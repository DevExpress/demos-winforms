Imports System
Imports DevExpress.DXperience.Demos
Imports DevExpress.LookAndFeel
Imports DevExpress.Tutorials
Imports DevExpress.Utils

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class frmMain
        Inherits RibbonMainForm

        Protected Overrides ReadOnly Property DemoName As String
            Get
                Return "WinForms Data Editors and Controls"
            End Get
        End Property

        Protected Overrides ReadOnly Property ProductName As String
            Get
                Return "XtraEditors"
            End Get
        End Property

        Protected Overrides ReadOnly Property FileType As SourceFileType
            Get
                Return DemoHelper.GetSourceFileType()
            End Get
        End Property

        Protected Overrides Sub SetFormParam()
            Icon = ResourceImageHelperCore.CreateIconFromResourcesEx("DevExpress.XtraEditors.Demos.AppIcon.ico", GetType(frmMain).Assembly)
        End Sub

        Protected Overrides Function CanUseEmptyRootPadding(ByVal name As String) As Boolean
            If name.StartsWith("SvgImage Box") Then Return True
            If name.StartsWith("Memo Edit") Then Return True
            Return MyBase.CanUseEmptyRootPadding(name)
        End Function

        Protected Overrides ReadOnly Property SupportAdvancedTitlePainting As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overrides Sub ShowModule(ByVal name As String, ByVal group As GroupControl, ByVal lookAndFeel As DefaultLookAndFeel)
            DemosInfo.ShowModule(name, group, RibbonMenuManager)
        End Sub

        Protected Overrides Sub ShowAbout()
            Call BaseEdit.About()
        End Sub

        Protected Overrides Sub OnLoad(ByVal sender As Object, ByVal e As EventArgs)
            MyBase.OnLoad(sender, e)
            InitRibbonPageGroupsMergeOrder()
        End Sub

        Private Sub InitRibbonPageGroupsMergeOrder()
            If ribbonControl1 Is Nothing Then Return
            For Each page As XtraBars.Ribbon.RibbonPage In ribbonControl1.Pages
                For Each group As XtraBars.Ribbon.RibbonPageGroup In page.Groups
                    group.MergeOrder = page.Groups.IndexOf(group)
                Next
            Next
        End Sub
    End Class
End Namespace
