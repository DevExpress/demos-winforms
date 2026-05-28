namespace DevExpress.XtraPivotGrid.Demos.Modules {
	partial class OlapCustomTotals {
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
            this.components = new System.ComponentModel.Container();
            this.totalsListBox = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.controlPanellayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.mainPanel = new DevExpress.XtraEditors.PanelControl();
            this.pivotGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.paddingPanel = new DevExpress.XtraEditors.PanelControl();
            this.separator1 = new DevExpress.XtraEditors.PanelControl();
            this.panelError = new DevExpress.XtraEditors.PanelControl();
            this.hyperLinkEdit1 = new DevExpress.XtraEditors.HyperLinkEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.totalsListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlPanellayoutControl1ConvertedLayout)).BeginInit();
            this.controlPanellayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddingPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelError)).BeginInit();
            this.panelError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalsListBox
            // 
            this.totalsListBox.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.totalsListBox.CheckOnClick = true;
            this.totalsListBox.ColumnWidth = 100;
            this.totalsListBox.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.totalsListBox.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Average", System.Windows.Forms.CheckState.Checked),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Count", System.Windows.Forms.CheckState.Checked),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Max"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Min"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("StdDev"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("StdDevp"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Sum"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Var"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Varp")});
            this.totalsListBox.Location = new System.Drawing.Point(12, 32);
            this.totalsListBox.Name = "totalsListBox";
            this.totalsListBox.Size = new System.Drawing.Size(175, 268);
            this.totalsListBox.StyleController = null;
            this.totalsListBox.TabIndex = 0;
            this.totalsListBox.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.chListBox_ItemCheck);
            // 
            // controlPanellayoutControl1ConvertedLayout
            // 
            this.controlPanellayoutControl1ConvertedLayout.AllowCustomization = false;
            this.controlPanellayoutControl1ConvertedLayout.Controls.Add(this.totalsListBox);
            this.controlPanellayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanellayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.controlPanellayoutControl1ConvertedLayout.Name = "controlPanellayoutControl1ConvertedLayout";
            this.controlPanellayoutControl1ConvertedLayout.Padding = new System.Windows.Forms.Padding(9);
            this.controlPanellayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.controlPanellayoutControl1ConvertedLayout.Size = new System.Drawing.Size(199, 312);
            this.controlPanellayoutControl1ConvertedLayout.TabIndex = 12;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(9, 9, 9, 9);
            this.layoutControlGroup1.Size = new System.Drawing.Size(199, 312);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(199, 312);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Text = "Show Custom Totals";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.totalsListBox;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(179, 272);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mainPanel.Controls.Add(this.pivotGridControl);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 61);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(500, 339);
            this.mainPanel.TabIndex = 9;
            // 
            // pivotGridControl
            // 
            this.pivotGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl.Name = "pivotGridControl";
            this.pivotGridControl.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.pivotGridControl.Size = new System.Drawing.Size(500, 339);
            this.pivotGridControl.TabIndex = 6;
            // 
            // paddingPanel
            // 
            this.paddingPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.paddingPanel.Location = new System.Drawing.Point(0, 53);
            this.paddingPanel.Name = "paddingPanel";
            this.paddingPanel.Size = new System.Drawing.Size(700, 8);
            this.paddingPanel.TabIndex = 8;
            // 
            // separator1
            // 
            this.separator1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.separator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.separator1.Location = new System.Drawing.Point(0, 45);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(700, 8);
            this.separator1.TabIndex = 10;
            // 
            // panelError
            // 
            this.panelError.Controls.Add(this.hyperLinkEdit1);
            this.panelError.Controls.Add(this.labelControl2);
            this.panelError.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelError.Location = new System.Drawing.Point(0, 0);
            this.panelError.Name = "panelError";
            this.panelError.Size = new System.Drawing.Size(700, 45);
            this.panelError.TabIndex = 11;
            // 
            // hyperLinkEdit1
            // 
            this.hyperLinkEdit1.EditValue = "http://www.microsoft.com/en-us/download/details.aspx?id=16978#ASOLEDB";
            this.hyperLinkEdit1.Location = new System.Drawing.Point(456, 20);
            this.hyperLinkEdit1.Name = "hyperLinkEdit1";
            this.hyperLinkEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.hyperLinkEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.hyperLinkEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.hyperLinkEdit1.Properties.Caption = "www.microsoft.com";
            this.hyperLinkEdit1.Size = new System.Drawing.Size(100, 18);
            this.hyperLinkEdit1.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.AutoEllipsis = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(14, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(673, 28);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "To run this demo, you should have Microsoft SQL Server Analysis Services OLE DB 8" +
    ".0 (or later) \r\ninstalled on your system. You can get the latest version of this" +
    " provider here:";
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.tabPane1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(500, 61);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(200, 339);
            this.sidePanel1.TabIndex = 7;
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
            this.tabPane1.RegularSize = new System.Drawing.Size(199, 339);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(199, 339);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Options";
            this.tabNavigationPage1.Controls.Add(this.controlPanellayoutControl1ConvertedLayout);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(199, 312);
            // 
            // OlapCustomTotals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.paddingPanel);
            this.Controls.Add(this.separator1);
            this.Controls.Add(this.panelError);
            this.Name = "OlapCustomTotals";
            this.Size = new System.Drawing.Size(700, 400);
            ((System.ComponentModel.ISupportInitialize)(this.totalsListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlPanellayoutControl1ConvertedLayout)).EndInit();
            this.controlPanellayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddingPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelError)).EndInit();
            this.panelError.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private DevExpress.XtraEditors.PanelControl mainPanel;
		private DevExpress.XtraEditors.PanelControl paddingPanel;
        private DevExpress.XtraEditors.CheckedListBoxControl totalsListBox;
		private PivotGridControl pivotGridControl;
        private DevExpress.XtraEditors.PanelControl separator1;
        private DevExpress.XtraEditors.PanelControl panelError;
        private DevExpress.XtraEditors.HyperLinkEdit hyperLinkEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private XtraEditors.SidePanel sidePanel1;
        private XtraBars.Navigation.TabPane tabPane1;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private XtraLayout.LayoutControl controlPanellayoutControl1ConvertedLayout;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.Converter.LayoutConverter layoutConverter1;
        private XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
