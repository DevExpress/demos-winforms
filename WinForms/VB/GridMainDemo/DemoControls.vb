Imports System
Imports System.Data
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.ActiveDemos
Imports DevExpress.DXperience.Demos
Imports DevExpress.Export
Imports DevExpress.Internal
Imports DevExpress.Tutorials
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Blending
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Card
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.ReportGeneration
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid.Demos.VehiclesData

Namespace DevExpress.XtraGrid.Demos

    Public Class GridRibbonMenuManager
        Inherits RibbonMenuManager

        Private view As BaseView = Nothing

        Private blending As XtraGridBlending = Nothing

        Private bsiViewOptions, bsiSelectionOptions As BarSubItem

        Private bciAlphaBlendingUsing As BarCheckItem

        Private bbiAlphaBlendingAdjustment As BarButtonItem

        Public Sub New(ByVal form As RibbonMainForm)
            MyBase.New(form)
            CreateOptionsMenu(form.ReservGroup1, form.Ribbon)
            CreateBlendingMenu(form.ReservGroup2, form.Ribbon)
        End Sub

        Private Sub CreateBlendingMenu(ByVal ribbonPageGroup As RibbonPageGroup, ByVal ribbonControl As RibbonControl)
            ribbonPageGroup.Text = Properties.Resources.AlphaBlending
            bciAlphaBlendingUsing = New CheckBarItem(Manager, Properties.Resources.UsingString, New ItemClickEventHandler(AddressOf miUsing_Click))
            bbiAlphaBlendingAdjustment = New ButtonBarItem(Manager, Properties.Resources.Adjustment, New ItemClickEventHandler(AddressOf miAdjustment_Click))
            bbiAlphaBlendingAdjustment.Glyph = Utils.ResourceImageHelperCore.CreateImageFromResourcesEx("DevExpress.XtraGrid.Demos.Images.Blending.png", GetType(frmMain).Assembly)
            ribbonPageGroup.ItemLinks.Add(bciAlphaBlendingUsing)
            ribbonPageGroup.ItemLinks.Add(bbiAlphaBlendingAdjustment)
        End Sub

        Private Sub CreateOptionsMenu(ByVal ribbonPageGroup As RibbonPageGroup, ByVal ribbonControl As RibbonControl)
            ribbonPageGroup.Text = Properties.Resources.Options
            bsiViewOptions = New BarSubItem()
            bsiSelectionOptions = New BarSubItem()
            bsiViewOptions.Caption = Properties.Resources.ViewOptions
            bsiSelectionOptions.Caption = Properties.Resources.SelectionOptions
            Call MainFormHelper.SetBarButtonImage(bsiViewOptions, "View")
            Call MainFormHelper.SetBarButtonImage(bsiSelectionOptions, "LayoutOptions")
            ribbonControl.Items.Add(bsiViewOptions)
            ribbonControl.Items.Add(bsiSelectionOptions)
            ribbonPageGroup.ItemLinks.Add(bsiViewOptions)
            ribbonPageGroup.ItemLinks.Add(bsiSelectionOptions)
        End Sub

        Public Sub RefreshOptionsMenu(ByVal view As BaseView)
            Dim ov As GridOptionsView = New GridOptionsView()
            ShowReservGroup1(view IsNot Nothing)
            Me.view = view
            LookAndFeelMenu.ClearOptionItems(Manager)
            Call LookAndFeelMenu.AddOptionsMenu(bsiViewOptions, ViewOptions, New ItemClickEventHandler(AddressOf miViewOptions_Click), Manager)
            Call LookAndFeelMenu.AddOptionsMenu(bsiSelectionOptions, SelectionOptions, New ItemClickEventHandler(AddressOf miSelectionViewOptions_Click), Manager)
        End Sub

        Private ReadOnly Property ViewOptions As Object
            Get
                If TypeOf view Is GridView Then Return CType(view, GridView).OptionsView
                If TypeOf view Is CardView Then Return CType(view, CardView).OptionsView
                Return Nothing
            End Get
        End Property

        Private ReadOnly Property SelectionOptions As Object
            Get
                If TypeOf view Is GridView Then Return CType(view, GridView).OptionsSelection
                Return Nothing
            End Get
        End Property

        Private Sub miViewOptions_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim item As OptionBarItem = TryCast(e.Item, OptionBarItem)
            If view IsNot Nothing AndAlso item IsNot Nothing Then
                Utils.SetOptions.SetOptionValueByString(item.Tag.ToString(), ViewOptions, item.Checked)
                LookAndFeelMenu.InitOptionsMenu(bsiViewOptions, ViewOptions)
            End If
        End Sub

        Private Sub miSelectionViewOptions_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim item As OptionBarItem = TryCast(e.Item, OptionBarItem)
            If view IsNot Nothing AndAlso item IsNot Nothing Then
                Utils.SetOptions.SetOptionValueByString(item.Tag.ToString(), SelectionOptions, item.Checked)
                LookAndFeelMenu.InitOptionsMenu(bsiSelectionOptions, SelectionOptions)
            End If
        End Sub

        Public Sub InitBlendingMenu(ByVal blending As XtraGridBlending)
            Me.blending = blending
            ShowReservGroup2(blending IsNot Nothing)
            If blending IsNot Nothing Then
                bciAlphaBlendingUsing.Checked = blending.Enabled
                bbiAlphaBlendingAdjustment.Enabled = blending.Enabled
            End If
        End Sub

        Private Sub miUsing_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Call Application.DoEvents()
            Dim item As CheckBarItem = TryCast(e.Item, CheckBarItem)
            If blending IsNot Nothing AndAlso item IsNot Nothing Then
                blending.Enabled = item.Checked
                bbiAlphaBlendingAdjustment.Enabled = item.Checked
            End If
        End Sub

        Private Sub miAdjustment_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If blending IsNot Nothing Then
                blending.ShowDialog()
            End If
        End Sub
    End Class

    Public Class TutorialControl
        Inherits TutorialControlBase

        Public ReadOnly Property GridRibbonMenuManager As GridRibbonMenuManager
            Get
                Return TryCast(RibbonMenuManager, GridRibbonMenuManager)
            End Get
        End Property

        Protected Overrides Sub SetControlManager(ByVal ctrl As Control, ByVal manager As BarManager)
            Dim grid As GridControl = TryCast(ctrl, GridControl)
            If grid IsNot Nothing Then grid.MenuManager = manager
            Dim scrollBar As ScrollBarBase = TryCast(ctrl, ScrollBarBase)
            If scrollBar IsNot Nothing AndAlso FluentScrollBars Then ScrollBarBase.ApplyUIMode(scrollBar, ScrollUIMode.Fluent)
            Dim be As BaseEdit = TryCast(ctrl, BaseEdit)
            If be IsNot Nothing Then be.MenuManager = manager
        End Sub

        Protected Overridable ReadOnly Property FluentScrollBars As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overrides Sub AllowExport()
            EnabledPrintExportActions(True, ExportFormats.PDF Or ExportFormats.HTML Or ExportFormats.MHT Or ExportFormats.XLS Or ExportFormats.DOCX Or ExportFormats.RTF Or ExportFormats.Text Or ExportFormats.XLSX, False)
        End Sub

        Public Overrides ReadOnly Property AllowPrintOptions As Boolean
            Get
                Return ExportView IsNot Nothing
            End Get
        End Property

        Public Overrides ReadOnly Property AllowGenerateReport As Boolean
            Get
                Return True
            End Get
        End Property

        Public Overridable ReadOnly Property ExportView As BaseView
            Get
                Return Nothing
            End Get
        End Property

        Public Overridable ReadOnly Property AllowCellImagesExport As Boolean
            Get
                Return False
            End Get
        End Property

        Public Overridable ReadOnly Property ShowViewOptions As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overridable ReadOnly Property PaintViews As PaintView()
            Get
                Return Nothing
            End Get
        End Property

        Protected Overrides ReadOnly Property ModulesFolder As String
            Get
                Return "GridMainDemo\Modules\"
            End Get
        End Property

        Protected Overrides ReadOnly Property CodeInfoFolder As String
            Get
                Return "DevExpress.XtraGrid.Demos.CodeInfo"
            End Get
        End Property

