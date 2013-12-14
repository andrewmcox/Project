Public Class PartySearchForm

    Private Sub chk_time_CheckedChanged(sender As Object, e As EventArgs) Handles chk_time.CheckedChanged
        If chk_time.Checked = True Then
            dtp_Start.Enabled = True
            dtp_End.Enabled = True
        ElseIf chk_time.Checked = False Then
            dtp_Start.Enabled = False
            dtp_End.Enabled = False
            dtp_Start.Value = 

        End If
    End Sub

    Private Sub chk_Party_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Party.CheckedChanged
        If chk_Party.Checked = True Then
            txt_Party.Enabled = True
        ElseIf chk_Party.Checked = False Then
            txt_Party.Enabled = False
        End If
    End Sub

    Private Sub chk_Phone_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Phone.CheckedChanged
        If chk_Phone.Checked = True Then
            txt_Phone.Enabled = True
        ElseIf chk_Phone.Checked = False Then
            txt_Phone.Enabled = False
        End If
    End Sub
End Class