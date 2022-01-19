Public Class Hangman

    Dim word, lives, letters_left, letter, underscores As String

    Dim food() As String = {"Pizza", "Burger", "Lasagne", "Curry", "Quiche"}
    Dim sport() As String = {"Football", "Basketball", "Cricket", "Badminton", "Volleyball"}
    Dim countries() As String = {"Portugal", "Paraguay", "Jamaica", "Malaysia", "Ethiopia"}

    Dim oDice As New Random
    Dim iDiceResult As Integer = oDice.Next(1, 5)

    Private Sub Hangman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call mnuFileReset_Click(sender, e)
        Call reset()
    End Sub

    Private Sub btnGuessLetter_Click(sender As Object, e As EventArgs) Handles btnGuessLetter.Click
        Call full_word()
        Call lives_check()

        letter = txtLetter.Text
        letter = letter.Trim
        word = UCase(word)
        txtLetter.MaxLength = 1

        If mnuCategoriesFood.Enabled = True Or mnuCategoriesSport.Enabled = True Or mnuCategoriesCountries.Enabled = True Then
            MsgBox("You need to select a category from the menu or the combo box!", 48, "Category needs selecting!")
            txtLetter.Clear()
            Exit Sub
        End If

        If letter.Trim = "" Then
            MsgBox("You need to enter in a letter!", vbExclamation, "No letter!")
            Exit Sub
        End If

        If letter Like "*[a-z]*" Then
            letter = UCase(letter)
        End If

        If letter Like "*[A-Z]*" Then
            Dim count As Integer
            For count = 0 To pnlAlphabet.Controls.Count - 1
                If pnlAlphabet.Controls.Item(count).Text = letter Then
                    If pnlAlphabet.Controls.Item(count).ForeColor <> SystemColors.ControlText Then
                        MsgBox("You have already guessed that letter!", vbExclamation, "Double Guess!")
                        Exit Sub
                    End If
                End If
            Next

            If word.Contains(letter) Then
                For count = 0 To pnlAlphabet.Controls.Count - 1
                    If pnlAlphabet.Controls.Item(count).Text = letter Then
                        pnlAlphabet.Controls.Item(count).ForeColor = Color.Green
                    End If
                Next

                Dim Current_Word As String = lblUnderscores.Text
                Dim word_characters() = Current_Word.ToCharArray()

                For count = 0 To Len(word) - 1
                    If word.Chars(count) = letter Then
                        word_characters(2 * count) = letter
                    End If
                Next

                Dim new_word As String = word_characters
                Call lives_count()

                lblUnderscores.Text = new_word
                txtLetter.Clear()
            Else
                For count = 0 To pnlAlphabet.Controls.Count - 1
                    If pnlAlphabet.Controls.Item(count).Text = letter Then
                        pnlAlphabet.Controls.Item(count).ForeColor = Color.Red
                    End If
                Next

                Call Wrong_Guess()
            End If
        ElseIf letter Like " *[0-9]*" Then
            MsgBox("You entered a number! You cannot enter numbers!", vbExclamation, "Number entered!")
            txtLetter.Clear()
            Exit Sub
        Else
            MsgBox("You have entered in a symbol! You cannot enter symbols!", vbExclamation, "Symbol entered!")
            txtLetter.Clear()
            Exit Sub
        End If

        Call full_word()
        Call lives_check()
    End Sub

    Private Sub btnGuessWord_Click(sender As Object, e As EventArgs) Handles btnGuessWord.Click
        Dim Input_Word As String

        Input_Word = InputBox("What is the word?")

        If LCase(Input_Word) = LCase(word) Then
            Call You_Win()
        Else
            Call Wrong_Guess()
        End If
    End Sub

    Private Sub mnuFileReset_Click(sender As Object, e As EventArgs) Handles mnuFileReset.Click
        Call reset()
    End Sub

    Private Sub mnuCategoriesFood_Click(sender As Object, e As EventArgs) Handles mnuCategoriesFood.Click
        If mnuCategoriesFood.Checked = True Then
            mnuCategoriesFood.Enabled = False
            mnuCategoriesSport.Enabled = False
            mnuCategoriesCountries.Enabled = False

            Call makeUnderscores(word)

            comboCategories.Text = "Food"
            word = food(iDiceResult.ToString)
            lblUnderscores.Visible = True
        End If
    End Sub

    Private Sub mnuCategoriesSport_Click(sender As Object, e As EventArgs) Handles mnuCategoriesSport.Click
        If mnuCategoriesSport.Checked = True Then
            mnuCategoriesFood.Enabled = False
            mnuCategoriesSport.Enabled = False
            mnuCategoriesCountries.Enabled = False

            Call makeUnderscores(word)

            comboCategories.Text = "Sport"
            word = sport(iDiceResult.ToString)
            lblUnderscores.Visible = True
        End If
    End Sub

    Private Sub mnuCategoriesCountries_Click(sender As Object, e As EventArgs) Handles mnuCategoriesCountries.Click
        If mnuCategoriesCountries.Checked = True Then
            mnuCategoriesFood.Enabled = False
            mnuCategoriesSport.Enabled = False
            mnuCategoriesCountries.Enabled = False

            Call makeUnderscores(word)

            comboCategories.Text = "Countries"
            word = countries(iDiceResult.ToString)
            lblUnderscores.Visible = True
        End If
    End Sub

    Private Sub cbmoCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboCategories.SelectedIndexChanged
        Call Clear_Checked()

        If comboCategories.SelectedIndex = 0 Then
            mnuCategoriesFood.Checked = True
            Call mnuCategoriesFood_Click(sender, e)
        ElseIf comboCategories.SelectedIndex = 1 Then
            mnuCategoriesSport.Checked = True
            Call mnuCategoriesSport_Click(sender, e)
        ElseIf comboCategories.SelectedIndex = 2 Then
            mnuCategoriesCountries.Checked = True
            Call mnuCategoriesCountries_Click(sender, e)
        Else
            comboCategories.Text = "Unknown"
        End If
    End Sub

    Private Sub makeUnderscores(word As String)
        Dim blank_string As String = ""
        Dim count As Integer

        underscores = Len(word)
        letters_left = Len(word)
        lblLettersCount.Text = letters_left

        For count = 0 To Len(word) - 1
            blank_string += "_" & " "
        Next

        lblUnderscores.Text = blank_string
    End Sub

    Sub Wrong_Guess()
        lives = lives - 1
        MsgBox("You have guessed wrong! You will lose a life!", vbExclamation, "Wrong Guess!")
        Call lives_check()
    End Sub

    Sub You_Win()
        MsgBox("You win!", vbInformation, "Congratulations!")
        lblUnderscores.Text = word
        txtLetter.Clear()
    End Sub

    Sub Clear_Checked()
        mnuCategoriesFood.Checked = False
        mnuCategoriesSport.Checked = False
        mnuCategoriesCountries.Checked = False
    End Sub

    Sub lives_count()
        Call lives_check()
    End Sub

    Sub lives_check()
        If lives = 6 Then
            picHangman.Image = My.Resources._6_lives
            Call lives_count()
        ElseIf lives = 5 Then
            picHangman.Image = My.Resources._5_lives
            Call lives_count()
        ElseIf lives = 4 Then
            picHangman.Image = My.Resources._4_lives
            Call lives_count()
        ElseIf lives = 3 Then
            picHangman.Image = My.Resources._3_lives
            Call lives_count()
        ElseIf lives = 2 Then
            picHangman.Image = My.Resources._2_lives
            Call lives_count()
        ElseIf lives = 1 Then
            picHangman.Image = My.Resources._1_life
            Call lives_count()
        ElseIf lives = 0 Then
            picHangman.Image = My.Resources._0_lives
            Call lives_count()
            MsgBox("Hangman!", vbCritical, "Hangman!")
        End If

        lblLivesCount.Text = lives
    End Sub

    Sub full_word()
        If lblUnderscores.Text = word Then
            MsgBox("You win!", vbOKOnly, "Congratulations!")
            lblUnderscores.Text = word
            txtLetter.Clear()
        End If
    End Sub

    Sub reset()
        lives = 6
        letters_left = 0
        lblLettersCount.Text = letters_left
        comboCategories.Text = "Unknown"
        txtLetter.Clear()

        mnuCategoriesFood.Enabled = True
        mnuCategoriesSport.Enabled = True
        mnuCategoriesCountries.Enabled = True

        mnuCategoriesFood.Checked = False
        mnuCategoriesSport.Checked = False
        mnuCategoriesCountries.Checked = False

        lblUnderscores.Visible = False

        picHangman.Image = My.Resources._6_lives

        Dim count As Integer
        For count = 0 To pnlAlphabet.Controls.Count - 1
            If pnlAlphabet.Controls.Item(count).Text = letter Then
                pnlAlphabet.Controls.Item(count).ForeColor = SystemColors.ControlText
            End If
        Next
    End Sub

    Private Sub mnuFileDetails_Click(sender As Object, e As EventArgs) Handles mnuFileDetails.Click
        MsgBox("This Is a game of Hangman made in Visual Basic by Tom H.", 0, "Details: ")
    End Sub

    Private Sub mnuMainExit_Click(sender As Object, e As EventArgs) Handles mnuMainExit.Click
        Me.Close()
    End Sub

    Private Sub mnuHelpCenter_Click(sender As Object, e As EventArgs) Handles mnuHelpCenter.Click
        MsgBox("This is my hangman game which you can play right now! Choose a category from the menu and the guess a letter!", vbInformation, "Help Centre")
    End Sub
End Class
