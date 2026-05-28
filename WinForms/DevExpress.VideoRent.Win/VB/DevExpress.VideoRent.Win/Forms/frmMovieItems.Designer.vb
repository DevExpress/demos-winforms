Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmMovieItems
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
			Me.components = New System.ComponentModel.Container()
			Dim styleFormatCondition1 As New DevExpress.XtraGrid.StyleFormatCondition()
			Me.colMovieItemId = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gcMovieItems = New DevExpress.XtraGrid.GridControl()
			Me.gvMovieItems = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colFormat = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colSellingPrice = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colAvailableForSell = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colLocation = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
			Me.barItems = New DevExpress.XtraBars.Bar()
			Me.bbiAdd = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.pcFormButtons = New DevExpress.XtraEditors.PanelControl()
			Me.sbClose = New DevExpress.XtraEditors.SimpleButton()
			Me.pnlAbout = New DevExpress.XtraEditors.PanelControl()
			Me.ucMovieInfo1 = New DevExpress.VideoRent.Win.Controls.ucMovieInfo()
			Me.pnlGrid = New DevExpress.XtraEditors.PanelControl()
			CType(Me.gcMovieItems, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gvMovieItems, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pcFormButtons, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pcFormButtons.SuspendLayout()
			CType(Me.pnlAbout, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlAbout.SuspendLayout()
			CType(Me.pnlGrid, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlGrid.SuspendLayout()
			Me.SuspendLayout()
			' 
			' colMovieItemId
			' 
			Me.colMovieItemId.AppearanceCell.Options.UseTextOptions = True
			Me.colMovieItemId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.colMovieItemId.Caption = "#"
			Me.colMovieItemId.DisplayFormat.FormatString = "d8"
			Me.colMovieItemId.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colMovieItemId.FieldName = "MovieItemId"
			Me.colMovieItemId.Name = "colMovieItemId"
			Me.colMovieItemId.OptionsColumn.AllowEdit = False
			Me.colMovieItemId.OptionsColumn.AllowFocus = False
			Me.colMovieItemId.OptionsColumn.ReadOnly = True
			Me.colMovieItemId.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
			Me.colMovieItemId.Visible = True
			Me.colMovieItemId.VisibleIndex = 0
			Me.colMovieItemId.Width = 126
			' 
			' gcMovieItems
			' 
			Me.gcMovieItems.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gcMovieItems.Location = New System.Drawing.Point(6, 0)
			Me.gcMovieItems.MainView = Me.gvMovieItems
			Me.gcMovieItems.Name = "gcMovieItems"
			Me.gcMovieItems.Size = New System.Drawing.Size(750, 363)
			Me.gcMovieItems.TabIndex = 0
			Me.gcMovieItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gvMovieItems})
			' 
			' gvMovieItems
			' 
			Me.gvMovieItems.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colMovieItemId, Me.colStatus, Me.colFormat, Me.colSellingPrice, Me.colAvailableForSell, Me.colLocation})
			styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(120))))), (CInt(Fix((CByte(120))))), (CInt(Fix((CByte(120))))))
			styleFormatCondition1.Appearance.Options.UseForeColor = True
			styleFormatCondition1.ApplyToRow = True
			styleFormatCondition1.Column = Me.colMovieItemId
			styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
			styleFormatCondition1.Value1 = 0
			Me.gvMovieItems.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() { styleFormatCondition1})
			Me.gvMovieItems.GridControl = Me.gcMovieItems
			Me.gvMovieItems.GroupCount = 1
			Me.gvMovieItems.Name = "gvMovieItems"
			Me.gvMovieItems.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False
			Me.gvMovieItems.OptionsSelection.MultiSelect = True
			Me.gvMovieItems.OptionsView.ShowDetailButtons = False
			Me.gvMovieItems.OptionsView.ShowFooter = True
			Me.gvMovieItems.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFormat, DevExpress.Data.ColumnSortOrder.Descending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colStatus, DevExpress.Data.ColumnSortOrder.Ascending)})
