Public Class FmCurrency
    Public Overrides Sub DBControlsEnabled(ByVal InValue As Boolean)
        BrowseGrid.ReadOnly = Not InValue
        BrowseGrid.AllowUserToAddRows = InValue
        BrowseGrid.AllowUserToDeleteRows = InValue
        CURR_CODETextBox.Enabled = InValue
        CURR_NAMETextBox.Enabled = InValue
        CURR_RATETextBox.Enabled = InValue
    End Sub

    Public Overrides Property SystemManager() As CSAccountDatabaseIntf.ICSAccountDatabaseIntf
        Get
            Return MyBase.SystemManager
        End Get
        Set(ByVal value As CSAccountDatabaseIntf.ICSAccountDatabaseIntf)
            MyBase.SystemManager = value
            Try
                SystemManager.LoadCSGLCurrDataset()
                CSGLDataset = SystemManager.GetCSGLDataset
                Dataset = CSGLDataset
                MST_CURRENCYBindingSource.DataSource = CSGLDataset
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
            Return CURR_CODETextBox
        End Get
    End Property

    Private Sub FmCurrency_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BindDataSource(MST_CURRENCYBindingSource)
    End Sub

    Private Sub FmCurrency_BeforeNewAndEdit(ByVal Sender As System.Object, ByVal e As CSAccountDatabaseIntf.BeforeAfterEditNewEventAgrs) Handles MyBase.BeforeNewAndEdit
        If e.IsNew = False Then
            TabControl.SelectedIndex = 1
        End If
    End Sub

    Private Sub FmCurrency_tsbtnSaveClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.tsbtnSaveClick
        MST_CURRENCYBindingSource.EndEdit()
        SystemManager.SaveCSGLCurrDataset(CSGLDataset)
        CSGLDataset.MST_CURRENCY.AcceptChanges()
    End Sub

    Private Sub FmCurrency_tsbtnCancelClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.tsbtnCancelClick
        MST_CURRENCYBindingSource.CancelEdit()
        CSGLDataset.MST_CURRENCY.RejectChanges()
    End Sub

    Private Sub FmCurrency_BeforeDelete(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.BeforeDelete
        Dim MyData As DataRowView = CType(MST_CURRENCYBindingSource.Current, DataRowView)
        If SystemManager.CheckCurrencyExists(CStr(MyData("CURR_CODE"))) Then
            MsgBox("Cannot delete, currency code is used by 1 or mroe of the followings forms - Company Setup, Customer Setup or AR, AP Transactions !")
            e.Cancel = True
        End If
    End Sub

    Private Sub CURR_CODETextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CURR_CODETextBox.Validating
        e.Cancel = Not ValidateLength(CURR_CODETextBox, True)
    End Sub

    Private Sub CURR_NAMETextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CURR_NAMETextBox.Validating
        e.Cancel = Not ValidateLength(CURR_NAMETextBox, True)
    End Sub

    Private Sub FmCurrency_AfterNewAndEdit(ByVal Sender As System.Object, ByVal e As CSAccountDatabaseIntf.BeforeAfterEditNewEventAgrs) Handles MyBase.AfterNewAndEdit
        If e.IsNew = False Then
            Dim MyData As DataRowView = CType(MST_CURRENCYBindingSource.Current, DataRowView)
            If SystemManager.CheckCurrencyExists(CStr(MyData("CURR_CODE"))) Then
                CURR_CODETextBox.Enabled = False
            End If
        End If
    End Sub
End Class
