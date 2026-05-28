Imports DevExpress.DevAV.Common.Utils
Imports DevExpress.DevAV.Presenters
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.XtraLayout.Utils

Namespace DevExpress.DevAV.Modules

    Public Partial Class EmployeesFilterPane
        Inherits BaseModuleControl
        Implements ISupportCompactLayout

        Private accordionPresenterCore As EmployeeFilterAccordionPresenter

        Public Sub New(ByVal collectionViewModel As EmployeeCollectionViewModel)
            MyBase.New(GetType(EmployeesFilterTreeViewModel), New Object() {collectionViewModel})
            InitializeComponent()
            accordionPresenterCore = CreateAccordionPresenter()
            BindCommands()
            SwapFluentIcons(Me)
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

        Public ReadOnly Property Presenter As EmployeeFilterAccordionPresenter
            Get
                Return accordionPresenterCore
            End Get
        End Property

        Protected Overridable Function CreateAccordionPresenter() As EmployeeFilterAccordionPresenter
            Return New EmployeeFilterAccordionPresenter(accordionControl, ViewModel)
        End Function

        Protected Overrides Sub OnInitServices()
            mvvmContext.RegisterService("Custom Filter", New FilterDialogDocumentManagerService(ModuleType.EmployeesCustomFilter))
            mvvmContext.RegisterService("Group Filter", New FilterDialogDocumentManagerService(ModuleType.EmployeesGroupFilter))
        End Sub

        Protected Overridable Sub BindCommands()
            btnNewEmployee.BindCommand(Sub() Presenter.CollectionViewModel.[New](), Presenter.CollectionViewModel)
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
            btnNewEmployee.Visible = Not compactLayout
        End Sub
#End Region
    End Class
End Namespace
