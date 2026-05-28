using DevExpress.Utils;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraGantt.Options;
using DevExpress.XtraLayout;

namespace DevExpress.XtraGantt.Demos
{
    partial class StartupPlan
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
            this.taskNameColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.startDateColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.finishDateColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.resourcesColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.baselineStartColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.baselineFinishColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ceAllowSplitTasks = new DevExpress.XtraEditors.CheckEdit();
            this.meLog = new DevExpress.XtraRichEdit.RichEditControl();
            this.btnClearLog = new DevExpress.XtraEditors.SimpleButton();
            this.ceEnableTracing = new DevExpress.XtraEditors.CheckEdit();
            this.ceShowBaseLines = new DevExpress.XtraEditors.CheckEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgOptions = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgTracing = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.ganttControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowSplitTasks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceEnableTracing.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowBaseLines.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgTracing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
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
            this.taskNameColumn,
            this.startDateColumn,
            this.finishDateColumn,
            this.resourcesColumn,
            this.baselineStartColumn,
            this.baselineFinishColumn});
            this.ganttControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ganttControl1.Location = new System.Drawing.Point(0, 0);
            this.ganttControl1.Name = "ganttControl1";
            this.ganttControl1.OptionsBehavior.ScheduleMode = DevExpress.XtraGantt.Options.ScheduleMode.Auto;
            this.ganttControl1.OptionsCustomization.AllowModifyDependencies = DevExpress.Utils.DefaultBoolean.True;
            this.ganttControl1.OptionsCustomization.AllowModifyProgress = DevExpress.Utils.DefaultBoolean.True;
            this.ganttControl1.OptionsCustomization.AllowModifyTasks = DevExpress.Utils.DefaultBoolean.True;
            this.ganttControl1.OptionsPrint.ShowPrintExportProgress = true;
            this.ganttControl1.Size = new System.Drawing.Size(608, 464);
            this.ganttControl1.SplitterPosition = 400;
            this.ganttControl1.TabIndex = 0;
            // 
            // taskNameColumn
            // 
            this.taskNameColumn.Caption = "Task Name";
            this.taskNameColumn.FieldName = "Name";
            this.taskNameColumn.MinWidth = 50;
            this.taskNameColumn.Name = "taskNameColumn";
            this.taskNameColumn.Visible = true;
            this.taskNameColumn.VisibleIndex = 0;
            this.taskNameColumn.Width = 55;
            // 
            // startDateColumn
            // 
            this.startDateColumn.Caption = "Start Date";
            this.startDateColumn.FieldName = "StartDate";
            this.startDateColumn.MinWidth = 30;
            this.startDateColumn.Name = "startDateColumn";
            this.startDateColumn.Visible = true;
            this.startDateColumn.VisibleIndex = 1;
            this.startDateColumn.Width = 35;
            // 
            // finishDateColumn
            // 
            this.finishDateColumn.Caption = "Finish Date";
            this.finishDateColumn.FieldName = "FinishDate";
            this.finishDateColumn.MinWidth = 30;
            this.finishDateColumn.Name = "finishDateColumn";
            this.finishDateColumn.Visible = true;
            this.finishDateColumn.VisibleIndex = 2;
            this.finishDateColumn.Width = 50;
            // 
            // resourcesColumn
            // 
            this.resourcesColumn.Caption = "Resources";
            this.resourcesColumn.FieldName = "Resources";
            this.resourcesColumn.MinWidth = 30;
            this.resourcesColumn.Name = "resourcesColumn";
            this.resourcesColumn.Visible = true;
            this.resourcesColumn.VisibleIndex = 3;
            this.resourcesColumn.Width = 60;
            // 
            // baselineStartColumn
            // 
            this.baselineStartColumn.Caption = "Baseline Start";
            this.baselineStartColumn.FieldName = "BaselineStartDate";
            this.baselineStartColumn.Name = "baselineStartColumn";
            // 
            // baselineFinishColumn
            // 
            this.baselineFinishColumn.Caption = "Baseline Finish";
            this.baselineFinishColumn.FieldName = "BaselineFinishDate";
            this.baselineFinishColumn.Name = "baselineFinishColumn";
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.ceAllowSplitTasks);
            this.layoutControl1.Controls.Add(this.meLog);
            this.layoutControl1.Controls.Add(this.btnClearLog);
            this.layoutControl1.Controls.Add(this.ceEnableTracing);
            this.layoutControl1.Controls.Add(this.ceShowBaseLines);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(790, 185, 876, 498);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(278, 431);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ceAllowSplitTasks
            // 
            this.ceAllowSplitTasks.Location = new System.Drawing.Point(12, 58);
            this.ceAllowSplitTasks.Name = "ceAllowSplitTasks";
            this.ceAllowSplitTasks.Properties.Caption = "Allow Split Tasks";
            this.ceAllowSplitTasks.Size = new System.Drawing.Size(254, 20);
            this.ceAllowSplitTasks.StyleController = this.layoutControl1;
            this.ceAllowSplitTasks.TabIndex = 9;
            this.ceAllowSplitTasks.CheckedChanged += new System.EventHandler(this.ceAllowSplitTasks_CheckedChanged);
            // 
            // meLog
            // 
            this.meLog.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.meLog.Appearance.Text.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meLog.Appearance.Text.Options.UseFont = true;
            this.meLog.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.meLog.Location = new System.Drawing.Point(12, 148);
            this.meLog.Name = "meLog";
            this.meLog.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.meLog.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.meLog.ReadOnly = true;
            this.meLog.ShowCaretInReadOnly = false;
            this.meLog.Size = new System.Drawing.Size(254, 245);
            this.meLog.TabIndex = 8;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(12, 397);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(254, 22);
            this.btnClearLog.StyleController = this.layoutControl1;
            this.btnClearLog.TabIndex = 7;
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // ceEnableTracing
            // 
            this.ceEnableTracing.EditValue = true;
            this.ceEnableTracing.Location = new System.Drawing.Point(12, 124);
            this.ceEnableTracing.Name = "ceEnableTracing";
            this.ceEnableTracing.Properties.Caption = "Enable Tracing";
            this.ceEnableTracing.Size = new System.Drawing.Size(254, 20);
            this.ceEnableTracing.StyleController = this.layoutControl1;
            this.ceEnableTracing.TabIndex = 6;
            this.ceEnableTracing.CheckedChanged += new System.EventHandler(this.ceEnableTracing_CheckedChanged);
            // 
            // ceShowBaseLines
            // 
            this.ceShowBaseLines.Location = new System.Drawing.Point(12, 34);
            this.ceShowBaseLines.Name = "ceShowBaseLines";
            this.ceShowBaseLines.Properties.Caption = "Show BaseLines";
            this.ceShowBaseLines.Size = new System.Drawing.Size(254, 20);
            this.ceShowBaseLines.StyleController = this.layoutControl1;
            this.ceShowBaseLines.TabIndex = 4;
            this.ceShowBaseLines.CheckedChanged += new System.EventHandler(this.ceShowBaseLines_CheckedChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgOptions,
            this.lcgTracing});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(278, 431);
            this.Root.TextVisible = false;
            // 
            // lcgOptions
            // 
            this.lcgOptions.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.lcgOptions.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem5});
            this.lcgOptions.Location = new System.Drawing.Point(0, 0);
            this.lcgOptions.Name = "lcgOptions";
            this.lcgOptions.Size = new System.Drawing.Size(278, 90);
            this.lcgOptions.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgOptions.Text = "Options";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ceShowBaseLines;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(258, 24);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.ceAllowSplitTasks;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(258, 24);
            this.layoutControlItem5.TextVisible = false;
            // 
            // lcgTracing
            // 
            this.lcgTracing.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.lcgTracing.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.lcgTracing.Location = new System.Drawing.Point(0, 90);
            this.lcgTracing.Name = "lcgTracing";
            this.lcgTracing.Size = new System.Drawing.Size(278, 341);
            this.lcgTracing.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgTracing.Text = "Tracing";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.ceEnableTracing;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(258, 24);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnClearLog;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 273);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(258, 26);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.meLog;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(258, 249);
            this.layoutControlItem4.TextVisible = false;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.tabPane1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(608, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(279, 464);
            this.sidePanel1.TabIndex = 1;
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
            this.tabPane1.RegularSize = new System.Drawing.Size(278, 464);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(278, 464);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Options";
            this.tabNavigationPage1.Controls.Add(this.layoutControl1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(278, 431);
            // 
            // StartupPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ganttControl1);
            this.Controls.Add(this.sidePanel1);
            this.Name = "StartupPlan";
            this.Size = new System.Drawing.Size(887, 464);
            ((System.ComponentModel.ISupportInitialize)(this.ganttControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowSplitTasks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceEnableTracing.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowBaseLines.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgTracing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GanttControl ganttControl1;
        private XtraTreeList.Columns.TreeListColumn taskNameColumn;
        private XtraTreeList.Columns.TreeListColumn startDateColumn;
        private XtraTreeList.Columns.TreeListColumn finishDateColumn;
        private XtraTreeList.Columns.TreeListColumn resourcesColumn;
        private XtraTreeList.Columns.TreeListColumn baselineStartColumn;
        private XtraTreeList.Columns.TreeListColumn baselineFinishColumn;
        private LayoutControl layoutControl1;
        private LayoutControlGroup Root;
        private CheckEdit ceShowBaseLines;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private LayoutControlGroup lcgOptions;
        private LayoutControlGroup lcgTracing;
        private SimpleButton btnClearLog;
        private CheckEdit ceEnableTracing;
        private LayoutControlItem layoutControlItem2;
        private LayoutControlItem layoutControlItem3;
        private XtraRichEdit.RichEditControl meLog;
        private LayoutControlItem layoutControlItem4;
        private CheckEdit ceAllowSplitTasks;
        private LayoutControlItem layoutControlItem5;
        private SidePanel sidePanel1;
        private TabPane tabPane1;
        private TabNavigationPage tabNavigationPage1;
    }
}
