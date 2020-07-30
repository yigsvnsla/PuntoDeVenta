Public Class FVenta
    Dim registroventa As Integer = 0
    Dim valoresventa As New LVenta
    Dim valoresdetalleventa As New LDetalleVenta
    Dim funcionesventa As New DVenta
    Dim funcionesdetalleventa As New DDetalleVenta

    Private Sub FVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'GENERA EL NUMERO DE SERIE DE LA BOLETA DE VENTA
        lblnrodoc.Text = funcionesventa.ObtenerNroDocumento
        LimpiarTexbox()
        Ordenarylimpiar()
    End Sub
    Private Sub btnbuscarE_Click(sender As Object, e As EventArgs) Handles btnbuscarE.Click
        Dim venta As New FListadoEmpleados
        venta.txtflag.Text = 1

        venta.ShowDialog()
    End Sub

    Private Sub btnbuscarC_Click(sender As Object, e As EventArgs) Handles btnbuscarC.Click
        Dim ventana As New FListadoClientes
        ventana.txtflag.Text = 1
        ventana.ShowDialog()

    End Sub


    Private Sub btnbuscarP_Click(sender As Object, e As EventArgs) Handles btnbuscarP.Click
        Dim ventana As New FListadoProductos
        ventana.lblflag.Text = 1
        ventana.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        ventana.ShowDialog()
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Try

            If registroventa = 0 Then

                If AgregarVenta() Then
                    If AgregarDetalleVenta() Then
                        registroventa = 1
                        VerRegistroVenta()
                        Ordenarylimpiar()
                    Else
                        MsgBox("Falta Ingresar Datos del Producto", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
                    End If
                Else
                    MsgBox("Falta Ingresar Datos Cliente o Empleado", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
                End If

            Else
                If AgregarDetalleVenta() Then

                    VerRegistroVenta()
                    Ordenarylimpiar()
                Else
                    MsgBox("Falta Ingresar Datos del Producto", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
                End If
            End If
          

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function AgregarVenta() As Boolean
        Try
            If lblidempleado.Text <> "0" And lblidcliente.Text <> "0" And txtcliente.Text <> "" Then

                valoresventa._idempleado = lblidempleado.Text
                valoresventa._idcliente = lblidcliente.Text
                valoresventa._nrodocumento = lblnrodoc.Text
                valoresventa._tipodocumento = cbotipodocumento.Text
                valoresventa._fechaventa = txtfecha.Text

                If funcionesventa.AgregarVenta(valoresventa) Then
                    txtidventa.Text = (funcionesdetalleventa.ObtenerIdVenta).ToString
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function
    Public Function AgregarDetalleVenta() As Boolean
        Try
            If txtidventa.Text <> "0" And lblidproducto.Text <> "0" Then
                valoresdetalleventa._idproducto = Convert.ToInt32(lblidproducto.Text)
                valoresdetalleventa._idventa = txtidventa.Text
                valoresdetalleventa._cantidad = txtcantidad.Value
                valoresdetalleventa._preciounitario = Convert.ToDecimal(txtprecio.Text)

                If funcionesdetalleventa.AgregarDetalleVenta(valoresdetalleventa) Then
                    If funcionesdetalleventa.Disminuirstock(valoresdetalleventa) Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Return False
                End If


            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Sub VerRegistroVenta()

        valoresdetalleventa._idventa = Convert.ToInt32(txtidventa.Text)
        listado.DataSource = funcionesdetalleventa.VerRegistroDetalleVenta(valoresdetalleventa)
        listado.Columns(0).Visible = False
        listado.Columns(1).Visible = False

        listado.ClearSelection()

        'ENVIAMOS LOS DATOS DE EL SUBTOTAL , IGV, TOTAL
        txtsubtotal.Text = "S./ " & FormatNumber((0.82 * Sumar("importe", listado)), 2)
        txtigv.Text = "S./ " & FormatNumber((0.18 * Sumar("importe", listado)), 2)
        txttotal.Text = "S./ " & FormatNumber(Sumar("importe", listado), 2).ToString
    End Sub
    Public Sub LimpiarTexbox()
        txtnya.Clear()
        txtcargo.Clear()
        txtcliente.Clear()
        txtdoc.Clear()

        txtsubtotal.Clear()
        txtigv.Clear()
        txttotal.Clear()
    End Sub
    Public Sub Ordenarylimpiar()
        Try      

            lblidproducto.Text = "0"
            txtproducto.Text = ""
            txtdescripcion.Text = ""
            txtstock.Text = ""
            txtprecio.Text = ""
            txtcantidad.Value = 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnregistrar_Click(sender As Object, e As EventArgs) Handles btnregistrar.Click
        Try
            If Trim(txtidventa.Text) = "0" Then
                MsgBox("La venta no Tiene registros aún", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            End If

            Dim ventana As New FComprobante
            ventana.idventa = Convert.ToInt32(Me.txtidventa.Text)
            ventana.ShowDialog()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

       
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            If listado.Rows.Count = 0 Then
                MsgBox("No existen Registros Aún", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
                Return
            End If

            If listado.SelectedRows.Count > 0 Then
                valoresdetalleventa._iddetalleventa = Me.listado.SelectedCells.Item(0).Value
                valoresdetalleventa._idproducto = Me.listado.SelectedCells.Item(1).Value
                valoresdetalleventa._cantidad = Me.listado.SelectedCells.Item(2).Value

                If funcionesdetalleventa.Aumentarstock(valoresdetalleventa) And funcionesdetalleventa.EliminarDetalleVenta(valoresdetalleventa) Then

                    VerRegistroVenta()
                Else
                    MsgBox("No se Puede Eliminar el Registro")
                End If
            Else
                MsgBox("Seleccione un Registro porfavor", MsgBoxStyle.Information, "Mensaje del Sistema")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub

    Private Function Sumar(ByVal nombre_Columna As String, ByVal Dgv As DataGridView) As Double
        Dim Total As Double = 0
        ' recorrer las filas y obtener los items de la columna indicada en "nombre_Columna"  
        
        Try

            If Dgv.RowCount > 0 Then
                For i As Integer = 0 To Dgv.RowCount - 1
                    Total = Total + CDbl(Dgv.Item(nombre_Columna.ToLower, i).Value)
                Next
                Return Total
            Else
                Return Nothing
            End If
          

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Return Nothing
        End Try

    End Function

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click

        Try
            If Trim(txtidventa.Text) = "0" Then
                Me.Close()
                Return
            End If

            valoresdetalleventa._idventa = Convert.ToInt32(txtidventa.Text)


            If funcionesventa.DeshacerVenta(valoresdetalleventa) Then

                For Each row As DataGridViewRow In listado.Rows
                    Dim idproducto As Integer = Convert.ToInt32(row.Cells("idproducto").Value)
                    Dim cantidad As Integer = Convert.ToInt32(row.Cells("cantidad").Value)

                    valoresdetalleventa._idproducto = idproducto
                    valoresdetalleventa._cantidad = cantidad


                    If funcionesdetalleventa.Aumentarstock(valoresdetalleventa) Then

                    End If

                Next

                Me.Close()

            Else
                MsgBox("Error al eliminar fuera", MsgBoxStyle.Information, "Mensaje del Sistema")
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class