Public Class Form1
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control Then
            If e.KeyCode = Keys.V Then
                btnview.PerformClick()
            End If
            If e.KeyCode = Keys.N Then
                btncreate.PerformClick()
            End If
        End If
    End Sub

    Private Sub btnview_Click(sender As Object, e As EventArgs) Handles btnview.Click
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.Show()
    End Sub

    Private Sub btncreate_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
    End Sub
End Class
