Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Controls
	Partial Public Class ucScreens
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
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.brMain = New DevExpress.XtraBars.Bar()
			Me.bbiAdd = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.layoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
			Me.lvcImage = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			Me.layoutViewField_layoutViewColumn1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_layoutViewColumn1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' barManager1
			' 
			Me.barManager1.AllowCustomization = False
			Me.barManager1.AllowQuickCustomization = False
			Me.barManager1.AllowShowToolbarsPopup = False
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.brMain})
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.bbiAdd, Me.bbiDelete})
			Me.barManager1.MaxItemId = 2
			' 
			' brMain
			' 
			Me.brMain.BarName = "Main"
			Me.brMain.DockCol = 0
			Me.brMain.DockRow = 0
			Me.brMain.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.brMain.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAdd), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiDelete)})
			Me.brMain.OptionsBar.AllowQuickCustomization = False
			Me.brMain.OptionsBar.DrawDragBorder = False
			Me.brMain.OptionsBar.UseWholeRow = True
			Me.brMain.Text = "Main menu"
			' 
			' bbiAdd
			' 
			Me.bbiAdd.Caption = "Add"
			Me.bbiAdd.Hint = "Add new image"
			Me.bbiAdd.Id = 0
			Me.bbiAdd.Name = "bbiAdd"
			Me.bbiAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
'			Me.bbiAdd.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbiAdd_ItemClick);
			' 
			' bbiDelete
			' 
			Me.bbiDelete.Caption = "Delete"
			Me.bbiDelete.Hint = "Delete current image"
			Me.bbiDelete.Id = 1
			Me.bbiDelete.Name = "bbiDelete"
'			Me.bbiDelete.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbiDelete_ItemClick);
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(273, 24)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 489)
			Me.barDockControlBottom.Size = New System.Drawing.Size(273, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 465)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(273, 24)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 465)
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 24)
			Me.gridControl1.MainView = Me.layoutView1
			Me.gridControl1.MenuManager = Me.barManager1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemPictureEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(273, 465)
			Me.gridControl1.TabIndex = 4
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.layoutView1})
			' 
			' layoutView1
			' 
			Me.layoutView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.layoutView1.CardMinSize = New System.Drawing.Size(208, 42)
			Me.layoutView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() { Me.lvcImage})
			Me.layoutView1.GridControl = Me.gridControl1
			Me.layoutView1.Name = "layoutView1"
			Me.layoutView1.OptionsItemText.TextToControlDistance = 2
			Me.layoutView1.OptionsView.CardArrangeRule = DevExpress.XtraGrid.Views.Layout.LayoutCardArrangeRule.AllowPartialCards
			Me.layoutView1.OptionsView.ShowCardCaption = False
			Me.layoutView1.OptionsView.ShowCardLines = False
			Me.layoutView1.OptionsView.ShowFieldHints = False
			Me.layoutView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
			Me.layoutView1.OptionsView.ShowHeaderPanel = False
			Me.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Column
			Me.layoutView1.TemplateCard = Me.layoutViewCard1
'			Me.layoutView1.FocusedRowChanged += New DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(Me.layoutView1_FocusedRowChanged);
			' 
			' lvcImage
			' 
			Me.lvcImage.ColumnEdit = Me.repositoryItemPictureEdit1
			Me.lvcImage.FieldName = "Image"
			Me.lvcImage.LayoutViewField = Me.layoutViewField_layoutViewColumn1
			Me.lvcImage.Name = "lvcImage"
			Me.lvcImage.OptionsColumn.AllowEdit = False
			Me.lvcImage.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			Me.lvcImage.OptionsColumn.ShowCaption = False
			Me.lvcImage.OptionsFilter.AllowFilter = False
			' 
			' repositoryItemPictureEdit1
			' 
			Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
			Me.repositoryItemPictureEdit1.ReadOnly = True
			Me.repositoryItemPictureEdit1.ShowMenu = False
			Me.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
			' 
			' layoutViewField_layoutViewColumn1
			' 
			Me.layoutViewField_layoutViewColumn1.EditorPreferredWidth = 200
			Me.layoutViewField_layoutViewColumn1.Location = New System.Drawing.Point(0, 0)
			Me.layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1"
			Me.layoutViewField_layoutViewColumn1.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4)
			Me.layoutViewField_layoutViewColumn1.Size = New System.Drawing.Size(208, 30)
			Me.layoutViewField_layoutViewColumn1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutViewField_layoutViewColumn1.TextToControlDistance = 0
			Me.layoutViewField_layoutViewColumn1.TextVisible = False
			' 
			' layoutViewCard1
			' 
			Me.layoutViewCard1.CustomizationFormText = "TemplateCard"
            Me.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
			Me.layoutViewCard1.GroupBordersVisible = False
			Me.layoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_layoutViewColumn1})
			Me.layoutViewCard1.Name = "layoutViewCard1"
			Me.layoutViewCard1.OptionsItemText.TextToControlDistance = 2
			Me.layoutViewCard1.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4)
			Me.layoutViewCard1.Text = "TemplateCard"
			' 
			' ucScreens
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "ucScreens"
			Me.Size = New System.Drawing.Size(273, 489)
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_layoutViewColumn1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private barManager1 As DevExpress.XtraBars.BarManager
		Private brMain As DevExpress.XtraBars.Bar
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private WithEvents bbiAdd As DevExpress.XtraBars.BarButtonItem
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents layoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
		Private lvcImage As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private layoutViewField_layoutViewColumn1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
		Private WithEvents bbiDelete As DevExpress.XtraBars.BarButtonItem
	End Class
End Namespace
