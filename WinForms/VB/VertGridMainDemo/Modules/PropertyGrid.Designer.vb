Namespace DevExpress.XtraVerticalGrid.Demos

    Partial Class PropertyGrid

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraVerticalGrid.Demos.PropertyGrid))
            Me.diagramControl1 = New DevExpress.XtraDiagram.DiagramControl()
            Me.diagramShape1 = New DevExpress.XtraDiagram.DiagramShape()
            Me.diagramShape2 = New DevExpress.XtraDiagram.DiagramShape()
            Me.diagramShape3 = New DevExpress.XtraDiagram.DiagramShape()
            Me.diagramShape4 = New DevExpress.XtraDiagram.DiagramShape()
            Me.diagramShape5 = New DevExpress.XtraDiagram.DiagramShape()
            Me.diagramShape6 = New DevExpress.XtraDiagram.DiagramShape()
            Me.diagramShape7 = New DevExpress.XtraDiagram.DiagramShape()
            Me.diagramShape8 = New DevExpress.XtraDiagram.DiagramShape()
            Me.diagramShape9 = New DevExpress.XtraDiagram.DiagramShape()
            Me.diagramShape10 = New DevExpress.XtraDiagram.DiagramShape()
            Me.diagramShape11 = New DevExpress.XtraDiagram.DiagramShape()
            Me.propertyGridControl1 = New DevExpress.XtraVerticalGrid.PropertyGridControl()
            Me.tabAppearance = New DevExpress.XtraVerticalGrid.Tab()
            Me.tabOptions = New DevExpress.XtraVerticalGrid.Tab()
            Me.separatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
            Me.propertyDescriptionControl1 = New DevExpress.XtraVerticalGrid.PropertyDescriptionControl()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            CType((Me.diagramControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.propertyGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.separatorControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' diagramControl1
            ' 
            Me.diagramControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.diagramControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.diagramControl1.Items.AddRange(New DevExpress.XtraDiagram.DiagramItem() {Me.diagramShape1, Me.diagramShape2, Me.diagramShape3, Me.diagramShape4, Me.diagramShape5, Me.diagramShape6, Me.diagramShape7, Me.diagramShape8, Me.diagramShape9, Me.diagramShape10, Me.diagramShape11})
            Me.diagramControl1.Location = New System.Drawing.Point(0, 0)
            Me.diagramControl1.Name = "diagramControl1"
            Me.diagramControl1.OptionsBehavior.ScrollMode = DevExpress.Diagram.Core.DiagramScrollMode.Content
            Me.diagramControl1.OptionsBehavior.SelectedStencils = New DevExpress.Diagram.Core.StencilCollection(New String() {"BasicShapes", "BasicFlowchartShapes"})
            Me.diagramControl1.OptionsView.PageSize = New System.Drawing.SizeF(608F, 528.0001F)
            Me.diagramControl1.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Custom
            Me.diagramControl1.OptionsView.ShowGrid = False
            Me.diagramControl1.OptionsView.ShowPageBreaks = False
            Me.diagramControl1.OptionsView.ShowRulers = False
            Me.diagramControl1.Size = New System.Drawing.Size(382, 392)
            Me.diagramControl1.TabIndex = 1
            Me.diagramControl1.Text = "diagramControl1"
            AddHandler Me.diagramControl1.SelectionChanged, New System.EventHandler(Of DevExpress.XtraDiagram.DiagramSelectionChangedEventArgs)(AddressOf Me.OnDiagramControlSelectionChanged)
            ' 
            ' diagramShape1
            ' 
            Me.diagramShape1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((27)))))), (CInt(((CByte((161)))))), (CInt(((CByte((221)))))))
            Me.diagramShape1.Appearance.Font = New System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Italic)
            Me.diagramShape1.Content = "PLAN" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "&" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "DESIGN"
            Me.diagramShape1.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White
            Me.diagramShape1.Position = New DevExpress.Utils.PointFloat(249F, 24F)
            Me.diagramShape1.Shape = DevExpress.Diagram.Core.BasicShapes.Ellipse
            Me.diagramShape1.Size = New System.Drawing.SizeF(110F, 110F)
            Me.diagramShape1.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Light_4
            ' 
            ' diagramShape2
            ' 
            Me.diagramShape2.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((51)))))), (CInt(((CByte((153)))))), (CInt(((CByte((51)))))))
            Me.diagramShape2.Appearance.Font = New System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Italic)
            Me.diagramShape2.Content = "VISITOR" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "ANALYSIS "
            Me.diagramShape2.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White
            Me.diagramShape2.Position = New DevExpress.Utils.PointFloat(474F, 164F)
            Me.diagramShape2.Shape = DevExpress.Diagram.Core.BasicShapes.Ellipse
            Me.diagramShape2.Size = New System.Drawing.SizeF(110F, 110F)
            Me.diagramShape2.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Light_4
            Me.diagramShape2.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant2
            ' 
            ' diagramShape3
            ' 
            Me.diagramShape3.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((162)))))), (CInt(((CByte((0)))))), (CInt(((CByte((255)))))))
            Me.diagramShape3.Appearance.Font = New System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Italic)
            Me.diagramShape3.Content = "MAINTAIN QUALITY"
            Me.diagramShape3.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White
            Me.diagramShape3.Position = New DevExpress.Utils.PointFloat(24F, 164F)
            Me.diagramShape3.Shape = DevExpress.Diagram.Core.BasicShapes.Ellipse
            Me.diagramShape3.Size = New System.Drawing.SizeF(110F, 110F)
            Me.diagramShape3.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Light_4
            Me.diagramShape3.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Balanced5
            ' 
            ' diagramShape4
            ' 
            Me.diagramShape4.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((240)))))), (CInt(((CByte((150)))))), (CInt(((CByte((0)))))))
            Me.diagramShape4.Appearance.Font = New System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Italic)
            Me.diagramShape4.Content = "SEO"
            Me.diagramShape4.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White
            Me.diagramShape4.Position = New DevExpress.Utils.PointFloat(124F, 394.0001F)
            Me.diagramShape4.Shape = DevExpress.Diagram.Core.BasicShapes.Ellipse
            Me.diagramShape4.Size = New System.Drawing.SizeF(110F, 110F)
            Me.diagramShape4.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Light_4
            Me.diagramShape4.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant4
            ' 
            ' diagramShape5
            ' 
            Me.diagramShape5.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((216)))))), (CInt(((CByte((0)))))), (CInt(((CByte((115)))))))
            Me.diagramShape5.Appearance.Font = New System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Italic)
            Me.diagramShape5.Content = "PROMOTE"
            Me.diagramShape5.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White
            Me.diagramShape5.Position = New DevExpress.Utils.PointFloat(378F, 394.0001F)
            Me.diagramShape5.Shape = DevExpress.Diagram.Core.BasicShapes.Ellipse
            Me.diagramShape5.Size = New System.Drawing.SizeF(110F, 110F)
            Me.diagramShape5.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Light_4
            Me.diagramShape5.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant3
            ' 
            ' diagramShape6
            ' 
            Me.diagramShape6.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((27)))))), (CInt(((CByte((161)))))), (CInt(((CByte((221)))))))
            Me.diagramShape6.Appearance.Font = New System.Drawing.Font("Segoe UI", 14F, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline)), System.Drawing.FontStyle))
            Me.diagramShape6.Content = "INTERNET MARKETING PROCESS"
            Me.diagramShape6.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White
            Me.diagramShape6.Position = New DevExpress.Utils.PointFloat(224F, 214F)
            Me.diagramShape6.Size = New System.Drawing.SizeF(160F, 90F)
            Me.diagramShape6.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Light_4
            ' 
            ' diagramShape7
            ' 
            Me.diagramShape7.Angle = 150F
            Me.diagramShape7.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((27)))))), (CInt(((CByte((161)))))), (CInt(((CByte((221)))))))
            Me.diagramShape7.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White
            Me.diagramShape7.Position = New DevExpress.Utils.PointFloat(384F, 104F)
            Me.diagramShape7.Shape = DevExpress.Diagram.Core.ArrowShapes.SimpleArrow
            Me.diagramShape7.Size = New System.Drawing.SizeF(100F, 50F)
            Me.diagramShape7.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Light_4
            ' 
            ' diagramShape8
            ' 
            Me.diagramShape8.Angle = 60F
            Me.diagramShape8.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((51)))))), (CInt(((CByte((153)))))), (CInt(((CByte((51)))))))
            Me.diagramShape8.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White
            Me.diagramShape8.Position = New DevExpress.Utils.PointFloat(443F, 312.0001F)
            Me.diagramShape8.Shape = DevExpress.Diagram.Core.ArrowShapes.SimpleArrow
            Me.diagramShape8.Size = New System.Drawing.SizeF(104F, 50F)
            Me.diagramShape8.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Light_4
            Me.diagramShape8.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant2
            ' 
            ' diagramShape9
            ' 
            Me.diagramShape9.Angle = -60F
            Me.diagramShape9.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((240)))))), (CInt(((CByte((150)))))), (CInt(((CByte((0)))))))
            Me.diagramShape9.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White
            Me.diagramShape9.Position = New DevExpress.Utils.PointFloat(64F, 304.0001F)
            Me.diagramShape9.Shape = DevExpress.Diagram.Core.ArrowShapes.SimpleArrow
            Me.diagramShape9.Size = New System.Drawing.SizeF(100F, 50F)
            Me.diagramShape9.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Light_4
            Me.diagramShape9.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant4
            ' 
            ' diagramShape10
            ' 
            Me.diagramShape10.Angle = -150F
            Me.diagramShape10.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((162)))))), (CInt(((CByte((0)))))), (CInt(((CByte((255)))))))
            Me.diagramShape10.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White
            Me.diagramShape10.Position = New DevExpress.Utils.PointFloat(134F, 104F)
            Me.diagramShape10.Shape = DevExpress.Diagram.Core.ArrowShapes.SimpleArrow
            Me.diagramShape10.Size = New System.Drawing.SizeF(100F, 50F)
            Me.diagramShape10.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Light_4
            Me.diagramShape10.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Balanced5
            ' 
            ' diagramShape11
            ' 
            Me.diagramShape11.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((216)))))), (CInt(((CByte((0)))))), (CInt(((CByte((115)))))))
            Me.diagramShape11.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White
            Me.diagramShape11.Position = New DevExpress.Utils.PointFloat(249F, 424.0001F)
            Me.diagramShape11.Shape = DevExpress.Diagram.Core.ArrowShapes.SimpleArrow
            Me.diagramShape11.Size = New System.Drawing.SizeF(110F, 50F)
            Me.diagramShape11.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Light_4
            Me.diagramShape11.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant3
            ' 
            ' propertyGridControl1
            ' 
            Me.propertyGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.propertyGridControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.propertyGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.propertyGridControl1.Location = New System.Drawing.Point(1, 0)
            Me.propertyGridControl1.Name = "propertyGridControl1"
            Me.propertyGridControl1.OptionsFind.FindFilterColumns = "Caption"
            Me.propertyGridControl1.OptionsFind.Location = DevExpress.XtraVerticalGrid.FindPanelLocation.TabPanel
            Me.propertyGridControl1.OptionsView.AllowReadOnlyRowAppearance = DevExpress.Utils.DefaultBoolean.[True]
            Me.propertyGridControl1.OptionsView.GradientHeight = 20
            Me.propertyGridControl1.OptionsView.MinRowAutoHeight = 20
            Me.propertyGridControl1.OptionsView.ShowRowBrick = DevExpress.Utils.DefaultBoolean.[True]
            Me.propertyGridControl1.SelectedObject = Me.diagramShape6
            Me.propertyGridControl1.SelectedTab = Me.tabAppearance
            Me.propertyGridControl1.Size = New System.Drawing.Size(329, 328)
            Me.propertyGridControl1.TabIndex = 0
            Me.propertyGridControl1.Tabs.AddRange(New DevExpress.XtraVerticalGrid.Tab() {Me.tabAppearance, Me.tabOptions})
            AddHandler Me.propertyGridControl1.CustomRowCreated, New DevExpress.XtraVerticalGrid.Events.CustomRowCreatedEventHandler(AddressOf Me.OnPropertyGridCustomRowCreated)
            AddHandler Me.propertyGridControl1.InvalidValueException, New DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(AddressOf Me.OnPropertyGridInvalidValueException)
            AddHandler Me.propertyGridControl1.PopupMenuShowing, New DevExpress.XtraVerticalGrid.Events.PopupMenuShowingEventHandler(AddressOf Me.OnPropertyGridPopupMenuShowing)
            ' 
            ' tabAppearance
            ' 
            Me.tabAppearance.Appearance.Image = CType((resources.GetObject("tabAppearance.Appearance.Image")), System.Drawing.Image)
            Me.tabAppearance.Appearance.Options.UseImage = True
            Me.tabAppearance.FieldNames.Add("Appearance.BackColor")
            Me.tabAppearance.FieldNames.Add("Appearance.BorderColor")
            Me.tabAppearance.FieldNames.Add("Appearance.BorderSize")
            Me.tabAppearance.FieldNames.Add("Appearance.Font")
            Me.tabAppearance.FieldNames.Add("Appearance.ForeColor")
            Me.tabAppearance.FieldNames.Add("Appearance.TextOptions.HAlignment")
            Me.tabAppearance.FieldNames.Add("Appearance.TextOptions.VAlignment")
            Me.tabAppearance.FieldNames.Add("Anchors")
            Me.tabAppearance.FieldNames.Add("Position")
            Me.tabAppearance.FieldNames.Add("Size.Height")
            Me.tabAppearance.FieldNames.Add("Size.Width")
            Me.tabAppearance.FieldNames.Add("Angle")
            Me.tabAppearance.ImageOptions.SvgImage = CType((resources.GetObject("tabAppearance.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.tabAppearance.ImageOptions.SvgImageSize = New System.Drawing.Size(24, 24)
            Me.tabAppearance.Name = "tabAppearance"
            Me.tabAppearance.UseCaption = False
            ' 
            ' tabOptions
            ' 
            Me.tabOptions.FieldNames.Add("categoryBehavior")
            Me.tabOptions.FieldNames.Add("categoryExpand___Collapse")
            Me.tabOptions.FieldNames.Add("categoryLayout")
            Me.tabOptions.ImageOptions.SvgImage = CType((resources.GetObject("tabOptions.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.tabOptions.ImageOptions.SvgImageSize = New System.Drawing.Size(22, 22)
            Me.tabOptions.Name = "tabOptions"
            Me.tabOptions.UseCaption = False
            ' 
            ' separatorControl1
            ' 
            Me.separatorControl1.AutoSizeMode = True
            Me.separatorControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.separatorControl1.Location = New System.Drawing.Point(1, 328)
            Me.separatorControl1.Name = "separatorControl1"
            Me.separatorControl1.Padding = New System.Windows.Forms.Padding(0)
            Me.separatorControl1.Size = New System.Drawing.Size(329, 1)
            Me.separatorControl1.TabIndex = 5
            ' 
            ' propertyDescriptionControl1
            ' 
            Me.propertyDescriptionControl1.AutoHeight = True
            Me.propertyDescriptionControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.propertyDescriptionControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.propertyDescriptionControl1.Location = New System.Drawing.Point(1, 329)
            Me.propertyDescriptionControl1.Name = "propertyDescriptionControl1"
            Me.propertyDescriptionControl1.PropertyGrid = Me.propertyGridControl1
            Me.propertyDescriptionControl1.Size = New System.Drawing.Size(329, 63)
            Me.propertyDescriptionControl1.TabIndex = 4
            Me.propertyDescriptionControl1.TabStop = False
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.propertyGridControl1)
            Me.sidePanel1.Controls.Add(Me.separatorControl1)
            Me.sidePanel1.Controls.Add(Me.propertyDescriptionControl1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(382, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(330, 392)
            Me.sidePanel1.TabIndex = 3
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' PropertyGrid
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.diagramControl1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "PropertyGrid"
            Me.Size = New System.Drawing.Size(712, 392)
            CType((Me.diagramControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.propertyGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.separatorControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private propertyGridControl1 As DevExpress.XtraVerticalGrid.PropertyGridControl

        Private components As System.ComponentModel.IContainer = Nothing

        Private diagramControl1 As DevExpress.XtraDiagram.DiagramControl

        Private propertyDescriptionControl1 As DevExpress.XtraVerticalGrid.PropertyDescriptionControl

        Private tabAppearance As DevExpress.XtraVerticalGrid.Tab

        Private tabOptions As DevExpress.XtraVerticalGrid.Tab

        Private diagramShape1 As DevExpress.XtraDiagram.DiagramShape

        Private diagramShape2 As DevExpress.XtraDiagram.DiagramShape

        Private diagramShape3 As DevExpress.XtraDiagram.DiagramShape

        Private diagramShape4 As DevExpress.XtraDiagram.DiagramShape

        Private diagramShape5 As DevExpress.XtraDiagram.DiagramShape

        Private diagramShape6 As DevExpress.XtraDiagram.DiagramShape

        Private diagramShape7 As DevExpress.XtraDiagram.DiagramShape

        Private diagramShape8 As DevExpress.XtraDiagram.DiagramShape

        Private diagramShape9 As DevExpress.XtraDiagram.DiagramShape

        Private diagramShape10 As DevExpress.XtraDiagram.DiagramShape

        Private diagramShape11 As DevExpress.XtraDiagram.DiagramShape

        Private separatorControl1 As DevExpress.XtraEditors.SeparatorControl

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel
    End Class
End Namespace
