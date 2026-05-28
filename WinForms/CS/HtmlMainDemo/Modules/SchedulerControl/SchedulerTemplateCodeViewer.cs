using DevExpress.Utils.Html;
using DevExpress.XtraScheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpress.HTML.Demos
{
    public class SchedulerTemplateCodeViewer : TemplateCodeViewer
    {
        SchedulerControl control;
        public void Fill(SchedulerControl control)
        {
            this.control = control;
            List<HtmlTemplate> templates = new List<HtmlTemplate>();
            templates.Add(this.control.DayView.HtmlTemplates.Appointment);
            templates.Add(this.control.OptionsView.ResourceHeaders.ResourceHeaderHtmlTemplate);
            FillTemplates(templates);
        }
        protected override void LayoutChanged()
        {
            this.control.DayView.LayoutChanged();
        }
    }
}
