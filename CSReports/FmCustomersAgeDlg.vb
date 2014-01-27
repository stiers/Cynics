Public Class FmCustomersAgeDlg
    Public Overrides Property Dataset() As DataSet
        Get
            Return MyBase.Dataset
        End Get
        Set(ByVal value As DataSet)
            MyBase.Dataset = value
            CSAccReporting = CType(value, CSAccountDatabaseIntf.CSAccReporting)
            MST_CUSTOMERBindingSource.DataSource = Dataset
            MST_CUSTOMERBindingSource1.DataSource = Dataset
            InitControls()
        End Set
    End Property

    Public Overrides Sub InitControls()
        MyBase.InitControls()
        AsOfDate.Value = SystemInfo.BusinessDate
        If MST_CUSTOMERBindingSource.Count > 0 Then
            MST_CUSTOMERBindingSource.Position = 0
        End If
        MST_CUSTOMERBindingSource1.Position = MST_CUSTOMERBindingSource1.Count
    End Sub

End Class
