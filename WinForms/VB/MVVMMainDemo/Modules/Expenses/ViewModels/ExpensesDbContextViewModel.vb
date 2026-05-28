Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.ComponentModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports DevExpress.MVVM.Demos.Common.DataModel
Imports DevExpress.MVVM.Demos.Common.ViewModel
Imports DevExpress.MVVM.Demos.ExpensesDbContextDataModel
Imports DevExpress.MVVM.Demos.DataBase
Imports DevExpress.MVVM.Demos.Model

Namespace DevExpress.MVVM.Demos.ViewModels
    ''' <summary>
    ''' Represents the root POCO view model for the ExpensesDbContext data model.
    ''' </summary>
    Partial Public Class ExpensesDbContextViewModel
        Inherits DocumentsViewModel(Of ExpensesDbContextModuleDescription, IExpensesDbContextUnitOfWork)
        Private Const _TablesGroup As String = "Tables"
        Private Const _ViewsGroup As String = "Views"
        Private ReadOnly Property NavigationService As INavigationService
            Get
                Return Me.GetService(Of INavigationService)()
            End Get
        End Property
        ''' <summary>
        ''' Creates a new instance of ExpensesDbContextViewModel as a POCO view model.
        ''' </summary>
        Public Shared Function Create() As ExpensesDbContextViewModel
            Return ViewModelSource.Create(Function() New ExpensesDbContextViewModel())
        End Function
        ''' <summary>
        ''' Initializes a new instance of the ExpensesDbContextViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the ExpensesDbContextViewModel type without the POCO proxy factory.
        ''' </summary>
        Protected Sub New()
            MyBase.New(UnitOfWorkSource.GetUnitOfWorkFactory())
        End Sub
        Protected Overrides Function CreateModules() As ExpensesDbContextModuleDescription()
            Return New ExpensesDbContextModuleDescription() {New ExpensesDbContextModuleDescription("Accounts", "AccountCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(x) x.Accounts)), New ExpensesDbContextModuleDescription("Categories", "CategoryCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(x) x.Categories)), New ExpensesDbContextModuleDescription("Transactions", "TransactionCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(x) x.Transactions))}
        End Function
        Protected Overrides Sub OnActiveModuleChanged(ByVal oldModule As ExpensesDbContextModuleDescription)
            If ActiveModule IsNot Nothing AndAlso NavigationService IsNot Nothing Then
                NavigationService.ClearNavigationHistory()
            End If
            MyBase.OnActiveModuleChanged(oldModule)
        End Sub
    End Class
    Partial Public Class ExpensesDbContextModuleDescription
        Inherits ModuleDescription(Of ExpensesDbContextModuleDescription)
        Public Sub New(ByVal title As String, ByVal documentType As String, ByVal group As String, Optional ByVal peekCollectionViewModelFactory As Func(Of ExpensesDbContextModuleDescription, Object) = Nothing)
            MyBase.New(title, documentType, group, peekCollectionViewModelFactory)
        End Sub
    End Class
End Namespace
