Namespace DevExpress.XtraGrid.Demos

    Partial Class RowHeight

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.RowHeight))
            Dim gridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
            Me.cardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
            Me.colFirstName1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLastName1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTitle1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTitleOfCourtesy1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.colBirthDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colHireDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colHomePhone1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNotes1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
            Me.colPhoto1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colBirthDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFirstName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colHireDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colHomePhone = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLastName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPhoto = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTitle = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTitleOfCourtesy = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.sbSwitching = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.cheAutoHeight = New DevExpress.XtraEditors.CheckEdit()
            Me.chePicture = New DevExpress.XtraEditors.CheckEdit()
            Me.cheMemo = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            CType((Me.cardView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemImageComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemMemoEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemPictureEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.cheAutoHeight.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chePicture.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cheMemo.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.sidePanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' cardView1
            ' 
            Me.cardView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            resources.ApplyResources(Me.cardView1, "cardView1")
            Me.cardView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFirstName1, Me.colLastName1, Me.colTitle1, Me.colTitleOfCourtesy1, Me.colBirthDate1, Me.colHireDate1, Me.colHomePhone1, Me.colNotes1, Me.colPhoto1})
            Me.cardView1.GridControl = Me.gridControl1
            Me.cardView1.MaximumCardColumns = 2
            Me.cardView1.Name = "cardView1"
            Me.cardView1.OptionsBehavior.AutoHorzWidth = True
            Me.cardView1.OptionsBehavior.FieldAutoHeight = True
            Me.cardView1.OptionsView.ShowLines = False
            Me.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto
            ' 
            ' colFirstName1
            ' 
            resources.ApplyResources(Me.colFirstName1, "colFirstName1")
            Me.colFirstName1.FieldName = "FirstName"
            Me.colFirstName1.Name = "colFirstName1"
            ' 
            ' colLastName1
            ' 
            resources.ApplyResources(Me.colLastName1, "colLastName1")
            Me.colLastName1.FieldName = "LastName"
            Me.colLastName1.Name = "colLastName1"
            ' 
            ' colTitle1
            ' 
            resources.ApplyResources(Me.colTitle1, "colTitle1")
            Me.colTitle1.FieldName = "Title"
            Me.colTitle1.Name = "colTitle1"
            ' 
            ' colTitleOfCourtesy1
            ' 
            resources.ApplyResources(Me.colTitleOfCourtesy1, "colTitleOfCourtesy1")
            Me.colTitleOfCourtesy1.ColumnEdit = Me.repositoryItemImageComboBox1
            Me.colTitleOfCourtesy1.FieldName = "TitleOfCourtesy"
            Me.colTitleOfCourtesy1.Name = "colTitleOfCourtesy1"
            ' 
            ' repositoryItemImageComboBox1
            ' 
            resources.ApplyResources(Me.repositoryItemImageComboBox1, "repositoryItemImageComboBox1")
            Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemImageComboBox1.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items"), resources.GetString("repositoryItemImageComboBox1.Items1"), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items2"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items3"), resources.GetString("repositoryItemImageComboBox1.Items4"), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items5"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items6"), resources.GetString("repositoryItemImageComboBox1.Items7"), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items8"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items9"), resources.GetString("repositoryItemImageComboBox1.Items10"), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items11"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items12"), resources.GetString("repositoryItemImageComboBox1.Items13"), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items14")))))})
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            Me.repositoryItemImageComboBox1.SmallImages = Me.svgImageCollection1
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("Doctor1", CType((resources.GetObject("svgImageCollection1.Doctor1")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Miss1", CType((resources.GetObject("svgImageCollection1.Miss1")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Mr1", CType((resources.GetObject("svgImageCollection1.Mr1")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Mrs1", CType((resources.GetObject("svgImageCollection1.Mrs1")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Ms1", CType((resources.GetObject("svgImageCollection1.Ms1")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' colBirthDate1
            ' 
            resources.ApplyResources(Me.colBirthDate1, "colBirthDate1")
            Me.colBirthDate1.FieldName = "BirthDate"
            Me.colBirthDate1.Name = "colBirthDate1"
            ' 
            ' colHireDate1
            ' 
            resources.ApplyResources(Me.colHireDate1, "colHireDate1")
            Me.colHireDate1.FieldName = "HireDate"
            Me.colHireDate1.Name = "colHireDate1"
            ' 
            ' colHomePhone1
            ' 
            resources.ApplyResources(Me.colHomePhone1, "colHomePhone1")
            Me.colHomePhone1.FieldName = "HomePhone"
            Me.colHomePhone1.Name = "colHomePhone1"
            ' 
            ' colNotes1
            ' 
            Me.colNotes1.AppearanceCell.Options.UseTextOptions = True
            Me.colNotes1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            resources.ApplyResources(Me.colNotes1, "colNotes1")
            Me.colNotes1.ColumnEdit = Me.repositoryItemMemoEdit1
            Me.colNotes1.FieldName = "Notes"
            Me.colNotes1.Name = "colNotes1"
            ' 
            ' repositoryItemMemoEdit1
            ' 
            Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
            ' 
            ' colPhoto1
            ' 
            resources.ApplyResources(Me.colPhoto1, "colPhoto1")
            Me.colPhoto1.ColumnEdit = Me.repositoryItemPictureEdit1
            Me.colPhoto1.FieldName = "Photo"
            Me.colPhoto1.Name = "colPhoto1"
            ' 
            ' repositoryItemPictureEdit1
            ' 
            Me.repositoryItemPictureEdit1.CustomHeight = 40
            Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
            Me.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
            ' 
            ' gridControl1
            ' 
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            gridLevelNode1.LevelTemplate = Me.cardView1
            gridLevelNode1.RelationName = "Card"
            Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {gridLevelNode1})
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemMemoEdit1, Me.repositoryItemPictureEdit1, Me.repositoryItemImageComboBox1})
            Me.gridControl1.ShowOnlyPredefinedDetails = True
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1, Me.cardView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBirthDate, Me.colFirstName, Me.colHireDate, Me.colHomePhone, Me.colLastName, Me.colNotes, Me.colPhoto, Me.colTitle, Me.colTitleOfCourtesy})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView1.OptionsView.RowAutoHeight = True
            Me.gridView1.OptionsView.ShowGroupPanel = False
            ' 
            ' colBirthDate
            ' 
            resources.ApplyResources(Me.colBirthDate, "colBirthDate")
            Me.colBirthDate.FieldName = "BirthDate"
            Me.colBirthDate.Name = "colBirthDate"
            ' 
            ' colFirstName
            ' 
            resources.ApplyResources(Me.colFirstName, "colFirstName")
            Me.colFirstName.FieldName = "FirstName"
            Me.colFirstName.Name = "colFirstName"
            ' 
            ' colHireDate
            ' 
            resources.ApplyResources(Me.colHireDate, "colHireDate")
            Me.colHireDate.FieldName = "HireDate"
            Me.colHireDate.Name = "colHireDate"
            ' 
            ' colHomePhone
            ' 
            resources.ApplyResources(Me.colHomePhone, "colHomePhone")
            Me.colHomePhone.FieldName = "HomePhone"
            Me.colHomePhone.Name = "colHomePhone"
            ' 
            ' colLastName
            ' 
            resources.ApplyResources(Me.colLastName, "colLastName")
            Me.colLastName.FieldName = "LastName"
            Me.colLastName.Name = "colLastName"
            ' 
            ' colNotes
            ' 
            Me.colNotes.AppearanceCell.Options.UseTextOptions = True
            Me.colNotes.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            resources.ApplyResources(Me.colNotes, "colNotes")
            Me.colNotes.ColumnEdit = Me.repositoryItemMemoEdit1
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.OptionsFilter.AllowFilter = False
            ' 
            ' colPhoto
            ' 
            resources.ApplyResources(Me.colPhoto, "colPhoto")
            Me.colPhoto.ColumnEdit = Me.repositoryItemPictureEdit1
            Me.colPhoto.FieldName = "Photo"
            Me.colPhoto.Name = "colPhoto"
            Me.colPhoto.OptionsColumn.FixedWidth = True
            Me.colPhoto.OptionsFilter.AllowFilter = False
            ' 
            ' colTitle
            ' 
            resources.ApplyResources(Me.colTitle, "colTitle")
            Me.colTitle.FieldName = "Title"
            Me.colTitle.Name = "colTitle"
            ' 
            ' colTitleOfCourtesy
            ' 
            resources.ApplyResources(Me.colTitleOfCourtesy, "colTitleOfCourtesy")
            Me.colTitleOfCourtesy.ColumnEdit = Me.repositoryItemImageComboBox1
            Me.colTitleOfCourtesy.FieldName = "TitleOfCourtesy"
            Me.colTitleOfCourtesy.Name = "colTitleOfCourtesy"
            ' 
            ' sbSwitching
            ' 
            resources.ApplyResources(Me.sbSwitching, "sbSwitching")
            Me.sbSwitching.Name = "sbSwitching"
            Me.sbSwitching.StyleController = Me.layoutControl1
            AddHandler Me.sbSwitching.Click, New System.EventHandler(AddressOf Me.sbSwitching_Click)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.sbSwitching)
            Me.layoutControl1.Controls.Add(Me.cheAutoHeight)
            Me.layoutControl1.Controls.Add(Me.chePicture)
            Me.layoutControl1.Controls.Add(Me.cheMemo)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1032, 180, 679, 599)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            ' 
            ' cheAutoHeight
            ' 
            resources.ApplyResources(Me.cheAutoHeight, "cheAutoHeight")
            Me.cheAutoHeight.Name = "cheAutoHeight"
            Me.cheAutoHeight.Properties.Caption = resources.GetString("cheAutoHeight.Properties.Caption")
            Me.cheAutoHeight.StyleController = Me.layoutControl1
            AddHandler Me.cheAutoHeight.CheckedChanged, New System.EventHandler(AddressOf Me.chbAutoHeight_CheckedChanged)
            ' 
            ' chePicture
            ' 
            resources.ApplyResources(Me.chePicture, "chePicture")
            Me.chePicture.Name = "chePicture"
            Me.chePicture.Properties.Caption = resources.GetString("chePicture.Properties.Caption")
            Me.chePicture.StyleController = Me.layoutControl1
            AddHandler Me.chePicture.CheckedChanged, New System.EventHandler(AddressOf Me.chbPicture_CheckedChanged)
            ' 
            ' cheMemo
            ' 
            resources.ApplyResources(Me.cheMemo, "cheMemo")
            Me.cheMemo.Name = "cheMemo"
            Me.cheMemo.Properties.Caption = resources.GetString("cheMemo.Properties.Caption")
            Me.cheMemo.StyleController = Me.layoutControl1
            AddHandler Me.cheMemo.CheckedChanged, New System.EventHandler(AddressOf Me.chbMemo_CheckedChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2, Me.layoutControlGroup3, Me.emptySpaceItem1})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(249, 448)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(249, 114)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            resources.ApplyResources(Me.layoutControlGroup2, "layoutControlGroup2")
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.cheAutoHeight
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.cheMemo
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.chePicture
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem4})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 114)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(249, 68)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            resources.ApplyResources(Me.layoutControlGroup3, "layoutControlGroup3")
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.sbSwitching
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(229, 26)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 182)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(249, 266)
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.Controls.Add(Me.navigationPage1)
            resources.ApplyResources(Me.navigationPane1, "navigationPane1")
            Me.navigationPane1.Name = "navigationPane1"
            Me.navigationPane1.PageProperties.AppearanceCaption.Options.UseTextOptions = True
            Me.navigationPane1.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.navigationPage1})
            Me.navigationPane1.RegularSize = New System.Drawing.Size(249, 481)
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
            ' RowHeight
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "RowHeight"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.RowHeight_Load)
            CType((Me.cardView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemImageComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemMemoEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemPictureEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.cheAutoHeight.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chePicture.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cheMemo.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.navigationPage1.ResumeLayout(False)
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.sidePanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private colHireDate As DevExpress.XtraGrid.Columns.GridColumn

        Private colHomePhone As DevExpress.XtraGrid.Columns.GridColumn

        Private colBirthDate As DevExpress.XtraGrid.Columns.GridColumn

        Private colTitle As DevExpress.XtraGrid.Columns.GridColumn

        Private colTitleOfCourtesy As DevExpress.XtraGrid.Columns.GridColumn

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private colFirstName As DevExpress.XtraGrid.Columns.GridColumn

        Private colLastName As DevExpress.XtraGrid.Columns.GridColumn

        Private colNotes As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit

        Private colPhoto As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit

        Private cardView1 As DevExpress.XtraGrid.Views.Card.CardView

        Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox

        Private colFirstName1 As DevExpress.XtraGrid.Columns.GridColumn

        Private colLastName1 As DevExpress.XtraGrid.Columns.GridColumn

        Private colTitle1 As DevExpress.XtraGrid.Columns.GridColumn

        Private colTitleOfCourtesy1 As DevExpress.XtraGrid.Columns.GridColumn

        Private colBirthDate1 As DevExpress.XtraGrid.Columns.GridColumn

        Private colHireDate1 As DevExpress.XtraGrid.Columns.GridColumn

        Private colHomePhone1 As DevExpress.XtraGrid.Columns.GridColumn

        Private colNotes1 As DevExpress.XtraGrid.Columns.GridColumn

        Private colPhoto1 As DevExpress.XtraGrid.Columns.GridColumn

        Private cheAutoHeight As DevExpress.XtraEditors.CheckEdit

        Private cheMemo As DevExpress.XtraEditors.CheckEdit

        Private chePicture As DevExpress.XtraEditors.CheckEdit

        Private sbSwitching As DevExpress.XtraEditors.SimpleButton

        Private components As System.ComponentModel.IContainer

        Private navigationPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private navigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection
    End Class
End Namespace
