Imports System.Data.SqlClient
Public Class frmLogin

    Dim datos As List(Of String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_user.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        MsgBox("¿Seguro que desea salir de la plataforma?", MsgBoxStyle.OkOnly)
        Me.Close()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click

        Dim datos = Conexiones.ObtenerDatos("Empleados", "WHERE CEDULA ='" & txt_user.Text & "'")

        If txt_user.TextLength < 5 Or txt_pass.TextLength < 5 Then
            MsgBox("ingrese valores en los campos ")
        Else
            If datos.Item(10) = txt_pass.Text Then
                Me.Hide()
                My.Forms.frmCaja.Show()
            Else
                MsgBox("Usuario o Contraseña Invalida ")
            End If
        End If

    End Sub

    Public Function Usuario()
        Return New Empleado(datos)
    End Function

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        frmVisualizarReportes.Show()
    End Sub
End Class
