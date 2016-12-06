Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strGames() As String = {"Pong", "Pacman", "Mario", "Chess"}

        For Each strG As String In strGames
            lstGames1.Items.Add(strG)
        Next strG

        Dim intHighSub As Integer = strGames.GetUpperBound(0)
        Dim intSub As Integer

        Do While intSub <= intHighSub
            lstGames2.Items.Add(strGames(intSub))
            intSub += 1
        Loop

        For intG As Integer = 0 To strGames.GetUpperBound(0)
            lstGames3.Items.Add(strGames(intG))
        Next intG
    End Sub
End Class
