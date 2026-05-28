using System;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos {
    public partial class HitTestingDemo : ChartDemoModule {
        readonly ToolTipController toolTipController = new ToolTipController();

        internal override ChartControl ChartControl {
            get { return chart; }
        }

        public HitTestingDemo() {
            InitializeComponent();
        }

        void chart_MouseMove(object sender, MouseEventArgs e) {
            ChartHitInfo hitInfo = chart.CalcHitInfo(e.Location);
            StringBuilder builder = new StringBuilder();
            if(hitInfo.InDiagram)
                builder.AppendLine("In diagram");
            if(hitInfo.InNonDefaultPane)
                builder.AppendLine("In non-default pane: " + hitInfo.NonDefaultPane.Name);
            if(hitInfo.InAxis) {
                builder.AppendLine("In axis: " + hitInfo.Axis.Name);
                if(hitInfo.AxisLabelItem != null)
                    builder.AppendLine("  Label item: " + hitInfo.AxisLabelItem.Text);
                if(hitInfo.AxisTitle != null)
                    builder.AppendLine("  Axis title: " + hitInfo.AxisTitle.Text);
            }
            if(hitInfo.InChartTitle)
                builder.AppendLine("In chart title: " + hitInfo.ChartTitle.Text);
            if(hitInfo.InLegend) {
                builder.AppendLine("In legend");
                if(hitInfo.Series != null && !hitInfo.InSeries)
                    builder.AppendLine("  Series: " + ((Series)hitInfo.Series).Name);
            }
            if(hitInfo.InSeries)
                builder.AppendLine("In series: " + ((Series)hitInfo.Series).Name);
            if(hitInfo.InSeriesLabel) {
                builder.AppendLine("In series label");
                builder.AppendLine("  Series: " + ((Series)hitInfo.Series).Name);
            }
            if(hitInfo.InSeriesPoint) {
                builder.AppendLine("  Argument: " + hitInfo.SeriesPoint.Argument);
                if(!hitInfo.SeriesPoint.IsEmpty)
                    builder.AppendLine("  Value: " + hitInfo.SeriesPoint.Values[0]);
            }
            if(hitInfo.InAnnotation)
                if(hitInfo.Annotation is TextAnnotation)
                    builder.AppendLine("In annotation: " + ((TextAnnotation)hitInfo.Annotation).Name);
                else if(hitInfo.Annotation is ImageAnnotation)
                    builder.AppendLine("In annotation: " + ((ImageAnnotation)hitInfo.Annotation).Name);
            if(hitInfo.InHyperlink) {
                builder.AppendLine("In hyperlink: " + hitInfo.Hyperlink);
                chart.Cursor = Cursors.Hand;
            }
            else
                chart.Cursor = Cursors.Default;
            if(builder.Length > 0)
                toolTipController.ShowHint("Hit-testing results:\n" + builder.ToString(), chart.PointToScreen(e.Location));
            else
                toolTipController.HideHint();
        }
        void chart_MouseLeave(object sender, EventArgs e) {
            toolTipController.HideHint();
        }
        void chart_MouseUp(object sender, MouseEventArgs e) {
            ChartHitInfo hitInfo = chart.CalcHitInfo(e.Location);
            if(hitInfo.InHyperlink)
                Data.Utils.SafeProcess.Start(hitInfo.Hyperlink);
        }
    }
}
