'** NOTICE:

'There are many limitation and uncompleteness in this demo source code, CSAccountDatabaseIntf project
'is not modifiable, you can only see some sample dataset designer.

'The License source code will allow you to configure, add, edit or remove the dataset, please visit
'http://www.cynics-soft.com for more information.

'Right Click Solution on 'Cynics Accounting'(6 projects), and select Build Solution before open any file.

'If you have any question, feel free to contact me at kkchoon@cynics-soft.com or support@cynics-soft.com

'Copyright (C) CYNICS SOFTWARE 2007 - 2008


Imports CSAccountDatabaseIntf
Imports CSAccountDatabaseIntf.CSGLDataset
Imports System.Windows.Forms
Public Class FmAccount
    Public Overrides Sub DBControlsEnabled(ByVal InValue As Boolean)
        BrowseGrid.ReadOnly = Not InValue
        BrowseGrid.AllowUserToAddRows = InValue
        BrowseGrid.AllowUserToDeleteRows = InValue
        ACC_CODETextBox.Enabled = InValue
        ACC_NAMETextBox.Enabled = InValue
        ACC_TYPEComboBox.Enabled = InValue
        RETAINED_EARNINGSCheckBox.Enabled = InValue
        IS_ACTIVECheckBox.Enabled = InValue
    End Sub

    Public Overrides Property SystemManager() As CSAccountDatabaseIntf.ICSAccountDatabaseIntf
        Get
            Return MyBase.SystemManager
        End Get
        Set(ByVal value As CSAccountDatabaseIntf.ICSAccountDatabaseIntf)
            MyBase.SystemManager = value
            Try
                SystemManager.LoadCSGLMasterDataset()
                CSGLDataset = SystemManager.GetCSGLDataset
                Dataset = CSGLDataset
                SYSACCTYPEBindingSource.DataSource = CSGLDataset
                MST_ACCOUNTBindingSource.DataSource = CSGLDataset
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
            m_KeyInfo.KeyNo = -1
            m_KeyInfo.KeyCode = CStr(CType(MST_ACCOUNTBindingSource.Current, DataRowView)("ACC_CODE"))
            Return MyBase.KeyInfo
        End Get
        Set(ByVal value As CSAccountDatabaseIntf.FormKeyInfo)
            MyBase.KeyInfo = value
        End Set
    End Property

    Public Overrides ReadOnly Property FirstControl() As System.Windows.Forms.Control
        Get
            If ACC_CODETextBox.Enabled = True Then
                Return ACC_CODETextBox
            Else
                Return ACC_NAMETextBox
            End If

        End Get
    End Property

    Private Sub FmAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BindDataSource(MST_ACCOUNTBindingSource)
    End Sub

    Private Sub FmAccount_BeforeNewAndEdit(ByVal Sender As System.Object, ByVal e As CSAccountDatabaseIntf.BeforeAfterEditNewEventAgrs) Handles MyBase.BeforeNewAndEdit
        If e.IsNew = False Then
            TabControl.SelectedIndex = 1
        End If
    End Sub

    Private Sub FmAccount_tsbtnSaveClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.tsbtnSaveClick
        MST_ACCOUNTBindingSource.EndEdit()
        SystemManager.SaveCSGLMasterDataset(CSGLDataset)
        CSGLDataset.MST_ACCOUNT.AcceptChanges()
    End Sub

    Private Sub FmAccount_tsbtnCancelClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.tsbtnCancelClick
        MST_ACCOUNTBindingSource.CancelEdit()
        CSGLDataset.MST_ACCOUNT.RejectChanges()
    End Sub

    Private Sub FmAccount_BeforesbtnSaveclick(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.BeforesbtnSaveclick
        e.Cancel = False
        If DBStatus = FormDBStatus.FormAdd Then
            Dim MyAccRow() As DataRow = CSGLDataset.MST_ACCOUNT.Select("ACC_CODE='" + CStr(CType(MST_ACCOUNTBindingSource.Current, DataRowView)("ACC_CODE")) + "'")
            If MyAccRow.Length > 0 Then
                MsgBox("Acc# already exists !")
                ACC_CODETextBox.Select()
                e.Cancel = True
            End If
        End If
        If e.Cancel = False Then
            MST_ACCOUNTBindingSource.EndEdit()
            Dim MyRow() As MST_ACCOUNTRow = CType(CSGLDataset.MST_ACCOUNT.Select("RETAINED_EARNINGS=1"), MST_ACCOUNTRow())
            If MyRow.Length > 1 Then
                Dim MyRowView As DataRowView = CType(MST_ACCOUNTBindingSource.Current, DataRowView)
                If CBool(MyRowView("RETAINED_EARNINGS")) = True Then
                    MsgBox("Only 1 record are allow for Retained Eearnings")
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub RETAINED_EARNINGSCheckBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles RETAINED_EARNINGSCheckBox.Validating
        e.Cancel = False
        Dim MyRow As DataRowView = CType(MST_ACCOUNTBindingSource.Current, DataRowView)
        If RETAINED_EARNINGSCheckBox.Checked = True Then
            If CInt(MyRow("ACC_TYPE")) <> 5 Then
                MsgBox("Only Equity can be Retained Earnings !")
                e.Cancel = True
                RETAINED_EARNINGSCheckBox.Checked = False
            End If
        End If
    End Sub

    Private Sub FmAccount_BeforeDelete(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.BeforeDelete
        e.Cancel = False
        If MST_ACCOUNTBindingSource.Count > 0 Then
            If SystemManager.CheckAccExists(CStr(CType(MST_ACCOUNTBindingSource.Current, DataRowView)("ACC_CODE"))) Then
                MsgBox("Account Transaction / Financial template exists !")
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub FmAccount_AfterNewAndEdit(ByVal Sender As System.Object, ByVal e As CSAccountDatabaseIntf.BeforeAfterEditNewEventAgrs) Handles MyBase.AfterNewAndEdit
        If e.IsNew = False Then
            Dim MyData As DataRowView = CType(MST_ACCOUNTBindingSource.Current, DataRowView)
            ACC_CODETextBox.Enabled = SystemManager.CheckAccExists(CStr(MyData("ACC_CODE"))) = False
        End If
    End Sub

    Private Sub ACC_CODETextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ACC_CODETextBox.Validating
        e.Cancel = Not ValidateLength(ACC_CODETextBox, True)
    End Sub

    Private Sub ACC_NAMETextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ACC_NAMETextBox.Validating
        e.Cancel = Not ValidateLength(ACC_NAMETextBox, True)
    End Sub
End Class
