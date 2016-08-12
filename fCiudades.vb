Public Class fCiudades

   
    Dim nuevaId As Integer
    Private Sub fCiudades_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        modUtil.createConnection("orozco.qro.itesm.mx", "bdEquipo3", "bdEquipo3 ", "tsgrze-eht")
        modUtil.fillList(cmbEstado, "select e.idEstados, e.Estados from Estados e")
        modUtil.fillList(cmbMax, "Select max(idciudad) from ciudades")


    End Sub

   
    Private Sub btnRegresar_Click(sender As System.Object, e As System.EventArgs) Handles btnRegresar.Click
        Me.Hide()
    End Sub

    Private Sub fCiudades_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel() = True
        Me.Hide()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        nuevaId = cmbMax.Text
        nuevaId = nuevaId + 1

        Dim comboEstados As Integer
        comboEstados = cmbEstado.SelectedValue

        If txtCiudad.Text <> "" Then
            modUtil.execute("insert into ciudades values(" & nuevaId _
                       & ",'" & txtCiudad.Text _
                       & "'," & comboEstados & ")")

        Else
            MsgBox("Faltan campos por llenar")
        End If

        Call fCiudades_Load(sender, e)
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If txtId.Text <> "" Then
            modUtil.execute("delete from ciudades Where idCiudad = " & txtId.Text)

        Else
            MsgBox("Faltan llenar id a Eliminar")
        End If

    End Sub

    Private Sub txtId_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtId.KeyPress
        If (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            Exit Sub
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCiudad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCiudad.KeyPress
        If (Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            Exit Sub
        Else
            e.Handled = True
        End If
    End Sub

End Class