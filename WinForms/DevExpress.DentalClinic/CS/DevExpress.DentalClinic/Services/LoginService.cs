using System.Windows.Forms;
using DevExpress.DentalClinic.Model;
using DevExpress.DentalClinic.ViewModel;
using DevExpress.DentalClinic.ViewModels;
using DevExpress.DentalClinic.Views.Settings;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Security.ClientServer;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Utils.MVVM;

namespace DevExpress.DentalClinic.Services {
    public interface ILoginService {
        bool Login(string name, bool showMessage = false);
        bool IsDefaultPassword(string name);
    }
    public class LoginService : ILoginService {
        public bool Login(string name, bool showMessage = false) {
            var viewModel = ViewModelSource.Create<LoginViewModel>();
            viewModel.UserName = name;
            var service = MVVMContext.GetService<IDocumentManagerService>(viewModel, "Flyout");
            service.CreateDocument(nameof(LoginView), viewModel).Show();
            Messenger.Default.Send(ReloadDataMessage.AllData);
            return viewModel.LoginResult;
        }
        public bool IsDefaultPassword(string name) {
            return IsDefaultPasswordCore(name, false);
        }
        bool LoginCore(string name) {
            var viewModel = ViewModelSource.Create<LoginViewModel>();
            viewModel.UserName = name;
            var service = MVVMContext.GetService<IDocumentManagerService>(viewModel, "Flyout");
            service.CreateDocument(nameof(LoginView), viewModel).Show();
            Messenger.Default.Send(ReloadDataMessage.AllData);
            return viewModel.LoginResult;
        }
        bool IsDefaultPasswordCore(string name, bool showMessage) {
            string databasePath = DBPathHelper.EnsureWriteable(Application.StartupPath, "DentalCabinet.db");
            string connectionString = @"XpoProvider=SQLite;Data Source=" + databasePath;
            AuthenticationStandard authentication = new AuthenticationStandard();
            SecurityStrategyComplex security = new SecurityStrategyComplex(typeof(Employee), typeof(EmployeeRole), authentication);
            var objectSpaceProvider = new SecuredObjectSpaceProvider(security, connectionString, null);
            security.RegisterXPOAdapterProviders();
            IObjectSpace logonObjectSpace = objectSpaceProvider.CreateObjectSpace();
            security.Authentication.SetLogonParameters(new AuthenticationStandardLogonParameters(name, ""));
            try {
                security.Logon(logonObjectSpace);
                if(security.IsAuthenticated)
                    return true;
                //SecuritySystem.SetInstance(security);
                //ServiceContainer.Default.RegisterService(new SecuredObjectSpaceService(security, objectSpaceProvider));
                //Messenger.Default.Send(ReloadDataMessage.AllData);
                //var messageBoxService = ServiceContainer.Default.GetService<IMessageBoxService>();
                //if(showMessage)
                //    messageBoxService.ShowMessage(string.Format(DentalClinicStringId.LoginMessage, name));
                //return true;
            }
            catch { }
            return false;
        }
    }
}
