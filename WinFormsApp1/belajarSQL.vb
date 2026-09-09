
Imports MySqlConnector
Public Class belajarSQL



    Private conn As New MySqlConnection( 'inisiasi koneksi database
            "Server=localhost;Database=belajarvb;User ID=root;Password=;"
        )
    Sub sqlLoad()
        conn.Open()

        MessageBox.Show("Connected!")
        text.Text = "gw ganteng"

        'conn.Close()
    End Sub


End Class