using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.DXperience.Demos.CodeDemo.Helpers;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Utils.Html;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraEditors;

namespace DevExpress.HTML.Demos.CodeExamples {
    [CodeExampleClass("Handle clicks on elements", "Interaction.cs")]
    public static class Interaction_ElementMouseClick {
        static Interaction_ElementMouseClick() {
            DelegateCommand.DefaultUseCommandManager = true;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var htmlContentControl = new HtmlContentControl();
            XtraUserControl mainView = null;
            if(mainView != null) {
                mainView.Dock = System.Windows.Forms.DockStyle.Fill;
                mainView.Parent = sampleHost;
            }
            else {
                htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
                htmlContentControl.Parent = sampleHost;
            }
            return new object[] { htmlContentControl, mainView };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = MVVMContext.FromControl(sampleHost);
            if(mvvmContext != null) mvvmContext.Dispose();
        }

        [CodeExampleCase("The ElementMouseClick event")]
        [HtmlFile("Interaction.ElementMouseClick", false), CssFile("Interaction.ElementMouseClick", false), CodeExampleUnderlineTokens("ElementMouseClick")]
        public static void ElementMouseClickEvent(HtmlContentControl htmlContentControl, XtraUserControl mainView) {
            htmlContentControl.HtmlImages = Assets.SvgImages;
            htmlContentControl.HtmlTemplate.Set(Loader.Load("ElementMouseClick.html"), Loader.Load("ElementMouseClick.css"));
            //
            htmlContentControl.ElementMouseClick += (s, e) => {
                if(e.ElementId == "btnPhone")
                    XtraMessageBox.Show("Phone!");
                if(e.ElementId == "btnVideo")
                    XtraMessageBox.Show("Video!");
                if(e.ElementId == "btnText")
                    XtraMessageBox.Show("Text Message!");
            };
        }

        [CodeExampleCase("The HTML 'onclick' event",
            new Type[] { typeof(MainView) }, null, typeof(MainView))]
        [HtmlFile("Interaction.ElementMouseClick2", false), CssFile("Interaction.ElementMouseClick", false), CodeExampleUnderlineTokens("BindCommandToElement")]
        public static void ElementMouseClickAutoWiredHandler(HtmlContentControl htmlContentControl, XtraUserControl mainView) {
            htmlContentControl.HtmlImages = Assets.SvgImages;
            htmlContentControl.HtmlTemplate.Set(Loader.Load("ElementMouseClick2.html"), Loader.Load("ElementMouseClick.css"));
        }
        [CodeExampleNestedClass]
        public partial class MainView {
            /// <summary>
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;
            /// <summary>
            /// Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing) {
                if(disposing && (components != null)) {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            #region Component Designer generated code
            /// <summary> 
            /// Required method for Designer support - do not modify 
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent() {
                this.components = new System.ComponentModel.Container();
                this.htmlContentControl = new DevExpress.XtraEditors.HtmlContentControl();
                this.SuspendLayout();
                // 
                // htmlContentControl
                // 
                this.htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
                this.htmlContentControl.Size = new System.Drawing.Size(398, 468);
                // 
                // AppLogo
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
                this.Controls.Add(this.htmlContentControl);
                this.Name = "MainForm";
                this.Size = new System.Drawing.Size(398, 468);
                this.ResumeLayout(false);
            }
            #endregion
            private DevExpress.XtraEditors.HtmlContentControl htmlContentControl;
        }
        partial class MainView : XtraUserControl {
            public MainView() {
                InitializeComponent();
                // $CodeBehindInsertionLine$ 
            }
            void OnPhoneClick(object sender, DxHtmlElementMouseEventArgs args) {
                XtraMessageBox.Show("Phone!");
            }
            void OnVideoClick(object sender, DxHtmlElementMouseEventArgs args) {
                XtraMessageBox.Show("Video!");
            }
            void OnTextClick(object sender, DxHtmlElementMouseEventArgs args) {
                XtraMessageBox.Show("Text Message!");
            }
        }

