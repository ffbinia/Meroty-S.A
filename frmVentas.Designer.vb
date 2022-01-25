<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentas))
        Me.lblTituloVentas = New System.Windows.Forms.Label()
        Me.gpbVentas = New System.Windows.Forms.GroupBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.nupVentas = New System.Windows.Forms.NumericUpDown()
        Me.mtbPrecioVenta = New System.Windows.Forms.MaskedTextBox()
        Me.dtpVentas = New System.Windows.Forms.DateTimePicker()
        Me.lblNombreVenta = New System.Windows.Forms.Label()
        Me.cboProductosVenta = New System.Windows.Forms.ComboBox()
        Me.lblPrecioVenta = New System.Windows.Forms.Label()
        Me.lblIDVenta = New System.Windows.Forms.Label()
        Me.lblFechaVenta = New System.Windows.Forms.Label()
        Me.lblCantidadVenta = New System.Windows.Forms.Label()
        Me.btnVolverVentas = New System.Windows.Forms.Button()
        Me.btnVerVentas = New System.Windows.Forms.Button()
        Me.btnCargaVenta = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblFiltroCantidad = New System.Windows.Forms.Label()
        Me.nupFiltroCantidad = New System.Windows.Forms.NumericUpDown()
        Me.optMayora10 = New System.Windows.Forms.RadioButton()
        Me.lblFiltroVenta = New System.Windows.Forms.Label()
        Me.optVentaMayor = New System.Windows.Forms.RadioButton()
        Me.cboFiltroVenta = New System.Windows.Forms.ComboBox()
        Me.btnLimpiarVenta = New System.Windows.Forms.Button()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.IDVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gpbVentas.SuspendLayout()
        CType(Me.nupVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nupFiltroCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTituloVentas
        '
        Me.lblTituloVentas.AutoSize = True
        Me.lblTituloVentas.Font = New System.Drawing.Font("Arial Narrow", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTituloVentas.Location = New System.Drawing.Point(232, 0)
        Me.lblTituloVentas.Name = "lblTituloVentas"
        Me.lblTituloVentas.Size = New System.Drawing.Size(113, 42)
        Me.lblTituloVentas.TabIndex = 0
        Me.lblTituloVentas.Text = "Ventas"
        '
        'gpbVentas
        '
        Me.gpbVentas.Controls.Add(Me.lblCodigo)
        Me.gpbVentas.Controls.Add(Me.nupVentas)
        Me.gpbVentas.Controls.Add(Me.mtbPrecioVenta)
        Me.gpbVentas.Controls.Add(Me.dtpVentas)
        Me.gpbVentas.Controls.Add(Me.lblNombreVenta)
        Me.gpbVentas.Controls.Add(Me.cboProductosVenta)
        Me.gpbVentas.Controls.Add(Me.lblPrecioVenta)
        Me.gpbVentas.Controls.Add(Me.lblIDVenta)
        Me.gpbVentas.Controls.Add(Me.lblFechaVenta)
        Me.gpbVentas.Controls.Add(Me.lblCantidadVenta)
        Me.gpbVentas.Controls.Add(Me.btnVolverVentas)
        Me.gpbVentas.Controls.Add(Me.btnVerVentas)
        Me.gpbVentas.Controls.Add(Me.btnCargaVenta)
        Me.gpbVentas.Location = New System.Drawing.Point(10, 45)
        Me.gpbVentas.Name = "gpbVentas"
        Me.gpbVentas.Size = New System.Drawing.Size(559, 136)
        Me.gpbVentas.TabIndex = 1
        Me.gpbVentas.TabStop = False
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(40, 57)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(12, 15)
        Me.lblCodigo.TabIndex = 12
        Me.lblCodigo.Text = "-"
        '
        'nupVentas
        '
        Me.nupVentas.Location = New System.Drawing.Point(145, 49)
        Me.nupVentas.Name = "nupVentas"
        Me.nupVentas.Size = New System.Drawing.Size(56, 23)
        Me.nupVentas.TabIndex = 11
        '
        'mtbPrecioVenta
        '
        Me.mtbPrecioVenta.Location = New System.Drawing.Point(370, 13)
        Me.mtbPrecioVenta.Name = "mtbPrecioVenta"
        Me.mtbPrecioVenta.Size = New System.Drawing.Size(62, 23)
        Me.mtbPrecioVenta.TabIndex = 10
        '
        'dtpVentas
        '
        Me.dtpVentas.Location = New System.Drawing.Point(370, 49)
        Me.dtpVentas.Name = "dtpVentas"
        Me.dtpVentas.Size = New System.Drawing.Size(167, 23)
        Me.dtpVentas.TabIndex = 9
        '
        'lblNombreVenta
        '
        Me.lblNombreVenta.AutoSize = True
        Me.lblNombreVenta.Location = New System.Drawing.Point(7, 21)
        Me.lblNombreVenta.Name = "lblNombreVenta"
        Me.lblNombreVenta.Size = New System.Drawing.Size(122, 15)
        Me.lblNombreVenta.TabIndex = 3
        Me.lblNombreVenta.Text = "Nombre del producto"
        '
        'cboProductosVenta
        '
        Me.cboProductosVenta.FormattingEnabled = True
        Me.cboProductosVenta.Location = New System.Drawing.Point(145, 13)
        Me.cboProductosVenta.Name = "cboProductosVenta"
        Me.cboProductosVenta.Size = New System.Drawing.Size(121, 23)
        Me.cboProductosVenta.TabIndex = 8
        '
        'lblPrecioVenta
        '
        Me.lblPrecioVenta.AutoSize = True
        Me.lblPrecioVenta.Location = New System.Drawing.Point(278, 21)
        Me.lblPrecioVenta.Name = "lblPrecioVenta"
        Me.lblPrecioVenta.Size = New System.Drawing.Size(40, 15)
        Me.lblPrecioVenta.TabIndex = 7
        Me.lblPrecioVenta.Text = "Precio"
        '
        'lblIDVenta
        '
        Me.lblIDVenta.AutoSize = True
        Me.lblIDVenta.Location = New System.Drawing.Point(6, 57)
        Me.lblIDVenta.Name = "lblIDVenta"
        Me.lblIDVenta.Size = New System.Drawing.Size(18, 15)
        Me.lblIDVenta.TabIndex = 4
        Me.lblIDVenta.Text = "ID"
        '
        'lblFechaVenta
        '
        Me.lblFechaVenta.AutoSize = True
        Me.lblFechaVenta.Location = New System.Drawing.Point(278, 57)
        Me.lblFechaVenta.Name = "lblFechaVenta"
        Me.lblFechaVenta.Size = New System.Drawing.Size(86, 15)
        Me.lblFechaVenta.TabIndex = 6
        Me.lblFechaVenta.Text = "Fecha de venta"
        '
        'lblCantidadVenta
        '
        Me.lblCantidadVenta.AutoSize = True
        Me.lblCantidadVenta.Location = New System.Drawing.Point(74, 57)
        Me.lblCantidadVenta.Name = "lblCantidadVenta"
        Me.lblCantidadVenta.Size = New System.Drawing.Size(55, 15)
        Me.lblCantidadVenta.TabIndex = 5
        Me.lblCantidadVenta.Text = "Cantidad"
        '
        'btnVolverVentas
        '
        Me.btnVolverVentas.BackColor = System.Drawing.Color.Black
        Me.btnVolverVentas.ForeColor = System.Drawing.Color.White
        Me.btnVolverVentas.Location = New System.Drawing.Point(7, 83)
        Me.btnVolverVentas.Name = "btnVolverVentas"
        Me.btnVolverVentas.Size = New System.Drawing.Size(143, 36)
        Me.btnVolverVentas.TabIndex = 2
        Me.btnVolverVentas.Text = "Volver"
        Me.btnVolverVentas.UseVisualStyleBackColor = False
        '
        'btnVerVentas
        '
        Me.btnVerVentas.BackColor = System.Drawing.Color.Black
        Me.btnVerVentas.ForeColor = System.Drawing.Color.White
        Me.btnVerVentas.Location = New System.Drawing.Point(200, 83)
        Me.btnVerVentas.Name = "btnVerVentas"
        Me.btnVerVentas.Size = New System.Drawing.Size(143, 36)
        Me.btnVerVentas.TabIndex = 1
        Me.btnVerVentas.Text = "Ver Ventas"
        Me.btnVerVentas.UseVisualStyleBackColor = False
        '
        'btnCargaVenta
        '
        Me.btnCargaVenta.BackColor = System.Drawing.Color.Black
        Me.btnCargaVenta.ForeColor = System.Drawing.Color.White
        Me.btnCargaVenta.Location = New System.Drawing.Point(393, 83)
        Me.btnCargaVenta.Name = "btnCargaVenta"
        Me.btnCargaVenta.Size = New System.Drawing.Size(143, 36)
        Me.btnCargaVenta.TabIndex = 0
        Me.btnCargaVenta.Text = "Cargar venta"
        Me.btnCargaVenta.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblFiltroCantidad)
        Me.GroupBox2.Controls.Add(Me.nupFiltroCantidad)
        Me.GroupBox2.Controls.Add(Me.optMayora10)
        Me.GroupBox2.Controls.Add(Me.lblFiltroVenta)
        Me.GroupBox2.Controls.Add(Me.optVentaMayor)
        Me.GroupBox2.Controls.Add(Me.cboFiltroVenta)
        Me.GroupBox2.Controls.Add(Me.btnLimpiarVenta)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 198)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(559, 116)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtros"
        '
        'lblFiltroCantidad
        '
        Me.lblFiltroCantidad.AutoSize = True
        Me.lblFiltroCantidad.Location = New System.Drawing.Point(306, 22)
        Me.lblFiltroCantidad.Name = "lblFiltroCantidad"
        Me.lblFiltroCantidad.Size = New System.Drawing.Size(58, 15)
        Me.lblFiltroCantidad.TabIndex = 9
        Me.lblFiltroCantidad.Text = "Cantidad:"
        '
        'nupFiltroCantidad
        '
        Me.nupFiltroCantidad.Location = New System.Drawing.Point(251, 63)
        Me.nupFiltroCantidad.Name = "nupFiltroCantidad"
        Me.nupFiltroCantidad.Size = New System.Drawing.Size(38, 23)
        Me.nupFiltroCantidad.TabIndex = 8
        '
        'optMayora10
        '
        Me.optMayora10.AutoSize = True
        Me.optMayora10.Location = New System.Drawing.Point(168, 68)
        Me.optMayora10.Name = "optMayora10"
        Me.optMayora10.Size = New System.Drawing.Size(76, 19)
        Me.optMayora10.TabIndex = 7
        Me.optMayora10.TabStop = True
        Me.optMayora10.Text = "Cantidad:"
        Me.optMayora10.UseVisualStyleBackColor = True
        '
        'lblFiltroVenta
        '
        Me.lblFiltroVenta.AutoSize = True
        Me.lblFiltroVenta.Location = New System.Drawing.Point(7, 30)
        Me.lblFiltroVenta.Name = "lblFiltroVenta"
        Me.lblFiltroVenta.Size = New System.Drawing.Size(138, 15)
        Me.lblFiltroVenta.TabIndex = 6
        Me.lblFiltroVenta.Text = "Por nombre de producto"
        '
        'optVentaMayor
        '
        Me.optVentaMayor.AutoSize = True
        Me.optVentaMayor.Location = New System.Drawing.Point(7, 67)
        Me.optVentaMayor.Name = "optVentaMayor"
        Me.optVentaMayor.Size = New System.Drawing.Size(107, 19)
        Me.optVentaMayor.TabIndex = 5
        Me.optVentaMayor.TabStop = True
        Me.optVentaMayor.Text = "Mayores Ventas"
        Me.optVentaMayor.UseVisualStyleBackColor = True
        '
        'cboFiltroVenta
        '
        Me.cboFiltroVenta.FormattingEnabled = True
        Me.cboFiltroVenta.Location = New System.Drawing.Point(168, 22)
        Me.cboFiltroVenta.Name = "cboFiltroVenta"
        Me.cboFiltroVenta.Size = New System.Drawing.Size(121, 23)
        Me.cboFiltroVenta.TabIndex = 3
        '
        'btnLimpiarVenta
        '
        Me.btnLimpiarVenta.BackColor = System.Drawing.Color.Black
        Me.btnLimpiarVenta.ForeColor = System.Drawing.Color.White
        Me.btnLimpiarVenta.Location = New System.Drawing.Point(393, 49)
        Me.btnLimpiarVenta.Name = "btnLimpiarVenta"
        Me.btnLimpiarVenta.Size = New System.Drawing.Size(143, 37)
        Me.btnLimpiarVenta.TabIndex = 0
        Me.btnLimpiarVenta.Text = "Limpiar tabla"
        Me.btnLimpiarVenta.UseVisualStyleBackColor = False
        '
        'dgvVentas
        '
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDVenta, Me.NombreVenta, Me.CantidadVenta, Me.Precio, Me.FechaVenta})
        Me.dgvVentas.Location = New System.Drawing.Point(10, 326)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.RowTemplate.Height = 25
        Me.dgvVentas.Size = New System.Drawing.Size(559, 181)
        Me.dgvVentas.TabIndex = 3
        '
        'IDVenta
        '
        Me.IDVenta.HeaderText = "ID"
        Me.IDVenta.Name = "IDVenta"
        '
        'NombreVenta
        '
        Me.NombreVenta.HeaderText = "Nombre del producto"
        Me.NombreVenta.Name = "NombreVenta"
        '
        'CantidadVenta
        '
        Me.CantidadVenta.HeaderText = "Cantidad"
        Me.CantidadVenta.Name = "CantidadVenta"
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        '
        'FechaVenta
        '
        Me.FechaVenta.HeaderText = "Fecha de venta"
        Me.FechaVenta.Name = "FechaVenta"
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(580, 517)
        Me.Controls.Add(Me.dgvVentas)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gpbVentas)
        Me.Controls.Add(Me.lblTituloVentas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVentas"
        Me.Text = "frmVentas"
        Me.gpbVentas.ResumeLayout(False)
        Me.gpbVentas.PerformLayout()
        CType(Me.nupVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nupFiltroCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTituloVentas As Label
    Friend WithEvents gpbVentas As GroupBox
    Friend WithEvents btnVolverVentas As Button
    Friend WithEvents btnVerVentas As Button
    Friend WithEvents btnCargaVenta As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblCodigo As Label
    Friend WithEvents nupVentas As NumericUpDown
    Friend WithEvents mtbPrecioVenta As MaskedTextBox
    Friend WithEvents dtpVentas As DateTimePicker
    Friend WithEvents cboProductosVenta As ComboBox
    Friend WithEvents lblPrecioVenta As Label
    Friend WithEvents lblFechaVenta As Label
    Friend WithEvents lblCantidadVenta As Label
    Friend WithEvents lblIDVenta As Label
    Friend WithEvents lblNombreVenta As Label
    Friend WithEvents optMayora10 As RadioButton
    Friend WithEvents lblFiltroVenta As Label
    Friend WithEvents optVentaMayor As RadioButton
    Friend WithEvents cboFiltroVenta As ComboBox
    Friend WithEvents btnLimpiarVenta As Button
    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents IDVenta As DataGridViewTextBoxColumn
    Friend WithEvents NombreVenta As DataGridViewTextBoxColumn
    Friend WithEvents CantidadVenta As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents FechaVenta As DataGridViewTextBoxColumn
    Friend WithEvents lblFiltroCantidad As Label
    Friend WithEvents nupFiltroCantidad As NumericUpDown
End Class
