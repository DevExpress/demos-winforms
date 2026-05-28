Imports System
Imports System.Drawing
Imports DevExpress.Data.Filtering
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class WaterfallDemo
        Inherits ChartDemoModuleWithOptions

        Private ReadOnly Property WaterfallView As WaterfallSeriesView
            Get
                Return TryCast(chart.SeriesTemplate.View, WaterfallSeriesView)
            End Get
        End Property

        Friend Overrides ReadOnly Property PaletteButtonEnabled As Boolean
            Get
                Return False
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            SetupCalculatedFields()
            ChartControl.DataSource = ReadCarbonData("carbon.csv")
            radioGroupDataView.SelectedIndex = 0
        End Sub

        Private Sub SetupCalculatedFields()
            ChartControl.CalculatedFields.Add(New ChartCalculatedField() With {.DisplayName = "Calculated Contribution", .Expression = "IIF([Factor] == 'Fuel/Industry' Or [Factor] == 'Land-Use Emissions' Or [Factor] == 'Imbalance', [Contribution], -1 * [Contribution])", .FieldType = ChartCalculatedFieldType.Double, .Name = "CalculatedContribution"})
        End Sub

        Private Sub SetupSeries(ByVal binaryOperatorType As BinaryOperatorType, ByVal legendVisibility As DefaultBoolean, ByVal risingColor As Color, ByVal fallingColor As Color)
            CType(ChartControl.SeriesTemplate.DataAdapter, SeriesTemplateAdapter).FilterCriteria = New BinaryOperator("Factor", "Imbalance", binaryOperatorType)
            If WaterfallView IsNot Nothing Then
                WaterfallView.RisingBarColor = risingColor
                WaterfallView.FallingBarColor = fallingColor
            End If

            ChartControl.Legend.Visibility = legendVisibility
        End Sub

        Private Sub RadioGroupTemperatureUnit_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If radioGroupDataView.SelectedIndex = 0 Then
                SetupSeries(BinaryOperatorType.Equal, DefaultBoolean.False, Color.FromArgb(218, 88, 89), Color.FromArgb(146, 206, 181))
            Else
                SetupSeries(BinaryOperatorType.NotEqual, DefaultBoolean.True, Color.Empty, Color.Empty)
            End If
        End Sub
    End Class
End Namespace
