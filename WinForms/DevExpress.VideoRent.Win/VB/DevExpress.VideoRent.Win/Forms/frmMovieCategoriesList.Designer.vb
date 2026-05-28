Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmMovieCategoriesList
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
			Me.lcMain = New DevExpress.XtraLayout.LayoutControl()
			Me.ucMovieCategoryDetail = New DevExpress.VideoRent.Win.Controls.ucMovieCategoryDetail()
			Me.gcCategories = New DevExpress.XtraGrid.GridControl()
			Me.gvCategories = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colIsDefault = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.lcgMain = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lciCategories = New DevExpress.XtraLayout.LayoutControlItem()
			Me.splitterItem = New DevExpress.XtraLayout.SplitterItem()
			Me.lciMovieCategoryDetail = New DevExpress.XtraLayout.LayoutControlItem()
			Me.pcButtons = New DevExpress.XtraEditors.PanelControl()
			Me.sbSave = New DevExpress.XtraEditors.SimpleButton()
			Me.pcSpace = New DevExpress.XtraEditors.PanelControl()
			Me.sbCancel = New DevExpress.XtraEditors.SimpleButton()
			Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
			Me.barEditCategories = New DevExpress.XtraBars.Bar()
			Me.bbiAdd = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.lcMain.SuspendLayout()
			CType(Me.gcCategories, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gvCategories, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciCategories, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitterItem, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciMovieCategoryDetail, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pcButtons, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pcButtons.SuspendLayout()
			CType(Me.pcSpace, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' lcMain
			' 
			Me.lcMain.Controls.Add(Me.ucMovieCategoryDetail)
			Me.lcMain.Controls.Add(Me.gcCategories)
			Me.lcMain.Dock = System.Windows.Forms.DockStyle.Fill
			Me.lcMain.Location = New System.Drawing.Point(24, 0)
			Me.lcMain.Name = "lcMain"
			Me.lcMain.Root = Me.lcgMain
			Me.lcMain.Size = New System.Drawing.Size(651, 342)
			Me.lcMain.TabIndex = 0
			Me.lcMain.Text = "layoutControl1"
			' 
			' ucMovieCategoryDetail
			' 
			Me.ucMovieCategoryDetail.Location = New System.Drawing.Point(229, 4)
			Me.ucMovieCategoryDetail.Name = "ucMovieCategoryDetail"
			Me.ucMovieCategoryDetail.Size = New System.Drawing.Size(418, 338)
			Me.ucMovieCategoryDetail.TabIndex = 5
			' 
			' gcCategories
			' 
			Me.gcCategories.Location = New System.Drawing.Point(6, 6)
			Me.gcCategories.MainView = Me.gvCategories
			Me.gcCategories.Name = "gcCategories"
			Me.gcCategories.Size = New System.Drawing.Size(215, 334)
			Me.gcCategories.TabIndex = 4
			Me.gcCategories.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gvCategories})
			' 
			' gvCategories
			' 
			Me.gvCategories.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colName, Me.colIsDefault})
			Me.gvCategories.GridControl = Me.gcCategories
			Me.gvCategories.Name = "gvCategories"
			Me.gvCategories.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False
			Me.gvCategories.OptionsBehavior.Editable = False
			Me.gvCategories.OptionsBehavior.ReadOnly = True
			Me.gvCategories.OptionsView.ShowDetailButtons = False
			Me.gvCategories.OptionsView.ShowGroupPanel = False
			Me.gvCategories.OptionsView.ShowIndicator = False
            Me.gvCategories.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False
