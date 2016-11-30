' Name:         Conversion Solution
' Purpose:      Convert a measurement to either centimeters or inches
' Programmer:   Brandon Meyer on 11/25/16

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtMeasurement_Enter(sender As Object, e As EventArgs) Handles txtMeasurement.Enter
        txtMeasurement.SelectAll()
    End Sub

    Private Sub txtMeasurement_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMeasurement.KeyPress
        ' allow only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub InputChanged(sender As Object, e As EventArgs) _
        Handles txtMeasurement.TextChanged, radSubCentimeters.CheckedChanged,
        radSubInches.CheckedChanged, radFuncCentimeters.CheckedChanged, radFuncInches.CheckedChanged

        Dim dblMeasurement As Double = 0.0
        Dim dblResult As Double = 0.0

        Double.TryParse(txtMeasurement.Text, dblMeasurement)
        'replace below with function calls
        '1: Private Sub CalcCentimetersSub
        '2: Private Sub CalcInchesSub
        '3: Private Sub CalcCentimetersFunc
        '4: Private Sub CalcInchesFunc

        If radSubCentimeters.Checked Then

            Call CalcCentimetersSub(dblMeasurement, dblResult)

        ElseIf radSubInches.Checked Then

            Call CalcInchesSub(dblMeasurement, dblResult)

        ElseIf radFuncCentimeters.Checked Then

            Call CalcCentimetersFunc(dblMeasurement, dblResult)

        ElseIf radFuncInches.Checked Then

            Call CalcInchesFunc(dblMeasurement, dblResult)
        End If

        lblResult.Text = dblResult.ToString("n2")
    End Sub

    Private Sub CalcCentimetersSub(ByVal dblMeas As Double, ByRef dblRes As Double)
        dblRes = dblMeas * 2.54
        lblResult.Text = Convert.ToString(dblRes)
    End Sub

    Private Sub CalcInchesSub(ByVal dblMeas As Double, ByRef dblRes As Double)
        dblRes = dblMeas * 0.393701
        lblResult.Text = Convert.ToString(dblRes)
    End Sub

    Private Function CalcCentimetersFunc(ByVal dblMeas As Double, ByRef dblRes As Double) As Double
        dblRes = dblMeas * 2.54
        Return dblRes
    End Function

    Private Function CalcInchesFunc(ByVal dblMeas As Double, ByRef dblRes As Double) As Double
        dblRes = dblMeas * 0.393701
        Return dblRes
    End Function

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Add planets to cboPlanets
        cboPlanets.Items.Add("Mercury")
        cboPlanets.Items.Add("Venus")
        cboPlanets.Items.Add("Earth")
        cboPlanets.Items.Add("Mars")
        cboPlanets.Items.Add("Jupiter")
        cboPlanets.Items.Add("Saturn")
        cboPlanets.Items.Add("Uranus")
        cboPlanets.Items.Add("Neptune")
        cboPlanets.Items.Add("Pluto")

        'Set selected item to Earth
        cboPlanets.SelectedItem = "Earth"


    End Sub

    Private Sub txtEarthWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEarthWeight.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
              e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Function CalcWeightFunc(ByVal intWeight As Integer) As Double
        'set dblGravity according to selected text in cboPlanets
        Dim dblGravity As Double
        Dim strPlanet As String

        strPlanet = cboPlanets.SelectedItem.ToString

        Select Case strPlanet
            Case "Mercury", "Mars"
                dblGravity = 0.38
            Case "Venus"
                dblGravity = 0.91
            Case "Earth"
                dblGravity = 1.0
            Case "Jupiter"
                dblGravity = 2.34
            Case "Saturn"
                dblGravity = 1.06
            Case "Uranus"
                dblGravity = 0.92
            Case "Neptune"
                dblGravity = 1.14
            Case "Pluto"
                dblGravity = 0.06

        End Select

        'Calculate and return weight
        CalcWeightFunc = dblGravity * intWeight

    End Function

    'Set dblGravity according to selected text in cboPlanets
    'Calculate weight
    Private Sub CalcWeightSub(ByVal intWeight As Integer, ByRef dblWeightOnPlanet As Double)

        Dim dblGravity As Double
        Dim strPlanet As String

        strPlanet = cboPlanets.SelectedItem.ToString

        Select Case strPlanet
            Case "Mercury", "Mars"
                dblGravity = 0.38
            Case "Venus"
                dblGravity = 0.91
            Case "Earth"
                dblGravity = 1.0
            Case "Jupiter"
                dblGravity = 2.34
            Case "Saturn"
                dblGravity = 1.06
            Case "Uranus"
                dblGravity = 0.92
            Case "Neptune"
                dblGravity = 1.14
            Case "Pluto"
                dblGravity = 0.06

        End Select
        dblWeightOnPlanet = dblGravity * intWeight
    End Sub

    'Parse value in txtEarthWeight

    'If user selected 'sub' radio button
    '   Use sub to calculate weight
    'ElseIf User selected "func" radio button
    '   Use function to calculate weight
    'End If
    'Display weight


    Private Sub txtEarthWeight_Enter(sender As Object, e As EventArgs) Handles txtEarthWeight.Enter
        txtEarthWeight.SelectAll()
    End Sub

    Private Sub WeightInputChanged(sender As Object, e As EventArgs) Handles txtEarthWeight.TextChanged,
            rdoPlanetSub.CheckedChanged, rdoPlanetFunc.CheckedChanged, cboPlanets.SelectedIndexChanged


        Dim intWeight As Integer = 0
        Dim dblWeightOnPlanet As Double = 0

        Integer.TryParse(txtEarthWeight.Text, intWeight)

        If rdoPlanetSub.Checked Then
            Call CalcWeightSub(intWeight, dblWeightOnPlanet)
        ElseIf rdoPlanetFunc.Checked Then
            dblWeightOnPlanet = CalcWeightFunc(intWeight)

        End If

        lblWeight.Text = dblWeightOnPlanet.ToString()
    End Sub
End Class
