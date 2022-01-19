Imports System.IO

Public Class Form1

    Dim Original_Text As String

    Private Sub btnCompress_Click(sender As Object, e As EventArgs) Handles btnCompress.Click
        openFD.InitialDirectory = "C:\Users\Tom Hoad\Documents\Visual Studio 2015\Projects\Task 3\Task 3 Files\Original Files"
        openFD.Title = "Select the text file that you want to open:"
        openFD.Filter = "Text Files|*.txt|Word Documents|*.doc"
        openFD.FileName = ""

        If openFD.ShowDialog <> DialogResult.OK Then
            Exit Sub
        Else
            Dim SR As New StreamReader(openFD.FileName)
            Dim Line_Count As Integer = 0

            Do Until Line_Count
                If Not String.IsNullOrWhiteSpace(SR.ReadLine) Then
                    Line_Count = Line_Count + 1
                End If
            Loop

            For i = 0 To Line_Count
                Original_Text = Original_Text & SR.ReadLine & " "
            Next

            lstTask3.Items.Add(Original_Text)

            SR.Close()
        End If
    End Sub

    Private Sub btnDecompress_Click(sender As Object, e As EventArgs) Handles btnDecompress.Click

    End Sub
End Class
