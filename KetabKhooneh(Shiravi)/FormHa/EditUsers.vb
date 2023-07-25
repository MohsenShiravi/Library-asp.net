Imports System.Globalization
Imports System.Data
Imports System.Data.SqlClient

Public Class EditUsers

    Dim pc As New PersianCalendar
    Dim StrCm As String = ""

    Private Function Format10Char(ByVal Date8 As String) As String
        Dim strDate8 As String = Date8
        Dim strDate10 As String = strDate8.Substring(0, 4) & "/" & strDate8.Substring(4, 2) & "/" & strDate8.Substring(6, 2)
        Return strDate10
    End Function
    Private Function Format8Char(ByVal Date10 As String) As String
        Dim strDate10 As String = Date10
        Dim strDate8 As String = strDate10.Substring(0, 4) & strDate10.Substring(5, 2) & strDate10.Substring(8, 2)
        Return strDate8
    End Function
    Private Sub ButtonSabt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSabt.Click
        Try
            If CheckBoxEdit.Checked = True Then
                StrCm = "Update tUsers Set UsName='" + txtName.Text + "',UsFamily='" + txtFamily.Text + "',UsFatherName='" + txtFatherName.Text + "',UsNumber='" + txtNumber.Text + "',UsBirthDate='" + txtBirthDate.Text + "',UsStartDate='" + Format8Char(txtStartDate.Text) + "',UsRevivalDate='" + Format8Char(txtRevivalDate.Text) + "' where UsID =" + txtUsID.Text
            Else
                Dim strRooz As String = pc.GetDayOfMonth(Now).ToString("00")
                Dim strMah As String = pc.GetMonth(Now).ToString("00")
                Dim strSal As String = pc.GetYear(Now).ToString()
                txtStartDate.Text = Format10Char(strSal & strMah & strRooz)
                txtRevivalDate.Text = Format10Char((Integer.Parse(strSal) + 1).ToString & strMah & strRooz)
                StrCm = "Insert tUsers values ('" + txtName.Text + "','" + txtFamily.Text + "','" + txtFatherName.Text + "','" + txtNumber.Text + "','" + txtBirthDate.Text + "','" + Format8Char(txtStartDate.Text) + "','" + Format8Char(txtRevivalDate.Text) + "')"
            End If
            Dim sqlcmd As New SqlCommand(StrCm, FormMain.con)
            If FormMain.con.State = ConnectionState.Closed Then
                FormMain.con.Open()
            End If
            sqlcmd.ExecuteNonQuery()
            FormMain.con.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtUsID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsID.TextChanged
        Try
            If CheckBoxEdit.Checked = True And txtUsID.Text <> "" Then
                StrCm = "select * from tUsers where UsID =" + txtUsID.Text
                If FormMain.con.State = ConnectionState.Closed Then
                    FormMain.con.Open()
                End If
                Dim Adapter As New SqlDataAdapter(StrCm, FormMain.con)
                Dim dst As New DataSet()
                Adapter.Fill(dst, "tUs")
                If dst.Tables("tUs").Rows.Count <> 0 Then
                    txtUsID.Text = dst.Tables("tUs").Rows(0).Item("UsID").ToString
                    txtName.Text = dst.Tables("tUs").Rows(0).Item("UsName").ToString
                    txtFamily.Text = dst.Tables("tUs").Rows(0).Item("UsFamily").ToString
                    txtFatherName.Text = dst.Tables("tUs").Rows(0).Item("UsFatherName").ToString()
                    txtNumber.Text = dst.Tables("tUs").Rows(0).Item("UsNumber").ToString()
                    txtBirthDate.Text = dst.Tables("tUs").Rows(0).Item("UsBirthDate").ToString()
                    txtStartDate.Text = Format10Char(dst.Tables("tUs").Rows(0).Item("UsStartDate").ToString())
                    txtRevivalDate.Text = Format10Char(dst.Tables("tUs").Rows(0).Item("UsRevivalDate").ToString)
                End If
                FormMain.con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub CheckBoxEdit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxEdit.CheckedChanged
        Try
            If CheckBoxEdit.Checked = True And txtUsID.Text <> "" Then
                StrCm = "select * from tUsers where UsID =" + txtUsID.Text
                If FormMain.con.State = ConnectionState.Closed Then
                    FormMain.con.Open()
                End If
                Dim Adapter As New SqlDataAdapter(StrCm, FormMain.con)
                Dim dst As New DataSet()
                Adapter.Fill(dst, "tUs")
                If dst.Tables("tUs").Rows.Count <> 0 Then
                    txtName.Text = dst.Tables("tUs").Rows(0).Item("UsName").ToString
                    txtFamily.Text = dst.Tables("tUs").Rows(0).Item("UsFamily").ToString
                    txtFatherName.Text = dst.Tables("tUs").Rows(0).Item("UsFatherName").ToString()
                    txtNumber.Text = dst.Tables("tUs").Rows(0).Item("UsNumber").ToString()
                    txtBirthDate.Text = dst.Tables("tUs").Rows(0).Item("UsBirthDate").ToString()
                    txtStartDate.Text = Format10Char(dst.Tables("tUs").Rows(0).Item("UsStartDate").ToString())
                    txtRevivalDate.Text = Format10Char(dst.Tables("tUs").Rows(0).Item("UsRevivalDate").ToString)
                    FormMain.con.Close()
                End If
            Else
                txtUsID.Text = ""
                txtName.Text = ""
                txtFamily.Text = ""
                txtFatherName.Text = ""
                txtNumber.Text = ""
                txtBirthDate.Text = ""
                txtStartDate.Text = ""
                txtRevivalDate.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ButtonUpateRevivalDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUpateRevivalDate.Click
        Try
            If CheckBoxEdit.Checked = True And txtUsID.Text <> "" Then
                Dim strRooz As String = pc.GetDayOfMonth(Now).ToString("00")
                Dim strMah As String = pc.GetMonth(Now).ToString("00")
                Dim strSal As String = (pc.GetYear(Now) + 1).ToString()
                txtRevivalDate.Text = Format10Char(strSal & strMah & strRooz)
                StrCm = "Update tUsers Set UsRevivalDate='" + (strSal & strMah & strRooz).ToString + "' where UsID =" + txtUsID.Text
                Dim sqlcmd As New SqlCommand(StrCm, FormMain.con)
                If FormMain.con.State = ConnectionState.Closed Then
                    FormMain.con.Open()
                End If
                sqlcmd.ExecuteNonQuery()
                FormMain.con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub EditUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub
End Class