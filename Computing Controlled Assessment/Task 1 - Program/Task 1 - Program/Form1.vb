Public Class Task1
    Dim Sentence, Word, UCSentence, UCWord As String
    Dim Position As Integer
    Dim WordCheck As Boolean = False
    Dim Words As Array
    'These are all of my variables that I shall be using throughout my program.

    Private Sub btnSentence_Click(sender As Object, e As EventArgs) Handles btnSentence.Click
        Sentence = InputBox("Plese enter your sentence here!", "Sentence:")
        'This brings up a message box for the user to enter their sentence into.

        UCSentence = UCase(Sentence)
        'This code makes the sentence uppercase so there is no case sensitivity.

        If UCSentence = "" Then
            MsgBox("You need to enter a sentence!", vbExclamation, "No sentence error:")
            Exit Sub
            'This checks if a sentence has not been entered and brings up an error if so.
        End If

        lstTask1.Items.Add("Your sentence is:")
        lstTask1.Items.Add("'" & Sentence & "'")
        lstTask1.Items.Add("")
        'This shows on the listbox what my sentence is.

        btnSentence.Enabled = False
        btnWord.Enabled = True
        'This switches round which buttons are enabled.
    End Sub

    Private Sub btnWord_Click(sender As Object, e As EventArgs) Handles btnWord.Click
        Word = InputBox("Please enter your word here!", "Word: ")
        'This brings up a message box for the user to enter their word into.

        UCWord = UCase(Word)
        Words = Split(UCSentence, " ")
        'This changes the case of the word and splits the sentence into parts of an array.

        If UCWord = "" Then
            MsgBox("You need to enter a word!", vbExclamation, "No word error:")
            Exit Sub
            'This checks if a word has not been entered and brings up an error message if so.
        ElseIf UCWord.Contains(" ") Then
            MsgBox("Your word '" & Word & "' contains a space! You have either entered two words or entered a space by accident!  Please try again!", vbCritical, "Space error:")
            lstTask1.Items.Add("'" & Word & "'" & " => Failed!")
            Exit Sub
            'This checks whether or not the sentence contains a space which either means one has been entered accidently or two words have been entered.
        End If

        For i = 0 To Words.Length - 1
            If UCWord = Words(i) Then
                Position = i + 1
                lstTask1.Items.Add("'" & Word & "'" & " is in the position: " & Position)
                WordCheck = True
            End If
        Next
        'This loop goes through the sentence and puts the position(s) of the word in the sentence.

        If WordCheck = True Then
            WordCheck = False
        ElseIf WordCheck = False Then
            MsgBox("Your word '" & Word & "' wasn't in the sentence! Please try again!", vbCritical, "No word error:")
            lstTask1.Items.Add("The word '" & Word & "'" & " => Failed!")
        End If
        'This checks if the sentence is even in the sentence at all.

        Me.lstTask1.TopIndex = lstTask1.Items.Count - 1
        'This goes to the bottom of the list box.
    End Sub

    Private Sub mnuFileReset_Click(sender As Object, e As EventArgs) Handles mnuFileReset.Click
        lstTask1.Items.Clear()

        btnSentence.Enabled = True
        btnWord.Enabled = False
        'This button resets the program entirely.
    End Sub

    Private Sub mnuFileClear_Click(sender As Object, e As EventArgs) Handles mnuFileClear.Click
        If Sentence = "" Then
            MsgBox("There is nothing in the list box to clear!", vbExclamation, "Empty list box error:")
        Else
            lstTask1.Items.Clear()

            lstTask1.Items.Add("Your sentence is:")
            lstTask1.Items.Add("'" & Sentence & "'")
            lstTask1.Items.Add("")
        End If
        'This clears the text box of all guesses.
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        MsgBox("Your program is closing!", vbCritical, "Close program:")
        Me.Close()
        'This closes the program and gives you a warning when it does so.
    End Sub
End Class
