' Author:      Rod Fant
' Date:        3/30/3023
' Class:       CPT 185
' Description: This is the video store project which will be a functioning video store.
'              The program will have various forms, show videos and rentals, perform various
'              actions, and so on.

Option Strict On

Public Class frmBaseForm
    Private Sub frmMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAboutForm.ShowDialog()
    End Sub

    Private Sub DisplayStudioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayStudioToolStripMenuItem.Click
        frmDisplayStudioForm.ShowDialog()
    End Sub

    Private Sub DisplayVideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayVideoToolStripMenuItem.Click
        frmDisplayVideoForm.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
