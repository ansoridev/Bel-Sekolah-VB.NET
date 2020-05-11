Public Class JadwalAuth
    Private Sub GunaTextBox1_TextChanged(sender As Object, e As EventArgs) Handles GunaTextBox1.Click
        Label1.Text = ""
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label1.Text = ""
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        db("SELECT * FROM [Pengaturan] WHERE Password = '" & GunaTextBox1.Text & "'", tipe.read)
        If dr.Read() Then
            dr.Close()
            DetailJadwal.Show()
            Me.Close()
        Else
            MsgBox("Password anda salah!", vbCritical)
        End If
    End Sub

    Private Sub JadwalAuth_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GunaTextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles GunaTextBox1.TextChanged

    End Sub
End Class