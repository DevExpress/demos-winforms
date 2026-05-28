namespace DevExpress.XtraPivotGrid.Demos.Modules {
    partial class CustomCellValue {
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
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup1 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            this.fieldOrderYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderQuarter = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldCompanyName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fieldOrderYear
            // 
            this.fieldOrderYear.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldOrderYear.AreaIndex = 0;
            this.fieldOrderYear.Caption = "Order Year";
            this.fieldOrderYear.FieldName = "OrderDate";
            this.fieldOrderYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldOrderYear.Name = "fieldOrderYear";
            this.fieldOrderYear.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            this.fieldOrderYear.UnboundFieldName = "fieldOrderYear";
            // 
            // fieldOrderQuarter
            // 
            this.fieldOrderQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldOrderQuarter.AreaIndex = 1;
            this.fieldOrderQuarter.Caption = "Order Quarter";
            this.fieldOrderQuarter.FieldName = "OrderDate";
            this.fieldOrderQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.fieldOrderQuarter.Name = "fieldOrderQuarter";
            this.fieldOrderQuarter.UnboundFieldName = "fieldOrderQuarter";
            this.fieldOrderQuarter.ValueFormat.FormatString = "Qtr {0}";
            this.fieldOrderQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pivotGridControl1.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCompanyName,
            this.fieldProductAmount,
            this.fieldOrderYear,
            this.fieldOrderQuarter});
            pivotGridGroup1.Fields.Add(this.fieldOrderYear);
            pivotGridGroup1.Fields.Add(this.fieldOrderQuarter);
            pivotGridGroup1.Hierarchy = null;
            this.pivotGridControl1.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(634, 506);
            this.pivotGridControl1.TabIndex = 3;
            this.pivotGridControl1.FieldValueDisplayText += new DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventHandler(this.pivotGridControl1_FieldValueDisplayText);
            this.pivotGridControl1.CustomCellValue += new System.EventHandler<DevExpress.XtraPivotGrid.PivotCellValueEventArgs>(this.pivotGridControl1_CustomCellValue);
            // 
            // fieldCompanyName
            // 
            this.fieldCompanyName.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldCompanyName.AreaIndex = 0;
            this.fieldCompanyName.Caption = "Customer";
            this.fieldCompanyName.FieldName = "CompanyName";
            this.fieldCompanyName.Name = "fieldCompanyName";
            this.fieldCompanyName.Width = 150;
            // 
            // fieldProductAmount
            // 
            this.fieldProductAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldProductAmount.AreaIndex = 0;
            this.fieldProductAmount.Caption = "Amount";
            this.fieldProductAmount.CellFormat.FormatString = "c";
            this.fieldProductAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldProductAmount.FieldName = "ProductAmount";
            this.fieldProductAmount.Name = "fieldProductAmount";
            this.fieldProductAmount.Width = 130;
            // 
            // CustomCellValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "CustomCellValue";
            this.Size = new System.Drawing.Size(634, 506);
            this.Load += new System.EventHandler(this.CustomCellValue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private DevExpress.XtraPivotGrid.Demos.dsReports dsReports1;
        private PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCompanyName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductAmount;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderYear;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderQuarter;

    }
}
