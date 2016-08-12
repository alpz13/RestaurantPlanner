Public Class fClientes
    Dim fVentanaciudad As fCiudades


    Private Sub fClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        fillList(cmbEstado, "select e.idEstados, e.Estado from Estados e")
        fillList(cmbRFC, "select clientes.RFC from clientes where clientes.visible = 1")
        fillList(cmbCiudad, "select c.idCiudad, c.Ciudad from Ciudades c,Estados e where e.idestados = c.idestados and e.idEstados = '" & cmbEstado.SelectedValue & "'")


    End Sub




    Private Sub btnAgregarCiudad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCiudad.Click
        If fVentanaciudad Is Nothing Then
            fVentanaciudad = New fCiudades
            fVentanaciudad.MdiParent = fMain
        End If

        fVentanaciudad.Show()
    End Sub

    Private Sub fClientes_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel() = True
        Me.Hide()
    End Sub

    Private Sub cmbEstado_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbEstado.SelectionChangeCommitted
        modUtil.fillList(cmbCiudad, "select c.idCiudad, c.Ciudad from Ciudades c,Estados e where e.idestados = c.idestados and e.idEstados = '" & cmbEstado.SelectedValue & "'")
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim RFC As String
        RFC = cmbRFC.SelectedText
        'MsgBox("select cli.Nombre,cli.Direccion,cli.Colonia,cli.CP from clientes cli where cli.RFC like '" & RFC.Text & "%'")

        showData("select cli.rfc, cli.Nombre,cli.Direccion,cli.Colonia,cli.CP from clientes cli where cli.RFC like '" & RFC & "%'", Me)
        modUtil.fillList(cmbCiudad, "select c.idCiudad, c.Ciudad from Ciudades c,Clientes cli where cli.idCiudad=c.idCiudad and cli.rfc like '" & cmbRFC.Text & "%'")
        modUtil.fillList(cmbEstado, "select e.idEstados, e.Estado from Estados e,Ciudades c where e.idEstados=c.idCiudad and c.idCiudad='" & cmbCiudad.SelectedValue & "'")
        errores.Text = "."


    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim visible As Integer
        visible = 1


        Dim comboCiudad As Integer
        comboCiudad = cmbCiudad.SelectedValue

        If Colonia.Text <> "" Or Direccion.Text <> "" Or Nombre.Text <> "" Or CP.Text <> "" Or cmbRFC.SelectedText <> "" Then
            modUtil.execute("insert into clientes values('" & cmbRFC.Text _
               & "','" & Nombre.Text _
             & "','" & Direccion.Text _
                 & "','" & Colonia.Text _
                 & "'," & CP.Text _
                 & "," & comboCiudad _
                 & "," & visible & ")")

            errores.Text = "Datos agregados a Clientes correctamente"

        Else
            errores.Text = "Falta algun campo por llenar"
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        modUtil.execute("update clientes set visible = 0 where rfc =" & cmbRFC.Text)
        Call fClientes_Load(sender, e)
        errores.Text = "Cliente eliminado correctamente"

    End Sub

    Private Sub btnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresar.Click
        Me.Hide()
    End Sub



    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        Nombre.Text = ""
        Direccion.Text = ""
        Colonia.Text = ""
        CP.Text = ""
        cmbEstado.SelectedValue = -1
        cmbCiudad.SelectedValue = -1
        errores.Text = "."

    End Sub
    Private Sub txtCP_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CP.KeyPress
        If (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            Exit Sub
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Nombre.KeyPress
        If (Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar)) Then
            Exit Sub
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cmbRFC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbRFC.KeyPress
        If (Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsNumber(e.KeyChar)) Then
            Exit Sub
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Direccion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Direccion.KeyPress
        If (Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsNumber(e.KeyChar)) Then
            Exit Sub
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Colonia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Colonia.KeyPress
        If (Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsNumber(e.KeyChar)) Then
            Exit Sub
        Else
            e.Handled = True
        End If
    End Sub
End Class