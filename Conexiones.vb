Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Module Conexiones

    ' Declaracion de variables que se usaran con SQL Server.
    Public conexion As SqlConnection = New SqlConnection()
    Public comando As SqlCommand

    ' Obtener la direccion del proyecto para manejar bases de datos offline.
    Public directorio As String = System.IO.Directory.GetCurrentDirectory.Replace("\bin\Debug", "")

    ' Funcion que abrira la conexion
    Public Sub AbrirConexion()
        Try
            conexion.Open()

        Catch ex As Exception
            MsgBox("Error al conectar a la base de datos")
        Finally
            conexion.Close()
        End Try
    End Sub

End Module
