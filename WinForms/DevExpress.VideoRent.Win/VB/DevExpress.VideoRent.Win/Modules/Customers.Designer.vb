Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Modules
	Partial Public Class Customers
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
			Me.xcCustomers = New DevExpress.Xpo.XPCollection()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.advBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
			Me.gbPhoto = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colPhoto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			Me.gbData = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colCustomerId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colName1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colBirthDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colPhone = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colEmail = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colGender = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gbAddress = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colAddress = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
			Me.gbComments = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colComments = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.repositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
			Me.colLevel = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colDiscount = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.repositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
			Me.repositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colGender2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colBirthDate2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCardNumber = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colAddress2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colPhone2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colPhoto2 = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.xcCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xcCustomers
			' 
			Me.xcCustomers.ObjectType = GetType(DevExpress.VideoRent.Customer)
			Me.xcCustomers.Sorting.AddRange(New DevExpress.Xpo.SortProperty() { New DevExpress.Xpo.SortProperty("[CustomerId]", DevExpress.Xpo.DB.SortingDirection.Ascending)})
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.xcCustomers
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(6, 6)
			Me.gridControl1.MainView = Me.advBandedGridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemPictureEdit1, Me.repositoryItemMemoEdit1, Me.repositoryItemMemoExEdit1, Me.repositoryItemMemoEdit2, Me.repositoryItemImageEdit1})
			Me.gridControl1.ShowOnlyPredefinedDetails = True
			Me.gridControl1.Size = New System.Drawing.Size(941, 559)
			Me.gridControl1.TabIndex = 1
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.advBandedGridView1, Me.gridView1})
			' 
			' advBandedGridView1
			' 
			Me.advBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gbPhoto, Me.gbData, Me.gbAddress, Me.gbComments})
			Me.advBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() { Me.colName1, Me.colGender, Me.colBirthDate, Me.colCustomerId, Me.colEmail, Me.colAddress, Me.colPhone, Me.colComments, Me.colPhoto, Me.colLevel, Me.colDiscount})
			Me.advBandedGridView1.GridControl = Me.gridControl1
			Me.advBandedGridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Oid", Nothing, "")})
			Me.advBandedGridView1.Name = "advBandedGridView1"
			Me.advBandedGridView1.OptionsBehavior.Editable = False
			Me.advBandedGridView1.OptionsCustomization.AllowQuickHideColumns = False
			Me.advBandedGridView1.OptionsFind.AlwaysVisible = True
			Me.advBandedGridView1.OptionsView.ColumnAutoWidth = True
			Me.advBandedGridView1.OptionsView.ShowBands = False
			Me.advBandedGridView1.OptionsView.ShowGroupPanel = False
