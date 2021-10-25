Public Class Form1
    Dim alarm As Integer = 0
    
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmr2.Enabled = True
        DateTimePicker1.Format = DateTimePickerFormat.Time
    End Sub

    Private Sub tmr2_Tick(sender As Object, e As EventArgs) Handles tmr2.Tick
        lblJam.Text = DateTime.Now.ToLongTimeString
    End Sub

    Private Sub tmr1_Tick(sender As Object, e As EventArgs) Handles tmr1.Tick
        Try
            If TimeOfDay = DateTimePicker1.Text Then
                If alarm = 1 Then
                    AxWindowsMediaPlayer1.URL = TxtNada.Text.ToString
                Else
                    MsgBox(DateTimePicker1.Value)

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub ChkON_CheckedChanged(sender As Object, e As EventArgs) Handles ChkON.CheckedChanged
        If ChkON.Checked = True Then
            ChkON.Text = "ON"
            tmr1.Enabled = True
        Else
            ChkON.Checked = False
            ChkON.Text = "OFF"
            tmr1.Enabled = False
            AxWindowsMediaPlayer1.close()
        End If
    End Sub

    Private Sub btnPilih_Click(sender As Object, e As EventArgs) Handles btnPilih.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TxtNada.Text = ""
            TxtNada.Text = OpenFileDialog1.FileName
            alarm = 1
        End If
    End Sub

    Private Sub lblJam_Click(sender As Object, e As EventArgs) Handles lblJam.Click

    End Sub
End Class
