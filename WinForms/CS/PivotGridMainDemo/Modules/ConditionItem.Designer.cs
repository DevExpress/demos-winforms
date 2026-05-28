using DevExpress.DXperience.Demos;
namespace DevExpress.XtraPivotGrid.Demos {
    partial class ConditionItem {
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
            this.propertyGrid1 = new DevExpress.DXperience.Demos.XtraPropertyGrid();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.lbVal2 = new DevExpress.XtraEditors.LabelControl();
            this.lbVal1 = new DevExpress.XtraEditors.LabelControl();
            this.icbCondition = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.seValue1 = new DevExpress.XtraEditors.SpinEdit();
            this.seValue2 = new DevExpress.XtraEditors.SpinEdit();
            this.ceCell = new DevExpress.XtraEditors.CheckEdit();
            this.ceTotalCell = new DevExpress.XtraEditors.CheckEdit();
            this.ceGrandTotalCell = new DevExpress.XtraEditors.CheckEdit();
            this.ceCustomSummaryCell = new DevExpress.XtraEditors.CheckEdit();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.icbCondition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seValue1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seValue2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceCell.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceTotalCell.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceGrandTotalCell.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceCustomSummaryCell.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.Location = new System.Drawing.Point(12, 168);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.ShowButtons = false;
            this.propertyGrid1.ShowCategories = false;
            this.propertyGrid1.ShowDescription = false;
            this.propertyGrid1.Size = new System.Drawing.Size(274, 192);
            this.propertyGrid1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline);
            this.label4.Location = new System.Drawing.Point(8, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Appearance:";
            this.label4.LineLocation = DevExpress.XtraEditors.LineLocation.Left;
            //= System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            // 
            // lbVal2
            // 
            this.lbVal2.Location = new System.Drawing.Point(8, 56);
            this.lbVal2.Name = "lbVal2";
            this.lbVal2.Size = new System.Drawing.Size(92, 20);
            this.lbVal2.TabIndex = 10;
            this.lbVal2.Text = "Value 2:";
            this.lbVal2.LineLocation = DevExpress.XtraEditors.LineLocation.Left;
            this.lbVal2.BackColor = System.Drawing.Color.Transparent;
            // 
            // lbVal1
            // 
            this.lbVal1.Location = new System.Drawing.Point(8, 32);
            this.lbVal1.Name = "lbVal1";
            this.lbVal1.Size = new System.Drawing.Size(92, 20);
            this.lbVal1.TabIndex = 9;
            this.lbVal1.Text = "Value 1:";
            this.lbVal1.LineLocation = DevExpress.XtraEditors.LineLocation.Left;
            this.lbVal1.BackColor = System.Drawing.Color.Transparent;
            // 
            // icbCondition
            // 
            this.icbCondition.EditValue = "imageComboBoxEdit1";
            this.icbCondition.Location = new System.Drawing.Point(104, 8);
            this.icbCondition.Name = "icbCondition";
            this.icbCondition.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbCondition.Properties.DropDownRows = 10;
            this.icbCondition.Size = new System.Drawing.Size(132, 20);
            this.icbCondition.TabIndex = 0;
            this.icbCondition.SelectedIndexChanged += new System.EventHandler(this.icbCondition_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Condition:";
            this.label1.LineLocation = DevExpress.XtraEditors.LineLocation.Left;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            // 
            // seValue1
            // 
            this.seValue1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seValue1.Location = new System.Drawing.Point(124, 32);
            this.seValue1.Name = "seValue1";
            this.seValue1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seValue1.Size = new System.Drawing.Size(112, 20);
            this.seValue1.TabIndex = 1;
            this.seValue1.EditValueChanged += new System.EventHandler(this.seValue1_EditValueChanged);
            // 
            // seValue2
            // 
            this.seValue2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seValue2.Location = new System.Drawing.Point(124, 56);
            this.seValue2.Name = "seValue2";
            this.seValue2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seValue2.Size = new System.Drawing.Size(112, 20);
            this.seValue2.TabIndex = 2;
            this.seValue2.EditValueChanged += new System.EventHandler(this.seValue2_EditValueChanged);
            // 
            // ceCell
            // 
            this.ceCell.Location = new System.Drawing.Point(8, 104);
            this.ceCell.Name = "ceCell";
            this.ceCell.Properties.Caption = "Cell";
            this.ceCell.Size = new System.Drawing.Size(108, 19);
            this.ceCell.TabIndex = 4;
            this.ceCell.CheckedChanged += new System.EventHandler(this.ceCell_CheckedChanged);
            // 
            // ceTotalCell
            // 
            this.ceTotalCell.Location = new System.Drawing.Point(8, 124);
            this.ceTotalCell.Name = "ceTotalCell";
            this.ceTotalCell.Properties.Caption = "Total Cell";
            this.ceTotalCell.Size = new System.Drawing.Size(108, 19);
            this.ceTotalCell.TabIndex = 5;
            this.ceTotalCell.CheckedChanged += new System.EventHandler(this.ceTotalCell_CheckedChanged);
            // 
            // ceGrandTotalCell
            // 
            this.ceGrandTotalCell.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ceGrandTotalCell.Location = new System.Drawing.Point(124, 104);
            this.ceGrandTotalCell.Name = "ceGrandTotalCell";
            this.ceGrandTotalCell.Properties.Caption = "Grand Total Cell";
            this.ceGrandTotalCell.Size = new System.Drawing.Size(162, 19);
            this.ceGrandTotalCell.TabIndex = 6;
            this.ceGrandTotalCell.CheckedChanged += new System.EventHandler(this.ceGrandTotalCell_CheckedChanged);
            // 
            // ceCustomSummaryCell
            // 
            this.ceCustomSummaryCell.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ceCustomSummaryCell.Location = new System.Drawing.Point(124, 124);
            this.ceCustomSummaryCell.Name = "ceCustomSummaryCell";
            this.ceCustomSummaryCell.Properties.Caption = "Custom Total Cell";
            this.ceCustomSummaryCell.Size = new System.Drawing.Size(162, 19);
            this.ceCustomSummaryCell.TabIndex = 7;
            this.ceCustomSummaryCell.CheckedChanged += new System.EventHandler(this.ceCustomSummaryCell_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline);
            this.label2.Location = new System.Drawing.Point(8, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Apply To:";
            this.label2.LineLocation = DevExpress.XtraEditors.LineLocation.Left;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            // 
            // ConditionItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ceCustomSummaryCell);
            this.Controls.Add(this.ceGrandTotalCell);
            this.Controls.Add(this.ceTotalCell);
            this.Controls.Add(this.ceCell);
            this.Controls.Add(this.seValue2);
            this.Controls.Add(this.seValue1);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbVal2);
            this.Controls.Add(this.lbVal1);
            this.Controls.Add(this.icbCondition);
            this.Controls.Add(this.label1);
            this.Name = "ConditionItem";
            this.Size = new System.Drawing.Size(294, 368);
            ((System.ComponentModel.ISupportInitialize)(this.icbCondition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seValue1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seValue2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceCell.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceTotalCell.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceGrandTotalCell.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceCustomSummaryCell.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private XtraPropertyGrid propertyGrid1;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraEditors.LabelControl lbVal2;
        private DevExpress.XtraEditors.LabelControl lbVal1;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbCondition;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.SpinEdit seValue1;
        private DevExpress.XtraEditors.SpinEdit seValue2;
        private DevExpress.XtraEditors.CheckEdit ceCell;
        private DevExpress.XtraEditors.CheckEdit ceTotalCell;
        private DevExpress.XtraEditors.CheckEdit ceGrandTotalCell;
        private DevExpress.XtraEditors.CheckEdit ceCustomSummaryCell;
        private DevExpress.XtraEditors.LabelControl label2;
        private System.ComponentModel.Container components = null;
        
    }
}
