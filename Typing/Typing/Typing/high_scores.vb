'This form is used to show highscores made so far
Public Class high_scores

    Private Sub Button_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_ok.Click
        Me.Close()
    End Sub

    Private Sub high_scores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'according to the size of highscores.txt file, case are taken and outputs are displayed
        If Form1.size_out = 2 Then
            Label_p1.Text = Form1.output(0)
            Label_s1.Text = Form1.output(1)
        ElseIf Form1.size_out = 4 Then
            Label_p1.Text = Form1.output(0)
            Label_s1.Text = Form1.output(1)
            Label_p2.Text = Form1.output(2)
            Label_s2.Text = Form1.output(3)
        ElseIf Form1.size_out = 6 Then
            Label_p1.Text = Form1.output(0)
            Label_s1.Text = Form1.output(1)
            Label_p2.Text = Form1.output(2)
            Label_s2.Text = Form1.output(3)
            Label_p3.Text = Form1.output(4)
            Label_s3.Text = Form1.output(5)
        ElseIf Form1.size_out = 8 Then
            Label_p1.Text = Form1.output(0)
            Label_s1.Text = Form1.output(1)
            Label_p2.Text = Form1.output(2)
            Label_s2.Text = Form1.output(3)
            Label_p3.Text = Form1.output(4)
            Label_s3.Text = Form1.output(5)
            Label_p4.Text = Form1.output(6)
            Label_s4.Text = Form1.output(7)
        Else
            Label_p1.Text = Form1.output(0)
            Label_s1.Text = Form1.output(1)
            Label_p2.Text = Form1.output(2)
            Label_s2.Text = Form1.output(3)
            Label_p3.Text = Form1.output(4)
            Label_s3.Text = Form1.output(5)
            Label_p4.Text = Form1.output(6)
            Label_s4.Text = Form1.output(7)
            Label_p5.Text = Form1.output(8)
            Label_s5.Text = Form1.output(9)
        End If


    End Sub
End Class