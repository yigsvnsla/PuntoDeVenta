Imports System.Data.SqlClient
Public Class DUsuarios
    Inherits Dconexion
    Public Function AccederUsuario(ByVal lusuario As LUsuario) As Boolean
        Try
            conectar()
            Dim cmd As New SqlCommand("AccederUsuario", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@usuario", lusuario._usuario)
                .AddWithValue("@contraseña", lusuario._contraseña)
            End With

            Dim dr As SqlDataReader

            dr = cmd.ExecuteReader

            If dr.HasRows Then
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
    Public Function AgregarUsuario(ByVal lusuario As LUsuario) As Boolean
        Try
            conectar()
            Dim cmd As New SqlCommand("AgregarUsuario", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@idempleado", lusuario._idempleado)
                .AddWithValue("@usuario", lusuario._usuario)
                .AddWithValue("@contraseña", lusuario._contraseña)
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

    Public Function VerificarUsuario(ByVal lusuario As LUsuario) As Boolean

        Try
            conectar()
            Dim cmd As New SqlCommand("VerificarUsuario", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@idempleado", lusuario._idempleado)
            End With

            Dim dr As SqlDataReader

            dr = cmd.ExecuteReader

            If dr.HasRows Then
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
