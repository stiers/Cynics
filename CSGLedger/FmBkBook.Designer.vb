<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmBkBook
    Inherits CSAccountDatabaseIntf.StdDBTranForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container
		Dim BKTRAN_CODELabel As System.Windows.Forms.Label
		Dim BANKNOLabel As System.Windows.Forms.Label
		Dim TRAN_DATELabel As System.Windows.Forms.Label
		Dim ACC_YEARLabel As System.Windows.Forms.Label
		Dim ACC_PERIODLabel As System.Windows.Forms.Label
		Dim IS_PAYMENTLabel As System.Windows.Forms.Label
		Dim TOTALAMTLabel As System.Windows.Forms.Label
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Me.CSAccBkBookDataset = New CSAccountDatabaseIntf.CSAccBKBookDataset
		Me.TRN_BKTRANBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.BrowseGrid = New System.Windows.Forms.DataGridView
		Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn
		Me.MSTBANKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
		Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.BKTRAN_CODETextBox = New System.Windows.Forms.TextBox
		Me.BANKNOComboBox = New System.Windows.Forms.ComboBox
		Me.BKDESCTextBox = New System.Windows.Forms.TextBox
		Me.TRAN_DATEDateTimePicker = New System.Windows.Forms.DateTimePicker
		Me.ACC_YEARNumericUpDown = New System.Windows.Forms.NumericUpDown
		Me.ACC_PERIODNumericUpDown = New System.Windows.Forms.NumericUpDown
		Me.IS_PAYMENTCheckBox = New System.Windows.Forms.CheckBox
		Me.TOTALAMTTextBox = New System.Windows.Forms.TextBox
		Me.TRN_BKTRANDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.TRN_BKTRANDDataGridView = New System.Windows.Forms.DataGridView
		Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.btnAccColumn = New System.Windows.Forms.DataGridViewButtonColumn
		Me.AccName = New System.Windows.Forms.DataGridViewComboBoxColumn
		Me.MSTACCOUNTBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
		Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.btnBank = New System.Windows.Forms.Button
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.CALCTOTALAMTTextBox = New System.Windows.Forms.TextBox
		BKTRAN_CODELabel = New System.Windows.Forms.Label
		BANKNOLabel = New System.Windows.Forms.Label
		TRAN_DATELabel = New System.Windows.Forms.Label
		ACC_YEARLabel = New System.Windows.Forms.Label
		ACC_PERIODLabel = New System.Windows.Forms.Label
		IS_PAYMENTLabel = New System.Windows.Forms.Label
		TOTALAMTLabel = New System.Windows.Forms.Label
		Me.BrowsePage.SuspendLayout()
		Me.EditPage.SuspendLayout()
		Me.btnOKCancelPanel.SuspendLayout()
		Me.TabControl.SuspendLayout()
		CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CSAccBkBookDataset, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TRN_BKTRANBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BrowseGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.MSTBANKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ACC_YEARNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ACC_PERIODNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TRN_BKTRANDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TRN_BKTRANDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.MSTACCOUNTBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'BrowsePage
		'
		Me.BrowsePage.Controls.Add(Me.BrowseGrid)
		Me.BrowsePage.Controls.SetChildIndex(Me.btnOKCancelPanel, 0)
		Me.BrowsePage.Controls.SetChildIndex(Me.BrowseGrid, 0)
		'
		'EditPage
		'
		Me.EditPage.AutoScroll = True
		Me.EditPage.Controls.Add(Me.CALCTOTALAMTTextBox)
		Me.EditPage.Controls.Add(Me.Label1)
		Me.EditPage.Controls.Add(Me.Label2)
		Me.EditPage.Controls.Add(Me.btnBank)
		Me.EditPage.Controls.Add(Me.TRN_BKTRANDDataGridView)
		Me.EditPage.Controls.Add(BKTRAN_CODELabel)
		Me.EditPage.Controls.Add(Me.BKTRAN_CODETextBox)
		Me.EditPage.Controls.Add(BANKNOLabel)
		Me.EditPage.Controls.Add(Me.BANKNOComboBox)
		Me.EditPage.Controls.Add(Me.BKDESCTextBox)
		Me.EditPage.Controls.Add(TRAN_DATELabel)
		Me.EditPage.Controls.Add(Me.TRAN_DATEDateTimePicker)
		Me.EditPage.Controls.Add(ACC_YEARLabel)
		Me.EditPage.Controls.Add(Me.ACC_YEARNumericUpDown)
		Me.EditPage.Controls.Add(ACC_PERIODLabel)
		Me.EditPage.Controls.Add(Me.ACC_PERIODNumericUpDown)
		Me.EditPage.Controls.Add(IS_PAYMENTLabel)
		Me.EditPage.Controls.Add(Me.IS_PAYMENTCheckBox)
		Me.EditPage.Controls.Add(TOTALAMTLabel)
		Me.EditPage.Controls.Add(Me.TOTALAMTTextBox)
		'
		'TabControl
		'
		Me.TabControl.Location = New System.Drawing.Point(0, 44)
		Me.TabControl.Size = New System.Drawing.Size(592, 479)
		'
		'BKTRAN_CODELabel
		'
		BKTRAN_CODELabel.AutoSize = True
		BKTRAN_CODELabel.Location = New System.Drawing.Point(25, 9)
		BKTRAN_CODELabel.Name = "BKTRAN_CODELabel"
		BKTRAN_CODELabel.Size = New System.Drawing.Size(45, 13)
		BKTRAN_CODELabel.TabIndex = 0
		BKTRAN_CODELabel.Text = "Tran# : "
		'
		'BANKNOLabel
		'
		BANKNOLabel.AutoSize = True
		BANKNOLabel.Location = New System.Drawing.Point(29, 32)
		BANKNOLabel.Name = "BANKNOLabel"
		BANKNOLabel.Size = New System.Drawing.Size(41, 13)
		BANKNOLabel.TabIndex = 2
		BANKNOLabel.Text = "Bank : "
		'
		'TRAN_DATELabel
		'
		TRAN_DATELabel.AutoSize = True
		TRAN_DATELabel.Location = New System.Drawing.Point(31, 58)
		TRAN_DATELabel.Name = "TRAN_DATELabel"
		TRAN_DATELabel.Size = New System.Drawing.Size(39, 13)
		TRAN_DATELabel.TabIndex = 6
		TRAN_DATELabel.Text = "Date : "
		'
		'ACC_YEARLabel
		'
		ACC_YEARLabel.AutoSize = True
		ACC_YEARLabel.Location = New System.Drawing.Point(321, 9)
		ACC_YEARLabel.Name = "ACC_YEARLabel"
		ACC_YEARLabel.Size = New System.Drawing.Size(93, 13)
		ACC_YEARLabel.TabIndex = 8
		ACC_YEARLabel.Text = "Acc Year Month : "
		'
		'ACC_PERIODLabel
		'
		ACC_PERIODLabel.AutoSize = True
		ACC_PERIODLabel.Location = New System.Drawing.Point(492, 9)
		ACC_PERIODLabel.Name = "ACC_PERIODLabel"
		ACC_PERIODLabel.Size = New System.Drawing.Size(12, 13)
		ACC_PERIODLabel.TabIndex = 10
		ACC_PERIODLabel.Text = "/"
		'
		'IS_PAYMENTLabel
		'
		IS_PAYMENTLabel.AutoSize = True
		IS_PAYMENTLabel.Location = New System.Drawing.Point(13, 81)
		IS_PAYMENTLabel.Name = "IS_PAYMENTLabel"
		IS_PAYMENTLabel.Size = New System.Drawing.Size(57, 13)
		IS_PAYMENTLabel.TabIndex = 12
		IS_PAYMENTLabel.Text = "Payment : "
		'
		'TOTALAMTLabel
		'
		TOTALAMTLabel.AutoSize = True
		TOTALAMTLabel.Location = New System.Drawing.Point(353, 83)
		TOTALAMTLabel.Name = "TOTALAMTLabel"
		TOTALAMTLabel.Size = New System.Drawing.Size(61, 13)
		TOTALAMTLabel.TabIndex = 14
		TOTALAMTLabel.Text = "Total Amt : "
		'
		'CSAccBkBookDataset
		'
		Me.CSAccBkBookDataset.DataSetName = "CSAccBkBookDataset"
		Me.CSAccBkBookDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'TRN_BKTRANBindingSource
		'
		Me.TRN_BKTRANBindingSource.DataMember = "TRN_BKTRAN"
		Me.TRN_BKTRANBindingSource.DataSource = Me.CSAccBkBookDataset
		'
		'BrowseGrid
		'
		Me.BrowseGrid.AllowUserToAddRows = False
		Me.BrowseGrid.AllowUserToDeleteRows = False
		Me.BrowseGrid.AutoGenerateColumns = False
		Me.BrowseGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn9})
		Me.BrowseGrid.DataSource = Me.TRN_BKTRANBindingSource
		Me.BrowseGrid.Dock = System.Windows.Forms.DockStyle.Fill
		Me.BrowseGrid.Location = New System.Drawing.Point(3, 3)
		Me.BrowseGrid.Name = "BrowseGrid"
		Me.BrowseGrid.ReadOnly = True
		Me.BrowseGrid.RowHeadersWidth = 20
		Me.BrowseGrid.Size = New System.Drawing.Size(578, 415)
		Me.BrowseGrid.TabIndex = 4
		'
		'DataGridViewTextBoxColumn2
		'
		Me.DataGridViewTextBoxColumn2.DataPropertyName = "BKTRAN_CODE"
		Me.DataGridViewTextBoxColumn2.HeaderText = "Tran#"
		Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
		Me.DataGridViewTextBoxColumn2.ReadOnly = True
		'
		'DataGridViewTextBoxColumn3
		'
		Me.DataGridViewTextBoxColumn3.DataPropertyName = "BANKNO"
		Me.DataGridViewTextBoxColumn3.DataSource = Me.MSTBANKBindingSource
		Me.DataGridViewTextBoxColumn3.DisplayMember = "BANK_NAME"
		Me.DataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
		Me.DataGridViewTextBoxColumn3.HeaderText = "Bank"
		Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
		Me.DataGridViewTextBoxColumn3.ReadOnly = True
		Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		Me.DataGridViewTextBoxColumn3.ValueMember = "BANKNO"
		'
		'MSTBANKBindingSource
		'
		Me.MSTBANKBindingSource.DataMember = "MST_BANK"
		Me.MSTBANKBindingSource.DataSource = GetType(CSAccountDatabaseIntf.CSAccBKBookDataset)
		'
		'DataGridViewTextBoxColumn5
		'
		Me.DataGridViewTextBoxColumn5.DataPropertyName = "BKDESC"
		Me.DataGridViewTextBoxColumn5.HeaderText = "Memo"
		Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
		Me.DataGridViewTextBoxColumn5.ReadOnly = True
		'
		'DataGridViewTextBoxColumn6
		'
		Me.DataGridViewTextBoxColumn6.DataPropertyName = "TRAN_DATE"
		Me.DataGridViewTextBoxColumn6.HeaderText = "Date"
		Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
		Me.DataGridViewTextBoxColumn6.ReadOnly = True
		Me.DataGridViewTextBoxColumn6.Width = 80
		'
		'DataGridViewCheckBoxColumn1
		'
		Me.DataGridViewCheckBoxColumn1.DataPropertyName = "IS_PAYMENT"
		Me.DataGridViewCheckBoxColumn1.HeaderText = "Paymnt"
		Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
		Me.DataGridViewCheckBoxColumn1.ReadOnly = True
		Me.DataGridViewCheckBoxColumn1.Width = 50
		'
		'DataGridViewTextBoxColumn9
		'
		Me.DataGridViewTextBoxColumn9.DataPropertyName = "TOTALAMT"
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
		DataGridViewCellStyle1.Format = "N2"
		DataGridViewCellStyle1.NullValue = Nothing
		Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle1
		Me.DataGridViewTextBoxColumn9.HeaderText = "Total Amt"
		Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
		Me.DataGridViewTextBoxColumn9.ReadOnly = True
		'
		'BKTRAN_CODETextBox
		'
		Me.BKTRAN_CODETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TRN_BKTRANBindingSource, "BKTRAN_CODE", True))
		Me.BKTRAN_CODETextBox.Location = New System.Drawing.Point(76, 6)
		Me.BKTRAN_CODETextBox.Name = "BKTRAN_CODETextBox"
		Me.BKTRAN_CODETextBox.Size = New System.Drawing.Size(97, 20)
		Me.BKTRAN_CODETextBox.TabIndex = 0
		'
		'BANKNOComboBox
		'
		Me.BANKNOComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TRN_BKTRANBindingSource, "BANKNO", True))
		Me.BANKNOComboBox.DataSource = Me.MSTBANKBindingSource
		Me.BANKNOComboBox.DisplayMember = "BANK_NAME"
		Me.BANKNOComboBox.FormattingEnabled = True
		Me.BANKNOComboBox.Location = New System.Drawing.Point(76, 29)
		Me.BANKNOComboBox.Name = "BANKNOComboBox"
		Me.BANKNOComboBox.Size = New System.Drawing.Size(200, 21)
		Me.BANKNOComboBox.TabIndex = 1
		Me.BANKNOComboBox.ValueMember = "BANKNO"
		'
		'BKDESCTextBox
		'
		Me.BKDESCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TRN_BKTRANBindingSource, "BKDESC", True))
		Me.BKDESCTextBox.Location = New System.Drawing.Point(324, 32)
		Me.BKDESCTextBox.Multiline = True
		Me.BKDESCTextBox.Name = "BKDESCTextBox"
		Me.BKDESCTextBox.Size = New System.Drawing.Size(252, 42)
		Me.BKDESCTextBox.TabIndex = 6
		'
		'TRAN_DATEDateTimePicker
		'
		Me.TRAN_DATEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TRN_BKTRANBindingSource, "TRAN_DATE", True))
		Me.TRAN_DATEDateTimePicker.Location = New System.Drawing.Point(76, 54)
		Me.TRAN_DATEDateTimePicker.Name = "TRAN_DATEDateTimePicker"
		Me.TRAN_DATEDateTimePicker.Size = New System.Drawing.Size(200, 20)
		Me.TRAN_DATEDateTimePicker.TabIndex = 3
		'
		'ACC_YEARNumericUpDown
		'
		Me.ACC_YEARNumericUpDown.BackColor = System.Drawing.SystemColors.InactiveBorder
		Me.ACC_YEARNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TRN_BKTRANBindingSource, "ACC_YEAR", True))
		Me.ACC_YEARNumericUpDown.Enabled = False
		Me.ACC_YEARNumericUpDown.Location = New System.Drawing.Point(420, 6)
		Me.ACC_YEARNumericUpDown.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
		Me.ACC_YEARNumericUpDown.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
		Me.ACC_YEARNumericUpDown.Name = "ACC_YEARNumericUpDown"
		Me.ACC_YEARNumericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.ACC_YEARNumericUpDown.Size = New System.Drawing.Size(66, 20)
		Me.ACC_YEARNumericUpDown.TabIndex = 4
		Me.ACC_YEARNumericUpDown.Value = New Decimal(New Integer() {1900, 0, 0, 0})
		'
		'ACC_PERIODNumericUpDown
		'
		Me.ACC_PERIODNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TRN_BKTRANBindingSource, "ACC_PERIOD", True))
		Me.ACC_PERIODNumericUpDown.Location = New System.Drawing.Point(510, 6)
		Me.ACC_PERIODNumericUpDown.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
		Me.ACC_PERIODNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.ACC_PERIODNumericUpDown.Name = "ACC_PERIODNumericUpDown"
		Me.ACC_PERIODNumericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.ACC_PERIODNumericUpDown.Size = New System.Drawing.Size(66, 20)
		Me.ACC_PERIODNumericUpDown.TabIndex = 5
		Me.ACC_PERIODNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'IS_PAYMENTCheckBox
		'
		Me.IS_PAYMENTCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TRN_BKTRANBindingSource, "IS_PAYMENT", True))
		Me.IS_PAYMENTCheckBox.Location = New System.Drawing.Point(76, 76)
		Me.IS_PAYMENTCheckBox.Name = "IS_PAYMENTCheckBox"
		Me.IS_PAYMENTCheckBox.Size = New System.Drawing.Size(200, 24)
		Me.IS_PAYMENTCheckBox.TabIndex = 13
		'
		'TOTALAMTTextBox
		'
		Me.TOTALAMTTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder
		Me.TOTALAMTTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TOTALAMTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TRN_BKTRANBindingSource, "TOTALAMT", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
		Me.TOTALAMTTextBox.Enabled = False
		Me.TOTALAMTTextBox.Location = New System.Drawing.Point(420, 80)
		Me.TOTALAMTTextBox.Name = "TOTALAMTTextBox"
		Me.TOTALAMTTextBox.Size = New System.Drawing.Size(156, 20)
		Me.TOTALAMTTextBox.TabIndex = 7
		Me.TOTALAMTTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'TRN_BKTRANDBindingSource
		'
		Me.TRN_BKTRANDBindingSource.DataMember = "FK_TRN_BKTRAND_TRN_BKTRAN"
		Me.TRN_BKTRANDBindingSource.DataSource = Me.TRN_BKTRANBindingSource
		'
		'TRN_BKTRANDDataGridView
		'
		Me.TRN_BKTRANDDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TRN_BKTRANDDataGridView.AutoGenerateColumns = False
		Me.TRN_BKTRANDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.btnAccColumn, Me.AccName, Me.DataGridViewTextBoxColumn10})
		Me.TRN_BKTRANDDataGridView.DataSource = Me.TRN_BKTRANDBindingSource
		Me.TRN_BKTRANDDataGridView.Location = New System.Drawing.Point(8, 119)
		Me.TRN_BKTRANDDataGridView.Name = "TRN_BKTRANDDataGridView"
		Me.TRN_BKTRANDDataGridView.RowHeadersWidth = 20
		Me.TRN_BKTRANDDataGridView.Size = New System.Drawing.Size(570, 298)
		Me.TRN_BKTRANDDataGridView.TabIndex = 8
		'
		'DataGridViewTextBoxColumn11
		'
		Me.DataGridViewTextBoxColumn11.DataPropertyName = "AMOUNT"
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
		DataGridViewCellStyle2.Format = "N2"
		DataGridViewCellStyle2.NullValue = Nothing
		Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle2
		Me.DataGridViewTextBoxColumn11.HeaderText = "Amount"
		Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
		Me.DataGridViewTextBoxColumn11.Width = 80
		'
		'DataGridViewTextBoxColumn7
		'
		Me.DataGridViewTextBoxColumn7.DataPropertyName = "CHEQUE_CODE"
		Me.DataGridViewTextBoxColumn7.HeaderText = "Cheque#"
		Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
		Me.DataGridViewTextBoxColumn7.Width = 70
		'
		'DataGridViewTextBoxColumn8
		'
		Me.DataGridViewTextBoxColumn8.DataPropertyName = "ACC_CODE"
		Me.DataGridViewTextBoxColumn8.HeaderText = "Account#"
		Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
		Me.DataGridViewTextBoxColumn8.Width = 70
		'
		'btnAccColumn
		'
		Me.btnAccColumn.HeaderText = ""
		Me.btnAccColumn.Name = "btnAccColumn"
		Me.btnAccColumn.Width = 20
		'
		'AccName
		'
		Me.AccName.DataPropertyName = "ACC_CODE"
		Me.AccName.DataSource = Me.MSTACCOUNTBindingSource1
		DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveBorder
		Me.AccName.DefaultCellStyle = DataGridViewCellStyle3
		Me.AccName.DisplayMember = "ACC_NAME"
		Me.AccName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
		Me.AccName.HeaderText = "Account Name"
		Me.AccName.Name = "AccName"
		Me.AccName.ValueMember = "ACC_CODE"
		Me.AccName.Width = 120
		'
		'MSTACCOUNTBindingSource1
		'
		Me.MSTACCOUNTBindingSource1.DataMember = "MST_ACCOUNT"
		Me.MSTACCOUNTBindingSource1.DataSource = GetType(CSAccountDatabaseIntf.CSAccBKBookDataset)
		'
		'DataGridViewTextBoxColumn10
		'
		Me.DataGridViewTextBoxColumn10.DataPropertyName = "TRANDESC"
		Me.DataGridViewTextBoxColumn10.HeaderText = "Description"
		Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
		Me.DataGridViewTextBoxColumn10.Width = 160
		'
		'btnBank
		'
		Me.btnBank.Location = New System.Drawing.Point(279, 29)
		Me.btnBank.Name = "btnBank"
		Me.btnBank.Size = New System.Drawing.Size(25, 20)
		Me.btnBank.TabIndex = 2
		Me.btnBank.Text = "..."
		Me.btnBank.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
		Me.Label2.Location = New System.Drawing.Point(6, 104)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(396, 12)
		Me.Label2.TabIndex = 56
		Me.Label2.Text = "Please position to Acc# column and use keyboard <Space> key to activate select ac" & _
			"count dialog"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
		Me.Label1.Location = New System.Drawing.Point(92, 82)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(231, 12)
		Me.Label1.TabIndex = 57
		Me.Label1.Text = "Check for issue payment, uncheck for receive payment"
		'
		'CALCTOTALAMTTextBox
		'
		Me.CALCTOTALAMTTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.CALCTOTALAMTTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder
		Me.CALCTOTALAMTTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.CALCTOTALAMTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TRN_BKTRANBindingSource, "CALCTOTALAMT", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
		Me.CALCTOTALAMTTextBox.Location = New System.Drawing.Point(28, 423)
		Me.CALCTOTALAMTTextBox.Name = "CALCTOTALAMTTextBox"
		Me.CALCTOTALAMTTextBox.Size = New System.Drawing.Size(82, 20)
		Me.CALCTOTALAMTTextBox.TabIndex = 58
		Me.CALCTOTALAMTTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'FmBkBook
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.ClientSize = New System.Drawing.Size(592, 523)
		Me.HelpProvider1.SetHelpKeyword(Me, "41100")
		Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
		Me.Name = "FmBkBook"
		Me.HelpProvider1.SetShowHelp(Me, True)
		Me.Text = "Bank Book"
		Me.BrowsePage.ResumeLayout(False)
		Me.EditPage.ResumeLayout(False)
		Me.EditPage.PerformLayout()
		Me.btnOKCancelPanel.ResumeLayout(False)
		Me.TabControl.ResumeLayout(False)
		CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CSAccBkBookDataset, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TRN_BKTRANBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BrowseGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.MSTBANKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ACC_YEARNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ACC_PERIODNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TRN_BKTRANDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TRN_BKTRANDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.MSTACCOUNTBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents BrowseGrid As System.Windows.Forms.DataGridView
    Friend WithEvents TRN_BKTRANBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CSAccBkBookDataset As CSAccountDatabaseIntf.CSAccBkBookDataset
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents MSTBANKBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BKTRAN_CODETextBox As System.Windows.Forms.TextBox
    Friend WithEvents BANKNOComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BKDESCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TRAN_DATEDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ACC_YEARNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents ACC_PERIODNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents IS_PAYMENTCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TOTALAMTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TRN_BKTRANDDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TRN_BKTRANDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MSTACCOUNTBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents btnBank As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAccColumn As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents AccName As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CALCTOTALAMTTextBox As System.Windows.Forms.TextBox

End Class
