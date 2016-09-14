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
        Me.lblscr1 = New System.Windows.Forms.Label()
        Me.lblscr2 = New System.Windows.Forms.Label()
        Me.lblscr3 = New System.Windows.Forms.Label()
        Me.lblavg = New System.Windows.Forms.Label()
        Me.lblavgscr = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtscr1 = New System.Windows.Forms.TextBox()
        Me.txtscr2 = New System.Windows.Forms.TextBox()
        Me.txtscr3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblscr1
        '
        Me.lblscr1.AutoSize = True
        Me.lblscr1.Location = New System.Drawing.Point(21, 38)
        Me.lblscr1.Name = "lblscr1"
        Me.lblscr1.Size = New System.Drawing.Size(89, 20)
        Me.lblscr1.TabIndex = 0
        Me.lblscr1.Text = "Test score &1:"
        '
        'lblscr2
        '
        Me.lblscr2.AutoSize = True
        Me.lblscr2.Location = New System.Drawing.Point(21, 93)
        Me.lblscr2.Name = "lblscr2"
        Me.lblscr2.Size = New System.Drawing.Size(91, 20)
        Me.lblscr2.TabIndex = 1
        Me.lblscr2.Text = "Test Score &2:"
        '
        'lblscr3
        '
        Me.lblscr3.AutoSize = True
        Me.lblscr3.Location = New System.Drawing.Point(21, 142)
        Me.lblscr3.Name = "lblscr3"
        Me.lblscr3.Size = New System.Drawing.Size(91, 20)
        Me.lblscr3.TabIndex = 2
        Me.lblscr3.Text = "Test Score &3:"
        '
        'lblavg
        '
        Me.lblavg.AutoSize = True
        Me.lblavg.Location = New System.Drawing.Point(21, 198)
        Me.lblavg.Name = "lblavg"
        Me.lblavg.Size = New System.Drawing.Size(134, 20)
        Me.lblavg.TabIndex = 3
        Me.lblavg.Text = "Average test score:"
        '
        'lblavgscr
        '
        Me.lblavgscr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblavgscr.Location = New System.Drawing.Point(183, 189)
        Me.lblavgscr.Name = "lblavgscr"
        Me.lblavgscr.Size = New System.Drawing.Size(75, 29)
        Me.lblavgscr.TabIndex = 4
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(286, 24)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(88, 34)
        Me.btnCalc.TabIndex = 5
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(286, 79)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(88, 34)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(286, 132)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 30)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtscr1
        '
        Me.txtscr1.Location = New System.Drawing.Point(139, 31)
        Me.txtscr1.Name = "txtscr1"
        Me.txtscr1.Size = New System.Drawing.Size(100, 27)
        Me.txtscr1.TabIndex = 8
        '
        'txtscr2
        '
        Me.txtscr2.Location = New System.Drawing.Point(139, 86)
        Me.txtscr2.Name = "txtscr2"
        Me.txtscr2.Size = New System.Drawing.Size(100, 27)
        Me.txtscr2.TabIndex = 9
        '
        'txtscr3
        '
        Me.txtscr3.Location = New System.Drawing.Point(139, 135)
        Me.txtscr3.Name = "txtscr3"
        Me.txtscr3.Size = New System.Drawing.Size(100, 27)
        Me.txtscr3.TabIndex = 10
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 245)
        Me.Controls.Add(Me.txtscr3)
        Me.Controls.Add(Me.txtscr2)
        Me.Controls.Add(Me.txtscr1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblavgscr)
        Me.Controls.Add(Me.lblavg)
        Me.Controls.Add(Me.lblscr3)
        Me.Controls.Add(Me.lblscr2)
        Me.Controls.Add(Me.lblscr1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "bmeyer1g1 Average Test Score"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblscr1 As Label
    Friend WithEvents lblscr2 As Label
    Friend WithEvents lblscr3 As Label
    Friend WithEvents lblavg As Label
    Friend WithEvents lblavgscr As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtscr1 As TextBox
    Friend WithEvents txtscr2 As TextBox
    Friend WithEvents txtscr3 As TextBox
End Class
