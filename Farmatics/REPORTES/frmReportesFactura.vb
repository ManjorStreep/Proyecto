Imports Microsoft.Reporting.WinForms

Public Class frmReportesFactura

    ' Esta funcion es la que se encarga de llenar los datos para la factura
    ' Recibe dos parametros, uno se encarga de rellenar los Parametros dentro del Reporte el cual es ReportParameters
    ' El otro es el dataset que se usara como fuente de datos
    Public Sub Parametros(ByVal parametros As ReportParameter(), ByVal dataset As DataSet)
        ReportViewer1.LocalReport.SetParameters(parametros)
        ProductoBindingSource.DataSource = dataset
        ProductoBindingSource.DataMember = "Factura"
        ReportViewer1.RefreshReport()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.RefreshReport()
    End Sub

End Class