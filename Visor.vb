Public Class Visor

    Dim user As String = "bdEquipo3"
    Dim pass As String = "tsgrze-eht"

    Public Sub prepareReport(ByVal query As String)
        Dim report As New rptVentas
        report.SetDataSource(getDataTable(query))
        report.SetDatabaseLogon(user, pass)
        crvViewer.ReportSource = report
    End Sub
    Public Sub prepareReport2(ByVal factura As String, ByVal subfactura As String)


        Dim report As New rptFactura2
        report.SetDataSource(getDataTable(subfactura))
        report.SetDatabaseLogon(user, pass)
        report.Subreports.Item("Cliente").SetDataSource(getDataTable(factura))
        crvViewer.ReportSource = report
    End Sub
  
   
    Private Sub crvViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crvViewer.Load

    End Sub
End Class