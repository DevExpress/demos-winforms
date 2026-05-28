Namespace DevExpress.XtraVerticalGrid.Demos

    Partial Class VerticalGrid

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraVerticalGrid.Demos.VerticalGrid))
            Me.vGridControl = New DevExpress.XtraVerticalGrid.VGridControl()
            Me.gridIcons = New DevExpress.Utils.ImageCollection(Me.components)
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.repositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.ctgOrderInfo = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
            Me.erID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.erSalesDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.erDiscount = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.erModelPrice = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.ctgPerformance = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
            Me.merMPG = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
            Me.merpMPGCity = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
            Me.merpMPGHighway = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
            Me.merTransmmision = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
            Me.merpTransmissionType = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
            Me.merpTransmissionSpeeds = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
            Me.merTorqueHorsepower = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
            Me.merpTorque = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
            Me.merpHorsepower = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
            Me.erCylinders = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.ctgModel = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
            Me.erTrademark = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.erCategory = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.erBodyStyle = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.erDoors = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.erName = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.erModification = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.erPhoto = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.imageDiscount = New DevExpress.Utils.ImageCollection(Me.components)
            CType((Me.vGridControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridIcons), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTextEdit2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageDiscount), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' vGridControl
            ' 
            Me.vGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.vGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.vGridControl.ImageList = Me.gridIcons
            Me.vGridControl.Location = New System.Drawing.Point(0, 0)
            Me.vGridControl.Name = "vGridControl"
            Me.vGridControl.OptionsCustomization.UseAdvancedCustomizationForm = DevExpress.Utils.DefaultBoolean.[True]
            Me.vGridControl.OptionsFilter.FilterEditorAllowCustomExpressions = DevExpress.Utils.DefaultBoolean.[True]
            Me.vGridControl.OptionsMenu.ShowConditionalFormattingItem = True
            Me.vGridControl.OptionsView.AllowHtmlText = True
            Me.vGridControl.OptionsView.FilterCriteriaDisplayStyle = DevExpress.XtraEditors.FilterCriteriaDisplayStyle.Visual
            Me.vGridControl.OptionsView.MinRowAutoHeight = 20
            Me.vGridControl.RecordWidth = 184
            Me.vGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemTextEdit1, Me.repositoryItemTextEdit2})
            Me.vGridControl.RowHeaderWidth = 275
            Me.vGridControl.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.ctgOrderInfo, Me.ctgPerformance, Me.ctgModel})
            Me.vGridControl.Size = New System.Drawing.Size(784, 432)
            Me.vGridControl.TabIndex = 0
            AddHandler Me.vGridControl.FilterPopupExcelData, New DevExpress.XtraVerticalGrid.FilterPopupExcelDataEventHandler(AddressOf Me.vGridControl_FilterPopupExcelData)
            AddHandler Me.vGridControl.CellValueChanged, New DevExpress.XtraVerticalGrid.Events.CellValueChangedEventHandler(AddressOf Me.OnGridCellValueChanged)
            ' 
            ' gridIcons
            ' 
            Me.gridIcons.ImageStream = CType((resources.GetObject("gridIcons.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
            Me.gridIcons.Images.SetKeyName(0, "bcDiscount.Image.png")
            Me.gridIcons.Images.SetKeyName(1, "gridBand3.Image.png")
            ' 
            ' repositoryItemTextEdit1
            ' 
            Me.repositoryItemTextEdit1.AutoHeight = False
            Me.repositoryItemTextEdit1.Mask.EditMask = "d5"
            Me.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            ' 
            ' repositoryItemTextEdit2
            ' 
            Me.repositoryItemTextEdit2.AutoHeight = False
            Me.repositoryItemTextEdit2.Mask.EditMask = "p"
            Me.repositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = True
            Me.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2"
            ' 
            ' ctgOrderInfo
            ' 
            Me.ctgOrderInfo.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.erID, Me.erSalesDate, Me.erDiscount, Me.erModelPrice})
            Me.ctgOrderInfo.Name = "ctgOrderInfo"
            Me.ctgOrderInfo.OptionsRow.AllowFocus = False
            Me.ctgOrderInfo.Properties.Caption = "Order Info"
            ' 
            ' erID
            ' 
            Me.erID.Name = "erID"
            Me.erID.Properties.AllowEdit = False
            Me.erID.Properties.Caption = "ID"
            Me.erID.Properties.FieldName = "OrderID"
            Me.erID.Properties.RowEdit = Me.repositoryItemTextEdit1
            ' 
            ' erSalesDate
            ' 
            Me.erSalesDate.Name = "erSalesDate"
            Me.erSalesDate.Properties.Caption = "Sales Date"
            Me.erSalesDate.Properties.FieldName = "SalesDate"
            Me.erSalesDate.Properties.SortOrder = DevExpress.Data.ColumnSortOrder.Descending
            ' 
            ' erDiscount
            ' 
            Me.erDiscount.Name = "erDiscount"
            Me.erDiscount.Properties.Caption = "Discount"
            Me.erDiscount.Properties.FieldName = "Discount"
            Me.erDiscount.Properties.RowEdit = Me.repositoryItemTextEdit2
            ' 
            ' erModelPrice
            ' 
            Me.erModelPrice.Name = "erModelPrice"
            Me.erModelPrice.Properties.Caption = "Model Price"
            Me.erModelPrice.Properties.FieldName = "ModelPrice"
            ' 
            ' ctgPerformance
            ' 
            Me.ctgPerformance.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.merMPG, Me.merTransmmision, Me.merTorqueHorsepower, Me.erCylinders})
            Me.ctgPerformance.Name = "ctgPerformance"
            Me.ctgPerformance.OptionsRow.AllowFocus = False
            Me.ctgPerformance.Properties.Caption = "Performance"
            ' 
            ' merMPG
            ' 
            Me.merMPG.Name = "merMPG"
            Me.merMPG.OptionsRow.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
            Me.merMPG.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.merpMPGCity, Me.merpMPGHighway})
            ' 
            ' merpMPGCity
            ' 
            Me.merpMPGCity.Caption = "MPG <b>City</b>"
            Me.merpMPGCity.FieldName = "MPGCity"
            Me.merpMPGCity.Name = "merpMPGCity"
            Me.merpMPGCity.Width = 99
            ' 
            ' merpMPGHighway
            ' 
            Me.merpMPGHighway.Caption = "MPG <b>Highway</b>"
            Me.merpMPGHighway.FieldName = "MPGHighway"
            Me.merpMPGHighway.Name = "merpMPGHighway"
            Me.merpMPGHighway.Width = 108
            ' 
            ' merTransmmision
            ' 
            Me.merTransmmision.Name = "merTransmmision"
            Me.merTransmmision.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.merpTransmissionType, Me.merpTransmissionSpeeds})
            ' 
            ' merpTransmissionType
            ' 
            Me.merpTransmissionType.Caption = "Transmission Type"
            Me.merpTransmissionType.FieldName = "TransmissionType"
            Me.merpTransmissionType.Name = "merpTransmissionType"
            Me.merpTransmissionType.Width = 97
            ' 
            ' merpTransmissionSpeeds
            ' 
            Me.merpTransmissionSpeeds.Caption = "Transmission Speeds"
            Me.merpTransmissionSpeeds.FieldName = "TransmissionSpeeds"
            Me.merpTransmissionSpeeds.Name = "merpTransmissionSpeeds"
            Me.merpTransmissionSpeeds.Width = 105
            ' 
            ' merTorqueHorsepower
            ' 
            Me.merTorqueHorsepower.Name = "merTorqueHorsepower"
            Me.merTorqueHorsepower.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.merpTorque, Me.merpHorsepower})
            ' 
            ' merpTorque
            ' 
            Me.merpTorque.Caption = "Torque"
            Me.merpTorque.FieldName = "Torque"
            Me.merpTorque.Name = "merpTorque"
            Me.merpTorque.Width = 99
            ' 
            ' merpHorsepower
            ' 
            Me.merpHorsepower.Caption = "Horsepower"
            Me.merpHorsepower.FieldName = "Horsepower"
            Me.merpHorsepower.Name = "merpHorsepower"
            Me.merpHorsepower.Width = 108
            ' 
            ' erCylinders
            ' 
            Me.erCylinders.Name = "erCylinders"
            Me.erCylinders.Properties.Caption = "Cylinders"
            Me.erCylinders.Properties.FieldName = "Cylinders"
            ' 
            ' ctgModel
            ' 
            Me.ctgModel.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.erTrademark, Me.erCategory, Me.erBodyStyle, Me.erDoors, Me.erName, Me.erModification, Me.erPhoto})
            Me.ctgModel.Name = "ctgModel"
            Me.ctgModel.OptionsRow.AllowFocus = False
            Me.ctgModel.Properties.Caption = "Model"
            ' 
            ' erTrademark
            ' 
            Me.erTrademark.Name = "erTrademark"
            Me.erTrademark.Properties.Caption = "Trademark"
            Me.erTrademark.Properties.FieldName = "Trademark"
            ' 
            ' erCategory
            ' 
            Me.erCategory.Name = "erCategory"
            Me.erCategory.Properties.Caption = "Category"
            Me.erCategory.Properties.FieldName = "Category"
            ' 
            ' erBodyStyle
            ' 
            Me.erBodyStyle.Name = "erBodyStyle"
            Me.erBodyStyle.Properties.Caption = "Body Style"
            Me.erBodyStyle.Properties.FieldName = "BodyStyle"
            ' 
            ' erDoors
            ' 
            Me.erDoors.Name = "erDoors"
            Me.erDoors.Properties.Caption = "Doors"
            Me.erDoors.Properties.FieldName = "Doors"
            ' 
            ' erName
            ' 
            Me.erName.Name = "erName"
            Me.erName.Properties.Caption = "Name"
            Me.erName.Properties.FieldName = "Name"
            Me.erName.Properties.OptionsFilter.PopupExcelFilterGrouping = "Trademark;Name"
            ' 
            ' erModification
            ' 
            Me.erModification.Name = "erModification"
            Me.erModification.Properties.Caption = "Modification"
            Me.erModification.Properties.FieldName = "Modification"
            ' 
            ' erPhoto
            ' 
            Me.erPhoto.Name = "erPhoto"
            Me.erPhoto.Properties.Caption = "Photo"
            Me.erPhoto.Properties.FieldName = "Photo"
            Me.erPhoto.Properties.[ReadOnly] = False
            ' 
            ' repositoryItemSpinEdit1
            ' 
            Me.repositoryItemSpinEdit1.AutoHeight = False
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            ' 
            ' imageDiscount
            ' 
            Me.imageDiscount.ImageStream = CType((resources.GetObject("imageDiscount.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
            Me.imageDiscount.Images.SetKeyName(0, "1.png")
            Me.imageDiscount.Images.SetKeyName(1, "2.png")
            Me.imageDiscount.Images.SetKeyName(2, "3.png")
            ' 
            ' VerticalGrid
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.vGridControl)
            Me.Name = "VerticalGrid"
            CType((Me.vGridControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridIcons), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTextEdit2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageDiscount), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private vGridControl As DevExpress.XtraVerticalGrid.VGridControl

        Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private repositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

        Private ctgOrderInfo As DevExpress.XtraVerticalGrid.Rows.CategoryRow

        Private erID As DevExpress.XtraVerticalGrid.Rows.EditorRow

        Private erSalesDate As DevExpress.XtraVerticalGrid.Rows.EditorRow

        Private erDiscount As DevExpress.XtraVerticalGrid.Rows.EditorRow

        Private erModelPrice As DevExpress.XtraVerticalGrid.Rows.EditorRow

        Private ctgPerformance As DevExpress.XtraVerticalGrid.Rows.CategoryRow

        Private erDoors As DevExpress.XtraVerticalGrid.Rows.EditorRow

        Private merMPG As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow

        Private merpMPGCity As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties

        Private merpMPGHighway As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties

        Private merTransmmision As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow

        Private merpTransmissionType As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties

        Private merpTransmissionSpeeds As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties

        Private merTorqueHorsepower As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow

        Private merpTorque As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties

        Private merpHorsepower As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties

        Private ctgModel As DevExpress.XtraVerticalGrid.Rows.CategoryRow

        Private erTrademark As DevExpress.XtraVerticalGrid.Rows.EditorRow

        Private erCategory As DevExpress.XtraVerticalGrid.Rows.EditorRow

        Private erBodyStyle As DevExpress.XtraVerticalGrid.Rows.EditorRow

        Private erName As DevExpress.XtraVerticalGrid.Rows.EditorRow

        Private erModification As DevExpress.XtraVerticalGrid.Rows.EditorRow

        Private erPhoto As DevExpress.XtraVerticalGrid.Rows.EditorRow

        Private erCylinders As DevExpress.XtraVerticalGrid.Rows.EditorRow

        Private gridIcons As DevExpress.Utils.ImageCollection

        Private imageDiscount As DevExpress.Utils.ImageCollection
    End Class
End Namespace
