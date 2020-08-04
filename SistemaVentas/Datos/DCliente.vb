Imports System.Data.SqlClient
Public Class DCliente
    Inherits Dconexion

    ' Esta clase contiene funciones necesarias para gestionar clientes.
    ' Funcions como, mostrar, agregar y editar, dentro de la base de datos.
    
    ' Esta en la funcion que se encarga de devolver un DataTable con todos los clientes registrados en la base de datos
    ' Devuelve un DataTable con la informacion de todos los clientes 
    Public Function MostrarClientes() As DataTable
        Try
            conectar()
            ' Usamos un SqlCommand para hacer la consulta SQL la cual hace referencia a un proceso almacenado
            Dim cmd As New SqlCommand("MostrarCliente", con)
            Dim tablaclientes As New DataTable
            Dim adaptador As New SqlDataAdapter(cmd)

            ' Ejecutamos el comando
            If cmd.ExecuteNonQuery Then
            '   Dado el caso que se ejecute la consulta SQL correctamente, con ayuda de un SqlDataReader llenaremos
            '   El DataTable con la informacion obtenida
                adaptador.Fill(tablaclientes)
            ' Funalmente devolvemos la tabla llena de informacion
                Return tablaclientes
            Else
                ' Dado el caso que no se haya ejecutado la consulta sql, devolvera Nothing, es decir, devolvera nada
                Return Nothing
            End If


        Catch ex As Exception
            ' En caso de que haya un error con la base de datos, se mostrara un MsgBox con los detalles del error
            MsgBox(ex.Message)
            ' y devolveremos Nothing (Nada)
            Return Nothing
        Finally
            ' Finalmente cerramos la conexion
            desconectar()
        End Try
    End Function

    ' Esta funcion se encargara de registrar nuevos clientes a la base de datos.
    ' Recibe un objeto tipo LCliente como parametro, el cual contiene toda la informacion necesaria para el registro
    ' Devolvera un valor TRUE o FALSE, dependiendo si se realiza el registro o no
    Public Function AgregarCliente(ByVal lcliente As LCliente) As Boolean
        Try
            ' Abrimos la conexion a la base de datos
            conectar()
            ' Creamos un nuevo SqlCommand el cual esta vinculado a un procedimiento almacenado llamado "AgregarCliente"
            Dim cmd As New SqlCommand("AgregarCliente", con)
            cmd.CommandType = CommandType.StoredProcedure

            ' Pasamos informacion necesaria del cliente a travez de parametros para realizar la sentencia SQL
            With cmd.Parameters
                .AddWithValue("@dni", lcliente._dni)
                .AddWithValue("@apellido", lcliente._apellido)
                .AddWithValue("@nombre", lcliente._nombre)
                .AddWithValue("@direccion", lcliente._direccion)
                .AddWithValue("@telefono", lcliente._telefono)
            End With
            
            ' Ejecutamos el comando
            If cmd.ExecuteNonQuery Then
                ' Dado el caso que se ejecute la sentecia SQL correctamente devolveremos TRUE
                Return True
            Else
                ' Caso contrario, no se pudo realizar la sentecia SQL, devolvera FALSE
                Return False
            End If
        Catch ex As Exception
            ' En caso de que haya un error con la base de datos, se mostrara un MsgBox con los detalles del error
            MsgBox(ex.Message)
            ' Y devolvemos FALSE
            Return False
        Finally
            ' Finalmente cerramos la conexion
            desconectar()
        End Try
    End Function

    ' Esta funcion se encargara de modificar registros en la base de datos
    ' Recibe un objeto tipo LCliente que contendra la informacion necesaria para la modificacion
    ' Devolvera TRUE o FALSE, dependiendo de si se pudo modificar el cliente o no
    Public Function EditarCliente(ByVal lcliente As LCliente) As Boolean
        Try
            ' Abrimos la conexion a la base de datos
            conectar()
            ' Creamos un nuevo SqlCommando que estara vinculado al procedimiento almacenado "EditarCliente"
            Dim cmd As New SqlCommand("EditarCliente", con)
            cmd.CommandType = CommandType.StoredProcedure
            ' Pasamos la informacion necesaria para la modificacion a travez de parametros
            With cmd.Parameters
                .AddWithValue("@idcliente", lcliente._idcliente)
                .AddWithValue("@dni", lcliente._dni)
                .AddWithValue("@apellido", lcliente._apellido)
                .AddWithValue("@nombre", lcliente._nombre)
                .AddWithValue("@direccion", lcliente._direccion)
                .AddWithValue("@telefono", lcliente._telefono)
            End With

            ' Ejecutamos el comando
            If cmd.ExecuteNonQuery Then
                ' Dado el caso que se ejecute la sentecia SQL correctamente devolveremos TRUE
                Return True
            Else
                ' Caso contrario, no se pudo realizar la sentecia SQL, devolvera FALSE
                Return False
            End If

        Catch ex As Exception
            ' En caso de que haya un error con la base de datos, se mostrara un MsgBox con los detalles del error
            MsgBox(ex.Message)
            ' Y devolvemos FALSE
            Return False
        Finally
            ' Finalmente cerramos la conexion
            desconectar()
        End Try
    End Function
End Class
