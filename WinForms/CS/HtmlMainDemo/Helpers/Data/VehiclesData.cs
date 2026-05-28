using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Internal;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;

namespace DevExpress.HTML.Demos.Helpers.Data {
    public class VehiclesData {
        public enum Category {
            Car = 1,
            [Display(Name = "Crossover & SUV")]
            CrossoverAndSUV = 2,
            Truck = 3,
            Minivan = 4
        }
        public class BodyStyle {
            public int ID { get; set; }
            public string Name { get; set; }
        }
        public class Trademark {
            Bitmap captionLogoCore = null;
            public int ID { get; set; }
            public Image Logo { get; set; }
            public string Name { get; set; }
            public Bitmap CaptionLogo {
                get {
                    if(captionLogoCore == null)
                        captionLogoCore = ResizeImage(Logo, 24, 70);
                    return captionLogoCore;
                }
            }
        }
        public class OrderItem {
            internal Model Model;
            public OrderItem(int totalCount, List<Model> models, int id)
                : this(totalCount, models[id % models.Count], id) {
            }
            public OrderItem(int totalCount, Model model, int id) {
                Model = model;
                ModelPrice = model.Price;
                Trademark = model.Trademark;
                Name = model.Name;
                Modification = model.Modification;
                Category = model.Category;
                MPGCity = model.MPGCity;
                MPGHighway = model.MPGHighway;
                Doors = model.Doors;
                BodyStyle = model.BodyStyle;
                Cylinders = model.Cylinders;
                Horsepower = model.Horsepower;
                Torque = model.Torque;
                TransmissionSpeeds = model.TransmissionSpeeds;
                TransmissionType = model.TransmissionType;
                Discount = Math.Round(0.05 * ((id * Trademark) % 4), 2);
                OrderID = id;
                if(totalCount > 0)
                    CreateSalesInfo(id, totalCount);
            }
            void CreateSalesInfo(int id, int totalCount) {
                var salesPerDay = totalCount / (365.25 * 7);
                var lastSaleDateTime = TutorialConstants.Today.AddHours(-15);
                SalesDate = lastSaleDateTime.AddDays(-id / salesPerDay);
                var orderWithinYearId = (int)Math.Floor((SalesDate - new DateTime(SalesDate.Year, 1, 1)).TotalDays * salesPerDay) + 1;
                SalesID = string.Format("{0:d4}-<size=-1><b>{1:d6}</b>", SalesDate.Year, orderWithinYearId);
            }
            public OrderItem(Model model, int days, DevExpress.Data.Utils.NonCryptographicRandom rnd, int id)
                : this(-1, model, id) {
                Discount = Math.Round(0.05 * rnd.Next(4), 2);
                SalesDate = TutorialConstants.Now.AddDays(-rnd.Next(days));
            }
            public int OrderID { get; set; }
            public string SalesID { get; set; }
            public DateTime SalesDate { get; set; }
            public double Discount { get; set; }
            [DataType(DataType.Currency)]
            public decimal ModelPrice { get; set; }
            public int Trademark { get; set; }
            public string Name { get; set; }
            public string Modification { get; set; }
            public int Category { get; set; }
            public int? MPGCity { get; set; }
            public int? MPGHighway { get; set; }
            public int Doors { get; set; }
            public int BodyStyle { get; set; }
            public int Cylinders { get; set; }
            public string Horsepower { get; set; }
            public string Torque { get; set; }
            public int TransmissionSpeeds { get; set; }
            public int TransmissionType { get; set; }
            public Image Photo { get { return Model.Photo; } }
        }
        public class Model {
            public int ID { get; set; }
            public int Trademark { get; set; }
            public string Name { get; set; }
            public string Modification { get; set; }
            public int Category { get; set; }
            [DataType(DataType.Currency)]
            public decimal Price { get; set; }
            public int? MPGCity { get; set; }
            public int? MPGHighway { get; set; }
            public int Doors { get; set; }
            public int BodyStyle { get; set; }
            public int Cylinders { get; set; }
            public string Horsepower { get; set; }
            public string Torque { get; set; }
            public int TransmissionSpeeds { get; set; }
            public int TransmissionType { get; set; }
            public string Description { get; set; }
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
            public string CategoryName {
                get { return EnumDisplayTextHelper.GetDisplayText((Category)Category); }
            }
            public string CategoryNameCaps {
                get { return CategoryName?.ToUpperInvariant(); }
            }
            public Bitmap GetSmallTrademarkImage() {
                return Trademarks[Trademark - 1].CaptionLogo;
            }
            public List<Trademark> Trademarks = null;
            public List<BodyStyle> BodyStyles = null;
            public string LicenseName { get; set; }
            public string Author { get; set; }
            public string Source { get; set; }
            public string SourceLink {
                get {
                    return $"http:\\{Source}";
                }
            }
            public string Edits { get; set; }
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
        public static void InitXMLData(string dataFileName, GridControl grid) {
            InitXMLData(dataFileName, grid, 30);
        }
        public static void InitXMLData(string dataFileName, GridControl grid, int dataInterval) {
            DataSet ds = null;
            List<Trademark> listTrademarks = null;
            List<BodyStyle> listStyles = null;
            List<Model> listModels = InitXMLDataCore(dataFileName, out ds, out listTrademarks, out listStyles, dataInterval);
            grid.DataSource = listModels;
        }
        public static void InitVehiclesData(GridControl gc) {
            var DBFileName = DevAVDataDirectoryHelper.GetFile("Vehicles.xml");
            if(DBFileName != string.Empty)
                VehiclesData.InitXMLData(DBFileName, gc);
        }
        static List<Model> InitXMLDataCore(string dataFileName, out DataSet ds, out List<Trademark> listTrademarks, out List<BodyStyle> listStyles, int dataInterval) {
            string Model = "Model";
            string Trademark = "Trademark";
            ds = GetDataSet(dataFileName);
            listStyles = new List<BodyStyle>();
            foreach(DataRow row in ds.Tables["BodyStyle"].Rows) {
                listStyles.Add(new VehiclesData.BodyStyle() {
                    ID = (int)(row["ID"]),
                    Name = (string)row["Name"],
                });
            }
            listTrademarks = new List<VehiclesData.Trademark>();
            foreach(DataRow row in ds.Tables[Trademark].Rows) {
                listTrademarks.Add(new VehiclesData.Trademark() {
                    ID = (int)(row["ID"]),
                    Name = (string)row["Name"],
                    Logo = ByteImageConverter.FromByteArray((byte[])row["Logo"])
                });
            }
            var listModels = new List<VehiclesData.Model>();
            foreach(DataRow row in ds.Tables[Model].Rows) {
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
                    TransmissionType = (int)row["Transmission Type"],
                    Description = string.Format("{0}", row["Description"]),
                    Photo = CropImageHelper.Crop(ByteImageConverter.FromByteArray((byte[])row["Photo"])),
                    DeliveryDate = TutorialConstants.Now.AddDays(TutorialConstants.Random.Next(dataInterval)),
                    InStock = TutorialConstants.Random.Next(100) < 95,
                    Trademarks = listTrademarks,
                    BodyStyles = listStyles,
                    LicenseName = $"{row["License Name"]}",
                    Author = $"{row["Author"]}",
                    Source = $"{row["Source"]}",
                    Edits = $"{row["Edits"]}"
                });
            }
            return listModels;
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
    static class CropImageHelper {
        public static Image Crop(Image img) {
            Bitmap bmp = img as Bitmap;
            if(bmp == null)
                return img;
            BitmapData data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadOnly, bmp.PixelFormat);
            int size = data.Stride * data.Height;
            byte[] bt = new byte[size];

