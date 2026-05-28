Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Controls
	Partial Public Class ucBarTwoButtons
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
			Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
			Me.mainBar = New DevExpress.XtraBars.Bar()
			Me.bbiButton0 = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiButton1 = New DevExpress.XtraBars.BarButtonItem()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' barManager
			' 
			Me.barManager.AllowCustomization = False
			Me.barManager.AllowQuickCustomization = False
			Me.barManager.AllowShowToolbarsPopup = False
			Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.mainBar})
			Me.barManager.DockControls.Add(Me.barDockControlTop)
			Me.barManager.DockControls.Add(Me.barDockControlBottom)
			Me.barManager.DockControls.Add(Me.barDockControlLeft)
			Me.barManager.DockControls.Add(Me.barDockControlRight)
			Me.barManager.Form = Me
			Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.bbiButton0, Me.bbiButton1})
			Me.barManager.MaxItemId = 2
			' 
			' mainBar
			' 
			Me.mainBar.BarName = "Main menu"
			Me.mainBar.DockCol = 0
			Me.mainBar.DockRow = 0
			Me.mainBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.mainBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.bbiButton0), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiButton1)})
			Me.mainBar.OptionsBar.AllowQuickCustomization = False
			Me.mainBar.OptionsBar.DrawDragBorder = False
			Me.mainBar.OptionsBar.UseWholeRow = True
			Me.mainBar.Text = "Main menu"
			' 
			' bbiButton0
			' 
			Me.bbiButton0.Caption = "Button0"
			Me.bbiButton0.Id = 0
			Me.bbiButton0.Name = "bbiButton0"
			Me.bbiButton0.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
'			Me.bbiButton0.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbiButton0_ItemClick);
			' 
			' bbiButton1
			' 
			Me.bbiButton1.Caption = "Button1"
			Me.bbiButton1.Id = 1
			Me.bbiButton1.Name = "bbiButton1"
			Me.bbiButton1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
'			Me.bbiButton1.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbiButton1_ItemClick);
			' 
			' ucBarTwoButtons
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "ucBarTwoButtons"
			Me.Size = New System.Drawing.Size(416, 30)
			CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private barManager As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private mainBar As DevExpress.XtraBars.Bar
		Private WithEvents bbiButton0 As DevExpress.XtraBars.BarButtonItem
		Private WithEvents bbiButton1 As DevExpress.XtraBars.BarButtonItem
	End Class
End Namespace
