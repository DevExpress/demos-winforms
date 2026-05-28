using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.Utils;
using DevExpress.Utils.Animation;
using DevExpress.XtraBars.Docking2010.Customization;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;

namespace Examples {
    [CodeExampleClass("Workspace Manager", "UtilityControls.cs")]
    public static class WorkspaceManagerSamples {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            XtraUserControl workspaceManagerHost = new XtraUserControl();
            workspaceManagerHost.Parent = sampleHost;
            workspaceManagerHost.Dock = DockStyle.Fill;
            WorkspaceManager workspaceManager = new WorkspaceManager();
            return new object[] { workspaceManager, workspaceManagerHost };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) { }
    }
    [CodeExampleClass("Flyout Dialog", "UtilityControls.cs")]
    [CodeExampleHighlightTokens("DockStyle", "FlyoutAction", "FlyoutCommand", "FlyoutDialog", "UserControl", "DialogResult")]
    public static class FlyoutDialogSamples {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            return new object[] { sampleHost };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) { }
        [CodeExampleCase("Show Standard Dialog")]
        public static void ShowStandardDialog(XtraUserControl ownerControl) {
            SimpleButton button = new SimpleButton() { Text = "ShowFlyout" };
            button.Dock = DockStyle.Top;
            button.Parent = ownerControl;
            FlyoutAction action = new FlyoutAction();
            action.Caption = "Flyout Action";
            action.Description = "Flyout Action Description";
            action.Commands.Add(FlyoutCommand.OK);
            button.Click += (sender, e) => { FlyoutDialog.Show(ownerControl.FindForm(), action); };
        }
        [CodeExampleCase("Show Edit Dialog")]
        public static void ShowEditDialog(XtraUserControl ownerControl) {
            SimpleButton button = new SimpleButton() { Text = "ShowFlyout" };
            button.Dock = DockStyle.Top;
            button.Parent = ownerControl;
            UserControl control = new UserControl() { Padding = new Padding(0, 30, 0, 20), Size = new Size(300, 300) };
            TextEdit textEdit = new TextEdit() { Dock = DockStyle.Top };
            textEdit.Parent = control;
            SimpleButton okButton = new SimpleButton() { Dock = DockStyle.Bottom, Text = "Ok" };
            okButton.DialogResult = DialogResult.OK;
            okButton.Parent = control;
            button.Click += (sender, e) => { FlyoutDialog.Show(ownerControl.FindForm(), control); };
        }
    }
    [CodeExampleClass("Transition Manager", "UtilityControls.cs")]
    [CodeExampleHighlightTokens("Transition", "Color", "SlideFadeTransition", "TransitionManager", "FadeTransition", "LabelControl", "XtraPanel", "SlideFadeTransition", "Thread")]
    public static class TransitionManagerSamples {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            XtraUserControl transitionManagerHost = new XtraUserControl() { Dock = DockStyle.Fill };
            transitionManagerHost.Parent = sampleHost;
            return new object[] { transitionManagerHost };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) { }
        [CodeExampleCase("Show Simple Animation")]
        [CodeExampleUnderlineTokens("Click", "StartTransition", "EndTransition")]
        public static void ShowSimpleAnimation(XtraUserControl ownerControl) {
            Transition transiton = new Transition();
            transiton.Control = ownerControl;
            transiton.ShowWaitingIndicator = DefaultBoolean.False;
            transiton.TransitionType = new SlideFadeTransition();
            TransitionManager manager = new TransitionManager();
            manager.Transitions.Add(transiton);
            SimpleButton button = new SimpleButton() { Text = "Start Transition", Dock = DockStyle.Top };
            button.Parent = ownerControl;
            button.Click += (sender, e) =>
            {
                manager.StartTransition(ownerControl);
                ownerControl.BackColor = Color.FromArgb(TutorialConstants.Random.Next(0, 255), TutorialConstants.Random.Next(0, 255), TutorialConstants.Random.Next(0, 255));
                manager.EndTransition();
            };
        }
        [CodeExampleCase("Show Visibility Changed Animation")]
        [CodeExampleUnderlineTokens("Click", "StartTransition", "EndTransition")]
        public static void ShowVisibilityChangedAnimation(XtraUserControl ownerControl) {
            Transition transiton = new Transition();
            transiton.ShowWaitingIndicator = DefaultBoolean.False;
            transiton.Control = ownerControl;
            transiton.TransitionType = new FadeTransition();
            TransitionManager manager = new TransitionManager();
            manager.Transitions.Add(transiton);
            SimpleButton button = new SimpleButton() { Text = "Start Transition", Dock = DockStyle.Top };
            LabelControl label = new LabelControl() { Text = "Label Control", Dock = DockStyle.Fill };
            XtraPanel panel = new XtraPanel() { Dock = DockStyle.Top, Size = new Size(100, 50), Padding = new Padding(10) };
            label.Parent = panel;
            panel.Parent = ownerControl;
            button.Parent = ownerControl;
            button.Click += (sender, e) =>
            {
                manager.StartTransition(ownerControl);
                panel.Visible = !panel.Visible;
                manager.EndTransition();
            };
        }
        [CodeExampleCase("Show Wait Indicator")]
        [CodeExampleUnderlineTokens("Click", "StartTransition", "EndTransition")]
        public static void ShowWaitIndicator(XtraUserControl ownerControl) {
            Transition transiton = new Transition();
            transiton.Control = ownerControl;
            transiton.TransitionType = new SlideFadeTransition();
            TransitionManager manager = new TransitionManager();
            manager.Transitions.Add(transiton);
            SimpleButton button = new SimpleButton() { Text = "Start Transition", Dock = DockStyle.Top };
            button.Parent = ownerControl;
            button.Click += (sender, e) =>
            {
                manager.StartTransition(ownerControl);
                ownerControl.BackColor = Color.FromArgb(TutorialConstants.Random.Next(0, 255), TutorialConstants.Random.Next(0, 255), TutorialConstants.Random.Next(0, 255));
                Thread.Sleep(1000);
                manager.EndTransition();
            };
        }
    }
    [CodeExampleClass("NavigationFrame", "UtilityControls.cs")]
    [CodeExampleHighlightTokens("NavigationFrame", "NavigationPage", "NavigationPageContent", "DockStyle", "OfficeNavigationBar", "Color", "SolidBrush",
        "Pen", "StringFormat", "Font", "StringAlignment", "ControlStyles", "PaintEventArgs", "StringTrimming", "StringFormatFlags","Panel")]
    public static class NavigationFrameSamples {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            return new object[] { sampleHost };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) { }
        [CodeExampleCase("Create NavigationFrame", new Type[] { typeof(NavigationPageContent) })]
        [CodeExampleUnderlineTokens("SelectNextPage", "SelectPrevPage")]
        public static void CreateNavigationFrame(XtraUserControl ownerControl) {
            SimpleButton nextButton = new SimpleButton() { Text = "Select Next Page", Dock = DockStyle.Top, Parent = ownerControl };
            SimpleButton prevButton = new SimpleButton() { Text = "Select Previous Page", Dock = DockStyle.Top, Parent = ownerControl };
            NavigationFrame navigationFrame = new NavigationFrame() { Dock = DockStyle.Fill, Parent = ownerControl };
            var page1 = new NavigationPage();
            var pageContent1 = new NavigationPageContent() { Parent = page1, Dock = DockStyle.Fill, Text = "Navigation Page 1" };
            var page2 = new NavigationPage();
            var pageContent2 = new NavigationPageContent() { Parent = page2, Dock = DockStyle.Fill, Text = "Navigation Page 2" };
            var page3 = new NavigationPage();
            var pageContent3 = new NavigationPageContent() { Parent = page3, Dock = DockStyle.Fill, Text = "Navigation Page 3" };
            navigationFrame.Pages.AddRange(new NavigationPage[] { page1, page2, page3 });
            navigationFrame.BringToFront();
            nextButton.Click += (sender, e) => { navigationFrame.SelectNextPage(); };
            prevButton.Click += (sender, e) => { navigationFrame.SelectPrevPage(); };
        }
        [CodeExampleCase("Attach to OfficeNavigationBar", new Type[] { typeof(NavigationPageContent) })]
        public static void AttachToOfficeNavigationBar(XtraUserControl ownerControl) {
            OfficeNavigationBar navigationBar = new OfficeNavigationBar() { Dock = DockStyle.Bottom, Parent = ownerControl};
            NavigationFrame navigationFrame = new NavigationFrame() { Dock = DockStyle.Fill, Parent = ownerControl };
            var page1 = new NavigationPage() { Caption = "Page 1"};
            var pageContent1 = new NavigationPageContent() { Parent = page1, Dock = DockStyle.Fill, Text = "Navigation Page 1" };
            var page2 = new NavigationPage() { Caption = "Page 2" }; ;
            var pageContent2 = new NavigationPageContent() { Parent = page2, Dock = DockStyle.Fill, Text = "Navigation Page 2" };
            var page3 = new NavigationPage() { Caption = "Page 3" }; ;
            var pageContent3 = new NavigationPageContent() { Parent = page3, Dock = DockStyle.Fill, Text = "Navigation Page 3" };
            navigationFrame.Pages.AddRange(new NavigationPage[] { page1, page2, page3 });
            navigationFrame.BringToFront();
            navigationBar.NavigationClient = navigationFrame;
        }
        [CodeExampleNestedClass]
        public class NavigationPageContent : Panel {
            static int currentColor;
            static Color[] forecolors = new Color[] { 
                Color.Red, Color.Blue, Color.Green
            };
            SolidBrush sb;
            Pen pen;
            StringFormat sf;
            static Font _font = new Font("Segoe UI", 24f);
            public NavigationPageContent() {
                sf = new StringFormat()
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center,
                    Trimming = StringTrimming.EllipsisCharacter,
                    FormatFlags = StringFormatFlags.NoWrap
                };
                DoubleBuffered = true;
                ForeColor = forecolors[(currentColor++) % forecolors.Length];
                SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
                SetStyle(ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
            }
            protected override void OnPaint(PaintEventArgs e) {
                if(sb == null)
                    sb = new SolidBrush(Color.FromArgb(100, ForeColor));
                if(pen == null)
                    pen = new Pen(Color.FromArgb(200, 221, 223, 223));
                e.Graphics.FillRectangle(sb, ClientRectangle);
                e.Graphics.DrawString(Text, _font, sb, ClientRectangle, sf);
            }
        }
    }
}
