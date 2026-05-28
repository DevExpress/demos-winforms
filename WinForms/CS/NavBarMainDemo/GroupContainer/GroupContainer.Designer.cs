namespace DevExpress.XtraNavBar.Demos {
    partial class GroupContainer {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupContainer));
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.button1 = new DevExpress.XtraEditors.SimpleButton();
            this.comboBox1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.textBox1 = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.navBarGroupControlContainer3 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.dateTimePicker2 = new DevExpress.XtraEditors.DateEdit();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.dateTimePicker1 = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.comboBox2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.radioButton5 = new DevExpress.XtraEditors.CheckEdit();
            this.radioButton4 = new DevExpress.XtraEditors.CheckEdit();
            this.radioButton3 = new DevExpress.XtraEditors.CheckEdit();
            this.radioButton2 = new DevExpress.XtraEditors.CheckEdit();
            this.radioButton1 = new DevExpress.XtraEditors.CheckEdit();
            this.navBarGroupControlContainer4 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.checkBox5 = new DevExpress.XtraEditors.CheckEdit();
            this.checkBox4 = new DevExpress.XtraEditors.CheckEdit();
            this.checkBox3 = new DevExpress.XtraEditors.CheckEdit();
            this.checkBox2 = new DevExpress.XtraEditors.CheckEdit();
            this.checkBox1 = new DevExpress.XtraEditors.CheckEdit();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.contentPanel1)).BeginInit();
            this.contentPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.navBarControl1.SuspendLayout();
            this.navBarGroupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1.Properties)).BeginInit();
            this.navBarGroupControlContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePicker2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePicker2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePicker1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePicker1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton1.Properties)).BeginInit();
            this.navBarGroupControlContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel1
            // 
            this.contentPanel1.Controls.Add(this.panelControl1);
            this.contentPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.contentPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.contentPanel1.Size = new System.Drawing.Size(268, 507);
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Appearance.GroupHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.navBarControl1.Appearance.GroupHeader.Options.UseFont = true;
            this.navBarControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.navBarControl1.Controls.Add(this.navBarGroupControlContainer1);
            this.navBarControl1.Controls.Add(this.navBarGroupControlContainer3);
            this.navBarControl1.Controls.Add(this.navBarGroupControlContainer4);
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3});
            this.navBarControl1.Location = new System.Drawing.Point(2, 2);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 242;
            this.navBarControl1.Size = new System.Drawing.Size(242, 463);
            this.navBarControl1.StoreDefaultPaintStyleName = true;
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Search";
            this.navBarGroup1.ControlContainer = this.navBarGroupControlContainer1;
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup1.ImageOptions.SmallImageSize = new System.Drawing.Size(16, 16);
            this.navBarGroup1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarGroup1.ImageOptions.SvgImage")));
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarGroupControlContainer1
            // 
            this.navBarGroupControlContainer1.Controls.Add(this.button1);
            this.navBarGroupControlContainer1.Controls.Add(this.comboBox1);
            this.navBarGroupControlContainer1.Controls.Add(this.label2);
            this.navBarGroupControlContainer1.Controls.Add(this.textBox1);
            this.navBarGroupControlContainer1.Controls.Add(this.label1);
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(242, 127);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(8, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Location = new System.Drawing.Point(8, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBox1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBox1.Size = new System.Drawing.Size(229, 20);
            this.comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.label2.Appearance.Options.UseBackColor = true;
            this.label2.Location = new System.Drawing.Point(8, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Look in:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.EditValue = "";
            this.textBox1.Location = new System.Drawing.Point(8, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.label1.Appearance.Options.UseBackColor = true;
            this.label1.Location = new System.Drawing.Point(8, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "All or part of the file name:";
            // 
            // navBarGroupControlContainer3
            // 
            this.navBarGroupControlContainer3.Controls.Add(this.dateTimePicker2);
            this.navBarGroupControlContainer3.Controls.Add(this.label4);
            this.navBarGroupControlContainer3.Controls.Add(this.dateTimePicker1);
            this.navBarGroupControlContainer3.Controls.Add(this.label3);
            this.navBarGroupControlContainer3.Controls.Add(this.comboBox2);
            this.navBarGroupControlContainer3.Controls.Add(this.radioButton5);
            this.navBarGroupControlContainer3.Controls.Add(this.radioButton4);
            this.navBarGroupControlContainer3.Controls.Add(this.radioButton3);
            this.navBarGroupControlContainer3.Controls.Add(this.radioButton2);
            this.navBarGroupControlContainer3.Controls.Add(this.radioButton1);
            this.navBarGroupControlContainer3.Name = "navBarGroupControlContainer3";
            this.navBarGroupControlContainer3.Size = new System.Drawing.Size(242, 199);
            this.navBarGroupControlContainer3.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.EditValue = new System.DateTime(2006, 9, 28, 0, 0, 0, 0);
            this.dateTimePicker2.Location = new System.Drawing.Point(52, 160);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTimePicker2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTimePicker2.Size = new System.Drawing.Size(185, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.label4.Appearance.Options.UseBackColor = true;
            this.label4.Location = new System.Drawing.Point(16, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "to";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.EditValue = new System.DateTime(2006, 9, 28, 0, 0, 0, 0);
            this.dateTimePicker1.Location = new System.Drawing.Point(52, 136);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTimePicker1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTimePicker1.Size = new System.Drawing.Size(185, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.label3.Appearance.Options.UseBackColor = true;
            this.label3.Location = new System.Drawing.Point(16, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "from";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.Location = new System.Drawing.Point(20, 108);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBox2.Properties.Items.AddRange(new object[] {
            "Modified Date",
            "Created Date",
            "Accessed Date"});
            this.comboBox2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBox2.Size = new System.Drawing.Size(217, 20);
            this.comboBox2.TabIndex = 5;
            // 
            // radioButton5
            // 
            this.radioButton5.Location = new System.Drawing.Point(8, 84);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioButton5.Properties.Appearance.Options.UseBackColor = true;
            this.radioButton5.Properties.Caption = "Specify dates";
            this.radioButton5.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.radioButton5.Properties.RadioGroupIndex = 0;
            this.radioButton5.Size = new System.Drawing.Size(164, 20);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = false;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.Location = new System.Drawing.Point(8, 64);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioButton4.Properties.Appearance.Options.UseBackColor = true;
            this.radioButton4.Properties.Caption = "Within the past year";
            this.radioButton4.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.radioButton4.Properties.RadioGroupIndex = 0;
            this.radioButton4.Size = new System.Drawing.Size(164, 20);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = false;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(8, 44);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.Properties.Appearance.Options.UseBackColor = true;
            this.radioButton3.Properties.Caption = "Past month";
            this.radioButton3.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.radioButton3.Properties.RadioGroupIndex = 0;
            this.radioButton3.Size = new System.Drawing.Size(164, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(8, 24);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Properties.Appearance.Options.UseBackColor = true;
            this.radioButton2.Properties.Caption = "Within the last week";
            this.radioButton2.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.radioButton2.Properties.RadioGroupIndex = 0;
            this.radioButton2.Size = new System.Drawing.Size(164, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(8, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Properties.Appearance.Options.UseBackColor = true;
            this.radioButton1.Properties.Caption = "Don\'t remember";
            this.radioButton1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.radioButton1.Properties.RadioGroupIndex = 0;
            this.radioButton1.Size = new System.Drawing.Size(164, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // navBarGroupControlContainer4
            // 
            this.navBarGroupControlContainer4.Controls.Add(this.checkBox5);
            this.navBarGroupControlContainer4.Controls.Add(this.checkBox4);
            this.navBarGroupControlContainer4.Controls.Add(this.checkBox3);
            this.navBarGroupControlContainer4.Controls.Add(this.checkBox2);
            this.navBarGroupControlContainer4.Controls.Add(this.checkBox1);
            this.navBarGroupControlContainer4.Name = "navBarGroupControlContainer4";
            this.navBarGroupControlContainer4.Size = new System.Drawing.Size(208, 89);
            this.navBarGroupControlContainer4.TabIndex = 3;
            // 
            // checkBox5
            // 
            this.checkBox5.Location = new System.Drawing.Point(8, 96);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.checkBox5.Properties.Appearance.Options.UseBackColor = true;
            this.checkBox5.Properties.Caption = "Search tape backup";
            this.checkBox5.Size = new System.Drawing.Size(184, 20);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.Location = new System.Drawing.Point(8, 73);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.checkBox4.Properties.Appearance.Options.UseBackColor = true;
            this.checkBox4.Properties.Caption = "Case sensitive";
            this.checkBox4.Size = new System.Drawing.Size(184, 20);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.Location = new System.Drawing.Point(8, 50);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.checkBox3.Properties.Appearance.Options.UseBackColor = true;
            this.checkBox3.Properties.Caption = "Search subfolders";
            this.checkBox3.Size = new System.Drawing.Size(184, 20);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(8, 27);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Properties.Appearance.Options.UseBackColor = true;
            this.checkBox2.Properties.Caption = "Search hidden files and folders";
            this.checkBox2.Size = new System.Drawing.Size(184, 20);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(8, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Properties.Appearance.Options.UseBackColor = true;
            this.checkBox1.Properties.Caption = "Search system folders";
            this.checkBox1.Size = new System.Drawing.Size(184, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "When was it modified?";
            this.navBarGroup2.ControlContainer = this.navBarGroupControlContainer3;
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup2.ImageOptions.SmallImageSize = new System.Drawing.Size(16, 16);
            this.navBarGroup2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarGroup2.ImageOptions.SvgImage")));
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "More advanced options";
            this.navBarGroup3.ControlContainer = this.navBarGroupControlContainer4;
            this.navBarGroup3.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup3.ImageOptions.SmallImageSize = new System.Drawing.Size(16, 16);
            this.navBarGroup3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarGroup3.ImageOptions.SvgImage")));
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.navBarControl1);
            this.panelControl1.Location = new System.Drawing.Point(4, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(246, 467);
            this.panelControl1.TabIndex = 1;
            // 
            // GroupContainer
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "GroupContainer";
            this.Size = new System.Drawing.Size(268, 507);
            this.Load += new System.EventHandler(this.GroupContainer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contentPanel1)).EndInit();
            this.contentPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.navBarControl1.ResumeLayout(false);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            this.navBarGroupControlContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1.Properties)).EndInit();
            this.navBarGroupControlContainer3.ResumeLayout(false);
            this.navBarGroupControlContainer3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePicker2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePicker2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePicker1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePicker1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButton1.Properties)).EndInit();
            this.navBarGroupControlContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBox5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer3;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer4;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.TextEdit textBox1;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.ComboBoxEdit comboBox1;
        private DevExpress.XtraEditors.CheckEdit radioButton1;
        private DevExpress.XtraEditors.CheckEdit radioButton2;
        private DevExpress.XtraEditors.CheckEdit radioButton3;
        private DevExpress.XtraEditors.CheckEdit radioButton4;
        private DevExpress.XtraEditors.CheckEdit radioButton5;
        private DevExpress.XtraEditors.ComboBoxEdit comboBox2;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.DateEdit dateTimePicker1;
        private DevExpress.XtraEditors.DateEdit dateTimePicker2;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraEditors.CheckEdit checkBox1;
        private DevExpress.XtraEditors.CheckEdit checkBox2;
        private DevExpress.XtraEditors.CheckEdit checkBox3;
        private DevExpress.XtraEditors.CheckEdit checkBox4;
        private DevExpress.XtraEditors.CheckEdit checkBox5;
        private DevExpress.XtraEditors.SimpleButton button1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private System.ComponentModel.Container components = null;
        private XtraEditors.PanelControl panelControl1;

    }
}
