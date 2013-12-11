Public Class SelectedTableForm

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
End Class