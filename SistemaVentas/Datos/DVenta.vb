Imports System.Data.SqlClient
Public Class DVenta
    Inherits Dconexion
    Public Function MostrarVenta() As DataTable

        Try
            conectar()
            Dim cmd As New SqlCommand("MostrarVenta", con)
            Dim tablaempleados As New DataTable
            Dim adaptador As New SqlDataAdapter(cmd)


            If cmd.ExecuteNonQuery Then
                adaptador.Fill(tablaempleados)
                Return tablaempleados
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
    Public Function ObtenerNroDocumento() As String
        Dim nrodocumento As String
        Try
            Dim numero As Integer
            conectar()
            Dim cmd As New SqlCommand("ObtenerNroDocumento", con)
            cmd.CommandType = CommandType.StoredProcedure

            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader

            If lector.HasRows Then
                lector.Read()

                numero = Convert.ToInt32(lector(0).ToString)
                numero += 1
                nrodocumento = Format(numero, "0000000")

                lector.Close()
                Return nrodocumento
            Else
                nrodocumento = "0000001"
                lector.Close()
                Return nrodocumento
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function AgregarVenta(ByVal lventa As LVenta) As Boolean

        Try
            conectar()
            Dim cmd As New SqlCommand("AgregarVenta", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@idempleado", LVenta._idempleado)
                .AddWithValue("@idcliente", LVenta._idcliente)
                .AddWithValue("@nrodocumento", LVenta._nrodocumento)
                .AddWithValue("@tipodocumento", LVenta._tipodocumento)
                .AddWithValue("@fechaventa", LVenta._fechaventa)
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

    Public Function DeshacerVenta(ByVal ldetalleventa As LDetalleVenta) As Boolean
        Try
            conectar()
            Dim cmd As New SqlCommand("DeshacerVenta", con)
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

    
End Class
