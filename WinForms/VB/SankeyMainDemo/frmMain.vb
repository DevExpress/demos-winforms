Imports DevExpress.DXperience.Demos
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.XtraCharts.Sankey
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraSankey.Demos

    Public Class frmMain
        Inherits RibbonMainForm

        Protected Overrides ReadOnly Property DemoName As String
            Get
                Return "WinForms Sankey Diagram"
            End Get
        End Property

        Protected Overrides ReadOnly Property ProductName As String
            Get
                Return "XtraSankey"
            End Get
        End Property

        Protected Overrides Sub ShowAbout()
            Call SankeyDiagramControl.About()
        End Sub

        Public Overrides ReadOnly Property UseEmptyRootPadding As Boolean
            Get
                Return True
            End Get
        End Property

        Protected Overrides Sub SetFormParam()
            Icon = ResourceImageHelperCore.CreateIconFromResourcesEx("DevExpress.XtraSankey.Demos.AppIcon.ico", GetType(frmMain).Assembly)
        End Sub

        Protected Overrides Sub ShowModule(ByVal name As String, ByVal group As GroupControl, ByVal lookAndFeel As DefaultLookAndFeel)
            DemosInfo.DoShowModule(name, group, RibbonMenuManager)
        End Sub

        Protected Overrides ReadOnly Property SupportAdvancedTitlePainting As Boolean
            Get
                Return False
            End Get
        End Property
    End Class
End Namespace
