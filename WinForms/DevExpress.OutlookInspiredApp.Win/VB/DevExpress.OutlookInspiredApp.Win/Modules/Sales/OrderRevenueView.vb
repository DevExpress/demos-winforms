Imports System
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.XtraReports.UI
Imports DevExpress.Mvvm

Namespace DevExpress.DevAV.Modules

    Public Partial Class OrderRevenueView
        Inherits BaseModuleControl
        Implements IRibbonModule

        Public Sub New()
            MyBase.New(GetType(OrderRevenueViewModel))
            InitializeComponent()
        End Sub

        Public ReadOnly Property ViewModel As OrderRevenueViewModel
            Get
                Return GetViewModel(Of OrderRevenueViewModel)()
            End Get
        End Property

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            documentViewer1.DocumentSource = ViewModel.Report
        End Sub

#Region ""
        Private ReadOnly Property Ribbon As XtraBars.Ribbon.RibbonControl Implements IRibbonModule.Ribbon
            Get
                If String.IsNullOrEmpty(ribbonControl.ApplicationDocumentCaption) Then ribbonControl.ApplicationDocumentCaption = CStr(TryCast(ViewModel, IDocumentContent).Title)
                Return ribbonControl
            End Get
        End Property

#End Region
        Private Sub showDesignerBarItem_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            Using tool = New ReportDesignTool(ViewModel.Report)
                tool.ShowRibbonDesignerDialog()
            End Using
        End Sub
    End Class
End Namespace
