Public Class DicePanel
    Dim MaxDie As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MaxDie = 4
        OutPut.Text = Int(Rnd() * 4 + 1)
        ProgressBar1.Maximum = 4
        ProgressBar1.Value = OutPut.Text
        If OutPut.Text = MaxDie Then
            ProgressBar1.ForeColor = Color.Crimson
            Critical.Visible = True
        ElseIf OutPut.Text = 1 Then
            ProgressBar1.ForeColor = Color.White
            Critical.Visible = False
        Else : ProgressBar1.ForeColor = Color.Blue
            Critical.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MaxDie = 6
        OutPut.Text = Int(Rnd() * 6 + 1)
        ProgressBar1.Maximum = 6
        ProgressBar1.Value = OutPut.Text
        If OutPut.Text = MaxDie Then
            ProgressBar1.ForeColor = Color.Crimson
            Critical.Visible = True
        ElseIf OutPut.Text = 1 Then
            ProgressBar1.ForeColor = Color.White
            Critical.Visible = False
        Else : ProgressBar1.ForeColor = Color.Blue
            Critical.Visible = False
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MaxDie = 8
        OutPut.Text = Int(Rnd() * 8 + 1)
        ProgressBar1.Maximum = 8
        ProgressBar1.Value = OutPut.Text
        If OutPut.Text = MaxDie Then
            ProgressBar1.ForeColor = Color.Crimson
            Critical.Visible = True
        ElseIf OutPut.Text = 1 Then
            ProgressBar1.ForeColor = Color.White
            Critical.Visible = False
        Else : ProgressBar1.ForeColor = Color.Blue
            Critical.Visible = False
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MaxDie = 10
        OutPut.Text = Int(Rnd() * 10 + 1)
        ProgressBar1.Maximum = 10
        ProgressBar1.Value = OutPut.Text
        If OutPut.Text = MaxDie Then
            ProgressBar1.ForeColor = Color.Crimson
            Critical.Visible = True
        ElseIf OutPut.Text = 1 Then
            ProgressBar1.ForeColor = Color.White
            Critical.Visible = False
        Else : ProgressBar1.ForeColor = Color.Blue
            Critical.Visible = False
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        MaxDie = 12
        OutPut.Text = Int(Rnd() * 12 + 1)
        ProgressBar1.Maximum = 12
        ProgressBar1.Value = OutPut.Text
        If OutPut.Text = MaxDie Then
            ProgressBar1.ForeColor = Color.Crimson
            Critical.Visible = True
        ElseIf OutPut.Text = 1 Then
            ProgressBar1.ForeColor = Color.White
            Critical.Visible = False
        Else : ProgressBar1.ForeColor = Color.Blue
            Critical.Visible = False
        End If

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        MaxDie = 20
        OutPut.Text = Int(Rnd() * 20 + 1)
        ProgressBar1.Maximum = 20
        ProgressBar1.Value = OutPut.Text
        If OutPut.Text = MaxDie Then
            ProgressBar1.ForeColor = Color.Crimson
            Critical.Visible = True
        ElseIf OutPut.Text = 1 Then
            ProgressBar1.ForeColor = Color.White
            Critical.Visible = False
        Else : ProgressBar1.ForeColor = Color.Blue
            Critical.Visible = False
        End If
    End Sub
End Class
