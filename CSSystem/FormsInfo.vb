Imports CSCommon
Imports CSAccountDatabaseIntf

Public Class FormsInfo
    Inherits FormsInfoDef

    Public Sub New()
        MyBase.New()
        AddForm("Security Settings", "CSSystem.FmSecurity", GetType(CSSystem.FmSecurity), My.Resources.security_setting1) 'Resources
		AddForm("Document Code", "CSSystem.FmKeyCode", GetType(CSSystem.FmKeyCode), My.Resources.inventory_history1)
	End Sub
End Class
