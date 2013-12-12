<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPartyForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Party_nameLabel As System.Windows.Forms.Label
        Dim Party_phoneLabel As System.Windows.Forms.Label
        Dim Party_smokingLabel As System.Windows.Forms.Label
        Dim Party_sizeLabel As System.Windows.Forms.Label
        Me.Party_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Party_phoneTextBox = New System.Windows.Forms.TextBox()
        Me.Party_sizeTextBox = New System.Windows.Forms.TextBox()
        Me.AddPartyButton = New System.Windows.Forms.Button()
        Me.PartyTableAdapter = New eHostessV4.eHostessDataSetTableAdapters.PartyTableAdapter()
        Me.PartySmoking = New System.Windows.Forms.ComboBox()
        Me.ValidationErrorWarning = New System.Windows.Forms.Label()
        Me.PartyPreferencesListBox = New System.Windows.Forms.ListBox()
        Me.PreferenceTextBox = New System.Windows.Forms.TextBox()
        Me.AddPreferenceButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Party_DetailTableAdapter = New eHostessV4.eHostessDataSetTableAdapters.Party_DetailTableAdapter()
        Party_nameLabel = New System.Windows.Forms.Label()
        Party_phoneLabel = New System.Windows.Forms.Label()
        Party_smokingLabel = New System.Windows.Forms.Label()
        Party_sizeLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Party_nameLabel
        '
        Party_nameLabel.AutoSize = True
        Party_nameLabel.Location = New System.Drawing.Point(69, 102)
        Party_nameLabel.Name = "Party_nameLabel"
        Party_nameLabel.Size = New System.Drawing.Size(62, 13)
        Party_nameLabel.TabIndex = 3
        Party_nameLabel.Text = "party name:"
        '
        'Party_phoneLabel
        '
        Party_phoneLabel.AutoSize = True
        Party_phoneLabel.Location = New System.Drawing.Point(69, 128)
        Party_phoneLabel.Name = "Party_phoneLabel"
        Party_phoneLabel.Size = New System.Drawing.Size(66, 13)
        Party_phoneLabel.TabIndex = 5
        Party_phoneLabel.Text = "party phone:"
        '
        'Party_smokingLabel
        '
        Party_smokingLabel.AutoSize = True
        Party_smokingLabel.Location = New System.Drawing.Point(69, 154)
        Party_smokingLabel.Name = "Party_smokingLabel"
        Party_smokingLabel.Size = New System.Drawing.Size(75, 13)
        Party_smokingLabel.TabIndex = 7
        Party_smokingLabel.Text = "party smoking:"
        '
        'Party_sizeLabel
        '
        Party_sizeLabel.AutoSize = True
        Party_sizeLabel.Location = New System.Drawing.Point(69, 180)
        Party_sizeLabel.Name = "Party_sizeLabel"
        Party_sizeLabel.Size = New System.Drawing.Size(54, 13)
        Party_sizeLabel.TabIndex = 9
        Party_sizeLabel.Text = "party size:"
        '
        'Party_nameTextBox
        '
        Me.Party_nameTextBox.Location = New System.Drawing.Point(178, 99)
        Me.Party_nameTextBox.Name = "Party_nameTextBox"
        Me.Party_nameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Party_nameTextBox.TabIndex = 4
        '
        'Party_phoneTextBox
        '
        Me.Party_phoneTextBox.Location = New System.Drawing.Point(178, 125)
        Me.Party_phoneTextBox.Name = "Party_phoneTextBox"
        Me.Party_phoneTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Party_phoneTextBox.TabIndex = 6
        '
        'Party_sizeTextBox
        '
        Me.Party_sizeTextBox.Location = New System.Drawing.Point(178, 177)
        Me.Party_sizeTextBox.Name = "Party_sizeTextBox"
        Me.Party_sizeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Party_sizeTextBox.TabIndex = 10
        '
        'AddPartyButton
        '
        Me.AddPartyButton.Location = New System.Drawing.Point(204, 223)
        Me.AddPartyButton.Name = "AddPartyButton"
        Me.AddPartyButton.Size = New System.Drawing.Size(75, 23)
        Me.AddPartyButton.TabIndex = 11
        Me.AddPartyButton.Text = "Add Party"
        Me.AddPartyButton.UseVisualStyleBackColor = True
        '
        'PartyTableAdapter
        '
        Me.PartyTableAdapter.ClearBeforeFill = True
        '
        'PartySmoking
        '
        Me.PartySmoking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PartySmoking.FormattingEnabled = True
        Me.PartySmoking.Items.AddRange(New Object() {"Y", "N"})
        Me.PartySmoking.Location = New System.Drawing.Point(178, 152)
        Me.PartySmoking.Name = "PartySmoking"
        Me.PartySmoking.Size = New System.Drawing.Size(200, 21)
        Me.PartySmoking.TabIndex = 8
        '
        'ValidationErrorWarning
        '
        Me.ValidationErrorWarning.AutoSize = True
        Me.ValidationErrorWarning.ForeColor = System.Drawing.Color.Maroon
        Me.ValidationErrorWarning.Location = New System.Drawing.Point(56, 268)
        Me.ValidationErrorWarning.Name = "ValidationErrorWarning"
        Me.ValidationErrorWarning.Size = New System.Drawing.Size(388, 13)
        Me.ValidationErrorWarning.TabIndex = 12
        Me.ValidationErrorWarning.Text = "Please ensure that all fields are populated and party size is numeric and try aga" & _
    "in."
        Me.ValidationErrorWarning.Visible = False
        '
        'PartyPreferencesListBox
        '
        Me.PartyPreferencesListBox.FormattingEnabled = True
        Me.PartyPreferencesListBox.Location = New System.Drawing.Point(455, 102)
        Me.PartyPreferencesListBox.Name = "PartyPreferencesListBox"
        Me.PartyPreferencesListBox.Size = New System.Drawing.Size(146, 95)
        Me.PartyPreferencesListBox.TabIndex = 13
        '
        'PreferenceTextBox
        '
        Me.PreferenceTextBox.Location = New System.Drawing.Point(455, 203)
        Me.PreferenceTextBox.Name = "PreferenceTextBox"
        Me.PreferenceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PreferenceTextBox.TabIndex = 14
        '
        'AddPreferenceButton
        '
        Me.AddPreferenceButton.Location = New System.Drawing.Point(561, 203)
        Me.AddPreferenceButton.Name = "AddPreferenceButton"
        Me.AddPreferenceButton.Size = New System.Drawing.Size(40, 20)
        Me.AddPreferenceButton.TabIndex = 15
        Me.AddPreferenceButton.Text = "Add"
        Me.AddPreferenceButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(491, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Preferences"
        '
        'Party_DetailTableAdapter
        '
        Me.Party_DetailTableAdapter.ClearBeforeFill = True
        '
        'AddPartyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 334)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AddPreferenceButton)
        Me.Controls.Add(Me.PreferenceTextBox)
        Me.Controls.Add(Me.PartyPreferencesListBox)
        Me.Controls.Add(Me.ValidationErrorWarning)
        Me.Controls.Add(Me.PartySmoking)
        Me.Controls.Add(Me.AddPartyButton)
        Me.Controls.Add(Party_nameLabel)
        Me.Controls.Add(Me.Party_nameTextBox)
        Me.Controls.Add(Party_phoneLabel)
        Me.Controls.Add(Me.Party_phoneTextBox)
        Me.Controls.Add(Party_smokingLabel)
        Me.Controls.Add(Party_sizeLabel)
        Me.Controls.Add(Me.Party_sizeTextBox)
        Me.Name = "AddPartyForm"
        Me.Text = "Add Party"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Party_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Party_phoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Party_sizeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddPartyButton As System.Windows.Forms.Button
    Friend WithEvents PartyTableAdapter As eHostessV4.eHostessDataSetTableAdapters.PartyTableAdapter
    Friend WithEvents PartySmoking As System.Windows.Forms.ComboBox
    Friend WithEvents ValidationErrorWarning As System.Windows.Forms.Label
    Friend WithEvents PartyPreferencesListBox As System.Windows.Forms.ListBox
    Friend WithEvents PreferenceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddPreferenceButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Party_DetailTableAdapter As eHostessV4.eHostessDataSetTableAdapters.Party_DetailTableAdapter
End Class
