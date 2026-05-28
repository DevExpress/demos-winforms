Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Controls
	Partial Public Class ucPictureCollection
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
			Me.peImage = New DevExpress.XtraEditors.PictureEdit()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.mainBar = New DevExpress.XtraBars.Bar()
			Me.bbiPrev = New DevExpress.XtraBars.BarButtonItem()
			Me.bsiRecords = New DevExpress.XtraBars.BarStaticItem()
			Me.bbiNext = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiAdd = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			CType(Me.peImage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' peImage
			' 
			Me.peImage.Dock = System.Windows.Forms.DockStyle.Fill
			Me.peImage.Location = New System.Drawing.Point(0, 0)
			Me.peImage.Name = "peImage"
			Me.peImage.Properties.AllowFocused = False
			Me.peImage.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.peImage.Properties.Appearance.Options.UseBackColor = True
			Me.peImage.Properties.ReadOnly = True
			Me.peImage.Properties.ShowMenu = False
			Me.peImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
			Me.peImage.Size = New System.Drawing.Size(324, 284)
			Me.peImage.TabIndex = 1
			' 
			' panelControl2
			' 
			Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panelControl2.Location = New System.Drawing.Point(0, 284)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Size = New System.Drawing.Size(324, 4)
			Me.panelControl2.TabIndex = 2
			' 
			' barManager1
			' 
			Me.barManager1.AllowCustomization = False
			Me.barManager1.AllowQuickCustomization = False
			Me.barManager1.AllowShowToolbarsPopup = False
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.mainBar})
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.bbiPrev, Me.bbiNext, Me.bbiAdd, Me.bbiDelete, Me.bsiRecords})
			Me.barManager1.MaxItemId = 5
			' 
			' mainBar
			' 
			Me.mainBar.BarName = "Custom 2"
			Me.mainBar.DockCol = 0
			Me.mainBar.DockRow = 0
			Me.mainBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
			Me.mainBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.bbiPrev), New DevExpress.XtraBars.LinkPersistInfo(Me.bsiRecords), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiNext), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAdd), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiDelete)})
			Me.mainBar.OptionsBar.AllowQuickCustomization = False
			Me.mainBar.OptionsBar.DrawDragBorder = False
			Me.mainBar.OptionsBar.UseWholeRow = True
			Me.mainBar.Text = "Main menu"
			' 
			' bbiPrev
			' 
			Me.bbiPrev.Caption = "Prev"
			Me.bbiPrev.Hint = "Previous photo"
			Me.bbiPrev.Id = 0
			Me.bbiPrev.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.Left))
			Me.bbiPrev.Name = "bbiPrev"
'			Me.bbiPrev.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbiPrev_ItemClick);
			' 
			' bsiRecords
			' 
			Me.bsiRecords.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.bsiRecords.Id = 4
			Me.bsiRecords.Name = "bsiRecords"
			Me.bsiRecords.TextAlignment = System.Drawing.StringAlignment.Near
			' 
			' bbiNext
			' 
			Me.bbiNext.Caption = "Next"
			Me.bbiNext.Hint = "Next photo"
			Me.bbiNext.Id = 1
			Me.bbiNext.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.Right))
			Me.bbiNext.Name = "bbiNext"
'			Me.bbiNext.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbiNext_ItemClick);
			' 
			' bbiAdd
			' 
			Me.bbiAdd.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
			Me.bbiAdd.Caption = "Add Image"
			Me.bbiAdd.Hint = "Add new photo"
			Me.bbiAdd.Id = 2
			Me.bbiAdd.Name = "bbiAdd"
'			Me.bbiAdd.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbiAdd_ItemClick);
			' 
			' bbiDelete
			' 
			Me.bbiDelete.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
			Me.bbiDelete.Caption = "Delete Image"
			Me.bbiDelete.Hint = "Delete current photo"
			Me.bbiDelete.Id = 3
			Me.bbiDelete.Name = "bbiDelete"
'			Me.bbiDelete.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbiDelete_ItemClick);
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(324, 0)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 288)
			Me.barDockControlBottom.Size = New System.Drawing.Size(324, 24)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 288)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(324, 0)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 288)
			' 
			' ucPictureCollection
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.peImage)
			Me.Controls.Add(Me.panelControl2)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "ucPictureCollection"
			Me.Size = New System.Drawing.Size(324, 312)
			CType(Me.peImage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private peImage As DevExpress.XtraEditors.PictureEdit
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private mainBar As DevExpress.XtraBars.Bar
		Private WithEvents bbiPrev As DevExpress.XtraBars.BarButtonItem
		Private WithEvents bbiNext As DevExpress.XtraBars.BarButtonItem
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private WithEvents bbiAdd As DevExpress.XtraBars.BarButtonItem
		Private WithEvents bbiDelete As DevExpress.XtraBars.BarButtonItem
		Private bsiRecords As DevExpress.XtraBars.BarStaticItem
	End Class
End Namespace
