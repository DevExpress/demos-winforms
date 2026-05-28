Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Modules
	Partial Public Class ArtistDetail
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
			Me.lcgAdditionalDetail = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lcgArtist = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lcgRentalInfo = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.teFirstName = New DevExpress.XtraEditors.TextEdit()
			Me.lciFirstName = New DevExpress.XtraLayout.LayoutControlItem()
			Me.teLastName = New DevExpress.XtraEditors.TextEdit()
			Me.lciLastName = New DevExpress.XtraLayout.LayoutControlItem()
			Me.teNickName = New DevExpress.XtraEditors.TextEdit()
			Me.lciNickName = New DevExpress.XtraLayout.LayoutControlItem()
			Me.teBirthLocation = New DevExpress.XtraEditors.TextEdit()
			Me.lciBirthLocation = New DevExpress.XtraLayout.LayoutControlItem()
			Me.teBirthName = New DevExpress.XtraEditors.TextEdit()
			Me.lciBirthName = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciLink = New DevExpress.XtraLayout.LayoutControlItem()
			Me.teLink = New DevExpress.XtraEditors.ButtonEdit()
			Me.meBiography = New DevExpress.XtraEditors.MemoEdit()
			Me.lciGender = New DevExpress.XtraLayout.LayoutControlItem()
			Me.cbeGender = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.deBirthDate = New DevExpress.XtraEditors.DateEdit()
			Me.lciBirthDate = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lueBirthCountry = New DevExpress.XtraEditors.LookUpEdit()
			Me.lciBirthCountry = New DevExpress.XtraLayout.LayoutControlItem()
			Me.ucPictureCollection1 = New DevExpress.VideoRent.Win.Controls.ucPictureCollection()
			Me.lciPictureCollection = New DevExpress.XtraLayout.LayoutControlItem()
			Me.tcgMain = New DevExpress.XtraLayout.TabbedControlGroup()
			Me.lccBiography = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lciBiography = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lcgMovies = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.gcMovies = New DevExpress.XtraGrid.GridControl()
			Me.gvMovies = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colMovie = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
			Me.colLine = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.ucGridEditBarMovies = New DevExpress.VideoRent.Win.Controls.ucGridEditBar()
			Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem()
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.lcMain.SuspendLayout()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcgAdditionalDetail, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcgArtist, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcgRentalInfo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teFirstName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciFirstName, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teLastName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciLastName, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teNickName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciNickName, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teBirthLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciBirthLocation, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teBirthName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciBirthName, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciLink, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teLink.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.meBiography.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciGender, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbeGender.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.deBirthDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.deBirthDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciBirthDate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lueBirthCountry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciBirthCountry, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciPictureCollection, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lccBiography, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciBiography, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcgMovies, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gcMovies, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gvMovies, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' lcMain
			' 
			Me.lcMain.Controls.Add(Me.ucGridEditBarMovies)
			Me.lcMain.Controls.Add(Me.gcMovies)
			Me.lcMain.Controls.Add(Me.lueBirthCountry)
			Me.lcMain.Controls.Add(Me.deBirthDate)
			Me.lcMain.Controls.Add(Me.meBiography)
			Me.lcMain.Controls.Add(Me.ucPictureCollection1)
			Me.lcMain.Controls.Add(Me.teBirthName)
			Me.lcMain.Controls.Add(Me.teBirthLocation)
			Me.lcMain.Controls.Add(Me.teNickName)
			Me.lcMain.Controls.Add(Me.teLastName)
			Me.lcMain.Controls.Add(Me.teFirstName)
			Me.lcMain.Controls.Add(Me.cbeGender)
			Me.lcMain.Controls.Add(Me.teLink)
			Me.lcMain.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lcgRentalInfo, Me.lcgArtist, Me.lcgAdditionalDetail})
			Me.lcMain.Size = New System.Drawing.Size(737, 502)
			' 
			' lcgMain
			' 
			Me.lcgMain.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciFirstName, Me.lciLastName, Me.lciPictureCollection, Me.tcgMain, Me.lciNickName, Me.lciBirthName, Me.lciGender, Me.lciBirthDate, Me.lciBirthCountry, Me.lciBirthLocation, Me.lciLink, Me.splitterItem1})
			Me.lcgMain.Name = "Root"
			Me.lcgMain.Size = New System.Drawing.Size(737, 502)
			Me.lcgMain.Text = "Root"
			' 
			' lcgAdditionalDetail
			' 
			Me.lcgAdditionalDetail.CustomizationFormText = "Additional Details"
			Me.lcgAdditionalDetail.Location = New System.Drawing.Point(0, 0)
			Me.lcgAdditionalDetail.Name = "lcgAdditionalDetail"
			Me.lcgAdditionalDetail.Size = New System.Drawing.Size(493, 358)
			Me.lcgAdditionalDetail.Text = "Additional Details"
			' 
			' lcgArtist
			' 
			Me.lcgArtist.CustomizationFormText = "Actors/Crew"
			Me.lcgArtist.Location = New System.Drawing.Point(0, 0)
			Me.lcgArtist.Name = "lcgArtist"
			Me.lcgArtist.Size = New System.Drawing.Size(493, 358)
			Me.lcgArtist.Text = "Actors/Crew"
			' 
			' lcgRentalInfo
			' 
			Me.lcgRentalInfo.CustomizationFormText = "Rental/Sales Info"
			Me.lcgRentalInfo.Location = New System.Drawing.Point(0, 0)
			Me.lcgRentalInfo.Name = "lcgRentalInfo"
			Me.lcgRentalInfo.Size = New System.Drawing.Size(493, 358)
			Me.lcgRentalInfo.Text = "Rental/Sales Info"
			' 
			' teFirstName
			' 
			Me.teFirstName.Location = New System.Drawing.Point(81, 8)
			Me.teFirstName.Name = "teFirstName"
			Me.teFirstName.Size = New System.Drawing.Size(381, 20)
			Me.teFirstName.StyleController = Me.lcMain
			Me.teFirstName.TabIndex = 4
			' 
			' lciFirstName
			' 
			Me.lciFirstName.Control = Me.teFirstName
			Me.lciFirstName.CustomizationFormText = "layoutControlItem1"
			Me.lciFirstName.Location = New System.Drawing.Point(0, 0)
			Me.lciFirstName.Name = "lciFirstName"
			Me.lciFirstName.Size = New System.Drawing.Size(458, 24)
			Me.lciFirstName.Text = "First Name:"
			Me.lciFirstName.TextSize = New System.Drawing.Size(69, 13)
			' 
			' teLastName
			' 
			Me.teLastName.Location = New System.Drawing.Point(81, 32)
			Me.teLastName.Name = "teLastName"
			Me.teLastName.Size = New System.Drawing.Size(381, 20)
			Me.teLastName.StyleController = Me.lcMain
			Me.teLastName.TabIndex = 5
			' 
			' lciLastName
			' 
			Me.lciLastName.Control = Me.teLastName
			Me.lciLastName.CustomizationFormText = "layoutControlItem2"
			Me.lciLastName.Location = New System.Drawing.Point(0, 24)
			Me.lciLastName.Name = "lciLastName"
			Me.lciLastName.Size = New System.Drawing.Size(458, 24)
			Me.lciLastName.Text = "Last Name:"
			Me.lciLastName.TextSize = New System.Drawing.Size(69, 13)
			' 
			' teNickName
			' 
			Me.teNickName.Location = New System.Drawing.Point(81, 56)
			Me.teNickName.Name = "teNickName"
			Me.teNickName.Size = New System.Drawing.Size(381, 20)
			Me.teNickName.StyleController = Me.lcMain
			Me.teNickName.TabIndex = 6
			' 
			' lciNickName
			' 
			Me.lciNickName.Control = Me.teNickName
			Me.lciNickName.CustomizationFormText = "layoutControlItem3"
			Me.lciNickName.Location = New System.Drawing.Point(0, 48)
			Me.lciNickName.Name = "lciNickName"
			Me.lciNickName.Size = New System.Drawing.Size(458, 24)
			Me.lciNickName.Text = "Nick Name:"
			Me.lciNickName.TextSize = New System.Drawing.Size(69, 13)
			' 
			' teBirthLocation
			' 
			Me.teBirthLocation.Location = New System.Drawing.Point(310, 128)
			Me.teBirthLocation.Name = "teBirthLocation"
			Me.teBirthLocation.Size = New System.Drawing.Size(152, 20)
			Me.teBirthLocation.StyleController = Me.lcMain
			Me.teBirthLocation.TabIndex = 7
			' 
			' lciBirthLocation
			' 
			Me.lciBirthLocation.Control = Me.teBirthLocation
			Me.lciBirthLocation.CustomizationFormText = "layoutControlItem4"
			Me.lciBirthLocation.Location = New System.Drawing.Point(229, 120)
			Me.lciBirthLocation.Name = "lciBirthLocation"
			Me.lciBirthLocation.Size = New System.Drawing.Size(229, 24)
			Me.lciBirthLocation.Text = "Birth Location:"
			Me.lciBirthLocation.TextSize = New System.Drawing.Size(69, 13)
			' 
			' teBirthName
			' 
			Me.teBirthName.Location = New System.Drawing.Point(81, 80)
			Me.teBirthName.Name = "teBirthName"
			Me.teBirthName.Size = New System.Drawing.Size(381, 20)
			Me.teBirthName.StyleController = Me.lcMain
			Me.teBirthName.TabIndex = 8
			' 
			' lciBirthName
			' 
			Me.lciBirthName.Control = Me.teBirthName
			Me.lciBirthName.CustomizationFormText = "layoutControlItem5"
			Me.lciBirthName.Location = New System.Drawing.Point(0, 72)
			Me.lciBirthName.Name = "lciBirthName"
			Me.lciBirthName.Size = New System.Drawing.Size(458, 24)
			Me.lciBirthName.Text = "Birth Name:"
			Me.lciBirthName.TextSize = New System.Drawing.Size(69, 13)
			' 
			' lciLink
			' 
			Me.lciLink.Control = Me.teLink
			Me.lciLink.CustomizationFormText = "layoutControlItem6"
			Me.lciLink.Location = New System.Drawing.Point(0, 144)
			Me.lciLink.Name = "lciLink"
			Me.lciLink.Size = New System.Drawing.Size(458, 24)
			Me.lciLink.Text = "Link:"
			Me.lciLink.TextSize = New System.Drawing.Size(69, 13)
			' 
			' teLink
			' 
			Me.teLink.Location = New System.Drawing.Point(81, 152)
			Me.teLink.Name = "teLink"
			Me.teLink.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Go to Website", Nothing, Nothing, True)})
			Me.teLink.Size = New System.Drawing.Size(381, 20)
			Me.teLink.StyleController = Me.lcMain
			Me.teLink.TabIndex = 9
			Me.teLink.TabStop = False
