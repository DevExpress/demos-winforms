Namespace DevExpress.DevAV.ViewModels

    Partial Class QuoteViewModel
    End Class

    Public Partial Class SynchronizedQuoteViewModel
        Inherits QuoteViewModel

        Protected Overrides ReadOnly Property EnableSelectedItemSynchronization As Boolean
            Get
                Return True
            End Get
        End Property

        Protected Overrides ReadOnly Property EnableEntityChangedSynchronization As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace
