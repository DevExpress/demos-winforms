Imports System
Imports System.Linq
Imports System.Data
Imports System.Data.Entity
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports DevExpress.MVVM.Demos.Common.Utils
Imports DevExpress.MVVM.Demos.Common.DataModel
Imports DevExpress.MVVM
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.Data.Linq
Imports DevExpress.Data.Linq.Helpers
Imports DevExpress.Data.Async.Helpers
Namespace DevExpress.MVVM.Demos.Common.DataModel.EntityFramework
    Friend Class DbUnitOfWorkFactory(Of TUnitOfWork As IUnitOfWork)
        Implements IUnitOfWorkFactory(Of TUnitOfWork)
        Private _createUnitOfWork As Func(Of TUnitOfWork)
        Public Sub New(ByVal createUnitOfWork As Func(Of TUnitOfWork))
            Me._createUnitOfWork = createUnitOfWork
        End Sub
        Private Function CreateUnitOfWork() As TUnitOfWork Implements IUnitOfWorkFactory(Of TUnitOfWork).CreateUnitOfWork
            Return _createUnitOfWork()
        End Function
        Private Function CreateInstantFeedbackSource(Of TEntity As {Class, New}, TProjection As Class, TPrimaryKey)(ByVal getRepositoryFunc As Func(Of TUnitOfWork, IRepository(Of TEntity, TPrimaryKey)), ByVal projection As Func(Of IRepositoryQuery(Of TEntity), IQueryable(Of TProjection))) As IInstantFeedbackSource(Of TProjection) Implements IUnitOfWorkFactory(Of TUnitOfWork).CreateInstantFeedbackSource
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace
