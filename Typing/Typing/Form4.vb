Public Class Form4

    'All the variables used are similar to that use in previous forms
    Dim seconds1 As Integer = 60
    Dim words1_array As String()
    Dim speed2 As Double = 0
    Dim i1 As Integer = 0
    Dim sec As Integer = 0
    Public speed12 As Double                'stores the speed of player1 from form3
    Dim wrong As Integer = 0
    Private Sub Button2_start1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2_start1.Click
        Timer1.Start()
        wrong = 0
        Label2_p1.Text = Form1.name1
        Label2_p2.Text = Form1.name2
        Form3.correct_words1 = 0
        Timer1.Start()
        Button2_start1.Enabled = False
        RichTextBox1.Enabled = True
        Button2_back.Enabled = True
        TextBox1.Enabled = True
        Dim y As Integer
        Randomize()
        y = Rnd() * 9
        If y = 0 Then
            RichTextBox1.Text = My.Resources.story1
            Dim tempStr As String = RichTextBox1.Text '// read text into a String.
            words1_array = tempStr.Split()
            TextBox1.Focus()
        ElseIf y = 1 Then
            RichTextBox1.Text = My.Resources.story2
            Dim tempStr As String = RichTextBox1.Text '// read text into a String.
            words1_array = tempStr.Split()
            TextBox1.Focus()
        ElseIf y = 2 Then
            RichTextBox1.Text = My.Resources.story3
            Dim tempStr As String = RichTextBox1.Text '// read text into a String.
            words1_array = tempStr.Split()
            TextBox1.Focus()
        ElseIf y = 3 Then
            RichTextBox1.Text = My.Resources.story4
            Dim tempStr As String = RichTextBox1.Text '// read text into a String.
            words1_array = tempStr.Split()
            TextBox1.Focus()
        ElseIf y = 4 Then
            RichTextBox1.Text = My.Resources.story5
            Dim tempStr As String = RichTextBox1.Text '// read text into a String.
            words1_array = tempStr.Split()
            TextBox1.Focus()
        ElseIf y = 5 Then
            RichTextBox1.Text = My.Resources.story6
            Dim tempStr As String = RichTextBox1.Text '// read text into a String.
            words1_array = tempStr.Split()
            TextBox1.Focus()
        ElseIf y = 6 Then
            RichTextBox1.Text = My.Resources.story7
            Dim tempStr As String = RichTextBox1.Text '// read text into a String.
            words1_array = tempStr.Split()
            TextBox1.Focus()
        ElseIf y = 7 Then
            RichTextBox1.Text = My.Resources.story8
            Dim tempStr As String = RichTextBox1.Text '// read text into a String.
            words1_array = tempStr.Split()
            TextBox1.Focus()
        ElseIf y = 8 Then
            RichTextBox1.Text = My.Resources.story9
            Dim tempStr As String = RichTextBox1.Text '// read text into a String.
            words1_array = tempStr.Split()
            TextBox1.Focus()
        Else
            RichTextBox1.Text = My.Resources.story10
            Dim tempStr As String = RichTextBox1.Text '// read text into a String.
            words1_array = tempStr.Split()
            TextBox1.Focus()
        End If
        
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        Dim index As Integer

        Select Case e.KeyValue
            Case Keys.Space
                e.SuppressKeyPress = Keys.Enter
                RichTextBox1.Clear()
                For index = i1 + 1 To words1_array.Count - 1
                    RichTextBox1.Text = RichTextBox1.Text & " " & words1_array(index)
                Next index
                If words1_array(i1) = TextBox1.Text Then
                    TextBox1.BackColor = Color.Yellow
                    Form3.correct_words1 += 1
                    If i1 < words1_array.Count Then
                        i1 += 1
                    End If

                Else
                    RichTextBox1.Text = words1_array(i1)
                    wrong += 1
                    TextBox1.BackColor = Color.Red
                End If
                TextBox1.Clear()
        End Select
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        seconds1 -= 1
        sec += 1
        speed2 = Form3.correct_words1 * 60 / sec
        Label2_correct1.Text = Form3.correct_words1
        Label2_speedp1.Text = speed12       'shows the speed of player1 from form 3
        Label2_speedp2.Text = speed2        'shows the speed of player2 
        If seconds1 = 0 Then
            Timer1.Stop()
            TextBox1.Clear()
            RichTextBox1.Clear()
            Label2_speedp2.Text = speed2
            TextBox1.Enabled = False
            RichTextBox1.Enabled = False
            If speed12 > speed2 Then
                MsgBox(Form1.name1 & " won!")
            ElseIf speed12 = speed2 Then
                MsgBox("Its a tie! What a Game!")
            Else
                MsgBox(Form1.name2 & " won!")
            End If
            Form3.correct_words1 = 0
            seconds1 = 0
        End If
        Label2_seconds1.Text = seconds1
    End Sub

    Private Sub Button2_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2_back.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RichTextBox1.Enabled = False
        TextBox1.Enabled = False
        Label2_speedp1.Text = speed12
    End Sub
End Class