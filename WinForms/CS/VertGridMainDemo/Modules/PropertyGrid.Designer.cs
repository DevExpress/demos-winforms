namespace DevExpress.XtraVerticalGrid.Demos {
    partial class PropertyGrid {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropertyGrid));
            this.diagramControl1 = new DevExpress.XtraDiagram.DiagramControl();
            this.diagramShape1 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape2 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape3 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape4 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape5 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape6 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape7 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape8 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape9 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape10 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape11 = new DevExpress.XtraDiagram.DiagramShape();
            this.propertyGridControl1 = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            this.tabAppearance = new DevExpress.XtraVerticalGrid.Tab();
            this.tabOptions = new DevExpress.XtraVerticalGrid.Tab();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.propertyDescriptionControl1 = new DevExpress.XtraVerticalGrid.PropertyDescriptionControl();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // diagramControl1
            // 
            this.diagramControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.diagramControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagramControl1.Items.AddRange(new DevExpress.XtraDiagram.DiagramItem[] {
            this.diagramShape1,
            this.diagramShape2,
            this.diagramShape3,
            this.diagramShape4,
            this.diagramShape5,
            this.diagramShape6,
            this.diagramShape7,
            this.diagramShape8,
            this.diagramShape9,
            this.diagramShape10,
            this.diagramShape11});
            this.diagramControl1.Location = new System.Drawing.Point(0, 0);
            this.diagramControl1.Name = "diagramControl1";
            this.diagramControl1.OptionsBehavior.ScrollMode = DevExpress.Diagram.Core.DiagramScrollMode.Content;
            this.diagramControl1.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "BasicShapes",
            "BasicFlowchartShapes"});
            this.diagramControl1.OptionsView.PageSize = new System.Drawing.SizeF(608F, 528.0001F);
            this.diagramControl1.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.diagramControl1.OptionsView.ShowGrid = false;
            this.diagramControl1.OptionsView.ShowPageBreaks = false;
            this.diagramControl1.OptionsView.ShowRulers = false;
            this.diagramControl1.Size = new System.Drawing.Size(382, 392);
            this.diagramControl1.TabIndex = 1;
            this.diagramControl1.Text = "diagramControl1";
            this.diagramControl1.SelectionChanged += new System.EventHandler<DevExpress.XtraDiagram.DiagramSelectionChangedEventArgs>(this.OnDiagramControlSelectionChanged);
            // 
            // diagramShape1
            // 
            this.diagramShape1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(221)))));
            this.diagramShape1.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Italic);
            this.diagramShape1.Content = "PLAN\r\n&\r\nDESIGN";
            this.diagramShape1.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White;
            this.diagramShape1.Position = new DevExpress.Utils.PointFloat(249F, 24F);
            this.diagramShape1.Shape = DevExpress.Diagram.Core.BasicShapes.Ellipse;
            this.diagramShape1.Size = new System.Drawing.SizeF(110F, 110F);
            this.diagramShape1.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Light_4;
            // 
            // diagramShape2
            // 
            this.diagramShape2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.diagramShape2.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Italic);
            this.diagramShape2.Content = "VISITOR\r\nANALYSIS ";
            this.diagramShape2.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White;
            this.diagramShape2.Position = new DevExpress.Utils.PointFloat(474F, 164F);
            this.diagramShape2.Shape = DevExpress.Diagram.Core.BasicShapes.Ellipse;
            this.diagramShape2.Size = new System.Drawing.SizeF(110F, 110F);
            this.diagramShape2.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Light_4;
            this.diagramShape2.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant2;
            // 
            // diagramShape3
            // 
            this.diagramShape3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.diagramShape3.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Italic);
            this.diagramShape3.Content = "MAINTAIN QUALITY";
            this.diagramShape3.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White;
            this.diagramShape3.Position = new DevExpress.Utils.PointFloat(24F, 164F);
            this.diagramShape3.Shape = DevExpress.Diagram.Core.BasicShapes.Ellipse;
            this.diagramShape3.Size = new System.Drawing.SizeF(110F, 110F);
            this.diagramShape3.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Light_4;
            this.diagramShape3.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Balanced5;
            // 
            // diagramShape4
            // 
            this.diagramShape4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.diagramShape4.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Italic);
            this.diagramShape4.Content = "SEO";
            this.diagramShape4.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White;
            this.diagramShape4.Position = new DevExpress.Utils.PointFloat(124F, 394.0001F);
            this.diagramShape4.Shape = DevExpress.Diagram.Core.BasicShapes.Ellipse;
            this.diagramShape4.Size = new System.Drawing.SizeF(110F, 110F);
            this.diagramShape4.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Light_4;
            this.diagramShape4.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant4;
            // 
            // diagramShape5
            // 
            this.diagramShape5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.diagramShape5.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Italic);
            this.diagramShape5.Content = "PROMOTE";
            this.diagramShape5.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White;
            this.diagramShape5.Position = new DevExpress.Utils.PointFloat(378F, 394.0001F);
            this.diagramShape5.Shape = DevExpress.Diagram.Core.BasicShapes.Ellipse;
            this.diagramShape5.Size = new System.Drawing.SizeF(110F, 110F);
            this.diagramShape5.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Light_4;
            this.diagramShape5.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant3;
            // 
            // diagramShape6
            // 
            this.diagramShape6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(221)))));
            this.diagramShape6.Appearance.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.diagramShape6.Content = "INTERNET MARKETING PROCESS";
            this.diagramShape6.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White;
            this.diagramShape6.Position = new DevExpress.Utils.PointFloat(224F, 214F);
            this.diagramShape6.Size = new System.Drawing.SizeF(160F, 90F);
            this.diagramShape6.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Light_4;
            // 
            // diagramShape7
            // 
            this.diagramShape7.Angle = 150F;
            this.diagramShape7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(221)))));
            this.diagramShape7.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White;
            this.diagramShape7.Position = new DevExpress.Utils.PointFloat(384F, 104F);
            this.diagramShape7.Shape = DevExpress.Diagram.Core.ArrowShapes.SimpleArrow;
            this.diagramShape7.Size = new System.Drawing.SizeF(100F, 50F);
            this.diagramShape7.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Light_4;
            // 
            // diagramShape8
            // 
            this.diagramShape8.Angle = 60F;
            this.diagramShape8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.diagramShape8.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White;
            this.diagramShape8.Position = new DevExpress.Utils.PointFloat(443F, 312.0001F);
            this.diagramShape8.Shape = DevExpress.Diagram.Core.ArrowShapes.SimpleArrow;
            this.diagramShape8.Size = new System.Drawing.SizeF(104F, 50F);
            this.diagramShape8.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Light_4;
            this.diagramShape8.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant2;
            // 
            // diagramShape9
            // 
            this.diagramShape9.Angle = -60F;
            this.diagramShape9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.diagramShape9.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White;
            this.diagramShape9.Position = new DevExpress.Utils.PointFloat(64F, 304.0001F);
            this.diagramShape9.Shape = DevExpress.Diagram.Core.ArrowShapes.SimpleArrow;
            this.diagramShape9.Size = new System.Drawing.SizeF(100F, 50F);
            this.diagramShape9.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Light_4;
            this.diagramShape9.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant4;
            // 
            // diagramShape10
            // 
            this.diagramShape10.Angle = -150F;
            this.diagramShape10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.diagramShape10.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White;
            this.diagramShape10.Position = new DevExpress.Utils.PointFloat(134F, 104F);
            this.diagramShape10.Shape = DevExpress.Diagram.Core.ArrowShapes.SimpleArrow;
            this.diagramShape10.Size = new System.Drawing.SizeF(100F, 50F);
            this.diagramShape10.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Light_4;
            this.diagramShape10.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Balanced5;
            // 
            // diagramShape11
            // 
            this.diagramShape11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.diagramShape11.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White;
            this.diagramShape11.Position = new DevExpress.Utils.PointFloat(249F, 424.0001F);
            this.diagramShape11.Shape = DevExpress.Diagram.Core.ArrowShapes.SimpleArrow;
            this.diagramShape11.Size = new System.Drawing.SizeF(110F, 50F);
            this.diagramShape11.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Light_4;
            this.diagramShape11.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant3;
            // 
            // propertyGridControl1
            // 
            this.propertyGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.propertyGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.propertyGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridControl1.Location = new System.Drawing.Point(1, 0);
            this.propertyGridControl1.Name = "propertyGridControl1";
            this.propertyGridControl1.OptionsFind.FindFilterColumns = "Caption";
            this.propertyGridControl1.OptionsFind.Location = DevExpress.XtraVerticalGrid.FindPanelLocation.TabPanel;
            this.propertyGridControl1.OptionsView.AllowReadOnlyRowAppearance = DevExpress.Utils.DefaultBoolean.True;
            this.propertyGridControl1.OptionsView.GradientHeight = 20;
            this.propertyGridControl1.OptionsView.MinRowAutoHeight = 20;
            this.propertyGridControl1.OptionsView.ShowRowBrick = DevExpress.Utils.DefaultBoolean.True;
            this.propertyGridControl1.SelectedObject = this.diagramShape6;
            this.propertyGridControl1.SelectedTab = this.tabAppearance;
            this.propertyGridControl1.Size = new System.Drawing.Size(329, 328);
            this.propertyGridControl1.TabIndex = 0;
            this.propertyGridControl1.Tabs.AddRange(new DevExpress.XtraVerticalGrid.Tab[] {
            this.tabAppearance,
            this.tabOptions});
            this.propertyGridControl1.CustomRowCreated += new DevExpress.XtraVerticalGrid.Events.CustomRowCreatedEventHandler(this.OnPropertyGridCustomRowCreated);
            this.propertyGridControl1.InvalidValueException += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.OnPropertyGridInvalidValueException);
            this.propertyGridControl1.PopupMenuShowing += new DevExpress.XtraVerticalGrid.Events.PopupMenuShowingEventHandler(this.OnPropertyGridPopupMenuShowing);
            // 
            // tabAppearance
            // 
            this.tabAppearance.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("tabAppearance.Appearance.Image")));
            this.tabAppearance.Appearance.Options.UseImage = true;
            this.tabAppearance.FieldNames.Add("Appearance.BackColor");
            this.tabAppearance.FieldNames.Add("Appearance.BorderColor");
            this.tabAppearance.FieldNames.Add("Appearance.BorderSize");
            this.tabAppearance.FieldNames.Add("Appearance.Font");
            this.tabAppearance.FieldNames.Add("Appearance.ForeColor");
            this.tabAppearance.FieldNames.Add("Appearance.TextOptions.HAlignment");
            this.tabAppearance.FieldNames.Add("Appearance.TextOptions.VAlignment");
            this.tabAppearance.FieldNames.Add("Anchors");
            this.tabAppearance.FieldNames.Add("Position");
            this.tabAppearance.FieldNames.Add("Size.Height");
            this.tabAppearance.FieldNames.Add("Size.Width");
            this.tabAppearance.FieldNames.Add("Angle");
            this.tabAppearance.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tabAppearance.ImageOptions.SvgImage")));
            this.tabAppearance.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.tabAppearance.Name = "tabAppearance";
            this.tabAppearance.UseCaption = false;
            // 
            // tabOptions
            // 
            this.tabOptions.FieldNames.Add("categoryBehavior");
            this.tabOptions.FieldNames.Add("categoryExpand___Collapse");
            this.tabOptions.FieldNames.Add("categoryLayout");
            this.tabOptions.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tabOptions.ImageOptions.SvgImage")));
            this.tabOptions.ImageOptions.SvgImageSize = new System.Drawing.Size(22, 22);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.UseCaption = false;
            // 
            // separatorControl1
            // 
            this.separatorControl1.AutoSizeMode = true;
            this.separatorControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.separatorControl1.Location = new System.Drawing.Point(1, 328);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(0);
            this.separatorControl1.Size = new System.Drawing.Size(329, 1);
            this.separatorControl1.TabIndex = 5;
            // 
            // propertyDescriptionControl1
            // 
            this.propertyDescriptionControl1.AutoHeight = true;
            this.propertyDescriptionControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.propertyDescriptionControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.propertyDescriptionControl1.Location = new System.Drawing.Point(1, 329);
            this.propertyDescriptionControl1.Name = "propertyDescriptionControl1";
            this.propertyDescriptionControl1.PropertyGrid = this.propertyGridControl1;
            this.propertyDescriptionControl1.Size = new System.Drawing.Size(329, 63);
            this.propertyDescriptionControl1.TabIndex = 4;
            this.propertyDescriptionControl1.TabStop = false;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.propertyGridControl1);
            this.sidePanel1.Controls.Add(this.separatorControl1);
            this.sidePanel1.Controls.Add(this.propertyDescriptionControl1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(382, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(330, 392);
            this.sidePanel1.TabIndex = 3;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // PropertyGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.diagramControl1);
            this.Controls.Add(this.sidePanel1);
            this.Name = "PropertyGrid";
            this.Size = new System.Drawing.Size(712, 392);
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGridControl1;
        private System.ComponentModel.IContainer components = null;
        private XtraDiagram.DiagramControl diagramControl1;
        private PropertyDescriptionControl propertyDescriptionControl1;
        private Tab tabAppearance;
        private Tab tabOptions;
        private XtraDiagram.DiagramShape diagramShape1;
        private XtraDiagram.DiagramShape diagramShape2;
        private XtraDiagram.DiagramShape diagramShape3;
        private XtraDiagram.DiagramShape diagramShape4;
        private XtraDiagram.DiagramShape diagramShape5;
        private XtraDiagram.DiagramShape diagramShape6;
        private XtraDiagram.DiagramShape diagramShape7;
        private XtraDiagram.DiagramShape diagramShape8;
        private XtraDiagram.DiagramShape diagramShape9;
        private XtraDiagram.DiagramShape diagramShape10;
        private XtraDiagram.DiagramShape diagramShape11;
        private XtraEditors.SeparatorControl separatorControl1;
        private XtraEditors.SidePanel sidePanel1;
    }
}
