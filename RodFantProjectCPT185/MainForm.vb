Public Class MainForm
    Private Sub btnRentals_Click(sender As Object, e As EventArgs) Handles btnRentals.Click
        frmRentalsForm.ShowDialog()
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        frmCheckoutForm.ShowDialog()
    End Sub
End Class
