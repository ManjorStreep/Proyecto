Imports System.Data.OleDb
Public Class Empleado
    Inherits Conexion

    ' Propiedades que tendra la clase Empleado
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property Nacionalidad As String
    Public Property Cedula As Integer
    Public Property Fecha_nacimiento As New DateTime()
    Public Property Fecha_ingreso As New DateTime()
    Public Property Cargo As String
    Public Property Clave As String
    Public Property Direccion As String
    Public Property Telefono As Long
    Public Property Sexo As String
    Public Property Correo As String

    ' Propiedades privadas que solo seran usadas dentro de la clase Empleado
    Private Property TablaEmpleado As String = "Empleados"

    ' Constructor de la clase 
    ' Esta funcion sirve para darle un estado inicial a todas las variables!
    Public Sub New(ByVal cedula As String)
        ' Primero verificamos que el usuario con la cedula ingresada existe
        If Verificacion(TablaEmpleado, "CEDULA = " & cedula) Then
            ' Si existe, procedemos a rellenar todas las propiedades de la clase, rescatandolas desde la base de datos
            Try
                ' Abrimos la conexion para poder realizar consultas a la base de datos
                Conexion.Open()
                ' Creamos un nuevo comando, con una consulta sql para recuperar todos los datos de un empleado segun su Cedula
                ' Ejemplo "SELECT * FROM Empleados WHERE CEDULA ='123456789'
                Comando = New OleDbCommand("SELECT * FROM " & TablaEmpleado & " WHERE CEDULA = " & cedula, Conexion)
                ' Ejecutamos un Reader para leer los resultados de la consulta
                Lector = Comando.ExecuteReader()
                While Lector.Read()

                    Me.Nombre = Lector.Item(0)
                    Me.Apellido = Lector.Item(1)
                    Me.Nacionalidad = Lector.Item(2)
                    Me.Cedula = Lector.Item(3)
                    Me.Fecha_nacimiento = Convert.ToDateTime(Lector.Item(4))
                    Me.Fecha_ingreso = Convert.ToDateTime(Lector.Item(5))
                    Me.Cargo = Lector.Item(6)
                    Me.Clave = Lector.Item(7)
                    Me.Direccion = Lector.Item(8)
                    Me.Telefono = Lector.Item(9)
                    Me.Sexo = Lector.Item(10)
                    Me.Correo = Lector.Item(11)

                End While
            Catch ex As Exception
                MsgBox("ERROR Clase Empleado: " & ex.Message)
            Finally
                ' Siempre hay que cerrrar la conexion a la base de datos, una vez terminemos de manipularla
                Conexion.Close()
            End Try
        End If
    End Sub

    ' Constructor vacio, esto permite crar instancias sin especificar cedulas
    Public Sub New()
        Me.Nombre = Nothing
        Me.Apellido = Nothing
        Me.Nacionalidad = Nothing
        Me.Cedula = Nothing
        Me.Fecha_nacimiento = Nothing
        Me.Fecha_ingreso = Nothing
        Me.Cargo = Nothing
        Me.Clave = Nothing
        Me.Direccion = Nothing
        Me.Telefono = Nothing
        Me.Sexo = Nothing
        Me.Correo = Nothing
    End Sub

    ' Esta sera la funcion encargada de registrar empleados
    ' Esta funcion se puede usar sin tener que darle valor a todas las variables de esta clase
    Public Sub Registrar(ByVal pNombre As String, ByVal pApellido As String, ByVal pNacionalidad As String, ByVal pCedula As String, ByVal pNacimiento As String, ByRef pCargo As String, ByVal pclave As String, ByVal pDireccion As String, ByVal pTelefono As String, ByVal pSexo As String, ByVal pCorreo As String)

        ' Primero verificamos de que el empleado realmente no este registrado en la base de datos
        If Verificacion(TablaEmpleado, "CEDULA = " & pCedula) Then
            MsgBox("Este empleado ya existe, no se puede registrar")
            ' La funcion return, impide que el flujo de ejecucion siga hacia bajo, eso quiere decir que si el usuario existe ya no se ejecutara completamente esta funcion
            Return
        End If

        Try
            ' Abrimos la conexion
            Conexion.Open()
            ' Creamos el comando sql correspondiente para insertar registros con ayuda de los parametros de esta funcion
            Comando = New OleDbCommand("INSERT INTO " & TablaEmpleado & " (NOMBRE, APELLIDO, NACIONALIDAD, CEDULA, FECHA_NACIMIENTO, FECHA_INGRESO, CARGO, CLAVE, DIRECCION, TELEFONO, SEXO, CORREO) VALUES ( '" & pNombre & "', '" & pApellido & "', '" & pNacionalidad & "', " & pCedula & ", #" & Convert.ToDateTime(pNacimiento).ToString("dd/MM/yyyy") & "#, #" & DateTime.Now.ToString("dd/MM/yyyy") & "#, '" & pCargo & "', '" & pclave & "', '" & pDireccion & "', '" & pTelefono & "', '" & pSexo & "', '" & pCorreo & "')", Conexion)
            'Ejecutamos el comando
            If Comando.ExecuteNonQuery Then
                MsgBox("Empleado registrado con exito")
            Else
                MsgBox("ERROR Registrar: No se ha podido registrar el empleado")
            End If
        Catch ex As Exception
            MsgBox("ERROR Registrar: " & ex.Message)
        Finally
            ' Siempre hay que cerrrar la conexion a la base de datos, una vez terminemos de manipularla
            Conexion.Close()
        End Try

    End Sub

    Public Sub Eliminar()
        ' Primero que nada, debemos verificar que esta clase no se encuente vacia, para evitar problemas
        If vacio() Then
            ' Si la clase esta vacia, se detiene aqui el flujo de ejecucion evitando que se ejecute el codigo de abajo
            Return
        End If
        ' Para que se ejecute este codigo sin errores, hay que tener en cuenta que:
        ' La clase no puede estar vacia
        ' Se eliminara este mismo objeto de la base de datos
        Try
            ' Abrimos conexion antes de manipular la base de datos
            Conexion.Open()
            ' Aqui creamos la consulta SQL correspondiente para eliminar un registro, donde se usara como criterio la cedula del empleado
            Comando = New OleDbCommand("DELETE * FROM " & TablaEmpleado & " WHERE CEDULA =" & Cedula, Conexion)
            If Comando.ExecuteNonQuery Then
                MsgBox("Empleado eliminado con exito")
            Else
                MsgBox("ERROR Eliminar: No se ha podido Eliminar el empleado")
            End If
        Catch ex As Exception
            MsgBox("ERROR Eliminar: " & ex.Message)
        Finally
            ' Siempre hay que cerrrar la conexion a la base de datos, una vez terminemos de manipularla
            Conexion.Close()
        End Try
    End Sub

    Public Sub Modificar(ByVal pNombre As String, ByVal pApellido As String, ByVal pNacionalidad As String, ByVal pCedula As String, ByVal pNacimiento As String, ByRef pCargo As String, ByVal pclave As String, ByVal pDireccion As String, ByVal pTelefono As String, ByVal pSexo As String, ByVal pCorreo As String)
        ' Primero que nada, debemos verificar que esta clase no se encuente vacia, para evitar problemas
        If vacio() Then
            ' Si la clase esta vacia, se detiene aqui el flujo de ejecucion evitando que se ejecute el codigo de abajo
            Return
        End If

        ' Para que se ejecute este codigo sin errores, hay que tener en cuenta que:
        ' La clase no puede estar vacia
        ' Se eliminara este mismo objeto de la base de datos
        Try
            ' Abrimos conexion antes de manipular la base de datos
            Conexion.Open()
            ' Aqui creamos la consulta SQL correspondite para actualizar la informacion de la base de datos ya existente, y se usa como criterio la cedula del empleado
            Comando = New OleDbCommand("UPDATE " & TablaEmpleado & " SET NOMBRE = '" & pNombre & "', APELLIDO = '" & pApellido & "', NACIONALIDAD = '" & pNacionalidad & "', CEDULA = " & pCedula & ", FECHA_NACIMIENTO = '" & pNacimiento & "', CARGO = '" & pCargo & "', CLAVE= '" & pclave & "', DIRECCION ='" & pDireccion & "', TELEFONO = '" & pTelefono & "', SEXO =' " & pSexo & "', CORREO ='" & pCorreo & "' WHERE CEDULA =" & Cedula, Conexion)
            If Comando.ExecuteNonQuery Then
                MsgBox("Empleado modificado con exito")
            Else
                MsgBox("ERROR Modificar: No se ha podido Modificar el empleado")
            End If
        Catch ex As Exception
            MsgBox("ERROR Modificar: " & ex.Message)
        Finally
            ' Siempre hay que cerrrar la conexion a la base de datos, una vez terminemos de manipularla
            Conexion.Close()
        End Try
    End Sub

    ' Esta funcion devolvera false si no hay datos en la clase
    Public Function vacio()
        If String.IsNullOrEmpty(Nombre) Or String.IsNullOrEmpty(Apellido) Or Cedula = 0 Or Cedula = Nothing Then
            Return True
        Else
            Return False
        End If
    End Function

    ' Esta es una funcion modificada para rellenar los DataGridView
    Overloads Sub Llenar(ByRef datos As DataGridView)
        Llenar(datos, TablaEmpleado)
    End Sub

End Class
