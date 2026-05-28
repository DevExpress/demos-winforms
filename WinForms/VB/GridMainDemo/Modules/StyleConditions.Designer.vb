Namespace DevExpress.XtraGrid.Demos

    Partial Class StyleConditions

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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.StyleConditions))
            Dim gridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleExpression1 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
            Dim gridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleExpression2 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
            Dim gridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleExpression3 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
            Dim gridFormatRule4 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleExpression4 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
            Me.gcQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemSpinEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.gcTotal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.sidePanel = New DevExpress.XtraEditors.SidePanel()
            Me.expressionConditionsEditor1 = New DevExpress.XtraGrid.Demos.ExpressionConditionsEditor()
            Me.gcProducts = New DevExpress.XtraGrid.GridControl()
            Me.gvProducts = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gcOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gcProduct = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.gcUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
            Me.gcDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            CType((Me.repositoryItemSpinEdit3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel.SuspendLayout()
            CType((Me.gcProducts), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gvProducts), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemLookUpEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemCalcEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gcQuantity
            ' 
            resources.ApplyResources(Me.gcQuantity, "gcQuantity")
            Me.gcQuantity.ColumnEdit = Me.repositoryItemSpinEdit3
            Me.gcQuantity.FieldName = "Quantity"
            Me.gcQuantity.ImageOptions.ImageIndex =(CInt((resources.GetObject("gcQuantity.ImageOptions.ImageIndex"))))
            Me.gcQuantity.Name = "gcQuantity"
            ' 
            ' repositoryItemSpinEdit3
            ' 
            resources.ApplyResources(Me.repositoryItemSpinEdit3, "repositoryItemSpinEdit3")
            Me.repositoryItemSpinEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit3.IsFloatValue = False
            Me.repositoryItemSpinEdit3.Mask.EditMask = resources.GetString("repositoryItemSpinEdit3.Mask.EditMask")
            Me.repositoryItemSpinEdit3.Name = "repositoryItemSpinEdit3"
            ' 
            ' gcTotal
            ' 
            resources.ApplyResources(Me.gcTotal, "gcTotal")
            Me.gcTotal.DisplayFormat.FormatString = "c"
            Me.gcTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gcTotal.FieldName = "Total"
            Me.gcTotal.ImageOptions.ImageIndex =(CInt((resources.GetObject("gcTotal.ImageOptions.ImageIndex"))))
            Me.gcTotal.Name = "gcTotal"
            Me.gcTotal.OptionsColumn.[ReadOnly] = True
            Me.gcTotal.ShowUnboundExpressionMenu = True
            Me.gcTotal.UnboundDataType = GetType(Decimal)
            Me.gcTotal.UnboundExpression = "([UnitPrice] * [Quantity]) * (1 - [Discount])"
            ' 
            ' sidePanel
            ' 
            Me.sidePanel.Controls.Add(Me.expressionConditionsEditor1)
            resources.ApplyResources(Me.sidePanel, "sidePanel")
            Me.sidePanel.Name = "sidePanel"
            ' 
            ' expressionConditionsEditor1
            ' 
            resources.ApplyResources(Me.expressionConditionsEditor1, "expressionConditionsEditor1")
            Me.expressionConditionsEditor1.Name = "expressionConditionsEditor1"
            ' 
            ' gcProducts
            ' 
            Me.gcProducts.Cursor = System.Windows.Forms.Cursors.[Default]
            resources.ApplyResources(Me.gcProducts, "gcProducts")
            Me.gcProducts.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
            Me.gcProducts.EmbeddedNavigator.Buttons.EndEdit.Visible = False
            Me.gcProducts.MainView = Me.gvProducts
            Me.gcProducts.Name = "gcProducts"
            Me.gcProducts.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemLookUpEdit1, Me.repositoryItemCalcEdit1, Me.repositoryItemSpinEdit3, Me.repositoryItemTextEdit1})
            Me.gcProducts.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvProducts})
            ' 
            ' gvProducts
            ' 
            Me.gvProducts.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gvProducts.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcOrderID, Me.gcProduct, Me.gcUnitPrice, Me.gcQuantity, Me.gcDiscount, Me.gcTotal})
            Me.gvProducts.CustomizationFormBounds = New System.Drawing.Rectangle(763, 281, 260, 252)
            gridFormatRule1.ApplyToRow = True
            gridFormatRule1.Column = Me.gcQuantity
            gridFormatRule1.Name = "Format0"
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.PaleGreen
            formatConditionRuleExpression1.Appearance.ForeColor = System.Drawing.Color.Black
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = True
            formatConditionRuleExpression1.Appearance.Options.UseForeColor = True
            formatConditionRuleExpression1.Expression = "[Quantity] >= 20 And [Discount] != 0"
            gridFormatRule1.Rule = formatConditionRuleExpression1
            gridFormatRule2.ApplyToRow = True
            gridFormatRule2.Column = Me.gcQuantity
            gridFormatRule2.Name = "Format1"
            formatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.LightPink
            formatConditionRuleExpression2.Appearance.ForeColor = System.Drawing.Color.Maroon
            formatConditionRuleExpression2.Appearance.Options.UseBackColor = True
            formatConditionRuleExpression2.Appearance.Options.UseForeColor = True
            formatConditionRuleExpression2.Expression = "[Quantity] <= 20 AND [Total] < 100"
            gridFormatRule2.Rule = formatConditionRuleExpression2
            gridFormatRule3.Column = Me.gcTotal
            gridFormatRule3.Name = "Format2"
            formatConditionRuleExpression3.Appearance.Font = CType((resources.GetObject("resource.Font")), System.Drawing.Font)
            formatConditionRuleExpression3.Appearance.Options.UseFont = True
            formatConditionRuleExpression3.Expression = "[Total] >= 500"
            gridFormatRule3.Rule = formatConditionRuleExpression3
            gridFormatRule4.ApplyToRow = True
            gridFormatRule4.Column = Me.gcTotal
            gridFormatRule4.Name = "Format3"
            formatConditionRuleExpression4.Appearance.Font = CType((resources.GetObject("resource.Font1")), System.Drawing.Font)
            formatConditionRuleExpression4.Appearance.ForeColor = System.Drawing.Color.Gray
            formatConditionRuleExpression4.Appearance.Options.UseFont = True
            formatConditionRuleExpression4.Appearance.Options.UseForeColor = True
            formatConditionRuleExpression4.Expression = "[Total] < 50 And [Discount] != 0"
            gridFormatRule4.Rule = formatConditionRuleExpression4
            Me.gvProducts.FormatRules.Add(gridFormatRule1)
            Me.gvProducts.FormatRules.Add(gridFormatRule2)
            Me.gvProducts.FormatRules.Add(gridFormatRule3)
            Me.gvProducts.FormatRules.Add(gridFormatRule4)
            Me.gvProducts.GridControl = Me.gcProducts
            Me.gvProducts.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("gvProducts.GroupSummary")), DevExpress.Data.SummaryItemType), resources.GetString("gvProducts.GroupSummary1"), CType((resources.GetObject("gvProducts.GroupSummary2")), DevExpress.XtraGrid.Columns.GridColumn), resources.GetString("gvProducts.GroupSummary3"))})
            Me.gvProducts.Images = Me.svgImageCollection1
            Me.gvProducts.Name = "gvProducts"
            Me.gvProducts.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gvProducts.OptionsView.AllowHtmlDrawHeaders = True
            Me.gvProducts.OptionsView.ShowGroupPanel = False
            Me.gvProducts.OptionsView.ShowIndicator = False
            ' 
            ' gcOrderID
            ' 
            Me.gcOrderID.FieldName = "OrderID"
            Me.gcOrderID.ImageOptions.ImageIndex =(CInt((resources.GetObject("gcOrderID.ImageOptions.ImageIndex"))))
            Me.gcOrderID.Name = "gcOrderID"
            resources.ApplyResources(Me.gcOrderID, "gcOrderID")
            ' 
            ' gcProduct
            ' 
            resources.ApplyResources(Me.gcProduct, "gcProduct")
            Me.gcProduct.ColumnEdit = Me.repositoryItemLookUpEdit1
            Me.gcProduct.FieldName = "ProductID"
            Me.gcProduct.ImageOptions.ImageIndex =(CInt((resources.GetObject("gcProduct.ImageOptions.ImageIndex"))))
            Me.gcProduct.Name = "gcProduct"
            ' 
            ' repositoryItemLookUpEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemLookUpEdit1, "repositoryItemLookUpEdit1")
            Me.repositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemLookUpEdit1.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("repositoryItemLookUpEdit1.Columns"), resources.GetString("repositoryItemLookUpEdit1.Columns1"))})
            Me.repositoryItemLookUpEdit1.DisplayMember = "ProductName"
            Me.repositoryItemLookUpEdit1.DropDownRows = 10
            Me.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1"
            Me.repositoryItemLookUpEdit1.PopupWidth = 220
            Me.repositoryItemLookUpEdit1.ValueMember = "ProductID"
            ' 
            ' gcUnitPrice
            ' 
            Me.gcUnitPrice.ColumnEdit = Me.repositoryItemCalcEdit1
            Me.gcUnitPrice.DisplayFormat.FormatString = "c"
            Me.gcUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gcUnitPrice.FieldName = "UnitPrice"
            Me.gcUnitPrice.ImageOptions.ImageIndex =(CInt((resources.GetObject("gcUnitPrice.ImageOptions.ImageIndex"))))
            Me.gcUnitPrice.Name = "gcUnitPrice"
            resources.ApplyResources(Me.gcUnitPrice, "gcUnitPrice")
            ' 
            ' repositoryItemCalcEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemCalcEdit1, "repositoryItemCalcEdit1")
            Me.repositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemCalcEdit1.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemCalcEdit1.Mask.EditMask = resources.GetString("repositoryItemCalcEdit1.Mask.EditMask")
            Me.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1"
            ' 
            ' gcDiscount
            ' 
            resources.ApplyResources(Me.gcDiscount, "gcDiscount")
            Me.gcDiscount.ColumnEdit = Me.repositoryItemTextEdit1
            Me.gcDiscount.DisplayFormat.FormatString = "p"
            Me.gcDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gcDiscount.FieldName = "Discount"
            Me.gcDiscount.ImageOptions.ImageIndex =(CInt((resources.GetObject("gcDiscount.ImageOptions.ImageIndex"))))
            Me.gcDiscount.Name = "gcDiscount"
            ' 
            ' repositoryItemTextEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemTextEdit1, "repositoryItemTextEdit1")
            Me.repositoryItemTextEdit1.Mask.EditMask = resources.GetString("repositoryItemTextEdit1.Mask.EditMask")
            Me.repositoryItemTextEdit1.Mask.MaskType = CType((resources.GetObject("repositoryItemTextEdit1.Mask.MaskType")), DevExpress.XtraEditors.Mask.MaskType)
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("Discount", CType((resources.GetObject("svgImageCollection1.Discount")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Sales", CType((resources.GetObject("svgImageCollection1.Sales")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("UnitPrice", CType((resources.GetObject("svgImageCollection1.UnitPrice")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Product", CType((resources.GetObject("svgImageCollection1.Product")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Quantity", CType((resources.GetObject("svgImageCollection1.Quantity")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("order_id", CType((resources.GetObject("svgImageCollection1.order_id")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' StyleConditions
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gcProducts)
            Me.Controls.Add(Me.sidePanel)
            Me.Name = "StyleConditions"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.StyleConditions_Load)
            CType((Me.repositoryItemSpinEdit3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel.ResumeLayout(False)
            CType((Me.gcProducts), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gvProducts), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemLookUpEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemCalcEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer = Nothing

        Private gcProducts As DevExpress.XtraGrid.GridControl

        Private gvProducts As DevExpress.XtraGrid.Views.Grid.GridView

        Private gcOrderID As DevExpress.XtraGrid.Columns.GridColumn

        Private gcProduct As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

        Private gcUnitPrice As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit

        Private gcQuantity As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemSpinEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

        Private gcDiscount As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private gcTotal As DevExpress.XtraGrid.Columns.GridColumn

        Private expressionConditionsEditor1 As DevExpress.XtraGrid.Demos.ExpressionConditionsEditor

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection

        Private sidePanel As DevExpress.XtraEditors.SidePanel
    End Class
End Namespace
