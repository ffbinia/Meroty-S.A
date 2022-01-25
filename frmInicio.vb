Public Class frmInicio
    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        frmVentas.Show()
        Me.Hide()

    End Sub

    Private Sub btnRegistros_Click(sender As Object, e As EventArgs) Handles btnRegistros.Click
        frmRegistroProductos.Show()
        Me.Hide()

    End Sub

    Private Sub btnListados_Click(sender As Object, e As EventArgs) Handles btnListados.Click
        frmListados.Show()
        Me.Hide()


    End Sub
End Class
