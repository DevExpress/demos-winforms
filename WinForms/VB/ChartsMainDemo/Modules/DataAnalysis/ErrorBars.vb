Imports System
Imports System.Drawing
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class ErrorBarsDemo
        Inherits ChartDemoModuleWithOptions

        Private ReadOnly indicatorColor As Color = Color.Black

        Private ReadOnly Property Series As Series
            Get
                If ChartControl.Series.Count = 0 Then Return Nothing
                Return ChartControl.Series(0)
            End Get
        End Property

        Private ReadOnly Property SeriesView As XYDiagram2DSeriesViewBase
            Get
                If Series Is Nothing Then Return Nothing
                Dim lSeriesView As XYDiagram2DSeriesViewBase = TryCast(Series.View, XYDiagram2DSeriesViewBase)
                Return If(lSeriesView IsNot Nothing, lSeriesView, Nothing)
            End Get
        End Property

        Private ReadOnly Property ErrorBars As ErrorBars
            Get
                If SeriesView Is Nothing OrElse SeriesView.Indicators.Count = 0 Then Return Nothing
                Dim lErrorBars As ErrorBars = TryCast(SeriesView.Indicators(0), ErrorBars)
                Return If(lErrorBars IsNot Nothing, lErrorBars, Nothing)
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            FillErrorBarsKindRadioGroup()
            ChartControl.BeginInit()
            FillDataSet()
            ChartControl.EndInit()
        End Sub

        Private Sub FillErrorBarsKindRadioGroup()
            Dim fixedValuesErrorBars As FixedValueErrorBars = New FixedValueErrorBars() With {.NegativeError = 1, .PositiveError = 3, .Color = indicatorColor, .Animation = CreateAnimation()}
            Dim percentageErrorBars As PercentageErrorBars = New PercentageErrorBars() With {.Percent = 10, .Color = indicatorColor, .Animation = CreateAnimation()}
            Dim stdevErrorBars As StandardDeviationErrorBars = New StandardDeviationErrorBars() With {.Multiplier = 1, .Color = indicatorColor, .Animation = CreateAnimation()}
            Dim stdErrErrorBars As StandardErrorBars = New StandardErrorBars() With {.Color = indicatorColor, .Animation = CreateAnimation()}
            Dim dataSourceErrorBars As DataSourceBasedErrorBars = New DataSourceBasedErrorBars() With {.NegativeErrorDataMember = "Table1.NegativeError", .PositiveErrorDataMember = "Table1.PositiveError", .Color = indicatorColor, .Animation = CreateAnimation()}
            radioGroupErrorBarsKind.Properties.Items.Add(New RadioGroupItem(fixedValuesErrorBars, "Fixed Values"))
            radioGroupErrorBarsKind.Properties.Items.Add(New RadioGroupItem(percentageErrorBars, "Percentage"))
            radioGroupErrorBarsKind.Properties.Items.Add(New RadioGroupItem(stdevErrorBars, "Standard Deviation(s)"))
            radioGroupErrorBarsKind.Properties.Items.Add(New RadioGroupItem(stdErrErrorBars, "Standard Error"))
            radioGroupErrorBarsKind.Properties.Items.Add(New RadioGroupItem(dataSourceErrorBars, "Data Source"))
            radioGroupErrorBarsKind.SelectedIndex = 0
        End Sub

        Private Sub FillDataSet()
            Dim table As System.Data.DataTable = dataSet.Tables(0)
            table.Rows.Add("A", 20, 5, 8)
            table.Rows.Add("B", 50, 3, 5)
            table.Rows.Add("C", 40, 20, 10)
            table.Rows.Add("D", 22, 15, 5)
            table.Rows.Add("E", 30, 5, 8)
            table.Rows.Add("F", 45, 5, 4)
            table.Rows.Add("G", 35, 5, 3)
            table.Rows.Add("H", 28, 4, 2)
            table.Rows.Add("I", 46, 6, 4)
            table.Rows.Add("J", 27, 8, 20)
            table.Rows.Add("K", 20, 5, 8)
            table.Rows.Add("L", 50, 3, 5)
            table.Rows.Add("M", 40, 20, 10)
            table.Rows.Add("N", 22, 15, 5)
            table.Rows.Add("O", 30, 5, 8)
            table.Rows.Add("P", 45, 5, 2)
            table.Rows.Add("Q", 35, 5, 5)
            table.Rows.Add("R", 28, 4, 4)
            table.Rows.Add("S", 46, 6, 5)
            table.Rows.Add("T", 27, 8, 8)
        End Sub

        Private Sub SetDirection()
            If ErrorBars Is Nothing Then Return
            ErrorBars.Direction = CType(radioGroupDirection.EditValue, ErrorBarDirection)
        End Sub

        Private Sub SetEndStyle()
            If ErrorBars Is Nothing Then Return
            ErrorBars.EndStyle = CType(radioGroupEndStyle.EditValue, ErrorBarEndStyle)
        End Sub

        Private Function CreateAnimation() As IndicatorSlideAnimation
            Return New IndicatorSlideAnimation() With {.Duration = New TimeSpan(0, 0, 2), .Direction = AnimationDirection.FromBottom, .EasingFunction = New ElasticEasingFunction() With {.OscillationCount = 1, .EasingMode = EasingMode.InOut}}
        End Function

        Private Sub radioGroupSeriesView_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Series Is Nothing Then Return
            ChartControl.BeginInit()
            Series.ChangeView(CType(radioGroupSeriesView.EditValue, ViewType))
            ChartControl.EndInit()
            ChartControl.Animate()
        End Sub

        Private Sub radioGroupErrorBarsKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If SeriesView Is Nothing Then Return
            SeriesView.Indicators.Clear()
            SeriesView.Indicators.Add(CType(radioGroupErrorBarsKind.EditValue, Indicator))
            SetDirection()
            SetEndStyle()
        End Sub

        Private Sub radioGroupEndStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetEndStyle()
        End Sub

        Private Sub radioGroupDirection_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetDirection()
        End Sub
    End Class
End Namespace
