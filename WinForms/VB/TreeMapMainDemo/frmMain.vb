Imports DevExpress.DXperience.Demos
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraTreeMap.Demos

    Public Class frmMain
        Inherits RibbonMainForm

        Protected Overrides ReadOnly Property DemoName As String
            Get
                Return "WinForms Heatmap, TreeMap & Sunburst"
            End Get
        End Property

        Protected Overrides ReadOnly Property ProductName As String
            Get
                Return "XtraTreeMap"
            End Get
        End Property

        Protected Overrides Sub ShowAbout()
            Call HierarchicalChartControlBase.About()
        End Sub

        Public Overrides ReadOnly Property UseEmptyRootPadding As Boolean
            Get
                Return True
            End Get
        End Property

        Protected Overrides Sub SetFormParam()
            Icon = ResourceImageHelperCore.CreateIconFromResourcesEx("DevExpress.XtraTreeMap.Demos.AppIcon.ico", GetType(frmMain).Assembly)
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
