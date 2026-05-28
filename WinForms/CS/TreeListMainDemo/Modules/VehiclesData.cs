using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using DevExpress.DXperience.Demos;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTreeList.Columns;

namespace DevExpress.XtraTreeList.Demos {
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
        public class TrademarkItem {
            internal Model Model;
            public TrademarkItem(int id) {
                ID = id;
            }
            public int ID { get; set; }
            public int TrademarkID { get; set; }
            public string Name { get; set; }
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
        public class TrademarkHeader : TrademarkItem {
            public TrademarkHeader(string name, int id)
                : base(id) {
                Name = name;
                TrademarkID = -1;
            }
        }
        public class TrademarkBody : TrademarkItem {
            public TrademarkBody(OrderItem _item, int id)
                : base(id) {
                Model = _item.Model;

                ModelPrice = _item.Model.Price;
                Name = _item.Model.Name;
                Modification = _item.Model.Modification;
                Category = _item.Model.Category;
                MPGCity = _item.Model.MPGCity;
                MPGHighway = _item.Model.MPGHighway;
                Doors = _item.Model.Doors;
                BodyStyle = _item.Model.BodyStyle;
                Cylinders = _item.Model.Cylinders;
                Horsepower = _item.Model.Horsepower;
                Torque = _item.Model.Torque;
                TransmissionSpeeds = _item.Model.TransmissionSpeeds;
                TransmissionType = _item.Model.TransmissionType;
                Trademark = _item.Model.Trademark;
                TrademarkID = _item.Model.Trademark - 1;

                SalesDate = _item.SalesDate;
                Discount = _item.Discount;
            }
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
                get {
                    return Trademarks != null ? Trademarks[Trademark - 1].Logo : null;
                }
            }
            public string TrademarkName { get { return Trademarks != null ? Trademarks[Trademark - 1].Name : string.Empty; } }
            public Bitmap GetSmallTrademarkImage() {
                return Trademarks[Trademark - 1].CaptionLogo;
            }
            public List<VehiclesData.Trademark> Trademarks = null;
            internal string LicenseInfo { get; set; }
        }
        class OrdersData {
            public OrdersData(DataSet ds, List<Trademark> trademarks, List<Model> models, int itemCount, int dataInterval) {
                var rnd = TutorialConstants.Random;
                DataSet = ds;
                Trademarks = trademarks;
                TrademarkItems = new List<TrademarkItem>();
                List<OrderItem> orders = new List<OrderItem>();
                for(int i = 0; i < itemCount; i++)
                    orders.Add(new OrderItem(models[rnd.Next(0, models.Count - 1)], dataInterval, rnd, i + 1));
                int id = 0;
                foreach(Trademark _item in trademarks) {
                    TrademarkItems.Add(new TrademarkHeader(_item.Name, id));
                    id++;
                }
                foreach(OrderItem _item in orders) {
                    TrademarkItems.Add(new TrademarkBody(_item, id));
                    id++;
                }
                System.Threading.Thread.Sleep(1000);
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
        public static void InitOrdersData(string dbFileName, TreeList treeList, int itemCount, int dataInterval, Action initialization) {
            if(MainFormHelper.TakeScreens) {
                DataSet ds = null; List<Trademark> trademarks = null;
                List<Model> models = InitMDBDataCore(dbFileName, out ds, out trademarks, 1);
                var data = new OrdersData(ds, trademarks, models, itemCount, dataInterval);
                treeList.DataSource = data.TrademarkItems;
                CreateEditors(treeList, data.DataSet, data.Trademarks);
                if(initialization != null)
                    initialization();
                return;
            }
            var uiScheduler = System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext();
            Task.Factory.StartNew(() => {
                DataSet ds = null; List<Trademark> trademarks = null;
                List<Model> models = InitMDBDataCore(dbFileName, out ds, out trademarks, 1);
                return new OrdersData(ds, trademarks, models, itemCount, dataInterval);
            })
            .ContinueWith(load => {
                treeList.DataSource = load.Result.TrademarkItems;
                CreateEditors(treeList, load.Result.DataSet, load.Result.Trademarks);
                if(initialization != null)
                    initialization();
                treeList.LayoutChanged();
            }, uiScheduler);
        }
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
            var rnd = TutorialConstants.Random;
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
                    DeliveryDate = TutorialConstants.Now.AddDays(rnd.Next(dataInterval)),
                    InStock = rnd.Next(100) < 95,
                    Trademarks = listTrademarks,
                    LicenseInfo = GetLicenseInfo(row)
                });
            return listModels;
        }
        internal static string GetLicenseInfo(DataRow row) {
            return $"{row["License Name"]}|{row["Author"]}|{row["Source"]}|{row["Edits"]}";
        }

        public static void InitEditors(TreeList treeList) {
            if(treeList.Columns.Count == 0) return;
            foreach(TreeListColumn col in treeList.Columns) {
                RepositoryItem _item = GetEditByFielsName(col.FieldName, treeList.RepositoryItems);
                if(_item != null && col.ColumnEdit == null) col.ColumnEdit = _item;
            }
            TreeListColumn colPrice = treeList.Columns["Price"];
            if(colPrice != null) {
                colPrice.Format.FormatType = FormatType.Numeric;
                colPrice.Format.FormatString = "c";
            }
        }
        static RepositoryItem GetEditByFielsName(string fieldName, RepositoryItemCollection repositoryItemCollection) {
            foreach(RepositoryItem _item in repositoryItemCollection)
                if(_item.Name.IndexOf("/" + fieldName) >= 0) return _item;
            return null;
        }

        static void CreateEditors(TreeList treeList, DataSet ds, List<Trademark> listTrademarks) {
            CreateSimpleLookUpEdit(treeList, ds.Tables["Category"], "/Category");
            CreateSimpleLookUpEdit(treeList, ds.Tables["BodyStyle"], "/BodyStyle");
            CreateSimpleLookUpEdit(treeList, ds.Tables["TransmissionType"], "/TransmissionType");
            CreateTrademarkLookUpEdit(treeList, listTrademarks, "/Trademark");
            CreateSpinEdit(treeList, "/MPGCity/MPGHighway", 100, 1);
            CreateSpinEdit(treeList, "/Doors", 10, 1);
            CreateSpinEdit(treeList, "/Cylinders", 20, 1);
            CreateSpinEdit(treeList, "/TransmissionSpeeds", 20, -1);
            CreateCurrencyEdit(treeList, "/Price/ModelPrice");
            CreatePictureEdit(treeList, "/TrademarkImage/Photo/Image");
        }
        static RepositoryItemLookUpEdit CreateSimpleLookUpEdit(TreeList treeList, DataTable tbl, string name) {
            RepositoryItemLookUpEdit ret = new RepositoryItemLookUpEdit();
            treeList.RepositoryItems.Add(ret);
            ret.AutoHeight = false;
            ret.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name") });
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
        static RepositoryItemTreeListLookUpEditWithGlyph CreateTrademarkLookUpEdit(TreeList treeList, object ds, string name) {
            RepositoryItemTreeListLookUpEditWithGlyph riLookUpEditWithGlyph = new RepositoryItemTreeListLookUpEditWithGlyph();
            RepositoryItemPictureEdit picture = new RepositoryItemPictureEdit();
            treeList.RepositoryItems.Add(riLookUpEditWithGlyph);
            riLookUpEditWithGlyph.AutoHeight = false;
            riLookUpEditWithGlyph.NullText = string.Empty;
            riLookUpEditWithGlyph.DisplayMember = "Name";
            riLookUpEditWithGlyph.Name = name;
            picture.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            picture.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            riLookUpEditWithGlyph.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { picture });
            riLookUpEditWithGlyph.ValueMember = "ID";
            TreeList treeListInner = new TreeList();
            riLookUpEditWithGlyph.TreeList = treeListInner;
            TreeListColumn colLogo = new TreeListColumn();
            TreeListColumn colName = new TreeListColumn();
            treeListInner.Columns.AddRange(new TreeListColumn[] { colLogo, colName });
            treeListInner.OptionsView.FocusRectStyle = DrawFocusRectStyle.RowFocus;
            treeListInner.OptionsSelection.EnableAppearanceFocusedCell = false;
            treeListInner.OptionsView.ShowColumns = false;
            treeListInner.OptionsView.ShowIndicator = false;
            treeListInner.OptionsView.ShowRoot = false;
            colLogo.ColumnEdit = picture;
            colLogo.FieldName = "Logo";
            colLogo.Visible = true;
            colLogo.VisibleIndex = 0;
            colName.FieldName = "Name";
            colName.Visible = true;
            colName.VisibleIndex = 1;
            riLookUpEditWithGlyph.DataSource = ds;
            return riLookUpEditWithGlyph;
        }
        static RepositoryItemSpinEdit CreateSpinEdit(TreeList treeList, string name, int maxValue, int minValue) {
            RepositoryItemSpinEdit ret = new RepositoryItemSpinEdit();
            treeList.RepositoryItems.Add(ret);
            ret.AutoHeight = false;
            ret.IsFloatValue = false;
            ret.Mask.EditMask = "N00";
            ret.MaxValue = maxValue;
            ret.MinValue = minValue;
            ret.Name = name;
            return ret;
        }
        static RepositoryItemTextEdit CreateCurrencyEdit(TreeList treeList, string name) {
            RepositoryItemTextEdit ret = new RepositoryItemTextEdit();
            treeList.RepositoryItems.Add(ret);
            ret.AutoHeight = false;
            ret.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            ret.Mask.EditMask = "c";
            ret.Mask.UseMaskAsDisplayFormat = true;
            ret.Name = name;
            return ret;
        }
        static RepositoryItemPictureEdit CreatePictureEdit(TreeList treeList, string name) {
            RepositoryItemPictureEdit ret = new RepositoryItemPictureEdit();
            treeList.RepositoryItems.Add(ret);
            ret.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            ret.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            ret.Name = name;
            return ret;
        }
        public static ImageCollection GetTransmissionGlyphs() {
            ImageCollection result = new ImageCollection();
            result.ImageSize = ScaleUtils.ScaleValue(new Size(16, 16));
            StubGlyphOptions options = new StubGlyphOptions();
            options.ColorMode = GlyphColorMode.Red;
            result.AddImage(CreateStubGlyph("A", result.ImageSize, options, UserLookAndFeel.Default), "A");
            options.ColorMode = GlyphColorMode.Green;
            result.AddImage(CreateStubGlyph("M", result.ImageSize, options, UserLookAndFeel.Default), "M");
            options.ColorMode = GlyphColorMode.Blue;
            result.AddImage(CreateStubGlyph("V", result.ImageSize, options, UserLookAndFeel.Default), "V");
            options.ColorMode = GlyphColorMode.Yellow;
            result.AddImage(CreateStubGlyph("Ltd", result.ImageSize, options, UserLookAndFeel.Default), "Ltd");
            return result;
        }
        static Image CreateStubGlyph(string text, Size glyphSize, StubGlyphOptions options, ISkinProvider skinProvider) {
            var img = new Bitmap(glyphSize.Width, glyphSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            using(Graphics g = Graphics.FromImage(img)) {
                using(GraphicsCache cache = new GraphicsCache(g))
                    GlyphPainter.Default.DrawGlyph(cache, options, text, new Rectangle(Point.Empty, glyphSize), skinProvider, ObjectState.Normal);
            }
            return img;
        }
    }
}

