Namespace XtraReportsDemos.CachedDocumentSourceReport

    Public Class DataItem

        Private Shared ReadOnly accountType As String() = New String() {"Energy", "Manufacturing", "Estate", "Food", "Services"}

        Public Property CustomerID As String

        Public Property CompanyName As String

        Public Property ContactName As String

        Public Property ContactTitle As String

        Public Property Address As String

        Public Property City As String

        Public Property PostalCode As String

        Public Property Region As String

        Public Property Country As String

        Public Property Phone As String

        Public Property Fax As String

        Public Property Email As String

        Public Property Invoice As String

        Public Property CustomerAccount As String

        Public Property CustomerIdentifiers As String

        Public Property BillingDate As Date

        Public Property BillingPeriodStart As Date

        Public Property BillingPeriodEnd As Date

        Public Property Terms As String

        Public Property TermsID As String

        Public Property Adjustments As Adjustment()

        Public Sub New(ByVal i As Integer)
            Dim rnd As DeterministicRandom = New DeterministicRandom(i)
            Dim c As Customer = rnd.GetRandomItem(Customer.Customers)
            CustomerID = c.CustomerID
            CompanyName = c.CompanyName
            ContactName = c.ContactName
            ContactTitle = c.ContactTitle
            Address = c.Address
            City = c.City
            PostalCode = c.PostalCode
            Region = c.Region
            Country = c.Country
            Phone = c.Phone
            Fax = c.Fax
            Email = ContactName.Split(" "c)(0).Replace(" "c, "."c).ToLower() & "@" & CompanyName.Split(" "c)(0).ToLower() & ".com"
            Invoice = String.Format("{0}{1}-{2}", rnd.RandomChar, rnd.Random(100, 1000), rnd.Random(100, 1000))
            CustomerAccount = rnd.GetRandomItem(accountType)
            CustomerIdentifiers = String.Format("{0}-{1}", rnd.Random(1000, 10000), rnd.Random(10, 100))
            BillingPeriodStart = rnd.RandomTime()
            BillingPeriodEnd = rnd.RandomTime(BillingPeriodStart, 7 * 24, 30 * 24)
            BillingDate = rnd.RandomTime(BillingPeriodEnd, 7 * 24, 30 * 24)
            Dim currentTerm As Term = rnd.GetRandomItem(Term.Terms)
            Terms = currentTerm.Name
            Dim adjustmentsCount As Integer = rnd.Random(6) + 4
            Adjustments = New Adjustment(adjustmentsCount - 1) {}
            Dim h As Integer = CInt((BillingPeriodEnd - BillingPeriodStart).TotalHours / adjustmentsCount)
            Adjustments(0) = Adjustment.CreateBalanceForward(rnd.RandomTime(BillingPeriodStart, 0, h), rnd.Random(10000))
            Dim items As Integer() = rnd.RandomList(adjustmentsCount - 1, 2)
            For j As Integer = 1 To Adjustments.Length - 1
                Dim nextDate As Date = rnd.RandomTime(BillingPeriodStart.AddHours(h * j), 0, h)
                Select Case items(j - 1)
                    Case 0
                        Adjustments(j) = Adjustment.CreateCharge(nextDate, rnd.Random(10000))
                    Case 1
                        Adjustments(j) = Adjustment.CreatePayment(nextDate, rnd.Random(10000))
                End Select
            Next
        End Sub
    End Class
End Namespace
