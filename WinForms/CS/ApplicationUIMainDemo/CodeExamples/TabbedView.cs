using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DevExpress.ApplicationUI.Demos;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace Examples {
    [CodeExampleClass("TabbedView via code", "TabbedView.cs")]
    [CodeExampleHighlightTokens("TabbedView", "UserControl", "DocumentGroupCollection", "BaseDocument", "DocumentGroup", "Document", "Orientation"
        , "RibbonMdiMergeStyle", "RibbonAndBarsMergeStyle", "Color", "RibbonControl", "RibbonPage", "RibbonPageGroup", "BarButtonItem","BarItem", "Panel")]
    public static class TabbedLayout {
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
            if(documentManager != null) {
                documentManager.Dispose();
                documentManager = null;
            }
        }
        [CodeExampleCase("Create simple TabbedView")]
        public static void SimpleTabbedView(DocumentManager documentManager, XtraUserControl ownerControl) {
            TabbedView view = new TabbedView();
            documentManager.View = view;
            documentManager.ViewCollection.Add(view);
            documentManager.ContainerControl = ownerControl;
            view.AddDocument(new UserControl() { Text = "Document1" });
        }
        [CodeExampleCase("Create TabbedView with free layout")]
        public static void TabbedViewFreeLayout(DocumentManager documentManager, XtraUserControl ownerControl) {
            TabbedView view = new TabbedView();
            view.EnableFreeLayoutMode = DevExpress.Utils.DefaultBoolean.True;
            documentManager.View = view;
            documentManager.ViewCollection.Add(view);
            documentManager.ContainerControl = ownerControl;
            DocumentGroupCollection groups = view.DocumentGroups;
            for(int i = 1; i <= 3; i++) {
                BaseDocument document = view.AddDocument(new Control());
                document.Caption = "Document" + i;
                DocumentGroup documentGroup = new DocumentGroup();
                view.DocumentGroups.Add(documentGroup);
                view.Controller.Dock(document as Document, documentGroup);
            }
            groups[2].DockTo(groups[1], Orientation.Vertical);
            view.LayoutChanged();
        }
        [CodeExampleCase("Ribbon merging", new Type[] { typeof(RibbonInitializer) })]
        public static void DocumentRibbonMerging(DocumentManager documentManager, XtraUserControl ownerControl) {
            TabbedView view = new TabbedView();
            documentManager.View = view;
            documentManager.ViewCollection.Add(view);
            documentManager.ContainerControl = ownerControl;
            documentManager.RibbonAndBarsMergeStyle = RibbonAndBarsMergeStyle.Always;
            var control = new UserControl() { Text = "Document1" };
            var mainRibbon = RibbonInitializer.Init(ownerControl, true);
            var childRibbon = RibbonInitializer.Init(control, false);

            mainRibbon.MdiMergeStyle = RibbonMdiMergeStyle.Always;

            view.AddDocument(control);
            mainRibbon.SelectedPage = mainRibbon.MergedPages[0];
        }
        [CodeExampleCase("Create several vertical DocumentGroup")]
        public static void CreateSeveralDocumentVerticalGroup(DocumentManager documentManager, XtraUserControl ownerControl) {
            TabbedView view = new TabbedView();
            documentManager.View = view;
            documentManager.ViewCollection.Add(view);
            documentManager.ContainerControl = ownerControl;
            var document1 = view.AddDocument(new UserControl() { Text = "Document1" }) as Document;
            var document2 = view.AddDocument(new UserControl() { Text = "Document2" }) as Document;
            DocumentGroup newDocumentGroup = new DocumentGroup();
            view.DocumentGroups.Add(newDocumentGroup);
            var controller = view.Controller as ITabbedViewController;
            controller.Dock(document2, newDocumentGroup);
        }
        [CodeExampleCase("Create several horizontal DocumentGroup")]
        public static void CreateSeveralDocumentHorizontalGroup(DocumentManager documentManager, XtraUserControl ownerControl) {
            TabbedView view = new TabbedView();
            documentManager.View = view;
            documentManager.ViewCollection.Add(view);
            documentManager.ContainerControl = ownerControl;
            var document1 = view.AddDocument(new UserControl() { Text = "Document1" }) as Document;
            var document2 = view.AddDocument(new UserControl() { Text = "Document2" }) as Document;
            DocumentGroup newDocumentGroup = new DocumentGroup();
            view.DocumentGroups.Add(newDocumentGroup);
            view.Orientation = Orientation.Vertical;
            var controller = view.Controller as ITabbedViewController;
            controller.Dock(document2, newDocumentGroup);
        }
        [CodeExampleCase("Colored Tabs")]
        public static void ColoredTab(DocumentManager documentManager, XtraUserControl ownerControl) {
            TabbedView view = new TabbedView();
            documentManager.View = view;
            documentManager.ViewCollection.Add(view);
            documentManager.ContainerControl = ownerControl;
            var document1 = view.AddDocument(new UserControl() { Text = "Document1" }) as Document;
            var document2 = view.AddDocument(new UserControl() { Text = "Document2" }) as Document;
            DocumentGroup newDocumentGroup = new DocumentGroup();
            view.DocumentGroups.Add(newDocumentGroup);
            var controller = view.Controller as ITabbedViewController;
            controller.Dock(document2, newDocumentGroup);
            view.AppearancePage.Header.BackColor = Color.Red;
            document1.Appearance.HeaderActive.BackColor = Color.Green;
            document2.Appearance.HeaderActive.BackColor = Color.Green;
            controller.Activate(document1);
        }
        [CodeExampleCase("Custom draw tab headers")]
        public static void CustomDrawTabHeaders(DocumentManager documentManager, XtraUserControl ownerControl) {
            TabbedView view = new TabbedView();
            HatchBrush hatchBrush1 = new HatchBrush(HatchStyle.BackwardDiagonal, Color.LightGray, Color.AliceBlue);
            view.CustomDrawTabHeader += (s, e) => {
                e.Cache.FillRectangle(hatchBrush1, e.Bounds);
                e.DefaultDrawText();
                e.DefaultDrawImage();
                e.DefaultDrawButtons();
                e.Handled = true;
            };
            HatchBrush hatchBrush2 = new HatchBrush(HatchStyle.DiagonalCross, Color.LightGray, Color.AliceBlue);
            view.CustomDrawHeaderButton += (s, e) => {
                e.Cache.FillRectangle(hatchBrush2, e.Bounds);
                e.DefaultDraw();
                e.Handled = true;
            };
            documentManager.View = view;
            documentManager.ViewCollection.Add(view);
            documentManager.ContainerControl = ownerControl;
            string[] documentImageUris = { "Home;Size16x16", "Pie;Size16x16", "Up;Size16x16" };
            for(int i = 0; i < 3; i++) {
                var labelControl = new LabelControl();
                labelControl.Text = DemosInfo.GetLoremIpsumText(i);
                labelControl.Padding = new Padding(16);
                labelControl.AutoSizeMode = LabelAutoSizeMode.Vertical;
                var document = view.AddDocument(labelControl);
                document.ImageOptions.ImageUri = documentImageUris[i];
                document.Caption = string.Format("document{0}", view.Documents.Count);
            }
            var controller = view.Controller as ITabbedViewController;
            controller.Activate(view.Documents[0]);
        }
        [CodeExampleNestedClass]
        public static class RibbonInitializer {
            public static RibbonControl Init(Control control, bool parentRibbon) {
                RibbonControl ribbonControl = new RibbonControl();
                RibbonPage ribbonPage = new RibbonPage();
                RibbonPageGroup ribbonPageGroup = new RibbonPageGroup();
                BarButtonItem barButtonItem = new BarButtonItem();
                ribbonControl.Items.AddRange(new BarItem[] { barButtonItem });
                ribbonControl.Pages.AddRange(new RibbonPage[] { ribbonPage });
                ribbonPage.Groups.AddRange(new RibbonPageGroup[] { ribbonPageGroup });
                ribbonPage.Text = parentRibbon ? "MainPage" : "DocumentPage";
                ribbonPageGroup.ItemLinks.Add(barButtonItem);
                ribbonPageGroup.Text = "Actions";
                if(parentRibbon) {
                    barButtonItem.Caption = "Add";
                    barButtonItem.ImageUri.Uri = "Add";
                }
                else {
                    barButtonItem.Caption = "Save";
                    barButtonItem.ImageUri.Uri = "Save";
                }
                control.Controls.Add(ribbonControl);
                return ribbonControl;
            }
        }
    }
}
