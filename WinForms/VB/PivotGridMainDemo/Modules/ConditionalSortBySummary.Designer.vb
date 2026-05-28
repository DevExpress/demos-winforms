Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Partial Class ConditionalSortBySummary

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
            Dim pivotGridStyleFormatCondition1 As DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition = New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition()
            Dim pivotGridStyleFormatCondition2 As DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition = New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition()
            Dim pivotGridStyleFormatCondition3 As DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition = New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition()
            Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldDiscount = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.fieldMonth = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' fieldExtendedPrice
            ' 
            Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice.AreaIndex = 0
            Me.fieldExtendedPrice.Caption = "Order Amount"
            Me.fieldExtendedPrice.CellFormat.FormatString = "c"
            Me.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldExtendedPrice.FieldName = "Extended Price"
            Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
            ' 
            ' fieldQuantity
            ' 
            Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldQuantity.AreaIndex = 1
            Me.fieldQuantity.Caption = "Quantity"
            Me.fieldQuantity.FieldName = "Quantity"
            Me.fieldQuantity.Name = "fieldQuantity"
            ' 
            ' fieldDiscount
            ' 
            Me.fieldDiscount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldDiscount.AreaIndex = 2
            Me.fieldDiscount.Caption = "Discount (Avg)"
            Me.fieldDiscount.CellFormat.FormatString = "p"
            Me.fieldDiscount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldDiscount.FieldName = "Discount"
            Me.fieldDiscount.Name = "fieldDiscount"
            Me.fieldDiscount.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.pivotGridControl1.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldMonth, Me.fieldSalesPerson, Me.fieldExtendedPrice, Me.fieldYear, Me.fieldQuantity, Me.fieldDiscount})
            pivotGridStyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
            pivotGridStyleFormatCondition1.Appearance.Options.UseForeColor = True
            pivotGridStyleFormatCondition1.ApplyToCustomTotalCell = False
            pivotGridStyleFormatCondition1.ApplyToGrandTotalCell = False
            pivotGridStyleFormatCondition1.ApplyToTotalCell = False
            pivotGridStyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
            pivotGridStyleFormatCondition1.Field = Me.fieldExtendedPrice
            pivotGridStyleFormatCondition1.FieldName = "fieldExtendedPrice"
            pivotGridStyleFormatCondition1.Value1 = 10000
            pivotGridStyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Blue
            pivotGridStyleFormatCondition2.Appearance.Options.UseForeColor = True
            pivotGridStyleFormatCondition2.ApplyToCustomTotalCell = False
            pivotGridStyleFormatCondition2.ApplyToGrandTotalCell = False
            pivotGridStyleFormatCondition2.ApplyToTotalCell = False
            pivotGridStyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
            pivotGridStyleFormatCondition2.Field = Me.fieldQuantity
            pivotGridStyleFormatCondition2.FieldName = "fieldQuantity"
            pivotGridStyleFormatCondition2.Value1 = 350
            pivotGridStyleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Green
            pivotGridStyleFormatCondition3.Appearance.Options.UseForeColor = True
            pivotGridStyleFormatCondition3.ApplyToCustomTotalCell = False
            pivotGridStyleFormatCondition3.ApplyToGrandTotalCell = False
            pivotGridStyleFormatCondition3.ApplyToTotalCell = False
            pivotGridStyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
            pivotGridStyleFormatCondition3.Field = Me.fieldDiscount
            pivotGridStyleFormatCondition3.FieldName = "fieldDiscount"
            pivotGridStyleFormatCondition3.Value1 = 0.1F
            Me.pivotGridControl1.FormatConditions.AddRange(New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition() {pivotGridStyleFormatCondition1, pivotGridStyleFormatCondition2, pivotGridStyleFormatCondition3})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.Size = New System.Drawing.Size(707, 416)
            Me.pivotGridControl1.TabIndex = 14
            ' 
            ' fieldMonth
            ' 
            Me.fieldMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldMonth.AreaIndex = 1
            Me.fieldMonth.Caption = "Order Month"
            Me.fieldMonth.FieldName = "OrderDate"
            Me.fieldMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
            Me.fieldMonth.Name = "fieldMonth"
            Me.fieldMonth.UnboundFieldName = "fieldQuarter"
            Me.fieldMonth.Width = 120
            ' 
            ' fieldSalesPerson
            ' 
            Me.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldSalesPerson.AreaIndex = 0
            Me.fieldSalesPerson.FieldName = "Sales Person"
            Me.fieldSalesPerson.Name = "fieldSalesPerson"
            Me.fieldSalesPerson.SortBySummaryInfo.Field = Me.fieldExtendedPrice
            Me.fieldSalesPerson.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
            Me.fieldSalesPerson.Width = 150
            ' 
            ' fieldYear
            ' 
            Me.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldYear.AreaIndex = 0
            Me.fieldYear.Caption = "Order Year"
            Me.fieldYear.FieldName = "OrderDate"
            Me.fieldYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldYear.Name = "fieldYear"
            Me.fieldYear.Options.AllowSortBySummary = DevExpress.Utils.DefaultBoolean.[False]
            Me.fieldYear.UnboundFieldName = "fieldYear"
            ' 
            ' ConditionalSortBySummary
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "ConditionalSortBySummary"
            Me.Size = New System.Drawing.Size(707, 416)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.ConditionalSortBySummary_Load)
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

        Private fieldMonth As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldSalesPerson As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldYear As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldQuantity As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldDiscount As DevExpress.XtraPivotGrid.PivotGridField
    End Class
End Namespace
