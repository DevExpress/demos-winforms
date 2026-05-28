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
Imports DevExpress.MVVM
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.Data.Linq
Imports DevExpress.Data.Linq.Helpers
Imports DevExpress.Data.Async.Helpers
Namespace DevExpress.MVVM.Demos.ExpensesDbContextDataModel
    ''' <summary>
    ''' Provides methods to obtain the relevant IUnitOfWorkFactory.
    ''' </summary>
    Public Module UnitOfWorkSource
        ''' <summary>
        ''' Returns the IUnitOfWorkFactory implementation.
        ''' </summary>
        Public Function GetUnitOfWorkFactory() As IUnitOfWorkFactory(Of IExpensesDbContextUnitOfWork)
            Return New DbUnitOfWorkFactory(Of IExpensesDbContextUnitOfWork)(Function() New ExpensesDbContextUnitOfWork(Function() New ExpensesDbContext()))
        End Function
    End Module
End Namespace
