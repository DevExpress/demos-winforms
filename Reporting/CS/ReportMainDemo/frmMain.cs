using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Utils;
using DevExpress.DXperience.Demos;
using DevExpress.Internal;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace XtraReportsDemos {
    public class frmMain : DevExpress.DXperience.Demos.RibbonMainForm {
        readonly HashSet<IDisposable> objects = new HashSet<IDisposable>();
        public frmMain() {
            XtraReportsDemos.ObjectDataSourceTypesRegistrator.RegisterTrustedTypes();
            gcDescription.HyperlinkClick += GcDescription_HyperlinkClick;
        }
        protected override void Dispose(bool disposing) {
            if(disposing) {
                foreach(IDisposable obj in objects)
                    obj.Dispose();
                objects.Clear();
            }
            base.Dispose(disposing);
        }
        void GcDescription_HyperlinkClick(object sender, HyperlinkClickEventArgs e) {
            SafeProcess.Start(e.Link);
        }

        protected override void SetFormParam() {
            ribbonControl1.AutoHideEmptyItems = true;
            ribbonControl1.TransparentEditors = true;
            Icon = XtraReportsDemos.Properties.Resources.AppIcon;
        }
        protected override bool SupportAdvancedTitlePainting {
            get { return false; }
        }
        public override bool UseEmptyRootPadding {
            get { return true; }
        }
        protected override string ProductName {
            get { return "XtraReportsForWin"; }
        }
        protected override bool IsAllowAboutModule {
            get { return false; }
        }
        protected override int CustomWidth {
            get { return 1400; }
        }
        protected override int DefaultModuleIndex {
            get {
                DevExpress.DXperience.Demos.ModuleInfo item = ModulesInfo.GetItemByType(typeof(XtraReportsDemos.NorthwindTraders.InvoicePreviewControl).FullName);
                if(item != null) {
                    int index = ModulesInfo.GetItemIndex(item);
                    if(index >= 0) return index;
                }
                return Math.Max(0, ModulesInfo.Count - 1);
            }
        }
        protected override string DemoName {
            get { return "WinForms Reports"; }
        }

        readonly SemaphoreSlim semaphore = new SemaphoreSlim(1);
        ReportModuleBase moduleToActivate;
        ReportModuleBase activeModule;

        protected override async void ShowModule(string name, DevExpress.XtraEditors.GroupControl group, DevExpress.LookAndFeel.DefaultLookAndFeel lookAndFeel) {
            var newModuleInfo = DemosInfo.GetItem(name);
            if(newModuleInfo == null || DemosInfo.Instance.CurrentModuleBase?.Name == newModuleInfo?.Name)
                return;
            try {
                var pc = GetPrintControl(group);
                moduleToActivate = DemosInfo.ShowModule(newModuleInfo, group, RibbonMenuManager);
                if(moduleToActivate == null) return;
                objects.Add(moduleToActivate);
                if(ReferenceEquals(moduleToActivate, activeModule))
                    return;
                if(moduleToActivate is ReportModule) {
                    await ActivatePreviewModule((ReportModule)moduleToActivate, group).ConfigureAwait(false);
                } else {
                    await ActivateCommonModule(name, moduleToActivate, group).ConfigureAwait(false);
                }
            }
            catch(Exception ex) {
                throw new Exception("Module failed: " + name, ex);
            }
        }
        async Task ActivatePreviewModule(ReportModule moduleToActivate, DevExpress.XtraEditors.GroupControl group) {
            bool waitResult = await semaphore.WaitAsync(100).ConfigureAwait(true);
            if(!waitResult)
                return;
            try {
                var pc = GetPrintControl(group);
                pc.Visible = true;
                ReportModule prevModule = activeModule as ReportModule;
                activeModule = moduleToActivate;
                if(!pc.IsDisposed)
                    pc.Activate(activeModule as ReportModule);

                if(prevModule != null)
                    await prevModule.Deactivate().ConfigureAwait(false);
            }
            finally { semaphore.Release(); }
        }
        async Task ActivateCommonModule(string name, ReportModuleBase moduleToActivate, DevExpress.XtraEditors.GroupControl group) {
            bool waitResult = await semaphore.WaitAsync(100).ConfigureAwait(true);
            if(!waitResult)
                return;
            try {
                var pc = GetPrintControl(group);
                pc.Visible = false;
                pc.Deactivate();
                ReportModuleBase prevModule = activeModule;
                activeModule = moduleToActivate;
                if(prevModule != null)
                    await prevModule.Deactivate().ConfigureAwait(false);
            }
            finally { semaphore.Release(); }
        }

        PreviewControl GetPrintControl(DevExpress.XtraEditors.GroupControl group) {
            PreviewControl pc = group.Controls.OfType<PreviewControl>().FirstOrDefault();
            if(pc == null) {
                pc = new PreviewControl();
                pc.SuspendLayout();
                pc.Bounds = group.DisplayRectangle;
                group.Controls.Add(pc);
                pc.Dock = DockStyle.Fill;
                pc.Initialize(RibbonMenuManager);
                pc.ResumeLayout();
                pc.Focus();
            }
            return pc;
        }
        static frmMain() {
            // Third-party assemblies (.dll) required to run the demo are embedded inside the executable.
            // This code loads these DLLs into the current AppDomain
            AppDomain.CurrentDomain.AssemblyResolve += (s, e) => OnAssemblyResolve(e);
        }
        static System.Reflection.Assembly OnAssemblyResolve(ResolveEventArgs e) {
            var assembly = typeof(frmMain).Assembly;
            string partialName = DevExpress.Utils.AssemblyHelper.GetPartialName(e.Name);
            string assemblyName = partialName + ".dll";
            string manifestResourceName = assembly.GetManifestResourceNames()
                .FirstOrDefault(x => x.Equals(assemblyName, StringComparison.InvariantCultureIgnoreCase));
            if(string.IsNullOrEmpty(manifestResourceName))
                return null;
            using(Stream manifestResourceStream = assembly.GetManifestResourceStream(manifestResourceName)) {
                if(manifestResourceStream == null)
                    return null;
                byte[] data = new byte[(int)manifestResourceStream.Length];
                manifestResourceStream.Read(data, 0, data.Length);
                try {
                    string location = Path.GetDirectoryName(typeof(frmMain).Assembly.Location);
                    string fullAssemblyPath = Path.Combine(location, assemblyName);
                    if(!File.Exists(fullAssemblyPath))
                        File.WriteAllBytes(fullAssemblyPath, data);//CodeSamples
                    return DevExpress.Data.Internal.SafeTypeResolver.GetOrLoadAssemblyFrom(fullAssemblyPath);
                }
                catch { }
                return DevExpress.Data.Internal.SafeTypeResolver.GetOrLoadAssemblyBytes(data);
            }
        }
        [STAThread]
        static void Main() {
            System.Runtime.ProfileOptimization.SetProfileRoot(AppContext.BaseDirectory);
            System.Runtime.ProfileOptimization.StartProfile("Startup.Profile");
            bool enablePMv2 = false;
#if DEBUG
            enablePMv2 = true;
#endif
            if(!SystemInformation.TerminalServerSession && Screen.AllScreens.Length > 1 && enablePMv2)
                DevExpress.XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware();
            else
                DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();
            WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.WXI);
            WindowsFormsSettings.TrackWindowsAppMode = DevExpress.Utils.DefaultBoolean.True;

            string path = DataDirectoryHelper.GetDataFile("NWind.db");
            string directory = Path.GetDirectoryName(path);
            ConnectionHelper.SetDataDirectory(directory);
            DevExpress.XtraReports.Configuration.Settings.Default.UserDesignerOptions.ConvertBindingsToExpressions = DevExpress.XtraReports.UI.PromptBoolean.False;
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.XtraReports.Configuration.Settings.Default.UserDesignerOptions.ShowFieldListDateTimeComponents = true;
            Application.Run(new frmMain());
        }
        protected override void ShowAbout() {
            DevExpress.XtraReports.Extensions.ReportsAboutHelper.About();
        }
        protected override int TestTimerInterval {
            get {
                return 4500;
            }
        }
    }
    public class DemosInfo : ModulesInfo {
        public static ReportModuleBase ShowModule(ModuleInfo moduleInfo, DevExpress.XtraEditors.GroupControl group, RibbonMenuManager manager) {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try {
                ReportModuleBase oldModule = null;
                if(Instance.CurrentModuleBase != null) {
                    if(moduleInfo == null || Instance.CurrentModuleBase.Name == moduleInfo?.Name)
                        return null;
                    oldModule = Instance.CurrentModuleBase.TModule as ReportModuleBase;
                }
                var module = moduleInfo.TModule as ReportModuleBase;
                if(module == null) return null;
                if(!module.IsExternalPreviewApplicable()) {
                    module.Visible = false;
                    module.Dock = DockStyle.Fill;
                    module.RibbonMenuManager = manager;
                    module.Bounds = group.DisplayRectangle;
                    group.Controls.Add(module);
                    module.Visible = true;
                }
                if(oldModule != null && !oldModule.IsExternalPreviewApplicable()) {
                    oldModule.Visible = false;
                }
                module.TutorialName = moduleInfo.Name;
                moduleInfo.WasShown = true;
                Instance.CurrentModuleBase = moduleInfo;
                RaiseModuleChanged();
                return module;
            }
            finally { Cursor.Current = currentCursor; }
        }

        public static ReportModuleBase ActivateModule(string name) {
            if(Instance.CurrentModuleBase != null && Instance.CurrentModuleBase.Name == name)
                return null;

            DevExpress.DXperience.Demos.ModuleInfo moduleInfo = GetItem(name);
            ReportModuleBase module = moduleInfo != null ? moduleInfo.TModule as ReportModuleBase : null;
            if(module == null) return null;

            module.TutorialName = name;
            Instance.CurrentModuleBase = moduleInfo;

            RaiseModuleChanged();
            return module;
        }
    }
    public class About : DevExpress.Tutorials.ucOverviewPage {
        protected override Image Awards {
            get { return DevExpress.Tutorials.Properties.Resources.Awards_main; }
        }
        protected override string Line1Text {
            get { return "The XtraReports Suite"; }
        }
        protected override string Line2Text {
            get { return "A banded report designer and viewer for the WinForms platform."; }
        }
        protected override string Line3Text {
            get { return "DevExpress Desktop Controls"; }
        }
        protected override string Line4Text {
            get { return votedVSM; }
        }
        protected override DevExpress.Utils.About.ProductKind ProductKind {
            get { return DevExpress.Utils.About.ProductKind.XtraReports; }
        }
    }
}
