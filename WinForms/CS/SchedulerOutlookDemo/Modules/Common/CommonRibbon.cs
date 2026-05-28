using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Tutorials;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.Utils.Serializing.Helpers;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraScheduler.Commands;
using DevExpress.XtraScheduler.Demos.DemoData;
using DevExpress.XtraScheduler.Exchange;
using DevExpress.XtraScheduler.iCalendar;
using DevExpress.XtraScheduler.iCalendar.Components;
using DevExpress.XtraScheduler.Native;
using DevExpress.XtraScheduler.Outlook;
using DevExpress.XtraScheduler.Services;

namespace DevExpress.XtraScheduler.Demos {
    public partial class CommonRibbon : UserControl {
        public const string DefaultPageName = "Home";
        TutorialControl _tutorial;
        bool isLoaded;
        public CommonRibbon() {
            InitializeComponent();
            Load += OnLoad;
        }
        [DefaultValue(typeof(TutorialControl), null)]
        public TutorialControl Tutorial {
            get { return _tutorial; }
            set {
                if(_tutorial == value)
                    return;
                UnsubscribeSchedulerEvents(_tutorial);
                _tutorial = value;
                SchedulerControl scheduler = _tutorial.Scheduler;
                if(scheduler == null)
                    return;
                schedulerBarController1.Control = scheduler;
                CustomSchedulerCommandFactoryService commandFactory = new CustomSchedulerCommandFactoryService(scheduler, scheduler.GetService<ISchedulerCommandFactoryService>());
                scheduler.RemoveService(typeof(ISchedulerCommandFactoryService));
                scheduler.AddService(typeof(ISchedulerCommandFactoryService), commandFactory);
                SubscribeSchedulerEvents(_tutorial);
                PrepareRibbon();
            }
        }

