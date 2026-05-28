Imports DevExpress.MVVM.Demos.Common.ViewModel
Imports DevExpress.MVVM.Demos.ExpensesDbContextDataModel
Imports DevExpress.MVVM.Demos.Model

Namespace DevExpress.MVVM.Demos.ViewModels
	Partial Public Class CategoryViewModel
		'The bindable property that returns all transactions of the current category
		Public ReadOnly Property CategoryTransactionDetails() As CollectionViewModel(Of Transaction, Long, IExpensesDbContextUnitOfWork)
			Get
				Return GetDetailsCollectionViewModel(Function(x As CategoryViewModel) x.CategoryTransactionDetails, Function(x) x.Transactions, Function(x) x.CategoryID, Sub(x, key) x.CategoryID = key)
			End Get
		End Property
	End Class
End Namespace
