Imports DevExpress.Mvvm.DataModel
Imports DevExpress.DevAV.Common.ViewModel
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.XtraGrid.Views.Grid

Namespace DevExpress.DevAV.Presenters

    Public MustInherit Class PeekListPresenter(Of TEntity As Class, TID, TUnitOfWork As {Class, IUnitOfWork})
        Inherits BasePresenter(Of CollectionViewModel(Of TEntity, TID, TUnitOfWork))

        Public Sub New(ByVal gridView As GridView, ByVal viewModel As CollectionViewModel(Of TEntity, TID, TUnitOfWork))
            MyBase.New(viewModel)
            gridViewCore = gridView
            If Me.GridView IsNot Nothing Then InitRowActivationBehavior()
        End Sub

        Protected Overrides Sub OnDisposing()
            If GridView IsNot Nothing Then ReleaseRowActivationBehavior()
            gridViewCore = Nothing
            MyBase.OnDisposing()
        End Sub

        Private gridViewCore As GridView

        Protected ReadOnly Property GridView As GridView
            Get
                Return gridViewCore
            End Get
        End Property

        Protected ReadOnly Property MainViewModel As MainViewModel
            Get
                Return GetParentViewModel(Of MainViewModel)()
            End Get
        End Property

#Region "Row Activation Behavior"
        Private Sub InitRowActivationBehavior()
            AddHandler GridView.RowClick, AddressOf GridView_RowClick
            AddHandler GridView.KeyDown, AddressOf GridView_KeyDown
        End Sub

        Private Sub ReleaseRowActivationBehavior()
            RemoveHandler GridView.RowClick, AddressOf GridView_RowClick
            RemoveHandler GridView.KeyDown, AddressOf GridView_KeyDown
        End Sub

        Private Sub GridView_RowClick(ByVal sender As Object, ByVal e As RowClickEventArgs)
            If e.Clicks = 2 AndAlso e.Button = System.Windows.Forms.MouseButtons.Left Then e.Handled = TrySelectEntity(e.RowHandle)
        End Sub

        Private Sub GridView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
            If e.KeyCode = System.Windows.Forms.Keys.Enter Then e.Handled = TrySelectEntity(GridView.FocusedRowHandle)
        End Sub

        Private Function TrySelectEntity(ByVal rowHandle As Integer) As Boolean
            Dim helper = New ColumnViewHelper(Of TEntity, TID, TUnitOfWork)(GridView, ViewModel)
            If helper.IsEntity(rowHandle) Then MainViewModel.SelectedModuleType = GetMainModuleType()
            Return helper.SelectEntity(rowHandle)
        End Function

#End Region
        Protected MustOverride Function GetMainModuleType() As ModuleType
    End Class
End Namespace
