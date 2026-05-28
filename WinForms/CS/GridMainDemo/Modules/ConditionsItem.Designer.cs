namespace DevExpress.XtraGrid.Demos {
    partial class ConditionsItem {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConditionsItem));
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.icbCondition = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.lbVal1 = new DevExpress.XtraEditors.LabelControl();
            this.lbVal2 = new DevExpress.XtraEditors.LabelControl();
            this.ceRow = new DevExpress.XtraEditors.CheckEdit();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.propertyGrid1 = new DevExpress.DXperience.Demos.XtraPropertyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.icbCondition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceRow.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // icbCondition
            // 
            resources.ApplyResources(this.icbCondition, "icbCondition");
            this.icbCondition.Name = "icbCondition";
            this.icbCondition.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("icbCondition.Properties.Buttons"))))});
            this.icbCondition.Properties.DropDownRows = 10;
            this.icbCondition.SelectedIndexChanged += new System.EventHandler(this.icbCondition_SelectedIndexChanged);
            // 
            // lbVal1
            // 
            resources.ApplyResources(this.lbVal1, "lbVal1");
            this.lbVal1.Name = "lbVal1";
            // 
            // lbVal2
            // 
            resources.ApplyResources(this.lbVal2, "lbVal2");
            this.lbVal2.Name = "lbVal2";
            // 
            // ceRow
            // 
            resources.ApplyResources(this.ceRow, "ceRow");
            this.ceRow.Name = "ceRow";
            this.ceRow.Properties.Caption = resources.GetString("ceRow.Properties.Caption");
            this.ceRow.CheckedChanged += new System.EventHandler(this.ceRow_CheckedChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // propertyGrid1
            // 
            resources.ApplyResources(this.propertyGrid1, "propertyGrid1");
            this.propertyGrid1.Name = "propertyGrid1";
            // 
            // ConditionsItem
            // 
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ceRow);
            this.Controls.Add(this.lbVal2);
            this.Controls.Add(this.lbVal1);
            this.Controls.Add(this.icbCondition);
            this.Controls.Add(this.label1);
            this.Name = "ConditionsItem";
            resources.ApplyResources(this, "$this");
            ((System.ComponentModel.ISupportInitialize)(this.icbCondition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceRow.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbCondition;
        private DevExpress.XtraEditors.CheckEdit ceRow;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.DXperience.Demos.XtraPropertyGrid propertyGrid1;
        private DevExpress.XtraEditors.LabelControl lbVal1;
        private DevExpress.XtraEditors.LabelControl lbVal2;
        private System.ComponentModel.Container components = null;
    }
}