        [CodeExampleCase("Command binding (Fluent API)", new Type[] { typeof(ViewModel) })]
        [HtmlFile("Interaction.ElementMouseClick", false), CssFile("Interaction.ElementMouseClick", false), CodeExampleUnderlineTokens("BindCommandToElement")]
        public static void ElementMouseClickCommandBinding(HtmlContentControl htmlContentControl, XtraUserControl mainView) {
            htmlContentControl.HtmlImages = Assets.SvgImages;
            htmlContentControl.HtmlTemplate.Set(Loader.Load("ElementMouseClick.html"), Loader.Load("ElementMouseClick.css"));
            //
            MVVMContext context = new MVVMContext();
            context.ViewModelType = typeof(ViewModel);
            //
            var fluent = context.OfType<ViewModel>();
            fluent.BindCommandToElement(htmlContentControl, "btnPhone", x => x.Phone);
            fluent.BindCommandToElement(htmlContentControl, "btnVideo", x => x.Video);
            fluent.BindCommandToElement(htmlContentControl, "btnText", x => x.TextMessage);
        }
        [CodeExampleNestedClass]
        public class ViewModel {
            public void Phone() {
                var msgService = this.GetService<IMessageBoxService>();
                msgService.ShowMessage("Phone!");
            }
            public void Video() {
                var msgService = this.GetService<IMessageBoxService>();
                msgService.ShowMessage("Video!");
            }
            public void TextMessage() {
                var msgService = this.GetService<IMessageBoxService>();
                msgService.ShowMessage("Text Message!");
            }
        }
    }

    [CodeExampleClass("HtmlContentPopup - show a menu for an element", "Interaction.cs")]
    public static class Interaction_ShowingMenu {
        static Interaction_ShowingMenu() {
            DelegateCommand.DefaultUseCommandManager = true;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var menuBar = new HtmlContentControl();
            var menuPopup = new HtmlContentPopup();
            menuPopup.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
            XtraUserControl mainMenuView = null;
            if(mainMenuView != null) {
                mainMenuView.Dock = System.Windows.Forms.DockStyle.Fill;
                mainMenuView.Parent = sampleHost;
                menuPopup.ContainerControl = sampleHost;
            }
            else {
                menuBar.Dock = System.Windows.Forms.DockStyle.Fill;
                menuBar.Parent = sampleHost;
                menuPopup.ContainerControl = sampleHost;
            }
            menuBar.HtmlImages = Assets.SvgImages;
            menuPopup.HtmlImages = Assets.SvgImages;
            return new object[] { menuBar, menuPopup, mainMenuView };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = MVVMContext.FromControl(sampleHost);
            if(mvvmContext != null) mvvmContext.Dispose();
        }

        [CodeExampleCase("Use the 'HtmlContentPopup.Show' method within an 'onclick' HTML event handler",
            new Type[] { typeof(MainMenuView) }, null, typeof(MainMenuView))]
        [HtmlFile("Interaction.MenuBar", "Interaction.FileMenu"), CssFile("Interaction.MenuBar", "Interaction.FileMenu"), CodeExampleUnderlineTokens("Show", "HtmlTemplate", "HideOnElementClick")]
        public static void SetupForMenu(HtmlContentControl menuBar, HtmlContentPopup menuPopup, XtraUserControl mainMenuView) {
            menuPopup.HideOnElementClick = DevExpress.Utils.DefaultBoolean.True;
        }