#Region "Active Demo"
        Private fActiveDemoResults As ActiveDemoResults = Nothing

        Private fActiveDemo As ActiveDemo = Nothing

        Public Overrides Sub RunActiveDemo()
            If IsActiveDemo Then Return
            ActiveDemoResults.Clear()
            fActiveDemo = CreateActiveDemo()
            RunGridActiveDemo(TryCast(fActiveDemo, ActiveGridDemo))
            Dim cancelMode As ActiveActionsCancelMode = fActiveDemo.Actions.CancelMode
            fActiveDemo.Dispose()
            fActiveDemo = Nothing
            If cancelMode = ActiveActionsCancelMode.UnknownTopWindow Then MessageBox.Show(Properties.Resources.ActiveDemoWarning) 'TODO
            If cancelMode = ActiveActionsCancelMode.UserCancel Then MessageBox.Show(Properties.Resources.ActiveDemoCanceled)
        End Sub

        Public ReadOnly Property IsActiveDemo As Boolean
            Get
                Return fActiveDemo IsNot Nothing
            End Get
        End Property

        Protected Overridable Function CreateActiveDemo() As ActiveDemo
            Return New ActiveDemo()
        End Function

        Protected ReadOnly Property ActiveDemoResults As ActiveDemoResults
            Get
                If fActiveDemoResults Is Nothing Then fActiveDemoResults = New ActiveDemoResults(Me)
                Return fActiveDemoResults
            End Get
        End Property

        Protected Overridable Sub RunGridActiveDemo(ByVal fActiveDemo As ActiveGridDemo)
        End Sub

        Protected Overrides Sub OnVisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
            If fActiveDemoResults IsNot Nothing Then
                If Not Visible Then ActiveDemoResults.Hide()
            End If

            MyBase.OnVisibleChanged(sender, e)
        End Sub

