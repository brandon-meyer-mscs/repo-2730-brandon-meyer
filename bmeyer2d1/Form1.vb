'Name:      Chapter 4, Lesson B, If Statements, Message Boxes
'Purpose:   Currency, Tea, Electric, Quotient
'Programmer: Brandon Meyer on 10/12/2016

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

        lblE.Text = String.Empty
        lblPound.Text = String.Empty
        lblRand.Text = String.Empty

        If txtAmDollar.Text = String.Empty Then
            MessageBox.Show("Please enter the number of American dollars.", "Currency Converter",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else Double.TryParse(txtAmDollar.Text, dblAmDollar)
            Double.TryParse(txtEuro.Text, dblEuro)
            Double.TryParse(txtBP.Text, dblPound)
            Double.TryParse(txtSAR.Text, dblRand)
            'calculate dollar amount
            dblEuro = txtAmDollar.Text * dblEURO_RATE
            dblPound = txtAmDollar.Text * dblPOUND_RATE
            dblRand = txtAmDollar.Text * dblRAND_RATE

            'display totals
            txtEuro.Text = dblEuro.ToString("c2")
            txtBP.Text = dblPound.ToString("c2")
            txtSAR.Text = dblRand.ToString("c2")
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

        lblE.Text = String.Empty
        lblPound.Text = String.Empty
        lblRand.Text = String.Empty


        If txtAmDollar.Text <> String.Empty Then
            Double.TryParse(txtEuro.Text, dblEuro)
            Double.TryParse(txtBP.Text, dblPound)
            Double.TryParse(txtSAR.Text, dblRand)
            'calculate dollar amount
            dblEuro = txtAmDollar.Text * dblEURO_RATE
            dblPound = txtAmDollar.Text * dblPOUND_RATE
            dblRand = txtAmDollar.Text * dblRAND_RATE

            'display totals
            txtEuro.Text = dblEuro.ToString("c2")
            txtBP.Text = dblPound.ToString("c2")
            txtSAR.Text = dblRand.ToString("c2")
        Else Double.TryParse(txtAmDollar.Text, dblAmDollar)
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
            Double.TryParse(txtTotal.Text, dblTotal)
            'Calculate cost
            dblTotal = txtPound.Text * txtPrice.Text + 15
            'Display result
            txtTotal.Text = dblTotal.ToString("c2")
        Else
            Double.TryParse(txtPound.Text, dblPound)
            Double.TryParse(txtPrice.Text, dblPrice)
            Double.TryParse(txtTotal.Text, dblTotal)
            'Calculate cost
            dblTotal = txtPound.Text * txtPrice.Text
            'Display result
            txtTotal.Text = dblTotal.ToString("c2")

        End If
    End Sub

    Private Sub btnCalcE_Click(sender As Object, e As EventArgs) Handles btnCalcE.Click
        Const dblRate As Double = 0.13
        Dim dblPrev As Double
        Dim dblCurrent As Double
        Dim dblBill As Double


        If txtPrev.Text = String.Empty Or
                txtCurrent.Text < txtPrev.Text Then
            MessageBox.Show("Current amount must be greater than or equal to Previous.", "Triple County",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Calculate Bill
            Double.TryParse(txtPrev.Text, dblPrev)
            Double.TryParse(txtCurrent.Text, dblCurrent)
            Double.TryParse(txtBill.Text, dblBill)
            dblBill = txtCurrent.Text - txtPrev.Text * dblRate
            'Display result
            txtBill.Text = dblBill.ToString("c2")

        End If



    End Sub

    Private Sub btnCalcD_Click(sender As Object, e As EventArgs) Handles btnCalcD.Click
        Dim intNum1 As Integer
        Dim intNum2 As Integer
        Dim intQuotient As Integer

        Integer.TryParse(txtNum1.Text, intNum1)
        Integer.TryParse(txtNum2.Text, intNum2)
        Integer.TryParse(txtQuotient.Text, intQuotient)
        'Swap numbers for division
        If intNum1 > intNum2 Then
            Dim intTemp As Integer
            intTemp = intNum1
            intNum1 = intNum2
            intNum2 = intTemp
            intQuotient = txtNum1.Text / txtNum2.Text
            'Display answer
            txtQuotient.Text = intQuotient.ToString()
        Else
            Dim intTemp As Integer
            intTemp = 0
            MessageBox.Show("Cannot divide by 0.", "Division by 0",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
