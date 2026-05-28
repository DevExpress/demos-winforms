namespace DevExpress.XtraScheduler.Demos {
    partial class SendAppointmentByMailForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lblMessage = new DevExpress.XtraEditors.LabelControl();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciProgressPanel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciBtnOk = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciMessage = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProgressPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.BarAnimationElementThickness = 2;
            this.progressPanel1.Location = new System.Drawing.Point(12, 12);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(322, 16);
            this.progressPanel1.StyleController = this.layoutControl1;
            this.progressPanel1.TabIndex = 0;
            this.progressPanel1.Text = "progressPanel1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lblMessage);
            this.layoutControl1.Controls.Add(this.progressPanel1);
            this.layoutControl1.Controls.Add(this.btnOk);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(478, 296, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(363, 106);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(12, 32);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(63, 13);
            this.lblMessage.StyleController = this.layoutControl1;
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "labelControl1";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(258, 73);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(66, 23);
            this.btnOk.StyleController = this.layoutControl1;
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciProgressPanel,
            this.lciBtnOk,
            this.emptySpaceItem1,
            this.lciMessage,
            this.emptySpaceItem2,
            this.emptySpaceItem3});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(346, 108);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciProgressPanel
            // 
            this.lciProgressPanel.Control = this.progressPanel1;
            this.lciProgressPanel.Location = new System.Drawing.Point(0, 0);
            this.lciProgressPanel.MinSize = new System.Drawing.Size(54, 20);
            this.lciProgressPanel.Name = "lciProgressPanel";
            this.lciProgressPanel.Size = new System.Drawing.Size(326, 20);
            this.lciProgressPanel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciProgressPanel.TextSize = new System.Drawing.Size(0, 0);
            this.lciProgressPanel.TextVisible = false;
            // 
            // lciBtnOk
            // 
            this.lciBtnOk.Control = this.btnOk;
            this.lciBtnOk.CustomizationFormText = "layoutControlItem1";
            this.lciBtnOk.Location = new System.Drawing.Point(246, 61);
            this.lciBtnOk.MaxSize = new System.Drawing.Size(70, 27);
            this.lciBtnOk.MinSize = new System.Drawing.Size(70, 27);
            this.lciBtnOk.Name = "lciBtnOk";
            this.lciBtnOk.Size = new System.Drawing.Size(70, 27);
            this.lciBtnOk.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciBtnOk.Text = "layoutControlItem1";
            this.lciBtnOk.TextLocation = DevExpress.Utils.Locations.Left;
            this.lciBtnOk.TextSize = new System.Drawing.Size(0, 0);
            this.lciBtnOk.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(316, 61);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(10, 27);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 27);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(10, 27);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciMessage
            // 
            this.lciMessage.Control = this.lblMessage;
            this.lciMessage.Location = new System.Drawing.Point(0, 20);
            this.lciMessage.Name = "lciMessage";
            this.lciMessage.Size = new System.Drawing.Size(326, 17);
            this.lciMessage.TextSize = new System.Drawing.Size(0, 0);
            this.lciMessage.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 61);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(246, 27);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 37);
            this.emptySpaceItem3.MinSize = new System.Drawing.Size(104, 24);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(326, 24);
            this.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // SendAppointmentByMailForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOk;
            this.ClientSize = new System.Drawing.Size(363, 106);
            this.Controls.Add(this.layoutControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SendAppointmentByMailForm";
            this.ShowIcon = false;
            this.Text = "Opening Default Mail Client";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProgressPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraWaitForm.ProgressPanel progressPanel1;
        private XtraEditors.LabelControl lblMessage;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem lciProgressPanel;
        private XtraLayout.LayoutControlItem lciMessage;
        private XtraEditors.SimpleButton btnOk;
        private XtraLayout.LayoutControlItem lciBtnOk;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem2;
        private XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}
