using System.Data;

namespace DevExpress.XtraGrid.Demos {
    public class BaseLayoutModule : TutorialControl {
        protected override void InitXMLData(string dataFileName, DataSet ds) {
            ds.ReadXml(dataFileName);
        }
        protected override string ModulesFolder {
            get { return "GridMainDemo\\ModulesLayoutView\\"; }
        }
    }
}
