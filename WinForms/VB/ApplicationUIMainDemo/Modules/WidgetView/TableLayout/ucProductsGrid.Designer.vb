Namespace DevExpress.ApplicationUI.Demos

    Partial Class ucProductsGrid

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim styleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
            Dim styleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
            Dim styleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
            Dim styleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
            Me.RevenueYTDvsTarget = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.totalSalesItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProduct = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRevenueYTD = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitsSoldYTD = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRevenueYTDTarget = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitsSoldYTDTarget = New DevExpress.XtraGrid.Columns.GridColumn()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.totalSalesItemBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' RevenueYTDvsTarget
            ' 
            Me.RevenueYTDvsTarget.Caption = "Revenue YTD vs Target"
            Me.RevenueYTDvsTarget.DisplayFormat.FormatString = "P1"
            Me.RevenueYTDvsTarget.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            Me.RevenueYTDvsTarget.FieldName = "Revenue YTD vs Target"
            Me.RevenueYTDvsTarget.Name = "RevenueYTDvsTarget"
            Me.RevenueYTDvsTarget.UnboundExpression = "([RevenueYTD] - [RevenueYTDTarget]) / ([RevenueYTDTarget])"
            Me.RevenueYTDvsTarget.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
            Me.RevenueYTDvsTarget.Visible = True
            Me.RevenueYTDvsTarget.VisibleIndex = 3
            ' 
            ' gridColumn2
            ' 
            Me.gridColumn2.Caption = "Units Sold YTD vs Target"
            Me.gridColumn2.FieldName = "unitsSoldYTDvsTarget"
            Me.gridColumn2.Name = "gridColumn2"
            Me.gridColumn2.UnboundExpression = "([UnitsSoldYTD] - [UnitsSoldYTDTarget])"
            Me.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
            Me.gridColumn2.Visible = True
            Me.gridColumn2.VisibleIndex = 5
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.totalSalesItemBindingSource
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(776, 351)
            Me.gridControl1.TabIndex = 1
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' totalSalesItemBindingSource
            ' 
            Me.totalSalesItemBindingSource.DataSource = GetType(DevExpress.ApplicationUI.Demos.SalesPerformanceDataGenerator.TotalSalesItem)
            ' 
            ' gridView1
            ' 
            Me.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCategory, Me.colProduct, Me.colRevenueYTD, Me.RevenueYTDvsTarget, Me.colUnitsSoldYTD, Me.gridColumn2, Me.colRevenueYTDTarget, Me.colUnitsSoldYTDTarget})
            Me.gridView1.FixedLineWidth = 1
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((63)))))), (CInt(((CByte((136)))))), (CInt(((CByte((48)))))))
            styleFormatCondition1.Appearance.Options.UseForeColor = True
            styleFormatCondition1.Column = Me.RevenueYTDvsTarget
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
            styleFormatCondition1.Expression = "[Revenue YTD vs Target] >= 0"
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((214)))))), (CInt(((CByte((5)))))), (CInt(((CByte((5)))))))
            styleFormatCondition2.Appearance.Options.UseForeColor = True
            styleFormatCondition2.Column = Me.RevenueYTDvsTarget
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
            styleFormatCondition2.Expression = "[Revenue YTD vs Target] < 0"
            styleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((214)))))), (CInt(((CByte((5)))))), (CInt(((CByte((5)))))))
            styleFormatCondition3.Appearance.Options.UseForeColor = True
            styleFormatCondition3.Column = Me.gridColumn2
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
            styleFormatCondition3.Expression = "[unitsSoldYTDvsTarget] < 0"
            styleFormatCondition4.Appearance.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((63)))))), (CInt(((CByte((136)))))), (CInt(((CByte((48)))))))
            styleFormatCondition4.Appearance.Options.UseForeColor = True
            styleFormatCondition4.Column = Me.gridColumn2
            styleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
            styleFormatCondition4.Expression = "[unitsSoldYTDvsTarget] >= 0"
            Me.gridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {styleFormatCondition1, styleFormatCondition2, styleFormatCondition3, styleFormatCondition4})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView1.OptionsView.AllowCellMerge = True
            Me.gridView1.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office
            Me.gridView1.OptionsView.ShowGroupPanel = False
            Me.gridView1.OptionsView.ShowIndicator = False
            Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCategory, DevExpress.Data.ColumnSortOrder.Ascending)})
            ' 
            ' colCategory
            ' 
            Me.colCategory.FieldName = "Category"
            Me.colCategory.Name = "colCategory"
            Me.colCategory.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[True]
            Me.colCategory.Visible = True
            Me.colCategory.VisibleIndex = 0
            ' 
            ' colProduct
            ' 
            Me.colProduct.FieldName = "Product"
            Me.colProduct.Name = "colProduct"
            Me.colProduct.Visible = True
            Me.colProduct.VisibleIndex = 1
            ' 
            ' colRevenueYTD
            ' 
            Me.colRevenueYTD.DisplayFormat.FormatString = "C2"
            Me.colRevenueYTD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            Me.colRevenueYTD.FieldName = "RevenueYTD"
            Me.colRevenueYTD.Name = "colRevenueYTD"
            Me.colRevenueYTD.Visible = True
            Me.colRevenueYTD.VisibleIndex = 2
            ' 
            ' colUnitsSoldYTD
            ' 
            Me.colUnitsSoldYTD.FieldName = "UnitsSoldYTD"
            Me.colUnitsSoldYTD.Name = "colUnitsSoldYTD"
            Me.colUnitsSoldYTD.Visible = True
            Me.colUnitsSoldYTD.VisibleIndex = 4
            ' 
            ' colRevenueYTDTarget
            ' 
            Me.colRevenueYTDTarget.FieldName = "RevenueYTDTarget"
            Me.colRevenueYTDTarget.Name = "colRevenueYTDTarget"
            ' 
            ' colUnitsSoldYTDTarget
            ' 
            Me.colUnitsSoldYTDTarget.FieldName = "UnitsSoldYTDTarget"
            Me.colUnitsSoldYTDTarget.Name = "colUnitsSoldYTDTarget"
            ' 
            ' ucProductsGrid
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "ucProductsGrid"
            Me.Size = New System.Drawing.Size(776, 351)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.totalSalesItemBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Protected gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private colCategory As DevExpress.XtraGrid.Columns.GridColumn

        Private colProduct As DevExpress.XtraGrid.Columns.GridColumn

        Private colRevenueYTD As DevExpress.XtraGrid.Columns.GridColumn

        Private colUnitsSoldYTD As DevExpress.XtraGrid.Columns.GridColumn

        Private RevenueYTDvsTarget As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn

        Private colRevenueYTDTarget As DevExpress.XtraGrid.Columns.GridColumn

        Private colUnitsSoldYTDTarget As DevExpress.XtraGrid.Columns.GridColumn

        Private totalSalesItemBindingSource As System.Windows.Forms.BindingSource
    End Class
End Namespace
