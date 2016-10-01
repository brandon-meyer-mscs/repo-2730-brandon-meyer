<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetirement
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
        Me.lblGross = New System.Windows.Forms.Label()
        Me.txtGWP = New System.Windows.Forms.TextBox()
        Me.lblContRate = New System.Windows.Forms.Label()
        Me.txtECR = New System.Windows.Forms.TextBox()
        Me.lblEmpCR = New System.Windows.Forms.Label()
        Me.txtEmpCR = New System.Windows.Forms.TextBox()
        Me.lblEmpAC = New System.Windows.Forms.Label()
        Me.lblEmplAC = New System.Windows.Forms.Label()
        Me.lblTotAC = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblEAC = New System.Windows.Forms.Label()
        Me.lblEmAC = New System.Windows.Forms.Label()
        Me.lblTAC = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblGross
        '
        Me.lblGross.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGross.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGross.Location = New System.Drawing.Point(22, 27)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(137, 30)
        Me.lblGross.TabIndex = 0
        Me.lblGross.Text = "&Gross Weekly Pay:"
        '
        'txtGWP
        '
        Me.txtGWP.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGWP.Location = New System.Drawing.Point(165, 28)
        Me.txtGWP.Name = "txtGWP"
        Me.txtGWP.Size = New System.Drawing.Size(100, 29)
        Me.txtGWP.TabIndex = 1
        Me.txtGWP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblContRate
        '
        Me.lblContRate.AutoSize = True
        Me.lblContRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblContRate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContRate.Location = New System.Drawing.Point(22, 86)
        Me.lblContRate.Name = "lblContRate"
        Me.lblContRate.Size = New System.Drawing.Size(324, 23)
        Me.lblContRate.TabIndex = 2
        Me.lblContRate.Text = "&Employee Contribution Rate: (Decimal Form):"
        '
        'txtECR
        '
        Me.txtECR.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtECR.Location = New System.Drawing.Point(361, 80)
        Me.txtECR.Name = "txtECR"
        Me.txtECR.Size = New System.Drawing.Size(100, 29)
        Me.txtECR.TabIndex = 3
        Me.txtECR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblEmpCR
        '
        Me.lblEmpCR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmpCR.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpCR.Location = New System.Drawing.Point(26, 142)
        Me.lblEmpCR.Name = "lblEmpCR"
        Me.lblEmpCR.Size = New System.Drawing.Size(320, 23)
        Me.lblEmpCR.TabIndex = 4
        Me.lblEmpCR.Text = "E&mployer Contribution Rate (Decimal Form):"
        '
        'txtEmpCR
        '
        Me.txtEmpCR.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpCR.Location = New System.Drawing.Point(361, 136)
        Me.txtEmpCR.Name = "txtEmpCR"
        Me.txtEmpCR.Size = New System.Drawing.Size(100, 29)
        Me.txtEmpCR.TabIndex = 5
        Me.txtEmpCR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblEmpAC
        '
        Me.lblEmpAC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpAC.Location = New System.Drawing.Point(25, 197)
        Me.lblEmpAC.Name = "lblEmpAC"
        Me.lblEmpAC.Size = New System.Drawing.Size(240, 23)
        Me.lblEmpAC.TabIndex = 6
        Me.lblEmpAC.Text = "Employee Annual Contribution:"
        '
        'lblEmplAC
        '
        Me.lblEmplAC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmplAC.Location = New System.Drawing.Point(26, 251)
        Me.lblEmplAC.Name = "lblEmplAC"
        Me.lblEmplAC.Size = New System.Drawing.Size(228, 28)
        Me.lblEmplAC.TabIndex = 7
        Me.lblEmplAC.Text = "Employer Annual Contribution:"
        '
        'lblTotAC
        '
        Me.lblTotAC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotAC.Location = New System.Drawing.Point(26, 294)
        Me.lblTotAC.Name = "lblTotAC"
        Me.lblTotAC.Size = New System.Drawing.Size(219, 23)
        Me.lblTotAC.TabIndex = 8
        Me.lblTotAC.Text = "Total Annual Contributions:"
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(392, 193)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(82, 31)
        Me.btnCalc.TabIndex = 12
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(392, 294)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 31)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblEAC
        '
        Me.lblEAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEAC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEAC.Location = New System.Drawing.Point(271, 197)
        Me.lblEAC.Name = "lblEAC"
        Me.lblEAC.Size = New System.Drawing.Size(100, 23)
        Me.lblEAC.TabIndex = 14
        '
        'lblEmAC
        '
        Me.lblEmAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmAC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmAC.Location = New System.Drawing.Point(271, 251)
        Me.lblEmAC.Name = "lblEmAC"
        Me.lblEmAC.Size = New System.Drawing.Size(100, 23)
        Me.lblEmAC.TabIndex = 15
        '
        'lblTAC
        '
        Me.lblTAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTAC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTAC.Location = New System.Drawing.Point(271, 294)
        Me.lblTAC.Name = "lblTAC"
        Me.lblTAC.Size = New System.Drawing.Size(100, 23)
        Me.lblTAC.TabIndex = 16
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(392, 251)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(82, 31)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmRetirement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 384)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblTAC)
        Me.Controls.Add(Me.lblEmAC)
        Me.Controls.Add(Me.lblEAC)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblTotAC)
        Me.Controls.Add(Me.lblEmplAC)
        Me.Controls.Add(Me.lblEmpAC)
        Me.Controls.Add(Me.txtEmpCR)
        Me.Controls.Add(Me.lblEmpCR)
        Me.Controls.Add(Me.txtECR)
        Me.Controls.Add(Me.lblContRate)
        Me.Controls.Add(Me.txtGWP)
        Me.Controls.Add(Me.lblGross)
        Me.Name = "frmRetirement"
        Me.Text = "Retirement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGross As Label
    Friend WithEvents txtGWP As TextBox
    Friend WithEvents lblContRate As Label
    Friend WithEvents txtECR As TextBox
    Friend WithEvents lblEmpCR As Label
    Friend WithEvents txtEmpCR As TextBox
    Friend WithEvents lblEmpAC As Label
    Friend WithEvents lblEmplAC As Label
    Friend WithEvents lblTotAC As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblEAC As Label
    Friend WithEvents lblEmAC As Label
    Friend WithEvents lblTAC As Label
    Friend WithEvents btnClear As Button
End Class
