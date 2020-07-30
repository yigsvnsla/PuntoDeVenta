Imports System.Data.SqlClient
Public Class DProductos
    Inherits Dconexion

    Public Function MostrarProductos() As DataTable

        Try
            conectar()
            Dim cmd As New SqlCommand("MostrarProductos", con)
            Dim tablaproductos As New DataTable
            Dim adaptador As New SqlDataAdapter(cmd)


            If cmd.ExecuteNonQuery Then
                adaptador.Fill(tablaproductos)
                Return tablaproductos
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
    Public Function AgregarProducto(ByVal lproductos As LProductos) As Boolean
        Try
            conectar()
            Dim cmd As New SqlCommand("AgregarProducto", con)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@idcategoria", lproductos._idcategoria)
                .AddWithValue("@nombre", lproductos._nombre)
                .AddWithValue("@descripcion", lproductos._descripcion)
                .AddWithValue("@stock", lproductos._stock)
                .AddWithValue("@preciocompra", lproductos._preciocompra)
                .AddWithValue("@precioventa", lproductos._precioventa)
                .AddWithValue("@fechavencimiento", lproductos._fechavencimiento)
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

    Public Function EditarProducto(ByVal lproductos As LProductos) As Boolean
        Try
            conectar()
            Dim cmd As New SqlCommand("EditarProducto", con)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .AddWithValue("@idproducto", lproductos._idproducto)
                .AddWithValue("@idcategoria", lproductos._idcategoria)
                .AddWithValue("@nombre", lproductos._nombre)
                .AddWithValue("@descripcion", lproductos._descripcion)
                .AddWithValue("@stock", lproductos._stock)
                .AddWithValue("@preciocompra", lproductos._preciocompra)
                .AddWithValue("@precioventa", lproductos._precioventa)
                .AddWithValue("@fechavencimiento", lproductos._fechavencimiento)
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
