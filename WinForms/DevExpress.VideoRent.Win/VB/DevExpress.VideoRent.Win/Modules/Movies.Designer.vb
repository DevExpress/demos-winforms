Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Modules
	Partial Public Class Movies
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.colPicturesCount = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.xcMovies = New DevExpress.Xpo.XPCollection()
			Me.advBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
			Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colPhoto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colTitle = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colReleaseDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colPlot = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
			Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colTagline = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.repositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
			Me.colAwards = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colGenre = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.riccbGenre = New DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit()
			Me.colWebSite = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colDirectors = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colRunTime = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colAspectRatio = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colLanguage = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colRating = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colColor = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colInfo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.repositoryItemPictureEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			Me.repositoryItemMemoEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
			Me.layoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
			Me.colPhoto1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colPhoto1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.colTitle1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colTitle1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.colReleaseDate1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colReleaseDate1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.colPlot1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colPlot1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
			Me.dockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
			Me.dpScreens = New DevExpress.XtraBars.Docking.DockPanel()
			Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.ucScreens1 = New DevExpress.VideoRent.Win.Controls.ucScreens()
			Me.pnlMoviesContainer = New DevExpress.XtraEditors.PanelControl()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xcMovies, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.riccbGenre, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMemoEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colPhoto1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colTitle1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colReleaseDate1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colPlot1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.dpScreens.SuspendLayout()
			Me.dockPanel1_Container.SuspendLayout()
			CType(Me.pnlMoviesContainer, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlMoviesContainer.SuspendLayout()
			Me.SuspendLayout()
			' 
			' colPicturesCount
			' 
			Me.colPicturesCount.FieldName = "PicturesCount"
			Me.colPicturesCount.Name = "colPicturesCount"
			Me.colPicturesCount.OptionsColumn.AllowFocus = False
			Me.colPicturesCount.OptionsColumn.ReadOnly = True
			Me.colPicturesCount.OptionsColumn.ShowInCustomizationForm = False
			Me.colPicturesCount.Width = 60
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.xcMovies
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(6, 6)
			Me.gridControl1.MainView = Me.advBandedGridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemPictureEdit1, Me.repositoryItemMemoEdit1, Me.repositoryItemMemoEdit2, Me.riccbGenre, Me.repositoryItemPictureEdit2, Me.repositoryItemMemoEdit3})
			Me.gridControl1.ShowOnlyPredefinedDetails = True
			Me.gridControl1.Size = New System.Drawing.Size(771, 564)
			Me.gridControl1.TabIndex = 1
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.advBandedGridView1, Me.layoutView1})
'			Me.gridControl1.MouseUp += New System.Windows.Forms.MouseEventHandler(Me.gridControl1_MouseUp);
'			Me.gridControl1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.gridControl1_MouseMove);
'			Me.gridControl1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.gridControl1_MouseDown);
'			Me.gridControl1.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.gridControl1_KeyDown);
			' 
			' xcMovies
			' 
			Me.xcMovies.LoadingEnabled = False
			Me.xcMovies.ObjectType = GetType(DevExpress.VideoRent.Movie)
			' 
			' advBandedGridView1
			' 
			Me.advBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand2, Me.gridBand3, Me.gridBand1, Me.gridBand4})
			Me.advBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() { Me.colPhoto, Me.colTitle, Me.colReleaseDate, Me.colPlot, Me.colAwards, Me.colTagline, Me.colWebSite, Me.colColor, Me.colRunTime, Me.colPicturesCount, Me.colGenre, Me.colRating, Me.colLanguage, Me.colAspectRatio, Me.colDirectors, Me.colInfo})
			Me.advBandedGridView1.GridControl = Me.gridControl1
			Me.advBandedGridView1.Name = "advBandedGridView1"
			Me.advBandedGridView1.OptionsCustomization.AllowQuickHideColumns = False
			Me.advBandedGridView1.OptionsNavigation.UseAdvHorzNavigation = False
			Me.advBandedGridView1.OptionsNavigation.UseAdvVertNavigation = False
			Me.advBandedGridView1.OptionsView.ShowBands = False
			Me.advBandedGridView1.OptionsView.ShowGroupPanel = False
			Me.advBandedGridView1.RowSeparatorHeight = 2