'			Me.gvCategories.FocusedRowChanged += New DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(Me.gvCategories_FocusedRowChanged);
'			Me.gvCategories.ColumnFilterChanged += New System.EventHandler(Me.gvCategories_ColumnFilterChanged);
			' 
			' colName
			' 
			Me.colName.FieldName = "Name"
			Me.colName.Name = "colName"
			Me.colName.OptionsColumn.AllowFocus = False
			Me.colName.Visible = True
			Me.colName.VisibleIndex = 0
			Me.colName.Width = 217
			' 
			' colIsDefault
			' 
			Me.colIsDefault.Caption = "Default"
			Me.colIsDefault.FieldName = "IsDefault"
			Me.colIsDefault.Name = "colIsDefault"
			Me.colIsDefault.OptionsColumn.AllowFocus = False
			Me.colIsDefault.Visible = True
			Me.colIsDefault.VisibleIndex = 1
			Me.colIsDefault.Width = 94
			' 
			' lcgMain
			' 
			Me.lcgMain.CustomizationFormText = "lcgMain"
			Me.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.lcgMain.GroupBordersVisible = False
			Me.lcgMain.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciCategories, Me.splitterItem, Me.lciMovieCategoryDetail})
			Me.lcgMain.Location = New System.Drawing.Point(0, 0)
			Me.lcgMain.Name = "Root"
			Me.lcgMain.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 0)
			Me.lcgMain.Size = New System.Drawing.Size(651, 342)
			Me.lcgMain.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lcgMain.Text = "Root"
			Me.lcgMain.TextVisible = False
			' 
			' lciCategories
			' 
			Me.lciCategories.Control = Me.gcCategories
			Me.lciCategories.CustomizationFormText = "lciCategories"
			Me.lciCategories.Location = New System.Drawing.Point(0, 0)
			Me.lciCategories.Name = "lciCategories"
			Me.lciCategories.Size = New System.Drawing.Size(219, 338)
			Me.lciCategories.Text = "lciCategories"
			Me.lciCategories.TextSize = New System.Drawing.Size(0, 0)
			Me.lciCategories.TextToControlDistance = 0
			Me.lciCategories.TextVisible = False
			' 
			' splitterItem
			' 
			Me.splitterItem.AllowHotTrack = True
			Me.splitterItem.CustomizationFormText = "splitterItem"
			Me.splitterItem.Location = New System.Drawing.Point(219, 0)
			Me.splitterItem.Name = "splitterItem"
			Me.splitterItem.Size = New System.Drawing.Size(6, 338)
			' 
			' lciMovieCategoryDetail
			' 
			Me.lciMovieCategoryDetail.Control = Me.ucMovieCategoryDetail
			Me.lciMovieCategoryDetail.CustomizationFormText = "lciMovieCategoryDetail"
			Me.lciMovieCategoryDetail.Location = New System.Drawing.Point(225, 0)
			Me.lciMovieCategoryDetail.Name = "lciMovieCategoryDetail"
			Me.lciMovieCategoryDetail.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lciMovieCategoryDetail.Size = New System.Drawing.Size(418, 338)
			Me.lciMovieCategoryDetail.Text = "lciMovieCategoryDetail"
			Me.lciMovieCategoryDetail.TextSize = New System.Drawing.Size(0, 0)
			Me.lciMovieCategoryDetail.TextToControlDistance = 0
			Me.lciMovieCategoryDetail.TextVisible = False
			' 
			' pcButtons
			' 
			Me.pcButtons.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pcButtons.Controls.Add(Me.sbSave)
			Me.pcButtons.Controls.Add(Me.pcSpace)
			Me.pcButtons.Controls.Add(Me.sbCancel)
			Me.pcButtons.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pcButtons.Location = New System.Drawing.Point(12, 12)
			Me.pcButtons.Name = "pcButtons"
			Me.pcButtons.Size = New System.Drawing.Size(627, 22)
			Me.pcButtons.TabIndex = 8
			' 
			' sbSave
			' 
			Me.sbSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.sbSave.Dock = System.Windows.Forms.DockStyle.Right
			Me.sbSave.Location = New System.Drawing.Point(414, 0)
			Me.sbSave.Name = "sbSave"
			Me.sbSave.Size = New System.Drawing.Size(124, 22)
			Me.sbSave.TabIndex = 3
			Me.sbSave.Text = "S&ave and Close"
