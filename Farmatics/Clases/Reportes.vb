Imports System.Data.OleDb
Public Class Reportes
    Inherits Conexion
    ' Se usa unicamente un DataSet para almacenar todas las tablas modificadas
    Public Property tablas As New FacturaDataSet()
    ' Es una tabla de datos por cada reporte que se vaya a visualizar
    Public Property TablaEmpleados As New DataTable("Empleados")
    Public Property TablaClientes As New DataTable("Clientes")
    Public Property TablaHistorial As New DataTable("Historial")
    Public Property TablaProductos As New DataTable("Productos")

    'Cada tabla tiene su correspondiente funcion para llenar el datatable que se visualizara en el reporte
    Public Sub Empleados()
        If tablas.Tables.Contains("Empleados") Then
            tablas.Tables.Remove("Empleados")
        End If
        Try
            Conexion.Open()
            Comando = New OleDbCommand("SELECT * FROM Empleados", Conexion)
            Adaptador = New OleDbDataAdapter(Comando)
            Adaptador.Fill(TablaEmpleados)
            ' En este caso se remueve la columna "CLAVE" ya que es un dato que no puede ser visto desde un reporte
            TablaEmpleados.Columns.Remove("CLAVE")
            tablas.Tables.Add(TablaEmpleados)
        Catch ex As Exception
            MsgBox("ERROR TablaEmpleados: " & ex.Message)
        Finally
            Conexion.Close()
        End Try
    End Sub

    'Cada tabla tiene su correspondiente funcion para llenar el datatable que se visualizara en el reporte
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
            MsgBox(TablaClientes.Rows.Count)
        Catch ex As Exception
            MsgBox("ERROR TablaClientes: " & ex.Message)
        Finally
            Conexion.Close()
        End Try
    End Sub

    'Cada tabla tiene su correspondiente funcion para llenar el datatable que se visualizara en el reporte
    Public Sub Historial()
        If tablas.Tables.Contains("Historial") Then
            tablas.Tables.Remove("Historial")
        End If
        Try
            Conexion.Open()
            Comando = New OleDbCommand("SELECT * FROM Historial", Conexion)
            Adaptador = New OleDbDataAdapter(Comando)
            Adaptador.Fill(TablaHistorial)
            ' En este caso se remueve la columna "CLIENTE_NACIONALIDAD"
            TablaHistorial.Columns.Remove("CLIENTE_NACIONALIDAD")
            ' Aqui se renombra la columna "CLIENTE_CEDULA" por "CLIENTE"
            TablaHistorial.Columns("CLIENTE_CEDULA").ColumnName = "CLIENTE"
            tablas.Tables.Add(TablaHistorial)
        Catch ex As Exception
            MsgBox("ERROR TablaHistorial: " & ex.Message)
        Finally
            Conexion.Close()
        End Try
    End Sub

    'Cada tabla tiene su correspondiente funcion para llenar el datatable que se visualizara en el reporte
    Public Sub Productos()
        If tablas.Tables.Contains("Productos") Then
            tablas.Tables.Remove("Productos")
        End If
        Try
            Conexion.Open()
            Comando = New OleDbCommand("SELECT * FROM Productos", Conexion)
            Adaptador = New OleDbDataAdapter(Comando)
            Adaptador.Fill(TablaProductos)
            tablas.Tables.Add(TablaProductos)
        Catch ex As Exception
            MsgBox("ERROR TablaProductos: " & ex.Message)
        Finally
            Conexion.Close()
        End Try
    End Sub
End Class
