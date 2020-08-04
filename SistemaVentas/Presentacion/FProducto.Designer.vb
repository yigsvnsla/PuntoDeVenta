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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbocategoria
        '
        Me.cbocategoria.FormattingEnabled = True
        Me.cbocategoria.Location = New System.Drawing.Point(11, 40)
        Me.cbocategoria.Name = "cbocategoria"
        Me.cbocategoria.Size = New System.Drawing.Size(121, 21)
        Me.cbocategoria.TabIndex = 0
        '
        'btnCategoria
        '
        Me.btnCategoria.Location = New System.Drawing.Point(138, 40)
        Me.btnCategoria.Name = "btnCategoria"
        Me.btnCategoria.Size = New System.Drawing.Size(108, 21)
        Me.btnCategoria.TabIndex = 1
        Me.btnCategoria.Text = "Agregar"
        Me.btnCategoria.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Categoria:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripcion:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Stock:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Precio Compra:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Precio Venta:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Fecha Vencimiento:"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(11, 80)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(165, 20)
        Me.txtnombre.TabIndex = 9
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(11, 119)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(165, 35)
        Me.txtdescripcion.TabIndex = 10
        '
        'txtstock
        '
        Me.txtstock.Location = New System.Drawing.Point(32, 38)
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(63, 20)
        Me.txtstock.TabIndex = 11
        '
        'txtpreciocompra
        '
        Me.txtpreciocompra.Location = New System.Drawing.Point(32, 78)
        Me.txtpreciocompra.Name = "txtpreciocompra"
        Me.txtpreciocompra.Size = New System.Drawing.Size(76, 20)
        Me.txtpreciocompra.TabIndex = 12
        '
        'txtprecioventa
        '
        Me.txtprecioventa.Location = New System.Drawing.Point(32, 117)
        Me.txtprecioventa.Name = "txtprecioventa"
        Me.txtprecioventa.Size = New System.Drawing.Size(78, 20)
        Me.txtprecioventa.TabIndex = 13
        '
        'txtfechavencimiento
        '
        Me.txtfechavencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfechavencimiento.Location = New System.Drawing.Point(32, 156)
        Me.txtfechavencimiento.Name = "txtfechavencimiento"
        Me.txtfechavencimiento.Size = New System.Drawing.Size(108, 20)
        Me.txtfechavencimiento.TabIndex = 14
        '
        'btnaceptar
        '
        Me.btnaceptar.Location = New System.Drawing.Point(120, 283)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(88, 30)
        Me.btnaceptar.TabIndex = 15
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(229, 283)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(88, 30)
        Me.btnsalir.TabIndex = 16
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(182, 80)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(64, 20)
        Me.txtid.TabIndex = 17
        Me.txtid.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(437, 38)
        Me.Panel1.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtprecioventa)
        Me.GroupBox1.Controls.Add(Me.txtpreciocompra)
        Me.GroupBox1.Controls.Add(Me.txtstock)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtfechavencimiento)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(267, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(156, 211)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtid)
        Me.GroupBox2.Controls.Add(Me.txtdescripcion)
        Me.GroupBox2.Controls.Add(Me.txtnombre)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btnCategoria)
        Me.GroupBox2.Controls.Add(Me.cbocategoria)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 85)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(257, 179)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Prodcutos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(103, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(231, 31)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Datos Productos"
        '
        'FProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 323)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnaceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FProducto"
        Me.Text = "Producto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
