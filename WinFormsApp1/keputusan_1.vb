Public Class keputusan_1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text >= 85 Then
            TextBox2.Text = "lulus"
        ElseIf TextBox1.Text >= 75 Then
            TextBox2.Text = "daftar pengganti"
        Else
            TextBox2.ReadOnly = True
            TextBox2.Text = "gagal"
        End If
    End Sub
End Class