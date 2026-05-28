#if NET
using DevExpress.AIIntegration.WinForms.Chat;
using DevExpress.XtraEditors;

namespace DevExpress.AI.Demos {
    partial class AgentModuleBase {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent() {
            aiChatControl = new AIChatControl();
            layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            ucDisclaimerPanel1 = new ucDisclaimerPanel();
            roundedSkinPanel1 = new RoundedSkinPanel();
            panelControl1 = new PanelControl();
            layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            lciRoundedSkinPanel1 = new DevExpress.XtraLayout.LayoutControlItem();
            lciUcDisclaimerPanel1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)aiChatControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl3).BeginInit();
            layoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundedSkinPanel1).BeginInit();
            roundedSkinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
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
            aiChatControl.Location = new System.Drawing.Point(8, 8);
            aiChatControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            aiChatControl.MinimumSize = new System.Drawing.Size(35, 35);
            aiChatControl.Name = "aiChatControl";
            aiChatControl.ShowHeader = Utils.DefaultBoolean.True;
            aiChatControl.Size = new System.Drawing.Size(958, 417);
            aiChatControl.TabIndex = 0;
            aiChatControl.UseStreaming = Utils.DefaultBoolean.True;
            // 
            // layoutControl3
            // 
            layoutControl3.AllowCustomization = false;
            layoutControl3.Controls.Add(ucDisclaimerPanel1);
            layoutControl3.Controls.Add(roundedSkinPanel1);
            layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl3.Location = new System.Drawing.Point(0, 0);
            layoutControl3.Name = "layoutControl3";
            layoutControl3.Root = layoutControlGroup5;
            layoutControl3.Size = new System.Drawing.Size(992, 521);
            layoutControl3.TabIndex = 4;
            layoutControl3.Text = "layoutControl3";
            // 
            // ucDisclaimerPanel1
            // 
            ucDisclaimerPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ucDisclaimerPanel1.Location = new System.Drawing.Point(0, 0);
            ucDisclaimerPanel1.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            ucDisclaimerPanel1.Name = "ucDisclaimerPanel1";
            ucDisclaimerPanel1.Size = new System.Drawing.Size(992, 70);
            ucDisclaimerPanel1.TabIndex = 7;
            // 
            // roundedSkinPanel1
            // 
            roundedSkinPanel1.Controls.Add(panelControl1);
            roundedSkinPanel1.Location = new System.Drawing.Point(0, 70);
            roundedSkinPanel1.Name = "roundedSkinPanel1";
            roundedSkinPanel1.Size = new System.Drawing.Size(992, 451);
            roundedSkinPanel1.TabIndex = 3;
            // 
            // panelControl1
            // 
            panelControl1.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl1.Controls.Add(aiChatControl);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Location = new System.Drawing.Point(9, 9);
            panelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            panelControl1.Name = "panelControl1";
            panelControl1.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            panelControl1.Size = new System.Drawing.Size(974, 433);
            panelControl1.TabIndex = 2;
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
            lciRoundedSkinPanel1.Location = new System.Drawing.Point(0, 70);
            lciRoundedSkinPanel1.Name = "lciRoundedSkinPanel1";
            lciRoundedSkinPanel1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            lciRoundedSkinPanel1.Size = new System.Drawing.Size(992, 451);
            lciRoundedSkinPanel1.TextVisible = false;
            // 
            // lciUcDisclaimerPanel1
            // 
            lciUcDisclaimerPanel1.Control = ucDisclaimerPanel1;
            lciUcDisclaimerPanel1.Location = new System.Drawing.Point(0, 0);
            lciUcDisclaimerPanel1.Name = "lciUcDisclaimerPanel1";
            lciUcDisclaimerPanel1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            lciUcDisclaimerPanel1.Size = new System.Drawing.Size(992, 70);
            lciUcDisclaimerPanel1.TextVisible = false;
            // 
            // AgentModuleBase
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(layoutControl3);
            Name = "AgentModuleBase";
            Size = new System.Drawing.Size(992, 521);
            ((System.ComponentModel.ISupportInitialize)aiChatControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl3).EndInit();
            layoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)roundedSkinPanel1).EndInit();
            roundedSkinPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup5).EndInit();
            ((System.ComponentModel.ISupportInitialize)lciRoundedSkinPanel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)lciUcDisclaimerPanel1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private XtraLayout.LayoutControl layoutControl3;
        private XtraLayout.LayoutControlGroup layoutControlGroup5;
        private ucDisclaimerPanel ucDisclaimerPanel1;
        private XtraLayout.LayoutControlItem lciUcDisclaimerPanel1;
        private AIChatControl aiChatControl;
        private RoundedSkinPanel roundedSkinPanel1;
        private XtraLayout.LayoutControlItem lciRoundedSkinPanel1;
        private PanelControl panelControl1;
    }
}
#endif
