Namespace DevExpress.XtraDiagram.Demos

    Partial Class ProductFlowDiagramModule

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.category = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.customer = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.product = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.quantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.diagramDataBindingController1 = New DevExpress.XtraDiagram.DiagramDataBindingController(Me.components)
            Me.diagramContainer1 = New DevExpress.XtraDiagram.DiagramContainer()
            Me.diagramShape1 = New DevExpress.XtraDiagram.DiagramShape()
            Me.diagramShape2 = New DevExpress.XtraDiagram.DiagramShape()
            Me.diagramImage1 = New DevExpress.XtraDiagram.DiagramImage()
            Me.diagramContainer2 = New DevExpress.XtraDiagram.DiagramContainer()
            Me.diagramShape3 = New DevExpress.XtraDiagram.DiagramShape()
            Me.diagramShape4 = New DevExpress.XtraDiagram.DiagramShape()
            Me.diagramShape5 = New DevExpress.XtraDiagram.DiagramShape()
            Me.diagramConnector1 = New DevExpress.XtraDiagram.DiagramConnector()
            Me.containerControl.SuspendLayout()
            CType((Me.diagramControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.diagramDataBindingController1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.diagramDataBindingController1.TemplateDiagram), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' containerControl
            ' 
            Me.containerControl.Size = New System.Drawing.Size(476, 432)
            Me.containerControl.Controls.SetChildIndex(Me.diagramControl, 0)
            ' 
            ' diagramControl
            ' 
            Me.diagramControl.Location = New System.Drawing.Point(0, 150)
            Me.diagramControl.OptionsBehavior.SelectedStencils = New DevExpress.Diagram.Core.StencilCollection(New String() {"BasicShapes", "BasicFlowchartShapes"})
            Me.diagramControl.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.None
            Me.diagramControl.OptionsView.PageSize = New System.Drawing.SizeF(800F, 700F)
            Me.diagramControl.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Custom
            Me.diagramControl.OptionsView.PropertiesPanelVisibility = DevExpress.Diagram.Core.PropertiesPanelVisibility.Closed
            Me.diagramControl.OptionsView.Theme = DevExpress.Diagram.Core.DiagramThemes.Linear
            Me.diagramControl.OptionsView.ToolboxVisibility = DevExpress.Diagram.Core.ToolboxVisibility.Closed
            Me.diagramControl.Size = New System.Drawing.Size(476, 255)
            ' 
            ' gridControl
            ' 
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(0, 0)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(299, 399)
            Me.gridControl.TabIndex = 0
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            ' 
            ' gridView
            ' 
            Me.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.category, Me.customer, Me.product, Me.quantity})
            Me.gridView.GridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView.OptionsView.ShowGroupPanel = False
            Me.gridView.OptionsView.ShowIndicator = False
            ' 
            ' category
            ' 
            Me.category.AppearanceHeader.Options.UseTextOptions = True
            Me.category.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.category.Caption = "Category"
            Me.category.FieldName = "Category.Name"
            Me.category.Name = "category"
            Me.category.Visible = True
            Me.category.VisibleIndex = 0
            Me.category.Width = 104
            ' 
            ' customer
            ' 
            Me.customer.AppearanceHeader.Options.UseTextOptions = True
            Me.customer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.customer.Caption = "Customer"
            Me.customer.FieldName = "Customer.Name"
            Me.customer.Name = "customer"
            Me.customer.Visible = True
            Me.customer.VisibleIndex = 1
            Me.customer.Width = 109
            ' 
            ' product
            ' 
            Me.product.AppearanceHeader.Options.UseTextOptions = True
            Me.product.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.product.Caption = "Product"
            Me.product.FieldName = "ProductName"
            Me.product.Name = "product"
            Me.product.Visible = True
            Me.product.VisibleIndex = 2
            Me.product.Width = 104
            ' 
            ' quantity
            ' 
            Me.quantity.AppearanceCell.Options.UseTextOptions = True
            Me.quantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.quantity.AppearanceHeader.Options.UseTextOptions = True
            Me.quantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.quantity.Caption = "Quantity"
            Me.quantity.FieldName = "Quantity"
            Me.quantity.Name = "quantity"
            Me.quantity.Visible = True
            Me.quantity.VisibleIndex = 3
            ' 
            ' diagramDataBindingController1
            ' 
            Me.diagramDataBindingController1.ConnectorFromMember = "Customer"
            Me.diagramDataBindingController1.ConnectorsSource = Nothing
            Me.diagramDataBindingController1.ConnectorsZOrder = DevExpress.Diagram.Core.ConnectorsZOrder.InFrontOfItems
            Me.diagramDataBindingController1.ConnectorToMember = "Category"
            Me.diagramDataBindingController1.Diagram = Me.diagramControl
            ' 
            ' 
            ' 
            Me.diagramDataBindingController1.TemplateDiagram.Items.AddRange(New DevExpress.XtraDiagram.DiagramItem() {Me.diagramContainer1, Me.diagramContainer2, Me.diagramConnector1})
            Me.diagramDataBindingController1.TemplateDiagram.Location = New System.Drawing.Point(0, 0)
            Me.diagramDataBindingController1.TemplateDiagram.Name = ""
            Me.diagramDataBindingController1.TemplateDiagram.OptionsBehavior.SelectedStencils = New DevExpress.Diagram.Core.StencilCollection(New String() {"TemplateDesigner", "BasicShapes"})
            Me.diagramDataBindingController1.TemplateDiagram.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.Fill
            Me.diagramDataBindingController1.TemplateDiagram.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter
            Me.diagramDataBindingController1.TemplateDiagram.OptionsView.ShowPageBreaks = False
            Me.diagramDataBindingController1.TemplateDiagram.OptionsView.Theme = DevExpress.Diagram.Core.DiagramThemes.Linear
            Me.diagramDataBindingController1.TemplateDiagram.TabIndex = 0
            AddHandler Me.diagramDataBindingController1.GenerateItem, New System.EventHandler(Of DevExpress.XtraDiagram.DiagramGenerateItemEventArgs)(AddressOf Me.diagramDataBindingController1_GenerateItem)
            AddHandler Me.diagramDataBindingController1.UpdateConnector, New System.EventHandler(Of DevExpress.XtraDiagram.DiagramUpdateConnectorEventArgs)(AddressOf Me.diagramDataBindingController1_UpdateConnector)
            AddHandler Me.diagramDataBindingController1.CustomLayoutItems, New System.EventHandler(Of DevExpress.XtraDiagram.DiagramCustomLayoutItemsEventArgs)(AddressOf Me.diagramDataBindingController1_CustomLayoutItems)
            ' 
            ' diagramContainer1
            ' 
            Me.diagramContainer1.Anchors = CType(((DevExpress.Diagram.Core.Sides.Left Or DevExpress.Diagram.Core.Sides.Top)), DevExpress.Diagram.Core.Sides)
            Me.diagramContainer1.CanAddItems = False
            Me.diagramContainer1.CanCopy = False
            Me.diagramContainer1.CanCopyWithoutParent = True
            Me.diagramContainer1.CanDelete = False
            Me.diagramContainer1.ConnectionPoints = New DevExpress.XtraDiagram.PointCollection(New DevExpress.Utils.PointFloat() {New DevExpress.Utils.PointFloat(0.5F, 0F), New DevExpress.Utils.PointFloat(1F, 0.5F), New DevExpress.Utils.PointFloat(0.5F, 1F), New DevExpress.Utils.PointFloat(0F, 0.5F)})
            Me.diagramContainer1.DragMode = DevExpress.Diagram.Core.ContainerDragMode.ByAnyPoint
            Me.diagramContainer1.Items.AddRange(New DevExpress.XtraDiagram.DiagramItem() {Me.diagramShape1, Me.diagramShape2, Me.diagramImage1})
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
            Me.diagramContainer1.Position = New DevExpress.Utils.PointFloat(350F, 30F)
            Me.diagramContainer1.Size = New System.Drawing.SizeF(150F, 105F)
            Me.diagramContainer1.TemplateName = "CategoryTemplate"
            Me.diagramContainer1.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant1
            ' 
            ' diagramShape1
            ' 
            Me.diagramShape1.Anchors = CType((((DevExpress.Diagram.Core.Sides.Left Or DevExpress.Diagram.Core.Sides.Right) Or DevExpress.Diagram.Core.Sides.Bottom)), DevExpress.Diagram.Core.Sides)
            Me.diagramShape1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((27)))))), (CInt(((CByte((161)))))), (CInt(((CByte((226)))))))
            Me.diagramShape1.Appearance.BorderSize = 0
            Me.diagramShape1.Appearance.Font = New System.Drawing.Font("Tahoma", 7F)
            Me.diagramShape1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.diagramShape1.Bindings.Add(New DevExpress.Diagram.Core.DiagramBinding("Content", "Description"))
            Me.diagramShape1.Position = New DevExpress.Utils.PointFloat(10F, 60F)
            Me.diagramShape1.Size = New System.Drawing.SizeF(130F, 45F)
            ' 
            ' diagramShape2
            ' 
            Me.diagramShape2.Anchors = CType((((DevExpress.Diagram.Core.Sides.Left Or DevExpress.Diagram.Core.Sides.Right) Or DevExpress.Diagram.Core.Sides.Bottom)), DevExpress.Diagram.Core.Sides)
            Me.diagramShape2.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((27)))))), (CInt(((CByte((161)))))), (CInt(((CByte((226)))))))
            Me.diagramShape2.Appearance.BorderSize = 0
            Me.diagramShape2.Appearance.Font = New System.Drawing.Font("Tahoma", 9F)
            Me.diagramShape2.Bindings.Add(New DevExpress.Diagram.Core.DiagramBinding("Content", "Name"))
            Me.diagramShape2.Position = New DevExpress.Utils.PointFloat(10F, 36F)
            Me.diagramShape2.Size = New System.Drawing.SizeF(130F, 17F)
            ' 
            ' diagramImage1
            ' 
            Me.diagramImage1.Anchors = CType((((DevExpress.Diagram.Core.Sides.Left Or DevExpress.Diagram.Core.Sides.Top) Or DevExpress.Diagram.Core.Sides.Right)), DevExpress.Diagram.Core.Sides)
            Me.diagramImage1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((27)))))), (CInt(((CByte((161)))))), (CInt(((CByte((226)))))))
            Me.diagramImage1.Appearance.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((255)))))), (CInt(((CByte((255)))))), (CInt(((CByte((255)))))))
            Me.diagramImage1.Bindings.Add(New DevExpress.Diagram.Core.DiagramBinding("Image", "Picture"))
            Me.diagramImage1.CanAttachConnectorBeginPoint = False
            Me.diagramImage1.CanAttachConnectorEndPoint = False
            Me.diagramImage1.CanChangeParent = False
            Me.diagramImage1.CanCopyWithoutParent = False
            Me.diagramImage1.CanDeleteWithoutParent = False
            Me.diagramImage1.CanMove = False
            Me.diagramImage1.CanResize = False
            Me.diagramImage1.CanRotate = False
            Me.diagramImage1.CanSelect = False
            Me.diagramImage1.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.Black
            Me.diagramImage1.Position = New DevExpress.Utils.PointFloat(10F, 18F)
            Me.diagramImage1.Size = New System.Drawing.SizeF(130F, 17F)
            ' 
            ' diagramContainer2
            ' 
            Me.diagramContainer2.Anchors = CType(((DevExpress.Diagram.Core.Sides.Left Or DevExpress.Diagram.Core.Sides.Top)), DevExpress.Diagram.Core.Sides)
            Me.diagramContainer2.CanAddItems = False
            Me.diagramContainer2.CanCopy = False
            Me.diagramContainer2.CanCopyWithoutParent = True
            Me.diagramContainer2.CanDelete = False
            Me.diagramContainer2.ConnectionPoints = New DevExpress.XtraDiagram.PointCollection(New DevExpress.Utils.PointFloat() {New DevExpress.Utils.PointFloat(0.5F, 0F), New DevExpress.Utils.PointFloat(1F, 0.5F), New DevExpress.Utils.PointFloat(0.5F, 1F), New DevExpress.Utils.PointFloat(0F, 0.5F)})
            Me.diagramContainer2.DragMode = DevExpress.Diagram.Core.ContainerDragMode.ByAnyPoint
            Me.diagramContainer2.Items.AddRange(New DevExpress.XtraDiagram.DiagramItem() {Me.diagramShape3, Me.diagramShape4, Me.diagramShape5})
            Me.diagramContainer2.ItemsCanAttachConnectorBeginPoint = False
            Me.diagramContainer2.ItemsCanAttachConnectorEndPoint = False
            Me.diagramContainer2.ItemsCanChangeParent = False
            Me.diagramContainer2.ItemsCanCopyWithoutParent = False
            Me.diagramContainer2.ItemsCanDeleteWithoutParent = False
            Me.diagramContainer2.ItemsCanEdit = False
            Me.diagramContainer2.ItemsCanMove = False
            Me.diagramContainer2.ItemsCanResize = False
            Me.diagramContainer2.ItemsCanRotate = False
            Me.diagramContainer2.ItemsCanSelect = False
            Me.diagramContainer2.ItemsCanSnapToOtherItems = False
            Me.diagramContainer2.ItemsCanSnapToThisItem = False
            Me.diagramContainer2.Position = New DevExpress.Utils.PointFloat(60F, 30F)
            Me.diagramContainer2.Size = New System.Drawing.SizeF(150F, 105F)
            Me.diagramContainer2.TemplateName = "CustomerTemplate"
            Me.diagramContainer2.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant1
            ' 
            ' diagramShape3
            ' 
            Me.diagramShape3.Anchors = CType((((DevExpress.Diagram.Core.Sides.Left Or DevExpress.Diagram.Core.Sides.Top) Or DevExpress.Diagram.Core.Sides.Right)), DevExpress.Diagram.Core.Sides)
            Me.diagramShape3.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((27)))))), (CInt(((CByte((161)))))), (CInt(((CByte((226)))))))
            Me.diagramShape3.Appearance.BorderSize = 0
            Me.diagramShape3.Appearance.Font = New System.Drawing.Font("Tahoma", 9F)
            Me.diagramShape3.Bindings.Add(New DevExpress.Diagram.Core.DiagramBinding("Content", "CompanyName"))
            Me.diagramShape3.Position = New DevExpress.Utils.PointFloat(10F, 10F)
            Me.diagramShape3.Size = New System.Drawing.SizeF(130F, 43F)
            ' 
            ' diagramShape4
            ' 
            Me.diagramShape4.Anchors = CType((((DevExpress.Diagram.Core.Sides.Left Or DevExpress.Diagram.Core.Sides.Right) Or DevExpress.Diagram.Core.Sides.Bottom)), DevExpress.Diagram.Core.Sides)
            Me.diagramShape4.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((27)))))), (CInt(((CByte((161)))))), (CInt(((CByte((226)))))))
            Me.diagramShape4.Appearance.BorderSize = 0
            Me.diagramShape4.Appearance.Font = New System.Drawing.Font("Tahoma", 7F)
            Me.diagramShape4.Bindings.Add(New DevExpress.Diagram.Core.DiagramBinding("Content", "City"))
            Me.diagramShape4.Position = New DevExpress.Utils.PointFloat(10F, 55F)
            Me.diagramShape4.Size = New System.Drawing.SizeF(130F, 17F)
            ' 
            ' diagramShape5
            ' 
            Me.diagramShape5.Anchors = CType((((DevExpress.Diagram.Core.Sides.Left Or DevExpress.Diagram.Core.Sides.Right) Or DevExpress.Diagram.Core.Sides.Bottom)), DevExpress.Diagram.Core.Sides)
            Me.diagramShape5.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((27)))))), (CInt(((CByte((161)))))), (CInt(((CByte((226)))))))
            Me.diagramShape5.Appearance.BorderSize = 0
            Me.diagramShape5.Appearance.Font = New System.Drawing.Font("Tahoma", 7F)
            Me.diagramShape5.Bindings.Add(New DevExpress.Diagram.Core.DiagramBinding("Content", "PhoneNumber"))
            Me.diagramShape5.Position = New DevExpress.Utils.PointFloat(10F, 71F)
            Me.diagramShape5.Size = New System.Drawing.SizeF(130F, 17F)
            ' 
            ' diagramConnector1
            ' 
            Me.diagramConnector1.Appearance.ContentBackground = System.Drawing.Color.White
            Me.diagramConnector1.BeginItemPointIndex = 1
            Me.diagramConnector1.BeginPoint = New DevExpress.Utils.PointFloat(64F, 208F)
            Me.diagramConnector1.CanChangeRoute = False
            Me.diagramConnector1.CanCopy = False
            Me.diagramConnector1.CanDelete = False
            Me.diagramConnector1.CanDragBeginPoint = False
            Me.diagramConnector1.CanDragEndPoint = False
            Me.diagramConnector1.EndArrow = Nothing
            Me.diagramConnector1.EndItemPointIndex = 3
            Me.diagramConnector1.EndPoint = New DevExpress.Utils.PointFloat(154F, 298F)
            Me.diagramConnector1.Points = New DevExpress.XtraDiagram.PointCollection(New DevExpress.Utils.PointFloat() {New DevExpress.Utils.PointFloat(154F, 208F)})
            Me.diagramConnector1.Type = DevExpress.Diagram.Core.ConnectorType.Curved
            ' 
            ' ProductFlowDiagramModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "ProductFlowDiagramModule"
            Me.ShowOptionsPanel = True
            Me.Size = New System.Drawing.Size(776, 432)
            Me.OptionsPageControls.Add(Me.gridControl)
            Me.containerControl.ResumeLayout(False)
            Me.containerControl.PerformLayout()
            CType((Me.diagramControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.diagramDataBindingController1.TemplateDiagram), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.diagramDataBindingController1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl As DevExpress.XtraGrid.GridControl

        Private gridView As DevExpress.XtraGrid.Views.Grid.GridView

        Private quantity As DevExpress.XtraGrid.Columns.GridColumn

        Private product As DevExpress.XtraGrid.Columns.GridColumn

        Private customer As DevExpress.XtraGrid.Columns.GridColumn

        Private category As DevExpress.XtraGrid.Columns.GridColumn

        Private diagramDataBindingController1 As DevExpress.XtraDiagram.DiagramDataBindingController

        Private diagramContainer1 As DevExpress.XtraDiagram.DiagramContainer

        Private diagramShape1 As DevExpress.XtraDiagram.DiagramShape

        Private diagramShape2 As DevExpress.XtraDiagram.DiagramShape

        Private diagramImage1 As DevExpress.XtraDiagram.DiagramImage

        Private diagramContainer2 As DevExpress.XtraDiagram.DiagramContainer

        Private diagramShape3 As DevExpress.XtraDiagram.DiagramShape

        Private diagramShape4 As DevExpress.XtraDiagram.DiagramShape

        Private diagramShape5 As DevExpress.XtraDiagram.DiagramShape

        Private diagramConnector1 As DevExpress.XtraDiagram.DiagramConnector
    End Class
End Namespace
