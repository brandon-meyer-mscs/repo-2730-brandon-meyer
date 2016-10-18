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
        Me.btnCalcOr = New System.Windows.Forms.Button()
        Me.btnCalcAnd = New System.Windows.Forms.Button()
        Me.lblCharge = New System.Windows.Forms.Label()
        Me.lblShip = New System.Windows.Forms.Label()
        Me.txtYN = New System.Windows.Forms.TextBox()
        Me.lblSavannah = New System.Windows.Forms.Label()
        Me.txtOrder = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblIdent = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblSal = New System.Windows.Forms.Label()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.lblCom = New System.Windows.Forms.Label()
        Me.lblCommission = New System.Windows.Forms.Label()
        Me.calcEq = New System.Windows.Forms.Button()
        Me.btnCalcNEq = New System.Windows.Forms.Button()
        Me.gBox1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gBox1
        '
        Me.gBox1.Controls.Add(Me.btnCalcOr)
        Me.gBox1.Controls.Add(Me.btnCalcAnd)
        Me.gBox1.Controls.Add(Me.lblCharge)
        Me.gBox1.Controls.Add(Me.lblShip)
        Me.gBox1.Controls.Add(Me.txtYN)
        Me.gBox1.Controls.Add(Me.lblSavannah)
        Me.gBox1.Controls.Add(Me.txtOrder)
        Me.gBox1.Controls.Add(Me.Label1)
        Me.gBox1.Location = New System.Drawing.Point(12, 12)
        Me.gBox1.Name = "gBox1"
        Me.gBox1.Size = New System.Drawing.Size(558, 100)
        Me.gBox1.TabIndex = 0
        Me.gBox1.TabStop = False
        Me.gBox1.Text = "Free Shipping for Orders over $100 with Savannah CC"
        '
        'btnCalcOr
        '
        Me.btnCalcOr.Location = New System.Drawing.Point(397, 55)
        Me.btnCalcOr.Name = "btnCalcOr"
        Me.btnCalcOr.Size = New System.Drawing.Size(103, 23)
        Me.btnCalcOr.TabIndex = 7
        Me.btnCalcOr.Text = "Calculate (Or)"
        Me.btnCalcOr.UseVisualStyleBackColor = True
        '
        'btnCalcAnd
        '
        Me.btnCalcAnd.Location = New System.Drawing.Point(397, 20)
        Me.btnCalcAnd.Name = "btnCalcAnd"
        Me.btnCalcAnd.Size = New System.Drawing.Size(103, 23)
        Me.btnCalcAnd.TabIndex = 6
        Me.btnCalcAnd.Text = "Calculate (And)"
        Me.btnCalcAnd.UseVisualStyleBackColor = True
        '
        'lblCharge
        '
        Me.lblCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCharge.Location = New System.Drawing.Point(264, 54)
        Me.lblCharge.Name = "lblCharge"
        Me.lblCharge.Size = New System.Drawing.Size(100, 20)
        Me.lblCharge.TabIndex = 5
        '
        'lblShip
        '
        Me.lblShip.AutoSize = True
        Me.lblShip.Location = New System.Drawing.Point(261, 25)
        Me.lblShip.Name = "lblShip"
        Me.lblShip.Size = New System.Drawing.Size(88, 13)
        Me.lblShip.TabIndex = 4
        Me.lblShip.Text = "Shipping Charge:"
        '
        'txtYN
        '
        Me.txtYN.Location = New System.Drawing.Point(147, 57)
        Me.txtYN.Name = "txtYN"
        Me.txtYN.Size = New System.Drawing.Size(62, 20)
        Me.txtYN.TabIndex = 3
        '
        'lblSavannah
        '
        Me.lblSavannah.AutoSize = True
        Me.lblSavannah.Location = New System.Drawing.Point(132, 25)
        Me.lblSavannah.Name = "lblSavannah"
        Me.lblSavannah.Size = New System.Drawing.Size(88, 13)
        Me.lblSavannah.TabIndex = 2
        Me.lblSavannah.Text = "&Savannah (Y/N):"
        '
        'txtOrder
        '
        Me.txtOrder.Location = New System.Drawing.Point(9, 57)
        Me.txtOrder.Name = "txtOrder"
        Me.txtOrder.Size = New System.Drawing.Size(100, 20)
        Me.txtOrder.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Order Amount:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCalcNEq)
        Me.GroupBox1.Controls.Add(Me.calcEq)
        Me.GroupBox1.Controls.Add(Me.lblCommission)
        Me.GroupBox1.Controls.Add(Me.lblCom)
        Me.GroupBox1.Controls.Add(Me.txtSales)
        Me.GroupBox1.Controls.Add(Me.lblSal)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.lblIdent)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(558, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "15% Commision for Sales > 25000 w Codes A1, B2, C3"
        '
        'lblIdent
        '
        Me.lblIdent.AutoSize = True
        Me.lblIdent.Location = New System.Drawing.Point(6, 27)
        Me.lblIdent.Name = "lblIdent"
        Me.lblIdent.Size = New System.Drawing.Size(21, 13)
        Me.lblIdent.TabIndex = 0
        Me.lblIdent.Text = "&ID:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(9, 43)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(40, 20)
        Me.txtID.TabIndex = 1
        '
        'lblSal
        '
        Me.lblSal.AutoSize = True
        Me.lblSal.Location = New System.Drawing.Point(82, 27)
        Me.lblSal.Name = "lblSal"
        Me.lblSal.Size = New System.Drawing.Size(36, 13)
        Me.lblSal.TabIndex = 2
        Me.lblSal.Text = "S&ales:"
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(85, 43)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(100, 20)
        Me.txtSales.TabIndex = 3
        '
        'lblCom
        '
        Me.lblCom.AutoSize = True
        Me.lblCom.Location = New System.Drawing.Point(261, 27)
        Me.lblCom.Name = "lblCom"
        Me.lblCom.Size = New System.Drawing.Size(65, 13)
        Me.lblCom.TabIndex = 4
        Me.lblCom.Text = "Commission:"
        '
        'lblCommission
        '
        Me.lblCommission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCommission.Location = New System.Drawing.Point(264, 45)
        Me.lblCommission.Name = "lblCommission"
        Me.lblCommission.Size = New System.Drawing.Size(100, 20)
        Me.lblCommission.TabIndex = 5
        '
        'calcEq
        '
        Me.calcEq.Location = New System.Drawing.Point(397, 19)
        Me.calcEq.Name = "calcEq"
        Me.calcEq.Size = New System.Drawing.Size(103, 23)
        Me.calcEq.TabIndex = 6
        Me.calcEq.Text = "Calculate (=)"
        Me.calcEq.UseVisualStyleBackColor = True
        '
        'btnCalcNEq
        '
        Me.btnCalcNEq.Location = New System.Drawing.Point(397, 57)
        Me.btnCalcNEq.Name = "btnCalcNEq"
        Me.btnCalcNEq.Size = New System.Drawing.Size(103, 23)
        Me.btnCalcNEq.TabIndex = 7
        Me.btnCalcNEq.Text = "Calculate (<>)"
        Me.btnCalcNEq.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 285)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gBox1)
        Me.Name = "frmMain"
        Me.Text = "bmeyer2e1 AndAlso, OrElse"
        Me.gBox1.ResumeLayout(False)
        Me.gBox1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gBox1 As GroupBox
    Friend WithEvents btnCalcOr As Button
    Friend WithEvents btnCalcAnd As Button
    Friend WithEvents lblCharge As Label
    Friend WithEvents lblShip As Label
    Friend WithEvents txtYN As TextBox
    Friend WithEvents lblSavannah As Label
    Friend WithEvents txtOrder As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblCommission As Label
    Friend WithEvents lblCom As Label
    Friend WithEvents txtSales As TextBox
    Friend WithEvents lblSal As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblIdent As Label
    Friend WithEvents btnCalcNEq As Button
    Friend WithEvents calcEq As Button
End Class
