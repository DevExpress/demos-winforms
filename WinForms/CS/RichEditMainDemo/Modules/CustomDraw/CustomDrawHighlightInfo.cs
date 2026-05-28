using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraRichEdit.API.Native;

namespace DevExpress.XtraRichEdit.Demos.Modules.CustomDraw {
    public enum CustomDrawHighlightType {
        Fill,
        Outline
    }
    public class CustomDrawHighlightInfo {
        public FixedRange HighlightRange { get; }
        public CustomDrawHighlightType HighlightType { get; }
        public Color HighlightColor { get; }

        public CustomDrawHighlightInfo(FixedRange highlightedRange, CustomDrawHighlightType highlightType, Color highlightColor) {
            HighlightRange = highlightedRange;
            HighlightType = highlightType;
            HighlightColor = highlightColor;
        }
    }
}