        [CodeExampleNestedClass]
        public partial class MainMenuView {
            /// <summary>
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;
            /// <summary>
            /// Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing) {
                if(disposing && (components != null)) {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            #region Component Designer generated code
            /// <summary> 
            /// Required method for Designer support - do not modify 
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent() {
                this.components = new System.ComponentModel.Container();
                this.menuBar = new DevExpress.XtraEditors.HtmlContentControl();
                this.menuPopup = new DevExpress.XtraEditors.HtmlContentPopup(components);
                this.SuspendLayout();
                // 
                // menuBar
                // 
                this.menuBar.Dock = System.Windows.Forms.DockStyle.Fill;
                this.menuBar.Size = new System.Drawing.Size(398, 468);
                // 
                // menuPopup
                // 
                this.menuPopup.ContainerControl = this;
                this.menuPopup.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
                // 
                // MainMenuView
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
                this.Controls.Add(this.menuBar);
                this.Name = "MainMenuView";
                this.Size = new System.Drawing.Size(398, 468);
                this.ResumeLayout(false);
            }
            #endregion
            private DevExpress.XtraEditors.HtmlContentControl menuBar;
            private DevExpress.XtraEditors.HtmlContentPopup menuPopup;
        }
        partial class MainMenuView : XtraUserControl {
            public MainMenuView() {
                InitializeComponent();
                InitializeStyles();
                // $CodeBehindInsertionLine$ 
                menuPopup.ElementMouseClick += OnMenuItemClick;
            }
            void InitializeStyles() {
                menuBar.HtmlImages = Assets.SvgImages;
                menuBar.HtmlTemplate.Set(Loader.Load("MenuBar.html"), Loader.Load("MenuBar.css"));
                menuPopup.HtmlImages = Assets.SvgImages;
                menuPopup.HtmlTemplate.Set(Loader.Load("FileMenu.html"), Loader.Load("FileMenu.css"));
            }
            void OnFileClick(object sender, DxHtmlElementMouseEventArgs args) {
                var popupSize = ScaleDPI.ScaleSize(new Size(140, 180));
                int shadowOffsetLeft = ScaleDPI.ScaleHorizontal(8);
                var popupLocation = new Point(
                    args.Element.Location.X - shadowOffsetLeft,
                    args.Element.ViewInfo.Bounds.Bottom);
                menuPopup.Show(menuBar, menuBar.RectangleToScreen(new Rectangle(popupLocation, popupSize)));
            }
            void OnMenuItemClick(object sender, DxHtmlElementMouseEventArgs args) {
                XtraMessageBox.Show("Menu item [id=" + args.ElementId + "] clicked!");
            }
        }
    }

    [CodeExampleClass("HtmlContentPopup - show a tooltip for an element", "Interaction.cs")]
    public static class Interaction_ShowingToolTip {
        static Interaction_ShowingToolTip() {
            DelegateCommand.DefaultUseCommandManager = true;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var menuBar = new HtmlContentControl();
            var tooltipPopup = new HtmlContentPopup();
            tooltipPopup.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
            XtraUserControl tooltipView = null;
            if(tooltipView != null) {
                tooltipView.Dock = System.Windows.Forms.DockStyle.Fill;
                tooltipView.Parent = sampleHost;
                tooltipPopup.ContainerControl = sampleHost;
            }
            else {
                menuBar.Dock = System.Windows.Forms.DockStyle.Fill;
                menuBar.Parent = sampleHost;
                tooltipPopup.ContainerControl = sampleHost;
            }
            menuBar.HtmlImages = Assets.SvgImages;
            tooltipPopup.HtmlImages = Assets.SvgImages;
            return new object[] { menuBar, tooltipPopup, tooltipView };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = MVVMContext.FromControl(sampleHost);
            if(mvvmContext != null) mvvmContext.Dispose();
        }

        [CodeExampleCase("Use the 'HtmlContentPopup.Show' method within an 'onmouseover' event handler",
            new Type[] { typeof(TooltipView) }, null, typeof(TooltipView))]
        [HtmlFile("Interaction.MenuBar", "Interaction.Tooltip"), CssFile("Interaction.MenuBar", "Interaction.Tooltip"),
            CodeExampleUnderlineTokens("Show", "HtmlTemplate", "HideOnElementClick", "HideAutomatically", "AutoHidingDelay")]
        public static void SetupForTooltip(HtmlContentControl menuBar, HtmlContentPopup tooltipPopup, XtraUserControl tooltipView) {
            tooltipPopup.HideOnElementClick = DevExpress.Utils.DefaultBoolean.True;
            tooltipPopup.AutoHidingDelay = 1000;
            tooltipPopup.HideAutomatically = DevExpress.Utils.DefaultBoolean.True;
        }

