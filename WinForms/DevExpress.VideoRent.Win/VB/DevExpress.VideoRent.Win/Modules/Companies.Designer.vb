Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Modules
	Partial Public Class Companies
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
			Dim gridLevelNode1 As New DevExpress.XtraGrid.GridLevelNode()
			Me.layoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
			Me.colPhoto1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			Me.layoutViewField_colPhotoExist1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.colTitle1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colTitle2 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.colReleaseDate1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colReleaseDate2 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.colPlot1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
			Me.layoutViewField_colPlot2 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.colDescription = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_layoutViewColumn1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.xcCompanies = New DevExpress.Xpo.XPCollection()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colType = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colWebSite = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
			Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colFlag = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemPictureEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
			CType(Me.layoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colPhotoExist1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colTitle2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colReleaseDate2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colPlot2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_layoutViewColumn1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xcCompanies, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' layoutView1
			' 
			Me.layoutView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.layoutView1.CardCaptionFormat = "Movie {0} of {1}"
			Me.layoutView1.CardHorzInterval = 12
			Me.layoutView1.CardMinSize = New System.Drawing.Size(255, 216)
			Me.layoutView1.CardVertInterval = 12
			Me.layoutView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() { Me.colPhoto1, Me.colTitle1, Me.colReleaseDate1, Me.colPlot1, Me.colDescription})
			Me.layoutView1.GridControl = Me.gridControl1
			Me.layoutView1.Name = "layoutView1"
			Me.layoutView1.OptionsBehavior.Editable = False
			Me.layoutView1.OptionsBehavior.ScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto
			Me.layoutView1.OptionsCustomization.AllowFilter = False
			Me.layoutView1.OptionsCustomization.AllowSort = False
			Me.layoutView1.OptionsView.CardsAlignment = DevExpress.XtraGrid.Views.Layout.CardsAlignment.Near
			Me.layoutView1.OptionsView.ContentAlignment = System.Drawing.ContentAlignment.TopLeft
			Me.layoutView1.OptionsView.ShowCardExpandButton = False
			Me.layoutView1.OptionsView.ShowCardLines = False
			Me.layoutView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
			Me.layoutView1.OptionsView.ShowHeaderPanel = False
			Me.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow
			Me.layoutView1.TemplateCard = Me.layoutViewCard1
