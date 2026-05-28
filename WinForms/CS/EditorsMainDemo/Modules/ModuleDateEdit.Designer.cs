namespace DevExpress.XtraEditors.Demos {
    partial class ModuleDateEdit {
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ceSynchronizing = new DevExpress.XtraEditors.CheckEdit();
            this.icbEditMask = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.icbShowVistaClock = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.ceShowWeekNumbers = new DevExpress.XtraEditors.CheckEdit();
            this.dateEditSample = new DevExpress.XtraEditors.DateEdit();
            this.ceShowToday = new DevExpress.XtraEditors.CheckEdit();
            this.icbVistaDisplayMode = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.ceShowClear = new DevExpress.XtraEditors.CheckEdit();
            this.icbWeekNumberRule = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.icbAllowNullInput = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceSynchronizing.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbEditMask.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbShowVistaClock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowWeekNumbers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditSample.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditSample.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowToday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbVistaDisplayMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowClear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbWeekNumberRule.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbAllowNullInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.ceSynchronizing);
            this.layoutControl1.Controls.Add(this.icbEditMask);
            this.layoutControl1.Controls.Add(this.icbShowVistaClock);
            this.layoutControl1.Controls.Add(this.ceShowWeekNumbers);
            this.layoutControl1.Controls.Add(this.dateEditSample);
            this.layoutControl1.Controls.Add(this.ceShowToday);
            this.layoutControl1.Controls.Add(this.icbVistaDisplayMode);
            this.layoutControl1.Controls.Add(this.ceShowClear);
            this.layoutControl1.Controls.Add(this.icbWeekNumberRule);
            this.layoutControl1.Controls.Add(this.icbAllowNullInput);
            this.layoutControl1.Location = new System.Drawing.Point(46, 45);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(962, 178, 650, 400);
            this.layoutControl1.OptionsView.UseParentAutoScaleFactor = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(538, 408);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ceSynchronizing
            // 
            this.ceSynchronizing.EditValue = true;
            this.ceSynchronizing.Location = new System.Drawing.Point(280, 352);
            this.ceSynchronizing.Name = "ceSynchronizing";
            this.ceSynchronizing.Properties.Caption = "Synchronize edit mask with display format";
            this.ceSynchronizing.Size = new System.Drawing.Size(226, 20);
            this.ceSynchronizing.StyleController = this.layoutControl1;
            this.ceSynchronizing.TabIndex = 1;
            this.ceSynchronizing.CheckedChanged += new System.EventHandler(this.ceSynchronizing_CheckedChanged);
            // 
            // icbEditMask
            // 
            this.icbEditMask.EditValue = "imageComboBoxEdit1";
            this.icbEditMask.Location = new System.Drawing.Point(399, 324);
            this.icbEditMask.Name = "icbEditMask";
            this.icbEditMask.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbEditMask.Size = new System.Drawing.Size(107, 20);
            this.icbEditMask.StyleController = this.layoutControl1;
            this.icbEditMask.TabIndex = 0;
            this.icbEditMask.SelectedIndexChanged += new System.EventHandler(this.icbEditMask_SelectedIndexChanged);
            // 
            // icbShowVistaClock
            // 
            this.icbShowVistaClock.EditValue = "imageComboBoxEdit1";
            this.icbShowVistaClock.Location = new System.Drawing.Point(399, 81);
            this.icbShowVistaClock.Name = "icbShowVistaClock";
            this.icbShowVistaClock.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbShowVistaClock.Size = new System.Drawing.Size(107, 20);
            this.icbShowVistaClock.StyleController = this.layoutControl1;
            this.icbShowVistaClock.TabIndex = 18;
            this.icbShowVistaClock.SelectedIndexChanged += new System.EventHandler(this.icbShowVistaClock_SelectedIndexChanged);
            // 
            // ceShowWeekNumbers
            // 
            this.ceShowWeekNumbers.Location = new System.Drawing.Point(280, 221);
            this.ceShowWeekNumbers.Name = "ceShowWeekNumbers";
            this.ceShowWeekNumbers.Properties.Caption = "Show week numbers";
            this.ceShowWeekNumbers.Size = new System.Drawing.Size(226, 20);
            this.ceShowWeekNumbers.StyleController = this.layoutControl1;
            this.ceShowWeekNumbers.TabIndex = 5;
            this.ceShowWeekNumbers.CheckedChanged += new System.EventHandler(this.ceShowWeekNumbers_CheckedChanged);
            // 
            // dateEditSample
            // 
            this.dateEditSample.EditValue = new System.DateTime(2005, 5, 30, 0, 0, 0, 0);
            this.dateEditSample.Location = new System.Drawing.Point(32, 204);
            this.dateEditSample.Name = "dateEditSample";
            this.dateEditSample.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditSample.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEditSample.Size = new System.Drawing.Size(176, 20);
            this.dateEditSample.StyleController = this.layoutControl1;
            this.dateEditSample.TabIndex = 0;
            // 
            // ceShowToday
            // 
            this.ceShowToday.Location = new System.Drawing.Point(280, 193);
            this.ceShowToday.Name = "ceShowToday";
            this.ceShowToday.Properties.Caption = "Show Today button";
            this.ceShowToday.Size = new System.Drawing.Size(226, 20);
            this.ceShowToday.StyleController = this.layoutControl1;
            this.ceShowToday.TabIndex = 4;
            this.ceShowToday.CheckedChanged += new System.EventHandler(this.ceShowToday_CheckedChanged);
            // 
            // icbVistaDisplayMode
            // 
            this.icbVistaDisplayMode.EditValue = "imageComboBoxEdit1";
            this.icbVistaDisplayMode.Location = new System.Drawing.Point(399, 53);
            this.icbVistaDisplayMode.Name = "icbVistaDisplayMode";
            this.icbVistaDisplayMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbVistaDisplayMode.Size = new System.Drawing.Size(107, 20);
            this.icbVistaDisplayMode.StyleController = this.layoutControl1;
            this.icbVistaDisplayMode.TabIndex = 0;
            this.icbVistaDisplayMode.SelectedIndexChanged += new System.EventHandler(this.icbVistaDisplayMode_SelectedIndexChanged);
            // 
            // ceShowClear
            // 
            this.ceShowClear.Location = new System.Drawing.Point(280, 165);
            this.ceShowClear.Name = "ceShowClear";
            this.ceShowClear.Properties.Caption = "Show Clear button";
            this.ceShowClear.Size = new System.Drawing.Size(226, 20);
            this.ceShowClear.StyleController = this.layoutControl1;
            this.ceShowClear.TabIndex = 3;
            this.ceShowClear.CheckedChanged += new System.EventHandler(this.ceShowClear_CheckedChanged);
            // 
            // icbWeekNumberRule
            // 
            this.icbWeekNumberRule.EditValue = "imageComboBoxEdit1";
            this.icbWeekNumberRule.Location = new System.Drawing.Point(399, 137);
            this.icbWeekNumberRule.Name = "icbWeekNumberRule";
            this.icbWeekNumberRule.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbWeekNumberRule.Size = new System.Drawing.Size(107, 20);
            this.icbWeekNumberRule.StyleController = this.layoutControl1;
            this.icbWeekNumberRule.TabIndex = 2;
            this.icbWeekNumberRule.SelectedIndexChanged += new System.EventHandler(this.icbWeekNumberRule_SelectedIndexChanged);
            // 
            // icbAllowNullInput
            // 
            this.icbAllowNullInput.EditValue = "imageComboBoxEdit1";
            this.icbAllowNullInput.Location = new System.Drawing.Point(399, 109);
            this.icbAllowNullInput.Name = "icbAllowNullInput";
            this.icbAllowNullInput.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbAllowNullInput.Size = new System.Drawing.Size(107, 20);
            this.icbAllowNullInput.StyleController = this.layoutControl1;
            this.icbAllowNullInput.TabIndex = 1;
            this.icbAllowNullInput.SelectedIndexChanged += new System.EventHandler(this.icbAllowNullInput_SelectedIndexChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlGroup4});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(538, 408);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17);
            this.layoutControlGroup2.Size = new System.Drawing.Size(248, 388);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 30, 2, 2);
            this.layoutControlGroup2.Text = "Sample";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dateEditSample;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem1.FillControlToClientArea = false;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(180, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(180, 327);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextVisible = false;
            this.layoutControlItem1.TrimClientAreaToControl = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.layoutControlGroup3.Location = new System.Drawing.Point(248, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Padding = new DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17);
            this.layoutControlGroup3.Size = new System.Drawing.Size(270, 271);
            this.layoutControlGroup3.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 20);
            this.layoutControlGroup3.Text = "Properties";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.icbVistaDisplayMode;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4);
            this.layoutControlItem2.Size = new System.Drawing.Size(230, 26);
            this.layoutControlItem2.Text = "Calendar View:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(107, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.icbShowVistaClock;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem3.Size = new System.Drawing.Size(230, 28);
            this.layoutControlItem3.Text = "Calendar Time Editing:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(107, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.icbAllowNullInput;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 54);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem4.Size = new System.Drawing.Size(230, 28);
            this.layoutControlItem4.Text = "Allow Null Input:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(107, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.icbWeekNumberRule;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 82);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem5.Size = new System.Drawing.Size(230, 28);
            this.layoutControlItem5.Text = "Week number rule:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(107, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.ceShowClear;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 110);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem6.Size = new System.Drawing.Size(230, 28);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.ceShowToday;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 138);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem7.Size = new System.Drawing.Size(230, 28);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.ceShowWeekNumbers;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 166);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 2);
            this.layoutControlItem8.Size = new System.Drawing.Size(230, 26);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.emptySpaceItem1});
            this.layoutControlGroup4.Location = new System.Drawing.Point(248, 271);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Padding = new DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17);
            this.layoutControlGroup4.Size = new System.Drawing.Size(270, 117);
            this.layoutControlGroup4.Text = "Mask";
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.icbEditMask;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4);
            this.layoutControlItem9.Size = new System.Drawing.Size(230, 26);
            this.layoutControlItem9.Text = "Edit mask:";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(107, 13);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.ceSynchronizing;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 2);
            this.layoutControlItem10.Size = new System.Drawing.Size(230, 26);
            this.layoutControlItem10.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 52);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 1);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(230, 1);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(230, 4);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            // 
            // ModuleDateEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ModuleDateEdit";
            this.Size = new System.Drawing.Size(965, 616);
            this.Load += new System.EventHandler(this.ModuleDateEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceSynchronizing.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbEditMask.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbShowVistaClock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowWeekNumbers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditSample.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditSample.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowToday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbVistaDisplayMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowClear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbWeekNumberRule.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbAllowNullInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.DateEdit dateEditSample;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbAllowNullInput;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbWeekNumberRule;
        private DevExpress.XtraEditors.CheckEdit ceShowClear;
        private DevExpress.XtraEditors.CheckEdit ceShowToday;
        private DevExpress.XtraEditors.CheckEdit ceShowWeekNumbers;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbEditMask;
        private DevExpress.XtraEditors.CheckEdit ceSynchronizing;
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbVistaDisplayMode;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbShowVistaClock;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlGroup layoutControlGroup3;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraLayout.LayoutControlItem layoutControlItem6;
        private XtraLayout.LayoutControlItem layoutControlItem7;
        private XtraLayout.LayoutControlItem layoutControlItem8;
        private XtraLayout.LayoutControlGroup layoutControlGroup4;
        private XtraLayout.LayoutControlItem layoutControlItem9;
        private XtraLayout.LayoutControlItem layoutControlItem10;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;

    }
}
