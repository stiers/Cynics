<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutDlg
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
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.lbAddr1 = New System.Windows.Forms.Label
        Me.lbAddr2 = New System.Windows.Forms.Label
        Me.lbAddr3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lbAddr4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbRegComp = New System.Windows.Forms.Label
        Me.lbRegName = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbDealerName = New System.Windows.Forms.Label
        Me.lbPhoneFax = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Cancel_Button.Location = New System.Drawing.Point(301, 183)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 2
        Me.Cancel_Button.Text = "Close"
        '
        'lbAddr1
        '
        Me.lbAddr1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAddr1.Location = New System.Drawing.Point(123, 52)
        Me.lbAddr1.Name = "lbAddr1"
        Me.lbAddr1.Size = New System.Drawing.Size(251, 13)
        Me.lbAddr1.TabIndex = 4
        Me.lbAddr1.Text = "4-1, Jalan Nyaman 2,"
        Me.lbAddr1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbAddr2
        '
        Me.lbAddr2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAddr2.Location = New System.Drawing.Point(123, 67)
        Me.lbAddr2.Name = "lbAddr2"
        Me.lbAddr2.Size = New System.Drawing.Size(251, 13)
        Me.lbAddr2.TabIndex = 5
        Me.lbAddr2.Text = "Taman Gembira,"
        Me.lbAddr2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbAddr3
        '
        Me.lbAddr3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAddr3.Location = New System.Drawing.Point(123, 82)
        Me.lbAddr3.Name = "lbAddr3"
        Me.lbAddr3.Size = New System.Drawing.Size(251, 13)
        Me.lbAddr3.TabIndex = 6
        Me.lbAddr3.Text = "58200 Kuala Lumpur."
        Me.lbAddr3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(123, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(251, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cynics Accounting"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Location = New System.Drawing.Point(105, 193)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(145, 13)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "www.cynics-soft.com"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.CynicsAccounting.My.Resources.Resources.logo
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(17, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(17, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Version 3.2"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbAddr4
        '
        Me.lbAddr4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAddr4.Location = New System.Drawing.Point(123, 97)
        Me.lbAddr4.Name = "lbAddr4"
        Me.lbAddr4.Size = New System.Drawing.Size(251, 14)
        Me.lbAddr4.TabIndex = 11
        Me.lbAddr4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Registered to : "
        '
        'lbRegComp
        '
        Me.lbRegComp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRegComp.Location = New System.Drawing.Point(105, 167)
        Me.lbRegComp.Name = "lbRegComp"
        Me.lbRegComp.Size = New System.Drawing.Size(145, 13)
        Me.lbRegComp.TabIndex = 14
        '
        'lbRegName
        '
        Me.lbRegName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRegName.Location = New System.Drawing.Point(105, 151)
        Me.lbRegName.Name = "lbRegName"
        Me.lbRegName.Size = New System.Drawing.Size(145, 13)
        Me.lbRegName.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbPhoneFax)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 8)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'lbDealerName
        '
        Me.lbDealerName.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lbDealerName.Location = New System.Drawing.Point(123, 34)
        Me.lbDealerName.Name = "lbDealerName"
        Me.lbDealerName.Size = New System.Drawing.Size(251, 13)
        Me.lbDealerName.TabIndex = 16
        Me.lbDealerName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbPhoneFax
        '
        Me.lbPhoneFax.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPhoneFax.Location = New System.Drawing.Point(103, -12)
        Me.lbPhoneFax.Name = "lbPhoneFax"
        Me.lbPhoneFax.Size = New System.Drawing.Size(251, 13)
        Me.lbPhoneFax.TabIndex = 17
        Me.lbPhoneFax.Text = "LICENSE FROM  WWW.CYNICS-SOFT.COM"
        Me.lbPhoneFax.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Powered by :"
        '
        'AboutDlg
        '
        Me.AcceptButton = Me.Cancel_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 218)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbDealerName)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbRegComp)
        Me.Controls.Add(Me.lbRegName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbAddr4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbAddr3)
        Me.Controls.Add(Me.lbAddr2)
        Me.Controls.Add(Me.lbAddr1)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutDlg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About Dialog"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents lbAddr1 As System.Windows.Forms.Label
    Friend WithEvents lbAddr2 As System.Windows.Forms.Label
    Friend WithEvents lbAddr3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbAddr4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbRegComp As System.Windows.Forms.Label
    Friend WithEvents lbRegName As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbDealerName As System.Windows.Forms.Label
    Friend WithEvents lbPhoneFax As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
