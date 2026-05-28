using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Internal;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Native;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.iCalendar;
using DevExpress.XtraScheduler.Localization;
using DevExpress.XtraScheduler.Native;
using DevExpress.XtraScheduler.Printing;
using DevExpress.XtraScheduler.Printing.Native;
using DevExpress.XtraScheduler.UI;
using DevExpress.XtraScheduler.Commands;
using DevExpress.XtraScheduler.Services;
using System.Data;
using DevExpress.XtraScheduler.Demos;
#if !NET
using System.Data.Entity;
#else
using Microsoft.EntityFrameworkCore;
#endif

namespace Modules {
    /// <summary>
    /// Summary description for AppointmentRibbonForm.
    /// </summary>
    public partial class MedicalAppointmentForm : DevExpress.XtraBars.Ribbon.RibbonForm, IDXManagerPopupMenu {
        #region Fields
        bool _openRecurrenceForm;
        readonly ISchedulerStorage _storage;
        readonly SchedulerControl _control;
        Icon _recurringIcon;
        Icon _normalIcon;
        readonly AppointmentFormController _controller;
        IDXMenuManager _menuManager;
        bool _supressCancelCore;
        MedicScheduleContext _dataContext;
        Patient _patient;

        #endregion

        [EditorBrowsable(EditorBrowsableState.Never)]
        public MedicalAppointmentForm() {
            InitializeComponent();
        }
        public MedicalAppointmentForm(DevExpress.XtraScheduler.SchedulerControl control, Appointment apt)
            : this(control, apt, false) {
        }
        public MedicalAppointmentForm(DevExpress.XtraScheduler.SchedulerControl control, Appointment apt, bool openRecurrenceForm) {
            Guard.ArgumentNotNull(control, "control");
            Guard.ArgumentNotNull(control.DataStorage, "control.DataStorage");
            Guard.ArgumentNotNull(apt, "apt");

            this._openRecurrenceForm = openRecurrenceForm;
            this._controller = CreateController(control, apt);
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            LoadIcons();

            this._control = control;
            this._storage = control.DataStorage;

            this.edtResource.SchedulerControl = control;
            this.edtResource.Storage = _storage;

            this.riAppointmentResource.SchedulerControl = control;
            this.riAppointmentResource.Storage = _storage;
            this.riAppointmentStatus.Storage = _storage;

            this.riAppointmentLabel.Storage = _storage;

            BindControllerToControls();


            this.cmbPatient.EditValueChanged += cmbPatient_EditValueChanged;
            this.cmbPatient.MouseDown += cmbPatient_MouseDown;
            this._supressCancelCore = false;
            this.edtResource.EditValueChanged += edtResource_EditValueChanged;
            this.pictureEdit1.Properties.SizeMode = PictureSizeMode.Zoom;
        }

        void edtResource_EditValueChanged(object sender, EventArgs e) {
            RefreshMedic(Storage.Resources.GetResourceById(this.edtResource.EditValue));
        }


        #region Properties
        public IDXMenuManager MenuManager { get { return _menuManager; } private set { _menuManager = value; } }
        protected internal AppointmentFormController Controller { get { return _controller; } }
        protected internal SchedulerControl SchedulerControl { get { return _control; } }
        protected internal ISchedulerStorage Storage { get { return _storage; } }
        protected internal bool IsNewAppointment { get { return _controller != null ? _controller.IsNewAppointment : true; } }
        protected internal Icon RecurringIcon { get { return _recurringIcon; } }
        protected internal Icon NormalIcon { get { return _normalIcon; } }
        protected internal bool OpenRecurrenceForm { get { return _openRecurrenceForm; } }
        public bool ReadOnly {
            get { return Controller.ReadOnly; }
            set {
                if (Controller.ReadOnly == value)
                    return;
                Controller.ReadOnly = value;
            }
        }
        protected override FormShowMode ShowMode { get { return DevExpress.XtraEditors.FormShowMode.AfterInitialization; } }
        #endregion

        public void SetDataContext(MedicScheduleContext dataContext) {
            this._dataContext = dataContext;
        }

        public virtual void LoadFormData(Appointment appointment) {
            this._patient = (Patient)appointment.CustomFields["Patient"];
            RefreshPatient(_patient);
            if (this._patient != null)
                this.cmbPatient.Properties.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(_patient.Name, _patient.Id));
        }

        void RefreshPatient(Patient patient) {
            this.tbPhone.DataBindings.Clear();
            this.edtBirthday.DataBindings.Clear();
            this.cmbPatient.DataBindings.Clear();
            if (patient == null)
                return;
            this.tbPhone.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", patient, "Phone", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.edtBirthday.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", patient, "Birthday", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbPatient.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", patient, "Id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
        }

