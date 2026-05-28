Imports DevExpress.DevAV.Presenters
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.XtraLayout.Utils

Namespace DevExpress.DevAV.Modules

    Public Partial Class EmployeesFilterPaneCollapsed
        Inherits BaseModuleControl
        Implements ISupportCompactLayout

        Private presenterCore As EmployeeFilterPanePresenter

        Public Sub New(ByVal collectionViewModel As EmployeeCollectionViewModel)
            MyBase.New(GetType(EmployeesFilterTreeViewModel), New Object() {collectionViewModel})
            InitializeComponent()
            presenterCore = CreatePresenter()
            BindCommands()
        End Sub

        Protected Overrides Sub OnDisposing()
            Presenter.Dispose()
            MyBase.OnDisposing()
        End Sub

        Public ReadOnly Property ViewModel As EmployeesFilterTreeViewModel
            Get
                Return GetViewModel(Of EmployeesFilterTreeViewModel)()
            End Get
        End Property

        Public ReadOnly Property Presenter As EmployeeFilterPanePresenter
            Get
                Return presenterCore
            End Get
        End Property

        Protected Overridable Function CreatePresenter() As EmployeeFilterPanePresenter
            Return New EmployeeFilterPanePresenter(navigationBar, ViewModel)
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
            btnNew.Visible = Not compactLayout
        End Sub
#End Region
    End Class
End Namespace
