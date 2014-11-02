<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class high_scores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(high_scores))
        Me.Button_ok = New System.Windows.Forms.Button()
        Me.Label_heading = New System.Windows.Forms.Label()
        Me.Label_players = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label_p1 = New System.Windows.Forms.Label()
        Me.Label_p2 = New System.Windows.Forms.Label()
        Me.Label_s2 = New System.Windows.Forms.Label()
        Me.Label_p3 = New System.Windows.Forms.Label()
        Me.Label_s3 = New System.Windows.Forms.Label()
        Me.Label_p4 = New System.Windows.Forms.Label()
        Me.Label_s4 = New System.Windows.Forms.Label()
        Me.Label_p5 = New System.Windows.Forms.Label()
        Me.Label_s5 = New System.Windows.Forms.Label()
        Me.Label_s1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button_ok
        '
        Me.Button_ok.BackgroundImage = CType(resources.GetObject("Button_ok.BackgroundImage"), System.Drawing.Image)
        Me.Button_ok.Location = New System.Drawing.Point(125, 341)
        Me.Button_ok.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_ok.Name = "Button_ok"
        Me.Button_ok.Size = New System.Drawing.Size(100, 28)
        Me.Button_ok.TabIndex = 0
        Me.Button_ok.Text = "OK"
        Me.Button_ok.UseVisualStyleBackColor = True
        '
        'Label_heading
        '
        Me.Label_heading.AutoSize = True
        Me.Label_heading.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_heading.Location = New System.Drawing.Point(24, 9)
        Me.Label_heading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_heading.Name = "Label_heading"
        Me.Label_heading.Size = New System.Drawing.Size(149, 26)
        Me.Label_heading.TabIndex = 2
        Me.Label_heading.Text = "High Scores:"
        '
        'Label_players
        '
        Me.Label_players.AutoSize = True
        Me.Label_players.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label_players.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_players.Location = New System.Drawing.Point(74, 74)
        Me.Label_players.Name = "Label_players"
        Me.Label_players.Size = New System.Drawing.Size(62, 22)
        Me.Label_players.TabIndex = 4
        Me.Label_players.Text = "Players"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(220, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Scores"
        '
        'Label_p1
        '
        Me.Label_p1.AutoSize = True
        Me.Label_p1.Location = New System.Drawing.Point(71, 111)
        Me.Label_p1.Name = "Label_p1"
        Me.Label_p1.Size = New System.Drawing.Size(18, 17)
        Me.Label_p1.TabIndex = 7
        Me.Label_p1.Text = "--"
        '
        'Label_p2
        '
        Me.Label_p2.AutoSize = True
        Me.Label_p2.Location = New System.Drawing.Point(71, 151)
        Me.Label_p2.Name = "Label_p2"
        Me.Label_p2.Size = New System.Drawing.Size(18, 17)
        Me.Label_p2.TabIndex = 8
        Me.Label_p2.Text = "--"
        '
        'Label_s2
        '
        Me.Label_s2.AutoSize = True
        Me.Label_s2.Location = New System.Drawing.Point(222, 151)
        Me.Label_s2.Name = "Label_s2"
        Me.Label_s2.Size = New System.Drawing.Size(18, 17)
        Me.Label_s2.TabIndex = 9
        Me.Label_s2.Text = "--"
        '
        'Label_p3
        '
        Me.Label_p3.AutoSize = True
        Me.Label_p3.Location = New System.Drawing.Point(71, 191)
        Me.Label_p3.Name = "Label_p3"
        Me.Label_p3.Size = New System.Drawing.Size(18, 17)
        Me.Label_p3.TabIndex = 10
        Me.Label_p3.Text = "--"
        '
        'Label_s3
        '
        Me.Label_s3.AutoSize = True
        Me.Label_s3.Location = New System.Drawing.Point(222, 191)
        Me.Label_s3.Name = "Label_s3"
        Me.Label_s3.Size = New System.Drawing.Size(18, 17)
        Me.Label_s3.TabIndex = 11
        Me.Label_s3.Text = "--"
        '
        'Label_p4
        '
        Me.Label_p4.AutoSize = True
        Me.Label_p4.Location = New System.Drawing.Point(71, 231)
        Me.Label_p4.Name = "Label_p4"
        Me.Label_p4.Size = New System.Drawing.Size(18, 17)
        Me.Label_p4.TabIndex = 12
        Me.Label_p4.Text = "--"
        '
        'Label_s4
        '
        Me.Label_s4.AutoSize = True
        Me.Label_s4.Location = New System.Drawing.Point(222, 231)
        Me.Label_s4.Name = "Label_s4"
        Me.Label_s4.Size = New System.Drawing.Size(18, 17)
        Me.Label_s4.TabIndex = 13
        Me.Label_s4.Text = "--"
        '
        'Label_p5
        '
        Me.Label_p5.AutoSize = True
        Me.Label_p5.Location = New System.Drawing.Point(71, 271)
        Me.Label_p5.Name = "Label_p5"
        Me.Label_p5.Size = New System.Drawing.Size(18, 17)
        Me.Label_p5.TabIndex = 14
        Me.Label_p5.Text = "--"
        '
        'Label_s5
        '
        Me.Label_s5.AutoSize = True
        Me.Label_s5.Location = New System.Drawing.Point(222, 271)
        Me.Label_s5.Name = "Label_s5"
        Me.Label_s5.Size = New System.Drawing.Size(18, 17)
        Me.Label_s5.TabIndex = 15
        Me.Label_s5.Text = "--"
        '
        'Label_s1
        '
        Me.Label_s1.AutoSize = True
        Me.Label_s1.Location = New System.Drawing.Point(222, 111)
        Me.Label_s1.Name = "Label_s1"
        Me.Label_s1.Size = New System.Drawing.Size(18, 17)
        Me.Label_s1.TabIndex = 16
        Me.Label_s1.Text = "--"
        '
        'high_scores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 390)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label_s1)
        Me.Controls.Add(Me.Label_s5)
        Me.Controls.Add(Me.Label_p5)
        Me.Controls.Add(Me.Label_s4)
        Me.Controls.Add(Me.Label_p4)
        Me.Controls.Add(Me.Label_s3)
        Me.Controls.Add(Me.Label_p3)
        Me.Controls.Add(Me.Label_s2)
        Me.Controls.Add(Me.Label_p2)
        Me.Controls.Add(Me.Label_p1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label_players)
        Me.Controls.Add(Me.Label_heading)
        Me.Controls.Add(Me.Button_ok)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "high_scores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "high_scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_ok As System.Windows.Forms.Button
    Friend WithEvents Label_heading As System.Windows.Forms.Label
    Friend WithEvents Label_players As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label_p1 As System.Windows.Forms.Label
    Friend WithEvents Label_p2 As System.Windows.Forms.Label
    Friend WithEvents Label_s2 As System.Windows.Forms.Label
    Friend WithEvents Label_p3 As System.Windows.Forms.Label
    Friend WithEvents Label_s3 As System.Windows.Forms.Label
    Friend WithEvents Label_p4 As System.Windows.Forms.Label
    Friend WithEvents Label_s4 As System.Windows.Forms.Label
    Friend WithEvents Label_p5 As System.Windows.Forms.Label
    Friend WithEvents Label_s5 As System.Windows.Forms.Label
    Friend WithEvents Label_s1 As System.Windows.Forms.Label
End Class
