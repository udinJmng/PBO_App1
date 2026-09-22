<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quiz_3_option
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
        Label4 = New Label()
        Label5 = New Label()
        panjang = New TextBox()
        lebar = New TextBox()
        luas = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        proses = New Button()
        clear = New Button()
        tutup = New Button()
        keliling = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(144, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(165, 15)
        Label1.TabIndex = 0
        Label1.Text = "PROGRAM PERSEGI PANJANG"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(118, 120)
        Label2.Name = "Label2"
        Label2.Size = New Size(35, 15)
        Label2.TabIndex = 1
        Label2.Text = "Input"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(118, 232)
        Label3.Name = "Label3"
        Label3.Size = New Size(33, 15)
        Label3.TabIndex = 2
        Label3.Text = "Hasil"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(144, 163)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 15)
        Label4.TabIndex = 3
        Label4.Text = "Panjang: "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(144, 190)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 15)
        Label5.TabIndex = 4
        Label5.Text = "Lebar: "
        ' 
        ' panjang
        ' 
        panjang.Location = New Point(209, 160)
        panjang.Name = "panjang"
        panjang.Size = New Size(137, 23)
        panjang.TabIndex = 5
        ' 
        ' lebar
        ' 
        lebar.Location = New Point(209, 190)
        lebar.Name = "lebar"
        lebar.Size = New Size(137, 23)
        lebar.TabIndex = 6
        ' 
        ' luas
        ' 
        luas.Location = New Point(209, 262)
        luas.Name = "luas"
        luas.Size = New Size(137, 23)
        luas.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(144, 292)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 15)
        Label6.TabIndex = 8
        Label6.Text = "Keliling: "
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(144, 265)
        Label7.Name = "Label7"
        Label7.Size = New Size(37, 15)
        Label7.TabIndex = 7
        Label7.Text = "Luas: "
        ' 
        ' proses
        ' 
        proses.Location = New Point(118, 352)
        proses.Name = "proses"
        proses.Size = New Size(75, 23)
        proses.TabIndex = 11
        proses.Text = "Proses"
        proses.UseVisualStyleBackColor = True
        ' 
        ' clear
        ' 
        clear.Location = New Point(271, 352)
        clear.Name = "clear"
        clear.Size = New Size(75, 23)
        clear.TabIndex = 12
        clear.Text = "Bersih"
        clear.UseVisualStyleBackColor = True
        ' 
        ' tutup
        ' 
        tutup.Location = New Point(118, 381)
        tutup.Name = "tutup"
        tutup.Size = New Size(228, 23)
        tutup.TabIndex = 13
        tutup.Text = "Tutup"
        tutup.UseVisualStyleBackColor = True
        ' 
        ' keliling
        ' 
        keliling.Location = New Point(209, 292)
        keliling.Name = "keliling"
        keliling.Size = New Size(137, 23)
        keliling.TabIndex = 14
        ' 
        ' quiz_3_option
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(475, 572)
        Controls.Add(keliling)
        Controls.Add(tutup)
        Controls.Add(clear)
        Controls.Add(proses)
        Controls.Add(luas)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(lebar)
        Controls.Add(panjang)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "quiz_3_option"
        Text = "quiz_3_option"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents panjang As TextBox
    Friend WithEvents lebar As TextBox
    Friend WithEvents keliling As TextBox
    Friend WithEvents luas As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents proses As Button
    Friend WithEvents clear As Button
    Friend WithEvents tutup As Button
End Class
