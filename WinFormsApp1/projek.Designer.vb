<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class projek
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(projek))
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        QuizToolStripMenuItem = New ToolStripMenuItem()
        Latihan1ToolStripMenuItem = New ToolStripMenuItem()
        Latihan1ToolStripMenuItem1 = New ToolStripMenuItem()
        Latihan3ToolStripMenuItem = New ToolStripMenuItem()
        TugasToolStripMenuItem = New ToolStripMenuItem()
        AboutMeToolStripMenuItem = New ToolStripMenuItem()
        ToolStrip1 = New ToolStrip()
        ToolStripButton1 = New ToolStripButton()
        ToolStripButton2 = New ToolStripButton()
        ToolStripButton3 = New ToolStripButton()
        MenuStrip1.SuspendLayout()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, QuizToolStripMenuItem, TugasToolStripMenuItem, AboutMeToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' QuizToolStripMenuItem
        ' 
        QuizToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Latihan1ToolStripMenuItem, Latihan1ToolStripMenuItem1, Latihan3ToolStripMenuItem})
        QuizToolStripMenuItem.Name = "QuizToolStripMenuItem"
        QuizToolStripMenuItem.Size = New Size(43, 20)
        QuizToolStripMenuItem.Text = "Quiz"
        ' 
        ' Latihan1ToolStripMenuItem
        ' 
        Latihan1ToolStripMenuItem.Name = "Latihan1ToolStripMenuItem"
        Latihan1ToolStripMenuItem.Size = New Size(180, 22)
        Latihan1ToolStripMenuItem.Text = "Latihan 1"
        ' 
        ' Latihan1ToolStripMenuItem1
        ' 
        Latihan1ToolStripMenuItem1.Name = "Latihan1ToolStripMenuItem1"
        Latihan1ToolStripMenuItem1.Size = New Size(180, 22)
        Latihan1ToolStripMenuItem1.Text = "Latihan 2"
        ' 
        ' Latihan3ToolStripMenuItem
        ' 
        Latihan3ToolStripMenuItem.Name = "Latihan3ToolStripMenuItem"
        Latihan3ToolStripMenuItem.Size = New Size(180, 22)
        Latihan3ToolStripMenuItem.Text = "Latihan 3"
        ' 
        ' TugasToolStripMenuItem
        ' 
        TugasToolStripMenuItem.Name = "TugasToolStripMenuItem"
        TugasToolStripMenuItem.Size = New Size(51, 20)
        TugasToolStripMenuItem.Text = "Tugas"
        ' 
        ' AboutMeToolStripMenuItem
        ' 
        AboutMeToolStripMenuItem.Name = "AboutMeToolStripMenuItem"
        AboutMeToolStripMenuItem.Size = New Size(72, 20)
        AboutMeToolStripMenuItem.Text = "About Me"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripButton1, ToolStripButton2, ToolStripButton3})
        ToolStrip1.Location = New Point(0, 24)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(800, 25)
        ToolStrip1.TabIndex = 1
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ToolStripButton1
        ' 
        ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), Image)
        ToolStripButton1.ImageTransparentColor = Color.Magenta
        ToolStripButton1.Name = "ToolStripButton1"
        ToolStripButton1.Size = New Size(23, 22)
        ToolStripButton1.Text = "ToolStripButton1"
        ' 
        ' ToolStripButton2
        ' 
        ToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), Image)
        ToolStripButton2.ImageTransparentColor = Color.Magenta
        ToolStripButton2.Name = "ToolStripButton2"
        ToolStripButton2.Size = New Size(23, 22)
        ToolStripButton2.Text = "ToolStripButton2"
        ' 
        ' ToolStripButton3
        ' 
        ToolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), Image)
        ToolStripButton3.ImageTransparentColor = Color.Magenta
        ToolStripButton3.Name = "ToolStripButton3"
        ToolStripButton3.Size = New Size(23, 22)
        ToolStripButton3.Text = "ToolStripButton3"
        ' 
        ' projek
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ToolStrip1)
        Controls.Add(MenuStrip1)
        Name = "projek"
        StartPosition = FormStartPosition.CenterScreen
        Text = "projek"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuizToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Latihan1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Latihan1ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Latihan3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TugasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents AboutMeToolStripMenuItem As ToolStripMenuItem
End Class
