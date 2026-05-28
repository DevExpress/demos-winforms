Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Modules
	Partial Public Class MovieDetail
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso ((Not Object.Equals(components, Nothing))) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.deReleaseDate = New DevExpress.XtraEditors.DateEdit()
			Me.teRunTime = New DevExpress.XtraEditors.TimeEdit()
			Me.ccbGenre = New DevExpress.XtraEditors.CheckedComboBoxEdit()
			Me.ceIsColor = New DevExpress.XtraEditors.CheckEdit()
			Me.pePhoto = New DevExpress.XtraEditors.PictureEdit()
			Me.teAwards = New DevExpress.XtraEditors.TextEdit()
			Me.meTagline = New DevExpress.XtraEditors.MemoEdit()
			Me.mePlot = New DevExpress.XtraEditors.MemoEdit()
			Me.teAspectRatio = New DevExpress.XtraEditors.TextEdit()
			Me.lciPhoto = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciTitle = New DevExpress.XtraLayout.LayoutControlItem()
			Me.teTitle = New DevExpress.XtraEditors.MemoEdit()
			Me.tabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
			Me.lcgGeneralInfo = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lciPlot = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciAwards = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciTagline = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciGenre = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciRealeaseDate = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciRating = New DevExpress.XtraLayout.LayoutControlItem()
			Me.icbRating = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.lcgAdditionalDetail = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lciWebSite = New DevExpress.XtraLayout.LayoutControlItem()
			Me.teWebSite = New DevExpress.XtraEditors.ButtonEdit()
			Me.lciAspectRatio = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciRunTime = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciIsColor = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciCountries = New DevExpress.XtraLayout.LayoutControlItem()
			Me.ccbCountries = New DevExpress.XtraEditors.CheckedComboBoxEdit()
			Me.lciLanguage = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lueLanguage = New DevExpress.XtraEditors.LookUpEdit()
			Me.lcgCompanies = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lciCompanies = New DevExpress.XtraLayout.LayoutControlItem()
			Me.gcCompanies = New DevExpress.XtraGrid.GridControl()
			Me.gvCompanies = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colCompany = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCompanyDescription = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemMemoExEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
			Me.repositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
			Me.lciGridCompaniesBar = New DevExpress.XtraLayout.LayoutControlItem()
			Me.ucGridEditBarCompanies = New DevExpress.VideoRent.Win.Controls.ucGridEditBar()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.lcgArtist = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lciDirector = New DevExpress.XtraLayout.LayoutControlItem()
			Me.teDirectors = New DevExpress.XtraEditors.TextEdit()
			Me.lcgArtists = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lciArtists = New DevExpress.XtraLayout.LayoutControlItem()
			Me.gcArtists = New DevExpress.XtraGrid.GridControl()
			Me.gvArtist = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colArtist = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
			Me.colLine = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.lciGridArtistBar = New DevExpress.XtraLayout.LayoutControlItem()
			Me.ucGridEditBarArtist = New DevExpress.VideoRent.Win.Controls.ucGridEditBar()
			Me.lcgRentalInfo = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lciCategory = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lueCategory = New DevExpress.XtraEditors.LookUpEdit()
			Me.lciFormatsInfo = New DevExpress.XtraLayout.LayoutControlItem()
			Me.ucMovieFormatsInfo = New DevExpress.VideoRent.Win.Controls.ucMovieItemsInfo()
			Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem()
			Me.ucPictureEditBar1 = New DevExpress.VideoRent.Win.Controls.ucPictureEditBar()
			Me.lciBar = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.lcMain.SuspendLayout()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.deReleaseDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.deReleaseDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teRunTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ccbGenre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceIsColor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pePhoto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teAwards.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.meTagline.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.mePlot.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teAspectRatio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciTitle, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcgGeneralInfo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciPlot, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciAwards, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciTagline, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciGenre, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciRealeaseDate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciRating, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbRating.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcgAdditionalDetail, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciWebSite, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teWebSite.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciAspectRatio, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciRunTime, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciIsColor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciCountries, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ccbCountries.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciLanguage, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lueLanguage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcgCompanies, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciCompanies, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gcCompanies, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gvCompanies, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMemoExEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciGridCompaniesBar, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcgArtist, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciDirector, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teDirectors.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcgArtists, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciArtists, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gcArtists, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gvArtist, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciGridArtistBar, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcgRentalInfo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciCategory, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lueCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciFormatsInfo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciBar, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' lcMain
			' 
			Me.lcMain.Controls.Add(Me.ucPictureEditBar1)
			Me.lcMain.Controls.Add(Me.ucGridEditBarCompanies)
			Me.lcMain.Controls.Add(Me.ccbCountries)
			Me.lcMain.Controls.Add(Me.gcCompanies)
			Me.lcMain.Controls.Add(Me.ucGridEditBarArtist)
			Me.lcMain.Controls.Add(Me.lueCategory)
			Me.lcMain.Controls.Add(Me.ucMovieFormatsInfo)
			Me.lcMain.Controls.Add(Me.gcArtists)
			Me.lcMain.Controls.Add(Me.teDirectors)
			Me.lcMain.Controls.Add(Me.mePlot)
			Me.lcMain.Controls.Add(Me.teAspectRatio)
			Me.lcMain.Controls.Add(Me.teAwards)
			Me.lcMain.Controls.Add(Me.teRunTime)
			Me.lcMain.Controls.Add(Me.ccbGenre)
			Me.lcMain.Controls.Add(Me.pePhoto)
			Me.lcMain.Controls.Add(Me.deReleaseDate)
			Me.lcMain.Controls.Add(Me.ceIsColor)
			Me.lcMain.Controls.Add(Me.teTitle)
			Me.lcMain.Controls.Add(Me.meTagline)
			Me.lcMain.Controls.Add(Me.teWebSite)
			Me.lcMain.Controls.Add(Me.lueLanguage)
			Me.lcMain.Controls.Add(Me.icbRating)
			Me.lcMain.Size = New System.Drawing.Size(821, 509)
			' 
			' lcgMain
			' 
			Me.lcgMain.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciTitle, Me.lciBar, Me.tabbedControlGroup1, Me.splitterItem1, Me.lciPhoto})
			Me.lcgMain.Name = "Root"
			Me.lcgMain.Size = New System.Drawing.Size(821, 509)
			Me.lcgMain.Text = "Root"
			' 
			' deReleaseDate
			' 
			Me.deReleaseDate.EditValue = Nothing
			Me.deReleaseDate.Location = New System.Drawing.Point(364, 40)
			Me.deReleaseDate.Name = "deReleaseDate"
			Me.deReleaseDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.deReleaseDate.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True
			Me.deReleaseDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.deReleaseDate.Size = New System.Drawing.Size(174, 20)
			Me.deReleaseDate.StyleController = Me.lcMain
			Me.deReleaseDate.TabIndex = 5
			' 
			' teRunTime
			' 
			Me.teRunTime.EditValue = New System.DateTime(2010, 2, 5, 0, 0, 0, 0)
			Me.teRunTime.Location = New System.Drawing.Point(700, 40)
			Me.teRunTime.Name = "teRunTime"
			Me.teRunTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.teRunTime.Properties.Mask.EditMask = "HH:mm:ss"
			Me.teRunTime.Size = New System.Drawing.Size(102, 20)
			Me.teRunTime.StyleController = Me.lcMain
			Me.teRunTime.TabIndex = 6
			' 
			' ccbGenre
			' 
			Me.ccbGenre.Location = New System.Drawing.Point(364, 64)
			Me.ccbGenre.Name = "ccbGenre"
			Me.ccbGenre.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.ccbGenre.Properties.DropDownRows = 20
			Me.ccbGenre.Size = New System.Drawing.Size(438, 20)
			Me.ccbGenre.StyleController = Me.lcMain
			Me.ccbGenre.TabIndex = 7
			' 
			' ceIsColor
			' 
			Me.ceIsColor.Location = New System.Drawing.Point(277, 112)
			Me.ceIsColor.Name = "ceIsColor"
			Me.ceIsColor.Properties.Caption = "Color"
			Me.ceIsColor.Size = New System.Drawing.Size(77, 18)
			Me.ceIsColor.StyleController = Me.lcMain
			Me.ceIsColor.TabIndex = 8
			' 
			' pePhoto
			' 
			Me.pePhoto.Location = New System.Drawing.Point(8, 63)
			Me.pePhoto.Name = "pePhoto"
			Me.pePhoto.Properties.AllowFocused = False
			Me.pePhoto.Properties.ShowMenu = False
			Me.pePhoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
			Me.pePhoto.Size = New System.Drawing.Size(248, 408)
			Me.pePhoto.StyleController = Me.lcMain
			Me.pePhoto.TabIndex = 10
			' 
			' teAwards
			' 
			Me.teAwards.Location = New System.Drawing.Point(364, 470)
			Me.teAwards.Name = "teAwards"
			Me.teAwards.Size = New System.Drawing.Size(438, 20)
			Me.teAwards.StyleController = Me.lcMain
			Me.teAwards.TabIndex = 11
			' 
			' meTagline
			' 
			Me.meTagline.Location = New System.Drawing.Point(364, 303)
			Me.meTagline.Name = "meTagline"
			Me.meTagline.Size = New System.Drawing.Size(438, 163)
			Me.meTagline.StyleController = Me.lcMain
			Me.meTagline.TabIndex = 12
			' 
			' mePlot
			' 
			Me.mePlot.Location = New System.Drawing.Point(364, 88)
			Me.mePlot.Name = "mePlot"
			Me.mePlot.Size = New System.Drawing.Size(438, 211)
			Me.mePlot.StyleController = Me.lcMain
			Me.mePlot.TabIndex = 13
			' 
			' teAspectRatio
			' 
			Me.teAspectRatio.Location = New System.Drawing.Point(364, 40)
			Me.teAspectRatio.Name = "teAspectRatio"
			Me.teAspectRatio.Properties.Mask.EditMask = "[0-9.]+ : \d+"
			Me.teAspectRatio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
			Me.teAspectRatio.Size = New System.Drawing.Size(245, 20)
			Me.teAspectRatio.StyleController = Me.lcMain
			Me.teAspectRatio.TabIndex = 15
			' 
			' lciPhoto
			' 
			Me.lciPhoto.Control = Me.pePhoto
			Me.lciPhoto.CustomizationFormText = "layoutControlItem1"
			Me.lciPhoto.Location = New System.Drawing.Point(0, 55)
			Me.lciPhoto.Name = "lciPhoto"
			Me.lciPhoto.Size = New System.Drawing.Size(252, 412)
			Me.lciPhoto.Text = "lciPhoto"
			Me.lciPhoto.TextSize = New System.Drawing.Size(0, 0)
			Me.lciPhoto.TextToControlDistance = 0
			Me.lciPhoto.TextVisible = False
			' 
			' lciTitle
			' 
			Me.lciTitle.AllowHide = False
			Me.lciTitle.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.lciTitle.AppearanceItemCaption.Options.UseFont = True
			Me.lciTitle.Control = Me.teTitle
			Me.lciTitle.CustomizationFormText = "layoutControlItem2"
			Me.lciTitle.Location = New System.Drawing.Point(0, 0)
			Me.lciTitle.MaxSize = New System.Drawing.Size(0, 55)
			Me.lciTitle.MinSize = New System.Drawing.Size(74, 55)
			Me.lciTitle.Name = "lciTitle"
			Me.lciTitle.Size = New System.Drawing.Size(252, 55)
			Me.lciTitle.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.lciTitle.Text = "Title:"
			Me.lciTitle.TextLocation = DevExpress.Utils.Locations.Top
			Me.lciTitle.TextSize = New System.Drawing.Size(83, 13)
			' 
			' teTitle
			' 
			Me.teTitle.Location = New System.Drawing.Point(8, 24)
			Me.teTitle.Name = "teTitle"
			Me.teTitle.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.teTitle.Properties.Appearance.Options.UseFont = True
			Me.teTitle.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
			Me.teTitle.Size = New System.Drawing.Size(248, 35)
			Me.teTitle.StyleController = Me.lcMain
			Me.teTitle.TabIndex = 2
			' 
			' tabbedControlGroup1
			' 
			Me.tabbedControlGroup1.CustomizationFormText = "tabbedControlGroup1"
			Me.tabbedControlGroup1.Location = New System.Drawing.Point(258, 0)
			Me.tabbedControlGroup1.Name = "tabbedControlGroup1"
			Me.tabbedControlGroup1.SelectedTabPage = Me.lcgGeneralInfo
			Me.tabbedControlGroup1.SelectedTabPageIndex = 0
			Me.tabbedControlGroup1.Size = New System.Drawing.Size(551, 497)
			Me.tabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lcgGeneralInfo, Me.lcgAdditionalDetail, Me.lcgArtist, Me.lcgRentalInfo})
			Me.tabbedControlGroup1.Text = "tabbedControlGroup1"
			' 
			' lcgGeneralInfo
			' 
			Me.lcgGeneralInfo.CustomizationFormText = "General Info"
			Me.lcgGeneralInfo.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciPlot, Me.lciAwards, Me.lciTagline, Me.lciGenre, Me.lciRealeaseDate, Me.lciRating})
			Me.lcgGeneralInfo.Location = New System.Drawing.Point(0, 0)
			Me.lcgGeneralInfo.Name = "lcgGeneralInfo"
			Me.lcgGeneralInfo.Size = New System.Drawing.Size(529, 454)
			Me.lcgGeneralInfo.Text = "General Info"
			' 
			' lciPlot
			' 
			Me.lciPlot.AppearanceItemCaption.Options.UseTextOptions = True
			Me.lciPlot.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
			Me.lciPlot.Control = Me.mePlot
			Me.lciPlot.CustomizationFormText = "layoutControlItem11"
			Me.lciPlot.Location = New System.Drawing.Point(0, 48)
			Me.lciPlot.Name = "lciPlot"
			Me.lciPlot.Size = New System.Drawing.Size(529, 215)
			Me.lciPlot.Text = "Plot:"
			Me.lciPlot.TextSize = New System.Drawing.Size(83, 13)
			' 
			' lciAwards
			' 
			Me.lciAwards.Control = Me.teAwards
			Me.lciAwards.CustomizationFormText = "layoutControlItem8"
			Me.lciAwards.Location = New System.Drawing.Point(0, 430)
			Me.lciAwards.Name = "lciAwards"
			Me.lciAwards.Size = New System.Drawing.Size(529, 24)
			Me.lciAwards.Text = "Awards:"
			Me.lciAwards.TextSize = New System.Drawing.Size(83, 13)
			' 
			' lciTagline
			' 
			Me.lciTagline.AppearanceItemCaption.Options.UseTextOptions = True
			Me.lciTagline.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
			Me.lciTagline.Control = Me.meTagline
			Me.lciTagline.CustomizationFormText = "layoutControlItem2"
			Me.lciTagline.Location = New System.Drawing.Point(0, 263)
			Me.lciTagline.Name = "lciTagline"
			Me.lciTagline.Size = New System.Drawing.Size(529, 167)
			Me.lciTagline.Text = "Tagline:"
			Me.lciTagline.TextSize = New System.Drawing.Size(83, 13)
			' 
			' lciGenre
			' 
			Me.lciGenre.Control = Me.ccbGenre
			Me.lciGenre.CustomizationFormText = "layoutControlItem4"
			Me.lciGenre.Location = New System.Drawing.Point(0, 24)
			Me.lciGenre.Name = "lciGenre"
			Me.lciGenre.Size = New System.Drawing.Size(529, 24)
			Me.lciGenre.Text = "Genre:"
			Me.lciGenre.TextSize = New System.Drawing.Size(83, 13)
			' 
			' lciRealeaseDate
			' 
			Me.lciRealeaseDate.Control = Me.deReleaseDate
			Me.lciRealeaseDate.CustomizationFormText = "layoutControlItem6"
			Me.lciRealeaseDate.Location = New System.Drawing.Point(0, 0)
			Me.lciRealeaseDate.Name = "lciRealeaseDate"
			Me.lciRealeaseDate.Size = New System.Drawing.Size(265, 24)
			Me.lciRealeaseDate.Text = "Realease Date:"
			Me.lciRealeaseDate.TextSize = New System.Drawing.Size(83, 13)
			' 
			' lciRating
			' 
			Me.lciRating.Control = Me.icbRating
			Me.lciRating.CustomizationFormText = "layoutControlItem5"
			Me.lciRating.Location = New System.Drawing.Point(265, 0)
			Me.lciRating.Name = "lciRating"
			Me.lciRating.Size = New System.Drawing.Size(264, 24)
			Me.lciRating.Text = "Rating:"
			Me.lciRating.TextSize = New System.Drawing.Size(83, 13)
			' 
			' icbRating
			' 
			Me.icbRating.Location = New System.Drawing.Point(629, 40)
			Me.icbRating.Name = "icbRating"
			Me.icbRating.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbRating.Size = New System.Drawing.Size(173, 20)
			Me.icbRating.StyleController = Me.lcMain
			Me.icbRating.TabIndex = 4
			' 
			' lcgAdditionalDetail
			' 
			Me.lcgAdditionalDetail.CustomizationFormText = "Additional Details"
			Me.lcgAdditionalDetail.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciWebSite, Me.lciAspectRatio, Me.lciRunTime, Me.lciIsColor, Me.lciCountries, Me.lciLanguage, Me.lcgCompanies, Me.emptySpaceItem1})
			Me.lcgAdditionalDetail.Location = New System.Drawing.Point(0, 0)
			Me.lcgAdditionalDetail.Name = "lcgAdditionalDetail"
			Me.lcgAdditionalDetail.Size = New System.Drawing.Size(529, 454)
			Me.lcgAdditionalDetail.Text = "Additional Details"
			' 
			' lciWebSite
			' 
			Me.lciWebSite.Control = Me.teWebSite
			Me.lciWebSite.CustomizationFormText = "layoutControlItem9"
			Me.lciWebSite.Location = New System.Drawing.Point(0, 48)
			Me.lciWebSite.Name = "lciWebSite"
			Me.lciWebSite.Size = New System.Drawing.Size(529, 24)
			Me.lciWebSite.Text = "Web Site:"
			Me.lciWebSite.TextSize = New System.Drawing.Size(83, 13)
			' 
			' teWebSite
			' 
			Me.teWebSite.Location = New System.Drawing.Point(364, 88)
			Me.teWebSite.Name = "teWebSite"
			Me.teWebSite.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Go to Website", Nothing, Nothing, True)})
			Me.teWebSite.Size = New System.Drawing.Size(438, 20)
			Me.teWebSite.StyleController = Me.lcMain
			Me.teWebSite.TabIndex = 14
			Me.teWebSite.TabStop = False
