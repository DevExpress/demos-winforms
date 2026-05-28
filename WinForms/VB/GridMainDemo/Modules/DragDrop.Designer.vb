Namespace DevExpress.XtraGrid.Demos

    Partial Class DragDrop

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
            Dim formatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
            Dim gridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
            Dim gridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleTopBottom1 As DevExpress.XtraEditors.FormatConditionRuleTopBottom = New DevExpress.XtraEditors.FormatConditionRuleTopBottom()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.DragDrop))
            Dim gridFormatRule4 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleValue3 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
            Dim gridFormatRule5 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleValue4 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
            Dim gridFormatRule6 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleTopBottom2 As DevExpress.XtraEditors.FormatConditionRuleTopBottom = New DevExpress.XtraEditors.FormatConditionRuleTopBottom()
            Me.colSalesVsTarget = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.colProfit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.colMarketShare = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colState = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSales = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCustomersSatisfaction = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.dataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.pictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
            Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
            Me.imageComboBoxEdit1 = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
            Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.icbSelectMode1 = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.ceMultiSelect1 = New DevExpress.XtraEditors.CheckEdit()
            Me.icbSelectMode2 = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.ceMultiSelect2 = New DevExpress.XtraEditors.CheckEdit()
            Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.imageComboBoxEdit2 = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.behaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTextEdit3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTextEdit5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTextEdit4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTextEdit2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTextEdit6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dataLayoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dataLayoutControl1.SuspendLayout()
            CType((Me.pictureEdit2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pictureEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageComboBoxEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpinEdit2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbSelectMode1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceMultiSelect1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbSelectMode2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceMultiSelect2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageComboBoxEdit2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.splitterItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.behaviorManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' colSalesVsTarget
            ' 
            Me.colSalesVsTarget.ColumnEdit = Me.repositoryItemTextEdit1
            Me.colSalesVsTarget.FieldName = "SalesVsTarget"
            Me.colSalesVsTarget.Name = "colSalesVsTarget"
            Me.colSalesVsTarget.Visible = True
            Me.colSalesVsTarget.VisibleIndex = 2
            Me.colSalesVsTarget.Width = 81
            ' 
            ' repositoryItemTextEdit1
            ' 
            Me.repositoryItemTextEdit1.AutoHeight = False
            Me.repositoryItemTextEdit1.Mask.EditMask = "p"
            Me.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
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
            Me.colProfit.Width = 76
            ' 
            ' repositoryItemTextEdit3
            ' 
            Me.repositoryItemTextEdit3.AutoHeight = False
            Me.repositoryItemTextEdit3.Mask.EditMask = "n"
            Me.repositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3"
            ' 
            ' gridColumn4
            ' 
            Me.gridColumn4.ColumnEdit = Me.repositoryItemTextEdit5
            Me.gridColumn4.FieldName = "SalesVsTarget"
            Me.gridColumn4.Name = "gridColumn4"
            Me.gridColumn4.Visible = True
            Me.gridColumn4.VisibleIndex = 2
            Me.gridColumn4.Width = 105
            ' 
            ' repositoryItemTextEdit5
            ' 
            Me.repositoryItemTextEdit5.AutoHeight = False
            Me.repositoryItemTextEdit5.Mask.EditMask = "p"
            Me.repositoryItemTextEdit5.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit5.Mask.UseMaskAsDisplayFormat = True
            Me.repositoryItemTextEdit5.Name = "repositoryItemTextEdit5"
            ' 
            ' gridColumn3
            ' 
            Me.gridColumn3.ColumnEdit = Me.repositoryItemTextEdit4
            Me.gridColumn3.DisplayFormat.FormatString = "#,##0,,M"
            Me.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gridColumn3.FieldName = "Profit"
            Me.gridColumn3.Name = "gridColumn3"
            Me.gridColumn3.Visible = True
            Me.gridColumn3.VisibleIndex = 3
            Me.gridColumn3.Width = 204
            ' 
            ' repositoryItemTextEdit4
            ' 
            Me.repositoryItemTextEdit4.AutoHeight = False
            Me.repositoryItemTextEdit4.Mask.EditMask = "n"
            Me.repositoryItemTextEdit4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4"
            ' 
            ' colMarketShare
            ' 
            Me.colMarketShare.ColumnEdit = Me.repositoryItemTextEdit2
            Me.colMarketShare.FieldName = "MarketShare"
            Me.colMarketShare.Name = "colMarketShare"
            Me.colMarketShare.Visible = True
            Me.colMarketShare.VisibleIndex = 5
            Me.colMarketShare.Width = 69
            ' 
            ' repositoryItemTextEdit2
            ' 
            Me.repositoryItemTextEdit2.AutoHeight = False
            Me.repositoryItemTextEdit2.Mask.EditMask = "p0"
            Me.repositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = True
            Me.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2"
            ' 
            ' gridColumn5
            ' 
            Me.gridColumn5.ColumnEdit = Me.repositoryItemTextEdit6
            Me.gridColumn5.FieldName = "MarketShare"
            Me.gridColumn5.Name = "gridColumn5"
            Me.gridColumn5.Visible = True
            Me.gridColumn5.VisibleIndex = 5
            Me.gridColumn5.Width = 134
            ' 
            ' repositoryItemTextEdit6
            ' 
            Me.repositoryItemTextEdit6.AutoHeight = False
            Me.repositoryItemTextEdit6.Mask.EditMask = "p0"
            Me.repositoryItemTextEdit6.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit6.Mask.UseMaskAsDisplayFormat = True
            Me.repositoryItemTextEdit6.Name = "repositoryItemTextEdit6"
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.gridControl1.Location = New System.Drawing.Point(12, 94)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSpinEdit1, Me.repositoryItemTextEdit1, Me.repositoryItemTextEdit2, Me.repositoryItemTextEdit3})
            Me.gridControl1.Size = New System.Drawing.Size(514, 421)
            Me.gridControl1.TabIndex = 1
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Appearance.ViewCaption.Options.UseTextOptions = True
            Me.gridView1.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
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
            gridFormatRule3.ApplyToRow = True
            gridFormatRule3.Column = Me.colProfit
            gridFormatRule3.Name = "ProfitFormat"
            formatConditionRuleTopBottom1.PredefinedName = "Bold Text"
            formatConditionRuleTopBottom1.Rank = New Decimal(New Integer() {6, 0, 0, 0})
            gridFormatRule3.Rule = formatConditionRuleTopBottom1
            Me.gridView1.FormatRules.Add(gridFormatRule1)
            Me.gridView1.FormatRules.Add(gridFormatRule2)
            Me.gridView1.FormatRules.Add(gridFormatRule3)
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView1.OptionsClipboard.AllowHtmlFormat = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView1.OptionsClipboard.CopyCollapsedData = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView1.OptionsClipboard.PasteMode = DevExpress.Export.PasteMode.Append
            Me.gridView1.OptionsMenu.ShowConditionalFormattingItem = True
            Me.gridView1.OptionsSelection.MultiSelect = True
            Me.gridView1.OptionsView.EnableAppearanceOddRow = True
            Me.gridView1.OptionsView.ShowGroupPanel = False
            AddHandler Me.gridView1.ShowingEditor, New System.ComponentModel.CancelEventHandler(AddressOf Me.gridView2_ShowingEditor)
            ' 
            ' colState
            ' 
            Me.colState.FieldName = "State"
            Me.colState.Name = "colState"
            Me.colState.Visible = True
            Me.colState.VisibleIndex = 0
            Me.colState.Width = 65
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
            Me.colSales.Width = 60
            ' 
            ' colCustomersSatisfaction
            ' 
            Me.colCustomersSatisfaction.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.colCustomersSatisfaction.FieldName = "CustomersSatisfaction"
            Me.colCustomersSatisfaction.Name = "colCustomersSatisfaction"
            Me.colCustomersSatisfaction.Visible = True
            Me.colCustomersSatisfaction.VisibleIndex = 4
            Me.colCustomersSatisfaction.Width = 108
            ' 
            ' repositoryItemSpinEdit1
            ' 
            Me.repositoryItemSpinEdit1.AutoHeight = False
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            ' 
            ' dataLayoutControl1
            ' 
            Me.dataLayoutControl1.AllowCustomization = False
            Me.dataLayoutControl1.Controls.Add(Me.pictureEdit2)
            Me.dataLayoutControl1.Controls.Add(Me.pictureEdit1)
            Me.dataLayoutControl1.Controls.Add(Me.imageComboBoxEdit1)
            Me.dataLayoutControl1.Controls.Add(Me.labelControl1)
            Me.dataLayoutControl1.Controls.Add(Me.gridControl2)
            Me.dataLayoutControl1.Controls.Add(Me.gridControl1)
            Me.dataLayoutControl1.Controls.Add(Me.icbSelectMode1)
            Me.dataLayoutControl1.Controls.Add(Me.ceMultiSelect1)
            Me.dataLayoutControl1.Controls.Add(Me.icbSelectMode2)
            Me.dataLayoutControl1.Controls.Add(Me.ceMultiSelect2)
            Me.dataLayoutControl1.Controls.Add(Me.labelControl3)
            Me.dataLayoutControl1.Controls.Add(Me.imageComboBoxEdit2)
            Me.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dataLayoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.dataLayoutControl1.Name = "dataLayoutControl1"
            Me.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(-1242, 493, 650, 400)
            Me.dataLayoutControl1.OptionsView.AllowExpandAnimation = DevExpress.Utils.DefaultBoolean.[True]
            Me.dataLayoutControl1.Root = Me.layoutControlGroup1
            Me.dataLayoutControl1.Size = New System.Drawing.Size(1055, 527)
            Me.dataLayoutControl1.TabIndex = 2
            Me.dataLayoutControl1.Text = "dataLayoutControl1"
            ' 
            ' pictureEdit2
            ' 
            Me.pictureEdit2.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.pictureEdit2.EditValue =(CObj((resources.GetObject("pictureEdit2.EditValue"))))
            Me.pictureEdit2.Location = New System.Drawing.Point(540, 12)
            Me.pictureEdit2.MaximumSize = New System.Drawing.Size(72, 72)
            Me.pictureEdit2.MinimumSize = New System.Drawing.Size(72, 72)
            Me.pictureEdit2.Name = "pictureEdit2"
            Me.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto
            Me.pictureEdit2.Size = New System.Drawing.Size(72, 72)
            Me.pictureEdit2.StyleController = Me.dataLayoutControl1
            Me.pictureEdit2.TabIndex = 10
            ' 
            ' pictureEdit1
            ' 
            Me.pictureEdit1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.pictureEdit1.EditValue =(CObj((resources.GetObject("pictureEdit1.EditValue"))))
            Me.pictureEdit1.Location = New System.Drawing.Point(12, 12)
            Me.pictureEdit1.MaximumSize = New System.Drawing.Size(72, 72)
            Me.pictureEdit1.MinimumSize = New System.Drawing.Size(72, 72)
            Me.pictureEdit1.Name = "pictureEdit1"
            Me.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto
            Me.pictureEdit1.Size = New System.Drawing.Size(72, 72)
            Me.pictureEdit1.StyleController = Me.dataLayoutControl1
            Me.pictureEdit1.TabIndex = 9
            ' 
            ' imageComboBoxEdit1
            ' 
            Me.imageComboBoxEdit1.Location = New System.Drawing.Point(386, 60)
            Me.imageComboBoxEdit1.Name = "imageComboBoxEdit1"
            Me.imageComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.imageComboBoxEdit1.Size = New System.Drawing.Size(140, 20)
            Me.imageComboBoxEdit1.StyleController = Me.dataLayoutControl1
            Me.imageComboBoxEdit1.TabIndex = 8
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.AllowHtmlString = True
            Me.labelControl1.Appearance.Options.UseTextOptions = True
            Me.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
            Me.labelControl1.Location = New System.Drawing.Point(616, 29)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(132, 37)
            Me.labelControl1.StyleController = Me.dataLayoutControl1
            Me.labelControl1.TabIndex = 7
            Me.labelControl1.Text = "<size=+6>Hannah Brookly</size><size=+1><br> Online Sales Manager"
            ' 
            ' gridControl2
            ' 
            Me.gridControl2.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.gridControl2.Location = New System.Drawing.Point(540, 94)
            Me.gridControl2.MainView = Me.gridView2
            Me.gridControl2.Name = "gridControl2"
            Me.gridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSpinEdit2, Me.repositoryItemTextEdit5, Me.repositoryItemTextEdit6, Me.repositoryItemTextEdit4})
            Me.gridControl2.Size = New System.Drawing.Size(503, 421)
            Me.gridControl2.TabIndex = 4
            Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView2})
            ' 
            ' gridView2
            ' 
            Me.gridView2.Appearance.ViewCaption.Options.UseTextOptions = True
            Me.gridView2.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4, Me.gridColumn5, Me.gridColumn6})
            Me.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
            gridFormatRule4.Column = Me.gridColumn4
            gridFormatRule4.Name = "SalesFormat"
            formatConditionRuleValue3.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((192)))))), (CInt(((CByte((255)))))), (CInt(((CByte((192)))))))
            formatConditionRuleValue3.Appearance.ForeColor = System.Drawing.Color.Green
            formatConditionRuleValue3.Appearance.Options.UseBackColor = True
            formatConditionRuleValue3.Appearance.Options.UseForeColor = True
            formatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Greater
            formatConditionRuleValue3.Value1 = "0"
            gridFormatRule4.Rule = formatConditionRuleValue3
            gridFormatRule5.Column = Me.gridColumn4
            gridFormatRule5.Name = "Sales vs Target Less then zero"
            formatConditionRuleValue4.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((192)))))), (CInt(((CByte((192)))))))
            formatConditionRuleValue4.Appearance.ForeColor = System.Drawing.Color.Red
            formatConditionRuleValue4.Appearance.Options.UseBackColor = True
            formatConditionRuleValue4.Appearance.Options.UseForeColor = True
            formatConditionRuleValue4.Condition = DevExpress.XtraEditors.FormatCondition.Less
            formatConditionRuleValue4.Value1 = "0"
            gridFormatRule5.Rule = formatConditionRuleValue4
            gridFormatRule6.ApplyToRow = True
            gridFormatRule6.Column = Me.gridColumn3
            gridFormatRule6.Name = "ProfitFormat"
            formatConditionRuleTopBottom2.PredefinedName = "Bold Text"
            formatConditionRuleTopBottom2.Rank = New Decimal(New Integer() {6, 0, 0, 0})
            gridFormatRule6.Rule = formatConditionRuleTopBottom2
            Me.gridView2.FormatRules.Add(gridFormatRule4)
            Me.gridView2.FormatRules.Add(gridFormatRule5)
            Me.gridView2.FormatRules.Add(gridFormatRule6)
            Me.gridView2.GridControl = Me.gridControl2
            Me.gridView2.Name = "gridView2"
            Me.gridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView2.OptionsClipboard.AllowHtmlFormat = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView2.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView2.OptionsClipboard.CopyCollapsedData = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView2.OptionsClipboard.PasteMode = DevExpress.Export.PasteMode.Update
            Me.gridView2.OptionsMenu.ShowConditionalFormattingItem = True
            Me.gridView2.OptionsSelection.MultiSelect = True
            Me.gridView2.OptionsView.EnableAppearanceOddRow = True
            Me.gridView2.OptionsView.ShowGroupPanel = False
            AddHandler Me.gridView2.ShowingEditor, New System.ComponentModel.CancelEventHandler(AddressOf Me.gridView2_ShowingEditor)
            ' 
            ' gridColumn1
            ' 
            Me.gridColumn1.FieldName = "State"
            Me.gridColumn1.Name = "gridColumn1"
            Me.gridColumn1.Visible = True
            Me.gridColumn1.VisibleIndex = 0
            Me.gridColumn1.Width = 151
            ' 
            ' gridColumn2
            ' 
            Me.gridColumn2.ColumnEdit = Me.repositoryItemTextEdit4
            Me.gridColumn2.DisplayFormat.FormatString = "#,##0,,M"
            Me.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gridColumn2.FieldName = "Sales"
            Me.gridColumn2.Name = "gridColumn2"
            Me.gridColumn2.Visible = True
            Me.gridColumn2.VisibleIndex = 1
            Me.gridColumn2.Width = 184
            ' 
            ' gridColumn6
            ' 
            Me.gridColumn6.ColumnEdit = Me.repositoryItemSpinEdit2
            Me.gridColumn6.FieldName = "CustomersSatisfaction"
            Me.gridColumn6.Name = "gridColumn6"
            Me.gridColumn6.Visible = True
            Me.gridColumn6.VisibleIndex = 4
            Me.gridColumn6.Width = 132
            ' 
            ' repositoryItemSpinEdit2
            ' 
            Me.repositoryItemSpinEdit2.AutoHeight = False
            Me.repositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2"
            ' 
            ' icbSelectMode1
            ' 
            Me.icbSelectMode1.EditValue = "imageComboBoxEdit1"
            Me.icbSelectMode1.Location = New System.Drawing.Point(386, 12)
            Me.icbSelectMode1.MaximumSize = New System.Drawing.Size(140, 0)
            Me.icbSelectMode1.MinimumSize = New System.Drawing.Size(140, 0)
            Me.icbSelectMode1.Name = "icbSelectMode1"
            Me.icbSelectMode1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbSelectMode1.Size = New System.Drawing.Size(140, 20)
            Me.icbSelectMode1.StyleController = Me.dataLayoutControl1
            Me.icbSelectMode1.TabIndex = 5
            ' 
            ' ceMultiSelect1
            ' 
            Me.ceMultiSelect1.Location = New System.Drawing.Point(386, 36)
            Me.ceMultiSelect1.Name = "ceMultiSelect1"
            Me.ceMultiSelect1.Properties.Caption = ""
            Me.ceMultiSelect1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.ceMultiSelect1.Size = New System.Drawing.Size(140, 20)
            Me.ceMultiSelect1.StyleController = Me.dataLayoutControl1
            Me.ceMultiSelect1.TabIndex = 4
            ' 
            ' icbSelectMode2
            ' 
            Me.icbSelectMode2.EditValue = "imageComboBoxEdit1"
            Me.icbSelectMode2.Location = New System.Drawing.Point(903, 12)
            Me.icbSelectMode2.MaximumSize = New System.Drawing.Size(140, 0)
            Me.icbSelectMode2.MinimumSize = New System.Drawing.Size(140, 0)
            Me.icbSelectMode2.Name = "icbSelectMode2"
            Me.icbSelectMode2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbSelectMode2.Size = New System.Drawing.Size(140, 20)
            Me.icbSelectMode2.StyleController = Me.dataLayoutControl1
            Me.icbSelectMode2.TabIndex = 5
            ' 
            ' ceMultiSelect2
            ' 
            Me.ceMultiSelect2.Location = New System.Drawing.Point(903, 36)
            Me.ceMultiSelect2.Name = "ceMultiSelect2"
            Me.ceMultiSelect2.Properties.Caption = ""
            Me.ceMultiSelect2.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.ceMultiSelect2.Size = New System.Drawing.Size(140, 20)
            Me.ceMultiSelect2.StyleController = Me.dataLayoutControl1
            Me.ceMultiSelect2.TabIndex = 4
            ' 
            ' labelControl3
            ' 
            Me.labelControl3.AllowHtmlString = True
            Me.labelControl3.Appearance.Options.UseTextOptions = True
            Me.labelControl3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.labelControl3.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
            Me.labelControl3.Location = New System.Drawing.Point(88, 29)
            Me.labelControl3.Name = "labelControl3"
            Me.labelControl3.Size = New System.Drawing.Size(128, 37)
            Me.labelControl3.StyleController = Me.dataLayoutControl1
            Me.labelControl3.TabIndex = 6
            Me.labelControl3.Text = "<size=+6>Kurt Weherend</size><size=+1><br>Retail Sales Manager"
            ' 
            ' imageComboBoxEdit2
            ' 
            Me.imageComboBoxEdit2.Location = New System.Drawing.Point(903, 60)
            Me.imageComboBoxEdit2.Name = "imageComboBoxEdit2"
            Me.imageComboBoxEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.imageComboBoxEdit2.Size = New System.Drawing.Size(140, 20)
            Me.imageComboBoxEdit2.StyleController = Me.dataLayoutControl1
            Me.imageComboBoxEdit2.TabIndex = 8
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem1, Me.splitterItem1, Me.layoutControlItem5, Me.layoutControlItem8, Me.layoutControlItem10, Me.layoutControlItem12, Me.layoutControlItem3, Me.layoutControlItem9, Me.emptySpaceItem7, Me.layoutControlItem11, Me.emptySpaceItem1, Me.layoutControlItem6, Me.layoutControlItem7, Me.layoutControlItem4})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(1055, 527)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.gridControl2
            Me.layoutControlItem2.Location = New System.Drawing.Point(528, 76)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 8, 2)
            Me.layoutControlItem2.Size = New System.Drawing.Size(507, 431)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.gridControl1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 76)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 8, 2)
            Me.layoutControlItem1.Size = New System.Drawing.Size(518, 431)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' splitterItem1
            ' 
            Me.splitterItem1.Location = New System.Drawing.Point(518, 0)
            Me.splitterItem1.Name = "splitterItem1"
            Me.splitterItem1.Size = New System.Drawing.Size(10, 507)
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.labelControl1
            Me.layoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.layoutControlItem5.FillControlToClientArea = False
            Me.layoutControlItem5.Location = New System.Drawing.Point(604, 0)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(136, 76)
            Me.layoutControlItem5.TextVisible = False
            Me.layoutControlItem5.TrimClientAreaToControl = False
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.imageComboBoxEdit1
            Me.layoutControlItem8.Location = New System.Drawing.Point(300, 48)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(218, 28)
            Me.layoutControlItem8.Text = "Paste Mode:"
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(62, 13)
            ' 
            ' layoutControlItem10
            ' 
            Me.layoutControlItem10.Control = Me.pictureEdit1
            Me.layoutControlItem10.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Size = New System.Drawing.Size(76, 76)
            Me.layoutControlItem10.TextVisible = False
            ' 
            ' layoutControlItem12
            ' 
            Me.layoutControlItem12.Control = Me.pictureEdit2
            Me.layoutControlItem12.Location = New System.Drawing.Point(528, 0)
            Me.layoutControlItem12.Name = "layoutControlItem12"
            Me.layoutControlItem12.Size = New System.Drawing.Size(76, 76)
            Me.layoutControlItem12.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.icbSelectMode2
            Me.layoutControlItem3.CustomizationFormText = "Multi-Select Mode:"
            Me.layoutControlItem3.Location = New System.Drawing.Point(817, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(218, 24)
            Me.layoutControlItem3.Text = "Select Mode:"
            Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(62, 13)
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.imageComboBoxEdit2
            Me.layoutControlItem9.CustomizationFormText = "Paste Mode:"
            Me.layoutControlItem9.Location = New System.Drawing.Point(817, 48)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Size = New System.Drawing.Size(218, 28)
            Me.layoutControlItem9.Text = "Paste Mode:"
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(62, 13)
            ' 
            ' emptySpaceItem7
            ' 
            Me.emptySpaceItem7.Location = New System.Drawing.Point(740, 0)
            Me.emptySpaceItem7.Name = "emptySpaceItem7"
            Me.emptySpaceItem7.Size = New System.Drawing.Size(77, 76)
            ' 
            ' layoutControlItem11
            ' 
            Me.layoutControlItem11.Control = Me.labelControl3
            Me.layoutControlItem11.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.layoutControlItem11.CustomizationFormText = "layoutControlItem5"
            Me.layoutControlItem11.FillControlToClientArea = False
            Me.layoutControlItem11.Location = New System.Drawing.Point(76, 0)
            Me.layoutControlItem11.Name = "layoutControlItem11"
            Me.layoutControlItem11.Size = New System.Drawing.Size(132, 76)
            Me.layoutControlItem11.Text = "layoutControlItem5"
            Me.layoutControlItem11.TextVisible = False
            Me.layoutControlItem11.TrimClientAreaToControl = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(208, 0)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(92, 76)
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.icbSelectMode1
            Me.layoutControlItem6.CustomizationFormText = "Multi-Select Mode:"
            Me.layoutControlItem6.Location = New System.Drawing.Point(300, 0)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(218, 24)
            Me.layoutControlItem6.Text = "Select Mode:"
            Me.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(62, 13)
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.ceMultiSelect1
            Me.layoutControlItem7.CustomizationFormText = "layoutControlItem7"
            Me.layoutControlItem7.Location = New System.Drawing.Point(300, 24)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(218, 24)
            Me.layoutControlItem7.Text = "Multi-Select:"
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(62, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.ceMultiSelect2
            Me.layoutControlItem4.CustomizationFormText = "layoutControlItem7"
            Me.layoutControlItem4.Location = New System.Drawing.Point(817, 24)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(218, 24)
            Me.layoutControlItem4.Text = "Multi-Select"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(62, 13)
            ' 
            ' DragDrop
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dataLayoutControl1)
            Me.Name = "DragDrop"
            Me.Size = New System.Drawing.Size(1055, 527)
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTextEdit3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTextEdit5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTextEdit4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTextEdit2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTextEdit6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dataLayoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dataLayoutControl1.ResumeLayout(False)
            CType((Me.pictureEdit2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pictureEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageComboBoxEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpinEdit2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbSelectMode1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceMultiSelect1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbSelectMode2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceMultiSelect2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageComboBoxEdit2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.splitterItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.behaviorManager1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private colState As DevExpress.XtraGrid.Columns.GridColumn

        Private colSales As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private colProfit As DevExpress.XtraGrid.Columns.GridColumn

        Private colSalesVsTarget As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private colMarketShare As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private colCustomersSatisfaction As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

        Private dataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private behaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager

        Private gridControl2 As DevExpress.XtraGrid.GridControl

        Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView

        Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private gridColumn6 As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private splitterItem1 As DevExpress.XtraLayout.SplitterItem

        Private icbSelectMode1 As DevExpress.XtraEditors.ImageComboBoxEdit

        Private ceMultiSelect1 As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private icbSelectMode2 As DevExpress.XtraEditors.ImageComboBoxEdit

        Private ceMultiSelect2 As DevExpress.XtraEditors.CheckEdit

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private imageComboBoxEdit1 As DevExpress.XtraEditors.ImageComboBoxEdit

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private imageComboBoxEdit2 As DevExpress.XtraEditors.ImageComboBoxEdit

        Private pictureEdit1 As DevExpress.XtraEditors.PictureEdit

        Private labelControl3 As DevExpress.XtraEditors.LabelControl

        Private layoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem

        Private pictureEdit2 As DevExpress.XtraEditors.PictureEdit

        Private layoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
