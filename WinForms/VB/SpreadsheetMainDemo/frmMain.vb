Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils

Namespace DevExpress.XtraSpreadsheet.Demos

    Public Partial Class frmMain
        Inherits DXperience.Demos.RibbonMainForm

        Public Sub New()
            XtraEditors.WindowsFormsSettings.UseDXDialogs = DefaultBoolean.True
        End Sub

        Protected Overrides ReadOnly Property DemoName As String
            Get
                Return "WinForms Spreadsheet"
            End Get
        End Property

        Protected Overrides ReadOnly Property SupportAdvancedTitlePainting As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overrides Sub ShowAbout()
            Call SpreadsheetControl.About()
        End Sub

        Protected Overrides ReadOnly Property ProductName As String
            Get
                Return "XtraSpreadsheet"
            End Get
        End Property

        Protected Overrides Sub SetFormParam()
            Icon = ResourceImageHelperCore.CreateIconFromResources("DevExpress.XtraSpreadsheet.Demos.AppIcon.ico", GetType(frmMain).Assembly)
        End Sub

        Protected Overrides Function CreateRibbonMenuManager() As RibbonMenuManager
            Return New SpreadsheetRibbonMenuManager(Me)
        End Function

        Protected Overrides Sub ShowModule(ByVal name As String, ByVal groupControl As XtraEditors.GroupControl, ByVal lookAndFeel As LookAndFeel.DefaultLookAndFeel)
            Call DemosInfo.DoShowModule(name, groupControl, TryCast(RibbonMenuManager, SpreadsheetRibbonMenuManager))
        End Sub

        Protected Overrides Sub InitCurrentRibbon()
            MyBase.InitCurrentRibbon()
            If RibbonControl IsNot Nothing Then RibbonControl.AutoHideEmptyItems = True
        End Sub
    End Class

    Public Class SpreadsheetRibbonMenuManager
        Inherits RibbonMenuManager

        Public Sub New(ByVal form As RibbonMainForm)
            MyBase.New(form)
        End Sub
    End Class
End Namespace
