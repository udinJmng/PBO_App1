<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kalkulator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        tambah = New Button()
        kali = New Button()
        bagi = New Button()
        kurang = New Button()
        pangkat = New Button()
        clean = New Button()
        keluar = New Button()
        TextBox4 = New TextBox()
        Label5 = New Label()
        calc = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(104, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 15)
        Label1.TabIndex = 0
        Label1.Text = "OPERASI MATEMATIKA"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(61, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 15)
        Label2.TabIndex = 1
        Label2.Text = "Bilangan 1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(61, 143)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 15)
        Label3.TabIndex = 2
        Label3.Text = "Bilangan 2"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(129, 112)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(129, 140)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 5
        ' 
        ' tambah
        ' 
        tambah.Location = New Point(282, 141)
        tambah.Name = "tambah"
        tambah.Size = New Size(33, 23)
        tambah.TabIndex = 7
        tambah.Text = "+"
        tambah.UseVisualStyleBackColor = True
        ' 
        ' kali
        ' 
        kali.Location = New Point(321, 141)
        kali.Name = "kali"
        kali.Size = New Size(33, 23)
        kali.TabIndex = 8
        kali.Text = "*"
        kali.UseVisualStyleBackColor = True
        ' 
        ' bagi
        ' 
        bagi.Location = New Point(360, 141)
        bagi.Name = "bagi"
        bagi.Size = New Size(33, 23)
        bagi.TabIndex = 9
        bagi.Text = "/"
        bagi.UseVisualStyleBackColor = True
        ' 
        ' kurang
        ' 
        kurang.Location = New Point(399, 141)
        kurang.Name = "kurang"
        kurang.Size = New Size(33, 23)
        kurang.TabIndex = 10
        kurang.Text = "-"
        kurang.UseVisualStyleBackColor = True
        ' 
        ' pangkat
        ' 
        pangkat.Location = New Point(438, 141)
        pangkat.Name = "pangkat"
        pangkat.Size = New Size(33, 23)
        pangkat.TabIndex = 11
        pangkat.Text = "^"
        pangkat.UseVisualStyleBackColor = True
        ' 
        ' clean
        ' 
        clean.Location = New Point(321, 170)
        clean.Name = "clean"
        clean.Size = New Size(72, 23)
        clean.TabIndex = 12
        clean.Text = "Bersih"
        clean.UseVisualStyleBackColor = True
        ' 
        ' keluar
        ' 
        keluar.Location = New Point(399, 170)
        keluar.Name = "keluar"
        keluar.Size = New Size(72, 23)
        keluar.TabIndex = 13
        keluar.Text = "Tutup"
        keluar.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(365, 112)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(278, 115)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 15)
        Label5.TabIndex = 15
        Label5.Text = "ketik bilangan"
        ' 
        ' calc
        ' 
        calc.Location = New Point(471, 115)
        calc.Name = "calc"
        calc.Size = New Size(75, 23)
        calc.TabIndex = 17
        calc.Text = "Hitung"
        calc.UseVisualStyleBackColor = True
        ' 
        ' kalkulator
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(727, 450)
        Controls.Add(calc)
        Controls.Add(Label5)
        Controls.Add(TextBox4)
        Controls.Add(keluar)
        Controls.Add(clean)
        Controls.Add(pangkat)
        Controls.Add(kurang)
        Controls.Add(bagi)
        Controls.Add(kali)
        Controls.Add(tambah)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "kalkulator"
        Text = "kalkulator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents tambah As Button
    Friend WithEvents kali As Button
    Friend WithEvents bagi As Button
    Friend WithEvents kurang As Button
    Friend WithEvents pangkat As Button
    Friend WithEvents clean As Button
    Friend WithEvents keluar As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents calc As Button
End Class