        [CodeExampleNestedClass]
        public partial class TooltipView {
            /// <summary>
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;
            /// <summary>
            /// Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing) {
                if(disposing && (components != null)) {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            #region Component Designer generated code
            /// <summary> 
            /// Required method for Designer support - do not modify 
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent() {
                this.components = new System.ComponentModel.Container();
                this.menuBar = new DevExpress.XtraEditors.HtmlContentControl();
                this.tooltipPopup = new DevExpress.XtraEditors.HtmlContentPopup(components);
                this.SuspendLayout();
                // 
                // menuBar
                // 
                this.menuBar.Dock = System.Windows.Forms.DockStyle.Fill;
                this.menuBar.Size = new System.Drawing.Size(398, 468);
                // 
                // tooltipPopup
                // 
                this.tooltipPopup.ContainerControl = this;
                this.tooltipPopup.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
                // 
                // TooltipView
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
                this.Controls.Add(this.menuBar);
                this.Name = "TooltipView";
                this.Size = new System.Drawing.Size(398, 468);
                this.ResumeLayout(false);
            }
            #endregion
            private DevExpress.XtraEditors.HtmlContentControl menuBar;
            private DevExpress.XtraEditors.HtmlContentPopup tooltipPopup;
        }
        partial class TooltipView : XtraUserControl {
            public TooltipView() {
                InitializeComponent();
                InitializeStyles();
                // $CodeBehindInsertionLine$ 
            }
            void InitializeStyles() {
                menuBar.HtmlImages = Assets.SvgImages;
                menuBar.HtmlTemplate.Set(Loader.Load("MenuBar.html"), Loader.Load("MenuBar.css"));
                tooltipPopup.HtmlImages = Assets.SvgImages;
                tooltipPopup.HtmlTemplate.Set(Loader.Load("Tooltip.html"), Loader.Load("Tooltip.css"));
            }
            void OnFileHover(object sender, DxHtmlElementMouseEventArgs args) {
                var popupSize = ScaleDPI.ScaleSize(new Size(316, 180));
                int shadowOffsetLeft = ScaleDPI.ScaleHorizontal(8);
                var popupLocation = new Point(
                    args.Element.Location.X - shadowOffsetLeft,
                    args.Element.ViewInfo.Bounds.Bottom);
                tooltipPopup.Show(menuBar, menuBar.RectangleToScreen(new Rectangle(popupLocation, popupSize)));
            }
        }
    }

    [CodeExampleClass("HtmlContentPopup - show a dialog", "Interaction.cs")]
    public static class Interaction_ShowingDialog {
        static Interaction_ShowingDialog() {
            DelegateCommand.DefaultUseCommandManager = true;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var menuBar = new HtmlContentControl();
            var dialogPopup = new HtmlContentPopup();
            dialogPopup.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
            XtraUserControl dialogView = null;
            if(dialogView != null) {
                dialogView.Dock = System.Windows.Forms.DockStyle.Fill;
                dialogView.Parent = sampleHost;
                dialogPopup.ContainerControl = sampleHost;
            }
            else {
                menuBar.Dock = System.Windows.Forms.DockStyle.Fill;
                menuBar.Parent = sampleHost;
                dialogPopup.ContainerControl = sampleHost;
            }
            menuBar.HtmlImages = Assets.SvgImages;
            dialogPopup.HtmlImages = Assets.SvgImages;
            return new object[] { menuBar, dialogPopup, dialogView };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = MVVMContext.FromControl(sampleHost);
            if(mvvmContext != null) mvvmContext.Dispose();
        }

        [CodeExampleCase("Use the 'HtmlContentPopup.ShowDialog' method",
            new Type[] { typeof(DialogView) }, null, typeof(DialogView))]
        [HtmlFile("Interaction.MenuBar", "Interaction.Dialog"), CssFile("Interaction.MenuBar", "Interaction.Dialog"),
            CodeExampleUnderlineTokens("ShowDialog", "Close", "HtmlTemplate")]
        public static void SetupForDialog(HtmlContentControl menuBar, HtmlContentPopup dialogPopup, XtraUserControl dialogView) {
        }

