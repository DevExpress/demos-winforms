using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
// <comboBoxSizeMode>
using DevExpress.XtraEditors.Controls;
// </comboBoxSizeMode>
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using DevExpress.Utils;
using DevExpress.XtraEditors.ImageEditor;
using DevExpress.XtraTab;
using DevExpress.XtraBars.Navigation;
using DevExpress.Data.Utils;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModulePictureEdit : TutorialControl {

        public ModulePictureEdit() {
            InitializeComponent();
            if(tabPane1 != null)
                tabPane1.SelectedPageChanged += OnSelectedPageChanged;

            peEditable.ImageEditorDialogShowing += PeEditable_ImageEditorDialogShowing;
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModulePictureEdit" }; } }
        protected override string WhatsThisXMLFileName { get { return "pictureEdit"; } }
        void OnSelectedPageChanged(object sender, SelectedPageChangedEventArgs e) {
            CalcContentCore();
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public override bool ContainsTabs { get { return true; } }
        public override void SelectTabByName(string tabName) {
            if(string.IsNullOrEmpty(tabName)) return;
            foreach(TabNavigationPage page in tabPane1.Pages) {
                if(string.Equals(page.Caption.Replace(" ",""), tabName, StringComparison.OrdinalIgnoreCase)) {
                    tabPane1.SelectedPage = page;
                    break;
                }
            }
        }
        public override string GetSelectedTabFullName() { return tabPane1.SelectedPage.Caption; }
        protected override void UnsubscribeOnEvents() {
            base.UnsubscribeOnEvents();
            if(tabPane1 != null)
                tabPane1.SelectedPageChanged -= OnSelectedPageChanged;
        }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
            CalcLayoutControlBounds(layoutControl2);
            CalcLayoutControlBounds(layoutControl4);
        }

        bool updateValues = false;
        ContentAlignment[] aligns = new ContentAlignment[] { 
				ContentAlignment.TopLeft, 
				ContentAlignment.TopCenter, 
				ContentAlignment.TopRight, 
				ContentAlignment.MiddleLeft, 
				ContentAlignment.MiddleCenter, 
				ContentAlignment.MiddleRight, 
				ContentAlignment.BottomLeft, 
				ContentAlignment.BottomCenter, 
				ContentAlignment.BottomRight };
        private void ModulePictureEdit_Load(object sender, System.EventArgs e) {
            foreach(InterpolationMode mode in Enum.GetValues(typeof(InterpolationMode))) 
                if(mode != InterpolationMode.Invalid)
                    icbInterpolationMode.Properties.Items.Add(new ImageComboBoxItem(mode.ToString(), mode, -1));
            icbShowZoomSubMenu.Properties.Items.AddEnum(typeof(DefaultBoolean));
            InitValues();
        }


        void InitValues() {
            updateValues = true;
            ceShowScrollBars.Checked = peScrollable.Properties.ShowScrollBars;
            ceAllowFocused.Checked = peScrollable.Properties.AllowFocused;
            cbAllowMenu.Checked = peScrollable.Properties.ShowMenu;
            cbAlignment.EditValue = peScrollable.Properties.PictureAlignment.ToString();
            seZoomPercent.Value = new decimal(peScrollable.Properties.ZoomPercent);
            ceAllowScroll.Checked = peScrollable.Properties.AllowScrollViaMouseDrag;
            icbInterpolationMode.EditValue = peScrollable.Properties.PictureInterpolationMode;
            icbShowZoomSubMenu.EditValue = peScrollable.Properties.ShowZoomSubMenu;
            ceShowCameraItem.Checked = peScrollable.Properties.ShowCameraMenuItem == CameraMenuItemVisibility.Always;
            updateValues = false;
            UpdateAllowScrollViaMouseDrag();
        }

        //<ceShowScrollBars>
        private void ceShowScrollBars_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            peScrollable.Properties.SizeMode = PictureSizeMode.Clip;
            peScrollable.Properties.ShowScrollBars = ceShowScrollBars.Checked;
            UpdateAllowScrollViaMouseDrag();
        }
        //</ceShowScrollBars>
        void UpdateAllowScrollViaMouseDrag() {
            ceAllowScroll.Enabled = peScrollable.Properties.ShowScrollBars;
        }

        //<ceAllowFocused>
        private void ceAllowFocused_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            peScrollable.Properties.AllowFocused = ceAllowFocused.Checked;
        }
        //</ceAllowFocused>
        //<cbAlignment>
        private void cbAlignment_SelectedIndexChanged(object sender, EventArgs e) {
            if(updateValues) return;
            peScrollable.Properties.SizeMode = PictureSizeMode.Clip;
            int selectedIndex = cbAlignment.SelectedIndex;
            peScrollable.Properties.PictureAlignment = aligns[selectedIndex];
        }
        //</cbAlignment>
        private void seZoomPercent_EditValueChanged(object sender, EventArgs e) {
            ztbZoomPercent.Value = (int)seZoomPercent.Value;
        }

        private void ztbZoomPercent_EditValueChanged(object sender, EventArgs e) {
            if(updateValues) return;
            peScrollable.Properties.SizeMode = PictureSizeMode.Clip;
            seZoomPercent.Value = ztbZoomPercent.Value;
            peScrollable.Properties.ZoomPercent = ztbZoomPercent.Value;
        }
        //<ceAllowScroll>
        private void ceAllowScroll_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            peScrollable.Properties.SizeMode = PictureSizeMode.Clip;
            peScrollable.Properties.AllowScrollViaMouseDrag = ceAllowScroll.Checked;
        }
        //</ceAllowScroll>
        //<icbInterpolationMode>
        private void icbInterpolationMode_SelectedIndexChanged(object sender, EventArgs e) {
            if(updateValues) return;
            peScrollable.Properties.PictureInterpolationMode = (InterpolationMode)icbInterpolationMode.EditValue;
        }

        private void peScrollable_ZoomPercentChanged(object sender, EventArgs e) {
            updateValues = true;
            try {
                seZoomPercent.Value = new decimal(peScrollable.Properties.ZoomPercent);
                ztbZoomPercent.Value = (int)peScrollable.Properties.ZoomPercent;
            } finally {
                updateValues = false;
            }
        }

        private void icbShowZoomSubMenu_SelectedIndexChanged(object sender, EventArgs e) {
            if(updateValues) return;
            peScrollable.Properties.ShowZoomSubMenu = (DefaultBoolean)icbShowZoomSubMenu.EditValue;
        }

        private void pictureEditSample_Properties_ContextButtonClick(object sender, ContextItemClickEventArgs e) {
            ContextItemClick(e);
        }

        private void peScrollable_Properties_ContextButtonClick(object sender, ContextItemClickEventArgs e) {
            ContextItemClick(e);
        }
        void ContextItemClick(ContextItemClickEventArgs e) {
            if(e.Item.Name == "itemDownload") {
                XtraMessageBox.Show("'Download' item clicked");
            }
            else if(e.Item.Name == "itemRemove") {
                XtraMessageBox.Show("'Remove' item clicked");
            }
            else if(e.Item.Name == "itemInfo") {
                XtraMessageBoxArgs args = new XtraMessageBoxArgs();
                args.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
                args.Text = LicenseToolTipController.GetLicenseInfo($"CC BY-SA 3.0|Cristianv14|devexpress.com/carimage24|Resize and crop");
                args.HyperlinkClick += (s, a) => { SafeProcess.Start(a.Link); };
                XtraMessageBox.Show(args);
            }
        }

        private void ceShowCameraItem_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            peScrollable.Properties.ShowCameraMenuItem = ceShowCameraItem.Checked ? CameraMenuItemVisibility.Always : CameraMenuItemVisibility.Never;
        }
        
        private void OnMaskTypeChanged(object sender, EventArgs e) {
            string text = comboBoxEdit1.EditValue as string;
            switch(text) {
                case "Circle":
                    peMasked.Properties.OptionsMask.MaskType = PictureEditMaskType.Circle;
                    break;
                case "RoundedRect":
                    peMasked.Properties.OptionsMask.MaskType = PictureEditMaskType.RoundedRect;
                    break;
                case "Custom":
                    peMasked.Properties.OptionsMask.MaskType = PictureEditMaskType.Custom;
                    break;
                default:
                    peMasked.Properties.OptionsMask.MaskType = PictureEditMaskType.None;
                    break;
            }
            OnMaskTypeChanged(peMasked.Properties.OptionsMask.MaskType);
        }

        protected void OnMaskTypeChanged(PictureEditMaskType type) {
            comboBoxEdit2.Enabled = textEdit2.Enabled = textEdit1.Enabled = textEdit3.Enabled = (type != PictureEditMaskType.None);
            seRadius.Enabled = (type == PictureEditMaskType.RoundedRect);
            buttonEdit1.Enabled = (type == PictureEditMaskType.Custom);
        }
        protected int[] GetIntArrayFromEditValue(object editValue) {
            if(editValue == null)
                return null;
            string[] vals = editValue.ToString().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            int[] res = new int[vals.Length];
            for(int i = 0; i < vals.Length; i++) {
                int result = 0;
                if(!int.TryParse(vals[i], out result))
                    return null;
                res[i] = result;
            }
            return res;
        }
        private void OnMaskOffsetChanged(object sender, EventArgs e) {
            int[] val = GetIntArrayFromEditValue(textEdit2.EditValue);
            if(val == null || val.Length != 2) return;
            this.peMasked.Properties.OptionsMask.Offset = new Point(val[0], val[1]);
        }
        private void OnMaskSizeChanged(object sender, EventArgs e) {
            int[] val = GetIntArrayFromEditValue(textEdit1.EditValue);
            if(val == null || val.Length != 2) return;
            Size res = (val[0] <= 0 || val[1] <= 0) ? Size.Empty : new Size(val[0], val[1]);
            this.peMasked.Properties.OptionsMask.Size = res;
        }
        private void OnMaskMarginChanged(object sender, EventArgs e) {
            int[] val = GetIntArrayFromEditValue(textEdit3.EditValue);
            if(val == null || val.Length != 4) return;
            this.peMasked.Properties.OptionsMask.Margin = new System.Windows.Forms.Padding(val[0], val[1], val[2], val[3]);
        }
        private void OnMaskRadiusChanged(object sender, EventArgs e) {
            this.peMasked.Properties.OptionsMask.RectCornerRadius = decimal.ToInt32(seRadius.Value);
        }
        private void OnMaskLayoutChanged(object sender, EventArgs e) {
            this.peMasked.Properties.OptionsMask.MaskLayoutMode = GetMaskLayoutType(this.comboBoxEdit2.SelectedIndex);
        }
        protected PictureEditMaskLayoutMode GetMaskLayoutType(int index) {
            switch(index){
                case 1: return PictureEditMaskLayoutMode.ZoomInside;
                case 2: return PictureEditMaskLayoutMode.Stretch;
                case 3: return PictureEditMaskLayoutMode.BottomCenter;
                case 4: return PictureEditMaskLayoutMode.BottomLeft;
                case 5: return PictureEditMaskLayoutMode.BottomRight;
                case 6: return PictureEditMaskLayoutMode.MiddleCenter;
                case 7: return PictureEditMaskLayoutMode.MiddleLeft;
                case 8: return PictureEditMaskLayoutMode.MiddleRight;
                case 9: return PictureEditMaskLayoutMode.TopCenter;
                case 10: return PictureEditMaskLayoutMode.TopLeft;
                case 11: return PictureEditMaskLayoutMode.TopRight;
                default: return PictureEditMaskLayoutMode.Default;
            }
        }
        private void buttonEdit1_ButtonClick(object sender, ButtonPressedEventArgs e) {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "BMP (*.bmp)|*.bmp|PNG (*.png)|*.png";
            dlg.Title = "Open";
            if(dlg.ShowDialog(this) == DialogResult.OK && dlg.FileName != null && dlg.FileName != string.Empty) {
                try {
                    this.peMasked.Properties.OptionsMask.CustomMask = Image.FromFile(dlg.FileName);
                    this.buttonEdit1.Text = dlg.FileName;
                }
                catch { }
            }
        }

        void btnEdit_Click(object sender, EventArgs e) {
            peEditable.ShowImageEditorDialog();
        }

        void PeEditable_ImageEditorDialogShowing(object sender, ImageEditorDialogShowingEventArgs e) {
            e.Form.CustomizeCropOptions += (s, ea) => { CustomizeCropOptions(s, ea); };
        }

        void CustomizeCropOptions(object sender, CustomizeCropOptionsEventArgs e) {
            if(ceCustomRatios.Checked) {
                var widescreen = new AspectRatioInfo(1.777f, "16:9");
                var standard = new AspectRatioInfo(1.333f, "4:3");
                e.AspectRatios.Clear();
                e.AspectRatios.Add(widescreen);
                e.AspectRatios.Add(standard);
                e.DefaultAspectRatio = widescreen;
            }
        }

        // <cbAllowMenu>
        private void cbAllowMenu_CheckedChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            peScrollable.Properties.ShowMenu = cbAllowMenu.Checked;
        }
        // </cbAllowMenu>
    }
}

