Option Strict On
Option Explicit On
Option Infer Off


Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        '#03 Insert
        Dim strWord As String = txt03RemoveInsert.Text
        strWord = strWord.Remove(0, 1)
        strWord = strWord.Insert(0, "cr")
        lbl03RemoveInsert.Text = strWord

        '#04 Substring
        Dim strItem As String = txt04Substring.Text
        Dim strColor As String = lbl04Substring.Text

        strColor = strItem.Substring(2, 4)
        lbl04Substring.Text = strColor

        '#5a Length
        Dim strMsg As String = txt05Length.Text
        Dim intChars As Integer = strMsg.Length

        lbl05aLength.Text = intChars.ToString()

        '#5b Trim
        Dim strTrim As String

        strTrim = txt05bTrim.Text.Trim
        lbl05bTrim.Text = strTrim

        '#5c Insert/Remove
        Dim strRem As String = txt05cInsRem.Text

        strRem = strRem.Remove(1, 1)
        lbl05cInsertRemove.Text = strRem.Insert(1, "rit")

        '#5d Insert
        Dim strIns As String = txt05dInsert.Text

        lbl05dInsert.Text = strIns.Insert(0, "Mon")

        '#5e Padding
        Dim dblPay As Double = 765.44
        Dim strPay As String

        strPay = dblPay.ToString("N2").PadLeft(10, "*"c)
        lbl05ePad.Text = strPay

        '#6 Remove
        Dim strAmount As String = txt06Remove.Text

        strAmount = strAmount.Remove(1, 1)
        lbl06Remove.Text = strAmount.Remove(4, 1)

        '#7 Contains Method
        Dim strAddress As String
        'Dim blnIsContained As Boolean

        strAddress = txt07Contains.Text
        If strAddress.Contains("Jefferson Street") Then
            lbl07Contains.Text = "Jefferson Street Found"
        Else
            lbl07Contains.Text = "Jeff St. Not Found"
        End If

        '#12 Tax Calculation
        Dim strTaxRate As String = txtTaxRate.Text
        Dim dblTaxRate As Double
        Dim dblTax As Double = 1000.0 * dblTaxRate * 0.01

        If strTaxRate.Substring(strTaxRate.Length - 1) = "%" Then
            strTaxRate = strTaxRate.Remove(strTaxRate.Length - 1)
        End If

        'Calculate Tax

        Double.TryParse(strTaxRate, dblTaxRate)
        dblTax = 1000 * dblTaxRate * 0.01
        lblTaxRate.Text = dblTax.ToString()

        '#13 Like
        Dim strLike As String = txtLike.Text

        If strLike Like "605??" Then
            lblLike.Text = "Shipping: $25"
        ElseIf strLike Like "606??" Then
            lblLike.Text = "Shipping: $30"
        Else
            lblLike.Text = "Invalid Code"
        End If


    End Sub
End Class
