Imports DevExpress.DXperience.Demos
Imports DevExpress.LookAndFeel
Imports DevExpress.Tutorials
Imports DevExpress.Utils
Imports DevExpress.Utils.Frames
Imports DevExpress.XtraGauges.Win

Namespace DevExpress.XtraGauges.Demos

    Public Class frmMain
        Inherits DXperience.Demos.RibbonMainForm

        Private showOutdated As Boolean = True

        Public Sub New(ByVal arguments As String())
            MyBase.New(arguments)
            ToolTipController.DefaultController.ToolTipType = ToolTipType.SuperTip
            For Each _name As String In arguments
                If Equals(_name, "-demo") Then showOutdated = False
            Next
        End Sub

        Protected Overrides ReadOnly Property DemoName As String
            Get
                Return "WinForms Gauge and Indicators"
            End Get
        End Property

        Protected Overrides ReadOnly Property ProductName As String
            Get
                Return "XtraGauges"
            End Get
        End Property

        Protected Overrides ReadOnly Property FileType As SourceFileType
            Get
                Return DemoHelper.GetSourceFileType()
            End Get
        End Property

        Protected Overrides Sub ShowAbout()
            Call GaugeControl.About()
        End Sub

        Protected Overrides Sub SetFormParam()
            MinimumSize = New System.Drawing.Size(800, 600)
            Icon = ResourceImageHelperCore.CreateIconFromResourcesEx("DevExpress.XtraGauges.Demos.AppIcon.ico", GetType(frmMain).Assembly)
        End Sub

        Protected Overrides Function CreateRibbonMenuManager() As RibbonMenuManager
            Return New GaugesRibbonMenuManager(Me)
        End Function

        Protected Overrides Sub ShowModule(ByVal name As String, ByVal group As XtraEditors.GroupControl, ByVal lookAndFeel As DefaultLookAndFeel)
            DemosInfo.ShowModule(name, group, RibbonMenuManager)
        End Sub

        Protected Overrides Sub FillNavBar()
            ModulesInfo.FillAccordionControl(accordionControl1, XtraNavBar.NavBarGroupStyle.SmallIconsText, showOutdated)
        End Sub

        Protected Overrides ReadOnly Property SupportAdvancedTitlePainting As Boolean
            Get
                Return False
            End Get
        End Property
    End Class
End Namespace
