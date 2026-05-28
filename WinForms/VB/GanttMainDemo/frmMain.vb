Imports DevExpress.DXperience.Demos
Imports DevExpress.LookAndFeel
Imports DevExpress.Tutorials
Imports DevExpress.Utils
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGantt.Demos

    Public Class frmMain
        Inherits RibbonMainForm

        Public Sub New(ByVal arguments As String())
            MyBase.New(arguments)
            GetStartedLink = AssemblyInfo.DXLinkGetStarted
            ToolTipController.DefaultController.ToolTipType = ToolTipType.SuperTip
        End Sub

        Public Overrides ReadOnly Property UseEmptyRootPadding As Boolean
            Get
                Return True
            End Get
        End Property

        Protected Overrides ReadOnly Property SupportAdvancedTitlePainting As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overrides ReadOnly Property ProductName As String
            Get
                Return "XtraGantt"
            End Get
        End Property

        Protected Overrides ReadOnly Property DemoName As String
            Get
                Return Properties.Resources.DemoName
            End Get
        End Property

        Protected Overrides ReadOnly Property FileType As SourceFileType
            Get
                Return DemoHelper.GetSourceFileType()
            End Get
        End Property

        Protected Overrides Sub ShowAbout()
            Call XtraTreeList.TreeList.About()
        End Sub

        Protected Overrides Sub SetFormParam()
            Icon = ResourceImageHelperCore.CreateIconFromResourcesEx("DevExpress.XtraGantt.Demos.AppIcon.ico", GetType(frmMain).Assembly)
        End Sub

        Protected Overrides Function CreateRibbonMenuManager() As RibbonMenuManager
            Return New GanttRibbonMenuManager(Me)
        End Function

        Protected Overrides Sub ShowModule(ByVal name As String, ByVal group As GroupControl, ByVal lookAndFeel As DefaultLookAndFeel)
            Call DemosInfo.ShowModule(name, group, TryCast(RibbonMenuManager, GanttRibbonMenuManager))
        End Sub
    End Class
End Namespace
