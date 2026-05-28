using System.Windows.Forms;

namespace DevExpress.XtraDiagram.Demos {
    partial class MindMapTreeLayoutModule {
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
            System.Windows.Forms.BindingSource bindingSource;
            DevExpress.XtraDiagram.Demos.TrackBarSettings trackBarSettings1 = new DevExpress.XtraDiagram.Demos.TrackBarSettings();
            DevExpress.XtraDiagram.Demos.TrackBarSettings trackBarSettings2 = new DevExpress.XtraDiagram.Demos.TrackBarSettings();
            DevExpress.XtraDiagram.Demos.TrackBarSettings trackBarSettings3 = new DevExpress.XtraDiagram.Demos.TrackBarSettings();
            this.addChildGroup = new DevExpress.XtraDiagram.Demos.OptionsPanelGroupControl();
            this.addChildButton = new DevExpress.XtraEditors.SimpleButton();
            this.orientationGroup = new DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup();
            this.subTreeAlignmentGroup = new DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup();
            this.spacingGroup = new DevExpress.XtraDiagram.Demos.GroupControlWithTrackBars();
            this.subTreeDefaultSplitModeGroup = new DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup();
            bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.containerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addChildGroup)).BeginInit();
            this.addChildGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orientationGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orientationGroup.RadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subTreeAlignmentGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subTreeAlignmentGroup.RadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spacingGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subTreeDefaultSplitModeGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subTreeDefaultSplitModeGroup.RadioGroup.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // containerControl
            // 
            this.containerControl.Size = new System.Drawing.Size(543, 581);
            this.containerControl.Controls.SetChildIndex(this.diagramControl, 0);
            // 
            // diagramControl
            // 
            this.diagramControl.Location = new System.Drawing.Point(0, 150);
            this.diagramControl.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "BasicShapes",
            "BasicFlowchartShapes"});
            this.diagramControl.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.None;
            this.diagramControl.OptionsView.PageSize = new System.Drawing.SizeF(800F, 600F);
            this.diagramControl.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.diagramControl.OptionsView.PropertiesPanelVisibility = DevExpress.Diagram.Core.PropertiesPanelVisibility.Closed;
            this.diagramControl.OptionsView.Theme = DevExpress.Diagram.Core.DiagramThemes.Linear;
            this.diagramControl.OptionsView.ToolboxVisibility = DevExpress.Diagram.Core.ToolboxVisibility.Closed;
            this.diagramControl.Size = new System.Drawing.Size(543, 404);
            // 
            // bindingSource
            // 
            bindingSource.DataMember = "OptionsMindMapTreeLayout";
            bindingSource.DataSource = this.diagramControl;
            bindingSource.Position = 0;
            // 
            // addChildGroup
            // 
            this.addChildGroup.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.addChildGroup.Controls.Add(this.addChildButton);
            this.addChildGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.addChildGroup.Location = new System.Drawing.Point(0, 634);
            this.addChildGroup.Name = "addChildGroup";
            this.addChildGroup.Padding = new System.Windows.Forms.Padding(12, 0, 12, 12);
            this.addChildGroup.Size = new System.Drawing.Size(232, 35);
            this.addChildGroup.TabIndex = 0;
            // 
            // addChildButton
            // 
            this.addChildButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addChildButton.Enabled = false;
            this.addChildButton.Location = new System.Drawing.Point(12, 0);
            this.addChildButton.Name = "addChildButton";
            this.addChildButton.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.addChildButton.Size = new System.Drawing.Size(208, 23);
            this.addChildButton.TabIndex = 9;
            this.addChildButton.Text = "Add Child";
            this.addChildButton.Click += new System.EventHandler(this.AddChild);
            // 
            // orientationGroup
            // 
            this.orientationGroup.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.orientationGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.orientationGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.orientationGroup.Location = new System.Drawing.Point(0, 0);
            this.orientationGroup.Name = "orientationGroup";
            this.orientationGroup.Padding = new System.Windows.Forms.Padding(12);
            // 
            // 
            // 
            this.orientationGroup.RadioGroup.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", bindingSource, "Orientation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.orientationGroup.RadioGroup.EditValue = System.Windows.Forms.Orientation.Horizontal;
            this.orientationGroup.RadioGroup.Location = new System.Drawing.Point(0, 0);
            this.orientationGroup.RadioGroup.Name = "";
            this.orientationGroup.RadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(System.Windows.Forms.Orientation.Horizontal, "Horizontal"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(System.Windows.Forms.Orientation.Vertical, "Vertical")});
            this.orientationGroup.RadioGroup.TabIndex = 0;
            this.orientationGroup.RadioGroup.SelectedIndexChanged += new System.EventHandler(this.RadioGroupSelectedItemChanged);
            this.orientationGroup.Size = new System.Drawing.Size(232, 142);
            this.orientationGroup.TabIndex = 4;
            this.orientationGroup.Text = "Orientation";
            // 
            // subTreeAlignmentGroup
            // 
            this.subTreeAlignmentGroup.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.subTreeAlignmentGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.subTreeAlignmentGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.subTreeAlignmentGroup.Location = new System.Drawing.Point(0, 142);
            this.subTreeAlignmentGroup.Name = "subTreeAlignmentGroup";
            this.subTreeAlignmentGroup.Padding = new System.Windows.Forms.Padding(12);
            // 
            // 
            // 
            this.subTreeAlignmentGroup.RadioGroup.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", bindingSource, "SubTreeAlignment", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.subTreeAlignmentGroup.RadioGroup.EditValue = DevExpress.Diagram.Core.Alignment.Center;
            this.subTreeAlignmentGroup.RadioGroup.Location = new System.Drawing.Point(0, 0);
            this.subTreeAlignmentGroup.RadioGroup.Name = "";
            this.subTreeAlignmentGroup.RadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Alignment.Near, "Near"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Alignment.Center, "Center"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Alignment.Far, "Far")});
            this.subTreeAlignmentGroup.RadioGroup.TabIndex = 0;
            this.subTreeAlignmentGroup.RadioGroup.SelectedIndexChanged += new System.EventHandler(this.RadioGroupSelectedItemChanged);
            this.subTreeAlignmentGroup.Size = new System.Drawing.Size(232, 142);
            this.subTreeAlignmentGroup.TabIndex = 3;
            this.subTreeAlignmentGroup.Text = "Sub Tree Alignment";
            // 
            // spacingGroup
            // 
            this.spacingGroup.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.spacingGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacingGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.spacingGroup.Location = new System.Drawing.Point(0, 426);
            this.spacingGroup.Name = "spacingGroup";
            this.spacingGroup.Padding = new System.Windows.Forms.Padding(12);
            this.spacingGroup.Size = new System.Drawing.Size(232, 208);
            this.spacingGroup.TabIndex = 1;
            this.spacingGroup.Text = "Spacing";
            trackBarSettings1.Binding = new System.Windows.Forms.Binding("EditValue", bindingSource, "HierarchySpacing", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
            trackBarSettings1.Caption = "Hierarchy";
            trackBarSettings1.LargeChange = 30;
            trackBarSettings1.Max = 300;
            trackBarSettings1.Min = 80;
            trackBarSettings1.SmallChange = 10;
            trackBarSettings2.Binding = new System.Windows.Forms.Binding("EditValue", bindingSource, "NodeSpacing", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
            trackBarSettings2.Caption = "Node";
            trackBarSettings2.LargeChange = 15;
            trackBarSettings2.Max = 150;
            trackBarSettings2.Min = 10;
            trackBarSettings2.SmallChange = 5;
            trackBarSettings3.Binding = new System.Windows.Forms.Binding("EditValue", bindingSource, "RootSpacing", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
            trackBarSettings3.Caption = "Root";
            trackBarSettings3.LargeChange = 30;
            trackBarSettings3.Max = 300;
            trackBarSettings3.Min = 80;
            trackBarSettings3.SmallChange = 10;
            this.spacingGroup.TrackBarsSettings.Add(trackBarSettings1);
            this.spacingGroup.TrackBarsSettings.Add(trackBarSettings2);
            this.spacingGroup.TrackBarsSettings.Add(trackBarSettings3);
            this.spacingGroup.TrackBarsValueChanged += new System.EventHandler(this.TrackBarValueChanged);
            // 
            // subTreeDefaultSplitModeGroup
            // 
            this.subTreeDefaultSplitModeGroup.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.subTreeDefaultSplitModeGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.subTreeDefaultSplitModeGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.subTreeDefaultSplitModeGroup.Location = new System.Drawing.Point(0, 284);
            this.subTreeDefaultSplitModeGroup.Name = "subTreeDefaultSplitModeGroup";
            this.subTreeDefaultSplitModeGroup.Padding = new System.Windows.Forms.Padding(12);
            // 
            // 
            // 
            this.subTreeDefaultSplitModeGroup.RadioGroup.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", bindingSource, "SubTreeDefaultSplitMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.subTreeDefaultSplitModeGroup.RadioGroup.EditValue = DevExpress.Diagram.Core.Layout.SubTreeDefaultSplitMode.RootChildrenCount;
            this.subTreeDefaultSplitModeGroup.RadioGroup.Location = new System.Drawing.Point(0, 0);
            this.subTreeDefaultSplitModeGroup.RadioGroup.Name = "";
            this.subTreeDefaultSplitModeGroup.RadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.SubTreeDefaultSplitMode.RootChildrenCount, "Root Children Count"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.SubTreeDefaultSplitMode.TreeNodesCount, "Tree Nodes Count"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.SubTreeDefaultSplitMode.Breadth, "Breadth"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.SubTreeDefaultSplitMode.Area, "Area")});
            this.subTreeDefaultSplitModeGroup.RadioGroup.TabIndex = 0;
            this.subTreeDefaultSplitModeGroup.RadioGroup.SelectedIndexChanged += new System.EventHandler(this.RadioGroupSelectedItemChanged);
            this.subTreeDefaultSplitModeGroup.Size = new System.Drawing.Size(232, 142);
            this.subTreeDefaultSplitModeGroup.TabIndex = 2;
            this.subTreeDefaultSplitModeGroup.Text = "Sub Tree Default Split Mode";
            // 
            // MindMapTreeLayoutModule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Name = "MindMapTreeLayoutModule";
            this.OptionsPageControls.Add(this.addChildGroup);
            this.OptionsPageControls.Add(this.spacingGroup);
            this.OptionsPageControls.Add(this.subTreeDefaultSplitModeGroup);
            this.OptionsPageControls.Add(this.subTreeAlignmentGroup);
            this.OptionsPageControls.Add(this.orientationGroup);
            this.Size = new System.Drawing.Size(793, 581);
            this.containerControl.ResumeLayout(false);
            this.containerControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addChildGroup)).EndInit();
            this.addChildGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orientationGroup.RadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orientationGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subTreeAlignmentGroup.RadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subTreeAlignmentGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spacingGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subTreeDefaultSplitModeGroup.RadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subTreeDefaultSplitModeGroup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private OptionsPanelGroupControl addChildGroup;
        private GroupControlWithRadioGroup orientationGroup;
        private GroupControlWithRadioGroup subTreeAlignmentGroup;
        private GroupControlWithTrackBars spacingGroup;
        private GroupControlWithRadioGroup subTreeDefaultSplitModeGroup;
        private XtraEditors.SimpleButton addChildButton;
    }
}
