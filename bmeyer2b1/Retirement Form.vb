Option Strict On
Option Explicit On
Option Infer Off
Public Class frmRetirement
    Private decTotal As Decimal
    Private decTotal2 As Decimal
    Private decTotal3 As Decimal

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'calculate contributions

        Dim decGWP As Decimal = 0D
        Dim decECR As Decimal = 0D
        Dim decEmpCR As Decimal = 0D

        Decimal.TryParse(txtGWP.Text, decGWP)
        Decimal.TryParse(txtECR.Text, decECR)
        Decimal.TryParse(txtEmpCR.Text, decEmpCR)

        decTotal = (decGWP * 52) * decECR
        decTotal2 = (decGWP * 52) * decEmpCR
        decTotal3 = ((decGWP * 52) * decECR) + ((decGWP * 52) * decEmpCR)

        lblEAC.Text = Convert.ToString(decTotal)
        lblEmAC.Text = Convert.ToString(decTotal2)
        lblTAC.Text = Convert.ToString(decTotal3)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear form for next calculation

        txtGWP.Text = String.Empty
        txtECR.Text = String.Empty
        txtEmpCR.Text = String.Empty
        lblEAC.Text = String.Empty
        lblEmAC.Text = String.Empty
        lblTAC.Text = String.Empty
        'send focus to GWP
        txtGWP.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class