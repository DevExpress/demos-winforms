using System;
using System.Drawing;

namespace DevExpress.XtraGauges.Demos {
    public partial class ZoomFeature : TutorialControl {
        public ZoomFeature() {
            InitializeComponent();
            zoomTrackBarControl1_EditValueChanged(null, null);
        }
        void zoomTrackBarControl1_EditValueChanged(object sender, EventArgs e) {
            Rectangle oldBounds = circularGauge1.Bounds;
            oldBounds.Inflate(2, 2);
            int w = (int)(1000 * Math.Sin(Math.PI / 180 * 5 * zoomTrack.Value));
            circularGauge1.Bounds = new Rectangle(new Point(5, 5), new Size(w, w));
            if(oldBounds.Width > circularGauge1.Bounds.Width) gaugeControl1.Invalidate(oldBounds);
        }
    }
}
