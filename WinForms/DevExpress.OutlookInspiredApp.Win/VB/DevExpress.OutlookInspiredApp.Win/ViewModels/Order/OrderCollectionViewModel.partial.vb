Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Linq.Expressions
Imports DevExpress.DevAV
Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.DXperience.Demos
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports DevExpress.Mvvm.ViewModel

Namespace DevExpress.DevAV.ViewModels

    Partial Class OrderCollectionViewModel
        Implements ISupportMap, ISupportCustomFilters

        Public Overrides Sub Refresh()
            MyBase.Refresh()
            RaiseReload()
        End Sub

        Protected Overrides Sub OnSelectedEntityChanged()
            MyBase.OnSelectedEntityChanged()
            RaiseCanExecuteChanged(Sub(x) x.ShowMap())
            RaiseCanExecuteChanged(Sub(x) x.PrintInvoice())
            RaiseCanExecuteChanged(Sub(x) x.QuickReport(SalesReportType.Invoice))
            RaiseCanExecuteChanged(Sub(x) x.QuickReportFormat(ReportFormat.Doc))
            RaiseCanExecuteChanged(Sub(x) x.ShowRevenueAnalysisReport())
        End Sub

        Public Event Reload As EventHandler

        Public Event CustomFilter As EventHandler

        Public Event CustomFiltersReset As EventHandler Implements ISupportCustomFilters.CustomFiltersReset

        <Command>
        Public Sub ShowMap() Implements ISupportMap.ShowMap
            ShowMapCore(SelectedEntity)
        End Sub

        Public Function CanShowMap() As Boolean Implements ISupportMap.CanShowMap
            Return CanShowMapCore(SelectedEntity)
        End Function

        Protected Friend Sub ShowMapCore(ByVal order As Order)
            ShowDocument(Of OrderMapViewModel)("MapView", order.Id)
        End Sub

        Protected Friend Function CanShowMapCore(ByVal order As Order) As Boolean
            Return order IsNot Nothing
        End Function

        <Command>
        Public Sub ShowViewSettings()
            Dim dms = GetService(Of IDocumentManagerService)("View Settings")
            If dms IsNot Nothing Then
                Dim document = dms.Documents.FirstOrDefault(Function(d) TypeOf d.Content Is ViewSettingsViewModel)
                If document Is Nothing Then document = dms.CreateDocument("View Settings", Nothing, Nothing, Me)
                document.Show()
            End If
        End Sub

        <Command>
        Public Sub NewCustomFilter()
            RaiseCustomFilter()
        End Sub

        <Command>
        Public Sub PrintSalesReport()
            RaisePrint(SalesReportType.SalesReport)
        End Sub

        <Command>
        Public Sub PrintSalesByStore()
            RaisePrint(SalesReportType.SalesByStore)
        End Sub

        <Command(UseCommandManager:=False, CanExecuteMethodName:="CanPrint")>
        Public Sub PrintInvoice()
            RaisePrint(SalesReportType.Invoice)
        End Sub

        Public Function CanPrint() As Boolean
            Return SelectedEntity IsNot Nothing
        End Function

        <Command>
        Public Sub QuickReport(ByVal reportType As SalesReportType)
            QuickReportCore(SelectedEntity, reportType)
        End Sub

        Public Function CanQuickReport(ByVal reportType As SalesReportType) As Boolean
            Return CanQuickReportCore(SelectedEntity, reportType)
        End Function

        Protected Friend Sub QuickReportCore(ByVal order As Order, ByVal reportTemplate As SalesReportType)
            ShowDocument(Of OrderMailMergeViewModel)("MailMerge", reportTemplate)
        End Sub

        Protected Friend Function CanQuickReportCore(ByVal order As Order, ByVal reportTemplate As SalesReportType) As Boolean
            Return order IsNot Nothing
        End Function

        Public Overrides Sub [New]()
            DocumentManagerService.ShowNewEntityDocument(Of Order)(Me, Sub(newOrder) InitializeNewOrder(newOrder))
        End Sub

        Private Sub InitializeNewOrder(ByVal order As Order)
            Dim unitOfWork = CreateUnitOfWork()
            order.InvoiceNumber = GetNewInvoiceNumber(unitOfWork)
            order.OrderDate = TutorialConstants.Now
            Dim customer As Customer = unitOfWork.Customers.FirstOrDefault()
            If customer IsNot Nothing Then
                order.CustomerId = customer.Id
                Dim store = customer.CustomerStores.FirstOrDefault()
                If store IsNot Nothing Then order.StoreId = store.Id
                Dim employee = customer.Employees.FirstOrDefault()
                If employee IsNot Nothing Then order.EmployeeId = employee.Id
            End If
        End Sub

        Private Function GetNewInvoiceNumber(ByVal unitOfWork As IDevAVDbUnitOfWork) As String
            Dim numberStrings = unitOfWork.Orders.[Select](Function(x) x.InvoiceNumber).ToList()
            Dim invoiceNumbers = numberStrings.ConvertAll(Function(x)
                Dim number As Integer
                Return If(Integer.TryParse(x, number), number, 0)
            End Function)
            Return(invoiceNumbers.Max() + 1).ToString()
        End Function

        <Command>
        Public Sub QuickReportFormat(ByVal reportFormatType As ReportFormat)
            QuickReportFormatCore(reportFormatType)
        End Sub

        Public Function CanQuickReportFormat(ByVal reportFormatType As ReportFormat) As Boolean
            Return CanQuickReportFormatCore(SelectedEntity, reportFormatType)
        End Function

        Protected Friend Sub QuickReportFormatCore(ByVal reportFormatTemplate As ReportFormat)
            Select Case reportFormatTemplate
                Case ReportFormat.Pdf
                    ShowDocument(Of OrderQuickReportsViewModel)("OrderPdfQuickReportView", New Object() {reportFormatTemplate, SelectedEntity})
                Case ReportFormat.Xls
                    ShowDocument(Of OrderQuickReportsViewModel)("OrderXlsQuickReportView", New Object() {reportFormatTemplate, SelectedEntity})
                Case ReportFormat.Doc
                    ShowDocument(Of OrderQuickReportsViewModel)("OrderDocQuickReportView", New Object() {reportFormatTemplate, SelectedEntity})
            End Select
        End Sub

        Protected Friend Function CanQuickReportFormatCore(ByVal order As Order, ByVal reportFormatTemplate As ReportFormat) As Boolean
            Return order IsNot Nothing
        End Function

        <Command>
        Public Sub ShowRevenueReport()
            Dim data = QueriesHelper.GetRevenueReportItems(CreateUnitOfWork().OrderItems)
            ShowDocument(Of OrderRevenueViewModel)("OrderRevenueView", New Object() {data, RevenueReportFormat.Summary})
        End Sub

        Public Function CanShowRevenueAnalysisReport() As Boolean
            Return SelectedEntity IsNot Nothing
        End Function

        <Command>
        Public Sub ShowRevenueAnalysisReport()
            Dim data = QueriesHelper.GetRevenueAnalysisReportItems(CreateUnitOfWork().OrderItems, SelectedEntity.StoreId.Value)
            ShowDocument(Of OrderRevenueViewModel)("OrderRevenueView", New Object() {data, RevenueReportFormat.Analysis})
        End Sub

        Private orderItemsUnitOfWork As IDevAVDbUnitOfWork

        Protected Overrides Sub OnBeforeEntityDeleted(ByVal primaryKey As Long, ByVal entity As Order)
            MyBase.OnBeforeEntityDeleted(primaryKey, entity)
            If entity.OrderItems.Count = 0 Then Return
            Dim deletedItemKeys = entity.OrderItems.[Select](Function(x) x.Id).ToList()
            orderItemsUnitOfWork = CreateUnitOfWork()
            deletedItemKeys.ForEach(Sub(x)
                Dim item = orderItemsUnitOfWork.OrderItems.Find(x)
                If item IsNot Nothing Then orderItemsUnitOfWork.OrderItems.Remove(item)
            End Sub)
        End Sub

        Protected Overrides Sub OnEntityDeleted(ByVal primaryKey As Long, ByVal entity As Order)
            MyBase.OnEntityDeleted(primaryKey, entity)
            If orderItemsUnitOfWork IsNot Nothing Then orderItemsUnitOfWork.SaveChanges()
            orderItemsUnitOfWork = Nothing
        End Sub

        <Command>
        Public Sub ShowAllFolders()
            RaiseShowAllFolders()
        End Sub

        <Command>
        Public Sub ResetCustomFilters() Implements ISupportCustomFilters.ResetCustomFilters
            RaiseCustomFiltersReset()
        End Sub

        Private Sub RaisePrint(ByVal reportType As SalesReportType)
            Dim mainViewModel As MainViewModel = ViewModelHelper.GetParentViewModel(Of MainViewModel)(Me)
            If mainViewModel IsNot Nothing Then mainViewModel.RaisePrint(reportType)
        End Sub

        Private Sub RaiseShowAllFolders()
            Dim mainViewModel As MainViewModel = ViewModelHelper.GetParentViewModel(Of MainViewModel)(Me)
            If mainViewModel IsNot Nothing Then mainViewModel.RaiseShowAllFolders()
        End Sub

        Private Sub RaiseReload()
            Dim handler As EventHandler = ReloadEvent
            If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
        End Sub

        Private Sub RaiseCustomFilter()
            Dim handler As EventHandler = CustomFilterEvent
            If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
        End Sub

        Private Sub RaiseCustomFiltersReset()
            Dim handler As EventHandler = CustomFiltersResetEvent
            If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
        End Sub

        Private Sub ShowDocument(Of TViewModel)(ByVal documentType As String, ByVal parameter As Object)
            Dim document = FindDocument(Of TViewModel)()
            If TypeOf parameter Is Long Then document = FindDocument(Of TViewModel)(CLng(parameter))
            If document Is Nothing Then
                document = DocumentManagerService.CreateDocument(documentType, Nothing, parameter, Me)
            Else
                EnsureViewModel(document.Content, Me, parameter)
            End If

            document.Show()
        End Sub

        Public Overrides Function GetEntities(ByVal Optional filter As Expression(Of Func(Of Order, Boolean)) = Nothing) As IQueryable(Of Order)
            Return MyBase.GetEntities(filter).ActualOrders()
        End Function

        Friend Function GetSaleAnalysisInfos() As IEnumerable(Of SaleAnalysisInfo)
            Return QueriesHelper.GetSaleAnalysis(CreateUnitOfWork().OrderItems)
        End Function

        Friend Function GetSaleSummaryInfos() As IEnumerable(Of SaleSummaryInfo)
            Return QueriesHelper.GetSaleSummaries(CreateUnitOfWork().OrderItems)
        End Function

        Friend Function GetOrderItems() As IEnumerable(Of OrderItem)
            Return CreateUnitOfWork().OrderItems.Include(Function(x) x.Order).ToList()
        End Function

        Friend Function GetOrderItems(ByVal storeId As Long?) As IEnumerable(Of OrderItem)
            Return CreateUnitOfWork().OrderItems.Include(Function(x) x.Order).Where(Function(x) Nullable.Equals(x.Order.StoreId, storeId)).ToList()
        End Function
    End Class
End Namespace
