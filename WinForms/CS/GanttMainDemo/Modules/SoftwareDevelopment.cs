using System;
using System.Collections.Generic;
using System.Drawing;
using System.Xml.Serialization;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGantt.Base.Scheduling;
using DevExpress.XtraGantt.Exceptions;
using DevExpress.XtraGantt.Options;
using DevExpress.XtraGantt.Scheduling;
using DevExpress.XtraPrinting;

namespace DevExpress.XtraGantt.Demos {
    public partial class SoftwareDevelopment : TutorialControl {
        string[] constraintStrings;
        bool toolTipVisible = false;
        bool lockUpdate = false;
        public SoftwareDevelopment() {
            InitializeComponent();
            InitConstraintStrings();
            Init();
            // <ganttControl1>
            ganttControl1.TreeListMappings.ParentFieldName = "ParentUID";
            ganttControl1.TreeListMappings.KeyFieldName = "UID";
            ganttControl1.ChartMappings.TextFieldName = "Resources";
            ganttControl1.ChartMappings.InteractionTooltipTextFieldName = "Name";
            ganttControl1.ChartMappings.DurationFieldName = "Duration";
            LoadDataSource();
            ganttControl1.ExpandAll();
            ganttControl1.Exceptions.AddRange(CreateExceptionRules());
            // </ganttControl1>
        }
        void InitConstraintStrings() {
            constraintStrings = new string[8];
            constraintStrings[0] = "As soon as possible";
            constraintStrings[1] = "As late as possible";
            constraintStrings[2] = "Start no earlier than";
            constraintStrings[3] = "Start no later than";
            constraintStrings[4] = "Finish no earlier than";
            constraintStrings[5] = "Finish no later than";
            constraintStrings[6] = "Must start on";
            constraintStrings[7] = "Must finish on";
        }
        public override bool AllowShowCriticalPath {
            get { return true; }
        }
        void LoadDataSource() {
            using(var stream = LoadXml("SoftwareDevelopmentPlan.xml")) {
                IList<TaskDataItem> tasks = ProjectXMLLoader.LoadModel(stream);
                if(tasks != null && tasks.Count > 0) {
                    ProjectXMLLoader.TryUpdateDates(tasks);
                    ganttControl1.DataSource = tasks;
                    ganttControl1.ScheduleFromStartDate(tasks[0].StartDate);
                }
            }
        }
        void Init() {
            icbSchedulingMode.Properties.Items.Add(new ImageComboBoxItem("Default", ScheduleMode.Default, -1));
            icbSchedulingMode.Properties.Items.Add(new ImageComboBoxItem("AutoScheduled", ScheduleMode.Auto, -1));
            icbSchedulingMode.Properties.Items.Add(new ImageComboBoxItem("ManuallyScheduled", ScheduleMode.Manual, -1));
            icbSchedulingMode.EditValue = ganttControl1.OptionsBehavior.ScheduleMode;
            icbTooltipLocation.Properties.Items.Add(new ImageComboBoxItem("Default", InteractionTooltipLocation.Default, -1));
            icbTooltipLocation.Properties.Items.Add(new ImageComboBoxItem("TopLeft", InteractionTooltipLocation.TopLeft, -1));
            icbTooltipLocation.Properties.Items.Add(new ImageComboBoxItem("TopRight", InteractionTooltipLocation.TopRight, -1));
            icbTooltipLocation.Properties.Items.Add(new ImageComboBoxItem("BottomLeft", InteractionTooltipLocation.BottomLeft, -1));
            icbTooltipLocation.Properties.Items.Add(new ImageComboBoxItem("BottomRight", InteractionTooltipLocation.BottomRight, -1));
            icbTooltipLocation.Properties.Items.Add(new ImageComboBoxItem("None", InteractionTooltipLocation.None, -1));
            icbTooltipLocation.EditValue = ganttControl1.OptionsView.InteractionTooltipLocation;
            ceAllowModifyTasks.Checked = ganttControl1.OptionsCustomization.AllowModifyTasks != DefaultBoolean.False;
            ceAllowModifyDependencies.Checked = ganttControl1.OptionsCustomization.AllowModifyDependencies != DefaultBoolean.False;
            ceAllowModifyProgress.Checked = ganttControl1.OptionsCustomization.AllowModifyProgress != DefaultBoolean.False;
            ganttControl1.OptionsView.CriticalPathHighlightMode = CriticalPathHighlightMode.Single;
            ganttControl1.OptionsTimeline.TimelinePosition = TimelinePosition.Bottom;
            cpeCriticalPathTasks.Color = DXSkinColors.FillColors.Danger;
            cpeCriticalPathDependencies.Color = DXSkinColors.FillColors.Danger;
        }
        void cpeCriticalPathTasks_EditValueChanged(object sender, EventArgs e) {
            ganttControl1.Appearance.CriticalPathTask.BackColor = cpeCriticalPathTasks.Color;
            ganttControl1.AppearancePrint.CriticalPathTask.BackColor = cpeCriticalPathTasks.Color;
        }
        void cpeCriticalPathDependencies_EditValueChanged(object sender, EventArgs e) {
            ganttControl1.Appearance.CriticalPathDependency.BackColor = cpeCriticalPathDependencies.Color;
            ganttControl1.AppearancePrint.CriticalPathDependency.BackColor = cpeCriticalPathDependencies.Color;
        }
        ExceptionRule[] CreateExceptionRules() {
            YearlyExceptionRule NewYearDay = new YearlyExceptionRule() {
                DayOfMonth = 1,
                Month = Month.January
            };
            YearlyDayOfWeekExceptionRule MartinLutherDay = new YearlyDayOfWeekExceptionRule() {
                DayOfWeek = DayOfWeek.Monday,
                Month = Month.January,
                WeekOfMonth = WeekOfMonth.Third
            };
            YearlyDayOfWeekExceptionRule PresidentDay = new YearlyDayOfWeekExceptionRule() {
                DayOfWeek = DayOfWeek.Monday,
                Month = Month.February,
                WeekOfMonth = WeekOfMonth.Third
            };
            YearlyDayOfWeekExceptionRule MemorialDay = new YearlyDayOfWeekExceptionRule() {
                DayOfWeek = DayOfWeek.Monday,
                Month = Month.May,
                WeekOfMonth = WeekOfMonth.Last
            };
            YearlyExceptionRule IndependenceDay = new YearlyExceptionRule() {
                DayOfMonth = 4,
                Month = Month.July
            };
            YearlyDayOfWeekExceptionRule LaborDay = new YearlyDayOfWeekExceptionRule() {
                DayOfWeek = DayOfWeek.Monday,
                Month = Month.September,
                WeekOfMonth = WeekOfMonth.First
            };
            YearlyDayOfWeekExceptionRule ColumbusDay = new YearlyDayOfWeekExceptionRule() {
                DayOfWeek = DayOfWeek.Monday,
                Month = Month.October,
                WeekOfMonth = WeekOfMonth.Second
            };
            YearlyExceptionRule VeteransDay = new YearlyExceptionRule() {
                DayOfMonth = 11,
                Month = Month.November
            };
            YearlyDayOfWeekExceptionRule ThanksgivingDay = new YearlyDayOfWeekExceptionRule() {
                DayOfWeek = DayOfWeek.Thursday,
                Month = Month.November,
                WeekOfMonth = WeekOfMonth.Forth
            };
            YearlyExceptionRule ChristmasDay = new YearlyExceptionRule() {
                DayOfMonth = 25,
                Month = Month.December
            };
            return new ExceptionRule[] {
                NewYearDay,
                MartinLutherDay,
                PresidentDay,
                MemorialDay,
                IndependenceDay,
                LaborDay,
                ColumbusDay,
                VeteransDay,
                ThanksgivingDay,
                ChristmasDay
            };
        }

        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "SoftwareDevelopment" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "softwareDevelopment"; }
        }

        public override GanttControl MainControl {
            get { return ganttControl1; }
        }
        public override bool AllowPrintOptions {
            get { return true; }
        }
        public override bool AllowGenerateReport {
            get { return false; }
        }

        void icbSchedulingMode_SelectedIndexChanged(object sender, System.EventArgs e) {
            ganttControl1.OptionsBehavior.ScheduleMode = (ScheduleMode)icbSchedulingMode.EditValue;
        }

        void icbTooltipLocation_SelectedIndexChanged(object sender, System.EventArgs e) {
            ganttControl1.OptionsView.InteractionTooltipLocation = (InteractionTooltipLocation)icbTooltipLocation.EditValue;
        }

        void ceAllowModifyTasks_CheckedChanged(object sender, System.EventArgs e) {
            ganttControl1.OptionsCustomization.AllowModifyTasks = ceAllowModifyTasks.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        }

        void ceAllowModifyDependencies_CheckedChanged(object sender, EventArgs e) {
            ganttControl1.OptionsCustomization.AllowModifyDependencies = ceAllowModifyDependencies.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        }
        void ceAllowModifyProgress_CheckedChanged(object sender, EventArgs e) {
            ganttControl1.OptionsCustomization.AllowModifyProgress = ceAllowModifyProgress.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        }
        private void constraintTypeComboBox_EditValueChanged(object sender, EventArgs e) {
            if(ganttControl1.FocusedNode == null || lockUpdate)
                return;
            ganttControl1.FocusedNode[ganttControl1.ChartMappings.ConstraintTypeFieldName] = constraintTypeComboBox.SelectedIndex;
        }
        private void constraintDateEdit_EditValueChanged(object sender, EventArgs e) {
            if(ganttControl1.FocusedNode == null || lockUpdate)
                return;
            ganttControl1.FocusedNode[ganttControl1.ChartMappings.ConstraintDateFieldName] = constraintDateEdit.DateTime;
        }
        private void ganttControl1_FocusedNodeChanged(object sender, XtraTreeList.FocusedNodeChangedEventArgs e) {
            if(e.Node == null)
                return;
            lockUpdate = true;
            constraintTypeComboBox.SelectedIndex = (int)e.Node[ganttControl1.ChartMappings.ConstraintTypeFieldName];
            constraintDateEdit.EditValue = (DateTime?)e.Node[ganttControl1.ChartMappings.ConstraintDateFieldName];
            lockUpdate = false;
        }
        private void ganttControl1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e) {
            var hitInfo = ganttControl1.CalcHitInfo(e.Location);
            if(hitInfo.TreeListHitTest != null && hitInfo.TreeListHitTest.Column == constraintTypeColumn && hitInfo.TreeListHitTest.InRowCell) {
                var node = hitInfo.TreeListHitTest.Node;
                int index = (int)node[ganttControl1.ChartMappings.ConstraintTypeFieldName];
                if(index > 0) {
                    string toolTipText = constraintStrings[index];
                    var date = (DateTime?)node[ganttControl1.ChartMappings.ConstraintDateFieldName];
                    if(date != null)
                        toolTipText += " " + date.Value.Day + "/" + date.Value.Month + "/" + date.Value.Year;
                    if(!toolTipVisible) {
                        toolTipController1.ShowHint(toolTipText, ganttControl1.PointToScreen(e.Location));
                        toolTipVisible = true;
                    }
                    return;
                }
            }
            toolTipVisible = false;
            toolTipController1.HideHint();
        }
        private void ganttControl1_CellValueChanged(object sender, XtraTreeList.CellValueChangedEventArgs e) {
            lockUpdate = true;
            if(e.Column == constraintTypeColumn)
                constraintTypeComboBox.SelectedIndex = (int)e.Node[ganttControl1.ChartMappings.ConstraintTypeFieldName];
            if(e.Column == constraintDateColumn)
                constraintDateEdit.EditValue = (DateTime?)e.Node[ganttControl1.ChartMappings.ConstraintDateFieldName];
            lockUpdate = false;
        }
    }
}
