Imports System.Drawing
Imports DevExpress.Data.Filtering
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Filtering

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class DataFilteringDemo
        Inherits ChartDemoModule

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return chart
            End Get
        End Property

        Private ReadOnly images As ImageCollection = New ImageCollection()

        Public Sub New()
            InitializeComponent()
            images.ImageSize = ScaleUtils.ScaleValue(New Size(12, 12))
            chart.DataSource = DevAV.GetBranchesSalesList()
            Dim lastYear As Integer = DevAV.GetLastYear()
            CType(chart.SeriesTemplate.DataAdapter, SeriesTemplateAdapter).FilterCriteria = New GroupOperator(New BinaryOperator("Year", lastYear - 2, BinaryOperatorType.GreaterOrEqual), New BinaryOperator("Year", lastYear, BinaryOperatorType.LessOrEqual))
            Call DevAV.InitializeCompanyImages(images, New System.Func(Of String, Color)(AddressOf GetColorByCompanyName))
            filteringUIContext.RetrieveFields()
        End Sub

        Protected Overrides Sub OnPaletteChanged()
            Call DevAV.UpdateCompanyImages(images, New System.Func(Of String, Color)(AddressOf GetColorByCompanyName))
            filteringUIContext.UpdateMemberBindings()
        End Sub

        Private Function GetColorByCompanyName(ByVal name As String) As Color
            Dim seriesColorizer As SeriesKeyColorColorizer = TryCast(chart.SeriesTemplate.SeriesColorizer, SeriesKeyColorColorizer)
            If seriesColorizer Is Nothing Then Return Color.Empty
            Dim palette As Palette = chart.PaletteRepository(chart.PaletteName)
            Return seriesColorizer.GetSeriesColor(name, palette)
        End Function

        ' Filtering UI Customization
        Private Sub filteringUIContext_QueryLookupData(ByVal sender As Object, ByVal e As Filtering.QueryLookupDataEventArgs)
            If Equals(e.PropertyPath, "Company") Then e.WithDataItems(New System.Action(Of DataItemsExtension.DataItems)(AddressOf PrepareHtmlText))
        End Sub

        Private Sub PrepareHtmlText(ByVal dataItems As DataItemsExtension.DataItems)
            For Each item As ExcelFilterDataItem In dataItems
                Dim companyName As String = CStr(item.Value)
                item.HtmlText = "<image=" & companyName & "><nbsp>" & item.Text
            Next

            dataItems.HtmlImages = images
        End Sub
    End Class
End Namespace
