Imports DevExpress.DevAV.Common.Utils
Imports DevExpress.DevAV.Presenters
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.XtraLayout.Utils

Namespace DevExpress.DevAV.Modules

    Public Partial Class QuotesFilterPane
        Inherits BaseModuleControl
        Implements ISupportCompactLayout

        Private accordionPresenterCore As QuoteFilterAccordionPresenter

        Public Sub New(ByVal collectionViewModel As QuoteCollectionViewModel)
            MyBase.New(GetType(QuotesFilterTreeViewModel), New Object() {collectionViewModel})
            InitializeComponent()
            accordionPresenterCore = CreatePresenter()
            BindCommands()
            SwapFluentIcons(Me)
        End Sub

        Protected Overrides Sub OnDisposing()
            Presenter.Dispose()
            MyBase.OnDisposing()
        End Sub

        Public ReadOnly Property ViewModel As QuotesFilterTreeViewModel
            Get
                Return GetViewModel(Of QuotesFilterTreeViewModel)()
            End Get
        End Property

        Public ReadOnly Property Presenter As QuoteFilterAccordionPresenter
            Get
                Return accordionPresenterCore
            End Get
        End Property

        Protected Overridable Function CreatePresenter() As QuoteFilterAccordionPresenter
            Return New QuoteFilterAccordionPresenter(accordionControl, ViewModel)
        End Function

        Protected Overrides Sub OnInitServices()
            mvvmContext.RegisterService("Custom Filter", New FilterDialogDocumentManagerService(ModuleType.QuotesCustomFilter))
        End Sub

        Protected Overridable Sub BindCommands()
            btnNewQuote.BindCommand(Sub() Presenter.CollectionViewModel.[New](), Presenter.CollectionViewModel)
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
            btnNewQuote.Visible = Not compactLayout
        End Sub
#End Region
    End Class
End Namespace
