namespace DevExpress.XtraPivotGrid.Demos.Modules {
    partial class frmStyleConditions {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sbRemove = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.sbAdd = new DevExpress.XtraEditors.SimpleButton();
            this.FormatItemList = new DevExpress.XtraEditors.ListBoxControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.conditionItem1 = new DevExpress.XtraPivotGrid.Demos.ConditionItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormatItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.sbRemove);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.sbAdd);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(4, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.panelControl1.Size = new System.Drawing.Size(503, 28);
            this.panelControl1.TabIndex = 3;
            // 
            // sbRemove
            // 
            this.sbRemove.Dock = System.Windows.Forms.DockStyle.Left;
            this.sbRemove.Enabled = false;
            this.sbRemove.Location = new System.Drawing.Point(164, 0);
            this.sbRemove.Name = "sbRemove";
            this.sbRemove.Size = new System.Drawing.Size(116, 24);
            this.sbRemove.TabIndex = 1;
            this.sbRemove.Text = "Remove";
            this.sbRemove.Click += new System.EventHandler(this.sbRemove_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl3.Location = new System.Drawing.Point(156, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(8, 24);
            this.panelControl3.TabIndex = 2;
            // 
            // sbAdd
            // 
            this.sbAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.sbAdd.Location = new System.Drawing.Point(0, 0);
            this.sbAdd.Name = "sbAdd";
            this.sbAdd.Size = new System.Drawing.Size(156, 24);
            this.sbAdd.TabIndex = 0;
            this.sbAdd.Text = "Add New Style Condition";
            this.sbAdd.Click += new System.EventHandler(this.sbAdd_Click);
            // 
            // FormatItemList
            // 
            this.FormatItemList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.FormatItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormatItemList.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.FormatItemList.ItemHeight = 16;
            this.FormatItemList.Location = new System.Drawing.Point(0, 0);
            this.FormatItemList.Name = "FormatItemList";
            this.FormatItemList.Size = new System.Drawing.Size(158, 332);
            this.FormatItemList.TabIndex = 4;
            this.FormatItemList.SelectedIndexChanged += new System.EventHandler(this.FormatItemList_SelectedIndexChanged);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(4, 32);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.FormatItemList);
            this.splitContainerControl1.Panel1.Text = "splitContainerControl1_Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.conditionItem1);
            this.splitContainerControl1.Panel2.Text = "splitContainerControl1_Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(503, 332);
            this.splitContainerControl1.SplitterPosition = 158;
            this.splitContainerControl1.TabIndex = 5;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // conditionItem1
            // 
            this.conditionItem1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conditionItem1.Location = new System.Drawing.Point(0, 0);
            this.conditionItem1.Name = "conditionItem1";
            this.conditionItem1.Size = new System.Drawing.Size(339, 332);
            this.conditionItem1.TabIndex = 0;
            this.conditionItem1.RefreshValues += new System.EventHandler(this.conditionItem1_RefreshValues);
            // 
            // frmStyleConditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(511, 368);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmStyleConditions";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Style Conditions Editor";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStyleConditions_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormatItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton sbRemove;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton sbAdd;
        private DevExpress.XtraEditors.ListBoxControl FormatItemList;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.ComponentModel.Container components = null;

    }
}
