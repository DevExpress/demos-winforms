Namespace DevExpress.XtraTreeList.Demos

    Partial Class ExcelFiltering

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraTreeList.Demos.ExcelFiltering))
            Dim treeListFormatRule1 As DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule = New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
            Dim formatConditionRuleIconSet1 As DevExpress.XtraEditors.FormatConditionRuleIconSet = New DevExpress.XtraEditors.FormatConditionRuleIconSet()
            Dim formatConditionIconSet1 As DevExpress.XtraEditors.FormatConditionIconSet = New DevExpress.XtraEditors.FormatConditionIconSet()
            Dim formatConditionIconSetIcon1 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon2 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon3 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim treeListFormatRule2 As DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule = New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
            Dim formatConditionRuleIconSet2 As DevExpress.XtraEditors.FormatConditionRuleIconSet = New DevExpress.XtraEditors.FormatConditionRuleIconSet()
            Dim formatConditionIconSet2 As DevExpress.XtraEditors.FormatConditionIconSet = New DevExpress.XtraEditors.FormatConditionIconSet()
            Dim formatConditionIconSetIcon4 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon5 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon6 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim treeListFormatRule3 As DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule = New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
            Dim formatConditionRuleIconSet3 As DevExpress.XtraEditors.FormatConditionRuleIconSet = New DevExpress.XtraEditors.FormatConditionRuleIconSet()
            Dim formatConditionIconSet3 As DevExpress.XtraEditors.FormatConditionIconSet = New DevExpress.XtraEditors.FormatConditionIconSet()
            Dim formatConditionIconSetIcon7 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon8 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon9 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim treeListFormatRule4 As DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule = New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
            Dim formatConditionRuleDataBar1 As DevExpress.XtraEditors.FormatConditionRuleDataBar = New DevExpress.XtraEditors.FormatConditionRuleDataBar()
            Me.bcDiscount = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.textEditForDiscount = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.bcMPGCity = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.bcMPGHighway = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.bcPrice = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
            Me.treeListBand2 = New DevExpress.XtraTreeList.Columns.TreeListBand()
            Me.bcTrademark = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.bcName = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.bcCategory = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.bcModification = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.bcBodyStyle = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListBand1 = New DevExpress.XtraTreeList.Columns.TreeListBand()
            Me.bcOrderID = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.textEditForOrderID = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.bcSalesDate = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListBand3 = New DevExpress.XtraTreeList.Columns.TreeListBand()
            Me.bcCylinders = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.bcDoors = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.bcTransmissionSpeeds = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.bcTransmissionType = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.bcHorsepower = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.bcTorque = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.bcPhoto = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
            Me.textEditForRoots = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            CType((Me.textEditForDiscount), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEditForOrderID), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemPictureEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEditForRoots), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' bcDiscount
            ' 
            Me.bcDiscount.ColumnEdit = Me.textEditForDiscount
            Me.bcDiscount.FieldName = "Discount"
            Me.bcDiscount.ImageOptions.SvgImage = CType((resources.GetObject("bcDiscount.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.bcDiscount.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.bcDiscount.Name = "bcDiscount"
            Me.bcDiscount.Visible = True
            Me.bcDiscount.VisibleIndex = 4
            ' 
            ' textEditForDiscount
            ' 
            Me.textEditForDiscount.AutoHeight = False
            Me.textEditForDiscount.Mask.EditMask = "p"
            Me.textEditForDiscount.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.textEditForDiscount.Mask.UseMaskAsDisplayFormat = True
            Me.textEditForDiscount.Name = "textEditForDiscount"
            ' 
            ' bcMPGCity
            ' 
            Me.bcMPGCity.Caption = "MPG <b>City"
            Me.bcMPGCity.FieldName = "MPGCity"
            Me.bcMPGCity.Name = "bcMPGCity"
            Me.bcMPGCity.Visible = True
            Me.bcMPGCity.VisibleIndex = 6
            Me.bcMPGCity.Width = 64
            ' 
            ' bcMPGHighway
            ' 
            Me.bcMPGHighway.Caption = "MPG <b>Highway"
            Me.bcMPGHighway.FieldName = "MPGHighway"
            Me.bcMPGHighway.Name = "bcMPGHighway"
            Me.bcMPGHighway.Visible = True
            Me.bcMPGHighway.VisibleIndex = 7
            Me.bcMPGHighway.Width = 64
            ' 
            ' bcPrice
            ' 
            Me.bcPrice.FieldName = "ModelPrice"
            Me.bcPrice.Name = "bcPrice"
            Me.bcPrice.Visible = True
            Me.bcPrice.VisibleIndex = 3
            Me.bcPrice.Width = 74
            ' 
            ' treeList1
            ' 
            Me.treeList1.Bands.AddRange(New DevExpress.XtraTreeList.Columns.TreeListBand() {Me.treeListBand2, Me.treeListBand1, Me.treeListBand3})
            Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.bcName, Me.bcModification, Me.bcCategory, Me.bcPrice, Me.bcMPGCity, Me.bcMPGHighway, Me.bcDoors, Me.bcCylinders, Me.bcHorsepower, Me.bcTorque, Me.bcTransmissionSpeeds, Me.bcTransmissionType, Me.bcPhoto, Me.bcSalesDate, Me.bcOrderID, Me.bcDiscount, Me.bcBodyStyle, Me.bcTrademark})
            Me.treeList1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList1.FixedLineWidth = 1
            treeListFormatRule1.Column = Me.bcDiscount
            treeListFormatRule1.Name = "Format0"
            formatConditionIconSet1.CategoryName = "Ratings"
            formatConditionIconSetIcon1.PredefinedName = "Stars3_1.png"
            formatConditionIconSetIcon1.Value = New Decimal(New Integer() {67, 0, 0, 0})
            formatConditionIconSetIcon1.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSetIcon2.PredefinedName = "Stars3_2.png"
            formatConditionIconSetIcon2.Value = New Decimal(New Integer() {33, 0, 0, 0})
            formatConditionIconSetIcon2.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSetIcon3.PredefinedName = "Stars3_3.png"
            formatConditionIconSetIcon3.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon1)
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon2)
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon3)
            formatConditionIconSet1.Name = "Stars3"
            formatConditionIconSet1.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Percent
            formatConditionRuleIconSet1.IconSet = formatConditionIconSet1
            treeListFormatRule1.Rule = formatConditionRuleIconSet1
            treeListFormatRule2.Column = Me.bcMPGCity
            treeListFormatRule2.Name = "Format1"
            formatConditionIconSet2.CategoryName = "Directional"
            formatConditionIconSetIcon4.PredefinedName = "Arrows3_1.png"
            formatConditionIconSetIcon4.Value = New Decimal(New Integer() {67, 0, 0, 0})
            formatConditionIconSetIcon4.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSetIcon5.PredefinedName = "Arrows3_2.png"
            formatConditionIconSetIcon5.Value = New Decimal(New Integer() {33, 0, 0, 0})
            formatConditionIconSetIcon5.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSetIcon6.PredefinedName = "Arrows3_3.png"
            formatConditionIconSetIcon6.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSet2.Icons.Add(formatConditionIconSetIcon4)
            formatConditionIconSet2.Icons.Add(formatConditionIconSetIcon5)
            formatConditionIconSet2.Icons.Add(formatConditionIconSetIcon6)
            formatConditionIconSet2.Name = "Arrows3Colored"
            formatConditionIconSet2.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Percent
            formatConditionRuleIconSet2.IconSet = formatConditionIconSet2
            treeListFormatRule2.Rule = formatConditionRuleIconSet2
            treeListFormatRule3.Column = Me.bcMPGHighway
            treeListFormatRule3.Name = "Format2"
            formatConditionIconSet3.CategoryName = "Directional"
            formatConditionIconSetIcon7.PredefinedName = "Arrows3_1.png"
            formatConditionIconSetIcon7.Value = New Decimal(New Integer() {67, 0, 0, 0})
            formatConditionIconSetIcon7.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSetIcon8.PredefinedName = "Arrows3_2.png"
            formatConditionIconSetIcon8.Value = New Decimal(New Integer() {33, 0, 0, 0})
            formatConditionIconSetIcon8.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSetIcon9.PredefinedName = "Arrows3_3.png"
            formatConditionIconSetIcon9.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSet3.Icons.Add(formatConditionIconSetIcon7)
            formatConditionIconSet3.Icons.Add(formatConditionIconSetIcon8)
            formatConditionIconSet3.Icons.Add(formatConditionIconSetIcon9)
            formatConditionIconSet3.Name = "Arrows3Colored"
            formatConditionIconSet3.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Percent
            formatConditionRuleIconSet3.IconSet = formatConditionIconSet3
            treeListFormatRule3.Rule = formatConditionRuleIconSet3
            treeListFormatRule4.Column = Me.bcPrice
            treeListFormatRule4.Name = "Format3"
            formatConditionRuleDataBar1.AutomaticType = DevExpress.XtraEditors.FormatConditionAutomaticType.ZeroBased
            formatConditionRuleDataBar1.PredefinedName = "Mint"
            treeListFormatRule4.Rule = formatConditionRuleDataBar1
            Me.treeList1.FormatRules.Add(treeListFormatRule1)
            Me.treeList1.FormatRules.Add(treeListFormatRule2)
            Me.treeList1.FormatRules.Add(treeListFormatRule3)
            Me.treeList1.FormatRules.Add(treeListFormatRule4)
            Me.treeList1.Location = New System.Drawing.Point(0, 0)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.OptionsBehavior.PopulateServiceColumns = True
            Me.treeList1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.treeList1.OptionsCustomization.CustomizationFormSnapMode = DevExpress.Utils.Controls.SnapMode.OwnerControl
            Me.treeList1.OptionsFilter.FilterEditorAllowCustomExpressions = DevExpress.Utils.DefaultBoolean.[True]
            Me.treeList1.OptionsMenu.ShowConditionalFormatFiltersItem = True
            Me.treeList1.OptionsView.AllowHtmlDrawHeaders = True
            Me.treeList1.OptionsView.FilterCriteriaDisplayStyle = DevExpress.XtraEditors.FilterCriteriaDisplayStyle.Visual
            Me.treeList1.ParentFieldName = "TrademarkID"
            Me.treeList1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.textEditForDiscount, Me.textEditForOrderID, Me.textEditForRoots, Me.repositoryItemPictureEdit1})
            Me.treeList1.Size = New System.Drawing.Size(784, 432)
            Me.treeList1.TabIndex = 0
            AddHandler Me.treeList1.FilterPopupExcelData, New DevExpress.XtraTreeList.FilterPopupExcelDataEventHandler(AddressOf Me.TreeList_FilterPopupExcelData)
            ' 
            ' treeListBand2
            ' 
            Me.treeListBand2.Caption = "Model"
            Me.treeListBand2.Columns.Add(Me.bcTrademark)
            Me.treeListBand2.Columns.Add(Me.bcName)
            Me.treeListBand2.Columns.Add(Me.bcCategory)
            Me.treeListBand2.Columns.Add(Me.bcModification)
            Me.treeListBand2.Columns.Add(Me.bcBodyStyle)
            Me.treeListBand2.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left
            Me.treeListBand2.Name = "treeListBand2"
            Me.treeListBand2.Width = 275
            ' 
            ' bcTrademark
            ' 
            Me.bcTrademark.FieldName = "Trademark"
            Me.bcTrademark.Name = "bcTrademark"
            Me.bcTrademark.OptionsColumn.AllowMove = False
            Me.bcTrademark.OptionsColumn.ShowInCustomizationForm = False
            Me.bcTrademark.Width = 68
            ' 
            ' bcName
            ' 
            Me.bcName.FieldName = "Name"
            Me.bcName.FieldNameSort = "Trademark"
            Me.bcName.Name = "bcName"
            Me.bcName.OptionsColumn.AllowEdit = False
            Me.bcName.OptionsColumn.AllowMove = False
            Me.bcName.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.[True]
            Me.bcName.Visible = True
            Me.bcName.VisibleIndex = 0
            Me.bcName.Width = 69
            ' 
            ' bcCategory
            ' 
            Me.bcCategory.FieldName = "Category"
            Me.bcCategory.Name = "bcCategory"
            Me.bcCategory.OptionsColumn.AllowMove = False
            Me.bcCategory.OptionsColumn.ShowInCustomizationForm = False
            Me.bcCategory.Width = 84
            ' 
            ' bcModification
            ' 
            Me.bcModification.FieldName = "Modification"
            Me.bcModification.Name = "bcModification"
            Me.bcModification.OptionsColumn.AllowMove = False
            Me.bcModification.Visible = True
            Me.bcModification.VisibleIndex = 1
            Me.bcModification.Width = 69
            ' 
            ' bcBodyStyle
            ' 
            Me.bcBodyStyle.FieldName = "BodyStyle"
            Me.bcBodyStyle.Name = "bcBodyStyle"
            Me.bcBodyStyle.OptionsColumn.AllowMove = False
            Me.bcBodyStyle.Visible = True
            Me.bcBodyStyle.VisibleIndex = 2
            Me.bcBodyStyle.Width = 69
            ' 
            ' treeListBand1
            ' 
            Me.treeListBand1.Caption = "Order Info"
            Me.treeListBand1.Columns.Add(Me.bcOrderID)
            Me.treeListBand1.Columns.Add(Me.bcPrice)
            Me.treeListBand1.Columns.Add(Me.bcDiscount)
            Me.treeListBand1.Columns.Add(Me.bcSalesDate)
            Me.treeListBand1.Name = "treeListBand1"
            Me.treeListBand1.Width = 298
            ' 
            ' bcOrderID
            ' 
            Me.bcOrderID.Caption = "ID"
            Me.bcOrderID.ColumnEdit = Me.textEditForOrderID
            Me.bcOrderID.FieldName = "OrderID"
            Me.bcOrderID.Name = "bcOrderID"
            Me.bcOrderID.OptionsColumn.AllowEdit = False
            Me.bcOrderID.OptionsColumn.ShowInCustomizationForm = False
            Me.bcOrderID.Width = 74
            ' 
            ' textEditForOrderID
            ' 
            Me.textEditForOrderID.AutoHeight = False
            Me.textEditForOrderID.Mask.EditMask = "d5"
            Me.textEditForOrderID.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.textEditForOrderID.Mask.UseMaskAsDisplayFormat = True
            Me.textEditForOrderID.Name = "textEditForOrderID"
            ' 
            ' bcSalesDate
            ' 
            Me.bcSalesDate.FieldName = "SalesDate"
            Me.bcSalesDate.Name = "bcSalesDate"
            Me.bcSalesDate.Visible = True
            Me.bcSalesDate.VisibleIndex = 5
            ' 
            ' treeListBand3
            ' 
            Me.treeListBand3.Caption = "Performance"
            Me.treeListBand3.Columns.Add(Me.bcMPGCity)
            Me.treeListBand3.Columns.Add(Me.bcMPGHighway)
            Me.treeListBand3.Columns.Add(Me.bcCylinders)
            Me.treeListBand3.Columns.Add(Me.bcDoors)
            Me.treeListBand3.Columns.Add(Me.bcTransmissionSpeeds)
            Me.treeListBand3.Columns.Add(Me.bcTransmissionType)
            Me.treeListBand3.Columns.Add(Me.bcHorsepower)
            Me.treeListBand3.Columns.Add(Me.bcTorque)
            Me.treeListBand3.Columns.Add(Me.bcPhoto)
            Me.treeListBand3.Name = "treeListBand3"
            Me.treeListBand3.Width = 193
            ' 
            ' bcCylinders
            ' 
            Me.bcCylinders.FieldName = "Cylinders"
            Me.bcCylinders.Name = "bcCylinders"
            Me.bcCylinders.Visible = True
            Me.bcCylinders.VisibleIndex = 8
            Me.bcCylinders.Width = 65
            ' 
            ' bcDoors
            ' 
            Me.bcDoors.FieldName = "Doors"
            Me.bcDoors.Name = "bcDoors"
            ' 
            ' bcTransmissionSpeeds
            ' 
            Me.bcTransmissionSpeeds.FieldName = "TransmissionSpeeds"
            Me.bcTransmissionSpeeds.Name = "bcTransmissionSpeeds"
            ' 
            ' bcTransmissionType
            ' 
            Me.bcTransmissionType.FieldName = "TransmissionType"
            Me.bcTransmissionType.Name = "bcTransmissionType"
            ' 
            ' bcHorsepower
            ' 
            Me.bcHorsepower.FieldName = "Horsepower"
            Me.bcHorsepower.Name = "bcHorsepower"
            Me.bcHorsepower.Width = 71
            ' 
            ' bcTorque
            ' 
            Me.bcTorque.FieldName = "Torque"
            Me.bcTorque.Name = "bcTorque"
            Me.bcTorque.Width = 83
            ' 
            ' bcPhoto
            ' 
            Me.bcPhoto.ColumnEdit = Me.repositoryItemPictureEdit1
            Me.bcPhoto.FieldName = "Photo"
            Me.bcPhoto.Name = "bcPhoto"
            Me.bcPhoto.OptionsColumn.AllowEdit = False
            Me.bcPhoto.OptionsFilter.AllowFilter = False
            Me.bcPhoto.Width = 64
            ' 
            ' repositoryItemPictureEdit1
            ' 
            Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
            Me.repositoryItemPictureEdit1.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
            Me.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            ' 
            ' textEditForRoots
            ' 
            Me.textEditForRoots.AutoHeight = False
            Me.textEditForRoots.Name = "textEditForRoots"
            ' 
            ' ExcelFiltering
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.treeList1)
            Me.Name = "ExcelFiltering"
            CType((Me.textEditForDiscount), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEditForOrderID), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemPictureEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEditForRoots), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private treeList1 As DevExpress.XtraTreeList.TreeList

        Private bcOrderID As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private bcPrice As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private bcDiscount As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private bcSalesDate As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private bcName As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private bcModification As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private bcMPGCity As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private bcMPGHighway As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private bcCylinders As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private bcCategory As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private bcDoors As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private bcHorsepower As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private bcTorque As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private bcTransmissionSpeeds As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private bcTransmissionType As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private bcPhoto As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private bcBodyStyle As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private bcTrademark As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private treeListBand2 As DevExpress.XtraTreeList.Columns.TreeListBand

        Private treeListBand1 As DevExpress.XtraTreeList.Columns.TreeListBand

        Private treeListBand3 As DevExpress.XtraTreeList.Columns.TreeListBand

        Private textEditForRoots As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private textEditForDiscount As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private textEditForOrderID As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    End Class
End Namespace