'			Me.advBandedGridView1.FocusedRowChanged += New DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(Me.advBandedGridView1_FocusedRowChanged);
'			Me.advBandedGridView1.FocusedColumnChanged += New DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(Me.advBandedGridView1_FocusedColumnChanged);
'			Me.advBandedGridView1.CustomDrawCell += New DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(Me.advBandedGridView1_CustomDrawCell);
'			Me.advBandedGridView1.PopupMenuShowing += New DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(Me.advBandedGridView1_PopupMenuShowing);
'			Me.advBandedGridView1.CustomDrawColumnHeader += New DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventHandler(Me.advBandedGridView1_CustomDrawColumnHeader);
			' 
			' gbPhoto
			' 
			Me.gbPhoto.Caption = "Photo"
			Me.gbPhoto.Columns.Add(Me.colPhoto)
			Me.gbPhoto.Name = "gbPhoto"
			Me.gbPhoto.OptionsBand.FixedWidth = True
			Me.gbPhoto.Width = 43
			' 
			' colPhoto
			' 
			Me.colPhoto.AutoFillDown = True
			Me.colPhoto.ColumnEdit = Me.repositoryItemPictureEdit1
			Me.colPhoto.FieldName = "Photo"
			Me.colPhoto.Name = "colPhoto"
			Me.colPhoto.OptionsColumn.AllowFocus = False
			Me.colPhoto.OptionsColumn.AllowSize = False
			Me.colPhoto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			Me.colPhoto.OptionsColumn.FixedWidth = True
			Me.colPhoto.OptionsFilter.AllowAutoFilter = False
			Me.colPhoto.OptionsFilter.AllowFilter = False
			Me.colPhoto.Visible = True
			Me.colPhoto.Width = 43
			' 
			' repositoryItemPictureEdit1
			' 
			Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
			Me.repositoryItemPictureEdit1.NullText = " "
			Me.repositoryItemPictureEdit1.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
			Me.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
			' 
			' gbData
			' 
			Me.gbData.Caption = "Data"
			Me.gbData.Columns.Add(Me.colCustomerId)
			Me.gbData.Columns.Add(Me.colName1)
			Me.gbData.Columns.Add(Me.colBirthDate)
			Me.gbData.Columns.Add(Me.colPhone)
			Me.gbData.Columns.Add(Me.colEmail)
			Me.gbData.Columns.Add(Me.colGender)
			Me.gbData.Name = "gbData"
			Me.gbData.Width = 497
			' 
			' colCustomerId
			' 
			Me.colCustomerId.AppearanceCell.Options.UseTextOptions = True
			Me.colCustomerId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.colCustomerId.Caption = "Card Number"
			Me.colCustomerId.FieldName = "CustomerId"
			Me.colCustomerId.Name = "colCustomerId"
			Me.colCustomerId.OptionsColumn.AllowFocus = False
			Me.colCustomerId.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
			Me.colCustomerId.Visible = True
			Me.colCustomerId.Width = 107
			' 
			' colName1
			' 
			Me.colName1.Caption = "Name"
			Me.colName1.FieldName = "FullName"
			Me.colName1.Name = "colName1"
			Me.colName1.OptionsColumn.AllowFocus = False
			Me.colName1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
			Me.colName1.Visible = True
			Me.colName1.Width = 246
			' 
			' colBirthDate
			' 
			Me.colBirthDate.FieldName = "BirthDate"
			Me.colBirthDate.Name = "colBirthDate"
			Me.colBirthDate.OptionsColumn.AllowFocus = False
			Me.colBirthDate.Visible = True
			Me.colBirthDate.Width = 144
			' 
			' colPhone
			' 
			Me.colPhone.FieldName = "Phone"
			Me.colPhone.Name = "colPhone"
			Me.colPhone.OptionsColumn.AllowFocus = False
			Me.colPhone.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
			Me.colPhone.RowIndex = 1
			Me.colPhone.Visible = True
			Me.colPhone.Width = 107
			' 
			' colEmail
			' 
			Me.colEmail.FieldName = "Email"
			Me.colEmail.Name = "colEmail"
			Me.colEmail.OptionsColumn.AllowFocus = False
			Me.colEmail.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
			Me.colEmail.RowIndex = 1
			Me.colEmail.Visible = True
			Me.colEmail.Width = 246
			' 
			' colGender
			' 
			Me.colGender.FieldName = "Gender"
			Me.colGender.Name = "colGender"
			Me.colGender.OptionsColumn.AllowFocus = False
			Me.colGender.RowIndex = 1
			Me.colGender.Visible = True
			Me.colGender.Width = 144
			' 
			' gbAddress
			' 
			Me.gbAddress.Caption = "Address"
			Me.gbAddress.Columns.Add(Me.colAddress)
			Me.gbAddress.Name = "gbAddress"
			Me.gbAddress.Width = 172
			' 
			' colAddress
			' 
			Me.colAddress.AutoFillDown = True
			Me.colAddress.ColumnEdit = Me.repositoryItemMemoEdit1
			Me.colAddress.FieldName = "Address"
			Me.colAddress.Name = "colAddress"
			Me.colAddress.OptionsColumn.AllowFocus = False
			Me.colAddress.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
			Me.colAddress.Visible = True
			Me.colAddress.Width = 172
			' 
			' repositoryItemMemoEdit1
			' 
			Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
			' 
			' gbComments
			' 
			Me.gbComments.Caption = "Comments"
			Me.gbComments.Columns.Add(Me.colComments)
			Me.gbComments.Columns.Add(Me.colLevel)
			Me.gbComments.Columns.Add(Me.colDiscount)
			Me.gbComments.Name = "gbComments"
			Me.gbComments.Width = 208
			' 
			' colComments
			' 
			Me.colComments.AutoFillDown = True
			Me.colComments.ColumnEdit = Me.repositoryItemMemoEdit2
			Me.colComments.FieldName = "Comments"
			Me.colComments.Name = "colComments"
			Me.colComments.OptionsColumn.AllowFocus = False
			Me.colComments.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
			Me.colComments.Visible = True
			Me.colComments.Width = 208
			' 
			' repositoryItemMemoEdit2
			' 
			Me.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2"
			' 
			' colLevel
			' 
			Me.colLevel.FieldName = "DiscountLevel"
			Me.colLevel.Name = "colLevel"
			Me.colLevel.OptionsColumn.AllowFocus = False
			Me.colLevel.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
			Me.colLevel.RowIndex = 1
			Me.colLevel.Visible = True
			Me.colLevel.Width = 101
			' 
			' colDiscount
			' 
			Me.colDiscount.DisplayFormat.FormatString = "P"
			Me.colDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colDiscount.FieldName = "Discount"
			Me.colDiscount.Name = "colDiscount"
			Me.colDiscount.OptionsColumn.AllowFocus = False
			Me.colDiscount.RowIndex = 1
			Me.colDiscount.Visible = True
			Me.colDiscount.Width = 107
			' 
			' repositoryItemMemoExEdit1
			' 
			Me.repositoryItemMemoExEdit1.AutoHeight = False
			Me.repositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1"
			' 
			' repositoryItemImageEdit1
			' 
			Me.repositoryItemImageEdit1.AutoHeight = False
			Me.repositoryItemImageEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1"
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colName, Me.colGender2, Me.colBirthDate2, Me.colCardNumber, Me.colAddress2, Me.colPhone2, Me.gridColumn10, Me.colPhoto2})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsBehavior.Editable = False
			Me.gridView1.OptionsView.ShowAutoFilterRow = True
			Me.gridView1.OptionsView.ShowGroupPanel = False
