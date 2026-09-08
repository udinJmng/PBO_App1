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
    End Sub

    Private Sub vb_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = False Then
            TextBox2.Text = ""
            TextBox2.Clear()
            Return
        End If
        TextBox2.Text = "Visual Basic"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClearAll()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DestroyHandle()
    End Sub
End Class