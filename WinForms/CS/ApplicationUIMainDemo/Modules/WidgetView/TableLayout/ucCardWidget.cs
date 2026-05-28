using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils.Drawing;
using DevExpress.Utils.Text;
using DevExpress.XtraEditors;

namespace DevExpress.ApplicationUI.Demos {
    public partial class ucCardWidget : XtraEditors.XtraUserControl {
        public ucCardWidget() {
            InitializeComponent();
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public decimal Price { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double PPrice { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double Delta { get; set; }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            labelControl1.StateIndex = Delta > 0 ? 0 : 1;
            if(labelControl1.StateIndex == 0)
                labelControl1.Text = Price.ToString("C1") + "<br><color=63,136,48>" + PPrice.ToString("P") + "<br><b><color=63,136,48><size=+2>" + Delta.ToString("F2");
            else
                labelControl1.Text = Price.ToString("C1") + "<br><color=214,5,5>" + PPrice.ToString("P") + "<br><b><color=214,5,5><size=+2>" + Delta.ToString("F2");
        }
    }
    public class OverviewLabel : LabelControl {
        static Color positiveColor = Color.FromArgb(63, 136, 48);
        static Color negativeColor = Color.FromArgb(214, 5, 5);
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int StateIndex {
            get;
            set;
        }
        protected override void Dispose(bool disposing) {
            if(disposing)
                DestroyFitAppearance();
            base.Dispose(disposing);
        }
        protected override void OnTextChanged(EventArgs e) {
            base.OnTextChanged(e);
            DestroyFitAppearance();
        }
        protected override void OnSizeChanged(EventArgs e) {
            base.OnSizeChanged(e);
            DestroyFitAppearance();
        }
        protected override void OnPaint(PaintEventArgs e) {
            if(IsDesignMode || GetFitHeight() <= 1)
                return;
            using(GraphicsCache cache = new GraphicsCache(e.Graphics)) {
                cache.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                DrawText(cache, GetFitAppearance(cache));
                DrawStateIndicator(cache, GetFitHeight() * 2);
            }
        }
        void DrawText(GraphicsCache cache, LabelControlAppearanceObject appearance) {
            var rect = ClientRectangle;
            rect.Height -= Padding.Bottom;
            StringPainter.Default.DrawString(cache, appearance, Text, rect, appearance.TextOptions, this);
        }
        void DrawStateIndicator(GraphicsCache cache, int height) {
            Point p1 = Point.Empty;
            Point p2 = Point.Empty;
            Point p3 = Point.Empty;
            int _width = (int)(2 * height / Math.Sqrt(3));
            p1.X = ClientRectangle.Left + Padding.Left + _width / 2;
            p2.X = ClientRectangle.Left + Padding.Left;
            p3.X = ClientRectangle.Left + Padding.Left + _width;
            int y = (ClientRectangle.Bottom - Padding.Bottom) - 5;
            Color stateColor = Color.Empty;
            if(StateIndex == 0) {
                p1.Y = y - height;
                p2.Y = p3.Y = y;
                stateColor = positiveColor;
            }
            else {
                p1.Y = y;
                p2.Y = p3.Y = y - height;
                stateColor = negativeColor;
            }
            cache.FillPolygon(new Point[] { p1, p2, p3 }, stateColor);
        }
        int GetFitHeight() {
            return (int)((ClientRectangle.Height - Padding.Bottom) / 4F + 0.5F);
        }
        LabelControlAppearanceObject labelControlAppearanceObject;
        LabelControlAppearanceObject GetFitAppearance(GraphicsCache cache) {
            if(labelControlAppearanceObject != null)
                return labelControlAppearanceObject;
            LabelControlAppearanceObject obj = new LabelControlAppearanceObject();
            obj.Assign(ViewInfo.PaintAppearance);
            obj.Font = new Font(obj.Font.FontFamily, GetFitHeight(), GraphicsUnit.Pixel);
            labelControlAppearanceObject = obj;
            return obj;
        }
        void DestroyFitAppearance() {
            if(labelControlAppearanceObject != null) {
                var _font = labelControlAppearanceObject.Font;
                labelControlAppearanceObject.Font = null;
                if(_font != null && _font != Utils.AppearanceObject.DefaultFont)
                    _font.Dispose();
                labelControlAppearanceObject.Dispose();
            }
            labelControlAppearanceObject = null;
        }
    }
}
