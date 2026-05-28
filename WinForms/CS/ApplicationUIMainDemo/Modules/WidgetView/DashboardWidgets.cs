using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Widget;

namespace DevExpress.ApplicationUI.Demos {
    public partial class DashboardWidgets : TutorialControlBase {
        Color[] WidgetColors = { Color.FromArgb(255, 173, 180), Color.FromArgb(255, 243, 182), Color.FromArgb(230, 189, 228), Color.FromArgb(255, 219, 189), Color.FromArgb(189, 230, 255), Color.FromArgb(204, 245, 194) };
        public DashboardWidgets() {
            InitializeComponent();
            widgetView1.AllowDocumentStateChangeAnimation = DevExpress.Utils.DefaultBoolean.True;
            AutoMergeRibbon = true;
            widgetView1.QueryControl += OnQueryControl;
            SetWidgetsAppearances();
            foreach(Document item in widgetView1.Documents) {
                item.Width = (int)Math.Round(item.Width * Skins.DpiProvider.Default.DpiScaleFactor);
                item.Height = (int)Math.Round(item.Height * Skins.DpiProvider.Default.DpiScaleFactor);
            }
            ApplyLayoutMode(widgetView1.LayoutMode);
        }
        void OnQueryControl(object sender, XtraBars.Docking2010.Views.QueryControlEventArgs e) {
            string typeName = e.Document.ControlTypeName;
            if(!string.IsNullOrEmpty(typeName)) {
                var controlType = Data.Internal.SafeTypeResolver.GetKnownType(typeof(Program).Assembly, typeName);
                e.Control = Activator.CreateInstance(controlType) as Control;
            }
            else e.Control = new Control();
        }
        void OnLayoutModeCheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            LayoutMode layoutMode = (LayoutMode)e.Item.Tag;
            ApplyLayoutMode(layoutMode);
        }
        void ApplyLayoutMode(LayoutMode layoutMode) {
            widgetView1.BeginUpdateAnimation();
            widgetView1.LayoutMode = layoutMode;
            switch(layoutMode) {
                case LayoutMode.FlowLayout:
                    InitFlowLayout();
                    break;
                case LayoutMode.FreeLayout:
                    InitFreeLayout();
                    break;
                default:
                    pgMixAction.Visible = true;
                    biItemMixer.Visibility = XtraBars.BarItemVisibility.Always;
                    biDragMode.Visibility = XtraBars.BarItemVisibility.OnlyInCustomizing;
                    pgFlowDirection.Visible = false;
                    break;
            }
            widgetView1.EndUpdateAnimation();
        }
        void InitFlowLayout() {
            pgMixAction.Visible = true;
            biItemMixer.Visibility = XtraBars.BarItemVisibility.Always;
            biDragMode.Visibility = XtraBars.BarItemVisibility.OnlyInCustomizing;
            pgFlowDirection.Visible = true;
        }
        void InitFreeLayout() {
            pgFlowDirection.Visible = false;
            biItemMixer.Visibility = XtraBars.BarItemVisibility.OnlyInCustomizing;
            biDragMode.Visibility = XtraBars.BarItemVisibility.Always;
        }
        void OnFlowDirectionCheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            widgetView1.BeginUpdateAnimation();
            FlowDirection flowDirection = (FlowDirection)e.Item.Tag;
            widgetView1.FlowLayoutProperties.FlowDirection = flowDirection;
            widgetView1.EndUpdateAnimation();
        }
        void OnMixButtonClick(object sender, XtraBars.ItemClickEventArgs e) {
            switch(widgetView1.LayoutMode) {
                case LayoutMode.FlowLayout: FlowLayoutMix(); break;
                case LayoutMode.StackLayout: StackLayoutMix(); break;
                case LayoutMode.TableLayout: TableLayoutMix(); break;
            }
        }
        void StackLayoutMix() {
            int randomIndex = 0;
            try {
                widgetView1.BeginUpdateAnimation();
                foreach(Document document in widgetView1.Documents) {
                    StackGroup oldGroup = document.Parent;
                    if(oldGroup != null)
                        oldGroup.Items.Remove(document);
                    randomIndex = TutorialConstants.Random.Next(widgetView1.StackGroups.Count);
                    widgetView1.StackGroups[randomIndex].Items.Add(document);
                }
            }
            finally {
                widgetView1.EndUpdateAnimation();
            }
        }
        void TableLayoutMix() {
            try {
                widgetView1.BeginUpdateAnimation();
                List<Point> points = new List<Point>();
                for(int i = 0; i < 3; i++) {
                    for(int j = 0; j < 3; j++) {
                        points.Add(new Point(i, j));
                    }
                }
                foreach(Document document in widgetView1.Documents) {
                    Point newLocation = points[TutorialConstants.Random.Next(points.Count)];
                    document.RowIndex = newLocation.Y;
                    document.ColumnIndex = newLocation.X;
                    points.Remove(newLocation);
                }
            }
            finally {
                widgetView1.EndUpdateAnimation();
            }
        }
        void FlowLayoutMix() {
            int index = 0;
            Document document = new Document();
            try {
                widgetView1.BeginUpdateAnimation();
                for(int i = 0; i < widgetView1.FlowLayoutProperties.FlowLayoutItems.Count; i++) {
                    index = TutorialConstants.Random.Next(widgetView1.Documents.Count);
                    if(i == index) continue;
                    document = widgetView1.FlowLayoutProperties.FlowLayoutItems[i];
                    widgetView1.FlowLayoutProperties.FlowLayoutItems.Remove(document);
                    widgetView1.FlowLayoutProperties.FlowLayoutItems.Insert(index, document);
                }
            }
            finally {
                widgetView1.EndUpdateAnimation();
            }
        }
        void OnCheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            if((e.Item as XtraBars.BarCheckItem).Checked) SetWidgetsAppearances();
            else ResetWidgetAppearances();
        }
        void SetWidgetsAppearances() {
            List<BaseDocument> documents = new List<BaseDocument>();
            documents.AddRange(widgetView1.Documents.ToArray());
            documents.AddRange(widgetView1.FloatDocuments.ToArray());
            for(int i = 0; i < documents.Count; i++) {
                Document document = documents[i] as Document;
                document.AppearanceActiveCaption.BackColor = WidgetColors[i % WidgetColors.Length];
                document.AppearanceCaption.BackColor = WidgetColors[i % WidgetColors.Length];
            }
        }
        void ResetWidgetAppearances() {
            List<BaseDocument> documents = new List<BaseDocument>();
            documents.AddRange(widgetView1.FloatDocuments.ToArray());
            documents.AddRange(widgetView1.Documents.ToArray());
            foreach(Document document in documents) {
                document.AppearanceActiveCaption.Reset();
                document.AppearanceCaption.Reset();
            }
        }
        void ToggleFreeLayoutDragMode(object sender, XtraBars.ItemClickEventArgs e) {
            if(biDragMode.Down)
                widgetView1.FreeLayoutProperties.ItemDragStyle = ItemDragStyle.DockingHints;
            else
                widgetView1.FreeLayoutProperties.ItemDragStyle = ItemDragStyle.Default;
        }
    }
}
