' Name:         Multiplication Project
' Purpose:      Display a multiplication table that shows
'               the multiplicand, multiplier, and product
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Const dblTAXRATE As Double = 0.05

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        ' displays a multiplication table
        Dim number, product, count As Integer
        lstMultTable.Items.Clear()
        lstMultTable.Items.Add("Do Loop:")
        Integer.TryParse(txtNumber.Text, number)

        count = 0

        'Do Loop
        Do
            count = count + 1
            product = number * count
            lstMultTable.Items.Add("    " & number.ToString() & " * " & count.ToString() & " = " & product.ToString())
        Loop Until count = 9

    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        ' displays a multiplication table
        Dim number, product As Integer
        lstMultTable.Items.Clear()
        lstMultTable.Items.Add("For Loop:")
        Integer.TryParse(txtNumber.Text, number)
        'For Loop
        For count As Integer = 1 To 9
            product = number * count
            lstMultTable.Items.Add("    " & number.ToString() & " * " & count.ToString() & " = " & product.ToString())

        Next
    End Sub

    Private Sub txtNumber_Enter(sender As Object, e As EventArgs) Handles txtNumber.Enter
        txtNumber.SelectAll()
    End Sub

    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress
        ' allows only numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged
        'Clear listbox
        lstMultTable.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load ListBox with test data:
        For dblPrices As Double = 1 To 4
            lstPrices.Items.Add(dblPrices.ToString("n2"))
        Next dblPrices

        'calculate pretax total:

        Dim dblPretaxTotal As Double = 0
        Dim dblSelectedPrice As Double
        Dim strPrice As String
        Dim dblTotal As Double

        For intTax As Integer = 0 To lstPrices.Items.Count - 1
            lstPrices.SelectedIndex = intTax

            strPrice = Convert.ToString(lstPrices.SelectedItem)
            ' MessageBox.Show(intTax.ToString & " " & strPrice)
            Double.TryParse(strPrice, dblSelectedPrice)
            dblPretaxTotal = dblPretaxTotal + dblSelectedPrice


        Next intTax
        '   declare dblPretaxTotal and initialize to 0
        '   repeat for each index 0 to lstPrices.Items.Count - 1
        '       set ListBox SelectedIndex to index
        '       set strSelectedItem and to the ListBox SelectedItem
        '       convert strSelectedItem to Double and set dblSelectedPrice
        '       add dblSelectedPrice to dblPretaxTotal
        '   next index
        lblPreTaxTotal.Text = dblPretaxTotal.ToString("c2")
        lblTax.Text = (dblTAXRATE * dblPretaxTotal).ToString("c2")

        dblTotal = (dblTAXRATE * dblPretaxTotal) + dblPretaxTotal
        lblTotal.Text = dblTotal.ToString("c2")
        lstPrices.SelectedIndex = -1
        '   display dblPretaxTotal
        '   calculate and display dblTax
        '   calculate and display dblTotal
        '   deselect listBox items
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strPrice As String
        Dim dblPrice As Double

        ' get strPrice using InputBox
        strPrice = InputBox("Enter Value Between 1 and 9.99", "Price Entry")

        ' convert strPrice to Double: dblPrice
        Double.TryParse(strPrice, dblPrice)

        ' repeat as long as price is invalid: outside of range 1 to 9.99
        Do Until dblPrice >= 1 And dblPrice <= 9.99
            '   get strPrice using InputBox
            strPrice = InputBox("Enter Value Between 1 and 9.99", "Invalid Entry")

            '   convert strPrice to Double: dblPrice
            Double.TryParse(strPrice, dblPrice)
        Loop
        ' end repeat

        ' add dblPrice to ListBox
        lstPrices.Items.Add(dblPrice.ToString("n2"))

        ' calculate and display totals
        Dim dblPretaxTotal As Double = 0
        Dim dblSelectedPrice As Double

        Dim dblTotal As Double

        For intTax As Integer = 0 To lstPrices.Items.Count - 1
            lstPrices.SelectedIndex = intTax

            strPrice = Convert.ToString(lstPrices.SelectedItem)
            ' MessageBox.Show(intTax.ToString & " " & strPrice)
            Double.TryParse(strPrice, dblSelectedPrice)
            dblPretaxTotal = dblPretaxTotal + dblSelectedPrice


        Next intTax
        '   declare dblPretaxTotal and initialize to 0
        '   repeat for each index 0 to lstPrices.Items.Count - 1
        '       set ListBox SelectedIndex to index
        '       set strSelectedItem and to the ListBox SelectedItem
        '       convert strSelectedItem to Double and set dblSelectedPrice
        '       add dblSelectedPrice to dblPretaxTotal
        '   next index
        lblPreTaxTotal.Text = dblPretaxTotal.ToString("c2")
        lblTax.Text = (dblTAXRATE * dblPretaxTotal).ToString("c2")

        dblTotal = (dblTAXRATE * dblPretaxTotal) + dblPretaxTotal
        lblTotal.Text = dblTotal.ToString("c2")
        lstPrices.SelectedIndex = -1

    End Sub

    Private Sub lstPrices_KeyDown(sender As Object, e As KeyEventArgs) Handles lstPrices.KeyDown
        Dim intItem As Integer
        Dim strPrice As String

        'if an item is selected and the user pressed 'Del' or 'Back'
        intItem = lstPrices.SelectedIndex
        If (intItem <> -1) AndAlso (e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back) Then
            '   remove the ListBox item at the selected index
            lstPrices.Items.RemoveAt(intItem)

            '   calculate and display totals
            Dim dblPretaxTotal As Double = 0
            Dim dblSelectedPrice As Double

            Dim dblTotal As Double

            For intTax As Integer = 0 To lstPrices.Items.Count - 1
                lstPrices.SelectedIndex = intTax

                strPrice = Convert.ToString(lstPrices.SelectedItem)
                ' MessageBox.Show(intTax.ToString & " " & strPrice)
                Double.TryParse(strPrice, dblSelectedPrice)
                dblPretaxTotal = dblPretaxTotal + dblSelectedPrice


            Next intTax
            '   declare dblPretaxTotal and initialize to 0
            '   repeat for each index 0 to lstPrices.Items.Count - 1
            '       set ListBox SelectedIndex to index
            '       set strSelectedItem and to the ListBox SelectedItem
            '       convert strSelectedItem to Double and set dblSelectedPrice
            '       add dblSelectedPrice to dblPretaxTotal
            '   next index
            lblPreTaxTotal.Text = dblPretaxTotal.ToString("c2")
            lblTax.Text = (dblTAXRATE * dblPretaxTotal).ToString("c2")

            dblTotal = (dblTAXRATE * dblPretaxTotal) + dblPretaxTotal
            lblTotal.Text = dblTotal.ToString("c2")
            lstPrices.SelectedIndex = -1
        End If

        ' end if
    End Sub
End Class
