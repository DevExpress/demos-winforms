Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Globalization
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraCharts
Imports DevExpress.XtraLayout
Imports DevExpress.XtraGauges.Core
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraPivotGrid
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel

Namespace DevExpress.VideoRent.Win.ModulesStatistics
	Partial Public Class NetIncomeStatistics
		Inherits ChartExportTutorialControl
		Private Const CurrentPeriod As Integer = 1, ComparePeriod As Integer = 2
		Private receipts As XPCollection(Of Receipt)
		Private currentMonth As Integer
		Private currentPeriodText, comparePeriodText As String
		Private currentPeriodDate As DateTime

		Protected Friend Overrides ReadOnly Property ChartViewType() As ViewType
			Get
				Return ViewType.Line
			End Get
		End Property
		Protected Overrides ReadOnly Property MainChart() As ChartControl
			Get
				Return chart
			End Get
		End Property
		Protected Overrides ReadOnly Property MainLayoutControl() As LayoutControl
			Get
				Return layoutControl1
			End Get
		End Property
		Public Sub New()
			InitializeComponent()
            AddHandler pivotGrid.LookAndFeel.StyleChanged, AddressOf AnonymousMethod1
			AddHandler pivotGrid.FocusedCellChanged, AddressOf pivotGrid_FocusedCellChanged
		End Sub
		
		Private Sub AnonymousMethod1(ByVal sender As Object, ByVal e As System.EventArgs)
			pivotGrid.BestFit()
		End Sub
		Private Function CorrectMonth(ByVal month As Integer) As Integer
			If month > Me.currentMonth Then
				Return month - Me.currentMonth
			Else
				Return month + 12
			End If
		End Function
		Private Sub pivotGrid_FocusedCellChanged(ByVal sender As Object, ByVal e As EventArgs)
			UpdateGauge(GetGaugeValueFromPivot(), GetGaugeTextFromPivot())
		End Sub
		Private Function GetGaugeValueFromPivot() As Double
			Dim cellValue As Object = pivotGrid.GetCellValue(pivotGrid.Cells.FocusedCell.X, pivotGrid.Cells.FocusedCell.Y)
			If TypeOf cellValue Is Integer Then
				Return CDbl(CInt(Fix(cellValue)))
			End If
			If TypeOf cellValue Is Decimal Then
				Return CDbl(CDec(cellValue))
			End If
			Return 0.0
		End Function
		Private Function GetGaugeTextFromPivot() As String
			Dim fieldValue As Object = pivotGrid.GetFieldValue(fieldMonth, pivotGrid.Cells.FocusedCell.Y)
			If ((Not Object.Equals(fieldValue, Nothing))) Then
				Return fieldMonth.GetDisplayText(fieldValue)
			Else
				Return Nothing
			End If
		End Function
		Private Sub pivotGrid_CustomGroupInterval(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCustomGroupIntervalEventArgs) Handles pivotGrid.CustomGroupInterval
            If Object.Equals(e.Field, fieldPeriod) Then
                Dim valueAsDate As DateTime = CDate(e.Value)
                If valueAsDate >= Me.currentPeriodDate Then
                    e.GroupValue = CurrentPeriod
                Else
                    e.GroupValue = ComparePeriod
                End If
            End If
		End Sub
		Private Sub pivotGrid_CustomFieldSort(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotGridCustomFieldSortEventArgs) Handles pivotGrid.CustomFieldSort
            If Object.Equals(e.Field, fieldMonth) Then
                Dim value1 As Integer = CorrectMonth(CInt(Fix(e.Value1))), value2 As Integer = CorrectMonth(CInt(Fix(e.Value2)))
                e.Result = Comparer(Of Integer).Default.Compare(value1, value2)
                e.Handled = True
            End If
		End Sub
		Private Sub pivotGrid_FieldValueDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventArgs) Handles pivotGrid.FieldValueDisplayText
            If Object.Equals(e.Field, fieldMonth) AndAlso ((Not Object.Equals(e.Value, Nothing))) Then
                Dim val As Integer = CInt(Fix(e.Value))
                If val < 1 Then val = 1
                If val > 12 Then val = 12
                e.DisplayText = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(val)
            End If
            If Object.Equals(e.Field, fieldPeriod) Then
                If Object.Equals(e.Value, CurrentPeriod) Then
                    e.DisplayText = Me.currentPeriodText
                Else
                    e.DisplayText = Me.comparePeriodText
                End If
            End If
		End Sub
		Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioGroup1.SelectedIndexChanged
			UpdatefieldRevenue()
			UpdateGauge(GetGaugeValueFromPivot(), GetGaugeTextFromPivot())
		End Sub
		Private Sub UpdateGauge(ByVal value As Double, ByVal text As String)
			Dim values() As Double = New Double() {}
			If chart.Series.Count <> 0 Then
				values = GetValues(chart.Series(0))
			End If
			Dim min As Double = 2500
			Dim max As Double = 4500
			Dim avg As Double = 3000
			If values.Length > 0 Then
				Dim sum As Double = 0
				min = values(0)
				max = values(0)
				For i As Integer = 0 To values.Length - 1
					min = Math.Min(min, values(i))
					max = Math.Max(max, values(i))
					sum += values(i)
				Next i
				avg = sum / CDbl(values.Length)
			End If
			Dim overhead As Single
			If radioGroup1.SelectedIndex = 0 Then
				overhead = 100.0F
			Else
				overhead = 10.0F
			End If

			If (value = 0.0 OrElse value > max OrElse value < min) Then
				arcScaleComponent1.Labels(0).FormatString = String.Empty
			Else
				arcScaleComponent1.Labels(0).FormatString = gaugeTextFormat
			End If

			arcScaleComponent1.MinValue = CSng(min) - overhead
			arcScaleComponent1.Value = CSng(value)
			arcScaleComponent1.MaxValue = CSng(max) + overhead

			arcScaleComponent1.Ranges(0).StartValue = CSng(min)
			arcScaleComponent1.Ranges(0).EndValue = CSng(avg)
			arcScaleComponent1.Ranges(1).StartValue = CSng(avg)
			arcScaleComponent1.Ranges(1).EndValue = CSng(max)

			labelComponent1.Text = text
		End Sub
		Private gaugeTextFormat As String = "${1:F2}"
		Private Sub UpdatefieldRevenue()
			Select Case radioGroup1.SelectedIndex
				Case 0
					fieldRevenue.SummaryType = PivotSummaryType.Sum
					fieldRevenue.Caption = ConstStrings.Revenue
					chart.Titles(0).Text = ConstStrings.Revenue12Months
                    chart.SeriesTemplate.Label.TextPattern = "{V:C2}"
					gaugeTextFormat = "${1:F2}"
				Case 1
					fieldRevenue.SummaryType = PivotSummaryType.Count
					fieldRevenue.Caption = ConstStrings.ReceiptCount
					chart.Titles(0).Text = ConstStrings.ReceiptCount12Months
                    chart.SeriesTemplate.Label.TextPattern = "{V:G2}"
                    gaugeTextFormat = "{1:F0}"
			End Select
		End Sub
        Private Sub pivotGrid_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCustomDrawCellEventArgs) Handles pivotGrid.CustomDrawCell
            If Object.Equals(e.GetFieldValue(fieldPeriod), CurrentPeriod) Then
                Dim month As Object = e.GetFieldValue(fieldMonth)
                Dim rowValues As Object() = New Object() {IIf(Not Object.Equals(month, Nothing), New Object() {e.GetFieldValue(fieldMonth)}, Nothing)}
                Dim currentValue As Decimal = Convert.ToDecimal(e.GetCellValue(fieldRevenue)), compareValue As Decimal = Convert.ToDecimal(e.GetCellValue(New Object() {ComparePeriod}, rowValues, fieldRevenue))
                If currentValue > compareValue Then
                    e.Appearance.ForeColor = CommonColors.GetInformationColor(UserLookAndFeel.Default)
                ElseIf currentValue < compareValue Then
                    e.Appearance.ForeColor = CommonColors.GetCriticalColor(UserLookAndFeel.Default)
                End If
            End If
        End Sub
		Private Sub chart_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chart.BoundDataChanged
			Dim compareSeries As Series = chart.Series(comparePeriodText)
			If (Not Object.Equals(compareSeries, Nothing)) Then
				Dim view As LineSeriesView = CType(compareSeries.View, LineSeriesView)
				view.LineStyle.DashStyle = DashStyle.Dash
				view.LineMarkerOptions.FillStyle.FillMode = FillMode.Solid
			End If
		End Sub
		Private Sub chart_CustomizeAutoBindingSettings(ByVal sender As Object, ByVal e As EventArgs) Handles chart.CustomizeAutoBindingSettings
			pivotGrid.OptionsChartDataSource.FieldValuesProvideMode = PivotChartFieldValuesProvideMode.DisplayText
			chart.SeriesTemplate.ArgumentScaleType = ScaleType.Qualitative
		End Sub
		Private Function GetValues(ByVal series As Series) As Double()
			If Object.Equals(series, Nothing) OrElse series.Points.Count < 2 Then
				Return New Double(){}
			End If
			Dim values(series.Points.Count - 1) As Double
			For i As Integer = 0 To values.Length - 1
				values(i) = series.Points(i).Values(0)
			Next i
			Return values
		End Function
		Friend Overrides Sub RefreshData()
			MyBase.RefreshData()
			receipts.Reload()
		End Sub
		Protected Overrides Sub InitData()
			MyBase.InitData()
			Dim startDate As DateTime = DateTime.Now.AddYears(-2)
			Me.currentPeriodDate = DateTime.Now.AddYears(-1)
			Me.currentMonth = DateTime.Now.Month

			Me.currentPeriodText = String.Format(ConstStrings.TimePeriod, currentPeriodDate, DateTime.Now)
			Me.comparePeriodText = String.Format(ConstStrings.ComparePeriod, startDate, currentPeriodDate.AddDays(-1))

			receipts = New XPCollection(Of Receipt)(Session, New BinaryOperator("Date", startDate, BinaryOperatorType.GreaterOrEqual))
			pivotGrid.DataSource = receipts
			pivotGrid.BestFit()
			UpdatefieldRevenue()
			UpdateGauge(GetGaugeValueFromPivot(), GetGaugeTextFromPivot())
		End Sub
	End Class
End Namespace
