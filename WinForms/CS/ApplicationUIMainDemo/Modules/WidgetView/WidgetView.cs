using System;
using System.Collections.Generic;
using DevExpress.DXperience.Demos;
using DevExpress.Skins;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Widget;

namespace DevExpress.ApplicationUI.Demos {
    public partial class WidgetView : TutorialControlBase {
        Dictionary<string, string> companyFullNames = new Dictionary<string, string>();
        public WidgetView() {
            InitializeComponent();
            FillCompaniesInformation();
            documentManager.View.QueryControl += View_QueryControl;
            widgetView1.AllowDocumentStateChangeAnimation = DevExpress.Utils.DefaultBoolean.True;
            ScaleElements();
        }
        void ScaleElements() {
            float dpiScaleFactor = DpiProvider.Default.DpiScaleFactor;
            foreach(StackGroup group in widgetView1.StackGroups)
                group.Length.UnitValue *= dpiScaleFactor;
            foreach(Document doc in documentManager.View.Documents)
                doc.Height = (int)Math.Round(doc.Height * dpiScaleFactor) + (dpiScaleFactor > 1 ? 2 : 0);
        }
        void View_QueryControl(object sender, QueryControlEventArgs e) {
            WidgetControl widget = new WidgetControl();
            widget.CompanyNameText = companyFullNames[e.Document.Caption];
            e.Control = widget;
            (e.Document as Document).MaximizedControl = new MaximizedWidgetControl();
        }
        void FillCompaniesInformation() {
            companyFullNames.Add("AAPL", "Apple Inc.");
            companyFullNames.Add("YHOO", "Yahoo! Inc.");
            companyFullNames.Add("CSCO", "Cisco Systems Inc.");
            companyFullNames.Add("ADBE", "Adobe Systems Inc.");
            companyFullNames.Add("BAC", "Bank of America Corporation");
            companyFullNames.Add("DELL", "Dell Inc.");
            companyFullNames.Add("NVDA", "NVIDIA Corporation");
            companyFullNames.Add("HPQ", "Hewlett-Packard Company");
        }
    }
}
