Imports System.Data.SqlClient
Public Class FProducto
    Public idcategoria As Integer
    Dim valores As New LProductos
    Dim funcionespro As New DProductos
    Dim funcionescat As New DCategoria
    Private Sub FProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarcategorias()
    End Sub
    Public Sub AgregarProducto()
        Try
            valores._idcategoria = Convert.ToInt32(cbocategoria.SelectedValue.ToString)
            valores._nombre = txtnombre.Text
            valores._descripcion = txtdescripcion.Text
            valores._stock = Convert.ToInt32(txtstock.Text)
            valores._preciocompra = Convert.ToDecimal(txtpreciocompra.Text)
            valores._precioventa = Convert.ToDecimal(txtprecioventa.Text)
            valores._fechavencimiento = txtfechavencimiento.Value

            If funcionespro.AgregarProducto(valores) Then
                MsgBox("Producto Agregado Correctamente", MsgBoxStyle.Information, "Registro de Producto")

            Else
                MsgBox("Producto No Agregado Correctamente", MsgBoxStyle.Information, "Registro de Producto")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub EditarProducto()
        Try
            valores._idproducto = Convert.ToInt32(txtid.Text)
            valores._idcategoria = Convert.ToInt32(cbocategoria.SelectedValue.ToString)
            valores._nombre = txtnombre.Text
            valores._descripcion = txtdescripcion.Text
            valores._stock = Convert.ToInt32(txtstock.Text)
            valores._preciocompra = Convert.ToDecimal(txtpreciocompra.Text)
            valores._precioventa = Convert.ToDecimal(txtprecioventa.Text)
            valores._fechavencimiento = txtfechavencimiento.Text

            If funcionespro.EditarProducto(valores) Then
                MsgBox("Producto Editado Correctamente", MsgBoxStyle.Information, "Registro de Producto")

            Else
                MsgBox("Producto No Editado Correctamente", MsgBoxStyle.Information, "Registro de Producto")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cargarcategorias()
        Try
            cbocategoria.DataSource = funcionescat.MostrarCategoria

            cbocategoria.DisplayMember = "descripcion"
            cbocategoria.ValueMember = "idcategoria"

            If idcategoria <> 0 Then
                cbocategoria.SelectedValue = idcategoria
            End If
            idcategoria = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        If txtnombre.Text = "" Or txtdescripcion.Text = "" Or txtstock.Text = "" Or txtpreciocompra.Text = "" Or txtprecioventa.Text = "" Then
            MsgBox("Complete Todos Los Datos Porfavor", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            Exit Sub
        End If


        If txtid.Text <> "" Then
            If MsgBox("¿Desesa Guardar los Cambios?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje del Sistema") = MsgBoxResult.No Then
                Exit Sub
            End If
            EditarProducto()
        Else
            AgregarProducto()
        End If

        Me.txtid.Text = ""
        FListadoProductos.mostrarproductos()
        Me.Close()

    End Sub

    Private Sub btnCategoria_Click(sender As Object, e As EventArgs) Handles btnCategoria.Click
        Dim ventana As New FCategoria
        ventana.ShowDialog()

        cargarcategorias()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        cbocategoria.SelectedValue = 7
    End Sub
End Class