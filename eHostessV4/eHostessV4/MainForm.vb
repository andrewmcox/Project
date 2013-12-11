Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EHostessDataSet.Party' table. You can move, or remove it, as needed.
        Me.PartyTableAdapter.Fill(Me.EHostessDataSet.Party)
        'TODO: This line of code loads data into the 'EHostessDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.EHostessDataSet.Staff)

    End Sub
End Class
