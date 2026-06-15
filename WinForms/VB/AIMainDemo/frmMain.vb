Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraTreeList
Imports System
Imports System.Drawing

Namespace DevExpress.AI.Demos

    Public Partial Class frmMain
        Inherits DXperience.Demos.RibbonMainForm

        Public Sub New()
            MyBase.New()
            Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(GetType(GridControl).TypeHandle)
            Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(GetType(TreeList).TypeHandle)
        End Sub

        Protected Overrides Sub SetFormParam()
            Icon = Utils.ResourceImageHelperCore.CreateIconFromResourcesEx("DevExpress.AI.Demos.AppIcon.ico", GetType(frmMain).Assembly)
        End Sub

        Protected Overrides ReadOnly Property ProductName As String
            Get
                Return "AI"
            End Get
        End Property

        Protected Overrides ReadOnly Property DemoName As String
            Get
                Return "WinForms AI-powered Extensions"
            End Get
        End Property

        Protected Overrides ReadOnly Property SupportAdvancedTitlePainting As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overrides Sub ShowModule(ByVal name As String, ByVal group As GroupControl, ByVal lookAndFeel As DefaultLookAndFeel)
            DemosInfo.ShowModule(name, group, RibbonMenuManager)
        End Sub

        Protected Overrides Sub FillNavBar()
            DXperience.Demos.ModulesInfo.FillAccordionControl(accordionControl1, XtraNavBar.NavBarGroupStyle.SmallIconsList, True, XtraNavBar.NavBarImage.Large)
        End Sub

        Protected Overrides Function CanUseEmptyRootPadding(ByVal name As String) As Boolean
            Return True
        End Function

        Protected Overrides Sub ShowAbout()
            Call BaseEdit.About()
        End Sub

#If Not NET
        Protected Overrides Sub RegisterDemos()
            DXperience.Demos.MainFormRegisterDemoHelper.RegisterDemos(Function(x) Not Equals(x.Group, DemoData.Model.Repository.WinAIChatControlGroupName))
        End Sub
#End If
    End Class
End Namespace
