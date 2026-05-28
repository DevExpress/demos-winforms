using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Diagram.Core;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraDiagram;
using DevExpress.XtraDiagram.Designer;
using DevExpress.XtraDiagram.Utils;
using DevExpress.XtraEditors;

namespace Examples {
    [CodeExampleVersionID(161)]
    [CodeExampleHighlightTokens("ArrowDescriptions", "DiagramShape", "DiagramConnector", "Color", "Font", "BasicShapes", "DiagramShape")]
    [CodeExampleClass("Appearance", "GenericExamples.cs")]
    public static class Appearance {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            DiagramControl diagram = new DiagramControl();
            diagram.Parent = sampleHost;
            diagram.Dock = DockStyle.Fill;
            diagram.OptionsView.PageSize = new SizeF(600, 400);
            diagram.FitToPage();

            return new object[] { diagram };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
        }

        [CodeExampleCase("Diagram appearance")]
        public static void CustomizeDiagramAppearance(DiagramControl diagramControl) {
            DiagramShape diagramItem1 = new DiagramShape(BasicShapes.Rectangle, 10, 10, 200, 100);
            diagramItem1.Content = "Text";
            diagramControl.Appearance.Shape.Font = new Font("Times New Roman", 40);
            diagramControl.Appearance.Shape.BackColor = Color.Yellow;
            diagramControl.Appearance.Shape.ForeColor = Color.Red;
            diagramControl.Appearance.Shape.BorderColor = Color.Orange;
            diagramControl.Appearance.Shape.BorderSize = 5;

            diagramControl.Items.Add(diagramItem1);
            diagramControl.Items.Add(new DiagramShape(BasicShapes.Rectangle, 10, 150, 200, 100));
        }

        [CodeExampleCase("Change shape appearance")]
        public static void ChangeShapeAppearance(DiagramControl diagramControl) {
            diagramControl.Appearance.Shape.Font = new Font("Times New Roman", 40);
            diagramControl.Appearance.Shape.ForeColor = Color.Yellow;

            DiagramShape diagramShape1 = new DiagramShape(BasicShapes.Rectangle, 10, 150, 200, 100);
            DiagramShape diagramShape2 = new DiagramShape(BasicShapes.Rectangle, 250, 10, 200, 100);

            diagramShape1.Content = "Text1";
            diagramShape2.Content = "Text2";

            diagramShape1.Appearance.BackColor = Color.Green;
            diagramShape1.Appearance.BorderColor = Color.Orange;
            diagramShape2.Appearance.BorderColor = diagramShape1.Appearance.GetBackColor();
            diagramShape1.Appearance.BorderSize = 5;
            diagramShape2.Appearance.BorderSize = 12;
            diagramShape2.Appearance.Font = new Font("Times New Roman", 20);

            diagramControl.Items.AddRange(diagramShape1, diagramShape2);
        }

