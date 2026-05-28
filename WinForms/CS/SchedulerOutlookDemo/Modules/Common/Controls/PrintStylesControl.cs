using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevExpress.XtraScheduler.Demos {
    public partial class PrintStylesControl : UserControl {
        Action<ReportType> action;
        List<CheckButton> buttons;

        public PrintStylesControl() {
            InitializeComponent();
            this.buttons = new List<CheckButton>();
            RegisterButton(this.btnCalendarDetailsStyle, ReportType.CalendarDetailsStyle);
            RegisterButton(this.btnCalendarDetailsStyle, ReportType.CalendarDetailsStyle);
            RegisterButton(this.btnDailyStyle, ReportType.DailyStyle);
            RegisterButton(this.btnMonthlyCalendarStyle, ReportType.MonthlyCalendarStyle);
            RegisterButton(this.btnWeeklyAgendaStyle, ReportType.WeeklyAgendaStyle);
            RegisterButton(this.btnWeeklyCalendarStyle, ReportType.WeeklyCalendarStyle);
            RegisterButton(this.btnTriFoldStyle, ReportType.TriFoldStyle);
        }

        public PrintStylesControl(Action<ReportType> action, ReportType type) : this() {
            foreach (var button in this.buttons)
                if ((ReportType)button.Tag == type) {
                    button.Checked = true;
                    break;
                }
            this.action = action;
        }

        void RegisterButton(CheckButton button, ReportType type) {
            this.buttons.Add(button);
            button.Tag = type;
            button.CheckedChanged += OnButtonCheckedChanged;
        }

        void OnButtonCheckedChanged(object sender, EventArgs e) {
            CheckButton button = (CheckButton)sender;
            if (!button.Checked)
                return;
            if (this.action == null)
                return;
            this.action((ReportType)button.Tag);
        }
    }
    public enum ReportType { CalendarDetailsStyle, DailyStyle, MonthlyCalendarStyle, WeeklyAgendaStyle, WeeklyCalendarStyle, TriFoldStyle }
}
