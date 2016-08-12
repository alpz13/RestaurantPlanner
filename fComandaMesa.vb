Imports System
Imports System.Collections.Generic
Imports System.Drawing

Public Class fComandaMesa

    Dim lista, lista2 As List(Of Cliente)
    Dim prodTotal As List(Of Producto)
    Dim capacidad As Integer
    Dim m As Mesa
    Dim frmorden As fOrden
    Dim frmCM As fConsultaMesas
    Dim bola As Bitmap
    Dim sel As Boolean
    Dim folio As String


    Public Sub New(ByRef nuevo As Mesa, ByRef fCM As fConsultaMesas)

        MyBase.New()
        InitializeComponent()
        capacidad = nuevo.capacidadMax
        lista = nuevo.clientes
        m = nuevo
        lista2 = New List(Of Cliente)
        frmCM = fCM


    End Sub

    Private Sub fComandaMesa_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub

   
    Private Sub fComandaMesa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        vsbCliente.SmallChange = 10
        vsbCliente.LargeChange = 20
        sel = False
        'fillList(cmbRFC, "SELECT rfc FROM clientes WHERE visible=1 ORDER BY rfc ASC")
        fillList(cmbEstados, "select idestadomesa, descripcion from estadosmesa where visible=1")
        bola = New Bitmap(New Bitmap(Application.StartupPath & "\bolaverde.png"), New Size(10, 10))
        bola.MakeTransparent(Color.White)

        llenarCombo(cmbRFC, "SELECT rfc FROM clientes WHERE visible=1 ORDER BY rfc ASC")
        cmbRFC.Text = "GENERICO1"

        AddHandler cmbRFC.TextChanged, AddressOf cmbRFC_TextChanged

        cmbEstados.SelectedIndex = m.idEstadoMesa - 1

        AddHandler cmbEstados.SelectedIndexChanged, AddressOf cmbEstados_SelectedIndexChanged
        prodTotal = New List(Of Producto)
        

    End Sub


    Private Sub tabClients_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabClients.MouseClick

        Dim prodInd As New List(Of String)
        Dim total As Integer = 0

        For Each i As Cliente In lista

            If New Rectangle(e.X - 5, e.Y - 5, 10, 10).IntersectsWith(i.getBounds()) Then

                If Seleccionado.Checked Then
                    i.seleccionado = Not i.seleccionado
                End If


                lstComida.Items.Clear()
                If i.productos.Count > 0 Then
                    For Each j As Producto In i.productos
                        lstComida.Items.Add(j.nombre & "    $ " & j.precioActual & ".00    " & j.cantidad)
                        total += j.precioActual * j.cantidad
                    Next

                    lstComida.Items.Add("TOTAL   $" & total & ".00")
                End If
                lblMensajes.Text = "Comanda de Cliente " & i.numero
                tabClients.Invalidate()
                Return
            End If
        Next




    End Sub

    Private Sub tabClients_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabClients.MouseDoubleClick

        For Each i As Cliente In lista

            If New Rectangle(e.X - 5, e.Y - 5, 10, 10).IntersectsWith(i.getBounds()) Then


                frmCM.frmMain.frmOrden.ordenado = i.productos
                frmCM.frmMain.frmOrden.seleccionado = Nothing
                frmCM.frmMain.frmOrden.Show()
                frmCM.frmMain.frmOrden.tabCliente.Invalidate()
                frmCM.frmMain.frmOrden.BringToFront()
                Return
            End If
        Next

        tabClients.Invalidate()

    End Sub

    Public Sub agregaclientes()
        If lista.Count < capacidad Then

            If lista.Count > 0 Then

                lista.Add(New Cliente(lista.Last.numero + 1, 10, 10 + (lista.Count - 1) * 35, tabClients.Width - 10))
            Else

                lista.Add(New Cliente(1, 10, 10 + (lista.Count - 1) * 35, tabClients.Width - 10))
            End If

            vsb_MaxChanged(vsbCliente, tabClients, lista.Count)

            If lista.Count > 1 Then
                lista.Last.y = 35 + lista.ElementAt(lista.Count - 2).y
            Else
                lista.Last.y = 10
            End If
        Else

            MsgBox("La capacidad de la mesa es de " & capacidad)
        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        agregaclientes()
    End Sub

    Private Sub btnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresar.Click
        Me.Hide()

    End Sub

    Private Sub btnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagar.Click
       

        Dim total As Integer = 0
        Dim lprod As New List(Of Producto)

        For Each i As Cliente In lista

            If i.seleccionado Then
                lista2.Add(i)
            End If
        Next

        If lista2.Count > 0 Then
            soloSeleccionado(lprod, lista2)

            For Each i As Producto In lprod

                total += i.precioActual * i.cantidad
            Next

            Dim r As Integer
            r = MsgBox("Finalizado con un total de $ " & total & ".00       ¿Pagar y registrar con el RFC: " _
                           & cmbRFC.Text & "?", vbYesNo + vbQuestion)
            If r = vbYes Then

                For Each k As Producto In lprod

                    execute("INSERT INTO comanda VALUES ('" & cmbRFC.Text & "', " & k.idProducto & ", getdate(), '" & folio & "', " _
                            & k.precioActual & ", " & k.cantidad & ", " & m.idMesa & ")")
                Next

                While lista2.Count > 0

                    lista.Remove(lista2.First)
                    lista2.RemoveAt(0)
                End While

                reOrdena()

                Dim s, aux As String
                Dim num As Integer
                


               
                s = cadenaChica(m.idMesa) & m.idMesa
                aux = folio
                num = Integer.Parse(aux.Substring(3, 4)) + 1
                s += cadenaGrande(num) & num
                folio = s
                execute("UPDATE mesa set folio='" & folio & "' where idmesa=" & m.idMesa)
                Me.Text = "Mesa " & m.idMesa & " Folio " & folio

                End If

                lista2.Clear()
            tabClients.Invalidate()
            Else

                MsgBox("No hay clientes seleccionados")
            End If

    End Sub

    Public Sub removeProd()

        For Each i As Cliente In lista2

            lista.ElementAt(lista.IndexOf(i)).productos.Clear()

        Next

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Dim i As Integer = 0
        Dim b As Boolean = False

        For Each a As Cliente In lista
            If a.seleccionado Then
                b = True
            End If
        Next

        If b Then
            If lista.Count > 0 Then
                While i < lista.Count

                    If lista.ElementAt(i).seleccionado Then
                        If lista.ElementAt(i).productos.Count > 0 Then

                            Dim r As Integer
                            r = MsgBox("Cliente " & lista.ElementAt(i).numero & " todavia tiene productos " & _
                                       "¿Eliminar?", vbYesNo + vbQuestion)
                            If r = vbYes Then

                                lista.RemoveAt(i)
                                i -= 1

                            End If

                        Else
                            lista.RemoveAt(i)
                            i -= 1

                        End If

                    End If

                    i += 1
                End While


                todaLaMesa()
                lblMensajes.Text = "Comanda de toda la mesa"
                reOrdena()
                vsb_MaxChanged(vsbCliente, tabClients, lista.Count)
                tabClients.Invalidate()

            End If

        Else
            MsgBox("No hay clientes seleccionados")
        End If


    End Sub

    Private Sub cmbEstados_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        execute("UPDATE mesa set idestadomesa=" & cmbEstados.SelectedIndex + 1 & " where idmesa=" & m.idMesa)
        m.ImEstado = frmCM.mEstados(cmbEstados.SelectedValue - 1)
        m.idEstadoMesa = cmbEstados.SelectedValue

    End Sub

    Private Function cadenaGrande(ByVal valor As Integer) As String

        If valor < 10 Then
            Return "000"
        End If

        If valor < 100 Then
            Return "00"
        End If

        If valor < 1000 Then
            Return "0"
        End If

        Return ""

    End Function

    Private Function cadenaChica(ByVal valor As Integer) As String

        If valor < 10 Then
            Return "00"
        End If

        If valor < 100 Then
            Return "0"
        End If

        Return ""

    End Function

    Private Sub btnComenzar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComenzar.Click

        Dim s, aux As String
        Dim num As Integer
        Dim tFolio As DataTable = getDataTable("SELECT folio from comanda where idmesa=" & m.idMesa & _
                                               " order by folio desc")


        If tFolio IsNot Nothing Then

            s = cadenaChica(m.idMesa) & m.idMesa
            aux = tFolio.Rows(0).Item(0)
            num = Integer.Parse(aux.Substring(3, 4)) + 1
            s += cadenaGrande(num) & num

            folio = s


        Else

            s = cadenaChica(m.idMesa) & m.idMesa & "0001"
            folio = s

        End If

        execute("update mesa set folio='" & folio & "' where idmesa=" & m.idMesa)

        Me.Text = "Mesa " & m.idMesa & " Folio " & folio
        Me.Invalidate()
        controles(True)

    End Sub

    Private Sub btnTerminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTerminar.Click


        If lista.Count = 0 Then
            folio = "0"
            Me.Text = "Mesa " & m.idMesa
            Me.Invalidate()
            execute("update mesa set folio='0' where idmesa=" & m.idMesa)
            controles(False)
        Else
            MsgBox("Existen clientes en la mesa")
        End If


    End Sub

    Public Sub controles(ByVal b As Boolean)

        btnComenzar.Enabled = Not b
        btnAgregar.Enabled = b
        btnPagar.Enabled = b
        Seleccionado.Enabled = b
        btnFacturar.Enabled = b
        btnTerminar.Enabled = b
        btnEliminar.Enabled = b
        cmbRFC.Enabled = b
        chkTodo.Enabled = False

    End Sub

    Private Sub btnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide.Click

        execute("DELETE FROM contienenClientes where idmesa=" & m.idMesa)
        Dim i, j As Integer
        i = 0

        While i < lista.Count
            j = 0

            If lista.ElementAt(i).productos.Count = 0 Then
                execute("INSERT INTO contienenclientes VALUES(" & m.idMesa & ", " & i + 1 & ", 0, 0)")
            Else

                While j < lista.ElementAt(i).productos.Count

                    execute("INSERT INTO contienenclientes VALUES(" & m.idMesa & ", " & i + 1 & ", " & _
                            lista.ElementAt(i).productos.ElementAt(j).idProducto & ", " & _
                            lista.ElementAt(i).productos.ElementAt(j).cantidad & ")")

                    j += 1
                End While
            End If

            i += 1
        End While


        Me.Hide()
    End Sub

    Private Sub btnFacturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacturar.Click

        frmCM.frmMain.frmReportes.Show()

    End Sub

    Public Sub vsb_MaxChanged(ByRef vsb As VScrollBar, ByRef tab As TabPage, ByVal i As Integer)

        vsb.Maximum = (35 * i) + 50

        If vsb.Maximum - tab.Height > 0 Then

            vsb.Maximum -= tab.Height
            vsb.Value = vsb.Maximum
            vsb.Visible = True
            vsb.Enabled = True

        Else
            vsb.Value = 0
            vsb.Maximum = 0
            vsb.Visible = False
            vsb.Enabled = False

        End If

        tab.Invalidate()

    End Sub

    Private Sub vsbCliente_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles vsbCliente.ValueChanged

        For Each i As Cliente In lista

            i.dy = vsbCliente.Value

        Next

        tabClients.Invalidate()

    End Sub

    Private Sub tabClients_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles tabClients.Paint

        For Each i As Cliente In lista

            i.dibuja(e.Graphics)
            i.dibujaNombre(e.Graphics)

            If i.seleccionado Then
                i.dibujaVerde(e.Graphics, bola)
            End If

        Next

    End Sub

    Private Sub chkTodo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodo.CheckedChanged

        If lista.Count > 0 Then

            If chkTodo.Checked Then

                For Each i As Cliente In lista

                    i.seleccionado = True
                Next

            Else

                For Each i As Cliente In lista

                    i.seleccionado = False
                Next

            End If

        Else

            chkTodo.Checked = False

        End If

        tabClients.Invalidate()

    End Sub

    Private Sub Seleccionado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Seleccionado.CheckedChanged

        If lista.Count > 0 Then

            If Seleccionado.Checked Then
                sel = True
                chkTodo.Enabled = True
            Else
                sel = False
                chkTodo.Enabled = False

                For Each i As Cliente In lista
                    i.seleccionado = False
                Next

            End If

        Else

            Seleccionado.Checked = False

        End If
        tabClients.Invalidate()

    End Sub

    Private Sub reOrdena()

        For i = 0 To lista.Count - 1

            lista.ElementAt(i).y = 10 + (i) * 35
            lista.ElementAt(i).numero = i + 1

        Next

    End Sub

  

    Private Sub cmbRFC_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)

        If cmbRFC.Text = "" Then

            cmbRFC.Items.Clear()
            llenarCombo(cmbRFC, "SELECT rfc FROM clientes WHERE visible=1 ORDER BY rfc ASC")


        Else

            If Not cmbRFC.Text.Contains("'") Then
                'cmbRFC.Items.Clear()
                'llenarCombo(cmbRFC, "SELECT rfc FROM clientes WHERE visible=1 and rfc like '" & cmbRFC.Text & "%' ORDER BY rfc ASC")
                cmbRFC.FindString(cmbRFC.Text)
                lblMensajes.Text = ""
            Else
                lblMensajes.Text = "Caracter invalido en RFC"
            End If

        End If

    End Sub

    Public Sub soloSeleccionado(ByRef prods As List(Of Producto), ByVal listaClientes As List(Of Cliente))


        Dim m, total As Integer
        total = 0

        For Each i As Cliente In listaClientes

            For Each j As Producto In i.productos

                m = existe(j, prods)

                If m <> -1 Then

                    prods.ElementAt(m).cantidad += j.cantidad

                Else

                    prods.Add(j.clone())
                    prods.Last.cantidad = j.cantidad
                End If

            Next

        Next

        lstComida.Items.Clear()

        For Each i As Producto In prods

            lstComida.Items.Add(i.nombre & "    $ " & i.precioActual & ".00    " & i.cantidad)
            total += i.precioActual * i.cantidad
        Next
        lstComida.Items.Add("TOTAL   $" & total & ".00")

    End Sub

    Public Sub todaLaMesa()

        Dim prods As New List(Of Producto)
        Dim m, total As Integer
        total = 0

        For Each i As Cliente In lista

            For Each j As Producto In i.productos

                m = existe(j, prods)

                If m <> -1 Then

                    prods.ElementAt(m).cantidad += j.cantidad

                Else

                    prods.Add(j)

                End If

            Next

        Next

        lstComida.Items.Clear()

        For Each i As Producto In prods

            lstComida.Items.Add(i.nombre & "    $ " & i.precioActual & ".00    " & i.cantidad)
            total += i.precioActual * i.cantidad
        Next

        lstComida.Items.Add("TOTAL   $" & total & ".00")
    End Sub

    Public Function existe(ByVal p As Producto, ByVal lista As List(Of Producto)) As Integer

        For i = 0 To lista.Count - 1

            If lista.ElementAt(i).idProducto = p.idProducto Then
                Return i
            End If

        Next

        Return -1

    End Function

    Private Sub lstComida_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstComida.Click

        todaLaMesa()
        lblMensajes.Text = "Comanda de toda la mesa"

    End Sub


    Public Sub verificaComanda()

        lista.Clear()
        Dim cat() As List(Of Producto) = frmCM.frmMain.frmOrden.categorias
        Dim f As String
        Dim idP, idTP As Integer
        Dim CClientes, prods As DataTable

        f = getDataTable("SELECT folio FROM mesa where idMesa=" & m.idMesa).Rows(0).Item(0)

        If Not f.Equals("0") Then

            folio = f

            Me.Text = "Mesa " & m.idMesa & " Folio " & folio
            Me.Invalidate()
            controles(True)
            CClientes = getDataTable("select distinct numeroCliente from contienenClientes where idmesa=" & m.idMesa)

            If CClientes IsNot Nothing Then

                Dim i, j As Integer
                i = 0
                While i < CClientes.Rows.Count
                    agregaclientes()
                    prods = getDataTable("select C.idproducto, C.cantidad, P.idTipoComida from contienenclientes C, Productos P" & _
                                         " where C.idproducto=P.idProducto and idmesa=" & m.idMesa & _
                                         " and numerocliente=" & i + 1 & " order by idproducto asc")

                    If prods IsNot Nothing Then
                        If Not prods.Rows(0).Item(0) = 0 Then
                            j = 0
                            While j < prods.Rows.Count
                                idP = prods.Rows(j).Item(0)
                                idTP = prods.Rows(j).Item(2)
                                lista.Last.productos.Add(cat(idTP - 1).ElementAt(indice(cat(idTP - 1), idP)).clone)

                                lista.Last.productos.Last.cantidad = prods.Rows(j).Item(1)

                                j += 1
                            End While
                            frmCM.frmMain.frmOrden.ordenado = lista.Last.productos
                            frmCM.frmMain.frmOrden.reordena(frmCM.frmMain.frmOrden.ordenado, 0)

                        End If
                    End If
                    i += 1
                End While

            End If

        Else
            folio = "0"
            Me.Text = "Mesa " & m.idMesa
            controles(False)
        End If

    End Sub

    Public Function indice(ByVal p As List(Of Producto), ByVal id As Integer) As Integer

        For i = 0 To p.Count - 1

            If p.ElementAt(i).idProducto = id Then

                Return i
            End If

        Next
        Return 0
    End Function
End Class