Imports System.Data.SqlClient
Public Class DCategoria
    Inherits Dconexion
     ' Este clase se encarga de agregar y consultar los cargos disponibles en la base de datos

    ' Esta funcion devuelve un DataTable con la informacion de todas las categorias existentes en la base de datos
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

    ' Esta funcion es la encargada de registrar nuevas categorias en la base de datos
    ' Recibe por parametros un objeto tipo LCategoria, el cual contiene toda la informacion necesaria
    ' Para realizar el registro en la base de datos.
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
