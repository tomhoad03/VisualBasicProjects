'Sets up the form to use paticular functions relating to file saving, reading and opening.
Imports System.IO

Public Class Task3
    Dim Save_File_Name, Open_File_Name, Saved_File_Name, Read_Unique_Words, Read_Unique_Positions As String

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        saveFD.InitialDirectory = "C:\Users\Tom Hoad\Documents\Computing Controlled Assessment\Task 3 - Program\Task 3 - Files\Task 3 - Text Files"
        saveFD.Title = "Save your text file here:"
        saveFD.FileName = "Text file name:"
        saveFD.Filter = "Text Files|*.txt"
        saveFD.OverwritePrompt = True

        Dim saveFDResult As DialogResult = saveFD.ShowDialog()

        Save_File_Name = saveFD.FileName

        If saveFDResult = DialogResult.Cancel Then
            Exit Sub
        ElseIf File.Exists(Save_File_Name) Then
            File.Delete(Save_File_Name)
        End If

        If String.IsNullOrWhiteSpace(Save_File_Name) Then
            MsgBox("You need to enter a name for your text file!", vbCritical, "No file name!")
            Exit Sub
        End If

        Dim SW As New StreamWriter(Save_File_Name, True)
        SW.AutoFlush = True

        Dim Original_Text As String = txtRead.Text

        If String.IsNullOrWhiteSpace(Original_Text) Then
            MsgBox("You have not entered any text!", vbCritical, "No text!")
            Exit Sub
        Else
            lstTask3.Items.Add("Your entered sentence is: " & Original_Text)
            SW.WriteLine(Original_Text)

            Saved_File_Name = Save_File_Name

            MsgBox("You text file has saved.", vbInformation, "Saved!")
        End If

        SW.Close()
    End Sub

    Private Sub btnCompress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompress.Click
        Dim Response As Integer = MsgBox("Do you want to use the text file that you just saved?", vbYesNoCancel + vbQuestion, "Use saved text file?")
        Dim Uncompressed_Text As String = ""

        If Response = vbYes Then
            If String.IsNullOrWhiteSpace(Saved_File_Name) Then
                MsgBox("You haven't saved a file yet!", vbCritical, "Not saved file!")
                Exit Sub
            Else
                Dim SR As New StreamReader(Save_File_Name, True)

                Do Until SR.EndOfStream
                    Uncompressed_Text = Uncompressed_Text & SR.ReadLine & " "
                Loop

                txtRead.Text = Uncompressed_Text

                SR.Close()
            End If
        ElseIf Response = vbNo Then
            openFD.InitialDirectory = "C:\Users\Tom Hoad\Documents\Computing Controlled Assessment\Task 3 - Program\Task 3 - Files\Task 3 - Text Files"
            openFD.Title = "Select a file to be decompressed:"
            openFD.Filter = "Text Files|*.txt"

            Dim openFDResult As DialogResult = openFD.ShowDialog()

            Open_File_Name = openFD.FileName

            If openFDResult = DialogResult.Cancel Then
                Exit Sub
            End If

            Dim SR As New StreamReader(Open_File_Name, True)

            Do Until SR.EndOfStream
                Uncompressed_Text = Uncompressed_Text & SR.ReadLine & " "
            Loop

            txtRead.Text = Uncompressed_Text

            SR.Close()
        Else
            Exit Sub
        End If

        Dim Text_Words() As String = Split(Uncompressed_Text, " ")
        Dim Unique_Words() As String = {}
        Dim Unique_Positions() As String = {}

        Dim Count_Words As Integer = 0

        For i = 0 To Text_Words.Length - 1
            Dim Word As String = Text_Words(i)

            If Not Unique_Words.Contains(Word) Then
                ReDim Preserve Unique_Words(Count_Words)
                Unique_Words(Count_Words) = Word
                Count_Words = Count_Words + 1
            End If
        Next

        ReDim Preserve Unique_Positions(Text_Words.Length - 1)

        For i = 0 To Text_Words.Length - 1
            Dim Word As String = Text_Words(i)
            Dim Position As Integer

            For j = 0 To Unique_Words.Length - 1
                If Word = Unique_Words(j) Then
                    Position = Array.IndexOf(Unique_Words, Word)
                End If
            Next

            Unique_Positions(i) = Position + 1
        Next

        Save_File_Name = Replace(Save_File_Name, ".txt", "COMPRESS.txt")

        Dim SW As New StreamWriter(Save_File_Name, True)
        SW.AutoFlush = True

        Dim Unique_Words_List As String = String.Join(", ", Unique_Words)
        SW.WriteLine(Unique_Words_List)

        SW.WriteLine("|")

        Dim Unique_Positions_List As String = String.Join(", ", Unique_Positions)
        SW.WriteLine(Unique_Positions_List)

        lstTask3.Items.Add("Your compressed file has been saved.")

        SW.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        openFD.InitialDirectory = "C:\Users\Tom Hoad\Documents\Computing Controlled Assessment\Task 3 - Program\Task 3 - Files\Task 3 - Compressed Files"
        openFD.Title = "Select a file to be decompressed:"
        openFD.Filter = "Text Files|*.txt"

        Dim openFDResult As DialogResult = openFD.ShowDialog()

        Open_File_Name = openFD.FileName

        If openFDResult = DialogResult.Cancel Then
            Exit Sub
        End If

        Dim SR_Count As New StreamReader(Open_File_Name, True)

        Dim Count_Lines As Integer

        Do Until SR_Count.EndOfStream
            If SR_Count_ReadLine = "|" Then

            End If
        Loop

        Read_Unique_Positions = SR.ReadLine()

        MsgBox(Read_Unique_Words)
        MsgBox(Read_Unique_Positions)

        lstTask3.Items.Add("Your file has been selected!")

        SR.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If String.IsNullOrWhiteSpace(Read_Unique_Words) Or String.IsNullOrWhiteSpace(Read_Unique_Positions) Then
            MsgBox("Either you have not selected a file or you selected the wrong type of file!", vbCritical, "No file selected!")
            Exit Sub
        End If

        Dim Recreated_Unique_Words() As String = Split(Read_Unique_Words, ", ")
        Dim Recreated_Unique_Positions() As String = Split(Read_Unique_Positions, ", ")

        Dim Decompressed_Words() As String = {}

        ReDim Preserve Decompressed_Words(Recreated_Unique_Positions.Length - 1)

        For i = 0 To Recreated_Unique_Positions.Length - 1
            Dim Unique_Position As Integer = Recreated_Unique_Positions(i) - 1
            Dim Word As String

            For j = 0 To Recreated_Unique_Words.Length - 1
                If Unique_Position = j Then
                    Word = Recreated_Unique_Words(j)
                    Decompressed_Words(i) = Word
                End If
            Next
        Next

        Save_File_Name = Replace(Save_File_Name, ".txt", "DECOMPRESS.txt")

        Dim SW As New StreamWriter(Save_File_Name, True)
        SW.AutoFlush = True

        Dim Decompressed_Text As String = String.Join(" ", Decompressed_Words)
        lstTask3.Items.Add("Your decompressed sentence has been saved!")
        SW.WriteLine(Decompressed_Text)

        SW.Close()
    End Sub


    Private Sub mnuFileClear_Click(sender As Object, e As EventArgs) Handles mnuFileClear.Click
        lstTask3.Items.Clear()
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Dim Response As Integer = MsgBox("Do you want to exit?", vbYesNo + vbQuestion, "Exit?")

        If Response = vbYes Then
            Me.Close()
        End If
    End Sub
End Class
