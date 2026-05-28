using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;

namespace DevExpress.XtraGrid.Demos {
    public partial class NWindLayout : BaseLayoutModule {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.layoutView = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colAddress = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.layoutViewField_colAddress = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colCity = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.layoutViewField_colCity = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colCountry = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.layoutViewField_colCountry = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colFirstName = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colFirstName = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colHomePhone = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colHomePhone = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colLastName = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colLastName = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colNotes = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.layoutViewField_colNotes = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colPhoto = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.layoutViewField_colPhoto = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colPostalCode = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.layoutViewField_colPostalCode = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colRegion = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.layoutViewField_colRegion = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colReportsTo = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colReportsTo = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colTitle = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colTitle = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colTitleOfCourtesy = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colTitleOfCourtesy = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.Group2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.Item12 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.item1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.dsNWindCustomers = new DevExpress.XtraGrid.Demos.dsNWindCustomers();
            this.imagesInFields = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControl5 = new DevExpress.XtraLayout.LayoutControl();
            this.visibilityOnlyForFocused = new DevExpress.XtraEditors.CheckEdit();
            this.photoVisibility = new DevExpress.XtraEditors.CheckEdit();
            this.imagesInCaptions = new DevExpress.XtraEditors.CheckEdit();
            this.imagesOnlyForFocused = new DevExpress.XtraEditors.CheckEdit();
            this.notesVisibility = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup8 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem3 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.multiSelect = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            this.stretchWidthM = new DevExpress.XtraEditors.CheckEdit();
            this.stretchHeightM = new DevExpress.XtraEditors.CheckEdit();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.spinEdit2 = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup9 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem2 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.cardAlignment = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.stretchWidth = new DevExpress.XtraEditors.CheckEdit();
            this.stretchHeight = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControl4 = new DevExpress.XtraLayout.LayoutControl();
            this.customizationOptions = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.allowRuntimeCustomization = new DevExpress.XtraEditors.CheckEdit();
            this.customizeBtn = new DevExpress.XtraEditors.SimpleButton();
            this.advancedCustomization = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup7 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage3 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage4 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pnlGrid = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colHomePhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPostalCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colReportsTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colTitleOfCourtesy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Group2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNWindCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesInFields.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl5)).BeginInit();
            this.layoutControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visibilityOnlyForFocused.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoVisibility.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesInCaptions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesOnlyForFocused.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesVisibility.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiSelect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
            this.layoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stretchWidthM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stretchHeightM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardAlignment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stretchWidth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stretchHeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl4)).BeginInit();
            this.layoutControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customizationOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowRuntimeCustomization.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedCustomization.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage3.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            this.navigationPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.layoutView;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1,
            this.repositoryItemMemoEdit1,
            this.repositoryItemMemoExEdit1,
            this.repositoryItemComboBox1,
            this.repositoryItemLookUpEdit1,
            this.repositoryItemComboBox2,
            this.repositoryItemComboBox3});
            this.gridControl1.Size = new System.Drawing.Size(835, 668);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView});
            // 
            // layoutView
            // 
            this.layoutView.Appearance.Card.Options.UseTextOptions = true;
            this.layoutView.Appearance.Card.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutView.Appearance.FieldCaption.Options.UseTextOptions = true;
            this.layoutView.Appearance.FieldCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.layoutView.CardMinSize = new System.Drawing.Size(250, 343);
            this.layoutView.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colAddress,
            this.colCity,
            this.colCountry,
            this.colFirstName,
            this.colHomePhone,
            this.colLastName,
            this.colNotes,
            this.colPhoto,
            this.colPostalCode,
            this.colRegion,
            this.colReportsTo,
            this.colTitle,
            this.colTitleOfCourtesy});
            this.layoutView.GridControl = this.gridControl1;
            this.layoutView.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colReportsTo,
            this.layoutViewField_colTitleOfCourtesy});
            this.layoutView.Name = "layoutView";
            this.layoutView.OptionsItemText.AlignMode = DevExpress.XtraGrid.Views.Layout.FieldTextAlignMode.AutoSize;
            this.layoutView.OptionsSingleRecordMode.StretchCardToViewHeight = true;
            this.layoutView.OptionsSingleRecordMode.StretchCardToViewWidth = true;
            this.layoutView.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow;
            this.layoutView.TemplateCard = this.layoutViewCard1;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Address";
            this.colAddress.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.colAddress.CustomizationCaption = "Address";
            this.colAddress.FieldName = "Address";
            this.colAddress.LayoutViewField = this.layoutViewField_colAddress;
            this.colAddress.Name = "colAddress";
            this.colAddress.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colAddress.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAddress.OptionsFilter.AllowFilter = false;
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            this.repositoryItemMemoExEdit1.ShowIcon = false;
            // 
            // layoutViewField_colAddress
            // 
            this.layoutViewField_colAddress.EditorPreferredWidth = 152;
            this.layoutViewField_colAddress.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colAddress.Name = "layoutViewField_colAddress";
            this.layoutViewField_colAddress.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutViewField_colAddress.Size = new System.Drawing.Size(207, 26);
            this.layoutViewField_colAddress.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewField_colAddress.TextSize = new System.Drawing.Size(43, 13);
            // 
            // colCity
            // 
            this.colCity.Caption = "City";
            this.colCity.ColumnEdit = this.repositoryItemComboBox2;
            this.colCity.CustomizationCaption = "City";
            this.colCity.FieldName = "City";
            this.colCity.LayoutViewField = this.layoutViewField_colCity;
            this.colCity.Name = "colCity";
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Items.AddRange(new object[] {
            "Seattle",
            "Tacoma",
            "Kirkland",
            "Redmond",
            "London"});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // layoutViewField_colCity
            // 
            this.layoutViewField_colCity.EditorPreferredWidth = 172;
            this.layoutViewField_colCity.Location = new System.Drawing.Point(0, 26);
            this.layoutViewField_colCity.Name = "layoutViewField_colCity";
            this.layoutViewField_colCity.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutViewField_colCity.Size = new System.Drawing.Size(207, 26);
            this.layoutViewField_colCity.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewField_colCity.TextSize = new System.Drawing.Size(23, 13);
            // 
            // colCountry
            // 
            this.colCountry.Caption = "Country";
            this.colCountry.ColumnEdit = this.repositoryItemComboBox1;
            this.colCountry.CustomizationCaption = "Country";
            this.colCountry.FieldName = "Country";
            this.colCountry.LayoutViewField = this.layoutViewField_colCountry;
            this.colCountry.Name = "colCountry";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "USA",
            "UK"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // layoutViewField_colCountry
            // 
            this.layoutViewField_colCountry.EditorPreferredWidth = 152;
            this.layoutViewField_colCountry.Location = new System.Drawing.Point(0, 78);
            this.layoutViewField_colCountry.Name = "layoutViewField_colCountry";
            this.layoutViewField_colCountry.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutViewField_colCountry.Size = new System.Drawing.Size(207, 26);
            this.layoutViewField_colCountry.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewField_colCountry.TextSize = new System.Drawing.Size(43, 13);
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "First Name";
            this.colFirstName.CustomizationCaption = " First Name";
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.LayoutViewField = this.layoutViewField_colFirstName;
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.OptionsFilter.AllowFilter = false;
            // 
            // layoutViewField_colFirstName
            // 
            this.layoutViewField_colFirstName.EditorPreferredWidth = 99;
            this.layoutViewField_colFirstName.Location = new System.Drawing.Point(66, 26);
            this.layoutViewField_colFirstName.Name = "layoutViewField_colFirstName";
            this.layoutViewField_colFirstName.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutViewField_colFirstName.Size = new System.Drawing.Size(165, 26);
            this.layoutViewField_colFirstName.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewField_colFirstName.TextSize = new System.Drawing.Size(55, 13);
            // 
            // colHomePhone
            // 
            this.colHomePhone.Caption = "Home Phone";
            this.colHomePhone.CustomizationCaption = "Home Phone";
            this.colHomePhone.FieldName = "HomePhone";
            this.colHomePhone.LayoutViewField = this.layoutViewField_colHomePhone;
            this.colHomePhone.Name = "colHomePhone";
            // 
            // layoutViewField_colHomePhone
            // 
            this.layoutViewField_colHomePhone.EditorPreferredWidth = 131;
            this.layoutViewField_colHomePhone.Location = new System.Drawing.Point(0, 104);
            this.layoutViewField_colHomePhone.Name = "layoutViewField_colHomePhone";
            this.layoutViewField_colHomePhone.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutViewField_colHomePhone.Size = new System.Drawing.Size(207, 26);
            this.layoutViewField_colHomePhone.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewField_colHomePhone.TextSize = new System.Drawing.Size(64, 13);
            // 
            // colLastName
            // 
            this.colLastName.Caption = "Last Name";
            this.colLastName.CustomizationCaption = "Last Name";
            this.colLastName.FieldName = "LastName";
            this.colLastName.LayoutViewField = this.layoutViewField_colLastName;
            this.colLastName.Name = "colLastName";
            this.colLastName.OptionsFilter.AllowFilter = false;
            // 
            // layoutViewField_colLastName
            // 
            this.layoutViewField_colLastName.EditorPreferredWidth = 100;
            this.layoutViewField_colLastName.Location = new System.Drawing.Point(66, 52);
            this.layoutViewField_colLastName.Name = "layoutViewField_colLastName";
            this.layoutViewField_colLastName.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutViewField_colLastName.Size = new System.Drawing.Size(165, 26);
            this.layoutViewField_colLastName.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewField_colLastName.TextSize = new System.Drawing.Size(54, 13);
            // 
            // colNotes
            // 
            this.colNotes.AppearanceCell.Options.UseTextOptions = true;
            this.colNotes.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colNotes.Caption = "Notes";
            this.colNotes.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colNotes.CustomizationCaption = "Notes";
            this.colNotes.FieldName = "Notes";
            this.colNotes.LayoutViewField = this.layoutViewField_colNotes;
            this.colNotes.Name = "colNotes";
            this.colNotes.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNotes.OptionsFilter.AllowFilter = false;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // layoutViewField_colNotes
            // 
            this.layoutViewField_colNotes.EditorPreferredWidth = 187;
            this.layoutViewField_colNotes.Location = new System.Drawing.Point(0, 261);
            this.layoutViewField_colNotes.MaxSize = new System.Drawing.Size(207, 60);
            this.layoutViewField_colNotes.MinSize = new System.Drawing.Size(207, 60);
            this.layoutViewField_colNotes.Name = "layoutViewField_colNotes";
            this.layoutViewField_colNotes.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutViewField_colNotes.Size = new System.Drawing.Size(231, 25);
            this.layoutViewField_colNotes.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutViewField_colNotes.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewField_colNotes.TextSize = new System.Drawing.Size(32, 13);
            // 
            // colPhoto
            // 
            this.colPhoto.Caption = "Photo";
            this.colPhoto.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colPhoto.CustomizationCaption = "Photo";
            this.colPhoto.FieldName = "Photo";
            this.colPhoto.LayoutViewField = this.layoutViewField_colPhoto;
            this.colPhoto.Name = "colPhoto";
            this.colPhoto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPhoto.OptionsFilter.AllowFilter = false;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // layoutViewField_colPhoto
            // 
            this.layoutViewField_colPhoto.EditorPreferredWidth = 58;
            this.layoutViewField_colPhoto.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colPhoto.MaxSize = new System.Drawing.Size(64, 80);
            this.layoutViewField_colPhoto.MinSize = new System.Drawing.Size(64, 80);
            this.layoutViewField_colPhoto.Name = "layoutViewField_colPhoto";
            this.layoutViewField_colPhoto.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutViewField_colPhoto.Size = new System.Drawing.Size(64, 88);
            this.layoutViewField_colPhoto.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutViewField_colPhoto.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 12);
            this.layoutViewField_colPhoto.TextVisible = false;
            // 
            // colPostalCode
            // 
            this.colPostalCode.Caption = "Postal Code";
            this.colPostalCode.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colPostalCode.CustomizationCaption = "Postal Code";
            this.colPostalCode.FieldName = "PostalCode";
            this.colPostalCode.LayoutViewField = this.layoutViewField_colPostalCode;
            this.colPostalCode.Name = "colPostalCode";
            this.colPostalCode.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPostalCode.OptionsFilter.AllowFilter = false;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PostalCode", "PostalCode", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.repositoryItemLookUpEdit1.DisplayMember = "PostalCode";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.PopupWidth = 100;
            this.repositoryItemLookUpEdit1.ShowHeader = false;
            this.repositoryItemLookUpEdit1.ValueMember = "PostalCode";
            // 
            // layoutViewField_colPostalCode
            // 
            this.layoutViewField_colPostalCode.EditorPreferredWidth = 55;
            this.layoutViewField_colPostalCode.Location = new System.Drawing.Point(0, 52);
            this.layoutViewField_colPostalCode.Name = "layoutViewField_colPostalCode";
            this.layoutViewField_colPostalCode.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutViewField_colPostalCode.Size = new System.Drawing.Size(128, 26);
            this.layoutViewField_colPostalCode.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewField_colPostalCode.TextSize = new System.Drawing.Size(61, 13);
            // 
            // colRegion
            // 
            this.colRegion.Caption = "Region";
            this.colRegion.ColumnEdit = this.repositoryItemComboBox3;
            this.colRegion.CustomizationCaption = "Region";
            this.colRegion.FieldName = "Region";
            this.colRegion.LayoutViewField = this.layoutViewField_colRegion;
            this.colRegion.Name = "colRegion";
            // 
            // repositoryItemComboBox3
            // 
            this.repositoryItemComboBox3.AutoHeight = false;
            this.repositoryItemComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox3.Items.AddRange(new object[] {
            "WA",
            "SP",
            "NM",
            "Lara",
            "Québec",
            "WY",
            "ID",
            "OR",
            "Nueva Esparta",
            "Essex",
            "Isle of Wight",
            "Táchira"});
            this.repositoryItemComboBox3.Name = "repositoryItemComboBox3";
            // 
            // layoutViewField_colRegion
            // 
            this.layoutViewField_colRegion.EditorPreferredWidth = 31;
            this.layoutViewField_colRegion.Location = new System.Drawing.Point(128, 52);
            this.layoutViewField_colRegion.Name = "layoutViewField_colRegion";
            this.layoutViewField_colRegion.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutViewField_colRegion.Size = new System.Drawing.Size(79, 26);
            this.layoutViewField_colRegion.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewField_colRegion.TextSize = new System.Drawing.Size(37, 13);
            // 
            // colReportsTo
            // 
            this.colReportsTo.Caption = "ReportsTo";
            this.colReportsTo.CustomizationCaption = "ReportsTo";
            this.colReportsTo.FieldName = "ReportsTo";
            this.colReportsTo.LayoutViewField = this.layoutViewField_colReportsTo;
            this.colReportsTo.Name = "colReportsTo";
            // 
            // layoutViewField_colReportsTo
            // 
            this.layoutViewField_colReportsTo.EditorPreferredWidth = 10;
            this.layoutViewField_colReportsTo.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colReportsTo.Name = "layoutViewField_colReportsTo";
            this.layoutViewField_colReportsTo.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutViewField_colReportsTo.Size = new System.Drawing.Size(230, 304);
            this.layoutViewField_colReportsTo.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewField_colReportsTo.TextSize = new System.Drawing.Size(76, 20);
            // 
            // colTitle
            // 
            this.colTitle.Caption = "Title";
            this.colTitle.CustomizationCaption = "Title";
            this.colTitle.FieldName = "Title";
            this.colTitle.LayoutViewField = this.layoutViewField_colTitle;
            this.colTitle.Name = "colTitle";
            // 
            // layoutViewField_colTitle
            // 
            this.layoutViewField_colTitle.EditorPreferredWidth = 130;
            this.layoutViewField_colTitle.Location = new System.Drawing.Point(66, 0);
            this.layoutViewField_colTitle.Name = "layoutViewField_colTitle";
            this.layoutViewField_colTitle.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutViewField_colTitle.Size = new System.Drawing.Size(165, 26);
            this.layoutViewField_colTitle.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewField_colTitle.TextSize = new System.Drawing.Size(24, 13);
            // 
            // colTitleOfCourtesy
            // 
            this.colTitleOfCourtesy.Caption = "TitleOfCourtesy";
            this.colTitleOfCourtesy.CustomizationCaption = "TitleOfCourtesy";
            this.colTitleOfCourtesy.FieldName = "TitleOfCourtesy";
            this.colTitleOfCourtesy.LayoutViewField = this.layoutViewField_colTitleOfCourtesy;
            this.colTitleOfCourtesy.Name = "colTitleOfCourtesy";
            // 
            // layoutViewField_colTitleOfCourtesy
            // 
            this.layoutViewField_colTitleOfCourtesy.EditorPreferredWidth = 10;
            this.layoutViewField_colTitleOfCourtesy.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colTitleOfCourtesy.Name = "layoutViewField_colTitleOfCourtesy";
            this.layoutViewField_colTitleOfCourtesy.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutViewField_colTitleOfCourtesy.Size = new System.Drawing.Size(230, 304);
            this.layoutViewField_colTitleOfCourtesy.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewField_colTitleOfCourtesy.TextSize = new System.Drawing.Size(76, 20);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "layoutViewCard";
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colPhoto,
            this.layoutViewField_colNotes,
            this.Group2,
            this.layoutViewField_colTitle,
            this.layoutViewField_colFirstName,
            this.layoutViewField_colLastName,
            this.Item12,
            this.item1});
            this.layoutViewCard1.Name = "layoutViewTemplateCard";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
            this.layoutViewCard1.Text = "TemplateCard";
            this.layoutViewCard1.TextLocation = DevExpress.Utils.Locations.Default;
            // 
            // Group2
            // 
            this.Group2.CustomizationFormText = "Contact Info";
            this.Group2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colHomePhone,
            this.layoutViewField_colCountry,
            this.layoutViewField_colAddress,
            this.layoutViewField_colCity,
            this.layoutViewField_colPostalCode,
            this.layoutViewField_colRegion});
            this.Group2.Location = new System.Drawing.Point(0, 88);
            this.Group2.Name = "Group2";
            this.Group2.Size = new System.Drawing.Size(231, 173);
            this.Group2.Text = "Contact Info";
            this.Group2.TextLocation = DevExpress.Utils.Locations.Default;
            // 
            // Item12
            // 
            this.Item12.CustomizationFormText = "LayoutItem13";
            this.Item12.Location = new System.Drawing.Point(66, 78);
            this.Item12.Name = "Item12";
            this.Item12.Size = new System.Drawing.Size(165, 10);
            this.Item12.Text = "LayoutItem13";
            // 
            // item1
            // 
            this.item1.CustomizationFormText = "item1";
            this.item1.Location = new System.Drawing.Point(64, 0);
            this.item1.Name = "item1";
            this.item1.Size = new System.Drawing.Size(2, 88);
            // 
            // dsNWindCustomers
            // 
            this.dsNWindCustomers.DataSetName = "dsNWindCustomers";
            this.dsNWindCustomers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imagesInFields
            // 
            this.imagesInFields.Location = new System.Drawing.Point(12, 12);
            this.imagesInFields.Name = "imagesInFields";
            this.imagesInFields.Properties.Caption = "Show Field Caption Images";
            this.imagesInFields.Size = new System.Drawing.Size(186, 20);
            this.imagesInFields.StyleController = this.layoutControl5;
            this.imagesInFields.TabIndex = 15;
            this.imagesInFields.CheckedChanged += new System.EventHandler(this.imagesInFields_CheckedChanged);
            // 
            // layoutControl5
            // 
            this.layoutControl5.AllowCustomization = false;
            this.layoutControl5.Controls.Add(this.imagesInFields);
            this.layoutControl5.Controls.Add(this.visibilityOnlyForFocused);
            this.layoutControl5.Controls.Add(this.photoVisibility);
            this.layoutControl5.Controls.Add(this.imagesInCaptions);
            this.layoutControl5.Controls.Add(this.imagesOnlyForFocused);
            this.layoutControl5.Controls.Add(this.notesVisibility);
            this.layoutControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl5.Location = new System.Drawing.Point(0, 0);
            this.layoutControl5.Name = "layoutControl5";
            this.layoutControl5.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1096, 194, 450, 350);
            this.layoutControl5.Root = this.layoutControlGroup8;
            this.layoutControl5.Size = new System.Drawing.Size(210, 608);
            this.layoutControl5.TabIndex = 0;
            this.layoutControl5.Text = "layoutControl5";
            // 
            // visibilityOnlyForFocused
            // 
            this.visibilityOnlyForFocused.Location = new System.Drawing.Point(12, 181);
            this.visibilityOnlyForFocused.Name = "visibilityOnlyForFocused";
            this.visibilityOnlyForFocused.Properties.Caption = "Show \"Contact Info\"";
            this.visibilityOnlyForFocused.Size = new System.Drawing.Size(186, 20);
            this.visibilityOnlyForFocused.StyleController = this.layoutControl5;
            this.visibilityOnlyForFocused.TabIndex = 20;
            this.visibilityOnlyForFocused.CheckedChanged += new System.EventHandler(this.visibilityOnlyForFocused_CheckedChanged);
            // 
            // photoVisibility
            // 
            this.photoVisibility.EditValue = true;
            this.photoVisibility.Location = new System.Drawing.Point(12, 157);
            this.photoVisibility.Name = "photoVisibility";
            this.photoVisibility.Properties.Caption = "Show Photo Field";
            this.photoVisibility.Size = new System.Drawing.Size(186, 20);
            this.photoVisibility.StyleController = this.layoutControl5;
            this.photoVisibility.TabIndex = 18;
            this.photoVisibility.CheckedChanged += new System.EventHandler(this.photoVisibility_CheckedChanged);
            // 
            // imagesInCaptions
            // 
            this.imagesInCaptions.Location = new System.Drawing.Point(12, 36);
            this.imagesInCaptions.Name = "imagesInCaptions";
            this.imagesInCaptions.Properties.Caption = "Show Card Caption Images";
            this.imagesInCaptions.Size = new System.Drawing.Size(186, 20);
            this.imagesInCaptions.StyleController = this.layoutControl5;
            this.imagesInCaptions.TabIndex = 14;
            this.imagesInCaptions.CheckedChanged += new System.EventHandler(this.imagesInCaptions_CheckedChanged);
            // 
            // imagesOnlyForFocused
            // 
            this.imagesOnlyForFocused.Location = new System.Drawing.Point(12, 60);
            this.imagesOnlyForFocused.Name = "imagesOnlyForFocused";
            this.imagesOnlyForFocused.Properties.Caption = "Only in Focused Card";
            this.imagesOnlyForFocused.Size = new System.Drawing.Size(186, 20);
            this.imagesOnlyForFocused.StyleController = this.layoutControl5;
            this.imagesOnlyForFocused.TabIndex = 16;
            this.imagesOnlyForFocused.CheckedChanged += new System.EventHandler(this.imagesOnlyForFocused_CheckedChanged);
            // 
            // notesVisibility
            // 
            this.notesVisibility.EditValue = true;
            this.notesVisibility.Location = new System.Drawing.Point(12, 133);
            this.notesVisibility.Name = "notesVisibility";
            this.notesVisibility.Properties.Caption = "Show Notes Field";
            this.notesVisibility.Size = new System.Drawing.Size(186, 20);
            this.notesVisibility.StyleController = this.layoutControl5;
            this.notesVisibility.TabIndex = 19;
            this.notesVisibility.CheckedChanged += new System.EventHandler(this.notesVisibility_CheckedChanged);
            // 
            // layoutControlGroup8
            // 
            this.layoutControlGroup8.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup8.GroupBordersVisible = false;
            this.layoutControlGroup8.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem12,
            this.layoutControlItem11,
            this.layoutControlItem13,
            this.layoutControlItem16,
            this.layoutControlItem15,
            this.layoutControlItem17,
            this.simpleLabelItem3,
            this.emptySpaceItem9,
            this.emptySpaceItem6});
            this.layoutControlGroup8.Name = "Root";
            this.layoutControlGroup8.Size = new System.Drawing.Size(210, 608);
            this.layoutControlGroup8.TextVisible = false;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.imagesInFields;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(190, 24);
            this.layoutControlItem12.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.imagesInCaptions;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(190, 24);
            this.layoutControlItem11.TextVisible = false;
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.imagesOnlyForFocused;
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(190, 24);
            this.layoutControlItem13.TextVisible = false;
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.notesVisibility;
            this.layoutControlItem16.Location = new System.Drawing.Point(0, 121);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(190, 24);
            this.layoutControlItem16.TextVisible = false;
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.photoVisibility;
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 145);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(190, 24);
            this.layoutControlItem15.TextVisible = false;
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.Control = this.visibilityOnlyForFocused;
            this.layoutControlItem17.Location = new System.Drawing.Point(0, 169);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(190, 24);
            this.layoutControlItem17.TextVisible = false;
            // 
            // simpleLabelItem3
            // 
            this.simpleLabelItem3.Location = new System.Drawing.Point(0, 193);
            this.simpleLabelItem3.Name = "simpleLabelItem3";
            this.simpleLabelItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 2, 2, 2);
            this.simpleLabelItem3.Size = new System.Drawing.Size(190, 17);
            this.simpleLabelItem3.Text = " (only in focused card)";
            this.simpleLabelItem3.TextSize = new System.Drawing.Size(107, 13);
            // 
            // emptySpaceItem9
            // 
            this.emptySpaceItem9.Location = new System.Drawing.Point(0, 210);
            this.emptySpaceItem9.Name = "emptySpaceItem9";
            this.emptySpaceItem9.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 2, 2, 2);
            this.emptySpaceItem9.Size = new System.Drawing.Size(190, 378);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.Location = new System.Drawing.Point(0, 72);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(190, 49);
            // 
            // multiSelect
            // 
            this.multiSelect.Location = new System.Drawing.Point(12, 106);
            this.multiSelect.Name = "multiSelect";
            this.multiSelect.Properties.Caption = "Multiple Card Selection";
            this.multiSelect.Size = new System.Drawing.Size(186, 20);
            this.multiSelect.StyleController = this.layoutControl3;
            this.multiSelect.TabIndex = 17;
            this.multiSelect.CheckedChanged += new System.EventHandler(this.multiSelect_CheckedChanged);
            // 
            // layoutControl3
            // 
            this.layoutControl3.AllowCustomization = false;
            this.layoutControl3.Controls.Add(this.stretchWidthM);
            this.layoutControl3.Controls.Add(this.stretchHeightM);
            this.layoutControl3.Controls.Add(this.multiSelect);
            this.layoutControl3.Controls.Add(this.spinEdit1);
            this.layoutControl3.Controls.Add(this.spinEdit2);
            this.layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl3.Location = new System.Drawing.Point(0, 0);
            this.layoutControl3.Name = "layoutControl3";
            this.layoutControl3.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(892, 161, 450, 350);
            this.layoutControl3.Root = this.layoutControlGroup9;
            this.layoutControl3.Size = new System.Drawing.Size(210, 608);
            this.layoutControl3.TabIndex = 0;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // stretchWidthM
            // 
            this.stretchWidthM.Location = new System.Drawing.Point(12, 12);
            this.stretchWidthM.Name = "stretchWidthM";
            this.stretchWidthM.Properties.Caption = "Stretch Card to View Width";
            this.stretchWidthM.Size = new System.Drawing.Size(186, 20);
            this.stretchWidthM.StyleController = this.layoutControl3;
            this.stretchWidthM.TabIndex = 10;
            this.stretchWidthM.CheckedChanged += new System.EventHandler(this.stretchWidthM_CheckedChanged);
            // 
            // stretchHeightM
            // 
            this.stretchHeightM.Location = new System.Drawing.Point(12, 36);
            this.stretchHeightM.Name = "stretchHeightM";
            this.stretchHeightM.Properties.Caption = "Stretch Card to View Height";
            this.stretchHeightM.Size = new System.Drawing.Size(186, 20);
            this.stretchHeightM.StyleController = this.layoutControl3;
            this.stretchHeightM.TabIndex = 11;
            this.stretchHeightM.CheckedChanged += new System.EventHandler(this.stretchHeightM_CheckedChanged);
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(91, 214);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEdit1.Properties.IsFloatValue = false;
            this.spinEdit1.Properties.Mask.EditMask = "N00";
            this.spinEdit1.Properties.MaxValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.spinEdit1.Size = new System.Drawing.Size(107, 20);
            this.spinEdit1.StyleController = this.layoutControl3;
            this.spinEdit1.TabIndex = 12;
            this.spinEdit1.EditValueChanged += new System.EventHandler(this.spinEdit1_EditValueChanged);
            // 
            // spinEdit2
            // 
            this.spinEdit2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit2.Location = new System.Drawing.Point(91, 238);
            this.spinEdit2.Name = "spinEdit2";
            this.spinEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEdit2.Properties.IsFloatValue = false;
            this.spinEdit2.Properties.Mask.EditMask = "N00";
            this.spinEdit2.Properties.MaxValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.spinEdit2.Size = new System.Drawing.Size(107, 20);
            this.spinEdit2.StyleController = this.layoutControl3;
            this.spinEdit2.TabIndex = 13;
            this.spinEdit2.EditValueChanged += new System.EventHandler(this.spinEdit2_EditValueChanged);
            // 
            // layoutControlGroup9
            // 
            this.layoutControlGroup9.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup9.GroupBordersVisible = false;
            this.layoutControlGroup9.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem14,
            this.simpleLabelItem2,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.emptySpaceItem3,
            this.emptySpaceItem4,
            this.emptySpaceItem5});
            this.layoutControlGroup9.Name = "Root";
            this.layoutControlGroup9.Size = new System.Drawing.Size(210, 608);
            this.layoutControlGroup9.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.stretchWidthM;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(190, 24);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.stretchHeightM;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(190, 24);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.multiSelect;
            this.layoutControlItem14.Location = new System.Drawing.Point(0, 94);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(190, 24);
            this.layoutControlItem14.TextVisible = false;
            // 
            // simpleLabelItem2
            // 
            this.simpleLabelItem2.Location = new System.Drawing.Point(0, 118);
            this.simpleLabelItem2.Name = "simpleLabelItem2";
            this.simpleLabelItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 2, 2, 2);
            this.simpleLabelItem2.Size = new System.Drawing.Size(190, 17);
            this.simpleLabelItem2.Text = " (enables marquee selection)";
            this.simpleLabelItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.simpleLabelItem2.TextSize = new System.Drawing.Size(138, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.spinEdit1;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 202);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(190, 24);
            this.layoutControlItem9.Text = "Max Columns:";
            this.layoutControlItem9.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.spinEdit2;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 226);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(190, 24);
            this.layoutControlItem10.Text = "Max Rows:";
            this.layoutControlItem10.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem10.TextSize = new System.Drawing.Size(67, 13);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 250);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(190, 338);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 48);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(190, 46);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.Location = new System.Drawing.Point(0, 135);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(190, 67);
            // 
            // cardAlignment
            // 
            this.cardAlignment.Location = new System.Drawing.Point(101, 183);
            this.cardAlignment.Name = "cardAlignment";
            this.cardAlignment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cardAlignment.Size = new System.Drawing.Size(97, 20);
            this.cardAlignment.StyleController = this.layoutControl2;
            this.cardAlignment.TabIndex = 10;
            this.cardAlignment.SelectedIndexChanged += new System.EventHandler(this.cardAlignment_SelectedIndexChanged);
            // 
            // layoutControl2
            // 
            this.layoutControl2.AllowCustomization = false;
            this.layoutControl2.Controls.Add(this.stretchWidth);
            this.layoutControl2.Controls.Add(this.stretchHeight);
            this.layoutControl2.Controls.Add(this.cardAlignment);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1096, 194, 450, 350);
            this.layoutControl2.Root = this.layoutControlGroup6;
            this.layoutControl2.Size = new System.Drawing.Size(210, 608);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // stretchWidth
            // 
            this.stretchWidth.EditValue = true;
            this.stretchWidth.Location = new System.Drawing.Point(12, 12);
            this.stretchWidth.Name = "stretchWidth";
            this.stretchWidth.Properties.Caption = "Stretch Card to View Width";
            this.stretchWidth.Size = new System.Drawing.Size(186, 20);
            this.stretchWidth.StyleController = this.layoutControl2;
            this.stretchWidth.TabIndex = 8;
            this.stretchWidth.CheckedChanged += new System.EventHandler(this.stretchWidth_CheckedChanged);
            // 
            // stretchHeight
            // 
            this.stretchHeight.EditValue = true;
            this.stretchHeight.Location = new System.Drawing.Point(12, 36);
            this.stretchHeight.Name = "stretchHeight";
            this.stretchHeight.Properties.Caption = "Stretch Card to View Height";
            this.stretchHeight.Size = new System.Drawing.Size(186, 20);
            this.stretchHeight.StyleController = this.layoutControl2;
            this.stretchHeight.TabIndex = 9;
            this.stretchHeight.CheckedChanged += new System.EventHandler(this.stretchHeight_CheckedChanged);
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup6.GroupBordersVisible = false;
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.layoutControlGroup6.Name = "Root";
            this.layoutControlGroup6.Size = new System.Drawing.Size(210, 608);
            this.layoutControlGroup6.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.stretchWidth;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(190, 24);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.stretchHeight;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(190, 24);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.cardAlignment;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 171);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(190, 24);
            this.layoutControlItem6.Text = "Card Alignment:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(77, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 195);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(190, 393);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 48);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(190, 123);
            // 
            // layoutControl4
            // 
            this.layoutControl4.AllowCustomization = false;
            this.layoutControl4.Controls.Add(this.customizationOptions);
            this.layoutControl4.Controls.Add(this.allowRuntimeCustomization);
            this.layoutControl4.Controls.Add(this.customizeBtn);
            this.layoutControl4.Controls.Add(this.advancedCustomization);
            this.layoutControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl4.Location = new System.Drawing.Point(0, 0);
            this.layoutControl4.Name = "layoutControl4";
            this.layoutControl4.Root = this.layoutControlGroup7;
            this.layoutControl4.Size = new System.Drawing.Size(192, 595);
            this.layoutControl4.TabIndex = 0;
            this.layoutControl4.Text = "layoutControl4";
            // 
            // customizationOptions
            // 
            this.customizationOptions.CheckOnClick = true;
            this.customizationOptions.Enabled = false;
            this.customizationOptions.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Show Group Layout Tree View", System.Windows.Forms.CheckState.Checked),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Show Group Hidden Items", System.Windows.Forms.CheckState.Checked),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Show Reset Shrink Buttons", System.Windows.Forms.CheckState.Checked),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Show Group Card Indents", System.Windows.Forms.CheckState.Checked),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Show Group Card Captions", System.Windows.Forms.CheckState.Checked),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Show Save Load Layout Buttons", System.Windows.Forms.CheckState.Checked),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Show Group View", System.Windows.Forms.CheckState.Checked),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Show Group Layout", System.Windows.Forms.CheckState.Checked),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Show Group Cards", System.Windows.Forms.CheckState.Checked),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Show Group Fields", System.Windows.Forms.CheckState.Checked)});
            this.customizationOptions.Location = new System.Drawing.Point(10, 68);
            this.customizationOptions.Name = "customizationOptions";
            this.customizationOptions.Size = new System.Drawing.Size(172, 188);
            this.customizationOptions.StyleController = this.layoutControl4;
            this.customizationOptions.TabIndex = 23;
            this.customizationOptions.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.customizationOptionsList_ItemCheck);
            // 
            // allowRuntimeCustomization
            // 
            this.allowRuntimeCustomization.EditValue = true;
            this.allowRuntimeCustomization.Location = new System.Drawing.Point(10, 10);
            this.allowRuntimeCustomization.Name = "allowRuntimeCustomization";
            this.allowRuntimeCustomization.Properties.Caption = "Allow Runtime Customization";
            this.allowRuntimeCustomization.Size = new System.Drawing.Size(172, 20);
            this.allowRuntimeCustomization.StyleController = this.layoutControl4;
            this.allowRuntimeCustomization.TabIndex = 4;
            this.allowRuntimeCustomization.CheckedChanged += new System.EventHandler(this.allowRuntimeCustomization_CheckedChanged);
            // 
            // customizeBtn
            // 
            this.customizeBtn.Location = new System.Drawing.Point(10, 268);
            this.customizeBtn.Name = "customizeBtn";
            this.customizeBtn.Size = new System.Drawing.Size(172, 22);
            this.customizeBtn.StyleController = this.layoutControl4;
            this.customizeBtn.TabIndex = 7;
            this.customizeBtn.Text = "Customize...";
            this.customizeBtn.Click += new System.EventHandler(this.customizeBtn_Click);
            // 
            // advancedCustomization
            // 
            this.advancedCustomization.Location = new System.Drawing.Point(10, 42);
            this.advancedCustomization.Name = "advancedCustomization";
            this.advancedCustomization.Properties.Caption = "Advanced Options:";
            this.advancedCustomization.Size = new System.Drawing.Size(172, 20);
            this.advancedCustomization.StyleController = this.layoutControl4;
            this.advancedCustomization.TabIndex = 21;
            this.advancedCustomization.CheckedChanged += new System.EventHandler(this.advancedCustomization_CheckedChanged);
            // 
            // layoutControlGroup7
            // 
            this.layoutControlGroup7.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup7.GroupBordersVisible = false;
            this.layoutControlGroup7.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem18,
            this.layoutControlItem5,
            this.layoutControlItem1,
            this.emptySpaceItem7});
            this.layoutControlGroup7.Name = "layoutControlGroup1";
            this.layoutControlGroup7.Size = new System.Drawing.Size(192, 595);
            this.layoutControlGroup7.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.allowRuntimeCustomization;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 12);
            this.layoutControlItem2.Size = new System.Drawing.Size(172, 32);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.Control = this.advancedCustomization;
            this.layoutControlItem18.Location = new System.Drawing.Point(0, 32);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 6);
            this.layoutControlItem18.Size = new System.Drawing.Size(172, 26);
            this.layoutControlItem18.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.customizeBtn;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 258);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem5.Size = new System.Drawing.Size(172, 22);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.customizationOptions;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 58);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(1, 200);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 12);
            this.layoutControlItem1.Size = new System.Drawing.Size(172, 200);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.Location = new System.Drawing.Point(0, 280);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(172, 295);
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage3);
            this.navigationPane1.Controls.Add(this.navigationPage2);
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Controls.Add(this.navigationPage4);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Right;
            this.navigationPane1.ItemOrientation = System.Windows.Forms.Orientation.Vertical;
            this.navigationPane1.Location = new System.Drawing.Point(835, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.PageProperties.AppearanceCaption.Options.UseTextOptions = true;
            this.navigationPane1.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.navigationPane1.PageProperties.ShowExpandButton = false;
            this.navigationPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text;
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2,
            this.navigationPage3,
            this.navigationPage4});
            this.navigationPane1.RegularSize = new System.Drawing.Size(253, 668);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.Size = new System.Drawing.Size(253, 668);
            this.navigationPane1.TabIndex = 9;
            this.navigationPane1.Text = "navigationPane1";
            this.navigationPane1.SelectedPageChanged += new DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(this.navigationPane1_SelectedPageChanged);
            // 
            // navigationPage3
            // 
            this.navigationPage3.Caption = "MultiRecord Layout";
            this.navigationPage3.Controls.Add(this.layoutControl3);
            this.navigationPage3.ImageOptions.ImageUri.Uri = "New";
            this.navigationPage3.Name = "navigationPage3";
            this.navigationPage3.Size = new System.Drawing.Size(210, 608);
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "SingleRecord Layout";
            this.navigationPage2.Controls.Add(this.layoutControl2);
            this.navigationPage2.ImageOptions.ImageUri.Uri = "New";
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(210, 608);
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Runtime Customization";
            this.navigationPage1.Controls.Add(this.layoutControl4);
            this.navigationPage1.ImageOptions.ImageUri.Uri = "New";
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(192, 595);
            // 
            // navigationPage4
            // 
            this.navigationPage4.Caption = "Custom Events";
            this.navigationPage4.Controls.Add(this.layoutControl5);
            this.navigationPage4.ImageOptions.ImageUri.Uri = "New";
            this.navigationPage4.Name = "navigationPage4";
            this.navigationPage4.Size = new System.Drawing.Size(210, 608);
            // 
            // pnlGrid
            // 
            this.pnlGrid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlGrid.Controls.Add(this.gridControl1);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 0);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(835, 668);
            this.pnlGrid.TabIndex = 10;
            // 
            // NWindLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.navigationPane1);
            this.Name = "NWindLayout";
            this.Size = new System.Drawing.Size(1088, 668);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colHomePhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPostalCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colReportsTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colTitleOfCourtesy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Group2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNWindCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesInFields.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl5)).EndInit();
            this.layoutControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.visibilityOnlyForFocused.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoVisibility.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesInCaptions.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesOnlyForFocused.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesVisibility.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiSelect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
            this.layoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stretchWidthM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stretchHeightM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardAlignment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stretchWidth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stretchHeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl4)).EndInit();
            this.layoutControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customizationOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowRuntimeCustomization.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedCustomization.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage3.ResumeLayout(false);
            this.navigationPage2.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            this.navigationPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected GridControl gridControl1;
        private dsNWindCustomers dsNWindCustomers;
        protected DevExpress.XtraGrid.Views.Layout.LayoutView layoutView;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colAddress;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colCity;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colCountry;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colFirstName;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colHomePhone;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colLastName;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colNotes;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colPhoto;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colPostalCode;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colRegion;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colReportsTo;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colTitle;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colTitleOfCourtesy;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.CheckEdit allowRuntimeCustomization;
        private DevExpress.XtraEditors.SimpleButton customizeBtn;
        private DevExpress.XtraEditors.CheckEdit stretchWidth;
        private DevExpress.XtraEditors.CheckEdit stretchHeight;
        private DevExpress.XtraEditors.ImageComboBoxEdit cardAlignment;
        private DevExpress.XtraEditors.CheckEdit stretchWidthM;
        private DevExpress.XtraEditors.CheckEdit stretchHeightM;
        private DevExpress.XtraEditors.SpinEdit spinEdit2;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private DevExpress.XtraEditors.CheckEdit imagesOnlyForFocused;
        private DevExpress.XtraEditors.CheckEdit imagesInFields;
        private DevExpress.XtraEditors.CheckEdit imagesInCaptions;
        private DevExpress.XtraEditors.CheckEdit multiSelect;
        private DevExpress.XtraEditors.CheckEdit photoVisibility;
        private DevExpress.XtraEditors.CheckEdit notesVisibility;
        private DevExpress.XtraEditors.CheckEdit visibilityOnlyForFocused;
        private DevExpress.XtraEditors.CheckEdit advancedCustomization;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox3;
        private Views.Layout.LayoutViewField layoutViewField_colAddress;
        private Views.Layout.LayoutViewField layoutViewField_colCity;
        private Views.Layout.LayoutViewField layoutViewField_colCountry;
        private Views.Layout.LayoutViewField layoutViewField_colFirstName;
        private Views.Layout.LayoutViewField layoutViewField_colHomePhone;
        private Views.Layout.LayoutViewField layoutViewField_colLastName;
        private Views.Layout.LayoutViewField layoutViewField_colNotes;
        private Views.Layout.LayoutViewField layoutViewField_colPhoto;
        private Views.Layout.LayoutViewField layoutViewField_colPostalCode;
        private Views.Layout.LayoutViewField layoutViewField_colRegion;
        private Views.Layout.LayoutViewField layoutViewField_colReportsTo;
        private Views.Layout.LayoutViewField layoutViewField_colTitle;
        private Views.Layout.LayoutViewField layoutViewField_colTitleOfCourtesy;
        private Views.Layout.LayoutViewCard layoutViewCard1;
        private XtraLayout.LayoutControlGroup Group2;
        private XtraLayout.EmptySpaceItem Item12;
        private XtraLayout.SimpleSeparator item1;
        private XtraLayout.LayoutControl layoutControl4;
        private XtraLayout.LayoutControlGroup layoutControlGroup7;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem18;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraBars.Navigation.NavigationPane navigationPane1;
        private XtraBars.Navigation.NavigationPage navigationPage3;
        private XtraLayout.LayoutControl layoutControl3;
        private XtraLayout.LayoutControlGroup layoutControlGroup9;
        private XtraBars.Navigation.NavigationPage navigationPage2;
        private XtraLayout.LayoutControl layoutControl2;
        private XtraLayout.LayoutControlGroup layoutControlGroup6;
        private XtraBars.Navigation.NavigationPage navigationPage1;
        private XtraBars.Navigation.NavigationPage navigationPage4;
        private XtraLayout.LayoutControl layoutControl5;
        private XtraLayout.LayoutControlGroup layoutControlGroup8;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControlItem layoutControlItem6;
        private XtraLayout.LayoutControlItem layoutControlItem12;
        private XtraLayout.LayoutControlItem layoutControlItem11;
        private XtraLayout.LayoutControlItem layoutControlItem13;
        private XtraLayout.LayoutControlItem layoutControlItem16;
        private XtraLayout.LayoutControlItem layoutControlItem15;
        private XtraLayout.LayoutControlItem layoutControlItem17;
        private XtraLayout.SimpleLabelItem simpleLabelItem3;
        private XtraLayout.EmptySpaceItem emptySpaceItem9;
        private XtraLayout.LayoutControlItem layoutControlItem7;
        private XtraLayout.LayoutControlItem layoutControlItem8;
        private XtraLayout.LayoutControlItem layoutControlItem14;
        private XtraLayout.SimpleLabelItem simpleLabelItem2;
        private XtraLayout.LayoutControlItem layoutControlItem9;
        private XtraLayout.LayoutControlItem layoutControlItem10;
        private XtraEditors.PanelControl pnlGrid;
        private XtraLayout.EmptySpaceItem emptySpaceItem6;
        private XtraLayout.EmptySpaceItem emptySpaceItem3;
        private XtraLayout.EmptySpaceItem emptySpaceItem4;
        private XtraLayout.EmptySpaceItem emptySpaceItem5;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem2;
        private XtraEditors.CheckedListBoxControl customizationOptions;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem7;
    }
}
