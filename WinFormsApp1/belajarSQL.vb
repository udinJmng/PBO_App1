
Imports MySqlConnector
Public Class belajarSQL



    Private conn As New MySqlConnection( 'inisiasi koneksi database
            "Server=localhost;Database=belajarvb;User ID=root;Password=;"
        )
    Sub sqlLoad()
        conn.Open()

        'MessageBox.Show("Connected!")
        text.Text = "Connected"

        'conn.Close()
    End Sub

    Private Sub belajarSQL_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        sqlLoad()

    End Sub


    Sub loadBarang()
        Dim sql As String = "SELECT id, nama_slug_barang, label_barang, harga_satuan FROM barang"
        listbar.Rows.Clear()
        Using cmd As New MySqlCommand(sql, conn)
            Using reader = cmd.ExecuteReader()
                While reader.Read()
                    listbar.Rows.Add(
                        reader("id"),
                        reader("nama_slug_barang"),
                        reader("label_barang"),
                        reader("harga_satuan")
                    )
                End While
            End Using
        End Using
    End Sub

    Sub addBarang(slug As String, label As String, price As Decimal)
        Dim sql As String =
            "insert into barang(nama_slug_barang, label_barang,harga_satuan)" & "VALUES (@slug, @label, @price)"

        Dim cmd As New MySqlCommand(sql, conn)

        cmd.Parameters.AddWithValue("@slug", slug)
        cmd.Parameters.AddWithValue("@label", label)
        cmd.Parameters.AddWithValue("@price", price)

        cmd.ExecuteNonQuery()
    End Sub

    Private Sub Click_Click(sender As Object, e As EventArgs) Handles Click.Click
        If isSlug.Text <> "" AndAlso isLabel.Text <> "" AndAlso isPrice.Text <> "" Then
            addBarang(isSlug.Text, isLabel.Text, Val(isPrice.Text))
            loadBarang()
        Else
            MessageBox.Show("Data tidak valid")
        End If
    End Sub

    Private Sub loadClick_Click(sender As Object, e As EventArgs) Handles loadClick.Click
        loadBarang()
    End Sub
End Class