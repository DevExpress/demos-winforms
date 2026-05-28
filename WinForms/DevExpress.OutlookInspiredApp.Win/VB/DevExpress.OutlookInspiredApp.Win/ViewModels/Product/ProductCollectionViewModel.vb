Imports System.Linq
Imports DevExpress.Mvvm.POCO
Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.Mvvm.DataModel
Imports DevExpress.DevAV.Common.ViewModel

Namespace DevExpress.DevAV.ViewModels

    ''' <summary>
    ''' Represents the Products collection view model.
    ''' </summary>
    Public Partial Class ProductCollectionViewModel
        Inherits CollectionViewModel(Of Product, Long, IDevAVDbUnitOfWork)

        ''' <summary>
        ''' Creates a new instance of ProductCollectionViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(ByVal Optional unitOfWorkFactory As IUnitOfWorkFactory(Of IDevAVDbUnitOfWork) = Nothing) As ProductCollectionViewModel
            Return ViewModelSource.Create(Function() New ProductCollectionViewModel(unitOfWorkFactory))
        End Function

        ''' <summary>
        ''' Initializes a new instance of the ProductCollectionViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the ProductCollectionViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(ByVal Optional unitOfWorkFactory As IUnitOfWorkFactory(Of IDevAVDbUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, GetUnitOfWorkFactory()), Function(x) x.Products, Function(query) query.OrderBy(Function(x) x.Category))
        End Sub
    End Class
End Namespace
