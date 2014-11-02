Public Class Form3
    Public correct_words1 As Integer = 0            'to store correct words
    Dim seconds1 As Integer = 60                     'to store the time passed 
    Public speed1 As Double                         'to store speed
    Dim words1_array As String()                    'to store each word of text file to be used as source excluding the space
    Dim i1 As Integer = 0
    Dim sec As Integer = 0
    Dim wrong As Integer = 0
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button_next.Enabled = False
        TextBox1.Enabled = False
        RichTextBox1.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_back.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_start1.Click
        Label1_p1.Text = Form1.name1        'dispalys the name of player1
        Label1_p2.Text = Form1.name2        'displayes the name of player2 
        Timer1.Start()
        wrong = 0
        Button_start1.Enabled = False
        RichTextBox1.Enabled = True
        Button_back.Enabled = True
        Button_next.Enabled = False
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

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        seconds1 -= 1
        sec += 1
        speed1 = correct_words1 * 60 / sec
        Label_correct1.Text = correct_words1
        Label_speedp1.Text = speed1
        If seconds1 = 0 Then
            Timer1.Stop()
            Button_next.Enabled = True
            Button_next.Focus()
            TextBox1.Clear()
            RichTextBox1.Clear()
            Label_speedp1.Text = speed1
            Form4.speed12 = speed1
            TextBox1.Enabled = False
            RichTextBox1.Enabled = False
            correct_words1 = 0
            seconds1 = 0
        End If
        Label_seconds1.Text = seconds1
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        'same operations as in form1
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
                    correct_words1 += 1
                    If i1 < words1_array.Count Then
                        i1 += 1
                    End If
                ElseIf words1_array(i1) = "" Then
                    RichTextBox1.Text = words1_array(i1)
                    wrong += 1
                Else
                    RichTextBox1.Text = words1_array(i1)
                    wrong += 1
                    TextBox1.BackColor = Color.Red
                    
                End If
                
                TextBox1.Clear()
        End Select
    End Sub

    Private Sub Button_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_next.Click
        Me.Close()
        Form4.Show()
    End Sub

End Class