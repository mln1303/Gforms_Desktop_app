<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblsub = New System.Windows.Forms.Label()
        Me.txtgitlinkc = New System.Windows.Forms.TextBox()
        Me.lblgitlinkc = New System.Windows.Forms.Label()
        Me.txtphnoc = New System.Windows.Forms.TextBox()
        Me.lblphnoc = New System.Windows.Forms.Label()
        Me.txtemailc = New System.Windows.Forms.TextBox()
        Me.lblemailc = New System.Windows.Forms.Label()
        Me.txtnamec = New System.Windows.Forms.TextBox()
        Me.lblnamec = New System.Windows.Forms.Label()
        Me.btnstpwatch = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtstpwatchc = New System.Windows.Forms.TextBox()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblsub
        '
        Me.lblsub.AutoSize = True
        Me.lblsub.Location = New System.Drawing.Point(59, 27)
        Me.lblsub.Name = "lblsub"
        Me.lblsub.Size = New System.Drawing.Size(278, 20)
        Me.lblsub.TabIndex = 23
        Me.lblsub.Text = "Keertana, Slidely- Create Submissions"
        '
        'txtgitlinkc
        '
        Me.txtgitlinkc.Location = New System.Drawing.Point(186, 240)
        Me.txtgitlinkc.Name = "txtgitlinkc"
        Me.txtgitlinkc.Size = New System.Drawing.Size(213, 26)
        Me.txtgitlinkc.TabIndex = 20
        '
        'lblgitlinkc
        '
        Me.lblgitlinkc.AutoSize = True
        Me.lblgitlinkc.Location = New System.Drawing.Point(34, 226)
        Me.lblgitlinkc.Name = "lblgitlinkc"
        Me.lblgitlinkc.Size = New System.Drawing.Size(91, 40)
        Me.lblgitlinkc.TabIndex = 19
        Me.lblgitlinkc.Text = "GitHub like " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For task-2"
        '
        'txtphnoc
        '
        Me.txtphnoc.Location = New System.Drawing.Point(186, 178)
        Me.txtphnoc.Name = "txtphnoc"
        Me.txtphnoc.Size = New System.Drawing.Size(213, 26)
        Me.txtphnoc.TabIndex = 18
        '
        'lblphnoc
        '
        Me.lblphnoc.AutoSize = True
        Me.lblphnoc.Location = New System.Drawing.Point(34, 184)
        Me.lblphnoc.Name = "lblphnoc"
        Me.lblphnoc.Size = New System.Drawing.Size(115, 20)
        Me.lblphnoc.TabIndex = 17
        Me.lblphnoc.Text = "Phone Number"
        '
        'txtemailc
        '
        Me.txtemailc.Location = New System.Drawing.Point(186, 127)
        Me.txtemailc.Name = "txtemailc"
        Me.txtemailc.Size = New System.Drawing.Size(213, 26)
        Me.txtemailc.TabIndex = 16
        '
        'lblemailc
        '
        Me.lblemailc.AutoSize = True
        Me.lblemailc.Location = New System.Drawing.Point(34, 133)
        Me.lblemailc.Name = "lblemailc"
        Me.lblemailc.Size = New System.Drawing.Size(48, 20)
        Me.lblemailc.TabIndex = 15
        Me.lblemailc.Text = "Email"
        '
        'txtnamec
        '
        Me.txtnamec.Location = New System.Drawing.Point(186, 71)
        Me.txtnamec.Name = "txtnamec"
        Me.txtnamec.Size = New System.Drawing.Size(213, 26)
        Me.txtnamec.TabIndex = 14
        '
        'lblnamec
        '
        Me.lblnamec.AutoSize = True
        Me.lblnamec.Location = New System.Drawing.Point(34, 77)
        Me.lblnamec.Name = "lblnamec"
        Me.lblnamec.Size = New System.Drawing.Size(51, 20)
        Me.lblnamec.TabIndex = 13
        Me.lblnamec.Text = "Name"
        '
        'btnstpwatch
        '
        Me.btnstpwatch.BackColor = System.Drawing.SystemColors.Info
        Me.btnstpwatch.Location = New System.Drawing.Point(12, 299)
        Me.btnstpwatch.Name = "btnstpwatch"
        Me.btnstpwatch.Size = New System.Drawing.Size(291, 30)
        Me.btnstpwatch.TabIndex = 24
        Me.btnstpwatch.Text = "TOGGLE STOP WATCH (CTRL+H)"
        Me.btnstpwatch.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'txtstpwatchc
        '
        Me.txtstpwatchc.Location = New System.Drawing.Point(321, 303)
        Me.txtstpwatchc.Name = "txtstpwatchc"
        Me.txtstpwatchc.ReadOnly = True
        Me.txtstpwatchc.Size = New System.Drawing.Size(213, 26)
        Me.txtstpwatchc.TabIndex = 22
        '
        'btnsubmit
        '
        Me.btnsubmit.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnsubmit.Location = New System.Drawing.Point(152, 375)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(270, 30)
        Me.btnsubmit.TabIndex = 25
        Me.btnsubmit.Text = "SUBMIT (CTRL+S)"
        Me.btnsubmit.UseMnemonic = False
        Me.btnsubmit.UseVisualStyleBackColor = False
        '
        'CreateSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.btnstpwatch)
        Me.Controls.Add(Me.lblsub)
        Me.Controls.Add(Me.txtstpwatchc)
        Me.Controls.Add(Me.txtgitlinkc)
        Me.Controls.Add(Me.lblgitlinkc)
        Me.Controls.Add(Me.txtphnoc)
        Me.Controls.Add(Me.lblphnoc)
        Me.Controls.Add(Me.txtemailc)
        Me.Controls.Add(Me.lblemailc)
        Me.Controls.Add(Me.txtnamec)
        Me.Controls.Add(Me.lblnamec)
        Me.KeyPreview = True
        Me.Name = "CreateSubmissionForm"
        Me.Text = "CreateSubmissionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblsub As Label
    Friend WithEvents txtgitlinkc As TextBox
    Friend WithEvents lblgitlinkc As Label
    Friend WithEvents txtphnoc As TextBox
    Friend WithEvents lblphnoc As Label
    Friend WithEvents txtemailc As TextBox
    Friend WithEvents lblemailc As Label
    Friend WithEvents txtnamec As TextBox
    Friend WithEvents lblnamec As Label
    Friend WithEvents btnstpwatch As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtstpwatchc As TextBox
    Friend WithEvents btnsubmit As Button
End Class
