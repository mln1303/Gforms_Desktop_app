<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        Me.lblname = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.lblphno = New System.Windows.Forms.Label()
        Me.txtphno = New System.Windows.Forms.TextBox()
        Me.lblgitlink = New System.Windows.Forms.Label()
        Me.txtgitlink = New System.Windows.Forms.TextBox()
        Me.lblstpwatch = New System.Windows.Forms.Label()
        Me.txtstpwatch = New System.Windows.Forms.TextBox()
        Me.btnprev = New System.Windows.Forms.Button()
        Me.btnnxt = New System.Windows.Forms.Button()
        Me.lblheading = New System.Windows.Forms.Label()
        Me.delete = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.totoggle = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(36, 83)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(51, 20)
        Me.lblname.TabIndex = 0
        Me.lblname.Text = "Name"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(188, 77)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(213, 26)
        Me.txtname.TabIndex = 1
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Location = New System.Drawing.Point(36, 139)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(48, 20)
        Me.lblemail.TabIndex = 2
        Me.lblemail.Text = "Email"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(188, 133)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.ReadOnly = True
        Me.txtemail.Size = New System.Drawing.Size(213, 26)
        Me.txtemail.TabIndex = 3
        '
        'lblphno
        '
        Me.lblphno.AutoSize = True
        Me.lblphno.Location = New System.Drawing.Point(36, 190)
        Me.lblphno.Name = "lblphno"
        Me.lblphno.Size = New System.Drawing.Size(115, 20)
        Me.lblphno.TabIndex = 4
        Me.lblphno.Text = "Phone Number"
        '
        'txtphno
        '
        Me.txtphno.Location = New System.Drawing.Point(188, 184)
        Me.txtphno.Name = "txtphno"
        Me.txtphno.ReadOnly = True
        Me.txtphno.Size = New System.Drawing.Size(213, 26)
        Me.txtphno.TabIndex = 5
        '
        'lblgitlink
        '
        Me.lblgitlink.AutoSize = True
        Me.lblgitlink.Location = New System.Drawing.Point(36, 245)
        Me.lblgitlink.Name = "lblgitlink"
        Me.lblgitlink.Size = New System.Drawing.Size(91, 40)
        Me.lblgitlink.TabIndex = 6
        Me.lblgitlink.Text = "GitHub like " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For task-2"
        '
        'txtgitlink
        '
        Me.txtgitlink.Location = New System.Drawing.Point(188, 259)
        Me.txtgitlink.Name = "txtgitlink"
        Me.txtgitlink.ReadOnly = True
        Me.txtgitlink.Size = New System.Drawing.Size(213, 26)
        Me.txtgitlink.TabIndex = 7
        '
        'lblstpwatch
        '
        Me.lblstpwatch.AutoSize = True
        Me.lblstpwatch.Location = New System.Drawing.Point(36, 322)
        Me.lblstpwatch.Name = "lblstpwatch"
        Me.lblstpwatch.Size = New System.Drawing.Size(85, 40)
        Me.lblstpwatch.TabIndex = 8
        Me.lblstpwatch.Text = "Stopwatch" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    time"
        '
        'txtstpwatch
        '
        Me.txtstpwatch.Location = New System.Drawing.Point(188, 336)
        Me.txtstpwatch.Name = "txtstpwatch"
        Me.txtstpwatch.ReadOnly = True
        Me.txtstpwatch.Size = New System.Drawing.Size(213, 26)
        Me.txtstpwatch.TabIndex = 9
        '
        'btnprev
        '
        Me.btnprev.BackColor = System.Drawing.SystemColors.Info
        Me.btnprev.Location = New System.Drawing.Point(12, 396)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(212, 30)
        Me.btnprev.TabIndex = 10
        Me.btnprev.Text = "PREVIOUS (CTRL+P)"
        Me.btnprev.UseVisualStyleBackColor = False
        '
        'btnnxt
        '
        Me.btnnxt.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnnxt.Location = New System.Drawing.Point(266, 396)
        Me.btnnxt.Name = "btnnxt"
        Me.btnnxt.Size = New System.Drawing.Size(212, 30)
        Me.btnnxt.TabIndex = 11
        Me.btnnxt.Text = "NEXT (CTRL+N)"
        Me.btnnxt.UseVisualStyleBackColor = False
        '
        'lblheading
        '
        Me.lblheading.AutoSize = True
        Me.lblheading.Location = New System.Drawing.Point(61, 33)
        Me.lblheading.Name = "lblheading"
        Me.lblheading.Size = New System.Drawing.Size(264, 20)
        Me.lblheading.TabIndex = 12
        Me.lblheading.Text = "Keertana, Slidely- View Submissions"
        '
        'delete
        '
        Me.delete.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.delete.Location = New System.Drawing.Point(501, 259)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(212, 30)
        Me.delete.TabIndex = 14
        Me.delete.Text = "DELETE SUBMISSION"
        Me.delete.UseVisualStyleBackColor = False
        '
        'edit
        '
        Me.edit.BackColor = System.Drawing.SystemColors.Info
        Me.edit.Location = New System.Drawing.Point(501, 190)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(212, 30)
        Me.edit.TabIndex = 27
        Me.edit.Text = "SUBMIT EDITED FORM"
        Me.edit.UseVisualStyleBackColor = False
        '
        'totoggle
        '
        Me.totoggle.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.totoggle.Location = New System.Drawing.Point(501, 129)
        Me.totoggle.Name = "totoggle"
        Me.totoggle.Size = New System.Drawing.Size(212, 30)
        Me.totoggle.TabIndex = 28
        Me.totoggle.Text = "EDIT SUBMISSION"
        Me.totoggle.UseVisualStyleBackColor = False
        '
        'ViewSubmissionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.totoggle)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.lblheading)
        Me.Controls.Add(Me.btnnxt)
        Me.Controls.Add(Me.btnprev)
        Me.Controls.Add(Me.txtstpwatch)
        Me.Controls.Add(Me.lblstpwatch)
        Me.Controls.Add(Me.txtgitlink)
        Me.Controls.Add(Me.lblgitlink)
        Me.Controls.Add(Me.txtphno)
        Me.Controls.Add(Me.lblphno)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.lblname)
        Me.KeyPreview = True
        Me.Name = "ViewSubmissionsForm"
        Me.Text = "ViewSubmissionsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblname As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents lblemail As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents lblphno As Label
    Friend WithEvents txtphno As TextBox
    Friend WithEvents lblgitlink As Label
    Friend WithEvents txtgitlink As TextBox
    Friend WithEvents lblstpwatch As Label
    Friend WithEvents txtstpwatch As TextBox
    Friend WithEvents btnprev As Button
    Friend WithEvents btnnxt As Button
    Friend WithEvents lblheading As Label
    Friend WithEvents delete As Button
    Friend WithEvents edit As Button
    Friend WithEvents totoggle As Button
End Class
