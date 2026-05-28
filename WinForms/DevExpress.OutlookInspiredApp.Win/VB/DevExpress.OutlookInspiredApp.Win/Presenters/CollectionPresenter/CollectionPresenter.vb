Imports DevExpress.DevAV.Common.ViewModel
Imports DevExpress.Mvvm.DataModel
Imports DevExpress.Utils
Imports DevExpress.XtraGantt
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Layout
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms

Namespace DevExpress.DevAV.Presenters

    Public MustInherit Class CollectionPresenter(Of TEntity As Class, TID, TUnitOfWork As {Class, IUnitOfWork})
        Inherits BasePresenter(Of CollectionViewModel(Of TEntity, TID, TUnitOfWork))

        Private updateUIAction As Action(Of Integer)

        Public Sub New(ByVal gridControl As GridControl, ByVal viewModel As CollectionViewModel(Of TEntity, TID, TUnitOfWork), ByVal updateUIAction As Action(Of Integer))
            MyBase.New(viewModel)
            gridControlCore = gridControl
            Me.updateUIAction = updateUIAction
            gridViewCore = TryCast(gridControl.ViewCollection.FirstOrDefault(Function(view)(TypeOf view Is GridView) AndAlso String.IsNullOrEmpty(view.LevelName)), GridView)
            layoutViewCore = TryCast(gridControl.ViewCollection.FirstOrDefault(Function(view)(TypeOf view Is LayoutView) AndAlso String.IsNullOrEmpty(view.LevelName)), LayoutView)
            SubscribeViewModelEvents()
            InitMouseClickBehavior()
            InitFocusedRowSynchronization()
            AddHandler Me.GridControl.Load, AddressOf GridControl_Load
        End Sub

        Protected Overrides Sub OnDisposing()
            RemoveHandler GridControl.Load, AddressOf GridControl_Load
            UnsubscribeViewModelEvents()
            ReleaseMouseClickBehavior()
            ReleaseFocusedRowSynchronization()
            loadingTrigger.Dispose()
            entitiesBinding.Dispose()
            gridControlCore = Nothing
            layoutViewCore = Nothing
            gridViewCore = Nothing
            MyBase.OnDisposing()
        End Sub

        Private gridControlCore As GridControl

        Protected ReadOnly Property GridControl As GridControl
            Get
                Return gridControlCore
            End Get
        End Property

        Private gridViewCore As GridView

        Protected ReadOnly Property GridView As GridView
            Get
                Return gridViewCore
            End Get
        End Property

        Private layoutViewCore As LayoutView

        Protected ReadOnly Property LayoutView As LayoutView
            Get
                Return layoutViewCore
            End Get
        End Property

        Protected Overridable Sub SubscribeViewModelEvents()
            AddHandler ViewModel.EntityChanged, AddressOf ViewModel_EntityChanged
            AddHandler ViewModel.EntitiesCountChanged, AddressOf ViewModel_EntitiesCountChanged
        End Sub

        Protected Overridable Sub UnsubscribeViewModelEvents()
            RemoveHandler ViewModel.EntityChanged, AddressOf ViewModel_EntityChanged
            RemoveHandler ViewModel.EntitiesCountChanged, AddressOf ViewModel_EntitiesCountChanged
        End Sub

        Private Sub GridControl_Load(ByVal sender As Object, ByVal e As EventArgs)
            SetFindControlImages(GridControl)
        End Sub

        Protected Overridable Sub SetTopRow()
            If GridView Is Nothing Then Return
            GridView.ClearSelection()
            GridView.SelectRow(0)
            GridView.FocusedRowHandle = 0
            GridView.ExpandMasterRow(0)
        End Sub

        Protected Sub ViewModel_Reload(ByVal sender As Object, ByVal e As EventArgs)
            OnReloadEntities(context)
            SetTopRow()
        End Sub

        Private Sub ViewModel_EntityChanged(ByVal sender As Object, ByVal e As EntityEventArgs(Of TID))
            If LayoutView IsNot Nothing Then LayoutView.InvalidateCardCaption(LayoutView.LocateByValue(GetKeyColumn(), e.Key))
        End Sub

        Private Sub ViewModel_EntitiesCountChanged(ByVal sender As Object, ByVal e As EntitiesCountEventArgs)
            UpdateEntitiesCountRelatedUI(e.Count)
        End Sub

        Private context As Utils.MVVM.MVVMContext

        Private entitiesBinding As Utils.MVVM.IPropertyBinding

        Private loadingTrigger As IDisposable

        Private Sub OnReloadEntities(ByVal context As Utils.MVVM.MVVMContext)
            If entitiesBinding Is Nothing Then
                entitiesBinding = context.SetBinding(GridControl, Function(g) g.DataSource, "Entities")
                loadingTrigger = context.SetTrigger(Of CollectionViewModel(Of TEntity, TID, TUnitOfWork), Boolean)(Function(x) x.IsLoading, Sub(loading)
                    If loading Then
                        GridView.ShowLoadingPanel()
                    Else
                        GridView.HideLoadingPanel()
                        SetTopRow()
                    End If
                End Sub)
            Else
                entitiesBinding.UpdateTarget()
            End If

            CType(GridControl.MainView, ColumnView).FindFilterText = Nothing
            CType(GridControl.MainView, ColumnView).ActiveFilterString = Nothing
            UpdateEntitiesCountRelatedUI(ViewModel.Entities.Count)
        End Sub

        Private Sub UpdateEntitiesCountRelatedUI(ByVal count As Integer)
            If updateUIAction IsNot Nothing Then updateUIAction(count)
        End Sub

