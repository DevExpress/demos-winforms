Imports System
Imports System.Linq
Imports DevExpress.Mvvm.POCO
Imports DevExpress.MVVM.Demos.Common.Utils
Imports DevExpress.MVVM.Demos.ExpensesDbContextDataModel
Imports DevExpress.MVVM.Demos.Common.DataModel
Imports DevExpress.MVVM.Demos.Model
Imports DevExpress.MVVM.Demos.DataBase
Imports DevExpress.MVVM.Demos.Common.ViewModel

Namespace DevExpress.MVVM.Demos.ViewModels
	''' <summary>
	''' Represents the Categories collection view model.
	''' </summary>
	Partial Public Class CategoryCollectionViewModel
		Inherits CollectionViewModel(Of Category, Long, IExpensesDbContextUnitOfWork)

		''' <summary>
		''' Creates a new instance of CategoryCollectionViewModel as a POCO view model.
		''' </summary>
		''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
		Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IExpensesDbContextUnitOfWork) = Nothing) As CategoryCollectionViewModel
			Return ViewModelSource.Create(Function() New CategoryCollectionViewModel(unitOfWorkFactory))
		End Function

		''' <summary>
		''' Initializes a new instance of the CategoryCollectionViewModel class.
		''' This constructor is declared protected to avoid undesired instantiation of the CategoryCollectionViewModel type without the POCO proxy factory.
		''' </summary>
		''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
		Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IExpensesDbContextUnitOfWork) = Nothing)
			MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(x) x.Categories)
		End Sub
	End Class
End Namespace
