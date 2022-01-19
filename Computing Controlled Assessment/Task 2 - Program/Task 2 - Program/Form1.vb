'Allows me to use a stream writer so I can write to the file.
Imports System.IO

Public Class Task2

    Private Sub btnCompress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompress.Click
        'Changes the settings of the dialogue so the user will save a text file.
        saveFD.InitialDirectory = "X:\Computing - Controlled Assessment\Task 2 - Program\Task 2 - Text Files Folder"
        saveFD.Title = "Save your file here:"
        saveFD.Filter = "Text Files|*.txt "

        'Opens the save file dialogue box.
        saveFD.ShowDialog()

        'Declares the file name and sets it as the name of the saved file. This allows the stream writer to write to that file.
        Dim File_Name As String
        File_Name = saveFD.FileName

        'Checks to see if a file name was entered or not.
        If String.IsNullOrEmpty(File_Name) Then
            MsgBox("You need to enter a file name!", vbCritical, "No file name!")
            Exit Sub
        End If

        'Declares the stream writer which will write to the file. It also turns on auto flush that writes any information to the file.
        Dim SW As New StreamWriter(File_Name, True)
        SW.AutoFlush = True

        'Declares the sentence that will equal what is ever entered into the input box.
        Dim Sentence As String = InputBox("Please enter your sentence here!", "Sentence:")

        'Checks if the sentence is empty or contains only spaces.
        If String.IsNullOrWhiteSpace(Sentence) = True Then
            MsgBox("You need to enter a sentence!", vbExclamation, "No sentence error:")
            Exit Sub
        Else
            'Makes the entire sentence upper case so it doesn't see words with different capitalisation as different words.
            Sentence = UCase(Sentence)
        End If

        'Writes the sentence to the list box and the file.
        lstTask2.Items.Add("Your sentence is: " & Sentence)

        'Declares the variables that will be necessary for making a list of unique words and positions and splits the sentence into an array.
        Dim Sentence_Words() As String = Split(Sentence, " ")
        Dim Unique_Positions() As Integer = {}
        Dim Unique_Words() As String = {}

        Dim Count_Words As Integer = 0

        'Loops through the sentence words array and makes a list of unique words.
        For i = 0 To Sentence_Words.Length - 1
            Dim Word As String = Sentence_Words(i)

            If Not Unique_Words.Contains(Word) Then
                ReDim Preserve Unique_Words(Count_Words)
                Unique_Words(Count_Words) = Word
                Count_Words = Count_Words + 1
            End If
        Next

        'Makes the size of the unique positons array as the same size of the sentence words array.
        ReDim Preserve Unique_Positions(Sentence_Words.Length - 1)

        'Starts the array that makes the list of unique positons.
        For i = 0 To Sentence_Words.Length - 1
            Dim Word As String = Sentence_Words(i)
            Dim Position As Integer

            'Returns the positon of the word in the unique words array.
            For j = 0 To Unique_Words.Length - 1
                If Word = Unique_Words(j) Then
                    Position = Array.IndexOf(Unique_Words, Word)
                End If
            Next

            Unique_Positions(i) = Position
        Next

        'Writes to the file and the text file the unique words list that is a string which is formed by joining the unique words array.
        Dim Unique_Words_List As String = String.Join(",", Unique_Words)
        lstTask2.Items.Add("Your unique words are: " & Unique_Words_List)
        SW.WriteLine(Unique_Words_List)

        'Writes to the file and the text file the unique positons list that is a string which is formed by joining the unique positions array.
        Dim Unique_Positions_List As String = String.Join(", ", Unique_Positions)
        lstTask2.Items.Add("Your unique positions are: " & Unique_Positions_List)
        SW.WriteLine(Unique_Positions_List)

        'Scrolls to the bottom of the list box.
        Me.lstTask2.TopIndex = lstTask2.Items.Count - 1

        'Closes the stream writer.
        SW.Close()
    End Sub

    Private Sub mnuFileReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileReset.Click
        'Clears the list box.
        lstTask2.Items.Clear()
    End Sub

    Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        'Exits the file after giving a warning.
        MsgBox("Your program is closing!", vbCritical, "Close program:")
        Me.Close()
    End Sub
End Class
