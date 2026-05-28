Imports System
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Diagram.Core
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.Skins
Imports DevExpress.XtraDiagram
Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports DevExpress.Diagram.Core.Native

Namespace Examples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Prohibiting actions", "EventsExamples.cs")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("DiagramShape", "DiagramConnector", "ItemsActionKind", "BasicShapes")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(161)>
    Public Module ProhibitingActionsExamples

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim diagram As DevExpress.XtraDiagram.DiagramControl = New DevExpress.XtraDiagram.DiagramControl()
            diagram.Parent = sampleHost
            diagram.Dock = System.Windows.Forms.DockStyle.Fill
            diagram.OptionsView.PageSize = New System.Drawing.SizeF(400, 300)
            diagram.FitToPage()
            Return New Object() {diagram}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            For Each control As System.Windows.Forms.Control In sampleHost.Controls
                control.Dispose()
            Next
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Prohibiting actions 1")>
        Public Sub ProhibitingActions1(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl)
            ' Each time the end-user tries to perform an action on a diagram item, the QueryItemsAction event is raised.
            ' The following implementation restricts certain actions based on the item's content.
            AddHandler diagramControl.QueryItemsAction, Sub(sender, e)
                Select Case e.Action
                    Case DevExpress.Diagram.Core.ItemsActionKind.MoveCopy
                        GoTo _Select0_CaseDevExpress_Diagram_Core_ItemsActionKind_Move
                    Case DevExpress.Diagram.Core.ItemsActionKind.Move
