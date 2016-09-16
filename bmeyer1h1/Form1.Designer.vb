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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.lblGross = New System.Windows.Forms.Label()
        Me.lblFWT = New System.Windows.Forms.Label()
        Me.lblF = New System.Windows.Forms.Label()
        Me.lblSIT = New System.Windows.Forms.Label()
        Me.lblNP = New System.Windows.Forms.Label()
        Me.lblGP = New System.Windows.Forms.Label()
        Me.lblFed = New System.Windows.Forms.Label()
        Me.lblSST = New System.Windows.Forms.Label()
        Me.lblFICA = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(20, 42)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(52, 20)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(20, 156)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(42, 20)
        Me.lblRate.TabIndex = 1
        Me.lblRate.Text = "Rate:"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(20, 102)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(106, 20)
        Me.lblHours.TabIndex = 2
        Me.lblHours.Text = "Hours Worked:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(135, 35)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 27)
        Me.txtName.TabIndex = 3
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(135, 95)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(100, 27)
        Me.txtHours.TabIndex = 4
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(135, 149)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(100, 27)
        Me.txtRate.TabIndex = 5
        '
        'lblGross
        '
        Me.lblGross.AutoSize = True
        Me.lblGross.Location = New System.Drawing.Point(295, 42)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(74, 20)
        Me.lblGross.TabIndex = 6
        Me.lblGross.Text = "Gross Pay:"
        '
        'lblFWT
        '
        Me.lblFWT.AutoSize = True
        Me.lblFWT.Location = New System.Drawing.Point(295, 102)
        Me.lblFWT.Name = "lblFWT"
        Me.lblFWT.Size = New System.Drawing.Size(41, 20)
        Me.lblFWT.TabIndex = 7
        Me.lblFWT.Text = "FWT:"
        '
        'lblF
        '
        Me.lblF.AutoSize = True
        Me.lblF.Location = New System.Drawing.Point(295, 156)
        Me.lblF.Name = "lblF"
        Me.lblF.Size = New System.Drawing.Size(42, 20)
        Me.lblF.TabIndex = 8
        Me.lblF.Text = "FICA:"
        '
        'lblSIT
        '
        Me.lblSIT.AutoSize = True
        Me.lblSIT.Location = New System.Drawing.Point(295, 201)
        Me.lblSIT.Name = "lblSIT"
        Me.lblSIT.Size = New System.Drawing.Size(124, 20)
        Me.lblSIT.TabIndex = 9
        Me.lblSIT.Text = "State Income Tax:"
        '
        'lblNP
        '
        Me.lblNP.AutoSize = True
        Me.lblNP.Location = New System.Drawing.Point(295, 242)
        Me.lblNP.Name = "lblNP"
        Me.lblNP.Size = New System.Drawing.Size(62, 20)
        Me.lblNP.TabIndex = 10
        Me.lblNP.Text = "Net Pay:"
        '
        'lblGP
        '
        Me.lblGP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGP.Location = New System.Drawing.Point(428, 35)
        Me.lblGP.Name = "lblGP"
        Me.lblGP.Size = New System.Drawing.Size(78, 27)
        Me.lblGP.TabIndex = 11
        '
        'lblFed
        '
        Me.lblFed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFed.Location = New System.Drawing.Point(428, 95)
        Me.lblFed.Name = "lblFed"
        Me.lblFed.Size = New System.Drawing.Size(78, 27)
        Me.lblFed.TabIndex = 12
        '
        'lblSST
        '
        Me.lblSST.Location = New System.Drawing.Point(390, 159)
        Me.lblSST.Name = "lblSST"
        Me.lblSST.Size = New System.Drawing.Size(39, 13)
        Me.lblSST.TabIndex = 13
        '
        'lblFICA
        '
        Me.lblFICA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFICA.Location = New System.Drawing.Point(426, 149)
        Me.lblFICA.Name = "lblFICA"
        Me.lblFICA.Size = New System.Drawing.Size(80, 27)
        Me.lblFICA.TabIndex = 14
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTax.Location = New System.Drawing.Point(425, 192)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(81, 29)
        Me.lblTax.TabIndex = 15
        '
        'lblNetPay
        '
        Me.lblNetPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNetPay.Location = New System.Drawing.Point(425, 233)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(80, 29)
        Me.lblNetPay.TabIndex = 16
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(52, 233)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(91, 29)
        Me.btnCalc.TabIndex = 17
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(52, 285)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 28)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(228, 285)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(89, 28)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 359)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblNetPay)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblFICA)
        Me.Controls.Add(Me.lblSST)
        Me.Controls.Add(Me.lblFed)
        Me.Controls.Add(Me.lblGP)
        Me.Controls.Add(Me.lblNP)
        Me.Controls.Add(Me.lblSIT)
        Me.Controls.Add(Me.lblF)
        Me.Controls.Add(Me.lblFWT)
        Me.Controls.Add(Me.lblGross)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.lblName)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "bmeyer1h1 Employee Net Pay"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblRate As Label
    Friend WithEvents lblHours As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtHours As TextBox
    Friend WithEvents txtRate As TextBox
    Friend WithEvents lblGross As Label
    Friend WithEvents lblFWT As Label
    Friend WithEvents lblF As Label
    Friend WithEvents lblSIT As Label
    Friend WithEvents lblNP As Label
    Friend WithEvents lblGP As Label
    Friend WithEvents lblFed As Label
    Friend WithEvents lblSST As Label
    Friend WithEvents lblFICA As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblNetPay As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
