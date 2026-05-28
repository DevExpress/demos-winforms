Imports System.Windows.Forms
Imports DevExpress.Data.Utils
Imports DevExpress.DXperience.Demos
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraSplashScreen

Namespace DevExpress.XtraCharts.Demos

    Friend Partial Class frmMain
        Inherits RibbonMainForm

        Protected Overrides ReadOnly Property DemoName As String
            Get
                Return "WinForms Chart Control"
            End Get
        End Property

        Protected Overrides ReadOnly Property ProductName As String
            Get
                Return "XtraCharts"
            End Get
        End Property

        Protected Overrides ReadOnly Property SupportAdvancedTitlePainting As Boolean
            Get
                Return False
            End Get
        End Property

        Overloads Friend ReadOnly Property ExportToImageExButton As BarSubItem
            Get
                Return MyBase.ExportToImageExButton
            End Get
        End Property

        Public Overrides ReadOnly Property UseEmptyRootPadding As Boolean
            Get
                Return True
            End Get
        End Property

        Protected Overrides Function CreateRibbonMenuManager() As RibbonMenuManager
            Return New ChartRibbonMenuManager(Me)
        End Function

        Protected Overrides Sub SetFormParam()
            Icon = ResourceImageHelperCore.CreateIconFromResourcesEx("DevExpress.XtraCharts.Demos.AppIcon.ico", GetType(frmMain).Assembly)
        End Sub

        Protected Overrides Sub ShowModule(ByVal name As String, ByVal group As GroupControl, ByVal lookAndFeel As DefaultLookAndFeel)
            Dim currentModule As ChartDemoModule = DemosInfo.DoShowModule(name, group, TryCast(RibbonMenuManager, ChartRibbonMenuManager))
            If currentModule Is Nothing Then Return
            CType(RibbonMenuManager, ChartRibbonMenuManager).CurrentModule = currentModule
            CType(RibbonMenuManager, ChartRibbonMenuManager).UpdateMenu(currentModule.ChartDesignerEnabled, currentModule.PaletteButtonEnabled)
        End Sub

        Protected Overrides Function ShowProgressPanel(ByVal owner As Control, ByVal Optional windowOptions As OverlayWindowOptions = Nothing) As IOverlaySplashScreenHandle
            Return If(FrameworkVersions.IsFullFramework(), MyBase.ShowProgressPanel(owner, windowOptions), Nothing)
        End Function

        Protected Overrides Sub CloseProgressPanel(ByVal handle As IOverlaySplashScreenHandle)
            If FrameworkVersions.IsFullFramework() Then MyBase.CloseProgressPanel(handle)
        End Sub

        Protected Overrides Sub ShowAbout()
            Call ChartControl.About()
        End Sub

        Protected Overrides ReadOnly Property TestTimerInterval As Integer
            Get
                Return 4500
            End Get
        End Property

        Protected Overrides Function AllowApplicationDoEventsOnShowModuleOnTest(ByVal info As ModuleInfo) As Boolean
            Return False
        End Function
    End Class
End Namespace
