using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using DevExpress.DentalClinic.Model;
using DevExpress.DentalClinic.ViewModel;
using DevExpress.DentalClinic.Views.Scheduler;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.Utils.DragDrop;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Tile;
using DevExpress.XtraGrid.Views.Tile.ViewInfo;
using DevExpress.XtraScheduler;

namespace DevExpress.DentalClinic.View {
    public partial class TreatmentPlanView : XtraUserControl {
        public TreatmentPlanView() {
            InitializeComponent();
            InitializeSchedulerLabels();
            schedulerControl.Start = DateTime.Now;
            if(!mvvmContext1.IsDesignMode)
                InitializeBindings();
            schedulerControl.TimelineView.Scales.ForEach(x => x.Width = 200);
            schedulerControl.OptionsView.ResourceCategories.ResourceDisplayStyle = ResourceDisplayStyle.Tabs;
            schedulerControl.OptionsView.ResourceCategories.AppointmentDisplayMode = AppointmentDisplayMode.SelectedResource;
            schedulerControl.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource;
            schedulerControl.OptionsView.ResourceCategories.ShowCloseButton = false;
            schedulerControl.OptionsView.ResourceCategories.ShowAddButton = false;
            schedulerControl.ResourceNavigator.Visibility = ResourceNavigatorVisibility.Never;
            schedulerControl.DayView.AppointmentDisplayOptions.StatusDisplayType = AppointmentStatusDisplayType.Bounds;
            schedulerControl.WorkWeekView.AppointmentDisplayOptions.StatusDisplayType = AppointmentStatusDisplayType.Bounds;
            schedulerControl.FullWeekView.AppointmentDisplayOptions.StatusDisplayType = AppointmentStatusDisplayType.Bounds;
            schedulerControl.MonthView.AppointmentDisplayOptions.StatusDisplayType = AppointmentStatusDisplayType.Bounds;
            schedulerControl.OptionsView.ColorizeResources = false;
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
            GroupResources();
            InitializeSchedulerStatuses();
            LookAndFeel.StyleChanged += (s, e) => InitializeSchedulerStatuses();
        }
        void GroupResources() {
            schedulerControl.ResourceCategories.Clear();
            ResourceCategory group = new ResourceCategory();
            for(int i = 0; i < treatmentStorage.Resources.Count; i++) {
                group.Resources.Add(treatmentStorage.Resources[i]);
            }
            schedulerControl.ResourceCategories.Add(group);
        }
        void OnInitAppointmentDisplayText(object sender, AppointmentDisplayTextEventArgs e) {
            if(e.Appointment.AllDay)
                return;
            var app = e.Appointment.RowHandle as Model.Appointment;
            if(app == null || app.IsDeleted) return;
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
        void InitializeBindings() {
            var fluentAPI = mvvmContext1.OfType<TreatmentPlanViewModel>();
            // Data Sources
            fluentAPI.SetBinding(xpBindingSource1, x => x.DataSource, x => x.UnassignedProcedures);
            fluentAPI.SetBinding(xpBindingSource2, x => x.DataSource, x => x.Appointments);
            fluentAPI.SetBinding(xpBindingSource3, x => x.DataSource, x => x.Doctors);
            fluentAPI.SetTrigger(x => x.ReloadResource, (s) => GroupResources());
            // Events
            var btnRemoveProcedure = tileViewUnsheduledProcedures.ContextButtons["removeButton"] as ContextButton;
            fluentAPI.WithEvent<ContextItemClickEventArgs>(btnRemoveProcedure, nameof(btnRemoveProcedure.Click))
                .EventToCommand(x => x.RemoveProcedure, args => GetRow<ProcedureItem>(args));
            fluentAPI.WithEvent<DragDropEventArgs>(tileViewDragDropEvents, nameof(tileViewDragDropEvents.DragDrop))
                .EventToCommand(m => m.OnTileViewDragDrop);
            fluentAPI.WithEvent<EndDragDropEventArgs>(tileViewDragDropEvents, nameof(tileViewDragDropEvents.EndDragDrop))
                .EventToCommand(m => m.OnTileViewEndDragDrop);
            fluentAPI.WithEvent<AppointmentDragEventArgs>(schedulerControl, nameof(schedulerControl.AppointmentDrag))
                .EventToCommand(m => m.OnDragSchedulerAppointment, ea => new DragDataArgs(schedulerControl, ea));
            fluentAPI.WithEvent<AppointmentsDragEventArgs>(schedulerControl, nameof(schedulerControl.AppointmentsDrag))
                .EventToCommand(m => m.OnDragSchedulerAppointments);
            fluentAPI.WithEvent<AppointmentDragEventArgs>(schedulerControl, nameof(schedulerControl.AppointmentDrop))
                .EventToCommand(m => m.OnDropSchedulerAppointment, ea => new DragDataArgs(schedulerControl, ea));
            fluentAPI.WithEvent<AppointmentDropCompleteEventArgs>(schedulerControl, nameof(schedulerControl.AppointmentDropComplete))
                .EventToCommand(m => m.OnDropSchedulerAppointmentComplete);
            fluentAPI.WithEvent<PrepareDragDataEventArgs>(treatmentStorage, nameof(treatmentStorage.AppointmentsInserted))
                .EventToCommand(m => m.OnAppointmentInserted);
            fluentAPI.WithEvent<PrepareDragDataEventArgs>(schedulerControl, nameof(schedulerControl.PrepareDragData))
                .EventToCommand(m => m.OnPrepareSchedulerDragData, ea => new PrepareDragDataArgs(schedulerControl, ea));
            fluentAPI.WithEvent<PersistentObjectsEventArgs>(treatmentStorage, nameof(treatmentStorage.AppointmentsChanged))
                .EventToCommand(x => x.CommitChanges);
            fluentAPI.WithEvent<AppointmentFormEventArgs>(schedulerControl, nameof(schedulerControl.EditAppointmentFormShowing))
               .EventToCommand(x => x.CreateOrEditAppointment, args => {
                   args.Handled = true;
                   return new AppointmentInfo() {
                       Id = args.Appointment.Id,
                       Date = args.Appointment.Start,
                       ResourceId = schedulerControl.SelectedResource.Id
                   };
               });
            // Commands
            fluentAPI.BindCommand(sbCreateAppointment, x => x.CreateAppointment(null), x => schedulerControl.SelectedResource.Id);
            fluentAPI.BindCommand(sbRemoveAll, x => x.RemoveAllProcedures);
        }
        T GetRow<T>(ContextItemClickEventArgs args) {
            var ownerInfo = args.ItemInfo.ViewInfo.Owner as TileViewItemInfo;
            var tileViewItem = ownerInfo.Item as TileViewItem;
            return GetRow<T>(tileViewItem);
        }
        T GetRow<T>(TileViewItem tileViewItem) {
            return (T)tileViewItem.View.GetRow(tileViewItem.RowHandle);
        }
        void OnSchedulerControlPopupMenuShowing(object sender, PopupMenuShowingEventArgs e) {
            if (e.Menu.Id == SchedulerMenuItemId.AppointmentMenu ||
                e.Menu.Id == SchedulerMenuItemId.AppointmentDragMenu)
                e.Menu = null;
        }
        void OnSchedulerControlCustomAppointmentSort(object sender, CustomAppointmentSortEventArgs e) {
            XtraScheduler.Appointment apt1 = e.AppointmentLayoutInfo1.Appointment;
            XtraScheduler.Appointment apt2 = e.AppointmentLayoutInfo2.Appointment;
            if (!apt2.LabelKey.Equals(apt1.LabelKey)) {
                if (apt2.LabelKey == null || apt2.LabelKey.Equals(LabelMappingConverter.HighlightLabelId)) {
                    e.Result = 1;
                    return;
                }
                if (apt1.LabelKey == null || apt1.LabelKey.Equals(LabelMappingConverter.HighlightLabelId)) {
                    e.Result = -1;
                    return;
                }
            }
            e.Result = apt1.Start.CompareTo(apt2.Start);
            if (e.Result != 0)
                return;
            e.Result = -apt2.End.CompareTo(apt1.End);
        }
        void OnFilterAppointment(object sender, PersistentObjectCancelEventArgs e) {
            var apt = (XtraScheduler.Appointment)e.Object;
            e.Cancel = (Model.AppointmentStatus)apt.CustomFields["AppointmentStatus"] != Model.AppointmentStatus.Open;
        }
        Dictionary<Model.ProcedureGroup, Color> statusColorIdDictionary = new Dictionary<Model.ProcedureGroup, Color>();
        void InitializeSchedulerStatuses() {
            statusColorIdDictionary.Clear();
            var backColor = LookAndFeelHelper.GetSystemColorEx(LookAndFeel, SystemColors.Window);
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
            treatmentStorage.Labels.Clear();
            treatmentStorage.Statuses.Clear();
            foreach(Model.ProcedureGroup status in Enum.GetValues(typeof(Model.ProcedureGroup))) {
                var appointmentLabel = treatmentStorage.Labels.Items.CreateNewLabel(status, status.ToString());
                if(backColor.R < 150)
                    appointmentLabel.Color = DXColor.Blend(Color.FromArgb(15, statusColorIdDictionary[status]), backColor);
                else
                    appointmentLabel.Color = DXColor.Blend(Color.FromArgb(30, statusColorIdDictionary[status]), backColor);
                treatmentStorage.Labels.Add(appointmentLabel);
                var appointmentStatus = treatmentStorage.Statuses.Items.CreateNewStatus(status, status.ToString());
                appointmentStatus.SetBrush(new SolidBrush(statusColorIdDictionary[status]));
                treatmentStorage.Statuses.Add(appointmentStatus);
            }
        }
        void InitializeSchedulerLabels() {
            //this.treatmentStorage.Labels.Clear();
            //var otherLabel = this.treatmentStorage.Labels.Items.CreateNewLabel(0, "any");
            //otherLabel.ColorId = SchedulerColorId.NoneLabel;
            //this.treatmentStorage.Labels.Add(otherLabel);

            //var activeLabel = this.treatmentStorage.Labels.Items.CreateNewLabel(1, "active");
            //activeLabel.ColorId = SchedulerColorId.BusinessLabel;
            //this.treatmentStorage.Labels.Add(activeLabel);
        }
        void OnTileViewCustomColumnDisplayText(object sender, XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e) {
            if(e.Column.FieldName == nameof(Procedure) + "." + nameof(Procedure.Type) && !Object.Equals(e.Value, ProcedureType.General)) {
                    int toothNumber = (int)tileViewUnsheduledProcedures.GetRowCellValue(e.ListSourceRowIndex, nameof(ProcedureItem.ToothNumber));
                    e.DisplayText = $"{e.DisplayText} {toothNumber}";
            }
            if(e.Column.FieldName == nameof(Procedure) + "." + nameof(Procedure.Duration))
                e.DisplayText = $"{e.Value:%h\\:mm}m";            
        }
        void OnAppointmentFlyoutShowing(object sender, AppointmentFlyoutShowingEventArgs e) {
            var appointmentData = e.FlyoutData.Appointment.GetSourceObject(schedulerControl.DataStorage) as Model.Appointment;
            e.Control = new AppointmentFlyoutView { Appointment = appointmentData };
        }
    }

    public class LabelMappingConverter : ISchedulerMappingConverter {
        public const int HighlightLabelId = 1;
        public const int DefaultLabelId = 0;
        public const MappingConversionBehavior MappingBehavior = MappingConversionBehavior.InPlaceOfMapping;

        public Patient Patient { get; set; }

        public object Convert(object obj, Type targetType, object parameter) {
            if (Patient == null)
                return DefaultLabelId;
            if (obj == Patient || obj == null)
                return HighlightLabelId;
            return DefaultLabelId;
        }

        public object ConvertBack(object obj, Type targetType, object parameter) {
            return Patient;
        }
    }
}
