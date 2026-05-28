Imports DevExpress.XtraEditors

Namespace DevExpress.XtraDialogs.Demos

    Public Partial Class frmMain
        Inherits DXperience.Demos.RibbonMainForm

        Protected Overrides Sub SetFormParam()
            Icon = Utils.ResourceImageHelperCore.CreateIconFromResourcesEx("DevExpress.XtraDialogs.Demos.AppIcon.ico", GetType(frmMain).Assembly)
        End Sub

        Protected Overrides ReadOnly Property ProductName As String
            Get
                Return "Xtra Dialogs"
            End Get
        End Property

        Protected Overrides ReadOnly Property DemoName As String
            Get
                Return "Dialogs Demo (C# code)"
            End Get
        End Property

        Protected Overrides ReadOnly Property SupportAdvancedTitlePainting As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overrides Sub ShowModule(ByVal name As String, ByVal group As GroupControl, ByVal lookAndFeel As LookAndFeel.DefaultLookAndFeel)
            DemosInfo.ShowModule(name, group, RibbonMenuManager)
        End Sub

        Protected Overrides Sub FillNavBar()
            DXperience.Demos.ModulesInfo.FillAccordionControl(accordionControl1, XtraNavBar.NavBarGroupStyle.SmallIconsList, True, XtraNavBar.NavBarImage.Large)
        End Sub

        Protected Overrides Function CanUseEmptyRootPadding(ByVal name As String) As Boolean
            Return True
        End Function

        Protected Overrides Sub ShowAbout()
            Call BaseEdit.About()
        End Sub
    End Class
End Namespace
