Imports System.IO
Imports System.Data.SQLite
Imports WMPLib

Module settings
    Public Conn As SQLiteConnection
    Public da As SQLiteDataAdapter
    Public ds As DataSet
    Public cmd As SQLiteCommand
    Public dr As SQLiteDataReader
    Public dt As DataTable
    Public read, exe As tipe
    Public berikutnya = 0

    Dim Player As WindowsMediaPlayer = New WindowsMediaPlayer

    Public jumlahArray, hariku, statusskrng, kehabisanarray, lokasibel, volnya, laststr, nextstr
    Function switchPanel(ByRef panel As Form, ByRef panelname As Panel)
        panelname.Controls.Clear()
        panel.TopLevel = False
        panelname.Controls.Add(panel)
        panel.Show()
        Return True
    End Function
    Function connect()
        Dim LokasiDB = "Data Source=db.sqlite;"
        Conn = New SQLiteConnection(LokasiDB)
        Try
            Conn.Open()
        Catch ex As Exception
            MsgBox("Connection Failed!", vbCritical)
        End Try
        Return True
    End Function
    Function db(ByRef dbquery As String, ByRef tipe As tipe)
        connect()
        If tipe = tipe.exe Then
            cmd = New SQLiteCommand(dbquery + ";", Conn)
            Return cmd.ExecuteNonQuery().ToString()
        ElseIf tipe = tipe.read Then Thenk
            cmd = New SQLiteCommand(dbquery + ";", Conn)
            dr = cmd.ExecuteReader()
        End If
        Return True
    End Function
    Function dbgrid(ByRef dbquery As String, ByRef gridtable As String, ByRef datagridview As DataGridView)
        connect()
        da = New SQLiteDataAdapter(dbquery + ";", Conn)
        ds = New DataSet
        da.Fill(ds, gridtable)
        datagridview.DataSource = ds
        datagridview.DataMember = gridtable

        Return True
    End Function
    Function listboxing(ByRef dbquery As String, ByRef listbox As ListBox, ByRef col As String)
        connect()
        da = New SQLiteDataAdapter(dbquery + ";", Conn)
        dt = New DataTable
        da.Fill(dt)
        listbox.DataSource = dt
        listbox.DisplayMember = col

        Return True
    End Function
    Function playmusic(ByRef filename As String, ByRef volume As Integer)
        Dim SongLocation = Path.Combine(Application.StartupPath, filename)
        Player.URL = SongLocation
        Player.settings.volume = volume
        Player.controls.play()
        Return True
    End Function
    Sub stopMusic()
        Player.controls.stop()
    End Sub
    Public Enum tipe
        read
        exe
    End Enum
End Module
