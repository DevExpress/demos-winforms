using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGauges.Base;
using DevExpress.XtraGauges.Core.Base;
using DevExpress.XtraGauges.Core.Model;
using DevExpress.XtraGauges.Core.Primitive;

namespace DevExpress.XtraGauges.Demos {
    public partial class InteractionFeature : TutorialControl {
        public InteractionFeature() {
            InitializeComponent();
        }
        void gaugeControl1_MouseMove(object sender, MouseEventArgs e) {
            CheckCursor(gaugeControl1 as IGaugeContainer, e);
            if(e.Button == MouseButtons.Left)
                CalculateMouseValue(gaugeControl1 as IGaugeContainer, arcScaleComponent1, e);
        }
        void gaugeControl2_MouseMove(object sender, MouseEventArgs e) {
            CheckCursor(gaugeControl2 as IGaugeContainer, e);
            if(e.Button == MouseButtons.Left)
                CalculateMouseValue(gaugeControl2 as IGaugeContainer, linearScaleComponent1, e);
        }
        void gaugeControl1_MouseDown(object sender, MouseEventArgs e) {
            CalculateMouseValue(gaugeControl1 as IGaugeContainer, arcScaleComponent1, e);
        }
        void gaugeControl2_MouseDown(object sender, MouseEventArgs e) {
            CalculateMouseValue(gaugeControl2 as IGaugeContainer, linearScaleComponent1, e);
        }
        void CalculateMouseValue(IGaugeContainer container, IConvertibleScaleEx scale, MouseEventArgs e) {
            BasePrimitiveHitInfo hi = container.CalcHitInfo(e.Location);
            if(hi.Element != null && !hi.Element.IsComposite) {
                PointF modelPt = MathHelper.PointToModelPoint(scale as IElement<IRenderableElement>, new PointF(e.X, e.Y));
                float percent = scale.PointToPercent(modelPt);
                scale.Value = scale.PercentToValue(percent);
            }
        }
        void CheckCursor(IGaugeContainer container, MouseEventArgs e) {
            BasePrimitiveHitInfo hi = container.CalcHitInfo(e.Location);
            Cursor _cursor = (hi.Element != null && !hi.Element.IsComposite) ?
                Utils.Controls.DXCursors.Hand : Cursors.Default;
            if(((Control)container).Cursor != _cursor) 
                ((Control)container).Cursor = _cursor;
        }
    }
}
