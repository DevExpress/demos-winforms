Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Diagram.Core
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraDiagram
Imports DevExpress.XtraDiagram.Designer
Imports DevExpress.XtraDiagram.Utils
Imports DevExpress.XtraEditors

Namespace Examples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(161)>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("ArrowDescriptions", "DiagramShape", "DiagramConnector", "Color", "Font", "BasicShapes", "DiagramShape")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Appearance", "GenericExamples.cs")>
    Public Module Appearance

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim diagram As DevExpress.XtraDiagram.DiagramControl = New DevExpress.XtraDiagram.DiagramControl()
            diagram.Parent = sampleHost
            diagram.Dock = System.Windows.Forms.DockStyle.Fill
            diagram.OptionsView.PageSize = New System.Drawing.SizeF(600, 400)
            diagram.FitToPage()
            Return New Object() {diagram}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            For Each control As System.Windows.Forms.Control In sampleHost.Controls
                control.Dispose()
            Next
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Diagram appearance")>
        Public Sub CustomizeDiagramAppearance(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl)
            Dim diagramItem1 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 10, 10, 200, 100)
            diagramItem1.Content = "Text"
            diagramControl.Appearance.Shape.Font = New System.Drawing.Font("Times New Roman", 40)
            diagramControl.Appearance.Shape.BackColor = System.Drawing.Color.Yellow
            diagramControl.Appearance.Shape.ForeColor = System.Drawing.Color.Red
            diagramControl.Appearance.Shape.BorderColor = System.Drawing.Color.Orange
            diagramControl.Appearance.Shape.BorderSize = 5
            diagramControl.Items.Add(diagramItem1)
            diagramControl.Items.Add(New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 10, 150, 200, 100))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Change shape appearance")>
        Public Sub ChangeShapeAppearance(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl)
            diagramControl.Appearance.Shape.Font = New System.Drawing.Font("Times New Roman", 40)
            diagramControl.Appearance.Shape.ForeColor = System.Drawing.Color.Yellow
            Dim diagramShape1 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 10, 150, 200, 100)
            Dim diagramShape2 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 250, 10, 200, 100)
            diagramShape1.Content = "Text1"
            diagramShape2.Content = "Text2"
            diagramShape1.Appearance.BackColor = System.Drawing.Color.Green
            diagramShape1.Appearance.BorderColor = System.Drawing.Color.Orange
            diagramShape2.Appearance.BorderColor = diagramShape1.Appearance.GetBackColor()
            diagramShape1.Appearance.BorderSize = 5
            diagramShape2.Appearance.BorderSize = 12
            diagramShape2.Appearance.Font = New System.Drawing.Font("Times New Roman", 20)
            diagramControl.Items.AddRange(diagramShape1, diagramShape2)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Change connector appearance")>
        Public Sub ChangeConnectorAppearance(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl)
            diagramControl.Appearance.Connector.ForeColor = System.Drawing.Color.Red
            Dim diagramShape1 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 50, 50, 50, 50)
            Dim diagramShape2 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 50, 150, 50, 50)
            Dim diagramShape3 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 300, 50, 50, 50)
            Dim diagramShape4 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 300, 150, 50, 50)
            Dim connector1 As DevExpress.XtraDiagram.DiagramConnector = New DevExpress.XtraDiagram.DiagramConnector(diagramShape1, diagramShape3)
            connector1.Content = "Text1"
            connector1.Appearance.ForeColor = System.Drawing.Color.Blue
            connector1.EndArrow = DevExpress.Diagram.Core.ArrowDescriptions.Open90
            Dim connector2 As DevExpress.XtraDiagram.DiagramConnector = New DevExpress.XtraDiagram.DiagramConnector(diagramShape2, diagramShape4)
            connector2.Content = "Text2"
            connector2.Appearance.ContentBackground = System.Drawing.Color.Yellow
            connector2.EndArrow = DevExpress.Diagram.Core.ArrowDescriptions.Open90
            diagramControl.Items.AddRange(diagramShape1, diagramShape2, diagramShape3, diagramShape4, connector1, connector2)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Custom Item Drawing")>
        Public Sub CustomDraw(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl)
            Dim shape As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 50, 50, 100, 75)
            shape.Content = "Rectangle with shadow"
            AddHandler diagramControl.CustomDrawItem, Sub(s, e)
                If e.Context = DevExpress.XtraDiagram.DiagramDrawingContext.Canvas OrElse e.Context = DevExpress.XtraDiagram.DiagramDrawingContext.DragPreview Then
                    Dim foreColor = e.Appearance.ForeColor
                    e.DefaultDraw(DevExpress.XtraDiagram.CustomDrawItemMode.Background)
                    Dim transform = e.GraphicsCache.GetTransform()
                    transform.Translate(1, 1)
                    e.GraphicsCache.SetTransform(transform)
                    e.Appearance.ForeColor = System.Drawing.Color.DarkGray
                    e.DefaultDraw(DevExpress.XtraDiagram.CustomDrawItemMode.Content)
                    transform.Translate(-1, -1)
                    e.GraphicsCache.SetTransform(transform)
                    e.Appearance.ForeColor = foreColor
                    e.DefaultDraw(DevExpress.XtraDiagram.CustomDrawItemMode.Content)
                    e.Handled = True
                End If
            End Sub
            diagramControl.Items.Add(shape)
            diagramControl.FitToItems({shape})
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(161)>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("DiagramShape", "BasicShapes", "List", "ShapeDescription", "DiagramToolboxRegistrator", "Rectangle", "Timer", "BasicFlowchartShapes", "ArrowShapes", "DecorativeShapes, DiagramStencil")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Create diagrams", "GenericExamples.cs")>
    Public Module CreateDiagrams

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim diagram As DevExpress.XtraDiagram.DiagramControl = New DevExpress.XtraDiagram.DiagramControl()
            diagram.Parent = sampleHost
            diagram.Dock = System.Windows.Forms.DockStyle.Fill
            diagram.OptionsView.PageSize = New System.Drawing.SizeF(600, 400)
            diagram.FitToPage()
            Dim hostButton As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton()
            Dim panel As DevExpress.XtraEditors.PanelControl = New DevExpress.XtraEditors.PanelControl()
            panel.Dock = System.Windows.Forms.DockStyle.Top
            hostButton.Parent = panel
            hostButton.Width = CInt((80 * DevExpress.Skins.DpiProvider.[Default].DpiScaleFactor))
            panel.Height = CInt((30 * DevExpress.Skins.DpiProvider.[Default].DpiScaleFactor))
            hostButton.Dock = System.Windows.Forms.DockStyle.Left
            diagram.Appearance.Shape.ForeColor = System.Drawing.Color.Black
            Return New Object() {diagram, panel, sampleHost}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            For Each control As System.Windows.Forms.Control In sampleHost.Controls
                control.Dispose()
            Next
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Add diagram item")>
        Public Sub AddDiagramItem(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl, ByVal panel As DevExpress.XtraEditors.PanelControl, ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            Dim diagramItem As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 50, 10, 200, 100)
            diagramControl.Items.Add(diagramItem)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Create various shapes")>
        Public Sub CreateVariousShapes(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl, ByVal panel As DevExpress.XtraEditors.PanelControl, ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            diagramControl.Items.Add(New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicFlowchartShapes.Subprocess, New System.Drawing.Rectangle(50, 50, 150, 100)))
            diagramControl.Items.Add(New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Decagon, New System.Drawing.Rectangle(250, 50, 150, 100)))
            diagramControl.Items.Add(New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.ArrowShapes.CurvedLeftArrow, New System.Drawing.Rectangle(50, 170, 150, 100)))
            diagramControl.Items.Add(New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.DecorativeShapes.Cloud, New System.Drawing.Rectangle(250, 170, 150, 100)))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Show all shapes")>
        Public Sub ShowVariousShapes(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl, ByVal panel As DevExpress.XtraEditors.PanelControl, ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            Dim descriptions As System.Collections.Generic.List(Of DevExpress.Diagram.Core.ShapeDescription) = New System.Collections.Generic.List(Of DevExpress.Diagram.Core.ShapeDescription)()
            For Each a As DevExpress.Diagram.Core.DiagramStencil In DevExpress.Diagram.Core.DiagramToolboxRegistrator.Stencils
                descriptions.AddRange(a.Shapes.ToList())
            Next

            Dim description As DevExpress.Diagram.Core.ShapeDescription = descriptions.First()
            Dim shape As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, New System.Drawing.Rectangle(200, 100, 200, 150))
            diagramControl.Items.Add(shape)
            Dim myTimer As System.Windows.Forms.Timer = New System.Windows.Forms.Timer()
            AddHandler myTimer.Tick, Sub(sender, e)
                If diagramControl.Page Is Nothing Then
                    myTimer.[Stop]()
                    Return
                End If

                shape.Shape = description
                shape.Content = description.Id
                Dim index As Integer = descriptions.IndexOf(description) + 1
                If index = descriptions.Count Then index = 0
                description = descriptions(index)
            End Sub
            myTimer.Interval = 500
            myTimer.Start()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("DeleteSelectedItems")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Delete selected items")>
        Public Sub DeleteSelectedItems(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl, ByVal panel As DevExpress.XtraEditors.PanelControl, ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            Dim diagramItem1 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 50, 50, 50, 50)
            Dim diagramItem2 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 50, 150, 50, 50)
            Dim diagramItem3 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 150, 50, 50, 50)
            Dim diagramItem4 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 150, 150, 50, 50)
            diagramControl.Items.AddRange(diagramItem1, diagramItem2, diagramItem3, diagramItem4)
            panel.Parent = diagramControl.Parent
            Dim button As DevExpress.XtraEditors.SimpleButton = TryCast(panel.Controls(0), DevExpress.XtraEditors.SimpleButton)
            button.Text = "Delete"
            AddHandler button.Click, Sub(sender, e) diagramControl.DeleteSelectedItems()
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("Size", "DiagramShape")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(161)>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Customize diagram items", "GenericExamples.cs")>
    Public Module CustomizeDiagramItems

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim diagram As DevExpress.XtraDiagram.DiagramControl = New DevExpress.XtraDiagram.DiagramControl()
            diagram.Parent = sampleHost
            diagram.Dock = System.Windows.Forms.DockStyle.Fill
            diagram.OptionsView.PageSize = New System.Drawing.SizeF(600, 400)
            diagram.FitToPage()
            Dim diagramItem As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 100, 100, 200, 100)
            diagram.Items.Add(diagramItem)
            Return New Object() {diagram}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            For Each control As System.Windows.Forms.Control In sampleHost.Controls
                control.Dispose()
            Next
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Resize diagram item")>
        Public Sub ResizeDiagramItem(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl)
            diagramControl.Items(CInt((0))).Size = New System.Drawing.Size(50, 100)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Show text in diagram item")>
        Public Sub ShowDiagramItemText(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl)
            TryCast(diagramControl.Items(CInt((0))), DevExpress.XtraDiagram.DiagramShape).Content = "Text"
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Customize item properties")>
        Public Sub CustomizeProperties(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl)
            diagramControl.Items(CInt((0))).CanDelete = False
            diagramControl.Items(CInt((0))).CanMove = False
            diagramControl.Items(CInt((0))).CanCopy = False
            diagramControl.Items(CInt((0))).CanRotate = False
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Rotate item")>
        Public Sub RotateItem(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl)
            diagramControl.Items(CInt((0))).Angle = 30
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Diagram connectors", "GenericExamples.cs")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("DiagramShape", "DiagramConnector", "Point", "ArrowDescriptions", "BasicShapes", "SizeF", "Timer", "Math")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(161)>
    Public Module DiagramConnectors

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim diagram As DevExpress.XtraDiagram.DiagramControl = New DevExpress.XtraDiagram.DiagramControl()
            diagram.Parent = sampleHost
            diagram.Dock = System.Windows.Forms.DockStyle.Fill
            diagram.OptionsView.PageSize = New System.Drawing.SizeF(600, 400)
            diagram.FitToPage()
            Return New Object() {diagram}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            For Each control As System.Windows.Forms.Control In sampleHost.Controls
                control.Dispose()
            Next
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Create diagram connector")>
        Public Sub CreateDiagramConnector(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl)
            Dim connector As DevExpress.XtraDiagram.DiagramConnector = New DevExpress.XtraDiagram.DiagramConnector(New System.Drawing.Point(50, 50), New System.Drawing.Point(200, 200), New System.Drawing.Point(50, 200))
            connector.EndArrow = DevExpress.Diagram.Core.ArrowDescriptions.Filled90
            diagramControl.Items.Add(connector)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Arrow Styles")>
        Public Sub CustomizeArrowStyle(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl)
            Dim connector1 As DevExpress.XtraDiagram.DiagramConnector = New DevExpress.XtraDiagram.DiagramConnector(New System.Drawing.Point(50, 50), New System.Drawing.Point(300, 50))
            connector1.EndArrow = DevExpress.Diagram.Core.ArrowDescriptions.Diamond
            Dim connector2 As DevExpress.XtraDiagram.DiagramConnector = New DevExpress.XtraDiagram.DiagramConnector(New System.Drawing.Point(50, 100), New System.Drawing.Point(300, 100))
            connector2.EndArrow = DevExpress.Diagram.Core.ArrowDescriptions.Filled90
            Dim connector3 As DevExpress.XtraDiagram.DiagramConnector = New DevExpress.XtraDiagram.DiagramConnector(New System.Drawing.Point(50, 150), New System.Drawing.Point(300, 150))
            connector3.EndArrow = DevExpress.Diagram.Core.ArrowDescriptions.Open90
            Dim connector4 As DevExpress.XtraDiagram.DiagramConnector = New DevExpress.XtraDiagram.DiagramConnector(New System.Drawing.Point(50, 200), New System.Drawing.Point(300, 200))
            connector4.EndArrow = DevExpress.Diagram.Core.ArrowDescriptions.FilledFletch
            diagramControl.Items.AddRange(connector1, connector2, connector3, connector4)
        'Various styles:
        'ClosedASMEArrow, ClosedDiamond, ClosedDot, ClosedDoubleArrow, Diamond, Filled90, FilledDiamond, FilledDot, FilledDoubleArrow, FilledFletch
        'FilledSquare, IndentedFilledArrow, Open90, OpenFletch, OutdentedFilledArrow
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Show all arrow Styles")>
        Public Sub ShowArrowStyles(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl)
            Dim diagramItem1 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 100, 100, 100, 100)
            Dim diagramItem2 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 400, 100, 100, 100)
            Dim connector1 As DevExpress.XtraDiagram.DiagramConnector = New DevExpress.XtraDiagram.DiagramConnector(diagramItem1, diagramItem2)
            connector1.EndArrowSize = New System.Drawing.SizeF(20, 20)
            diagramControl.Items.AddRange(diagramItem1, diagramItem2, connector1)
            Dim index As Integer = 0
            Dim myTimer As System.Windows.Forms.Timer = New System.Windows.Forms.Timer()
            AddHandler myTimer.Tick, Sub(sender, e)
                If diagramControl.Page Is Nothing Then
                    myTimer.[Stop]()
                    Return
                End If

                connector1.EndArrow = DevExpress.Diagram.Core.ArrowDescriptions.Arrows.ElementAt(index)
                connector1.Content = System.Linq.Enumerable.ElementAt(Of DevExpress.Diagram.Core.ArrowDescription)(DevExpress.Diagram.Core.ArrowDescriptions.Arrows, CInt((index))).Id
                index += 1
                If index = DevExpress.Diagram.Core.ArrowDescriptions.Arrows.Count() Then index = 0
            End Sub
            myTimer.Interval = 700
            myTimer.Start()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Resize arrow")>
        Public Sub ChangeArrowSize(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl)
            Dim connector As DevExpress.XtraDiagram.DiagramConnector = New DevExpress.XtraDiagram.DiagramConnector(New System.Drawing.Point(50, 50), New System.Drawing.Point(200, 200), New System.Drawing.Point(50, 200))
            connector.EndArrow = DevExpress.Diagram.Core.ArrowDescriptions.Filled90
            connector.EndArrowSize = New System.Drawing.SizeF(30, 20)
            diagramControl.Items.Add(connector)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Connect diagram items")>
        Public Sub ConnectDiagramItems(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl)
            Dim diagramItem1 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 10, 10, 200, 100)
            Dim diagramItem2 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 10, 200, 200, 100)
            Dim connector1 As DevExpress.XtraDiagram.DiagramConnector = New DevExpress.XtraDiagram.DiagramConnector(diagramItem1, diagramItem2)
            connector1.EndArrow = DevExpress.Diagram.Core.ArrowDescriptions.Filled90
            Dim diagramItem3 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 250, 10, 200, 100)
            Dim diagramItem4 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 400, 200, 200, 100)
            Dim connector2 As DevExpress.XtraDiagram.DiagramConnector = New DevExpress.XtraDiagram.DiagramConnector(diagramItem3, diagramItem4, New System.Drawing.Point(350, 250))
            connector2.EndArrow = DevExpress.Diagram.Core.ArrowDescriptions.Filled90
            diagramControl.Items.AddRange(diagramItem1, diagramItem2, diagramItem3, diagramItem4, connector1, connector2)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Connect two items")>
        Public Sub ConnectTwoItems(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl)
            Dim a As Double = System.Math.PI / 2
            Dim rad = 100
            Dim diagramItem1 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 200, 100, 50, 50)
            Dim diagramItem2 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 200, 200, 50, 50)
            diagramControl.Items.AddRange(diagramItem1, diagramItem2, New DevExpress.XtraDiagram.DiagramConnector(diagramItem1, diagramItem2))
            Dim myTimer As System.Windows.Forms.Timer = New System.Windows.Forms.Timer()
            AddHandler myTimer.Tick, Sub(sender, e)
                If diagramControl.Page Is Nothing Then
                    myTimer.[Stop]()
                    Return
                End If

                a += System.Math.PI / 10
                diagramItem2.X = diagramItem1.X + CInt((rad * System.Math.Cos(a)))
                diagramItem2.Y = diagramItem1.Y + CInt((rad * System.Math.Sin(a)))
                myTimer.Enabled = True
                diagramControl.UpdateRoute()
            End Sub
            myTimer.Interval = 250
            myTimer.Start()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Customize connector properties")>
        Public Sub CustomizeConnectorProperties(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl)
            Dim connector As DevExpress.XtraDiagram.DiagramConnector = New DevExpress.XtraDiagram.DiagramConnector(New System.Drawing.Point(50, 50), New System.Drawing.Point(200, 200), New System.Drawing.Point(50, 200))
            connector.EndArrow = DevExpress.Diagram.Core.ArrowDescriptions.Filled90
            connector.CanCopy = False
            connector.CanDelete = False
            diagramControl.Items.Add(connector)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Show text in diagram connector")>
        Public Sub ShowTextInDiagramConnector(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl)
            Dim connector As DevExpress.XtraDiagram.DiagramConnector = New DevExpress.XtraDiagram.DiagramConnector(New System.Drawing.Point(50, 50), New System.Drawing.Point(200, 200))
            connector.EndArrow = DevExpress.Diagram.Core.ArrowDescriptions.Filled90
            connector.Content = "Text"
            diagramControl.Items.Add(connector)
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Diagram properties", "GenericExamples.cs")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("SizeF", "DiagramDesignerUtils", "DiagramDesignerForm", "FormWindowState", "DiagramDesignerUtils")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(161)>
    Public Module DiagramProperties

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim diagram As DevExpress.XtraDiagram.DiagramControl = New DevExpress.XtraDiagram.DiagramControl()
            diagram.Parent = sampleHost
            diagram.Dock = System.Windows.Forms.DockStyle.Fill
            diagram.OptionsView.PageSize = New System.Drawing.SizeF(600, 400)
            diagram.FitToPage()
            Dim hostButton As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton()
            Dim hostButton1 As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton()
            Dim panel As DevExpress.XtraEditors.PanelControl = New DevExpress.XtraEditors.PanelControl()
            panel.Dock = System.Windows.Forms.DockStyle.Top
            hostButton.Parent = panel
            hostButton1.Parent = panel
            hostButton1.Width = CInt((80 * DevExpress.Skins.DpiProvider.[Default].DpiScaleFactor))
            hostButton.Width = CInt((80 * DevExpress.Skins.DpiProvider.[Default].DpiScaleFactor))
            panel.Height = CInt((30 * DevExpress.Skins.DpiProvider.[Default].DpiScaleFactor))
            hostButton.Dock = System.Windows.Forms.DockStyle.Left
            hostButton1.Dock = System.Windows.Forms.DockStyle.Left
            Dim diagramItem1 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 200, 120, 50, 50)
            Dim diagramItem2 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 270, 120, 50, 50)
            Dim diagramItem3 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 200, 190, 50, 50)
            Dim diagramItem4 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 270, 190, 50, 50)
            diagram.Items.AddRange(diagramItem1, diagramItem2, diagramItem3, diagramItem4)
            Return New Object() {diagram, panel, sampleHost}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            For Each control As System.Windows.Forms.Control In sampleHost.Controls
                control.Dispose()
            Next
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Page size")>
        Public Sub PageSize(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl, ByVal panel As DevExpress.XtraEditors.PanelControl, ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            diagramControl.OptionsView.PageSize = New System.Drawing.SizeF(550, 400)
            diagramControl.FitToPage()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Grid size")>
        Public Sub GridSize(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl, ByVal panel As DevExpress.XtraEditors.PanelControl, ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            diagramControl.OptionsView.GridSize = New System.Drawing.SizeF(50, 50)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Draw Grid and Rulers")>
        Public Sub DrawGridAndRulers(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl, ByVal panel As DevExpress.XtraEditors.PanelControl, ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            diagramControl.OptionsView.ShowGrid = False
            diagramControl.OptionsView.ShowRulers = False
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Zooming")>
        Public Sub Zooming(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl, ByVal panel As DevExpress.XtraEditors.PanelControl, ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            panel.Parent = diagramControl.Parent
            Dim button1 As DevExpress.XtraEditors.SimpleButton = TryCast(panel.Controls(0), DevExpress.XtraEditors.SimpleButton)
            Dim button2 As DevExpress.XtraEditors.SimpleButton = TryCast(panel.Controls(1), DevExpress.XtraEditors.SimpleButton)
            button1.Text = "Zoom In"
            button2.Text = "Zoom Out"
            AddHandler button1.Click, Sub(sender, e) diagramControl.OptionsView.ZoomFactor += 0.1F
            AddHandler button2.Click, Sub(sender, e) diagramControl.OptionsView.ZoomFactor -= 0.1F
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("Clear")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Clear diagram contents")>
        Public Sub ClearDiagramContents(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl, ByVal panel As DevExpress.XtraEditors.PanelControl, ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            panel.Parent = diagramControl.Parent
            Dim button As DevExpress.XtraEditors.SimpleButton = TryCast(panel.Controls(0), DevExpress.XtraEditors.SimpleButton)
            button.Text = "Clear"
            AddHandler button.Click, Sub(sender, e) diagramControl.Items.Clear()
            panel.Controls(CInt((1))).Dispose()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("RunDesigner")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Design diagram")>
        Public Sub DesignDiagram(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl, ByVal panel As DevExpress.XtraEditors.PanelControl, ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            panel.Parent = diagramControl.Parent
            Dim button As DevExpress.XtraEditors.SimpleButton = TryCast(panel.Controls(0), DevExpress.XtraEditors.SimpleButton)
            button.Text = "Design"
            AddHandler button.Click, Sub(sender, e)
                Dim designerForm = New DevExpress.XtraDiagram.Designer.DiagramDesignerForm() With {.ShowInTaskbar = False, .WindowState = System.Windows.Forms.FormWindowState.Maximized}
                Call DevExpress.XtraDiagram.Utils.DiagramDesignerUtils.RunDesigner(diagramControl, designerForm)
            End Sub
            panel.Controls(CInt((1))).Dispose()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Select items")>
        Public Sub SelectItems(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl, ByVal panel As DevExpress.XtraEditors.PanelControl, ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            diagramControl.SelectItems(diagramControl.Items(0), diagramControl.Items(1), diagramControl.Items(2), diagramControl.Items(3))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CopySelectedItems", "Paste")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Copy and Paste")>
        Public Sub CopyPaste(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl, ByVal panel As DevExpress.XtraEditors.PanelControl, ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            panel.Parent = diagramControl.Parent
            Dim button1 As DevExpress.XtraEditors.SimpleButton = TryCast(panel.Controls(0), DevExpress.XtraEditors.SimpleButton)
            Dim button2 As DevExpress.XtraEditors.SimpleButton = TryCast(panel.Controls(1), DevExpress.XtraEditors.SimpleButton)
            button1.Text = "Copy"
            button2.Text = "Paste"
            AddHandler button1.Click, Sub(sender, e) diagramControl.CopySelectedItems()
            AddHandler button2.Click, Sub(sender, e) diagramControl.Paste()
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(161)>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("SimpleButton", "SeekOrigin", "MemoryStream")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Save and load documents", "GenericExamples.cs")>
    Public Module SaveLoadDocument

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim diagram As DevExpress.XtraDiagram.DiagramControl = New DevExpress.XtraDiagram.DiagramControl()
            diagram.Parent = sampleHost
            diagram.Dock = System.Windows.Forms.DockStyle.Fill
            diagram.OptionsView.PageSize = New System.Drawing.SizeF(600, 400)
            diagram.FitToPage()
            Dim hostButton As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton()
            Dim hostButton1 As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton()
            Dim panel As DevExpress.XtraEditors.PanelControl = New DevExpress.XtraEditors.PanelControl()
            panel.Dock = System.Windows.Forms.DockStyle.Top
            hostButton.Parent = panel
            hostButton1.Parent = panel
            hostButton1.Width = CInt((80 * DevExpress.Skins.DpiProvider.[Default].DpiScaleFactor))
            hostButton.Width = CInt((80 * DevExpress.Skins.DpiProvider.[Default].DpiScaleFactor))
            panel.Height = CInt((30 * DevExpress.Skins.DpiProvider.[Default].DpiScaleFactor))
            hostButton.Dock = System.Windows.Forms.DockStyle.Left
            hostButton1.Dock = System.Windows.Forms.DockStyle.Left
            panel.Parent = sampleHost
            Dim diagramItem1 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 50, 50, 50, 50)
            Dim num = 1
            For i As Integer = 0 To 3 - 1
                For j As Integer = 0 To 3 - 1
                    diagramItem1.Content = System.[String].Format("Item {0}", System.Math.Min(System.Threading.Interlocked.Increment(num), num - 1))
                    diagram.Items.Add(diagramItem1)
                    diagramItem1 = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, diagramItem1.X + diagramItem1.Width + 20, diagramItem1.Y, 50, 50)
                Next

                diagramItem1 = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 50, diagramItem1.Y + diagramItem1.Height + 20, 50, 50)
            Next

            diagram.FitToDrawing()
            Return New Object() {diagram, panel}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            For Each control As System.Windows.Forms.Control In sampleHost.Controls
                control.Dispose()
            Next
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("SaveDocument", "LoadDocument")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Save and restore diagram to/from stream")>
        Public Sub SaveRestoreDiagramFromStream(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl, ByVal panel As DevExpress.XtraEditors.PanelControl)
            Dim button1 As DevExpress.XtraEditors.SimpleButton = TryCast(panel.Controls(0), DevExpress.XtraEditors.SimpleButton)
            Dim button2 As DevExpress.XtraEditors.SimpleButton = TryCast(panel.Controls(1), DevExpress.XtraEditors.SimpleButton)
            button1.Text = "Save"
            button2.Text = "Restore"
            Dim memoryStream As System.IO.MemoryStream = New System.IO.MemoryStream()
            diagramControl.SaveDocument(memoryStream)
            AddHandler button1.Click, Sub(sender, e)
                memoryStream.Dispose()
                memoryStream = New System.IO.MemoryStream()
                diagramControl.SaveDocument(memoryStream)
            End Sub
            AddHandler button2.Click, Sub(sender, e)
                memoryStream.Seek(0, System.IO.SeekOrigin.Begin)
                diagramControl.LoadDocument(memoryStream)
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("SaveFile", "OpenFile")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Save and restore diagram to/from file")>
        Public Sub SaveRestoreDiagramInFile(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl, ByVal panel As DevExpress.XtraEditors.PanelControl)
            Dim button1 As DevExpress.XtraEditors.SimpleButton = TryCast(panel.Controls(0), DevExpress.XtraEditors.SimpleButton)
            Dim button2 As DevExpress.XtraEditors.SimpleButton = TryCast(panel.Controls(1), DevExpress.XtraEditors.SimpleButton)
            button1.Text = "Save File"
            button2.Text = "Load File"
            AddHandler button1.Click, Sub(sender, e) diagramControl.SaveFile()
            AddHandler button2.Click, Sub(sender, e) diagramControl.OpenFile()
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Themes", "GenericExamples.cs")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("DiagramThemes", "DiagramShapeStyleId", "ThemeRegistrator", "Timer", "DiagramConnectorStyleId", "DiagramShapeStyleId", "DiagramConnector", "DiagramShape")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(161)>
    Public Module Themes

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim diagram As DevExpress.XtraDiagram.DiagramControl = New DevExpress.XtraDiagram.DiagramControl()
            diagram.Parent = sampleHost
            diagram.Dock = System.Windows.Forms.DockStyle.Fill
            diagram.OptionsView.PageSize = New System.Drawing.SizeF(600, 400)
            diagram.FitToPage()
            Dim diagramItem1 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 100, 100, 100, 100)
            Dim diagramItem2 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 350, 100, 100, 100)
            Dim diagramConnector1 As DevExpress.XtraDiagram.DiagramConnector = New DevExpress.XtraDiagram.DiagramConnector(diagramItem1, diagramItem2)
            diagramConnector1.EndArrow = DevExpress.Diagram.Core.ArrowDescriptions.Filled90
            diagram.Items.AddRange(diagramItem2, diagramConnector1, diagramItem1)
            Return New Object() {diagram}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            For Each control As System.Windows.Forms.Control In sampleHost.Controls
                control.Dispose()
            Next
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Diagram theme")>
        Public Sub GlobalTheme(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl)
            diagramControl.OptionsView.Theme = DevExpress.Diagram.Core.DiagramThemes.NoTheme
        'DiagramThemes: Daybreak, Integral, Linear, Lines, Office, Parallel, Sequence
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Shape theme")>
        Public Sub ShapeTheme(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl)
            diagramControl.OptionsView.Theme = DevExpress.Diagram.Core.DiagramThemes.Office
            diagramControl.Items(CInt((0))).ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant3
            diagramControl.Items(CInt((2))).ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant2
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Connector theme")>
        Public Sub ConnectorTheme(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl)
            diagramControl.OptionsView.Theme = DevExpress.Diagram.Core.DiagramThemes.Linear
            diagramControl.Items(CInt((1))).ThemeStyleId = DevExpress.Diagram.Core.DiagramConnectorStyleId.Intense2
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Show all diagram themes")>
        Public Sub ShowVariousGlobalThemes(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl)
            Dim index As Integer = 0
            Dim myTimer As System.Windows.Forms.Timer = New System.Windows.Forms.Timer()
            AddHandler myTimer.Tick, Sub(sender, e)
                If diagramControl.Page Is Nothing Then
                    myTimer.[Stop]()
                    Return
                End If

                diagramControl.OptionsView.Theme = DevExpress.Diagram.Core.ThemeRegistrator.Themes.ElementAt(index)
                index += 1
                If index = DevExpress.Diagram.Core.ThemeRegistrator.Themes.Count() Then index = 0
            End Sub
            myTimer.Interval = 700
            myTimer.Start()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Show all item themes")>
        Public Sub ShowConnectorAndShapeThemes(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl)
            Dim diagramShape1 As DevExpress.XtraDiagram.DiagramShape = TryCast(diagramControl.Items(0), DevExpress.XtraDiagram.DiagramShape)
            Dim diagramShape2 As DevExpress.XtraDiagram.DiagramShape = TryCast(diagramControl.Items(2), DevExpress.XtraDiagram.DiagramShape)
            Dim diagramConnector1 As DevExpress.XtraDiagram.DiagramConnector = TryCast(diagramControl.Items(1), DevExpress.XtraDiagram.DiagramConnector)
            Dim index1 As Integer = 0
            Dim index2 As Integer = 0
            Dim myTimer As System.Windows.Forms.Timer = New System.Windows.Forms.Timer()
            AddHandler myTimer.Tick, Sub(sender, e)
                If diagramControl.Page Is Nothing Then
                    myTimer.[Stop]()
                    Return
                End If

                Dim id As String() = DevExpress.Diagram.Core.DiagramShapeStyleId.Styles(CInt((index1))).Id.Split("."c)
                diagramShape1.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Styles(index1)
                diagramShape1.Content = id(id.Count() - 1)
                diagramShape2.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Styles(index1)
                diagramShape2.Content = id(id.Count() - 1)
                diagramConnector1.ThemeStyleId = DevExpress.Diagram.Core.DiagramConnectorStyleId.Styles(index2)
                diagramConnector1.Content = DevExpress.Diagram.Core.DiagramConnectorStyleId.Styles(CInt((index2))).Id.Split("."c)(1)
                index1 += 1
                index2 += 1
                If index1 = DevExpress.Diagram.Core.DiagramShapeStyleId.Styles.Count Then index1 = 0
                If index2 = DevExpress.Diagram.Core.DiagramConnectorStyleId.Styles.Count Then index2 = 0
            End Sub
            myTimer.Interval = 700
            myTimer.Start()
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Undo and Redo Operations", "GenericExamples.cs")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(161)>
    Public Module UndoRedoInCode

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim diagram As DevExpress.XtraDiagram.DiagramControl = New DevExpress.XtraDiagram.DiagramControl()
            diagram.Parent = sampleHost
            diagram.Dock = System.Windows.Forms.DockStyle.Fill
            diagram.OptionsView.PageSize = New System.Drawing.SizeF(600, 400)
            diagram.FitToPage()
            Dim hostButton As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton()
            Dim hostButton1 As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton()
            Dim panel As DevExpress.XtraEditors.PanelControl = New DevExpress.XtraEditors.PanelControl()
            panel.Dock = System.Windows.Forms.DockStyle.Top
            hostButton.Parent = panel
            hostButton1.Parent = panel
            hostButton1.Width = CInt((80 * DevExpress.Skins.DpiProvider.[Default].DpiScaleFactor))
            hostButton.Width = CInt((80 * DevExpress.Skins.DpiProvider.[Default].DpiScaleFactor))
            panel.Height = CInt((30 * DevExpress.Skins.DpiProvider.[Default].DpiScaleFactor))
            hostButton.Dock = System.Windows.Forms.DockStyle.Left
            hostButton1.Dock = System.Windows.Forms.DockStyle.Left
            panel.Parent = sampleHost
            Dim diagramItem1 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 50, 50, 100, 100)
            Dim diagramItem2 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 200, 50, 100, 100)
            Dim connector As DevExpress.XtraDiagram.DiagramConnector = New DevExpress.XtraDiagram.DiagramConnector(diagramItem1, diagramItem2)
            connector.EndArrow = DevExpress.Diagram.Core.ArrowDescriptions.Filled90
            diagram.Items.Add(connector)
            diagram.Items.Add(diagramItem1)
            diagram.Items.Add(diagramItem2)
            Return New Object() {diagram, panel}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            For Each control As System.Windows.Forms.Control In sampleHost.Controls
                control.Dispose()
            Next
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("Undo", "Redo")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Undo and Redo")>
        Public Sub UndoAndRedo(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl, ByVal panel As DevExpress.XtraEditors.PanelControl)
            Dim button1 As DevExpress.XtraEditors.SimpleButton = TryCast(panel.Controls(0), DevExpress.XtraEditors.SimpleButton)
            Dim button2 As DevExpress.XtraEditors.SimpleButton = TryCast(panel.Controls(1), DevExpress.XtraEditors.SimpleButton)
            button1.Text = "Undo"
            button2.Text = "Redo"
            AddHandler button1.Click, Sub(sender, e) diagramControl.UndoManager.Undo()
            AddHandler button2.Click, Sub(sender, e) diagramControl.UndoManager.Redo()
        End Sub
    End Module
End Namespace
