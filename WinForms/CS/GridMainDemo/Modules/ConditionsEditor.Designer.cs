namespace DevExpress.XtraGrid.Demos {
    partial class ConditionsEditor {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConditionsEditor));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sbRemove = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.sbAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.FormatItemList = new DevExpress.XtraEditors.ListBoxControl();
            this.splitter1 = new DevExpress.XtraEditors.SplitterControl();
            this.conditionsItem1 = new DevExpress.XtraGrid.Demos.ConditionsItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormatItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.sbRemove);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.sbAdd);
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
            // 
            // sbRemove
            // 
            resources.ApplyResources(this.sbRemove, "sbRemove");
            this.sbRemove.Name = "sbRemove";
            this.sbRemove.Click += new System.EventHandler(this.sbRemove_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("panelControl3.Appearance.BackColor")));
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            resources.ApplyResources(this.panelControl3, "panelControl3");
            this.panelControl3.Name = "panelControl3";
            // 
            // sbAdd
            // 
            resources.ApplyResources(this.sbAdd, "sbAdd");
            this.sbAdd.Name = "sbAdd";
            this.sbAdd.Click += new System.EventHandler(this.sbAdd_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.conditionsItem1);
            resources.ApplyResources(this.panelControl2, "panelControl2");
            this.panelControl2.Name = "panelControl2";
            // 
            // FormatItemList
            // 
            resources.ApplyResources(this.FormatItemList, "FormatItemList");
            this.FormatItemList.ItemHeight = 16;
            this.FormatItemList.Name = "FormatItemList";
            this.FormatItemList.SelectedIndexChanged += new System.EventHandler(this.FormatItemList_SelectedIndexChanged);
            // 
            // splitter1
            // 
            resources.ApplyResources(this.splitter1, "splitter1");
            this.splitter1.Name = "splitter1";
            this.splitter1.TabStop = false;
            // 
            // conditionsItem1
            // 
            this.conditionsItem1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.conditionsItem1, "conditionsItem1");
            this.conditionsItem1.Name = "conditionsItem1";
            this.conditionsItem1.RefreshValues += new System.EventHandler(this.conditionsItem1_RefreshValues);
            // 
            // ConditionsEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.FormatItemList);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConditionsEditor";
            this.ShowInTaskbar = false;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConditionsEditor_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FormatItemList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton sbAdd;
        private DevExpress.XtraEditors.SimpleButton sbRemove;
        private DevExpress.XtraEditors.SplitterControl splitter1;
        private System.ComponentModel.Container components = null;
        private DevExpress.XtraEditors.ListBoxControl FormatItemList;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private ConditionsItem conditionsItem1;
    }
}
