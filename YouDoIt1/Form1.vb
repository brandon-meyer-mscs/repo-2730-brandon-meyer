Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim intNums() As Integer = {2, 4, 6, 8, 10, 12}

        lblLength.Text = intNums.Length.ToString
        lblUpper.Text = (intNums.GetUpperBound(0) + 1).ToString
    End Sub
End Class
