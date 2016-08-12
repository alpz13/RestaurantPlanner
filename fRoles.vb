Public Class fRoles

    Private Sub btnPrivilegios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
       
    End Sub


 

    Private Sub fRoles_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        modUtil.createConnection("orozco.qro.itesm.mx", "bdEquipo3", "bdEquipo3 ", "tsgrze-eht")
        modUtil.fillList(cmbMaxId, "Select Max(idrol) from rol")

    End Sub

    Private Sub fRoles_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel() = True
        Me.Hide()
    End Sub

    Private Sub btnRegresar_Click(sender As System.Object, e As System.EventArgs) Handles btnRegresar.Click
        Me.Hide()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim nuevaId As Integer
        nuevaId = cmbMaxId.Text
        nuevaId = nuevaId + 1

        If txtRol.Text <> "" Then
            modUtil.execute("insert into rol values(" & nuevaId _
           & ",'" & txtRol.Text & "')")

            errores.Text = "Datos agregados correctamente"
        Else
            errores.Text = "Falta campo Rol por llenar"
        End If

        Call fRoles_Load(sender, e)

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If txtIdRol.Text <> "" Then
            modUtil.execute("delete from rol where idRol = " & txtIdRol.Text)

            errores.Text = "Datos eliminados correctamente"
        Else
            errores.Text = "Falta campo idRol por llenar"
        End If
    End Sub


    Private Sub txtIdRol_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdRol.KeyPress
        If (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            Exit Sub
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtRol_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRol.KeyPress
        If (Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            Exit Sub
        Else
            e.Handled = True
        End If
    End Sub
End Class