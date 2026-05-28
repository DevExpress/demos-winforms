using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.Utils.Base;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;

namespace Examples {
    [CodeExampleClass("WindowsUIView", "WindowsUIView.cs")]
    [CodeExampleHighlightTokens("WindowsUIView", "TileItemElement", "Tile", "TileContainer", "TileItemContentAlignment", "ISupportInitialize", "Flyout"
        , "FlyoutAction", "MessageBoxButtons", "DocumentContent", "Document", "PageGroup", "TabbedGroup", "HeaderStyle", "Page", "AttachedAction", "NavigationCommand",
        "ActionType", "ActionEdge", "Color", "SolidBrush", "Pen", "StringFormat", "Font", "StringAlignment", "ControlStyles", "PaintEventArgs", "StringTrimming", "StringFormatFlags", "Panel"
        , "INavigationArgs", "IDictionaryEnumerator", "AnchorStyles", "IDocumentActionsArgs", "DocumentAction", "ISupportNavigation", "IPropertiesProvider", "DocumentManager", "XtraUserControl", "DockStyle", "ISupportDocumentActions")]
    public static class WindowsUIViewInterface {
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
            var documentManager = DocumentManager.FromControl(sampleHost.Controls[0]);
            if(documentManager != null)
                documentManager.Dispose();
        }
        [CodeExampleCase("Create WindowsUIView")]
        public static void CreateWindowsUIView(DocumentManager documentManager, XtraUserControl ownerControl) {
            WindowsUIView view = new WindowsUIView();
            documentManager.View = view;
            documentManager.ViewCollection.Add(view);
            documentManager.ContainerControl = ownerControl;
            Tile tile = new Tile();
            TileItemElement element = new TileItemElement() { Text = "Tile", TextAlignment = TileItemContentAlignment.MiddleCenter };
            tile.Elements.Add(element);
            view.Tiles.Add(tile);
            TileContainer container = new TileContainer();
            container.Items.Add(tile);
            view.ContentContainers.Add(container);
            view.ActivateContainer(container);
        }
        [CodeExampleCase("Using QueryStartupContentContainer event", new Type[] { typeof(DocumentContent) })]
        [CodeExampleUnderlineTokens("BeginInit", "EndInit", "ForceInitialize")]
        public static void UseQueryStartupContentContainer(DocumentManager documentManager, XtraUserControl ownerControl) {
            WindowsUIView view = new WindowsUIView();
            (view as ISupportInitialize).BeginInit();
            Flyout flyoutView = new Flyout();
            flyoutView.Action = new FlyoutAction() { Caption = "Login form" };
            flyoutView.FlyoutButtons = MessageBoxButtons.OK;
            documentManager.View = view;
            documentManager.ContainerControl = ownerControl;
            flyoutView.Document = view.AddDocument(new DocumentContent() { Text = "Login User Control", Size = new Size(300, 130) }) as Document;
            Tile tile = new Tile();
            TileItemElement element = new TileItemElement() { Text = "Tile", TextAlignment = TileItemContentAlignment.MiddleCenter };
            tile.Elements.Add(element);
            view.Tiles.Add(tile);
            TileContainer tileContainer = new TileContainer();
            tileContainer.Items.Add(tile);
            tileContainer.Parent = flyoutView;
            view.ContentContainers.Add(tileContainer);
            view.QueryStartupContentContainer += (sender, e) => { e.ContentContainer = flyoutView; };
            view.FlyoutHidden += (sender, e) => { view.ActivateContainer(tileContainer); };
            (view as ISupportInitialize).EndInit();
            documentManager.ForceInitialize();

        }
        [CodeExampleCase("Create Tile automatically", new Type[] { typeof(DocumentContent) })]
        [CodeExampleUnderlineTokens("ActivateContainer")]
        public static void CreateSimpleTileWithDocument(DocumentManager documentManager, XtraUserControl ownerControl) {
            WindowsUIView view = new WindowsUIView();
            documentManager.View = view;
            documentManager.ViewCollection.Add(view);
            documentManager.ContainerControl = ownerControl;
            TileContainer tileContainer = new TileContainer();
            view.ContentContainers.Add(tileContainer);
            var document = view.AddDocument(new DocumentContent() { Text = "Document1" });
            //Tile created after adding document
            var tile = view.Tiles[document];
            TileItemElement element = new TileItemElement() { Text = "Document1", TextAlignment = TileItemContentAlignment.MiddleCenter };
            tile.Elements.Add(element);
            view.ActivateContainer(tileContainer);
        }
        [CodeExampleCase("Create PageGroup", new Type[] { typeof(DocumentContent) })]
        public static void CreatePageGroup(DocumentManager documentManager, XtraUserControl ownerControl) {
            WindowsUIView view = new WindowsUIView();
            documentManager.View = view;
            documentManager.ViewCollection.Add(view);
            documentManager.ContainerControl = ownerControl;
            PageGroup container = new PageGroup();
            view.ContentContainers.Add(container);
            var document1 = view.AddDocument(new DocumentContent() { Text = "Document1" }) as Document;
            var document2 = view.AddDocument(new DocumentContent() { Text = "Document2" }) as Document;
            container.Items.Add(document1);
            container.Items.Add(document2);
            view.ActivateContainer(container);
        }
        [CodeExampleCase("Create TabbedGroup(Tabs)", new Type[] { typeof(DocumentContent) })]
        public static void CreateTabbedGroupTabHeaderStyle(DocumentManager documentManager, XtraUserControl ownerControl) {
            WindowsUIView view = new WindowsUIView();
            documentManager.View = view;
            documentManager.ViewCollection.Add(view);
            documentManager.ContainerControl = ownerControl;
            TabbedGroup container = new TabbedGroup();
            view.ContentContainers.Add(container);
            var document1 = view.AddDocument(new DocumentContent() { Text = "Document1" }) as Document;
            var document2 = view.AddDocument(new DocumentContent() { Text = "Document2" }) as Document;
            var document3 = view.AddDocument(new DocumentContent() { Text = "Document3" }) as Document;
            var document4 = view.AddDocument(new DocumentContent() { Text = "Document4" }) as Document;
            var document5 = view.AddDocument(new DocumentContent() { Text = "Document5" }) as Document;
            container.Items.Add(document1);
            container.Items.Add(document2);
            container.Items.Add(document3);
            container.Items.Add(document4);
            container.Items.Add(document5);
            view.ActivateContainer(container);
        }
        [CodeExampleCase("Create TabbedGroup(Tiles)", new Type[] { typeof(DocumentContent) })]
        public static void CreateTabbedGroupTileHeaderStyle(DocumentManager documentManager, XtraUserControl ownerControl) {
            WindowsUIView view = new WindowsUIView();
            documentManager.View = view;
            documentManager.ViewCollection.Add(view);
            documentManager.ContainerControl = ownerControl;
            TabbedGroup container = new TabbedGroup();
            container.Properties.HeaderStyle = HeaderStyle.Tile;
            container.Properties.TileSize = 80;
            container.Properties.TileColumnCount = 1;
            view.ContentContainers.Add(container);
            var item1 = view.AddDocument(new DocumentContent() { Text = "Item1" }) as Document;
            var item2 = view.AddDocument(new DocumentContent() { Text = "Item2" }) as Document;
            var item3 = view.AddDocument(new DocumentContent() { Text = "Item3" }) as Document;
            container.Items.Add(item1);
            container.Items.Add(item2);
            container.Items.Add(item3);
            view.ActivateContainer(container);
        }
        [CodeExampleCase("Simple Navigation", new Type[] { typeof(DocumentContent), typeof(WindowsUIViewInitializer) })]
        public static void SimpleNavigation(DocumentManager documentManager, XtraUserControl ownerControl) {
            var view = WindowsUIViewInitializer.Init(documentManager, ownerControl);
            var document = view.Documents[0] as Document;
            Tile tile = new Tile();
            TileItemElement element = new TileItemElement() { Text = "Click here", TextAlignment = TileItemContentAlignment.MiddleCenter };
            tile.Elements.Add(element);
            view.Tiles.Add(tile);
            TileContainer container = new TileContainer();
            Page page = new Page() { Caption = "Custom page" };
            page.Parent = container;
            page.Document = document;
            container.Items.Add(tile);
            tile.ActivationTarget = page;
            view.ContentContainers.Add(container);
            view.ContentContainers.Add(page);
            view.ActivateContainer(container);
        }
        [CodeExampleCase("Using ISupportNavigation interface", new Type[] { typeof(UserControl1), typeof(DocumentContent), typeof(WindowsUIViewInitializer) })]
        public static void UsingNavigation(DocumentManager documentManager, XtraUserControl ownerControl) {
            var view = WindowsUIViewInitializer.Init(documentManager, ownerControl);
            var document = view.AddDocument(new UserControl1()) as Document;
            Tile tile = new Tile();
            tile.Tag = "Custom Filter";
            TileItemElement element = new TileItemElement() { Text = "Click here", TextAlignment = TileItemContentAlignment.MiddleCenter };
            tile.Elements.Add(element);
            view.Tiles.Add(tile);
            TileContainer container = new TileContainer() { Name = "Main container" };
            Page page = new Page() { Caption = "Custom page" };
            page.Parent = container;
            page.Document = document;
            container.Items.Add(tile);
            tile.ActivationTarget = page;
            view.ContentContainers.Add(container);
            view.ContentContainers.Add(page);
            view.ActivateContainer(container);
        }
        [CodeExampleCase("Using attached action", new Type[] { typeof(WindowsUIViewInitializer), typeof(DocumentContent), typeof(NavigationCommand), typeof(UserControl2) })]
        public static void AttachedActions(DocumentManager documentManager, XtraUserControl ownerControl) {
            var view = WindowsUIViewInitializer.Init(documentManager, ownerControl);
            Page mainPage = new Page() { Caption = "Main Page" };
            Page targetPage = new Page() { Caption = "Target Page" };
            UserControl2 control = new UserControl2();
            control.NavigateButton.Click += (sender, e) => {
                AttachedAction.Execute(control.NavigateButton);
            };
            AttachedAction navigateAction = new AttachedAction() { Target = targetPage, Command = new NavigationCommand(view) };
            AttachedAction.Attach(control.NavigateButton, navigateAction);
            var navigateDocument = view.AddDocument(control) as Document;
            mainPage.Document = navigateDocument;
            var targetDocument = view.AddDocument(new DocumentContent() { Text = "Target document" }) as Document;
            targetPage.Document = targetDocument;
            view.ContentContainers.Add(mainPage);
            view.ContentContainers.Add(targetPage);
            targetPage.Parent = mainPage;
            view.ActivateContainer(mainPage);
        }
        [CodeExampleCase("Custom document action", new Type[] { typeof(ActionUserControl), typeof(DocumentContent) })]
        public static void CustomDocumentAction(DocumentManager documentManager, XtraUserControl ownerControl) {
            WindowsUIView view = new WindowsUIView();
            view.AddTileWhenCreatingDocument = DevExpress.Utils.DefaultBoolean.False;
            documentManager.View = view;
            documentManager.ViewCollection.Add(view);
            documentManager.ContainerControl = ownerControl;
            view.QueryDocumentActions += (sender, e) => {
                e.DocumentActions.Add(new DocumentAction(null) { Caption = "Document Action 1" });
            };
            var document = view.AddDocument(new ActionUserControl() { Text = "Document1" }) as Document;
            Page page = new Page() { Caption = "Page" };
            page.Document = document;
            page.Properties.ShowContextActionBarOnActivating = DevExpress.Utils.DefaultBoolean.True;
            view.ContentContainers.Add(page);
            view.ActivateContainer(page);
        }
        [CodeExampleCase("Custom container action", new Type[] { typeof(DocumentContent) })]
        public static void CustomContainerAction(DocumentManager documentManager, XtraUserControl ownerControl) {
            WindowsUIView view = new WindowsUIView();
            view.AddTileWhenCreatingDocument = DevExpress.Utils.DefaultBoolean.False;
            documentManager.View = view;
            documentManager.ViewCollection.Add(view);
            documentManager.ContainerControl = ownerControl;
            var document = view.AddDocument(new DocumentContent() { Text = "Document1" }) as Document;
            Page page = new Page() { Caption = "Page" };
            page.Actions.Add(new DelegateAction(() => (true), () => { }) { Caption = "Container action", Type = ActionType.Context, Edge = ActionEdge.Left });
            page.Document = document;
            page.Properties.ShowContextActionBarOnActivating = DevExpress.Utils.DefaultBoolean.True;
            view.ContentContainers.Add(page);
            view.ActivateContainer(page);
        }
        [CodeExampleCase("Flyout with action", new Type[] { typeof(WindowsUIViewInitializer), typeof(DocumentContent) })]
        public static void Flyout(DocumentManager documentManager, XtraUserControl ownerControl) {
            var view = WindowsUIViewInitializer.Init(documentManager, ownerControl);
            var document = view.Documents[0] as Document;
            Flyout flyoutView = new Flyout() { Caption = "Custom page" };
            flyoutView.Action = new FlyoutAction() { Caption = "Flyout Action Caption", Description = "Flyout Action Description" };
            flyoutView.FlyoutButtons = MessageBoxButtons.OK;
            view.ContentContainers.Add(flyoutView);
            view.ActivateContainer(flyoutView);
        }
        [CodeExampleCase("Flyout with UserControl", new Type[] { typeof(WindowsUIViewInitializer), typeof(DocumentContent) })]
        public static void FlyoutWithControl(DocumentManager documentManager, XtraUserControl ownerControl) {
            var view = WindowsUIViewInitializer.Init(documentManager, ownerControl);
            var document = view.Documents[0] as Document;
            Flyout flyoutView = new Flyout();
            flyoutView.Action = new FlyoutAction() { Caption = "Flyout Action Caption" };
            flyoutView.FlyoutButtons = MessageBoxButtons.OK;
            //add document with user control to flyout
            flyoutView.Document = document;
            view.ContentContainers.Add(flyoutView);
            view.ActivateContainer(flyoutView);
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
            Color TextColor { get; set; }
            public DocumentContent() {
                sf = new StringFormat() {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center,
                    Trimming = StringTrimming.EllipsisCharacter,
                    FormatFlags = StringFormatFlags.NoWrap
                };
                DoubleBuffered = true;
                TextColor = forecolors[(currentColor++) % forecolors.Length];
                SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
                SetStyle(ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
            }
            protected override void OnPaint(PaintEventArgs e) {
                if(sb == null)
                    sb = new SolidBrush(Color.FromArgb(100, TextColor));
                if(pen == null)
                    pen = new Pen(Color.FromArgb(200, 221, 223, 223));
                e.Graphics.FillRectangle(sb, ClientRectangle);
                e.Graphics.DrawString(Text, _font, sb, ClientRectangle, sf);
            }
        }
        [CodeExampleNestedClass]
        public class UserControl1 : DocumentContent, ISupportNavigation, IPropertiesProvider {
            #region ISupportNavigation Members
            public void OnNavigatedFrom(INavigationArgs args) {
            }
            public void OnNavigatedTo(INavigationArgs args) {
                DevExpress.XtraEditors.XtraMessageBox.Show("Navigated from " + args.Source.Name + ". Tile tag = " + args.Tag.ToString());
            }
            #endregion
            #region IPropertiesProvider Members
            public System.Collections.IDictionaryEnumerator GetProperties() {
                return null;
            }
            #endregion
        }
        [CodeExampleNestedClass]
        public class NavigationCommand : ICommand<IContentContainer> {
            WindowsUIView viewCore;
            public NavigationCommand(WindowsUIView view) {
                viewCore = view;
            }
            public bool CanExecute(IContentContainer parameter) {
                return true;
            }
            public void Execute(IContentContainer parameter) {
                viewCore.ActivateContainer(parameter);
            }
            public event EventHandler CanExecuteChanged {
                add { }
                remove { }
            }
        }
        [CodeExampleNestedClass]
        public class UserControl2 : DocumentContent {
            public UserControl2() {
                Size = new Size(300, 130);
                NavigateButton = new SimpleButton() {
                    Text = "Navigate to container",
                    Size = new Size(175, 30),
                    Location = new Point(10, 10),
                    Dock = DockStyle.Top,
                    Parent = this,
                    Anchor = AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top
                };
                NavigateButton.Click += (sender, e) => { AttachedAction.Execute(NavigateButton); };
            }
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public SimpleButton NavigateButton { get; set; }
        }
        [CodeExampleNestedClass]
        public class ActionUserControl : DocumentContent, ISupportDocumentActions {
            #region ISupportDocumentActions Members
            public void OnQueryDocumentActions(IDocumentActionsArgs args) {
                args.DocumentActions.Add(new DocumentAction(CanExecuteDocumentAction, ExecuteDocumentAction) { Caption = "Document Action 2" });
            }
            public static bool CanExecuteDocumentAction(Document document) {
                return true;
            }
            public static void ExecuteDocumentAction(Document document) {
                DevExpress.XtraEditors.XtraMessageBox.Show("Custom action executed");
            }
            #endregion
        }
        [CodeExampleNestedClass]
        public static class WindowsUIViewInitializer {
            public static WindowsUIView Init(DocumentManager documentManager, XtraUserControl ownerControl) {
                WindowsUIView view = new WindowsUIView();
                view.AddTileWhenCreatingDocument = DevExpress.Utils.DefaultBoolean.False;
                documentManager.View = view;
                documentManager.ViewCollection.Add(view);
                documentManager.ContainerControl = ownerControl;
                view.AddDocument(new DocumentContent() { Text = "Document1", Size = new Size(300, 150) });
                view.AddDocument(new DocumentContent() { Text = "Document2" });
                return view;
            }
        }
    }
}
