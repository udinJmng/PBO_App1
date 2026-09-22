<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class typedata
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
        getHasil = New Button()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' getHasil
        ' 
        getHasil.Location = New Point(295, 214)
        getHasil.Name = "getHasil"
        getHasil.Size = New Size(75, 23)
        getHasil.TabIndex = 0
        getHasil.Text = "Button1"
        getHasil.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(280, 185)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 1
        ' 
        ' typedata
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox1)
        Controls.Add(getHasil)
        Name = "typedata"
        Text = "typedata"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents getHasil As Button
    Friend WithEvents TextBox1 As TextBox
End Class
