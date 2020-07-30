Imports System.Data.SqlClient
Public Class DCliente
    Inherits Dconexion
    Public Function MostrarClientes() As DataTable

        Try
            conectar()
            Dim cmd As New SqlCommand("MostrarCliente", con)
            Dim tablaclientes As New DataTable
            Dim adaptador As New SqlDataAdapter(cmd)


            If cmd.ExecuteNonQuery Then
                adaptador.Fill(tablaclientes)
                Return tablaclientes
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
    Public Function AgregarCliente(ByVal lcliente As LCliente) As Boolean
        Try
            conectar()
            Dim cmd As New SqlCommand("AgregarCliente", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@dni", lcliente._dni)
                .AddWithValue("@apellido", lcliente._apellido)
                .AddWithValue("@nombre", lcliente._nombre)
                .AddWithValue("@direccion", lcliente._direccion)
                .AddWithValue("@telefono", lcliente._telefono)
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

    Public Function EditarCliente(ByVal lcliente As LCliente) As Boolean
        Try
            conectar()
            Dim cmd As New SqlCommand("EditarCliente", con)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .AddWithValue("@idcliente", lcliente._idcliente)
                .AddWithValue("@dni", lcliente._dni)
                .AddWithValue("@apellido", lcliente._apellido)
                .AddWithValue("@nombre", lcliente._nombre)
                .AddWithValue("@direccion", lcliente._direccion)
                .AddWithValue("@telefono", lcliente._telefono)
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
