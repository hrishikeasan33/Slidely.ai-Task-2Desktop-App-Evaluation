Imports System.Net.Http
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private submission As Submission
    Private currentIndex As Integer = 0
    Private WithEvents btnRefresh As New Button  ' Add this line

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        ' Initialize and add the Refresh button
        btnRefresh.Text = "Refresh"
        btnRefresh.Location = New Point(10, 10)  ' Adjust as needed
        Me.Controls.Add(btnRefresh)

        Await GetUserInputAndLoadSubmission()
    End Sub

    Private Async Function GetUserInputAndLoadSubmission() As Task
        Dim userInput As String = InputBox("Enter the index of the submission you want to view:", "Enter Index", "0")

        If Integer.TryParse(userInput, currentIndex) Then
            Await LoadSubmission(currentIndex)
            DisplaySubmission()
        Else
            MessageBox.Show("Invalid input. Please enter a valid number.")
        End If
    End Function

    Private Async Function LoadSubmission(index As Integer) As Task
        Using client As New HttpClient()
            Try
                Dim response = Await client.GetStringAsync($"http://localhost:3000/read?index={index}")
                submission = JsonConvert.DeserializeObject(Of Submission)(response)
            Catch ex As HttpRequestException
                MessageBox.Show($"Error loading submission: {ex.Message}")
                submission = Nothing
            Catch ex As JsonException
                MessageBox.Show($"Error parsing submission data: {ex.Message}")
                submission = Nothing
            End Try
        End Using
    End Function

    Private Sub DisplaySubmission()
        If submission IsNot Nothing Then
            txtName.Text = submission.Name
            txtEmail.Text = submission.Email
            txtPhone.Text = submission.Phone
            txtGithubLink.Text = submission.GithubLink
            txtStopwatchTime.Text = TimeSpan.FromMilliseconds(submission.StopwatchTime).ToString("hh\:mm\:ss")
        Else
            MessageBox.Show("No submission data found for the given index.")
        End If
    End Sub

    Private Async Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Await GetUserInputAndLoadSubmission()
    End Sub
End Class