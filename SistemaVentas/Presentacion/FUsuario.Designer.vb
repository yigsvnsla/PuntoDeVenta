<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FUsuario
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcargo = New System.Windows.Forms.TextBox()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtnya = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkver = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcontraseña = New System.Windows.Forms.TextBox()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.btbgrabar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtcargo)
        Me.GroupBox1.Controls.Add(Me.txtdni)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Controls.Add(Me.txtnya)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(379, 80)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Empleado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(195, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cargo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dni:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombres y Apellidos:"
        '
        'txtcargo
        '
        Me.txtcargo.Location = New System.Drawing.Point(239, 48)
        Me.txtcargo.Name = "txtcargo"
        Me.txtcargo.ReadOnly = True
        Me.txtcargo.Size = New System.Drawing.Size(114, 20)
        Me.txtcargo.TabIndex = 0
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(50, 48)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.ReadOnly = True
        Me.txtdni.Size = New System.Drawing.Size(139, 20)
        Me.txtdni.TabIndex = 0
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(359, 19)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(47, 20)
        Me.txtid.TabIndex = 0
        Me.txtid.Visible = False
        '
        'txtnya
        '
        Me.txtnya.Location = New System.Drawing.Point(120, 19)
        Me.txtnya.Name = "txtnya"
        Me.txtnya.ReadOnly = True
        Me.txtnya.Size = New System.Drawing.Size(233, 20)
        Me.txtnya.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkver)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtcontraseña)
        Me.GroupBox2.Controls.Add(Me.txtusuario)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(379, 62)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Usuario"
        '
        'chkver
        '
        Me.chkver.AutoSize = True
        Me.chkver.Location = New System.Drawing.Point(266, 34)
        Me.chkver.Name = "chkver"
        Me.chkver.Size = New System.Drawing.Size(99, 17)
        Me.chkver.TabIndex = 3
        Me.chkver.Text = "Ver Contraseña"
        Me.chkver.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(157, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Contraseña:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Usuario:"
        '
        'txtcontraseña
        '
        Me.txtcontraseña.Location = New System.Drawing.Point(160, 34)
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtcontraseña.Size = New System.Drawing.Size(100, 20)
        Me.txtcontraseña.TabIndex = 1
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(12, 34)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(124, 20)
        Me.txtusuario.TabIndex = 0
        '
        'btbgrabar
        '
        Me.btbgrabar.Location = New System.Drawing.Point(12, 175)
        Me.btbgrabar.Name = "btbgrabar"
        Me.btbgrabar.Size = New System.Drawing.Size(139, 23)
        Me.btbgrabar.TabIndex = 3
        Me.btbgrabar.Text = "Grabar"
        Me.btbgrabar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(238, 175)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(139, 23)
        Me.btnsalir.TabIndex = 4
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'FUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 207)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btbgrabar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(419, 241)
        Me.MinimumSize = New System.Drawing.Size(419, 241)
        Me.Name = "FUsuario"
        Me.Text = "FUsuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcargo As System.Windows.Forms.TextBox
    Friend WithEvents txtdni As System.Windows.Forms.TextBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtnya As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btbgrabar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcontraseña As System.Windows.Forms.TextBox
    Friend WithEvents txtusuario As System.Windows.Forms.TextBox
    Friend WithEvents chkver As System.Windows.Forms.CheckBox
    Friend WithEvents btnsalir As System.Windows.Forms.Button
End Class
