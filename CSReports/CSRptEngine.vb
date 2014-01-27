Imports System.Windows.Forms
Imports Microsoft.Reporting.WinForms
Imports CSAccountDatabaseIntf
Imports CSCommon
Imports System.io
Public Class CSRptEngine
    Implements iCSReport

    Private dsAccRptDB As CSAccRptDataset
    Private Sub CreatedsAccRptDB()
        If dsAccRptDB Is Nothing Then
            dsAccRptDB = New CSAccRptDataset
        End If
    End Sub

    Private PreviewForm As CSRptPreview
    Public Sub CreatePreview()
        If PreviewForm Is Nothing Then
            PreviewForm = New CSRptPreview
            PreviewForm.MdiParent = m_Parentform
            PreviewForm.WindowState = FormWindowState.Maximized
            AddHandler PreviewForm.ReportViewer.LocalReport.SubreportProcessing, AddressOf SubReportProcessing
        End If
    End Sub

    Public Function GetReportDatasource(ByVal InLocalReport As LocalReport, ByVal InReportName As String, ByVal InDataset As DataSet, Optional ByVal FilterKey As String = "") As ArrayList
        Dim MySources As ArrayList = New ArrayList
        If InReportName.ToUpper = "BLPL.rdlc".ToUpper Then
            Dim MyDlg As FmBLPLDlg = New FmBLPLDlg
            MyDlg.SystemInfo = SystemInfo
            MyDlg.Dataset = dsAccRptDB
            If MyDlg.ShowDialog = DialogResult.OK Then
                SystemManager.LoadCSAccReporting_ReportBLPL(CInt(MyDlg.TemplateCode.SelectedValue), CInt(MyDlg.ThisYear.Value), CInt(MyDlg.ThisMonth.Value), CInt(MyDlg.LastYear.Value), CInt(MyDlg.LastMonth.Value))
                Dim pmAccYear As New ReportParameter("ACCYEAR", CStr(MyDlg.ThisYear.Value))
                Dim pmAccMonth As New ReportParameter("ACCMONTH", CStr(MyDlg.ThisMonth.Value))
                Dim MyRow As DataRow = MyDlg.CSAccRptDataset.MST_ACCREPORT.FindByACCRPTNO(CInt(CStr(MyDlg.TemplateCode.SelectedValue)))
                If MyRow Is Nothing Then
                    MsgBox("Please create financial template first !")
                    Return Nothing
                End If
                Dim pmTemplate As New ReportParameter("TEMPLATE_CODE", CStr(MyRow("TEMPLATE_CODE")))
                Dim pmTemplateName As New ReportParameter("TEMPLATE_NAME", CStr(MyRow("ACCRPT_NAME")))
                Dim Params() As ReportParameter = {pmAccYear, pmAccMonth, pmTemplate, pmTemplateName}
                InLocalReport.SetParameters(Params)
                MySources.Add(New ReportDataSource("CSAccReporting_ReportBLPL", SystemManager.GetCSAccReporting.Tables("ReportBLPL")))
                Return MySources
            Else
                Return Nothing
            End If
        ElseIf InReportName.ToUpper = "VendorListing.rdlc".ToUpper Then
            MySources.Add(New ReportDataSource("CSAccPayableDataset_MST_VENDOR", InDataset.Tables("MST_VENDOR")))
            Return MySources
        ElseIf InReportName.ToUpper = "VendorInvoices.rdlc".ToUpper Then
            MySources.Add(New ReportDataSource("CSAccPayableDataset_TRN_APINV", InDataset.Tables("TRN_APINV")))
            MySources.Add(New ReportDataSource("CSAccPayableDataset_TRN_APINVD", InDataset.Tables("TRN_APINVD")))
            MySources.Add(New ReportDataSource("CSAccPayableDataset_MST_VENDOR", InDataset.Tables("MST_VENDOR")))
            Return MySources
        ElseIf InReportName.ToUpper = "VendorCheques.rdlc".ToUpper Then
            MySources.Add(New ReportDataSource("CSAPChequeDataset_TRN_CHEQUE", InDataset.Tables("TRN_CHEQUE")))
            MySources.Add(New ReportDataSource("CSAPChequeDataset_TRN_CHEQUED", InDataset.Tables("TRN_CHEQUED")))
            MySources.Add(New ReportDataSource("CSAPChequeDataset_MST_VENDOR", InDataset.Tables("MST_VENDOR")))
            Return MySources
        ElseIf InReportName.ToUpper = "OpenPayable.rdlc".ToUpper Then
            Dim MyDlg As FmSelVendorDlg = New FmSelVendorDlg
            SystemManager.LoadCSAccReporting_Master()
            MyDlg.Dataset = SystemManager.GetCSAccReporting
            If MyDlg.ShowDialog = DialogResult.OK Then
                SystemManager.LoadCSAccReporting_TRN_APINV(CStr(MyDlg.FrVendor.SelectedValue), CStr(MyDlg.ToVendor.SelectedValue))
                MySources.Add(New ReportDataSource("CSAccReporting_TRN_APINV", SystemManager.GetCSAccReporting.Tables("TRN_APINV")))
                Return MySources
            Else
                Return Nothing
            End If
        ElseIf InReportName.ToUpper = "CustomerListing.rdlc".ToUpper Then
            MySources.Add(New ReportDataSource("CSMasterDataset_MST_CUSTOMER", InDataset.Tables("MST_CUSTOMER")))
            Return MySources
        ElseIf InReportName.ToUpper = "CustomerDetails.rdlc".ToUpper Then
            Dim Mydlg As FmCustomersAgeDlg = New FmCustomersAgeDlg
            Mydlg.AsOfDate.Enabled = False
            SystemManager.LoadCSAccReporting_Master()
            Mydlg.SystemInfo = SystemInfo
            Mydlg.Dataset = SystemManager.GetCSAccReporting
            If Mydlg.ShowDialog = DialogResult.OK Then
                Dim FrCustCodeParam As ReportParameter = New ReportParameter("FrCustCode", CStr(Mydlg.FrCustomer.SelectedValue))
                Dim ToCustCodeParam As ReportParameter = New ReportParameter("ToCustCode", CStr(Mydlg.ToCustomer.SelectedValue))
                Dim Params() As ReportParameter = {FrCustCodeParam, ToCustCodeParam}
                InLocalReport.SetParameters(Params)
            End If
            MySources.Add(New ReportDataSource("CSMasterDataset_MST_CUSTOMER", InDataset.Tables("MST_CUSTOMER")))
            Return MySources
        ElseIf InReportName.ToUpper = "InvoiceWithTax.rdlc".ToUpper Then
            MySources.Add(New ReportDataSource("CSAccReporting_InvoiceWithTax", InDataset.Tables("InvoiceWithTax")))
            Return MySources
        ElseIf InReportName.ToUpper = "CustomerInvoices.rdlc".ToUpper Then
            MySources.Add(New ReportDataSource("CSAccReceivableDataset_TRN_ARINV", InDataset.Tables("TRN_ARINV")))
            MySources.Add(New ReportDataSource("CSAccReceivableDataset_TRN_ARINVD", InDataset.Tables("TRN_ARINVD")))
            MySources.Add(New ReportDataSource("CSAccReceivableDataset_MST_CUSTOMER", InDataset.Tables("MST_CUSTOMER")))
            Return MySources
        ElseIf InReportName.ToUpper = "CustomerInvoice.rdlc".ToUpper Then
            DetailDataset = InDataset
            If FilterKey <> "" Then
                Dim FilterParam As New ReportParameter("ARINVNO", FilterKey)
                Dim Params() As ReportParameter = {FilterParam}
                InLocalReport.SetParameters(Params)
            End If
            MySources.Add(New ReportDataSource("CSAccReceivableDataset_TRN_ARINV", InDataset.Tables("TRN_ARINV")))
            MySources.Add(New ReportDataSource("CSAccReceivableDataset_MST_CUSTOMER", InDataset.Tables("MST_CUSTOMER")))
            MySources.Add(New ReportDataSource("CSAccReceivableDataset_MST_COMPANY", InDataset.Tables("MST_COMPANY")))
            Return MySources
        ElseIf InReportName.ToUpper = "CustomerReceipt.rdlc".ToUpper Then
            DetailDataset = InDataset
            If FilterKey <> "" Then
                Dim FilterParam As New ReportParameter("ARCHEQUENO", FilterKey)
                Dim Params() As ReportParameter = {FilterParam}
                InLocalReport.SetParameters(Params)
            End If
            MySources.Add(New ReportDataSource("CSARChequeDataset_TRN_ARCHEQUE", InDataset.Tables("TRN_ARCHEQUE")))
            Return MySources
        ElseIf InReportName.ToUpper = "CustomerPayments.rdlc".ToUpper Then
            MySources.Add(New ReportDataSource("CSARChequeDataset_TRN_ARCHEQUE", InDataset.Tables("TRN_ARCheque")))
            Return MySources
        ElseIf InReportName.ToUpper = "CustomersAging.rdlc".ToUpper Then
            Dim Mydlg As FmCustomersAgeDlg = New FmCustomersAgeDlg
            SystemManager.LoadCSAccReporting_Master()
            Mydlg.SystemInfo = SystemInfo
            Mydlg.Dataset = SystemManager.GetCSAccReporting
            If Mydlg.ShowDialog = DialogResult.OK Then
                Dim DateParam As ReportParameter = New ReportParameter("AsOfDate", CStr(Mydlg.AsOfDate.Value))
                Dim Params() As ReportParameter = {DateParam}
                InLocalReport.SetParameters(Params)
                SystemManager.LoadCSAccreporting_SMY_CUSTAGE(Mydlg.AsOfDate.Value, CStr(Mydlg.FrCustomer.SelectedValue), CStr(Mydlg.ToCustomer.SelectedValue), Mydlg.AsOfDate.Value)
                MySources.Add(New ReportDataSource("CSAccReporting_SMY_CUSTAGE", SystemManager.GetCSAccReporting.Tables("SMY_CUSTAGE")))
                Return MySources
            Else
                Return Nothing
            End If
            Return MySources
        ElseIf InReportName.ToUpper = "CustomerStatement.rdlc".ToUpper Then
            Dim Mydlg As FmCustomersAgeDlg = New FmCustomersAgeDlg
            SystemManager.LoadCSAccReporting_Master()
            Mydlg.SystemInfo = SystemInfo
            Mydlg.Dataset = SystemManager.GetCSAccReporting
            If Mydlg.ShowDialog = DialogResult.OK Then
                Dim DateParam As ReportParameter = New ReportParameter("AsOfDate", CStr(Mydlg.AsOfDate.Value))
                Dim Params() As ReportParameter = {DateParam}
                InLocalReport.SetParameters(Params)
                SystemManager.LoadCSAccReporting_Statement(Mydlg.AsOfDate.Value, CStr(Mydlg.FrCustomer.SelectedValue), CStr(Mydlg.ToCustomer.SelectedValue))
                DetailDataset = SystemManager.GetCSAccReporting
                MySources.Add(New ReportDataSource("CSAccReporting_SMY_STATEMENT", SystemManager.GetCSAccReporting.Tables("SMY_STATEMENT")))
                MySources.Add(New ReportDataSource("CSAccReporting_MST_COMPANY", Mydlg.Dataset.Tables("MST_COMPANY")))
                Return MySources
            Else
                Return Nothing
            End If
            Return MySources
        ElseIf InReportName.ToUpper = "TrialBalance.rdlc".ToUpper Then
            Dim MyDlg As FmSelAccPeriodDlg = New FmSelAccPeriodDlg
            MyDlg.SystemInfo = SystemInfo
            MyDlg.InitControls()
            If MyDlg.ShowDialog = DialogResult.OK Then
                Dim AccYear As ReportParameter = New ReportParameter("AccYear", CStr(MyDlg.AccYear.Value))
                Dim AccMonth As ReportParameter = New ReportParameter("AccMonth", CStr(MyDlg.AccMonth.Value))
                Dim Params() As ReportParameter = {AccYear, AccMonth}
                InLocalReport.SetParameters(Params)
                SystemManager.LoadCSAccReporting_SMY_TRIAL_BALANCE(CInt(MyDlg.AccYear.Value), CInt(MyDlg.AccMonth.Value))
                MySources.Add(New ReportDataSource("CSAccReporting_SMY_TRIAL_BALANCE", SystemManager.GetCSAccReporting.Tables("SMY_TRIAL_BALANCE")))
                Return MySources
            Else
                Return Nothing
            End If
        ElseIf InReportName.ToUpper = "DOListing.rdlc".ToUpper Then
            MySources.Add(New ReportDataSource("CSInvReport_TRN_DO", InDataset.Tables("TRN_DO")))
            Return MySources
        ElseIf InReportName.ToUpper = "RCListing.rdlc".ToUpper Then
            MySources.Add(New ReportDataSource("CSInvReport_TRN_RC", InDataset.Tables("TRN_RC")))
            Return MySources
        ElseIf InReportName.ToUpper = "AJListing.rdlc".ToUpper Then
            MySources.Add(New ReportDataSource("CSInvReport_TRN_AJ", InDataset.Tables("TRN_AJ")))
            Return MySources
        ElseIf InReportName.ToUpper = "DeliveryOrder.rdlc".ToUpper Then
            DetailDataset = InDataset
            MySources.Add(New ReportDataSource("CSInvReport_PrintDO", InDataset.Tables("PrintDO")))
            MySources.Add(New ReportDataSource("CSInvReport_MST_COMPANY", InDataset.Tables("MST_COMPANY")))
            Return MySources
        ElseIf InReportName.ToUpper = "SimpleFinance.rdlc".ToUpper Then
            Dim MyDlg As FmBLPLDlg = New FmBLPLDlg
            MyDlg.SystemInfo = SystemInfo
            MyDlg.Dataset = dsAccRptDB
            MyDlg.TemplateCode.Enabled = False
            If MyDlg.ShowDialog = DialogResult.OK Then
                SystemManager.LoadSimpleFinanceRpt(CInt(MyDlg.ThisYear.Value), CInt(MyDlg.ThisMonth.Value), CInt(MyDlg.LastYear.Value), CInt(MyDlg.LastMonth.Value))
                Dim ReportName As New ReportParameter("REPORTNAME", "Balance Sheet / Profit & Lost")
                Dim pmAccYear1 As New ReportParameter("ACCYEAR1", CStr(MyDlg.ThisYear.Value))
                Dim pmAccMonth1 As New ReportParameter("ACCMONTH1", CStr(MyDlg.ThisMonth.Value))
                Dim pmAccYear2 As New ReportParameter("ACCYEAR2", CStr(MyDlg.LastYear.Value))
                Dim pmAccMonth2 As New ReportParameter("ACCMONTH2", CStr(MyDlg.LastMonth.Value))

                Dim Params() As ReportParameter = {ReportName, pmAccYear1, pmAccMonth1, pmAccYear2, pmAccMonth2}
                InLocalReport.SetParameters(Params)
                MySources.Add(New ReportDataSource("CSAccSimpleFinanceRptDataset_SIMPLEFINANCERPT", SystemManager.GetSimpleFinanceRpt.Tables("SIMPLEFINANCERPT")))
                Return MySources
            Else
                Return Nothing
            End If
        ElseIf InReportName.ToUpper = "ItemStockTakeList.rdlc".ToUpper Then
            Dim MyDlg As FmWHYearMonthDlg = New FmWHYearMonthDlg
            MyDlg.SystemInfo = SystemInfo
            SystemManager.LoadCSAccReporting_WH()
            MyDlg.Dataset = SystemManager.GetCSAccReporting
            If MyDlg.ShowDialog = DialogResult.OK Then
                SystemManager.LoadCSAccReporting_StkTake(CInt(MyDlg.WH_NAMEComboBox.SelectedValue), CInt(MyDlg.udYear.Value), CInt(MyDlg.udMonth.Value))
                Dim pmAccYear As New ReportParameter("ItemYear", CStr(MyDlg.udYear.Value))
                Dim pmAccMonth As New ReportParameter("ItemMonth", CStr(MyDlg.udMonth.Value))
                Dim pmOutletName As New ReportParameter("OutletName", MyDlg.WH_NAMEComboBox.Text)
                Dim Params() As ReportParameter = {pmAccYear, pmAccMonth, pmOutletName}
                InLocalReport.SetParameters(Params)
                MySources.Add(New ReportDataSource("CSAccReporting_STKTAKELIST", SystemManager.GetCSAccReporting.Tables("STKTAKELIST")))
                Return MySources
            Else
                Return Nothing
            End If
        ElseIf InReportName.ToUpper = "AccHistoryListing.rdlc".ToUpper Then
            MySources.Add(New ReportDataSource("CSSummaryDataset_TRN_ACCHISTORY", InDataset.Tables("TRN_ACCHISTORY")))
            Return MySources
        ElseIf InReportName.ToUpper = "Receiving.rdlc".ToUpper Then
            DetailDataset = InDataset
            If FilterKey <> "" Then
                Dim FilterParam As New ReportParameter("RCNO", FilterKey)
                Dim Params() As ReportParameter = {FilterParam}
                InLocalReport.SetParameters(Params)
            End If
            MySources.Add(New ReportDataSource("CSInvRcvDataset_MST_COMPANY", InDataset.Tables("MST_COMPANY")))
            MySources.Add(New ReportDataSource("CSInvRcvDataset_TRN_RC", InDataset.Tables("TRN_RC")))
            Return MySources
        ElseIf InReportName.ToUpper = "CashBill.rdlc".ToUpper Then
            DetailDataset = InDataset
            If FilterKey <> "" Then
                Dim FilterParam As New ReportParameter("CBNO", FilterKey)
                Dim Params() As ReportParameter = {FilterParam}
                InLocalReport.SetParameters(Params)
            End If
            MySources.Add(New ReportDataSource("CSInvCashBillDataset_TRN_CASHBILL", InDataset.Tables("TRN_CASHBILL")))
            MySources.Add(New ReportDataSource("CSInvCashBillDataset_MST_CUSTOMER", InDataset.Tables("MST_CUSTOMER")))
            MySources.Add(New ReportDataSource("CSInvCashBillDataset_MST_COMPANY", InDataset.Tables("MST_COMPANY")))
            Return MySources
        Else
            Return Nothing
        End If
    End Function

    Public Sub Preview(Optional ByVal InDataset As DataSet = Nothing, Optional ByVal FilterKey As String = "") Implements CSAccountDatabaseIntf.iCSReport.Preview
        DisposeForm()
        CreatePreview()
        PreviewForm.ReportViewer.LocalReport.ReportPath = Application.StartupPath + "\Reports\" + m_ReportName
        Dim MyRptSources As ArrayList = GetReportDatasource(PreviewForm.ReportViewer.LocalReport, m_ReportName, InDataset, FilterKey)
        If MyRptSources IsNot Nothing Then
            For Each MySource As ReportDataSource In MyRptSources
                PreviewForm.ReportViewer.LocalReport.DataSources.Add(MySource)
            Next
            PreviewForm.Show()
            PreviewForm.ReportViewer.RefreshReport()
        End If
    End Sub

    Public Sub Print(Optional ByVal InDataset As DataSet = Nothing, Optional ByVal FilterKey As String = "") Implements CSAccountDatabaseIntf.iCSReport.Print
        DisposeForm()
        CreatePreview()
        PreviewForm.ReportViewer.LocalReport.ReportPath = Application.StartupPath + "\Reports\" + m_ReportName
        Dim MyRptSources As ArrayList = GetReportDatasource(PreviewForm.ReportViewer.LocalReport, m_ReportName, InDataset, FilterKey)
        If MyRptSources IsNot Nothing Then
            For Each MySource As ReportDataSource In MyRptSources
                PreviewForm.ReportViewer.LocalReport.DataSources.Add(MySource)
            Next
            PreviewForm.Show()
            PreviewForm.ReportViewer.PrintDialog()
        End If
    End Sub

    Private DetailDataset As DataSet
    Private Sub SubReportProcessing(ByVal sender As Object, ByVal e As SubreportProcessingEventArgs)
        If e.ReportPath.ToUpper = "CustomerInvoiceDetails".ToUpper Then
            e.DataSources.Add(New ReportDataSource("CSAccReceivableDataset_TRN_ARINV", DetailDataset.Tables("TRN_ARINV")))
            e.DataSources.Add(New ReportDataSource("CSAccReceivableDataset_TRN_ARINVD", DetailDataset.Tables("TRN_ARINVD")))
            e.DataSources.Add(New ReportDataSource("CSAccReceivableDataset_MST_TAX", DetailDataset.Tables("MST_TAX")))
        ElseIf e.ReportPath.ToUpper = "CustomerReceiptDetails".ToUpper Then
            e.DataSources.Add(New ReportDataSource("CSARChequeDataset_TRN_ARCHEQUED", DetailDataset.Tables("TRN_ARCHEQUED")))
        ElseIf e.ReportPath.ToUpper = "CustomerStatementDetails".ToUpper Then
            e.DataSources.Add(New ReportDataSource("CSAccReporting_SMY_INVPAYDETAIL", DetailDataset.Tables("SMY_INVPAYDETAIL")))
        ElseIf e.ReportPath.ToUpper = "DeliveryOrderDetails".ToUpper Then
            e.DataSources.Add(New ReportDataSource("CSInvReport_PrintDOD", DetailDataset.Tables("PrintDOD")))
        ElseIf e.ReportPath.ToUpper = "ReceivingDetails".ToUpper Then
            e.DataSources.Add(New ReportDataSource("CSInvRcvDataset_TRN_RCD", DetailDataset.Tables("TRN_RCD")))
        ElseIf e.ReportPath.ToUpper = "CashBillDetails".ToUpper Then
            e.DataSources.Add(New ReportDataSource("CSInvCashBillDataset_TRN_CASHBILL", DetailDataset.Tables("TRN_CASHBILL")))
            e.DataSources.Add(New ReportDataSource("CSInvCashBillDataset_TRN_CASHBILLD", DetailDataset.Tables("TRN_CASHBILLD")))
            e.DataSources.Add(New ReportDataSource("CSInvCashBillDataset_MST_TAX", DetailDataset.Tables("MST_TAX")))
        End If
    End Sub


    Private m_ReportName As String
    Public Property ReportName() As String Implements CSAccountDatabaseIntf.iCSReport.ReportName
        Get
            Return m_ReportName
        End Get
        Set(ByVal value As String)
            m_ReportName = value
        End Set
    End Property

    Private m_Parentform As Form
    Public Property ParentForm() As System.Windows.Forms.Form Implements CSAccountDatabaseIntf.iCSReport.ParentForm
        Get
            Return m_Parentform
        End Get
        Set(ByVal value As System.Windows.Forms.Form)
            m_Parentform = value
        End Set
    End Property

    Private disposedValue As Boolean = False        ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: free managed resources when explicitly called
                DisposeForm()
            End If

            ' TODO: free shared unmanaged resources
        End If
        Me.disposedValue = True
    End Sub

