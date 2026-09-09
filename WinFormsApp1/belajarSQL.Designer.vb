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
        Label4 = New Label()
        listbar = New DataGridView()
        id = New DataGridViewTextBoxColumn()
        nama_slug_barang = New DataGridViewTextBoxColumn()
        label_barang = New DataGridViewTextBoxColumn()
        harga_satuan = New DataGridViewTextBoxColumn()
        loadClick = New Button()
        CType(listbar, ComponentModel.ISupportInitialize).BeginInit()
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
        isSlug.Location = New Point(86, 74)
        isSlug.Name = "isSlug"
        isSlug.Size = New Size(151, 23)
        isSlug.TabIndex = 2
        ' 
        ' isLabel
        ' 
        isLabel.Location = New Point(86, 103)
        isLabel.Name = "isLabel"
        isLabel.Size = New Size(151, 23)
        isLabel.TabIndex = 3
        ' 
        ' isPrice
        ' 
        isPrice.Location = New Point(86, 132)
        isPrice.Name = "isPrice"
        isPrice.Size = New Size(151, 23)
        isPrice.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(243, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(200, 15)
        Label1.TabIndex = 5
        Label1.Text = "Slug barang (contoh : nasi_bungkus)"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(243, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(205, 15)
        Label2.TabIndex = 6
        Label2.Text = "Label barang (contoh : Nasi Bungkus)"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(243, 135)
        Label3.Name = "Label3"
        Label3.Size = New Size(170, 15)
        Label3.TabIndex = 7
        Label3.Text = "Hargal barang (contoh : 25000)"
        ' 
        ' Click
        ' 
        Click.Location = New Point(86, 161)
        Click.Name = "Click"
        Click.Size = New Size(151, 23)
        Click.TabIndex = 8
        Click.Text = "Klik untuk nambah"
        Click.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(243, 247)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 15)
        Label4.TabIndex = 9
        Label4.Text = "List Barang"
        ' 
        ' listbar
        ' 
        listbar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        listbar.Columns.AddRange(New DataGridViewColumn() {id, nama_slug_barang, label_barang, harga_satuan})
        listbar.Location = New Point(33, 276)
        listbar.Name = "listbar"
        listbar.Size = New Size(443, 150)
        listbar.TabIndex = 10
        ' 
        ' id
        ' 
        id.HeaderText = "id"
        id.Name = "id"
        ' 
        ' nama_slug_barang
        ' 
        nama_slug_barang.HeaderText = "slug barang"
        nama_slug_barang.Name = "nama_slug_barang"
        ' 
        ' label_barang
        ' 
        label_barang.HeaderText = "label barang"
        label_barang.Name = "label_barang"
        ' 
        ' harga_satuan
        ' 
        harga_satuan.HeaderText = "harga"
        harga_satuan.Name = "harga_satuan"
        ' 
        ' loadClick
        ' 
        loadClick.Location = New Point(393, 247)
        loadClick.Name = "loadClick"
        loadClick.Size = New Size(83, 23)
        loadClick.TabIndex = 11
        loadClick.Text = "Klik untuk load"
        loadClick.UseVisualStyleBackColor = True
        ' 
        ' belajarSQL
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(loadClick)
        Controls.Add(listbar)
        Controls.Add(Label4)
        Controls.Add(Click)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(isPrice)
        Controls.Add(isLabel)
        Controls.Add(isSlug)
        Controls.Add(text)
        Name = "belajarSQL"
        CType(listbar, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label4 As Label
    Friend WithEvents listbar As DataGridView
    Friend WithEvents loadClick As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nama_slug_barang As DataGridViewTextBoxColumn
    Friend WithEvents label_barang As DataGridViewTextBoxColumn
    Friend WithEvents harga_satuan As DataGridViewTextBoxColumn
End Class
