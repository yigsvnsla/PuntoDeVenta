Imports System.Data.SqlClient
Imports System.Configuration
Module ModuloObtnerUsuario
    Public con As New SqlConnection(ConfigurationManager.ConnectionStrings("dbventas").ToString)

    ' Esta funcion se encargara de abrir la conexion a la base de datos
    Public Sub conectar()
        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    ' Esta funcion se encargara de cerrar la conexion a la base de datos
    Public Sub desconectar()
        Try
            ' Verificamos que la conexion este abierta
            If con.State = ConnectionState.Open Then
                ' Sea el caso que este abierta, la cerraremos.
                con.Close()
            End If
            ' Si ya se encuentra cerrada, no hara nada.
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Dim rango As Integer

    Public Function obtenerRango(ByVal _usuario As String)

        Try
            conectar()
            Dim ejecutar As New SqlCommand("select * from usuario where usuario ='" & _usuario & "'", con)
            Dim l As SqlDataReader = ejecutar.ExecuteReader
            If l.HasRows = True Then
                While l.Read
                    rango = l(1)
                End While
                l.Close()
            End If

        Catch ex As Exception
            MsgBox("error" & ex.ToString)
        End Try
        desconectar()
        Return rango
    End Function

    Public Function x(ByVal _x As Integer)

        Dim y As String = String.Empty
        conectar()
        Dim ejecutar As New SqlCommand("select * from empleado where idempleado = '" & _x & "'", con)
        Dim l As SqlDataReader = ejecutar.ExecuteReader
        If l.HasRows = True Then
            While l.Read
                y = l(1)
            End While
            l.Close()
        End If
        desconectar()
        Return y
    End Function
End Module
