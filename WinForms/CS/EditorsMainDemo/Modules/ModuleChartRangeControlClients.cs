using System;
using System.Data;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleChartRangeControlClients : TutorialControl {
        const int seriesCount = 3;
        const int pointCount = 50;
        const double valueLevelThreshold = 100;
        const string argumentColumn = "Argument";
        const string valueColumn = "Value";
        const string seriesColumn = "Series";

        readonly DataTable numericDataSource;
        readonly DataTable dateTimeDataSource;
        readonly DataTable timeSpanDataSource;
        readonly DateTime baseDate;

        public ModuleChartRangeControlClients() {
            InitializeComponent();
            CalcControlsBestSize();
            TutorialInfo.AboutFile = null;
            TutorialInfo.Description = "";
            TutorialInfo.TutorialName = "Chart Range Control Clients Tutorial";

            this.numericDataSource = new DataTable();
            this.dateTimeDataSource = new DataTable();
            this.timeSpanDataSource = new DataTable();
            this.baseDate = TutorialConstants.Now;

            SetClientDateSource(dateTimeClient, dateTimeDataSource, typeof(DateTime));
            SetClientDateSource(timeSpanClient, timeSpanDataSource, typeof(TimeSpan));
            SetClientDateSource(numericClient, numericDataSource, typeof(double));

            radioGroupView.SelectedIndex = 1;

            InitPalettes();

            checkEditNumericAuto.Checked = true;
            checkEditDateTimeAuto.Checked = true;
            checkEditTimeSpanAuto.Checked = true;

            FillDateTimeComboBox(comboBoxDateTimeGridAlignment);
            FillDateTimeComboBox(comboBoxDateTimeSnapAlignment);
            FillTimeSpanComboBox(comboBoxTimeSpanGridAlignment);
            FillTimeSpanComboBox(comboBoxTimeSpanSnapAlignment);
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleChartRangeControlClients" }; } }
        protected override string WhatsThisXMLFileName { get { return "chartRangeControlClients"; } }
        protected override void OnLookAndFeelChanged() {
            base.OnLookAndFeelChanged();
            CalcControlsBestSize();
        }
        void CalcControlsBestSize() {
            this.layoutControl1.BeginUpdate();
            try {
                CalcTrackBarBestSize(this.trackBarDateTimeGridSpacing);
                CalcTrackBarBestSize(this.trackBarDateTimeSnapSpacing);
                CalcTrackBarBestSize(this.trackBarNumericGridSpacing);
                CalcTrackBarBestSize(this.trackBarNumericSnapSpacing);
                CalcTrackBarBestSize(this.trackBarTimeSpanGridSpacing);
                CalcTrackBarBestSize(this.trackBarTimeSpanSnapSpacing);
            }
            finally { this.layoutControl1.EndUpdate(); }
        }

        void FillDateTimeComboBox(ComboBoxEdit comboBox) {
            comboBox.Properties.Items.Add(RangeControlDateTimeGridAlignment.Day);
            comboBox.Properties.Items.Add(RangeControlDateTimeGridAlignment.Week);
            comboBox.Properties.Items.Add(RangeControlDateTimeGridAlignment.Month);
        }
        void FillTimeSpanComboBox(ComboBoxEdit comboBox) {
            comboBox.Properties.Items.Add(RangeControlTimeSpanGridAlignment.Minute);
            comboBox.Properties.Items.Add(RangeControlTimeSpanGridAlignment.Hour);
        }
        object GetArgumentByIndex(Type argumentType, int index) {
            if (argumentType == typeof(DateTime))
                return baseDate.AddDays(index * 7);
            if (argumentType == typeof(TimeSpan))
                return TimeSpan.FromMinutes(index * 30);
            return (double)(index * 10000);
        }
        void SetClientDateSource(ChartRangeControlClientBase client, DataTable dataSource, Type argumentType) {
            dataSource.Columns.Add(seriesColumn, typeof(string));
            dataSource.Columns.Add(argumentColumn, argumentType);
            dataSource.Columns.Add(valueColumn, typeof(double));

            var rand = MainFormHelper.TakeScreens ? TutorialConstants.Random : DevExpress.Data.Utils.NonCryptographicRandom.System;

            double valueLevel = valueLevelThreshold * seriesCount;

            for (int seriesIndex = 0; seriesIndex < seriesCount; seriesIndex++) {
                for (int pointIndex = 0; pointIndex < pointCount; pointIndex++)
                    dataSource.Rows.Add("Series " + seriesIndex.ToString(), GetArgumentByIndex(argumentType, pointIndex), rand.NextDouble() * valueLevelThreshold + valueLevel);
                valueLevel -= valueLevelThreshold;
            }

            client.DataProvider.SeriesDataMember = seriesColumn;
            client.DataProvider.ArgumentDataMember = argumentColumn;
            client.DataProvider.ValueDataMember = valueColumn;
            client.DataProvider.DataSource = dataSource;
        }
        void InitPalettes() {
            foreach (string paletteName in ChartRangeControlClientBase.PredefinedPalettes)
                comboBoxPalette.Properties.Items.Add(paletteName);

            comboBoxPalette.SelectedItem = numericClient.PaletteName;
        }
        void SetTrackBarRange(TrackBarControl trackBar, int min, int max) {
            trackBar.Properties.BeginUpdate();
            trackBar.Properties.Minimum = 0;
            trackBar.Properties.Maximum = int.MaxValue;
            trackBar.Value = min;
            trackBar.Properties.Minimum = min;
            trackBar.Properties.Maximum = max;
            trackBar.Properties.EndUpdate();
        }
        void SetSpacingDateTimeTrackBarRange(TrackBarControl trackBar, RangeControlDateTimeGridAlignment alignment) {
            switch (alignment) {
                case RangeControlDateTimeGridAlignment.Day:
                    SetTrackBarRange(trackBar, 40, 60);
                    break;
                case RangeControlDateTimeGridAlignment.Week:
                    SetTrackBarRange(trackBar, 6, 12);
                    break;
                default:
                case RangeControlDateTimeGridAlignment.Month:
                    SetTrackBarRange(trackBar, 2, 6);
                    break;
            }
        }
        void SetSpacingTimeSpanTrackBarRange(TrackBarControl trackBar, RangeControlTimeSpanGridAlignment alignment) {
            switch (alignment) {
                case RangeControlTimeSpanGridAlignment.Minute:
                    SetTrackBarRange(trackBar, 30, 120);
                    break;
                default:
                case RangeControlTimeSpanGridAlignment.Hour:
                    SetTrackBarRange(trackBar, 1, 12);
                    break;
            }
        }

        // <radioGroupView>
        void radioGroupView_SelectedIndexChanged(object sender, EventArgs e) {
            int viewType = (int)radioGroupView.SelectedIndex;

            ChartRangeControlClientView clientView = null;

            switch (viewType) {
                case 0:
                    clientView = new LineChartRangeControlClientView();
                    break;
                default:
                case 1:
                    clientView = new AreaChartRangeControlClientView();
                    break;
            }

            dateTimeClient.DataProvider.TemplateView = clientView;
            numericClient.DataProvider.TemplateView = clientView;
            timeSpanClient.DataProvider.TemplateView = clientView;
        }
        // </radioGroupView>
        // <comboBoxPalette>
        void comboBoxPalette_SelectedIndexChanged(object sender, EventArgs e) {
            string paletteName = (string)comboBoxPalette.SelectedItem;
            numericClient.PaletteName = paletteName;
            dateTimeClient.PaletteName = paletteName;
            timeSpanClient.PaletteName = paletteName;
        }
        // </comboBoxPalette>
        // <checkEditNumericAuto>
        void checkEditNumericAuto_CheckedChanged(object sender, EventArgs e) {
            NumericChartRangeControlClientGridOptions gridOptions = numericClient.GridOptions;

            gridOptions.Auto = checkEditNumericAuto.Checked;

            trackBarNumericGridSpacing.Enabled = !gridOptions.Auto;
            trackBarNumericSnapSpacing.Enabled = !gridOptions.Auto;

            if (!gridOptions.Auto) {
                trackBarNumericGridSpacing.Value = (int)gridOptions.GridSpacing;
                trackBarNumericSnapSpacing.Value = (int)gridOptions.SnapSpacing;
            }
        }
        // </checkEditNumericAuto>
        // <checkEditDateTimeAuto>
        void checkEditDateTimeAuto_CheckedChanged(object sender, EventArgs e) {
            DateTimeChartRangeControlClientGridOptions gridOptions = dateTimeClient.GridOptions;

            gridOptions.Auto = checkEditDateTimeAuto.Checked;

            trackBarDateTimeGridSpacing.Enabled = !gridOptions.Auto;
            trackBarDateTimeSnapSpacing.Enabled = !gridOptions.Auto;
            comboBoxDateTimeGridAlignment.Enabled = !gridOptions.Auto;
            comboBoxDateTimeSnapAlignment.Enabled = !gridOptions.Auto;

            if (!gridOptions.Auto) {
                comboBoxDateTimeGridAlignment.SelectedItem = gridOptions.GridAlignment;
                comboBoxDateTimeSnapAlignment.SelectedItem = gridOptions.SnapAlignment;
                trackBarDateTimeSnapSpacing.Value = (int)gridOptions.SnapSpacing;
                trackBarDateTimeGridSpacing.Value = (int)gridOptions.GridSpacing;
            }
        }
        // </checkEditDateTimeAuto>
        // <checkEditTimeSpanAuto>
        void checkEditTimeSpanAuto_CheckedChanged(object sender, EventArgs e) {
            TimeSpanChartRangeControlClientGridOptions gridOptions = timeSpanClient.GridOptions;

            gridOptions.Auto = checkEditTimeSpanAuto.Checked;

            trackBarTimeSpanGridSpacing.Enabled = !gridOptions.Auto;
            trackBarTimeSpanSnapSpacing.Enabled = !gridOptions.Auto;
            comboBoxTimeSpanGridAlignment.Enabled = !gridOptions.Auto;
            comboBoxTimeSpanSnapAlignment.Enabled = !gridOptions.Auto;

            if (!gridOptions.Auto) {
                comboBoxTimeSpanGridAlignment.SelectedItem = gridOptions.GridAlignment;
                comboBoxTimeSpanSnapAlignment.SelectedItem = gridOptions.SnapAlignment;
                trackBarTimeSpanSnapSpacing.Value = (int)gridOptions.SnapSpacing;
                trackBarTimeSpanGridSpacing.Value = (int)gridOptions.GridSpacing;
            }
        }
        // </checkEditTimeSpanAuto>
        // <trackBarNumericGridSpacing>
        void trackBarNumericGridSpacing_EditValueChanged(object sender, EventArgs e) {
            numericClient.GridOptions.GridSpacing = (double)trackBarNumericGridSpacing.Value;
        }
        // </trackBarNumericGridSpacing>
        // <trackBarNumericSnapSpacing>
        void trackBarNumericSnapSpacing_EditValueChanged(object sender, EventArgs e) {
            numericClient.GridOptions.SnapSpacing = (double)trackBarNumericSnapSpacing.Value;
        }
        // </trackBarNumericSnapSpacing>
        // <trackBarDateTimeGridSpacing>
        void trackBarDateTimeGridSpacing_EditValueChanged(object sender, EventArgs e) {
            dateTimeClient.GridOptions.GridSpacing = (double)trackBarDateTimeGridSpacing.Value;
        }
        // </trackBarDateTimeGridSpacing>
        // <trackBarDateTimeSnapSpacing>
        void trackBarDateTimeSnapSpacing_EditValueChanged(object sender, EventArgs e) {
            dateTimeClient.GridOptions.SnapSpacing = (double)trackBarDateTimeSnapSpacing.Value;
        }
        // </trackBarDateTimeSnapSpacing>
        // <comboBoxDateTimeGridAlignment>
        void comboBoxDateTimeGridAlignment_SelectedIndexChanged(object sender, EventArgs e) {
            RangeControlDateTimeGridAlignment alignment = (RangeControlDateTimeGridAlignment)comboBoxDateTimeGridAlignment.SelectedItem;
            dateTimeClient.GridOptions.GridAlignment = alignment;
            SetSpacingDateTimeTrackBarRange(trackBarDateTimeGridSpacing, alignment);
        }
        // </comboBoxDateTimeGridAlignment>
        // <comboBoxDateTimeSnapAlignment>
        void comboBoxDateTimeSnapAlignment_SelectedIndexChanged(object sender, EventArgs e) {
            RangeControlDateTimeGridAlignment alignment = (RangeControlDateTimeGridAlignment)comboBoxDateTimeSnapAlignment.SelectedItem;
            dateTimeClient.GridOptions.SnapAlignment = alignment;
            SetSpacingDateTimeTrackBarRange(trackBarDateTimeSnapSpacing, alignment);
        }
        // </comboBoxDateTimeSnapAlignment>
        // <trackBarTimeSpanGridSpacing>
        void trackBarTimeSpanGridSpacing_EditValueChanged(object sender, EventArgs e) {
            timeSpanClient.GridOptions.GridSpacing = (double)trackBarTimeSpanGridSpacing.Value;
        }
        // </trackBarTimeSpanGridSpacing>
        // <trackBarTimeSpanSnapSpacing>
        void trackBarTimeSpanSnapSpacing_EditValueChanged(object sender, EventArgs e) {
            timeSpanClient.GridOptions.SnapSpacing = (double)trackBarTimeSpanSnapSpacing.Value;
        }
        // </trackBarTimeSpanSnapSpacing>
        // <comboBoxTimeSpanGridAlignment>
        void comboBoxTimeSpanGridAlignment_SelectedIndexChanged(object sender, EventArgs e) {
            RangeControlTimeSpanGridAlignment alignment = (RangeControlTimeSpanGridAlignment)comboBoxTimeSpanGridAlignment.SelectedItem;
            timeSpanClient.GridOptions.GridAlignment = alignment;
            SetSpacingTimeSpanTrackBarRange(trackBarTimeSpanGridSpacing, alignment);
        }
        // </comboBoxTimeSpanGridAlignment>
        // <comboBoxTimeSpanSnapAlignment>
        void comboBoxTimeSpanSnapAlignment_SelectedIndexChanged(object sender, EventArgs e) {
            RangeControlTimeSpanGridAlignment alignment = (RangeControlTimeSpanGridAlignment)comboBoxTimeSpanSnapAlignment.SelectedItem;
            timeSpanClient.GridOptions.SnapAlignment = alignment;
            SetSpacingTimeSpanTrackBarRange(trackBarTimeSpanSnapSpacing, alignment);
        }
        // </comboBoxTimeSpanSnapAlignment>

        void trackBarNumeric_EditValueChanging(object sender, ChangingEventArgs e) {
            e.NewValue = Math.Round(Convert.ToDouble(e.NewValue) / 10000.0) * 10000.0;
        }
    }
}
