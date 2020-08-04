<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FEmpleado
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
        Me.btncargo = New System.Windows.Forms.Button()
        Me.cbocargo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbosexo = New System.Windows.Forms.ComboBox()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtfechanacimiento = New System.Windows.Forms.DateTimePicker()
        Me.cboestadocivil = New System.Windows.Forms.ComboBox()
        Me.cboestado = New System.Windows.Forms.ComboBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btncargo
        '
        Me.btncargo.Location = New System.Drawing.Point(181, 30)
        Me.btncargo.Name = "btncargo"
        Me.btncargo.Size = New System.Drawing.Size(62, 23)
        Me.btncargo.TabIndex = 0
        Me.btncargo.Text = "Agregar"
        Me.btncargo.UseVisualStyleBackColor = True
        '
        'cbocargo
        '
        Me.cbocargo.FormattingEnabled = True
        Me.cbocargo.Location = New System.Drawing.Point(46, 33)
        Me.cbocargo.Name = "cbocargo"
        Me.cbocargo.Size = New System.Drawing.Size(129, 21)
        Me.cbocargo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cargo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Apellidos:"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(46, 72)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(170, 20)
        Me.txtnombre.TabIndex = 4
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(46, 111)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(170, 20)
        Me.txtapellido.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Sexo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Dni:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Fecha Nacimiento:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Direccion:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Estado Civil:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Estado:"
        '
        'cbosexo
        '
        Me.cbosexo.FormattingEnabled = True
        Me.cbosexo.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.cbosexo.Location = New System.Drawing.Point(46, 147)
        Me.cbosexo.Name = "cbosexo"
        Me.cbosexo.Size = New System.Drawing.Size(103, 21)
        Me.cbosexo.TabIndex = 11
        Me.cbosexo.Text = "Masculino"
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(46, 188)
        Me.txtdni.MaxLength = 8
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(100, 20)
        Me.txtdni.TabIndex = 12
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(25, 75)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(197, 20)
        Me.txtdireccion.TabIndex = 13
        '
        'txtfechanacimiento
        '
        Me.txtfechanacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfechanacimiento.Location = New System.Drawing.Point(25, 36)
        Me.txtfechanacimiento.Name = "txtfechanacimiento"
        Me.txtfechanacimiento.Size = New System.Drawing.Size(100, 20)
        Me.txtfechanacimiento.TabIndex = 14
        '
        'cboestadocivil
        '
        Me.cboestadocivil.FormattingEnabled = True
        Me.cboestadocivil.Items.AddRange(New Object() {"Casado(a)", "Soltero(a)", "Viudo(a)"})
        Me.cboestadocivil.Location = New System.Drawing.Point(25, 114)
        Me.cboestadocivil.Name = "cboestadocivil"
        Me.cboestadocivil.Size = New System.Drawing.Size(121, 21)
        Me.cboestadocivil.TabIndex = 15
        Me.cboestadocivil.Text = "Soltero(a)"
        '
        'cboestado
        '
        Me.cboestado.FormattingEnabled = True
        Me.cboestado.Items.AddRange(New Object() {"Activo", "No Activo"})
        Me.cboestado.Location = New System.Drawing.Point(25, 154)
        Me.cboestado.Name = "cboestado"
        Me.cboestado.Size = New System.Drawing.Size(121, 21)
        Me.cboestado.TabIndex = 16
        Me.cboestado.Text = "Activo"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(171, 291)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(88, 35)
        Me.btnAceptar.TabIndex = 17
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(261, 291)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(88, 35)
        Me.btnSalir.TabIndex = 18
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(168, 148)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(75, 20)
        Me.txtid.TabIndex = 19
        Me.txtid.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboestado)
        Me.GroupBox1.Controls.Add(Me.cboestadocivil)
        Me.GroupBox1.Controls.Add(Me.txtfechanacimiento)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtdireccion)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(277, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 195)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btncargo)
        Me.GroupBox2.Controls.Add(Me.txtid)
        Me.GroupBox2.Controls.Add(Me.cbocargo)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtdni)
        Me.GroupBox2.Controls.Add(Me.txtnombre)
        Me.GroupBox2.Controls.Add(Me.cbosexo)
        Me.GroupBox2.Controls.Add(Me.txtapellido)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(269, 220)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Empleado"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(525, 48)
        Me.Panel1.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(210, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 28)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Empleado"
        '
        'FEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 338)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FEmpleado"
        Me.Text = "FEmpleado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btncargo As System.Windows.Forms.Button
    Friend WithEvents cbocargo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents txtapellido As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbosexo As System.Windows.Forms.ComboBox
    Friend WithEvents txtdni As System.Windows.Forms.TextBox
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtfechanacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboestadocivil As System.Windows.Forms.ComboBox
    Friend WithEvents cboestado As System.Windows.Forms.ComboBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
