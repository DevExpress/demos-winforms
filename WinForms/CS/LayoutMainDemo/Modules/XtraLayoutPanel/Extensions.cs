using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraToolbox;
using DevExpress.Utils.Layout;
using DevExpress.Utils.Extensions;

namespace DevExpress.XtraLayout.Demos {
    public static class ToolboxItemExtensions {
        public static Image CreateToolboxItemImage(this ToolboxItem @this, Color foreColor) {
            return ToolboxControlHelper.CreateToolboxItemImage(@this.Caption, @this.ImageOptions.GetImage(), foreColor);
        }
    }


    public static class StackPanelLayoutItemExtensions {
        public static int GetDragDropTargetIndex(this StackPanelLayoutItem @this, Point point) {
            if(@this.MarginBounds.BottomHalfRect().Contains(point)) return @this.Index + 1;
            return @this.Index;
        }
    }
}
