namespace DevExpress.XtraScheduler.Demos {
    partial class AppointmentOptionsControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            this.cbAppointmentFontSize = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.feAppointment = new DevExpress.XtraEditors.FontEdit();
            this.chkAppointmentShowRecurrence = new DevExpress.XtraEditors.CheckEdit();
            this.chkAppointmentShowReminder = new DevExpress.XtraEditors.CheckEdit();
            this.optionsGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.cbAppointmentFontSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feAppointment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAppointmentShowRecurrence.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAppointmentShowReminder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAppointmentFontSize
            // 
            this.cbAppointmentFontSize.Location = new System.Drawing.Point(278, 34);
            this.cbAppointmentFontSize.Name = "cbAppointmentFontSize";
            this.cbAppointmentFontSize.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbAppointmentFontSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAppointmentFontSize.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cbAppointmentFontSize.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cbAppointmentFontSize.Size = new System.Drawing.Size(58, 20);
            this.cbAppointmentFontSize.StyleController = this.layoutControl2;
            this.cbAppointmentFontSize.TabIndex = 7;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.feAppointment);
            this.layoutControl2.Controls.Add(this.chkAppointmentShowRecurrence);
            this.layoutControl2.Controls.Add(this.chkAppointmentShowReminder);
            this.layoutControl2.Controls.Add(this.cbAppointmentFontSize);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(505, 96, 650, 400);
            this.layoutControl2.Root = this.optionsGroup;
            this.layoutControl2.Size = new System.Drawing.Size(458, 375);
            this.layoutControl2.TabIndex = 1;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // feAppointment
            // 
            this.feAppointment.Location = new System.Drawing.Point(53, 34);
            this.feAppointment.Name = "feAppointment";
            this.feAppointment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.feAppointment.Size = new System.Drawing.Size(221, 20);
            this.feAppointment.StyleController = this.layoutControl2;
            this.feAppointment.TabIndex = 4;
            // 
            // chkAppointmentShowRecurrence
            // 
            this.chkAppointmentShowRecurrence.Location = new System.Drawing.Point(12, 58);
            this.chkAppointmentShowRecurrence.Name = "chkAppointmentShowRecurrence";
            this.chkAppointmentShowRecurrence.Properties.Caption = "Show reccurrence icon";
            this.chkAppointmentShowRecurrence.Size = new System.Drawing.Size(434, 20);
            this.chkAppointmentShowRecurrence.StyleController = this.layoutControl2;
            this.chkAppointmentShowRecurrence.TabIndex = 5;
            // 
            // chkAppointmentShowReminder
            // 
            this.chkAppointmentShowReminder.Location = new System.Drawing.Point(12, 82);
            this.chkAppointmentShowReminder.Name = "chkAppointmentShowReminder";
            this.chkAppointmentShowReminder.Properties.Caption = "Show reminder icon";
            this.chkAppointmentShowReminder.Size = new System.Drawing.Size(434, 20);
            this.chkAppointmentShowReminder.StyleController = this.layoutControl2;
            this.chkAppointmentShowReminder.TabIndex = 6;
            // 
            // optionsGroup
            // 
            this.optionsGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.optionsGroup.GroupBordersVisible = false;
            this.optionsGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.optionsGroup.Name = "Root";
            this.optionsGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.optionsGroup.Size = new System.Drawing.Size(458, 375);
            this.optionsGroup.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem2,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(458, 375);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "Display Options";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.feAppointment;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(266, 24);
            this.layoutControlItem1.Text = "Font :";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(29, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbAppointmentFontSize;
            this.layoutControlItem4.Location = new System.Drawing.Point(266, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(62, 24);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.chkAppointmentShowRecurrence;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(438, 24);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.chkAppointmentShowReminder;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(438, 24);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.Location = new System.Drawing.Point(328, 0);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(104, 24);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(110, 24);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 72);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(438, 261);
            // 
            // AppointmentOptionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl2);
            this.Name = "AppointmentOptionsControl";
            this.Size = new System.Drawing.Size(458, 375);
            ((System.ComponentModel.ISupportInitialize)(this.cbAppointmentFontSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.feAppointment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAppointmentShowRecurrence.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAppointmentShowReminder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private XtraEditors.CheckEdit chkAppointmentShowReminder;
        private XtraEditors.CheckEdit chkAppointmentShowRecurrence;
        private XtraEditors.FontEdit feAppointment;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem2;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraEditors.ComboBoxEdit cbAppointmentFontSize;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControl layoutControl2;
        private XtraLayout.LayoutControlGroup optionsGroup;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}
