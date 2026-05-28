namespace DevExpress.XtraPivotGrid.Demos.Modules {
	partial class OLAP {
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.sbConnect = new DevExpress.XtraEditors.SimpleButton();
            this.beServer = new DevExpress.XtraEditors.ButtonEdit();
            this.cbeDatabase = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbeCube = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciServer = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDataBase = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCube = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.pivotGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.mainPanel = new DevExpress.XtraEditors.PanelControl();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.panelError = new DevExpress.XtraEditors.PanelControl();
            this.hyperLinkEdit1 = new DevExpress.XtraEditors.HyperLinkEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeCube.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelError)).BeginInit();
            this.panelError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.radioGroup1);
            this.layoutControl1.Controls.Add(this.sbConnect);
            this.layoutControl1.Controls.Add(this.beServer);
            this.layoutControl1.Controls.Add(this.cbeDatabase);
            this.layoutControl1.Controls.Add(this.cbeCube);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1086, 439, 650, 397);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(199, 441);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // radioGroup1
            // 
            this.radioGroup1.AutoSizeInLayoutControl = true;
            this.radioGroup1.Location = new System.Drawing.Point(11, 11);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroup1.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroup1.Properties.Columns = 1;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Demo Data"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Analysis Server")});
            this.radioGroup1.Size = new System.Drawing.Size(177, 56);
            this.radioGroup1.StyleController = this.layoutControl1;
            this.radioGroup1.TabIndex = 0;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // sbConnect
            // 
            this.sbConnect.Location = new System.Drawing.Point(11, 191);
            this.sbConnect.Name = "sbConnect";
            this.sbConnect.Size = new System.Drawing.Size(177, 22);
            this.sbConnect.StyleController = this.layoutControl1;
            this.sbConnect.TabIndex = 8;
            this.sbConnect.Text = "Connect";
            this.sbConnect.Visible = false;
            this.sbConnect.Click += new System.EventHandler(this.sbConnect_Click);
            // 
            // beServer
            // 
            this.beServer.Location = new System.Drawing.Point(11, 87);
            this.beServer.Name = "beServer";
            this.beServer.Size = new System.Drawing.Size(177, 20);
            this.beServer.StyleController = this.layoutControl1;
            this.beServer.TabIndex = 5;
            // 
            // cbeDatabase
            // 
            this.cbeDatabase.Location = new System.Drawing.Point(11, 127);
            this.cbeDatabase.Name = "cbeDatabase";
            this.cbeDatabase.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeDatabase.Size = new System.Drawing.Size(177, 20);
            this.cbeDatabase.StyleController = this.layoutControl1;
            this.cbeDatabase.TabIndex = 6;
            this.cbeDatabase.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.cbeDatabase_QueryPopUp);
            // 
            // cbeCube
            // 
            this.cbeCube.Location = new System.Drawing.Point(11, 167);
            this.cbeCube.Name = "cbeCube";
            this.cbeCube.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeCube.Size = new System.Drawing.Size(177, 20);
            this.cbeCube.StyleController = this.layoutControl1;
            this.cbeCube.TabIndex = 7;
            this.cbeCube.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.cbeCube_QueryPopUp);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(9, 9, 9, 9);
            this.layoutControlGroup1.Size = new System.Drawing.Size(199, 441);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 206);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(181, 217);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.lciServer,
            this.lciDataBase,
            this.lciCube,
            this.layoutControlItem6});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(181, 206);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.radioGroup1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(181, 60);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // lciServer
            // 
            this.lciServer.Control = this.beServer;
            this.lciServer.Location = new System.Drawing.Point(0, 60);
            this.lciServer.Name = "lceServer";
            this.lciServer.Size = new System.Drawing.Size(181, 40);
            this.lciServer.Text = "Server";
            this.lciServer.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciServer.TextSize = new System.Drawing.Size(46, 13);
            this.lciServer.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lciDataBase
            // 
            this.lciDataBase.Control = this.cbeDatabase;
            this.lciDataBase.Location = new System.Drawing.Point(0, 100);
            this.lciDataBase.Name = "lciDataBase";
            this.lciDataBase.Size = new System.Drawing.Size(181, 40);
            this.lciDataBase.Text = "Database";
            this.lciDataBase.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciDataBase.TextSize = new System.Drawing.Size(46, 13);
            this.lciDataBase.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lciCube
            // 
            this.lciCube.Control = this.cbeCube;
            this.lciCube.Location = new System.Drawing.Point(0, 140);
            this.lciCube.Name = "lciCube";
            this.lciCube.Size = new System.Drawing.Size(181, 40);
            this.lciCube.Text = "Cube";
            this.lciCube.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciCube.TextSize = new System.Drawing.Size(46, 13);
            this.lciCube.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.sbConnect;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 180);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(181, 26);
            this.layoutControlItem6.Text = "Connect";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            this.layoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // pivotGridControl
            // 
            this.pivotGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pivotGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl.Location = new System.Drawing.Point(255, 0);
            this.pivotGridControl.Name = "pivotGridControl";
            this.pivotGridControl.OptionsBehavior.UseAsyncMode = true;
            this.pivotGridControl.OptionsCustomization.AllowFilterInCustomizationForm = true;
            this.pivotGridControl.OptionsCustomization.AllowSortInCustomizationForm = true;
            this.pivotGridControl.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.pivotGridControl.OptionsCustomization.CustomizationFormStyle = DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007;
            this.pivotGridControl.OptionsDataField.RowHeaderWidth = 75;
            this.pivotGridControl.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.pivotGridControl.OptionsView.RowTotalsLocation = DevExpress.XtraPivotGrid.PivotRowTotalsLocation.Tree;
            this.pivotGridControl.OptionsView.RowTreeOffset = 16;
            this.pivotGridControl.OptionsView.RowTreeWidth = 75;
            this.pivotGridControl.OptionsView.ShowColumnHeaders = false;
            this.pivotGridControl.OptionsView.ShowDataHeaders = false;
            this.pivotGridControl.OptionsView.ShowFilterHeaders = false;
            this.pivotGridControl.OptionsView.ShowRowHeaders = false;
            this.pivotGridControl.OptionsView.ShowTotalsForSingleValues = true;
            this.pivotGridControl.Size = new System.Drawing.Size(235, 427);
            this.pivotGridControl.TabIndex = 2;
            this.pivotGridControl.ShowingCustomizationForm += new DevExpress.XtraPivotGrid.CustomizationFormShowingEventHandler(this.pivotGridControl_ShowingCustomizationForm);
            this.pivotGridControl.PopupMenuShowing += new DevExpress.XtraPivotGrid.PopupMenuShowingEventHandler(this.pivotGridControl_PopupMenuShowing);
            this.pivotGridControl.FieldValueNotExpanded += new DevExpress.XtraPivotGrid.PivotFieldValueEventHandler(this.pivotGridControl_FieldValueNotExpanded);
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mainPanel.Controls.Add(this.pivotGridControl);
            this.mainPanel.Controls.Add(this.sidePanel2);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 43);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(490, 427);
            this.mainPanel.TabIndex = 7;
            // 
            // sidePanel2
            // 
            this.sidePanel2.AllowSnap = false;
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel2.Location = new System.Drawing.Point(0, 0);
            this.sidePanel2.Margin = new System.Windows.Forms.Padding(2);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(255, 427);
            this.sidePanel2.TabIndex = 0;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // panelError
            // 
            this.panelError.Controls.Add(this.hyperLinkEdit1);
            this.panelError.Controls.Add(this.labelControl1);
            this.panelError.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelError.Location = new System.Drawing.Point(0, 0);
            this.panelError.Name = "panelError";
            this.panelError.Size = new System.Drawing.Size(490, 43);
            this.panelError.TabIndex = 15;
            // 
            // hyperLinkEdit1
            // 
            this.hyperLinkEdit1.EditValue = "https://docs.microsoft.com/en-gb/analysis-services/instances/data-providers-used-for-analysis-services-connections?view=sql-server-2017";
            this.hyperLinkEdit1.Location = new System.Drawing.Point(280, 19);
            this.hyperLinkEdit1.Name = "hyperLinkEdit1";
            this.hyperLinkEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.hyperLinkEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.hyperLinkEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.hyperLinkEdit1.Properties.Caption = "Analysis Services client libraries";
            this.hyperLinkEdit1.Size = new System.Drawing.Size(250, 18);
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
            this.labelControl1.Location = new System.Drawing.Point(12, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(463, 28);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "To run this demo, you should have data providers used for Analysis Services conne" +
    "ctions installed on your system.\r\nYou can find a list of supported providers her" +
    "e:";
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.tabPane1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(490, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(200, 470);
            this.sidePanel1.TabIndex = 3;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(1, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1});
            this.tabPane1.RegularSize = new System.Drawing.Size(199, 470);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(199, 470);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Options";
            this.tabNavigationPage1.Controls.Add(this.layoutControl1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(199, 441);
            // 
            // toolTipController1
            // 
            this.toolTipController1.Rounded = true;
            this.toolTipController1.ToolTipLocation = DevExpress.Utils.ToolTipLocation.LeftCenter;
            // 
            // OLAP
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panelError);
            this.Controls.Add(this.sidePanel1);
            this.Name = "OLAP";
            this.Size = new System.Drawing.Size(690, 470);
            this.Load += new System.EventHandler(this.OLAP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeCube.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.mainPanel.ResumeLayout(false);
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
        private PivotGridControl pivotGridControl;
		private DevExpress.XtraEditors.PanelControl mainPanel;
        private DevExpress.XtraEditors.PanelControl panelError;
        private DevExpress.XtraEditors.HyperLinkEdit hyperLinkEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraEditors.SidePanel sidePanel1;
        private XtraBars.Navigation.TabPane tabPane1;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraEditors.SidePanel sidePanel2;
        private XtraEditors.RadioGroup radioGroup1;
        private XtraEditors.SimpleButton sbConnect;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem lciServer;
        private XtraLayout.LayoutControlItem lciDataBase;
        private XtraLayout.LayoutControlItem lciCube;
        private XtraLayout.LayoutControlItem layoutControlItem6;
        private XtraEditors.ButtonEdit beServer;
        private XtraEditors.ComboBoxEdit cbeDatabase;
        private XtraEditors.ComboBoxEdit cbeCube;
        private DevExpress.Utils.ToolTipController toolTipController1;
    }
}
