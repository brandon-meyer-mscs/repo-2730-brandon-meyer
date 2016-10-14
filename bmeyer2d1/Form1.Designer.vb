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
        Me.txtSAR = New System.Windows.Forms.TextBox()
        Me.lblRand = New System.Windows.Forms.Label()
        Me.txtBP = New System.Windows.Forms.TextBox()
        Me.lblPound = New System.Windows.Forms.Label()
        Me.txtEuro = New System.Windows.Forms.TextBox()
        Me.lblE = New System.Windows.Forms.Label()
        Me.btnNE = New System.Windows.Forms.Button()
        Me.btnEQ = New System.Windows.Forms.Button()
        Me.lblAmDoll = New System.Windows.Forms.Label()
        Me.txtAmDollar = New System.Windows.Forms.TextBox()
        Me.gBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTD = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblPlb = New System.Windows.Forms.Label()
        Me.txtPound = New System.Windows.Forms.TextBox()
        Me.lblP = New System.Windows.Forms.Label()
        Me.gBox3 = New System.Windows.Forms.GroupBox()
        Me.lblPr = New System.Windows.Forms.Label()
        Me.txtPrev = New System.Windows.Forms.TextBox()
        Me.lblCur = New System.Windows.Forms.Label()
        Me.txtCurrent = New System.Windows.Forms.TextBox()
        Me.btnCalcE = New System.Windows.Forms.Button()
        Me.lblB = New System.Windows.Forms.Label()
        Me.txtBill = New System.Windows.Forms.TextBox()
        Me.gBox4 = New System.Windows.Forms.GroupBox()
        Me.lblN1 = New System.Windows.Forms.Label()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.lblN2 = New System.Windows.Forms.Label()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.btnCalcD = New System.Windows.Forms.Button()
        Me.lblQ = New System.Windows.Forms.Label()
        Me.txtQuotient = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gBox1.SuspendLayout()
        Me.gBox2.SuspendLayout()
        Me.gBox3.SuspendLayout()
        Me.gBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'gBox1
        '
        Me.gBox1.Controls.Add(Me.txtSAR)
        Me.gBox1.Controls.Add(Me.lblRand)
        Me.gBox1.Controls.Add(Me.txtBP)
        Me.gBox1.Controls.Add(Me.lblPound)
        Me.gBox1.Controls.Add(Me.txtEuro)
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
        'txtSAR
        '
        Me.txtSAR.Location = New System.Drawing.Point(460, 46)
        Me.txtSAR.Name = "txtSAR"
        Me.txtSAR.Size = New System.Drawing.Size(100, 20)
        Me.txtSAR.TabIndex = 9
        '
        'lblRand
        '
        Me.lblRand.AutoSize = True
        Me.lblRand.Location = New System.Drawing.Point(457, 30)
        Me.lblRand.Name = "lblRand"
        Me.lblRand.Size = New System.Drawing.Size(103, 13)
        Me.lblRand.TabIndex = 8
        Me.lblRand.Text = "South African &Rand:"
        '
        'txtBP
        '
        Me.txtBP.Location = New System.Drawing.Point(363, 46)
        Me.txtBP.Name = "txtBP"
        Me.txtBP.Size = New System.Drawing.Size(69, 20)
        Me.txtBP.TabIndex = 7
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
        'txtEuro
        '
        Me.txtEuro.Location = New System.Drawing.Point(245, 46)
        Me.txtEuro.Name = "txtEuro"
        Me.txtEuro.Size = New System.Drawing.Size(100, 20)
        Me.txtEuro.TabIndex = 5
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
        Me.gBox2.Controls.Add(Me.txtTotal)
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
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(363, 45)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 6
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
        Me.gBox3.Controls.Add(Me.txtBill)
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
        Me.gBox3.Text = "p232 #4 Division Calculator"
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
        'txtPrev
        '
        Me.txtPrev.Location = New System.Drawing.Point(9, 53)
        Me.txtPrev.Name = "txtPrev"
        Me.txtPrev.Size = New System.Drawing.Size(100, 20)
        Me.txtPrev.TabIndex = 1
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
        'txtCurrent
        '
        Me.txtCurrent.Location = New System.Drawing.Point(134, 53)
        Me.txtCurrent.Name = "txtCurrent"
        Me.txtCurrent.Size = New System.Drawing.Size(100, 20)
        Me.txtCurrent.TabIndex = 3
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
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Location = New System.Drawing.Point(362, 28)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(63, 13)
        Me.lblB.TabIndex = 5
        Me.lblB.Text = "Monthly Bill:"
        '
        'txtBill
        '
        Me.txtBill.Location = New System.Drawing.Point(365, 53)
        Me.txtBill.Name = "txtBill"
        Me.txtBill.Size = New System.Drawing.Size(100, 20)
        Me.txtBill.TabIndex = 6
        '
        'gBox4
        '
        Me.gBox4.Controls.Add(Me.btnExit)
        Me.gBox4.Controls.Add(Me.txtQuotient)
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
        'lblN1
        '
        Me.lblN1.AutoSize = True
        Me.lblN1.Location = New System.Drawing.Point(6, 25)
        Me.lblN1.Name = "lblN1"
        Me.lblN1.Size = New System.Drawing.Size(36, 13)
        Me.lblN1.TabIndex = 0
        Me.lblN1.Text = "First#:"
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(9, 41)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(100, 20)
        Me.txtNum1.TabIndex = 1
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
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(134, 41)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(100, 20)
        Me.txtNum2.TabIndex = 3
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
        'lblQ
        '
        Me.lblQ.AutoSize = True
        Me.lblQ.Location = New System.Drawing.Point(351, 23)
        Me.lblQ.Name = "lblQ"
        Me.lblQ.Size = New System.Drawing.Size(50, 13)
        Me.lblQ.TabIndex = 5
        Me.lblQ.Text = "Quotient:"
        '
        'txtQuotient
        '
        Me.txtQuotient.Location = New System.Drawing.Point(347, 39)
        Me.txtQuotient.Name = "txtQuotient"
        Me.txtQuotient.Size = New System.Drawing.Size(100, 20)
        Me.txtQuotient.TabIndex = 6
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(463, 36)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
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
    Friend WithEvents txtSAR As TextBox
    Friend WithEvents lblRand As Label
    Friend WithEvents txtBP As TextBox
    Friend WithEvents lblPound As Label
    Friend WithEvents txtEuro As TextBox
    Friend WithEvents gBox2 As GroupBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblTD As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblPlb As Label
    Friend WithEvents txtPound As TextBox
    Friend WithEvents lblP As Label
    Friend WithEvents gBox3 As GroupBox
    Friend WithEvents txtBill As TextBox
    Friend WithEvents lblB As Label
    Friend WithEvents btnCalcE As Button
    Friend WithEvents txtCurrent As TextBox
    Friend WithEvents lblCur As Label
    Friend WithEvents txtPrev As TextBox
    Friend WithEvents lblPr As Label
    Friend WithEvents gBox4 As GroupBox
    Friend WithEvents txtQuotient As TextBox
    Friend WithEvents lblQ As Label
    Friend WithEvents btnCalcD As Button
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents lblN2 As Label
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents lblN1 As Label
    Friend WithEvents btnExit As Button
End Class
