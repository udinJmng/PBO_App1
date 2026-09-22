Public Class kalkulator

    Dim onceClick As Boolean = False
    Dim tempBil1 As Integer
    Dim tempBIl2 As Integer

    Dim operasi_global As String
    Dim canHitung As Boolean
    Private Sub tempStorage(args1 As Integer, operasi As String)

        onceClick = Not onceClick
        If onceClick Then
            tempBil1 = args1
            TextBox4.Clear()
            operasi_global = operasi
            canHitung = True
        End If
    End Sub

    Private Sub calcHasil()
        If canHitung Then
            Dim hasil As Integer
            tempBIl2 = Val(TextBox4.Text)
            If operasi_global = "tambah" Then
                hasil = tempBil1 + tempBIl2
            ElseIf operasi_global = "kali" Then
                hasil = tempBil1 * tempBIl2
            ElseIf operasi_global = "bagi" Then
                hasil = tempBil1 / tempBIl2
            ElseIf operasi_global = "kurang" Then
                hasil = tempBil1 - tempBIl2
            ElseIf operasi_global = "pangkat" Then
                hasil = tempBil1 ^ tempBIl2
            End If
            canHitung = False
            TextBox4.Text = hasil
        End If
    End Sub

    Private Sub tambah_Click(sender As Object, e As EventArgs) Handles tambah.Click
        tempStorage(Val(TextBox4.Text), "tambah")
    End Sub

    Private Sub kali_Click(sender As Object, e As EventArgs) Handles kali.Click
        tempStorage(Val(TextBox4.Text), "kali")
    End Sub

    Private Sub bagi_Click(sender As Object, e As EventArgs) Handles bagi.Click
        tempStorage(Val(TextBox4.Text), "kali")
    End Sub

    Private Sub kurang_Click(sender As Object, e As EventArgs) Handles kurang.Click
        tempStorage(Val(TextBox4.Text), "kurang")
    End Sub
    Private Sub pangkat_Click(sender As Object, e As EventArgs) Handles pangkat.Click
        tempStorage(Val(TextBox4.Text), "pangkat")
    End Sub

    Private Sub clean_Click(sender As Object, e As EventArgs) Handles clean.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox4.Clear()
        onceClick = False
    End Sub

    Private Sub keluar_Click(sender As Object, e As EventArgs) Handles keluar.Click
        DestroyHandle()
    End Sub

    Private Sub calc_Click(sender As Object, e As EventArgs) Handles calc.Click
        calcHasil()
    End Sub

End Class