using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Utils;
using DevExpress.HTML.Demos.Helpers;

namespace DevExpress.HTML.Demos {
    public partial class ListBoxModule : TutorialControlBase {
        Dictionary<int, bool> employeesOnline;

        public ListBoxModule() {
            InitializeComponent();
            listBoxTemplateCodeViewer1.Fill(listBoxControl, htmlContentPopup);
            listBoxControl.ShowFocusRect = false;
            listBoxControl.DataSource = DataHelper.Employees;

            listBoxControl.CustomizeItem += ListBoxControl1_CustomizeItem;
            listBoxControl.HtmlElementMouseClick += ListBoxControl1_HtmlElementMouseClick;

            employeesOnline = Enumerable.Range(0, listBoxControl.ItemCount).ToDictionary(x => x, x => TutorialConstants.Random.NextDouble() >= 0.5);
        }

        void ListBoxControl1_HtmlElementMouseClick(object sender, XtraEditors.ListBoxHtmlElementMouseEventArgs e) {
            if(e.ElementId == "info") {
                var size = ScaleDPI.ScaleSize(new Size(352, 360));
                var location = new Point(
                    e.Bounds.Right - ScaleDPI.ScaleHorizontal(6),
                    e.Bounds.Y + ScaleDPI.ScaleHorizontal(8) - (size.Height - e.Bounds.Height) / 2);
                var tooltipScreenBounds = listBoxControl.RectangleToScreen(new Rectangle(location, size));

                htmlContentPopup.DataContext = e.Item;
                htmlContentPopup.Show(this, tooltipScreenBounds);
            }
        }

        void ListBoxControl1_CustomizeItem(object sender, XtraEditors.CustomizeTemplatedItemEventArgs e) {
            var statusBadge = e.HtmlElement?.FindElementById("status");
            bool online = employeesOnline[e.Index];
            if(statusBadge != null && online)
                statusBadge.Style.SetBackgroundColor("@Green");
        }
    }
}
