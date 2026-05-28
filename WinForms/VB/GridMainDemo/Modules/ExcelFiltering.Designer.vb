Namespace DevExpress.XtraGrid.Demos

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
            Me.components = New System.ComponentModel.Container()
            Dim gridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleIconSet1 As DevExpress.XtraEditors.FormatConditionRuleIconSet = New DevExpress.XtraEditors.FormatConditionRuleIconSet()
            Dim formatConditionIconSet1 As DevExpress.XtraEditors.FormatConditionIconSet = New DevExpress.XtraEditors.FormatConditionIconSet()
            Dim formatConditionIconSetIcon1 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon2 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon3 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim gridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleIconSet2 As DevExpress.XtraEditors.FormatConditionRuleIconSet = New DevExpress.XtraEditors.FormatConditionRuleIconSet()
            Dim formatConditionIconSet2 As DevExpress.XtraEditors.FormatConditionIconSet = New DevExpress.XtraEditors.FormatConditionIconSet()
            Dim formatConditionIconSetIcon4 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon5 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon6 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim gridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleIconSet3 As DevExpress.XtraEditors.FormatConditionRuleIconSet = New DevExpress.XtraEditors.FormatConditionRuleIconSet()
            Dim formatConditionIconSet3 As DevExpress.XtraEditors.FormatConditionIconSet = New DevExpress.XtraEditors.FormatConditionIconSet()
            Dim formatConditionIconSetIcon7 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon8 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon9 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim gridFormatRule4 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleDataBar1 As DevExpress.XtraEditors.FormatConditionRuleDataBar = New DevExpress.XtraEditors.FormatConditionRuleDataBar()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.ExcelFiltering))
            Me.bcDiscount = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.bcMPGCity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcMPGHighway = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcPrice = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.repositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.bandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
            Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.bcOrderID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.bcSalesDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.bcPhoto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcTrademark = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcModification = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.bcCylinders = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcTransmissionSpeeds = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcDoors = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcTransmissionType = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcTorque = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcHorsepower = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcBodyStyle = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.bcCategory = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.svgImages = New DevExpress.Utils.SvgImageCollection(Me.components)
            CType((Me.repositoryItemTextEdit4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTextEdit3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTextEdit2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.bandedGridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTextEdit5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImages), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' bcDiscount
            ' 
            Me.bcDiscount.ColumnEdit = Me.repositoryItemTextEdit4
            Me.bcDiscount.FieldName = "Discount"
            Me.bcDiscount.ImageOptions.ImageIndex = 1
            Me.bcDiscount.Name = "bcDiscount"
            Me.bcDiscount.Visible = True
            ' 
            ' repositoryItemTextEdit4
            ' 
            Me.repositoryItemTextEdit4.AutoHeight = False
            Me.repositoryItemTextEdit4.Mask.EditMask = "p"
            Me.repositoryItemTextEdit4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit4.Mask.UseMaskAsDisplayFormat = True
            Me.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4"
            ' 
            ' bcMPGCity
            ' 
            Me.bcMPGCity.Caption = "MPG <b>City"
            Me.bcMPGCity.FieldName = "MPGCity"
            Me.bcMPGCity.Name = "bcMPGCity"
            Me.bcMPGCity.Visible = True
            ' 
            ' bcMPGHighway
            ' 
            Me.bcMPGHighway.Caption = "MPG <b>Highway"
            Me.bcMPGHighway.FieldName = "MPGHighway"
            Me.bcMPGHighway.Name = "bcMPGHighway"
            Me.bcMPGHighway.Visible = True
            ' 
            ' bcPrice
            ' 
            Me.bcPrice.FieldName = "ModelPrice"
            Me.bcPrice.Name = "bcPrice"
            Me.bcPrice.Visible = True
            Me.bcPrice.Width = 150
            ' 
            ' repositoryItemTextEdit3
            ' 
            Me.repositoryItemTextEdit3.AutoHeight = False
            Me.repositoryItemTextEdit3.Mask.EditMask = "n"
            Me.repositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3"
            ' 
            ' repositoryItemTextEdit1
            ' 
            Me.repositoryItemTextEdit1.AutoHeight = False
            Me.repositoryItemTextEdit1.Mask.EditMask = "p"
            Me.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            ' 
            ' repositoryItemSpinEdit1
            ' 
            Me.repositoryItemSpinEdit1.AutoHeight = False
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            ' 
            ' repositoryItemTextEdit2
            ' 
            Me.repositoryItemTextEdit2.AutoHeight = False
            Me.repositoryItemTextEdit2.Mask.EditMask = "p0"
            Me.repositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = True
            Me.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2"
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.bandedGridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSpinEdit1, Me.repositoryItemTextEdit1, Me.repositoryItemTextEdit2, Me.repositoryItemTextEdit3, Me.repositoryItemTextEdit4, Me.repositoryItemTextEdit5})
            Me.gridControl1.Size = New System.Drawing.Size(944, 562)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.bandedGridView1})
            ' 
            ' bandedGridView1
            ' 
            Me.bandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand1, Me.gridBand2, Me.gridBand3})
            Me.bandedGridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.bandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.bcTrademark, Me.bcName, Me.bcModification, Me.bcCategory, Me.bcPrice, Me.bcMPGCity, Me.bcMPGHighway, Me.bcDoors, Me.bcBodyStyle, Me.bcCylinders, Me.bcHorsepower, Me.bcTorque, Me.bcTransmissionSpeeds, Me.bcTransmissionType, Me.bcPhoto, Me.bcSalesDate, Me.bcOrderID, Me.bcDiscount})
            gridFormatRule1.Column = Me.bcDiscount
            gridFormatRule1.Name = "Format0"
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
            gridFormatRule1.Rule = formatConditionRuleIconSet1
            gridFormatRule2.Column = Me.bcMPGCity
            gridFormatRule2.Name = "Format1"
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
            gridFormatRule2.Rule = formatConditionRuleIconSet2
            gridFormatRule3.Column = Me.bcMPGHighway
            gridFormatRule3.Name = "Format2"
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
            gridFormatRule3.Rule = formatConditionRuleIconSet3
            gridFormatRule4.Column = Me.bcPrice
            gridFormatRule4.Name = "Format3"
            formatConditionRuleDataBar1.AutomaticType = DevExpress.XtraEditors.FormatConditionAutomaticType.ZeroBased
            formatConditionRuleDataBar1.PredefinedName = "Mint"
            gridFormatRule4.Rule = formatConditionRuleDataBar1
            Me.bandedGridView1.FormatRules.Add(gridFormatRule1)
            Me.bandedGridView1.FormatRules.Add(gridFormatRule2)
            Me.bandedGridView1.FormatRules.Add(gridFormatRule3)
            Me.bandedGridView1.FormatRules.Add(gridFormatRule4)
            Me.bandedGridView1.GridControl = Me.gridControl1
            Me.bandedGridView1.Images = Me.svgImages
            Me.bandedGridView1.Name = "bandedGridView1"
            Me.bandedGridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
            Me.bandedGridView1.OptionsBehavior.AutoExpandAllGroups = True
            Me.bandedGridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.bandedGridView1.OptionsCustomization.AllowChangeColumnParent = True
            Me.bandedGridView1.OptionsCustomization.CustomizationFormSnapMode = DevExpress.Utils.Controls.SnapMode.OwnerControl
            Me.bandedGridView1.OptionsCustomization.ShowBandsInCustomizationForm = False
            Me.bandedGridView1.OptionsDetail.EnableMasterViewMode = False
            Me.bandedGridView1.OptionsFilter.FilterEditorAllowCustomExpressions = DevExpress.Utils.DefaultBoolean.[True]
            Me.bandedGridView1.OptionsMenu.ShowConditionalFormatFiltersItem = True
            Me.bandedGridView1.OptionsView.AllowHtmlDrawHeaders = True
            Me.bandedGridView1.OptionsView.FilterCriteriaDisplayStyle = DevExpress.XtraEditors.FilterCriteriaDisplayStyle.Visual
            Me.bandedGridView1.OptionsView.ShowGroupPanel = False
            AddHandler Me.bandedGridView1.FilterPopupExcelData, New DevExpress.XtraGrid.Views.Grid.FilterPopupExcelDataEventHandler(AddressOf Me.gridView_FilterPopupExcelData)
            ' 
            ' gridBand1
            ' 
            Me.gridBand1.Caption = "Order Info"
            Me.gridBand1.Columns.Add(Me.bcOrderID)
            Me.gridBand1.Columns.Add(Me.bcPrice)
            Me.gridBand1.Columns.Add(Me.bcDiscount)
            Me.gridBand1.Columns.Add(Me.bcSalesDate)
            Me.gridBand1.Name = "gridBand1"
            Me.gridBand1.VisibleIndex = 0
            Me.gridBand1.Width = 350
            ' 
            ' bcOrderID
            ' 
            Me.bcOrderID.Caption = "ID"
            Me.bcOrderID.ColumnEdit = Me.repositoryItemTextEdit5
            Me.bcOrderID.FieldName = "OrderID"
            Me.bcOrderID.Name = "bcOrderID"
            Me.bcOrderID.OptionsColumn.AllowEdit = False
            Me.bcOrderID.Visible = True
            Me.bcOrderID.Width = 50
            ' 
            ' repositoryItemTextEdit5
            ' 
            Me.repositoryItemTextEdit5.AutoHeight = False
            Me.repositoryItemTextEdit5.Mask.EditMask = "d5"
            Me.repositoryItemTextEdit5.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit5.Mask.UseMaskAsDisplayFormat = True
            Me.repositoryItemTextEdit5.Name = "repositoryItemTextEdit5"
            ' 
            ' bcSalesDate
            ' 
            Me.bcSalesDate.FieldName = "SalesDate"
            Me.bcSalesDate.Name = "bcSalesDate"
            Me.bcSalesDate.Visible = True
            ' 
            ' gridBand2
            ' 
            Me.gridBand2.Caption = "Model"
            Me.gridBand2.Columns.Add(Me.bcPhoto)
            Me.gridBand2.Columns.Add(Me.bcTrademark)
            Me.gridBand2.Columns.Add(Me.bcName)
            Me.gridBand2.Columns.Add(Me.bcModification)
            Me.gridBand2.Name = "gridBand2"
            Me.gridBand2.VisibleIndex = 1
            Me.gridBand2.Width = 360
            ' 
            ' bcPhoto
            ' 
            Me.bcPhoto.FieldName = "Photo"
            Me.bcPhoto.Name = "bcPhoto"
            Me.bcPhoto.OptionsFilter.AllowFilter = False
            Me.bcPhoto.Width = 64
            ' 
            ' bcTrademark
            ' 
            Me.bcTrademark.FieldName = "Trademark"
            Me.bcTrademark.Name = "bcTrademark"
            Me.bcTrademark.Visible = True
            Me.bcTrademark.Width = 100
            ' 
            ' bcName
            ' 
            Me.bcName.FieldName = "Name"
            Me.bcName.Name = "bcName"
            Me.bcName.Visible = True
            Me.bcName.Width = 100
            ' 
            ' bcModification
            ' 
            Me.bcModification.FieldName = "Modification"
            Me.bcModification.Name = "bcModification"
            Me.bcModification.Visible = True
            Me.bcModification.Width = 160
            ' 
            ' gridBand3
            ' 
            Me.gridBand3.Caption = "Performance"
            Me.gridBand3.Columns.Add(Me.bcMPGCity)
            Me.gridBand3.Columns.Add(Me.bcMPGHighway)
            Me.gridBand3.Columns.Add(Me.bcCylinders)
            Me.gridBand3.Columns.Add(Me.bcTransmissionSpeeds)
            Me.gridBand3.Columns.Add(Me.bcDoors)
            Me.gridBand3.Columns.Add(Me.bcTransmissionType)
            Me.gridBand3.Columns.Add(Me.bcTorque)
            Me.gridBand3.Columns.Add(Me.bcHorsepower)
            Me.gridBand3.Columns.Add(Me.bcBodyStyle)
            Me.gridBand3.Columns.Add(Me.bcCategory)
            Me.gridBand3.ImageOptions.ImageIndex = 0
            Me.gridBand3.Name = "gridBand3"
            Me.gridBand3.VisibleIndex = 2
            Me.gridBand3.Width = 210
            ' 
            ' bcCylinders
            ' 
            Me.bcCylinders.FieldName = "Cylinders"
            Me.bcCylinders.Name = "bcCylinders"
            Me.bcCylinders.Visible = True
            Me.bcCylinders.Width = 60
            ' 
            ' bcTransmissionSpeeds
            ' 
            Me.bcTransmissionSpeeds.FieldName = "TransmissionSpeeds"
            Me.bcTransmissionSpeeds.Name = "bcTransmissionSpeeds"
            ' 
            ' bcDoors
            ' 
            Me.bcDoors.FieldName = "Doors"
            Me.bcDoors.Name = "bcDoors"
            ' 
            ' bcTransmissionType
            ' 
            Me.bcTransmissionType.FieldName = "TransmissionType"
            Me.bcTransmissionType.Name = "bcTransmissionType"
            ' 
            ' bcTorque
            ' 
            Me.bcTorque.FieldName = "Torque"
            Me.bcTorque.Name = "bcTorque"
            Me.bcTorque.Width = 83
            ' 
            ' bcHorsepower
            ' 
            Me.bcHorsepower.FieldName = "Horsepower"
            Me.bcHorsepower.Name = "bcHorsepower"
            Me.bcHorsepower.Width = 71
            ' 
            ' bcBodyStyle
            ' 
            Me.bcBodyStyle.FieldName = "BodyStyle"
            Me.bcBodyStyle.Name = "bcBodyStyle"
            Me.bcBodyStyle.Width = 92
            ' 
            ' bcCategory
            ' 
            Me.bcCategory.FieldName = "Category"
            Me.bcCategory.Name = "bcCategory"
            Me.bcCategory.Width = 84
            ' 
            ' svgImages
            ' 
            Me.svgImages.Add("performance", CType((resources.GetObject("svgImages.performance")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImages.Add("Discount", CType((resources.GetObject("svgImages.Discount")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' ExcelFiltering
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "ExcelFiltering"
            Me.Size = New System.Drawing.Size(944, 562)
            CType((Me.repositoryItemTextEdit4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTextEdit3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTextEdit2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.bandedGridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTextEdit5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImages), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

        Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private repositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private repositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private bandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView

        Private bcTrademark As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bcName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bcModification As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bcCategory As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bcBodyStyle As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bcMPGCity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bcMPGHighway As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bcHorsepower As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bcTorque As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bcPhoto As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bcPrice As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bcDoors As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bcCylinders As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bcTransmissionSpeeds As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bcTransmissionType As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bcSalesDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bcOrderID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bcDiscount As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private repositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private repositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private svgImages As DevExpress.Utils.SvgImageCollection
    End Class
End Namespace
