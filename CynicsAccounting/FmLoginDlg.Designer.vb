<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmLoginDlg
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
        Dim USERNOLabel As System.Windows.Forms.Label
        Dim PASSWDLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Me.CSSystemDBDataset = New CSAccountDatabaseIntf.CSSystemDBDataset
        Me.UserID = New System.Windows.Forms.TextBox
        Me.UserPasswd = New System.Windows.Forms.TextBox
        Me.BusinessDate = New System.Windows.Forms.DateTimePicker
        Me.StartDate = New System.Windows.Forms.DateTimePicker
        Me.EndDate = New System.Windows.Forms.DateTimePicker
        Me.cmbCompany = New System.Windows.Forms.ComboBox
        Me.CompDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompsDBs = New CSAccountDatabaseIntf.CompsDBs
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnDel = New System.Windows.Forms.Button
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Label5 = New System.Windows.Forms.Label
        USERNOLabel = New System.Windows.Forms.Label
        PASSWDLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        CType(Me.CSSystemDBDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompsDBs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK_Button.DialogResult = System.Windows.Forms.DialogResult.None
        Me.OK_Button.Location = New System.Drawing.Point(243, 12)
        Me.OK_Button.TabIndex = 5
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_Button.Location = New System.Drawing.Point(243, 39)
        Me.Cancel_Button.TabIndex = 6
        '
        'USERNOLabel
        '
        USERNOLabel.AutoSize = True
        USERNOLabel.Location = New System.Drawing.Point(34, 15)
        USERNOLabel.Name = "USERNOLabel"
        USERNOLabel.Size = New System.Drawing.Size(52, 13)
        USERNOLabel.TabIndex = 4
        USERNOLabel.Text = "User ID : "
        '
        'PASSWDLabel
        '
        PASSWDLabel.AutoSize = True
        PASSWDLabel.Location = New System.Drawing.Point(24, 41)
        PASSWDLabel.Name = "PASSWDLabel"
        PASSWDLabel.Size = New System.Drawing.Size(62, 13)
        PASSWDLabel.TabIndex = 5
        PASSWDLabel.Text = "Password : "
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(47, 67)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(39, 13)
        Label1.TabIndex = 10
        Label1.Text = "Date : "
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(22, 92)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(64, 13)
        Label2.TabIndex = 11
        Label2.Text = "Start Date : "
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(25, 115)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(61, 13)
        Label3.TabIndex = 12
        Label3.Text = "End Date : "
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(26, 141)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(60, 13)
        Label4.TabIndex = 13
        Label4.Text = "Company : "
        '
        'CSSystemDBDataset
        '
        Me.CSSystemDBDataset.DataSetName = "CSSystemDBDataset"
        Me.CSSystemDBDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserID
        '
        Me.UserID.Location = New System.Drawing.Point(92, 12)
        Me.UserID.Name = "UserID"
        Me.UserID.Size = New System.Drawing.Size(145, 20)
        Me.UserID.TabIndex = 0
        '
        'UserPasswd
        '
        Me.UserPasswd.Location = New System.Drawing.Point(92, 37)
        Me.UserPasswd.Name = "UserPasswd"
        Me.UserPasswd.Size = New System.Drawing.Size(145, 20)
        Me.UserPasswd.TabIndex = 1
        Me.UserPasswd.UseSystemPasswordChar = True
        '
        'BusinessDate
        '
        Me.BusinessDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BusinessDate.Location = New System.Drawing.Point(92, 62)
        Me.BusinessDate.Name = "BusinessDate"
        Me.BusinessDate.Size = New System.Drawing.Size(145, 20)
        Me.BusinessDate.TabIndex = 2
        '
        'StartDate
        '
        Me.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.StartDate.Location = New System.Drawing.Point(92, 87)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Size = New System.Drawing.Size(145, 20)
        Me.StartDate.TabIndex = 3
        '
        'EndDate
        '
        Me.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.EndDate.Location = New System.Drawing.Point(92, 112)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Size = New System.Drawing.Size(145, 20)
        Me.EndDate.TabIndex = 4
        '
        'cmbCompany
        '
        Me.cmbCompany.DataSource = Me.CompDBBindingSource
        Me.cmbCompany.DisplayMember = "CompName"
        Me.cmbCompany.FormattingEnabled = True
        Me.cmbCompany.Location = New System.Drawing.Point(91, 137)
        Me.cmbCompany.Name = "cmbCompany"
        Me.cmbCompany.Size = New System.Drawing.Size(146, 21)
        Me.cmbCompany.TabIndex = 14
        Me.cmbCompany.ValueMember = "DBName"
        '
        'CompDBBindingSource
        '
        Me.CompDBBindingSource.DataMember = "CompDB"
        Me.CompDBBindingSource.DataSource = Me.CompsDBs
        '
        'CompsDBs
        '
        Me.CompsDBs.DataSetName = "CompsDBs"
        Me.CompsDBs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(242, 138)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(24, 21)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.Location = New System.Drawing.Point(265, 138)
        Me.btnDel.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(24, 21)
        Me.btnDel.TabIndex = 16
        Me.btnDel.Text = "-"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(244, 66)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(71, 13)
        Me.LinkLabel1.TabIndex = 17
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Login Sample"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(244, 83)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 48)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Click here if you log on to a sample database"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FmLoginDlg
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(322, 179)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cmbCompany)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.EndDate)
        Me.Controls.Add(Me.StartDate)
        Me.Controls.Add(Me.BusinessDate)
        Me.Controls.Add(PASSWDLabel)
        Me.Controls.Add(Me.UserPasswd)
        Me.Controls.Add(USERNOLabel)
        Me.Controls.Add(Me.UserID)
        Me.Name = "FmLoginDlg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Dialog"
        Me.Controls.SetChildIndex(Me.Cancel_Button, 0)
        Me.Controls.SetChildIndex(Me.OK_Button, 0)
        Me.Controls.SetChildIndex(Me.UserID, 0)
        Me.Controls.SetChildIndex(USERNOLabel, 0)
        Me.Controls.SetChildIndex(Me.UserPasswd, 0)
        Me.Controls.SetChildIndex(PASSWDLabel, 0)
        Me.Controls.SetChildIndex(Me.BusinessDate, 0)
        Me.Controls.SetChildIndex(Me.StartDate, 0)
        Me.Controls.SetChildIndex(Me.EndDate, 0)
        Me.Controls.SetChildIndex(Label1, 0)
        Me.Controls.SetChildIndex(Label2, 0)
        Me.Controls.SetChildIndex(Label3, 0)
        Me.Controls.SetChildIndex(Label4, 0)
        Me.Controls.SetChildIndex(Me.cmbCompany, 0)
        Me.Controls.SetChildIndex(Me.btnAdd, 0)
        Me.Controls.SetChildIndex(Me.btnDel, 0)
        Me.Controls.SetChildIndex(Me.LinkLabel1, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        CType(Me.CSSystemDBDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompsDBs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CSSystemDBDataset As CSAccountDatabaseIntf.CSSystemDBDataset
    Friend WithEvents UserID As System.Windows.Forms.TextBox
    Friend WithEvents UserPasswd As System.Windows.Forms.TextBox
    Friend WithEvents BusinessDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents StartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents EndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbCompany As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents CompDBBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompsDBs As CSAccountDatabaseIntf.CompsDBs
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
