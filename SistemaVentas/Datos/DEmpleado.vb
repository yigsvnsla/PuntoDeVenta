Imports System.Data.SqlClient
Public Class DEmpleado
    Inherits Dconexion
    Public Function MostrarEmpleado() As DataTable

        Try
            conectar()
            Dim cmd As New SqlCommand("MostrarEmpleados", con)
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
    Public Function AgregarEmpleado(ByVal lempleado As LEmpleados) As Boolean
        Try
            conectar()
            Dim cmd As New SqlCommand("AgregarEmpleado", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@idcargo", lempleado._idcargo)
                .AddWithValue("@nombre", lempleado._nombre)
                .AddWithValue("@apellidos", lempleado._apellidos)
                .AddWithValue("@sexo", lempleado._sexo)
                .AddWithValue("@dni", lempleado._dni)
                .AddWithValue("@fechanac", lempleado._fechanacimiento)
                .AddWithValue("@direccion", lempleado._direccion)
                .AddWithValue("@estadocivil", lempleado._estadocivil)
                .AddWithValue("@estado", lempleado._estado)
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

    Public Function EditarEmpleado(ByVal lempleado As LEmpleados) As Boolean
        Try
            conectar()
            Dim cmd As New SqlCommand("EditarEmpleado", con)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .AddWithValue("@idempleado", lempleado._idempleado)
                .AddWithValue("@idcargo", lempleado._idcargo)
                .AddWithValue("@nombre", lempleado._nombre)
                .AddWithValue("@apellidos", lempleado._apellidos)
                .AddWithValue("@sexo", lempleado._sexo)
                .AddWithValue("@dni", lempleado._dni)
                .AddWithValue("@fechanac", lempleado._fechanacimiento)
                .AddWithValue("@direccion", lempleado._direccion)
                .AddWithValue("@estadocivil", lempleado._estadocivil)
                .AddWithValue("@estado", lempleado._estado)
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
