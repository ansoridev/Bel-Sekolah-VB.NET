Public Class DetailJadwal
    Private Sub DetailJadwal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        started()
    End Sub
    Dim hariii
    Function lb(ByRef hari As String)
        listboxing("SELECT * FROM Jadwal WHERE Hari = '" & hari & "' ORDER BY Jam", ListBox1, "Jam")
        Return True
    End Function
    Sub started()
        Select Case hariku
            Case "Senin", "Monday"
                dr.Close()
                lb("Senin")
                jadwalbeltxt.Text = "Jadwal Bel Senin"
            Case "Selasa", "Tuesday"
                dr.Close()
                lb("Selasa")
                jadwalbeltxt.Text = "Jadwal Bel Selasa"
            Case "Rabu", "Wednesday"
                dr.Close()
                lb("Rabu")
                jadwalbeltxt.Text = "Jadwal Bel Rabu"
            Case "Kamis", "Thursday"
                dr.Close()
                lb("Kamis")
                jadwalbeltxt.Text = "Jadwal Bel Kamis"
            Case "Jum'at", "Friday", "Jumat"
                dr.Close()
                lb("Jumat")
                jadwalbeltxt.Text = "Jadwal Bel Jum'at"
            Case "Sabtu", "Saturday"
                dr.Close()
                lb("Sabtu")
                jadwalbeltxt.Text = "Jadwal Bel Sabtu"
            Case "Minggu", "Sunday"
                dr.Close()
                lb("Minggu")
                jadwalbeltxt.Text = "Jadwal Bel Minggu"
            Case "Puasa"
                dr.Close()
                lb("Puasa")
                jadwalbeltxt.Text = "Jadwal Bel Puasa"
            Case "Ujian"
                dr.Close()
                lb("Ujian")
                jadwalbeltxt.Text = "Jadwal Bel Ujian"
            Case Else
                dr.Close()
                listboxing("SELECT * FROM Jadwal WHERE Hari = 'Senin'", ListBox1, "Jam")
        End Select

        addbtn.Enabled = True
        editbtn.Enabled = True
        delbtn.Enabled = True
        namanya.Enabled = False
        harinya.Enabled = False
        jamnya.Enabled = False
        lokasifilenya.Enabled = False
        volumenya.Enabled = False
        savebtn.Enabled = False
        cancelbtn.Enabled = False

        db("SELECT * FROM Pengaturan", tipe.read)
        If dr.Read() Then
            hariii = dr("Hari")
            dr.Close()
            dbgrid("SELECT * FROM [Jadwal] WHERE Hari = '" & hariii & "'", "Jadwal", GunaDataGridView1)
            GunaDataGridView1.Columns(0).Visible = False
        End If

        namanya.Text = ""
        harinya.Text = hariii
        jamnya.Text = ""
        lokasifilenya.Text = ""
        volumenya.Text = ""
    End Sub
    Sub modeku()
        addbtn.Enabled = False
        editbtn.Enabled = False
        delbtn.Enabled = False
        namanya.Enabled = True
        harinya.Enabled = True
        jamnya.Enabled = True
        lokasifilenya.Enabled = True
        volumenya.Enabled = True
        savebtn.Enabled = True
        cancelbtn.Enabled = True

        db("SELECT * FROM Pengaturan", tipe.read)
        If dr.Read() Then
            hariii = dr("Hari")
            dr.Close()
            dbgrid("SELECT * FROM [Jadwal] WHERE Hari = '" & hariii & "'", "Jadwal", GunaDataGridView1)
            GunaDataGridView1.Columns(0).Visible = False
        End If
    End Sub

    Private Sub label1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Dim idnya, modenya

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        modenya = "add"
        modeku()
    End Sub

    Private Sub editbtn_Click(sender As Object, e As EventArgs) Handles editbtn.Click
        modenya = "edit"
        modeku()
    End Sub

    Private Sub delbtn_Click(sender As Object, e As EventArgs) Handles delbtn.Click
        modenya = "del"
        modeku()
    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        Dim id1
        If modenya = "add" Then
            db("SELECT (ID) FROM Jadwal ORDER BY ID DESC LIMIT 1", tipe.read)
            If dr.Read() Then
                id1 = dr("ID") + 1
            End If
            db("INSERT INTO Jadwal VALUES('" & id1 & "','" & namanya.Text & "', '" & harinya.Text & "', '" & jamnya.Text & "', '" & lokasifilenya.Text & "', '" & volumenya.Text & "')", tipe.exe)
            MsgBox("Jadwal telah berhasil ditambahkan!", vbInformation)
            ElseIf modenya = "edit" Then
                db("UPDATE Jadwal SET Nama = '" & namanya.Text & "', Hari = '" & harinya.Text & "', Jam = '" & jamnya.Text & "', LokasiFile = '" & lokasifilenya.Text & "', Volume = '" & volumenya.Text & "' WHERE ID = '" & idnya & "'", tipe.exe)
                MsgBox("Jadwal telah berhasil diubah!", vbInformation)
            ElseIf modenya = "del" Then
                Dim pesan = MsgBox("Apakah anda yakin untuk menghapus jadwal yang telah dipilih?", vbQuestion + vbYesNo, vbCritical)
                If pesan = vbYes Then
                    db("DELETE Jadwal WHERE ID = '" & idnya & "'", tipe.exe)
                    MsgBox("Jadwal telah berhasil dihapus!", vbInformation)
                End If
            End If
            started()
            HalamanUtama.repres()
            Dashboard.bacaArray()
    End Sub
    Private Sub volumenya_TextChanged(sender As Object, e As EventArgs) Handles volumenya.Click
        If IsNumeric(volumenya.Text) Then
        Else
            MsgBox("Hanya masukkan nomor saja!", vbInformation)
            volumenya.Text = ""
        End If
    End Sub
    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        started()
    End Sub
    Private Sub GunaDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellClick
        If GunaDataGridView1.Rows(e.RowIndex).Cells(0).Value Then
            idnya = GunaDataGridView1.Rows(e.RowIndex).Cells(0).Value

            namanya.Text = GunaDataGridView1.Rows(e.RowIndex).Cells(1).Value
            harinya.Text = GunaDataGridView1.Rows(e.RowIndex).Cells(2).Value
            jamnya.Text = GunaDataGridView1.Rows(e.RowIndex).Cells(3).Value
            lokasifilenya.Text = GunaDataGridView1.Rows(e.RowIndex).Cells(4).Value
            volumenya.Text = GunaDataGridView1.Rows(e.RowIndex).Cells(5).Value
        Else

        End If
    End Sub
End Class