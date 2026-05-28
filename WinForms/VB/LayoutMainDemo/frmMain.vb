Imports DevExpress.DXperience.Demos
Imports DevExpress.Tutorials
Imports DevExpress.XtraNavBar

Namespace DevExpress.XtraLayout.Demos

    Public Class frmMain
        Inherits DXperience.Demos.RibbonMainForm

        Protected Overrides Sub SetFormParam()
            Icon = DevExpress.Utils.ResourceImageHelperCore.CreateIconFromResourcesEx("DevExpress.XtraLayout.Demos.AppIcon.ico", GetType(frmMain).Assembly)
        End Sub

        Protected Overrides ReadOnly Property FileType As SourceFileType
            Get
                Return DemoHelper.GetSourceFileType()
            End Get
        End Property

        Protected Overrides ReadOnly Property DemoName As String
            Get
                Return "WinForms Automatic Form Layout Control"
            End Get
        End Property

        Protected Overrides ReadOnly Property ProductName As String
            Get
                Return "XtraLayoutControl"
            End Get
        End Property

        Protected Overrides Sub ShowAbout()
            Call LayoutControl.About()
        End Sub

        Public Overrides ReadOnly Property UseEmptyRootPadding As Boolean
            Get
                Return True
            End Get
        End Property

        Protected Overrides Sub ShowModule(ByVal name As String, ByVal group As XtraEditors.GroupControl, ByVal lookAndFeel As LookAndFeel.DefaultLookAndFeel)
            Call DemosInfo.ShowModule(name, group, RibbonMenuManager)
        End Sub

        Protected Overrides Sub FillNavBar()
            Call DemosInfo.FillAccordionControl(accordionControl1, NavBarGroupStyle.SmallIconsList, True, NavBarImage.Large)
        End Sub

        Protected Overrides ReadOnly Property SupportAdvancedTitlePainting As Boolean
            Get
                Return False
            End Get
        End Property
    End Class
End Namespace
