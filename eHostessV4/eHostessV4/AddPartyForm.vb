Public Class AddPartyForm
    Private Sub AddPartyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PartySmoking.SelectedIndex = 1
    End Sub

    Private Sub PartyForm_Closed(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles MyBase.Closed
        MainForm.Show()
    End Sub

    Private Sub AddPartyButton_Click(sender As Object, e As EventArgs) Handles AddPartyButton.Click
        'Add Party to DB
        Dim success As Boolean = False

        Try

            Dim Id As Integer
            Id = Me.PartyTableAdapter.InsertPartyProcedure(Me.Party_nameTextBox.Text, Me.Party_phoneTextBox.Text, Me.PartySmoking.SelectedItem.ToString, CType(Me.Party_sizeTextBox.Text, Integer), "Waiting", DateTime.Now, Nothing)
            'Returns the number of rows inserted (which should be only one if it worked)
            If Not Id = 0 Then
                success = True
                'How do we persist these changes?

                For l_index As Integer = 0 To Me.PartyPreferencesListBox.Items.Count - 1
                    Try
                        Dim l_text As String = CStr(Me.PartyPreferencesListBox.Items(l_index))
                        Me.Party_DetailTableAdapter.InsertPreference(Id, l_text)
                    Catch ex As Exception
                        'Most likely there was already an exact preference defined for this member.
                    End Try
                Next

            End If
        Catch ex As Exception
            'Present validation error to the user.
            Me.ValidationErrorWarning.Visible = True
        End Try

        If success = True Then
            'Success close form!!
            MainForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub AddPreferenceButton_Click(sender As Object, e As EventArgs) Handles AddPreferenceButton.Click
        If Not String.IsNullOrEmpty(Me.PreferenceTextBox.Text.ToString) Then
            Me.PartyPreferencesListBox.Items.Add(Me.PreferenceTextBox.Text.ToString)
            Me.PreferenceTextBox.Text = Nothing
        End If
        Me.PreferenceTextBox.Focus()
    End Sub
End Class