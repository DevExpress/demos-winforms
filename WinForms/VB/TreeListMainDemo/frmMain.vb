Imports DevExpress.DXperience.Demos
Imports DevExpress.LookAndFeel
Imports DevExpress.Tutorials
Imports DevExpress.XtraEditors
Imports DevExpress.XtraNavBar

Namespace DevExpress.XtraTreeList.Demos

    Public Class frmMain
        Inherits DXperience.Demos.RibbonMainForm

        Protected Overrides Sub SetFormParam()
            Icon = Utils.ResourceImageHelperCore.CreateIconFromResourcesEx("DevExpress.XtraTreeList.Demos.AppIcon.ico", GetType(frmMain).Assembly)
        End Sub

        Protected Overrides ReadOnly Property DemoName As String
            Get
                Return "WinForms TreeList"
            End Get
        End Property

        Protected Overrides ReadOnly Property FileType As SourceFileType
            Get
                Return DemoHelper.GetSourceFileType()
            End Get
        End Property

        Protected Overrides ReadOnly Property ProductName As String
            Get
                Return "XtraTreeList"
            End Get
        End Property

        Protected Overrides Sub ShowAbout()
            Call TreeList.About()
        End Sub

        Protected Overrides ReadOnly Property SupportAdvancedTitlePainting As Boolean
            Get
                Return False
            End Get
        End Property

        Public Overrides ReadOnly Property UseEmptyRootPadding As Boolean
            Get
                Return True
            End Get
        End Property

        Protected Overrides Function CreateRibbonMenuManager() As RibbonMenuManager
            Return New TreeListRibbonMenuManager(Me)
        End Function

        Protected Overrides Sub ShowModule(ByVal name As String, ByVal group As GroupControl, ByVal lookAndFeel As DefaultLookAndFeel)
            Call DemosInfo.ShowModule(name, group, TryCast(RibbonMenuManager, TreeListRibbonMenuManager))
        End Sub

        Protected Overrides Sub FillNavBar()
            ModulesInfo.FillAccordionControl(accordionControl1, NavBarGroupStyle.SmallIconsText, True, NavBarImage.Large)
        End Sub
    End Class
End Namespace
