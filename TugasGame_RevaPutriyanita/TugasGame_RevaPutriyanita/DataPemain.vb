Imports MySql.Data.MySqlClient
Public Class DataPemain
    Dim Con As MySqlConnection
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim db As String
    Sub koneksi()
        db = "server=localhost;user id=root;password=;database=game"
        Con = New MySqlConnection(db)
        Con.Open()
    End Sub
    Sub tampil()
        Try
            koneksi()
            da = New MySqlDataAdapter("select *from players order by nama", Con)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "players")
            Me.DataGridView1.DataSource = (ds.Tables("players"))

        Catch ex As Exception
            MsgBox("Menampilkan data gagal")
        End Try
    End Sub

    Sub bestscore()
        TextBox1.Text = (From row As DataGridViewRow In DataGridView1.Rows
                         Where row.Cells(2).FormattedValue.ToString() <> String.Empty
                         Select Convert.ToInt32(row.Cells(2).FormattedValue)
                         ).Max().ToString()

    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Form2.Label2.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Form2.lblCount.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        Form2.lblScore.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
        Call bestscore()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Form1.lblScore.Text = TextBox1.Text
        Me.Hide()
    End Sub
End Class