Imports DevExpress.DevAV.Common.ViewModel
Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.Mvvm.DataModel
Imports DevExpress.Mvvm.POCO
Imports DevExpress.Mvvm.ViewModel

Namespace DevExpress.DevAV.ViewModels

    ''' <summary>
    ''' Represents the single Employee object view model.
    ''' </summary>
    Public Partial Class EmployeeViewModel
        Inherits SingleObjectViewModel(Of Employee, Long, IDevAVDbUnitOfWork)

        ''' <summary>
        ''' Creates a new instance of EmployeeViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(ByVal Optional unitOfWorkFactory As IUnitOfWorkFactory(Of IDevAVDbUnitOfWork) = Nothing) As EmployeeViewModel
            Return ViewModelSource.Create(Function() New EmployeeViewModel(unitOfWorkFactory))
        End Function

        ''' <summary>
        ''' Initializes a new instance of the EmployeeViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the EmployeeViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(ByVal Optional unitOfWorkFactory As IUnitOfWorkFactory(Of IDevAVDbUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, GetUnitOfWorkFactory()), Function(x) x.Employees, Function(x) x.FullName)
        End Sub

        ''' <summary>
        ''' The view model that contains a look-up collection of Pictures for the corresponding navigation property in the view.
        ''' </summary>
        Public ReadOnly Property LookUpPictures As IEntitiesViewModel(Of Picture)
            Get
                Return GetLookUpEntitiesViewModel(propertyExpression:=Function(ByVal x As EmployeeViewModel) x.LookUpPictures, getRepositoryFunc:=Function(x) x.Pictures)
            End Get
        End Property

        ''' <summary>
        ''' The view model that contains a look-up collection of Probations for the corresponding navigation property in the view.
        ''' </summary>
        Public ReadOnly Property LookUpProbations As IEntitiesViewModel(Of Probation)
            Get
                Return GetLookUpEntitiesViewModel(Function(ByVal x As EmployeeViewModel) x.LookUpProbations, Function(x) x.Probations)
            End Get
        End Property

        ''' <summary>
        ''' The view model for the EmployeeOwnedTasks detail collection.
        ''' </summary>
        Public ReadOnly Property EmployeeOwnedTasksDetails As CollectionViewModelBase(Of EmployeeTask, EmployeeTask, Long, IDevAVDbUnitOfWork)
            Get
                Return GetDetailsCollectionViewModel(propertyExpression:=Function(ByVal x As EmployeeViewModel) x.EmployeeOwnedTasksDetails, getRepositoryFunc:=Function(x) x.Tasks, foreignKeyExpression:=Function(x) x.OwnerId, navigationExpression:=Function(x) x.Owner)
            End Get
        End Property

        ''' <summary>
        ''' The view model for the EmployeeEvaluations detail collection.
        ''' </summary>
        Public ReadOnly Property EmployeeEvaluationsDetails As CollectionViewModelBase(Of Evaluation, Evaluation, Long, IDevAVDbUnitOfWork)
            Get
                Return GetDetailsCollectionViewModel(propertyExpression:=Function(ByVal x As EmployeeViewModel) x.EmployeeEvaluationsDetails, getRepositoryFunc:=Function(x) x.Evaluations, foreignKeyExpression:=Function(x) x.EmployeeId, navigationExpression:=Function(x) x.Employee)
            End Get
        End Property
    End Class
End Namespace
