using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraBars.Docking2010.Customization;
using DevExpress.XtraEditors.ButtonPanel;

namespace DevExpress.RealtorWorld.Win {
    public partial class ucSettings : BaseModule {
        static int TimerInterval = 2300;
        public ucSettings() {
            InitializeComponent();
            ucStats stats = new ucStats();
            ucResearch research = new ucResearch();
            stats.InitModule(barManager1, null);
            research.InitModule(barManager1, null);
            windowsUIView1.AddDocument(stats);
            windowsUIView1.AddDocument(research);
            pageGroup1.Properties.ShowPageHeaders = Utils.DefaultBoolean.False;
            windowsUIView1.NavigationBarsShowing += new NavigationBarsCancelEventHandler(onShowingNavigationBars);
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        protected internal Timer ActivationTimer { get; set; }
        protected override void Dispose(bool disposing) {
            if(disposing && ActivationTimer != null) {
                ActivationTimer.Tick -= timerTick;
                ActivationTimer = null;
                View.ContentContainerActivated -= OnContentContainerActivated;
                View.ContentContainerDeactivated -= OnContentContainerDeactivated;
            }
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        protected WindowsUIView View { get; set; }
        internal override void InitModule(DevExpress.Utils.Menu.IDXMenuManager manager, object data) {
            base.InitModule(manager, data);
            if(data is WindowsUIView) {
                View = (WindowsUIView)data;
                foreach(IBaseButton button in animationButtonPanel.Buttons) {
                    button.Properties.Checked = button.Properties.Tag.Equals(View.PageGroupProperties.SwitchDocumentAnimationMode);
                    windowsUIView1.PageGroupProperties.SwitchDocumentAnimationMode = View.PageGroupProperties.SwitchDocumentAnimationMode;
                }
            }
            View.ContentContainerActivated += OnContentContainerActivated;
            View.ContentContainerDeactivated += OnContentContainerDeactivated;
            ActivationTimer = new Timer();
            ActivationTimer.Tick += timerTick;
            ActivationTimer.Interval = TimerInterval;
            ActivationTimer.Start();
        }
        void OnContentContainerDeactivated(object sender, ContentContainerEventArgs e) {
            if(e.ContentContainer is Page)
                ActivationTimer.Stop();
        }
        void OnContentContainerActivated(object sender, ContentContainerEventArgs e) {
            if(e.ContentContainer is Page)
                ActivationTimer.Start();
        }
        void timerTick(object sender, EventArgs e) {
            if(document1.IsActive)
                windowsUIView1.Controller.Activate(document2);
            else
                windowsUIView1.Controller.Activate(document1);
        }
        public override string ModuleCaption { get { return "Settings"; } }
        void animationButtonChecked(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e) {
            if(View != null)
                View.PageGroupProperties.SwitchDocumentAnimationMode = (TransitionAnimation)e.Button.Properties.Tag;
            windowsUIView1.PageGroupProperties.SwitchDocumentAnimationMode = (TransitionAnimation)e.Button.Properties.Tag;
        }
        void onShowingNavigationBars(object sender, NavigationBarsCancelEventArgs e) {
            e.Cancel = true;
        }
    }
}
