Imports DevExpress.DevAV.Common.ViewModel
Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.Mvvm.DataModel
Imports DevExpress.Mvvm.POCO
Imports System.Linq

Namespace DevExpress.DevAV.ViewModels

    Public Partial Class TaskCollectionViewModel
        Inherits CollectionViewModel(Of EmployeeTask, Long, IDevAVDbUnitOfWork)

        ''' <summary>
        ''' Creates a new instance of GanttCollectionViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(ByVal Optional unitOfWorkFactory As IUnitOfWorkFactory(Of IDevAVDbUnitOfWork) = Nothing) As TaskCollectionViewModel
            Return ViewModelSource.Create(Function() New TaskCollectionViewModel(unitOfWorkFactory))
        End Function

        ''' <summary>
        ''' Initializes a new instance of the GanttCollectionViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the GanttCollectionViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(ByVal Optional unitOfWorkFactory As IUnitOfWorkFactory(Of IDevAVDbUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, GetUnitOfWorkFactory()), Function(x) x.Tasks, Function(q) q.OrderBy(Function(t) t.StartDate))
        End Sub
    End Class
End Namespace
