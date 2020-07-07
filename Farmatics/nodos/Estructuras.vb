Imports System.Text
Imports Sotware_Farmatics.Conexiones
Imports System.Data.OleDb
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


        Public Sub New(ByVal Identificacion As Integer)
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
    End Structure

    Public Structure Productos
        Public Id As Integer
        Public Nombre As String
        Public Valor As Integer
        Public Cantidad_Disponible As Integer
        Public Clasificacion As String
        Public Recipe As Boolean

        Public Sub New(ByVal datos As DataRow)
            Id = Integer.Parse(CStr(datos(0)))
            Nombre = CStr(datos(1))
            Valor = Integer.Parse(CStr(datos(2)))
            Cantidad_Disponible = Integer.Parse(CStr(datos(3)))
            Clasificacion = CStr(datos(4))
            Recipe = Boolean.Parse(CStr(datos(5)))
        End Sub
    End Structure


End Module
