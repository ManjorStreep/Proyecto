﻿Public Class frmCaja

    Private Sub btn_client_Click(sender As Object, e As EventArgs) Handles btn_client.Click

    End Sub

    Private Sub frmCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        MsgBox("¿Seguro que desea salir de la plataforma?", MsgBoxStyle.OkOnly)
        Me.Close()
    End Sub

End Class
