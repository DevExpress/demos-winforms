Imports System
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports DevExpress.MVVM.Demos.Common.Utils
Imports DevExpress.MVVM.Demos.ExpensesDbContextDataModel
Imports DevExpress.MVVM.Demos.Common.DataModel
Imports DevExpress.MVVM.Demos.Model
Imports DevExpress.MVVM.Demos.DataBase
Imports DevExpress.MVVM.Demos.Common.ViewModel

Namespace DevExpress.MVVM.Demos.ViewModels
    ''' <summary>
    ''' Represents the single Transaction object view model.
    ''' </summary>
    Partial Public Class TransactionViewModel
        Inherits SingleObjectViewModel(Of Transaction, Long, IExpensesDbContextUnitOfWork)
        ''' <summary>
        ''' Creates a new instance of TransactionViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IExpensesDbContextUnitOfWork) = Nothing) As TransactionViewModel
            Return ViewModelSource.Create(Function() New TransactionViewModel(unitOfWorkFactory))
        End Function
        ''' <summary>
        ''' Initializes a new instance of the TransactionViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the TransactionViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IExpensesDbContextUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.Transactions, Function(x) x.Comment)
        End Sub
        ''' <summary>
        ''' The view model that contains a look-up collection of Accounts for the corresponding navigation property in the view.
        ''' </summary>
        Public ReadOnly Property LookUpAccounts As IEntitiesViewModel(Of Account)
            Get
                Return GetLookUpEntitiesViewModel(Function(x As TransactionViewModel) x.LookUpAccounts, Function(x) x.Accounts)
            End Get
        End Property
        ''' <summary>
        ''' The view model that contains a look-up collection of Categories for the corresponding navigation property in the view.
        ''' </summary>
        Public ReadOnly Property LookUpCategories As IEntitiesViewModel(Of Category)
            Get
                Return GetLookUpEntitiesViewModel(Function(x As TransactionViewModel) x.LookUpCategories, Function(x) x.Categories)
            End Get
        End Property
    End Class
End Namespace