        RibbonControl ParentRibbon {
            get {
                if(Tutorial == null || Tutorial.RibbonOwnerForm == null)
                    return null;
                return Tutorial.RibbonOwnerForm.Ribbon;
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool GroupByRibbonPageGroupVisible {
            get {
                return !groupByRibbonPageGroup1.Visible;
            }
            set {
                groupByRibbonPageGroup1.Visible = value;
            }
        }
        [DefaultValue(true)]
        public bool SwitchViewPageGroupVisible {
            get {
                return arrangeRibbonPageGroup1.Visible && activeViewRibbonPageGroup1.Visible;
            }
            set {
                arrangeRibbonPageGroup1.Visible = value;
                activeViewRibbonPageGroup1.Visible = value;
            }
        }

        public void UpdateRibbonItems() {
            bbiShowOptionsPane.Down = CommonOptions.Instance.ShowModuleOptionsPane;
        }

        void OnLoad(object sender, EventArgs e) {
            isLoaded = true;
            PrepareRibbon();
        }

        void PrepareRibbon() {
            if(!isLoaded || Tutorial == null)
                return;
            Tutorial.SetModulesSubMenu(bbiOpenCalendar);
        }

        void SubscribeSchedulerEvents(TutorialControl tutorialControl) {
            if(tutorialControl == null || tutorialControl.Scheduler == null)
                return;
            tutorialControl.Scheduler.SelectionChanged += OnSchedulerSelectionChanged;
            tutorialControl.Scheduler.PopupMenuShowing += OnSchedulerPopupMenuShowing;
        }

        void UnsubscribeSchedulerEvents(TutorialControl tutorialControl) {
            if(tutorialControl == null || tutorialControl.Scheduler == null)
                return;
            tutorialControl.Scheduler.SelectionChanged -= OnSchedulerSelectionChanged;
            tutorialControl.Scheduler.PopupMenuShowing -= OnSchedulerPopupMenuShowing;
        }

        void OnSchedulerPopupMenuShowing(object sender, PopupMenuShowingEventArgs e) {
            SchedulerControl scheduler = (SchedulerControl)sender;
            if(e.Menu.Id == SchedulerMenuItemId.AppointmentMenu) {
                int openAppointmentGroupIndex = FindMenuAppointmentItemsGroupLastIndex(e.Menu);
                //Image sendMenuItemImage = DemoUtils.GetResourceImage("Images.Send_16x16.png");
                DXMenuItem sendMenuItem = new DXMenuItem("Send", (s, ea) => { iCalendarMessageSender.ExportAppointments(ParentForm, scheduler.DataStorage, scheduler.SelectedAppointments); });
                sendMenuItem.BeginGroup = true;
                sendMenuItem.SvgImage = DemoUtils.GetResourceSvgImage("Images.Forward.svg");
                sendMenuItem.ImageOptions.SvgImageSize = new Size(16, 16);
                e.Menu.Items.Add(sendMenuItem);
                e.Menu.MoveMenuItem(sendMenuItem, ++openAppointmentGroupIndex);

                AppointmentBaseCollection selectedAppointments = scheduler.SelectedAppointments;
                if(selectedAppointments.Count == 1) {
                    Appointment selectedAppointment = selectedAppointments[0];
                    DXMenuItem setAppointmentPrivateMenuItem = new DXMenuCheckItem("Private", selectedAppointment.GetIsPrivate());
                    setAppointmentPrivateMenuItem.Click += (s, ea) => selectedAppointment.ToggleIsPrivate();
                    setAppointmentPrivateMenuItem.SvgImage = DemoUtils.GetResourceSvgImage("Images.Private.svg");
                    setAppointmentPrivateMenuItem.ImageOptions.SvgImageSize = new Size(16, 16);
                    setAppointmentPrivateMenuItem.BeginGroup = true;
                    e.Menu.Items.Add(setAppointmentPrivateMenuItem);
                    e.Menu.MoveMenuItem(setAppointmentPrivateMenuItem, ++openAppointmentGroupIndex);
                    e.Menu.Items[openAppointmentGroupIndex + 1].BeginGroup = false;
                }

                DXMenuItem labelItem = FindMenuItemById(e.Menu, SchedulerMenuItemId.LabelSubMenu);
                if(labelItem != null) {
                    labelItem.Caption = "Categorize";
                    labelItem.SvgImage = DemoUtils.GetResourceSvgImage("Images.Categorize.svg");
                    labelItem.ImageOptions.SvgImageSize = new Size(16, 16);
                }
            }
        }

        DXMenuItem FindMenuItemById(SchedulerPopupMenu menu, SchedulerMenuItemId id) {
            for(int i = 0; i < menu.Items.Count; i++) {
                SchedulerMenuItem item = menu.Items[i] as SchedulerMenuItem;
                if(item != null && item.Id.Equals(id))
                    return item;
                if(item != null)
                    continue;
                SchedulerPopupMenu subMenu = menu.Items[i] as SchedulerPopupMenu;
                if(subMenu != null && subMenu.Id.Equals(id))
                    return subMenu;
            }
            return null;
        }

        int FindMenuAppointmentItemsGroupLastIndex(SchedulerPopupMenu menu) {
            int openAppointmentGroupIndex = -1;
            for(int i = 0; i < menu.Items.Count; i++) {
                SchedulerMenuItem menuItem = menu.Items[i] as SchedulerMenuItem;
                if(menuItem == null)
                    continue;
                if(menuItem.Id == SchedulerMenuItemId.OpenAppointment || menuItem.Id == SchedulerMenuItemId.EditSeries || menuItem.Id == SchedulerMenuItemId.RestoreOccurrence)
                    openAppointmentGroupIndex = i;
            }
            return openAppointmentGroupIndex;
        }

        void OnSchedulerSelectionChanged(object sender, EventArgs e) {
            if(ParentRibbon == null)
                return;
            SchedulerControl scheduler = (SchedulerControl)sender;
            if(scheduler.SelectedAppointments.Count != 1)
                return;

            calendarToolsRibbonPageCategory1.Visible = true;
            ParentRibbon.SelectedPage = appointmentRibbonPage1;

            btnIsPrivate.Down = scheduler.SelectedAppointments[0].GetIsPrivate();
            EventPriority priority = scheduler.SelectedAppointments[0].GetPriority();
            UpdateImportanceItems(priority);
        }

        void UpdateImportanceItems(EventPriority priority) {
            bbiHighImportance.Down = priority == EventPriority.Important;
            bbiLowImportance.Down = priority == EventPriority.NotImportant;
        }

        void OnBbiNext7DaysItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(Tutorial == null || Tutorial.Scheduler == null)
                return;
            SchedulerControl scheduler = Tutorial.Scheduler;
            scheduler.BeginUpdate();
            try {
                if(scheduler.DayView.Enabled) {
                    scheduler.ActiveViewType = SchedulerViewType.Day;
                    scheduler.DayView.DayCount = 7;
                }
                scheduler.Start = DateTime.Today;
            }
            finally {
                scheduler.EndUpdate();
            }
        }

        int currentOperationProgressIndex = 0;
        void OnBbiOutlookImportItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(Tutorial == null || Tutorial.Scheduler == null)
                return;
            SchedulerControl scheduler = Tutorial.Scheduler;
            scheduler.BeginUpdate();
            try {
                SelectOutlookCalendarsForm chooseCalendarsForm = new SelectOutlookCalendarsForm();
                chooseCalendarsForm.StartPosition = FormStartPosition.CenterParent;
                if(chooseCalendarsForm.ShowDialog(Tutorial.ParentForm) != DialogResult.OK)
                    return;
                IOperationProgress operationProgress = Tutorial.ParentForm as IOperationProgress;
                operationProgress.Start("Import from outlook", 0, 10000);
                currentOperationProgressIndex = 0;
                AppointmentImporter importer = scheduler.DataStorage.CreateOutlookImporter();
                ((ISupportCalendarFolders)importer).CalendarFolderName = chooseCalendarsForm.CalendarName;
                operationProgress.Start("Import from outlook", 0, importer.SourceObjectCount);
                importer.AppointmentImporting += OnOutlookImportAppointmentImporting;
                importer.Import(System.IO.Stream.Null);
                operationProgress.End();

            }
            finally {
                scheduler.EndUpdate();
            }
        }

