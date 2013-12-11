Public Class StaffForm

    Private Sub StaffBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StaffBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EHostessDataSet)

    End Sub

    Private Sub StaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EHostessDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.EHostessDataSet.Staff)
    End Sub

    Private Sub StaffForm_Closed(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles MyBase.Closed
        MainForm.Show()
    End Sub

    Private Sub DoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoneToolStripMenuItem.Click
        Me.Close()
        MainForm.Show()
    End Sub
End Class