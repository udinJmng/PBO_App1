Public Class Form2
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim btn As Button = CType(sender, Button)

    '    TextBox1.Text = TextBox1.Text & btn.Text
    'End Sub
    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    Dim btn As Button = CType(sender, Button)

    '    TextBox1.Text = TextBox1.Text & btn.Text
    'End Sub
    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    '    Dim btn As Button = CType(sender, Button)

    '    TextBox1.Text = TextBox1.Text & btn.Text
    'End Sub
    'Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    '    Dim btn As Button = CType(sender, Button)

    '    TextBox1.Text = TextBox1.Text & btn.Text
    'End Sub
    'Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    '    Dim btn As Button = CType(sender, Button)

    '    TextBox1.Text = TextBox1.Text & btn.Text
    'End Sub
    'Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
    '    Dim btn As Button = CType(sender, Button)

    '    TextBox1.Text = TextBox1.Text & btn.Text
    'End Sub
    'Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
    '    Dim btn As Button = CType(sender, Button)

    '    TextBox1.Text = TextBox1.Text & btn.Text
    'End Sub
    'Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
    '    Dim btn As Button = CType(sender, Button)

    '    TextBox1.Text = TextBox1.Text & btn.Text
    'End Sub
    'Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
    '    Dim btn As Button = CType(sender, Button)

    '    TextBox1.Text = TextBox1.Text & btn.Text
    'End Sub
    'Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
    '    Dim btn As Button = CType(sender, Button)

    '    TextBox1.Text = TextBox1.Text & btn.Text
    'End Sub

    'Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub
    Private angkaPertama As Double = 0
    Private angkaKeduae = 0
    Private operatorAktif As String = ""
    Private isOperatorClicked As Boolean = False
    Private stateChunk As Boolean = False
    Private Sub TombolAngka_Click(sender As Object, e As EventArgs) Handles _
        Button0.Click, Button1.Click, Button2.Click, Button3.Click, Button4.Click,
        Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click

        Dim btn As Button = CType(sender, Button)

        ' Jika operator baru saja ditekan atau layar masih "0", reset text dulu
        If isOperatorClicked OrElse TextBox1.Text = "0" Then
            TextBox1.Text = ""
            isOperatorClicked = False
        End If

        TextBox1.Text &= btn.Text
    End Sub

    ''' PEMBATAS
    ''' 
    Private hasilCached As Double
    Private hasil As Double

    Private Sub calcResult(isOnFinalRes As Boolean, isChunk As Boolean, operasi As String)
        If isOnFinalRes Then
            hasilCached = hasil
            TextBox1.Text = hasilCached
            Return
        End If
        If isChunk Then
            If operasi = "kali" Then
                hasil = Val(angkaPertama) * Val(angkaKeduae)
            ElseIf operasi = "tambah" Then
                hasil = Val(angkaPertama) + Val(angkaKeduae)
            End If
            hasilCached = hasil
        End If
    End Sub

    Private Sub chunkSystem(angka As Double)
        stateChunk = Not stateChunk
        If stateChunk Then
            angkaPertama = angka
        Else
            angkaKeduae = angka
        End If

    End Sub

    Private Sub kali_Click(sender As Object, e As EventArgs) Handles kali.Click
        chunkSystem(Val(TextBox1.Text))
        calcResult(False, True, "kali")
        operatorAktif = "kali"
        TextBox1.Clear()
    End Sub
    Private Sub tambah_Click(sender As Object, e As EventArgs) Handles tambah.Click
        chunkSystem(Val(TextBox1.Text))
        calcResult(False, True, "tambah")
        operatorAktif = "tambah"
        TextBox1.Clear()
    End Sub

    Private Sub getResult_Click(sender As Object, e As EventArgs) Handles getResult.Click
        chunkSystem(Val(TextBox1.Text))
        calcResult(False, True, operatorAktif)
        calcResult(True, False, "")
    End Sub
End Class