Imports System.Windows.forms
Imports CSCommon
Imports System.ComponentModel
Public Class StdDBForm

    Friend Sub DoAfterCallFormSearch(ByVal Sender As Object, ByVal e As EventArgs)
        RaiseEvent AfterCallFormSearch(Sender, e)
    End Sub

    Private m_ShowNavigator As Boolean = True
    Public Property ShowNavigator() As Boolean
        Get
            Return m_ShowNavigator
        End Get
        Set(ByVal value As Boolean)
            m_ShowNavigator = value
            BindingNavigator1.Visible = value
            MenuStrip1.Visible = value
        End Set
    End Property

    Public AllowAdd As Boolean
    Public AllowEdit As Boolean
    Public AllowDel As Boolean
    Private m_AllowPrint As Boolean
    Public Property AllowPrint() As Boolean
        Get
            Return m_AllowPrint
        End Get
        Set(ByVal value As Boolean)
            m_AllowPrint = value
            tsbtnPrint.Enabled = m_AllowPrint
        End Set
    End Property

    Private m_PrintEngine As iCSReport
    Property PrintEngine() As iCSReport
        Get
            Return m_PrintEngine
        End Get
        Set(ByVal value As iCSReport)
            m_PrintEngine = value
            m_PrintEngine.ParentForm = MdiParent
        End Set
    End Property

    Private m_DBStatus As FormDBStatus = FormDBStatus.FormBrowse
    Public Property DBStatus() As FormDBStatus
        Get
            Return m_DBStatus
        End Get
        Set(ByVal value As FormDBStatus)
            m_DBStatus = value
            Dim NewEvent As EventArgs = New EventArgs
            RaiseEvent DBStatusChanged(Me, NewEvent)
        End Set
    End Property

    Protected m_KeyInfo As FormKeyInfo
    Public Overridable Property KeyInfo() As FormKeyInfo
        Get
            Return m_KeyInfo
        End Get
        Set(ByVal value As FormKeyInfo)
            m_KeyInfo = value
        End Set
    End Property

    Protected ErrorControlList As ArrayList = New ArrayList
    Protected Sub ClearErrorControlList()
        For Each MyControl As Control In ErrorControlList
            ErrorProvider1.SetError(MyControl, "")
        Next
    End Sub

    Public FormsSecurityInfo As ArrayList
    Public Event DBStatusChanged As EventHandler
    Public Event tsbtnSaveClick As EventHandler
    Public Event tsbtnCancelClick As EventHandler
    Public Event tsbtnEditClick As EventHandler
    Public Event tsbtnNewClick As EventHandler
    Public Event BeforeNewAndEdit As BeforeAfterNewAndEditEvent
    Public Event AfterNewAndEdit As BeforeAfterNewAndEditEvent
    Public Event BeforeDelete As CancelEventHandler
    Public Event AfterDelete As EventHandler
    Public Event BeforesbtnSaveclick As CancelEventHandler
    Public Event BeforesbtnCancelClick As CancelEventHandler
    Public Event AftertsbtnSaveclick As EventHandler
    Public Event AftertsbtnCancelClick As EventHandler
    Public Event BeforeValidateSave As EventHandler
    Public Event AfterValidateSave As EventHandler
    Public Event BeforeCtrlEnableSave As EventHandler
    Public Event AfterCtrlEnableSave As EventHandler
    Public Event tsbtnPrintClick As EventHandler
    Public Event AfterCallFormSearch As EventHandler
    Public Event BeforeCallForm As BeforeAfterCallForm
    Public Event AfterCallForm As BeforeAfterCallForm

    Public Function ValidateTextBlank(ByVal InControl As Control, ByVal ErrorMsg As String) As Boolean
        If DBStatus <> FormDBStatus.FormDel Then 'Skip checking if deleting
            If BindingNavigator1.BindingSource.Count > 0 Then
                If InControl.Text.Length = 0 Then
                    SetFormError(InControl, ErrorMsg)
                    Return False
                Else
                    SetFormError(InControl, "")
                    Return True
                End If
            End If
        End If
    End Function

    Public Overridable ReadOnly Property FirstControl() As Control
        Get
            Return Nothing
        End Get
    End Property

    Private m_Dataset As DataSet
    Public Overridable Property Dataset() As DataSet
        Get
            Return m_Dataset
        End Get
        Set(ByVal value As DataSet)
            m_Dataset = value
        End Set
    End Property

    Protected NeedSave As Boolean = False

    Public Overridable Sub DBControlsEnabled(ByVal InValue As Boolean)

    End Sub

    Protected Overridable Sub CheckNvgButtons()
        If NeedSave = True Then
            BindingNavigatorMoveFirstItem.Enabled = False
            BindingNavigatorMoveNextItem.Enabled = False
            BindingNavigatorMovePreviousItem.Enabled = False
            BindingNavigatorMoveLastItem.Enabled = False
            BindingNavigatorAddNewItem.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False
            tsbtnEdit.Enabled = False
        Else
            BindingNavigator1.MoveFirstItem = Nothing
            BindingNavigator1.MoveFirstItem = BindingNavigatorMoveFirstItem 'Reset one of the button to cause refresh on navigator buttons
            If BindingNavigator1.BindingSource IsNot Nothing Then
                BindingNavigatorAddNewItem.Enabled = (AllowAdd = True)
                tsbtnEdit.Enabled = (AllowEdit = True) And (BindingNavigator1.BindingSource.Count > 0)
                BindingNavigatorDeleteItem.Enabled = (AllowDel = True) And (BindingNavigator1.BindingSource.Count > 0)
            Else
                BindingNavigatorAddNewItem.Enabled = False
                tsbtnEdit.Enabled = False
                BindingNavigatorDeleteItem.Enabled = False
            End If
        End If
    End Sub


    Protected Sub SaveCancelEnabled(ByVal InValue As Boolean)
        NeedSave = InValue
        tsbtnSave.Enabled = InValue
        tsbtnCancel.Enabled = InValue
        CheckNvgButtons()
    End Sub

    Private m_Source As BindingSource

    Protected Sub BindDataSource(ByVal InSource As BindingSource)
        ErrorProvider1.DataSource = InSource
        BindingNavigator1.BindingSource = InSource
        m_Source = InSource
        AddHandler BindingNavigator1.BindingSource.PositionChanged, AddressOf BindingSource_PositionChanged
        CheckNvgButtons()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        If AllowDel Then
            Dim LastStatus As FormDBStatus = DBStatus
            DBStatus = FormDBStatus.FormDel
            Dim MyCancel As CancelEventArgs = New CancelEventArgs
            MyCancel.Cancel = False
            RaiseEvent BeforeDelete(sender, MyCancel)
            If MyCancel.Cancel = False Then
                If Dataset IsNot Nothing Then
                    Dataset.RejectChanges() 'To avoid any unwanted update to other records
                End If
            End If
            If MyCancel.Cancel = False Then
                If BindingNavigator1.BindingSource IsNot Nothing Then
                    If MessageBox.Show("Confirm Delete ?", "Delete Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                        Dim MyRow As DataRowView = CType(BindingNavigator1.BindingSource.Current, DataRowView)
                        If MyRow IsNot Nothing Then
                            MyRow.Delete()
                            NeedSave = True
                            DBControlsEnabled(False)
                            SaveCancelEnabled(True)
                            CheckNvgButtons()
                            RaiseEvent AfterDelete(sender, e)
                        End If
                    End If
                End If
            Else
                DBStatus = LastStatus
            End If
        End If
    End Sub

    Protected Sub tsbtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnSave.Click
        Dim ValidResult As Boolean = True

        If BindingNavigator1.BindingSource IsNot Nothing Then
            If BindingNavigator1.BindingSource.Count > 0 Then
                RaiseEvent BeforeValidateSave(sender, e)
                ValidResult = Validate()
                If ValidResult Then
                    ValidResult = ValidateChildren()
                End If
                RaiseEvent AfterValidateSave(sender, e)
            End If
        End If

        If ValidResult Then
            Dim MyCancelArgs As CancelEventArgs = New CancelEventArgs

            MyCancelArgs.Cancel = False

            Dim LastStatus As FormDBStatus = DBStatus
            If DBStatus = FormDBStatus.FormAdd Then
                Dim MySource As BindingSource = BindingNavigator1.BindingSource
                Dim MyTable As DataTable = Dataset.Tables(MySource.DataMember)
                If MyTable.Columns(0).Unique Then
                    If MyTable.Columns(0).DataType Is System.Type.GetType("System.String") Then
                        Dim MyRow() As DataRow = MyTable.Select(MyTable.Columns(0).ColumnName + _
                            "='" + CStr(CType(MySource.Current, DataRowView)(MyTable.Columns(0).ColumnName)) + "'")
                        If MyRow.Length > 0 Then
                            MsgBox("Code / No already exists !")
                            If FirstControl IsNot Nothing Then
                                FirstControl.Select()
                            End If
                            MyCancelArgs.Cancel = True
                        End If
                    End If
                End If
            Else
                DBStatus = LastStatus
            End If

            Dim HeaderPOS As Integer = -1

            If BindingNavigator1.BindingSource IsNot Nothing Then
                HeaderPOS = BindingNavigator1.BindingSource.Position
            End If

            If MyCancelArgs.Cancel = False Then
                RaiseEvent BeforesbtnSaveclick(sender, MyCancelArgs)
            End If

            If MyCancelArgs.Cancel = False Then
                If ErrorControlList.Count > 0 Then
                    MsgBox("Please clear all error before save !")
                    Exit Sub
                End If

                Try
                    NeedSave = False
                    RaiseEvent tsbtnSaveClick(sender, e)
                    RaiseEvent BeforeCtrlEnableSave(sender, e)
                    DBControlsEnabled(NeedSave)
                    RaiseEvent AfterCtrlEnableSave(sender, e)
                    SaveCancelEnabled(NeedSave)
                    RaiseEvent AftertsbtnSaveclick(sender, e)
                    DBStatus = FormDBStatus.FormBrowse
                Catch ex As Exception
                    If TypeOf ex Is System.Data.ConstraintException Then
                        MsgBox("Code already exists !")
                    Else
                        MsgBox(ex.Message)
                    End If
                    NeedSave = True
                    RaiseEvent BeforeCtrlEnableSave(sender, e)
                    DBControlsEnabled(NeedSave)
                    RaiseEvent AfterCtrlEnableSave(sender, e)
                    SaveCancelEnabled(NeedSave)
                End Try
            End If

            If BindingNavigator1.BindingSource IsNot Nothing Then
                If HeaderPOS <> -1 Then
                    BindingNavigator1.BindingSource.Position = HeaderPOS
                End If
            End If
        End If
    End Sub

    Private Sub tsbtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnCancel.Click
        Dim MyCancelArgs As CancelEventArgs = New CancelEventArgs

        MyCancelArgs.Cancel = False

        RaiseEvent BeforesbtnCancelClick(sender, MyCancelArgs)

        If MyCancelArgs.Cancel = False Then
            Try
                NeedSave = False
                RaiseEvent tsbtnCancelClick(sender, e)
                DBControlsEnabled(NeedSave)
                SaveCancelEnabled(NeedSave)
                RaiseEvent AftertsbtnCancelClick(sender, e)
                ClearErrorControlList()
                DBStatus = FormDBStatus.FormBrowse
            Catch ex As Exception
                MsgBox(ex.Message)
                NeedSave = True
                DBControlsEnabled(NeedSave)
                SaveCancelEnabled(NeedSave)
            End Try
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.EnabledChanged
        AddToolStripMenuItem.Enabled = BindingNavigatorAddNewItem.Enabled
    End Sub

    Private Sub StdDBForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If NeedSave Then
            If MessageBox.Show("Data not save, continue to close form ?", "Data not save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            Else
                e.Cancel = False
            End If
        End If
    End Sub

    Private Sub tsbtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnEdit.Click
        If AllowEdit Then
            Dim LastStatus As FormDBStatus = DBStatus
            DBStatus = FormDBStatus.FormEdit
            Dim MyEvent As BeforeAfterEditNewEventAgrs = New BeforeAfterEditNewEventAgrs
            MyEvent.IsNew = False
            MyEvent.Cancel = False
            RaiseEvent BeforeNewAndEdit(sender, MyEvent)
            If MyEvent.Cancel = False Then
                If Dataset IsNot Nothing Then
                    Dataset.RejectChanges() 'To avoid any unwanted update to other records
                End If
            End If
            If MyEvent.Cancel = False Then
                NeedSave = True
                DBControlsEnabled(True)
                SaveCancelEnabled(NeedSave)
                RaiseEvent tsbtnEditClick(sender, e)
                RaiseEvent AfterNewAndEdit(sender, MyEvent)
                If FirstControl IsNot Nothing Then
                    FirstControl.Select()
                End If
            Else
                DBStatus = LastStatus
            End If
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        If BindingNavigator1.BindingSource IsNot Nothing Then
            If AllowAdd Then
                Dim LastStatus As FormDBStatus = DBStatus
                DBStatus = FormDBStatus.FormAdd
                Dim MyEvent As BeforeAfterEditNewEventAgrs = New BeforeAfterEditNewEventAgrs
                MyEvent.IsNew = True
                MyEvent.Cancel = False
                RaiseEvent BeforeNewAndEdit(sender, MyEvent)
                If MyEvent.Cancel = False Then
                    If Dataset IsNot Nothing Then
                        Dataset.RejectChanges() 'To avoid any unwanted update to other records
                    End If
                End If
                If MyEvent.Cancel = False Then
                    BindingNavigator1.BindingSource.AddNew()
                    NeedSave = True
                    DBControlsEnabled(True)
                    SaveCancelEnabled(True)
                    CheckNvgButtons()
                    RaiseEvent AfterNewAndEdit(sender, MyEvent)
                    If FirstControl IsNot Nothing Then
                        FirstControl.Select()
                    End If
                Else
                    DBStatus = LastStatus
                End If
            End If
        End If

        If AllowAdd Then
            RaiseEvent tsbtnNewClick(sender, e)
        End If
    End Sub

    Private Sub StdDBForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DBControlsEnabled(False)
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        BindingNavigatorAddNewItem_Click(sender, e)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        BindingNavigatorDeleteItem_Click(sender, e)
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        tsbtnEdit_Click(sender, e)
    End Sub

    Private Sub BindingNavigatorMoveFirstItem_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorMoveFirstItem.EnabledChanged
        FirstToolStripMenuItem.Enabled = BindingNavigatorMoveFirstItem.Enabled
    End Sub

    Private Sub BindingNavigatorMovePreviousItem_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorMovePreviousItem.EnabledChanged
        PreviousToolStripMenuItem.Enabled = BindingNavigatorMovePreviousItem.Enabled
    End Sub

    Private Sub BindingNavigatorMoveNextItem_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorMoveNextItem.EnabledChanged
        NextToolStripMenuItem.Enabled = BindingNavigatorMoveNextItem.Enabled
    End Sub

    Private Sub BindingNavigatorMoveLastItem_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorMoveLastItem.EnabledChanged
        LastToolStripMenuItem.Enabled = BindingNavigatorMoveLastItem.Enabled
    End Sub

    Private Sub BindingNavigatorDeleteItem_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.EnabledChanged
        DeleteToolStripMenuItem.Enabled = BindingNavigatorDeleteItem.Enabled
    End Sub

    Private Sub tsbtnEdit_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnEdit.EnabledChanged
        EditToolStripMenuItem.Enabled = tsbtnEdit.Enabled
    End Sub

    Private Sub tsbtnSave_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnSave.EnabledChanged
        SaveToolStripMenuItem.Enabled = tsbtnSave.Enabled
    End Sub

    Private Sub tsbtnCancel_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnCancel.EnabledChanged
        CancelToolStripMenuItem.Enabled = tsbtnCancel.Enabled
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        tsbtnSave_Click(sender, e)
    End Sub

    Private Sub CancelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelToolStripMenuItem.Click
        tsbtnCancel_Click(sender, e)
    End Sub

    Protected Sub BindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CheckNvgButtons()
    End Sub

    Private Sub BindingNavigator1_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigator1.EnabledChanged
        DataNavigatorToolStripMenuItem.Enabled = BindingNavigator1.Enabled
    End Sub

    Public Function CheckSkipValidate() As Boolean
        If BindingNavigator1.BindingSource IsNot Nothing Then
            Return Not (((DBStatus = FormDBStatus.FormAdd) Or (DBStatus = FormDBStatus.FormEdit)) And (BindingNavigator1.BindingSource.Count > 0))
        Else
            Return True
        End If
    End Function

    Public Overrides Sub CallAfterFormInit()
        MyBase.CallAfterFormInit()
        CheckNvgButtons()
    End Sub

    Public Sub SetFormError(ByVal InControl As Control, ByVal InErrMsg As String)
        ErrorProvider1.SetError(InControl, InErrMsg)
        If InErrMsg <> "" Then
            If ErrorControlList.IndexOf(InControl) = -1 Then
                ErrorControlList.Add(InControl)
            End If
        Else
            ErrorControlList.Remove(InControl)
        End If
    End Sub

    Public Sub ForceUpperGridColumnTextbox(ByVal InDataGridView As DataGridView, ByVal e As DataGridViewEditingControlShowingEventArgs, ByVal ColumnControlName As String)
        'Force grid view control for acc# to be uppercase all the time
        If TypeOf e.Control Is TextBox Then
            If InDataGridView.Columns(InDataGridView.CurrentCell.ColumnIndex).Name = ColumnControlName Then
                CType(e.Control, TextBox).CharacterCasing = CharacterCasing.Upper
            Else
                CType(e.Control, TextBox).CharacterCasing = CharacterCasing.Normal
            End If
        End If
    End Sub

    Public Function CheckUnique(ByVal InTable As DataTable, ByVal InBinding As BindingSource, _
    ByVal InControl As Control, ByVal KeyNo As String, ByVal KeyCode As String, ByVal ErrMsg As String) As Boolean
        If DBStatus <> FormDBStatus.FormDel Then 'Skip checking if deleting
            Dim MyRow() As DataRow = InTable.Select(KeyCode + "='" + InControl.Text + "'")
            If MyRow.Length > 0 Then
                If CInt(MyRow(0)(KeyNo)) <> CInt(CType(InBinding.Current, DataRowView)(KeyNo)) Then
                    SetFormError(InControl, ErrMsg)
                    Return False
                Else
                    SetFormError(InControl, "")
                    Return True
                End If
            Else
                Return True
            End If
        End If
    End Function

    Private Sub tsbtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnPrint.Click
        If BindingNavigator1.BindingSource IsNot Nothing Then
            Dim MySource As BindingSource = BindingNavigator1.BindingSource
            If MySource.Count > 0 Then
                RaiseEvent tsbtnPrintClick(sender, e)
            End If
        End If
    End Sub

    Public Sub PrintReport(ByVal InReportName As String, Optional ByVal InDataset As DataSet = Nothing, Optional ByVal FilterKey As String = "")
        PrintEngine.ReportName = InReportName
        PrintEngine.SystemManager = SystemManager
        PrintEngine.SystemInfo = SystemInfo
        PrintEngine.Preview(InDataset, FilterKey)
    End Sub

    Public Function GetFormSecurityInfo(ByVal InClassName As String) As FormCreateInfoDef
        Dim ReturnValue As FormCreateInfoDef = Nothing

        If FormsSecurityInfo IsNot Nothing Then
            For Each MyInfo As FormCreateInfoDef In FormsSecurityInfo
                If MyInfo.ClassName = InClassName Then
                    ReturnValue = MyInfo
                End If
            Next
        End If

        Return ReturnValue
    End Function

    Private MyBinding As BindingSource
    Private ldKeyName As String
    Private ldKeyCode As String
    Private ldCurrentForm As StdDBForm

    Private Sub GetBindingWhenLoad(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MyBinding = ldCurrentForm.BindingNavigator1.BindingSource

        If MyBinding IsNot Nothing Then
            If ldKeyName <> "" Then
                MyBinding.Position = MyBinding.Find(ldKeyName, ldKeyCode)
            End If
        End If

        ldCurrentForm.DoAfterCallFormSearch(sender, e)
    End Sub

    Public Function CallForm(ByVal InFormName As String, Optional ByVal TableName As String = "", Optional ByVal KeyName As String = "", Optional ByVal KeyCode As String = "") As FormKeyInfo
        Dim MyInfo As FormCreateInfoDef = GetFormSecurityInfo(InFormName)

        Try
            Dim MyFormsInfo As FormsInfoDef = _
            CType(Activator.CreateInstance(MyInfo.AssemblyName, MyInfo.AssemblyName + ".FormsInfo").Unwrap, FormsInfoDef)

            Dim CurrentForm As StdDBForm

            CurrentForm = CType(MyFormsInfo.CreateForm(MyInfo.ClassName), StdDBForm)
            CurrentForm.SystemInfo = SystemInfo
            CurrentForm.AllowAdd = MyInfo.AllowAdd
            CurrentForm.AllowEdit = MyInfo.AllowEdit
            CurrentForm.AllowDel = MyInfo.AllowDel
            CurrentForm.AllowPrint = MyInfo.AllowPrint
            CurrentForm.PrintEngine = PrintEngine
            CurrentForm.Text = MyInfo.Description
            CurrentForm.SystemManager = SystemManager
            CurrentForm.FormsSecurityInfo = FormsSecurityInfo
            CurrentForm.CallAfterFormInit()
            AddHandler CurrentForm.Load, AddressOf GetBindingWhenLoad
            ldKeyName = KeyName
            ldKeyCode = KeyCode
            ldCurrentForm = CurrentForm
            RaiseEvent BeforeCallForm(CurrentForm, Nothing, Nothing)
            CurrentForm.ShowDialog()

            Dim MyKeyInfo As FormKeyInfo

            MyKeyInfo.KeyNo = -1
            MyKeyInfo.KeyCode = ""

            If MyBinding IsNot Nothing Then
                If MyBinding.Current IsNot Nothing Then
                    MyKeyInfo.KeyNo = CurrentForm.KeyInfo.KeyNo
                    MyKeyInfo.KeyCode = CurrentForm.KeyInfo.KeyCode
                End If
            End If

            If TableName <> "" Then
                If Dataset IsNot Nothing Then
                    Dataset.Tables(TableName).Clear()
                    Dataset.Tables(TableName).Merge(CurrentForm.Dataset.Tables(TableName))
                    Dataset.Tables(TableName).AcceptChanges()
                End If
            End If

            RaiseEvent AfterCallForm(CurrentForm, MyKeyInfo, CurrentForm.Dataset)

            CurrentForm = Nothing

            Return MyKeyInfo
        Catch ex As Exception
            If TypeOf ex Is TypeLoadException Then
                MsgBox("This function is not available in this package !")
            Else
                MsgBox(ex.Message)
            End If
            Return Nothing
        End Try
    End Function

    Private Sub FirstToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirstToolStripMenuItem.Click
        If BindingNavigator1.BindingSource IsNot Nothing Then
            BindingNavigator1.BindingSource.MoveFirst()
        End If
    End Sub

    Private Sub PreviousToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviousToolStripMenuItem.Click
        If BindingNavigator1.BindingSource IsNot Nothing Then
            BindingNavigator1.BindingSource.MovePrevious()
        End If
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        If BindingNavigator1.BindingSource IsNot Nothing Then
            BindingNavigator1.BindingSource.MoveNext()
        End If
    End Sub

    Private Sub LastToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LastToolStripMenuItem.Click
        If BindingNavigator1.BindingSource IsNot Nothing Then
            BindingNavigator1.BindingSource.MoveLast()
        End If
    End Sub

    Public Function ValidateLength(ByVal InControl As Control, Optional ByVal RequiredField As Boolean = False) As Boolean
        If DBStatus <> FormDBStatus.FormDel Then
            If (TypeOf InControl Is TextBox) Then
                Dim OrgDatasource As BindingSource = Nothing
                Dim MyDatasource As BindingSource = Nothing
                Dim BindingField As String = ""
                MyDatasource = CType(CType(InControl, TextBox).DataBindings("Text").DataSource, BindingSource)
                BindingField = CType(InControl, TextBox).DataBindings("Text").BindingMemberInfo.BindingField

                If MyDatasource IsNot Nothing Then
                    Dim CurrRow As DataRowView = CType(MyDatasource.Current, DataRowView)
                    Dim CurrTable As String = ""
                    Dim MyDataset As DataSet = Nothing
                    If TypeOf MyDatasource.DataSource Is DataSet Then
                        MyDataset = CType(MyDatasource.DataSource, DataSet)
                        CurrTable = MyDatasource.DataMember
                    End If

                    If CurrTable <> "" Then
                        If MyDataset.Tables(CurrTable).Columns(BindingField).DataType Is System.Type.GetType("System.String") Then
                            Dim MaxLen As Integer = MyDataset.Tables(CurrTable).Columns(BindingField).MaxLength
                            If RequiredField Then
                                If InControl.Text.Length = 0 Then
                                    SetFormError(InControl, "Field value required !")
                                    Return False
                                Else
                                    SetFormError(InControl, "")
                                End If
                            End If

                            If InControl.Text.Length > MaxLen Then
                                SetFormError(InControl, String.Format("Maximum field length : [{0:D}] Char(s) exceeded !", MaxLen))
                                Return False
                            Else
                                SetFormError(InControl, "")
                                Return True
                            End If
                        ElseIf MyDataset.Tables(CurrTable).Columns(BindingField).DataType Is System.Type.GetType("System.Decimal") Then
                            Dim dummyDecimal As Decimal
                            If Not Decimal.TryParse(InControl.Text, dummyDecimal) Then
                                SetFormError(InControl, "Value is not decimal !")
                                Return False
                            Else
                                SetFormError(InControl, "")
                                Return True
                            End If
                        ElseIf MyDataset.Tables(CurrTable).Columns(BindingField).DataType Is System.Type.GetType("System.Int32") Then
                            Dim dummyInt32 As Int32
                            If Not Int32.TryParse(InControl.Text, dummyInt32) Then
                                SetFormError(InControl, "Value is not integer !")
                                Return False
                            Else
                                SetFormError(InControl, "")
                                Return True
                            End If
                        End If
                    End If
                End If
            End If
        End If
        Return True
    End Function

    Public Sub HandleGridError(ByRef sender As System.Object, ByRef e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
        If (TypeOf e.Exception Is System.FormatException) Then
            If (TypeOf e.Exception.InnerException Is System.FormatException) Then
                If CType(sender, DataGridView).Columns(e.ColumnIndex).ValueType Is System.Type.GetType("System.Int32") Then
                    MsgBox("Only integer value allowed !")
                ElseIf CType(sender, DataGridView).Columns(e.ColumnIndex).ValueType Is System.Type.GetType("System.Decimal") Then
                    MsgBox("Only decimal value allowed !")
                End If
            ElseIf (TypeOf e.Exception.InnerException Is System.OverflowException) Then
                MsgBox("Value exceed field limits !")
            ElseIf (e.Exception.InnerException Is Nothing) Then
                If CType(sender, DataGridView).Columns(e.ColumnIndex).ValueType Is System.Type.GetType("System.Boolean") Then
                    'Skip if boolean
                Else
                    MsgBox(e.Exception.Message)
                End If
            Else
                MsgBox(e.Exception.Message)
            End If
        ElseIf (TypeOf e.Exception Is System.NullReferenceException) Then
            MsgBox(e.Exception.Message)
        ElseIf (TypeOf e.Exception Is System.ArgumentException) Then
            MsgBox(e.Exception.Message)
        ElseIf (TypeOf e.Exception Is System.ArgumentNullException) Then
            MsgBox(e.Exception.Message)
        ElseIf (TypeOf e.Exception Is System.ArgumentOutOfRangeException) Then
            MsgBox(e.Exception.Message)
        Else
            MsgBox(e.Exception.Message)
        End If
    End Sub

    Private EnteredRefresh As Boolean = False
    Public Sub RefreshGridCells(ByVal InGrid As DataGridView)
        If EnteredRefresh Then
            Exit Sub
        End If
		Try
			Try
				EnteredRefresh = True
				Dim CurrRow As DataRowView = CType(CType(InGrid.DataSource, BindingSource).Current, DataRowView)

				Dim OrgReadOnlyValue As Boolean
				For Each ColumnCell As DataGridViewCell In InGrid.CurrentRow.Cells
					If ColumnCell.OwningColumn.DataPropertyName <> "" Then
						If CurrRow.DataView.Table.Columns(ColumnCell.OwningColumn.DataPropertyName).ReadOnly = False Then
							OrgReadOnlyValue = ColumnCell.OwningColumn.ReadOnly
							ColumnCell.OwningColumn.ReadOnly = False
							ColumnCell.Value = CurrRow(ColumnCell.OwningColumn.DataPropertyName)
							ColumnCell.OwningColumn.ReadOnly = OrgReadOnlyValue
						End If
					End If
				Next
			Finally
				EnteredRefresh = False
			End Try
		Catch Ex As Exception
			MsgBox(Ex.Message)
		End Try

	End Sub

    Public Sub SetNavigatorVisible(ByVal InValue As Boolean)
        BindingNavigator1.MoveFirstItem.Visible = InValue
        BindingNavigator1.MovePreviousItem.Visible = InValue
        BindingNavigator1.MoveNextItem.Visible = InValue
        BindingNavigator1.MoveLastItem.Visible = InValue
        BindingNavigatorSeparator.Visible = InValue
        BindingNavigatorSeparator1.Visible = InValue
        BindingNavigatorSeparator2.Visible = InValue
        BindingNavigatorCountItem.Visible = InValue
        BindingNavigatorPositionItem.Visible = InValue

        FirstToolStripMenuItem.Visible = InValue
        NextToolStripMenuItem.Visible = InValue
        PreviousToolStripMenuItem.Visible = InValue
        LastToolStripMenuItem.Visible = InValue
        ToolStripMenuItem1.Visible = InValue
    End Sub
End Class


Public Delegate Sub BeforeAfterNewAndEditEvent(ByVal Sender As Object, ByVal e As BeforeAfterEditNewEventAgrs)
Public Delegate Sub BeforeAfterCallForm(ByVal CurrentForm As StdDBForm, ByRef InFormKeyInfo As FormKeyInfo, ByRef InDataset As Dataset)

Public Class BeforeAfterEditNewEventAgrs
    Inherits EventArgs
    Public IsNew As Boolean
    Public Cancel As Boolean
End Class

Public Structure FormKeyInfo
    Public KeyNo As Integer
    Public KeyCode As String
End Structure

Public Enum FormDBStatus
    FormAdd
    FormEdit
    FormDel
    FormBrowse
End Enum

