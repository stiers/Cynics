Imports CSAccountDatabaseIntf
Public Class FmKeyCode
	Public Overrides Sub DBControlsEnabled(ByVal InValue As Boolean)
		MST_KEYCODEDataGridView.Enabled = InValue
	End Sub

	Public Overrides Property SystemManager() As CSAccountDatabaseIntf.ICSAccountDatabaseIntf
		Get
			Return MyBase.SystemManager
		End Get
		Set(ByVal value As CSAccountDatabaseIntf.ICSAccountDatabaseIntf)
			SetNavigatorVisible(False)
			MyBase.SystemManager = value
			Try
				SystemManager.LoadCSSystemDBDataset_KeyCode()
				CSSystemDBDataset = SystemManager.GetCSSystemDBDataset
				Dataset = CSSystemDBDataset
				Dim MyData() As DataRow
				MyData = CSSystemDBDataset.MST_KEYCODE.Select(String.Format("KEY_NAME = 'Delivery Order'"))
				If MyData.Length = 0 Then
					Dim NewData As CSSystemDBDataset.MST_KEYCODERow = CSSystemDBDataset.MST_KEYCODE.NewMST_KEYCODERow
					NewData("KEY_NAME") = "Delivery Order"
					NewData("PREFIX") = "DO"
					NewData("KEYNO") = "0"
					NewData("IS_ACTIVE") = "TRUE"
					CSSystemDBDataset.MST_KEYCODE.AddMST_KEYCODERow(NewData)
				End If

				MyData = CSSystemDBDataset.MST_KEYCODE.Select(String.Format("KEY_NAME = 'Invoice'"))
				If MyData.Length = 0 Then
					Dim NewData As CSSystemDBDataset.MST_KEYCODERow = CSSystemDBDataset.MST_KEYCODE.NewMST_KEYCODERow
					NewData("KEY_NAME") = "Invoice"
					NewData("PREFIX") = "IV"
					NewData("KEYNO") = "0"
					NewData("IS_ACTIVE") = "TRUE"
					CSSystemDBDataset.MST_KEYCODE.AddMST_KEYCODERow(NewData)
				End If

				MyData = CSSystemDBDataset.MST_KEYCODE.Select(String.Format("KEY_NAME = 'Adjustment'"))
				If MyData.Length = 0 Then
					Dim NewData As CSSystemDBDataset.MST_KEYCODERow = CSSystemDBDataset.MST_KEYCODE.NewMST_KEYCODERow
					NewData("KEY_NAME") = "Adjustment"
					NewData("PREFIX") = "AJ"
					NewData("KEYNO") = "0"
					NewData("IS_ACTIVE") = "TRUE"
					CSSystemDBDataset.MST_KEYCODE.AddMST_KEYCODERow(NewData)
				End If

				MyData = CSSystemDBDataset.MST_KEYCODE.Select(String.Format("KEY_NAME = 'Receiving'"))
				If MyData.Length = 0 Then
					Dim NewData As CSSystemDBDataset.MST_KEYCODERow = CSSystemDBDataset.MST_KEYCODE.NewMST_KEYCODERow
					NewData("KEY_NAME") = "Receiving"
					NewData("PREFIX") = "RC"
					NewData("KEYNO") = "0"
					NewData("IS_ACTIVE") = "TRUE"
					CSSystemDBDataset.MST_KEYCODE.AddMST_KEYCODERow(NewData)
				End If

                MyData = CSSystemDBDataset.MST_KEYCODE.Select(String.Format("KEY_NAME = 'Cash Bill'"))
                If MyData.Length = 0 Then
                    Dim NewData As CSSystemDBDataset.MST_KEYCODERow = CSSystemDBDataset.MST_KEYCODE.NewMST_KEYCODERow
                    NewData("KEY_NAME") = "Cash Bill"
                    NewData("PREFIX") = "CB"
                    NewData("KEYNO") = "0"
                    NewData("IS_ACTIVE") = "TRUE"
                    CSSystemDBDataset.MST_KEYCODE.AddMST_KEYCODERow(NewData)
                End If

                SystemManager.SaveCSSystemDBDatasetKeyCode(CSSystemDBDataset)
				CSSystemDBDataset.MST_KEYCODE.AcceptChanges()

				MST_KEYCODEBindingSource.DataSource = CSSystemDBDataset

			Catch ex As Exception
				If TypeOf ex Is System.Net.Sockets.SocketException Then
					MsgBox("Server inactive or no network connection !")
					Exit Property
				End If
				Throw ex
			End Try
		End Set
	End Property

	Public Overrides Sub CallAfterFormInit()
		AllowAdd = False
		AllowDel = False
		MyBase.CallAfterFormInit()
	End Sub

	Private Sub FmKeyCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		BindDataSource(MST_KEYCODEBindingSource)
	End Sub

	Private Sub MST_KEYCODEDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles MST_KEYCODEDataGridView.DataError
		HandleGridError(sender, e)
	End Sub

	Private Sub FmKeyCode_tsbtnSaveClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.tsbtnSaveClick
		MST_KEYCODEBindingSource.EndEdit()
		SystemManager.SaveCSSystemDBDatasetKeyCode(CSSystemDBDataset)
		CSSystemDBDataset.MST_KEYCODE.AcceptChanges()
	End Sub

	Private Sub FmKeyCode_BeforesbtnCancelClick(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.BeforesbtnCancelClick
		MST_KEYCODEBindingSource.CancelEdit()
		CSSystemDBDataset.MST_KEYCODE.RejectChanges()
	End Sub
End Class