        [CodeExampleNestedClass]
        public partial class DialogView {
            /// <summary>
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;
            /// <summary>
            /// Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing) {
                if(disposing && (components != null)) {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            #region Component Designer generated code
            /// <summary> 
            /// Required method for Designer support - do not modify 
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent() {
                this.components = new System.ComponentModel.Container();
                this.menuBar = new DevExpress.XtraEditors.HtmlContentControl();
                this.dialogPopup = new DevExpress.XtraEditors.HtmlContentPopup(components);
                this.SuspendLayout();
                // 
                // menuBar
                // 
                this.menuBar.Dock = System.Windows.Forms.DockStyle.Fill;
                this.menuBar.Size = new System.Drawing.Size(398, 468);
                // 
                // dialogPopup
                // 
                this.dialogPopup.ContainerControl = this;
                this.dialogPopup.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
                // 
                // DialogView
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
                this.Controls.Add(this.menuBar);
                this.Name = "DialogView";
                this.Size = new System.Drawing.Size(398, 468);
                this.ResumeLayout(false);
            }
            #endregion
            private DevExpress.XtraEditors.HtmlContentControl menuBar;
            private DevExpress.XtraEditors.HtmlContentPopup dialogPopup;
        }
        partial class DialogView : XtraUserControl {
            public DialogView() {
                InitializeComponent();
                InitializeStyles();
                // $CodeBehindInsertionLine$ 
                menuBar.ElementMouseClick += OnMenuItemClick;
                dialogPopup.ElementMouseClick += OnDialogElementClick;
            }
            void InitializeStyles() {
                menuBar.HtmlImages = Assets.SvgImages;
                menuBar.HtmlTemplate.Set(Loader.Load("MenuBar.html"), Loader.Load("MenuBar.css"));
                dialogPopup.HtmlImages = Assets.SvgImages;
                dialogPopup.HtmlTemplate.Set(Loader.Load("Dialog.html"), Loader.Load("Dialog.css"));
            }
            void OnMenuItemClick(object sender, DxHtmlElementMouseEventArgs args) {
                var dialogSize = ScaleDPI.ScaleSize(new Size(332, 232));
                var dialogRect = DevExpress.Utils.PlacementHelper.Arrange(dialogSize, ClientRectangle, ContentAlignment.MiddleCenter);
                var dialogScreenRect = RectangleToScreen(dialogRect);
                if(dialogPopup.ShowDialog(menuBar, dialogScreenRect) == DialogResult.OK) {
                    /* do something */
                    DevExpress.XtraEditors.XtraMessageBox.Show("Thanks!");
                }
            }
            void OnDialogElementClick(object sender, DxHtmlElementMouseEventArgs e) {
                if(e.ElementId == "btnClose")
                    dialogPopup.Close(DialogResult.Cancel);
                if(e.ElementId == "btnAccept")
                    dialogPopup.Close(DialogResult.OK);
            }
        }
    }

    [CodeExampleClass("HtmlContentPopup - show a popup from a ViewModel (IWindowService)", "Interaction.cs")]
    public static class Interaction_WindowService {
        static Interaction_WindowService() {
            DelegateCommand.DefaultUseCommandManager = true;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var mvvmContext = new MVVMContext();
            var menuBar = new HtmlContentControl();
            var popup = new HtmlContentPopup();
            popup.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
            XtraUserControl popupView = null;
            if(popupView != null) {
                popupView.Dock = System.Windows.Forms.DockStyle.Fill;
                popupView.Parent = sampleHost;
                popup.ContainerControl = sampleHost;
            }
            else {
                menuBar.Dock = System.Windows.Forms.DockStyle.Fill;
                menuBar.Parent = sampleHost;
                popup.ContainerControl = sampleHost;
            }
            menuBar.HtmlImages = Assets.SvgImages;
            popup.HtmlImages = Assets.SvgImages;
            return new object[] { menuBar, popup, mvvmContext, popupView };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = MVVMContext.FromControl(sampleHost);
            if(mvvmContext != null) mvvmContext.Dispose();
        }

