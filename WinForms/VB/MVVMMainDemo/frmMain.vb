Namespace DevExpress.MVVM.Demos
    Partial Public Class frmMain
        Inherits DXperience.Demos.RibbonMainForm
        Protected Overrides Sub SetFormParam()
            Icon = Utils.ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.MVVM.Demos.AppIcon.ico", GetType(frmMain).Assembly)
        End Sub
        Protected Overrides ReadOnly Property ProductName() As String
            Get
                Return "MVVM"
            End Get
        End Property
        Protected Overrides ReadOnly Property DemoName() As String
            Get
                Return "Application Infrastructural MVVM Pattern Demo (VB code)"
            End Get
        End Property
        Protected Overrides ReadOnly Property AllowShareDemos As Boolean
            Get
               Return False
            End Get
        End Property
        Protected Overrides Sub ShowAbout()
            Utils.MVVM.MVVMContext.About()
        End Sub
        Protected Overrides Sub ShowModule(ByVal name As String, ByVal group As XtraEditors.GroupControl, ByVal lookAndFeel As LookAndFeel.DefaultLookAndFeel)
            DemosInfo.ShowDemoModule(name, group, RibbonMenuManager)
        End Sub
        Protected Overrides Sub FillNavBar()
            DXperience.Demos.ModulesInfo.FillAccordionControl(accordionControl1, XtraNavBar.NavBarGroupStyle.SmallIconsList, True, XtraNavBar.NavBarImage.Large)
        End Sub
    End Class
End Namespace
