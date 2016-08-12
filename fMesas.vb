Public Class fMesas

    Dim n As Integer
    Dim fm As fMain

  

    Public Sub New(ByRef f As fMain)

        InitializeComponent()
        fm = f


    End Sub

    Private Sub fMesas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        e.Cancel = True
        Me.Hide()

    End Sub

  
    Private Sub fMesas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

       

        fillList(cmbTipoMesa, "select t.idTipo,t.Descripcion  from TipoMesa t")
        fillList(cmbEstadoMesa, "select idEstadoMesa, Descripcion from estadosMesa")
        n = getDataTable("SELECT idMesa FROM Mesa").Rows.Count

        cmbEstadoMesa.SelectedValue = -1
        cmbTipoMesa.SelectedValue = -1

        lblTotal.Text = "Existen " & n & " mesas en registro"

    End Sub

    'Private Sub fMesas_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
    '    e.Cancel() = True
    '    Me.Hide()
    'End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        If numeroAceptable(idMesaText.Text, n) Then
            txtCapacidad.Text = getDataTable("select capacidad from Mesa where idMesa =" & idMesaText.Text).Rows(0).Item(0).ToString
            cmbTipoMesa.SelectedValue = getDataTable("select idTipo from Mesa where idMesa =" & idMesaText.Text).Rows(0).Item(0).ToString
            cmbEstadoMesa.SelectedValue = getDataTable("select idestadomesa from mesa where idmesa=" & idMesaText.Text).Rows(0).Item(0).ToString

        Else
            lblMensajes.Text = "Número de mesa estaba fuera de rango"
            idMesaText.Text = ""

        End If

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click



        If cmbEstadoMesa.SelectedValue > 0 And cmbTipoMesa.SelectedValue > 0 And numeroAceptable(txtCapacidad.Text, 50) Then

            n = n + 1

            fm.frmConsultaMesa.addMesa(n, cmbTipoMesa.SelectedValue, txtCapacidad.Text, cmbEstadoMesa.SelectedValue)
            fm.frmConsultaMesa.comandas.Add(New fComandaMesa(fm.frmConsultaMesa.lista.Last, fm.frmConsultaMesa))

            lblMensajes.Text = "Mesa " & n & " agregada exitosamente"
            lblTotal.Text = "Existen " & n & " mesas en registro"

        Else

            lblMensajes.Text = "Falta especificar valores uno o mas campos"


        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        If numeroAceptable(idMesaText.Text, n) Then

            If getDataTable("SELECT folio from mesa where idmesa=" & idMesaText.Text).Rows(0).Item(0).ToString = 0 Then

                fm.frmConsultaMesa.eliminaMesa(idMesaText.Text)

                lblMensajes.Text = "Mesa " & idMesaText.Text & " eliminada exitosamente"
                'fMain.frmConsultaMesa.cargarMesas()
                cmbEstadoMesa.SelectedValue = getDataTable("select idestadomesa from mesa where idmesa=" & idMesaText.Text).Rows(0).Item(0).ToString



            Else

                lblMensajes.Text = "La mesa " & idMesaText.Text & " no está disponible"

            End If
        Else
            lblMensajes.Text = "Número de mesa estaba fuera de rango"
            idMesaText.Text = ""
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        idMesaText.Text = ""
        cmbEstadoMesa.SelectedValue = -1
        cmbTipoMesa.SelectedValue = -1
        txtCapacidad.Text = ""

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click


        If cmbEstadoMesa.SelectedValue > 0 And cmbTipoMesa.SelectedValue > 0 _
                              And numeroAceptable(txtCapacidad.Text, 50) And numeroAceptable(idMesaText.Text, n) Then

            If getDataTable("SELECT folio from mesa where idmesa=" & idMesaText.Text).Rows(0).Item(0).ToString = 0 Then

                fm.frmConsultaMesa.modificaMesa(idMesaText.Text, cmbTipoMesa.SelectedValue, txtCapacidad.Text, cmbEstadoMesa.SelectedValue)

                lblMensajes.Text = "La mesa " & idMesaText.Text & " ha sido modificada"

            Else

                lblMensajes.Text = "La mesa " & idMesaText.Text & " no está disponible"

            End If

        Else

            lblMensajes.Text = "Falta especificar valores uno o mas campos"

        End If
    End Sub

    Private Sub idMesaText_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles idMesaText.KeyPress
        If (Char.IsControl(e.KeyChar) Or Char.IsNumber(e.KeyChar)) Then
            Exit Sub
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCapacidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCapacidad.KeyPress
        If (Char.IsControl(e.KeyChar) Or Char.IsNumber(e.KeyChar)) Then
            Exit Sub
        Else
            e.Handled = True
        End If
    End Sub

End Class