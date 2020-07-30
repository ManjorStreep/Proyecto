Public Class frmReportesClientes
    Dim dataset As New Reportes

    Private Sub frmReportesClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataset.Clientes()
        ProductoBindingSource.DataSource = dataset.tablas
        ProductoBindingSource.DataMember = "Clientes"
        ReportViewer1.RefreshReport()
    End Sub
End Class