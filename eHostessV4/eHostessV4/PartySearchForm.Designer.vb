<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PartySearchForm
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
        Me.txt_Party = New System.Windows.Forms.TextBox()
        Me.txt_Phone = New System.Windows.Forms.TextBox()
        Me.chk_Party = New System.Windows.Forms.CheckBox()
        Me.chk_Phone = New System.Windows.Forms.CheckBox()
        Me.chk_time = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.dtp_Start = New System.Windows.Forms.DateTimePicker()
        Me.dtp_End = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'txt_Party
        '
        Me.txt_Party.Enabled = False
        Me.txt_Party.Location = New System.Drawing.Point(38, 39)
        Me.txt_Party.Name = "txt_Party"
        Me.txt_Party.Size = New System.Drawing.Size(100, 20)
        Me.txt_Party.TabIndex = 0
        '
        'txt_Phone
        '
        Me.txt_Phone.Enabled = False
        Me.txt_Phone.Location = New System.Drawing.Point(189, 39)
        Me.txt_Phone.Name = "txt_Phone"
        Me.txt_Phone.Size = New System.Drawing.Size(100, 20)
        Me.txt_Phone.TabIndex = 1
        '
        'chk_Party
        '
        Me.chk_Party.AutoSize = True
        Me.chk_Party.Location = New System.Drawing.Point(38, 12)
        Me.chk_Party.Name = "chk_Party"
        Me.chk_Party.Size = New System.Drawing.Size(78, 17)
        Me.chk_Party.TabIndex = 2
        Me.chk_Party.Text = "PartyName"
        Me.chk_Party.UseVisualStyleBackColor = True
        '
        'chk_Phone
        '
        Me.chk_Phone.AutoSize = True
        Me.chk_Phone.Location = New System.Drawing.Point(189, 12)
        Me.chk_Phone.Name = "chk_Phone"
        Me.chk_Phone.Size = New System.Drawing.Size(57, 17)
        Me.chk_Phone.TabIndex = 3
        Me.chk_Phone.Text = "Phone"
        Me.chk_Phone.UseVisualStyleBackColor = True
        '
        'chk_time
        '
        Me.chk_time.AutoSize = True
        Me.chk_time.Location = New System.Drawing.Point(364, 12)
        Me.chk_time.Name = "chk_time"
        Me.chk_time.Size = New System.Drawing.Size(81, 17)
        Me.chk_time.TabIndex = 6
        Me.chk_time.Text = "Arrival Time"
        Me.chk_time.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(385, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "And"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(362, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Between"
        '
        'btn_Search
        '
        Me.btn_Search.Location = New System.Drawing.Point(38, 66)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(75, 23)
        Me.btn_Search.TabIndex = 9
        Me.btn_Search.Text = "Search"
        Me.btn_Search.UseVisualStyleBackColor = True
        '
        'dtp_Start
        '
        Me.dtp_Start.Enabled = False
        Me.dtp_Start.Location = New System.Drawing.Point(417, 39)
        Me.dtp_Start.Name = "dtp_Start"
        Me.dtp_Start.Size = New System.Drawing.Size(200, 20)
        Me.dtp_Start.TabIndex = 10
        '
        'dtp_End
        '
        Me.dtp_End.Enabled = False
        Me.dtp_End.Location = New System.Drawing.Point(418, 66)
        Me.dtp_End.Name = "dtp_End"
        Me.dtp_End.Size = New System.Drawing.Size(200, 20)
        Me.dtp_End.TabIndex = 11
        '
        'PartySearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 372)
        Me.Controls.Add(Me.dtp_End)
        Me.Controls.Add(Me.dtp_Start)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chk_time)
        Me.Controls.Add(Me.chk_Phone)
        Me.Controls.Add(Me.chk_Party)
        Me.Controls.Add(Me.txt_Phone)
        Me.Controls.Add(Me.txt_Party)
        Me.Name = "PartySearchForm"
        Me.Text = "PartySearch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Party As System.Windows.Forms.TextBox
    Friend WithEvents txt_Phone As System.Windows.Forms.TextBox
    Friend WithEvents chk_Party As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Phone As System.Windows.Forms.CheckBox
    Friend WithEvents chk_time As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_Search As System.Windows.Forms.Button
    Friend WithEvents dtp_Start As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_End As System.Windows.Forms.DateTimePicker
End Class
