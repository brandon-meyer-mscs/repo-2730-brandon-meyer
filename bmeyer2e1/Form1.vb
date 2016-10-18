Option Strict On
Option Explicit On
Option Infer Off

Public Class frmMain
    Private Sub btnCalcAnd_Click(sender As Object, e As EventArgs) Handles btnCalcAnd.Click
        Dim dblOrder As Double
        Dim strYN As String
        Dim dblCharge As Double
        strYN = txtYN.Text.ToUpper

        Double.TryParse(txtOrder.Text, dblOrder)
        If dblOrder >= 100 AndAlso strYN = "Y" Then
            Double.TryParse(lblCharge.Text, dblCharge)
            dblCharge = 0
        Else
            dblCharge = 9
        End If
        lblCharge.Text = dblCharge.ToString("c2")
    End Sub

    Private Sub btnCalcOr_Click(sender As Object, e As EventArgs) Handles btnCalcOr.Click
        Dim dblOrder As Double
        Dim strYN As String
        Dim dblCharge As Double
        strYN = txtYN.Text.ToUpper

        Double.TryParse(txtOrder.Text, dblOrder)
        If dblOrder < 100 OrElse strYN <> "Y" Then
            Double.TryParse(lblCharge.Text, dblCharge)
            dblCharge = 9
        Else
            dblCharge = 0
        End If
        lblCharge.Text = dblCharge.ToString("c2")
    End Sub

    Private Sub calcEq_Click(sender As Object, e As EventArgs) Handles calcEq.Click
        Dim strID As String
        Dim dblSales As Double
        Dim dblCommission As Double
        strID = txtID.Text.ToUpper

        'calculate 15% or 12%

        Double.TryParse(txtSales.Text, dblSales)

        If (strID = "A1" And dblSales >= 25000) Or (strID = "B2" And dblSales >= 25000) Or
            (strID = "C3" And dblSales >= 25000) Then
            Double.TryParse(lblCommission.Text, dblCommission)
            dblCommission = dblSales * 0.15
        Else
            dblCommission = dblSales * 0.12
        End If
        lblCommission.Text = dblCommission.ToString("c2")
    End Sub

    Private Sub btnCalcNEq_Click(sender As Object, e As EventArgs) Handles btnCalcNEq.Click
        Dim strID As String
        Dim dblSales As Double
        Dim dblCommission As Double
        strID = txtID.Text.ToUpper

        'calculate 12% or 15%

        Double.TryParse(txtSales.Text, dblSales)

        If (strID <> "A1" Or dblSales < 25000) And (strID <> "B2" Or dblSales < 25000) And
            (strID <> "C3" Or dblSales < 25000) Then
            Double.TryParse(lblCommission.Text, dblCommission)
            dblCommission = dblSales * 0.12
        Else
            dblCommission = dblSales * 0.15
        End If
        lblCommission.Text = dblCommission.ToString("c2")
    End Sub
End Class