#Region "Focused Row Synchronization"
        Private Sub InitFocusedRowSynchronization()
            AddHandler ViewModel.SelectedEntityChanged, AddressOf ViewModel_SelectedEntityChanged
            If GridView IsNot Nothing Then
                GridView.DataController.AllowCurrentRowObjectForGroupRow = False
                AddHandler GridView.FocusedRowObjectChanged, AddressOf ColumnView_FocusedRowObjectChanged
                AddHandler GridView.SelectionChanged, AddressOf View_SelectionChanged
            End If

            If LayoutView IsNot Nothing Then
                AddHandler LayoutView.FocusedRowObjectChanged, AddressOf ColumnView_FocusedRowObjectChanged
                AddHandler LayoutView.SelectionChanged, AddressOf View_SelectionChanged
            End If
        End Sub

        Private Sub ReleaseFocusedRowSynchronization()
            RemoveHandler ViewModel.SelectedEntityChanged, AddressOf ViewModel_SelectedEntityChanged
            If GridView IsNot Nothing Then
                RemoveHandler GridView.FocusedRowObjectChanged, AddressOf ColumnView_FocusedRowObjectChanged
                RemoveHandler GridView.SelectionChanged, AddressOf View_SelectionChanged
            End If

            If LayoutView IsNot Nothing Then
                RemoveHandler LayoutView.FocusedRowObjectChanged, AddressOf ColumnView_FocusedRowObjectChanged
                RemoveHandler LayoutView.SelectionChanged, AddressOf View_SelectionChanged
            End If
        End Sub

        Private Sub View_SelectionChanged(ByVal sender As Object, ByVal e As Data.SelectionChangedEventArgs)
            Dim helper = New ColumnViewHelper(Of TEntity, TID, TUnitOfWork)(CType(sender, ColumnView), ViewModel)
            SetSelection(helper.GetSelection())
        End Sub

        Private lockFocusedRowChanged As Integer = 0

        Private Sub ColumnView_FocusedRowObjectChanged(ByVal sender As Object, ByVal e As FocusedRowObjectChangedEventArgs)
            lockFocusedRowChanged += 1
            Try
                Dim view As ColumnView = CType(sender, ColumnView)
                If view.IsValidRowHandle(e.FocusedRowHandle) Then
                    If view.IsDataRow(e.FocusedRowHandle) Then
                        ViewModel.SelectedEntity = TryCast(e.Row, TEntity)
                    Else
                        ViewModel.SelectedEntity = Nothing
                    End If
                End If
            Finally
                lockFocusedRowChanged -= 1
            End Try
        End Sub

        Private Sub ViewModel_SelectedEntityChanged(ByVal sender As Object, ByVal e As EventArgs)
            If lockFocusedRowChanged > 0 Then Return
            If ViewModel.SelectedEntity Is Nothing Then
                If GridView IsNot Nothing Then GridView.FocusedRowHandle = GridControl.InvalidRowHandle
                If LayoutView IsNot Nothing Then LayoutView.FocusedRowHandle = GridControl.InvalidRowHandle
            Else
                If GridView IsNot Nothing Then GridView.FocusedRowHandle = GridView.LocateByValue(GetKeyColumn(), GetKey(ViewModel.SelectedEntity))
                If LayoutView IsNot Nothing Then LayoutView.FocusedRowHandle = LayoutView.LocateByValue(GetKeyColumn(), GetKey(ViewModel.SelectedEntity))
            End If
        End Sub

        Protected MustOverride Sub SetSelection(ByVal selection As IEnumerable(Of TEntity))

        Protected MustOverride Function GetKey(ByVal entity As TEntity) As TID

        Protected Overridable Function GetKeyColumn() As String
            Return "Id"
        End Function

