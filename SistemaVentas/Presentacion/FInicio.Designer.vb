<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FInicio
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnventas = New System.Windows.Forms.Button()
        Me.btnproductos = New System.Windows.Forms.Button()
        Me.btnempleados = New System.Windows.Forms.Button()
        Me.btnclientes = New System.Windows.Forms.Button()
        Me.LabelHoraFecha = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(178, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(658, 394)
        Me.Panel1.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel2.Controls.Add(Me.LabelHoraFecha)
        Me.Panel2.Controls.Add(Me.btnSalir)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(839, 50)
        Me.Panel2.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(317, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " ABASTO ""SAN JOSE"".s.a"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SistemaVentas.My.Resources.Resources._048_medical
        Me.PictureBox1.Location = New System.Drawing.Point(263, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.SistemaVentas.My.Resources.Resources.salir_black
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(734, 8)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(72, 34)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnventas
        '
        Me.btnventas.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.btnventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnventas.Image = Global.SistemaVentas.My.Resources.Resources.ventas_converted
        Me.btnventas.Location = New System.Drawing.Point(6, 385)
        Me.btnventas.Name = "btnventas"
        Me.btnventas.Size = New System.Drawing.Size(158, 50)
        Me.btnventas.TabIndex = 6
        Me.btnventas.Text = "Ventas"
        Me.btnventas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnventas.UseVisualStyleBackColor = True
        '
        'btnproductos
        '
        Me.btnproductos.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.btnproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnproductos.Image = Global.SistemaVentas.My.Resources.Resources.productos_converted
        Me.btnproductos.Location = New System.Drawing.Point(6, 329)
        Me.btnproductos.Name = "btnproductos"
        Me.btnproductos.Size = New System.Drawing.Size(158, 50)
        Me.btnproductos.TabIndex = 3
        Me.btnproductos.Text = "Productos"
        Me.btnproductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnproductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnproductos.UseVisualStyleBackColor = True
        '
        'btnempleados
        '
        Me.btnempleados.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.btnempleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnempleados.Image = Global.SistemaVentas.My.Resources.Resources.Empleados_converted
        Me.btnempleados.Location = New System.Drawing.Point(6, 272)
        Me.btnempleados.Name = "btnempleados"
        Me.btnempleados.Size = New System.Drawing.Size(158, 50)
        Me.btnempleados.TabIndex = 2
        Me.btnempleados.Text = "Empleados"
        Me.btnempleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnempleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnempleados.UseVisualStyleBackColor = True
        '
        'btnclientes
        '
        Me.btnclientes.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclientes.Image = Global.SistemaVentas.My.Resources.Resources.Clientes_converted
        Me.btnclientes.Location = New System.Drawing.Point(6, 215)
        Me.btnclientes.Name = "btnclientes"
        Me.btnclientes.Size = New System.Drawing.Size(158, 50)
        Me.btnclientes.TabIndex = 1
        Me.btnclientes.Text = "Clientes"
        Me.btnclientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnclientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnclientes.UseVisualStyleBackColor = True
        '
        'LabelHoraFecha
        '
        Me.LabelHoraFecha.AutoSize = True
        Me.LabelHoraFecha.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHoraFecha.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelHoraFecha.Location = New System.Drawing.Point(12, 17)
        Me.LabelHoraFecha.Name = "LabelHoraFecha"
        Me.LabelHoraFecha.Size = New System.Drawing.Size(140, 17)
        Me.LabelHoraFecha.TabIndex = 2
        Me.LabelHoraFecha.Text = "DD/MM/AAAA ##:##"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SistemaVentas.My.Resources.Resources.dibujos_animados_san_jose_76844_1209
        Me.PictureBox2.Location = New System.Drawing.Point(6, 56)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(158, 147)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnproductos)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.btnventas)
        Me.Panel3.Controls.Add(Me.btnclientes)
        Me.Panel3.Controls.Add(Me.btnempleados)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(172, 450)
        Me.Panel3.TabIndex = 10
        '
        'FInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(839, 451)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(855, 490)
        Me.MinimumSize = New System.Drawing.Size(855, 490)
        Me.Name = "FInicio"
        Me.Text = "FInicio"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnclientes As System.Windows.Forms.Button
    Friend WithEvents btnempleados As System.Windows.Forms.Button
    Friend WithEvents btnproductos As System.Windows.Forms.Button
    Friend WithEvents btnventas As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelHoraFecha As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
