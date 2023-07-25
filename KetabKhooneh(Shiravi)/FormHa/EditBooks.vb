Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class EditBooks
    Private Sub sbBindComboBoxGroup()
        Try
            Dim ada As New SqlDataAdapter("select * from tGroups", FormMain.con)
            Dim dst As New DataSet
            ada.Fill(dst, "tGroups")
            ComboBoxGroupID.DataSource = dst.Tables("tGroups")
            ComboBoxGroupID.DisplayMember = "GroupName"
            ComboBoxGroupID.ValueMember = "GroupID"
            ComboBoxGroupID.SelectedValue = dst.Tables("tGroups").Columns("GroupID").DefaultValue
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub txtketabMojood_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKetabNumChap.ValueChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxGroupID.SelectedIndexChanged

    End Sub

    Private Sub ButtonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub

    Private Sub txtKetabID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKetabID.TextChanged
        sbLoadKetab()
        sbBindComboBoxGroup()
    End Sub

    Private Sub sbLoadKetab()
        Try
            Dim ada As New SqlDataAdapter("select * from tKetab inner join tGroups on tGroups.GroupID=tKetab.GroupID where KetabID=" + txtKetabID.Text, FormMain.con)
            Dim dst As New DataSet
            ada.Fill(dst, "Ketab")
            If dst.Tables("Ketab").Rows.Count <> 0 Then
                txtKetabOnvan.Text = dst.Tables("Ketab").Rows(0).Item("KetabOnvan").ToString
                txtKetabFee.Text = dst.Tables("Ketab").Rows(0).Item("KetabFee").ToString
                txtKetabDate.Text = dst.Tables("Ketab").Rows(0).Item("KetabDate").ToString
                ComboBoxGroupID.Text = dst.Tables("Ketab").Rows(0).Item("GroupName").ToString
                txtKetabNumChap.Text = dst.Tables("Ketab").Rows(0).Item("KetabNumChap").ToString
                If dst.Tables("Ketab").Rows(0).Item("ketabMojood").ToString = "True" Then
                    CheckBoxketabMojood.Checked = True
                Else
                    CheckBoxketabMojood.Checked = False
                End If
                txtKetabNevisande.Text = dst.Tables("Ketab").Rows(0).Item("KetabNevisande").ToString
                txtKetabNasher.Text = dst.Tables("Ketab").Rows(0).Item("KetabNasher").ToString
            Else
                txtKetabOnvan.Text = ""
                txtKetabFee.Text = ""
                txtKetabDate.Text = ""
                ComboBoxGroupID.Text = ""
                txtKetabNumChap.Text = ""
                CheckBoxketabMojood.Checked = True

                txtKetabNevisande.Text = ""
                txtKetabNasher.Text = ""
            End If
        Catch ex As Exception
            'MsgBox(ex.Message.ToString(), MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ButtonSabt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSabt.Click
        Try
            Dim StrCm As String = ""
            If CheckBoxEdit.Checked = True Then
                'update
                StrCm = "Update tKetab set KetabOnvan='" & txtKetabOnvan.Text & "',KetabFee=" & txtKetabFee.Text & ",KetabDate='" & txtKetabDate.Text & "',ketabMojood='" & CheckBoxketabMojood.Checked & "',KetabNumChap=" & txtKetabNumChap.Value & ",GroupID=" & ComboBoxGroupID.SelectedValue & ",KetabNevisande='" & txtKetabNevisande.Text & "',KetabNasher='" & txtKetabNasher.Text & "' where KetabID=" & txtKetabID.Text
            Else
                'insert
                StrCm = "Insert tKetab values ('" & txtKetabOnvan.Text & "','" & txtKetabFee.Text & "','" & txtKetabDate.Text & "',1," & txtKetabNumChap.Value & "," & ComboBoxGroupID.SelectedValue & ",'" & txtKetabNevisande.Text & "','" & txtKetabNasher.Text & "')"
            End If
            sbEditKetab(StrCm)
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub sbEditKetab(ByVal StrCommand As String)
        Try
            Dim sqlcmd As New SqlCommand(StrCommand, FormMain.con)
            If FormMain.con.State = ConnectionState.Closed Then
                FormMain.con.Open()
            End If
            sqlcmd.ExecuteNonQuery()
            FormMain.con.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub EditBooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sbBindComboBoxGroup()
        sbLoadKetab()
    End Sub

    Private Sub CheckBoxEdit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxEdit.CheckedChanged
        If CheckBoxEdit.Checked = False Or txtKetabID.Text = "" Then
            txtKetabID.Text = ""
            txtKetabOnvan.Text = ""
            txtKetabFee.Text = ""
            txtKetabDate.Text = ""
            ComboBoxGroupID.Text = ""
            txtKetabNumChap.Text = ""
            CheckBoxketabMojood.Checked = True

            txtKetabNevisande.Text = ""
            txtKetabNasher.Text = ""
        End If
    End Sub
End Class