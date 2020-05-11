Imports System.Data.SqlClient
Public Class HalamanUtama
    Dim haricok
    Private Sub HalamanUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        db("SELECT * FROM Pengaturan", tipe.read)
        If dr.Read() Then
            haricok = dr("hari")
        End If
    End Sub
    Sub senen()
        jadwalbeltxt.Text = "Jadwal Bel Senin"
        jadwalbeltxt.BaseColor = btnsenin.BaseColor
        listboxing("SELECT * FROM Jadwal WHERE Hari = 'Senin' ORDER BY Jam", ListBox1, "Jam")

    End Sub
    Sub selasa()
        jadwalbeltxt.Text = "Jadwal Bel Selasa"
        jadwalbeltxt.BaseColor = btnselasa.BaseColor
        listboxing("SELECT * FROM Jadwal WHERE Hari = 'Selasa' ORDER BY Jam", ListBox1, "Jam")
    End Sub
    Sub rabo()
        jadwalbeltxt.Text = "Jadwal Bel Rabu"
        jadwalbeltxt.BaseColor = btnrabu.BaseColor
        listboxing("SELECT * FROM Jadwal WHERE Hari = 'Rabu' ORDER BY Jam", ListBox1, "Jam")
    End Sub
    Sub kames()
        jadwalbeltxt.Text = "Jadwal Bel Kamis"
        jadwalbeltxt.BaseColor = btnkamis.BaseColor
        listboxing("SELECT * FROM Jadwal WHERE Hari = 'Kamis' ORDER BY Jam", ListBox1, "Jam")
    End Sub
    Sub jumat()
        jadwalbeltxt.Text = "Jadwal Bel Jum'at"
        jadwalbeltxt.BaseColor = btnjumat.BaseColor
        listboxing("SELECT * FROM Jadwal WHERE Hari = 'Jumat' ORDER BY Jam", ListBox1, "Jam")
    End Sub
    Sub sabtu()
        jadwalbeltxt.Text = "Jadwal Bel Sabtu"
        jadwalbeltxt.BaseColor = btnsabtu.BaseColor
        listboxing("SELECT * FROM Jadwal WHERE Hari = 'Sabtu' ORDER BY Jam", ListBox1, "Jam")
    End Sub
    Sub minggu()
        jadwalbeltxt.Text = "Jadwal Bel Ahad"
        jadwalbeltxt.BaseColor = btnahad.BaseColor
        listboxing("SELECT * FROM Jadwal WHERE Hari = 'Minggu' ORDER BY Jam", ListBox1, "Jam")
    End Sub
    Sub puasa()
        jadwalbeltxt.Text = "Jadwal Bel Puasa"
        jadwalbeltxt.BaseColor = btnpuasa.BaseColor
        listboxing("SELECT * FROM Jadwal WHERE Hari = 'Puasa' ORDER BY Jam", ListBox1, "Jam")
    End Sub
    Sub ujian()
        jadwalbeltxt.Text = "Jadwal Bel Ujian"
        jadwalbeltxt.BaseColor = btnujian.BaseColor
        listboxing("SELECT * FROM Jadwal WHERE Hari = 'Ujian' ORDER BY Jam", ListBox1, "Jam")
    End Sub
    Public Sub btnsenin_Click(sender As Object, e As EventArgs) Handles btnsenin.Click
        db("UPDATE [Pengaturan] SET [Hari] = 'Senin'", exe)
        Dashboard.bacaArray()
        senen()
    End Sub

    Public Sub btnselasa_Click(sender As Object, e As EventArgs) Handles btnselasa.Click
        db("UPDATE [Pengaturan] SET [Hari] = 'Selasa'", exe)
        Dashboard.bacaArray()
        selasa()
    End Sub

    Public Sub btnrabu_Click(sender As Object, e As EventArgs) Handles btnrabu.Click
        db("UPDATE [Pengaturan] SET [Hari] = 'Rabu'", exe)
        Dashboard.bacaArray()
        rabo()
    End Sub

    Public Sub btnkamis_Click(sender As Object, e As EventArgs) Handles btnkamis.Click
        db("UPDATE [Pengaturan] SET [Hari] = 'Kamis'", exe)
        Dashboard.bacaArray()
        kames()
    End Sub

    Public Sub btnjumat_Click(sender As Object, e As EventArgs) Handles btnjumat.Click
        db("UPDATE [Pengaturan] SET [Hari] = 'Jumat'", exe)
        Dashboard.bacaArray()
        jumat()
    End Sub

    Public Sub btnsabtu_Click(sender As Object, e As EventArgs) Handles btnsabtu.Click
        db("UPDATE [Pengaturan] SET [Hari] = 'Sabtu'", exe)
        Dashboard.bacaArray()
        sabtu()
    End Sub

    Public Sub btnahad_Click(sender As Object, e As EventArgs) Handles btnahad.Click
        db("UPDATE [Pengaturan] Set [Hari] = 'Minggu'", exe)
        Dashboard.bacaArray()
        minggu()
    End Sub

    Public Sub btnpuasa_Click(sender As Object, e As EventArgs) Handles btnpuasa.Click
        db("UPDATE [Pengaturan] Set [Hari] = 'Puasa'", exe)
        Dashboard.bacaArray()
        puasa()
    End Sub

    Public Sub btnujian_Click(sender As Object, e As EventArgs) Handles btnujian.Click
        db("UPDATE [Pengaturan] Set [Hari] = 'Ujian'", exe)
        Dashboard.bacaArray()
        ujian()
    End Sub

    Public Sub jadwalbeltxt_Click(sender As Object, e As EventArgs) Handles jadwalbeltxt.Click
        GunaShadowPanel1.Visible = False
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        JadwalAuth.Show()
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        JadwalAuth.Show()
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        JadwalAuth.Show()
    End Sub
    Public Sub repres()
        Select Case haricok
            Case "Senin", "Monday"
                dr.Close()
                senen()
            Case "Selasa", "Tuesday"
                dr.Close()
                selasa()
            Case "Rabu", "Wednesday"
                dr.Close()
                rabo()
            Case "Kamis", "Thursday"
                dr.Close()
                kames()
            Case "Jum'at", "Friday", "Jumat"
                dr.Close()
                jumat()
            Case "Sabtu", "Saturday"
                dr.Close()
                sabtu()
            Case "Minggu", "Sunday"
                dr.Close()
                minggu()
            Case "Puasa"
                dr.Close()
                puasa()
            Case "Ujian"
                dr.Close()
                ujian()
            Case Else
                dr.Close()
                minggu()
        End Select
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If laststr = "" Then
            Label4.Text = "Dini Hari"
            Label4.Text = nextstr
        Else
            Label2.Text = laststr
            Label4.Text = nextstr
        End If
    End Sub
End Class