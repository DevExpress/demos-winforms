namespace DevExpress.XtraTreeList.Demos.Options {
    partial class ucFilterOptions {
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
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.ceColumnFilterList = new DevExpress.XtraEditors.CheckEdit();
            this.ieShowFilterPanelMode = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.ceShowAllValuesInFilterPopup = new DevExpress.XtraEditors.CheckEdit();
            this.ceAutoFilterRow = new DevExpress.XtraEditors.CheckEdit();
            this.ceFilterList = new DevExpress.XtraEditors.CheckEdit();
            this.ceAllowFilter = new DevExpress.XtraEditors.CheckEdit();
            this.cbFilterMode = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.ceFilterEditor = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.liAllowFilterMode = new DevExpress.XtraLayout.LayoutControlItem();
            this.liFilterMode = new DevExpress.XtraLayout.LayoutControlItem();
            this.liFilterEditor = new DevExpress.XtraLayout.LayoutControlItem();
            this.liAllowMRUFilterLlist = new DevExpress.XtraLayout.LayoutControlItem();
            this.liShowAutoFilterRow = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.liShowAllValuesInFilterPopup = new DevExpress.XtraLayout.LayoutControlItem();
            this.liShowFilterPanelMode = new DevExpress.XtraLayout.LayoutControlItem();
            this.liColumnFilterList = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceColumnFilterList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ieShowFilterPanelMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowAllValuesInFilterPopup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAutoFilterRow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceFilterList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFilterMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceFilterEditor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liAllowFilterMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liFilterMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liFilterEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liAllowMRUFilterLlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liShowAutoFilterRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liShowAllValuesInFilterPopup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liShowFilterPanelMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liColumnFilterList)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.ceColumnFilterList);
            this.layoutControl.Controls.Add(this.ieShowFilterPanelMode);
            this.layoutControl.Controls.Add(this.ceShowAllValuesInFilterPopup);
            this.layoutControl.Controls.Add(this.ceAutoFilterRow);
            this.layoutControl.Controls.Add(this.ceFilterList);
            this.layoutControl.Controls.Add(this.ceAllowFilter);
            this.layoutControl.Controls.Add(this.cbFilterMode);
            this.layoutControl.Controls.Add(this.ceFilterEditor);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1032, 180, 596, 696);
            this.layoutControl.Root = this.layoutControlGroup;
            this.layoutControl.Size = new System.Drawing.Size(208, 274);
            this.layoutControl.TabIndex = 1;
            this.layoutControl.Text = "layoutControl1";
            // 
            // ceColumnFilterList
            // 
            this.ceColumnFilterList.Location = new System.Drawing.Point(12, 166);
            this.ceColumnFilterList.Name = "ceColumnFilterList";
            this.ceColumnFilterList.Properties.Caption = "Allow Column MRU Filter List";
            this.ceColumnFilterList.Size = new System.Drawing.Size(184, 20);
            this.ceColumnFilterList.StyleController = this.layoutControl;
            this.ceColumnFilterList.TabIndex = 9;
            this.ceColumnFilterList.CheckedChanged += new System.EventHandler(this.ceColumnFilterList_CheckedChanged);
            // 
            // ieShowFilterPanelMode
            // 
            this.ieShowFilterPanelMode.Location = new System.Drawing.Point(139, 70);
            this.ieShowFilterPanelMode.Name = "ieShowFilterPanelMode";
            this.ieShowFilterPanelMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ieShowFilterPanelMode.Properties.DropDownRows = 25;
            this.ieShowFilterPanelMode.Size = new System.Drawing.Size(57, 20);
            this.ieShowFilterPanelMode.StyleController = this.layoutControl;
            this.ieShowFilterPanelMode.TabIndex = 8;
            this.ieShowFilterPanelMode.SelectedIndexChanged += new System.EventHandler(this.ieShowFilterPanelMode_SelectedIndexChanged);
            // 
            // ceShowAllValuesInFilterPopup
            // 
            this.ceShowAllValuesInFilterPopup.Location = new System.Drawing.Point(12, 190);
            this.ceShowAllValuesInFilterPopup.Name = "ceShowAllValuesInFilterPopup";
            this.ceShowAllValuesInFilterPopup.Properties.Caption = "Show All Values in Filter Popup";
            this.ceShowAllValuesInFilterPopup.Size = new System.Drawing.Size(184, 20);
            this.ceShowAllValuesInFilterPopup.StyleController = this.layoutControl;
            this.ceShowAllValuesInFilterPopup.TabIndex = 7;
            this.ceShowAllValuesInFilterPopup.CheckedChanged += new System.EventHandler(this.ceShowAllValuesInFilterPopup_CheckedChanged);
            // 
            // ceAutoFilterRow
            // 
            this.ceAutoFilterRow.Location = new System.Drawing.Point(12, 94);
            this.ceAutoFilterRow.Name = "ceAutoFilterRow";
            this.ceAutoFilterRow.Properties.Caption = "Show Auto Filter Row";
            this.ceAutoFilterRow.Size = new System.Drawing.Size(184, 20);
            this.ceAutoFilterRow.StyleController = this.layoutControl;
            this.ceAutoFilterRow.TabIndex = 4;
            this.ceAutoFilterRow.CheckedChanged += new System.EventHandler(this.ceAutoFilterRow_CheckedChanged);
            // 
            // ceFilterList
            // 
            this.ceFilterList.Location = new System.Drawing.Point(12, 142);
            this.ceFilterList.Name = "ceFilterList";
            this.ceFilterList.Properties.Caption = "Allow MRU filter list";
            this.ceFilterList.Size = new System.Drawing.Size(184, 20);
            this.ceFilterList.StyleController = this.layoutControl;
            this.ceFilterList.TabIndex = 5;
            this.ceFilterList.CheckedChanged += new System.EventHandler(this.ceFilterList_CheckedChanged);
            // 
            // ceAllowFilter
            // 
            this.ceAllowFilter.Location = new System.Drawing.Point(12, 12);
            this.ceAllowFilter.Name = "ceAllowFilter";
            this.ceAllowFilter.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ceAllowFilter.Properties.Appearance.Options.UseFont = true;
            this.ceAllowFilter.Properties.Caption = "Allow Filter";
            this.ceAllowFilter.Size = new System.Drawing.Size(184, 20);
            this.ceAllowFilter.StyleController = this.layoutControl;
            this.ceAllowFilter.TabIndex = 0;
            this.ceAllowFilter.CheckedChanged += new System.EventHandler(this.ceAllowFilter_CheckedChanged);
            // 
            // cbFilterMode
            // 
            this.cbFilterMode.Location = new System.Drawing.Point(139, 46);
            this.cbFilterMode.Name = "cbFilterMode";
            this.cbFilterMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFilterMode.Properties.DropDownRows = 25;
            this.cbFilterMode.Size = new System.Drawing.Size(57, 20);
            this.cbFilterMode.StyleController = this.layoutControl;
            this.cbFilterMode.TabIndex = 2;
            this.cbFilterMode.SelectedIndexChanged += new System.EventHandler(this.cbFilterMode_SelectedIndexChanged);
            // 
            // ceFilterEditor
            // 
            this.ceFilterEditor.Location = new System.Drawing.Point(12, 118);
            this.ceFilterEditor.Name = "ceFilterEditor";
            this.ceFilterEditor.Properties.Caption = "Allow Filter Editor";
            this.ceFilterEditor.Size = new System.Drawing.Size(184, 20);
            this.ceFilterEditor.StyleController = this.layoutControl;
            this.ceFilterEditor.TabIndex = 3;
            this.ceFilterEditor.CheckedChanged += new System.EventHandler(this.ceFilterEditor_CheckedChanged);
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.liAllowFilterMode,
            this.liFilterMode,
            this.liFilterEditor,
            this.liAllowMRUFilterLlist,
            this.liShowAutoFilterRow,
            this.emptySpaceItem2,
            this.liShowAllValuesInFilterPopup,
            this.liShowFilterPanelMode,
            this.liColumnFilterList});
            this.layoutControlGroup.Name = "Root";
            this.layoutControlGroup.Size = new System.Drawing.Size(208, 274);
            this.layoutControlGroup.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 202);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(188, 52);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // liAllowFilterMode
            // 
            this.liAllowFilterMode.Control = this.ceAllowFilter;
            this.liAllowFilterMode.Location = new System.Drawing.Point(0, 0);
            this.liAllowFilterMode.Name = "liAllowFilterMode";
            this.liAllowFilterMode.Size = new System.Drawing.Size(188, 24);
            this.liAllowFilterMode.TextSize = new System.Drawing.Size(0, 0);
            this.liAllowFilterMode.TextVisible = false;
            // 
            // liFilterMode
            // 
            this.liFilterMode.Control = this.cbFilterMode;
            this.liFilterMode.Location = new System.Drawing.Point(0, 34);
            this.liFilterMode.Name = "liFilterMode";
            this.liFilterMode.Size = new System.Drawing.Size(188, 24);
            this.liFilterMode.Text = "Filter Mode:";
            this.liFilterMode.TextSize = new System.Drawing.Size(115, 13);
            // 
            // liFilterEditor
            // 
            this.liFilterEditor.Control = this.ceFilterEditor;
            this.liFilterEditor.Location = new System.Drawing.Point(0, 106);
            this.liFilterEditor.Name = "liFilterEditor";
            this.liFilterEditor.Size = new System.Drawing.Size(188, 24);
            this.liFilterEditor.TextSize = new System.Drawing.Size(0, 0);
            this.liFilterEditor.TextVisible = false;
            // 
            // liAllowMRUFilterLlist
            // 
            this.liAllowMRUFilterLlist.Control = this.ceFilterList;
            this.liAllowMRUFilterLlist.Location = new System.Drawing.Point(0, 130);
            this.liAllowMRUFilterLlist.Name = "liAllowMRUFilterLlist";
            this.liAllowMRUFilterLlist.Size = new System.Drawing.Size(188, 24);
            this.liAllowMRUFilterLlist.TextSize = new System.Drawing.Size(0, 0);
            this.liAllowMRUFilterLlist.TextVisible = false;
            // 
            // liShowAutoFilterRow
            // 
            this.liShowAutoFilterRow.Control = this.ceAutoFilterRow;
            this.liShowAutoFilterRow.Location = new System.Drawing.Point(0, 82);
            this.liShowAutoFilterRow.Name = "liShowAutoFilterRow";
            this.liShowAutoFilterRow.Size = new System.Drawing.Size(188, 24);
            this.liShowAutoFilterRow.TextSize = new System.Drawing.Size(0, 0);
            this.liShowAutoFilterRow.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 24);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(188, 10);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // liShowAllValuesInFilterPopup
            // 
            this.liShowAllValuesInFilterPopup.Control = this.ceShowAllValuesInFilterPopup;
            this.liShowAllValuesInFilterPopup.Location = new System.Drawing.Point(0, 178);
            this.liShowAllValuesInFilterPopup.Name = "liShowAllValuesInFilterPopup";
            this.liShowAllValuesInFilterPopup.Size = new System.Drawing.Size(188, 24);
            this.liShowAllValuesInFilterPopup.TextSize = new System.Drawing.Size(0, 0);
            this.liShowAllValuesInFilterPopup.TextVisible = false;
            // 
            // liShowFilterPanelMode
            // 
            this.liShowFilterPanelMode.Control = this.ieShowFilterPanelMode;
            this.liShowFilterPanelMode.Location = new System.Drawing.Point(0, 58);
            this.liShowFilterPanelMode.Name = "liShowFilterPanelMode";
            this.liShowFilterPanelMode.Size = new System.Drawing.Size(188, 24);
            this.liShowFilterPanelMode.Text = "Show Filter Panel Mode:";
            this.liShowFilterPanelMode.TextSize = new System.Drawing.Size(115, 13);
            // 
            // liColumnFilterList
            // 
            this.liColumnFilterList.Control = this.ceColumnFilterList;
            this.liColumnFilterList.Location = new System.Drawing.Point(0, 154);
            this.liColumnFilterList.Name = "liColumnFilterList";
            this.liColumnFilterList.Size = new System.Drawing.Size(188, 24);
            this.liColumnFilterList.TextSize = new System.Drawing.Size(0, 0);
            this.liColumnFilterList.TextVisible = false;
            // 
            // ucFilterOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl);
            this.Name = "ucFilterOptions";
            this.Size = new System.Drawing.Size(208, 274);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceColumnFilterList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ieShowFilterPanelMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowAllValuesInFilterPopup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAutoFilterRow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceFilterList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFilterMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceFilterEditor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liAllowFilterMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liFilterMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liFilterEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liAllowMRUFilterLlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liShowAutoFilterRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liShowAllValuesInFilterPopup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liShowFilterPanelMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liColumnFilterList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraLayout.LayoutControl layoutControl;
        private XtraEditors.CheckEdit ceAutoFilterRow;
        private XtraEditors.CheckEdit ceFilterList;
        private XtraEditors.CheckEdit ceAllowFilter;
        private XtraEditors.ImageComboBoxEdit cbFilterMode;
        private XtraEditors.CheckEdit ceFilterEditor;
        private XtraLayout.LayoutControlGroup layoutControlGroup;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem2;
        private XtraLayout.LayoutControlItem liAllowFilterMode;
        private XtraLayout.LayoutControlItem liFilterMode;
        private XtraLayout.LayoutControlItem liFilterEditor;
        private XtraLayout.LayoutControlItem liShowAutoFilterRow;
        private XtraLayout.LayoutControlItem liAllowMRUFilterLlist;
        private XtraEditors.CheckEdit ceShowAllValuesInFilterPopup;
        private XtraLayout.LayoutControlItem liShowAllValuesInFilterPopup;
        private XtraEditors.ImageComboBoxEdit ieShowFilterPanelMode;
        private XtraLayout.LayoutControlItem liShowFilterPanelMode;
        private XtraEditors.CheckEdit ceColumnFilterList;
        private XtraLayout.LayoutControlItem liColumnFilterList;
    }
}
