namespace DevExpress.XtraGauges.Demos {
    partial class SysInfo {
        /// <summary> 
        /// Required designer variable.
        /// </summary>

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            System.Threading.WaitHandle notifyEvent = new System.Threading.EventWaitHandle(false, System.Threading.EventResetMode.AutoReset);
            System.Threading.Interlocked.Add(ref lockTimerCounter, 1);
            if(pollingTimer != null) {
                pollingTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                pollingTimer.Dispose(notifyEvent);
                pollingTimer = null;
            }
            System.Threading.WaitHandle.WaitAll(new System.Threading.WaitHandle[] { notifyEvent });
            if(wmiService != null) {
                wmiService.Dispose();
                wmiService = null;
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraGauges.Core.Model.ScaleLabel scaleLabel1 = new DevExpress.XtraGauges.Core.Model.ScaleLabel();
            DevExpress.XtraGauges.Core.Model.ScaleLabel scaleLabel2 = new DevExpress.XtraGauges.Core.Model.ScaleLabel();
            DevExpress.XtraGauges.Core.Model.ScaleLabel scaleLabel3 = new DevExpress.XtraGauges.Core.Model.ScaleLabel();
            DevExpress.XtraGauges.Core.Model.ScaleLabel scaleLabel4 = new DevExpress.XtraGauges.Core.Model.ScaleLabel();
            DevExpress.XtraGauges.Core.Model.ScaleLabel scaleLabel5 = new DevExpress.XtraGauges.Core.Model.ScaleLabel();
            DevExpress.XtraGauges.Core.Model.ScaleLabel scaleLabel6 = new DevExpress.XtraGauges.Core.Model.ScaleLabel();
            DevExpress.XtraGauges.Core.Model.ScaleLabel scaleLabel7 = new DevExpress.XtraGauges.Core.Model.ScaleLabel();
            DevExpress.XtraGauges.Core.Model.ScaleLabel scaleLabel8 = new DevExpress.XtraGauges.Core.Model.ScaleLabel();
            DevExpress.XtraGauges.Core.Model.ScaleLabel scaleLabel9 = new DevExpress.XtraGauges.Core.Model.ScaleLabel();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.updateSpeed = new DevExpress.XtraEditors.TrackBarControl();
            this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge1 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.arcScaleBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.arcScaleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleBackgroundLayerComponent2 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.arcScaleComponent4 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleBackgroundLayerComponent3 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.arcScaleComponent6 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleBackgroundLayerComponent4 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.arcScaleComponent7 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.labelComponent1 = new DevExpress.XtraGauges.Win.Base.LabelComponent();
            this.labelComponent2 = new DevExpress.XtraGauges.Win.Base.LabelComponent();
            this.arcScaleNeedleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleNeedleComponent2 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleNeedleComponent3 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleRangeBarComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent();
            this.arcScaleComponent2 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleRangeBarComponent2 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent();
            this.arcScaleComponent3 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleRangeBarComponent3 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent();
            this.arcScaleRangeBarComponent4 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent();
            this.arcScaleComponent5 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateSpeed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleRangeBarComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleRangeBarComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleRangeBarComponent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleRangeBarComponent4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.layoutControl1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 12);
            this.xtraScrollableControl1.Size = new System.Drawing.Size(552, 621);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.updateSpeed);
            this.layoutControl1.Controls.Add(this.gaugeControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 8);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(552, 601);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // updateSpeed
            // 
            this.updateSpeed.EditValue = null;
            this.updateSpeed.Location = new System.Drawing.Point(361, 555);
            this.updateSpeed.MaximumSize = new System.Drawing.Size(0, 32);
            this.updateSpeed.MinimumSize = new System.Drawing.Size(0, 32);
            this.updateSpeed.Name = "updateSpeed";
            this.updateSpeed.Size = new System.Drawing.Size(190, 32);
            this.updateSpeed.StyleController = this.layoutControl1;
            this.updateSpeed.TabIndex = 4;
            this.updateSpeed.EditValueChanged += new System.EventHandler(this.OnUpdateSpeedChanged);
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge1});
            this.gaugeControl1.Location = new System.Drawing.Point(1, 1);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(550, 542);
            this.gaugeControl1.TabIndex = 0;
            // 
            // circularGauge1
            // 
            this.circularGauge1.AutoSize = DevExpress.Utils.DefaultBoolean.False;
            this.circularGauge1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] {
            this.arcScaleBackgroundLayerComponent1,
            this.arcScaleBackgroundLayerComponent2,
            this.arcScaleBackgroundLayerComponent3,
            this.arcScaleBackgroundLayerComponent4});
            this.circularGauge1.Bounds = new System.Drawing.Rectangle(6, 6, 538, 530);
            this.circularGauge1.Labels.AddRange(new DevExpress.XtraGauges.Win.Base.LabelComponent[] {
            this.labelComponent1,
            this.labelComponent2});
            this.circularGauge1.Name = "circularGauge1";
            this.circularGauge1.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.arcScaleNeedleComponent1,
            this.arcScaleNeedleComponent2,
            this.arcScaleNeedleComponent3});
            this.circularGauge1.RangeBars.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent[] {
            this.arcScaleRangeBarComponent1,
            this.arcScaleRangeBarComponent2,
            this.arcScaleRangeBarComponent3,
            this.arcScaleRangeBarComponent4});
            this.circularGauge1.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScaleComponent1,
            this.arcScaleComponent2,
            this.arcScaleComponent3,
            this.arcScaleComponent4,
            this.arcScaleComponent5,
            this.arcScaleComponent6,
            this.arcScaleComponent7});
            // 
            // arcScaleBackgroundLayerComponent1
            // 
            this.arcScaleBackgroundLayerComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleBackgroundLayerComponent1.Name = "bgCPU";
            this.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style1;
            this.arcScaleBackgroundLayerComponent1.Size = new System.Drawing.SizeF(122F, 122F);
            this.arcScaleBackgroundLayerComponent1.ZOrder = -5;
            // 
            // arcScaleComponent1
            // 
            this.arcScaleComponent1.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceTickmarkText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 5F);
            this.arcScaleComponent1.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            this.arcScaleComponent1.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 75F);
            this.arcScaleComponent1.EndAngle = 60F;
            scaleLabel1.AppearanceText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 5F);
            scaleLabel1.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            scaleLabel1.FormatString = "{0} {1:F0}%";
            scaleLabel1.Name = "Label0";
            scaleLabel1.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 122F);
            scaleLabel1.Size = new System.Drawing.SizeF(100F, 12F);
            scaleLabel1.Text = "Total:";
            scaleLabel2.AppearanceText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 5F);
            scaleLabel2.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:DimGray");
            scaleLabel2.FormatString = "{0}";
            scaleLabel2.Name = "Label1";
            scaleLabel2.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 95F);
            scaleLabel2.Size = new System.Drawing.SizeF(50F, 12F);
            scaleLabel2.Text = "Kernel";
            scaleLabel3.AppearanceText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 5F);
            scaleLabel3.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:DarkGray");
            scaleLabel3.FormatString = "{0}";
            scaleLabel3.Name = "Label2";
            scaleLabel3.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 88F);
            scaleLabel3.Size = new System.Drawing.SizeF(50F, 12F);
            scaleLabel3.Text = "User";
            this.arcScaleComponent1.Labels.AddRange(new DevExpress.XtraGauges.Core.Model.ILabel[] {
            scaleLabel1,
            scaleLabel2,
            scaleLabel3});
            this.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent1.MajorTickmark.ShapeOffset = -2F;
            this.arcScaleComponent1.MajorTickmark.ShapeScale = new DevExpress.XtraGauges.Core.Base.FactorF2D(0.4F, 0.6F);
            this.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_4;
            this.arcScaleComponent1.MajorTickmark.TextOffset = -7F;
            this.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent1.MaxValue = 100F;
            this.arcScaleComponent1.MinorTickCount = 4;
            this.arcScaleComponent1.MinorTickmark.ShapeScale = new DevExpress.XtraGauges.Core.Base.FactorF2D(0.3F, 0.5F);
            this.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_3;
            this.arcScaleComponent1.Name = "cpuTotal";
            this.arcScaleComponent1.RadiusX = 50F;
            this.arcScaleComponent1.RadiusY = 50F;
            this.arcScaleComponent1.StartAngle = -240F;
            this.arcScaleComponent1.Value = 15F;
            this.arcScaleComponent1.ZOrder = -50;
            // 
            // arcScaleBackgroundLayerComponent2
            // 
            this.arcScaleBackgroundLayerComponent2.ArcScale = this.arcScaleComponent4;
            this.arcScaleBackgroundLayerComponent2.Name = "bgOS";
            this.arcScaleBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style1;
            this.arcScaleBackgroundLayerComponent2.Size = new System.Drawing.SizeF(100F, 100F);
            this.arcScaleBackgroundLayerComponent2.ZOrder = 1050;
            // 
            // arcScaleComponent4
            // 
            this.arcScaleComponent4.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent4.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent4.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent4.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent4.AppearanceTickmarkText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 4F);
            this.arcScaleComponent4.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            this.arcScaleComponent4.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 175F);
            this.arcScaleComponent4.EndAngle = 10F;
            scaleLabel4.AppearanceText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 4F);
            scaleLabel4.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            scaleLabel4.FormatString = "{0}{1:F0}";
            scaleLabel4.Name = "Label1";
            scaleLabel4.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 160F);
            scaleLabel4.Size = new System.Drawing.SizeF(50F, 12F);
            scaleLabel4.Text = "Threads:";
            this.arcScaleComponent4.Labels.AddRange(new DevExpress.XtraGauges.Core.Model.ILabel[] {
            scaleLabel4});
            this.arcScaleComponent4.MajorTickCount = 7;
            this.arcScaleComponent4.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent4.MajorTickmark.ShapeOffset = -1F;
            this.arcScaleComponent4.MajorTickmark.ShapeScale = new DevExpress.XtraGauges.Core.Base.FactorF2D(0.25F, 0.4F);
            this.arcScaleComponent4.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_4;
            this.arcScaleComponent4.MajorTickmark.TextOffset = -7F;
            this.arcScaleComponent4.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent4.MaxValue = 1300F;
            this.arcScaleComponent4.MinorTickCount = 4;
            this.arcScaleComponent4.MinorTickmark.ShapeScale = new DevExpress.XtraGauges.Core.Base.FactorF2D(0.3F, 0.5F);
            this.arcScaleComponent4.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_3;
            this.arcScaleComponent4.MinValue = 100F;
            this.arcScaleComponent4.Name = "osThreads";
            this.arcScaleComponent4.RadiusX = 40F;
            this.arcScaleComponent4.RadiusY = 40F;
            this.arcScaleComponent4.StartAngle = -190F;
            this.arcScaleComponent4.Value = 500F;
            // 
            // arcScaleBackgroundLayerComponent3
            // 
            this.arcScaleBackgroundLayerComponent3.ArcScale = this.arcScaleComponent6;
            this.arcScaleBackgroundLayerComponent3.Name = "bgMemory";
            this.arcScaleBackgroundLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style1;
            this.arcScaleBackgroundLayerComponent3.Size = new System.Drawing.SizeF(92F, 92F);
            this.arcScaleBackgroundLayerComponent3.ZOrder = 1000;
            // 
            // arcScaleComponent6
            // 
            this.arcScaleComponent6.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent6.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent6.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent6.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent6.AppearanceTickmarkText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 3F);
            this.arcScaleComponent6.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            this.arcScaleComponent6.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(45F, 135F);
            this.arcScaleComponent6.EndAngle = 60F;
            scaleLabel5.AppearanceText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 4F);
            scaleLabel5.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            scaleLabel5.FormatString = "{0} {2:P1}";
            scaleLabel5.Name = "Label0";
            scaleLabel5.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(50F, 150F);
            scaleLabel5.Size = new System.Drawing.SizeF(100F, 12F);
            scaleLabel5.Text = "Free:";
            scaleLabel6.AppearanceText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 4F);
            scaleLabel6.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C00000");
            scaleLabel6.FormatString = "{0}";
            scaleLabel6.Name = "Label1";
            scaleLabel6.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(50F, 125F);
            scaleLabel6.Text = "Memory, MB";
            this.arcScaleComponent6.Labels.AddRange(new DevExpress.XtraGauges.Core.Model.ILabel[] {
            scaleLabel5,
            scaleLabel6});
            this.arcScaleComponent6.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent6.MajorTickmark.ShapeOffset = -2F;
            this.arcScaleComponent6.MajorTickmark.ShapeScale = new DevExpress.XtraGauges.Core.Base.FactorF2D(0.2F, 0.3F);
            this.arcScaleComponent6.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_4;
            this.arcScaleComponent6.MajorTickmark.TextOffset = -7F;
            this.arcScaleComponent6.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent6.MaxValue = 100F;
            this.arcScaleComponent6.MinorTickCount = 4;
            this.arcScaleComponent6.MinorTickmark.ShapeScale = new DevExpress.XtraGauges.Core.Base.FactorF2D(0.15F, 0.25F);
            this.arcScaleComponent6.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_3;
            this.arcScaleComponent6.Name = "memoryTotal";
            this.arcScaleComponent6.RadiusX = 40F;
            this.arcScaleComponent6.RadiusY = 40F;
            this.arcScaleComponent6.StartAngle = -240F;
            this.arcScaleComponent6.Value = 15F;
            // 
            // arcScaleBackgroundLayerComponent4
            // 
            this.arcScaleBackgroundLayerComponent4.ArcScale = this.arcScaleComponent7;
            this.arcScaleBackgroundLayerComponent4.Name = "bgHDD";
            this.arcScaleBackgroundLayerComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style1;
            this.arcScaleBackgroundLayerComponent4.Size = new System.Drawing.SizeF(92F, 92F);
            this.arcScaleBackgroundLayerComponent4.ZOrder = 1000;
            // 
            // arcScaleComponent7
            // 
            this.arcScaleComponent7.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent7.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent7.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent7.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent7.AppearanceTickmarkText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 3F);
            this.arcScaleComponent7.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            this.arcScaleComponent7.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(205F, 135F);
            this.arcScaleComponent7.EndAngle = 60F;
            scaleLabel7.AppearanceText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 4F);
            scaleLabel7.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            scaleLabel7.FormatString = "{0} {2:P1}";
            scaleLabel7.Name = "Label0";
            scaleLabel7.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(205F, 150F);
            scaleLabel7.Size = new System.Drawing.SizeF(100F, 12F);
            scaleLabel7.Text = "Free:";
            scaleLabel8.AppearanceText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 4F);
            scaleLabel8.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C00000");
            scaleLabel8.FormatString = "{0}";
            scaleLabel8.Name = "Label1";
            scaleLabel8.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(205F, 125F);
            scaleLabel8.Text = "HDD, GB";
            this.arcScaleComponent7.Labels.AddRange(new DevExpress.XtraGauges.Core.Model.ILabel[] {
            scaleLabel7,
            scaleLabel8});
            this.arcScaleComponent7.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent7.MajorTickmark.ShapeOffset = -2F;
            this.arcScaleComponent7.MajorTickmark.ShapeScale = new DevExpress.XtraGauges.Core.Base.FactorF2D(0.2F, 0.3F);
            this.arcScaleComponent7.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_4;
            this.arcScaleComponent7.MajorTickmark.TextOffset = -7F;
            this.arcScaleComponent7.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent7.MaxValue = 100F;
            this.arcScaleComponent7.MinorTickCount = 4;
            this.arcScaleComponent7.MinorTickmark.ShapeScale = new DevExpress.XtraGauges.Core.Base.FactorF2D(0.15F, 0.25F);
            this.arcScaleComponent7.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_3;
            this.arcScaleComponent7.Name = "hddTotal";
            this.arcScaleComponent7.RadiusX = 40F;
            this.arcScaleComponent7.RadiusY = 40F;
            this.arcScaleComponent7.StartAngle = -240F;
            this.arcScaleComponent7.Value = 15F;
            // 
            // labelComponent1
            // 
            this.labelComponent1.AppearanceText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 4F);
            this.labelComponent1.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C00000");
            this.labelComponent1.Name = "processorName";
            this.labelComponent1.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 62F);
            this.labelComponent1.Size = new System.Drawing.SizeF(75F, 25F);
            this.labelComponent1.Text = "CPU Info";
            this.labelComponent1.ZOrder = -45;
            // 
            // labelComponent2
            // 
            this.labelComponent2.AppearanceText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 4F);
            this.labelComponent2.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C00000");
            this.labelComponent2.Name = "osName";
            this.labelComponent2.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 175F);
            this.labelComponent2.Size = new System.Drawing.SizeF(55F, 25F);
            this.labelComponent2.Text = "OS Info";
            this.labelComponent2.ZOrder = -2;
            // 
            // arcScaleNeedleComponent1
            // 
            this.arcScaleNeedleComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleNeedleComponent1.Name = "needleCpu";
            this.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style1;
            this.arcScaleNeedleComponent1.StartOffset = -2.75F;
            this.arcScaleNeedleComponent1.ZOrder = -50;
            // 
            // arcScaleNeedleComponent2
            // 
            this.arcScaleNeedleComponent2.ArcScale = this.arcScaleComponent6;
            this.arcScaleNeedleComponent2.Name = "needleRAM";
            this.arcScaleNeedleComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style1;
            this.arcScaleNeedleComponent2.StartOffset = -2.75F;
            this.arcScaleNeedleComponent2.ZOrder = -50;
            // 
            // arcScaleNeedleComponent3
            // 
            this.arcScaleNeedleComponent3.ArcScale = this.arcScaleComponent7;
            this.arcScaleNeedleComponent3.Name = "needleHDD";
            this.arcScaleNeedleComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style1;
            this.arcScaleNeedleComponent3.StartOffset = -2.75F;
            this.arcScaleNeedleComponent3.ZOrder = -50;
            // 
            // arcScaleRangeBarComponent1
            // 
            this.arcScaleRangeBarComponent1.AppearanceRangeBar.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver");
            this.arcScaleRangeBarComponent1.ArcScale = this.arcScaleComponent2;
            this.arcScaleRangeBarComponent1.EndOffset = 15F;
            this.arcScaleRangeBarComponent1.Name = "rangeUser";
            this.arcScaleRangeBarComponent1.StartOffset = 40F;
            this.arcScaleRangeBarComponent1.ZOrder = -10;
            // 
            // arcScaleComponent2
            // 
            this.arcScaleComponent2.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent2.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent2.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent2.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent2.AppearanceTickmarkText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 6F);
            this.arcScaleComponent2.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver");
            this.arcScaleComponent2.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 75F);
            this.arcScaleComponent2.EndAngle = 60F;
            this.arcScaleComponent2.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent2.MajorTickmark.ShapeOffset = -2F;
            this.arcScaleComponent2.MajorTickmark.ShapeScale = new DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 0.8F);
            this.arcScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_4;
            this.arcScaleComponent2.MajorTickmark.ShowText = false;
            this.arcScaleComponent2.MajorTickmark.ShowTick = false;
            this.arcScaleComponent2.MajorTickmark.TextOffset = -10F;
            this.arcScaleComponent2.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent2.MaxValue = 100F;
            this.arcScaleComponent2.MinorTickCount = 4;
            this.arcScaleComponent2.MinorTickmark.ShapeScale = new DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 1F);
            this.arcScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_3;
            this.arcScaleComponent2.MinorTickmark.ShowTick = false;
            this.arcScaleComponent2.Name = "cpuUser";
            this.arcScaleComponent2.RadiusX = 50F;
            this.arcScaleComponent2.RadiusY = 50F;
            this.arcScaleComponent2.StartAngle = -240F;
            this.arcScaleComponent2.Value = 15F;
            this.arcScaleComponent2.ZOrder = 1001;
            // 
            // arcScaleRangeBarComponent2
            // 
            this.arcScaleRangeBarComponent2.AppearanceRangeBar.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Gray");
            this.arcScaleRangeBarComponent2.ArcScale = this.arcScaleComponent3;
            this.arcScaleRangeBarComponent2.EndOffset = 15F;
            this.arcScaleRangeBarComponent2.Name = "rangeKernel";
            this.arcScaleRangeBarComponent2.StartOffset = 40F;
            this.arcScaleRangeBarComponent2.ZOrder = -11;
            // 
            // arcScaleComponent3
            // 
            this.arcScaleComponent3.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent3.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent3.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent3.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent3.AppearanceTickmarkText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 6F);
            this.arcScaleComponent3.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver");
            this.arcScaleComponent3.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 75F);
            this.arcScaleComponent3.EndAngle = 60F;
            this.arcScaleComponent3.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent3.MajorTickmark.ShapeOffset = -2F;
            this.arcScaleComponent3.MajorTickmark.ShapeScale = new DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 0.8F);
            this.arcScaleComponent3.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_4;
            this.arcScaleComponent3.MajorTickmark.ShowText = false;
            this.arcScaleComponent3.MajorTickmark.ShowTick = false;
            this.arcScaleComponent3.MajorTickmark.TextOffset = -10F;
            this.arcScaleComponent3.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent3.MaxValue = 100F;
            this.arcScaleComponent3.MinorTickCount = 4;
            this.arcScaleComponent3.MinorTickmark.ShapeScale = new DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 1F);
            this.arcScaleComponent3.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_3;
            this.arcScaleComponent3.MinorTickmark.ShowTick = false;
            this.arcScaleComponent3.Name = "cpuKernel";
            this.arcScaleComponent3.RadiusX = 50F;
            this.arcScaleComponent3.RadiusY = 50F;
            this.arcScaleComponent3.StartAngle = -240F;
            this.arcScaleComponent3.Value = 3F;
            this.arcScaleComponent3.ZOrder = 1002;
            // 
            // arcScaleRangeBarComponent3
            // 
            this.arcScaleRangeBarComponent3.AnchorValue = 100F;
            this.arcScaleRangeBarComponent3.AppearanceRangeBar.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver");
            this.arcScaleRangeBarComponent3.ArcScale = this.arcScaleComponent4;
            this.arcScaleRangeBarComponent3.EndOffset = -3F;
            this.arcScaleRangeBarComponent3.Name = "rangeThreads";
            this.arcScaleRangeBarComponent3.StartOffset = 35F;
            this.arcScaleRangeBarComponent3.ZOrder = 1;
            // 
            // arcScaleRangeBarComponent4
            // 
            this.arcScaleRangeBarComponent4.AppearanceRangeBar.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver");
            this.arcScaleRangeBarComponent4.ArcScale = this.arcScaleComponent5;
            this.arcScaleRangeBarComponent4.EndOffset = -2F;
            this.arcScaleRangeBarComponent4.Name = "rangeProcesses";
            this.arcScaleRangeBarComponent4.StartOffset = 35F;
            this.arcScaleRangeBarComponent4.ZOrder = 1;
            // 
            // arcScaleComponent5
            // 
            this.arcScaleComponent5.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent5.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent5.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent5.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent5.AppearanceTickmarkText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 3F);
            this.arcScaleComponent5.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            this.arcScaleComponent5.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 175F);
            this.arcScaleComponent5.EndAngle = 150F;
            scaleLabel9.AppearanceText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 4F);
            scaleLabel9.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            scaleLabel9.FormatString = "{0}{1:F0}";
            scaleLabel9.Name = "Label1";
            scaleLabel9.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 195F);
            scaleLabel9.Size = new System.Drawing.SizeF(50F, 12F);
            scaleLabel9.Text = "Processes:";
            this.arcScaleComponent5.Labels.AddRange(new DevExpress.XtraGauges.Core.Model.ILabel[] {
            scaleLabel9});
            this.arcScaleComponent5.MajorTickCount = 6;
            this.arcScaleComponent5.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent5.MajorTickmark.ShapeOffset = -1F;
            this.arcScaleComponent5.MajorTickmark.ShapeScale = new DevExpress.XtraGauges.Core.Base.FactorF2D(0.3F, 0.4F);
            this.arcScaleComponent5.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_2;
            this.arcScaleComponent5.MajorTickmark.TextOffset = -7F;
            this.arcScaleComponent5.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent5.MaxValue = 150F;
            this.arcScaleComponent5.MinorTickCount = 4;
            this.arcScaleComponent5.MinorTickmark.ShapeScale = new DevExpress.XtraGauges.Core.Base.FactorF2D(0.3F, 0.5F);
            this.arcScaleComponent5.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_1;
            this.arcScaleComponent5.Name = "osProcesses";
            this.arcScaleComponent5.RadiusX = 40F;
            this.arcScaleComponent5.RadiusY = 40F;
            this.arcScaleComponent5.StartAngle = 30F;
            this.arcScaleComponent5.Value = 50F;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(552, 601);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gaugeControl1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutControlItem1.Size = new System.Drawing.Size(552, 544);
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 544);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(276, 57);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.updateSpeed;
            this.layoutControlItem2.CustomizationFormText = "Update Speed:";
            this.layoutControlItem2.Location = new System.Drawing.Point(276, 544);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 11, 1);
            this.layoutControlItem2.Size = new System.Drawing.Size(276, 57);
            this.layoutControlItem2.Text = "Update Speed:";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(72, 13);
            // 
            // SysInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "SysInfo";
            this.Size = new System.Drawing.Size(552, 621);
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.updateSpeed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleRangeBarComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleRangeBarComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleRangeBarComponent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleRangeBarComponent4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.TrackBarControl updateSpeed;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent4;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent3;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent6;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent4;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent7;
        private DevExpress.XtraGauges.Win.Base.LabelComponent labelComponent1;
        private DevExpress.XtraGauges.Win.Base.LabelComponent labelComponent2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent3;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent arcScaleRangeBarComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent arcScaleRangeBarComponent2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent3;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent arcScaleRangeBarComponent3;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent arcScaleRangeBarComponent4;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent5;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
    }
}
