'Name:          Average Project
'Purpose:       Displays the average of 3 test scores
'Programmer:    Brandon Meyer on 9/14/16

Option Strict On

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Calculate average of the test scores
        lblavgscr.Text = Format(((Val(txtscr1.Text) + Val(txtscr2.Text) + Val(txtscr3.Text)) / 3), "fixed")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear application for next calculation
        txtscr1.Text = String.Empty
        txtscr2.Text = String.Empty
        txtscr3.Text = String.Empty
        lblavgscr.Text = String.Empty

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close application
        Me.Close()

    End Sub
End Class
