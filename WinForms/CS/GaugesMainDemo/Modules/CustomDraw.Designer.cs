namespace DevExpress.XtraGauges.Demos {
    partial class CustomDrawFeature {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ceAllowCustomDraw = new DevExpress.XtraEditors.CheckEdit();
            this.gaugeControl2 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.linearGauge1 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge();
            this.linearScaleBackgroundLayer = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent();
            this.linearScale = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent();
            this.linearScaleLevel = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent();
            this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge1 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.arcScaleBackgroundLayer = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.arcScale = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleNeedle = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowCustomDraw.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleBackgroundLayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ceAllowCustomDraw);
            this.layoutControl1.Controls.Add(this.gaugeControl2);
            this.layoutControl1.Controls.Add(this.gaugeControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(601, 480);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ceAllowCustomDraw
            // 
            this.ceAllowCustomDraw.Location = new System.Drawing.Point(12, 12);
            this.ceAllowCustomDraw.Name = "ceAllowCustomDraw";
            this.ceAllowCustomDraw.Properties.Caption = "Handle CustomDraw events";
            this.ceAllowCustomDraw.Size = new System.Drawing.Size(577, 20);
            this.ceAllowCustomDraw.StyleController = this.layoutControl1;
            this.ceAllowCustomDraw.TabIndex = 6;
            this.ceAllowCustomDraw.CheckedChanged += new System.EventHandler(this.ceAllowCustomDraw_CheckedChanged);
            // 
            // gaugeControl2
            // 
            this.gaugeControl2.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.linearGauge1});
            this.gaugeControl2.LayoutPadding = new DevExpress.XtraGauges.Core.Base.Thickness(25);
            this.gaugeControl2.Location = new System.Drawing.Point(302, 36);
            this.gaugeControl2.Name = "gaugeControl2";
            this.gaugeControl2.Size = new System.Drawing.Size(287, 432);
            this.gaugeControl2.TabIndex = 5;
            // 
            // linearGauge1
            // 
            this.linearGauge1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent[] {
            this.linearScaleBackgroundLayer});
            this.linearGauge1.Bounds = new System.Drawing.Rectangle(25, 25, 237, 382);
            this.linearGauge1.Levels.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent[] {
            this.linearScaleLevel});
            this.linearGauge1.Name = "linearGauge1";
            this.linearGauge1.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent[] {
            this.linearScale});
            // 
            // linearScaleBackgroundLayer
            // 
            this.linearScaleBackgroundLayer.LinearScale = this.linearScale;
            this.linearScaleBackgroundLayer.Name = "Gauge0_BackgroundLayer1";
            this.linearScaleBackgroundLayer.ZOrder = 1000;
            // 
            // linearScale
            // 
            this.linearScale.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScale.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScale.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScale.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScale.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            this.linearScale.EndPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 35F);
            this.linearScale.MajorTickCount = 6;
            this.linearScale.MajorTickmark.FormatString = "{0:F0}";
            this.linearScale.MajorTickmark.ShapeOffset = -20F;
            this.linearScale.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_1;
            this.linearScale.MajorTickmark.TextOffset = -32F;
            this.linearScale.MaxValue = 100F;
            this.linearScale.MinorTickCount = 4;
            this.linearScale.MinorTickmark.ShapeOffset = -14F;
            this.linearScale.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_2;
            this.linearScale.Name = "Gauge0_Scale1";
            this.linearScale.StartPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 215F);
            // 
            // linearScaleLevel
            // 
            this.linearScaleLevel.LinearScale = this.linearScale;
            this.linearScaleLevel.Name = "Gauge0_Level1";
            this.linearScaleLevel.ZOrder = -50;
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge1});
            this.gaugeControl1.LayoutPadding = new DevExpress.XtraGauges.Core.Base.Thickness(25);
            this.gaugeControl1.Location = new System.Drawing.Point(12, 36);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(286, 432);
            this.gaugeControl1.TabIndex = 4;
            // 
            // circularGauge1
            // 
            this.circularGauge1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] {
            this.arcScaleBackgroundLayer});
            this.circularGauge1.Bounds = new System.Drawing.Rectangle(25, 25, 236, 382);
            this.circularGauge1.Name = "circularGauge1";
            this.circularGauge1.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.arcScaleNeedle});
            this.circularGauge1.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScale});
            // 
            // arcScaleBackgroundLayer
            // 
            this.arcScaleBackgroundLayer.ArcScale = this.arcScale;
            this.arcScaleBackgroundLayer.Name = "Gauge0_BackgroundLayer1";
            this.arcScaleBackgroundLayer.ZOrder = 1000;
            // 
            // arcScale
            // 
            this.arcScale.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScale.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScale.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScale.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScale.AppearanceTickmarkText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 11F);
            this.arcScale.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            this.arcScale.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F);
            this.arcScale.EndAngle = 60F;
            this.arcScale.MajorTickmark.FormatString = "{0:F0}";
            this.arcScale.MajorTickmark.ShapeOffset = -3.5F;
            this.arcScale.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_4;
            this.arcScale.MajorTickmark.TextOffset = -15F;
            this.arcScale.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScale.MaxValue = 100F;
            this.arcScale.MinorTickCount = 4;
            this.arcScale.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_3;
            this.arcScale.Name = "Gauge0_Scale1";
            this.arcScale.StartAngle = -240F;
            this.arcScale.Value = 50F;
            // 
            // arcScaleNeedle
            // 
            this.arcScaleNeedle.ArcScale = this.arcScale;
            this.arcScaleNeedle.Name = "Gauge0_Needle1";
            this.arcScaleNeedle.StartOffset = -4.4F;
            this.arcScaleNeedle.ZOrder = -50;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(601, 480);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gaugeControl1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(290, 436);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gaugeControl2;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(290, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(291, 436);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ceAllowCustomDraw;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(581, 24);
            this.layoutControlItem3.TextVisible = false;
            // 
            // CustomDrawFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "CustomDrawFeature";
            this.Size = new System.Drawing.Size(601, 480);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowCustomDraw.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleBackgroundLayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl2;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge linearGauge1;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent linearScaleBackgroundLayer;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent linearScale;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent linearScaleLevel;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayer;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScale;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedle;
        private DevExpress.XtraEditors.CheckEdit ceAllowCustomDraw;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}
