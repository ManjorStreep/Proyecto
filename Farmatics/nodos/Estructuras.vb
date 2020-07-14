Imports System.Text
Imports Sotware_Farmatics.Conexiones
Imports System.Data.OleDb
Imports Sotware_Farmatics.DatabaseDataSet
Module Estructuras
    Public Structure Empleado

        Public Nombre As String
        Public Apellido As String
        Public Cedula As String
        Public Telefono As Long
        Public Correo As String
        Public Direccion As String
        Public Sexo As String
        Public Cargo As String
        Public FechaIngreso As DateTime
        Public Clave As String


        Public Sub New(ByVal Identificacion As String)
            Try
                Conexion.Open()
                Comando = New OleDbCommand("SELECT * FROM Empleados WHERE CEDULA ='" & Identificacion & "'", Conexion)
                Lector = Comando.ExecuteReader()

                While Lector.Read()
                    Nombre = Lector.Item(1)
                    Apellido = Lector.Item(2)
                    Cedula = Lector.Item(3)
                    Telefono = Long.Parse(Lector.Item(4))
                    Correo = Lector.Item(5)
                    Direccion = Lector.Item(6)
                    Sexo = Lector.Item(7)
                    Cargo = Lector.Item(8)
                    FechaIngreso = Convert.ToDateTime(Lector.Item(9))
                    Clave = Lector.Item(10)
                End While
            Catch ex As Exception
                MsgBox("Error al cargar empleado - " & ex.Message)
            Finally
                Conexion.Close()
            End Try
        End Sub
        Public Function vacio()
            If String.IsNullOrEmpty(Nombre) Or String.IsNullOrEmpty(Apellido) Then
                Return True
            Else
                Return False
            End If
        End Function
    End Structure

    Public Structure Productos
        Public Id As Integer
        Public Nombre As String
        Public Valor As Integer
        Public Cantidad_Disponible As Integer
        Public Clasificacion As String
        Public Recipe As Boolean

        ' Funcion privada cuya finalidad es llenar los datos del producto
        Private Sub RellenarDatos(ByRef lector As OleDbDataReader)
            While lector.Read
                Id = lector.Item(0)
                Nombre = lector.Item(1)
                Valor = lector.Item(2)
                Cantidad_Disponible = lector.Item(3)
                Clasificacion = lector.Item(4)
                Recipe = lector.Item(5)
            End While
            lector.Close()
        End Sub

        Public Sub New(ByVal datos As String)
            ' Constructor del producto a travez de SQL
            Try
                Conexion.Open()
                Comando = New OleDbCommand("SELECT * FROM Productos WHERE CODIGO=" & datos, Conexion)
                Lector = Comando.ExecuteReader()
                RellenarDatos(Lector)
            Catch ex As Exception
                MsgBox("ERROR Productos: Producto no se encuentra en la base de datos! - " & ex.Message)
            Finally
                Conexion.Close()
            End Try
        End Sub

        ' Esta funcion sera la encargada de actualizar los productos dentro de la base de datos
        Public Sub ActualizarCantidad(ByVal cantidad As String)
            Try
                Conexion.Open()

                ' Actualizamos la columna CANTIDAD_DISPONIBLE en la base de datos con el parametro cantidad
                Comando = New OleDbCommand("UPDATE Productos SET CANTIDAD_DISPONIBLE = " & cantidad & " WHERE CODIGO = " & Id, Conexion)
                Comando.ExecuteNonQuery()

                ' Obtenemos Los datos nuevamente para mantener la informacion del producto actualizada
                Comando = New OleDbCommand("SELECT * FROM Productos WHERE CODIGO=" & Id, Conexion)
                Lector = Comando.ExecuteReader()
                RellenarDatos(Lector)
            Catch ex As Exception
                MsgBox("ERROR Productos: No se puede actualizar este producto CODIGO = " & Id & " - " & ex.Message)
            Finally
                Conexion.Close()
            End Try
        End Sub
    End Structure

End Module