'			Me.layoutView1.CustomCardLayout += New DevExpress.XtraGrid.Views.Layout.Events.LayoutViewCustomCardLayoutEventHandler(Me.layoutView1_CustomCardLayout);
			' 
			' colPhoto1
			' 
			Me.colPhoto1.ColumnEdit = Me.repositoryItemPictureEdit1
			Me.colPhoto1.FieldName = "Movie.PhotoExist"
			Me.colPhoto1.LayoutViewField = Me.layoutViewField_colPhotoExist1
			Me.colPhoto1.Name = "colPhoto1"
			Me.colPhoto1.OptionsColumn.AllowFocus = False
			' 
			' repositoryItemPictureEdit1
			' 
			Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
			Me.repositoryItemPictureEdit1.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
			Me.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
			' 
			' layoutViewField_colPhotoExist1
			' 
			Me.layoutViewField_colPhotoExist1.EditorPreferredWidth = 110
			Me.layoutViewField_colPhotoExist1.Location = New System.Drawing.Point(0, 0)
			Me.layoutViewField_colPhotoExist1.Name = "layoutViewField_colPhotoExist1"
			Me.layoutViewField_colPhotoExist1.Size = New System.Drawing.Size(114, 156)
			Me.layoutViewField_colPhotoExist1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutViewField_colPhotoExist1.TextToControlDistance = 0
			Me.layoutViewField_colPhotoExist1.TextVisible = False
			' 
			' colTitle1
			' 
			Me.colTitle1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.colTitle1.AppearanceCell.Options.UseFont = True
			Me.colTitle1.FieldName = "Movie.Title"
			Me.colTitle1.LayoutViewField = Me.layoutViewField_colTitle2
			Me.colTitle1.Name = "colTitle1"
			Me.colTitle1.OptionsColumn.AllowFocus = False
			' 
			' layoutViewField_colTitle2
			' 
			Me.layoutViewField_colTitle2.EditorPreferredWidth = 117
			Me.layoutViewField_colTitle2.Location = New System.Drawing.Point(114, 0)
			Me.layoutViewField_colTitle2.Name = "layoutViewField_colTitle2"
			Me.layoutViewField_colTitle2.Size = New System.Drawing.Size(121, 20)
			Me.layoutViewField_colTitle2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutViewField_colTitle2.TextToControlDistance = 0
			Me.layoutViewField_colTitle2.TextVisible = False
			' 
			' colReleaseDate1
			' 
			Me.colReleaseDate1.FieldName = "Movie.ReleaseDate"
			Me.colReleaseDate1.LayoutViewField = Me.layoutViewField_colReleaseDate2
			Me.colReleaseDate1.Name = "colReleaseDate1"
			Me.colReleaseDate1.OptionsColumn.AllowFocus = False
			' 
			' layoutViewField_colReleaseDate2
			' 
			Me.layoutViewField_colReleaseDate2.EditorPreferredWidth = 117
			Me.layoutViewField_colReleaseDate2.Location = New System.Drawing.Point(114, 20)
			Me.layoutViewField_colReleaseDate2.Name = "layoutViewField_colReleaseDate2"
			Me.layoutViewField_colReleaseDate2.Size = New System.Drawing.Size(121, 20)
			Me.layoutViewField_colReleaseDate2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutViewField_colReleaseDate2.TextToControlDistance = 0
			Me.layoutViewField_colReleaseDate2.TextVisible = False
			' 
			' colPlot1
			' 
			Me.colPlot1.ColumnEdit = Me.repositoryItemMemoEdit1
			Me.colPlot1.FieldName = "Movie.Plot"
			Me.colPlot1.LayoutViewField = Me.layoutViewField_colPlot2
			Me.colPlot1.Name = "colPlot1"
			Me.colPlot1.OptionsColumn.AllowFocus = False
			' 
			' repositoryItemMemoEdit1
			' 
			Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
			' 
			' layoutViewField_colPlot2
			' 
			Me.layoutViewField_colPlot2.EditorPreferredWidth = 117
			Me.layoutViewField_colPlot2.Location = New System.Drawing.Point(114, 40)
			Me.layoutViewField_colPlot2.Name = "layoutViewField_colPlot2"
			Me.layoutViewField_colPlot2.Size = New System.Drawing.Size(121, 116)
			Me.layoutViewField_colPlot2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutViewField_colPlot2.TextToControlDistance = 0
			Me.layoutViewField_colPlot2.TextVisible = False
			' 
			' colDescription
			' 
			Me.colDescription.FieldName = "Description"
			Me.colDescription.LayoutViewField = Me.layoutViewField_layoutViewColumn1
			Me.colDescription.Name = "colDescription"
			Me.colDescription.OptionsColumn.AllowFocus = False
			' 
			' layoutViewField_layoutViewColumn1
			' 
			Me.layoutViewField_layoutViewColumn1.EditorPreferredWidth = 169
			Me.layoutViewField_layoutViewColumn1.Location = New System.Drawing.Point(0, 156)
			Me.layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1"
			Me.layoutViewField_layoutViewColumn1.Size = New System.Drawing.Size(235, 20)
			Me.layoutViewField_layoutViewColumn1.TextSize = New System.Drawing.Size(57, 13)
			Me.layoutViewField_layoutViewColumn1.TextToControlDistance = 5
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.xcCompanies
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			gridLevelNode1.LevelTemplate = Me.layoutView1
			gridLevelNode1.RelationName = "Movies"
			Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1})
			Me.gridControl1.Location = New System.Drawing.Point(6, 6)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemPictureEdit1, Me.repositoryItemMemoEdit1, Me.repositoryItemPictureEdit2, Me.repositoryItemHyperLinkEdit1})
			Me.gridControl1.ShowOnlyPredefinedDetails = True
			Me.gridControl1.Size = New System.Drawing.Size(1033, 624)
			Me.gridControl1.TabIndex = 1
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.layoutView1})
'			Me.gridControl1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.gridControl1_MouseDown);
			' 
			' xcCompanies
			' 
			Me.xcCompanies.CaseSensitive = True
			Me.xcCompanies.LoadingEnabled = False
			Me.xcCompanies.ObjectType = GetType(DevExpress.VideoRent.Company)
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colName, Me.colType, Me.colWebSite, Me.colCountry, Me.colFlag})
			Me.gridView1.DetailHeight = 100
			Me.gridView1.DetailVerticalIndent = 2
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Oid", Nothing, "")})
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsBehavior.Editable = False
			Me.gridView1.OptionsDetail.ShowDetailTabs = False
			Me.gridView1.OptionsPrint.ExpandAllDetails = True
			Me.gridView1.OptionsPrint.PrintDetails = True
			Me.gridView1.OptionsView.ShowAutoFilterRow = True
			' 
			' colName
			' 
			Me.colName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.colName.AppearanceCell.Options.UseFont = True
			Me.colName.FieldName = "Name"
			Me.colName.Name = "colName"
			Me.colName.OptionsColumn.AllowFocus = False
			Me.colName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
			Me.colName.Visible = True
			Me.colName.VisibleIndex = 0
			Me.colName.Width = 343
			' 
			' colType
			' 
			Me.colType.FieldName = "Type!Key"
			Me.colType.Name = "colType"
			Me.colType.OptionsColumn.AllowFocus = False
			Me.colType.Visible = True
			Me.colType.VisibleIndex = 2
			Me.colType.Width = 154
			' 
			' colWebSite
			' 
			Me.colWebSite.ColumnEdit = Me.repositoryItemHyperLinkEdit1
			Me.colWebSite.FieldName = "WebSite"
			Me.colWebSite.Name = "colWebSite"
			Me.colWebSite.OptionsColumn.AllowFocus = False
			Me.colWebSite.OptionsFilter.AllowFilter = False
			Me.colWebSite.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
			Me.colWebSite.Visible = True
			Me.colWebSite.VisibleIndex = 3
			Me.colWebSite.Width = 264
			' 
			' repositoryItemHyperLinkEdit1
			' 
			Me.repositoryItemHyperLinkEdit1.AutoHeight = False
			Me.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1"
			' 
			' colCountry
			' 
			Me.colCountry.FieldName = "Country!Key"
			Me.colCountry.Name = "colCountry"
			Me.colCountry.OptionsColumn.AllowFocus = False
			Me.colCountry.Visible = True
			Me.colCountry.VisibleIndex = 1
			Me.colCountry.Width = 137
			' 
			' colFlag
			' 
			Me.colFlag.Caption = "Flag"
			Me.colFlag.ColumnEdit = Me.repositoryItemPictureEdit2
			Me.colFlag.FieldName = "Country.Flag"
			Me.colFlag.Name = "colFlag"
			Me.colFlag.OptionsColumn.AllowFocus = False
			Me.colFlag.OptionsColumn.FixedWidth = True
			Me.colFlag.OptionsFilter.AllowAutoFilter = False
			Me.colFlag.OptionsFilter.AllowFilter = False
			Me.colFlag.Visible = True
			Me.colFlag.VisibleIndex = 4
			Me.colFlag.Width = 114
			' 
			' repositoryItemPictureEdit2
			' 
			Me.repositoryItemPictureEdit2.Name = "repositoryItemPictureEdit2"
			Me.repositoryItemPictureEdit2.NullText = " "
			Me.repositoryItemPictureEdit2.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
			Me.repositoryItemPictureEdit2.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
			' 
			' layoutViewCard1
			' 
			Me.layoutViewCard1.CustomizationFormText = "TemplateCard"
            Me.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
			Me.layoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_colPhotoExist1, Me.layoutViewField_colPlot2, Me.layoutViewField_colTitle2, Me.layoutViewField_colReleaseDate2, Me.layoutViewField_layoutViewColumn1})
			Me.layoutViewCard1.Name = "layoutViewCard1"
			Me.layoutViewCard1.OptionsItemText.TextToControlDistance = 5
			Me.layoutViewCard1.Text = "TemplateCard"
			' 
			' Companies
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Companies"
			Me.Padding = New System.Windows.Forms.Padding(6)
			Me.Size = New System.Drawing.Size(1045, 636)
			CType(Me.layoutView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colPhotoExist1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colTitle2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colReleaseDate2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colPlot2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_layoutViewColumn1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xcCompanies, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private xcCompanies As DevExpress.Xpo.XPCollection
		Private WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colName As DevExpress.XtraGrid.Columns.GridColumn
		Private colType As DevExpress.XtraGrid.Columns.GridColumn
		Private colWebSite As DevExpress.XtraGrid.Columns.GridColumn
		Private colCountry As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private repositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
		Private WithEvents layoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
		Private colPhoto1 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colTitle1 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colReleaseDate1 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colPlot1 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private colFlag As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemPictureEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private repositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
		Private layoutViewField_colPhotoExist1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colTitle2 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colReleaseDate2 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewField_colPlot2 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private colDescription As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_layoutViewColumn1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
	End Class
End Namespace
