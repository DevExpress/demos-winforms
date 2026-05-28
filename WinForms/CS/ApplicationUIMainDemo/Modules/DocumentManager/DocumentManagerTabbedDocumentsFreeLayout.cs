using System;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views;

namespace DevExpress.ApplicationUI.Demos {
    public partial class DocumentManagerTabbedDocumentsFreeLayout : TabbedViewTutorialControl {
        #region Windows Form Designer generated code
        private XtraBars.Docking2010.DocumentManager documentManager1;
        private XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private System.ComponentModel.IContainer components;
        private XtraBars.Docking2010.Views.Tabbed.DocumentGroup documentGroup1;
        private XtraBars.Docking2010.Views.Tabbed.Document document1;
        private XtraBars.Docking2010.Views.Tabbed.Document document2;
        private XtraBars.Docking2010.Views.Tabbed.Document document3;
        private XtraBars.Docking2010.Views.Tabbed.DocumentGroup documentGroup2;
        private XtraBars.Docking2010.Views.Tabbed.Document document4;
        private XtraBars.Docking2010.Views.Tabbed.Document document5;
        private XtraBars.Docking2010.Views.Tabbed.DocumentGroup documentGroup4;
        private XtraBars.Docking2010.Views.Tabbed.DocumentGroup documentGroup5;
        private XtraBars.Docking2010.Views.Tabbed.DocumentGroup documentGroup7;
        private XtraBars.BarAndDockingController barAndDockingController1;
        
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer dockingContainer1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer();
            DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer dockingContainer2 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer();
            DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer dockingContainer3 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer();
            DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer dockingContainer4 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer();
            DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer dockingContainer5 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer();
            DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer dockingContainer6 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer();
            DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer dockingContainer7 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer();
            this.documentGroup4 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(this.components);
            this.document4 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.documentGroup5 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(this.components);
            this.document5 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.documentGroup7 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(this.components);
            this.document3 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.documentGroup1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(this.components);
            this.document1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.documentGroup2 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(this.components);
            this.document2 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // documentGroup4
            // 
            this.documentGroup4.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document[] {
            this.document4});
            // 
            // document4
            // 
            this.document4.Caption = "Clock";
            this.document4.ControlName = "Clock";
            this.document4.ControlTypeName = "DevExpress.ApplicationUI.Demos.Clock";
            // 
            // documentGroup5
            // 
            this.documentGroup5.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document[] {
            this.document5});
            // 
            // document5
            // 
            this.document5.Caption = "Calendar";
            this.document5.ControlName = "Calendar";
            this.document5.ControlTypeName = "DevExpress.ApplicationUI.Demos.Calendar";
            // 
            // documentGroup7
            // 
            this.documentGroup7.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document[] {
            this.document3});
            // 
            // document3
            // 
            this.document3.Caption = "Sales";
            this.document3.ControlName = "Sales";
            this.document3.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucCategorySales";
            // 
            // documentGroup1
            // 
            this.documentGroup1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document[] {
            this.document1});
            // 
            // document1
            // 
            this.document1.Caption = "Products";
            this.document1.ControlName = "document1";
            this.document1.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucProductsGrid";
            // 
            // documentGroup2
            // 
            this.documentGroup2.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document[] {
            this.document2});
            // 
            // document2
            // 
            this.document2.Caption = "Locations";
            this.document2.ControlName = "ChoropletMapItem";
            this.document2.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucChoroplethMapItem";
            // 
            // tabbedView1
            // 
            this.tabbedView1.DocumentGroups.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup[] {
            this.documentGroup1,
            this.documentGroup2,
            this.documentGroup4,
            this.documentGroup5,
            this.documentGroup7});
            this.tabbedView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.document1,
            this.document2,
            this.document3,
            this.document4,
            this.document5});
            this.tabbedView1.EnableFreeLayoutMode = DevExpress.Utils.DefaultBoolean.True;
            dockingContainer1.Length.UnitValue = 0.62267099719482488D;
            dockingContainer2.Element = this.documentGroup4;
            dockingContainer2.Length.UnitValue = 0.4821805394648605D;
            dockingContainer3.Element = this.documentGroup5;
            dockingContainer3.Length.UnitValue = 1.3723427353315503D;
            dockingContainer4.Element = this.documentGroup7;
            dockingContainer4.Length.UnitValue = 1.1454767252035896D;
            dockingContainer1.Nodes.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer[] {
            dockingContainer2,
            dockingContainer3,
            dockingContainer4});
            dockingContainer1.Orientation = System.Windows.Forms.Orientation.Vertical;
            dockingContainer5.Length.UnitValue = 1.7054427658400548D;
            dockingContainer6.Element = this.documentGroup1;
            dockingContainer6.Length.UnitValue = 1.2481231810106879D;
            dockingContainer7.Element = this.documentGroup2;
            dockingContainer7.Length.UnitValue = 0.7518768189893118D;
            dockingContainer5.Nodes.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer[] {
            dockingContainer6,
            dockingContainer7});
            dockingContainer5.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tabbedView1.RootContainer.Nodes.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer[] {
            dockingContainer1,
            dockingContainer5});
            // 
            // documentManager1
            // 
            this.documentManager1.BarAndDockingController = this.barAndDockingController1;
            this.documentManager1.ContainerControl = this;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // DocumentManagerTabbedDocumentsFreeLayout
            // 
            this.Name = "DocumentManagerTabbedDocumentsFreeLayout";
            this.Size = new System.Drawing.Size(869, 624);
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        public DocumentManagerTabbedDocumentsFreeLayout() {
            InitializeComponent();
            documentManager1.View.QueryControl += OnQueryControl;
        }
        protected override int TakeScreenDelay => 300;
        void OnQueryControl(object sender, QueryControlEventArgs e) {
            string typeName = e.Document.ControlTypeName;
            if(!string.IsNullOrEmpty(typeName)) {
                var controlType = Data.Internal.SafeTypeResolver.GetKnownType(typeof(Program).Assembly, typeName);
                e.Control = Activator.CreateInstance(controlType) as Control;
            }
            else e.Control = new Control();
        }
    }
}
