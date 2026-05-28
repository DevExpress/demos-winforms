Namespace DevExpress.XtraGrid.Demos

    Partial Class Grid100000Records

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.Grid100000Records))
            Dim unboundSourceProperty1 As DevExpress.Data.UnboundSourceProperty = New DevExpress.Data.UnboundSourceProperty()
            Dim unboundSourceProperty2 As DevExpress.Data.UnboundSourceProperty = New DevExpress.Data.UnboundSourceProperty()
            Dim unboundSourceProperty3 As DevExpress.Data.UnboundSourceProperty = New DevExpress.Data.UnboundSourceProperty()
            Dim unboundSourceProperty4 As DevExpress.Data.UnboundSourceProperty = New DevExpress.Data.UnboundSourceProperty()
            Dim unboundSourceProperty5 As DevExpress.Data.UnboundSourceProperty = New DevExpress.Data.UnboundSourceProperty()
            Dim unboundSourceProperty6 As DevExpress.Data.UnboundSourceProperty = New DevExpress.Data.UnboundSourceProperty()
            Me.colclnCurrency = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.unboundSource = New DevExpress.Data.UnboundSource(Me.components)
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colclnId = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colclnDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colclnWord = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colclnBool = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colclnText = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.sbGenerate = New DevExpress.XtraEditors.SimpleButton()
            Me.ceCustom = New DevExpress.XtraEditors.CheckEdit()
            Me.ceRecord3 = New DevExpress.XtraEditors.CheckEdit()
            Me.ceRecord2 = New DevExpress.XtraEditors.CheckEdit()
            Me.ceRecord1 = New DevExpress.XtraEditors.CheckEdit()
            Me.seCustomRecordsCount = New DevExpress.XtraEditors.SpinEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.unboundSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.ceCustom.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceRecord3.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceRecord2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceRecord1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seCustomRecordsCount.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' colclnCurrency
            ' 
            resources.ApplyResources(Me.colclnCurrency, "colclnCurrency")
            Me.colclnCurrency.ColumnEdit = Me.repositoryItemTextEdit1
            Me.colclnCurrency.FieldName = "Currency"
            Me.colclnCurrency.Name = "colclnCurrency"
            Me.colclnCurrency.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
            Me.colclnCurrency.OptionsColumn.[ReadOnly] = True
            ' 
            ' repositoryItemTextEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemTextEdit1, "repositoryItemTextEdit1")
            Me.repositoryItemTextEdit1.DisplayFormat.FormatString = "c"
            Me.repositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.repositoryItemTextEdit1.EditFormat.FormatString = "c"
            Me.repositoryItemTextEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.gridControl1.DataSource = Me.unboundSource
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemTextEdit1})
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' unboundSource
            ' 
            unboundSourceProperty1.DisplayName = Nothing
            unboundSourceProperty1.Name = "Id"
            unboundSourceProperty1.PropertyType = GetType(Integer)
            unboundSourceProperty2.DisplayName = Nothing
            unboundSourceProperty2.Name = "Word"
            unboundSourceProperty2.PropertyType = GetType(String)
            unboundSourceProperty3.DisplayName = Nothing
            unboundSourceProperty3.Name = "Text"
            unboundSourceProperty3.PropertyType = GetType(String)
            unboundSourceProperty4.DisplayName = Nothing
            unboundSourceProperty4.Name = "Date"
            unboundSourceProperty4.PropertyType = GetType(System.DateTime)
            unboundSourceProperty5.DisplayName = Nothing
            unboundSourceProperty5.Name = "Currency"
            unboundSourceProperty5.PropertyType = GetType(Decimal)
            unboundSourceProperty6.DisplayName = Nothing
            unboundSourceProperty6.Name = "Bool"
            unboundSourceProperty6.PropertyType = GetType(Boolean)
            Me.unboundSource.Properties.Add(unboundSourceProperty1)
            Me.unboundSource.Properties.Add(unboundSourceProperty2)
            Me.unboundSource.Properties.Add(unboundSourceProperty3)
            Me.unboundSource.Properties.Add(unboundSourceProperty4)
            Me.unboundSource.Properties.Add(unboundSourceProperty5)
            Me.unboundSource.Properties.Add(unboundSourceProperty6)
            AddHandler Me.unboundSource.ValueNeeded, New System.EventHandler(Of DevExpress.Data.UnboundSourceValueNeededEventArgs)(AddressOf Me.unboundSource_ValueNeeded)
            ' 
            ' gridView1
            ' 
            Me.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colclnId, Me.colclnDate, Me.colclnWord, Me.colclnBool, Me.colclnText, Me.colclnCurrency})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("gridView1.GroupSummary")), DevExpress.Data.SummaryItemType), resources.GetString("gridView1.GroupSummary1"), CType((resources.GetObject("gridView1.GroupSummary2")), DevExpress.XtraGrid.Columns.GridColumn), resources.GetString("gridView1.GroupSummary3"))})
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView1.OptionsView.BestFitMaxRowCount = 20
            Me.gridView1.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Standard
            Me.gridView1.OptionsView.ShowFooter = True
            ' 
            ' colclnId
            ' 
            resources.ApplyResources(Me.colclnId, "colclnId")
            Me.colclnId.FieldName = "Id"
            Me.colclnId.Name = "colclnId"
            Me.colclnId.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
            Me.colclnId.OptionsColumn.[ReadOnly] = True
            Me.colclnId.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("colclnId.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("colclnId.Summary1"), resources.GetString("colclnId.Summary2"))})
            ' 
            ' colclnDate
            ' 
            resources.ApplyResources(Me.colclnDate, "colclnDate")
            Me.colclnDate.FieldName = "Date"
            Me.colclnDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Date]
            Me.colclnDate.Name = "colclnDate"
            Me.colclnDate.OptionsColumn.[ReadOnly] = True
            ' 
            ' colclnWord
            ' 
            resources.ApplyResources(Me.colclnWord, "colclnWord")
            Me.colclnWord.FieldName = "Word"
            Me.colclnWord.Name = "colclnWord"
            Me.colclnWord.OptionsColumn.[ReadOnly] = True
            ' 
            ' colclnBool
            ' 
            resources.ApplyResources(Me.colclnBool, "colclnBool")
            Me.colclnBool.FieldName = "Bool"
            Me.colclnBool.Name = "colclnBool"
            Me.colclnBool.OptionsColumn.[ReadOnly] = True
            ' 
            ' colclnText
            ' 
            resources.ApplyResources(Me.colclnText, "colclnText")
            Me.colclnText.FieldName = "Text"
            Me.colclnText.Name = "colclnText"
            Me.colclnText.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
            Me.colclnText.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            Me.colclnText.OptionsColumn.[ReadOnly] = True
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.navigationPane1)
            resources.ApplyResources(Me.sidePanel1, "sidePanel1")
            Me.sidePanel1.Name = "sidePanel1"
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.Controls.Add(Me.navigationPage1)
            resources.ApplyResources(Me.navigationPane1, "navigationPane1")
            Me.navigationPane1.Name = "navigationPane1"
            Me.navigationPane1.PageProperties.AppearanceCaption.Options.UseTextOptions = True
            Me.navigationPane1.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.navigationPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text
            Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.navigationPage1})
            Me.navigationPane1.RegularSize = New System.Drawing.Size(249, 464)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            ' 
            ' navigationPage1
            ' 
            resources.ApplyResources(Me.navigationPage1, "navigationPage1")
            Me.navigationPage1.Controls.Add(Me.layoutControl1)
            Me.navigationPage1.Name = "navigationPage1"
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.sbGenerate)
            Me.layoutControl1.Controls.Add(Me.ceCustom)
            Me.layoutControl1.Controls.Add(Me.ceRecord3)
            Me.layoutControl1.Controls.Add(Me.ceRecord2)
            Me.layoutControl1.Controls.Add(Me.ceRecord1)
            Me.layoutControl1.Controls.Add(Me.seCustomRecordsCount)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(880, 335, 650, 400)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            ' 
            ' sbGenerate
            ' 
            resources.ApplyResources(Me.sbGenerate, "sbGenerate")
            Me.sbGenerate.Name = "sbGenerate"
            Me.sbGenerate.StyleController = Me.layoutControl1
            AddHandler Me.sbGenerate.Click, New System.EventHandler(AddressOf Me.sbGenerate_Click)
            ' 
            ' ceCustom
            ' 
            resources.ApplyResources(Me.ceCustom, "ceCustom")
            Me.ceCustom.Name = "ceCustom"
            Me.ceCustom.Properties.Caption = resources.GetString("ceCustom.Properties.Caption")
            Me.ceCustom.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio
            Me.ceCustom.Properties.RadioGroupIndex = 0
            Me.ceCustom.StyleController = Me.layoutControl1
            Me.ceCustom.TabStop = False
            AddHandler Me.ceCustom.CheckedChanged, New System.EventHandler(AddressOf Me.ceRecord_CheckedChanged)
            ' 
            ' ceRecord3
            ' 
            resources.ApplyResources(Me.ceRecord3, "ceRecord3")
            Me.ceRecord3.Name = "ceRecord3"
            Me.ceRecord3.Properties.Caption = resources.GetString("ceRecord3.Properties.Caption")
            Me.ceRecord3.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio
            Me.ceRecord3.Properties.RadioGroupIndex = 0
            Me.ceRecord3.StyleController = Me.layoutControl1
            Me.ceRecord3.TabStop = False
            AddHandler Me.ceRecord3.CheckedChanged, New System.EventHandler(AddressOf Me.ceRecord_CheckedChanged)
            ' 
            ' ceRecord2
            ' 
            resources.ApplyResources(Me.ceRecord2, "ceRecord2")
            Me.ceRecord2.Name = "ceRecord2"
            Me.ceRecord2.Properties.Caption = resources.GetString("ceRecord2.Properties.Caption")
            Me.ceRecord2.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio
            Me.ceRecord2.Properties.RadioGroupIndex = 0
            Me.ceRecord2.StyleController = Me.layoutControl1
            Me.ceRecord2.TabStop = False
            AddHandler Me.ceRecord2.CheckedChanged, New System.EventHandler(AddressOf Me.ceRecord_CheckedChanged)
            ' 
            ' ceRecord1
            ' 
            resources.ApplyResources(Me.ceRecord1, "ceRecord1")
            Me.ceRecord1.Name = "ceRecord1"
            Me.ceRecord1.Properties.Caption = resources.GetString("ceRecord1.Properties.Caption")
            Me.ceRecord1.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio
            Me.ceRecord1.Properties.RadioGroupIndex = 0
            Me.ceRecord1.StyleController = Me.layoutControl1
            AddHandler Me.ceRecord1.CheckedChanged, New System.EventHandler(AddressOf Me.ceRecord_CheckedChanged)
            ' 
            ' seCustomRecordsCount
            ' 
            resources.ApplyResources(Me.seCustomRecordsCount, "seCustomRecordsCount")
            Me.seCustomRecordsCount.Name = "seCustomRecordsCount"
            Me.seCustomRecordsCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("seCustomRecordsCount.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.seCustomRecordsCount.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.seCustomRecordsCount.Properties.Increment = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seCustomRecordsCount.Properties.IsFloatValue = False
            Me.seCustomRecordsCount.Properties.Mask.EditMask = resources.GetString("seCustomRecordsCount.Properties.Mask.EditMask")
            Me.seCustomRecordsCount.Properties.Mask.UseMaskAsDisplayFormat =(CBool((resources.GetObject("seCustomRecordsCount.Properties.Mask.UseMaskAsDisplayFormat"))))
            Me.seCustomRecordsCount.Properties.MaxValue = New Decimal(New Integer() {7000000, 0, 0, 0})
            Me.seCustomRecordsCount.StyleController = Me.layoutControl1
            AddHandler Me.seCustomRecordsCount.EditValueChanged, New System.EventHandler(AddressOf Me.seCustomRecordsCount_EditValueChanged)
            AddHandler Me.seCustomRecordsCount.Enter, New System.EventHandler(AddressOf Me.seCustomRecordsCount_Enter)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem2, Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(249, 431)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 122)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(239, 309)
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.ceRecord1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(239, 24)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.ceRecord2
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(239, 24)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.ceRecord3
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(239, 24)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.ceCustom
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(239, 24)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.seCustomRecordsCount
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 96)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 10, 2, 2)
            Me.layoutControlItem5.Size = New System.Drawing.Size(160, 26)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.sbGenerate
            Me.layoutControlItem6.Location = New System.Drawing.Point(160, 96)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 10, 2, 2)
            Me.layoutControlItem6.Size = New System.Drawing.Size(79, 26)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' Grid100000Records
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "Grid100000Records"
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.unboundSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.navigationPage1.ResumeLayout(False)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.ceCustom.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceRecord3.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceRecord2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceRecord1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seCustomRecordsCount.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private colclnId As DevExpress.XtraGrid.Columns.GridColumn

        Private colclnWord As DevExpress.XtraGrid.Columns.GridColumn

        Private colclnText As DevExpress.XtraGrid.Columns.GridColumn

        Private colclnDate As DevExpress.XtraGrid.Columns.GridColumn

        Private colclnCurrency As DevExpress.XtraGrid.Columns.GridColumn

        Private colclnBool As DevExpress.XtraGrid.Columns.GridColumn

        Private components As System.ComponentModel.IContainer = Nothing

        Private unboundSource As DevExpress.Data.UnboundSource

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private navigationPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private navigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private ceCustom As DevExpress.XtraEditors.CheckEdit

        Private ceRecord3 As DevExpress.XtraEditors.CheckEdit

        Private ceRecord2 As DevExpress.XtraEditors.CheckEdit

        Private ceRecord1 As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private seCustomRecordsCount As DevExpress.XtraEditors.SpinEdit

        Private sbGenerate As DevExpress.XtraEditors.SimpleButton

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    End Class
End Namespace
