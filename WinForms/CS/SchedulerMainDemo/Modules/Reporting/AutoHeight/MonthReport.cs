using System;
using DevExpress.XtraScheduler.Reporting;

namespace DevExpress.XtraScheduler.Demos.Reporting.AutoHeight {
	/// <summary>
	/// Summary description for Report.
	/// </summary>
    public partial class MonthReport : XtraSchedulerReport, IAutoHeightReport {

        public MonthReport() {
            InitializeComponent();
        }

        public bool CompressWeekend { get { return horizontalWeek.CompressWeekend; } set { horizontalWeek.CompressWeekend = value; } }
        public ControlContentLayoutType CellsLayoutType { get { return horizontalWeek.VerticalLayoutType; } set { horizontalWeek.VerticalLayoutType = value; } }
        public float CellsHeight { get { return horizontalWeek.HeightF; } set { horizontalWeek.HeightF = value; } }        
        public bool CellsCanShrink { get { return horizontalWeek.CanShrink; } set { horizontalWeek.CanShrink = value; } }
        public bool CellsCanGrow { get { return horizontalWeek.CanGrow; } set { horizontalWeek.CanGrow = value; } }
	}
}
