Public Class Form1
    Dim res As Integer

    Private Sub BtnClick_Click(sender As Object, e As EventArgs) Handles BtnClick.Click

        If CInt(tb1.Text) < 0 OrElse CInt(tb2.Text) < 0 Then
            getRes.Text = "You can't operate"
            Return
        End If

        res = CInt(tb1.Text) + CInt(tb2.Text) 'bisa cint + convert int32'
        getRes.Text = res

    End Sub
End Class
