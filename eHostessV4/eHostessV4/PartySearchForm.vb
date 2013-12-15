Public Class PartySearchForm

    Private Sub chk_time_CheckedChanged(sender As Object, e As EventArgs) Handles chk_time.CheckedChanged
        If chk_time.Checked = True Then
            dtp_Start.Enabled = True
            dtp_End.Enabled = True
        ElseIf chk_time.Checked = False Then
            dtp_Start.Enabled = False
            dtp_End.Enabled = False
        End If
    End Sub



    Private Sub PartyBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PartyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EHostessDataSet)

    End Sub

    Private Sub PartySearchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EHostessDataSet.Party' table. You can move, or remove it, as needed.
        Me.PartyTableAdapter.Fill(Me.EHostessDataSet.Party)

    End Sub

    Private Sub btn_Search_Click(sender As Object, e As EventArgs) Handles btn_Search.Click
        Dim party_temp As String = ""
        Dim phone_temp As String = ""
        Dim start_temp As DateTime = "1901-01-01 01:00:00.300"
        Dim end_temp As DateTime = DateTime.Now

        If txt_Party.Text <> Nothing Then
            party_temp = txt_Party.Text
        End If

        If txt_Phone.Text <> Nothing Then
            phone_temp = txt_Phone.Text
        End If

        If chk_time.Checked = True Then
            start_temp = dtp_Start.Value
            end_temp = dtp_End.Value
        End If

        Me.PartyTableAdapter.FillBySearchParams(Me.EHostessDataSet.Party, party_temp, phone_temp, start_temp, end_temp)
    End Sub

    Private Sub SelectTableForm_Closed(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles MyBase.Closed
        MainForm.Show()
    End Sub

    Private Sub DoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoneToolStripMenuItem.Click
        MainForm.Show()
        Me.Close()
    End Sub
End Class