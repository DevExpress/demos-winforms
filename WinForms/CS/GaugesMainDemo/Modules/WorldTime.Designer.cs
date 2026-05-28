namespace DevExpress.XtraGauges.Demos {
    partial class WorldTime {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                lockTimerCounter++;
                if(timer != null) {
                    timer.Stop();
                    timer.Dispose();
                    timer = null;
                }
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGauges.Core.Model.ScaleLabel scaleLabel1 = new DevExpress.XtraGauges.Core.Model.ScaleLabel();
            DevExpress.XtraGauges.Core.Model.ScaleLabel scaleLabel2 = new DevExpress.XtraGauges.Core.Model.ScaleLabel();
            DevExpress.XtraGauges.Core.Model.ScaleLabel scaleLabel3 = new DevExpress.XtraGauges.Core.Model.ScaleLabel();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState1 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState2 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState3 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleLabel scaleLabel4 = new DevExpress.XtraGauges.Core.Model.ScaleLabel();
            DevExpress.XtraGauges.Core.Model.ScaleLabel scaleLabel5 = new DevExpress.XtraGauges.Core.Model.ScaleLabel();
            DevExpress.XtraGauges.Core.Model.ScaleLabel scaleLabel6 = new DevExpress.XtraGauges.Core.Model.ScaleLabel();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState4 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState5 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState6 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleLabel scaleLabel7 = new DevExpress.XtraGauges.Core.Model.ScaleLabel();
            DevExpress.XtraGauges.Core.Model.ScaleLabel scaleLabel8 = new DevExpress.XtraGauges.Core.Model.ScaleLabel();
            DevExpress.XtraGauges.Core.Model.ScaleLabel scaleLabel9 = new DevExpress.XtraGauges.Core.Model.ScaleLabel();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState7 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState8 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState9 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleLabel scaleLabel10 = new DevExpress.XtraGauges.Core.Model.ScaleLabel();
            DevExpress.XtraGauges.Core.Model.ScaleLabel scaleLabel11 = new DevExpress.XtraGauges.Core.Model.ScaleLabel();
            DevExpress.XtraGauges.Core.Model.ScaleLabel scaleLabel12 = new DevExpress.XtraGauges.Core.Model.ScaleLabel();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState10 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState11 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState12 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleLabel scaleLabel13 = new DevExpress.XtraGauges.Core.Model.ScaleLabel();
            DevExpress.XtraGauges.Core.Model.ScaleLabel scaleLabel14 = new DevExpress.XtraGauges.Core.Model.ScaleLabel();
            DevExpress.XtraGauges.Core.Model.ScaleLabel scaleLabel15 = new DevExpress.XtraGauges.Core.Model.ScaleLabel();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState13 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState14 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState15 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleLabel scaleLabel16 = new DevExpress.XtraGauges.Core.Model.ScaleLabel();
            DevExpress.XtraGauges.Core.Model.ScaleLabel scaleLabel17 = new DevExpress.XtraGauges.Core.Model.ScaleLabel();
            DevExpress.XtraGauges.Core.Model.ScaleLabel scaleLabel18 = new DevExpress.XtraGauges.Core.Model.ScaleLabel();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState16 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            DevExpress.XtraGauges.Core.Model.ScaleIndicatorState scaleIndicatorState17 = new DevExpress.XtraGauges.Core.Model.ScaleIndicatorState();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Rome = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge6 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.arcScaleBackgroundLayerComponent6 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.arcScaleComponent16 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleEffectLayerComponent6 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent();
            this.arcScaleStateIndicatorComponent16 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent();
            this.arcScaleStateIndicatorComponent17 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent();
            this.arcScaleStateIndicatorComponent18 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent();
            this.arcScaleNeedleComponent16 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleNeedleComponent17 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleComponent17 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleNeedleComponent18 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleComponent18 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleSpindleCapComponent6 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent();
            this.Moscow = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge5 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.arcScaleBackgroundLayerComponent5 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.arcScaleComponent13 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleEffectLayerComponent5 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent();
            this.arcScaleStateIndicatorComponent13 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent();
            this.arcScaleStateIndicatorComponent14 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent();
            this.arcScaleStateIndicatorComponent15 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent();
            this.arcScaleNeedleComponent13 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleNeedleComponent14 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleComponent14 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleNeedleComponent15 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleComponent15 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleSpindleCapComponent5 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent();
            this.Paris = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge4 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.arcScaleBackgroundLayerComponent4 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.arcScaleComponent10 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleEffectLayerComponent4 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent();
            this.arcScaleStateIndicatorComponent10 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent();
            this.arcScaleStateIndicatorComponent11 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent();
            this.arcScaleStateIndicatorComponent12 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent();
            this.arcScaleNeedleComponent10 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleNeedleComponent11 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleComponent11 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleNeedleComponent12 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleComponent12 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleSpindleCapComponent4 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent();
            this.Tokyo = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge3 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.arcScaleBackgroundLayerComponent3 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.arcScaleComponent7 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleEffectLayerComponent3 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent();
            this.arcScaleStateIndicatorComponent7 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent();
            this.arcScaleStateIndicatorComponent8 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent();
            this.arcScaleStateIndicatorComponent9 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent();
            this.arcScaleNeedleComponent7 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleNeedleComponent8 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleComponent8 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleNeedleComponent9 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleComponent9 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleSpindleCapComponent3 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent();
            this.London = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge2 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.arcScaleBackgroundLayerComponent2 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.arcScaleComponent4 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleEffectLayerComponent2 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent();
            this.arcScaleStateIndicatorComponent4 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent();
            this.arcScaleStateIndicatorComponent5 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent();
            this.arcScaleStateIndicatorComponent6 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent();
            this.arcScaleNeedleComponent4 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleNeedleComponent5 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleComponent5 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleNeedleComponent6 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleComponent6 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleSpindleCapComponent2 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent();
            this.Washington = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge1 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.arcScaleBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.arcScaleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleEffectLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent();
            this.arcScaleStateIndicatorComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent();
            this.arcScaleStateIndicatorComponent2 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent();
            this.arcScaleNeedleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleNeedleComponent2 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleComponent2 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleNeedleComponent3 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleComponent3 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleSpindleCapComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleEffectLayerComponent6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleEffectLayerComponent5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleEffectLayerComponent4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleEffectLayerComponent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleEffectLayerComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleEffectLayerComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.Rome);
            this.layoutControl1.Controls.Add(this.Moscow);
            this.layoutControl1.Controls.Add(this.Paris);
            this.layoutControl1.Controls.Add(this.Tokyo);
            this.layoutControl1.Controls.Add(this.London);
            this.layoutControl1.Controls.Add(this.Washington);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(687, 593);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Rome
            // 
            this.Rome.BackColor = System.Drawing.Color.Transparent;
            this.Rome.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Rome.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge6});
            this.Rome.Location = new System.Drawing.Point(459, 297);
            this.Rome.Name = "Rome";
            this.Rome.Size = new System.Drawing.Size(220, 288);
            this.Rome.TabIndex = 8;
            // 
            // circularGauge6
            // 
            this.circularGauge6.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] {
            this.arcScaleBackgroundLayerComponent6});
            this.circularGauge6.Bounds = new System.Drawing.Rectangle(6, 6, 208, 276);
            this.circularGauge6.EffectLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent[] {
            this.arcScaleEffectLayerComponent6});
            this.circularGauge6.Indicators.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent[] {
            this.arcScaleStateIndicatorComponent16,
            this.arcScaleStateIndicatorComponent17,
            this.arcScaleStateIndicatorComponent18});
            this.circularGauge6.Name = "circularGauge6";
            this.circularGauge6.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.arcScaleNeedleComponent16,
            this.arcScaleNeedleComponent17,
            this.arcScaleNeedleComponent18});
            this.circularGauge6.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScaleComponent16,
            this.arcScaleComponent17,
            this.arcScaleComponent18});
            this.circularGauge6.SpindleCaps.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent[] {
            this.arcScaleSpindleCapComponent6});
            // 
            // arcScaleBackgroundLayerComponent6
            // 
            this.arcScaleBackgroundLayerComponent6.ArcScale = this.arcScaleComponent16;
            this.arcScaleBackgroundLayerComponent6.Name = "arcScaleBackgroundLayerComponent6";
            this.arcScaleBackgroundLayerComponent6.ScaleCenterPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.504F, 0.436F);
            this.arcScaleBackgroundLayerComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_WorldTimeClock;
            this.arcScaleBackgroundLayerComponent6.Size = new System.Drawing.SizeF(216F, 250F);
            this.arcScaleBackgroundLayerComponent6.ZOrder = 1000;
            // 
            // arcScaleComponent16
            // 
            this.arcScaleComponent16.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent16.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent16.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent16.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent16.AppearanceTickmarkText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 10F);
            this.arcScaleComponent16.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            this.arcScaleComponent16.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F);
            this.arcScaleComponent16.EndAngle = 270F;
            scaleLabel1.AppearanceText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 8F);
            scaleLabel1.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            scaleLabel1.FormatString = "{0}";
            scaleLabel1.Name = "Label0";
            scaleLabel1.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 135F);
            scaleLabel1.Size = new System.Drawing.SizeF(70F, 20F);
            scaleLabel1.Text = "Rome";
            scaleLabel2.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            scaleLabel2.FormatString = "{0}";
            scaleLabel2.Name = "Label1";
            scaleLabel2.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(75F, 238F);
            scaleLabel2.Size = new System.Drawing.SizeF(50F, 15F);
            scaleLabel2.Text = "Italy";
            scaleLabel3.AppearanceText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 12F);
            scaleLabel3.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            scaleLabel3.FormatString = "{0:F4}";
            scaleLabel3.Name = "Label2";
            scaleLabel3.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(160F, 225F);
            scaleLabel3.Size = new System.Drawing.SizeF(70F, 20F);
            scaleLabel3.Text = "73.142";
            this.arcScaleComponent16.Labels.AddRange(new DevExpress.XtraGauges.Core.Model.ILabel[] {
            scaleLabel1,
            scaleLabel2,
            scaleLabel3});
            this.arcScaleComponent16.MajorTickCount = 13;
            this.arcScaleComponent16.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent16.MajorTickmark.ShapeOffset = -9.5F;
            this.arcScaleComponent16.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_2;
            this.arcScaleComponent16.MajorTickmark.ShowFirst = false;
            this.arcScaleComponent16.MajorTickmark.TextOffset = -18F;
            this.arcScaleComponent16.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent16.MaxValue = 12F;
            this.arcScaleComponent16.MinorTickCount = 4;
            this.arcScaleComponent16.MinorTickmark.ShapeOffset = -1.5F;
            this.arcScaleComponent16.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_5;
            this.arcScaleComponent16.Name = "arcScaleComponent16";
            this.arcScaleComponent16.RadiusX = 74F;
            this.arcScaleComponent16.RadiusY = 74F;
            this.arcScaleComponent16.StartAngle = -90F;
            // 
            // arcScaleEffectLayerComponent6
            // 
            this.arcScaleEffectLayerComponent6.ArcScale = this.arcScaleComponent16;
            this.arcScaleEffectLayerComponent6.Name = "arcScaleEffectLayerComponent6";
            this.arcScaleEffectLayerComponent6.ScaleCenterPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 1F);
            this.arcScaleEffectLayerComponent6.Shader = new DevExpress.XtraGauges.Core.Drawing.OpacityShader("Opacity[0.7]");
            this.arcScaleEffectLayerComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Clock;
            this.arcScaleEffectLayerComponent6.Size = new System.Drawing.SizeF(170F, 85F);
            this.arcScaleEffectLayerComponent6.ZOrder = -1000;
            // 
            // arcScaleStateIndicatorComponent16
            // 
            this.arcScaleStateIndicatorComponent16.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(75F, 218F);
            this.arcScaleStateIndicatorComponent16.IndicatorScale = this.arcScaleComponent16;
            this.arcScaleStateIndicatorComponent16.Name = "arcScaleStateIndicatorComponent16";
            this.arcScaleStateIndicatorComponent16.Size = new System.Drawing.SizeF(40F, 21F);
            scaleIndicatorState1.IntervalLength = 12F;
            scaleIndicatorState1.Name = "Default";
            scaleIndicatorState1.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.FlagItaly;
            this.arcScaleStateIndicatorComponent16.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            scaleIndicatorState1});
            this.arcScaleStateIndicatorComponent16.ZOrder = -100;
            // 
            // arcScaleStateIndicatorComponent17
            // 
            this.arcScaleStateIndicatorComponent17.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(118F, 223F);
            this.arcScaleStateIndicatorComponent17.IndicatorScale = this.arcScaleComponent16;
            this.arcScaleStateIndicatorComponent17.Name = "arcScaleStateIndicatorComponent17";
            this.arcScaleStateIndicatorComponent17.Shader = new DevExpress.XtraGauges.Core.Drawing.GrayShader("");
            this.arcScaleStateIndicatorComponent17.Size = new System.Drawing.SizeF(20F, 20F);
            scaleIndicatorState2.IntervalLength = 12F;
            scaleIndicatorState2.Name = "Default";
            scaleIndicatorState2.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.CurrencyEUR;
            this.arcScaleStateIndicatorComponent17.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            scaleIndicatorState2});
            this.arcScaleStateIndicatorComponent17.ZOrder = -100;
            // 
            // arcScaleStateIndicatorComponent18
            // 
            this.arcScaleStateIndicatorComponent18.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(195F, 223F);
            this.arcScaleStateIndicatorComponent18.IndicatorScale = this.arcScaleComponent16;
            this.arcScaleStateIndicatorComponent18.Name = "arcScaleStateIndicatorComponent18";
            this.arcScaleStateIndicatorComponent18.Size = new System.Drawing.SizeF(15F, 15F);
            scaleIndicatorState3.IntervalLength = 12F;
            scaleIndicatorState3.Name = "Default";
            scaleIndicatorState3.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Arrow1;
            this.arcScaleStateIndicatorComponent18.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            scaleIndicatorState3});
            this.arcScaleStateIndicatorComponent18.ZOrder = -100;
            // 
            // arcScaleNeedleComponent16
            // 
            this.arcScaleNeedleComponent16.ArcScale = this.arcScaleComponent16;
            this.arcScaleNeedleComponent16.EndOffset = 10F;
            this.arcScaleNeedleComponent16.Name = "arcScaleNeedleComponent16";
            this.arcScaleNeedleComponent16.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockHour;
            this.arcScaleNeedleComponent16.ZOrder = -50;
            // 
            // arcScaleNeedleComponent17
            // 
            this.arcScaleNeedleComponent17.ArcScale = this.arcScaleComponent17;
            this.arcScaleNeedleComponent17.EndOffset = -5F;
            this.arcScaleNeedleComponent17.Name = "arcScaleNeedleComponent17";
            this.arcScaleNeedleComponent17.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockMinute;
            this.arcScaleNeedleComponent17.ZOrder = -51;
            // 
            // arcScaleComponent17
            // 
            this.arcScaleComponent17.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent17.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent17.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent17.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent17.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F);
            this.arcScaleComponent17.EndAngle = 270F;
            this.arcScaleComponent17.MajorTickCount = 2;
            this.arcScaleComponent17.MajorTickmark.ShowText = false;
            this.arcScaleComponent17.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent17.MaxValue = 12F;
            this.arcScaleComponent17.MinorTickCount = 0;
            this.arcScaleComponent17.Name = "arcScaleComponent17";
            this.arcScaleComponent17.RadiusX = 74F;
            this.arcScaleComponent17.RadiusY = 74F;
            this.arcScaleComponent17.StartAngle = -90F;
            this.arcScaleComponent17.Value = 3F;
            // 
            // arcScaleNeedleComponent18
            // 
            this.arcScaleNeedleComponent18.ArcScale = this.arcScaleComponent18;
            this.arcScaleNeedleComponent18.EndOffset = -10F;
            this.arcScaleNeedleComponent18.Name = "arcScaleNeedleComponent18";
            this.arcScaleNeedleComponent18.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockSecond;
            this.arcScaleNeedleComponent18.ZOrder = -52;
            // 
            // arcScaleComponent18
            // 
            this.arcScaleComponent18.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent18.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent18.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent18.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent18.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F);
            this.arcScaleComponent18.EndAngle = 270F;
            this.arcScaleComponent18.MajorTickCount = 2;
            this.arcScaleComponent18.MajorTickmark.ShowText = false;
            this.arcScaleComponent18.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent18.MaxValue = 12F;
            this.arcScaleComponent18.MinorTickCount = 0;
            this.arcScaleComponent18.Name = "arcScaleComponent18";
            this.arcScaleComponent18.RadiusX = 74F;
            this.arcScaleComponent18.RadiusY = 74F;
            this.arcScaleComponent18.StartAngle = -90F;
            this.arcScaleComponent18.Value = 1.5F;
            // 
            // arcScaleSpindleCapComponent6
            // 
            this.arcScaleSpindleCapComponent6.ArcScale = this.arcScaleComponent16;
            this.arcScaleSpindleCapComponent6.Name = "arcScaleSpindleCapComponent6";
            this.arcScaleSpindleCapComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Clock;
            this.arcScaleSpindleCapComponent6.Size = new System.Drawing.SizeF(12F, 12F);
            this.arcScaleSpindleCapComponent6.ZOrder = -100;
            // 
            // Moscow
            // 
            this.Moscow.BackColor = System.Drawing.Color.Transparent;
            this.Moscow.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Moscow.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge5});
            this.Moscow.Location = new System.Drawing.Point(459, 8);
            this.Moscow.Name = "Moscow";
            this.Moscow.Size = new System.Drawing.Size(220, 289);
            this.Moscow.TabIndex = 8;
            // 
            // circularGauge5
            // 
            this.circularGauge5.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] {
            this.arcScaleBackgroundLayerComponent5});
            this.circularGauge5.Bounds = new System.Drawing.Rectangle(6, 6, 208, 277);
            this.circularGauge5.EffectLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent[] {
            this.arcScaleEffectLayerComponent5});
            this.circularGauge5.Indicators.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent[] {
            this.arcScaleStateIndicatorComponent13,
            this.arcScaleStateIndicatorComponent14,
            this.arcScaleStateIndicatorComponent15});
            this.circularGauge5.Name = "circularGauge5";
            this.circularGauge5.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.arcScaleNeedleComponent13,
            this.arcScaleNeedleComponent14,
            this.arcScaleNeedleComponent15});
            this.circularGauge5.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScaleComponent13,
            this.arcScaleComponent14,
            this.arcScaleComponent15});
            this.circularGauge5.SpindleCaps.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent[] {
            this.arcScaleSpindleCapComponent5});
            // 
            // arcScaleBackgroundLayerComponent5
            // 
            this.arcScaleBackgroundLayerComponent5.ArcScale = this.arcScaleComponent13;
            this.arcScaleBackgroundLayerComponent5.Name = "arcScaleBackgroundLayerComponent5";
            this.arcScaleBackgroundLayerComponent5.ScaleCenterPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.504F, 0.436F);
            this.arcScaleBackgroundLayerComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_WorldTimeClock;
            this.arcScaleBackgroundLayerComponent5.Size = new System.Drawing.SizeF(216F, 250F);
            this.arcScaleBackgroundLayerComponent5.ZOrder = 1000;
            // 
            // arcScaleComponent13
            // 
            this.arcScaleComponent13.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent13.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent13.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent13.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent13.AppearanceTickmarkText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 10F);
            this.arcScaleComponent13.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            this.arcScaleComponent13.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F);
            this.arcScaleComponent13.EndAngle = 270F;
            scaleLabel4.AppearanceText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 8F);
            scaleLabel4.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            scaleLabel4.FormatString = "{0}";
            scaleLabel4.Name = "Label0";
            scaleLabel4.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 135F);
            scaleLabel4.Size = new System.Drawing.SizeF(70F, 20F);
            scaleLabel4.Text = "Moscow";
            scaleLabel5.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            scaleLabel5.FormatString = "{0}";
            scaleLabel5.Name = "Label1";
            scaleLabel5.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(75F, 238F);
            scaleLabel5.Size = new System.Drawing.SizeF(50F, 15F);
            scaleLabel5.Text = "Russia";
            scaleLabel6.AppearanceText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 12F);
            scaleLabel6.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            scaleLabel6.FormatString = "{0:F4}";
            scaleLabel6.Name = "Label2";
            scaleLabel6.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(165F, 225F);
            scaleLabel6.Size = new System.Drawing.SizeF(70F, 20F);
            scaleLabel6.Text = "2 602.60";
            this.arcScaleComponent13.Labels.AddRange(new DevExpress.XtraGauges.Core.Model.ILabel[] {
            scaleLabel4,
            scaleLabel5,
            scaleLabel6});
            this.arcScaleComponent13.MajorTickCount = 13;
            this.arcScaleComponent13.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent13.MajorTickmark.ShapeOffset = -9.5F;
            this.arcScaleComponent13.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_2;
            this.arcScaleComponent13.MajorTickmark.ShowFirst = false;
            this.arcScaleComponent13.MajorTickmark.TextOffset = -18F;
            this.arcScaleComponent13.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent13.MaxValue = 12F;
            this.arcScaleComponent13.MinorTickCount = 4;
            this.arcScaleComponent13.MinorTickmark.ShapeOffset = -1.5F;
            this.arcScaleComponent13.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_5;
            this.arcScaleComponent13.Name = "arcScaleComponent13";
            this.arcScaleComponent13.RadiusX = 74F;
            this.arcScaleComponent13.RadiusY = 74F;
            this.arcScaleComponent13.StartAngle = -90F;
            // 
            // arcScaleEffectLayerComponent5
            // 
            this.arcScaleEffectLayerComponent5.ArcScale = this.arcScaleComponent13;
            this.arcScaleEffectLayerComponent5.Name = "arcScaleEffectLayerComponent5";
            this.arcScaleEffectLayerComponent5.ScaleCenterPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 1F);
            this.arcScaleEffectLayerComponent5.Shader = new DevExpress.XtraGauges.Core.Drawing.OpacityShader("Opacity[0.7]");
            this.arcScaleEffectLayerComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Clock;
            this.arcScaleEffectLayerComponent5.Size = new System.Drawing.SizeF(170F, 85F);
            this.arcScaleEffectLayerComponent5.ZOrder = -1000;
            // 
            // arcScaleStateIndicatorComponent13
            // 
            this.arcScaleStateIndicatorComponent13.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(75F, 218F);
            this.arcScaleStateIndicatorComponent13.IndicatorScale = this.arcScaleComponent13;
            this.arcScaleStateIndicatorComponent13.Name = "arcScaleStateIndicatorComponent13";
            this.arcScaleStateIndicatorComponent13.Size = new System.Drawing.SizeF(40F, 21F);
            scaleIndicatorState4.IntervalLength = 12F;
            scaleIndicatorState4.Name = "Default";
            scaleIndicatorState4.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.FlagRussia;
            this.arcScaleStateIndicatorComponent13.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            scaleIndicatorState4});
            this.arcScaleStateIndicatorComponent13.ZOrder = -100;
            // 
            // arcScaleStateIndicatorComponent14
            // 
            this.arcScaleStateIndicatorComponent14.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(118F, 223F);
            this.arcScaleStateIndicatorComponent14.IndicatorScale = this.arcScaleComponent13;
            this.arcScaleStateIndicatorComponent14.Name = "arcScaleStateIndicatorComponent14";
            this.arcScaleStateIndicatorComponent14.Shader = new DevExpress.XtraGauges.Core.Drawing.GrayShader("");
            this.arcScaleStateIndicatorComponent14.Size = new System.Drawing.SizeF(20F, 20F);
            scaleIndicatorState5.IntervalLength = 12F;
            scaleIndicatorState5.Name = "Default";
            scaleIndicatorState5.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.CurrencyRUR;
            this.arcScaleStateIndicatorComponent14.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            scaleIndicatorState5});
            this.arcScaleStateIndicatorComponent14.ZOrder = -100;
            // 
            // arcScaleStateIndicatorComponent15
            // 
            this.arcScaleStateIndicatorComponent15.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(205F, 223F);
            this.arcScaleStateIndicatorComponent15.IndicatorScale = this.arcScaleComponent13;
            this.arcScaleStateIndicatorComponent15.Name = "arcScaleStateIndicatorComponent15";
            this.arcScaleStateIndicatorComponent15.Size = new System.Drawing.SizeF(15F, 15F);
            scaleIndicatorState6.IntervalLength = 12F;
            scaleIndicatorState6.Name = "Default";
            scaleIndicatorState6.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Arrow2;
            this.arcScaleStateIndicatorComponent15.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            scaleIndicatorState6});
            this.arcScaleStateIndicatorComponent15.ZOrder = -100;
            // 
            // arcScaleNeedleComponent13
            // 
            this.arcScaleNeedleComponent13.ArcScale = this.arcScaleComponent13;
            this.arcScaleNeedleComponent13.EndOffset = 10F;
            this.arcScaleNeedleComponent13.Name = "arcScaleNeedleComponent13";
            this.arcScaleNeedleComponent13.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockHour;
            this.arcScaleNeedleComponent13.ZOrder = -50;
            // 
            // arcScaleNeedleComponent14
            // 
            this.arcScaleNeedleComponent14.ArcScale = this.arcScaleComponent14;
            this.arcScaleNeedleComponent14.EndOffset = -5F;
            this.arcScaleNeedleComponent14.Name = "arcScaleNeedleComponent14";
            this.arcScaleNeedleComponent14.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockMinute;
            this.arcScaleNeedleComponent14.ZOrder = -51;
            // 
            // arcScaleComponent14
            // 
            this.arcScaleComponent14.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent14.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent14.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent14.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent14.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F);
            this.arcScaleComponent14.EndAngle = 270F;
            this.arcScaleComponent14.MajorTickCount = 2;
            this.arcScaleComponent14.MajorTickmark.ShowText = false;
            this.arcScaleComponent14.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent14.MaxValue = 12F;
            this.arcScaleComponent14.MinorTickCount = 0;
            this.arcScaleComponent14.Name = "arcScaleComponent14";
            this.arcScaleComponent14.RadiusX = 74F;
            this.arcScaleComponent14.RadiusY = 74F;
            this.arcScaleComponent14.StartAngle = -90F;
            this.arcScaleComponent14.Value = 3F;
            // 
            // arcScaleNeedleComponent15
            // 
            this.arcScaleNeedleComponent15.ArcScale = this.arcScaleComponent15;
            this.arcScaleNeedleComponent15.EndOffset = -10F;
            this.arcScaleNeedleComponent15.Name = "arcScaleNeedleComponent15";
            this.arcScaleNeedleComponent15.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockSecond;
            this.arcScaleNeedleComponent15.ZOrder = -52;
            // 
            // arcScaleComponent15
            // 
            this.arcScaleComponent15.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent15.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent15.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent15.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent15.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F);
            this.arcScaleComponent15.EndAngle = 270F;
            this.arcScaleComponent15.MajorTickCount = 2;
            this.arcScaleComponent15.MajorTickmark.ShowText = false;
            this.arcScaleComponent15.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent15.MaxValue = 12F;
            this.arcScaleComponent15.MinorTickCount = 0;
            this.arcScaleComponent15.Name = "arcScaleComponent15";
            this.arcScaleComponent15.RadiusX = 74F;
            this.arcScaleComponent15.RadiusY = 74F;
            this.arcScaleComponent15.StartAngle = -90F;
            this.arcScaleComponent15.Value = 1.5F;
            // 
            // arcScaleSpindleCapComponent5
            // 
            this.arcScaleSpindleCapComponent5.ArcScale = this.arcScaleComponent13;
            this.arcScaleSpindleCapComponent5.Name = "arcScaleSpindleCapComponent5";
            this.arcScaleSpindleCapComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Clock;
            this.arcScaleSpindleCapComponent5.Size = new System.Drawing.SizeF(12F, 12F);
            this.arcScaleSpindleCapComponent5.ZOrder = -100;
            // 
            // Paris
            // 
            this.Paris.BackColor = System.Drawing.Color.Transparent;
            this.Paris.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Paris.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge4});
            this.Paris.Location = new System.Drawing.Point(230, 8);
            this.Paris.Name = "Paris";
            this.Paris.Size = new System.Drawing.Size(228, 289);
            this.Paris.TabIndex = 7;
            // 
            // circularGauge4
            // 
            this.circularGauge4.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] {
            this.arcScaleBackgroundLayerComponent4});
            this.circularGauge4.Bounds = new System.Drawing.Rectangle(6, 6, 216, 277);
            this.circularGauge4.EffectLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent[] {
            this.arcScaleEffectLayerComponent4});
            this.circularGauge4.Indicators.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent[] {
            this.arcScaleStateIndicatorComponent10,
            this.arcScaleStateIndicatorComponent11,
            this.arcScaleStateIndicatorComponent12});
            this.circularGauge4.Name = "circularGauge4";
            this.circularGauge4.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.arcScaleNeedleComponent10,
            this.arcScaleNeedleComponent11,
            this.arcScaleNeedleComponent12});
            this.circularGauge4.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScaleComponent10,
            this.arcScaleComponent11,
            this.arcScaleComponent12});
            this.circularGauge4.SpindleCaps.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent[] {
            this.arcScaleSpindleCapComponent4});
            // 
            // arcScaleBackgroundLayerComponent4
            // 
            this.arcScaleBackgroundLayerComponent4.ArcScale = this.arcScaleComponent10;
            this.arcScaleBackgroundLayerComponent4.Name = "arcScaleBackgroundLayerComponent4";
            this.arcScaleBackgroundLayerComponent4.ScaleCenterPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.504F, 0.436F);
            this.arcScaleBackgroundLayerComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_WorldTimeClock;
            this.arcScaleBackgroundLayerComponent4.Size = new System.Drawing.SizeF(216F, 250F);
            this.arcScaleBackgroundLayerComponent4.ZOrder = 1000;
            // 
            // arcScaleComponent10
            // 
            this.arcScaleComponent10.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent10.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent10.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent10.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent10.AppearanceTickmarkText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 10F);
            this.arcScaleComponent10.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            this.arcScaleComponent10.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F);
            this.arcScaleComponent10.EndAngle = 270F;
            scaleLabel7.AppearanceText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 8F);
            scaleLabel7.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            scaleLabel7.FormatString = "{0}";
            scaleLabel7.Name = "Label0";
            scaleLabel7.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 135F);
            scaleLabel7.Size = new System.Drawing.SizeF(70F, 20F);
            scaleLabel7.Text = "Paris";
            scaleLabel8.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            scaleLabel8.FormatString = "{0}";
            scaleLabel8.Name = "Label1";
            scaleLabel8.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(75F, 238F);
            scaleLabel8.Size = new System.Drawing.SizeF(50F, 15F);
            scaleLabel8.Text = "France";
            scaleLabel9.AppearanceText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 12F);
            scaleLabel9.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            scaleLabel9.FormatString = "{0:F4}";
            scaleLabel9.Name = "Label2";
            scaleLabel9.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(160F, 225F);
            scaleLabel9.Size = new System.Drawing.SizeF(70F, 20F);
            scaleLabel9.Text = "73.142";
            this.arcScaleComponent10.Labels.AddRange(new DevExpress.XtraGauges.Core.Model.ILabel[] {
            scaleLabel7,
            scaleLabel8,
            scaleLabel9});
            this.arcScaleComponent10.MajorTickCount = 13;
            this.arcScaleComponent10.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent10.MajorTickmark.ShapeOffset = -9.5F;
            this.arcScaleComponent10.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_2;
            this.arcScaleComponent10.MajorTickmark.ShowFirst = false;
            this.arcScaleComponent10.MajorTickmark.TextOffset = -18F;
            this.arcScaleComponent10.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent10.MaxValue = 12F;
            this.arcScaleComponent10.MinorTickCount = 4;
            this.arcScaleComponent10.MinorTickmark.ShapeOffset = -1.5F;
            this.arcScaleComponent10.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_5;
            this.arcScaleComponent10.Name = "arcScaleComponent10";
            this.arcScaleComponent10.RadiusX = 74F;
            this.arcScaleComponent10.RadiusY = 74F;
            this.arcScaleComponent10.StartAngle = -90F;
            // 
            // arcScaleEffectLayerComponent4
            // 
            this.arcScaleEffectLayerComponent4.ArcScale = this.arcScaleComponent10;
            this.arcScaleEffectLayerComponent4.Name = "arcScaleEffectLayerComponent4";
            this.arcScaleEffectLayerComponent4.ScaleCenterPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 1F);
            this.arcScaleEffectLayerComponent4.Shader = new DevExpress.XtraGauges.Core.Drawing.OpacityShader("Opacity[0.7]");
            this.arcScaleEffectLayerComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Clock;
            this.arcScaleEffectLayerComponent4.Size = new System.Drawing.SizeF(170F, 85F);
            this.arcScaleEffectLayerComponent4.ZOrder = -1000;
            // 
            // arcScaleStateIndicatorComponent10
            // 
            this.arcScaleStateIndicatorComponent10.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(75F, 218F);
            this.arcScaleStateIndicatorComponent10.IndicatorScale = this.arcScaleComponent10;
            this.arcScaleStateIndicatorComponent10.Name = "arcScaleStateIndicatorComponent10";
            this.arcScaleStateIndicatorComponent10.Size = new System.Drawing.SizeF(40F, 21F);
            scaleIndicatorState7.IntervalLength = 12F;
            scaleIndicatorState7.Name = "Default";
            scaleIndicatorState7.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.FlagFrance;
            this.arcScaleStateIndicatorComponent10.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            scaleIndicatorState7});
            this.arcScaleStateIndicatorComponent10.ZOrder = -100;
            // 
            // arcScaleStateIndicatorComponent11
            // 
            this.arcScaleStateIndicatorComponent11.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(118F, 223F);
            this.arcScaleStateIndicatorComponent11.IndicatorScale = this.arcScaleComponent10;
            this.arcScaleStateIndicatorComponent11.Name = "arcScaleStateIndicatorComponent11";
            this.arcScaleStateIndicatorComponent11.Shader = new DevExpress.XtraGauges.Core.Drawing.GrayShader("");
            this.arcScaleStateIndicatorComponent11.Size = new System.Drawing.SizeF(20F, 20F);
            scaleIndicatorState8.IntervalLength = 12F;
            scaleIndicatorState8.Name = "Default";
            scaleIndicatorState8.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.CurrencyEUR;
            this.arcScaleStateIndicatorComponent11.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            scaleIndicatorState8});
            this.arcScaleStateIndicatorComponent11.ZOrder = -100;
            // 
            // arcScaleStateIndicatorComponent12
            // 
            this.arcScaleStateIndicatorComponent12.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(195F, 223F);
            this.arcScaleStateIndicatorComponent12.IndicatorScale = this.arcScaleComponent10;
            this.arcScaleStateIndicatorComponent12.Name = "arcScaleStateIndicatorComponent12";
            this.arcScaleStateIndicatorComponent12.Size = new System.Drawing.SizeF(15F, 15F);
            scaleIndicatorState9.IntervalLength = 12F;
            scaleIndicatorState9.Name = "Default";
            scaleIndicatorState9.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Arrow1;
            this.arcScaleStateIndicatorComponent12.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            scaleIndicatorState9});
            this.arcScaleStateIndicatorComponent12.ZOrder = -100;
            // 
            // arcScaleNeedleComponent10
            // 
            this.arcScaleNeedleComponent10.ArcScale = this.arcScaleComponent10;
            this.arcScaleNeedleComponent10.EndOffset = 10F;
            this.arcScaleNeedleComponent10.Name = "arcScaleNeedleComponent10";
            this.arcScaleNeedleComponent10.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockHour;
            this.arcScaleNeedleComponent10.ZOrder = -50;
            // 
            // arcScaleNeedleComponent11
            // 
            this.arcScaleNeedleComponent11.ArcScale = this.arcScaleComponent11;
            this.arcScaleNeedleComponent11.EndOffset = -5F;
            this.arcScaleNeedleComponent11.Name = "arcScaleNeedleComponent11";
            this.arcScaleNeedleComponent11.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockMinute;
            this.arcScaleNeedleComponent11.ZOrder = -51;
            // 
            // arcScaleComponent11
            // 
            this.arcScaleComponent11.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent11.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent11.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent11.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent11.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F);
            this.arcScaleComponent11.EndAngle = 270F;
            this.arcScaleComponent11.MajorTickCount = 2;
            this.arcScaleComponent11.MajorTickmark.ShowText = false;
            this.arcScaleComponent11.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent11.MaxValue = 12F;
            this.arcScaleComponent11.MinorTickCount = 0;
            this.arcScaleComponent11.Name = "arcScaleComponent11";
            this.arcScaleComponent11.RadiusX = 74F;
            this.arcScaleComponent11.RadiusY = 74F;
            this.arcScaleComponent11.StartAngle = -90F;
            this.arcScaleComponent11.Value = 3F;
            // 
            // arcScaleNeedleComponent12
            // 
            this.arcScaleNeedleComponent12.ArcScale = this.arcScaleComponent12;
            this.arcScaleNeedleComponent12.EndOffset = -10F;
            this.arcScaleNeedleComponent12.Name = "arcScaleNeedleComponent12";
            this.arcScaleNeedleComponent12.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockSecond;
            this.arcScaleNeedleComponent12.ZOrder = -52;
            // 
            // arcScaleComponent12
            // 
            this.arcScaleComponent12.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent12.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent12.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent12.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent12.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F);
            this.arcScaleComponent12.EndAngle = 270F;
            this.arcScaleComponent12.MajorTickCount = 2;
            this.arcScaleComponent12.MajorTickmark.ShowText = false;
            this.arcScaleComponent12.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent12.MaxValue = 12F;
            this.arcScaleComponent12.MinorTickCount = 0;
            this.arcScaleComponent12.Name = "arcScaleComponent12";
            this.arcScaleComponent12.RadiusX = 74F;
            this.arcScaleComponent12.RadiusY = 74F;
            this.arcScaleComponent12.StartAngle = -90F;
            this.arcScaleComponent12.Value = 1.5F;
            // 
            // arcScaleSpindleCapComponent4
            // 
            this.arcScaleSpindleCapComponent4.ArcScale = this.arcScaleComponent10;
            this.arcScaleSpindleCapComponent4.Name = "arcScaleSpindleCapComponent4";
            this.arcScaleSpindleCapComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Clock;
            this.arcScaleSpindleCapComponent4.Size = new System.Drawing.SizeF(12F, 12F);
            this.arcScaleSpindleCapComponent4.ZOrder = -100;
            // 
            // Tokyo
            // 
            this.Tokyo.BackColor = System.Drawing.Color.Transparent;
            this.Tokyo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Tokyo.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge3});
            this.Tokyo.Location = new System.Drawing.Point(230, 297);
            this.Tokyo.Name = "Tokyo";
            this.Tokyo.Size = new System.Drawing.Size(228, 288);
            this.Tokyo.TabIndex = 6;
            // 
            // circularGauge3
            // 
            this.circularGauge3.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] {
            this.arcScaleBackgroundLayerComponent3});
            this.circularGauge3.Bounds = new System.Drawing.Rectangle(6, 6, 216, 276);
            this.circularGauge3.EffectLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent[] {
            this.arcScaleEffectLayerComponent3});
            this.circularGauge3.Indicators.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent[] {
            this.arcScaleStateIndicatorComponent7,
            this.arcScaleStateIndicatorComponent8,
            this.arcScaleStateIndicatorComponent9});
            this.circularGauge3.Name = "circularGauge3";
            this.circularGauge3.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.arcScaleNeedleComponent7,
            this.arcScaleNeedleComponent8,
            this.arcScaleNeedleComponent9});
            this.circularGauge3.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScaleComponent7,
            this.arcScaleComponent8,
            this.arcScaleComponent9});
            this.circularGauge3.SpindleCaps.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent[] {
            this.arcScaleSpindleCapComponent3});
            // 
            // arcScaleBackgroundLayerComponent3
            // 
            this.arcScaleBackgroundLayerComponent3.ArcScale = this.arcScaleComponent7;
            this.arcScaleBackgroundLayerComponent3.Name = "arcScaleBackgroundLayerComponent3";
            this.arcScaleBackgroundLayerComponent3.ScaleCenterPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.504F, 0.436F);
            this.arcScaleBackgroundLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_WorldTimeClock;
            this.arcScaleBackgroundLayerComponent3.Size = new System.Drawing.SizeF(216F, 250F);
            this.arcScaleBackgroundLayerComponent3.ZOrder = 1000;
            // 
            // arcScaleComponent7
            // 
            this.arcScaleComponent7.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent7.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent7.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent7.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent7.AppearanceTickmarkText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 10F);
            this.arcScaleComponent7.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            this.arcScaleComponent7.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F);
            this.arcScaleComponent7.EndAngle = 270F;
            scaleLabel10.AppearanceText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 8F);
            scaleLabel10.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            scaleLabel10.FormatString = "{0}";
            scaleLabel10.Name = "Label0";
            scaleLabel10.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 135F);
            scaleLabel10.Size = new System.Drawing.SizeF(70F, 20F);
            scaleLabel10.Text = "Tokyo";
            scaleLabel11.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            scaleLabel11.FormatString = "{0}";
            scaleLabel11.Name = "Label1";
            scaleLabel11.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(75F, 238F);
            scaleLabel11.Size = new System.Drawing.SizeF(50F, 15F);
            scaleLabel11.Text = "Japan";
            scaleLabel12.AppearanceText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 12F);
            scaleLabel12.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            scaleLabel12.FormatString = "{0:F4}";
            scaleLabel12.Name = "Label2";
            scaleLabel12.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(168F, 225F);
            scaleLabel12.Size = new System.Drawing.SizeF(90F, 20F);
            scaleLabel12.Text = "10 058.33";
            this.arcScaleComponent7.Labels.AddRange(new DevExpress.XtraGauges.Core.Model.ILabel[] {
            scaleLabel10,
            scaleLabel11,
            scaleLabel12});
            this.arcScaleComponent7.MajorTickCount = 13;
            this.arcScaleComponent7.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent7.MajorTickmark.ShapeOffset = -9.5F;
            this.arcScaleComponent7.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_2;
            this.arcScaleComponent7.MajorTickmark.ShowFirst = false;
            this.arcScaleComponent7.MajorTickmark.TextOffset = -18F;
            this.arcScaleComponent7.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent7.MaxValue = 12F;
            this.arcScaleComponent7.MinorTickCount = 4;
            this.arcScaleComponent7.MinorTickmark.ShapeOffset = -1.5F;
            this.arcScaleComponent7.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_5;
            this.arcScaleComponent7.Name = "arcScaleComponent7";
            this.arcScaleComponent7.RadiusX = 74F;
            this.arcScaleComponent7.RadiusY = 74F;
            this.arcScaleComponent7.StartAngle = -90F;
            // 
            // arcScaleEffectLayerComponent3
            // 
            this.arcScaleEffectLayerComponent3.ArcScale = this.arcScaleComponent7;
            this.arcScaleEffectLayerComponent3.Name = "arcScaleEffectLayerComponent3";
            this.arcScaleEffectLayerComponent3.ScaleCenterPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 1F);
            this.arcScaleEffectLayerComponent3.Shader = new DevExpress.XtraGauges.Core.Drawing.OpacityShader("Opacity[0.7]");
            this.arcScaleEffectLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Clock;
            this.arcScaleEffectLayerComponent3.Size = new System.Drawing.SizeF(170F, 85F);
            this.arcScaleEffectLayerComponent3.ZOrder = -1000;
            // 
            // arcScaleStateIndicatorComponent7
            // 
            this.arcScaleStateIndicatorComponent7.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(75F, 218F);
            this.arcScaleStateIndicatorComponent7.IndicatorScale = this.arcScaleComponent7;
            this.arcScaleStateIndicatorComponent7.Name = "arcScaleStateIndicatorComponent7";
            this.arcScaleStateIndicatorComponent7.Size = new System.Drawing.SizeF(40F, 21F);
            scaleIndicatorState10.IntervalLength = 12F;
            scaleIndicatorState10.Name = "Default";
            scaleIndicatorState10.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.FlagJapan;
            this.arcScaleStateIndicatorComponent7.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            scaleIndicatorState10});
            this.arcScaleStateIndicatorComponent7.ZOrder = -100;
            // 
            // arcScaleStateIndicatorComponent8
            // 
            this.arcScaleStateIndicatorComponent8.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(118F, 223F);
            this.arcScaleStateIndicatorComponent8.IndicatorScale = this.arcScaleComponent7;
            this.arcScaleStateIndicatorComponent8.Name = "arcScaleStateIndicatorComponent8";
            this.arcScaleStateIndicatorComponent8.Shader = new DevExpress.XtraGauges.Core.Drawing.GrayShader("");
            this.arcScaleStateIndicatorComponent8.Size = new System.Drawing.SizeF(20F, 20F);
            scaleIndicatorState11.IntervalLength = 12F;
            scaleIndicatorState11.Name = "Default";
            scaleIndicatorState11.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.CurrencyJPY;
            this.arcScaleStateIndicatorComponent8.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            scaleIndicatorState11});
            this.arcScaleStateIndicatorComponent8.ZOrder = -100;
            // 
            // arcScaleStateIndicatorComponent9
            // 
            this.arcScaleStateIndicatorComponent9.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(213F, 223F);
            this.arcScaleStateIndicatorComponent9.IndicatorScale = this.arcScaleComponent7;
            this.arcScaleStateIndicatorComponent9.Name = "arcScaleStateIndicatorComponent9";
            this.arcScaleStateIndicatorComponent9.Size = new System.Drawing.SizeF(15F, 15F);
            scaleIndicatorState12.IntervalLength = 12F;
            scaleIndicatorState12.Name = "Default";
            scaleIndicatorState12.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Arrow10;
            this.arcScaleStateIndicatorComponent9.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            scaleIndicatorState12});
            this.arcScaleStateIndicatorComponent9.ZOrder = -100;
            // 
            // arcScaleNeedleComponent7
            // 
            this.arcScaleNeedleComponent7.ArcScale = this.arcScaleComponent7;
            this.arcScaleNeedleComponent7.EndOffset = 10F;
            this.arcScaleNeedleComponent7.Name = "arcScaleNeedleComponent7";
            this.arcScaleNeedleComponent7.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockHour;
            this.arcScaleNeedleComponent7.ZOrder = -50;
            // 
            // arcScaleNeedleComponent8
            // 
            this.arcScaleNeedleComponent8.ArcScale = this.arcScaleComponent8;
            this.arcScaleNeedleComponent8.EndOffset = -5F;
            this.arcScaleNeedleComponent8.Name = "arcScaleNeedleComponent8";
            this.arcScaleNeedleComponent8.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockMinute;
            this.arcScaleNeedleComponent8.ZOrder = -51;
            // 
            // arcScaleComponent8
            // 
            this.arcScaleComponent8.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent8.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent8.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent8.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent8.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F);
            this.arcScaleComponent8.EndAngle = 270F;
            this.arcScaleComponent8.MajorTickCount = 2;
            this.arcScaleComponent8.MajorTickmark.ShowText = false;
            this.arcScaleComponent8.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent8.MaxValue = 12F;
            this.arcScaleComponent8.MinorTickCount = 0;
            this.arcScaleComponent8.Name = "arcScaleComponent8";
            this.arcScaleComponent8.RadiusX = 74F;
            this.arcScaleComponent8.RadiusY = 74F;
            this.arcScaleComponent8.StartAngle = -90F;
            this.arcScaleComponent8.Value = 3F;
            // 
            // arcScaleNeedleComponent9
            // 
            this.arcScaleNeedleComponent9.ArcScale = this.arcScaleComponent9;
            this.arcScaleNeedleComponent9.EndOffset = -10F;
            this.arcScaleNeedleComponent9.Name = "arcScaleNeedleComponent9";
            this.arcScaleNeedleComponent9.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockSecond;
            this.arcScaleNeedleComponent9.ZOrder = -52;
            // 
            // arcScaleComponent9
            // 
            this.arcScaleComponent9.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent9.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent9.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent9.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent9.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F);
            this.arcScaleComponent9.EndAngle = 270F;
            this.arcScaleComponent9.MajorTickCount = 2;
            this.arcScaleComponent9.MajorTickmark.ShowText = false;
            this.arcScaleComponent9.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent9.MaxValue = 12F;
            this.arcScaleComponent9.MinorTickCount = 0;
            this.arcScaleComponent9.Name = "arcScaleComponent9";
            this.arcScaleComponent9.RadiusX = 74F;
            this.arcScaleComponent9.RadiusY = 74F;
            this.arcScaleComponent9.StartAngle = -90F;
            this.arcScaleComponent9.Value = 1.5F;
            // 
            // arcScaleSpindleCapComponent3
            // 
            this.arcScaleSpindleCapComponent3.ArcScale = this.arcScaleComponent7;
            this.arcScaleSpindleCapComponent3.Name = "arcScaleSpindleCapComponent3";
            this.arcScaleSpindleCapComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Clock;
            this.arcScaleSpindleCapComponent3.Size = new System.Drawing.SizeF(12F, 12F);
            this.arcScaleSpindleCapComponent3.ZOrder = -100;
            // 
            // London
            // 
            this.London.BackColor = System.Drawing.Color.Transparent;
            this.London.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.London.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge2});
            this.London.Location = new System.Drawing.Point(8, 297);
            this.London.Name = "London";
            this.London.Size = new System.Drawing.Size(221, 288);
            this.London.TabIndex = 5;
            // 
            // circularGauge2
            // 
            this.circularGauge2.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] {
            this.arcScaleBackgroundLayerComponent2});
            this.circularGauge2.Bounds = new System.Drawing.Rectangle(6, 6, 209, 276);
            this.circularGauge2.EffectLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent[] {
            this.arcScaleEffectLayerComponent2});
            this.circularGauge2.Indicators.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent[] {
            this.arcScaleStateIndicatorComponent4,
            this.arcScaleStateIndicatorComponent5,
            this.arcScaleStateIndicatorComponent6});
            this.circularGauge2.Name = "circularGauge2";
            this.circularGauge2.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.arcScaleNeedleComponent4,
            this.arcScaleNeedleComponent5,
            this.arcScaleNeedleComponent6});
            this.circularGauge2.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScaleComponent4,
            this.arcScaleComponent5,
            this.arcScaleComponent6});
            this.circularGauge2.SpindleCaps.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent[] {
            this.arcScaleSpindleCapComponent2});
            // 
            // arcScaleBackgroundLayerComponent2
            // 
            this.arcScaleBackgroundLayerComponent2.ArcScale = this.arcScaleComponent4;
            this.arcScaleBackgroundLayerComponent2.Name = "arcScaleBackgroundLayerComponent2";
            this.arcScaleBackgroundLayerComponent2.ScaleCenterPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.504F, 0.436F);
            this.arcScaleBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_WorldTimeClock;
            this.arcScaleBackgroundLayerComponent2.Size = new System.Drawing.SizeF(216F, 250F);
            this.arcScaleBackgroundLayerComponent2.ZOrder = 1000;
            // 
            // arcScaleComponent4
            // 
            this.arcScaleComponent4.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent4.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent4.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent4.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent4.AppearanceTickmarkText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 10F);
            this.arcScaleComponent4.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            this.arcScaleComponent4.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F);
            this.arcScaleComponent4.EndAngle = 270F;
            scaleLabel13.AppearanceText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 8F);
            scaleLabel13.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            scaleLabel13.FormatString = "{0}";
            scaleLabel13.Name = "Label0";
            scaleLabel13.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 135F);
            scaleLabel13.Size = new System.Drawing.SizeF(70F, 20F);
            scaleLabel13.Text = "London";
            scaleLabel14.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            scaleLabel14.FormatString = "{0}";
            scaleLabel14.Name = "Label1";
            scaleLabel14.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(75F, 238F);
            scaleLabel14.Size = new System.Drawing.SizeF(90F, 15F);
            scaleLabel14.Text = "United Kingdom";
            scaleLabel15.AppearanceText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 12F);
            scaleLabel15.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            scaleLabel15.FormatString = "{0:F4}";
            scaleLabel15.Name = "Label2";
            scaleLabel15.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(168F, 225F);
            scaleLabel15.Size = new System.Drawing.SizeF(70F, 20F);
            scaleLabel15.Text = "57.750";
            this.arcScaleComponent4.Labels.AddRange(new DevExpress.XtraGauges.Core.Model.ILabel[] {
            scaleLabel13,
            scaleLabel14,
            scaleLabel15});
            this.arcScaleComponent4.MajorTickCount = 13;
            this.arcScaleComponent4.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent4.MajorTickmark.ShapeOffset = -9.5F;
            this.arcScaleComponent4.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_2;
            this.arcScaleComponent4.MajorTickmark.ShowFirst = false;
            this.arcScaleComponent4.MajorTickmark.TextOffset = -18F;
            this.arcScaleComponent4.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent4.MaxValue = 12F;
            this.arcScaleComponent4.MinorTickCount = 4;
            this.arcScaleComponent4.MinorTickmark.ShapeOffset = -1.5F;
            this.arcScaleComponent4.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_5;
            this.arcScaleComponent4.Name = "arcScaleComponent4";
            this.arcScaleComponent4.RadiusX = 74F;
            this.arcScaleComponent4.RadiusY = 74F;
            this.arcScaleComponent4.StartAngle = -90F;
            // 
            // arcScaleEffectLayerComponent2
            // 
            this.arcScaleEffectLayerComponent2.ArcScale = this.arcScaleComponent4;
            this.arcScaleEffectLayerComponent2.Name = "arcScaleEffectLayerComponent2";
            this.arcScaleEffectLayerComponent2.ScaleCenterPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 1F);
            this.arcScaleEffectLayerComponent2.Shader = new DevExpress.XtraGauges.Core.Drawing.OpacityShader("Opacity[0.7]");
            this.arcScaleEffectLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Clock;
            this.arcScaleEffectLayerComponent2.Size = new System.Drawing.SizeF(170F, 85F);
            this.arcScaleEffectLayerComponent2.ZOrder = -1000;
            // 
            // arcScaleStateIndicatorComponent4
            // 
            this.arcScaleStateIndicatorComponent4.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(75F, 218F);
            this.arcScaleStateIndicatorComponent4.IndicatorScale = this.arcScaleComponent4;
            this.arcScaleStateIndicatorComponent4.Name = "arcScaleStateIndicatorComponent4";
            this.arcScaleStateIndicatorComponent4.Size = new System.Drawing.SizeF(40F, 21F);
            scaleIndicatorState13.IntervalLength = 12F;
            scaleIndicatorState13.Name = "Default";
            scaleIndicatorState13.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.FlagUK;
            this.arcScaleStateIndicatorComponent4.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            scaleIndicatorState13});
            this.arcScaleStateIndicatorComponent4.ZOrder = -100;
            // 
            // arcScaleStateIndicatorComponent5
            // 
            this.arcScaleStateIndicatorComponent5.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(130F, 223F);
            this.arcScaleStateIndicatorComponent5.IndicatorScale = this.arcScaleComponent4;
            this.arcScaleStateIndicatorComponent5.Name = "arcScaleStateIndicatorComponent5";
            this.arcScaleStateIndicatorComponent5.Shader = new DevExpress.XtraGauges.Core.Drawing.GrayShader("");
            this.arcScaleStateIndicatorComponent5.Size = new System.Drawing.SizeF(20F, 20F);
            scaleIndicatorState14.IntervalLength = 12F;
            scaleIndicatorState14.Name = "Default";
            scaleIndicatorState14.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.CurrencyGBP;
            this.arcScaleStateIndicatorComponent5.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            scaleIndicatorState14});
            this.arcScaleStateIndicatorComponent5.ZOrder = -100;
            // 
            // arcScaleStateIndicatorComponent6
            // 
            this.arcScaleStateIndicatorComponent6.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(203F, 223F);
            this.arcScaleStateIndicatorComponent6.IndicatorScale = this.arcScaleComponent4;
            this.arcScaleStateIndicatorComponent6.Name = "arcScaleStateIndicatorComponent6";
            this.arcScaleStateIndicatorComponent6.Size = new System.Drawing.SizeF(15F, 15F);
            scaleIndicatorState15.IntervalLength = 12F;
            scaleIndicatorState15.Name = "Default";
            scaleIndicatorState15.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Arrow9;
            this.arcScaleStateIndicatorComponent6.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            scaleIndicatorState15});
            this.arcScaleStateIndicatorComponent6.ZOrder = -100;
            // 
            // arcScaleNeedleComponent4
            // 
            this.arcScaleNeedleComponent4.ArcScale = this.arcScaleComponent4;
            this.arcScaleNeedleComponent4.EndOffset = 10F;
            this.arcScaleNeedleComponent4.Name = "arcScaleNeedleComponent4";
            this.arcScaleNeedleComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockHour;
            this.arcScaleNeedleComponent4.ZOrder = -50;
            // 
            // arcScaleNeedleComponent5
            // 
            this.arcScaleNeedleComponent5.ArcScale = this.arcScaleComponent5;
            this.arcScaleNeedleComponent5.EndOffset = -5F;
            this.arcScaleNeedleComponent5.Name = "arcScaleNeedleComponent5";
            this.arcScaleNeedleComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockMinute;
            this.arcScaleNeedleComponent5.ZOrder = -51;
            // 
            // arcScaleComponent5
            // 
            this.arcScaleComponent5.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent5.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent5.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent5.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent5.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F);
            this.arcScaleComponent5.EndAngle = 270F;
            this.arcScaleComponent5.MajorTickCount = 2;
            this.arcScaleComponent5.MajorTickmark.ShowText = false;
            this.arcScaleComponent5.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent5.MaxValue = 12F;
            this.arcScaleComponent5.MinorTickCount = 0;
            this.arcScaleComponent5.Name = "arcScaleComponent5";
            this.arcScaleComponent5.RadiusX = 74F;
            this.arcScaleComponent5.RadiusY = 74F;
            this.arcScaleComponent5.StartAngle = -90F;
            this.arcScaleComponent5.Value = 3F;
            // 
            // arcScaleNeedleComponent6
            // 
            this.arcScaleNeedleComponent6.ArcScale = this.arcScaleComponent6;
            this.arcScaleNeedleComponent6.EndOffset = -10F;
            this.arcScaleNeedleComponent6.Name = "arcScaleNeedleComponent6";
            this.arcScaleNeedleComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockSecond;
            this.arcScaleNeedleComponent6.ZOrder = -52;
            // 
            // arcScaleComponent6
            // 
            this.arcScaleComponent6.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent6.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent6.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent6.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent6.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F);
            this.arcScaleComponent6.EndAngle = 270F;
            this.arcScaleComponent6.MajorTickCount = 2;
            this.arcScaleComponent6.MajorTickmark.ShowText = false;
            this.arcScaleComponent6.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent6.MaxValue = 12F;
            this.arcScaleComponent6.MinorTickCount = 0;
            this.arcScaleComponent6.Name = "arcScaleComponent6";
            this.arcScaleComponent6.RadiusX = 74F;
            this.arcScaleComponent6.RadiusY = 74F;
            this.arcScaleComponent6.StartAngle = -90F;
            this.arcScaleComponent6.Value = 1.5F;
            // 
            // arcScaleSpindleCapComponent2
            // 
            this.arcScaleSpindleCapComponent2.ArcScale = this.arcScaleComponent4;
            this.arcScaleSpindleCapComponent2.Name = "arcScaleSpindleCapComponent2";
            this.arcScaleSpindleCapComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Clock;
            this.arcScaleSpindleCapComponent2.Size = new System.Drawing.SizeF(12F, 12F);
            this.arcScaleSpindleCapComponent2.ZOrder = -100;
            // 
            // Washington
            // 
            this.Washington.BackColor = System.Drawing.Color.Transparent;
            this.Washington.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Washington.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge1});
            this.Washington.Location = new System.Drawing.Point(8, 8);
            this.Washington.Name = "Washington";
            this.Washington.Size = new System.Drawing.Size(221, 289);
            this.Washington.TabIndex = 4;
            // 
            // circularGauge1
            // 
            this.circularGauge1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] {
            this.arcScaleBackgroundLayerComponent1});
            this.circularGauge1.Bounds = new System.Drawing.Rectangle(6, 6, 209, 277);
            this.circularGauge1.EffectLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent[] {
            this.arcScaleEffectLayerComponent1});
            this.circularGauge1.Indicators.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent[] {
            this.arcScaleStateIndicatorComponent1,
            this.arcScaleStateIndicatorComponent2});
            this.circularGauge1.Name = "circularGauge1";
            this.circularGauge1.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.arcScaleNeedleComponent1,
            this.arcScaleNeedleComponent2,
            this.arcScaleNeedleComponent3});
            this.circularGauge1.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScaleComponent1,
            this.arcScaleComponent2,
            this.arcScaleComponent3});
            this.circularGauge1.SpindleCaps.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent[] {
            this.arcScaleSpindleCapComponent1});
            // 
            // arcScaleBackgroundLayerComponent1
            // 
            this.arcScaleBackgroundLayerComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleBackgroundLayerComponent1.Name = "arcScaleBackgroundLayerComponent1";
            this.arcScaleBackgroundLayerComponent1.ScaleCenterPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.504F, 0.436F);
            this.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_WorldTimeClock;
            this.arcScaleBackgroundLayerComponent1.Size = new System.Drawing.SizeF(216F, 250F);
            this.arcScaleBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // arcScaleComponent1
            // 
            this.arcScaleComponent1.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceTickmarkText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 10F);
            this.arcScaleComponent1.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            this.arcScaleComponent1.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F);
            this.arcScaleComponent1.EndAngle = 270F;
            scaleLabel16.AppearanceText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 8F);
            scaleLabel16.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            scaleLabel16.FormatString = "{0}";
            scaleLabel16.Name = "Label0";
            scaleLabel16.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 135F);
            scaleLabel16.Size = new System.Drawing.SizeF(70F, 20F);
            scaleLabel16.Text = "Washington";
            scaleLabel17.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            scaleLabel17.FormatString = "{0}";
            scaleLabel17.Name = "Label1";
            scaleLabel17.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(75F, 238F);
            scaleLabel17.Size = new System.Drawing.SizeF(50F, 15F);
            scaleLabel17.Text = "U.S.A.";
            scaleLabel18.AppearanceText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 12F);
            scaleLabel18.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            scaleLabel18.FormatString = "{0}";
            scaleLabel18.Name = "Label2";
            scaleLabel18.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(160F, 225F);
            scaleLabel18.Size = new System.Drawing.SizeF(70F, 20F);
            scaleLabel18.Text = "100.00";
            this.arcScaleComponent1.Labels.AddRange(new DevExpress.XtraGauges.Core.Model.ILabel[] {
            scaleLabel16,
            scaleLabel17,
            scaleLabel18});
            this.arcScaleComponent1.MajorTickCount = 13;
            this.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent1.MajorTickmark.ShapeOffset = -9.5F;
            this.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_2;
            this.arcScaleComponent1.MajorTickmark.ShowFirst = false;
            this.arcScaleComponent1.MajorTickmark.TextOffset = -18F;
            this.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent1.MaxValue = 12F;
            this.arcScaleComponent1.MinorTickCount = 4;
            this.arcScaleComponent1.MinorTickmark.ShapeOffset = -1.5F;
            this.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style5_5;
            this.arcScaleComponent1.Name = "arcScaleComponent1";
            this.arcScaleComponent1.RadiusX = 74F;
            this.arcScaleComponent1.RadiusY = 74F;
            this.arcScaleComponent1.StartAngle = -90F;
            // 
            // arcScaleEffectLayerComponent1
            // 
            this.arcScaleEffectLayerComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleEffectLayerComponent1.Name = "arcScaleEffectLayerComponent1";
            this.arcScaleEffectLayerComponent1.ScaleCenterPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 1F);
            this.arcScaleEffectLayerComponent1.Shader = new DevExpress.XtraGauges.Core.Drawing.OpacityShader("Opacity[0.7]");
            this.arcScaleEffectLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Clock;
            this.arcScaleEffectLayerComponent1.Size = new System.Drawing.SizeF(170F, 85F);
            this.arcScaleEffectLayerComponent1.ZOrder = -1000;
            // 
            // arcScaleStateIndicatorComponent1
            // 
            this.arcScaleStateIndicatorComponent1.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(75F, 218F);
            this.arcScaleStateIndicatorComponent1.IndicatorScale = this.arcScaleComponent1;
            this.arcScaleStateIndicatorComponent1.Name = "arcScaleStateIndicatorComponent1";
            this.arcScaleStateIndicatorComponent1.Size = new System.Drawing.SizeF(40F, 21F);
            scaleIndicatorState16.IntervalLength = 12F;
            scaleIndicatorState16.Name = "Default";
            scaleIndicatorState16.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.FlagUSA;
            this.arcScaleStateIndicatorComponent1.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            scaleIndicatorState16});
            this.arcScaleStateIndicatorComponent1.ZOrder = -100;
            // 
            // arcScaleStateIndicatorComponent2
            // 
            this.arcScaleStateIndicatorComponent2.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(123F, 223F);
            this.arcScaleStateIndicatorComponent2.IndicatorScale = this.arcScaleComponent1;
            this.arcScaleStateIndicatorComponent2.Name = "arcScaleStateIndicatorComponent2";
            this.arcScaleStateIndicatorComponent2.Shader = new DevExpress.XtraGauges.Core.Drawing.GrayShader("");
            this.arcScaleStateIndicatorComponent2.Size = new System.Drawing.SizeF(20F, 20F);
            scaleIndicatorState17.IntervalLength = 12F;
            scaleIndicatorState17.Name = "Default";
            scaleIndicatorState17.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.CurrencyUSD;
            this.arcScaleStateIndicatorComponent2.States.AddRange(new DevExpress.XtraGauges.Core.Model.IIndicatorState[] {
            scaleIndicatorState17});
            this.arcScaleStateIndicatorComponent2.ZOrder = -100;
            // 
            // arcScaleNeedleComponent1
            // 
            this.arcScaleNeedleComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleNeedleComponent1.EndOffset = 10F;
            this.arcScaleNeedleComponent1.Name = "arcScaleNeedleComponent1";
            this.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockHour;
            this.arcScaleNeedleComponent1.ZOrder = -50;
            // 
            // arcScaleNeedleComponent2
            // 
            this.arcScaleNeedleComponent2.ArcScale = this.arcScaleComponent2;
            this.arcScaleNeedleComponent2.EndOffset = -5F;
            this.arcScaleNeedleComponent2.Name = "arcScaleNeedleComponent2";
            this.arcScaleNeedleComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockMinute;
            this.arcScaleNeedleComponent2.ZOrder = -51;
            // 
            // arcScaleComponent2
            // 
            this.arcScaleComponent2.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent2.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent2.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent2.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent2.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F);
            this.arcScaleComponent2.EndAngle = 270F;
            this.arcScaleComponent2.MajorTickCount = 2;
            this.arcScaleComponent2.MajorTickmark.ShowText = false;
            this.arcScaleComponent2.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent2.MaxValue = 12F;
            this.arcScaleComponent2.MinorTickCount = 0;
            this.arcScaleComponent2.Name = "arcScaleComponent2";
            this.arcScaleComponent2.RadiusX = 74F;
            this.arcScaleComponent2.RadiusY = 74F;
            this.arcScaleComponent2.StartAngle = -90F;
            this.arcScaleComponent2.Value = 3F;
            // 
            // arcScaleNeedleComponent3
            // 
            this.arcScaleNeedleComponent3.ArcScale = this.arcScaleComponent3;
            this.arcScaleNeedleComponent3.EndOffset = -10F;
            this.arcScaleNeedleComponent3.Name = "arcScaleNeedleComponent3";
            this.arcScaleNeedleComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockSecond;
            this.arcScaleNeedleComponent3.ZOrder = -52;
            // 
            // arcScaleComponent3
            // 
            this.arcScaleComponent3.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent3.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent3.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent3.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent3.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 110F);
            this.arcScaleComponent3.EndAngle = 270F;
            this.arcScaleComponent3.MajorTickCount = 2;
            this.arcScaleComponent3.MajorTickmark.ShowText = false;
            this.arcScaleComponent3.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent3.MaxValue = 12F;
            this.arcScaleComponent3.MinorTickCount = 0;
            this.arcScaleComponent3.Name = "arcScaleComponent3";
            this.arcScaleComponent3.RadiusX = 74F;
            this.arcScaleComponent3.RadiusY = 74F;
            this.arcScaleComponent3.StartAngle = -90F;
            this.arcScaleComponent3.Value = 1.5F;
            // 
            // arcScaleSpindleCapComponent1
            // 
            this.arcScaleSpindleCapComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleSpindleCapComponent1.Name = "arcScaleSpindleCapComponent1";
            this.arcScaleSpindleCapComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Clock;
            this.arcScaleSpindleCapComponent1.Size = new System.Drawing.SizeF(12F, 12F);
            this.arcScaleSpindleCapComponent1.ZOrder = -100;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(687, 593);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.Washington;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 0, 8, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(229, 297);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.Paris;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(229, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 8, 0);
            this.layoutControlItem4.Size = new System.Drawing.Size(230, 297);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.Tokyo;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(229, 297);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 0, 8);
            this.layoutControlItem3.Size = new System.Drawing.Size(230, 296);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.London;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 297);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 0, 0, 8);
            this.layoutControlItem2.Size = new System.Drawing.Size(229, 296);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.Moscow;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(459, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 8, 8, 0);
            this.layoutControlItem5.Size = new System.Drawing.Size(228, 297);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.Rome;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(459, 297);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 8, 0, 8);
            this.layoutControlItem6.Size = new System.Drawing.Size(228, 296);
            this.layoutControlItem6.TextVisible = false;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // WorldTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "WorldTime";
            this.Size = new System.Drawing.Size(687, 593);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleEffectLayerComponent6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleEffectLayerComponent5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleEffectLayerComponent4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleEffectLayerComponent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleEffectLayerComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleEffectLayerComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleStateIndicatorComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGauges.Win.GaugeControl Washington;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.Timer timer;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent arcScaleEffectLayerComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent arcScaleStateIndicatorComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent arcScaleStateIndicatorComponent2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent3;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent3;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent arcScaleSpindleCapComponent1;
        private DevExpress.XtraGauges.Win.GaugeControl London;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent4;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent arcScaleEffectLayerComponent2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent arcScaleStateIndicatorComponent4;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent arcScaleStateIndicatorComponent5;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent arcScaleStateIndicatorComponent6;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent4;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent5;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent5;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent6;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent6;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent arcScaleSpindleCapComponent2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGauges.Win.GaugeControl Paris;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge4;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent4;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent10;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent arcScaleEffectLayerComponent4;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent arcScaleStateIndicatorComponent10;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent arcScaleStateIndicatorComponent11;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent arcScaleStateIndicatorComponent12;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent10;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent11;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent11;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent12;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent12;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent arcScaleSpindleCapComponent4;
        private DevExpress.XtraGauges.Win.GaugeControl Tokyo;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge3;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent3;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent7;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent arcScaleEffectLayerComponent3;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent arcScaleStateIndicatorComponent7;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent arcScaleStateIndicatorComponent8;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent arcScaleStateIndicatorComponent9;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent7;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent8;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent8;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent9;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent9;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent arcScaleSpindleCapComponent3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGauges.Win.GaugeControl Rome;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge6;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent6;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent16;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent arcScaleEffectLayerComponent6;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent arcScaleStateIndicatorComponent16;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent arcScaleStateIndicatorComponent17;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent arcScaleStateIndicatorComponent18;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent16;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent17;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent17;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent18;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent18;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent arcScaleSpindleCapComponent6;
        private DevExpress.XtraGauges.Win.GaugeControl Moscow;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge5;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent5;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent13;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent arcScaleEffectLayerComponent5;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent arcScaleStateIndicatorComponent13;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent arcScaleStateIndicatorComponent14;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleStateIndicatorComponent arcScaleStateIndicatorComponent15;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent13;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent14;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent14;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent15;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent15;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent arcScaleSpindleCapComponent5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}