'			Me.teWebSite.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.teWebSite_ButtonClick);
			' 
			' lciAspectRatio
			' 
			Me.lciAspectRatio.Control = Me.teAspectRatio
			Me.lciAspectRatio.CustomizationFormText = "layoutControlItem10"
			Me.lciAspectRatio.Location = New System.Drawing.Point(0, 0)
			Me.lciAspectRatio.Name = "lciAspectRatio"
			Me.lciAspectRatio.Size = New System.Drawing.Size(336, 24)
			Me.lciAspectRatio.Text = "Aspect Ratio:"
			Me.lciAspectRatio.TextSize = New System.Drawing.Size(83, 13)
			' 
			' lciRunTime
			' 
			Me.lciRunTime.Control = Me.teRunTime
			Me.lciRunTime.CustomizationFormText = "layoutControlItem3"
			Me.lciRunTime.Location = New System.Drawing.Point(336, 0)
			Me.lciRunTime.Name = "lciRunTime"
			Me.lciRunTime.Size = New System.Drawing.Size(193, 24)
			Me.lciRunTime.Text = "Run Time:"
			Me.lciRunTime.TextSize = New System.Drawing.Size(83, 13)
			' 
			' lciIsColor
			' 
			Me.lciIsColor.Control = Me.ceIsColor
			Me.lciIsColor.CustomizationFormText = "layoutControlItem12"
			Me.lciIsColor.Location = New System.Drawing.Point(0, 72)
			Me.lciIsColor.MaxSize = New System.Drawing.Size(81, 22)
			Me.lciIsColor.MinSize = New System.Drawing.Size(81, 22)
			Me.lciIsColor.Name = "lciIsColor"
			Me.lciIsColor.Size = New System.Drawing.Size(81, 22)
			Me.lciIsColor.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.lciIsColor.Text = " "
			Me.lciIsColor.TextSize = New System.Drawing.Size(0, 0)
			Me.lciIsColor.TextToControlDistance = 0
			Me.lciIsColor.TextVisible = False
			' 
			' lciCountries
			' 
			Me.lciCountries.Control = Me.ccbCountries
			Me.lciCountries.CustomizationFormText = "Countries"
			Me.lciCountries.Location = New System.Drawing.Point(0, 24)
			Me.lciCountries.Name = "lciCountries"
			Me.lciCountries.Size = New System.Drawing.Size(336, 24)
			Me.lciCountries.Text = "Countries:"
			Me.lciCountries.TextSize = New System.Drawing.Size(83, 13)
			' 
			' ccbCountries
			' 
			Me.ccbCountries.Location = New System.Drawing.Point(364, 64)
			Me.ccbCountries.Name = "ccbCountries"
			Me.ccbCountries.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.ccbCountries.Size = New System.Drawing.Size(245, 20)
			Me.ccbCountries.StyleController = Me.lcMain
			Me.ccbCountries.TabIndex = 21
			' 
			' lciLanguage
			' 
			Me.lciLanguage.Control = Me.lueLanguage
			Me.lciLanguage.CustomizationFormText = "layoutControlItem7"
			Me.lciLanguage.Location = New System.Drawing.Point(336, 24)
			Me.lciLanguage.Name = "lciLanguage"
			Me.lciLanguage.Size = New System.Drawing.Size(193, 24)
			Me.lciLanguage.Text = "Language:"
			Me.lciLanguage.TextSize = New System.Drawing.Size(83, 13)
			' 
			' lueLanguage
			' 
			Me.lueLanguage.Location = New System.Drawing.Point(700, 64)
			Me.lueLanguage.Name = "lueLanguage"
			Me.lueLanguage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.lueLanguage.Properties.NullText = ""
			Me.lueLanguage.Properties.PopupSizeable = False
			Me.lueLanguage.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
			Me.lueLanguage.Size = New System.Drawing.Size(102, 20)
			Me.lueLanguage.StyleController = Me.lcMain
			Me.lueLanguage.TabIndex = 16
			Me.lueLanguage.TabStop = False
			' 
			' lcgCompanies
			' 
			Me.lcgCompanies.CustomizationFormText = "Companies"
			Me.lcgCompanies.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciCompanies, Me.lciGridCompaniesBar})
			Me.lcgCompanies.Location = New System.Drawing.Point(0, 94)
			Me.lcgCompanies.Name = "lcgCompanies"
			Me.lcgCompanies.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lcgCompanies.Size = New System.Drawing.Size(529, 360)
			Me.lcgCompanies.Text = "Companies"
			' 
			' lciCompanies
			' 
			Me.lciCompanies.Control = Me.gcCompanies
			Me.lciCompanies.CustomizationFormText = "Companies"
			Me.lciCompanies.Location = New System.Drawing.Point(0, 30)
			Me.lciCompanies.Name = "lciCompanies"
			Me.lciCompanies.Size = New System.Drawing.Size(521, 302)
			Me.lciCompanies.Text = "Companies:"
			Me.lciCompanies.TextLocation = DevExpress.Utils.Locations.Top
			Me.lciCompanies.TextSize = New System.Drawing.Size(0, 0)
			Me.lciCompanies.TextToControlDistance = 0
			Me.lciCompanies.TextVisible = False
			' 
			' gcCompanies
			' 
			Me.gcCompanies.Location = New System.Drawing.Point(281, 188)
			Me.gcCompanies.MainView = Me.gvCompanies
			Me.gcCompanies.Name = "gcCompanies"
			Me.gcCompanies.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemMemoExEdit2, Me.repositoryItemMemoExEdit3})
			Me.gcCompanies.ShowOnlyPredefinedDetails = True
			Me.gcCompanies.Size = New System.Drawing.Size(517, 298)
			Me.gcCompanies.TabIndex = 20
			Me.gcCompanies.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gvCompanies})
			' 
			' gvCompanies
			' 
			Me.gvCompanies.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.gvCompanies.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCompany, Me.colCompanyDescription})
			Me.gvCompanies.GridControl = Me.gcCompanies
			Me.gvCompanies.Name = "gvCompanies"
			Me.gvCompanies.OptionsView.ShowGroupPanel = False
            Me.gvCompanies.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False
            ' 
            ' colCompany
            ' 
            Me.colCompany.Caption = "Company"
            Me.colCompany.FieldName = "Company!"
            Me.colCompany.Name = "colCompany"
            Me.colCompany.Visible = True
            Me.colCompany.VisibleIndex = 0
            Me.colCompany.Width = 380
            ' 
            ' colCompanyDescription
            ' 
            Me.colCompanyDescription.Caption = "Description"
            Me.colCompanyDescription.ColumnEdit = Me.repositoryItemMemoExEdit3
            Me.colCompanyDescription.FieldName = "Description"
            Me.colCompanyDescription.Name = "colCompanyDescription"
            Me.colCompanyDescription.Visible = True
            Me.colCompanyDescription.VisibleIndex = 1
            Me.colCompanyDescription.Width = 105
            ' 
            ' repositoryItemMemoExEdit3
            ' 
            Me.repositoryItemMemoExEdit3.AutoHeight = False
            Me.repositoryItemMemoExEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemMemoExEdit3.Name = "repositoryItemMemoExEdit3"
            ' 
            ' repositoryItemMemoExEdit2
            ' 
            Me.repositoryItemMemoExEdit2.AutoHeight = False
            Me.repositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemMemoExEdit2.Name = "repositoryItemMemoExEdit2"
            ' 
            ' lciGridCompaniesBar
            ' 
            Me.lciGridCompaniesBar.Control = Me.ucGridEditBarCompanies
            Me.lciGridCompaniesBar.CustomizationFormText = "lciGridCompaniesBar"
            Me.lciGridCompaniesBar.Location = New System.Drawing.Point(0, 0)
            Me.lciGridCompaniesBar.Name = "lciGridCompaniesBar"
            Me.lciGridCompaniesBar.Size = New System.Drawing.Size(521, 30)
            Me.lciGridCompaniesBar.Text = "lciGridCompaniesBar"
            Me.lciGridCompaniesBar.TextSize = New System.Drawing.Size(0, 0)
            Me.lciGridCompaniesBar.TextToControlDistance = 0
            Me.lciGridCompaniesBar.TextVisible = False
            ' 
            ' ucGridEditBarCompanies
            ' 
            Me.ucGridEditBarCompanies.Location = New System.Drawing.Point(281, 158)
            Me.ucGridEditBarCompanies.Name = "ucGridEditBarCompanies"
            Me.ucGridEditBarCompanies.Size = New System.Drawing.Size(517, 26)
            Me.ucGridEditBarCompanies.TabIndex = 25
            '			Me.ucGridEditBarCompanies.DeleteRecord += New System.EventHandler(Me.ucGridEditBarCompanies_DeleteRecord);
            '			Me.ucGridEditBarCompanies.AddRecord += New System.EventHandler(Me.ucGridEditBarCompanies_AddRecord);
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(81, 72)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(448, 22)
            Me.emptySpaceItem1.Text = "emptySpaceItem1"
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' lcgArtist
            ' 
            Me.lcgArtist.CustomizationFormText = "Actors/Crew"
            Me.lcgArtist.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciDirector, Me.lcgArtists})
            Me.lcgArtist.Location = New System.Drawing.Point(0, 0)
            Me.lcgArtist.Name = "lcgArtist"
            Me.lcgArtist.Size = New System.Drawing.Size(529, 454)
            Me.lcgArtist.Text = "Actors/Crew"
            ' 
            ' lciDirector
            ' 
            Me.lciDirector.Control = Me.teDirectors
            Me.lciDirector.CustomizationFormText = "Director"
            Me.lciDirector.Location = New System.Drawing.Point(0, 0)
            Me.lciDirector.Name = "lciDirector"
            Me.lciDirector.Size = New System.Drawing.Size(529, 24)
            Me.lciDirector.Text = "Directors:"
            Me.lciDirector.TextSize = New System.Drawing.Size(83, 13)
            ' 
            ' teDirectors
            ' 
            Me.teDirectors.Location = New System.Drawing.Point(364, 40)
            Me.teDirectors.Name = "teDirectors"
            Me.teDirectors.Properties.ReadOnly = True
            Me.teDirectors.Size = New System.Drawing.Size(438, 20)
            Me.teDirectors.StyleController = Me.lcMain
            Me.teDirectors.TabIndex = 17
            ' 
            ' lcgArtists
            ' 
            Me.lcgArtists.CustomizationFormText = "Actors/Crew"
            Me.lcgArtists.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciArtists, Me.lciGridArtistBar})
            Me.lcgArtists.Location = New System.Drawing.Point(0, 24)
            Me.lcgArtists.Name = "lcgArtists"
            Me.lcgArtists.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lcgArtists.Size = New System.Drawing.Size(529, 430)
            Me.lcgArtists.Text = "Actors/Crew"
            ' 
            ' lciArtists
            ' 
            Me.lciArtists.Control = Me.gcArtists
            Me.lciArtists.CustomizationFormText = "layoutControlItem2"
            Me.lciArtists.Location = New System.Drawing.Point(0, 30)
            Me.lciArtists.Name = "lciArtists"
            Me.lciArtists.Size = New System.Drawing.Size(521, 372)
            Me.lciArtists.Text = "Actors/Crew:"
            Me.lciArtists.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciArtists.TextSize = New System.Drawing.Size(0, 0)
            Me.lciArtists.TextToControlDistance = 0
            Me.lciArtists.TextVisible = False
            ' 
            ' gcArtists
            ' 
            Me.gcArtists.Location = New System.Drawing.Point(281, 118)
            Me.gcArtists.MainView = Me.gvArtist
            Me.gcArtists.Name = "gcArtists"
            Me.gcArtists.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemMemoExEdit1})
            Me.gcArtists.ShowOnlyPredefinedDetails = True
            Me.gcArtists.Size = New System.Drawing.Size(517, 368)
            Me.gcArtists.TabIndex = 19
            Me.gcArtists.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvArtist})
            ' 
            ' gvArtist
            ' 
            Me.gvArtist.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gvArtist.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colArtist, Me.colDescription, Me.colLine})
            Me.gvArtist.GridControl = Me.gcArtists
            Me.gvArtist.Name = "gvArtist"
            Me.gvArtist.OptionsView.ShowAutoFilterRow = True
            Me.gvArtist.OptionsView.ShowGroupPanel = False
            Me.gvArtist.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False
