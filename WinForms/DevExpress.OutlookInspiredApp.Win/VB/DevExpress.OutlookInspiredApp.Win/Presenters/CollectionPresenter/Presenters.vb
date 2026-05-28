Imports System
Imports System.Collections.Generic
Imports DevExpress.DevAV.Common.ViewModel
Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.XtraGantt
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Layout.Events

Namespace DevExpress.DevAV.Presenters

    Public Class EmployeeCollectionPresenter
        Inherits CollectionPresenter(Of Employee, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal gridControl As GridControl, ByVal viewModel As EmployeeCollectionViewModel, ByVal updateUIAction As Action(Of Integer))
            MyBase.New(gridControl, viewModel, updateUIAction)
        End Sub

        Protected Overloads ReadOnly Property ViewModel As EmployeeCollectionViewModel
            Get
                Return TryCast(MyBase.ViewModel, EmployeeCollectionViewModel)
            End Get
        End Property

        Protected Overrides Sub SubscribeViewModelEvents()
            MyBase.SubscribeViewModelEvents()
            AddHandler ViewModel.Reload, AddressOf ViewModel_Reload
        End Sub

        Protected Overrides Sub UnsubscribeViewModelEvents()
            RemoveHandler ViewModel.Reload, AddressOf ViewModel_Reload
            MyBase.UnsubscribeViewModelEvents()
        End Sub

        Protected Overrides Sub InitMouseClickBehavior()
            MyBase.InitMouseClickBehavior()
            AddHandler GridView.RowCellClick, AddressOf GridView_RowCellClick
            AddHandler LayoutView.FieldValueClick, AddressOf Me.LayoutView_FieldValueClick
        End Sub

        Protected Overrides Sub ReleaseMouseClickBehavior()
            RemoveHandler GridView.RowCellClick, AddressOf GridView_RowCellClick
            RemoveHandler LayoutView.FieldValueClick, AddressOf Me.LayoutView_FieldValueClick
            MyBase.ReleaseMouseClickBehavior()
        End Sub

        Protected Overrides Sub SetSelection(ByVal selection As IEnumerable(Of Employee))
            ViewModel.Selection = selection
        End Sub

        Protected Overrides Function GetKey(ByVal entity As Employee) As Long
            Return entity.Id
        End Function

        Private Sub GridView_RowCellClick(ByVal sender As Object, ByVal e As RowCellClickEventArgs)
            MailTo(e.RowHandle, e.Column, e.CellValue)
        End Sub

        Private Sub LayoutView_FieldValueClick(ByVal sender As Object, ByVal e As FieldValueClickEventArgs)
            MailTo(e.RowHandle, e.Column, e.FieldValue)
        End Sub

        Private Sub MailTo(ByVal rowHandle As Integer, ByVal column As GridColumn, ByVal value As Object)
            If rowHandle > -1 AndAlso Equals(column.FieldName, "Email") Then Call EmployeeContactsViewModel.ExecuteMailTo(GetService(Of Mvvm.IMessageBoxService)(), CStr(value))
        End Sub
    End Class

    Public Class CustomerCollectionPresenter
        Inherits CollectionPresenter(Of Customer, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal gridControl As GridControl, ByVal viewModel As CustomerCollectionViewModel, ByVal updateUIAction As Action(Of Integer))
            MyBase.New(gridControl, viewModel, updateUIAction)
            AddHandler Me.GridControl.FocusedViewChanged, AddressOf gridControl_FocusedViewChanged
        End Sub

        Protected Overrides Sub OnDisposing()
            RemoveHandler GridControl.FocusedViewChanged, AddressOf gridControl_FocusedViewChanged
            MyBase.OnDisposing()
        End Sub

        Private Sub gridControl_FocusedViewChanged(ByVal sender As Object, ByVal e As ViewFocusEventArgs)
            If e.View IsNot Nothing AndAlso e.View.IsDetailView Then
                Dim parentView = TryCast(e.View.ParentView, Views.Base.ColumnView)
                If parentView IsNot Nothing Then parentView.FocusedRowHandle = e.View.SourceRowHandle
            End If
        End Sub

        Protected Overloads ReadOnly Property ViewModel As CustomerCollectionViewModel
            Get
                Return TryCast(MyBase.ViewModel, CustomerCollectionViewModel)
            End Get
        End Property

        Protected Overrides Sub SubscribeViewModelEvents()
            MyBase.SubscribeViewModelEvents()
            AddHandler ViewModel.Reload, AddressOf ViewModel_Reload
        End Sub

        Protected Overrides Sub UnsubscribeViewModelEvents()
            RemoveHandler ViewModel.Reload, AddressOf ViewModel_Reload
            MyBase.UnsubscribeViewModelEvents()
        End Sub

        Protected Overrides Sub SetSelection(ByVal selection As IEnumerable(Of Customer))
            ViewModel.Selection = selection
        End Sub

        Protected Overrides Function GetKey(ByVal entity As Customer) As Long
            Return entity.Id
        End Function
    End Class

    Public Class ProductCollectionPresenter
        Inherits CollectionPresenter(Of Product, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal gridControl As GridControl, ByVal viewModel As ProductCollectionViewModel, ByVal updateUIAction As Action(Of Integer))
            MyBase.New(gridControl, viewModel, updateUIAction)
        End Sub

        Protected Overloads ReadOnly Property ViewModel As ProductCollectionViewModel
            Get
                Return TryCast(MyBase.ViewModel, ProductCollectionViewModel)
            End Get
        End Property

        Protected Overrides Sub SubscribeViewModelEvents()
            MyBase.SubscribeViewModelEvents()
            AddHandler ViewModel.Reload, AddressOf ViewModel_Reload
        End Sub

        Protected Overrides Sub UnsubscribeViewModelEvents()
            RemoveHandler ViewModel.Reload, AddressOf ViewModel_Reload
            MyBase.UnsubscribeViewModelEvents()
        End Sub

        Protected Overrides Sub SetSelection(ByVal selection As IEnumerable(Of Product))
            ViewModel.Selection = selection
        End Sub

        Protected Overrides Function GetKey(ByVal entity As Product) As Long
            Return entity.Id
        End Function
    End Class

    Public Class OrderCollectionPresenter
        Inherits CollectionPresenter(Of Order, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal gridControl As GridControl, ByVal viewModel As OrderCollectionViewModel, ByVal updateUIAction As Action(Of Integer))
            MyBase.New(gridControl, viewModel, updateUIAction)
            AddHandler Me.GridControl.FocusedViewChanged, AddressOf gridControl_FocusedViewChanged
        End Sub

        Protected Overrides Sub OnDisposing()
            RemoveHandler GridControl.FocusedViewChanged, AddressOf gridControl_FocusedViewChanged
            MyBase.OnDisposing()
        End Sub

        Private Sub gridControl_FocusedViewChanged(ByVal sender As Object, ByVal e As ViewFocusEventArgs)
            If e.View IsNot Nothing AndAlso e.View.IsDetailView Then
                Dim parentView = TryCast(e.View.ParentView, Views.Base.ColumnView)
                If parentView IsNot Nothing Then parentView.FocusedRowHandle = e.View.SourceRowHandle
            End If
        End Sub

        Protected Overrides Sub SetTopRow()
            If GridView IsNot Nothing AndAlso GridView.FocusedRowHandle = 0 Then GridView.FocusedRowHandle = 1
            MyBase.SetTopRow()
        End Sub

        Protected Overloads ReadOnly Property ViewModel As OrderCollectionViewModel
            Get
                Return TryCast(MyBase.ViewModel, OrderCollectionViewModel)
            End Get
        End Property

        Protected Overrides Sub SubscribeViewModelEvents()
            MyBase.SubscribeViewModelEvents()
            AddHandler ViewModel.Reload, AddressOf ViewModel_Reload
        End Sub

        Protected Overrides Sub UnsubscribeViewModelEvents()
            RemoveHandler ViewModel.Reload, AddressOf ViewModel_Reload
            MyBase.UnsubscribeViewModelEvents()
        End Sub

        Protected Overrides Sub SetSelection(ByVal selection As IEnumerable(Of Order))
        End Sub

        Protected Overrides Function GetKey(ByVal entity As Order) As Long
            Return entity.Id
        End Function
    End Class

    Public Class TasksCollectionPresenterType
        Inherits TasksCollectionPresenter(Of EmployeeTask, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal gridControl As GanttControl, ByVal viewModel As CollectionViewModel(Of EmployeeTask, Long, IDevAVDbUnitOfWork), ByVal updateUIAction As Action(Of Integer))
            MyBase.New(gridControl, viewModel, updateUIAction)
        End Sub

        Protected Overloads ReadOnly Property ViewModel As TaskCollectionViewModel
            Get
                Return TryCast(MyBase.ViewModel, TaskCollectionViewModel)
            End Get
        End Property

        Protected Overrides Sub SubscribeViewModelEvents()
            MyBase.SubscribeViewModelEvents()
            AddHandler ViewModel.Reload, AddressOf ViewModel_Reload
        End Sub

        Protected Overrides Sub UnsubscribeViewModelEvents()
            RemoveHandler ViewModel.Reload, AddressOf ViewModel_Reload
            MyBase.UnsubscribeViewModelEvents()
        End Sub
    End Class
End Namespace
