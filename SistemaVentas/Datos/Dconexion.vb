Imports System.Data.SqlClient
Imports System.Configuration
Public Class Dconexion
    ' Esta clase se encargara de gestionar las conexiones a la base de datos
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
End Class
