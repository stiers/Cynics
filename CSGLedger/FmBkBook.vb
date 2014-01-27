Imports CSAccountDatabaseIntf
Imports CSCommon
Imports System.Windows.Forms
Public Class FmBkBook
    Private Sub TRN_BKTRANDDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles TRN_BKTRANDDataGridView.DataError
        HandleGridError(sender, e)
    End Sub

    Public Overrides Sub DBControlsEnabled(ByVal InValue As Boolean)
        BrowseGrid.ReadOnly = Not InValue
        TRN_BKTRANDDataGridView.ReadOnly = Not InValue
        TRN_BKTRANDDataGridView.AllowUserToDeleteRows = InValue
        TRN_BKTRANDDataGridView.AllowUserToAddRows = InValue
        BKTRAN_CODETextBox.Enabled = InValue
        BANKNOComboBox.Enabled = InValue
        TRAN_DATEDateTimePicker.Enabled = InValue
        IS_PAYMENTCheckBox.Enabled = InValue
        ACC_PERIODNumericUpDown.Enabled = InValue
        BKDESCTextBox.Enabled = InValue
    End Sub

    Public Overrides Property SystemManager() As CSAccountDatabaseIntf.ICSAccountDatabaseIntf
        Get
            Return MyBase.SystemManager
        End Get
        Set(ByVal value As CSAccountDatabaseIntf.ICSAccountDatabaseIntf)
            MyBase.SystemManager = value
            Try
                SystemManager.LoadCSAccBKBookDataset(SystemInfo.StartDate, SystemInfo.EndDate)
                CSAccBkBookDataset = SystemManager.GetCSAccBKBookDataset
                Dataset = CSAccBkBookDataset
                MSTACCOUNTBindingSource1.DataSource = CSAccBkBookDataset
                TRN_BKTRANBindingSource.DataSource = CSAccBkBookDataset
                TRN_BKTRANDBindingSource.DataSource = TRN_BKTRANBindingSource
                MSTBANKBindingSource.DataSource = CSAccBkBookDataset
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
            Return BKTRAN_CODETextBox
        End Get
    End Property

    Private Sub FmAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BindDataSource(TRN_BKTRANBindingSource)
    End Sub

    Private Sub btnBank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBank.Click
        CallForm("CSGLedger.FmBank", "MST_BANK")
        BANKNOComboBox.BindingContext = BANKNOComboBox.BindingContext
    End Sub

    Private Sub FmBkBook_BeforeNewAndEdit(ByVal Sender As System.Object, ByVal e As CSAccountDatabaseIntf.BeforeAfterEditNewEventAgrs) Handles MyBase.BeforeNewAndEdit
        e.Cancel = False
        If e.IsNew = False Then
            TabControl.SelectedIndex = 1
            If SystemInfo.BusinessPeriod.AccYear <> CInt(ACC_YEARNumericUpDown.Value) Then
                MsgBox("Cannot edit closed transactions !")
                e.Cancel = True
            End If
        Else
            If CSAccBkBookDataset.MST_BANK.Count = 0 Then
                MsgBox("No Bank exists !")
                e.Cancel = True
            End If

            If CSAccBkBookDataset.MST_ACCOUNT.Count = 0 Then
                MsgBox("No Account exists !")
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub FmBkBook_tsbtnSaveClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.tsbtnSaveClick
        TRN_BKTRANBindingSource.EndEdit()
        TRN_BKTRANDBindingSource.EndEdit()
        SystemManager.SaveCSAcccBKBookDataset(CSAccBkBookDataset)
        CSAccBkBookDataset.TRN_BKTRAN.AcceptChanges()
        CSAccBkBookDataset.TRN_BKTRAND.AcceptChanges()
    End Sub

    Private Sub FmBkBook_tsbtnCancelClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.tsbtnCancelClick
        TRN_BKTRANDBindingSource.CancelEdit()
        TRN_BKTRANBindingSource.CancelEdit()
        CSAccBkBookDataset.TRN_BKTRAN.RejectChanges()
        CSAccBkBookDataset.TRN_BKTRAND.RejectChanges()
    End Sub

    Private Sub TRN_BKTRANBindingSource_AddingNew(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles TRN_BKTRANBindingSource.AddingNew
        Dim BankRec As DataRowView = CType(MSTBANKBindingSource.Current, DataRowView)
        Dim NewRow As CSAccBkBookDataset.TRN_BKTRANRow = CSAccBkBookDataset.TRN_BKTRAN.NewTRN_BKTRANRow
        NewRow("BKTRANNO") = SystemManager.GetKey("BKTRANNO")
        NewRow("BKTRAN_CODE") = ""
        NewRow("BANKNO") = BankRec("BANKNO")
        NewRow("ACC_CODE") = BankRec("ACC_CODE")
        NewRow("BKDesc") = ""
        NewRow("TRAN_DATE") = SystemInfo.BusinessDate
        NewRow("ACC_YEAR") = SystemInfo.BusinessPeriod.AccYear
        NewRow("ACC_PERIOD") = SystemInfo.BusinessPeriod.AccPeriod
        NewRow("IS_PAYMENT") = 1
        NewRow("TOTALAMT") = 0
        e.NewObject = NewRow
        CSAccBkBookDataset.TRN_BKTRAN.AddTRN_BKTRANRow(NewRow)
        TRN_BKTRANBindingSource.Position = TRN_BKTRANBindingSource.Count
    End Sub

    Private Sub TRN_BKTRANDBindingSource_AddingNew(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles TRN_BKTRANDBindingSource.AddingNew
        Dim AccRec As DataRowView = CType(MSTACCOUNTBindingSource1.Current, DataRowView)
        Dim NewRow As CSAccBkBookDataset.TRN_BKTRANDRow = CSAccBkBookDataset.TRN_BKTRAND.NewTRN_BKTRANDRow
        Dim ParentRec As DataRowView = CType(TRN_BKTRANBindingSource.Current, DataRowView)
        NewRow("BKTRANDNO") = SystemManager.GetKey("BKTRANDNO")
        NewRow("BKTRANNO") = ParentRec("BKTRANNO")
        NewRow("CHEQUE_CODE") = ""
        NewRow("ACC_CODE") = AccRec("ACC_CODE")
        NewRow("TRANDESC") = ""
        NewRow("AMOUNT") = 0
        e.NewObject = NewRow
        CSAccBkBookDataset.TRN_BKTRAND.AddTRN_BKTRANDRow(NewRow)
        TRN_BKTRANDBindingSource.Position = TRN_BKTRANDBindingSource.Count
    End Sub

    Private Sub TRAN_DATEDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TRAN_DATEDateTimePicker.ValueChanged
        Dim TempPeriod As AccPeriodDef = SystemInfo.GetAccPeriod(CType(sender, DateTimePicker).Value)
        If TempPeriod.AccYear <> 0 Then
            ACC_YEARNumericUpDown.Value = TempPeriod.AccYear
            ACC_PERIODNumericUpDown.Value = TempPeriod.AccPeriod
        End If
    End Sub

    Private Sub TRN_BKTRANDDataGridView_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles TRN_BKTRANDDataGridView.EditingControlShowing
        ForceUpperGridColumnTextbox(CType(sender, DataGridView), e, "ACC_CODE")

        If TypeOf e.Control Is TextBox Then
            Dim mytextbox As TextBox = CType(e.Control, TextBox)
            RemoveHandler mytextbox.PreviewKeyDown, AddressOf TRN_BKTRANDDataGridView_PreviewKeyDown
            'Must remove previous handler before adding, because controlshowing event might occurs multiple times result in multiple call to keydown
            RemoveHandler mytextbox.KeyDown, AddressOf TRN_BKTRANDDataGridView_KeyDown
            RemoveHandler mytextbox.KeyPress, AddressOf TRN_BKTRANDDataGridView_KeyPress

            AddHandler mytextbox.PreviewKeyDown, AddressOf TRN_BKTRANDDataGridView_PreviewKeyDown
            AddHandler mytextbox.KeyDown, AddressOf TRN_BKTRANDDataGridView_KeyDown
            AddHandler mytextbox.KeyPress, AddressOf TRN_BKTRANDDataGridView_KeyPress
        End If
    End Sub

    Private Sub TRN_BKTRANDDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TRN_BKTRANDDataGridView.CellContentClick
        If TRN_BKTRANDDataGridView.Columns(e.ColumnIndex).Name = "btnAccColumn" Then
            CallForm("CSGLedger.FmAccount", "MST_ACCOUNT")
        End If
    End Sub

    Private Sub BKDESCTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles BKDESCTextBox.Validating
        If CheckSkipValidate() Then
            Exit Sub
        End If

        e.Cancel = Not ValidateLength(BKDESCTextBox, False)
    End Sub

    Private Sub BKTRAN_CODETextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles BKTRAN_CODETextBox.Validating
        If CheckSkipValidate() Then
            Exit Sub
        End If

        If BKTRAN_CODETextBox.Text.Length = 0 Then
            MsgBox("Tran# required !")
            e.Cancel = True
        Else
            e.Cancel = Not ValidateLength(BKTRAN_CODETextBox, True)
        End If
    End Sub

    Private Sub TRN_BKTRANDDataGridView_CellValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles TRN_BKTRANDDataGridView.CellValidating
        Select Case e.ColumnIndex
            Case 0
                Dim CurrVal As Decimal
                If Decimal.TryParse(CStr(e.FormattedValue), CurrVal) Then
                    If CurrVal = 0 Then
                        MsgBox("Amount not specify !")
                        e.Cancel = True
                    End If
                End If
            Case 2, 4
                    Dim AccRow As DataRow = Nothing

                    If e.ColumnIndex = 2 Then
                        AccRow = CSAccBkBookDataset.MST_ACCOUNT.FindByACC_CODE(e.FormattedValue.ToString)
                    Else
                    Dim AccRows() As DataRow
                    Dim AccName As String = e.FormattedValue.ToString
                    AccName = AccName.Replace("'", "''")
                    AccRows = CSAccBkBookDataset.MST_ACCOUNT.Select("ACC_NAME='" + AccName + "'")
                        If AccRows.Length > 0 Then
                            AccRow = AccRows(0)
                        End If
                    End If

                    If AccRow IsNot Nothing Then
                        If CBool(AccRow("IS_ACTIVE")) = False Then
                            MsgBox("Account is not active !")
                            e.Cancel = True
                        Else
                        End If
                    Else
                        MsgBox("Incorrect Acc# !")
                        e.Cancel = True
                    End If
        End Select
    End Sub

    Private Sub TRN_BKTRANDDataGridView_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs)
        If e.KeyCode = Keys.Space Then
			If TRN_BKTRANDDataGridView.Columns(TRN_BKTRANDDataGridView.SelectedCells(0).ColumnIndex).DataPropertyName = "ACC_CODE" Then
				e.IsInputKey = True
			End If
		End If
    End Sub

    Private Sub TRN_BKTRANDDataGridView_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If TRN_BKTRANDDataGridView.SelectedCells.Count > 0 Then
            If TRN_BKTRANDDataGridView.Columns(TRN_BKTRANDDataGridView.SelectedCells(0).ColumnIndex).DataPropertyName = "ACC_CODE" Then
                If e.KeyCode = Keys.Space Then
                    Dim MyTextBox As TextBox = CType(sender, TextBox)
                    Dim MyDlg As FmAccountDlg = New FmAccountDlg
                    MyDlg.CSAccountDataset.SYS_ACCTYPE.Merge(CSAccBkBookDataset.SYS_ACCTYPE)
                    MyDlg.CSAccountDataset.MST_ACCOUNT.Merge(CSAccBkBookDataset.MST_ACCOUNT)
                    MyDlg.SYSACCTYPEBindingSource.DataSource = MyDlg.CSAccountDataset
                    MyDlg.MST_ACCOUNTBindingSource.DataSource = MyDlg.CSAccountDataset
                    MyDlg.MST_ACCOUNTBindingSource.Filter = "IS_ACTIVE=1"
                    MyDlg.SearchText(CStr(MyTextBox.Text))
                    If MyDlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                        If MyDlg.ACC_CODE <> "" Then
                            Dim MyData As DataRowView = CType(TRN_BKTRANDBindingSource.Current, DataRowView)
                            MyData.EndEdit()
                            MyData.BeginEdit()
                            MyData("ACC_CODE") = MyDlg.ACC_CODE
                            MyTextBox.Text = MyDlg.ACC_CODE
                            MyData.EndEdit()
                            TRN_BKTRANDDataGridView.EndEdit()
                            MSTACCOUNTBindingSource1.Position = MSTACCOUNTBindingSource1.Find("ACC_CODE", MyDlg.ACC_CODE)
                        End If
                        e.SuppressKeyPress = True
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub TRN_BKTRANDDataGridView_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Space) Then
			If TRN_BKTRANDDataGridView.Columns(TRN_BKTRANDDataGridView.SelectedCells(0).ColumnIndex).DataPropertyName = "ACC_CODE" Then
				e.Handled = True
			End If
		End If
    End Sub

    Private Sub FmBkBook_AfterNewAndEdit(ByVal Sender As System.Object, ByVal e As CSAccountDatabaseIntf.BeforeAfterEditNewEventAgrs) Handles MyBase.AfterNewAndEdit
        AccName.ReadOnly = True
    End Sub

    Private EnteredRow As Boolean = False

    Private Sub TRN_BKTRANDDataGridView_KeyDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TRN_BKTRANDDataGridView.KeyDown
        If e.KeyCode = Keys.Down Then
            If EnteredRow = False Then
                Try
                    EnteredRow = True
                    If TRN_BKTRANDBindingSource.Position = TRN_BKTRANDBindingSource.Count - 1 Then
                        TRN_BKTRANDDataGridView.CurrentCell = TRN_BKTRANDDataGridView.Rows(TRN_BKTRANDDataGridView.NewRowIndex).Cells(0)
                    End If
                Finally
                    EnteredRow = False
                End Try
            End If
        End If
    End Sub

    Private Sub FmBkBook_BeforesbtnSaveclick(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.BeforesbtnSaveclick
        TRN_BKTRANDBindingSource.EndEdit()
        TRN_BKTRANBindingSource.EndEdit()
        Dim CurrRec As DataRowView = CType(TRN_BKTRANBindingSource.Current, DataRowView)
        If CurrRec IsNot Nothing Then
            CurrRec.EndEdit()
            CurrRec("TOTALAMT") = CurrRec("CALCTOTALAMT")
            CurrRec.EndEdit()
        End If
    End Sub
End Class
