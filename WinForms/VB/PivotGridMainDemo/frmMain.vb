Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.Data.Utils
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraPivotGrid.Demos

    Public Class frmMain
        Inherits RibbonMainForm

        Public Sub New()
            AddHandler gcDescription.HyperlinkClick, AddressOf GcDescription_HyperlinkClick
        End Sub

        Private Sub GcDescription_HyperlinkClick(ByVal sender As Object, ByVal e As HyperlinkClickEventArgs)
            SafeProcess.Start(e.Link)
        End Sub

        Protected Overrides Sub SetFormParam()
            Icon = ResourceImageHelperCore.CreateIconFromResourcesEx("DevExpress.XtraPivotGrid.Demos.AppIcon.ico", GetType(frmMain).Assembly)
        End Sub

        Protected Overrides ReadOnly Property ProductName As String
            Get
                Return "XtraPivotGrid"
            End Get
        End Property

        Protected Overrides Sub ShowModule(ByVal name As String, ByVal group As XtraEditors.GroupControl, ByVal lookAndFeel As LookAndFeel.DefaultLookAndFeel, ByVal notePanel As Control)
            Call DemosInfo.Show(name, group, notePanel, TryCast(RibbonMenuManager, PivotGridRibbonMenuManager))
        End Sub

        Protected Overrides ReadOnly Property DemoName As String
            Get
                Return "WinForms Pivot Grid"
            End Get
        End Property

        Protected Overrides Sub FillNavBar()
            ModulesInfo.FillAccordionControl(accordionControl1, XtraNavBar.NavBarGroupStyle.SmallIconsText)
        End Sub

        Protected Overrides Function CreateRibbonMenuManager() As RibbonMenuManager
            Return New PivotGridRibbonMenuManager(Me)
        End Function

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

        Protected Overrides Sub ShowAbout()
            Call PivotGridControl.About()
        End Sub
    End Class
End Namespace
