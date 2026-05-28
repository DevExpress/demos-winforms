using System;
using System.Collections.Generic;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Docking2010.Views;

namespace DevExpress.XtraCharts.Demos {
    public partial class GanttViewsDemo : ChartDemoModule {
        static readonly DateTime rightAxisLimit = new DateTime(2006, 11, 13);

        ChartControl chart;

        GanttDiagram Diagram {
            get { return chart != null ? chart.Diagram as GanttDiagram : null; }
        }
        Series PlannedSeries {
            get { return chart.GetSeriesByName("Planned"); }
        }
        Series CompletedSeries {
            get { return chart.GetSeriesByName("Completed"); }
        }
        ConstantLine ProgressLine {
            get { return Diagram.AxisY.ConstantLines[0]; }
        }
        bool HasConstantLine {
            get { return Diagram != null && Diagram.AxisY.ConstantLines.Count > 0; }
        }

        internal override ChartControl ChartControl {
            get { return chart; }
        }
        internal override List<ChartControl> ChartControls {
            get {
                return new List<ChartControl>() {
                    chartGantt,
                    chartGanttSideBySide
                };
            }
        }

        public GanttViewsDemo() {
            InitializeComponent();
            currentTabbedView.PopupMenuShowing += (s, e) => e.Cancel = true;
        }

        void tabbedView_DocumentActivated(object sender, DocumentEventArgs e) {
            chart = ((DockPanel)e.Document.Control).ControlContainer.Controls[0] as ChartControl;
            chart.Animate();
        }
        void chartGantt_ConstantLineMoved(object sender, ConstantLineMovedEventArgs e) {
            SetProgressState((DateTime)e.ConstantLine.AxisValue);
        }
        void chartGantt_AnimationEnded(object sender, EventArgs e) {
            XYDiagram diagram = (XYDiagram)ChartControl.Diagram;
            if(diagram.AxisY.ConstantLines.Count > 0)
                diagram.AxisY.ConstantLines[0].Visible = true;
        }
        void SetProgressState(DateTime dateTimeValue) {
            if(dateTimeValue > rightAxisLimit)
                dateTimeValue = rightAxisLimit;
            if(CompletedSeries != null && PlannedSeries != null) {
                CompletedSeries.Points.BeginUpdate();
                CompletedSeries.Points.Clear();
                foreach(SeriesPoint point in PlannedSeries.Points) {
                    DateTime plannedStartDate = point.DateTimeValues[0];
                    if(DateTime.Compare(plannedStartDate, dateTimeValue) >= 0)
                        continue;
                    DateTime plannedFinishDate = point.DateTimeValues[1];
                    DateTime completedFinishDate;
                    if(DateTime.Compare(dateTimeValue, plannedFinishDate) > 0)
                        completedFinishDate = plannedFinishDate;
                    else
                        completedFinishDate = dateTimeValue;
                    CompletedSeries.Points.Add(new SeriesPoint(point.Argument, new DateTime[] { plannedStartDate, completedFinishDate }));
                }
                CompletedSeries.Points.EndUpdate();
            }
            if(HasConstantLine)
                ProgressLine.AxisValue = dateTimeValue;
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            documentManager.View.Controller.Activate(documentGantt);
        }


    }
}
