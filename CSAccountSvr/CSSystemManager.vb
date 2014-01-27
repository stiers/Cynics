Imports CSAccountDatabaseIntf
Imports System.Text
Imports CSCommon
Imports System.IO
Imports System.Threading
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
<Serializable()> _
Public Class CSSystemManager
    Inherits MarshalByRefObject
    Implements ICSAccountDatabaseIntf

    Private SQLScriptEngine As SQLScriptEngine = New SQLScriptEngine

    Private daQuery As CSSystemDBDatasetTableAdapters.QueriesTableAdapter

    Private dsSystemDB As CSSystemDBDataset
    Private dsGLDB As CSGLDataset
    Private dsMasterDB As CSMasterDataset
    Private dsBudgetDB As CSBudgetDataset

    Private dsAccPayableDB As CSAccPayableDataset

    Private spSystem As CSSystemDBDatasetTableAdapters.QueriesTableAdapter

    Private Sub CreatedsBudgetDB()
        If dsBudgetDB Is Nothing Then
            dsBudgetDB = New CSBudgetDataset
        End If
    End Sub

    Private Sub CreatespSystem()
        If spSystem Is Nothing Then
            spSystem = New CSSystemDBDatasetTableAdapters.QueriesTableAdapter
        End If
    End Sub

    Private Sub CreatedsSystemDB()
        If dsSystemDB Is Nothing Then
            dsSystemDB = New CSSystemDBDataset
        End If
    End Sub

    Private Sub CreatedsGLDB()
        If dsGLDB Is Nothing Then
            dsGLDB = New CSGLDataset
        End If
    End Sub

    Private Sub CreatedsMasterDB()
        If dsMasterDB Is Nothing Then
            dsMasterDB = New CSMasterDataset
        End If
    End Sub

    Public Function GetCSSystemDBDataset() As CSAccountDatabaseIntf.CSSystemDBDataset Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.GetCSSystemDBDataset
        CreatedsSystemDB()
        Return dsSystemDB
    End Function

    Public Sub LoadCSAccountDBDataset() Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSAccountDBDataset

    End Sub


    Public Sub CreatedaQuery()
        If daQuery Is Nothing Then
            daQuery = New CSSystemDBDatasetTableAdapters.QueriesTableAdapter
        End If
    End Sub

    Public Sub LoadCSSystemDBDataset_KeyCode() Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSSystemDBDataset_KeyCode
        CreatedsSystemDB()
        Dim KeyCodeAdapter As CSSystemDBDatasetTableAdapters.MST_KEYCODETableAdapter = New CSSystemDBDatasetTableAdapters.MST_KEYCODETableAdapter
        KeyCodeAdapter.Fill(dsSystemDB.MST_KEYCODE)
    End Sub

    Public Sub SaveCSSystemDBDatasetKeyCode(ByVal InDataset As CSAccountDatabaseIntf.CSSystemDBDataset) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveCSSystemDBDatasetKeyCode
        Dim KeyCodeAdapter As CSSystemDBDatasetTableAdapters.MST_KEYCODETableAdapter = New CSSystemDBDatasetTableAdapters.MST_KEYCODETableAdapter
        KeyCodeAdapter.Update(InDataset)
    End Sub

    Public Sub LoadCSSystemDBDataset() Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSSystemDBDataset
        Dim daGrp As CSSystemDBDatasetTableAdapters.MST_GRPSTableAdapter
        daGrp = New CSSystemDBDatasetTableAdapters.MST_GRPSTableAdapter

        Dim daForms As CSSystemDBDatasetTableAdapters.MST_FORMSTableAdapter
        daForms = New CSSystemDBDatasetTableAdapters.MST_FORMSTableAdapter

        Dim daGrpForm As CSSystemDBDatasetTableAdapters.MST_GRPFORMTableAdapter
        daGrpForm = New CSSystemDBDatasetTableAdapters.MST_GRPFORMTableAdapter

        Dim daGrpformdetail As CSSystemDBDatasetTableAdapters.GRPFORMDetailTableAdapter
        daGrpformdetail = New CSSystemDBDatasetTableAdapters.GRPFORMDetailTableAdapter

        Dim daUser As CSSystemDBDatasetTableAdapters.MST_USERTableAdapter
        daUser = New CSSystemDBDatasetTableAdapters.MST_USERTableAdapter

        Dim daRoles As CSSystemDBDatasetTableAdapters.MST_ROLESTableAdapter
        daRoles = New CSSystemDBDatasetTableAdapters.MST_ROLESTableAdapter

        Dim daRoleForm As CSSystemDBDatasetTableAdapters.MST_ROLEFORMTableAdapter
        daRoleForm = New CSSystemDBDatasetTableAdapters.MST_ROLEFORMTableAdapter

        Dim daCompany As CSSystemDBDatasetTableAdapters.MST_COMPANYTableAdapter
        daCompany = New CSSystemDBDatasetTableAdapters.MST_COMPANYTableAdapter

        CreatedsSystemDB()
        daGrp.Fill(dsSystemDB.MST_GRPS)
        daForms.Fill(dsSystemDB.MST_FORMS)
        daGrpForm.Fill(dsSystemDB.MST_GRPFORM)
        daGrpformdetail.Fill(dsSystemDB.GRPFORMDetail)
        daUser.Fill(dsSystemDB.MST_USER)
        daRoles.Fill(dsSystemDB.MST_ROLES)
        daRoleForm.Fill(dsSystemDB.MST_ROLEFORM)
        daCompany.Fill(dsSystemDB.MST_COMPANY)
    End Sub

    Public Function CSSystemStoreProc() As CSAccountDatabaseIntf.CSSystemDBDatasetTableAdapters.QueriesTableAdapter Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.CSSystemStoreProc
        CreatespSystem()
        Return spSystem
    End Function

    Public Sub SaveCSSystemDBDataset(ByVal InDataset As CSAccountDatabaseIntf.CSSystemDBDataset) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveCSSystemDBDataset
        Dim daGrp As CSSystemDBDatasetTableAdapters.MST_GRPSTableAdapter = New CSSystemDBDatasetTableAdapters.MST_GRPSTableAdapter
        Dim daForms As CSSystemDBDatasetTableAdapters.MST_FORMSTableAdapter = New CSSystemDBDatasetTableAdapters.MST_FORMSTableAdapter
        Dim daGrpForm As CSSystemDBDatasetTableAdapters.MST_GRPFORMTableAdapter = New CSSystemDBDatasetTableAdapters.MST_GRPFORMTableAdapter

        daGrp.Update(InDataset.MST_GRPS.Select("", "", DataViewRowState.Added))
        daGrpForm.Update(InDataset.MST_GRPFORM.Select("", "", DataViewRowState.Added))
        daGrp.Update(InDataset.MST_GRPS.Select("", "", DataViewRowState.ModifiedCurrent))
        daGrpForm.Update(InDataset.MST_GRPFORM.Select("", "", DataViewRowState.ModifiedCurrent))
        daGrpForm.Update(InDataset.MST_GRPFORM.Select("", "", DataViewRowState.Deleted))
        daGrp.Update(InDataset.MST_GRPS.Select("", "", DataViewRowState.Deleted))
    End Sub

    Public Sub SaveSecurityUserInfo(ByVal InDataset As CSAccountDatabaseIntf.CSSystemDBDataset) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveSecurityUserInfo
        Dim daUser As CSSystemDBDatasetTableAdapters.MST_USERTableAdapter = New CSSystemDBDatasetTableAdapters.MST_USERTableAdapter

        daUser.Update(InDataset.MST_USER.Select("", "", DataViewRowState.Deleted))
        daUser.Update(InDataset.MST_USER.Select("", "", DataViewRowState.ModifiedCurrent))
        daUser.Update(InDataset.MST_USER.Select("", "", DataViewRowState.Added))
    End Sub

    Public Sub SaveSecurityRoleInfo(ByVal InDataset As CSAccountDatabaseIntf.CSSystemDBDataset) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveSecurityRoleInfo
        Dim daRoles As CSSystemDBDatasetTableAdapters.MST_ROLESTableAdapter = New CSSystemDBDatasetTableAdapters.MST_ROLESTableAdapter
        Dim daRoleForm As CSSystemDBDatasetTableAdapters.MST_ROLEFORMTableAdapter = New CSSystemDBDatasetTableAdapters.MST_ROLEFORMTableAdapter
        daRoleForm.Update(InDataset.MST_ROLEFORM.Select("", "", DataViewRowState.Deleted))
        daRoles.Update(InDataset.MST_ROLES.Select("", "", DataViewRowState.Deleted))
        daRoles.Update(InDataset.MST_ROLES.Select("", "", DataViewRowState.Added))
        daRoleForm.Update(InDataset.MST_ROLEFORM.Select("", "", DataViewRowState.Added))
        daRoles.Update(InDataset.MST_ROLES.Select("", "", DataViewRowState.ModifiedCurrent))
        daRoleForm.Update(InDataset.MST_ROLEFORM.Select("", "", DataViewRowState.ModifiedCurrent))
    End Sub

    Public Function GetCSGLDataset() As CSAccountDatabaseIntf.CSGLDataset Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.GetCSGLDataset
        CreatedsGLDB()
        Return dsGLDB
    End Function

    Public Function GetKey(ByVal InKeyName As String) As Integer Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.GetKey
        CreatedaQuery()
        Dim KeyNo As Nullable(Of Integer)
        daQuery.GETKEY(InKeyName, KeyNo)
        If KeyNo.HasValue Then
            Return CInt(KeyNo)
        Else
            Return -1
        End If
    End Function

    Private Function GetRunnoFormat(ByVal InLength As Integer) As String
        Dim StrLength As Integer = 10 - InLength
        Dim FmtStr As String = ""
        For I As Integer = 1 To StrLength
            FmtStr += "0"
        Next
        Return FmtStr
    End Function

    Public Function GetKeyCode(ByVal InKeyName As String) As String Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.GetKeyCode
        CreatedaQuery()
        Dim KeyNo As Nullable(Of Integer)
        Dim Prefix As String = ""
        daQuery.GetKeyCode(InKeyName, Prefix, KeyNo)
        If KeyNo.HasValue Then
            If (Prefix = "") And (CInt(KeyNo) = -1) Then
                Return ""
            Else
                Return String.Format("{0}{1}", Prefix, CInt(KeyNo).ToString(GetRunnoFormat(Prefix.Length)))
            End If
        Else
            Return ""
        End If
    End Function

    Public Sub LoadCSGLMasterDataset() Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSGLMasterDataset
        Dim daAccount As CSGLDatasetTableAdapters.MST_ACCOUNTTableAdapter = New CSGLDatasetTableAdapters.MST_ACCOUNTTableAdapter
        Dim daAccType As CSGLDatasetTableAdapters.SYS_ACCTYPETableAdapter = New CSGLDatasetTableAdapters.SYS_ACCTYPETableAdapter
        CreatedsGLDB()
        daAccount.Fill(dsGLDB.MST_ACCOUNT)
        daAccType.Fill(dsGLDB.SYS_ACCTYPE)
    End Sub

    Public Sub SaveCSGLMasterDataset(ByVal InDataset As CSAccountDatabaseIntf.CSGLDataset) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveCSGLMasterDataset
        Dim daAccount As CSGLDatasetTableAdapters.MST_ACCOUNTTableAdapter = New CSGLDatasetTableAdapters.MST_ACCOUNTTableAdapter
        daAccount.Update(InDataset)
    End Sub

    Public Sub LoadCSGLTranDataset(ByVal StartDate As DateTime, ByVal EndDate As DateTime) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSGLTranDataset
        LoadCSGLMasterDataset()
        LoadCSGLCurrDataset()
        Dim daGL As CSGLDatasetTableAdapters.TRN_GNLJNLTableAdapter = New CSGLDatasetTableAdapters.TRN_GNLJNLTableAdapter
        Dim daGLD As CSGLDatasetTableAdapters.TRN_GNLJNLDTableAdapter = New CSGLDatasetTableAdapters.TRN_GNLJNLDTableAdapter
        daGL.Fill(dsGLDB.TRN_GNLJNL, StartDate, EndDate)
        daGLD.Fill(dsGLDB.TRN_GNLJNLD, StartDate, EndDate)
    End Sub

    Public Sub SaveCSGLTranDataset(ByVal InDataset As CSAccountDatabaseIntf.CSGLDataset) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveCSGLTranDataset
        Dim daGL As CSGLDatasetTableAdapters.TRN_GNLJNLTableAdapter = New CSGLDatasetTableAdapters.TRN_GNLJNLTableAdapter
        Dim daGLD As CSGLDatasetTableAdapters.TRN_GNLJNLDTableAdapter = New CSGLDatasetTableAdapters.TRN_GNLJNLDTableAdapter
        Dim MyTransaction As System.Data.SqlClient.SqlTransaction

        daGL.Connection.Open()
        MyTransaction = daGL.Connection.BeginTransaction()
        daGL.SetCommandsTransaction(daGL.Connection, MyTransaction)
        daGLD.SetCommandsTransaction(daGL.Connection, MyTransaction)
        Try
            daGL.Update(InDataset.TRN_GNLJNL.Select("", "", DataViewRowState.Added))
            daGLD.Update(InDataset.TRN_GNLJNLD.Select("", "", DataViewRowState.Added))
            daGL.Update(InDataset.TRN_GNLJNL.Select("", "", DataViewRowState.ModifiedCurrent))
            daGLD.Update(InDataset.TRN_GNLJNLD.Select("", "", DataViewRowState.ModifiedCurrent))
            daGLD.Update(InDataset.TRN_GNLJNLD.Select("", "", DataViewRowState.Deleted))
            daGL.Update(InDataset.TRN_GNLJNL.Select("", "", DataViewRowState.Deleted))
            MyTransaction.Commit()
            daGL.Connection.Close()
        Catch ex As Exception
            MyTransaction.Rollback()
            daGL.Connection.Close()
            Throw ex
        End Try
    End Sub

    Public Sub LoadCSGLCurrDataset() Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSGLCurrDataset
        Dim daCurrency As CSGLDatasetTableAdapters.MST_CURRENCYTableAdapter = New CSGLDatasetTableAdapters.MST_CURRENCYTableAdapter
        CreatedsGLDB()
        daCurrency.Fill(dsGLDB.MST_CURRENCY)
    End Sub

    Public Sub SaveCSGLCurrDataset(ByVal InDataset As CSAccountDatabaseIntf.CSGLDataset) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveCSGLCurrDataset
        Dim daCurrency As CSGLDatasetTableAdapters.MST_CURRENCYTableAdapter = New CSGLDatasetTableAdapters.MST_CURRENCYTableAdapter
        daCurrency.Update(InDataset)
    End Sub

    Public Function GetCSMasterDataset() As CSAccountDatabaseIntf.CSMasterDataset Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.GetCSMasterDataset
        CreatedsMasterDB()
        Return dsMasterDB
    End Function

    Public Sub LoadCSMasterDataset() Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSMasterDataset
        Dim daCompany As CSMasterDatasetTableAdapters.MST_COMPANYTableAdapter = New CSMasterDatasetTableAdapters.MST_COMPANYTableAdapter
        Dim daCurrency As CSMasterDatasetTableAdapters.MST_CURRENCYTableAdapter = New CSMasterDatasetTableAdapters.MST_CURRENCYTableAdapter
        Dim daAccount As CSMasterDatasetTableAdapters.MST_ACCOUNTTableAdapter = New CSMasterDatasetTableAdapters.MST_ACCOUNTTableAdapter
        CreatedsMasterDB()
        daCompany.Fill(dsMasterDB.MST_COMPANY)
        daCurrency.Fill(dsMasterDB.MST_CURRENCY)
        daAccount.Fill(dsMasterDB.MST_ACCOUNT)
    End Sub

    Public Sub LoadCSMasterDataset_Company() Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSMasterDataset_Company
        CreatedsMasterDB()
        Dim daCompany As CSMasterDatasetTableAdapters.MST_COMPANYTableAdapter = New CSMasterDatasetTableAdapters.MST_COMPANYTableAdapter
        daCompany.Fill(dsMasterDB.MST_COMPANY)
    End Sub

    Public Sub SaveCSMasterDataset(ByVal InDataset As CSAccountDatabaseIntf.CSMasterDataset) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveCSMasterDataset
        Dim daCompany As CSMasterDatasetTableAdapters.MST_COMPANYTableAdapter = New CSMasterDatasetTableAdapters.MST_COMPANYTableAdapter
        daCompany.Update(InDataset)
    End Sub

    Public Function GetCSBudgetDataset() As CSAccountDatabaseIntf.CSBudgetDataset Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.GetCSBudgetDataset
        CreatedsBudgetDB()
        Return dsBudgetDB
    End Function

    Public Sub LoadCSBudgetDataset(ByVal Acc_Year As Int16) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSBudgetDataset
        Dim daAccPeriod As CSBudgetDatasetTableAdapters.TRN_ACCPERIODTableAdapter = New CSBudgetDatasetTableAdapters.TRN_ACCPERIODTableAdapter
        Dim daAccount As CSBudgetDatasetTableAdapters.MST_ACCOUNTTableAdapter = New CSBudgetDatasetTableAdapters.MST_ACCOUNTTableAdapter
        Dim MyQuery As CSBudgetDatasetTableAdapters.QueriesTableAdapter = New CSBudgetDatasetTableAdapters.QueriesTableAdapter
        MyQuery.GenBudgetData(Acc_Year)
        CreatedsBudgetDB()
        daAccPeriod.Fill(dsBudgetDB.TRN_ACCPERIOD, Acc_Year)
        daAccount.Fill(dsBudgetDB.MST_ACCOUNT)
    End Sub

    Public Sub SaveCSBudgetDataset(ByVal InDataset As CSAccountDatabaseIntf.CSBudgetDataset) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveCSBudgetDataset
        Dim daAccPeriod As CSBudgetDatasetTableAdapters.TRN_ACCPERIODTableAdapter = New CSBudgetDatasetTableAdapters.TRN_ACCPERIODTableAdapter
        daAccPeriod.Update(InDataset)
    End Sub

    Public Sub CreatedsAccPayable()
        If dsAccPayableDB Is Nothing Then
            dsAccPayableDB = New CSAccPayableDataset
        End If
    End Sub

    Public Function GetCSAccPayableDataset() As CSAccountDatabaseIntf.CSAccPayableDataset Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.GetCSAccPayableDataset
        CreatedsAccPayable()
        Return dsAccPayableDB
    End Function

    Public Sub LoadCSAccPayableDataset() Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSAccPayableDataset
        CreatedsAccPayable()
        Dim daVendor As CSAccPayableDatasetTableAdapters.MST_VENDORTableAdapter = New CSAccPayableDatasetTableAdapters.MST_VENDORTableAdapter
        Dim daCurrency As CSAccPayableDatasetTableAdapters.MST_CURRENCYTableAdapter = New CSAccPayableDatasetTableAdapters.MST_CURRENCYTableAdapter
        Dim daCompany As CSAccPayableDatasetTableAdapters.MST_COMPANYTableAdapter = New CSAccPayableDatasetTableAdapters.MST_COMPANYTableAdapter
        daVendor.Fill(dsAccPayableDB.MST_VENDOR)
        daCurrency.Fill(dsAccPayableDB.MST_CURRENCY)
        daCompany.Fill(dsAccPayableDB.MST_COMPANY)
    End Sub

    Public Sub SaveCSAccPayableMasterDataset(ByVal InDataset As CSAccountDatabaseIntf.CSAccPayableDataset) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveCSAccPayableMasterDataset
        Dim daVendor As CSAccPayableDatasetTableAdapters.MST_VENDORTableAdapter = New CSAccPayableDatasetTableAdapters.MST_VENDORTableAdapter
        daVendor.Update(InDataset)
    End Sub

    Public Sub LoadCSAPInvDataset(ByVal StartDate As DateTime, ByVal EndDate As DateTime) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSAPInvDataset
        CreatedsAccPayable()
        Dim daCurrency As CSAccPayableDatasetTableAdapters.MST_CURRENCYTableAdapter = New CSAccPayableDatasetTableAdapters.MST_CURRENCYTableAdapter
        Dim daAccount As CSAccPayableDatasetTableAdapters.MST_ACCOUNTTableAdapter = New CSAccPayableDatasetTableAdapters.MST_ACCOUNTTableAdapter
        Dim daAPInv As CSAccPayableDatasetTableAdapters.TRN_APINVTableAdapter = New CSAccPayableDatasetTableAdapters.TRN_APINVTableAdapter
        Dim daAPInvD As CSAccPayableDatasetTableAdapters.TRN_APINVDTableAdapter = New CSAccPayableDatasetTableAdapters.TRN_APINVDTableAdapter
        Dim daVendor As CSAccPayableDatasetTableAdapters.MST_VENDORTableAdapter = New CSAccPayableDatasetTableAdapters.MST_VENDORTableAdapter
        Dim daCompany As CSAccPayableDatasetTableAdapters.MST_COMPANYTableAdapter = New CSAccPayableDatasetTableAdapters.MST_COMPANYTableAdapter
        Dim daAccType As CSAccPayableDatasetTableAdapters.SYS_ACCTYPETableAdapter = New CSAccPayableDatasetTableAdapters.SYS_ACCTYPETableAdapter

        daAccType.Fill(dsAccPayableDB.SYS_ACCTYPE)
        daCurrency.Fill(dsAccPayableDB.MST_CURRENCY)
        daAccount.Fill(dsAccPayableDB.MST_ACCOUNT)
        daVendor.Fill(dsAccPayableDB.MST_VENDOR)
        daCompany.Fill(dsAccPayableDB.MST_COMPANY)
        daAPInv.Fill(dsAccPayableDB.TRN_APINV, StartDate, EndDate)
        daAPInvD.Fill(dsAccPayableDB.TRN_APINVD, StartDate, EndDate)
    End Sub

    Public Sub SaveCSAPInvDataset(ByVal InDataset As CSAccountDatabaseIntf.CSAccPayableDataset) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveCSAPInvDataset
        Dim daAPInv As CSAccPayableDatasetTableAdapters.TRN_APINVTableAdapter = New CSAccPayableDatasetTableAdapters.TRN_APINVTableAdapter
        Dim daAPInvD As CSAccPayableDatasetTableAdapters.TRN_APINVDTableAdapter = New CSAccPayableDatasetTableAdapters.TRN_APINVDTableAdapter
        daAPInv.Update(InDataset.TRN_APINV.Select("", "", DataViewRowState.Added))
        daAPInvD.Update(InDataset.TRN_APINVD.Select("", "", DataViewRowState.Added))
        daAPInv.Update(InDataset.TRN_APINV.Select("", "", DataViewRowState.ModifiedCurrent))
        daAPInvD.Update(InDataset.TRN_APINVD.Select("", "", DataViewRowState.ModifiedCurrent))
        daAPInvD.Update(InDataset.TRN_APINVD.Select("", "", DataViewRowState.Deleted))
        daAPInv.Update(InDataset.TRN_APINV.Select("", "", DataViewRowState.Deleted))
    End Sub

    Public Sub LoadCSBankMasterDataset() Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSBankMasterDataset
        CreatedsMasterDB()
        Dim daAccount As CSMasterDatasetTableAdapters.MST_ACCOUNTTableAdapter = New CSMasterDatasetTableAdapters.MST_ACCOUNTTableAdapter
        Dim daBank As CSMasterDatasetTableAdapters.MST_BANKTableAdapter = New CSMasterDatasetTableAdapters.MST_BANKTableAdapter
        daAccount.Fill(dsMasterDB.MST_ACCOUNT)
        daBank.Fill(dsMasterDB.MST_BANK)
    End Sub

    Public Sub SaveCSBankMasterDataset(ByVal InDataset As CSAccountDatabaseIntf.CSMasterDataset) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveCSBankMasterDataset
        Dim daBank As CSMasterDatasetTableAdapters.MST_BANKTableAdapter = New CSMasterDatasetTableAdapters.MST_BANKTableAdapter
        daBank.Update(InDataset)
    End Sub

    Private dsCSAPChequeDataset As CSAPChequeDataset

    Sub CreateCSAPChequeDataset()
        If dsCSAPChequeDataset Is Nothing Then
            dsCSAPChequeDataset = New CSAPChequeDataset
        End If
    End Sub

    Public Function GetCSAPChequeDataset() As CSAccountDatabaseIntf.CSAPChequeDataset Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.GetCSAPChequeDataset
        CreateCSAPChequeDataset()
        Return dsCSAPChequeDataset
    End Function

    Public Sub LoadCSAPChequeDataset(ByVal StartDate As Date, ByVal EndDate As Date) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSAPChequeDataset
        Dim daCurrency As CSAPChequeDatasetTableAdapters.MST_CURRENCYTableAdapter = New CSAPChequeDatasetTableAdapters.MST_CURRENCYTableAdapter
        Dim daBank As CSAPChequeDatasetTableAdapters.MST_BANKTableAdapter = New CSAPChequeDatasetTableAdapters.MST_BANKTableAdapter
        Dim daVendor As CSAPChequeDatasetTableAdapters.MST_VENDORTableAdapter = New CSAPChequeDatasetTableAdapters.MST_VENDORTableAdapter
        Dim daAPInv As CSAPChequeDatasetTableAdapters.TRN_APINVTableAdapter = New CSAPChequeDatasetTableAdapters.TRN_APINVTableAdapter
        Dim daCheque As CSAPChequeDatasetTableAdapters.TRN_CHEQUETableAdapter = New CSAPChequeDatasetTableAdapters.TRN_CHEQUETableAdapter
        Dim daChequeD As CSAPChequeDatasetTableAdapters.TRN_CHEQUEDTableAdapter = New CSAPChequeDatasetTableAdapters.TRN_CHEQUEDTableAdapter
        Dim daCompany As CSAPChequeDatasetTableAdapters.MST_COMPANYTableAdapter = New CSAPChequeDatasetTableAdapters.MST_COMPANYTableAdapter
        CreateCSAPChequeDataset()
        daCurrency.Fill(dsCSAPChequeDataset.MST_CURRENCY)
        daBank.Fill(dsCSAPChequeDataset.MST_BANK)
        daVendor.Fill(dsCSAPChequeDataset.MST_VENDOR)
        daCompany.Fill(dsCSAPChequeDataset.MST_COMPANY)
        daAPInv.Fill(dsCSAPChequeDataset.TRN_APINV, StartDate, EndDate)
        daCheque.Fill(dsCSAPChequeDataset.TRN_CHEQUE, StartDate, EndDate)
        daChequeD.Fill(dsCSAPChequeDataset.TRN_CHEQUED, StartDate, EndDate)
    End Sub

    Public Sub SaveCSAPChequeDataset(ByVal InDataset As CSAccountDatabaseIntf.CSAPChequeDataset) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveCSAPChequeDataset
        Dim daCheque As CSAPChequeDatasetTableAdapters.TRN_CHEQUETableAdapter = New CSAPChequeDatasetTableAdapters.TRN_CHEQUETableAdapter
        Dim daChequeD As CSAPChequeDatasetTableAdapters.TRN_CHEQUEDTableAdapter = New CSAPChequeDatasetTableAdapters.TRN_CHEQUEDTableAdapter
        daCheque.Update(InDataset.TRN_CHEQUE.Select("", "", DataViewRowState.Added))
        daChequeD.Update(InDataset.TRN_CHEQUED.Select("", "", DataViewRowState.Added))
        daCheque.Update(InDataset.TRN_CHEQUE.Select("", "", DataViewRowState.ModifiedCurrent))
        daChequeD.Update(InDataset.TRN_CHEQUED.Select("", "", DataViewRowState.ModifiedCurrent))
        daChequeD.Update(InDataset.TRN_CHEQUED.Select("", "", DataViewRowState.Deleted))
        daCheque.Update(InDataset.TRN_CHEQUE.Select("", "", DataViewRowState.Deleted))
    End Sub


    Public Function CheckAPTranExists() As Boolean Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.CheckAPTranExists
        Dim daQuery As CSMasterDatasetTableAdapters.QueriesTableAdapter = New CSMasterDatasetTableAdapters.QueriesTableAdapter
        Dim DataExists As Nullable(Of Boolean)
        daQuery.CheckAPTranExists(DataExists)
        Return CBool(DataExists)
    End Function

    Public Function CheckAPPaymentExists(ByVal APINVNO As Integer) As Boolean Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.CheckAPPaymentExists
        Dim daQuery As CSAccPayableDatasetTableAdapters.QueriesTableAdapter = New CSAccPayableDatasetTableAdapters.QueriesTableAdapter
        Dim DataExists As Nullable(Of Boolean)
        daQuery.CheckAPPaymentExists(APINVNO, DataExists)
        Return CBool(DataExists)
    End Function

    Public Function CheckAPBankDetailExists(ByVal BANKNO As Integer) As Boolean Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.CheckAPBankDetailExists
        Dim daQuery As CSMasterDatasetTableAdapters.QueriesTableAdapter = New CSMasterDatasetTableAdapters.QueriesTableAdapter
        Dim DataExists As Nullable(Of Boolean)
        daQuery.CheckAPBankDetailsExists(BANKNO, DataExists)
        Return CBool(DataExists)
    End Function

    Public Sub LoadCSCustTypeMaster() Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSCustTypeMaster
        CreatedsMasterDB()
        Dim daCustType As CSMasterDatasetTableAdapters.MST_CUSTTYPETableAdapter = New CSMasterDatasetTableAdapters.MST_CUSTTYPETableAdapter
        daCustType.Fill(dsMasterDB.MST_CUSTTYPE)
    End Sub

    Public Sub SaveCSCustTypeMaster(ByVal InDataset As CSAccountDatabaseIntf.CSMasterDataset) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveCSCustTypeMaster
        Dim daCustType As CSMasterDatasetTableAdapters.MST_CUSTTYPETableAdapter = New CSMasterDatasetTableAdapters.MST_CUSTTYPETableAdapter
        daCustType.Update(InDataset)
    End Sub

    Public Function CheckCustTypeExists(ByVal CustType_Code As String) As Boolean Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.CheckCustTypeExists
        Dim daQuery As CSMasterDatasetTableAdapters.QueriesTableAdapter = New CSMasterDatasetTableAdapters.QueriesTableAdapter
        Dim DataExists As Nullable(Of Boolean)
        daQuery.CheckCustTypeExists(CustType_Code, DataExists)
        Return CBool(DataExists)
    End Function

    Public Function CheckSalesManExists(ByVal SALES_CODE As String) As Boolean Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.CheckSalesManExists
        Dim daQuery As CSMasterDatasetTableAdapters.QueriesTableAdapter = New CSMasterDatasetTableAdapters.QueriesTableAdapter
        Dim DataExists As Nullable(Of Boolean)
        daQuery.CheckSalesmanExists(SALES_CODE, DataExists)
        Return CBool(DataExists)
    End Function

    Public Sub LoadCSSalesManMaster() Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSSalesManMaster
        CreatedsMasterDB()
        Dim daSalesman As CSMasterDatasetTableAdapters.MST_SALESMANTableAdapter = New CSMasterDatasetTableAdapters.MST_SALESMANTableAdapter
        daSalesman.Fill(dsMasterDB.MST_SALESMAN)
    End Sub

    Public Sub SaveCSSalesManMaster(ByVal InDataset As CSAccountDatabaseIntf.CSMasterDataset) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveCSSalesManMaster
        Dim daSalesman As CSMasterDatasetTableAdapters.MST_SALESMANTableAdapter = New CSMasterDatasetTableAdapters.MST_SALESMANTableAdapter
        daSalesman.Update(InDataset)
    End Sub

    Public Function CheckTaxExists(ByVal TAX_CODE As String) As Boolean Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.CheckTaxExists
        Dim daQuery As CSMasterDatasetTableAdapters.QueriesTableAdapter = New CSMasterDatasetTableAdapters.QueriesTableAdapter
        Dim DataExists As Nullable(Of Boolean)
        daQuery.CheckTaxExists(TAX_CODE, DataExists)
        Return CBool(DataExists)
    End Function

    Public Sub LoadCSTaxMaster() Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSTaxMaster
        CreatedsMasterDB()
        Dim daTax As CSMasterDatasetTableAdapters.MST_TAXTableAdapter = New CSMasterDatasetTableAdapters.MST_TAXTableAdapter
        Dim daAccount As CSMasterDatasetTableAdapters.MST_ACCOUNTTableAdapter = New CSMasterDatasetTableAdapters.MST_ACCOUNTTableAdapter
        daAccount.Fill(dsMasterDB.MST_ACCOUNT)
        daTax.Fill(dsMasterDB.MST_TAX)
    End Sub

    Public Sub SaveCSTaxMaster(ByVal InDataset As CSAccountDatabaseIntf.CSMasterDataset) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveCSTaxMaster
        Dim daTax As CSMasterDatasetTableAdapters.MST_TAXTableAdapter = New CSMasterDatasetTableAdapters.MST_TAXTableAdapter
        daTax.Update(InDataset)
    End Sub

    Public Sub LoadCSCustomerMaster() Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSCustomerMaster
        CreatedsMasterDB()
        Dim daCurrency As CSMasterDatasetTableAdapters.MST_CURRENCYTableAdapter = New CSMasterDatasetTableAdapters.MST_CURRENCYTableAdapter
        Dim daSales As CSMasterDatasetTableAdapters.MST_SALESMANTableAdapter = New CSMasterDatasetTableAdapters.MST_SALESMANTableAdapter
        Dim daCustomer As CSMasterDatasetTableAdapters.MST_CUSTOMERTableAdapter = New CSMasterDatasetTableAdapters.MST_CUSTOMERTableAdapter
        Dim daCustType As CSMasterDatasetTableAdapters.MST_CUSTTYPETableAdapter = New CSMasterDatasetTableAdapters.MST_CUSTTYPETableAdapter
        Dim daTax As CSMasterDatasetTableAdapters.MST_TAXTableAdapter = New CSMasterDatasetTableAdapters.MST_TAXTableAdapter
        Dim daCompany As CSMasterDatasetTableAdapters.MST_COMPANYTableAdapter = New CSMasterDatasetTableAdapters.MST_COMPANYTableAdapter
        daCompany.Fill(dsMasterDB.MST_COMPANY)
        daCurrency.Fill(dsMasterDB.MST_CURRENCY)
        daSales.Fill(dsMasterDB.MST_SALESMAN)
        daCustomer.Fill(dsMasterDB.MST_CUSTOMER)
        daCustType.Fill(dsMasterDB.MST_CUSTTYPE)
        daTax.Fill(dsMasterDB.MST_TAX)
    End Sub

    Public Sub SaveCSCustomerMaster(ByVal InDataset As CSAccountDatabaseIntf.CSMasterDataset) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveCSCustomerMaster
        Dim daCustomer As CSMasterDatasetTableAdapters.MST_CUSTOMERTableAdapter = New CSMasterDatasetTableAdapters.MST_CUSTOMERTableAdapter
        daCustomer.Update(InDataset)
    End Sub

    Public Function CheckAPTranExistsByVendor(ByVal VENDOR_CODE As String) As Boolean Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.CheckAPTranExistsByVendor
        Dim daQuery As CSAccPayableDatasetTableAdapters.QueriesTableAdapter = New CSAccPayableDatasetTableAdapters.QueriesTableAdapter
        Dim DataExists As Nullable(Of Boolean)
        daQuery.CheckAPTranExistsByVendor(VENDOR_CODE, DataExists)
        Return CBool(DataExists)
    End Function

    Public Function CheckARTranExistsByCustomer(ByVal CUST_CODE As String) As Boolean Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.CheckARTranExistsByCustomer
        Dim QueryAdapter As CSMasterDatasetTableAdapters.QueriesTableAdapter = New CSMasterDatasetTableAdapters.QueriesTableAdapter
        Dim DataExists As Nullable(Of Boolean)
        QueryAdapter.CheckARTranExistsByCustomer(CUST_CODE, DataExists)
        Return CBool(DataExists)
    End Function

    Private dsCSAccReceivableDB As CSAccReceivableDataset

    Public Sub CreatedsAccReceivable()
        If dsCSAccReceivableDB Is Nothing Then
            dsCSAccReceivableDB = New CSAccReceivableDataset
        End If
    End Sub

    Public Function GetCSAccReceivableDataset() As CSAccountDatabaseIntf.CSAccReceivableDataset Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.GetCSAccReceivableDataset
        CreatedsAccReceivable()
        Return dsCSAccReceivableDB
    End Function

    Public Sub LoadCSAccReceivable(ByVal STARTDATE As DateTime, ByVal ENDDATE As DateTime) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSAccReceivable
        CreatedsAccReceivable()
        Dim daCurrency As CSAccReceivableDatasetTableAdapters.MST_CURRENCYTableAdapter = New CSAccReceivableDatasetTableAdapters.MST_CURRENCYTableAdapter
        Dim daCustomer As CSAccReceivableDatasetTableAdapters.MST_CUSTOMERTableAdapter = New CSAccReceivableDatasetTableAdapters.MST_CUSTOMERTableAdapter
        Dim daTax As CSAccReceivableDatasetTableAdapters.MST_TAXTableAdapter = New CSAccReceivableDatasetTableAdapters.MST_TAXTableAdapter
        Dim daARInv As CSAccReceivableDatasetTableAdapters.TRN_ARINVTableAdapter = New CSAccReceivableDatasetTableAdapters.TRN_ARINVTableAdapter
        Dim daARInvD As CSAccReceivableDatasetTableAdapters.TRN_ARINVDTableAdapter = New CSAccReceivableDatasetTableAdapters.TRN_ARINVDTableAdapter
        Dim daCompany As CSAccReceivableDatasetTableAdapters.MST_COMPANYTableAdapter = New CSAccReceivableDatasetTableAdapters.MST_COMPANYTableAdapter
        Dim daBank As CSAccReceivableDatasetTableAdapters.MST_BANKTableAdapter = New CSAccReceivableDatasetTableAdapters.MST_BANKTableAdapter
        daCurrency.Fill(dsCSAccReceivableDB.MST_CURRENCY)
        daCustomer.Fill(dsCSAccReceivableDB.MST_CUSTOMER)
        daTax.Fill(dsCSAccReceivableDB.MST_TAX)
        daCompany.Fill(dsCSAccReceivableDB.MST_COMPANY)
        daARInv.Fill(dsCSAccReceivableDB.TRN_ARINV, STARTDATE, ENDDATE)
        daARInvD.Fill(dsCSAccReceivableDB.TRN_ARINVD, STARTDATE, ENDDATE)
        daBank.Fill(dsCSAccReceivableDB.MST_BANK)
    End Sub

    Public Sub SaveCSAccReceivable(ByVal InDataset As CSAccountDatabaseIntf.CSAccReceivableDataset) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveCSAccReceivable
        Dim daARInv As CSAccReceivableDatasetTableAdapters.TRN_ARINVTableAdapter = New CSAccReceivableDatasetTableAdapters.TRN_ARINVTableAdapter
        Dim daARInvD As CSAccReceivableDatasetTableAdapters.TRN_ARINVDTableAdapter = New CSAccReceivableDatasetTableAdapters.TRN_ARINVDTableAdapter
        daARInv.Update(InDataset.TRN_ARINV.Select("", "", DataViewRowState.Added))
        daARInvD.Update(InDataset.TRN_ARINVD.Select("", "", DataViewRowState.Added))
        daARInv.Update(InDataset.TRN_ARINV.Select("", "", DataViewRowState.ModifiedCurrent))
        daARInvD.Update(InDataset.TRN_ARINVD.Select("", "", DataViewRowState.ModifiedCurrent))
        daARInvD.Update(InDataset.TRN_ARINVD.Select("", "", DataViewRowState.Deleted))
        daARInv.Update(InDataset.TRN_ARINV.Select("", "", DataViewRowState.Deleted))
    End Sub

    Public Function CheckARTranExists() As Boolean Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.CheckARTranExists
        Dim daQuery As CSMasterDatasetTableAdapters.QueriesTableAdapter = New CSMasterDatasetTableAdapters.QueriesTableAdapter
        Dim DataExists As Nullable(Of Boolean)
        daQuery.CheckARTranExists(DataExists)
        Return CBool(DataExists)
    End Function

    Public Function CheckARTranExistsByTax(ByVal TAX_CODE As String) As Boolean Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.CheckARTranExistsByTax
        Dim daQuery As CSMasterDatasetTableAdapters.QueriesTableAdapter = New CSMasterDatasetTableAdapters.QueriesTableAdapter
        Dim DataExists As Nullable(Of Boolean)
        daQuery.CheckARTranExistsByTax(TAX_CODE, DataExists)
        Return CBool(DataExists)
    End Function

    Public Function CheckARBankDetailExists(ByVal BANKNO As Integer) As Boolean Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.CheckARBankDetailExists
        Dim daQuery As CSARChequeDatasetTableAdapters.QueriesTableAdapter = New CSARChequeDatasetTableAdapters.QueriesTableAdapter
        Dim DataExists As Nullable(Of Boolean)
        daQuery.CheckARBankDetailsExists(BANKNO, DataExists)
        Return CBool(DataExists)
    End Function

    Public Function CheckARPaymentExists(ByVal APINVNO As Integer) As Boolean Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.CheckARPaymentExists
        Dim daQuery As CSARChequeDatasetTableAdapters.QueriesTableAdapter = New CSARChequeDatasetTableAdapters.QueriesTableAdapter
        Dim DataExists As Nullable(Of Boolean)
        daQuery.CheckARPaymentExists(APINVNO, DataExists)
        Return CBool(DataExists)
    End Function

    Private dsARChequeDB As CSARChequeDataset

    Public Sub CreatedsARChequeDB()
        If dsARChequeDB Is Nothing Then
            dsARChequeDB = New CSARChequeDataset
        End If
    End Sub

    Public Function GetCSARChequeDataset() As CSAccountDatabaseIntf.CSARChequeDataset Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.GetCSARChequeDataset
        CreatedsARChequeDB()
        Return dsARChequeDB
    End Function

    Public Sub LoadCSARChequeDataset(ByVal StartDate As Date, ByVal EndDate As Date) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSARChequeDataset
        Dim daBank As CSARChequeDatasetTableAdapters.MST_BANKTableAdapter = New CSARChequeDatasetTableAdapters.MST_BANKTableAdapter
        Dim daCompany As CSARChequeDatasetTableAdapters.MST_COMPANYTableAdapter = New CSARChequeDatasetTableAdapters.MST_COMPANYTableAdapter
        Dim daCurrency As CSARChequeDatasetTableAdapters.MST_CURRENCYTableAdapter = New CSARChequeDatasetTableAdapters.MST_CURRENCYTableAdapter
        Dim daCustomer As CSARChequeDatasetTableAdapters.MST_CUSTOMERTableAdapter = New CSARChequeDatasetTableAdapters.MST_CUSTOMERTableAdapter
        Dim daARINV As CSARChequeDatasetTableAdapters.TRN_ARINVTableAdapter = New CSARChequeDatasetTableAdapters.TRN_ARINVTableAdapter
        Dim daARCheque As CSARChequeDatasetTableAdapters.TRN_ARCHEQUETableAdapter = New CSARChequeDatasetTableAdapters.TRN_ARCHEQUETableAdapter
        Dim daARChequeD As CSARChequeDatasetTableAdapters.TRN_ARCHEQUEDTableAdapter = New CSARChequeDatasetTableAdapters.TRN_ARCHEQUEDTableAdapter
        CreatedsARChequeDB()
        daBank.Fill(dsARChequeDB.MST_BANK)
        daCompany.Fill(dsARChequeDB.MST_COMPANY)
        daCurrency.Fill(dsARChequeDB.MST_CURRENCY)
        daCustomer.Fill(dsARChequeDB.MST_CUSTOMER)
        daARINV.Fill(dsARChequeDB.TRN_ARINV, StartDate, EndDate)
        daARCheque.Fill(dsARChequeDB.TRN_ARCHEQUE, StartDate, EndDate)
        daARChequeD.Fill(dsARChequeDB.TRN_ARCHEQUED, StartDate, EndDate)
    End Sub

    Public Sub SaveCSARChequeDataset(ByVal InDataset As CSAccountDatabaseIntf.CSARChequeDataset) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveCSARChequeDataset
        Dim daARCheque As CSARChequeDatasetTableAdapters.TRN_ARCHEQUETableAdapter = New CSARChequeDatasetTableAdapters.TRN_ARCHEQUETableAdapter
        Dim daARChequeD As CSARChequeDatasetTableAdapters.TRN_ARCHEQUEDTableAdapter = New CSARChequeDatasetTableAdapters.TRN_ARCHEQUEDTableAdapter
        daARCheque.Update(InDataset.TRN_ARCHEQUE.Select("", "", DataViewRowState.Added))
        daARChequeD.Update(InDataset.TRN_ARCHEQUED.Select("", "", DataViewRowState.Added))
        daARCheque.Update(InDataset.TRN_ARCHEQUE.Select("", "", DataViewRowState.ModifiedCurrent))
        daARChequeD.Update(InDataset.TRN_ARCHEQUED.Select("", "", DataViewRowState.ModifiedCurrent))
        daARChequeD.Update(InDataset.TRN_ARCHEQUED.Select("", "", DataViewRowState.Deleted))
        daARCheque.Update(InDataset.TRN_ARCHEQUE.Select("", "", DataViewRowState.Deleted))
    End Sub

    Private dsReconDB As CSReconDataSet

    Private Sub CreatedsReconDB()
        If dsReconDB Is Nothing Then
            dsReconDB = New CSReconDataSet
        End If
    End Sub

    Public Function GetCSReconDataset() As CSAccountDatabaseIntf.CSReconDataSet Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.GetCSReconDataset
        CreatedsReconDB()
        Return dsReconDB
    End Function

    Public Sub LoadCSReconDataset(ByVal StartDate As Date, ByVal EndDate As Date, ByVal AccYear As Integer) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSReconDataset
        CreatedsReconDB()
        Dim daAccount As CSReconDataSetTableAdapters.MST_ACCOUNTTableAdapter = New CSReconDataSetTableAdapters.MST_ACCOUNTTableAdapter
        Dim daBank As CSReconDataSetTableAdapters.MST_BANKTableAdapter = New CSReconDataSetTableAdapters.MST_BANKTableAdapter
        Dim daRecon As CSReconDataSetTableAdapters.TRN_RECONTableAdapter = New CSReconDataSetTableAdapters.TRN_RECONTableAdapter
        daAccount.Fill(dsReconDB.MST_ACCOUNT)
        daBank.Fill(dsReconDB.MST_BANK)
        daRecon.Fill(dsReconDB.TRN_RECON, AccYear)
    End Sub

    Public Sub SaveCSReconDataset(ByVal InDataset As CSAccountDatabaseIntf.CSReconDataSet) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveCSReconDataset
        Dim daRecon As CSReconDataSetTableAdapters.TRN_RECONTableAdapter = New CSReconDataSetTableAdapters.TRN_RECONTableAdapter
        Dim daHistory As CSReconDataSetTableAdapters.TRN_ACCHISTORYTableAdapter = New CSReconDataSetTableAdapters.TRN_ACCHISTORYTableAdapter
        daRecon.Update(InDataset.TRN_RECON)
        daHistory.Update(InDataset.TRN_ACCHISTORY)
    End Sub

    Public Function LoadCSReconACCPeriod(ByVal AccYear As Integer, ByVal AccMonth As Integer, ByVal ACC_CODE As String) As CSAccountDatabaseIntf.CSReconDataSet.TRN_ACCPERIODDataTable Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSReconACCPeriod
        CreatedsReconDB()
        Dim daPeriod As CSReconDataSetTableAdapters.TRN_ACCPERIODTableAdapter = New CSReconDataSetTableAdapters.TRN_ACCPERIODTableAdapter
        daPeriod.Fill(dsReconDB.TRN_ACCPERIOD, CShort(AccYear), ACC_CODE)
        Return dsReconDB.TRN_ACCPERIOD
    End Function

    Public Function LoadCSReconHistory(ByVal AccYear As Integer, ByVal AccMonth As Integer, ByVal ACC_CODE As String) As CSAccountDatabaseIntf.CSReconDataSet.TRN_ACCHISTORYDataTable Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSReconHistory
        CreatedsReconDB()
        Dim daHistory As CSReconDataSetTableAdapters.TRN_ACCHISTORYTableAdapter = New CSReconDataSetTableAdapters.TRN_ACCHISTORYTableAdapter
        daHistory.Fill(dsReconDB.TRN_ACCHISTORY, CShort(AccYear), CByte(AccMonth), ACC_CODE)
        Return dsReconDB.TRN_ACCHISTORY
    End Function

    Public Function CheckAccExists(ByVal ACC_CODE As String) As Boolean Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.CheckAccExists
        Dim daQuery As CSGLDatasetTableAdapters.QueriesTableAdapter = New CSGLDatasetTableAdapters.QueriesTableAdapter
        Dim DataExists As Nullable(Of Boolean)
        daQuery.CheckAccExists(ACC_CODE, DataExists)
        Return CBool(DataExists)
    End Function

    Private dsAccRptDB As CSAccRptDataset

    Private Sub CreatedsAccRptDB()
        If dsAccRptDB Is Nothing Then
            dsAccRptDB = New CSAccRptDataset
        End If
    End Sub

    Public Function GetCSAccRptDataset() As CSAccountDatabaseIntf.CSAccRptDataset Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.GetCSAccRptDataset
        CreatedsAccRptDB()
        Return dsAccRptDB
    End Function

    Public Sub LoadCSAccRptDataset() Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSAccRptDataset
        Dim daAccount As CSAccRptDatasetTableAdapters.MST_ACCOUNTTableAdapter = New CSAccRptDatasetTableAdapters.MST_ACCOUNTTableAdapter
        Dim daAccReport As CSAccRptDatasetTableAdapters.MST_ACCREPORTTableAdapter = New CSAccRptDatasetTableAdapters.MST_ACCREPORTTableAdapter
        Dim daAccReportD As CSAccRptDatasetTableAdapters.MST_ACCREPORTDTableAdapter = New CSAccRptDatasetTableAdapters.MST_ACCREPORTDTableAdapter
        Dim daAccReportDD As CSAccRptDatasetTableAdapters.MST_ACCREPORTDDTableAdapter = New CSAccRptDatasetTableAdapters.MST_ACCREPORTDDTableAdapter
        Dim daAccTotal As CSAccRptDatasetTableAdapters.MST_ACCTOTALTableAdapter = New CSAccRptDatasetTableAdapters.MST_ACCTOTALTableAdapter
        Dim daTemplate As CSAccRptDatasetTableAdapters.MST_TEMPLATETableAdapter = New CSAccRptDatasetTableAdapters.MST_TEMPLATETableAdapter
        Dim daRptType As CSAccRptDatasetTableAdapters.SYS_RPTTYPETableAdapter = New CSAccRptDatasetTableAdapters.SYS_RPTTYPETableAdapter
        CreatedsAccRptDB()
        daAccount.Fill(dsAccRptDB.MST_ACCOUNT)
        daAccReport.Fill(dsAccRptDB.MST_ACCREPORT)
        daAccReportD.Fill(dsAccRptDB.MST_ACCREPORTD)
        daAccReportDD.Fill(dsAccRptDB.MST_ACCREPORTDD)
        daAccTotal.Fill(dsAccRptDB.MST_ACCTOTAL)
        daTemplate.Fill(dsAccRptDB.MST_TEMPLATE)
        daRptType.Fill(dsAccRptDB.SYS_RPTTYPE)
    End Sub

    Public Sub SaveCSAccRptDataset(ByVal InDataset As CSAccountDatabaseIntf.CSAccRptDataset) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveCSAccRptDataset
        Dim daAccReport As CSAccRptDatasetTableAdapters.MST_ACCREPORTTableAdapter = New CSAccRptDatasetTableAdapters.MST_ACCREPORTTableAdapter
        Dim daAccReportD As CSAccRptDatasetTableAdapters.MST_ACCREPORTDTableAdapter = New CSAccRptDatasetTableAdapters.MST_ACCREPORTDTableAdapter
        Dim daAccReportDD As CSAccRptDatasetTableAdapters.MST_ACCREPORTDDTableAdapter = New CSAccRptDatasetTableAdapters.MST_ACCREPORTDDTableAdapter
        Dim daAccTotal As CSAccRptDatasetTableAdapters.MST_ACCTOTALTableAdapter = New CSAccRptDatasetTableAdapters.MST_ACCTOTALTableAdapter
        daAccReport.Update(InDataset.MST_ACCREPORT.Select("", "", DataViewRowState.Added))
        daAccReportD.Update(InDataset.MST_ACCREPORTD.Select("", "", DataViewRowState.Added))
        daAccReportDD.Update(InDataset.MST_ACCREPORTDD.Select("", "", DataViewRowState.Added))
        daAccTotal.Update(InDataset.MST_ACCTOTAL.Select("", "", DataViewRowState.Added))
        daAccReport.Update(InDataset.MST_ACCREPORT.Select("", "", DataViewRowState.ModifiedCurrent))
        daAccReportD.Update(InDataset.MST_ACCREPORTD.Select("", "", DataViewRowState.ModifiedCurrent))
        daAccReportDD.Update(InDataset.MST_ACCREPORTDD.Select("", "", DataViewRowState.ModifiedCurrent))
        daAccTotal.Update(InDataset.MST_ACCTOTAL.Select("", "", DataViewRowState.ModifiedCurrent))
        daAccTotal.Update(InDataset.MST_ACCTOTAL.Select("", "", DataViewRowState.Deleted))
        daAccReportDD.Update(InDataset.MST_ACCREPORTDD.Select("", "", DataViewRowState.Deleted))
        daAccReportD.Update(InDataset.MST_ACCREPORTD.Select("", "", DataViewRowState.Deleted))
        daAccReport.Update(InDataset.MST_ACCREPORT.Select("", "", DataViewRowState.Deleted))
    End Sub

    Private dsAccReporting As CSAccReporting
    Private Sub CreateAccReporting()
        If dsAccReporting Is Nothing Then
            dsAccReporting = New CSAccReporting
        End If
    End Sub
    Public Function GetCSAccReporting() As CSAccountDatabaseIntf.CSAccReporting Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.GetCSAccReporting
        CreateAccReporting()
        Return dsAccReporting
    End Function

    Public Sub LoadCSAccReporting_ReportBLPL(ByVal ACCRPTNO As Integer, ByVal ACCYEAR As Integer, ByVal ACCMONTH As Integer, ByVal LASTYEAR As Integer, ByVal LASTMONTH As Integer) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSAccReporting_ReportBLPL
        CreateAccReporting()
        Dim daReportPL As CSAccReportingTableAdapters.ReportBLPLTableAdapter = New CSAccReportingTableAdapters.ReportBLPLTableAdapter
        daReportPL.Fill(dsAccReporting.ReportBLPL, ACCRPTNO, ACCYEAR, ACCMONTH, LASTYEAR, LASTMONTH)
    End Sub

    Public Sub LoadCSAccReporting_Master() Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSAccReporting_Master
        CreateAccReporting()
        Dim daVendor As CSAccReportingTableAdapters.MST_VENDORTableAdapter = New CSAccReportingTableAdapters.MST_VENDORTableAdapter
        Dim daCustomer As CSAccReportingTableAdapters.MST_CUSTOMERTableAdapter = New CSAccReportingTableAdapters.MST_CUSTOMERTableAdapter
        Dim daCompany As CSAccReportingTableAdapters.MST_COMPANYTableAdapter = New CSAccReportingTableAdapters.MST_COMPANYTableAdapter
        daVendor.Fill(dsAccReporting.MST_VENDOR)
        daCustomer.Fill(dsAccReporting.MST_CUSTOMER)
        daCompany.Fill(dsAccReporting.MST_COMPANY)
    End Sub

    Public Sub LoadCSAccReporting_TRN_APINV(ByVal StartCode As String, ByVal EndCode As String) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSAccReporting_TRN_APINV
        CreateAccReporting()
        If StartCode Is Nothing Then
            StartCode = ""
        End If
        If EndCode Is Nothing Then
            EndCode = ""
        End If
        Dim daAPInv As CSAccReportingTableAdapters.TRN_APINVTableAdapter = New CSAccReportingTableAdapters.TRN_APINVTableAdapter
        daAPInv.Fill(dsAccReporting.TRN_APINV, StartCode, EndCode)
    End Sub

    Public Sub LoadCSAccreporting_SMY_CUSTAGE(ByVal InToday As DateTime, ByVal StartCode As String, ByVal EndCode As String, ByVal InDate As DateTime) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSAccreporting_SMY_CUSTAGE
        CreateAccReporting()
        Dim daCustAge As CSAccReportingTableAdapters.SMY_CUSTAGETableAdapter = New CSAccReportingTableAdapters.SMY_CUSTAGETableAdapter
        If StartCode Is Nothing Then
            StartCode = ""
        End If

        If EndCode Is Nothing Then
            EndCode = ""
        End If
        daCustAge.Fill(dsAccReporting.SMY_CUSTAGE, InToday, StartCode, EndCode, InDate)
    End Sub

    Public Sub LoadCSAccReporting_Statement(ByVal InDate As Date, ByVal StartCode As String, ByVal EndCode As String) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSAccReporting_Statement
        CreateAccReporting()
        Dim daStatement As CSAccReportingTableAdapters.SMY_STATEMENTTableAdapter = New CSAccReportingTableAdapters.SMY_STATEMENTTableAdapter
        Dim daInvPayDetail As CSAccReportingTableAdapters.SMY_INVPAYDETAILTableAdapter = New CSAccReportingTableAdapters.SMY_INVPAYDETAILTableAdapter
        If StartCode Is Nothing Then
            StartCode = ""
        End If

        If EndCode Is Nothing Then
            EndCode = ""
        End If
        daStatement.Fill(dsAccReporting.SMY_STATEMENT, InDate, StartCode, EndCode)
        daInvPayDetail.Fill(dsAccReporting.SMY_INVPAYDETAIL, InDate, StartCode, EndCode)
    End Sub

    Public Sub LoadCSAccReporting_SMY_TRIAL_BALANCE(ByVal AccYear As Integer, ByVal AccMonth As Integer) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSAccReporting_SMY_TRIAL_BALANCE
        CreateAccReporting()
        Dim daTrialBalance As CSAccReportingTableAdapters.SMY_TRIAL_BALANCETableAdapter = New CSAccReportingTableAdapters.SMY_TRIAL_BALANCETableAdapter
        daTrialBalance.Fill(dsAccReporting.SMY_TRIAL_BALANCE, CShort(AccYear), CByte(AccMonth))
    End Sub

    Public Sub LoadCSAccReporting_StkTake(ByVal WHNO As Integer, ByVal ItemYear As Integer, ByVal ItemMonth As Integer) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSAccReporting_StkTake
        CreateAccReporting()
        Dim SKAdapter As CSAccReportingTableAdapters.STKTAKELISTTableAdapter = New CSAccReportingTableAdapters.STKTAKELISTTableAdapter
        SKAdapter.Fill(dsAccReporting.STKTAKELIST, WHNO, ItemYear, ItemMonth)
    End Sub

    Public Sub LoadCSAccReporting_WH() Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSAccReporting_WH
        Dim WHAdapter As CSAccReportingTableAdapters.MST_WAREHOUSETableAdapter = New CSAccReportingTableAdapters.MST_WAREHOUSETableAdapter
        CreateAccReporting()
        WHAdapter.Fill(dsAccReporting.MST_WAREHOUSE)
    End Sub

    Private dsSummaryDB As CSSummaryDataset
    Private Sub CreateSummaryDB()
        If dsSummaryDB Is Nothing Then
            dsSummaryDB = New CSSummaryDataset
        End If
    End Sub

    Public Function GetCSSummaryDataset() As CSAccountDatabaseIntf.CSSummaryDataset Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.GetCSSummaryDataset
        CreateSummaryDB()
        Return dsSummaryDB
    End Function

    Public Sub LoadCSSummaryDataset(ByVal FrYear As Integer, ByVal ToYear As Integer) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSSummaryDataset
        CreateSummaryDB()
        Dim daAccount As CSSummaryDatasetTableAdapters.MST_ACCOUNTTableAdapter = New CSSummaryDatasetTableAdapters.MST_ACCOUNTTableAdapter
        Dim daHistory As CSSummaryDatasetTableAdapters.TRN_ACCHISTORYTableAdapter = New CSSummaryDatasetTableAdapters.TRN_ACCHISTORYTableAdapter
        Dim daAccPeriod As CSSummaryDatasetTableAdapters.TRN_ACCPERIODTableAdapter = New CSSummaryDatasetTableAdapters.TRN_ACCPERIODTableAdapter
        Dim daAccType As CSSummaryDatasetTableAdapters.SYS_ACCTYPETableAdapter = New CSSummaryDatasetTableAdapters.SYS_ACCTYPETableAdapter
        daAccount.Fill(dsSummaryDB.MST_ACCOUNT)
        daHistory.Fill(dsSummaryDB.TRN_ACCHISTORY, CShort(FrYear), CShort(ToYear))
        daAccPeriod.Fill(dsSummaryDB.TRN_ACCPERIOD, CShort(FrYear), CShort(ToYear))
        daAccType.Fill(dsSummaryDB.SYS_ACCTYPE)
    End Sub

    Public Function CheckAccHistoryExists() As Boolean Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.CheckAccHistoryExists
        Dim daQuery As CSMasterDatasetTableAdapters.QueriesTableAdapter = New CSMasterDatasetTableAdapters.QueriesTableAdapter
        Dim DataExists As Nullable(Of Boolean)
        daQuery.CheckAccHistoryExists(DataExists)
        Return CBool(DataExists)
    End Function

    Public Sub CloseYear() Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.CloseYear
        Dim daQuery As CSMasterDatasetTableAdapters.QueriesTableAdapter = New CSMasterDatasetTableAdapters.QueriesTableAdapter
        daQuery.CLOSEYEAR()
    End Sub

    Public Function RunScript(ByVal StrFile As String, ByVal InCompName As String) As Boolean Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.RunScript
        Return SQLScriptEngine.RunScript(StrFile, InCompName)
    End Function

    Private CompDBPath As String
    Private Sub GetCompDBPath()
        CompDBPath = My.Settings.CompDBPath
    End Sub

    Public Sub New()
        Dim MyThread As Thread = New Thread(AddressOf GetCompDBPath)
        'This thread is used to pass settings to a variable, if direct pass
        'into the CompDBPath in this Sub, exception will occur
        MyThread.Start()
        While MyThread.IsAlive  'Loop till thread ends
        End While
        Dim InConn As String = ConfigurationManager.ConnectionStrings("CSAccountDatabaseIntf.My.MySettings.CSAccountDBConnectionString").ConnectionString
        Dim myregex As Regex = New Regex(";")
        Dim NewStr() As String = myregex.Split(InConn)
        Dim FinalStr As String = ""
        For Each NewConn As String In NewStr
            If Not NewConn.ToUpper.Contains("INITIAL CATALOG") Then
                FinalStr += NewConn + ";"
            End If
        Next
        SQLScriptEngine.SetupDatabase(FinalStr)
    End Sub

    Private dsCompsDBs As CompsDBs

    Private Sub CreateCompsDBs()
        If dsCompsDBs Is Nothing Then
            dsCompsDBs = New CSAccountDatabaseIntf.CompsDBs
        End If
    End Sub

    Public Function GetCompsDBs() As CSAccountDatabaseIntf.CompsDBs Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.GetCompsDBs
        Dim MyCrypto As CSSimpleCrypto = New CSSimpleCrypto
        CreateCompsDBs()
        dsCompsDBs.Clear()
        If File.Exists(CompDBPath + "CompsDBs.xml") Then
            dsCompsDBs.ReadXml(CompDBPath + "CompsDBs.xml")
        Else
            dsCompsDBs.AdminData.AddAdminDataRow(MyCrypto.Encrypt("ADMIN"), MyCrypto.Encrypt("ADMIN"))
        End If
        Return dsCompsDBs
    End Function

    Public Sub SaveCompsDBs(ByVal InDataset As CSAccountDatabaseIntf.CompsDBs) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveCompsDBs
        InDataset.WriteXml(CompDBPath + "CompsDBs.xml")
    End Sub

    Public Sub SetConnectionStr(ByVal InDatabase As String) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SetConnectionStr
        If InDatabase <> "" Then
            ShareData.DataBaseName = _
            ConfigurationManager.ConnectionStrings("CSAccountDatabaseIntf.My.MySettings.CSAccountDBConnectionString"). _
            ConnectionString.Replace("CSAccountDB", InDatabase)
            '"Data Source=.\SQLEXPRESS;Initial Catalog=TESTDATA1DB;Integrated Security=True"
        End If
    End Sub

    Public Function CloseScriptEngineDatabase() As Boolean Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.CloseScriptEngineDatabase
        Return SQLScriptEngine.CloseDatabase
    End Function

    Public Sub LoadCSAccReporting_InvoiceWithTax(ByVal StartDate As Date, ByVal EndDate As Date) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSAccReporting_InvoiceWithTax
        Dim daInvoice As CSAccReportingTableAdapters.InvoiceWithTaxTableAdapter = New CSAccReportingTableAdapters.InvoiceWithTaxTableAdapter
        CreateAccReporting()
        daInvoice.Fill(dsAccReporting.InvoiceWithTax, StartDate, EndDate)
    End Sub


    Private dsxxxDataset As CSAccountDatabaseIntf.DataSet1
    Private Sub CreatexxxDataset()
        If dsxxxDataset Is Nothing Then
            dsxxxDataset = New CSAccountDatabaseIntf.DataSet1
        End If
    End Sub

    Public Function GetxxxDataset() As CSAccountDatabaseIntf.DataSet1 Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.GetxxxDataset
        CreatexxxDataset()
        Return dsxxxDataset
    End Function

    Public Sub LoadxxxDataset() Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadxxxDataset
        Dim daAccount As CSAccountDatabaseIntf.DataSet1TableAdapters.MST_ACCOUNTTableAdapter = New CSAccountDatabaseIntf.DataSet1TableAdapters.MST_ACCOUNTTableAdapter
        CreatexxxDataset()
        daAccount.Fill(dsxxxDataset.MST_ACCOUNT)
    End Sub

    Public Sub SavexxxDataset(ByVal InDataset As CSAccountDatabaseIntf.DataSet1) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SavexxxDataset
        Dim daAccount As CSAccountDatabaseIntf.DataSet1TableAdapters.MST_ACCOUNTTableAdapter = New CSAccountDatabaseIntf.DataSet1TableAdapters.MST_ACCOUNTTableAdapter
        daAccount.Update(InDataset.MST_ACCOUNT)
    End Sub

    Private dsInvDataset As CSAccInvDataset
    Private Sub CreateAccInvDataset()
        If dsInvDataset Is Nothing Then
            dsInvDataset = New CSAccInvDataset
        End If
    End Sub

    Public Function GetCSInvDataset() As CSAccountDatabaseIntf.CSAccInvDataset Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.GetCSInvDataset
        CreateAccInvDataset()
        Return dsInvDataset
    End Function

    Public Sub LoadCSInvDataset_Class() Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSInvDataset_Class
        Dim Class1Adapter As CSAccInvDatasetTableAdapters.MST_CLASS1TableAdapter = New CSAccInvDatasetTableAdapters.MST_CLASS1TableAdapter
        Dim Class2Adapter As CSAccInvDatasetTableAdapters.MST_CLASS2TableAdapter = New CSAccInvDatasetTableAdapters.MST_CLASS2TableAdapter
        CreateAccInvDataset()
        Class1Adapter.Fill(dsInvDataset.MST_CLASS1)
        Class2Adapter.Fill(dsInvDataset.MST_CLASS2)
    End Sub

    Public Sub SaveCSInvDatset_Class(ByVal InDataset As CSAccountDatabaseIntf.CSAccInvDataset) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveCSInvDatset_Class
        Dim Class1Adapter As CSAccInvDatasetTableAdapters.MST_CLASS1TableAdapter = New CSAccInvDatasetTableAdapters.MST_CLASS1TableAdapter
        Dim Class2Adapter As CSAccInvDatasetTableAdapters.MST_CLASS2TableAdapter = New CSAccInvDatasetTableAdapters.MST_CLASS2TableAdapter
        Class1Adapter.Update(InDataset.MST_CLASS1)
        Class2Adapter.Update(InDataset.MST_CLASS2)
    End Sub

    Public Sub LoadCSInvDataset() Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSInvDataset
        CreateAccInvDataset()
        Dim ItemTypeAdapter As CSAccInvDatasetTableAdapters.MST_ITEM_TYPETableAdapter = New CSAccInvDatasetTableAdapters.MST_ITEM_TYPETableAdapter
        Dim WarehouseAdapter As CSAccInvDatasetTableAdapters.MST_WAREHOUSETableAdapter = New CSAccInvDatasetTableAdapters.MST_WAREHOUSETableAdapter
        Dim ItemAdapter As CSAccInvDatasetTableAdapters.MST_ITEMSTableAdapter = New CSAccInvDatasetTableAdapters.MST_ITEMSTableAdapter
        Dim AccAdapter As CSAccInvDatasetTableAdapters.MST_ACCOUNTTableAdapter = New CSAccInvDatasetTableAdapters.MST_ACCOUNTTableAdapter
        Dim ColorAdapter As CSAccInvDatasetTableAdapters.MST_ITMCOLORTableAdapter = New CSAccInvDatasetTableAdapters.MST_ITMCOLORTableAdapter
        Dim SizeAdapter As CSAccInvDatasetTableAdapters.MST_ITMSIZETableAdapter = New CSAccInvDatasetTableAdapters.MST_ITMSIZETableAdapter
        Dim ItmGrpAdapter As CSAccInvDatasetTableAdapters.MST_ITMGRPTableAdapter = New CSAccInvDatasetTableAdapters.MST_ITMGRPTableAdapter
        Dim Class1Adapter As CSAccInvDatasetTableAdapters.MST_CLASS1TableAdapter = New CSAccInvDatasetTableAdapters.MST_CLASS1TableAdapter
        Dim Class2Adapter As CSAccInvDatasetTableAdapters.MST_CLASS2TableAdapter = New CSAccInvDatasetTableAdapters.MST_CLASS2TableAdapter
        ColorAdapter.Fill(dsInvDataset.MST_ITMCOLOR)
        SizeAdapter.Fill(dsInvDataset.MST_ITMSIZE)
        ItemTypeAdapter.Fill(dsInvDataset.MST_ITEM_TYPE)
        WarehouseAdapter.Fill(dsInvDataset.MST_WAREHOUSE)
        ItemAdapter.Fill(dsInvDataset.MST_ITEMS)
        ItmGrpAdapter.Fill(dsInvDataset.MST_ITMGRP)
        AccAdapter.Fill(dsInvDataset.MST_ACCOUNT)
        Class1Adapter.Fill(dsInvDataset.MST_CLASS1)
        Class2Adapter.Fill(dsInvDataset.MST_CLASS2)
    End Sub

    Public Sub SaveCSInvDataset(ByVal InDataset As CSAccountDatabaseIntf.CSAccInvDataset) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveCSInvDataset
        CreateAccInvDataset()
        Dim ItemTypeAdapter As CSAccInvDatasetTableAdapters.MST_ITEM_TYPETableAdapter = New CSAccInvDatasetTableAdapters.MST_ITEM_TYPETableAdapter
        Dim WarehouseAdapter As CSAccInvDatasetTableAdapters.MST_WAREHOUSETableAdapter = New CSAccInvDatasetTableAdapters.MST_WAREHOUSETableAdapter
        Dim ItemAdapter As CSAccInvDatasetTableAdapters.MST_ITEMSTableAdapter = New CSAccInvDatasetTableAdapters.MST_ITEMSTableAdapter
        Dim ColorAdapter As CSAccInvDatasetTableAdapters.MST_ITMCOLORTableAdapter = New CSAccInvDatasetTableAdapters.MST_ITMCOLORTableAdapter
        Dim SizeAdapter As CSAccInvDatasetTableAdapters.MST_ITMSIZETableAdapter = New CSAccInvDatasetTableAdapters.MST_ITMSIZETableAdapter
        ColorAdapter.Update(InDataset)
        SizeAdapter.Update(InDataset)
        ItemTypeAdapter.Update(InDataset)
        WarehouseAdapter.Update(InDataset)
        ItemAdapter.Update(InDataset)
    End Sub

    Private dsInvRcv As CSInvRcvDataset
    Private Sub CreateInvRcv()
        If dsInvRcv Is Nothing Then
            dsInvRcv = New CSInvRcvDataset
        End If
    End Sub

    Public Function GetCSInvRcvDataset() As CSAccountDatabaseIntf.CSInvRcvDataset Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.GetCSInvRcvDataset
        CreateInvRcv()
        Return dsInvRcv
    End Function

    Public Sub LoadCSInvRcvDataset(ByVal StartDate As Date, ByVal EndDate As Date) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSInvRcvDataset
        CreateInvRcv()
        Dim ItemAdapter As CSInvRcvDatasetTableAdapters.MST_ITEMSTableAdapter = New CSInvRcvDatasetTableAdapters.MST_ITEMSTableAdapter
        Dim RCVAdapter As CSInvRcvDatasetTableAdapters.TRN_RCTableAdapter = New CSInvRcvDatasetTableAdapters.TRN_RCTableAdapter
        Dim RCVDAdapter As CSInvRcvDatasetTableAdapters.TRN_RCDTableAdapter = New CSInvRcvDatasetTableAdapters.TRN_RCDTableAdapter
        Dim WHAdapter As CSInvRcvDatasetTableAdapters.MST_WAREHOUSETableAdapter = New CSInvRcvDatasetTableAdapters.MST_WAREHOUSETableAdapter
        Dim VDAdapter As CSInvRcvDatasetTableAdapters.MST_VENDORTableAdapter = New CSInvRcvDatasetTableAdapters.MST_VENDORTableAdapter
        Dim CompAdapter As CSInvRcvDatasetTableAdapters.MST_COMPANYTableAdapter = New CSInvRcvDatasetTableAdapters.MST_COMPANYTableAdapter

        ItemAdapter.Fill(dsInvRcv.MST_ITEMS)
        WHAdapter.Fill(dsInvRcv.MST_WAREHOUSE)
        VDAdapter.Fill(dsInvRcv.MST_VENDOR)
        RCVAdapter.Fill(dsInvRcv.TRN_RC, StartDate, EndDate)
        RCVDAdapter.Fill(dsInvRcv.TRN_RCD, StartDate, EndDate)
        CompAdapter.Fill(dsInvRcv.MST_COMPANY)
    End Sub

    Public Sub SaveCSInvRcvDataset(ByVal InDataset As CSAccountDatabaseIntf.CSInvRcvDataset) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveCSInvRcvDataset
        Dim RCVAdapter As CSInvRcvDatasetTableAdapters.TRN_RCTableAdapter = New CSInvRcvDatasetTableAdapters.TRN_RCTableAdapter
        Dim RCVDAdapter As CSInvRcvDatasetTableAdapters.TRN_RCDTableAdapter = New CSInvRcvDatasetTableAdapters.TRN_RCDTableAdapter

        RCVAdapter.Update(InDataset.TRN_RC.Select("", "", DataViewRowState.Added))
        RCVDAdapter.Update(InDataset.TRN_RCD.Select("", "", DataViewRowState.Added))
        RCVAdapter.Update(InDataset.TRN_RC.Select("", "", DataViewRowState.ModifiedCurrent))
        RCVDAdapter.Update(InDataset.TRN_RCD.Select("", "", DataViewRowState.ModifiedCurrent))
        RCVDAdapter.Update(InDataset.TRN_RCD.Select("", "", DataViewRowState.Deleted))
        RCVAdapter.Update(InDataset.TRN_RC.Select("", "", DataViewRowState.Deleted))
    End Sub

    Private dsInvItem As CSInvItemDataset
    Private Sub CreateInvItemDataset()
        If dsInvItem Is Nothing Then
            dsInvItem = New CSInvItemDataset
        End If
    End Sub

    Public Function GetCSInvItemDataset() As CSAccountDatabaseIntf.CSInvItemDataset Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.GetCSInvItemDataset
        CreateInvItemDataset()
        Return dsInvItem
    End Function

    Public Sub LoadCSInvItemDataset() Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSInvItemDataset
        CreateInvItemDataset()
        Dim ItemAdapter As CSInvItemDatasetTableAdapters.MST_ITEMSTableAdapter = New CSInvItemDatasetTableAdapters.MST_ITEMSTableAdapter
        ItemAdapter.Fill(dsInvItem.MST_ITEMS)
    End Sub

    Public Sub LoadCSInvItemDataset_ItmGrp() Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSInvItemDataset_ItmGrp
        CreateInvItemDataset()
        Dim ItmGrpAdapter As CSInvItemDatasetTableAdapters.MST_ITMGRPTableAdapter = New CSInvItemDatasetTableAdapters.MST_ITMGRPTableAdapter
        ItmGrpAdapter.Fill(dsInvItem.MST_ITMGRP)
    End Sub


    Public Function CheckRCExists(ByVal TRAN_CODE As String, ByVal RCNO As Integer) As Boolean Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.CheckRCExists
        Dim RCAdapter As CSInvRcvDatasetTableAdapters.CheckRCExistsTableAdapter = New CSInvRcvDatasetTableAdapters.CheckRCExistsTableAdapter
        CreateInvRcv()
        dsInvRcv.CheckRCExists.Clear()
        RCAdapter.Fill(dsInvRcv.CheckRCExists, TRAN_CODE, RCNO)
        Return dsInvRcv.CheckRCExists.Count > 0
    End Function

    Public Function CheckARInvExists(ByVal INVOICENO As String, ByVal ARINVNO As Integer) As Boolean Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.CheckARInvExists
        Dim ARAdapter As CSAccReceivableDatasetTableAdapters.CheckARInvExistsTableAdapter = New CSAccReceivableDatasetTableAdapters.CheckARInvExistsTableAdapter
        CreatedsAccReceivable()
        dsCSAccReceivableDB.CheckARInvExists.Clear()
        ARAdapter.Fill(dsCSAccReceivableDB.CheckARInvExists, INVOICENO, ARINVNO)
        Return dsCSAccReceivableDB.CheckARInvExists.Count > 0
    End Function

    Public Function CheckAPInvExists(ByVal INVOICENO As String, ByVal APINVNO As Integer) As Boolean Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.CheckAPInvExists
        Dim APAdapter As CSAccPayableDatasetTableAdapters.CheckAPInvExistsTableAdapter = New CSAccPayableDatasetTableAdapters.CheckAPInvExistsTableAdapter
        CreatedsAccPayable()
        dsAccPayableDB.CheckAPInvExists.Clear()
        APAdapter.Fill(dsAccPayableDB.CheckAPInvExists, INVOICENO, APINVNO)
        Return dsAccPayableDB.CheckAPInvExists.Count > 0
    End Function

    Public Function CheckCurrencyExists(ByVal CURR_CODE As String) As Boolean Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.CheckCurrencyExists
        Dim QueryAdapter As CSGLDatasetTableAdapters.QueriesTableAdapter = New CSGLDatasetTableAdapters.QueriesTableAdapter
        Dim DataExists As Nullable(Of Integer)
        QueryAdapter.CheckCurrencyExists(CURR_CODE, DataExists)
        Return CInt(DataExists) > 0
    End Function

    Private dsInvDODataset As CSInvDODataset
    Private Sub CreateInvDODataset()
        If dsInvDODataset Is Nothing Then
            dsInvDODataset = New CSInvDODataset
        End If
    End Sub
    Public Function GetCSInvDODataset() As CSAccountDatabaseIntf.CSInvDODataset Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.GetCSInvDODataset
        CreateInvDODataset()
        Return dsInvDODataset
    End Function

    Public Sub LoadCSInvDODataset(ByVal StartDate As Date, ByVal EndDate As Date) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSInvDODataset
        Dim ItemAdapter As CSInvDODatasetTableAdapters.MST_ITEMSTableAdapter = New CSInvDODatasetTableAdapters.MST_ITEMSTableAdapter
        Dim DOAdapter As CSInvDODatasetTableAdapters.TRN_DOTableAdapter = New CSInvDODatasetTableAdapters.TRN_DOTableAdapter
        Dim DODAdapter As CSInvDODatasetTableAdapters.TRN_DODTableAdapter = New CSInvDODatasetTableAdapters.TRN_DODTableAdapter
        Dim WHAdapter As CSInvDODatasetTableAdapters.MST_WAREHOUSETableAdapter = New CSInvDODatasetTableAdapters.MST_WAREHOUSETableAdapter
        Dim CustAdapter As CSInvDODatasetTableAdapters.MST_CUSTOMERTableAdapter = New CSInvDODatasetTableAdapters.MST_CUSTOMERTableAdapter
        CreateInvDODataset()
        ItemAdapter.Fill(dsInvDODataset.MST_ITEMS)
        DOAdapter.Fill(dsInvDODataset.TRN_DO, StartDate, EndDate)
        DODAdapter.Fill(dsInvDODataset.TRN_DOD, StartDate, EndDate)
        WHAdapter.Fill(dsInvDODataset.MST_WAREHOUSE)
        CustAdapter.Fill(dsInvDODataset.MST_CUSTOMER)
    End Sub

    Public Sub SaveCSInvDODataset(ByVal InDataset As CSAccountDatabaseIntf.CSInvDODataset) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveCSInvDODataset
        Dim DOAdapter As CSInvDODatasetTableAdapters.TRN_DOTableAdapter = New CSInvDODatasetTableAdapters.TRN_DOTableAdapter
        Dim DODAdapter As CSInvDODatasetTableAdapters.TRN_DODTableAdapter = New CSInvDODatasetTableAdapters.TRN_DODTableAdapter
        DOAdapter.Update(InDataset.TRN_DO.Select("", "", DataViewRowState.Added))
        DODAdapter.Update(InDataset.TRN_DOD.Select("", "", DataViewRowState.Added))
        DOAdapter.Update(InDataset.TRN_DO.Select("", "", DataViewRowState.ModifiedCurrent))
        DODAdapter.Update(InDataset.TRN_DOD.Select("", "", DataViewRowState.ModifiedCurrent))
        DODAdapter.Update(InDataset.TRN_DOD.Select("", "", DataViewRowState.Deleted))
        DOAdapter.Update(InDataset.TRN_DO.Select("", "", DataViewRowState.Deleted))
    End Sub

    Public Function CheckDOExists(ByVal Tran_Code As String, ByVal DONO As Integer) As Boolean Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.CheckDOExists
        Dim DOAdapter As CSInvDODatasetTableAdapters.CheckDOExistsTableAdapter = New CSInvDODatasetTableAdapters.CheckDOExistsTableAdapter
        CreateInvDODataset()
        dsInvDODataset.CheckDOExists.Clear()
        DOAdapter.Fill(dsInvDODataset.CheckDOExists, Tran_Code, DONO)
        Return dsInvDODataset.CheckDOExists.Count > 0
    End Function

    Public Function CheckCBExists(ByVal Tran_Code As String, ByVal CBNO As Integer) As Boolean Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.CheckCBExists
        Dim CBAdapter As CSInvCashBillDatasetTableAdapters.CheckCASHBILLExistsTableAdapter = New CSInvCashBillDatasetTableAdapters.CheckCASHBILLExistsTableAdapter
        CreateCashBillDataset()
        dsCashBillDataset.CheckCASHBILLExists.Clear()
        CBAdapter.Fill(dsCashBillDataset.CheckCASHBILLExists, Tran_Code, CBNO)
        Return dsCashBillDataset.CheckCASHBILLExists.Count > 0
    End Function

    Public Function CheckDTOExists(ByVal Tran_Code As String, ByVal DTONO As Integer) As Boolean Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.CheckDTOExists
        Dim DTOAdapter As CSPOSDTODatasetTableAdapters.CheckDTOExistsTableAdapter = New CSPOSDTODatasetTableAdapters.CheckDTOExistsTableAdapter
        CreateCSPOSDTODataset()
        dsPOSDTODataset.CheckDTOExists.Clear()
        DTOAdapter.Fill(dsPOSDTODataset.CheckDTOExists, DTONO, Tran_Code)
        Return dsPOSDTODataset.CheckDTOExists.Count > 0
    End Function


    Public Function CheckAJExists(ByVal Tran_Code As String, ByVal AJNO As Integer) As Boolean Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.CheckAJExists
        Dim AJAdapter As CSInvAJDatasetTableAdapters.CheckAJExistsTableAdapter = New CSInvAJDatasetTableAdapters.CheckAJExistsTableAdapter
        CreateInvAJDataset()
        dsAJDataset.CheckAJExists.Clear()
        AJAdapter.Fill(dsAJDataset.CheckAJExists, AJNO, Tran_Code)
        Return dsAJDataset.CheckAJExists.Count > 0
    End Function

    Private dsAJDataset As CSInvAJDataset
    Private Sub CreateInvAJDataset()
        If dsAJDataset Is Nothing Then
            dsAJDataset = New CSInvAJDataset
        End If
    End Sub

    Public Function GetCSInvAJDataset() As CSAccountDatabaseIntf.CSInvAJDataset Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.GetCSInvAJDataset
        CreateInvAJDataset()
        Return dsAJDataset
    End Function

    Public Sub LoadCSInvAJDataset(ByVal StartDate As Date, ByVal EndDate As Date) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSInvAJDataset
        Dim ItemAdapter As CSInvAJDatasetTableAdapters.MST_ITEMSTableAdapter = New CSInvAJDatasetTableAdapters.MST_ITEMSTableAdapter
        Dim AJAdapter As CSInvAJDatasetTableAdapters.TRN_AJTableAdapter = New CSInvAJDatasetTableAdapters.TRN_AJTableAdapter
        Dim AJDAdapter As CSInvAJDatasetTableAdapters.TRN_AJDTableAdapter = New CSInvAJDatasetTableAdapters.TRN_AJDTableAdapter
        Dim WHAdapter As CSInvAJDatasetTableAdapters.MST_WAREHOUSETableAdapter = New CSInvAJDatasetTableAdapters.MST_WAREHOUSETableAdapter
        CreateInvAJDataset()
        ItemAdapter.Fill(dsAJDataset.MST_ITEMS)
        AJAdapter.Fill(dsAJDataset.TRN_AJ, StartDate, EndDate)
        AJDAdapter.Fill(dsAJDataset.TRN_AJD, StartDate, EndDate)
        WHAdapter.Fill(dsAJDataset.MST_WAREHOUSE)
    End Sub

    Public Sub SaveCSInvAJDataset(ByVal InDataset As CSAccountDatabaseIntf.CSInvAJDataset) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveCSInvAJDataset
        Dim AJAdapter As CSInvAJDatasetTableAdapters.TRN_AJTableAdapter = New CSInvAJDatasetTableAdapters.TRN_AJTableAdapter
        Dim AJDAdapter As CSInvAJDatasetTableAdapters.TRN_AJDTableAdapter = New CSInvAJDatasetTableAdapters.TRN_AJDTableAdapter
        AJAdapter.Update(InDataset.TRN_AJ.Select("", "", DataViewRowState.Added))
        AJDAdapter.Update(InDataset.TRN_AJD.Select("", "", DataViewRowState.Added))
        AJAdapter.Update(InDataset.TRN_AJ.Select("", "", DataViewRowState.ModifiedCurrent))
        AJDAdapter.Update(InDataset.TRN_AJD.Select("", "", DataViewRowState.ModifiedCurrent))
        AJDAdapter.Update(InDataset.TRN_AJD.Select("", "", DataViewRowState.Deleted))
        AJAdapter.Update(InDataset.TRN_AJ.Select("", "", DataViewRowState.Deleted))
    End Sub

    Private dsInvReport As CSInvReport
    Private Sub CreateInvReport()
        If dsInvReport Is Nothing Then
            dsInvReport = New CSInvReport
        End If
    End Sub

    Public Function GetInvReport() As CSAccountDatabaseIntf.CSInvReport Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.GetInvReport
        CreateInvReport()
        Return dsInvReport
    End Function

    Public Sub LoadInvReport_AJ(ByVal StartDate As Date, ByVal EndDate As Date) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadInvReport_AJ
        Dim AJAdapter As CSInvReportTableAdapters.TRN_AJTableAdapter = New CSInvReportTableAdapters.TRN_AJTableAdapter
        CreateInvReport()
        AJAdapter.Fill(dsInvReport.TRN_AJ, StartDate, EndDate)
    End Sub

    Public Sub LoadInvReport_DO(ByVal StartDate As Date, ByVal EndDate As Date) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadInvReport_DO
        Dim DOAdapter As CSInvReportTableAdapters.TRN_DOTableAdapter = New CSInvReportTableAdapters.TRN_DOTableAdapter
        CreateInvReport()
        DOAdapter.Fill(dsInvReport.TRN_DO, StartDate, EndDate)
    End Sub

    Public Sub LoadInvReport_RC(ByVal StartDate As Date, ByVal EndDate As Date) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadInvReport_RC
        Dim RCAdapter As CSInvReportTableAdapters.TRN_RCTableAdapter = New CSInvReportTableAdapters.TRN_RCTableAdapter
        CreateInvReport()
        RCAdapter.Fill(dsInvReport.TRN_RC, StartDate, EndDate)
    End Sub

    Public Sub LoadInvReport_PrintDO(ByVal DONO As Integer) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadInvReport_PrintDO
        Dim PrintDOAdapter As CSInvReportTableAdapters.PrintDOTableAdapter = New CSInvReportTableAdapters.PrintDOTableAdapter
        Dim PrintDODAdapter As CSInvReportTableAdapters.PrintDODTableAdapter = New CSInvReportTableAdapters.PrintDODTableAdapter
        Dim CompAdapter As CSInvReportTableAdapters.MST_COMPANYTableAdapter = New CSInvReportTableAdapters.MST_COMPANYTableAdapter
        CreateInvReport()
        PrintDOAdapter.Fill(dsInvReport.PrintDO, DONO)
        PrintDODAdapter.Fill(dsInvReport.PrintDOD, DONO)
        CompAdapter.Fill(dsInvReport.MST_COMPANY)
    End Sub

    Private dsInvSummary As CSInvSummaryDataset
    Private Sub CreateInvSummaryDataset()
        If dsInvSummary Is Nothing Then
            dsInvSummary = New CSInvSummaryDataset
        End If
    End Sub

    Public Function GetInvSummaryDataset() As CSAccountDatabaseIntf.CSInvSummaryDataset Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.GetInvSummaryDataset
        CreateInvSummaryDataset()
        Return dsInvSummary
    End Function

    Public Sub LoadInvSummaryDataset_Bal(ByVal ItemYear As Integer, ByVal WHNO As Integer) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadInvSummaryDataset_Bal
        Dim BalAdapter As CSInvSummaryDatasetTableAdapters.TRN_ITEM_BALTableAdapter = New CSInvSummaryDatasetTableAdapters.TRN_ITEM_BALTableAdapter
        CreateInvSummaryDataset()
        BalAdapter.Fill(dsInvSummary.TRN_ITEM_BAL, ItemYear, WHNO)
    End Sub

    Public Sub LoadInvSummaryDataset_WH() Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadInvSummaryDataset_WH
        CreateInvSummaryDataset()
        Dim WHAdapter As CSInvSummaryDatasetTableAdapters.MST_WAREHOUSETableAdapter = New CSInvSummaryDatasetTableAdapters.MST_WAREHOUSETableAdapter
        WHAdapter.Fill(dsInvSummary.MST_WAREHOUSE)
    End Sub

    Public Sub LoadInvSummaryDataset_His(ByVal Inv_Year As Integer, ByVal WHNO As Integer, ByVal WHNO1 As Integer, ByVal Item_NO As Integer) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadInvSummaryDataset_His
        CreateInvSummaryDataset()
        Dim HisAdapter As CSInvSummaryDatasetTableAdapters.TRN_ITMHISTORYTableAdapter = New CSInvSummaryDatasetTableAdapters.TRN_ITMHISTORYTableAdapter
        HisAdapter.Fill(dsInvSummary.TRN_ITMHISTORY, WHNO, Inv_Year, WHNO1, Item_NO)
    End Sub

    Public Function CheckItemExists(ByVal Item_No As Integer) As Boolean Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.CheckItemExists
        Dim QueryAdapter As CSAccInvDatasetTableAdapters.QueriesTableAdapter = New CSAccInvDatasetTableAdapters.QueriesTableAdapter
        Dim DataExists As Nullable(Of Boolean)
        QueryAdapter.CheckItemExists(Item_No, DataExists)
        Return CBool(DataExists)
    End Function

    Public Sub LoadCSInvDataset_ItmGrp() Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSInvDataset_ItmGrp
        Dim ItmGrpAdapter As CSAccInvDatasetTableAdapters.MST_ITMGRPTableAdapter = New CSAccInvDatasetTableAdapters.MST_ITMGRPTableAdapter
        CreateAccInvDataset()
        ItmGrpAdapter.Fill(dsInvDataset.MST_ITMGRP)
    End Sub

    Public Sub SaveCSInvDataset_ItmGrp(ByVal InDataset As CSAccountDatabaseIntf.CSAccInvDataset) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveCSInvDataset_ItmGrp
        Dim ItmGrpAdapter As CSAccInvDatasetTableAdapters.MST_ITMGRPTableAdapter = New CSAccInvDatasetTableAdapters.MST_ITMGRPTableAdapter
        ItmGrpAdapter.Update(InDataset)
    End Sub

    Public Function CheckItemExistsByItmGrp(ByVal ItmGrp_Code As String) As Boolean Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.CheckItemExistsByItmGrp
        Dim CheckExistsAdapter As CSAccInvDatasetTableAdapters.CheckItemExistsByItmGrpTableAdapter = New CSAccInvDatasetTableAdapters.CheckItemExistsByItmGrpTableAdapter
        CreateAccInvDataset()
        CheckExistsAdapter.Fill(dsInvDataset.CheckItemExistsByItmGrp, ItmGrp_Code)
        If dsInvDataset.CheckItemExistsByItmGrp.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function CheckItemExistsByColor(ByVal Color_code As String) As Boolean Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.CheckItemExistsByColor
        Dim CheckExistsAdapter As CSAccInvDatasetTableAdapters.CheckItemExistsByColorTableAdapter = New CSAccInvDatasetTableAdapters.CheckItemExistsByColorTableAdapter
        CreateAccInvDataset()
        CheckExistsAdapter.Fill(dsInvDataset.CheckItemExistsByColor, Color_code)
        If dsInvDataset.CheckItemExistsByColor.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function CheckItemExistsBySize(ByVal Size_Code As String) As Boolean Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.CheckItemExistsBySize
        Dim CheckExistsAdapter As CSAccInvDatasetTableAdapters.CheckItemExistsBySizeTableAdapter = New CSAccInvDatasetTableAdapters.CheckItemExistsBySizeTableAdapter
        CreateAccInvDataset()
        CheckExistsAdapter.Fill(dsInvDataset.CheckItemExistsBySize, Size_Code)
        If dsInvDataset.CheckItemExistsBySize.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Function CheckItmHistoryExistsByWarehouse(ByVal WHNO As Integer) As Boolean Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.CheckItmHistoryExistsByWarehouse
        Dim CheckExistsAdapter As CSAccInvDatasetTableAdapters.CheckItmHistoryExistsByWarehouseTableAdapter = _
        New CSAccInvDatasetTableAdapters.CheckItmHistoryExistsByWarehouseTableAdapter
        CreateAccInvDataset()
        CheckExistsAdapter.Fill(dsInvDataset.CheckItmHistoryExistsByWarehouse, WHNO)
        If dsInvDataset.CheckItmHistoryExistsByWarehouse.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private dsPOSDTODataset As CSPOSDTODataset = Nothing
    Private Sub CreateCSPOSDTODataset()
        If dsPOSDTODataset Is Nothing Then
            dsPOSDTODataset = New CSPOSDTODataset
        End If
    End Sub

    Public Function GetCSPOSDTODataset() As CSAccountDatabaseIntf.CSPOSDTODataset Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.GetCSPOSDTODataset
        CreateCSPOSDTODataset()
        Return dsPOSDTODataset
    End Function

    Public Sub LoadCSPOSDTODataset(ByVal StartDate As DateTime, ByVal Enddate As DateTime) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSPOSDTODataset
        Dim WHAdapter As CSPOSDTODatasetTableAdapters.MST_WAREHOUSETableAdapter = New CSPOSDTODatasetTableAdapters.MST_WAREHOUSETableAdapter
        Dim DTOAdapter As CSPOSDTODatasetTableAdapters.TRN_DTOTableAdapter = New CSPOSDTODatasetTableAdapters.TRN_DTOTableAdapter
        Dim DTODAdapter As CSPOSDTODatasetTableAdapters.TRN_DTODTableAdapter = New CSPOSDTODatasetTableAdapters.TRN_DTODTableAdapter
        Dim DTOWHAdapter As CSPOSDTODatasetTableAdapters.TRN_DTOWHTableAdapter = New CSPOSDTODatasetTableAdapters.TRN_DTOWHTableAdapter
        Dim ItemAdapter As CSPOSDTODatasetTableAdapters.MST_ITEMSTableAdapter = New CSPOSDTODatasetTableAdapters.MST_ITEMSTableAdapter
        Dim ItmGrpAdapter As CSPOSDTODatasetTableAdapters.MST_ITMGRPTableAdapter = New CSPOSDTODatasetTableAdapters.MST_ITMGRPTableAdapter
        CreateCSPOSDTODataset()
        WHAdapter.Fill(dsPOSDTODataset.MST_WAREHOUSE)
        DTOAdapter.Fill(dsPOSDTODataset.TRN_DTO, StartDate, Enddate)
        DTODAdapter.Fill(dsPOSDTODataset.TRN_DTOD, StartDate, Enddate)
        DTOWHAdapter.Fill(dsPOSDTODataset.TRN_DTOWH, StartDate, Enddate)
        ItemAdapter.Fill(dsPOSDTODataset.MST_ITEMS)
        ItmGrpAdapter.Fill(dsPOSDTODataset.MST_ITMGRP)
    End Sub


    Public Sub SaveCSPOSDTODataset(ByVal InDataset As CSPOSDTODataset) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveCSPOSDTODataset
        Dim TRN_DTOAdapter As CSPOSDTODatasetTableAdapters.TRN_DTOTableAdapter = New CSPOSDTODatasetTableAdapters.TRN_DTOTableAdapter
        Dim TRN_DTODAdapter As CSPOSDTODatasetTableAdapters.TRN_DTODTableAdapter = New CSPOSDTODatasetTableAdapters.TRN_DTODTableAdapter
        Dim TRN_DTOWHAdapter As CSPOSDTODatasetTableAdapters.TRN_DTOWHTableAdapter = New CSPOSDTODatasetTableAdapters.TRN_DTOWHTableAdapter
        Dim MyTransaction As System.Data.SqlClient.SqlTransaction
        TRN_DTOAdapter.Connection.Open()
        MyTransaction = TRN_DTOAdapter.Connection.BeginTransaction
        TRN_DTOAdapter.SetCommandsTransaction(TRN_DTOAdapter.Connection, MyTransaction)
        TRN_DTODAdapter.SetCommandsTransaction(TRN_DTOAdapter.Connection, MyTransaction)
        TRN_DTOWHAdapter.SetCommandsTransaction(TRN_DTOAdapter.Connection, MyTransaction)
        Try
            Dim InsTRN_DTOData() As DataRow = InDataset.TRN_DTO.Select("", "", DataViewRowState.Added)
            If InsTRN_DTOData.Length > 0 Then
                TRN_DTOAdapter.Update(InsTRN_DTOData)
            End If

            Dim InsTRN_DTOWHData() As DataRow = InDataset.TRN_DTOWH.Select("", "", DataViewRowState.Added)
            If InsTRN_DTOWHData.Length > 0 Then
                TRN_DTOWHAdapter.Update(InsTRN_DTOWHData)
            End If

            Dim InsTRN_DTODData() As DataRow = InDataset.TRN_DTOD.Select("", "", DataViewRowState.Added)
            If InsTRN_DTODData.Length > 0 Then
                TRN_DTODAdapter.Update(InsTRN_DTODData)
            End If

            Dim ModTRN_DTOData() As DataRow = InDataset.TRN_DTO.Select("", "", DataViewRowState.ModifiedCurrent)
            If ModTRN_DTOData.Length > 0 Then
                TRN_DTOAdapter.Update(ModTRN_DTOData)
            End If

            Dim ModTRN_DTOWHData() As DataRow = InDataset.TRN_DTOWH.Select("", "", DataViewRowState.ModifiedCurrent)
            If ModTRN_DTOWHData.Length > 0 Then
                TRN_DTOWHAdapter.Update(ModTRN_DTOWHData)
            End If

            Dim ModTRN_DTODData() As DataRow = InDataset.TRN_DTOD.Select("", "", DataViewRowState.ModifiedCurrent)
            If ModTRN_DTODData.Length > 0 Then
                TRN_DTODAdapter.Update(ModTRN_DTODData)
            End If

            Dim DelTRN_DTODData() As DataRow = InDataset.TRN_DTOD.Select("", "", DataViewRowState.Deleted)
            If DelTRN_DTODData.Length > 0 Then
                TRN_DTODAdapter.Update(DelTRN_DTODData)
            End If

            Dim DelTRN_DTOWHData() As DataRow = InDataset.TRN_DTOWH.Select("", "", DataViewRowState.Deleted)
            If DelTRN_DTOWHData.Length > 0 Then
                TRN_DTOWHAdapter.Update(DelTRN_DTOWHData)
            End If

            Dim DelTRN_DTOData() As DataRow = InDataset.TRN_DTO.Select("", "", DataViewRowState.Deleted)
            If DelTRN_DTOData.Length > 0 Then
                TRN_DTOAdapter.Update(DelTRN_DTOData)
            End If

            MyTransaction.Commit()
            TRN_DTOAdapter.Connection.Close()
        Catch ex As Exception
            MyTransaction.Rollback()
            TRN_DTOAdapter.Connection.Close()
            Throw ex
        End Try
    End Sub



    Private dsCSPOSMasterDataset As CSPOSMasterDataset
    Private Sub CreateCSPOSMasterDataset()
        If dsCSPOSMasterDataset Is Nothing Then
            dsCSPOSMasterDataset = New CSPOSMasterDataset
        End If
    End Sub

    Public Function GetCSPOSMasterDataset() As CSAccountDatabaseIntf.CSPOSMasterDataset Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.GetCSPOSMasterDataset
        CreateCSPOSMasterDataset()
        Return dsCSPOSMasterDataset
    End Function

    Public Sub LoadCSPOSMasterDataset_POSUSer() Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSPOSMasterDataset_POSUser
        CreateCSPOSMasterDataset()
        Dim MST_POSUSERAdapter As CSPOSMasterDatasetTableAdapters.MST_POSUSERTableAdapter = New CSPOSMasterDatasetTableAdapters.MST_POSUSERTableAdapter
        MST_POSUSERAdapter.Fill(dsCSPOSMasterDataset.MST_POSUSER)
    End Sub

    Public Sub LoadCSPOSMasterDataset_POSSet() Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSPOSMasterDataset_POSSet
        CreateCSPOSMasterDataset()
        Dim MST_POSSETAdapter As CSPOSMasterDatasetTableAdapters.MST_POSSETTableAdapter = New CSPOSMasterDatasetTableAdapters.MST_POSSETTableAdapter
        Dim AccAdapter As CSPOSMasterDatasetTableAdapters.MST_ACCOUNTTableAdapter = New CSPOSMasterDatasetTableAdapters.MST_ACCOUNTTableAdapter
        AccAdapter.Fill(dsCSPOSMasterDataset.MST_ACCOUNT)
        MST_POSSETAdapter.Fill(dsCSPOSMasterDataset.MST_POSSET)
    End Sub

    Public Sub SaveCSPOSMasterDataset(ByVal InDataset As CSAccountDatabaseIntf.CSPOSMasterDataset) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveCSPOSMasterDataset
        Dim MST_POSUSERAdapter As CSPOSMasterDatasetTableAdapters.MST_POSUSERTableAdapter = New CSAccountDatabaseIntf.CSPOSMasterDatasetTableAdapters.MST_POSUSERTableAdapter
        Dim MST_POSSETadapter As CSPOSMasterDatasetTableAdapters.MST_POSSETTableAdapter = New CSPOSMasterDatasetTableAdapters.MST_POSSETTableAdapter
        MST_POSUSERAdapter.Update(InDataset.MST_POSUSER)
        MST_POSSETadapter.Update(InDataset.MST_POSSET)
    End Sub

    Public Function CheckPOSDataExists(ByVal POSUserNo As Integer) As Boolean Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.CheckPOSDataExists
        Return False 'Implement later.
    End Function



    Public Sub SaveCSPOSPromoDataset(ByVal InDataset As CSPOSPromoDataset) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveCSPOSPromoDataset
        Dim TRN_PROMOAdapter As CSPOSPromoDatasetTableAdapters.TRN_PROMOTableAdapter = New CSPOSPromoDatasetTableAdapters.TRN_PROMOTableAdapter
        Dim TRN_PROMORULESAdapter As CSPOSPromoDatasetTableAdapters.TRN_PRMRULESTableAdapter = New CSPOSPromoDatasetTableAdapters.TRN_PRMRULESTableAdapter
        Dim TRN_PROMOITMAdapter As CSPOSPromoDatasetTableAdapters.TRN_PROMOITMTableAdapter = New CSPOSPromoDatasetTableAdapters.TRN_PROMOITMTableAdapter
        Dim TRN_PROMORPAdapter As CSPOSPromoDatasetTableAdapters.TRN_PROMORPTableAdapter = New CSPOSPromoDatasetTableAdapters.TRN_PROMORPTableAdapter
        Dim MyTransaction As System.Data.SqlClient.SqlTransaction
        TRN_PROMOAdapter.Connection.Open()
        MyTransaction = TRN_PROMOAdapter.Connection.BeginTransaction
        TRN_PROMOAdapter.SetCommandsTransaction(TRN_PROMOAdapter.Connection, MyTransaction)
        TRN_PROMORULESAdapter.SetCommandsTransaction(TRN_PROMOAdapter.Connection, MyTransaction)
        TRN_PROMOITMAdapter.SetCommandsTransaction(TRN_PROMOAdapter.Connection, MyTransaction)
        TRN_PROMORPAdapter.SetCommandsTransaction(TRN_PROMOAdapter.Connection, MyTransaction)
        Try
            Dim InsTRN_PROMOData() As DataRow = InDataset.TRN_PROMO.Select("", "", DataViewRowState.Added)
            If InsTRN_PROMOData.Length > 0 Then
                TRN_PROMOAdapter.Update(InsTRN_PROMOData)
            End If

            Dim InsTRN_PROMORULESData() As DataRow = InDataset.TRN_PRMRULES.Select("", "", DataViewRowState.Added)
            If InsTRN_PROMORULESData.Length > 0 Then
                TRN_PROMORULESAdapter.Update(InsTRN_PROMORULESData)
            End If

            Dim InsTRN_PROMORPData() As DataRow = InDataset.TRN_PROMORP.Select("", "", DataViewRowState.Added)
            If InsTRN_PROMORPData.Length > 0 Then
                TRN_PROMORPAdapter.Update(InsTRN_PROMORPData)
            End If

            Dim InsTRN_PROMOITMData() As DataRow = InDataset.TRN_PROMOITM.Select("", "", DataViewRowState.Added)
            If InsTRN_PROMOITMData.Length > 0 Then
                TRN_PROMOITMAdapter.Update(InsTRN_PROMOITMData)
            End If

            Dim ModTRN_PROMOData() As DataRow = InDataset.TRN_PROMO.Select("", "", DataViewRowState.ModifiedCurrent)
            If ModTRN_PROMOData.Length > 0 Then
                TRN_PROMOAdapter.Update(ModTRN_PROMOData)
            End If

            Dim ModTRN_PROMORULESData() As DataRow = InDataset.TRN_PRMRULES.Select("", "", DataViewRowState.ModifiedCurrent)
            If ModTRN_PROMORULESData.Length > 0 Then
                TRN_PROMORULESAdapter.Update(ModTRN_PROMORULESData)
            End If

            Dim ModTRN_PROMORPData() As DataRow = InDataset.TRN_PROMORP.Select("", "", DataViewRowState.ModifiedCurrent)
            If ModTRN_PROMORPData.Length > 0 Then
                TRN_PROMORPAdapter.Update(ModTRN_PROMORPData)
            End If

            Dim ModTRN_PROMOITMData() As DataRow = InDataset.TRN_PROMOITM.Select("", "", DataViewRowState.ModifiedCurrent)
            If ModTRN_PROMOITMData.Length > 0 Then
                TRN_PROMOITMAdapter.Update(ModTRN_PROMOITMData)
            End If

            Dim DelTRN_PROMOITMData() As DataRow = InDataset.TRN_PROMOITM.Select("", "", DataViewRowState.Deleted)
            If DelTRN_PROMOITMData.Length > 0 Then
                TRN_PROMOITMAdapter.Update(DelTRN_PROMOITMData)
            End If

            Dim DelTRN_PROMORPData() As DataRow = InDataset.TRN_PROMORP.Select("", "", DataViewRowState.Deleted)
            If DelTRN_PROMORPData.Length > 0 Then
                TRN_PROMORPAdapter.Update(DelTRN_PROMORPData)
            End If

            Dim DelTRN_PROMORULESData() As DataRow = InDataset.TRN_PRMRULES.Select("", "", DataViewRowState.Deleted)
            If DelTRN_PROMORULESData.Length > 0 Then
                TRN_PROMORULESAdapter.Update(DelTRN_PROMORULESData)
            End If

            Dim DelTRN_PROMOData() As DataRow = InDataset.TRN_PROMO.Select("", "", DataViewRowState.Deleted)
            If DelTRN_PROMOData.Length > 0 Then
                TRN_PROMOAdapter.Update(DelTRN_PROMOData)
            End If

            MyTransaction.Commit()
            TRN_PROMOAdapter.Connection.Close()
        Catch ex As Exception
            MyTransaction.Rollback()
            TRN_PROMOAdapter.Connection.Close()
            Throw ex
        End Try
    End Sub

    Private dsCSPOSPromoDataset As CSPOSPromoDataset = Nothing
    Private Sub CreateCSPOSPromoDataset()
        If dsCSPOSPromoDataset Is Nothing Then
            dsCSPOSPromoDataset = New CSPOSPromoDataset
        End If
    End Sub
    Public Function GetCSPOSPromoDataset() As CSAccountDatabaseIntf.CSPOSPromoDataset Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.GetCSPOSPromoDataset
        CreateCSPOSPromoDataset()
        Return dsCSPOSPromoDataset
    End Function

    Public Sub LoadCSPOSPromoDataset() Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSPOSPromoDataset
        CreateCSPOSPromoDataset()
        Dim TRN_PROMOAdapter As CSPOSPromoDatasetTableAdapters.TRN_PROMOTableAdapter = New CSPOSPromoDatasetTableAdapters.TRN_PROMOTableAdapter
        Dim TRN_PRMRULESAdapter As CSPOSPromoDatasetTableAdapters.TRN_PRMRULESTableAdapter = New CSPOSPromoDatasetTableAdapters.TRN_PRMRULESTableAdapter
        Dim TRN_PROMOITMAdapter As CSPOSPromoDatasetTableAdapters.TRN_PROMOITMTableAdapter = New CSPOSPromoDatasetTableAdapters.TRN_PROMOITMTableAdapter
        Dim TRN_PROMORPAdapter As CSPOSPromoDatasetTableAdapters.TRN_PROMORPTableAdapter = New CSPOSPromoDatasetTableAdapters.TRN_PROMORPTableAdapter
        Dim MST_ITEMSAdapter As CSPOSPromoDatasetTableAdapters.MST_ITEMSTableAdapter = New CSPOSPromoDatasetTableAdapters.MST_ITEMSTableAdapter
        TRN_PROMOAdapter.Fill(dsCSPOSPromoDataset.TRN_PROMO)
        TRN_PRMRULESAdapter.Fill(dsCSPOSPromoDataset.TRN_PRMRULES)
        TRN_PROMOITMAdapter.Fill(dsCSPOSPromoDataset.TRN_PROMOITM)
        TRN_PROMORPAdapter.Fill(dsCSPOSPromoDataset.TRN_PROMORP)
        MST_ITEMSAdapter.Fill(dsCSPOSPromoDataset.MST_ITEMS)
    End Sub

    Private dsPOSDataset As CSPOSDataset
    Private Sub CreatePOSDataset()
        If dsPOSDataset Is Nothing Then
            dsPOSDataset = New CSPOSDataset
        End If
    End Sub

    Public Function GetCSPOSDataset() As CSAccountDatabaseIntf.CSPOSDataset Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.GetCSPOSDataset
        CreatePOSDataset()
        Return dsPOSDataset
    End Function

    Public Sub LoadCSPOSDataset_DailySalesByItem(ByVal WHNO As Integer, ByVal FrDate As Date, ByVal ToDate As Date) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSPOSDataset_DailySalesByItem
        Dim DSalesAdapter As CSPOSDatasetTableAdapters.DailySalesByItemTableAdapter = New CSPOSDatasetTableAdapters.DailySalesByItemTableAdapter

        CreatePOSDataset()
        DSalesAdapter.Fill(dsPOSDataset.DailySalesByItem, WHNO, FrDate, ToDate)
    End Sub

    Public Sub LoadCSPOSDataset_DailySalesByTender(ByVal WHNO As Integer, ByVal FrDate As Date, ByVal ToDate As Date) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSPOSDataset_DailySalesByTender
        Dim DSalesAdapter As CSPOSDatasetTableAdapters.DailySalesByTenderTableAdapter = New CSPOSDatasetTableAdapters.DailySalesByTenderTableAdapter

        CreatePOSDataset()
        DSalesAdapter.Fill(dsPOSDataset.DailySalesByTender, WHNO, FrDate, ToDate)
    End Sub

    Public Sub LoadCSPOSDataset_DailySales(ByVal FrWHNo As Integer, ByVal ToWHNO As Integer, ByVal FrDate As Date, ByVal ToDate As Date) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSPOSDataset_DailySales
        Dim DSalesAdapter As CSPOSDatasetTableAdapters.DailySalesByWarehousesTableAdapter = New CSPOSDatasetTableAdapters.DailySalesByWarehousesTableAdapter
        Dim WHNameAdapter As CSPOSDatasetTableAdapters.WHNAMESTableAdapter = New CSPOSDatasetTableAdapters.WHNAMESTableAdapter

        CreatePOSDataset()
        DSalesAdapter.Fill(dsPOSDataset.DailySalesByWarehouses, FrWHNo, ToWHNO, FrDate, ToDate)
        WHNameAdapter.Fill(dsPOSDataset.WHNAMES, FrWHNo, ToWHNO, FrDate, ToDate)
    End Sub

    Public Sub LoadCSPOSDataset_Warehouse() Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSPOSDataset_Warehouse
        Dim WHAdapter As CSPOSDatasetTableAdapters.MST_WAREHOUSETableAdapter = New CSPOSDatasetTableAdapters.MST_WAREHOUSETableAdapter
        CreatePOSDataset()
        WHAdapter.Fill(dsPOSDataset.MST_WAREHOUSE)
    End Sub

    Public Sub LoadCSPOSDataset(ByVal StartDate As DateTime, ByVal Enddate As DateTime) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSPOSDataset
        CreatePOSDataset()
        Dim POSAdapter As CSPOSDatasetTableAdapters.TRN_POSTableAdapter = New CSPOSDatasetTableAdapters.TRN_POSTableAdapter
        Dim POSDAdapter As CSPOSDatasetTableAdapters.TRN_POSDTableAdapter = New CSPOSDatasetTableAdapters.TRN_POSDTableAdapter
        Dim POSPayAdapter As CSPOSDatasetTableAdapters.TRN_POSPAYTableAdapter = New CSPOSDatasetTableAdapters.TRN_POSPAYTableAdapter
        POSAdapter.Fill(dsPOSDataset.TRN_POS, StartDate, Enddate)
        POSDAdapter.Fill(dsPOSDataset.TRN_POSD, StartDate, Enddate)
        POSPayAdapter.Fill(dsPOSDataset.TRN_POSPAY, StartDate, Enddate)
    End Sub

    Public Sub SaveCSPOSDataset(ByVal InDataset As CSAccountDatabaseIntf.CSPOSDataset) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveCSPOSDataset
        Dim POSAdapter As CSPOSDatasetTableAdapters.TRN_POSTableAdapter = New CSPOSDatasetTableAdapters.TRN_POSTableAdapter
        Dim POSDAdapter As CSPOSDatasetTableAdapters.TRN_POSDTableAdapter = New CSPOSDatasetTableAdapters.TRN_POSDTableAdapter
        Dim POSPayAdapter As CSPOSDatasetTableAdapters.TRN_POSPAYTableAdapter = New CSPOSDatasetTableAdapters.TRN_POSPAYTableAdapter
        POSAdapter.Connection.Open()
        Dim MyTrans As System.Data.SqlClient.SqlTransaction = POSAdapter.Connection.BeginTransaction
        POSAdapter.SetCommandsTransaction(POSAdapter.Connection, MyTrans)
        POSDAdapter.SetCommandsTransaction(POSAdapter.Connection, MyTrans)
        POSPayAdapter.SetCommandsTransaction(POSAdapter.Connection, MyTrans)
        Try
            POSAdapter.Update(InDataset.TRN_POS.Select("", "", DataViewRowState.Added))
            POSDAdapter.Update(InDataset.TRN_POSD.Select("", "", DataViewRowState.Added))
            POSPayAdapter.Update(InDataset.TRN_POSPAY.Select("", "", DataViewRowState.Added))
            POSAdapter.Update(InDataset.TRN_POS.Select("", "", DataViewRowState.ModifiedCurrent))
            POSDAdapter.Update(InDataset.TRN_POSD.Select("", "", DataViewRowState.ModifiedCurrent))
            POSPayAdapter.Update(InDataset.TRN_POSPAY.Select("", "", DataViewRowState.ModifiedCurrent))
            POSPayAdapter.Update(InDataset.TRN_POSPAY.Select("", "", DataViewRowState.Deleted))
            POSDAdapter.Update(InDataset.TRN_POSD.Select("", "", DataViewRowState.Deleted))
            POSAdapter.Update(InDataset.TRN_POS.Select("", "", DataViewRowState.Deleted))
            MyTrans.Commit()
            POSAdapter.Connection.Close()
            InDataset.AcceptChanges()
        Catch ex As Exception
            MyTrans.Rollback()
            POSAdapter.Connection.Close()
            Throw ex
        End Try
    End Sub

    Private dsBKBookDataset As CSAccBKBookDataset
    Private Sub CreateBKBookDataset()
        If dsBKBookDataset Is Nothing Then
            dsBKBookDataset = New CSAccBKBookDataset
        End If
    End Sub

    Public Function GetCSAccBKBookDataset() As CSAccountDatabaseIntf.CSAccBKBookDataset Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.GetCSAccBKBookDataset
        CreateBKBookDataset()
        Return dsBKBookDataset
    End Function

    Public Sub LoadCSAccBKBookDataset(ByVal StartDate As Date, ByVal EndDate As Date) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSAccBKBookDataset
        Dim BKTranAdapter As CSAccBKBookDatasetTableAdapters.TRN_BKTRANTableAdapter = New CSAccBKBookDatasetTableAdapters.TRN_BKTRANTableAdapter
        Dim BKTrandAdapter As CSAccBKBookDatasetTableAdapters.TRN_BKTRANDTableAdapter = New CSAccBKBookDatasetTableAdapters.TRN_BKTRANDTableAdapter
        Dim BankAdapter As CSAccBKBookDatasetTableAdapters.MST_BANKTableAdapter = New CSAccBKBookDatasetTableAdapters.MST_BANKTableAdapter
        Dim AccAdapter As CSAccBKBookDatasetTableAdapters.MST_ACCOUNTTableAdapter = New CSAccBKBookDatasetTableAdapters.MST_ACCOUNTTableAdapter
        Dim AccTypeAdapter As CSAccBKBookDatasetTableAdapters.SYS_ACCTYPETableAdapter = New CSAccBKBookDatasetTableAdapters.SYS_ACCTYPETableAdapter

        CreateBKBookDataset()
        BKTranAdapter.Fill(dsBKBookDataset.TRN_BKTRAN, StartDate, EndDate)
        BKTrandAdapter.Fill(dsBKBookDataset.TRN_BKTRAND, StartDate, EndDate)
        BankAdapter.Fill(dsBKBookDataset.MST_BANK)
        AccAdapter.Fill(dsBKBookDataset.MST_ACCOUNT)
        AccTypeAdapter.Fill(dsBKBookDataset.SYS_ACCTYPE)
    End Sub

    Public Sub SaveCSAcccBKBookDataset(ByVal InDataset As CSAccountDatabaseIntf.CSAccBKBookDataset) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveCSAcccBKBookDataset
        Dim BKTranAdapter As CSAccBKBookDatasetTableAdapters.TRN_BKTRANTableAdapter = New CSAccBKBookDatasetTableAdapters.TRN_BKTRANTableAdapter
        Dim BKTrandAdapter As CSAccBKBookDatasetTableAdapters.TRN_BKTRANDTableAdapter = New CSAccBKBookDatasetTableAdapters.TRN_BKTRANDTableAdapter
        BKTranAdapter.Connection.Open()
        Dim MyTrans As System.Data.SqlClient.SqlTransaction = BKTranAdapter.Connection.BeginTransaction
        BKTranAdapter.SetCommandsTransaction(BKTranAdapter.Connection, MyTrans)
        BKTrandAdapter.SetCommandsTransaction(BKTranAdapter.Connection, MyTrans)
        Try
            BKTranAdapter.Update(InDataset.TRN_BKTRAN.Select("", "", DataViewRowState.Added))
            BKTrandAdapter.Update(InDataset.TRN_BKTRAND.Select("", "", DataViewRowState.Added))
            BKTranAdapter.Update(InDataset.TRN_BKTRAN.Select("", "", DataViewRowState.ModifiedCurrent))
            BKTrandAdapter.Update(InDataset.TRN_BKTRAND.Select("", "", DataViewRowState.ModifiedCurrent))
            BKTrandAdapter.Update(InDataset.TRN_BKTRAND.Select("", "", DataViewRowState.Deleted))
            BKTranAdapter.Update(InDataset.TRN_BKTRAN.Select("", "", DataViewRowState.Deleted))
            MyTrans.Commit()
            BKTranAdapter.Connection.Close()
        Catch ex As Exception
            MyTrans.Rollback()
            BKTranAdapter.Connection.Close()
            Throw ex
        End Try

    End Sub

    Private dsSimpleFinanceRpt As CSAccSimpleFinanceRptDataset
    Private Sub CreateSimpleFinanceRpt()
        If dsSimpleFinanceRpt Is Nothing Then
            dsSimpleFinanceRpt = New CSAccSimpleFinanceRptDataset
        End If
    End Sub

    Public Function GetSimpleFinanceRpt() As CSAccountDatabaseIntf.CSAccSimpleFinanceRptDataset Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.GetSimpleFinanceRpt
        CreateSimpleFinanceRpt()
        Return dsSimpleFinanceRpt
    End Function

    Public Sub LoadSimpleFinanceRpt(ByVal Year1 As Integer, ByVal Month1 As Integer, ByVal Year2 As Integer, ByVal Month2 As Integer) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadSimpleFinanceRpt
        Dim SFAdapter As CSAccSimpleFinanceRptDatasetTableAdapters.SIMPLEFINANCERPTTableAdapter = New CSAccSimpleFinanceRptDatasetTableAdapters.SIMPLEFINANCERPTTableAdapter
        CreateSimpleFinanceRpt()
        SFAdapter.Fill(dsSimpleFinanceRpt.SIMPLEFINANCERPT, Year1, Month1, Year2, Month2)
    End Sub

    Private dsPOSPOSTDataset As CSPOSPOSTDataset
    Private Sub CreatePOSPOSTDataset()
        If dsPOSPOSTDataset Is Nothing Then
            dsPOSPOSTDataset = New CSPOSPOSTDataset
        End If
    End Sub
    Public Function GetCSPOSPOSTDataset() As CSAccountDatabaseIntf.CSPOSPOSTDataset Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.GetCSPOSPOSTDataset
        CreatePOSPOSTDataset()
        Return dsPOSPOSTDataset
    End Function


    Public Sub LoadCSPOSPOSTDataset(ByVal StartDate As Date, ByVal EndDate As Date) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSPOSPOSTDataset
        Dim POSPostAdapter As CSPOSPOSTDatasetTableAdapters.TRN_POSTSLTableAdapter = New CSPOSPOSTDatasetTableAdapters.TRN_POSTSLTableAdapter
        Dim POSPostDAdapter As CSPOSPOSTDatasetTableAdapters.TRN_POSTSLDTableAdapter = New CSPOSPOSTDatasetTableAdapters.TRN_POSTSLDTableAdapter
        Dim AccAdapter As CSPOSPOSTDatasetTableAdapters.MST_ACCOUNTTableAdapter = New CSPOSPOSTDatasetTableAdapters.MST_ACCOUNTTableAdapter
        Dim WHAdapter As CSPOSPOSTDatasetTableAdapters.MST_WAREHOUSETableAdapter = New CSPOSPOSTDatasetTableAdapters.MST_WAREHOUSETableAdapter
        Dim POSSetAdapter As CSPOSPOSTDatasetTableAdapters.MST_POSSETTableAdapter = New CSPOSPOSTDatasetTableAdapters.MST_POSSETTableAdapter
        CreatePOSPOSTDataset()
        POSPostAdapter.Fill(dsPOSPOSTDataset.TRN_POSTSL, StartDate, EndDate)
        POSPostDAdapter.Fill(dsPOSPOSTDataset.TRN_POSTSLD, StartDate, EndDate)
        AccAdapter.Fill(dsPOSPOSTDataset.MST_ACCOUNT)
        WHAdapter.Fill(dsPOSPOSTDataset.MST_WAREHOUSE)
        POSSetAdapter.Fill(dsPOSPOSTDataset.MST_POSSET)
    End Sub


    Public Function GetCSPOSPOSTWHSummary(ByVal StartDate As Date, ByVal EndDate As Date, ByVal FrWHNo As Integer, ByVal ToWHNO As Integer) As CSAccountDatabaseIntf.CSPOSPOSTDataset Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.GetCSPOSPOSTWHSummary
        CreatePOSPOSTDataset()
        Dim POSDAdapter As CSPOSPOSTDatasetTableAdapters.TRN_POSDTableAdapter = New CSPOSPOSTDatasetTableAdapters.TRN_POSDTableAdapter
        Dim POSAdapter As CSPOSPOSTDatasetTableAdapters.TRN_POSTableAdapter = New CSPOSPOSTDatasetTableAdapters.TRN_POSTableAdapter
        POSAdapter.Fill(dsPOSPOSTDataset.TRN_POS, StartDate, EndDate, FrWHNo, ToWHNO)
        POSDAdapter.Fill(dsPOSPOSTDataset.TRN_POSD, StartDate, EndDate, FrWHNo, ToWHNO)
        Return dsPOSPOSTDataset
    End Function

    Public Sub SaveCSPOSPOSTDataset(ByVal InDataset As CSAccountDatabaseIntf.CSPOSPOSTDataset) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveCSPOSPOSTDataset
        CreatePOSPOSTDataset()
        Dim POSPostAdapter As CSPOSPOSTDatasetTableAdapters.TRN_POSTSLTableAdapter = New CSPOSPOSTDatasetTableAdapters.TRN_POSTSLTableAdapter
        Dim POSPostDAdapter As CSPOSPOSTDatasetTableAdapters.TRN_POSTSLDTableAdapter = New CSPOSPOSTDatasetTableAdapters.TRN_POSTSLDTableAdapter
        POSPostAdapter.Connection.Open()
        Dim MyTrans As System.Data.SqlClient.SqlTransaction = POSPostAdapter.Connection.BeginTransaction
        POSPostAdapter.SetCommandsTransaction(POSPostAdapter.Connection, MyTrans)
        POSPostDAdapter.SetCommandsTransaction(POSPostAdapter.Connection, MyTrans)
        Try
            POSPostAdapter.Update(InDataset.TRN_POSTSL.Select("", "", DataViewRowState.Added))
            POSPostDAdapter.Update(InDataset.TRN_POSTSLD.Select("", "", DataViewRowState.Added))
            POSPostAdapter.Update(InDataset.TRN_POSTSL.Select("", "", DataViewRowState.ModifiedCurrent))
            POSPostDAdapter.Update(InDataset.TRN_POSTSLD.Select("", "", DataViewRowState.ModifiedCurrent))
            POSPostDAdapter.Update(InDataset.TRN_POSTSLD.Select("", "", DataViewRowState.Deleted))
            POSPostAdapter.Update(InDataset.TRN_POSTSL.Select("", "", DataViewRowState.Deleted))
            MyTrans.Commit()
            POSPostAdapter.Connection.Close()
        Catch ex As Exception
            MyTrans.Rollback()
            POSPostAdapter.Connection.Close()
            Throw ex
        End Try
    End Sub

    Private dsCashBillDataset As CSInvCashBillDataset
    Private Sub CreateCashBillDataset()
        If dsCashBillDataset Is Nothing Then
            dsCashBillDataset = New CSInvCashBillDataset
        End If
    End Sub

    Public Function GetCSInvCashBillDataset() As CSAccountDatabaseIntf.CSInvCashBillDataset Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.GetCSInvCashBillDataset
        CreateCashBillDataset()
        Return dsCashBillDataset
    End Function

    Public Sub LoadCSInvCashBillDataset(ByVal StartDate As Date, ByVal EndDate As Date) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.LoadCSInvCashBillDataset
        Dim itemAdapter As CSInvCashBillDatasetTableAdapters.MST_ITEMSTableAdapter = New CSInvCashBillDatasetTableAdapters.MST_ITEMSTableAdapter
        Dim CompAdapter As CSInvCashBillDatasetTableAdapters.MST_COMPANYTableAdapter = New CSInvCashBillDatasetTableAdapters.MST_COMPANYTableAdapter
        Dim TaxAdapter As CSInvCashBillDatasetTableAdapters.MST_TAXTableAdapter = New CSInvCashBillDatasetTableAdapters.MST_TAXTableAdapter
        Dim CBAdapter As CSInvCashBillDatasetTableAdapters.TRN_CASHBILLTableAdapter = New CSInvCashBillDatasetTableAdapters.TRN_CASHBILLTableAdapter
        Dim CBDAdapter As CSInvCashBillDatasetTableAdapters.TRN_CASHBILLDTableAdapter = New CSInvCashBillDatasetTableAdapters.TRN_CASHBILLDTableAdapter
        Dim CurrAdapter As CSInvCashBillDatasetTableAdapters.MST_CURRENCYTableAdapter = New CSInvCashBillDatasetTableAdapters.MST_CURRENCYTableAdapter
        Dim BankAdapter As CSInvCashBillDatasetTableAdapters.MST_BANKTableAdapter = New CSInvCashBillDatasetTableAdapters.MST_BANKTableAdapter
        Dim CustAdapter As CSInvCashBillDatasetTableAdapters.MST_CUSTOMERTableAdapter = New CSInvCashBillDatasetTableAdapters.MST_CUSTOMERTableAdapter
        Dim WHAdapter As CSInvCashBillDatasetTableAdapters.MST_WAREHOUSETableAdapter = New CSInvCashBillDatasetTableAdapters.MST_WAREHOUSETableAdapter
        CreateCashBillDataset()
        itemAdapter.Fill(dsCashBillDataset.MST_ITEMS)
        CompAdapter.Fill(dsCashBillDataset.MST_COMPANY)
        TaxAdapter.Fill(dsCashBillDataset.MST_TAX)
        CurrAdapter.Fill(dsCashBillDataset.MST_CURRENCY)
        BankAdapter.Fill(dsCashBillDataset.MST_BANK)
        CBAdapter.Fill(dsCashBillDataset.TRN_CASHBILL, StartDate, EndDate)
        CBDAdapter.Fill(dsCashBillDataset.TRN_CASHBILLD, StartDate, EndDate)
        WHAdapter.Fill(dsCashBillDataset.MST_WAREHOUSE)
        CustAdapter.Fill(dsCashBillDataset.MST_CUSTOMER)
    End Sub

    Public Sub SaveCSInvCashBillDataset(ByVal InDataset As CSAccountDatabaseIntf.CSInvCashBillDataset) Implements CSAccountDatabaseIntf.ICSAccountDatabaseIntf.SaveCSInvCashBillDataset
        Dim CBAdapter As CSInvCashBillDatasetTableAdapters.TRN_CASHBILLTableAdapter = New CSInvCashBillDatasetTableAdapters.TRN_CASHBILLTableAdapter
        Dim CBDAdapter As CSInvCashBillDatasetTableAdapters.TRN_CASHBILLDTableAdapter = New CSInvCashBillDatasetTableAdapters.TRN_CASHBILLDTableAdapter
        CreateCashBillDataset()
        CBAdapter.Connection.Open()
        Dim MyTrans As System.Data.SqlClient.SqlTransaction = CBAdapter.Connection.BeginTransaction
        CBAdapter.SetCommandsTransaction(CBAdapter.Connection, MyTrans)
        CBDAdapter.SetCommandsTransaction(CBAdapter.Connection, MyTrans)
        Try
            CBAdapter.Update(InDataset.TRN_CASHBILL.Select("", "", DataViewRowState.Added))
            CBDAdapter.Update(InDataset.TRN_CASHBILLD.Select("", "", DataViewRowState.Added))
            CBAdapter.Update(InDataset.TRN_CASHBILL.Select("", "", DataViewRowState.ModifiedCurrent))
            CBDAdapter.Update(InDataset.TRN_CASHBILLD.Select("", "", DataViewRowState.ModifiedCurrent))
            CBDAdapter.Update(InDataset.TRN_CASHBILLD.Select("", "", DataViewRowState.Deleted))
            CBAdapter.Update(InDataset.TRN_CASHBILL.Select("", "", DataViewRowState.Deleted))
            MyTrans.Commit()
            CBAdapter.Connection.Close()
        Catch ex As Exception
            MyTrans.Rollback()
            CBAdapter.Connection.Close()
            Throw ex
        End Try
    End Sub

End Class
