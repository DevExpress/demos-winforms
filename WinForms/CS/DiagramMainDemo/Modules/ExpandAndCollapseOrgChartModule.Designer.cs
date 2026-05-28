namespace DevExpress.XtraDiagram.Demos {
    partial class ExpandAndCollapseOrgChartModule {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.fitToItemsGroup = new DevExpress.XtraDiagram.Demos.OptionsPanelGroupControl();
            this.fitToItemsButton = new DevExpress.XtraEditors.SimpleButton();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagramOrgChartController1 = new DevExpress.XtraDiagram.DiagramOrgChartController(this.components);
            this.diagramContainer1 = new DevExpress.XtraDiagram.DiagramContainer();
            this.diagramShape1 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape2 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape3 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramConnector1 = new DevExpress.XtraDiagram.DiagramConnector();
            this.layoutKindGroup = new DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup();
            this.containerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitToItemsGroup)).BeginInit();
            this.fitToItemsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramOrgChartController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramOrgChartController1.TemplateDiagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutKindGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutKindGroup.RadioGroup.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // containerControl
            // 
            this.containerControl.Size = new System.Drawing.Size(737, 505);
            // 
            // diagramControl
            // 
            this.diagramControl.OptionsBehavior.PointerToolDragMode = DevExpress.Diagram.Core.PointerToolDragMode.Pan;
            this.diagramControl.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "BasicShapes",
            "BasicFlowchartShapes"});
            this.diagramControl.OptionsCircularLayout.Order = DevExpress.Diagram.Core.Layout.CircularLayoutOrder.Clockwise;
            this.diagramControl.OptionsConnector.LineJumpPlacement = DevExpress.Diagram.Core.LineJumpPlacement.None;
            this.diagramControl.OptionsOrgChartLayout.TreeLevelCount = 4;
            this.diagramControl.OptionsTipOverTreeLayout.Offset = 40F;
            this.diagramControl.OptionsTipOverTreeLayout.VerticalSpacing = 40F;
            this.diagramControl.OptionsTreeLayout.VerticalSpacing = 45F;
            this.diagramControl.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.Fill;
            this.diagramControl.OptionsView.MaxZoomFactor = 1.5F;
            this.diagramControl.OptionsView.MinZoomFactor = 0.3F;
            this.diagramControl.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            this.diagramControl.OptionsView.PropertiesPanelVisibility = DevExpress.Diagram.Core.PropertiesPanelVisibility.Closed;
            this.diagramControl.OptionsView.ShowGrid = false;
            this.diagramControl.OptionsView.ShowPageBreaks = false;
            this.diagramControl.OptionsView.ShowRulers = false;
            this.diagramControl.OptionsView.Theme = DevExpress.Diagram.Core.DiagramThemes.Linear;
            this.diagramControl.OptionsView.ToolboxVisibility = DevExpress.Diagram.Core.ToolboxVisibility.Compact;
            this.diagramControl.Size = new System.Drawing.Size(737, 505);
            // 
            // fitToItemsGroup
            // 
            this.fitToItemsGroup.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.fitToItemsGroup.Controls.Add(this.fitToItemsButton);
            this.fitToItemsGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.fitToItemsGroup.Location = new System.Drawing.Point(0, 142);
            this.fitToItemsGroup.Name = "fitToItemsGroup";
            this.fitToItemsGroup.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.fitToItemsGroup.Size = new System.Drawing.Size(249, 23);
            this.fitToItemsGroup.TabIndex = 0;
            // 
            // fitToItemsButton
            // 
            this.fitToItemsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fitToItemsButton.Location = new System.Drawing.Point(12, 0);
            this.fitToItemsButton.Name = "fitToItemsButton";
            this.fitToItemsButton.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.fitToItemsButton.Size = new System.Drawing.Size(225, 23);
            this.fitToItemsButton.TabIndex = 2;
            this.fitToItemsButton.Text = "Fit to Items";
            this.fitToItemsButton.Click += new System.EventHandler(this.FitToItems);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(DevExpress.Diagram.Demos.Employee);
            // 
            // diagramOrgChartController1
            // 
            this.diagramOrgChartController1.DataSource = this.employeeBindingSource;
            this.diagramOrgChartController1.Diagram = this.diagramControl;
            this.diagramOrgChartController1.ExpandSubordinatesButtonMode = DevExpress.Diagram.Core.ExpandSubordinatesButtonMode.LookupChildrenInSource;
            this.diagramOrgChartController1.ExpansionDepth = 0;
            this.diagramOrgChartController1.GenerationDepth = 0;
            this.diagramOrgChartController1.KeyMember = "Id";
            this.diagramOrgChartController1.LayoutKind = DevExpress.Diagram.Core.DiagramLayoutKind.OrgChart;
            this.diagramOrgChartController1.ParentMember = "ParentId";
            // 
            // 
            // 
            this.diagramOrgChartController1.TemplateDiagram.Items.AddRange(new DevExpress.XtraDiagram.DiagramItem[] {
            this.diagramContainer1,
            this.diagramConnector1});
            this.diagramOrgChartController1.TemplateDiagram.Location = new System.Drawing.Point(0, 0);
            this.diagramOrgChartController1.TemplateDiagram.Name = "";
            this.diagramOrgChartController1.TemplateDiagram.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "TemplateDesigner"});
            this.diagramOrgChartController1.TemplateDiagram.OptionsBehavior.ShowQuickShapes = false;
            this.diagramOrgChartController1.TemplateDiagram.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.Fill;
            this.diagramOrgChartController1.TemplateDiagram.OptionsView.Landscape = false;
            this.diagramOrgChartController1.TemplateDiagram.OptionsView.PageSize = new System.Drawing.SizeF(616F, 928F);
            this.diagramOrgChartController1.TemplateDiagram.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.diagramOrgChartController1.TemplateDiagram.OptionsView.ShowPageBreaks = false;
            this.diagramOrgChartController1.TemplateDiagram.TabIndex = 0;
            this.diagramOrgChartController1.ItemsGenerated += new System.EventHandler<DevExpress.XtraDiagram.DiagramItemsGeneratedEventArgs>(this.OnItemsGenerated);
            // 
            // diagramContainer1
            // 
            this.diagramContainer1.Anchors = ((DevExpress.Diagram.Core.Sides)((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Top)));
            this.diagramContainer1.Appearance.BorderSize = 0;
            this.diagramContainer1.CanAddItems = false;
            this.diagramContainer1.CanCopyWithoutParent = true;
            this.diagramContainer1.CanDelete = false;
            this.diagramContainer1.ConnectionPoints = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[] {
            new DevExpress.Utils.PointFloat(0F, 0.5F),
            new DevExpress.Utils.PointFloat(0.5F, 0F),
            new DevExpress.Utils.PointFloat(1F, 0.5F),
            new DevExpress.Utils.PointFloat(0.5F, 1F)});
            this.diagramContainer1.DragMode = DevExpress.Diagram.Core.ContainerDragMode.ByAnyPoint;
            this.diagramContainer1.Items.AddRange(new DevExpress.XtraDiagram.DiagramItem[] {
            this.diagramShape1,
            this.diagramShape2,
            this.diagramShape3});
            this.diagramContainer1.ItemsCanAttachConnectorBeginPoint = false;
            this.diagramContainer1.ItemsCanAttachConnectorEndPoint = false;
            this.diagramContainer1.ItemsCanChangeParent = false;
            this.diagramContainer1.ItemsCanCopyWithoutParent = false;
            this.diagramContainer1.ItemsCanDeleteWithoutParent = false;
            this.diagramContainer1.ItemsCanEdit = false;
            this.diagramContainer1.ItemsCanMove = false;
            this.diagramContainer1.ItemsCanResize = false;
            this.diagramContainer1.ItemsCanRotate = false;
            this.diagramContainer1.ItemsCanSelect = false;
            this.diagramContainer1.ItemsCanSnapToOtherItems = false;
            this.diagramContainer1.ItemsCanSnapToThisItem = false;
            this.diagramContainer1.MoveWithSubordinates = true;
            this.diagramContainer1.Position = new DevExpress.Utils.PointFloat(182.5F, 281.5F);
            this.diagramContainer1.Size = new System.Drawing.SizeF(251F, 127F);
            this.diagramContainer1.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Accent1;
            this.diagramContainer1.TemplateName = "";
            this.diagramContainer1.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant1;
            // 
            // diagramShape1
            // 
            this.diagramShape1.Anchors = ((DevExpress.Diagram.Core.Sides)((DevExpress.Diagram.Core.Sides.Top | DevExpress.Diagram.Core.Sides.Right)));
            this.diagramShape1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.diagramShape1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.diagramShape1.Appearance.BorderSize = 0;
            this.diagramShape1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.diagramShape1.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Content", "JobTitle"));
            this.diagramShape1.CanCopy = false;
            this.diagramShape1.CanCopyWithoutParent = false;
            this.diagramShape1.CanEdit = false;
            this.diagramShape1.CanMove = false;
            this.diagramShape1.CanResize = false;
            this.diagramShape1.CanRotate = false;
            this.diagramShape1.CanSelect = false;
            this.diagramShape1.CanSnapToOtherItems = false;
            this.diagramShape1.CanSnapToThisItem = false;
            this.diagramShape1.Position = new DevExpress.Utils.PointFloat(0F, -3.552714E-15F);
            this.diagramShape1.Size = new System.Drawing.SizeF(251F, 61.03622F);
            this.diagramShape1.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant1;
            // 
            // diagramShape2
            // 
            this.diagramShape2.Anchors = ((DevExpress.Diagram.Core.Sides)((DevExpress.Diagram.Core.Sides.Right | DevExpress.Diagram.Core.Sides.Bottom)));
            this.diagramShape2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.diagramShape2.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.diagramShape2.Appearance.BorderSize = 0;
            this.diagramShape2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.diagramShape2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.diagramShape2.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Content", "FirstName"));
            this.diagramShape2.CanCopy = false;
            this.diagramShape2.CanCopyWithoutParent = false;
            this.diagramShape2.CanEdit = false;
            this.diagramShape2.CanMove = false;
            this.diagramShape2.CanResize = false;
            this.diagramShape2.CanRotate = false;
            this.diagramShape2.CanSelect = false;
            this.diagramShape2.CanSnapToOtherItems = false;
            this.diagramShape2.CanSnapToThisItem = false;
            this.diagramShape2.Position = new DevExpress.Utils.PointFloat(0F, 65F);
            this.diagramShape2.Size = new System.Drawing.SizeF(251F, 20F);
            this.diagramShape2.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant1;
            // 
            // diagramShape3
            // 
            this.diagramShape3.Anchors = ((DevExpress.Diagram.Core.Sides)((DevExpress.Diagram.Core.Sides.Right | DevExpress.Diagram.Core.Sides.Bottom)));
            this.diagramShape3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.diagramShape3.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.diagramShape3.Appearance.BorderSize = 0;
            this.diagramShape3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.diagramShape3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.diagramShape3.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Content", "LastName"));
            this.diagramShape3.CanCopy = false;
            this.diagramShape3.CanCopyWithoutParent = false;
            this.diagramShape3.CanEdit = false;
            this.diagramShape3.CanMove = false;
            this.diagramShape3.CanResize = false;
            this.diagramShape3.CanRotate = false;
            this.diagramShape3.CanSelect = false;
            this.diagramShape3.CanSnapToOtherItems = false;
            this.diagramShape3.CanSnapToThisItem = false;
            this.diagramShape3.Position = new DevExpress.Utils.PointFloat(0F, 85F);
            this.diagramShape3.Size = new System.Drawing.SizeF(251F, 20F);
            this.diagramShape3.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant1;
            // 
            // diagramConnector1
            // 
            this.diagramConnector1.Appearance.ContentBackground = System.Drawing.Color.White;
            this.diagramConnector1.BeginPoint = new DevExpress.Utils.PointFloat(307.5F, 556.5F);
            this.diagramConnector1.CanChangeRoute = false;
            this.diagramConnector1.CanDragBeginPoint = false;
            this.diagramConnector1.CanDragEndPoint = false;
            this.diagramConnector1.EndPoint = new DevExpress.Utils.PointFloat(397.5F, 646.5F);
            this.diagramConnector1.Points = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[] {
            new DevExpress.Utils.PointFloat(397.5F, 556.5F)});
            // 
            // layoutKindGroup
            // 
            this.layoutKindGroup.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.layoutKindGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutKindGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutKindGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutKindGroup.Name = "layoutKindGroup";
            this.layoutKindGroup.Padding = new System.Windows.Forms.Padding(12);
            // 
            // 
            // 
            this.layoutKindGroup.RadioGroup.EditValue = DevExpress.Diagram.Core.DiagramLayoutKind.OrgChart;
            this.layoutKindGroup.RadioGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutKindGroup.RadioGroup.Name = "";
            this.layoutKindGroup.RadioGroup.Properties.AllowFocused = false;
            this.layoutKindGroup.RadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.DiagramLayoutKind.OrgChart, "OrgChart"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.DiagramLayoutKind.Tree, "Tree"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.DiagramLayoutKind.TipOverTree, "TipOverTree"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.DiagramLayoutKind.MindMapTree, "MindMapTree")});
            this.layoutKindGroup.RadioGroup.TabIndex = 0;
            this.layoutKindGroup.RadioGroup.SelectedIndexChanged += new System.EventHandler(this.LayoutKindChanged);
            this.layoutKindGroup.Size = new System.Drawing.Size(249, 142);
            this.layoutKindGroup.TabIndex = 1;
            this.layoutKindGroup.Text = "Layout Kind";
            // 
            // ExpandAndCollapseOrgChartModule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Name = "ExpandAndCollapseOrgChartModule";
            this.OptionsPageControls.Add(this.fitToItemsGroup);
            this.OptionsPageControls.Add(this.layoutKindGroup);
            this.ShowOptionsPanel = true;
            this.Size = new System.Drawing.Size(987, 505);
            this.containerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitToItemsGroup)).EndInit();
            this.fitToItemsGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramOrgChartController1.TemplateDiagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramOrgChartController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutKindGroup.RadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutKindGroup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private OptionsPanelGroupControl fitToItemsGroup;
        private DiagramOrgChartController diagramOrgChartController1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private GroupControlWithRadioGroup layoutKindGroup;
        private DiagramContainer diagramContainer1;
        private DiagramShape diagramShape1;
        private DiagramShape diagramShape2;
        private DiagramShape diagramShape3;
        private DiagramConnector diagramConnector1;
        private XtraEditors.SimpleButton fitToItemsButton;
    }
}
