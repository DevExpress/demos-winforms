namespace DevExpress.XtraVerticalGrid.Demos {
    partial class VerticalGrid {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerticalGrid));
            this.vGridControl = new DevExpress.XtraVerticalGrid.VGridControl();
            this.gridIcons = new DevExpress.Utils.ImageCollection(this.components);
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ctgOrderInfo = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.erID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.erSalesDate = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.erDiscount = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.erModelPrice = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.ctgPerformance = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.merMPG = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRow();
            this.merpMPGCity = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.merpMPGHighway = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.merTransmmision = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRow();
            this.merpTransmissionType = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.merpTransmissionSpeeds = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.merTorqueHorsepower = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRow();
            this.merpTorque = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.merpHorsepower = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.erCylinders = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.ctgModel = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.erTrademark = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.erCategory = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.erBodyStyle = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.erDoors = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.erName = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.erModification = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.erPhoto = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.imageDiscount = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIcons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // vGridControl
            // 
            this.vGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.vGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vGridControl.ImageList = this.gridIcons;
            this.vGridControl.Location = new System.Drawing.Point(0, 0);
            this.vGridControl.Name = "vGridControl";
            this.vGridControl.OptionsCustomization.UseAdvancedCustomizationForm = DevExpress.Utils.DefaultBoolean.True;
            this.vGridControl.OptionsFilter.FilterEditorAllowCustomExpressions = DevExpress.Utils.DefaultBoolean.True;
            this.vGridControl.OptionsMenu.ShowConditionalFormattingItem = true;
            this.vGridControl.OptionsView.AllowHtmlText = true;
            this.vGridControl.OptionsView.FilterCriteriaDisplayStyle = DevExpress.XtraEditors.FilterCriteriaDisplayStyle.Visual;
            this.vGridControl.OptionsView.MinRowAutoHeight = 20;
            this.vGridControl.RecordWidth = 184;
            this.vGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2});
            this.vGridControl.RowHeaderWidth = 275;
            this.vGridControl.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.ctgOrderInfo,
            this.ctgPerformance,
            this.ctgModel});
            this.vGridControl.Size = new System.Drawing.Size(784, 432);
            this.vGridControl.TabIndex = 0;
            this.vGridControl.FilterPopupExcelData += new DevExpress.XtraVerticalGrid.FilterPopupExcelDataEventHandler(this.vGridControl_FilterPopupExcelData);
            this.vGridControl.CellValueChanged += new DevExpress.XtraVerticalGrid.Events.CellValueChangedEventHandler(this.OnGridCellValueChanged);
            // 
            // gridIcons
            // 
            this.gridIcons.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("gridIcons.ImageStream")));
            this.gridIcons.Images.SetKeyName(0, "bcDiscount.Image.png");
            this.gridIcons.Images.SetKeyName(1, "gridBand3.Image.png");
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "d5";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Mask.EditMask = "p";
            this.repositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // ctgOrderInfo
            // 
            this.ctgOrderInfo.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.erID,
            this.erSalesDate,
            this.erDiscount,
            this.erModelPrice});
            this.ctgOrderInfo.Name = "ctgOrderInfo";
            this.ctgOrderInfo.OptionsRow.AllowFocus = false;
            this.ctgOrderInfo.Properties.Caption = "Order Info";
            // 
            // erID
            // 
            this.erID.Name = "erID";
            this.erID.Properties.AllowEdit = false;
            this.erID.Properties.Caption = "ID";
            this.erID.Properties.FieldName = "OrderID";
            this.erID.Properties.RowEdit = this.repositoryItemTextEdit1;
            // 
            // erSalesDate
            // 
            this.erSalesDate.Name = "erSalesDate";
            this.erSalesDate.Properties.Caption = "Sales Date";
            this.erSalesDate.Properties.FieldName = "SalesDate";
            this.erSalesDate.Properties.SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
            // 
            // erDiscount
            // 
            this.erDiscount.Name = "erDiscount";
            this.erDiscount.Properties.Caption = "Discount";
            this.erDiscount.Properties.FieldName = "Discount";
            this.erDiscount.Properties.RowEdit = this.repositoryItemTextEdit2;
            // 
            // erModelPrice
            // 
            this.erModelPrice.Name = "erModelPrice";
            this.erModelPrice.Properties.Caption = "Model Price";
            this.erModelPrice.Properties.FieldName = "ModelPrice";
            // 
            // ctgPerformance
            // 
            this.ctgPerformance.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.merMPG,
            this.merTransmmision,
            this.merTorqueHorsepower,
            this.erCylinders});
            this.ctgPerformance.Name = "ctgPerformance";
            this.ctgPerformance.OptionsRow.AllowFocus = false;
            this.ctgPerformance.Properties.Caption = "Performance";
            // 
            // merMPG
            // 
            this.merMPG.Name = "merMPG";
            this.merMPG.OptionsRow.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            this.merMPG.PropertiesCollection.AddRange(new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties[] {
            this.merpMPGCity,
            this.merpMPGHighway});
            // 
            // merpMPGCity
            // 
            this.merpMPGCity.Caption = "MPG <b>City</b>";
            this.merpMPGCity.FieldName = "MPGCity";
            this.merpMPGCity.Name = "merpMPGCity";
            this.merpMPGCity.Width = 99;
            // 
            // merpMPGHighway
            // 
            this.merpMPGHighway.Caption = "MPG <b>Highway</b>";
            this.merpMPGHighway.FieldName = "MPGHighway";
            this.merpMPGHighway.Name = "merpMPGHighway";
            this.merpMPGHighway.Width = 108;
            // 
            // merTransmmision
            // 
            this.merTransmmision.Name = "merTransmmision";
            this.merTransmmision.PropertiesCollection.AddRange(new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties[] {
            this.merpTransmissionType,
            this.merpTransmissionSpeeds});
            // 
            // merpTransmissionType
            // 
            this.merpTransmissionType.Caption = "Transmission Type";
            this.merpTransmissionType.FieldName = "TransmissionType";
            this.merpTransmissionType.Name = "merpTransmissionType";
            this.merpTransmissionType.Width = 97;
            // 
            // merpTransmissionSpeeds
            // 
            this.merpTransmissionSpeeds.Caption = "Transmission Speeds";
            this.merpTransmissionSpeeds.FieldName = "TransmissionSpeeds";
            this.merpTransmissionSpeeds.Name = "merpTransmissionSpeeds";
            this.merpTransmissionSpeeds.Width = 105;
            // 
            // merTorqueHorsepower
            // 
            this.merTorqueHorsepower.Name = "merTorqueHorsepower";
            this.merTorqueHorsepower.PropertiesCollection.AddRange(new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties[] {
            this.merpTorque,
            this.merpHorsepower});
            // 
            // merpTorque
            // 
            this.merpTorque.Caption = "Torque";
            this.merpTorque.FieldName = "Torque";
            this.merpTorque.Name = "merpTorque";
            this.merpTorque.Width = 99;
            // 
            // merpHorsepower
            // 
            this.merpHorsepower.Caption = "Horsepower";
            this.merpHorsepower.FieldName = "Horsepower";
            this.merpHorsepower.Name = "merpHorsepower";
            this.merpHorsepower.Width = 108;
            // 
            // erCylinders
            // 
            this.erCylinders.Name = "erCylinders";
            this.erCylinders.Properties.Caption = "Cylinders";
            this.erCylinders.Properties.FieldName = "Cylinders";
            // 
            // ctgModel
            // 
            this.ctgModel.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.erTrademark,
            this.erCategory,
            this.erBodyStyle,
            this.erDoors,
            this.erName,
            this.erModification,
            this.erPhoto});
            this.ctgModel.Name = "ctgModel";
            this.ctgModel.OptionsRow.AllowFocus = false;
            this.ctgModel.Properties.Caption = "Model";
            // 
            // erTrademark
            // 
            this.erTrademark.Name = "erTrademark";
            this.erTrademark.Properties.Caption = "Trademark";
            this.erTrademark.Properties.FieldName = "Trademark";
            // 
            // erCategory
            // 
            this.erCategory.Name = "erCategory";
            this.erCategory.Properties.Caption = "Category";
            this.erCategory.Properties.FieldName = "Category";
            // 
            // erBodyStyle
            // 
            this.erBodyStyle.Name = "erBodyStyle";
            this.erBodyStyle.Properties.Caption = "Body Style";
            this.erBodyStyle.Properties.FieldName = "BodyStyle";
            // 
            // erDoors
            // 
            this.erDoors.Name = "erDoors";
            this.erDoors.Properties.Caption = "Doors";
            this.erDoors.Properties.FieldName = "Doors";
            // 
            // erName
            // 
            this.erName.Name = "erName";
            this.erName.Properties.Caption = "Name";
            this.erName.Properties.FieldName = "Name";
            this.erName.Properties.OptionsFilter.PopupExcelFilterGrouping = "Trademark;Name";
            // 
            // erModification
            // 
            this.erModification.Name = "erModification";
            this.erModification.Properties.Caption = "Modification";
            this.erModification.Properties.FieldName = "Modification";
            // 
            // erPhoto
            // 
            this.erPhoto.Name = "erPhoto";
            this.erPhoto.Properties.Caption = "Photo";
            this.erPhoto.Properties.FieldName = "Photo";
            this.erPhoto.Properties.ReadOnly = false;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // imageDiscount
            // 
            this.imageDiscount.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageDiscount.ImageStream")));
            this.imageDiscount.Images.SetKeyName(0, "1.png");
            this.imageDiscount.Images.SetKeyName(1, "2.png");
            this.imageDiscount.Images.SetKeyName(2, "3.png");
            // 
            // VerticalGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vGridControl);
            this.Name = "VerticalGrid";
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIcons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageDiscount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VGridControl vGridControl;
        private XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private Rows.CategoryRow ctgOrderInfo;
        private Rows.EditorRow erID;
        private Rows.EditorRow erSalesDate;
        private Rows.EditorRow erDiscount;
        private Rows.EditorRow erModelPrice;
        private Rows.CategoryRow ctgPerformance;
        private Rows.EditorRow erDoors;
        private Rows.MultiEditorRow merMPG;
        private Rows.MultiEditorRowProperties merpMPGCity;
        private Rows.MultiEditorRowProperties merpMPGHighway;
        private Rows.MultiEditorRow merTransmmision;
        private Rows.MultiEditorRowProperties merpTransmissionType;
        private Rows.MultiEditorRowProperties merpTransmissionSpeeds;
        private Rows.MultiEditorRow merTorqueHorsepower;
        private Rows.MultiEditorRowProperties merpTorque;
        private Rows.MultiEditorRowProperties merpHorsepower;
        private Rows.CategoryRow ctgModel;
        private Rows.EditorRow erTrademark;
        private Rows.EditorRow erCategory;
        private Rows.EditorRow erBodyStyle;
        private Rows.EditorRow erName;
        private Rows.EditorRow erModification;
        private Rows.EditorRow erPhoto;
        private Rows.EditorRow erCylinders;
        private DevExpress.Utils.ImageCollection gridIcons;
        private DevExpress.Utils.ImageCollection imageDiscount;
    }
}
