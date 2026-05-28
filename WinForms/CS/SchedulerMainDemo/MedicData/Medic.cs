using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace DevExpress.XtraScheduler.Demos {
    public class Medic {
        [Key]
        public Int64 Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public byte[] PhotoBytes { get; set; }
        public Int64? DepartmentId { get; set; }

        public void SetPhoto(Image image) {
            if (image == null) {
                PhotoBytes = null;
                return;
            }
            using (MemoryStream stream = new MemoryStream()) {
                image.Save(stream, ImageFormat.Jpeg);
                PhotoBytes = stream.ToArray();
            }
        }

        public Image GetPhoto() {
            if (PhotoBytes == null)
                return null;
            using (MemoryStream stream = new MemoryStream(PhotoBytes))
                return Image.FromStream(stream);
        }
    }
}
