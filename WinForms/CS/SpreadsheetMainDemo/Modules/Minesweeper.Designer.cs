namespace DevExpress.XtraSpreadsheet.Demos {
    partial class MinesweeperModule {
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

        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition6 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition7 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition8 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition9 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition10 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            this.spreadsheetControl = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cellSizeLabel = new DevExpress.XtraEditors.LabelControl();
            this.NewGameBtn = new DevExpress.XtraEditors.SimpleButton();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.cellSizeTrack = new DevExpress.XtraEditors.TrackBarControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellSizeTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellSizeTrack.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // spreadsheetControl
            // 
            this.spreadsheetControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.spreadsheetControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetControl.Location = new System.Drawing.Point(0, 59);
            this.spreadsheetControl.Name = "spreadsheetControl";
            this.spreadsheetControl.Options.Behavior.Selection.HideSelection = true;
            this.spreadsheetControl.Options.Behavior.Selection.MoveActiveCellMode = DevExpress.XtraSpreadsheet.MoveActiveCellModeOnEnterPress.None;
            this.spreadsheetControl.Options.Behavior.UseSkinColors = false;
            this.spreadsheetControl.Options.Culture = new System.Globalization.CultureInfo("en-US");
            this.spreadsheetControl.Options.Export.Csv.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl.Options.Export.Txt.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl.Options.Import.Csv.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl.Options.Import.Txt.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl.Size = new System.Drawing.Size(784, 373);
            this.spreadsheetControl.TabIndex = 55;
            this.spreadsheetControl.Text = "spreadsheetControl1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // cellSizeLabel
            // 
            this.cellSizeLabel.Location = new System.Drawing.Point(317, 22);
            this.cellSizeLabel.Name = "cellSizeLabel";
            this.cellSizeLabel.Size = new System.Drawing.Size(43, 13);
            this.cellSizeLabel.StyleController = this.layoutControl1;
            this.cellSizeLabel.TabIndex = 61;
            this.cellSizeLabel.Text = "Cell Size:";
            // 
            // NewGameBtn
            // 
            this.NewGameBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewGameBtn.Location = new System.Drawing.Point(696, 18);
            this.NewGameBtn.Name = "NewGameBtn";
            this.NewGameBtn.Size = new System.Drawing.Size(76, 22);
            this.NewGameBtn.StyleController = this.layoutControl1;
            this.NewGameBtn.TabIndex = 62;
            this.NewGameBtn.Text = "New Game";
            this.NewGameBtn.Click += new System.EventHandler(this.Button1Click);
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(12, 12);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Columns = 3;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Beginner"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Intermediate"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Expert")});
            this.radioGroup1.Size = new System.Drawing.Size(296, 34);
            this.radioGroup1.StyleController = this.layoutControl1;
            this.radioGroup1.TabIndex = 59;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.RadioGroup1SelectedIndexChanged);
            // 
            // cellSizeTrack
            // 
            this.cellSizeTrack.EditValue = 18;
            this.cellSizeTrack.Location = new System.Drawing.Point(364, 17);
            this.cellSizeTrack.Name = "cellSizeTrack";
            this.cellSizeTrack.Properties.AutoSizeMode = DevExpress.XtraEditors.Repository.TrackBarAutoSizeMode.Content;
            this.cellSizeTrack.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.cellSizeTrack.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cellSizeTrack.Properties.Maximum = 35;
            this.cellSizeTrack.Properties.Minimum = 18;
            this.cellSizeTrack.Size = new System.Drawing.Size(246, 23);
            this.cellSizeTrack.StyleController = this.layoutControl1;
            this.cellSizeTrack.TabIndex = 60;
            this.cellSizeTrack.Value = 18;
            this.cellSizeTrack.ValueChanged += new System.EventHandler(this.CellSizeTrackValueChanged);
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.AutoScroll = false;
            this.layoutControl1.AutoSize = true;
            this.layoutControl1.Controls.Add(this.cellSizeTrack);
            this.layoutControl1.Controls.Add(this.cellSizeLabel);
            this.layoutControl1.Controls.Add(this.radioGroup1);
            this.layoutControl1.Controls.Add(this.NewGameBtn);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(784, 58);
            this.layoutControl1.TabIndex = 57;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition6.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition6.Width = 300D;
            columnDefinition7.SizeType = System.Windows.Forms.SizeType.AutoSize;
            columnDefinition7.Width = 52D;
            columnDefinition8.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition8.Width = 250D;
            columnDefinition9.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition9.Width = 100D;
            columnDefinition10.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition10.Width = 80D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition6,
            columnDefinition7,
            columnDefinition8,
            columnDefinition9,
            columnDefinition10});
            rowDefinition2.Height = 38D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.AutoSize;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition2});
            this.Root.Size = new System.Drawing.Size(784, 58);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControlItem1.Control = this.NewGameBtn;
            this.layoutControlItem1.Location = new System.Drawing.Point(684, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnIndex = 4;
            this.layoutControlItem1.Size = new System.Drawing.Size(80, 38);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.radioGroup1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(300, 38);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControlItem3.Control = this.cellSizeLabel;
            this.layoutControlItem3.Location = new System.Drawing.Point(300, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem3.Size = new System.Drawing.Size(52, 38);
            this.layoutControlItem3.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControlItem4.Control = this.cellSizeTrack;
            this.layoutControlItem4.Location = new System.Drawing.Point(352, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem4.Size = new System.Drawing.Size(250, 38);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // separatorControl1
            // 
            this.separatorControl1.AutoSizeMode = true;
            this.separatorControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.separatorControl1.Location = new System.Drawing.Point(0, 58);
            this.separatorControl1.Margin = new System.Windows.Forms.Padding(0);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(0);
            this.separatorControl1.Size = new System.Drawing.Size(784, 1);
            this.separatorControl1.TabIndex = 58;
            // 
            // MinesweeperModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spreadsheetControl);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.layoutControl1);
            this.Name = "MinesweeperModule";
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellSizeTrack.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellSizeTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private SpreadsheetControl spreadsheetControl;
        private System.Windows.Forms.Timer timer1;
        private XtraEditors.LabelControl cellSizeLabel;
        private XtraEditors.SimpleButton NewGameBtn;
        private XtraEditors.RadioGroup radioGroup1;
        private XtraEditors.TrackBarControl cellSizeTrack;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraEditors.SeparatorControl separatorControl1;
    }
}
