Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Text


Public Class ViewSubmissionsForm
    Private submissions As List(Of Dictionary(Of String, String))
    Private currentIndex As Integer = 0
    Private isEditing As Boolean = False

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        submissions = Await ApiHelper.ReadAllSubmissions()
        DisplaySubmission(currentIndex)
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnprev.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnnxt.PerformClick()
        End If
    End Sub

    Private Sub btnprev_Click(sender As Object, e As EventArgs) Handles btnprev.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub btnnxt_Click(sender As Object, e As EventArgs) Handles btnnxt.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub DisplaySubmission(index As Integer)
        If index >= 0 AndAlso index < submissions.Count Then
            Dim submission = submissions(index)
            txtname.Text = submission("name")
            txtemail.Text = submission("email")
            txtphno.Text = submission("phone")
            txtgitlink.Text = submission("github_link")
            txtstpwatch.Text = submission("stopwatch_time")
        Else
            MessageBox.Show("No more submissions.")
            currentIndex -= 1
        End If
    End Sub

    Private Async Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        Dim submission As New Dictionary(Of String, String) From {
        {"name", txtname.Text},
        {"email", txtemail.Text},
        {"phone", txtphno.Text},
        {"github_link", txtgitlink.Text},
        {"stopwatch_time", txtstpwatch.Text}
    }

        ' Call the API to edit the submission (excluding stopwatch_time)
        Dim success As Boolean = Await ApiHelper.EditSubmission(currentIndex, submission)

        If success Then
            MessageBox.Show("Submission edited successfully!")
        Else
            MessageBox.Show("Failed to edit submission.")
        End If
    End Sub

    Private Sub totoggle_Click(sender As Object, e As EventArgs) Handles totoggle.Click
        txtname.ReadOnly = isEditing
        txtemail.ReadOnly = isEditing
        txtphno.ReadOnly = isEditing
        txtgitlink.ReadOnly = isEditing

        isEditing = Not isEditing
    End Sub

    Private Async Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Dim success As Boolean = Await ApiHelper.DeleteSubmission(currentIndex)
        If success Then
            MessageBox.Show("Submission deleted successfully!")
            ' Optionally refresh the display or navigate to the next submission
        Else
            MessageBox.Show("Failed to delete submission.")
        End If
    End Sub
End Class
