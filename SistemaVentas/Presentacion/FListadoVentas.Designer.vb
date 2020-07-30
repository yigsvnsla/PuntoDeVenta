<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FListadoVentas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Listado = New System.Windows.Forms.DataGridView()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Listado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbobuscar
        '
        Me.cbobuscar.ForeColor = System.Drawing.Color.DodgerBlue
        Me.cbobuscar.FormattingEnabled = True
        Me.cbobuscar.Items.AddRange(New Object() {"Nro.Documento", "Empleado", "Cliente"})
        Me.cbobuscar.Location = New System.Drawing.Point(21, 29)
        Me.cbobuscar.Name = "cbobuscar"
        Me.cbobuscar.Size = New System.Drawing.Size(104, 21)
        Me.cbobuscar.TabIndex = 0
        Me.cbobuscar.Text = "Nro.Documento"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbuscar)
        Me.GroupBox1.Controls.Add(Me.cbobuscar)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox1.Location = New System.Drawing.Point(12, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(396, 68)
        Me.GroupBox1.TabIndex = 12
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(193, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 31)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Listado de Ventas"
        '
        'Listado
        '
        Me.Listado.AllowUserToAddRows = False
        Me.Listado.AllowUserToDeleteRows = False
        Me.Listado.AllowUserToResizeColumns = False
        Me.Listado.AllowUserToResizeRows = False
        Me.Listado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Listado.Location = New System.Drawing.Point(12, 114)
        Me.Listado.MultiSelect = False
        Me.Listado.Name = "Listado"
        Me.Listado.ReadOnly = True
        Me.Listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Listado.Size = New System.Drawing.Size(646, 231)
        Me.Listado.TabIndex = 13
        '
        'btnactualizar
        '
        Me.btnactualizar.Image = Global.SistemaVentas.My.Resources.Resources.refresh_24
        Me.btnactualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnactualizar.Location = New System.Drawing.Point(373, 352)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(98, 36)
        Me.btnactualizar.TabIndex = 19
        Me.btnactualizar.Text = "Actualizar"
        Me.btnactualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnactualizar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Image = Global.SistemaVentas.My.Resources.Resources.formulariosIcono
        Me.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnuevo.Location = New System.Drawing.Point(477, 352)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(86, 36)
        Me.btnnuevo.TabIndex = 18
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Image = Global.SistemaVentas.My.Resources.Resources.imprimir
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(569, 351)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(86, 37)
        Me.btnEditar.TabIndex = 15
        Me.btnEditar.Text = "Imprimir"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'FListadoVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(671, 394)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.Listado)
        Me.Name = "FListadoVentas"
        Me.Text = "FListadoVentas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Listado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbobuscar As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents Listado As System.Windows.Forms.DataGridView
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents btnactualizar As System.Windows.Forms.Button
End Class
