'Name: Cranston Berries Project
'Purpose: Calculates Projected Sales
'Programmer: Brandon Meyer on 9/10/16

Option Strict On


Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'calculate projected sales
        lblProjStraw.Text = Format((Val(txtProjIncrease.Text) * Val(txtStraw.Text)) + Val(txtStraw.Text), "currency")
        lblProjBlue.Text = Format((Val(txtProjIncrease.Text) * Val(txtBlue.Text)) + Val(txtBlue.Text), "currency")
        lblProjRasp.Text = Format((Val(txtProjIncrease.Text) * Val(txtRasp.Text)) + Val(txtRasp.Text), "currency")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear form for next calculation
        txtStraw.Text = String.Empty
        txtBlue.Text = String.Empty
        txtRasp.Text = String.Empty
        lblProjStraw.Text = String.Empty
        lblProjBlue.Text = String.Empty
        lblProjRasp.Text = String.Empty
        'send the focus to the projected increase box
        txtProjIncrease.Focus()


    End Sub
End Class
