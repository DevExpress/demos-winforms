using DevExpress.DXperience.Demos.CodeDemo;

namespace DevExpress.XtraEditors.Demos.CodeExamples {
    public class FilteringModule : CodeTutorialControlBase {
        static FilteringModule() {
            var type = typeof(DevExpress.Utils.Filtering.FilteringUIContext);
        }
        public FilteringModule()
            : base() {
        }
        protected override bool UseSameTutorialControlNameForGenerateExample {
            get { return true; }
        }
    }
}
