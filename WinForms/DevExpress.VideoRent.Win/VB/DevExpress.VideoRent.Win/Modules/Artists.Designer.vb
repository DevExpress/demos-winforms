Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Modules
	Partial Public Class Artists
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim gridLevelNode1 As New DevExpress.XtraGrid.GridLevelNode()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Artists))
			Me.cardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
			Me.colPicture = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.xcArtist = New DevExpress.Xpo.XPCollection()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colArtistId = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colGender = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colBirthCountry = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colBirthLocation = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colFirstName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colLastName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colBirthName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colBirthDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colBiography = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
			Me.colNickName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colLink = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.ilColumnImages = New System.Windows.Forms.ImageList(Me.components)
			CType(Me.cardView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xcArtist, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' cardView1
			' 
			Me.cardView1.CardCaptionFormat = "Photo {0}"
			Me.cardView1.CardWidth = 250
			Me.cardView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colPicture})
			Me.cardView1.FocusedCardTopFieldIndex = 0
			Me.cardView1.GridControl = Me.gridControl1
			Me.cardView1.Name = "cardView1"
			Me.cardView1.OptionsBehavior.Editable = False
			Me.cardView1.OptionsBehavior.FieldAutoHeight = True
			Me.cardView1.OptionsView.ShowFieldCaptions = False
			Me.cardView1.OptionsView.ShowQuickCustomizeButton = False
