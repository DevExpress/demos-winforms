using DevExpress.XtraEditors;

namespace DevExpress.XtraGantt.Demos
{
    partial class MarketResearchSchedule
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ganttControl1 = new DevExpress.XtraGantt.GanttControl();
            this.ganttColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ganttColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ganttColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.tePageCaption = new DevExpress.XtraEditors.TextEdit();
            this.cePrintAllNodes = new DevExpress.XtraEditors.CheckEdit();
            this.deChartFinishDate = new DevExpress.XtraEditors.DateEdit();
            this.deChartStartDate = new DevExpress.XtraEditors.DateEdit();
            this.icePaperKind = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.iceOrientation = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.icePageInfoType = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.cePrintPageInfo = new DevExpress.XtraEditors.CheckEdit();
            this.cePrintLegend = new DevExpress.XtraEditors.CheckEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciPrintLegend = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPrintPageInfo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPageInfoType = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciChartStartDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciChartFinishDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPrintAllNodes = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcePageCaption = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciOrientation = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPaperKind = new DevExpress.XtraLayout.LayoutControlItem();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.ganttControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tePageCaption.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cePrintAllNodes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deChartFinishDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deChartFinishDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deChartStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deChartStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icePaperKind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iceOrientation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icePageInfoType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cePrintPageInfo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cePrintLegend.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPrintLegend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPrintPageInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPageInfoType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciChartStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciChartFinishDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPrintAllNodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcePageCaption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOrientation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPaperKind)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ganttControl1
            // 
            this.ganttControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ganttControl1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.ganttColumn1,
            this.ganttColumn2,
            this.ganttColumn3});
            this.ganttControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ganttControl1.Location = new System.Drawing.Point(0, 0);
            this.ganttControl1.Name = "ganttControl1";
            this.ganttControl1.OptionsPrint.PrintAllNodes = true;
            this.ganttControl1.OptionsPrint.PrintLegend = DevExpress.Utils.DefaultBoolean.True;
            this.ganttControl1.OptionsPrint.PrintPageInfo = DevExpress.Utils.DefaultBoolean.True;
            this.ganttControl1.OptionsPrint.ShowPrintExportProgress = true;
            this.ganttControl1.Size = new System.Drawing.Size(612, 457);
            this.ganttControl1.SplitterPosition = 400;
            this.ganttControl1.TabIndex = 1;
            // 
            // ganttColumn1
            // 
            this.ganttColumn1.Caption = "Name";
            this.ganttColumn1.FieldName = "Name";
            this.ganttColumn1.Name = "ganttColumn1";
            this.ganttColumn1.Visible = true;
            this.ganttColumn1.VisibleIndex = 0;
            this.ganttColumn1.Width = 263;
            // 
            // ganttColumn2
            // 
            this.ganttColumn2.Caption = "Start Date";
            this.ganttColumn2.FieldName = "StartDate";
            this.ganttColumn2.Name = "ganttColumn2";
            this.ganttColumn2.Visible = true;
            this.ganttColumn2.VisibleIndex = 1;
            this.ganttColumn2.Width = 66;
            // 
            // ganttColumn3
            // 
            this.ganttColumn3.Caption = "Finish Date";
            this.ganttColumn3.FieldName = "FinishDate";
            this.ganttColumn3.Name = "ganttColumn3";
            this.ganttColumn3.Visible = true;
            this.ganttColumn3.VisibleIndex = 2;
            this.ganttColumn3.Width = 71;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tePageCaption);
            this.layoutControl1.Controls.Add(this.cePrintAllNodes);
            this.layoutControl1.Controls.Add(this.deChartFinishDate);
            this.layoutControl1.Controls.Add(this.deChartStartDate);
            this.layoutControl1.Controls.Add(this.icePaperKind);
            this.layoutControl1.Controls.Add(this.iceOrientation);
            this.layoutControl1.Controls.Add(this.icePageInfoType);
            this.layoutControl1.Controls.Add(this.cePrintPageInfo);
            this.layoutControl1.Controls.Add(this.cePrintLegend);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(861, 138, 899, 521);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(207, 424);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tePageCaption
            // 
            this.tePageCaption.Location = new System.Drawing.Point(12, 162);
            this.tePageCaption.Name = "tePageCaption";
            this.tePageCaption.Size = new System.Drawing.Size(183, 20);
            this.tePageCaption.StyleController = this.layoutControl1;
            this.tePageCaption.TabIndex = 12;
            this.tePageCaption.EditValueChanged += new System.EventHandler(this.tePageCaption_EditValueChanged);
            // 
            // cePrintAllNodes
            // 
            this.cePrintAllNodes.Location = new System.Drawing.Point(12, 34);
            this.cePrintAllNodes.Name = "cePrintAllNodes";
            this.cePrintAllNodes.Properties.Caption = "Print All Nodes";
            this.cePrintAllNodes.Size = new System.Drawing.Size(183, 20);
            this.cePrintAllNodes.StyleController = this.layoutControl1;
            this.cePrintAllNodes.TabIndex = 11;
            this.cePrintAllNodes.CheckedChanged += new System.EventHandler(this.cePrintAllNodes_CheckedChanged);
            // 
            // deChartFinishDate
            // 
            this.deChartFinishDate.EditValue = null;
            this.deChartFinishDate.Location = new System.Drawing.Point(12, 242);
            this.deChartFinishDate.Name = "deChartFinishDate";
            this.deChartFinishDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deChartFinishDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deChartFinishDate.Size = new System.Drawing.Size(183, 20);
            this.deChartFinishDate.StyleController = this.layoutControl1;
            this.deChartFinishDate.TabIndex = 10;
            this.deChartFinishDate.EditValueChanged += new System.EventHandler(this.deChartFinishDate_EditValueChanged);
            // 
            // deChartStartDate
            // 
            this.deChartStartDate.EditValue = null;
            this.deChartStartDate.Location = new System.Drawing.Point(12, 202);
            this.deChartStartDate.Name = "deChartStartDate";
            this.deChartStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deChartStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deChartStartDate.Size = new System.Drawing.Size(183, 20);
            this.deChartStartDate.StyleController = this.layoutControl1;
            this.deChartStartDate.TabIndex = 9;
            this.deChartStartDate.EditValueChanged += new System.EventHandler(this.deChartStartDate_EditValueChanged);
            // 
            // icePaperKind
            // 
            this.icePaperKind.Location = new System.Drawing.Point(12, 364);
            this.icePaperKind.Name = "icePaperKind";
            this.icePaperKind.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icePaperKind.Size = new System.Drawing.Size(183, 20);
            this.icePaperKind.StyleController = this.layoutControl1;
            this.icePaperKind.TabIndex = 8;
            // 
            // iceOrientation
            // 
            this.iceOrientation.Location = new System.Drawing.Point(12, 324);
            this.iceOrientation.Name = "iceOrientation";
            this.iceOrientation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.iceOrientation.Size = new System.Drawing.Size(183, 20);
            this.iceOrientation.StyleController = this.layoutControl1;
            this.iceOrientation.TabIndex = 7;
            // 
            // icePageInfoType
            // 
            this.icePageInfoType.Location = new System.Drawing.Point(12, 122);
            this.icePageInfoType.Name = "icePageInfoType";
            this.icePageInfoType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icePageInfoType.Size = new System.Drawing.Size(183, 20);
            this.icePageInfoType.StyleController = this.layoutControl1;
            this.icePageInfoType.TabIndex = 6;
            this.icePageInfoType.SelectedIndexChanged += new System.EventHandler(this.icePageInfoType_SelectedIndexChanged);
            // 
            // cePrintPageInfo
            // 
            this.cePrintPageInfo.Location = new System.Drawing.Point(12, 82);
            this.cePrintPageInfo.Name = "cePrintPageInfo";
            this.cePrintPageInfo.Properties.Caption = "Print Page Info";
            this.cePrintPageInfo.Size = new System.Drawing.Size(183, 20);
            this.cePrintPageInfo.StyleController = this.layoutControl1;
            this.cePrintPageInfo.TabIndex = 5;
            this.cePrintPageInfo.CheckedChanged += new System.EventHandler(this.cePrintPageInfo_CheckedChanged);
            // 
            // cePrintLegend
            // 
            this.cePrintLegend.Location = new System.Drawing.Point(12, 58);
            this.cePrintLegend.Name = "cePrintLegend";
            this.cePrintLegend.Properties.Caption = "Print Legend";
            this.cePrintLegend.Size = new System.Drawing.Size(183, 20);
            this.cePrintLegend.StyleController = this.layoutControl1;
            this.cePrintLegend.TabIndex = 4;
            this.cePrintLegend.CheckedChanged += new System.EventHandler(this.cePrintLegend_CheckedChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlGroup1,
            this.layoutControlGroup2});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(207, 424);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 396);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(207, 28);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciPrintLegend,
            this.lciPrintPageInfo,
            this.lciPageInfoType,
            this.lciChartStartDate,
            this.lciChartFinishDate,
            this.lciPrintAllNodes,
            this.lcePageCaption});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(207, 274);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "Options";
            // 
            // lciPrintLegend
            // 
            this.lciPrintLegend.Control = this.cePrintLegend;
            this.lciPrintLegend.CustomizationFormText = "Print Legend";
            this.lciPrintLegend.Location = new System.Drawing.Point(0, 24);
            this.lciPrintLegend.Name = "lciPrintLegend";
            this.lciPrintLegend.Size = new System.Drawing.Size(187, 24);
            this.lciPrintLegend.TextVisible = false;
            // 
            // lciPrintPageInfo
            // 
            this.lciPrintPageInfo.Control = this.cePrintPageInfo;
            this.lciPrintPageInfo.CustomizationFormText = "Print Page Info";
            this.lciPrintPageInfo.Location = new System.Drawing.Point(0, 48);
            this.lciPrintPageInfo.Name = "lciPrintPageInfo";
            this.lciPrintPageInfo.Size = new System.Drawing.Size(187, 24);
            this.lciPrintPageInfo.TextVisible = false;
            // 
            // lciPageInfoType
            // 
            this.lciPageInfoType.Control = this.icePageInfoType;
            this.lciPageInfoType.Location = new System.Drawing.Point(0, 72);
            this.lciPageInfoType.Name = "lciPageInfoType";
            this.lciPageInfoType.Size = new System.Drawing.Size(187, 40);
            this.lciPageInfoType.Text = "Page Info Type";
            this.lciPageInfoType.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciPageInfoType.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciChartStartDate
            // 
            this.lciChartStartDate.Control = this.deChartStartDate;
            this.lciChartStartDate.Location = new System.Drawing.Point(0, 152);
            this.lciChartStartDate.Name = "lciChartStartDate";
            this.lciChartStartDate.Size = new System.Drawing.Size(187, 40);
            this.lciChartStartDate.Text = "Chart Start Date";
            this.lciChartStartDate.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciChartStartDate.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciChartFinishDate
            // 
            this.lciChartFinishDate.Control = this.deChartFinishDate;
            this.lciChartFinishDate.Location = new System.Drawing.Point(0, 192);
            this.lciChartFinishDate.Name = "lciChartFinishDate";
            this.lciChartFinishDate.Size = new System.Drawing.Size(187, 40);
            this.lciChartFinishDate.Text = "Chart Finish Date";
            this.lciChartFinishDate.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciChartFinishDate.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciPrintAllNodes
            // 
            this.lciPrintAllNodes.Control = this.cePrintAllNodes;
            this.lciPrintAllNodes.Location = new System.Drawing.Point(0, 0);
            this.lciPrintAllNodes.Name = "lciPrintAllNodes";
            this.lciPrintAllNodes.Size = new System.Drawing.Size(187, 24);
            this.lciPrintAllNodes.TextVisible = false;
            // 
            // lcePageCaption
            // 
            this.lcePageCaption.Control = this.tePageCaption;
            this.lcePageCaption.Location = new System.Drawing.Point(0, 112);
            this.lcePageCaption.Name = "lcePageCaption";
            this.lcePageCaption.Size = new System.Drawing.Size(187, 40);
            this.lcePageCaption.Text = "Page Info Caption";
            this.lcePageCaption.TextLocation = DevExpress.Utils.Locations.Top;
            this.lcePageCaption.TextSize = new System.Drawing.Size(87, 13);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciOrientation,
            this.lciPaperKind});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 274);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(207, 122);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Text = "Page Settings";
            // 
            // lciOrientation
            // 
            this.lciOrientation.Control = this.iceOrientation;
            this.lciOrientation.Location = new System.Drawing.Point(0, 0);
            this.lciOrientation.Name = "lciOrientation";
            this.lciOrientation.Size = new System.Drawing.Size(187, 40);
            this.lciOrientation.Text = "Orientation";
            this.lciOrientation.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciOrientation.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciPaperKind
            // 
            this.lciPaperKind.Control = this.icePaperKind;
            this.lciPaperKind.Location = new System.Drawing.Point(0, 40);
            this.lciPaperKind.Name = "lciPaperKind";
            this.lciPaperKind.Size = new System.Drawing.Size(187, 40);
            this.lciPaperKind.Text = "Paper Kind";
            this.lciPaperKind.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciPaperKind.TextSize = new System.Drawing.Size(87, 13);
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.tabPane1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(612, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(208, 457);
            this.sidePanel1.TabIndex = 2;
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
            this.tabPane1.RegularSize = new System.Drawing.Size(207, 457);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(207, 457);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Printing";
            this.tabNavigationPage1.Controls.Add(this.layoutControl1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(207, 424);
            // 
            // MarketResearchSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ganttControl1);
            this.Controls.Add(this.sidePanel1);
            this.Name = "MarketResearchSchedule";
            this.Size = new System.Drawing.Size(820, 457);
            ((System.ComponentModel.ISupportInitialize)(this.ganttControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tePageCaption.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cePrintAllNodes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deChartFinishDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deChartFinishDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deChartStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deChartStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icePaperKind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iceOrientation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icePageInfoType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cePrintPageInfo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cePrintLegend.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPrintLegend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPrintPageInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPageInfoType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciChartStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciChartFinishDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPrintAllNodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcePageCaption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOrientation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPaperKind)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GanttControl ganttControl1;
        private XtraTreeList.Columns.TreeListColumn ganttColumn1;
        private XtraTreeList.Columns.TreeListColumn ganttColumn2;
        private XtraTreeList.Columns.TreeListColumn ganttColumn3;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraEditors.ImageComboBoxEdit icePageInfoType;
        private XtraEditors.CheckEdit cePrintPageInfo;
        private XtraEditors.CheckEdit cePrintLegend;
        private XtraLayout.LayoutControlItem lciPrintLegend;
        private XtraLayout.LayoutControlItem lciPrintPageInfo;
        private XtraLayout.LayoutControlItem lciPageInfoType;
        private ImageComboBoxEdit iceOrientation;
        private XtraLayout.LayoutControlItem lciOrientation;
        private XtraEditors.ImageComboBoxEdit icePaperKind;
        private XtraLayout.LayoutControlItem lciPaperKind;
        private XtraEditors.DateEdit deChartFinishDate;
        private XtraEditors.DateEdit deChartStartDate;
        private XtraLayout.LayoutControlItem lciChartStartDate;
        private XtraLayout.LayoutControlItem lciChartFinishDate;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private CheckEdit cePrintAllNodes;
        private XtraLayout.LayoutControlItem lciPrintAllNodes;
        private TextEdit tePageCaption;
        private XtraLayout.LayoutControlItem lcePageCaption;
        private SidePanel sidePanel1;
        private XtraBars.Navigation.TabPane tabPane1;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
    }
}