        [CodeExampleCase("Flyout (modeless window)",
            new Type[] { typeof(PopupView), typeof(MainViewModel), typeof(PopupViewModel), typeof(DialogViewModel) }, 
            null, typeof(PopupView), HiddenTypes = "DialogViewModel")]
        [HtmlFile("Interaction.MVVMMenuBar", "Interaction.MVVMPopup"), CssFile("Interaction.MenuBar", "Interaction.Popup"),
        CodeExampleUnderlineTokens("ViewModelType", "ViewModelSet", "CreateWindowService", "ShowMode")]
        public static void SetupForPopup(HtmlContentControl menuBar, HtmlContentPopup popup, MVVMContext mvvmContext, XtraUserControl popupView) {
            // Setup the popup 
            popup.HtmlImages = Assets.SvgImages;
            popup.HtmlTemplate.Set(Loader.Load("MVVMPopup.html"), Loader.Load("Popup.css"));
            // Bind the HTML 'miPopup' element to the ShowPopup command
            var fluent = mvvmContext.OfType<MainViewModel>();
            fluent.BindCommandToElement(menuBar, "miPopup", x => x.ShowPopup);
            // Configure a WindowService instance
            var popupService = popup.CreateWindowService(popup.ContainerControl);
            popupService.ShowMode = WindowService.WindowShowMode.Modeless;
            var popupWindowStyle = new Action<IWindow>((window) => {
                var flyoutWindow = window as IPopupWindow;
                flyoutWindow.PopupSize = new Size(332, 140);
            });
            popupService.WindowStyle = popupWindowStyle;
            mvvmContext.RegisterService(popupService);
            // Bind dialog elements to the PopupViewModel
            popup.ViewModelType = typeof(PopupViewModel);
        }

        [CodeExampleCase("Modal window",
            new Type[] { typeof(PopupView), typeof(MainViewModel), typeof(PopupViewModel), typeof(DialogViewModel) }, 
            null, typeof(PopupView), HiddenTypes = "PopupViewModel")]
        [HtmlFile("Interaction.MVVMMenuBar", "Interaction.MVVMDialog"), CssFile("Interaction.MenuBar", "Interaction.Dialog"),
        CodeExampleUnderlineTokens("ViewModelType", "ViewModelSet", "CreateWindowService", "ShowMode")]
        public static void SetupForDialog(HtmlContentControl menuBar, HtmlContentPopup popup, MVVMContext mvvmContext, XtraUserControl popupView) {
            // Setup the popup 
            popup.HtmlImages = Assets.SvgImages;
            popup.HtmlTemplate.Set(Loader.Load("MVVMDialog.html"), Loader.Load("Dialog.css"));
            // Bind the HTML 'miDialog' element to the ShowDialog command
            var fluent = mvvmContext.OfType<MainViewModel>();
            fluent.BindCommandToElement(menuBar, "miDialog", x => x.ShowDialog);
            // Configure a WindowService instance
            var popupService = popup.CreateWindowService(popup.ContainerControl);
            popupService.ShowMode = WindowService.WindowShowMode.Modal;
            var popupWindowStyle = new Action<IWindow>((window) => {
                var dlgWindow = window as IPopupWindow;
                dlgWindow.PopupSize = new Size(332, 232);
                dlgWindow.DestroyOnHide = false;
            });
            popupService.WindowStyle = popupWindowStyle;
            mvvmContext.RegisterService(popupService);
            // Bind dialog elements to the DialogViewModel
            popup.ViewModelType = typeof(DialogViewModel);
            popup.ViewModelSet += (s, e) => {
                var dlgFluent = popup.OfType<DialogViewModel>();
                dlgFluent.BindCommand("btnClose", x => x.Close);
                dlgFluent.BindCommand("btnAccept", x => x.Accept);
            };
        }

