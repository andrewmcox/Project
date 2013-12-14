<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.Table1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PartyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActiveStaffDataGrid = New System.Windows.Forms.DataGridView()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EHostessDataSet = New eHostessV4.eHostessDataSet()
        Me.PartyDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PartyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table12 = New System.Windows.Forms.Button()
        Me.Table2 = New System.Windows.Forms.Button()
        Me.Table3 = New System.Windows.Forms.Button()
        Me.Table4 = New System.Windows.Forms.Button()
        Me.Table5 = New System.Windows.Forms.Button()
        Me.Table6 = New System.Windows.Forms.Button()
        Me.Table7 = New System.Windows.Forms.Button()
        Me.Table8 = New System.Windows.Forms.Button()
        Me.Table9 = New System.Windows.Forms.Button()
        Me.Table10 = New System.Windows.Forms.Button()
        Me.Table11 = New System.Windows.Forms.Button()
        Me.Table13 = New System.Windows.Forms.Button()
        Me.Table14 = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ActiveStaffLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StaffTableAdapter = New eHostessV4.eHostessDataSetTableAdapters.StaffTableAdapter()
        Me.PartyTableAdapter = New eHostessV4.eHostessDataSetTableAdapters.PartyTableAdapter()
        Me.TableAdapterManager = New eHostessV4.eHostessDataSetTableAdapters.TableAdapterManager()
        Me.AssignmentsTableAdapter = New eHostessV4.eHostessDataSetTableAdapters.AssignmentsTableAdapter()
        Me.SeatingTableAdapter = New eHostessV4.eHostessDataSetTableAdapters.SeatingTableAdapter()
        Me.AddPartyButton = New System.Windows.Forms.Button()
        Me.JoinActiveStaffSizeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JoinActiveStaffSizeTableAdapter = New eHostessV4.eHostessDataSetTableAdapters.JoinActiveStaffSizeTableAdapter()
        Me.NameSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ActiveStaffDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EHostessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JoinActiveStaffSizeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Table1
        '
        Me.Table1.Location = New System.Drawing.Point(391, 92)
        Me.Table1.Name = "Table1"
        Me.Table1.Size = New System.Drawing.Size(75, 23)
        Me.Table1.TabIndex = 0
        Me.Table1.Tag = "1"
        Me.Table1.Text = "Table 1"
        Me.Table1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1274, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StaffToolStripMenuItem, Me.PartyToolStripMenuItem, Me.TableToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.AboutToolStripMenuItem.Text = "Manage"
        '
        'StaffToolStripMenuItem
        '
        Me.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem"
        Me.StaffToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.StaffToolStripMenuItem.Text = "Staff"
        '
        'PartyToolStripMenuItem
        '
        Me.PartyToolStripMenuItem.Name = "PartyToolStripMenuItem"
        Me.PartyToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.PartyToolStripMenuItem.Text = "Party"
        '
        'TableToolStripMenuItem
        '
        Me.TableToolStripMenuItem.Name = "TableToolStripMenuItem"
        Me.TableToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.TableToolStripMenuItem.Text = "Table"
        '
        'ActiveStaffDataGrid
        '
        Me.ActiveStaffDataGrid.AutoGenerateColumns = False
        Me.ActiveStaffDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ActiveStaffDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameSizeDataGridViewTextBoxColumn})
        Me.ActiveStaffDataGrid.DataSource = Me.JoinActiveStaffSizeBindingSource
        Me.ActiveStaffDataGrid.Location = New System.Drawing.Point(12, 43)
        Me.ActiveStaffDataGrid.Name = "ActiveStaffDataGrid"
        Me.ActiveStaffDataGrid.Size = New System.Drawing.Size(350, 439)
        Me.ActiveStaffDataGrid.TabIndex = 1
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.EHostessDataSet
        '
        'EHostessDataSet
        '
        Me.EHostessDataSet.DataSetName = "eHostessDataSet"
        Me.EHostessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PartyDataGridView
        '
        Me.PartyDataGridView.AutoGenerateColumns = False
        Me.PartyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PartyDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5})
        Me.PartyDataGridView.DataSource = Me.PartyBindingSource
        Me.PartyDataGridView.Location = New System.Drawing.Point(818, 43)
        Me.PartyDataGridView.Name = "PartyDataGridView"
        Me.PartyDataGridView.Size = New System.Drawing.Size(444, 455)
        Me.PartyDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "party_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "party_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "party_smoking"
        Me.DataGridViewTextBoxColumn4.HeaderText = "party_smoking"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "party_phone"
        Me.DataGridViewTextBoxColumn3.HeaderText = "party_phone"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "party_size"
        Me.DataGridViewTextBoxColumn5.HeaderText = "party_size"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'PartyBindingSource
        '
        Me.PartyBindingSource.DataMember = "Party"
        Me.PartyBindingSource.DataSource = Me.EHostessDataSet
        '
        'Table12
        '
        Me.Table12.Location = New System.Drawing.Point(716, 324)
        Me.Table12.Name = "Table12"
        Me.Table12.Size = New System.Drawing.Size(75, 23)
        Me.Table12.TabIndex = 4
        Me.Table12.Tag = "12"
        Me.Table12.Text = "Table 12"
        Me.Table12.UseVisualStyleBackColor = True
        '
        'Table2
        '
        Me.Table2.Location = New System.Drawing.Point(505, 92)
        Me.Table2.Name = "Table2"
        Me.Table2.Size = New System.Drawing.Size(75, 23)
        Me.Table2.TabIndex = 5
        Me.Table2.Tag = "2"
        Me.Table2.Text = "Table 2"
        Me.Table2.UseVisualStyleBackColor = True
        '
        'Table3
        '
        Me.Table3.Location = New System.Drawing.Point(391, 138)
        Me.Table3.Name = "Table3"
        Me.Table3.Size = New System.Drawing.Size(75, 23)
        Me.Table3.TabIndex = 6
        Me.Table3.Tag = "3"
        Me.Table3.Text = "Table 3"
        Me.Table3.UseVisualStyleBackColor = True
        '
        'Table4
        '
        Me.Table4.Location = New System.Drawing.Point(505, 138)
        Me.Table4.Name = "Table4"
        Me.Table4.Size = New System.Drawing.Size(75, 23)
        Me.Table4.TabIndex = 7
        Me.Table4.Tag = "4"
        Me.Table4.Text = "Table 4"
        Me.Table4.UseVisualStyleBackColor = True
        '
        'Table5
        '
        Me.Table5.Location = New System.Drawing.Point(391, 181)
        Me.Table5.Name = "Table5"
        Me.Table5.Size = New System.Drawing.Size(75, 23)
        Me.Table5.TabIndex = 8
        Me.Table5.Tag = "5"
        Me.Table5.Text = "Table 5"
        Me.Table5.UseVisualStyleBackColor = True
        '
        'Table6
        '
        Me.Table6.Location = New System.Drawing.Point(391, 228)
        Me.Table6.Name = "Table6"
        Me.Table6.Size = New System.Drawing.Size(75, 23)
        Me.Table6.TabIndex = 9
        Me.Table6.Tag = "6"
        Me.Table6.Text = "Table 6"
        Me.Table6.UseVisualStyleBackColor = True
        '
        'Table7
        '
        Me.Table7.Location = New System.Drawing.Point(391, 280)
        Me.Table7.Name = "Table7"
        Me.Table7.Size = New System.Drawing.Size(75, 23)
        Me.Table7.TabIndex = 10
        Me.Table7.Tag = "7"
        Me.Table7.Text = "Table 7"
        Me.Table7.UseVisualStyleBackColor = True
        '
        'Table8
        '
        Me.Table8.Location = New System.Drawing.Point(391, 324)
        Me.Table8.Name = "Table8"
        Me.Table8.Size = New System.Drawing.Size(75, 23)
        Me.Table8.TabIndex = 11
        Me.Table8.Tag = "8"
        Me.Table8.Text = "Table 8"
        Me.Table8.UseVisualStyleBackColor = True
        '
        'Table9
        '
        Me.Table9.Location = New System.Drawing.Point(505, 324)
        Me.Table9.Name = "Table9"
        Me.Table9.Size = New System.Drawing.Size(75, 23)
        Me.Table9.TabIndex = 12
        Me.Table9.Tag = "9"
        Me.Table9.Text = "Table 9"
        Me.Table9.UseVisualStyleBackColor = True
        '
        'Table10
        '
        Me.Table10.Location = New System.Drawing.Point(616, 324)
        Me.Table10.Name = "Table10"
        Me.Table10.Size = New System.Drawing.Size(75, 23)
        Me.Table10.TabIndex = 13
        Me.Table10.Tag = "10"
        Me.Table10.Text = "Table 10"
        Me.Table10.UseVisualStyleBackColor = True
        '
        'Table11
        '
        Me.Table11.Location = New System.Drawing.Point(505, 228)
        Me.Table11.Name = "Table11"
        Me.Table11.Size = New System.Drawing.Size(75, 23)
        Me.Table11.TabIndex = 14
        Me.Table11.Tag = "11"
        Me.Table11.Text = "Table 11"
        Me.Table11.UseVisualStyleBackColor = True
        '
        'Table13
        '
        Me.Table13.Location = New System.Drawing.Point(716, 280)
        Me.Table13.Name = "Table13"
        Me.Table13.Size = New System.Drawing.Size(75, 23)
        Me.Table13.TabIndex = 15
        Me.Table13.Tag = "13"
        Me.Table13.Text = "Table 13"
        Me.Table13.UseVisualStyleBackColor = True
        '
        'Table14
        '
        Me.Table14.Location = New System.Drawing.Point(716, 228)
        Me.Table14.Name = "Table14"
        Me.Table14.Size = New System.Drawing.Size(75, 23)
        Me.Table14.TabIndex = 16
        Me.Table14.Tag = "14"
        Me.Table14.Text = "Table 14"
        Me.Table14.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1274, 622)
        Me.ShapeContainer1.TabIndex = 17
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(384, 65)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(413, 300)
        '
        'ActiveStaffLabel
        '
        Me.ActiveStaffLabel.AutoSize = True
        Me.ActiveStaffLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActiveStaffLabel.Location = New System.Drawing.Point(132, 27)
        Me.ActiveStaffLabel.Name = "ActiveStaffLabel"
        Me.ActiveStaffLabel.Size = New System.Drawing.Size(74, 13)
        Me.ActiveStaffLabel.TabIndex = 18
        Me.ActiveStaffLabel.Text = "Active Staff"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1009, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Party Waitlist"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(565, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Tables"
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.StaffTableAdapter = Me.StaffTableAdapter
        Me.TableAdapterManager.UpdateOrder = eHostessV4.eHostessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AssignmentsTableAdapter
        '
        Me.AssignmentsTableAdapter.ClearBeforeFill = True
        '
        'SeatingTableAdapter
        '
        Me.SeatingTableAdapter.ClearBeforeFill = True
        '
        'AddPartyButton
        '
        Me.AddPartyButton.Location = New System.Drawing.Point(1012, 513)
        Me.AddPartyButton.Name = "AddPartyButton"
        Me.AddPartyButton.Size = New System.Drawing.Size(75, 23)
        Me.AddPartyButton.TabIndex = 21
        Me.AddPartyButton.Text = "Add Party"
        Me.AddPartyButton.UseVisualStyleBackColor = True
        '
        'JoinActiveStaffSizeBindingSource
        '
        Me.JoinActiveStaffSizeBindingSource.DataMember = "JoinActiveStaffSize"
        Me.JoinActiveStaffSizeBindingSource.DataSource = Me.EHostessDataSet
        '
        'JoinActiveStaffSizeTableAdapter
        '
        Me.JoinActiveStaffSizeTableAdapter.ClearBeforeFill = True
        '
        'NameSizeDataGridViewTextBoxColumn
        '
        Me.NameSizeDataGridViewTextBoxColumn.DataPropertyName = "nameSize"
        Me.NameSizeDataGridViewTextBoxColumn.HeaderText = "nameSize"
        Me.NameSizeDataGridViewTextBoxColumn.Name = "NameSizeDataGridViewTextBoxColumn"
        Me.NameSizeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1274, 622)
        Me.Controls.Add(Me.AddPartyButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ActiveStaffLabel)
        Me.Controls.Add(Me.Table14)
        Me.Controls.Add(Me.Table13)
        Me.Controls.Add(Me.Table11)
        Me.Controls.Add(Me.Table10)
        Me.Controls.Add(Me.Table9)
        Me.Controls.Add(Me.Table8)
        Me.Controls.Add(Me.Table7)
        Me.Controls.Add(Me.Table6)
        Me.Controls.Add(Me.Table5)
        Me.Controls.Add(Me.Table4)
        Me.Controls.Add(Me.Table3)
        Me.Controls.Add(Me.Table2)
        Me.Controls.Add(Me.Table12)
        Me.Controls.Add(Me.PartyDataGridView)
        Me.Controls.Add(Me.ActiveStaffDataGrid)
        Me.Controls.Add(Me.Table1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "eHostess Main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ActiveStaffDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EHostessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JoinActiveStaffSizeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Table1 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PartyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActiveStaffDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents EHostessDataSet As eHostessV4.eHostessDataSet
    Friend WithEvents StaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StaffTableAdapter As eHostessV4.eHostessDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents PartyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PartyTableAdapter As eHostessV4.eHostessDataSetTableAdapters.PartyTableAdapter
    Friend WithEvents TableAdapterManager As eHostessV4.eHostessDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PartyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Table12 As System.Windows.Forms.Button
    Friend WithEvents Table2 As System.Windows.Forms.Button
    Friend WithEvents Table3 As System.Windows.Forms.Button
    Friend WithEvents Table4 As System.Windows.Forms.Button
    Friend WithEvents Table5 As System.Windows.Forms.Button
    Friend WithEvents Table6 As System.Windows.Forms.Button
    Friend WithEvents Table7 As System.Windows.Forms.Button
    Friend WithEvents Table8 As System.Windows.Forms.Button
    Friend WithEvents Table9 As System.Windows.Forms.Button
    Friend WithEvents Table10 As System.Windows.Forms.Button
    Friend WithEvents Table11 As System.Windows.Forms.Button
    Friend WithEvents Table13 As System.Windows.Forms.Button
    Friend WithEvents Table14 As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ActiveStaffLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AssignmentsTableAdapter As eHostessV4.eHostessDataSetTableAdapters.AssignmentsTableAdapter
    Friend WithEvents SeatingTableAdapter As eHostessV4.eHostessDataSetTableAdapters.SeatingTableAdapter
    Friend WithEvents AddPartyButton As System.Windows.Forms.Button
    Friend WithEvents JoinActiveStaffSizeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JoinActiveStaffSizeTableAdapter As eHostessV4.eHostessDataSetTableAdapters.JoinActiveStaffSizeTableAdapter
    Friend WithEvents NameSizeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