#End Region
#Region "Mouse Click Behavior"
        Protected Overridable Sub InitMouseClickBehavior()
            If GridView IsNot Nothing Then
                AddHandler GridView.RowClick, AddressOf GridView_RowClick
                AddHandler GridView.PopupMenuShowing, AddressOf GridView_PopupMenuShowing
            End If

            If LayoutView IsNot Nothing Then
                AddHandler LayoutView.MouseDown, AddressOf Me.LayoutView_MouseDown
                AddHandler LayoutView.DoubleClick, AddressOf Me.LayoutView_DoubleClick
            End If
        End Sub

        Protected Overridable Sub ReleaseMouseClickBehavior()
            If GridView IsNot Nothing Then
                RemoveHandler GridView.RowClick, AddressOf GridView_RowClick
                RemoveHandler GridView.PopupMenuShowing, AddressOf GridView_PopupMenuShowing
            End If

            If LayoutView IsNot Nothing Then
                RemoveHandler LayoutView.MouseDown, AddressOf Me.LayoutView_MouseDown
                RemoveHandler LayoutView.DoubleClick, AddressOf Me.LayoutView_DoubleClick
            End If
        End Sub

        Private Sub LayoutView_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim ea As DXMouseEventArgs = TryCast(e, DXMouseEventArgs)
            If ea.Button <> MouseButtons.Left Then Return
            Dim hitInfo = CType(sender, LayoutView).CalcHitInfo(ea.Location)
            If hitInfo.InCard Then
                Dim helper = New ColumnViewHelper(Of TEntity, TID, TUnitOfWork)(CType(sender, ColumnView), ViewModel)
                ea.Handled = helper.EditEntity(hitInfo.RowHandle)
            End If
        End Sub

        Private Sub LayoutView_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            If e.Button <> MouseButtons.Right OrElse e.Clicks <> 1 Then Return
            Dim ea As DXMouseEventArgs = DXMouseEventArgs.GetMouseArgs(e)
            Dim hitInfo = CType(sender, LayoutView).CalcHitInfo(ea.Location)
            If hitInfo.InCard Then
                Dim helper = New ColumnViewHelper(Of TEntity, TID, TUnitOfWork)(CType(sender, ColumnView), ViewModel)
                ea.Handled = helper.ShowEntityMenu(ea.Location, hitInfo.RowHandle)
            End If
        End Sub

        Private Sub GridView_RowClick(ByVal sender As Object, ByVal e As RowClickEventArgs)
            If e.Clicks = 2 AndAlso e.Button = MouseButtons.Left Then
                Dim helper = New ColumnViewHelper(Of TEntity, TID, TUnitOfWork)(CType(sender, ColumnView), ViewModel)
                e.Handled = helper.EditEntity(e.RowHandle)
            End If
        End Sub

        Private Sub GridView_PopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs)
            If e.MenuType = GridMenuType.Row AndAlso e.HitInfo.InRowCell Then
                Dim helper = New ColumnViewHelper(Of TEntity, TID, TUnitOfWork)(CType(sender, ColumnView), ViewModel)
                helper.PopulateEntityMenu(e.Menu, e.HitInfo.RowHandle)
            End If
        End Sub

