Imports System.Data
Imports System.Data.SqlClient

Public Class TrustDetails

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If RadioButtonTrID.Checked = True Then
            PanelFactorID.Enabled = True

            PanelDate.Enabled = False
            PanelMoshtari.Enabled = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If RadioButtonDate.Checked = True Then
            PanelDate.Enabled = True

            PanelFactorID.Enabled = False
            PanelMoshtari.Enabled = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If RadioButtonUsID.Checked = True Then
            PanelMoshtari.Enabled = True

            PanelDate.Enabled = False
            PanelFactorID.Enabled = False
        End If
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GozareshForoosh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub sbSelect()
        Try
            Dim dst As New DataSet
            Dim strCmd As String = "Select * from tTrust inner join tKetab on tTrust.KetabID=tKetab.KetabID inner join tUsers on tTrust.UsID=tUsers.UsID where "
            If RadioButtonTrID.Checked = True Then
                strCmd += "tTrust.TrID between " + txtFromTrID.Text + " And " + txtToTrID.Text
            ElseIf RadioButtonDate.Checked = True Then
                strCmd += "tTrust.TrDate between 13" + ComboBox3.Text.ToString & ComboBox2.Text.ToString & ComboBox1.Text.ToString + "0000 and 13" + ComboBox6.Text.ToString & ComboBox5.Text.ToString & ComboBox4.Text.ToString + "0000"
            ElseIf RadioButtonUsID.Checked = True Then
                strCmd += "tTrust.UsID = " + txtUsID.Text
            End If

            Dim ada As New SqlDataAdapter(strCmd, FormMain.con)
            Dim dst1 As New DataSet
            If FormMain.con.State = ConnectionState.Closed Then
                FormMain.con.Open()
            End If
            ada.Fill(dst1, "Gozaresh")
            grdGozaresh.DataSource = dst1.Tables("Gozaresh")
            FormMain.con.Close()
        Catch ex As Exception
            'MsgBox(ex.Message.ToString, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        sbSelect()
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonTrID.CheckedChanged
        sbSelect()
    End Sub

    Private Sub txtUsID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsID.TextChanged
        sbSelect()
    End Sub

    Private Sub RadioButtonDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonDate.CheckedChanged
        sbSelect()
    End Sub

    Private Sub RadioButtonUsID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonUsID.CheckedChanged
        sbSelect()
    End Sub

    Private Sub txtFromTrID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFromTrID.TextChanged
        sbSelect()
    End Sub

    Private Sub txtToTrID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtToTrID.TextChanged
        sbSelect()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        sbSelect()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        sbSelect()
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        sbSelect()
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        sbSelect()
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox6.SelectedIndexChanged
        sbSelect()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub grdGozaresh_CellValueNeeded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellValueEventArgs) Handles grdGozaresh.CellValueNeeded
        Dim a As String = e.Value
    End Sub

    Private Sub grdGozaresh_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdGozaresh.CellDoubleClick
        If e.ColumnIndex = 0 Then
            Dim Trust As New Trust
            Trust.txtTrID.Text = grdGozaresh.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            Trust.txtTrID.Text = grdGozaresh.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString
            Trust.ShowDialog()
            sbSelect()
        End If
    End Sub
End Class