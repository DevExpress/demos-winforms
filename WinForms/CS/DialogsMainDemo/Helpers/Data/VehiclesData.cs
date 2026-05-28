using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraDialogs.Demos.Helpers.Data {
    public class VehiclesData {
        public enum Category {
            Car = 1,
            [Display(Name = "Crossover & SUV")]
            CrossoverAndSUV = 2,
            Truck = 3,
            Minivan = 4
        }
        public enum TransmissionType {
            Automatic = 1,
            Manual = 2,
            Variomatic = 3
        }
        public class BodyStyle {
            public int ID { get; set; }
            public string Name { get; set; }
        }
        public class Trademark {
            public int ID { get; set; }
            public Image Logo { get; set; }
            public string Name { get; set; }
            readonly Dictionary<int, Image> logoImages = new Dictionary<int, Image>();
            public Image GetLogo(Size size) {
                Image image = null; int imageSizeKey = (size.Width << 16) + size.Width;
                if(!logoImages.TryGetValue(imageSizeKey, out image)) {
                    image = ResizeImage(Logo, size.Height, size.Width);
                    logoImages.Add(imageSizeKey, image);
                }
                return image;
            }
        }
        public class Model {
            public int ID { get; set; }
            public int Trademark { get; set; }
            public string Name { get; set; }
            public string Modification { get; set; }
            [EnumDataType(typeof(Category))]
            public int Category { get; set; }
            public decimal Price { get; set; }
            public int? MPGCity { get; set; }
            public int? MPGHighway { get; set; }
            public int Doors { get; set; }
            public int BodyStyle { get; set; }
            public int Cylinders { get; set; }
            public string Horsepower { get; set; }
            public string Torque { get; set; }
            public int TransmissionSpeeds { get; set; }
            [EnumDataType(typeof(TransmissionType))]
            public int TransmissionType { get; set; }
            public string Description { get; set; }
            public Image Image { get; set; }
            public Image Photo { get; set; }
            public DateTime DeliveryDate { get; set; }
            public bool InStock { get; set; }
            public Image TrademarkImage {
                get { return Trademarks != null ? Trademarks[Trademark - 1].Logo : null; }
            }
            public string BodyStyleName {
                get { return BodyStyles != null ? BodyStyles[BodyStyle - 1].Name : string.Empty; }
            }
            public string TrademarkName {
                get { return Trademarks != null ? Trademarks[Trademark - 1].Name : string.Empty; }
            }
            public List<Trademark> Trademarks = null;
            public List<BodyStyle> BodyStyles = null;
            readonly Dictionary<int, Image> images = new Dictionary<int, Image>();
            public Image GetImage(Size size) {
                Image image = null; int imageSizeKey = (size.Width << 16) + size.Width;
                if(!images.TryGetValue(imageSizeKey, out image)) {
                    image = ResizeImage(Image, size.Height, size.Width);
                    images.Add(imageSizeKey, image);
                }
                return image;
            }
            internal string LicenseInfo { get; set; }
        }
        public static Bitmap ResizeImage(Image image, int height, int maxWidth) {
            int width = Math.Min(image.Width * height / image.Height, maxWidth);
            int heightImage = image.Height * width / image.Width;
            Rectangle destRect = new Rectangle(0, (height - heightImage) / 2, width, heightImage);
            Bitmap destImage = new Bitmap(width, height);
            using(Graphics graphics = Graphics.FromImage(destImage)) {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel);
            }
            return destImage;
        }
        public static List<Model> InitXMLDataCore(string dataFileName) {
            var ds = GetDataSet(dataFileName);
            var listStyles = new List<BodyStyle>();
            foreach(DataRow row in ds.Tables["BodyStyle"].Rows) {
                listStyles.Add(new VehiclesData.BodyStyle() {
                    ID = (int)(row["ID"]),
                    Name = (string)row["Name"],
                });
            }
            var listTrademarks = new List<VehiclesData.Trademark>();
            foreach(DataRow row in ds.Tables["Trademark"].Rows) {
                listTrademarks.Add(new VehiclesData.Trademark() {
                    ID = (int)(row["ID"]),
                    Name = (string)row["Name"],
                    Logo = ByteImageConverter.FromByteArray((byte[])row["Logo"])
                });
            }
            var listModels = new List<VehiclesData.Model>();
            foreach(DataRow row in ds.Tables["Model"].Rows) {
                listModels.Add(new VehiclesData.Model() {
                    ID = (int)row["ID"],
                    Name = (string)row["Name"],
                    Trademark = (int)row["TrademarkID"],
                    Modification = (string)row["Modification"],
                    Category = (int)row["CategoryID"],
                    Price = (decimal)row["Price"],
                    MPGCity = System.DBNull.Value.Equals(row["MPG City"]) ? null : (int?)row["MPG City"],
                    MPGHighway = System.DBNull.Value.Equals(row["MPG City"]) ? null : (int?)row["MPG Highway"],
                    Doors = (int)row["Doors"],
                    BodyStyle = (int)row["BodyStyleID"],
                    Cylinders = (int)row["Cylinders"],
                    Horsepower = (string)row["Horsepower"],
                    Torque = (string)row["Torque"],
                    TransmissionSpeeds = Convert.ToInt32(row["Transmission Speeds"]),
                    TransmissionType = ((string)row["Modification"]).Contains("VA") ? 3 : (int)row["Transmission Type"],
                    Description = string.Format("{0}", row["Description"]),
                    Image = ResizeImage(ByteImageConverter.FromByteArray((byte[])row["Photo"]), 128, 128),
                    Photo = ByteImageConverter.FromByteArray((byte[])row["Photo"]),
                    DeliveryDate = TutorialConstants.Now.AddDays(TutorialConstants.Random.Next(30)),
                    InStock = TutorialConstants.Random.Next(100) < 95,
                    Trademarks = listTrademarks,
                    BodyStyles = listStyles,
                    LicenseInfo = GetLicenseInfo(row)
                });
            }
            return listModels;
        }
        internal static string GetLicenseInfo(DataRow row) {
            return $"{row["License Name"]}|{row["Author"]}|{row["Source"]}|{row["Edits"]}";
        }
        readonly static Dictionary<string, DataSet> dataSets = new Dictionary<string, DataSet>();
        static DataSet GetDataSet(string dataFileName) {
            DataSet ds = null;
            if(!dataSets.TryGetValue(dataFileName, out ds)) {
                ds = new DataSet();
                ds.ReadXml(dataFileName);
                dataSets.Add(dataFileName, ds);
            }
            return ds;
        }
    }
}
