using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils;
using DevExpress.Xpo;

namespace DevExpress.DentalClinic.Model {
    public class Picture : XPObject {
        public const string DefaultUserPic = "DevExpress.DentalClinic.Resources.Unknown-user.png";
        public Picture(Session uow)
            : base(uow) {
        }
        Image imageCore;
        [ValueConverter(typeof(DevExpress.DentalClinic.ImageValueConverter))]
        public Image Image {
            get { return imageCore; }
            set { SetPropertyValue(nameof(Image), ref imageCore, value); }
        }
        public Image GetImage() {
            return Image ?? ResourceImageHelper.CreateImageFromResourcesEx(DefaultUserPic, typeof(Picture).Assembly);
        }
    }
}
