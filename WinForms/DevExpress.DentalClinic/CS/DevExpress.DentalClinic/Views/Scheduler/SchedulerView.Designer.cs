using DevExpress.XtraScheduler;

namespace DevExpress.DentalClinic.View {
    partial class SchedulerView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            this.schedulerControl = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
            this.xpBindingSource1 = new DevExpress.Xpo.XPBindingSource(this.components);
            this.xpBindingSource2 = new DevExpress.Xpo.XPBindingSource(this.components);
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.whiteningButton = new DevExpress.XtraEditors.SimpleButton();
            this.surgeryButton = new DevExpress.XtraEditors.SimpleButton();
            this.rootCanalButton = new DevExpress.XtraEditors.SimpleButton();
            this.restorationButton = new DevExpress.XtraEditors.SimpleButton();
            this.orthodonticsButton = new DevExpress.XtraEditors.SimpleButton();
            this.implantationButton = new DevExpress.XtraEditors.SimpleButton();
            this.hygieneButton = new DevExpress.XtraEditors.SimpleButton();
            this.diagnosisButton = new DevExpress.XtraEditors.SimpleButton();
            this.prostheticsButton = new DevExpress.XtraEditors.SimpleButton();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerControl
            // 
            this.schedulerControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.schedulerControl.DataStorage = this.schedulerDataStorage1;
            this.schedulerControl.DateNavigationBar.ShowTodayButton = true;
            this.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource;
            this.schedulerControl.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl.Margin = new System.Windows.Forms.Padding(0);
            this.schedulerControl.Name = "schedulerControl";
            this.schedulerControl.OptionsCustomization.AllowAppointmentDelete = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl.OptionsCustomization.AllowAppointmentDrag = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl.OptionsCustomization.AllowAppointmentResize = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.schedulerControl.Size = new System.Drawing.Size(879, 491);
            this.schedulerControl.Start = new System.DateTime(2019, 10, 7, 0, 0, 0, 0);
            this.schedulerControl.TabIndex = 0;
            this.schedulerControl.Text = "schedulerControl";
            this.schedulerControl.Views.AgendaView.Enabled = false;
            this.schedulerControl.Views.YearView.Enabled = false;
            this.schedulerControl.Views.DayView.DayCount = 3;
            this.schedulerControl.Views.DayView.ShowWorkTimeOnly = true;
            this.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl.Views.FullWeekView.Enabled = true;
            this.schedulerControl.Views.FullWeekView.ShowWorkTimeOnly = true;
            this.schedulerControl.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl.Views.GanttView.Enabled = false;
            this.schedulerControl.Views.MonthView.AppointmentDisplayOptions.EndTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Never;
            this.schedulerControl.Views.MonthView.AppointmentDisplayOptions.StartTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Never;
            this.schedulerControl.Views.TimelineView.AppointmentDisplayOptions.EndTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Never;
            this.schedulerControl.Views.TimelineView.AppointmentDisplayOptions.StartTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Never;
            this.schedulerControl.Views.WeekView.Enabled = false;
            this.schedulerControl.Views.WorkWeekView.ShowWorkTimeOnly = true;
            this.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            this.schedulerControl.Views.YearView.UseOptimizedScrolling = false;
            this.schedulerControl.PopupMenuShowing += new DevExpress.XtraScheduler.PopupMenuShowingEventHandler(this.OnSchedulerControlPopupMenuShowing);
            this.schedulerControl.AppointmentFlyoutShowing += new DevExpress.XtraScheduler.AppointmentFlyoutShowingEventHandler(this.OnAppointmentFlyoutShowing);
            this.schedulerControl.OptionsBehavior.UseAsyncMode = false;
            // 
            // schedulerDataStorage1
            // 
            // 
            // 
            // 
            this.schedulerDataStorage1.AppointmentDependencies.AutoReload = false;
            // 
            // 
            // 
            this.schedulerDataStorage1.Appointments.DataSource = this.xpBindingSource1;
            this.schedulerDataStorage1.Appointments.Mappings.AppointmentId = "Oid";
            this.schedulerDataStorage1.Appointments.Mappings.Description = "Comment";
            this.schedulerDataStorage1.Appointments.Mappings.End = "EndDate";
            this.schedulerDataStorage1.Appointments.Mappings.Label = "ProcedureGroup";
            this.schedulerDataStorage1.Appointments.Mappings.ResourceId = "Doctor!Key";
            this.schedulerDataStorage1.Appointments.Mappings.Start = "Date";
            this.schedulerDataStorage1.Appointments.Mappings.Status = "ProcedureGroup";
            this.schedulerDataStorage1.Appointments.Mappings.Subject = "Patient.FullName";
            // 
            // 
            // 
            this.schedulerDataStorage1.Resources.DataSource = this.xpBindingSource2;
            this.schedulerDataStorage1.Resources.Mappings.Caption = "FullName";
            this.schedulerDataStorage1.Resources.Mappings.Id = "Oid";
            this.schedulerDataStorage1.FilterAppointment += new DevExpress.XtraScheduler.PersistentObjectCancelEventHandler(this.OnFilterAppointment);
            // 
            // xpBindingSource1
            // 
            this.xpBindingSource1.ObjectType = typeof(DevExpress.DentalClinic.Model.Appointment);
            // 
            // xpBindingSource2
            // 
            this.xpBindingSource2.ObjectType = typeof(DevExpress.DentalClinic.Model.Doctor);
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.whiteningButton);
            this.tablePanel1.Controls.Add(this.surgeryButton);
            this.tablePanel1.Controls.Add(this.rootCanalButton);
            this.tablePanel1.Controls.Add(this.restorationButton);
            this.tablePanel1.Controls.Add(this.orthodonticsButton);
            this.tablePanel1.Controls.Add(this.implantationButton);
            this.tablePanel1.Controls.Add(this.hygieneButton);
            this.tablePanel1.Controls.Add(this.diagnosisButton);
            this.tablePanel1.Controls.Add(this.prostheticsButton);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tablePanel1.Location = new System.Drawing.Point(0, 492);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Padding = new System.Windows.Forms.Padding(2, 0, 12, 0);
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(879, 60);
            this.tablePanel1.TabIndex = 1;
            // 
            // simpleButton9
            // 
            this.tablePanel1.SetColumn(this.whiteningButton, 8);
            this.whiteningButton.Location = new System.Drawing.Point(781, 12);
            this.whiteningButton.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.whiteningButton.Name = "simpleButton9";
            this.tablePanel1.SetRow(this.whiteningButton, 0);
            this.whiteningButton.Size = new System.Drawing.Size(86, 35);
            this.whiteningButton.TabIndex = 8;
            this.whiteningButton.Text = "Surgery";
            // 
            // simpleButton8
            // 
            this.tablePanel1.SetColumn(this.surgeryButton, 7);
            this.surgeryButton.Location = new System.Drawing.Point(685, 12);
            this.surgeryButton.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.surgeryButton.Name = "simpleButton8";
            this.tablePanel1.SetRow(this.surgeryButton, 0);
            this.surgeryButton.Size = new System.Drawing.Size(86, 35);
            this.surgeryButton.TabIndex = 7;
            this.surgeryButton.Text = "Orthodontics";
            // 
            // simpleButton7
            // 
            this.tablePanel1.SetColumn(this.rootCanalButton, 6);
            this.rootCanalButton.Location = new System.Drawing.Point(589, 12);
            this.rootCanalButton.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rootCanalButton.Name = "simpleButton7";
            this.tablePanel1.SetRow(this.rootCanalButton, 0);
            this.rootCanalButton.Size = new System.Drawing.Size(86, 35);
            this.rootCanalButton.TabIndex = 6;
            this.rootCanalButton.Text = "Implantation";
            // 
            // simpleButton6
            // 
            this.tablePanel1.SetColumn(this.restorationButton, 5);
            this.restorationButton.Location = new System.Drawing.Point(493, 12);
            this.restorationButton.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.restorationButton.Name = "simpleButton6";
            this.tablePanel1.SetRow(this.restorationButton, 0);
            this.restorationButton.Size = new System.Drawing.Size(86, 35);
            this.restorationButton.TabIndex = 5;
            this.restorationButton.Text = "Prosthetics";
            // 
            // simpleButton4
            // 
            this.tablePanel1.SetColumn(this.orthodonticsButton, 3);
            this.orthodonticsButton.Location = new System.Drawing.Point(300, 12);
            this.orthodonticsButton.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.orthodonticsButton.Name = "simpleButton4";
            this.tablePanel1.SetRow(this.orthodonticsButton, 0);
            this.orthodonticsButton.Size = new System.Drawing.Size(86, 35);
            this.orthodonticsButton.TabIndex = 3;
            this.orthodonticsButton.Text = "Hygiene";
            // 
            // simpleButton3
            // 
            this.tablePanel1.SetColumn(this.implantationButton, 2);
            this.implantationButton.Location = new System.Drawing.Point(204, 12);
            this.implantationButton.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.implantationButton.Name = "simpleButton3";
            this.tablePanel1.SetRow(this.implantationButton, 0);
            this.implantationButton.Size = new System.Drawing.Size(86, 35);
            this.implantationButton.TabIndex = 2;
            this.implantationButton.Text = "Root canal";
            // 
            // simpleButton2
            // 
            this.tablePanel1.SetColumn(this.hygieneButton, 1);
            this.hygieneButton.Location = new System.Drawing.Point(108, 12);
            this.hygieneButton.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.hygieneButton.Name = "simpleButton2";
            this.tablePanel1.SetRow(this.hygieneButton, 0);
            this.hygieneButton.Size = new System.Drawing.Size(86, 35);
            this.hygieneButton.TabIndex = 1;
            this.hygieneButton.Text = "Restoration";
            // 
            // simpleButton1
            // 
            this.tablePanel1.SetColumn(this.diagnosisButton, 0);
            this.diagnosisButton.Location = new System.Drawing.Point(12, 12);
            this.diagnosisButton.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.diagnosisButton.Name = "simpleButton1";
            this.tablePanel1.SetRow(this.diagnosisButton, 0);
            this.diagnosisButton.Size = new System.Drawing.Size(86, 35);
            this.diagnosisButton.TabIndex = 0;
            this.diagnosisButton.Text = "Diagnosis";
            // 
            // simpleButton5
            // 
            this.tablePanel1.SetColumn(this.prostheticsButton, 4);
            this.prostheticsButton.Location = new System.Drawing.Point(396, 12);
            this.prostheticsButton.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.prostheticsButton.Name = "simpleButton5";
            this.tablePanel1.SetRow(this.prostheticsButton, 0);
            this.prostheticsButton.Size = new System.Drawing.Size(86, 35);
            this.prostheticsButton.TabIndex = 4;
            this.prostheticsButton.Text = "Whitening";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.separatorControl1.Location = new System.Drawing.Point(0, 491);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(879, 1);
            this.separatorControl1.TabIndex = 2;
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.ViewModelType = typeof(DevExpress.DentalClinic.ViewModel.SchedulerViewModel);
            // 
            // SchedulerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.schedulerControl);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.tablePanel1);
            this.Name = "SchedulerView";
            this.Size = new System.Drawing.Size(879, 552);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraScheduler.SchedulerControl schedulerControl;
        private XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
        private Utils.MVVM.MVVMContext mvvmContext1;
        private Xpo.XPBindingSource xpBindingSource1;
        private Xpo.XPBindingSource xpBindingSource2;
        private Utils.Layout.TablePanel tablePanel1;
        private XtraEditors.SimpleButton whiteningButton;
        private XtraEditors.SimpleButton surgeryButton;
        private XtraEditors.SimpleButton rootCanalButton;
        private XtraEditors.SimpleButton restorationButton;
        private XtraEditors.SimpleButton prostheticsButton;
        private XtraEditors.SimpleButton orthodonticsButton;
        private XtraEditors.SimpleButton implantationButton;
        private XtraEditors.SimpleButton hygieneButton;
        private XtraEditors.SimpleButton diagnosisButton;
        private XtraEditors.SeparatorControl separatorControl1;
    }
}
