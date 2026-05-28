using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Diagram.Core;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.Skins;
using DevExpress.XtraDiagram;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using DevExpress.Diagram.Core.Native;

namespace Examples {
    [CodeExampleClass("Prohibiting actions", "EventsExamples.cs")]
    [CodeExampleHighlightTokens("DiagramShape", "DiagramConnector", "ItemsActionKind", "BasicShapes")]
    [CodeExampleVersionID(161)]
    public static class ProhibitingActionsExamples {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            DiagramControl diagram = new DiagramControl();
            diagram.Parent = sampleHost;
            diagram.Dock = DockStyle.Fill;
            diagram.OptionsView.PageSize = new SizeF(400, 300);
            diagram.FitToPage();

            return new object[] { diagram };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
        }

        [CodeExampleCase("Prohibiting actions 1")]
        public static void ProhibitingActions1(DiagramControl diagramControl) {
            // Each time the end-user tries to perform an action on a diagram item, the QueryItemsAction event is raised.
            // The following implementation restricts certain actions based on the item's content.
            diagramControl.QueryItemsAction += (sender, e) => {
            switch(e.Action) {
                case ItemsActionKind.MoveCopy: goto case ItemsActionKind.Move;
                case ItemsActionKind.Move:
                    if(e.Items.OfType<DiagramShape>().Any(x => x.Content == "Non-movable"))
                        e.Allow = false;
                    break;
                case ItemsActionKind.Resize:
                    if(e.Items.OfType<DiagramShape>().Any(x => x.Content == "Non-resizable"))
                        e.Allow = false;
                    break;
                case ItemsActionKind.Rotate:
                    if(e.Items.OfType<DiagramShape>().Any(x => x.Content == "Non-rotatable"))
                        e.Allow = false;
                    break;
                }
            };

            diagramControl.Items.Add(new DiagramShape(BasicShapes.Ellipse, 20, 40, 120, 50, "Non-movable"));
            diagramControl.Items.Add(new DiagramShape(BasicShapes.Rectangle, 140, 120, 120, 50, "Non-resizable"));
            diagramControl.Items.Add(new DiagramShape(BasicShapes.Parallelogram, 260, 200, 120, 50, "Non-rotatable"));
        }

