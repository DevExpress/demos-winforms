Namespace DevExpress.XtraDiagram.Demos

    Partial Class ExpandAndCollapseOrgChartModule

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.fitToItemsGroup = New DevExpress.XtraDiagram.Demos.OptionsPanelGroupControl()
            Me.fitToItemsButton = New DevExpress.XtraEditors.SimpleButton()
            Me.employeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.diagramOrgChartController1 = New DevExpress.XtraDiagram.DiagramOrgChartController(Me.components)
            Me.diagramContainer1 = New DevExpress.XtraDiagram.DiagramContainer()
            Me.diagramShape1 = New DevExpress.XtraDiagram.DiagramShape()
            Me.diagramShape2 = New DevExpress.XtraDiagram.DiagramShape()
            Me.diagramShape3 = New DevExpress.XtraDiagram.DiagramShape()
            Me.diagramConnector1 = New DevExpress.XtraDiagram.DiagramConnector()
            Me.layoutKindGroup = New DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup()
            Me.containerControl.SuspendLayout()
            CType((Me.diagramControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.fitToItemsGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.fitToItemsGroup.SuspendLayout()
            CType((Me.employeeBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.diagramOrgChartController1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.diagramOrgChartController1.TemplateDiagram), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutKindGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutKindGroup.RadioGroup.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' containerControl
            ' 
            Me.containerControl.Size = New System.Drawing.Size(737, 505)
            ' 
            ' diagramControl
            ' 
            Me.diagramControl.OptionsBehavior.PointerToolDragMode = DevExpress.Diagram.Core.PointerToolDragMode.Pan
            Me.diagramControl.OptionsBehavior.SelectedStencils = New DevExpress.Diagram.Core.StencilCollection(New String() {"BasicShapes", "BasicFlowchartShapes"})
            Me.diagramControl.OptionsCircularLayout.Order = DevExpress.Diagram.Core.Layout.CircularLayoutOrder.Clockwise
            Me.diagramControl.OptionsConnector.LineJumpPlacement = DevExpress.Diagram.Core.LineJumpPlacement.None
            Me.diagramControl.OptionsOrgChartLayout.TreeLevelCount = 4
            Me.diagramControl.OptionsTipOverTreeLayout.Offset = 40F
            Me.diagramControl.OptionsTipOverTreeLayout.VerticalSpacing = 40F
            Me.diagramControl.OptionsTreeLayout.VerticalSpacing = 45F
            Me.diagramControl.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.Fill
            Me.diagramControl.OptionsView.MaxZoomFactor = 1.5F
            Me.diagramControl.OptionsView.MinZoomFactor = 0.3F
            Me.diagramControl.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter
            Me.diagramControl.OptionsView.PropertiesPanelVisibility = DevExpress.Diagram.Core.PropertiesPanelVisibility.Closed
            Me.diagramControl.OptionsView.ShowGrid = False
            Me.diagramControl.OptionsView.ShowPageBreaks = False
            Me.diagramControl.OptionsView.ShowRulers = False
            Me.diagramControl.OptionsView.Theme = DevExpress.Diagram.Core.DiagramThemes.Linear
            Me.diagramControl.OptionsView.ToolboxVisibility = DevExpress.Diagram.Core.ToolboxVisibility.Compact
            Me.diagramControl.Size = New System.Drawing.Size(737, 505)
            ' 
            ' fitToItemsGroup
            ' 
            Me.fitToItemsGroup.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.fitToItemsGroup.Controls.Add(Me.fitToItemsButton)
            Me.fitToItemsGroup.Dock = System.Windows.Forms.DockStyle.Top
            Me.fitToItemsGroup.Location = New System.Drawing.Point(0, 142)
            Me.fitToItemsGroup.Name = "fitToItemsGroup"
            Me.fitToItemsGroup.Padding = New System.Windows.Forms.Padding(12, 0, 12, 0)
            Me.fitToItemsGroup.Size = New System.Drawing.Size(249, 23)
            Me.fitToItemsGroup.TabIndex = 0
            ' 
            ' fitToItemsButton
            ' 
            Me.fitToItemsButton.Dock = System.Windows.Forms.DockStyle.Fill
            Me.fitToItemsButton.Location = New System.Drawing.Point(12, 0)
            Me.fitToItemsButton.Name = "fitToItemsButton"
            Me.fitToItemsButton.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
            Me.fitToItemsButton.Size = New System.Drawing.Size(225, 23)
            Me.fitToItemsButton.TabIndex = 2
            Me.fitToItemsButton.Text = "Fit to Items"
            AddHandler Me.fitToItemsButton.Click, New System.EventHandler(AddressOf Me.FitToItems)
            ' 
            ' employeeBindingSource
            ' 
            Me.employeeBindingSource.DataSource = GetType(DevExpress.Diagram.Demos.Employee)
            ' 
            ' diagramOrgChartController1
            ' 
            Me.diagramOrgChartController1.DataSource = Me.employeeBindingSource
            Me.diagramOrgChartController1.Diagram = Me.diagramControl
            Me.diagramOrgChartController1.ExpandSubordinatesButtonMode = DevExpress.Diagram.Core.ExpandSubordinatesButtonMode.LookupChildrenInSource
            Me.diagramOrgChartController1.ExpansionDepth = 0
            Me.diagramOrgChartController1.GenerationDepth = 0
            Me.diagramOrgChartController1.KeyMember = "Id"
            Me.diagramOrgChartController1.LayoutKind = DevExpress.Diagram.Core.DiagramLayoutKind.OrgChart
            Me.diagramOrgChartController1.ParentMember = "ParentId"
            ' 
            ' 
            ' 
            Me.diagramOrgChartController1.TemplateDiagram.Items.AddRange(New DevExpress.XtraDiagram.DiagramItem() {Me.diagramContainer1, Me.diagramConnector1})
            Me.diagramOrgChartController1.TemplateDiagram.Location = New System.Drawing.Point(0, 0)
            Me.diagramOrgChartController1.TemplateDiagram.Name = ""
            Me.diagramOrgChartController1.TemplateDiagram.OptionsBehavior.SelectedStencils = New DevExpress.Diagram.Core.StencilCollection(New String() {"TemplateDesigner"})
            Me.diagramOrgChartController1.TemplateDiagram.OptionsBehavior.ShowQuickShapes = False
            Me.diagramOrgChartController1.TemplateDiagram.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.Fill
            Me.diagramOrgChartController1.TemplateDiagram.OptionsView.Landscape = False
            Me.diagramOrgChartController1.TemplateDiagram.OptionsView.PageSize = New System.Drawing.SizeF(616F, 928F)
            Me.diagramOrgChartController1.TemplateDiagram.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Custom
            Me.diagramOrgChartController1.TemplateDiagram.OptionsView.ShowPageBreaks = False
            Me.diagramOrgChartController1.TemplateDiagram.TabIndex = 0
            AddHandler Me.diagramOrgChartController1.ItemsGenerated, New System.EventHandler(Of DevExpress.XtraDiagram.DiagramItemsGeneratedEventArgs)(AddressOf Me.OnItemsGenerated)
            ' 
            ' diagramContainer1
            ' 
            Me.diagramContainer1.Anchors = CType(((DevExpress.Diagram.Core.Sides.Left Or DevExpress.Diagram.Core.Sides.Top)), DevExpress.Diagram.Core.Sides)
            Me.diagramContainer1.Appearance.BorderSize = 0
            Me.diagramContainer1.CanAddItems = False
            Me.diagramContainer1.CanCopyWithoutParent = True
            Me.diagramContainer1.CanDelete = False
            Me.diagramContainer1.ConnectionPoints = New DevExpress.XtraDiagram.PointCollection(New DevExpress.Utils.PointFloat() {New DevExpress.Utils.PointFloat(0F, 0.5F), New DevExpress.Utils.PointFloat(0.5F, 0F), New DevExpress.Utils.PointFloat(1F, 0.5F), New DevExpress.Utils.PointFloat(0.5F, 1F)})
            Me.diagramContainer1.DragMode = DevExpress.Diagram.Core.ContainerDragMode.ByAnyPoint
            Me.diagramContainer1.Items.AddRange(New DevExpress.XtraDiagram.DiagramItem() {Me.diagramShape1, Me.diagramShape2, Me.diagramShape3})
            Me.diagramContainer1.ItemsCanAttachConnectorBeginPoint = False
            Me.diagramContainer1.ItemsCanAttachConnectorEndPoint = False
            Me.diagramContainer1.ItemsCanChangeParent = False
            Me.diagramContainer1.ItemsCanCopyWithoutParent = False
            Me.diagramContainer1.ItemsCanDeleteWithoutParent = False
            Me.diagramContainer1.ItemsCanEdit = False
            Me.diagramContainer1.ItemsCanMove = False
            Me.diagramContainer1.ItemsCanResize = False
            Me.diagramContainer1.ItemsCanRotate = False
            Me.diagramContainer1.ItemsCanSelect = False
            Me.diagramContainer1.ItemsCanSnapToOtherItems = False
            Me.diagramContainer1.ItemsCanSnapToThisItem = False
            Me.diagramContainer1.MoveWithSubordinates = True
            Me.diagramContainer1.Position = New DevExpress.Utils.PointFloat(182.5F, 281.5F)
            Me.diagramContainer1.Size = New System.Drawing.SizeF(251F, 127F)
            Me.diagramContainer1.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Accent1
            Me.diagramContainer1.TemplateName = ""
            Me.diagramContainer1.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant1
            ' 
            ' diagramShape1
            ' 
            Me.diagramShape1.Anchors = CType(((DevExpress.Diagram.Core.Sides.Top Or DevExpress.Diagram.Core.Sides.Right)), DevExpress.Diagram.Core.Sides)
            Me.diagramShape1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((91)))))), (CInt(((CByte((155)))))), (CInt(((CByte((213)))))))
            Me.diagramShape1.Appearance.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((255)))))), (CInt(((CByte((255)))))), (CInt(((CByte((255)))))))
            Me.diagramShape1.Appearance.BorderSize = 0
            Me.diagramShape1.Appearance.Font = New System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold)
            Me.diagramShape1.Bindings.Add(New DevExpress.Diagram.Core.DiagramBinding("Content", "JobTitle"))
            Me.diagramShape1.CanCopy = False
            Me.diagramShape1.CanCopyWithoutParent = False
            Me.diagramShape1.CanEdit = False
            Me.diagramShape1.CanMove = False
            Me.diagramShape1.CanResize = False
            Me.diagramShape1.CanRotate = False
            Me.diagramShape1.CanSelect = False
            Me.diagramShape1.CanSnapToOtherItems = False
            Me.diagramShape1.CanSnapToThisItem = False
            Me.diagramShape1.Position = New DevExpress.Utils.PointFloat(0F, -3.552714E-15F)
            Me.diagramShape1.Size = New System.Drawing.SizeF(251F, 61.03622F)
            Me.diagramShape1.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant1
            ' 
            ' diagramShape2
            ' 
            Me.diagramShape2.Anchors = CType(((DevExpress.Diagram.Core.Sides.Right Or DevExpress.Diagram.Core.Sides.Bottom)), DevExpress.Diagram.Core.Sides)
            Me.diagramShape2.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((91)))))), (CInt(((CByte((155)))))), (CInt(((CByte((213)))))))
            Me.diagramShape2.Appearance.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((255)))))), (CInt(((CByte((255)))))), (CInt(((CByte((255)))))))
            Me.diagramShape2.Appearance.BorderSize = 0
            Me.diagramShape2.Appearance.Font = New System.Drawing.Font("Segoe UI", 12F)
            Me.diagramShape2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.diagramShape2.Bindings.Add(New DevExpress.Diagram.Core.DiagramBinding("Content", "FirstName"))
            Me.diagramShape2.CanCopy = False
            Me.diagramShape2.CanCopyWithoutParent = False
            Me.diagramShape2.CanEdit = False
            Me.diagramShape2.CanMove = False
            Me.diagramShape2.CanResize = False
            Me.diagramShape2.CanRotate = False
            Me.diagramShape2.CanSelect = False
            Me.diagramShape2.CanSnapToOtherItems = False
            Me.diagramShape2.CanSnapToThisItem = False
            Me.diagramShape2.Position = New DevExpress.Utils.PointFloat(0F, 65F)
            Me.diagramShape2.Size = New System.Drawing.SizeF(251F, 20F)
            Me.diagramShape2.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant1
            ' 
            ' diagramShape3
            ' 
            Me.diagramShape3.Anchors = CType(((DevExpress.Diagram.Core.Sides.Right Or DevExpress.Diagram.Core.Sides.Bottom)), DevExpress.Diagram.Core.Sides)
            Me.diagramShape3.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((91)))))), (CInt(((CByte((155)))))), (CInt(((CByte((213)))))))
            Me.diagramShape3.Appearance.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((255)))))), (CInt(((CByte((255)))))), (CInt(((CByte((255)))))))
            Me.diagramShape3.Appearance.BorderSize = 0
            Me.diagramShape3.Appearance.Font = New System.Drawing.Font("Segoe UI", 12F)
            Me.diagramShape3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.diagramShape3.Bindings.Add(New DevExpress.Diagram.Core.DiagramBinding("Content", "LastName"))
            Me.diagramShape3.CanCopy = False
            Me.diagramShape3.CanCopyWithoutParent = False
            Me.diagramShape3.CanEdit = False
            Me.diagramShape3.CanMove = False
            Me.diagramShape3.CanResize = False
            Me.diagramShape3.CanRotate = False
            Me.diagramShape3.CanSelect = False
            Me.diagramShape3.CanSnapToOtherItems = False
            Me.diagramShape3.CanSnapToThisItem = False
            Me.diagramShape3.Position = New DevExpress.Utils.PointFloat(0F, 85F)
            Me.diagramShape3.Size = New System.Drawing.SizeF(251F, 20F)
            Me.diagramShape3.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant1
            ' 
            ' diagramConnector1
            ' 
            Me.diagramConnector1.Appearance.ContentBackground = System.Drawing.Color.White
            Me.diagramConnector1.BeginPoint = New DevExpress.Utils.PointFloat(307.5F, 556.5F)
            Me.diagramConnector1.CanChangeRoute = False
            Me.diagramConnector1.CanDragBeginPoint = False
            Me.diagramConnector1.CanDragEndPoint = False
            Me.diagramConnector1.EndPoint = New DevExpress.Utils.PointFloat(397.5F, 646.5F)
            Me.diagramConnector1.Points = New DevExpress.XtraDiagram.PointCollection(New DevExpress.Utils.PointFloat() {New DevExpress.Utils.PointFloat(397.5F, 556.5F)})
            ' 
            ' layoutKindGroup
            ' 
            Me.layoutKindGroup.CaptionLocation = DevExpress.Utils.Locations.Top
            Me.layoutKindGroup.Dock = System.Windows.Forms.DockStyle.Top
            Me.layoutKindGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutKindGroup.Location = New System.Drawing.Point(0, 0)
            Me.layoutKindGroup.Name = "layoutKindGroup"
            Me.layoutKindGroup.Padding = New System.Windows.Forms.Padding(12)
            ' 
            ' 
            ' 
            Me.layoutKindGroup.RadioGroup.EditValue = DevExpress.Diagram.Core.DiagramLayoutKind.OrgChart
            Me.layoutKindGroup.RadioGroup.Location = New System.Drawing.Point(0, 0)
            Me.layoutKindGroup.RadioGroup.Name = ""
            Me.layoutKindGroup.RadioGroup.Properties.AllowFocused = False
            Me.layoutKindGroup.RadioGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.DiagramLayoutKind.OrgChart, "OrgChart"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.DiagramLayoutKind.Tree, "Tree"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.DiagramLayoutKind.TipOverTree, "TipOverTree"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.DiagramLayoutKind.MindMapTree, "MindMapTree")})
            Me.layoutKindGroup.RadioGroup.TabIndex = 0
            AddHandler Me.layoutKindGroup.RadioGroup.SelectedIndexChanged, New System.EventHandler(AddressOf Me.LayoutKindChanged)
            Me.layoutKindGroup.Size = New System.Drawing.Size(249, 142)
            Me.layoutKindGroup.TabIndex = 1
            Me.layoutKindGroup.Text = "Layout Kind"
            ' 
            ' ExpandAndCollapseOrgChartModule
            ' 
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
            Me.Name = "ExpandAndCollapseOrgChartModule"
            Me.OptionsPageControls.Add(Me.fitToItemsGroup)
            Me.OptionsPageControls.Add(Me.layoutKindGroup)
            Me.ShowOptionsPanel = True
            Me.Size = New System.Drawing.Size(987, 505)
            Me.containerControl.ResumeLayout(False)
            CType((Me.diagramControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.fitToItemsGroup), System.ComponentModel.ISupportInitialize).EndInit()
            Me.fitToItemsGroup.ResumeLayout(False)
            CType((Me.employeeBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.diagramOrgChartController1.TemplateDiagram), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.diagramOrgChartController1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutKindGroup.RadioGroup.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutKindGroup), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private fitToItemsGroup As DevExpress.XtraDiagram.Demos.OptionsPanelGroupControl

        Private diagramOrgChartController1 As DevExpress.XtraDiagram.DiagramOrgChartController

        Private employeeBindingSource As System.Windows.Forms.BindingSource

        Private layoutKindGroup As DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup

        Private diagramContainer1 As DevExpress.XtraDiagram.DiagramContainer

        Private diagramShape1 As DevExpress.XtraDiagram.DiagramShape

        Private diagramShape2 As DevExpress.XtraDiagram.DiagramShape

        Private diagramShape3 As DevExpress.XtraDiagram.DiagramShape

        Private diagramConnector1 As DevExpress.XtraDiagram.DiagramConnector

        Private fitToItemsButton As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace
