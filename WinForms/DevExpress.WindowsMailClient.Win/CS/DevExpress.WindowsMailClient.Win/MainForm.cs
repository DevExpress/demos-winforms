using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.Utils.DirectXPaint;
using DevExpress.Utils.Drawing;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.Taskbar;
using DevExpress.Utils.Taskbar.Core;
using DevExpress.WindowsMailClient.Win.Modules;
using DevExpress.WindowsMailClient.Win.Services;
using DevExpress.WindowsMailClient.Win.Utils;
using DevExpress.WindowsMailClient.Win.ViewModels;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;

namespace DevExpress.WindowsMailClient.Win {
    public partial class MainForm : XtraBars.FluentDesignSystem.FluentDesignForm, IMainModule {
        public MainForm() {
            TaskbarHelper.InitDemoJumpList(TaskbarAssistant.Default, this);
            AppProvider.MainForm = this;
            StartUpProcess.OnStart("When Only the Best Will Do");
            InitializeComponent();
            ConfigureDateNavigatorControl();
            StartUpProcess.OnRunning("Initializing...");
            mvvmContext.ViewModelConstructorParameter = this;
            this.OptionsAdaptiveLayout.AdaptiveLayout = true;
            Icon = AppProvider.AppIcon;
            
            ViewModel.ModuleAdded += ViewModelOnModuleAdded;
            ViewModel.ModuleRemoved += ViewModelOnModuleRemoved;
            ViewModel.CurrentTagChanged += ViewModel_CurrentTagChanged;

            
            BindCommands();
            InitBindings();
            

        }
        void ViewModel_CurrentTagChanged(object sender, EventArgs e) {
            SelectNavigationControlElementByTag(accordionControl, ViewModel.CurrentTag);
            SelectNavigationControlElementByTag(accordionFolders, ViewModel.CurrentTag);
        }
        void SelectNavigationControlElementByTag(AccordionControl control, object tag) {
            var element = control.GetElements().FirstOrDefault(x => Equals(x.Tag, tag));
            control.SelectElement(element);
        }
        protected override void OnLookAndFeelChangedCore() {
            base.OnLookAndFeelChangedCore();
            UpdateCalendarColors();
        }
        void ConfigureDateNavigatorControl() {
            calendarControl1.CalendarView = CalendarView.Fluent;
            calendarControl1.AllowAnimatedContentChange = true;
            calendarControl1.UseDirectXPaint = DefaultBoolean.True;
            calendarControl1.ShowTodayButton = false;
            calendarControl1.PerformTodayClick();

            UpdateCalendarColors();
        }

        void UpdateCalendarColors() {
            if(DCompositionSettings.IsWindowsSupportsAcrylic) {
                calendarControl1.HighlightHolidays = false;

                SkinElement elem = HamburgerMenuSkins.GetSkin(UserLookAndFeel.Default)[HamburgerMenuSkins.SkinItem];
                if(elem == null) return;
                calendarControl1.CalendarAppearance.DayCell.ForeColor =
                calendarControl1.CalendarAppearance.DayCellSpecial.ForeColor = elem.Color.GetForeColor();
                calendarControl1.CalendarAppearance.DayCell.Font = new Font("Segoe UI", 9F);

                
                
                
                
                calendarControl1.CalendarAppearance.DayCellToday.Font = 
                calendarControl1.CalendarAppearance.DayCellInactive.Font =
                calendarControl1.CalendarAppearance.DayCellSpecialInactive.Font = calendarControl1.CalendarAppearance.DayCell.Font;

                
                
                
                

                calendarControl1.CalendarAppearance.DayCellSpecialHighlighted.Font =
                calendarControl1.CalendarAppearance.DayCellHighlighted.Font =
                calendarControl1.CalendarAppearance.DayCellSpecialSelected.Font =
                calendarControl1.CalendarAppearance.DayCellSelected.Font = calendarControl1.CalendarAppearance.DayCell.Font;

                
                
                
                calendarControl1.CalendarAppearance.DayCellPressed.Font =
                calendarControl1.CalendarAppearance.DayCellSpecialPressed.Font =
                calendarControl1.CalendarAppearance.DayCell.Font;

                calendarControl1.CalendarAppearance.Header.ForeColor =
                calendarControl1.CalendarAppearance.HeaderHighlighted.ForeColor =
                calendarControl1.CalendarAppearance.HeaderPressed.ForeColor = calendarControl1.CalendarAppearance.DayCell.ForeColor;

                calendarControl1.CalendarAppearance.Header.Font =
                calendarControl1.CalendarAppearance.HeaderHighlighted.Font =
                calendarControl1.CalendarAppearance.HeaderPressed.Font =
                calendarControl1.CalendarAppearance.DayCell.Font; 

                
                calendarControl1.CalendarAppearance.WeekDay.Font = calendarControl1.CalendarAppearance.DayCell.Font;
            }
        }
        void ViewModelOnModuleRemoved(object sender, EventArgs e) {
            Control module = sender as Control;
            if(module != null) {
                module.Parent = null;
            }
            this.accordionControl.Refresh();
        }
        void ViewModelOnModuleAdded(object sender, EventArgs e) {
            Control module = sender as Control;
            if(module != null) {
                ConfigureAddedModule(module);
                module.Dock = DockStyle.Fill;
                module.Parent = fluentDesignFormContainer;
            }
        }
        void ConfigureAddedModule(Control module) {
            if(module is MailModule) {
                ((MailModule) module).Init();
                accordionControl.OptionsMinimizing.State = AccordionControlState.Minimized;
            }
        }

