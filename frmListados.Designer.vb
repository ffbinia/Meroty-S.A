<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListados))
        Me.optListadoVentas = New System.Windows.Forms.RadioButton()
        Me.optListadoRegistro = New System.Windows.Forms.RadioButton()
        Me.gpbListado1 = New System.Windows.Forms.GroupBox()
        Me.gpbListado2 = New System.Windows.Forms.GroupBox()
        Me.lblFiltroxNombre = New System.Windows.Forms.Label()
        Me.cboFiltroxNombre = New System.Windows.Forms.ComboBox()
        Me.dgvListadoRegistro = New System.Windows.Forms.DataGridView()
        Me.IDRegistroListado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreRegistroListado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadRegistroListado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaRegistroListado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvListadoVentas = New System.Windows.Forms.DataGridView()
        Me.IDVentaListado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreVentaListado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadVentaListado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioVentaListado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVentaListado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnVolverListados = New System.Windows.Forms.Button()
        Me.gpbListado1.SuspendLayout()
        Me.gpbListado2.SuspendLayout()
        CType(Me.dgvListadoRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListadoVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'optListadoVentas
        '
        Me.optListadoVentas.AutoSize = True
        Me.optListadoVentas.Location = New System.Drawing.Point(17, 61)
        Me.optListadoVentas.Name = "optListadoVentas"
        Me.optListadoVentas.Size = New System.Drawing.Size(59, 19)
        Me.optListadoVentas.TabIndex = 1
        Me.optListadoVentas.TabStop = True
        Me.optListadoVentas.Text = "Ventas"
        Me.optListadoVentas.UseVisualStyleBackColor = True
        '
        'optListadoRegistro
        '
        Me.optListadoRegistro.AutoSize = True
        Me.optListadoRegistro.Location = New System.Drawing.Point(17, 25)
        Me.optListadoRegistro.Name = "optListadoRegistro"
        Me.optListadoRegistro.Size = New System.Drawing.Size(89, 19)
        Me.optListadoRegistro.TabIndex = 2
        Me.optListadoRegistro.TabStop = True
        Me.optListadoRegistro.Text = "Stock actual"
        Me.optListadoRegistro.UseVisualStyleBackColor = True
        '
        'gpbListado1
        '
        Me.gpbListado1.Controls.Add(Me.optListadoRegistro)
        Me.gpbListado1.Controls.Add(Me.optListadoVentas)
        Me.gpbListado1.Location = New System.Drawing.Point(9, 8)
        Me.gpbListado1.Name = "gpbListado1"
        Me.gpbListado1.Size = New System.Drawing.Size(258, 96)
        Me.gpbListado1.TabIndex = 4
        Me.gpbListado1.TabStop = False
        Me.gpbListado1.Text = "Elija una opcion"
        '
        'gpbListado2
        '
        Me.gpbListado2.Controls.Add(Me.lblFiltroxNombre)
        Me.gpbListado2.Controls.Add(Me.cboFiltroxNombre)
        Me.gpbListado2.Location = New System.Drawing.Point(286, 8)
        Me.gpbListado2.Name = "gpbListado2"
        Me.gpbListado2.Size = New System.Drawing.Size(298, 96)
        Me.gpbListado2.TabIndex = 5
        Me.gpbListado2.TabStop = False
        Me.gpbListado2.Text = "Filtros"
        '
        'lblFiltroxNombre
        '
        Me.lblFiltroxNombre.AutoSize = True
        Me.lblFiltroxNombre.Location = New System.Drawing.Point(6, 32)
        Me.lblFiltroxNombre.Name = "lblFiltroxNombre"
        Me.lblFiltroxNombre.Size = New System.Drawing.Size(138, 15)
        Me.lblFiltroxNombre.TabIndex = 4
        Me.lblFiltroxNombre.Text = "Por nombre de producto"
        '
        'cboFiltroxNombre
        '
        Me.cboFiltroxNombre.FormattingEnabled = True
        Me.cboFiltroxNombre.Location = New System.Drawing.Point(161, 24)
        Me.cboFiltroxNombre.Name = "cboFiltroxNombre"
        Me.cboFiltroxNombre.Size = New System.Drawing.Size(121, 23)
        Me.cboFiltroxNombre.TabIndex = 0
        '
        'dgvListadoRegistro
        '
        Me.dgvListadoRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoRegistro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDRegistroListado, Me.NombreRegistroListado, Me.CantidadRegistroListado, Me.FechaRegistroListado})
        Me.dgvListadoRegistro.Location = New System.Drawing.Point(12, 184)
        Me.dgvListadoRegistro.Name = "dgvListadoRegistro"
        Me.dgvListadoRegistro.RowTemplate.Height = 25
        Me.dgvListadoRegistro.Size = New System.Drawing.Size(572, 181)
        Me.dgvListadoRegistro.TabIndex = 6
        Me.dgvListadoRegistro.Visible = False
        '
        'IDRegistroListado
        '
        Me.IDRegistroListado.HeaderText = "ID"
        Me.IDRegistroListado.Name = "IDRegistroListado"
        '
        'NombreRegistroListado
        '
        Me.NombreRegistroListado.HeaderText = "Nombre del producto"
        Me.NombreRegistroListado.Name = "NombreRegistroListado"
        '
        'CantidadRegistroListado
        '
        Me.CantidadRegistroListado.HeaderText = "Cantidad"
        Me.CantidadRegistroListado.Name = "CantidadRegistroListado"
        '
        'FechaRegistroListado
        '
        Me.FechaRegistroListado.HeaderText = "Fecha de registro"
        Me.FechaRegistroListado.Name = "FechaRegistroListado"
        '
        'dgvListadoVentas
        '
        Me.dgvListadoVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDVentaListado, Me.NombreVentaListado, Me.CantidadVentaListado, Me.PrecioVentaListado, Me.FechaVentaListado})
        Me.dgvListadoVentas.Location = New System.Drawing.Point(12, 184)
        Me.dgvListadoVentas.Name = "dgvListadoVentas"
        Me.dgvListadoVentas.RowTemplate.Height = 25
        Me.dgvListadoVentas.Size = New System.Drawing.Size(572, 181)
        Me.dgvListadoVentas.TabIndex = 7
        '
        'IDVentaListado
        '
        Me.IDVentaListado.HeaderText = "ID"
        Me.IDVentaListado.Name = "IDVentaListado"
        '
        'NombreVentaListado
        '
        Me.NombreVentaListado.HeaderText = "Nombre del producto"
        Me.NombreVentaListado.Name = "NombreVentaListado"
        '
        'CantidadVentaListado
        '
        Me.CantidadVentaListado.HeaderText = "Cantidad"
        Me.CantidadVentaListado.Name = "CantidadVentaListado"
        '
        'PrecioVentaListado
        '
        Me.PrecioVentaListado.HeaderText = "Precio"
        Me.PrecioVentaListado.Name = "PrecioVentaListado"
        '
        'FechaVentaListado
        '
        Me.FechaVentaListado.HeaderText = "Fecha de venta"
        Me.FechaVentaListado.Name = "FechaVentaListado"
        '
        'btnVolverListados
        '
        Me.btnVolverListados.BackColor = System.Drawing.Color.Black
        Me.btnVolverListados.ForeColor = System.Drawing.Color.White
        Me.btnVolverListados.Location = New System.Drawing.Point(9, 110)
        Me.btnVolverListados.Name = "btnVolverListados"
        Me.btnVolverListados.Size = New System.Drawing.Size(106, 34)
        Me.btnVolverListados.TabIndex = 9
        Me.btnVolverListados.Text = "Volver"
        Me.btnVolverListados.UseVisualStyleBackColor = False
        '
        'frmListados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(596, 154)
        Me.Controls.Add(Me.btnVolverListados)
        Me.Controls.Add(Me.dgvListadoVentas)
        Me.Controls.Add(Me.dgvListadoRegistro)
        Me.Controls.Add(Me.gpbListado2)
        Me.Controls.Add(Me.gpbListado1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListados"
        Me.Text = "frmListados"
        Me.gpbListado1.ResumeLayout(False)
        Me.gpbListado1.PerformLayout()
        Me.gpbListado2.ResumeLayout(False)
        Me.gpbListado2.PerformLayout()
        CType(Me.dgvListadoRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListadoVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents optListadoVentas As RadioButton
    Friend WithEvents optListadoRegistro As RadioButton
    Friend WithEvents gpbListado1 As GroupBox
    Friend WithEvents gpbListado2 As GroupBox
    Friend WithEvents lblFiltroxNombre As Label
    Friend WithEvents cboFiltroxNombre As ComboBox
    Friend WithEvents dgvListadoRegistro As DataGridView
    Friend WithEvents IDRegistroListado As DataGridViewTextBoxColumn
    Friend WithEvents NombreRegistroListado As DataGridViewTextBoxColumn
    Friend WithEvents CantidadRegistroListado As DataGridViewTextBoxColumn
    Friend WithEvents FechaRegistroListado As DataGridViewTextBoxColumn
    Friend WithEvents dgvListadoVentas As DataGridView
    Friend WithEvents btnVolverListados As Button
    Friend WithEvents IDVentaListado As DataGridViewTextBoxColumn
    Friend WithEvents NombreVentaListado As DataGridViewTextBoxColumn
    Friend WithEvents CantidadVentaListado As DataGridViewTextBoxColumn
    Friend WithEvents PrecioVentaListado As DataGridViewTextBoxColumn
    Friend WithEvents FechaVentaListado As DataGridViewTextBoxColumn
End Class
