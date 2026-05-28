using DevExpress.Diagram.Core.Layout;

namespace DevExpress.XtraDiagram.Demos {
    partial class LayeredLayoutModule {
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
            bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.containerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directionGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directionGroup.RadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spacingGroup)).BeginInit();
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
            bindingSource.DataMember = "OptionsSugiyamaLayout";
            bindingSource.DataSource = this.diagramControl;
            bindingSource.Position = 0;
            // 
            // directionGroup
            // 
            this.directionGroup.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.directionGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.directionGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.directionGroup.Location = new System.Drawing.Point(0, 46);
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
            this.directionGroup.Size = new System.Drawing.Size(249, 118);
            this.directionGroup.TabIndex = 0;
            this.directionGroup.Text = "Direction";
            // 
            // spacingGroup
            // 
            this.spacingGroup.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.spacingGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacingGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.spacingGroup.Location = new System.Drawing.Point(0, 0);
            this.spacingGroup.Name = "spacingGroup";
            this.spacingGroup.Padding = new System.Windows.Forms.Padding(12);
            this.spacingGroup.Size = new System.Drawing.Size(249, 46);
            this.spacingGroup.TabIndex = 1;
            this.spacingGroup.Text = "Spacing";
            trackBarSettings1.Binding = new System.Windows.Forms.Binding("EditValue", bindingSource, "LayerSpacing", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
            trackBarSettings1.Caption = "Layer";
            trackBarSettings1.Max = 150;
            trackBarSettings1.Min = 30;
            trackBarSettings1.SmallChange = 15;
            trackBarSettings2.Binding = new System.Windows.Forms.Binding("EditValue", bindingSource, "ColumnSpacing", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
            trackBarSettings2.Caption = "Column";
            trackBarSettings2.Max = 150;
            trackBarSettings2.Min = 20;
            trackBarSettings2.SmallChange = 15;
            this.spacingGroup.TrackBarsSettings.Add(trackBarSettings1);
            this.spacingGroup.TrackBarsSettings.Add(trackBarSettings2);
            this.spacingGroup.TrackBarsValueChanged += new System.EventHandler(this.TrackBarValueChanged);
            // 
            // LayeredLayoutModule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Name = "LayeredLayoutModule";
            this.OptionsPageControls.Add(this.spacingGroup);
            this.OptionsPageControls.Add(this.directionGroup);
            this.containerControl.ResumeLayout(false);
            this.containerControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directionGroup.RadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directionGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spacingGroup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupControlWithRadioGroup directionGroup;
        private GroupControlWithTrackBars spacingGroup;
    }
}