namespace DevExpress.XtraTreeList.Demos {
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using DevExpress.XtraEditors;
    using DevExpress.XtraEditors.Controls;
    using DevExpress.XtraEditors.Drawing;
    using DevExpress.XtraEditors.Registrator;
    using DevExpress.XtraEditors.Repository;
    using DevExpress.XtraEditors.ViewInfo;

    public delegate void ImageByValueEventHandler(object sender, ImageByValueEventArgs e);
    public class ImageByValueEventArgs : EventArgs {
        object valueCore;
        object imageCore;
        public ImageByValueEventArgs(object value) {
            this.valueCore = value;
        }
        public object Value { get { return valueCore; } }
        public object Image {
            get { return imageCore; }
            set { imageCore = value; }
        }
    }

    public class RepositoryItemTreeListLookUpEditWithGlyph : RepositoryItemTreeListLookUpEdit {
        static RepositoryItemTreeListLookUpEditWithGlyph() {
            RegisterTreeListLookUpEditWithGlyph();
        }
        public override string EditorTypeName { get { return "TreeListLookUpEditWithGlyph"; } }
        public static void RegisterTreeListLookUpEditWithGlyph() {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo("TreeListLookUpEditWithGlyph",
                                                       typeof(TreeListLookUpEditWithGlyph),
                                                       typeof(RepositoryItemTreeListLookUpEditWithGlyph),
                                                       typeof(TreeListLookUpEditWithGlyphBaseViewInfo),
                                                       new TreeListEditPainterWithGlyph(),
                                                       false));
        }
        static readonly object getImageByValue = new object();
        public event ImageByValueEventHandler GetImageByValue {
            add { Events.AddHandler(getImageByValue, value); }
            remove { Events.RemoveHandler(getImageByValue, value); }
        }
        public object GetImage(ImageByValueEventArgs e) {
            var hander = Events[getImageByValue] as ImageByValueEventHandler;
            if(hander != null) hander(this, e);
            return e.Image;
        }
        public override void Assign(RepositoryItem _item) {
            RepositoryItemTreeListLookUpEditWithGlyph li = _item as RepositoryItemTreeListLookUpEditWithGlyph;
            if(li != null)
                this.Events.AddHandler(getImageByValue, li.Events[getImageByValue]);
            base.Assign(_item);
        }
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public virtual RepositoryItemCollection RepositoryItems {
            get { return TreeList.RepositoryItems; }
        }
    }
    public class TreeListLookUpEditWithGlyph : TreeListLookUpEdit {
        static TreeListLookUpEditWithGlyph() {
            RepositoryItemTreeListLookUpEdit.RegisterTreeListLookUpEdit();
        }
        public override string EditorTypeName {
            get { return "TreeListLookUpEditWithGlyph"; }
        }
        Image imageCore;
        protected override void Dispose(bool disposing) {
            if(disposing && imageCore != null) imageCore.Dispose();
            this.imageCore = null;
            base.Dispose(disposing);
        }
        [DefaultValue((object)null)]
        public Image Image {
            get { return imageCore; }
            set {
                if(imageCore == value) return;
                imageCore = value;
                LayoutChanged();
            }
        }
    }
    public class TreeListLookUpEditWithGlyphBaseViewInfo : TreeListLookUpEditBaseViewInfo {
        Image glyphCore;
        public static Size DefaultImageSize = new Size(60, 16);
        public TreeListLookUpEditWithGlyphBaseViewInfo(RepositoryItem _item) : base(_item) { }
        public new TreeListLookUpEditWithGlyph OwnerEdit {
            get { return base.OwnerEdit as TreeListLookUpEditWithGlyph; }
        }
        public new RepositoryItemTreeListLookUpEditWithGlyph Item {
            get { return base.Item as RepositoryItemTreeListLookUpEditWithGlyph; }
        }
        public override bool IsExistImage {
            get { return true; }
        }
        public override Size ImageSize {
            get { return Glyph == null ? Size.Empty : DefaultImageSize; }
        }
        public override DevExpress.Utils.Drawing.TextGlyphDrawModeEnum GlyphDrawMode {
            get {
                if(ImageSize.IsEmpty) 
                    return DevExpress.Utils.Drawing.TextGlyphDrawModeEnum.Text;
                return DevExpress.Utils.Drawing.TextGlyphDrawModeEnum.TextGlyph;
            }
        }
        bool requireUpdateImage = false;
        protected override void OnEditValueChanged() {
            base.OnEditValueChanged();
            if(Bounds.IsEmpty) {
                this.requireUpdateImage = true;
                return;
            }
            UpdateImage();
        }
        public override void CalcViewInfo(Graphics g) {
            if(requireUpdateImage || OwnerEdit != null && OwnerEdit.Image != null) UpdateImage();
            base.CalcViewInfo(g);
        }
        public override void Reset() {
            base.Reset();
            this.glyphCore = null;
        }
        void UpdateImage() {
            this.requireUpdateImage = false;
            this.glyphCore = GetImageCore(EditValue);
        }
        Image GetImageCore(object editValue) {
            object ret = null;
            if(OwnerEdit != null) ret = OwnerEdit.Image;
            if(ret != null)
                return (Image)ret;
            if(Item != null && editValue != nullValue && editValue != null)
                ret = Item.GetImage(new ImageByValueEventArgs(editValue));
            if(ret == null)
                return null;
            if(ret is Image)
                return (Image)ret;
            return ByteImageConverter.FromByteArray(ByteImageConverter.ToByteArray(ret));
        }
        protected override Rectangle CalcGlyphBounds() {
            Rectangle res = base.CalcGlyphBounds();
            if(Glyph != null && OwnerEdit != null && OwnerEdit.InplaceType == DevExpress.XtraEditors.Controls.InplaceType.Standalone)
                res.Width = (Glyph.Size.Width * DefaultImageSize.Height) / Glyph.Size.Height;
            return res;
        }
        public Image Glyph {
            get { return glyphCore; }
        }
    }
    public class TreeListEditPainterWithGlyph : ButtonEditPainter {
        protected override void DrawGlyphCore(ControlGraphicsInfoArgs info, ButtonEditViewInfo be) {
            TreeListLookUpEditWithGlyphBaseViewInfo vi = be as TreeListLookUpEditWithGlyphBaseViewInfo;
            if(vi.Glyph == null) return;
            info.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            info.Paint.DrawImage(info.Graphics, vi.Glyph, CalcImageRect(vi.Glyph.Size, vi.GlyphBounds), new Rectangle(Point.Empty, vi.Glyph.Size), vi.State != DevExpress.Utils.Drawing.ObjectState.Disabled);
        }
        Rectangle CalcImageRect(Size imageSize, Rectangle rect) {
            int dh = (imageSize.Height * rect.Width) / imageSize.Width;
            int dw = (imageSize.Width * rect.Height) / imageSize.Height;
            if(dh > rect.Height) {
                rect.X += (rect.Width - dw) / 2;
                rect.Width = dw;
            }
            if(dw > rect.Width) {
                rect.Y += (rect.Height - dh) / 2;
                rect.Height = dh;
            }
            return rect;
        }
    }
}
