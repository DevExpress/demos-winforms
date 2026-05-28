Namespace DevExpress.XtraDiagram.Demos

    Partial Class TournamentModule

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
            Me.diagramDataBindingController1 = New DevExpress.XtraDiagram.DiagramDataBindingController(Me.components)
            Me.relationshipInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.tournamentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.diagramConnector1 = New DevExpress.XtraDiagram.DiagramConnector()
            Me.diagramContainer1 = New DevExpress.XtraDiagram.DiagramContainer()
            Me.diagramContainer2 = New DevExpress.XtraDiagram.DiagramContainer()
            Me.diagramImage1 = New DevExpress.XtraDiagram.DiagramImage()
            Me.diagramShape1 = New DevExpress.XtraDiagram.DiagramShape()
            Me.diagramShape2 = New DevExpress.XtraDiagram.DiagramShape()
            Me.diagramContainer3 = New DevExpress.XtraDiagram.DiagramContainer()
            Me.diagramImage2 = New DevExpress.XtraDiagram.DiagramImage()
            Me.diagramShape3 = New DevExpress.XtraDiagram.DiagramShape()
            Me.diagramShape4 = New DevExpress.XtraDiagram.DiagramShape()
            CType((Me.diagramControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.diagramDataBindingController1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.diagramDataBindingController1.TemplateDiagram), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.relationshipInfoBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tournamentsBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' containerControl
            ' 
            Me.containerControl.Size = New System.Drawing.Size(987, 505)
            ' 
            ' diagramControl
            ' 
            Me.diagramControl.OptionsBehavior.PointerToolDragMode = DevExpress.Diagram.Core.PointerToolDragMode.Pan
            Me.diagramControl.OptionsBehavior.SelectedStencils = New DevExpress.Diagram.Core.StencilCollection(New String() {"BasicShapes", "BasicFlowchartShapes"})
            Me.diagramControl.OptionsTreeLayout.DepthAlignment = DevExpress.Diagram.Core.Alignment.Center
            Me.diagramControl.OptionsTreeLayout.Direction = DevExpress.Diagram.Core.Layout.LayoutDirection.RightToLeft
            Me.diagramControl.OptionsTreeLayout.HorizontalSpacing = 250F
            Me.diagramControl.OptionsTreeLayout.VerticalSpacing = 100F
            Me.diagramControl.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.Fill
            Me.diagramControl.OptionsView.PageSize = New System.Drawing.SizeF(1598F, 748F)
            Me.diagramControl.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Custom
            Me.diagramControl.OptionsView.PropertiesPanelVisibility = DevExpress.Diagram.Core.PropertiesPanelVisibility.Closed
            Me.diagramControl.OptionsView.ShowGrid = False
            Me.diagramControl.OptionsView.ShowPageBreaks = False
            Me.diagramControl.OptionsView.ShowRulers = False
            Me.diagramControl.OptionsView.Theme = DevExpress.Diagram.Core.DiagramThemes.NoTheme
            Me.diagramControl.OptionsView.ToolboxVisibility = DevExpress.Diagram.Core.ToolboxVisibility.Closed
            Me.diagramControl.Size = New System.Drawing.Size(981, 331)
            ' 
            ' diagramDataBindingController1
            ' 
            Me.diagramDataBindingController1.ClearExistingItems = False
            Me.diagramDataBindingController1.ConnectorFromMember = "Source"
            Me.diagramDataBindingController1.ConnectorsSource = Me.relationshipInfoBindingSource
            Me.diagramDataBindingController1.ConnectorToMember = "Target"
            Me.diagramDataBindingController1.DataSource = Me.tournamentsBindingSource
            Me.diagramDataBindingController1.Diagram = Me.diagramControl
            Me.diagramDataBindingController1.KeyMember = "Id"
            Me.diagramDataBindingController1.LayoutKind = DevExpress.Diagram.Core.DiagramLayoutKind.Tree
            ' 
            ' 
            ' 
            Me.diagramDataBindingController1.TemplateDiagram.Items.AddRange(New DevExpress.XtraDiagram.DiagramItem() {Me.diagramConnector1, Me.diagramContainer1})
            Me.diagramDataBindingController1.TemplateDiagram.Location = New System.Drawing.Point(0, 0)
            Me.diagramDataBindingController1.TemplateDiagram.Name = ""
            Me.diagramDataBindingController1.TemplateDiagram.OptionsBehavior.SelectedStencils = New DevExpress.Diagram.Core.StencilCollection(New String() {"TemplateDesigner"})
            Me.diagramDataBindingController1.TemplateDiagram.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.Fill
            Me.diagramDataBindingController1.TemplateDiagram.OptionsView.Landscape = False
            Me.diagramDataBindingController1.TemplateDiagram.OptionsView.PageSize = New System.Drawing.SizeF(348F, 363F)
            Me.diagramDataBindingController1.TemplateDiagram.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Custom
            Me.diagramDataBindingController1.TemplateDiagram.OptionsView.ShowPageBreaks = False
            Me.diagramDataBindingController1.TemplateDiagram.TabIndex = 0
            ' 
            ' relationshipInfoBindingSource
            ' 
            Me.relationshipInfoBindingSource.DataSource = GetType(DevExpress.Diagram.Demos.TournamentRelationInfo)
            ' 
            ' tournamentsBindingSource
            ' 
            Me.tournamentsBindingSource.DataSource = GetType(DevExpress.Diagram.Demos.Game)
            ' 
            ' diagramConnector1
            ' 
            Me.diagramConnector1.Appearance.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((217)))))), (CInt(((CByte((230)))))), (CInt(((CByte((240)))))))
            Me.diagramConnector1.Appearance.ContentBackground = System.Drawing.Color.White
            Me.diagramConnector1.BeginPoint = New DevExpress.Utils.PointFloat(0F, 30F)
            Me.diagramConnector1.CanChangeRoute = False
            Me.diagramConnector1.CanCopy = False
            Me.diagramConnector1.CanCopyWithoutParent = False
            Me.diagramConnector1.CanDelete = False
            Me.diagramConnector1.CanDeleteWithoutParent = False
            Me.diagramConnector1.CanDragBeginPoint = False
            Me.diagramConnector1.CanDragEndPoint = False
            Me.diagramConnector1.CanEdit = False
            Me.diagramConnector1.CanMove = False
            Me.diagramConnector1.CanSelect = False
            Me.diagramConnector1.EndArrow = Nothing
            Me.diagramConnector1.EndPoint = New DevExpress.Utils.PointFloat(90F, 120F)
            Me.diagramConnector1.Points = New DevExpress.XtraDiagram.PointCollection(New DevExpress.Utils.PointFloat() {New DevExpress.Utils.PointFloat(90F, 30F)})
            ' 
            ' diagramContainer1
            ' 
            Me.diagramContainer1.Anchors = CType(((DevExpress.Diagram.Core.Sides.Left Or DevExpress.Diagram.Core.Sides.Top)), DevExpress.Diagram.Core.Sides)
            Me.diagramContainer1.Appearance.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((212)))))), (CInt(((CByte((212)))))), (CInt(((CByte((212)))))))
            Me.diagramContainer1.Appearance.BorderSize = 0
            Me.diagramContainer1.CanAddItems = False
            Me.diagramContainer1.CanChangeParent = False
            Me.diagramContainer1.CanCopy = False
            Me.diagramContainer1.CanCopyWithoutParent = False
            Me.diagramContainer1.CanDelete = False
            Me.diagramContainer1.CanDeleteWithoutParent = False
            Me.diagramContainer1.CanMove = False
            Me.diagramContainer1.CanResize = False
            Me.diagramContainer1.CanSelect = False
            Me.diagramContainer1.CanSnapToOtherItems = False
            Me.diagramContainer1.CanSnapToThisItem = False
            Me.diagramContainer1.CollapseButtonVisibilityMode = DevExpress.Diagram.Core.CollapseButtonVisibilityMode.Never
            Me.diagramContainer1.ConnectionPoints = New DevExpress.XtraDiagram.PointCollection(New DevExpress.Utils.PointFloat() {New DevExpress.Utils.PointFloat(0.5F, 0F), New DevExpress.Utils.PointFloat(1F, 0.5F), New DevExpress.Utils.PointFloat(0.5F, 1F), New DevExpress.Utils.PointFloat(0F, 0.5F)})
            Me.diagramContainer1.DragMode = DevExpress.Diagram.Core.ContainerDragMode.ByAnyPoint
            Me.diagramContainer1.Items.AddRange(New DevExpress.XtraDiagram.DiagramItem() {Me.diagramContainer2, Me.diagramContainer3})
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
            Me.diagramContainer1.Position = New DevExpress.Utils.PointFloat(-100F, -180F)
            Me.diagramContainer1.Size = New System.Drawing.SizeF(355F, 100.034F)
            Me.diagramContainer1.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant1
            ' 
            ' diagramContainer2
            ' 
            Me.diagramContainer2.Anchors = CType(((DevExpress.Diagram.Core.Sides.Left Or DevExpress.Diagram.Core.Sides.Top)), DevExpress.Diagram.Core.Sides)
            Me.diagramContainer2.Appearance.Font = New System.Drawing.Font("Tahoma", 18F)
            Me.diagramContainer2.CanAddItems = False
            Me.diagramContainer2.CanAttachConnectorBeginPoint = False
            Me.diagramContainer2.CanAttachConnectorEndPoint = False
            Me.diagramContainer2.CanChangeParent = False
            Me.diagramContainer2.CanCopy = False
            Me.diagramContainer2.CanCopyWithoutParent = False
            Me.diagramContainer2.CanDelete = False
            Me.diagramContainer2.CanDeleteWithoutParent = False
            Me.diagramContainer2.CanMove = False
            Me.diagramContainer2.CanResize = False
            Me.diagramContainer2.CanSelect = True
            Me.diagramContainer2.CanSnapToOtherItems = False
            Me.diagramContainer2.CanSnapToThisItem = False
            Me.diagramContainer2.ConnectionPoints = New DevExpress.XtraDiagram.PointCollection(New DevExpress.Utils.PointFloat() {New DevExpress.Utils.PointFloat(0.5F, 0F), New DevExpress.Utils.PointFloat(1F, 0.5F), New DevExpress.Utils.PointFloat(0.5F, 1F), New DevExpress.Utils.PointFloat(0F, 0.5F)})
            Me.diagramContainer2.DragMode = DevExpress.Diagram.Core.ContainerDragMode.ByAnyPoint
            Me.diagramContainer2.Items.AddRange(New DevExpress.XtraDiagram.DiagramItem() {Me.diagramImage1, Me.diagramShape1, Me.diagramShape2})
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
            Me.diagramContainer2.Size = New System.Drawing.SizeF(355F, 50F)
            Me.diagramContainer2.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant1
            ' 
            ' diagramImage1
            ' 
            Me.diagramImage1.AllowPlaceholder = False
            Me.diagramImage1.Anchors = CType(((DevExpress.Diagram.Core.Sides.Left Or DevExpress.Diagram.Core.Sides.Top)), DevExpress.Diagram.Core.Sides)
            Me.diagramImage1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((72)))))), (CInt(((CByte((84)))))), (CInt(((CByte((96)))))))
            Me.diagramImage1.Appearance.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((217)))))), (CInt(((CByte((230)))))), (CInt(((CByte((240)))))))
            Me.diagramImage1.Bindings.Add(New DevExpress.Diagram.Core.DiagramBinding("Image", "First.ImageData"))
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
            Me.diagramImage1.MoveWithSubordinates = True
            Me.diagramImage1.Size = New System.Drawing.SizeF(80.39952F, 50F)
            Me.diagramImage1.StretchMode = DevExpress.Diagram.Core.StretchMode.Stretch
            ' 
            ' diagramShape1
            ' 
            Me.diagramShape1.Anchors = CType(((DevExpress.Diagram.Core.Sides.Left Or DevExpress.Diagram.Core.Sides.Top)), DevExpress.Diagram.Core.Sides)
            Me.diagramShape1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((72)))))), (CInt(((CByte((84)))))), (CInt(((CByte((96)))))))
            Me.diagramShape1.Appearance.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((217)))))), (CInt(((CByte((230)))))), (CInt(((CByte((240)))))))
            Me.diagramShape1.Appearance.Font = New System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold)
            Me.diagramShape1.Bindings.Add(New DevExpress.Diagram.Core.DiagramBinding("Content", "First.Name"))
            Me.diagramShape1.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White
            Me.diagramShape1.MoveWithSubordinates = True
            Me.diagramShape1.Position = New DevExpress.Utils.PointFloat(80F, 0F)
            Me.diagramShape1.Size = New System.Drawing.SizeF(220F, 50F)
            ' 
            ' diagramShape2
            ' 
            Me.diagramShape2.Anchors = CType(((DevExpress.Diagram.Core.Sides.Left Or DevExpress.Diagram.Core.Sides.Top)), DevExpress.Diagram.Core.Sides)
            Me.diagramShape2.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((46)))))), (CInt(((CByte((59)))))), (CInt(((CByte((70)))))))
            Me.diagramShape2.Appearance.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((217)))))), (CInt(((CByte((230)))))), (CInt(((CByte((240)))))))
            Me.diagramShape2.Appearance.Font = New System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold)
            Me.diagramShape2.Bindings.Add(New DevExpress.Diagram.Core.DiagramBinding("Content", "Team1Score", DevExpress.Diagram.Core.DiagramBindingMode.TwoWay))
            Me.diagramShape2.CanEdit = True
            Me.diagramShape2.CanSelect = True
            Me.diagramShape2.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White
            Me.diagramShape2.MoveWithSubordinates = True
            Me.diagramShape2.Position = New DevExpress.Utils.PointFloat(300F, 0F)
            Me.diagramShape2.Size = New System.Drawing.SizeF(55F, 50F)
            Me.diagramShape2.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant1
            ' 
            ' diagramContainer3
            ' 
            Me.diagramContainer3.Anchors = CType(((DevExpress.Diagram.Core.Sides.Left Or DevExpress.Diagram.Core.Sides.Top)), DevExpress.Diagram.Core.Sides)
            Me.diagramContainer3.Appearance.Font = New System.Drawing.Font("Tahoma", 18F)
            Me.diagramContainer3.CanAddItems = False
            Me.diagramContainer3.CanAttachConnectorBeginPoint = False
            Me.diagramContainer3.CanAttachConnectorEndPoint = False
            Me.diagramContainer3.CanChangeParent = False
            Me.diagramContainer3.CanCopy = False
            Me.diagramContainer3.CanCopyWithoutParent = False
            Me.diagramContainer3.CanDelete = False
            Me.diagramContainer3.CanDeleteWithoutParent = False
            Me.diagramContainer3.CanMove = False
            Me.diagramContainer3.CanResize = False
            Me.diagramContainer3.CanSelect = True
            Me.diagramContainer3.CanSnapToOtherItems = False
            Me.diagramContainer3.CanSnapToThisItem = False
            Me.diagramContainer3.ConnectionPoints = New DevExpress.XtraDiagram.PointCollection(New DevExpress.Utils.PointFloat() {New DevExpress.Utils.PointFloat(0.5F, 0F), New DevExpress.Utils.PointFloat(1F, 0.5F), New DevExpress.Utils.PointFloat(0.5F, 1F), New DevExpress.Utils.PointFloat(0F, 0.5F)})
            Me.diagramContainer3.DragMode = DevExpress.Diagram.Core.ContainerDragMode.ByAnyPoint
            Me.diagramContainer3.Items.AddRange(New DevExpress.XtraDiagram.DiagramItem() {Me.diagramImage2, Me.diagramShape3, Me.diagramShape4})
            Me.diagramContainer3.ItemsCanAttachConnectorBeginPoint = False
            Me.diagramContainer3.ItemsCanAttachConnectorEndPoint = False
            Me.diagramContainer3.ItemsCanChangeParent = False
            Me.diagramContainer3.ItemsCanCopyWithoutParent = False
            Me.diagramContainer3.ItemsCanDeleteWithoutParent = False
            Me.diagramContainer3.ItemsCanEdit = False
            Me.diagramContainer3.ItemsCanMove = False
            Me.diagramContainer3.ItemsCanResize = False
            Me.diagramContainer3.ItemsCanRotate = False
            Me.diagramContainer3.ItemsCanSelect = False
            Me.diagramContainer3.ItemsCanSnapToOtherItems = False
            Me.diagramContainer3.ItemsCanSnapToThisItem = False
            Me.diagramContainer3.Position = New DevExpress.Utils.PointFloat(0F, 50F)
            Me.diagramContainer3.Size = New System.Drawing.SizeF(355F, 50F)
            Me.diagramContainer3.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant1
            ' 
            ' diagramImage2
            ' 
            Me.diagramImage2.AllowPlaceholder = False
            Me.diagramImage2.Anchors = CType(((DevExpress.Diagram.Core.Sides.Left Or DevExpress.Diagram.Core.Sides.Top)), DevExpress.Diagram.Core.Sides)
            Me.diagramImage2.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((72)))))), (CInt(((CByte((84)))))), (CInt(((CByte((96)))))))
            Me.diagramImage2.Appearance.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((217)))))), (CInt(((CByte((230)))))), (CInt(((CByte((240)))))))
            Me.diagramImage2.Bindings.Add(New DevExpress.Diagram.Core.DiagramBinding("Image", "Second.ImageData"))
            Me.diagramImage2.CanAttachConnectorBeginPoint = False
            Me.diagramImage2.CanAttachConnectorEndPoint = False
            Me.diagramImage2.CanChangeParent = False
            Me.diagramImage2.CanCopyWithoutParent = False
            Me.diagramImage2.CanDeleteWithoutParent = False
            Me.diagramImage2.CanMove = False
            Me.diagramImage2.CanResize = False
            Me.diagramImage2.CanRotate = False
            Me.diagramImage2.CanSelect = False
            Me.diagramImage2.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.Black
            Me.diagramImage2.MoveWithSubordinates = True
            Me.diagramImage2.Size = New System.Drawing.SizeF(80.39952F, 50F)
            Me.diagramImage2.StretchMode = DevExpress.Diagram.Core.StretchMode.Stretch
            ' 
            ' diagramShape3
            ' 
            Me.diagramShape3.Anchors = CType(((DevExpress.Diagram.Core.Sides.Left Or DevExpress.Diagram.Core.Sides.Top)), DevExpress.Diagram.Core.Sides)
            Me.diagramShape3.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((72)))))), (CInt(((CByte((84)))))), (CInt(((CByte((96)))))))
            Me.diagramShape3.Appearance.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((217)))))), (CInt(((CByte((230)))))), (CInt(((CByte((240)))))))
            Me.diagramShape3.Appearance.Font = New System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold)
            Me.diagramShape3.Bindings.Add(New DevExpress.Diagram.Core.DiagramBinding("Content", "Second.Name"))
            Me.diagramShape3.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White
            Me.diagramShape3.MoveWithSubordinates = True
            Me.diagramShape3.Position = New DevExpress.Utils.PointFloat(80F, 0F)
            Me.diagramShape3.Size = New System.Drawing.SizeF(220F, 50F)
            ' 
            ' diagramShape4
            ' 
            Me.diagramShape4.Anchors = CType(((DevExpress.Diagram.Core.Sides.Left Or DevExpress.Diagram.Core.Sides.Top)), DevExpress.Diagram.Core.Sides)
            Me.diagramShape4.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((46)))))), (CInt(((CByte((59)))))), (CInt(((CByte((70)))))))
            Me.diagramShape4.Appearance.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((217)))))), (CInt(((CByte((230)))))), (CInt(((CByte((240)))))))
            Me.diagramShape4.Appearance.Font = New System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold)
            Me.diagramShape4.Bindings.Add(New DevExpress.Diagram.Core.DiagramBinding("Content", "Team2Score", DevExpress.Diagram.Core.DiagramBindingMode.TwoWay))
            Me.diagramShape4.CanEdit = True
            Me.diagramShape4.CanSelect = True
            Me.diagramShape4.ForegroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White
            Me.diagramShape4.MoveWithSubordinates = True
            Me.diagramShape4.Position = New DevExpress.Utils.PointFloat(300F, 0F)
            Me.diagramShape4.Size = New System.Drawing.SizeF(55F, 50F)
            Me.diagramShape4.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant1
            ' 
            ' TournamentModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "TournamentModule"
            Me.Size = New System.Drawing.Size(987, 505)
            CType((Me.diagramControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.diagramDataBindingController1.TemplateDiagram), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.diagramDataBindingController1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.relationshipInfoBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tournamentsBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private diagramDataBindingController1 As DevExpress.XtraDiagram.DiagramDataBindingController

        Private tournamentsBindingSource As System.Windows.Forms.BindingSource

        Private relationshipInfoBindingSource As System.Windows.Forms.BindingSource

        Private diagramConnector1 As DevExpress.XtraDiagram.DiagramConnector

        Private diagramContainer1 As DevExpress.XtraDiagram.DiagramContainer

        Private diagramContainer2 As DevExpress.XtraDiagram.DiagramContainer

        Private diagramImage1 As DevExpress.XtraDiagram.DiagramImage

        Private diagramShape1 As DevExpress.XtraDiagram.DiagramShape

        Private diagramShape2 As DevExpress.XtraDiagram.DiagramShape

        Private diagramContainer3 As DevExpress.XtraDiagram.DiagramContainer

        Private diagramImage2 As DevExpress.XtraDiagram.DiagramImage

        Private diagramShape3 As DevExpress.XtraDiagram.DiagramShape

        Private diagramShape4 As DevExpress.XtraDiagram.DiagramShape
    End Class
End Namespace