'			Me.sbSave.Click += New System.EventHandler(Me.sbSave_Click);
			' 
			' pcSpace
			' 
			Me.pcSpace.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pcSpace.Dock = System.Windows.Forms.DockStyle.Right
			Me.pcSpace.Location = New System.Drawing.Point(538, 0)
			Me.pcSpace.Name = "pcSpace"
			Me.pcSpace.Size = New System.Drawing.Size(6, 22)
			Me.pcSpace.TabIndex = 2
			' 
			' sbCancel
			' 
			Me.sbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.sbCancel.Dock = System.Windows.Forms.DockStyle.Right
			Me.sbCancel.Location = New System.Drawing.Point(544, 0)
			Me.sbCancel.Name = "sbCancel"
			Me.sbCancel.Size = New System.Drawing.Size(83, 22)
			Me.sbCancel.TabIndex = 0
			Me.sbCancel.Text = "&Close"
			' 
			' barManager
			' 
			Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.barEditCategories})
			Me.barManager.DockControls.Add(Me.barDockControlTop)
			Me.barManager.DockControls.Add(Me.barDockControlBottom)
			Me.barManager.DockControls.Add(Me.barDockControlLeft)
			Me.barManager.DockControls.Add(Me.barDockControlRight)
			Me.barManager.Form = Me
			Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.bbiAdd, Me.bbiDelete})
			Me.barManager.MaxItemId = 3
			' 
			' barEditCategories
			' 
			Me.barEditCategories.BarName = "Main menu"
			Me.barEditCategories.DockCol = 0
			Me.barEditCategories.DockRow = 0
			Me.barEditCategories.DockStyle = DevExpress.XtraBars.BarDockStyle.Left
			Me.barEditCategories.FloatLocation = New System.Drawing.Point(204, 159)
			Me.barEditCategories.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAdd), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiDelete)})
			Me.barEditCategories.OptionsBar.AllowQuickCustomization = False
			Me.barEditCategories.OptionsBar.DrawDragBorder = False
			Me.barEditCategories.OptionsBar.MultiLine = True
			Me.barEditCategories.OptionsBar.UseWholeRow = True
			Me.barEditCategories.Text = "Edit Categories"
			' 
			' bbiAdd
			' 
			Me.bbiAdd.Caption = "Add"
			Me.bbiAdd.Hint = "Add new category"
			Me.bbiAdd.Id = 0
			Me.bbiAdd.Name = "bbiAdd"
			Me.bbiAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
'			Me.bbiAdd.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbiAdd_ItemClick);
			' 
			' bbiDelete
			' 
			Me.bbiDelete.Caption = "Delete"
			Me.bbiDelete.Hint = "Delete current category"
			Me.bbiDelete.Id = 1
			Me.bbiDelete.Name = "bbiDelete"
'			Me.bbiDelete.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbiDelete_ItemClick);
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(675, 0)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 388)
			Me.barDockControlBottom.Size = New System.Drawing.Size(675, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlLeft.Size = New System.Drawing.Size(24, 388)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(675, 0)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 388)
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Controls.Add(Me.pcButtons)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panelControl1.Location = New System.Drawing.Point(24, 342)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Padding = New System.Windows.Forms.Padding(12)
			Me.panelControl1.Size = New System.Drawing.Size(651, 46)
			Me.panelControl1.TabIndex = 9
			' 
			' frmMovieCategoriesList
			' 
			Me.AcceptButton = Me.sbCancel
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me.sbSave
			Me.ClientSize = New System.Drawing.Size(675, 388)
			Me.Controls.Add(Me.lcMain)
			Me.Controls.Add(Me.panelControl1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "frmMovieCategoriesList"
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Movie Categories"
'			Me.FormClosing += New System.Windows.Forms.FormClosingEventHandler(Me.frmMovieCategoriesList_FormClosing);
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).EndInit()
			Me.lcMain.ResumeLayout(False)
			CType(Me.gcCategories, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gvCategories, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciCategories, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.splitterItem, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciMovieCategoryDetail, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pcButtons, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pcButtons.ResumeLayout(False)
			CType(Me.pcSpace, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private lcMain As DevExpress.XtraLayout.LayoutControl
		Private lcgMain As DevExpress.XtraLayout.LayoutControlGroup
		Private gcCategories As DevExpress.XtraGrid.GridControl
		Private WithEvents gvCategories As DevExpress.XtraGrid.Views.Grid.GridView
		Private lciCategories As DevExpress.XtraLayout.LayoutControlItem
		Private colName As DevExpress.XtraGrid.Columns.GridColumn
		Private colIsDefault As DevExpress.XtraGrid.Columns.GridColumn
		Private splitterItem As DevExpress.XtraLayout.SplitterItem
		Private barManager As DevExpress.XtraBars.BarManager
		Private barEditCategories As DevExpress.XtraBars.Bar
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private WithEvents bbiAdd As DevExpress.XtraBars.BarButtonItem
		Private WithEvents bbiDelete As DevExpress.XtraBars.BarButtonItem
		Private pcButtons As DevExpress.XtraEditors.PanelControl
		Private sbCancel As DevExpress.XtraEditors.SimpleButton
		Private pcSpace As DevExpress.XtraEditors.PanelControl
		Private WithEvents sbSave As DevExpress.XtraEditors.SimpleButton
		Private ucMovieCategoryDetail As DevExpress.VideoRent.Win.Controls.ucMovieCategoryDetail
		Private lciMovieCategoryDetail As DevExpress.XtraLayout.LayoutControlItem
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
	End Class
End Namespace
