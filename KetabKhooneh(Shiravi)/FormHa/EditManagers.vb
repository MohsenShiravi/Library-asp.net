Imports System.Data
Imports System.Data.SqlClient

Public Class EditManagers

    Dim StrCm As String = ""

    Private Sub ButtonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub

    Private Sub CheckBoxModirNoAccess_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxModirNoAccess.CheckedChanged
        If CheckBoxModirNoAccess.Checked = True Then
            LabelModirNoAccess.Text = "0"
        Else
            LabelModirNoAccess.Text = "1"
        End If
    End Sub

    Private Sub CheckBoxEdit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxEdit.CheckedChanged
        Try
            If CheckBoxEdit.Checked = True And txtModirID.Text <> "" Then
                StrCm = "select * from tModir where ModirID =" + txtModirID.Text
                If FormMain.con.State = ConnectionState.Closed Then
                    FormMain.con.Open()
                End If
                Dim Adapter As New SqlDataAdapter(StrCm, FormMain.con)
                Dim dst As New DataSet()
                Adapter.Fill(dst, "Modir")
                If dst.Tables("Modir").Rows.Count <> 0 Then
                    txtModirUserName.Text = dst.Tables("Modir").Rows(0).Item("ModirUserName").ToString
                    txtModirPass.Text = dst.Tables("Modir").Rows(0).Item("ModirPass").ToString
                    txtModirPass2.Text = txtModirPass.Text
                End If
                FormMain.con.Close()
            Else
                txtModirID.Text = ""
                txtModirUserName.Text = ""
                txtModirPass.Text = ""
                txtModirPass2.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ButtonSabt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSabt.Click
        Try
            If CheckBoxEdit.Checked = True Then
                If txtModirPass.Text = txtModirPass2.Text Then
                    StrCm = "Update tModir Set ModirUserName='" + txtModirUserName.Text + "',ModirPass='" + txtModirPass.Text + "',ModirNoAccess=" + LabelModirNoAccess.Text + " where ModirID =" + txtModirID.Text
                Else
                    MsgBox("گذرواژه ها یک نیستند !", MsgBoxStyle.OkOnly)
                End If
            Else
                If txtModirPass.Text = txtModirPass2.Text Then
                    StrCm = "Insert tModir values ('" + txtModirUserName.Text + "','" + txtModirPass.Text + "'," + LabelModirNoAccess.Text + ")"
                Else
                    MsgBox("گذرواژه ها یک نیستند !", MsgBoxStyle.OkOnly)
                End If
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

    Private Sub txtModirID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtModirID.TextChanged
        Try
            If CheckBoxEdit.Checked = True And txtModirID.Text <> "" Then
                StrCm = "select * from tModir where ModirID=" + txtModirID.Text
                If FormMain.con.State = ConnectionState.Closed Then
                    FormMain.con.Open()
                End If
                Dim Adapter As New SqlDataAdapter(StrCm, FormMain.con)
                Dim dst As New DataSet()
                Adapter.Fill(dst, "Modir")
                If dst.Tables("Modir").Rows.Count <> 0 Then
                    txtModirID.Text = dst.Tables("Modir").Rows(0).Item("ModirID").ToString
                    txtModirUserName.Text = dst.Tables("Modir").Rows(0).Item("ModirUserName").ToString
                    txtModirPass.Text = dst.Tables("Modir").Rows(0).Item("ModirPass").ToString
                    txtModirPass2.Text = txtModirPass.Text
                    LabelModirNoAccess.Text = dst.Tables("Modir").Rows(0).Item("ModirNoAccess").ToString
                    If LabelModirNoAccess.Text = "True" Then
                        LabelModirNoAccess.Text = "1"
                    Else
                        LabelModirNoAccess.Text = "0"
                    End If
                End If
                FormMain.con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub EditManagers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class