Imports DevExpress.DevAV.Common.Utils
Imports DevExpress.DevAV.Presenters
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.XtraLayout.Utils

Namespace DevExpress.DevAV.Modules

    Public Partial Class OrdersFilterPane
        Inherits BaseModuleControl
        Implements ISupportCompactLayout

        Private accordionPresenterCore As OrderFilterAccordionPresenter

        Public Sub New(ByVal collectionViewModel As OrderCollectionViewModel)
            MyBase.New(GetType(OrdersFilterTreeViewModel), New Object() {collectionViewModel})
            InitializeComponent()
            accordionPresenterCore = CreatePresenter()
            BindCommands()
            SwapFluentIcons(Me)
        End Sub

        Protected Overrides Sub OnDisposing()
            Presenter.Dispose()
            MyBase.OnDisposing()
        End Sub

        Public ReadOnly Property ViewModel As OrdersFilterTreeViewModel
            Get
                Return GetViewModel(Of OrdersFilterTreeViewModel)()
            End Get
        End Property

        Public ReadOnly Property Presenter As OrderFilterAccordionPresenter
            Get
                Return accordionPresenterCore
            End Get
        End Property

        Protected Overridable Function CreatePresenter() As OrderFilterAccordionPresenter
            Return New OrderFilterAccordionPresenter(accordionControl, ViewModel)
        End Function

        Protected Overrides Sub OnInitServices()
            mvvmContext.RegisterService("Custom Filter", New FilterDialogDocumentManagerService(ModuleType.OrdersCustomFilter))
        End Sub

        Protected Overridable Sub BindCommands()
            btnNewOrder.BindCommand(Sub() Presenter.CollectionViewModel.[New](), Presenter.CollectionViewModel)
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
            btnNewOrder.Visible = Not compactLayout
        End Sub
#End Region
    End Class
End Namespace
