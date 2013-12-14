Public Class SelectedTableForm
    Dim tableID As Integer = 0
    Dim assigned As Boolean = False
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

    Private Sub SelectTableForm_Activated(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.LoadTable(Me.tableID)
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

        Me.Party_DetailTableAdapter.ClearBeforeFill = True
        Me.Party_DetailTableAdapter.FillByTableID(Me.EHostessDataSet.Party_Detail, Me.tableID)

        If CBool(Me.AssignmentsTableAdapter.IsTableAvailableProcedure(Me.tableID) = 0) Then
            Me.CompleteAssignmentButton.Enabled = False
            Me.AssignTableButton.Enabled = True
        Else
            Me.CompleteAssignmentButton.Enabled = True
            Me.AssignTableButton.Enabled = False
        End If
    End Sub

    Private Sub SeatingBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SeatingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EHostessDataSet)

    End Sub

    Private Sub AssignTableButton_Click(sender As Object, e As EventArgs) Handles AssignTableButton.Click
        'Launch the form to show the available parties matched by smoking and 
        'size with staff members that can handle that party/table.
        'Make sure to update the Party Seated Time and Status
        'Update Assignments Table
        AssignTableForm.LoadTable(Me.tableID)
        AssignTableForm.Show()
    End Sub

    Private Sub CompleteAssignmentButton_Click(sender As Object, e As EventArgs) Handles CompleteAssignmentButton.Click
        'Execute complete of assignment - should update the Party Table (Completed Status?) Waiting, Seated, Paid, Completed?
        'Assignments Table - remove row?

        'refresh table after we make the updates
        Me.LoadTable(Me.tableID)
    End Sub

    Private Sub Seating_DetailListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Seating_DetailListBox.SelectedIndexChanged

    End Sub
End Class