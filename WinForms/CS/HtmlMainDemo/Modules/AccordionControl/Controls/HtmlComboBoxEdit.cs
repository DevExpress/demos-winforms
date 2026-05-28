using DevExpress.Utils.Html;
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DevExpress.HTML.Demos.Modules.AccordionControl {
    public class HtmlComboBoxEdit : ComboBoxEdit {
        public HtmlComboBoxEdit() {
            PaintEx += OnPaintEx;
            Width = 162;
            Height = 36;
            Properties.TextEditStyle = XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            Properties.AutoHeight = false;
            Properties.UseAdvancedMode = Utils.DefaultBoolean.True;
            context = new DxHtmlPainterContext();
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        protected internal HtmlTemplate HtmlTemplate { get; set; }
        void OnPaintEx(object sender, TextEditPaintExEventArgs e) {
            if(HtmlTemplate == null)
                return;
            var args = new DxHtmlPainterArgs();
            args.Cache = e.Cache;
            args.Bounds = new Rectangle(Point.Empty, Size);
            args.LookAndFeel = LookAndFeel;
            bool hasValue = SelectedIndex >= 0;
            args.SetFieldValue("Value", hasValue ? EditValue : Properties.NullValuePrompt);
            args.SetFieldValue("HasValue", hasValue);
            args.HtmlImages = Properties.HtmlImages;
            DxHtmlPainter.Default.Draw(HtmlTemplate, args, context);
        }
        protected override void OnMouseMove(MouseEventArgs e) {
            base.OnMouseMove(e);
            context.OnMouseMove(e);
            Invalidate();
        }
        protected override void OnMouseDown(MouseEventArgs e) {
            var result = context.CalcHitInfo(e.Location);
            if(result == null)
                return;
            if(IsPopupOpen)
                ClosePopup();
            else
                ShowPopup();
        }
        protected override void OnMouseLeave(EventArgs e) {
            base.OnMouseLeave(e);
            context.OnMouseLeave(e);
            Invalidate();
        }
        DxHtmlPainterContext context;
    }
}
