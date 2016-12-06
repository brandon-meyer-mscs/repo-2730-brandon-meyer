' Name:         Bond Project
' Purpose:      Displays the selected list box item
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the list box with array values and then selects the first item

        Dim strBond() As String = {"Goldfinger", "Moonraker",
            "Skyfall", "For Your Eyes Only"}

        Dim intHighSub As Integer = strBond.Length - 1
        Dim intSub As Integer
        Do While intSub <= intHighSub
            lstBondMovies.Items.Add(strBond(intSub))
            intSub += 1
        Loop

        lstBondMovies.SelectedIndex = 0
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lstBondMovies_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstBondMovies.SelectedValueChanged
        ' displays the selected item in a label control

        lblSelection.Text = lstBondMovies.SelectedItem.ToString
    End Sub
End Class
