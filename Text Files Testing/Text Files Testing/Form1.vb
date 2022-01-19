Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim File_Name As String = "C:\Users\Tom Hoad\Documents\Text Files\Tom.txt"

        Dim SW As New StreamWriter(File_Name, True)

        SW.WriteLine("Hello World!")
        SW.Close()

        Dim SR As New StreamReader(File_Name)

        Do Until SR.EndOfStream
            ListBox1.Items.Add(SR.ReadLine())
        Loop

        SR.Close()
    End Sub
End Class
