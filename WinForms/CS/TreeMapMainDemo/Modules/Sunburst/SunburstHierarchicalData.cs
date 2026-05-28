using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using System.Xml.Linq;
using DevExpress.TreeMap;
using DevExpress.Utils;

namespace DevExpress.XtraTreeMap.Demos {
    public partial class SunburstHierarchicalData : TreeMapDemoModuleWithOptions {
        SunburstHierarchicalDataAdapter HierarchicalDataAdapter { get { return (SunburstHierarchicalDataAdapter)sunburstControl1.DataAdapter; } }

        public override Control ActiveDemoModule { get { return sunburstControl1; } }

        public SunburstHierarchicalData() {
            InitializeComponent();
            InitializeControls(sunburstControl1, colorizerCBE, varyColorInGroupLCI, modeLCI);
            HierarchicalDataAdapter.DataSource = LoadDataFromXML();
            HierarchicalDataAdapter.Mappings[0].Type = typeof(TypeInfo);
        }
        void ToolTipController_BeforeShow(object sender, ToolTipControllerShowEventArgs e) {
            ISunburstItem sunburstItem = (ISunburstItem)e.SelectedObject;
            string namespaceString = "DevExpress.XtraBars";
            foreach(ISunburstItem item in sunburstControl1.GetItemPath(sunburstItem))
                namespaceString += "." + item.Label.ToString();
            SuperToolTip superToolTip = new SuperToolTip() { MaxWidth = 400 };
            superToolTip.Items.Add(new ToolTipTitleItem() { Text = namespaceString });
            superToolTip.Items.Add(new ToolTipSeparatorItem());
            superToolTip.Items.Add(new ToolTipItem() { Text = "Types Count: " + sunburstItem.Value });

            e.SuperTip = superToolTip;
        }
        void LoadData(XElement element, List<TypeInfo> datas) {
            TypeInfo data = new TypeInfo() { NamespaceString = element.Element("Namespace").Value, TypesCount = Convert.ToDouble(element.Element("TypesCount").Value, CultureInfo.InvariantCulture) };
            datas.Add(data);
            foreach(XElement item in element.Element("NestedNamespaces").Elements())
                LoadData(item, data.NestedNamespaces);
        }
        List<TypeInfo> LoadDataFromXML() {
            XDocument document = XDocument.Load(Utils.GetRelativePath("XtraBarsTypes.xml"));
            List<TypeInfo> datas = new List<TypeInfo>();
            if(document != null) {
                foreach(XElement element in document.Element("ArrayOfTypeInfo").Elements())
                    LoadData(element, datas);
            }
            return datas;
        }
    }

    public class TypeInfo {
        readonly List<TypeInfo> _nestedNamespaces = new List<TypeInfo>();

        public string NamespaceString { get; set; }
        public double TypesCount { get; set; }
        public List<TypeInfo> NestedNamespaces { get { return _nestedNamespaces; } }
    }
}
