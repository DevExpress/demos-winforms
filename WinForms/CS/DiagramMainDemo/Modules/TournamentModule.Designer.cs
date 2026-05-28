namespace DevExpress.XtraDiagram.Demos {
    partial class TournamentModule {
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
            this.diagramDataBindingController1 = new DevExpress.XtraDiagram.DiagramDataBindingController(this.components);
            this.relationshipInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tournamentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagramConnector1 = new DevExpress.XtraDiagram.DiagramConnector();
            this.diagramContainer1 = new DevExpress.XtraDiagram.DiagramContainer();
            this.diagramContainer2 = new DevExpress.XtraDiagram.DiagramContainer();
            this.diagramImage1 = new DevExpress.XtraDiagram.DiagramImage();
            this.diagramShape1 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape2 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramContainer3 = new DevExpress.XtraDiagram.DiagramContainer();
            this.diagramImage2 = new DevExpress.XtraDiagram.DiagramImage();
            this.diagramShape3 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape4 = new DevExpress.XtraDiagram.DiagramShape();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1.TemplateDiagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationshipInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // containerControl
            // 
            this.containerControl.Size = new System.Drawing.Size(987, 505);
            // 
            // diagramControl
            // 
            this.diagramControl.OptionsBehavior.PointerToolDragMode = DevExpress.Diagram.Core.PointerToolDragMode.Pan;
            this.diagramControl.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "BasicShapes",
            "BasicFlowchartShapes"});
            this.diagramControl.OptionsTreeLayout.DepthAlignment = DevExpress.Diagram.Core.Alignment.Center;
            this.diagramControl.OptionsTreeLayout.Direction = DevExpress.Diagram.Core.Layout.LayoutDirection.RightToLeft;
            this.diagramControl.OptionsTreeLayout.HorizontalSpacing = 250F;
            this.diagramControl.OptionsTreeLayout.VerticalSpacing = 100F;
            this.diagramControl.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.Fill;
            this.diagramControl.OptionsView.PageSize = new System.Drawing.SizeF(1598F, 748F);
            this.diagramControl.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.diagramControl.OptionsView.PropertiesPanelVisibility = DevExpress.Diagram.Core.PropertiesPanelVisibility.Closed;
            this.diagramControl.OptionsView.ShowGrid = false;
            this.diagramControl.OptionsView.ShowPageBreaks = false;
            this.diagramControl.OptionsView.ShowRulers = false;
            this.diagramControl.OptionsView.Theme = DevExpress.Diagram.Core.DiagramThemes.NoTheme;
            this.diagramControl.OptionsView.ToolboxVisibility = DevExpress.Diagram.Core.ToolboxVisibility.Closed;
            this.diagramControl.Size = new System.Drawing.Size(981, 331);
            // 
            // diagramDataBindingController1
            // 
            this.diagramDataBindingController1.ClearExistingItems = false;
            this.diagramDataBindingController1.ConnectorFromMember = "Source";
            this.diagramDataBindingController1.ConnectorsSource = this.relationshipInfoBindingSource;
            this.diagramDataBindingController1.ConnectorToMember = "Target";
            this.diagramDataBindingController1.DataSource = this.tournamentsBindingSource;
            this.diagramDataBindingController1.Diagram = this.diagramControl;
            this.diagramDataBindingController1.KeyMember = "Id";
            this.diagramDataBindingController1.LayoutKind = DevExpress.Diagram.Core.DiagramLayoutKind.Tree;
            // 
            // 
            // 
            this.diagramDataBindingController1.TemplateDiagram.Items.AddRange(new DevExpress.XtraDiagram.DiagramItem[] {
            this.diagramConnector1,
            this.diagramContainer1});
            this.diagramDataBindingController1.TemplateDiagram.Location = new System.Drawing.Point(0, 0);
            this.diagramDataBindingController1.TemplateDiagram.Name = "";
            this.diagramDataBindingController1.TemplateDiagram.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "TemplateDesigner"});
            this.diagramDataBindingController1.TemplateDiagram.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.Fill;
            this.diagramDataBindingController1.TemplateDiagram.OptionsView.Landscape = false;
            this.diagramDataBindingController1.TemplateDiagram.OptionsView.PageSize = new System.Drawing.SizeF(348F, 363F);
            this.diagramDataBindingController1.TemplateDiagram.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.diagramDataBindingController1.TemplateDiagram.OptionsView.ShowPageBreaks = false;
            this.diagramDataBindingController1.TemplateDiagram.TabIndex = 0;
            // 
            // relationshipInfoBindingSource
            // 
            this.relationshipInfoBindingSource.DataSource = typeof(DevExpress.Diagram.Demos.TournamentRelationInfo);
            // 
            // tournamentsBindingSource
            // 
            this.tournamentsBindingSource.DataSource = typeof(DevExpress.Diagram.Demos.Game);
            // 
            // diagramConnector1
            // 
            this.diagramConnector1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.diagramConnector1.Appearance.ContentBackground = System.Drawing.Color.White;
            this.diagramConnector1.BeginPoint = new DevExpress.Utils.PointFloat(0F, 30F);
            this.diagramConnector1.CanChangeRoute = false;
            this.diagramConnector1.CanCopy = false;
            this.diagramConnector1.CanCopyWithoutParent = false;
            this.diagramConnector1.CanDelete = false;
            this.diagramConnector1.CanDeleteWithoutParent = false;
            this.diagramConnector1.CanDragBeginPoint = false;
            this.diagramConnector1.CanDragEndPoint = false;
            this.diagramConnector1.CanEdit = false;
            this.diagramConnector1.CanMove = false;
            this.diagramConnector1.CanSelect = false;
            this.diagramConnector1.EndArrow = null;
            this.diagramConnector1.EndPoint = new DevExpress.Utils.PointFloat(90F, 120F);
            this.diagramConnector1.Points = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[] {
            new DevExpress.Utils.PointFloat(90F, 30F)});
            // 
            // diagramContainer1
            // 
            this.diagramContainer1.Anchors = ((DevExpress.Diagram.Core.Sides)((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Top)));
            this.diagramContainer1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.diagramContainer1.Appearance.BorderSize = 0;
            this.diagramContainer1.CanAddItems = false;
            this.diagramContainer1.CanChangeParent = false;
            this.diagramContainer1.CanCopy = false;
            this.diagramContainer1.CanCopyWithoutParent = false;
            this.diagramContainer1.CanDelete = false;
            this.diagramContainer1.CanDeleteWithoutParent = false;
            this.diagramContainer1.CanMove = false;
            this.diagramContainer1.CanResize = false;
            this.diagramContainer1.CanSelect = false;
            this.diagramContainer1.CanSnapToOtherItems = false;
            this.diagramContainer1.CanSnapToThisItem = false;
            this.diagramContainer1.CollapseButtonVisibilityMode = DevExpress.Diagram.Core.CollapseButtonVisibilityMode.Never;
            this.diagramContainer1.ConnectionPoints = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[] {
            new DevExpress.Utils.PointFloat(0.5F, 0F),
            new DevExpress.Utils.PointFloat(1F, 0.5F),
            new DevExpress.Utils.PointFloat(0.5F, 1F),
            new DevExpress.Utils.PointFloat(0F, 0.5F)});
            this.diagramContainer1.DragMode = DevExpress.Diagram.Core.ContainerDragMode.ByAnyPoint;
            this.diagramContainer1.Items.AddRange(new DevExpress.XtraDiagram.DiagramItem[] {
            this.diagramContainer2,
            this.diagramContainer3});
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
            this.diagramContainer1.Position = new DevExpress.Utils.PointFloat(-100F, -180F);
            this.diagramContainer1.Size = new System.Drawing.SizeF(355F, 100.034F);
            this.diagramContainer1.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant1;
            // 
            // diagramContainer2
            // 
            this.diagramContainer2.Anchors = ((DevExpress.Diagram.Core.Sides)((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Top)));
            this.diagramContainer2.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.diagramContainer2.CanAddItems = false;
            this.diagramContainer2.CanAttachConnectorBeginPoint = false;
            this.diagramContainer2.CanAttachConnectorEndPoint = false;
            this.diagramContainer2.CanChangeParent = false;
            this.diagramContainer2.CanCopy = false;
            this.diagramContainer2.CanCopyWithoutParent = false;
            this.diagramContainer2.CanDelete = false;
            this.diagramContainer2.CanDeleteWithoutParent = false;
            this.diagramContainer2.CanMove = false;
            this.diagramContainer2.CanResize = false;
            this.diagramContainer2.CanSelect = true;
            this.diagramContainer2.CanSnapToOtherItems = false;
            this.diagramContainer2.CanSnapToThisItem = false;
            this.diagramContainer2.ConnectionPoints = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[] {
            new DevExpress.Utils.PointFloat(0.5F, 0F),
            new DevExpress.Utils.PointFloat(1F, 0.5F),
            new DevExpress.Utils.PointFloat(0.5F, 1F),
            new DevExpress.Utils.PointFloat(0F, 0.5F)});
            this.diagramContainer2.DragMode = DevExpress.Diagram.Core.ContainerDragMode.ByAnyPoint;
            this.diagramContainer2.Items.AddRange(new DevExpress.XtraDiagram.DiagramItem[] {
            this.diagramImage1,
            this.diagramShape1,
            this.diagramShape2});
            this.diagramContainer2.ItemsCanAttachConnectorBeginPoint = false;
            this.diagramContainer2.ItemsCanAttachConnectorEndPoint = false;
            this.diagramContainer2.ItemsCanChangeParent = false;
            this.diagramContainer2.ItemsCanCopyWithoutParent = false;
            this.diagramContainer2.ItemsCanDeleteWithoutParent = false;
            this.diagramContainer2.ItemsCanEdit = false;
            this.diagramContainer2.ItemsCanMove = false;
            this.diagramContainer2.ItemsCanResize = false;
            this.diagramContainer2.ItemsCanRotate = false;
            this.diagramContainer2.ItemsCanSelect = false;
            this.diagramContainer2.ItemsCanSnapToOtherItems = false;
            this.diagramContainer2.ItemsCanSnapToThisItem = false;
            this.diagramContainer2.Size = new System.Drawing.SizeF(355F, 50F);
            this.diagramContainer2.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant1;
            // 
            // diagramImage1
            // 
            this.diagramImage1.AllowPlaceholder = false;
            this.diagramImage1.Anchors = ((DevExpress.Diagram.Core.Sides)((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Top)));
            this.diagramImage1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.diagramImage1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.diagramImage1.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Image", "First.ImageData"));
            this.diagramImage1.CanAttachConnectorBeginPoint = false;
            this.diagramImage1.CanAttachConnectorEndPoint = false;
            this.diagramImage1.CanChangeParent = false;
            this.diagramImage1.CanCopyWithoutParent = false;
            this.diagramImage1.CanDeleteWithoutParent = false;
            this.diagramImage1.CanMove = false;
            this.diagramImage1.CanResize = false;
            this.diagramImage1.CanRotate = false;
            this.diagramImage1.CanSelect = false;
            this.diagramImage1.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.Black;
            this.diagramImage1.MoveWithSubordinates = true;
            this.diagramImage1.Size = new System.Drawing.SizeF(80.39952F, 50F);
            this.diagramImage1.StretchMode = DevExpress.Diagram.Core.StretchMode.Stretch;
            // 
            // diagramShape1
            // 
            this.diagramShape1.Anchors = ((DevExpress.Diagram.Core.Sides)((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Top)));
            this.diagramShape1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.diagramShape1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.diagramShape1.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold);
            this.diagramShape1.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Content", "First.Name"));
            this.diagramShape1.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White;
            this.diagramShape1.MoveWithSubordinates = true;
            this.diagramShape1.Position = new DevExpress.Utils.PointFloat(80F, 0F);
            this.diagramShape1.Size = new System.Drawing.SizeF(220F, 50F);
            // 
            // diagramShape2
            // 
            this.diagramShape2.Anchors = ((DevExpress.Diagram.Core.Sides)((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Top)));
            this.diagramShape2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.diagramShape2.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.diagramShape2.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold);
            this.diagramShape2.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Content", "Team1Score", DevExpress.Diagram.Core.DiagramBindingMode.TwoWay));
            this.diagramShape2.CanEdit = true;
            this.diagramShape2.CanSelect = true;
            this.diagramShape2.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White;
            this.diagramShape2.MoveWithSubordinates = true;
            this.diagramShape2.Position = new DevExpress.Utils.PointFloat(300F, 0F);
            this.diagramShape2.Size = new System.Drawing.SizeF(55F, 50F);
            this.diagramShape2.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant1;
            // 
            // diagramContainer3
            // 
            this.diagramContainer3.Anchors = ((DevExpress.Diagram.Core.Sides)((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Top)));
            this.diagramContainer3.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.diagramContainer3.CanAddItems = false;
            this.diagramContainer3.CanAttachConnectorBeginPoint = false;
            this.diagramContainer3.CanAttachConnectorEndPoint = false;
            this.diagramContainer3.CanChangeParent = false;
            this.diagramContainer3.CanCopy = false;
            this.diagramContainer3.CanCopyWithoutParent = false;
            this.diagramContainer3.CanDelete = false;
            this.diagramContainer3.CanDeleteWithoutParent = false;
            this.diagramContainer3.CanMove = false;
            this.diagramContainer3.CanResize = false;
            this.diagramContainer3.CanSelect = true;
            this.diagramContainer3.CanSnapToOtherItems = false;
            this.diagramContainer3.CanSnapToThisItem = false;
            this.diagramContainer3.ConnectionPoints = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[] {
            new DevExpress.Utils.PointFloat(0.5F, 0F),
            new DevExpress.Utils.PointFloat(1F, 0.5F),
            new DevExpress.Utils.PointFloat(0.5F, 1F),
            new DevExpress.Utils.PointFloat(0F, 0.5F)});
            this.diagramContainer3.DragMode = DevExpress.Diagram.Core.ContainerDragMode.ByAnyPoint;
            this.diagramContainer3.Items.AddRange(new DevExpress.XtraDiagram.DiagramItem[] {
            this.diagramImage2,
            this.diagramShape3,
            this.diagramShape4});
            this.diagramContainer3.ItemsCanAttachConnectorBeginPoint = false;
            this.diagramContainer3.ItemsCanAttachConnectorEndPoint = false;
            this.diagramContainer3.ItemsCanChangeParent = false;
            this.diagramContainer3.ItemsCanCopyWithoutParent = false;
            this.diagramContainer3.ItemsCanDeleteWithoutParent = false;
            this.diagramContainer3.ItemsCanEdit = false;
            this.diagramContainer3.ItemsCanMove = false;
            this.diagramContainer3.ItemsCanResize = false;
            this.diagramContainer3.ItemsCanRotate = false;
            this.diagramContainer3.ItemsCanSelect = false;
            this.diagramContainer3.ItemsCanSnapToOtherItems = false;
            this.diagramContainer3.ItemsCanSnapToThisItem = false;
            this.diagramContainer3.Position = new DevExpress.Utils.PointFloat(0F, 50F);
            this.diagramContainer3.Size = new System.Drawing.SizeF(355F, 50F);
            this.diagramContainer3.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant1;
            // 
            // diagramImage2
            // 
            this.diagramImage2.AllowPlaceholder = false;
            this.diagramImage2.Anchors = ((DevExpress.Diagram.Core.Sides)((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Top)));
            this.diagramImage2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.diagramImage2.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.diagramImage2.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Image", "Second.ImageData"));
            this.diagramImage2.CanAttachConnectorBeginPoint = false;
            this.diagramImage2.CanAttachConnectorEndPoint = false;
            this.diagramImage2.CanChangeParent = false;
            this.diagramImage2.CanCopyWithoutParent = false;
            this.diagramImage2.CanDeleteWithoutParent = false;
            this.diagramImage2.CanMove = false;
            this.diagramImage2.CanResize = false;
            this.diagramImage2.CanRotate = false;
            this.diagramImage2.CanSelect = false;
            this.diagramImage2.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.Black;
            this.diagramImage2.MoveWithSubordinates = true;
            this.diagramImage2.Size = new System.Drawing.SizeF(80.39952F, 50F);
            this.diagramImage2.StretchMode = DevExpress.Diagram.Core.StretchMode.Stretch;
            // 
            // diagramShape3
            // 
            this.diagramShape3.Anchors = ((DevExpress.Diagram.Core.Sides)((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Top)));
            this.diagramShape3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.diagramShape3.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.diagramShape3.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold);
            this.diagramShape3.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Content", "Second.Name"));
            this.diagramShape3.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White;
            this.diagramShape3.MoveWithSubordinates = true;
            this.diagramShape3.Position = new DevExpress.Utils.PointFloat(80F, 0F);
            this.diagramShape3.Size = new System.Drawing.SizeF(220F, 50F);
            // 
            // diagramShape4
            // 
            this.diagramShape4.Anchors = ((DevExpress.Diagram.Core.Sides)((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Top)));
            this.diagramShape4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.diagramShape4.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.diagramShape4.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold);
            this.diagramShape4.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Content", "Team2Score", DevExpress.Diagram.Core.DiagramBindingMode.TwoWay));
            this.diagramShape4.CanEdit = true;
            this.diagramShape4.CanSelect = true;
            this.diagramShape4.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White;
            this.diagramShape4.MoveWithSubordinates = true;
            this.diagramShape4.Position = new DevExpress.Utils.PointFloat(300F, 0F);
            this.diagramShape4.Size = new System.Drawing.SizeF(55F, 50F);
            this.diagramShape4.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant1;
            // 
            // TournamentModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TournamentModule";
            this.Size = new System.Drawing.Size(987, 505);
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1.TemplateDiagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationshipInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DiagramDataBindingController diagramDataBindingController1;
        private System.Windows.Forms.BindingSource tournamentsBindingSource;
        private System.Windows.Forms.BindingSource relationshipInfoBindingSource;
        private DiagramConnector diagramConnector1;
        private DiagramContainer diagramContainer1;
        private DiagramContainer diagramContainer2;
        private DiagramImage diagramImage1;
        private DiagramShape diagramShape1;
        private DiagramShape diagramShape2;
        private DiagramContainer diagramContainer3;
        private DiagramImage diagramImage2;
        private DiagramShape diagramShape3;
        private DiagramShape diagramShape4;
    }
}
