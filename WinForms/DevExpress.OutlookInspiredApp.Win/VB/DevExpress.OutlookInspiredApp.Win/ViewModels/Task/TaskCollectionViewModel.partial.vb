Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace DevExpress.DevAV.ViewModels

    Partial Class TaskCollectionViewModel
        Implements ISupportCustomFilters, ISupportNewParent

        Public Overrides Sub Refresh()
            MyBase.Refresh()
            RaiseReload()
        End Sub

        Public Function CanNew() As Boolean
            Dim service As IDocumentManagerService = GetDocumentManagerService()
            If service Is Nothing Then Return False
            For Each doc In service.Documents
                Dim newTaskViewModel = TryCast(doc.Content, TaskViewModel)
                If newTaskViewModel IsNot Nothing AndAlso newTaskViewModel.IsNew() Then Return False
            Next

            Return True
        End Function

        Private Function GetDocumentManagerService() As IDocumentManagerService
            Dim service = If(UnitOfWorkPolicy = ViewModel.UnitOfWorkPolicy.Shared, WindowedDocumentManagerService, DocumentManagerService)
            Return If(service, DocumentManagerService)
        End Function

        Public Overridable Property Selection As IEnumerable(Of EmployeeTask)

        Protected Overridable Sub OnSelectionChanged()
            RaiseCanExecuteChanged(Sub(x) x.GroupSelection())
        End Sub

        Public Event Reload As EventHandler

        Public Event CustomFilter As EventHandler

        Public Event CustomFiltersReset As EventHandler Implements ISupportCustomFilters.CustomFiltersReset

        Public Event CustomGroup As EventHandler

        Public Event CustomGroupFromSelection As EventHandler(Of GroupEventArgs(Of EmployeeTask))

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

        <Command>
        Public Sub ResetCustomFilters() Implements ISupportCustomFilters.ResetCustomFilters
            RaiseCustomFiltersReset()
        End Sub

        <Command>
        Public Sub ShowAllFolders()
            RaiseShowAllFolders()
        End Sub

        Private Sub RaiseShowAllFolders()
            Dim mainViewModel As MainViewModel = ViewModelHelper.GetParentViewModel(Of MainViewModel)(Me)
            If mainViewModel IsNot Nothing Then mainViewModel.RaiseShowAllFolders()
        End Sub

        Private Sub RaiseCustomGroupFromSelection()
            Dim handler As EventHandler(Of GroupEventArgs(Of EmployeeTask)) = CustomGroupFromSelectionEvent
            If handler IsNot Nothing Then handler(Me, New GroupEventArgs(Of EmployeeTask)(Selection))
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
    End Class
End Namespace
