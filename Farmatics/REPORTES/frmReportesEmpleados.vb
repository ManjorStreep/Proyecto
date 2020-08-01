Public Class frmReportesEmpleados
    Dim dataset As New Reportes

    Private Sub frmReportesClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataset.Empleados()
        EmpleadosBindingSource.DataSource = dataset.tablas
        EmpleadosBindingSource.DataMember = "Empleados"
        ReportViewer1.RefreshReport()
    End Sub
End Class