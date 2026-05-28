using DevExpress.Diagram.Core;
using DevExpress.Diagram.Core.Layout;
using DevExpress.XtraEditors;

namespace DevExpress.XtraDiagram.Demos {
    partial class OrgChartLayoutModule {
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
            this.directionGroup = new DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup();
            this.spacingGroup = new DevExpress.XtraDiagram.Demos.GroupControlWithTrackBars();
            this.alignmentGroup = new DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup();
            this.tipOverOffsetModeGroup = new DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup();
            this.tipOverDirectionGroup = new DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup();
            this.spinEditGroup = new DevExpress.XtraDiagram.Demos.GroupControlWithSpinEdit();
            bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.containerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directionGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directionGroup.RadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spacingGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignmentGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignmentGroup.RadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipOverOffsetModeGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipOverOffsetModeGroup.RadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipOverDirectionGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipOverDirectionGroup.RadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditGroup.SpinEdit.Properties)).BeginInit();
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
            bindingSource.DataMember = "OptionsOrgChartLayout";
            bindingSource.DataSource = this.diagramControl;
            bindingSource.Position = 0;
            // 
            // directionGroup
            // 
            this.directionGroup.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.directionGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.directionGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.directionGroup.Location = new System.Drawing.Point(0, 0);
            this.directionGroup.Name = "directionGroup";
            this.directionGroup.Padding = new System.Windows.Forms.Padding(12);
            // 
            // 
            // 
            this.directionGroup.RadioGroup.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", bindingSource, "Direction", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.directionGroup.RadioGroup.EditValue = DevExpress.Diagram.Core.Layout.LayoutDirection.TopToBottom;
            this.directionGroup.RadioGroup.Location = new System.Drawing.Point(0, 0);
            this.directionGroup.RadioGroup.Name = "";
            this.directionGroup.RadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.LayoutDirection.TopToBottom, "Top to Bottom"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.LayoutDirection.BottomToTop, "Bottom to Top"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.LayoutDirection.LeftToRight, "Left to Right"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.LayoutDirection.RightToLeft, "Right to Left")});
            this.directionGroup.RadioGroup.TabIndex = 0;
            this.directionGroup.RadioGroup.SelectedIndexChanged += new System.EventHandler(this.RadioGroupSelectedItemChanged);
            this.directionGroup.Size = new System.Drawing.Size(232, 118);
            this.directionGroup.TabIndex = 5;
            this.directionGroup.Text = "Direction";
            // 
            // spacingGroup
            // 
            this.spacingGroup.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.spacingGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacingGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.spacingGroup.Location = new System.Drawing.Point(0, 514);
            this.spacingGroup.Name = "spacingGroup";
            this.spacingGroup.Padding = new System.Windows.Forms.Padding(12);
            this.spacingGroup.Size = new System.Drawing.Size(232, 46);
            this.spacingGroup.TabIndex = 0;
            this.spacingGroup.Text = "Spacing";
            trackBarSettings1.Binding = new System.Windows.Forms.Binding("EditValue", bindingSource, "HierarchySpacing", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
            trackBarSettings1.Caption = "Hierarchy";
            trackBarSettings1.LargeChange = 0;
            trackBarSettings1.Max = 150;
            trackBarSettings1.Min = 20;
            trackBarSettings1.SmallChange = 15;
            trackBarSettings2.Binding = new System.Windows.Forms.Binding("EditValue", bindingSource, "NodeSpacing", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
            trackBarSettings2.Caption = "Nodes";
            trackBarSettings2.LargeChange = 0;
            trackBarSettings2.Max = 150;
            trackBarSettings2.Min = 20;
            trackBarSettings2.SmallChange = 15;
            this.spacingGroup.TrackBarsSettings.Add(trackBarSettings1);
            this.spacingGroup.TrackBarsSettings.Add(trackBarSettings2);
            this.spacingGroup.TrackBarsValueChanged += new System.EventHandler(this.TrackBarValueChanged);
            // 
            // alignmentGroup
            // 
            this.alignmentGroup.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.alignmentGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.alignmentGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.alignmentGroup.Location = new System.Drawing.Point(0, 354);
            this.alignmentGroup.Name = "alignmentGroup";
            this.alignmentGroup.Padding = new System.Windows.Forms.Padding(12);
            // 
            // 
            // 
            this.alignmentGroup.RadioGroup.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", bindingSource, "TreeAlignment", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.alignmentGroup.RadioGroup.EditValue = DevExpress.Diagram.Core.Alignment.Center;
            this.alignmentGroup.RadioGroup.Location = new System.Drawing.Point(0, 0);
            this.alignmentGroup.RadioGroup.Name = "";
            this.alignmentGroup.RadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Alignment.Near, "Near"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Alignment.Center, "Center"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Alignment.Far, "Far")});
            this.alignmentGroup.RadioGroup.TabIndex = 0;
            this.alignmentGroup.RadioGroup.SelectedIndexChanged += new System.EventHandler(this.RadioGroupSelectedItemChanged);
            this.alignmentGroup.Size = new System.Drawing.Size(232, 118);
            this.alignmentGroup.TabIndex = 2;
            this.alignmentGroup.Text = "Tree Alignment";
            // 
            // tipOverOffsetModeGroup
            // 
            this.tipOverOffsetModeGroup.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.tipOverOffsetModeGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.tipOverOffsetModeGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.tipOverOffsetModeGroup.Location = new System.Drawing.Point(0, 236);
            this.tipOverOffsetModeGroup.Name = "tipOverOffsetModeGroup";
            this.tipOverOffsetModeGroup.Padding = new System.Windows.Forms.Padding(12);
            // 
            // 
            // 
            this.tipOverOffsetModeGroup.RadioGroup.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", bindingSource, "TipOverOffsetMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tipOverOffsetModeGroup.RadioGroup.EditValue = DevExpress.Diagram.Core.Layout.TipOverOffsetMode.Center;
            this.tipOverOffsetModeGroup.RadioGroup.Location = new System.Drawing.Point(0, 0);
            this.tipOverOffsetModeGroup.RadioGroup.Name = "";
            this.tipOverOffsetModeGroup.RadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.TipOverOffsetMode.Center, "Center"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.TipOverOffsetMode.Edge, "Edge")});
            this.tipOverOffsetModeGroup.RadioGroup.TabIndex = 0;
            this.tipOverOffsetModeGroup.RadioGroup.SelectedIndexChanged += new System.EventHandler(this.RadioGroupSelectedItemChanged);
            this.tipOverOffsetModeGroup.Size = new System.Drawing.Size(232, 118);
            this.tipOverOffsetModeGroup.TabIndex = 3;
            this.tipOverOffsetModeGroup.Text = "Tip Over Offset Mode";
            // 
            // tipOverDirectionGroup
            // 
            this.tipOverDirectionGroup.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.tipOverDirectionGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.tipOverDirectionGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.tipOverDirectionGroup.Location = new System.Drawing.Point(0, 118);
            this.tipOverDirectionGroup.Name = "tipOverDirectionGroup";
            this.tipOverDirectionGroup.Padding = new System.Windows.Forms.Padding(12);
            // 
            // 
            // 
            this.tipOverDirectionGroup.RadioGroup.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", bindingSource, "TipOverDirection", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tipOverDirectionGroup.RadioGroup.EditValue = DevExpress.Diagram.Core.Layout.TipOverDirection.LeftToRight;
            this.tipOverDirectionGroup.RadioGroup.Location = new System.Drawing.Point(0, 0);
            this.tipOverDirectionGroup.RadioGroup.Name = "";
            this.tipOverDirectionGroup.RadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.TipOverDirection.LeftToRight, "Left to Right"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.TipOverDirection.RightToLeft, "Right to Left")});
            this.tipOverDirectionGroup.RadioGroup.TabIndex = 0;
            this.tipOverDirectionGroup.RadioGroup.SelectedIndexChanged += new System.EventHandler(this.RadioGroupSelectedItemChanged);
            this.tipOverDirectionGroup.Size = new System.Drawing.Size(232, 118);
            this.tipOverDirectionGroup.TabIndex = 4;
            this.tipOverDirectionGroup.Text = "Tip Over Direction";
            // 
            // spinEditGroup
            // 
            this.spinEditGroup.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.spinEditGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.spinEditGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.spinEditGroup.Location = new System.Drawing.Point(0, 472);
            this.spinEditGroup.Name = "spinEditGroup";
            this.spinEditGroup.Padding = new System.Windows.Forms.Padding(12);
            this.spinEditGroup.Size = new System.Drawing.Size(232, 42);
            // 
            // 
            // 
            this.spinEditGroup.SpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", bindingSource, "TreeLevelCount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.spinEditGroup.SpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditGroup.SpinEdit.Location = new System.Drawing.Point(0, 0);
            this.spinEditGroup.SpinEdit.Name = "";
            this.spinEditGroup.SpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditGroup.SpinEdit.Properties.IsFloatValue = false;
            this.spinEditGroup.SpinEdit.Properties.Mask.EditMask = "N00";
            this.spinEditGroup.SpinEdit.TabIndex = 0;
            this.spinEditGroup.SpinEdit.ValueChanged += new System.EventHandler(this.TrackBarValueChanged);
            this.spinEditGroup.TabIndex = 1;
            this.spinEditGroup.Text = "Tree Level Count";
            // 
            // OrgChartLayoutModule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Name = "OrgChartLayoutModule";
            this.OptionsPageControls.Add(this.spacingGroup);
            this.OptionsPageControls.Add(this.spinEditGroup);
            this.OptionsPageControls.Add(this.alignmentGroup);
            this.OptionsPageControls.Add(this.tipOverOffsetModeGroup);
            this.OptionsPageControls.Add(this.tipOverDirectionGroup);
            this.OptionsPageControls.Add(this.directionGroup);
            this.Size = new System.Drawing.Size(793, 581);
            this.containerControl.ResumeLayout(false);
            this.containerControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directionGroup.RadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directionGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spacingGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignmentGroup.RadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignmentGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipOverOffsetModeGroup.RadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipOverOffsetModeGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipOverDirectionGroup.RadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipOverDirectionGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditGroup.SpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditGroup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupControlWithRadioGroup directionGroup;
        private GroupControlWithTrackBars spacingGroup;
        private GroupControlWithRadioGroup alignmentGroup;
        private GroupControlWithRadioGroup tipOverOffsetModeGroup;
        private GroupControlWithRadioGroup tipOverDirectionGroup;
        private GroupControlWithSpinEdit spinEditGroup;
    }
}
