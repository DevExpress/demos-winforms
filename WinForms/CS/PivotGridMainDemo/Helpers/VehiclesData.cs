using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using DevExpress.Data.Filtering;
using DevExpress.Data.Utils;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;

namespace DevExpress.XtraPivotGrid.Demos.Helpers {
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
            Bitmap captionLogoBitmap = null;
            public int ID { get; set; }
            public Image Logo { get; set; }
            public string Name { get; set; }
            public Bitmap CaptionLogo {
                get {
                    if(captionLogoBitmap == null)
                        captionLogoBitmap = ResizeImage(Logo, 24, 70);
                    return captionLogoBitmap;
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

        public class TrademarkItem {
            internal Model Model;
            public TrademarkItem(int id) {
                ID = id;
            }

            public int ID { get; set; }
            public int TrademarkID { get; set; }
            public string Name { get; set; }
            [CustomFunction(IsBlackFridayFunction.FunctionName), CustomFunction(IsWeekendFunction.FunctionName)]
            public DateTime? SalesDate { get; set; }
            public double? Discount { get; set; }
            [DataType(DataType.Currency)]
            public decimal? ModelPrice { get; set; }
            public int Trademark { get; set; }
            public string Modification { get; set; }
            public int Category { get; set; }
            public int? MPGCity { get; set; }
            public int? MPGHighway { get; set; }
            public int Doors { get; set; }
            [EnumDataType(typeof(BodyStyle))]
            public int? BodyStyle { get; set; }
            public int? Cylinders { get; set; }
            public string Horsepower { get; set; }
            public string Torque { get; set; }
            public int TransmissionSpeeds { get; set; }
            public int TransmissionType { get; set; }
            public Image Photo { get { return (Model != null) ? Model.Photo : null; } }
        }
        public class TrademarkBody : TrademarkItem {
            public TrademarkBody(OrderItem item, int id)
                : base(id) {
                Model = item.Model;

                ModelPrice = item.Model.Price;
                Name = item.Model.Name;
                Modification = item.Model.Modification;
                Category = item.Model.Category;
                MPGCity = item.Model.MPGCity;
                MPGHighway = item.Model.MPGHighway;
                Doors = item.Model.Doors;
                BodyStyle = item.Model.BodyStyle;
                Cylinders = item.Model.Cylinders;
                Horsepower = item.Model.Horsepower;
                Torque = item.Model.Torque;
                TransmissionSpeeds = item.Model.TransmissionSpeeds;
                TransmissionType = item.Model.TransmissionType;
                Trademark = item.Model.Trademark;
                TrademarkID = item.Model.Trademark - 1;

                SalesDate = item.SalesDate;
                Discount = item.Discount;
            }
        }

        public class OrderItem {
            internal Model Model;
            public OrderItem(Model model, int days, NonCryptographicRandom rnd, int id) {
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
            public string TrademarkName {
                get { return Trademarks != null ? Trademarks[Trademark - 1].Name : string.Empty; }
            }
            public Bitmap GetSmallTrademarkImage() {
                return Trademarks[Trademark - 1].CaptionLogo;
            }
            public List<VehiclesData.Trademark> Trademarks = null;
        }
        class OrdersData {
            public OrdersData(DataSet ds, List<Trademark> trademarks, List<Model> models, int itemCount, int days) {
                DataSet = ds;
                Trademarks = trademarks;
                TrademarkItems = new List<TrademarkItem>();
                List<OrderItem> orders = new List<OrderItem>();
                for(int i = 0; i < itemCount; i++)
                    orders.Add(new OrderItem(models[TutorialConstants.Random.Next(0, models.Count - 1)], days, TutorialConstants.Random, i + 1));
                int id = 0;
                foreach(OrderItem item in orders) {
                    TrademarkItems.Add(new TrademarkBody(item, id));
                    id++;
                }
            }
            public DataSet DataSet {
                get;
                private set;
            }
            public List<Trademark> Trademarks {
                get;
                private set;
            }
            public List<TrademarkItem> TrademarkItems {
                get;
                private set;
            }
        }
        public static void InitOrdersData(string dbFileName, PivotGridControl pivot, int itemCount, int dateInterval, Action initialization) {
            var uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();
            Task.Factory.StartNew(() => {
                DataSet ds = null; List<Trademark> trademarks = null;
                List<Model> models = InitMDBDataCore(dbFileName, out ds, out trademarks, 1);
                return new OrdersData(ds, trademarks, models, itemCount, dateInterval);
            })
            .ContinueWith(load => {
                CreateEditors(pivot, load.Result.DataSet, load.Result.Trademarks);
                InitEditors(pivot);
                pivot.DataSource = load.Result.TrademarkItems;
                if(initialization != null)
                    initialization();
            }, uiScheduler);
        }
        //
        static List<Model> InitMDBDataCore(string dbFileName, out DataSet ds, out List<Trademark> listTrademarks, int dataInterval) {
            string Model = "Model";
            string Trademark = "Trademark";
            ds = new DataSet();
            ds.ReadXml(dbFileName);
            listTrademarks = new List<VehiclesData.Trademark>();
            foreach(DataRow row in ds.Tables[Trademark].Rows)
                listTrademarks.Add(new VehiclesData.Trademark() {
                    ID = (int)row["ID"],
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
                    Trademarks = listTrademarks
                });
            return listModels;
        }
        public static void InitEditors(PivotGridControl pivot) {
            if(pivot.Fields.Count == 0)
                return;
            foreach(PivotGridField field in pivot.Fields) {
                var binding = field.DataBinding as DataSourceColumnBinding;
                string fieldName = binding != null ? binding.ColumnName : field.FieldName;
                RepositoryItem item = GetEditByFielsName(fieldName, pivot.RepositoryItems);
                if(item != null && field.FieldEdit == null)
                    field.FieldEdit = item;
            }
        }
        static RepositoryItem GetEditByFielsName(string fieldName, RepositoryItemCollection repositoryItemCollection) {
            foreach(RepositoryItem item in repositoryItemCollection)
                if(item.Name.IndexOf("/" + fieldName) >= 0) return item;
            return null;
        }
        static void CreateEditors(PivotGridControl pivot, DataSet ds, List<Trademark> listTrademarks) {
            CreateLookUp(pivot, listTrademarks, "/Trademark");
        }
        static RepositoryItemLookUpEdit CreateLookUp(PivotGridControl pivot, object dataSource, string name) {
            RepositoryItemLookUpEdit ret = new RepositoryItemLookUpEdit();
            pivot.RepositoryItems.Add(ret);
            ret.AutoHeight = false;
            ret.Columns.AddRange(new LookUpColumnInfo[] { new LookUpColumnInfo("Name", "Name") });
            ret.Name = name;
            ret.ShowFooter = false;
            ret.ShowHeader = false;
            ret.ValueMember = "ID";
            ret.DisplayMember = "Name";
            ret.DataSource = dataSource;
            return ret;
        }
    }
}
