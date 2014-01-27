<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmFilterAccTypeYearDlg
    Inherits CSAccountDatabaseIntf.CSStdDlg

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
        Me.ACC_TYPELabel = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CSSummaryDataset = New CSAccountDatabaseIntf.CSSummaryDataset
        Me.SYS_ACCTYPEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccType = New System.Windows.Forms.ComboBox
        Me.ToYear = New System.Windows.Forms.NumericUpDown
        Me.FrYear = New System.Windows.Forms.NumericUpDown
        CType(Me.CSSummaryDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SYS_ACCTYPEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Location = New System.Drawing.Point(102, 72)
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Location = New System.Drawing.Point(175, 72)
        '
        'ACC_TYPELabel
        '
        Me.ACC_TYPELabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ACC_TYPELabel.AutoSize = True
        Me.ACC_TYPELabel.Location = New System.Drawing.Point(9, 15)
        Me.ACC_TYPELabel.Name = "ACC_TYPELabel"
        Me.ACC_TYPELabel.Size = New System.Drawing.Size(62, 13)
        Me.ACC_TYPELabel.TabIndex = 4
        Me.ACC_TYPELabel.Text = "Acc Type : "
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Acc Year : "
        '
        'CSSummaryDataset
        '
        Me.CSSummaryDataset.DataSetName = "CSSummaryDataset"
        Me.CSSummaryDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SYS_ACCTYPEBindingSource
        '
        Me.SYS_ACCTYPEBindingSource.DataMember = "SYS_ACCTYPE"
        Me.SYS_ACCTYPEBindingSource.DataSource = Me.CSSummaryDataset
        '
        'AccType
        '
        Me.AccType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccType.DataSource = Me.SYS_ACCTYPEBindingSource
        Me.AccType.DisplayMember = "TYPE_NAME"
        Me.AccType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AccType.FormattingEnabled = True
        Me.AccType.Location = New System.Drawing.Point(77, 12)
        Me.AccType.Name = "AccType"
        Me.AccType.Size = New System.Drawing.Size(165, 21)
        Me.AccType.TabIndex = 5
        Me.AccType.ValueMember = "ACC_TYPE"
        '
        'ToYear
        '
        Me.ToYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToYear.Location = New System.Drawing.Point(162, 39)
        Me.ToYear.Maximum = New Decimal(New Integer() {2500, 0, 0, 0})
        Me.ToYear.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.ToYear.Name = "ToYear"
        Me.ToYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToYear.Size = New System.Drawing.Size(79, 20)
        Me.ToYear.TabIndex = 6
        Me.ToYear.Value = New Decimal(New Integer() {1900, 0, 0, 0})
        '
        'FrYear
        '
        Me.FrYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FrYear.Location = New System.Drawing.Point(77, 39)
        Me.FrYear.Maximum = New Decimal(New Integer() {2500, 0, 0, 0})
        Me.FrYear.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.FrYear.Name = "FrYear"
        Me.FrYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FrYear.Size = New System.Drawing.Size(79, 20)
        Me.FrYear.TabIndex = 7
        Me.FrYear.Value = New Decimal(New Integer() {1900, 0, 0, 0})
        '
        'FmFilterAccTypeYearDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(249, 104)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FrYear)
        Me.Controls.Add(Me.ToYear)
        Me.Controls.Add(Me.ACC_TYPELabel)
        Me.Controls.Add(Me.AccType)
        Me.Name = "FmFilterAccTypeYearDlg"
        Me.Text = "Filter Acc. Type and Year"
        Me.Controls.SetChildIndex(Me.Cancel_Button, 0)
        Me.Controls.SetChildIndex(Me.OK_Button, 0)
        Me.Controls.SetChildIndex(Me.AccType, 0)
        Me.Controls.SetChildIndex(Me.ACC_TYPELabel, 0)
        Me.Controls.SetChildIndex(Me.ToYear, 0)
        Me.Controls.SetChildIndex(Me.FrYear, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.CSSummaryDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SYS_ACCTYPEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents ACC_TYPELabel As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents AccType As System.Windows.Forms.ComboBox
    Public WithEvents ToYear As System.Windows.Forms.NumericUpDown
    Public WithEvents FrYear As System.Windows.Forms.NumericUpDown
    Public WithEvents CSSummaryDataset As CSAccountDatabaseIntf.CSSummaryDataset
    Public WithEvents SYS_ACCTYPEBindingSource As System.Windows.Forms.BindingSource

End Class
