using System;
using DevExpress.XtraScheduler.Reporting;

namespace DevExpress.XtraScheduler.Demos.Reporting.AutoHeight
{
	/// <summary>
	/// Summary description for Report.
	/// </summary>
    public partial class TimelineReport : XtraSchedulerReport, IAutoHeightReport {


        public TimelineReport() {

            InitializeComponent();
        }
        public int VisibleResourceCount {
            get { return reportTimelineView1.VisibleResourceCount; }
            set { reportTimelineView1.VisibleResourceCount = value; }
        }
        public ControlContentLayoutType CellsLayoutType { get { return timelineCells.VerticalLayoutType; } set { timelineCells.VerticalLayoutType = value; } }
        public float CellsHeight { get { return timelineCells.HeightF; } set { timelineCells.HeightF = value; } }        
        public bool CellsCanShrink { get { return timelineCells.CanShrink; } set { timelineCells.CanShrink = value; } }
        public bool CellsCanGrow { get { return timelineCells.CanGrow; } set { timelineCells.CanGrow = value; } }
        public bool CompressWeekend { get { return false; } set { } }
    }
}
