Public Class FAq

    Private Sub FAq_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        index.Visible = True
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        rules.Visible = True
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        email.Visible = True
        Me.Hide()
    End Sub

    Private Sub wifi_Click(sender As System.Object, e As System.EventArgs) Handles wifi.Click
        wireless.Visible = True
        Me.Hide()
    End Sub
End Class