Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Frames
Imports DevExpress.LookAndFeel
Imports DevExpress.Xpo
Imports DevExpress.XtraBars
Imports DevExpress.VideoRent.Win.Forms
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraPrinting.Preview
Imports System.Collections.Generic

Namespace DevExpress.VideoRent.Win
	Partial Public Class frmMain
		Inherits frmMainBase
		Implements IFormWithLayoutManager
        Private flayoutManager As FormLayoutManager = Nothing
        Private fribbonMenuController As RibbonMenuController = Nothing
		Private dataSession As UnitOfWork = Nothing
        Private fchartAppearanceManager As ChartAppearanceManager = Nothing
        Private fprogress As frmProgress = Nothing

#Region "printing"
        Private previewLinks As New List(Of BarItemLink)()
        Private links As New List(Of BarItemLink)()
        Private fprintRibbonController As New PrintRibbonController()
        Private designerButton As BarButtonItem
        Private fpreviewPage As PrintPreviewRibbonPage

        Private ReadOnly Property PreviewPage() As PrintPreviewRibbonPage
            Get
                If Object.Equals(fpreviewPage, Nothing) Then
                    For Each page As PrintPreviewRibbonPage In fprintRibbonController.PreviewRibbonPages
                        fpreviewPage = page
                        Exit For
                    Next page
                End If
                Return fpreviewPage
            End Get
        End Property
        Public Sub SubscribeOnDesignerButtonClick(ByVal handler As ItemClickEventHandler)
            AddHandler designerButton.ItemClick, handler
        End Sub
        Public ReadOnly Property PrintRibbonController() As PrintRibbonController
            Get
                Return fprintRibbonController
            End Get
        End Property
        Private Sub InitPrintRibbonController()
            For Each link As BarItemLink In Me.StatusBar.ItemLinks
                links.Add(link)
            Next link
            fprintRibbonController.Initialize(Me.RibbonControl, Me.StatusBar)
            For Each link As BarItemLink In Me.StatusBar.ItemLinks
                If (Not links.Contains(link)) Then
                    previewLinks.Add(link)
                End If
            Next link
            InitPreviewPage(PreviewPage)
            HidePreviewPage()
        End Sub
        Private Sub InitPreviewPage(ByVal page As PrintPreviewRibbonPage)
            If (Not Object.Equals(page, Nothing)) Then
                designerButton = CreateDesignerButton()
                designerButton.Manager = Me.RibbonControl.Manager
                page.Groups(PrintPreviewRibbonPageGroupKind.Document.ToString()).ItemLinks.Add(designerButton)
                page.Text = ConstStrings.DefaultPageName
                page.Groups(PrintPreviewRibbonPageGroupKind.PageSetup.ToString()).Visible = False
            End If
        End Sub
        Public Sub ShowPreviewPage()
            SetVisibility(links, False)
            SetVisibility(previewLinks, True)
            If (Not Object.Equals(PreviewPage, Nothing)) Then
                PreviewPage.Visible = True
                SetPageIndex(Me.RibbonControl, PreviewPage, 0)
                Me.RibbonControl.SelectedPage = PreviewPage
            End If
        End Sub
        Private Shared Sub SetPageIndex(ByVal ribbonControl As RibbonControl, ByVal page As RibbonPage, ByVal index As Integer)
            Dim currentIndex As Integer = ribbonControl.Pages.IndexOf(page)
            If currentIndex <> index Then
                ribbonControl.Pages.RemoveAt(currentIndex)
                ribbonControl.Pages.Insert(index, page)
                ribbonControl.SelectedPage = page
            End If
        End Sub
        Public Sub HidePreviewPage()
            SetVisibility(links, True)
            SetVisibility(previewLinks, False)
            If (Not Object.Equals(PreviewPage, Nothing)) Then
                PreviewPage.Visible = False
            End If
        End Sub
        Private Shared Sub SetVisibility(ByVal links As List(Of BarItemLink), ByVal value As Boolean)
            For Each link As BarItemLink In links
                link.Visible = value
            Next link
        End Sub
        Private Shared Function CreateDesignerButton() As BarButtonItem
            Dim buttonItem As New BarButtonItem()
            buttonItem.Caption = ConstStrings.ShowReportDesigner
            buttonItem.Hint = ConstStrings.ShowReportDesigner
            buttonItem.Visibility = BarItemVisibility.OnlyInRuntime
            buttonItem.ImageOptions.Image = ResourceImageHelper.CreateImageFromResources("Action_Report_ShowDesigner.png", GetType(DevExpress.VideoRent.Resources.ImagesHelper).Assembly)
            buttonItem.ImageOptions.LargeImage = ResourceImageHelper.CreateImageFromResources("Action_Report_ShowDesigner_32x32.png", GetType(DevExpress.VideoRent.Resources.ImagesHelper).Assembly)
            buttonItem.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.VideoRent.Resources.ImagesHelper)
            buttonItem.ImageOptions.ImageUri.Uri = "resource://Designer.svg"

            Return buttonItem
        End Function
