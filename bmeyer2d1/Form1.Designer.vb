<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.gBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSAR = New System.Windows.Forms.Label()
        Me.lblBP = New System.Windows.Forms.Label()
        Me.lblEuro = New System.Windows.Forms.Label()
        Me.lblRand = New System.Windows.Forms.Label()
        Me.lblPound = New System.Windows.Forms.Label()
        Me.lblE = New System.Windows.Forms.Label()
        Me.btnNE = New System.Windows.Forms.Button()
        Me.btnEQ = New System.Windows.Forms.Button()
        Me.lblAmDoll = New System.Windows.Forms.Label()
        Me.txtAmDollar = New System.Windows.Forms.TextBox()
        Me.gBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTD = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblPlb = New System.Windows.Forms.Label()
        Me.txtPound = New System.Windows.Forms.TextBox()
        Me.lblP = New System.Windows.Forms.Label()
        Me.gBox3 = New System.Windows.Forms.GroupBox()
        Me.lblBill = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.btnCalcE = New System.Windows.Forms.Button()
        Me.txtCurrent = New System.Windows.Forms.TextBox()
        Me.lblCur = New System.Windows.Forms.Label()
        Me.txtPrev = New System.Windows.Forms.TextBox()
        Me.lblPr = New System.Windows.Forms.Label()
        Me.gBox4 = New System.Windows.Forms.GroupBox()
        Me.lblQuotient = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblQ = New System.Windows.Forms.Label()
        Me.btnCalcD = New System.Windows.Forms.Button()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.lblN2 = New System.Windows.Forms.Label()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.lblN1 = New System.Windows.Forms.Label()
        Me.gBox1.SuspendLayout()
        Me.gBox2.SuspendLayout()
        Me.gBox3.SuspendLayout()
        Me.gBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'gBox1
        '
        Me.gBox1.Controls.Add(Me.lblSAR)
        Me.gBox1.Controls.Add(Me.lblBP)
        Me.gBox1.Controls.Add(Me.lblEuro)
        Me.gBox1.Controls.Add(Me.lblRand)
        Me.gBox1.Controls.Add(Me.lblPound)
        Me.gBox1.Controls.Add(Me.lblE)
        Me.gBox1.Controls.Add(Me.btnNE)
        Me.gBox1.Controls.Add(Me.btnEQ)
        Me.gBox1.Controls.Add(Me.lblAmDoll)
        Me.gBox1.Controls.Add(Me.txtAmDollar)
        Me.gBox1.Location = New System.Drawing.Point(12, 12)
        Me.gBox1.Name = "gBox1"
        Me.gBox1.Size = New System.Drawing.Size(585, 130)
        Me.gBox1.TabIndex = 0
        Me.gBox1.TabStop = False
        Me.gBox1.Text = "p231 #1 Currency Converter"
        '
        'lblSAR
        '
        Me.lblSAR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSAR.Location = New System.Drawing.Point(476, 51)
        Me.lblSAR.Name = "lblSAR"
        Me.lblSAR.Size = New System.Drawing.Size(100, 20)
        Me.lblSAR.TabIndex = 12
        '
        'lblBP
        '
        Me.lblBP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBP.Location = New System.Drawing.Point(360, 50)
        Me.lblBP.Name = "lblBP"
        Me.lblBP.Size = New System.Drawing.Size(100, 20)
        Me.lblBP.TabIndex = 11
        '
        'lblEuro
        '
        Me.lblEuro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEuro.Location = New System.Drawing.Point(245, 49)
        Me.lblEuro.Name = "lblEuro"
        Me.lblEuro.Size = New System.Drawing.Size(100, 20)
        Me.lblEuro.TabIndex = 10
        '
        'lblRand
        '
        Me.lblRand.AutoSize = True
        Me.lblRand.Location = New System.Drawing.Point(476, 30)
        Me.lblRand.Name = "lblRand"
        Me.lblRand.Size = New System.Drawing.Size(103, 13)
        Me.lblRand.TabIndex = 8
        Me.lblRand.Text = "South African &Rand:"
        '
        'lblPound
        '
        Me.lblPound.AutoSize = True
        Me.lblPound.Location = New System.Drawing.Point(360, 30)
        Me.lblPound.Name = "lblPound"
        Me.lblPound.Size = New System.Drawing.Size(72, 13)
        Me.lblPound.TabIndex = 6
        Me.lblPound.Text = "British &Pound:"
        '
        'lblE
        '
        Me.lblE.Location = New System.Drawing.Point(245, 30)
        Me.lblE.Name = "lblE"
        Me.lblE.Size = New System.Drawing.Size(100, 13)
        Me.lblE.TabIndex = 4
        Me.lblE.Text = "&Euro:"
        '
        'btnNE
        '
        Me.btnNE.Location = New System.Drawing.Point(142, 59)
        Me.btnNE.Name = "btnNE"
        Me.btnNE.Size = New System.Drawing.Size(75, 23)
        Me.btnNE.TabIndex = 3
        Me.btnNE.Text = "Convert <>"
        Me.btnNE.UseVisualStyleBackColor = True
        '
        'btnEQ
        '
        Me.btnEQ.Location = New System.Drawing.Point(142, 30)
        Me.btnEQ.Name = "btnEQ"
        Me.btnEQ.Size = New System.Drawing.Size(75, 23)
        Me.btnEQ.TabIndex = 2
        Me.btnEQ.Text = "Convert ="
        Me.btnEQ.UseVisualStyleBackColor = True
        '
        'lblAmDoll
        '
        Me.lblAmDoll.AutoSize = True
        Me.lblAmDoll.Location = New System.Drawing.Point(13, 30)
        Me.lblAmDoll.Name = "lblAmDoll"
        Me.lblAmDoll.Size = New System.Drawing.Size(84, 13)
        Me.lblAmDoll.TabIndex = 1
        Me.lblAmDoll.Text = "&American Dollar:"
        '
        'txtAmDollar
        '
        Me.txtAmDollar.Location = New System.Drawing.Point(16, 46)
        Me.txtAmDollar.Name = "txtAmDollar"
        Me.txtAmDollar.Size = New System.Drawing.Size(100, 20)
        Me.txtAmDollar.TabIndex = 0
        '
        'gBox2
        '
        Me.gBox2.Controls.Add(Me.lblTotal)
        Me.gBox2.Controls.Add(Me.lblTD)
        Me.gBox2.Controls.Add(Me.btnCalc)
        Me.gBox2.Controls.Add(Me.txtPrice)
        Me.gBox2.Controls.Add(Me.lblPlb)
        Me.gBox2.Controls.Add(Me.txtPound)
        Me.gBox2.Controls.Add(Me.lblP)
        Me.gBox2.Location = New System.Drawing.Point(12, 163)
        Me.gBox2.Name = "gBox2"
        Me.gBox2.Size = New System.Drawing.Size(585, 100)
        Me.gBox2.TabIndex = 1
        Me.gBox2.TabStop = False
        Me.gBox2.Text = "p231 #3 Tea Time"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(360, 42)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 6
        '
        'lblTD
        '
        Me.lblTD.AutoSize = True
        Me.lblTD.Location = New System.Drawing.Point(360, 16)
        Me.lblTD.Name = "lblTD"
        Me.lblTD.Size = New System.Drawing.Size(57, 13)
        Me.lblTD.TabIndex = 5
        Me.lblTD.Text = "Total Due:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(270, 42)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(142, 45)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 3
        '
        'lblPlb
        '
        Me.lblPlb.AutoSize = True
        Me.lblPlb.Location = New System.Drawing.Point(139, 16)
        Me.lblPlb.Name = "lblPlb"
        Me.lblPlb.Size = New System.Drawing.Size(47, 13)
        Me.lblPlb.TabIndex = 2
        Me.lblPlb.Text = "Price/lb:"
        '
        'txtPound
        '
        Me.txtPound.Location = New System.Drawing.Point(16, 45)
        Me.txtPound.Name = "txtPound"
        Me.txtPound.Size = New System.Drawing.Size(100, 20)
        Me.txtPound.TabIndex = 1
        '
        'lblP
        '
        Me.lblP.AutoSize = True
        Me.lblP.Location = New System.Drawing.Point(13, 16)
        Me.lblP.Name = "lblP"
        Me.lblP.Size = New System.Drawing.Size(46, 13)
        Me.lblP.TabIndex = 0
        Me.lblP.Text = "Pounds:"
        '
        'gBox3
        '
        Me.gBox3.Controls.Add(Me.lblBill)
        Me.gBox3.Controls.Add(Me.lblB)
        Me.gBox3.Controls.Add(Me.btnCalcE)
        Me.gBox3.Controls.Add(Me.txtCurrent)
        Me.gBox3.Controls.Add(Me.lblCur)
        Me.gBox3.Controls.Add(Me.txtPrev)
        Me.gBox3.Controls.Add(Me.lblPr)
        Me.gBox3.Location = New System.Drawing.Point(28, 269)
        Me.gBox3.Name = "gBox3"
        Me.gBox3.Size = New System.Drawing.Size(544, 100)
        Me.gBox3.TabIndex = 2
        Me.gBox3.TabStop = False
        Me.gBox3.Text = "p232 #4 Triple County Electric"
        '
        'lblBill
        '
        Me.lblBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBill.Location = New System.Drawing.Point(354, 53)
        Me.lblBill.Name = "lblBill"
        Me.lblBill.Size = New System.Drawing.Size(100, 23)
        Me.lblBill.TabIndex = 6
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Location = New System.Drawing.Point(362, 28)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(63, 13)
        Me.lblB.TabIndex = 5
        Me.lblB.Text = "Monthly Bill:"
        '
        'btnCalcE
        '
        Me.btnCalcE.Location = New System.Drawing.Point(254, 53)
        Me.btnCalcE.Name = "btnCalcE"
        Me.btnCalcE.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcE.TabIndex = 4
        Me.btnCalcE.Text = "Calculate"
        Me.btnCalcE.UseVisualStyleBackColor = True
        '
        'txtCurrent
        '
        Me.txtCurrent.Location = New System.Drawing.Point(134, 53)
        Me.txtCurrent.Name = "txtCurrent"
        Me.txtCurrent.Size = New System.Drawing.Size(100, 20)
        Me.txtCurrent.TabIndex = 3
        '
        'lblCur
        '
        Me.lblCur.AutoSize = True
        Me.lblCur.Location = New System.Drawing.Point(131, 28)
        Me.lblCur.Name = "lblCur"
        Me.lblCur.Size = New System.Drawing.Size(44, 13)
        Me.lblCur.TabIndex = 2
        Me.lblCur.Text = "Current:"
        '
        'txtPrev
        '
        Me.txtPrev.Location = New System.Drawing.Point(9, 53)
        Me.txtPrev.Name = "txtPrev"
        Me.txtPrev.Size = New System.Drawing.Size(100, 20)
        Me.txtPrev.TabIndex = 1
        '
        'lblPr
        '
        Me.lblPr.AutoSize = True
        Me.lblPr.Location = New System.Drawing.Point(6, 28)
        Me.lblPr.Name = "lblPr"
        Me.lblPr.Size = New System.Drawing.Size(51, 13)
        Me.lblPr.TabIndex = 0
        Me.lblPr.Text = "Previous:"
        '
        'gBox4
        '
        Me.gBox4.Controls.Add(Me.lblQuotient)
        Me.gBox4.Controls.Add(Me.btnExit)
        Me.gBox4.Controls.Add(Me.lblQ)
        Me.gBox4.Controls.Add(Me.btnCalcD)
        Me.gBox4.Controls.Add(Me.txtNum2)
        Me.gBox4.Controls.Add(Me.lblN2)
        Me.gBox4.Controls.Add(Me.txtNum1)
        Me.gBox4.Controls.Add(Me.lblN1)
        Me.gBox4.Location = New System.Drawing.Point(28, 375)
        Me.gBox4.Name = "gBox4"
        Me.gBox4.Size = New System.Drawing.Size(544, 100)
        Me.gBox4.TabIndex = 3
        Me.gBox4.TabStop = False
        Me.gBox4.Text = "p232 #5 Division Calculator"
        '
        'lblQuotient
        '
        Me.lblQuotient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuotient.Location = New System.Drawing.Point(347, 39)
        Me.lblQuotient.Name = "lblQuotient"
        Me.lblQuotient.Size = New System.Drawing.Size(100, 23)
        Me.lblQuotient.TabIndex = 8
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(463, 41)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblQ
        '
        Me.lblQ.AutoSize = True
        Me.lblQ.Location = New System.Drawing.Point(351, 23)
        Me.lblQ.Name = "lblQ"
        Me.lblQ.Size = New System.Drawing.Size(50, 13)
        Me.lblQ.TabIndex = 5
        Me.lblQ.Text = "Quotient:"
        '
        'btnCalcD
        '
        Me.btnCalcD.Location = New System.Drawing.Point(254, 39)
        Me.btnCalcD.Name = "btnCalcD"
        Me.btnCalcD.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcD.TabIndex = 4
        Me.btnCalcD.Text = "Calculate"
        Me.btnCalcD.UseVisualStyleBackColor = True
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(134, 41)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(100, 20)
        Me.txtNum2.TabIndex = 3
        '
        'lblN2
        '
        Me.lblN2.AutoSize = True
        Me.lblN2.Location = New System.Drawing.Point(131, 25)
        Me.lblN2.Name = "lblN2"
        Me.lblN2.Size = New System.Drawing.Size(54, 13)
        Me.lblN2.TabIndex = 2
        Me.lblN2.Text = "Second#:"
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(9, 41)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(100, 20)
        Me.txtNum1.TabIndex = 1
        '
        'lblN1
        '
        Me.lblN1.AutoSize = True
        Me.lblN1.Location = New System.Drawing.Point(6, 25)
        Me.lblN1.Name = "lblN1"
        Me.lblN1.Size = New System.Drawing.Size(36, 13)
        Me.lblN1.TabIndex = 0
        Me.lblN1.Text = "First#:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 477)
        Me.Controls.Add(Me.gBox4)
        Me.Controls.Add(Me.gBox3)
        Me.Controls.Add(Me.gBox2)
        Me.Controls.Add(Me.gBox1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "bmeyer If-Else Statements"
        Me.gBox1.ResumeLayout(False)
        Me.gBox1.PerformLayout()
        Me.gBox2.ResumeLayout(False)
        Me.gBox2.PerformLayout()
        Me.gBox3.ResumeLayout(False)
        Me.gBox3.PerformLayout()
        Me.gBox4.ResumeLayout(False)
        Me.gBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gBox1 As GroupBox
    Friend WithEvents btnNE As Button
    Friend WithEvents btnEQ As Button
    Friend WithEvents lblAmDoll As Label
    Friend WithEvents txtAmDollar As TextBox
    Friend WithEvents lblE As Label
    Friend WithEvents lblRand As Label
    Friend WithEvents lblPound As Label
    Friend WithEvents gBox2 As GroupBox
    Friend WithEvents lblTD As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblPlb As Label
    Friend WithEvents txtPound As TextBox
    Friend WithEvents lblP As Label
    Friend WithEvents gBox3 As GroupBox
    Friend WithEvents lblB As Label
    Friend WithEvents btnCalcE As Button
    Friend WithEvents txtCurrent As TextBox
    Friend WithEvents lblCur As Label
    Friend WithEvents txtPrev As TextBox
    Friend WithEvents lblPr As Label
    Friend WithEvents gBox4 As GroupBox
    Friend WithEvents lblQ As Label
    Friend WithEvents btnCalcD As Button
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents lblN2 As Label
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents lblN1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblSAR As Label
    Friend WithEvents lblBP As Label
    Friend WithEvents lblEuro As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblBill As Label
    Friend WithEvents lblQuotient As Label
End Class
