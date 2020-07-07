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
        If Conexiones.Verificacion("Empleados", "CEDULA ='" & txt_user.Text & "' AND CLAVE ='" & txt_pass.Text & "'") Then
            If Conexiones.Verificacion("Empleados", "CEDULA ='" & txt_user.Text & "' AND CARGO ='Dueño'") Then
                frmMenu.Show()
            Else
                frmCaja.Show()
            End If
        Else
            MsgBox("Usuario no existe")
        End If

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        frmVisualizarReportes.Show()
    End Sub
End Class
