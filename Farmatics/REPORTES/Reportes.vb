Imports System.Data.OleDb
Public Class Reportes
    Inherits Conexion

    Public Property tablas As New FacturaDataSet()

    Public Property TablaEmpleados As New DataTable("Empleados")
    Public Property TablaClientes As New DataTable("Clientes")
    Public Property TablaHistorial As New DataTable("Historial")

    Public Sub Empleados()
        If tablas.Tables.Contains("Empleados") Then
            tablas.Tables.Remove("Empleados")
        End If
        Try
            Conexion.Open()
            Comando = New OleDbCommand("SELECT * FROM Empleados", Conexion)
            Adaptador = New OleDbDataAdapter(Comando)
            Adaptador.Fill(TablaEmpleados)
            TablaEmpleados.Columns.Remove("CLAVE")
            tablas.Tables.Add(TablaEmpleados)
        Catch ex As Exception
            MsgBox("ERROR TablaEmpleados: " & ex.Message)
        Finally
            Conexion.Close()
        End Try
    End Sub

    Public Sub Clientes()
        If tablas.Tables.Contains("Clientes") Then
            tablas.Tables.Remove("Clientes")
        End If
        Try
            Conexion.Open()
            Comando = New OleDbCommand("SELECT * FROM Clientes", Conexion)
            Adaptador = New OleDbDataAdapter(Comando)
            Adaptador.Fill(TablaClientes)
            tablas.Tables.Add(TablaClientes)
        Catch ex As Exception
            MsgBox("ERROR Clientes: " & ex.Message)
        Finally
            Conexion.Close()
        End Try
    End Sub

    Public Sub Historial()
        If tablas.Tables.Contains("Historial") Then
            tablas.Tables.Remove("Historial")
        End If
        Try
            Conexion.Open()
            Comando = New OleDbCommand("SELECT * FROM Historial", Conexion)
            Adaptador = New OleDbDataAdapter(Comando)
            Adaptador.Fill(TablaHistorial)
            TablaHistorial.Columns.Remove("CLIENTE_NACIONALIDAD")
            TablaHistorial.Columns("CLIENTE_CEDULA").ColumnName = "CLIENTE"
            tablas.Tables.Add(TablaHistorial)
        Catch ex As Exception
            MsgBox("ERROR TablaEmpleados: " & ex.Message)
        Finally
            Conexion.Close()
        End Try
    End Sub

End Class
