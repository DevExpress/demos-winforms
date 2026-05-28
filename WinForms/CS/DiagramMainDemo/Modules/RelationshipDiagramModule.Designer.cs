namespace DevExpress.XtraDiagram.Demos {
    partial class RelationshipDiagramModule {
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
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagramContainer1 = new DevExpress.XtraDiagram.DiagramContainer();
            this.diagramImage1 = new DevExpress.XtraDiagram.DiagramImage();
            this.diagramShape2 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramConnector1 = new DevExpress.XtraDiagram.DiagramConnector();
            this.diagramConnector2 = new DevExpress.XtraDiagram.DiagramConnector();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.labelKnowEachOther = new DevExpress.XtraEditors.LabelControl();
            this.labelFriendsWithCaption = new DevExpress.XtraEditors.LabelControl();
            this.labelPhoneNumber = new DevExpress.XtraEditors.LabelControl();
            this.labelBirthDate = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.labelName = new DevExpress.XtraEditors.LabelControl();
            this.labelAddressLine = new DevExpress.XtraEditors.LabelControl();
            this.labelKnowEachOtherCaption = new DevExpress.XtraEditors.LabelControl();
            this.labelFriends = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.personInfoGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutPhoneNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.selectPersonLabel = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.diagramShape1 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape3 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape4 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramConnector3 = new DevExpress.XtraDiagram.DiagramConnector();
            this.diagramConnector4 = new DevExpress.XtraDiagram.DiagramConnector();
            this.containerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1.TemplateDiagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationshipInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personInfoGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutPhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectPersonLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // containerControl
            // 
            this.containerControl.Size = new System.Drawing.Size(737, 505);
            this.containerControl.Controls.SetChildIndex(this.diagramControl, 0);
            // 
            // diagramControl
            // 
            this.diagramControl.Items.AddRange(new DevExpress.XtraDiagram.DiagramItem[] {
            this.diagramShape1,
            this.diagramShape3,
            this.diagramShape4,
            this.diagramConnector3,
            this.diagramConnector4});
            this.diagramControl.Location = new System.Drawing.Point(0, 150);
            this.diagramControl.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "BasicShapes",
            "BasicFlowchartShapes"});
            this.diagramControl.OptionsBehavior.SelectionMode = DevExpress.Diagram.Core.SelectionMode.Single;
            this.diagramControl.OptionsCircularLayout.Order = DevExpress.Diagram.Core.Layout.CircularLayoutOrder.Clockwise;
            this.diagramControl.OptionsConnector.LineJumpPlacement = DevExpress.Diagram.Core.LineJumpPlacement.None;
            this.diagramControl.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.Fill;
            this.diagramControl.OptionsView.Landscape = false;
            this.diagramControl.OptionsView.PageSize = new System.Drawing.SizeF(1000F, 1000F);
            this.diagramControl.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.diagramControl.OptionsView.PropertiesPanelVisibility = DevExpress.Diagram.Core.PropertiesPanelVisibility.Closed;
            this.diagramControl.OptionsView.ShowPageBreaks = false;
            this.diagramControl.OptionsView.ShowRulers = false;
            this.diagramControl.OptionsView.Theme = DevExpress.Diagram.Core.DiagramThemes.Linear;
            this.diagramControl.OptionsView.ToolboxVisibility = DevExpress.Diagram.Core.ToolboxVisibility.Closed;
            this.diagramControl.Size = new System.Drawing.Size(737, 328);
            // 
            // diagramDataBindingController1
            // 
            this.diagramDataBindingController1.ClearExistingItems = false;
            this.diagramDataBindingController1.ConnectorFromMember = "Source";
            this.diagramDataBindingController1.ConnectorsSource = this.relationshipInfoBindingSource;
            this.diagramDataBindingController1.ConnectorToMember = "Target";
            this.diagramDataBindingController1.DataSource = this.employeeBindingSource;
            this.diagramDataBindingController1.Diagram = this.diagramControl;
            this.diagramDataBindingController1.KeyMember = "Id";
            this.diagramDataBindingController1.LayoutKind = DevExpress.Diagram.Core.DiagramLayoutKind.Circular;
            // 
            // 
            // 
            this.diagramDataBindingController1.TemplateDiagram.Items.AddRange(new DevExpress.XtraDiagram.DiagramItem[] {
            this.diagramContainer1,
            this.diagramConnector1,
            this.diagramConnector2});
            this.diagramDataBindingController1.TemplateDiagram.Location = new System.Drawing.Point(0, 0);
            this.diagramDataBindingController1.TemplateDiagram.Name = "";
            this.diagramDataBindingController1.TemplateDiagram.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "BasicShapes",
            "BasicFlowchartShapes",
            "TemplateDesigner"});
            this.diagramDataBindingController1.TemplateDiagram.OptionsBehavior.ShowQuickShapes = false;
            this.diagramDataBindingController1.TemplateDiagram.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.Fill;
            this.diagramDataBindingController1.TemplateDiagram.OptionsView.Landscape = false;
            this.diagramDataBindingController1.TemplateDiagram.OptionsView.PageSize = new System.Drawing.SizeF(162F, 258F);
            this.diagramDataBindingController1.TemplateDiagram.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.diagramDataBindingController1.TemplateDiagram.OptionsView.ShowPageBreaks = false;
            this.diagramDataBindingController1.TemplateDiagram.OptionsView.Theme = DevExpress.Diagram.Core.DiagramThemes.Linear;
            this.diagramDataBindingController1.TemplateDiagram.TabIndex = 0;
            this.diagramDataBindingController1.GenerateConnector += new System.EventHandler<DevExpress.XtraDiagram.DiagramGenerateConnectorEventArgs>(this.diagramDataBindingController1_GenerateConnector);
            // 
            // relationshipInfoBindingSource
            // 
            this.relationshipInfoBindingSource.DataSource = typeof(DevExpress.Diagram.Demos.RelationshipInfo);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(DevExpress.Diagram.Demos.Employee);
            // 
            // diagramContainer1
            // 
            this.diagramContainer1.Anchors = ((DevExpress.Diagram.Core.Sides)((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Top)));
            this.diagramContainer1.CanAddItems = false;
            this.diagramContainer1.CanCopy = false;
            this.diagramContainer1.CanDelete = false;
            this.diagramContainer1.DragMode = DevExpress.Diagram.Core.ContainerDragMode.ByAnyPoint;
            this.diagramContainer1.Items.AddRange(new DevExpress.XtraDiagram.DiagramItem[] {
            this.diagramImage1,
            this.diagramShape2});
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
            this.diagramContainer1.Padding = new System.Windows.Forms.Padding(12);
            this.diagramContainer1.Position = new DevExpress.Utils.PointFloat(24F, 15F);
            this.diagramContainer1.Size = new System.Drawing.SizeF(114F, 171F);
            this.diagramContainer1.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant1;
            // 
            // diagramImage1
            // 
            this.diagramImage1.Anchors = ((DevExpress.Diagram.Core.Sides)((((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Top) 
            | DevExpress.Diagram.Core.Sides.Right) 
            | DevExpress.Diagram.Core.Sides.Bottom)));
            this.diagramImage1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.diagramImage1.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Image", "ImageData"));
            this.diagramImage1.CanMove = false;
            this.diagramImage1.CanSelect = false;
            this.diagramImage1.Size = new System.Drawing.SizeF(90F, 120F);
            this.diagramImage1.StretchMode = DevExpress.Diagram.Core.StretchMode.UniformToFill;
            // 
            // diagramShape2
            // 
            this.diagramShape2.Anchors = ((DevExpress.Diagram.Core.Sides)(((DevExpress.Diagram.Core.Sides.Left | DevExpress.Diagram.Core.Sides.Right) 
            | DevExpress.Diagram.Core.Sides.Bottom)));
            this.diagramShape2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.diagramShape2.Appearance.BorderSize = 0;
            this.diagramShape2.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Content", "FullName"));
            this.diagramShape2.CanMove = false;
            this.diagramShape2.CanSelect = false;
            this.diagramShape2.Position = new DevExpress.Utils.PointFloat(0F, 132F);
            this.diagramShape2.Size = new System.Drawing.SizeF(90F, 15F);
            this.diagramShape2.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant1;
            // 
            // diagramConnector1
            // 
            this.diagramConnector1.Appearance.BorderDashPattern = new DevExpress.Diagram.Core.DiagramDoubleCollection(new double[] {
            4D,
            8D});
            this.diagramConnector1.Appearance.BorderSize = 2;
            this.diagramConnector1.Appearance.ContentBackground = System.Drawing.Color.White;
            this.diagramConnector1.BeginPoint = new DevExpress.Utils.PointFloat(26F, 202F);
            this.diagramConnector1.CanCopy = false;
            this.diagramConnector1.CanDelete = false;
            this.diagramConnector1.CanEdit = false;
            this.diagramConnector1.EndArrow = null;
            this.diagramConnector1.EndPoint = new DevExpress.Utils.PointFloat(138F, 202F);
            this.diagramConnector1.Points = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[0]);
            this.diagramConnector1.TemplateName = "KnowEachOther";
            this.diagramConnector1.ThemeStyleId = DevExpress.Diagram.Core.DiagramConnectorStyleId.Subtle2;
            this.diagramConnector1.Type = DevExpress.Diagram.Core.ConnectorType.Straight;
            // 
            // diagramConnector2
            // 
            this.diagramConnector2.Appearance.BorderSize = 2;
            this.diagramConnector2.Appearance.ContentBackground = System.Drawing.Color.White;
            this.diagramConnector2.BeginPoint = new DevExpress.Utils.PointFloat(26F, 234F);
            this.diagramConnector2.CanCopy = false;
            this.diagramConnector2.CanDelete = false;
            this.diagramConnector2.CanEdit = false;
            this.diagramConnector2.EndArrow = null;
            this.diagramConnector2.EndPoint = new DevExpress.Utils.PointFloat(138F, 234F);
            this.diagramConnector2.Points = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[0]);
            this.diagramConnector2.TemplateName = "Friends";
            this.diagramConnector2.ThemeStyleId = DevExpress.Diagram.Core.DiagramConnectorStyleId.Subtle3;
            this.diagramConnector2.Type = DevExpress.Diagram.Core.ConnectorType.Straight;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.labelKnowEachOther);
            this.layoutControl1.Controls.Add(this.labelFriendsWithCaption);
            this.layoutControl1.Controls.Add(this.labelPhoneNumber);
            this.layoutControl1.Controls.Add(this.labelBirthDate);
            this.layoutControl1.Controls.Add(this.pictureEdit);
            this.layoutControl1.Controls.Add(this.labelName);
            this.layoutControl1.Controls.Add(this.labelAddressLine);
            this.layoutControl1.Controls.Add(this.labelKnowEachOtherCaption);
            this.layoutControl1.Controls.Add(this.labelFriends);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1105, 370, 650, 555);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(249, 472);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // labelKnowEachOther
            // 
            this.labelKnowEachOther.Appearance.Options.UseTextOptions = true;
            this.labelKnowEachOther.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelKnowEachOther.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelKnowEachOther.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelKnowEachOther.Location = new System.Drawing.Point(15, 373);
            this.labelKnowEachOther.Name = "labelKnowEachOther";
            this.labelKnowEachOther.Size = new System.Drawing.Size(219, 1);
            this.labelKnowEachOther.StyleController = this.layoutControl1;
            this.labelKnowEachOther.TabIndex = 9;
            // 
            // labelFriendsWithCaption
            // 
            this.labelFriendsWithCaption.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelFriendsWithCaption.Appearance.Options.UseFont = true;
            this.labelFriendsWithCaption.Appearance.Options.UseTextOptions = true;
            this.labelFriendsWithCaption.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelFriendsWithCaption.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelFriendsWithCaption.Location = new System.Drawing.Point(15, 357);
            this.labelFriendsWithCaption.Name = "labelFriendsWithCaption";
            this.labelFriendsWithCaption.Size = new System.Drawing.Size(219, 16);
            this.labelFriendsWithCaption.StyleController = this.layoutControl1;
            this.labelFriendsWithCaption.TabIndex = 8;
            this.labelFriendsWithCaption.Text = "Friends:";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.Appearance.Options.UseTextOptions = true;
            this.labelPhoneNumber.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelPhoneNumber.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelPhoneNumber.Location = new System.Drawing.Point(15, 318);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(219, 1);
            this.labelPhoneNumber.StyleController = this.layoutControl1;
            this.labelPhoneNumber.TabIndex = 7;
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.Appearance.Options.UseTextOptions = true;
            this.labelBirthDate.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelBirthDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelBirthDate.Location = new System.Drawing.Point(15, 317);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(219, 1);
            this.labelBirthDate.StyleController = this.layoutControl1;
            this.labelBirthDate.TabIndex = 6;
            // 
            // pictureEdit
            // 
            this.pictureEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit.Location = new System.Drawing.Point(15, 32);
            this.pictureEdit.Name = "pictureEdit";
            this.pictureEdit.Properties.ReadOnly = true;
            this.pictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit.Size = new System.Drawing.Size(219, 251);
            this.pictureEdit.StyleController = this.layoutControl1;
            this.pictureEdit.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelName.Appearance.Options.UseFont = true;
            this.labelName.Appearance.Options.UseTextOptions = true;
            this.labelName.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelName.Location = new System.Drawing.Point(15, 298);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(219, 19);
            this.labelName.StyleController = this.layoutControl1;
            this.labelName.TabIndex = 4;
            this.labelName.Text = " ";
            // 
            // labelAddressLine
            // 
            this.labelAddressLine.Appearance.Options.UseTextOptions = true;
            this.labelAddressLine.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelAddressLine.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelAddressLine.Location = new System.Drawing.Point(15, 319);
            this.labelAddressLine.Name = "labelAddressLine";
            this.labelAddressLine.Size = new System.Drawing.Size(219, 1);
            this.labelAddressLine.StyleController = this.layoutControl1;
            this.labelAddressLine.TabIndex = 7;
            // 
            // labelKnowEachOtherCaption
            // 
            this.labelKnowEachOtherCaption.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelKnowEachOtherCaption.Appearance.Options.UseFont = true;
            this.labelKnowEachOtherCaption.Appearance.Options.UseTextOptions = true;
            this.labelKnowEachOtherCaption.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelKnowEachOtherCaption.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelKnowEachOtherCaption.Location = new System.Drawing.Point(15, 330);
            this.labelKnowEachOtherCaption.Name = "labelKnowEachOtherCaption";
            this.labelKnowEachOtherCaption.Size = new System.Drawing.Size(219, 16);
            this.labelKnowEachOtherCaption.StyleController = this.layoutControl1;
            this.labelKnowEachOtherCaption.TabIndex = 7;
            this.labelKnowEachOtherCaption.Text = "Acquaintances:";
            // 
            // labelFriends
            // 
            this.labelFriends.Appearance.Options.UseTextOptions = true;
            this.labelFriends.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelFriends.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelFriends.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelFriends.Location = new System.Drawing.Point(15, 346);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(219, 1);
            this.labelFriends.StyleController = this.layoutControl1;
            this.labelFriends.TabIndex = 7;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.personInfoGroup,
            this.selectPersonLabel});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(15, 15, 15, 15);
            this.layoutControlGroup1.Size = new System.Drawing.Size(249, 472);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // personInfoGroup
            // 
            this.personInfoGroup.GroupBordersVisible = false;
            this.personInfoGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem6,
            this.layoutControlGroup2,
            this.layoutControlItem9,
            this.layoutControlItem7,
            this.emptySpaceItem1});
            this.personInfoGroup.Location = new System.Drawing.Point(0, 17);
            this.personInfoGroup.Name = "personInfoGroup";
            this.personInfoGroup.Size = new System.Drawing.Size(219, 425);
            this.personInfoGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.pictureEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(219, 266);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(219, 266);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 15);
            this.layoutControlItem2.Size = new System.Drawing.Size(219, 266);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.Control = this.labelFriends;
            this.layoutControlItem6.CustomizationFormText = "Phone Number:";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 314);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem6.Size = new System.Drawing.Size(219, 1);
            this.layoutControlItem6.Text = "Friends";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutPhoneNumber,
            this.layoutControlItem5,
            this.layoutControlItem8,
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 266);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AlignLocal;
            this.layoutControlGroup2.Size = new System.Drawing.Size(219, 48);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem3.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutControlItem3.Control = this.labelBirthDate;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 19);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem3.Size = new System.Drawing.Size(219, 1);
            this.layoutControlItem3.Text = "Birth Date:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutPhoneNumber
            // 
            this.layoutPhoneNumber.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutPhoneNumber.AppearanceItemCaption.Options.UseFont = true;
            this.layoutPhoneNumber.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutPhoneNumber.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutPhoneNumber.Control = this.labelPhoneNumber;
            this.layoutPhoneNumber.Location = new System.Drawing.Point(0, 20);
            this.layoutPhoneNumber.Name = "layoutControlItem4";
            this.layoutPhoneNumber.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutPhoneNumber.Size = new System.Drawing.Size(219, 1);
            this.layoutPhoneNumber.Text = "Phone Number:";
            this.layoutPhoneNumber.TextSize = new System.Drawing.Size(0, 0);
            this.layoutPhoneNumber.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem5.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutControlItem5.Control = this.labelAddressLine;
            this.layoutControlItem5.CustomizationFormText = "Phone Number:";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 21);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem5.Size = new System.Drawing.Size(219, 1);
            this.layoutControlItem5.Text = "Adress:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem8.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem8.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutControlItem8.Control = this.labelKnowEachOtherCaption;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 22);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0);
            this.layoutControlItem8.Size = new System.Drawing.Size(219, 26);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem1.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutControlItem1.Control = this.labelName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(219, 19);
            this.layoutControlItem1.Text = "Name:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.labelFriendsWithCaption;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 315);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0);
            this.layoutControlItem9.Size = new System.Drawing.Size(219, 26);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.labelKnowEachOther;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 341);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem7.Size = new System.Drawing.Size(219, 1);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 342);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(219, 83);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // selectPersonLabel
            // 
            this.selectPersonLabel.AllowHotTrack = false;
            this.selectPersonLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.selectPersonLabel.AppearanceItemCaption.Options.UseFont = true;
            this.selectPersonLabel.AppearanceItemCaption.Options.UseTextOptions = true;
            this.selectPersonLabel.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.selectPersonLabel.Location = new System.Drawing.Point(0, 0);
            this.selectPersonLabel.Name = "selectPersonLabel";
            this.selectPersonLabel.Size = new System.Drawing.Size(219, 17);
            this.selectPersonLabel.Text = "Select a person to see relationships";
            this.selectPersonLabel.TextSize = new System.Drawing.Size(201, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.labelPhoneNumber;
            this.layoutControlItem4.Location = new System.Drawing.Point(126, 34);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem4.Size = new System.Drawing.Size(144, 389);
            this.layoutControlItem4.Text = "Phone Number:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // diagramShape1
            // 
            this.diagramShape1.AffectedByLayoutAlgorithms = false;
            this.diagramShape1.Appearance.BorderSize = 0;
            this.diagramShape1.BackgroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White;
            this.diagramShape1.CanMove = false;
            this.diagramShape1.CanSelect = false;
            this.diagramShape1.Position = new DevExpress.Utils.PointFloat(810F, 30F);
            this.diagramShape1.Size = new System.Drawing.SizeF(160F, 80F);
            // 
            // diagramShape3
            // 
            this.diagramShape3.AffectedByLayoutAlgorithms = false;
            this.diagramShape3.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.diagramShape3.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.diagramShape3.BackgroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White;
            this.diagramShape3.CanMove = false;
            this.diagramShape3.CanSelect = false;
            this.diagramShape3.Content = "Know each other";
            this.diagramShape3.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White_5;
            this.diagramShape3.Position = new DevExpress.Utils.PointFloat(810F, 30F);
            this.diagramShape3.Size = new System.Drawing.SizeF(160F, 30F);
            // 
            // diagramShape4
            // 
            this.diagramShape4.AffectedByLayoutAlgorithms = false;
            this.diagramShape4.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.diagramShape4.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.diagramShape4.BackgroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White;
            this.diagramShape4.CanMove = false;
            this.diagramShape4.CanSelect = false;
            this.diagramShape4.Content = "Friends with";
            this.diagramShape4.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White_5;
            this.diagramShape4.Position = new DevExpress.Utils.PointFloat(810F, 70F);
            this.diagramShape4.Size = new System.Drawing.SizeF(160F, 30F);
            // 
            // diagramConnector3
            // 
            this.diagramConnector3.AffectedByLayoutAlgorithms = false;
            this.diagramConnector3.Appearance.BorderDashPattern = new DevExpress.Diagram.Core.DiagramDoubleCollection(new double[] {
            4D,
            8D});
            this.diagramConnector3.Appearance.ContentBackground = System.Drawing.Color.White;
            this.diagramConnector3.BeginPoint = new DevExpress.Utils.PointFloat(820F, 100F);
            this.diagramConnector3.CanMove = false;
            this.diagramConnector3.CanSelect = false;
            this.diagramConnector3.EndArrow = null;
            this.diagramConnector3.EndPoint = new DevExpress.Utils.PointFloat(960F, 100F);
            this.diagramConnector3.Points = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[0]);
            this.diagramConnector3.ThemeStyleId = DevExpress.Diagram.Core.DiagramConnectorStyleId.Intense2;
            // 
            // diagramConnector4
            // 
            this.diagramConnector4.AffectedByLayoutAlgorithms = false;
            this.diagramConnector4.Appearance.ContentBackground = System.Drawing.Color.White;
            this.diagramConnector4.BeginPoint = new DevExpress.Utils.PointFloat(820F, 60F);
            this.diagramConnector4.CanMove = false;
            this.diagramConnector4.CanSelect = false;
            this.diagramConnector4.EndArrow = null;
            this.diagramConnector4.EndPoint = new DevExpress.Utils.PointFloat(960F, 60F);
            this.diagramConnector4.Points = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[0]);
            this.diagramConnector4.ThemeStyleId = DevExpress.Diagram.Core.DiagramConnectorStyleId.Intense3;
            // 
            // RelationshipDiagramModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "RelationshipDiagramModule";
            this.OptionsPageControls.Add(this.layoutControl1);
            this.ShowOptionsPanel = true;
            this.Size = new System.Drawing.Size(987, 505);
            this.containerControl.ResumeLayout(false);
            this.containerControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1.TemplateDiagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramDataBindingController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationshipInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personInfoGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutPhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectPersonLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DiagramDataBindingController diagramDataBindingController1;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraEditors.LabelControl labelName;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraEditors.PictureEdit pictureEdit;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraEditors.LabelControl labelPhoneNumber;
        private XtraEditors.LabelControl labelBirthDate;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControlItem layoutPhoneNumber;
        private XtraEditors.LabelControl labelAddressLine;
        private XtraEditors.LabelControl labelKnowEachOtherCaption;
        private XtraEditors.LabelControl labelFriends;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraLayout.LayoutControlItem layoutControlItem8;
        private XtraLayout.LayoutControlItem layoutControlItem6;
        private XtraLayout.LayoutControlGroup personInfoGroup;
        private XtraLayout.SimpleLabelItem selectPersonLabel;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private System.Windows.Forms.BindingSource relationshipInfoBindingSource;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DiagramShape diagramShape1;
        private DiagramShape diagramShape3;
        private DiagramShape diagramShape4;
        private DiagramConnector diagramConnector3;
        private DiagramConnector diagramConnector4;
        private DiagramContainer diagramContainer1;
        private DiagramImage diagramImage1;
        private DiagramShape diagramShape2;
        private DiagramConnector diagramConnector1;
        private DiagramConnector diagramConnector2;
        private XtraEditors.LabelControl labelKnowEachOther;
        private XtraEditors.LabelControl labelFriendsWithCaption;
        private XtraLayout.LayoutControlItem layoutControlItem9;
        private XtraLayout.LayoutControlItem layoutControlItem7;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}
