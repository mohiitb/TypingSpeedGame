Imports System
Imports System.IO
Imports System.Text

Public Class Form2

    Dim correct_words As Integer = 0                'correct no. of words of player in single player mode
    Dim seconds As Integer = 0                      'number of seconds passed so far
    Dim speed As Double = 0                         'to store speed of the players
    Dim words_array As String()                     'to store each word of text file to be used as source excluding the space
    Dim i As Integer = 0                            'integer used as variable

    Private Sub Form2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        Me.Focus()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button_restart1.Enabled = False  'before starting game user can't press restart button,
        Button_stop1.Enabled = False      'stop button,
        TextBox1.Enabled = False         'textbox1, where text is to be typed is disabled
        RichTextBox1.Enabled = False    ' and richtextbox1, where text to be typed is shown
    End Sub

    Private Sub Button_start1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_start1.Click
        Timer1.Start()                      'start the timer
        Button_start1.Enabled = False       ' if timer starts, start button is disabled,
        RichTextBox1.Enabled = True         ' richtextbox1 enabled
        Button_restart1.Enabled = True      'restart button enabled
        Button_stop1.Enabled = True         'stop button enabled
        TextBox1.Enabled = True             'textbox1 enabled
        Dim y As Integer
        Randomize()
        y = Rnd() * 9                       'to generate random numbers between 0 to 9 to get index of form1.paths
        If y = 0 Then
            RichTextBox1.Text = My.Resources.story1             'reads all the text and store it in richtextbox1
            Dim tempStr As String = RichTextBox1.Text   'read all text into a String.
            words_array = tempStr.Split()               'split the above string and store it in an array
            TextBox1.Focus()
        ElseIf y = 1 Then
            RichTextBox1.Text = My.Resources.story2             'reads all the text and store it in richtextbox1
            Dim tempStr As String = RichTextBox1.Text   'read all text into a String.
            words_array = tempStr.Split()               'split the above string and store it in an array
            TextBox1.Focus()
        ElseIf y = 2 Then
            RichTextBox1.Text = My.Resources.story3             'reads all the text and store it in richtextbox1
            Dim tempStr As String = RichTextBox1.Text   'read all text into a String.
            words_array = tempStr.Split()               'split the above string and store it in an array
            TextBox1.Focus()
        ElseIf y = 3 Then
            RichTextBox1.Text = My.Resources.story4             'reads all the text and store it in richtextbox1
            Dim tempStr As String = RichTextBox1.Text   'read all text into a String.
            words_array = tempStr.Split()               'split the above string and store it in an array
            TextBox1.Focus()
        ElseIf y = 4 Then
            RichTextBox1.Text = My.Resources.story5             'reads all the text and store it in richtextbox1
            Dim tempStr As String = RichTextBox1.Text   'read all text into a String.
            words_array = tempStr.Split()               'split the above string and store it in an array
            TextBox1.Focus()
        ElseIf y = 5 Then
            RichTextBox1.Text = My.Resources.story6             'reads all the text and store it in richtextbox1
            Dim tempStr As String = RichTextBox1.Text   'read all text into a String.
            words_array = tempStr.Split()               'split the above string and store it in an array
            TextBox1.Focus()
        ElseIf y = 6 Then
            RichTextBox1.Text = My.Resources.story7             'reads all the text and store it in richtextbox1
            Dim tempStr As String = RichTextBox1.Text   'read all text into a String.
            words_array = tempStr.Split()               'split the above string and store it in an array
            TextBox1.Focus()
        ElseIf y = 7 Then
            RichTextBox1.Text = My.Resources.story8             'reads all the text and store it in richtextbox1
            Dim tempStr As String = RichTextBox1.Text   'read all text into a String.
            words_array = tempStr.Split()               'split the above string and store it in an array
            TextBox1.Focus()
        ElseIf y = 8 Then
            RichTextBox1.Text = My.Resources.story9             'reads all the text and store it in richtextbox1
            Dim tempStr As String = RichTextBox1.Text   'read all text into a String.
            words_array = tempStr.Split()               'split the above string and store it in an array
            TextBox1.Focus()
        Else
            RichTextBox1.Text = My.Resources.story10             'reads all the text and store it in richtextbox1
            Dim tempStr As String = RichTextBox1.Text   'read all text into a String.
            words_array = tempStr.Split()               'split the above string and store it in an array
            TextBox1.Focus()
        End If
        
    End Sub

    Private Sub Button_stop1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_stop1.Click
        Timer1.Stop()     'if stop button is clicked, form1 will be shown again and this form will be closed
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        Dim index As Integer = 0
        Select Case e.KeyValue
            Case Keys.Space
                e.SuppressKeyPress = Keys.Enter
                RichTextBox1.Clear()        'clear the Richtextbox1 each time space is pressed and 
                For index = i + 1 To words_array.Count - 1  'loop from i+1 to size of words_array - 1
                    RichTextBox1.Text = RichTextBox1.Text & " " & words_array(index)    'store all text again skiping the first word
                Next index
                If words_array(i) = TextBox1.Text Then              'if text typed in textbox1 is same as the first word in richtextbox1,
                    TextBox1.BackColor = Color.Yellow               'make color of textbox yellow
                    correct_words += 1                              'and increase number of correct words by 1
                    If i < words_array.Count Then
                        i += 1                                   'i is incremented each time as first word of richtextbox is skipped each time space is pressed       
                    End If
                ElseIf TextBox1.Text = "" Then
                    i = i                                       ' i is unchanged if only space is pressed
                Else
                    TextBox1.BackColor = Color.Red          'if typed word is incorrect make color to red
                    If i < words_array.Count Then
                        i += 1                                   'i is incremented each time as first word of richtextbox is skipped each time space is pressed       
                    End If
                End If
                
                TextBox1.Clear()                'clear the textbox1 each time space is pressed
        End Select

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        seconds += 1            'interval is set to 1000 miliseconds, so increase second each time after 1 second interval 
        speed = correct_words * 60 / seconds        'store speed 
        Label_correctwords.Text = correct_words     'this will show number of correct words to user
        Label_speed1.Text = speed
        If seconds = 10 Then                        'time limit set to this much seconds
            Timer1.Stop()                           'after this, stop the timer
            If Form1.size_out > 0 Then              'if size of highscore file or, form1.output array was greater than 0, i.e. if there was some text in highscore file then consider this 
                'all the below if-else statements are used to show the updated scores of the users 
                If Form1.output(1) < speed Then
                    MsgBox("Congratulations! You made a new highscore!")
                End If
                If Form1.size_out = 2 Then
                    ReDim Preserve Form1.output(Form1.size_out + 2)  'in each if-else, except for the lastone, form1.output array is reallocated size
                    If CDbl(Form1.output(1)) >= speed Then
                        Form1.output(2) = Form1.names
                        Form1.output(3) = speed
                    Else
                        Form1.output(2) = Form1.output(0)
                        Form1.output(3) = Form1.output(1)
                        Form1.output(0) = Form1.names
                        Form1.output(1) = speed
                    End If
                    Form1.size_out = 4
                ElseIf Form1.size_out = 4 Then
                    ReDim Preserve Form1.output(Form1.size_out + 2)
                    If CDbl(Form1.output(1)) >= speed Then
                        If CDbl(Form1.output(3)) >= speed Then
                            Form1.output(4) = Form1.names
                            Form1.output(5) = speed

                        Else
                            Form1.output(4) = Form1.output(2)
                            Form1.output(5) = Form1.output(3)
                            Form1.output(2) = Form1.names
                            Form1.output(3) = speed
                        End If
                    Else
                        Form1.output(4) = Form1.output(2)
                        Form1.output(5) = Form1.output(3)
                        Form1.output(2) = Form1.output(0)
                        Form1.output(3) = Form1.output(1)
                        Form1.output(0) = Form1.names
                        Form1.output(1) = speed
                    End If
                    Form1.size_out = 6
                ElseIf Form1.size_out = 6 Then
                    ReDim Preserve Form1.output(Form1.size_out + 2)
                    If CDbl(Form1.output(1)) >= speed Then
                        If CDbl(Form1.output(3)) >= speed Then
                            If CDbl(Form1.output(5)) >= speed Then
                                Form1.output(6) = Form1.names
                                Form1.output(7) = speed
                            Else
                                Form1.output(6) = Form1.output(4)
                                Form1.output(7) = Form1.output(5)
                                Form1.output(4) = Form1.names
                                Form1.output(5) = speed
                            End If
                        Else
                            Form1.output(6) = Form1.output(4)
                            Form1.output(7) = Form1.output(5)
                            Form1.output(4) = Form1.output(2)
                            Form1.output(5) = Form1.output(3)
                            Form1.output(2) = Form1.names
                            Form1.output(3) = speed
                        End If
                    Else
                        Form1.output(6) = Form1.output(4)
                        Form1.output(7) = Form1.output(5)
                        Form1.output(4) = Form1.output(2)
                        Form1.output(5) = Form1.output(3)
                        Form1.output(2) = Form1.output(0)
                        Form1.output(3) = Form1.output(1)
                        Form1.output(0) = Form1.names
                        Form1.output(1) = speed
                    End If
                    Form1.size_out = 8
                ElseIf Form1.size_out = 8 Then
                    ReDim Preserve Form1.output(Form1.size_out + 2)
                    If CDbl(Form1.output(1)) >= speed Then
                        If CDbl(Form1.output(3)) >= speed Then
                            If CDbl(Form1.output(5)) >= speed Then
                                If CDbl(Form1.output(7)) >= speed Then
                                    Form1.output(8) = Form1.names
                                    Form1.output(9) = speed
                                Else
                                    Form1.output(8) = Form1.output(6)
                                    Form1.output(9) = Form1.output(7)
                                    Form1.output(6) = Form1.names
                                    Form1.output(7) = speed
                                End If
                            Else
                                Form1.output(8) = Form1.output(6)
                                Form1.output(9) = Form1.output(7)
                                Form1.output(6) = Form1.output(4)
                                Form1.output(7) = Form1.output(5)
                                Form1.output(4) = Form1.names
                                Form1.output(5) = speed
                            End If
                        Else
                            Form1.output(8) = Form1.output(6)
                            Form1.output(9) = Form1.output(7)
                            Form1.output(6) = Form1.output(4)
                            Form1.output(7) = Form1.output(5)
                            Form1.output(4) = Form1.output(2)
                            Form1.output(5) = Form1.output(3)
                            Form1.output(2) = Form1.names
                            Form1.output(3) = speed
                        End If
                    Else
                        Form1.output(8) = Form1.output(6)
                        Form1.output(9) = Form1.output(7)
                        Form1.output(6) = Form1.output(4)
                        Form1.output(7) = Form1.output(5)
                        Form1.output(4) = Form1.output(2)
                        Form1.output(5) = Form1.output(3)
                        Form1.output(2) = Form1.output(0)
                        Form1.output(3) = Form1.output(1)
                        Form1.output(0) = Form1.names
                        Form1.output(1) = speed
                    End If
                    Form1.size_out = 10
                ElseIf Form1.size_out = 10 Then
                    If CDbl(Form1.output(1)) >= speed Then
                        If CDbl(Form1.output(3)) >= speed Then
                            If CDbl(Form1.output(5)) >= speed Then
                                If CDbl(Form1.output(7)) >= speed Then
                                    If CDbl(Form1.output(9)) < speed Then
                                        Form1.output(8) = Form1.names
                                        Form1.output(9) = speed
                                    End If
                                Else
                                    Form1.output(8) = Form1.output(6)
                                    Form1.output(9) = Form1.output(7)
                                    Form1.output(6) = Form1.names
                                    Form1.output(7) = speed
                                End If
                            Else
                                Form1.output(8) = Form1.output(6)
                                Form1.output(9) = Form1.output(7)
                                Form1.output(6) = Form1.output(4)
                                Form1.output(7) = Form1.output(5)
                                Form1.output(4) = Form1.names
                                Form1.output(5) = speed
                            End If
                        Else
                            Form1.output(8) = Form1.output(6)
                            Form1.output(9) = Form1.output(7)
                            Form1.output(6) = Form1.output(4)
                            Form1.output(7) = Form1.output(5)
                            Form1.output(4) = Form1.output(2)
                            Form1.output(5) = Form1.output(3)
                            Form1.output(2) = Form1.names
                            Form1.output(3) = speed
                        End If
                    Else
                        Form1.output(8) = Form1.output(6)
                        Form1.output(9) = Form1.output(7)
                        Form1.output(6) = Form1.output(4)
                        Form1.output(7) = Form1.output(5)
                        Form1.output(4) = Form1.output(2)
                        Form1.output(5) = Form1.output(3)
                        Form1.output(2) = Form1.output(0)
                        Form1.output(3) = Form1.output(1)
                        Form1.output(0) = Form1.names
                        Form1.output(1) = speed
                    End If
                    Form1.size_out = 10
                End If
                'once the timer stops following fields are enabled and disabled
                TextBox1.Clear()
                RichTextBox1.Clear()
                TextBox1.Enabled = False
                RichTextBox1.Enabled = False
                'first highscores.txt file is deleted and then again created
                Dim appPath As String = Application.StartupPath()
                My.Computer.FileSystem.DeleteFile(appPath & "\highscores.txt")
                Dim fs As FileStream = File.Create(appPath & "\highscores.txt")
                fs.Close()

                Dim intex As Integer = 0
                'store the updated scores and name of the players in the file highscores.txt file
                While intex < Form1.size_out
                    My.Computer.FileSystem.WriteAllText(appPath & "\highscores.txt", Form1.output(intex) & "*" & Form1.output(intex + 1), True)
                    intex += 2
                    If intex < Form1.size_out - 1 Then   'if it is not the last name and scores, append "*" with the above text
                        My.Computer.FileSystem.WriteAllText(appPath & "\highscores.txt", "*", True)
                    End If
                End While
            Else
                'if highscores.txt file is empty, store the name and scores as below
                ReDim Form1.output(2)
                Form1.size_out = 2
                Dim appPath1 As String = Application.StartupPath()
                Form1.output(0) = Form1.names
                Form1.output(1) = speed
                Dim ft As New StreamWriter(appPath1 & "\highscores.txt")
                ft.WriteLine(Form1.output(0) & "*" & Form1.output(1))
                ft.Close()
            End If
            Dim accuracy As Double = 0
            accuracy = correct_words / i * 100
            MsgBox("Stats " & vbCrLf & Form1.name1 & vbCrLf & "Accuracy: " & accuracy & vbCrLf & "Speed(wpm): " & speed)
        End If

        Label_timer.Text = seconds  'to show the time passed so far
    End Sub

    Private Sub Button_restart1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_restart1.Click
        'restart the game with same user
        seconds = 0
        correct_words = 0
        speed = 0
        i = 0
        Timer1.Start()
        Button_start1.Enabled = False
        RichTextBox1.Enabled = True
        TextBox1.Enabled = True
        Dim y As Integer
        Randomize()
        y = Rnd() * 9
        If y = 0 Then
            Dim R As New IO.StreamReader(My.Resources.story1)
            RichTextBox1.Text = R.ReadToEnd
            Dim tempStr As String = RichTextBox1.Text '// read text into a String.
            words_array = tempStr.Split()
            R.Close()
            TextBox1.Focus()
        ElseIf y = 1 Then
            Dim R As New IO.StreamReader(My.Resources.story2)
            RichTextBox1.Text = R.ReadToEnd
            Dim tempStr As String = RichTextBox1.Text '// read text into a String.
            words_array = tempStr.Split()
            R.Close()
            TextBox1.Focus()
        ElseIf y = 2 Then
            Dim R As New IO.StreamReader(My.Resources.story3)
            RichTextBox1.Text = R.ReadToEnd
            Dim tempStr As String = RichTextBox1.Text '// read text into a String.
            words_array = tempStr.Split()
            R.Close()
            TextBox1.Focus()
        ElseIf y = 3 Then
            Dim R As New IO.StreamReader(My.Resources.story4)
            RichTextBox1.Text = R.ReadToEnd
            Dim tempStr As String = RichTextBox1.Text '// read text into a String.
            words_array = tempStr.Split()
            R.Close()
            TextBox1.Focus()
        ElseIf y = 4 Then
            Dim R As New IO.StreamReader(My.Resources.story5)
            RichTextBox1.Text = R.ReadToEnd
            Dim tempStr As String = RichTextBox1.Text '// read text into a String.
            words_array = tempStr.Split()
            R.Close()
            TextBox1.Focus()
        ElseIf y = 5 Then
            Dim R As New IO.StreamReader(My.Resources.story6)
            RichTextBox1.Text = R.ReadToEnd
            Dim tempStr As String = RichTextBox1.Text '// read text into a String.
            words_array = tempStr.Split()
            R.Close()
            TextBox1.Focus()
        ElseIf y = 6 Then
            Dim R As New IO.StreamReader(My.Resources.story7)
            RichTextBox1.Text = R.ReadToEnd
            Dim tempStr As String = RichTextBox1.Text '// read text into a String.
            words_array = tempStr.Split()
            R.Close()
            TextBox1.Focus()
        ElseIf y = 7 Then
            Dim R As New IO.StreamReader(My.Resources.story8)
            RichTextBox1.Text = R.ReadToEnd
            Dim tempStr As String = RichTextBox1.Text '// read text into a String.
            words_array = tempStr.Split()
            R.Close()
            TextBox1.Focus()
        ElseIf y = 8 Then
            Dim R As New IO.StreamReader(My.Resources.story9)
            RichTextBox1.Text = R.ReadToEnd
            Dim tempStr As String = RichTextBox1.Text '// read text into a String.
            words_array = tempStr.Split()
            R.Close()
            TextBox1.Focus()
        Else
            Dim R As New IO.StreamReader(My.Resources.story10)
            RichTextBox1.Text = R.ReadToEnd
            Dim tempStr As String = RichTextBox1.Text '// read text into a String.
            words_array = tempStr.Split()
            R.Close()
            TextBox1.Focus()
        End If
        
    End Sub

    Private Sub Label10_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label10.VisibleChanged
        If Form1.size_out > 0 Then
            Label10.Text = Form1.output(1) & " by " & Form1.output(0) 'show the top score made previously 
        End If
    End Sub
End Class