        [CodeExampleNestedClass]
        public partial class PopupView {
            /// <summary>
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;
            /// <summary>
            /// Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing) {
                if(disposing && (components != null)) {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            #region Component Designer generated code
            /// <summary> 
            /// Required method for Designer support - do not modify 
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent() {
                this.components = new System.ComponentModel.Container();
                this.mvvmContext = new MVVMContext(components);
                this.menuBar = new DevExpress.XtraEditors.HtmlContentControl();
                this.popup = new DevExpress.XtraEditors.HtmlContentPopup(components);
                this.SuspendLayout();
                // 
                // mvvmContext
                // 
                this.mvvmContext.ViewModelType = typeof(MainViewModel);
                this.mvvmContext.ContainerControl = this;
                // 
                // menuBar
                // 
                this.menuBar.Dock = System.Windows.Forms.DockStyle.Fill;
                this.menuBar.Size = new System.Drawing.Size(398, 468);
                // 
                // dialogPopup
                // 
                this.popup.ContainerControl = this;
                this.popup.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
                // 
                // PopupView
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
                this.Controls.Add(this.menuBar);
                this.Name = "PopupView";
                this.Size = new System.Drawing.Size(398, 468);
                this.ResumeLayout(false);
            }
            #endregion
            private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
            private DevExpress.XtraEditors.HtmlContentControl menuBar;
            private DevExpress.XtraEditors.HtmlContentPopup popup;
        }
        partial class PopupView : XtraUserControl {
            public PopupView() {
                InitializeComponent();
                InitializeStyles();
                if(mvvmContext.IsDesignMode)
                    return;
                // $CodeBehindInsertionLine$ 
            }
            void InitializeStyles() {
                menuBar.HtmlImages = Assets.SvgImages;
                menuBar.HtmlTemplate.Set(Loader.Load("MVVMMenuBar.html"), Loader.Load("MenuBar.css"));
            }
        }

        [CodeExampleNestedClass]
        public class MainViewModel {
            PopupViewModel popupViewModel;
            public void ShowPopup() {
                if(popupViewModel == null) {
                    popupViewModel = ViewModelSource.Create<PopupViewModel>();
                    popupViewModel.Text = "Click outside the popup to close it.";
                }
                var windowService = this.GetService<IWindowService>();
                // The following method call returns immediately due to the WindowService setup
                windowService.Show(null, popupViewModel, null, this);
            }
            DialogViewModel dialogViewModel;
            public void ShowDialog() {
                if(dialogViewModel == null) {
                    dialogViewModel = ViewModelSource.Create<DialogViewModel>();
                    dialogViewModel.Text = "Press OK button to accept the dialog.";
                }
                var windowService = this.GetService<IWindowService>();
                // The following method call does not return immediately due to the WindowService setup
                windowService.Show(null, dialogViewModel, null, this);
                if(dialogViewModel.Result) {
                    var msgService = this.GetService<IMessageBoxService>();
                    msgService.ShowMessage("Thanks");
                }
            }
        }
        [CodeExampleNestedClass]
        public class PopupViewModel {
            public string Title {
                get { return "Popup Window"; }
            }
            public virtual string Text {
                get;
                set;
            }
        }
        [CodeExampleNestedClass]
        public class DialogViewModel : IDocumentContent {
            public string Title {
                get { return "Dialog Window"; }
            }
            public virtual string Text {
                get;
                set;
            }
            public bool Result {
                get;
                private set;
            }
            public void Close() {
                Result = false;
                CloseDocument();
            }
            public void Accept() {
                Result = true;
                CloseDocument();
            }
            #region IDocumentContent
            void CloseDocument() {
                var owner = ((IDocumentContent)this).DocumentOwner;
                if(owner != null) owner.Close(this);
            }
            object IDocumentContent.Title {
                get { return Title; }
            }
            IDocumentOwner IDocumentContent.DocumentOwner { get; set; }
            void IDocumentContent.OnClose(CancelEventArgs e) { }
            void IDocumentContent.OnDestroy() { }
            #endregion IDocumentContent
        }
    }
}
