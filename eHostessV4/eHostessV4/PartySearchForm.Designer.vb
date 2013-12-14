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
        Me.components = New System.ComponentModel.Container()
        Me.txt_Party = New System.Windows.Forms.TextBox()
        Me.txt_Phone = New System.Windows.Forms.TextBox()
        Me.chk_time = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.dtp_Start = New System.Windows.Forms.DateTimePicker()
        Me.dtp_End = New System.Windows.Forms.DateTimePicker()
        Me.EHostessDataSet = New eHostessV4.eHostessDataSet()
        Me.PartyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PartyTableAdapter = New eHostessV4.eHostessDataSetTableAdapters.PartyTableAdapter()
        Me.TableAdapterManager = New eHostessV4.eHostessDataSetTableAdapters.TableAdapterManager()
        Me.PartyDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.EHostessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_Party
        '
        Me.txt_Party.Location = New System.Drawing.Point(38, 39)
        Me.txt_Party.Name = "txt_Party"
        Me.txt_Party.Size = New System.Drawing.Size(100, 20)
        Me.txt_Party.TabIndex = 0
        '
        'txt_Phone
        '
        Me.txt_Phone.Location = New System.Drawing.Point(189, 39)
        Me.txt_Phone.Name = "txt_Phone"
        Me.txt_Phone.Size = New System.Drawing.Size(100, 20)
        Me.txt_Phone.TabIndex = 1
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
        'EHostessDataSet
        '
        Me.EHostessDataSet.DataSetName = "eHostessDataSet"
        Me.EHostessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PartyBindingSource
        '
        Me.PartyBindingSource.DataMember = "Party"
        Me.PartyBindingSource.DataSource = Me.EHostessDataSet
        '
        'PartyTableAdapter
        '
        Me.PartyTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Active_StaffTableAdapter = Nothing
        Me.TableAdapterManager.AssignmentsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Party_DetailTableAdapter = Nothing
        Me.TableAdapterManager.PartyTableAdapter = Me.PartyTableAdapter
        Me.TableAdapterManager.Seating_DetailTableAdapter = Nothing
        Me.TableAdapterManager.SeatingTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = eHostessV4.eHostessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PartyDataGridView
        '
        Me.PartyDataGridView.AutoGenerateColumns = False
        Me.PartyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PartyDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.PartyDataGridView.DataSource = Me.PartyBindingSource
        Me.PartyDataGridView.Location = New System.Drawing.Point(38, 109)
        Me.PartyDataGridView.Name = "PartyDataGridView"
        Me.PartyDataGridView.Size = New System.Drawing.Size(620, 264)
        Me.PartyDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "party_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "party_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "party_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "party_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "party_phone"
        Me.DataGridViewTextBoxColumn3.HeaderText = "party_phone"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "party_smoking"
        Me.DataGridViewTextBoxColumn4.HeaderText = "party_smoking"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "party_size"
        Me.DataGridViewTextBoxColumn5.HeaderText = "party_size"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "party_status"
        Me.DataGridViewTextBoxColumn6.HeaderText = "party_status"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "party_arrival_time"
        Me.DataGridViewTextBoxColumn7.HeaderText = "party_arrival_time"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "party_departure_time"
        Me.DataGridViewTextBoxColumn8.HeaderText = "party_departure_time"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Party"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(191, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Phone"
        '
        'PartySearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 398)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PartyDataGridView)
        Me.Controls.Add(Me.dtp_End)
        Me.Controls.Add(Me.dtp_Start)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chk_time)
        Me.Controls.Add(Me.txt_Phone)
        Me.Controls.Add(Me.txt_Party)
        Me.Name = "PartySearchForm"
        Me.Text = "PartySearch"
        CType(Me.EHostessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Party As System.Windows.Forms.TextBox
    Friend WithEvents txt_Phone As System.Windows.Forms.TextBox
    Friend WithEvents chk_time As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_Search As System.Windows.Forms.Button
    Friend WithEvents dtp_Start As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_End As System.Windows.Forms.DateTimePicker
    Friend WithEvents EHostessDataSet As eHostessV4.eHostessDataSet
    Friend WithEvents PartyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PartyTableAdapter As eHostessV4.eHostessDataSetTableAdapters.PartyTableAdapter
    Friend WithEvents TableAdapterManager As eHostessV4.eHostessDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PartyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
