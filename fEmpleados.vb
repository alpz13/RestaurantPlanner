Public Class fEmpleados


    Public ventanaRoles As New fRoles
    Private Sub btnRoles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoles.Click

        ventanaRoles.MdiParent = LoginScreen.main
        ventanaRoles.Show()

    End Sub

    Private Sub fEmpleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        fillList(cmbPuesto, "select r.idRol, r.Rol from Rol r ")
        fillList(cmbRol, "select r.idRol, r.Rol from Rol r ")
        fillList(Nomina, "select empleados.nomina from empleados where empleados.visible = 1")

    End Sub


    Private Sub btnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresar.Click
        Me.Hide()

    End Sub

    Private Sub fEmpleados_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel() = True
        Me.Hide()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If Not Nomina.Text = "" Then
            Try
                modUtil.showData("select e.Nombre, e.Direccion, e.Telefono, e.Correo from Empleados e, Usuarios u, Rol r where e.Nomina like '" & Nomina.Text & "%'", Me)
                modUtil.fillList(cmbPuesto, "select r.idRol, r.Rol from Rol r, Usuarios u, Empleados e where r.idRol = u.idRol and u.idUsuario = e.idUsuario and e.idUsuario = '" & Nomina.Text & "'")
            Catch ex As Exception
                errores.Text = "No se encontró el valor."
            End Try
        Else
            errores.Text = "Coloca el número de nómina para hacer la búsqueda."
        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim visible As Integer
        visible = 1

        If Nomina.SelectedText <> "" Or Direccion.Text <> "" Or Telefono.Text <> "" Or Nombre.Text <> "" Or Correo.Text <> "" Then
            modUtil.execute("insert into empleados values(" & Nomina.Text _
               & ",'" & Nombre.Text _
             & "','" & Direccion.Text _
                 & "', " & Telefono.Text _
                 & ",'" & Correo.Text _
                 & "'," & Nomina.Text _
                 & "," & visible & ")")

            errores.Text = "Datos de empleados agregados correctamente"

        Else
            errores.Text = "Faltan campos por llenar"
        End If

            txtUsuario.Text = Nomina.Text
            cmbRol.SelectedValue = cmbPuesto.SelectedValue

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        errores.Text = "."
        Nomina.Text = ""
        Nombre.Text = ""
        Direccion.Text = ""
        Correo.Text = ""
        Telefono.Text = ""
        cmbPuesto.SelectedValue = 0


    End Sub

    Private Sub cmbPuesto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPuesto.SelectedIndexChanged

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        modUtil.execute("update empleados set visible = 0 where nomina =" & Nomina.Text)
        errores.Text = "Empleado eliminado correctamente"
        Call fEmpleados_Load(sender, e)

    End Sub


    Private Sub txtUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.TextChanged
        txtUsuario.Text = Nomina.Text
    End Sub

    Private Sub txtTelefono_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Telefono.KeyPress
        If (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            Exit Sub
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNomina_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            Exit Sub
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnAgregaUs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregaUs.Click
        If txtContrasena.Text <> "" Or txtRecordatorio.Text <> "" Then
            modUtil.execute("insert into usuarios values (" & txtUsuario.Text _
                            & ",'" & txtContrasena.Text _
                            & "','" & txtRecordatorio.Text _
                            & "'," & cmbRol.SelectedValue & ")")
            errores.Text = "Datos del usuario agregados correctamente"
        Else
            errores.Text = "Faltan campos por llenar"
        End If

        Call fEmpleados_Load(sender, e)

    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Nombre.KeyPress
        If (Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
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

    Private Sub Correo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Correo.KeyPress
        If (Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsNumber(e.KeyChar)) Then
            Exit Sub
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Nomina_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Nomina.KeyPress
        If (Char.IsControl(e.KeyChar) Or Char.IsNumber(e.KeyChar)) Then
            Exit Sub
        Else
            e.Handled = True
        End If
    End Sub
End Class