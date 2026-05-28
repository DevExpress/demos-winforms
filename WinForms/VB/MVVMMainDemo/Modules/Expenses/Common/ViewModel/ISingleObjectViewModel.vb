Imports System
Imports System.ComponentModel.DataAnnotations
Imports System.Linq
Imports System.Linq.Expressions
Imports DevExpress.MVVM
Imports DevExpress.MVVM.POCO
Imports DevExpress.MVVM.DataAnnotations
Imports DevExpress.MVVM.Demos.Common.Utils
Imports DevExpress.MVVM.Demos.Common.DataModel
Namespace DevExpress.MVVM.Demos.Common.ViewModel

    ''' <summary>
    ''' The base interface for view models representing a single entity.
    ''' </summary>
    ''' <typeparam name="TEntity">An entity type.</typeparam>
    ''' <typeparam name="TPrimaryKey">An entity primary key type.</typeparam>
    Public Interface ISingleObjectViewModel(Of TEntity, TPrimaryKey)
        ''' <summary>
        ''' The entity represented by a view model.
        ''' </summary>
        ReadOnly Property Entity As TEntity
        ''' <summary>
        ''' The entity primary key value.
        ''' </summary>
        ReadOnly Property PrimaryKey As TPrimaryKey
    End Interface
End Namespace
