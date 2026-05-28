using System;
using System.Collections;
using System.ComponentModel;
//using System.Drawing;
using DevExpress.Tutorials;
using System.Windows.Forms;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.Utils.Drawing;
using DevExpress.Utils.Svg;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
// <comboAlign>
using DevExpress.Utils;
// </comboAlign>
// <checkEditRadioGroup>
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils.Text;
using DevExpress.XtraLayout;
using System.Drawing;
using DevExpress.XtraBars.Navigation;
// </checkEditRadioGroup>

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleCheckEdit : TutorialControl {
        public ModuleCheckEdit() {
            InitializeComponent();
            InitializeImageListBox(true);
            CheckControlsState();
            if(tabPane1 != null) {
                tabPane1.SelectedPageChanged += OnSelectedPageChanged;
                tabPane1.VisibleChanged += OnTabControlVisibleChanged;
            }
        }
        protected override void UnsubscribeOnEvents() {
            base.UnsubscribeOnEvents();
            if(tabPane1 != null) {
                tabPane1.SelectedPageChanged -= OnSelectedPageChanged;
                tabPane1.VisibleChanged -= OnTabControlVisibleChanged;
            }
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleCheckEdit" }; } }
        protected override string WhatsThisXMLFileName { get { return "checkEdit"; } }
        protected override void OnLookAndFeelChanged() {
            base.OnLookAndFeelChanged();
            InitializeImageListBox(false);
        }
        void InitializeImageListBox(bool createItems) {
            lbStyle.BeginUpdate();
            try {
                ImageCollection imageCollection = lbStyle.ImageList as ImageCollection;
                if(imageCollection == null) {
                    imageCollection = new ImageCollection();
                    imageCollection.ImageSize = CheckBoxImageProvider.GetImageSize();
                }
                else {
                    imageCollection.Clear();
                }
                int imageIndex = 0;
                foreach(CheckBoxStyle style in Enum.GetValues(typeof(CheckBoxStyle))) {
                    Image image = CheckBoxImageProvider.GetCheckBoxImage(LookAndFeel, style);
                    if(image == null)
                        continue;
                    imageCollection.Images.Add(image);
                    if(createItems) lbStyle.Items.Add(style, imageIndex++);
                }
                lbStyle.ImageList = imageCollection;
            }
            catch { }
            finally {
                lbStyle.EndUpdate();
            }
        }
        // <lbStyle>
        private void lbStyle_SelectedValueChanged(object sender, System.EventArgs e) {
            var style = (CheckBoxStyle)this.lbStyle.SelectedValue;
            this.checkEditSample.Properties.CheckBoxOptions.Style = style;
            CheckControlsState();
        }
        // </lbStyle>
        private void CheckControlsState() {
            var style = this.checkEditSample.Properties.CheckBoxOptions.Style;
            this.ceCheckedColor.Enabled = this.ceUncheckedColor.Enabled = this.ceIndeterminateColor.Enabled = IsSvgStyle(style);
        }
        bool IsSvgStyle(CheckBoxStyle style) {
            return (int)style > (int)CheckBoxStyle.Custom;
        }

        bool updateValues = false;
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        void OnTabControlVisibleChanged(object sender, EventArgs e) {
            CalcContentCore();
        }
        void OnSelectedPageChanged(object sender, SelectedPageChangedEventArgs e) {
            CalcContentCore();
        }
        protected override void CalcContentCore() {
            if(!Visible || !IsHandleCreated) return;
            CalcLayoutControlBounds(layoutControl1);
            CalcLayoutControlBounds(layoutControl2);
        }

        // <checkEditAllowGrayed>
        private void checkEditAllowGrayed_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            checkEditSample.Properties.AllowGrayed = checkEditAllowGrayed.Checked;
        }
        // </checkEditAllowGrayed>
        // <comboAlign>
        private void comboAlign_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            HorzAlignment[] alignments = new HorzAlignment[] { 
				HorzAlignment.Near, 
				HorzAlignment.Center, 
				HorzAlignment.Far };
            int selectedIndex = comboAlign.SelectedIndex;
            checkEditSample.Properties.GlyphAlignment = alignments[selectedIndex];
            checkEditSample.Properties.Appearance.TextOptions.HAlignment = alignments[selectedIndex];
        }
        // </comboAlign>

        private void CreateEditors() {
            int checkEditCount = 10;
            int checkEditDistance = checkEditSample.Font.Height + 10;
            for(int i = 0; i < checkEditCount; i++) {
                DevExpress.XtraEditors.CheckEdit newCheckEdit = new DevExpress.XtraEditors.CheckEdit();
                newCheckEdit.Text = "Check edit " + (i + 1).ToString();
                LayoutControlItem item = layoutControlGroup7.AddItem(string.Empty, newCheckEdit);
                item.TextVisible = false;
            }
        }

        // <checkEditRadioGroup>
        private void checkEditRadioGroup_CheckedChanged(object sender, System.EventArgs e) {
            if(checkEditRadioGroup.Checked)
                SetCheckEditsRadioIndex(0);
            else
                SetCheckEditsRadioIndex(-1);
            checkEditApplyRadioStyle.Checked = checkEditRadioGroup.Checked;
        }
        private void SetCheckEditsRadioIndex(int radioIndex) {
            ArrayList checkEdits = GetCheckEditControls();
            foreach(DevExpress.XtraEditors.CheckEdit editor in checkEdits) {
                editor.Checked = false;
                editor.Properties.RadioGroupIndex = radioIndex;
            }
        }
        // </checkEditRadioGroup>

        // <checkEditApplyRadioStyle>
        private void checkEditApplyRadioStyle_CheckedChanged(object sender, System.EventArgs e) {
            if(checkEditApplyRadioStyle.Checked)
                SetCheckEditsStyle(CheckStyles.Radio);
            else
                SetCheckEditsStyle(CheckStyles.Standard);
        }
        private void SetCheckEditsStyle(CheckStyles style) {
            ArrayList checkEdits = GetCheckEditControls();
            foreach(DevExpress.XtraEditors.CheckEdit editor in checkEdits)
                editor.Properties.CheckStyle = style;
        }
        // </checkEditApplyRadioStyle>


        // <btnRemoveEditors> <checkEditRadioGroup> <checkEditApplyRadioStyle>
        private ArrayList GetCheckEditControls() {
            ArrayList checkEdits = new ArrayList();
            foreach(LayoutControlItem item in layoutControlGroup7.Items) {
                if(item.Control is DevExpress.XtraEditors.CheckEdit)
                    checkEdits.Add(item.Control);
            }
            return checkEdits;
        }
        // </btnRemoveEditors> </checkEditRadioGroup> </checkEditApplyRadioStyle>

        private void TutorialModuleCheckEdit_Load(object sender, System.EventArgs e) {
            DevExpress.Tutorials.ControlUtils.CenterControlInParent(checkEditSample);
            CreateEditors();
            InitValues();
        }


        void InitValues() {
            updateValues = true;
            checkEditAllowGrayed.Checked = checkEditSample.Properties.AllowGrayed;
            checkEditSample.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Near;
            comboAlign.EditValue = checkEditSample.Properties.Appearance.TextOptions.HAlignment.ToString();
            updateValues = false;
        }
        
        //<ceCheckedColor>
        private void ceCheckedColor_EditValueChanged(object sender, EventArgs e) {
            Color color = ((ColorPickEdit)sender).Color;
            this.checkEditSample.Properties.CheckBoxOptions.SvgColorChecked = color;
        }
        //</ceCheckedColor>
        //<ceUncheckedColor>
        private void ceUncheckedColor_EditValueChanged(object sender, EventArgs e) {
            Color color = ((ColorPickEdit)sender).Color;
            this.checkEditSample.Properties.CheckBoxOptions.SvgColorUnchecked = color;
        }
        //</ceUncheckedColor>
        //<ceIndeterminateColor>
        private void ceIndeterminateColor_EditValueChanged(object sender, EventArgs e) {
            Color color = ((ColorPickEdit)sender).Color;
            this.checkEditSample.Properties.CheckBoxOptions.SvgColorGrayed = color;
        }
        //</ceIndeterminateColor>
    }

    static class CheckBoxImageProvider {
        static Size GetImageSizeCore() {
            return new Size((int)(18 * DpiProvider.Default.DpiScaleFactor), (int)(18 * DpiProvider.Default.DpiScaleFactor));
        }
        public static Size GetImageSize() {
            Size size = GetImageSizeCore();
            size.Width = size.Width * 2 + ImageInterval;
            return size;
        }
        static int ImageInterval {
            get { return (int)(6 * DpiProvider.Default.DpiScaleFactor); }
        }

        static SkinElementInfo GetCheckBoxElementInfo(GraphicsCache cache, UserLookAndFeel lookAndFeel, CheckBoxStyle style, CheckState state, Size size) {
            string name = style == CheckBoxStyle.Radio ? EditorsSkins.SkinRadioButton : EditorsSkins.SkinCheckBox;
            SkinElementInfo info = new SkinElementInfo(EditorsSkins.GetSkin(lookAndFeel)[name], new Rectangle(Point.Empty, size));
            info.State = ObjectState.Normal;
            info.ImageIndex = SkinElementPainter.Default.CalcDefaultImageIndex(info.Element.Image, ObjectState.Normal);
            info.Cache = cache;
            switch(state) {
                case CheckState.Checked: info.ImageIndex += 4; break;
                case CheckState.Indeterminate: info.ImageIndex += 8; break;
            }
            return info;
        }
        public static Image GetCheckBoxImage(UserLookAndFeel lookAndFeel, CheckBoxStyle style) {

            if(style == CheckBoxStyle.Default || style == CheckBoxStyle.Custom)
                return null;
            Image checkedImage = GetCheckBoxImage(style, CheckState.Checked, lookAndFeel);
            Image uncheckedImage = GetCheckBoxImage(style, CheckState.Unchecked, lookAndFeel);
            if(checkedImage == null || uncheckedImage == null)
                return null;
            Size imageSize = GetImageSize();
            Bitmap bmp = new Bitmap(imageSize.Width, imageSize.Height);
            using(Graphics g = Graphics.FromImage(bmp)) {
                g.DrawImageUnscaled(checkedImage, 0, 0);
                g.DrawImageUnscaled(uncheckedImage, GetImageSizeCore().Width + ImageInterval, 0);
            }
            checkedImage.Dispose();
            uncheckedImage.Dispose();
            return bmp;
        }
        static Image GetCheckBoxImage(CheckBoxStyle style, CheckState state, UserLookAndFeel lookAndFeel) {
            if(style == CheckBoxStyle.CheckBox || style == CheckBoxStyle.Radio) {
                Size imageSize = GetImageSizeCore();
                Bitmap checkBoxBitmap = new Bitmap(imageSize.Width, imageSize.Height);
                using(Graphics g = Graphics.FromImage(checkBoxBitmap)) {
                    using(GraphicsCache cache = new GraphicsCache(g)) {
                        SkinElementPainter.Default.DrawObject(GetCheckBoxElementInfo(cache, lookAndFeel, style, state, imageSize));
                    }
                }
                return checkBoxBitmap;
            }
            string resourceName = string.Format("DevExpress.XtraEditors.Images.SVG.CheckEdit.{0}_{1}.svg", style, state);
            var svgImage = ResourceImageHelper.CreateSvgImageFromResources(resourceName, typeof(CheckEdit).GetAssembly());
            if(svgImage == null)
                return null;
            var svgBitmap = new SvgBitmap(svgImage);
            var palette = SvgPaletteHelper.GetSvgPalette(lookAndFeel, ObjectState.Normal);
            return svgBitmap.Render(palette);
        }
    }
}

