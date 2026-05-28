using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraGrid.Views.Layout;
using System.IO;
using System.Reflection;
using DevExpress.XtraGrid.Views.Layout.Events;
using DevExpress.XtraLayout;
using DevExpress.XtraEditors.Controls;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraGrid.Demos {
    public partial class NWindLayout : BaseLayoutModule {
        string pathSingleRecordXML = @"DevExpress.XtraGrid.Demos.ModulesLayoutView.SingleRecordLayout.xml";

        Stream defaultXMLStream;
        Stream singleRecordXMLStream;
        bool showCaptionImages;
        bool showFieldImages;
        bool showImagesInFocusedCardOnly;
        
        bool fieldNotesCustomVisibility;
        bool fieldPhotoCustomVisibility;
        bool contactInfoInFocusedCardOnly;
        Assembly thisAssembly; 
        public NWindLayout() {
            thisAssembly = Assembly.GetExecutingAssembly();
            CreateWaitDialog();
            InitializeComponent();
            InitData();
            this.BorderStyle = BorderStyle.None;
            gridControl1.ForceInitialize();
            CustomizationPageVisible = true;
            foreach(CardsAlignment mode in Enum.GetValues(typeof(CardsAlignment)))
                cardAlignment.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<CardsAlignment>.GetTitle(mode), mode, -1));

            cardAlignment.EditValue = CardsAlignment.Center;
            //<imagesOnlyForFocused>
            //<imagesInCaptions>
            layoutView.CustomCardCaptionImage += OnCustomCardCaptionImage;
            //</imagesInCaptions>
            //</imagesOnlyForFocused>

            //<imagesOnlyForFocused>
            //<imagesInFields>
            layoutView.CustomFieldCaptionImage += OnCustomFieldCaptionImage;
            //</imagesInFields>
            //</imagesOnlyForFocused>

            //<photoVisibility>
            //<notesVisibility>
            //<visibilityOnlyForFocused>
            layoutView.CustomCardLayout += OnCustomCardLayout;
            //</notesVisibility>
            //</photoVisibility>
            //</visibilityOnlyForFocused>
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "NWindLayout" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "NWindLayout"; }
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            defaultXMLStream = new MemoryStream();
            layoutView.SaveLayoutToStream(defaultXMLStream);
        }
        SvgImageCollection list = null;
        protected void LoadCustomImages() {
            list = new SvgImageCollection();
            list.ImageSize = new Size(16, 16);
            list.Add("about", "image://svgimages/outlook inspired/about.svg");
            list.Add("actions_rating", "image://svgimages/icon builder/actions_rating.svg");
            list.Add("bo_address", "image://svgimages/business objects/bo_address.svg");
        }

        //<photoVisibility>
        //<notesVisibility>
        //<visibilityOnlyForFocused>
        void OnCustomCardLayout(object sender, LayoutViewCustomCardLayoutEventArgs e) {
            if(!CustomEventsPageVisible) return;
            string colNotesFieldName = layoutViewField_colNotes.Name;
            string colPhotoFieldName = layoutViewField_colPhoto.Name;
            string groupContactInfoName = "Group2";
            LayoutViewCardDifferences differences = e.CardDifferences;
            if(contactInfoInFocusedCardOnly) {
                differences.AddItemDifference(groupContactInfoName, LayoutItemDifferenceType.ItemVisibility, (layoutView.FocusedRowHandle == e.RowHandle));
            }
            else {
                differences.AddItemDifference(groupContactInfoName, LayoutItemDifferenceType.ItemVisibility, true);
            }
            differences.AddItemDifference(colNotesFieldName, LayoutItemDifferenceType.ItemVisibility, fieldNotesCustomVisibility);
            differences.AddItemDifference(colPhotoFieldName, LayoutItemDifferenceType.ItemVisibility, fieldPhotoCustomVisibility);
        }
        //</visibilityOnlyForFocused>
        //</notesVisibility>
        //</photoVisibility>

        //<imagesOnlyForFocused>
        //<imagesInFields>
        void OnCustomFieldCaptionImage(object sender, LayoutViewFieldCaptionImageEventArgs e) {
            if(!CustomEventsPageVisible || !showFieldImages)
                return;
            if(showImagesInFocusedCardOnly && layoutView.FocusedRowHandle != e.RowHandle)
                return;
            if(e.Column == colNotes) {
                e.Image = list.GetImage(0, list.ScaledImageSize);
                e.ImageAlignment = ContentAlignment.MiddleLeft;
            }
        }
        //</imagesInFields>
        //</imagesOnlyForFocused>

        //<imagesOnlyForFocused>
        //<imagesInCaptions>
        void OnCustomCardCaptionImage(object sender, LayoutViewCardCaptionImageEventArgs e) {
            if(!CustomEventsPageVisible || !showCaptionImages) return;
            if(showImagesInFocusedCardOnly && layoutView.FocusedRowHandle!=e.RowHandle) return;
            e.ImageList = list;
            e.ImageIndex = 1;
            e.CaptionImageLocation = GroupElementLocation.BeforeText;
        }
        //</imagesInCaptions>
        //</imagesOnlyForFocused>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(singleRecordXMLStream!=null) {
                    singleRecordXMLStream.Close();
                    singleRecordXMLStream.Dispose();
                    singleRecordXMLStream = null;
                }
                if(defaultXMLStream!=null) {
                    defaultXMLStream.Dispose();
                    defaultXMLStream.Close();
                    defaultXMLStream = null;
                }
            }
            base.Dispose(disposing);
        }
        public override DevExpress.XtraGrid.Views.Base.BaseView ExportView {
            get { return layoutView; }
        }
        protected virtual void InitData() {
            var dsNWind = NWindDataSet();
            gridControl1.DataSource = dsNWind.Tables["Employees"];
            repositoryItemLookUpEdit1.DataSource = dsNWind.Tables["Employees"];
            //
            singleRecordXMLStream = ResourceImageHelper.FindStream(pathSingleRecordXML, thisAssembly);
            LoadCustomImages();
        }
        
        //<customizeBtn>
        protected void customizeBtn_Click(object sender, EventArgs e) {
            if(!layoutView.IsCustomizationMode) layoutView.ShowCustomizationForm();
            else layoutView.HideCustomizationForm();
        }
        //</customizeBtn>
        //<allowRuntimeCustomization>
        private void allowRuntimeCustomization_CheckedChanged(object sender, EventArgs e) {
            layoutView.OptionsBehavior.AllowRuntimeCustomization = (bool)allowRuntimeCustomization.EditValue;
            customizeBtn.Enabled = layoutView.OptionsBehavior.AllowRuntimeCustomization;
        }
        //</allowRuntimeCustomization>
        private void navigationPane1_SelectedPageChanged(object sender, XtraBars.Navigation.SelectedPageChangedEventArgs e) {
            CustomizeCustomizationModePage();
            CustomizeSingleRecordModePage();
            CustomizeMultiRecordModePage();
            CustomizeCustomsEventPage();
            layoutView.Refresh();
        }
        protected void CustomizeSingleRecordModePage() {
            if(SingleRecordPageVisible) {
                LoadSingleRecordLayout();
                SetLayoutTabbedGroupCaptions(layoutView.TemplateCard.Items[5], new string[] {Properties.Resources.Other, colNotes.Caption});
                layoutView.OptionsBehavior.AllowSwitchViewModes = false;
                layoutView.OptionsBehavior.AllowExpandCollapse = false;
                cardAlignment.Enabled = (!stretchWidth.Checked ^ !stretchHeight.Checked);
                return;
            }
        }
        void SetLayoutTabbedGroupCaptions(object group, string[] captions) {
            TabbedControlGroup tGroup = group as TabbedControlGroup;
            if(tGroup == null) return;
            tGroup.TabPages[0].Text = captions[0];
            tGroup.TabPages[1].Text = captions[1];
        }
        void ExpandAllCards() {
            for(int i = 0; i < layoutView.RecordCount; i++)
                layoutView.ExpandCard(i);
        }
        protected void LoadSingleRecordLayout() {
            if(singleRecordXMLStream!=null) {
                singleRecordXMLStream.Seek(0, SeekOrigin.Begin);
                ExpandAllCards();
                layoutView.RestoreLayoutFromStream(singleRecordXMLStream);
                layoutView.OptionsBehavior.AllowExpandCollapse = false;
            }
            gridControl1.UseEmbeddedNavigator = true;
            isDefault = false;
        }
        protected void CustomizeMultiRecordModePage() {
            if(MultiRecordPageVisible) {
                LoadDefaultLayout();
                layoutView.OptionsMultiRecordMode.StretchCardToViewHeight = stretchHeightM.Checked;
                layoutView.OptionsMultiRecordMode.StretchCardToViewWidth = stretchWidthM.Checked;
                multiSelect.EditValue = layoutView.OptionsSelection.MultiSelect;
                return;
            }
        }
        protected void CustomizeCustomizationModePage() {
            if(CustomizationPageVisible) {
                LoadDefaultLayout();
            }
        }
        protected void CustomizeCustomsEventPage() {
            if(CustomEventsPageVisible) {
                isDefault = false;
                LoadDefaultLayout();
                showCaptionImages = imagesInCaptions.Checked;
                showFieldImages = imagesInFields.Checked;
                showImagesInFocusedCardOnly = imagesOnlyForFocused.Checked;
                
                fieldNotesCustomVisibility = notesVisibility.Checked;
                fieldPhotoCustomVisibility = photoVisibility.Checked;
                contactInfoInFocusedCardOnly = visibilityOnlyForFocused.Checked;
                InitContactInfoGroupImage();
            }
        }
        protected void InitContactInfoGroupImage() {
            layoutView.TemplateCard.BeginUpdate();
            (layoutView as ILayoutControl).Images = list;
            (layoutView.TemplateCard[2] as LayoutGroup).CaptionImageIndex = 2;
            (layoutView.TemplateCard[2] as LayoutGroup).CaptionImageLocation = GroupElementLocation.BeforeText;
            layoutView.TemplateCard.EndUpdate();
        }
        bool isDefault = false;
        private void LoadDefaultLayout() {
            if(isDefault) return;
            layoutView.OptionsBehavior.AllowSwitchViewModes = true;
            if(defaultXMLStream != null) {
                defaultXMLStream.Seek(0, SeekOrigin.Begin);
                layoutView.RestoreLayoutFromStream(defaultXMLStream);
            }
            layoutView.OptionsBehavior.AllowExpandCollapse = true;
            layoutView.OptionsView.ShowCardCaption = true;
            gridControl1.UseEmbeddedNavigator = false;
            isDefault = true;
        }
        protected bool CustomizationPageVisible {
            get { return navigationPane1.SelectedPageIndex == 0; }
            set { navigationPane1.SelectedPageIndex = 0; } 
        }
        protected bool SingleRecordPageVisible {
            get { return navigationPane1.SelectedPageIndex == 1; }
            set { navigationPane1.SelectedPageIndex = 1; } 
        }
        protected bool MultiRecordPageVisible {
            get { return navigationPane1.SelectedPageIndex == 2; }
            set { navigationPane1.SelectedPageIndex = 2; } 
        }
        protected bool CustomEventsPageVisible {
            get { return navigationPane1.SelectedPageIndex == 3; }
            set { navigationPane1.SelectedPageIndex = 3; }
        }
        //<stretchWidth>
        private void stretchWidth_CheckedChanged(object sender, EventArgs e) {
            layoutView.OptionsSingleRecordMode.StretchCardToViewWidth = stretchWidth.Checked;
            cardAlignment.Enabled = !stretchWidth.Checked ^ !stretchHeight.Checked;
        }
        //</stretchWidth>
        //<stretchHeight>
        private void stretchHeight_CheckedChanged(object sender, EventArgs e) {
            layoutView.OptionsSingleRecordMode.StretchCardToViewHeight = stretchHeight.Checked;
            cardAlignment.Enabled = !stretchWidth.Checked ^ !stretchHeight.Checked;
        }
        //</stretchHeight>
        //<cardAlignment>
        private void cardAlignment_SelectedIndexChanged(object sender, EventArgs e) {
            layoutView.OptionsSingleRecordMode.CardAlignment = (CardsAlignment)cardAlignment.EditValue;
        }
        //</cardAlignment>

        //<stretchHeightM>
        private void stretchHeightM_CheckedChanged(object sender, EventArgs e) {
            layoutView.OptionsMultiRecordMode.StretchCardToViewHeight = stretchHeightM.Checked;
        }
        //</stretchHeightM>

        //<stretchWidthM>
        private void stretchWidthM_CheckedChanged(object sender, EventArgs e) {
            layoutView.OptionsMultiRecordMode.StretchCardToViewWidth = stretchWidthM.Checked;
        }
        //</stretchWidthM>

        //<spinEdit1>
        private void spinEdit1_EditValueChanged(object sender, EventArgs e) {
            layoutView.OptionsMultiRecordMode.MaxCardColumns = (int)spinEdit1.Value;
            stretchWidthM.Enabled = layoutView.OptionsMultiRecordMode.MaxCardColumns==0;
        }
        //</spinEdit1>
        //<spinEdit2>
        private void spinEdit2_EditValueChanged(object sender, EventArgs e) {
            layoutView.OptionsMultiRecordMode.MaxCardRows = (int)spinEdit2.Value;
            stretchHeightM.Enabled = layoutView.OptionsMultiRecordMode.MaxCardRows==0;
        }
        //</spinEdit2>

        //<imagesInCaptions>
        private void imagesInCaptions_CheckedChanged(object sender, EventArgs e) {
            showCaptionImages = imagesInCaptions.Checked;
            layoutView.Refresh();
        }
        //</imagesInCaptions>

        //<imagesInFields>
        private void imagesInFields_CheckedChanged(object sender, EventArgs e) {
            showFieldImages = imagesInFields.Checked;
            layoutView.Refresh();
        }
        //</imagesInFields>

        //<imagesOnlyForFocused>
        private void imagesOnlyForFocused_CheckedChanged(object sender, EventArgs e) {
            showImagesInFocusedCardOnly = imagesOnlyForFocused.Checked;
            layoutView.Refresh();
        }
        //</imagesOnlyForFocused>

        //<multiSelect>
        private void multiSelect_CheckedChanged(object sender, EventArgs e) {
            layoutView.OptionsSelection.MultiSelect = multiSelect.Checked;
            layoutView.OptionsPrint.PrintSelectedCardsOnly = multiSelect.Checked;
        }
        //</multiSelect>

        //<photoVisibility>
        private void photoVisibility_CheckedChanged(object sender, EventArgs e) {
            fieldPhotoCustomVisibility = photoVisibility.Checked;
            layoutView.Refresh();
        }
        //</photoVisibility>

        //<notesVisibility>
        private void notesVisibility_CheckedChanged(object sender, EventArgs e) {
            fieldNotesCustomVisibility = notesVisibility.Checked;
            layoutView.Refresh();
        }
        //</notesVisibility>

        //<visibilityOnlyForFocused>
        private void visibilityOnlyForFocused_CheckedChanged(object sender, EventArgs e) {
            contactInfoInFocusedCardOnly = visibilityOnlyForFocused.Checked;
            layoutView.Refresh();
        }
        //</visibilityOnlyForFocused>

        private void advancedCustomization_CheckedChanged(object sender, EventArgs e) {
            bool value = advancedCustomization.Checked;
            layoutView.OptionsCustomization.UseAdvancedRuntimeCustomization = value;
            customizationOptions.Enabled = value;
        }
        //<customizationOptions>
        private void customizationOptionsList_ItemCheck(object sender, XtraEditors.Controls.ItemCheckEventArgs e) {
            if(customizationOptions.Items.Count == 0) return;
            layoutView.OptionsCustomization.ShowGroupLayoutTreeView = (customizationOptions.Items[0].CheckState == CheckState.Checked);
            layoutView.OptionsCustomization.ShowGroupHiddenItems = (customizationOptions.Items[1].CheckState == CheckState.Checked);
            layoutView.OptionsCustomization.ShowResetShrinkButtons = (customizationOptions.Items[2].CheckState == CheckState.Checked);
            layoutView.OptionsCustomization.ShowGroupCardIndents = (customizationOptions.Items[3].CheckState == CheckState.Checked);
            layoutView.OptionsCustomization.ShowGroupCardCaptions = (customizationOptions.Items[4].CheckState == CheckState.Checked);
            layoutView.OptionsCustomization.ShowSaveLoadLayoutButtons = (customizationOptions.Items[5].CheckState == CheckState.Checked);
            layoutView.OptionsCustomization.ShowGroupView = (customizationOptions.Items[6].CheckState == CheckState.Checked);
            layoutView.OptionsCustomization.ShowGroupLayout = (customizationOptions.Items[7].CheckState == CheckState.Checked);
            layoutView.OptionsCustomization.ShowGroupCards = (customizationOptions.Items[8].CheckState == CheckState.Checked);
            layoutView.OptionsCustomization.ShowGroupFields = (customizationOptions.Items[9].CheckState == CheckState.Checked);
        }
        //</customizationOptions>
        #region ReportGeneration
        public override bool AllowGenerateReport { get { return false; } }
        #endregion
    }
}
