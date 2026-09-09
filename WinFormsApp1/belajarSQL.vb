
Imports MySqlConnector
Public Class belajarSQL

    Sub sqlLoad()

        Dim conn As New MySqlConnection(
            "Server=localhost;Database=belajarvb;User ID=root;Password=;"
        )

        conn.Open()

        MessageBox.Show("Connected!")
        text.Text = "gw ganteng"

        'conn.Close()
    End Sub


End Class