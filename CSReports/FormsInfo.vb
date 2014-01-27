Imports CSCommon
Imports CSAccountDatabaseIntf

Public Class FormsInfo
    Inherits FormsInfoDef

    Public Sub New()
        MyBase.New()
        AddForm("Financial Report", "BLPL.rdlc", Nothing, My.Resources.fina_report1)
        AddForm("Simple Finance Rpt", "SimpleFinance.rdlc", Nothing, My.Resources.fina_report1)
        AddForm("Open Payable Report", "OpenPayable.rdlc", Nothing, My.Resources.open_payable_report1)
        AddForm("Customers' Aging Report", "CustomersAging.rdlc", Nothing, My.Resources.anging_report1)
        AddForm("Customer Statement Report", "CustomerStatement.rdlc", Nothing, My.Resources.custermer_statement_report1)
		AddForm("Trial Balance Report", "TrialBalance.rdlc", Nothing, My.Resources.trial_belane_report1)
		AddForm("Stock Take List", "ItemStockTakeList.rdlc", Nothing, My.Resources.stock_take_list1)
    End Sub
End Class
