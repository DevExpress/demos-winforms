Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.Diagram.Core
Imports DevExpress.Diagram.Demos
Imports DevExpress.Utils
Imports DevExpress.Utils.Serializing

Namespace DevExpress.XtraDiagram.Demos

    Public Partial Class CustomShapesModule
        Inherits DocumentModuleBase

        Public Sub New()
            InitializeComponent()
            AddHandler diagramControl.CustomGetEditableItemProperties, AddressOf DiagramControl_CustomGetEditableItemProperties
            AddHandler diagramControl.CustomDrawItem, AddressOf DiagramControl_CustomDrawItem
            InitializeStencils()
        End Sub

        Protected Overrides ReadOnly Property DocumentName As String
            Get
                Return "CustomShapesDocument_Win.xml"
            End Get
        End Property

        Private svgStencil As DiagramStencil

        Private customShapesStencil As DiagramStencil

        Private customDrawShapesStencil As DiagramStencil

        Private Sub InitializeStencils()
            customShapesStencil = CreateStencilFromFile(GetDataFileName("CustomShapes.xml"), "CustomShapes", "Custom Shapes")
            svgStencil = CreatePredefinedSvgStencil("SvgShapes", "Svg Shapes")
            customDrawShapesStencil = CreateCustomDrawShapesStencil()
            diagramControl.OptionsBehavior.Stencils = CreateExtendedStencilCollection(svgStencil, customShapesStencil, customDrawShapesStencil)
        End Sub

        Private Function CreateCustomDrawShapesStencil() As DiagramStencil
            Dim stencilId = "CustomDrawShapes"
            DiagramControl.ItemTypeRegistrator.Register(GetType(DiagramShapeEx))
            Dim stencil = New DiagramStencil(stencilId, "Custom Draw Shapes", False)
            Dim shapeSize = New System.Windows.Size(150, 100)
            stencil.RegisterTool(New FactoryItemTool("activeTaskShape", Function() "Active Task", Function(diagram) New DiagramShapeEx With {.Content = "Active Task", .Status = Status.Active}, shapeSize))
            stencil.RegisterTool(New FactoryItemTool("inactiveTaskShape", Function() "Inactive Task", Function(diagram) New DiagramShapeEx With {.Content = "Inactive Task", .Status = Status.Inactive}, shapeSize))
            Return stencil
        End Function

        Private Sub DiagramControlItemInitializing(ByVal sender As Object, ByVal e As DiagramItemInitializingEventArgs)
            Call InitializeSvgShape(svgStencil, TryCast(e.Item, IDiagramShape))
        End Sub

        Private Sub DiagramControl_CustomGetEditableItemProperties(ByVal sender As Object, ByVal e As DiagramCustomGetEditableItemPropertiesEventArgs)
            If TypeOf e.Item Is DiagramShapeEx Then e.Properties.Add(TypeDescriptor.GetProperties(GetType(DiagramShapeEx))("Status"))
        End Sub

        Private Sub ToolTipController_GetActiveObjectInfo(ByVal sender As Object, ByVal e As ToolTipControllerGetActiveObjectInfoEventArgs)
            If e.SelectedControl IsNot diagramControl Then Return
            Dim toolTipInfo As ToolTipControlInfo = Nothing
            Dim item = diagramControl.CalcHitItem(e.ControlMousePosition)
            If item IsNot Nothing AndAlso item.Tag IsNot Nothing Then toolTipInfo = New ToolTipControlInfo(item, item.Tag.ToString())
            If toolTipInfo IsNot Nothing Then e.Info = toolTipInfo
        End Sub

        Private Sub DiagramControl_CustomDrawItem(ByVal sender As Object, ByVal e As CustomDrawItemEventArgs)
            Dim shape = TryCast(e.Item, DiagramShapeEx)
            If shape Is Nothing Then Return
            e.DefaultDraw()
            Dim imagePath = If(shape.Status = Status.Active, "images/actions/apply_16x16.png", "images/actions/cancel_16x16.png")
            Dim image = Images.ImageResourceCache.Default.GetImage(imagePath)
            Dim margin = 3F
            e.GraphicsCache.DrawImage(image, New RectangleF(shape.Width - image.Width - margin, shape.Height - image.Height - margin, image.Width, image.Height))
            e.Handled = True
        End Sub
    End Class

    Public Class DiagramShapeEx
        Inherits DiagramShape

        <XtraSerializableProperty, Category("Info")>
        <DefaultValue(Status.Active)>
        Public Property Status As Status = Status.Active
    End Class

    Public Enum Status
        Active
        Inactive
    End Enum
End Namespace