'			Me.teLink.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.teLink_ButtonClick);
			' 
			' meBiography
			' 
			Me.meBiography.Location = New System.Drawing.Point(41, 188)
			Me.meBiography.Name = "meBiography"
			Me.meBiography.Size = New System.Drawing.Size(409, 294)
			Me.meBiography.StyleController = Me.lcMain
			Me.meBiography.TabIndex = 11
			' 
			' lciGender
			' 
			Me.lciGender.Control = Me.cbeGender
			Me.lciGender.CustomizationFormText = "layoutControlItem9"
			Me.lciGender.Location = New System.Drawing.Point(0, 96)
			Me.lciGender.Name = "lciGender"
			Me.lciGender.Size = New System.Drawing.Size(229, 24)
			Me.lciGender.Text = "Gender:"
			Me.lciGender.TextSize = New System.Drawing.Size(69, 13)
			' 
			' cbeGender
			' 
			Me.cbeGender.Location = New System.Drawing.Point(81, 104)
			Me.cbeGender.Name = "cbeGender"
			Me.cbeGender.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbeGender.Size = New System.Drawing.Size(152, 20)
			Me.cbeGender.StyleController = Me.lcMain
			Me.cbeGender.TabIndex = 12
			Me.cbeGender.TabStop = False
			' 
			' deBirthDate
			' 
			Me.deBirthDate.EditValue = Nothing
			Me.deBirthDate.Location = New System.Drawing.Point(310, 104)
			Me.deBirthDate.Name = "deBirthDate"
			Me.deBirthDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.deBirthDate.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True
			Me.deBirthDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.deBirthDate.Size = New System.Drawing.Size(152, 20)
			Me.deBirthDate.StyleController = Me.lcMain
			Me.deBirthDate.TabIndex = 13
			' 
			' lciBirthDate
			' 
			Me.lciBirthDate.Control = Me.deBirthDate
			Me.lciBirthDate.CustomizationFormText = "layoutControlItem7"
			Me.lciBirthDate.Location = New System.Drawing.Point(229, 96)
			Me.lciBirthDate.Name = "lciBirthDate"
			Me.lciBirthDate.Size = New System.Drawing.Size(229, 24)
			Me.lciBirthDate.Text = "Birth Date:"
			Me.lciBirthDate.TextSize = New System.Drawing.Size(69, 13)
			' 
			' lueBirthCountry
			' 
			Me.lueBirthCountry.Location = New System.Drawing.Point(81, 128)
			Me.lueBirthCountry.Name = "lueBirthCountry"
			Me.lueBirthCountry.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.lueBirthCountry.Size = New System.Drawing.Size(152, 20)
			Me.lueBirthCountry.StyleController = Me.lcMain
			Me.lueBirthCountry.TabIndex = 14
			' 
			' lciBirthCountry
			' 
			Me.lciBirthCountry.Control = Me.lueBirthCountry
			Me.lciBirthCountry.CustomizationFormText = "layoutControlItem10"
			Me.lciBirthCountry.Location = New System.Drawing.Point(0, 120)
			Me.lciBirthCountry.Name = "lciBirthCountry"
			Me.lciBirthCountry.Size = New System.Drawing.Size(229, 24)
			Me.lciBirthCountry.Text = "Birth Country:"
			Me.lciBirthCountry.TextSize = New System.Drawing.Size(69, 13)
			' 
			' ucPictureCollection1
			' 
			Me.ucPictureCollection1.Location = New System.Drawing.Point(472, 8)
			Me.ucPictureCollection1.Name = "ucPictureCollection1"
			Me.ucPictureCollection1.Size = New System.Drawing.Size(257, 486)
			Me.ucPictureCollection1.TabIndex = 15
			' 
			' lciPictureCollection
			' 
			Me.lciPictureCollection.Control = Me.ucPictureCollection1
			Me.lciPictureCollection.CustomizationFormText = "layoutControlItem1"
			Me.lciPictureCollection.Location = New System.Drawing.Point(464, 0)
			Me.lciPictureCollection.Name = "lciPictureCollection"
			Me.lciPictureCollection.Size = New System.Drawing.Size(261, 490)
			Me.lciPictureCollection.Text = "lciPictureCollection"
			Me.lciPictureCollection.TextSize = New System.Drawing.Size(0, 0)
			Me.lciPictureCollection.TextToControlDistance = 0
			Me.lciPictureCollection.TextVisible = False
			' 
			' tcgMain
			' 
			Me.tcgMain.CustomizationFormText = "tabbedControlGroup1"
			Me.tcgMain.Location = New System.Drawing.Point(0, 168)
			Me.tcgMain.Name = "tcgMain"
			Me.tcgMain.SelectedTabPage = Me.lccBiography
			Me.tcgMain.SelectedTabPageIndex = 0
			Me.tcgMain.Size = New System.Drawing.Size(458, 322)
			Me.tcgMain.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lccBiography, Me.lcgMovies})
			Me.tcgMain.Text = "tcgMain"
			Me.tcgMain.TextLocation = DevExpress.Utils.Locations.Left
			' 
			' lccBiography
			' 
			Me.lccBiography.CustomizationFormText = "Biography"
			Me.lccBiography.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciBiography})
			Me.lccBiography.Location = New System.Drawing.Point(0, 0)
			Me.lccBiography.Name = "lccBiography"
			Me.lccBiography.Size = New System.Drawing.Size(413, 298)
			Me.lccBiography.Text = "Biography"
			' 
			' lciBiography
			' 
			Me.lciBiography.AppearanceItemCaption.Options.UseTextOptions = True
			Me.lciBiography.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
			Me.lciBiography.Control = Me.meBiography
			Me.lciBiography.CustomizationFormText = "layoutControlItem8"
			Me.lciBiography.Location = New System.Drawing.Point(0, 0)
			Me.lciBiography.Name = "lciBiography"
			Me.lciBiography.Size = New System.Drawing.Size(413, 298)
			Me.lciBiography.Text = "Biography:"
			Me.lciBiography.TextSize = New System.Drawing.Size(0, 0)
			Me.lciBiography.TextToControlDistance = 0
			Me.lciBiography.TextVisible = False
			' 
			' lcgMovies
			' 
			Me.lcgMovies.CustomizationFormText = "Movies"
			Me.lcgMovies.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2})
			Me.lcgMovies.Location = New System.Drawing.Point(0, 0)
			Me.lcgMovies.Name = "lcgMovies"
			Me.lcgMovies.Size = New System.Drawing.Size(413, 298)
			Me.lcgMovies.Text = "Movies"
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.gcMovies
			Me.layoutControlItem1.CustomizationFormText = "Movies"
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 30)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(413, 268)
			Me.layoutControlItem1.Text = "Movies"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextToControlDistance = 0
			Me.layoutControlItem1.TextVisible = False
			' 
			' gcMovies
			' 
			Me.gcMovies.Location = New System.Drawing.Point(41, 218)
			Me.gcMovies.MainView = Me.gvMovies
			Me.gcMovies.Name = "gcMovies"
			Me.gcMovies.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemMemoExEdit1})
			Me.gcMovies.ShowOnlyPredefinedDetails = True
			Me.gcMovies.Size = New System.Drawing.Size(409, 264)
			Me.gcMovies.TabIndex = 16
			Me.gcMovies.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gvMovies, Me.gridView2})
			' 
			' gvMovies
			' 
			Me.gvMovies.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colMovie, Me.colDescription, Me.colLine})
			Me.gvMovies.GridControl = Me.gcMovies
			Me.gvMovies.Name = "gvMovies"
			Me.gvMovies.OptionsView.ShowAutoFilterRow = True
			Me.gvMovies.OptionsView.ShowGroupPanel = False
            Me.gvMovies.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False
			' 
			' colMovie
			' 
			Me.colMovie.Caption = "Movie"
			Me.colMovie.FieldName = "Movie!"
			Me.colMovie.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
			Me.colMovie.Name = "colMovie"
			Me.colMovie.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
			Me.colMovie.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
			Me.colMovie.Visible = True
			Me.colMovie.VisibleIndex = 0
			Me.colMovie.Width = 181
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
			Me.colDescription.Width = 101
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
			Me.colLine.Visible = True
			Me.colLine.VisibleIndex = 1
			Me.colLine.Width = 86
			' 
			' gridView2
			' 
			Me.gridView2.GridControl = Me.gcMovies
			Me.gridView2.Name = "gridView2"
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.ucGridEditBarMovies
			Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(413, 30)
			Me.layoutControlItem2.Text = "layoutControlItem2"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextToControlDistance = 0
			Me.layoutControlItem2.TextVisible = False
			' 
			' ucGridEditBarMovies
			' 
			Me.ucGridEditBarMovies.Location = New System.Drawing.Point(41, 188)
			Me.ucGridEditBarMovies.Name = "ucGridEditBarMovies"
			Me.ucGridEditBarMovies.Size = New System.Drawing.Size(409, 26)
			Me.ucGridEditBarMovies.TabIndex = 17
