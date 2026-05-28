using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler.iCalendar;

namespace DevExpress.XtraScheduler.Demos {
	public partial class iCalendarExchangeModule : DevExpress.XtraScheduler.Demos.TutorialControl {
		public iCalendarExchangeModule() {
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
        protected override int TakeScreenDelay => 300;
        protected bool IsCancelForRecurring { get { return ((UsedAppointmentType)cbCancelingTypes.EditValue).Equals(UsedAppointmentType.Recurring); } }
		protected bool IsCancelForNonRecurring { get { return ((UsedAppointmentType)cbCancelingTypes.EditValue).Equals(UsedAppointmentType.NonRecurring); } }

		void iCalendarExchangeModule_Load(object sender, EventArgs e) {
            CarsDataHelper.FillData(schedulerControl, schedulerStorage);
            cbCancelingTypes.EditValue = UsedAppointmentType.None;
            schedulerControl.DataStorage.EnableReminders = true;
        }

		void btnImport_Click(object sender, EventArgs e) {
            BeforeImportActions();
            using (Stream stream = CreateInputStream(txtICalendar.Text))
                ImportAppointments(stream);
            AfterImportActions();
            AfterExchangeActions();
		}

		void ImportAppointments(Stream stream) {
			if(stream == null)
				return;
			iCalendarImporter importer = new iCalendarImporter(schedulerStorage);
			importer.CalendarStructureCreated += new iCalendarStructureCreatedEventHandler(importer_CalendarStructureCreated);
			importer.AppointmentImporting += new AppointmentImportingEventHandler(importer_AppointmentImporting);
            importer.OnException += new ExchangeExceptionEventHandler(importer_OnException);
			importer.Import(stream);
		}
        void importer_OnException(object sender, ExchangeExceptionEventArgs e) {
            iCalendarParseExceptionEventArgs args = e as iCalendarParseExceptionEventArgs;
            if (args != null) {
                XtraMessageBox.Show(String.Format("Can't parse line '{1}' at {0} index", args.LineIndex, args.LineText));
                iCalendarImporter importer = (iCalendarImporter)sender;
                importer.Terminate();
            } 
            e.Handled = true;
        }
		void importer_AppointmentImporting(object sender, AppointmentImportingEventArgs e) {
			ProgressBarControl1.Position++;
			ProgressBarControl1.Update();
			bool cancel = e.Appointment.IsRecurring ? IsCancelForRecurring : IsCancelForNonRecurring;
			if(cancel) {
			    e.Cancel = true;
			}
		}
		void importer_CalendarStructureCreated(object sender, iCalendarStructureCreatedEventArgs e) {
			iCalendarImporter importer = (iCalendarImporter)sender;
			ProgressBarControl1.Position = 0;
			ProgressBarControl1.Properties.Maximum = importer.SourceObjectCount;
		}		
		void BeforeImportActions() {
			if (chkClearBeforImport.Checked)
				schedulerStorage.Appointments.Clear();
            txtICalendar.TextChanged -= new EventHandler(txtICalendar_TextChanged);
        }
        void AfterImportActions() {
            txtICalendar.TextChanged += new EventHandler(txtICalendar_TextChanged);
        }

        void txtICalendar_TextChanged(object sender, EventArgs e) {
            btnImport.Enabled = txtICalendar.Text.Length != 0 ? true : false;
        }

        public static Stream CreateInputStream(string text) {
            byte[] buf = Encoding.Unicode.GetBytes(text);
            return new MemoryStream(buf, 0, buf.Length);
        }
        void AfterExchangeActions() {
			ProgressBarControl1.Properties.Maximum = 100;
			ProgressBarControl1.Position = 0;
		}
        void btnExport_Click(Object sender, EventArgs e) {
            try {
                using(MemoryStream ms = new MemoryStream()) 
                    using(StreamReader sr = new StreamReader(ms)) {
                        ExportAppointments(ms);
                        ms.Seek(0, SeekOrigin.Begin);
                        txtICalendar.Text = sr.ReadToEnd();
                    }
            } catch {
                MessageBox.Show("Error: could not export appointments");
            } finally {
                AfterExchangeActions();
            }
        }
        void ExportAppointments(Stream stream) {
            if(stream == null)
                return;
            iCalendarExporter exporter = new iCalendarExporter(schedulerStorage);

            ProgressBarControl1.Properties.Maximum = exporter.SourceObjectCount;
            ProgressBarControl1.Position = 0;

            exporter.ProductIdentifier = "-//Developer Express Inc.//XtraScheduler iCalendarExchangeDemo//EN";
            exporter.AppointmentExporting += new AppointmentExportingEventHandler(exporter_AppointmentExporting);
            exporter.Export(stream);
        }
        void exporter_AppointmentExporting(object sender, AppointmentExportingEventArgs e) {
            ProgressBarControl1.Position++;
            ProgressBarControl1.Update();
            bool cancel = e.Appointment.IsRecurring ? IsCancelForRecurring : IsCancelForNonRecurring;
            if(cancel) {
                e.Cancel = true;
            }
        }
    }
}
