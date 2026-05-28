Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Controls
	Partial Public Class ucGridEditBar
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
			Me.mainBar = New DevExpress.XtraBars.Bar()
			Me.bciAllowEditing = New DevExpress.XtraBars.BarCheckItem()
			Me.bbiAdd = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
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
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.bciAllowEditing, Me.bbiAdd, Me.bbiDelete})
			Me.barManager1.MaxItemId = 4
			' 
			' mainBar
			' 
			Me.mainBar.BarName = "Main menu"
			Me.mainBar.DockCol = 0
			Me.mainBar.DockRow = 0
			Me.mainBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.mainBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.bciAllowEditing), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAdd, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiDelete)})
			Me.mainBar.OptionsBar.AllowQuickCustomization = False
			Me.mainBar.OptionsBar.DrawDragBorder = False
			Me.mainBar.OptionsBar.UseWholeRow = True
			Me.mainBar.Text = "Main menu"
			' 
			' bciAllowEditing
			' 
			Me.bciAllowEditing.Caption = "Allow Editing"
			Me.bciAllowEditing.Hint = "Allow Editing"
			Me.bciAllowEditing.Id = 0
			Me.bciAllowEditing.Name = "bciAllowEditing"
			Me.bciAllowEditing.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
'			Me.bciAllowEditing.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.bciAllowEditing_CheckedChanged);
			' 
			' bbiAdd
			' 
			Me.bbiAdd.Caption = "Add"
			Me.bbiAdd.Hint = "Add new record"
			Me.bbiAdd.Id = 1
			Me.bbiAdd.Name = "bbiAdd"
'			Me.bbiAdd.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbiAdd_ItemClick);
			' 
			' bbiDelete
			' 
			Me.bbiDelete.Caption = "Delete"
			Me.bbiDelete.Hint = "Delete current record"
			Me.bbiDelete.Id = 2
			Me.bbiDelete.Name = "bbiDelete"
'			Me.bbiDelete.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbiDelete_ItemClick);
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(247, 24)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 25)
			Me.barDockControlBottom.Size = New System.Drawing.Size(247, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 1)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(247, 24)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 1)
			' 
			' ucGridEditBar
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "ucGridEditBar"
			Me.Size = New System.Drawing.Size(247, 25)
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private barManager1 As DevExpress.XtraBars.BarManager
		Private mainBar As DevExpress.XtraBars.Bar
		Private WithEvents bciAllowEditing As DevExpress.XtraBars.BarCheckItem
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private WithEvents bbiAdd As DevExpress.XtraBars.BarButtonItem
		Private WithEvents bbiDelete As DevExpress.XtraBars.BarButtonItem
	End Class
End Namespace
