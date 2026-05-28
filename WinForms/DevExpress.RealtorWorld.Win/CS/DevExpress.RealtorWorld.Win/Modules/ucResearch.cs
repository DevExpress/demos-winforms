using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraPivotGrid;

namespace DevExpress.RealtorWorld.Win {
    public partial class ucResearch : BaseModule {
        PivotGridField seasonallyAdjustedField;
        PivotGridField yearField;
        XYDiagram Diagram {
            get { return (XYDiagram)ccHousesSales.Diagram; }
        }
        public override string ModuleCaption { get { return "US Houses Market Research"; } }
        public override string ModuleName { get { return "Research"; } }

        public ucResearch() {
            InitializeComponent();
            PivotGridField monthField;
            PivotGridField regionField;
            pgcHousesSales.BeginUpdate();
            try {
                pgcHousesSales.DataSource = DataHelper.GetHousesSalesTable();

                yearField = new PivotGridField("Date", PivotArea.RowArea);
                yearField.Caption = "Year";
                yearField.Options.AllowExpand = DefaultBoolean.False;
                yearField.Options.AllowFilter = DefaultBoolean.False;
                yearField.GroupInterval = PivotGroupInterval.DateYear;
                pgcHousesSales.Fields.Add(yearField);
                monthField = new PivotGridField("Date", PivotArea.RowArea);
                monthField.Caption = "Month";
                monthField.GroupInterval = PivotGroupInterval.DateMonth;
                pgcHousesSales.Fields.Add(monthField);
                PivotGridGroup dateGroup = new PivotGridGroup("Date");
                dateGroup.Fields.Add(yearField);
                dateGroup.Fields.Add(monthField);
                pgcHousesSales.Groups.Add(dateGroup);

                PivotGridField typeField = new PivotGridField("Type", PivotArea.ColumnArea);
                typeField.Caption = "Status";
                typeField.Options.AllowExpand = DefaultBoolean.False;
                typeField.SortOrder = PivotSortOrder.Descending;
                typeField.TotalsVisibility = PivotTotalsVisibility.None;
                pgcHousesSales.Fields.Add(typeField);
                seasonallyAdjustedField = new PivotGridField("SeasonallyAdjusted", PivotArea.ColumnArea);
                seasonallyAdjustedField.Caption = "Seasonally Adjusted";
                seasonallyAdjustedField.Width = 60;
                pgcHousesSales.Fields.Add(seasonallyAdjustedField);
                regionField = new PivotGridField("Region", PivotArea.ColumnArea);
                pgcHousesSales.Fields.Add(regionField);
                PivotGridGroup typeGroup = new PivotGridGroup("Type");
                typeGroup.Fields.Add(seasonallyAdjustedField);
                typeGroup.Fields.Add(regionField);
                pgcHousesSales.Groups.Add(typeGroup);
                pgcHousesSales.Fields.Add(new PivotGridField("Count", PivotArea.DataArea));
            }
            finally {
                pgcHousesSales.EndUpdate();
            }
            yearField.BestFit();
            monthField.BestFit();
            regionField.BestFit();
        }
        void ccHousesSales_BoundDataChanged(object sender, EventArgs e) {
            if(ccHousesSales.Series.Count == 0)
                return;
            ccHousesSales.BeginInit();
            try {
                List<string> seriesNames = new List<string>();
                PaletteEntry[] colors = ccHousesSales.GetPaletteEntries(10);
                Dictionary<string, XYDiagramPaneBase> panes = new Dictionary<string, XYDiagramPaneBase>();
                foreach(XYDiagramPane pane in Diagram.Panes)
                    pane.Visibility = ChartElementVisibility.Hidden;
                foreach(SecondaryAxisY axisY in Diagram.SecondaryAxesY) {
                    axisY.Visibility = DefaultBoolean.False;
                    axisY.GridLines.Visible = false;
                    axisY.GridLines.MinorVisible = false;
                }
                foreach(Series series in ccHousesSales.Series) {
                    string[] splittedName = series.Name.TrimEnd().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    string name = splittedName.Length == 3 ? splittedName[2] : "All Regions";
                    string key = splittedName[0].Trim() + " (" + splittedName[1].Trim() + ")";
                    if(seriesNames.Contains(name)) {
                        ((LineSeriesView)series.View).Color = colors[seriesNames.IndexOf(name)].Color;
                        series.ShowInLegend = false;
                    }
                    else {
                        seriesNames.Add(name);
                        ((LineSeriesView)series.View).Color = colors[seriesNames.Count - 1].Color;
                    }
                    series.Name = name;
                    XYDiagramPaneBase currentPane = null;
                    if(panes.Keys.Count == 0) {
                        panes.Add(key, Diagram.DefaultPane);
                        ((TextAnnotation)ccHousesSales.Annotations[0]).Text = key;
                    }
                    else if(panes.TryGetValue(key, out currentPane)) {
                        UptadeSeries(series, currentPane, GetAxisY(currentPane));
                    }
                    else {
                        int paneIndex;
                        for(paneIndex = 0; paneIndex < Diagram.Panes.Count; paneIndex++) {
                            if(!panes.ContainsValue(Diagram.Panes[paneIndex]))
                                break;
                        }
                        XYDiagramPane pane = Diagram.Panes[paneIndex];
                        pane.Visibility = ChartElementVisibility.Hidden;
                        panes.Add(key, pane);
                        SecondaryAxisY axis = Diagram.SecondaryAxesY[paneIndex];
                        axis.GridLines.Visible = true;
                        axis.GridLines.MinorVisible = true;
                        axis.Visibility = DefaultBoolean.True;
                        UptadeSeries(series, pane, axis);
                        ((TextAnnotation)ccHousesSales.Annotations[paneIndex + 1]).Text = key;
                    }
                }
            }
            finally {
                ccHousesSales.EndInit();
            }
        }
        void ccHousesSales_CustomizeAutoBindingSettings(object sender, EventArgs e) {
            if(yearField == null)
                return;
            Diagram.AxisX.DateTimeScaleOptions.MeasureUnit = yearField.ExpandedInFieldsGroup ? DateTimeMeasureUnit.Month : DateTimeMeasureUnit.Year;
            Diagram.AxisX.DateTimeScaleOptions.GridAlignment = DateTimeGridAlignment.Year;
            Diagram.AxisX.Label.TextPattern = "{A:yyyy}";
        }
        void pgcHousesSales_FieldValueDisplayText(object sender, PivotFieldDisplayTextEventArgs e) {
            if(e.ValueType == PivotGridValueType.Total && e.Field.Equals(seasonallyAdjustedField))
                e.DisplayText = "Total";
        }
        void pgcHousesSales_GridLayout(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
        }
        void UptadeSeries(Series series, XYDiagramPaneBase pane, AxisYBase axis) {
            XYDiagramSeriesViewBase view = (XYDiagramSeriesViewBase)series.View;
            view.AxisY = axis;
            view.Pane = pane;
        }
        AxisYBase GetAxisY(XYDiagramPaneBase currentPane) {
            for(int i = 0; i < Diagram.Panes.Count; i++)
                if(Diagram.Panes[i] == currentPane)
                    return Diagram.SecondaryAxesY[i];
            return Diagram.AxisY;
        }
    }
}