#End Region
        Public Sub ReloadEntities(ByVal context As Utils.MVVM.MVVMContext)
            If Me.context Is Nothing Then Me.context = context
            OnReloadEntities(context)
        End Sub

        Public Sub ReverseSort(ByVal gridColumn As GridColumn, ByVal layoutViewColumn As LayoutViewColumn)
            If GridControl.MainView Is GridView Then
                ReverseSort(GridView, gridColumn)
            Else
                ReverseSort(LayoutView, layoutViewColumn)
            End If
        End Sub

        Public Sub ReverseSort(ByVal view As ColumnView, ByVal column As GridColumn)
            If view.SortInfo(column) Is Nothing Then Return
            If view.SortInfo(column).SortOrder = Data.ColumnSortOrder.Ascending Then
                view.SortInfo(column).SortOrder = Data.ColumnSortOrder.Descending
            Else
                view.SortInfo(column).SortOrder = Data.ColumnSortOrder.Ascending
            End If
        End Sub

        Public Sub ExpandCollapseGroups()
            If GridControl.MainView Is GridView Then
                If GridView.GetRowExpanded(-1) Then
                    GridView.CollapseAllGroups()
                Else
                    GridView.ExpandAllGroups()
                End If
            End If
        End Sub

        Public Sub ExpandCollapseMasterRows()
            If GridControl.MainView Is GridView Then
                If GridView.GetMasterRowExpanded(0) Then
                    GridView.CollapseMasterRow(0)
                Else
                    GridView.ExpandMasterRow(0)
                End If
            End If
        End Sub

        Private biAddColumns As XtraBars.BarCheckItem

        Public Sub AddColumns(ByVal biAddColumns As XtraBars.BarCheckItem)
            Me.biAddColumns = biAddColumns
            If GridControl.MainView Is GridView Then
                If Not biAddColumns.Checked Then
                    GridView.HideCustomization()
                Else
                    AddHandler GridView.HideCustomizationForm, AddressOf GridView_HideCustomizationForm
                    GridView.ShowCustomization()
                End If
            End If
        End Sub

        Private Sub GridView_HideCustomizationForm(ByVal sender As Object, ByVal e As EventArgs)
            RemoveHandler GridView.HideCustomizationForm, AddressOf GridView_HideCustomizationForm
            If biAddColumns IsNot Nothing Then biAddColumns.Checked = False
            biAddColumns = Nothing
        End Sub
    End Class

    Public MustInherit Class TasksCollectionPresenter(Of TEntity As Class, TID, TUnitOfWork As {Class, IUnitOfWork})
        Inherits BasePresenter(Of CollectionViewModel(Of TEntity, TID, TUnitOfWork))

        Private updateUIAction As Action(Of Integer)

        Private ganttControlCore As GanttControl

        Public Sub New(ByVal gridControl As GanttControl, ByVal viewModel As CollectionViewModel(Of TEntity, TID, TUnitOfWork), ByVal updateUIAction As Action(Of Integer))
            MyBase.New(viewModel)
            ganttControlCore = gridControl
            Me.updateUIAction = updateUIAction
            SubscribeViewModelEvents()
            If GanttControl IsNot Nothing Then AddHandler GanttControl.FocusedNodeChanged, AddressOf GanttControl_FocusedNodeChanged
        End Sub

        Private lockFocusedNodeChanged As Integer = 0

        Private Sub GanttControl_FocusedNodeChanged(ByVal sender As Object, ByVal e As XtraTreeList.FocusedNodeChangedEventArgs)
            If e.Node IsNot Nothing Then
                lockFocusedNodeChanged += 1
                Try
                    Dim view = CType(sender, GanttControl)
                    ViewModel.SelectedEntity = If(e.Node.Focused, TryCast(view.GetDataRecordByNode(e.Node), TEntity), Nothing)
                Finally
                    lockFocusedNodeChanged -= 1
                End Try
            End If
        End Sub

        Protected Overridable Sub SubscribeViewModelEvents()
            AddHandler ViewModel.EntityChanged, AddressOf ViewModel_EntityChanged
            AddHandler ViewModel.EntitiesCountChanged, AddressOf ViewModel_EntitiesCountChanged
        End Sub

        Protected Overridable Sub UnsubscribeViewModelEvents()
            RemoveHandler ViewModel.EntityChanged, AddressOf ViewModel_EntityChanged
            RemoveHandler ViewModel.EntitiesCountChanged, AddressOf ViewModel_EntitiesCountChanged
        End Sub

        Private Sub ViewModel_EntityChanged(ByVal sender As Object, ByVal e As EntityEventArgs(Of TID))
        End Sub

        Private Sub ViewModel_EntitiesCountChanged(ByVal sender As Object, ByVal e As EntitiesCountEventArgs)
            UpdateEntitiesCountRelatedUI(e.Count)
        End Sub

        Private Sub UpdateEntitiesCountRelatedUI(ByVal count As Integer)
            If updateUIAction IsNot Nothing Then updateUIAction(count)
        End Sub

        Protected ReadOnly Property GanttControl As GanttControl
            Get
                Return ganttControlCore
            End Get
        End Property

        Public Sub ReloadEntities(ByVal context As Utils.MVVM.MVVMContext)
            If Me.context Is Nothing Then Me.context = context
            OnReloadEntities(context)
        End Sub

        Private context As Utils.MVVM.MVVMContext

        Private entitiesBinding As Utils.MVVM.IPropertyBinding

        Private loadingTrigger As IDisposable

        Private Sub OnReloadEntities(ByVal context As Utils.MVVM.MVVMContext)
            If entitiesBinding Is Nothing Then
                entitiesBinding = context.SetBinding(GanttControl, Function(g) g.DataSource, "Entities")
                loadingTrigger = context.SetTrigger(Of CollectionViewModel(Of TEntity, TID, TUnitOfWork), Boolean)(Function(x) x.IsLoading, Sub(loading)
                    If loading Then
                        GanttControl.ShowLoadingPanel()
                    Else
                        GanttControl.HideLoadingPanel()
                        SetTopRow()
                    End If
                End Sub)
            Else
                entitiesBinding.UpdateTarget()
            End If

            GanttControl.FindFilterText = Nothing
            GanttControl.ActiveFilterString = Nothing
            UpdateEntitiesCountRelatedUI(ViewModel.Entities.Count)
        End Sub

        Protected Overridable Sub SetTopRow()
            GanttControl.ClearSelection()
            If GanttControl.NodesIterator.Visible.Any() Then
                Dim firstNode = GanttControl.NodesIterator.Visible.First()
                GanttControl.FocusedNode = firstNode
                GanttControl.SelectNode(firstNode)
                Dim nodeEntity = TryCast(GanttControl.GetDataRecordByNode(firstNode), TEntity)
                ViewModel.SelectedEntity = nodeEntity
                GanttControl.ExpandToLevel(0)
            End If
        End Sub

        Protected Sub ViewModel_Reload(ByVal sender As Object, ByVal e As EventArgs)
            OnReloadEntities(context)
            SetTopRow()
        End Sub
    End Class
End Namespace