        #region MVVM

        public MainViewModel ViewModel {
            get { return mvvmContext.GetViewModel<MainViewModel>(); }
        }
        void BindCommands() {
            
            mvvmContext.BindCommand<MainViewModel>(elementPeople, x => x.StartPeople());
            mvvmContext.BindCommand<MainViewModel>(elementFolders,
                    x => x.ShowPanel(PanelType.Folders),
                    p => accordionControl.OptionsMinimizing.State == AccordionControlState.Normal ? PanelType.Folders : PanelType.Unknown);
            mvvmContext.BindCommand<MainViewModel>(elementSettings, x => x.ShowPanel(PanelType.Settings), p => PanelType.Settings);
            mvvmContext.BindCommand<MainViewModel>(elementAccounts, x => x.ShowPanel(PanelType.Accounts), p => PanelType.Accounts);
            mvvmContext.BindCommand<MainViewModel>(manageAccountsElement, x => x.ShowPanel(PanelType.Accounts), p => PanelType.Accounts);

            
            mvvmContext.BindCommand<MainViewModel>(outboxElement, x => x.SelectMailViewerModuleAndApplyOutboxFilter());
            mvvmContext.BindCommand<MainViewModel>(inboxElement, x => x.SelectMailViewerModuleAndApplyInboxFilter());
            mvvmContext.BindCommand<MainViewModel>(archiveElement, x => x.SelectMailViewerModuleAndApplyArchiveFilter());
            mvvmContext.BindCommand<MainViewModel>(archive1Element, x => x.SelectMailViewerModuleAndApplyArchive1Filter());
            mvvmContext.BindCommand<MainViewModel>(clutterElement, x => x.SelectMailViewerModuleAndApplyClutterFilter());
            mvvmContext.BindCommand<MainViewModel>(draftsElement, x => x.SelectMailViewerModuleAndApplyDraftsFilter());
            mvvmContext.BindCommand<MainViewModel>(sentItemsElement, x => x.SelectMailViewerModuleAndApplySentItemsFilter());
            mvvmContext.BindCommand<MainViewModel>(foldersDrafts, x => x.SelectMailViewerModuleAndApplyDraftsFilter());
            mvvmContext.BindCommand<MainViewModel>(foldersSentItems, x => x.SelectMailViewerModuleAndApplySentItemsFilter());
            mvvmContext.BindCommand<MainViewModel>(foldersMore, x => x.ShowPanel(PanelType.Folders), p => PanelType.Folders);
            mvvmContext.BindCommand<MainViewModel>(deletedItemsElement, x => x.SelectMailViewerModuleAndApplyDeletedItemsFilter());

            
            mvvmContext.BindCommand<MainViewModel>(signatureElement, x => x.ShowSignatureForm(this.Bounds), p => this.Bounds);
            mvvmContext.BindCommand<MainViewModel>(notificationsElement, x => x.ShowPanel(PanelType.Notifications), p => PanelType.Notifications);
            mvvmContext.BindCommand<MainViewModel>(elementNewEvent, x => x.ShowAppointmentForm());
            mvvmContext.BindCommand<MainViewModel>(focusedInboxElement, x => x.ShowPanel(PanelType.FocusedOther), p => PanelType.FocusedOther);
            mvvmContext.BindCommand<MainViewModel>(personalizationElement, x => x.ShowPersonalization(this), p => this);

            mvvmContext.BindCommand<MainViewModel>(helpElement, x => x.ShowHelp());
            mvvmContext.BindCommand<MainViewModel>(wnElement, x => x.ShowWN());

            mvvmContext.BindCommand<MainViewModel>(aceManageAccountsTitle, x => x.HidePanel(PanelType.Accounts), p => PanelType.Accounts);
            mvvmContext.BindCommand<MainViewModel>(focusedInboxAccordionTitle, x => x.HidePanel(PanelType.FocusedOther), p => PanelType.FocusedOther);
            mvvmContext.BindCommand<MainViewModel>(notificationsHeader, x => x.HidePanel(PanelType.Notifications), p => PanelType.Notifications);

            mvvmContext.BindCommand<MainViewModel>(elementNewMail, x => x.SelectModule(ModuleType.MailModule), p => ModuleType.MailModule);
            mvvmContext.BindCommand<MainViewModel>(elementMail, x => x.SelectModule(ModuleType.MailViewer), p => ModuleType.MailViewer);
            mvvmContext.BindCommand<MainViewModel>(elementCalendar, x => x.SelectModule(ModuleType.SchedulerModule), p => ModuleType.SchedulerModule);
        }
        void InitBindings() {
            MVVMContextFluentAPI<MainViewModel> fluentAPI = mvvmContext.OfType<MainViewModel>();
            fluentAPI.SetBinding(accordionControl, x => x.SelectedElement, x => x.CurrentTag, GetAccordionControlElementFromTag, x => x != null ? x.Tag : -1);
            fluentAPI.SetBinding(accordionFolders, x => x.SelectedElement, x => x.CurrentTag, tag => accordionFolders.GetElements().FirstOrDefault(x => Equals(x.Tag, tag)), x => x != null ? x.Tag : -1);
            fluentAPI.SetBinding(showFocusedOtherFilterToggle, x => x.EditValue, x => x.ShowFocusedOtherFilter);
        }
        AccordionControlElement GetAccordionControlElementFromTag(object tag) {
            var element = accordionControl.GetElements().FirstOrDefault(x => Equals(x.Tag, tag));
            if(!Equals(element, null)) return element;
            return accordionControl.GetElements().FirstOrDefault(x => Equals(x.Tag, foldersMore.Tag));
        }

