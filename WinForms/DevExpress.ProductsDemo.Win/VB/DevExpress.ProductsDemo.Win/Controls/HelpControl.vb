Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.Utils.About

Namespace DevExpress.ProductsDemo.Win.Controls
	Partial Public Class HelpControl
		Inherits RibbonApplicationUserControl

		Private aboutPanel As Form
		Private isLoaded As Boolean
        Public Sub New()
            InitializeComponent()
            AddHandler Me.Load, AddressOf HelpControl_Load
        End Sub

        Private Sub HelpControl_Load(ByVal sender As Object, ByVal e As EventArgs)
			If isLoaded Then
				Return
			End If
            aboutPanel = New AboutForm12(New ProductInfo(ProductKind.DXperienceWin))
            aboutPanel.TopLevel = False
			aboutPanel.Parent = splitContainer1.Panel2
			ResizeAbout()
			aboutPanel.Show()
			AddHandler splitContainer1.Panel2.Resize, AddressOf Panel2_Resize
			ResizeAbout()
			isLoaded = True
		End Sub

		Private Sub Panel2_Resize(ByVal sender As Object, ByVal e As EventArgs)
			ResizeAbout()
		End Sub
		Private Sub ResizeAbout()
			Dim pnl As Panel = TryCast(aboutPanel.Parent, Panel)
			aboutPanel.Location = New Point((pnl.Width - aboutPanel.Width) \ 2, (pnl.Height - aboutPanel.Height) \ 2)
		End Sub
		Private Sub galleryControlGallery1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs) Handles galleryControl1.Gallery.ItemClick
			Dim link As String = String.Format("{0}", e.Item.Tag)
			Select Case link
				Case "LinkHelp"
					link = AssemblyInfo.DXLinkHelp
				Case "LinkGetSupport"
					link = AssemblyInfo.DXLinkGetSupport
				Case "LinkGetStarted"
					link = AssemblyInfo.DXLinkGetStartedWinGrid
			End Select
			If Not String.IsNullOrEmpty(link) Then
				ObjectHelper.StartProcess(link)
			End If
		End Sub
	End Class
End Namespace
