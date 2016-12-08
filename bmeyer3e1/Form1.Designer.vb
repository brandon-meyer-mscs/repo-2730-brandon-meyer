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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblComm = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblValueCount = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblRangeCount = New System.Windows.Forms.Label()
        Me.cboSearchValues = New System.Windows.Forms.ComboBox()
        Me.cboSearchRanges = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Commission Values:"
        '
        'lblComm
        '
        Me.lblComm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblComm.Location = New System.Drawing.Point(120, 30)
        Me.lblComm.Name = "lblComm"
        Me.lblComm.Size = New System.Drawing.Size(216, 51)
        Me.lblComm.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Search for Value:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(256, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Count:"
        '
        'lblValueCount
        '
        Me.lblValueCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblValueCount.Location = New System.Drawing.Point(300, 111)
        Me.lblValueCount.Name = "lblValueCount"
        Me.lblValueCount.Size = New System.Drawing.Size(63, 18)
        Me.lblValueCount.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Search for Range:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(256, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Count:"
        '
        'lblRangeCount
        '
        Me.lblRangeCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRangeCount.Location = New System.Drawing.Point(300, 232)
        Me.lblRangeCount.Name = "lblRangeCount"
        Me.lblRangeCount.Size = New System.Drawing.Size(63, 18)
        Me.lblRangeCount.TabIndex = 9
        '
        'cboSearchValues
        '
        Me.cboSearchValues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboSearchValues.FormattingEnabled = True
        Me.cboSearchValues.Items.AddRange(New Object() {"50", "100", "300", "900"})
        Me.cboSearchValues.Location = New System.Drawing.Point(120, 112)
        Me.cboSearchValues.Name = "cboSearchValues"
        Me.cboSearchValues.Size = New System.Drawing.Size(121, 86)
        Me.cboSearchValues.TabIndex = 10
        '
        'cboSearchRanges
        '
        Me.cboSearchRanges.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboSearchRanges.FormattingEnabled = True
        Me.cboSearchRanges.Items.AddRange(New Object() {"    0 - 200", "100 - 300", "700 - 800"})
        Me.cboSearchRanges.Location = New System.Drawing.Point(122, 215)
        Me.cboSearchRanges.Name = "cboSearchRanges"
        Me.cboSearchRanges.Size = New System.Drawing.Size(121, 85)
        Me.cboSearchRanges.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 332)
        Me.Controls.Add(Me.cboSearchRanges)
        Me.Controls.Add(Me.cboSearchValues)
        Me.Controls.Add(Me.lblRangeCount)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblValueCount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblComm)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "bmeyer3e1 Arrays, Functions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblComm As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblValueCount As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblRangeCount As Label
    Friend WithEvents cboSearchValues As ComboBox
    Friend WithEvents cboSearchRanges As ComboBox
End Class
