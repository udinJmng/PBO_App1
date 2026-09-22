Public Class quiz_3_option
    Private Sub tutup_Click(sender As Object, e As EventArgs) Handles tutup.Click
        DestroyHandle()
    End Sub

    Private Sub calcRes()
        Dim hasilLuas As Double
        Dim hasilKel As Double

        hasilLuas = Val(panjang.Text) * Val(lebar.Text)
        hasilKel = 2 * (Val(panjang.Text) + Val(lebar.Text))

        luas.Text = hasilLuas
        keliling.Text = hasilKel
    End Sub

    Private Sub proses_Click(sender As Object, e As EventArgs) Handles proses.Click
        calcRes()
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        lebar.Clear()
        panjang.Clear()
        luas.Clear()
        keliling.Clear()
    End Sub
End Class