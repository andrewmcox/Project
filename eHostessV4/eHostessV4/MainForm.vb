Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EHostessDataSet.Party' table. You can move, or remove it, as needed.
        Me.PartyTableAdapter.Fill(Me.EHostessDataSet.Party)
        'TODO: This line of code loads data into the 'EHostessDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.EHostessDataSet.Staff)

    End Sub

    Private Sub MainForm_Activated(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles MyBase.Activated
        'TODO: This line of code loads data into the 'EHostessDataSet.Party' table. You can move, or remove it, as needed.
        Me.PartyTableAdapter.Fill(Me.EHostessDataSet.Party)
        'TODO: This line of code loads data into the 'EHostessDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.EHostessDataSet.Staff)
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
End Class
