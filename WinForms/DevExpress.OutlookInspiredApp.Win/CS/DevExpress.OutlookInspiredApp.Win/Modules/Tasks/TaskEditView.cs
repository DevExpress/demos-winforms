namespace DevExpress.DevAV.Modules {
    using System.Windows.Forms;
    using DevExpress.DevAV;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraEditors;

    public partial class TaskEditView : BaseModuleControl, IRibbonModule {
        public TaskEditView()
            : base(typeof(TaskViewModel)) {
            InitializeComponent();
            GalleryItemAppearances.Apply(galleryQuickLetters);
            
            BindCommands();
            BindEditors();
            
            

            if(!mvvmContext.IsDesignMode) {
                InitBindings();
            }

        }

        void InitBindings() {
            var fluentAPI = mvvmContext.OfType<TaskViewModel>();
            fluentAPI.SetObjectDataSourceBinding(taskBindingSource,
                x => x.Entity, x => x.Update());
           
            fluentAPI.SetBinding(ownerLookUpEdit.Properties, r => r.DataSource, x => x. LookUpEmployees.Entities);
            fluentAPI.SetBinding(assignedToLookUpEdit.Properties, r => r.DataSource, x => x.LookUpEmployees.Entities);
            fluentAPI.SetBinding(linkedToLookUpEdit.Properties, r => r.DataSource, x => x.LookUpEmployees.Entities);

        }

        public TaskViewModel ViewModel {
            get { return GetViewModel<TaskViewModel>(); }
        }
        public TaskCollectionViewModel CollectionViewModel {
            get { return GetParentViewModel<TaskCollectionViewModel>(); }
        }
        protected override void OnParentViewModelAttached() {
            
        }
        void BindCommands() {
            var fluent = mvvmContext.OfType<TaskViewModel>();
            
            fluent.BindCommand(biSave, x => x.Save());
            fluent.BindCommand(biClose, x => x.Close());
            fluent.BindCommand(biSaveAndClose, x => x.SaveAndClose());
            
            fluent.BindCommand(biDelete, x => x.Delete());
            
            fluent.BindCommand(biRefresh, x => x.Reset());
        }
        void BindCollectionViewCommands() {
            var fluent = mvvmContext.OfType<EmployeeViewModel>();
            
            fluent.BindCommand(biShowMap, x => x.ShowMap());
            
            fluent.BindCommand(bmiPrintProfile, x => x.Print(EmployeeReportType.None), x => EmployeeReportType.Profile);
            fluent.BindCommand(bmiPrintSummary, x => x.Print(EmployeeReportType.None), x => EmployeeReportType.Summary);
            fluent.BindCommand(bmiPrintDirectory, x => x.Print(EmployeeReportType.None), x => EmployeeReportType.Directory);
            fluent.BindCommand(bmiPrintTaskList, x => x.Print(EmployeeReportType.None), x => EmployeeReportType.TaskList);
            
            fluent.BindCommand(biMailMerge, x => x.MailMerge());
            
            fluent.BindCommand(GalleryQuickLetterItem(0), x => x.QuickLetter(default(EmployeeMailTemplate)), x => EmployeeMailTemplate.ThankYouNote);
            fluent.BindCommand(GalleryQuickLetterItem(1), x => x.QuickLetter(default(EmployeeMailTemplate)), x => EmployeeMailTemplate.EmployeeOfTheMonth);
            fluent.BindCommand(GalleryQuickLetterItem(2), x => x.QuickLetter(default(EmployeeMailTemplate)), x => EmployeeMailTemplate.ServiceExcellence);
            fluent.BindCommand(GalleryQuickLetterItem(3), x => x.QuickLetter(default(EmployeeMailTemplate)), x => EmployeeMailTemplate.ProbationNotice);
            fluent.BindCommand(GalleryQuickLetterItem(4), x => x.QuickLetter(default(EmployeeMailTemplate)), x => EmployeeMailTemplate.WelcomeToDevAV);
            
            fluent.BindCommand(biMeeting, x => x.ShowMeeting());
            fluent.BindCommand(biTask, x => x.ShowTask());
        }
        XtraBars.Ribbon.GalleryItem GalleryQuickLetterItem(int index) {
            return galleryQuickLetters.Gallery.Groups[0].Items[index];
        }
        void BindEditors() {
            
            
            
            
            
            
            
            
            
            
            
            var fluent = mvvmContext.OfType<TaskViewModel>();
            
            
            
            
            
            fluent.SetBinding(ribbonControl, r => r.ApplicationDocumentCaption, x => x.Title);
            
            
            
            
            
            
            
            
            
            
            
        }
        XtraEditors.Controls.EditorButton ContactButton(XtraEditors.ButtonEdit edit, int index = 0) {
            return edit.Properties.Buttons[index];
        }
        int fullNameUpdateQueued = 0;
        void QueueFullNameUpdate() {
            if(0 == fullNameUpdateQueued) {
                fullNameUpdateQueued++;
                BeginInvoke(new MethodInvoker(UpdateFullNameEditValue));
            }
            else fullNameUpdateQueued++;
        }
        void UpdateFullNameEditValue() {
            
            fullNameUpdateQueued = 0;
        }
        #region
        XtraBars.Ribbon.RibbonControl IRibbonModule.Ribbon {
            get { return ribbonControl; }
        }
        #endregion
        
        
        
        
        
        
    }
}
