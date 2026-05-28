Namespace XtraReportsDemos.CachedDocumentSourceReport

    Public Class Adjustment

        Public Shared Function CreateBalanceForward(ByVal dt As Date, ByVal random As Integer) As Adjustment
            Dim rnd As DeterministicRandom = New DeterministicRandom(random)
            Dim res As Adjustment = New Adjustment()
            res.currentDateTime = dt
            res.currentDescription = "Balance Forward"
            res.currentAmount = rnd.Random(10, 300) * 10
            Return res
        End Function

        Public Shared Function CreatePayment(ByVal dt As Date, ByVal random As Integer) As Adjustment
            Dim rnd As DeterministicRandom = New DeterministicRandom(random)
            Dim res As Adjustment = New Adjustment()
            res.currentDateTime = dt
            res.currentDescription = "Payment"
            res.currentAmount = -rnd.Random(1, 40) * 10
            Return res
        End Function

        Public Shared Function CreateCharge(ByVal dt As Date, ByVal random As Integer) As Adjustment
            Dim rnd As DeterministicRandom = New DeterministicRandom(random)
            Dim res As Adjustment = New Adjustment()
            res.currentDateTime = dt
            res.currentDescription = rnd.GetRandomItem(bills)
            res.currentAmount = rnd.Random(10, 50) * 10
            Return res
        End Function

        Private currentDateTime As Date

        Private currentDescription As String = ""

        Private currentAmount As Double = 0

        Private Shared ReadOnly bills As String() = New String() {"Bill - Insurance", "Bill - Electricity", "Bill - Rent", "Bill - Phone", "Bill - Office Supplies"}

        Public ReadOnly Property [Date] As Date
            Get
                Return currentDateTime
            End Get
        End Property

        Public ReadOnly Property Description As String
            Get
                Return currentDescription
            End Get
        End Property

        Public ReadOnly Property Amount As Double
            Get
                Return currentAmount
            End Get
        End Property

        Public Sub New()
        End Sub
    End Class
End Namespace
