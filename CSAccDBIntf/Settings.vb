
Namespace My
    
    'This class allows you to handle specific events on the settings class:
    ' The SettingChanging event is raised before a setting's value is changed.
    ' The PropertyChanged event is raised after a setting's value is changed.
    ' The SettingsLoaded event is raised after the setting values are loaded.
    ' The SettingsSaving event is raised before the setting values are saved.
    Partial Friend NotInheritable Class MySettings
        Default Public Overrides Property Item(ByVal propertyName As String) As Object
            Get
                If propertyName = "CSAccountDBConnectionString" Then
                    If ShareData.DataBaseName = "" Then
                        Return MyBase.Item(propertyName)
                    Else
                        Return ShareData.DataBaseName
                    End If
                End If
                Return MyBase.Item(propertyName)
            End Get
            Set(ByVal value As Object)
                MyBase.Item(propertyName) = value
            End Set
        End Property
    End Class
End Namespace
