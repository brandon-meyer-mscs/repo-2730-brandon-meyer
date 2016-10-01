'Name: Cranston Berries Project
'Purpose: Calculates Projected Sales
'Programmer: Brandon Meyer on 9/28/16

Option Strict On
Option Explicit On
Option Infer Off


Public Class frmMain
    Private decTotal As Decimal
    Private decTotal2 As Decimal
    Private decTotal3 As Decimal
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'calculate projected sales
        Dim decStraw As Decimal = 0.0D
        Dim decBlue As Decimal = 0.0D
        Dim decRasp As Decimal = 0.0D
        Decimal.TryParse(txtStraw.Text, decStraw)
        Decimal.TryParse(txtBlue.Text, decBlue)
        Decimal.TryParse(txtRasp.Text, decRasp)
        decTotal = CDec((decStraw * 0.05) + decStraw)
        decTotal2 = CDec((decBlue * 0.05) + decBlue)
        decTotal3 = CDec((decRasp * 0.05) + decRasp)

        lblProjStraw.Text = Convert.ToString(decTotal)
        lblProjBlue.Text = Convert.ToString(decTotal2)
        lblProjRasp.Text = Convert.ToString(decTotal3)

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

    Private Sub btnRetire_Click(sender As Object, e As EventArgs) Handles btnRetire.Click
        frmRetirement.Show()
    End Sub
End Class
