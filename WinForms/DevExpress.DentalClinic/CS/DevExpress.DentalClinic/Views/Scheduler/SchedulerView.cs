using DevExpress.DentalClinic.ViewModel;
using DevExpress.DentalClinic.Views.Scheduler;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DevExpress.DentalClinic.View {
    public partial class SchedulerView : XtraUserControl {
        public SchedulerView() {
            InitializeComponent();
            schedulerControl.BeginUpdate();
            InitializeColoredStatuses();
            if(!mvvmContext1.IsDesignMode)
                InitializeBindings();
            schedulerControl.Start = DateTime.Today;
            schedulerControl.TimelineView.Scales.ForEach(x => x.Width = 200);
            schedulerControl.OptionsView.ResourceCategories.ResourceDisplayStyle = ResourceDisplayStyle.Tabs;
            schedulerControl.OptionsView.ResourceCategories.AppointmentDisplayMode = AppointmentDisplayMode.SelectedResource;

            schedulerControl.OptionsView.ResourceCategories.ShowCloseButton = false;
            schedulerControl.OptionsView.ResourceCategories.ShowAddButton = false;
            schedulerControl.ResourceNavigator.Visibility = ResourceNavigatorVisibility.Never;
            schedulerControl.DayView.ShowAllDayArea = false;
            schedulerControl.DayView.AppointmentDisplayOptions.StatusDisplayType = AppointmentStatusDisplayType.Bounds;
            schedulerControl.WorkWeekView.AppointmentDisplayOptions.StatusDisplayType = AppointmentStatusDisplayType.Bounds;
            schedulerControl.FullWeekView.AppointmentDisplayOptions.StatusDisplayType = AppointmentStatusDisplayType.Bounds;
            schedulerControl.MonthView.AppointmentDisplayOptions.StatusDisplayType = AppointmentStatusDisplayType.Bounds;
            schedulerControl.OptionsView.ColorizeResources = false;
            GroupResources();
            schedulerControl.DayView.AppointmentDisplayOptions.AllowHtmlText = true;
            schedulerControl.WeekView.AppointmentDisplayOptions.AllowHtmlText = true;
            schedulerControl.YearView.AppointmentDisplayOptions.AllowHtmlText = true;
            schedulerControl.YearView.AppointmentDisplayOptions.AppointmentAutoHeight = true;
            schedulerControl.WorkWeekView.AppointmentDisplayOptions.AllowHtmlText = true;
            schedulerControl.FullWeekView.AppointmentDisplayOptions.AllowHtmlText = true;
            schedulerControl.MonthView.AppointmentDisplayOptions.AllowHtmlText = true;
            schedulerControl.MonthView.AppointmentDisplayOptions.AppointmentAutoHeight = true;
            schedulerControl.TimelineView.AppointmentDisplayOptions.AllowHtmlText = true;
            schedulerControl.TimelineView.AppointmentDisplayOptions.AppointmentAutoHeight = true;
            //schedulerControl.AgendaView.AppointmentDisplayOptions.AllowHtmlText = true;
            schedulerControl.AgendaView.AppointmentDisplayOptions.AppointmentAutoHeight = true;
            schedulerControl.InitAppointmentDisplayText += OnInitAppointmentDisplayText;
            schedulerControl.EndUpdate();
            schedulerDataStorage1.FilterAppointment += SchedulerDataStorage1_FilterAppointment;

            diagnosisButton.Click += filterButonClick;
            hygieneButton.Click += filterButonClick;
            implantationButton.Click += filterButonClick;
            orthodonticsButton.Click += filterButonClick;
            prostheticsButton.Click += filterButonClick;
            restorationButton.Click += filterButonClick;
            rootCanalButton.Click += filterButonClick;
            surgeryButton.Click += filterButonClick;
            whiteningButton.Click += filterButonClick;
            buttons.AddRange(new SimpleButton[] { diagnosisButton, hygieneButton, implantationButton, orthodonticsButton, prostheticsButton, restorationButton, rootCanalButton, surgeryButton, whiteningButton });
            LookAndFeel.StyleChanged += (s, e) => InitializeColoredStatuses();
        }
        void SchedulerDataStorage1_FilterAppointment(object sender, PersistentObjectCancelEventArgs e) {
            var result = buttons.Any(x => (int)x.Tag == (int)((Appointment)e.Object).StatusKey);
            e.Cancel = !result;
        }

        List<SimpleButton> buttons = new List<SimpleButton>();
        private void filterButonClick(object sender, EventArgs e) {
            ControlUtils.SuspendRedraw(this);
            try {
                var button = sender as SimpleButton;
                if(buttons.Count == 9) {
                    foreach(var item in buttons) {
                        if(item == button) continue;
                        item.PaintStyle = XtraEditors.Controls.PaintStyles.Light;
                    }
                    buttons.Clear();
                    buttons.Add(button);
                    schedulerDataStorage1.Appointments.Filter = $"[Status] in ({(int)button.Tag})";
                    return;
                }
                if(buttons.Count == 1 && buttons.Contains(button)) {
                    buttons.Clear();
                    buttons.AddRange(new SimpleButton[] { diagnosisButton, hygieneButton, implantationButton, orthodonticsButton, prostheticsButton, restorationButton, rootCanalButton, surgeryButton, whiteningButton });
                    foreach(var item in buttons) {
                        item.PaintStyle = XtraEditors.Controls.PaintStyles.Default;
                    }
                    schedulerDataStorage1.Appointments.Filter = $"[Status] in ({string.Join(",", buttons.Select(x => ((int)x.Tag).ToString()))})"; ;
                    return;
                }
                if(button.PaintStyle == XtraEditors.Controls.PaintStyles.Default) {
                    button.PaintStyle = XtraEditors.Controls.PaintStyles.Light;
                    buttons.Remove(button);
                }
                else {
                    buttons.Add(button);
                    button.PaintStyle = XtraEditors.Controls.PaintStyles.Default;
                }
                schedulerDataStorage1.Appointments.Filter = $"[Status] in ({string.Join(",", buttons.Select(x => ((int)x.Tag).ToString()))})"; ;
            }
            finally {
                ControlUtils.ResumeRedraw(this);
            }
        }
        void OnInitAppointmentDisplayText(object sender, AppointmentDisplayTextEventArgs e) {
            if(e.Appointment.AllDay)
                return;
            var app = e.Appointment.RowHandle as Model.Appointment;
            if(app == null) return;
            var descriptionStringBuilder = new StringBuilder();
            var color = LookAndFeelHelper.GetSystemColorEx(LookAndFeel, SystemColors.ControlText);
            descriptionStringBuilder.Append($"<color={color.R},{color.G},{color.B}>");
            descriptionStringBuilder.Append("<size=2><br> <br></size>");
            descriptionStringBuilder.Append($"{app.Date.ToString("hh:mm tt")} - {app.EndDate.ToString("hh:mm tt")}");
            descriptionStringBuilder.Append("<size=2><br> <br></size>");
            descriptionStringBuilder.Append($"{app.Patient.FullName}");
            descriptionStringBuilder.Append("<size=3><br> <br></size><r>");
            foreach(var item in app.ProcedureCollection) {
                descriptionStringBuilder.Append($"{item.Procedure.Name}<size=2>");
                descriptionStringBuilder.Append("<br> <br></size>");
            }
            descriptionStringBuilder.Append($"</color>");
            e.Text = descriptionStringBuilder.ToString();
        }
        void GroupResources() {
            schedulerControl.BeginUpdate();
            schedulerControl.ResourceCategories.Clear();
            ResourceCategory group = new ResourceCategory();
            for(int i = 0; i < schedulerDataStorage1.Resources.Count; i++) {
                group.Resources.Add(schedulerDataStorage1.Resources[i]);
            }
            schedulerControl.ResourceCategories.Add(group);
            schedulerControl.EndUpdate();
        }
        void InitializeBindings() {
            var fluentAPI = mvvmContext1.OfType<SchedulerViewModel>();
            fluentAPI.SetBinding(xpBindingSource1, x => x.DataSource, x => x.Appointments);
            fluentAPI.SetBinding(xpBindingSource2, x => x.DataSource, x => x.Doctors);
            fluentAPI.SetTrigger(x => x.ReloadResource, (s) => GroupResources());
            fluentAPI.WithEvent<AppointmentFormEventArgs>(schedulerControl, "EditAppointmentFormShowing")
                .EventToCommand(x => x.CreateOrEditAppointment, args =>
                {
                    args.Handled = true;
                    return new AppointmentInfo()
                    {
                        Id = args.Appointment.Id,
                        Date = args.Appointment.Start,
                        ResourceId = schedulerControl.SelectedResource.Id
                    };
                });
        }
        void OnFilterAppointment(object sender, PersistentObjectCancelEventArgs e) {
            var apt = (XtraScheduler.Appointment)e.Object;
            e.Cancel = (Model.AppointmentStatus)apt.LabelKey == Model.AppointmentStatus.Canceled;
        }
        void OnSchedulerControlPopupMenuShowing(object sender, PopupMenuShowingEventArgs e) {
            if(e.Menu.Id == SchedulerMenuItemId.AppointmentMenu ||
                e.Menu.Id == SchedulerMenuItemId.AppointmentDragMenu)
                e.Menu = null;
        }
        Dictionary<Model.ProcedureGroup, Color> statusColorIdDictionary = new Dictionary<Model.ProcedureGroup, Color>();
        void InitializeColoredStatuses() {
            statusColorIdDictionary.Clear();
            var backColor = LookAndFeelHelper.GetSystemColorEx(LookAndFeel, SystemColors.Window);
            tablePanel1.BackColor = backColor;
            if(backColor.R < 150) {
                statusColorIdDictionary.Add(Model.ProcedureGroup.Diagnosis, Color.FromArgb(246, 141, 153));
                statusColorIdDictionary.Add(Model.ProcedureGroup.Hygiene, Color.FromArgb(247, 182, 57));
                statusColorIdDictionary.Add(Model.ProcedureGroup.Implantation, Color.FromArgb(112, 213, 176));
                statusColorIdDictionary.Add(Model.ProcedureGroup.Orthodontics, Color.FromArgb(154, 213, 91));
                statusColorIdDictionary.Add(Model.ProcedureGroup.Prosthetics, Color.FromArgb(121, 190, 244));
                statusColorIdDictionary.Add(Model.ProcedureGroup.Restoration, Color.FromArgb(176, 155, 237));
                statusColorIdDictionary.Add(Model.ProcedureGroup.RootCanal, Color.FromArgb(233, 133, 215));
                statusColorIdDictionary.Add(Model.ProcedureGroup.Surgery, Color.FromArgb(120, 214, 231));
                statusColorIdDictionary.Add(Model.ProcedureGroup.Whitening, Color.FromArgb(255, 234, 0));
            }
            else {
                statusColorIdDictionary.Add(Model.ProcedureGroup.Diagnosis, Color.FromArgb(218, 12, 12));
                statusColorIdDictionary.Add(Model.ProcedureGroup.Hygiene, Color.FromArgb(253, 71, 0));
                statusColorIdDictionary.Add(Model.ProcedureGroup.Implantation, Color.FromArgb(45, 105, 5));
                statusColorIdDictionary.Add(Model.ProcedureGroup.Orthodontics, Color.FromArgb(10, 117, 78));
                statusColorIdDictionary.Add(Model.ProcedureGroup.Prosthetics, Color.FromArgb(9, 94, 159));
                statusColorIdDictionary.Add(Model.ProcedureGroup.Restoration, Color.FromArgb(98, 71, 172));
                statusColorIdDictionary.Add(Model.ProcedureGroup.RootCanal, Color.FromArgb(160, 53, 131));
                statusColorIdDictionary.Add(Model.ProcedureGroup.Surgery, Color.FromArgb(16, 129, 149));
                statusColorIdDictionary.Add(Model.ProcedureGroup.Whitening, Color.FromArgb(255, 198, 0));
            }
            schedulerDataStorage1.Labels.Clear();
            schedulerDataStorage1.Statuses.Clear();

            int opacity = backColor.R < 150 ? 15 : 30;
            int buttonOpacity = opacity;
            diagnosisButton.Tag = Model.ProcedureGroup.Diagnosis;
            hygieneButton.Tag = Model.ProcedureGroup.Hygiene;
            implantationButton.Tag = Model.ProcedureGroup.Implantation;
            orthodonticsButton.Tag = Model.ProcedureGroup.Orthodontics;
            prostheticsButton.Tag = Model.ProcedureGroup.Prosthetics;
            restorationButton.Tag = Model.ProcedureGroup.Restoration;
            rootCanalButton.Tag = Model.ProcedureGroup.RootCanal;
            surgeryButton.Tag = Model.ProcedureGroup.Surgery;
            whiteningButton.Tag = Model.ProcedureGroup.Whitening;
            diagnosisButton.Appearance.BackColor = DXColor.Blend(Color.FromArgb(buttonOpacity, statusColorIdDictionary[Model.ProcedureGroup.Diagnosis]), backColor);
            hygieneButton.Appearance.BackColor = DXColor.Blend(Color.FromArgb(buttonOpacity, statusColorIdDictionary[Model.ProcedureGroup.Hygiene]), backColor);
            implantationButton.Appearance.BackColor = DXColor.Blend(Color.FromArgb(buttonOpacity, statusColorIdDictionary[Model.ProcedureGroup.Implantation]), backColor);
            orthodonticsButton.Appearance.BackColor = DXColor.Blend(Color.FromArgb(buttonOpacity, statusColorIdDictionary[Model.ProcedureGroup.Orthodontics]), backColor);
            prostheticsButton.Appearance.BackColor = DXColor.Blend(Color.FromArgb(buttonOpacity, statusColorIdDictionary[Model.ProcedureGroup.Prosthetics]), backColor);
            restorationButton.Appearance.BackColor = DXColor.Blend(Color.FromArgb(buttonOpacity, statusColorIdDictionary[Model.ProcedureGroup.Restoration]), backColor);
            rootCanalButton.Appearance.BackColor = DXColor.Blend(Color.FromArgb(buttonOpacity, statusColorIdDictionary[Model.ProcedureGroup.RootCanal]), backColor);
            surgeryButton.Appearance.BackColor = DXColor.Blend(Color.FromArgb(buttonOpacity, statusColorIdDictionary[Model.ProcedureGroup.Surgery]), backColor);
            whiteningButton.Appearance.BackColor = DXColor.Blend(Color.FromArgb(buttonOpacity, statusColorIdDictionary[Model.ProcedureGroup.Whitening]), backColor);

            foreach(Model.ProcedureGroup status in Enum.GetValues(typeof(Model.ProcedureGroup))) {
                var appointmentLabel = schedulerDataStorage1.Labels.Items.CreateNewLabel(status, status.ToString());
                appointmentLabel.Color = DXColor.Blend(Color.FromArgb(opacity, statusColorIdDictionary[status]), backColor);
                schedulerDataStorage1.Labels.Add(appointmentLabel);
                var appointmentStatus = schedulerDataStorage1.Statuses.Items.CreateNewStatus(status, status.ToString());
                appointmentStatus.SetBrush(new SolidBrush(statusColorIdDictionary[status]));
                schedulerDataStorage1.Statuses.Add(appointmentStatus);
            }
        }
        void OnAppointmentFlyoutShowing(object sender, AppointmentFlyoutShowingEventArgs e) {
            var appointmentData = e.FlyoutData.Appointment.GetSourceObject(schedulerControl.DataStorage) as Model.Appointment;
            e.Control = new AppointmentFlyoutView { Appointment = appointmentData };
        }
    }
}
