Imports System
Imports System.Collections.Generic

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class DateTimeScaleDemo
        Inherits ChartDemoModuleWithOptions

        Private workHoursRule As WorkTimeRule

        Private weekendRule As WorkTimeRule

        Private may1stRules As List(Of WorkTimeRule)

        Private january1stRules As List(Of WorkTimeRule)

        Private ReadOnly Property Diagram As XYDiagram
            Get
                Return TryCast(chart.Diagram, XYDiagram)
            End Get
        End Property

        Private ReadOnly Property AxisX As AxisX
            Get
                Return If(Diagram IsNot Nothing, Diagram.AxisX, Nothing)
            End Get
        End Property

        Private ReadOnly Property DateTimeScaleOptions As DateTimeScaleOptions
            Get
                Return If(AxisX Is Nothing, Nothing, AxisX.DateTimeScaleOptions)
            End Get
        End Property

        Private ReadOnly Property PriceSeries As Series
            Get
                Return ChartControl.Series("Price")
            End Get
        End Property

        Private ReadOnly Property SalesVolumeSeries As Series
            Get
                Return ChartControl.Series("Sales Volume")
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
            FillGridAlignmentComboBox()
            FillMeasureUnitComboBox()
            FillFunctionsComboBox()
            FillScaleModeComboBox()
            Dim dataSource As List(Of FinancialDataPoint) = Generate()
            ChartControl.BeginInit()
            ChartControl.DataSource = dataSource
            PriceSeries.SetFinancialDataMembers("DateTimeStamp", "Low", "High", "Open", "Close")
            SalesVolumeSeries.SetDataMembers("DateTimeStamp", "Volume")
            SalesVolumeSeries.Visible = False
            SetWorkTimeRules(dataSource(0).DateTimeStamp.Year, dataSource(dataSource.Count - 1).DateTimeStamp.Year)
            comboBoxEditScaleMode.SelectedIndex = 0
            comboBoxEditMeasureUnit.SelectedIndex = 2
            comboBoxEditAggregateFunction.SelectedIndex = 3
            spinEditGridSpacing.Value = Convert.ToDecimal(DateTimeScaleOptions.GridSpacing)
            spinEditMeasureUnitFactor.Value = DateTimeScaleOptions.MeasureUnitMultiplier
            spinEditMinorTickMarksCount.Value = AxisX.MinorCount
            spinEditGridOffset.Value = Convert.ToDecimal(DateTimeScaleOptions.GridOffset)
            radioGroupView.SelectedIndex = 0
            SetChartTitle(DateTimeScaleOptions.MeasureUnit)
            ChartControl.EndInit()
        End Sub

        Private Sub FillGridAlignmentComboBox()
            If DateTimeScaleOptions Is Nothing Then Return
            comboBoxEditGridAlignment.Properties.Items.Clear()
            Dim list As List(Of DateTimeGridAlignment) = New List(Of DateTimeGridAlignment)()
            For i As Integer = 8 To CInt(DateTimeScaleOptions.MeasureUnit) Step -1
                comboBoxEditGridAlignment.Properties.Items.Add(CType(i, DateTimeGridAlignment))
            Next

            comboBoxEditGridAlignment.SelectedIndex = 0
        End Sub

        Private Sub FillScaleModeComboBox()
            Dim scaleModeItems As List(Of ScaleMode) = New List(Of ScaleMode)() From {ScaleMode.Manual, ScaleMode.Continuous, ScaleMode.Automatic}
            comboBoxEditScaleMode.Properties.Items.AddRange(scaleModeItems)
        End Sub

        Private Sub FillMeasureUnitComboBox()
            Dim measureUnitItems As List(Of DateTimeMeasureUnit) = New List(Of DateTimeMeasureUnit)() From {DateTimeMeasureUnit.Year, DateTimeMeasureUnit.Quarter, DateTimeMeasureUnit.Month, DateTimeMeasureUnit.Week, DateTimeMeasureUnit.Day, DateTimeMeasureUnit.Hour}
            comboBoxEditMeasureUnit.Properties.Items.AddRange(measureUnitItems)
        End Sub

        Private Sub FillFunctionsComboBox()
            Dim aggregateFunctionItems As List(Of AggregateFunction) = New List(Of AggregateFunction)() From {AggregateFunction.Average, AggregateFunction.Minimum, AggregateFunction.Maximum, AggregateFunction.Sum}
            comboBoxEditAggregateFunction.Properties.Items.AddRange(aggregateFunctionItems)
        End Sub

        Private Sub SetChartTitle(ByVal measureUnit As DateTimeMeasureUnit)
            If chart.Titles.Count = 0 OrElse DateTimeScaleOptions Is Nothing Then Return
            Dim titleText As String = String.Empty
            If DateTimeScaleOptions.ScaleMode <> ScaleMode.Continuous Then
                Select Case DateTimeScaleOptions.AggregateFunction
                    Case AggregateFunction.Sum
                        titleText = "Sales Volume by " & measureUnit
                    Case AggregateFunction.Maximum
                        titleText = "Max Sales Volume by Hour in " & measureUnit
                    Case AggregateFunction.Minimum
                        titleText = "Min Sales Volume by Hour in " & measureUnit
                    Case AggregateFunction.Average
                        titleText = "Average Sales Volume by Hour in " & measureUnit
                    Case AggregateFunction.Financial
                        titleText = "Price by " & measureUnit
                    Case Else
                        Throw New NotSupportedException()
                End Select
            Else
                If TypeOf ChartControl.Series(0).View Is FinancialSeriesViewBase AndAlso ChartControl.Series(0).Visible Then
                    titleText = "Stock Price"
                Else
                    titleText = "Sales Volume"
                End If
            End If

            chart.Titles(0).Text = titleText
        End Sub

        Private Sub SetWorkTimeRules(ByVal firstYear As Integer, ByVal lastYear As Integer)
            workHoursRule = New WorkTimeRule()
            Dim interval As TimeInterval = New TimeInterval(CInt(spinEditStartHour.Value), 0, 0, CInt(spinEditEndHour.Value), 0, 0)
            workHoursRule.WorkIntervals.Add(interval)
            DateTimeScaleOptions.WorkTimeRules.Add(workHoursRule)
            weekendRule = New WorkTimeRule()
            weekendRule.Weekdays = Weekday.Saturday Or Weekday.Sunday
            january1stRules = New List(Of WorkTimeRule)()
            For y As Integer = firstYear To lastYear
                Dim january1stRule As WorkTimeRule = New WorkTimeRule()
                january1stRule.Date = New DateTime(y, 1, 1)
                january1stRules.Add(january1stRule)
            Next

            may1stRules = New List(Of WorkTimeRule)()
            For y As Integer = firstYear To lastYear
                Dim may1stRule As WorkTimeRule = New WorkTimeRule()
                may1stRule.Date = New DateTime(y, 5, 1)
                may1stRules.Add(may1stRule)
            Next
        End Sub

        Private Sub SetCrosshairHeaderPattern(ByVal unit As DateTimeMeasureUnit)
            If DateTimeScaleOptions Is Nothing Then Return
            Dim scaleMode As ScaleMode = DateTimeScaleOptions.ScaleMode
            Dim options As CrosshairOptions = ChartControl.CrosshairOptions
            Select Case scaleMode
                Case ScaleMode.Automatic, ScaleMode.Manual
                    Select Case unit
                        Case DateTimeMeasureUnit.Year
                            options.GroupHeaderPattern = "{A:yyyy}"
                        Case DateTimeMeasureUnit.Quarter
                            options.GroupHeaderPattern = "{A:MMMM yyyy}"
                        Case DateTimeMeasureUnit.Month
                            options.GroupHeaderPattern = "{A:MMMM yyyy}"
                        Case DateTimeMeasureUnit.Week
                            options.GroupHeaderPattern = "{A:d}"
                        Case DateTimeMeasureUnit.Day
                            options.GroupHeaderPattern = "{A:d}"
                        Case DateTimeMeasureUnit.Hour
                            options.GroupHeaderPattern = "{A:g}"
                    End Select

                Case ScaleMode.Continuous
                    options.GroupHeaderPattern = "{A:g}"
            End Select
        End Sub

        Private Sub SetWorkTimeOptionsGroupEnabled()
            If DateTimeScaleOptions Is Nothing Then Return
            If(DateTimeScaleOptions.MeasureUnit.Equals(DateTimeMeasureUnit.Day) OrElse DateTimeScaleOptions.MeasureUnit.Equals(DateTimeMeasureUnit.Hour)) AndAlso DateTimeScaleOptions.ScaleMode <> ScaleMode.Continuous Then
                Dim workTimeOnly As Boolean = checkEditWorkTimeOnly.Checked
                checkEditWorkTimeOnly.Enabled = True
                DateTimeScaleOptions.WorkTimeOnly = workTimeOnly
                spinEditEndHour.Enabled = workTimeOnly
                spinEditStartHour.Enabled = workTimeOnly
                checkEditExcludeWeekends.Enabled = workTimeOnly
                checkEditExcludeHolidays.Enabled = workTimeOnly
            Else
                checkEditWorkTimeOnly.Enabled = False
                DateTimeScaleOptions.WorkTimeOnly = False
                spinEditEndHour.Enabled = False
                spinEditStartHour.Enabled = False
                checkEditExcludeWeekends.Enabled = False
                checkEditExcludeHolidays.Enabled = False
            End If
        End Sub

        Private Sub SetMeasureUnitOptionsEnabled()
            If DateTimeScaleOptions Is Nothing Then Return
            Select Case DateTimeScaleOptions.ScaleMode
                Case ScaleMode.Automatic
                    If radioGroupView.SelectedIndex = 0 Then
                        comboBoxEditAggregateFunction.Enabled = False
                    Else
                        comboBoxEditAggregateFunction.Enabled = True
                    End If

                    comboBoxEditMeasureUnit.Enabled = False
                    spinEditMeasureUnitFactor.Enabled = False
                Case ScaleMode.Continuous
                    comboBoxEditMeasureUnit.Enabled = False
                    spinEditMeasureUnitFactor.Enabled = False
                    comboBoxEditAggregateFunction.Enabled = False
                Case ScaleMode.Manual
                    comboBoxEditMeasureUnit.Enabled = True
                    spinEditMeasureUnitFactor.Enabled = True
                    If radioGroupView.SelectedIndex = 0 Then
                        comboBoxEditAggregateFunction.Enabled = False
                    Else
                        comboBoxEditAggregateFunction.Enabled = True
                    End If

                Case Else
                    Throw New NotSupportedException()
            End Select
        End Sub

        Private Sub chart_AxisScaleChanged(ByVal sender As Object, ByVal e As AxisScaleChangedEventArgs)
            If Not e.Axis.Equals(AxisX) Then Return
            Dim args As DateTimeScaleChangedEventArgs = TryCast(e, DateTimeScaleChangedEventArgs)
            If args Is Nothing Then Return
            SetChartTitle(args.MeasureUnitChange.NewValue)
            If args.MeasureUnitChange.NewValue = DateTimeMeasureUnit.Hour OrElse args.MeasureUnitChange.NewValue = DateTimeMeasureUnit.Day Then
                layoutControlGroupWorkTimeOptions.Enabled = True
            Else
                layoutControlGroupWorkTimeOptions.Enabled = False
            End If

            SetCrosshairHeaderPattern(args.MeasureUnitChange.NewValue)
        End Sub

        Private Sub radioGroupView_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Diagram Is Nothing OrElse SalesVolumeSeries Is Nothing OrElse PriceSeries Is Nothing OrElse DateTimeScaleOptions Is Nothing Then Return
            If radioGroupView.SelectedIndex = 0 Then
                SalesVolumeSeries.Visible = False
                PriceSeries.Visible = True
                comboBoxEditAggregateFunction.Text = "Financial"
                comboBoxEditAggregateFunction.Enabled = False
                DateTimeScaleOptions.AggregateFunction = AggregateFunction.Financial
            Else
                SalesVolumeSeries.Visible = True
                PriceSeries.Visible = False
                comboBoxEditAggregateFunction.Enabled = True
                comboBoxEditAggregateFunction.SelectedIndex = 3
            End If

            SetChartTitle(DateTimeScaleOptions.MeasureUnit)
        End Sub

        Private Sub comboBoxEditScaleMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If DateTimeScaleOptions Is Nothing Then Return
            Dim scaleMode As ScaleMode = CType(comboBoxEditScaleMode.EditValue, ScaleMode)
            DateTimeScaleOptions.ScaleMode = scaleMode
            SetMeasureUnitOptionsEnabled()
            SetChartTitle(DateTimeScaleOptions.MeasureUnit)
            SetWorkTimeOptionsGroupEnabled()
            Select Case scaleMode
                Case ScaleMode.Automatic
                    comboBoxEditGridAlignment.Enabled = False
                Case ScaleMode.Continuous, ScaleMode.Manual
                    comboBoxEditGridAlignment.Enabled = True
                    comboBoxEditGridAlignment.SelectedIndex = 0
                Case Else
                    Throw New NotSupportedException()
            End Select
        End Sub

        Private Sub comboBoxEditMeasureUnit_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If AxisX Is Nothing Then Return
            Dim newMeasureUnit As DateTimeMeasureUnit = CType(comboBoxEditMeasureUnit.EditValue, DateTimeMeasureUnit)
            DateTimeScaleOptions.MeasureUnit = newMeasureUnit
            SetChartTitle(newMeasureUnit)
            SetWorkTimeOptionsGroupEnabled()
            FillGridAlignmentComboBox()
            spinEditGridSpacing.Properties.DisplayFormat.FormatString = String.Format("0 {0}(s)", newMeasureUnit.ToString().ToLower())
            spinEditGridOffset.Properties.DisplayFormat.FormatString = String.Format("0 {0}(s)", newMeasureUnit.ToString().ToLower())
        End Sub

        Private Sub spinEditMeasureUnitFactor_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If DateTimeScaleOptions Is Nothing Then Return
            DateTimeScaleOptions.MeasureUnitMultiplier = CInt(spinEditMeasureUnitFactor.Value)
        End Sub

        Private Sub comboBoxEditAggregateFunction_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If DateTimeScaleOptions Is Nothing OrElse comboBoxEditAggregateFunction.EditValue.GetType() IsNot GetType(AggregateFunction) Then Return
            DateTimeScaleOptions.AggregateFunction = CType(comboBoxEditAggregateFunction.EditValue, AggregateFunction)
            SetChartTitle(DateTimeScaleOptions.MeasureUnit)
        End Sub

        Private Sub checkEditAutoGrid_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If DateTimeScaleOptions Is Nothing Then Return
            Dim isAutoGrid As Boolean = checkEditAutoGrid.Checked
            DateTimeScaleOptions.AutoGrid = isAutoGrid
            comboBoxEditGridAlignment.Enabled = Not isAutoGrid AndAlso DateTimeScaleOptions.ScaleMode <> ScaleMode.Automatic
            spinEditGridSpacing.Enabled = Not isAutoGrid
            spinEditGridSpacing.Value = Convert.ToDecimal(DateTimeScaleOptions.GridSpacing)
            spinEditGridOffset.Enabled = Not isAutoGrid
            spinEditGridOffset.Value = Convert.ToDecimal(DateTimeScaleOptions.GridOffset)
            If comboBoxEditGridAlignment.Enabled AndAlso comboBoxEditGridAlignment.EditValue IsNot Nothing Then DateTimeScaleOptions.GridAlignment = CType(comboBoxEditGridAlignment.EditValue, DateTimeGridAlignment)
        End Sub

        Private Sub comboBoxEditGridAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If DateTimeScaleOptions Is Nothing Then Return
            DateTimeScaleOptions.GridAlignment = CType(comboBoxEditGridAlignment.EditValue, DateTimeGridAlignment)
        End Sub

        Private Sub spinEditGridSpacing_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If DateTimeScaleOptions Is Nothing Then Return
            DateTimeScaleOptions.GridSpacing = CInt(spinEditGridSpacing.Value)
            If DateTimeScaleOptions.GridSpacing = 1 Then
                spinEditGridOffset.Enabled = False
            Else
                spinEditGridOffset.Enabled = True
                spinEditGridOffset.Properties.MaxValue = spinEditGridSpacing.Value
                spinEditGridOffset.Properties.MinValue = -spinEditGridSpacing.Value
            End If
        End Sub

        Private Sub spinEditGridOffset_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If DateTimeScaleOptions Is Nothing Then Return
            DateTimeScaleOptions.GridOffset = CInt(spinEditGridOffset.Value)
        End Sub

        Private Sub spinEditMinorTickMarksCount_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If AxisX Is Nothing Then Return
            AxisX.MinorCount = CInt(spinEditMinorTickMarksCount.Value)
        End Sub

        Private Sub checkEditWorkTimeOnly_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetWorkTimeOptionsGroupEnabled()
        End Sub

        Private Sub spinEditStartHour_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If workHoursRule Is Nothing Then Return
            workHoursRule.WorkIntervals(0).StartHour = CInt(spinEditStartHour.Value)
        End Sub

        Private Sub spinEditEndHour_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If workHoursRule Is Nothing Then Return
            workHoursRule.WorkIntervals(0).EndHour = CInt(spinEditEndHour.Value)
        End Sub

        Private Sub checkEditExcludeWeekends_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If DateTimeScaleOptions Is Nothing Then Return
            If checkEditExcludeWeekends.Checked Then
                DateTimeScaleOptions.WorkTimeRules.Add(weekendRule)
            Else
                DateTimeScaleOptions.WorkTimeRules.Remove(weekendRule)
            End If
        End Sub

        Private Sub checkEditExcludeHolidays_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If DateTimeScaleOptions Is Nothing Then Return
            If checkEditExcludeHolidays.Checked Then
                For Each january1stRule As WorkTimeRule In january1stRules
                    DateTimeScaleOptions.WorkTimeRules.Add(january1stRule)
                Next

                For Each may1stRule As WorkTimeRule In may1stRules
                    DateTimeScaleOptions.WorkTimeRules.Add(may1stRule)
                Next
            Else
                For Each january1stRule As WorkTimeRule In january1stRules
                    DateTimeScaleOptions.WorkTimeRules.Remove(january1stRule)
                Next

                For Each may1stRule As WorkTimeRule In may1stRules
                    DateTimeScaleOptions.WorkTimeRules.Remove(may1stRule)
                Next
            End If
        End Sub
    End Class
End Namespace
