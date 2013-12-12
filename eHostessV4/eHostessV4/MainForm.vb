Public Class MainForm
    Dim myButtons() As Button = {}

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setup the buttons
        myButtons = {Table1, Table2, Table3,
                                     Table4, Table5, Table6,
                                     Table7, Table8, Table9,
                                     Table10, Table11, Table12,
                                     Table13, Table14}
        Me.ColorTables()
        Me.AddClickHandlers()
    End Sub

    Private Sub MainForm_Activated(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles MyBase.Activated
        'TODO: This line of code loads data into the 'EHostessDataSet.Party' table. You can move, or remove it, as needed.
        Me.PartyTableAdapter.Fill(Me.EHostessDataSet.Party)
        'TODO: This line of code loads data into the 'EHostessDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.EHostessDataSet.Staff)
        Me.SeatingTableAdapter.Fill(Me.EHostessDataSet.Seating)
        Me.AssignmentsTableAdapter.Fill(Me.EHostessDataSet.Assignments)
        Me.ColorTables()
    End Sub


    'Navigation MenuStrip Stuff
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub StaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffToolStripMenuItem.Click
        Me.Hide()
        StaffForm.Show()
    End Sub

    Private Sub PartyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PartyToolStripMenuItem.Click
        Me.Hide()
        PartyForm.Show()
    End Sub

    Private Sub TableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TableToolStripMenuItem.Click
        Me.Hide()
        TableForm.Show()
    End Sub


    'Button Stuff
    Private Sub TableSelectedClick(sender As Object, e As EventArgs)
        Dim clickedBtn As Button = sender
        Dim selectedTable As New SelectedTableForm
        selectedTable.LoadTable(CType(clickedBtn.Tag, Integer))
        selectedTable.Show()
        Me.Hide()
    End Sub

    Private Sub AddClickHandlers()
        For Each btn As Button In Me.myButtons
            AddHandler btn.Click, AddressOf TableSelectedClick
        Next
    End Sub

    Private Sub ColorTables()
        'Add Coloring for each button
        For Each btn As Button In Me.myButtons
            If CBool(Me.AssignmentsTableAdapter.IsTableAvailableProcedure(CType(btn.Tag, Integer)) = 0) Then
                'Determine if we need to enable or disable the button
                If CBool(Me.SeatingTableAdapter.IsTableDefinedProcedure(CType(btn.Tag, Integer)) = 1) Then
                    btn.BackColor = Color.Green
                    btn.Enabled = True
                Else
                    'Table doesn't exist.
                    btn.BackColor = Color.LightGray
                    btn.Enabled = False
                End If
            Else
                'Table already in use.
                btn.BackColor = Color.Red
                btn.Enabled = True
            End If
        Next
    End Sub
End Class
