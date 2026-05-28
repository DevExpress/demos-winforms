using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace DevExpress.XtraNavBar.Demos {
    public partial class AccordionControlMultimediaModule : TutorialControl {
        public AccordionControlMultimediaModule() {
            InitializeComponent();
            WorkingFolder = DataPath;
            if(!string.IsNullOrEmpty(WorkingFolder)) {
                InitializeContent();
                SetImage(Images[0]);
            }
        }
        protected virtual void InitializeContent() {
            InitializeTileControl();
            UpdateEditors();
            galleryFilters.SizeChanged += OnGalleryFiltersSizeChanged;
        }
        protected virtual void InitializeTileControl() {
            (tileControl1 as ITileControl).ViewInfo.UseAdvancedTextRendering = false;
            if(TileGroupImages == null)
                return;
            TileControl.Groups.Clear();
            TileControl.Groups.Add(TileGroupImages);
        }
        protected virtual void InitializeImages() {
            if(string.IsNullOrEmpty(WorkingFolder))
                return;
            Images = new List<Image>();
            string[] files = Directory.GetFiles(WorkingFolder, "*.jpg");
            foreach(string file in files) {
                Image img = Bitmap.FromFile(file);
                img.Tag = file;
                Images.Add(img);
            }
            InitializeTileControl();
        }
        protected virtual List<Image> Images { get; set; }
        protected virtual TileControl TileControl {
            get { return tileControl1; }
        }
        protected virtual PictureEdit PictureEdit {
            get { return peCurrentImage; }
        }
        protected virtual GalleryItemGroup FilterGroup {
            get { return galleryFilters.Gallery.Groups[0]; }
        }
        protected virtual Size PreviewSize {
            get { return galleryFilters.Gallery.ImageSize; }
        }
        Image originalImageCore;
        protected virtual Image OriginalImage {
            get { return originalImageCore; }
            set {
                originalImageCore = value;
                peOriginalImage.Image = originalImageCore;
                UpdateImageProperties();
            }
        }
        Image currentImageCore;
        protected virtual Image CurrentImage {
            get { return currentImageCore; }
            set {
                currentImageCore = value;
                if(CurrentImage == null) return;
                PictureEdit.Image = CurrentImage;
                CalcCurrentImageZoomPercent(currentImageCore);
                UpdateEditors();
            }
        }
        protected virtual void CalcCurrentImageZoomPercent(Image img) {
            PictureEdit.Properties.ZoomPercent = Math.Min(((double)PictureEdit.Height / (double)img.Height) * 100, 100);
        }
        string workingFolderCore;
        protected virtual string WorkingFolder {
            get { return workingFolderCore; }
            set {
                if(workingFolderCore == value) return;
                workingFolderCore = value;
                InitializeImages();
            }
        }
        TileGroup group;
        protected virtual TileGroup TileGroupImages {
            get {
                if(group == null)
                    group = CreateTileGroupImages();
                return group;
            }
        }
        protected virtual void SetImage(Image img) {
            CurrentImage = OriginalImage = img;
            RefreshFilters(OriginalImage);
        }
        protected string DataPath {
            get {
                string dataDir = Tutorials.FilePathUtils.FindDirPath("Data");
                string dataPathCore = Path.Combine(dataDir, "AccordionControlData");
                if(Directory.Exists(dataPathCore))
                    return dataPathCore;
                return string.Empty;
            }
        }
        protected virtual void UpdateEditors() {
            bool value = CurrentImage != null;
            tbRed.Enabled = value;
            tbGreen.Enabled = value;
            tbBlue.Enabled = value;
            tbBrightness.Enabled = value;
            tbContrast.Enabled = value;

            tbRed.Value = tbRed.Properties.Minimum;
            tbGreen.Value = tbGreen.Properties.Minimum;
            tbBlue.Value = tbBlue.Properties.Minimum;
            tbBrightness.Value = tbBrightness.Properties.Minimum;
            tbContrast.Value = tbContrast.Properties.Minimum;
        }
        protected virtual TileGroup CreateTileGroupImages() {
            if(Images == null || Images.Count == 0)
                return null;
            TileGroup g = new TileGroup();
            foreach(Image img in Images) {
                TileItem item = new TileItem() {
                    BackgroundImage = img,
                    BackgroundImageScaleMode = TileItemImageScaleMode.Squeeze,
                    BackgroundImageAlignment = TileItemContentAlignment.MiddleCenter
                };
                g.Items.Add(item);
            }
            return g;
        }
        protected virtual void RefreshFilters(Image img) {
            FilterGroup.Items.Clear();
            foreach(FilterBase filter in FilterList) {
                FilterGroup.Items.Add(CreateGalleryItemFilter(img, filter));
            }
        }
        bool updatingAccordionWidth;
        protected virtual void OnGalleryFiltersSizeChanged(object sender, EventArgs e) {
            UpdateAccordionPanelWidth();
        }
        protected virtual void UpdateAccordionPanelWidth() {
            if(updatingAccordionWidth) return;
            if(FilterGroup.Items.Count == 0) return;
            updatingAccordionWidth = true;
            try {
                Size bestSize = galleryFilters.GetPreferredSize(Size.Empty);
                int delta = bestSize.Width - galleryFilters.Width;
                if(delta == 0) return;
                panelControl7.Width += delta;
            }
            finally {
                updatingAccordionWidth = false;
            }
        }
        protected virtual void UpdateImageProperties() {
            ratingImage.Rating = ImageHelper.GetRating(OriginalImage);
            lblSize.Text = ImageHelper.GetSize(OriginalImage);
            lblName.Text = ImageHelper.GetName(OriginalImage);
            lblDimension.Text = ImageHelper.GetDimension(OriginalImage);
        }
        protected virtual GalleryItem CreateGalleryItemFilter(Image img, FilterBase filter) {
            GalleryItem item = new GalleryItem() {
                Image = filter.ApplyFilter(img, PreviewSize),
                Caption = filter.Name,
            };
            item.ItemClick += delegate { PictureEdit.Image = filter.ApplyFilter(img, img.Size); };
            return item;
        }
        protected virtual void OnPictureEditCurrentImageSizeChanged(object sender, EventArgs e) {
            if(CurrentImage == null)
                return;
            CalcCurrentImageZoomPercent(CurrentImage);
        }
        protected virtual void OnTbRedEditValueChanged(object sender, EventArgs e) { OnChangeColor(); }
        protected virtual void OnTbGreenEditValueChanged(object sender, EventArgs e) { OnChangeColor(); }
        protected virtual void OnTbBlueEditValueChanged(object sender, EventArgs e) { OnChangeColor(); }
        protected virtual void OnChangeColor() {
            if(CurrentImage == null)
                return;
            PictureEdit.Image = UniversalFilterInstance.ApplyFilter(CurrentImage, CurrentImage.Size, tbRed.Value, tbGreen.Value, tbBlue.Value);
        }
        protected void OnBrightnessChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e) {
            int val = tbBrightness.Value;
            PictureEdit.Image = UniversalFilterInstance.ApplyFilter(CurrentImage, CurrentImage.Size, val, val, val);
        }
        protected virtual void OnContrastChanged(object sender, EventArgs e) {
            if(CurrentImage == null)
                return;
            int val = tbContrast.Value;
            PictureEdit.Image = ContrastFilterInstance.ApplyFilter(CurrentImage, CurrentImage.Size, val);
        }
        protected virtual void OnTileControlItemClick(object sender, TileItemEventArgs e) {
            SetImage(e.Item.BackgroundImage);
        }
        #region Filters
        List<FilterBase> filterListCore;
        protected virtual List<FilterBase> FilterList {
            get {
                if(filterListCore == null) {
                    filterListCore = new List<FilterBase>(){
                        new PolaroidFilter(),
                        new BGRFilter(),
                        new GBRFilter(),
                        new SepiaFilter(),
                        new GrayScaleFilter(),
                        new NegativeFilter(),
                    };
                }
                return filterListCore;
            }
        }
        UniversalFilter universalFilter;
        protected virtual UniversalFilter UniversalFilterInstance {
            get {
                if(universalFilter == null)
                    universalFilter = new UniversalFilter();
                return universalFilter;
            }
        }
        ContrastFilter contrastFilter;
        protected virtual ContrastFilter ContrastFilterInstance {
            get {
                if(contrastFilter == null)
                    contrastFilter = new ContrastFilter();
                return contrastFilter;
            }
        }
        #endregion
    }
    //
    public static class ImageHelper {
        public static string GetDimension(Image img) {
            if(img == null) return "0x0";
            return string.Format("{0}x{1}", img.Width, img.Height);
        }
        public static string GetName(Image img) {
            if(img == null) return string.Empty;
            return Path.GetFileName(img.Tag.ToString());
        }
        public static string GetSize(Image img) {
            if(img == null) return "0 KB";
            return (new FileInfo(img.Tag.ToString()).Length / 1024).ToString() + " KB";
        }
        public static int GetRating(Image img) {
            if(img == null) return 0;
            return TutorialConstants.Random.Next(5);
        }
        readonly static Dictionary<string, Bitmap> images = new Dictionary<string, Bitmap>();
        public static Bitmap CreateSenderImage(string sender, Size size, DevExpress.LookAndFeel.UserLookAndFeel ulf) {
            Bitmap img = null;
            if(images.TryGetValue(sender, out img))
                return img;
            Size imageSize = new Size(size.Width, size.Height);
            string[] parsedText = sender.Split(' ');
            string result = string.Empty;
            int count = 0;
            for(int i = 0; i < parsedText.Length; i++) {
                if(parsedText[i].Length > 0) {
                    result += parsedText[i][0];
                    count++;
                    if(count == 2) break;
                }
            }
            img = GlyphPainter.CreateRoundedStubGlyph(ulf, imageSize, result);
            images.Add(sender, img);
            return img;
        }
    }
    public delegate void GalleryItemApplyFilter(string name, Image image, FilterBase filter);
    public class FilterBase {
        public virtual string Name { get { return string.Empty; } }
        public Image ApplyFilter(Image image, Size size) {
            return ApplyMatrix(image, size, Matrix);
        }
        protected virtual ColorMatrix Matrix { get { return new ColorMatrix(); } }
        protected Bitmap ApplyMatrix(Image image, Size size, ColorMatrix matrix) {
            Bitmap src = new Bitmap(image, size);
            Bitmap dest = new Bitmap(src.Width, src.Height, PixelFormat.Format32bppArgb);
            using(Graphics graphics = Graphics.FromImage(dest)) {
                ImageAttributes bmpAttributes = new ImageAttributes();
                bmpAttributes.SetColorMatrix(matrix);
                graphics.DrawImage(src, new Rectangle(0, 0, src.Width, src.Height), 0, 0, src.Width, src.Height, GraphicsUnit.Pixel, bmpAttributes);
            }
            src.Dispose();
            return dest;
        }
    }
    public class PolaroidFilter : FilterBase {
        public override string Name { get { return "Polaroid"; } }
        protected override ColorMatrix Matrix {
            get {
                return new ColorMatrix(new float[][] {
                    new float[] {1.438f, -0.062f, -0.062f, 0, 0},
                    new float[] {-0.122f, 1.378f, -0.122f, 0, 0},
                    new float[] {0.016f, -0.016f, 1.438f, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0.03f, 0.05f, -0.2f, 0, 1}
                });
            }
        }
    }
    public class GrayScaleFilter : FilterBase {
        public override string Name { get { return "GrayScale"; } }
        protected override ColorMatrix Matrix {
            get {
                return new ColorMatrix(new float[][] {
                    new float[] {.3f, .3f, .3f, 0, 0},
                    new float[] {.59f, .59f, .59f, 0, 0},
                    new float[] {.11f, .11f, .11f, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1}
                });
            }
        }
    }
    public class NegativeFilter : FilterBase {
        public override string Name { get { return "Negative"; } }
        protected override ColorMatrix Matrix {
            get {
                return new ColorMatrix(new float[][] {
                    new float[] {-1, 0, 0, 0, 0},
                    new float[] {0, -1, 0, 0, 0},
                    new float[] {0, 0, -1, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {1, 1, 1, 0, 1}
                });
            }
        }
    }
    public class SepiaFilter : FilterBase {
        public override string Name { get { return "Sepia"; } }
        protected override ColorMatrix Matrix {
            get {
                return new ColorMatrix(new float[][] {
                    new float[] {.393f, .349f, .272f, 0, 0},
                    new float[] {.769f, .686f, .534f, 0, 0},
                    new float[] {.189f, .168f, .131f, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1}
                });
            }
        }
    }
    public class BGRFilter : FilterBase {
        public override string Name { get { return "BGR"; } }
        protected override ColorMatrix Matrix {
            get {
                return new ColorMatrix(new float[][] {
                    new float[] {0, 0, 1, 0, 0},
                    new float[] {0, 1, 0, 0, 0},
                    new float[] {1, 0, 0, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1}
                });
            }
        }
    }
    public class GBRFilter : FilterBase {
        public override string Name { get { return "GBR"; } }
        protected override ColorMatrix Matrix {
            get {
                return new ColorMatrix(new float[][] {
                    new float[] {0, 1, 0, 0, 0},
                    new float[] {0, 0, 1, 0, 0},
                    new float[] {1, 0, 0, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1}
                });
            }
        }
    }
    public class UniversalFilter : FilterBase {
        public UniversalFilter() {
            r = g = b = 0;
        }
        int r, g, b;
        public Image ApplyFilter(Image image, Size size, int r, int g, int b) {
            this.r = r;
            this.g = g;
            this.b = b;
            return ApplyMatrix(image, size, Matrix);
        }
        public override string Name { get { return "Universal"; } }
        protected override ColorMatrix Matrix {
            get {
                return new ColorMatrix(new float[][] {
                    new float[] {1 + (float)(r / 255.0f), 0, 0, 0, 0},
                    new float[] {0, 1 + (float)(g/ 255.0f), 0, 0, 0},
                    new float[] {0, 0, 1 + (float)(b/ 255.0f), 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0.1f, 0.1f, 0.1f, 0, 1}
                });
            }
        }
    }
    public class ContrastFilter : FilterBase {
        public ContrastFilter() {
            scale = translate = 0;
        }
        float scale;
        float translate;
        public override string Name { get { return "Contrast"; } }
        public Image ApplyFilter(Image image, Size size, int val) {
            scale = val;
            translate = (-.5f * scale + .5f) * 255.0f;
            return ApplyMatrix(image, size, Matrix);
        }
        protected override ColorMatrix Matrix {
            get {
                return new ColorMatrix(new float[][] {
                    new float[] {1 + scale / 100, 0, 0, 0, translate},
                    new float[] {0, 1 + scale / 100, 0, 0, translate},
                    new float[] {0, 0, 1 + scale / 100, 0, translate},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1}
                });
            }
        }
    }
}
