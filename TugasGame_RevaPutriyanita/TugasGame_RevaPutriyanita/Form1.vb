
Public Class Form1
    Dim menit, detik As Integer
    Dim nama As String

    Private Sub PicPlay_Click(sender As Object, e As EventArgs) Handles PicPlay.Click
        nama = InputBox("Masukkan Nama")
        Form2.Label2.Text = (nama)
        Form2.Timer2.Start()
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataPemain.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.musik, AudioPlayMode.BackgroundLoop)

        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is PictureBox AndAlso ctl.Name <> "PicPlay" Then
                ctl.Visible = False
                ctl.BackColor = Color.Transparent
            End If
        Next

        lblScore.Text = DataPemain.TextBox1.Text
    End Sub

End Class
