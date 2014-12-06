Public Class index

    'Author = David Otero

    Dim todaysDate As String = String.Format("{0:dd/MM/yyyy}", DateTime.Now)

    Private Sub index_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim csvFile As String = My.Application.Info.DirectoryPath & "\CheckIn.csv"
        Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, True)

        outFile.WriteLine(TimeOfDay + "," + todaysDate)
        outFile.Close()

        thankyou.Visible = True
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        FAq.Visible = True
        Me.Hide()
    End Sub
End Class
