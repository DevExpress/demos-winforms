Namespace DevExpress.XtraGrid.Demos

    Partial Class DataUpdateRules

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
            Dim formatConditionRuleDataBar1 As DevExpress.XtraEditors.FormatConditionRuleDataBar = New DevExpress.XtraEditors.FormatConditionRuleDataBar()
            Dim gridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleDataUpdate1 As DevExpress.XtraEditors.FormatConditionRuleDataUpdate = New DevExpress.XtraEditors.FormatConditionRuleDataUpdate()
            Dim gridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleDataUpdate2 As DevExpress.XtraEditors.FormatConditionRuleDataUpdate = New DevExpress.XtraEditors.FormatConditionRuleDataUpdate()
            Dim gridFormatRule4 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleDataUpdate3 As DevExpress.XtraEditors.FormatConditionRuleDataUpdate = New DevExpress.XtraEditors.FormatConditionRuleDataUpdate()
            Dim gridFormatRule5 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleDataUpdate4 As DevExpress.XtraEditors.FormatConditionRuleDataUpdate = New DevExpress.XtraEditors.FormatConditionRuleDataUpdate()
            Dim gridFormatRule6 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleDataUpdate5 As DevExpress.XtraEditors.FormatConditionRuleDataUpdate = New DevExpress.XtraEditors.FormatConditionRuleDataUpdate()
            Dim gridFormatRule7 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleDataUpdate6 As DevExpress.XtraEditors.FormatConditionRuleDataUpdate = New DevExpress.XtraEditors.FormatConditionRuleDataUpdate()
            Dim gridFormatRule8 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleDataUpdate7 As DevExpress.XtraEditors.FormatConditionRuleDataUpdate = New DevExpress.XtraEditors.FormatConditionRuleDataUpdate()
            Me.ChgPercent = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.Chg = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.High = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.Low = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.Last = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.Ticker = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.Open = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.ceShowConditionalFormattingItem = New DevExpress.XtraEditors.CheckEdit()
            Me.trackBarControl1 = New DevExpress.XtraEditors.TrackBarControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.dateTimeChartRangeControlClient1 = New DevExpress.XtraEditors.DateTimeChartRangeControlClient()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemProgressBar1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.ceShowConditionalFormattingItem.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.trackBarControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.trackBarControl1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dateTimeChartRangeControlClient1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ChgPercent
            ' 
            Me.ChgPercent.Caption = "Change <size=-1>(%)"
            Me.ChgPercent.FieldName = "ChgPercent"
            Me.ChgPercent.Name = "ChgPercent"
            Me.ChgPercent.Visible = True
            Me.ChgPercent.VisibleIndex = 3
            Me.ChgPercent.Width = 120
            ' 
            ' Chg
            ' 
            Me.Chg.Caption = "Change <size=-1>($)"
            Me.Chg.DisplayFormat.FormatString = "c"
            Me.Chg.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.Chg.FieldName = "Chg"
            Me.Chg.Name = "Chg"
            Me.Chg.Visible = True
            Me.Chg.VisibleIndex = 2
            Me.Chg.Width = 102
            ' 
            ' High
            ' 
            Me.High.Caption = "High <size=-1>($)"
            Me.High.DisplayFormat.FormatString = "c"
            Me.High.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.High.FieldName = "High"
            Me.High.Name = "High"
            Me.High.Visible = True
            Me.High.VisibleIndex = 5
            Me.High.Width = 94
            ' 
            ' Low
            ' 
            Me.Low.Caption = "Low <size=-1>($)"
            Me.Low.DisplayFormat.FormatString = "c"
            Me.Low.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.Low.FieldName = "Low"
            Me.Low.Name = "Low"
            Me.Low.Visible = True
            Me.Low.VisibleIndex = 6
            Me.Low.Width = 96
            ' 
            ' Last
            ' 
            Me.Last.Caption = "Price"
            Me.Last.DisplayFormat.FormatString = "c"
            Me.Last.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.Last.FieldName = "Last"
            Me.Last.Name = "Last"
            Me.Last.Visible = True
            Me.Last.VisibleIndex = 1
            Me.Last.Width = 91
            ' 
            ' Ticker
            ' 
            Me.Ticker.Caption = "Ticker"
            Me.Ticker.FieldName = "Ticker"
            Me.Ticker.Name = "Ticker"
            Me.Ticker.Visible = True
            Me.Ticker.VisibleIndex = 0
            Me.Ticker.Width = 113
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemProgressBar1})
            Me.gridControl1.Size = New System.Drawing.Size(707, 450)
            Me.gridControl1.TabIndex = 4
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Ticker, Me.Last, Me.Chg, Me.ChgPercent, Me.Open, Me.High, Me.Low})
            gridFormatRule1.Column = Me.ChgPercent
            gridFormatRule1.Name = "Format0"
            formatConditionRuleDataBar1.DrawAxisAtMiddle = True
            formatConditionRuleDataBar1.PredefinedName = "Green"
            gridFormatRule1.Rule = formatConditionRuleDataBar1
            gridFormatRule2.Column = Me.Chg
            gridFormatRule2.Name = "Format1"
            formatConditionRuleDataUpdate1.HighlightTime = 500
            formatConditionRuleDataUpdate1.PredefinedName = "Green Fill"
            formatConditionRuleDataUpdate1.Trigger = DevExpress.XtraEditors.FormatConditionDataUpdateTrigger.ValueIncreased
            gridFormatRule2.Rule = formatConditionRuleDataUpdate1
            gridFormatRule3.Column = Me.Chg
            gridFormatRule3.Name = "Format2"
            formatConditionRuleDataUpdate2.HighlightTime = 500
            formatConditionRuleDataUpdate2.PredefinedName = "Red Fill"
            formatConditionRuleDataUpdate2.Trigger = DevExpress.XtraEditors.FormatConditionDataUpdateTrigger.ValueDecreased
            gridFormatRule3.Rule = formatConditionRuleDataUpdate2
            gridFormatRule4.Column = Me.High
            gridFormatRule4.Name = "Format3"
            formatConditionRuleDataUpdate3.HighlightTime = 500
            formatConditionRuleDataUpdate3.Icon.PredefinedName = "Flags3_1.png"
            formatConditionRuleDataUpdate3.PredefinedName = "Green Fill, Green Text"
            formatConditionRuleDataUpdate3.Trigger = DevExpress.XtraEditors.FormatConditionDataUpdateTrigger.ValueIncreased
            gridFormatRule4.Rule = formatConditionRuleDataUpdate3
            gridFormatRule5.Column = Me.Low
            gridFormatRule5.Name = "Format4"
            formatConditionRuleDataUpdate4.HighlightTime = 500
            formatConditionRuleDataUpdate4.PredefinedName = "Red Fill, Red Text"
            formatConditionRuleDataUpdate4.Trigger = DevExpress.XtraEditors.FormatConditionDataUpdateTrigger.ValueDecreased
            gridFormatRule5.Rule = formatConditionRuleDataUpdate4
            gridFormatRule6.Column = Me.Chg
            gridFormatRule6.ColumnApplyTo = Me.Last
            gridFormatRule6.Name = "Format5"
            formatConditionRuleDataUpdate5.HighlightTime = 500
            formatConditionRuleDataUpdate5.Icon.PredefinedName = "Triangles3_1.png"
            formatConditionRuleDataUpdate5.Trigger = DevExpress.XtraEditors.FormatConditionDataUpdateTrigger.ValueIncreased
            gridFormatRule6.Rule = formatConditionRuleDataUpdate5
            gridFormatRule7.Column = Me.Chg
            gridFormatRule7.ColumnApplyTo = Me.Last
            gridFormatRule7.Name = "Format6"
            formatConditionRuleDataUpdate6.HighlightTime = 500
            formatConditionRuleDataUpdate6.Icon.PredefinedName = "Triangles3_3.png"
            formatConditionRuleDataUpdate6.Trigger = DevExpress.XtraEditors.FormatConditionDataUpdateTrigger.ValueDecreased
            gridFormatRule7.Rule = formatConditionRuleDataUpdate6
            gridFormatRule8.Column = Me.Chg
            gridFormatRule8.ColumnApplyTo = Me.Ticker
            gridFormatRule8.Name = "Format7"
            formatConditionRuleDataUpdate7.Appearance.FontStyleDelta = System.Drawing.FontStyle.Underline
            formatConditionRuleDataUpdate7.Appearance.Options.UseFont = True
            formatConditionRuleDataUpdate7.HighlightTime = 500
            formatConditionRuleDataUpdate7.PredefinedName = "Green Fill, Green Text"
            formatConditionRuleDataUpdate7.Trigger = DevExpress.XtraEditors.FormatConditionDataUpdateTrigger.Custom
            gridFormatRule8.Rule = formatConditionRuleDataUpdate7
            Me.gridView1.FormatRules.Add(gridFormatRule1)
            Me.gridView1.FormatRules.Add(gridFormatRule2)
            Me.gridView1.FormatRules.Add(gridFormatRule3)
            Me.gridView1.FormatRules.Add(gridFormatRule4)
            Me.gridView1.FormatRules.Add(gridFormatRule5)
            Me.gridView1.FormatRules.Add(gridFormatRule6)
            Me.gridView1.FormatRules.Add(gridFormatRule7)
            Me.gridView1.FormatRules.Add(gridFormatRule8)
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView1.OptionsBehavior.Editable = False
            Me.gridView1.OptionsBehavior.KeepFocusedRowOnUpdate = False
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView1.OptionsMenu.ShowConditionalFormattingItem = True
            Me.gridView1.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.gridView1.OptionsSelection.EnableAppearanceFocusedRow = False
            Me.gridView1.OptionsView.AllowHtmlDrawHeaders = True
            Me.gridView1.OptionsView.ShowGroupPanel = False
            Me.gridView1.OptionsView.ShowIndicator = False
            AddHandler Me.gridView1.FormatRuleDataUpdateCustomTrigger, New System.EventHandler(Of DevExpress.XtraGrid.Views.Grid.FormatRuleGridDataUpdateTriggerEventArgs)(AddressOf Me.gridView1_FormatRuleDataUpdateCustomTrigger)
            ' 
            ' Open
            ' 
            Me.Open.Caption = "Open <size=-1>($)"
            Me.Open.DisplayFormat.FormatString = "c"
            Me.Open.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.Open.FieldName = "Open"
            Me.Open.Name = "Open"
            Me.Open.Visible = True
            Me.Open.VisibleIndex = 4
            Me.Open.Width = 91
            ' 
            ' repositoryItemProgressBar1
            ' 
            Me.repositoryItemProgressBar1.Maximum = 1000
            Me.repositoryItemProgressBar1.Minimum = 300
            Me.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1"
            Me.repositoryItemProgressBar1.PercentView = False
            Me.repositoryItemProgressBar1.ShowTitle = True
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.navigationPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(707, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(250, 450)
            Me.sidePanel1.TabIndex = 5
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.Controls.Add(Me.navigationPage1)
            Me.navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.navigationPane1.Location = New System.Drawing.Point(1, 0)
            Me.navigationPane1.Name = "navigationPane1"
            Me.navigationPane1.PageProperties.AppearanceCaption.Options.UseTextOptions = True
            Me.navigationPane1.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.navigationPage1})
            Me.navigationPane1.RegularSize = New System.Drawing.Size(249, 450)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            Me.navigationPane1.Size = New System.Drawing.Size(249, 450)
            Me.navigationPane1.TabIndex = 8
            Me.navigationPane1.Text = "navigationPane1"
            ' 
            ' navigationPage1
            ' 
            Me.navigationPage1.Caption = "Options"
            Me.navigationPage1.Controls.Add(Me.layoutControl1)
            Me.navigationPage1.Name = "navigationPage1"
            Me.navigationPage1.Size = New System.Drawing.Size(249, 417)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.ceShowConditionalFormattingItem)
            Me.layoutControl1.Controls.Add(Me.trackBarControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1084, 408, 450, 350)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(249, 417)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' ceShowConditionalFormattingItem
            ' 
            Me.ceShowConditionalFormattingItem.Location = New System.Drawing.Point(10, 10)
            Me.ceShowConditionalFormattingItem.Name = "ceShowConditionalFormattingItem"
            Me.ceShowConditionalFormattingItem.Properties.Caption = "Show Conditional Formatting Menu"
            Me.ceShowConditionalFormattingItem.Size = New System.Drawing.Size(229, 20)
            Me.ceShowConditionalFormattingItem.StyleController = Me.layoutControl1
            Me.ceShowConditionalFormattingItem.TabIndex = 0
            AddHandler Me.ceShowConditionalFormattingItem.CheckedChanged, New System.EventHandler(AddressOf Me.checkEdit1_CheckedChanged)
            ' 
            ' trackBarControl1
            ' 
            Me.trackBarControl1.EditValue = Nothing
            Me.trackBarControl1.Location = New System.Drawing.Point(12, 74)
            Me.trackBarControl1.Name = "trackBarControl1"
            Me.trackBarControl1.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.trackBarControl1.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.trackBarControl1.Size = New System.Drawing.Size(225, 45)
            Me.trackBarControl1.StyleController = Me.layoutControl1
            Me.trackBarControl1.TabIndex = 2
            AddHandler Me.trackBarControl1.EditValueChanged, New System.EventHandler(AddressOf Me.trackBarControl1_EditValueChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem3, Me.layoutControlGroup2, Me.layoutControlItem2})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(249, 417)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 131)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(249, 286)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 40)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(249, 91)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "Speed of change"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.trackBarControl1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(229, 49)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.ceShowConditionalFormattingItem
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10)
            Me.layoutControlItem2.Size = New System.Drawing.Size(249, 40)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' DataUpdateRules
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "DataUpdateRules"
            Me.Size = New System.Drawing.Size(957, 450)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemProgressBar1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.navigationPage1.ResumeLayout(False)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.ceShowConditionalFormattingItem.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.trackBarControl1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.trackBarControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dateTimeChartRangeControlClient1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private Ticker As DevExpress.XtraGrid.Columns.GridColumn

        Private Last As DevExpress.XtraGrid.Columns.GridColumn

        Private Chg As DevExpress.XtraGrid.Columns.GridColumn

        Private ChgPercent As DevExpress.XtraGrid.Columns.GridColumn

        Private Open As DevExpress.XtraGrid.Columns.GridColumn

        Private High As DevExpress.XtraGrid.Columns.GridColumn

        Private Low As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private navigationPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private navigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private trackBarControl1 As DevExpress.XtraEditors.TrackBarControl

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private dateTimeChartRangeControlClient1 As DevExpress.XtraEditors.DateTimeChartRangeControlClient

        Private ceShowConditionalFormattingItem As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
