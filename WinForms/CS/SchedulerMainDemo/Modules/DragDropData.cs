using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraScheduler;
using DevExpress.XtraEditors;

namespace DevExpress.XtraScheduler.Demos {
	public partial class DragDropDataModule : DevExpress.XtraScheduler.Demos.TutorialControl {
		GridHitInfo downHitInfo;

		public DragDropDataModule() {
			// This call is required by the Windows Form Designer.
			InitializeComponent();
            UpdateSize();
            // TODO: Add any initialization after the InitializeComponent call
		}

        public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }


        void UpdateSize() {
            grdTasks.Height = (int) (Bounds.Size.Height / 3);
        }
        void DragDropDataModule_Resize(object sender, EventArgs e) {
            UpdateSize();
        }
        void DragDropDataModule_Load(object sender, System.EventArgs e) {
			schedulerControl.GroupType = SchedulerGroupType.Resource;
			schedulerStorage.Appointments.ResourceSharing = true;
            DemoUtils.FillResources(schedulerStorage, 5);
			grdTasks.DataSource = DemoUtils.GenerateScheduleTasks();
		}
		void grdTasks_MouseDown(object sender, MouseEventArgs e) {
			GridView view = sender as GridView;
			downHitInfo = null;

			GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
			if (Control.ModifierKeys != Keys.None)
				return;
			if (e.Button == MouseButtons.Left && hitInfo.InRow && hitInfo.HitTest != GridHitTest.RowIndicator)
				downHitInfo = hitInfo;
		}

		void grdTasks_MouseMove(object sender, MouseEventArgs e) {
			GridView view = sender as GridView;
			if (e.Button == MouseButtons.Left && downHitInfo != null) {
				Size dragSize = SystemInformation.DragSize;
				Rectangle dragRect = new Rectangle(new Point((int)(downHitInfo.HitPoint.X - dragSize.Width / 2),
					(int)(downHitInfo.HitPoint.Y - dragSize.Height / 2)), dragSize);

				if (!dragRect.Contains(new Point(e.X, e.Y))) {
					view.GridControl.DoDragDrop(GetDragData(view), DragDropEffects.All);
					downHitInfo = null;
				}
			}
		}

        void AddAppointmentLabel(string displayName, string menuCaption, Color color) {
            IAppointmentLabel label = this.schedulerStorage.Appointments.Labels.CreateNewLabel(displayName);
            label.MenuCaption = menuCaption;
            label.SetColor(color);
            this.schedulerStorage.Appointments.Labels.Add(label);
        }
        void AddAppointmentStatus(string displayName, string menuCaption, AppointmentStatusType type, Color color) {
            AppointmentStatus status = this.schedulerStorage.Appointments.Statuses.CreateNewStatus("Low");
            status.MenuCaption = menuCaption;
            status.Type = type;
            status.SetBrush(new SolidBrush(color));
            this.schedulerStorage.Appointments.Statuses.Add(status);
        }
		SchedulerDragData GetDragData(GridView view) {
			int[] selection = view.GetSelectedRows();
			if (selection == null)
				return null;

			AppointmentBaseCollection appointments = new AppointmentBaseCollection();
			int count = selection.Length;
			for (int i = 0; i < count; i++) {
				int rowIndex = selection[i];
				Appointment apt = schedulerStorage.CreateAppointment(AppointmentType.Normal);
				apt.Subject = (string)view.GetRowCellValue(rowIndex, "Subject");
				apt.LabelKey = (int)view.GetRowCellValue(rowIndex, "Severity");
				apt.StatusKey = (int)view.GetRowCellValue(rowIndex, "Priority");
                apt.Start = DateTime.MinValue;
				apt.Duration = TimeSpan.FromHours((int)view.GetRowCellValue(rowIndex, "Duration"));
				apt.Description = (string)view.GetRowCellValue(rowIndex, "Description");
				appointments.Add(apt);
			}

			return new SchedulerDragData(appointments, 0);
		}

		void schedulerControl_AppointmentDrop(object sender, AppointmentDragEventArgs e) {
			string createEventMsg = "Creating an event at {0} on {1}.";
			string moveEventMsg = "Moving the event from {0} on {1} to {2} on {3}.";

			DateTime srcStart = e.SourceAppointment.Start;
			DateTime newStart = e.EditedAppointment.Start;
            bool isNewAppointment = srcStart == DateTime.MinValue;

            string msg = isNewAppointment ? String.Format(createEventMsg, newStart.ToShortTimeString(), newStart.ToShortDateString()) :
				String.Format(moveEventMsg, srcStart.ToShortTimeString(), srcStart.ToShortDateString(), newStart.ToShortTimeString(), newStart.ToShortDateString());

			if (XtraMessageBox.Show(msg + "\r\nProceed?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
				e.Allow = false;
            } else if (isNewAppointment) {
                this.schedulerControl.SelectedAppointments.Clear();
                this.schedulerControl.SelectedAppointments.Add(e.EditedAppointment);
            }
		}
	}
}
