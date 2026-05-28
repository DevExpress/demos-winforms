Imports System.Collections.Generic

Namespace XtraReportsDemos.CarryoverSummaryReport

    Public Class Transaction

        Public Property Name As String

        Public Property MinAmount As Integer

        Public Property MaxAmount As Integer

        Public Shared Function GetTransactions() As List(Of Transaction)
            Dim transactions As List(Of Transaction) = New List(Of Transaction)()
            transactions.Add(New Transaction() With {.Name = "Bill – Meals & Entertainment", .MinAmount = 50, .MaxAmount = 150})
            transactions.Add(New Transaction() With {.Name = "Bill – Office Supplies", .MinAmount = 50, .MaxAmount = 100})
            transactions.Add(New Transaction() With {.Name = "Bill – Office Cleaning", .MinAmount = 50, .MaxAmount = 100})
            transactions.Add(New Transaction() With {.Name = "Bill – Meals & Entertainment", .MinAmount = 50, .MaxAmount = 150})
            transactions.Add(New Transaction() With {.Name = "Bill – Mobile Phone", .MinAmount = 75, .MaxAmount = 100})
            transactions.Add(New Transaction() With {.Name = "Bill – Lodging", .MinAmount = 500, .MaxAmount = 1000})
            transactions.Add(New Transaction() With {.Name = "Payment", .MinAmount = -1500, .MaxAmount = -300})
            transactions.Add(New Transaction() With {.Name = "Bill – Printing Services", .MinAmount = 50, .MaxAmount = 150})
            transactions.Add(New Transaction() With {.Name = "Bill – Meals & Entertainment", .MinAmount = 50, .MaxAmount = 150})
            transactions.Add(New Transaction() With {.Name = "Bill – Office Phone", .MinAmount = 50, .MaxAmount = 75})
            transactions.Add(New Transaction() With {.Name = "Payment", .MinAmount = -1500, .MaxAmount = -300})
            transactions.Add(New Transaction() With {.Name = "Bill – Car Rental", .MinAmount = 100, .MaxAmount = 500})
            transactions.Add(New Transaction() With {.Name = "Bill – Meals & Entertainment", .MinAmount = 50, .MaxAmount = 150})
            transactions.Add(New Transaction() With {.Name = "Bill – Meals & Entertainment", .MinAmount = 50, .MaxAmount = 150})
            transactions.Add(New Transaction() With {.Name = "Bill – Air Travel", .MinAmount = 500, .MaxAmount = 1000})
            transactions.Add(New Transaction() With {.Name = "Bill – Print Advertising", .MinAmount = 1000, .MaxAmount = 2500})
            transactions.Add(New Transaction() With {.Name = "Bill – Meals & Entertainment", .MinAmount = 50, .MaxAmount = 150})
            transactions.Add(New Transaction() With {.Name = "Bill – Google AdWords", .MinAmount = 500, .MaxAmount = 1000})
            transactions.Add(New Transaction() With {.Name = "Bill – Internet Service", .MinAmount = 50, .MaxAmount = 100})
            transactions.Add(New Transaction() With {.Name = "Bill – Meals & Entertainment", .MinAmount = 50, .MaxAmount = 150})
            transactions.Add(New Transaction() With {.Name = "Bill – Meals & Entertainment", .MinAmount = 50, .MaxAmount = 150})
            transactions.Add(New Transaction() With {.Name = "Bill – Printing Services", .MinAmount = 50, .MaxAmount = 150})
            transactions.Add(New Transaction() With {.Name = "Bill – Car Lease", .MinAmount = 250, .MaxAmount = 500})
            transactions.Add(New Transaction() With {.Name = "Payment", .MinAmount = -1500, .MaxAmount = -300})
            transactions.Add(New Transaction() With {.Name = "Bill – Office Supplies", .MinAmount = 50, .MaxAmount = 100})
            transactions.Add(New Transaction() With {.Name = "Payment", .MinAmount = -1500, .MaxAmount = -300})
            transactions.Add(New Transaction() With {.Name = "Bill – Meals & Entertainment", .MinAmount = 50, .MaxAmount = 150})
            transactions.Add(New Transaction() With {.Name = "Bill – Air Travel", .MinAmount = 500, .MaxAmount = 1000})
            transactions.Add(New Transaction() With {.Name = "Payment", .MinAmount = -1500, .MaxAmount = -300})
            transactions.Add(New Transaction() With {.Name = "Bill – Meals & Entertainment", .MinAmount = 50, .MaxAmount = 150})
            transactions.Add(New Transaction() With {.Name = "Payment", .MinAmount = -1500, .MaxAmount = -300})
            transactions.Add(New Transaction() With {.Name = "Bill – Meals & Entertainment", .MinAmount = 50, .MaxAmount = 150})
            transactions.Add(New Transaction() With {.Name = "Bill – Meals & Entertainment", .MinAmount = 50, .MaxAmount = 150})
            transactions.Add(New Transaction() With {.Name = "Bill – Printing Services", .MinAmount = 50, .MaxAmount = 150})
            transactions.Add(New Transaction() With {.Name = "Bill – Liability Insurance", .MinAmount = 25, .MaxAmount = 75})
            transactions.Add(New Transaction() With {.Name = "Payment", .MinAmount = -1500, .MaxAmount = -300})
            transactions.Add(New Transaction() With {.Name = "Bill – Air Travel", .MinAmount = 500, .MaxAmount = 1000})
            transactions.Add(New Transaction() With {.Name = "Bill – Meals & Entertainment", .MinAmount = 50, .MaxAmount = 150})
            transactions.Add(New Transaction() With {.Name = "Bill – Office Cleaning", .MinAmount = 50, .MaxAmount = 100})
            transactions.Add(New Transaction() With {.Name = "Bill – Meals & Entertainment", .MinAmount = 50, .MaxAmount = 150})
            transactions.Add(New Transaction() With {.Name = "Bill – Google AdWords", .MinAmount = 500, .MaxAmount = 1000})
            transactions.Add(New Transaction() With {.Name = "Bill – E&O Insurance", .MinAmount = 25, .MaxAmount = 50})
            transactions.Add(New Transaction() With {.Name = "Bill – Meals & Entertainment", .MinAmount = 50, .MaxAmount = 150})
            transactions.Add(New Transaction() With {.Name = "Payment", .MinAmount = -1500, .MaxAmount = -300})
            transactions.Add(New Transaction() With {.Name = "Bill – Office Supplies", .MinAmount = 50, .MaxAmount = 100})
            transactions.Add(New Transaction() With {.Name = "Bill – Meals & Entertainment", .MinAmount = 50, .MaxAmount = 150})
            transactions.Add(New Transaction() With {.Name = "Bill – Air Travel", .MinAmount = 500, .MaxAmount = 1000})
            transactions.Add(New Transaction() With {.Name = "Bill – Meals & Entertainment", .MinAmount = 50, .MaxAmount = 150})
            transactions.Add(New Transaction() With {.Name = "Bill – Office Cleaning", .MinAmount = 50, .MaxAmount = 100})
            transactions.Add(New Transaction() With {.Name = "Bill – Printing Services", .MinAmount = 50, .MaxAmount = 150})
            Return transactions
        End Function
    End Class
End Namespace
