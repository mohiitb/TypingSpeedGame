<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Label2_speedp2 = New System.Windows.Forms.Label()
        Me.Label2_speedp1 = New System.Windows.Forms.Label()
        Me.Label2_p2 = New System.Windows.Forms.Label()
        Me.Label2_p1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2_seconds1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2_correct1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2_start1 = New System.Windows.Forms.Button()
        Me.Button2_back = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2_speedp2
        '
        Me.Label2_speedp2.AutoSize = True
        Me.Label2_speedp2.BackColor = System.Drawing.Color.Transparent
        Me.Label2_speedp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_speedp2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2_speedp2.Location = New System.Drawing.Point(103, 330)
        Me.Label2_speedp2.Name = "Label2_speedp2"
        Me.Label2_speedp2.Size = New System.Drawing.Size(24, 17)
        Me.Label2_speedp2.TabIndex = 32
        Me.Label2_speedp2.Text = "00"
        '
        'Label2_speedp1
        '
        Me.Label2_speedp1.AutoSize = True
        Me.Label2_speedp1.BackColor = System.Drawing.Color.Transparent
        Me.Label2_speedp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_speedp1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2_speedp1.Location = New System.Drawing.Point(103, 295)
        Me.Label2_speedp1.Name = "Label2_speedp1"
        Me.Label2_speedp1.Size = New System.Drawing.Size(24, 17)
        Me.Label2_speedp1.TabIndex = 31
        Me.Label2_speedp1.Text = "00"
        '
        'Label2_p2
        '
        Me.Label2_p2.AutoSize = True
        Me.Label2_p2.BackColor = System.Drawing.Color.Transparent
        Me.Label2_p2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_p2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2_p2.Location = New System.Drawing.Point(13, 330)
        Me.Label2_p2.Name = "Label2_p2"
        Me.Label2_p2.Size = New System.Drawing.Size(60, 17)
        Me.Label2_p2.TabIndex = 30
        Me.Label2_p2.Text = "Player2:"
        '
        'Label2_p1
        '
        Me.Label2_p1.AutoSize = True
        Me.Label2_p1.BackColor = System.Drawing.Color.Transparent
        Me.Label2_p1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_p1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2_p1.Location = New System.Drawing.Point(13, 295)
        Me.Label2_p1.Name = "Label2_p1"
        Me.Label2_p1.Size = New System.Drawing.Size(64, 17)
        Me.Label2_p1.TabIndex = 29
        Me.Label2_p1.Text = "Player1: "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2_seconds1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2_correct1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(399, 295)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 116)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stats:"
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
        'Label2_seconds1
        '
        Me.Label2_seconds1.AutoSize = True
        Me.Label2_seconds1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_seconds1.Location = New System.Drawing.Point(146, 35)
        Me.Label2_seconds1.Name = "Label2_seconds1"
        Me.Label2_seconds1.Size = New System.Drawing.Size(27, 20)
        Me.Label2_seconds1.TabIndex = 6
        Me.Label2_seconds1.Text = "00"
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
        'Label2_correct1
        '
        Me.Label2_correct1.AutoSize = True
        Me.Label2_correct1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_correct1.Location = New System.Drawing.Point(146, 81)
        Me.Label2_correct1.Name = "Label2_correct1"
        Me.Label2_correct1.Size = New System.Drawing.Size(27, 20)
        Me.Label2_correct1.TabIndex = 7
        Me.Label2_correct1.Text = "00"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(116, 219)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(159, 23)
        Me.TextBox1.TabIndex = 24
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(116, 24)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(483, 184)
        Me.RichTextBox1.TabIndex = 23
        Me.RichTextBox1.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(12, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Type here:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Source Text:"
        '
        'Button2_start1
        '
        Me.Button2_start1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2_start1.BackgroundImage = Global.Typing.My.Resources.Resources.Capture
        Me.Button2_start1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2_start1.Location = New System.Drawing.Point(12, 373)
        Me.Button2_start1.Name = "Button2_start1"
        Me.Button2_start1.Size = New System.Drawing.Size(120, 38)
        Me.Button2_start1.TabIndex = 28
        Me.Button2_start1.Text = "Start"
        Me.Button2_start1.UseVisualStyleBackColor = False
        '
        'Button2_back
        '
        Me.Button2_back.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2_back.BackgroundImage = Global.Typing.My.Resources.Resources.Capture
        Me.Button2_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2_back.Location = New System.Drawing.Point(138, 373)
        Me.Button2_back.Name = "Button2_back"
        Me.Button2_back.Size = New System.Drawing.Size(120, 38)
        Me.Button2_back.TabIndex = 26
        Me.Button2_back.Text = "Back"
        Me.Button2_back.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Typing.My.Resources.Resources.Black_background_set_wood_on_chanconsultants_jpg
        Me.ClientSize = New System.Drawing.Size(628, 426)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2_speedp2)
        Me.Controls.Add(Me.Label2_speedp1)
        Me.Controls.Add(Me.Label2_p2)
        Me.Controls.Add(Me.Label2_p1)
        Me.Controls.Add(Me.Button2_start1)
        Me.Controls.Add(Me.Button2_back)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2_speedp2 As System.Windows.Forms.Label
    Friend WithEvents Label2_speedp1 As System.Windows.Forms.Label
    Friend WithEvents Label2_p2 As System.Windows.Forms.Label
    Friend WithEvents Label2_p1 As System.Windows.Forms.Label
    Friend WithEvents Button2_start1 As System.Windows.Forms.Button
    Friend WithEvents Button2_back As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2_seconds1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2_correct1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
