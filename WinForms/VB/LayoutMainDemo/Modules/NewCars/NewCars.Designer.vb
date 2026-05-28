Namespace DevExpress.XtraLayout.Demos

    Partial Class NewCars

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
            Dim buttonImageOptions1 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraLayout.Demos.NewCars))
            Dim tableRowDefinition1 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tileViewItemElement1 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tableRowDefinition2 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tileViewItemElement2 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Me.colLogo = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colName1 = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.layoutGridControl = New DevExpress.XtraGrid.GridControl()
            Me.modelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.vehiclesDataSet = New DevExpress.XtraLayout.Demos.VehiclesDataSet()
            Me.layoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
            Me.colPhoto = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
            Me.layoutViewField_colPhoto = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colCategoryID = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.repositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
            Me.categoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.repositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.layoutViewField_colCategoryID = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colName = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colName = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colTrademarkID = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.repositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
            Me.trademarkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.repositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.layoutViewField_colTrademarkID = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colPrice = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colPrice = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
            Me.Group1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.colorPickEdit1 = New DevExpress.XtraEditors.ColorPickEdit()
            Me.colorPickEdit2 = New DevExpress.XtraEditors.ColorPickEdit()
            Me.colorPickEdit3 = New DevExpress.XtraEditors.ColorPickEdit()
            Me.colorPickEdit4 = New DevExpress.XtraEditors.ColorPickEdit()
            Me.colorPickEdit5 = New DevExpress.XtraEditors.ColorPickEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.sidePanel2 = New DevExpress.XtraEditors.SidePanel()
            Me.dataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.cancelSimpleButton = New DevExpress.XtraEditors.SimpleButton()
            Me.deleteSimpleButton = New DevExpress.XtraEditors.SimpleButton()
            Me.saveSimpleButton = New DevExpress.XtraEditors.SimpleButton()
            Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
            Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
            Me.dateEdit1 = New DevExpress.XtraEditors.DateEdit()
            Me.calcEdit1 = New DevExpress.XtraEditors.CalcEdit()
            Me.textEdit2 = New DevExpress.XtraEditors.TextEdit()
            Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit()
            Me.textEdit4 = New DevExpress.XtraEditors.TextEdit()
            Me.textEdit3 = New DevExpress.XtraEditors.TextEdit()
            Me.spinEdit3 = New DevExpress.XtraEditors.SpinEdit()
            Me.spinEdit4 = New DevExpress.XtraEditors.SpinEdit()
            Me.spinEdit2 = New DevExpress.XtraEditors.SpinEdit()
            Me.textEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
            Me.textEdit1View = New DevExpress.XtraGrid.Views.Tile.TileView()
            Me.colID = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.tileViewColumn1 = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colSite = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colDescription = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.imageComboBoxEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
            Me.imageComboBoxEdit1View = New DevExpress.XtraGrid.Views.Tile.TileView()
            Me.colID1 = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colPicture = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.checkEdit2 = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.item0 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.item1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.tabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
            Me.perfomanceLayoutGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.descriptionLayoutGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.item3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            CType((Me.layoutGridControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.modelBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.vehiclesDataSet), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemPictureEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colPhoto), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemGridLookUpEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.categoryBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemGridLookUpEdit1View), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colCategoryID), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colName), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemGridLookUpEdit2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.trademarkBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemGridLookUpEdit2View), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colTrademarkID), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colPrice), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewCard1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Group1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemCalcEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.colorPickEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.colorPickEdit2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.colorPickEdit3.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.colorPickEdit4.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.colorPickEdit5.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel2.SuspendLayout()
            CType((Me.dataLayoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dataLayoutControl1.SuspendLayout()
            CType((Me.memoEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pictureEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dateEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dateEdit1.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.calcEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEdit2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEdit4.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEdit3.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEdit3.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEdit4.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEdit2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEdit1View), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageComboBoxEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageComboBoxEdit1View), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEdit2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem17), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.item0), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.item1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem18), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tabbedControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.perfomanceLayoutGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem16), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem13), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem15), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.descriptionLayoutGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem14), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem22), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.item3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' colLogo
            ' 
            Me.colLogo.FieldName = "Logo"
            Me.colLogo.Name = "colLogo"
            Me.colLogo.Visible = True
            Me.colLogo.VisibleIndex = 3
            ' 
            ' colName1
            ' 
            Me.colName1.FieldName = "Name"
            Me.colName1.Name = "colName1"
            Me.colName1.Visible = True
            Me.colName1.VisibleIndex = 1
            ' 
            ' layoutGridControl
            ' 
            Me.layoutGridControl.DataSource = Me.modelBindingSource
            Me.layoutGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutGridControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutGridControl.MainView = Me.layoutView1
            Me.layoutGridControl.Name = "layoutGridControl"
            Me.layoutGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemGridLookUpEdit1, Me.repositoryItemGridLookUpEdit2, Me.repositoryItemPictureEdit1, Me.repositoryItemCalcEdit1})
            Me.layoutGridControl.Size = New System.Drawing.Size(319, 437)
            Me.layoutGridControl.TabIndex = 4
            Me.layoutGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.layoutView1})
            ' 
            ' modelBindingSource
            ' 
            Me.modelBindingSource.DataMember = "Model"
            Me.modelBindingSource.DataSource = Me.vehiclesDataSet
            Me.modelBindingSource.Sort = ""
            ' 
            ' vehiclesDataSet
            ' 
            Me.vehiclesDataSet.DataSetName = "VehiclesDataSet"
            Me.vehiclesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' layoutView1
            ' 
            Me.layoutView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.layoutView1.CardCaptionFormat = "{5}"
            Me.layoutView1.CardMinSize = New System.Drawing.Size(290, 130)
            Me.layoutView1.CardVertInterval = 4
            Me.layoutView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.colPhoto, Me.colCategoryID, Me.colName, Me.colTrademarkID, Me.colPrice})
            Me.layoutView1.GridControl = Me.layoutGridControl
            Me.layoutView1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_colTrademarkID})
            Me.layoutView1.Name = "layoutView1"
            Me.layoutView1.OptionsBehavior.Editable = False
            Me.layoutView1.OptionsBehavior.ScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto
            Me.layoutView1.OptionsCustomization.AllowFilter = False
            Me.layoutView1.OptionsCustomization.AllowSort = False
            Me.layoutView1.OptionsView.AllowHotTrackFields = False
            Me.layoutView1.OptionsView.CardArrangeRule = DevExpress.XtraGrid.Views.Layout.LayoutCardArrangeRule.AllowPartialCards
            Me.layoutView1.OptionsView.FocusRectStyle = DevExpress.XtraGrid.Views.Layout.FocusRectStyle.None
            Me.layoutView1.OptionsView.ShowCardExpandButton = False
            Me.layoutView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            Me.layoutView1.OptionsView.ShowHeaderPanel = False
            Me.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Column
            Me.layoutView1.TemplateCard = Me.layoutViewCard1
            AddHandler Me.layoutView1.CustomCardStyle, New DevExpress.XtraGrid.Views.Layout.Events.LayoutViewCardStyleEventHandler(AddressOf Me.layoutView1_CustomCardStyle)
            AddHandler Me.layoutView1.FocusedRowObjectChanged, New DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(AddressOf Me.layoutView1_FocusedRowObjectChanged)
            ' 
            ' colPhoto
            ' 
            Me.colPhoto.AppearanceCell.BackColor = System.Drawing.Color.White
            Me.colPhoto.AppearanceCell.Options.UseBackColor = True
            Me.colPhoto.ColumnEdit = Me.repositoryItemPictureEdit1
            Me.colPhoto.FieldName = "Photo"
            Me.colPhoto.LayoutViewField = Me.layoutViewField_colPhoto
            Me.colPhoto.Name = "colPhoto"
            ' 
            ' repositoryItemPictureEdit1
            ' 
            Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
            Me.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            ' 
            ' layoutViewField_colPhoto
            ' 
            Me.layoutViewField_colPhoto.EditorPreferredWidth = 158
            Me.layoutViewField_colPhoto.Location = New System.Drawing.Point(0, 0)
            Me.layoutViewField_colPhoto.MaxSize = New System.Drawing.Size(162, 92)
            Me.layoutViewField_colPhoto.MinSize = New System.Drawing.Size(162, 92)
            Me.layoutViewField_colPhoto.Name = "layoutViewField_colPhoto"
            Me.layoutViewField_colPhoto.Size = New System.Drawing.Size(162, 92)
            Me.layoutViewField_colPhoto.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutViewField_colPhoto.StartNewLine = True
            Me.layoutViewField_colPhoto.TextVisible = False
            ' 
            ' colCategoryID
            ' 
            Me.colCategoryID.ColumnEdit = Me.repositoryItemGridLookUpEdit1
            Me.colCategoryID.FieldName = "CategoryID"
            Me.colCategoryID.LayoutViewField = Me.layoutViewField_colCategoryID
            Me.colCategoryID.Name = "colCategoryID"
            ' 
            ' repositoryItemGridLookUpEdit1
            ' 
            Me.repositoryItemGridLookUpEdit1.AutoHeight = False
            Me.repositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemGridLookUpEdit1.DataSource = Me.categoryBindingSource
            Me.repositoryItemGridLookUpEdit1.DisplayMember = "Name"
            Me.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1"
            Me.repositoryItemGridLookUpEdit1.PopupView = Me.repositoryItemGridLookUpEdit1View
            Me.repositoryItemGridLookUpEdit1.ValueMember = "ID"
            ' 
            ' categoryBindingSource
            ' 
            Me.categoryBindingSource.DataMember = "Category"
            Me.categoryBindingSource.DataSource = Me.vehiclesDataSet
            Me.categoryBindingSource.Sort = ""
            ' 
            ' repositoryItemGridLookUpEdit1View
            ' 
            Me.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View"
            Me.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
            ' 
            ' layoutViewField_colCategoryID
            ' 
            Me.layoutViewField_colCategoryID.EditorPreferredWidth = 22
            Me.layoutViewField_colCategoryID.Location = New System.Drawing.Point(0, 24)
            Me.layoutViewField_colCategoryID.Name = "layoutViewField_colCategoryID"
            Me.layoutViewField_colCategoryID.Size = New System.Drawing.Size(26, 24)
            Me.layoutViewField_colCategoryID.TextVisible = False
            ' 
            ' colName
            ' 
            Me.colName.AppearanceCell.FontStyleDelta = System.Drawing.FontStyle.Bold
            Me.colName.AppearanceCell.Options.UseFont = True
            Me.colName.FieldName = "Name"
            Me.colName.LayoutViewField = Me.layoutViewField_colName
            Me.colName.Name = "colName"
            ' 
            ' layoutViewField_colName
            ' 
            Me.layoutViewField_colName.EditorPreferredWidth = 22
            Me.layoutViewField_colName.Location = New System.Drawing.Point(0, 0)
            Me.layoutViewField_colName.Name = "layoutViewField_colName"
            Me.layoutViewField_colName.Size = New System.Drawing.Size(26, 24)
            Me.layoutViewField_colName.TextVisible = False
            ' 
            ' colTrademarkID
            ' 
            Me.colTrademarkID.ColumnEdit = Me.repositoryItemGridLookUpEdit2
            Me.colTrademarkID.FieldName = "TrademarkID"
            Me.colTrademarkID.LayoutViewField = Me.layoutViewField_colTrademarkID
            Me.colTrademarkID.Name = "colTrademarkID"
            ' 
            ' repositoryItemGridLookUpEdit2
            ' 
            Me.repositoryItemGridLookUpEdit2.AutoHeight = False
            Me.repositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemGridLookUpEdit2.DataSource = Me.trademarkBindingSource
            Me.repositoryItemGridLookUpEdit2.DisplayMember = "Name"
            Me.repositoryItemGridLookUpEdit2.Name = "repositoryItemGridLookUpEdit2"
            Me.repositoryItemGridLookUpEdit2.PopupView = Me.repositoryItemGridLookUpEdit2View
            Me.repositoryItemGridLookUpEdit2.ValueMember = "ID"
            ' 
            ' trademarkBindingSource
            ' 
            Me.trademarkBindingSource.DataMember = "Trademark"
            Me.trademarkBindingSource.DataSource = Me.vehiclesDataSet
            Me.trademarkBindingSource.Sort = ""
            ' 
            ' repositoryItemGridLookUpEdit2View
            ' 
            Me.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View"
            Me.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = False
            ' 
            ' layoutViewField_colTrademarkID
            ' 
            Me.layoutViewField_colTrademarkID.EditorPreferredWidth = 15
            Me.layoutViewField_colTrademarkID.Location = New System.Drawing.Point(0, 0)
            Me.layoutViewField_colTrademarkID.Name = "layoutViewField_colTrademarkID"
            Me.layoutViewField_colTrademarkID.Size = New System.Drawing.Size(204, 92)
            Me.layoutViewField_colTrademarkID.TextVisible = False
            ' 
            ' colPrice
            ' 
            Me.colPrice.AppearanceCell.Options.UseTextOptions = True
            Me.colPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.colPrice.DisplayFormat.FormatString = "c"
            Me.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            Me.colPrice.FieldName = "Price"
            Me.colPrice.LayoutViewField = Me.layoutViewField_colPrice
            Me.colPrice.Name = "colPrice"
            ' 
            ' layoutViewField_colPrice
            ' 
            Me.layoutViewField_colPrice.EditorPreferredWidth = 22
            Me.layoutViewField_colPrice.Location = New System.Drawing.Point(0, 48)
            Me.layoutViewField_colPrice.Name = "layoutViewField_colPrice"
            Me.layoutViewField_colPrice.Size = New System.Drawing.Size(26, 24)
            Me.layoutViewField_colPrice.TextVisible = False
            ' 
            ' layoutViewCard1
            ' 
            Me.layoutViewCard1.CustomizationFormText = "TemplateCard"
            Me.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
            Me.layoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.Group1, Me.layoutViewField_colPhoto})
            Me.layoutViewCard1.Name = "layoutViewTemplateCard"
            Me.layoutViewCard1.OptionsItemText.TextToControlDistance = 5
            Me.layoutViewCard1.Text = "TemplateCard"
            ' 
            ' Group1
            ' 
            Me.Group1.CustomizationFormText = "Group1"
            Me.Group1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Group1.GroupBordersVisible = False
            Me.Group1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_colPrice, Me.layoutViewField_colCategoryID, Me.layoutViewField_colName})
            Me.Group1.Location = New System.Drawing.Point(162, 0)
            Me.Group1.Name = "Group1"
            Me.Group1.Padding = New DevExpress.XtraLayout.Utils.Padding(6, 0, 8, 8)
            Me.Group1.Size = New System.Drawing.Size(36, 92)
            ' 
            ' repositoryItemCalcEdit1
            ' 
            Me.repositoryItemCalcEdit1.AutoHeight = False
            Me.repositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1"
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.colorPickEdit1)
            Me.layoutControl1.Controls.Add(Me.colorPickEdit2)
            Me.layoutControl1.Controls.Add(Me.colorPickEdit3)
            Me.layoutControl1.Controls.Add(Me.colorPickEdit4)
            Me.layoutControl1.Controls.Add(Me.colorPickEdit5)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1526, 819, 650, 400)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(199, 404)
            Me.layoutControl1.TabIndex = 1
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' colorPickEdit1
            ' 
            Me.colorPickEdit1.EditValue = System.Drawing.Color.Empty
            Me.colorPickEdit1.Location = New System.Drawing.Point(12, 34)
            Me.colorPickEdit1.Name = "colorPickEdit1"
            Me.colorPickEdit1.Properties.AutomaticColor = System.Drawing.Color.Black
            Me.colorPickEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.colorPickEdit1.Size = New System.Drawing.Size(175, 20)
            Me.colorPickEdit1.StyleController = Me.layoutControl1
            Me.colorPickEdit1.TabIndex = 0
            ' 
            ' colorPickEdit2
            ' 
            Me.colorPickEdit2.EditValue = System.Drawing.Color.Empty
            Me.colorPickEdit2.Location = New System.Drawing.Point(12, 58)
            Me.colorPickEdit2.Name = "colorPickEdit2"
            Me.colorPickEdit2.Properties.AutomaticColor = System.Drawing.Color.Black
            Me.colorPickEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.colorPickEdit2.Size = New System.Drawing.Size(175, 20)
            Me.colorPickEdit2.StyleController = Me.layoutControl1
            Me.colorPickEdit2.TabIndex = 2
            ' 
            ' colorPickEdit3
            ' 
            Me.colorPickEdit3.EditValue = System.Drawing.Color.Empty
            Me.colorPickEdit3.Location = New System.Drawing.Point(12, 82)
            Me.colorPickEdit3.Name = "colorPickEdit3"
            Me.colorPickEdit3.Properties.AutomaticColor = System.Drawing.Color.Black
            Me.colorPickEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.colorPickEdit3.Size = New System.Drawing.Size(175, 20)
            Me.colorPickEdit3.StyleController = Me.layoutControl1
            Me.colorPickEdit3.TabIndex = 3
            ' 
            ' colorPickEdit4
            ' 
            Me.colorPickEdit4.EditValue = System.Drawing.Color.Empty
            Me.colorPickEdit4.Location = New System.Drawing.Point(12, 106)
            Me.colorPickEdit4.Name = "colorPickEdit4"
            Me.colorPickEdit4.Properties.AutomaticColor = System.Drawing.Color.Black
            Me.colorPickEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.colorPickEdit4.Size = New System.Drawing.Size(175, 20)
            Me.colorPickEdit4.StyleController = Me.layoutControl1
            Me.colorPickEdit4.TabIndex = 4
            ' 
            ' colorPickEdit5
            ' 
            Me.colorPickEdit5.EditValue = System.Drawing.Color.Empty
            Me.colorPickEdit5.Location = New System.Drawing.Point(12, 130)
            Me.colorPickEdit5.Name = "colorPickEdit5"
            Me.colorPickEdit5.Properties.AutomaticColor = System.Drawing.Color.Black
            Me.colorPickEdit5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.colorPickEdit5.Size = New System.Drawing.Size(175, 20)
            Me.colorPickEdit5.StyleController = Me.layoutControl1
            Me.colorPickEdit5.TabIndex = 5
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem3, Me.layoutControlGroup2})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(199, 404)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 162)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(199, 242)
            ' 
            ' layoutControlGroup2
            ' 
            buttonImageOptions1.SvgImage = CType((resources.GetObject("buttonImageOptions1.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            buttonImageOptions1.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.layoutControlGroup2.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Reset", False, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Reset", -1, True, Nothing, True, False, True, Nothing, -1)})
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(199, 162)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "Skin Fill Colors"
            AddHandler Me.layoutControlGroup2.CustomButtonClick, New DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(AddressOf Me.layoutControlGroup2_CustomButtonClick)
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.colorPickEdit1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(179, 24)
            Me.layoutControlItem1.Text = "#1"
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.colorPickEdit2
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(179, 24)
            Me.layoutControlItem2.Text = "#2"
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.colorPickEdit3
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(179, 24)
            Me.layoutControlItem4.Text = "#3"
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.colorPickEdit4
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(179, 24)
            Me.layoutControlItem5.Text = "#4"
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.colorPickEdit5
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 96)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(179, 24)
            Me.layoutControlItem6.Text = "#5"
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tabPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(802, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(200, 437)
            Me.sidePanel1.TabIndex = 2
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.Controls.Add(Me.tabNavigationPage1)
            Me.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane1.Location = New System.Drawing.Point(1, 0)
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage1})
            Me.tabPane1.RegularSize = New System.Drawing.Size(199, 437)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            Me.tabPane1.Size = New System.Drawing.Size(199, 437)
            Me.tabPane1.TabIndex = 3
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "Options"
            Me.tabNavigationPage1.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(199, 404)
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 246)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(295, 422)
            ' 
            ' sidePanel2
            ' 
            Me.sidePanel2.AllowResize = False
            Me.sidePanel2.Controls.Add(Me.layoutGridControl)
            Me.sidePanel2.Dock = System.Windows.Forms.DockStyle.Left
            Me.sidePanel2.Location = New System.Drawing.Point(0, 0)
            Me.sidePanel2.MaximumSize = New System.Drawing.Size(320, 0)
            Me.sidePanel2.MinimumSize = New System.Drawing.Size(320, 0)
            Me.sidePanel2.Name = "sidePanel2"
            Me.sidePanel2.Size = New System.Drawing.Size(320, 437)
            Me.sidePanel2.TabIndex = 8
            Me.sidePanel2.Text = "sidePanel2"
            ' 
            ' dataLayoutControl1
            ' 
            Me.dataLayoutControl1.AllowGeneratingCollectionProperties = DevExpress.Utils.DefaultBoolean.[True]
            Me.dataLayoutControl1.AllowGeneratingNestedGroups = DevExpress.Utils.DefaultBoolean.[True]
            Me.dataLayoutControl1.Controls.Add(Me.cancelSimpleButton)
            Me.dataLayoutControl1.Controls.Add(Me.deleteSimpleButton)
            Me.dataLayoutControl1.Controls.Add(Me.saveSimpleButton)
            Me.dataLayoutControl1.Controls.Add(Me.memoEdit1)
            Me.dataLayoutControl1.Controls.Add(Me.pictureEdit1)
            Me.dataLayoutControl1.Controls.Add(Me.dateEdit1)
            Me.dataLayoutControl1.Controls.Add(Me.calcEdit1)
            Me.dataLayoutControl1.Controls.Add(Me.textEdit2)
            Me.dataLayoutControl1.Controls.Add(Me.spinEdit1)
            Me.dataLayoutControl1.Controls.Add(Me.textEdit4)
            Me.dataLayoutControl1.Controls.Add(Me.textEdit3)
            Me.dataLayoutControl1.Controls.Add(Me.spinEdit3)
            Me.dataLayoutControl1.Controls.Add(Me.spinEdit4)
            Me.dataLayoutControl1.Controls.Add(Me.spinEdit2)
            Me.dataLayoutControl1.Controls.Add(Me.textEdit1)
            Me.dataLayoutControl1.Controls.Add(Me.imageComboBoxEdit1)
            Me.dataLayoutControl1.Controls.Add(Me.checkEdit2)
            Me.dataLayoutControl1.DataSource = Me.modelBindingSource
            Me.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dataLayoutControl1.Images = Me.svgImageCollection1
            Me.dataLayoutControl1.Location = New System.Drawing.Point(320, 0)
            Me.dataLayoutControl1.Name = "dataLayoutControl1"
            Me.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(170, 358, 1448, 730)
            Me.dataLayoutControl1.OptionsSerialization.RestoreGroupPadding = True
            Me.dataLayoutControl1.OptionsSerialization.RestoreGroupSpacing = True
            Me.dataLayoutControl1.OptionsSerialization.RestoreRootGroupPadding = True
            Me.dataLayoutControl1.OptionsSerialization.RestoreRootGroupSpacing = True
            Me.dataLayoutControl1.OptionsView.UseParentAutoScaleFactor = True
            Me.dataLayoutControl1.Root = Me.Root
            Me.dataLayoutControl1.Size = New System.Drawing.Size(482, 437)
            Me.dataLayoutControl1.TabIndex = 9
            Me.dataLayoutControl1.Text = "dataLayoutControl1"
            ' 
            ' cancelSimpleButton
            ' 
            Me.cancelSimpleButton.AutoWidthInLayoutControl = True
            Me.cancelSimpleButton.Location = New System.Drawing.Point(284, 389)
            Me.cancelSimpleButton.MinimumSize = New System.Drawing.Size(90, 26)
            Me.cancelSimpleButton.Name = "cancelSimpleButton"
            Me.cancelSimpleButton.Size = New System.Drawing.Size(90, 26)
            Me.cancelSimpleButton.StyleController = Me.dataLayoutControl1
            Me.cancelSimpleButton.TabIndex = 21
            Me.cancelSimpleButton.Text = "Cancel"
            ' 
            ' deleteSimpleButton
            ' 
            Me.deleteSimpleButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
            Me.deleteSimpleButton.Appearance.Options.UseBackColor = True
            Me.deleteSimpleButton.AutoWidthInLayoutControl = True
            Me.deleteSimpleButton.Location = New System.Drawing.Point(12, 389)
            Me.deleteSimpleButton.MinimumSize = New System.Drawing.Size(90, 26)
            Me.deleteSimpleButton.Name = "deleteSimpleButton"
            Me.deleteSimpleButton.Size = New System.Drawing.Size(90, 26)
            Me.deleteSimpleButton.StyleController = Me.dataLayoutControl1
            Me.deleteSimpleButton.TabIndex = 20
            Me.deleteSimpleButton.Text = "Delete"
            ' 
            ' saveSimpleButton
            ' 
            Me.saveSimpleButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
            Me.saveSimpleButton.Appearance.Options.UseBackColor = True
            Me.saveSimpleButton.AutoWidthInLayoutControl = True
            Me.saveSimpleButton.Location = New System.Drawing.Point(380, 389)
            Me.saveSimpleButton.MinimumSize = New System.Drawing.Size(90, 26)
            Me.saveSimpleButton.Name = "saveSimpleButton"
            Me.saveSimpleButton.Size = New System.Drawing.Size(90, 26)
            Me.saveSimpleButton.StyleController = Me.dataLayoutControl1
            Me.saveSimpleButton.TabIndex = 19
            Me.saveSimpleButton.Text = "Save"
            ' 
            ' memoEdit1
            ' 
            Me.memoEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "Description", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.memoEdit1.EditValue = "memoEdit1"
            Me.memoEdit1.Location = New System.Drawing.Point(24, 264)
            Me.memoEdit1.Name = "memoEdit1"
            Me.memoEdit1.Size = New System.Drawing.Size(434, 103)
            Me.memoEdit1.StyleController = Me.dataLayoutControl1
            Me.memoEdit1.TabIndex = 12
            ' 
            ' pictureEdit1
            ' 
            Me.pictureEdit1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.pictureEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "Photo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.pictureEdit1.Location = New System.Drawing.Point(12, 74)
            Me.pictureEdit1.Name = "pictureEdit1"
            Me.pictureEdit1.Properties.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.[True]
            Me.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
            Me.pictureEdit1.Size = New System.Drawing.Size(252, 144)
            Me.pictureEdit1.StyleController = Me.dataLayoutControl1
            Me.pictureEdit1.TabIndex = 3
            ' 
            ' dateEdit1
            ' 
            Me.dateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "Delivery Date", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.dateEdit1.EditValue = New System.DateTime((CLng((0))))
            Me.dateEdit1.Location = New System.Drawing.Point(362, 182)
            Me.dateEdit1.Name = "dateEdit1"
            Me.dateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.dateEdit1.Size = New System.Drawing.Size(96, 20)
            Me.dateEdit1.StyleController = Me.dataLayoutControl1
            Me.dateEdit1.TabIndex = 9
            ' 
            ' calcEdit1
            ' 
            Me.calcEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "Price", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.calcEdit1.Location = New System.Drawing.Point(362, 158)
            Me.calcEdit1.Name = "calcEdit1"
            Me.calcEdit1.Properties.Appearance.Options.UseTextOptions = True
            Me.calcEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.calcEdit1.Properties.AppearanceDisabled.Options.UseTextOptions = True
            Me.calcEdit1.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.calcEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.calcEdit1.Properties.Mask.EditMask = "c"
            Me.calcEdit1.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.calcEdit1.Size = New System.Drawing.Size(96, 20)
            Me.calcEdit1.StyleController = Me.dataLayoutControl1
            Me.calcEdit1.TabIndex = 7
            ' 
            ' textEdit2
            ' 
            Me.textEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "Name", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.textEdit2.EditValue = "textEdit2"
            Me.textEdit2.Location = New System.Drawing.Point(362, 110)
            Me.textEdit2.Name = "textEdit2"
            Me.textEdit2.Size = New System.Drawing.Size(96, 20)
            Me.textEdit2.StyleController = Me.dataLayoutControl1
            Me.textEdit2.TabIndex = 4
            ' 
            ' spinEdit1
            ' 
            Me.spinEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "Cylinders", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.spinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinEdit1.Location = New System.Drawing.Point(348, 288)
            Me.spinEdit1.Name = "spinEdit1"
            Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinEdit1.Properties.IsFloatValue = False
            Me.spinEdit1.Properties.Mask.EditMask = "N00"
            Me.spinEdit1.Size = New System.Drawing.Size(110, 20)
            Me.spinEdit1.StyleController = Me.dataLayoutControl1
            Me.spinEdit1.TabIndex = 14
            ' 
            ' textEdit4
            ' 
            Me.textEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "Modification", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.textEdit4.EditValue = "textEdit4"
            Me.textEdit4.Location = New System.Drawing.Point(128, 264)
            Me.textEdit4.Name = "textEdit4"
            Me.textEdit4.Properties.DisplayFormat.FormatString = "#.## Liters"
            Me.textEdit4.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.textEdit4.Size = New System.Drawing.Size(330, 20)
            Me.textEdit4.StyleController = Me.dataLayoutControl1
            Me.textEdit4.TabIndex = 15
            ' 
            ' textEdit3
            ' 
            Me.textEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "Horsepower", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.textEdit3.EditValue = "textEdit3"
            Me.textEdit3.Location = New System.Drawing.Point(128, 288)
            Me.textEdit3.Name = "textEdit3"
            Me.textEdit3.Size = New System.Drawing.Size(112, 20)
            Me.textEdit3.StyleController = Me.dataLayoutControl1
            Me.textEdit3.TabIndex = 13
            ' 
            ' spinEdit3
            ' 
            Me.spinEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "MPG City", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.spinEdit3.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinEdit3.Location = New System.Drawing.Point(128, 312)
            Me.spinEdit3.Name = "spinEdit3"
            Me.spinEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinEdit3.Properties.IsFloatValue = False
            Me.spinEdit3.Properties.Mask.EditMask = "N00"
            Me.spinEdit3.Size = New System.Drawing.Size(112, 20)
            Me.spinEdit3.StyleController = Me.dataLayoutControl1
            Me.spinEdit3.TabIndex = 16
            ' 
            ' spinEdit4
            ' 
            Me.spinEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "Doors", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.spinEdit4.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinEdit4.Location = New System.Drawing.Point(128, 336)
            Me.spinEdit4.Name = "spinEdit4"
            Me.spinEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinEdit4.Properties.IsFloatValue = False
            Me.spinEdit4.Properties.Mask.EditMask = "N00"
            Me.spinEdit4.Size = New System.Drawing.Size(112, 20)
            Me.spinEdit4.StyleController = Me.dataLayoutControl1
            Me.spinEdit4.TabIndex = 17
            ' 
            ' spinEdit2
            ' 
            Me.spinEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "MPG Highway", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.spinEdit2.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinEdit2.Location = New System.Drawing.Point(348, 312)
            Me.spinEdit2.Name = "spinEdit2"
            Me.spinEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinEdit2.Properties.IsFloatValue = False
            Me.spinEdit2.Properties.Mask.EditMask = "N00"
            Me.spinEdit2.Size = New System.Drawing.Size(110, 20)
            Me.spinEdit2.StyleController = Me.dataLayoutControl1
            Me.spinEdit2.TabIndex = 1
            ' 
            ' textEdit1
            ' 
            Me.textEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "TrademarkID", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.textEdit1.Location = New System.Drawing.Point(362, 86)
            Me.textEdit1.Name = "textEdit1"
            Me.textEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.textEdit1.Properties.DataSource = Me.trademarkBindingSource
            Me.textEdit1.Properties.DisplayMember = "Name"
            Me.textEdit1.Properties.NullText = ""
            Me.textEdit1.Properties.PopupView = Me.textEdit1View
            Me.textEdit1.Properties.ValueMember = "ID"
            Me.textEdit1.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.TileView
            Me.textEdit1.Size = New System.Drawing.Size(96, 20)
            Me.textEdit1.StyleController = Me.dataLayoutControl1
            Me.textEdit1.TabIndex = 2
            ' 
            ' textEdit1View
            ' 
            Me.textEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.tileViewColumn1, Me.colSite, Me.colLogo, Me.colDescription})
            Me.textEdit1View.Name = "textEdit1View"
            Me.textEdit1View.OptionsBehavior.AllowSmoothScrolling = True
            Me.textEdit1View.OptionsTiles.AllowPressAnimation = False
            Me.textEdit1View.OptionsTiles.IndentBetweenGroups = 0
            Me.textEdit1View.OptionsTiles.IndentBetweenItems = 0
            Me.textEdit1View.OptionsTiles.ItemSize = New System.Drawing.Size(248, 55)
            Me.textEdit1View.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List
            Me.textEdit1View.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.textEdit1View.OptionsTiles.Padding = New System.Windows.Forms.Padding(0)
            Me.textEdit1View.OptionsTiles.RowCount = 0
            Me.textEdit1View.TileRows.Add(tableRowDefinition1)
            tileViewItemElement1.Column = Me.colLogo
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            tileViewItemElement1.Text = "colLogo"
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            Me.textEdit1View.TileTemplate.Add(tileViewItemElement1)
            ' 
            ' colID
            ' 
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            ' 
            ' tileViewColumn1
            ' 
            Me.tileViewColumn1.FieldName = "Name"
            Me.tileViewColumn1.Name = "tileViewColumn1"
            Me.tileViewColumn1.Visible = True
            Me.tileViewColumn1.VisibleIndex = 1
            ' 
            ' colSite
            ' 
            Me.colSite.FieldName = "Site"
            Me.colSite.Name = "colSite"
            Me.colSite.Visible = True
            Me.colSite.VisibleIndex = 2
            ' 
            ' colDescription
            ' 
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.Visible = True
            Me.colDescription.VisibleIndex = 4
            ' 
            ' imageComboBoxEdit1
            ' 
            Me.imageComboBoxEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "CategoryID", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.imageComboBoxEdit1.Location = New System.Drawing.Point(362, 134)
            Me.imageComboBoxEdit1.Name = "imageComboBoxEdit1"
            Me.imageComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.imageComboBoxEdit1.Properties.DataSource = Me.categoryBindingSource
            Me.imageComboBoxEdit1.Properties.DisplayMember = "Name"
            Me.imageComboBoxEdit1.Properties.NullText = ""
            Me.imageComboBoxEdit1.Properties.PopupSizeable = False
            Me.imageComboBoxEdit1.Properties.PopupView = Me.imageComboBoxEdit1View
            Me.imageComboBoxEdit1.Properties.ValueMember = "ID"
            Me.imageComboBoxEdit1.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.TileView
            Me.imageComboBoxEdit1.Size = New System.Drawing.Size(96, 20)
            Me.imageComboBoxEdit1.StyleController = Me.dataLayoutControl1
            Me.imageComboBoxEdit1.TabIndex = 5
            ' 
            ' imageComboBoxEdit1View
            ' 
            Me.imageComboBoxEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID1, Me.colName1, Me.colPicture})
            Me.imageComboBoxEdit1View.Name = "imageComboBoxEdit1View"
            Me.imageComboBoxEdit1View.OptionsBehavior.AllowSmoothScrolling = True
            Me.imageComboBoxEdit1View.OptionsTiles.AllowPressAnimation = False
            Me.imageComboBoxEdit1View.OptionsTiles.IndentBetweenGroups = 0
            Me.imageComboBoxEdit1View.OptionsTiles.IndentBetweenItems = 0
            Me.imageComboBoxEdit1View.OptionsTiles.ItemSize = New System.Drawing.Size(248, 55)
            Me.imageComboBoxEdit1View.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List
            Me.imageComboBoxEdit1View.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.imageComboBoxEdit1View.OptionsTiles.Padding = New System.Windows.Forms.Padding(0)
            Me.imageComboBoxEdit1View.OptionsTiles.RowCount = 0
            Me.imageComboBoxEdit1View.TileRows.Add(tableRowDefinition2)
            tileViewItemElement2.Column = Me.colName1
            tileViewItemElement2.Text = "colName1"
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            Me.imageComboBoxEdit1View.TileTemplate.Add(tileViewItemElement2)
            ' 
            ' colID1
            ' 
            Me.colID1.FieldName = "ID"
            Me.colID1.Name = "colID1"
            Me.colID1.Visible = True
            Me.colID1.VisibleIndex = 0
            ' 
            ' colPicture
            ' 
            Me.colPicture.FieldName = "Picture"
            Me.colPicture.Name = "colPicture"
            Me.colPicture.Visible = True
            Me.colPicture.VisibleIndex = 2
            ' 
            ' checkEdit2
            ' 
            Me.checkEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "Transmission Type", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.checkEdit2.Location = New System.Drawing.Point(348, 336)
            Me.checkEdit2.Name = "checkEdit2"
            Me.checkEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.checkEdit2.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Automatic", 1, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Manual", 2, -1)})
            Me.checkEdit2.Size = New System.Drawing.Size(110, 20)
            Me.checkEdit2.StyleController = Me.dataLayoutControl1
            Me.checkEdit2.TabIndex = 18
            Me.checkEdit2.TabStop = False
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("Person", CType((resources.GetObject("svgImageCollection1.Person")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("House", CType((resources.GetObject("svgImageCollection1.House")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Notes", CType((resources.GetObject("svgImageCollection1.Notes")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("OrderDetails", CType((resources.GetObject("svgImageCollection1.OrderDetails")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Settings", CType((resources.GetObject("svgImageCollection1.Settings")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Categories", CType((resources.GetObject("svgImageCollection1.Categories")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Product", CType((resources.GetObject("svgImageCollection1.Product")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("OrderDetails", CType((resources.GetObject("svgImageCollection1.OrderDetails1")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Warning", CType((resources.GetObject("svgImageCollection1.Warning")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' Root
            ' 
            Me.Root.CustomizationFormText = "Main"
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup4})
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.Root.Size = New System.Drawing.Size(482, 437)
            Me.Root.Text = "Main"
            Me.Root.TextVisible = False
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup4.GroupBordersVisible = False
            Me.layoutControlGroup4.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlItem8, Me.layoutControlGroup3, Me.tabbedControlGroup1, Me.emptySpaceItem6, Me.layoutControlItem14, Me.emptySpaceItem4, Me.layoutControlItem22, Me.item3, Me.emptySpaceItem8, Me.emptySpaceItem7})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Size = New System.Drawing.Size(482, 437)
            Me.layoutControlGroup4.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup4.Text = "Warning!"
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 407)
            Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 10)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(10, 10)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(462, 10)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.pictureEdit1
            Me.layoutControlItem8.CustomizationFormText = "Picture"
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 62)
            Me.layoutControlItem8.MaxSize = New System.Drawing.Size(256, 148)
            Me.layoutControlItem8.MinSize = New System.Drawing.Size(256, 148)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(256, 148)
            Me.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem8.Text = "Picture"
            Me.layoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
            Me.layoutControlItem8.TextToControlDistance = 0
            Me.layoutControlItem8.TextVisible = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.CaptionImageOptions.ImageIndex = 3
            Me.layoutControlGroup3.CustomizationFormText = "Details"
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem9, Me.layoutControlItem17, Me.item0, Me.item1, Me.layoutControlItem18})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(256, 62)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AlignLocal
            Me.layoutControlGroup3.OptionsItemText.TextToControlDistance = 0
            Me.layoutControlGroup3.Size = New System.Drawing.Size(206, 148)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(6, 2, 2, 2)
            Me.layoutControlGroup3.Text = "Details"
            Me.layoutControlGroup3.TextVisible = False
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.textEdit1
            Me.layoutControlItem9.CustomizationFormText = "&Manufacturer:   "
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Size = New System.Drawing.Size(178, 24)
            Me.layoutControlItem9.Text = "&Manufacturer:   "
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(78, 13)
            ' 
            ' layoutControlItem17
            ' 
            Me.layoutControlItem17.Control = Me.calcEdit1
            Me.layoutControlItem17.CustomizationFormText = "Price:"
            Me.layoutControlItem17.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItem17.Name = "layoutControlItem17"
            Me.layoutControlItem17.Size = New System.Drawing.Size(178, 24)
            Me.layoutControlItem17.Text = "Price:"
            Me.layoutControlItem17.TextSize = New System.Drawing.Size(78, 13)
            ' 
            ' item0
            ' 
            Me.item0.Control = Me.imageComboBoxEdit1
            Me.item0.CustomizationFormText = "Category: "
            Me.item0.Location = New System.Drawing.Point(0, 48)
            Me.item0.Name = "item0"
            Me.item0.Size = New System.Drawing.Size(178, 24)
            Me.item0.Text = "Category: "
            Me.item0.TextSize = New System.Drawing.Size(78, 13)
            ' 
            ' item1
            ' 
            Me.item1.Control = Me.textEdit2
            Me.item1.CustomizationFormText = "Model:"
            Me.item1.Location = New System.Drawing.Point(0, 24)
            Me.item1.Name = "item1"
            Me.item1.Size = New System.Drawing.Size(178, 24)
            Me.item1.Text = "Model:"
            Me.item1.TextSize = New System.Drawing.Size(78, 13)
            ' 
            ' layoutControlItem18
            ' 
            Me.layoutControlItem18.Control = Me.dateEdit1
            Me.layoutControlItem18.CustomizationFormText = "Delivery Date:"
            Me.layoutControlItem18.Location = New System.Drawing.Point(0, 96)
            Me.layoutControlItem18.Name = "layoutControlItem18"
            Me.layoutControlItem18.Size = New System.Drawing.Size(178, 28)
            Me.layoutControlItem18.Text = "Delivery Date:"
            Me.layoutControlItem18.TextSize = New System.Drawing.Size(78, 13)
            ' 
            ' tabbedControlGroup1
            ' 
            Me.tabbedControlGroup1.CustomizationFormText = "TabbedGroup"
            Me.tabbedControlGroup1.Location = New System.Drawing.Point(0, 210)
            Me.tabbedControlGroup1.Name = "tabbedControlGroup1"
            Me.tabbedControlGroup1.SelectedTabPage = Me.perfomanceLayoutGroup
            Me.tabbedControlGroup1.Size = New System.Drawing.Size(462, 157)
            Me.tabbedControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 6, -2)
            Me.tabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.perfomanceLayoutGroup, Me.descriptionLayoutGroup})
            Me.tabbedControlGroup1.Text = "TabbedGroup"
            Me.tabbedControlGroup1.Transition.AllowTransition = DevExpress.Utils.DefaultBoolean.[True]
            ' 
            ' perfomanceLayoutGroup
            ' 
            Me.perfomanceLayoutGroup.AppearanceTabPage.Header.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question
            Me.perfomanceLayoutGroup.AppearanceTabPage.Header.Options.UseBackColor = True
            Me.perfomanceLayoutGroup.CaptionImageOptions.ImageIndex = 4
            Me.perfomanceLayoutGroup.CustomizationFormText = "&Performance Attributes"
            Me.perfomanceLayoutGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem11, Me.layoutControlItem16, Me.layoutControlItem13, Me.layoutControlItem12, Me.layoutControlItem7, Me.layoutControlItem3, Me.layoutControlItem15, Me.emptySpaceItem5})
            Me.perfomanceLayoutGroup.Location = New System.Drawing.Point(0, 0)
            Me.perfomanceLayoutGroup.Name = "perfomanceLayoutGroup"
            Me.perfomanceLayoutGroup.Size = New System.Drawing.Size(438, 107)
            Me.perfomanceLayoutGroup.Text = "&Performance Attributes"
            ' 
            ' layoutControlItem11
            ' 
            Me.layoutControlItem11.Control = Me.spinEdit1
            Me.layoutControlItem11.CustomizationFormText = "Cyl:"
            Me.layoutControlItem11.Location = New System.Drawing.Point(220, 24)
            Me.layoutControlItem11.Name = "layoutControlItem11"
            Me.layoutControlItem11.Size = New System.Drawing.Size(218, 24)
            Me.layoutControlItem11.Text = "Cyl:"
            Me.layoutControlItem11.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' layoutControlItem16
            ' 
            Me.layoutControlItem16.Control = Me.checkEdit2
            Me.layoutControlItem16.CustomizationFormText = "Automatic Transmission"
            Me.layoutControlItem16.Location = New System.Drawing.Point(220, 72)
            Me.layoutControlItem16.Name = "layoutControlItem16"
            Me.layoutControlItem16.Size = New System.Drawing.Size(218, 24)
            Me.layoutControlItem16.Text = "Transmission Type:"
            Me.layoutControlItem16.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' layoutControlItem13
            ' 
            Me.layoutControlItem13.Control = Me.spinEdit2
            Me.layoutControlItem13.CustomizationFormText = "MPG Highway:"
            Me.layoutControlItem13.Location = New System.Drawing.Point(220, 48)
            Me.layoutControlItem13.Name = "layoutControlItem13"
            Me.layoutControlItem13.Size = New System.Drawing.Size(218, 24)
            Me.layoutControlItem13.Text = "MPG Highway:"
            Me.layoutControlItem13.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' layoutControlItem12
            ' 
            Me.layoutControlItem12.Control = Me.textEdit4
            Me.layoutControlItem12.CustomizationFormText = "Capacity:"
            Me.layoutControlItem12.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem12.Name = "layoutControlItem12"
            Me.layoutControlItem12.Size = New System.Drawing.Size(438, 24)
            Me.layoutControlItem12.Text = "Capacity:"
            Me.layoutControlItem12.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.textEdit3
            Me.layoutControlItem7.CustomizationFormText = "HP:"
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(220, 24)
            Me.layoutControlItem7.Text = "HP:"
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.spinEdit3
            Me.layoutControlItem3.CustomizationFormText = "MPG City:"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(220, 24)
            Me.layoutControlItem3.Text = "MPG City:"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' layoutControlItem15
            ' 
            Me.layoutControlItem15.Control = Me.spinEdit4
            Me.layoutControlItem15.CustomizationFormText = "# of Gears:"
            Me.layoutControlItem15.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItem15.Name = "layoutControlItem15"
            Me.layoutControlItem15.Size = New System.Drawing.Size(220, 24)
            Me.layoutControlItem15.Text = "# of Gears:"
            Me.layoutControlItem15.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' emptySpaceItem5
            ' 
            Me.emptySpaceItem5.Location = New System.Drawing.Point(0, 96)
            Me.emptySpaceItem5.Name = "emptySpaceItem5"
            Me.emptySpaceItem5.Size = New System.Drawing.Size(438, 11)
            ' 
            ' descriptionLayoutGroup
            ' 
            Me.descriptionLayoutGroup.CaptionImageOptions.ImageIndex = 3
            Me.descriptionLayoutGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem10})
            Me.descriptionLayoutGroup.Location = New System.Drawing.Point(0, 0)
            Me.descriptionLayoutGroup.Name = "descriptionLayoutGroup"
            Me.descriptionLayoutGroup.Size = New System.Drawing.Size(438, 107)
            Me.descriptionLayoutGroup.Text = "Description"
            ' 
            ' layoutControlItem10
            ' 
            Me.layoutControlItem10.Control = Me.memoEdit1
            Me.layoutControlItem10.CustomizationFormText = "&Description: "
            Me.layoutControlItem10.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Size = New System.Drawing.Size(438, 107)
            Me.layoutControlItem10.Text = "&Description: "
            Me.layoutControlItem10.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem10.TextVisible = False
            ' 
            ' emptySpaceItem6
            ' 
            Me.emptySpaceItem6.Location = New System.Drawing.Point(0, 367)
            Me.emptySpaceItem6.MaxSize = New System.Drawing.Size(0, 10)
            Me.emptySpaceItem6.MinSize = New System.Drawing.Size(10, 10)
            Me.emptySpaceItem6.Name = "emptySpaceItem6"
            Me.emptySpaceItem6.Size = New System.Drawing.Size(462, 10)
            Me.emptySpaceItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' layoutControlItem14
            ' 
            Me.layoutControlItem14.Control = Me.deleteSimpleButton
            Me.layoutControlItem14.Location = New System.Drawing.Point(0, 377)
            Me.layoutControlItem14.Name = "item3"
            Me.layoutControlItem14.Size = New System.Drawing.Size(94, 30)
            Me.layoutControlItem14.TextVisible = False
            ' 
            ' emptySpaceItem4
            ' 
            Me.emptySpaceItem4.Location = New System.Drawing.Point(94, 377)
            Me.emptySpaceItem4.Name = "emptySpaceItem4"
            Me.emptySpaceItem4.OptionsTableLayoutItem.ColumnIndex = 1
            Me.emptySpaceItem4.Size = New System.Drawing.Size(178, 30)
            ' 
            ' layoutControlItem22
            ' 
            Me.layoutControlItem22.Control = Me.cancelSimpleButton
            Me.layoutControlItem22.Location = New System.Drawing.Point(272, 377)
            Me.layoutControlItem22.Name = "layoutControlItem22"
            Me.layoutControlItem22.OptionsTableLayoutItem.ColumnIndex = 2
            Me.layoutControlItem22.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 4, 2, 2)
            Me.layoutControlItem22.Size = New System.Drawing.Size(96, 30)
            Me.layoutControlItem22.TextVisible = False
            ' 
            ' item3
            ' 
            Me.item3.Control = Me.saveSimpleButton
            Me.item3.Location = New System.Drawing.Point(368, 377)
            Me.item3.Name = "item4"
            Me.item3.OptionsTableLayoutItem.ColumnIndex = 3
            Me.item3.Size = New System.Drawing.Size(94, 30)
            Me.item3.TextVisible = False
            ' 
            ' emptySpaceItem8
            ' 
            Me.emptySpaceItem8.Location = New System.Drawing.Point(0, 10)
            Me.emptySpaceItem8.MaxSize = New System.Drawing.Size(0, 52)
            Me.emptySpaceItem8.MinSize = New System.Drawing.Size(10, 52)
            Me.emptySpaceItem8.Name = "emptySpaceItem8"
            Me.emptySpaceItem8.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 6)
            Me.emptySpaceItem8.Size = New System.Drawing.Size(462, 52)
            Me.emptySpaceItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            AddHandler Me.emptySpaceItem8.CustomDraw, New System.EventHandler(Of DevExpress.XtraLayout.ItemCustomDrawEventArgs)(AddressOf Me.emptySpaceItem8_CustomDraw)
            ' 
            ' emptySpaceItem7
            ' 
            Me.emptySpaceItem7.CustomizationFormText = "emptySpaceItem6"
            Me.emptySpaceItem7.Location = New System.Drawing.Point(0, 0)
            Me.emptySpaceItem7.MaxSize = New System.Drawing.Size(0, 10)
            Me.emptySpaceItem7.MinSize = New System.Drawing.Size(10, 10)
            Me.emptySpaceItem7.Name = "emptySpaceItem7"
            Me.emptySpaceItem7.Size = New System.Drawing.Size(462, 10)
            Me.emptySpaceItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem7.Text = "emptySpaceItem6"
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.dataLayoutControl1)
            Me.panelControl1.Controls.Add(Me.sidePanel2)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(802, 437)
            Me.panelControl1.TabIndex = 22
            ' 
            ' NewCars
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "NewCars"
            Me.Size = New System.Drawing.Size(1002, 437)
            CType((Me.layoutGridControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.modelBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.vehiclesDataSet), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemPictureEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colPhoto), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemGridLookUpEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.categoryBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemGridLookUpEdit1View), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colCategoryID), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colName), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemGridLookUpEdit2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.trademarkBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemGridLookUpEdit2View), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colTrademarkID), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colPrice), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewCard1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Group1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemCalcEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.colorPickEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.colorPickEdit2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.colorPickEdit3.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.colorPickEdit4.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.colorPickEdit5.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel2.ResumeLayout(False)
            CType((Me.dataLayoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dataLayoutControl1.ResumeLayout(False)
            CType((Me.memoEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pictureEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dateEdit1.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dateEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.calcEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEdit2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEdit4.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEdit3.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEdit3.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEdit4.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEdit2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEdit1View), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageComboBoxEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageComboBoxEdit1View), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEdit2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem17), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.item0), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.item1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem18), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tabbedControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.perfomanceLayoutGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem16), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem13), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem15), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.descriptionLayoutGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem14), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem22), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.item3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutGridControl As DevExpress.XtraGrid.GridControl

        Private layoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private sidePanel2 As DevExpress.XtraEditors.SidePanel

        Private colorPickEdit1 As DevExpress.XtraEditors.ColorPickEdit

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private colorPickEdit2 As DevExpress.XtraEditors.ColorPickEdit

        Private colorPickEdit3 As DevExpress.XtraEditors.ColorPickEdit

        Private colorPickEdit4 As DevExpress.XtraEditors.ColorPickEdit

        Private colorPickEdit5 As DevExpress.XtraEditors.ColorPickEdit

        Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private modelBindingSource As System.Windows.Forms.BindingSource

        Private vehiclesDataSet As DevExpress.XtraLayout.Demos.VehiclesDataSet

        Private trademarkBindingSource As System.Windows.Forms.BindingSource

        Private categoryBindingSource As System.Windows.Forms.BindingSource

        Private colPhoto As DevExpress.XtraGrid.Columns.LayoutViewColumn

        Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit

        Private colCategoryID As DevExpress.XtraGrid.Columns.LayoutViewColumn

        Private repositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit

        Private repositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView

        Private colName As DevExpress.XtraGrid.Columns.LayoutViewColumn

        Private colTrademarkID As DevExpress.XtraGrid.Columns.LayoutViewColumn

        Private repositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit

        Private repositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView

        Private dataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl

        Private cancelSimpleButton As DevExpress.XtraEditors.SimpleButton

        Private deleteSimpleButton As DevExpress.XtraEditors.SimpleButton

        Private saveSimpleButton As DevExpress.XtraEditors.SimpleButton

        Private memoEdit1 As DevExpress.XtraEditors.MemoEdit

        Private pictureEdit1 As DevExpress.XtraEditors.PictureEdit

        Private dateEdit1 As DevExpress.XtraEditors.DateEdit

        Private calcEdit1 As DevExpress.XtraEditors.CalcEdit

        Private textEdit2 As DevExpress.XtraEditors.TextEdit

        Private spinEdit1 As DevExpress.XtraEditors.SpinEdit

        Private textEdit4 As DevExpress.XtraEditors.TextEdit

        Private textEdit3 As DevExpress.XtraEditors.TextEdit

        Private spinEdit3 As DevExpress.XtraEditors.SpinEdit

        Private spinEdit4 As DevExpress.XtraEditors.SpinEdit

        Private spinEdit2 As DevExpress.XtraEditors.SpinEdit

        Private textEdit1 As DevExpress.XtraEditors.GridLookUpEdit

        Private textEdit1View As DevExpress.XtraGrid.Views.Tile.TileView

        Private colID As DevExpress.XtraGrid.Columns.TileViewColumn

        Private tileViewColumn1 As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colSite As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colLogo As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colDescription As DevExpress.XtraGrid.Columns.TileViewColumn

        Private imageComboBoxEdit1 As DevExpress.XtraEditors.GridLookUpEdit

        Private imageComboBoxEdit1View As DevExpress.XtraGrid.Views.Tile.TileView

        Private colID1 As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colName1 As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colPicture As DevExpress.XtraGrid.Columns.TileViewColumn

        Private checkEdit2 As DevExpress.XtraEditors.ImageComboBoxEdit

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem

        Private item3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private colPrice As DevExpress.XtraGrid.Columns.LayoutViewColumn

        Private repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection

        Private tabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup

        Private perfomanceLayoutGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem

        Private descriptionLayoutGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem

        Private item0 As DevExpress.XtraLayout.LayoutControlItem

        Private item1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutViewField_colPhoto As DevExpress.XtraGrid.Views.Layout.LayoutViewField

        Private layoutViewField_colCategoryID As DevExpress.XtraGrid.Views.Layout.LayoutViewField

        Private layoutViewField_colName As DevExpress.XtraGrid.Views.Layout.LayoutViewField

        Private layoutViewField_colTrademarkID As DevExpress.XtraGrid.Views.Layout.LayoutViewField

        Private layoutViewField_colPrice As DevExpress.XtraGrid.Views.Layout.LayoutViewField

        Private layoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard

        Private Group1 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
