Public Class AssignTableForm
    Dim tableID As Integer = 0
    Dim previousForm = SelectedTableForm

    Friend Sub LoadTable(ByVal TableID As Integer, ByRef selectedTableForm As SelectedTableForm)
        'Hold for later use in queries and stores.
        Me.tableID = TableID
        previousForm = selectedTableForm

        Me.SeatingTableAdapter.ClearBeforeFill = True
        Me.SeatingTableAdapter.FillByTableID(Me.EHostessDataSet.Seating, Me.tableID)

        Me.Seating_DetailTableAdapter.ClearBeforeFill = True
        Me.Seating_DetailTableAdapter.FillByTableID(Me.EHostessDataSet.Seating_Detail, Me.tableID)

        Me.ActiveStaffNamesTableAdapter.ClearBeforeFill = True
        Me.ActiveStaffNamesTableAdapter.FillByMaxTable(Me.EHostessDataSet.ActiveStaffNames, Me.SeatingTableAdapter.FillByMaxTableSizeByTableID(Me.tableID))

        Me.PartyTableAdapter.ClearBeforeFill = True
        Me.PartyTableAdapter.FillByWaitingParties(Me.EHostessDataSet.Party)
    End Sub

    Private Sub SelectTableForm_Closed(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles MyBase.Closed
        previousForm.Show()
    End Sub

    Private Sub AssignTableForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AssignForm_Activated(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.LoadTable(Me.tableID, Me.previousForm)
    End Sub

    Private Sub lb_party_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_party.SelectedIndexChanged
        If lb_party.SelectedValue <> Nothing Then
            Me.Party_DetailTableAdapter.FillByByPartyID(Me.EHostessDataSet.Party_Detail, lb_party.SelectedValue)
        End If
    End Sub

    Private Sub btn_Assign_Click(sender As Object, e As EventArgs) Handles btn_Assign.Click
        Me.AssignmentsTableAdapter.InsertAssignmentUpdateParty(Me.tableID, lb_party.SelectedValue, lb_staff.SelectedValue, DateTime.Now)
        previousForm.show()
        Me.Close()
    End Sub

    Private Sub DoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoneToolStripMenuItem.Click
        previousForm.Show()
        Me.Close()
    End Sub
End Class