<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        judulCOK = New Label()
        BtnClick = New Button()
        getRes = New Label()
        tb1 = New TextBox()
        tb2 = New TextBox()
        SuspendLayout()
        ' 
        ' judulCOK
        ' 
        judulCOK.AutoSize = True
        judulCOK.Location = New Point(232, 37)
        judulCOK.Name = "judulCOK"
        judulCOK.Size = New Size(188, 15)
        judulCOK.TabIndex = 1
        judulCOK.Text = "Pemerograman Berorientasi Objek"
        ' 
        ' BtnClick
        ' 
        BtnClick.Location = New Point(121, 220)
        BtnClick.Name = "BtnClick"
        BtnClick.Size = New Size(75, 23)
        BtnClick.TabIndex = 4
        BtnClick.Text = "Button1"
        BtnClick.UseVisualStyleBackColor = True
        ' 
        ' getRes
        ' 
        getRes.AutoSize = True
        getRes.Location = New Point(137, 256)
        getRes.Name = "getRes"
        getRes.Size = New Size(41, 15)
        getRes.TabIndex = 5
        getRes.Text = "Label1"
        ' 
        ' tb1
        ' 
        tb1.Location = New Point(121, 123)
        tb1.Name = "tb1"
        tb1.Size = New Size(100, 23)
        tb1.TabIndex = 6
        ' 
        ' tb2
        ' 
        tb2.Location = New Point(121, 172)
        tb2.Name = "tb2"
        tb2.Size = New Size(100, 23)
        tb2.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(670, 450)
        Controls.Add(tb2)
        Controls.Add(tb1)
        Controls.Add(getRes)
        Controls.Add(BtnClick)
        Controls.Add(judulCOK)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents judulCOK As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents b2 As TextBox
    Friend WithEvents BtnClick As Button
    Friend WithEvents getRes As Label
    Friend WithEvents tb1 As TextBox
    Friend WithEvents tb2 As TextBox

End Class
