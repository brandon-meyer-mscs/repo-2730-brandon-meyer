Public Class Form1
    Private Sub btnCalcIfThen_Click(sender As Object, e As EventArgs) Handles btnCalcIfThen.Click
        lblComm.Text = String.Empty
        lblAdd.Text = String.Empty
        lblTotalComm.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblComm As Double = 0.0
        Dim dblAdd As Double = 0.0
        Dim dblTotalComm As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid Input", "Number Format Error", MessageBoxButtons.OK)
        End If

        If boolSalesOK AndAlso dblSales < 1.0 Then
            dblComm = 0.0
        End If

        If boolSalesOK AndAlso dblSales >= 1.0 AndAlso dblSales < 6000.0 Then
            dblComm = dblSales * 0.1
        End If

        If boolSalesOK AndAlso dblSales >= 6000.0 AndAlso dblSales < 30000.0 Then
            dblComm = 120.0 + (dblSales - 6000) * 0.13
        End If

        If boolSalesOK AndAlso dblSales >= 30000.0 Then
            dblComm = 3120.0 + (dblSales - 30000.0) * 0.14
        End If

        If chkMoreThan10.Checked Then
            dblAdd = dblAdd + 500
        End If

        If chkTravel.Checked Then
            dblAdd = dblAdd + 700
        End If

        dblTotalComm = dblComm + dblAdd

        If boolSalesOK Then
            lblComm.Text = dblComm.ToString("c2")
            lblAdd.Text = dblAdd.ToString("c2")
            lblTotalComm.Text = dblTotalComm.ToString("c2")
        End If

        txtSales.Focus()
    End Sub

    Private Sub txtSales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSales.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
               e.KeyChar <> ControlChars.Back AndAlso
               e.KeyChar <> "." Then
            'cancel the key
            e.Handled = True
        End If
    End Sub

    Private Sub btnCalcNestedIf_Click(sender As Object, e As EventArgs) Handles btnCalcNestedIf.Click
        lblComm.Text = String.Empty
        lblAdd.Text = String.Empty
        lblTotalComm.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblComm As Double = 0.0
        Dim dblAdd As Double = 0.0
        Dim dblTotalComm As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid Input", "Number Format Error", MessageBoxButtons.OK)
        End If

        If boolSalesOK AndAlso dblSales >= 30000.0 Then
            dblComm = 3120.0 + (dblSales - 30000.0) * 0.14
        Else
            If dblSales >= 6000.0 Then
                dblComm = 120.0 + (dblSales - 6000.0) * 0.13
            Else
                If dblSales >= 1.0 Then
                    dblComm = dblSales * 0.1
                Else
                    dblComm = 0.0
                End If
            End If
        End If


        If chkMoreThan10.Checked Then
            dblAdd = dblAdd + 500
        End If

        If chkTravel.Checked Then
            dblAdd = dblAdd + 700
        End If

        dblTotalComm = dblComm + dblAdd

        lblComm.Text = dblComm.ToString("c2")
        lblAdd.Text = dblAdd.ToString("c2")
        lblTotalComm.Text = dblTotalComm.ToString("c2")


            txtSales.Focus()
    End Sub

    Private Sub btnCalcIfElseIf_Click(sender As Object, e As EventArgs) Handles btnCalcIfElseIf.Click
        lblComm.Text = String.Empty
        lblAdd.Text = String.Empty
        lblTotalComm.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblComm As Double = 0.0
        Dim dblAdd As Double = 0.0
        Dim dblTotalComm As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid Input", "Number Format Error", MessageBoxButtons.OK)
        End If

        If boolSalesOK AndAlso dblSales < 1.0 Then
            dblComm = 0.0
        ElseIf boolSalesOK AndAlso dblSales >= 1.0 AndAlso dblSales < 6000.0 Then
            dblComm = dblSales * 0.1
        ElseIf boolSalesOK AndAlso dblSales >= 6000.0 AndAlso dblSales < 30000.0 Then
            dblComm = 120.0 + (dblSales - 6000.0) * 0.13
        ElseIf boolSalesOK AndAlso dblSales >= 30000.0 Then
            dblComm = 120.0 + (dblSales - 30000.0) * 0.14
        End If

        If chkMoreThan10.Checked Then
            dblAdd = dblAdd + 500
        End If

        If chkTravel.Checked Then
            dblAdd = dblAdd + 700
        End If

        dblTotalComm = dblComm + dblAdd

        If boolSalesOK Then
            lblComm.Text = dblComm.ToString("c2")
            lblAdd.Text = dblAdd.ToString("c2")
            lblTotalComm.Text = dblTotalComm.ToString("c2")
        End If

        txtSales.Focus()
    End Sub

    Private Sub btnCalcSelectCase_Click(sender As Object, e As EventArgs) Handles btnCalcSelectCase.Click
        lblComm.Text = String.Empty
        lblAdd.Text = String.Empty
        lblTotalComm.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblComm As Double = 0.0
        Dim dblAdd As Double = 0.0
        Dim dblTotalComm As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid Input", "Number Format Error", MessageBoxButtons.OK)
        End If

        Select Case dblSales
            Case 0 To 1
                dblComm = 0.0
        End Select

        Select Case dblSales
            Case 1.0 To 6000.0
                dblComm = dblSales * 0.1
        End Select

        Select Case dblSales
            Case 6000.0 To 30000.0
                dblComm = 120.0 + (dblSales - 6000.0) * 0.13
        End Select

        Select Case dblSales
            Case > 30000.0
                dblComm = 3120.0 + (dblSales - 30000.0) * 0.14
        End Select


        If chkMoreThan10.Checked Then
            dblAdd = dblAdd + 500
        End If

        If chkTravel.Checked Then
            dblAdd = dblAdd + 700
        End If

        dblTotalComm = dblComm + dblAdd

        lblComm.Text = dblComm.ToString("c2")
        lblAdd.Text = dblAdd.ToString("c2")
        lblTotalComm.Text = dblTotalComm.ToString("c2")

        txtSales.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearCommission(sender As Object, e As EventArgs) Handles txtSales.TextChanged, chkMoreThan10.CheckedChanged, chkTravel.CheckedChanged
        lblComm.Text = String.Empty
        lblAdd.Text = String.Empty
        lblTotalComm.Text = String.Empty
    End Sub
End Class
