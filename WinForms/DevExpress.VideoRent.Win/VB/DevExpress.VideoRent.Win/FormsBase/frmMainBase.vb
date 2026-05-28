Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Ribbon
Imports System.Runtime.InteropServices
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraNavBar
Imports DevExpress.Utils.Menu

Namespace DevExpress.VideoRent.Win
	Partial Public Class frmMainBase
		Inherits RibbonForm
		<DllImport("kernel32.dll")> _
		Public Shared Function SetProcessWorkingSetSize(ByVal handle As IntPtr, ByVal minimumWorkingSetSize As Integer, ByVal maximumWorkingSetSize As Integer) As Boolean
		End Function
		Public Sub New()
			InitializeComponent()
			AddHandler nbMain.SelectedLinkChanged, AddressOf nbMain_SelectedLinkChanged
			AddHandler nbMain.CustomDrawGroupCaption, AddressOf nbMain_CustomDrawGroupCaption
			AddHandler nbMain.LinkClicked, AddressOf nbMain_LinkClicked
			nbMain.MenuManager = rcMain.Manager
			InitRibbonElementsImages()
		End Sub
		Public ReadOnly Property MainContainer() As PanelControl
			Get
				Return pnlMainContainer
			End Get
		End Property
		Private Sub InitRibbonElementsImages()
			bbiAbout.LargeGlyph = ElementHelper.GetImage("Info", ImageSize.Large32)
			bbiAbout.Glyph = ElementHelper.GetImage("Info", ImageSize.Small16)
		End Sub
		Public ReadOnly Property ChildContainer() As PanelControl
			Get
				Return pnlControl
			End Get
		End Property
		Public ReadOnly Property MenuManager() As IDXMenuManager
			Get
				Return rcMain.Manager
			End Get
		End Property
		Public ReadOnly Property RibbonControl() As RibbonControl
			Get
				Return rcMain
			End Get
		End Property
		Public ReadOnly Property NavigationBar() As NavBarControl
			Get
				Return nbMain
			End Get
		End Property
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			RegisterTutorials()
			FillNavBar()
			Dim info As ModuleInfo = ModulesInfo.GetItem(0)
			If Object.Equals(info, Nothing) Then
				Return
			End If
			ShowModule(info.Name)
		End Sub
		Protected Friend ReadOnly Property MainStatusBar() As RibbonStatusBar
			Get
				Return rsbMain
			End Get
		End Property
		Protected Overridable ReadOnly Property DemoName() As String
			Get
				Return "BaseForm"
			End Get
		End Property
		Protected Overridable Sub RegisterTutorials()
		End Sub
		Protected Overridable Sub FillNavBar()
			ModulesInfo.FillNavBar(nbMain)
			InitMenu()
		End Sub
		Protected Overridable Sub InitMenu()
		End Sub
		Private prevModuleName As String = String.Empty
		Public Sub ShowModule(ByVal name As String)
			If (Not Object.Equals(ModulesInfo.Instance.CurrentModuleBase, Nothing)) Then
				prevModuleName = ModulesInfo.Instance.CurrentModuleBase.Name
			End If
			pnlControl.Parent.SuspendLayout()
			pnlControl.SuspendLayout()
			ShowModule(name, pnlControl)
			Me.StatusBar.Visible = Not Object.Equals(name, ConstStrings.AboutGroup)
			Dim currentModule As TutorialControlBase = TryCast(ModulesInfo.Instance.CurrentModuleBase.TModule, TutorialControlBase)
			Try
				If Object.Equals(currentModule, Nothing) Then
					Return
				End If
				Text = String.Format("{0} - {1}", ElementHelper.GetSingleLineString(name), DemoName)
			Finally
				pnlControl.ResumeLayout()
				pnlControl.Parent.ResumeLayout()
				currentModule.Invalidate()
				SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1)
			End Try
		End Sub
		Protected Overridable Sub ShowModule(ByVal name As String, ByVal parent As PanelControl)
		End Sub
		Private prevLink As NavBarItemLink = Nothing
		Private Sub nbMain_SelectedLinkChanged(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.ViewInfo.NavBarSelectedLinkChangedEventArgs)
			If Object.Equals(e.Link, Nothing) Then
				Return
			End If
			ShowModule(e.Link.Caption)
			prevLink = e.Link
		End Sub
		Private Sub nbMain_LinkClicked(ByVal sender As Object, ByVal e As NavBarLinkEventArgs)
			If Object.Equals(ModulesInfo.CurrentModule, Nothing) OrElse Object.Equals(e.Link, Nothing) Then
				Return
			End If
			Dim info As ModuleInfo = TryCast(e.Link.Item.Tag, ModuleInfo)
			If Object.Equals(info, Nothing) Then
				Return
			End If
			If ModulesInfo.CurrentModule.Name = info.TypeName Then
				ModulesInfo.CurrentModule.ShowMasterModule()
			End If
		End Sub
		Public Sub ResetNavbarSelectedLink()
			nbMain.SelectedLink = Nothing
		End Sub
		Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
			MyBase.OnKeyDown(e)
			If prevModuleName = String.Empty Then
				Return
			End If
			Dim isAbout As Boolean = ModulesInfo.Instance.CurrentModuleBase.Name = ModulesInfo.GetItem(0).Name
			If e.KeyData = Keys.F1 AndAlso (Not isAbout) Then
				ShowModule(ModulesInfo.GetItem(0).Name)
				ResetNavbarSelectedLink()
			End If
			If e.KeyData = Keys.Escape AndAlso isAbout Then
				ShowModule(prevModuleName)
				If (Not Object.Equals(prevLink, Nothing)) Then
					nbMain.SelectedLink = prevLink
				End If
			End If
		End Sub
		Protected Overridable Sub nbMain_CustomDrawGroupCaption(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.ViewInfo.CustomDrawNavBarElementEventArgs)
		End Sub
		Public Sub SetUserInfo(ByVal caption As String)
			bsUser.Caption = caption
		End Sub
		Public Sub SetDataInfo(ByVal caption As String)
			bsData.Caption = caption
		End Sub

		Private Sub nbMain_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles nbMain.Resize
			pnlMainContainer.Width = (CType(sender, Control)).Width + pnlMainContainer.Padding.Left
		End Sub

		Private Sub bbiAbout_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAbout.ItemClick
			frmAbout.ShowAbout(Me)
		End Sub
	End Class
End Namespace
