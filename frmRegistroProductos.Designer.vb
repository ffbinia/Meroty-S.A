<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistroProductos
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
        Me.lblRegistro = New System.Windows.Forms.Label()
        Me.lblIDRegistro = New System.Windows.Forms.Label()
        Me.lblNombreRegistro = New System.Windows.Forms.Label()
        Me.lblFechaRegistro = New System.Windows.Forms.Label()
        Me.lblCantidadRegistro = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.mtbIDProducto = New System.Windows.Forms.MaskedTextBox()
        Me.dtpRegistro = New System.Windows.Forms.DateTimePicker()
        Me.nupCantidadRegsitro = New System.Windows.Forms.NumericUpDown()
        Me.gpbRegistro = New System.Windows.Forms.GroupBox()
        Me.btnCargarProducto = New System.Windows.Forms.Button()
        Me.btnVolverRegistro = New System.Windows.Forms.Button()
        Me.btnLimpiarRegistro = New System.Windows.Forms.Button()
        Me.tbcRegistro = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnLimpiarDGV = New System.Windows.Forms.Button()
        Me.btnListarRegistros = New System.Windows.Forms.Button()
        Me.dgvConsulta = New System.Windows.Forms.DataGridView()
        Me.IDRegistro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreRegistro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadRegistro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaRegistro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.nupCantidadRegsitro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbRegistro.SuspendLayout()
        Me.tbcRegistro.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRegistro
        '
        Me.lblRegistro.AutoSize = True
        Me.lblRegistro.Font = New System.Drawing.Font("Arial Narrow", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRegistro.Location = New System.Drawing.Point(57, 0)
        Me.lblRegistro.Name = "lblRegistro"
        Me.lblRegistro.Size = New System.Drawing.Size(422, 57)
        Me.lblRegistro.TabIndex = 0
        Me.lblRegistro.Text = "Registro de producto"
        '
        'lblIDRegistro
        '
        Me.lblIDRegistro.AutoSize = True
        Me.lblIDRegistro.Location = New System.Drawing.Point(28, 35)
        Me.lblIDRegistro.Name = "lblIDRegistro"
        Me.lblIDRegistro.Size = New System.Drawing.Size(70, 15)
        Me.lblIDRegistro.TabIndex = 1
        Me.lblIDRegistro.Text = "ID Producto"
        '
        'lblNombreRegistro
        '
        Me.lblNombreRegistro.AutoSize = True
        Me.lblNombreRegistro.Location = New System.Drawing.Point(28, 80)
        Me.lblNombreRegistro.Name = "lblNombreRegistro"
        Me.lblNombreRegistro.Size = New System.Drawing.Size(122, 15)
        Me.lblNombreRegistro.TabIndex = 2
        Me.lblNombreRegistro.Text = "Nombre del producto"
        '
        'lblFechaRegistro
        '
        Me.lblFechaRegistro.AutoSize = True
        Me.lblFechaRegistro.Location = New System.Drawing.Point(28, 172)
        Me.lblFechaRegistro.Name = "lblFechaRegistro"
        Me.lblFechaRegistro.Size = New System.Drawing.Size(97, 15)
        Me.lblFechaRegistro.TabIndex = 3
        Me.lblFechaRegistro.Text = "Fecha de registro"
        '
        'lblCantidadRegistro
        '
        Me.lblCantidadRegistro.AutoSize = True
        Me.lblCantidadRegistro.Location = New System.Drawing.Point(28, 127)
        Me.lblCantidadRegistro.Name = "lblCantidadRegistro"
        Me.lblCantidadRegistro.Size = New System.Drawing.Size(58, 15)
        Me.lblCantidadRegistro.TabIndex = 4
        Me.lblCantidadRegistro.Text = "Cantidad:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(151, 72)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 23)
        Me.txtNombre.TabIndex = 5
        '
        'mtbIDProducto
        '
        Me.mtbIDProducto.Location = New System.Drawing.Point(151, 27)
        Me.mtbIDProducto.Name = "mtbIDProducto"
        Me.mtbIDProducto.Size = New System.Drawing.Size(100, 23)
        Me.mtbIDProducto.TabIndex = 6
        '
        'dtpRegistro
        '
        Me.dtpRegistro.Location = New System.Drawing.Point(151, 164)
        Me.dtpRegistro.Name = "dtpRegistro"
        Me.dtpRegistro.Size = New System.Drawing.Size(200, 23)
        Me.dtpRegistro.TabIndex = 7
        '
        'nupCantidadRegsitro
        '
        Me.nupCantidadRegsitro.Location = New System.Drawing.Point(151, 119)
        Me.nupCantidadRegsitro.Name = "nupCantidadRegsitro"
        Me.nupCantidadRegsitro.Size = New System.Drawing.Size(120, 23)
        Me.nupCantidadRegsitro.TabIndex = 8
        '
        'gpbRegistro
        '
        Me.gpbRegistro.Controls.Add(Me.nupCantidadRegsitro)
        Me.gpbRegistro.Controls.Add(Me.dtpRegistro)
        Me.gpbRegistro.Controls.Add(Me.mtbIDProducto)
        Me.gpbRegistro.Controls.Add(Me.txtNombre)
        Me.gpbRegistro.Controls.Add(Me.lblCantidadRegistro)
        Me.gpbRegistro.Controls.Add(Me.lblFechaRegistro)
        Me.gpbRegistro.Controls.Add(Me.lblNombreRegistro)
        Me.gpbRegistro.Controls.Add(Me.lblIDRegistro)
        Me.gpbRegistro.Location = New System.Drawing.Point(29, 56)
        Me.gpbRegistro.Name = "gpbRegistro"
        Me.gpbRegistro.Size = New System.Drawing.Size(482, 224)
        Me.gpbRegistro.TabIndex = 9
        Me.gpbRegistro.TabStop = False
        '
        'btnCargarProducto
        '
        Me.btnCargarProducto.BackColor = System.Drawing.Color.Black
        Me.btnCargarProducto.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCargarProducto.ForeColor = System.Drawing.Color.White
        Me.btnCargarProducto.Location = New System.Drawing.Point(353, 286)
        Me.btnCargarProducto.Name = "btnCargarProducto"
        Me.btnCargarProducto.Size = New System.Drawing.Size(161, 50)
        Me.btnCargarProducto.TabIndex = 10
        Me.btnCargarProducto.Text = "Cargar Producto"
        Me.btnCargarProducto.UseVisualStyleBackColor = False
        '
        'btnVolverRegistro
        '
        Me.btnVolverRegistro.BackColor = System.Drawing.Color.Black
        Me.btnVolverRegistro.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnVolverRegistro.ForeColor = System.Drawing.Color.White
        Me.btnVolverRegistro.Location = New System.Drawing.Point(13, 286)
        Me.btnVolverRegistro.Name = "btnVolverRegistro"
        Me.btnVolverRegistro.Size = New System.Drawing.Size(161, 50)
        Me.btnVolverRegistro.TabIndex = 11
        Me.btnVolverRegistro.Text = "Volver"
        Me.btnVolverRegistro.UseVisualStyleBackColor = False
        '
        'btnLimpiarRegistro
        '
        Me.btnLimpiarRegistro.BackColor = System.Drawing.Color.Black
        Me.btnLimpiarRegistro.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnLimpiarRegistro.ForeColor = System.Drawing.Color.White
        Me.btnLimpiarRegistro.Location = New System.Drawing.Point(180, 286)
        Me.btnLimpiarRegistro.Name = "btnLimpiarRegistro"
        Me.btnLimpiarRegistro.Size = New System.Drawing.Size(161, 50)
        Me.btnLimpiarRegistro.TabIndex = 12
        Me.btnLimpiarRegistro.Text = "Limpiar campos"
        Me.btnLimpiarRegistro.UseVisualStyleBackColor = False
        '
        'tbcRegistro
        '
        Me.tbcRegistro.Controls.Add(Me.TabPage1)
        Me.tbcRegistro.Controls.Add(Me.TabPage2)
        Me.tbcRegistro.Location = New System.Drawing.Point(3, 12)
        Me.tbcRegistro.Name = "tbcRegistro"
        Me.tbcRegistro.SelectedIndex = 0
        Me.tbcRegistro.Size = New System.Drawing.Size(525, 403)
        Me.tbcRegistro.TabIndex = 13
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Gray
        Me.TabPage1.Controls.Add(Me.gpbRegistro)
        Me.TabPage1.Controls.Add(Me.btnVolverRegistro)
        Me.TabPage1.Controls.Add(Me.btnLimpiarRegistro)
        Me.TabPage1.Controls.Add(Me.lblRegistro)
        Me.TabPage1.Controls.Add(Me.btnCargarProducto)
        Me.TabPage1.ForeColor = System.Drawing.Color.Black
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(517, 375)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registro de productos"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnLimpiarDGV)
        Me.TabPage2.Controls.Add(Me.btnListarRegistros)
        Me.TabPage2.Controls.Add(Me.dgvConsulta)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(517, 401)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Consulta"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnLimpiarDGV
        '
        Me.btnLimpiarDGV.BackColor = System.Drawing.Color.Black
        Me.btnLimpiarDGV.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnLimpiarDGV.ForeColor = System.Drawing.Color.White
        Me.btnLimpiarDGV.Location = New System.Drawing.Point(21, 297)
        Me.btnLimpiarDGV.Name = "btnLimpiarDGV"
        Me.btnLimpiarDGV.Size = New System.Drawing.Size(75, 58)
        Me.btnLimpiarDGV.TabIndex = 2
        Me.btnLimpiarDGV.Text = "Limpiar tabla"
        Me.btnLimpiarDGV.UseVisualStyleBackColor = False
        '
        'btnListarRegistros
        '
        Me.btnListarRegistros.BackColor = System.Drawing.Color.Black
        Me.btnListarRegistros.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnListarRegistros.ForeColor = System.Drawing.Color.White
        Me.btnListarRegistros.Location = New System.Drawing.Point(399, 297)
        Me.btnListarRegistros.Name = "btnListarRegistros"
        Me.btnListarRegistros.Size = New System.Drawing.Size(75, 58)
        Me.btnListarRegistros.TabIndex = 1
        Me.btnListarRegistros.Text = "Ver Registros"
        Me.btnListarRegistros.UseVisualStyleBackColor = False
        '
        'dgvConsulta
        '
        Me.dgvConsulta.BackgroundColor = System.Drawing.Color.Gray
        Me.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsulta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDRegistro, Me.NombreRegistro, Me.CantidadRegistro, Me.FechaRegistro})
        Me.dgvConsulta.Location = New System.Drawing.Point(6, 6)
        Me.dgvConsulta.Name = "dgvConsulta"
        Me.dgvConsulta.RowTemplate.Height = 25
        Me.dgvConsulta.Size = New System.Drawing.Size(495, 376)
        Me.dgvConsulta.TabIndex = 0
        '
        'IDRegistro
        '
        Me.IDRegistro.HeaderText = "ID"
        Me.IDRegistro.Name = "IDRegistro"
        '
        'NombreRegistro
        '
        Me.NombreRegistro.HeaderText = "Nombre del producto"
        Me.NombreRegistro.Name = "NombreRegistro"
        '
        'CantidadRegistro
        '
        Me.CantidadRegistro.HeaderText = "Cantidad"
        Me.CantidadRegistro.Name = "CantidadRegistro"
        '
        'FechaRegistro
        '
        Me.FechaRegistro.HeaderText = "Fecha de registro"
        Me.FechaRegistro.Name = "FechaRegistro"
        '
        'frmRegistroProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(534, 436)
        Me.Controls.Add(Me.tbcRegistro)
        Me.Name = "frmRegistroProductos"
        Me.Text = "frmRegistroProductos"
        CType(Me.nupCantidadRegsitro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbRegistro.ResumeLayout(False)
        Me.gpbRegistro.PerformLayout()
        Me.tbcRegistro.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblRegistro As Label
    Friend WithEvents lblIDRegistro As Label
    Friend WithEvents lblNombreRegistro As Label
    Friend WithEvents lblFechaRegistro As Label
    Friend WithEvents lblCantidadRegistro As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents mtbIDProducto As MaskedTextBox
    Friend WithEvents dtpRegistro As DateTimePicker
    Friend WithEvents nupCantidadRegsitro As NumericUpDown
    Friend WithEvents gpbRegistro As GroupBox
    Friend WithEvents btnCargarProducto As Button
    Friend WithEvents btnVolverRegistro As Button
    Friend WithEvents btnLimpiarRegistro As Button
    Friend WithEvents tbcRegistro As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgvConsulta As DataGridView
    Friend WithEvents IDRegistro As DataGridViewTextBoxColumn
    Friend WithEvents NombreRegistro As DataGridViewTextBoxColumn
    Friend WithEvents CantidadRegistro As DataGridViewTextBoxColumn
    Friend WithEvents FechaRegistro As DataGridViewTextBoxColumn
    Friend WithEvents btnLimpiarDGV As Button
    Friend WithEvents btnListarRegistros As Button
End Class
