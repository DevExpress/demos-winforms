namespace DevExpress.XtraTreeList.Demos.Options {
    partial class ucMultiSelectOptions {
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
            this.components = new System.ComponentModel.Container();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.btnShowSelectedValues = new DevExpress.XtraEditors.SimpleButton();
            this.imcMultiSelectMode = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.ceAllowMultiSelect = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.liAllowMultiSelect = new DevExpress.XtraLayout.LayoutControlItem();
            this.liMultiSelectMode = new DevExpress.XtraLayout.LayoutControlItem();
            this.liShowSelectedValues = new DevExpress.XtraLayout.LayoutControlItem();
            this.behaviorManager = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.ceMultiCellEdit = new DevExpress.XtraEditors.CheckEdit();
            this.liMultiCellEdit = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imcMultiSelectMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowMultiSelect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liAllowMultiSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liMultiSelectMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liShowSelectedValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceMultiCellEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liMultiCellEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.btnShowSelectedValues);
            this.layoutControl.Controls.Add(this.imcMultiSelectMode);
            this.layoutControl.Controls.Add(this.ceAllowMultiSelect);
            this.layoutControl.Controls.Add(this.ceMultiCellEdit);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1032, 180, 726, 758);
            this.layoutControl.Root = this.layoutControlGroup;
            this.layoutControl.Size = new System.Drawing.Size(187, 217);
            this.layoutControl.TabIndex = 1;
            this.layoutControl.Text = "layoutControl1";
            // 
            // btnShowSelectedValues
            // 
            this.btnShowSelectedValues.Location = new System.Drawing.Point(12, 100);
            this.btnShowSelectedValues.Name = "btnShowSelectedValues";
            this.btnShowSelectedValues.Size = new System.Drawing.Size(163, 22);
            this.btnShowSelectedValues.StyleController = this.layoutControl;
            this.btnShowSelectedValues.TabIndex = 0;
            this.btnShowSelectedValues.Text = "Show Selected Values";
            this.btnShowSelectedValues.Click += new System.EventHandler(this.btnShowSelectedValues_Click);
            // 
            // imcMultiSelectMode
            // 
            this.imcMultiSelectMode.EditValue = "imageComboBoxEdit1";
            this.imcMultiSelectMode.Location = new System.Drawing.Point(12, 28);
            this.imcMultiSelectMode.Name = "imcMultiSelectMode";
            this.imcMultiSelectMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imcMultiSelectMode.Size = new System.Drawing.Size(163, 20);
            this.imcMultiSelectMode.StyleController = this.layoutControl;
            this.imcMultiSelectMode.TabIndex = 1;
            this.imcMultiSelectMode.SelectedIndexChanged += new System.EventHandler(this.cbMultiSelectMode_SelectedIndexChanged);
            // 
            // ceAllowMultiSelect
            // 
            this.ceAllowMultiSelect.Location = new System.Drawing.Point(12, 52);
            this.ceAllowMultiSelect.Name = "ceAllowMultiSelect";
            this.ceAllowMultiSelect.Properties.Caption = "Multi Select";
            this.ceAllowMultiSelect.Size = new System.Drawing.Size(163, 20);
            this.ceAllowMultiSelect.StyleController = this.layoutControl;
            this.ceAllowMultiSelect.TabIndex = 0;
            this.ceAllowMultiSelect.CheckedChanged += new System.EventHandler(this.ceAllowMultiSelect_CheckedChanged);
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.liAllowMultiSelect,
            this.liMultiSelectMode,
            this.liShowSelectedValues,
            this.liMultiCellEdit});
            this.layoutControlGroup.Name = "layoutControlGroup";
            this.layoutControlGroup.Size = new System.Drawing.Size(187, 217);
            this.layoutControlGroup.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 114);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(167, 83);
            // 
            // liAllowMultiSelect
            // 
            this.liAllowMultiSelect.Control = this.ceAllowMultiSelect;
            this.liAllowMultiSelect.Location = new System.Drawing.Point(0, 40);
            this.liAllowMultiSelect.Name = "liAllowMultiSelect";
            this.liAllowMultiSelect.Size = new System.Drawing.Size(167, 24);
            this.liAllowMultiSelect.TextVisible = false;
            // 
            // liMultiSelectMode
            // 
            this.liMultiSelectMode.Control = this.imcMultiSelectMode;
            this.liMultiSelectMode.Location = new System.Drawing.Point(0, 0);
            this.liMultiSelectMode.Name = "liMultiSelectMode";
            this.liMultiSelectMode.Size = new System.Drawing.Size(167, 40);
            this.liMultiSelectMode.Text = "Multi Select Mode:";
            this.liMultiSelectMode.TextLocation = DevExpress.Utils.Locations.Top;
            this.liMultiSelectMode.TextSize = new System.Drawing.Size(87, 13);
            // 
            // liShowSelectedValues
            // 
            this.liShowSelectedValues.Control = this.btnShowSelectedValues;
            this.liShowSelectedValues.Location = new System.Drawing.Point(0, 88);
            this.liShowSelectedValues.Name = "liShowSelectedValues";
            this.liShowSelectedValues.Size = new System.Drawing.Size(167, 26);
            this.liShowSelectedValues.TextVisible = false;
            // 
            // ceMultiCellEdit
            // 
            this.ceMultiCellEdit.Location = new System.Drawing.Point(12, 76);
            this.ceMultiCellEdit.Name = "ceMultiCellEdit";
            this.ceMultiCellEdit.Properties.Caption = "Multi-Cell Editing";
            this.ceMultiCellEdit.Size = new System.Drawing.Size(163, 20);
            this.ceMultiCellEdit.StyleController = this.layoutControl;
            this.ceMultiCellEdit.TabIndex = 4;
            this.ceMultiCellEdit.CheckedChanged += new System.EventHandler(this.ceMultiCellEdit_CheckedChanged);
            // 
            // liMultiCellEdit
            // 
            this.liMultiCellEdit.Control = this.ceMultiCellEdit;
            this.liMultiCellEdit.Location = new System.Drawing.Point(0, 64);
            this.liMultiCellEdit.Name = "liMultiCellEdit";
            this.liMultiCellEdit.Size = new System.Drawing.Size(167, 24);
            this.liMultiCellEdit.TextVisible = false;
            // 
            // ucMultiSelectOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl);
            this.Name = "ucMultiSelectOptions";
            this.Size = new System.Drawing.Size(187, 217);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imcMultiSelectMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowMultiSelect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liAllowMultiSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liMultiSelectMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liShowSelectedValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceMultiCellEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liMultiCellEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraLayout.LayoutControl layoutControl;
        private XtraEditors.SimpleButton btnShowSelectedValues;
        private XtraEditors.ImageComboBoxEdit imcMultiSelectMode;
        private XtraEditors.CheckEdit ceAllowMultiSelect;
        private XtraLayout.LayoutControlGroup layoutControlGroup;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.LayoutControlItem liAllowMultiSelect;
        private XtraLayout.LayoutControlItem liMultiSelectMode;
        private XtraLayout.LayoutControlItem liShowSelectedValues;
        private Utils.Behaviors.BehaviorManager behaviorManager;
        private XtraEditors.CheckEdit ceMultiCellEdit;
        private XtraLayout.LayoutControlItem liMultiCellEdit;
    }
}
