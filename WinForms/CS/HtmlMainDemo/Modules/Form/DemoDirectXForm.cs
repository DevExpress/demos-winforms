using DevExpress.Utils;
using DevExpress.Utils.Html;
using DevExpress.XtraEditors;

namespace DevExpress.HTML.Demos {
    public partial class DemoDirectXForm : DirectXForm {
        public DemoDirectXForm() {
            InitializeComponent();
            HtmlElementMouseDown += DemoDirectXForm_HtmlElementMouseDown;
        }

        void DemoDirectXForm_HtmlElementMouseDown(object sender, DxHtmlElementMouseEventArgs e) {
            var args = e.MouseArgs as DXMouseEventArgs;
            if(e.Element == null || args == null)
                return;
            var id = e.Element.Id;
            if(e.HasClassName("addbutton")) {
                args.Handled = true;
                return;
            }
            if(id == "loginbutton") {
                args.Handled = true;
                return;
            }
            if(id == "infobutton") {
                args.Handled = true;
                return;
            }
        }

        protected override void OnShown(System.EventArgs e) {
            base.OnShown(e);
            if(!HtmlTemplate.Template.Contains(searchEdit.Name))
                searchEdit.Visible = false;
        }
    }
}
