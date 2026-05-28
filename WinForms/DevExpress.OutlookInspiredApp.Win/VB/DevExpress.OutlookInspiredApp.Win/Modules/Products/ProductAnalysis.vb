Imports System.Linq
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.Spreadsheet

Namespace DevExpress.DevAV.Modules

    Public Partial Class ProductAnalysis
        Inherits BaseModuleControl
        Implements IRibbonModule

        Public Sub New()
            MyBase.New(GetType(ProductAnalysisViewModel))
            InitializeComponent()
            BindCommands()
            LoadTemplate()
        End Sub

        Public ReadOnly Property ViewModel As ProductAnalysisViewModel
            Get
                Return GetViewModel(Of ProductAnalysisViewModel)()
            End Get
        End Property

        Public ReadOnly Property CollectionViewModel As ProductCollectionViewModel
            Get
                Return GetParentViewModel(Of ProductCollectionViewModel)()
            End Get
        End Property

        Protected Overrides Sub OnParentViewModelAttached()
            MyBase.OnParentViewModelAttached()
            LoadAnalysisData()
        End Sub

        Private Sub BindCommands()
            biClose.BindCommand(Sub() ViewModel.Close(), ViewModel)
        End Sub

        Private Sub LoadTemplate()
            Using stream = GetAnalysisTemplate(AnalysisTemplate.ProductSales)
                spreadsheetControl.LoadDocument(stream, DocumentFormat.Xlsm)
            End Using
        End Sub

        Private Sub LoadAnalysisData()
            spreadsheetControl.Document.BeginUpdate()
            Dim financialReportWorksheet = spreadsheetControl.Document.Worksheets("Financial Report")
            Dim financialReportItems = ViewModel.GetFinancialReport().ToList()
            Dim frProducts = financialReportItems.[Select](Function(i) i.ProductName).Distinct().OrderBy(Function(i) i).ToList()
            financialReportWorksheet.Import(frProducts, 17, 1, True)
            For Each reportItem In financialReportItems
                Dim rowOffset As Integer = frProducts.IndexOf(reportItem.ProductName)
                Dim columnOffset As Integer = MonthOffsetFromStart(reportItem.Date) \ 12
                If rowOffset < 0 OrElse columnOffset < 0 Then Continue For
                financialReportWorksheet.Cells(17 + rowOffset, 3 + columnOffset * 2).SetValue(reportItem.Total)
            Next

            Dim financialDataWorksheet = spreadsheetControl.Document.Worksheets("Financial Data")
            Dim financialDataItems = ViewModel.GetFinancialData().ToList()
            For Each dataItem In financialDataItems
                Dim rowOffset As Integer = MonthOffsetFromStart(dataItem.Date)
                Dim columnOffset As Integer = GetColumnIndex(dataItem.ProductCategory)
                If rowOffset < 0 OrElse columnOffset < 0 Then Continue For
                financialDataWorksheet.Cells(6 + rowOffset, 3 + columnOffset).SetValue(dataItem.Total)
            Next

            spreadsheetControl.Document.Worksheets.ActiveWorksheet = financialReportWorksheet
            spreadsheetControl.Document.EndUpdate()
        End Sub

        Private Function GetColumnIndex(ByVal category As ProductCategory) As Integer
            Select Case category
                Case ProductCategory.Televisions
                    Return 0
                Case ProductCategory.Monitors
                    Return 1
                Case ProductCategory.VideoPlayers
                    Return 2
                Case ProductCategory.Automation
                    Return 3
                Case Else
                    Return -1
            End Select
        End Function

#Region ""
        Private ReadOnly Property Ribbon As XtraBars.Ribbon.RibbonControl Implements IRibbonModule.Ribbon
            Get
                Return ribbonControl
            End Get
        End Property
#End Region
    End Class
End Namespace
