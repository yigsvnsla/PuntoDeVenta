<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fLogin
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
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.txtcontraseña = New System.Windows.Forms.TextBox()
        Me.btniniciar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelCabezera = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCabezera.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtusuario
        '
        Me.txtusuario.BackColor = System.Drawing.SystemColors.Control
        Me.txtusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusuario.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtusuario.Location = New System.Drawing.Point(11, 8)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(174, 31)
        Me.txtusuario.TabIndex = 0
        Me.txtusuario.Text = "jchambi"
        '
        'txtcontraseña
        '
        Me.txtcontraseña.BackColor = System.Drawing.SystemColors.Control
        Me.txtcontraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontraseña.Location = New System.Drawing.Point(11, 45)
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtcontraseña.Size = New System.Drawing.Size(174, 31)
        Me.txtcontraseña.TabIndex = 1
        Me.txtcontraseña.Text = "123456"
        '
        'btniniciar
        '
        Me.btniniciar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btniniciar.FlatAppearance.BorderSize = 0
        Me.btniniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btniniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btniniciar.ForeColor = System.Drawing.Color.White
        Me.btniniciar.Location = New System.Drawing.Point(144, 225)
        Me.btniniciar.Name = "btniniciar"
        Me.btniniciar.Size = New System.Drawing.Size(97, 38)
        Me.btniniciar.TabIndex = 3
        Me.btniniciar.Text = "Iniciar"
        Me.btniniciar.UseVisualStyleBackColor = False
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnsalir.FlatAppearance.BorderSize = 0
        Me.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.ForeColor = System.Drawing.Color.White
        Me.btnsalir.Location = New System.Drawing.Point(29, 225)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(103, 38)
        Me.btnsalir.TabIndex = 3
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnsalir)
        Me.Panel1.Controls.Add(Me.btniniciar)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Location = New System.Drawing.Point(72, 96)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(271, 278)
        Me.Panel1.TabIndex = 9
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.SistemaVentas.My.Resources.Resources.logo_farmatic_vec_png
        Me.PictureBox6.Location = New System.Drawing.Point(-8, 7)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(283, 127)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 13
        Me.PictureBox6.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.txtcontraseña)
        Me.Panel2.Controls.Add(Me.txtusuario)
        Me.Panel2.Location = New System.Drawing.Point(17, 124)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(237, 85)
        Me.Panel2.TabIndex = 6
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SistemaVentas.My.Resources.Resources.padlock_1
        Me.PictureBox2.Location = New System.Drawing.Point(193, 45)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 31)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SistemaVentas.My.Resources.Resources.login1
        Me.PictureBox1.Location = New System.Drawing.Point(193, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PanelCabezera
        '
        Me.PanelCabezera.BackColor = System.Drawing.Color.DimGray
        Me.PanelCabezera.Controls.Add(Me.PictureBox5)
        Me.PanelCabezera.Controls.Add(Me.Label1)
        Me.PanelCabezera.Controls.Add(Me.btnCerrar)
        Me.PanelCabezera.Controls.Add(Me.btnMinimizar)
        Me.PanelCabezera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCabezera.ForeColor = System.Drawing.Color.White
        Me.PanelCabezera.Location = New System.Drawing.Point(0, 0)
        Me.PanelCabezera.Name = "PanelCabezera"
        Me.PanelCabezera.Size = New System.Drawing.Size(414, 43)
        Me.PanelCabezera.TabIndex = 10
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.SistemaVentas.My.Resources.Resources.cslogin_94432
        Me.PictureBox5.Location = New System.Drawing.Point(12, 1)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 12
        Me.PictureBox5.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 35)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Iniciar"
        '
        'btnCerrar
        '
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Image = Global.SistemaVentas.My.Resources.Resources.cancel
        Me.btnCerrar.Location = New System.Drawing.Point(353, 6)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(30, 30)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCerrar.TabIndex = 11
        Me.btnCerrar.TabStop = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.Image = Global.SistemaVentas.My.Resources.Resources.minimize_1
        Me.btnMinimizar.Location = New System.Drawing.Point(322, 9)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(25, 25)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMinimizar.TabIndex = 0
        Me.btnMinimizar.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DimGray
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.ForeColor = System.Drawing.SystemColors.Control
        Me.Panel4.Location = New System.Drawing.Point(0, 431)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(414, 44)
        Me.Panel4.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(104, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 28)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "I.U.P.S.M  -  Maracay"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'fLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(414, 475)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.PanelCabezera)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCabezera.ResumeLayout(False)
        Me.PanelCabezera.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtusuario As System.Windows.Forms.TextBox
    Friend WithEvents txtcontraseña As System.Windows.Forms.TextBox
    Friend WithEvents btniniciar As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PanelCabezera As System.Windows.Forms.Panel
    Friend WithEvents btnCerrar As System.Windows.Forms.PictureBox
    Friend WithEvents btnMinimizar As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider

End Class
