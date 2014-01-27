Imports CSAccountDatabaseIntf.CSGLDataset
Imports CSCommon
Imports System.Windows.Forms
Public Class FmGL
    Public Overrides Sub DBControlsEnabled(ByVal InValue As Boolean)
        BrowseGrid.ReadOnly = Not InValue
        BrowseGrid.AllowUserToAddRows = InValue
        BrowseGrid.AllowUserToDeleteRows = InValue
        TRN_GNLJNLDDataGridView.ReadOnly = Not InValue
        TRN_GNLJNLDDataGridView.AllowUserToAddRows = InValue
        TRN_GNLJNLDDataGridView.AllowUserToDeleteRows = InValue
        GNLJNLNOTextBox.Enabled = False
        JNL_DESCTextBox.Enabled = InValue
        JNL_DATEDateTimePicker.Enabled = InValue
        JNL_AMTTextBox.Enabled = InValue
        ACC_PERIODNumericUpDown.Enabled = InValue
        CURR_CODEComboBox.Enabled = InValue
        JNL_CODETextBox.Enabled = InValue
    End Sub

    Public Overrides Property SystemManager() As CSAccountDatabaseIntf.ICSAccountDatabaseIntf
        Get
            Return MyBase.SystemManager
        End Get
        Set(ByVal value As CSAccountDatabaseIntf.ICSAccountDatabaseIntf)
            MyBase.SystemManager = value
            Try
                SystemManager.LoadCSGLTranDataset(SystemInfo.StartDate, SystemInfo.EndDate)
                CSGLDataset = SystemManager.GetCSGLDataset
                Dataset = CSGLDataset
                TRN_GNLJNLBindingSource.DataSource = CSGLDataset
                MST_ACCOUNTBindingSource.DataSource = CSGLDataset
                MSTCURRENCYBindingSource.DataSource = CSGLDataset
            Catch ex As Exception
                If TypeOf ex Is System.Net.Sockets.SocketException Then
                    MsgBox("Server inactive or no network connection !")
                    Exit Property
                End If
                Throw ex
            End Try
        End Set
    End Property

    Public Overrides ReadOnly Property FirstControl() As System.Windows.Forms.Control
        Get
            Return JNL_CODETextBox
        End Get
    End Property

    Private Sub FmAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BindDataSource(TRN_GNLJNLBindingSource)
    End Sub

    Private Sub FmAccount_BeforeNewAndEdit(ByVal Sender As System.Object, ByVal e As CSAccountDatabaseIntf.BeforeAfterEditNewEventAgrs) Handles MyBase.BeforeNewAndEdit
        e.Cancel = False
        If e.IsNew = False Then
            TabControl.SelectedIndex = 1
            If SystemInfo.BusinessPeriod.AccYear <> CInt(ACC_YEARNumericUpDown.Value) Then
                MsgBox("Cannot edit closed transactions !")
                e.Cancel = True
            End If
        Else
            If CSGLDataset.MST_CURRENCY.Count = 0 Then
                MsgBox("No Currency exists !")
                e.Cancel = True
            End If

            If CSGLDataset.MST_ACCOUNT.Count = 0 Then
                MsgBox("No Account exists !")
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub FmAccount_tsbtnSaveClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.tsbtnSaveClick
        If TRN_GNLJNLBindingSource.Current IsNot Nothing Then
            Dim TempDataRow As TRN_GNLJNLRow = _
            CType(CType(TRN_GNLJNLBindingSource.Current, DataRowView).Row, TRN_GNLJNLRow)
            If CSGLDataset.TRN_GNLJNLD.Rows.Count > 0 Then
                If TempDataRow.IsTOTAL_DEBITNull Then
                    TRN_GNLJNLDBindingSource.EndEdit()
                    TRN_GNLJNLBindingSource.EndEdit()
                End If

                If TempDataRow.TOTAL_DEBIT <> TempDataRow.TOTAL_CREDIT Then
                    Dim Ex As Exception = New Exception("Account not balance !")
                    Throw Ex
                End If
                If TempDataRow.JNL_AMT <> TempDataRow.TOTAL_DEBIT Then
                    TempDataRow.JNL_AMT = TempDataRow.TOTAL_DEBIT
                End If
                SystemManager.SaveCSGLTranDataset(CSGLDataset)
                CSGLDataset.TRN_GNLJNL.AcceptChanges()
                CSGLDataset.TRN_GNLJNLD.AcceptChanges()
            End If
        ElseIf CSGLDataset.TRN_GNLJNL.Select("", "", DataViewRowState.Deleted) IsNot Nothing Then
            SystemManager.SaveCSGLTranDataset(CSGLDataset)
            CSGLDataset.TRN_GNLJNL.AcceptChanges()
            CSGLDataset.TRN_GNLJNLD.AcceptChanges()
        End If

    End Sub

    Private Sub FmAccount_tsbtnCancelClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.tsbtnCancelClick
        TRN_GNLJNLBindingSource.CancelEdit()
        TRN_GNLJNLDBindingSource.CancelEdit()
        CSGLDataset.TRN_GNLJNL.RejectChanges()
        CSGLDataset.TRN_GNLJNLD.RejectChanges()
    End Sub

    Private Sub TRN_GNLJNLBindingSource_AddingNew(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles TRN_GNLJNLBindingSource.AddingNew
        Dim CurrCode As MST_CURRENCYRow
        Dim MyCurrRow As DataRow() = CSGLDataset.MST_CURRENCY.Select("CURR_RATE = 1")
        If MyCurrRow.Length = 0 Then
            MsgBox("Please setup domestic currency first !")
            Exit Sub
        Else
            CurrCode = CType(MyCurrRow(0), MST_CURRENCYRow)
        End If
        Dim MyDataRow As DataRow = CSGLDataset.TRN_GNLJNL.AddTRN_GNLJNLRow(SystemManager.GetKey("GNLJNLNO"), "", SystemInfo.BusinessDate, 0, _
            SystemInfo.BusinessPeriod.AccYear, CByte(SystemInfo.BusinessPeriod.AccPeriod), CurrCode, 1, 0, 0, 0, "")
        e.NewObject = MyDataRow
        TRN_GNLJNLBindingSource.Position = TRN_GNLJNLBindingSource.Count
    End Sub

    Private Sub TRN_GNLJNLDDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles TRN_GNLJNLDDataGridView.DataError
        HandleGridError(sender, e)
    End Sub

    Private Sub TRN_GNLJNLDDataGridView_CellValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles TRN_GNLJNLDDataGridView.CellValidating
        Select Case e.ColumnIndex
            Case 1, 3
                Dim AccRow As DataRow = Nothing

                If e.ColumnIndex = 1 Then
                    AccRow = CSGLDataset.MST_ACCOUNT.FindByACC_CODE(e.FormattedValue.ToString)
                Else
                    Dim AccRows() As DataRow
                    Dim AccName As String = e.FormattedValue.ToString
                    AccName = AccName.Replace("'", "''")
                    AccRows = CSGLDataset.MST_ACCOUNT.Select("ACC_NAME='" + ACCName + "'")
                    If AccRows.Length > 0 Then
                        AccRow = AccRows(0)
                    End If
                End If

                If AccRow IsNot Nothing Then
                    If CBool(AccRow("IS_ACTIVE")) = False Then
                        MsgBox("Account is not active !")
                        e.Cancel = True
                    End If
                Else
                    MsgBox("Incorrect Acc# !")
                    e.Cancel = True
                End If
        End Select
    End Sub

    Private Sub JNL_DATEDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JNL_DATEDateTimePicker.ValueChanged
        Dim TempPeriod As AccPeriodDef = SystemInfo.GetAccPeriod(CType(sender, DateTimePicker).Value)
        If TempPeriod.AccYear <> 0 Then
            ACC_YEARNumericUpDown.Value = TempPeriod.AccYear
            ACC_PERIODNumericUpDown.Value = TempPeriod.AccPeriod
        End If
    End Sub

    Private Sub TRN_GNLJNLDBindingSource_AddingNew(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles TRN_GNLJNLDBindingSource.AddingNew
        TRN_GNLJNLBindingSource.EndEdit()
        Dim NewData As CSAccountDatabaseIntf.CSGLDataset.TRN_GNLJNLDRow = _
        CSGLDataset.TRN_GNLJNLD.NewTRN_GNLJNLDRow
        NewData("GNLJNLDNO") = SystemManager.GetKey("GNLJNLDNO")
        NewData("GNLJNLNO") = CType(TRN_GNLJNLBindingSource.Current, DataRowView)("GNLJNLNO")
        NewData("ACC_CODE") = CType(MST_ACCOUNTBindingSource.Current, DataRowView)("ACC_CODE")
        If CType(TRN_GNLJNLBindingSource.Current, DataRowView).Row.IsNull("TOTAL_DEBIT") = False Then
            NewData("ACC_AMT") = CDec(CType(TRN_GNLJNLBindingSource.Current, DataRowView)("TOTAL_DIFF"))
        Else
            NewData("ACC_AMT") = 0
        End If
        CSGLDataset.TRN_GNLJNLD.AddTRN_GNLJNLDRow(NewData)
        e.NewObject = NewData
        TRN_GNLJNLDBindingSource.Position = TRN_GNLJNLDBindingSource.Count
        SendKeys.Send("{HOME}")
    End Sub

    Private Sub TRN_GNLJNLDDataGridView_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles TRN_GNLJNLDDataGridView.EditingControlShowing
        'Force grid view control for acc# to be uppercase all the time
        ForceUpperGridColumnTextbox(CType(sender, DataGridView), e, "ACC_CODE")
        If TypeOf e.Control Is TextBox Then
            Dim mytextbox As TextBox = CType(e.Control, TextBox)
            RemoveHandler mytextbox.PreviewKeyDown, AddressOf TRN_GNLJNLDDataGridView_PreviewKeyDown
            'Must remove previous handler before adding, because controlshowing event might occurs multiple times result in multiple call to keydown
            RemoveHandler mytextbox.KeyDown, AddressOf TRN_GNLJNLDDataGridView_KeyDown
            RemoveHandler mytextbox.KeyPress, AddressOf TRN_GNLJNLDDataGridView_KeyPress

            AddHandler mytextbox.PreviewKeyDown, AddressOf TRN_GNLJNLDDataGridView_PreviewKeyDown
            AddHandler mytextbox.KeyDown, AddressOf TRN_GNLJNLDDataGridView_KeyDown
            AddHandler mytextbox.KeyPress, AddressOf TRN_GNLJNLDDataGridView_KeyPress
        End If
    End Sub

    Private Sub CURR_CODEComboBox_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CURR_CODEComboBox.Validated
        If CheckSkipValidate() Then
            Exit Sub
        End If

        Dim MyRow As DataRowView = CType(TRN_GNLJNLBindingSource.Current, DataRowView)
        If MyRow IsNot Nothing Then
            Dim CurrRow As DataRowView = CType(MSTCURRENCYBindingSource.Current, DataRowView)
            MyRow.BeginEdit()
            MyRow("CURR_RATE") = CurrRow("CURR_RATE")
            MyRow.EndEdit()
        End If
    End Sub

    Private Sub TRN_GNLJNLDDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TRN_GNLJNLDDataGridView.CellContentClick
        If TRN_GNLJNLDDataGridView.Columns(e.ColumnIndex).Name = "AccButtonColumn" Then
            CallForm("CSGLedger.FmAccount", "MST_ACCOUNT")

            'Bellow Code is the same as CallForm
            'Dim MyAccount As FmAccount = New FmAccount
            'MyAccount.SystemInfo = SystemInfo
            'Dim MyInfo As FormCreateInfoDef = GetFormSecurityInfo("CSGLedger.FmAccount")
            'MyAccount.AllowAdd = MyInfo.AllowAdd
            'MyAccount.AllowEdit = MyInfo.AllowEdit
            'MyAccount.AllowDel = MyInfo.AllowDel
            'MyAccount.AllowPrint = MyInfo.AllowPrint
            'MyAccount.Text = MyInfo.Description
            'MyAccount.SystemManager = SystemManager
            'MyAccount.FormsSecurityInfo = FormsSecurityInfo
            'MyAccount.CallAfterFormInit()
            'MyAccount.ShowDialog()
            'CSGLDataset.MST_ACCOUNT.Clear()
            'CSGLDataset.MST_ACCOUNT.Merge(MyAccount.CSGLDataset.MST_ACCOUNT)
            'MyAccount = Nothing
        End If
    End Sub

    Private Sub btnCurrency_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurrency.Click
        CallForm("CSGLedger.FmCurrency", "MST_CURRENCY")
        CURR_CODEComboBox.BindingContext = CURR_CODEComboBox.BindingContext
    End Sub

    Private Sub FmGL_AfterNewAndEdit(ByVal Sender As System.Object, ByVal e As CSAccountDatabaseIntf.BeforeAfterEditNewEventAgrs) Handles MyBase.AfterNewAndEdit
        ACC_CREDIT.ReadOnly = True
        ACC_DEBIT.ReadOnly = True
        ACC_NAME.ReadOnly = True
    End Sub

    Private Sub GNLJNLNOTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GNLJNLNOTextBox.Validating
        If CheckSkipValidate() Then
            Exit Sub
        End If

        e.Cancel = Not ValidateLength(GNLJNLNOTextBox, True)
    End Sub

    Private Sub JNL_CODETextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles JNL_CODETextBox.Validating
        If CheckSkipValidate() Then
            Exit Sub
        End If

        e.Cancel = Not ValidateLength(JNL_CODETextBox, False)
    End Sub

    Private Sub JNL_DESCTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles JNL_DESCTextBox.Validating
        If CheckSkipValidate() Then
            Exit Sub
        End If

        e.Cancel = Not ValidateLength(JNL_DESCTextBox, False)
    End Sub

    Private Sub TRN_GNLJNLDDataGridView_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs)
        If e.KeyCode = Keys.Space Then
			If TRN_GNLJNLDDataGridView.Columns(TRN_GNLJNLDDataGridView.SelectedCells(0).ColumnIndex).DataPropertyName = "ACC_CODE" Then
				e.IsInputKey = True
			End If
		End If
    End Sub

    Private Sub TRN_GNLJNLDDataGridView_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If TRN_GNLJNLDDataGridView.SelectedCells.Count > 0 Then
            If TRN_GNLJNLDDataGridView.Columns(TRN_GNLJNLDDataGridView.SelectedCells(0).ColumnIndex).DataPropertyName = "ACC_CODE" Then
                If e.KeyCode = Keys.Space Then
                    Dim MyTextBox As TextBox = CType(sender, TextBox)
                    Dim MyDlg As FmAccountDlg = New FmAccountDlg
                    MyDlg.CSAccountDataset.SYS_ACCTYPE.Merge(CSGLDataset.SYS_ACCTYPE)
                    MyDlg.CSAccountDataset.MST_ACCOUNT.Merge(CSGLDataset.MST_ACCOUNT)
                    MyDlg.SYSACCTYPEBindingSource.DataSource = MyDlg.CSAccountDataset
                    MyDlg.MST_ACCOUNTBindingSource.DataSource = MyDlg.CSAccountDataset
                    MyDlg.MST_ACCOUNTBindingSource.Filter = "IS_ACTIVE=1"
                    MyDlg.SearchText(CStr(MyTextBox.Text))
                    If MyDlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                        If MyDlg.ACC_CODE <> "" Then
                            Dim MyData As DataRowView = CType(TRN_GNLJNLDBindingSource.Current, DataRowView)
                            MyData.EndEdit()
                            MyData.BeginEdit()
                            MyData("ACC_CODE") = MyDlg.ACC_CODE
                            MyTextBox.Text = MyDlg.ACC_CODE
                            MyData.EndEdit()
                            TRN_GNLJNLDDataGridView.EndEdit()
                            MST_ACCOUNTBindingSource.Position = MST_ACCOUNTBindingSource.Find("ACC_CODE", MyDlg.ACC_CODE)
                        End If
                        e.SuppressKeyPress = True
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub TRN_GNLJNLDDataGridView_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Space) Then
			If TRN_GNLJNLDDataGridView.Columns(TRN_GNLJNLDDataGridView.SelectedCells(0).ColumnIndex).DataPropertyName = "ACC_CODE" Then
				e.Handled = True
			End If
		End If
    End Sub

End Class
