namespace DevExpress.XtraCharts.Demos {
    partial class AnimationDemo {
        System.ComponentModel.IContainer components = null;

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
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButtonAnimate = new DevExpress.XtraEditors.SimpleButton();
            this.checkEditSeriesLabelsVisible = new DevExpress.XtraEditors.CheckEdit();
            this.comboBoxEditSeriesAnimation = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEditPointAnimation = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEditSeriesView = new DevExpress.XtraEditors.ComboBoxEdit();
            this.checkEditDiagramRotated = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditAxisXReversed = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditAxisYReversed = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroupRoot = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroupGeneral = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemSeriesView = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemShowSeriesLabels = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroupAnimation = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemAnimate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemPointAnimation = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemSeriesAnimation = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroupDiagramOptions = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemDiagramRotated = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemAxisYReversed = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemAxisXReversed = new DevExpress.XtraLayout.LayoutControlItem();
            this.sidePanelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).BeginInit();
            this.tabPaneOptions.SuspendLayout();
            this.tabNavigationPageOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditSeriesLabelsVisible.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSeriesAnimation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditPointAnimation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSeriesView.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditDiagramRotated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditAxisXReversed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditAxisYReversed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSeriesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemShowSeriesLabels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupAnimation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAnimate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemPointAnimation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSeriesAnimation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupDiagramOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemDiagramRotated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAxisYReversed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAxisXReversed)).BeginInit();
            this.SuspendLayout();
            // 
            // tabNavigationPageOptions
            // 
            this.tabNavigationPageOptions.Controls.Add(this.layoutControl);
            this.tabNavigationPageOptions.Size = new System.Drawing.Size(241, 538);
            // 
            // chart
            // 
            this.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart.Size = new System.Drawing.Size(546, 571);
            this.chart.TabIndex = 3;
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.simpleButtonAnimate);
            this.layoutControl.Controls.Add(this.checkEditSeriesLabelsVisible);
            this.layoutControl.Controls.Add(this.comboBoxEditSeriesAnimation);
            this.layoutControl.Controls.Add(this.comboBoxEditPointAnimation);
            this.layoutControl.Controls.Add(this.comboBoxEditSeriesView);
            this.layoutControl.Controls.Add(this.checkEditDiagramRotated);
            this.layoutControl.Controls.Add(this.checkEditAxisXReversed);
            this.layoutControl.Controls.Add(this.checkEditAxisYReversed);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(268, 270, 650, 398);
            this.layoutControl.Root = this.layoutControlGroupRoot;
            this.layoutControl.Size = new System.Drawing.Size(241, 538);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl1";
            // 
            // simpleButtonAnimate
            // 
            this.simpleButtonAnimate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonAnimate.Location = new System.Drawing.Point(12, 188);
            this.simpleButtonAnimate.Name = "simpleButtonAnimate";
            this.simpleButtonAnimate.Size = new System.Drawing.Size(217, 22);
            this.simpleButtonAnimate.StyleController = this.layoutControl;
            this.simpleButtonAnimate.TabIndex = 23;
            this.simpleButtonAnimate.Text = "Animate";
            this.simpleButtonAnimate.Click += new System.EventHandler(this.simpleButtonAnimate_Click);
            // 
            // checkEditSeriesLabelsVisible
            // 
            this.checkEditSeriesLabelsVisible.Location = new System.Drawing.Point(12, 66);
            this.checkEditSeriesLabelsVisible.Name = "checkEditSeriesLabelsVisible";
            this.checkEditSeriesLabelsVisible.Properties.Caption = "Series Labels Visible";
            this.checkEditSeriesLabelsVisible.Size = new System.Drawing.Size(217, 20);
            this.checkEditSeriesLabelsVisible.StyleController = this.layoutControl;
            this.checkEditSeriesLabelsVisible.TabIndex = 22;
            this.checkEditSeriesLabelsVisible.CheckedChanged += new System.EventHandler(this.checkEditSeriesLabelsVisible_CheckedChanged);
            // 
            // comboBoxEditSeriesAnimation
            // 
            this.comboBoxEditSeriesAnimation.Location = new System.Drawing.Point(107, 132);
            this.comboBoxEditSeriesAnimation.Name = "comboBoxEditSeriesAnimation";
            this.comboBoxEditSeriesAnimation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditSeriesAnimation.Properties.DropDownRows = 8;
            this.comboBoxEditSeriesAnimation.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditSeriesAnimation.Size = new System.Drawing.Size(122, 20);
            this.comboBoxEditSeriesAnimation.StyleController = this.layoutControl;
            this.comboBoxEditSeriesAnimation.TabIndex = 21;
            this.comboBoxEditSeriesAnimation.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditSeriesAnimation_SelectedValueChanged);
            // 
            // comboBoxEditPointAnimation
            // 
            this.comboBoxEditPointAnimation.Location = new System.Drawing.Point(107, 156);
            this.comboBoxEditPointAnimation.Name = "comboBoxEditPointAnimation";
            this.comboBoxEditPointAnimation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditPointAnimation.Properties.DropDownRows = 8;
            this.comboBoxEditPointAnimation.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditPointAnimation.Size = new System.Drawing.Size(122, 20);
            this.comboBoxEditPointAnimation.StyleController = this.layoutControl;
            this.comboBoxEditPointAnimation.TabIndex = 20;
            this.comboBoxEditPointAnimation.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditPointAnimation_SelectedIndexChanged);
            // 
            // comboBoxEditSeriesView
            // 
            this.comboBoxEditSeriesView.Location = new System.Drawing.Point(107, 34);
            this.comboBoxEditSeriesView.Name = "comboBoxEditSeriesView";
            this.comboBoxEditSeriesView.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditSeriesView.Properties.DropDownRows = 16;
            this.comboBoxEditSeriesView.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditSeriesView.Size = new System.Drawing.Size(122, 20);
            this.comboBoxEditSeriesView.StyleController = this.layoutControl;
            this.comboBoxEditSeriesView.TabIndex = 19;
            this.comboBoxEditSeriesView.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditSeriesView_SelectedIndexChanged);
            // 
            // checkEditDiagramRotated
            // 
            this.checkEditDiagramRotated.Location = new System.Drawing.Point(12, 256);
            this.checkEditDiagramRotated.Name = "checkEditDiagramRotated";
            this.checkEditDiagramRotated.Properties.Caption = "Diagram Rotated";
            this.checkEditDiagramRotated.Size = new System.Drawing.Size(217, 20);
            this.checkEditDiagramRotated.StyleController = this.layoutControl;
            this.checkEditDiagramRotated.TabIndex = 24;
            this.checkEditDiagramRotated.CheckedChanged += new System.EventHandler(this.checkEditDiagramRotated_CheckedChanged);
            // 
            // checkEditAxisXReversed
            // 
            this.checkEditAxisXReversed.Location = new System.Drawing.Point(12, 280);
            this.checkEditAxisXReversed.Name = "checkEditAxisXReversed";
            this.checkEditAxisXReversed.Properties.Caption = "Axis X Reversed";
            this.checkEditAxisXReversed.Size = new System.Drawing.Size(217, 20);
            this.checkEditAxisXReversed.StyleController = this.layoutControl;
            this.checkEditAxisXReversed.TabIndex = 25;
            this.checkEditAxisXReversed.CheckedChanged += new System.EventHandler(this.checkEditAxisXReversed_CheckedChanged);
            // 
            // checkEditAxisYReversed
            // 
            this.checkEditAxisYReversed.Location = new System.Drawing.Point(12, 304);
            this.checkEditAxisYReversed.Name = "checkEditAxisYReversed";
            this.checkEditAxisYReversed.Properties.Caption = "Axis Y Reversed";
            this.checkEditAxisYReversed.Size = new System.Drawing.Size(217, 20);
            this.checkEditAxisYReversed.StyleController = this.layoutControl;
            this.checkEditAxisYReversed.TabIndex = 26;
            this.checkEditAxisYReversed.CheckedChanged += new System.EventHandler(this.checkEditAxisYReversed_CheckedChanged);
            // 
            // layoutControlGroupRoot
            // 
            this.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupRoot.GroupBordersVisible = false;
            this.layoutControlGroupRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem,
            this.layoutControlGroupGeneral,
            this.layoutControlGroupAnimation,
            this.layoutControlGroupDiagramOptions});
            this.layoutControlGroupRoot.Name = "Root";
            this.layoutControlGroupRoot.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupRoot.Size = new System.Drawing.Size(241, 538);
            this.layoutControlGroupRoot.TextVisible = false;
            // 
            // emptySpaceItem
            // 
            this.emptySpaceItem.Location = new System.Drawing.Point(0, 336);
            this.emptySpaceItem.Name = "emptySpaceItem";
            this.emptySpaceItem.Size = new System.Drawing.Size(241, 202);
            // 
            // layoutControlGroupGeneral
            // 
            this.layoutControlGroupGeneral.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroupGeneral.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemSeriesView,
            this.layoutControlItemShowSeriesLabels});
            this.layoutControlGroupGeneral.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupGeneral.Name = "layoutControlGroupGeneral";
            this.layoutControlGroupGeneral.Size = new System.Drawing.Size(241, 98);
            this.layoutControlGroupGeneral.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupGeneral.Text = "General";
            // 
            // layoutControlItemSeriesView
            // 
            this.layoutControlItemSeriesView.Control = this.comboBoxEditSeriesView;
            this.layoutControlItemSeriesView.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemSeriesView.Name = "layoutControlItemSeriesView";
            this.layoutControlItemSeriesView.Size = new System.Drawing.Size(221, 24);
            this.layoutControlItemSeriesView.Text = "Series View:";
            this.layoutControlItemSeriesView.TextSize = new System.Drawing.Size(83, 13);
            // 
            // layoutControlItemShowSeriesLabels
            // 
            this.layoutControlItemShowSeriesLabels.Control = this.checkEditSeriesLabelsVisible;
            this.layoutControlItemShowSeriesLabels.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItemShowSeriesLabels.Name = "layoutControlItemShowSeriesLabels";
            this.layoutControlItemShowSeriesLabels.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 2);
            this.layoutControlItemShowSeriesLabels.Size = new System.Drawing.Size(221, 32);
            this.layoutControlItemShowSeriesLabels.TextVisible = false;
            // 
            // layoutControlGroupAnimation
            // 
            this.layoutControlGroupAnimation.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroupAnimation.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemAnimate,
            this.layoutControlItemPointAnimation,
            this.layoutControlItemSeriesAnimation});
            this.layoutControlGroupAnimation.Location = new System.Drawing.Point(0, 98);
            this.layoutControlGroupAnimation.Name = "layoutControlGroupAnimation";
            this.layoutControlGroupAnimation.Size = new System.Drawing.Size(241, 124);
            this.layoutControlGroupAnimation.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupAnimation.Text = "Animation";
            // 
            // layoutControlItemAnimate
            // 
            this.layoutControlItemAnimate.Control = this.simpleButtonAnimate;
            this.layoutControlItemAnimate.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItemAnimate.Name = "layoutControlItemAnimate";
            this.layoutControlItemAnimate.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 2);
            this.layoutControlItemAnimate.Size = new System.Drawing.Size(221, 34);
            this.layoutControlItemAnimate.TextVisible = false;
            // 
            // layoutControlItemPointAnimation
            // 
            this.layoutControlItemPointAnimation.Control = this.comboBoxEditPointAnimation;
            this.layoutControlItemPointAnimation.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItemPointAnimation.Name = "layoutControlItemPointAnimation";
            this.layoutControlItemPointAnimation.Size = new System.Drawing.Size(221, 24);
            this.layoutControlItemPointAnimation.Text = "Point Animation:";
            this.layoutControlItemPointAnimation.TextSize = new System.Drawing.Size(83, 13);
            // 
            // layoutControlItemSeriesAnimation
            // 
            this.layoutControlItemSeriesAnimation.Control = this.comboBoxEditSeriesAnimation;
            this.layoutControlItemSeriesAnimation.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemSeriesAnimation.Name = "layoutControlItemSeriesAnimation";
            this.layoutControlItemSeriesAnimation.Size = new System.Drawing.Size(221, 24);
            this.layoutControlItemSeriesAnimation.Text = "Series Animation:";
            this.layoutControlItemSeriesAnimation.TextSize = new System.Drawing.Size(83, 13);
            // 
            // layoutControlGroupDiagramOptions
            // 
            this.layoutControlGroupDiagramOptions.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroupDiagramOptions.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemDiagramRotated,
            this.layoutControlItemAxisYReversed,
            this.layoutControlItemAxisXReversed});
            this.layoutControlGroupDiagramOptions.Location = new System.Drawing.Point(0, 222);
            this.layoutControlGroupDiagramOptions.Name = "layoutControlGroupDiagramOptions";
            this.layoutControlGroupDiagramOptions.Size = new System.Drawing.Size(241, 114);
            this.layoutControlGroupDiagramOptions.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupDiagramOptions.Text = "Diagram Options";
            // 
            // layoutControlItemDiagramRotated
            // 
            this.layoutControlItemDiagramRotated.Control = this.checkEditDiagramRotated;
            this.layoutControlItemDiagramRotated.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemDiagramRotated.Name = "layoutControlItemDiagramRotated";
            this.layoutControlItemDiagramRotated.Size = new System.Drawing.Size(221, 24);
            this.layoutControlItemDiagramRotated.TextVisible = false;
            // 
            // layoutControlItemAxisYReversed
            // 
            this.layoutControlItemAxisYReversed.Control = this.checkEditAxisYReversed;
            this.layoutControlItemAxisYReversed.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItemAxisYReversed.Name = "layoutControlItemAxisYReversed";
            this.layoutControlItemAxisYReversed.Size = new System.Drawing.Size(221, 24);
            this.layoutControlItemAxisYReversed.TextVisible = false;
            // 
            // layoutControlItemAxisXReversed
            // 
            this.layoutControlItemAxisXReversed.Control = this.checkEditAxisXReversed;
            this.layoutControlItemAxisXReversed.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItemAxisXReversed.Name = "layoutControlItemAxisXReversed";
            this.layoutControlItemAxisXReversed.Size = new System.Drawing.Size(221, 24);
            this.layoutControlItemAxisXReversed.TextVisible = false;
            // 
            // AnimationDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "AnimationDemo";
            this.Controls.SetChildIndex(this.sidePanelOptions, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            this.sidePanelOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).EndInit();
            this.tabPaneOptions.ResumeLayout(false);
            this.tabNavigationPageOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEditSeriesLabelsVisible.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSeriesAnimation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditPointAnimation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSeriesView.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditDiagramRotated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditAxisXReversed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditAxisYReversed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSeriesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemShowSeriesLabels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupAnimation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAnimate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemPointAnimation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSeriesAnimation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupDiagramOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemDiagramRotated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAxisYReversed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAxisXReversed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        ChartControl chart;
        XtraLayout.LayoutControl layoutControl;
        XtraLayout.LayoutControlGroup layoutControlGroupRoot;
        XtraEditors.ComboBoxEdit comboBoxEditSeriesView;
        XtraLayout.LayoutControlItem layoutControlItemSeriesView;
        XtraLayout.EmptySpaceItem emptySpaceItem;
        XtraEditors.ComboBoxEdit comboBoxEditPointAnimation;
        XtraLayout.LayoutControlItem layoutControlItemPointAnimation;
        XtraEditors.ComboBoxEdit comboBoxEditSeriesAnimation;
        XtraLayout.LayoutControlItem layoutControlItemSeriesAnimation;
        XtraEditors.CheckEdit checkEditSeriesLabelsVisible;
        XtraLayout.LayoutControlItem layoutControlItemShowSeriesLabels;
        XtraEditors.SimpleButton simpleButtonAnimate;
        XtraLayout.LayoutControlItem layoutControlItemAnimate;
        XtraLayout.LayoutControlGroup layoutControlGroupGeneral;
        XtraLayout.LayoutControlGroup layoutControlGroupAnimation;
        XtraEditors.CheckEdit checkEditDiagramRotated;
        XtraEditors.CheckEdit checkEditAxisXReversed;
        XtraEditors.CheckEdit checkEditAxisYReversed;
        XtraLayout.LayoutControlGroup layoutControlGroupDiagramOptions;
        XtraLayout.LayoutControlItem layoutControlItemDiagramRotated;
        XtraLayout.LayoutControlItem layoutControlItemAxisYReversed;
        XtraLayout.LayoutControlItem layoutControlItemAxisXReversed;
    }
}
