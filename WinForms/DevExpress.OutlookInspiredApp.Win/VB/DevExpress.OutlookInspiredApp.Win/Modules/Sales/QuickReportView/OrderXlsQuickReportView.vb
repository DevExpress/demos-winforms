Imports System
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.Mvvm

Namespace DevExpress.DevAV.Modules

    Public Partial Class OrderXlsQuickReportView
        Inherits BaseModuleControl
        Implements IRibbonModule

        Public Sub New()
            MyBase.New(GetType(OrderQuickReportsViewModel))
            InitializeComponent()
        End Sub

        Public ReadOnly Property ViewModel As OrderQuickReportsViewModel
            Get
                Return GetViewModel(Of OrderQuickReportsViewModel)()
            End Get
        End Property

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            spreadsheetControl1.LoadDocument(ViewModel.DocumentStream)
        End Sub

#Region ""
        Private ReadOnly Property Ribbon As XtraBars.Ribbon.RibbonControl Implements IRibbonModule.Ribbon
            Get
                If String.IsNullOrEmpty(ribbonControl.ApplicationDocumentCaption) Then ribbonControl.ApplicationDocumentCaption = CStr(TryCast(ViewModel, IDocumentContent).Title)
                Return ribbonControl
            End Get
        End Property
#End Region
    End Class
End Namespace
