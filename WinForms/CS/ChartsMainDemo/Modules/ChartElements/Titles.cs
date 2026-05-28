using System;
using System.Drawing;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos {
    public partial class TitlesDemo : ChartDemoModuleWithOptions {
        Title selectedTitle = null;

        PieSeriesView TemplatePieView {
            get { return ChartControl.SeriesTemplate.View as PieSeriesView; }
        }

        internal override ChartControl ChartControl {
            get { return chart; }
        }

        public TitlesDemo() {
            InitializeComponent();
            ChartControl.BeginInit();
            ChartControl.DataSource = DevAV.GetSalesMixByRegion();
            comboBoxEditSeriesView.SelectedIndex = 0;
            ChartControl.SetObjectSelection(ChartControl.Titles[0]);
            SetSeriesTitles();
            ChartControl.EndInit();
        }
        void UpdateChartControl() {
            if(ChartControl.Series.Count > 0 && ChartControl.Series[0].View is PieSeriesView) {
                for(int i = 1; i < ChartControl.Series.Count; i++)
                    ChartControl.Series[i].ShowInLegend = false;
            }
            if(ChartControl.Series.Count > 0 && ChartControl.Series[0].View is BarSeriesView) {
                for(int i = 1; i < ChartControl.Series.Count; i++)
                    ChartControl.Series[i].ShowInLegend = true;
                XYDiagram diagram = (XYDiagram)ChartControl.Diagram;
                diagram.AxisX.Title.Text = "Products";
                diagram.AxisX.Title.Visibility = DefaultBoolean.True;
                diagram.AxisY.Title.Text = "Sales, <i>thousands of USD</i>";
                diagram.AxisY.Title.Visibility = DefaultBoolean.True;
            }
        }
        void SetSeriesTitles() {
            if(TemplatePieView != null) {
                SeriesTitle seriesTitle = new SeriesTitle() { Visibility = DefaultBoolean.True };
                TemplatePieView.Titles.Clear();
                TemplatePieView.Titles.Add(seriesTitle);
            }
        }
        void chart_BoundDataChanged(object sender, EventArgs e) {
            UpdateChartControl();
        }
        void chart_ObjectSelected(object sender, HotTrackEventArgs e) {
            if(e.Object is Title)
                selectedTitle = (Title)e.Object;
            else if(e.AdditionalObject is AxisTitle)
                selectedTitle = (AxisTitle)e.AdditionalObject;
            else
                e.Cancel = true;
            textEditTitleText.Text = selectedTitle.Text;
            DockableTitle dockableTitle = selectedTitle as DockableTitle;
            if(dockableTitle != null) {
                checkEditWordWrap.Checked = dockableTitle.WordWrap;
                comboBoxEditDock.Enabled = true;
                comboBoxEditDock.SelectedIndex = (int)dockableTitle.Dock;
                comboBoxEditAlignment.SelectedIndex = (int)dockableTitle.Alignment;
            }
            AxisTitle axisTitle = selectedTitle as AxisTitle;
            if(axisTitle != null) {
                checkEditWordWrap.Checked = axisTitle.WordWrap;
                comboBoxEditDock.Enabled = false;
                comboBoxEditDock.Text = string.Empty;
                comboBoxEditAlignment.SelectedIndex = (int)axisTitle.Alignment;
            }
        }
        void chart_ObjectHotTracked(object sender, HotTrackEventArgs e) {
            if(!(e.Object is Title))
                e.Cancel = true;
        }
        void comboBoxEditSeriesView_SelectedIndexChanged(object sender, EventArgs e) {
            chart.BeginInit();
            if((string)comboBoxEditSeriesView.SelectedItem == "Pie") {
                ChartControl.SeriesTemplate.ChangeView(ViewType.Pie);
                if(selectedTitle is AxisTitle && ChartControl.Titles.Count > 0)
                    ChartControl.SetObjectSelection(ChartControl.Titles[0]);
                ChartControl.Legend.Title.Text = "Products";
            }
            else if((string)comboBoxEditSeriesView.SelectedItem == "Bar") {
                ChartControl.SeriesTemplate.ChangeView(ViewType.Bar);
                if(selectedTitle is SeriesTitle && ChartControl.Titles.Count > 0)
                    ChartControl.SetObjectSelection(ChartControl.Titles[0]);
                ChartControl.Legend.Title.Text = "Regions";
            }
            UpdateChartControl();
            SetSeriesTitles();
            chart.EndInit();
            ChartControl.Animate();
        }
        void textEditTitleText_TextChanged(object sender, EventArgs e) {
            if(selectedTitle != null)
                selectedTitle.Text = textEditTitleText.Text;
        }
        void checkEditWordWrap_CheckedChanged(object sender, EventArgs e) {
            DockableTitle dockableTitle = selectedTitle as DockableTitle;
            if(dockableTitle != null)
                dockableTitle.WordWrap = checkEditWordWrap.Checked;
            AxisTitle axisTitle = selectedTitle as AxisTitle;
            if(axisTitle != null)
                axisTitle.WordWrap = checkEditWordWrap.Checked;
        }
        void comboBoxEditDock_SelectedIndexChanged(object sender, EventArgs e) {
            DockableTitle dockableTitle = selectedTitle as DockableTitle;
            if(dockableTitle != null)
                dockableTitle.Dock = (ChartTitleDockStyle)comboBoxEditDock.SelectedIndex;
        }
        void comboBoxEditAlignment_SelectedIndexChanged(object sender, EventArgs e) {
            DockableTitle dockableTitle = selectedTitle as DockableTitle;
            if(dockableTitle != null)
                dockableTitle.Alignment = (StringAlignment)comboBoxEditAlignment.SelectedIndex;
            AxisTitle axisTitle = selectedTitle as AxisTitle;
            if(axisTitle != null)
                axisTitle.Alignment = (StringAlignment)comboBoxEditAlignment.SelectedIndex;
        }
    }
}