'			Me.advBandedGridView1.CustomUnboundColumnData += New DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(Me.advBandedGridView1_CustomUnboundColumnData);
'			Me.advBandedGridView1.CustomDrawCell += New DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(Me.advBandedGridView1_CustomDrawCell);
'			Me.advBandedGridView1.PopupMenuShowing += New DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(Me.advBandedGridView1_PopupMenuShowing);
			' 
			' gridBand2
			' 
			Me.gridBand2.Caption = "Image"
			Me.gridBand2.Columns.Add(Me.colPhoto)
			Me.gridBand2.MinWidth = 20
			Me.gridBand2.Name = "gridBand2"
			Me.gridBand2.Width = 50
			' 
			' colPhoto
			' 
			Me.colPhoto.AutoFillDown = True
			Me.colPhoto.Caption = "Photo"
			Me.colPhoto.ColumnEdit = Me.repositoryItemPictureEdit1
			Me.colPhoto.FieldName = "PhotoExist"
			Me.colPhoto.Name = "colPhoto"
			Me.colPhoto.OptionsColumn.AllowEdit = False
			Me.colPhoto.OptionsColumn.AllowFocus = False
			Me.colPhoto.OptionsColumn.AllowSize = False
			Me.colPhoto.OptionsColumn.FixedWidth = True
			Me.colPhoto.OptionsColumn.ReadOnly = True
			Me.colPhoto.RowCount = 3
			Me.colPhoto.Visible = True
			Me.colPhoto.Width = 50
			' 
			' repositoryItemPictureEdit1
			' 
			Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
			Me.repositoryItemPictureEdit1.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
			Me.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
			' 
			' gridBand3
			' 
			Me.gridBand3.Caption = "Data1"
			Me.gridBand3.Columns.Add(Me.colTitle)
			Me.gridBand3.Columns.Add(Me.colReleaseDate)
			Me.gridBand3.Columns.Add(Me.colPlot)
			Me.gridBand3.MinWidth = 20
			Me.gridBand3.Name = "gridBand3"
			Me.gridBand3.Width = 320
			' 
			' colTitle
			' 
			Me.colTitle.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.colTitle.AppearanceCell.Options.UseFont = True
			Me.colTitle.FieldName = "Title"
			Me.colTitle.Name = "colTitle"
			Me.colTitle.OptionsColumn.AllowFocus = False
			Me.colTitle.OptionsColumn.ReadOnly = True
			Me.colTitle.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
			Me.colTitle.Visible = True
			Me.colTitle.Width = 222
			' 
			' colReleaseDate
			' 
			Me.colReleaseDate.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.colReleaseDate.AppearanceCell.Options.UseFont = True
			Me.colReleaseDate.FieldName = "ReleaseDate"
			Me.colReleaseDate.Name = "colReleaseDate"
			Me.colReleaseDate.OptionsColumn.AllowFocus = False
			Me.colReleaseDate.OptionsColumn.ReadOnly = True
			Me.colReleaseDate.Visible = True
			Me.colReleaseDate.Width = 98
			' 
			' colPlot
			' 
			Me.colPlot.AutoFillDown = True
			Me.colPlot.ColumnEdit = Me.repositoryItemMemoEdit1
			Me.colPlot.FieldName = "Plot"
			Me.colPlot.Name = "colPlot"
			Me.colPlot.OptionsColumn.AllowFocus = False
			Me.colPlot.OptionsColumn.ReadOnly = True
			Me.colPlot.OptionsFilter.AllowAutoFilter = False
			Me.colPlot.OptionsFilter.AllowFilter = False
			Me.colPlot.RowIndex = 1
			Me.colPlot.Visible = True
			Me.colPlot.Width = 320
			' 
			' repositoryItemMemoEdit1
			' 
			Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
			' 
			' gridBand1
			' 
			Me.gridBand1.Caption = "Data2"
			Me.gridBand1.Columns.Add(Me.colTagline)
			Me.gridBand1.Columns.Add(Me.colAwards)
			Me.gridBand1.MinWidth = 20
			Me.gridBand1.Name = "gridBand1"
			Me.gridBand1.Width = 238
			' 
			' colTagline
			' 
			Me.colTagline.AutoFillDown = True
			Me.colTagline.ColumnEdit = Me.repositoryItemMemoEdit2
			Me.colTagline.FieldName = "Tagline"
			Me.colTagline.Name = "colTagline"
			Me.colTagline.OptionsColumn.AllowFocus = False
			Me.colTagline.OptionsColumn.ReadOnly = True
			Me.colTagline.OptionsFilter.AllowAutoFilter = False
			Me.colTagline.OptionsFilter.AllowFilter = False
			Me.colTagline.RowIndex = 1
			Me.colTagline.Visible = True
			Me.colTagline.Width = 238
			' 
			' repositoryItemMemoEdit2
			' 
			Me.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2"
			' 
			' colAwards
			' 
			Me.colAwards.FieldName = "Awards"
			Me.colAwards.Name = "colAwards"
			Me.colAwards.OptionsColumn.AllowFocus = False
			Me.colAwards.OptionsColumn.ReadOnly = True
			Me.colAwards.Visible = True
			Me.colAwards.Width = 238
			' 
			' gridBand4
			' 
			Me.gridBand4.Caption = "Data3"
			Me.gridBand4.Columns.Add(Me.colGenre)
			Me.gridBand4.Columns.Add(Me.colWebSite)
			Me.gridBand4.Columns.Add(Me.colDirectors)
			Me.gridBand4.Columns.Add(Me.colRunTime)
			Me.gridBand4.Columns.Add(Me.colAspectRatio)
			Me.gridBand4.Columns.Add(Me.colLanguage)
			Me.gridBand4.Columns.Add(Me.colRating)
			Me.gridBand4.Columns.Add(Me.colColor)
			Me.gridBand4.MinWidth = 20
			Me.gridBand4.Name = "gridBand4"
			Me.gridBand4.Width = 360
			' 
			' colGenre
			' 
			Me.colGenre.ColumnEdit = Me.riccbGenre
			Me.colGenre.FieldName = "Genre"
			Me.colGenre.Name = "colGenre"
			Me.colGenre.OptionsColumn.AllowFocus = False
			Me.colGenre.OptionsColumn.ReadOnly = True
			Me.colGenre.Visible = True
			Me.colGenre.Width = 240
			' 
			' riccbGenre
			' 
			Me.riccbGenre.AutoHeight = False
			Me.riccbGenre.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.riccbGenre.Name = "riccbGenre"
			' 
			' colWebSite
			' 
			Me.colWebSite.AppearanceCell.Options.UseTextOptions = True
			Me.colWebSite.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.colWebSite.Caption = "WebSite"
			Me.colWebSite.FieldName = "WebSite"
			Me.colWebSite.Name = "colWebSite"
			Me.colWebSite.OptionsColumn.AllowFocus = False
			Me.colWebSite.OptionsColumn.ReadOnly = True
			Me.colWebSite.Visible = True
			Me.colWebSite.Width = 120
			' 
			' colDirectors
			' 
			Me.colDirectors.FieldName = "Directors"
			Me.colDirectors.Name = "colDirectors"
			Me.colDirectors.OptionsColumn.AllowFocus = False
			Me.colDirectors.OptionsColumn.ReadOnly = True
			Me.colDirectors.RowIndex = 1
			Me.colDirectors.Visible = True
			Me.colDirectors.Width = 120
			' 
			' colRunTime
			' 
			Me.colRunTime.FieldName = "RunTime"
			Me.colRunTime.Name = "colRunTime"
			Me.colRunTime.OptionsColumn.AllowFocus = False
			Me.colRunTime.OptionsColumn.ReadOnly = True
			Me.colRunTime.RowIndex = 1
			Me.colRunTime.Visible = True
			Me.colRunTime.Width = 120
			' 
			' colAspectRatio
			' 
			Me.colAspectRatio.FieldName = "AspectRatio"
			Me.colAspectRatio.Name = "colAspectRatio"
			Me.colAspectRatio.OptionsColumn.AllowFocus = False
			Me.colAspectRatio.OptionsColumn.ReadOnly = True
			Me.colAspectRatio.RowIndex = 1
			Me.colAspectRatio.Visible = True
			Me.colAspectRatio.Width = 120
			' 
			' colLanguage
			' 
			Me.colLanguage.FieldName = "Language!Key"
			Me.colLanguage.Name = "colLanguage"
			Me.colLanguage.OptionsColumn.AllowFocus = False
			Me.colLanguage.OptionsColumn.ReadOnly = True
			Me.colLanguage.RowIndex = 2
			Me.colLanguage.Visible = True
			Me.colLanguage.Width = 120
			' 
			' colRating
			' 
			Me.colRating.FieldName = "Rating"
			Me.colRating.Name = "colRating"
			Me.colRating.OptionsColumn.AllowFocus = False
			Me.colRating.OptionsColumn.ReadOnly = True
			Me.colRating.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
			Me.colRating.RowIndex = 2
			Me.colRating.Visible = True
			Me.colRating.Width = 120
			' 
			' colColor
			' 
			Me.colColor.Caption = "Color"
			Me.colColor.FieldName = "IsColor"
			Me.colColor.Name = "colColor"
			Me.colColor.OptionsColumn.AllowFocus = False
			Me.colColor.OptionsColumn.ReadOnly = True
			Me.colColor.RowIndex = 2
			Me.colColor.Visible = True
			Me.colColor.Width = 120
			' 
			' colInfo
			' 
			Me.colInfo.FieldName = "Info"
			Me.colInfo.Name = "colInfo"
			Me.colInfo.OptionsColumn.ShowInCustomizationForm = False
			Me.colInfo.UnboundType = DevExpress.Data.UnboundColumnType.String
			' 
			' repositoryItemPictureEdit2
			' 
			Me.repositoryItemPictureEdit2.Name = "repositoryItemPictureEdit2"
			Me.repositoryItemPictureEdit2.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
			Me.repositoryItemPictureEdit2.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
			' 
			' repositoryItemMemoEdit3
			' 
			Me.repositoryItemMemoEdit3.Name = "repositoryItemMemoEdit3"
			' 
			' layoutView1
			' 
			Me.layoutView1.CardCaptionFormat = "Movie {0} of {1}"
			Me.layoutView1.CardHorzInterval = 12
			Me.layoutView1.CardMinSize = New System.Drawing.Size(288, 223)
			Me.layoutView1.CardVertInterval = 12
			Me.layoutView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() { Me.colPhoto1, Me.colTitle1, Me.colReleaseDate1, Me.colPlot1})
			Me.layoutView1.GridControl = Me.gridControl1
			Me.layoutView1.Name = "layoutView1"
			Me.layoutView1.OptionsBehavior.Editable = False
			Me.layoutView1.OptionsCustomization.AllowFilter = False
			Me.layoutView1.OptionsCustomization.AllowSort = False
			Me.layoutView1.OptionsFind.AlwaysVisible = True
			Me.layoutView1.OptionsMultiRecordMode.MultiRowScrollBarOrientation = DevExpress.XtraGrid.Views.Layout.ScrollBarOrientation.Vertical
			Me.layoutView1.OptionsView.ContentAlignment = System.Drawing.ContentAlignment.TopCenter
			Me.layoutView1.OptionsView.ShowCardLines = False
			Me.layoutView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
			Me.layoutView1.OptionsView.ShowHeaderPanel = False
			Me.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow
			Me.layoutView1.TemplateCard = Me.layoutViewCard1
			' 
			' colPhoto1
			' 
			Me.colPhoto1.ColumnEdit = Me.repositoryItemPictureEdit2
			Me.colPhoto1.FieldName = "PhotoExist"
			Me.colPhoto1.LayoutViewField = Me.layoutViewField_colPhoto1
			Me.colPhoto1.Name = "colPhoto1"
			Me.colPhoto1.OptionsColumn.AllowFocus = False
			' 
			' layoutViewField_colPhoto1
			' 
			Me.layoutViewField_colPhoto1.EditorPreferredWidth = 118
			Me.layoutViewField_colPhoto1.Location = New System.Drawing.Point(0, 0)
			Me.layoutViewField_colPhoto1.Name = "layoutViewField_colPhoto1"
			Me.layoutViewField_colPhoto1.Size = New System.Drawing.Size(122, 62)
			Me.layoutViewField_colPhoto1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutViewField_colPhoto1.TextToControlDistance = 0
			Me.layoutViewField_colPhoto1.TextVisible = False
			' 
			' colTitle1
			' 
			Me.colTitle1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.colTitle1.AppearanceCell.Options.UseFont = True
			Me.colTitle1.FieldName = "Title"
			Me.colTitle1.LayoutViewField = Me.layoutViewField_colTitle1
			Me.colTitle1.Name = "colTitle1"
			Me.colTitle1.OptionsColumn.AllowFocus = False
			' 
			' layoutViewField_colTitle1
			' 
			Me.layoutViewField_colTitle1.EditorPreferredWidth = 142
			Me.layoutViewField_colTitle1.Location = New System.Drawing.Point(122, 0)
			Me.layoutViewField_colTitle1.Name = "layoutViewField_colTitle1"
			Me.layoutViewField_colTitle1.Size = New System.Drawing.Size(146, 20)
			Me.layoutViewField_colTitle1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutViewField_colTitle1.TextToControlDistance = 0
			Me.layoutViewField_colTitle1.TextVisible = False
			' 
			' colReleaseDate1
			' 
			Me.colReleaseDate1.FieldName = "ReleaseDate"
			Me.colReleaseDate1.LayoutViewField = Me.layoutViewField_colReleaseDate1
			Me.colReleaseDate1.Name = "colReleaseDate1"
			Me.colReleaseDate1.OptionsColumn.AllowFocus = False
			' 
			' layoutViewField_colReleaseDate1
			' 
			Me.layoutViewField_colReleaseDate1.EditorPreferredWidth = 142
			Me.layoutViewField_colReleaseDate1.Location = New System.Drawing.Point(122, 20)
			Me.layoutViewField_colReleaseDate1.Name = "layoutViewField_colReleaseDate1"
			Me.layoutViewField_colReleaseDate1.Size = New System.Drawing.Size(146, 20)
			Me.layoutViewField_colReleaseDate1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutViewField_colReleaseDate1.TextToControlDistance = 0
			Me.layoutViewField_colReleaseDate1.TextVisible = False
			' 
			' colPlot1
			' 
			Me.colPlot1.ColumnEdit = Me.repositoryItemMemoEdit3
			Me.colPlot1.FieldName = "Plot"
			Me.colPlot1.LayoutViewField = Me.layoutViewField_colPlot1
			Me.colPlot1.Name = "colPlot1"
			Me.colPlot1.OptionsColumn.AllowFocus = False
			' 
			' layoutViewField_colPlot1
			' 
			Me.layoutViewField_colPlot1.EditorPreferredWidth = 142
			Me.layoutViewField_colPlot1.Location = New System.Drawing.Point(122, 40)
			Me.layoutViewField_colPlot1.Name = "layoutViewField_colPlot1"
			Me.layoutViewField_colPlot1.Size = New System.Drawing.Size(146, 22)
			Me.layoutViewField_colPlot1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutViewField_colPlot1.TextToControlDistance = 0
			Me.layoutViewField_colPlot1.TextVisible = False
			' 
			' layoutViewCard1
			' 
			Me.layoutViewCard1.CustomizationFormText = "TemplateCard"
            Me.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
			Me.layoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_colPhoto1, Me.layoutViewField_colPlot1, Me.layoutViewField_colTitle1, Me.layoutViewField_colReleaseDate1})
			Me.layoutViewCard1.Name = "layoutViewCard1"
			Me.layoutViewCard1.OptionsItemText.TextToControlDistance = 5
			Me.layoutViewCard1.Text = "TemplateCard"
			' 
			' dockManager1
			' 
			Me.dockManager1.Form = Me
			Me.dockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() { Me.dpScreens})
			Me.dockManager1.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
			' 
			' dpScreens
			' 
			Me.dpScreens.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(227))))), (CInt(Fix((CByte(241))))), (CInt(Fix((CByte(254))))))
			Me.dpScreens.Appearance.Options.UseBackColor = True
			Me.dpScreens.Controls.Add(Me.dockPanel1_Container)
			Me.dpScreens.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
			Me.dpScreens.FloatSize = New System.Drawing.Size(250, 250)
			Me.dpScreens.ID = New System.Guid("35b1abb6-71d4-4f79-a3f3-15c353bb45b9")
			Me.dpScreens.Location = New System.Drawing.Point(783, 0)
			Me.dpScreens.Name = "dpScreens"
			Me.dpScreens.Options.AllowDockBottom = False
			Me.dpScreens.Options.AllowDockFill = False
			Me.dpScreens.Options.AllowDockTop = False
			Me.dpScreens.Options.AllowFloating = False
			Me.dpScreens.Options.ShowCloseButton = False
			Me.dpScreens.OriginalSize = New System.Drawing.Size(250, 200)
			Me.dpScreens.Size = New System.Drawing.Size(250, 576)
			Me.dpScreens.Text = "Screens"
			' 
			' dockPanel1_Container
			' 
			Me.dockPanel1_Container.Controls.Add(Me.ucScreens1)
			Me.dockPanel1_Container.Location = New System.Drawing.Point(2, 24)
			Me.dockPanel1_Container.Name = "dockPanel1_Container"
			Me.dockPanel1_Container.Size = New System.Drawing.Size(246, 550)
			Me.dockPanel1_Container.TabIndex = 0
			' 
			' ucScreens1
			' 
			Me.ucScreens1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.ucScreens1.Location = New System.Drawing.Point(0, 0)
			Me.ucScreens1.Name = "ucScreens1"
			Me.ucScreens1.Size = New System.Drawing.Size(246, 550)
			Me.ucScreens1.TabIndex = 0
			' 
			' pnlMoviesContainer
			' 
			Me.pnlMoviesContainer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pnlMoviesContainer.Controls.Add(Me.gridControl1)
			Me.pnlMoviesContainer.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pnlMoviesContainer.Location = New System.Drawing.Point(0, 0)
			Me.pnlMoviesContainer.Name = "pnlMoviesContainer"
			Me.pnlMoviesContainer.Padding = New System.Windows.Forms.Padding(6)
			Me.pnlMoviesContainer.Size = New System.Drawing.Size(783, 576)
			Me.pnlMoviesContainer.TabIndex = 3
			' 
			' Movies
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.pnlMoviesContainer)
			Me.Controls.Add(Me.dpScreens)
			Me.Name = "Movies"
			Me.Size = New System.Drawing.Size(1033, 576)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xcMovies, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.riccbGenre, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMemoEdit3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colPhoto1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colTitle1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colReleaseDate1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colPlot1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.dpScreens.ResumeLayout(False)
			Me.dockPanel1_Container.ResumeLayout(False)
			CType(Me.pnlMoviesContainer, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlMoviesContainer.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
		Private xcMovies As DevExpress.Xpo.XPCollection
		Private WithEvents advBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
		Private colPhoto As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colTitle As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colTagline As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colReleaseDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colWebSite As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colRunTime As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colColor As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colPlot As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private repositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
		Private repositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
		Private colAwards As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colPicturesCount As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colAspectRatio As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colGenre As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colRating As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colLanguage As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private riccbGenre As DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit
		Private dockManager1 As DevExpress.XtraBars.Docking.DockManager
		Private dpScreens As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private ucScreens1 As DevExpress.VideoRent.Win.Controls.ucScreens
		Private pnlMoviesContainer As DevExpress.XtraEditors.PanelControl
		Private layoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
		Private colPhoto1 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private repositoryItemPictureEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private colTitle1 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colReleaseDate1 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colPlot1 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private repositoryItemMemoEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
		Private layoutViewField_colPhoto1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colTitle1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colReleaseDate1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colPlot1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
		Private colDirectors As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colInfo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
	End Class
End Namespace
