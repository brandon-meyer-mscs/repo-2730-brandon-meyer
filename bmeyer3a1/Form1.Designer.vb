<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainFrm1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.posttestFor = New System.Windows.Forms.Button()
        Me.posttestLoopUntil = New System.Windows.Forms.Button()
        Me.posttestLoopWhile = New System.Windows.Forms.Button()
        Me.pretestDoUntil = New System.Windows.Forms.Button()
        Me.pretestDoWhile = New System.Windows.Forms.Button()
        Me.lblEven = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtList = New System.Windows.Forms.TextBox()
        Me.btnSumForNext = New System.Windows.Forms.Button()
        Me.btnSumLoopUntil = New System.Windows.Forms.Button()
        Me.btnSumDoWhile = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblAvg = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.posttestFor)
        Me.GroupBox1.Controls.Add(Me.posttestLoopUntil)
        Me.GroupBox1.Controls.Add(Me.posttestLoopWhile)
        Me.GroupBox1.Controls.Add(Me.pretestDoUntil)
        Me.GroupBox1.Controls.Add(Me.pretestDoWhile)
        Me.GroupBox1.Controls.Add(Me.lblEven)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 219)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "p347 #13 Loop 2-20"
        '
        'posttestFor
        '
        Me.posttestFor.Location = New System.Drawing.Point(129, 165)
        Me.posttestFor.Name = "posttestFor"
        Me.posttestFor.Size = New System.Drawing.Size(124, 23)
        Me.posttestFor.TabIndex = 5
        Me.posttestFor.Text = "Posttest: For"
        Me.posttestFor.UseVisualStyleBackColor = True
        '
        'posttestLoopUntil
        '
        Me.posttestLoopUntil.Location = New System.Drawing.Point(129, 122)
        Me.posttestLoopUntil.Name = "posttestLoopUntil"
        Me.posttestLoopUntil.Size = New System.Drawing.Size(124, 23)
        Me.posttestLoopUntil.TabIndex = 4
        Me.posttestLoopUntil.Text = "Posttest: Loop Until"
        Me.posttestLoopUntil.UseVisualStyleBackColor = True
        '
        'posttestLoopWhile
        '
        Me.posttestLoopWhile.Location = New System.Drawing.Point(129, 93)
        Me.posttestLoopWhile.Name = "posttestLoopWhile"
        Me.posttestLoopWhile.Size = New System.Drawing.Size(124, 23)
        Me.posttestLoopWhile.TabIndex = 3
        Me.posttestLoopWhile.Text = "Posttest: Loop While"
        Me.posttestLoopWhile.UseVisualStyleBackColor = True
        '
        'pretestDoUntil
        '
        Me.pretestDoUntil.Location = New System.Drawing.Point(129, 64)
        Me.pretestDoUntil.Name = "pretestDoUntil"
        Me.pretestDoUntil.Size = New System.Drawing.Size(124, 23)
        Me.pretestDoUntil.TabIndex = 2
        Me.pretestDoUntil.Text = "Pretest: Do Until"
        Me.pretestDoUntil.UseVisualStyleBackColor = True
        '
        'pretestDoWhile
        '
        Me.pretestDoWhile.Location = New System.Drawing.Point(129, 26)
        Me.pretestDoWhile.Name = "pretestDoWhile"
        Me.pretestDoWhile.Size = New System.Drawing.Size(124, 23)
        Me.pretestDoWhile.TabIndex = 1
        Me.pretestDoWhile.Text = "Pretest: Do While"
        Me.pretestDoWhile.UseVisualStyleBackColor = True
        '
        'lblEven
        '
        Me.lblEven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEven.Location = New System.Drawing.Point(10, 23)
        Me.lblEven.Name = "lblEven"
        Me.lblEven.Size = New System.Drawing.Size(113, 182)
        Me.lblEven.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtList)
        Me.GroupBox2.Controls.Add(Me.btnSumForNext)
        Me.GroupBox2.Controls.Add(Me.btnSumLoopUntil)
        Me.GroupBox2.Controls.Add(Me.btnSumDoWhile)
        Me.GroupBox2.Controls.Add(Me.lblCount)
        Me.GroupBox2.Controls.Add(Me.lblAvg)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(302, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(237, 219)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "p332_348 #22 Addition"
        '
        'txtList
        '
        Me.txtList.Enabled = False
        Me.txtList.Location = New System.Drawing.Point(6, 21)
        Me.txtList.Multiline = True
        Me.txtList.Name = "txtList"
        Me.txtList.Size = New System.Drawing.Size(100, 167)
        Me.txtList.TabIndex = 8
        '
        'btnSumForNext
        '
        Me.btnSumForNext.Location = New System.Drawing.Point(125, 182)
        Me.btnSumForNext.Name = "btnSumForNext"
        Me.btnSumForNext.Size = New System.Drawing.Size(106, 23)
        Me.btnSumForNext.TabIndex = 7
        Me.btnSumForNext.Text = "Sum, For Next"
        Me.btnSumForNext.UseVisualStyleBackColor = True
        '
        'btnSumLoopUntil
        '
        Me.btnSumLoopUntil.Location = New System.Drawing.Point(125, 140)
        Me.btnSumLoopUntil.Name = "btnSumLoopUntil"
        Me.btnSumLoopUntil.Size = New System.Drawing.Size(106, 23)
        Me.btnSumLoopUntil.TabIndex = 6
        Me.btnSumLoopUntil.Text = "Sum, Loop Until"
        Me.btnSumLoopUntil.UseVisualStyleBackColor = True
        '
        'btnSumDoWhile
        '
        Me.btnSumDoWhile.Location = New System.Drawing.Point(125, 93)
        Me.btnSumDoWhile.Name = "btnSumDoWhile"
        Me.btnSumDoWhile.Size = New System.Drawing.Size(106, 23)
        Me.btnSumDoWhile.TabIndex = 5
        Me.btnSumDoWhile.Text = "Sum, Do While"
        Me.btnSumDoWhile.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCount.Location = New System.Drawing.Point(180, 39)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(51, 37)
        Me.lblCount.TabIndex = 4
        '
        'lblAvg
        '
        Me.lblAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvg.Location = New System.Drawing.Point(125, 39)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(49, 37)
        Me.lblAvg.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(193, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Count:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(138, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Avg:"
        '
        'mainFrm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 253)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "mainFrm1"
        Me.Text = "bmeyer3a1 Loops, Sum, Count"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents posttestFor As Button
    Friend WithEvents posttestLoopUntil As Button
    Friend WithEvents posttestLoopWhile As Button
    Friend WithEvents pretestDoUntil As Button
    Friend WithEvents pretestDoWhile As Button
    Friend WithEvents lblEven As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSumForNext As Button
    Friend WithEvents btnSumLoopUntil As Button
    Friend WithEvents btnSumDoWhile As Button
    Friend WithEvents lblCount As Label
    Friend WithEvents lblAvg As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtList As TextBox
End Class
