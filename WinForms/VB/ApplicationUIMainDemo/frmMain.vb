Imports DevExpress.DXperience.Demos
Imports DevExpress.Tutorials

Namespace DevExpress.ApplicationUI.Demos

    Public Partial Class frmMain
        Inherits DXperience.Demos.RibbonMainForm

        Protected Overrides Sub SetFormParam()
            Icon = Utils.ResourceImageHelperCore.CreateIconFromResourcesEx("DevExpress.ApplicationUI.Demos.AppIcon.ico", GetType(frmMain).Assembly)
        End Sub

        Protected Overrides ReadOnly Property FileType As SourceFileType
            Get
                Return DemoHelper.GetSourceFileType()
            End Get
        End Property

        Protected Overrides ReadOnly Property DemoName As String
            Get
                Return DemoHelper.GetFormText("Application UI Layout Controls Demo")
            End Get
        End Property

        Protected Overrides ReadOnly Property ProductName As String
            Get
                Return "ApplicationUI"
            End Get
        End Property

        Protected Overrides Function CanUseEmptyRootPadding(ByVal name As String) As Boolean
            If Equals(name, "Workspace Manager") OrElse Equals(name, "Badges") OrElse Equals(name, "Dock Panels") OrElse Equals(name, "Sales Performance Widget View") Then Return True
            Return MyBase.CanUseEmptyRootPadding(name)
        End Function

        Protected Overrides ReadOnly Property SupportAdvancedTitlePainting As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overrides Sub ShowAbout()
            XtraBars.Docking2010.DocumentManager.About()
        End Sub

        Protected Overrides Sub ShowModule(ByVal name As String, ByVal group As XtraEditors.GroupControl, ByVal lookAndFeel As LookAndFeel.DefaultLookAndFeel)
            DemosInfo.ShowModule(name, group, RibbonMenuManager)
        End Sub

        Protected Overrides Sub FillNavBar()
            ModulesInfo.FillAccordionControl(accordionControl1, XtraNavBar.NavBarGroupStyle.SmallIconsList, True, XtraNavBar.NavBarImage.Large)
        End Sub

        Protected Overrides ReadOnly Property AllowBorderRounding As Boolean
            Get
                Return False
            End Get
        End Property
    End Class
End Namespace
