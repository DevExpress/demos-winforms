Imports System.Collections.ObjectModel
Imports System.Linq
Imports DevExpress.Data.Helpers
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.Mvvm.DataModel
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraBars.Navigation

Namespace DevExpress.DevAV.Modules

    Friend Class FilterAccordionHelper(Of TEntity As Class, TID, TUnitOfWork As {Class, IUnitOfWork})

        Private accordion As AccordionControl

        Public Sub New(ByVal accordion As AccordionControl)
            Me.accordion = accordion
        End Sub

        Public Function PopulateMenu(ByVal element As AccordionControlElement, ByVal viewModel As FilterTreeViewModel(Of TEntity, TID, TUnitOfWork)) As DXPopupMenu
            Dim menu = New DXPopupMenu()
            If element.Style = ElementStyle.Group Then
                If Equals(element.Text, FilterTreeViewModel(Of TEntity, TID, TUnitOfWork).StaticFiltersName) Then Return Nothing
                If Equals(element.Text, FilterTreeViewModel(Of TEntity, TID, TUnitOfWork).GroupFiltersName) Then
                    Dim newItem = New DXMenuItem()
                    newItem.Caption = "New Group..."
                    newItem.BindCommand(Sub() viewModel.NewGroup(), viewModel)
                    menu.Items.Add(newItem)
                Else
                    Dim newItem = New DXMenuItem()
                    newItem.Caption = "New..."
                    newItem.BindCommand(Sub() viewModel.[New](), viewModel)
                    menu.Items.Add(newItem)
                End If
            End If

            If element.Style = ElementStyle.Item Then
                If Match(element, viewModel.Groups) Then
                    Dim filterItemBase = TryCast(element.Tag, FilterTreeViewModel(Of TEntity, TID, TUnitOfWork).FilterItem)
                    Dim editItem = New DXMenuItem()
                    editItem.Caption = "Modify Group..."
                    Dim filterItem = FilterTreeViewModel(Of TEntity, TID, TUnitOfWork).FilterItem.Create(filterItemBase.Name, filterItemBase.FilterCriteria)
                    editItem.BindCommand(Sub(f) viewModel.ModifyGroup(f), viewModel, Function() filterItemBase)
                    menu.Items.Add(editItem)
                    Dim deleteItem = New DXMenuItem()
                    deleteItem.Caption = "Delete Group"
                    deleteItem.BindCommand(Sub(f) viewModel.DeleteGroup(f), viewModel, Function() filterItemBase)
                    menu.Items.Add(deleteItem)
                Else
                    If Match(element, viewModel.StaticFilters) Then Return Nothing
                    Dim newItem = New DXMenuItem()
                    newItem.Caption = "New..."
                    newItem.BindCommand(Sub() viewModel.[New](), viewModel)
                    menu.Items.Add(newItem)
                    If element.Style = ElementStyle.Item Then
                        Dim filterItemBase = TryCast(element.Tag, FilterItemBase)
                        Dim editItem = New DXMenuItem()
                        editItem.Caption = "Modify..."
                        Dim filterItem = viewModel.CustomFilters.FirstOrDefault(Function(fi) fi.Name.Equals(filterItemBase.Name) AndAlso Equals(fi.FilterCriteria, filterItemBase.FilterCriteria))
                        editItem.BindCommand(Sub(f) viewModel.Modify(f), viewModel, Function() CType(filterItem, FilterTreeViewModel(Of TEntity, TID, TUnitOfWork).FilterItem))
                        menu.Items.Add(editItem)
                        Dim deleteItem = New DXMenuItem()
                        deleteItem.Caption = "Delete"
                        deleteItem.BindCommand(Sub(f) viewModel.Delete(f), viewModel, Function() CType(filterItem, FilterTreeViewModel(Of TEntity, TID, TUnitOfWork).FilterItem))
                        menu.Items.Add(deleteItem)
                    End If
                End If
            End If

            Return menu
        End Function

        Private Function Match(ByVal element As AccordionControlElement, ByVal dataItem As Object) As Boolean
            Return TryCast(dataItem, ObservableCollection(Of FilterItemBase)).Any(Function(fi) fi Is TryCast(element.Tag, FilterItemBase))
        End Function

        Public Function FindElementByTag(ByVal dataItem As Object) As AccordionControlElement
            If dataItem Is Nothing Then Return accordion.Elements(0).Elements(0)
            For Each element In accordion.Elements
                Dim found = FindElementByTagRecursive(element, dataItem)
                If found IsNot Nothing Then Return found
            Next

            Return accordion.Elements(0).Elements(0)
        End Function

        Private Function FindElementByTagRecursive(ByVal element As AccordionControlElement, ByVal dataItem As Object) As AccordionControlElement
            If Equals(element.Tag, dataItem) Then Return element
            For Each child In element.Elements
                Dim found = FindElementByTagRecursive(child, dataItem)
                If found IsNot Nothing Then Return found
            Next

            Return Nothing
        End Function
    End Class
End Namespace
