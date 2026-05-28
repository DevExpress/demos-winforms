using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;

namespace DevExpress.ApplicationUI.Demos {
    public partial class SalesPerformanceWidgets : WidgetViewTutorialControl {
        const string STR_UcCardWidget = "DevExpress.ApplicationUI.Demos.ucCardWidget";
        //
        readonly Dictionary<string, Control> QueryControlDictionary = new Dictionary<string, Control>();
        public SalesPerformanceWidgets() {
            InitializeComponent();
            foreach(var item in widgetView1.Documents) {
                string typeName = item.ControlTypeName;
                if(typeName == STR_UcCardWidget)
                    continue;
                if(!string.IsNullOrEmpty(typeName)) {
                    var controlType = Data.Internal.SafeTypeResolver.GetKnownType(typeof(Program).Assembly, typeName);
                    var control = Activator.CreateInstance(controlType) as Control;
                    QueryControlDictionary.Add(item.ControlTypeName, control);
                }
            }
        }
        protected override int TakeScreenDelay => 2100;
        void widgetView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e) {
            if(e.Document.ControlTypeName == STR_UcCardWidget) {
                var smallWidget = new ucCardWidget();
                var random = TutorialConstants.Random;
                smallWidget.Price = random.Next(100, 1000);
                smallWidget.PPrice = random.NextDouble() - random.NextDouble();
                smallWidget.Delta = random.Next(-50, 100) + random.NextDouble();
                e.Control = smallWidget;
                return;
            }
            if(!string.IsNullOrEmpty(e.Document.ControlTypeName)) {
                e.Control = QueryControlDictionary[e.Document.ControlTypeName];
            }
        }
    }
}
