<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnview = New System.Windows.Forms.Button()
        Me.btncreate = New System.Windows.Forms.Button()
        Me.lblmainhead = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnview
        '
        Me.btnview.BackColor = System.Drawing.SystemColors.Info
        Me.btnview.Location = New System.Drawing.Point(276, 147)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(308, 30)
        Me.btnview.TabIndex = 0
        Me.btnview.Text = "VIEW SUBMISSIONS(CTRL+V)"
        Me.btnview.UseVisualStyleBackColor = False
        '
        'btncreate
        '
        Me.btncreate.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btncreate.Location = New System.Drawing.Point(276, 207)
        Me.btncreate.Name = "btncreate"
        Me.btncreate.Size = New System.Drawing.Size(308, 33)
        Me.btncreate.TabIndex = 1
        Me.btncreate.Text = "CREATE NEW SUBMISSION(CTRL+N)"
        Me.btncreate.UseVisualStyleBackColor = False
        '
        'lblmainhead
        '
        Me.lblmainhead.AutoSize = True
        Me.lblmainhead.Location = New System.Drawing.Point(295, 82)
        Me.lblmainhead.Name = "lblmainhead"
        Me.lblmainhead.Size = New System.Drawing.Size(254, 20)
        Me.lblmainhead.TabIndex = 2
        Me.lblmainhead.Text = "Keertana, Slidely Task 2, Form app"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblmainhead)
        Me.Controls.Add(Me.btncreate)
        Me.Controls.Add(Me.btnview)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnview As Button
    Friend WithEvents btncreate As Button
    Friend WithEvents lblmainhead As Label
End Class
