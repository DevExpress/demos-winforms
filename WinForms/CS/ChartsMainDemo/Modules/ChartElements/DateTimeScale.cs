using System;
using System.Collections.Generic;

namespace DevExpress.XtraCharts.Demos {
    public partial class DateTimeScaleDemo : ChartDemoModuleWithOptions {
        WorkTimeRule workHoursRule;
        WorkTimeRule weekendRule;
        List<WorkTimeRule> may1stRules;
        List<WorkTimeRule> january1stRules;

        XYDiagram Diagram {
            get { return chart.Diagram as XYDiagram; }
        }
        AxisX AxisX {
            get { return Diagram != null ? Diagram.AxisX : null; }
        }
        DateTimeScaleOptions DateTimeScaleOptions {
            get { return AxisX == null ? null : AxisX.DateTimeScaleOptions; }
        }
        Series PriceSeries {
            get { return ChartControl.Series["Price"]; }
        }
        Series SalesVolumeSeries {
            get { return ChartControl.Series["Sales Volume"]; }
        }
        internal override bool PaletteButtonEnabled {
            get { return false; }
        }
        internal override ChartControl ChartControl {
            get { return chart; }
        }

        public DateTimeScaleDemo() {
            InitializeComponent();
            FillGridAlignmentComboBox();
            FillMeasureUnitComboBox();
            FillFunctionsComboBox();
            FillScaleModeComboBox();
            List<FinancialDataPoint> dataSource = FinancialDataGenerator.Generate();
            ChartControl.BeginInit();
            ChartControl.DataSource = dataSource;
            PriceSeries.SetFinancialDataMembers("DateTimeStamp", "Low", "High", "Open", "Close");
            SalesVolumeSeries.SetDataMembers("DateTimeStamp", "Volume");
            SalesVolumeSeries.Visible = false;
            SetWorkTimeRules(dataSource[0].DateTimeStamp.Year, dataSource[dataSource.Count - 1].DateTimeStamp.Year);
            comboBoxEditScaleMode.SelectedIndex = 0;
            comboBoxEditMeasureUnit.SelectedIndex = 2;
            comboBoxEditAggregateFunction.SelectedIndex = 3;
            spinEditGridSpacing.Value = Convert.ToDecimal(DateTimeScaleOptions.GridSpacing);
            spinEditMeasureUnitFactor.Value = DateTimeScaleOptions.MeasureUnitMultiplier;
            spinEditMinorTickMarksCount.Value = AxisX.MinorCount;
            spinEditGridOffset.Value = Convert.ToDecimal(DateTimeScaleOptions.GridOffset);
            radioGroupView.SelectedIndex = 0;
            SetChartTitle(DateTimeScaleOptions.MeasureUnit);
            ChartControl.EndInit();
        }

        void FillGridAlignmentComboBox() {
            if(DateTimeScaleOptions == null)
                return;
            comboBoxEditGridAlignment.Properties.Items.Clear();
            List<DateTimeGridAlignment> list = new List<DateTimeGridAlignment>();
            for(int i = 8; i >= (int)DateTimeScaleOptions.MeasureUnit; i--) {
                comboBoxEditGridAlignment.Properties.Items.Add((DateTimeGridAlignment)i);
            }
            comboBoxEditGridAlignment.SelectedIndex = 0;
        }
        void FillScaleModeComboBox() {
            List<ScaleMode> scaleModeItems = new List<ScaleMode>() {
                ScaleMode.Manual,
                ScaleMode.Continuous,
                ScaleMode.Automatic
            };
            comboBoxEditScaleMode.Properties.Items.AddRange(scaleModeItems);
        }
        void FillMeasureUnitComboBox() {
            List<DateTimeMeasureUnit> measureUnitItems = new List<DateTimeMeasureUnit>() {
                DateTimeMeasureUnit.Year,
                DateTimeMeasureUnit.Quarter,
                DateTimeMeasureUnit.Month,
                DateTimeMeasureUnit.Week,
                DateTimeMeasureUnit.Day,
                DateTimeMeasureUnit.Hour
            };
            comboBoxEditMeasureUnit.Properties.Items.AddRange(measureUnitItems);
        }
        void FillFunctionsComboBox() {
            List<AggregateFunction> aggregateFunctionItems = new List<AggregateFunction>() {
                AggregateFunction.Average,
                AggregateFunction.Minimum,
                AggregateFunction.Maximum,
                AggregateFunction.Sum
            };
            comboBoxEditAggregateFunction.Properties.Items.AddRange(aggregateFunctionItems);
        }

