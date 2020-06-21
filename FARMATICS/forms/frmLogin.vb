Imports System.Data.SqlClient
Public Class frmLogin
    Dim x As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        MsgBox("¿Seguro que desea salir de la plataforma?", MsgBoxStyle.OkOnly)
        Me.Close()
    End Sub
<<<<<<< HEAD
    Private Sub Button1_Click_2(sender As Object, e As EventArgs)
        'abrir()
        x = TextBox1.Text
        Try
            'conexion_1.Login(TextBox1.Text, TextBox2.Text)
=======
    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
>>>>>>> 9a0dcd4cb9dccc53897e071bfee4624c67e31704

        Dim datos As List(Of String) = Conexiones.ObtenerDatos("Empleados", "WHERE CEDULA ='" & TextBox1.Text & "'")
        If datos.Item(10) = TextBox2.Text Then
            MsgBox("Login exitoso")
        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
