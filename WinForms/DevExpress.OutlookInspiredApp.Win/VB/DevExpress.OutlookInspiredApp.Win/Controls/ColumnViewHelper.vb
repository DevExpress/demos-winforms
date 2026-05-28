Imports System.Collections.Generic
Imports System.Drawing
Imports DevExpress.DevAV.Common.ViewModel
Imports DevExpress.Mvvm.DataModel
Imports DevExpress.XtraGrid.Views.Base

Namespace DevExpress.DevAV

    Friend Class ColumnViewHelper(Of TEntity As Class, TID, TUnitOfWork As {Class, IUnitOfWork})

        Private viewModel As CollectionViewModel(Of TEntity, TID, TUnitOfWork)

        Private view As ColumnView

        Public Sub New(ByVal view As ColumnView, ByVal viewModel As CollectionViewModel(Of TEntity, TID, TUnitOfWork))
            Me.view = view
            Me.viewModel = viewModel
        End Sub

        Public Function GetSelection() As IEnumerable(Of TEntity)
            Dim rowHandles As Integer() = view.GetSelectedRows()
            Dim entities As TEntity() = New TEntity(rowHandles.Length - 1) {}
            For i As Integer = 0 To entities.Length - 1
                entities(i) = TryCast(view.GetRow(rowHandles(i)), TEntity)
            Next

            Return entities
        End Function

        Public Sub PopulateEntityMenu(ByVal menu As Utils.Menu.DXPopupMenu, ByVal rowHandle As Integer)
            If Not view.IsDataRow(rowHandle) Then Return
            Dim entity As TEntity = TryCast(view.GetRow(rowHandle), TEntity)
            If entity IsNot Nothing Then CreateEntityMenu(menu, entity)
        End Sub

        Public Function ShowEntityMenu(ByVal pt As Point, ByVal rowHandle As Integer) As Boolean
            Dim entity As TEntity = TryCast(view.GetRow(rowHandle), TEntity)
            If entity IsNot Nothing Then
                Dim rowMenu = New Utils.Menu.DXPopupMenu()
                CreateEntityMenu(rowMenu, entity)
                Utils.Menu.MenuManagerHelper.ShowMenu(rowMenu, view.GridControl.LookAndFeel, view.GridControl.MenuManager, view.GridControl, pt)
                Return True
            End If

            Return False
        End Function

        Public Function EditEntity(ByVal rowHandle As Integer) As Boolean
            If Not view.IsDataRow(rowHandle) Then Return False
            Dim entity As TEntity = TryCast(view.GetRow(rowHandle), TEntity)
            If entity IsNot Nothing AndAlso viewModel.CanEdit(entity) Then
                viewModel.Edit(entity)
                Return True
            End If

            Return False
        End Function

        Public Function IsEntity(ByVal rowHandle As Integer) As Boolean
            If Not view.IsValidRowHandle(rowHandle) Then Return False
            Return view.IsDataRow(rowHandle)
        End Function

        Public Function SelectEntity(ByVal rowHandle As Integer) As Boolean
            If Not view.IsValidRowHandle(rowHandle) Then Return False
            If view.IsDataRow(rowHandle) Then
                viewModel.SelectedEntity = TryCast(view.GetRow(rowHandle), TEntity)
            Else
                viewModel.SelectedEntity = Nothing
            End If

            Return True
        End Function

        Protected Sub CreateEntityMenu(ByVal rowMenu As Utils.Menu.DXPopupMenu, ByVal entity As TEntity)
            Dim newItem = New Utils.Menu.DXMenuItem()
            newItem.Caption = "New"
            newItem.BindCommand(Sub() viewModel.[New](), viewModel)
            Dim editItem = New Utils.Menu.DXMenuItem()
            editItem.Caption = "Edit..."
            editItem.BindCommand(Sub(ee) viewModel.Edit(ee), viewModel, Function() entity)
            Dim deleteItem = New Utils.Menu.DXMenuItem()
            deleteItem.Caption = "Delete"
            deleteItem.BindCommand(Sub(ee) viewModel.Delete(ee), viewModel, Function() entity)
            rowMenu.Items.Add(newItem)
            rowMenu.Items.Add(editItem)
            rowMenu.Items.Add(deleteItem)
        End Sub
    End Class
End Namespace
