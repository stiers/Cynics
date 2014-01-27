<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmBLPLDlg
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
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim TEMPLATE_CODELabel As System.Windows.Forms.Label
        Me.LastMonth = New System.Windows.Forms.NumericUpDown
        Me.LastYear = New System.Windows.Forms.NumericUpDown
        Me.ThisMonth = New System.Windows.Forms.NumericUpDown
        Me.ThisYear = New System.Windows.Forms.NumericUpDown
        Me.TemplateCode = New System.Windows.Forms.ComboBox
        Me.MSTACCREPORTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CSAccRptDataset = New CSAccountDatabaseIntf.CSAccRptDataset
        Label2 = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        TEMPLATE_CODELabel = New System.Windows.Forms.Label
        CType(Me.LastMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LastYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ThisMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ThisYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MSTACCREPORTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSAccRptDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Location = New System.Drawing.Point(185, 86)
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Location = New System.Drawing.Point(258, 86)
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(5, 63)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(100, 13)
        Label2.TabIndex = 17
        Label2.Text = "Last Year - Month : "
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(5, 37)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(100, 13)
        Label1.TabIndex = 16
        Label1.Text = "This Year - Month : "
        '
        'TEMPLATE_CODELabel
        '
        TEMPLATE_CODELabel.AutoSize = True
        TEMPLATE_CODELabel.Location = New System.Drawing.Point(12, 9)
        TEMPLATE_CODELabel.Name = "TEMPLATE_CODELabel"
        TEMPLATE_CODELabel.Size = New System.Drawing.Size(93, 13)
        TEMPLATE_CODELabel.TabIndex = 10
        TEMPLATE_CODELabel.Text = "Select Template : "
        '
        'LastMonth
        '
        Me.LastMonth.Location = New System.Drawing.Point(225, 59)
        Me.LastMonth.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.LastMonth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.LastMonth.Name = "LastMonth"
        Me.LastMonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LastMonth.Size = New System.Drawing.Size(100, 20)
        Me.LastMonth.TabIndex = 15
        Me.LastMonth.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'LastYear
        '
        Me.LastYear.Location = New System.Drawing.Point(110, 59)
        Me.LastYear.Maximum = New Decimal(New Integer() {2500, 0, 0, 0})
        Me.LastYear.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.LastYear.Name = "LastYear"
        Me.LastYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LastYear.Size = New System.Drawing.Size(107, 20)
        Me.LastYear.TabIndex = 14
        Me.LastYear.Value = New Decimal(New Integer() {1900, 0, 0, 0})
        '
        'ThisMonth
        '
        Me.ThisMonth.Location = New System.Drawing.Point(225, 33)
        Me.ThisMonth.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.ThisMonth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ThisMonth.Name = "ThisMonth"
        Me.ThisMonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ThisMonth.Size = New System.Drawing.Size(100, 20)
        Me.ThisMonth.TabIndex = 13
        Me.ThisMonth.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ThisYear
        '
        Me.ThisYear.Location = New System.Drawing.Point(110, 33)
        Me.ThisYear.Maximum = New Decimal(New Integer() {2500, 0, 0, 0})
        Me.ThisYear.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.ThisYear.Name = "ThisYear"
        Me.ThisYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ThisYear.Size = New System.Drawing.Size(107, 20)
        Me.ThisYear.TabIndex = 12
        Me.ThisYear.Value = New Decimal(New Integer() {1900, 0, 0, 0})
        '
        'TemplateCode
        '
        Me.TemplateCode.DataSource = Me.MSTACCREPORTBindingSource
        Me.TemplateCode.DisplayMember = "ACCRPT_NAME"
        Me.TemplateCode.FormattingEnabled = True
        Me.TemplateCode.Location = New System.Drawing.Point(110, 6)
        Me.TemplateCode.Name = "TemplateCode"
        Me.TemplateCode.Size = New System.Drawing.Size(215, 21)
        Me.TemplateCode.TabIndex = 11
        Me.TemplateCode.ValueMember = "ACCRPTNO"
        '
        'MSTACCREPORTBindingSource
        '
        Me.MSTACCREPORTBindingSource.DataMember = "MST_ACCREPORT"
        Me.MSTACCREPORTBindingSource.DataSource = GetType(CSAccountDatabaseIntf.CSAccRptDataset)
        '
        'CSAccRptDataset
        '
        Me.CSAccRptDataset.DataSetName = "CSAccRptDataset"
        Me.CSAccRptDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FmBLPLDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(344, 121)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.LastMonth)
        Me.Controls.Add(Me.LastYear)
        Me.Controls.Add(Me.ThisMonth)
        Me.Controls.Add(Me.ThisYear)
        Me.Controls.Add(TEMPLATE_CODELabel)
        Me.Controls.Add(Me.TemplateCode)
        Me.Name = "FmBLPLDlg"
        Me.Text = "Financial Report"
        Me.Controls.SetChildIndex(Me.Cancel_Button, 0)
        Me.Controls.SetChildIndex(Me.OK_Button, 0)
        Me.Controls.SetChildIndex(Me.TemplateCode, 0)
        Me.Controls.SetChildIndex(TEMPLATE_CODELabel, 0)
        Me.Controls.SetChildIndex(Me.ThisYear, 0)
        Me.Controls.SetChildIndex(Me.ThisMonth, 0)
        Me.Controls.SetChildIndex(Me.LastYear, 0)
        Me.Controls.SetChildIndex(Me.LastMonth, 0)
        Me.Controls.SetChildIndex(Label1, 0)
        Me.Controls.SetChildIndex(Label2, 0)
        CType(Me.LastMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LastYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ThisMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ThisYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MSTACCREPORTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CSAccRptDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LastMonth As System.Windows.Forms.NumericUpDown
    Friend WithEvents LastYear As System.Windows.Forms.NumericUpDown
    Friend WithEvents ThisMonth As System.Windows.Forms.NumericUpDown
    Friend WithEvents ThisYear As System.Windows.Forms.NumericUpDown
    Friend WithEvents TemplateCode As System.Windows.Forms.ComboBox
    Friend WithEvents MSTACCREPORTBindingSource As System.Windows.Forms.BindingSource
    Public WithEvents CSAccRptDataset As CSAccountDatabaseIntf.CSAccRptDataset

End Class
