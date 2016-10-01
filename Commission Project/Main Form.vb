' Name:         Commission Project
' Purpose:      Displays a salesperson's commission
' Programmer:   <your name> on <current date>

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRate8_Click(sender As Object, e As EventArgs) Handles btnRate8.Click
        'calculates and displays an 8% commission

        'the Dim statements declare two procedure-level
        'variables that can be used only within the
        'btnRate8_Click procedure
        Dim dblSales As Double
        Dim dblComm8 As Double

        'the TryParse method converts the contents of the 
        'txtSales control to Double and then stores the
        'result in the procedure-level dblSales variable
        Double.TryParse(txtSales.Text, dblSales)

        'the assignment statement multiplies the value
        'stored in the procedure-level dblSales variable
        'by the Double number 0.08 and then assigns the
        'result to the procedure-level dblComm8 variable
        dblComm8 = dblSales * 0.08

        'the Convert method converts thevalue stored in
        'the procedure-level dblComm8 variable to String,
        'and the assignment statement assigns the result
        'to the lblComm control's Text property
        lblComm.Text = Convert.ToString(dblComm8)
    End Sub

    Private Sub btnRate10_Click(sender As Object, e As EventArgs) Handles btnRate10.Click
        'calculates and displays a 10% commission

        'the Dim statements declare two procedure-level
        'variables that can be used only within the
        'btnRate10_Click procedure
        Dim dblSales As Double
        Dim dblComm10 As Double

        'the TryParse method converts the contents of the
        'txtSales control to Double and then stores the
        'result in the procedure-level dblSales variable
        Double.TryParse(txtSales.Text, dblSales)

        'the assignment statement multiplies the value
        'stored in the procedure-level dblSales variable
        'by the Double number 0.1 and then assigns the
        'result to the procedure-level dblComm10 variable
        dblComm10 = dblSales * 0.1

        'the Convert method converts the value stored in
        'the procedure-level dblComm10 variable to String,
        'and the assignment statement assigns the result
        'to the lblComm control's Text property
        lblComm.Text = Convert.ToString(dblComm10)

    End Sub
End Class
