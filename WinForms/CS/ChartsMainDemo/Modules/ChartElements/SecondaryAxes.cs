using System;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraCharts.Demos {
    public partial class SecondaryAxesDemo : ChartDemoModuleWithOptions {
        XYDiagram Diagram {
            get { return ChartControl.Diagram as XYDiagram; }
        }
        SecondaryAxisX SecondaryAxisX {
            get { return (Diagram != null && Diagram.SecondaryAxesX.Count > 0) ? Diagram.SecondaryAxesX[0] : null; }
        }
        SecondaryAxisY SecondaryAxisY {
            get { return (Diagram != null && Diagram.SecondaryAxesY.Count > 0) ? Diagram.SecondaryAxesY[0] : null; }
        }
        AxisX PrimaryAxisX {
            get { return Diagram != null ? Diagram.AxisX : null; }
        }
        AxisY PrimaryAxisY {
            get { return Diagram != null ? Diagram.AxisY : null; }
        }
        XYDiagramSeriesViewBase SecondSeriesView {
            get {
                Series secondSeries = ChartControl.Series.Count > 1 ? ChartControl.Series[1] : null;
                return secondSeries != null ? secondSeries.View as XYDiagramSeriesViewBase : null;
            }
        }
        internal override ChartControl ChartControl {
            get { return chart; }
        }

        public SecondaryAxesDemo() {
            InitializeComponent();
            if(Diagram == null)
                return;
            ChartControl.BeginInit();
            Diagram.SecondaryAxesX.Add(new SecondaryAxisX("Secondary Axis X"));
            Diagram.SecondaryAxesY.Add(new SecondaryAxisY("Secondary Axis Y"));
            ChartControl.EndInit();
            RadioGroupItemCollection items = radioGroupChartType.Properties.Items;
            items.Add(new RadioGroupItem(ViewType.Line, "Line"));
            items.Add(new RadioGroupItem(ViewType.Bar, "Bar"));
            radioGroupChartType.SelectedIndex = 0;
            items = radioGroupSeries2AxisX.Properties.Items;
            items.Add(new RadioGroupItem(null, "Primary Axis X"));
            items.Add(new RadioGroupItem(null, "Secondary Axis X"));
            radioGroupSeries2AxisX.SelectedIndex = 0;
            items = radioGroupSeries2AxisY.Properties.Items;
            items.Add(new RadioGroupItem(null, "Primary Axis Y"));
            items.Add(new RadioGroupItem(null, "Secondary Axis Y"));
            radioGroupSeries2AxisY.SelectedIndex = 1;
        }

        void AttachSecondaryAxisX() {
            if(PrimaryAxisX == null || SecondSeriesView == null || SecondaryAxisX == null)
                return;
            SecondSeriesView.AxisX = SecondaryAxisX;
            SecondaryAxisX.Visibility = DefaultBoolean.True;
            PrimaryAxisX.Title.Text = "Series 1 Axis X (Primary)";
            SecondaryAxisX.Title.Visibility = DefaultBoolean.True;
            SecondaryAxisX.Title.Text = "Series 2 Axis X (Secondary)";
        }
        void AttachSecondaryAxisY() {
            if(PrimaryAxisY == null || SecondSeriesView == null || SecondaryAxisY == null)
                return;
            SecondSeriesView.AxisY = SecondaryAxisY;
            SecondaryAxisY.Visibility = DefaultBoolean.True;
            Diagram.AxisY.Title.Text = "Series 1 Axis Y (Primary)";
            SecondaryAxisY.Title.Visibility = DefaultBoolean.True;
            SecondaryAxisY.Title.Text = "Series 2 Axis Y (Secondary)";
        }
        void DetachSecondaryAxisX() {
            if(SecondaryAxisX == null || SecondSeriesView == null || PrimaryAxisX == null)
                return;
            SecondaryAxisX.Visibility = DefaultBoolean.False;
            SecondSeriesView.AxisX = Diagram.AxisX;
            PrimaryAxisX.Title.Text = "Series 1 and Series 2 Axis X (Primary)";
        }
        void DetachSecondaryAxisY() {
            if(SecondaryAxisY == null || SecondSeriesView == null || PrimaryAxisY == null)
                return;
            SecondaryAxisY.Visibility = DefaultBoolean.False;
            SecondSeriesView.AxisY = Diagram.AxisY;
            PrimaryAxisY.Title.Text = "Series 1 and Series 2 Axis Y (Primary)";
        }
        void radioGroupChartType_SelectedIndexChanged(object sender, EventArgs e) {
            foreach(Series series in ChartControl.Series)
                series.ChangeView((ViewType)radioGroupChartType.EditValue);
        }
        void radioGroupSeries2AxisX_SelectedIndexChanged(object sender, EventArgs e) {
            if(radioGroupSeries2AxisX.SelectedIndex == 0)
                DetachSecondaryAxisX();
            else
                AttachSecondaryAxisX();
        }
        void radioGroupSeries2AxisY_SelectedIndexChanged(object sender, EventArgs e) {
            if(radioGroupSeries2AxisY.SelectedIndex == 0)
                DetachSecondaryAxisY();
            else
                AttachSecondaryAxisY();
        }
    }
}