        private void OnOutlookImportAppointmentImporting(object sender, AppointmentImportingEventArgs e) {
            currentOperationProgressIndex++;
            IOperationProgress operationProgress = Tutorial.ParentForm as IOperationProgress;
            if(operationProgress == null)
                return;
            operationProgress.Do(currentOperationProgressIndex);
        }

        void OnBbiResetViewSettingsItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            CommonOptions.ResetInstance();
            if(Tutorial == null || Tutorial.Scheduler == null)
                return;
            ApplySchedulerOptions();
            Tutorial.ResetOptions();
        }

        void OnBbiViewSettingsItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            ChangeViewForm form = new ChangeViewForm() { Icon = Tutorial.ParentForm.Icon };
            form.LoadOptions(CommonOptions.Instance);
            if(form.ShowDialog(Tutorial.ParentForm) != DialogResult.OK)
                return;
            form.SaveOptions(CommonOptions.Instance);
            ApplySchedulerOptions();
        }

        void ApplySchedulerOptions() {
            if(Tutorial == null)
                return;
            CommonOptions.Instance.Apply(Tutorial);
        }

        void OnBbiShowOptionsPaneItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            CommonOptions.Instance.ShowModuleOptionsPane = !CommonOptions.Instance.ShowModuleOptionsPane;
            Tutorial.UpdateOptionsPaneVisibility(CommonOptions.Instance.ShowModuleOptionsPane);
        }

        void OnBtnIsPrivateItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            SchedulerControl scheduler = Tutorial.Scheduler;
            if(scheduler.SelectedAppointments.Count != 1)
                return;
            scheduler.SelectedAppointments[0].SetIsPrivate(btnIsPrivate.Down);
        }

        void OnBbiHightImportanceItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            SchedulerControl scheduler = Tutorial.Scheduler;
            if(scheduler.SelectedAppointments.Count != 1)
                return;
            EventPriority priority = EventPriority.None;
            if(bbiHighImportance.Down)
                priority = EventPriority.Important;
            scheduler.SelectedAppointments[0].SetPriority(priority);
            UpdateImportanceItems(priority);
        }

        void OnBbiLowImportanceItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            SchedulerControl scheduler = Tutorial.Scheduler;
            if(scheduler.SelectedAppointments.Count != 1)
                return;
            EventPriority priority = EventPriority.None;
            if(bbiLowImportance.Down)
                priority = EventPriority.NotImportant;
            scheduler.SelectedAppointments[0].SetPriority(priority);
            UpdateImportanceItems(priority);
        }

        void barButtonItem1_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            SchedulerControl scheduler = Tutorial.Scheduler;
            iCalendarMessageSender.ExportAppointments(ParentForm, scheduler.DataStorage, scheduler.SelectedAppointments);
        }
        void OnBbiCopyDemoLinkItemClick(object sender, ItemClickEventArgs e) {
            CopyDemoLink();
        }
        void OnBbiChCopyDemoLinkItemClick(object sender, ItemClickEventArgs e) {
            CopyDemoLink();
        }
        void OnBbiChCopyHtmlDemoLinkItemClick(object sender, ItemClickEventArgs e) {
            string htmlDemoLink = DemoLinkHelper.GetHtmlLink(Tutorial);
            if(String.IsNullOrEmpty(htmlDemoLink))
                return;
            DevExpress.Data.Utils.SafeClipboardWin.Instance.SetText(htmlDemoLink);
        }
        void CopyDemoLink() {
            string link = DemoLinkHelper.GetLink(Tutorial);
            if(String.IsNullOrEmpty(link))
                return;
            DevExpress.Data.Utils.SafeClipboardWin.Instance.SetText(link);
        }
    }

    public class CustomSchedulerCommandFactoryService : ISchedulerCommandFactoryService {
        readonly ISchedulerCommandFactoryService service;
        readonly SchedulerControl control;

        public CustomSchedulerCommandFactoryService(SchedulerControl control,
            ISchedulerCommandFactoryService service) {
            Guard.ArgumentNotNull(control, "control");
            Guard.ArgumentNotNull(service, "service");
            this.control = control;
            this.service = service;
        }

        public SchedulerCommand CreateCommand(SchedulerCommandId id) {
            if(id == SchedulerCommandId.SaveSchedule)
                return new CustomSaveScheduleCommand(control);
            return service.CreateCommand(id);
        }
    }
    public class CustomSaveScheduleCommand : SaveScheduleCommand {
        iCalendarExporter exporter;
        public CustomSaveScheduleCommand(ISchedulerCommandTarget target) : base(target) {
        }
        public CustomSaveScheduleCommand(InnerSchedulerControl control) : base(control) {
        }
        protected override AppointmentExporter CreateExporter() {
            exporter = new iCalendarExporter(Control.Storage);
            exporter.AppointmentExporting += Exporter_AppointmentExporting;
            return exporter;
        }
        public override void Execute() {
            base.Execute();
            exporter.AppointmentExporting -= Exporter_AppointmentExporting;
        }

        private void Exporter_AppointmentExporting(object sender, AppointmentExportingEventArgs e) {
            iCalendarAppointmentExportingEventArgs args = e as iCalendarAppointmentExportingEventArgs;
            CustomProperty customProperty = args.VEvent.CustomProperties["X-DEVEXPRESS-CUSTOMFIELD-PRIORITY"] as CustomProperty;
            customProperty.Value = ObjectConverter.ObjectToString((int)e.Appointment.CustomFields["Priority"]);
        }
    }
}
