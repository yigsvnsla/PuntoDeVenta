Imports System.Data.SqlClient
Public Class DCargo
    Inherits Dconexion
    Public Function MostrarCargo() As DataTable
        Try
            conectar()
            Dim cmd As New SqlCommand("MostrarCargo", con)
            cmd.CommandType = CommandType.StoredProcedure

            Dim tablacargo As New DataTable

            If cmd.ExecuteNonQuery Then
                Dim adaptador As New SqlDataAdapter(cmd)
                adaptador.Fill(tablacargo)
                Return tablacargo
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
    Public Function AgregarCargo(ByVal lcargo As LCargo) As Boolean
        Try
            conectar()
            Dim cmd As New SqlCommand("AgregarCargo", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@descripcion", lcargo._descripcion)

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