'			Me.gvMovieItems.SelectionChanged += New DevExpress.Data.SelectionChangedEventHandler(Me.gvMovieItems_SelectionChanged);
'			Me.gvMovieItems.CellValueChanging += New DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(Me.gvMovieItems_CellValueChanging);
'			Me.gvMovieItems.CustomDrawCell += New DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(Me.gvMovieItems_CustomDrawCell);
'			Me.gvMovieItems.ShowingEditor += New System.ComponentModel.CancelEventHandler(Me.gvMovieItems_ShowingEditor);
'			Me.gvMovieItems.EndGrouping += New System.EventHandler(Me.gvMovieItems_EndGrouping);
'			Me.gvMovieItems.PopupMenuShowing += New DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(Me.gvMovieItems_PopupMenuShowing);
			' 
			' colStatus
			' 
			Me.colStatus.FieldName = "Status"
			Me.colStatus.Name = "colStatus"
			Me.colStatus.OptionsColumn.AllowEdit = False
			Me.colStatus.OptionsColumn.AllowFocus = False
			Me.colStatus.OptionsColumn.ReadOnly = True
			Me.colStatus.Visible = True
			Me.colStatus.VisibleIndex = 1
			Me.colStatus.Width = 176
			' 
			' colFormat
			' 
			Me.colFormat.FieldName = "Format"
			Me.colFormat.Name = "colFormat"
			Me.colFormat.OptionsColumn.AllowEdit = False
			Me.colFormat.OptionsColumn.AllowFocus = False
			Me.colFormat.OptionsColumn.ReadOnly = True
			Me.colFormat.Width = 180
			' 
			' colSellingPrice
			' 
			Me.colSellingPrice.DisplayFormat.FormatString = "c"
			Me.colSellingPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colSellingPrice.FieldName = "SellingPrice"
			Me.colSellingPrice.Name = "colSellingPrice"
			Me.colSellingPrice.Visible = True
			Me.colSellingPrice.VisibleIndex = 2
			Me.colSellingPrice.Width = 142
			' 
			' colAvailableForSell
			' 
			Me.colAvailableForSell.FieldName = "AvailableForSell"
			Me.colAvailableForSell.Name = "colAvailableForSell"
			Me.colAvailableForSell.Visible = True
			Me.colAvailableForSell.VisibleIndex = 3
			Me.colAvailableForSell.Width = 137
			' 
			' colLocation
			' 
			Me.colLocation.FieldName = "Location"
			Me.colLocation.Name = "colLocation"
			Me.colLocation.Visible = True
			Me.colLocation.VisibleIndex = 4
			Me.colLocation.Width = 148
			' 
			' barManager
			' 
			Me.barManager.AllowCustomization = False
			Me.barManager.AllowQuickCustomization = False
			Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.barItems})
			Me.barManager.DockControls.Add(Me.barDockControlTop)
			Me.barManager.DockControls.Add(Me.barDockControlBottom)
			Me.barManager.DockControls.Add(Me.barDockControlLeft)
			Me.barManager.DockControls.Add(Me.barDockControlRight)
			Me.barManager.Form = Me
			Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.bbiAdd, Me.bbiDelete})
			Me.barManager.MaxItemId = 2
			' 
			' barItems
			' 
			Me.barItems.BarName = "Main menu"
			Me.barItems.DockCol = 0
			Me.barItems.DockRow = 0
			Me.barItems.DockStyle = DevExpress.XtraBars.BarDockStyle.Left
			Me.barItems.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAdd), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiDelete)})
			Me.barItems.OptionsBar.AllowQuickCustomization = False
			Me.barItems.OptionsBar.DrawDragBorder = False
			Me.barItems.OptionsBar.UseWholeRow = True
			Me.barItems.Text = "Main menu"
			' 
			' bbiAdd
			' 
			Me.bbiAdd.Caption = "Add Item(s)"
			Me.bbiAdd.Hint = "Add movie item(s)"
			Me.bbiAdd.Id = 0
			Me.bbiAdd.Name = "bbiAdd"
			Me.bbiAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
'			Me.bbiAdd.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbiAddItems_ItemClick);
			' 
			' bbiDelete
			' 
			Me.bbiDelete.Caption = "Delete"
			Me.bbiDelete.Hint = "Delete selected items"
			Me.bbiDelete.Id = 1
			Me.bbiDelete.Name = "bbiDelete"
