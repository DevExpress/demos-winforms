Imports DevExpress.DXperience.Demos
Imports System

Namespace DevExpress.ApplicationUI.Demos

    Public Partial Class StockData

        Public Property ClosePrice As Decimal

        Public Property [Date] As Date

        Public Property HighPrice As Decimal

        Public Property LowPrice As Decimal

        Public Property OpenPrice As Decimal

        Public Property Volumne As Integer
    End Class

    Public Module StockDataCreator

        Const BeginDate As Integer = 40000

        Public Function GetData(ByVal index As Integer) As StockData
            Dim delta As Integer = TutorialConstants.Random.Next(-5, 5)
            Dim data As StockData = New StockData()
            data.Date = Date.FromOADate(BeginDate + index)
            data.HighPrice = TutorialConstants.Random.Next(20 + delta, 30 + delta) + CDec(Math.Round(TutorialConstants.Random.NextDouble(), 2))
            data.LowPrice = TutorialConstants.Random.Next(10 + delta, 18 + delta) + CDec(Math.Round(TutorialConstants.Random.NextDouble(), 2))
            data.OpenPrice = TutorialConstants.Random.Next(20 + delta, 25 + delta) + CDec(Math.Round(TutorialConstants.Random.NextDouble(), 2))
            data.ClosePrice = TutorialConstants.Random.Next(15 + delta, 20 + delta) + CDec(Math.Round(TutorialConstants.Random.NextDouble(), 2))
            data.Volumne = TutorialConstants.Random.Next(10000, 18000)
            Return data
        End Function
    End Module
End Namespace
