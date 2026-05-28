Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Data.Filtering
Imports DevExpress.Mvvm.DataModel
Imports DevExpress.DevAV.Common.ViewModel
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.WinExplorer

Namespace DevExpress.DevAV.Presenters

    Public MustInherit Class GroupFilterPresenter(Of TEntity As Class, TID, TUnitOfWork As {Class, IUnitOfWork})
        Inherits BasePresenter(Of GroupFilterViewModel)

        Private itemsView As WinExplorerView

        Public Sub New(ByVal itemsView As WinExplorerView, ByVal viewModel As GroupFilterViewModel)
            MyBase.New(viewModel)
            Me.itemsView = itemsView
            If itemsView IsNot Nothing Then
                AddHandler itemsView.ItemClick, AddressOf winExplorerView_ItemClick
                AddHandler itemsView.CustomUnboundColumnData, AddressOf winExplorerView_CustomUnboundColumnData
                AddHandler itemsView.GridControl.Load, Sub(s, e) SetFindControlImages(itemsView.GridControl)
            End If

            AddHandler Me.ViewModel.QueryFilterCriteria, AddressOf ViewModel_QueryFilterCriteria
        End Sub

        Protected Overrides Sub OnDisposing()
            RemoveHandler ViewModel.QueryFilterCriteria, AddressOf ViewModel_QueryFilterCriteria
            If itemsView IsNot Nothing Then
                RemoveHandler itemsView.ItemClick, AddressOf winExplorerView_ItemClick
                RemoveHandler itemsView.CustomUnboundColumnData, AddressOf winExplorerView_CustomUnboundColumnData
                itemsView = Nothing
            End If

            MyBase.OnDisposing()
        End Sub

        Public Sub Load()
            Dim expression = FilterTreeViewModel(Of TEntity, TID, TUnitOfWork).GetFilterExpression(ViewModel.FilterCriteria)
            Dim parentCollectionViewModel = GetParentViewModel(Of CollectionViewModel(Of TEntity, TID, TUnitOfWork))()
            If expression IsNot Nothing Then
                For Each entity As TEntity In parentCollectionViewModel.GetEntities(expression)
                    selection.Add(GetEntityKey(entity))
                Next
            End If

            itemsView.GridControl.DataSource = parentCollectionViewModel.GetEntities().ToList()
        End Sub

        Private selection As HashSet(Of TID) = New HashSet(Of TID)()

        Protected MustOverride Function GetEntityKey(ByVal entity As TEntity) As TID

        Private Function GetIsSelected(ByVal entity As TEntity) As Boolean
            Return selection.Contains(GetEntityKey(entity))
        End Function

        Private Sub ViewModel_QueryFilterCriteria(ByVal sender As Object, ByVal e As QueryFilterCriteriaEventArgs)
            e.FilterCriteria = New InOperator("Id", selection)
        End Sub

        Private Sub SetIsSelected(ByVal entity As TEntity, ByVal selected As Boolean)
            If selected Then
                selection.Add(GetEntityKey(entity))
            Else
                selection.Remove(GetEntityKey(entity))
            End If
        End Sub

        Private Sub winExplorerView_CustomUnboundColumnData(ByVal sender As Object, ByVal e As CustomColumnDataEventArgs)
            If e.IsSetData Then SetIsSelected(CType(e.Row, TEntity), CBool(e.Value))
            If e.IsGetData Then e.Value = GetIsSelected(CType(e.Row, TEntity))
        End Sub

        Private Sub winExplorerView_ItemClick(ByVal sender As Object, ByVal e As WinExplorerViewItemClickEventArgs)
            Dim entity As TEntity = TryCast(e.ItemInfo.Row.RowKey, TEntity)
            If entity IsNot Nothing Then
                SetIsSelected(entity, Not e.ItemInfo.IsChecked)
                itemsView.RefreshData()
            End If
        End Sub
    End Class
End Namespace
