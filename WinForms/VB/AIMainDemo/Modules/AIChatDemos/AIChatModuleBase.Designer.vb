#If NET
using DevExpress.AIIntegration.WinForms.Chat;
using DevExpress.XtraEditors;

namespace DevExpress.AI.Demos {
    partial class AIChatModuleBase {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(Options != null)
                    Options.PropertyChanged -= OptionsPropertyChanged;
                if(optionsBindingSource != null)
                    optionsBindingSource.Dispose();
                if(components != null)
                    components.Dispose();
            }
            base.Dispose(disposing);
        }

#Region "Component Designer generated code"

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            aiChatControl = new AIChatControl();
            layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            ucDisclaimerPanel1 = new ucDisclaimerPanel();
            roundedSkinPanel1 = new RoundedSkinPanel();
            sidePanel1 = new SidePanel();
            panelControl1 = new PanelControl();
            sidePanel2 = new SidePanel();
            tabPane = new DevExpress.XtraBars.Navigation.TabPane();
            optionsPage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            dataLayoutControl = new DevExpress.XtraDataLayout.DataLayoutControl();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            lciRoundedSkinPanel1 = new DevExpress.XtraLayout.LayoutControlItem();
            lciUcDisclaimerPanel1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)aiChatControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl3).BeginInit();
            layoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundedSkinPanel1).BeginInit();
            roundedSkinPanel1.SuspendLayout();
            sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            sidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabPane).BeginInit();
            tabPane.SuspendLayout();
            optionsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataLayoutControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lciRoundedSkinPanel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lciUcDisclaimerPanel1).BeginInit();
            SuspendLayout();
            // 
            // aiChatControl
            // 
            aiChatControl.Appearance.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
            aiChatControl.Appearance.Options.UseBackColor = true;
            aiChatControl.Dock = System.Windows.Forms.DockStyle.Fill;
            aiChatControl.ShowHeader = Utils.DefaultBoolean.True;
            aiChatControl.UseStreaming = Utils.DefaultBoolean.True;
            aiChatControl.Location = new System.Drawing.Point(11, 10);
            aiChatControl.Margin = new System.Windows.Forms.Padding(2);
            aiChatControl.MinimumSize = new System.Drawing.Size(21, 20);
            aiChatControl.Name = "aiChatControl";
            aiChatControl.Size = new System.Drawing.Size(686, 364);
            aiChatControl.TabIndex = 0;
            // 
            // layoutControl3
            // 
            layoutControl3.AllowCustomization = false;
            layoutControl3.Controls.Add(ucDisclaimerPanel1);
            layoutControl3.Controls.Add(roundedSkinPanel1);
            layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl3.Location = new System.Drawing.Point(0, 0);
            layoutControl3.Name = "layoutControl3";
            layoutControl3.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1039, 230, 650, 596);
            layoutControl3.Root = layoutControlGroup5;
            layoutControl3.Size = new System.Drawing.Size(992, 521);
            layoutControl3.TabIndex = 4;
            layoutControl3.Text = "layoutControl3";
            // 
            // ucDisclaimerPanel1
            // 
            ucDisclaimerPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ucDisclaimerPanel1.Location = new System.Drawing.Point(0, 0);
            ucDisclaimerPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ucDisclaimerPanel1.Name = "ucDisclaimerPanel1";
            ucDisclaimerPanel1.Size = new System.Drawing.Size(992, 103);
            ucDisclaimerPanel1.TabIndex = 7;
            // 
            // roundedSkinPanel1
            // 
            roundedSkinPanel1.Controls.Add(sidePanel1);
            roundedSkinPanel1.Location = new System.Drawing.Point(0, 103);
            roundedSkinPanel1.Name = "roundedSkinPanel1";
            roundedSkinPanel1.Size = new System.Drawing.Size(992, 418);
            roundedSkinPanel1.TabIndex = 3;
            // 
            // sidePanel1
            // 
            sidePanel1.Controls.Add(panelControl1);
            sidePanel1.Controls.Add(sidePanel2);
            sidePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            sidePanel1.Location = new System.Drawing.Point(17, 17);
            sidePanel1.Margin = new System.Windows.Forms.Padding(2);
            sidePanel1.MinimumSize = new System.Drawing.Size(32, 32);
            sidePanel1.Name = "sidePanel1";
            sidePanel1.Size = new System.Drawing.Size(958, 384);
            sidePanel1.TabIndex = 1;
            sidePanel1.Text = "sidePanel1";
            // 
            // panelControl1
            // 
            panelControl1.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl1.Controls.Add(aiChatControl);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Location = new System.Drawing.Point(0, 0);
            panelControl1.Margin = new System.Windows.Forms.Padding(2);
            panelControl1.Name = "panelControl1";
            panelControl1.Padding = new System.Windows.Forms.Padding(8);
            panelControl1.Size = new System.Drawing.Size(708, 384);
            panelControl1.TabIndex = 2;
            // 
            // sidePanel2
            // 
            sidePanel2.Controls.Add(tabPane);
            sidePanel2.Dock = System.Windows.Forms.DockStyle.Right;
            sidePanel2.Location = new System.Drawing.Point(708, 0);
            sidePanel2.Margin = new System.Windows.Forms.Padding(2);
            sidePanel2.Name = "sidePanel2";
            sidePanel2.Size = new System.Drawing.Size(250, 384);
            sidePanel2.TabIndex = 1;
            sidePanel2.Text = "sidePanel2";
            // 
            // tabPane
            // 
            tabPane.Controls.Add(optionsPage);
            tabPane.Dock = System.Windows.Forms.DockStyle.Fill;
            tabPane.Location = new System.Drawing.Point(1, 0);
            tabPane.Margin = new System.Windows.Forms.Padding(2);
            tabPane.Name = "tabPane";
            tabPane.Pages.AddRange(new XtraBars.Navigation.NavigationPageBase[] { optionsPage });
            tabPane.RegularSize = new System.Drawing.Size(249, 384);
            tabPane.SelectedPage = optionsPage;
            tabPane.Size = new System.Drawing.Size(249, 384);
            tabPane.TabIndex = 2;
            tabPane.Text = "tabPane1";
            // 
            // optionsPage
            // 
            optionsPage.Caption = "Options";
            optionsPage.Controls.Add(dataLayoutControl);
            optionsPage.Margin = new System.Windows.Forms.Padding(2);
            optionsPage.Name = "optionsPage";
            optionsPage.Size = new System.Drawing.Size(249, 428);
            // 
            // dataLayoutControl
            // 
            dataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            dataLayoutControl.Location = new System.Drawing.Point(0, 0);
            dataLayoutControl.Name = "dataLayoutControl";
            dataLayoutControl.Root = Root;
            dataLayoutControl.Size = new System.Drawing.Size(249, 428);
            dataLayoutControl.TabIndex = 0;
            dataLayoutControl.Text = "dataLayoutControl1";
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(249, 428);
            Root.TextVisible = false;
            // 
            // layoutControlGroup5
            // 
            layoutControlGroup5.EnableIndentsWithoutBorders = Utils.DefaultBoolean.False;
            layoutControlGroup5.GroupBordersVisible = false;
            layoutControlGroup5.Items.AddRange(new XtraLayout.BaseLayoutItem[] { lciRoundedSkinPanel1, lciUcDisclaimerPanel1 });
            layoutControlGroup5.Name = "Root";
            layoutControlGroup5.Size = new System.Drawing.Size(992, 521);
            layoutControlGroup5.TextVisible = false;
            // 
            // lciRoundedSkinPanel1
            // 
            lciRoundedSkinPanel1.Control = roundedSkinPanel1;
            lciRoundedSkinPanel1.Location = new System.Drawing.Point(0, 103);
            lciRoundedSkinPanel1.Name = "lciRoundedSkinPanel1";
            lciRoundedSkinPanel1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            lciRoundedSkinPanel1.Size = new System.Drawing.Size(992, 418);
            lciRoundedSkinPanel1.TextVisible = false;
            // 
            // lciUcDisclaimerPanel1
            // 
            lciUcDisclaimerPanel1.Control = ucDisclaimerPanel1;
            lciUcDisclaimerPanel1.Location = new System.Drawing.Point(0, 0);
            lciUcDisclaimerPanel1.Name = "lciUcDisclaimerPanel1";
            lciUcDisclaimerPanel1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            lciUcDisclaimerPanel1.Size = new System.Drawing.Size(992, 103);
            lciUcDisclaimerPanel1.TextVisible = false;
            // 
            // AIChatModuleBase
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(layoutControl3);
            Name = "AIChatModuleBase";
            Size = new System.Drawing.Size(992, 521);
            ((System.ComponentModel.ISupportInitialize)aiChatControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl3).EndInit();
            layoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)roundedSkinPanel1).EndInit();
            roundedSkinPanel1.ResumeLayout(false);
            sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            sidePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tabPane).EndInit();
            tabPane.ResumeLayout(false);
            optionsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataLayoutControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup5).EndInit();
            ((System.ComponentModel.ISupportInitialize)lciRoundedSkinPanel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)lciUcDisclaimerPanel1).EndInit();
            ResumeLayout(false);

        }

#End Region
        private XtraLayout.LayoutControl layoutControl3;
        private XtraLayout.LayoutControlGroup layoutControlGroup5;
        private ucDisclaimerPanel ucDisclaimerPanel1;
        private XtraLayout.LayoutControlItem lciUcDisclaimerPanel1;
        private AIChatControl aiChatControl;
        private RoundedSkinPanel roundedSkinPanel1;
        private XtraLayout.LayoutControlItem lciRoundedSkinPanel1;
        private SidePanel sidePanel1;
        private SidePanel sidePanel2;
        private XtraDataLayout.DataLayoutControl dataLayoutControl;
        private XtraLayout.LayoutControlGroup Root;
        private XtraBars.Navigation.TabPane tabPane;
        private XtraBars.Navigation.TabNavigationPage optionsPage;
        private PanelControl panelControl1;
    }
}
#End If
