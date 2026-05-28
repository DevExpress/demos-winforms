Option Infer On

Imports DevExpress.MVVM.Demos.Model

Namespace DevExpress.MVVM.Demos.ViewModels

	Friend Class AmountMessage
		Public Sub New(ByVal t As Transaction)
			ID = t.AccountID
		End Sub
		Public Property ID() As Long
        Private privateChange As Decimal
		Public Property Change() As Decimal
			Get
				Return privateChange
			End Get
			Protected Set(ByVal value As Decimal)
				privateChange = value
			End Set
		End Property
	End Class
	Friend Class AmountChangedMessage
		Inherits AmountMessage

		Public Sub New(ByVal t As Transaction, ByVal category As Category, ByVal prevAmount As Decimal)
			MyBase.New(t)
            Dim sign As Decimal = If(category Is Nothing Or category.Type = TransactionType.Expense, 1, -1)
			Change = sign * (prevAmount - t.Amount)
		End Sub
	End Class
	Friend Class AmountIncreasedMessage
		Inherits AmountMessage

		Public Sub New(ByVal t As Transaction, ByVal category As Category)
			MyBase.New(t)
            Dim sign As Decimal = If(category Is Nothing Or category.Type = TransactionType.Expense, -1, 1)
			Change = t.Amount * sign
		End Sub
	End Class
	Friend Class AmountDecreasedMessage
		Inherits AmountMessage

		Public Sub New(ByVal t As Transaction, ByVal category As Category)
			MyBase.New(t)
            Dim sign As Decimal = If(category Is Nothing Or category.Type = TransactionType.Expense, 1, -1)
			Change = t.Amount * sign
		End Sub
	End Class
End Namespace
