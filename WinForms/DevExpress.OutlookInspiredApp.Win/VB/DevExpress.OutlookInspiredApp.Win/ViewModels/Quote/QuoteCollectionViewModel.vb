Imports DevExpress.Mvvm.POCO
Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.Mvvm.DataModel
Imports DevExpress.DevAV
Imports DevExpress.DevAV.Common.ViewModel

Namespace DevExpress.DevAV.ViewModels

    ''' <summary>
    ''' Represents the Quotes collection view model.
    ''' </summary>
    Public Partial Class QuoteCollectionViewModel
        Inherits CollectionViewModel(Of Quote, Long, IDevAVDbUnitOfWork)

        ''' <summary>
        ''' Creates a new instance of QuoteCollectionViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(ByVal Optional unitOfWorkFactory As IUnitOfWorkFactory(Of IDevAVDbUnitOfWork) = Nothing) As QuoteCollectionViewModel
            Return ViewModelSource.Create(Function() New QuoteCollectionViewModel(unitOfWorkFactory))
        End Function

        ''' <summary>
        ''' Initializes a new instance of the QuoteCollectionViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the QuoteCollectionViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(ByVal Optional unitOfWorkFactory As IUnitOfWorkFactory(Of IDevAVDbUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, GetUnitOfWorkFactory()), Function(x) x.Quotes, Function(query) query.ActualQuotes())
        End Sub
    End Class
End Namespace
