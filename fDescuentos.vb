Public Class fDescuentos

    Private Sub Descuentos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        modUtil.createConnection("orozco.qro.itesm.mx", "bdEquipo3", "bdEquipo3 ", "tsgrze-eht")
        modUtil.fillList(cmbProductos, "select p.Descripcion from productos p")
        modUtil.fillList(cmbDescuentos, "select d.idDescuentos from descuentos d")
    End Sub

    

    Private Sub fDescuentos_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel() = True
        Me.Hide()
    End Sub

    
    Private Sub btnRegresar_Click(sender As System.Object, e As System.EventArgs) Handles btnRegresar.Click
        Me.Hide()
    End Sub
    
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        modUtil.execute("update productos set idDescuento = " & cmbDescuentos.SelectedValue & " where idproduto = " & cmbProductos.SelectedValue)
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        modUtil.execute("update productos set idDescuento = '0%' where idproduto = " & cmbProductos.SelectedValue)
    End Sub
End Class