<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssignTableForm
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
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_TableID = New System.Windows.Forms.Label()
        Me.lbl_TableMax = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_TableSmoking = New System.Windows.Forms.Label()
        Me.lb_Attributes = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lb_Staff = New System.Windows.Forms.ListBox()
        Me.lb_party = New System.Windows.Forms.ListBox()
        Me.lb_PartyAttributes = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_Assign = New System.Windows.Forms.Button()
        Me.EHostessDataSet = New eHostessV4.eHostessDataSet()
        Me.SeatingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeatingTableAdapter = New eHostessV4.eHostessDataSetTableAdapters.SeatingTableAdapter()
        Me.SeatingDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Seating_DetailTableAdapter = New eHostessV4.eHostessDataSetTableAdapters.Seating_DetailTableAdapter()
        CType(Me.EHostessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeatingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeatingDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape4, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(756, 417)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape4
        '
        Me.RectangleShape4.Location = New System.Drawing.Point(143, 183)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(570, 218)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.Location = New System.Drawing.Point(458, 26)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(255, 129)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(24, 27)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(411, 127)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Table ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Table Max:"
        '
        'lbl_TableID
        '
        Me.lbl_TableID.AutoSize = True
        Me.lbl_TableID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeatingBindingSource, "table_id", True))
        Me.lbl_TableID.Location = New System.Drawing.Point(146, 46)
        Me.lbl_TableID.Name = "lbl_TableID"
        Me.lbl_TableID.Size = New System.Drawing.Size(39, 13)
        Me.lbl_TableID.TabIndex = 3
        Me.lbl_TableID.Text = "Label3"
        '
        'lbl_TableMax
        '
        Me.lbl_TableMax.AutoSize = True
        Me.lbl_TableMax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeatingBindingSource, "table_max", True))
        Me.lbl_TableMax.Location = New System.Drawing.Point(146, 73)
        Me.lbl_TableMax.Name = "lbl_TableMax"
        Me.lbl_TableMax.Size = New System.Drawing.Size(39, 13)
        Me.lbl_TableMax.TabIndex = 4
        Me.lbl_TableMax.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Table Smoking:"
        '
        'lbl_TableSmoking
        '
        Me.lbl_TableSmoking.AutoSize = True
        Me.lbl_TableSmoking.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeatingBindingSource, "table_smoking", True))
        Me.lbl_TableSmoking.Location = New System.Drawing.Point(146, 99)
        Me.lbl_TableSmoking.Name = "lbl_TableSmoking"
        Me.lbl_TableSmoking.Size = New System.Drawing.Size(39, 13)
        Me.lbl_TableSmoking.TabIndex = 6
        Me.lbl_TableSmoking.Text = "Label6"
        '
        'lb_Attributes
        '
        Me.lb_Attributes.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SeatingDetailBindingSource, "table_attribute", True))
        Me.lb_Attributes.FormattingEnabled = True
        Me.lb_Attributes.Location = New System.Drawing.Point(239, 41)
        Me.lb_Attributes.Name = "lb_Attributes"
        Me.lb_Attributes.Size = New System.Drawing.Size(185, 95)
        Me.lb_Attributes.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(199, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Table Attributes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(545, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Select Staff"
        '
        'lb_Staff
        '
        Me.lb_Staff.FormattingEnabled = True
        Me.lb_Staff.Location = New System.Drawing.Point(480, 41)
        Me.lb_Staff.Name = "lb_Staff"
        Me.lb_Staff.Size = New System.Drawing.Size(215, 95)
        Me.lb_Staff.TabIndex = 10
        '
        'lb_party
        '
        Me.lb_party.FormattingEnabled = True
        Me.lb_party.Location = New System.Drawing.Point(171, 213)
        Me.lb_party.Name = "lb_party"
        Me.lb_party.Size = New System.Drawing.Size(253, 160)
        Me.lb_party.TabIndex = 11
        '
        'lb_PartyAttributes
        '
        Me.lb_PartyAttributes.FormattingEnabled = True
        Me.lb_PartyAttributes.Location = New System.Drawing.Point(480, 230)
        Me.lb_PartyAttributes.Name = "lb_PartyAttributes"
        Me.lb_PartyAttributes.Size = New System.Drawing.Size(210, 95)
        Me.lb_PartyAttributes.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(545, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Preferences"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(277, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Parties"
        '
        'btn_Assign
        '
        Me.btn_Assign.Location = New System.Drawing.Point(21, 265)
        Me.btn_Assign.Name = "btn_Assign"
        Me.btn_Assign.Size = New System.Drawing.Size(92, 60)
        Me.btn_Assign.TabIndex = 15
        Me.btn_Assign.Text = "Assign Party"
        Me.btn_Assign.UseVisualStyleBackColor = True
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
        'SeatingDetailBindingSource
        '
        Me.SeatingDetailBindingSource.DataMember = "Seating_Detail"
        Me.SeatingDetailBindingSource.DataSource = Me.EHostessDataSet
        '
        'Seating_DetailTableAdapter
        '
        Me.Seating_DetailTableAdapter.ClearBeforeFill = True
        '
        'AssignTableForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 417)
        Me.Controls.Add(Me.btn_Assign)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lb_PartyAttributes)
        Me.Controls.Add(Me.lb_party)
        Me.Controls.Add(Me.lb_Staff)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lb_Attributes)
        Me.Controls.Add(Me.lbl_TableSmoking)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_TableMax)
        Me.Controls.Add(Me.lbl_TableID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "AssignTableForm"
        Me.Text = "AssignTableForm"
        CType(Me.EHostessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeatingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeatingDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_TableID As System.Windows.Forms.Label
    Friend WithEvents lbl_TableMax As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_TableSmoking As System.Windows.Forms.Label
    Friend WithEvents lb_Attributes As System.Windows.Forms.ListBox
    Friend WithEvents RectangleShape4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lb_Staff As System.Windows.Forms.ListBox
    Friend WithEvents lb_party As System.Windows.Forms.ListBox
    Friend WithEvents lb_PartyAttributes As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_Assign As System.Windows.Forms.Button
    Friend WithEvents EHostessDataSet As eHostessV4.eHostessDataSet
    Friend WithEvents SeatingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SeatingTableAdapter As eHostessV4.eHostessDataSetTableAdapters.SeatingTableAdapter
    Friend WithEvents SeatingDetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Seating_DetailTableAdapter As eHostessV4.eHostessDataSetTableAdapters.Seating_DetailTableAdapter
End Class
