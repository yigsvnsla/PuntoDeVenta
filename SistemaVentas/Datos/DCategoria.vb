Imports System.Data.SqlClient
Public Class DCategoria
    Inherits Dconexion
    Public Function MostrarCategoria() As DataTable
        Try
            conectar()
            Dim cmd As New SqlCommand("MostrarCategoria", con)
            cmd.CommandType = CommandType.StoredProcedure

            Dim tablacategoria As New DataTable

            If cmd.ExecuteNonQuery Then
                Dim adaptador As New SqlDataAdapter(cmd)
                adaptador.Fill(tablacategoria)
                Return tablacategoria
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
    Public Function AgregarCategoria(ByVal lcategoria As LCategoria) As Boolean
        Try
            conectar()
            Dim cmd As New SqlCommand("AgregarCategoria", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@descripcion", lcategoria._descripcion)

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
