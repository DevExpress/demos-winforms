Imports System
Imports System.Linq
Imports System.Data
Imports System.Data.Entity
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports DevExpress.MVVM.Demos.Common.Utils
Imports DevExpress.MVVM.Demos.Common.DataModel
Imports DevExpress.MVVM.Demos.Common.DataModel.EntityFramework
Imports DevExpress.MVVM.Demos.DataBase
Imports DevExpress.MVVM.Demos.Model
Namespace DevExpress.MVVM.Demos.ExpensesDbContextDataModel
    ''' <summary>
    ''' IExpensesDbContextUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    ''' </summary>
    Public Interface IExpensesDbContextUnitOfWork
        Inherits IUnitOfWork
        ''' <summary>
        ''' The Account entities repository.
        ''' </summary>
        ReadOnly Property Accounts As IRepository(Of Account, Long)
        ''' <summary>
        ''' The Category entities repository.
        ''' </summary>
        ReadOnly Property Categories As IRepository(Of Category, Long)
        ''' <summary>
        ''' The Transaction entities repository.
        ''' </summary>
        ReadOnly Property Transactions As IRepository(Of Transaction, Long)
    End Interface
End Namespace
