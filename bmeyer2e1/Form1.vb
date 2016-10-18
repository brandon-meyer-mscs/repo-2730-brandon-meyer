Public Class frmMain
    Private Sub btnCalcAnd_Click(sender As Object, e As EventArgs) Handles btnCalcAnd.Click
        Dim dblOrder As Double
        Dim strYN As String
        Dim dblCharge As Double
        strYN = txtYN.Text.ToUpper


        If txtOrder.Text >= 100 AndAlso strYN = "Y" Then
            Double.TryParse(txtOrder.Text, dblOrder)
            Double.TryParse(lblCharge.Text, dblCharge)
            dblCharge = 0
            lblCharge.Text = dblCharge.ToString("c2")
        Else
            Double.TryParse(txtOrder.Text, dblOrder)
            Double.TryParse(lblCharge.Text, dblCharge)
            dblCharge = 9
            lblCharge.Text = dblCharge.ToString("c2")
        End If
    End Sub

    Private Sub btnCalcOr_Click(sender As Object, e As EventArgs) Handles btnCalcOr.Click
        Dim dblOrder As Double
        Dim strYN As String
        Dim dblCharge As Double
        strYN = txtYN.Text.ToUpper

        If txtOrder.Text < 100 OrElse strYN <> "Y" Then
            Double.TryParse(txtOrder.Text, dblOrder)
            Double.TryParse(lblCharge.Text, dblCharge)
            dblCharge = 9
            lblCharge.Text = dblCharge.ToString("c2")
        Else
            Double.TryParse(txtOrder.Text, dblOrder)
            Double.TryParse(lblCharge.Text, dblCharge)
            dblCharge = 0
            lblCharge.Text = dblCharge.ToString("c2")
        End If
    End Sub

    Private Sub calcEq_Click(sender As Object, e As EventArgs) Handles calcEq.Click
        Dim strID As String
        Dim dblSales As Double
        Dim dblCommission As Double
        strID = txtID.Text.ToUpper
        'calculate 15% or 12%
        If (strID = "A1" And txtSales.Text >= 25000) Or (strID = "B2" And txtSales.Text >= 25000) Or
            (strID = "C3" And txtSales.Text >= 25000) Then
            Double.TryParse(txtSales.Text, dblSales)
            Double.TryParse(lblCommission.Text, dblCommission)
            dblCommission = dblSales * 0.15
            lblCommission.Text = dblCommission.ToString("c2")
        Else
            Double.TryParse(txtSales.Text, dblSales)
            Double.TryParse(lblCommission.Text, dblCommission)
            dblCommission = dblSales * 0.12
            lblCommission.Text = dblCommission.ToString("c2")
        End If
    End Sub

    Private Sub btnCalcNEq_Click(sender As Object, e As EventArgs) Handles btnCalcNEq.Click
        Dim strID As String
        Dim dblSales As Double
        Dim dblCommission As Double
        strID = txtID.Text.ToUpper
        'calculate 12% or 15%
        If (strID <> "A1" Or txtSales.Text < 25000) And (strID <> "B2" Or txtSales.Text < 25000) And
            (strID <> "C3" Or txtSales.Text < 25000) Then
            Double.TryParse(txtSales.Text, dblSales)
            Double.TryParse(lblCommission.Text, dblCommission)
            dblCommission = dblSales * 0.12
            lblCommission.Text = dblCommission.ToString("c2")
        Else
            Double.TryParse(txtSales.Text, dblSales)
            Double.TryParse(lblCommission.Text, dblCommission)
            dblCommission = dblSales * 0.15
            lblCommission.Text = dblCommission.ToString("c2")
        End If
    End Sub
End Class