'			Me.cardView1.CalcFieldHeight += New DevExpress.XtraGrid.Views.Card.FieldHeightEventHandler(Me.cardView1_CalcFieldHeight);
			' 
			' colPicture
			' 
			Me.colPicture.ColumnEdit = Me.repositoryItemPictureEdit1
			Me.colPicture.FieldName = "Image"
			Me.colPicture.Name = "colPicture"
			Me.colPicture.Visible = True
			Me.colPicture.VisibleIndex = 0
			' 
			' repositoryItemPictureEdit1
			' 
			Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
			Me.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.xcArtist
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			gridLevelNode1.LevelTemplate = Me.cardView1
			gridLevelNode1.RelationName = "Pictures"
			Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1})
			Me.gridControl1.Location = New System.Drawing.Point(6, 6)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemPictureEdit1, Me.repositoryItemMemoExEdit1})
			Me.gridControl1.ShowOnlyPredefinedDetails = True
			Me.gridControl1.Size = New System.Drawing.Size(904, 534)
			Me.gridControl1.TabIndex = 1
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.cardView1})
			' 
			' xcArtist
			' 
			Me.xcArtist.LoadingEnabled = False
			Me.xcArtist.ObjectType = GetType(DevExpress.VideoRent.Artist)
			' 
			' gridView1
			' 
			Me.gridView1.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 6.75F)
			Me.gridView1.Appearance.Preview.Options.UseFont = True
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colArtistId, Me.colGender, Me.colBirthCountry, Me.colBirthLocation, Me.colFirstName, Me.colLastName, Me.colBirthName, Me.colBirthDate, Me.colBiography, Me.colNickName, Me.colLink})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Images = Me.ilColumnImages
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsBehavior.Editable = False
			Me.gridView1.OptionsDetail.AllowExpandEmptyDetails = True
			Me.gridView1.OptionsDetail.EnableDetailToolTip = True
			Me.gridView1.OptionsDetail.EnableMasterViewMode = False
			Me.gridView1.OptionsDetail.ShowDetailTabs = False
			Me.gridView1.OptionsPrint.PrintPreview = True
			Me.gridView1.OptionsView.AutoCalcPreviewLineCount = True
			Me.gridView1.OptionsView.EnableAppearanceOddRow = True
			Me.gridView1.OptionsView.ShowAutoFilterRow = True
			Me.gridView1.OptionsView.ShowGroupPanel = False
			Me.gridView1.OptionsView.ShowPreview = True
            Me.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False
			Me.gridView1.PreviewFieldName = "Biography"
			Me.gridView1.PreviewLineCount = 5
			' 
			' colArtistId
			' 
			Me.colArtistId.FieldName = "ArtistId"
			Me.colArtistId.Name = "colArtistId"
			Me.colArtistId.OptionsColumn.AllowEdit = False
			Me.colArtistId.OptionsColumn.AllowFocus = False
			' 
			' colGender
			' 
			Me.colGender.FieldName = "Gender"
			Me.colGender.ImageIndex = 0
			Me.colGender.Name = "colGender"
			Me.colGender.OptionsColumn.AllowEdit = False
			Me.colGender.OptionsColumn.AllowFocus = False
			Me.colGender.OptionsColumn.AllowMove = False
			Me.colGender.OptionsColumn.AllowSize = False
			Me.colGender.OptionsColumn.FixedWidth = True
			Me.colGender.OptionsColumn.ShowCaption = False
			Me.colGender.Visible = True
			Me.colGender.VisibleIndex = 0
			Me.colGender.Width = 45
			' 
			' colBirthCountry
			' 
			Me.colBirthCountry.Caption = "Birth Country"
			Me.colBirthCountry.FieldName = "BirthCountry!Key"
			Me.colBirthCountry.Name = "colBirthCountry"
			Me.colBirthCountry.OptionsColumn.AllowEdit = False
			Me.colBirthCountry.OptionsColumn.AllowFocus = False
			Me.colBirthCountry.Visible = True
			Me.colBirthCountry.VisibleIndex = 5
			Me.colBirthCountry.Width = 115
			' 
			' colBirthLocation
			' 
			Me.colBirthLocation.FieldName = "BirthLocation"
			Me.colBirthLocation.Name = "colBirthLocation"
			Me.colBirthLocation.OptionsColumn.AllowEdit = False
			Me.colBirthLocation.OptionsColumn.AllowFocus = False
			Me.colBirthLocation.Visible = True
			Me.colBirthLocation.VisibleIndex = 6
			Me.colBirthLocation.Width = 139
			' 
			' colFirstName
			' 
			Me.colFirstName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.colFirstName.AppearanceCell.Options.UseFont = True
			Me.colFirstName.FieldName = "FirstName"
			Me.colFirstName.Name = "colFirstName"
			Me.colFirstName.OptionsColumn.AllowEdit = False
			Me.colFirstName.OptionsColumn.AllowFocus = False
			Me.colFirstName.Visible = True
			Me.colFirstName.VisibleIndex = 1
			Me.colFirstName.Width = 130
			' 
			' colLastName
			' 
			Me.colLastName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.colLastName.AppearanceCell.Options.UseFont = True
			Me.colLastName.FieldName = "LastName"
			Me.colLastName.Name = "colLastName"
			Me.colLastName.OptionsColumn.AllowEdit = False
			Me.colLastName.OptionsColumn.AllowFocus = False
			Me.colLastName.Visible = True
			Me.colLastName.VisibleIndex = 2
			Me.colLastName.Width = 132
			' 
			' colBirthName
			' 
			Me.colBirthName.FieldName = "BirthName"
			Me.colBirthName.Name = "colBirthName"
			Me.colBirthName.OptionsColumn.AllowEdit = False
			Me.colBirthName.OptionsColumn.AllowFocus = False
			Me.colBirthName.Visible = True
			Me.colBirthName.VisibleIndex = 4
			Me.colBirthName.Width = 106
			' 
			' colBirthDate
			' 
			Me.colBirthDate.FieldName = "BirthDate"
			Me.colBirthDate.Name = "colBirthDate"
			Me.colBirthDate.OptionsColumn.AllowEdit = False
			Me.colBirthDate.OptionsColumn.AllowFocus = False
			Me.colBirthDate.Visible = True
			Me.colBirthDate.VisibleIndex = 3
			Me.colBirthDate.Width = 138
			' 
			' colBiography
			' 
			Me.colBiography.ColumnEdit = Me.repositoryItemMemoExEdit1
			Me.colBiography.FieldName = "Biography"
			Me.colBiography.Name = "colBiography"
			Me.colBiography.OptionsColumn.AllowEdit = False
			Me.colBiography.OptionsColumn.AllowFocus = False
			Me.colBiography.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			Me.colBiography.OptionsFilter.AllowAutoFilter = False
			Me.colBiography.OptionsFilter.AllowFilter = False
			Me.colBiography.Visible = True
			Me.colBiography.VisibleIndex = 8
			' 
			' repositoryItemMemoExEdit1
			' 
			Me.repositoryItemMemoExEdit1.AutoHeight = False
			Me.repositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1"
			Me.repositoryItemMemoExEdit1.PopupFormSize = New System.Drawing.Size(350, 200)
			' 
			' colNickName
			' 
			Me.colNickName.FieldName = "NickName"
			Me.colNickName.Name = "colNickName"
			Me.colNickName.OptionsColumn.AllowEdit = False
			Me.colNickName.OptionsColumn.AllowFocus = False
			Me.colNickName.Visible = True
			Me.colNickName.VisibleIndex = 7
			Me.colNickName.Width = 105
			' 
			' colLink
			' 
			Me.colLink.FieldName = "Link"
			Me.colLink.Name = "colLink"
			Me.colLink.OptionsColumn.AllowEdit = False
			Me.colLink.OptionsColumn.AllowFocus = False
			' 
			' ilColumnImages
			' 
			Me.ilColumnImages.ImageStream = (CType(resources.GetObject("ilColumnImages.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.ilColumnImages.TransparentColor = System.Drawing.Color.Magenta
			Me.ilColumnImages.Images.SetKeyName(0, "")
			' 
			' Artists
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Artists"
			Me.Padding = New System.Windows.Forms.Padding(6)
			Me.Size = New System.Drawing.Size(916, 546)
			CType(Me.cardView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xcArtist, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private xcArtist As DevExpress.Xpo.XPCollection
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colGender As DevExpress.XtraGrid.Columns.GridColumn
		Private colBirthCountry As DevExpress.XtraGrid.Columns.GridColumn
		Private colBirthLocation As DevExpress.XtraGrid.Columns.GridColumn
		Private colFirstName As DevExpress.XtraGrid.Columns.GridColumn
		Private colLastName As DevExpress.XtraGrid.Columns.GridColumn
		Private colBirthName As DevExpress.XtraGrid.Columns.GridColumn
		Private colBirthDate As DevExpress.XtraGrid.Columns.GridColumn
		Private colBiography As DevExpress.XtraGrid.Columns.GridColumn
		Private colNickName As DevExpress.XtraGrid.Columns.GridColumn
		Private colLink As DevExpress.XtraGrid.Columns.GridColumn
		Private colArtistId As DevExpress.XtraGrid.Columns.GridColumn
		Private WithEvents cardView1 As DevExpress.XtraGrid.Views.Card.CardView
		Private colPicture As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private ilColumnImages As System.Windows.Forms.ImageList
		Private repositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
	End Class
End Namespace
