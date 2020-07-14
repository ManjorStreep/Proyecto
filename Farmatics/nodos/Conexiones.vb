﻿Imports System.Data.OleDb
Imports System.Text
Module Conexiones
    Dim SESSION As Boolean
    ' Declaracion de variables a usar en el modulo.
    Public Conexion As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Database.mdb")
    Public Comando As OleDbCommand
    Public Lector As OleDbDataReader

    Public Function Verificacion(ByVal tabla As String, ByVal consulta As String)
        Dim regresar As Boolean = False
        Try
            Conexion.Open()
            Comando = New OleDbCommand("SELECT * FROM " & tabla & " WHERE " & consulta, Conexion)
            Lector = Comando.ExecuteReader()
            regresar = Lector.HasRows()
            Lector.Close()
        Catch ex As Exception
            MsgBox("Error al verificar en la base de datos - " & ex.Message)
        Finally
            Conexion.Close()
        End Try

        Return regresar
    End Function

    
    Public Function abrirPantallas(Optional ByVal x As Boolean = True)
        Return x
    End Function

End Module