            Marshal.Copy(data.Scan0, bt, 0, size);

            int left = GetLeft(data, bt);
            int right = GetRight(data, bt);
            int top = GetTop(data, bt);
            int bottom = GetBottom(data, bt);

            bmp.UnlockBits(data);

            Rectangle crop = new Rectangle(left, top, right - left, bottom - top);
            Bitmap res = new Bitmap(bmp, crop.Width, crop.Height);
            using(Graphics g = Graphics.FromImage(res))
                g.DrawImage(bmp, new Rectangle(0, 0, res.Width, res.Height), crop, GraphicsUnit.Pixel);
            return res;
        }
        static int GetLeft(BitmapData data, byte[] bt) {
            int pixelSize = GetPixelSize(data.PixelFormat);
            for(int x = 0; x < data.Width; x ++) {
                for(int y = 0; y < data.Height; y++) {
                    int pos = y * data.Stride + x * pixelSize;
                    for(int l = 0; l < pixelSize; l++) {
                        if(bt[pos + l] < 250)  // white and alpha
                            return x;
                    }
                }
            }
            return 0;
        }
        static int GetRight(BitmapData data, byte[] bt) {
            int pixelSize = GetPixelSize(data.PixelFormat);
            for(int x = data.Width - 1; x >= 0; x --) {
                for(int y = 0; y < data.Height; y++) {
                    int pos = y * data.Stride + x * pixelSize;
                    for(int l = 0; l < pixelSize; l++) {
                        if(bt[pos + l] < 250)  // white and alpha
                            return x;
                    }
                }
            }
            return data.Width - 1;
        }
        static int GetTop(BitmapData data, byte[] bt) {
            int pixelSize = GetPixelSize(data.PixelFormat);
            for(int y = 0; y < data.Height; y ++) {
                for(int x = 0; x < data.Width; x++) {
                    int pos = y * data.Stride + x * pixelSize;
                    for(int l = 0; l < pixelSize; l++) {
                        if(bt[pos + l] < 250)  // white and alpha
                            return y;
                    }
                }
            }
            return 0;
        }
        static int GetBottom(BitmapData data, byte[] bt) {
            int pixelSize = GetPixelSize(data.PixelFormat);
            for(int y = data.Height - 1; y >= 0; y --) {
                for(int x = 0; x < data.Width; x++) {
                    int pos = y * data.Stride + x * pixelSize;
                    for(int l = 0; l < pixelSize; l++) {
                        if(bt[pos + l] < 250)  // white and alpha
                            return y;
                    }
                }
            }
            return data.Height - 1;
        }
        static int GetPixelSize(PixelFormat pixelFormat) {
            if(pixelFormat == PixelFormat.Format32bppArgb || pixelFormat == PixelFormat.Format32bppPArgb || pixelFormat == PixelFormat.Format32bppRgb)
                return 4;
            return 3;
        }
    }
}
