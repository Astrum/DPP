Public Class Form1
    Dim roll As Integer, rollMod As Integer
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        roll = Int(Rnd() * 20 + 1)
        RollLabel.Text = roll
        If roll = 20 Then
            RollLabel.ForeColor = Color.Red
        ElseIf roll = 1 Then
            RollLabel.ForeColor = Color.White
        Else : RollLabel.ForeColor = Color.Black
        End If
        RollWithMod.Text = roll + rollMod
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

        If ListBox1.SelectedIndex.Equals(0) Then
            rollMod = 0
        ElseIf ListBox1.SelectedIndex.Equals(1) Then
            rollMod = ChaModNum.Text
            REM Changes the modifier for the roll according to the selected modifier.

        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ChaModNum.Text = Int((ChaMod.Text - 10) / 2)
        MaskedTextBox7.Text = 
    End Sub

    Private Sub ExpCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpCalculate.Click
        If Experience.Text >= 0 And Experience.Text < 1000 Then
            Level.Text = 1
        ElseIf Experience.Text >= 1000 And Experience.Text < 2250 Then
            Level.Text = 2
        ElseIf Experience.Text < 3750 Then
            Level.Text = 3
        ElseIf Experience.Text < 5500 Then
            Level.Text = 4
        ElseIf Experience.Text < 7500 Then
            Level.Text = 5
        Else
            Level.Text = 0
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim Result As Single
        For roll As Integer = 1 To AtWillDiceNumber1.Value Step 1
            Randomize()
            Result = Result + (Rnd() * AtWillDiceType1.Text)
        Next roll
        AtWillDamage1.Text = Int(Result + 1)
    End Sub
End Class
