Imports DevExpress.Data.Filtering
Imports DevExpress.Diagram.Core
Imports DevExpress.Diagram.Demos
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils.Svg
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Drawing2D

Namespace DevExpress.XtraDiagram.Demos

    Public Partial Class DatabaseDiagram
        Inherits DiagramTutorialControlBase

        Private Property Database As DatabaseDefinition

        Private evaluationOperator As TableRelationEvaluationOperator

        Private ReadOnly PropertyImage As SvgBitmap

        Private ReadOnly IdImage As SvgBitmap

        Protected Overrides ReadOnly Property PanAndZoomVisibleOnInitialized As Boolean
            Get
                Return True
            End Get
        End Property

        Public Sub New()
            evaluationOperator = New TableRelationEvaluationOperator()
            CriteriaOperator.RegisterCustomFunction(evaluationOperator)
            Database = GetDatabaseDefinition()
            IdImage = LoadSvgImage("Images/DatabaseDiagram/id.svg")
            PropertyImage = LoadSvgImage("Images/DatabaseDiagram/property.svg")
            InitializeComponent()
            diagramControl.OptionsView.FitToDrawingMargin = New Windows.Forms.Padding(50)
            AddHandler diagramControl.CustomDrawItem, AddressOf diagramControl_CustomDrawItem
            InitializeDataBindingController()
        End Sub

        Protected Overrides Sub Finalize()
            CriteriaOperator.UnregisterCustomFunction(evaluationOperator)
        End Sub

        Private Sub InitializeDataBindingController()
            diagramDataBindingController1.ConnectorToMember = "To"
            diagramDataBindingController1.ConnectorFromMember = "From"
            diagramDataBindingController1.KeySelector = New DatabaseDefinitionKeySelector()
            diagramDataBindingController1.ItemsPath = "Columns"
            diagramDataBindingController1.DataSource = Database.Tables
            diagramDataBindingController1.ConnectorsSource = Database.Connections
        End Sub

        Private Sub diagramControl_CustomDrawItem(ByVal sender As Object, ByVal e As CustomDrawItemEventArgs)
            Dim column = TryCast(e.Item.DataContext, ColumnDefinition)
            If column Is Nothing OrElse e.Item.Tag Is Nothing Then Return
            Dim image = If(column.IsPrimaryKey, IdImage, PropertyImage)
            Dim state = e.GraphicsCache.Paint.SaveCacheState(e.GraphicsCache)
            Try
                e.GraphicsCache.SmoothingMode = SmoothingMode.AntiAlias
                Dim imageSize = image.GetBounds().Size
                e.GraphicsCache.ScaleTransform(CSng(e.Item.Width) / imageSize.Width, CSng(e.Item.Height) / imageSize.Height)
                Using svgCache = New GraphicsCacheSvgWrapper(e.GraphicsCache)
                    image.RenderToSvgGraphics(svgCache)
                End Using
            Finally
                e.GraphicsCache.Paint.RestoreCacheState(e.GraphicsCache, state)
            End Try
        End Sub

        Private Sub diagramDataBindingController1_GenerateItem(ByVal sender As Object, ByVal e As DiagramGenerateItemEventArgs)
            If TypeOf e.DataObject Is TableDefinition Then
                e.Item = CreateTableItem()
            Else
                e.Item = CreateColumnItem()
            End If
        End Sub

        Private Sub diagramDataBindingController1_GenerateConnector(ByVal sender As Object, ByVal e As DiagramGenerateConnectorEventArgs)
            e.Connector = CreateConnectionItem()
        End Sub

        Private Sub diagramDataBindingController1_ItemsGenerated(ByVal sender As Object, ByVal e As DiagramItemsGeneratedEventArgs)
            diagramControl.FitToDrawing()
            diagramControl.OptionsView.ZoomFactor = 1.0F
            diagramControl.OptionsProtection.IsReadOnly = True
            diagramControl.OptionsBehavior.SelectionMode = SelectionMode.None
        End Sub

        Private Shared Function CreateTableItem() As DiagramList
            Dim stack = New DiagramList With {.ShowHeader = True, .Width = 200, .DragMode = ContainerDragMode.ByAnyPoint, .Shape = StandardContainers.Classic, .AffectedByLayoutAlgorithms = False, .CanCollapse = True}
            stack.Bindings.Add(New DiagramBinding("Header", "Name"))
            stack.Bindings.Add(New DiagramBinding("X", "PositionX"))
            stack.Bindings.Add(New DiagramBinding("Y", "PositionY"))
            stack.Appearance.BorderSize = 2
            stack.Appearance.Font = New Font(stack.Appearance.Font.FontFamily, 16)
            Return stack
        End Function

        Private Shared Function CreateColumnItem() As DiagramItem
            Dim imageItem = New DiagramShape With {.X = 4, .Y = 2, .Width = 21, .Height = 21, .Tag = True, .CanSnapToThisItem = False}
            imageItem.Appearance.BorderSize = 0
            imageItem.Appearance.BackColor = Color.Transparent
            Dim contentItem = New DiagramShape With {.X = 27, .Width = 173, .Height = 25, .CanSnapToThisItem = False}
            contentItem.Appearance.BorderSize = 0
            contentItem.Appearance.BackColor = Color.Transparent
            contentItem.Appearance.ForeColor = Color.Black
            contentItem.Appearance.Font = New Font(contentItem.Appearance.Font.FontFamily, 14)
            contentItem.Appearance.TextOptions.HAlignment = HorzAlignment.Near
            contentItem.Bindings.Add(New DiagramBinding("Content", "Name"))
            Dim connectionPoints = New List(Of PointFloat) From {New PointFloat(0, 0.5F), New PointFloat(1, 0.5F)}
            Dim columnItem = New DiagramContainer With {.Height = 30, .ConnectionPoints = New PointCollection(connectionPoints), .CanSnapToThisItem = False}
            columnItem.Items.Add(imageItem)
            columnItem.Items.Add(contentItem)
            columnItem.Appearance.BorderSize = 0
            Return columnItem
        End Function

        Private Shared Function CreateConnectionItem() As DiagramConnector
            Dim connector = New DiagramConnector With {.CanEdit = False, .CanDragBeginPoint = False, .CanChangeRoute = False, .CanDragEndPoint = False, .Type = ConnectorType.RightAngle, .BeginLabelArrowOffset = 4}
            connector.Bindings.Add(New DiagramBinding("BeginLeftLabel", "TableRelation([FromRelation])"))
            connector.Bindings.Add(New DiagramBinding("EndLeftLabel", "TableRelation([ToRelation])"))
            connector.Appearance.BorderSize = 2
            connector.Appearance.Font = New Font(connector.Appearance.Font.FontFamily, 13)
            Return connector
        End Function

        Private Function LoadSvgImage(ByVal svgPath As String) As SvgBitmap
            Return New SvgBitmap(GetSvgImageResource(svgPath))
        End Function
    End Class
End Namespace