#End Region
#Region "InitData"
        Protected Overridable Sub InitNWindData()
            Dim DBFileName As String = String.Empty
            DBFileName = DevAVDataDirectoryHelper.GetFile("nwind.xml")
            If Not Equals(DBFileName, String.Empty) Then
                TutorialHelper.DataSetConvertByteToImage(InitNWindXMLData(DBFileName))
            End If
        End Sub

        Protected Friend Overridable Sub UpdateRibbonItems()
        End Sub

        Protected Overridable Sub InitVehiclesData()
            Dim DBFileName As String = String.Empty
            DBFileName = DevAVDataDirectoryHelper.GetFile("Vehicles.xml")
            If Not Equals(DBFileName, String.Empty) Then
                InitXMLData(DBFileName)
            End If
        End Sub

        Protected Overridable Function InitNWindXMLData(ByVal dataFileName As String) As DataSet
            Return Nothing
        End Function

        Protected Overridable Sub InitXMLData(ByVal dataFileName As String)
        End Sub

        Protected Overridable Function NWindDataSet() As DataSet
            Dim DBFileName As String = String.Empty
            Dim ds As DataSet = New DataSet()
            DBFileName = DevAVDataDirectoryHelper.GetFile("nwind.xml")
            If Not Equals(DBFileName, String.Empty) Then
                InitXMLData(DBFileName, ds)
            End If

            TutorialHelper.DataSetConvertByteToImage(ds)
            Return ds
        End Function

        Protected Overridable Sub InitXMLData(ByVal dataFileName As String, ByVal ds As DataSet)
        End Sub

        Protected Overridable Sub InitIssueListData(ByVal ds As dsIssueList, ByVal Optional grid As GridControl = Nothing)
            Dim DBFileName As String = String.Empty
            DBFileName = DevAVDataDirectoryHelper.GetFile("IssueList.xml")
            If Not Equals(DBFileName, String.Empty) Then
                ds.ReadXml(DBFileName, XmlReadMode.InferSchema)
                UpdateIssueListData(ds.Items, 100)
            End If

            If grid IsNot Nothing Then
                grid.DataSource = ds.Items.OrderBy(Function(r) r.Status).OrderBy(Function(r) r.Priority).OrderBy(Function(r) Not r.Type).OrderBy(Function(r) r.ProjectID).ToList()
            End If
        End Sub

        Private Sub UpdateIssueListData(ByVal table As dsIssueList.ItemsDataTable, ByVal newRowsCount As Integer)
            Dim days As Integer =(TutorialConstants.Now.Date - New DateTime(2004, 8, 29)).Days
            For Each row As dsIssueList.ItemsRow In table
                row.CreatedDate = row.CreatedDate.AddDays(days)
                If Not row.IsModifiedDateNull() Then row.ModifiedDate = row.ModifiedDate.AddDays(days)
                If Not row.IsFixedDateNull() Then row.FixedDate = row.FixedDate.AddDays(days)
            Next

            For i As Integer = 0 To newRowsCount - 1
                Dim createdDate As Date = TutorialConstants.Today.AddDays(-TutorialConstants.Random.Next(40))
                Dim row1 As dsIssueList.ItemsRow = table(i Mod table.Rows.Count)
                Dim row2 As dsIssueList.ItemsRow = table(TutorialConstants.Random.Next(newRowsCount) Mod table.Rows.Count)
                table.Rows.Add(New Object() {createdDate, row2.CreatorID, row1.Description, GetFixedDate(createdDate, row2.Status, TutorialConstants.Random), i + 100, GetModifiedDate(createdDate, row2.Status, TutorialConstants.Random), row1.Name, row2.OwnerID, row2.Priority, row2.ProjectID, row2.Resolution, row2.Status, row2.Type})
            Next
        End Sub

        Private Function GetFixedDate(ByVal createdDate As Date, ByVal status As Integer, ByVal rnd As Data.Utils.NonCryptographicRandom) As Date?
            If status < 3 Then Return Nothing
            Dim ret As Date = createdDate.AddDays(rnd.Next(7))
            If ret > TutorialConstants.Today Then
                Return TutorialConstants.Today
            Else
                Return ret
            End If
        End Function

        Private Function GetModifiedDate(ByVal createdDate As Date, ByVal status As Integer, ByVal rnd As Data.Utils.NonCryptographicRandom) As Date?
            If status = 1 Then Return Nothing
            Dim ret As Date = createdDate.AddDays(rnd.Next(5))
            If ret > TutorialConstants.Today Then
                Return TutorialConstants.Today
            Else
                Return ret
            End If
        End Function

        Protected Overridable Sub InitCustomersPaymentData(ByVal ds As dsContacts)
            Dim DBFileName As String = String.Empty
            DBFileName = DevAVDataDirectoryHelper.GetFile("Payment.xml")
            If Not Equals(DBFileName, String.Empty) Then
                ds.ReadXml(DBFileName)
            End If
        End Sub

