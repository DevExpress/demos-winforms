namespace DevExpress.XtraGrid.Demos {
    partial class ExpressionConditionsEditor {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpressionConditionsEditor));
            this.FormatItemList = new DevExpress.XtraEditors.ListBoxControl();
            this.tablePanel = new DevExpress.Utils.Layout.TablePanel();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.propertyGrid1 = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            this.imageComboBoxEdit1 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.repositoryItemColorPickEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit();
            ((System.ComponentModel.ISupportInitialize)(this.FormatItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel)).BeginInit();
            this.tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // FormatItemList
            // 
            this.FormatItemList.Appearance.Options.UseTextOptions = true;
            this.FormatItemList.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.FormatItemList.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.tablePanel.SetColumn(this.FormatItemList, 0);
            this.tablePanel.SetColumnSpan(this.FormatItemList, 2);
            resources.ApplyResources(this.FormatItemList, "FormatItemList");
            this.FormatItemList.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.FormatItemList.Name = "FormatItemList";
            this.tablePanel.SetRow(this.FormatItemList, 1);
            this.FormatItemList.ShowFocusRect = false;
            this.FormatItemList.SelectedIndexChanged += new System.EventHandler(this.FormatItemList_SelectedIndexChanged);
            this.FormatItemList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FormatItemList_MouseDoubleClick);
            // 
            // tablePanel
            // 
            this.tablePanel.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F)});
            this.tablePanel.Controls.Add(this.labelControl4);
            this.tablePanel.Controls.Add(this.checkEdit1);
            this.tablePanel.Controls.Add(this.btnAdd);
            this.tablePanel.Controls.Add(this.labelControl1);
            this.tablePanel.Controls.Add(this.FormatItemList);
            this.tablePanel.Controls.Add(this.labelControl2);
            this.tablePanel.Controls.Add(this.propertyGrid1);
            this.tablePanel.Controls.Add(this.imageComboBoxEdit1);
            this.tablePanel.Controls.Add(this.labelControl3);
            this.tablePanel.Controls.Add(this.btnDelete);
            this.tablePanel.Controls.Add(this.btnEdit);
            resources.ApplyResources(this.tablePanel, "tablePanel");
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)});
            // 
            // labelControl4
            // 
            this.tablePanel.SetColumn(this.labelControl4, 0);
            resources.ApplyResources(this.labelControl4, "labelControl4");
            this.labelControl4.Name = "labelControl4";
            this.tablePanel.SetRow(this.labelControl4, 8);
            // 
            // checkEdit1
            // 
            this.tablePanel.SetColumn(this.checkEdit1, 1);
            resources.ApplyResources(this.checkEdit1, "checkEdit1");
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = resources.GetString("checkEdit1.Properties.Caption");
            this.tablePanel.SetRow(this.checkEdit1, 8);
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // btnAdd
            // 
            this.tablePanel.SetColumn(this.btnAdd, 0);
            this.tablePanel.SetColumnSpan(this.btnAdd, 2);
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.tablePanel.SetRow(this.btnAdd, 2);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelControl1
            // 
            this.tablePanel.SetColumn(this.labelControl1, 0);
            this.tablePanel.SetColumnSpan(this.labelControl1, 2);
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            this.tablePanel.SetRow(this.labelControl1, 0);
            // 
            // labelControl2
            // 
            this.tablePanel.SetColumn(this.labelControl2, 0);
            this.tablePanel.SetColumnSpan(this.labelControl2, 2);
            resources.ApplyResources(this.labelControl2, "labelControl2");
            this.labelControl2.Name = "labelControl2";
            this.tablePanel.SetRow(this.labelControl2, 5);
            // 
            // propertyGrid1
            // 
            this.tablePanel.SetColumn(this.propertyGrid1, 0);
            this.tablePanel.SetColumnSpan(this.propertyGrid1, 2);
            this.propertyGrid1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.propertyGrid1, "propertyGrid1");
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.OptionsBehavior.ResizeRowHeaders = false;
            this.propertyGrid1.OptionsBehavior.ResizeRowValues = false;
            this.propertyGrid1.OptionsView.AllowReadOnlyRowAppearance = DevExpress.Utils.DefaultBoolean.True;
            this.tablePanel.SetRow(this.propertyGrid1, 6);
            this.propertyGrid1.ScrollsStyle.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.propertyGrid1.CustomRecordCellEdit += new DevExpress.XtraVerticalGrid.Events.GetCustomRowCellEditEventHandler(this.propertyGrid1_CustomRecordCellEdit);
            // 
            // imageComboBoxEdit1
            // 
            resources.ApplyResources(this.imageComboBoxEdit1, "imageComboBoxEdit1");
            this.tablePanel.SetColumn(this.imageComboBoxEdit1, 1);
            this.imageComboBoxEdit1.Name = "imageComboBoxEdit1";
            this.imageComboBoxEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.imageComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("imageComboBoxEdit1.Properties.Buttons"))))});
            this.tablePanel.SetRow(this.imageComboBoxEdit1, 7);
            this.imageComboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.imageComboBoxEdit1_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.tablePanel.SetColumn(this.labelControl3, 0);
            resources.ApplyResources(this.labelControl3, "labelControl3");
            this.labelControl3.Name = "labelControl3";
            this.tablePanel.SetRow(this.labelControl3, 7);
            // 
            // btnDelete
            // 
            this.tablePanel.SetColumn(this.btnDelete, 0);
            this.tablePanel.SetColumnSpan(this.btnDelete, 2);
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.tablePanel.SetRow(this.btnDelete, 3);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.tablePanel.SetColumn(this.btnEdit, 0);
            this.tablePanel.SetColumnSpan(this.btnEdit, 2);
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.Name = "btnEdit";
            this.tablePanel.SetRow(this.btnEdit, 4);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // repositoryItemColorPickEdit1
            // 
            resources.ApplyResources(this.repositoryItemColorPickEdit1, "repositoryItemColorPickEdit1");
            this.repositoryItemColorPickEdit1.AutomaticColor = System.Drawing.Color.Black;
            this.repositoryItemColorPickEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemColorPickEdit1.Buttons"))))});
            this.repositoryItemColorPickEdit1.Name = "repositoryItemColorPickEdit1";
            // 
            // ExpressionConditionsEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel);
            this.Name = "ExpressionConditionsEditor";
            ((System.ComponentModel.ISupportInitialize)(this.FormatItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel)).EndInit();
            this.tablePanel.ResumeLayout(false);
            this.tablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.ListBoxControl FormatItemList;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGrid1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.ImageComboBoxEdit imageComboBoxEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private XtraEditors.Repository.RepositoryItemColorPickEdit repositoryItemColorPickEdit1;
        private Utils.Layout.TablePanel tablePanel;
        private XtraEditors.SimpleButton btnAdd;
        private XtraEditors.SimpleButton btnDelete;
        private XtraEditors.SimpleButton btnEdit;
        private XtraEditors.LabelControl labelControl4;
    }
}
