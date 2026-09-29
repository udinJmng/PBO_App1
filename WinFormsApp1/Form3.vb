Public Class Form3


    Private Sub calcHasil()
        Dim hasil As Integer = 0
        If TextBox3.Text <> "" Then
            hasil = TextBox3.Text * TextBox2.Text
            TextBox4.Text = hasil
        Else
            TextBox4.Clear()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox4.Clear()
        If ComboBox1.Text = "PL01" Then
            TextBox1.Text = "Pulpen Pilot"
            TextBox2.Text = 1200
        ElseIf ComboBox1.Text = "PL02" Then
            TextBox1.Text = "Pulpen Standard"
            TextBox2.Text = 1000
        ElseIf ComboBox1.Text = "BK01" Then
            TextBox1.Text = "Buku AA 60 LBR"
            TextBox2.Text = 3500
        Else
            TextBox1.Text = "Buku Sinar DUnia 50 LBR"
            TextBox2.Text = 300
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        calcHasil()
    End Sub

End Class