'			Me.ucGridEditBarMovies.DeleteRecord += New System.EventHandler(Me.ucGridEditBarMovies_DeleteRecord);
'			Me.ucGridEditBarMovies.AddRecord += New System.EventHandler(Me.ucGridEditBarMovies_AddRecord);
			' 
			' splitterItem1
			' 
			Me.splitterItem1.AllowHotTrack = True
			Me.splitterItem1.CustomizationFormText = "splitterItem1"
			Me.splitterItem1.Location = New System.Drawing.Point(458, 0)
			Me.splitterItem1.Name = "splitterItem1"
			Me.splitterItem1.Size = New System.Drawing.Size(6, 490)
			' 
			' ArtistDetail
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Name = "ArtistDetail"
			Me.Size = New System.Drawing.Size(737, 502)
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).EndInit()
			Me.lcMain.ResumeLayout(False)
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcgAdditionalDetail, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcgArtist, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcgRentalInfo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teFirstName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciFirstName, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teLastName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciLastName, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teNickName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciNickName, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teBirthLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciBirthLocation, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teBirthName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciBirthName, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciLink, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teLink.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.meBiography.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciGender, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbeGender.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.deBirthDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.deBirthDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciBirthDate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lueBirthCountry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciBirthCountry, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciPictureCollection, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tcgMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lccBiography, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciBiography, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcgMovies, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gcMovies, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gvMovies, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private lcgAdditionalDetail As DevExpress.XtraLayout.LayoutControlGroup
		Private lcgRentalInfo As DevExpress.XtraLayout.LayoutControlGroup
		Private lcgArtist As DevExpress.XtraLayout.LayoutControlGroup
		Private meBiography As DevExpress.XtraEditors.MemoEdit
		Private teBirthName As DevExpress.XtraEditors.TextEdit
		Private teBirthLocation As DevExpress.XtraEditors.TextEdit
		Private teNickName As DevExpress.XtraEditors.TextEdit
		Private teLastName As DevExpress.XtraEditors.TextEdit
		Private teFirstName As DevExpress.XtraEditors.TextEdit
		Private lciFirstName As DevExpress.XtraLayout.LayoutControlItem
		Private lciLastName As DevExpress.XtraLayout.LayoutControlItem
		Private lciNickName As DevExpress.XtraLayout.LayoutControlItem
		Private lciBirthLocation As DevExpress.XtraLayout.LayoutControlItem
		Private lciBirthName As DevExpress.XtraLayout.LayoutControlItem
		Private lciLink As DevExpress.XtraLayout.LayoutControlItem
		Private lciGender As DevExpress.XtraLayout.LayoutControlItem
		Private lueBirthCountry As DevExpress.XtraEditors.LookUpEdit
		Private deBirthDate As DevExpress.XtraEditors.DateEdit
		Private lciBirthDate As DevExpress.XtraLayout.LayoutControlItem
		Private lciBirthCountry As DevExpress.XtraLayout.LayoutControlItem
		Private ucPictureCollection1 As DevExpress.VideoRent.Win.Controls.ucPictureCollection
		Private lciPictureCollection As DevExpress.XtraLayout.LayoutControlItem
		Private tcgMain As DevExpress.XtraLayout.TabbedControlGroup
		Private lccBiography As DevExpress.XtraLayout.LayoutControlGroup
		Private lciBiography As DevExpress.XtraLayout.LayoutControlItem
		Private lcgMovies As DevExpress.XtraLayout.LayoutControlGroup
		Private gcMovies As DevExpress.XtraGrid.GridControl
		Private gvMovies As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private cbeGender As DevExpress.XtraEditors.ImageComboBoxEdit
		Private WithEvents ucGridEditBarMovies As DevExpress.VideoRent.Win.Controls.ucGridEditBar
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private WithEvents teLink As DevExpress.XtraEditors.ButtonEdit
		Private colMovie As DevExpress.XtraGrid.Columns.GridColumn
		Private colDescription As DevExpress.XtraGrid.Columns.GridColumn
		Private colLine As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
		Private splitterItem1 As DevExpress.XtraLayout.SplitterItem
	End Class
End Namespace
