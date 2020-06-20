Imports System.Data.SqlClient
Public Class frmLogin
    Dim x As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        MsgBox("¿Seguro que desea salir de la plataforma?", MsgBoxStyle.OkOnly)
        Me.Close()
    End Sub
    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        'abrir()
        x = TextBox1.Text
        Try
            'conexion_1.Login(TextBox1.Text, TextBox2.Text)

        Catch EX As Exception
            MsgBox(EX.ToString)
        End Try
        'If conexion_1.conector = False Then
        TextBox1.Text = ""
        TextBox2.Text = ""
        'End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
