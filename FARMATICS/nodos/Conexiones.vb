Imports System.Data.OleDb
Imports System.Text
Module Conexiones

    ' Declaracion de variables a usar en el modulo.
    Public Conexion As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & System.IO.Directory.GetCurrentDirectory() & "\Database.mdb;")

    Public Sub RegistrarDatos(ByVal texto As String, ByVal valores As List(Of String))
        Dim inicioConsulta As String = "INSERT INTO " & texto & " "
        Dim complementoConsulta As String = "Nombre de tabla equivocada"
        Dim constructor As New StringBuilder()
        For Each datos As String In valores
            constructor.Append("'" & datos & "'").Append(",")
        Next
        Dim datosFinalizados = constructor.ToString()
        datosFinalizados = datosFinalizados.Remove(datosFinalizados.LastIndexOf(","))
        Select Case texto
            Case "Clientes"
                complementoConsulta = "(NOMBRE, APELLIDO, CEDULA, TELEFONO, DIRECCION)"
            Case "Productos"
                complementoConsulta = "(NOMBRE, APELLIDO, CEDULA, TELEFONO, DIRECCION)"
            Case "Trabajadores"
                complementoConsulta = "(NOMBRE, APELLIDO, CEDULA, TELEFONO, DIRECCION)"
            Case "Historial"
                complementoConsulta = "(NOMBRE, APELLIDO, CEDULA, TELEFONO, DIRECCION)"
        End Select
        Dim Consulta As String = inicioConsulta & complementoConsulta & " values (" & datosFinalizados & ");"

        Conexion.Open()

        Dim comando As OleDbCommand = New OleDbCommand(Consulta, Conexion)

        Try
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conexion.Close()
    End Sub

    ' Metodo para Obtener una lista de la base de datos y pasarlos a un datagridview
    Public Sub ObtenerTabla(ByVal nombreTabla As String, ByVal tabla As DataGridView)
        Conexion.Open()
        Dim datos As New DataSet
        Dim adaptador As OleDbDataAdapter = New OleDbDataAdapter("Select * from " & nombreTabla, Conexion)
        adaptador.Fill(datos, nombreTabla)
        tabla.DataSource = datos
        tabla.DataMember = nombreTabla
        Conexion.Close()
    End Sub

    Public Sub ObtenerDatos()
        Conexion.Open()
        Conexion.Close()
    End Sub

    Public Sub EliminarDatos(ByVal tabla As String, ByVal id As String)
        Conexion.Open()
        Dim comando As New OleDbCommand("DELETE * FROM" & tabla & "WHERE ID = " & id)
        comando.ExecuteNonQuery()
        Conexion.Close()
    End Sub


End Module
