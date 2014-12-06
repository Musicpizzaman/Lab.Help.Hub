Public Class wireless

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        index.Visible = True
        Me.Hide()
    End Sub

    Private Sub wireless_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub


End Class