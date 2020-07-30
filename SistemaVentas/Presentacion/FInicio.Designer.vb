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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.lbldia = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblequipo = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnventas = New System.Windows.Forms.Button()
        Me.btnproductos = New System.Windows.Forms.Button()
        Me.btnempleados = New System.Windows.Forms.Button()
        Me.btnclientes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(171, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(668, 399)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SkyBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(839, 53)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Sistema de Ventas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.SkyBlue
        Me.Label2.Location = New System.Drawing.Point(554, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "by LouixChambi"
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.BackColor = System.Drawing.Color.SkyBlue
        Me.lblhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.Location = New System.Drawing.Point(738, 17)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(54, 25)
        Me.lblhora.TabIndex = 7
        Me.lblhora.Text = "0:00"
        '
        'lbldia
        '
        Me.lbldia.AutoSize = True
        Me.lbldia.BackColor = System.Drawing.Color.SkyBlue
        Me.lbldia.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldia.Location = New System.Drawing.Point(4, 22)
        Me.lbldia.Name = "lbldia"
        Me.lbldia.Size = New System.Drawing.Size(29, 31)
        Me.lbldia.TabIndex = 7
        Me.lbldia.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.SkyBlue
        Me.Label4.Location = New System.Drawing.Point(3, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nombre de Equipo:"
        '
        'lblequipo
        '
        Me.lblequipo.AutoSize = True
        Me.lblequipo.BackColor = System.Drawing.Color.SkyBlue
        Me.lblequipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblequipo.Location = New System.Drawing.Point(100, 3)
        Me.lblequipo.Name = "lblequipo"
        Me.lblequipo.Size = New System.Drawing.Size(14, 13)
        Me.lblequipo.TabIndex = 7
        Me.lblequipo.Text = "0"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'btnSalir
        '
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Image = Global.SistemaVentas.My.Resources.Resources.salir_black
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(6, 410)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(88, 32)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnventas
        '
        Me.btnventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnventas.Image = Global.SistemaVentas.My.Resources.Resources.ventas_converted
        Me.btnventas.Location = New System.Drawing.Point(6, 259)
        Me.btnventas.Name = "btnventas"
        Me.btnventas.Size = New System.Drawing.Size(153, 50)
        Me.btnventas.TabIndex = 6
        Me.btnventas.Text = "Ventas"
        Me.btnventas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnventas.UseVisualStyleBackColor = True
        '
        'btnproductos
        '
        Me.btnproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnproductos.Image = Global.SistemaVentas.My.Resources.Resources.productos_converted
        Me.btnproductos.Location = New System.Drawing.Point(6, 203)
        Me.btnproductos.Name = "btnproductos"
        Me.btnproductos.Size = New System.Drawing.Size(153, 50)
        Me.btnproductos.TabIndex = 3
        Me.btnproductos.Text = "Productos"
        Me.btnproductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnproductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnproductos.UseVisualStyleBackColor = True
        '
        'btnempleados
        '
        Me.btnempleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnempleados.Image = Global.SistemaVentas.My.Resources.Resources.Empleados_converted
        Me.btnempleados.Location = New System.Drawing.Point(6, 146)
        Me.btnempleados.Name = "btnempleados"
        Me.btnempleados.Size = New System.Drawing.Size(153, 50)
        Me.btnempleados.TabIndex = 2
        Me.btnempleados.Text = "Empleados"
        Me.btnempleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnempleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnempleados.UseVisualStyleBackColor = True
        '
        'btnclientes
        '
        Me.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclientes.Image = Global.SistemaVentas.My.Resources.Resources.Clientes_converted
        Me.btnclientes.Location = New System.Drawing.Point(6, 89)
        Me.btnclientes.Name = "btnclientes"
        Me.btnclientes.Size = New System.Drawing.Size(153, 50)
        Me.btnclientes.TabIndex = 1
        Me.btnclientes.Text = "Clientes"
        Me.btnclientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnclientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnclientes.UseVisualStyleBackColor = True
        '
        'FInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 456)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblequipo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbldia)
        Me.Controls.Add(Me.lblhora)
        Me.Controls.Add(Me.btnventas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnproductos)
        Me.Controls.Add(Me.btnempleados)
        Me.Controls.Add(Me.btnclientes)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(855, 490)
        Me.MinimumSize = New System.Drawing.Size(855, 490)
        Me.Name = "FInicio"
        Me.Text = "FInicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnclientes As System.Windows.Forms.Button
    Friend WithEvents btnempleados As System.Windows.Forms.Button
    Friend WithEvents btnproductos As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnventas As System.Windows.Forms.Button
    Friend WithEvents lblhora As System.Windows.Forms.Label
    Friend WithEvents lbldia As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblequipo As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class
