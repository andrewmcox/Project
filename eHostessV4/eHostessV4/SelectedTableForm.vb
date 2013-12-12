Public Class SelectedTableForm
    Dim tableID As Integer = 0
    Private Sub DoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoneToolStripMenuItem.Click
        Me.Close()
        MainForm.Show()
    End Sub

    Private Sub SelectedTableForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SelectTableForm_Closed(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles MyBase.Closed
        MainForm.Show()
    End Sub

    Friend Sub LoadTable(ByVal TableID As Integer)
        'Hold for later use in queries and stores.
        Me.tableID = TableID

        Me.SeatingTableAdapter.ClearBeforeFill = True
        Me.SeatingTableAdapter.FillByTableID(Me.EHostessDataSet.Seating, Me.tableID)

        Me.Seating_DetailTableAdapter.ClearBeforeFill = True
        Me.Seating_DetailTableAdapter.FillByTableID(Me.EHostessDataSet.Seating_Detail, Me.tableID)

        Me.StaffTableAdapter.ClearBeforeFill = True
        Me.StaffTableAdapter.FillByStaffByTableID(Me.EHostessDataSet.Staff, Me.tableID)

        Me.PartyTableAdapter.ClearBeforeFill = True
        Me.PartyTableAdapter.FillByPartyByTableID(Me.EHostessDataSet.Party, Me.tableID)


    End Sub

    Private Sub SeatingBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SeatingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EHostessDataSet)

    End Sub
End Class