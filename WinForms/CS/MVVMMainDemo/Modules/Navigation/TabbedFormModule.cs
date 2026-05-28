using System;
using DevExpress.MVVM.Demos.ViewModels;
using DevExpress.Utils.MVVM.Services;

namespace DevExpress.MVVM.Demos.Navigation {
    public partial class TabbedFormModule : DevExpress.XtraBars.TabForm {
        public TabbedFormModule() {
            InitializeComponent();
            if(!mvvmContext.IsDesignMode)
                InitializeNavigation(true);
        }
        public TabbedFormModule(bool loadDefaultModule) {
            InitializeComponent();
            if(!mvvmContext.IsDesignMode)
                InitializeNavigation(loadDefaultModule);
        }
        void tabFormControl_OuterFormCreating(object sender, XtraBars.OuterFormCreatingEventArgs e) {
            // creating secondary Tab Form
            e.Form = new TabbedFormModule(false);
        }
        void tabFormControl_PageClosed(object sender, XtraBars.PageClosedEventArgs e) {
            // close empty form
            if(tabFormControl.Pages.Count == 0)
                Close();
        }
        void InitializeNavigation(bool loadDefaultModule) {
            // We want the DocumentManagerService based on TabFormControl to be a navigation provider
            mvvmContext.RegisterService(DocumentManagerService.Create(tabFormControl));
            // We want to use buttons in TabFormControl to show the specific modules
            var fluent = mvvmContext.OfType<ExpensesDbContextViewModel>();
            // assign True if needed to load default module (True for main Tab Form, False for secondary Tab Form)
            fluent.ViewModel.AllowDefaultModule = loadDefaultModule;
            fluent.BindCommand(biAccounts, x => x.Show, x => x.Modules[0]);
            fluent.BindCommand(biCategories, x => x.Show, x => x.Modules[1]);
            fluent.BindCommand(biTransactions, x => x.Show, x => x.Modules[2]);
            // We want show the default module when our TabForm is loaded
            fluent.WithEvent<EventArgs>(this, "Load")
                .EventToCommand(x => x.OnLoaded, x => x.DefaultModule);
            // We want to add a new Entity into the active Entities list
            fluent.BindCommand(tabFormControl.AddPageButton, x => x.AddNew);
        }
    }
    #region Module Starter
    public partial class TabbedFormModuleStarter : TutorialControl {
        DXperience.Demos.CodeDemo.RichEditUserControl sourceCode;
        DevExpress.XtraEditors.PanelControl showModuleButton;
        public TabbedFormModuleStarter() {
            InitializeComponent();
            var asm = typeof(DevExpress.Tutorials.ucAboutPage).Assembly;
            new DevExpress.Tutorials.Controls.OverviewButton(showModuleButton,
                    DevExpress.Utils.ResourceImageHelper.CreateImageFromResources("DevExpress.Tutorials.Images.RunButtonNormal.png", asm),
                    DevExpress.Utils.ResourceImageHelper.CreateImageFromResources("DevExpress.Tutorials.Images.RunButtonHover.png", asm),
                    DevExpress.Utils.ResourceImageHelper.CreateImageFromResources("DevExpress.Tutorials.Images.RunButtonPressed.png", asm),
                    string.Empty).ButtonClick += showModuleButton_Click;
            //
            LoadSourceCode(sourceCode, "tabFormControl_OuterFormCreating", typeof(TabbedFormModule));
            LoadSourceCode(sourceCode, "tabFormControl_PageClosed", typeof(TabbedFormModule), true);
            LoadSourceCode(sourceCode, "InitializeNavigation", typeof(TabbedFormModule), true);
        }
        void InitializeComponent() {
            this.sourceCode = new DevExpress.DXperience.Demos.CodeDemo.RichEditUserControl();
            this.showModuleButton = new XtraEditors.PanelControl();
            this.SuspendLayout();
            // 
            // showModuleButton
            // 
            this.showModuleButton.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder;
            this.showModuleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showModuleButton.Name = "showModuleButton";
            this.showModuleButton.Text = "Start the TabbedForm Module";
            // 
            // sourceCode
            // 
            this.sourceCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sourceCode.Location = new System.Drawing.Point(5, 217);
            this.sourceCode.Padding = new System.Windows.Forms.Padding(16);
            this.sourceCode.Name = "sourceCode";
            this.sourceCode.Size = new System.Drawing.Size(779, 352);
            // 
            // WindowedModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Controls.Add(this.showModuleButton);
            this.Controls.Add(this.sourceCode);
            this.Name = "TabbedFormModuleStarter";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        //
        TabbedFormModule module;
        void showModuleButton_Click(object sender, EventArgs e) {
            if(module == null) {
                module = new TabbedFormModule();
                module.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                if(ParentFormMain != null) {
                    module.Location = new System.Drawing.Point(
                        ParentFormMain.Left + (ParentFormMain.Width - module.Width) / 2,
                        ParentFormMain.Top + (ParentFormMain.Height - module.Height) / 2);
                }
                module.FormClosed += activeModule_FormClosed;
            }
            showModuleButton.Enabled = false;
            module.Show(this);
        }
        void activeModule_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e) {
            if(module != null)
                module.FormClosed -= activeModule_FormClosed;
            module = null;
            showModuleButton.Enabled = true;
        }
        protected override void DoVisibleChanged(bool visible) {
            base.DoVisibleChanged(visible);
            if(!visible && module != null && module.Visible)
                module.Close();
        }
    }
    #endregion
}
