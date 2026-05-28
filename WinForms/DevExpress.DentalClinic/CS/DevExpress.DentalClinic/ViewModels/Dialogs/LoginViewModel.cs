using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.Data.Utils.Security;
using DevExpress.DentalClinic.Model;
using DevExpress.DentalClinic.Services;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Security.ClientServer;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;

namespace DevExpress.DentalClinic.ViewModels {
    public class LoginViewModel : IDocumentContent {
        public LoginViewModel() {
            IsInStartPage = SessionProvider == null;
            RememberMe = true;
        }
        public virtual string UserName { get; set; }
        readonly SensitiveData passwordData = SensitiveData.CreateForCurrentUser();
        public virtual string Password {
            get { return passwordData.Text; }
            set { passwordData.Text = value; }
        }
        public virtual bool IsInStartPage { get; set; }
        public virtual bool IsDefaultPassword { get; set; }
        public virtual bool RememberMe { get; set; }
        protected void OnUserNameChanged() {
            IsDefaultPassword = string.IsNullOrEmpty(UserName) ? false : LoginService.IsDefaultPassword(UserName);
        }
        public bool LoginResult { get; set; }
        public void Login() {
            string databasePath = DBPathHelper.EnsureWriteable(Application.StartupPath, "DentalCabinet.db");
            string connectionString = @"XpoProvider=SQLite;Data Source=" + databasePath;
            AuthenticationStandard authentication = new AuthenticationStandard();
            SecurityStrategyComplex security = new SecurityStrategyComplex(typeof(Employee), typeof(EmployeeRole), authentication);
            var objectSpaceProvider = new SecuredObjectSpaceProvider(security, connectionString, null);
            security.RegisterXPOAdapterProviders();
            IObjectSpace logonObjectSpace = objectSpaceProvider.CreateObjectSpace();
            security.Authentication.SetLogonParameters(new AuthenticationStandardLogonParameters(UserName, Password));
            try {
                security.Logon(logonObjectSpace);
                LoginResult = true;
                if(RememberMe) {
                    Properties.Settings.Default.UserName = UserName;
                    Properties.Settings.Default.Save();
                }
                (this as IDocumentContent).DocumentOwner.Close(this);
                ServiceContainer.Default.RegisterService(new SecuredObjectSpaceService(security, objectSpaceProvider));
            }
            catch {
                LoginResult = false;
                MessageBoxService.ShowMessage(DentalClinicStringId.LoginErrorMessage, string.Empty, MessageButton.OK);
            }
        }
        IMessageBoxService MessageBoxService {
            get { return this.GetService<IMessageBoxService>(); }
        }
        ISecuredObjectSpaceService SessionProvider {
            get { return this.GetService<ISecuredObjectSpaceService>(); }
        }
        ILoginService LoginService {
            get { return ServiceContainer.Default.GetService(typeof(ILoginService), string.Empty) as ILoginService; }
        }
        //
        IDocumentOwner IDocumentContent.DocumentOwner { get; set; }
        object IDocumentContent.Title => string.Empty;
        void IDocumentContent.OnClose(CancelEventArgs e) {
            if(!IsInStartPage)
                return;
            var result = MessageBoxService.ShowMessage(DentalClinicStringId.ExitMessage, string.Empty, MessageButton.YesNo);
            if(result == MessageResult.No)
                e.Cancel = true;
        }
        void IDocumentContent.OnDestroy() { }
    }
}
