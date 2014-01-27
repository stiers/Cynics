<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmCustomersAgeDlg
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
        Dim CUSTOMER_CODELabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.CSAccReporting = New CSAccountDatabaseIntf.CSAccReporting
        Me.MST_CUSTOMERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FrCustomer = New System.Windows.Forms.ComboBox
        Me.MST_CUSTOMERBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToCustomer = New System.Windows.Forms.ComboBox
        Me.AsOfDate = New System.Windows.Forms.DateTimePicker
        CUSTOMER_CODELabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        CType(Me.CSAccReporting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MST_CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MST_CUSTOMERBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Location = New System.Drawing.Point(159, 88)
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Location = New System.Drawing.Point(232, 88)
        '
        'CSAccReporting
        '
        Me.CSAccReporting.DataSetName = "CSAccReporting"
        Me.CSAccReporting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MST_CUSTOMERBindingSource
        '
        Me.MST_CUSTOMERBindingSource.DataMember = "MST_CUSTOMER"
        Me.MST_CUSTOMERBindingSource.DataSource = Me.CSAccReporting
        '
        'CUSTOMER_CODELabel
        '
        CUSTOMER_CODELabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CUSTOMER_CODELabel.AutoSize = True
        CUSTOMER_CODELabel.Location = New System.Drawing.Point(16, 38)
        CUSTOMER_CODELabel.Name = "CUSTOMER_CODELabel"
        CUSTOMER_CODELabel.Size = New System.Drawing.Size(75, 13)
        CUSTOMER_CODELabel.TabIndex = 4
        CUSTOMER_CODELabel.Text = "Fr. Customer : "
        '
        'FrCustomer
        '
        Me.FrCustomer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FrCustomer.DataSource = Me.MST_CUSTOMERBindingSource
        Me.FrCustomer.DisplayMember = "CUSTOMER_NAME"
        Me.FrCustomer.FormattingEnabled = True
        Me.FrCustomer.Location = New System.Drawing.Point(93, 35)
        Me.FrCustomer.Name = "FrCustomer"
        Me.FrCustomer.Size = New System.Drawing.Size(206, 21)
        Me.FrCustomer.TabIndex = 5
        Me.FrCustomer.ValueMember = "CUSTOMER_CODE"
        '
        'MST_CUSTOMERBindingSource1
        '
        Me.MST_CUSTOMERBindingSource1.DataMember = "MST_CUSTOMER"
        Me.MST_CUSTOMERBindingSource1.DataSource = Me.CSAccReporting
        '
        'Label1
        '
        Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(12, 63)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(79, 13)
        Label1.TabIndex = 6
        Label1.Text = "To. Customer : "
        '
        'ToCustomer
        '
        Me.ToCustomer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToCustomer.DataSource = Me.MST_CUSTOMERBindingSource1
        Me.ToCustomer.DisplayMember = "CUSTOMER_NAME"
        Me.ToCustomer.FormattingEnabled = True
        Me.ToCustomer.Location = New System.Drawing.Point(93, 60)
        Me.ToCustomer.Name = "ToCustomer"
        Me.ToCustomer.Size = New System.Drawing.Size(206, 21)
        Me.ToCustomer.TabIndex = 7
        Me.ToCustomer.ValueMember = "CUSTOMER_CODE"
        '
        'Label2
        '
        Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(25, 14)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(66, 13)
        Label2.TabIndex = 8
        Label2.Text = "As of Date : "
        '
        'AsOfDate
        '
        Me.AsOfDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AsOfDate.Location = New System.Drawing.Point(93, 12)
        Me.AsOfDate.Name = "AsOfDate"
        Me.AsOfDate.Size = New System.Drawing.Size(206, 20)
        Me.AsOfDate.TabIndex = 9
        '
        'FmCustomersAgeDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(306, 120)
        Me.Controls.Add(Me.AsOfDate)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.ToCustomer)
        Me.Controls.Add(CUSTOMER_CODELabel)
        Me.Controls.Add(Me.FrCustomer)
        Me.Name = "FmCustomersAgeDlg"
        Me.Text = "Customers Age"
        Me.Controls.SetChildIndex(Me.Cancel_Button, 0)
        Me.Controls.SetChildIndex(Me.OK_Button, 0)
        Me.Controls.SetChildIndex(Me.FrCustomer, 0)
        Me.Controls.SetChildIndex(CUSTOMER_CODELabel, 0)
        Me.Controls.SetChildIndex(Me.ToCustomer, 0)
        Me.Controls.SetChildIndex(Label1, 0)
        Me.Controls.SetChildIndex(Label2, 0)
        Me.Controls.SetChildIndex(Me.AsOfDate, 0)
        CType(Me.CSAccReporting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MST_CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MST_CUSTOMERBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CSAccReporting As CSAccountDatabaseIntf.CSAccReporting
    Friend WithEvents MST_CUSTOMERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FrCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents MST_CUSTOMERBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ToCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents AsOfDate As System.Windows.Forms.DateTimePicker

End Class
