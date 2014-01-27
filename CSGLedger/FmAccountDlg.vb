Imports System.Windows.Forms

Public Class FmAccountDlg
    Sub SearchText(ByVal InText As String)
        TextBox1.Text = InText
        m_ACC_CODE = InText
        MST_ACCOUNTBindingSource.Position = MST_ACCOUNTBindingSource.Find("ACC_CODE", InText)
    End Sub

    Private m_ACC_CODE As String
    Public ReadOnly Property ACC_CODE() As String
        Get
            Return m_ACC_CODE
        End Get
    End Property

    Private m_ACC_NAME As String
    Public ReadOnly Property ACC_NAME() As String
        Get
            Return m_ACC_NAME
        End Get
    End Property

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Down
                If MST_ACCOUNTBindingSource.Position + 1 <> MST_ACCOUNTBindingSource.Count Then
                    MST_ACCOUNTBindingSource.Position += 1
                End If
                e.SuppressKeyPress = True
            Case Keys.Up
                If MST_ACCOUNTBindingSource.Position > 0 Then
                    MST_ACCOUNTBindingSource.Position -= 1
                End If
                e.SuppressKeyPress = True
            Case Keys.Space
                If e.Control = False Then
                    Exit Sub
                End If

                If rbAccountCode.Checked Then
                    Dim FirstFind() As DataRow = CSAccountDataset.MST_ACCOUNT.Select(String.Format("ACC_CODE='{0}'", TextBox1.Text))
                    If FirstFind.Length > 0 Then
                        MST_ACCOUNTBindingSource.Position = MST_ACCOUNTBindingSource.Find("ACC_CODE", FirstFind(0)("ACC_CODE"))
                    Else
                        Dim MyData() As DataRow = CSAccountDataset.MST_ACCOUNT.Select(String.Format("ACC_CODE LIKE '{0}*'", TextBox1.Text))
                        Dim TmpItem As String = ""

                        If MyData.Length > 0 Then
                            TmpItem = CStr(MyData(0)("ACC_CODE"))
                        End If

                        MST_ACCOUNTBindingSource.Position = MST_ACCOUNTBindingSource.Find("ACC_CODE", TmpItem)
                    End If
                ElseIf rbAccountName.Checked Then
                    Dim FirstFind() As DataRow = CSAccountDataset.MST_ACCOUNT.Select(String.Format("ACC_NAME='{0}'", TextBox1.Text))
                    If FirstFind.Length > 0 Then
                        MST_ACCOUNTBindingSource.Position = MST_ACCOUNTBindingSource.Find("ACC_NAME", FirstFind(0)("ACC_NAME"))
                    Else
                        Dim MyData() As DataRow = CSAccountDataset.MST_ACCOUNT.Select(String.Format("ACC_NAME LIKE '{0}*'", TextBox1.Text))
                        Dim TmpItem As String = ""

                        If MyData.Length > 0 Then
                            TmpItem = CStr(MyData(0)("ACC_NAME"))
                        End If

                        MST_ACCOUNTBindingSource.Position = MST_ACCOUNTBindingSource.Find("ACC_NAME", TmpItem)
                    End If
                End If
            Case Keys.Enter
                OK_Button_Click(OK_Button, Nothing)
        End Select
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Close()
        m_ACC_CODE = ""
        m_ACC_NAME = ""
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        DialogResult = Windows.Forms.DialogResult.OK
        Close()
        Dim MyAcc As DataRowView = CType(MST_ACCOUNTBindingSource.Current, DataRowView)
        If MyAcc Is Nothing Then
            m_ACC_CODE = ""
            m_ACC_NAME = ""
        Else
            m_ACC_CODE = CStr(MyAcc("ACC_CODE"))
            m_ACC_NAME = CStr(MyAcc("ACC_NAME"))
        End If
    End Sub

    Private Sub FmAccountDlg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Select()
    End Sub

	Private Sub FmAccountDlg_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
		If e.Control = True Then
			If e.KeyCode = Keys.D1 Then
				rbAccountCode.Checked = True
			ElseIf e.KeyCode = Keys.D2 Then
				rbAccountName.Checked = True
			End If
		Else
			If e.KeyCode = Keys.Return Then
				OK_Button_Click(Me, Nothing)
			ElseIf e.KeyCode = Keys.Escape Then
				Cancel_Button_Click(Me, Nothing)
			End If
		End If
	End Sub
End Class
