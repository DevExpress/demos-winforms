namespace DevExpress.XtraEditors.Demos {
    partial class ModuleTimeEdit {
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
            this.teMask = new DevExpress.XtraEditors.TextEdit();
            this.timeEditSample = new DevExpress.XtraEditors.TimeEdit();
            this.comboBoxTimeFormat = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxTimeEditStyle = new DevExpress.XtraEditors.ComboBoxEdit();
            this.radioGroupHourFormat = new DevExpress.XtraEditors.RadioGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teMask.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEditSample.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxTimeFormat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxTimeEditStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupHourFormat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.teMask);
            this.layoutControl1.Controls.Add(this.timeEditSample);
            this.layoutControl1.Controls.Add(this.comboBoxTimeFormat);
            this.layoutControl1.Controls.Add(this.comboBoxTimeEditStyle);
            this.layoutControl1.Controls.Add(this.radioGroupHourFormat);
            this.layoutControl1.Location = new System.Drawing.Point(37, 46);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(949, 204, 650, 400);
            this.layoutControl1.OptionsView.UseParentAutoScaleFactor = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(541, 178);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // teMask
            // 
            this.teMask.EditValue = "";
            this.teMask.Location = new System.Drawing.Point(365, 151);
            this.teMask.Name = "teMask";
            this.teMask.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.teMask.Properties.Appearance.ForeColor = System.Drawing.SystemColors.InfoText;
            this.teMask.Properties.Appearance.Options.UseBackColor = true;
            this.teMask.Properties.Appearance.Options.UseForeColor = true;
            this.teMask.Properties.ReadOnly = true;
            this.teMask.Size = new System.Drawing.Size(151, 20);
            this.teMask.StyleController = this.layoutControl1;
            this.teMask.TabIndex = 5;
            // 
            // timeEditSample
            // 
            this.timeEditSample.EditValue = new System.DateTime(2005, 5, 25, 0, 0, 0, 0);
            this.timeEditSample.Location = new System.Drawing.Point(32, 102);
            this.timeEditSample.Name = "timeEditSample";
            this.timeEditSample.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEditSample.Properties.Mask.EditMask = "hh:mm:ss tt";
            this.timeEditSample.Size = new System.Drawing.Size(176, 20);
            this.timeEditSample.StyleController = this.layoutControl1;
            this.timeEditSample.TabIndex = 0;
            // 
            // comboBoxTimeFormat
            // 
            this.comboBoxTimeFormat.EditValue = "HourMinSec";
            this.comboBoxTimeFormat.Location = new System.Drawing.Point(365, 123);
            this.comboBoxTimeFormat.Name = "comboBoxTimeFormat";
            this.comboBoxTimeFormat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxTimeFormat.Properties.Items.AddRange(new object[] {
            "HourMinSec",
            "HourMin",
            "Hour"});
            this.comboBoxTimeFormat.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxTimeFormat.Size = new System.Drawing.Size(151, 20);
            this.comboBoxTimeFormat.StyleController = this.layoutControl1;
            this.comboBoxTimeFormat.TabIndex = 2;
            this.comboBoxTimeFormat.SelectedIndexChanged += new System.EventHandler(this.comboBoxTimeFormat_SelectedIndexChanged);
            // 
            // comboBoxTimeEditStyle
            // 
            this.comboBoxTimeEditStyle.EditValue = "SpinButtons";
            this.comboBoxTimeEditStyle.Location = new System.Drawing.Point(365, 53);
            this.comboBoxTimeEditStyle.Name = "comboBoxTimeEditStyle";
            this.comboBoxTimeEditStyle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxTimeEditStyle.Properties.Items.AddRange(new object[] {
            "SpinButtons",
            "TouchUI"});
            this.comboBoxTimeEditStyle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxTimeEditStyle.Size = new System.Drawing.Size(151, 20);
            this.comboBoxTimeEditStyle.StyleController = this.layoutControl1;
            this.comboBoxTimeEditStyle.TabIndex = 0;
            this.comboBoxTimeEditStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxTimeEditStyle_SelectedIndexChanged);
            // 
            // radioGroupHourFormat
            // 
            this.radioGroupHourFormat.EditValue = "12";
            this.radioGroupHourFormat.Location = new System.Drawing.Point(365, 81);
            this.radioGroupHourFormat.Name = "radioGroupHourFormat";
            this.radioGroupHourFormat.Properties.Columns = 2;
            this.radioGroupHourFormat.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("12", "12"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("24", "24")});
            this.radioGroupHourFormat.Size = new System.Drawing.Size(151, 34);
            this.radioGroupHourFormat.StyleController = this.layoutControl1;
            this.radioGroupHourFormat.TabIndex = 1;
            this.radioGroupHourFormat.SelectedIndexChanged += new System.EventHandler(this.radioGroupHourFormat_SelectedIndexChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(548, 204);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17);
            this.layoutControlGroup2.Size = new System.Drawing.Size(248, 184);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 30, 2, 2);
            this.layoutControlGroup2.Text = "Sample";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.timeEditSample;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem1.FillControlToClientArea = false;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(1, 1);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(180, 122);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextVisible = false;
            this.layoutControlItem1.TrimClientAreaToControl = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 122);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(0, 1);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(180, 1);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(180, 1);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem1});
            this.layoutControlGroup3.Location = new System.Drawing.Point(248, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Padding = new DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17);
            this.layoutControlGroup3.Size = new System.Drawing.Size(280, 184);
            this.layoutControlGroup3.Text = "Edit value representation";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.comboBoxTimeEditStyle;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4);
            this.layoutControlItem2.Size = new System.Drawing.Size(240, 26);
            this.layoutControlItem2.Text = "Time edit style:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(73, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.radioGroupHourFormat;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem3.Size = new System.Drawing.Size(240, 42);
            this.layoutControlItem3.Text = "Hour format:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(73, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.comboBoxTimeFormat;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 68);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.layoutControlItem4.Size = new System.Drawing.Size(240, 28);
            this.layoutControlItem4.Text = "Time format:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(73, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.teMask;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 2);
            this.layoutControlItem5.Size = new System.Drawing.Size(240, 26);
            this.layoutControlItem5.Text = "Edit mask:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(73, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 122);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 1);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(240, 1);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(240, 1);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            // 
            // ModuleTimeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ModuleTimeEdit";
            this.Size = new System.Drawing.Size(842, 547);
            this.Load += new System.EventHandler(this.ModuleTimeEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teMask.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEditSample.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxTimeFormat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxTimeEditStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupHourFormat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TimeEdit timeEditSample;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxTimeFormat;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxTimeEditStyle;
        private DevExpress.XtraEditors.RadioGroup radioGroupHourFormat;
        private DevExpress.XtraEditors.TextEdit teMask;
        private System.ComponentModel.Container components = null;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem2;
        private XtraLayout.LayoutControlGroup layoutControlGroup3;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;

    }
}
