<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectedTableForm
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
        Dim Table_idLabel As System.Windows.Forms.Label
        Dim Table_maxLabel As System.Windows.Forms.Label
        Dim Table_smokingLabel As System.Windows.Forms.Label
        Dim Table_xLabel As System.Windows.Forms.Label
        Dim Table_yLabel As System.Windows.Forms.Label
        Dim Table_wLabel As System.Windows.Forms.Label
        Dim Table_hLabel As System.Windows.Forms.Label
        Dim Staff_idLabel As System.Windows.Forms.Label
        Dim Staff_fnameLabel As System.Windows.Forms.Label
        Dim Staff_lnameLabel As System.Windows.Forms.Label
        Dim Staff_max_tableLabel As System.Windows.Forms.Label
        Dim Party_idLabel As System.Windows.Forms.Label
        Dim Party_nameLabel As System.Windows.Forms.Label
        Dim Party_phoneLabel As System.Windows.Forms.Label
        Dim Party_smokingLabel As System.Windows.Forms.Label
        Dim Party_sizeLabel As System.Windows.Forms.Label
        Dim Party_statusLabel As System.Windows.Forms.Label
        Dim Party_arrival_timeLabel As System.Windows.Forms.Label
        Dim Party_departure_timeLabel As System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EHostessDataSet = New eHostessV4.eHostessDataSet()
        Me.SeatingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeatingTableAdapter = New eHostessV4.eHostessDataSetTableAdapters.SeatingTableAdapter()
        Me.TableAdapterManager = New eHostessV4.eHostessDataSetTableAdapters.TableAdapterManager()
        Me.Table_idLabel1 = New System.Windows.Forms.Label()
        Me.Table_maxLabel1 = New System.Windows.Forms.Label()
        Me.Table_smokingLabel1 = New System.Windows.Forms.Label()
        Me.Table_xLabel1 = New System.Windows.Forms.Label()
        Me.Table_yLabel1 = New System.Windows.Forms.Label()
        Me.Table_wLabel1 = New System.Windows.Forms.Label()
        Me.Table_hLabel1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Seating_DetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Seating_DetailTableAdapter = New eHostessV4.eHostessDataSetTableAdapters.Seating_DetailTableAdapter()
        Me.Seating_DetailListBox = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter = New eHostessV4.eHostessDataSetTableAdapters.StaffTableAdapter()
        Me.Staff_idLabel1 = New System.Windows.Forms.Label()
        Me.Staff_fnameLabel1 = New System.Windows.Forms.Label()
        Me.Staff_lnameLabel1 = New System.Windows.Forms.Label()
        Me.Staff_max_tableLabel1 = New System.Windows.Forms.Label()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PartyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PartyTableAdapter = New eHostessV4.eHostessDataSetTableAdapters.PartyTableAdapter()
        Me.Party_idLabel1 = New System.Windows.Forms.Label()
        Me.Party_nameLabel1 = New System.Windows.Forms.Label()
        Me.Party_phoneLabel1 = New System.Windows.Forms.Label()
        Me.Party_smokingLabel1 = New System.Windows.Forms.Label()
        Me.Party_sizeLabel1 = New System.Windows.Forms.Label()
        Me.Party_statusLabel1 = New System.Windows.Forms.Label()
        Me.Party_arrival_timeLabel1 = New System.Windows.Forms.Label()
        Me.Party_departure_timeLabel1 = New System.Windows.Forms.Label()
        Table_idLabel = New System.Windows.Forms.Label()
        Table_maxLabel = New System.Windows.Forms.Label()
        Table_smokingLabel = New System.Windows.Forms.Label()
        Table_xLabel = New System.Windows.Forms.Label()
        Table_yLabel = New System.Windows.Forms.Label()
        Table_wLabel = New System.Windows.Forms.Label()
        Table_hLabel = New System.Windows.Forms.Label()
        Staff_idLabel = New System.Windows.Forms.Label()
        Staff_fnameLabel = New System.Windows.Forms.Label()
        Staff_lnameLabel = New System.Windows.Forms.Label()
        Staff_max_tableLabel = New System.Windows.Forms.Label()
        Party_idLabel = New System.Windows.Forms.Label()
        Party_nameLabel = New System.Windows.Forms.Label()
        Party_phoneLabel = New System.Windows.Forms.Label()
        Party_smokingLabel = New System.Windows.Forms.Label()
        Party_sizeLabel = New System.Windows.Forms.Label()
        Party_statusLabel = New System.Windows.Forms.Label()
        Party_arrival_timeLabel = New System.Windows.Forms.Label()
        Party_departure_timeLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.EHostessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeatingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Seating_DetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Table_idLabel
        '
        Table_idLabel.AutoSize = True
        Table_idLabel.Location = New System.Drawing.Point(389, 99)
        Table_idLabel.Name = "Table_idLabel"
        Table_idLabel.Size = New System.Drawing.Size(44, 13)
        Table_idLabel.TabIndex = 3
        Table_idLabel.Text = "table id:"
        '
        'Table_maxLabel
        '
        Table_maxLabel.AutoSize = True
        Table_maxLabel.Location = New System.Drawing.Point(389, 122)
        Table_maxLabel.Name = "Table_maxLabel"
        Table_maxLabel.Size = New System.Drawing.Size(55, 13)
        Table_maxLabel.TabIndex = 5
        Table_maxLabel.Text = "table max:"
        '
        'Table_smokingLabel
        '
        Table_smokingLabel.AutoSize = True
        Table_smokingLabel.Location = New System.Drawing.Point(389, 145)
        Table_smokingLabel.Name = "Table_smokingLabel"
        Table_smokingLabel.Size = New System.Drawing.Size(75, 13)
        Table_smokingLabel.TabIndex = 7
        Table_smokingLabel.Text = "table smoking:"
        '
        'Table_xLabel
        '
        Table_xLabel.AutoSize = True
        Table_xLabel.Location = New System.Drawing.Point(389, 168)
        Table_xLabel.Name = "Table_xLabel"
        Table_xLabel.Size = New System.Drawing.Size(41, 13)
        Table_xLabel.TabIndex = 9
        Table_xLabel.Text = "table x:"
        '
        'Table_yLabel
        '
        Table_yLabel.AutoSize = True
        Table_yLabel.Location = New System.Drawing.Point(389, 191)
        Table_yLabel.Name = "Table_yLabel"
        Table_yLabel.Size = New System.Drawing.Size(41, 13)
        Table_yLabel.TabIndex = 11
        Table_yLabel.Text = "table y:"
        '
        'Table_wLabel
        '
        Table_wLabel.AutoSize = True
        Table_wLabel.Location = New System.Drawing.Point(389, 214)
        Table_wLabel.Name = "Table_wLabel"
        Table_wLabel.Size = New System.Drawing.Size(44, 13)
        Table_wLabel.TabIndex = 13
        Table_wLabel.Text = "table w:"
        '
        'Table_hLabel
        '
        Table_hLabel.AutoSize = True
        Table_hLabel.Location = New System.Drawing.Point(389, 237)
        Table_hLabel.Name = "Table_hLabel"
        Table_hLabel.Size = New System.Drawing.Size(42, 13)
        Table_hLabel.TabIndex = 15
        Table_hLabel.Text = "table h:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DoneToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1081, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DoneToolStripMenuItem
        '
        Me.DoneToolStripMenuItem.Name = "DoneToolStripMenuItem"
        Me.DoneToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.DoneToolStripMenuItem.Text = "Done"
        '
        'EHostessDataSet
        '
        Me.EHostessDataSet.DataSetName = "eHostessDataSet"
        Me.EHostessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SeatingBindingSource
        '
        Me.SeatingBindingSource.DataMember = "Seating"
        Me.SeatingBindingSource.DataSource = Me.EHostessDataSet
        '
        'SeatingTableAdapter
        '
        Me.SeatingTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Active_StaffTableAdapter = Nothing
        Me.TableAdapterManager.AssignmentsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Party_DetailTableAdapter = Nothing
        Me.TableAdapterManager.PartyTableAdapter = Nothing
        Me.TableAdapterManager.SeatingTableAdapter = Me.SeatingTableAdapter
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = eHostessV4.eHostessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Table_idLabel1
        '
        Me.Table_idLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeatingBindingSource, "table_id", True))
        Me.Table_idLabel1.Location = New System.Drawing.Point(470, 99)
        Me.Table_idLabel1.Name = "Table_idLabel1"
        Me.Table_idLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Table_idLabel1.TabIndex = 4
        Me.Table_idLabel1.Text = "Label1"
        '
        'Table_maxLabel1
        '
        Me.Table_maxLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeatingBindingSource, "table_max", True))
        Me.Table_maxLabel1.Location = New System.Drawing.Point(470, 122)
        Me.Table_maxLabel1.Name = "Table_maxLabel1"
        Me.Table_maxLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Table_maxLabel1.TabIndex = 6
        Me.Table_maxLabel1.Text = "Label1"
        '
        'Table_smokingLabel1
        '
        Me.Table_smokingLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeatingBindingSource, "table_smoking", True))
        Me.Table_smokingLabel1.Location = New System.Drawing.Point(470, 145)
        Me.Table_smokingLabel1.Name = "Table_smokingLabel1"
        Me.Table_smokingLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Table_smokingLabel1.TabIndex = 8
        Me.Table_smokingLabel1.Text = "Label1"
        '
        'Table_xLabel1
        '
        Me.Table_xLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeatingBindingSource, "table_x", True))
        Me.Table_xLabel1.Location = New System.Drawing.Point(470, 168)
        Me.Table_xLabel1.Name = "Table_xLabel1"
        Me.Table_xLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Table_xLabel1.TabIndex = 10
        Me.Table_xLabel1.Text = "Label1"
        '
        'Table_yLabel1
        '
        Me.Table_yLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeatingBindingSource, "table_y", True))
        Me.Table_yLabel1.Location = New System.Drawing.Point(470, 191)
        Me.Table_yLabel1.Name = "Table_yLabel1"
        Me.Table_yLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Table_yLabel1.TabIndex = 12
        Me.Table_yLabel1.Text = "Label1"
        '
        'Table_wLabel1
        '
        Me.Table_wLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeatingBindingSource, "table_w", True))
        Me.Table_wLabel1.Location = New System.Drawing.Point(470, 214)
        Me.Table_wLabel1.Name = "Table_wLabel1"
        Me.Table_wLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Table_wLabel1.TabIndex = 14
        Me.Table_wLabel1.Text = "Label1"
        '
        'Table_hLabel1
        '
        Me.Table_hLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeatingBindingSource, "table_h", True))
        Me.Table_hLabel1.Location = New System.Drawing.Point(470, 237)
        Me.Table_hLabel1.Name = "Table_hLabel1"
        Me.Table_hLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Table_hLabel1.TabIndex = 16
        Me.Table_hLabel1.Text = "Label1"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1081, 462)
        Me.ShapeContainer1.TabIndex = 17
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(377, 46)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(328, 236)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(499, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Table Details"
        '
        'Seating_DetailBindingSource
        '
        Me.Seating_DetailBindingSource.DataMember = "Seating_Detail"
        Me.Seating_DetailBindingSource.DataSource = Me.EHostessDataSet
        '
        'Seating_DetailTableAdapter
        '
        Me.Seating_DetailTableAdapter.ClearBeforeFill = True
        '
        'Seating_DetailListBox
        '
        Me.Seating_DetailListBox.DataSource = Me.Seating_DetailBindingSource
        Me.Seating_DetailListBox.DisplayMember = "table_attribute"
        Me.Seating_DetailListBox.FormattingEnabled = True
        Me.Seating_DetailListBox.Location = New System.Drawing.Point(531, 116)
        Me.Seating_DetailListBox.Name = "Seating_DetailListBox"
        Me.Seating_DetailListBox.Size = New System.Drawing.Size(166, 134)
        Me.Seating_DetailListBox.TabIndex = 0
        Me.Seating_DetailListBox.ValueMember = "table_id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(573, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Table Attributes"
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.EHostessDataSet
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'Staff_idLabel
        '
        Staff_idLabel.AutoSize = True
        Staff_idLabel.Location = New System.Drawing.Point(58, 99)
        Staff_idLabel.Name = "Staff_idLabel"
        Staff_idLabel.Size = New System.Drawing.Size(41, 13)
        Staff_idLabel.TabIndex = 0
        Staff_idLabel.Text = "staff id:"
        '
        'Staff_idLabel1
        '
        Me.Staff_idLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "staff_id", True))
        Me.Staff_idLabel1.Location = New System.Drawing.Point(142, 99)
        Me.Staff_idLabel1.Name = "Staff_idLabel1"
        Me.Staff_idLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Staff_idLabel1.TabIndex = 1
        Me.Staff_idLabel1.Text = "No Staff Assigned"
        '
        'Staff_fnameLabel
        '
        Staff_fnameLabel.AutoSize = True
        Staff_fnameLabel.Location = New System.Drawing.Point(58, 122)
        Staff_fnameLabel.Name = "Staff_fnameLabel"
        Staff_fnameLabel.Size = New System.Drawing.Size(62, 13)
        Staff_fnameLabel.TabIndex = 2
        Staff_fnameLabel.Text = "staff fname:"
        '
        'Staff_fnameLabel1
        '
        Me.Staff_fnameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "staff_fname", True))
        Me.Staff_fnameLabel1.Location = New System.Drawing.Point(142, 122)
        Me.Staff_fnameLabel1.Name = "Staff_fnameLabel1"
        Me.Staff_fnameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Staff_fnameLabel1.TabIndex = 3
        Me.Staff_fnameLabel1.Text = "No Staff Assigned"
        '
        'Staff_lnameLabel
        '
        Staff_lnameLabel.AutoSize = True
        Staff_lnameLabel.Location = New System.Drawing.Point(58, 145)
        Staff_lnameLabel.Name = "Staff_lnameLabel"
        Staff_lnameLabel.Size = New System.Drawing.Size(61, 13)
        Staff_lnameLabel.TabIndex = 4
        Staff_lnameLabel.Text = "staff lname:"
        '
        'Staff_lnameLabel1
        '
        Me.Staff_lnameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "staff_lname", True))
        Me.Staff_lnameLabel1.Location = New System.Drawing.Point(142, 145)
        Me.Staff_lnameLabel1.Name = "Staff_lnameLabel1"
        Me.Staff_lnameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Staff_lnameLabel1.TabIndex = 5
        Me.Staff_lnameLabel1.Text = "No Staff Assigned"
        '
        'Staff_max_tableLabel
        '
        Staff_max_tableLabel.AutoSize = True
        Staff_max_tableLabel.Location = New System.Drawing.Point(58, 168)
        Staff_max_tableLabel.Name = "Staff_max_tableLabel"
        Staff_max_tableLabel.Size = New System.Drawing.Size(78, 13)
        Staff_max_tableLabel.TabIndex = 6
        Staff_max_tableLabel.Text = "staff max table:"
        '
        'Staff_max_tableLabel1
        '
        Me.Staff_max_tableLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "staff_max_table", True))
        Me.Staff_max_tableLabel1.Location = New System.Drawing.Point(142, 168)
        Me.Staff_max_tableLabel1.Name = "Staff_max_tableLabel1"
        Me.Staff_max_tableLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Staff_max_tableLabel1.TabIndex = 7
        Me.Staff_max_tableLabel1.Text = "No Staff Assigned"
        '
        'RectangleShape2
        '
        Me.RectangleShape2.Location = New System.Drawing.Point(20, 46)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(273, 235)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.Location = New System.Drawing.Point(787, 49)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(271, 233)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(891, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Party Details"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(111, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Staff Details"
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
        'Party_idLabel
        '
        Party_idLabel.AutoSize = True
        Party_idLabel.Location = New System.Drawing.Point(803, 89)
        Party_idLabel.Name = "Party_idLabel"
        Party_idLabel.Size = New System.Drawing.Size(44, 13)
        Party_idLabel.TabIndex = 0
        Party_idLabel.Text = "party id:"
        '
        'Party_idLabel1
        '
        Me.Party_idLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PartyBindingSource, "party_id", True))
        Me.Party_idLabel1.Location = New System.Drawing.Point(912, 89)
        Me.Party_idLabel1.Name = "Party_idLabel1"
        Me.Party_idLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Party_idLabel1.TabIndex = 1
        Me.Party_idLabel1.Text = "No Party Assigned"
        '
        'Party_nameLabel
        '
        Party_nameLabel.AutoSize = True
        Party_nameLabel.Location = New System.Drawing.Point(803, 112)
        Party_nameLabel.Name = "Party_nameLabel"
        Party_nameLabel.Size = New System.Drawing.Size(62, 13)
        Party_nameLabel.TabIndex = 2
        Party_nameLabel.Text = "party name:"
        '
        'Party_nameLabel1
        '
        Me.Party_nameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PartyBindingSource, "party_name", True))
        Me.Party_nameLabel1.Location = New System.Drawing.Point(912, 112)
        Me.Party_nameLabel1.Name = "Party_nameLabel1"
        Me.Party_nameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Party_nameLabel1.TabIndex = 3
        Me.Party_nameLabel1.Text = "No Party Assigned"
        '
        'Party_phoneLabel
        '
        Party_phoneLabel.AutoSize = True
        Party_phoneLabel.Location = New System.Drawing.Point(803, 135)
        Party_phoneLabel.Name = "Party_phoneLabel"
        Party_phoneLabel.Size = New System.Drawing.Size(66, 13)
        Party_phoneLabel.TabIndex = 4
        Party_phoneLabel.Text = "party phone:"
        '
        'Party_phoneLabel1
        '
        Me.Party_phoneLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PartyBindingSource, "party_phone", True))
        Me.Party_phoneLabel1.Location = New System.Drawing.Point(912, 135)
        Me.Party_phoneLabel1.Name = "Party_phoneLabel1"
        Me.Party_phoneLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Party_phoneLabel1.TabIndex = 5
        Me.Party_phoneLabel1.Text = "No Party Assigned"
        '
        'Party_smokingLabel
        '
        Party_smokingLabel.AutoSize = True
        Party_smokingLabel.Location = New System.Drawing.Point(803, 158)
        Party_smokingLabel.Name = "Party_smokingLabel"
        Party_smokingLabel.Size = New System.Drawing.Size(75, 13)
        Party_smokingLabel.TabIndex = 6
        Party_smokingLabel.Text = "party smoking:"
        '
        'Party_smokingLabel1
        '
        Me.Party_smokingLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PartyBindingSource, "party_smoking", True))
        Me.Party_smokingLabel1.Location = New System.Drawing.Point(912, 158)
        Me.Party_smokingLabel1.Name = "Party_smokingLabel1"
        Me.Party_smokingLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Party_smokingLabel1.TabIndex = 7
        Me.Party_smokingLabel1.Text = "No Party Assigned"
        '
        'Party_sizeLabel
        '
        Party_sizeLabel.AutoSize = True
        Party_sizeLabel.Location = New System.Drawing.Point(803, 181)
        Party_sizeLabel.Name = "Party_sizeLabel"
        Party_sizeLabel.Size = New System.Drawing.Size(54, 13)
        Party_sizeLabel.TabIndex = 8
        Party_sizeLabel.Text = "party size:"
        '
        'Party_sizeLabel1
        '
        Me.Party_sizeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PartyBindingSource, "party_size", True))
        Me.Party_sizeLabel1.Location = New System.Drawing.Point(912, 181)
        Me.Party_sizeLabel1.Name = "Party_sizeLabel1"
        Me.Party_sizeLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Party_sizeLabel1.TabIndex = 9
        Me.Party_sizeLabel1.Text = "No Party Assigned"
        '
        'Party_statusLabel
        '
        Party_statusLabel.AutoSize = True
        Party_statusLabel.Location = New System.Drawing.Point(803, 204)
        Party_statusLabel.Name = "Party_statusLabel"
        Party_statusLabel.Size = New System.Drawing.Size(64, 13)
        Party_statusLabel.TabIndex = 10
        Party_statusLabel.Text = "party status:"
        '
        'Party_statusLabel1
        '
        Me.Party_statusLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PartyBindingSource, "party_status", True))
        Me.Party_statusLabel1.Location = New System.Drawing.Point(912, 204)
        Me.Party_statusLabel1.Name = "Party_statusLabel1"
        Me.Party_statusLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Party_statusLabel1.TabIndex = 11
        Me.Party_statusLabel1.Text = "No Party Assigned"
        '
        'Party_arrival_timeLabel
        '
        Party_arrival_timeLabel.AutoSize = True
        Party_arrival_timeLabel.Location = New System.Drawing.Point(803, 227)
        Party_arrival_timeLabel.Name = "Party_arrival_timeLabel"
        Party_arrival_timeLabel.Size = New System.Drawing.Size(86, 13)
        Party_arrival_timeLabel.TabIndex = 12
        Party_arrival_timeLabel.Text = "party arrival time:"
        '
        'Party_arrival_timeLabel1
        '
        Me.Party_arrival_timeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PartyBindingSource, "party_arrival_time", True))
        Me.Party_arrival_timeLabel1.Location = New System.Drawing.Point(912, 227)
        Me.Party_arrival_timeLabel1.Name = "Party_arrival_timeLabel1"
        Me.Party_arrival_timeLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Party_arrival_timeLabel1.TabIndex = 13
        Me.Party_arrival_timeLabel1.Text = "No Party Assigned"
        '
        'Party_departure_timeLabel
        '
        Party_departure_timeLabel.AutoSize = True
        Party_departure_timeLabel.Location = New System.Drawing.Point(803, 250)
        Party_departure_timeLabel.Name = "Party_departure_timeLabel"
        Party_departure_timeLabel.Size = New System.Drawing.Size(103, 13)
        Party_departure_timeLabel.TabIndex = 14
        Party_departure_timeLabel.Text = "party departure time:"
        '
        'Party_departure_timeLabel1
        '
        Me.Party_departure_timeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PartyBindingSource, "party_departure_time", True))
        Me.Party_departure_timeLabel1.Location = New System.Drawing.Point(912, 250)
        Me.Party_departure_timeLabel1.Name = "Party_departure_timeLabel1"
        Me.Party_departure_timeLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Party_departure_timeLabel1.TabIndex = 15
        Me.Party_departure_timeLabel1.Text = "No Party Assigned"
        '
        'SelectedTableForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1081, 462)
        Me.Controls.Add(Party_idLabel)
        Me.Controls.Add(Me.Party_idLabel1)
        Me.Controls.Add(Party_nameLabel)
        Me.Controls.Add(Me.Party_nameLabel1)
        Me.Controls.Add(Party_phoneLabel)
        Me.Controls.Add(Me.Party_phoneLabel1)
        Me.Controls.Add(Party_smokingLabel)
        Me.Controls.Add(Me.Party_smokingLabel1)
        Me.Controls.Add(Party_sizeLabel)
        Me.Controls.Add(Me.Party_sizeLabel1)
        Me.Controls.Add(Party_statusLabel)
        Me.Controls.Add(Me.Party_statusLabel1)
        Me.Controls.Add(Party_arrival_timeLabel)
        Me.Controls.Add(Me.Party_arrival_timeLabel1)
        Me.Controls.Add(Party_departure_timeLabel)
        Me.Controls.Add(Me.Party_departure_timeLabel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Staff_idLabel)
        Me.Controls.Add(Me.Staff_idLabel1)
        Me.Controls.Add(Staff_fnameLabel)
        Me.Controls.Add(Me.Staff_fnameLabel1)
        Me.Controls.Add(Staff_lnameLabel)
        Me.Controls.Add(Me.Staff_lnameLabel1)
        Me.Controls.Add(Staff_max_tableLabel)
        Me.Controls.Add(Me.Staff_max_tableLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Seating_DetailListBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Table_idLabel)
        Me.Controls.Add(Me.Table_idLabel1)
        Me.Controls.Add(Table_maxLabel)
        Me.Controls.Add(Me.Table_maxLabel1)
        Me.Controls.Add(Table_smokingLabel)
        Me.Controls.Add(Me.Table_smokingLabel1)
        Me.Controls.Add(Table_xLabel)
        Me.Controls.Add(Me.Table_xLabel1)
        Me.Controls.Add(Table_yLabel)
        Me.Controls.Add(Me.Table_yLabel1)
        Me.Controls.Add(Table_wLabel)
        Me.Controls.Add(Me.Table_wLabel1)
        Me.Controls.Add(Table_hLabel)
        Me.Controls.Add(Me.Table_hLabel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "SelectedTableForm"
        Me.Text = "SelectedTableForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.EHostessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeatingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Seating_DetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DoneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EHostessDataSet As eHostessV4.eHostessDataSet
    Friend WithEvents SeatingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SeatingTableAdapter As eHostessV4.eHostessDataSetTableAdapters.SeatingTableAdapter
    Friend WithEvents TableAdapterManager As eHostessV4.eHostessDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Table_idLabel1 As System.Windows.Forms.Label
    Friend WithEvents Table_maxLabel1 As System.Windows.Forms.Label
    Friend WithEvents Table_smokingLabel1 As System.Windows.Forms.Label
    Friend WithEvents Table_xLabel1 As System.Windows.Forms.Label
    Friend WithEvents Table_yLabel1 As System.Windows.Forms.Label
    Friend WithEvents Table_wLabel1 As System.Windows.Forms.Label
    Friend WithEvents Table_hLabel1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Seating_DetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Seating_DetailTableAdapter As eHostessV4.eHostessDataSetTableAdapters.Seating_DetailTableAdapter
    Friend WithEvents Seating_DetailListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents StaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StaffTableAdapter As eHostessV4.eHostessDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents Staff_idLabel1 As System.Windows.Forms.Label
    Friend WithEvents Staff_fnameLabel1 As System.Windows.Forms.Label
    Friend WithEvents Staff_lnameLabel1 As System.Windows.Forms.Label
    Friend WithEvents Staff_max_tableLabel1 As System.Windows.Forms.Label
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PartyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PartyTableAdapter As eHostessV4.eHostessDataSetTableAdapters.PartyTableAdapter
    Friend WithEvents Party_idLabel1 As System.Windows.Forms.Label
    Friend WithEvents Party_nameLabel1 As System.Windows.Forms.Label
    Friend WithEvents Party_phoneLabel1 As System.Windows.Forms.Label
    Friend WithEvents Party_smokingLabel1 As System.Windows.Forms.Label
    Friend WithEvents Party_sizeLabel1 As System.Windows.Forms.Label
    Friend WithEvents Party_statusLabel1 As System.Windows.Forms.Label
    Friend WithEvents Party_arrival_timeLabel1 As System.Windows.Forms.Label
    Friend WithEvents Party_departure_timeLabel1 As System.Windows.Forms.Label
End Class
