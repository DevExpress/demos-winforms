Namespace DevExpress.ChatClient.Properties

    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")>
    Friend NotInheritable Partial Class Settings
        Inherits Global.System.Configuration.ApplicationSettingsBase

        Private Shared defaultInstance As DevExpress.ChatClient.Properties.Settings = CType((Global.System.Configuration.ApplicationSettingsBase.Synchronized(New DevExpress.ChatClient.Properties.Settings())), DevExpress.ChatClient.Properties.Settings)

        Public Shared ReadOnly Property [Default] As Settings
            Get
                Return DevExpress.ChatClient.Properties.Settings.defaultInstance
            End Get
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute()>
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
        <Global.System.Configuration.DefaultSettingValueAttribute("John Heart")>
        Public Property CurrentUser As String
            Get
                Return(CStr((Me("CurrentUser"))))
            End Get

            Set(ByVal value As String)
                Me("CurrentUser") = value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute()>
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
        <Global.System.Configuration.DefaultSettingValueAttribute("Light")>
        Public Property Theme As String
            Get
                Return(CStr((Me("Theme"))))
            End Get

            Set(ByVal value As String)
                Me("Theme") = value
            End Set
        End Property
    End Class
End Namespace
