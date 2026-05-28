using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;

namespace PhotoViewer {
    public class ThumbnailHelper {
        static ThumbnailHelper defaultHelper;
        public static ThumbnailHelper Default {
            get {
                if(defaultHelper == null)
                    defaultHelper = new ThumbnailHelper();
                return defaultHelper;
            }
        }
        Dictionary<string, Image> thumbnailsCore;
        protected Dictionary<string, Image> Thumbnails {
            get {
                if(thumbnailsCore == null)
                    thumbnailsCore = new Dictionary<string, Image>();
                return thumbnailsCore;
            }
        }
        public Image CreateThumbnail(Image image, int length) {
            Rectangle rect = ImageLayoutHelper.GetImageBounds(
                new Rectangle(0, 0, length, length), image.Size, ImageLayoutMode.ZoomInside);
            Bitmap bmp = new Bitmap(rect.Width, rect.Height);
            using(Graphics g = Graphics.FromImage(bmp)) {
                rect.X = 0; rect.Y = 0;
                g.DrawImage(image, rect);
            }
            return bmp;
        }
        public Image CreateThumbnail(Image image, string fileName, int length, string thumbPath) {
            Image bmp = CreateThumbnail(image, length);
#pragma warning disable DX0025 // no path traversal (using prefix)
            string thumbFileName = length.ToString() + "_" + fileName;
#pragma warning restore DX0025
            string digest = CalculateDigest(thumbFileName);
            try {
                if(!Directory.Exists(thumbPath))
                    Directory.CreateDirectory(thumbPath);
            }
            catch(Exception e) {
                XtraMessageBox.Show("Error creating thumnail for image '" + fileName + "'. " + e.Message, "Thumbnail creator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return bmp;
        }
        public Image GetThumbnail(string fileName, int length, string thumbPath) {
#pragma warning disable DX0025 // no path traversal (using prefix and suffix)
            string thumbFileName = length.ToString() + "_" + fileName;
            thumbFileName = CalculateDigest(thumbFileName);
            thumbFileName = thumbPath + thumbFileName;
#pragma warning restore DX0025
            Image imgThumbnail = null;
            if(Thumbnails.TryGetValue(thumbFileName, out imgThumbnail))
                return imgThumbnail;
            try {
                if(File.Exists(thumbFileName))
                    return Image.FromFile(thumbFileName);
            }
            catch(Exception e) {
                XtraMessageBox.Show("Error creating thumnail for image '" + fileName + "'. " + e.Message, "Thumbnail creator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try {
                using(Image img = Image.FromFile(fileName))
                    return CreateThumbnail(img, fileName, length, thumbPath);
            }
            catch { return null; }
        }
        static string CalculateDigest(string input) {
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] digestBytes = HashCodeHelper.Persistent.CreateRH5Digest(inputBytes);
            StringBuilder sb = new StringBuilder(32);
            for(int i = 0; i < digestBytes.Length; i++)
                sb.Append(digestBytes[i].ToString("X2"));
            return sb.ToString();
        }
    }
}
