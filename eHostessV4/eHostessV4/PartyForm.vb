Public Class PartyForm

    Private Sub PartyBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PartyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EHostessDataSet)

    End Sub


    Private Sub PartyBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles PartyBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PartyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EHostessDataSet)

    End Sub

    Private Sub PartyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EHostessDataSet.Party' table. You can move, or remove it, as needed.
        Me.PartyTableAdapter.Fill(Me.EHostessDataSet.Party)

    End Sub

    Private Sub PartyForm_Closed(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles MyBase.Closed
        MainForm.Show()
    End Sub

    Private Sub DoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoneToolStripMenuItem.Click
        Me.Close()
        MainForm.Show()
    End Sub
End Class