#End Region
#Region "Print and Export"
        Protected Overrides Sub ExportToCore(ByVal filename As String, ByVal ext As String)
            If ExportView Is Nothing Then Return
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            If Equals(ext, "rtf") Then ExportView.ExportToRtf(filename)
            If Equals(ext, "docx") Then ExportView.ExportToDocx(filename)
            If Equals(ext, "pdf") Then ExportView.ExportToPdf(filename)
            If Equals(ext, "mht") Then ExportView.ExportToMht(filename)
            If Equals(ext, "html") Then ExportView.ExportToHtml(filename)
            If Equals(ext, "txt") Then ExportView.ExportToText(filename)
            If Equals(ext, "xls") Then ExportToXlsInternal(filename)
            If Equals(ext, "xlsx") Then ExportToXlsxInternal(filename)
            Cursor.Current = currentCursor
        End Sub

        Private Sub ExportToXlsxInternal(ByVal filename As String)
            Dim options = New XlsxExportOptionsEx()
            options.UnboundExpressionExportMode = UnboundExpressionExportMode.AsFormula
            If Not(TypeOf ExportView Is GridView) Then options.ExportType = ExportType.WYSIWYG
            If AllowCellImagesExport Then options.AllowCellImages = Utils.DefaultBoolean.True
            ExportView.ExportToXlsx(filename, options)
        End Sub

        Private Sub ExportToXlsInternal(ByVal filename As String)
            Dim options = New XlsExportOptionsEx()
            options.UnboundExpressionExportMode = UnboundExpressionExportMode.AsFormula
            If Not(TypeOf ExportView Is GridView) Then options.ExportType = ExportType.WYSIWYG
            ExportView.ExportToXls(filename, options)
        End Sub

        Protected Overrides Sub ExportToPDF()
            ExportTo("pdf", Properties.Resources.PDFFilter)
        End Sub

        Protected Overrides Sub ExportToHTML()
            ExportTo("html", Properties.Resources.HTMLFilter)
        End Sub

        Protected Overrides Sub ExportToMHT()
            ExportTo("mht", Properties.Resources.MHTFilter)
        End Sub

        Protected Overrides Sub ExportToXLS()
            ExportTo("xls", Properties.Resources.XLSFilter)
        End Sub

        Protected Overrides Sub ExportToXLSX()
            ExportTo("xlsx", Properties.Resources.XLSXFilter)
        End Sub

        Protected Overrides Sub ExportToRTF()
            ExportTo("rtf", Properties.Resources.RTFFilter)
        End Sub

        Protected Overrides Sub ExportToDOCX()
            ExportTo("docx", Properties.Resources.DOCXFilter)
        End Sub

        Protected Overrides Sub ExportToText()
            ExportTo("txt", Properties.Resources.TextFilter)
        End Sub

        Protected Overrides Sub PrintPreview()
            If ExportView IsNot Nothing AndAlso ExportView.GridControl IsNot Nothing Then
                AddHandler ExportView.PrintInitialize, AddressOf ExportView_PrintInitialize
                If RibbonMenuManager.PrintOptions.ShowRibbonPreviewForm Then
                    ExportView.GridControl.ShowRibbonPrintPreview()
                Else
                    ExportView.GridControl.ShowPrintPreview()
                End If

                RemoveHandler ExportView.PrintInitialize, AddressOf ExportView_PrintInitialize
            End If
        End Sub

        Protected Overrides Sub GenerateReport()
            Dim useExpressionBindings As Boolean = XtraReports.Configuration.Settings.Default.UserDesignerOptions.DataBindingMode <> DataBindingMode.Bindings
            Dim report As XtraReport = ReportGenerator.GenerateReport(ExportView, Nothing, useExpressionBindings)
            report.ShowRibbonDesignerDialog()
        End Sub

        Private Sub ExportView_PrintInitialize(ByVal sender As Object, ByVal e As PrintInitializeEventArgs)
            Dim phf As PageHeaderFooter = TryCast(e.Link.PageHeaderFooter, PageHeaderFooter)
            phf.Footer.Content.Clear()
            phf.Footer.Content.AddRange(New String() {"", "", "[Page # of Pages #]"})
            phf.Footer.LineAlignment = BrickAlignment.Far
            e.Link.RtfReportHeader = "{\rtf1\ansi\ansicpg1251\deff0\deflang1049{\fonttbl{\f0\fnil\fcharset0 Segoe UI;}}
{\*\generator Msftedit 5.41.21.2510;}\viewkind4\uc1\pard\sa200\sl276\slmult1\qc\lang9\f0\fs32 " & TutorialName & "\par}\xd\x\a"
        End Sub