        void RefreshMedic(Resource resource) {
            this.pictureEdit1.Image = null;
            this.edtPhoneMedic.Text = "";
            if (resource == null)
                return;
            Medic medic = resource.GetRow(Storage) as Medic;
            if (medic == null)
                return;
            this.pictureEdit1.Image = resource.GetImage();
            this.edtPhoneMedic.Text = medic.Phone;
            this.lbMedic.Text = medic.Name;
            HospitalDepartment hospitalDepartment = this._dataContext.HospitalDepartments.Find(medic.DepartmentId);
            if (hospitalDepartment == null)
                return;
            this.lbDepartment.Text = hospitalDepartment.Name;
        }

        void cmbPatient_MouseDown(object sender, MouseEventArgs e) {
            if (this.cmbPatient.Properties.Items.Count > 1)
                return;
            this.cmbPatient.Properties.Items.Clear();
            BindingList<Patient> patients = this._dataContext.Patients.Local.ToBindingList();
            foreach (Patient patient in patients)
                this.cmbPatient.Properties.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(patient.Name, patient.Id));
        }

        void cmbPatient_EditValueChanged(object sender, EventArgs e) {
            RefreshPatient(this._dataContext.Patients.Find(this.cmbPatient.EditValue));
        }

        public virtual bool SaveFormData(Appointment appointment) {
            appointment.CustomFields["Patient"] = this._dataContext.Patients.Find(this.cmbPatient.EditValue);
            return true;
        }
        public virtual bool IsAppointmentChanged(Appointment appointment) {
            if (this._patient == null)
                return true;
            if (this._patient.Id.Equals(this.cmbPatient.EditValue))
                return false;
            return true;
        }
        public virtual void SetMenuManager(DevExpress.Utils.Menu.IDXMenuManager menuManager) {
            MenuManagerUtils.SetMenuManager(Controls, menuManager);
            this._menuManager = menuManager;
        }

        protected virtual void BindControllerToControls() {
            BindControllerToIcon();
            BindProperties(this.tbLocation, "Text", "Location");
            BindProperties(this.tbDescription, "Text", "Description");
            BindProperties(this.edtStartDate, "EditValue", "DisplayStartDate");
            BindProperties(this.edtStartDate, "Enabled", "IsDateTimeEditable");
            BindProperties(this.edtStartTime, "EditValue", "DisplayStartTime");
            BindProperties(this.edtStartTime, "Enabled", "IsTimeEnabled");
            BindProperties(this.edtEndDate, "EditValue", "DisplayEndDate", DataSourceUpdateMode.Never);
            BindProperties(this.edtEndDate, "Enabled", "IsDateTimeEditable", DataSourceUpdateMode.Never);
            BindProperties(this.edtEndTime, "EditValue", "DisplayEndTime", DataSourceUpdateMode.Never);
            BindProperties(this.edtEndTime, "Enabled", "IsTimeEnabled", DataSourceUpdateMode.Never);

            BindProperties(this.edtResource, "ResourceId", "ResourceId");
            BindProperties(this.edtResource, "Enabled", "CanEditResource");
            BindToBoolPropertyAndInvert(this.edtResource, "Visible", "ResourceSharing");

            BindProperties(this.barLabel, "EditValue", "Label");

            BindProperties(this.barStatus, "EditValue", "Status");

            BindBoolToVisibility(this.barReminder, "Visibility", "ReminderVisible");
            BindProperties(this.barReminder, "Editvalue", "ReminderTimeBeforeStart");

            BindProperties(this.btnDelete, "Enabled", "CanDeleteAppointment");

            BindBoolToVisibility(this.btnRecurrence, "Visibility", "ShouldShowRecurrenceButton");
            BindProperties(this.btnRecurrence, "Down", "IsRecurrentAppointment");


            BindToBoolPropertyAndInvert(this.ribbonControl1, "Enabled", "ReadOnly");

            BindBoolToVisibility(this.btnTimeZones, "Visibility", "TimeZonesEnabled");
            BindProperties(this.btnTimeZones, "Down", "TimeZoneVisible");
        }

        protected virtual void BindControllerToIcon() {
            Binding binding = new Binding("Icon", Controller, "AppointmentType");
            binding.Format += AppointmentTypeToIconConverter;
            DataBindings.Add(binding);
        }
        protected virtual void ObjectToStringConverter(object o, ConvertEventArgs e) {
            e.Value = e.Value.ToString();
        }
        protected virtual void AppointmentTypeToIconConverter(object o, ConvertEventArgs e) {
            AppointmentType type = (AppointmentType)e.Value;
            if (type.Equals(AppointmentType.Pattern))
                e.Value = RecurringIcon;
            else
                e.Value = NormalIcon;
        }
        protected virtual void BindProperties(Control target, string targetProperty, string sourceProperty) {
            BindProperties(target, targetProperty, sourceProperty, DataSourceUpdateMode.OnPropertyChanged);
        }
        protected virtual void BindProperties(Control target, string targetProperty, string sourceProperty, DataSourceUpdateMode updateMode) {
            target.DataBindings.Add(targetProperty, Controller, sourceProperty, true, updateMode);
            BindToIsReadOnly(target, updateMode);
        }
        protected virtual void BindProperties(Control target, string targetProperty, string sourceProperty, ConvertEventHandler objectToStringConverter) {
            Binding binding = new Binding(targetProperty, Controller, sourceProperty, true);
            binding.Format += objectToStringConverter;
            target.DataBindings.Add(binding);
        }
        protected virtual void BindToBoolPropertyAndInvert(Control target, string targetProperty, string sourceProperty) {
            target.DataBindings.Add(new BoolInvertBinding(targetProperty, Controller, sourceProperty));
            BindToIsReadOnly(target);
        }
        protected virtual void BindToIsReadOnly(Control control) {
            BindToIsReadOnly(control, DataSourceUpdateMode.OnPropertyChanged);
        }
        protected virtual void BindToIsReadOnly(Control control, DataSourceUpdateMode updateMode) {
            if ((!(control is BaseEdit)) || control.DataBindings["ReadOnly"] != null)
                return;
            control.DataBindings.Add("ReadOnly", Controller, "ReadOnly", true, updateMode);
        }

        protected virtual void BindProperties(DevExpress.XtraBars.BarItem target, string targetProperty, string sourceProperty) {
            BindProperties(target, targetProperty, sourceProperty, DataSourceUpdateMode.OnPropertyChanged);
        }
        protected virtual void BindProperties(DevExpress.XtraBars.BarItem target, string targetProperty, string sourceProperty, DataSourceUpdateMode updateMode) {
            target.DataBindings.Add(targetProperty, Controller, sourceProperty, true, updateMode);
        }
        protected virtual void BindProperties(DevExpress.XtraBars.BarItem target, string targetProperty, string sourceProperty, ConvertEventHandler objectToStringConverter) {
            Binding binding = new Binding(targetProperty, Controller, sourceProperty, true);
            binding.Format += objectToStringConverter;
            target.DataBindings.Add(binding);
        }
        protected virtual void BindToBoolPropertyAndInvert(DevExpress.XtraBars.BarItem target, string targetProperty, string sourceProperty) {
            target.DataBindings.Add(new BoolInvertBinding(targetProperty, Controller, sourceProperty));
        }
        protected virtual void BindBoolToVisibility(DevExpress.XtraBars.BarItem target, string targetProperty, string sourceProperty) {
            target.DataBindings.Add(new BoolToVisibilityBinding(targetProperty, Controller, sourceProperty, false));
        }
        protected virtual void BindBoolToVisibility(DevExpress.XtraBars.BarItem target, string targetProperty, string sourceProperty, bool invert) {
            target.DataBindings.Add(new BoolToVisibilityBinding(targetProperty, Controller, sourceProperty, invert));
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if (Controller == null)
                return;
            SubscribeControlsEvents();
            LoadFormData(Controller.EditedAppointmentCopy);
        }
        protected virtual AppointmentFormController CreateController(SchedulerControl control, Appointment apt) {
            return new AppointmentFormController(control, apt);
        }
        protected internal virtual void LoadIcons() {
            Assembly asm = typeof(SchedulerControl).Assembly;
            this._recurringIcon = ResourceImageHelper.CreateIconFromResources(SchedulerIconNames.RecurringAppointment, asm);
            this._normalIcon = ResourceImageHelper.CreateIconFromResources(SchedulerIconNames.Appointment, asm);
        }
        protected internal virtual void SubscribeControlsEvents() {
            this.edtEndDate.Validating += new CancelEventHandler(OnEdtEndDateValidating);
            this.edtEndDate.InvalidValue += new InvalidValueExceptionEventHandler(OnEdtEndDateInvalidValue);
            this.edtEndTime.Validating += new CancelEventHandler(OnEdtEndTimeValidating);
            this.edtEndTime.InvalidValue += new InvalidValueExceptionEventHandler(OnEdtEndTimeInvalidValue);
            this.riDuration.Validating += new CancelEventHandler(OnCbReminderValidating);
        }
        protected internal virtual void UnsubscribeControlsEvents() {
            this.edtEndDate.Validating -= new CancelEventHandler(OnEdtEndDateValidating);
            this.edtEndDate.InvalidValue -= new InvalidValueExceptionEventHandler(OnEdtEndDateInvalidValue);
            this.edtEndTime.Validating -= new CancelEventHandler(OnEdtEndTimeValidating);
            this.edtEndTime.InvalidValue -= new InvalidValueExceptionEventHandler(OnEdtEndTimeInvalidValue);
            this.riDuration.Validating -= new CancelEventHandler(OnCbReminderValidating);
        }
        protected internal virtual void OnEdtEndDateValidating(object sender, CancelEventArgs e) {
            e.Cancel = !IsValidInterval();
            if (!e.Cancel)
                this.edtEndDate.DataBindings["EditValue"].WriteValue();
        }
        protected internal virtual void OnEdtEndDateInvalidValue(object sender, InvalidValueExceptionEventArgs e) {
            e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_InvalidEndDate);
        }
        protected internal virtual void OnEdtEndTimeValidating(object sender, CancelEventArgs e) {
            e.Cancel = !IsValidInterval();
            if (!e.Cancel)
                this.edtEndTime.DataBindings["EditValue"].WriteValue();
        }
        protected internal virtual void OnEdtEndTimeInvalidValue(object sender, InvalidValueExceptionEventArgs e) {
            e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_InvalidEndDate);
        }
        protected internal virtual bool IsValidInterval() {
            return AppointmentFormControllerBase.ValidateInterval(edtStartDate.DateTime.Date, edtStartTime.Time.TimeOfDay, edtEndDate.DateTime.Date, edtEndTime.Time.TimeOfDay);
        }
        protected internal virtual void OnOkButton() {
            Save(true);
        }
        protected virtual void OnSaveButton() {
            Save(false);
        }
        private void Save(bool closeAfterSave) {
            if (!ValidateEndDateAndTime())
                return;
            if (!SaveFormData(Controller.EditedAppointmentCopy))
                return;
            if (!Controller.IsConflictResolved()) {
                ShowMessageBox(SchedulerLocalizer.GetString(SchedulerStringId.Msg_Conflict), Controller.GetMessageBoxCaption(SchedulerStringId.Msg_Conflict), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (Controller.IsAppointmentChanged() || Controller.IsNewAppointment || IsAppointmentChanged(Controller.EditedAppointmentCopy))
                Controller.ApplyChanges();
            if (closeAfterSave) {
                this._supressCancelCore = true;
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
        private bool ValidateEndDateAndTime() {
            this.edtEndDate.DoValidate();
            this.edtEndTime.DoValidate();

            return String.IsNullOrEmpty(this.edtEndTime.ErrorText) && String.IsNullOrEmpty(this.edtEndDate.ErrorText);
        }
        protected virtual void OnSaveAsButton() {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "iCalendar files (*.ics)|*.ics";
            fileDialog.FilterIndex = 1;
            if (fileDialog.ShowDialog() != DialogResult.OK)
                return;
            try {
                using (Stream stream = fileDialog.OpenFile())
                    ExportAppointment(stream);
            } catch {
                ShowMessageBox("Error: could not export appointments", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ExportAppointment(Stream stream) {
            if (stream == null)
                return;

            AppointmentBaseCollection aptsToExport = new AppointmentBaseCollection();
            aptsToExport.Add(Controller.EditedAppointmentCopy);
            iCalendarExporter exporter = new iCalendarExporter(this._storage, aptsToExport);

            exporter.ProductIdentifier = "-//Developer Express Inc.";
            exporter.Export(stream);
        }
        protected internal virtual DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon) {
            return XtraMessageBox.Show(this, text, caption, buttons, icon);
        }
        protected internal virtual void OnDeleteButton() {
            if (IsNewAppointment)
                return;

            Controller.DeleteAppointment();

            DialogResult = DialogResult.Abort;
            Close();
        }
        protected internal virtual void OnRecurrenceButton() {
            if (!Controller.ShouldShowRecurrenceButton)
                return;

            Appointment patternCopy = Controller.PrepareToRecurrenceEdit();

            DialogResult result;
            using (Form form = CreateAppointmentRecurrenceForm(patternCopy, SchedulerControl.OptionsView.FirstDayOfWeek)) {
                result = ShowRecurrenceForm(form);
            }

            if (result == DialogResult.Abort) {
                Controller.RemoveRecurrence();
            } else if (result == DialogResult.OK) {
                Controller.ApplyRecurrence(patternCopy);
            }

            this.btnRecurrence.Down = Controller.IsRecurrentAppointment;
        }
        protected virtual void OnCloseButton() {
            this.Close();
        }

        private bool CancelCore() {
            bool result = true;

            if (DialogResult != System.Windows.Forms.DialogResult.Abort && Controller != null && Controller.IsAppointmentChanged() && !this._supressCancelCore) {
                DialogResult saveBeforeCloseDialogResult = ShowMessageBox(SchedulerLocalizer.GetString(SchedulerStringId.Msg_SaveBeforeClose), Controller.GetMessageBoxCaption(SchedulerStringId.Msg_SaveBeforeClose), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (saveBeforeCloseDialogResult == System.Windows.Forms.DialogResult.Cancel)
                    result = false;
                else if (saveBeforeCloseDialogResult == System.Windows.Forms.DialogResult.Yes)
                    Save(true);
            }

            return result;
        }

        protected virtual DialogResult ShowRecurrenceForm(Form form) {
            return FormTouchUIAdapter.ShowDialog(form, this);
        }
        protected internal virtual Form CreateAppointmentRecurrenceForm(Appointment patternCopy, DevExpress.XtraScheduler.FirstDayOfWeek firstDayOfWeek) {
            AppointmentRecurrenceForm form = new AppointmentRecurrenceForm(patternCopy, firstDayOfWeek, Controller);
            form.SetMenuManager(MenuManager);
            form.LookAndFeel.ParentLookAndFeel = LookAndFeel;
            form.ShowExceptionsRemoveMsgBox = _controller.AreExceptionsPresent();
            return form;
        }
        internal void OnAppointmentFormActivated(object sender, EventArgs e) {
            if (_openRecurrenceForm) {
                _openRecurrenceForm = false;
                OnRecurrenceButton();
            }
        }
        protected internal virtual void OnCbReminderValidating(object sender, CancelEventArgs e) {
            TimeSpan span = (TimeSpan)barReminder.EditValue;
            e.Cancel = span.Ticks < 0 && span != TimeSpan.MinValue;
            if (!e.Cancel)
                this.barReminder.DataBindings["EditValue"].WriteValue();
        }

        protected internal virtual void OnNextButton() {
            if (CancelCore()) {
                this._supressCancelCore = true;
                OpenNextAppointmentCommand command = new OpenNextAppointmentCommand(SchedulerControl);
                command.Execute();
                this.Close();
            }
        }

        protected internal virtual void OnPreviousButton() {
            if (CancelCore()) {
                this._supressCancelCore = true;
                OpenPrevAppointmentCommand command = new OpenPrevAppointmentCommand(SchedulerControl);
                command.Execute();
                this.Close();
            }
        }

        protected internal virtual void OnTimeZonesButton() {
            Controller.TimeZoneVisible = !Controller.TimeZoneVisible;
        }

        protected virtual void OnApplicationButtonClick() {
            this.dvInfo.Document = SchedulerControl.GetPrintPreviewDocument(new MemoPrintStyle());
            this.dvInfo.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.ZoomToWholePage);
        }

        private void btnSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            OnOkButton();
        }

        private void barButtonDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            OnDeleteButton();
        }

        private void barRecurrence_ItemClick(object sender, ItemClickEventArgs e) {
            OnRecurrenceButton();
        }

        private void bvbSave_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e) {
            OnSaveButton();
        }

        private void bvbSaveAs_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e) {
            OnSaveAsButton();
        }

        private void bvbClose_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e) {
            OnCloseButton();
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e) {
            OnSaveButton();
        }

        protected override void OnClosing(CancelEventArgs e) {
            e.Cancel = !CancelCore();
            base.OnClosing(e);
        }

        private void btnNext_ItemClick(object sender, ItemClickEventArgs e) {
            OnNextButton();
        }

        private void btnPrevious_ItemClick(object sender, ItemClickEventArgs e) {
            OnPreviousButton();
        }

        private void btnTimeZones_ItemClick(object sender, ItemClickEventArgs e) {
            OnTimeZonesButton();
        }

        private void ribbonControl1_ApplicationButtonClick(object sender, EventArgs e) {
            OnApplicationButtonClick();
        }

        private void OutlookAppointmentForm_Load(object sender, EventArgs e) {

        }
    }
}
