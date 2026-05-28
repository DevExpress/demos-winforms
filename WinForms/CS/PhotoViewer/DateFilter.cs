using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;

namespace PhotoViewer {
    public partial class DateFilter : XtraUserControl {
        private static readonly object _selectionChanged = new object();
        public DateFilter() {
            InitializeComponent();
            calendarStartDate.SizeChanged += startDate_SizeChanged;
        }

        void startDate_SizeChanged(object sender, EventArgs e) {
            UpdateStartDateLocation();
        }
        protected virtual void UpdateStartDateLocation() {
            Point pt = new Point(DisplayRectangle.X + (DisplayRectangle.Width - calendarStartDate.Width) / 2, DisplayRectangle.Y + (panel1.Top - DisplayRectangle.Y - calendarStartDate.Height) / 2);
            pt.X = Math.Max(0, pt.X);
            pt.Y = Math.Max(0, pt.Y);
            calendarStartDate.Location = pt;
        }
        protected override void OnSizeChanged(EventArgs e) {
            base.OnSizeChanged(e);
            UpdateStartDateLocation();
        }

        public DateTime StartDate { get { return allowFilterCheck.Checked ? calendarStartDate.SelectionStart: DateTime.MinValue; } }
        public DateTime EndDate { get { return allowFilterCheck.Checked ? calendarStartDate.SelectionEnd : DateTime.MinValue; } }
        public bool AllowFilter { get { return allowFilterCheck.Checked; } }

        protected void RaiseSelectionChanged() {
            EventHandler handler = Events[_selectionChanged] as EventHandler;
            if(handler != null)
                handler(this, EventArgs.Empty);
        }
        public event EventHandler SelectionChanged {
            add { Events.AddHandler(_selectionChanged, value); }
            remove { Events.RemoveHandler(_selectionChanged, value); }
        }

        private void allowFilterCheck_CheckedChanged(object sender, EventArgs e) {
            RaiseSelectionChanged();
        }

        private void startDate_SelectionChanged(object sender, EventArgs e) {
            RaiseSelectionChanged();
        }

        private void endDate_SelectionChanged(object sender, EventArgs e) {
            RaiseSelectionChanged();
        }
    }
}
