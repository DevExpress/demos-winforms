using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using DevExpress.DXperience.Demos;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraVerticalGrid.Rows;

namespace DevExpress.XtraVerticalGrid.Demos {
    public class VehiclesData {
        public enum Category {
            Car = 1,
            [Display(Name = "Crossover & SUV")]
            CrossoverAndSUV = 2,
            Truck = 3,
            Minivan = 4
        }
        public enum BodyStyle {
            Convertible = 1,
            Coupe = 2,
            Hatchback = 3,
            [Display(Name = "Passenger Van")]
            PassengerVan = 4,
            Pickup = 5,
            Sedan = 6,
            [Display(Name = "Sport Utility Vehicle")]
            SportUtilityVehicle = 7,
            Wagon = 8
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
        public class OrderItem {
            internal Model Model;
            public OrderItem(Model model, int days, DevExpress.Data.Utils.NonCryptographicRandom rnd, int id) {
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
                SalesDate = TutorialConstants.Now.AddDays(-rnd.Next(days));
                Discount = Math.Round(0.05 * rnd.Next(4), 2);
                OrderID = id;
            }
            public int OrderID { get; set; }
            public DateTime SalesDate { get; set; }
            public double Discount { get; set; }
            [DataType(DataType.Currency)]
            public decimal? ModelPrice { get; set; }
            public int Trademark { get; set; }
            public string Name { get; set; }
            public string Modification { get; set; }
            public int Category { get; set; }
            public int? MPGCity { get; set; }
            public int? MPGHighway { get; set; }
            public int Doors { get; set; }
            [EnumDataType(typeof(BodyStyle))]
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
            public decimal? Price { get; set; }
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
            public string TrademarkName { get { return Trademarks != null ? Trademarks[Trademark - 1].Name : string.Empty; } }
            public Bitmap GetSmallTrademarkImage() {
                return Trademarks[Trademark - 1].CaptionLogo;
            }
            public List<VehiclesData.Trademark> Trademarks = null;
            internal string LicenseInfo { get; set; }
        }

