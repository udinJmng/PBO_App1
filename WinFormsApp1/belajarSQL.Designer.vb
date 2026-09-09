<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class belajarSQL
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
        text = New Label()
        isSlug = New TextBox()
        isLabel = New TextBox()
        isPrice = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Click = New Button()
        SuspendLayout()
        ' 
        ' text
        ' 
        text.AutoSize = True
        text.Location = New Point(86, 47)
        text.Name = "text"
        text.Size = New Size(240, 15)
        text.TabIndex = 1
        text.Text = "Aplikasi pencatatan dan pengecekan barang"
        ' 
        ' isSlug
        ' 
        isSlug.Location = New Point(86, 90)
        isSlug.Name = "isSlug"
        isSlug.Size = New Size(151, 23)
        isSlug.TabIndex = 2
        ' 
        ' isLabel
        ' 
        isLabel.Location = New Point(86, 119)
        isLabel.Name = "isLabel"
        isLabel.Size = New Size(151, 23)
        isLabel.TabIndex = 3
        ' 
        ' isPrice
        ' 
        isPrice.Location = New Point(86, 148)
        isPrice.Name = "isPrice"
        isPrice.Size = New Size(151, 23)
        isPrice.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(243, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(200, 15)
        Label1.TabIndex = 5
        Label1.Text = "Slug barang (contoh : nasi_bungkus)"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(243, 122)
        Label2.Name = "Label2"
        Label2.Size = New Size(205, 15)
        Label2.TabIndex = 6
        Label2.Text = "Label barang (contoh : Nasi Bungkus)"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(243, 151)
        Label3.Name = "Label3"
        Label3.Size = New Size(170, 15)
        Label3.TabIndex = 7
        Label3.Text = "Hargal barang (contoh : 25000)"
        ' 
        ' Click
        ' 
        Click.Location = New Point(86, 177)
        Click.Name = "Click"
        Click.Size = New Size(151, 23)
        Click.TabIndex = 8
        Click.Text = "Klik untuk nambah"
        Click.UseVisualStyleBackColor = True
        ' 
        ' belajarSQL
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Click)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(isPrice)
        Controls.Add(isLabel)
        Controls.Add(isSlug)
        Controls.Add(text)
        Name = "belajarSQL"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents text As Label
    Friend WithEvents isSlug As TextBox
    Friend WithEvents isLabel As TextBox
    Friend WithEvents isPrice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Click As Button
End Class
