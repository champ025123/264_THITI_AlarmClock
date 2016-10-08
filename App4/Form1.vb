Public Class Form1

    Dim setsts As Boolean
    Dim alrmsound As String
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblctime.Text = DateTime.Now.ToString("hh:mm:ss tt")

        If setsts = True And lblctime.Text = txtsettime.Text Then

            If alrmsound <> "" Then
                AxWindowsMediaPlayer1.URL = alrmsound
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Else
                MsgBox("STARTTT UP PP P P!")
            End If

            lblmsg.Text = "Set Alarm..."

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        setsts = True
        lblmsg.Text = "Alarm at " + txtsettime.Text
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alrmsound = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            alrmsound = OpenFileDialog1.FileName
        Else
            alrmsound = ""
        End If

    End Sub

End Class