'			Me.gvArtist.CustomDrawCell += New DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(Me.gvArtist_CustomDrawCell);
'			Me.gvArtist.ValidateRow += New DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(Me.gvArtist_ValidateRow);
			' 
			' colArtist
			' 
			Me.colArtist.Caption = "Name"
			Me.colArtist.FieldName = "Artist!"
			Me.colArtist.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
			Me.colArtist.Name = "colArtist"
			Me.colArtist.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
			Me.colArtist.Visible = True
			Me.colArtist.VisibleIndex = 0
			Me.colArtist.Width = 178
			' 
			' colDescription
			' 
			Me.colDescription.ColumnEdit = Me.repositoryItemMemoExEdit1
			Me.colDescription.FieldName = "Description"
			Me.colDescription.Name = "colDescription"
			Me.colDescription.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			Me.colDescription.OptionsFilter.AllowFilter = False
			Me.colDescription.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
			Me.colDescription.Visible = True
			Me.colDescription.VisibleIndex = 2
			Me.colDescription.Width = 163
			' 
			' repositoryItemMemoExEdit1
			' 
			Me.repositoryItemMemoExEdit1.AutoHeight = False
			Me.repositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1"
			Me.repositoryItemMemoExEdit1.ShowIcon = False
			' 
			' colLine
			' 
			Me.colLine.Caption = "Line"
			Me.colLine.FieldName = "Line!"
			Me.colLine.Name = "colLine"
			Me.colLine.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
			Me.colLine.Visible = True
			Me.colLine.VisibleIndex = 1
			Me.colLine.Width = 144
			' 
			' lciGridArtistBar
			' 
			Me.lciGridArtistBar.Control = Me.ucGridEditBarArtist
			Me.lciGridArtistBar.CustomizationFormText = " "
			Me.lciGridArtistBar.Location = New System.Drawing.Point(0, 0)
			Me.lciGridArtistBar.Name = "lciGridArtistBar"
			Me.lciGridArtistBar.Size = New System.Drawing.Size(521, 30)
			Me.lciGridArtistBar.Text = " "
			Me.lciGridArtistBar.TextSize = New System.Drawing.Size(0, 0)
			Me.lciGridArtistBar.TextToControlDistance = 0
			Me.lciGridArtistBar.TextVisible = False
			' 
			' ucGridEditBarArtist
			' 
			Me.ucGridEditBarArtist.Location = New System.Drawing.Point(281, 88)
			Me.ucGridEditBarArtist.Name = "ucGridEditBarArtist"
			Me.ucGridEditBarArtist.Size = New System.Drawing.Size(517, 26)
			Me.ucGridEditBarArtist.TabIndex = 24
