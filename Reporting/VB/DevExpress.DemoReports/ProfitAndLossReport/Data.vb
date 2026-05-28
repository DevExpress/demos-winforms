Imports System
Imports System.Collections.Generic
Imports XtraReportsDemos.CachedDocumentSourceReport

Namespace XtraReportsDemos.ProfitAndLossReport

    Public Class Data

        Private Shared currentData As List(Of Data)

        Public Property Month As Date

        Public Property ConstructionIncome As Decimal

        Public Property SalesIncome As Decimal

        Public Property CostOfGoodsSold As Decimal

        Public Property JobExpenses As Decimal

        Public Property Automobile As Decimal

        Public Property BankServiceCharges As Decimal

        Public Property Insurance As Decimal

        Public Property PayrollExpenses As Decimal

        Public Property Repairs As Decimal

        Public Property ToolsAndMachinery As Decimal

        Public Shared Function GetData() As List(Of Data)
            If currentData Is Nothing Then currentData = CreateData()
            Return currentData
        End Function

        Private Shared Function CreateData() As List(Of Data)
            Dim result As List(Of Data) = New List(Of Data)()
            For i As Integer = 1 To 12
                result.Add(CreateItem(2018, i))
            Next

            Return result
        End Function

        Private Shared Function CreateItem(ByVal year As Integer, ByVal month As Integer) As Data
            Dim rnd As DeterministicRandom = New DeterministicRandom(month)
            Return New Data() With {.Month = New DateTime(year, month, Date.DaysInMonth(year, month)), .ConstructionIncome = rnd.Random(75000, 125000) + CDec(rnd.Random(100)) / 100, .SalesIncome = rnd.Random(0, 1000), .CostOfGoodsSold = rnd.Random(0, 3500) + CDec(rnd.Random(100)) / 100, .JobExpenses = rnd.Random(5000, 35000) + CDec(rnd.Random(100)) / 100, .Automobile = rnd.Random(300, 900) + CDec(rnd.Random(100)) / 100, .BankServiceCharges = rnd.Random(10, 80), .Insurance = rnd.Random(1000, 5000), .PayrollExpenses = rnd.Random(9000, 18000), .Repairs = rnd.Random(0, 400), .ToolsAndMachinery = rnd.Random(0, 1000)}
        End Function
    End Class
End Namespace
