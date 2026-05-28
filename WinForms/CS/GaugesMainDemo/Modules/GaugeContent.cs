using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGauges.Base;
using DevExpress.XtraGauges.Core.Model;
using DevExpress.XtraGauges.Win;
using DevExpress.XtraGauges.Win.Base;

namespace DevExpress.XtraGauges.Demos {
    public partial class GaugeContent : XtraUserControl {
        ObjectState stateCore;
        Color colorCore;
        public GaugeContent() {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitGauge();
            stateCore = ObjectState.Normal;
            colorCore = Color.Empty;
        }
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            arcScaleComponent1.Animating -= OnAnimating;
            gaugeControl.MouseEnter -= OnMouseEnter;
            gaugeControl.MouseLeave -= OnMouseLeave;
            gaugeControl.GotFocus -= OnGotFocus;
            gaugeControl.LostFocus -= OnLostFocus;
            timer.Stop();
            base.Dispose(disposing);
        }
        void InitGauge() {
            arcScaleComponent1.EasingFunction = new CubicEase();
            arcScaleComponent1.EasingMode = EasingMode.EaseOut;
            arcScaleComponent1.EnableAnimation = true;
            arcScaleComponent1.Animating += OnAnimating;
            gaugeControl.MouseLeave += OnMouseLeave;
            gaugeControl.GotFocus += OnGotFocus;
            gaugeControl.LostFocus += OnLostFocus;
            gaugeControl.MouseEnter += OnMouseEnter;
        }
        void UpdateState() {
            Invalidate();
            Update();
        }
        void OnLostFocus(object sender, EventArgs e) {
            Selected = false;
            UpdateState();
        }
        public GaugeControl Gauge { get { return gaugeControl; } }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Caption {
            get { return labelControl1.Text; }
            set { labelControl1.Text = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color Color {
            get { return gaugeControl.ColorScheme.Color; }
            set {
                if(!colorCore.IsEmpty &&  colorCore != gaugeControl.ColorScheme.Color)
                    return;
                colorCore = value;
                gaugeControl.ColorScheme.Color = colorCore;
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image Image {
            get { return imageIndicatorComponent.Image; }
            set { imageIndicatorComponent.Image = value; }
        }
        void OnGotFocus(object sender, EventArgs e) {
            Selected = true;
            UpdateState();
        }
        void OnMouseEnter(object sender, EventArgs e) {
            Hot = true;
            UpdateState();
        }
        void OnMouseLeave(object sender, EventArgs e) {
            Hot = false;
            UpdateState();
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual bool Hot {
            get { return GetState(ObjectState.Hot); }
            set { SetState(ObjectState.Hot, value); }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual bool Selected {
            get { return GetState(ObjectState.Selected); }
            set {
                SetState(ObjectState.Selected, value);
                var gaugesDashboard = GetParent(this.Parent);
                if(Selected && gaugesDashboard != null)
                    gaugesDashboard.UpdateColor(Color);
            }
        }
        GaugesDashboard GetParent(Control parent) {
            if(parent == null) return null;
            if(parent is GaugesDashboard)
                return parent as GaugesDashboard;
            return GetParent(parent.Parent);
        }
        void SetState(ObjectState state, bool value) {
            if(value)
                stateCore |= state;
            else
                stateCore &= ~state;
        }
        bool GetState(ObjectState state) {
            return (stateCore & state) != 0;
        }
        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            DrawBackground(e);
        }
        void DrawBackground(PaintEventArgs e) {
            Rectangle rect = ClientRectangle;
            rect.Height -= Padding.Vertical;
            rect.X += Padding.Left;
            rect.Y += Padding.Top - 10;
            rect.Width -= Padding.Horizontal;
            Skin skin = CommonSkins.GetSkin(LookAndFeel);
            SkinElementInfo elementInfo = new SkinElementInfo(skin[CommonSkins.SkinLayoutItemBackground], rect);
            if(Selected)
                elementInfo.ImageIndex = 2;
            if(Hot)
                elementInfo.ImageIndex = 1;
            using(GraphicsCache cache = new GraphicsCache(e.Graphics, ScaleDPI)) 
                ObjectPainter.DrawObject(cache, SkinElementPainter.Default, elementInfo);
        }
        #region Animation
        void OnAnimating(object sender, EventArgs e) {
            ValueChangedEventArgs ea = e as ValueChangedEventArgs;
            if(ea != null)
                labelComponent1.Text = ea.Value.ToString("F0");
        }
        int animationLockCounterCore = 0;
        Timer timer;
        bool IsAnimationLocked {
            get { return animationLockCounterCore > 0; }
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            timer = new Timer();
            timer.Interval = Data.Utils.NonCryptographicRandom.Default.Next(2000, 2400);
            timer.Tick += new EventHandler(OnTimerTick);
            timer.Start();
        }
        void OnTimerTick(object sender, EventArgs e) {
            if(!timer.Enabled) return;
            if(IsAnimationLocked) return;
            LockAnimation();
            DoAnimation(gaugeControl);
            UnlockAnimation();
        }
        void UnlockAnimation() {
            animationLockCounterCore--;
        }
        void LockAnimation() {
            animationLockCounterCore++;
        }
        void DoAnimation(GaugeControl gauge) {
            foreach(IGauge gb in gauge.Gauges) {
                ICircularGauge cGauge = gb as ICircularGauge;
                if(cGauge != null) {
                    foreach(IScale _scale in cGauge.Scales) _scale.Value = AnimateScaleValue(_scale);
                }
            }
        }
        float AnimateScaleValue(IScale scale) {
            return Data.Utils.NonCryptographicRandom.System.Next(0, 100);
        }
        #endregion
    }
}
