Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Text

Public Class ApiHelper
    Private Shared ReadOnly client As HttpClient = New HttpClient()
    Private Const BaseUrl As String = "http://localhost:3000"

    Public Shared Async Function SubmitForm(submission As Dictionary(Of String, String)) As Task(Of Boolean)
        Try
            Dim json = JsonConvert.SerializeObject(submission)
            Dim content = New StringContent(json, Encoding.UTF8, "application/json")
            Dim response = Await client.PostAsync("http://localhost:3000/submit", content)
            Return response.IsSuccessStatusCode
        Catch ex As Exception
            ' Handle exceptions
            Console.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    Public Shared Async Function ReadSubmission(index As Integer) As Task(Of Dictionary(Of String, String))
        Try
            Dim response = Await client.GetAsync($"http://localhost:3000/read?index={index}")
            If response.IsSuccessStatusCode Then
                Dim json = Await response.Content.ReadAsStringAsync()
                Return JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(json)
            End If
            Return Nothing
        Catch ex As Exception
            ' Handle exceptions
            Console.WriteLine(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Shared Async Function ReadAllSubmissions() As Task(Of List(Of Dictionary(Of String, String)))
        Try
            Dim response = Await client.GetAsync("http://localhost:3000/allsubmissions")
            If response.IsSuccessStatusCode Then
                Dim json = Await response.Content.ReadAsStringAsync()
                Return JsonConvert.DeserializeObject(Of List(Of Dictionary(Of String, String)))(json)
            End If
            Return New List(Of Dictionary(Of String, String))()
        Catch ex As Exception
            ' Handle exceptions
            Console.WriteLine(ex.Message)
            Return New List(Of Dictionary(Of String, String))()
        End Try
    End Function
    Public Shared Async Function EditSubmission(index As Integer, submission As Dictionary(Of String, String)) As Task(Of Boolean)
        Try
            Dim json = JsonConvert.SerializeObject(submission)
            Dim content = New StringContent(json, Encoding.UTF8, "application/json")
            Dim response = Await client.PutAsync($"http://localhost:3000/edit?index={index}", content)
            Return response.IsSuccessStatusCode
        Catch ex As Exception
            ' Handle exceptions
            Console.WriteLine(ex.Message)
            Return False
        End Try
    End Function
    Public Shared Async Function DeleteSubmission(index As Integer) As Task(Of Boolean)
        Try
            Dim response = Await client.DeleteAsync($"http://localhost:3000/delete?index={index}")
            Return response.IsSuccessStatusCode
        Catch ex As Exception
            ' Handle exceptions
            Console.WriteLine(ex.Message)
            Return False
        End Try
    End Function

End Class