        [CodeExampleCase("Change connector appearance")]
        public static void ChangeConnectorAppearance(DiagramControl diagramControl) {
            diagramControl.Appearance.Connector.ForeColor = Color.Red;

            DiagramShape diagramShape1 = new DiagramShape(BasicShapes.Rectangle, 50, 50, 50, 50);
            DiagramShape diagramShape2 = new DiagramShape(BasicShapes.Rectangle, 50, 150, 50, 50);
            DiagramShape diagramShape3 = new DiagramShape(BasicShapes.Rectangle, 300, 50, 50, 50);
            DiagramShape diagramShape4 = new DiagramShape(BasicShapes.Rectangle, 300, 150, 50, 50);

            DiagramConnector connector1 = new DiagramConnector(diagramShape1, diagramShape3);
            connector1.Content = "Text1";
            connector1.Appearance.ForeColor = Color.Blue;
            connector1.EndArrow = ArrowDescriptions.Open90;

            DiagramConnector connector2 = new DiagramConnector(diagramShape2, diagramShape4);
            connector2.Content = "Text2";
            connector2.Appearance.ContentBackground = Color.Yellow;
            connector2.EndArrow = ArrowDescriptions.Open90;

            diagramControl.Items.AddRange(diagramShape1, diagramShape2, diagramShape3, diagramShape4, connector1, connector2);
        }
        [CodeExampleCase("Custom Item Drawing")]
        public static void CustomDraw(DiagramControl diagramControl) {
            DiagramShape shape = new DiagramShape(BasicShapes.Rectangle, 50, 50, 100, 75);
            shape.Content = "Rectangle with shadow";

            diagramControl.CustomDrawItem += (s, e) => {
                if(e.Context == DiagramDrawingContext.Canvas || e.Context == DiagramDrawingContext.DragPreview) {
                    var foreColor = e.Appearance.ForeColor;
                    e.DefaultDraw(CustomDrawItemMode.Background);

                    var transform = e.GraphicsCache.GetTransform();
                    transform.Translate(1, 1);
                    e.GraphicsCache.SetTransform(transform);
                    e.Appearance.ForeColor = Color.DarkGray;
                    e.DefaultDraw(CustomDrawItemMode.Content);

                    transform.Translate(-1, -1);
                    e.GraphicsCache.SetTransform(transform);
                    e.Appearance.ForeColor = foreColor;
                    e.DefaultDraw(CustomDrawItemMode.Content);

                    e.Handled = true;
                }
            };

            diagramControl.Items.Add(shape);
            diagramControl.FitToItems(new[] { shape });
        }
    }

    [CodeExampleVersionID(161)]
    [CodeExampleHighlightTokens("DiagramShape", "BasicShapes", "List", "ShapeDescription", "DiagramToolboxRegistrator", "Rectangle", "Timer",
        "BasicFlowchartShapes", "ArrowShapes", "DecorativeShapes, DiagramStencil")]
    [CodeExampleClass("Create diagrams", "GenericExamples.cs")]
    public static class CreateDiagrams {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            DiagramControl diagram = new DiagramControl();
            diagram.Parent = sampleHost;
            diagram.Dock = DockStyle.Fill;
            diagram.OptionsView.PageSize = new SizeF(600, 400);
            diagram.FitToPage();

            SimpleButton hostButton = new SimpleButton();
            PanelControl panel = new PanelControl();
            panel.Dock = DockStyle.Top;
            hostButton.Parent = panel;
            hostButton.Width = (int)(80 * DevExpress.Skins.DpiProvider.Default.DpiScaleFactor);
            panel.Height = (int)(30 * DevExpress.Skins.DpiProvider.Default.DpiScaleFactor);
            hostButton.Dock = DockStyle.Left;

            diagram.Appearance.Shape.ForeColor = Color.Black;
            return new object[] { diagram, panel, sampleHost };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
        }
        [CodeExampleCase("Add diagram item")]
        public static void AddDiagramItem(DiagramControl diagramControl, PanelControl panel, XtraUserControl sampleHost) {
            DiagramShape diagramItem = new DiagramShape(BasicShapes.Rectangle, 50, 10, 200, 100);
            diagramControl.Items.Add(diagramItem);
        }


        [CodeExampleCase("Create various shapes")]
        public static void CreateVariousShapes(DiagramControl diagramControl, PanelControl panel, XtraUserControl sampleHost) {
            diagramControl.Items.Add(new DiagramShape(BasicFlowchartShapes.Subprocess, new Rectangle(50, 50, 150, 100)));
            diagramControl.Items.Add(new DiagramShape(BasicShapes.Decagon, new Rectangle(250, 50, 150, 100)));
            diagramControl.Items.Add(new DiagramShape(ArrowShapes.CurvedLeftArrow, new Rectangle(50, 170, 150, 100)));
            diagramControl.Items.Add(new DiagramShape(DecorativeShapes.Cloud, new Rectangle(250, 170, 150, 100)));
        }

        [CodeExampleCase("Show all shapes")]
        public static void ShowVariousShapes(DiagramControl diagramControl, PanelControl panel, XtraUserControl sampleHost) {
            List<ShapeDescription> descriptions = new List<ShapeDescription>();
            foreach(DiagramStencil a in DiagramToolboxRegistrator.Stencils) {
                descriptions.AddRange(a.Shapes.ToList());
            };
            ShapeDescription description = descriptions.First();

            DiagramShape shape = new DiagramShape(BasicShapes.Rectangle, new Rectangle(200, 100, 200, 150));
            diagramControl.Items.Add(shape);

            Timer myTimer = new Timer();
            myTimer.Tick += (sender, e) => {
                if(diagramControl.Page == null) {
                    myTimer.Stop();
                    return;
                }
                shape.Shape = description;
                shape.Content = description.Id;
                int index = descriptions.IndexOf(description) + 1;
                if(index == descriptions.Count)
                    index = 0;
                description = descriptions[index];
            };
            myTimer.Interval = 500;
            myTimer.Start();
        }

        [CodeExampleUnderlineTokens("DeleteSelectedItems")]
        [CodeExampleCase("Delete selected items")]
        public static void DeleteSelectedItems(DiagramControl diagramControl, PanelControl panel, XtraUserControl sampleHost) {
            DiagramShape diagramItem1 = new DiagramShape(BasicShapes.Rectangle, 50, 50, 50, 50);
            DiagramShape diagramItem2 = new DiagramShape(BasicShapes.Rectangle, 50, 150, 50, 50);
            DiagramShape diagramItem3 = new DiagramShape(BasicShapes.Rectangle, 150, 50, 50, 50);
            DiagramShape diagramItem4 = new DiagramShape(BasicShapes.Rectangle, 150, 150, 50, 50);
            diagramControl.Items.AddRange(diagramItem1, diagramItem2, diagramItem3, diagramItem4);

            panel.Parent = diagramControl.Parent;
            SimpleButton button = panel.Controls[0] as SimpleButton;
            button.Text = "Delete";

            button.Click += (sender, e) => {
                diagramControl.DeleteSelectedItems();
            };
        }
    }

    [CodeExampleHighlightTokens("Size", "DiagramShape")]
    [CodeExampleVersionID(161)]
    [CodeExampleClass("Customize diagram items", "GenericExamples.cs")]
    public static class CustomizeDiagramItems {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            DiagramControl diagram = new DiagramControl();
            diagram.Parent = sampleHost;
            diagram.Dock = DockStyle.Fill;
            diagram.OptionsView.PageSize = new SizeF(600, 400);
            diagram.FitToPage();

            DiagramShape diagramItem = new DiagramShape(BasicShapes.Rectangle, 100, 100, 200, 100);
            diagram.Items.Add(diagramItem);
            return new object[] { diagram };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
        }

        [CodeExampleCase("Resize diagram item")]
        public static void ResizeDiagramItem(DiagramControl diagramControl) {
            diagramControl.Items[0].Size = new System.Drawing.Size(50, 100);
        }

        [CodeExampleCase("Show text in diagram item")]
        public static void ShowDiagramItemText(DiagramControl diagramControl) {
            (diagramControl.Items[0] as DiagramShape).Content = "Text";
        }

        [CodeExampleCase("Customize item properties")]
        public static void CustomizeProperties(DiagramControl diagramControl) {
            diagramControl.Items[0].CanDelete = false;
            diagramControl.Items[0].CanMove = false;
            diagramControl.Items[0].CanCopy = false;
            diagramControl.Items[0].CanRotate = false;
        }

        [CodeExampleCase("Rotate item")]
        public static void RotateItem(DiagramControl diagramControl) {
            diagramControl.Items[0].Angle = 30;
        }
    }

    [CodeExampleClass("Diagram connectors", "GenericExamples.cs")]
    [CodeExampleHighlightTokens("DiagramShape", "DiagramConnector", "Point", "ArrowDescriptions", "BasicShapes", "SizeF", "Timer", "Math")]
    [CodeExampleVersionID(161)]
    public static class DiagramConnectors {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            DiagramControl diagram = new DiagramControl();
            diagram.Parent = sampleHost;
            diagram.Dock = DockStyle.Fill;
            diagram.OptionsView.PageSize = new SizeF(600, 400);
            diagram.FitToPage();

            return new object[] { diagram };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
        }

        [CodeExampleCase("Create diagram connector")]
        public static void CreateDiagramConnector(DiagramControl diagramControl) {
            DiagramConnector connector = new DiagramConnector(new Point(50, 50), new Point(200, 200), new Point(50, 200));
            connector.EndArrow = ArrowDescriptions.Filled90;
            diagramControl.Items.Add(connector);
        }

        [CodeExampleCase("Arrow Styles")]
        public static void CustomizeArrowStyle(DiagramControl diagramControl) {
            DiagramConnector connector1 = new DiagramConnector(new Point(50, 50), new Point(300, 50));
            connector1.EndArrow = ArrowDescriptions.Diamond;
            DiagramConnector connector2 = new DiagramConnector(new Point(50, 100), new Point(300, 100));
            connector2.EndArrow = ArrowDescriptions.Filled90;
            DiagramConnector connector3 = new DiagramConnector(new Point(50, 150), new Point(300, 150));
            connector3.EndArrow = ArrowDescriptions.Open90;
            DiagramConnector connector4 = new DiagramConnector(new Point(50, 200), new Point(300, 200));
            connector4.EndArrow = ArrowDescriptions.FilledFletch;
            diagramControl.Items.AddRange(connector1, connector2, connector3, connector4);
            //Various styles:
            //ClosedASMEArrow, ClosedDiamond, ClosedDot, ClosedDoubleArrow, Diamond, Filled90, FilledDiamond, FilledDot, FilledDoubleArrow, FilledFletch
            //FilledSquare, IndentedFilledArrow, Open90, OpenFletch, OutdentedFilledArrow
        }

        [CodeExampleCase("Show all arrow Styles")]
        public static void ShowArrowStyles(DiagramControl diagramControl) {
            DiagramShape diagramItem1 = new DiagramShape(BasicShapes.Rectangle, 100, 100, 100, 100);
            DiagramShape diagramItem2 = new DiagramShape(BasicShapes.Rectangle, 400, 100, 100, 100);
            DiagramConnector connector1 = new DiagramConnector(diagramItem1, diagramItem2);
            connector1.EndArrowSize = new SizeF(20, 20);
            diagramControl.Items.AddRange(diagramItem1, diagramItem2, connector1);

            int index = 0;

            Timer myTimer = new Timer();
            myTimer.Tick += (sender, e) => {
                if(diagramControl.Page == null) {
                    myTimer.Stop();
                    return;
                }
                connector1.EndArrow = ArrowDescriptions.Arrows.ElementAt(index);
                connector1.Content = ArrowDescriptions.Arrows.ElementAt(index).Id;
                index += 1;
                if(index == ArrowDescriptions.Arrows.Count())
                    index = 0;
            };
            myTimer.Interval = 700;
            myTimer.Start();
        }


        [CodeExampleCase("Resize arrow")]
        public static void ChangeArrowSize(DiagramControl diagramControl) {
            DiagramConnector connector = new DiagramConnector(new Point(50, 50), new Point(200, 200), new Point(50, 200));
            connector.EndArrow = ArrowDescriptions.Filled90;
            connector.EndArrowSize = new SizeF(30, 20);
            diagramControl.Items.Add(connector);
        }

        [CodeExampleCase("Connect diagram items")]
        public static void ConnectDiagramItems(DiagramControl diagramControl) {
            DiagramShape diagramItem1 = new DiagramShape(BasicShapes.Rectangle, 10, 10, 200, 100);
            DiagramShape diagramItem2 = new DiagramShape(BasicShapes.Rectangle, 10, 200, 200, 100);
            DiagramConnector connector1 = new DiagramConnector(diagramItem1, diagramItem2);
            connector1.EndArrow = ArrowDescriptions.Filled90;
            DiagramShape diagramItem3 = new DiagramShape(BasicShapes.Rectangle, 250, 10, 200, 100);
            DiagramShape diagramItem4 = new DiagramShape(BasicShapes.Rectangle, 400, 200, 200, 100);
            DiagramConnector connector2 = new DiagramConnector(diagramItem3, diagramItem4, new Point(350, 250));
            connector2.EndArrow = ArrowDescriptions.Filled90;
            diagramControl.Items.AddRange(diagramItem1, diagramItem2, diagramItem3, diagramItem4, connector1, connector2);
        }

        [CodeExampleCase("Connect two items")]
        public static void ConnectTwoItems(DiagramControl diagramControl) {
            double a = Math.PI / 2;
            var rad = 100;
            DiagramShape diagramItem1 = new DiagramShape(BasicShapes.Rectangle, 200, 100, 50, 50);
            DiagramShape diagramItem2 = new DiagramShape(BasicShapes.Rectangle, 200, 200, 50, 50);
            diagramControl.Items.AddRange(diagramItem1, diagramItem2, new DiagramConnector(diagramItem1, diagramItem2));

            Timer myTimer = new Timer();
            myTimer.Tick += (sender, e) => {
                if(diagramControl.Page == null) {
                    myTimer.Stop();
                    return;
                }
                a += Math.PI / 10;
                diagramItem2.X = diagramItem1.X + (int)(rad * Math.Cos(a));
                diagramItem2.Y = diagramItem1.Y + (int)(rad * Math.Sin(a));
                myTimer.Enabled = true;
                diagramControl.UpdateRoute();
            };
            myTimer.Interval = 250;
            myTimer.Start();
        }

        [CodeExampleCase("Customize connector properties")]
        public static void CustomizeConnectorProperties(DiagramControl diagramControl) {
            DiagramConnector connector = new DiagramConnector(new Point(50, 50), new Point(200, 200), new Point(50, 200));
            connector.EndArrow = ArrowDescriptions.Filled90;
            connector.CanCopy = false;
            connector.CanDelete = false;
            diagramControl.Items.Add(connector);
        }

        [CodeExampleCase("Show text in diagram connector")]
        public static void ShowTextInDiagramConnector(DiagramControl diagramControl) {
            DiagramConnector connector = new DiagramConnector(new Point(50, 50), new Point(200, 200));
            connector.EndArrow = ArrowDescriptions.Filled90;
            connector.Content = "Text";
            diagramControl.Items.Add(connector);
        }
    }

    [CodeExampleClass("Diagram properties", "GenericExamples.cs")]
    [CodeExampleHighlightTokens("SizeF", "DiagramDesignerUtils", "DiagramDesignerForm", "FormWindowState", "DiagramDesignerUtils")]
    [CodeExampleVersionID(161)]
    public static class DiagramProperties {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            DiagramControl diagram = new DiagramControl();
            diagram.Parent = sampleHost;
            diagram.Dock = DockStyle.Fill;
            diagram.OptionsView.PageSize = new SizeF(600, 400);
            diagram.FitToPage();

            SimpleButton hostButton = new SimpleButton();
            SimpleButton hostButton1 = new SimpleButton();
            PanelControl panel = new PanelControl();
            panel.Dock = DockStyle.Top;
            hostButton.Parent = panel;
            hostButton1.Parent = panel;
            hostButton1.Width = (int)(80 * DevExpress.Skins.DpiProvider.Default.DpiScaleFactor);
            hostButton.Width = (int)(80 * DevExpress.Skins.DpiProvider.Default.DpiScaleFactor);
            panel.Height = (int)(30 * DevExpress.Skins.DpiProvider.Default.DpiScaleFactor);
            hostButton.Dock = DockStyle.Left;
            hostButton1.Dock = DockStyle.Left;

            DiagramShape diagramItem1 = new DiagramShape(BasicShapes.Rectangle, 200, 120, 50, 50);
            DiagramShape diagramItem2 = new DiagramShape(BasicShapes.Rectangle, 270, 120, 50, 50);
            DiagramShape diagramItem3 = new DiagramShape(BasicShapes.Rectangle, 200, 190, 50, 50);
            DiagramShape diagramItem4 = new DiagramShape(BasicShapes.Rectangle, 270, 190, 50, 50);
            diagram.Items.AddRange(diagramItem1, diagramItem2, diagramItem3, diagramItem4);
            return new object[] { diagram, panel, sampleHost };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
        }

        [CodeExampleCase("Page size")]
        public static void PageSize(DiagramControl diagramControl, PanelControl panel, XtraUserControl sampleHost) {
            diagramControl.OptionsView.PageSize = new SizeF(550, 400);
            diagramControl.FitToPage();
        }

        [CodeExampleCase("Grid size")]
        public static void GridSize(DiagramControl diagramControl, PanelControl panel, XtraUserControl sampleHost) {
            diagramControl.OptionsView.GridSize = new SizeF(50, 50);
        }

        [CodeExampleCase("Draw Grid and Rulers")]
        public static void DrawGridAndRulers(DiagramControl diagramControl, PanelControl panel, XtraUserControl sampleHost) {
            diagramControl.OptionsView.ShowGrid = false;
            diagramControl.OptionsView.ShowRulers = false;
        }

        [CodeExampleCase("Zooming")]
        public static void Zooming(DiagramControl diagramControl, PanelControl panel, XtraUserControl sampleHost) {
            panel.Parent = diagramControl.Parent;
            SimpleButton button1 = panel.Controls[0] as SimpleButton;
            SimpleButton button2 = panel.Controls[1] as SimpleButton;
            button1.Text = "Zoom In";
            button2.Text = "Zoom Out";

            button1.Click += (sender, e) => {
                diagramControl.OptionsView.ZoomFactor += 0.1f;
            };

            button2.Click += (sender, e) => {
                diagramControl.OptionsView.ZoomFactor -= 0.1f;
            };
        }

        [CodeExampleUnderlineTokens("Clear")]
        [CodeExampleCase("Clear diagram contents")]
        public static void ClearDiagramContents(DiagramControl diagramControl, PanelControl panel, XtraUserControl sampleHost) {
            panel.Parent = diagramControl.Parent;
            SimpleButton button = panel.Controls[0] as SimpleButton;
            button.Text = "Clear";
            button.Click += (sender, e) => {
                diagramControl.Items.Clear();
            };
            panel.Controls[1].Dispose();
        }

        [CodeExampleUnderlineTokens("RunDesigner")]
        [CodeExampleCase("Design diagram")]
        public static void DesignDiagram(DiagramControl diagramControl, PanelControl panel, XtraUserControl sampleHost) {
            panel.Parent = diagramControl.Parent;
            SimpleButton button = panel.Controls[0] as SimpleButton;
            button.Text = "Design";
            button.Click += (sender, e) => {
                var designerForm = new DiagramDesignerForm() { ShowInTaskbar = false, WindowState = FormWindowState.Maximized };
                DiagramDesignerUtils.RunDesigner(diagramControl, designerForm);
            };
            panel.Controls[1].Dispose();
        }

        [CodeExampleCase("Select items")]
        public static void SelectItems(DiagramControl diagramControl, PanelControl panel, XtraUserControl sampleHost) {
            diagramControl.SelectItems(diagramControl.Items[0], diagramControl.Items[1], diagramControl.Items[2], diagramControl.Items[3]);
        }

        [CodeExampleUnderlineTokens("CopySelectedItems", "Paste")]
        [CodeExampleCase("Copy and Paste")]
        public static void CopyPaste(DiagramControl diagramControl, PanelControl panel, XtraUserControl sampleHost) {
            panel.Parent = diagramControl.Parent;
            SimpleButton button1 = panel.Controls[0] as SimpleButton;
            SimpleButton button2 = panel.Controls[1] as SimpleButton;
            button1.Text = "Copy";
            button2.Text = "Paste";

            button1.Click += (sender, e) => {
                diagramControl.CopySelectedItems();
            };

            button2.Click += (sender, e) => {
                diagramControl.Paste();
            };
        }
    }

    [CodeExampleVersionID(161)]
    [CodeExampleHighlightTokens("SimpleButton", "SeekOrigin", "MemoryStream")]
    [CodeExampleClass("Save and load documents", "GenericExamples.cs")]
    public static class SaveLoadDocument {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            DiagramControl diagram = new DiagramControl();
            diagram.Parent = sampleHost;
            diagram.Dock = DockStyle.Fill;
            diagram.OptionsView.PageSize = new SizeF(600, 400);
            diagram.FitToPage();

            SimpleButton hostButton = new SimpleButton();
            SimpleButton hostButton1 = new SimpleButton();
            PanelControl panel = new PanelControl();
            panel.Dock = DockStyle.Top;
            hostButton.Parent = panel;
            hostButton1.Parent = panel;
            hostButton1.Width = (int)(80 * DevExpress.Skins.DpiProvider.Default.DpiScaleFactor);
            hostButton.Width = (int)(80 * DevExpress.Skins.DpiProvider.Default.DpiScaleFactor);
            panel.Height = (int)(30 * DevExpress.Skins.DpiProvider.Default.DpiScaleFactor);
            hostButton.Dock = DockStyle.Left;
            hostButton1.Dock = DockStyle.Left;
            panel.Parent = sampleHost;

            DiagramShape diagramItem1 = new DiagramShape(BasicShapes.Rectangle, 50, 50, 50, 50);
            var num = 1;

            for(int i = 0; i < 3; i++) {
                for(int j = 0; j < 3; j++) {
                    diagramItem1.Content = String.Format("Item {0}", num++);
                    diagram.Items.Add(diagramItem1);
                    diagramItem1 = new DiagramShape(BasicShapes.Rectangle, diagramItem1.X + diagramItem1.Width + 20, diagramItem1.Y, 50, 50);
                }
                diagramItem1 = new DiagramShape(BasicShapes.Rectangle, 50, diagramItem1.Y + diagramItem1.Height + 20, 50, 50);
            }
            diagram.FitToDrawing();
            return new object[] { diagram, panel };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
        }

        [CodeExampleUnderlineTokens("SaveDocument", "LoadDocument")]
        [CodeExampleCase("Save and restore diagram to/from stream")]
        public static void SaveRestoreDiagramFromStream(DiagramControl diagramControl, PanelControl panel) {
            SimpleButton button1 = panel.Controls[0] as SimpleButton;
            SimpleButton button2 = panel.Controls[1] as SimpleButton;
            button1.Text = "Save";
            button2.Text = "Restore";
            MemoryStream memoryStream = new MemoryStream();
            diagramControl.SaveDocument(memoryStream);
            button1.Click += (sender, e) => {
                memoryStream.Dispose();
                memoryStream = new MemoryStream();
                diagramControl.SaveDocument(memoryStream);
            };
            button2.Click += (sender, e) => {
                memoryStream.Seek(0, SeekOrigin.Begin);
                diagramControl.LoadDocument(memoryStream);
            };
        }

        [CodeExampleUnderlineTokens("SaveFile", "OpenFile")]
        [CodeExampleCase("Save and restore diagram to/from file")]
        public static void SaveRestoreDiagramInFile(DiagramControl diagramControl, PanelControl panel) {
            SimpleButton button1 = panel.Controls[0] as SimpleButton;
            SimpleButton button2 = panel.Controls[1] as SimpleButton;
            button1.Text = "Save File";
            button2.Text = "Load File";
            button1.Click += (sender, e) => {
                diagramControl.SaveFile();
            };

            button2.Click += (sender, e) => {
                diagramControl.OpenFile();
            };
        }
    }

    [CodeExampleClass("Themes", "GenericExamples.cs")]
    [CodeExampleHighlightTokens("DiagramThemes", "DiagramShapeStyleId", "ThemeRegistrator", "Timer", "DiagramConnectorStyleId", "DiagramShapeStyleId", "DiagramConnector", "DiagramShape")]
    [CodeExampleVersionID(161)]
    public static class Themes {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            DiagramControl diagram = new DiagramControl();
            diagram.Parent = sampleHost;
            diagram.Dock = DockStyle.Fill;
            diagram.OptionsView.PageSize = new SizeF(600, 400);
            diagram.FitToPage();

            DiagramShape diagramItem1 = new DiagramShape(BasicShapes.Rectangle, 100, 100, 100, 100);
            DiagramShape diagramItem2 = new DiagramShape(BasicShapes.Rectangle, 350, 100, 100, 100);
            DiagramConnector diagramConnector1 = new DiagramConnector(diagramItem1, diagramItem2);
            diagramConnector1.EndArrow = ArrowDescriptions.Filled90;
            diagram.Items.AddRange(diagramItem2, diagramConnector1, diagramItem1);
            return new object[] { diagram };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
        }

        [CodeExampleCase("Diagram theme")]
        public static void GlobalTheme(DiagramControl diagramControl) {
            diagramControl.OptionsView.Theme = DiagramThemes.NoTheme;
            //DiagramThemes: Daybreak, Integral, Linear, Lines, Office, Parallel, Sequence
        }

        [CodeExampleCase("Shape theme")]
        public static void ShapeTheme(DiagramControl diagramControl) {
            diagramControl.OptionsView.Theme = DiagramThemes.Office;
            diagramControl.Items[0].ThemeStyleId = DiagramShapeStyleId.Variant3;
            diagramControl.Items[2].ThemeStyleId = DiagramShapeStyleId.Variant2;
        }

        [CodeExampleCase("Connector theme")]
        public static void ConnectorTheme(DiagramControl diagramControl) {
            diagramControl.OptionsView.Theme = DiagramThemes.Linear;
            diagramControl.Items[1].ThemeStyleId = DiagramConnectorStyleId.Intense2;
        }

        [CodeExampleCase("Show all diagram themes")]
        public static void ShowVariousGlobalThemes(DiagramControl diagramControl) {
            int index = 0;
            Timer myTimer = new Timer();
            myTimer.Tick += (sender, e) => {
                if(diagramControl.Page == null) {
                    myTimer.Stop();
                    return;
                }
                diagramControl.OptionsView.Theme = ThemeRegistrator.Themes.ElementAt(index);
                index += 1;
                if(index == ThemeRegistrator.Themes.Count())
                    index = 0;
            };
            myTimer.Interval = 700;
            myTimer.Start();
        }


        [CodeExampleCase("Show all item themes")]
        public static void ShowConnectorAndShapeThemes(DiagramControl diagramControl) {
            DiagramShape diagramShape1 = diagramControl.Items[0] as DiagramShape;
            DiagramShape diagramShape2 = diagramControl.Items[2] as DiagramShape;
            DiagramConnector diagramConnector1 = diagramControl.Items[1] as DiagramConnector;

            int index1 = 0;
            int index2 = 0;

            Timer myTimer = new Timer();
            myTimer.Tick += (sender, e) => {
                if(diagramControl.Page == null) {
                    myTimer.Stop();
                    return;
                }
                string[] id = DiagramShapeStyleId.Styles[index1].Id.Split('.');
                diagramShape1.ThemeStyleId = DiagramShapeStyleId.Styles[index1];
                diagramShape1.Content = id[id.Count() - 1];
                diagramShape2.ThemeStyleId = DiagramShapeStyleId.Styles[index1];
                diagramShape2.Content = id[id.Count() - 1];
                diagramConnector1.ThemeStyleId = DiagramConnectorStyleId.Styles[index2];
                diagramConnector1.Content = DiagramConnectorStyleId.Styles[index2].Id.Split('.')[1];
                index1 += 1;
                index2 += 1;
                if(index1 == DiagramShapeStyleId.Styles.Count)
                    index1 = 0;
                if(index2 == DiagramConnectorStyleId.Styles.Count)
                    index2 = 0;
            };
            myTimer.Interval = 700;
            myTimer.Start();
        }
    }

    [CodeExampleClass("Undo and Redo Operations", "GenericExamples.cs")]
    [CodeExampleVersionID(161)]
    public static class UndoRedoInCode {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            DiagramControl diagram = new DiagramControl();
            diagram.Parent = sampleHost;
            diagram.Dock = DockStyle.Fill;
            diagram.OptionsView.PageSize = new SizeF(600, 400);
            diagram.FitToPage();

            SimpleButton hostButton = new SimpleButton();
            SimpleButton hostButton1 = new SimpleButton();
            PanelControl panel = new PanelControl();
            panel.Dock = DockStyle.Top;
            hostButton.Parent = panel;
            hostButton1.Parent = panel;
            hostButton1.Width = (int)(80 * DevExpress.Skins.DpiProvider.Default.DpiScaleFactor);
            hostButton.Width = (int)(80 * DevExpress.Skins.DpiProvider.Default.DpiScaleFactor);
            panel.Height = (int)(30 * DevExpress.Skins.DpiProvider.Default.DpiScaleFactor);
            hostButton.Dock = DockStyle.Left;
            hostButton1.Dock = DockStyle.Left;
            panel.Parent = sampleHost;

            DiagramShape diagramItem1 = new DiagramShape(BasicShapes.Rectangle, 50, 50, 100, 100);
            DiagramShape diagramItem2 = new DiagramShape(BasicShapes.Rectangle, 200, 50, 100, 100);
            DiagramConnector connector = new DiagramConnector(diagramItem1, diagramItem2);
            connector.EndArrow = ArrowDescriptions.Filled90;
            diagram.Items.Add(connector);
            diagram.Items.Add(diagramItem1);
            diagram.Items.Add(diagramItem2);
            return new object[] { diagram, panel };
        }

        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
        }


        [CodeExampleUnderlineTokens("Undo", "Redo")]
        [CodeExampleCase("Undo and Redo")]
        public static void UndoAndRedo(DiagramControl diagramControl, PanelControl panel) {
            SimpleButton button1 = panel.Controls[0] as SimpleButton;
            SimpleButton button2 = panel.Controls[1] as SimpleButton;

            button1.Text = "Undo";
            button2.Text = "Redo";
            button1.Click += (sender, e) => {
                diagramControl.UndoManager.Undo();
            };

            button2.Click += (sender, e) => {
                diagramControl.UndoManager.Redo();
            };
        }
    }
}
