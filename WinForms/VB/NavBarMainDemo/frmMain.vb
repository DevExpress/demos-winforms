Imports System.Drawing
Imports DevExpress.DXperience.Demos
Imports DevExpress.LookAndFeel
Imports DevExpress.Tutorials
Imports DevExpress.Utils
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraNavBar.Demos

    Public Partial Class frmMain
        Inherits DXperience.Demos.RibbonMainForm

        Private showOutdated As Boolean = False

        Public Sub New(ByVal arguments As String())
            MyBase.New(arguments)
            ToolTipController.DefaultController.ToolTipType = ToolTipType.SuperTip
            Call DataHelper.LoadMessagesAsync()
        End Sub

        Protected Overrides ReadOnly Property DemoName As String
            Get
                Return "WinForms Navigation Bar"
            End Get
        End Property

        Protected Overrides ReadOnly Property ProductName As String
            Get
                Return "Navigation Bar"
            End Get
        End Property

        Protected Overrides ReadOnly Property FileType As SourceFileType
            Get
                Return DemoHelper.GetSourceFileType()
            End Get
        End Property

        Protected Overrides Sub ShowAbout()
            XtraBars.BarManager.About()
        End Sub

        Protected Overrides Function CanUseEmptyRootPadding(ByVal name As String) As Boolean
            If name.Contains("Hamburger") Then Return True
            Return MyBase.CanUseEmptyRootPadding(name)
        End Function

        Protected Overrides Sub SetFormParam()
            MinimumSize = New Size(800, 600)
            Icon = ResourceImageHelperCore.CreateIconFromResourcesEx("NavBarMainDemo.AppIcon.ico", GetType(frmMain).Assembly)
        End Sub

        Protected Overrides Sub ShowModule(ByVal name As String, ByVal group As GroupControl, ByVal lookAndFeel As DefaultLookAndFeel)
            DemosInfo.ShowModule(name, group, RibbonMenuManager)
        End Sub

        Protected Overrides Sub FillNavBar()
            ModulesInfo.FillAccordionControl(accordionControl1, NavBarGroupStyle.SmallIconsText, showOutdated)
        End Sub

        Protected Overrides ReadOnly Property SupportAdvancedTitlePainting As Boolean
            Get
                Return False
            End Get
        End Property
    End Class
End Namespace
