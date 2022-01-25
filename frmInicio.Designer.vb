<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnRegistros = New System.Windows.Forms.Button()
        Me.btnListados = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Arial Narrow", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(61, 22)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(269, 57)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "MEROTY S.A"
        '
        'btnVentas
        '
        Me.btnVentas.BackColor = System.Drawing.Color.Black
        Me.btnVentas.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnVentas.ForeColor = System.Drawing.Color.White
        Me.btnVentas.Location = New System.Drawing.Point(109, 174)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(148, 62)
        Me.btnVentas.TabIndex = 1
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.UseVisualStyleBackColor = False
        '
        'btnRegistros
        '
        Me.btnRegistros.BackColor = System.Drawing.Color.Black
        Me.btnRegistros.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRegistros.ForeColor = System.Drawing.Color.White
        Me.btnRegistros.Location = New System.Drawing.Point(109, 95)
        Me.btnRegistros.Name = "btnRegistros"
        Me.btnRegistros.Size = New System.Drawing.Size(148, 62)
        Me.btnRegistros.TabIndex = 2
        Me.btnRegistros.Text = "Registros"
        Me.btnRegistros.UseVisualStyleBackColor = False
        '
        'btnListados
        '
        Me.btnListados.BackColor = System.Drawing.Color.Black
        Me.btnListados.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnListados.ForeColor = System.Drawing.Color.White
        Me.btnListados.Location = New System.Drawing.Point(109, 255)
        Me.btnListados.Name = "btnListados"
        Me.btnListados.Size = New System.Drawing.Size(148, 62)
        Me.btnListados.TabIndex = 3
        Me.btnListados.Text = "Listados"
        Me.btnListados.UseVisualStyleBackColor = False
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(371, 329)
        Me.Controls.Add(Me.btnListados)
        Me.Controls.Add(Me.btnRegistros)
        Me.Controls.Add(Me.btnVentas)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "frmInicio"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnRegistros As Button
    Friend WithEvents btnListados As Button
End Class
