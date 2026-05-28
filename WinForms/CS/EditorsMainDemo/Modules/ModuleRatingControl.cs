using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleRatingControl : TutorialControl {
        public ModuleRatingControl() {
            InitializeComponent();            

            UpdateRatingControl();

            this.ratingControlSample.AutoSizeInLayoutControl = true;
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleRatingControl" }; } }
        protected override string WhatsThisXMLFileName { get { return "ratingControl"; } }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
        }
        private void UpdateRatingControl() {            
            ratingControlSample.Properties.ItemCount = Convert.ToInt32(spEditItemCount.Value);
            ratingControlSample.Rating = (ratingControlSample.Properties.ItemCount - 2) <= 0 ? ratingControlSample.Properties.ItemCount - 1 :  ratingControlSample.Properties.ItemCount - 2;
            spEditRating.Properties.MaxValue = spEditItemCount.Value;
            spEditIndent.Value = ratingControlSample.Properties.TextToRatingIndent;

            CalcContentCore();
        }
        // <spEditItemCount>
        private void spinItemCount_EditValueChanged(object sender, EventArgs e) {
            SpinEdit spEdit = sender as SpinEdit;
            ratingControlSample.Properties.ItemCount = Convert.ToInt32(spEdit.Value);
            spEditRating.Properties.MaxValue = spEditItemCount.Value;

            CalcContentCore();
        }
        // </spEditItemCount>
        // <spEditRating>
        private void spEditRating_EditValueChanged(object sender, EventArgs e) {
            SpinEdit spEdit = sender as SpinEdit;
            if(spEdit.Value == ratingControlSample.Rating)
                return;
            ratingControlSample.Rating = spEdit.Value;           
        }
        // </spEditRating>

        private void ratingControlSample_EditValueChanged(object sender, EventArgs e) {
            if(ratingControlSample.Rating == spEditRating.Value)
                return;
            spEditRating.Value = ratingControlSample.Rating;
        }

        // <cmbEditRatingOrientation>
        private void cmbEditRatingOrientation_SelectedIndexChanged(object sender, EventArgs e) {
            ComboBoxEdit cmbEdit = sender as ComboBoxEdit;
            if(cmbEdit.SelectedIndex == 0)
                ratingControlSample.Properties.RatingOrientation = Orientation.Horizontal;
            else
                ratingControlSample.Properties.RatingOrientation = Orientation.Vertical;

            CalcContentCore();
        }
        // </cmbEditRatingOrientation>

        // <cmbEditFillPrecision>
        private void cmbEditFillPrecision_SelectedIndexChanged(object sender, EventArgs e) {
            ComboBoxEdit cmbEdit = sender as ComboBoxEdit;
            switch(cmbEdit.SelectedIndex) {
                case 0: ratingControlSample.Properties.FillPrecision = RatingItemFillPrecision.Full;
                    spEditRating.Properties.IsFloatValue = false;
                    spEditRating.Properties.Increment = 1.0m;
                    break;
                case 1: ratingControlSample.Properties.FillPrecision = RatingItemFillPrecision.Half;
                    spEditRating.Properties.IsFloatValue = true;
                    spEditRating.Properties.Increment = 0.5m;
                    break;
                case 2: ratingControlSample.Properties.FillPrecision = RatingItemFillPrecision.Exact;
                    spEditRating.Properties.IsFloatValue = true;
                    spEditRating.Properties.Increment = 0.2m;
                    break;
                default:
                    break;
            }
            spEditRating.Value = ratingControlSample.Rating;                 
        }
        // </cmbEditFillPrecision>

        // <chEditShowText>
        private void chEditShowText_CheckedChanged(object sender, EventArgs e) {
            CheckEdit chEdit = sender as CheckEdit;
            ratingControlSample.Properties.ShowText = chEdit.Checked;
            EnableTextSettingControls(chEdit.Checked);

            CalcContentCore();
        }
        // </chEditShowText>

        private void EnableTextSettingControls(bool enabled) {
            cmbEditTextLocation.Enabled = enabled;
            spEditIndent.Enabled = enabled;
            chEditHtmlDraw.Enabled = enabled;
        }

        // <cmbEditTextLocation>
        private void cmbEditRatingAlignment_SelectedIndexChanged(object sender, EventArgs e) {
            ComboBoxEdit cmbEdit = sender as ComboBoxEdit;
            switch(cmbEdit.SelectedIndex){
                case 0: ratingControlSample.Properties.TextLocation = Repository.RatingTextLocation.Bottom;
                    break;
                case 1: ratingControlSample.Properties.TextLocation = Repository.RatingTextLocation.Default;
                    break;
                case 2: ratingControlSample.Properties.TextLocation = Repository.RatingTextLocation.Left;
                    break;
                case 3: ratingControlSample.Properties.TextLocation = Repository.RatingTextLocation.None;
                    break;
                case 4: ratingControlSample.Properties.TextLocation = Repository.RatingTextLocation.Right;
                    break;
                case 5: ratingControlSample.Properties.TextLocation = Repository.RatingTextLocation.Top;
                    break;
                default:
                    break;
            }
        }
        // </cmbEditTextLocation>

        // <spEditIndent>
        private void spEditIndent_EditValueChanged(object sender, EventArgs e) {
            SpinEdit spEdit = sender as SpinEdit;
            ratingControlSample.Properties.TextToRatingIndent = Convert.ToInt32(spEdit.Value);
        }
        // </spEditIndent>

        // <chEditHtmlDraw>
        private void chEditHtmlDraw_CheckedChanged(object sender, EventArgs e) {
            CheckEdit chEdit = sender as CheckEdit;
            if(chEdit.Checked) {
                ratingControlSample.Properties.AllowHtmlDraw = Utils.DefaultBoolean.True;
                ratingControlSample.Text = "<Color=Blue>Sample<Color=Black> <b>RatingControl</b><br>";
            }
            else {
                ratingControlSample.Properties.AllowHtmlDraw = Utils.DefaultBoolean.False;
                ratingControlSample.Text = "RatingControl";
            }

            CalcContentCore();
        }
        // </chEditHtmlDraw>

        // <popupContainerEditImages>
        private void btnApply_Click(object sender, EventArgs e) {
            ratingControlSample.Properties.Glyph = picEditGlyph.Image;
            ratingControlSample.Properties.HoverGlyph = picEditHover.Image;
            ratingControlSample.Properties.CheckedGlyph = picEditChecked.Image;

            popupContainerEditImages.ClosePopup();

            CalcContentCore();
        }

        private void btnDefault_Click(object sender, EventArgs e) {
            ratingControlSample.Properties.Glyph = null;
            ratingControlSample.Properties.HoverGlyph = null;
            ratingControlSample.Properties.CheckedGlyph = null;

            popupContainerEditImages.ClosePopup();

            CalcContentCore();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            popupContainerEditImages.ClosePopup();
        }
        // </popupContainerEditImages>

        // <cmbEditRatingDirection>
        private void cmbEditRatingDirection_SelectedIndexChanged(object sender, EventArgs e) {
            ComboBoxEdit combo = sender as ComboBoxEdit;
            ratingControlSample.Properties.IsDirectionReversed = combo.SelectedIndex == 1;
        }
        // </cmbEditRatingDirection>
        

        private void spEditRating_EditValueChanging(object sender, Controls.ChangingEventArgs e) {
            e.NewValue = Decimal.Round(Convert.ToDecimal(e.NewValue), 2);
        }
      
    }
}
