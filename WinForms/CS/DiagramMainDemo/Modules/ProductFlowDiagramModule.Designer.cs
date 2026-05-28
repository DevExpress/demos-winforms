namespace DevExpress.XtraDiagram.Demos {
    partial class ProductFlowDiagramModule {
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
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.category = new DevExpress.XtraGrid.Columns.GridColumn();
            this.customer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.product = new DevExpress.XtraGrid.Columns.GridColumn();
            this.quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.diagramDataBindingController1 = new DevExpress.XtraDiagram.DiagramDataBindingController(this.components);
            this.diagramContainer1 = new DevExpress.XtraDiagram.DiagramContainer();
            this.diagramShape1 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape2 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramImage1 = new DevExpress.XtraDiagram.DiagramImage();
            this.diagramContainer2 = new DevExpress.XtraDiagram.DiagramContainer();
            this.diagramShape3 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape4 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape5 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramConnector1 = new DevExpress.XtraDiagram.DiagramConnector();
            this.containerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1.TemplateDiagram)).BeginInit();
            this.SuspendLayout();
            // 
            // containerControl
            // 
            this.containerControl.Size = new System.Drawing.Size(476, 432);
            this.containerControl.Controls.SetChildIndex(this.diagramControl, 0);
            // 
            // diagramControl
            // 
            this.diagramControl.Location = new System.Drawing.Point(0, 150);
            this.diagramControl.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "BasicShapes",
            "BasicFlowchartShapes"});
            this.diagramControl.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.None;
            this.diagramControl.OptionsView.PageSize = new System.Drawing.SizeF(800F, 700F);
            this.diagramControl.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.diagramControl.OptionsView.PropertiesPanelVisibility = DevExpress.Diagram.Core.PropertiesPanelVisibility.Closed;
            this.diagramControl.OptionsView.Theme = DevExpress.Diagram.Core.DiagramThemes.Linear;
            this.diagramControl.OptionsView.ToolboxVisibility = DevExpress.Diagram.Core.ToolboxVisibility.Closed;
            this.diagramControl.Size = new System.Drawing.Size(476, 255);
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(299, 399);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.category,
            this.customer,
            this.product,
            this.quantity});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.OptionsView.ShowIndicator = false;
            // 
            // category
            // 
            this.category.AppearanceHeader.Options.UseTextOptions = true;
            this.category.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.category.Caption = "Category";
            this.category.FieldName = "Category.Name";
            this.category.Name = "category";
            this.category.Visible = true;
            this.category.VisibleIndex = 0;
            this.category.Width = 104;
            // 
            // customer
            // 
            this.customer.AppearanceHeader.Options.UseTextOptions = true;
            this.customer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.customer.Caption = "Customer";
            this.customer.FieldName = "Customer.Name";
            this.customer.Name = "customer";
            this.customer.Visible = true;
            this.customer.VisibleIndex = 1;
            this.customer.Width = 109;
            // 
            // product
            // 
            this.product.AppearanceHeader.Options.UseTextOptions = true;
            this.product.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.product.Caption = "Product";
            this.product.FieldName = "ProductName";
            this.product.Name = "product";
            this.product.Visible = true;
            this.product.VisibleIndex = 2;
            this.product.Width = 104;
            // 
            // quantity
            // 
            this.quantity.AppearanceCell.Options.UseTextOptions = true;
            this.quantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.quantity.AppearanceHeader.Options.UseTextOptions = true;
            this.quantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.quantity.Caption = "Quantity";
            this.quantity.FieldName = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.Visible = true;
            this.quantity.VisibleIndex = 3;
            // 
            // diagramDataBindingController1
            // 
            this.diagramDataBindingController1.ConnectorFromMember = "Customer";
            this.diagramDataBindingController1.ConnectorsSource = null;
            this.diagramDataBindingController1.ConnectorsZOrder = DevExpress.Diagram.Core.ConnectorsZOrder.InFrontOfItems;
            this.diagramDataBindingController1.ConnectorToMember = "Category";
            this.diagramDataBindingController1.Diagram = this.diagramControl;
            // 
            // 
            // 
            this.diagramDataBindingController1.TemplateDiagram.Items.AddRange(new DevExpress.XtraDiagram.DiagramItem[] {
            this.diagramContainer1,
            this.diagramContainer2,
            this.diagramConnector1});
            this.diagramDataBindingController1.TemplateDiagram.Location = new System.Drawing.Point(0, 0);
            this.diagramDataBindingController1.TemplateDiagram.Name = "";
            this.diagramDataBindingController1.TemplateDiagram.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "TemplateDesigner",
            "BasicShapes"});
            this.diagramDataBindingController1.TemplateDiagram.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.Fill;
            this.diagramDataBindingController1.TemplateDiagram.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            this.diagramDataBindingController1.TemplateDiagram.OptionsView.ShowPageBreaks = false;
            this.diagramDataBindingController1.TemplateDiagram.OptionsView.Theme = DevExpress.Diagram.Core.DiagramThemes.Linear;
            this.diagramDataBindingController1.TemplateDiagram.TabIndex = 0;
            this.diagramDataBindingController1.GenerateItem += new System.EventHandler<DevExpress.XtraDiagram.DiagramGenerateItemEventArgs>(this.diagramDataBindingController1_GenerateItem);
            this.diagramDataBindingController1.UpdateConnector += new System.EventHandler<DevExpress.XtraDiagram.DiagramUpdateConnectorEventArgs>(this.diagramDataBindingController1_UpdateConnector);
            this.diagramDataBindingController1.CustomLayoutItems += new System.EventHandler<DevExpress.XtraDiagram.DiagramCustomLayoutItemsEventArgs>(this.diagramDataBindingController1_CustomLayoutItems);
            // 
            // diagramContainer1
            // 
            this.diagramContainer1.Anchors = ((DevExpress.Diagram.Core.Sides)((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Top)));
            this.diagramContainer1.CanAddItems = false;
            this.diagramContainer1.CanCopy = false;
            this.diagramContainer1.CanCopyWithoutParent = true;
            this.diagramContainer1.CanDelete = false;
            this.diagramContainer1.ConnectionPoints = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[] {
            new DevExpress.Utils.PointFloat(0.5F, 0F),
            new DevExpress.Utils.PointFloat(1F, 0.5F),
            new DevExpress.Utils.PointFloat(0.5F, 1F),
            new DevExpress.Utils.PointFloat(0F, 0.5F)});
            this.diagramContainer1.DragMode = DevExpress.Diagram.Core.ContainerDragMode.ByAnyPoint;
            this.diagramContainer1.Items.AddRange(new DevExpress.XtraDiagram.DiagramItem[] {
            this.diagramShape1,
            this.diagramShape2,
            this.diagramImage1});
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
            this.diagramContainer1.Position = new DevExpress.Utils.PointFloat(350F, 30F);
            this.diagramContainer1.Size = new System.Drawing.SizeF(150F, 105F);
            this.diagramContainer1.TemplateName = "CategoryTemplate";
            this.diagramContainer1.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant1;
            // 
            // diagramShape1
            // 
            this.diagramShape1.Anchors = ((DevExpress.Diagram.Core.Sides)(((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Right) 
            | DevExpress.Diagram.Core.Sides.Bottom)));
            this.diagramShape1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.diagramShape1.Appearance.BorderSize = 0;
            this.diagramShape1.Appearance.Font = new System.Drawing.Font("Tahoma", 7F);
            this.diagramShape1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.diagramShape1.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Content", "Description"));
            this.diagramShape1.Position = new DevExpress.Utils.PointFloat(10F, 60F);
            this.diagramShape1.Size = new System.Drawing.SizeF(130F, 45F);
            // 
            // diagramShape2
            // 
            this.diagramShape2.Anchors = ((DevExpress.Diagram.Core.Sides)(((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Right) 
            | DevExpress.Diagram.Core.Sides.Bottom)));
            this.diagramShape2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.diagramShape2.Appearance.BorderSize = 0;
            this.diagramShape2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.diagramShape2.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Content", "Name"));
            this.diagramShape2.Position = new DevExpress.Utils.PointFloat(10F, 36F);
            this.diagramShape2.Size = new System.Drawing.SizeF(130F, 17F);
            // 
            // diagramImage1
            // 
            this.diagramImage1.Anchors = ((DevExpress.Diagram.Core.Sides)(((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Top) 
            | DevExpress.Diagram.Core.Sides.Right)));
            this.diagramImage1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.diagramImage1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.diagramImage1.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Image", "Picture"));
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
            this.diagramImage1.Position = new DevExpress.Utils.PointFloat(10F, 18F);
            this.diagramImage1.Size = new System.Drawing.SizeF(130F, 17F);
            // 
            // diagramContainer2
            // 
            this.diagramContainer2.Anchors = ((DevExpress.Diagram.Core.Sides)((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Top)));
            this.diagramContainer2.CanAddItems = false;
            this.diagramContainer2.CanCopy = false;
            this.diagramContainer2.CanCopyWithoutParent = true;
            this.diagramContainer2.CanDelete = false;
            this.diagramContainer2.ConnectionPoints = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[] {
            new DevExpress.Utils.PointFloat(0.5F, 0F),
            new DevExpress.Utils.PointFloat(1F, 0.5F),
            new DevExpress.Utils.PointFloat(0.5F, 1F),
            new DevExpress.Utils.PointFloat(0F, 0.5F)});
            this.diagramContainer2.DragMode = DevExpress.Diagram.Core.ContainerDragMode.ByAnyPoint;
            this.diagramContainer2.Items.AddRange(new DevExpress.XtraDiagram.DiagramItem[] {
            this.diagramShape3,
            this.diagramShape4,
            this.diagramShape5});
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
            this.diagramContainer2.Position = new DevExpress.Utils.PointFloat(60F, 30F);
            this.diagramContainer2.Size = new System.Drawing.SizeF(150F, 105F);
            this.diagramContainer2.TemplateName = "CustomerTemplate";
            this.diagramContainer2.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant1;
            // 
            // diagramShape3
            // 
            this.diagramShape3.Anchors = ((DevExpress.Diagram.Core.Sides)(((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Top) 
            | DevExpress.Diagram.Core.Sides.Right)));
            this.diagramShape3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.diagramShape3.Appearance.BorderSize = 0;
            this.diagramShape3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.diagramShape3.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Content", "CompanyName"));
            this.diagramShape3.Position = new DevExpress.Utils.PointFloat(10F, 10F);
            this.diagramShape3.Size = new System.Drawing.SizeF(130F, 43F);
            // 
            // diagramShape4
            // 
            this.diagramShape4.Anchors = ((DevExpress.Diagram.Core.Sides)(((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Right) 
            | DevExpress.Diagram.Core.Sides.Bottom)));
            this.diagramShape4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.diagramShape4.Appearance.BorderSize = 0;
            this.diagramShape4.Appearance.Font = new System.Drawing.Font("Tahoma", 7F);
            this.diagramShape4.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Content", "City"));
            this.diagramShape4.Position = new DevExpress.Utils.PointFloat(10F, 55F);
            this.diagramShape4.Size = new System.Drawing.SizeF(130F, 17F);
            // 
            // diagramShape5
            // 
            this.diagramShape5.Anchors = ((DevExpress.Diagram.Core.Sides)(((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Right) 
            | DevExpress.Diagram.Core.Sides.Bottom)));
            this.diagramShape5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.diagramShape5.Appearance.BorderSize = 0;
            this.diagramShape5.Appearance.Font = new System.Drawing.Font("Tahoma", 7F);
            this.diagramShape5.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Content", "PhoneNumber"));
            this.diagramShape5.Position = new DevExpress.Utils.PointFloat(10F, 71F);
            this.diagramShape5.Size = new System.Drawing.SizeF(130F, 17F);
            // 
            // diagramConnector1
            // 
            this.diagramConnector1.Appearance.ContentBackground = System.Drawing.Color.White;
            this.diagramConnector1.BeginItemPointIndex = 1;
            this.diagramConnector1.BeginPoint = new DevExpress.Utils.PointFloat(64F, 208F);
            this.diagramConnector1.CanChangeRoute = false;
            this.diagramConnector1.CanCopy = false;
            this.diagramConnector1.CanDelete = false;
            this.diagramConnector1.CanDragBeginPoint = false;
            this.diagramConnector1.CanDragEndPoint = false;
            this.diagramConnector1.EndArrow = null;
            this.diagramConnector1.EndItemPointIndex = 3;
            this.diagramConnector1.EndPoint = new DevExpress.Utils.PointFloat(154F, 298F);
            this.diagramConnector1.Points = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[] {
            new DevExpress.Utils.PointFloat(154F, 208F)});
            this.diagramConnector1.Type = DevExpress.Diagram.Core.ConnectorType.Curved;
            // 
            // ProductFlowDiagramModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ProductFlowDiagramModule";
            this.ShowOptionsPanel = true;
            this.Size = new System.Drawing.Size(776, 432);
            this.OptionsPageControls.Add(this.gridControl);
            this.containerControl.ResumeLayout(false);
            this.containerControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1.TemplateDiagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private XtraGrid.Columns.GridColumn quantity;
        private XtraGrid.Columns.GridColumn product;
        private XtraGrid.Columns.GridColumn customer;
        private XtraGrid.Columns.GridColumn category;
        private DiagramDataBindingController diagramDataBindingController1;
        private DiagramContainer diagramContainer1;
        private DiagramShape diagramShape1;
        private DiagramShape diagramShape2;
        private DiagramImage diagramImage1;
        private DiagramContainer diagramContainer2;
        private DiagramShape diagramShape3;
        private DiagramShape diagramShape4;
        private DiagramShape diagramShape5;
        private DiagramConnector diagramConnector1;
    }
}
