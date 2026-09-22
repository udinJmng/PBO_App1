Public Class Project2

    Sub ClearAll()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        bButton.Checked = False
        sButton.Checked = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            TextBox1.Text = ""
            TextBox1.Clear()
            Return
        End If
        TextBox1.Text = "Object Oriented Programming"
        TextBox1.ForeColor = Color.Blue

    End Sub

    Private Sub vb_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = False Then
            TextBox2.Text = ""
            TextBox2.Clear()
            TextBox2.BackColor = Color.White
            Return
        End If
        TextBox2.Text = "Visual Basic"
        TextBox2.BackColor = Color.Yellow
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.ForeColor = Color.Black
        TextBox2.BackColor = Color.White
        ClearAll()
        sButton.Checked = False
        bButton.Checked = False
        TextBox3.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DestroyHandle()
    End Sub

    Private Sub bButton_CheckedChanged(sender As Object, e As EventArgs) Handles bButton.CheckedChanged
        TextBox3.Text = "anda memilih benar"
    End Sub

    Private Sub sButton_CheckedChanged(sender As Object, e As EventArgs) Handles sButton.CheckedChanged
        TextBox3.Text = "anda memilih salah"
    End Sub

End Class