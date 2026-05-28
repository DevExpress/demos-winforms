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
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Native;
using DevExpress.XtraScheduler.iCalendar;
using DevExpress.XtraScheduler.Localization;
using DevExpress.XtraScheduler.Native;
using DevExpress.XtraScheduler.Printing;
using DevExpress.XtraScheduler.UI;
using DevExpress.XtraScheduler.Commands;
using System.Collections.Generic;
using DevExpress.XtraScheduler.Demos.DemoData;
using System.Linq;
using DevExpress.LookAndFeel;

namespace DevExpress.XtraScheduler.Demos {
    /// <summary>
    /// Summary description for AppointmentRibbonForm.
    /// </summary>
    public partial class OutlookAppointmentForm : RibbonForm, IDXManagerPopupMenu {
        Icon _recurringIcon;
        Icon _normalIcon;
        readonly MyAppointmentFormController _controller;
        IDXMenuManager _menuManager;
        bool _suppressCancelCore;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public OutlookAppointmentForm() {
            InitializeComponent();
        }
        public OutlookAppointmentForm(SchedulerControl control, Appointment apt)
            : this(control, apt, false) {
        }
        public OutlookAppointmentForm(SchedulerControl control, Appointment apt, bool openRecurrenceForm) {
            Guard.ArgumentNotNull(control, "control");
            Guard.ArgumentNotNull(control.DataStorage, "control.DataStorage");
            Guard.ArgumentNotNull(apt, "apt");

            OpenRecurrenceForm = openRecurrenceForm;
            this._controller = CreateController(control, apt);
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            SetupPredefinedConstraints();

            LoadIcons();

            Control = control;
            Storage = control.DataStorage;


            this.riAppointmentResource.SchedulerControl = control;
            this.riAppointmentResource.Storage = Storage;
            this.riAppointmentStatus.Storage = Storage;

            this.riAppointmentLabel.Storage = Storage;

            BindControllerToControls();

            LookAndFeel.ParentLookAndFeel = control.LookAndFeel;

            this._suppressCancelCore = false;

            new LabelsSubMenuController(this.pmCategorize, this._controller).PopulateFrom(control.DataStorage.Appointments.Labels);
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IDXMenuManager MenuManager { get { return this._menuManager; } private set { this._menuManager = value; } }
        protected internal MyAppointmentFormController Controller { get { return this._controller; } }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        protected internal SchedulerControl Control { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        protected internal ISchedulerStorage Storage { get; set; }
        protected internal bool IsNewAppointment { get { return this._controller != null ? this._controller.IsNewAppointment : true; } }
        protected internal Icon RecurringIcon { get { return this._recurringIcon; } }
        protected internal Icon NormalIcon { get { return this._normalIcon; } }
        [DefaultValue(false)]
        protected internal bool OpenRecurrenceForm { get; private set; }
        [DXDescription("DevExpress.XtraScheduler.UI.AppointmentRibbonForm,ReadOnly")]
        [DXCategory(CategoryName.Behavior)]
        [DefaultValue(false)]
        public bool ReadOnly {
            get { return Controller.ReadOnly; }
            set {
                if (Controller.ReadOnly == value)
                    return;
                Controller.ReadOnly = value;
            }
        }
        protected override FormShowMode ShowMode { get { return FormShowMode.AfterInitialization; } }

        public virtual void LoadFormData(Appointment appointment) {
            this.barStatus.Enabled = !TimeRegionHelper.IsIntersectWithRegion(appointment.Start, appointment.End);
        }
        public virtual bool SaveFormData(Appointment appointment) {
            return true;
        }
        public virtual bool IsAppointmentChanged(Appointment appointment) {
            return false;
        }
        public virtual void SetMenuManager(IDXMenuManager menuManager) {
            MenuManagerUtils.SetMenuManager(Controls, menuManager);
            this._menuManager = menuManager;
        }

        protected internal virtual void SetupPredefinedConstraints() {
            this.tbProgress.Properties.Minimum = AppointmentProcessValues.Min;
            this.tbProgress.Properties.Maximum = AppointmentProcessValues.Max;
            this.tbProgress.Properties.SmallChange = AppointmentProcessValues.Step;
        }
        protected virtual void BindControllerToControls() {
            DataBindings.Add("Text", Controller, "Caption");
            BindControllerToIcon();
            BindProperties(this.tbSubject, "Text", "Subject");
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
            BindProperties(this.chkAllDay, "Checked", "AllDay");
            BindProperties(this.chkAllDay, "Enabled", "IsDateTimeEditable");

            BindProperties(this.barLabel, "EditValue", "Label");

            BindProperties(this.barStatus, "EditValue", "Status");

            BindBoolToVisibility(this.barReminder, "Visibility", "ReminderVisible");
            BindProperties(this.barReminder, "Editvalue", "ReminderTimeBeforeStart");

            BindProperties(this.tbProgress, "Value", "PercentComplete");
            BindProperties(this.lblPercentCompleteValue, "Text", "PercentComplete", ObjectToStringConverter);
            this.tablePanel1.Rows[6].Visible = Controller.ShouldEditTaskProgress;
            BindProperties(this.btnDelete, "Enabled", "CanDeleteAppointment");

            BindBoolToVisibility(this.btnRecurrence, "Visibility", "ShouldShowRecurrenceButton");
            BindProperties(this.btnRecurrence, "Down", "IsRecurrentAppointment");

            BindProperties(this.lblResource, "Enabled", "CanEditResource");

            BindProperties(this.edtResources, "ResourceIds", "ResourceIds");
            BindProperties(this.edtResources, "Visible", "ResourceSharing");
            BindProperties(this.edtResources, "Enabled", "CanEditResource");

            BindProperties(this.edtResource, "ResourceId", "ResourceId");
            BindProperties(this.edtResource, "Enabled", "CanEditResource");
            BindToBoolPropertyAndInvert(this.edtResource, "Visible", "ResourceSharing");

            BindToBoolPropertyAndInvert(this.ribbonControl1, "Enabled", "ReadOnly");

            BindProperties(this.edtTimeZone, "Visible", "TimeZoneVisible");
            BindProperties(this.edtTimeZone, "EditValue", "TimeZoneId");
            BindProperties(this.edtTimeZone, "Enabled", "TimeZoneEnabled");

            BindBoolToVisibility(this.btnTimeZones, "Visibility", "TimeZonesEnabled");
            BindProperties(this.btnTimeZones, "Down", "TimeZoneVisible");
            BindProperties(this.btnIsPrivate, "Down", "IsPrivate");
            BindProperties(this.btnLowImportance, "Down", "IsLowPriority");
            BindProperties(this.btnHighImportance, "Down", "IsHighPriority");
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

        protected virtual void BindProperties(BarItem target, string targetProperty, string sourceProperty) {
            BindProperties(target, targetProperty, sourceProperty, DataSourceUpdateMode.OnPropertyChanged);
        }
        protected virtual void BindProperties(BarItem target, string targetProperty, string sourceProperty, DataSourceUpdateMode updateMode) {
            target.DataBindings.Add(targetProperty, Controller, sourceProperty, true, updateMode);
        }
        protected virtual void BindProperties(BarItem target, string targetProperty, string sourceProperty, ConvertEventHandler objectToStringConverter) {
            Binding binding = new Binding(targetProperty, Controller, sourceProperty, true);
            binding.Format += objectToStringConverter;
            target.DataBindings.Add(binding);
        }
        protected virtual void BindToBoolPropertyAndInvert(BarItem target, string targetProperty, string sourceProperty) {
            target.DataBindings.Add(new BoolInvertBinding(targetProperty, Controller, sourceProperty));
        }
        protected virtual void BindBoolToVisibility(BarItem target, string targetProperty, string sourceProperty) {
            target.DataBindings.Add(new BoolToVisibilityBinding(targetProperty, Controller, sourceProperty, false));
        }
        protected virtual void BindBoolToVisibility(BarItem target, string targetProperty, string sourceProperty, bool invert) {
            target.DataBindings.Add(new BoolToVisibilityBinding(targetProperty, Controller, sourceProperty, invert));
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if (Controller == null)
                return;
            SubscribeControlsEvents();
            LoadFormData(Controller.EditedAppointmentCopy);
        }
        protected virtual MyAppointmentFormController CreateController(SchedulerControl control, Appointment apt) {
            return new MyAppointmentFormController(control, apt);
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
            this.edtStartDate.Validating += new CancelEventHandler(OnEdtStartDateValidating);
            this.edtStartDate.InvalidValue += new InvalidValueExceptionEventHandler(OnEdtStartDateInvalidValue);
            this.edtStartTime.Validating += new CancelEventHandler(OnEdtStartTimeValidating);
            this.edtStartTime.InvalidValue += new InvalidValueExceptionEventHandler(OnEdtStartTimeInvalidValue);
        }

        protected internal virtual void UnsubscribeControlsEvents() {
            this.edtEndDate.Validating -= new CancelEventHandler(OnEdtEndDateValidating);
            this.edtEndDate.InvalidValue -= new InvalidValueExceptionEventHandler(OnEdtEndDateInvalidValue);
            this.edtEndTime.Validating -= new CancelEventHandler(OnEdtEndTimeValidating);
            this.edtEndTime.InvalidValue -= new InvalidValueExceptionEventHandler(OnEdtEndTimeInvalidValue);
            this.riDuration.Validating -= new CancelEventHandler(OnCbReminderValidating);
            this.edtStartDate.Validating -= new CancelEventHandler(OnEdtStartDateValidating);
            this.edtStartDate.InvalidValue -= new InvalidValueExceptionEventHandler(OnEdtStartDateInvalidValue);
            this.edtStartTime.Validating -= new CancelEventHandler(OnEdtStartTimeValidating);
            this.edtStartTime.InvalidValue -= new InvalidValueExceptionEventHandler(OnEdtStartTimeInvalidValue);
        }

        protected internal virtual void OnEdtStartTimeInvalidValue(object sender, InvalidValueExceptionEventArgs e) {
            e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_DateOutsideLimitInterval);
        }
        protected internal virtual void OnEdtStartTimeValidating(object sender, CancelEventArgs e) {
            e.Cancel = !Controller.ValidateLimitInterval(this.edtStartDate.DateTime.Date, this.edtStartTime.Time.TimeOfDay, this.edtEndDate.DateTime.Date, this.edtEndTime.Time.TimeOfDay);
        }
        protected internal virtual void OnEdtStartDateInvalidValue(object sender, InvalidValueExceptionEventArgs e) {
            e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_DateOutsideLimitInterval);
        }
        protected internal virtual void OnEdtStartDateValidating(object sender, CancelEventArgs e) {
            e.Cancel = !Controller.ValidateLimitInterval(this.edtStartDate.DateTime.Date, this.edtStartTime.Time.TimeOfDay, this.edtEndDate.DateTime.Date, this.edtEndTime.Time.TimeOfDay);
        }
        protected internal virtual void OnEdtEndDateValidating(object sender, CancelEventArgs e) {
            e.Cancel = !IsValidInterval();
            if (!e.Cancel)
                this.edtEndDate.DataBindings["EditValue"].WriteValue();
        }
        protected internal virtual void OnEdtEndDateInvalidValue(object sender, InvalidValueExceptionEventArgs e) {
            if (!AppointmentFormControllerBase.ValidateInterval(this.edtStartDate.DateTime.Date, this.edtStartTime.Time.TimeOfDay, this.edtEndDate.DateTime.Date, this.edtEndTime.Time.TimeOfDay))
                e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_InvalidEndDate);
            else
                e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_DateOutsideLimitInterval);
        }
        protected internal virtual void OnEdtEndTimeValidating(object sender, CancelEventArgs e) {
            e.Cancel = !IsValidInterval();
            if (!e.Cancel)
                this.edtEndTime.DataBindings["EditValue"].WriteValue();
        }
        protected internal virtual void OnEdtEndTimeInvalidValue(object sender, InvalidValueExceptionEventArgs e) {
            if (!AppointmentFormControllerBase.ValidateInterval(this.edtStartDate.DateTime.Date, this.edtStartTime.Time.TimeOfDay, this.edtEndDate.DateTime.Date, this.edtEndTime.Time.TimeOfDay))
                e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_InvalidEndDate);
            else
                e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_DateOutsideLimitInterval);
        }
        protected internal virtual bool IsValidInterval() {
            return AppointmentFormControllerBase.ValidateInterval(this.edtStartDate.DateTime.Date, this.edtStartTime.Time.TimeOfDay, this.edtEndDate.DateTime.Date, this.edtEndTime.Time.TimeOfDay) &&
                Controller.ValidateLimitInterval(this.edtStartDate.DateTime.Date, this.edtStartTime.Time.TimeOfDay, this.edtEndDate.DateTime.Date, this.edtEndTime.Time.TimeOfDay);
        }
        protected internal virtual void OnOkButton() {
            Save(true);
        }
        protected virtual void OnSaveButton() {
            Save(false);
        }
        private void Save(bool closeAfterSave) {
            if (!ValidateDateAndTime())
                return;
            if (!SaveFormData(Controller.EditedAppointmentCopy))
                return;
            if (!Controller.IsConflictResolved()) {
                ShowMessageBox(SchedulerLocalizer.GetString(SchedulerStringId.Msg_Conflict), Controller.GetMessageBoxCaption(SchedulerStringId.Msg_Conflict), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!Controller.IsTimeValid()) {
                ShowMessageBox(SchedulerLocalizer.GetString(SchedulerStringId.Msg_InvalidAppointmentTime), Controller.GetMessageBoxCaption(SchedulerStringId.Msg_InvalidAppointmentTime), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (IsAppointmentChanged(Controller.EditedAppointmentCopy) || Controller.IsAppointmentChanged() || Controller.IsNewAppointment)
                Controller.ApplyChanges();
            if (closeAfterSave) {
                this._suppressCancelCore = true;
                DialogResult = DialogResult.OK;
            }
        }
        private bool ValidateDateAndTime() {
            this.edtEndDate.DoValidate();
            this.edtEndTime.DoValidate();
            this.edtStartDate.DoValidate();
            this.edtStartTime.DoValidate();

            return String.IsNullOrEmpty(this.edtEndTime.ErrorText) && String.IsNullOrEmpty(this.edtEndDate.ErrorText) && String.IsNullOrEmpty(this.edtStartDate.ErrorText) && String.IsNullOrEmpty(this.edtStartTime.ErrorText);
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
            iCalendarExporter exporter = new iCalendarExporter(Storage, aptsToExport);

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
            using (Form form = CreateAppointmentRecurrenceForm(patternCopy, Control.OptionsView.FirstDayOfWeek)) {
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
            Close();
        }

        private bool CancelCore() {
            bool result = true;

            if (DialogResult != DialogResult.Abort && Controller != null && Controller.IsAppointmentChanged() && !this._suppressCancelCore) {
                DialogResult saveBeforeCloseDialogResult = ShowMessageBox(SchedulerLocalizer.GetString(SchedulerStringId.Msg_SaveBeforeClose), Controller.GetMessageBoxCaption(SchedulerStringId.Msg_SaveBeforeClose), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (saveBeforeCloseDialogResult == DialogResult.Cancel)
                    result = false;
                else if (saveBeforeCloseDialogResult == DialogResult.Yes)
                    Save(true);
            }

            return result;
        }

        protected virtual DialogResult ShowRecurrenceForm(Form form) {
            return FormTouchUIAdapter.ShowDialog(form, this);
        }
        protected internal virtual Form CreateAppointmentRecurrenceForm(Appointment patternCopy, FirstDayOfWeek firstDayOfWeek) {
            AppointmentRecurrenceForm form = new AppointmentRecurrenceForm(patternCopy, firstDayOfWeek, Controller);
            form.SetMenuManager(MenuManager);
            form.LookAndFeel.ParentLookAndFeel = LookAndFeel;
            form.ShowExceptionsRemoveMsgBox = this._controller.AreExceptionsPresent();
            return form;
        }

        protected override void OnShown(EventArgs e) {
            base.OnShown(e);
            if (OpenRecurrenceForm) {
                OpenRecurrenceForm = false;
                OnRecurrenceButton();
            }
        }

        protected internal virtual void OnCbReminderValidating(object sender, CancelEventArgs e) {
            TimeSpan span = (TimeSpan)this.barReminder.EditValue;
            e.Cancel = span.Ticks < 0 && span != TimeSpan.MinValue;
            if (!e.Cancel)
                this.barReminder.DataBindings["EditValue"].WriteValue();
        }

        protected internal virtual void OnNextButton() {
            if (CancelCore()) {
                this._suppressCancelCore = true;
                OpenNextAppointmentCommand command = new OpenNextAppointmentCommand(Control);
                command.Execute();
                Close();
            }
        }

        protected internal virtual void OnPreviousButton() {
            if (CancelCore()) {
                this._suppressCancelCore = true;
                OpenPrevAppointmentCommand command = new OpenPrevAppointmentCommand(Control);
                command.Execute();
                Close();
            }
        }

        protected internal virtual void OnTimeZonesButton() {
            Controller.TimeZoneVisible = !Controller.TimeZoneVisible;
        }

        protected virtual void OnApplicationButtonClick() {
            this.dvInfo.Document = Control.GetPrintPreviewDocument(new RibbonFormPreviewMemoPrintStyle(Controller.EditedAppointmentCopy));
            this.dvInfo.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.ZoomToWholePage);
        }

        protected virtual void OnPrintButton() {
            this.dvInfo.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.PrintDirect);
        }

        private void btnSaveAndClose_ItemClick(object sender, ItemClickEventArgs e) {
            OnOkButton();
        }

        private void barButtonDelete_ItemClick(object sender, ItemClickEventArgs e) {
            OnDeleteButton();
        }

        private void barRecurrence_ItemClick(object sender, ItemClickEventArgs e) {
            OnRecurrenceButton();
        }

        private void bvbSave_ItemClick(object sender, BackstageViewItemEventArgs e) {
            OnSaveButton();
        }

        private void bvbSaveAs_ItemClick(object sender, BackstageViewItemEventArgs e) {
            OnSaveAsButton();
        }

        private void bvbClose_ItemClick(object sender, BackstageViewItemEventArgs e) {
            OnCloseButton();
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e) {
            OnSaveButton();
        }

        protected override void OnFormClosing(FormClosingEventArgs e) {
            e.Cancel = !CancelCore();
            base.OnFormClosing(e);
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

        private void btnPrint_Click(object sender, EventArgs e) {
            OnPrintButton();
        }

        protected override void Dispose(bool disposing) {
            if (disposing) {
                if (this.components != null) {
                    this.components.Dispose();
                }
                if (LookAndFeel != null)
                    LookAndFeel.ParentLookAndFeel = null;
            }
            base.Dispose(disposing);
        }
        
        void OnBtnIsPrivateItemClick(object sender, ItemClickEventArgs e) {
            Controller.IsPrivate = this.btnIsPrivate.Down;
        }

        void OnBtnHightImportanceItemClick(object sender, ItemClickEventArgs e) {
            Controller.IsHighPriority = this.btnHighImportance.Down;
        }

        void OnBtnLowImportanceItemClick(object sender, ItemClickEventArgs e) {
            Controller.IsLowPriority = this.btnLowImportance.Down;
        }

        class LabelsSubMenuController {
            PopupMenu popupMenu;
            MyAppointmentFormController controller;
            public LabelsSubMenuController(PopupMenu popupMenu, MyAppointmentFormController controller) {
                this.popupMenu = popupMenu;
                this.controller = controller;
            }

            public void PopulateFrom(IAppointmentLabelStorage labels) {
                foreach (IAppointmentLabel label in labels) {                    
                    LabelBarItem item = new LabelBarItem(label, controller.Control.LookAndFeel);
                    this.popupMenu.AddItem(item);
                    item.Checked = this.controller.LabelKey.Equals(item.Label.Id);
                    item.ItemClick += OnLabelBarItemClicker;
                }
            }

            void OnLabelBarItemClicker(object sender, ItemClickEventArgs e) {
                LabelBarItem item = (LabelBarItem)e.Item;
                this.controller.LabelKey = item.Label.Id;
                UpdatePopupMenu();
            }

            void UpdatePopupMenu() {
                foreach (BarCheckItemLink barItemLink in this.popupMenu.ItemLinks) {
                    LabelBarItem item = ((LabelBarItem)barItemLink.Item);
                    item.Checked = this.controller.LabelKey.Equals(item.Label.Id);
                }
            }
        }
    }

    public class MyAppointmentFormController : AppointmentFormController {
        public MyAppointmentFormController(SchedulerControl control, Appointment apt) : base(control, apt) {
        }

        public bool IsPrivate { get { return EditedAppointmentCopy.GetIsPrivate(); } set { EditedAppointmentCopy.SetIsPrivate(value); } }
        public EventPriority Priority { get { return EditedAppointmentCopy.GetPriority(); } set { EditedAppointmentCopy.SetPriority(value); } }
        public bool IsHighPriority {
            get { return EditedAppointmentCopy.GetPriority() == EventPriority.Important; }
            set {
                if (IsHighPriority == value)
                    return;
                EditedAppointmentCopy.SetPriority(value ? EventPriority.Important : EventPriority.None);
                NotifyPropertyChanged("IsHighPriority");
                NotifyPropertyChanged("IsLowPriority");
            }
        }
        public bool IsLowPriority {
            get { return EditedAppointmentCopy.GetPriority() == EventPriority.NotImportant; }
            set {
                if (IsLowPriority == value)
                    return;
                EditedAppointmentCopy.SetPriority(value ? EventPriority.NotImportant : EventPriority.None);
                NotifyPropertyChanged("IsHighPriority");
                NotifyPropertyChanged("IsLowPriority");
            }
        }

        public List<string> GetLocations() {
            return SchedulerDataHelper.GetLocations(Control).Select(x => x.Caption).ToList();
        }

        public override void ApplyChanges() {
            if (IsAppointmentChanged()) 
                SchedulerDataHelper.AddLocation(Control, Location);
            base.ApplyChanges();
        }

        public override bool IsAppointmentChanged() {
            bool isAppointmentWasChanged = base.IsAppointmentChanged();
            if (IsPrivate != SourceAppointment.GetIsPrivate())
                isAppointmentWasChanged = true;
            if (Priority != SourceAppointment.GetPriority())
                isAppointmentWasChanged = true;
            return isAppointmentWasChanged;
        }
        public new SchedulerControl Control { get { return base.Control; } }
    }

    public class LabelBarItem : BarCheckItem {
        Image image;
        Image largeImage;

        public LabelBarItem(IAppointmentLabel label, UserLookAndFeel lookAndFeel) {
            Color color = label.GetColor();
            if(label is AppointmentLabel appointmentLabel && lookAndFeel != null && appointmentLabel.ColorId != SchedulerColorId.Nothing) {
                color = AppointmentLabel.GetDefaultColorByStringId(appointmentLabel.ColorId, lookAndFeel);
                SchedulerColorId colorId = appointmentLabel.ColorId;
                if(color == Color.Empty) {
                    color = label.GetColor();
                }
            }
            this.image = CreateBitmap(color, 16, 16);
            this.largeImage = CreateBitmap(color, 32, 32);
            Caption = label.DisplayName;
            Label = label;
        }

        internal static Bitmap CreateBitmap(Color color, int width, int height) {
            Rectangle rectangle = new Rectangle(0, 0, width, height);
            Bitmap bitmap = new Bitmap(rectangle.Width, rectangle.Height);
            using(Brush brush = new SolidBrush(color)) {
                using(Graphics graphics = Graphics.FromImage(bitmap)) {
                    if(brush != null) {
                        graphics.FillRectangle(brush, rectangle);
                    }

                    graphics.FillRectangle(Brushes.Black, RectUtils.GetTopSideRect(rectangle, 1));
                    graphics.FillRectangle(Brushes.Black, RectUtils.GetLeftSideRect(rectangle, 1));
                    graphics.FillRectangle(Brushes.Black, RectUtils.GetRightSideRect(rectangle, 1));
                    graphics.FillRectangle(Brushes.Black, RectUtils.GetBottomSideRect(rectangle, 1));
                }
            }
            return bitmap;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IAppointmentLabel Label { get; private set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Image LargeGlyph {
            get { return this.largeImage; }

            set { }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Image Glyph {
            get { return this.image; }
            set { }
        }
    }
}
