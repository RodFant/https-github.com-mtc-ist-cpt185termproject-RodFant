Public Class frmAboutForm
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblDescription.Click

    End Sub

    Private Sub txtDescriptionInfo_TextChanged(sender As Object, e As EventArgs) Handles txtDescriptionInfo.TextChanged

    End Sub

    Private Sub frmAboutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDescriptionInfo.Enabled = False
        AboutToolStripMenuItem.Enabled = False
    End Sub
End Class
