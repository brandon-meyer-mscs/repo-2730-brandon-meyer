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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lstGames1 = New System.Windows.Forms.ListBox()
        Me.lstGames2 = New System.Windows.Forms.ListBox()
        Me.lstGames3 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(26, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lstGames1
        '
        Me.lstGames1.FormattingEnabled = True
        Me.lstGames1.Location = New System.Drawing.Point(26, 70)
        Me.lstGames1.Name = "lstGames1"
        Me.lstGames1.Size = New System.Drawing.Size(120, 95)
        Me.lstGames1.TabIndex = 1
        '
        'lstGames2
        '
        Me.lstGames2.FormattingEnabled = True
        Me.lstGames2.Location = New System.Drawing.Point(26, 195)
        Me.lstGames2.Name = "lstGames2"
        Me.lstGames2.Size = New System.Drawing.Size(120, 95)
        Me.lstGames2.TabIndex = 2
        '
        'lstGames3
        '
        Me.lstGames3.FormattingEnabled = True
        Me.lstGames3.Location = New System.Drawing.Point(201, 70)
        Me.lstGames3.Name = "lstGames3"
        Me.lstGames3.Size = New System.Drawing.Size(120, 95)
        Me.lstGames3.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 322)
        Me.Controls.Add(Me.lstGames3)
        Me.Controls.Add(Me.lstGames2)
        Me.Controls.Add(Me.lstGames1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lstGames1 As ListBox
    Friend WithEvents lstGames2 As ListBox
    Friend WithEvents lstGames3 As ListBox
End Class
