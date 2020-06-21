Imports System.Data.SqlClient
Public Class frmLogin

    Dim datos As List(Of String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        MsgBox("¿Seguro que desea salir de la plataforma?", MsgBoxStyle.OkOnly)
        Me.Close()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click

        datos = Conexiones.ObtenerDatos("Empleados", "WHERE CEDULA ='" & TextBox1.Text & "'")
        If datos.Item(10) = TextBox2.Text Then
            Me.Hide()
            My.Forms.frmCaja.Show()
        End If

    End Sub

    Public Function Usuario()
        Return New Empleado(datos)
    End Function

End Class
