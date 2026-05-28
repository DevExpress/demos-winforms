namespace DevExpress.XtraPivotGrid.Demos.Modules {
	partial class OLAPKPI {
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
            this.fieldTrend = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldStatus = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField5 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField4 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ddlTrendGraphics = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ddlStatusGraphics = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.separator1 = new DevExpress.XtraEditors.PanelControl();
            this.panelError = new DevExpress.XtraEditors.PanelControl();
            this.hyperLinkEdit1 = new DevExpress.XtraEditors.HyperLinkEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlTrendGraphics.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlStatusGraphics.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelError)).BeginInit();
            this.panelError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fieldTrend
            // 
            this.fieldTrend.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldTrend.AreaIndex = 3;
            this.fieldTrend.Caption = "Trend";
            this.fieldTrend.FieldName = "[Measures].[Internet Revenue Trend]";
            this.fieldTrend.Name = "fieldTrend";
            this.fieldTrend.ToolTips.HeaderText = "[Measures].[Internet Revenue Trend]";
            this.fieldTrend.ToolTips.ValueText = "[Measures].[Internet Revenue Trend]";
            // 
            // fieldStatus
            // 
            this.fieldStatus.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldStatus.AreaIndex = 2;
            this.fieldStatus.Caption = "Status";
            this.fieldStatus.FieldName = "[Measures].[Internet Revenue Status]";
            this.fieldStatus.Name = "fieldStatus";
            this.fieldStatus.ToolTips.HeaderText = "[Measures].[Internet Revenue Status]";
            this.fieldStatus.ToolTips.ValueText = "[Measures].[Internet Revenue Status]";
            // 
            // pivotGridField5
            // 
            this.pivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField5.AreaIndex = 2;
            this.pivotGridField5.Caption = "Fiscal Quarter";
            this.pivotGridField5.FieldName = "[Date].[Fiscal].[Fiscal Quarter]";
            this.pivotGridField5.Name = "pivotGridField5";
            // 
            // pivotGridField4
            // 
            this.pivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField4.AreaIndex = 1;
            this.pivotGridField4.Caption = "Fiscal Semester";
            this.pivotGridField4.FieldName = "[Date].[Fiscal].[Fiscal Semester]";
            this.pivotGridField4.Name = "pivotGridField4";
            // 
            // pivotGridField3
            // 
            this.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField3.AreaIndex = 0;
            this.pivotGridField3.Caption = "Fiscal Year";
            this.pivotGridField3.FieldName = "[Date].[Fiscal].[Fiscal Year]";
            this.pivotGridField3.Name = "pivotGridField3";
            // 
            // pivotGridField2
            // 
            this.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField2.AreaIndex = 1;
            this.pivotGridField2.Caption = "Goal";
            this.pivotGridField2.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pivotGridField2.FieldName = "[Measures].[Internet Revenue Goal]";
            this.pivotGridField2.Name = "pivotGridField2";
            this.pivotGridField2.ToolTips.HeaderText = "[Measures].[Internet Revenue Goal]";
            this.pivotGridField2.ToolTips.ValueText = "[Measures].[Internet Revenue Goal]";
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField1.AreaIndex = 0;
            this.pivotGridField1.Caption = "Internet Revenue";
            this.pivotGridField1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pivotGridField1.FieldName = "[Measures].[Internet Sales Amount]";
            this.pivotGridField1.Name = "pivotGridField1";
            this.pivotGridField1.ToolTips.HeaderText = "[Measures].[Internet Sales Amount]";
            this.pivotGridField1.ToolTips.ValueText = "[Measures].[Internet Sales Amount]";
            // 
            // pivotGridControl
            // 
            this.pivotGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pivotGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pivotGridField1,
            this.pivotGridField2,
            this.pivotGridField3,
            this.pivotGridField4,
            this.pivotGridField5,
            this.fieldStatus,
            this.fieldTrend});
            this.pivotGridControl.Location = new System.Drawing.Point(0, 51);
            this.pivotGridControl.Name = "pivotGridControl";
            this.pivotGridControl.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.pivotGridControl.OptionsCustomization.CustomizationFormStyle = DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007;
            this.pivotGridControl.Size = new System.Drawing.Size(490, 419);
            this.pivotGridControl.TabIndex = 3;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.tabPane1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(490, 51);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(200, 419);
            this.sidePanel1.TabIndex = 18;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // tabPane1
            // 
            this.tabPane1.AllowCollapse = DevExpress.Utils.DefaultBoolean.Default;
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(1, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1});
            this.tabPane1.RegularSize = new System.Drawing.Size(199, 419);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(199, 419);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Options";
            this.tabNavigationPage1.Controls.Add(this.layoutControl1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(199, 392);
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.ddlTrendGraphics);
            this.layoutControl1.Controls.Add(this.ddlStatusGraphics);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(885, 439, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(199, 392);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ddlTrendGraphics
            // 
            this.ddlTrendGraphics.EditValue = "";
            this.ddlTrendGraphics.Location = new System.Drawing.Point(90, 56);
            this.ddlTrendGraphics.Name = "ddlTrendGraphics";
            this.ddlTrendGraphics.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddlTrendGraphics.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ddlTrendGraphics.Size = new System.Drawing.Size(97, 20);
            this.ddlTrendGraphics.StyleController = this.layoutControl1;
            this.ddlTrendGraphics.TabIndex = 6;
            this.ddlTrendGraphics.SelectedIndexChanged += new System.EventHandler(this.cbTrendGraphic_SelectedIndexChanged);
            // 
            // ddlStatusGraphics
            // 
            this.ddlStatusGraphics.EditValue = "";
            this.ddlStatusGraphics.Location = new System.Drawing.Point(90, 32);
            this.ddlStatusGraphics.Name = "ddlStatusGraphics";
            this.ddlStatusGraphics.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddlStatusGraphics.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ddlStatusGraphics.Size = new System.Drawing.Size(97, 20);
            this.ddlStatusGraphics.StyleController = this.layoutControl1;
            this.ddlStatusGraphics.TabIndex = 4;
            this.ddlStatusGraphics.SelectedIndexChanged += new System.EventHandler(this.cbStatusGraphic_SelectedIndexChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(199, 392);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 88);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(199, 304);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(199, 88);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(199, 88);
            this.layoutControlGroup3.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup3.Text = "KPI Settings";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.ddlTrendGraphics;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(179, 24);
            this.layoutControlItem2.Text = "Trend graphics";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ddlStatusGraphics;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(179, 24);
            this.layoutControlItem1.Text = "Status Graphics";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(75, 13);
            // 
            // separator1
            // 
            this.separator1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.separator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.separator1.Location = new System.Drawing.Point(0, 43);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(690, 8);
            this.separator1.TabIndex = 16;
            // 
            // panelError
            // 
            this.panelError.Controls.Add(this.hyperLinkEdit1);
            this.panelError.Controls.Add(this.labelControl1);
            this.panelError.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelError.Location = new System.Drawing.Point(0, 0);
            this.panelError.Name = "panelError";
            this.panelError.Size = new System.Drawing.Size(690, 43);
            this.panelError.TabIndex = 17;
            // 
            // hyperLinkEdit1
            // 
            this.hyperLinkEdit1.EditValue = "http://www.microsoft.com/en-us/download/details.aspx?id=16978#ASOLEDB";
            this.hyperLinkEdit1.Location = new System.Drawing.Point(456, 18);
            this.hyperLinkEdit1.Name = "hyperLinkEdit1";
            this.hyperLinkEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.hyperLinkEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.hyperLinkEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.hyperLinkEdit1.Properties.Caption = "www.microsoft.com";
            this.hyperLinkEdit1.Size = new System.Drawing.Size(100, 18);
            this.hyperLinkEdit1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AutoEllipsis = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(12, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(663, 28);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "To run this demo, you should have Microsoft SQL Server Analysis Services OLE DB 8" +
    ".0 (or later) \r\ninstalled on your system. You can get the latest version of this" +
    " provider here:";
            // 
            // OLAPKPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pivotGridControl);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.separator1);
            this.Controls.Add(this.panelError);
            this.Name = "OLAPKPI";
            this.Size = new System.Drawing.Size(690, 470);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ddlTrendGraphics.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlStatusGraphics.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelError)).EndInit();
            this.panelError.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private DevExpress.XtraEditors.ComboBoxEdit ddlTrendGraphics;
		private DevExpress.XtraEditors.ComboBoxEdit ddlStatusGraphics;
		private PivotGridField fieldTrend;
		private PivotGridField fieldStatus;
		private PivotGridField pivotGridField5;
		private PivotGridField pivotGridField4;
		private PivotGridField pivotGridField3;
		private PivotGridField pivotGridField2;
		private PivotGridField pivotGridField1;
		private PivotGridControl pivotGridControl;
        private DevExpress.XtraEditors.PanelControl separator1;
        private DevExpress.XtraEditors.PanelControl panelError;
        private DevExpress.XtraEditors.HyperLinkEdit hyperLinkEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraEditors.SidePanel sidePanel1;
        private XtraBars.Navigation.TabPane tabPane1;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.LayoutControlGroup layoutControlGroup3;
    }
}
