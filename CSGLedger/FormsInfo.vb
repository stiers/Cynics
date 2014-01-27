Imports CSCommon
Imports CSAccountDatabaseIntf

Public Class FormsInfo
    Inherits FormsInfoDef

    Public Sub New()
        MyBase.New()
        AddForm("Account Settings", "CSGLedger.FmAccount", GetType(FmAccount), My.Resources.account_setting1)
        AddForm("General Ledger", "CSGLedger.FmGL", GetType(FmGL), My.Resources.general_ledger1)
        AddForm("Currency Settings", "CSGLedger.FmCurrency", GetType(FmCurrency), My.Resources.currency_setting1)
        AddForm("Company Setup", "CSGLedger.FmCompany", GetType(FmCompany), My.Resources.campang_setup1)
        AddForm("Bank Settings", "CSGLedger.FmBank", GetType(FmBank), My.Resources.bank_setting1)
        AddForm("Bank Book", "CSGLedger.FmBKBook", GetType(FmBkBook), My.Resources.Bank_Book1)
    End Sub
End Class
