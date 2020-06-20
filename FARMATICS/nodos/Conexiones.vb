Imports System.Data.OleDb
Module Conexiones

    ' Declaracion de variables a usar en el modulo.
    Public Conexion As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & System.IO.Directory.GetCurrentDirectory() & "\Database.mdb;")



    Public Sub Abrir()
        Try
            Conexion.Open()
        Catch ex As Exception
            MsgBox("Error al conectar la base de datos:" & ex.Message)
        Finally
            Conexion.Close()
        End Try
    End Sub

    Public Sub registrar(ByVal texto As String)
        Conexion.Open()

    End Sub

    Public Function Productos(ByVal texto As String)
        Conexion.Open()
        Dim datos As New DataSet
        Dim adaptador As OleDbDataAdapter = New OleDbDataAdapter(texto, Conexion)
        adaptador.Fill(datos, "Clientes")
        Conexion.Close()
        Return datos
    End Function



End Module
