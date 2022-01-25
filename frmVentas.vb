Public Class frmVentas
    Dim varFilaVentas As Integer = 0
    Dim varindicefilaStock As Integer = 0

    Dim varFilaStock As Integer = 0
    Dim varColumnaStock As Integer = 0
    Private Sub btnVolverVentas_Click(sender As Object, e As EventArgs) Handles btnVolverVentas.Click
        Dim dialogresult As DialogResult
        dialogresult = MessageBox.Show("¿Desea volver al menu principal? Los datos no guardados se perderan", "¡Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dialogresult = DialogResult.Yes Then
            Me.Close()
            frmInicio.Show()
        ElseIf dialogresult = DialogResult.No Then
            Me.BringToFront()
        End If
    End Sub

    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        varFilaStock = 0
        While varFilaStock <= Stock.GetUpperBound(0)

            If Stock(varFilaStock, 1) <> "" Then
                cboProductosVenta.Items.Add(Stock(varFilaStock, 1))
                cboFiltroVenta.Items.Add(Stock(varFilaStock, 1))
            End If
            varFilaStock = varFilaStock + 1
        End While
    End Sub

    Private Sub btnCargaVenta_Click(sender As Object, e As EventArgs) Handles btnCargaVenta.Click

        If nupVentas.Value = 0 Or cboProductosVenta.Text = "" Or mtbPrecioVenta.Text = "" Then
            MessageBox.Show("¡Complete todos los campos!", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else



            varindicefilaStock = 0

            While varindicefilaStock <= Stock.GetUpperBound(0)


                If cboProductosVenta.Text = Stock(varindicefilaStock, 1) Then

                    If Stock(varindicefilaStock, 2) > 0 Then
                        Ventas(varFilaVentas, 0) = lblCodigo.Text
                        Ventas(varFilaVentas, 1) = cboProductosVenta.SelectedItem
                        Ventas(varFilaVentas, 2) = nupVentas.Value
                        Ventas(varFilaVentas, 3) = mtbPrecioVenta.Text
                        Ventas(varFilaVentas, 4) = dtpVentas.Value
                        varFilaVentas = varFilaVentas + 1

                        Stock(varindicefilaStock, 2) = Stock(varindicefilaStock, 2) - nupVentas.Value
                        MessageBox.Show("¡Venta cargada!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        lblCodigo.Text = ""
                        cboProductosVenta.Text = ""
                        nupVentas.Value = "0"
                        mtbPrecioVenta.Text = ""
                        dtpVentas.Value = Today
                        Exit While
                    Else
                        MessageBox.Show("¡NO HAY MAS STOCK DE ESTE PRODUCTO!", "¡LO SIENTO!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If



                End If
                varindicefilaStock = varindicefilaStock + 1

            End While

        End If
    End Sub

    Private Sub btnVerVentas_Click(sender As Object, e As EventArgs) Handles btnVerVentas.Click
        dgvVentas.Rows.Clear()
        varFilaVentas = 0

        Me.Height = 591

        While varFilaVentas <= Ventas.GetUpperBound(0)
            If Ventas(varFilaVentas, 0) <> "" Then
                dgvVentas.Rows.Add(Ventas(varFilaVentas, 0), Ventas(varFilaVentas, 1), Ventas(varFilaVentas, 2), Ventas(varFilaVentas, 3), Ventas(varFilaVentas, 4))

            End If
            varFilaVentas = varFilaVentas + 1

        End While
    End Sub

    Private Sub cboProductosVenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProductosVenta.SelectedIndexChanged
        varFilaStock = 0
        lblCodigo.Text = ""
        While varFilaStock <= Stock.GetUpperBound(0)
            If Stock(varFilaStock, 1) = cboProductosVenta.Text Then
                lblCodigo.Text = Stock(varFilaStock, varColumnaStock)
            End If

            varFilaStock = varFilaStock + 1
        End While

    End Sub

    Private Sub optVentaMayor_CheckedChanged(sender As Object, e As EventArgs) Handles optVentaMayor.CheckedChanged

        dgvVentas.Rows.Clear()


        varFilaVentas = 0
        Dim varMayor As Integer


        varMayor = Ventas(varFilaVentas, 2)

        While varFilaVentas <= Ventas.GetUpperBound(0)

            If Ventas(varFilaVentas, 2) > varMayor Then
                varMayor = Ventas(varFilaVentas, 2)
                dgvVentas.Rows.Add(Ventas(varFilaVentas, 0), Ventas(varFilaVentas, 1), Ventas(varFilaVentas, 2), Ventas(varFilaVentas, 3), Ventas(varFilaVentas, 4))

            End If
            varFilaVentas = varFilaVentas + 1

        End While
    End Sub

    Private Sub cboFiltroVenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFiltroVenta.SelectedIndexChanged
        dgvVentas.Rows.Clear()

        varFilaVentas = 0
        While varFilaVentas <= Ventas.GetUpperBound(0)
            If Ventas(varFilaVentas, 1) = cboFiltroVenta.Text Then
                dgvVentas.Rows.Add(Ventas(varFilaVentas, 0), Ventas(varFilaVentas, 1), Ventas(varFilaVentas, 2), Ventas(varFilaVentas, 3), Ventas(varFilaVentas, 4))
            End If
            varFilaVentas = varFilaVentas + 1
        End While
    End Sub

    Private Sub btnLimpiarVenta_Click(sender As Object, e As EventArgs) Handles btnLimpiarVenta.Click
        dgvVentas.Rows.Clear()

    End Sub

    Private Sub dtpVentas_ValueChanged(sender As Object, e As EventArgs) Handles dtpVentas.ValueChanged


        If dtpVentas.Value > DateAndTime.Today Then
            MessageBox.Show("Elija otra fecha por favor!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub optMenora10_CheckedChanged(sender As Object, e As EventArgs) Handles optMayora10.CheckedChanged
        dgvVentas.Rows.Clear()

        varFilaVentas = 0

        While varFilaVentas <= Ventas.GetUpperBound(0)

            If Ventas(varFilaVentas, 2) <= nupFiltroCantidad.Value Then
                dgvVentas.Rows.Add(Ventas(varFilaVentas, 0), Ventas(varFilaVentas, 1), Ventas(varFilaVentas, 2), Ventas(varFilaVentas, 3), Ventas(varFilaVentas, 4))
            End If

            varFilaVentas = varFilaVentas + 1

        End While
    End Sub


End Class