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
        Me.Button_single = New System.Windows.Forms.Button()
        Me.Button_inst = New System.Windows.Forms.Button()
        Me.Button_score = New System.Windows.Forms.Button()
        Me.Button_quit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_double = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_single
        '
        Me.Button_single.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_single.BackgroundImage = Global.Typing.My.Resources.Resources.Capture
        Me.Button_single.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_single.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_single.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_single.Location = New System.Drawing.Point(116, 215)
        Me.Button_single.Name = "Button_single"
        Me.Button_single.Size = New System.Drawing.Size(116, 32)
        Me.Button_single.TabIndex = 0
        Me.Button_single.Text = "Single Player"
        Me.Button_single.UseVisualStyleBackColor = True
        '
        'Button_inst
        '
        Me.Button_inst.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_inst.BackgroundImage = Global.Typing.My.Resources.Resources.Capture
        Me.Button_inst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_inst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_inst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_inst.Location = New System.Drawing.Point(243, 257)
        Me.Button_inst.Name = "Button_inst"
        Me.Button_inst.Size = New System.Drawing.Size(106, 32)
        Me.Button_inst.TabIndex = 1
        Me.Button_inst.Text = "How Tos"
        Me.Button_inst.UseVisualStyleBackColor = True
        '
        'Button_score
        '
        Me.Button_score.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_score.BackgroundImage = Global.Typing.My.Resources.Resources.Capture
        Me.Button_score.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_score.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_score.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_score.Location = New System.Drawing.Point(243, 311)
        Me.Button_score.Name = "Button_score"
        Me.Button_score.Size = New System.Drawing.Size(106, 32)
        Me.Button_score.TabIndex = 2
        Me.Button_score.Text = "High Scores"
        Me.Button_score.UseVisualStyleBackColor = True
        '
        'Button_quit
        '
        Me.Button_quit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_quit.BackgroundImage = Global.Typing.My.Resources.Resources.Capture
        Me.Button_quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_quit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_quit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_quit.Location = New System.Drawing.Point(243, 365)
        Me.Button_quit.Name = "Button_quit"
        Me.Button_quit.Size = New System.Drawing.Size(106, 32)
        Me.Button_quit.TabIndex = 3
        Me.Button_quit.Text = "Quit"
        Me.Button_quit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Stencil", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(140, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "WELCOME TO TYPETEST"
        '
        'Button_double
        '
        Me.Button_double.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_double.BackgroundImage = Global.Typing.My.Resources.Resources.Capture
        Me.Button_double.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_double.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_double.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_double.Location = New System.Drawing.Point(356, 215)
        Me.Button_double.Name = "Button_double"
        Me.Button_double.Size = New System.Drawing.Size(116, 32)
        Me.Button_double.TabIndex = 5
        Me.Button_double.Text = "Double Player"
        Me.Button_double.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Typing.My.Resources.Resources.FastTyping
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(37, 75)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(524, 134)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.Typing.My.Resources.Resources.Black_background_set_wood_on_chanconsultants_jpg
        Me.ClientSize = New System.Drawing.Size(611, 419)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button_double)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_quit)
        Me.Controls.Add(Me.Button_score)
        Me.Controls.Add(Me.Button_inst)
        Me.Controls.Add(Me.Button_single)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_single As System.Windows.Forms.Button
    Friend WithEvents Button_inst As System.Windows.Forms.Button
    Friend WithEvents Button_score As System.Windows.Forms.Button
    Friend WithEvents Button_quit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button_double As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
