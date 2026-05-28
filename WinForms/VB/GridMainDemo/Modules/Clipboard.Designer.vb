Namespace DevExpress.XtraGrid.Demos

    Partial Class ClipboardTutorial

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
            Dim gridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
            Dim gridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
            Dim gridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRule3ColorScale1 As DevExpress.XtraEditors.FormatConditionRule3ColorScale = New DevExpress.XtraEditors.FormatConditionRule3ColorScale()
            Dim gridFormatRule4 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleTopBottom1 As DevExpress.XtraEditors.FormatConditionRuleTopBottom = New DevExpress.XtraEditors.FormatConditionRuleTopBottom()
            Me.colSalesVsTarget = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.colMarketShare = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.colProfit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.colState = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSales = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCustomersSatisfaction = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.gridControl1 = New DevExpress.XtraGrid.Demos.ClipboardGridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.webBrowser1 = New System.Windows.Forms.WebBrowser()
            Me.propertyGridControl = New DevExpress.XtraVerticalGrid.PropertyGridControl()
            Me.simpleButtonCopyPaste = New DevExpress.XtraEditors.SimpleButton()
            Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl()
            Me.spreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.richEditLCI = New DevExpress.XtraLayout.LayoutControlItem()
            Me.copyPasteButtonLCI = New DevExpress.XtraLayout.LayoutControlItem()
            Me.gridViewPropertiesLayoutGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            Me.webBrowserLCI = New DevExpress.XtraLayout.LayoutControlItem()
            Me.gridControlLCI = New DevExpress.XtraLayout.LayoutControlItem()
            Me.splitterItemGrid = New DevExpress.XtraLayout.SplitterItem()
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTextEdit2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTextEdit3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.propertyGridControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.richEditLCI), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.copyPasteButtonLCI), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridViewPropertiesLayoutGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.splitterItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.webBrowserLCI), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControlLCI), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.splitterItemGrid), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' colSalesVsTarget
            ' 
            Me.colSalesVsTarget.ColumnEdit = Me.repositoryItemTextEdit1
            Me.colSalesVsTarget.FieldName = "SalesVsTarget"
            Me.colSalesVsTarget.Name = "colSalesVsTarget"
            Me.colSalesVsTarget.Visible = True
            Me.colSalesVsTarget.VisibleIndex = 2
            Me.colSalesVsTarget.Width = 105
            ' 
            ' repositoryItemTextEdit1
            ' 
            Me.repositoryItemTextEdit1.AutoHeight = False
            Me.repositoryItemTextEdit1.Mask.EditMask = "p"
            Me.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            ' 
            ' colMarketShare
            ' 
            Me.colMarketShare.ColumnEdit = Me.repositoryItemTextEdit2
            Me.colMarketShare.FieldName = "MarketShare"
            Me.colMarketShare.Name = "colMarketShare"
            Me.colMarketShare.Visible = True
            Me.colMarketShare.VisibleIndex = 5
            Me.colMarketShare.Width = 134
            ' 
            ' repositoryItemTextEdit2
            ' 
            Me.repositoryItemTextEdit2.AutoHeight = False
            Me.repositoryItemTextEdit2.Mask.EditMask = "p0"
            Me.repositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = True
            Me.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2"
            ' 
            ' colProfit
            ' 
            Me.colProfit.ColumnEdit = Me.repositoryItemTextEdit3
            Me.colProfit.DisplayFormat.FormatString = "#,##0,,M"
            Me.colProfit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colProfit.FieldName = "Profit"
            Me.colProfit.Name = "colProfit"
            Me.colProfit.Visible = True
            Me.colProfit.VisibleIndex = 3
            Me.colProfit.Width = 204
            ' 
            ' repositoryItemTextEdit3
            ' 
            Me.repositoryItemTextEdit3.AutoHeight = False
            Me.repositoryItemTextEdit3.Mask.EditMask = "n"
            Me.repositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3"
            ' 
            ' colState
            ' 
            Me.colState.FieldName = "State"
            Me.colState.Name = "colState"
            Me.colState.Visible = True
            Me.colState.VisibleIndex = 0
            Me.colState.Width = 151
            ' 
            ' colSales
            ' 
            Me.colSales.ColumnEdit = Me.repositoryItemTextEdit3
            Me.colSales.DisplayFormat.FormatString = "#,##0,,M"
            Me.colSales.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colSales.FieldName = "Sales"
            Me.colSales.Name = "colSales"
            Me.colSales.Visible = True
            Me.colSales.VisibleIndex = 1
            Me.colSales.Width = 184
            ' 
            ' colCustomersSatisfaction
            ' 
            Me.colCustomersSatisfaction.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.colCustomersSatisfaction.FieldName = "CustomersSatisfaction"
            Me.colCustomersSatisfaction.Name = "colCustomersSatisfaction"
            Me.colCustomersSatisfaction.Visible = True
            Me.colCustomersSatisfaction.VisibleIndex = 4
            Me.colCustomersSatisfaction.Width = 132
            ' 
            ' repositoryItemSpinEdit1
            ' 
            Me.repositoryItemSpinEdit1.AutoHeight = False
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.gridControl1.Location = New System.Drawing.Point(2, 28)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSpinEdit1, Me.repositoryItemTextEdit1, Me.repositoryItemTextEdit2, Me.repositoryItemTextEdit3})
            Me.gridControl1.Size = New System.Drawing.Size(445, 532)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colState, Me.colSales, Me.colProfit, Me.colSalesVsTarget, Me.colMarketShare, Me.colCustomersSatisfaction})
            Me.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
            gridFormatRule1.Column = Me.colSalesVsTarget
            gridFormatRule1.Name = "SalesFormat"
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((192)))))), (CInt(((CByte((255)))))), (CInt(((CByte((192)))))))
            formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.Green
            formatConditionRuleValue1.Appearance.Options.UseBackColor = True
            formatConditionRuleValue1.Appearance.Options.UseForeColor = True
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Greater
            formatConditionRuleValue1.Value1 = "0"
            gridFormatRule1.Rule = formatConditionRuleValue1
            gridFormatRule2.Column = Me.colSalesVsTarget
            gridFormatRule2.Name = "Sales vs Target Less then zero"
            formatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((192)))))), (CInt(((CByte((192)))))))
            formatConditionRuleValue2.Appearance.ForeColor = System.Drawing.Color.Red
            formatConditionRuleValue2.Appearance.Options.UseBackColor = True
            formatConditionRuleValue2.Appearance.Options.UseForeColor = True
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Less
            formatConditionRuleValue2.Value1 = "0"
            gridFormatRule2.Rule = formatConditionRuleValue2
            gridFormatRule3.Column = Me.colMarketShare
            gridFormatRule3.Name = "MarketShare"
            formatConditionRule3ColorScale1.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
            formatConditionRule3ColorScale1.MaximumColor = System.Drawing.Color.FromArgb((CInt(((CByte((128)))))), (CInt(((CByte((255)))))), (CInt(((CByte((128)))))))
            formatConditionRule3ColorScale1.Middle = New Decimal(New Integer() {66, 0, 0, 0})
            formatConditionRule3ColorScale1.MiddleColor = System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((255)))))), (CInt(((CByte((128)))))))
            formatConditionRule3ColorScale1.Minimum = New Decimal(New Integer() {33, 0, 0, 0})
            formatConditionRule3ColorScale1.MinimumColor = System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((128)))))), (CInt(((CByte((128)))))))
            gridFormatRule3.Rule = formatConditionRule3ColorScale1
            gridFormatRule4.ApplyToRow = True
            gridFormatRule4.Column = Me.colProfit
            gridFormatRule4.Name = "ProfitFormat"
            formatConditionRuleTopBottom1.PredefinedName = "Bold Text"
            formatConditionRuleTopBottom1.Rank = New Decimal(New Integer() {6, 0, 0, 0})
            gridFormatRule4.Rule = formatConditionRuleTopBottom1
            Me.gridView1.FormatRules.Add(gridFormatRule1)
            Me.gridView1.FormatRules.Add(gridFormatRule2)
            Me.gridView1.FormatRules.Add(gridFormatRule3)
            Me.gridView1.FormatRules.Add(gridFormatRule4)
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsClipboard.AllowHtmlFormat = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView1.OptionsClipboard.CopyCollapsedData = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView1.OptionsClipboard.PasteMode = DevExpress.Export.PasteMode.Append
            Me.gridView1.OptionsMenu.ShowConditionalFormattingItem = True
            Me.gridView1.OptionsSelection.MultiSelect = True
            Me.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
            Me.gridView1.OptionsView.EnableAppearanceOddRow = True
            Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colMarketShare, DevExpress.Data.ColumnSortOrder.Ascending)})
            AddHandler Me.gridView1.ShowingEditor, New System.ComponentModel.CancelEventHandler(AddressOf Me.gridView1_ShowingEditor)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.panelControl1)
            Me.layoutControl1.Controls.Add(Me.propertyGridControl)
            Me.layoutControl1.Controls.Add(Me.simpleButtonCopyPaste)
            Me.layoutControl1.Controls.Add(Me.richEditControl)
            Me.layoutControl1.Controls.Add(Me.spreadsheetControl1)
            Me.layoutControl1.Controls.Add(Me.gridControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(267, 62, 925, 789)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(924, 562)
            Me.layoutControl1.TabIndex = 1
            Me.layoutControl1.Text = "layoutControl1"
            AddHandler Me.layoutControl1.GroupExpandChanged, New DevExpress.XtraLayout.Utils.LayoutGroupEventHandler(AddressOf Me.layoutControl1_GroupExpandChanged)
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.webBrowser1)
            Me.panelControl1.Location = New System.Drawing.Point(461, 392)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(420, 168)
            Me.panelControl1.TabIndex = 19
            ' 
            ' webBrowser1
            ' 
            Me.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.webBrowser1.Location = New System.Drawing.Point(2, 2)
            Me.webBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.webBrowser1.Name = "webBrowser1"
            Me.webBrowser1.Size = New System.Drawing.Size(416, 164)
            Me.webBrowser1.TabIndex = 13
            ' 
            ' propertyGridControl
            ' 
            Me.propertyGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.propertyGridControl.Location = New System.Drawing.Point(895, 2)
            Me.propertyGridControl.MinimumSize = New System.Drawing.Size(300, 0)
            Me.propertyGridControl.Name = "propertyGridControl"
            Me.propertyGridControl.OptionsView.AllowReadOnlyRowAppearance = DevExpress.Utils.DefaultBoolean.[True]
            Me.propertyGridControl.OptionsView.ShowRootCategories = False
            Me.propertyGridControl.Size = New System.Drawing.Size(343, 553)
            Me.propertyGridControl.TabIndex = 17
            ' 
            ' simpleButtonCopyPaste
            ' 
            Me.simpleButtonCopyPaste.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
            Me.simpleButtonCopyPaste.Appearance.Options.UseBackColor = True
            Me.simpleButtonCopyPaste.Location = New System.Drawing.Point(2, 2)
            Me.simpleButtonCopyPaste.Name = "simpleButtonCopyPaste"
            Me.simpleButtonCopyPaste.Size = New System.Drawing.Size(445, 22)
            Me.simpleButtonCopyPaste.StyleController = Me.layoutControl1
            Me.simpleButtonCopyPaste.TabIndex = 15
            Me.simpleButtonCopyPaste.Text = "Copy and Paste"
            AddHandler Me.simpleButtonCopyPaste.Click, New System.EventHandler(AddressOf Me.simpleButtonCopyPaste_Click)
            ' 
            ' richEditControl
            ' 
            Me.richEditControl.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft
            Me.richEditControl.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel
            Me.richEditControl.Location = New System.Drawing.Point(461, 205)
            Me.richEditControl.Name = "richEditControl"
            Me.richEditControl.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
            Me.richEditControl.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
            Me.richEditControl.Size = New System.Drawing.Size(420, 167)
            Me.richEditControl.TabIndex = 12
            Me.richEditControl.Views.DraftView.Padding = New DevExpress.Portable.PortablePadding(17, 16, 0, 0)
            ' 
            ' spreadsheetControl1
            ' 
            Me.spreadsheetControl1.Location = New System.Drawing.Point(461, 18)
            Me.spreadsheetControl1.Name = "spreadsheetControl1"
            Me.spreadsheetControl1.Options.TabSelector.Visibility = DevExpress.XtraSpreadsheet.SpreadsheetElementVisibility.Hidden
            Me.spreadsheetControl1.Options.View.Charts.Antialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled
            Me.spreadsheetControl1.Options.View.Charts.TextAntialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled
            Me.spreadsheetControl1.Options.View.ShowColumnHeaders = False
            Me.spreadsheetControl1.Options.View.ShowPrintArea = False
            Me.spreadsheetControl1.Options.View.ShowRowHeaders = False
            Me.spreadsheetControl1.Size = New System.Drawing.Size(420, 167)
            Me.spreadsheetControl1.TabIndex = 4
            Me.spreadsheetControl1.Text = "spreadsheetControl1"
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.richEditLCI, Me.copyPasteButtonLCI, Me.gridViewPropertiesLayoutGroup, Me.splitterItem1, Me.webBrowserLCI, Me.gridControlLCI, Me.splitterItemGrid})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(924, 562)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.spreadsheetControl1
            Me.layoutControlItem2.Location = New System.Drawing.Point(459, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(424, 187)
            Me.layoutControlItem2.Text = "Excel format"
            Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(78, 13)
            ' 
            ' richEditLCI
            ' 
            Me.richEditLCI.Control = Me.richEditControl
            Me.richEditLCI.Location = New System.Drawing.Point(459, 187)
            Me.richEditLCI.Name = "richEditLCI"
            Me.richEditLCI.Size = New System.Drawing.Size(424, 187)
            Me.richEditLCI.Text = "Rich text format"
            Me.richEditLCI.TextLocation = DevExpress.Utils.Locations.Top
            Me.richEditLCI.TextSize = New System.Drawing.Size(78, 13)
            ' 
            ' copyPasteButtonLCI
            ' 
            Me.copyPasteButtonLCI.Control = Me.simpleButtonCopyPaste
            Me.copyPasteButtonLCI.Location = New System.Drawing.Point(0, 0)
            Me.copyPasteButtonLCI.Name = "copyPasteButtonLCI"
            Me.copyPasteButtonLCI.Size = New System.Drawing.Size(449, 26)
            Me.copyPasteButtonLCI.TextVisible = False
            ' 
            ' gridViewPropertiesLayoutGroup
            ' 
            Me.gridViewPropertiesLayoutGroup.ExpandButtonVisible = True
            Me.gridViewPropertiesLayoutGroup.Expanded = False
            Me.gridViewPropertiesLayoutGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem8})
            Me.gridViewPropertiesLayoutGroup.Location = New System.Drawing.Point(893, 0)
            Me.gridViewPropertiesLayoutGroup.Name = "gridViewPropertiesLayoutGroup"
            Me.gridViewPropertiesLayoutGroup.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.gridViewPropertiesLayoutGroup.Size = New System.Drawing.Size(31, 562)
            Me.gridViewPropertiesLayoutGroup.Text = "Clipboard Options"
            Me.gridViewPropertiesLayoutGroup.TextLocation = DevExpress.Utils.Locations.Right
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.propertyGridControl
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(347, 557)
            Me.layoutControlItem8.TextVisible = False
            ' 
            ' splitterItem1
            ' 
            Me.splitterItem1.Location = New System.Drawing.Point(883, 0)
            Me.splitterItem1.Name = "splitterItem1"
            Me.splitterItem1.Size = New System.Drawing.Size(10, 562)
            Me.splitterItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            ' 
            ' webBrowserLCI
            ' 
            Me.webBrowserLCI.Control = Me.panelControl1
            Me.webBrowserLCI.Location = New System.Drawing.Point(459, 374)
            Me.webBrowserLCI.Name = "webBrowserLCI"
            Me.webBrowserLCI.Size = New System.Drawing.Size(424, 188)
            Me.webBrowserLCI.Text = "HTML format"
            Me.webBrowserLCI.TextLocation = DevExpress.Utils.Locations.Top
            Me.webBrowserLCI.TextSize = New System.Drawing.Size(78, 13)
            ' 
            ' gridControlLCI
            ' 
            Me.gridControlLCI.Control = Me.gridControl1
            Me.gridControlLCI.Location = New System.Drawing.Point(0, 26)
            Me.gridControlLCI.Name = "gridControlLCI"
            Me.gridControlLCI.Size = New System.Drawing.Size(449, 536)
            Me.gridControlLCI.TextVisible = False
            ' 
            ' splitterItemGrid
            ' 
            Me.splitterItemGrid.Location = New System.Drawing.Point(449, 0)
            Me.splitterItemGrid.Name = "splitterItemGrid"
            Me.splitterItemGrid.Size = New System.Drawing.Size(10, 562)
            ' 
            ' ClipboardTutorial
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "ClipboardTutorial"
            Me.Size = New System.Drawing.Size(924, 562)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.ClipboardTutorial_Load)
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTextEdit2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTextEdit3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType((Me.propertyGridControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.richEditLCI), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.copyPasteButtonLCI), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridViewPropertiesLayoutGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.splitterItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.webBrowserLCI), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControlLCI), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.splitterItemGrid), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.Demos.ClipboardGridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private colState As DevExpress.XtraGrid.Columns.GridColumn

        Private colSales As DevExpress.XtraGrid.Columns.GridColumn

        Private colProfit As DevExpress.XtraGrid.Columns.GridColumn

        Private colSalesVsTarget As DevExpress.XtraGrid.Columns.GridColumn

        Private colMarketShare As DevExpress.XtraGrid.Columns.GridColumn

        Private colCustomersSatisfaction As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

        Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private repositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private repositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private gridControlLCI As DevExpress.XtraLayout.LayoutControlItem

        Private webBrowser1 As System.Windows.Forms.WebBrowser

        Private richEditControl As DevExpress.XtraRichEdit.RichEditControl

        Private spreadsheetControl1 As DevExpress.XtraSpreadsheet.SpreadsheetControl

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private richEditLCI As DevExpress.XtraLayout.LayoutControlItem

        Private splitterItemGrid As DevExpress.XtraLayout.SplitterItem

        Private simpleButtonCopyPaste As DevExpress.XtraEditors.SimpleButton

        Private copyPasteButtonLCI As DevExpress.XtraLayout.LayoutControlItem

        Private propertyGridControl As DevExpress.XtraVerticalGrid.PropertyGridControl

        Private gridViewPropertiesLayoutGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private splitterItem1 As DevExpress.XtraLayout.SplitterItem

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private webBrowserLCI As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