'			Me.bbiDelete.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbiDelete_ItemClick);
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(786, 0)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 505)
			Me.barDockControlBottom.Size = New System.Drawing.Size(786, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlLeft.Size = New System.Drawing.Size(24, 505)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(786, 0)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 505)
			' 
			' pcFormButtons
			' 
			Me.pcFormButtons.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pcFormButtons.Controls.Add(Me.sbClose)
			Me.pcFormButtons.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.pcFormButtons.Location = New System.Drawing.Point(24, 467)
			Me.pcFormButtons.Name = "pcFormButtons"
			Me.pcFormButtons.Padding = New System.Windows.Forms.Padding(8)
			Me.pcFormButtons.Size = New System.Drawing.Size(762, 38)
			Me.pcFormButtons.TabIndex = 5
			' 
			' sbClose
			' 
			Me.sbClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.sbClose.Dock = System.Windows.Forms.DockStyle.Right
			Me.sbClose.Location = New System.Drawing.Point(671, 8)
			Me.sbClose.Name = "sbClose"
			Me.sbClose.Size = New System.Drawing.Size(83, 22)
			Me.sbClose.TabIndex = 1
			Me.sbClose.Text = "&Close"
			' 
			' pnlAbout
			' 
			Me.pnlAbout.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pnlAbout.Controls.Add(Me.ucMovieInfo1)
			Me.pnlAbout.Dock = System.Windows.Forms.DockStyle.Top
			Me.pnlAbout.Location = New System.Drawing.Point(24, 0)
			Me.pnlAbout.Name = "pnlAbout"
			Me.pnlAbout.Padding = New System.Windows.Forms.Padding(6)
			Me.pnlAbout.Size = New System.Drawing.Size(762, 104)
			Me.pnlAbout.TabIndex = 10
			' 
			' ucMovieInfo1
			' 
			Me.ucMovieInfo1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.ucMovieInfo1.Location = New System.Drawing.Point(6, 6)
			Me.ucMovieInfo1.Name = "ucMovieInfo1"
			Me.ucMovieInfo1.Size = New System.Drawing.Size(750, 92)
			Me.ucMovieInfo1.TabIndex = 0
			' 
			' pnlGrid
			' 
			Me.pnlGrid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pnlGrid.Controls.Add(Me.gcMovieItems)
			Me.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pnlGrid.Location = New System.Drawing.Point(24, 104)
			Me.pnlGrid.Name = "pnlGrid"
			Me.pnlGrid.Padding = New System.Windows.Forms.Padding(6, 0, 6, 0)
			Me.pnlGrid.Size = New System.Drawing.Size(762, 363)
			Me.pnlGrid.TabIndex = 11
			' 
			' frmMovieItems
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me.sbClose
			Me.ClientSize = New System.Drawing.Size(786, 505)
			Me.Controls.Add(Me.pnlGrid)
			Me.Controls.Add(Me.pnlAbout)
			Me.Controls.Add(Me.pcFormButtons)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "frmMovieItems"
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Movie Items"
			CType(Me.gcMovieItems, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gvMovieItems, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pcFormButtons, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pcFormButtons.ResumeLayout(False)
			CType(Me.pnlAbout, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlAbout.ResumeLayout(False)
			CType(Me.pnlGrid, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlGrid.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gcMovieItems As DevExpress.XtraGrid.GridControl
		Private WithEvents gvMovieItems As DevExpress.XtraGrid.Views.Grid.GridView
		Private colMovieItemId As DevExpress.XtraGrid.Columns.GridColumn
		Private colStatus As DevExpress.XtraGrid.Columns.GridColumn
		Private colFormat As DevExpress.XtraGrid.Columns.GridColumn
		Private colSellingPrice As DevExpress.XtraGrid.Columns.GridColumn
		Private colAvailableForSell As DevExpress.XtraGrid.Columns.GridColumn
		Private barManager As DevExpress.XtraBars.BarManager
		Private barItems As DevExpress.XtraBars.Bar
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private WithEvents bbiAdd As DevExpress.XtraBars.BarButtonItem
		Private WithEvents bbiDelete As DevExpress.XtraBars.BarButtonItem
		Private pcFormButtons As DevExpress.XtraEditors.PanelControl
		Private sbClose As DevExpress.XtraEditors.SimpleButton
		Private pnlGrid As DevExpress.XtraEditors.PanelControl
		Private pnlAbout As DevExpress.XtraEditors.PanelControl
		Private ucMovieInfo1 As DevExpress.VideoRent.Win.Controls.ucMovieInfo
		Private colLocation As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace
