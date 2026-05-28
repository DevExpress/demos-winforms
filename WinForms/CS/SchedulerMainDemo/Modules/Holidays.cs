using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Xml;
using DevExpress.XtraScheduler.Native;
using DevExpress.XtraScheduler.Drawing;
using DevExpress.Schedule;
using DevExpress.Schedule.Serializing;
using DevExpress.XtraScheduler.Internal;
using System.Collections;
using System.Linq;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraScheduler.Demos {
    public partial class HolidaysModule : DevExpress.XtraScheduler.Demos.TutorialControl {
        const string OutlookHolidaysFileName = "OUTLOOK.HOL";
        const string SchedulerHolidaysFileName = "holidays.xml";
        const string defaultLocationName = "united states";

        HolidayBaseCollection _allHolidays = new HolidayBaseCollection();


        public HolidaysModule() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            // TODO: Add any initialization after the InitializeComponent call
        }

        public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }
        protected HolidayBaseCollection AllHolidays { get { return _allHolidays; } }

        private void HolidaysModule_Load(object sender, EventArgs e) {
            string filePath = DemoUtils.GetFileRelativePath(SchedulerHolidaysFileName);
            ImportHolidaysFromXmlFile(filePath);
            UpdateControls();
            int defaultLocationIndex = Math.Max(0, clbLocations.FindStringExact(defaultLocationName));
            if (clbLocations.ItemCount >= 0) {
                clbLocations.SetItemChecked(defaultLocationIndex, true);
                GenerateHolidayAppointments(false);
            }
            this.schedulerControl.Start = FindNearHoliday();
            ActiveControl = this.clbLocations;
        }
        private void UpdateControls() {
            FillLocationListBox(SelectHolidayLocations(AllHolidays));
            FillHolidaysListBox(new List<HolidayListBoxItem>(0));
            UpdateStatusLabel(0, 0);
        }
        string[] SelectHolidayLocations(HolidayBaseCollection holidays) {
            List<string> locations = new List<string>();
            foreach (Holiday item in holidays) {
                if (!locations.Contains(item.Location))
                    locations.Add(item.Location);
            }
            return locations.ToArray();
        }
        void FillLocationListBox(string[] locations) {
            clbLocations.Items.BeginUpdate();
            try {
                clbLocations.Items.Clear();
                for (int i = 0; i < locations.Length; i++)
                    clbLocations.Items.Add(locations[i], false);
                clbLocations.SelectedIndex = 0;
            } finally {
                clbLocations.Items.EndUpdate();
            }
        }
        List<HolidayListBoxItem> CreateListBoxData(HolidayBaseCollection items) {
            List<HolidayListBoxItem> data = new List<HolidayListBoxItem>();
            for (int i = 0; i < items.Count; i++) {
                data.Add(new HolidayListBoxItem(items[i]));
            }
            return data;
        }
        void FillHolidaysListBox(List<HolidayListBoxItem> data) {
            lbHolidays.Items.BeginUpdate();
            try {
                lbHolidays.DataSource = data;
                lbHolidays.DisplayMember = "DisplayText";
            } finally {
                lbHolidays.Items.EndUpdate();
            }
        }
        void UpdateStatusLabel(int holidayCount, int locationCount) {
            lblStatus.Text = String.Format("Loaded {0} holiday(s) for {1} location(s)", holidayCount, locationCount);
        }
        private void clbLocations_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e) {
            List<string> locations = GetSelectedLocations();
            HolidayBaseCollection holidays = GetSelectedHolidays(locations);

            AddHolidaysToScheduler(holidays);
            FillHolidaysListBox(CreateListBoxData(holidays));
            UpdateStatusLabel(holidays.Count, locations.Count);
        }
        HolidayBaseCollection GetSelectedHolidays(List<string> locations) {
            HolidayBaseCollection result = new HolidayBaseCollection();
            if (locations.Count == 0)
                return result;

            foreach (Holiday item in AllHolidays) {
                if (locations.Contains(item.Location))
                    result.Add(item);
            }
            return result;
        }
        List<string> GetSelectedLocations() {
            List<string> result = new List<string>();
            for (int i = 0; i < clbLocations.Items.Count; i++) {
                CheckedListBoxItem item = clbLocations.Items[i];
                if (item.CheckState == CheckState.Checked)
                    result.Add(item.Value.ToString());
            }
            return result;
        }
        private void lbHolidays_DoubleClick(object sender, EventArgs e) {
            HolidayListBoxItem item = lbHolidays.SelectedItem as HolidayListBoxItem;
            if (item != null) {
                schedulerControl.GoToDate(item.Holiday.Date);
            }
        }
        private void AddHolidaysToScheduler(HolidayBaseCollection items) {
            schedulerControl.BeginUpdate();
            try {
                schedulerControl.WorkDays.Clear();
                schedulerControl.WorkDays.Add(WeekDays.WorkDays);
                schedulerControl.WorkDays.AddRange(items);
            } finally {
                schedulerControl.EndUpdate();
            }
        }
        private void btnGenerate_Click(object sender, EventArgs e) {
            GenerateHolidayAppointments(true);
        }
        private void GenerateHolidayAppointments(bool showMessage) {
            if (chkClearBeforGenerate.Checked)
                schedulerDataStorage.Appointments.Clear();
            AppointmentBaseCollection apts = HolidaysHelper.GenerateHolidayAppointments(schedulerDataStorage, schedulerControl.WorkDays);
            schedulerDataStorage.Appointments.Items.AddRange(apts);
            if (showMessage)
                XtraMessageBox.Show(String.Format("{0} appointment(s) were added", apts.Count), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnImportFromXml_Click(object sender, EventArgs e) {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Scheduler holidays files (*.xml)|*.xml|All files (*.*)|*.*";
            dlg.FilterIndex = 1;
            dlg.FileName = SchedulerHolidaysFileName;
            string filePath = DemoUtils.GetFileRelativePath(SchedulerHolidaysFileName);
            dlg.InitialDirectory = new FileInfo(filePath).DirectoryName;
            dlg.DefaultExt = "*.xml";
            dlg.CheckFileExists = true;

            if (dlg.ShowDialog() == DialogResult.OK) {
                ImportHolidaysFromXmlFile(dlg.FileName);
                UpdateControls();
            }
        }
        private void ImportHolidaysFromXmlFile(string path) {
            if (!File.Exists(path))
                return;
            XmlDocument doc = new XmlDocument();
            doc.Load(Path.GetFullPath(path));
            this._allHolidays = HolidayCollectionXmlPersistenceHelper.ObjectFromXml(doc.OuterXml);
        }

        DateTime FindNearHoliday() {
            DateTime now = TutorialConstants.Today;
            IEnumerable<Holiday> holidays = this.schedulerControl.WorkDays.OfType<Holiday>().Where(hol => hol.Date >= now);
            if (holidays.Count() == 0)
                return now;
            TimeSpan minDistance = holidays.Min(hol => (hol.Date - now).Duration());
            return holidays.First(hol => (hol.Date - now).Duration() == minDistance).Date;
        }

        private void btnImportFromOutlook_Click(object sender, EventArgs e) {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Microsoft Office Outlook Holidays files (*.hol)|*.hol|Text files (*.txt)|*.txt|All files (*.*)|*.*";
            dlg.FilterIndex = 1;
            dlg.FileName = OutlookHolidaysFileName;
            dlg.DefaultExt = "*.hol";
            dlg.CheckFileExists = true;

            if (dlg.ShowDialog() == DialogResult.OK) {
                ImportHolidaysFromOutlookFile(dlg.FileName);
                UpdateControls();
            }
        }
        void ImportHolidaysFromOutlookFile(string path) {
            if (!File.Exists(path))
                return;

            OutlookHolidaysLoader loader = new OutlookHolidaysLoader();
            this._allHolidays = loader.FromFile(path);
        }

        private void schedulerControl_LayoutViewInfoCustomizing(object sender, LayoutViewInfoCustomizingEventArgs e) {
            SchedulerHeader header = null;
            if (e.Kind == LayoutElementKind.DateHeader && schedulerControl.ActiveViewType != SchedulerViewType.Month)
                header = (SchedulerHeader)e.ViewInfo;
            if (e.Kind == LayoutElementKind.Cell && schedulerControl.ActiveViewType == SchedulerViewType.Month)
                header = ((SingleWeekCellBase)e.ViewInfo).Header;

            if (header != null) {
                Holiday hol = FindHoliday(header.Interval.Start.Date);
                if (hol != null) {
                    header.Caption = String.Format("{0} ({1})", hol.DisplayName, hol.Location);
                    header.Appearance.HeaderCaption.ForeColor = Color.Red;
                    header.Appearance.AlternateHeaderCaption.ForeColor = Color.Red;
                    header.ToolTipText = header.Caption;
                    header.ShouldShowToolTip = true;
                }
            }
        }

        // This method finds a holiday for the specified date.
        private Holiday FindHoliday(DateTime date) {
            foreach (WorkDay item in this.schedulerControl.WorkDays) {
                if (item is Holiday) {
                    Holiday hol = (Holiday)item;
                    if (hol.Date == date)
                        return hol;
                }
            }
            return null;
        }

    }

    #region HolidayListBoxItem class
    public class HolidayListBoxItem {
        Holiday _holiday;
        public HolidayListBoxItem(Holiday holiday) {
            this._holiday = holiday;
        }
        public Holiday Holiday { get { return _holiday; } }
        public string DisplayText { get { return String.Format("{0} ({1}) {2}", _holiday.DisplayName, _holiday.Location, _holiday.Date.ToShortDateString()); } }
    }
    #endregion
}
