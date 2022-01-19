Public Class Excercises
    Private Sub btnCMajor_Click(sender As Object, e As EventArgs) Handles btnCMajor.Click
        Dim Notes As String = "ABCDEFG"
        Dim CKey_Full, CKey_Start, CKey_End As String

        CKey_Start = Notes.Substring(2)
        CKey_End = Notes.Substring(0, 2)

        CKey_Full = CKey_Start & CKey_End

        lstExercises.Items.Add("C Major Chord = " & CKey_Full)
        lstExercises.Items.Add("")
    End Sub

    Private Sub btnVocalist_Click(sender As Object, e As EventArgs) Handles btnVocalist.Click
        Dim Vocalists(4) As String

        Vocalists(0) = "Beyonce(f)"
        Vocalists(1) = "David Bowie(m)"
        Vocalists(2) = "Madonna(f)"
        Vocalists(3) = "Elton John(m)"
        Vocalists(4) = "Charles Aznavour(m)"

        Dim Male_Vocalists As Integer = 0
        Dim Female_Vocalists As Integer = 0

        For i = 0 To Vocalists.Length - 1
            If InStr(Vocalists(i), "m") > 0 Then
                Male_Vocalists = Male_Vocalists + 1
            End If

            If InStr(Vocalists(i), "f") > 0 Then
                Female_Vocalists = Female_Vocalists + 1
            End If
        Next

        lstExercises.Items.Add("Male Vocalists = " & Male_Vocalists)
        lstExercises.Items.Add("")
        lstExercises.Items.Add("Female Vocalists = " & Female_Vocalists)
        lstExercises.Items.Add("")
    End Sub

    Private Sub btnVowel_Click(sender As Object, e As EventArgs) Handles btnVowel.Click
        Dim Instruments(3) As String
        Dim Vowel(4) As String

        Instruments(0) = "Cello"
        Instruments(1) = "Guitar"
        Instruments(2) = "Violin"
        Instruments(3) = "Double Bass"

        Vowel(0) = "a"
        Vowel(1) = "e"
        Vowel(2) = "i"
        Vowel(3) = "o"
        Vowel(4) = "u"

        Dim Instrument As String
        Dim count1 As Integer = 0
        Dim count2 As Integer = 0

        For count1 = 0 To Instruments.Length - 1
            Instrument = Instruments(count1)

            For count2 = 0 To Vowel.Length - 1
                Instrument = Instrument.Replace(Vowel(count2), "")
            Next

            lstExercises.Items.Add(Instrument)
        Next

        lstExercises.Items.Add("")
    End Sub

    Private Sub btnConsecutive_Click(sender As Object, e As EventArgs) Handles btnConsecutive.Click
        Dim numbers1 As String = "10-9-8-7-6"
        Dim numbers2 As String = "1-2-3-4-5"
        Dim array_numbers() As String

        array_numbers = numbers1.Split("-")

        Dim i As Integer
        Dim counter As Integer = 0

        For i = 0 To array_numbers.Length - 2

            Dim first_num = Integer.Parse(array_numbers(i))
            Dim second_num = Integer.Parse(array_numbers(i + 1))

            If first_num > second_num Then

                If first_num - second_num = 1 Then
                    counter = counter + 1
                End If
            Else
                If second_num - first_num = 1 Then
                    counter = counter + 1
                End If
            End If
        Next

        If counter = 4 Then
            lstExercises.Items.Add("Consecutive Numbers")
        Else
            lstExercises.Items.Add("Non-Consecutive Numbers")
        End If

        lstExercises.Items.Add("")
    End Sub

    Private Sub btnManU_Click(sender As Object, e As EventArgs) Handles btnManU.Click
        Dim results As String = "Manchester United 1 Chelsea 0, Arsenal 1 Manchester United 1, Manchester United 3 Fulham 1, Liverpool 2 Manchester United 1, Swansea 2 Manchester United 4"
        Dim results_array() As String = results.Split(",")

        Dim number_of_wins As Integer = 0
        Dim number_of_draws As Integer = 0
        Dim number_of_defeats As Integer = 0
        Dim number_of_points As Integer = 0

        Dim goals_scored As Integer = 0
        Dim goals_conceded As Integer = 0

        For i = 0 To results_array.Length - 1
            Dim the_result As String = getResults(results_array(i).Trim())
            Dim match_facts() As String = the_result.Split("-")

            If match_facts(0) = "0" Then
                number_of_defeats = number_of_defeats + 1
            End If

            If match_facts(0) = "1" Then
                number_of_draws = number_of_draws + 1
                number_of_points = number_of_points + 1
            End If

            If match_facts(0) = "3" Then
                number_of_wins = number_of_wins + 1
                number_of_points = number_of_points + 3
            End If

            If match_facts(0) = "-1" Then
                lstExercises.Items.Add("Undetermined!")
            End If

            goals_scored = goals_scored + Integer.Parse(match_facts(1))
            goals_conceded = goals_conceded + Integer.Parse(match_facts(2))
        Next

        lstExercises.Items.Add("Number of Wins = " & number_of_wins.ToString())
        lstExercises.Items.Add("Draws = " & number_of_draws.ToString())
        lstExercises.Items.Add("Defeats = " & number_of_defeats.ToString())

        lstExercises.Items.Add("Goals Scored = " & goals_scored.ToString())
        lstExercises.Items.Add("Goals Conceded = " & goals_conceded.ToString())

        lstExercises.Items.Add("Points = " & number_of_points.ToString())

        lstExercises.Items.Add("")
    End Sub

    Private Function getResults(ByRef result As String) As String
        Dim result_array() As String = result.Split(" ")
        Dim first_score As Integer = 0
        Dim second_score As Integer = 0
        Dim counter As Integer = 0

        For i = 0 To result_array.Length - 1
            If IsNumeric(result_array(i)) Then
                If counter = 0 Then
                    first_score = Integer.Parse(result_array(i))
                    counter = counter + 1
                Else
                    second_score = Integer.Parse(result_array(i))
                End If
            End If
        Next

        Dim Home_Win As String = "3"
        Dim Away_Win As String = "3"
        Dim Draw As String = "1"
        Dim Loss As String = "0"

        Dim point_and_goals As String = ""
        Dim man_utd As Integer = InStr(result, "Manchester United")

        If man_utd = 1 Then
            If first_score > second_score Then
                point_and_goals = Home_Win & "-" & first_score.ToString() & "-" & second_score.ToString()
            ElseIf second_score > first_score Then
                point_and_goals = Loss & "-" & first_score.ToString() & "-" & second_score.ToString()
            ElseIf first_score = second_score Then
                point_and_goals = Draw & "-" & first_score.ToString() & "-" & second_score.ToString()
            End If
        ElseIf man_utd > 0 Then
            If second_score > first_score Then
                point_and_goals = Away_Win & "-" & second_score.ToString() & "-" & first_score.ToString()
            ElseIf first_score > second_score Then
                point_and_goals = Loss & "-" & second_score.ToString() & "-" & first_score.ToString()
            ElseIf first_score = second_score Then
                point_and_goals = Draw & "-" & second_score.ToString() & "-" & first_score.ToString()
            End If
        ElseIf man_utd = 0 Then
            point_and_goals = "-1"
        End If

        getResults = point_and_goals
    End Function
End Class
