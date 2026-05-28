Imports System.Collections.Generic
Imports System.ComponentModel
Imports XtraReportsDemos.CachedDocumentSourceReport

Namespace XtraReportsDemos.CarryoverSummaryReport

    Public Class DataItem

        Public Property CustomerID As String

        Public Property ContactName As String

        Public Property ContactTitle As String

        Public Property BillingDate As Date

        Public Property BillingPeriodStart As Date

        Public Property BillingPeriodEnd As Date

        Public Property Adjustments As Adjustment()

        Public Sub New(ByVal i As Integer)
            Dim rnd As DeterministicRandom = New DeterministicRandom(i)
            Dim c As Customer = rnd.GetRandomItem(Customer.Customers)
            CustomerID = c.CustomerID
            ContactName = c.ContactName
            ContactTitle = c.ContactTitle
            BillingPeriodStart = rnd.RandomTime()
            BillingPeriodEnd = rnd.RandomTime(BillingPeriodStart, 20 * 24, 30 * 24)
            BillingDate = rnd.RandomTime(BillingPeriodEnd, 20 * 24, 30 * 24)
            Dim adjustmentsCount As Integer = rnd.Random(40, 50)
            Adjustments = New Adjustment(adjustmentsCount - 1) {}
            Dim h As Integer = CInt((BillingPeriodEnd - BillingPeriodStart).TotalHours / adjustmentsCount)
            Adjustments(0) = Adjustment.CreateBalanceForward(rnd.RandomTime(BillingPeriodStart, 0, h), rnd.Random(10000))
            Dim transactions As List(Of Transaction) = Transaction.GetTransactions()
            For j As Integer = 1 To Adjustments.Length - 1
                Dim nextDate As Date = rnd.RandomTime(BillingPeriodStart.AddHours(h * j), 0, h)
                Adjustments(j) = Adjustment.CreateAdjustment(nextDate, transactions(j - 1), rnd.Random(10000))
            Next
        End Sub
    End Class

    <DisplayName("Carryover Summary Report Data Source")>
    Public Class DataSource

        Public Shared Function GetData() As List(Of DataItem)
            Return New List(Of DataItem)() From {New DataItem(0)}
        End Function
    End Class
End Namespace
