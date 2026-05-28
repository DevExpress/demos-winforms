Imports System
Imports System.Globalization
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Docking

Namespace DevExpress.XtraSpreadsheet.Demos

    Public Partial Class MailMergeModuleBase
        Inherits SpreadSheetTutorialControlBase

        Private ReadOnly book As IWorkbook

        Private ReadOnly culture As CultureInfo

        Private ribbonPageDemoGroup As Ribbon.RibbonPageGroup

        Private hideCommentsCheckItem As BarCheckItem

        Private toolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem

        Private toolTipItem1 As DevExpress.Utils.ToolTipItem

        Private superToolTip1 As DevExpress.Utils.SuperToolTip

        Protected Sub New()
            culture = DefaultCulture
            InitializeComponent()
            CreateDemoGroup()
            spreadsheetControl1.Options.Culture = culture
            ribbonPageDemoGroup.Visible = ShowHideCommentsItem
            spreadsheetDockManager1.ForceInitialize()
            filteringDockPanel.Visibility = If(ShowFilterPanel, DockVisibility.Visible, DockVisibility.Hidden)
            mailMergeParametersDockPanel.Visibility = If(ShowParametersPanel, DockVisibility.Visible, DockVisibility.Hidden)
            spreadsheetControl1.BeginUpdate()
            book = spreadsheetControl1.Document
            LoadTemplate(spreadsheetControl1)
            LoadData(book)
            spreadsheetControl1.CreateCommand(Commands.SpreadsheetCommandId.MailMergeShowRanges).Execute()
            spreadsheetControl1.Document.History.Clear()
            spreadsheetControl1.EndUpdate()
        End Sub

        Private Sub CreateDemoGroup()
            ribbonPageDemoGroup = New Ribbon.RibbonPageGroup()
            hideCommentsCheckItem = New BarCheckItem()
            toolTipTitleItem1 = New DevExpress.Utils.ToolTipTitleItem()
            toolTipItem1 = New DevExpress.Utils.ToolTipItem()
            superToolTip1 = New DevExpress.Utils.SuperToolTip()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MailMergeModuleBase))
            mailMergeRibbonPage1.Groups.Add(ribbonPageDemoGroup)
            ribbonPageDemoGroup.ItemLinks.Add(hideCommentsCheckItem)
            ribbonPageDemoGroup.Name = "ribbonPageDemoGroup"
            ribbonPageDemoGroup.ShowCaptionButton = False
            ribbonPageDemoGroup.Text = "Demo"
            ribbonControl1.Items.Add(hideCommentsCheckItem)
            hideCommentsCheckItem.Caption = "Hide Comments"
            hideCommentsCheckItem.CategoryGuid = New Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            hideCommentsCheckItem.Description = "Show or hide descriptive comments in the template."
            hideCommentsCheckItem.Id = 230
            hideCommentsCheckItem.ImageOptions.Image = CType(resources.GetObject("hideCommentsCheckItem.ImageOptions.Image"), System.Drawing.Image)
            hideCommentsCheckItem.ImageOptions.LargeImage = CType(resources.GetObject("hideCommentsCheckItem.ImageOptions.LargeImage"), System.Drawing.Image)
            hideCommentsCheckItem.ImageOptions.SvgImage = CType(resources.GetObject("hideCommentsCheckItem.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
            hideCommentsCheckItem.Name = "hideCommentsCheckItem"
            hideCommentsCheckItem.RibbonStyle = Ribbon.RibbonItemStyles.Large
            toolTipTitleItem1.Text = "Hide Comments"
            toolTipItem1.Text = "Show or hide descriptive comments in the template."
            superToolTip1.Items.Add(toolTipTitleItem1)
            superToolTip1.Items.Add(toolTipItem1)
            hideCommentsCheckItem.SuperTip = superToolTip1
            AddHandler hideCommentsCheckItem.CheckedChanged, AddressOf hideCommentsCheckItem_ItemClick
        End Sub

        Protected Overridable ReadOnly Property ShowHideCommentsItem As Boolean
            Get
                Return True
            End Get
        End Property

        Protected Overridable ReadOnly Property ShowFilterPanel As Boolean
            Get
                Return True
            End Get
        End Property

        Protected Overridable ReadOnly Property ShowParametersPanel As Boolean
            Get
                Return False
            End Get
        End Property

        Protected ReadOnly Property ShowSalesManagers As Boolean
            Get
                Return checkEdit0.Checked
            End Get
        End Property

        Protected ReadOnly Property ShowInsideSalesCoordinators As Boolean
            Get
                Return checkEdit1.Checked
            End Get
        End Property

        Protected ReadOnly Property ShowSalesRepresentatives As Boolean
            Get
                Return checkEdit2.Checked
            End Get
        End Property

        Public Overrides ReadOnly Property ShowWithPaddings As Boolean
            Get
                Return True
            End Get
        End Property

        Protected Overrides Sub DoShow()
            ribbonControl1.SelectedPage = mailMergeRibbonPage1
            spreadsheetBarController1.Control.Focus()
            MyBase.DoShow()
        End Sub

        Private Sub hideCommentsCheckItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            HideComments(book, Not hideCommentsCheckItem.Checked)
        End Sub

        Private Sub checkEdit_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ChangeFilter(book)
        End Sub

        Protected Overridable Sub LoadTemplate(ByVal spreadsheetControl As SpreadsheetControl)
        End Sub

        Protected Overridable Sub LoadData(ByVal book As IWorkbook)
        End Sub

        Protected Overridable Sub ChangeFilter(ByVal book As IWorkbook)
            Throw New NotImplementedException()
        End Sub

        Protected Overridable Sub HideComments(ByVal book As IWorkbook, ByVal visible As Boolean)
            Throw New NotImplementedException()
        End Sub
    End Class
End Namespace
