using System.ComponentModel;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;

namespace DevExpress.WindowsMailClient.Win.Controls {
    public class MailClientPanelAccordionControl : AccordionControl {
        protected override BaseControlPainter CreatePainter() { return new MailClientAccordionControlPainter(); }
        protected override BaseStyleControlViewInfo CreateViewInfo() { return new MailClientAccordionControlViewInfo(this); }
        [DefaultValue(0)]
        public int ContentTopIndent { get; set; }
    }
    public class MailClientAccordionControlViewInfo : AccordionControlViewInfo {
        public MailClientAccordionControlViewInfo(AccordionControl owner) : base(owner) {
        }
    }
    class MailClientAccordionControlPainter : AccordionControlPainter {
        protected override bool DrawElementDCompBackground(GraphicsCache cache, AccordionElementBaseViewInfo elementInfo) {
            return elementInfo.Element.Style == ElementStyle.Group;
        }
    }
}
