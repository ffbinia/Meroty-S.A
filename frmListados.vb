Public Class frmListados
    Dim varFilaVentas As Integer
    Dim varColumnaVentas As Integer

    Dim varFilaStock As Integer
    Dim varColumnaStock As Integer
    Private Sub frmListados_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnVolverListados_Click(sender As Object, e As EventArgs) Handles btnVolverListados.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("¿Desea volver al menu principal?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If resultado = DialogResult.Yes Then
            Me.Hide()
            frmInicio.Show()
        ElseIf resultado = DialogResult.No Then
            Me.BringToFront()
        End If
    End Sub

    'Private Sub optListado_CheckedChanged(sender As Object, e As EventArgs)
    '    'dgvListado.Rows.Clear()
    '    varFilaStock = 0
    '    varFilaVentas = 0

    '    While varFilaStock <= Stock.GetUpperBound(0)
    '        While varFilaVentas <= Ventas.GetUpperBound(0)
    '            'dgvListado.Rows.Add(Stock(varFilaStock, 0), Stock(varFilaStock, 1), Stock(varFilaStock, 3), Ventas(varFilaVentas, 4), Stock(varFilaStock, 2), Ventas(varFilaVentas, 2), "0", Ventas(varFilaVentas, 3))
    '            varFilaVentas = varFilaVentas + 1
    '            varFilaStock = varFilaStock + 1
    '        End While


    '    End While
    '    dgvListado.Visible = True
    '    dgvListadoVentas.Visible = False
    '    dgvListadoRegistro.Visible = False
    '    Me.Width = 811
    '    Me.Height = 422
    'End Sub
    Private Sub optListadoRegistro_CheckedChanged(sender As Object, e As EventArgs) Handles optListadoRegistro.CheckedChanged
        dgvListadoRegistro.Rows.Clear()
        cboFiltroxNombre.Items.Clear()


        varFilaStock = 0
        While varFilaStock <= Stock.GetUpperBound(0)

            If Stock(varFilaStock, 1) <> "" Then
                cboFiltroxNombre.Items.Add(Stock(varFilaStock, 1))
                dgvListadoRegistro.Rows.Add(Stock(varFilaStock, 0), Stock(varFilaStock, 1), Stock(varFilaStock, 2), Stock(varFilaStock, 3))

            End If
            varFilaStock = varFilaStock + 1
        End While

        'While varFilaStock <= 4
        '    varFilaStock = varFilaStock + 1
        'End While



        'dgvListado.Visible = False


        dgvListadoVentas.Visible = False

        dgvListadoRegistro.Visible = True

        Me.Width = 811
        Me.Height = 422

    End Sub
    Private Sub optListadoVentas_CheckedChanged(sender As Object, e As EventArgs) Handles optListadoVentas.CheckedChanged
        dgvListadoVentas.Rows.Clear()
        varFilaVentas = 0
        cboFiltroxNombre.Items.Clear()




        While varFilaVentas <= Ventas.GetUpperBound(0)
            If Ventas(varFilaVentas, 1) <> "" Then
                cboFiltroxNombre.Items.Add(Ventas(varFilaVentas, 1))
                dgvListadoVentas.Rows.Add(Ventas(varFilaVentas, 0), Ventas(varFilaVentas, 1), Ventas(varFilaVentas, 2), Ventas(varFilaVentas, 3), Ventas(varFilaVentas, 4))

            End If
            varFilaVentas = varFilaVentas + 1

        End While


        'While varFilaVentas <= Ventas.GetUpperBound(0)
        '    If Ventas(varFilaVentas, 0) <> "" Then
        '    End If
        '    varFilaVentas = varFilaVentas + 1

        'End While



        'dgvListado.Visible = False
        dgvListadoVentas.Visible = True
        dgvListadoRegistro.Visible = False
        Me.Width = 811
        Me.Height = 422

    End Sub





    Private Sub cboListados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFiltroxNombre.SelectedIndexChanged
        dgvListadoVentas.Rows.Clear()
        dgvListadoRegistro.Rows.Clear()
        'varFilaVentas = 0
        'While varFilaVentas <= Ventas.GetUpperBound(0)
        '    If Ventas(varFilaVentas, 1) = cboFiltroVenta.Text Then
        '        dgvVentas.Rows.Add(Ventas(varFilaVentas, 0), Ventas(varFilaVentas, 1), Ventas(varFilaVentas, 2), Ventas(varFilaVentas, 3), Ventas(varFilaVentas, 4))
        '    End If
        '    varFilaVentas = varFilaVentas + 1
        'End While


        varFilaVentas = 0
        varFilaStock = 0


        If optListadoVentas.Checked = True Then
            While varFilaVentas <= Ventas.GetUpperBound(0)
                If Ventas(varFilaVentas, 1) = cboFiltroxNombre.Text Then
                    dgvListadoVentas.Rows.Add(Ventas(varFilaVentas, 0), Ventas(varFilaVentas, 1), Ventas(varFilaVentas, 2), Ventas(varFilaVentas, 3), Ventas(varFilaVentas, 4))
                End If
                varFilaVentas = varFilaVentas + 1
            End While
        End If



        If optListadoRegistro.Checked = True Then

            While varFilaStock <= Stock.GetUpperBound(0)

                If Stock(varFilaStock, 1) = cboFiltroxNombre.Text Then

                    dgvListadoRegistro.Rows.Add(Stock(varFilaStock, 0), Stock(varFilaStock, 1), Stock(varFilaStock, 2), Stock(varFilaStock, 3))
                End If

                varFilaStock = varFilaStock + 1

            End While

        End If





    End Sub







End Class