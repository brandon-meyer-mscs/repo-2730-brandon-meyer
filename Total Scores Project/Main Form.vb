' Name:         Total Scores Project
' Purpose:      Displays the total of the scores entered by the user
' Programmer:   Brandon Meyer on 9/28/16

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    'class-level variable for accumulating the scores
    Private decTotal As Decimal

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'totals the scores entered by the user

        'procedure-level variable for getting each score
        Dim decScore As Decimal

        'total the scores and display the result
        Decimal.TryParse(txtScore.Text, decScore)
        decTotal = decTotal + decScore
        lblTotal.Text = Convert.ToString(decTotal)

        txtScore.Focus()
    End Sub
End Class
