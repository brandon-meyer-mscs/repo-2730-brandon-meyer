Public Class mainFrm1
    Private Sub pretestDoWhile_Click(sender As Object, e As EventArgs) Handles pretestDoWhile.Click
        lblEven.Text = "Pretest Do While" & ControlChars.NewLine
        Dim i As Integer = 2
        Do While i <= 20
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop

    End Sub

    Private Sub pretestDoUntil_Click(sender As Object, e As EventArgs) Handles pretestDoUntil.Click
        lblEven.Text = "Pretest Do Until" & ControlChars.NewLine
        Dim i As Integer = 2
        Do Until i > 20
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop
    End Sub

    Private Sub posttestLoopWhile_Click(sender As Object, e As EventArgs) Handles posttestLoopWhile.Click
        lblEven.Text = "Posttest Loop While" & ControlChars.NewLine
        Dim i As Integer = 2
        Do
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop While i <= 20
    End Sub

    Private Sub posttestLoopUntil_Click(sender As Object, e As EventArgs) Handles posttestLoopUntil.Click
        lblEven.Text = "Posttest Loop Until" & ControlChars.NewLine
        Dim i As Integer = 2
        Do
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop Until i > 20
    End Sub

    Private Sub posttestFor_Click(sender As Object, e As EventArgs) Handles posttestFor.Click
        lblEven.Text = "For Loop" & ControlChars.NewLine
        For i As Integer = 2 To 20 Step 0
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Next i
    End Sub

    Private Sub btnSumDoWhile_Click(sender As Object, e As EventArgs) Handles btnSumDoWhile.Click
        'Clear Fields
        txtList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        'Calculate Average

        Const strPROMPT As String =
            ControlChars.NewLine &
            "Click Cancel or leave blank to end."
        Const strTITLE As String = "Number Entry"

        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Int32
        Dim intCount As Integer
        Dim dblAvg As Double

        'Get First Sales Amount

        '        strNum = InputBox(strPROMPT, strTITLE, "0")
        strNum = InputBox("Enter Value 1 " & strPROMPT, strTITLE)





        '***Begin Loop: Repeat as long as input not empty
        Do While strNum <> ""

            'Convert the input to a number
            Int32.TryParse(strNum, intNum)


            'Display the input in the text box

            txtList.Text = txtList.Text & intNum.ToString & ControlChars.NewLine

            'Update Counter and Accumulator

            intCount = intCount + 1
            intSum = intSum + intNum

            '*Update Control Variable
            'strNum = InputBox(strPROMPT, strTITLE, "0")
            strNum = InputBox("Enter Value " & (intCount + 1).ToString() & strPROMPT, strTITLE)

            '*End Loop Here
        Loop

        lblCount.Text = intCount.ToString
        'Verify Counter is Greater than 0

        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")
        Else
            lblAvg.Text = "N/A"
        End If

    End Sub

    Private Sub btnSumLoopUntil_Click(sender As Object, e As EventArgs) Handles btnSumLoopUntil.Click
        'Clear Fields
        txtList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        'Calculate Average

        Const strPROMPT As String =
            ControlChars.NewLine &
            "Click Cancel or leave blank to end."
        Const strTITLE As String = "Number Entry"

        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Int32
        Dim intCount As Integer
        Dim dblAvg As Double

        'Get First Sales Amount

        strNum = InputBox("Enter Value 1 " & strPROMPT, strTITLE)

        '***Begin Loop: Repeat as long as input not empty
        Do

            'Convert the input to a number
            Int32.TryParse(strNum, intNum)


            'Display the input in the text box

            txtList.Text = txtList.Text & intNum.ToString() & ControlChars.NewLine

            'Update Counter and Accumulator

            intCount = intCount + 1
            intSum = intSum + intNum

            '*Update Control Variable
            strNum = InputBox("Enter Value " & (intCount + 1).ToString() & strPROMPT, strTITLE)

            '*End Loop Here
        Loop Until strNum = ""

        lblCount.Text = intCount.ToString
        'Verify Counter is Greater than 0

        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")
        Else
            lblAvg.Text = "N/A"
        End If
    End Sub

    Private Sub btnSumForNext_Click(sender As Object, e As EventArgs) Handles btnSumForNext.Click
        'Clear Fields
        txtList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        'Calculate Average

        Const strPROMPT As String =
            "Enter quantity of numbers. "

        Const strTITLE As String = "Quantity"

        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Int32
        Dim intCount As Integer
        Dim dblAvg As Double
        Dim intLoopNum As Integer


        'Get First Sales Amount

        strNum = InputBox(strPROMPT, strTITLE, "0")
        Int32.TryParse(strNum, intNum)

        '***Begin Loop: Repeat as long as input not empty
        For intLoopNum = 1 To intNum

            strNum = InputBox("Enter value " & intLoopNum.ToString(), "Value Entry", "0")


            'Convert the input to a number
            Int32.TryParse(strNum, intNum)


            'Display the input in the text box

            txtList.Text = txtList.Text & intNum.ToString & ControlChars.NewLine

            'Update Counter and Accumulator

            intCount = intCount + 1
            intSum = intSum + intNum

            '*End Loop Here
        Next

        lblCount.Text = intCount.ToString
        'Verify Counter is Greater than 0

        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")
        Else
            lblAvg.Text = "N/A"
        End If
    End Sub
End Class
