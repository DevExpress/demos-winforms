using System.Reflection;
using DevExpress.XtraRichEdit;
using System.IO;
using DevExpress.DXperience.Demos;

namespace DevExpress.AI.Demos {
    public partial class RichEditAIModule : AITutorialControl {
        public RichEditAIModule() {
            AutoMergeRibbon = true;
            InitializeComponent();
            if(!DemoHelper.IsTesting) {
                using(var documentStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("DevExpress.AI.Demos.Data.FirstLook.docx")) {
                    if(documentStream == null)
                        throw new FileNotFoundException("Embedded document resource not found.");
                    richEditControl1.LoadDocument(documentStream, DocumentFormat.OpenXml);
                }
            }
            else {
                richEditControl1.Options.VerticalScrollbar.Visibility = RichEditScrollbarVisibility.Hidden;
            }
            UpdatePaddings();
        }
        protected override void UpdatePaddings() {
            UpdateBottomSpacings(lciUcDisclaimerPanel1, ucDisclaimerPanel1.RoundedPanelOffset);
        }
    }
}
