Imports System.Data
Imports CSCommon
Imports System.Windows.forms
Imports CSAccountDatabaseIntf
Imports System.Drawing
Public Class FmSecurity
    Inherits StdDBTabForm

    Private MyCrypto As CSSimpleCrypto = New CSSimpleCrypto

    Public Overrides Sub DBControlsEnabled(ByVal InValue As Boolean)
        Select Case TabControl.SelectedIndex
            Case 0
                USERIDTextBox.Enabled = InValue
                ROLENOComboBox.Enabled = InValue
                PasswordTextBox.Enabled = InValue
                UserInfoView.ReadOnly = Not InValue
                UserInfoView.AllowUserToAddRows = InValue
                UserInfoView.AllowUserToDeleteRows = InValue
            Case 1
                MST_ROLESDataGridView.ReadOnly = Not InValue
                MST_ROLESDataGridView.AllowUserToAddRows = InValue
                MST_ROLESDataGridView.AllowUserToDeleteRows = InValue
                MST_ROLEFORMDataGridView.ReadOnly = Not InValue
                MST_ROLEFORMDataGridView.AllowUserToAddRows = InValue
                MST_ROLEFORMDataGridView.AllowUserToDeleteRows = InValue
                ContextMenuStrip1.Enabled = InValue
        End Select
    End Sub

    Public Overrides Property SystemManager() As CSAccountDatabaseIntf.ICSAccountDatabaseIntf
        Get
            Return MyBase.SystemManager
        End Get
        Set(ByVal value As CSAccountDatabaseIntf.ICSAccountDatabaseIntf)
            MyBase.SystemManager = value
            Try
                SystemManager.LoadCSSystemDBDataset()
                CSSystemDBDataset = SystemManager.GetCSSystemDBDataset()
                Dataset = CSSystemDBDataset
                MSTUSERBindingSource.DataSource = CSSystemDBDataset
                MSTFORMSBindingSource.DataSource = CSSystemDBDataset
                MSTROLESBindingSource.DataSource = CSSystemDBDataset
                MST_ROLEFORMDataGridView.DataSource = MST_ROLEFORMBindingSource
            Catch ex As Exception
                If TypeOf ex Is System.Net.Sockets.SocketException Then
                    MsgBox("Server inactive or no network connection !")
                    Exit Property
                End If
                Throw ex
            End Try
        End Set
    End Property

    Private Sub UpdatePasswd()
        Dim MyRowView As DataRowView = CType(MSTUSERBindingSource.Current, DataRowView)
        If MyRowView IsNot Nothing Then
            If MyRowView("PASSWD") IsNot DBNull.Value Then
                Dim DecryptPass As String = MyCrypto.Decrypt(CType(MyRowView("PASSWD"), Byte()))
                If DecryptPass <> PasswordTextBox.Text Then
                    MyRowView.BeginEdit()
                    MyRowView("PASSWD") = MyCrypto.Encrypt(PasswordTextBox.Text)
                    MyRowView.EndEdit()
                End If
            End If
        End If
    End Sub

    Private Sub MSTUSERBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSTUSERBindingSource.PositionChanged
        If CType(MSTUSERBindingSource.Current, DataRowView)("PASSWD") IsNot DBNull.Value Then
            PasswordTextBox.Text = MyCrypto.Decrypt(CType(CType(MSTUSERBindingSource.Current, DataRowView)("PASSWD"), Byte()))
        Else
            PasswordTextBox.Text = ""
        End If
    End Sub

    Private Sub FmSecurity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BindDataSource(MSTUSERBindingSource)
    End Sub


    Private Sub PasswordTextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordTextBox.Leave
        UpdatePasswd()
    End Sub

    Private Sub MST_ROLEFORMDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles MST_ROLEFORMDataGridView.DataError
        HandleGridError(sender, e)
    End Sub

    Private Sub TabControl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl.SelectedIndexChanged
        Select Case TabControl.SelectedIndex
            Case 0
                BindDataSource(MSTUSERBindingSource)
            Case 1
                BindDataSource(MSTROLESBindingSource)
        End Select
    End Sub


    Private Sub UserInfoView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles UserInfoView.DataError
        HandleGridError(sender, e)
    End Sub

    Private Sub AddItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddItemToolStripMenuItem.Click
        If MST_ROLEFORMBindingSource.Current IsNot Nothing Then
            CType(MST_ROLEFORMBindingSource.Current, DataRowView).CancelEdit()
        End If
        For Each MyRow As DataRow In CSSystemDBDataset.MST_FORMS.Rows
            If CType(MSTROLESBindingSource.Current, DataRowView)("ROLENO") IsNot DBNull.Value Then
                If CSSystemDBDataset.MST_ROLEFORM.FindByROLENOFORMNO(CType(CType(MSTROLESBindingSource.Current, DataRowView)("ROLENO"), Integer), CType(MyRow("FORMNO"), Integer)) Is Nothing Then
                    Dim NewRow As DataRowView = CType(MST_ROLEFORMBindingSource.AddNew(), DataRowView)
                    NewRow("FORMNO") = MyRow("FORMNO")
                    NewRow.EndEdit()
                End If
            End If
        Next
    End Sub

    Private Sub FmSecurity_AfterNewAndEdit(ByVal Sender As System.Object, ByVal e As CSAccountDatabaseIntf.BeforeAfterEditNewEventAgrs) Handles MyBase.AfterNewAndEdit
        Select Case TabControl.SelectedIndex
            Case 0
                UserInfoView.ReadOnly = True
                USERIDTextBox.Select()
            Case 1
                If e.IsNew Then
                    MST_ROLESDataGridView.Select()
                Else
                    MST_ROLEFORMDataGridView.Select()
                End If
        End Select
    End Sub

    Private Sub FmSecurity_tsbtnSaveClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.tsbtnSaveClick
        Select Case TabControl.SelectedIndex
            Case 0
                Try
                    Dim MyRowView As DataRowView = CType(MSTUSERBindingSource.Current, DataRowView)
                    If MyRowView IsNot Nothing Then
                        MyRowView.BeginEdit()
                        MyRowView("PASSWD") = MyCrypto.Encrypt(PasswordTextBox.Text)
                        MyRowView.EndEdit()
                    End If

                    SystemManager.SaveSecurityUserInfo(CSSystemDBDataset)
                    CSSystemDBDataset.MST_USER.AcceptChanges()
                Catch Ex As Exception
                    MsgBox(Ex.Message)
                End Try
            Case 1
                Try
                    SystemManager.SaveSecurityRoleInfo(CSSystemDBDataset)
                    CSSystemDBDataset.MST_ROLES.AcceptChanges()
                    CSSystemDBDataset.MST_ROLEFORM.AcceptChanges()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
        End Select
        ContextMenuStrip1.Enabled = False
    End Sub

    Private Sub FmSecurity_tsbtnCancelClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.tsbtnCancelClick
        If MessageBox.Show("Confirm cancel all changes ?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Select Case TabControl.SelectedIndex
                Case 0
                    MSTUSERBindingSource.CancelEdit()
                    CSSystemDBDataset.MST_USER.RejectChanges()
                Case 1
                    MSTROLESBindingSource.CancelEdit()
                    MST_ROLEFORMBindingSource.CancelEdit()
                    CSSystemDBDataset.MST_ROLES.RejectChanges()
                    CSSystemDBDataset.MST_ROLEFORM.RejectChanges()
            End Select
            NeedSave = False
        Else
            NeedSave = True
        End If
		ContextMenuStrip1.Enabled = False
    End Sub

    Private Sub FmSecurity_BeforeDelete(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.BeforeDelete
        Dim MyData As DataRowView = CType(MSTROLESBindingSource.Current, DataRowView)
        If CInt(MyData("ROLENO")) = 1 Then
            MsgBox("Cannot delete Default ADMIN Group !")
            e.Cancel = True
        End If
    End Sub

    Private Sub FmSecurity_tsbtnEditClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.tsbtnEditClick
        ContextMenuStrip1.Enabled = True
    End Sub

    Private Sub PasswordTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles PasswordTextBox.Validating
        If PasswordTextBox.Text = "" Then
            SetFormError(PasswordTextBox, "Password required !")
            e.Cancel = True
        Else
            If PasswordTextBox.Text.Length > 10 Then
                SetFormError(PasswordTextBox, "Password maximum Length is 10 digits !")
            Else
                SetFormError(PasswordTextBox, "")
                e.Cancel = False
            End If
        End If
    End Sub

    Private Sub FmSecurity_BeforesbtnSaveclick(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.BeforesbtnSaveclick
        If TabControl.SelectedIndex = 0 Then
            Dim CurrRow As DataRowView = CType(MSTUSERBindingSource.Current, DataRowView)
            If (PasswordTextBox.Text = "") Then
                MsgBox("Password required !")
                PasswordTextBox.Select()
                e.Cancel = True
            End If
        ElseIf TabControl.SelectedIndex = 1 Then
            Dim AddedRoleRows() As DataRow = CSSystemDBDataset.MST_ROLES.Select("", "", DataViewRowState.Added)
            Dim EditedRoleRows() As DataRow = CSSystemDBDataset.MST_ROLES.Select("", "", DataViewRowState.ModifiedCurrent)
            Dim RoleRow As DataRow

            Dim PromptNoDetails As Boolean = False
            For Each RoleRow In AddedRoleRows
                Dim detailRows() As DataRow = CSSystemDBDataset.MST_ROLEFORM.Select("ROLENO='" + CStr(RoleRow("ROLENO")) + "'")
                If detailRows.Length = 0 Then
                    PromptNoDetails = True
                End If
            Next
            For Each RoleRow In EditedRoleRows
                Dim detailRows() As DataRow = CSSystemDBDataset.MST_ROLEFORM.Select("ROLENO='" + CStr(RoleRow("ROLENO")) + "'")
                If detailRows.Length = 0 Then
                    PromptNoDetails = True
                End If
            Next

            If PromptNoDetails Then
                MsgBox("You have at least one role with no forms added !")
                e.Cancel = True
                Exit Sub
            End If

            Dim deletedRows() As DataRow = CSSystemDBDataset.MST_ROLEFORM.Select("", "", DataViewRowState.Deleted)
            Dim AddedRows() As DataRow = CSSystemDBDataset.MST_ROLEFORM.Select("", "", DataViewRowState.Added)
            Dim EditedRows() As DataRow = CSSystemDBDataset.MST_ROLEFORM.Select("", "", DataViewRowState.ModifiedCurrent)
            If (deletedRows.Length > 0) Or (AddedRows.Length > 0) Or (EditedRows.Length > 0) Then
                MsgBox("Please remember to restart for security setup to take effect !")
            End If
        End If
    End Sub

    Private NeedPromptRestart As Boolean = False
    Private Sub MST_ROLEFORMDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MST_ROLEFORMDataGridView.CellContentClick
        Select Case e.ColumnIndex
            Case 1 To 4
        End Select
    End Sub


    Private Sub MST_ROLESDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles MST_ROLESDataGridView.DataError
        HandleGridError(sender, e)
    End Sub

    Private Sub USERIDTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles USERIDTextBox.Validating
        e.Cancel = Not ValidateLength(USERIDTextBox, True)
    End Sub
End Class
