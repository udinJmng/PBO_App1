<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        TextBox1 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        Button0 = New Button()
        getResult = New Button()
        tambah = New Button()
        kali = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(104, 45)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(326, 62)
        TextBox1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(104, 136)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 64)
        Button1.TabIndex = 1
        Button1.Text = "1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(227, 136)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 64)
        Button2.TabIndex = 2
        Button2.Text = "2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(355, 136)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 64)
        Button3.TabIndex = 3
        Button3.Text = "3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(104, 227)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 64)
        Button4.TabIndex = 6
        Button4.Text = "4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(227, 227)
        Button5.Name = "Button5"
        Button5.Size = New Size(75, 64)
        Button5.TabIndex = 5
        Button5.Text = "5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(355, 227)
        Button6.Name = "Button6"
        Button6.Size = New Size(75, 64)
        Button6.TabIndex = 4
        Button6.Text = "6"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(104, 323)
        Button7.Name = "Button7"
        Button7.Size = New Size(75, 64)
        Button7.TabIndex = 9
        Button7.Text = "7"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(227, 323)
        Button8.Name = "Button8"
        Button8.Size = New Size(75, 64)
        Button8.TabIndex = 8
        Button8.Text = "8"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(355, 323)
        Button9.Name = "Button9"
        Button9.Size = New Size(75, 64)
        Button9.TabIndex = 7
        Button9.Text = "9"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button0
        ' 
        Button0.Location = New Point(227, 409)
        Button0.Name = "Button0"
        Button0.Size = New Size(75, 64)
        Button0.TabIndex = 10
        Button0.Text = "0"
        Button0.UseVisualStyleBackColor = True
        ' 
        ' getResult
        ' 
        getResult.Location = New Point(227, 502)
        getResult.Name = "getResult"
        getResult.Size = New Size(75, 64)
        getResult.TabIndex = 11
        getResult.Text = "="
        getResult.UseVisualStyleBackColor = True
        ' 
        ' tambah
        ' 
        tambah.Location = New Point(104, 409)
        tambah.Name = "tambah"
        tambah.Size = New Size(75, 64)
        tambah.TabIndex = 12
        tambah.Text = "+"
        tambah.UseVisualStyleBackColor = True
        ' 
        ' kali
        ' 
        kali.Location = New Point(355, 409)
        kali.Name = "kali"
        kali.Size = New Size(75, 64)
        kali.TabIndex = 13
        kali.Text = "*"
        kali.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(545, 608)
        Controls.Add(kali)
        Controls.Add(tambah)
        Controls.Add(getResult)
        Controls.Add(Button0)
        Controls.Add(Button7)
        Controls.Add(Button8)
        Controls.Add(Button9)
        Controls.Add(Button4)
        Controls.Add(Button5)
        Controls.Add(Button6)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button0 As Button
    Friend WithEvents getResult As Button
    Friend WithEvents tambah As Button
    Friend WithEvents kali As Button
End Class
