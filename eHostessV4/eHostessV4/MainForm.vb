Public Class MainForm
    Dim myButtons() As Button = {}

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EHostessDataSet.Seating' table. You can move, or remove it, as needed.
        Me.SeatingTableAdapter.Fill(Me.EHostessDataSet.Seating)
        'TODO: This line of code loads data into the 'EHostessDataSet.Party' table. You can move, or remove it, as needed.
        Me.PartyTableAdapter.Fill(Me.EHostessDataSet.Party)
        'TODO: This line of code loads data into the 'EHostessDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.EHostessDataSet.Staff)
        Me.AssignmentsTableAdapter.Fill(Me.EHostessDataSet.Assignments)

        myButtons = {Table1, Table2, Table3,
                                     Table4, Table5, Table6,
                                     Table7, Table8, Table9,
                                     Table10, Table11, Table12,
                                     Table13, Table14}
        Me.ColorTables()

    End Sub

    Private Sub MainForm_Activated(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles MyBase.Activated
        'TODO: This line of code loads data into the 'EHostessDataSet.Party' table. You can move, or remove it, as needed.
        Me.PartyTableAdapter.Fill(Me.EHostessDataSet.Party)
        'TODO: This line of code loads data into the 'EHostessDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.EHostessDataSet.Staff)
        Me.ColorTables()

    End Sub

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

    Private Sub Table1_Click(sender As Object, e As EventArgs) Handles Table1.Click
        Me.Hide()
        SelectedTableForm.Show()
    End Sub

    Private Sub Table2_Click(sender As Object, e As EventArgs) Handles Table2.Click
        Me.Hide()
        SelectedTableForm.Show()
    End Sub

    Private Sub Table3_Click(sender As Object, e As EventArgs) Handles Table3.Click
        Me.Hide()
        SelectedTableForm.Show()
    End Sub

    Private Sub Table4_Click(sender As Object, e As EventArgs) Handles Table4.Click
        Me.Hide()
        SelectedTableForm.Show()
    End Sub

    Private Sub Table5_Click(sender As Object, e As EventArgs) Handles Table5.Click
        Me.Hide()
        SelectedTableForm.Show()
    End Sub

    Private Sub Table6_Click(sender As Object, e As EventArgs) Handles Table6.Click
        Me.Hide()
        SelectedTableForm.Show()
    End Sub

    Private Sub Table7_Click(sender As Object, e As EventArgs) Handles Table7.Click
        Me.Hide()
        SelectedTableForm.Show()
    End Sub
    Private Sub Table8_Click(sender As Object, e As EventArgs) Handles Table8.Click
        Me.Hide()
        SelectedTableForm.Show()
    End Sub

    Private Sub Table9_Click(sender As Object, e As EventArgs) Handles Table9.Click
        Me.Hide()
        SelectedTableForm.Show()
    End Sub

    Private Sub Table10_Click(sender As Object, e As EventArgs) Handles Table10.Click
        Me.Hide()
        SelectedTableForm.Show()
    End Sub

    Private Sub Table11_Click(sender As Object, e As EventArgs) Handles Table11.Click
        Me.Hide()
        SelectedTableForm.Show()
    End Sub

    Private Sub Table12_Click(sender As Object, e As EventArgs) Handles Table12.Click
        Me.Hide()
        SelectedTableForm.Show()
    End Sub

    Private Sub Table13_Click(sender As Object, e As EventArgs) Handles Table13.Click
        Me.Hide()
        SelectedTableForm.Show()
    End Sub

    Private Sub Table14_Click(sender As Object, e As EventArgs) Handles Table14.Click
        Me.Hide()
        SelectedTableForm.Show()
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
