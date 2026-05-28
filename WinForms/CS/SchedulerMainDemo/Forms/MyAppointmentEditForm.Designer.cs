namespace DevExpress.XtraScheduler.Demos {
	partial class MyAppointmentEditForm {
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing) {
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.btnOK = new DevExpress.XtraEditors.SimpleButton();
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.btnReccurrence = new DevExpress.XtraEditors.SimpleButton();
			this.lblSubject = new System.Windows.Forms.Label();
			this.txSubject = new DevExpress.XtraEditors.TextEdit();
			this.edLabel = new DevExpress.XtraScheduler.UI.AppointmentLabelEdit();
			this.edStatus = new DevExpress.XtraScheduler.UI.AppointmentStatusEdit();
			this.lblStatus = new System.Windows.Forms.Label();
			this.lblLabel = new System.Windows.Forms.Label();
			this.lblStart = new System.Windows.Forms.Label();
			this.lblEnd = new System.Windows.Forms.Label();
			this.lblCustomName = new System.Windows.Forms.Label();
			this.lblCustomStatus = new System.Windows.Forms.Label();
			this.txCustomName = new DevExpress.XtraEditors.TextEdit();
			this.txCustomStatus = new DevExpress.XtraEditors.TextEdit();
			this.dtStart = new DevExpress.XtraEditors.DateEdit();
			this.dtEnd = new DevExpress.XtraEditors.DateEdit();
			this.timeStart = new DevExpress.XtraEditors.TimeEdit();
			this.timeEnd = new DevExpress.XtraEditors.TimeEdit();
			this._checkAllDay = new DevExpress.XtraEditors.CheckEdit();
			((System.ComponentModel.ISupportInitialize)(this.txSubject.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.edLabel.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.edStatus.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txCustomName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txCustomStatus.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties.VistaTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties.VistaTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.timeStart.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.timeEnd.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._checkAllDay.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(16, 224);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 27);
			this.btnOK.TabIndex = 10;
			this.btnOK.Text = "OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(113, 224);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 27);
			this.btnCancel.TabIndex = 11;
			this.btnCancel.Text = "Cancel";
			// 
			// btnReccurrence
			// 
			this.btnReccurrence.Location = new System.Drawing.Point(208, 224);
			this.btnReccurrence.Name = "btnReccurrence";
			this.btnReccurrence.Size = new System.Drawing.Size(80, 27);
			this.btnReccurrence.TabIndex = 12;
			this.btnReccurrence.Text = "Recurrence";
			this.btnReccurrence.Click += new System.EventHandler(this.btnAddRec_Click);
			// 
			// lblSubject
			// 
			this.lblSubject.Location = new System.Drawing.Point(8, 9);
			this.lblSubject.Name = "lblSubject";
			this.lblSubject.Size = new System.Drawing.Size(48, 18);
			this.lblSubject.TabIndex = 4;
			this.lblSubject.Text = "Subject:";
			// 
			// txSubject
			// 
			this.txSubject.EditValue = "";
			this.txSubject.Location = new System.Drawing.Point(96, 8);
			this.txSubject.Name = "txSubject";
			this.txSubject.Size = new System.Drawing.Size(192, 20);
			this.txSubject.TabIndex = 0;
			// 
			// edLabel
			// 
			this.edLabel.Location = new System.Drawing.Point(96, 136);
			this.edLabel.Name = "edLabel";
			this.edLabel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.edLabel.Size = new System.Drawing.Size(192, 20);
			this.edLabel.TabIndex = 7;
			// 
			// edStatus
			// 
			this.edStatus.Location = new System.Drawing.Point(96, 112);
			this.edStatus.Name = "edStatus";
			this.edStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.edStatus.Size = new System.Drawing.Size(192, 20);
			this.edStatus.TabIndex = 6;
			// 
			// lblStatus
			// 
			this.lblStatus.Location = new System.Drawing.Point(8, 112);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(48, 18);
			this.lblStatus.TabIndex = 10;
			this.lblStatus.Text = "Status:";
			// 
			// lblLabel
			// 
			this.lblLabel.Location = new System.Drawing.Point(8, 136);
			this.lblLabel.Name = "lblLabel";
			this.lblLabel.Size = new System.Drawing.Size(48, 19);
			this.lblLabel.TabIndex = 11;
			this.lblLabel.Text = "Label:";
			// 
			// lblStart
			// 
			this.lblStart.Location = new System.Drawing.Point(8, 41);
			this.lblStart.Name = "lblStart";
			this.lblStart.Size = new System.Drawing.Size(56, 18);
			this.lblStart.TabIndex = 12;
			this.lblStart.Text = "Start:";
			// 
			// lblEnd
			// 
			this.lblEnd.Location = new System.Drawing.Point(8, 65);
			this.lblEnd.Name = "lblEnd";
			this.lblEnd.Size = new System.Drawing.Size(48, 18);
			this.lblEnd.TabIndex = 13;
			this.lblEnd.Text = "End:";
			// 
			// lblCustomName
			// 
			this.lblCustomName.Location = new System.Drawing.Point(8, 168);
			this.lblCustomName.Name = "lblCustomName";
			this.lblCustomName.Size = new System.Drawing.Size(80, 19);
			this.lblCustomName.TabIndex = 15;
			this.lblCustomName.Text = "Custom name:";
			// 
			// lblCustomStatus
			// 
			this.lblCustomStatus.Location = new System.Drawing.Point(8, 192);
			this.lblCustomStatus.Name = "lblCustomStatus";
			this.lblCustomStatus.Size = new System.Drawing.Size(80, 19);
			this.lblCustomStatus.TabIndex = 16;
			this.lblCustomStatus.Text = "Custom status:";
			// 
			// txCustomName
			// 
			this.txCustomName.EditValue = "";
			this.txCustomName.Location = new System.Drawing.Point(96, 168);
			this.txCustomName.Name = "txCustomName";
			this.txCustomName.Size = new System.Drawing.Size(192, 20);
			this.txCustomName.TabIndex = 8;
			// 
			// txCustomStatus
			// 
			this.txCustomStatus.EditValue = "";
			this.txCustomStatus.Location = new System.Drawing.Point(96, 192);
			this.txCustomStatus.Name = "txCustomStatus";
			this.txCustomStatus.Size = new System.Drawing.Size(192, 20);
			this.txCustomStatus.TabIndex = 9;
			// 
			// dtStart
			// 
			this.dtStart.EditValue = new System.DateTime(2010, 6, 27, 0, 0, 0, 0);
			this.dtStart.Location = new System.Drawing.Point(96, 40);
			this.dtStart.Name = "dtStart";
			this.dtStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtStart.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.dtStart.Size = new System.Drawing.Size(96, 20);
			this.dtStart.TabIndex = 1;
			this.dtStart.EditValueChanged += new System.EventHandler(this.dtStart_EditValueChanged);
			// 
			// dtEnd
			// 
			this.dtEnd.EditValue = new System.DateTime(2010, 6, 27, 0, 0, 0, 0);
			this.dtEnd.Location = new System.Drawing.Point(96, 64);
			this.dtEnd.Name = "dtEnd";
			this.dtEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtEnd.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.dtEnd.Size = new System.Drawing.Size(96, 20);
			this.dtEnd.TabIndex = 3;
			this.dtEnd.EditValueChanged += new System.EventHandler(this.dtEnd_EditValueChanged);
			// 
			// timeStart
			// 
			this.timeStart.EditValue = new System.DateTime(2006, 3, 28, 0, 0, 0, 0);
			this.timeStart.Location = new System.Drawing.Point(208, 40);
			this.timeStart.Name = "timeStart";
			this.timeStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.timeStart.Size = new System.Drawing.Size(80, 20);
			this.timeStart.TabIndex = 2;
			this.timeStart.EditValueChanged += new System.EventHandler(this.timeStart_EditValueChanged);
			// 
			// timeEnd
			// 
			this.timeEnd.EditValue = new System.DateTime(2006, 3, 28, 0, 0, 0, 0);
			this.timeEnd.Location = new System.Drawing.Point(208, 64);
			this.timeEnd.Name = "timeEnd";
			this.timeEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.timeEnd.Size = new System.Drawing.Size(80, 20);
			this.timeEnd.TabIndex = 4;
			this.timeEnd.EditValueChanged += new System.EventHandler(this.timeEnd_EditValueChanged);
			// 
			// checkAllDay
			// 
			this._checkAllDay.Location = new System.Drawing.Point(94, 88);
			this._checkAllDay.Name = "checkAllDay";
			this._checkAllDay.Properties.Caption = "All day event";
			this._checkAllDay.Size = new System.Drawing.Size(88, 19);
			this._checkAllDay.TabIndex = 5;
			this._checkAllDay.CheckedChanged += new System.EventHandler(this.checkAllDay_CheckedChanged);
			// 
			// MyAppointmentEditForm
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(298, 264);
			this.Controls.Add(this._checkAllDay);
			this.Controls.Add(this.timeEnd);
			this.Controls.Add(this.timeStart);
			this.Controls.Add(this.dtEnd);
			this.Controls.Add(this.dtStart);
			this.Controls.Add(this.txCustomStatus);
			this.Controls.Add(this.txCustomName);
			this.Controls.Add(this.lblCustomStatus);
			this.Controls.Add(this.lblCustomName);
			this.Controls.Add(this.lblEnd);
			this.Controls.Add(this.lblStart);
			this.Controls.Add(this.lblLabel);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.edStatus);
			this.Controls.Add(this.edLabel);
			this.Controls.Add(this.txSubject);
			this.Controls.Add(this.lblSubject);
			this.Controls.Add(this.btnReccurrence);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MyAppointmentEditForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Custom Appointment Form";
			this.Activated += new System.EventHandler(this.MyAppointmentEditForm_Activated);
			((System.ComponentModel.ISupportInitialize)(this.txSubject.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.edLabel.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.edStatus.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txCustomName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txCustomStatus.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties.VistaTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties.VistaTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.timeStart.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.timeEnd.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._checkAllDay.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private DevExpress.XtraEditors.SimpleButton btnOK;
		private DevExpress.XtraEditors.SimpleButton btnCancel;
		private DevExpress.XtraEditors.TextEdit txSubject;
		private DevExpress.XtraEditors.SimpleButton btnReccurrence;
		private DevExpress.XtraScheduler.UI.AppointmentLabelEdit edLabel;
		private DevExpress.XtraScheduler.UI.AppointmentStatusEdit edStatus;
		private System.Windows.Forms.Label lblSubject;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Label lblLabel;
		private System.Windows.Forms.Label lblStart;
		private System.Windows.Forms.Label lblEnd;
		private System.Windows.Forms.Label lblCustomName;
		private System.Windows.Forms.Label lblCustomStatus;
		private DevExpress.XtraEditors.TextEdit txCustomName;
		private DevExpress.XtraEditors.TextEdit txCustomStatus;
		private DevExpress.XtraEditors.DateEdit dtStart;
		private DevExpress.XtraEditors.DateEdit dtEnd;
		private DevExpress.XtraEditors.TimeEdit timeStart;
		private DevExpress.XtraEditors.TimeEdit timeEnd;
	}
}
