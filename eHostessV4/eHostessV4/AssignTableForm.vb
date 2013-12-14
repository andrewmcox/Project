Public Class AssignTableForm
    Dim tableID As Integer = 0

    Friend Sub LoadTable(ByVal TableID As Integer)
        'Hold for later use in queries and stores.
        Me.tableID = TableID

        Me.SeatingTableAdapter.ClearBeforeFill = True
        Me.SeatingTableAdapter.FillByTableID(Me.EHostessDataSet.Seating, Me.tableID)

        Me.Seating_DetailTableAdapter.ClearBeforeFill = True
        Me.Seating_DetailTableAdapter.FillByTableID(Me.EHostessDataSet.Seating_Detail, Me.tableID)
    End Sub

    Private Sub SelectTableForm_Closed(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles MyBase.Closed
        MainForm.Show()
    End Sub

    Private Sub AssignTableForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EHostessDataSet.Seating_Detail' table. You can move, or remove it, as needed.
        ' Me.Seating_DetailTableAdapter.Fill(Me.EHostessDataSet.Seating_Detail)
        'TODO: This line of code loads data into the 'EHostessDataSet.Seating' table. You can move, or remove it, as needed.

    End Sub

    Private Sub AssignForm_Activated(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.LoadTable(Me.tableID)
    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class