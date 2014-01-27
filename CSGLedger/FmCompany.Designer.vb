<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmCompany
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
        Dim COMP_NAMELabel As System.Windows.Forms.Label
        Dim REG_CODELabel As System.Windows.Forms.Label
        Dim ACC_YEARLabel As System.Windows.Forms.Label
        Dim CURR_CODELabel As System.Windows.Forms.Label
        Dim PHONENOLabel As System.Windows.Forms.Label
        Dim FAXNOLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim ACC_APLabel As System.Windows.Forms.Label
        Dim ACC_APDISCLabel As System.Windows.Forms.Label
        Dim ACC_ARLabel As System.Windows.Forms.Label
        Dim ACC_ARDISCLabel As System.Windows.Forms.Label
        Dim ACC_SALESLabel As System.Windows.Forms.Label
        Dim START_MONTHLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.CSMasterDataset = New CSAccountDatabaseIntf.CSMasterDataset
        Me.MST_COMPANYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BrowseGrid = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.COMP_NAMETextBox = New System.Windows.Forms.TextBox
        Me.REG_CODETextBox = New System.Windows.Forms.TextBox
        Me.ACC_YEARNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.CURR_CODEComboBox = New System.Windows.Forms.ComboBox
        Me.MSTCURRENCYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ADDR1TextBox = New System.Windows.Forms.TextBox
        Me.ADDR2TextBox = New System.Windows.Forms.TextBox
        Me.ADDR3TextBox = New System.Windows.Forms.TextBox
        Me.ADDR4TextBox = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PHONENOMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.FAXNOMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.btnCurrency = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnSales = New System.Windows.Forms.Button
        Me.ACC_SALESComboBox = New System.Windows.Forms.ComboBox
        Me.MSTACCOUNTBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnARDisc = New System.Windows.Forms.Button
        Me.btnAR = New System.Windows.Forms.Button
        Me.btnAPDisc = New System.Windows.Forms.Button
        Me.btnAP = New System.Windows.Forms.Button
        Me.ACC_ARDISCComboBox = New System.Windows.Forms.ComboBox
        Me.MSTAccountBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACC_ARComboBox = New System.Windows.Forms.ComboBox
        Me.MSTAccountBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACC_APDISCComboBox = New System.Windows.Forms.ComboBox
        Me.MSTAccountBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACC_APComboBox = New System.Windows.Forms.ComboBox
        Me.MSTACCOUNTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.START_MONTHNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.btnCloseYear = New System.Windows.Forms.Button
        COMP_NAMELabel = New System.Windows.Forms.Label
        REG_CODELabel = New System.Windows.Forms.Label
        ACC_YEARLabel = New System.Windows.Forms.Label
        CURR_CODELabel = New System.Windows.Forms.Label
        PHONENOLabel = New System.Windows.Forms.Label
        FAXNOLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        ACC_APLabel = New System.Windows.Forms.Label
        ACC_APDISCLabel = New System.Windows.Forms.Label
        ACC_ARLabel = New System.Windows.Forms.Label
        ACC_ARDISCLabel = New System.Windows.Forms.Label
        ACC_SALESLabel = New System.Windows.Forms.Label
        START_MONTHLabel = New System.Windows.Forms.Label
        Me.BrowsePage.SuspendLayout()
        Me.EditPage.SuspendLayout()
        Me.btnOKCancelPanel.SuspendLayout()
        Me.TabControl.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSMasterDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MST_COMPANYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrowseGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACC_YEARNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MSTCURRENCYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.MSTACCOUNTBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MSTAccountBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MSTAccountBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MSTAccountBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MSTACCOUNTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.START_MONTHNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BrowsePage
        '
        Me.BrowsePage.Controls.Add(Me.BrowseGrid)
        Me.BrowsePage.Controls.SetChildIndex(Me.BrowseGrid, 0)
        Me.BrowsePage.Controls.SetChildIndex(Me.btnOKCancelPanel, 0)
        '
        'EditPage
        '
        Me.EditPage.AutoScroll = True
        Me.EditPage.Controls.Add(Me.btnCloseYear)
        Me.EditPage.Controls.Add(START_MONTHLabel)
        Me.EditPage.Controls.Add(Me.START_MONTHNumericUpDown)
        Me.EditPage.Controls.Add(Me.GroupBox2)
        Me.EditPage.Controls.Add(Me.btnCurrency)
        Me.EditPage.Controls.Add(Me.FAXNOMaskedTextBox)
        Me.EditPage.Controls.Add(Me.PHONENOMaskedTextBox)
        Me.EditPage.Controls.Add(Label1)
        Me.EditPage.Controls.Add(Me.GroupBox1)
        Me.EditPage.Controls.Add(COMP_NAMELabel)
        Me.EditPage.Controls.Add(Me.COMP_NAMETextBox)
        Me.EditPage.Controls.Add(REG_CODELabel)
        Me.EditPage.Controls.Add(Me.REG_CODETextBox)
        Me.EditPage.Controls.Add(ACC_YEARLabel)
        Me.EditPage.Controls.Add(Me.ACC_YEARNumericUpDown)
        Me.EditPage.Controls.Add(CURR_CODELabel)
        Me.EditPage.Controls.Add(Me.CURR_CODEComboBox)
        Me.EditPage.Controls.Add(PHONENOLabel)
        Me.EditPage.Controls.Add(FAXNOLabel)
        '
        'TabControl
        '
        Me.TabControl.Location = New System.Drawing.Point(0, 44)
        Me.TabControl.Size = New System.Drawing.Size(592, 479)
        Me.TabControl.TabIndex = 0
        '
        'COMP_NAMELabel
        '
        COMP_NAMELabel.AutoSize = True
        COMP_NAMELabel.Location = New System.Drawing.Point(17, 18)
        COMP_NAMELabel.Name = "COMP_NAMELabel"
        COMP_NAMELabel.Size = New System.Drawing.Size(77, 13)
        COMP_NAMELabel.TabIndex = 2
        COMP_NAMELabel.Text = "Comp. Name : "
        '
        'REG_CODELabel
        '
        REG_CODELabel.AutoSize = True
        REG_CODELabel.Location = New System.Drawing.Point(48, 44)
        REG_CODELabel.Name = "REG_CODELabel"
        REG_CODELabel.Size = New System.Drawing.Size(43, 13)
        REG_CODELabel.TabIndex = 4
        REG_CODELabel.Text = "Reg# : "
        '
        'ACC_YEARLabel
        '
        ACC_YEARLabel.AutoSize = True
        ACC_YEARLabel.Location = New System.Drawing.Point(442, 73)
        ACC_YEARLabel.Name = "ACC_YEARLabel"
        ACC_YEARLabel.Size = New System.Drawing.Size(68, 13)
        ACC_YEARLabel.TabIndex = 6
        ACC_YEARLabel.Text = "Fiscal Year : "
        '
        'CURR_CODELabel
        '
        CURR_CODELabel.AutoSize = True
        CURR_CODELabel.Location = New System.Drawing.Point(33, 70)
        CURR_CODELabel.Name = "CURR_CODELabel"
        CURR_CODELabel.Size = New System.Drawing.Size(58, 13)
        CURR_CODELabel.TabIndex = 8
        CURR_CODELabel.Text = "Currency : "
        '
        'PHONENOLabel
        '
        PHONENOLabel.AutoSize = True
        PHONENOLabel.Location = New System.Drawing.Point(354, 20)
        PHONENOLabel.Name = "PHONENOLabel"
        PHONENOLabel.Size = New System.Drawing.Size(54, 13)
        PHONENOLabel.TabIndex = 18
        PHONENOLabel.Text = "Phone# : "
        '
        'FAXNOLabel
        '
        FAXNOLabel.AutoSize = True
        FAXNOLabel.Location = New System.Drawing.Point(368, 45)
        FAXNOLabel.Name = "FAXNOLabel"
        FAXNOLabel.Size = New System.Drawing.Size(40, 13)
        FAXNOLabel.TabIndex = 20
        FAXNOLabel.Text = "Fax# : "
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(43, 106)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(48, 13)
        Label1.TabIndex = 23
        Label1.Text = "Adress : "
        '
        'ACC_APLabel
        '
        ACC_APLabel.AutoSize = True
        ACC_APLabel.Location = New System.Drawing.Point(35, 27)
        ACC_APLabel.Name = "ACC_APLabel"
        ACC_APLabel.Size = New System.Drawing.Size(97, 13)
        ACC_APLabel.TabIndex = 0
        ACC_APLabel.Text = "Account Payable : "
        '
        'ACC_APDISCLabel
        '
        ACC_APDISCLabel.AutoSize = True
        ACC_APDISCLabel.Location = New System.Drawing.Point(57, 50)
        ACC_APDISCLabel.Name = "ACC_APDISCLabel"
        ACC_APDISCLabel.Size = New System.Drawing.Size(75, 13)
        ACC_APDISCLabel.TabIndex = 2
        ACC_APDISCLabel.Text = "AP Discount : "
        '
        'ACC_ARLabel
        '
        ACC_ARLabel.AutoSize = True
        ACC_ARLabel.Location = New System.Drawing.Point(19, 74)
        ACC_ARLabel.Name = "ACC_ARLabel"
        ACC_ARLabel.Size = New System.Drawing.Size(113, 13)
        ACC_ARLabel.TabIndex = 4
        ACC_ARLabel.Text = "Account Receivable : "
        '
        'ACC_ARDISCLabel
        '
        ACC_ARDISCLabel.AutoSize = True
        ACC_ARDISCLabel.Location = New System.Drawing.Point(56, 98)
        ACC_ARDISCLabel.Name = "ACC_ARDISCLabel"
        ACC_ARDISCLabel.Size = New System.Drawing.Size(76, 13)
        ACC_ARDISCLabel.TabIndex = 6
        ACC_ARDISCLabel.Text = "AR Discount : "
        '
        'ACC_SALESLabel
        '
        ACC_SALESLabel.AutoSize = True
        ACC_SALESLabel.Location = New System.Drawing.Point(47, 121)
        ACC_SALESLabel.Name = "ACC_SALESLabel"
        ACC_SALESLabel.Size = New System.Drawing.Size(85, 13)
        ACC_SALESLabel.TabIndex = 30
        ACC_SALESLabel.Text = "Sales Account : "
        '
        'START_MONTHLabel
        '
        START_MONTHLabel.AutoSize = True
        START_MONTHLabel.Location = New System.Drawing.Point(444, 99)
        START_MONTHLabel.Name = "START_MONTHLabel"
        START_MONTHLabel.Size = New System.Drawing.Size(71, 13)
        START_MONTHLabel.TabIndex = 23
        START_MONTHLabel.Text = "Start Month : "
        '
        'CSMasterDataset
        '
        Me.CSMasterDataset.DataSetName = "CSMasterDataset"
        Me.CSMasterDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MST_COMPANYBindingSource
        '
        Me.MST_COMPANYBindingSource.DataMember = "MST_COMPANY"
        Me.MST_COMPANYBindingSource.DataSource = Me.CSMasterDataset
        '
        'BrowseGrid
        '
        Me.BrowseGrid.AutoGenerateColumns = False
        Me.BrowseGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.BrowseGrid.DataSource = Me.MST_COMPANYBindingSource
        Me.BrowseGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BrowseGrid.Location = New System.Drawing.Point(3, 3)
        Me.BrowseGrid.Name = "BrowseGrid"
        Me.BrowseGrid.ReadOnly = True
        Me.BrowseGrid.Size = New System.Drawing.Size(578, 444)
        Me.BrowseGrid.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "COMP_NAME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Company Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 180
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "REG_CODE"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Reg. Code"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ACC_YEAR"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fiscal.Y"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 60
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PHONENO"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn10.HeaderText = "Phone#"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "FAXNO"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn11.HeaderText = "Fax#"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'COMP_NAMETextBox
        '
        Me.COMP_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MST_COMPANYBindingSource, "COMP_NAME", True))
        Me.COMP_NAMETextBox.Location = New System.Drawing.Point(97, 16)
        Me.COMP_NAMETextBox.Name = "COMP_NAMETextBox"
        Me.COMP_NAMETextBox.Size = New System.Drawing.Size(247, 20)
        Me.COMP_NAMETextBox.TabIndex = 0
        '
        'REG_CODETextBox
        '
        Me.REG_CODETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MST_COMPANYBindingSource, "REG_CODE", True))
        Me.REG_CODETextBox.Location = New System.Drawing.Point(97, 42)
        Me.REG_CODETextBox.Name = "REG_CODETextBox"
        Me.REG_CODETextBox.Size = New System.Drawing.Size(247, 20)
        Me.REG_CODETextBox.TabIndex = 1
        '
        'ACC_YEARNumericUpDown
        '
        Me.ACC_YEARNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MST_COMPANYBindingSource, "ACC_YEAR", True))
        Me.ACC_YEARNumericUpDown.Location = New System.Drawing.Point(516, 70)
        Me.ACC_YEARNumericUpDown.Maximum = New Decimal(New Integer() {2500, 0, 0, 0})
        Me.ACC_YEARNumericUpDown.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.ACC_YEARNumericUpDown.Name = "ACC_YEARNumericUpDown"
        Me.ACC_YEARNumericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ACC_YEARNumericUpDown.Size = New System.Drawing.Size(54, 20)
        Me.ACC_YEARNumericUpDown.TabIndex = 6
        Me.ACC_YEARNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ACC_YEARNumericUpDown.Value = New Decimal(New Integer() {1900, 0, 0, 0})
        '
        'CURR_CODEComboBox
        '
        Me.CURR_CODEComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MST_COMPANYBindingSource, "CURR_CODE", True))
        Me.CURR_CODEComboBox.DataSource = Me.MSTCURRENCYBindingSource
        Me.CURR_CODEComboBox.DisplayMember = "CURR_NAME"
        Me.CURR_CODEComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CURR_CODEComboBox.FormattingEnabled = True
        Me.CURR_CODEComboBox.Location = New System.Drawing.Point(97, 70)
        Me.CURR_CODEComboBox.Name = "CURR_CODEComboBox"
        Me.CURR_CODEComboBox.Size = New System.Drawing.Size(219, 21)
        Me.CURR_CODEComboBox.TabIndex = 2
        Me.CURR_CODEComboBox.ValueMember = "CURR_CODE"
        '
        'MSTCURRENCYBindingSource
        '
        Me.MSTCURRENCYBindingSource.DataMember = "MST_CURRENCY"
        Me.MSTCURRENCYBindingSource.DataSource = GetType(CSAccountDatabaseIntf.CSMasterDataset)
        '
        'ADDR1TextBox
        '
        Me.ADDR1TextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ADDR1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MST_COMPANYBindingSource, "ADDR1", True))
        Me.ADDR1TextBox.Location = New System.Drawing.Point(10, 15)
        Me.ADDR1TextBox.Name = "ADDR1TextBox"
        Me.ADDR1TextBox.Size = New System.Drawing.Size(225, 20)
        Me.ADDR1TextBox.TabIndex = 0
        '
        'ADDR2TextBox
        '
        Me.ADDR2TextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ADDR2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MST_COMPANYBindingSource, "ADDR2", True))
        Me.ADDR2TextBox.Location = New System.Drawing.Point(10, 37)
        Me.ADDR2TextBox.Name = "ADDR2TextBox"
        Me.ADDR2TextBox.Size = New System.Drawing.Size(225, 20)
        Me.ADDR2TextBox.TabIndex = 1
        '
        'ADDR3TextBox
        '
        Me.ADDR3TextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ADDR3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MST_COMPANYBindingSource, "ADDR3", True))
        Me.ADDR3TextBox.Location = New System.Drawing.Point(10, 59)
        Me.ADDR3TextBox.Name = "ADDR3TextBox"
        Me.ADDR3TextBox.Size = New System.Drawing.Size(225, 20)
        Me.ADDR3TextBox.TabIndex = 2
        '
        'ADDR4TextBox
        '
        Me.ADDR4TextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ADDR4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MST_COMPANYBindingSource, "ADDR4", True))
        Me.ADDR4TextBox.Location = New System.Drawing.Point(10, 80)
        Me.ADDR4TextBox.Name = "ADDR4TextBox"
        Me.ADDR4TextBox.Size = New System.Drawing.Size(225, 20)
        Me.ADDR4TextBox.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ADDR1TextBox)
        Me.GroupBox1.Controls.Add(Me.ADDR2TextBox)
        Me.GroupBox1.Controls.Add(Me.ADDR3TextBox)
        Me.GroupBox1.Controls.Add(Me.ADDR4TextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(97, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(247, 109)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'PHONENOMaskedTextBox
        '
        Me.PHONENOMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MST_COMPANYBindingSource, "PHONENO", True))
        Me.PHONENOMaskedTextBox.Location = New System.Drawing.Point(411, 16)
        Me.PHONENOMaskedTextBox.Mask = "(999) 0000-0000"
        Me.PHONENOMaskedTextBox.Name = "PHONENOMaskedTextBox"
        Me.PHONENOMaskedTextBox.Size = New System.Drawing.Size(159, 20)
        Me.PHONENOMaskedTextBox.TabIndex = 4
        Me.PHONENOMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'FAXNOMaskedTextBox
        '
        Me.FAXNOMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MST_COMPANYBindingSource, "FAXNO", True))
        Me.FAXNOMaskedTextBox.Location = New System.Drawing.Point(411, 42)
        Me.FAXNOMaskedTextBox.Mask = "(999) 0000-0000"
        Me.FAXNOMaskedTextBox.Name = "FAXNOMaskedTextBox"
        Me.FAXNOMaskedTextBox.Size = New System.Drawing.Size(159, 20)
        Me.FAXNOMaskedTextBox.TabIndex = 5
        Me.FAXNOMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'btnCurrency
        '
        Me.btnCurrency.Location = New System.Drawing.Point(319, 70)
        Me.btnCurrency.Name = "btnCurrency"
        Me.btnCurrency.Size = New System.Drawing.Size(25, 20)
        Me.btnCurrency.TabIndex = 3
        Me.btnCurrency.Text = "..."
        Me.btnCurrency.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSales)
        Me.GroupBox2.Controls.Add(ACC_SALESLabel)
        Me.GroupBox2.Controls.Add(Me.ACC_SALESComboBox)
        Me.GroupBox2.Controls.Add(Me.btnARDisc)
        Me.GroupBox2.Controls.Add(Me.btnAR)
        Me.GroupBox2.Controls.Add(Me.btnAPDisc)
        Me.GroupBox2.Controls.Add(Me.btnAP)
        Me.GroupBox2.Controls.Add(ACC_ARDISCLabel)
        Me.GroupBox2.Controls.Add(Me.ACC_ARDISCComboBox)
        Me.GroupBox2.Controls.Add(ACC_ARLabel)
        Me.GroupBox2.Controls.Add(Me.ACC_ARComboBox)
        Me.GroupBox2.Controls.Add(ACC_APDISCLabel)
        Me.GroupBox2.Controls.Add(Me.ACC_APDISCComboBox)
        Me.GroupBox2.Controls.Add(ACC_APLabel)
        Me.GroupBox2.Controls.Add(Me.ACC_APComboBox)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 226)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(565, 156)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Invoice Account Settings"
        '
        'btnSales
        '
        Me.btnSales.Location = New System.Drawing.Point(336, 118)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(25, 20)
        Me.btnSales.TabIndex = 9
        Me.btnSales.Text = "..."
        Me.btnSales.UseVisualStyleBackColor = True
        '
        'ACC_SALESComboBox
        '
        Me.ACC_SALESComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MST_COMPANYBindingSource, "ACC_SALES", True))
        Me.ACC_SALESComboBox.DataSource = Me.MSTACCOUNTBindingSource4
        Me.ACC_SALESComboBox.DisplayMember = "ACC_NAME"
        Me.ACC_SALESComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ACC_SALESComboBox.FormattingEnabled = True
        Me.ACC_SALESComboBox.Location = New System.Drawing.Point(138, 118)
        Me.ACC_SALESComboBox.Name = "ACC_SALESComboBox"
        Me.ACC_SALESComboBox.Size = New System.Drawing.Size(195, 21)
        Me.ACC_SALESComboBox.TabIndex = 8
        Me.ACC_SALESComboBox.ValueMember = "ACC_CODE"
        '
        'MSTACCOUNTBindingSource4
        '
        Me.MSTACCOUNTBindingSource4.DataMember = "MST_ACCOUNT"
        Me.MSTACCOUNTBindingSource4.DataSource = GetType(CSAccountDatabaseIntf.CSMasterDataset)
        Me.MSTACCOUNTBindingSource4.Filter = "ACC_TYPE in (6)"
        '
        'btnARDisc
        '
        Me.btnARDisc.Location = New System.Drawing.Point(336, 95)
        Me.btnARDisc.Name = "btnARDisc"
        Me.btnARDisc.Size = New System.Drawing.Size(25, 20)
        Me.btnARDisc.TabIndex = 7
        Me.btnARDisc.Text = "..."
        Me.btnARDisc.UseVisualStyleBackColor = True
        '
        'btnAR
        '
        Me.btnAR.Location = New System.Drawing.Point(336, 71)
        Me.btnAR.Name = "btnAR"
        Me.btnAR.Size = New System.Drawing.Size(25, 20)
        Me.btnAR.TabIndex = 5
        Me.btnAR.Text = "..."
        Me.btnAR.UseVisualStyleBackColor = True
        '
        'btnAPDisc
        '
        Me.btnAPDisc.Location = New System.Drawing.Point(336, 47)
        Me.btnAPDisc.Name = "btnAPDisc"
        Me.btnAPDisc.Size = New System.Drawing.Size(25, 20)
        Me.btnAPDisc.TabIndex = 3
        Me.btnAPDisc.Text = "..."
        Me.btnAPDisc.UseVisualStyleBackColor = True
        '
        'btnAP
        '
        Me.btnAP.Location = New System.Drawing.Point(336, 24)
        Me.btnAP.Name = "btnAP"
        Me.btnAP.Size = New System.Drawing.Size(25, 20)
        Me.btnAP.TabIndex = 1
        Me.btnAP.Text = "..."
        Me.btnAP.UseVisualStyleBackColor = True
        '
        'ACC_ARDISCComboBox
        '
        Me.ACC_ARDISCComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MST_COMPANYBindingSource, "ACC_ARDISC", True))
        Me.ACC_ARDISCComboBox.DataSource = Me.MSTAccountBindingSource3
        Me.ACC_ARDISCComboBox.DisplayMember = "ACC_NAME"
        Me.ACC_ARDISCComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ACC_ARDISCComboBox.FormattingEnabled = True
        Me.ACC_ARDISCComboBox.Location = New System.Drawing.Point(138, 95)
        Me.ACC_ARDISCComboBox.Name = "ACC_ARDISCComboBox"
        Me.ACC_ARDISCComboBox.Size = New System.Drawing.Size(195, 21)
        Me.ACC_ARDISCComboBox.TabIndex = 6
        Me.ACC_ARDISCComboBox.ValueMember = "ACC_CODE"
        '
        'MSTAccountBindingSource3
        '
        Me.MSTAccountBindingSource3.DataMember = "MST_ACCOUNT"
        Me.MSTAccountBindingSource3.DataSource = GetType(CSAccountDatabaseIntf.CSMasterDataset)
        Me.MSTAccountBindingSource3.Filter = "ACC_TYPE in (6,7)"
        '
        'ACC_ARComboBox
        '
        Me.ACC_ARComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MST_COMPANYBindingSource, "ACC_AR", True))
        Me.ACC_ARComboBox.DataSource = Me.MSTAccountBindingSource2
        Me.ACC_ARComboBox.DisplayMember = "ACC_NAME"
        Me.ACC_ARComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ACC_ARComboBox.FormattingEnabled = True
        Me.ACC_ARComboBox.Location = New System.Drawing.Point(138, 71)
        Me.ACC_ARComboBox.Name = "ACC_ARComboBox"
        Me.ACC_ARComboBox.Size = New System.Drawing.Size(195, 21)
        Me.ACC_ARComboBox.TabIndex = 4
        Me.ACC_ARComboBox.ValueMember = "ACC_CODE"
        '
        'MSTAccountBindingSource2
        '
        Me.MSTAccountBindingSource2.DataMember = "MST_ACCOUNT"
        Me.MSTAccountBindingSource2.DataSource = GetType(CSAccountDatabaseIntf.CSMasterDataset)
        Me.MSTAccountBindingSource2.Filter = "ACC_TYPE=2"
        '
        'ACC_APDISCComboBox
        '
        Me.ACC_APDISCComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MST_COMPANYBindingSource, "ACC_APDISC", True))
        Me.ACC_APDISCComboBox.DataSource = Me.MSTAccountBindingSource1
        Me.ACC_APDISCComboBox.DisplayMember = "ACC_NAME"
        Me.ACC_APDISCComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ACC_APDISCComboBox.FormattingEnabled = True
        Me.ACC_APDISCComboBox.Location = New System.Drawing.Point(138, 47)
        Me.ACC_APDISCComboBox.Name = "ACC_APDISCComboBox"
        Me.ACC_APDISCComboBox.Size = New System.Drawing.Size(195, 21)
        Me.ACC_APDISCComboBox.TabIndex = 2
        Me.ACC_APDISCComboBox.ValueMember = "ACC_CODE"
        '
        'MSTAccountBindingSource1
        '
        Me.MSTAccountBindingSource1.DataMember = "MST_ACCOUNT"
        Me.MSTAccountBindingSource1.DataSource = GetType(CSAccountDatabaseIntf.CSMasterDataset)
        Me.MSTAccountBindingSource1.Filter = "ACC_TYPE in (6,7)"
        '
        'ACC_APComboBox
        '
        Me.ACC_APComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MST_COMPANYBindingSource, "ACC_AP", True))
        Me.ACC_APComboBox.DataSource = Me.MSTACCOUNTBindingSource
        Me.ACC_APComboBox.DisplayMember = "ACC_NAME"
        Me.ACC_APComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ACC_APComboBox.FormattingEnabled = True
        Me.ACC_APComboBox.Location = New System.Drawing.Point(138, 24)
        Me.ACC_APComboBox.Name = "ACC_APComboBox"
        Me.ACC_APComboBox.Size = New System.Drawing.Size(195, 21)
        Me.ACC_APComboBox.TabIndex = 0
        Me.ACC_APComboBox.ValueMember = "ACC_CODE"
        '
        'MSTACCOUNTBindingSource
        '
        Me.MSTACCOUNTBindingSource.DataMember = "MST_ACCOUNT"
        Me.MSTACCOUNTBindingSource.DataSource = GetType(CSAccountDatabaseIntf.CSMasterDataset)
        Me.MSTACCOUNTBindingSource.Filter = "ACC_TYPE=4"
        '
        'START_MONTHNumericUpDown
        '
        Me.START_MONTHNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MST_COMPANYBindingSource, "START_MONTH", True))
        Me.START_MONTHNumericUpDown.Location = New System.Drawing.Point(516, 96)
        Me.START_MONTHNumericUpDown.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.START_MONTHNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.START_MONTHNumericUpDown.Name = "START_MONTHNumericUpDown"
        Me.START_MONTHNumericUpDown.Size = New System.Drawing.Size(54, 20)
        Me.START_MONTHNumericUpDown.TabIndex = 7
        Me.START_MONTHNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.START_MONTHNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnCloseYear
        '
        Me.btnCloseYear.Location = New System.Drawing.Point(357, 122)
        Me.btnCloseYear.Name = "btnCloseYear"
        Me.btnCloseYear.Size = New System.Drawing.Size(213, 29)
        Me.btnCloseYear.TabIndex = 8
        Me.btnCloseYear.Text = "Year End Closing"
        Me.btnCloseYear.UseVisualStyleBackColor = True
        '
        'FmCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(592, 523)
        Me.HelpProvider1.SetHelpKeyword(Me, "40300")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Name = "FmCompany"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Company Data"
        Me.BrowsePage.ResumeLayout(False)
        Me.EditPage.ResumeLayout(False)
        Me.EditPage.PerformLayout()
        Me.btnOKCancelPanel.ResumeLayout(False)
        Me.TabControl.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CSMasterDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MST_COMPANYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrowseGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACC_YEARNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MSTCURRENCYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.MSTACCOUNTBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MSTAccountBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MSTAccountBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MSTAccountBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MSTACCOUNTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.START_MONTHNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BrowseGrid As System.Windows.Forms.DataGridView
    Friend WithEvents MST_COMPANYBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CSMasterDataset As CSAccountDatabaseIntf.CSMasterDataset
    Friend WithEvents COMP_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents REG_CODETextBox As System.Windows.Forms.TextBox
    Friend WithEvents ACC_YEARNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents CURR_CODEComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ADDR1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ADDR2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ADDR3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ADDR4TextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MSTCURRENCYBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FAXNOMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PHONENOMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnCurrency As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ACC_ARDISCComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ACC_ARComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ACC_APDISCComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ACC_APComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MSTACCOUNTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnARDisc As System.Windows.Forms.Button
    Friend WithEvents btnAR As System.Windows.Forms.Button
    Friend WithEvents btnAPDisc As System.Windows.Forms.Button
    Friend WithEvents btnAP As System.Windows.Forms.Button
    Friend WithEvents MSTAccountBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents MSTAccountBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents MSTAccountBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ACC_SALESComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnSales As System.Windows.Forms.Button
    Friend WithEvents MSTACCOUNTBindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents START_MONTHNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnCloseYear As System.Windows.Forms.Button

End Class
