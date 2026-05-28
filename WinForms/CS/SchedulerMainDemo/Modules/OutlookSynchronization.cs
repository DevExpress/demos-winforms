using System;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Xpo;
using DevExpress.XtraScheduler.Exchange;
using DevExpress.XtraScheduler.Outlook;

namespace DevExpress.XtraScheduler.Demos {
	public partial class OutlookSynchronizationModule : DevExpress.XtraScheduler.Demos.TutorialControl {
		public OutlookSynchronizationModule() {
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}

		public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }
		protected bool IsCancelForRecurring { get { return ((UsedAppointmentType)cbCancelingTypes.EditValue).Equals(UsedAppointmentType.Recurring); } }
		protected bool IsCancelForNonRecurring { get { return ((UsedAppointmentType)cbCancelingTypes.EditValue).Equals(UsedAppointmentType.NonRecurring); } }
        protected string CalendarName { get { return this.cbCalendarFolderPaths.Text; } }

		private void OutlookSynchronizationModule_Load(object sender, System.EventArgs e) {
			schedulerControl.Start = TutorialConstants.Today;
			UpdateControls();
		}
		private void OutlookSynchronizationModule_VisibleChanged(object sender, System.EventArgs e) {
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
            }
            finally {
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
				
			} catch {
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
		void BeforeSynchronization(int objectCount) {
            AddToLog(String.Format("{0} - Start synchronization with '{1}' calendar...", TutorialConstants.Now.ToLongTimeString(), CalendarName));
			Application.DoEvents();
			SuspendLog();
			ProgressBarControl1.Position = 0;
			ProgressBarControl1.Properties.Maximum = objectCount;
		}
		void AfterSynchronization() {
            AddToLog(String.Format("{0} - Synchronization complete!", TutorialConstants.Now.ToLongTimeString()));
			AddToLog(new string('-', 60));
			ResumeLog();
			ProgressBarControl1.Properties.Maximum = 100;
			ProgressBarControl1.Position = 0;
		}
		string CreateSyncronizationLogString(AppointmentSynchronizingEventArgs e) {
			OutlookAppointmentSynchronizingEventArgs args = (OutlookAppointmentSynchronizingEventArgs)e;
			return String.Format("Trying to {0}: apt={1}, olApt={2} ...", args.Operation.ToString(),
				DemoUtils.FormatAppointmentString(args.Appointment), DemoUtils.FormatOutlookAppointmentString(args.OutlookAppointment));
		}
		#endregion

		private void btnClearLog_Click(object sender, EventArgs e) {
			ClearLog();
		}
		private void btnSynchronize_Click(object sender, EventArgs e) {
            try {
                Synchronize();
            } catch(Exception ex) {
                DemoUtils.ReportOutlookError("synchronize XtraScheduler with Microsoft Outlook", ex.Message);
            }
		}
		void Synchronize() {
			AppointmentImportSynchronizer synchronizer = schedulerStorage.CreateOutlookImportSynchronizer();
            ((ISupportCalendarFolders)synchronizer).CalendarFolderName = CalendarName;
			synchronizer.ForeignIdFieldName = "EntryID";
			synchronizer.AppointmentSynchronizing += new AppointmentSynchronizingEventHandler(synchronizer_AppointmentSynchronizing);
			synchronizer.AppointmentSynchronized += new AppointmentSynchronizedEventHandler(synchronizer_AppointmentSynchronized);
            synchronizer.OnException += new ExchangeExceptionEventHandler(synchronizer_OnException);

			Cursor oldCur = Cursor.Current;
			Cursor.Current = Cursors.WaitCursor;
			BeforeSynchronization(synchronizer.SourceObjectCount);
			try {
                synchronizer.Synchronize();
            }
			finally {
				AfterSynchronization();
				Cursor.Current = oldCur;
			}
		}

        void synchronizer_OnException(object sender, ExchangeExceptionEventArgs e) {
            string errText = e.OriginalException.Message;
            OutlookExchangeExceptionEventArgs args = e as OutlookExchangeExceptionEventArgs;
            if (args != null) {
                if (args.OutlookAppointment != null) {
                    errText += String.Format("\r\nEvent '{0}' started on {1:D} at {2}\n", args.OutlookAppointment.Subject,
                            args.OutlookAppointment.Start, args.OutlookAppointment.Start.TimeOfDay);
                }
            }
            AddToLog(errText);
            AppointmentImportSynchronizer synchronizer = (AppointmentImportSynchronizer)sender;
            synchronizer.Terminate();
            e.Handled = true;
            throw e.OriginalException;
        }
		void synchronizer_AppointmentSynchronizing(object sender, AppointmentSynchronizingEventArgs e) {
			OutlookAppointmentSynchronizingEventArgs args = (OutlookAppointmentSynchronizingEventArgs)e;
			AddToLog(CreateSyncronizationLogString(args));

			ProgressBarControl1.Position++;
			ProgressBarControl1.Update();

			Appointment apt = e.Appointment;
			bool cancel = false;
			if (apt != null) {
				cancel = apt.IsRecurring ? IsCancelForRecurring : IsCancelForNonRecurring;
			}

			if (cancel) {
				e.Cancel = true;
				AddToLog("Cancelled because of the appointment type");
				return;
			}

			switch (e.Operation) {
				case SynchronizeOperation.Create:
					if (chkDontCreateNew.Checked) {
						AddToLog("Cancelled because of the 'DontCreateNew' rule");
						e.Cancel = true;
					}
					break;

				case SynchronizeOperation.Delete:
					if (chkDontDeleteExisting.Checked) {
						AddToLog("Cancelled because of the 'DontDeleteExisting' rule");
						e.Cancel = true;
					}
					break;

				case SynchronizeOperation.Replace:
					if (chkDeleteInsteadReplace.Checked) {
						e.Operation = SynchronizeOperation.Delete;
						AddToLog("Synchronization operation has been changed from 'Replace' to 'Delete' because of the DeleteInsteadReplace rule");
					}
					break;
			}
		}
		void synchronizer_AppointmentSynchronized(object sender, AppointmentSynchronizedEventArgs e) {
			AddToLog(String.Format("Successfully synchronized: {0}", DemoUtils.FormatAppointmentString(e.Appointment)));
		}
	}
}
