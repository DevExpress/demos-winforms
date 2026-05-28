Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Controls
	Partial Public Class ucBarOneCheckedButton
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
			Me.bciSwitch = New DevExpress.XtraBars.BarCheckItem()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.biSwitch = New DevExpress.XtraBars.BarLargeButtonItem()
			CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' barManager
			' 
			Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.mainBar})
			Me.barManager.DockControls.Add(Me.barDockControlTop)
			Me.barManager.DockControls.Add(Me.barDockControlBottom)
			Me.barManager.DockControls.Add(Me.barDockControlLeft)
			Me.barManager.DockControls.Add(Me.barDockControlRight)
			Me.barManager.Form = Me
			Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.biSwitch, Me.bciSwitch})
			Me.barManager.MaxItemId = 2
			' 
			' mainBar
			' 
			Me.mainBar.BarName = "Tools"
			Me.mainBar.DockCol = 0
			Me.mainBar.DockRow = 0
			Me.mainBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.mainBar.FloatLocation = New System.Drawing.Point(49, 115)
			Me.mainBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.bciSwitch)})
			Me.mainBar.OptionsBar.AllowQuickCustomization = False
			Me.mainBar.OptionsBar.DisableClose = True
			Me.mainBar.OptionsBar.DisableCustomization = True
			Me.mainBar.OptionsBar.DrawDragBorder = False
			Me.mainBar.OptionsBar.UseWholeRow = True
			Me.mainBar.Text = "Tools"
			' 
			' bciSwitch
			' 
			Me.bciSwitch.Caption = "Text"
			Me.bciSwitch.Id = 1
			Me.bciSwitch.Name = "bciSwitch"
'			Me.bciSwitch.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.bciSwitch_CheckedChanged);
			' 
			' biSwitch
			' 
			Me.biSwitch.Caption = "Only Active"
			Me.biSwitch.Id = 0
			Me.biSwitch.Name = "biSwitch"
			' 
			' ucBarOneCheckedButton
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "ucBarOneCheckedButton"
			Me.Size = New System.Drawing.Size(152, 25)
			CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private barManager As DevExpress.XtraBars.BarManager
		Private mainBar As DevExpress.XtraBars.Bar
		Private biSwitch As DevExpress.XtraBars.BarLargeButtonItem
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private WithEvents bciSwitch As DevExpress.XtraBars.BarCheckItem
	End Class
End Namespace
