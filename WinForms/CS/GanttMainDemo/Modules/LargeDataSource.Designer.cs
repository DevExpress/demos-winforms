using DevExpress.Utils.Layout;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;

namespace DevExpress.XtraGantt.Demos
{
    partial class LargeDataSource
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
            this.uidColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.nameColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.startColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.duractionColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.predecessorColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.parentUIDColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.btngenerate = new DevExpress.XtraEditors.SimpleButton();
            this.customTasksCount = new DevExpress.XtraEditors.SpinEdit();
            this.ceCustom = new DevExpress.XtraEditors.CheckEdit();
            this.ceValue3 = new DevExpress.XtraEditors.CheckEdit();
            this.ceValue2 = new DevExpress.XtraEditors.CheckEdit();
            this.ceValue1 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ganttControl1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customTasksCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceCustom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceValue3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceValue2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceValue1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ganttControl1
            // 
            this.ganttControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ganttControl1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.uidColumn,
            this.nameColumn,
            this.startColumn,
            this.duractionColumn,
            this.predecessorColumn,
            this.parentUIDColumn});
            this.ganttControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ganttControl1.Location = new System.Drawing.Point(0, 0);
            this.ganttControl1.Name = "ganttControl1";
            this.ganttControl1.OptionsBehavior.Editable = false;
            this.ganttControl1.OptionsBehavior.ReadOnly = true;
            this.ganttControl1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.ganttControl1.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.None;
            this.ganttControl1.OptionsView.InteractionTooltipLocation = DevExpress.XtraGantt.InteractionTooltipLocation.None;
            this.ganttControl1.OptionsView.ShowIndentAsRowStyle = true;
            this.ganttControl1.OptionsView.ShowSummaryFooter = true;
            this.ganttControl1.Size = new System.Drawing.Size(728, 491);
            this.ganttControl1.TabIndex = 0;
            this.ganttControl1.TreeListMappings.HierarchyColumn = this.nameColumn;
            // 
            // uidColumn
            // 
            this.uidColumn.Caption = "ID";
            this.uidColumn.FieldName = "UID";
            this.uidColumn.Name = "uidColumn";
            // 
            // nameColumn
            // 
            this.nameColumn.AllNodesSummary = true;
            this.nameColumn.Caption = "Name";
            this.nameColumn.FieldName = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Count;
            this.nameColumn.SummaryFooterStrFormat = "Tasks Count: {0}";
            this.nameColumn.Visible = true;
            this.nameColumn.VisibleIndex = 0;
            // 
            // startColumn
            // 
            this.startColumn.Caption = "Start";
            this.startColumn.FieldName = "Start";
            this.startColumn.MaxWidth = 90;
            this.startColumn.Name = "startColumn";
            // 
            // duractionColumn
            // 
            this.duractionColumn.Caption = "Duration";
            this.duractionColumn.FieldName = "Duration";
            this.duractionColumn.MaxWidth = 90;
            this.duractionColumn.Name = "duractionColumn";
            // 
            // predecessorColumn
            // 
            this.predecessorColumn.Caption = "Predecessors";
            this.predecessorColumn.FieldName = "Predecessors";
            this.predecessorColumn.Name = "predecessorColumn";
            // 
            // parentUIDColumn
            // 
            this.parentUIDColumn.Caption = "ParentUID";
            this.parentUIDColumn.FieldName = "ParentUID";
            this.parentUIDColumn.Name = "parentUIDColumn";
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.tabPane1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(728, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(210, 491);
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
            this.tabPane1.RegularSize = new System.Drawing.Size(209, 491);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(209, 491);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Tasks";
            this.tabNavigationPage1.Controls.Add(this.tablePanel1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(209, 458);
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)});
            this.tablePanel1.Controls.Add(this.tablePanel2);
            this.tablePanel1.Controls.Add(this.ceCustom);
            this.tablePanel1.Controls.Add(this.ceValue3);
            this.tablePanel1.Controls.Add(this.ceValue2);
            this.tablePanel1.Controls.Add(this.ceValue1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Padding = new System.Windows.Forms.Padding(16);
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 31F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(209, 458);
            this.tablePanel1.TabIndex = 0;
            // 
            // tablePanel2
            // 
            this.tablePanel2.AutoSize = true;
            this.tablePanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablePanel1.SetColumn(this.tablePanel2, 0);
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 37.96F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 22.04F)});
            this.tablePanel2.Controls.Add(this.btngenerate);
            this.tablePanel2.Controls.Add(this.customTasksCount);
            this.tablePanel2.Location = new System.Drawing.Point(19, 123);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel1.SetRow(this.tablePanel2, 4);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 4F)});
            this.tablePanel2.Size = new System.Drawing.Size(171, 30);
            this.tablePanel2.TabIndex = 4;
            // 
            // btngenerate
            // 
            this.tablePanel2.SetColumn(this.btngenerate, 1);
            this.btngenerate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btngenerate.Location = new System.Drawing.Point(111, 3);
            this.btngenerate.Name = "btngenerate";
            this.tablePanel2.SetRow(this.btngenerate, 0);
            this.btngenerate.Size = new System.Drawing.Size(57, 20);
            this.btngenerate.TabIndex = 1;
            this.btngenerate.Text = "Generate";
            this.btngenerate.Click += new System.EventHandler(this.btngenerate_Click);
            // 
            // customTasksCount
            // 
            this.tablePanel2.SetColumn(this.customTasksCount, 0);
            this.customTasksCount.EditValue = new decimal(new int[] {
            1500000,
            0,
            0,
            0});
            this.customTasksCount.Location = new System.Drawing.Point(3, 3);
            this.customTasksCount.Name = "customTasksCount";
            this.customTasksCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.customTasksCount.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.customTasksCount.Properties.MaxValue = new decimal(new int[] {
            1500000,
            0,
            0,
            0});
            this.tablePanel2.SetRow(this.customTasksCount, 0);
            this.customTasksCount.Size = new System.Drawing.Size(102, 20);
            this.customTasksCount.TabIndex = 0;
            this.customTasksCount.Enter += new System.EventHandler(this.seCustomRecordsCount_Enter);
            // 
            // ceCustom
            // 
            this.tablePanel1.SetColumn(this.ceCustom, 0);
            this.ceCustom.Location = new System.Drawing.Point(19, 97);
            this.ceCustom.Name = "ceCustom";
            this.ceCustom.Properties.Caption = "Enter tasks count";
            this.ceCustom.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio;
            this.ceCustom.Properties.RadioGroupIndex = 0;
            this.tablePanel1.SetRow(this.ceCustom, 3);
            this.ceCustom.Size = new System.Drawing.Size(171, 20);
            this.ceCustom.TabIndex = 3;
            this.ceCustom.TabStop = false;
            this.ceCustom.CheckedChanged += new System.EventHandler(this.ceTask_CheckedChanged);
            // 
            // ceValue3
            // 
            this.tablePanel1.SetColumn(this.ceValue3, 0);
            this.ceValue3.Location = new System.Drawing.Point(19, 71);
            this.ceValue3.Name = "ceValue3";
            this.ceValue3.Properties.Caption = "1M";
            this.ceValue3.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio;
            this.ceValue3.Properties.RadioGroupIndex = 0;
            this.tablePanel1.SetRow(this.ceValue3, 2);
            this.ceValue3.Size = new System.Drawing.Size(171, 20);
            this.ceValue3.TabIndex = 2;
            this.ceValue3.TabStop = false;
            this.ceValue3.CheckedChanged += new System.EventHandler(this.ceTask_CheckedChanged);
            // 
            // ceValue2
            // 
            this.tablePanel1.SetColumn(this.ceValue2, 0);
            this.ceValue2.Location = new System.Drawing.Point(19, 45);
            this.ceValue2.Name = "ceValue2";
            this.ceValue2.Properties.Caption = "500K";
            this.ceValue2.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio;
            this.ceValue2.Properties.RadioGroupIndex = 0;
            this.tablePanel1.SetRow(this.ceValue2, 1);
            this.ceValue2.Size = new System.Drawing.Size(171, 20);
            this.ceValue2.TabIndex = 1;
            this.ceValue2.TabStop = false;
            this.ceValue2.CheckedChanged += new System.EventHandler(this.ceTask_CheckedChanged);
            // 
            // ceValue1
            // 
            this.tablePanel1.SetColumn(this.ceValue1, 0);
            this.ceValue1.EditValue = true;
            this.ceValue1.Location = new System.Drawing.Point(19, 19);
            this.ceValue1.Name = "ceValue1";
            this.ceValue1.Properties.Caption = "100K";
            this.ceValue1.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio;
            this.ceValue1.Properties.RadioGroupIndex = 0;
            this.tablePanel1.SetRow(this.ceValue1, 0);
            this.ceValue1.Size = new System.Drawing.Size(171, 20);
            this.ceValue1.TabIndex = 0;
            this.ceValue1.CheckedChanged += new System.EventHandler(this.ceTask_CheckedChanged);
            // 
            // LargeDataSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ganttControl1);
            this.Controls.Add(this.sidePanel1);
            this.Name = "LargeDataSource";
            this.Size = new System.Drawing.Size(938, 491);
            ((System.ComponentModel.ISupportInitialize)(this.ganttControl1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customTasksCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceCustom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceValue3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceValue2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceValue1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GanttControl ganttControl1;
        private XtraTreeList.Columns.TreeListColumn nameColumn;
        private XtraTreeList.Columns.TreeListColumn startColumn;
        private XtraTreeList.Columns.TreeListColumn duractionColumn;
        private XtraTreeList.Columns.TreeListColumn predecessorColumn;
        private XtraTreeList.Columns.TreeListColumn uidColumn;
        private XtraTreeList.Columns.TreeListColumn parentUIDColumn;
        private SidePanel sidePanel1;
        private TabPane tabPane1;
        private TabNavigationPage tabNavigationPage1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private CheckEdit ceValue1;
        private TablePanel tablePanel2;
        private SpinEdit customTasksCount;
        private CheckEdit ceCustom;
        private CheckEdit ceValue3;
        private CheckEdit ceValue2;
        private SimpleButton btngenerate;
    }
}
