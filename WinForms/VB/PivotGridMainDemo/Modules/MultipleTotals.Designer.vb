Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Partial Class MultipleTotals

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim pivotGridGroup1 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
            Dim pivotGridGroup2 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
            Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.dsSalesPerson1 = New DevExpress.XtraPivotGrid.Demos.dsSalesPerson()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
            CType((Me.dsSalesPerson1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' fieldYear
            ' 
            Me.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldYear.AreaIndex = 0
            Me.fieldYear.Caption = "Year"
            Me.fieldYear.FieldName = "OrderDate"
            Me.fieldYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldYear.Name = "fieldYear"
            Me.fieldYear.UnboundFieldName = "fieldYear"
            ' 
            ' fieldQuarter
            ' 
            Me.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldQuarter.AreaIndex = 1
            Me.fieldQuarter.Caption = "Quarter"
            Me.fieldQuarter.FieldName = "OrderDate"
            Me.fieldQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
            Me.fieldQuarter.Name = "fieldQuarter"
            Me.fieldQuarter.TotalValueFormat.FormatString = "Quarter {0} Total"
            Me.fieldQuarter.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldQuarter.UnboundFieldName = "fieldQuarter"
            Me.fieldQuarter.ValueFormat.FormatString = "Quarter {0}"
            Me.fieldQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            ' 
            ' fieldQuantity
            ' 
            Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldQuantity.AreaIndex = 0
            Me.fieldQuantity.Caption = "Quantity"
            Me.fieldQuantity.CellFormat.FormatString = "#.##"
            Me.fieldQuantity.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldQuantity.FieldName = "Quantity"
            Me.fieldQuantity.Name = "fieldQuantity"
            Me.fieldQuantity.ValueFormat.FormatString = "#.##"
            Me.fieldQuantity.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            ' 
            ' fieldExtendedPrice
            ' 
            Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice.AreaIndex = 1
            Me.fieldExtendedPrice.Caption = "Extended Price"
            Me.fieldExtendedPrice.CellFormat.FormatString = "c"
            Me.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldExtendedPrice.FieldName = "Extended Price"
            Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
            Me.fieldExtendedPrice.ValueFormat.FormatString = "c"
            Me.fieldExtendedPrice.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            ' 
            ' dsSalesPerson1
            ' 
            Me.dsSalesPerson1.DataSetName = "dsSalesPerson"
            Me.dsSalesPerson1.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dsSalesPerson1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.ActiveFilterString = ""
            Me.pivotGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.pivotGridControl1.DataSource = Me.dsSalesPerson1.SalesPerson
            Me.pivotGridControl1.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldYear, Me.fieldCategoryName, Me.fieldProductName, Me.fieldQuarter, Me.fieldQuantity, Me.fieldExtendedPrice})
            pivotGridGroup1.Fields.Add(Me.fieldYear)
            pivotGridGroup1.Fields.Add(Me.fieldQuarter)
            pivotGridGroup1.Hierarchy = Nothing
            pivotGridGroup1.ShowNewValues = True
            pivotGridGroup2.Fields.Add(Me.fieldQuantity)
            pivotGridGroup2.Fields.Add(Me.fieldExtendedPrice)
            pivotGridGroup2.Hierarchy = Nothing
            pivotGridGroup2.ShowNewValues = True
            Me.pivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() {pivotGridGroup1, pivotGridGroup2})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsView.ShowColumnGrandTotals = False
            Me.pivotGridControl1.OptionsView.ShowFilterHeaders = False
            Me.pivotGridControl1.Size = New System.Drawing.Size(705, 416)
            Me.pivotGridControl1.TabIndex = 0
            AddHandler Me.pivotGridControl1.FieldValueImageIndex, New DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(AddressOf Me.pivotGridControl1_FieldValueImageIndex)
            ' 
            ' fieldCategoryName
            ' 
            Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCategoryName.AreaIndex = 0
            Me.fieldCategoryName.Caption = "Category Name"
            Me.fieldCategoryName.FieldName = "CategoryName"
            Me.fieldCategoryName.Name = "fieldCategoryName"
            Me.fieldCategoryName.Width = 129
            ' 
            ' fieldProductName
            ' 
            Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProductName.AreaIndex = 1
            Me.fieldProductName.Caption = "Product Name"
            Me.fieldProductName.FieldName = "ProductName"
            Me.fieldProductName.Name = "fieldProductName"
            Me.fieldProductName.Width = 153
            ' 
            ' MultipleTotals
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "MultipleTotals"
            Me.Size = New System.Drawing.Size(705, 416)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.MultipleTotals_Load)
            CType((Me.dsSalesPerson1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private dsSalesPerson1 As DevExpress.XtraPivotGrid.Demos.dsSalesPerson

        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

        Private fieldYear As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldCategoryName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldQuarter As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldQuantity As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField

        Private components As System.ComponentModel.IContainer = Nothing
    End Class
End Namespace
