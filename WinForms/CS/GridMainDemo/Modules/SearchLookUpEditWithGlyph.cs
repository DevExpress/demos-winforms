using System;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;
using System.Drawing;
using System.ComponentModel;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraGrid.Demos {
    public class RepositoryItemSearchLookUpEditWithGlyph : RepositoryItemSearchLookUpEdit {
        static RepositoryItemSearchLookUpEditWithGlyph() {
            RegisterSearchLookUpEditWithGlyph();
        }
        readonly static object getImageByValueCore = new object();
        public event ImageByValueEventHandler GetImageByValue {
            add { Events.AddHandler(getImageByValueCore, value); }
            remove { Events.RemoveHandler(getImageByValueCore, value); }
        }
        public object GetImage(ImageByValueEventArgs e) {
            RaiseGetImageByValue(e);
            return e.Image;
        }
        protected void RaiseGetImageByValue(ImageByValueEventArgs e) {
            var handler = Events[getImageByValueCore] as ImageByValueEventHandler;
            if(handler != null) handler(this, e);
        }
        public override string EditorTypeName { get { return "SearchLookUpEditWithGlyph"; } }
        public static void RegisterSearchLookUpEditWithGlyph() {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo("SearchLookUpEditWithGlyph", 
                typeof(SearchLookUpEditWithGlyph), 
                typeof(RepositoryItemSearchLookUpEditWithGlyph),
                typeof(SearchLookUpEditWithGlyphBaseViewInfo), 
                new SearchEditPainterWithGlyph(), 
                false));
        }
        public override void Assign(RepositoryItem item) {
            var li = item as RepositoryItemSearchLookUpEditWithGlyph;
            if(li != null) 
                this.Events.AddHandler(getImageByValueCore, li.Events[getImageByValueCore]);
            base.Assign(item);
        }
        protected override void ClearClick() {
            base.ClearClick();
            SearchLookUpEditWithGlyph edit = OwnerEdit as SearchLookUpEditWithGlyph;
            if(edit != null) {
                edit.Image = null;
                edit.DoValidate();
            }
        }
    }
    public class SearchEditPainterWithGlyph : ButtonEditPainter {
        protected override void DrawGlyphCore(ControlGraphicsInfoArgs info, ButtonEditViewInfo be) {
            SearchLookUpEditWithGlyphBaseViewInfo vi = be as SearchLookUpEditWithGlyphBaseViewInfo;
            if(vi.Image == null) 
                return;
            if(vi.Image.Size.Width > vi.GetScaleDefaultSize().Width * 2)
                info.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            info.Paint.DrawImage(info.Graphics, vi.Image, vi.GlyphBounds, new Rectangle(Point.Empty, vi.Image.Size), vi.State != DevExpress.Utils.Drawing.ObjectState.Disabled);
        }
    }
    public class SearchLookUpEditWithGlyphBaseViewInfo : SearchLookUpEditBaseViewInfo {
        Image imageCore;
        public static Size DefaultImageSize = new Size(17, 17);
        internal Size GetScaleDefaultSize() {
            return GetScaleDpi().ScaleSize(DefaultImageSize);
        }
        public SearchLookUpEditWithGlyphBaseViewInfo(RepositoryItem item) : base(item) { }
        public new SearchLookUpEditWithGlyph OwnerEdit { get { return base.OwnerEdit as SearchLookUpEditWithGlyph; } }
        public new RepositoryItemSearchLookUpEditWithGlyph Item { get { return base.Item as RepositoryItemSearchLookUpEditWithGlyph; } }
        public override bool IsExistImage { get { return true; } }
        public override Size ImageSize { get { return Image == null ? Size.Empty : GetScaleDefaultSize(); } }
        public override DevExpress.Utils.Drawing.TextGlyphDrawModeEnum GlyphDrawMode {
            get {
                if(ImageSize.IsEmpty) return DevExpress.Utils.Drawing.TextGlyphDrawModeEnum.Text;
                return DevExpress.Utils.Drawing.TextGlyphDrawModeEnum.TextGlyph;
            }
        }
        protected override Rectangle CalcGlyphBounds() {
            Rectangle ret = base.CalcGlyphBounds();
            ret.X += GetScaleDpi().ScaleHorizontal(3); //horizontal image indent
            return ret;
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
            this.imageCore = null;
        }
        void UpdateImage() {
            this.requireUpdateImage = false;
            this.imageCore = GetImageCore(EditValue);
        }
        Image GetImageCore(object editValue) {
            object ret = null;
            if(OwnerEdit != null) ret = OwnerEdit.Image;
            if(ret != null) 
                return (Image)ret;
            if(Item != null && editValue != nullValue)
                ret = Item.GetImage(new ImageByValueEventArgs(editValue));
            if(ret == null) 
                return null;
            if(ret is Image) 
                return (Image)ret;
            return ByteImageConverter.FromByteArray(ByteImageConverter.ToByteArray(ret));
        }
        public Image Image {
            get { return imageCore; }
        }
    }
    public class SearchLookUpEditWithGlyph : SearchLookUpEdit {
        Image imageCore;
        static SearchLookUpEditWithGlyph() {
            RepositoryItemSearchLookUpEditWithGlyph.RegisterSearchLookUpEditWithGlyph();
        }
        public override string EditorTypeName { get { return "SearchLookUpEditWithGlyph"; } }
        protected override void Dispose(bool disposing) {
            if(disposing && imageCore != null) imageCore.Dispose();
            this.imageCore = null;
            base.Dispose(disposing);
        }
        [DefaultValue(null)]
        public Image Image {
            get { return imageCore; }
            set {
                imageCore = value;
                LayoutChanged();
            }
        }
    }
    public delegate void ImageByValueEventHandler(object sender, ImageByValueEventArgs e);
    public class ImageByValueEventArgs : EventArgs {
        object valueCore;
        object imageCore;
        public ImageByValueEventArgs(object value) {
            this.valueCore = value;
        }
        public object Value {
            get { return valueCore; }
        }
        public object Image { 
            get { return imageCore; } 
            set { imageCore = value; } 
        }
    }
}
