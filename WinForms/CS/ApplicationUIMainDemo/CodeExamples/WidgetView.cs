using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views.Widget;
using DevExpress.XtraEditors;

namespace Examples {
    [CodeExampleClass("WidgetView via code", "WidgetView.cs")]
    [CodeExampleHighlightTokens("WidgetView", "StackGroup", "UserControl", "DocumentContent", "Document", "Orientation", "LengthUnitType", "DocumentManager", "XtraUserControl"
        , "RowDefinition", "ColumnDefinition", "Color","Pen","SolidBrush", "StringFormat", "StringAlignment", "StringTrimming", "StringFormatFlags", "ControlStyles", "PaintEventArgs","Panel")]
    public static class WidgetLayout {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            DocumentManager documentManager = new DocumentManager();
            XtraUserControl documentManagerHost = new XtraUserControl();
            documentManagerHost.Parent = sampleHost;
            documentManagerHost.Dock = DockStyle.Fill;
            return new object[] { documentManager, documentManagerHost };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var documentManager = DocumentManager.FromControl(sampleHost);
            if(documentManager != null)
                documentManager = null;
        }
        [CodeExampleCase("Create WidgetView")]
        public static void CreateWidgetView(DocumentManager documentManager, XtraUserControl ownerControl) {
            WidgetView view = new WidgetView();
            documentManager.View = view;
            documentManager.ViewCollection.Add(view);
            documentManager.ContainerControl = ownerControl;
            view.StackGroups.Add(new StackGroup());
            view.AddDocument(new UserControl() { Text = "Document1" });
        }
        [CodeExampleCase("Using maximized Control", new Type[] { typeof(DocumentContent) })]
        public static void UsingMaximizedControl(DocumentManager documentManager, XtraUserControl ownerControl) {
            WidgetView view = new WidgetView();
            documentManager.View = view;
            documentManager.ViewCollection.Add(view);
            documentManager.ContainerControl = ownerControl;
            view.StackGroups.Add(new StackGroup());
            var document = view.AddDocument(new DocumentContent() { Text = "Document1" }) as Document;
            document.MaximizedControl = new DocumentContent() { Text = "Maximized control" };
            view.Controller.Maximize(document);
        }
        [CodeExampleCase("Create Vertical StackLayout"), CodeExampleGroupName("Stack Layout")]
        public static void CreateVerticalStackGroup(DocumentManager documentManager, XtraUserControl ownerControl) {
            WidgetView view = new WidgetView();
            documentManager.View = view;
            documentManager.ViewCollection.Add(view);
            documentManager.ContainerControl = ownerControl;
            view.StackGroups.Add(new StackGroup());
            var document1 = view.AddDocument(new UserControl() { Text = "Document1" }) as Document;
            var document2 = view.AddDocument(new UserControl() { Text = "Document2" }) as Document;
            StackGroup group1 = new StackGroup();
            view.StackGroups.Add(group1);
            view.Controller.Dock(document2, group1);
        }
        [CodeExampleCase("Create Horizontal StackLayout"), CodeExampleGroupName("Stack Layout")]
        public static void CreateHorizontalStackGroup(DocumentManager documentManager, XtraUserControl ownerControl) {
            WidgetView view = new WidgetView();
            documentManager.View = view;
            documentManager.ViewCollection.Add(view);
            documentManager.ContainerControl = ownerControl;
            view.StackGroups.Add(new StackGroup());
            var document1 = view.AddDocument(new UserControl() { Text = "Document1" }) as Document;
            var document2 = view.AddDocument(new UserControl() { Text = "Document2" }) as Document;

            view.Orientation = Orientation.Horizontal;

            StackGroup group = new StackGroup();
            view.StackGroups.Add(group);
            view.Controller.Dock(document2, group);
        }
        [CodeExampleCase("Dragging StackGroup"), CodeExampleGroupName("Stack Layout")]
        public static void DraggingStackGroup(DocumentManager documentManager, XtraUserControl ownerControl) {
            WidgetView view = new WidgetView();
            view.AllowStartupAnimation = DevExpress.Utils.DefaultBoolean.False;
            documentManager.View = view;
            documentManager.ViewCollection.Add(view);
            documentManager.ContainerControl = ownerControl;
            view.StackGroups.Add(new StackGroup() { Caption = "StackGroup1"});
            var document1 = view.AddDocument(new UserControl() { Text = "Document1" }) as Document;
            var document2 = view.AddDocument(new UserControl() { Text = "Document2" }) as Document;
            StackGroup group = new StackGroup() {Caption = "StackGroup2" };
            view.StackGroups.Add(group);
            view.Controller.Dock(document2, group);

            view.BeginUpdateAnimation();
            view.StackGroups.Remove(group);
            view.StackGroups.Insert(0, group);
            view.EndUpdateAnimation();
        }
        [CodeExampleCase("Resize Document in StackLayout"), CodeExampleGroupName("Stack Layout")]
        public static void ResizeDocumentInStackLayout(DocumentManager documentManager, XtraUserControl ownerControl) {
            WidgetView view = new WidgetView();
            documentManager.View = view;
            documentManager.ViewCollection.Add(view);
            documentManager.ContainerControl = ownerControl;
            view.StackGroups.Add(new StackGroup());
            var document1 = view.AddDocument(new UserControl() { Text = "Document1" }) as Document;
            var document2 = view.AddDocument(new UserControl() { Text = "Document2" }) as Document;
            document1.Height = 300;
            StackGroup group = new StackGroup();
            view.StackGroups.Add(group);
            view.Controller.Dock(document2, group);
        }
        [CodeExampleCase("Resize StackGroup"), CodeExampleGroupName("Stack Layout")]
        public static void ResizeStackGroup(DocumentManager documentManager, XtraUserControl ownerControl) {
            WidgetView view = new WidgetView();
            documentManager.View = view;
            documentManager.ViewCollection.Add(view);
            documentManager.ContainerControl = ownerControl;
            view.StackGroups.Add(new StackGroup());
            var document1 = view.AddDocument(new UserControl() { Text = "Document1" }) as Document;
            var document2 = view.AddDocument(new UserControl() { Text = "Document2" }) as Document;
            StackGroup group = new StackGroup();
            group.Length.UnitType = LengthUnitType.Pixel;
            group.Length.UnitValue = 200;
            view.StackGroups.Add(group);
            view.Controller.Dock(document2, group);
        }
        [CodeExampleCase("Create TableLayout", new Type[] { typeof(DefaultWidgetViewCreator) }), CodeExampleGroupName("Table Layout")]
        public static void CreateTableLayout(DocumentManager documentManager, XtraUserControl ownerControl) {
            var view = DefaultWidgetViewCreator.Create(documentManager, ownerControl);
            view.LayoutMode = LayoutMode.FlowLayout;
            var document = view.Documents[1] as Document;
            view.LayoutMode = LayoutMode.TableLayout;
            view.Rows.Add(new RowDefinition());
            view.Rows.Add(new RowDefinition());
            view.Columns.Add(new ColumnDefinition());
            view.Columns.Add(new ColumnDefinition());
            document.RowIndex = 1;
            document.ColumnIndex = 1;
        }
        [CodeExampleCase("Resize Document", new Type[] { typeof(DefaultWidgetViewCreator) }), CodeExampleGroupName("Table Layout")]
        public static void ResizeDocumentInTableLayout(DocumentManager documentManager, XtraUserControl ownerControl) {
            var view = DefaultWidgetViewCreator.Create(documentManager, ownerControl);
            view.LayoutMode = LayoutMode.FlowLayout;
            var document = view.Documents[1] as Document;
            view.LayoutMode = LayoutMode.TableLayout;
            view.Rows.Add(new RowDefinition());
            view.Rows.Add(new RowDefinition());
            view.Columns.Add(new ColumnDefinition());
            view.Columns.Add(new ColumnDefinition());
            document.RowIndex = 1;
            document.ColumnIndex = 0;
            document.ColumnSpan = 2;
        }
        [CodeExampleCase("Resize TableLayout"), CodeExampleGroupName("Table Layout")]
        public static void ResizeTableLayout(DocumentManager documentManager, XtraUserControl ownerControl) {
            WidgetView view = new WidgetView();
            documentManager.View = view;
            documentManager.ViewCollection.Add(view);
            documentManager.ContainerControl = ownerControl;
            var document1 = view.AddDocument(new UserControl() { Text = "Document1" }) as Document;
            var document2 = view.AddDocument(new UserControl() { Text = "Document2" }) as Document;
            document2.RowIndex = 0;
            document2.ColumnIndex = 1;
            view.LayoutMode = LayoutMode.TableLayout;
            view.Rows.Add(new RowDefinition());
            view.Rows.Add(new RowDefinition());
            view.Columns.Add(new ColumnDefinition());
            view.Columns.Add(new ColumnDefinition());
            var column = view.Columns[1];
            column.Length.UnitType = LengthUnitType.Pixel;
            column.Length.UnitValue = 150;
        }
        [CodeExampleCase("Create FlowLayout"), CodeExampleGroupName("Flow Layout")]
        public static void CreateFlowLayout(DocumentManager documentManager, XtraUserControl ownerControl) {
            WidgetView view = new WidgetView();
            documentManager.View = view;
            documentManager.ViewCollection.Add(view);
            documentManager.ContainerControl = ownerControl;
            var document1 = view.AddDocument(new UserControl() { Text = "Document1" }) as Document;
            var document2 = view.AddDocument(new UserControl() { Text = "Document2" }) as Document;
            view.LayoutMode = LayoutMode.FlowLayout;
        }
        [CodeExampleCase("Change FlowDirection", new Type[] { typeof(DefaultWidgetViewCreator) }), CodeExampleGroupName("Flow Layout")]
        public static void ChangeFlowDirection(DocumentManager documentManager, XtraUserControl ownerControl) {
            var view = DefaultWidgetViewCreator.Create(documentManager, ownerControl);
            view.LayoutMode = LayoutMode.FlowLayout;
            view.FlowLayoutProperties.FlowDirection = FlowDirection.RightToLeft;
        }
        [CodeExampleCase("Resize Document", new Type[] { typeof(DefaultWidgetViewCreator) }), CodeExampleGroupName("Flow Layout")]
        public static void ResizeDocumentInFlowLayout(DocumentManager documentManager, XtraUserControl ownerControl) {
            var view = DefaultWidgetViewCreator.Create(documentManager, ownerControl);
            view.LayoutMode = LayoutMode.FlowLayout;
            var document = view.Documents[0] as Document;
            document.Width = 180;
            document.Height = 180;
        }
        [CodeExampleCase("Create FreeLayout"), CodeExampleGroupName("Free Layout")]
        public static void CreateFreeLayout(DocumentManager documentManager, XtraUserControl ownerControl) {
            WidgetView view = new WidgetView();
            documentManager.View = view;
            documentManager.ViewCollection.Add(view);
            documentManager.ContainerControl = ownerControl;
            var document1 = view.AddDocument(new UserControl() { Text = "Document1" }) as Document;
            var document2 = view.AddDocument(new UserControl() { Text = "Document2" }) as Document;
            var document3 = view.AddDocument(new UserControl() { Text = "Document3" }) as Document;
            view.LayoutMode = LayoutMode.FreeLayout;
            view.Orientation = Orientation.Horizontal;
            document3.DockTo(document2, Orientation.Vertical);
        }
        [CodeExampleCase("Create Document with fixed Length", new Type[] { typeof(DefaultWidgetViewCreator) }), CodeExampleGroupName("Free Layout")]
        public static void CreateDocumentWithFixedLength(DocumentManager documentManager, XtraUserControl ownerControl) {
            int documentsCount = 3;
            WidgetView view = DefaultWidgetViewCreator.Create(documentManager, ownerControl, documentsCount);
            view.LayoutMode = LayoutMode.FreeLayout;
            view.Orientation = Orientation.Horizontal;
            Document document2 = view.Documents[1] as Document;
            view.BeginUpdate();
            document2.FreeLayoutWidth.UnitType = LengthUnitType.Pixel;
            document2.FreeLayoutWidth.UnitValue = 150;
            view.EndUpdate();
        }
        [CodeExampleCase("Resize Document", new Type[] { typeof(DefaultWidgetViewCreator) }), CodeExampleGroupName("Free Layout")]
        public static void ResizeDocumentInFreeLayout(DocumentManager documentManager, XtraUserControl ownerControl) {
            int documentsCount = 3;
            WidgetView view = DefaultWidgetViewCreator.Create(documentManager, ownerControl, documentsCount);
            view.LayoutMode = LayoutMode.FreeLayout;
            view.Orientation = Orientation.Horizontal;
            Document document1 = view.Documents[0] as Document;
            Document document2 = view.Documents[1] as Document;
            double delta = 0.2D;
            document1.FreeLayoutWidth.UnitValue += delta;
            document2.FreeLayoutWidth.UnitValue -= delta;
        }
        [CodeExampleNestedClass]
        public static class DefaultWidgetViewCreator{
            public static WidgetView Create(DocumentManager documentManager, XtraUserControl ownerControl, int documentCount = 2) {
                WidgetView view = new WidgetView();
                documentManager.View = view;
                documentManager.ViewCollection.Add(view);
                documentManager.ContainerControl = ownerControl;
                for(int i = 0; i < documentCount; i++) {
                    view.AddDocument(new UserControl() { Text = "Document" + (i + 1) });
                }
                return view;
            }
        }
        [CodeExampleNestedClass]
        public class DocumentContent : Panel {
            static int currentColor;
            static Color[] forecolors = new Color[] { 
                Color.Red, Color.Blue, Color.Green
            };
            SolidBrush sb;
            Pen pen;
            StringFormat sf;
            static Font _font = new Font("Segoe UI", 24f);
            public DocumentContent() {
                sf = new StringFormat()
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center,
                    Trimming = StringTrimming.EllipsisCharacter,
                    FormatFlags = StringFormatFlags.NoWrap
                };
                DoubleBuffered = true;
                ForeColor = forecolors[(currentColor++) % forecolors.Length];
                SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
                SetStyle(ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
            }
            protected override void OnPaint(PaintEventArgs e) {
                if(sb == null)
                    sb = new SolidBrush(Color.FromArgb(100, ForeColor));
                if(pen == null)
                    pen = new Pen(Color.FromArgb(200, 221, 223, 223));
                e.Graphics.FillRectangle(sb, ClientRectangle);
                e.Graphics.DrawString(Text, _font, sb, ClientRectangle, sf);
            }
        }
    }
}
