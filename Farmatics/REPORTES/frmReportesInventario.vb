Public Class frmReportesInventario
    Dim dataset As New Reportes

    Private Sub frmReportesClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataset.Productos()
        ProductosBindingSource.DataSource = dataset.tablas
        ProductosBindingSource.DataMember = "Productos"
        ReportViewer1.RefreshReport()
    End Sub
End Class