Imports System.Diagnostics
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()
    Private Sub btnstpwatch_Click(sender As Object, e As EventArgs) Handles btnstpwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            btnstpwatch.Text = "Start"
        Else
            stopwatch.Start()
            btnstpwatch.Text = "Pause"
        End If
    End Sub
    Private Sub UpdateStopwatchDisplay()
        Dim elapsed As TimeSpan = stopwatch.Elapsed
        txtstpwatchc.Text = String.Format("{0:00}:{1:00}:{2:00}", elapsed.Hours, elapsed.Minutes, elapsed.Seconds)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If stopwatch.IsRunning Then
            UpdateStopwatchDisplay()
        End If
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.H Then
            btnstpwatch.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            btnsubmit.PerformClick()
        End If
    End Sub

    Private Async Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Dim submission As New Dictionary(Of String, String) From {
        {"name", txtnamec.Text},
            {"email", txtemailc.Text},
            {"phone", txtphnoc.Text},
            {"github_link", txtgitlinkc.Text},
            {"stopwatch_time", stopwatch.Elapsed.ToString()}
        }
        Dim success As Boolean = Await ApiHelper.SubmitForm(submission)
        If success Then
            MessageBox.Show("Submission successful!")
        Else
            MessageBox.Show("Submission failed.")
        End If

    End Sub

    Private Sub ClearForm()
        txtnamec.Text = ""
        txtemailc.Text = ""
        txtphnoc.Text = ""
        txtgitlinkc.Text = ""
        txtstpwatchc.Text = ""
    End Sub


End Class