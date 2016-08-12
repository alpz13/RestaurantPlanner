Public Class fReportes

    Private Sub fReportes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        fillList(cmbProducto, "select p.idProducto,p.Nombre from Productos p")
        fillList(cmbRFC, "select c.RFC, c.RFC from clientes c")

        AddHandler cmbRFC.SelectedIndexChanged, AddressOf cmbRFC_TextChanged
        cmbRFC.SelectedIndex = 0
    End Sub

    Private Sub fReportes_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel() = True
        Me.Hide()

    End Sub

    Private Function getQuery() As String
        Dim query As String
        query = "SELECT p.idProducto, p.Nombre,p.PrecioAnual,c.PrecioVenta, c.Cantidad,(c.cantidad * c.PrecioVenta) as Total FROM Comanda c, Productos p where c.idProducto=p.idproducto "

        If chkProducto.Checked Then
            query &= "AND p.idProducto = " & cmbProducto.SelectedValue & ""
        End If
        If (dtpDesde.Value < dtpHasta.Value) Then
            query &= "AND c.Fecha between " & modUtil.sqlFormat(dtpDesde.Value) & " AND " & modUtil.sqlFormat(dtpHasta.Value) & " "
        End If
        If (txtMayor.Text <> "") Then
            query &= "AND c.Cantidad > " & txtMayor.Text & ""
        End If
        If (txtMenor.Text <> "") Then
            query &= "AND c.Cantidad < " & txtMenor.Text & ""
        End If
        If (txtEntre.Text <> "" And txtHasta.Text <> "") Then
            query &= "AND c.Cantidad BETWEEN " & txtEntre.Text & " AND " & txtHasta.Text & ""
        End If

        Return query
    End Function
    Private Function getFactura() As String
        Dim factura As String

        factura = "select cli.RFC,cli.Nombre,cli.Direccion,cli.Colonia,ci.Ciudad,e.Estado from Clientes cli, Estados e,Ciudades ci where cli.idCiudad = ci.idCiudad and ci.idEstados = e.idEstados and cli.RFC = '" & cmbRFC.Text & "'"

        Return factura
    End Function
    Private Function getsubfactura() As String
        Dim subfactura As String
        subfactura = "select co.idproducto, p.Nombre,co.PrecioVenta,co.Cantidad from Productos p, Comanda co where co.idProducto = p.idProducto and co.Folio = '" & cmbFolio.Text & "'"
        Return subfactura
    End Function

    Private Sub cboReporte_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboReporte.SelectedIndexChanged

        Try
            If cboReporte.Text = "Factura" Then
                Panel2.Show()
                Panel1.Hide()
            End If
            If cboReporte.Text = "Consulta Genérica" Then
                Panel1.Show()
                Panel2.Hide()
            End If
           
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkProducto_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkProducto.CheckedChanged
        cmbProducto.Enabled = chkProducto.Checked
    End Sub

    Private Sub btnReporte_Click(sender As System.Object, e As System.EventArgs) Handles btnReporte.Click
        Dim query As String = getQuery()
        Dim frmvisor As New Visor
        frmvisor.prepareReport(query)
        frmvisor.Show()


    End Sub

 
    Private Sub btnFactura_Click(sender As System.Object, e As System.EventArgs) Handles btnFactura.Click
        Dim factura As String = getFactura()
        Dim subfactura As String = getsubfactura()



        Dim frmVisor As New Visor
        frmVisor.prepareReport2(factura, subfactura)
        frmVisor.Show()
    End Sub

 
    Private Sub cmbMate_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbMate.SelectedIndexChanged
        pnlEntre.Hide()
        pnlMayor.Hide()
        pnlMenor.Hide()
        If cmbMate.Text = "Mayor A" Then
            pnlMayor.Show()
            pnlMenor.Hide()
            pnlEntre.Hide()
        End If
        If cmbMate.Text = "Menor A" Then
            pnlMayor.Hide()
            pnlMenor.Show()
            pnlEntre.Hide()
        End If
        If cmbMate.Text = "Entre" Then
            pnlEntre.Show()
            pnlMayor.Hide()
            pnlMenor.Hide()
        End If
    End Sub


    Private Sub Panel2_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub cmbRFC_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)

        cmbFolio.Items.Clear()
        llenarCombo(cmbFolio, "SELECT distinct folio from comanda where rfc='" & cmbRFC.Text & "' order by folio asc")

        If cmbFolio.Items.Count > 0 Then
            cmbFolio.SelectedIndex = 0
        End If

    End Sub
End Class