'			Me.gridView1.FocusedRowChanged += New DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(Me.advBandedGridView1_FocusedRowChanged);
'			Me.gridView1.FocusedColumnChanged += New DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(Me.advBandedGridView1_FocusedColumnChanged);
'			Me.gridView1.CustomDrawColumnHeader += New DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventHandler(Me.advBandedGridView1_CustomDrawColumnHeader);
			' 
			' colName
			' 
			Me.colName.Caption = "Name"
			Me.colName.FieldName = "FullName"
			Me.colName.Name = "colName"
			Me.colName.OptionsColumn.AllowFocus = False
			Me.colName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
			Me.colName.Visible = True
			Me.colName.VisibleIndex = 2
			' 
			' colGender2
			' 
			Me.colGender2.FieldName = "Gender"
			Me.colGender2.Name = "colGender2"
			Me.colGender2.OptionsColumn.AllowFocus = False
			Me.colGender2.OptionsColumn.FixedWidth = True
			Me.colGender2.OptionsColumn.ShowCaption = False
			Me.colGender2.OptionsFilter.AllowAutoFilter = False
			Me.colGender2.Visible = True
			Me.colGender2.VisibleIndex = 0
			Me.colGender2.Width = 40
			' 
			' colBirthDate2
			' 
			Me.colBirthDate2.FieldName = "BirthDate"
			Me.colBirthDate2.Name = "colBirthDate2"
			Me.colBirthDate2.OptionsColumn.AllowFocus = False
			Me.colBirthDate2.Visible = True
			Me.colBirthDate2.VisibleIndex = 3
			' 
			' colCardNumber
			' 
			Me.colCardNumber.AppearanceCell.Options.UseTextOptions = True
			Me.colCardNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.colCardNumber.Caption = "Card Number"
			Me.colCardNumber.FieldName = "CustomerId"
			Me.colCardNumber.Name = "colCardNumber"
			Me.colCardNumber.OptionsColumn.AllowFocus = False
			Me.colCardNumber.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
			Me.colCardNumber.Visible = True
			Me.colCardNumber.VisibleIndex = 1
			' 
			' colAddress2
			' 
			Me.colAddress2.FieldName = "Address"
			Me.colAddress2.Name = "colAddress2"
			Me.colAddress2.OptionsColumn.AllowFocus = False
			Me.colAddress2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
			Me.colAddress2.Visible = True
			Me.colAddress2.VisibleIndex = 4
			' 
			' colPhone2
			' 
			Me.colPhone2.FieldName = "Phone"
			Me.colPhone2.Name = "colPhone2"
			Me.colPhone2.OptionsColumn.AllowFocus = False
			Me.colPhone2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
			Me.colPhone2.Visible = True
			Me.colPhone2.VisibleIndex = 5
			' 
			' gridColumn10
			' 
			Me.gridColumn10.ColumnEdit = Me.repositoryItemMemoExEdit1
			Me.gridColumn10.FieldName = "Comments"
			Me.gridColumn10.Name = "gridColumn10"
			Me.gridColumn10.OptionsColumn.AllowFocus = False
			Me.gridColumn10.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
			Me.gridColumn10.Visible = True
			Me.gridColumn10.VisibleIndex = 7
			' 
			' colPhoto2
			' 
			Me.colPhoto2.ColumnEdit = Me.repositoryItemImageEdit1
			Me.colPhoto2.FieldName = "Photo"
			Me.colPhoto2.Name = "colPhoto2"
			Me.colPhoto2.OptionsColumn.AllowFocus = False
			Me.colPhoto2.OptionsFilter.AllowAutoFilter = False
			Me.colPhoto2.OptionsFilter.AllowFilter = False
			Me.colPhoto2.Visible = True
			Me.colPhoto2.VisibleIndex = 6
			' 
			' Customers
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Customers"
			Me.Padding = New System.Windows.Forms.Padding(6)
			Me.Size = New System.Drawing.Size(953, 571)
			CType(Me.xcCustomers, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private xcCustomers As DevExpress.Xpo.XPCollection
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents advBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
		Private colPhoto As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private colCustomerId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colName1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colGender As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colBirthDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colEmail As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colPhone As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colAddress As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colComments As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private repositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
		Private colLevel As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private gbPhoto As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gbData As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gbAddress As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gbComments As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private colDiscount As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colName As DevExpress.XtraGrid.Columns.GridColumn
		Private colGender2 As DevExpress.XtraGrid.Columns.GridColumn
		Private colBirthDate2 As DevExpress.XtraGrid.Columns.GridColumn
		Private colCardNumber As DevExpress.XtraGrid.Columns.GridColumn
		Private colAddress2 As DevExpress.XtraGrid.Columns.GridColumn
		Private colPhone2 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
		Private colPhoto2 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
		Private repositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
		Private repositoryItemImageEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
	End Class
End Namespace
