Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO

Namespace DevExpress.DevAV.ViewModels

    Partial Class ProductCollectionViewModel
        Implements ISupportMap, ISupportAnalysis, ISupportCustomFilters

        Public Overrides Sub Refresh()
            MyBase.Refresh()
            RaiseReload()
        End Sub

        Protected Overrides Sub OnSelectedEntityChanged()
            MyBase.OnSelectedEntityChanged()
            RaiseCanExecuteChanged(Sub(x) x.ShowMap())
            RaiseCanExecuteChanged(Sub(x) x.PrintOrderDetail())
            RaiseCanExecuteChanged(Sub(x) x.PrintSalesSummary())
            RaiseCanExecuteChanged(Sub(x) x.PrintSpecificationSummary())
            RaiseCanExecuteChanged(Sub(x) x.QuickReport(ProductReportType.OrderDetail))
        End Sub

        Public Overridable Property Selection As IEnumerable(Of Product)

        Protected Overridable Sub OnSelectionChanged()
            RaiseCanExecuteChanged(Sub(x) x.GroupSelection())
        End Sub

        Public Event Reload As EventHandler

        Public Event CustomFilter As EventHandler

        Public Event CustomFiltersReset As EventHandler Implements ISupportCustomFilters.CustomFiltersReset

        Public Event CustomGroup As EventHandler

        Public Event CustomGroupFromSelection As EventHandler(Of GroupEventArgs(Of Product))

        <Command>
        Public Sub ShowAnalysis() Implements ISupportAnalysis.ShowAnalysis
            ShowDocument(Of ProductAnalysisViewModel)("Analysis", Nothing)
        End Sub

        <Command>
        Public Sub ShowMap() Implements ISupportMap.ShowMap
            If SelectedEntity Is Nothing Then Return
            ShowDocument(Of ProductMapViewModel)("MapView", SelectedEntity.Id)
        End Sub

        Public Function CanShowMap() As Boolean Implements ISupportMap.CanShowMap
            Return SelectedEntity IsNot Nothing
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
        Public Sub NewGroup()
            RaiseCustomGroup()
        End Sub

        <Command>
        Public Sub GroupSelection()
            RaiseCustomGroupFromSelection()
        End Sub

        Public Function CanGroupSelection() As Boolean
            Return Selection IsNot Nothing AndAlso Selection.Any()
        End Function

        <Command>
        Public Sub NewCustomFilter()
            RaiseCustomFilter()
        End Sub

        <Command(UseCommandManager:=False, CanExecuteMethodName:="CanPrint")>
        Public Sub PrintOrderDetail()
            RaisePrint(ProductReportType.OrderDetail)
        End Sub

        <Command(UseCommandManager:=False, CanExecuteMethodName:="CanPrint")>
        Public Sub PrintSalesSummary()
            RaisePrint(ProductReportType.SalesSummary)
        End Sub

        <Command(UseCommandManager:=False, CanExecuteMethodName:="CanPrint")>
        Public Sub PrintSpecificationSummary()
            RaisePrint(ProductReportType.SpecificationSummary)
        End Sub

        <Command>
        Public Sub QuickReport(ByVal reportType As ProductReportType)
            RaisePrint(reportType)
        End Sub

        Public Function CanQuickReport(ByVal reportType As ProductReportType) As Boolean
            Return SelectedEntity IsNot Nothing
        End Function

        Public Function CanPrint() As Boolean
            Return SelectedEntity IsNot Nothing
        End Function

        <Command>
        Public Sub ShowAllFolders()
            RaiseShowAllFolders()
        End Sub

        <Command>
        Public Sub ResetCustomFilters() Implements ISupportCustomFilters.ResetCustomFilters
            RaiseCustomFiltersReset()
        End Sub

        Private Sub RaisePrint(ByVal reportType As ProductReportType)
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

        Private Sub RaiseCustomGroup()
            Dim handler As EventHandler = CustomGroupEvent
            If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
        End Sub

        Private Sub RaiseCustomGroupFromSelection()
            Dim handler As EventHandler(Of GroupEventArgs(Of Product)) = CustomGroupFromSelectionEvent
            If handler IsNot Nothing Then handler(Me, New GroupEventArgs(Of Product)(Selection))
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

        Public Overrides Sub Delete(ByVal entity As Product)
            MessageBoxService.ShowMessage("To ensure data integrity, the Products module doesn't allow records to be deleted. Record deletion is supported by the Employees module.", "Delete Product", MessageButton.OK)
        End Sub
    End Class
End Namespace