        #endregion
        #region Properties

        protected override bool ExtendNavigationControlToFormTitle {
            get { return false; }
        }
        internal bool ExtendNavigationControlToFormTitleInternal { get { return ExtendNavigationControlToFormTitle; } }

        protected override FormShowMode ShowMode {
            get { return FormShowMode.AfterInitialization; }
        }

        #endregion
        #region Events

        int loading = 0;
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            loading++;
            try {
                ViewModel.SelectedModuleType = ModuleType.MailViewer;
            }
            finally {
                StartUpProcess.OnRunning("Successfully loaded.");
                loading--;
            }
        }
        protected override void OnShown(EventArgs e) {
            base.OnShown(e);
            StartUpProcess.OnComplete();
        }
        protected override void OnFormClosed(FormClosedEventArgs e) {
            ViewModel.SelectedModuleType = ModuleType.Unknown;
            ViewModel.ModuleAdded -= ViewModelOnModuleAdded;
            ViewModel.ModuleRemoved -= ViewModelOnModuleRemoved;
            ViewModel.CurrentTagChanged -= ViewModel_CurrentTagChanged;
            base.OnFormClosed(e);
        }

        #endregion
        void ISupportModuleLayout.SaveLayoutToStream(MemoryStream ms) { }
        void ISupportModuleLayout.RestoreLayoutFromStream(MemoryStream ms) { }

        void accordionControl_CustomDrawElement(object sender, CustomDrawElementEventArgs e) {
            int selectionWidth = 3;
            SkinElement elem = HamburgerMenuSkins.GetSkin(UserLookAndFeel.Default)[HamburgerMenuSkins.SkinItem];
            if(string.Equals(e.ObjectInfo.Element.Tag, "Account")) {
                e.Handled = true;
                e.DrawHeaderBackground();
                e.DrawText();
                e.Cache.FillRectangle(elem.GetForeColor(ObjectState.Pressed), new Rectangle(e.ObjectInfo.HeaderBounds.Location, new Size(ScaleHelper.ScaleHorizontal(selectionWidth), e.ObjectInfo.HeaderBounds.Height)));
            }
            else {
                int _tag = Convert.ToInt32(e.ObjectInfo.Element.Tag);
                if(_tag >= (int) ModuleType.DraftsModule && _tag <= (int) ModuleType.SentItemsModule) {
                    e.Handled = true;
                    e.DrawHeaderBackground();
                    e.DrawText();
                    if(Equals(accordionControl.SelectedElement, e.ObjectInfo.Element))
                        e.Cache.FillRectangle(elem.GetForeColor(ObjectState.Pressed), new Rectangle(e.ObjectInfo.HeaderBounds.Location, new Size(ScaleHelper.ScaleHorizontal(selectionWidth), e.ObjectInfo.HeaderBounds.Height)));
                    if(_tag == (int) ModuleType.DraftsModule && ViewModel.DraftsMailCounter > 0) {
                        float x = e.ObjectInfo.HeaderBounds.Width - e.ObjectInfo.HeaderBounds.X - e.ObjectInfo.TextBounds.X;
                        float y = e.ObjectInfo.TextBounds.Y;
                        Font fn = accordionControl.Appearance.Item.Normal.Font;
                        if(e.ObjectInfo.Element != null) {
                            int elementTag = e.ObjectInfo.Element.Tag is int ? (int) e.ObjectInfo.Element.Tag : -1;
                            ObjectState state = Equals(elementTag, _tag) ? ObjectState.Pressed : ObjectState.Hot;
                            e.Cache.DrawString(ViewModel.DraftsMailCounter.ToString(), fn, e.Cache.GetSolidBrush(elem.GetForeColor(state)), x, y);
                        }
                    }
                }
            }
        }
    }
}