'			Me.ucGridEditBarArtist.DeleteRecord += New System.EventHandler(Me.ucGridEditBarArtist_DeleteRecord);
'			Me.ucGridEditBarArtist.AddRecord += New System.EventHandler(Me.ucGridEditBarArtist_AddRecord);
			' 
			' lcgRentalInfo
			' 
			Me.lcgRentalInfo.CustomizationFormText = "Rental/Sales Info"
			Me.lcgRentalInfo.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciCategory, Me.lciFormatsInfo})
			Me.lcgRentalInfo.Location = New System.Drawing.Point(0, 0)
			Me.lcgRentalInfo.Name = "lcgRentalInfo"
			Me.lcgRentalInfo.Size = New System.Drawing.Size(529, 454)
			Me.lcgRentalInfo.Text = "Rental/Sales Info"
			' 
			' lciCategory
			' 
			Me.lciCategory.Control = Me.lueCategory
			Me.lciCategory.CustomizationFormText = "Rental Category"
			Me.lciCategory.Location = New System.Drawing.Point(0, 0)
			Me.lciCategory.Name = "lciCategory"
			Me.lciCategory.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2)
			Me.lciCategory.Size = New System.Drawing.Size(529, 24)
			Me.lciCategory.Text = "Rental Category:"
			Me.lciCategory.TextSize = New System.Drawing.Size(83, 13)
			' 
			' lueCategory
			' 
			Me.lueCategory.Location = New System.Drawing.Point(367, 40)
			Me.lueCategory.Name = "lueCategory"
			Me.lueCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
			Me.lueCategory.Size = New System.Drawing.Size(432, 20)
			Me.lueCategory.StyleController = Me.lcMain
			Me.lueCategory.TabIndex = 29
