using System;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;

namespace DevExpress.ApplicationUI.Demos {
    public partial class DocumentManagerWidgetViewFreeLayout : TutorialControlBase {
        private XtraBars.Docking2010.Views.Widget.WidgetView widgetView1;
        private XtraBars.Docking2010.DocumentManager documentManager1;
        private XtraBars.Docking2010.Views.Widget.Document document1;
        private XtraBars.Docking2010.Views.Widget.Document document3;
        private XtraBars.Docking2010.Views.Widget.Document document2;
        private XtraBars.Docking2010.Views.Widget.Document document4;
        private XtraBars.Docking2010.Views.Widget.Document document5;
        private XtraBars.Docking2010.Views.Widget.Document document6;
        private XtraBars.Docking2010.Views.Widget.Document document7;
        private XtraBars.Docking2010.Views.Widget.Document document8;
        private XtraBars.Docking2010.Views.Widget.Document document9;
        private System.ComponentModel.IContainer components;
        public DocumentManagerWidgetViewFreeLayout() {
            InitializeComponent();
            documentManager1.View.QueryControl += OnViewQueryControl;
        }
        void OnViewQueryControl(object sender, XtraBars.Docking2010.Views.QueryControlEventArgs e) {
            string typeName = e.Document.ControlTypeName;
            if(typeName == "DevExpress.ApplicationUI.Demos.ucCardWidget") {
                var smallWidget = new ucCardWidget();
                smallWidget.Price = TutorialConstants.Random.Next(100, 1000);
                smallWidget.PPrice = TutorialConstants.Random.NextDouble() - TutorialConstants.Random.NextDouble();
                smallWidget.Delta = TutorialConstants.Random.Next(-50, 100) + TutorialConstants.Random.NextDouble();
                e.Control = smallWidget;
                return;
            }
            if(!string.IsNullOrEmpty(typeName)) {
                var controlType = Data.Internal.SafeTypeResolver.GetKnownType(typeof(Program).Assembly, typeName);
                e.Control = Activator.CreateInstance(controlType) as Control;
            }
            else e.Control = new System.Windows.Forms.Control();
        }
        protected override int TakeScreenDelay => 300;
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer widgetDockingContainer1 = new DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer();
            DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer widgetDockingContainer2 = new DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer();
            DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer widgetDockingContainer3 = new DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer();
            DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer widgetDockingContainer4 = new DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer();
            DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer widgetDockingContainer5 = new DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer();
            DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer widgetDockingContainer6 = new DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer();
            DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer widgetDockingContainer7 = new DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer();
            DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer widgetDockingContainer8 = new DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer();
            DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer widgetDockingContainer9 = new DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer();
            DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer widgetDockingContainer10 = new DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer();
            DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer widgetDockingContainer11 = new DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer();
            DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer widgetDockingContainer12 = new DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer();
            this.document9 = new DevExpress.XtraBars.Docking2010.Views.Widget.Document(this.components);
            this.document2 = new DevExpress.XtraBars.Docking2010.Views.Widget.Document(this.components);
            this.document1 = new DevExpress.XtraBars.Docking2010.Views.Widget.Document(this.components);
            this.document3 = new DevExpress.XtraBars.Docking2010.Views.Widget.Document(this.components);
            this.document5 = new DevExpress.XtraBars.Docking2010.Views.Widget.Document(this.components);
            this.document4 = new DevExpress.XtraBars.Docking2010.Views.Widget.Document(this.components);
            this.document6 = new DevExpress.XtraBars.Docking2010.Views.Widget.Document(this.components);
            this.document7 = new DevExpress.XtraBars.Docking2010.Views.Widget.Document(this.components);
            this.document8 = new DevExpress.XtraBars.Docking2010.Views.Widget.Document(this.components);
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.widgetView1 = new DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.document9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widgetView1)).BeginInit();
            this.SuspendLayout();
            // 
            // document9
            // 
            this.document9.Caption = "Clock";
            this.document9.ControlName = "Clock";
            this.document9.ControlTypeName = "DevExpress.ApplicationUI.Demos.Clock";
            this.document9.FreeLayoutHeight.UnitValue = 0.45D;
            this.document9.FreeLayoutWidth.UnitType = DevExpress.XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel;
            this.document9.FreeLayoutWidth.UnitValue = 220D;
            // 
            // document2
            // 
            this.document2.Caption = "Calendar";
            this.document2.ControlName = "Calendar";
            this.document2.ControlTypeName = "DevExpress.ApplicationUI.Demos.Calendar";
            this.document2.FreeLayoutHeight.UnitValue = 1.55D;
            this.document2.FreeLayoutWidth.UnitType = DevExpress.XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel;
            this.document2.FreeLayoutWidth.UnitValue = 220D;
            // 
            // document1
            // 
            this.document1.Caption = "Products";
            this.document1.ControlName = "ProductsGridEx";
            this.document1.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucProductsBorderlessGrid";
            this.document1.Properties.ShowBorders = DevExpress.Utils.DefaultBoolean.False;
            // 
            // document3
            // 
            this.document3.Caption = "Locations";
            this.document3.ControlName = "ChoroplethMapItem";
            this.document3.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucChoroplethMapItem";
            this.document3.FreeLayoutHeight.UnitType = DevExpress.XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel;
            this.document3.FreeLayoutHeight.UnitValue = 230D;
            // 
            // document5
            // 
            this.document5.Caption = "Profit YTD";
            this.document5.ControlName = "CardWidget2";
            this.document5.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucCardWidget";
            this.document5.FreeLayoutWidth.UnitType = DevExpress.XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel;
            this.document5.FreeLayoutWidth.UnitValue = 220D;
            this.document5.Properties.AllowMaximize = DevExpress.Utils.DefaultBoolean.False;
            // 
            // document4
            // 
            this.document4.Caption = "Exprense YTD";
            this.document4.ControlName = "CardWidget1";
            this.document4.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucCardWidget";
            this.document4.FreeLayoutWidth.UnitType = DevExpress.XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel;
            this.document4.FreeLayoutWidth.UnitValue = 220D;
            this.document4.Properties.AllowMaximize = DevExpress.Utils.DefaultBoolean.False;
            // 
            // document6
            // 
            this.document6.Caption = "New Customers";
            this.document6.ControlName = "CardWidget3";
            this.document6.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucCardWidget";
            this.document6.FreeLayoutWidth.UnitType = DevExpress.XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel;
            this.document6.FreeLayoutWidth.UnitValue = 220D;
            this.document6.Properties.AllowMaximize = DevExpress.Utils.DefaultBoolean.False;
            // 
            // document7
            // 
            this.document7.Caption = "Market Share";
            this.document7.ControlName = "CardWidget4";
            this.document7.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucCardWidget";
            this.document7.FreeLayoutWidth.UnitType = DevExpress.XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel;
            this.document7.FreeLayoutWidth.UnitValue = 220D;
            this.document7.Properties.AllowMaximize = DevExpress.Utils.DefaultBoolean.False;
            // 
            // document8
            // 
            this.document8.Caption = "Avg Order Size";
            this.document8.ControlName = "CardWidget5";
            this.document8.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucCardWidget";
            this.document8.FreeLayoutWidth.UnitType = DevExpress.XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel;
            this.document8.FreeLayoutWidth.UnitValue = 220D;
            this.document8.Properties.AllowMaximize = DevExpress.Utils.DefaultBoolean.False;
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.ShowThumbnailsInTaskBar = DevExpress.Utils.DefaultBoolean.False;
            this.documentManager1.View = this.widgetView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.widgetView1});
            // 
            // widgetView1
            // 
            this.widgetView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.document1,
            this.document2,
            this.document3,
            this.document4,
            this.document5,
            this.document6,
            this.document7,
            this.document8,
            this.document9});
            this.widgetView1.FreeLayoutProperties.FreeLayoutItems.AddRange(new DevExpress.XtraBars.Docking2010.Views.Widget.Document[] {
            this.document1,
            this.document2,
            this.document3,
            this.document4,
            this.document5,
            this.document6,
            this.document7,
            this.document8,
            this.document9});
            this.widgetView1.FreeLayoutProperties.ItemDragStyle = DevExpress.XtraBars.Docking2010.Views.Widget.ItemDragStyle.DockingHints;
            this.widgetView1.LayoutMode = DevExpress.XtraBars.Docking2010.Views.Widget.LayoutMode.FreeLayout;
            this.widgetView1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            widgetDockingContainer2.Element = this.document9;
            widgetDockingContainer3.Element = this.document2;
            widgetDockingContainer1.Nodes.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer[] {
            widgetDockingContainer2,
            widgetDockingContainer3});
            widgetDockingContainer1.Orientation = System.Windows.Forms.Orientation.Vertical;
            widgetDockingContainer1.Size.Width.UnitType = DevExpress.XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel;
            widgetDockingContainer1.Size.Width.UnitValue = 260D;
            widgetDockingContainer5.Element = this.document1;
            widgetDockingContainer6.Element = this.document3;
            widgetDockingContainer4.Nodes.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer[] {
            widgetDockingContainer5,
            widgetDockingContainer6});
            widgetDockingContainer4.Orientation = System.Windows.Forms.Orientation.Vertical;
            widgetDockingContainer8.Element = this.document5;
            widgetDockingContainer9.Element = this.document4;
            widgetDockingContainer10.Element = this.document6;
            widgetDockingContainer11.Element = this.document7;
            widgetDockingContainer12.Element = this.document8;
            widgetDockingContainer7.Nodes.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer[] {
            widgetDockingContainer8,
            widgetDockingContainer9,
            widgetDockingContainer10,
            widgetDockingContainer11,
            widgetDockingContainer12});
            widgetDockingContainer7.Orientation = System.Windows.Forms.Orientation.Vertical;
            widgetDockingContainer7.Size.Width.UnitType = DevExpress.XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel;
            widgetDockingContainer7.Size.Width.UnitValue = 180D;
            this.widgetView1.RootContainer.Nodes.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer[] {
            widgetDockingContainer1,
            widgetDockingContainer4,
            widgetDockingContainer7});
            // 
            // DocumentManagerWidgetViewFreeLayout
            // 
            this.Name = "DocumentManagerWidgetViewFreeLayout";
            this.Size = new System.Drawing.Size(778, 409);
            ((System.ComponentModel.ISupportInitialize)(this.document9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widgetView1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
