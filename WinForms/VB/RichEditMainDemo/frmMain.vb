Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils

Namespace DevExpress.XtraRichEdit.Demos

    Public Partial Class frmMain
        Inherits RibbonMainForm

        Protected Overrides ReadOnly Property DemoName As String
            Get
                Return "WinForms Word Processing (RTF)"
            End Get
        End Property

        Protected Overrides ReadOnly Property ProductName As String
            Get
                Return "XtraRichEdit"
            End Get
        End Property

        Protected Overrides Sub ShowAbout()
            Call RichEditControl.About()
        End Sub

        Protected Overrides ReadOnly Property SupportAdvancedTitlePainting As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overrides Sub SetFormParam()
            Icon = ResourceImageHelperCore.CreateIconFromResources("DevExpress.XtraRichEdit.Demos.AppIcon.ico", GetType(frmMain).Assembly)
        End Sub

        Protected Overrides Sub ShowModule(ByVal name As String, ByVal groupControl As XtraEditors.GroupControl, ByVal lookAndFeel As LookAndFeel.DefaultLookAndFeel)
            DemosInfo.DoShowModule(name, groupControl, RibbonMenuManager)
        End Sub
    End Class
End Namespace
