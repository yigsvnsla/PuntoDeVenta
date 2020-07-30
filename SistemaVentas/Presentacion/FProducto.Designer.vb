<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FProducto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cbocategoria = New System.Windows.Forms.ComboBox()
        Me.btnCategoria = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.txtpreciocompra = New System.Windows.Forms.TextBox()
        Me.txtprecioventa = New System.Windows.Forms.TextBox()
        Me.txtfechavencimiento = New System.Windows.Forms.DateTimePicker()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cbocategoria
        '
        Me.cbocategoria.FormattingEnabled = True
        Me.cbocategoria.Location = New System.Drawing.Point(15, 25)
        Me.cbocategoria.Name = "cbocategoria"
        Me.cbocategoria.Size = New System.Drawing.Size(121, 21)
        Me.cbocategoria.TabIndex = 0
        '
        'btnCategoria
        '
        Me.btnCategoria.Location = New System.Drawing.Point(142, 25)
        Me.btnCategoria.Name = "btnCategoria"
        Me.btnCategoria.Size = New System.Drawing.Size(108, 21)
        Me.btnCategoria.TabIndex = 1
        Me.btnCategoria.Text = "Categoria"
        Me.btnCategoria.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Categoria:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripcion:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Stock:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Precio Compra:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Precio Venta:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Fecha Vencimiento:"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(15, 65)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(165, 20)
        Me.txtnombre.TabIndex = 9
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(15, 104)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(165, 32)
        Me.txtdescripcion.TabIndex = 10
        '
        'txtstock
        '
        Me.txtstock.Location = New System.Drawing.Point(15, 155)
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(63, 20)
        Me.txtstock.TabIndex = 11
        '
        'txtpreciocompra
        '
        Me.txtpreciocompra.Location = New System.Drawing.Point(15, 194)
        Me.txtpreciocompra.Name = "txtpreciocompra"
        Me.txtpreciocompra.Size = New System.Drawing.Size(76, 20)
        Me.txtpreciocompra.TabIndex = 12
        '
        'txtprecioventa
        '
        Me.txtprecioventa.Location = New System.Drawing.Point(13, 233)
        Me.txtprecioventa.Name = "txtprecioventa"
        Me.txtprecioventa.Size = New System.Drawing.Size(78, 20)
        Me.txtprecioventa.TabIndex = 13
        '
        'txtfechavencimiento
        '
        Me.txtfechavencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfechavencimiento.Location = New System.Drawing.Point(13, 272)
        Me.txtfechavencimiento.Name = "txtfechavencimiento"
        Me.txtfechavencimiento.Size = New System.Drawing.Size(108, 20)
        Me.txtfechavencimiento.TabIndex = 14
        '
        'btnaceptar
        '
        Me.btnaceptar.Location = New System.Drawing.Point(33, 307)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(88, 30)
        Me.btnaceptar.TabIndex = 15
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(142, 307)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(88, 30)
        Me.btnsalir.TabIndex = 16
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(186, 65)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(64, 20)
        Me.txtid.TabIndex = 17
        Me.txtid.Visible = False
        '
        'FProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 348)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.txtfechavencimiento)
        Me.Controls.Add(Me.txtprecioventa)
        Me.Controls.Add(Me.txtpreciocompra)
        Me.Controls.Add(Me.txtstock)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCategoria)
        Me.Controls.Add(Me.cbocategoria)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(293, 382)
        Me.MinimumSize = New System.Drawing.Size(293, 382)
        Me.Name = "FProducto"
        Me.Text = "FProducto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbocategoria As System.Windows.Forms.ComboBox
    Friend WithEvents btnCategoria As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtstock As System.Windows.Forms.TextBox
    Friend WithEvents txtpreciocompra As System.Windows.Forms.TextBox
    Friend WithEvents txtprecioventa As System.Windows.Forms.TextBox
    Friend WithEvents txtfechavencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents txtid As System.Windows.Forms.TextBox
End Class
