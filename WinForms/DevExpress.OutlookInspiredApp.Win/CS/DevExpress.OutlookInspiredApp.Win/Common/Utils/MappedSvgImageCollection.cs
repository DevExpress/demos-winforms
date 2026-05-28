using System.ComponentModel;
using System.Drawing;
using DevExpress.DevAV.Common.Utils;
using DevExpress.Utils.Svg;

namespace DevExpress.Utils {
    public class MappedSvgInfoCreator : SvgImageInfoCreator {
        public override SvgImageInfo Create(string name, DxImageUri imageUri, Size size) {
            imageUri.ResourceType = typeof(DevAV.MainForm);
            imageUri.Uri = FluentIconHelper.GetFluentIconName(imageUri.Uri);
            return base.Create(name, imageUri, size);
        }
    }
    public class MappedSvgImageCollection : SvgImageCollection {
        public MappedSvgImageCollection(IContainer container)
        : base(container) {
        }
        protected override ImageInfoCreator<SvgImage, SvgImageInfo> CreateImageInfoCreator() {
            return new MappedSvgInfoCreator();
        }
    }
}