_Select0_CaseDevExpress_Diagram_Core_ItemsActionKind_Move:
                        If e.Items.OfType(Of DevExpress.XtraDiagram.DiagramShape)().Any(Function(x) Equals(x.Content, "Non-movable")) Then e.Allow = False
                    Case DevExpress.Diagram.Core.ItemsActionKind.Resize
                        If e.Items.OfType(Of DevExpress.XtraDiagram.DiagramShape)().Any(Function(x) Equals(x.Content, "Non-resizable")) Then e.Allow = False
                    Case DevExpress.Diagram.Core.ItemsActionKind.Rotate
                        If e.Items.OfType(Of DevExpress.XtraDiagram.DiagramShape)().Any(Function(x) Equals(x.Content, "Non-rotatable")) Then e.Allow = False
                End Select
            End Sub
            diagramControl.Items.Add(New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Ellipse, 20, 40, 120, 50, "Non-movable"))
            diagramControl.Items.Add(New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 140, 120, 120, 50, "Non-resizable"))
            diagramControl.Items.Add(New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Parallelogram, 260, 200, 120, 50, "Non-rotatable"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Prohibiting actions 2")>
        Public Sub ProhibitingActions2(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl)
            ' Each time the end-user tries to perform an action on a diagram item, the QueryItemsAction event is raised.
            ' The following implementation restricts certain actions based on the item's content.
            AddHandler diagramControl.QueryItemsAction, Sub(sender, e)
                Select Case e.Action
                    Case DevExpress.Diagram.Core.ItemsActionKind.MoveCopy
                        GoTo _Select0_CaseDevExpress_Diagram_Core_ItemsActionKind_Copy
                    Case DevExpress.Diagram.Core.ItemsActionKind.Copy
_Select0_CaseDevExpress_Diagram_Core_ItemsActionKind_Copy:
                        If e.Items.OfType(Of DevExpress.XtraDiagram.DiagramShape)().Any(Function(x) Equals(x.Content, "Non-copyable")) Then e.Allow = False
                    Case DevExpress.Diagram.Core.ItemsActionKind.Delete
                        If e.Items.OfType(Of DevExpress.XtraDiagram.DiagramShape)().Any(Function(x) Equals(x.Content, "Non-deletable")) Then e.Allow = False
                End Select
            End Sub
            AddHandler diagramControl.QueryItemEditAction, Sub(sender, e)
                If TypeOf e.Item Is DevExpress.XtraDiagram.DiagramShape AndAlso Equals(CType(e.Item, DevExpress.XtraDiagram.DiagramShape).Content, "Non-editable") Then e.Allow = False
            End Sub
            diagramControl.Items.Add(New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Ellipse, 20, 40, 120, 50, "Non-copyable"))
            diagramControl.Items.Add(New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 140, 120, 120, 50, "Non-deletable"))
            diagramControl.Items.Add(New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Parallelogram, 260, 200, 120, 50, "Non-editable"))
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Constraining actions", "EventsExamples.cs")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("DiagramShape", "DiagramConnector", "ItemsActionKind", "BasicShapes", "ResizingItem", "SizeF", "ResizeMode", "RotatingItem", "MovingItem", "Math", "PointF", "PointFloat")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(161)>
    Public Module ConstrainingActionsExamples

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim diagram As DevExpress.XtraDiagram.DiagramControl = New DevExpress.XtraDiagram.DiagramControl()
            diagram.Parent = sampleHost
            diagram.Dock = System.Windows.Forms.DockStyle.Fill
            diagram.OptionsView.PageSize = New System.Drawing.SizeF(400, 300)
            diagram.FitToPage()
            Dim marker As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 180, 50, 180, 200)
            marker.Appearance.BorderDashPattern = New DevExpress.Diagram.Core.DiagramDoubleCollection({8.0, 8.0})
            marker.Appearance.BorderColor = System.Drawing.Color.FromArgb(200, 20, 20)
            marker.Appearance.BackColor = System.Drawing.Color.Transparent
            marker.Appearance.BorderSize = 3
            marker.CanRotate = False
            marker.CanResize = marker.CanRotate
            marker.CanSelect = marker.CanResize
            marker.CanMove = marker.CanSelect
            Return New Object() {diagram, marker}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            For Each control As System.Windows.Forms.Control In sampleHost.Controls
                control.Dispose()
            Next
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Max width")>
        Public Sub MaxWidth(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl, ByVal restrictedPartMarker As DevExpress.XtraDiagram.DiagramShape)
            ' Each time the end-user tries to resize a diagram item, the ItemsResizing event is raised.
            ' The following implementation sets the maximum width based on the item's content.
            AddHandler diagramControl.ItemsResizing, Sub(sender, e)
                For Each c As DevExpress.XtraDiagram.ResizingItem In e.Items
                    Dim maxWidth As Single = 0F
                    If TypeOf c.Item Is DevExpress.XtraDiagram.DiagramShape Then Call Single.TryParse(CType(c.Item, DevExpress.XtraDiagram.DiagramShape).Content, maxWidth)
                    Dim widthOver As Single = c.NewSize.Width - maxWidth
                    If widthOver <= 0F Then Continue For
                    c.NewSize = New System.Drawing.SizeF(maxWidth, c.NewSize.Height)
                    If e.Mode = DevExpress.Diagram.Core.ResizeMode.Left OrElse e.Mode = DevExpress.Diagram.Core.ResizeMode.TopLeft OrElse e.Mode = DevExpress.Diagram.Core.ResizeMode.BottomLeft Then c.NewDiagramPosition = New System.Drawing.PointF(c.NewDiagramPosition.X + widthOver, c.NewDiagramPosition.Y)
                Next
            End Sub
            Dim item As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 60, 75, 280, 150, "300") With {.CanRotate = False}
            item.Appearance.FontSizeDelta = 10
            diagramControl.Items.Add(item)
            diagramControl.OptionsBehavior.EnableProportionalResizing = False
            diagramControl.SelectItem(item)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("90-degree-only-rotatable item")>
        Public Sub NinetyDegreeOnlyRotatableItem(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl, ByVal restrictedPartMarker As DevExpress.XtraDiagram.DiagramShape)
            ' Each time the end-user tries to rotate a diagram item, the ItemsRotating event is raised.
            ' The following implementation sets the fixed 90-degree angle on which the end-user can rotate items.
            AddHandler diagramControl.ItemsRotating, Sub(sender, e)
                For Each c As DevExpress.XtraDiagram.RotatingItem In e.Items
                    c.NewAngle = CSng(System.Math.Round(c.NewAngle / 90F)) * 90F
                Next
            End Sub
            Dim item As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 100, 70, 200, 160) With {.CanResize = False}
            diagramControl.Items.Add(item)
            diagramControl.SelectItem(item)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Restricted part of the canvas")>
        Public Sub RestrictedPartOfTheCanvas(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl, ByVal restrictedPartMarker As DevExpress.XtraDiagram.DiagramShape)
            ' Each time the end-user tries to move a diagram item, the ItemsMoving event is raised.
            ' The following implementation prevents items from being moved in a certain area of the canvas.
            AddHandler diagramControl.ItemsMoving, Sub(sender, e)
                For Each c As DevExpress.XtraDiagram.MovingItem In e.Items
                    Dim x1 As Single = restrictedPartMarker.Bounds.Left - c.Item.Width
                    Dim x2 As Single = restrictedPartMarker.Bounds.Right
                    Dim y1 As Single = restrictedPartMarker.Bounds.Top - c.Item.Height
                    Dim y2 As Single = restrictedPartMarker.Bounds.Bottom
                    If c.NewDiagramPosition.X > x1 AndAlso c.NewDiagramPosition.X < x2 AndAlso c.NewDiagramPosition.Y > y1 AndAlso c.NewDiagramPosition.Y < y2 Then
                        Dim coercedX As Single = If(c.NewDiagramPosition.X - x1 < (x2 - x1) / 2F, x1, x2)
                        Dim coercedY As Single = If(c.NewDiagramPosition.Y - y1 < (y2 - y1) / 2F, y1, y2)
                        If System.Math.Abs(coercedX - c.NewDiagramPosition.X) < System.Math.Abs(coercedY - c.NewDiagramPosition.Y) Then
                            c.NewDiagramPosition = New System.Drawing.PointF(coercedX, c.NewDiagramPosition.Y)
                        Else
                            c.NewDiagramPosition = New System.Drawing.PointF(c.NewDiagramPosition.X, coercedY)
                        End If
                    End If
                Next
            End Sub
            diagramControl.Items.Add(restrictedPartMarker)
            Dim item As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 50, 100, 100, 100) With {.CanResize = False, .CanRotate = False}
            diagramControl.Items.Add(item)
            diagramControl.SelectItem(item)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Draw circle")>
        Public Sub DrawCircle(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl, ByVal restrictedPartMarker As DevExpress.XtraDiagram.DiagramShape)
            ' Each time the end-user tries to draw a diagram item, the ItemDrawing event is raised.
            ' The following implementation constrains the drawing tool to draw regular polygons (a circle in case of the Ellipse tool selected by default).            diagramControl.ItemDrawing += (sender, e) => {
            AddHandler diagramControl.ItemDrawing, Sub(sender, e)
                Dim width As Single = e.EndPosition.X - e.StartPosition.X
                Dim height As Single = e.EndPosition.Y - e.StartPosition.Y
                If System.Math.Abs(height) > System.Math.Abs(width) Then
                    e.EndPosition = New DevExpress.Utils.PointFloat(e.StartPosition.X + System.Math.Sign(width) * System.Math.Abs(height), e.EndPosition.Y)
                Else
                    e.EndPosition = New DevExpress.Utils.PointFloat(e.EndPosition.X, e.StartPosition.Y + System.Math.Sign(height) * System.Math.Abs(width))
                End If
            End Sub
            diagramControl.OptionsBehavior.ActiveTool = diagramControl.OptionsBehavior.EllipseTool
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Notifications", "EventsExamples.cs")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("DiagramShape", "DiagramConnector", "ItemsActionKind", "BasicShapes", "ResizingItem", "SizeF", "ResizeMode", "RotatingItem", "MovingItem", "Math", "PointF", "PointFloat", "MessageBox", "DiagramActionStage", "Orientation")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(161)>
    Public Module NotificationsExamples

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim label As DevExpress.XtraEditors.LabelControl = New DevExpress.XtraEditors.LabelControl()
            label.Parent = sampleHost
            label.Left = CInt((40 * DevExpress.Skins.DpiProvider.[Default].DpiScaleFactor))
            label.Top = CInt((40 * DevExpress.Skins.DpiProvider.[Default].DpiScaleFactor))
            label.Width = CInt((80 * DevExpress.Skins.DpiProvider.[Default].DpiScaleFactor))
            label.Appearance.FontSizeDelta = 10
            Dim diagram As DevExpress.XtraDiagram.DiagramControl = New DevExpress.XtraDiagram.DiagramControl()
            diagram.Parent = sampleHost
            diagram.Dock = System.Windows.Forms.DockStyle.Fill
            diagram.OptionsView.PageSize = New System.Drawing.SizeF(400, 300)
            diagram.FitToPage()
            sampleHost.Tag = sampleHost.BackColor
            sampleHost.BackColor = DevExpress.Skins.PrintingSkins.GetSkin(CType((diagram.LookAndFeel), DevExpress.Skins.ISkinProvider))(CStr((DevExpress.Skins.PrintingSkins.SkinBackgroundPreview))).Color.GetBackColor()
            AddHandler diagram.QueryItemsAction, Sub(sender, e)
                If e.Action <> DevExpress.Diagram.Core.ItemsActionKind.Resize AndAlso e.Items.Any(Function(x) TypeOf x.Tag Is System.Windows.Forms.Orientation) Then
                    e.Allow = False
                    Return
                End If

                If diagram.Items.Any(Function(x) TypeOf x.Tag Is System.Windows.Forms.Orientation) AndAlso e.Items.Any(Function(x) Not(TypeOf x.Tag Is System.Windows.Forms.Orientation)) Then e.Allow = False
            End Sub
            AddHandler diagram.QueryItemSnapping, Sub(sender, e)
                If diagram.Items.Any(Function(x) TypeOf x.Tag Is System.Windows.Forms.Orientation) Then e.Allow = False
            End Sub
            AddHandler diagram.ItemsResizing, Sub(sender, e)
                For Each c As DevExpress.XtraDiagram.ResizingItem In e.Items
                    If TypeOf c.Item.Tag Is System.Windows.Forms.Orientation AndAlso c.NewDiagramPosition <> c.OldDiagramPosition Then
                        c.NewSize = c.OldSize
                        c.NewDiagramPosition = c.OldDiagramPosition
                    ElseIf System.[Object].Equals(c.Item.Tag, System.Windows.Forms.Orientation.Vertical) Then
                        c.NewSize = New System.Drawing.SizeF(c.OldSize.Width, c.NewSize.Height)
                    ElseIf System.[Object].Equals(c.Item.Tag, System.Windows.Forms.Orientation.Horizontal) Then
                        c.NewSize = New System.Drawing.SizeF(c.NewSize.Width, c.OldSize.Height)
                    End If
                Next
            End Sub
            AddHandler diagram.CustomDrawItem, Sub(sender, e)
                If System.[Object].Equals(e.Item.Tag, System.Windows.Forms.Orientation.Horizontal) Then
                    e.Handled = True
                    e.GraphicsCache.FillRectangle(System.Drawing.Brushes.Black, 0, 0, e.Size.Width, 2)
                    For x As Single = 0F To e.Size.Width - 1 Step 10F
                        e.GraphicsCache.FillRectangle(System.Drawing.Brushes.Black, x, 0, 2, 8)
                    Next

                    For x As Single = 0F To e.Size.Width - 1 Step 20F
                        e.GraphicsCache.FillRectangle(System.Drawing.Brushes.Black, x, 0, 2, 12)
                    Next
                ElseIf System.[Object].Equals(e.Item.Tag, System.Windows.Forms.Orientation.Vertical) Then
                    e.Handled = True
                    e.GraphicsCache.FillRectangle(System.Drawing.Brushes.Black, 0, 0, 2, e.Size.Height)
                    For y As Single = 0F To e.Size.Height - 1 Step 10F
                        e.GraphicsCache.FillRectangle(System.Drawing.Brushes.Black, 0, y, 8, 2)
                    Next

                    For y As Single = 0F To e.Size.Height - 1 Step 20F
                        e.GraphicsCache.FillRectangle(System.Drawing.Brushes.Black, 0, y, 12, 2)
                    Next
                End If
            End Sub
            Return New Object() {diagram, label}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            For Each control As System.Windows.Forms.Control In sampleHost.Controls
                control.Dispose()
            Next

            sampleHost.BackColor = CType(sampleHost.Tag, System.Drawing.Color)
            sampleHost.Tag = Nothing
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Moving feedback and confirmation message")>
        Public Sub FeedbackAndConfirmationMessage(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl, ByVal labelControl As DevExpress.XtraEditors.LabelControl)
            ' Each time the end-user tries to move a diagram item, the ItemsMoving event is raised.
            ' The following implementation displays a label as the end-user is moving an item and invokes the confirmation dialog window prompting the user to confirm the action.
            AddHandler diagramControl.ItemsMoving, Sub(sender, e)
                Select Case e.Stage
                    Case DevExpress.Diagram.Core.DiagramActionStage.Start
                        labelControl.Text = "Moving..."
                    Case DevExpress.Diagram.Core.DiagramActionStage.Canceled
