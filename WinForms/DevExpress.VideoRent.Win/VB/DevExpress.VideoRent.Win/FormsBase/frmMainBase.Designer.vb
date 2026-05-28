Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win
	Partial Public Class frmMainBase
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
			Dim superToolTip1 As New DevExpress.Utils.SuperToolTip()
			Dim toolTipTitleItem1 As New DevExpress.Utils.ToolTipTitleItem()
			Dim toolTipItem1 As New DevExpress.Utils.ToolTipItem()
			Me.rcMain = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.bbiAbout = New DevExpress.XtraBars.BarButtonItem()
			Me.bsUser = New DevExpress.XtraBars.BarStaticItem()
			Me.bsData = New DevExpress.XtraBars.BarStaticItem()
			Me.rsbMain = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
			Me.nbMain = New DevExpress.XtraNavBar.NavBarControl()
			Me.pnlControl = New DevExpress.XtraEditors.PanelControl()
			Me.pnlMainContainer = New DevExpress.XtraEditors.PanelControl()
			CType(Me.rcMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nbMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pnlControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pnlMainContainer, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlMainContainer.SuspendLayout()
			Me.SuspendLayout()
			' 
			' rcMain
			' 
			Me.rcMain.ApplicationButtonText = Nothing
			' 
			' 
			' 
			Me.rcMain.ExpandCollapseItem.Id = 0
			Me.rcMain.ExpandCollapseItem.Name = ""
			Me.rcMain.ExpandCollapseItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
			toolTipTitleItem1.Text = "Minimize the Ribbon (Ctrl+F1)"
			toolTipItem1.Text = "Show only the tab names on the Ribbon"
			superToolTip1.Items.Add(toolTipTitleItem1)
			superToolTip1.Items.Add(toolTipItem1)
			Me.rcMain.ExpandCollapseItem.SuperTip = superToolTip1
			Me.rcMain.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.rcMain.ExpandCollapseItem, Me.bbiAbout, Me.bsUser, Me.bsData})
			Me.rcMain.Location = New System.Drawing.Point(0, 0)
			Me.rcMain.MaxItemId = 4
			Me.rcMain.Name = "rcMain"
			Me.rcMain.PageHeaderItemLinks.Add(Me.bbiAbout)
			Me.rcMain.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
			Me.rcMain.Size = New System.Drawing.Size(1076, 54)
			Me.rcMain.StatusBar = Me.rsbMain
			' 
			' bbiAbout
			' 
			Me.bbiAbout.Caption = "About"
			Me.bbiAbout.Hint = "About this Demo"
			Me.bbiAbout.Id = 0
			Me.bbiAbout.Name = "bbiAbout"
'			Me.bbiAbout.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbiAbout_ItemClick);
			' 
			' bsUser
			' 
			Me.bsUser.Id = 1
			Me.bsUser.Name = "bsUser"
			Me.bsUser.TextAlignment = System.Drawing.StringAlignment.Near
			' 
			' bsData
			' 
			Me.bsData.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring
			Me.bsData.Id = 2
			Me.bsData.LeftIndent = 4
			Me.bsData.Name = "bsData"
			Me.bsData.TextAlignment = System.Drawing.StringAlignment.Near
			' 
			' rsbMain
			' 
			Me.rsbMain.ItemLinks.Add(Me.bsUser)
			Me.rsbMain.ItemLinks.Add(Me.bsData)
			Me.rsbMain.Location = New System.Drawing.Point(0, 667)
			Me.rsbMain.Name = "rsbMain"
			Me.rsbMain.Ribbon = Me.rcMain
			Me.rsbMain.Size = New System.Drawing.Size(1076, 23)
			' 
			' nbMain
			' 
			Me.nbMain.ActiveGroup = Nothing
            Me.nbMain.LinkSelectionMode = DevExpress.XtraNavBar.LinkSelectionModeType.OneInControl
			Me.nbMain.Dock = System.Windows.Forms.DockStyle.Left
			Me.nbMain.Location = New System.Drawing.Point(6, 6)
			Me.nbMain.Name = "nbMain"
			Me.nbMain.OptionsNavPane.ExpandedWidth = 186
			Me.nbMain.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
			Me.nbMain.Size = New System.Drawing.Size(158, 601)
			Me.nbMain.TabIndex = 2
			Me.nbMain.Text = "navBarControl1"
'			Me.nbMain.Resize += New System.EventHandler(Me.nbMain_Resize);
			' 
			' pnlControl
			' 
			Me.pnlControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pnlControl.Location = New System.Drawing.Point(180, 54)
			Me.pnlControl.Name = "pnlControl"
			Me.pnlControl.Size = New System.Drawing.Size(896, 613)
			Me.pnlControl.TabIndex = 4
			' 
			' pnlMainContainer
			' 
			Me.pnlMainContainer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pnlMainContainer.Controls.Add(Me.nbMain)
			Me.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Left
			Me.pnlMainContainer.Location = New System.Drawing.Point(0, 54)
			Me.pnlMainContainer.Name = "pnlMainContainer"
			Me.pnlMainContainer.Padding = New System.Windows.Forms.Padding(6, 6, 0, 6)
			Me.pnlMainContainer.Size = New System.Drawing.Size(180, 613)
			Me.pnlMainContainer.TabIndex = 7
			' 
			' frmMainBase
			' 
			Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1076, 690)
			Me.Controls.Add(Me.pnlControl)
			Me.Controls.Add(Me.pnlMainContainer)
			Me.Controls.Add(Me.rsbMain)
			Me.Controls.Add(Me.rcMain)
			Me.KeyPreview = True
			Me.Name = "frmMainBase"
			Me.Ribbon = Me.rcMain
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.StatusBar = Me.rsbMain
			Me.Text = "Form1"
			CType(Me.rcMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nbMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pnlControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pnlMainContainer, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlMainContainer.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

        Private WithEvents rsbMain As DevExpress.XtraBars.Ribbon.RibbonStatusBar
		Private WithEvents nbMain As DevExpress.XtraNavBar.NavBarControl
        Private WithEvents bsUser As DevExpress.XtraBars.BarStaticItem
        Private WithEvents bsData As DevExpress.XtraBars.BarStaticItem
        Protected WithEvents rcMain As DevExpress.XtraBars.Ribbon.RibbonControl
        Private WithEvents pnlMainContainer As DevExpress.XtraEditors.PanelControl
		Protected WithEvents bbiAbout As DevExpress.XtraBars.BarButtonItem
        Protected WithEvents pnlControl As DevExpress.XtraEditors.PanelControl
	End Class
End Namespace

