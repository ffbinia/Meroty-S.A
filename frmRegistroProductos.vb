Public Class frmRegistroProductos
    Private Sub btnVolverRegistro_Click(sender As Object, e As EventArgs) Handles btnVolverRegistro.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("¿Esta seguro que desea volver al menu principal? Todos los datos no guardados se perderan", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If resultado = DialogResult.Yes Then
            frmInicio.Show()
            Me.Close()
        ElseIf resultado = DialogResult.No Then
            Me.BringToFront()

        End If
    End Sub

    Private Sub frmRegistroProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        varColumnaStock = 0
        varFilaStock = 0
    End Sub

    Private Sub btnCargarProducto_Click(sender As Object, e As EventArgs) Handles btnCargarProducto.Click

        If mtbIDProducto.Text = "" Or txtNombre.Text = "" Or nupCantidadRegsitro.Value = 0 Then
            MessageBox.Show("Campos incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf varFilaStock <= 4 Then
            Stock(varFilaStock, 0) = mtbIDProducto.Text
            Stock(varFilaStock, 1) = txtNombre.Text
            Stock(varFilaStock, 2) = nupCantidadRegsitro.Value
            Stock(varFilaStock, 3) = dtpRegistro.Value
            varFilaStock = varFilaStock + 1
            MessageBox.Show("¡Datos cargados exitosamente!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mtbIDProducto.Clear()
            txtNombre.Clear()
            nupCantidadRegsitro.Value = 0
            dtpRegistro.Value = Date.Today
            mtbIDProducto.Focus()
        Else
            MessageBox.Show("¡No se pueden registrar mas productos por hoy!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnCargarProducto.Enabled = False
        End If
    End Sub

    Private Sub btnListarRegistros_Click(sender As Object, e As EventArgs) Handles btnListarRegistros.Click
        varFilaStock = 0
        varColumnaStock = 0

        While varFilaStock <= 4
            If Stock(varFilaStock, 1) <> "" Then
                dgvConsulta.Rows.Add(Stock(varFilaStock, 0), Stock(varFilaStock, 1), Stock(varFilaStock, 2), Stock(varFilaStock, 3))
            End If

            varFilaStock = varFilaStock + 1
        End While

    End Sub



    Private Sub btnLimpiarDGV_Click(sender As Object, e As EventArgs) Handles btnLimpiarDGV.Click
        dgvConsulta.Rows.Clear()
    End Sub

    Private Sub btnLimpiarRegistro_Click(sender As Object, e As EventArgs) Handles btnLimpiarRegistro.Click
        mtbIDProducto.Clear()
        txtNombre.Clear()
        nupCantidadRegsitro.Value = 0
        dtpRegistro.Value = Date.Today
    End Sub
End Class