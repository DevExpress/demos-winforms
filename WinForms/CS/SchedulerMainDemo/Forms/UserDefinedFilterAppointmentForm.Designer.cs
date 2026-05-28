namespace DevExpress.XtraScheduler.Demos.Forms {
	partial class UserDefinedFilterAppointmentForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.lblPrice = new System.Windows.Forms.Label();
			this.edtPrice = new DevExpress.XtraEditors.CalcEdit();
			((System.ComponentModel.ISupportInitialize)(this.chkAllDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.edtLabel.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.edtShowTimeAs.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbSubject.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.edtResource.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.edtResources.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.ResourcesCheckedListBoxControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkReminder.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbReminder.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            this.progressPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.edtPrice.Properties)).BeginInit();
			this.SuspendLayout();
			// 
            // lblLabel
            // 
            this.lblLabel.Appearance.BackColor = System.Drawing.Color.Transparent;
            // 
			// chkAllDay
			// 
			// 
            // edtStartDate
            // 
            this.edtStartDate.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            // 
            // edtEndDate
            // 
            this.edtEndDate.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            // 
            // edtStartTime
            // 
            this.edtStartTime.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            // 
            // edtEndTime
            // 
            this.edtEndTime.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            // 
			// edtLabel
			// 
			// 
			// edtShowTimeAs
			// 
			// 
			// tbSubject
			// 
			// 
			// edtResource
			// 
			// 
			// edtResources
			// 
			// 
            // 
            // 
            this.edtResources.ResourcesCheckedListBoxControl.CheckOnClick = true;
            this.edtResources.ResourcesCheckedListBoxControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtResources.ResourcesCheckedListBoxControl.Location = new System.Drawing.Point(0, 0);
            this.edtResources.ResourcesCheckedListBoxControl.Name = "";
            this.edtResources.ResourcesCheckedListBoxControl.Size = new System.Drawing.Size(200, 100);
            this.edtResources.ResourcesCheckedListBoxControl.TabIndex = 0;
            // 
			// chkReminder
			// 
			// 
			// tbDescription
			// 
            this.tbDescription.Location = new System.Drawing.Point(16, 222);
            this.tbDescription.Size = new System.Drawing.Size(496, 120);
			this.tbDescription.TabIndex = 15;
			// 
			// cbReminder
			// 
			// 
			// tbLocation
			// 
			// 
            // progressPanel
            // 
            this.progressPanel.Location = new System.Drawing.Point(16, 187);
            // 
            // tbProgress
            // 
            this.tbProgress.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.tbProgress.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            // 
            // lblPercentComplete
            // 
            this.lblPercentComplete.Appearance.BackColor = System.Drawing.Color.Transparent;
            // 
            // lblPercentCompleteValue
            // 
            this.lblPercentCompleteValue.Appearance.BackColor = System.Drawing.Color.Transparent;
            // 
			// lblPrice
			// 
			this.lblPrice.AutoSize = true;
			this.lblPrice.Location = new System.Drawing.Point(16, 168);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(34, 13);
			this.lblPrice.TabIndex = 37;
			this.lblPrice.Text = "&Price:";
			// 
			// edtPrice
			// 
			this.edtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.edtPrice.Location = new System.Drawing.Point(96, 165);
			this.edtPrice.Name = "edtPrice";
			this.edtPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtPrice.Size = new System.Drawing.Size(216, 20);
			this.edtPrice.TabIndex = 14;			
			// 
			// UserDefinedFilterAppointmentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(528, 382);
			this.Controls.Add(this.edtPrice);
			this.Controls.Add(this.lblPrice);
			this.Name = "UserDefinedFilterAppointmentForm";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.progressPanel, 0);
			this.Controls.SetChildIndex(this.tbDescription, 0);
			this.Controls.SetChildIndex(this.lblPrice, 0);
			this.Controls.SetChildIndex(this.edtPrice, 0);
			this.Controls.SetChildIndex(this.edtShowTimeAs, 0);
			this.Controls.SetChildIndex(this.edtEndTime, 0);
			this.Controls.SetChildIndex(this.edtEndDate, 0);
			this.Controls.SetChildIndex(this.btnRecurrence, 0);
			this.Controls.SetChildIndex(this.btnDelete, 0);
			this.Controls.SetChildIndex(this.btnCancel, 0);
			this.Controls.SetChildIndex(this.lblShowTimeAs, 0);
			this.Controls.SetChildIndex(this.lblEndTime, 0);
			this.Controls.SetChildIndex(this.tbLocation, 0);
			this.Controls.SetChildIndex(this.lblSubject, 0);
			this.Controls.SetChildIndex(this.lblLocation, 0);
			this.Controls.SetChildIndex(this.tbSubject, 0);
			this.Controls.SetChildIndex(this.lblStartTime, 0);
			this.Controls.SetChildIndex(this.btnOk, 0);
			this.Controls.SetChildIndex(this.edtStartDate, 0);
			this.Controls.SetChildIndex(this.edtStartTime, 0);
			((System.ComponentModel.ISupportInitialize)(this.chkAllDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.edtLabel.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.edtShowTimeAs.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbSubject.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.edtResource.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.edtResources.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.ResourcesCheckedListBoxControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkReminder.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbReminder.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.progressPanel.ResumeLayout(false);
            this.progressPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.edtPrice.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblPrice;
		private DevExpress.XtraEditors.CalcEdit edtPrice;
	}
}
