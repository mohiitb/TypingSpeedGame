<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Me.Label_source1 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label_type1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label_timer = New System.Windows.Forms.Label()
        Me.Label_correctwords = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label_speed1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button_stop1 = New System.Windows.Forms.Button()
        Me.Button_restart1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button_start1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_source1
        '
        Me.Label_source1.AutoSize = True
        Me.Label_source1.BackColor = System.Drawing.Color.Transparent
        Me.Label_source1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_source1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label_source1.Location = New System.Drawing.Point(12, 31)
        Me.Label_source1.Name = "Label_source1"
        Me.Label_source1.Size = New System.Drawing.Size(98, 20)
        Me.Label_source1.TabIndex = 0
        Me.Label_source1.Text = "Source Text:"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(116, 31)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(483, 184)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'Label_type1
        '
        Me.Label_type1.AutoSize = True
        Me.Label_type1.BackColor = System.Drawing.Color.Transparent
        Me.Label_type1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_type1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label_type1.Location = New System.Drawing.Point(12, 242)
        Me.Label_type1.Name = "Label_type1"
        Me.Label_type1.Size = New System.Drawing.Size(86, 20)
        Me.Label_type1.TabIndex = 2
        Me.Label_type1.Text = "Type Here:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(116, 236)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(159, 23)
        Me.TextBox1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Correct Words:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Timer:"
        '
        'Label_timer
        '
        Me.Label_timer.AutoSize = True
        Me.Label_timer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_timer.Location = New System.Drawing.Point(146, 35)
        Me.Label_timer.Name = "Label_timer"
        Me.Label_timer.Size = New System.Drawing.Size(27, 20)
        Me.Label_timer.TabIndex = 6
        Me.Label_timer.Text = "00"
        '
        'Label_correctwords
        '
        Me.Label_correctwords.AutoSize = True
        Me.Label_correctwords.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_correctwords.Location = New System.Drawing.Point(146, 81)
        Me.Label_correctwords.Name = "Label_correctwords"
        Me.Label_correctwords.Size = New System.Drawing.Size(27, 20)
        Me.Label_correctwords.TabIndex = 7
        Me.Label_correctwords.Text = "00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Typing Speed:"
        '
        'Label_speed1
        '
        Me.Label_speed1.AutoSize = True
        Me.Label_speed1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_speed1.Location = New System.Drawing.Point(146, 127)
        Me.Label_speed1.Name = "Label_speed1"
        Me.Label_speed1.Size = New System.Drawing.Size(27, 20)
        Me.Label_speed1.TabIndex = 9
        Me.Label_speed1.Text = "00"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label_speed1)
        Me.GroupBox1.Controls.Add(Me.Label_timer)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label_correctwords)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(399, 242)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 165)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stats:"
        '
        'Button_stop1
        '
        Me.Button_stop1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button_stop1.BackgroundImage = Global.Typing.My.Resources.Resources.Capture
        Me.Button_stop1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_stop1.Location = New System.Drawing.Point(273, 369)
        Me.Button_stop1.Name = "Button_stop1"
        Me.Button_stop1.Size = New System.Drawing.Size(120, 38)
        Me.Button_stop1.TabIndex = 11
        Me.Button_stop1.Text = "Stop"
        Me.Button_stop1.UseVisualStyleBackColor = False
        '
        'Button_restart1
        '
        Me.Button_restart1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button_restart1.BackgroundImage = Global.Typing.My.Resources.Resources.Capture
        Me.Button_restart1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_restart1.Location = New System.Drawing.Point(138, 369)
        Me.Button_restart1.Name = "Button_restart1"
        Me.Button_restart1.Size = New System.Drawing.Size(120, 38)
        Me.Button_restart1.TabIndex = 12
        Me.Button_restart1.Text = "Restart Game"
        Me.Button_restart1.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Button_start1
        '
        Me.Button_start1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button_start1.BackgroundImage = Global.Typing.My.Resources.Resources.Capture
        Me.Button_start1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_start1.Location = New System.Drawing.Point(3, 369)
        Me.Button_start1.Name = "Button_start1"
        Me.Button_start1.Size = New System.Drawing.Size(120, 38)
        Me.Button_start1.TabIndex = 13
        Me.Button_start1.Text = "Start"
        Me.Button_start1.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(16, 329)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 17)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Previous HighScore:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Location = New System.Drawing.Point(180, 329)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 17)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "NA"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.Typing.My.Resources.Resources.Black_background_set_wood_on_chanconsultants_jpg
        Me.ClientSize = New System.Drawing.Size(611, 419)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button_start1)
        Me.Controls.Add(Me.Button_restart1)
        Me.Controls.Add(Me.Button_stop1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label_type1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label_source1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_source1 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label_type1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label_timer As System.Windows.Forms.Label
    Friend WithEvents Label_correctwords As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label_speed1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button_stop1 As System.Windows.Forms.Button
    Friend WithEvents Button_restart1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button_start1 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
