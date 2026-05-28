Imports DevExpress.Mvvm.POCO
Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.Mvvm.DataModel
Imports DevExpress.DevAV.Common.ViewModel
Imports DevExpress.Mvvm.ViewModel

Namespace DevExpress.DevAV.ViewModels

    ''' <summary>
    ''' Represents the single Gant object view model.
    ''' </summary>
    Public Partial Class TaskViewModel
        Inherits SingleObjectViewModel(Of EmployeeTask, Long, IDevAVDbUnitOfWork)

        ''' <summary>
        ''' Creates a new instance of GantViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(ByVal Optional unitOfWorkFactory As IUnitOfWorkFactory(Of IDevAVDbUnitOfWork) = Nothing) As TaskViewModel
            Return ViewModelSource.Create(Function() New TaskViewModel(unitOfWorkFactory))
        End Function

        ''' <summary>
        ''' Initializes a new instance of the GantViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the GantViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(ByVal Optional unitOfWorkFactory As IUnitOfWorkFactory(Of IDevAVDbUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, GetUnitOfWorkFactory()), Function(x) x.Tasks, Function(x) x.Id)
        End Sub

        Public ReadOnly Property LookUpEmployees As IEntitiesViewModel(Of Employee)
            Get
                Return GetLookUpEntitiesViewModel(Function(ByVal x As TaskViewModel) x.LookUpEmployees, Function(x) x.Employees)
            End Get
        End Property
    End Class
End Namespace
