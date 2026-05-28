Imports XtraReportsDemos.CachedDocumentSourceReport

Namespace XtraReportsDemos.CarryoverSummaryReport

    Public Class Adjustment

        Public Shared Function CreateBalanceForward(ByVal dt As Date, ByVal random As Integer) As Adjustment
            Dim rnd As DeterministicRandom = New DeterministicRandom(random)
            Dim res As Adjustment = New Adjustment()
            res.Date = dt
            res.Description = "Balance Forward"
            res.Amount = rnd.Random(10, 300) * 10
            Return res
        End Function

        Public Shared Function CreateAdjustment(ByVal dt As Date, ByVal transaction As Transaction, ByVal random As Integer) As Adjustment
            Dim rnd As DeterministicRandom = New DeterministicRandom(random)
            Dim res As Adjustment = New Adjustment()
            res.Date = dt
            res.Description = transaction.Name
            res.Amount = rnd.Random(transaction.MinAmount, transaction.MaxAmount)
            Return res
        End Function

        Public Property [Date] As Date

        Public Property Description As String

        Public Property Amount As Double

        Public Sub New()
        End Sub
    End Class
End Namespace
