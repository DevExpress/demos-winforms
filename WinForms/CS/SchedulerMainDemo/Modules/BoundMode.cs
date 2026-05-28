using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;

namespace DevExpress.XtraScheduler.Demos {
	public partial class BoundModeModule : DevExpress.XtraScheduler.Demos.TutorialControl {
		public BoundModeModule() {
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			FillData();

		}
		public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }

		private void BoundModeModule_Load(object sender, System.EventArgs e) {
            schedulerControl.Start = new DateTime(2016, 11, 16);

			schedulerControl.DataStorage.EnableReminders = false;

			InitCustomAppointmentStatuses();
		}

		void FillData() {
			string connectionString = DemoUtils.GetFileRelativePath("CarsDB.mdb");
			if (connectionString.Length <= 0)
				return;

			DemoUtils.SetConnectionString(usageTypeTableAdapter.Connection, connectionString);
			DemoUtils.SetConnectionString(carsTableAdapter.Connection, connectionString);
			DemoUtils.SetConnectionString(carSchedulingTableAdapter.Connection, connectionString);

			usageTypeTableAdapter.Fill(this.carsDataSet.UsageType);
			carsTableAdapter.Fill(this.carsDataSet.Cars);
			carSchedulingTableAdapter.Fill(this.carsDataSet.CarScheduling);

			carSchedulingTableAdapter.DataAdapter.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(carSchedulingTableAdapter_RowUpdated);
		}
		void InitCustomAppointmentStatuses() {
			schedulerStorage.Appointments.Statuses.Clear();
			for (int i = 0; i < this.carsDataSet.UsageType.Rows.Count; i++) {
				string nameColumnTextValue = this.carsDataSet.UsageType.Rows[i]["Name"].ToString();
				schedulerStorage.Appointments.Statuses.Add(GetStatusColor(i), nameColumnTextValue, nameColumnTextValue);
			}
		}
		System.Drawing.Color GetStatusColor(int rowIndex) {
			object obj = this.carsDataSet.UsageType.Rows[rowIndex]["Color"];
			int statusColor = obj != DBNull.Value ? Convert.ToInt32(obj) : 0xFFFFFF;
            int b = statusColor & 0xFF;
            statusColor >>= 8;
            int g = statusColor & 0xFF;
            statusColor >>= 8;
            int r = statusColor & 0xFF;
            return Color.FromArgb(r, g, b);
		}
		private void schedulerStorage_AppointmentsChanged(object sender, DevExpress.XtraScheduler.PersistentObjectsEventArgs e) {
            // Uncomment the code below to apply changes.
            
            //carSchedulingTableAdapter.Update(this.carsDBDataSet);
            //this.carsDBDataSet.AcceptChanges();
		}

		private void schedulerStorage_FilterResource(object sender, DevExpress.XtraScheduler.PersistentObjectCancelEventArgs e) {
			e.Cancel = FilterCar((Resource)e.Object);
		}
		bool FilterCar(Resource car) {
			if ((int)car.Id > 5) {
				return true;
			}
			else {
				string tradeMark = (string)schedulerStorage.GetObjectValue(car, "Trademark");
				string model = (string)schedulerStorage.GetObjectValue(car, "Model");
				car.Caption = String.Format("{0} {1}", tradeMark, model);
				return false;
			}
		}
		private void carSchedulingTableAdapter_RowUpdated(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e) {
			if (e.Status == UpdateStatus.Continue && e.StatementType == StatementType.Insert) {
				int id = 0;
				using (OleDbCommand cmd = new OleDbCommand("SELECT @@IDENTITY", carSchedulingTableAdapter.Connection)) {
					id = (int)cmd.ExecuteScalar();
				}
				e.Row["ID"] = id;
			}
		}
	}
}

