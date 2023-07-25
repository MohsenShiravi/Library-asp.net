Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data
Imports System.Globalization

Public Class Trust
    Dim pc As New PersianCalendar
    Dim dst As New DataSet

    Private Sub btnFactor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFactor.Click
        Try
            If txtUsID.Text <> Nothing And IsNumeric(txtUsID.Text) And txtUsDetails.Text <> "" Then
                btnInsertKetab.Enabled = True

                Dim strRooz As String = pc.GetDayOfMonth(Now).ToString("00")
                Dim strMah As String = pc.GetMonth(Now).ToString("00")
                Dim strDate As String = pc.GetYear(Now) & strMah & strRooz
                Dim strTime As String = Now.Hour.ToString("00") & Now.Minute.ToString("00") & Now.Second.ToString("00")
                Dim strDateTime As String = strDate & strTime
                Dim cmd As New SqlCommand("spInsertTrust", FormMain.con)
                Dim param As New SqlParameter
                cmd.Parameters.AddWithValue("TrDate", strDateTime)
                cmd.Parameters.AddWithValue("TrReturnDate", Nothing)
                cmd.Parameters.AddWithValue("UsID", txtUsID.Text)
                cmd.Parameters.AddWithValue("KetabID", Nothing)
                param = cmd.Parameters.AddWithValue("returnValue", DbType.Int16)
                cmd.CommandType = CommandType.StoredProcedure
                param.Direction = ParameterDirection.ReturnValue
                If FormMain.con.State = ConnectionState.Closed Then
                    FormMain.con.Open()
                End If
                cmd.ExecuteNonQuery()
                FormMain.con.Close()
                txtTrID.Text = param.Value
                LabelKetab.Text = 0

            Else
                txtUsDetails.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub ForooshForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'txtTedad.Text = "1"
        'BindComboBox()
        'cbKala.SelectedIndex = -1
    End Sub

    Private Function FnCheckKetabMojood(ByVal KetabID As String) As Boolean
        Try
            Dim shart1, shart2 As Boolean
            Dim Adapter1 As New SqlDataAdapter("Select * from tKetab where tKetab.ketabMojood=1 and ketabID=" + txtKetabID.Text.ToString(), FormMain.con)
            Dim Adapter2 As New SqlDataAdapter("Select * from tTrust where TrID in (Select top 1 TrID from tTrust where ketabID=" + txtKetabID.Text + " order by TrID Desc) and TrReturnDate is not null and ketabID=" + txtKetabID.Text, FormMain.con)
            Dim Adapter3 As New SqlDataAdapter("Select * from tTrust where ketabID=" + txtKetabID.Text, FormMain.con)
            Dim dst As New DataSet()
            Adapter1.Fill(dst, "Ketab")
            Adapter2.Fill(dst, "Trust")
            Adapter3.Fill(dst, "Trust3")
            If dst.Tables("Ketab").Rows.Count <> 0 Then
                shart1 = True
            Else
                shart1 = False
            End If
            If dst.Tables("Trust3").Rows.Count <> 0 Then
                If dst.Tables("Trust").Rows.Count <> 0 Then
                    shart2 = True
                Else
                    shart2 = False
                End If
            Else
                shart2 = True
            End If

            If shart1 = True And shart2 = True Then
                Return True
            Else
                Return False
            End If
            FormMain.con.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MsgBoxStyle.OkOnly)
        End Try
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertKetab.Click
        Try
            If txtKetabID.Text <> "" And IsNumeric(txtKetabID.Text) And txtKetabDetails.Text <> "" And txtTrID.Text <> "" And IsNumeric(txtTrID.Text) Then
                If FnCheckKetabMojood(txtKetabID.Text) = True Then
                    'sbKetabBeUser(LabelKetab.Text, True)
                    'Dim cmd As New SqlCommand("Update tTrust set KetabID=@KetabID where TrID=@TrID", FormMain.con)
                    'cmd.Parameters.AddWithValue("@TrID", txtTrID.Text)
                    'cmd.Parameters.AddWithValue("@KetabID", txtKetabID.Text)
                    'FormMain.con.Open()
                    'cmd.ExecuteNonQuery()
                    'FormMain.con.Close()
                    sbKetabState(False)
                    ShowTrDetails()
                    LabelKetab.Text = txtKetabID.Text
                    btnInsertKetab.Enabled = False
                Else
                    MsgBox("کتاب با شناسه : " + txtKetabID.Text + " در امانت می باشد !", MsgBoxStyle.OkOnly, "نبود کتاب")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub sbKetabState(ByVal MojoodDarKetabkhoone As Boolean)
        Try
            Dim cmd As New SqlCommand("Update tKetab set ketabMojood=@ketabMojood where KetabID=@KetabID", FormMain.con)
            cmd.Parameters.AddWithValue("@ketabMojood", MojoodDarKetabkhoone)
            cmd.Parameters.AddWithValue("@KetabID", txtKetabID.Text)

            Dim cmd2 As New SqlCommand("Update tTrust set KetabID=@KetabID where TrID=@TrID", FormMain.con)
            cmd2.Parameters.AddWithValue("@TrID", txtTrID.Text)
            cmd2.Parameters.AddWithValue("@KetabID", txtKetabID.Text)

            If FormMain.con.State = ConnectionState.Closed Then
                FormMain.con.Open()
            End If
            cmd.ExecuteNonQuery()
            cmd2.ExecuteNonQuery()
            FormMain.con.Close()

        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtFactorID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTrID.TextChanged
        txtKetabID.Text = ""
        If txtTrID.Text <> "" And IsNumeric(txtTrID.Text) Then
            GroupBox1.Enabled = True
            ShowUsDetails()
            ShowTrDetails()
            ShowUsThisTr()
            ShowKetabThisTr()
        Else
            ShowTrDetails()
            GroupBox1.Enabled = False
        End If
    End Sub
    Private Sub ShowUsThisTr()
        Try
            If FormMain.con.State = ConnectionState.Closed Then
                FormMain.con.Open()
            End If
            Dim Adapter As New SqlDataAdapter("Select * from tTrust inner join tUsers on tUsers.UsID = tTrust.UsID where tTrust.TrID=" + txtTrID.Text.ToString(), FormMain.con)
            Dim dst As New DataSet()
            Adapter.Fill(dst, "tUs")
            txtUsID.Text = dst.Tables("tUs").Rows(0).Item("UsID").ToString
            txtUsDetails.Text = "شناسه کاربر :" + dst.Tables("tUs").Rows(0).Item("UsID").ToString + "،نام کامل :" + dst.Tables("tUs").Rows(0).Item("UsName").ToString + " " + dst.Tables("tUs").Rows(0).Item("UsFamily").ToString + "، نام پدر :" + dst.Tables("tUs").Rows(0).Item("UsFatherName").ToString + "، تاریخ تمدید : " + dst.Tables("tUs").Rows(0).Item("UsRevivalDate").ToString
            FormMain.con.Close()
        Catch ex As Exception
            txtUsID.Text = ""
            txtKetabID.Text = ""
        End Try
    End Sub
    Private Sub ShowKetabThisTr()
        Try
            If FormMain.con.State = ConnectionState.Closed Then
                FormMain.con.Open()
            End If
            Dim Adapter As New SqlDataAdapter("Select * from tTrust where tTrust.TrID=" + txtTrID.Text.ToString(), FormMain.con)
            Dim dst As New DataSet()
            Adapter.Fill(dst, "tTr")
            If dst.Tables("tTr").Rows.Count <> 0 Then
                txtKetabID.Text = dst.Tables("tTr").Rows(0).Item("KetabID").ToString
            Else
                txtKetabID.Text = ""
            End If

            If txtKetabID.Text = "" Then
                btnInsertKetab.Enabled = True
            Else
                btnInsertKetab.Enabled = False
            End If

            FormMain.con.Close()
        Catch ex As Exception
            txtKetabID.Text = "0"
        End Try
    End Sub
    Private Sub ShowUsDetails()
        Try
            Dim cmd As New SqlCommand("Select * from tUsers where UsID=@UsID", FormMain.con)
            cmd.Parameters.AddWithValue("@UsID", txtUsID.Text.ToString())
            If FormMain.con.State = ConnectionState.Closed Then
                FormMain.con.Open()
            End If
            Dim Reader As SqlDataReader = cmd.ExecuteReader()
            If Reader.Read() Then
                txtUsDetails.Text = "شناسه کاربر :" + Reader.Item("UsID").ToString() + "،نام کامل :" + Reader.Item("UsName").ToString() + " " + Reader.Item("UsFamily").ToString() + "، نام پدر :" + Reader.Item("UsFatherName").ToString() + "، تاریخ تمدید : " + Reader.Item("UsRevivalDate").ToString()
            Else
                txtUsDetails.Text = ""
            End If
            Reader.Close()
            FormMain.con.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MsgBoxStyle.Critical)
        End Try

    End Sub
    Private Sub ShowTrDetails()
        Try
            Dim strcmd As String = ""
            If txtTrID.Text <> "" Then
                If IsNumeric(txtTrID.Text) Then
                    strcmd = "and tTrust.TrID = " + txtTrID.Text
                End If
            ElseIf txtTrID.Text = "" Then
                strcmd = "and tTrust.UsID = " + txtUsID.Text
            End If
            Dim strAdaptor As String
            strAdaptor = "select distinct tTrust.TrID,tKetab.KetabID,tKetab.KetabOnvan,tTrust.TrDate,tTrust.TrReturnDate from tTrust inner join tKetab on tTrust.KetabID=tKetab.KetabID where TrReturnDate is null " + strcmd
            Dim ada As New SqlDataAdapter(strAdaptor, FormMain.con)
            Dim dst1 As New DataSet
            ada.Fill(dst1, "TableTrustDetails")
            dgdFactorDetails.DataSource = dst1.Tables("TableTrustDetails")
            FormMain.con.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            If txtTrID.Text <> Nothing And IsNumeric(txtTrID.Text) And txtUsDetails.Text <> "" Then
                Dim strRooz As String = pc.GetDayOfMonth(Now).ToString("00")
                Dim strMah As String = pc.GetMonth(Now).ToString("00")
                Dim strDate As String = pc.GetYear(Now) & strMah & strRooz
                Dim strTime As String = Now.Hour.ToString("00") & Now.Minute.ToString("00") & Now.Second.ToString("00")
                Dim strDateTime As String = strDate & strTime
                Dim strCmd As String = "Update tTrust set TrReturnDate='" + strDateTime + "' where TrID=" + txtTrID.Text
                Dim cmd As New SqlCommand(strCmd, FormMain.con)
                If FormMain.con.State = ConnectionState.Closed Then
                    FormMain.con.Open()
                End If
                cmd.ExecuteNonQuery()
                FormMain.con.Close()
                sbKetabState(True)
                ShowTrDetails()
                ShowKetabDetails()
                LabelKetab.Text = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub TextBoxKetabID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKetabID.TextChanged
        ShowKetabDetails()
    End Sub

    Private Sub ShowKetabDetails()
        Try
            If txtKetabID.Text <> "" And IsNumeric(txtKetabID.Text) Then
                Dim cmd As New SqlCommand("Select * from tketab where KetabID=@ketabID", FormMain.con)
                cmd.Parameters.AddWithValue("@ketabID", txtKetabID.Text.ToString())
                If FormMain.con.State = ConnectionState.Closed Then
                    FormMain.con.Open()
                End If
                Dim Reader As SqlDataReader = cmd.ExecuteReader()
                txtKetabDetails.Text = ""
                If Reader.Read() Then
                    txtKetabDetails.Text += "نام کتاب :" + Reader.Item("KetabOnvan").ToString() + "، نام ناشر :" + Reader.Item("KetabNasher").ToString() + "، چاپ : " + Reader.Item("KetabNumChap").ToString() + "ام "
                End If
                Reader.Close()
                FormMain.con.Close()
            Else
                txtKetabDetails.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub txtUsID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsID.TextChanged
        Try
            If txtUsID.Text <> "" And IsNumeric(txtUsID.Text) Then
                txtTrID.Text = ""
                txtKetabID.Text = ""

                ShowUsDetails()
                ShowTrDetails()
            Else
                txtUsDetails.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        txtKetabID.Text = ""
        LabelKetab.Text = 0
    End Sub
End Class