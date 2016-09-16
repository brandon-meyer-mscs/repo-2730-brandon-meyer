'Name:          Net Pay Project
'Purpose:       Displays the net pay and taxable amounts
'Programmer:    Brandon Meyer on 9/16/16

Option Strict On

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Calculate gross, witholdings, and net pay

        lblGP.Text = Format(Val(txtHours.Text) * Val(txtRate.Text), "fixed")
        lblFed.Text = Format(Val(lblGP.Text) * 0.2, "fixed")
        lblFICA.Text = Format(Val(lblGP.Text) * 0.08, "fixed")
        lblTax.Text = Format(Val(lblGP.Text) * 0.03, "fixed")
        lblNetPay.Text = Format(Val(lblGP.Text) - (Val(lblFed.Text) + Val(lblFICA.Text) + Val(lblTax.Text)), "fixed")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all fields for next calc

        txtName.Text = String.Empty
        txtRate.Text = String.Empty
        txtHours.Text = String.Empty
        lblGP.Text = String.Empty
        lblFed.Text = String.Empty
        lblFICA.Text = String.Empty
        lblTax.Text = String.Empty
        lblNetPay.Text = String.Empty

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close application

        Me.Close()

    End Sub
End Class