_Select0_CaseDevExpress_Diagram_Core_DiagramActionStage_Canceled:
                        labelControl.Text = ""
                    Case DevExpress.Diagram.Core.DiagramActionStage.Finished
                        If DevExpress.XtraEditors.XtraMessageBox.Show(diagramControl.FindForm(), "Confirm the moving action.", "Confirmation", System.Windows.Forms.MessageBoxButtons.OKCancel) <> System.Windows.Forms.DialogResult.OK Then e.Cancel = True
                        GoTo _Select0_CaseDevExpress_Diagram_Core_DiagramActionStage_Canceled
                End Select
            End Sub
            diagramControl.Items.Add(New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Ellipse, 30, 50, 120, 80))
            diagramControl.Items.Add(New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Hexagon, 30, 150, 120, 80))
            diagramControl.SelectAll()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Item bounds changed")>
        Public Sub ItemBoundsChanged(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl, ByVal labelControl As DevExpress.XtraEditors.LabelControl)
            ' Each time the end-user tries to modify the bounds a diagram item, the ItemsBoundsChanged event is raised.
            ' The following implementation allows the end-user to change the size of the ellipse by resizing the ruler items that are tagged by their orientation.
            Dim item As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Ellipse, 65, 65, 200, 160)
            AddHandler diagramControl.ItemBoundsChanged, Sub(sender, e)
                If System.[Object].Equals(e.Item.Tag, System.Windows.Forms.Orientation.Vertical) Then
                    item.Height = e.NewSize.Height
                    item.Y = e.NewPosition.Y
                ElseIf System.[Object].Equals(e.Item.Tag, System.Windows.Forms.Orientation.Horizontal) Then
                    item.Width = e.NewSize.Width
                    item.X = e.NewPosition.X
                End If
            End Sub
            Dim vRuler As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 25, 65, 20, 160) With {.Tag = System.Windows.Forms.Orientation.Vertical}
            Dim hRuler As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 65, 25, 200, 20) With {.Tag = System.Windows.Forms.Orientation.Horizontal}
            diagramControl.Items.Add(vRuler)
            diagramControl.Items.Add(hRuler)
            diagramControl.Items.Add(item)
            diagramControl.SelectItem(hRuler)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Expand container by dragging an item over it")>
        Public Sub ExpandContainerOnDragOver(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl, ByVal labelControl As DevExpress.XtraEditors.LabelControl)
            ' Each time the end-user tries to move a diagram item, the ItemsMoving event is raised.
            ' The following implementation expands a collapsed container when the end-user is dragging an item over it.
            Dim shape = New DevExpress.XtraDiagram.DiagramShape() With {.Position = New DevExpress.Utils.PointFloat(150, 130), .Width = 100, .Height = 80, .Content = "Drag me over the container"}
            Dim container = New DevExpress.XtraDiagram.DiagramContainer With {.Position = New DevExpress.Utils.PointFloat(100, 50), .Width = 200, .Height = 150, .ShowHeader = True, .Header = "Collapsed container", .CanCollapse = True, .IsCollapsed = True, .CanCopy = False, .CanMove = False}
            Dim containerCollapseState = False
            AddHandler diagramControl.ItemsMoving, Sub(s, e)
                If e.ActionSource <> DevExpress.Diagram.Core.ItemsActionSource.Mouse Then Return
                If e.Stage = DevExpress.Diagram.Core.DiagramActionStage.Start Then
                    containerCollapseState = container.IsCollapsed
                ElseIf e.Stage = DevExpress.Diagram.Core.DiagramActionStage.Canceled Then
                    container.IsCollapsed = containerCollapseState
                ElseIf containerCollapseState Then
                    Dim rotatedBounds = container.DiagramBounds()
                    Dim containerBounds = New System.Drawing.RectangleF(CSng(rotatedBounds.X), CSng(rotatedBounds.Y), CSng(rotatedBounds.Width), CSng(rotatedBounds.Height))
                    container.IsCollapsed = Not e.Items.Any(Function(x) containerBounds.IntersectsWith(New System.Drawing.RectangleF(x.NewDiagramPosition, x.Item.Size)))
                End If
            End Sub
            diagramControl.Items.Add(shape)
            diagramControl.Items.Add(container)
            diagramControl.SelectItem(shape)
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Connectors", "EventsExamples.cs")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("DiagramShape", "DiagramConnector", "ItemsActionKind", "BasicShapes", "ResizingItem", "SizeF", "ResizeMode", "RotatingItem", "MovingItem", "Math", "PointF", "PointFloat", "MessageBox", "DiagramActionStage", "Orientation", "DiagramThemeColorId")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(161)>
    Public Module ConnectorEventsExamples

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim diagram As DevExpress.XtraDiagram.DiagramControl = New DevExpress.XtraDiagram.DiagramControl()
            diagram.Parent = sampleHost
            diagram.Dock = System.Windows.Forms.DockStyle.Fill
            diagram.OptionsView.PageSize = New System.Drawing.SizeF(400, 300)
            diagram.FitToPage()
            diagram.OptionsBehavior.ConnectorTool = New DevExpress.Diagram.Core.FactoryConnectorTool("Example", Function() "Connector", Function(x) New DevExpress.XtraDiagram.DiagramConnector() With {.Type = DevExpress.Diagram.Core.ConnectorType.Curved, .BeginPointRestrictions = DevExpress.Diagram.Core.ConnectorPointRestrictions.KeepConnected, .EndPointRestrictions = DevExpress.Diagram.Core.ConnectorPointRestrictions.KeepConnected})
            AddHandler diagram.QueryItemsAction, Sub(sender, e)
                If e.Action = DevExpress.Diagram.Core.ItemsActionKind.Move Then e.Allow = False
            End Sub
            AddHandler diagram.QueryConnectionPoints, Sub(sender, e)
                If System.[Object].Equals(e.OppositeItem, e.HoveredItem) Then
                    e.ItemConnectionBorderState = DevExpress.Diagram.Core.ConnectionElementState.Hidden
                    For Each p As DevExpress.Diagram.Core.ConnectionPoint In e.ItemConnectionPointStates
                        p.State = DevExpress.Diagram.Core.ConnectionElementState.Hidden
                    Next
                End If
            End Sub
            AddHandler diagram.ItemsChanged, Sub(sender, e)
                If e.Action = DevExpress.Diagram.Core.ItemsChangedAction.Added AndAlso TypeOf e.Item Is DevExpress.XtraDiagram.DiagramConnector Then
                    CType(e.Item, DevExpress.XtraDiagram.DiagramConnector).CanChangeRoute = False
                    e.Item.Appearance.BorderSize = 2
                    e.Item.StrokeId = DevExpress.Diagram.Core.DiagramThemeColorId.Black_3
                End If
            End Sub
            Return New Object() {diagram}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            For Each control As System.Windows.Forms.Control In sampleHost.Controls
                control.Dispose()
            Next
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Categorized connectors")>
        Public Sub CategorizedConnectors(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl)
            ' Each time the end-user moves the cursor with the active Connector Tool near shapes or their connection points, the QueryConnectionPoints event is raised.
            ' The following implementation prevents the end-user from connecting items with different background colors.
            AddHandler diagramControl.QueryConnectionPoints, Sub(sender, e)
                If e.OppositeItem IsNot Nothing AndAlso e.OppositeItem.Appearance.BackColor <> e.HoveredItem.Appearance.BackColor Then
                    e.ItemConnectionBorderState = DevExpress.Diagram.Core.ConnectionElementState.Hidden
                    For Each p In e.ItemConnectionPointStates
                        p.State = DevExpress.Diagram.Core.ConnectionElementState.Hidden
                    Next
                End If
            End Sub
            Dim blueItem1 = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 50, 40, 120, 50)
            Dim blueItem2 = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 230, 120, 120, 50)
            Dim blueItem3 = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 50, 200, 120, 50)
            Dim redItem1 = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 230, 40, 120, 50)
            Dim redItem2 = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 50, 120, 120, 50)
            Dim redItem3 = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Rectangle, 230, 200, 120, 50)
            blueItem3.Appearance.BackColor = System.Drawing.Color.FromArgb(1, 115, 199)
            blueItem2.Appearance.BackColor = blueItem3.Appearance.BackColor
            blueItem1.Appearance.BackColor = blueItem2.Appearance.BackColor
            redItem3.Appearance.BackColor = System.Drawing.Color.FromArgb(199, 115, 1)
            redItem2.Appearance.BackColor = redItem3.Appearance.BackColor
            redItem1.Appearance.BackColor = redItem2.Appearance.BackColor
            diagramControl.Items.Add(blueItem1)
            diagramControl.Items.Add(blueItem2)
            diagramControl.Items.Add(blueItem3)
            diagramControl.Items.Add(redItem1)
            diagramControl.Items.Add(redItem2)
            diagramControl.Items.Add(redItem3)
            diagramControl.OptionsBehavior.ActiveTool = diagramControl.OptionsBehavior.ConnectorTool
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Confirmation message")>
        Public Sub ConfirmationMessage(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl)
            ' Each time the end-user tries to modify a connector, the ConnectionChanging event is raised.
            ' The following implementation invokes the confirmation dialog window prompting the user to confirm the action.
            AddHandler diagramControl.ConnectionChanging, Sub(sender, e)
                If DevExpress.XtraEditors.XtraMessageBox.Show(diagramControl.FindForm(), "Confirm the connection changing action.", "Confirmation", System.Windows.Forms.MessageBoxButtons.OKCancel) <> System.Windows.Forms.DialogResult.OK Then e.Cancel = True
            End Sub
            Dim item1 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Parallelogram, 150, 40, 120, 80)
            Dim item2 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Hexagon, 30, 200, 120, 80)
            Dim item3 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Ellipse, 250, 200, 120, 80)
            diagramControl.Items.Add(item1)
            diagramControl.Items.Add(item2)
            diagramControl.Items.Add(item3)
            Dim connector As DevExpress.XtraDiagram.DiagramConnector = New DevExpress.XtraDiagram.DiagramConnector() With {.BeginItem = item1, .EndItem = item3}
            diagramControl.Items.Add(connector)
            diagramControl.SelectItem(connector)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Connection changed")>
        Public Sub ConnectionChanged(ByVal diagramControl As DevExpress.XtraDiagram.DiagramControl)
            ' Each time the end-user tries to modify a connector, the ConnectionChanged event is raised.
            AddHandler diagramControl.ConnectionChanged, Sub(sender, e)
                Dim oldShape As DevExpress.XtraDiagram.DiagramShape = TryCast(e.OldItem, DevExpress.XtraDiagram.DiagramShape)
                If oldShape IsNot Nothing Then oldShape.BackgroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White_2
                Dim newShape As DevExpress.XtraDiagram.DiagramShape = TryCast(e.NewItem, DevExpress.XtraDiagram.DiagramShape)
                If newShape IsNot Nothing Then newShape.BackgroundId = DevExpress.Diagram.Core.DiagramThemeColorId.Black_3
            End Sub
            Dim item1 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Parallelogram, 150, 40, 120, 80) With {.BackgroundId = DevExpress.Diagram.Core.DiagramThemeColorId.Black_3}
            Dim item2 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Hexagon, 30, 200, 120, 80) With {.BackgroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White_2}
            Dim item3 As DevExpress.XtraDiagram.DiagramShape = New DevExpress.XtraDiagram.DiagramShape(DevExpress.Diagram.Core.BasicShapes.Ellipse, 250, 200, 120, 80) With {.BackgroundId = DevExpress.Diagram.Core.DiagramThemeColorId.Black_3}
            diagramControl.Items.Add(item1)
            diagramControl.Items.Add(item2)
            diagramControl.Items.Add(item3)
            Dim connector As DevExpress.XtraDiagram.DiagramConnector = New DevExpress.XtraDiagram.DiagramConnector() With {.BeginItem = item1, .EndItem = item3, .CanDragBeginPoint = False, .EndPointRestrictions = DevExpress.Diagram.Core.ConnectorPointRestrictions.KeepConnected}
            diagramControl.Items.Add(connector)
            diagramControl.SelectItem(connector)
        End Sub
    End Module
End Namespace
