Imports System.Data.SqlClient
Public Class DDetalleVenta
    Inherits Dconexion
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

    Public Function ObtenerIdVenta() As Integer
        Dim id As Integer
        Try
            conectar()
            Dim cmd As New SqlCommand("ObtenerIdVenta", con)

            cmd.CommandType = CommandType.StoredProcedure

            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader

            If lector.HasRows Then
                lector.Read()
                id = Convert.ToInt32(lector(0).ToString)
                lector.Close()
                Return id
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



    Public Function AgregarDetalleVenta(ByVal ldetalleventa As LDetalleVenta) As Boolean

        Try
            conectar()
            Dim cmd As New SqlCommand("AgregarDetalleVenta", con)
            cmd.CommandType = CommandType.StoredProcedure

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
            MsgBox(ex.Message)
            Return False
        Finally
            desconectar()
        End Try
    End Function




    Public Function EliminarDetalleVenta(ByVal ldetalleventa As LDetalleVenta) As Boolean

        Try
            conectar()
            Dim cmd As New SqlCommand("EliminarDetalleVenta", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@iddetalleventa", ldetalleventa._iddetalleventa)
            End With

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


    Public Function VerRegistroDetalleVenta(ByVal ldetalleventa As LDetalleVenta) As DataTable
        Try
            conectar()
            Dim cmd As New SqlCommand("VerRegistroDetalleVenta", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idventa", ldetalleventa._idventa)
            Dim adaptador As New SqlDataAdapter(cmd)
            Dim listadoventa As New DataTable

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
            MsgBox(ex.Message)
            Return False
        Finally
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
            MsgBox(ex.Message)
            Return False
        Finally
            desconectar()
        End Try
    End Function
End Class
