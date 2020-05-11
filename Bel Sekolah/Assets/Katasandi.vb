Public Class Katasandi
    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        If GunaTextBox2.Text = GunaTextBox3.Text Then
            db("SELECT * FROM [Pengaturan] WHERE Password = '" & GunaTextBox1.Text & "'", tipe.read)
            If dr.Read() Then
                dr.Close()
                db("UPDATE [Pengaturan] SET Password = '" & GunaTextBox2.Text & "'", tipe.exe)
                MsgBox("Data telah berhasil diubah", vbInformation)
            Else
                MsgBox("Password Lama Salah", vbCritical)
            End If
        Else
            MsgBox("Password tidak sama!", vbInformation)
            GunaTextBox3.Text = ""
            GunaTextBox2.Text = ""
        End If
    End Sub
End Class