Imports System.Data.SqlClient
Public Class DDetalleVenta
    Inherits Dconexion
    ' Esta clase contiene metodos para gestionar informacion de la base de datos

    Public Function DeshacerDetalleVenta(ByVal ldetalleventa As LDetalleVenta) As Boolean
        Try
            conectar()
            Dim cmd As New SqlCommand("DeshacerDetalleVenta", con)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@idventa", ldetalleventa._idventa)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectar()
        End Try
    End Function

    ' Esta funcion devuelve un Integer correspondiente al Id de la venta.
    Public Function ObtenerIdVenta() As Integer
        Dim id As Integer
        Try
            ' Abrimos la conexion a la base de datos
            conectar()
            ' Creamos un nuevo SqlCommand vinculado con el procedimiento almacenado del SQL Server, "ObtenerIdVenta"
            Dim cmd As New SqlCommand("ObtenerIdVenta", con)
            cmd.CommandType = CommandType.StoredProcedure

            ' Ejecutamos el comando y rescatamos la informacion obtenida con un SqlDataReader
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader
            
            ' Verificamos que el SqlDataReader tenga informacion 
            If lector.HasRows Then
                ' Dado el caso tenga informacion, extraemos el id 
                lector.Read()
                id = Convert.ToInt32(lector(0).ToString)
                lector.Close()
                ' devolveremos el id 
                Return id
            Else
                ' Dado el caso que no tenga informacion, devolvera Nothing
                Return Nothing
            End If

        Catch ex As Exception
            ' En caso que falle la conexion a la base de datos, se mostrara un MsgBox con el error y devolvera Nothing
            MsgBox(ex.Message)
            Return Nothing
        Finally
            ' Finalmente cerramos la conexion
            desconectar()
        End Try
    End Function


    ' Esta funcion se encargara de agregar registros a la base de datos
    ' Devolvera TRUE o FALSE, dependiendo de si se realizo o no el registro
    Public Function AgregarDetalleVenta(ByVal ldetalleventa As LDetalleVenta) As Boolean

        Try
            ' Abrimos la conexion a la base de datos
            conectar()
            ' Creamos un nuevo SqlCommand vinculado con el procedimiento almacenado del SQL Server, "AgregarDetalleVenta"
            Dim cmd As New SqlCommand("AgregarDetalleVenta", con)
            cmd.CommandType = CommandType.StoredProcedure

            ' Pasamos informacion a travez de parametros de SQLServer
            With cmd.Parameters
                .AddWithValue("@idproducto", ldetalleventa._idproducto)
                .AddWithValue("@idventa", ldetalleventa._idventa)
                .AddWithValue("@cantidad", ldetalleventa._cantidad)
                .AddWithValue("@preciounitario", ldetalleventa._preciounitario)

            End With

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            ' En caso que falle la conexion a la base de datos, se mostrara un MsgBox con el error y devolvera Nothing
            MsgBox(ex.Message)
            Return False
        Finally
            ' Finalmente cerramos la conexion
            desconectar()
        End Try
    End Function



    ' Esta funcion se encarga de eliminar la informacion de detalle de venta
    ' Esta funcion recibe como parametro un objeto LDetalleVenta la cual contiene la informacion necesaria para realizar la sentencia sql
    Public Function EliminarDetalleVenta(ByVal ldetalleventa As LDetalleVenta) As Boolean

        Try
            ' Abrimos la conexion a la base de datos
            conectar()
            ' Creamos un nuevo SqlComand el cual esta vinculado al procedimiento almacenado "EliminarDetalleVenta"
            Dim cmd As New SqlCommand("EliminarDetalleVenta", con)
            cmd.CommandType = CommandType.StoredProcedure

            ' Añadimos informacion a travez de parametros al comando
            With cmd.Parameters
                .AddWithValue("@iddetalleventa", ldetalleventa._iddetalleventa)
            End With
            
            ' Ejecutamos el comando, si se ejecuta correctamente, devolvera TRUE, si no, devuelve False
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            ' En caso que falle la conexion a la base de datos, se mostrara un MsgBox con el error y devolvera Nothing
            MsgBox(ex.Message)
            Return False
        Finally
            ' Finalmente cerramos la conexion
            desconectar()
        End Try
    End Function

    ' Esta funcion devuelve un DataTable con toda la informacion referente a un LDetalleVenta
    ' Recibe por parametros un objeto tipo LDetalleVenta el cual tendra la informacion necesaria para realizar la sentecia SQL
    Public Function VerRegistroDetalleVenta(ByVal ldetalleventa As LDetalleVenta) As DataTable
        Try
            ' Abrimos la conexion a la base de datos
            conectar()
            ' Creamos un nuevo SqlComand el cual esta vinculado al procedimiento almacenado "VerRegistroDetalleVenta"
            Dim cmd As New SqlCommand("VerRegistroDetalleVenta", con)
            cmd.CommandType = CommandType.StoredProcedure

            ' Pasamos el idventa a travez de parametros para realizar la consutla sql
            cmd.Parameters.AddWithValue("@idventa", ldetalleventa._idventa)
            Dim adaptador As New SqlDataAdapter(cmd)
            Dim listadoventa As New DataTable

            ' Ejecutamos el comando y con ayuda de un SqlDataAdapter llenamos un DataTable para devolverlo
            If cmd.ExecuteNonQuery Then
                adaptador.Fill(listadoventa)
                Return listadoventa
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function


    Public Function Aumentarstock(ByVal ldetalleventa As LDetalleVenta) As Boolean

        Try
            conectar()
            Dim cmd As New SqlCommand("Aumentarstock", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@idproducto", ldetalleventa._idproducto)
                .AddWithValue("@cantidad", ldetalleventa._cantidad)
            End With

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            ' En caso que falle la conexion a la base de datos, se mostrara un MsgBox con el error y devolvera Nothing
            MsgBox(ex.Message)
            Return False
        Finally
            ' Finalmente cerramos la conexion
            desconectar()
        End Try
    End Function
    Public Function Disminuirstock(ByVal ldetalleventa As LDetalleVenta) As Boolean

        Try
            conectar()
            Dim cmd As New SqlCommand("Disminuirstock", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@idproducto", ldetalleventa._idproducto)
                .AddWithValue("@cantidad", ldetalleventa._cantidad)
            End With

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            ' En caso que falle la conexion a la base de datos, se mostrara un MsgBox con el error y devolvera Nothing
            MsgBox(ex.Message)
            Return False
        Finally
            ' Finalmente cerramos la conexion
            desconectar()
        End Try
    End Function
End Class