        void SetChartTitle(DateTimeMeasureUnit measureUnit) {
            if(chart.Titles.Count == 0 || DateTimeScaleOptions == null)
                return;
            string titleText = string.Empty;
            if(DateTimeScaleOptions.ScaleMode != ScaleMode.Continuous) {
                switch(DateTimeScaleOptions.AggregateFunction) {
                    case AggregateFunction.Sum:
                        titleText = "Sales Volume by " + measureUnit;
                        break;
                    case AggregateFunction.Maximum:
                        titleText = "Max Sales Volume by Hour in " + measureUnit;
                        break;
                    case AggregateFunction.Minimum:
                        titleText = "Min Sales Volume by Hour in " + measureUnit;
                        break;
                    case AggregateFunction.Average:
                        titleText = "Average Sales Volume by Hour in " + measureUnit;
                        break;
                    case AggregateFunction.Financial:
                        titleText = "Price by " + measureUnit;
                        break;
                    default:
                        throw new NotSupportedException();
                }
            }
            else {
                if(ChartControl.Series[0].View is FinancialSeriesViewBase && ChartControl.Series[0].Visible)
                    titleText = "Stock Price";
                else
                    titleText = "Sales Volume";
            }
            chart.Titles[0].Text = titleText;
        }
        void SetWorkTimeRules(int firstYear, int lastYear) {
            workHoursRule = new WorkTimeRule();
            TimeInterval interval = new TimeInterval((int)spinEditStartHour.Value, 0, 0, (int)spinEditEndHour.Value, 0, 0);
            workHoursRule.WorkIntervals.Add(interval);
            DateTimeScaleOptions.WorkTimeRules.Add(workHoursRule);
            weekendRule = new WorkTimeRule();
            weekendRule.Weekdays = Weekday.Saturday | Weekday.Sunday;
            january1stRules = new List<WorkTimeRule>();
            for(int y = firstYear; y <= lastYear; y++) {
                WorkTimeRule january1stRule = new WorkTimeRule();
                january1stRule.Date = new DateTime(y, 1, 1);
                january1stRules.Add(january1stRule);
            }
            may1stRules = new List<WorkTimeRule>();
            for(int y = firstYear; y <= lastYear; y++) {
                WorkTimeRule may1stRule = new WorkTimeRule();
                may1stRule.Date = new DateTime(y, 5, 1);
                may1stRules.Add(may1stRule);
            }
        }
        void SetCrosshairHeaderPattern(DateTimeMeasureUnit unit) {
            if(DateTimeScaleOptions == null)
                return;
            ScaleMode scaleMode = DateTimeScaleOptions.ScaleMode;
            CrosshairOptions options = ChartControl.CrosshairOptions;
            switch(scaleMode) {
                case ScaleMode.Automatic:
                case ScaleMode.Manual:
                    switch(unit) {
                        case DateTimeMeasureUnit.Year:
                            options.GroupHeaderPattern = "{A:yyyy}";
                            break;
                        case DateTimeMeasureUnit.Quarter:
                            options.GroupHeaderPattern = "{A:MMMM yyyy}";
                            break;
                        case DateTimeMeasureUnit.Month:
                            options.GroupHeaderPattern = "{A:MMMM yyyy}";
                            break;
                        case DateTimeMeasureUnit.Week:
                            options.GroupHeaderPattern = "{A:d}";
                            break;
                        case DateTimeMeasureUnit.Day:
                            options.GroupHeaderPattern = "{A:d}";
                            break;
                        case DateTimeMeasureUnit.Hour:
                            options.GroupHeaderPattern = "{A:g}";
                            break;
                    };
                    break;
                case ScaleMode.Continuous:
                    options.GroupHeaderPattern = "{A:g}";
                    break;
            };
        }
        void SetWorkTimeOptionsGroupEnabled() {
            if(DateTimeScaleOptions == null)
                return;
            if((DateTimeScaleOptions.MeasureUnit.Equals(DateTimeMeasureUnit.Day)
                    || DateTimeScaleOptions.MeasureUnit.Equals(DateTimeMeasureUnit.Hour))
                    && DateTimeScaleOptions.ScaleMode != ScaleMode.Continuous) {
                bool workTimeOnly = checkEditWorkTimeOnly.Checked;
                checkEditWorkTimeOnly.Enabled = true;
                DateTimeScaleOptions.WorkTimeOnly = workTimeOnly;
                spinEditEndHour.Enabled = workTimeOnly;
                spinEditStartHour.Enabled = workTimeOnly;
                checkEditExcludeWeekends.Enabled = workTimeOnly;
                checkEditExcludeHolidays.Enabled = workTimeOnly;
            }
            else {
                checkEditWorkTimeOnly.Enabled = false;
                DateTimeScaleOptions.WorkTimeOnly = false;
                spinEditEndHour.Enabled = false;
                spinEditStartHour.Enabled = false;
                checkEditExcludeWeekends.Enabled = false;
                checkEditExcludeHolidays.Enabled = false;
            }
        }
        void SetMeasureUnitOptionsEnabled() {
            if(DateTimeScaleOptions == null)
                return;
            switch(DateTimeScaleOptions.ScaleMode) {
                case ScaleMode.Automatic:
                    if(radioGroupView.SelectedIndex == 0)
                        comboBoxEditAggregateFunction.Enabled = false;
                    else
                        comboBoxEditAggregateFunction.Enabled = true;
                    comboBoxEditMeasureUnit.Enabled = false;
                    spinEditMeasureUnitFactor.Enabled = false;
                    break;
                case ScaleMode.Continuous:
                    comboBoxEditMeasureUnit.Enabled = false;
                    spinEditMeasureUnitFactor.Enabled = false;
                    comboBoxEditAggregateFunction.Enabled = false;
                    break;
                case ScaleMode.Manual:
                    comboBoxEditMeasureUnit.Enabled = true;
                    spinEditMeasureUnitFactor.Enabled = true;
                    if(radioGroupView.SelectedIndex == 0)
                        comboBoxEditAggregateFunction.Enabled = false;
                    else
                        comboBoxEditAggregateFunction.Enabled = true;
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        void chart_AxisScaleChanged(object sender, AxisScaleChangedEventArgs e) {
            if(!e.Axis.Equals(AxisX))
                return;
            DateTimeScaleChangedEventArgs args = e as DateTimeScaleChangedEventArgs;
            if(args == null)
                return;
            SetChartTitle(args.MeasureUnitChange.NewValue);
            if(args.MeasureUnitChange.NewValue == DateTimeMeasureUnit.Hour || args.MeasureUnitChange.NewValue == DateTimeMeasureUnit.Day)
                layoutControlGroupWorkTimeOptions.Enabled = true;
            else
                layoutControlGroupWorkTimeOptions.Enabled = false;
            SetCrosshairHeaderPattern(args.MeasureUnitChange.NewValue);
        }

        void radioGroupView_SelectedIndexChanged(object sender, EventArgs e) {
            if(Diagram == null || SalesVolumeSeries == null || PriceSeries == null || DateTimeScaleOptions == null)
                return;
            if(radioGroupView.SelectedIndex == 0) {
                SalesVolumeSeries.Visible = false;
                PriceSeries.Visible = true;
                comboBoxEditAggregateFunction.Text = "Financial";
                comboBoxEditAggregateFunction.Enabled = false;
                DateTimeScaleOptions.AggregateFunction = AggregateFunction.Financial;
            }
            else {
                SalesVolumeSeries.Visible = true;
                PriceSeries.Visible = false;
                comboBoxEditAggregateFunction.Enabled = true;
                comboBoxEditAggregateFunction.SelectedIndex = 3;
            }
            SetChartTitle(DateTimeScaleOptions.MeasureUnit);
        }
        void comboBoxEditScaleMode_SelectedIndexChanged(object sender, EventArgs e) {
            if(DateTimeScaleOptions == null)
                return;
            ScaleMode scaleMode = (ScaleMode)comboBoxEditScaleMode.EditValue;
            DateTimeScaleOptions.ScaleMode = scaleMode;
            SetMeasureUnitOptionsEnabled();
            SetChartTitle(DateTimeScaleOptions.MeasureUnit);
            SetWorkTimeOptionsGroupEnabled();
            switch(scaleMode) {
                case ScaleMode.Automatic:
                    comboBoxEditGridAlignment.Enabled = false;
                    break;
                case ScaleMode.Continuous:
                case ScaleMode.Manual:
                    comboBoxEditGridAlignment.Enabled = true;
                    comboBoxEditGridAlignment.SelectedIndex = 0;
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        void comboBoxEditMeasureUnit_SelectedIndexChanged(object sender, EventArgs e) {
            if(AxisX == null)
                return;
            DateTimeMeasureUnit newMeasureUnit = (DateTimeMeasureUnit)comboBoxEditMeasureUnit.EditValue;
            DateTimeScaleOptions.MeasureUnit = newMeasureUnit;
            SetChartTitle(newMeasureUnit);
            SetWorkTimeOptionsGroupEnabled();
            FillGridAlignmentComboBox();
            spinEditGridSpacing.Properties.DisplayFormat.FormatString = String.Format("0 {0}(s)", newMeasureUnit.ToString().ToLower());
            spinEditGridOffset.Properties.DisplayFormat.FormatString = String.Format("0 {0}(s)", newMeasureUnit.ToString().ToLower());
        }
        void spinEditMeasureUnitFactor_ValueChanged(object sender, EventArgs e) {
            if(DateTimeScaleOptions == null)
                return;
            DateTimeScaleOptions.MeasureUnitMultiplier = (int)spinEditMeasureUnitFactor.Value;
        }
        void comboBoxEditAggregateFunction_SelectedIndexChanged(object sender, EventArgs e) {
            if(DateTimeScaleOptions == null || comboBoxEditAggregateFunction.EditValue.GetType() != typeof(AggregateFunction))
                return;
            DateTimeScaleOptions.AggregateFunction = (AggregateFunction)comboBoxEditAggregateFunction.EditValue;
            SetChartTitle(DateTimeScaleOptions.MeasureUnit);
        }
        void checkEditAutoGrid_CheckedChanged(object sender, EventArgs e) {
            if(DateTimeScaleOptions == null)
                return;
            bool isAutoGrid = checkEditAutoGrid.Checked;
            DateTimeScaleOptions.AutoGrid = isAutoGrid;
            comboBoxEditGridAlignment.Enabled = !isAutoGrid && DateTimeScaleOptions.ScaleMode != ScaleMode.Automatic;
            spinEditGridSpacing.Enabled = !isAutoGrid;
            spinEditGridSpacing.Value = Convert.ToDecimal(DateTimeScaleOptions.GridSpacing);
            spinEditGridOffset.Enabled = !isAutoGrid;
            spinEditGridOffset.Value = Convert.ToDecimal(DateTimeScaleOptions.GridOffset);
            if(comboBoxEditGridAlignment.Enabled && comboBoxEditGridAlignment.EditValue != null)
                DateTimeScaleOptions.GridAlignment = (DateTimeGridAlignment)comboBoxEditGridAlignment.EditValue;
        }
        void comboBoxEditGridAlignment_SelectedIndexChanged(object sender, EventArgs e) {
            if(DateTimeScaleOptions == null)
                return;
            DateTimeScaleOptions.GridAlignment = (DateTimeGridAlignment)comboBoxEditGridAlignment.EditValue;
        }
        void spinEditGridSpacing_ValueChanged(object sender, EventArgs e) {
            if(DateTimeScaleOptions == null)
                return;
            DateTimeScaleOptions.GridSpacing = (int)spinEditGridSpacing.Value;
            if(DateTimeScaleOptions.GridSpacing == 1)
                spinEditGridOffset.Enabled = false;
            else {
                spinEditGridOffset.Enabled = true;
                spinEditGridOffset.Properties.MaxValue = spinEditGridSpacing.Value;
                spinEditGridOffset.Properties.MinValue = -spinEditGridSpacing.Value;
            }
        }
        void spinEditGridOffset_ValueChanged(object sender, EventArgs e) {
            if(DateTimeScaleOptions == null)
                return;
            DateTimeScaleOptions.GridOffset = (int)spinEditGridOffset.Value;
        }
        void spinEditMinorTickMarksCount_ValueChanged(object sender, EventArgs e) {
            if(AxisX == null)
                return;
            AxisX.MinorCount = (int)spinEditMinorTickMarksCount.Value;

        }
        void checkEditWorkTimeOnly_CheckedChanged(object sender, EventArgs e) {
            SetWorkTimeOptionsGroupEnabled();
        }
        void spinEditStartHour_ValueChanged(object sender, EventArgs e) {
            if(workHoursRule == null)
                return;
            workHoursRule.WorkIntervals[0].StartHour = (int)spinEditStartHour.Value;
        }
        void spinEditEndHour_ValueChanged(object sender, EventArgs e) {
            if(workHoursRule == null)
                return;
            workHoursRule.WorkIntervals[0].EndHour = (int)spinEditEndHour.Value;
        }
        void checkEditExcludeWeekends_CheckedChanged(object sender, EventArgs e) {
            if(DateTimeScaleOptions == null)
                return;
            if(checkEditExcludeWeekends.Checked)
                DateTimeScaleOptions.WorkTimeRules.Add(weekendRule);
            else
                DateTimeScaleOptions.WorkTimeRules.Remove(weekendRule);
        }
        void checkEditExcludeHolidays_CheckedChanged(object sender, EventArgs e) {
            if(DateTimeScaleOptions == null)
                return;
            if(checkEditExcludeHolidays.Checked) {
                foreach(WorkTimeRule january1stRule in january1stRules)
                    DateTimeScaleOptions.WorkTimeRules.Add(january1stRule);
                foreach(WorkTimeRule may1stRule in may1stRules)
                    DateTimeScaleOptions.WorkTimeRules.Add(may1stRule);
            }
            else {
                foreach(WorkTimeRule january1stRule in january1stRules)
                    DateTimeScaleOptions.WorkTimeRules.Remove(january1stRule);
                foreach(WorkTimeRule may1stRule in may1stRules)
                    DateTimeScaleOptions.WorkTimeRules.Remove(may1stRule);
            }
        }
    }
}
