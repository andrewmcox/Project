Public Class TablesForm

    Private Sub SeatingBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SeatingBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SeatingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EHostessDataSet)

    End Sub

    Private Sub TableForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EHostessDataSet.Seating' table. You can move, or remove it, as needed.
        Me.SeatingTableAdapter.Fill(Me.EHostessDataSet.Seating)
    End Sub

    Private Sub TableForm_Closed(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles MyBase.Closed
        MainForm.Show()
    End Sub

    Private Sub DoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoneToolStripMenuItem.Click
        Me.Close()
        MainForm.Show()
    End Sub
End Class