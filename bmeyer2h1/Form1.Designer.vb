<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblSales = New System.Windows.Forms.Label()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.chkMoreThan10 = New System.Windows.Forms.CheckBox()
        Me.chkTravel = New System.Windows.Forms.CheckBox()
        Me.btnCalcIfThen = New System.Windows.Forms.Button()
        Me.btnCalcNestedIf = New System.Windows.Forms.Button()
        Me.btnCalcIfElseIf = New System.Windows.Forms.Button()
        Me.btnCalcSelectCase = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCommOnly = New System.Windows.Forms.Label()
        Me.lblAdditional = New System.Windows.Forms.Label()
        Me.lblComm = New System.Windows.Forms.Label()
        Me.lblTotalCommission = New System.Windows.Forms.Label()
        Me.lblTotalComm = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSales
        '
        Me.lblSales.Location = New System.Drawing.Point(23, 27)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(57, 20)
        Me.lblSales.TabIndex = 0
        Me.lblSales.Text = "Sales:"
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(26, 60)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(100, 20)
        Me.txtSales.TabIndex = 1
        '
        'chkMoreThan10
        '
        Me.chkMoreThan10.AutoSize = True
        Me.chkMoreThan10.Location = New System.Drawing.Point(26, 100)
        Me.chkMoreThan10.Name = "chkMoreThan10"
        Me.chkMoreThan10.Size = New System.Drawing.Size(77, 17)
        Me.chkMoreThan10.TabIndex = 2
        Me.chkMoreThan10.Text = "> 10 Years"
        Me.chkMoreThan10.UseVisualStyleBackColor = True
        '
        'chkTravel
        '
        Me.chkTravel.AutoSize = True
        Me.chkTravel.Location = New System.Drawing.Point(26, 134)
        Me.chkTravel.Name = "chkTravel"
        Me.chkTravel.Size = New System.Drawing.Size(72, 17)
        Me.chkTravel.TabIndex = 3
        Me.chkTravel.Text = "Travelling"
        Me.chkTravel.UseVisualStyleBackColor = True
        '
        'btnCalcIfThen
        '
        Me.btnCalcIfThen.Location = New System.Drawing.Point(162, 27)
        Me.btnCalcIfThen.Name = "btnCalcIfThen"
        Me.btnCalcIfThen.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcIfThen.TabIndex = 4
        Me.btnCalcIfThen.Text = "If Then"
        Me.btnCalcIfThen.UseVisualStyleBackColor = True
        '
        'btnCalcNestedIf
        '
        Me.btnCalcNestedIf.Location = New System.Drawing.Point(162, 72)
        Me.btnCalcNestedIf.Name = "btnCalcNestedIf"
        Me.btnCalcNestedIf.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcNestedIf.TabIndex = 5
        Me.btnCalcNestedIf.Text = "Nested If"
        Me.btnCalcNestedIf.UseVisualStyleBackColor = True
        '
        'btnCalcIfElseIf
        '
        Me.btnCalcIfElseIf.Location = New System.Drawing.Point(162, 119)
        Me.btnCalcIfElseIf.Name = "btnCalcIfElseIf"
        Me.btnCalcIfElseIf.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcIfElseIf.TabIndex = 6
        Me.btnCalcIfElseIf.Text = "If Else If"
        Me.btnCalcIfElseIf.UseVisualStyleBackColor = True
        '
        'btnCalcSelectCase
        '
        Me.btnCalcSelectCase.Location = New System.Drawing.Point(162, 165)
        Me.btnCalcSelectCase.Name = "btnCalcSelectCase"
        Me.btnCalcSelectCase.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcSelectCase.TabIndex = 7
        Me.btnCalcSelectCase.Text = "Select Case"
        Me.btnCalcSelectCase.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(162, 204)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblCommOnly
        '
        Me.lblCommOnly.AutoSize = True
        Me.lblCommOnly.Location = New System.Drawing.Point(23, 170)
        Me.lblCommOnly.Name = "lblCommOnly"
        Me.lblCommOnly.Size = New System.Drawing.Size(89, 13)
        Me.lblCommOnly.TabIndex = 9
        Me.lblCommOnly.Text = "Commission Only:"
        '
        'lblAdditional
        '
        Me.lblAdditional.AutoSize = True
        Me.lblAdditional.Location = New System.Drawing.Point(24, 244)
        Me.lblAdditional.Name = "lblAdditional"
        Me.lblAdditional.Size = New System.Drawing.Size(56, 13)
        Me.lblAdditional.TabIndex = 11
        Me.lblAdditional.Text = "Additional:"
        '
        'lblComm
        '
        Me.lblComm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblComm.Location = New System.Drawing.Point(23, 204)
        Me.lblComm.Name = "lblComm"
        Me.lblComm.Size = New System.Drawing.Size(100, 23)
        Me.lblComm.TabIndex = 12
        '
        'lblTotalCommission
        '
        Me.lblTotalCommission.AutoSize = True
        Me.lblTotalCommission.Location = New System.Drawing.Point(24, 275)
        Me.lblTotalCommission.Name = "lblTotalCommission"
        Me.lblTotalCommission.Size = New System.Drawing.Size(92, 13)
        Me.lblTotalCommission.TabIndex = 13
        Me.lblTotalCommission.Text = "Total Commission:"
        '
        'lblTotalComm
        '
        Me.lblTotalComm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalComm.Location = New System.Drawing.Point(24, 304)
        Me.lblTotalComm.Name = "lblTotalComm"
        Me.lblTotalComm.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalComm.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(279, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 300)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Commission Calculators"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(123, 239)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "$700"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(123, 205)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "$500"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(23, 239)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Travelling"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 202)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "> 10 years"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 169)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Additional Amounts:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(117, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "$3,120 + 14% > 30,000"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(117, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "$120 + 13% of sales > 6000"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(117, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "10% of sales"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "> 30,000"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "6,000 - 29,999.99"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "1 - 5,999.99"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(120, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Commission"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales ($)"
        '
        'lblAdd
        '
        Me.lblAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdd.Location = New System.Drawing.Point(86, 243)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(100, 23)
        Me.lblAdd.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 350)
        Me.Controls.Add(Me.lblAdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTotalComm)
        Me.Controls.Add(Me.lblTotalCommission)
        Me.Controls.Add(Me.lblComm)
        Me.Controls.Add(Me.lblAdditional)
        Me.Controls.Add(Me.lblCommOnly)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalcSelectCase)
        Me.Controls.Add(Me.btnCalcIfElseIf)
        Me.Controls.Add(Me.btnCalcNestedIf)
        Me.Controls.Add(Me.btnCalcIfThen)
        Me.Controls.Add(Me.chkTravel)
        Me.Controls.Add(Me.chkMoreThan10)
        Me.Controls.Add(Me.txtSales)
        Me.Controls.Add(Me.lblSales)
        Me.Name = "Form1"
        Me.Text = "bmeyer2h1 Marshall Sales Commission"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSales As Label
    Friend WithEvents txtSales As TextBox
    Friend WithEvents chkMoreThan10 As CheckBox
    Friend WithEvents chkTravel As CheckBox
    Friend WithEvents btnCalcIfThen As Button
    Friend WithEvents btnCalcNestedIf As Button
    Friend WithEvents btnCalcIfElseIf As Button
    Friend WithEvents btnCalcSelectCase As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblCommOnly As Label
    Friend WithEvents lblAdditional As Label
    Friend WithEvents lblComm As Label
    Friend WithEvents lblTotalCommission As Label
    Friend WithEvents lblTotalComm As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAdd As Label
End Class
