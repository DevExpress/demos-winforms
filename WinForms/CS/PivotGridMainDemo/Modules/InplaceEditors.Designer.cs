namespace DevExpress.XtraPivotGrid.Demos.Modules {
	partial class InplaceEditors {
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.controlPanel = new DevExpress.XtraEditors.PanelControl();
            this.paddingPanel = new DevExpress.XtraEditors.PanelControl();
            this.mainPanel = new DevExpress.XtraEditors.PanelControl();
            this.pivotGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldCategoryName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesPerson = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.fieldPercents = new DevExpress.XtraPivotGrid.PivotGridField();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.controlPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddingPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(700, 21);
            this.controlPanel.TabIndex = 0;
            this.controlPanel.Visible = false;
            // 
            // paddingPanel
            // 
            this.paddingPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.paddingPanel.Location = new System.Drawing.Point(0, 21);
            this.paddingPanel.Name = "paddingPanel";
            this.paddingPanel.Size = new System.Drawing.Size(700, 8);
            this.paddingPanel.TabIndex = 1;
            this.paddingPanel.Visible = false;
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mainPanel.Controls.Add(this.pivotGridControl);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 29);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(700, 371);
            this.mainPanel.TabIndex = 2;
            // 
            // pivotGridControl
            // 
            this.pivotGridControl.OptionsData.DataProcessingEngine = PivotDataProcessingEngine.Optimized;
            this.pivotGridControl.ActiveFilterString = "";
            this.pivotGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pivotGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText;
            this.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCategoryName,
            this.fieldSalesPerson,
            this.fieldExtendedPrice,
            this.fieldPercents});
            this.pivotGridControl.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl.Name = "pivotGridControl";
            this.pivotGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemProgressBar1,
            this.repositoryItemCalcEdit1});
            this.pivotGridControl.Size = new System.Drawing.Size(700, 371);
            this.pivotGridControl.TabIndex = 0;
            this.pivotGridControl.GridLayout += new System.EventHandler(this.pivotGridControl_GridLayout);
            this.pivotGridControl.FieldValueImageIndex += new DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(this.pivotGridControl_FieldValueImageIndex);
            this.pivotGridControl.CustomAppearance += new DevExpress.XtraPivotGrid.PivotCustomAppearanceEventHandler(this.pivotGridControl_CustomAppearance);
            this.pivotGridControl.EditValueChanged += new DevExpress.XtraPivotGrid.EditValueChangedEventHandler(this.pivotGridControl_EditorValueChanged);
            this.pivotGridControl.CustomEditValue += new DevExpress.XtraPivotGrid.CustomEditValueEventHandler(this.pivotGridControl_CustomEditValue);
            this.pivotGridControl.ShowingEditor += new System.EventHandler<DevExpress.XtraPivotGrid.CancelPivotCellEditEventArgs>(this.pivotGridControl_ShowingEditor);
            // 
            // fieldCategoryName
            // 
            this.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldCategoryName.AreaIndex = 0;
            this.fieldCategoryName.Caption = "CategoryName";
            this.fieldCategoryName.DataBinding = new DataSourceColumnBinding("CategoryName");
            this.fieldCategoryName.Name = "fieldCategoryName";
            // 
            // fieldSalesPerson
            // 
            this.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldSalesPerson.AreaIndex = 0;
            this.fieldSalesPerson.Caption = "Sales Person";
            this.fieldSalesPerson.DataBinding = new DataSourceColumnBinding("Sales Person");
            this.fieldSalesPerson.Name = "fieldSalesPerson";
            // 
            // fieldExtendedPrice
            // 
            this.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldExtendedPrice.AreaIndex = 0;
            this.fieldExtendedPrice.Caption = "Extended Price";
            this.fieldExtendedPrice.FieldEdit = this.repositoryItemCalcEdit1;
            this.fieldExtendedPrice.DataBinding = new DataSourceColumnBinding("Extended Price");
            this.fieldExtendedPrice.Name = "fieldExtendedPrice";
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.DisplayFormat.FormatString = "c";
            this.repositoryItemCalcEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // fieldPercents
            // 
            this.fieldPercents.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPercents.AreaIndex = 1;
            this.fieldPercents.Caption = "Percent Of Column";
            this.fieldPercents.CellFormat.FormatString = "{0}%";
            this.fieldPercents.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fieldPercents.FieldEdit = this.repositoryItemProgressBar1;
            this.fieldPercents.DataBinding = new PercentOfTotalBinding(new DataSourceColumnBinding("Extended Price"), CalculationPartitioningCriteria.ColumnValue);
            this.fieldPercents.Name = "fieldPercents";
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemProgressBar1.DisplayFormat.FormatString = "{0}%";
            this.repositoryItemProgressBar1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            this.repositoryItemProgressBar1.ShowTitle = true;
            this.repositoryItemProgressBar1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.progressBar_KeyPress);
            // 
            // InplaceEditors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.paddingPanel);
            this.Controls.Add(this.controlPanel);
            this.Name = "InplaceEditors";
            this.Size = new System.Drawing.Size(700, 400);
            ((System.ComponentModel.ISupportInitialize)(this.controlPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddingPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            this.ResumeLayout(false);

		}


		private DevExpress.XtraEditors.PanelControl controlPanel;
		private DevExpress.XtraEditors.PanelControl paddingPanel;
		private DevExpress.XtraEditors.PanelControl mainPanel;
		#endregion
		private PivotGridControl pivotGridControl;
		private PivotGridField fieldCategoryName;
		private PivotGridField fieldSalesPerson;
		private PivotGridField fieldExtendedPrice;
		private PivotGridField fieldPercents;
		private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
		private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;

	}
}
