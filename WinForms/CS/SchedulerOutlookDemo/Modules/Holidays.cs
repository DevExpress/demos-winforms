using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using DevExpress.LookAndFeel;
using DevExpress.Schedule;
using DevExpress.Schedule.Serializing;
using DevExpress.Utils;
using DevExpress.Utils.Colors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraScheduler.Demos.DemoData;
using DevExpress.XtraScheduler.Drawing;

namespace DevExpress.XtraScheduler.Demos {
    public partial class HolidaysModule : TutorialControl {
        const string OutlookHolidaysFileName = "OUTLOOK.HOL";
        const string SchedulerHolidaysFileName = "holidays.xml";
        const string defaultLocationName = "united states";

        HolidayBaseCollection _allHolidays = new HolidayBaseCollection();
        public HolidaysModule() {
            InitializeComponent();            
        }

        protected override IEnumerable<string> GetGlobalOptionIgnoreList() {
            return new string[] { "WorkDays" };
        }

        public override SchedulerControl Scheduler { get { return this.schedulerControl; } }
        protected override Control OptionsPane { get { return this.spOptionPane; } }
        protected HolidayBaseCollection AllHolidays { get { return this._allHolidays; } }

        void HolidaysModule_Load(object sender, EventArgs e) {
            Scheduler.Start = SchedulerDataHelper.Start;
            SchedulerDataHelper.Attach(Scheduler);
            string filePath = DemoUtils.GetFileRelativePath(SchedulerHolidaysFileName);
            ImportHolidaysFromXmlFile(filePath);
            UpdateControls();
            int defaultLocationIndex = Math.Max(0, this.clbLocations.FindStringExact(defaultLocationName));
            if (this.clbLocations.ItemCount >= 0)
                this.clbLocations.SetItemChecked(defaultLocationIndex, true);                
            ActiveControl = this.clbLocations;
        }

        void UpdateControls() {
            FillLocationListBox(SelectHolidayLocations(AllHolidays));
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
            this.clbLocations.Items.BeginUpdate();
            try {
                this.clbLocations.Items.Clear();
                for (int i = 0; i < locations.Length; i++)
                    this.clbLocations.Items.Add(locations[i], false);
                this.clbLocations.SelectedIndex = 0;
            } finally {
                this.clbLocations.Items.EndUpdate();
            }
        }

        void clbLocations_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e) {
            List<string> locations = GetSelectedLocations();
            HolidayBaseCollection holidays = GetSelectedHolidays(locations);
            AddHolidaysToScheduler(holidays);
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
            for (int i = 0; i < this.clbLocations.Items.Count; i++) {
                CheckedListBoxItem item = this.clbLocations.Items[i];
                if (item.CheckState == CheckState.Checked)
                    result.Add(item.Value.ToString());
            }
            return result;
        }
                
        void AddHolidaysToScheduler(HolidayBaseCollection items) {
            this.schedulerControl.BeginUpdate();
            try {
                this.schedulerControl.WorkDays.Clear();
                this.schedulerControl.WorkDays.Add(WeekDays.WorkDays);
                this.schedulerControl.WorkDays.AddRange(items);
            } finally {
                this.schedulerControl.EndUpdate();
            }
        }

        void btnImportFromXml_Click(object sender, EventArgs e) {
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

        void ImportHolidaysFromXmlFile(string path) {
            if (!File.Exists(path))
                return;
#if NET
            path = Path.GetFullPath(path);
#endif
            XmlDocument doc = SafeXml.CreateDocument(File.ReadAllText(path));
            this._allHolidays = HolidayCollectionXmlPersistenceHelper.ObjectFromXml(doc.OuterXml);
        }
        
        void btnImportFromOutlook_Click(object sender, EventArgs e) {
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

        void schedulerControl_LayoutViewInfoCustomizing(object sender, LayoutViewInfoCustomizingEventArgs e) {
            SchedulerHeader header = null;
            if (e.Kind == LayoutElementKind.DateHeader && Scheduler.ActiveViewType != SchedulerViewType.Month)
                header = (SchedulerHeader)e.ViewInfo;
            if (e.Kind == LayoutElementKind.Cell && Scheduler.ActiveViewType == SchedulerViewType.Month)
                header = ((SingleWeekCellBase)e.ViewInfo).Header;

            if (header != null) {
                Holiday hol = FindHoliday(header.Interval.Start.Date);
                if (hol != null) {
                    header.Caption = "Holiday";
                    Color primaryColor = DXSkinColorHelper.GetDXSkinColor(DXSkinColors.FillColors.Primary, LookAndFeel);
                    header.Appearance.HeaderCaption.ForeColor = primaryColor;
                    header.Appearance.AlternateHeaderCaption.ForeColor = primaryColor;
                    header.Appearance.HeaderCaption.TextOptions.HAlignment = HorzAlignment.Center;
                    header.ToolTipText = String.Format("{0} ({1})", hol.DisplayName, hol.Location);
                    header.ShouldShowToolTip = true;
                }
            }
        }

        // This method finds a holiday for the specified date.
        Holiday FindHoliday(DateTime date) {
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

    public class HolidayListBoxItem {
        Holiday _holiday;
        public HolidayListBoxItem(Holiday holiday) {
            this._holiday = holiday;
        }
        public Holiday Holiday {
            get { return this._holiday; }
        }
        public string DisplayText {
            get { return String.Format("{0} ({1}) {2}", this._holiday.DisplayName, this._holiday.Location, this._holiday.Date.ToShortDateString()); }
        }
    }
}
