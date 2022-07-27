
Public Class Form2
    Private time As DateTime
    Private countdown As TimeSpan = TimeSpan.FromMinutes(1)
    Private Sub PicExit_Click(sender As Object, e As EventArgs) Handles PicExit.Click
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is PictureBox AndAlso ctl.Name <> "PicExit" Then
                ctl.Visible = False
                ctl.BackColor = Color.Transparent
            End If
        Next

        Select Case Math.Round(Rnd() * 8, 0) + 1
            Case 1
                picM1.Visible = True
            Case 2
                picM2.Visible = True
            Case 3
                picM3.Visible = True
            Case 4
                picM4.Visible = True
            Case 5
                picM5.Visible = True
            Case 6
                picM6.Visible = True
            Case 7
                PicM7.Visible = True
            Case 8
                picM8.Visible = True
            Case 9
                picM9.Visible = True
        End Select

        My.Computer.Audio.Play(Application.StartupPath & "\out.wav")

    End Sub

    Private Sub Pukul_Click(sender As Object, e As EventArgs) Handles picM1.Click, picM2.Click, picM4.Click, picM6.Click, picM8.Click, picM9.Click
        My.Computer.Audio.Play(Application.StartupPath & "\pukul.wav")

        Dim picpukul As PictureBox = CType(sender, PictureBox)
        picpukul.BackColor = Color.Red
        lblCount.Text = Val(lblCount.Text) + 1
        lblScore.Text = Val(lblScore.Text) + 10
    End Sub

    Private Sub bomb_Click(sender As Object, e As EventArgs) Handles picM3.Click, picM5.Click, PicM7.Click
        My.Computer.Audio.Play(Application.StartupPath & "\pukul.wav")

        Dim picpukul As PictureBox = CType(sender, PictureBox)
        picpukul.BackColor = Color.Red
        lblCount.Text = Val(lblCount.Text) - 1
        lblScore.Text = Val(lblScore.Text) - 10
    End Sub

    Private Sub Form2_Click(sender As Object, e As EventArgs) Handles Me.Click
        My.Computer.Audio.Play(Application.StartupPath & "\pukul.wav")
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Interval = 100
        time = DateTime.Now.Add(countdown)

        If lblCount.Text > 10 And lblCount.Text < 25 Then
            Timer1.Interval = 1000
        End If
        If lblCount.Text > 25 And lblCount.Text < 50 Then
            Timer1.Interval = 800
        End If
        If lblCount.Text > 50 And lblCount.Text < 100 Then
            Timer1.Interval = 600
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim ts As TimeSpan = time.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            Label1.Text = ts.ToString("mm\:ss")
        Else
            Label1.Text = "00:00"
            Timer2.Stop()
            Timer1.Stop()
            Form3.Show()
        End If
    End Sub
End Class