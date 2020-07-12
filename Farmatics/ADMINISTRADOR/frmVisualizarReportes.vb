Imports Microsoft.Reporting.WinForms

Public Class frmVisualizarReportes

    Public Sub Parametros(ByVal parametros As ReportParameter(), ByVal dataset As DataSet)
        ReportViewer1.LocalReport.SetParameters(parametros)
        ProductoBindingSource.DataSource = dataset
        ProductoBindingSource.DataMember = "Table1"
        ReportViewer1.RefreshReport()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        ReportViewer1.RefreshReport()
    End Sub

End Class