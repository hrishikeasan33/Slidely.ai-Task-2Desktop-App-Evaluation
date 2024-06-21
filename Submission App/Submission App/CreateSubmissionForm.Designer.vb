<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        lblName = New Label()
        lblEmail = New Label()
        lblPhone = New Label()
        lblGithubLink = New Label()
        lblStopwatchTime = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGithubLink = New TextBox()
        txtStopwatchTime = New TextBox()
        btnSubmit = New Button()
        btnStopwatch = New Button()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(153, 96)
        lblName.Name = "lblName"
        lblName.Size = New Size(52, 20)
        lblName.TabIndex = 0
        lblName.Text = "Name:"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(153, 165)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(46, 20)
        lblEmail.TabIndex = 1
        lblEmail.Text = "Email"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(153, 224)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(53, 20)
        lblPhone.TabIndex = 2
        lblPhone.Text = "Phone:"
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.AutoSize = True
        lblGithubLink.Location = New Point(153, 281)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(89, 20)
        lblGithubLink.TabIndex = 3
        lblGithubLink.Text = "GitHub Link:"
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.AutoSize = True
        lblStopwatchTime.Location = New Point(153, 345)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Size = New Size(119, 20)
        lblStopwatchTime.TabIndex = 4
        lblStopwatchTime.Text = "Stopwatch Time:"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(358, 89)
        txtName.Name = "txtName"
        txtName.Size = New Size(223, 27)
        txtName.TabIndex = 5
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(358, 160)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(223, 27)
        txtEmail.TabIndex = 6
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(358, 215)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(223, 27)
        txtPhone.TabIndex = 7
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Location = New Point(358, 274)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(223, 27)
        txtGithubLink.TabIndex = 8
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.Location = New Point(358, 342)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.ReadOnly = True
        txtStopwatchTime.Size = New Size(223, 27)
        txtStopwatchTime.TabIndex = 9
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(177, 393)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(153, 29)
        btnSubmit.TabIndex = 10
        btnSubmit.Text = "SUBMIT (CTRL + S)"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' btnStopwatch
        ' 
        btnStopwatch.Location = New Point(470, 393)
        btnStopwatch.Name = "btnStopwatch"
        btnStopwatch.Size = New Size(135, 29)
        btnStopwatch.TabIndex = 11
        btnStopwatch.Text = "START/STOP"
        btnStopwatch.UseVisualStyleBackColor = True
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnStopwatch)
        Controls.Add(btnSubmit)
        Controls.Add(txtStopwatchTime)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(lblStopwatchTime)
        Controls.Add(lblGithubLink)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGithubLink As Label
    Friend WithEvents lblStopwatchTime As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnStopwatch As Button
End Class
