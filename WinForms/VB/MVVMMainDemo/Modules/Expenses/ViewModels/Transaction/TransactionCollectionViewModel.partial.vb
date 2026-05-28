Option Infer On

Imports DevExpress.MVVM.Demos.Model
Imports DevExpress.Mvvm
Imports System

Namespace DevExpress.MVVM.Demos.ViewModels

	Partial Public Class TransactionCollectionViewModel
		Private Shared Sub NewEntityInitializer(ByVal t As Transaction)
			t.CategoryID = 1
			t.AccountID = 1
			t.Date = Date.Now
		End Sub
		Protected Overrides Sub OnEntityDeleted(ByVal primaryKey As Long, ByVal entity As Transaction)
			MyBase.OnEntityDeleted(primaryKey, entity)
			Dim category = CreateUnitOfWork().Categories.Find(entity.CategoryID)
			Messenger.Default.Send(Of AmountMessage)(New AmountDecreasedMessage(entity, category))
		End Sub
	End Class
End Namespace
