' Name:                         Property Tax
' Purpose:                      Calculates the property tax
' Programmer:                   Brandon Meyer on 9/5/16
Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'calculate the property tax

        lblTax.Text = Val(txtAssessed.Text) * 0.015
        lblTax.Text = Format(lblTax.Text, "currency")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'prepare screen for next property tax
        lblTax.Text = String.Empty
        txtAssessed.Text = String.Empty
        'send the focus to the Assessed box
        txtAssessed.Focus()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
