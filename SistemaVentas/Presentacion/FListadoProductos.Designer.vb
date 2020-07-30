<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FListadoProductos
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
        Me.cbobuscar = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.Listado = New System.Windows.Forms.DataGridView()
        Me.lblflag = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Listado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbobuscar
        '
        Me.cbobuscar.ForeColor = System.Drawing.Color.DodgerBlue
        Me.cbobuscar.FormattingEnabled = True
        Me.cbobuscar.Items.AddRange(New Object() {"producto", "categoria"})
        Me.cbobuscar.Location = New System.Drawing.Point(21, 29)
        Me.cbobuscar.Name = "cbobuscar"
        Me.cbobuscar.Size = New System.Drawing.Size(104, 21)
        Me.cbobuscar.TabIndex = 0
        Me.cbobuscar.Text = "producto"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbuscar)
        Me.GroupBox1.Controls.Add(Me.cbobuscar)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox1.Location = New System.Drawing.Point(12, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(396, 68)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar por..."
        '
        'txtbuscar
        '
        Me.txtbuscar.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtbuscar.Location = New System.Drawing.Point(131, 29)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(256, 20)
        Me.txtbuscar.TabIndex = 1
        '
        'Listado
        '
        Me.Listado.AllowUserToAddRows = False
        Me.Listado.AllowUserToDeleteRows = False
        Me.Listado.AllowUserToResizeColumns = False
        Me.Listado.AllowUserToResizeRows = False
        Me.Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Listado.Location = New System.Drawing.Point(12, 120)
        Me.Listado.MultiSelect = False
        Me.Listado.Name = "Listado"
        Me.Listado.ReadOnly = True
        Me.Listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Listado.Size = New System.Drawing.Size(646, 231)
        Me.Listado.TabIndex = 6
        '
        'lblflag
        '
        Me.lblflag.AutoSize = True
        Me.lblflag.Location = New System.Drawing.Point(427, 94)
        Me.lblflag.Name = "lblflag"
        Me.lblflag.Size = New System.Drawing.Size(13, 13)
        Me.lblflag.TabIndex = 9
        Me.lblflag.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(201, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 31)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Listado de Productos"
        '
        'btnEditar
        '
        Me.btnEditar.Image = Global.SistemaVentas.My.Resources.Resources.images__1_
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(568, 357)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(86, 31)
        Me.btnEditar.TabIndex = 8
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.SistemaVentas.My.Resources.Resources.leer
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(452, 357)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(86, 31)
        Me.btnNuevo.TabIndex = 7
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'FListadoProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(666, 395)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblflag)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Listado)
        Me.Name = "FListadoProductos"
        Me.Text = "FListadoProductos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Listado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbobuscar As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents Listado As System.Windows.Forms.DataGridView
    Friend WithEvents lblflag As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
