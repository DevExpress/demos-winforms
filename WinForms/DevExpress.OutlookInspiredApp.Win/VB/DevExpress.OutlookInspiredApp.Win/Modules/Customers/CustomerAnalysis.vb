Imports System.Linq
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.Spreadsheet

Namespace DevExpress.DevAV.Modules

    Public Partial Class CustomerAnalysis
        Inherits BaseModuleControl
        Implements IRibbonModule

        Private dataPeriod As DatePeriod

        Private reportPeriod As DatePeriod

        Public Sub New()
            MyBase.New(GetType(CustomerAnalysisViewModel))
            InitializeComponent()
            BindCommands()
            LoadTemplate()
            InitializeCurrentDateTimePeriod()
        End Sub

        Public ReadOnly Property ViewModel As CustomerAnalysisViewModel
            Get
                Return GetViewModel(Of CustomerAnalysisViewModel)()
            End Get
        End Property

        Public ReadOnly Property CollectionViewModel As CustomerCollectionViewModel
            Get
                Return GetParentViewModel(Of CustomerCollectionViewModel)()
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
            Using stream = GetAnalysisTemplate(AnalysisTemplate.CustomerSales)
                spreadsheetControl.LoadDocument(stream, DocumentFormat.Xlsm)
            End Using
        End Sub

        Private Sub InitializeCurrentDateTimePeriod()
            Dim maxDate = ViewModel.GetMaxOrdersDate()
            dataPeriod = CalculateAnalysisPeriod(maxDate)
            reportPeriod = CalculateReportPeriod(maxDate)
        End Sub

        Private Sub LoadAnalysisData()
            spreadsheetControl.Document.BeginUpdate()
            Dim defName = spreadsheetControl.Document.DefinedNames.GetDefinedName("ReportYear")
            If defName IsNot Nothing Then defName.RefersTo = "=" & reportPeriod.End.Year.ToString(System.Globalization.CultureInfo.InvariantCulture)
            Dim salesReportWorksheet = spreadsheetControl.Document.Worksheets("Sales Report")
            Dim salesReportItems = ViewModel.GetSalesReport(dataPeriod.Start, dataPeriod.End).ToList()
            Dim frCustomers = salesReportItems.[Select](Function(i) i.CustomerName).Distinct().OrderBy(Function(i) i).ToList()
            salesReportWorksheet.Import(frCustomers, 14, 1, True)
            For Each reportItem In salesReportItems
                Dim rowOffset As Integer = frCustomers.IndexOf(reportItem.CustomerName)
                Dim columnOffset As Integer = MonthOffset(dataPeriod.Start, reportItem.Date) \ 12
                If rowOffset < 0 OrElse columnOffset < 0 Then Continue For
                salesReportWorksheet.Cells(14 + rowOffset, 3 + columnOffset * 2).SetValue(reportItem.Total)
            Next

            Dim salesDataWorksheet = spreadsheetControl.Document.Worksheets("Sales Data")
            Dim salesDataItems = ViewModel.GetSalesData(dataPeriod.Start, dataPeriod.End).ToList()
            Dim states = salesDataItems.[Select](Function(i) i.State).Distinct().OrderBy(Function(i) i).ToList()
            salesDataWorksheet.Import(ViewModel.GetStates(states), 5, 3, False)
            For Each dataItem In salesDataItems
                Dim rowOffset As Integer = MonthOffset(dataPeriod.Start, dataItem.Date)
                Dim columnOffset As Integer = states.IndexOf(dataItem.State)
                If rowOffset < 0 OrElse columnOffset < 0 Then Continue For
                salesDataWorksheet.Cells(6 + rowOffset, 3 + columnOffset).SetValue(dataItem.Total)
            Next

            spreadsheetControl.Document.Worksheets.ActiveWorksheet = salesReportWorksheet
            spreadsheetControl.Document.EndUpdate()
        End Sub

#Region ""
        Private ReadOnly Property Ribbon As XtraBars.Ribbon.RibbonControl Implements IRibbonModule.Ribbon
            Get
                Return ribbonControl
            End Get
        End Property
#End Region
    End Class
End Namespace
