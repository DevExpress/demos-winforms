using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Data.Utils;
using DevExpress.Drawing;
using DevExpress.XtraGauges.Core.Model;
using DevExpress.XtraGauges.Core.Primitive;

namespace DevExpress.XtraGauges.Demos {
    public partial class CustomDrawFeature : TutorialControl {
        bool IsDisposing;
        public CustomDrawFeature() {
            InitializeComponent();
            ceAllowCustomDraw.Checked = true;
            SubscribeEvents();
        }
        #region Infrastructure
        protected override void Dispose(bool disposing) {
            IsDisposing = true;
            if(disposing && (components != null)) {
                UnsubscribeEvents();
                timer.Stop();
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        void SubscribeEvents() {
            Load += OnLoad;
            arcScale.CustomDrawElement += Scale_CustomDrawElement;
            linearScale.CustomDrawElement += Scale_CustomDrawElement;
            arcScaleNeedle.CustomDrawElement += arcScaleNeedle_CustomDrawElement;
            arcScaleBackgroundLayer.CustomDrawElement += arcScaleBackgroundLayer_CustomDrawElement;
            linearScaleLevel.CustomDrawElement += linearScaleLevel_CustomDrawElement;
            linearScaleBackgroundLayer.CustomDrawElement += linearScaleBackgroundLayer_CustomDrawElement;
        }
        void UnsubscribeEvents() {
            timer.Tick -= OnTimerTick;
            Load -= OnLoad;
            arcScale.CustomDrawElement -= Scale_CustomDrawElement;
            linearScale.CustomDrawElement -= Scale_CustomDrawElement;
            arcScaleNeedle.CustomDrawElement -= arcScaleNeedle_CustomDrawElement;
            arcScaleBackgroundLayer.CustomDrawElement -= arcScaleBackgroundLayer_CustomDrawElement;
            linearScaleLevel.CustomDrawElement -= linearScaleLevel_CustomDrawElement;
            linearScaleBackgroundLayer.CustomDrawElement -= linearScaleBackgroundLayer_CustomDrawElement;
        }
        #endregion Infrastructure
        bool handleCustomDraw = false;
        void ceAllowCustomDraw_CheckedChanged(object sender, EventArgs e) {
            handleCustomDraw = ceAllowCustomDraw.Checked;
            arcScaleBackgroundLayer.Self.ResetCache(CacheKeys.RenderedImage);
            linearScaleBackgroundLayer.Self.ResetCache(CacheKeys.RenderedImage);
        }
        #region CustomDraw
        void Scale_CustomDrawElement(object sender, CustomDrawElementEventArgs e) {
            if(!handleCustomDraw)
                return;
            e.Handled = true;
        }
        void linearScaleBackgroundLayer_CustomDrawElement(object sender, CustomDrawElementEventArgs e) {
            if(!handleCustomDraw)
                return;
            e.Handled = true;
        }
        DXPen pen = new DXPen(Color.Black, 2f);
        void linearScaleLevel_CustomDrawElement(object sender, CustomDrawElementEventArgs e) {
            if(!handleCustomDraw)
                return;
            for(int i = 0; i < 5; i++)
                e.Context.DrawLine(DXPens.DarkGray, 60, 75 + i * 25, 190, 75 + i * 25);
            float pos = 75 + (float)Math.Round(linearScale.Percent * 8f) * 12.5f;
            e.Context.FillEllipse(DXBrushes.Black, new RectangleF(102, pos - 8, 19, 16));
            e.Context.DrawLine(pen, 120, pos - 45, 120, pos);
            e.Context.FillEllipse(DXBrushes.Black, new RectangleF(127, pos - 20.5f, 19, 16));
            e.Context.DrawLine(pen, 145, pos - 45, 145, pos - 12.5f);
            e.Context.DrawLine(pen, 120, pos - 44, 145, pos - 44);
            e.Context.DrawLine(pen, 120, pos - 36, 145, pos - 36);
            e.Handled = true;
        }
        void arcScaleBackgroundLayer_CustomDrawElement(object sender, CustomDrawElementEventArgs e) {
            if(!handleCustomDraw)
                return;
            RectangleF _bounds = RectangleF.Inflate(e.Info.BoundBox, -15, -15);
            e.Context.FillEllipse(DXBrushes.Black, _bounds);
            _bounds.Inflate(-2, -2);
            e.Context.SetClip(new RectangleF(_bounds.Left + _bounds.Width * 0.5f, _bounds.Top, _bounds.Width * 0.5f, _bounds.Height));
            e.Context.FillEllipse(DXBrushes.White, _bounds);
            e.Context.ResetClip();
            e.Context.FillEllipse(DXBrushes.White, new RectangleF(
                _bounds.Left + _bounds.Width * 0.25f, _bounds.Top,
                _bounds.Width * 0.5f, _bounds.Height * 0.5f));
            e.Context.FillEllipse(DXBrushes.Black, new RectangleF(
                _bounds.Left + _bounds.Width * 0.25f, _bounds.Top + _bounds.Height * 0.5f,
                _bounds.Width * 0.5f, _bounds.Height * 0.5f));
            e.Handled = true;
        }
        void arcScaleNeedle_CustomDrawElement(object sender, CustomDrawElementEventArgs e) {
            if(!handleCustomDraw)
                return;
            e.Context.FillEllipse(DXBrushes.White, new RectangleF(50, 112.5f, 25, 25));
            e.Context.FillEllipse(DXBrushes.Black, new RectangleF(175, 112.5f, 25, 25));
            e.Handled = true;
        }
        #endregion CustomDraw
        #region Animation
        Timer timer;
        void OnLoad(object sender, EventArgs e) {
            timer = new Timer();
            timer.Interval = 350;
            timer.Tick += OnTimerTick;
            timer.Start();
        }
        int animationLockCounterCore = 0;
        void OnTimerTick(object sender, EventArgs e) {
            if(animationLockCounterCore > 0 || !Visible || IsDisposing || IsDisposed) 
                return;
            if(arcScale.IsDisposing || linearScale.IsDisposing) 
                return;
            animationLockCounterCore++;
            arcScale.Value = AnimateScaleValue(arcScale, 0.05f);
            linearScale.Value = AnimateScaleValue(linearScale, 0.75f);
            animationLockCounterCore--;
        }
        float AnimateScaleValue(IBaseScale scale, float factor) {
            float deviation = (float)NonCryptographicRandom.Default.NextDouble() - scale.Percent;
            return scale.Value + (scale.ScaleLength * factor) * deviation;
        }
        #endregion Animation
    }
}
