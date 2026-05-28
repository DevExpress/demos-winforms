using System;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using DevExpress.Xpo;
using DevExpress.XtraScheduler.Exchange;
using DevExpress.XtraScheduler.Outlook;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraScheduler.Demos {
	public partial class OutlookImportModule : DevExpress.XtraScheduler.Demos.TutorialControl {
		public OutlookImportModule() {
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}

		public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }
		protected bool IsCancelForRecurring { get { return ((UsedAppointmentType)cbCancelingTypes.EditValue).Equals(UsedAppointmentType.Recurring); } }
		protected bool IsCancelForNonRecurring { get { return ((UsedAppointmentType)cbCancelingTypes.EditValue).Equals(UsedAppointmentType.NonRecurring); } }
        protected string CalendarName { get { return this.cbCalendarFolderPaths.Text; } }

		private void OutlookImportModule_Load(object sender, EventArgs e) {
			schedulerControl.Start = TutorialConstants.Today;
			UpdateControls();
		}
		private void OutlookImportModule_VisibleChanged(object sender, EventArgs e) {
			if (Visible) {
				xpCollectionEvents.Session.DropIdentityMap();
				xpCollectionEvents.Reload();
			}
		}
		private void UpdateControls() {
			cbCancelingTypes.EditValue = UsedAppointmentType.None;
            FillCalendarNamesCombo();
		}
        private void FillCalendarNamesCombo() {
            cbCalendarFolderPaths.Properties.BeginUpdate();
            try {
                cbCalendarFolderPaths.Properties.Items.Clear();
				cbCalendarFolderPaths.Properties.Items.AddRange(DemoUtils.OutlookCalendarPaths);
            } finally {
                cbCalendarFolderPaths.Properties.EndUpdate();
                cbCalendarFolderPaths.SelectedIndex = 0;
            }
        }
		private void schedulerStorage_AppointmentsChanged(object sender, PersistentObjectsEventArgs e) {
			session1.BeginTransaction();
			try {
				foreach (Appointment apt in e.Objects) {
					XPBaseObject o = apt.GetSourceObject(schedulerStorage) as XPBaseObject;
					if (o != null)
						o.Save();
				}
				session1.CommitTransaction();
			}
			catch {
				session1.RollbackTransaction();
			}
		}

		#region supplementary functionality
		void AddToLog(string s) {
			this.lbcLog.Items.Add(s);
		}
		void SuspendLog() {
			this.lbcLog.Items.BeginUpdate();
		}
		void ResumeLog() {
			this.lbcLog.SelectedIndex = this.lbcLog.Items.Count - 1;
			this.lbcLog.Items.EndUpdate();
		}
		void ClearLog() {
			this.lbcLog.Items.Clear();
		}
		void BeforeImport(int objectCount) {
            AddToLog(String.Format("{0} - Start importing from '{1}' calendar...", TutorialConstants.Now.ToLongTimeString(), CalendarName));
			Application.DoEvents();
			SuspendLog();
			ProgressBarControl1.Position = 0;
			ProgressBarControl1.Properties.Maximum = objectCount;
		}
		void AfterImport() {
            AddToLog(String.Format("{0} - Import complete!", TutorialConstants.Now.ToLongTimeString()));
			AddToLog(new string('-', 60));
			ResumeLog();
			ProgressBarControl1.Properties.Maximum = 100;
			ProgressBarControl1.Position = 0;
		}
		string CreateImportLogString(AppointmentImportingEventArgs e) {
			OutlookAppointmentImportingEventArgs args = (OutlookAppointmentImportingEventArgs)e;
			return String.Format("Trying to import: apt={0}, olApt={1} ...",
				DemoUtils.FormatAppointmentString(args.Appointment), DemoUtils.FormatOutlookAppointmentString(args.OutlookAppointment));
		}
		#endregion

		private void btnClearLog_Click(object sender, EventArgs e) {
			ClearLog();

		}
		private void btnImport_Click(object sender, EventArgs e) {
            try {
                Import();
            } catch(Exception ex) {
                DemoUtils.ReportOutlookError("import appointments from Microsoft Outlook", ex.Message);
            }
		}
		void Import() {
			AppointmentImporter importer = schedulerStorage.CreateOutlookImporter();
            ((ISupportCalendarFolders)importer).CalendarFolderName = CalendarName;
			importer.AppointmentImporting += new AppointmentImportingEventHandler(importer_AppointmentImporting);
			importer.AppointmentImported += new AppointmentImportedEventHandler(importer_AppointmentImported);
            importer.OnException += new ExchangeExceptionEventHandler(importer_OnException);

			Cursor oldCur = Cursor.Current;
			Cursor.Current = Cursors.WaitCursor;
			BeforeImport(importer.SourceObjectCount);
			try {
                importer.Import(System.IO.Stream.Null);
            }
			finally {
				AfterImport();
				Cursor.Current = oldCur;
			}
		}

        void importer_OnException(object sender, ExchangeExceptionEventArgs e) {
            string errText = e.OriginalException.Message;
            bool canTerminate = true;
            OutlookExchangeChangedOccurrenceExceptionEventArgs occurrenceArgs = e as OutlookExchangeChangedOccurrenceExceptionEventArgs;
            if (occurrenceArgs != null) {
                canTerminate = false;
                if (occurrenceArgs.OutlookAppointment != null && occurrenceArgs.Occurrence != null) {
                    errText += String.Format("\r\nChanged occurrence with index {0} is imported as normal occurrence '{1}' started on {2:D} at {3}\n", occurrenceArgs.Occurrence.RecurrenceIndex, occurrenceArgs.Occurrence.Subject,
                            occurrenceArgs.Occurrence.Start, occurrenceArgs.Occurrence.Start.TimeOfDay);
                }
            } else {
                OutlookExchangeExceptionEventArgs args = e as OutlookExchangeExceptionEventArgs;
                if (args != null) {
                    if (args.OutlookAppointment != null) {
                        errText += String.Format("\r\nEvent '{0}' started on {1:D} at {2}\n", args.OutlookAppointment.Subject,
                                args.OutlookAppointment.Start, args.OutlookAppointment.Start.TimeOfDay);
                    }
                }
            }

            AddToLog(errText);
            AppointmentImporter importer = (AppointmentImporter)sender;
               
            e.Handled = true;
            if (canTerminate) {
                importer.Terminate();
                throw e.OriginalException;
            }
        }
		void importer_AppointmentImporting(object sender, AppointmentImportingEventArgs e) {
			OutlookAppointmentImportingEventArgs args = (OutlookAppointmentImportingEventArgs)e;
			AddToLog(CreateImportLogString(args));
			
			ProgressBarControl1.Position++;
			ProgressBarControl1.Update();

			bool cancel = args.OutlookAppointment.IsRecurring ? IsCancelForRecurring : IsCancelForNonRecurring;
			if (cancel) {
				e.Cancel = true;
				AddToLog("Cancelled because of the appointment type");
			}
		}
		void importer_AppointmentImported(object sender, AppointmentImportedEventArgs e) {
			AddToLog(String.Format("Successfully imported: {0}", DemoUtils.FormatAppointmentString(e.Appointment)));
		}
	}
}
