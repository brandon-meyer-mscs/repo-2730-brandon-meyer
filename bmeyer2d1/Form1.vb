'Name:      Chapter 4, Lesson B, If Statements, Message Boxes
'Purpose:   Currency, Tea, Electric, Quotient
'Programmer: Brandon Meyer on 10/12/2016

Option Strict On
Option Explicit On
Option Infer Off

Public Class frmMain
    Private Sub btnEQ_Click(sender As Object, e As EventArgs) Handles btnEQ.Click
        'Convert American dollars to the Euro, British Pound, and South African Rand

        Const dblEURO_RATE As Double = 0.9
        Const dblPOUND_RATE As Double = 0.79
        Const dblRAND_RATE As Double = 13.89

        Dim dblAmDollar As Double
        Dim dblEuro As Double
        Dim dblPound As Double
        Dim dblRand As Double

        lblEuro.Text = String.Empty
        lblBP.Text = String.Empty
        lblSAR.Text = String.Empty

        If txtAmDollar.Text = String.Empty Then
            MessageBox.Show("Please enter the number of American dollars.", "Currency Converter",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Double.TryParse(txtAmDollar.Text, dblAmDollar)

            'calculate dollar amount
            dblEuro = dblAmDollar * dblEURO_RATE
            dblPound = dblAmDollar * dblPOUND_RATE
            dblRand = dblAmDollar * dblRAND_RATE

            'display totals
            lblEuro.Text = dblEuro.ToString("c2")
            lblBP.Text = dblPound.ToString("c2")
            lblSAR.Text = dblRand.ToString("c2")
        End If



    End Sub

    Private Sub btnNE_Click(sender As Object, e As EventArgs) Handles btnNE.Click
        Const dblEURO_RATE As Double = 0.9
        Const dblPOUND_RATE As Double = 0.79
        Const dblRAND_RATE As Double = 13.89

        Dim dblAmDollar As Double
        Dim dblEuro As Double
        Dim dblPound As Double
        Dim dblRand As Double

        lblEuro.Text = String.Empty
        lblBP.Text = String.Empty
        lblSAR.Text = String.Empty

        Double.TryParse(txtAmDollar.Text, dblAmDollar)
        If txtAmDollar.Text <> String.Empty Then

            'calculate dollar amount
            dblEuro = dblAmDollar * dblEURO_RATE
            dblPound = dblAmDollar * dblPOUND_RATE
            dblRand = dblAmDollar * dblRAND_RATE

            'display totals
            lblEuro.Text = dblEuro.ToString("c2")
            lblBP.Text = dblPound.ToString("c2")
            lblSAR.Text = dblRand.ToString("c2")

        Else

            MessageBox.Show("Please enter the number of American dollars.", "Currency Converter",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dblPound As Double
        Dim dblPrice As Double
        Dim dblTotal As Double
        Dim btnCalc As DialogResult
        Const strMSG As String =
            "Charge shipping fee?"

        btnCalc = MessageBox.Show(strMSG, "Shipping", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If btnCalc = DialogResult.Yes Then
            Double.TryParse(txtPound.Text, dblPound)
            Double.TryParse(txtPrice.Text, dblPrice)
            Double.TryParse(lblTotal.Text, dblTotal)
            'Calculate cost
            dblTotal = dblPound * dblPrice + 15
            'Display result
            lblTotal.Text = dblTotal.ToString("c2")
        Else
            Double.TryParse(txtPound.Text, dblPound)
            Double.TryParse(txtPrice.Text, dblPrice)
            Double.TryParse(lblTotal.Text, dblTotal)
            'Calculate cost
            dblTotal = dblPound * dblPrice
            'Display result
            lblTotal.Text = dblTotal.ToString("c2")

        End If
    End Sub

    Private Sub btnCalcE_Click(sender As Object, e As EventArgs) Handles btnCalcE.Click
        Const dblRate As Double = 0.13
        Dim dblPrev As Double
        Dim dblCurrent As Double
        Dim dblBill As Double

        Double.TryParse(txtPrev.Text, dblPrev)
        Double.TryParse(txtCurrent.Text, dblCurrent)
        If txtPrev.Text = String.Empty OrElse
                dblCurrent < dblPrev Then
            MessageBox.Show("Current amount must be greater than or equal to Previous.", "Triple County",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Calculate Bill
            dblBill = (dblCurrent - dblPrev) * dblRate
            'Display result
            lblBill.Text = dblBill.ToString("c2")

        End If



    End Sub

    Private Sub btnCalcD_Click(sender As Object, e As EventArgs) Handles btnCalcD.Click
        Dim dblNum1 As Double
        Dim dblNum2 As Double
        Dim dblQuotient As Double

        Double.TryParse(txtNum1.Text, dblNum1)
        Double.TryParse(txtNum2.Text, dblNum2)


        'Swap numbers for division
        Dim dblTemp As Double
        If dblNum1 > dblNum2 Then

            dblTemp = dblNum1
            dblNum1 = dblNum2
            dblNum2 = dblTemp
        End If

        If dblNum1 = 0 Then
            MessageBox.Show("Cannot divide by 0.", "Division by 0",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            dblQuotient = dblNum2 / dblNum1

            'Display answer
            lblQuotient.Text = dblQuotient.ToString()

        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