        [CodeExampleCase("Prohibiting actions 2")]
        public static void ProhibitingActions2(DiagramControl diagramControl) {
            // Each time the end-user tries to perform an action on a diagram item, the QueryItemsAction event is raised.
            // The following implementation restricts certain actions based on the item's content.
            diagramControl.QueryItemsAction += (sender, e) => {
                switch(e.Action) {
                case ItemsActionKind.MoveCopy: goto case ItemsActionKind.Copy;
                case ItemsActionKind.Copy:
                    if(e.Items.OfType<DiagramShape>().Any(x => x.Content == "Non-copyable"))
                        e.Allow = false;
                    break;
                case ItemsActionKind.Delete:
                    if(e.Items.OfType<DiagramShape>().Any(x => x.Content == "Non-deletable"))
                        e.Allow = false;
                    break;
                }
            };
            diagramControl.QueryItemEditAction += (sender, e) => {
                if(e.Item is DiagramShape && ((DiagramShape)e.Item).Content == "Non-editable")
                    e.Allow = false;
            };

            diagramControl.Items.Add(new DiagramShape(BasicShapes.Ellipse, 20, 40, 120, 50, "Non-copyable"));
            diagramControl.Items.Add(new DiagramShape(BasicShapes.Rectangle, 140, 120, 120, 50, "Non-deletable"));
            diagramControl.Items.Add(new DiagramShape(BasicShapes.Parallelogram, 260, 200, 120, 50, "Non-editable"));
        }
    }
    [CodeExampleClass("Constraining actions", "EventsExamples.cs")]
    [CodeExampleHighlightTokens("DiagramShape", "DiagramConnector", "ItemsActionKind", "BasicShapes", "ResizingItem", "SizeF", "ResizeMode", "RotatingItem", "MovingItem", "Math", "PointF", "PointFloat")]
    [CodeExampleVersionID(161)]
    public static class ConstrainingActionsExamples {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            DiagramControl diagram = new DiagramControl();
            diagram.Parent = sampleHost;
            diagram.Dock = DockStyle.Fill;
            diagram.OptionsView.PageSize = new SizeF(400, 300);
            diagram.FitToPage();

            DiagramShape marker = new DiagramShape(BasicShapes.Rectangle, 180, 50, 180, 200);
            marker.Appearance.BorderDashPattern = new DiagramDoubleCollection(new[] { 8.0, 8.0 });
            marker.Appearance.BorderColor = Color.FromArgb(200, 20, 20);
            marker.Appearance.BackColor = Color.Transparent;
            marker.Appearance.BorderSize = 3;
            marker.CanMove = marker.CanSelect = marker.CanResize = marker.CanRotate = false;

            return new object[] { diagram, marker };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
        }

        [CodeExampleCase("Max width")]
        public static void MaxWidth(DiagramControl diagramControl, DiagramShape restrictedPartMarker) {
            // Each time the end-user tries to resize a diagram item, the ItemsResizing event is raised.
            // The following implementation sets the maximum width based on the item's content.
            diagramControl.ItemsResizing += (sender, e) => {
            foreach(ResizingItem c in e.Items) {
                    float maxWidth = 0f;
                    if(c.Item is DiagramShape)
                        float.TryParse(((DiagramShape)c.Item).Content, out maxWidth);
                    float widthOver = c.NewSize.Width - maxWidth;
                    if(widthOver <= 0f) continue;

                    c.NewSize = new SizeF(maxWidth, c.NewSize.Height);
                    if(e.Mode == ResizeMode.Left || e.Mode == ResizeMode.TopLeft || e.Mode == ResizeMode.BottomLeft)
                        c.NewDiagramPosition = new PointF(c.NewDiagramPosition.X + widthOver, c.NewDiagramPosition.Y);
                }
            };

            DiagramShape item = new DiagramShape(BasicShapes.Rectangle, 60, 75, 280, 150, "300") { CanRotate = false };
            item.Appearance.FontSizeDelta = 10;
            diagramControl.Items.Add(item);
            diagramControl.OptionsBehavior.EnableProportionalResizing = false;
            diagramControl.SelectItem(item);
        }

        [CodeExampleCase("90-degree-only-rotatable item")]
        public static void NinetyDegreeOnlyRotatableItem(DiagramControl diagramControl, DiagramShape restrictedPartMarker) {
            // Each time the end-user tries to rotate a diagram item, the ItemsRotating event is raised.
            // The following implementation sets the fixed 90-degree angle on which the end-user can rotate items.
            diagramControl.ItemsRotating += (sender, e) => {
            foreach(RotatingItem c in e.Items)
                    c.NewAngle = (float)Math.Round(c.NewAngle / 90f) * 90f;
            };

            DiagramShape item = new DiagramShape(BasicShapes.Rectangle, 100, 70, 200, 160) { CanResize = false };
            diagramControl.Items.Add(item);
            diagramControl.SelectItem(item);
        }

        [CodeExampleCase("Restricted part of the canvas")]
        public static void RestrictedPartOfTheCanvas(DiagramControl diagramControl, DiagramShape restrictedPartMarker) {
            // Each time the end-user tries to move a diagram item, the ItemsMoving event is raised.
            // The following implementation prevents items from being moved in a certain area of the canvas.
            diagramControl.ItemsMoving += (sender, e) => {
            foreach(MovingItem c in e.Items) {
                    float x1 = restrictedPartMarker.Bounds.Left - c.Item.Width;
                    float x2 = restrictedPartMarker.Bounds.Right;
                    float y1 = restrictedPartMarker.Bounds.Top - c.Item.Height;
                    float y2 = restrictedPartMarker.Bounds.Bottom;
                    if(c.NewDiagramPosition.X > x1 && c.NewDiagramPosition.X < x2 && c.NewDiagramPosition.Y > y1 && c.NewDiagramPosition.Y < y2) {
                        float coercedX = c.NewDiagramPosition.X - x1 < (x2 - x1) / 2f ? x1 : x2;
                        float coercedY = c.NewDiagramPosition.Y - y1 < (y2 - y1) / 2f ? y1 : y2;
                        if(Math.Abs(coercedX - c.NewDiagramPosition.X) < Math.Abs(coercedY - c.NewDiagramPosition.Y))
                            c.NewDiagramPosition = new PointF(coercedX, c.NewDiagramPosition.Y);
                        else
                            c.NewDiagramPosition = new PointF(c.NewDiagramPosition.X, coercedY);
                    }
                }
            };

            diagramControl.Items.Add(restrictedPartMarker);
            DiagramShape item = new DiagramShape(BasicShapes.Rectangle, 50, 100, 100, 100) { CanResize = false, CanRotate = false };
            diagramControl.Items.Add(item);
            diagramControl.SelectItem(item);
        }

        [CodeExampleCase("Draw circle")]
        public static void DrawCircle(DiagramControl diagramControl, DiagramShape restrictedPartMarker) {
            // Each time the end-user tries to draw a diagram item, the ItemDrawing event is raised.
            // The following implementation constrains the drawing tool to draw regular polygons (a circle in case of the Ellipse tool selected by default).            diagramControl.ItemDrawing += (sender, e) => {
            diagramControl.ItemDrawing += (sender, e) => {
                float width = e.EndPosition.X - e.StartPosition.X;
                float height = e.EndPosition.Y - e.StartPosition.Y;
                if(Math.Abs(height) > Math.Abs(width))
                    e.EndPosition = new PointFloat(e.StartPosition.X + Math.Sign(width) * Math.Abs(height), e.EndPosition.Y);
                else
                    e.EndPosition = new PointFloat(e.EndPosition.X, e.StartPosition.Y + Math.Sign(height) * Math.Abs(width));
            };

            diagramControl.OptionsBehavior.ActiveTool = diagramControl.OptionsBehavior.EllipseTool;
        }
    }
    [CodeExampleClass("Notifications", "EventsExamples.cs")]
    [CodeExampleHighlightTokens("DiagramShape", "DiagramConnector", "ItemsActionKind", "BasicShapes", "ResizingItem", "SizeF", "ResizeMode", "RotatingItem", "MovingItem", "Math", "PointF", "PointFloat", "MessageBox", "DiagramActionStage", "Orientation")]
    [CodeExampleVersionID(161)]
    public static class NotificationsExamples {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            LabelControl label = new LabelControl();
            label.Parent = sampleHost;
            label.Left = (int)(40 * DpiProvider.Default.DpiScaleFactor);
            label.Top = (int)(40 * DpiProvider.Default.DpiScaleFactor);
            label.Width = (int)(80 * DpiProvider.Default.DpiScaleFactor);
            label.Appearance.FontSizeDelta = 10;

            DiagramControl diagram = new DiagramControl();
            diagram.Parent = sampleHost;
            diagram.Dock = DockStyle.Fill;
            diagram.OptionsView.PageSize = new SizeF(400, 300);
            diagram.FitToPage();

            sampleHost.Tag = sampleHost.BackColor;
            sampleHost.BackColor = PrintingSkins.GetSkin(diagram.LookAndFeel)[PrintingSkins.SkinBackgroundPreview].Color.GetBackColor();

            diagram.QueryItemsAction += (sender, e) => {
                if(e.Action != ItemsActionKind.Resize && e.Items.Any(x => x.Tag is Orientation)) {
                    e.Allow = false;
                    return;
                }
                if(diagram.Items.Any(x => x.Tag is Orientation) && e.Items.Any(x => !(x.Tag is Orientation)))
                    e.Allow = false;
            };
            diagram.QueryItemSnapping += (sender, e) => {
                if(diagram.Items.Any(x => x.Tag is Orientation))
                    e.Allow = false;
            };
            diagram.ItemsResizing += (sender, e) => {
                foreach(ResizingItem c in e.Items) {
                    if(c.Item.Tag is Orientation && c.NewDiagramPosition != c.OldDiagramPosition) {
                        c.NewSize = c.OldSize;
                        c.NewDiagramPosition = c.OldDiagramPosition;
                    } else if(Equals(c.Item.Tag, Orientation.Vertical)) {
                        c.NewSize = new SizeF(c.OldSize.Width, c.NewSize.Height);
                    } else if(Equals(c.Item.Tag, Orientation.Horizontal)) {
                        c.NewSize = new SizeF(c.NewSize.Width, c.OldSize.Height);
                    }
                }
            };
            diagram.CustomDrawItem += (sender, e) => {
                if(Equals(e.Item.Tag, Orientation.Horizontal)) {
                    e.Handled = true;
                    e.GraphicsCache.FillRectangle(Brushes.Black, 0, 0, e.Size.Width, 2);
                    for(float x = 0f; x < e.Size.Width; x += 10f)
                        e.GraphicsCache.FillRectangle(Brushes.Black, x, 0, 2, 8);
                    for(float x = 0f; x < e.Size.Width; x += 20f)
                        e.GraphicsCache.FillRectangle(Brushes.Black, x, 0, 2, 12);
                } else if(Equals(e.Item.Tag, Orientation.Vertical)) {
                    e.Handled = true;
                    e.GraphicsCache.FillRectangle(Brushes.Black, 0, 0, 2, e.Size.Height);
                    for(float y = 0f; y < e.Size.Height; y += 10f)
                        e.GraphicsCache.FillRectangle(Brushes.Black, 0, y, 8, 2);
                    for(float y = 0f; y < e.Size.Height; y += 20f)
                        e.GraphicsCache.FillRectangle(Brushes.Black, 0, y, 12, 2);
                }
            };

            return new object[] { diagram, label };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
            sampleHost.BackColor = (Color)sampleHost.Tag;
            sampleHost.Tag = null;
        }

        [CodeExampleCase("Moving feedback and confirmation message")]
        public static void FeedbackAndConfirmationMessage(DiagramControl diagramControl, LabelControl labelControl) {
            // Each time the end-user tries to move a diagram item, the ItemsMoving event is raised.
            // The following implementation displays a label as the end-user is moving an item and invokes the confirmation dialog window prompting the user to confirm the action.
            diagramControl.ItemsMoving += (sender, e) => {
            switch(e.Stage) {
                case DiagramActionStage.Start:
                    labelControl.Text = "Moving...";
                    break;
                case DiagramActionStage.Canceled:
                    labelControl.Text = "";
                    break;
                case DiagramActionStage.Finished:
                    if(XtraMessageBox.Show(diagramControl.FindForm(), "Confirm the moving action.", "Confirmation", MessageBoxButtons.OKCancel) != DialogResult.OK)
                        e.Cancel = true;
                    goto case DiagramActionStage.Canceled;
                }
            };

            diagramControl.Items.Add(new DiagramShape(BasicShapes.Ellipse, 30, 50, 120, 80));
            diagramControl.Items.Add(new DiagramShape(BasicShapes.Hexagon, 30, 150, 120, 80));
            diagramControl.SelectAll();
        }

        [CodeExampleCase("Item bounds changed")]
        public static void ItemBoundsChanged(DiagramControl diagramControl, LabelControl labelControl) {
            // Each time the end-user tries to modify the bounds a diagram item, the ItemsBoundsChanged event is raised.
            // The following implementation allows the end-user to change the size of the ellipse by resizing the ruler items that are tagged by their orientation.
            DiagramShape item = new DiagramShape(BasicShapes.Ellipse, 65, 65, 200, 160);

            diagramControl.ItemBoundsChanged += (sender, e) => {
                if(Equals(e.Item.Tag, Orientation.Vertical)) {
                    item.Height = e.NewSize.Height;
                    item.Y = e.NewPosition.Y;
                } else if(Equals(e.Item.Tag, Orientation.Horizontal)) {
                    item.Width = e.NewSize.Width;
                    item.X = e.NewPosition.X;
                }
            };

            DiagramShape vRuler = new DiagramShape(BasicShapes.Rectangle, 25, 65, 20, 160) { Tag = Orientation.Vertical };
            DiagramShape hRuler = new DiagramShape(BasicShapes.Rectangle, 65, 25, 200, 20) { Tag = Orientation.Horizontal };
            diagramControl.Items.Add(vRuler);
            diagramControl.Items.Add(hRuler);
            diagramControl.Items.Add(item);
            diagramControl.SelectItem(hRuler);
        }
        [CodeExampleCase("Expand container by dragging an item over it")]
        public static void ExpandContainerOnDragOver(DiagramControl diagramControl, LabelControl labelControl) {
            // Each time the end-user tries to move a diagram item, the ItemsMoving event is raised.
            // The following implementation expands a collapsed container when the end-user is dragging an item over it.

            var shape = new DiagramShape() { Position = new PointFloat(150, 130), Width = 100, Height = 80, Content = "Drag me over the container" };
            var container = new DiagramContainer {
                Position = new PointFloat(100, 50),
                Width = 200,
                Height = 150,
                ShowHeader = true,
                Header = "Collapsed container",
                CanCollapse = true,
                IsCollapsed = true, 
                CanCopy = false,
                CanMove = false,
            };
            var containerCollapseState = false;
            diagramControl.ItemsMoving += (s, e) => {
                if(e.ActionSource != ItemsActionSource.Mouse)
                    return;

                if(e.Stage == DiagramActionStage.Start)
                    containerCollapseState = container.IsCollapsed;
                else if(e.Stage == DiagramActionStage.Canceled)
                    container.IsCollapsed = containerCollapseState;
                else if(containerCollapseState) {
                    var rotatedBounds = container.DiagramBounds();
                    var containerBounds = new RectangleF((float)rotatedBounds.X, (float)rotatedBounds.Y, (float)rotatedBounds.Width, (float)rotatedBounds.Height);
                    container.IsCollapsed = !e.Items.Any(x => containerBounds.IntersectsWith(new RectangleF(x.NewDiagramPosition, x.Item.Size)));
                }
            };

            diagramControl.Items.Add(shape);
            diagramControl.Items.Add(container);
            diagramControl.SelectItem(shape);
        }
    }
    [CodeExampleClass("Connectors", "EventsExamples.cs")]
    [CodeExampleHighlightTokens("DiagramShape", "DiagramConnector", "ItemsActionKind", "BasicShapes", "ResizingItem", "SizeF", "ResizeMode", "RotatingItem", "MovingItem", "Math", "PointF", "PointFloat", "MessageBox", "DiagramActionStage", "Orientation", "DiagramThemeColorId")]
    [CodeExampleVersionID(161)]
    public static class ConnectorEventsExamples {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            DiagramControl diagram = new DiagramControl();
            diagram.Parent = sampleHost;
            diagram.Dock = DockStyle.Fill;
            diagram.OptionsView.PageSize = new SizeF(400, 300);
            diagram.FitToPage();

            diagram.OptionsBehavior.ConnectorTool = new FactoryConnectorTool("Example", () => "Connector", x => new DiagramConnector() { Type = ConnectorType.Curved, BeginPointRestrictions = ConnectorPointRestrictions.KeepConnected, EndPointRestrictions = ConnectorPointRestrictions.KeepConnected });
            diagram.QueryItemsAction += (sender, e) => {
                if(e.Action == ItemsActionKind.Move)
                    e.Allow = false;
            };
            diagram.QueryConnectionPoints += (sender, e) => {
                if(Equals(e.OppositeItem, e.HoveredItem)) {
                    e.ItemConnectionBorderState = ConnectionElementState.Hidden;
                    foreach(ConnectionPoint p in e.ItemConnectionPointStates)
                        p.State = ConnectionElementState.Hidden;
                }
            };
            diagram.ItemsChanged += (sender, e) => {
                if(e.Action == ItemsChangedAction.Added && e.Item is DiagramConnector) {
                    ((DiagramConnector)e.Item).CanChangeRoute = false;
                    e.Item.Appearance.BorderSize = 2;
                    e.Item.StrokeId = DiagramThemeColorId.Black_3;
                }
            };

            return new object[] { diagram };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
        }

        [CodeExampleCase("Categorized connectors")]
        public static void CategorizedConnectors(DiagramControl diagramControl) {
            // Each time the end-user moves the cursor with the active Connector Tool near shapes or their connection points, the QueryConnectionPoints event is raised.
            // The following implementation prevents the end-user from connecting items with different background colors.
            diagramControl.QueryConnectionPoints += (sender, e) => {
                if(e.OppositeItem != null && e.OppositeItem.Appearance.BackColor != e.HoveredItem.Appearance.BackColor) {
                    e.ItemConnectionBorderState = ConnectionElementState.Hidden;
                    foreach(var p in e.ItemConnectionPointStates)
                        p.State = ConnectionElementState.Hidden;
                }
            };

            var blueItem1 = new DiagramShape(BasicShapes.Rectangle, 50, 40, 120, 50);
            var blueItem2 = new DiagramShape(BasicShapes.Rectangle, 230, 120, 120, 50);
            var blueItem3 = new DiagramShape(BasicShapes.Rectangle, 50, 200, 120, 50);
            var redItem1 = new DiagramShape(BasicShapes.Rectangle, 230, 40, 120, 50);
            var redItem2 = new DiagramShape(BasicShapes.Rectangle, 50, 120, 120, 50);
            var redItem3 = new DiagramShape(BasicShapes.Rectangle, 230, 200, 120, 50);
            blueItem1.Appearance.BackColor = blueItem2.Appearance.BackColor = blueItem3.Appearance.BackColor = Color.FromArgb(1, 115, 199);
            redItem1.Appearance.BackColor = redItem2.Appearance.BackColor = redItem3.Appearance.BackColor = Color.FromArgb(199, 115, 1);
            diagramControl.Items.Add(blueItem1);
            diagramControl.Items.Add(blueItem2);
            diagramControl.Items.Add(blueItem3);
            diagramControl.Items.Add(redItem1);
            diagramControl.Items.Add(redItem2);
            diagramControl.Items.Add(redItem3);
            diagramControl.OptionsBehavior.ActiveTool = diagramControl.OptionsBehavior.ConnectorTool;
        }

        [CodeExampleCase("Confirmation message")]
        public static void ConfirmationMessage(DiagramControl diagramControl) {
            // Each time the end-user tries to modify a connector, the ConnectionChanging event is raised.
            // The following implementation invokes the confirmation dialog window prompting the user to confirm the action.
            diagramControl.ConnectionChanging += (sender, e) => {
                if(XtraMessageBox.Show(diagramControl.FindForm(), "Confirm the connection changing action.", "Confirmation", MessageBoxButtons.OKCancel) != DialogResult.OK)
                    e.Cancel = true;
            };

            DiagramShape item1 = new DiagramShape(BasicShapes.Parallelogram, 150, 40, 120, 80);
            DiagramShape item2 = new DiagramShape(BasicShapes.Hexagon, 30, 200, 120, 80);
            DiagramShape item3 = new DiagramShape(BasicShapes.Ellipse, 250, 200, 120, 80);
            diagramControl.Items.Add(item1);
            diagramControl.Items.Add(item2);
            diagramControl.Items.Add(item3);
            DiagramConnector connector = new DiagramConnector() { BeginItem = item1, EndItem = item3 };
            diagramControl.Items.Add(connector);
            diagramControl.SelectItem(connector);
        }

        [CodeExampleCase("Connection changed")]
        public static void ConnectionChanged(DiagramControl diagramControl) {
            // Each time the end-user tries to modify a connector, the ConnectionChanged event is raised.
            diagramControl.ConnectionChanged += (sender, e) => {
                DiagramShape oldShape = e.OldItem as DiagramShape;
                if(oldShape != null)
                    oldShape.BackgroundId = DiagramThemeColorId.White_2;
                DiagramShape newShape = e.NewItem as DiagramShape;
                if(newShape != null)
                    newShape.BackgroundId = DiagramThemeColorId.Black_3;
            };

            DiagramShape item1 = new DiagramShape(BasicShapes.Parallelogram, 150, 40, 120, 80) { BackgroundId = DiagramThemeColorId.Black_3 };
            DiagramShape item2 = new DiagramShape(BasicShapes.Hexagon, 30, 200, 120, 80) { BackgroundId = DiagramThemeColorId.White_2 };
            DiagramShape item3 = new DiagramShape(BasicShapes.Ellipse, 250, 200, 120, 80) { BackgroundId = DiagramThemeColorId.Black_3 };
            diagramControl.Items.Add(item1);
            diagramControl.Items.Add(item2);
            diagramControl.Items.Add(item3);
            DiagramConnector connector = new DiagramConnector() { BeginItem = item1, EndItem = item3, CanDragBeginPoint = false, EndPointRestrictions = ConnectorPointRestrictions.KeepConnected };
            diagramControl.Items.Add(connector);
            diagramControl.SelectItem(connector);
        }
    }
}
