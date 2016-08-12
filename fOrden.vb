Imports System
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports System.Drawing

Public Class fOrden

    Public categorias() As List(Of Producto)
    Public ordenado As List(Of Producto)
    Public seleccionado As Producto
    Dim sImagen As Bitmap
    Dim k, ancho As Integer


    Public Sub New()

        MyBase.New()
        InitializeComponent()

    End Sub

    Private Sub fOrden_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        vsbCliente.SmallChange = 10
        vsbCliente.LargeChange = 20
        ordenado = New List(Of Producto)
        cargarCategorias()
        k = 0

        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)

        btnMas.Image = New Bitmap(New Bitmap(Application.StartupPath & "\mas.png"), New Size(32, 32))
        btnMenos.Image = New Bitmap(New Bitmap(Application.StartupPath & "\minus.jpg"), New Size(32, 32))
        sImagen = New Bitmap(New Bitmap(Application.StartupPath & "\bolaverde.png"), New Size(10, 10))
        sImagen.MakeTransparent(Color.White)


        Me.Dock = DockStyle.Right


    End Sub

    Public Sub cargarCategorias()

        Dim tabla, tablaProd As DataTable
        Dim i, j, idproducto, precioanual As Integer
        Dim nombre, descripcion, idDescuento, filename As String
        Dim imagen As Bitmap = Nothing
        Dim data() As Byte
        Dim fs As FileStream
        seleccionado = Nothing

        filename = ""

        tabla = getDataTable("SELECT descripcion FROM tipoComida")
        ReDim categorias(tabla.Rows.Count - 1)


        For i = 0 To tabla.Rows.Count - 1

            tabOrden.TabPages.Add(New TabPage(tabla.Rows(i).Item(0).ToString) With {.BackColor = Color.White})

            tabOrden.TabPages(i).Controls.Add(New VScrollBar With {.Name = "vScrollBar" & tabla.Rows(i).Item(0).ToString,
                                                                   .Dock = DockStyle.Right,
                                                                   .Minimum = 0,
                                                                   .Maximum = 0,
                                                                   .Value = 0,
                                                                   .SmallChange = 10,
                                                                   .LargeChange = 20,
                                                                   .Visible = False,
                                                                   .Enabled = False})

            AddHandler DirectCast(tabOrden.TabPages(i).Controls(0), VScrollBar).ValueChanged, AddressOf vsb_ValueChanged
            AddHandler tabOrden.TabPages(i).Paint, AddressOf tabs_Paint
            AddHandler tabOrden.TabPages(i).MouseClick, AddressOf tabs_MouseClick


            tablaProd = getDataTable("SELECT * " & _
                                        "FROM productos " & _
                                        "WHERE idtipocomida=" & i + 1)



            categorias(i) = New List(Of Producto)
            If tablaProd IsNot Nothing Then

                j = 0
                While j < tablaProd.Rows.Count

                    idproducto = tablaProd.Rows(j).Item(0).ToString
                    nombre = tablaProd.Rows(j).Item(1)
                    descripcion = tablaProd.Rows(j).Item(2)
                    precioanual = tablaProd.Rows(j).Item(3).ToString

                    If tablaProd.Rows(j).Item(4) IsNot System.DBNull.Value Then
                        Try

                            data = tablaProd.Rows(j).Item(4)

                            filename = "temp" & i & j & ".jpg"

                            fs = New FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write)

                            fs.Write(data, 0, UBound(data))
                            fs.Close()

                            imagen = New Bitmap(Application.StartupPath & "\" & filename)
                            imagen = New Bitmap(imagen, New Size(32, 32))

                            Kill(filename)

                        Catch ex As Exception

                        End Try

                    Else


                    End If


                    idDescuento = tablaProd.Rows(j).Item(5)

                    

                    categorias(i).Add(New Producto(nombre, descripcion, idproducto, precioanual,
                                                   idDescuento, 10, 10 + j * 35, imagen))

                    j = j + 1

                End While

                vsb_MaxChanged(DirectCast(tabOrden.TabPages(i).Controls(0), VScrollBar), tabOrden.TabPages(i), categorias(i).Count)
                DirectCast(tabOrden.TabPages(i).Controls(0), VScrollBar).Value = 0

            End If

        Next

    End Sub

    Private Sub tabs_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)

        If categorias(k).Count > 0 Then

            For Each i As Producto In categorias(k)
                i.dibuja(e.Graphics)
            Next

        End If

    End Sub

    Private Sub tabs_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

        Dim m As Integer

        For Each i As Producto In categorias(k)

            If New Rectangle(e.X - 1, e.Y - 1, 2, 2).IntersectsWith(i.getBounds()) Then

                m = existe(i, ordenado)

                If m <> -1 Then

                    ordenado.Item(m).cantidad += 1

                Else

                    ordenado.Add(i.clone)
                    vsb_MaxChanged(vsbCliente, tabCliente, ordenado.Count)

                    If ordenado.Count > 1 Then
                        ordenado.Last.y = 35 + ordenado.ElementAt(ordenado.Count - 2).y
                    Else
                        ordenado.Last.y = 10
                    End If



                End If

            End If
        Next

    End Sub

    Private Sub tabCliente_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabCliente.MouseClick

        If ordenado.Count > 0 Then
            For Each i As Producto In ordenado

                If New Rectangle(e.X - 5, e.Y - 5, 10, 10).IntersectsWith(i.getBounds()) Then

                    seleccionado = i
                    tabCliente.Invalidate()
                    lblMensajes.Text = "Seleccionado: " & i.descripcion
                    Return
                End If

            Next


        End If


        seleccionado = Nothing
        lblMensajes.Text = ""

    End Sub

    Private Sub tabCliente_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles tabCliente.Paint

        If seleccionado IsNot Nothing Then

            seleccionado.dibujaSelected(e.Graphics, sImagen)

        End If

        If ordenado.Count > 0 Then

            For Each i As Producto In ordenado
                i.dibuja2(e.Graphics)
            Next

        End If

    End Sub

    Private Sub btnMenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenos.Click

        If seleccionado IsNot Nothing Then

            Dim i As Integer = ordenado.IndexOf(seleccionado)

            If ordenado.ElementAt(i).cantidad > 1 Then

                ordenado.ElementAt(i).cantidad -= 1

            Else

                ordenado.RemoveAt(i)
                vsb_MaxChanged(vsbCliente, tabCliente, ordenado.Count)
                seleccionado = Nothing
                lblMensajes.Text = ""
                reordena(ordenado, i)

            End If

        End If

        tabCliente.Invalidate()

    End Sub

    Private Sub btnMas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMas.Click

        If seleccionado IsNot Nothing Then

            ordenado.ElementAt(ordenado.IndexOf(seleccionado)).cantidad += 1
            tabCliente.Invalidate()

        End If

    End Sub

    Private Sub btnRetirar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetirar.Click

        Dim i As Integer

        If seleccionado IsNot Nothing Then

            i = ordenado.IndexOf(seleccionado)
            ordenado.RemoveAt(i)
            vsb_MaxChanged(vsbCliente, tabCliente, ordenado.Count)
            seleccionado = Nothing
            reordena(ordenado, i)
            tabCliente.Invalidate()
            lblMensajes.Text = ""

        End If

    End Sub

    Public Function existe(ByVal p As Producto, ByVal lista As List(Of Producto)) As Integer

        If lista.Count > 0 Then

            For i = 0 To lista.Count - 1

                If lista.ElementAt(i).idProducto = p.idProducto Then
                    Return i
                End If

            Next

        End If

        Return -1

    End Function

    Public Sub reordena(ByRef lista As List(Of Producto), ByVal j As Integer)

        If lista.Count > 0 Then

            If j = 0 Then
                lista.First.y = 10
                j = 1
            End If

            For i = j To lista.Count - 1

                lista.ElementAt(i).y = 35 + lista.ElementAt(i - 1).y

            Next

        End If

    End Sub

    Private Sub vsb_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)

        For Each i As Producto In categorias(k)

            i.dy = DirectCast(tabOrden.TabPages(k).Controls(0), VScrollBar).Value

        Next

        tabOrden.TabPages(k).Invalidate()

    End Sub

    Private Sub vsbCliente_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles vsbCliente.ValueChanged

        For Each i As Producto In ordenado

            i.dy = vsbCliente.Value

        Next

        tabCliente.Invalidate()

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

    Private Sub tabOrden_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabOrden.SelectedIndexChanged
        k = tabOrden.SelectedIndex
    End Sub

    Private Sub btnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresar.Click
        Me.Hide()
    End Sub

End Class

