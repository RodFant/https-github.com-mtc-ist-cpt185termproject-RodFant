<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAboutForm
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
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblDescriptionInfo = New System.Windows.Forms.Label()
        Me.lblProductNameInfo = New System.Windows.Forms.Label()
        Me.lblVersionInfo = New System.Windows.Forms.Label()
        Me.lblCopyrightInfo = New System.Windows.Forms.Label()
        Me.txtDescriptionInfo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Location = New System.Drawing.Point(55, 77)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(108, 17)
        Me.lblCompanyName.TabIndex = 4
        Me.lblCompanyName.Text = "Company Name"
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Location = New System.Drawing.Point(55, 122)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(98, 17)
        Me.lblProductName.TabIndex = 5
        Me.lblProductName.Text = "Product Name"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(55, 170)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(56, 17)
        Me.lblVersion.TabIndex = 6
        Me.lblVersion.Text = "Version"
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Location = New System.Drawing.Point(55, 219)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(68, 17)
        Me.lblCopyright.TabIndex = 7
        Me.lblCopyright.Text = "Copyright"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(55, 264)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(79, 17)
        Me.lblDescription.TabIndex = 8
        Me.lblDescription.Text = "Description"
        '
        'lblDescriptionInfo
        '
        Me.lblDescriptionInfo.AutoSize = True
        Me.lblDescriptionInfo.Location = New System.Drawing.Point(195, 77)
        Me.lblDescriptionInfo.Name = "lblDescriptionInfo"
        Me.lblDescriptionInfo.Size = New System.Drawing.Size(180, 17)
        Me.lblDescriptionInfo.TabIndex = 9
        Me.lblDescriptionInfo.Text = "Midlands Technical College"
        '
        'lblProductNameInfo
        '
        Me.lblProductNameInfo.AutoSize = True
        Me.lblProductNameInfo.Location = New System.Drawing.Point(198, 122)
        Me.lblProductNameInfo.Name = "lblProductNameInfo"
        Me.lblProductNameInfo.Size = New System.Drawing.Size(78, 17)
        Me.lblProductNameInfo.TabIndex = 10
        Me.lblProductNameInfo.Text = "VideoStore"
        '
        'lblVersionInfo
        '
        Me.lblVersionInfo.AutoSize = True
        Me.lblVersionInfo.Location = New System.Drawing.Point(198, 170)
        Me.lblVersionInfo.Name = "lblVersionInfo"
        Me.lblVersionInfo.Size = New System.Drawing.Size(104, 17)
        Me.lblVersionInfo.TabIndex = 11
        Me.lblVersionInfo.Text = "Version 1.1.1.0"
        '
        'lblCopyrightInfo
        '
        Me.lblCopyrightInfo.AutoSize = True
        Me.lblCopyrightInfo.Location = New System.Drawing.Point(198, 219)
        Me.lblCopyrightInfo.Name = "lblCopyrightInfo"
        Me.lblCopyrightInfo.Size = New System.Drawing.Size(280, 17)
        Me.lblCopyrightInfo.TabIndex = 12
        Me.lblCopyrightInfo.Text = "Copyright Midlands Technical College 2010"
        '
        'txtDescriptionInfo
        '
        Me.txtDescriptionInfo.Location = New System.Drawing.Point(198, 264)
        Me.txtDescriptionInfo.Multiline = True
        Me.txtDescriptionInfo.Name = "txtDescriptionInfo"
        Me.txtDescriptionInfo.ReadOnly = True
        Me.txtDescriptionInfo.Size = New System.Drawing.Size(375, 127)
        Me.txtDescriptionInfo.TabIndex = 14
        Me.txtDescriptionInfo.Text = "This application runs the Video Store."
        '
        'frmAboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(944, 483)
        Me.Controls.Add(Me.txtDescriptionInfo)
        Me.Controls.Add(Me.lblCopyrightInfo)
        Me.Controls.Add(Me.lblVersionInfo)
        Me.Controls.Add(Me.lblProductNameInfo)
        Me.Controls.Add(Me.lblDescriptionInfo)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.lblCompanyName)
        Me.Name = "frmAboutForm"
        Me.Text = "Video Store - About"
        Me.Controls.SetChildIndex(Me.lblCompanyName, 0)
        Me.Controls.SetChildIndex(Me.lblProductName, 0)
        Me.Controls.SetChildIndex(Me.lblVersion, 0)
        Me.Controls.SetChildIndex(Me.lblCopyright, 0)
        Me.Controls.SetChildIndex(Me.lblDescription, 0)
        Me.Controls.SetChildIndex(Me.lblDescriptionInfo, 0)
        Me.Controls.SetChildIndex(Me.lblProductNameInfo, 0)
        Me.Controls.SetChildIndex(Me.lblVersionInfo, 0)
        Me.Controls.SetChildIndex(Me.lblCopyrightInfo, 0)
        Me.Controls.SetChildIndex(Me.txtDescriptionInfo, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCompanyName As Label
    Friend WithEvents lblProductName As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblCopyright As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblDescriptionInfo As Label
    Friend WithEvents lblProductNameInfo As Label
    Friend WithEvents lblVersionInfo As Label
    Friend WithEvents lblCopyrightInfo As Label
    Friend WithEvents txtDescriptionInfo As TextBox
End Class
