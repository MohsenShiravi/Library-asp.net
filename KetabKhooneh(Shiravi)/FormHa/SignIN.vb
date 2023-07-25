Imports System.Data.SqlClient

Public Class SignIN

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBUserName.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> "" Then
            Button1.Enabled = True
        ElseIf TextBox1.Text = "" Then
            Button1.Enabled = False
        End If
    End Sub

    Private Sub SignIN_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub SignIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BindCBUserName()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FormMain.lblWelcome1.Text = "کاربر"
        Dim cmd As New SqlCommand("sp_checkModir", FormMain.con)
        Dim param As New SqlParameter
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("ModirID", CBUserName.SelectedValue)
        cmd.Parameters.AddWithValue("ModirPass", TextBox1.Text)
        param = cmd.Parameters.Add("ReturnValue", SqlDbType.TinyInt)
        param.Direction = ParameterDirection.ReturnValue
        FormMain.con.Open()
        cmd.ExecuteNonQuery()
        FormMain.con.Close()
        If param.Value > 0 Then
            FormMain.lblWelcome1.Text = FormMain.lblWelcome1.Text + " " & CBUserName.Text
            Me.Close()
        ElseIf param.Value = 0 Then
            MsgBox("! پسورد اشتباه است", MsgBoxStyle.Critical)
        ElseIf param.Value = -1 Then
            Dim javab As String = MsgBox("شما غیر فعال شده اید  !  آیا دوباره تکرار می کنید ؟", MsgBoxStyle.RetryCancel)
            If javab = MsgBoxResult.Retry Then
                Me.CBUserName.SelectedIndex = 0
                Me.TextBox1.Text = ""
            ElseIf javab = MsgBoxResult.Cancel Then
                FormMain.lblWelcome1.Text = "کاربر"
                Me.Close()
            End If
        End If
    End Sub
    Private Sub BindCBUserName()
        Dim ada As New SqlDataAdapter("select * from tModir", FormMain.con)
        Dim dst As New DataSet
        ada.Fill(dst, "Modir")
        CBUserName.DataSource = dst.Tables("Modir")
        CBUserName.DisplayMember = "ModirUserName"
        CBUserName.ValueMember = "ModirID"
        CBUserName.SelectedValue = dst.Tables("Modir").Columns("ModirID").DefaultValue
    End Sub
End Class