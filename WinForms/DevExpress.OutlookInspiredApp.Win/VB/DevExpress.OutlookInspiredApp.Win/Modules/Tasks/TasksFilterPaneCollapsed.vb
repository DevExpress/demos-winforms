Imports DevExpress.DevAV.Presenters
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.XtraLayout.Utils

Namespace DevExpress.DevAV.Modules

    Public Partial Class TasksFilterPaneCollapsed
        Inherits BaseModuleControl
        Implements ISupportCompactLayout

        Private presenterCore As TasksFilterPanePresenter

        Public Sub New(ByVal collectionViewModel As TaskCollectionViewModel)
            MyBase.New(GetType(TasksFilterTreeViewModel), New Object() {collectionViewModel})
            InitializeComponent()
            presenterCore = CreatePresenter()
            BindCommands()
        End Sub

        Protected Overrides Sub OnDisposing()
            Presenter.Dispose()
            MyBase.OnDisposing()
        End Sub

        Public ReadOnly Property ViewModel As TasksFilterTreeViewModel
            Get
                Return GetViewModel(Of TasksFilterTreeViewModel)()
            End Get
        End Property

        Public ReadOnly Property Presenter As TasksFilterPanePresenter
            Get
                Return presenterCore
            End Get
        End Property

        Protected Overridable Function CreatePresenter() As TasksFilterPanePresenter
            Return New TasksFilterPanePresenter(navigationBar, ViewModel)
        End Function

        Protected Overridable Sub BindCommands()
            btnNew.BindCommand(Sub() Presenter.CollectionViewModel.[New](), Presenter.CollectionViewModel)
        End Sub

#Region "ISupportCompactLayout Members"
        Private compactLayout As Boolean = True

        Private Property Compact As Boolean Implements ISupportCompactLayout.Compact
            Get
                Return compactLayout
            End Get

            Set(ByVal value As Boolean)
                If compactLayout = value Then Return
                compactLayout = value
                UpdateCompactLayout()
            End Set
        End Property

        Private Sub UpdateCompactLayout()
            btnNewLayoutControlItem.Visibility = If(compactLayout, LayoutVisibility.Never, LayoutVisibility.Always)
        End Sub
#End Region
    End Class
End Namespace
