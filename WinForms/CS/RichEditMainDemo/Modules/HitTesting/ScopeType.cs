using System.ComponentModel;

namespace DevExpress.XtraRichEdit.Demos {
    public enum ScopeType {
        [Description("Page")]
        Page,
        [Description("Main Page Area")]
        MainPageArea,
        [Description("Header Page Area")]
        HeaderPageArea,
        [Description("Footer Page Area")]
        FooterPageArea
    }
}
