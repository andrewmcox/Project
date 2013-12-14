Public Class AssignTableForm
    Dim tableID As Integer = 0

    Friend Sub LoadTable(ByVal TableID As Integer)
        'Hold for later use in queries and stores.
        Me.tableID = TableID
    End Sub

    Private Sub SelectTableForm_Closed(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles MyBase.Closed
        MainForm.Show()
    End Sub

    Private Sub AssignTableForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class