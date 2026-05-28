using System;
using DevExpress.DentalClinic.ViewModels;

namespace DevExpress.DentalClinic.Views.Settings {
    public partial class LoginView : DevExpress.XtraEditors.XtraUserControl {
        public LoginView() {
            InitializeComponent();
            if(!mvvmContext.IsDesignMode)
                InitializeBindings();
        }
        void InitializeBindings() {
            // Register the IErrorProviderService service
            mvvmContext.RegisterService(this);
            // Initializing Fluent API
            var fluentAPI = mvvmContext.OfType<LoginViewModel>();          
            fluentAPI.SetBinding(rememberMeCheckEdit, x => x.EditValue, x => x.RememberMe);
            fluentAPI.SetBinding(userNameTextEdit, x => x.Text, x => x.UserName);
            fluentAPI.SetBinding(passwordTextEdit, x => x.Text, x => x.Password);
            fluentAPI.SetTrigger(x => x.IsDefaultPassword, isDefaultPassword => 
                InitializePasswordUI(isDefaultPassword));
            fluentAPI.BindCommand(sbLogin, x => x.Login);
            InitializePasswordUI(fluentAPI.ViewModel.IsDefaultPassword);
        }
        void InitializePasswordUI(bool isDefaultPassword) {
            passwordTextEdit.Enabled = !isDefaultPassword;
            passwordTextEdit.Properties.UseSystemPasswordChar = !isDefaultPassword;
            passwordTextEdit.Properties.NullText = isDefaultPassword ? "Open “My Profile” to set a password" : string.Empty;
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            dataLayoutControl1.BeginInvoke(new Action(() => {
                sbLogin.Focus();
            }));
        }
    }
}
