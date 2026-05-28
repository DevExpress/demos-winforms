Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Linq.Expressions
Imports DevExpress.DevAV
Imports DevExpress.Mvvm.DataModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO

Namespace DevExpress.DevAV.ViewModels

    Partial Class QuoteCollectionViewModel
        Implements ISupportMap, ISupportCustomFilters

        Public Overrides Sub Refresh()
            MyBase.Refresh()
            RaiseReload()
        End Sub

        Public Event Reload As EventHandler

        Public Event CustomFilter As EventHandler

        Public Event CustomFiltersReset As EventHandler Implements ISupportCustomFilters.CustomFiltersReset

        <Command>
        Public Sub ShowMap() Implements ISupportMap.ShowMap
            ShowDocument(Of QuoteMapViewModel)("MapView", Nothing)
        End Sub

        Public Function CanShowMap() As Boolean Implements ISupportMap.CanShowMap
            Return True
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
        Public Sub ShowAllFolders()
            RaiseShowAllFolders()
        End Sub

        <Command>
        Public Sub ResetCustomFilters() Implements ISupportCustomFilters.ResetCustomFilters
            RaiseCustomFiltersReset()
        End Sub

        Private Sub RaiseShowAllFolders()
            Dim mainViewModel As MainViewModel = ViewModelHelper.GetParentViewModel(Of MainViewModel)(Me)
            If mainViewModel IsNot Nothing Then mainViewModel.RaiseShowAllFolders()
        End Sub

        Private Sub RaisePrint(ByVal reportType As SalesReportType)
            Dim mainViewModel As MainViewModel = ViewModelHelper.GetParentViewModel(Of MainViewModel)(Me)
            If mainViewModel IsNot Nothing Then mainViewModel.RaisePrint(reportType)
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

        Protected Overridable Function GetQuotes() As IQueryable(Of Quote)
            Return CreateRepository().GetFilteredEntities(FilterExpression)
        End Function

        Public Function GetOpportunities() As IList(Of QuoteMapItem)
            Return QueriesHelper.GetOpportunities(GetQuotes()).ToList()
        End Function

        Public Function GetOpportunities(ByVal stage As Stage, ByVal Optional filterExpression As Expression(Of Func(Of Quote, Boolean)) = Nothing) As IList(Of QuoteMapItem)
            Dim unitOfWork = CreateUnitOfWork()
            Dim quotes = unitOfWork.Quotes.GetFilteredEntities(If(filterExpression, Me.FilterExpression))
            Dim customers = unitOfWork.Customers
            Return QueriesHelper.GetOpportunities(quotes, customers, stage).ToList()
        End Function

        Public Function GetAddresses(ByVal stage As Stage) As IEnumerable(Of Address)
            Dim unitOfWork = CreateUnitOfWork()
            Return QueriesHelper.GetCustomerStore(unitOfWork.CustomerStores, ReadOnlyRepositoryExtensions.GetFilteredEntities(unitOfWork.Quotes, FilterExpression).ActualQuotes(), stage).Distinct().[Select](Function(cs) cs.Address)
        End Function

        Public Function GetOpportunity(ByVal stage As Stage, ByVal city As String) As Decimal
            Return QueriesHelper.GetOpportunity(GetQuotes(), stage, city)
        End Function

        Public Overrides Sub Delete(ByVal entity As Quote)
            MessageBoxService.ShowMessage("To ensure data integrity, the Opportunities module doesn't allow records to be deleted. Record deletion is supported by the Employees module.", "Delete Opportunity", MessageButton.OK)
        End Sub

        Public Overrides Function GetEntities(ByVal Optional filter As Expression(Of Func(Of Quote, Boolean)) = Nothing) As IQueryable(Of Quote)
            Return MyBase.GetEntities(filter).ActualQuotes()
        End Function
    End Class
End Namespace
