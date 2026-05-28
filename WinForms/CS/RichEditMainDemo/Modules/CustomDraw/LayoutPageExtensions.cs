using DevExpress.XtraRichEdit.API.Layout;
using DevExpress.XtraRichEdit.API.Native;
using System.Collections.Generic;
using System.Linq;

namespace DevExpress.XtraRichEdit.Demos.Modules.CustomDraw {
    internal static class LayoutPageExtensions {
        public static IEnumerable<FixedRange> GetVisibleRanges(this LayoutPage layoutPage, IEnumerable<FixedRange> ranges) {
            if(ranges is null)
                return null;
            return ranges.Where(layoutPage.IsRangeVisible);
        }
        public static bool IsRangeVisible(this LayoutPage layoutPage, FixedRange range) {
            FixedRange visibleRange = layoutPage.MainContentRange;
            return visibleRange.Contains(range);
        }
    }
}
