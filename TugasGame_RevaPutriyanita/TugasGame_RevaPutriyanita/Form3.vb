Imports MySql.Data.MySqlClient
Public Class Form3
    Dim Con As MySqlConnection
    Dim cmd As MySqlCommand
    Dim db As String

    Sub koneksi()
        db = "server=localhost;user id=root;password=;database=game"
        Con = New MySqlConnection(db)
        Con.Open()
    End Sub
    Sub simpan()
        koneksi()
        Dim sql As String
        sql = "insert into players values('" & Form2.Label2.Text & "','" & Form2.lblCount.Text & "','" & Form2.lblScore.Text & "')"
        cmd = New MySqlCommand(sql, Con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Melihat data berhasil", vbInformation, "INFORMASI")
            DataPemain.Show()
            Form2.Hide()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Melihat data gagal", vbInformation, "PERINGATAN")
        End Try
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.musik, AudioPlayMode.BackgroundLoop)
        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is PictureBox AndAlso ctl.Name <> "PicData" And ctl.Name <> "PicHome" Then
                ctl.Visible = False
                ctl.BackColor = Color.Transparent
            End If
        Next

        lblScore1.Text = Form2.lblScore.Text
        Label1.Text = DataPemain.TextBox1.Text
    End Sub

    Private Sub PicHome_Click_1(sender As Object, e As EventArgs) Handles PicHome.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub PicData_Click(sender As Object, e As EventArgs) Handles PicData.Click
        Call simpan()
    End Sub
End Class