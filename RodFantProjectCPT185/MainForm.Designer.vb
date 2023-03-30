<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits RodFantProjectCPT185.frmBaseForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnRentals = New System.Windows.Forms.Button()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRentals
        '
        Me.btnRentals.Location = New System.Drawing.Point(153, 341)
        Me.btnRentals.Name = "btnRentals"
        Me.btnRentals.Size = New System.Drawing.Size(175, 41)
        Me.btnRentals.TabIndex = 4
        Me.btnRentals.Text = "Rentals"
        Me.btnRentals.UseVisualStyleBackColor = True
        '
        'btnCheckout
        '
        Me.btnCheckout.Location = New System.Drawing.Point(413, 341)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(175, 41)
        Me.btnCheckout.TabIndex = 5
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(944, 483)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.btnRentals)
        Me.Name = "MainForm"
        Me.Controls.SetChildIndex(Me.btnRentals, 0)
        Me.Controls.SetChildIndex(Me.btnCheckout, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRentals As Button
    Friend WithEvents btnCheckout As Button
End Class
