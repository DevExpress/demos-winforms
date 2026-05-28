using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.Utils.Extensions;

namespace DevExpress.XtraLayout.Demos {
    static class ToolboxControlHelper {
        const int DefaultMargin = 4;
        static readonly Font DefaultFont = AppearanceObject.DefaultFont;

        public static Image CreateToolboxItemImage(string text, Image glyph, Color foreColor) {
            Size imageSz = CalculateImageSize(text, glyph);

            return new Bitmap(imageSz.Width, imageSz.Height).Draw(x => {
                x.DrawImage(glyph, new Point(0, 0));
                x.Graphics.DrawString(text, DefaultFont, x.GetSolidBrush(foreColor), glyph.Width + DefaultMargin, 0);
            });
        }
        static Size CalculateImageSize(string text, Image glyph) {
            Graphics graphics = GraphicsInfo.Default.AddGraphics(null);
            try {
                Size textSz = graphics.MeasureString(text, DefaultFont).ToSize();
                return new Size(glyph.Width + textSz.Width + 2 * DefaultMargin, glyph.Height * 2);
            }
            finally {
                GraphicsInfo.Default.ReleaseGraphics();
            }
        }
    }


    sealed class SimpleSizeConverter : SizeConverter {
        public override bool GetPropertiesSupported(ITypeDescriptorContext context) { return false; }
    }

    sealed class SimplePaddingConverter : PaddingConverter {
        public override bool GetPropertiesSupported(ITypeDescriptorContext context) { return false; }
    }
}
