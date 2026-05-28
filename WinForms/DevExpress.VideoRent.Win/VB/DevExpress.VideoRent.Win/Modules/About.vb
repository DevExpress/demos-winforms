Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms

Namespace DevExpress.VideoRent.Win.Modules
	Partial Public Class About
		Inherits TutorialControl
		Public Sub New()
			InitializeComponent()
			lcAbout1.Text = ConstStrings.WelcomeText1
			lcAbout2.Text = ConstStrings.WelcomeText2
			lcLink1.Text = ConstStrings.WelcomeLink1
			lcLink1.Appearance.Image = ElementHelper.GetAboutPageImage("Learn-More")
			lcLink1.LinkText = ConstStrings.DXLink
			lcLink2.Text = ConstStrings.WelcomeLink2
			lcLink2.Appearance.Image = ElementHelper.GetAboutPageImage("Download")
			lcLink2.LinkText = ConstStrings.TrialsLink
			lcLink3.Text = ConstStrings.WelcomeLink3
			lcLink3.Appearance.Image = ElementHelper.GetAboutPageImage("Buy")
			lcLink3.LinkText = ConstStrings.PurchaseLink
			lcControlsText.Text = ConstStrings.WelcomeText3
			ucControlAbout1.Init("XtraGrid", DemoProducts.Grid, ElementHelper.GetAboutPageImage("Grid"))
			ucControlAbout2.Init("XtraReports", DemoProducts.Reports, ElementHelper.GetAboutPageImage("Reports"))
			ucControlAbout3.Init("XtraCharts", DemoProducts.Charts, ElementHelper.GetAboutPageImage("Charts"))
			ucControlAbout4.Init("XtraPivotGrid", DemoProducts.Pivot, ElementHelper.GetAboutPageImage("PivotGrid"))
			ucControlAbout5.Init("XtraScheduler", DemoProducts.Scheduler, ElementHelper.GetAboutPageImage("Scheduler"))
			lcHint.Text = ConstStrings.WelcomeText4

			esiCaption.Width = Width
		End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			For Each ctrl As Control In lcAbout.Controls
				If TypeOf ctrl Is HotLabel Then
					CType(ctrl, HotLabel).UpdateColors()
				End If
				ctrl.Font = New Font("Segoe UI", ctrl.Font.Size, ctrl.Font.Style)
			Next ctrl
		End Sub
	End Class
End Namespace
