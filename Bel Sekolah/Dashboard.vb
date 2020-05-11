Imports System.Globalization
Imports System.Data.SqlClient
Public Class Dashboard
    Dim arraylist As New ArrayList
    Dim jumlahArray, ye, haricek

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer1.Interval = 200
        switchPanel(HalamanUtama, Panel2)

        HalamanUtama.repres()

        If Format(CDate(Date.Now), "dddd") = "Jum'at" Or Format(CDate(Date.Now), "dddd") = "Friday" Then
            db("UPDATE Pengaturan SET Hari = 'Jumat'", exe)
        Else
            Select Case Format(CDate(Date.Now), "dddd")
                Case "Sunday", "Minggu"
                    db("UPDATE Pengaturan SET Hari = 'Minggu'", exe)
                Case "Monday", "Senin"
                    db("UPDATE Pengaturan SET Hari = 'Senin'", exe)
                Case "Tuesday", "Selasa"
                    db("UPDATE Pengaturan SET Hari = 'Selasa'", exe)
                Case "Wednesday", "Rabu"
                    db("UPDATE Pengaturan SET Hari = 'Rabu'", exe)
                Case "Thursday", "Kamis"
                    db("UPDATE Pengaturan SET Hari = 'Kamis'", exe)
                Case "Saturday", "Sabtu"
                    db("UPDATE Pengaturan SET Hari = 'Sabtu'", exe)
            End Select
        End If

        Console.WriteLine(Format(CDate(Date.Now), "dddd"))

        Select Case Format(CDate(Date.Now), "dddd")
            Case "Sunday", "Minggu"
                haricek = "Minggu"
            Case "Monday", "Senin"
                haricek = "Senin"
            Case "Tuesday", "Selasa"
                haricek = "Selasa"
            Case "Wednesday", "Rabu"
                haricek = "Rabu"
            Case "Thursday", "Kamis"
                haricek = "Kamis"
            Case "Friday", "Jum'at"
                haricek = "Jumat"
            Case "Saturday", "Sabtu"
                haricek = "Sabtu"
        End Select

        hariku = "Monday"

        db("SELECT * FROM Pengaturan", read)
        Try
            dr.Read()
            hariku = dr("Hari")
            If dr("Status") = "ON" Then
                onoffbtn.Checked = True
                onoffbtn.Text = "ON"
            Else
                onoffbtn.Checked = False
                onoffbtn.Text = "OFF"
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Koneksi Gagal")
        End Try

        Console.WriteLine(hariku)

        db("SELECT * FROM Pengaturan", tipe.read)
        If dr.Read() Then
            statusskrng = dr("Status")
            dr.Close()
        End If


        bacaArray()
    End Sub

    Dim jamA, fileA, volA
    Dim f As Integer

    Public Sub bacaArray()
        Console.WriteLine("Baca array dipanggil")
        Dim haricek1
        Select Case Format(CDate(Date.Now), "dddd")
            Case "Sunday", "Minggu"
                haricek1 = "Minggu"
            Case "Monday", "Senin"
                haricek1 = "Senin"
            Case "Tuesday", "Selasa"
                haricek1 = "Selasa"
            Case "Wednesday", "Rabu"
                haricek1 = "Rabu"
            Case "Thursday", "Kamis"
                haricek1 = "Kamis"
            Case "Friday", "Jum'at"
                haricek1 = "Jumat"
            Case "Saturday", "Sabtu"
                haricek1 = "Sabtu"
        End Select

        db("SELECT * FROM Pengaturan", read)
        If dr.Read() Then
            hariku = dr("Hari")
        End If

        db("SELECT COUNT(Hari) FROM Jadwal WHERE Hari = '" & hariku & "'", tipe.read)
        If dr.Read() Then
            jumlahArray = dr("COUNT(Hari)") - 1
            Console.WriteLine(jumlahArray)
            dr.Close()
        End If

        Dim i(jumlahArray) 'Jam
        Dim j(jumlahArray) 'File
        Dim k(jumlahArray) 'Volume

        Dim n = 0

        db("SELECT * FROM Jadwal WHERE Hari = '" & hariku & "' ORDER BY Jam", read)
        While dr.Read()
            i(n) = dr("Jam")
            j(n) = dr("LokasiFile")
            k(n) = dr("Volume")
            If n = i.Length - 1 Then
            Else
                n += 1
            End If
        End While

        jamA = i
        fileA = j
        volA = k
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim haricek1 = Format(CDate(Date.Now), "dddd")
        If haricek1 = haricek Then
        Else
            If Format(CDate(Date.Now), "dddd") = "Jum'at" Or Format(CDate(Date.Now), "dddd") = "Friday" Then
                db("UPDATE [Pengaturan] SET [Hari] = 'Jumat'", exe)
            Else
                Select Case Format(CDate(Date.Now), "dddd")
                    Case "Sunday", "Minggu"
                        hariku = "Minggu"
                        db("UPDATE Pengaturan SET Hari = '" & hariku & "'", exe)
                        HalamanUtama.repres()
                    Case "Monday", "Senin"
                        hariku = "Senin"
                        db("UPDATE Pengaturan SET Hari = '" & hariku & "'", exe)
                        HalamanUtama.repres()
                    Case "Tuesday", "Selasa"
                        hariku = "Selasa"
                        db("UPDATE Pengaturan SET Hari = '" & hariku & "'", exe)
                        HalamanUtama.repres()
                    Case "Wednesday", "Rabu"
                        hariku = "Rabu"
                        db("UPDATE Pengaturan SET Hari = '" & hariku & "'", exe)
                        HalamanUtama.repres()
                    Case "Thursday", "Kamis"
                        hariku = "Kamis"
                        db("UPDATE Pengaturan SET Hari = '" & hariku & "'", exe)
                        HalamanUtama.repres()
                    Case "Saturday", "Sabtu"
                        hariku = "Sabtu"
                        db("UPDATE Pengaturan SET Hari = '" & hariku & "'", exe)
                        HalamanUtama.repres()
                End Select
            End If
            haricek = hariku
        End If

        Label2.Text = TimeOfDay
        GunaLabel1.Text = Format(CDate(Date.Now), "dddd, dd MMMM yyyy")

        If statusskrng = "ON" Then
            Try
                nextstr = jamA(berikutnya)
                For f = 0 To jumlahArray
                    Console.WriteLine(jamA(f))
                    If TimeOfDay = jamA(f) Then
                        stopMusic()
                        playmusic(fileA(f), volA(f))
                        laststr = jamA(f)
                        berikutnya = f + 1
                        nextstr = jamA(f)
                    End If
                Next
            Catch ex As Exception
            End Try
        Else
            stopMusic()
        End If

        Dim str As String
        Dim strArr() As String


        indexya = -1
        Dim selisih = 86400
        Dim waktusekarang = TimeOfDay.Hour * 3600 + TimeOfDay.Minute * 60 + TimeOfDay.Second
        Dim waktuskrng2

        For f = 0 To jumlahArray

            str = jamA(f)
            strArr = str.Split(".")

            js = strArr(0)
            ms = strArr(1)
            ds = strArr(2)

            waktuskrng2 = js * 3600 + ms * 60 + ds

            If waktusekarang - waktuskrng2 < selisih And waktusekarang - waktuskrng2 > 0 Then
                selisih = waktusekarang - waktuskrng2
                indexya = f
            End If
        Next

        Console.WriteLine(indexya)
        Try
            If indexya < 0 Then
                laststr = "Dini Hari"
                nextstr = jamA(indexya + 1)
            Else
                laststr = jamA(indexya)
                nextstr = jamA(indexya + 1)
            End If
        Catch exa As Exception
            Try
                nextstr = "Sudah Pulang"
                laststr = jamA(jumlahArray)
            Catch ex As Exception
                nextstr = "Tidak ada jadwal selanjutnya."
                laststr = "Tidak ada jadwal terakhir."
            End Try
        End Try
        Console.WriteLine(indexya)
    End Sub
    Dim indexya, selisih2, js, ms, ds
    Dim nganuskrng = 0
    Private Sub GunaAdvenceButton4_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton4.Click
        If GunaAdvenceButton4.Checked = True Then
            GunaAdvenceButton4.Checked = False
            switchPanel(HalamanUtama, Panel2)
            refreshmenu()
        Else
            refreshmenu()
            GunaAdvenceButton4.Checked = True
            switchPanel(HalamanUtama, Panel2)
        End If
    End Sub

    Private Sub onoffbtn_Click(sender As Object, e As EventArgs) Handles onoffbtn.Click
        If onoffbtn.Checked = True Then
            onoffbtn.Checked = False
            onoffbtn.Text = "OFF"
            db("UPDATE Pengaturan SET Status='OFF'", exe)
            statusskrng = "OFF"
            switchPanel(HalamanUtama, Panel2)
            stopMusic()
        Else
            onoffbtn.Checked = True
            onoffbtn.Text = "ON"
            db("UPDATE Pengaturan SET Status='ON'", exe)
            statusskrng = "ON"
            switchPanel(HalamanUtama, Panel2)
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Dim pesan As String = MsgBox("Apakah anda yakin ingin menghentikan aplikasi ini?", vbQuestion + vbOKCancel, vbInformation)
        If pesan = vbOK Then
            Me.Close()
        End If
    End Sub

    Function refreshmenu()
        GunaAdvenceButton2.Checked = False
        GunaAdvenceButton3.Checked = False
        GunaAdvenceButton4.Checked = True
        If GunaAdvenceButton4.Checked = False Then
            GunaAdvenceButton4.Checked = True
            switchPanel(HalamanUtama, Panel2)
        Else
            GunaAdvenceButton4.Checked = False
            switchPanel(HalamanUtama, Panel2)
        End If
        Return True
    End Function

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        If GunaAdvenceButton3.Checked = True Then
            GunaAdvenceButton3.Checked = False
            switchPanel(About, Panel2)
            refreshmenu()
        Else
            refreshmenu()
            GunaAdvenceButton3.Checked = True
            switchPanel(About, Panel2)
        End If
    End Sub

    Private Sub label1_Click_1(sender As Object, e As EventArgs) Handles label1.Click
        Dim pesan = MsgBox("Apakah anda yakin untuk menutup program ini?", vbQuestion + vbOKCancel, vbInformation)
        If pesan = vbOK Then
            Me.Close()
        End If
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        If GunaAdvenceButton2.Checked = True Then
            GunaAdvenceButton2.Checked = False
            switchPanel(Katasandi, Panel2)
            refreshmenu()
        Else
            refreshmenu()
            switchPanel(Katasandi, Panel2)
            GunaAdvenceButton2.Checked = True
        End If
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
