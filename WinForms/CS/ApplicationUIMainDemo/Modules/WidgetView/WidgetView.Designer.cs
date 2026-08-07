
namespace DevExpress.ApplicationUI.Demos {
    partial class WidgetView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        #region Windows Designer generated code

        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.widgetView1 = new DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView(this.components);
            this.document1 = new DevExpress.XtraBars.Docking2010.Views.Widget.Document(this.components);
            this.document2 = new DevExpress.XtraBars.Docking2010.Views.Widget.Document(this.components);
            this.document3 = new DevExpress.XtraBars.Docking2010.Views.Widget.Document(this.components);
            this.document4 = new DevExpress.XtraBars.Docking2010.Views.Widget.Document(this.components);
            this.document5 = new DevExpress.XtraBars.Docking2010.Views.Widget.Document(this.components);
            this.document6 = new DevExpress.XtraBars.Docking2010.Views.Widget.Document(this.components);
            this.document7 = new DevExpress.XtraBars.Docking2010.Views.Widget.Document(this.components);
            this.document8 = new DevExpress.XtraBars.Docking2010.Views.Widget.Document(this.components);
            this.stackGroup1 = new DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup(this.components);
            this.stackGroup2 = new DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup(this.components);
            this.stackGroup3 = new DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widgetView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackGroup3)).BeginInit();
            this.SuspendLayout();
            // 
            // documentManager
            // 
            this.documentManager.ContainerControl = this;
            this.documentManager.View = this.widgetView1;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
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
            this.document8});
            this.widgetView1.RootContainer.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.widgetView1.StackGroups.AddRange(new DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup[] {
            this.stackGroup1,
            this.stackGroup2,
            this.stackGroup3});
            // 
            // document1
            // 
            this.document1.Caption = "AAPL";
            this.document1.ControlName = "document1";
            this.document1.Height = 150;
            // 
            // document2
            // 
            this.document2.Caption = "YHOO";
            this.document2.ControlName = "document2";
            this.document2.Height = 150;
            // 
            // document3
            // 
            this.document3.Caption = "CSCO";
            this.document3.ControlName = "document3";
            this.document3.Height = 150;
            // 
            // document4
            // 
            this.document4.Caption = "ADBE";
            this.document4.ControlName = "document4";
            this.document4.Height = 150;
            // 
            // document5
            // 
            this.document5.Caption = "BAC";
            this.document5.ControlName = "document5";
            this.document5.Height = 150;
            // 
            // document6
            // 
            this.document6.Caption = "DELL";
            this.document6.ControlName = "document6";
            this.document6.Height = 150;
            // 
            // document7
            // 
            this.document7.Caption = "NVDA";
            this.document7.ControlName = "document7";
            this.document7.Height = 150;
            // 
            // document8
            // 
            this.document8.Caption = "HPQ";
            this.document8.ControlName = "document8";
            this.document8.Height = 150;
            // 
            // stackGroup1
            // 
            this.stackGroup1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Widget.Document[] {
            this.document1,
            this.document5,
            this.document7});
            this.stackGroup1.Length.UnitType = DevExpress.XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel;
            this.stackGroup1.Length.UnitValue = 200D;
            // 
            // stackGroup2
            // 
            this.stackGroup2.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Widget.Document[] {
            this.document2,
            this.document3,
            this.document8});
            this.stackGroup2.Length.UnitType = DevExpress.XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel;
            this.stackGroup2.Length.UnitValue = 200D;
            // 
            // stackGroup3
            // 
            this.stackGroup3.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Widget.Document[] {
            this.document4,
            this.document6});
            this.stackGroup3.Length.UnitType = DevExpress.XtraBars.Docking2010.Views.Widget.LengthUnitType.Pixel;
            this.stackGroup3.Length.UnitValue = 200D;
            // 
            // WidgetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WidgetView";
            this.Size = new System.Drawing.Size(620, 479);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widgetView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackGroup3)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;

        private DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView widgetView1;
        private DevExpress.XtraBars.Docking2010.Views.Widget.Document document1;
        private DevExpress.XtraBars.Docking2010.Views.Widget.Document document2;
        private DevExpress.XtraBars.Docking2010.Views.Widget.Document document3;
        private DevExpress.XtraBars.Docking2010.Views.Widget.Document document4;
        private DevExpress.XtraBars.Docking2010.Views.Widget.Document document5;
        private DevExpress.XtraBars.Docking2010.Views.Widget.Document document6;
        private DevExpress.XtraBars.Docking2010.Views.Widget.Document document7;
        private DevExpress.XtraBars.Docking2010.Views.Widget.Document document8;
        private DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup stackGroup1;
        private DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup stackGroup2;
        private DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup stackGroup3;
        private System.ComponentModel.IContainer components;
    }
}
