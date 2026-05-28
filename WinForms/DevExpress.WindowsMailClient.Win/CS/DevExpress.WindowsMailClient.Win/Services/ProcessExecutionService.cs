using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.Customization;
using DevExpress.Utils.Commands;
using DevExpress.Utils.MVVM.Services;
using DevExpress.WindowsMailClient.Win.Forms;
using DevExpress.WindowsMailClient.Win.Utils;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Commands;
using DevExpress.XtraSplashScreen;

namespace DevExpress.WindowsMailClient.Win.Services {
    public interface IProcessExecutionService {
        void ExecuteProcess(string name);
        void ShowWN();
        void ShowDocumentation();
        void ShowAppointmentForm(SchedulerControl scheduler);
        void ShowSignatureForm();
        void ShowPaletteSelector();
    }
    class ProcessExecutionService : IProcessExecutionService {
        public void ExecuteProcess(string name) {
            ExecuteCore(name);
        }
        IOverlaySplashScreenHandle progressPanelHandle = null;
        public void ShowSignatureForm() {
            Cursor.Current = Cursors.WaitCursor;
            try {
                progressPanelHandle = AppProvider.ShowProgressPanel(AppProvider.MainForm);
                var form = new EmailSignatureEditForm();
                form.Show();
            }
            finally {
                AppProvider.CloseProgressPanel(progressPanelHandle);
            }
            Cursor.Current = Cursors.Default;
        }
        public void ShowPaletteSelector() {
            using(SvgSkinPaletteSelector svgSkinPaletteSelector = new SvgSkinPaletteSelector(AppProvider.MainForm)) {
                svgSkinPaletteSelector.ShowDialog();
            }
        }
        public void ShowAppointmentForm(SchedulerControl scheduler) {
            NewAppointmentCommandBase command = new NewAppointmentCommand(scheduler);
            command.CommandSourceType = CommandSourceType.Mouse;
            command.Execute();
        }
        public void ShowWN() {
            var assemblies = Assembly.GetExecutingAssembly().GetReferencedAssemblies();
            AssemblyName assemblyForCheck = assemblies.FirstOrDefault(x => x.Name.Contains("DevExpress"));
            if(assemblyForCheck != null) {
                string minorVersion = assemblyForCheck.Version.Minor.ToString();
                string majorVersion = assemblyForCheck.Version.Major.ToString();
                ExecuteCore(string.Format("https://www.devexpress.com/Subscriptions/New-20{0}-{1}.xml", majorVersion, minorVersion));
            }
            else {
                ExecuteCore("https://www.devexpress.com/Subscriptions/New-2018-1.xml");
            }

        }
        public void ShowDocumentation() {
            ExecuteCore("https://www.devexpress.com/Support/Documentation/");
        }
        void ExecuteCore(string procName) {
            try {
                DevExpress.Data.Utils.SafeProcess.Start(procName);
            }
            catch {

            }
        }
    }
}
