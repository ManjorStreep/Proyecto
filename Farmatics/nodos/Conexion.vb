Imports System.Data.OleDb

Public Class Conexion
    Public Property Conexion As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Yigs-Family\Desktop\putos\Farmatics\Database.mdb")
    Public Property Comando As OleDbCommand
    Public Property Lector As OleDbDataReader
    Public Property Adaptador As OleDbDataAdapter

    ' Esta funcion se encarga de verificar si un registro en la base de datos existe
    ' El parametro 'tabla' hace referencia a la tabla dentro de la base de datos a consultar
    ' El parametro 'consulta' hace referencia a un critero para buscar, por ejemplo "CEDULA = '123456789'"
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

    ' Esta funcion se encarga de rellnar los DataGridView de todo
    ' Esta funcion debe ser heredada a sus respectivas clases y luego ser modificada para facilitar su funcionamiento
    ' Recibe originalmente 2 parametros:
    ' 1 - DataGrid: es una referencia directa al datagridview que sera modificado y rellenado de informacion
    ' 2 - tabla: Hace refencia a la tabla de donde se recuperara la informacion
    Public Sub Llenar(ByRef DataGrid As DataGridView, ByVal tabla As String)
        ' Declaramos una variable donde se almacenara la informacion obtenida desde la base de datos
        Dim Datos As New DataTable
        Try
            ' Abrimos la conexion a la base de datos
            Conexion.Open()
            ' Este comando se encargada de seleccionar todo lo que se encuentre en la tabla especificada
            Comando = New OleDbCommand("SELECT * FROM " & tabla, Conexion)
            ' Ejecutamos el comando y hacemos que se guarde en un DataReader
            Adaptador = New OleDbDataAdapter(Comando)
            ' Rellenamos la tabla con ayuda del DataReader
            Adaptador.Fill(Datos)
            ' Ahora comenzamos a rellenar el DataGridView
            ' Primeros limpiamos toda informacion que ya tenga anteriormente
            DataGrid.Rows.Clear()
            ' Ahora aqui, con la informacion guardada en el DataTable llamado Datos
            ' Iremos entrado en cada fila
            For Each fila As DataRow In Datos.Rows
                ' En cada fila que entremos se creara una lista llamada Columnas y esta es donde se guardara la informacion para rellenar El DataGridView
                Dim columnas As New List(Of String)
                ' Ahora iniciamos un for que se encargara de asignar valor a cada elemento de la lista
                For i As Integer = 0 To DataGrid.ColumnCount - 1
                    ' La lista sera rellenada de acuerdo a la cantidad de columnas que tenga el DataGridView
                    columnas.Add(fila.Item(i))
                Next
                ' Al finalizar de rellenar la lista, esta sera agregada al DataGridView de esta forma y transformandola en un Array (Vector)
                DataGrid.Rows.Add(columnas.ToArray())
            Next

        Catch ex As Exception
            MsgBox("ERROR Cargar lista: " & ex.Message)
        Finally
            ' Finalmente siempre hay que cerrar la conexion a la base de datos
            Conexion.Close()
        End Try

    End Sub


    ' -----------------------------------------------------------------------------------------------------------------------------------------------

    Public Sub Cliente(ByVal nombre As String, ByVal cedula As String, ByVal nacionalidad As String, ByVal telefono As String, ByVal direccion As String)
        If Verificacion("Clientes", "CEDULA = " & cedula) Then
            Return
        End If

        Try
            Conexion.Open()
            Comando = New OleDbCommand("INSERT INTO Clientes (NOMBRE, CEDULA, NACIONALIDAD, TELEFONO, DIRECCION) VALUES ('" & nombre & "', " & cedula & ", '" & nacionalidad & "', '" & telefono & "', '" & direccion & "')", Conexion)
            If Comando.ExecuteNonQuery Then
                MsgBox("Cliente registrado con exito")
            Else
                MsgBox("No se ha podido registrar el cliente")
            End If
        Catch ex As Exception
            MsgBox("ERROR Registrar Cliente: " & ex.Message)
        Finally
            Conexion.Close()
        End Try

    End Sub

    Public Function RegistrarCompra(ByVal cedula As String, ByVal nacionalidad As String, ByVal Productos As String, ByVal total As String)
        Dim Factura As Integer
        Dim r As New Random()
        Do
            Factura = r.Next(1, 10000)
        Loop While Verificacion("Historial", "FACTURA = " & Factura)

        Try
            Conexion.Open()
            Comando = New OleDbCommand("INSERT INTO Historial (FACTURA, CLIENTE_CEDULA, CLIENTE_NACIONALIDAD, PRODUCTOS, TOTAL, FECHA) VALUES (" & Factura & ", " & cedula & ", '" & nacionalidad & "', '" & Productos & "', " & Convert.ToDecimal(total) & ", #" & DateTime.Now.ToString("dd/MM/yyyy") & "#)", Conexion)
            Comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ERROR Registrar Compra: " & ex.Message)
        Finally
            Conexion.Close()
        End Try

        Return Factura
    End Function

End Class
