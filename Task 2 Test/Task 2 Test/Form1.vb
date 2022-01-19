Imports System.IO

Public Class Form1
    Dim File_Name As String
    Dim SW As StreamWriter

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        saveFD.FileName = File_Name

        saveFD.InitialDirectory = "C:\Users\Tom Hoad\Documents\Text Files"
        saveFD.Title = "Select a location to save your file:"
        saveFD.Filter = "Text Files|*.txt"
        saveFD.ShowDialog()

        File_Name = saveFD.FileName
        SW = New StreamWriter(File_Name, True)
        SW.AutoFlush = True
    End Sub

    Private Sub btnCompress_Click(sender As Object, e As EventArgs) Handles btnCompress.Click
        Dim Sentence As String = InputBox("Please enter some text:", "Enter text here:")

        If String.IsNullOrWhiteSpace(Sentence) Then
            MsgBox("You need to enter some text!", vbExclamation, "No text!")
            Exit Sub
        End If

        lstTask2.Items.Add("Text = " & Sentence)
        SW.WriteLine("Text = " & Sentence)

        Dim Sentence_Words() As String = Sentence.Trim.Split(" ")
        Dim Unique_Positions() As Integer = {}
        Dim Unique_Words() As String = {}

        Dim Count_UWords As Integer = 0

        For i = 0 To Sentence_Words.Length - 1
            Dim Word As String = Sentence_Words(i)

            If Not Unique_Words.Contains(Word) Then
                ReDim Preserve Unique_Words(Count_UWords)
                Unique_Words(Count_UWords) = Word

                Count_UWords = Count_UWords + 1
            End If
        Next

        ReDim Preserve Unique_Positions(Sentence_Words.Length - 1)

        For i = 0 To Sentence_Words.Length - 1
            Dim Word As String = Sentence_Words(i)
            Dim Position As Integer

            For j = 0 To Unique_Words.Length - 1
                If Unique_Words(j) = Word Then
                    Position = Array.IndexOf(Unique_Words, Word) + 1
                End If
            Next

            Unique_Positions(i) = Position
        Next

        Dim Unique_Words_List As String = String.Join(", ", Unique_Words)
        lstTask2.Items.Add("Unique words = " & Unique_Words_List)
        SW.WriteLine("Unique words = " & Unique_Words_List)

        Dim Unique_Positions_List As String = String.Join(", ", Unique_Positions)
        lstTask2.Items.Add("Unique positions = " & Unique_Positions_List)
        SW.WriteLine("Unique positions = " & Unique_Positions_List)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SW.Close()
    End Sub
End Class
