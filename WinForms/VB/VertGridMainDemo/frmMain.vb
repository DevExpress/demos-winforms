Imports DevExpress.DXperience.Demos
Imports DevExpress.Tutorials
Imports DevExpress.Utils

Namespace DevExpress.XtraVerticalGrid.Demos

    Public Class frmMain
        Inherits RibbonMainForm

        Protected Overrides Sub SetFormParam()
            Icon = ResourceImageHelperCore.CreateIconFromResourcesEx("DevExpress.XtraVerticalGrid.Demos.AppIcon.ico", GetType(frmMain).Assembly)
        End Sub

        Protected Overrides ReadOnly Property DemoName As String
            Get
                Return DemoHelper.GetFormText("The XtraVerticalGrid Suite by DevExpress")
            End Get
        End Property

        Protected Overrides ReadOnly Property FileType As SourceFileType
            Get
                Return DemoHelper.GetSourceFileType()
            End Get
        End Property

        Protected Overrides ReadOnly Property ProductName As String
            Get
                Return "XtraVerticalGrid"
            End Get
        End Property

        Protected Overrides Sub ShowAbout()
            Call VGridControlBase.About()
        End Sub

        Protected Overrides Function CreateRibbonMenuManager() As RibbonMenuManager
            Return New VGridRibbonMenuManager(Me)
        End Function

        Protected Overrides Sub ShowModule(ByVal name As String, ByVal group As XtraEditors.GroupControl, ByVal lookAndFeel As LookAndFeel.DefaultLookAndFeel)
            Call DemosInfo.ShowModule(name, group, TryCast(RibbonMenuManager, VGridRibbonMenuManager))
        End Sub

        Protected Overrides Sub FillNavBar()
            ModulesInfo.FillAccordionControl(accordionControl1, XtraNavBar.NavBarGroupStyle.SmallIconsText, True, XtraNavBar.NavBarImage.Large)
        End Sub

        Protected Overrides ReadOnly Property SupportAdvancedTitlePainting As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overrides Function CanUseEmptyRootPadding(ByVal name As String) As Boolean
            If Equals(name, "PC Market") OrElse Equals(name, "Vertical Grid") Then Return True
            Return MyBase.CanUseEmptyRootPadding(name)
        End Function
    End Class
End Namespace
