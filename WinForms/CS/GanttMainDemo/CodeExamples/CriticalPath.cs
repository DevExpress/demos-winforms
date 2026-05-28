namespace Examples {
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using DevExpress.DXperience.Demos.CodeDemo;
    using DevExpress.DXperience.Demos.CodeDemo.Data;
    using DevExpress.LookAndFeel;
    using DevExpress.XtraEditors;
    using DevExpress.XtraGantt;
    using DevExpress.Utils.Menu;
    using DevExpress.Utils;
    using DevExpress.Utils.Svg;
    using Examples;
    using DevExpress.XtraGantt.Scheduling;

    [CodeExampleClass("Critical Path", "CriticalPath.cs")]
    public class Format {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            GanttControl ganttControl = new GanttControl();
            ganttControl.OptionsBehavior.Editable = false;
            ganttControl.Dock = DockStyle.Fill;
            ganttControl.Parent = sampleHost;
            ganttControl.TreeListMappings.KeyFieldName = "Id";
            ganttControl.TreeListMappings.ParentFieldName = "ParentId";
            ganttControl.ChartMappings.TextFieldName = "Name";
            ganttControl.ChartMappings.StartDateFieldName = "StartTime";
            ganttControl.ChartMappings.FinishDateFieldName = "EndTime";
            ganttControl.ChartMappings.ProgressFieldName = "Progress";
            ganttControl.ChartMappings.PredecessorsFieldName = "PredecessorIDs";
            ganttControl.DataSource = Task.GetData();
            for(int i = 0; i < 7; i++)
                ganttControl.WorkWeek.Add(new WorkDayOfWeek((DayOfWeek) i, new List<WorkTime>() {new WorkTime(TimeSpan.FromHours(0), TimeSpan.FromHours(24))}));
            ganttControl.Load += (s, e) => ganttControl.ExpandAll();
            return new object[] {ganttControl};
        }
        [CodeExampleCase("Show a critical path")]
        [CodeExampleUnderlineTokens("OptionsView", "CriticalPathTask", "CriticalPathDependency")]
        public static void ShowCriticalPath(GanttControl ganttControl) {
            ganttControl.OptionsView.CriticalPathHighlightMode = CriticalPathHighlightMode.Single;
            ganttControl.Appearance.CriticalPathTask.BackColor = DXSkinColors.FillColors.Danger;
            ganttControl.Appearance.CriticalPathDependency.BackColor = DXSkinColors.FillColors.Danger;
        }
        [CodeExampleCase("Show multiple critical paths")]
        [CodeExampleUnderlineTokens("OptionsView", "CriticalPathTask", "CriticalPathDependency")]
        public static void ShowMultipleCriticalPaths(GanttControl ganttControl) {
            ganttControl.OptionsView.CriticalPathHighlightMode = CriticalPathHighlightMode.Multiple;
            ganttControl.Appearance.CriticalPathTask.BackColor = DXSkinColors.FillColors.Danger;
            ganttControl.Appearance.CriticalPathDependency.BackColor = DXSkinColors.FillColors.Danger;
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
            sampleHost.Controls.Clear();
        }
    }
}
