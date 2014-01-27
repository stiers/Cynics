<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CSLicenseDlg
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
        Me.btnReadLicense = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lbDealerName = New System.Windows.Forms.Label
        Me.lbDealerAddr1 = New System.Windows.Forms.Label
        Me.lbDealerAddr2 = New System.Windows.Forms.Label
        Me.lbDealerAddr4 = New System.Windows.Forms.Label
        Me.lbDealerAddr3 = New System.Windows.Forms.Label
        Me.lbPhone = New System.Windows.Forms.Label
        Me.lbFax = New System.Windows.Forms.Label
        Me.lbCustName = New System.Windows.Forms.Label
        Me.lbCustComp = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.txtComputerID = New System.Windows.Forms.TextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Location = New System.Drawing.Point(300, 334)
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Location = New System.Drawing.Point(373, 334)
        '
        'btnReadLicense
        '
        Me.btnReadLicense.Location = New System.Drawing.Point(12, 334)
        Me.btnReadLicense.Name = "btnReadLicense"
        Me.btnReadLicense.Size = New System.Drawing.Size(130, 23)
        Me.btnReadLicense.TabIndex = 4
        Me.btnReadLicense.Text = "Read License"
        Me.btnReadLicense.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Dealer Name : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Address : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Phone : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(87, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Fax : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 279)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Registred Customer : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 297)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Registred Company  : "
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(339, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'lbDealerName
        '
        Me.lbDealerName.Location = New System.Drawing.Point(126, 82)
        Me.lbDealerName.Name = "lbDealerName"
        Me.lbDealerName.Size = New System.Drawing.Size(180, 13)
        Me.lbDealerName.TabIndex = 13
        Me.lbDealerName.Text = "Dealer Name"
        '
        'lbDealerAddr1
        '
        Me.lbDealerAddr1.Location = New System.Drawing.Point(126, 128)
        Me.lbDealerAddr1.Name = "lbDealerAddr1"
        Me.lbDealerAddr1.Size = New System.Drawing.Size(180, 13)
        Me.lbDealerAddr1.TabIndex = 15
        Me.lbDealerAddr1.Text = "Address 1"
        '
        'lbDealerAddr2
        '
        Me.lbDealerAddr2.Location = New System.Drawing.Point(126, 146)
        Me.lbDealerAddr2.Name = "lbDealerAddr2"
        Me.lbDealerAddr2.Size = New System.Drawing.Size(180, 13)
        Me.lbDealerAddr2.TabIndex = 16
        Me.lbDealerAddr2.Text = "Address 2"
        '
        'lbDealerAddr4
        '
        Me.lbDealerAddr4.Location = New System.Drawing.Point(126, 182)
        Me.lbDealerAddr4.Name = "lbDealerAddr4"
        Me.lbDealerAddr4.Size = New System.Drawing.Size(180, 13)
        Me.lbDealerAddr4.TabIndex = 18
        Me.lbDealerAddr4.Text = "Address 4"
        '
        'lbDealerAddr3
        '
        Me.lbDealerAddr3.Location = New System.Drawing.Point(126, 164)
        Me.lbDealerAddr3.Name = "lbDealerAddr3"
        Me.lbDealerAddr3.Size = New System.Drawing.Size(180, 13)
        Me.lbDealerAddr3.TabIndex = 17
        Me.lbDealerAddr3.Text = "Address 3"
        '
        'lbPhone
        '
        Me.lbPhone.Location = New System.Drawing.Point(126, 209)
        Me.lbPhone.Name = "lbPhone"
        Me.lbPhone.Size = New System.Drawing.Size(180, 13)
        Me.lbPhone.TabIndex = 19
        Me.lbPhone.Text = "Phone"
        '
        'lbFax
        '
        Me.lbFax.Location = New System.Drawing.Point(126, 231)
        Me.lbFax.Name = "lbFax"
        Me.lbFax.Size = New System.Drawing.Size(180, 13)
        Me.lbFax.TabIndex = 20
        Me.lbFax.Text = "Fax"
        '
        'lbCustName
        '
        Me.lbCustName.Location = New System.Drawing.Point(126, 279)
        Me.lbCustName.Name = "lbCustName"
        Me.lbCustName.Size = New System.Drawing.Size(180, 13)
        Me.lbCustName.TabIndex = 21
        Me.lbCustName.Text = "Customer"
        '
        'lbCustComp
        '
        Me.lbCustComp.Location = New System.Drawing.Point(126, 297)
        Me.lbCustComp.Name = "lbCustComp"
        Me.lbCustComp.Size = New System.Drawing.Size(180, 13)
        Me.lbCustComp.TabIndex = 22
        Me.lbCustComp.Text = "Customer Company"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "License files (*.lic)|*.lic"
        '
        'txtComputerID
        '
        Me.txtComputerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComputerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComputerID.Location = New System.Drawing.Point(12, 21)
        Me.txtComputerID.Name = "txtComputerID"
        Me.txtComputerID.ReadOnly = True
        Me.txtComputerID.Size = New System.Drawing.Size(427, 29)
        Me.txtComputerID.TabIndex = 24
        Me.txtComputerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CSLicenseDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(447, 366)
        Me.Controls.Add(Me.txtComputerID)
        Me.Controls.Add(Me.lbCustComp)
        Me.Controls.Add(Me.lbCustName)
        Me.Controls.Add(Me.lbFax)
        Me.Controls.Add(Me.lbPhone)
        Me.Controls.Add(Me.lbDealerAddr4)
        Me.Controls.Add(Me.lbDealerAddr3)
        Me.Controls.Add(Me.lbDealerAddr2)
        Me.Controls.Add(Me.lbDealerAddr1)
        Me.Controls.Add(Me.lbDealerName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnReadLicense)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CSLicenseDlg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "License Dialog"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.btnReadLicense, 0)
        Me.Controls.SetChildIndex(Me.Cancel_Button, 0)
        Me.Controls.SetChildIndex(Me.OK_Button, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.lbDealerName, 0)
        Me.Controls.SetChildIndex(Me.lbDealerAddr1, 0)
        Me.Controls.SetChildIndex(Me.lbDealerAddr2, 0)
        Me.Controls.SetChildIndex(Me.lbDealerAddr3, 0)
        Me.Controls.SetChildIndex(Me.lbDealerAddr4, 0)
        Me.Controls.SetChildIndex(Me.lbPhone, 0)
        Me.Controls.SetChildIndex(Me.lbFax, 0)
        Me.Controls.SetChildIndex(Me.lbCustName, 0)
        Me.Controls.SetChildIndex(Me.lbCustComp, 0)
        Me.Controls.SetChildIndex(Me.txtComputerID, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReadLicense As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbDealerName As System.Windows.Forms.Label
    Friend WithEvents lbDealerAddr1 As System.Windows.Forms.Label
    Friend WithEvents lbDealerAddr2 As System.Windows.Forms.Label
    Friend WithEvents lbDealerAddr4 As System.Windows.Forms.Label
    Friend WithEvents lbDealerAddr3 As System.Windows.Forms.Label
    Friend WithEvents lbPhone As System.Windows.Forms.Label
    Friend WithEvents lbFax As System.Windows.Forms.Label
    Friend WithEvents lbCustName As System.Windows.Forms.Label
    Friend WithEvents lbCustComp As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtComputerID As System.Windows.Forms.TextBox

End Class
