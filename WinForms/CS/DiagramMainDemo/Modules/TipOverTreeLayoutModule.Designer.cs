using DevExpress.Diagram.Core.Layout;

namespace DevExpress.XtraDiagram.Demos {
    partial class TipOverTreeLayoutModule {
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
            this.tipOverOffsetModeGroup = new DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup();
            this.tipOverDirectionGroup = new DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup();
            this.verticalSpacingGroup = new DevExpress.XtraDiagram.Demos.GroupControlWithTrackBar();
            this.offsetGroup = new DevExpress.XtraDiagram.Demos.GroupControlWithTrackBar();
            bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.containerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipOverOffsetModeGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipOverOffsetModeGroup.RadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipOverDirectionGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipOverDirectionGroup.RadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalSpacingGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // containerControl
            // 
            this.containerControl.Size = new System.Drawing.Size(539, 581);
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
            this.diagramControl.Size = new System.Drawing.Size(539, 404);
            // 
            // bindingSource
            // 
            bindingSource.DataMember = "OptionsTipOverTreeLayout";
            bindingSource.DataSource = this.diagramControl;
            bindingSource.Position = 0;
            // 
            // tipOverOffsetModeGroup
            // 
            this.tipOverOffsetModeGroup.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.tipOverOffsetModeGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.tipOverOffsetModeGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.tipOverOffsetModeGroup.Location = new System.Drawing.Point(0, 118);
            this.tipOverOffsetModeGroup.Name = "tipOverOffsetModeGroup";
            this.tipOverOffsetModeGroup.Padding = new System.Windows.Forms.Padding(12);
            // 
            // 
            // 
            this.tipOverOffsetModeGroup.RadioGroup.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", bindingSource, "OffsetMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tipOverOffsetModeGroup.RadioGroup.EditValue = DevExpress.Diagram.Core.Layout.TipOverOffsetMode.Center;
            this.tipOverOffsetModeGroup.RadioGroup.Location = new System.Drawing.Point(0, 0);
            this.tipOverOffsetModeGroup.RadioGroup.Name = "";
            this.tipOverOffsetModeGroup.RadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.TipOverOffsetMode.Center, "Center"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.TipOverOffsetMode.Edge, "Edge")});
            this.tipOverOffsetModeGroup.RadioGroup.TabIndex = 0;
            this.tipOverOffsetModeGroup.RadioGroup.SelectedIndexChanged += new System.EventHandler(this.RadioGroupSelectedItemChanged);
            this.tipOverOffsetModeGroup.Size = new System.Drawing.Size(249, 118);
            this.tipOverOffsetModeGroup.TabIndex = 2;
            this.tipOverOffsetModeGroup.Text = "Tip Over Offset Mode";
            // 
            // tipOverDirectionGroup
            // 
            this.tipOverDirectionGroup.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.tipOverDirectionGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.tipOverDirectionGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.tipOverDirectionGroup.Location = new System.Drawing.Point(0, 0);
            this.tipOverDirectionGroup.Name = "tipOverDirectionGroup";
            this.tipOverDirectionGroup.Padding = new System.Windows.Forms.Padding(12);
            // 
            // 
            // 
            this.tipOverDirectionGroup.RadioGroup.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", bindingSource, "Direction", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tipOverDirectionGroup.RadioGroup.EditValue = DevExpress.Diagram.Core.Layout.TipOverDirection.LeftToRight;
            this.tipOverDirectionGroup.RadioGroup.Location = new System.Drawing.Point(0, 0);
            this.tipOverDirectionGroup.RadioGroup.Name = "";
            this.tipOverDirectionGroup.RadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.TipOverDirection.LeftToRight, "Left to Right"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.TipOverDirection.RightToLeft, "Right to Left")});
            this.tipOverDirectionGroup.RadioGroup.TabIndex = 0;
            this.tipOverDirectionGroup.RadioGroup.SelectedIndexChanged += new System.EventHandler(this.RadioGroupSelectedItemChanged);
            this.tipOverDirectionGroup.Size = new System.Drawing.Size(249, 118);
            this.tipOverDirectionGroup.TabIndex = 3;
            this.tipOverDirectionGroup.Text = "Tip Over Direction";
            // 
            // verticalSpacingGroup
            // 
            this.verticalSpacingGroup.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.verticalSpacingGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.verticalSpacingGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.verticalSpacingGroup.Location = new System.Drawing.Point(0, 309);
            this.verticalSpacingGroup.Name = "verticalSpacingGroup";
            this.verticalSpacingGroup.Padding = new System.Windows.Forms.Padding(12);
            this.verticalSpacingGroup.Size = new System.Drawing.Size(249, 73);
            this.verticalSpacingGroup.TabIndex = 0;
            this.verticalSpacingGroup.Text = "Vertical Spacing";
            this.verticalSpacingGroup.TrackBarSettings.Binding = new System.Windows.Forms.Binding("EditValue", bindingSource, "VerticalSpacing", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
            this.verticalSpacingGroup.TrackBarSettings.Caption = null;
            this.verticalSpacingGroup.TrackBarSettings.LargeChange = 0;
            this.verticalSpacingGroup.TrackBarSettings.Max = 150;
            this.verticalSpacingGroup.TrackBarSettings.Min = 20;
            this.verticalSpacingGroup.TrackBarSettings.SmallChange = 15;
            this.verticalSpacingGroup.TrackBarValueChanged += new System.EventHandler(this.TrackBarValueChanged);
            // 
            // offsetGroup
            // 
            this.offsetGroup.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.offsetGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.offsetGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.offsetGroup.Location = new System.Drawing.Point(0, 236);
            this.offsetGroup.Name = "offsetGroup";
            this.offsetGroup.Padding = new System.Windows.Forms.Padding(12);
            this.offsetGroup.Size = new System.Drawing.Size(249, 73);
            this.offsetGroup.TabIndex = 1;
            this.offsetGroup.Text = "Offset";
            this.offsetGroup.TrackBarSettings.Binding = new System.Windows.Forms.Binding("EditValue", bindingSource, "Offset", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
            this.offsetGroup.TrackBarSettings.Caption = null;
            this.offsetGroup.TrackBarSettings.LargeChange = 0;
            this.offsetGroup.TrackBarSettings.Max = 150;
            this.offsetGroup.TrackBarSettings.Min = 30;
            this.offsetGroup.TrackBarSettings.SmallChange = 15;
            this.offsetGroup.TrackBarValueChanged += new System.EventHandler(this.TrackBarValueChanged);
            // 
            // TipOverTreeLayoutModule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Name = "TipOverTreeLayoutModule";
            this.OptionsPageControls.Add(this.verticalSpacingGroup);
            this.OptionsPageControls.Add(this.offsetGroup);
            this.OptionsPageControls.Add(this.tipOverOffsetModeGroup);
            this.OptionsPageControls.Add(this.tipOverDirectionGroup);
            this.containerControl.ResumeLayout(false);
            this.containerControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipOverOffsetModeGroup.RadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipOverOffsetModeGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipOverDirectionGroup.RadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipOverDirectionGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalSpacingGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetGroup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupControlWithTrackBar verticalSpacingGroup;
        private GroupControlWithRadioGroup tipOverDirectionGroup;
        private GroupControlWithRadioGroup tipOverOffsetModeGroup;
        private GroupControlWithTrackBar offsetGroup;
    }
}
