Public Interface ICSAccountDatabaseIntf
    Function GetCSMasterDataset() As CSMasterDataset
    Function GetCSSystemDBDataset() As CSSystemDBDataset
    Function GetCSGLDataset() As CSGLDataset
    Function CheckAccExists(ByVal ACC_CODE As String) As Boolean

    Function CheckCurrencyExists(ByVal CURR_CODE As String) As Boolean

    Sub LoadCSAccountDBDataset()
    Sub LoadCSSystemDBDataset()
	Sub LoadCSSystemDBDataset_KeyCode()
	Sub SaveCSSystemDBDatasetKeyCode(ByVal InDataset As CSSystemDBDataset)
	Sub LoadCSGLMasterDataset()
    Sub LoadCSGLTranDataset(ByVal StartDate As DateTime, ByVal EndDate As DateTime)

    Sub LoadCSBudgetDataset(ByVal ACC_Year As Int16)

    Sub LoadCSGLCurrDataset()
    Sub SaveCSGLCurrDataset(ByVal InDataset As CSGLDataset)

    Sub LoadCSMasterDataset()
    Sub SaveCSMasterDataset(ByVal InDataset As CSMasterDataset)

    Sub LoadCSMasterDataset_Company()

    Sub LoadCSBankMasterDataset()
    Sub SaveCSBankMasterDataset(ByVal InDataset As CSMasterDataset)

    Sub LoadCSAccPayableDataset()
    Function CheckAPTranExistsByVendor(ByVal VENDOR_CODE As String) As Boolean

    Sub LoadCSAPInvDataset(ByVal StartDate As DateTime, ByVal EndDate As DateTime)

    Sub LoadCSAPChequeDataset(ByVal StartDate As DateTime, ByVal EndDate As DateTime)
    Function CheckAPTranExists() As Boolean
    Function CheckAPPaymentExists(ByVal APINVNO As Integer) As Boolean
    Function CheckAPBankDetailExists(ByVal BANKNO As Integer) As Boolean

    Sub SaveCSGLMasterDataset(ByVal InDataset As CSGLDataset)
    Sub SaveCSGLTranDataset(ByVal InDataset As CSGLDataset)
    Sub SaveCSSystemDBDataset(ByVal InDataset As CSSystemDBDataset)
    Sub SaveSecurityUserInfo(ByVal InDataset As CSSystemDBDataset)
    Sub SaveSecurityRoleInfo(ByVal InDataset As CSSystemDBDataset)
    Function CSSystemStoreProc() As CSSystemDBDatasetTableAdapters.QueriesTableAdapter
	Function GetKey(ByVal InKeyName As String) As Integer
	Function GetKeyCode(ByVal InKeyName As String) As String

    Sub LoadCSCustTypeMaster()
    Sub SaveCSCustTypeMaster(ByVal InDataset As CSMasterDataset)
    Function CheckCustTypeExists(ByVal CustType_Code As String) As Boolean

    Sub LoadCSSalesManMaster()
    Sub SaveCSSalesManMaster(ByVal InDataset As CSMasterDataset)
    Function CheckSalesManExists(ByVal SALES_CODE As String) As Boolean

    Sub LoadCSTaxMaster()
    Sub SaveCSTaxMaster(ByVal InDataset As CSMasterDataset)
    Function CheckTaxExists(ByVal TAX_CODE As String) As Boolean

    Sub LoadCSCustomerMaster()
    Sub SaveCSCustomerMaster(ByVal InDataset As CSMasterDataset)
    Function CheckARTranExistsByCustomer(ByVal CUST_CODE As String) As Boolean

    Sub LoadCSAccReceivable(ByVal StartDate As DateTime, ByVal EndDate As DateTime)

    Function CheckARTranExistsByTax(ByVal TAX_CODE As String) As Boolean

    Sub LoadCSARChequeDataset(ByVal StartDate As DateTime, ByVal EndDate As DateTime)
    Function CheckARTranExists() As Boolean
    Function CheckARPaymentExists(ByVal APINVNO As Integer) As Boolean
    Function CheckARBankDetailExists(ByVal BANKNO As Integer) As Boolean

    Sub LoadCSReconDataset(ByVal StartDate As DateTime, ByVal EndDate As DateTime, ByVal AccYear As Integer)

    Function GetCSAccRptDataset() As CSAccRptDataset
    Sub LoadCSAccRptDataset()
    Sub SaveCSAccRptDataset(ByVal InDataset As CSAccRptDataset)

    Function GetCSAccReporting() As CSAccReporting
    Sub LoadCSAccReporting_ReportBLPL(ByVal ACCRPTNO As Integer, ByVal ACCYEAR As Integer, ByVal ACCMONTH As Integer, ByVal LASTYEAR As Integer, ByVal LASTMONTH As Integer)
    Sub LoadCSAccReporting_Master()
    Sub LoadCSAccReporting_TRN_APINV(ByVal StartCode As String, ByVal EndCode As String)
    Sub LoadCSAccreporting_SMY_CUSTAGE(ByVal InToday As DateTime, ByVal StartCode As String, ByVal EndCode As String, ByVal InDate As DateTime)
    Sub LoadCSAccReporting_Statement(ByVal InDate As DateTime, ByVal StartCode As String, ByVal EndCode As String)
    Sub LoadCSAccReporting_SMY_TRIAL_BALANCE(ByVal AccYear As Int32, ByVal AccMonth As Int32)
	Sub LoadCSAccReporting_InvoiceWithTax(ByVal StartDate As DateTime, ByVal EndDate As DateTime)
	Sub LoadCSAccReporting_WH()
	Sub LoadCSAccReporting_StkTake(ByVal WHNO As Integer, ByVal ItemYear As Integer, ByVal ItemMonth As Integer)


    Sub LoadCSSummaryDataset(ByVal FrYear As Integer, ByVal ToYear As Integer)

    Function CheckAccHistoryExists() As Boolean

    Sub CloseYear()

    Function RunScript(ByVal StrFile As String, ByVal InCompName As String) As Boolean

    Function GetCompsDBs() As CompsDBs
    Sub SaveCompsDBs(ByVal InDataset As CompsDBs)

    Sub SetConnectionStr(ByVal InDatabase As String)

    Function CloseScriptEngineDatabase() As Boolean

    Sub LoadCSInvDataset_ItmGrp()
    Sub LoadCSInvDataset_Class()
    Sub LoadCSInvDataset()

    Sub LoadCSInvRcvDataset(ByVal StartDate As DateTime, ByVal EndDate As DateTime)

    Sub LoadCSInvDODataset(ByVal StartDate As DateTime, ByVal EndDate As DateTime)

    Sub LoadCSInvAJDataset(ByVal StartDate As DateTime, ByVal EndDate As DateTime)

    Sub LoadCSInvItemDataset()
    Sub LoadCSInvItemDataset_ItmGrp()


    Function CheckAPInvExists(ByVal INVOICENO As String, ByVal APINVNO As Integer) As Boolean
    Function CheckARInvExists(ByVal INVOICENO As String, ByVal ARINVNO As Integer) As Boolean
    Function CheckRCExists(ByVal TRAN_CODE As String, ByVal RCNO As Integer) As Boolean
    Function CheckDOExists(ByVal Tran_Code As String, ByVal DONO As Integer) As Boolean
    Function CheckAJExists(ByVal Tran_Code As String, ByVal AJNO As Integer) As Boolean
    Function CheckDTOExists(ByVal Tran_Code As String, ByVal DTONO As Integer) As Boolean
    Function CheckCBExists(ByVal Tran_Code As String, ByVal CBNO As Integer) As Boolean

    Sub LoadInvReport_DO(ByVal StartDate As DateTime, ByVal EndDate As DateTime)
    Sub LoadInvReport_AJ(ByVal StartDate As DateTime, ByVal EndDate As DateTime)
    Sub LoadInvReport_RC(ByVal StartDate As DateTime, ByVal EndDate As DateTime)
    Sub LoadInvReport_PrintDO(ByVal DONO As Integer)

    Sub LoadInvSummaryDataset_WH()
    Sub LoadInvSummaryDataset_Bal(ByVal ItemYear As Integer, ByVal WHNO As Integer)
    Sub LoadInvSummaryDataset_His(ByVal Inv_Year As Integer, ByVal WHNO As Integer, ByVal WHNO1 As Integer, ByVal Item_NO As Integer)

    Function CheckItemExists(ByVal Item_No As Integer) As Boolean
    Function CheckItemExistsByItmGrp(ByVal ItmGrp_Code As String) As Boolean
    Function CheckItemExistsByColor(ByVal Color_code As String) As Boolean
    Function CheckItemExistsBySize(ByVal Size_Code As String) As Boolean
    Function CheckItmHistoryExistsByWarehouse(ByVal WHNO As Integer) As Boolean
    Function CheckPOSDataExists(ByVal POSUserNo As Integer) As Boolean

    Sub LoadCSPOSDTODataset(ByVal StartDate As DateTime, ByVal Enddate As DateTime)

    Sub LoadCSPOSMasterDataset_POSUser()
    Sub LoadCSPOSMasterDataset_POSSet()


    Sub LoadCSPOSPromoDataset()

    Sub LoadCSPOSDataset(ByVal StartDate As DateTime, ByVal EndDate As DateTime)
    Sub LoadCSPOSDataset_Warehouse()
    Sub LoadCSPOSDataset_DailySales(ByVal FrWHNo As Integer, ByVal ToWHNO As Integer, ByVal FrDate As DateTime, ByVal ToDate As DateTime)
    Sub LoadCSPOSDataset_DailySalesByItem(ByVal WHNO As Integer, ByVal FrDate As DateTime, ByVal ToDate As DateTime)
    Sub LoadCSPOSDataset_DailySalesByTender(ByVal WHNO As Integer, ByVal FrDate As DateTime, ByVal ToDate As DateTime)

    Function GetCSAccBKBookDataset() As CSAccBkBookDataset
    Sub LoadCSAccBKBookDataset(ByVal StartDate As DateTime, ByVal EndDate As DateTime)
    Sub SaveCSAcccBKBookDataset(ByVal InDataset As CSAccBKBookDataset)

    Sub LoadSimpleFinanceRpt(ByVal Year1 As Integer, ByVal Month1 As Integer, ByVal Year2 As Integer, ByVal Month2 As Integer)
    Function GetSimpleFinanceRpt() As CSAccSimpleFinanceRptDataset

    Sub LoadCSPOSPOSTDataset(ByVal StartDate As DateTime, ByVal EndDate As DateTime)

    Sub LoadCSInvCashBillDataset(ByVal StartDate As DateTime, ByVal EndDate As DateTime)

    Sub LoadxxxDataset()

End Interface

Public Class ShareData
    Public Shared DataBaseName As String
End Class