#Region " IDisposable Support "
    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

    Private m_SystemManager As ICSAccountDatabaseIntf
    Public Property SystemManager() As CSAccountDatabaseIntf.ICSAccountDatabaseIntf Implements CSAccountDatabaseIntf.iCSReport.SystemManager
        Get
            Return m_SystemManager
        End Get
        Set(ByVal value As CSAccountDatabaseIntf.ICSAccountDatabaseIntf)
            m_SystemManager = value
            CreatedsAccRptDB()
            SystemManager.LoadCSAccRptDataset()
            dsAccRptDB = SystemManager.GetCSAccRptDataset()
        End Set
    End Property

    Public Sub DisposeForm() Implements CSAccountDatabaseIntf.iCSReport.DisposeForm
        If PreviewForm IsNot Nothing Then
            PreviewForm.Close()
            PreviewForm.Dispose()
            PreviewForm = Nothing
        End If
    End Sub

    Private m_SystemInfo As CSSystemInfo
    Public Property SystemInfo() As CSCommon.CSSystemInfo Implements CSAccountDatabaseIntf.iCSReport.SystemInfo
        Get
            Return m_SystemInfo
        End Get
        Set(ByVal value As CSCommon.CSSystemInfo)
            m_SystemInfo = value
        End Set
    End Property
End Class
