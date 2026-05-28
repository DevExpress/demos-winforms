using DevExpress.Diagram.Core.Layout;

namespace DevExpress.XtraDiagram.Demos {
    partial class CircularLayoutModule {
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
            this.startAngleGroup = new DevExpress.XtraDiagram.Demos.GroupControlWithTrackBar();
            this.circularOrderGroup = new DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup();
            this.nodesSpacingGroup = new DevExpress.XtraDiagram.Demos.GroupControlWithTrackBar();
            bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.containerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startAngleGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularOrderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularOrderGroup.RadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodesSpacingGroup)).BeginInit();
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
            bindingSource.DataMember = "OptionsCircularLayout";
            bindingSource.DataSource = this.diagramControl;
            bindingSource.Position = 0;
            // 
            // startAngleGroup
            // 
            this.startAngleGroup.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.startAngleGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.startAngleGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.startAngleGroup.Location = new System.Drawing.Point(0, 118);
            this.startAngleGroup.Name = "startAngleGroup";
            this.startAngleGroup.Padding = new System.Windows.Forms.Padding(12);
            this.startAngleGroup.Size = new System.Drawing.Size(249, 89);
            this.startAngleGroup.TabIndex = 1;
            this.startAngleGroup.Text = "Start Angle";
            this.startAngleGroup.TrackBarSettings.Binding = new System.Windows.Forms.Binding("EditValue", bindingSource, "StartAngle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
            this.startAngleGroup.TrackBarSettings.Caption = null;
            this.startAngleGroup.TrackBarSettings.Max = 360;
            this.startAngleGroup.TrackBarSettings.Min = 0;
            this.startAngleGroup.TrackBarSettings.SmallChange = 15;
            this.startAngleGroup.TrackBarValueChanged += new System.EventHandler(this.TrackBarValueChanged);
            // 
            // circularOrderGroup
            // 
            this.circularOrderGroup.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.circularOrderGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.circularOrderGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.circularOrderGroup.Location = new System.Drawing.Point(0, 0);
            this.circularOrderGroup.Name = "circularOrderGroup";
            this.circularOrderGroup.Padding = new System.Windows.Forms.Padding(12);
            // 
            // 
            // 
            this.circularOrderGroup.RadioGroup.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", bindingSource, "Order", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.circularOrderGroup.RadioGroup.EditValue = DevExpress.Diagram.Core.Layout.CircularLayoutOrder.Optimal;
            this.circularOrderGroup.RadioGroup.Location = new System.Drawing.Point(0, 0);
            this.circularOrderGroup.RadioGroup.Name = "";
            this.circularOrderGroup.RadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.CircularLayoutOrder.Optimal, "Optimal"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.CircularLayoutOrder.Clockwise, "Clockwise"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.CircularLayoutOrder.Counterclockwise, "Counterclockwise")});
            this.circularOrderGroup.RadioGroup.TabIndex = 0;
            this.circularOrderGroup.RadioGroup.SelectedIndexChanged += new System.EventHandler(this.CircularOrderGroupSelectedItemChanged);
            this.circularOrderGroup.Size = new System.Drawing.Size(249, 118);
            this.circularOrderGroup.TabIndex = 0;
            this.circularOrderGroup.Text = "Circular Order";
            // 
            // nodesSpacingGroup
            // 
            this.nodesSpacingGroup.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.nodesSpacingGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.nodesSpacingGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.nodesSpacingGroup.Location = new System.Drawing.Point(0, 207);
            this.nodesSpacingGroup.Name = "nodesSpacingGroup";
            this.nodesSpacingGroup.Padding = new System.Windows.Forms.Padding(12);
            this.nodesSpacingGroup.Size = new System.Drawing.Size(249, 89);
            this.nodesSpacingGroup.TabIndex = 2;
            this.nodesSpacingGroup.Text = "Nodes Spacing";
            this.nodesSpacingGroup.TrackBarSettings.Binding = new System.Windows.Forms.Binding("EditValue", bindingSource, "NodesSpacing", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
            this.nodesSpacingGroup.TrackBarSettings.Caption = null;
            this.nodesSpacingGroup.TrackBarSettings.Max = 150;
            this.nodesSpacingGroup.TrackBarSettings.Min = 0;
            this.nodesSpacingGroup.TrackBarSettings.SmallChange = 15;
            this.nodesSpacingGroup.TrackBarValueChanged += new System.EventHandler(this.TrackBarValueChanged);
            // 
            // CircularLayoutModule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Name = "CircularLayoutModule";
            this.OptionsPageControls.Add(this.nodesSpacingGroup);
            this.OptionsPageControls.Add(this.startAngleGroup);
            this.OptionsPageControls.Add(this.circularOrderGroup);
            this.containerControl.ResumeLayout(false);
            this.containerControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startAngleGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularOrderGroup.RadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularOrderGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodesSpacingGroup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupControlWithTrackBar startAngleGroup;
        private GroupControlWithRadioGroup circularOrderGroup;
        private GroupControlWithTrackBar nodesSpacingGroup;
    }
}
