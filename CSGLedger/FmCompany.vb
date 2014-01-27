Imports CSAccountDatabaseIntf
Imports System.Configuration
Imports System.Windows.Forms
Imports System.Threading
Public Class FmCompany

    Protected Overrides Sub CheckNvgButtons()
        MyBase.CheckNvgButtons()
        btnCloseYear.Enabled = Not NeedSave
    End Sub

    Public Overrides Sub DBControlsEnabled(ByVal InValue As Boolean)
        BrowseGrid.ReadOnly = Not InValue
        BrowseGrid.AllowUserToAddRows = InValue
        BrowseGrid.AllowUserToDeleteRows = InValue
        COMP_NAMETextBox.Enabled = InValue
        REG_CODETextBox.Enabled = InValue
        ACC_YEARNumericUpDown.Enabled = InValue
        CURR_CODEComboBox.Enabled = InValue
        ADDR1TextBox.Enabled = InValue
        ADDR2TextBox.Enabled = InValue
        ADDR3TextBox.Enabled = InValue
        ADDR4TextBox.Enabled = InValue
        PHONENOMaskedTextBox.Enabled = InValue
        FAXNOMaskedTextBox.Enabled = InValue
        ACC_APComboBox.Enabled = InValue
        ACC_APDISCComboBox.Enabled = InValue
        ACC_ARComboBox.Enabled = InValue
        ACC_ARDISCComboBox.Enabled = InValue
        ACC_SALESComboBox.Enabled = InValue
        START_MONTHNumericUpDown.Enabled = InValue
    End Sub

    Public Overrides Property SystemManager() As CSAccountDatabaseIntf.ICSAccountDatabaseIntf
        Get
            Return MyBase.SystemManager
        End Get
        Set(ByVal value As CSAccountDatabaseIntf.ICSAccountDatabaseIntf)
            MyBase.SystemManager = value
            Try
                SystemManager.LoadCSMasterDataset()
                CSMasterDataset = SystemManager.GetCSMasterDataset
                Dataset = CSMasterDataset
                MST_COMPANYBindingSource.DataSource = CSMasterDataset
                MSTCURRENCYBindingSource.DataSource = CSMasterDataset
                MSTACCOUNTBindingSource.DataSource = CSMasterDataset
                MSTAccountBindingSource1.DataSource = CSMasterDataset
                MSTAccountBindingSource2.DataSource = CSMasterDataset
                MSTAccountBindingSource3.DataSource = CSMasterDataset
                MSTACCOUNTBindingSource4.DataSource = CSMasterDataset

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
            m_KeyInfo.KeyNo = CInt(CType(MST_COMPANYBindingSource.Current, DataRowView)("COMPNO"))
            m_KeyInfo.KeyCode = ""
            Return MyBase.KeyInfo
        End Get
        Set(ByVal value As CSAccountDatabaseIntf.FormKeyInfo)
            MyBase.KeyInfo = value
        End Set
    End Property

    Public Overrides ReadOnly Property FirstControl() As System.Windows.Forms.Control
        Get
            Return COMP_NAMETextBox
        End Get
    End Property

    Private Sub FmCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BindDataSource(MST_COMPANYBindingSource)
    End Sub

    Private Sub FmCompany_BeforeNewAndEdit(ByVal Sender As System.Object, ByVal e As CSAccountDatabaseIntf.BeforeAfterEditNewEventAgrs) Handles MyBase.BeforeNewAndEdit
        If e.IsNew = False Then
            TabControl.SelectedIndex = 1
        Else
            If MSTCURRENCYBindingSource.Count = 0 Then
                MsgBox("No Currency exists !")
                e.Cancel = True
            End If

            If MSTACCOUNTBindingSource.Count = 0 Then
                MsgBox("No Liability Account exists !")
                e.Cancel = True
            End If

            If (MSTAccountBindingSource1.Count = 0) Or (MSTAccountBindingSource3.Count = 0) Then
                MsgBox("No Revenue / Expenses Account exists !")
                e.Cancel = True
            End If

            If MSTAccountBindingSource2.Count = 0 Then
                MsgBox("No Current Asset Account exists !")
                e.Cancel = True
            End If


            If (MSTACCOUNTBindingSource4.Count = 0) Then
                MsgBox("No Revenue / Sales Account exists !")
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub FmCompany_AfterNewAndEdit(ByVal Sender As System.Object, ByVal e As CSAccountDatabaseIntf.BeforeAfterEditNewEventAgrs) Handles MyBase.AfterNewAndEdit
        If SystemManager.CheckAPTranExists Then
            ACC_APComboBox.Enabled = False
            ACC_APDISCComboBox.Enabled = False
        End If

        If SystemManager.CheckARTranExists Then
            ACC_ARComboBox.Enabled = False
            ACC_ARDISCComboBox.Enabled = False
            ACC_SALESComboBox.Enabled = False
        End If

        If SystemManager.CheckAccHistoryExists Then
            START_MONTHNumericUpDown.Enabled = False
        End If
    End Sub

    Private Sub FmCompany_tsbtnSaveClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.tsbtnSaveClick
        MST_COMPANYBindingSource.EndEdit()
        SystemManager.SaveCSMasterDataset(CSMasterDataset)
        CSMasterDataset.MST_COMPANY.AcceptChanges()
    End Sub

    Private Sub FmCompany_tsbtnCancelClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.tsbtnCancelClick
        MST_COMPANYBindingSource.CancelEdit()
        CSMasterDataset.MST_COMPANY.RejectChanges()
    End Sub

    Private Sub MST_COMPANYBindingSource_AddingNew(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles MST_COMPANYBindingSource.AddingNew
        If CSMasterDataset.MST_COMPANY.Count = 0 Then
            Dim CurrRow As CSMasterDataset.MST_CURRENCYRow = CType(CType(MSTCURRENCYBindingSource.Current, DataRowView).Row, CSMasterDataset.MST_CURRENCYRow)
            Dim APRow As CSMasterDataset.MST_ACCOUNTRow = CType(CType(MSTACCOUNTBindingSource.Current, DataRowView).Row, CSMasterDataset.MST_ACCOUNTRow)
            Dim APDiscRow As CSMasterDataset.MST_ACCOUNTRow = CType(CType(MSTAccountBindingSource1.Current, DataRowView).Row, CSMasterDataset.MST_ACCOUNTRow)
            Dim ARRow As CSMasterDataset.MST_ACCOUNTRow = CType(CType(MSTAccountBindingSource2.Current, DataRowView).Row, CSMasterDataset.MST_ACCOUNTRow)
            Dim ARDiscRow As CSMasterDataset.MST_ACCOUNTRow = CType(CType(MSTAccountBindingSource3.Current, DataRowView).Row, CSMasterDataset.MST_ACCOUNTRow)
            Dim SLAccRow As CSMasterDataset.MST_ACCOUNTRow = CType(CType(MSTACCOUNTBindingSource4.Current, DataRowView).Row, CSMasterDataset.MST_ACCOUNTRow)

            Dim MyRow As DataRow = CSMasterDataset.MST_COMPANY.AddMST_COMPANYRow("", "", CShort(Today.Year), CurrRow, "", "", "", "", "", "", APRow, APDiscRow, ARRow, ARDiscRow, SLAccRow, 1)
            e.NewObject = MyRow
        End If
    End Sub

    Private Sub FmCompany_tsbtnNewClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.tsbtnNewClick
        ' Only 1 record for company setup
        If MST_COMPANYBindingSource.Count > 1 Then
            MST_COMPANYBindingSource.CancelEdit()
            COMP_NAMETextBox.SelectAll()
        End If
    End Sub

    Private Sub btnCurrency_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurrency.Click
        CallForm("CSGLedger.FmCurrency", "MST_CURRENCY")
        CURR_CODEComboBox.BindingContext = CURR_CODEComboBox.BindingContext
    End Sub


    Private Sub ResetAccountsControlValue()
        ACC_APComboBox.BindingContext = ACC_APComboBox.BindingContext
        ACC_APDISCComboBox.BindingContext = ACC_APDISCComboBox.BindingContext
        ACC_ARComboBox.BindingContext = ACC_ARComboBox.BindingContext
        ACC_ARDISCComboBox.BindingContext = ACC_ARDISCComboBox.BindingContext
        ACC_SALESComboBox.BindingContext = ACC_SALESComboBox.BindingContext
    End Sub

    Private Sub CreateAccountClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnARDisc.Click, btnAR.Click, btnAPDisc.Click, btnAP.Click
        CallForm("CSGLedger.FmAccount", "MST_ACCOUNT")
        ResetAccountsControlValue()
    End Sub

    Private Sub FmCompany_BeforeDelete(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.BeforeDelete
        If SystemManager.CheckAPTranExists Then
            MsgBox("Record cannot be delete if transaction exists !")
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub FmCompany_BeforesbtnSaveclick(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.BeforesbtnSaveclick
        Dim ErrMsg As String = ""

        If CSMasterDataset.MST_CURRENCY.Count = 0 Then
            ErrMsg = "Currency"
        End If

        If MSTACCOUNTBindingSource.Count = 0 Then
            If ErrMsg = "" Then
                ErrMsg = "Account Payable"
            Else
                ErrMsg = ErrMsg + ", Account Payable"
            End If
        End If

        If MSTAccountBindingSource1.Count = 0 Then
            If ErrMsg = "" Then
                ErrMsg = "AP Discount"
            Else
                ErrMsg = ErrMsg + ", AP Discount"
            End If
        End If

        If MSTAccountBindingSource2.Count = 0 Then
            If ErrMsg = "" Then
                ErrMsg = "Account Receivable"
            Else
                ErrMsg = ErrMsg + ", Account Receivable"
            End If
        End If

        If MSTAccountBindingSource3.Count = 0 Then
            If ErrMsg = "" Then
                ErrMsg = "AR Discount"
            Else
                ErrMsg = ErrMsg + ", ARDiscount"
            End If
        End If

        If MSTACCOUNTBindingSource4.Count = 0 Then
            If ErrMsg = "" Then
                ErrMsg = "Sales Account"
            Else
                ErrMsg = ErrMsg + ", Sales Account"
            End If
        End If

        If ErrMsg <> "" Then
            e.Cancel = True
            MsgBox("Please create " + ErrMsg + " First !")
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub btnSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSales.Click
        CallForm("CSGLedger.FmAccount", "MST_ACCOUNT")
    End Sub

    Private Sub btnCloseYear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseYear.Click
        Dim RetainAcc() As DataRow = CSMasterDataset.MST_ACCOUNT.Select("RETAINED_EARNINGS=1")
        If RetainAcc.Length = 0 Then
            MsgBox("Must setup Retained Earnings Account before Closing Year !")
        Else
            If MessageBox.Show("After closing, all transaction for current year will not be able to modify, continue ?", _
            "Confirm Closing", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, _
            MessageBoxOptions.DefaultDesktopOnly, False) = DialogResult.OK Then
                Dim MsgForm As FmCloseYearWaitDlg = New FmCloseYearWaitDlg
                MsgForm.Show()
                MsgForm.Update()
                Update()
                SystemManager.CloseYear()
                SystemManager.LoadCSMasterDataset_Company()
                CSMasterDataset.MST_COMPANY.Clear()
                CSMasterDataset.MST_COMPANY.Merge(SystemManager.GetCSMasterDataset.MST_COMPANY)
                MsgForm.Close()
                MsgForm.Dispose()
            End If
        End If
    End Sub

    Private Sub COMP_NAMETextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles COMP_NAMETextBox.Validating
        e.Cancel = Not ValidateLength(COMP_NAMETextBox, True)
    End Sub

    Private Sub REG_CODETextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles REG_CODETextBox.Validating
        e.Cancel = Not ValidateLength(REG_CODETextBox, False)
    End Sub

    Private Sub ADDR1TextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ADDR1TextBox.Validating
        e.Cancel = Not ValidateLength(ADDR1TextBox, False)
    End Sub

    Private Sub ADDR2TextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ADDR2TextBox.Validating
        e.Cancel = Not ValidateLength(ADDR2TextBox, False)
    End Sub

    Private Sub ADDR3TextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ADDR3TextBox.Validating
        e.Cancel = Not ValidateLength(ADDR3TextBox, False)
    End Sub

    Private Sub ADDR4TextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ADDR4TextBox.Validating
        e.Cancel = Not ValidateLength(ADDR4TextBox, False)
    End Sub
End Class