        public static void InitOrdersData(string dataFileName, VGridControl vGridControl, int itemCount, int dataInterval) {
            DataSet ds = null;
            List<Trademark> trademarks = null;
            List<Model> models = InitXMLDataCore(dataFileName, out ds, out trademarks, 1);
            vGridControl.DataSource = CreateOrders(models, itemCount, dataInterval);
            CreateEditors(vGridControl, ds, trademarks);
        }
        static List<Model> InitXMLDataCore(string dataFileName, out DataSet ds, out List<Trademark> listTrademarks) {
            return InitXMLDataCore(dataFileName, out ds, out listTrademarks, 30);
        }
        static List<Model> InitXMLDataCore(string dataFileName, out DataSet ds, out List<Trademark> listTrademarks, int dataInterval) {
            string Model = "Model";
            string Trademark = "Trademark";
            ds = GetDataSet(dataFileName);
            listTrademarks = new List<VehiclesData.Trademark>();
            foreach(DataRow row in ds.Tables[Trademark].Rows)
                listTrademarks.Add(new VehiclesData.Trademark() {
                    ID = (int)(row["ID"]),
                    Name = (string)row["Name"],
                    Logo = ByteImageConverter.FromByteArray((byte[])row["Logo"])
                });
            var listModels = new List<VehiclesData.Model>();
            foreach(DataRow row in ds.Tables[Model].Rows)
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
                    Photo = ByteImageConverter.FromByteArray((byte[])row["Photo"]),
                    DeliveryDate = TutorialConstants.Now.AddDays(TutorialConstants.Random.Next(dataInterval)),
                    InStock = TutorialConstants.Random.Next(100) < 95,
                    Trademarks = listTrademarks,
                    LicenseInfo = GetLicenseInfo(row)
                });
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
        static List<OrderItem> CreateOrders(List<Model> models, int itemCount, int dataInterval) {
            var orders = new List<OrderItem>();
            for(int i = 0; i < itemCount; i++)
                orders.Add(new OrderItem(models[TutorialConstants.Random.Next(0, models.Count - 1)], dataInterval, TutorialConstants.Random, i + 1));
            return orders;
        }
        public static void InitEditors(VGridControl vGridControl) {
            if(vGridControl.Rows.Count == 0)
                return;
            foreach(var row in vGridControl.Rows)
                SetRowEditorProperties(row, vGridControl);
            BaseRow colPrice = vGridControl.Rows["Price"];
            if(colPrice != null) {
                colPrice.Properties.Format.FormatType = FormatType.Numeric;
                colPrice.Properties.Format.FormatString = "c";
            }
        }
        static void SetRowEditorProperties(BaseRow row, VGridControl vGridControl) {
            if(row is EditorRow)
                SetEditorProperties(row.Properties, vGridControl);
            if(row is CategoryRow) {
                var category = row as CategoryRow;
                if(category.HasChildren)
                    SetChildRowsEditorProperties(category.ChildRows, vGridControl);
            }
            if(row is MultiEditorRow) {
                var multiEditorRow = row as MultiEditorRow;
                if(multiEditorRow.HasChildren)
                    SetChildRowsEditorProperties(multiEditorRow.ChildRows, vGridControl);
                if(multiEditorRow.PropertiesCollection.Count > 0)
                    SetEditorPropertiesCollection(multiEditorRow.PropertiesCollection, vGridControl);
            }
        }
        static void SetEditorProperties(RowProperties rowProperties, VGridControl vGridControl) {
            RepositoryItem item = GetEditByFielsName(rowProperties.FieldName, vGridControl.RepositoryItems);
            if(item != null && rowProperties.RowEdit == null)
                rowProperties.RowEdit = item;
        }
        static void SetChildRowsEditorProperties(VGridRows childRows, VGridControl vGridControl) {
            foreach(var row in childRows)
                SetRowEditorProperties(row, vGridControl);
        }
        static void SetEditorPropertiesCollection(MultiEditorRowPropertiesCollection propertiesCollection, VGridControl vGridControl) {
            foreach(RowProperties rowProperties in propertiesCollection)
                SetEditorProperties(rowProperties, vGridControl);
        }
        static RepositoryItem GetEditByFielsName(string fieldName, RepositoryItemCollection repositoryItemCollection) {
            foreach(RepositoryItem item in repositoryItemCollection)
                if(item.Name.IndexOf("/" + fieldName) >= 0)
                    return item;
            return null;
        }
        static void CreateEditors(VGridControl vGridControl, DataSet ds, List<Trademark> trademarks) {
            CreateSimpleLookUpEdit(vGridControl, ds.Tables["Category"], "/Category");
            CreateSimpleLookUpEdit(vGridControl, ds.Tables["BodyStyle"], "/BodyStyle");
            CreateSimpleLookUpEdit(vGridControl, ds.Tables["TransmissionType"], "/TransmissionType");
            CreateSimpleLookUpEdit(vGridControl, ds.Tables["Trademark"], "/Trademark"); // TODO images
            CreateSpinEdit(vGridControl, "/MPGCity/MPGHighway", 100, 1);
            CreateSpinEdit(vGridControl, "/Doors", 10, 1);
            CreateSpinEdit(vGridControl, "/Cylinders", 20, 1);
            CreateSpinEdit(vGridControl, "/TransmissionSpeeds", 20, -1);
            CreateCurrencyEdit(vGridControl, "/Price/ModelPrice");
            CreatePictureEdit(vGridControl, "/TrademarkImage/Photo/Image");
        }
        static RepositoryItemLookUpEdit CreateSimpleLookUpEdit(VGridControl vGridControl, DataTable tbl, string name) {
            RepositoryItemLookUpEdit ret = new RepositoryItemLookUpEdit();
            vGridControl.RepositoryItems.Add(ret);
            ret.AutoHeight = false;
            ret.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new LookUpColumnInfo("Name", "Name") });
            ret.PopupFormMinSize = new Size(100, 0);
            ret.DisplayMember = "Name";
            ret.Name = name;
            ret.ShowFooter = false;
            ret.ShowHeader = false;
            ret.ValueMember = "ID";
            ret.DataSource = tbl;
            ret.DropDownRows = tbl.Rows.Count;
            ret.NullText = string.Empty;
            return ret;
        }
        static RepositoryItemSpinEdit CreateSpinEdit(VGridControl vGridControl, string name, int maxValue, int minValue) {
            RepositoryItemSpinEdit ret = new RepositoryItemSpinEdit();
            vGridControl.RepositoryItems.Add(ret);
            ret.AutoHeight = false;
            ret.IsFloatValue = false;
            ret.Mask.EditMask = "N00";
            ret.MaxValue = maxValue;
            ret.MinValue = minValue;
            ret.Name = name;
            return ret;
        }
        static RepositoryItemTextEdit CreateCurrencyEdit(VGridControl vGridControl, string name) {
            RepositoryItemTextEdit ret = new RepositoryItemTextEdit();
            vGridControl.RepositoryItems.Add(ret);
            ret.AutoHeight = false;
            ret.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            ret.Mask.EditMask = "c";
            ret.Mask.UseMaskAsDisplayFormat = true;
            ret.Name = name;
            return ret;
        }
        static RepositoryItemPictureEdit CreatePictureEdit(VGridControl vGridControl, string name) {
            RepositoryItemPictureEdit ret = new RepositoryItemPictureEdit();
            vGridControl.RepositoryItems.Add(ret);
            ret.PictureInterpolationMode = InterpolationMode.HighQualityBicubic;
            ret.SizeMode = PictureSizeMode.Squeeze;
            ret.Name = name;
            return ret;
        }
    }
}