#End Region

        Public Sub New()
            InitializeComponent()
            InitStyles()
            Me.ClientSize = New System.Drawing.Size(1170, 890)
            ToolTipController.DefaultController.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip
            fribbonMenuController = New RibbonMenuController(Me)
            AddHandler UserLookAndFeel.Default.StyleChanged, AddressOf Default_StyleChanged
            AddHandler (CType(UserLookAndFeel.Default, DevExpress.LookAndFeel.Design.UserLookAndFeelDefault)).StyleChangeProgress, AddressOf frmMain_StyleChangeProgress
            Me.Icon = ElementHelper.AppIcon
            InitPrintRibbonController()
        End Sub
        Private ReadOnly Property Progress() As frmProgress
            Get
                If Object.Equals(fprogress, Nothing) Then
                    fprogress = New frmProgress(Me)
                End If
                Return fprogress
            End Get
        End Property
        Private Sub frmMain_StyleChangeProgress(ByVal sender As Object, ByVal e As LookAndFeelProgressEventArgs)
            If e.State = 0 Then
#If DebugTest Then
				System.Diagnostics.Debug.WriteLine(String.Format("Look and Feel objects count = {0}", e.Progress))
#End If
                Progress.ShowProgress(e.Progress)
                SuspendLayout()
            End If
            If e.State = 1 Then
                Progress.Progress(e.Progress)
            End If
            If e.State = 2 Then
                Progress.HideProgress()
                ResumeLayout()
            End If
        End Sub
        Public ReadOnly Property RibbonMenuController() As RibbonMenuController
            Get
                Return fribbonMenuController
            End Get
        End Property
        Public ReadOnly Property ChartAppearanceManager() As ChartAppearanceManager
            Get
                Return fchartAppearanceManager
            End Get
        End Property
        Protected Overrides ReadOnly Property DemoName() As String
            Get
                Return ConstStrings.DemoName
            End Get
        End Property
        Protected Overrides Sub nbMain_CustomDrawGroupCaption(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.ViewInfo.CustomDrawNavBarElementEventArgs)
            If ConstStrings.AdminGroup.Equals(e.Caption) Then
                e.Appearance.Font = ElementHelper.FontItalic
            End If
            If NavigationBar.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed Then
                Return
            End If
            Dim info As NavGroupInfoArgs = TryCast(e.ObjectInfo, NavGroupInfoArgs)
            Dim dx As Integer = 7
            If Object.Equals(info, Nothing) Then
                Return
            End If
            e.Image = Nothing
            info.CaptionBounds = New Rectangle(info.CaptionClientBounds.X + dx, info.CaptionClientBounds.Y, info.CaptionClientBounds.Width - dx * 2, info.CaptionClientBounds.Height)
        End Sub
        Private Sub Default_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            InitStyles()
        End Sub
        Private Sub InitStyles()
            ColorHelper.UpdateColor(ElementHelper.ColumnHeaderIcons, UserLookAndFeel.Default)
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            InitDataManagement()
            LayoutManager.Properties.LoadDefaultSkin()
            LayoutManager.Properties.LoadChartPaletteAppearance(ChartAppearanceManager)
            SkinHelper.InitSkinGallery(rgbiSkins, True)
        End Sub
        Private Sub InitDataManagement()
            dataSession = New UnitOfWork(DevExpress.Xpo.Session.DefaultSession.DataLayer)
            flayoutManager = New FormLayoutManager(DevExpress.Xpo.Session.DefaultSession, AddressOf SetDataInfo, dataSession)
            LayoutManager.RestoreFormLayout(New FormLayoutInfo(Me, Nothing, rcMain.Toolbar))
            SetUserInfo(VideoRentCurrentUser.GetCurrentUser(dataSession).Login)
            LayoutManager.SetDefaultCurrentCustomer(dataSession)
            NavigationBar.OptionsNavPane.NavPaneState = LayoutManager.Properties.CurrentProperty.NavPaneState
        End Sub
        Public ReadOnly Property LayoutManager() As FormLayoutManager Implements IFormWithLayoutManager.LayoutManager
            Get
                Return flayoutManager
            End Get
        End Property
        Protected Overrides Sub RegisterTutorials()
            DevExpress.VideoRent.Win.RegisterTutorials.Register()
        End Sub
        Protected Overrides Sub ShowModule(ByVal name As String, ByVal parent As PanelControl)
            If Object.Equals(dataSession, Nothing) Then
                DemosInfo.ShowModule(Me, name, parent, Nothing)
            Else
                DemosInfo.ShowModule(Me, name, parent, New UnitOfWork(dataSession.DataLayer))
            End If
        End Sub
        Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
            MyBase.OnClosing(e)
            Dim control As TutorialControl = TryCast(DemosInfo.CurrentModule, TutorialControl)
            If (Not Object.Equals(control, Nothing)) Then
                control.ForceHide()
            End If
            LayoutManager.SaveFormLayout(New FormLayoutInfo(Me, Nothing, rcMain.Toolbar))
            LayoutManager.Properties.SaveDefaultProperties(LayoutManager, NavigationBar.OptionsNavPane.NavPaneState, ChartAppearanceManager)
        End Sub
        Private Sub BBColorMix_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBColorMix.ItemClick
            Dim form As New DevExpress.XtraEditors.ColorWheel.ColorWheelForm
            form.StartPosition = FormStartPosition.CenterParent
            form.SkinMaskColor = UserLookAndFeel.Default.SkinMaskColor
            form.SkinMaskColor2 = UserLookAndFeel.Default.SkinMaskColor2
            form.ShowDialog(Me)
        End Sub