#End Region
        Protected Sub SetEditLicenseInfo(ByVal edit As RepositoryItem, ByVal view As ColumnView)
            LicenseToolTipController.SetEditLicenseInfo(edit, view)
        End Sub
    End Class

    Public Class PaintView

        Private ReadOnly fView As BaseView = Nothing

        Private fAppearanceName As String = ""

        Public Sub New(ByVal fView As BaseView, ByVal fAppearanceName As String)
            Me.fView = fView
            Me.fAppearanceName = fAppearanceName
        End Sub

        Public ReadOnly Property View As BaseView
            Get
                Return fView
            End Get
        End Property

        Public ReadOnly Property AppearanceName As String
            Get
                Return fAppearanceName
            End Get
        End Property
    End Class

    Public Module LicenseInfo

        Public Sub SetToolTipController(ByVal [module] As TutorialControl, ByVal grid As GridControl)
            grid.ToolTipController = [module].LicenseToolTipController
            AddHandler [module].LicenseToolTipController.OnLicenseChanged, Sub(s, e) e.Info = GetLicenseInfo(e.Row)
            [module].LicenseToolTipController.UpdateMaskOptions(grid)
            AddHandler grid.ViewRegistered, Sub(s, e) [module].LicenseToolTipController.UpdateMaskOptions(grid)
        End Sub

        Private Function GetLicenseInfo(ByVal obj As Object) As String
            Dim model = TryCast(obj, Model)
            If model IsNot Nothing Then Return model.LicenseInfo
            Dim item = TryCast(obj, VehiclesData.OrderItem)
            If item IsNot Nothing Then Return item.Model.LicenseInfo
            Dim row = TryCast(obj, DataRowView)
            If row IsNot Nothing Then Return VehiclesData.GetLicenseInfo(row.Row)
            Return Nothing
        End Function
    End Module
End Namespace
