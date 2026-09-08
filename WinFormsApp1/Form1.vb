Public Class Form1
    Dim res As Integer

    Private Sub BtnClick_Click(sender As Object, e As EventArgs) Handles BtnClick.Click
        Dim bil1 As Integer
        Dim bil2 As Integer

        res = CInt(tb1.Text) + CInt(tb2.Text) 'bisa cint + convert int32'
        getRes.Text = res
    End Sub
End Class
