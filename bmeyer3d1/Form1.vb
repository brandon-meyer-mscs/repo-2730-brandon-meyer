'Name: Exercise 3D: Array subscripts, totals, avg, min
'Purpose: Display the average number sold
'Programmer: Brandon Meyer on 12/4/16

Option Strict On
Option Explicit On
Option Infer Off



Public Class Form1
    Private intSold() As Integer = {250, 225, 193, 260}
    Private dblWholeSale() As Double = {17.5, 9, 10.5, 18.75, 26, 8.5, 5.65, 12.25, 10, 30}

    'Declare and initialize daysInMonth array
    'If month entered by user is valid
    '   Display days in selected month
    'Otherwise
    '   Display error message
    'End If
    'Set focus to txtMonth and select all text

    Private Sub btnDisplayDays_Click(sender As Object, e As EventArgs) Handles btnDisplayDays.Click
        Dim intDaysInMonth() As Integer = {31, 28, 31, 30, 31, 30, 31, 30, 30, 31, 30, 31}
        Dim intMonths As Integer

        Integer.TryParse(txtMonth.Text, intMonths)

        Select Case intMonths
            Case 1 To 12
                lblDays.Text = Convert.ToString(intDaysInMonth(intMonths - 1))

            Case Else
                MessageBox.Show("Please Enter a Valid Month Number")
        End Select

        txtMonth.Focus()
        txtMonth.SelectAll()

    End Sub

    'Clear labels
    'Use loop to calculate total of elements in intSold array
    'Calculate and display average
    'Use same loop to find and display intSold elements < average:
    '   lblLessThanAvg.text &= intSold(intSub).toString & ", "
    'Remove extra ", " from lblLessThanAvg.text:
    '   If lblLessThanAvg.text.EndsWith(", ") Then
    '   lblLessThanAvg.text = lblLessThanAvg.text.subString(0, lblLessThanAvg.text - 2)
    'End If

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        lblAvg.Text = String.Empty
        lblLessThanAvg.Text = String.Empty


        Dim intTotal As Integer = 0
        Dim intCount As Integer
        Dim dblAvg As Double
        Dim intIndex As Integer

        intCount = intSold.Length

        For intIndex = 0 To intSold.Length - 1
            intTotal = intTotal + intSold(intIndex)
        Next intIndex

        dblAvg = intTotal / intCount

        lblAvg.Text = dblAvg.ToString

        For intIndex = 0 To intSold.Length - 1
            If intSold(intIndex) < dblAvg Then
                lblLessThanAvg.Text &= intSold(intIndex).ToString & ", "
            End If
        Next intIndex

        'Remove extra ", " from lblLessThanAvg.text:
        If lblLessThanAvg.Text.EndsWith(", ") Then
            lblLessThanAvg.Text = lblLessThanAvg.Text.Substring(0, lblLessThanAvg.Text.Length - 2)
        End If
    End Sub

    Private Sub btnForEachNext_Click(sender As Object, e As EventArgs) Handles btnForEachNext.Click
        lblAvg.Text = String.Empty
        lblLessThanAvg.Text = String.Empty


        Dim intTotal As Integer = 0
        Dim intCount As Integer
        Dim dblAvg As Double
        Dim intValue As Integer

        intCount = intSold.Length

        For Each intValue In intSold
            intTotal = intTotal + intValue
        Next intValue

        dblAvg = intTotal / intCount

        lblAvg.Text = dblAvg.ToString

        For Each intValue In intSold
            If intValue < dblAvg Then
                lblLessThanAvg.Text &= intValue.ToString & ", "
            End If
        Next intValue

        'Remove extra ", " from lblLessThanAvg.text:
        If lblLessThanAvg.Text.EndsWith(", ") Then
            lblLessThanAvg.Text = lblLessThanAvg.Text.Substring(0, lblLessThanAvg.Text.Length - 2)
        End If



    End Sub

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        lblAvg.Text = String.Empty
        lblLessThanAvg.Text = String.Empty


        Dim intTotal As Integer = 0
        Dim intCount As Integer
        Dim dblAvg As Double
        Dim intIndex As Integer

        intCount = intSold.Length

        intIndex = 0
        Do While intIndex < intCount
            intTotal = intTotal + intSold(intIndex)
            intIndex += 1
        Loop


        dblAvg = intTotal / intCount

        lblAvg.Text = dblAvg.ToString

        intIndex = 0
        Do While intIndex < intCount
            If intSold(intIndex) < dblAvg Then
                lblLessThanAvg.Text &= intSold(intIndex).ToString & ", "
            End If
            intIndex += 1
        Loop


        'Remove extra ", " from lblLessThanAvg.text:
        If lblLessThanAvg.Text.EndsWith(", ") Then
            lblLessThanAvg.Text = lblLessThanAvg.Text.Substring(0, lblLessThanAvg.Text.Length - 2)
        End If



    End Sub

    Private Sub btnRetail_Click(sender As Object, e As EventArgs) Handles btnRetail.Click

        lstRetail.Items.Clear()

        'Input box to ask for Markup Rate/percentage
        Dim inputStr As String
        Dim inputPercent As Decimal


        inputStr = InputBox("Enter markup rate", "Markup Rate", "50")

        'Increase each price in the array and display in Retail list
        Decimal.TryParse(inputStr, inputPercent)

        For intSub As Integer = 0 To dblWholeSale.GetUpperBound(0)
            dblWholeSale(intSub) *= 1 + inputPercent / 100
            lstRetail.Items.Add(dblWholeSale(intSub).ToString("n2").PadLeft(6))
        Next intSub

    End Sub

    Private Sub btnWholesale_Click(sender As Object, e As EventArgs) Handles btnWholesale.Click
        'Returns array to original wholesale prices

        For intSub As Integer = 0 To dblWholeSale.GetUpperBound(0)
            dblWholeSale(intSub) = Convert.ToDouble(lstWholeSale.Items(intSub))
        Next intSub
        lstRetail.Items.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'fill lstWholeSale with array values

        For intSub As Integer = 0 To dblWholeSale.GetUpperBound(0)
            lstWholeSale.Items.Add(dblWholeSale(intSub).ToString("n2").PadLeft(6))
        Next intSub
    End Sub
End Class
