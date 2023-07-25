Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data

Public Class Users

    Private Sub Users_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim ada As New SqlDataAdapter("select * from tUsers", FormMain.con)
            Dim dst As New DataSet
            If FormMain.con.State = ConnectionState.Closed Then
                FormMain.con.Open()
            End If
            ada.Fill(dst, "Users")
            DataGridView1.DataSource = dst.Tables("Users")
            FormMain.con.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub txtUsID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsID.TextChanged
        Try
            Dim strCmd As String = "select * from tUsers " + "where UsID like '%" + txtUsID.Text + "%' "
            Dim ada As New SqlDataAdapter(strCmd, FormMain.con)
            Dim dst As New DataSet
            If FormMain.con.State = ConnectionState.Closed Then
                FormMain.con.Open()
            End If
            ada.Fill(dst, "Users")
            DataGridView1.DataSource = dst.Tables("Users")
            FormMain.con.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            Dim strCmd As String = "select * from tUsers " + "where (UsName + ' ' + UsFamily) like '%" + txtSearch.Text + "%' or UsFatherName like '%" + txtSearch.Text + "%' or UsNumber like '%" + txtSearch.Text + "%' or UsBirthDate like '%" + txtSearch.Text + "%' or UsStartDate like '%" + txtSearch.Text + "%' or UsRevivalDate like '%" + txtSearch.Text + "%' "
            Dim ada As New SqlDataAdapter(strCmd, FormMain.con)
            Dim dst As New DataSet
            If FormMain.con.State = ConnectionState.Closed Then
                FormMain.con.Open()
            End If
            ada.Fill(dst, "Users")
            DataGridView1.DataSource = dst.Tables("Users")
            FormMain.con.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Dim EditUsers As New EditUsers
        EditUsers.txtUsID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        EditUsers.CheckBoxEdit.Checked = True
        EditUsers.ShowDialog()
    End Sub

    Private Sub DataGridView1_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick
    End Sub
End Class