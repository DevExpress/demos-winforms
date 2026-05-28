Namespace DevExpress.XtraGrid.Demos

    Partial Class CellSelection

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.CellSelection))
            Dim styleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
            Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colContactName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colContactTitle = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRegion = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.colPostalCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPhone = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFax = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.icbSelectMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.icbTranslucentColors = New DevExpress.XtraEditors.CheckEdit()
            Me.sbRecords = New DevExpress.XtraEditors.SimpleButton()
            Me.ceMultiSelect = New DevExpress.XtraEditors.CheckEdit()
            Me.ceMultiCellEdit = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.behaviorManager = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
            CType((Me.repositoryItemComboBox2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbSelectMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.icbTranslucentColors.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceMultiSelect.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceMultiCellEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.sidePanel1.SuspendLayout()
            CType((Me.behaviorManager), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' colCountry
            ' 
            resources.ApplyResources(Me.colCountry, "colCountry")
            Me.colCountry.ColumnEdit = Me.repositoryItemComboBox2
            Me.colCountry.FieldName = "Country"
            Me.colCountry.Name = "colCountry"
            ' 
            ' repositoryItemComboBox2
            ' 
            resources.ApplyResources(Me.repositoryItemComboBox2, "repositoryItemComboBox2")
            Me.repositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemComboBox2.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemComboBox2.Items.AddRange(New Object() {resources.GetString("repositoryItemComboBox2.Items"), resources.GetString("repositoryItemComboBox2.Items1"), resources.GetString("repositoryItemComboBox2.Items2"), resources.GetString("repositoryItemComboBox2.Items3"), resources.GetString("repositoryItemComboBox2.Items4"), resources.GetString("repositoryItemComboBox2.Items5"), resources.GetString("repositoryItemComboBox2.Items6"), resources.GetString("repositoryItemComboBox2.Items7"), resources.GetString("repositoryItemComboBox2.Items8"), resources.GetString("repositoryItemComboBox2.Items9"), resources.GetString("repositoryItemComboBox2.Items10"), resources.GetString("repositoryItemComboBox2.Items11"), resources.GetString("repositoryItemComboBox2.Items12"), resources.GetString("repositoryItemComboBox2.Items13"), resources.GetString("repositoryItemComboBox2.Items14"), resources.GetString("repositoryItemComboBox2.Items15"), resources.GetString("repositoryItemComboBox2.Items16"), resources.GetString("repositoryItemComboBox2.Items17"), resources.GetString("repositoryItemComboBox2.Items18"), resources.GetString("repositoryItemComboBox2.Items19"), resources.GetString("repositoryItemComboBox2.Items20")})
            Me.repositoryItemComboBox2.Name = "repositoryItemComboBox2"
            ' 
            ' gridControl1
            ' 
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemComboBox1, Me.repositoryItemComboBox2})
            Me.gridControl1.ShowOnlyPredefinedDetails = True
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.behaviorManager.SetBehaviors(Me.gridView1, New DevExpress.Utils.Behaviors.Behavior() {CType((DevExpress.Utils.Behaviors.Common.MultiCellEditBehavior.Create(GetType(DevExpress.XtraGrid.Extensions.MultiCellEditGridViewSource))), DevExpress.Utils.Behaviors.Behavior)})
            Me.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCustomerID, Me.colCompanyName, Me.colContactName, Me.colContactTitle, Me.colAddress, Me.colCity, Me.colRegion, Me.colPostalCode, Me.colCountry, Me.colPhone, Me.colFax})
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((255)))))), (CInt(((CByte((128)))))))
            styleFormatCondition1.Appearance.BackColor2 = CType((resources.GetObject("resource.BackColor2")), System.Drawing.Color)
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Black
            styleFormatCondition1.Appearance.GradientMode = CType((resources.GetObject("resource.GradientMode")), System.Drawing.Drawing2D.LinearGradientMode)
            styleFormatCondition1.Appearance.Options.UseBackColor = True
            styleFormatCondition1.Appearance.Options.UseForeColor = True
            styleFormatCondition1.Column = Me.colCountry
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Between
            styleFormatCondition1.Value1 = "U"
            styleFormatCondition1.Value2 = "V"
            Me.gridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {styleFormatCondition1})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.HorzScrollStep = 30
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView1.OptionsSelection.MultiSelect = True
            Me.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
            Me.gridView1.OptionsView.ColumnAutoWidth = False
            Me.gridView1.OptionsView.ShowGroupPanel = False
            AddHandler Me.gridView1.SelectionChanged, New DevExpress.Data.SelectionChangedEventHandler(AddressOf Me.gridView1_SelectionChanged)
            ' 
            ' colCustomerID
            ' 
            resources.ApplyResources(Me.colCustomerID, "colCustomerID")
            Me.colCustomerID.FieldName = "CustomerID"
            Me.colCustomerID.Name = "colCustomerID"
            Me.colCustomerID.OptionsFilter.AllowFilter = False
            ' 
            ' colCompanyName
            ' 
            resources.ApplyResources(Me.colCompanyName, "colCompanyName")
            Me.colCompanyName.FieldName = "CompanyName"
            Me.colCompanyName.Name = "colCompanyName"
            Me.colCompanyName.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("colCompanyName.Summary")), DevExpress.Data.SummaryItemType))})
            ' 
            ' colContactName
            ' 
            resources.ApplyResources(Me.colContactName, "colContactName")
            Me.colContactName.FieldName = "ContactName"
            Me.colContactName.ImageOptions.SvgImage = CType((resources.GetObject("colContactName.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.colContactName.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.colContactName.Name = "colContactName"
            ' 
            ' colContactTitle
            ' 
            resources.ApplyResources(Me.colContactTitle, "colContactTitle")
            Me.colContactTitle.FieldName = "ContactTitle"
            Me.colContactTitle.Name = "colContactTitle"
            ' 
            ' colAddress
            ' 
            resources.ApplyResources(Me.colAddress, "colAddress")
            Me.colAddress.FieldName = "Address"
            Me.colAddress.ImageOptions.SvgImage = CType((resources.GetObject("colAddress.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.colAddress.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.colAddress.Name = "colAddress"
            ' 
            ' colCity
            ' 
            resources.ApplyResources(Me.colCity, "colCity")
            Me.colCity.FieldName = "City"
            Me.colCity.Name = "colCity"
            ' 
            ' colRegion
            ' 
            resources.ApplyResources(Me.colRegion, "colRegion")
            Me.colRegion.ColumnEdit = Me.repositoryItemComboBox1
            Me.colRegion.FieldName = "Region"
            Me.colRegion.Name = "colRegion"
            ' 
            ' repositoryItemComboBox1
            ' 
            resources.ApplyResources(Me.repositoryItemComboBox1, "repositoryItemComboBox1")
            Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemComboBox1.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemComboBox1.Items.AddRange(New Object() {resources.GetString("repositoryItemComboBox1.Items"), resources.GetString("repositoryItemComboBox1.Items1"), resources.GetString("repositoryItemComboBox1.Items2"), resources.GetString("repositoryItemComboBox1.Items3"), resources.GetString("repositoryItemComboBox1.Items4"), resources.GetString("repositoryItemComboBox1.Items5"), resources.GetString("repositoryItemComboBox1.Items6"), resources.GetString("repositoryItemComboBox1.Items7"), resources.GetString("repositoryItemComboBox1.Items8"), resources.GetString("repositoryItemComboBox1.Items9"), resources.GetString("repositoryItemComboBox1.Items10"), resources.GetString("repositoryItemComboBox1.Items11"), resources.GetString("repositoryItemComboBox1.Items12"), resources.GetString("repositoryItemComboBox1.Items13"), resources.GetString("repositoryItemComboBox1.Items14"), resources.GetString("repositoryItemComboBox1.Items15"), resources.GetString("repositoryItemComboBox1.Items16"), resources.GetString("repositoryItemComboBox1.Items17")})
            Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
            ' 
            ' colPostalCode
            ' 
            resources.ApplyResources(Me.colPostalCode, "colPostalCode")
            Me.colPostalCode.FieldName = "PostalCode"
            Me.colPostalCode.Name = "colPostalCode"
            ' 
            ' colPhone
            ' 
            resources.ApplyResources(Me.colPhone, "colPhone")
            Me.colPhone.FieldName = "Phone"
            Me.colPhone.Name = "colPhone"
            ' 
            ' colFax
            ' 
            resources.ApplyResources(Me.colFax, "colFax")
            Me.colFax.FieldName = "Fax"
            Me.colFax.Name = "colFax"
            ' 
            ' icbSelectMode
            ' 
            resources.ApplyResources(Me.icbSelectMode, "icbSelectMode")
            Me.icbSelectMode.Name = "icbSelectMode"
            Me.icbSelectMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("icbSelectMode.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.icbSelectMode.StyleController = Me.layoutControl1
            AddHandler Me.icbSelectMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbSelectMode_SelectedIndexChanged)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.icbTranslucentColors)
            Me.layoutControl1.Controls.Add(Me.sbRecords)
            Me.layoutControl1.Controls.Add(Me.icbSelectMode)
            Me.layoutControl1.Controls.Add(Me.ceMultiSelect)
            Me.layoutControl1.Controls.Add(Me.ceMultiCellEdit)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1032, 180, 726, 758)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            ' 
            ' icbTranslucentColors
            ' 
            resources.ApplyResources(Me.icbTranslucentColors, "icbTranslucentColors")
            Me.icbTranslucentColors.Name = "icbTranslucentColors"
            Me.icbTranslucentColors.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[True]
            Me.icbTranslucentColors.Properties.Appearance.Options.UseTextOptions = True
            Me.icbTranslucentColors.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.icbTranslucentColors.Properties.Caption = resources.GetString("icbTranslucentColors.Properties.Caption")
            Me.icbTranslucentColors.StyleController = Me.layoutControl1
            AddHandler Me.icbTranslucentColors.CheckedChanged, New System.EventHandler(AddressOf Me.icbTranslucentColors_CheckedChanged)
            ' 
            ' sbRecords
            ' 
            resources.ApplyResources(Me.sbRecords, "sbRecords")
            Me.sbRecords.Name = "sbRecords"
            Me.sbRecords.StyleController = Me.layoutControl1
            AddHandler Me.sbRecords.Click, New System.EventHandler(AddressOf Me.sbRecords_Click)
            ' 
            ' ceMultiSelect
            ' 
            resources.ApplyResources(Me.ceMultiSelect, "ceMultiSelect")
            Me.ceMultiSelect.Name = "ceMultiSelect"
            Me.ceMultiSelect.Properties.Caption = resources.GetString("ceMultiSelect.Properties.Caption")
            Me.ceMultiSelect.StyleController = Me.layoutControl1
            AddHandler Me.ceMultiSelect.CheckedChanged, New System.EventHandler(AddressOf Me.ceMultiSelect_CheckedChanged)
            ' 
            ' ceMultiCellEdit
            ' 
            resources.ApplyResources(Me.ceMultiCellEdit, "ceMultiCellEdit")
            Me.ceMultiCellEdit.Name = "ceMultiCellEdit"
            Me.ceMultiCellEdit.Properties.Caption = resources.GetString("ceMultiCellEdit.Properties.Caption")
            Me.ceMultiCellEdit.StyleController = Me.layoutControl1
            AddHandler Me.ceMultiCellEdit.CheckedChanged, New System.EventHandler(AddressOf Me.ceMultiCellEdit_CheckedChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2, Me.layoutControlGroup3, Me.emptySpaceItem1})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(249, 440)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem5})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(249, 156)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            resources.ApplyResources(Me.layoutControlGroup2, "layoutControlGroup2")
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.ceMultiSelect
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 40)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.icbSelectMode
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(229, 40)
            resources.ApplyResources(Me.layoutControlItem2, "layoutControlItem2")
            Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(87, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.sbRecords
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 88)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(229, 26)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.ceMultiCellEdit
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 64)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem4})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 156)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(249, 89)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            resources.ApplyResources(Me.layoutControlGroup3, "layoutControlGroup3")
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.icbTranslucentColors
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(229, 47)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 245)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(249, 195)
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.Controls.Add(Me.navigationPage1)
            resources.ApplyResources(Me.navigationPane1, "navigationPane1")
            Me.navigationPane1.Name = "navigationPane1"
            Me.navigationPane1.PageProperties.AppearanceCaption.Options.UseTextOptions = True
            Me.navigationPane1.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.navigationPage1})
            Me.navigationPane1.RegularSize = New System.Drawing.Size(249, 473)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            ' 
            ' navigationPage1
            ' 
            resources.ApplyResources(Me.navigationPage1, "navigationPage1")
            Me.navigationPage1.Controls.Add(Me.layoutControl1)
            Me.navigationPage1.Name = "navigationPage1"
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.gridControl1)
            resources.ApplyResources(Me.panelControl1, "panelControl1")
            Me.panelControl1.Name = "panelControl1"
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.navigationPane1)
            resources.ApplyResources(Me.sidePanel1, "sidePanel1")
            Me.sidePanel1.Name = "sidePanel1"
            ' 
            ' CellSelection
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "CellSelection"
            CType((Me.repositoryItemComboBox2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbSelectMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.icbTranslucentColors.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceMultiSelect.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceMultiCellEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.navigationPage1.ResumeLayout(False)
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.behaviorManager), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer = Nothing

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn

        Private colCompanyName As DevExpress.XtraGrid.Columns.GridColumn

        Private colContactName As DevExpress.XtraGrid.Columns.GridColumn

        Private colContactTitle As DevExpress.XtraGrid.Columns.GridColumn

        Private colAddress As DevExpress.XtraGrid.Columns.GridColumn

        Private colCity As DevExpress.XtraGrid.Columns.GridColumn

        Private colRegion As DevExpress.XtraGrid.Columns.GridColumn

        Private colPostalCode As DevExpress.XtraGrid.Columns.GridColumn

        Private colCountry As DevExpress.XtraGrid.Columns.GridColumn

        Private colPhone As DevExpress.XtraGrid.Columns.GridColumn

        Private colFax As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox

        Private repositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox

        Private sbRecords As DevExpress.XtraEditors.SimpleButton

        Private icbSelectMode As DevExpress.XtraEditors.ImageComboBoxEdit

        Private icbTranslucentColors As DevExpress.XtraEditors.CheckEdit

        Private ceMultiSelect As DevExpress.XtraEditors.CheckEdit

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private navigationPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private navigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private behaviorManager As DevExpress.Utils.Behaviors.BehaviorManager

        Private ceMultiCellEdit As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
