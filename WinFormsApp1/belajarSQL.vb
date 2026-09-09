
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
        sqlLoad()
        If isSlug.Text <> "" AndAlso isLabel.Text <> "" AndAlso isPrice.Text <> "" Then
            addBarang(isSlug.Text, isLabel.Text, Val(isPrice.Text))
        Else
            MessageBox.Show("Data tidak valid")
        End If
    End Sub
End Class