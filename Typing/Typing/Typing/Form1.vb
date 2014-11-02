Imports System.IO

Public Class Form1
    Public name1 As String = Nothing                    'Incase of double players, to store name of player 1
    Public name2 As String = Nothing                    ' and player 2
    Public names As String                              'Incase of single player, to store name of player 
    Public check As Integer = 1
    Public output() As String                           'To store each string inside highscores.txt file
    Public size_out As Integer = -1                     'To store size of highscores.txt file excluding spaces and "*" sign
    'Public filereader As String                         'To get file path of highscores.txt and read it
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim appPath As String = Application.StartupPath()
        Dim filereader As StreamReader
        filereader = New StreamReader(appPath & "\highscores.txt")
        Dim read_new As String
        read_new = filereader.ReadToEnd
        If read_new = "" Then
            check = 0                                   'check = 0 if highscores.txt is empty
        Else
            output = read_new.Split("*")              'split the whole text with "*" sign and put each string in output() array
            size_out = output.Count                     'To store size of highscores.txt file excluding spaces and "*" sign
        End If
    End Sub

    Private Sub Button_single_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_single.Click
        'single player button
        names = InputBox("Enter Player Name:")      'Enter name of player
        If names = "" Then
            MsgBox("Enter Some Text!", MsgBoxStyle.Exclamation)     'If name is not written, shows warning
        Else
            MsgBox("Welcome " & names & "!", MsgBoxStyle.OkOnly)    'else moves to form2 and hides this form
            Me.Hide()
            Form2.Show()
        End If

    End Sub

    Private Sub Button_inst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_inst.Click
        'shows instructions on how to play game
        MsgBox("1.First select the game: Single or Double Player." & vbCrLf & "2.Then type the player name." & vbCrLf & "3.Then type the text shown as text source in the box and press space bar after typing every word. All the Best!")
    End Sub

    Private Sub Button_quit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_quit.Click
        'to quite game
        Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_double.Click
        name1 = InputBox("Enter The name of first player:")
        name2 = InputBox("Enter The name of second player:")
        If name1 = "" Or name2 = "" Then
            MsgBox("Enter the names correctly", MsgBoxStyle.Exclamation)
        Else
            Me.Hide()               'if name1 and name2 are entered correctly movie to form 3
            Form3.Show()
        End If
    End Sub

    Private Sub Button_score_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_score.Click
        If size_out <= 0 Then
            MsgBox("No highscores made yet!", MsgBoxStyle.Exclamation)
        Else
            high_scores.Show()  'shows the high scores in a sorted manner with player name and correspinding score
        End If
    End Sub

End Class
