<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Project2
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
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        sButton = New RadioButton()
        TextBox3 = New TextBox()
        Button1 = New Button()
        bButton = New RadioButton()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Coral
        Label1.Location = New Point(156, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 15)
        Label1.TabIndex = 0
        Label1.Text = "Mamat koding"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(156, 99)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(51, 19)
        CheckBox1.TabIndex = 1
        CheckBox1.Text = "OOP"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(156, 128)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(40, 19)
        CheckBox2.TabIndex = 2
        CheckBox2.Text = "VB"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(322, 97)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(235, 23)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(322, 126)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(235, 23)
        TextBox2.TabIndex = 4
        ' 
        ' sButton
        ' 
        sButton.AutoSize = True
        sButton.Location = New Point(460, 284)
        sButton.Name = "sButton"
        sButton.Size = New Size(53, 19)
        sButton.TabIndex = 6
        sButton.TabStop = True
        sButton.Text = "Salah"
        sButton.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(177, 309)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(380, 23)
        TextBox3.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(177, 376)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 8
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' bButton
        ' 
        bButton.AutoSize = True
        bButton.Location = New Point(177, 284)
        bButton.Name = "bButton"
        bButton.Size = New Size(55, 19)
        bButton.TabIndex = 9
        bButton.TabStop = True
        bButton.Text = "Benar"
        bButton.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(482, 376)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 10
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Project2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(672, 450)
        Controls.Add(Button2)
        Controls.Add(bButton)
        Controls.Add(Button1)
        Controls.Add(TextBox3)
        Controls.Add(sButton)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(Label1)
        Name = "Project2"
        Text = "Project2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents sButton As RadioButton
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents bButton As RadioButton
    Friend WithEvents Button2 As Button
End Class