'			Me.lueCategory.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.lueCategory_ButtonClick);
'			Me.lueCategory.EditValueChanged += New System.EventHandler(Me.lueCategory_EditValueChanged);
			' 
			' lciFormatsInfo
			' 
			Me.lciFormatsInfo.Control = Me.ucMovieFormatsInfo
			Me.lciFormatsInfo.CustomizationFormText = "lciFormatsInfo"
			Me.lciFormatsInfo.Location = New System.Drawing.Point(0, 24)
			Me.lciFormatsInfo.Name = "lciFormatsInfo"
			Me.lciFormatsInfo.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lciFormatsInfo.Size = New System.Drawing.Size(529, 430)
			Me.lciFormatsInfo.Text = "lciFormatsInfo"
			Me.lciFormatsInfo.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
			Me.lciFormatsInfo.TextSize = New System.Drawing.Size(0, 0)
			Me.lciFormatsInfo.TextToControlDistance = 0
			Me.lciFormatsInfo.TextVisible = False
			' 
			' ucMovieFormatsInfo
			' 
			Me.ucMovieFormatsInfo.Location = New System.Drawing.Point(275, 62)
			Me.ucMovieFormatsInfo.Name = "ucMovieFormatsInfo"
			Me.ucMovieFormatsInfo.Size = New System.Drawing.Size(529, 430)
			Me.ucMovieFormatsInfo.TabIndex = 42
			' 
			' splitterItem1
			' 
			Me.splitterItem1.AllowHotTrack = True
			Me.splitterItem1.CustomizationFormText = "splitterItem1"
			Me.splitterItem1.Location = New System.Drawing.Point(252, 0)
			Me.splitterItem1.Name = "splitterItem1"
			Me.splitterItem1.Size = New System.Drawing.Size(6, 497)
			' 
			' ucPictureEditBar1
			' 
			Me.ucPictureEditBar1.Location = New System.Drawing.Point(8, 475)
			Me.ucPictureEditBar1.Name = "ucPictureEditBar1"
			Me.ucPictureEditBar1.Size = New System.Drawing.Size(248, 26)
			Me.ucPictureEditBar1.TabIndex = 44
			' 
			' lciBar
			' 
			Me.lciBar.Control = Me.ucPictureEditBar1
			Me.lciBar.CustomizationFormText = "layoutControlItem1"
			Me.lciBar.Location = New System.Drawing.Point(0, 467)
			Me.lciBar.Name = "lciBar"
			Me.lciBar.Size = New System.Drawing.Size(252, 30)
			Me.lciBar.Text = "lciBar"
			Me.lciBar.TextSize = New System.Drawing.Size(0, 0)
			Me.lciBar.TextToControlDistance = 0
			Me.lciBar.TextVisible = False
			' 
			' MovieDetail
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Name = "MovieDetail"
			Me.Size = New System.Drawing.Size(821, 509)
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).EndInit()
			Me.lcMain.ResumeLayout(False)
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.deReleaseDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.deReleaseDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teRunTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ccbGenre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceIsColor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pePhoto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teAwards.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.meTagline.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.mePlot.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teAspectRatio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciPhoto, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciTitle, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcgGeneralInfo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciPlot, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciAwards, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciTagline, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciGenre, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciRealeaseDate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciRating, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbRating.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcgAdditionalDetail, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciWebSite, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teWebSite.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciAspectRatio, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciRunTime, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciIsColor, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciCountries, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ccbCountries.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciLanguage, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lueLanguage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcgCompanies, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciCompanies, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gcCompanies, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gvCompanies, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMemoExEdit3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciGridCompaniesBar, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcgArtist, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciDirector, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teDirectors.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcgArtists, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciArtists, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gcArtists, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gvArtist, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciGridArtistBar, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcgRentalInfo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciCategory, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lueCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciFormatsInfo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciBar, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private deReleaseDate As DevExpress.XtraEditors.DateEdit
		Private teRunTime As DevExpress.XtraEditors.TimeEdit
		Private ccbGenre As DevExpress.XtraEditors.CheckedComboBoxEdit
		Private ceIsColor As DevExpress.XtraEditors.CheckEdit
		Private pePhoto As DevExpress.XtraEditors.PictureEdit
		Private teAwards As DevExpress.XtraEditors.TextEdit
		Private meTagline As DevExpress.XtraEditors.MemoEdit
		Private mePlot As DevExpress.XtraEditors.MemoEdit
		Private teAspectRatio As DevExpress.XtraEditors.TextEdit
		Private lciPhoto As DevExpress.XtraLayout.LayoutControlItem
		Private lciTitle As DevExpress.XtraLayout.LayoutControlItem
		Private tabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
		Private lcgGeneralInfo As DevExpress.XtraLayout.LayoutControlGroup
		Private lciTagline As DevExpress.XtraLayout.LayoutControlItem
		Private lciPlot As DevExpress.XtraLayout.LayoutControlItem
		Private lcgAdditionalDetail As DevExpress.XtraLayout.LayoutControlGroup
		Private lciRunTime As DevExpress.XtraLayout.LayoutControlItem
		Private lcgRentalInfo As DevExpress.XtraLayout.LayoutControlGroup
		Private lciGenre As DevExpress.XtraLayout.LayoutControlItem
		Private lciRating As DevExpress.XtraLayout.LayoutControlItem
		Private lciRealeaseDate As DevExpress.XtraLayout.LayoutControlItem
		Private lciLanguage As DevExpress.XtraLayout.LayoutControlItem
		Private lciAwards As DevExpress.XtraLayout.LayoutControlItem
		Private lciWebSite As DevExpress.XtraLayout.LayoutControlItem
		Private lciAspectRatio As DevExpress.XtraLayout.LayoutControlItem
		Private lciIsColor As DevExpress.XtraLayout.LayoutControlItem
		Private teDirectors As DevExpress.XtraEditors.TextEdit
		Private lciDirector As DevExpress.XtraLayout.LayoutControlItem
		Private gcArtists As DevExpress.XtraGrid.GridControl
		Private WithEvents gvArtist As DevExpress.XtraGrid.Views.Grid.GridView
		Private lciArtists As DevExpress.XtraLayout.LayoutControlItem
		Private teTitle As DevExpress.XtraEditors.MemoEdit
		Private WithEvents teWebSite As DevExpress.XtraEditors.ButtonEdit
		Private lueLanguage As DevExpress.XtraEditors.LookUpEdit
		Private colArtist As DevExpress.XtraGrid.Columns.GridColumn
		Private colDescription As DevExpress.XtraGrid.Columns.GridColumn
		Private colLine As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
		Private lcgArtist As DevExpress.XtraLayout.LayoutControlGroup
		Private gcCompanies As DevExpress.XtraGrid.GridControl
		Private gvCompanies As DevExpress.XtraGrid.Views.Grid.GridView
		Private repositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
		Private lciCompanies As DevExpress.XtraLayout.LayoutControlItem
		Private colCompany As DevExpress.XtraGrid.Columns.GridColumn
		Private colCompanyDescription As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemMemoExEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
		Private ccbCountries As DevExpress.XtraEditors.CheckedComboBoxEdit
		Private lciCountries As DevExpress.XtraLayout.LayoutControlItem
		Private WithEvents ucGridEditBarArtist As DevExpress.VideoRent.Win.Controls.ucGridEditBar
		Private lciGridArtistBar As DevExpress.XtraLayout.LayoutControlItem
		Private WithEvents ucGridEditBarCompanies As DevExpress.VideoRent.Win.Controls.ucGridEditBar
		Private lcgCompanies As DevExpress.XtraLayout.LayoutControlGroup
		Private lciGridCompaniesBar As DevExpress.XtraLayout.LayoutControlItem
		Private icbRating As DevExpress.XtraEditors.ImageComboBoxEdit
		Private splitterItem1 As DevExpress.XtraLayout.SplitterItem
		Private lcgArtists As DevExpress.XtraLayout.LayoutControlGroup
		Private WithEvents lueCategory As DevExpress.XtraEditors.LookUpEdit
		Private lciCategory As DevExpress.XtraLayout.LayoutControlItem
		Private ucMovieFormatsInfo As DevExpress.VideoRent.Win.Controls.ucMovieItemsInfo
		Private lciFormatsInfo As DevExpress.XtraLayout.LayoutControlItem
		Private ucPictureEditBar1 As DevExpress.VideoRent.Win.Controls.ucPictureEditBar
		Private lciBar As DevExpress.XtraLayout.LayoutControlItem
		Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
	End Class
End Namespace
