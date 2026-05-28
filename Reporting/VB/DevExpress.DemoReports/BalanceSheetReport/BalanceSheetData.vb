Imports System
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace XtraReportsDemos.BalanceSheetReport

    Public Class BalanceSheetDataItem

        Private ReadOnly itemType As ItemType

        Public ReadOnly Property Type As String
            Get
                Return If(itemType = ItemType.Assets, "Assets", "Liabilities and Shareholders Equity")
            End Get
        End Property

        Public Property SubType As String

        Public Property Name As String

        Public Property Value As Double?

        Public Property [Date] As Date

        Public Sub New(ByVal [date] As Date, ByVal itemType As ItemType, ByVal subType As String, ByVal name As String, ByVal value As Double?)
            Me.itemType = itemType
            Me.SubType = subType
            Me.Date = [date]
            Me.Name = name
            Me.Value = value
        End Sub
    End Class

    Public Enum ItemType
        Assets
        Liabilities
    End Enum

    <DisplayName("Balance Sheet Report Data Source")>
    Public Class BalanceSheetData

        Public Shared Function GetData() As List(Of BalanceSheetDataItem)
            Dim random As DevExpress.Data.Utils.NonCryptographicRandom = New DevExpress.Data.Utils.NonCryptographicRandom(2147483)
            Dim items As List(Of BalanceSheetDataItem) = New List(Of BalanceSheetDataItem)()
            items.AddRange(FillItems(random))
            Return items
        End Function

        Private Shared Function FillItems(ByVal random As DevExpress.Data.Utils.NonCryptographicRandom) As IEnumerable(Of BalanceSheetDataItem)
            Dim items As List(Of BalanceSheetDataItem) = New List(Of BalanceSheetDataItem)()
            Dim currentYear As Integer = Date.Today.Year
            For i As Integer = 0 To 3 - 1
                Dim year As Integer = currentYear - i
                For month As Integer = 1 To 12
                    AddItem(items, year, month, ItemType.Assets, "Current assets", "Cash and cash equivalents", GetRandomValue(random, 300, 2350))
                    AddItem(items, year, month, ItemType.Assets, "Current assets", "Marketable securities", GetRandomValue(random, 200, 3200))
                    AddItem(items, year, month, ItemType.Assets, "Current assets", "Accounts receivable trade, less allowances for doubtful accounts", GetRandomValue(random, 200, 1600))
                    AddItem(items, year, month, ItemType.Assets, "Current assets", "Inventories", GetRandomValue(random, 0, 1200))
                    AddItem(items, year, month, ItemType.Assets, "Long-term assets", "Property, plant and equipment, net", GetRandomValue(random, 600, 1950))
                    AddItem(items, year, month, ItemType.Assets, "Long-term assets", "Intangible assets, net", GetRandomValue(random, 1000, 3300))
                    AddItem(items, year, month, ItemType.Assets, "Long-term assets", "Goodwill", GetRandomValue(random, 950, 2500))
                    AddItem(items, year, month, ItemType.Assets, "Long-term assets", "Equity and long-term investments", GetRandomValue(random, 0, 1000))
                    AddItem(items, year, month, ItemType.Assets, "Long-term assets", "Defered taxes on income", GetRandomValue(random, 80, 1800))
                    AddItem(items, year, month, ItemType.Assets, "Long-term assets", "Other assets", GetRandomValue(random, 60, 630))
                    AddItem(items, year, month, ItemType.Liabilities, "Current liabilities", "Loans and notes payable", GetRandomValue(random, 130, 750))
                    AddItem(items, year, month, ItemType.Liabilities, "Current liabilities", "Accounts payable", GetRandomValue(random, 280, 970))
                    AddItem(items, year, month, ItemType.Liabilities, "Current liabilities", "Accrued rebates, returns and promotions", GetRandomValue(random, 185, 733))
                    AddItem(items, year, month, ItemType.Liabilities, "Current liabilities", "Accrued taxes on income", GetRandomValue(random, 5, 750))
                    AddItem(items, year, month, ItemType.Liabilities, "Long-term liabilities", "Long-term debt", GetRandomValue(random, 650, 1800))
                    AddItem(items, year, month, ItemType.Liabilities, "Long-term liabilities", "Deferred taxes on income", GetRandomValue(random, 90, 390))
                    AddItem(items, year, month, ItemType.Liabilities, "Long-term liabilities", "Employee related obligations", GetRandomValue(random, 150, 700))
                    AddItem(items, year, month, ItemType.Liabilities, "Long-term liabilities", "Other liabilities", GetRandomValue(random, 495, 995))
                    AddItem(items, year, month, ItemType.Liabilities, "Shareholders equity", "Preferred stock - without par value", Nothing)
                    AddItem(items, year, month, ItemType.Liabilities, "Shareholders equity", "Common stock - par value $1.00 per share", GetRandomValue(random, 100, 1200))
                    AddItem(items, year, month, ItemType.Liabilities, "Shareholders equity", "Accumulated other comprehensive income", GetRandomValue(random, -950, 0))
                    AddItem(items, year, month, ItemType.Liabilities, "Shareholders equity", "Retained earnings", GetRandomValue(random, 800, 2500))
                Next
            Next

            Return items
        End Function

        Private Shared Sub AddItem(ByVal items As List(Of BalanceSheetDataItem), ByVal year As Integer, ByVal month As Integer, ByVal type As ItemType, ByVal subType As String, ByVal name As String, ByVal value As Double?)
            items.Add(New BalanceSheetDataItem(New DateTime(year, month, 1), type, subType, name, value))
        End Sub

        Private Shared Function GetRandomValue(ByVal random As DevExpress.Data.Utils.NonCryptographicRandom, ByVal min As Integer, ByVal max As Integer) As Double
            Dim intPart As Integer = random.Next(min, max)
            Dim floatPart As Double = Math.Round(random.NextDouble(), 2)
            Return intPart + floatPart
        End Function
    End Class
End Namespace
