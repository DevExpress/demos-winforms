Imports DevExpress.XtraEditors

Namespace DevExpress.RealtorWorld.Win

    Partial Class frmMain

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim tileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
            Dim tileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
            Dim tileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
            Dim tileItemElement4 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
            Dim tileItemElement5 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
            Dim tileItemElement6 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
            Dim tileItemElement7 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
            Dim tileItemElement8 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
            Dim tileItemElement9 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
            Dim windowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.RealtorWorld.Win.frmMain))
            Me.documentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            Me.windowsUIView = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(Me.components)
            Me.startGroup = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer(Me.components)
            Me.pageGroup = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup(Me.components)
            Me.ucListingDocument = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
            Me.ucAgentsDocument = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
            Me.ucStatsDocument = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
            Me.ucResearchDocument = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
            Me.ucBanksDocument = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
            Me.ucLoanCalculatorDocument = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
            Me.ucListingTile = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
            Me.ucDraftTile = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
            Me.page = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page(Me.components)
            Me.ucDraftDocument = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
            Me.ucSettingsTile = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
            Me.ucSettingsDocument = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
            Me.ucAgentsTile = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
            Me.ucResearchTile = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
            Me.ucStatsTile = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
            Me.ucBrowserTile = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
            Me.browserPage = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page(Me.components)
            Me.ucBrowserDocument = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
            Me.ucBanksTile = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
            Me.ucLoanCalculatorTile = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
            Me.flyout = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout(Me.components)
            Me.ucFlyout = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
            Me.ucHomeDetailDocument = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
            Me.ucStatisticsDocument = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
            Me.ucSysInfoDocument = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.windowsUIButtonPanel1 = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
            CType((Me.documentManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.windowsUIView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.startGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pageGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ucListingDocument), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ucAgentsDocument), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ucStatsDocument), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ucResearchDocument), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ucBanksDocument), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ucLoanCalculatorDocument), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ucListingTile), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ucDraftTile), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.page), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ucDraftDocument), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ucSettingsTile), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ucSettingsDocument), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ucAgentsTile), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ucResearchTile), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ucStatsTile), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ucBrowserTile), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.browserPage), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ucBrowserDocument), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ucBanksTile), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ucLoanCalculatorTile), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.flyout), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ucFlyout), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ucHomeDetailDocument), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ucStatisticsDocument), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ucSysInfoDocument), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' documentManager1
            ' 
            Me.documentManager1.ContainerControl = Me
            Me.documentManager1.View = Me.windowsUIView
            Me.documentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.windowsUIView})
            ' 
            ' windowsUIView
            ' 
            Me.windowsUIView.Caption = "Realtor World"
            Me.windowsUIView.ContentContainers.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer() {Me.startGroup, Me.pageGroup, Me.page, Me.browserPage, Me.flyout})
            Me.windowsUIView.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.ucAgentsDocument, Me.ucBanksDocument, Me.ucBrowserDocument, Me.ucDraftDocument, Me.ucHomeDetailDocument, Me.ucListingDocument, Me.ucLoanCalculatorDocument, Me.ucResearchDocument, Me.ucStatisticsDocument, Me.ucStatsDocument, Me.ucSysInfoDocument, Me.ucSettingsDocument, Me.ucFlyout})
            Me.windowsUIView.LoadingIndicatorProperties.DescriptionFormat = "{0} loading..."
            Me.windowsUIView.TileProperties.AllowHtmlDraw = True
            Me.windowsUIView.Tiles.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile() {Me.ucAgentsTile, Me.ucBanksTile, Me.ucBrowserTile, Me.ucDraftTile, Me.ucListingTile, Me.ucLoanCalculatorTile, Me.ucResearchTile, Me.ucStatsTile, Me.ucSettingsTile})
            AddHandler Me.windowsUIView.TileClick, New DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileClickEventHandler(AddressOf Me.windowsUIView_TileClick)
            AddHandler Me.windowsUIView.QueryControl, New DevExpress.XtraBars.Docking2010.Views.QueryControlEventHandler(AddressOf Me.windowsUIView_QueryControl)
            ' 
            ' startGroup
            ' 
            Me.startGroup.ActivationTarget = Me.pageGroup
            Me.startGroup.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.startGroup.AppearanceItem.Normal.Options.UseFont = True
            Me.startGroup.Caption = "Realtor World"
            Me.startGroup.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile() {Me.ucListingTile, Me.ucDraftTile, Me.ucSettingsTile, Me.ucAgentsTile, Me.ucResearchTile, Me.ucStatsTile, Me.ucBrowserTile, Me.ucBanksTile, Me.ucLoanCalculatorTile})
            Me.startGroup.Name = "startGroup"
            Me.startGroup.Properties.ItemSize = 180
            Me.startGroup.Properties.RowCount = 3
            ' 
            ' pageGroup
            ' 
            Me.pageGroup.Caption = "Realtor World"
            Me.pageGroup.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document() {Me.ucListingDocument, Me.ucAgentsDocument, Me.ucStatsDocument, Me.ucResearchDocument, Me.ucBanksDocument, Me.ucLoanCalculatorDocument})
            Me.pageGroup.Name = "pageGroup"
            Me.pageGroup.Parent = Me.startGroup
            Me.pageGroup.Properties.Margin = New System.Windows.Forms.Padding(40, 0, 40, 20)
            ' 
            ' ucListingDocument
            ' 
            Me.ucListingDocument.Caption = "Listing"
            Me.ucListingDocument.ControlName = "ucListing"
            Me.ucListingDocument.ControlTypeName = "DevExpress.RealtorWorld.Win.ucListing"
            ' 
            ' ucAgentsDocument
            ' 
            Me.ucAgentsDocument.Caption = "Agents"
            Me.ucAgentsDocument.ControlName = "ucAgents"
            Me.ucAgentsDocument.ControlTypeName = "DevExpress.RealtorWorld.Win.ucAgents"
            ' 
            ' ucStatsDocument
            ' 
            Me.ucStatsDocument.Caption = "Stats"
            Me.ucStatsDocument.ControlName = "ucStats"
            Me.ucStatsDocument.ControlTypeName = "DevExpress.RealtorWorld.Win.ucStats"
            ' 
            ' ucResearchDocument
            ' 
            Me.ucResearchDocument.Caption = "Research"
            Me.ucResearchDocument.ControlName = "ucResearch"
            Me.ucResearchDocument.ControlTypeName = "DevExpress.RealtorWorld.Win.ucResearch"
            ' 
            ' ucBanksDocument
            ' 
            Me.ucBanksDocument.Caption = "Mortgage Rates"
            Me.ucBanksDocument.ControlName = "ucBanks"
            Me.ucBanksDocument.ControlTypeName = "DevExpress.RealtorWorld.Win.ucBanks"
            ' 
            ' ucLoanCalculatorDocument
            ' 
            Me.ucLoanCalculatorDocument.Caption = "Loan Calculator"
            Me.ucLoanCalculatorDocument.ControlName = "ucLoanCalculator"
            Me.ucLoanCalculatorDocument.ControlTypeName = "DevExpress.RealtorWorld.Win.ucLoanCalculator"
            ' 
            ' ucListingTile
            ' 
            Me.ucListingTile.Document = Me.ucListingDocument
            tileItemElement1.Text = "Listings"
            Me.ucListingTile.Elements.Add(tileItemElement1)
            Me.ucListingTile.Group = "Main"
            Me.ucListingTile.Name = "ucListingTile"
            Me.ucListingTile.Padding = New System.Windows.Forms.Padding(0)
            Me.ucListingTile.Properties.AllowCheck = DevExpress.Utils.DefaultBoolean.[False]
            Me.ucListingTile.Properties.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            Me.ucListingTile.Properties.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside
            ' 
            ' ucDraftTile
            ' 
            Me.ucDraftTile.ActivationTarget = Me.page
            Me.ucDraftTile.Appearances.Normal.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((171)))))), (CInt(((CByte((220)))))))
            Me.ucDraftTile.Appearances.Normal.BackColor2 = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((191)))))), (CInt(((CByte((227)))))))
            Me.ucDraftTile.Appearances.Normal.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((38)))))), (CInt(((CByte((184)))))), (CInt(((CByte((225)))))))
            Me.ucDraftTile.Appearances.Normal.Options.UseBackColor = True
            Me.ucDraftTile.Appearances.Normal.Options.UseBorderColor = True
            Me.ucDraftTile.Document = Me.ucDraftDocument
            tileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileItemElement2.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
            tileItemElement2.Text = "User Management"
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            Me.ucDraftTile.Elements.Add(tileItemElement2)
            Me.ucDraftTile.Group = "Main"
            Me.startGroup.SetID(Me.ucDraftTile, 1)
            Me.ucDraftTile.Name = "ucDraftTile"
            Me.ucDraftTile.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
            ' 
            ' page
            ' 
            Me.page.Document = Nothing
            Me.page.Name = "page"
            Me.page.Parent = Me.startGroup
            ' 
            ' ucDraftDocument
            ' 
            Me.ucDraftDocument.Caption = "Draft"
            Me.ucDraftDocument.ControlName = "ucDraft"
            Me.ucDraftDocument.ControlTypeName = "DevExpress.RealtorWorld.Win.ucDraft"
            ' 
            ' ucSettingsTile
            ' 
            Me.ucSettingsTile.ActivationTarget = Me.page
            Me.ucSettingsTile.Appearances.Normal.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((84)))))), (CInt(((CByte((175)))))), (CInt(((CByte((14)))))))
            Me.ucSettingsTile.Appearances.Normal.BackColor2 = System.Drawing.Color.FromArgb((CInt(((CByte((104)))))), (CInt(((CByte((194)))))), (CInt(((CByte((16)))))))
            Me.ucSettingsTile.Appearances.Normal.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((127)))))), (CInt(((CByte((203)))))), (CInt(((CByte((52)))))))
            Me.ucSettingsTile.Appearances.Normal.Options.UseBackColor = True
            Me.ucSettingsTile.Appearances.Normal.Options.UseBorderColor = True
            Me.ucSettingsTile.Document = Me.ucSettingsDocument
            tileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileItemElement3.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
            tileItemElement3.Text = "Settings"
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            Me.ucSettingsTile.Elements.Add(tileItemElement3)
            Me.ucSettingsTile.Group = "Main"
            Me.startGroup.SetID(Me.ucSettingsTile, 2)
            Me.ucSettingsTile.Name = "ucSettingsTile"
            Me.ucSettingsTile.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
            ' 
            ' ucSettingsDocument
            ' 
            Me.ucSettingsDocument.Caption = "Settings"
            Me.ucSettingsDocument.ControlName = "ucSettings"
            Me.ucSettingsDocument.ControlTypeName = "DevExpress.RealtorWorld.Win.ucSettings"
            ' 
            ' ucAgentsTile
            ' 
            Me.ucAgentsTile.Appearances.Normal.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((102)))))), (CInt(((CByte((102)))))), (CInt(((CByte((102)))))))
            Me.ucAgentsTile.Appearances.Normal.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((102)))))), (CInt(((CByte((102)))))), (CInt(((CByte((102)))))))
            Me.ucAgentsTile.Appearances.Normal.Options.UseBackColor = True
            Me.ucAgentsTile.Appearances.Normal.Options.UseBorderColor = True
            Me.ucAgentsTile.Document = Me.ucAgentsDocument
            tileItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileItemElement4.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
            tileItemElement4.Text = "Agents"
            Me.ucAgentsTile.Elements.Add(tileItemElement4)
            Me.ucAgentsTile.Group = "Main"
            Me.startGroup.SetID(Me.ucAgentsTile, 3)
            Me.ucAgentsTile.Name = "ucAgentsTile"
            Me.ucAgentsTile.Properties.AllowCheck = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' ucResearchTile
            ' 
            Me.ucResearchTile.Appearances.Normal.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((212)))))), (CInt(((CByte((175)))))), (CInt(((CByte((0)))))))
            Me.ucResearchTile.Appearances.Normal.BackColor2 = System.Drawing.Color.FromArgb((CInt(((CByte((224)))))), (CInt(((CByte((200)))))), (CInt(((CByte((26)))))))
            Me.ucResearchTile.Appearances.Normal.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((218)))))), (CInt(((CByte((187)))))), (CInt(((CByte((38)))))))
            Me.ucResearchTile.Appearances.Normal.Options.UseBackColor = True
            Me.ucResearchTile.Appearances.Normal.Options.UseBorderColor = True
            Me.ucResearchTile.Document = Me.ucResearchDocument
            tileItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileItemElement5.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
            tileItemElement5.Text = "Research"
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            Me.ucResearchTile.Elements.Add(tileItemElement5)
            Me.ucResearchTile.Group = "Main"
            Me.startGroup.SetID(Me.ucResearchTile, 4)
            Me.ucResearchTile.Name = "ucResearchTile"
            Me.ucResearchTile.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
            ' 
            ' ucStatsTile
            ' 
            Me.ucStatsTile.Appearances.Normal.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((102)))))), (CInt(((CByte((82)))))), (CInt(((CByte((162)))))))
            Me.ucStatsTile.Appearances.Normal.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((125)))))), (CInt(((CByte((108)))))), (CInt(((CByte((176)))))))
            Me.ucStatsTile.Appearances.Normal.Options.UseBackColor = True
            Me.ucStatsTile.Appearances.Normal.Options.UseBorderColor = True
            Me.ucStatsTile.Document = Me.ucStatsDocument
            tileItemElement6.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileItemElement6.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left
            tileItemElement6.ImageToTextIndent = 20
            tileItemElement6.Text = "Statistics"
            tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            Me.ucStatsTile.Elements.Add(tileItemElement6)
            Me.ucStatsTile.Group = "Utils"
            Me.startGroup.SetID(Me.ucStatsTile, 5)
            Me.ucStatsTile.Name = "ucStatsTile"
            ' 
            ' ucBrowserTile
            ' 
            Me.ucBrowserTile.ActivationTarget = Me.browserPage
            Me.ucBrowserTile.Appearances.Normal.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((218)))))), (CInt(((CByte((133)))))), (CInt(((CByte((21)))))))
            Me.ucBrowserTile.Appearances.Normal.BackColor2 = System.Drawing.Color.FromArgb((CInt(((CByte((226)))))), (CInt(((CByte((162)))))), (CInt(((CByte((25)))))))
            Me.ucBrowserTile.Appearances.Normal.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((224)))))), (CInt(((CByte((151)))))), (CInt(((CByte((56)))))))
            Me.ucBrowserTile.Appearances.Normal.Options.UseBackColor = True
            Me.ucBrowserTile.Appearances.Normal.Options.UseBorderColor = True
            Me.ucBrowserTile.Document = Me.ucBrowserDocument
            tileItemElement7.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileItemElement7.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left
            tileItemElement7.Text = "zillow.com"
            tileItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            Me.ucBrowserTile.Elements.Add(tileItemElement7)
            Me.ucBrowserTile.Group = "Utils"
            Me.startGroup.SetID(Me.ucBrowserTile, 6)
            Me.ucBrowserTile.Name = "ucBrowserTile"
            ' 
            ' browserPage
            ' 
            Me.browserPage.Document = Me.ucBrowserDocument
            Me.browserPage.Name = "browserPage"
            Me.browserPage.Parent = Me.startGroup
            AddHandler Me.browserPage.ButtonClick, New DevExpress.XtraBars.Docking2010.ButtonEventHandler(AddressOf Me.browserPage_ButtonClick)
            ' 
            ' ucBrowserDocument
            ' 
            Me.ucBrowserDocument.Caption = "Browser"
            Me.ucBrowserDocument.ControlName = "ucBrowser"
            Me.ucBrowserDocument.ControlTypeName = "DevExpress.RealtorWorld.Win.ucBrowser"
            ' 
            ' ucBanksTile
            ' 
            Me.ucBanksTile.Appearances.Normal.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((230)))))), (CInt(((CByte((94)))))), (CInt(((CByte((32)))))))
            Me.ucBanksTile.Appearances.Normal.BackColor2 = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((116)))))), (CInt(((CByte((39)))))))
            Me.ucBanksTile.Appearances.Normal.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((238)))))), (CInt(((CByte((137)))))), (CInt(((CByte((71)))))))
            Me.ucBanksTile.Appearances.Normal.Options.UseBackColor = True
            Me.ucBanksTile.Appearances.Normal.Options.UseBorderColor = True
            Me.ucBanksTile.Document = Me.ucBanksDocument
            tileItemElement8.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileItemElement8.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
            tileItemElement8.Text = "Mortgage Rates"
            tileItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            Me.ucBanksTile.Elements.Add(tileItemElement8)
            Me.ucBanksTile.Group = "Utils"
            Me.startGroup.SetID(Me.ucBanksTile, 7)
            Me.ucBanksTile.Name = "ucBanksTile"
            Me.ucBanksTile.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
            ' 
            ' ucLoanCalculatorTile
            ' 
            Me.ucLoanCalculatorTile.Appearances.Normal.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((195)))))), (CInt(((CByte((33)))))), (CInt(((CByte((63)))))))
            Me.ucLoanCalculatorTile.Appearances.Normal.BackColor2 = System.Drawing.Color.FromArgb((CInt(((CByte((209)))))), (CInt(((CByte((40)))))), (CInt(((CByte((77)))))))
            Me.ucLoanCalculatorTile.Appearances.Normal.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((204)))))), (CInt(((CByte((66)))))), (CInt(((CByte((92)))))))
            Me.ucLoanCalculatorTile.Appearances.Normal.Options.UseBackColor = True
            Me.ucLoanCalculatorTile.Appearances.Normal.Options.UseBorderColor = True
            Me.ucLoanCalculatorTile.Document = Me.ucLoanCalculatorDocument
            tileItemElement9.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileItemElement9.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
            tileItemElement9.Text = "Loan Calculator"
            tileItemElement9.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            Me.ucLoanCalculatorTile.Elements.Add(tileItemElement9)
            Me.ucLoanCalculatorTile.Group = "Utils"
            Me.startGroup.SetID(Me.ucLoanCalculatorTile, 8)
            Me.ucLoanCalculatorTile.Name = "ucLoanCalculatorTile"
            Me.ucLoanCalculatorTile.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
            ' 
            ' flyout
            ' 
            Me.flyout.Document = Me.ucFlyout
            Me.flyout.Name = "flyout"
            ' 
            ' ucFlyout
            ' 
            Me.ucFlyout.Caption = "ucFlyout"
            Me.ucFlyout.ControlName = "ucFlyoutDocument"
            Me.ucFlyout.ControlTypeName = "DevExpress.RealtorWorld.Win.Modules.ucFlyout"
            ' 
            ' ucHomeDetailDocument
            ' 
            Me.ucHomeDetailDocument.Caption = "Home Detail"
            Me.ucHomeDetailDocument.ControlName = "ucHomeDetail"
            Me.ucHomeDetailDocument.ControlTypeName = "DevExpress.RealtorWorld.Win.ucHomeDetail"
            ' 
            ' ucStatisticsDocument
            ' 
            Me.ucStatisticsDocument.Caption = "Statistics"
            Me.ucStatisticsDocument.ControlName = "ucStatistics"
            Me.ucStatisticsDocument.ControlTypeName = "DevExpress.RealtorWorld.Win.ucStatistics"
            ' 
            ' ucSysInfoDocument
            ' 
            Me.ucSysInfoDocument.Caption = "SysInfo"
            Me.ucSysInfoDocument.ControlName = "ucSysInfo"
            Me.ucSysInfoDocument.ControlTypeName = "DevExpress.RealtorWorld.Win.ucSysInfo"
            ' 
            ' barManager1
            ' 
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.MaxItemId = 0
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager1
            Me.barDockControlTop.Size = New System.Drawing.Size(1000, 0)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 600)
            Me.barDockControlBottom.Manager = Me.barManager1
            Me.barDockControlBottom.Size = New System.Drawing.Size(1000, 0)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Manager = Me.barManager1
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 600)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(1000, 0)
            Me.barDockControlRight.Manager = Me.barManager1
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 600)
            ' 
            ' windowsUIButtonPanel1
            ' 
            Me.windowsUIButtonPanel1.AllowGlyphSkinning = False
            windowsUIButtonImageOptions1.SvgImage = CType((resources.GetObject("windowsUIButtonImageOptions1.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            windowsUIButtonImageOptions1.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.windowsUIButtonPanel1.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Button", False, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False)})
            Me.windowsUIButtonPanel1.Location = New System.Drawing.Point(960, 8)
            Me.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1"
            Me.windowsUIButtonPanel1.Size = New System.Drawing.Size(32, 32)
            Me.windowsUIButtonPanel1.TabIndex = 5
            Me.windowsUIButtonPanel1.Text = "windowsUIButtonPanel1"
            Me.windowsUIButtonPanel1.UseButtonBackgroundImages = False
            AddHandler Me.windowsUIButtonPanel1.ButtonClick, New DevExpress.XtraBars.Docking2010.ButtonEventHandler(AddressOf Me.windowsUIButtonPanel1_ButtonClick)
            ' 
            ' frmMain
            ' 
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
            Me.ClientSize = New System.Drawing.Size(1000, 600)
            Me.Controls.Add(Me.windowsUIButtonPanel1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.MinimumSize = New System.Drawing.Size(1000, 600)
            Me.Name = "frmMain"
            Me.ShowIcon = False
            Me.Text = "Realtor World"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType((Me.documentManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.windowsUIView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.startGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pageGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ucListingDocument), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ucAgentsDocument), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ucStatsDocument), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ucResearchDocument), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ucBanksDocument), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ucLoanCalculatorDocument), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ucListingTile), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ucDraftTile), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.page), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ucDraftDocument), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ucSettingsTile), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ucSettingsDocument), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ucAgentsTile), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ucResearchTile), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ucStatsTile), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ucBrowserTile), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.browserPage), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ucBrowserDocument), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ucBanksTile), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ucLoanCalculatorTile), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.flyout), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ucFlyout), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ucHomeDetailDocument), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ucStatisticsDocument), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ucSysInfoDocument), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private documentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager

        Private windowsUIView As DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView

        Private ucAgentsDocument As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document

        Private ucBanksDocument As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document

        Private ucBrowserDocument As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document

        Private ucDraftDocument As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document

        Private ucHomeDetailDocument As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document

        Private ucListingDocument As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document

        Private ucLoanCalculatorDocument As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document

        Private ucResearchDocument As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document

        Private ucStatisticsDocument As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document

        Private ucStatsDocument As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document

        Private ucSysInfoDocument As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document

        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl

        Private barDockControlRight As DevExpress.XtraBars.BarDockControl

        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl

        Private barDockControlTop As DevExpress.XtraBars.BarDockControl

        Private barManager1 As DevExpress.XtraBars.BarManager

        Private ucListingTile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile

        Private ucBrowserTile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile

        Private ucStatsTile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile

        Private ucAgentsTile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile

        Private ucResearchTile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile

        Private ucBanksTile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile

        Private ucLoanCalculatorTile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile

        Private ucSettingsTile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile

        Private ucDraftTile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile

        Private startGroup As DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer

        Private pageGroup As DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup

        Private page As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page

        Private ucSettingsDocument As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document

        Private browserPage As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page

        Private flyout As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout

        Private ucFlyout As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document

        Private windowsUIButtonPanel1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    End Class
End Namespace
