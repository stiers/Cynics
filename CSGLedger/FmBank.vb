Imports CSAccountDatabaseIntf
Public Class FmBank
    Public Overrides Sub DBControlsEnabled(ByVal InValue As Boolean)
        BrowseGrid.ReadOnly = Not InValue
        BrowseGrid.AllowUserToAddRows = InValue
        BrowseGrid.AllowUserToDeleteRows = InValue
        BANK_CODETextBox.Enabled = InValue
        BANK_NAMETextBox.Enabled = InValue
        ACC_CODEComboBox.Enabled = InValue
    End Sub

    Public Overrides Property SystemManager() As CSAccountDatabaseIntf.ICSAccountDatabaseIntf
        Get
            Return MyBase.SystemManager
        End Get
        Set(ByVal value As CSAccountDatabaseIntf.ICSAccountDatabaseIntf)
            MyBase.SystemManager = value
            Try
                SystemManager.LoadCSBankMasterDataset()
                CSMasterDataset = SystemManager.GetCSMasterDataset
                Dataset = CSMasterDataset
                MSTACCOUNTBindingSource.DataSource = CSMasterDataset
                MST_BANKBindingSource.DataSource = CSMasterDataset

            Catch ex As Exception
                If TypeOf ex Is System.Net.Sockets.SocketException Then
                    MsgBox("Server inactive or no network connection !")
                    Exit Property
                End If
                Throw ex
            End Try
        End Set
    End Property

    Public Overrides Property KeyInfo() As CSAccountDatabaseIntf.FormKeyInfo
        Get
            m_KeyInfo.KeyNo = CInt(CType(MST_BANKBindingSource.Current, DataRowView)("BANKNO"))
            m_KeyInfo.KeyCode = CStr(CType(MST_BANKBindingSource.Current, DataRowView)("BANK_CODE"))
            Return MyBase.KeyInfo
        End Get
        Set(ByVal value As CSAccountDatabaseIntf.FormKeyInfo)
            MyBase.KeyInfo = value
        End Set
    End Property

    Public Overrides ReadOnly Property FirstControl() As System.Windows.Forms.Control
        Get
            If BANK_CODETextBox.Enabled Then
                Return BANK_CODETextBox
            Else
                Return BANK_NAMETextBox
            End If
        End Get
    End Property

    Private Sub FmBank_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BindDataSource(MST_BANKBindingSource)
    End Sub

    Private Sub FmBank_AfterNewAndEdit(ByVal Sender As System.Object, ByVal e As CSAccountDatabaseIntf.BeforeAfterEditNewEventAgrs) Handles MyBase.AfterNewAndEdit
        If e.IsNew = False Then
            If MST_BANKBindingSource.Count > 0 Then
                If SystemManager.CheckAPBankDetailExists(CInt(CType(MST_BANKBindingSource.Current, DataRowView)("BANKNO"))) Then
                    ACC_CODEComboBox.Enabled = False
                    BANK_CODETextBox.Enabled = False
                Else
                    If SystemManager.CheckARBankDetailExists(CInt(CType(MST_BANKBindingSource.Current, DataRowView)("BANKNO"))) Then
                        ACC_CODEComboBox.Enabled = False
                        BANK_CODETextBox.Enabled = False
                    End If
                End If
                End If
        End If
    End Sub

    Private Sub FmBank_tsbtnSaveClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.tsbtnSaveClick
        MST_BANKBindingSource.EndEdit()
        SystemManager.SaveCSBankMasterDataset(CSMasterDataset)
        CSMasterDataset.MST_BANK.AcceptChanges()
    End Sub

    Private Sub FmBank_tsbtnCancelClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.tsbtnCancelClick
        MST_BANKBindingSource.CancelEdit()
        CSMasterDataset.MST_BANK.RejectChanges()
    End Sub

    Private Sub btnAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccount.Click
        CallForm("CSGLedger.FmAccount", "MST_ACCOUNT")
        ACC_CODEComboBox.BindingContext = ACC_CODEComboBox.BindingContext
    End Sub

    Private Sub MST_BANKBindingSource_AddingNew(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles MST_BANKBindingSource.AddingNew
        Dim MyRow As CSMasterDataset.MST_BANKRow = CSMasterDataset.MST_BANK.NewMST_BANKRow
        MyRow("BANKNO") = SystemManager.GetKey("BANKNO")
        MyRow("BANK_CODE") = ""
        MyRow("BANK_NAME") = ""
        MyRow("ACC_CODE") = CType(MSTACCOUNTBindingSource.Current, DataRowView)("ACC_CODE")
        e.NewObject = MyRow
        CSMasterDataset.MST_BANK.AddMST_BANKRow(MyRow)
        MST_BANKBindingSource.Position = MST_BANKBindingSource.Count
    End Sub

    Private Sub FmBank_BeforeNewAndEdit(ByVal Sender As System.Object, ByVal e As CSAccountDatabaseIntf.BeforeAfterEditNewEventAgrs) Handles MyBase.BeforeNewAndEdit
        e.Cancel = False
        If e.IsNew = True Then
            If MSTACCOUNTBindingSource.Count = 0 Then
                MsgBox("No Account exists !")
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub BANK_CODETextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles BANK_CODETextBox.Validating
        If CheckSkipValidate() Then
            Exit Sub
        End If

        If BANK_CODETextBox.Text = "" Then
            SetFormError(BANK_CODETextBox, "Bank# required !")
            e.Cancel = True
        Else
            e.Cancel = Not ValidateLength(BANK_CODETextBox, True)
            If e.Cancel = False Then
                Dim BankCode As String = BANK_CODETextBox.Text
                BankCode = BankCode.Replace("'", "''")
                Dim MyRow() As DataRow = CSMasterDataset.MST_BANK.Select("BANK_CODE='" + BankCode + "'")
                If MyRow.Length > 0 Then
                    If CInt(MyRow(0)("BANKNO")) <> CInt(CType(MST_BANKBindingSource.Current, DataRowView)("BANKNO")) Then
                        SetFormError(BANK_CODETextBox, "Bank# must be unique !")
                        e.Cancel = True
                    Else
                        e.Cancel = False
                    End If
                Else
                    SetFormError(BANK_CODETextBox, "")
                    e.Cancel = False
                End If
            End If
        End If
    End Sub

    Private Sub FmBank_BeforeDelete(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.BeforeDelete
        e.Cancel = False
        If MST_BANKBindingSource.Count > 0 Then
            If SystemManager.CheckAPBankDetailExists(CInt(CType(MST_BANKBindingSource.Current, DataRowView)("BANKNO"))) Then
                MsgBox("Cannot delete bank record if transaction exists !")
                e.Cancel = True
            Else
                If SystemManager.CheckARBankDetailExists(CInt(CType(MST_BANKBindingSource.Current, DataRowView)("BANKNO"))) Then
                    MsgBox("Cannot delete bank record if transaction exists !")
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub BANK_NAMETextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles BANK_NAMETextBox.Validating
        e.Cancel = Not ValidateLength(BANK_NAMETextBox, True)
    End Sub
End Class
