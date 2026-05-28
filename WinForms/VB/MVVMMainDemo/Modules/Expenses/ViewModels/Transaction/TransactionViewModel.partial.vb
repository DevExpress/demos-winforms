Option Infer On

Imports DevExpress.MVVM.Demos.Model
Imports DevExpress.Mvvm
Imports System.Linq

Namespace DevExpress.MVVM.Demos.ViewModels

	Partial Public Class TransactionViewModel
		Private prevAmount As Decimal
		Private prevAccount, prevCategory As Long
		Protected Overrides Sub OnBeforeEntitySaved(ByVal key As Long, ByVal entity As Transaction, ByVal isNewEntity As Boolean)
			MyBase.OnBeforeEntitySaved(key, entity, isNewEntity)
			If Not isNewEntity Then
				Dim t = UnitOfWorkFactory.CreateUnitOfWork().Transactions.Find(PrimaryKey)
				prevAmount = t.Amount
				prevAccount = t.AccountID
				prevCategory = t.CategoryID
			End If
		End Sub
		Protected Overrides Sub OnEntitySaved(ByVal key As Long, ByVal entity As Transaction, ByVal isNewEntity As Boolean)
			MyBase.OnEntitySaved(key, entity, isNewEntity)
            Dim category = If(entity.Category, LookUpCategories.Entities.FirstOrDefault(Function(c) c.ID = entity.CategoryID))
			If isNewEntity Then
				Messenger.Default.Send(Of AmountMessage)(New AmountIncreasedMessage(entity, category))
			Else
				If prevAccount = entity.AccountID AndAlso prevCategory = entity.CategoryID Then
					Messenger.Default.Send(Of AmountMessage)(New AmountChangedMessage(entity, category, prevAmount))
				Else
					Dim uow = UnitOfWorkFactory.CreateUnitOfWork()
					Dim oldCategory = uow.Categories.Find(prevCategory)
					Messenger.Default.Send(Of AmountMessage)(New AmountDecreasedMessage(entity, oldCategory) With {.ID = prevAccount})
					Messenger.Default.Send(Of AmountMessage)(New AmountIncreasedMessage(entity, category))
				End If
			End If
		End Sub
		Protected Overrides Sub OnEntityDeleted(ByVal primaryKey As Long, ByVal entity As Transaction)
			MyBase.OnEntityDeleted(primaryKey, entity)
            Dim category = If(entity.Category, LookUpCategories.Entities.FirstOrDefault(Function(c) c.ID = entity.CategoryID))
			Messenger.Default.Send(Of AmountMessage)(New AmountDecreasedMessage(entity, category))
		End Sub
	End Class
End Namespace
