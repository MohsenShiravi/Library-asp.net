Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class SearchBook
    Private SearchBarHasbID As Boolean = False
    Private CMDString As String
    Private cmd As New SqlCommand(CMDString, FormMain.con)
    Private dtr As SqlDataReader
    'Private ConnectionString As String=

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxID.TextChanged
        If TextBoxID.Text <> "" And IsNumeric(TextBoxID.Text) Then
            IDsearch()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBarHasb.Click
        If PanelID.Visible = False Then
            btnBarHasb.Text = "جستجو بر حسب اطلاعات کتاب"
            SearchBarHasbID = True
            PanelKetabDetails.Enabled = False
            PanelID.Visible = True
            PanelID.Enabled = True
            TextBoxID.Text = ""
            TextBoxNasher.Text = ""
            TextBoxNevisande.Text = ""
            TextBoxOnvan.Text = ""
        ElseIf PanelID.Visible = True Then
            btnBarHasb.Text = "جستجو بر حسب شناسه کتاب"
            SearchBarHasbID = False
            PanelKetabDetails.Enabled = True
            PanelID.Visible = False
            PanelID.Enabled = False
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        If SearchBarHasbID = True Then
            IdSearch()
        ElseIf SearchBarHasbID = False Then
            DetailsSearch()
        End If
    End Sub

    Private Sub IDsearch()
        Try
            If TextBoxID.Text <> "" Then
                CMDString = "Select * from tKetab where KetabID=" & TextBoxID.Text
                Dim ada As New SqlDataAdapter(CMDString, FormMain.con)
                Dim dst As New DataSet
                ada.Fill(dst, "tblBook")
                GrdSearchBook.DataSource = dst.Tables("tblBook")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Private Sub DetailsSearch()
        Try
            CMDString = "select *,tGroups.GroupName from tketab inner join tGroups on tGroups.GroupID=tKetab.GroupID where ketabMojood='" & CheckBoxJadidBoodan.Checked & "'"
            If TextBoxOnvan.Text <> "" Then
                CMDString += " and KetabOnvan like '%" & TextBoxOnvan.Text & "%'"
            End If
            If TextBoxNevisande.Text <> "" Then
                CMDString += " and KetabNevisande like '%" & TextBoxNevisande.Text & "%'"
            End If
            If TextBoxNasher.Text <> "" Then
                CMDString += " and KetabNasher like '%" & TextBoxNasher.Text & "%'"
            End If

            Dim ada As New SqlDataAdapter(CMDString, FormMain.con)
            Dim dst As New DataSet
            ada.Fill(dst, "tblBook")
            GrdSearchBook.DataSource = dst.Tables("tblBook")
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub TextBoxOnvan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxOnvan.TextChanged
        DetailsSearch()
    End Sub

    Private Sub TextBoxNasher_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxNasher.TextChanged
        DetailsSearch()
    End Sub

    Private Sub TextBoxNevisande_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxNevisande.TextChanged
        DetailsSearch()
    End Sub

    Private Sub CheckBoxJadidBoodan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxJadidBoodan.CheckedChanged
        DetailsSearch()
    End Sub

    Private Sub SearchBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GrdSearchBook_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdSearchBook.CellValueChanged

    End Sub

    Private Sub GrdSearchBook_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdSearchBook.CellMouseDoubleClick
        Dim EditBooks As New EditBooks
        EditBooks.txtKetabID.Text = GrdSearchBook.Rows(e.RowIndex).Cells(0).Value
        EditBooks.CheckBoxEdit.Checked = True
        EditBooks.ShowDialog()
        DetailsSearch()
    End Sub
End Class