#Region "Ribbon"
        Protected Overrides Sub InitMenu()
            SetBarGroupImages()
            SetMenuItemImages()
            SetActionDescriptions()
            RibbonViewMenu.CreateNavigationMenu(bsiModules, NavigationBar, TryCast(MenuManager, BarManager))
            SkinHelper.InitSkinPopupMenu(pmAppearance)
            SkinHelper.InitSkinGalleryDropDown(gddSkins)
            pmAppearance.ItemLinks(1).BeginGroup = True
            fchartAppearanceManager = New ChartAppearanceManager(gddChartPalette, rgbiChartAppearance, bbiChartPalette)
            AddHandler fchartAppearanceManager.StyleChanged, AddressOf chartAppearanceManager_StyleChanged
            sbExit.Image = ElementHelper.GetImage("Delete", ImageSize.Small16)
            appMenu.ItemLinks.Add(bbiAbout, True)
        End Sub

        Private Sub SetActionDescriptions()
            ExportButton.Description = ConstStrings.ExportDescription
            PrintPreviewButton.Description = ConstStrings.PrintPreviewDescription
            LayoutOptionsButton.Description = ConstStrings.LayoutOptionDescription
            PeriodButton.Description = ConstStrings.PeriodDescription
            bbiAbout.Description = ConstStrings.AboutDescription
            bbiSkins.Description = ConstStrings.ChooseSkinDescription
        End Sub

        Private Sub chartAppearanceManager_StyleChanged(ByVal sender As Object, ByVal e As ChartAppearanceEventArgs)
            ModulesInfo.CurrentModule.CheckChartStyles(ChartAppearanceManager)
        End Sub

        Private Sub SetBarGroupImages()
            NavigationBar.Groups(ConstStrings.RentalGroup).SmallImage = ElementHelper.GetGroupImage("Rental")
            NavigationBar.Groups(ConstStrings.CatalogGroup).SmallImage = ElementHelper.GetGroupImage("Catalog")
            NavigationBar.Groups(ConstStrings.KPIGroup).SmallImage = ElementHelper.GetGroupImage("KPI")
            NavigationBar.Groups(ConstStrings.StatisticsGroup).SmallImage = ElementHelper.GetGroupImage("Statistics")
            NavigationBar.Groups(ConstStrings.ReportsGroup).SmallImage = ElementHelper.GetGroupImage("Reports")
            If NavigationBar.Groups(ConstStrings.AdminGroup) IsNot Nothing Then
                NavigationBar.Groups(ConstStrings.AdminGroup).SmallImage = ElementHelper.GetGroupImage("Administrator")
            End If
        End Sub

        Private Sub SetMenuItemImages()
            RibbonMenuController.SetBarButtonImage(bsiModules, "Navigation")
        End Sub
        Private Sub rpgAppearance_CaptionButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs) Handles rpgAppearance.CaptionButtonClick
            pmAppearance.ShowPopup(MousePosition)
        End Sub
        Private Sub pmAppearance_Popup(ByVal sender As Object, ByVal e As EventArgs) Handles pmAppearance.Popup
            bciFormSkin.Checked = Skins.SkinManager.AllowFormSkins
        End Sub
        Private Sub bciFormSkin_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles bciFormSkin.ItemClick
            If Skins.SkinManager.AllowFormSkins Then
                Me.AllowFormGlass = DefaultBoolean.True
            Else
                Me.AllowFormGlass = DefaultBoolean.False
            End If
            If Skins.SkinManager.AllowFormSkins Then
                Skins.SkinManager.DisableFormSkins()
            Else
                Skins.SkinManager.EnableFormSkins()
            End If
        End Sub
        Private Sub bbiLayoutOptions_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles bbiLayoutOptions.ItemClick
            Using form As New frmLayoutOptions(LayoutManager)
                form.ShowDialog(Me)
            End Using
        End Sub
        Private Sub bbiPeriod_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles bbiPeriod.ItemClick
            ShowPeriod(PeriodType.All)
        End Sub
        Private Sub bbiReceiptPeriod_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles bbiReceiptPeriod.ItemClick
            ShowPeriod(PeriodType.Receipt)
        End Sub
        Private Sub ShowPeriod(ByVal type As PeriodType)
            Using form As New frmPeriod(type)
                If form.ShowDialog(Me) = DialogResult.OK AndAlso ((Not Object.Equals(ModulesInfo.CurrentModule, Nothing))) Then
                    CType(ModulesInfo.CurrentModule, TutorialControl).RefreshData()
                End If
            End Using
        End Sub
        Private Sub rcMain_ShowCustomizationMenu(ByVal sender As Object, ByVal e As RibbonCustomizationMenuEventArgs) Handles rcMain.ShowCustomizationMenu
            e.CustomizationMenu.InitializeMenu()
            If Object.Equals(e.Link, Nothing) OrElse (Not "AllowQuickAccess".Equals(e.Link.Item.Tag)) Then
                e.CustomizationMenu.RemoveLink(e.CustomizationMenu.ItemLinks(0))
            End If
        End Sub
        Friend ReadOnly Property AddButton() As BarButtonItem
            Get
                Return bbiAdd
            End Get
        End Property
        Friend ReadOnly Property EditButton() As BarButtonItem
            Get
                Return bbiEdit
            End Get
        End Property
        Friend ReadOnly Property DeleteButton() As BarButtonItem
            Get
                Return bbiDelete
            End Get
        End Property
        Friend ReadOnly Property PrevButton() As BarButtonItem
            Get
                Return bbiPrev
            End Get
        End Property
        Friend ReadOnly Property NextButton() As BarButtonItem
            Get
                Return bbiNext
            End Get
        End Property
        Friend ReadOnly Property OptionsButton() As BarButtonItem
            Get
                Return bbiOptions
            End Get
        End Property
        Friend ReadOnly Property CurrentCustomerButton() As BarButtonItem
            Get
                Return bbiCurrentCustomer
            End Get
        End Property
        Friend ReadOnly Property RentButton() As BarButtonItem
            Get
                Return bbiRent
            End Get
        End Property
        Friend ReadOnly Property ReturnButton() As BarButtonItem
            Get
                Return bbiReturn
            End Get
        End Property
        Friend ReadOnly Property ActiveRentButton() As BarButtonItem
            Get
                Return bbiActiveRent
            End Get
        End Property
        Friend ReadOnly Property ChangeCustomerButton() As BarButtonItem
            Get
                Return bbiChangeCustomer
            End Get
        End Property
        Friend ReadOnly Property SaveButton() As BarButtonItem
            Get
                Return bbiSave
            End Get
        End Property
        Friend ReadOnly Property SaveAndCloseButton() As BarButtonItem
            Get
                Return bbiSaveAndClose
            End Get
        End Property
        Friend ReadOnly Property CloseButton() As BarButtonItem
            Get
                Return bbiClose
            End Get
        End Property
        Friend ReadOnly Property LoadPictureButton() As BarButtonItem
            Get
                Return bbiLoadPicture
            End Get
        End Property
        Friend ReadOnly Property ClearPictureButton() As BarButtonItem
            Get
                Return bbiClearPicture
            End Get
        End Property
        Friend ReadOnly Property MovieAddItemButton() As BarButtonItem
            Get
                Return bbiAddItems
            End Get
        End Property
        Friend ReadOnly Property MovieManageItemsButton() As BarButtonItem
            Get
                Return bbiManageItems
            End Get
        End Property
        Friend ReadOnly Property AddPictureButton() As BarButtonItem
            Get
                Return bbiAddPicture
            End Get
        End Property
        Friend ReadOnly Property DeletePictureButton() As BarButtonItem
            Get
                Return bbiDeletePicture
            End Get
        End Property
        Friend ReadOnly Property LayoutOptionsButton() As BarButtonItem
            Get
                Return bbiLayoutOptions
            End Get
        End Property
        Friend ReadOnly Property ViewStylesMenu() As BarSubItem
            Get
                Return bsiViews
            End Get
        End Property
        Friend ReadOnly Property MainViewButton() As BarButtonItem
            Get
                Return bbiMainView
            End Get
        End Property
        Friend ReadOnly Property AlternateViewButton() As BarButtonItem
            Get
                Return bbiAlternateView
            End Get
        End Property
        Friend ReadOnly Property CloseDetailsButton() As BarButtonItem
            Get
                Return bbiCloseDetails
            End Get
        End Property
        Friend ReadOnly Property ChartPaletteButton() As BarButtonItem
            Get
                Return bbiChartPalette
            End Get
        End Property
        Friend ReadOnly Property MovieCategoriesButton() As BarButtonItem
            Get
                Return bbiMovieCategories
            End Get
        End Property
        Friend ReadOnly Property RefreshButton() As BarButtonItem
            Get
                Return bbiRefresh
            End Get
        End Property
        Friend ReadOnly Property HomeButton() As BarButtonItem
            Get
                Return bbiHome
            End Get
        End Property
        Friend ReadOnly Property PrintPreviewButton() As BarButtonItem
            Get
                Return bbiPrintPreview
            End Get
        End Property
        Friend ReadOnly Property ExportButton() As BarButtonItem
            Get
                Return bbiExport
            End Get
        End Property
        Friend ReadOnly Property ExportToPDFButton() As BarButtonItem
            Get
                Return bbiExportToPDF
            End Get
        End Property
        Friend ReadOnly Property ExportToXMLButton() As BarButtonItem
            Get
                Return bbiExportToXML
            End Get
        End Property
        Friend ReadOnly Property ExportToHTMLButton() As BarButtonItem
            Get
                Return bbiExportToHTML
            End Get
        End Property
        Friend ReadOnly Property ExportToMHTButton() As BarButtonItem
            Get
                Return bbiExportToMHT
            End Get
        End Property
        Friend ReadOnly Property ExportToXLSButton() As BarButtonItem
            Get
                Return bbiExportToXLS
            End Get
        End Property
        Friend ReadOnly Property ExportToXLSXButton() As BarButtonItem
            Get
                Return bbiExportToXLSX
            End Get
        End Property
        Friend ReadOnly Property ExportToRTFButton() As BarButtonItem
            Get
                Return bbiExportToRTF
            End Get
        End Property
        Friend ReadOnly Property ExportToImageButton() As BarButtonItem
            Get
                Return bbiExportToImage
            End Get
        End Property
        Friend ReadOnly Property ExportToTextButton() As BarButtonItem
            Get
                Return bbiExportToText
            End Get
        End Property
        Friend ReadOnly Property RotateLayoutButton() As BarButtonItem
            Get
                Return bbiLayoutRotate
            End Get
        End Property
        Friend ReadOnly Property FlipLayoutButton() As BarButtonItem
            Get
                Return bbiLayoutFlip
            End Get
        End Property
        Friend ReadOnly Property PeriodButton() As BarButtonItem
            Get
                Return bbiPeriod
            End Get
        End Property
        Friend ReadOnly Property ReceiptPeriodButton() As BarButtonItem
            Get
                Return bbiReceiptPeriod
            End Get
        End Property
#End Region

		Private Sub sbExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbExit.Click
			Close()
        End Sub
        Friend Sub UpdateSchedulerRibbonController(ByVal schedulerControl As DevExpress.XtraScheduler.SchedulerControl)
            Me.schedulerBarController1.Control = schedulerControl
        End Sub
	End Class
End Namespace
