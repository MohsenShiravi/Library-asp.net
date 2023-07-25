Imports System.DateTime
Imports System.Globalization
Imports System.String
Imports System.Data.SqlClient
Imports System.IO



Public Class FormMain


    Public con As New SqlConnection(ConnectionString)
    Public modirUserName As String = "Admin"
    Dim pc As New PersianCalendar
    Dim arrayeRooz As String() = {"یکشنبه", "دوشنبه", "سه شنبه", "چهارشنبه", "پنج شنبه", "جمعه", "شنبه"}

    Private Property ConnectionString() As String
        Get
            Try
                Dim strDirectory As String = Directory.GetCurrentDirectory() + "\ConnectionString.txt"
                Dim strConn As String = File.ReadAllText(strDirectory).ToString()
                Return strConn
            Catch ex As Exception
                MsgBox(ex.Message.ToString(), MsgBoxStyle.Critical)
                Me.Close()
                Return Directory.GetCurrentDirectory() + "\ConnectionString.txt"
            End Try
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Private Sub خروجToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles خروجToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub FormMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If lblWelcome1.Text <> "کاربر" Then
            Dim strResualt As String = MsgBox("آیا برای خروج از برنامه اطمینان دارید؟", MsgBoxStyle.YesNo, "خروج از برنامه")
            If strResualt = MsgBoxResult.Yes Then
                Application.Exit()
            ElseIf strResualt = MsgBoxResult.No Then
                e.Cancel() = True
            End If
        Else
            Application.Exit()
        End If
    End Sub

    Private Sub FormMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'System.Windows.Forms.InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages(1)
        lblWelcome1.Text = "کاربر"
        Dim SignIN As New SignIN
        SignIN.ShowDialog()
        If lblWelcome1.Text = "کاربر" Then
            Application.Exit()
        End If
        MinimizeBox() = True
    End Sub

    Private Sub ثبتکتابToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ثبتکتابToolStripMenuItem.Click
        Dim EditBooks As New EditBooks
        EditBooks.Show()
    End Sub

    Private Sub جستجوکتابToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جستجوکتابToolStripMenuItem.Click
        Dim search As New SearchBook
        search.ShowDialog()
    End Sub

    Private Sub دربارهبرنامهنویسToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles دربارهبرنامهنویسToolStripMenuItem.Click
        Dim ab As New AboutBox
        ab.ShowDialog()

    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub گزارشفروشToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles گزارشفروشToolStripMenuItem.Click
        Dim GF As New TrustDetails
        GF.Show()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub

    Private Sub ToolStripButton7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim foroosh As New Trust
        foroosh.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeString.ToString
        Dim strRooz As String = pc.GetDayOfMonth(Now).ToString("00")
        Dim strMah As String = pc.GetMonth(Now).ToString("00")
        Dim strSal As String = pc.GetYear(Now).ToString()
        lblDay.Text = arrayeRooz(Now.DayOfWeek).ToString
        LblDate.Text = strSal & "/" & strMah & "/" & strRooz
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        دربارهبرنامهنویسToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim SearchBook As New SearchBook
        SearchBook.ShowDialog()
    End Sub

    Private Sub ToolStrip3_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip3.ItemClicked

    End Sub

    Private Sub جستجوکاربرانToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جستجوکاربرانToolStripMenuItem.Click
        Dim Users As New Users
        Users.Show()
    End Sub

    Private Sub ثبتکاربرانToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ثبتکاربرانToolStripMenuItem.Click
        Dim EditUsers As New EditUsers
        EditUsers.Show()
    End Sub

    Private Sub ثبتمدیرانToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ثبتمدیرانToolStripMenuItem.Click
        Dim EditManagers As New EditManagers
        EditManagers.Show()
    End Sub

    Private Sub ToolStripButton5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton5_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.MouseHover
        ToolStripButton5.ForeColor.GetHue()
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Dim Trust As New Trust
        Trust.Show()
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim SearchBook As New SearchBook
        SearchBook.Show()
    End Sub
End Class
