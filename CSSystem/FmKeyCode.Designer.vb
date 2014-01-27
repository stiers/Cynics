<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmKeyCode
    Inherits CSAccountDatabaseIntf.StdDBForm

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
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Me.CSSystemDBDataset = New CSAccountDatabaseIntf.CSSystemDBDataset
		Me.MST_KEYCODEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.MST_KEYCODEDataGridView = New System.Windows.Forms.DataGridView
		Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
		CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CSSystemDBDataset, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.MST_KEYCODEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.MST_KEYCODEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'HelpProvider1
		'
		Me.HelpProvider1.HelpNamespace = "C:\Program Files\Microsoft Visual Studio 8\Common7\IDE\Cynics Accounting.chm"
		'
		'CSSystemDBDataset
		'
		Me.CSSystemDBDataset.DataSetName = "CSSystemDBDataset"
		Me.CSSystemDBDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'MST_KEYCODEBindingSource
		'
		Me.MST_KEYCODEBindingSource.DataMember = "MST_KEYCODE"
		Me.MST_KEYCODEBindingSource.DataSource = Me.CSSystemDBDataset
		'
		'MST_KEYCODEDataGridView
		'
		Me.MST_KEYCODEDataGridView.AllowUserToAddRows = False
		Me.MST_KEYCODEDataGridView.AllowUserToDeleteRows = False
		Me.MST_KEYCODEDataGridView.AutoGenerateColumns = False
		Me.MST_KEYCODEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1})
		Me.MST_KEYCODEDataGridView.DataSource = Me.MST_KEYCODEBindingSource
		Me.MST_KEYCODEDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
		Me.MST_KEYCODEDataGridView.Location = New System.Drawing.Point(0, 44)
		Me.MST_KEYCODEDataGridView.Name = "MST_KEYCODEDataGridView"
		Me.MST_KEYCODEDataGridView.Size = New System.Drawing.Size(592, 479)
		Me.MST_KEYCODEDataGridView.TabIndex = 3
		'
		'DataGridViewTextBoxColumn1
		'
		Me.DataGridViewTextBoxColumn1.DataPropertyName = "KEY_NAME"
		DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder
		Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
		Me.DataGridViewTextBoxColumn1.HeaderText = "Documents"
		Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
		Me.DataGridViewTextBoxColumn1.ReadOnly = True
		Me.DataGridViewTextBoxColumn1.Width = 250
		'
		'DataGridViewTextBoxColumn2
		'
		Me.DataGridViewTextBoxColumn2.DataPropertyName = "PREFIX"
		Me.DataGridViewTextBoxColumn2.HeaderText = "Prefix"
		Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
		'
		'DataGridViewTextBoxColumn3
		'
		Me.DataGridViewTextBoxColumn3.DataPropertyName = "KEYNO"
		Me.DataGridViewTextBoxColumn3.HeaderText = "Key No"
		Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
		'
		'DataGridViewCheckBoxColumn1
		'
		Me.DataGridViewCheckBoxColumn1.DataPropertyName = "IS_ACTIVE"
		Me.DataGridViewCheckBoxColumn1.HeaderText = "Active"
		Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
		Me.DataGridViewCheckBoxColumn1.Width = 50
		'
		'FmKeyCode
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.ClientSize = New System.Drawing.Size(592, 523)
		Me.Controls.Add(Me.MST_KEYCODEDataGridView)
		Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
		Me.Name = "FmKeyCode"
		Me.HelpProvider1.SetShowHelp(Me, False)
		Me.Text = "Key Code"
		Me.Controls.SetChildIndex(Me.MST_KEYCODEDataGridView, 0)
		CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CSSystemDBDataset, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.MST_KEYCODEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.MST_KEYCODEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents CSSystemDBDataset As CSAccountDatabaseIntf.CSSystemDBDataset
	Friend WithEvents MST_KEYCODEBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents MST_KEYCODEDataGridView As System.Windows.Forms.DataGridView
	Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn

End Class
