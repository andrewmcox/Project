Public Class SelectedTableForm
    Dim tableID As Integer = 0
    Dim assigned As Boolean = False
    Dim seatedTime As DateTime = DateTime.Now

    Private Sub DoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoneToolStripMenuItem.Click
        Me.Close()
        MainForm.Show()
    End Sub

    Private Sub SelectedTableForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AssignedTimeLabel.Text = ""
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
            Me.Timer1.Stop()
            Me.CompleteAssignmentButton.Enabled = False
            Me.AssignTableButton.Enabled = True
            Me.AssignedTimeLabel.Visible = False
        Else
            Me.seatedTime = Me.AssignmentsTableAdapter.getSeatedTimeFromTable(Me.tableID)
            Me.calculateTimeInterval()
            Me.Timer1.Start()
            Me.CompleteAssignmentButton.Enabled = True
            Me.AssignTableButton.Enabled = False
        End If


    End Sub

    Private Sub AssignTableButton_Click(sender As Object, e As EventArgs) Handles AssignTableButton.Click
        'Launch the form to show the available parties matched by smoking and 
        'size with staff members that can handle that party/table.
        'Make sure to update the Party Seated Time and Status
        'Update Assignments Table

        If Me.PartyTableAdapter.CountOfWaitingPartiesForTableSizeAndPref(Me.tableID) > 0 Then
            AssignTableForm.LoadTable(Me.tableID, Me)
            AssignTableForm.Show()
        Else
            MsgBox("There are no parties currently waiting that meet this tables requirements.. Try a different table if there are parties actually waiting.", , "Warning")

        End If

        
    End Sub

    Private Sub CompleteAssignmentButton_Click(sender As Object, e As EventArgs) Handles CompleteAssignmentButton.Click
        'Execute complete of assignment - should update the Party Table (Completed Status?) Waiting, Seated, Paid, Completed?
        'Assignments Table - remove row?

        Me.AssignmentsTableAdapter.CompleteAssignmentByTableID(Me.tableID)

        'refresh table after we make the updates
        Me.LoadTable(Me.tableID)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.calculateTimeInterval()
    End Sub

    Private Sub calculateTimeInterval()
        Dim elapsed As TimeSpan = (DateTime.Now - Me.seatedTime)
        If elapsed.TotalDays * 60 * 24 > 120 Then
            Me.AssignedTimeLabel.ForeColor = Color.Red
        ElseIf elapsed.TotalDays * 60 * 24 > 60 Then
            Me.AssignedTimeLabel.ForeColor = Color.Yellow
        Else
            Me.AssignedTimeLabel.ForeColor = Color.Green
        End If
        Me.AssignedTimeLabel.Text = "Seated Time: " + CType(Int(elapsed.TotalDays * 60 * 24), String) + " minutes elapsed"
        Me.AssignedTimeLabel.Visible = True
    End Sub
End Class