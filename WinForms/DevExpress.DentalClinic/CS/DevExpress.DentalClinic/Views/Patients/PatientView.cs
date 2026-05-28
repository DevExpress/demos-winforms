using System;
using DevExpress.DentalClinic.ViewModel;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraEditors;

namespace DevExpress.DentalClinic.View {
    public partial class PatientView : XtraUserControl {
        public PatientView() {
            InitializeComponent();
            if(!mvvmContext.IsDesignMode) {
                InitializeNavigation();
                InitializeBindings();
            }
        }
        void InitializeNavigation() {
            var navigationService = DocumentManagerService.Create(tabPane);
            navigationService.UseDeferredLoading = Utils.DefaultBoolean.True;
            mvvmContext.RegisterService(navigationService);
        }
        void InitializeBindings() {
            var fluentApi = mvvmContext.OfType<PatientViewModel>();
            fluentApi.WithEvent(this, nameof(Load))
                .EventToCommand(x => x.Load);
            fluentApi.SetTrigger(v => v.UnassignedProcedureCount, count => badge.Visible = count > 0);
            fluentApi.SetBinding(badge.Properties, x => x.Text, x => x.UnassignedProcedureCount, 
                v => v.ToString(), s => string.IsNullOrEmpty(s) ? 0 : int.Parse(s));
            tabPane.PageAdded += OnTabPanePageAdded;
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            adornerUIManager.Owner = FindForm();
        }
        void OnTabPanePageAdded(object sender, XtraBars.Navigation.NavigationPageEventArgs e) {
            if(e.Page.Caption == "Treatment Plan") 
                badge.TargetElement = e.Page;
        }
    }
}
