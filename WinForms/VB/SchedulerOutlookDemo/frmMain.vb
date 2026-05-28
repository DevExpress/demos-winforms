Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class frmMain
        Inherits OutlookForm

        Private _DateNavigator As DateNavigator

        Const RightPadding As Integer = 10

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            Ribbon.RibbonStyle = RibbonControlStyle.Office2019
            SetBackstageInfoControl(New OverviewControl() With {.Dock = DockStyle.Fill})
            SetBackstageExportControl(New ExportControl(Me) With {.Dock = DockStyle.Fill})
            SetBackstagePrintControl(New SchedulerPrint() With {.Dock = DockStyle.Fill})
            AddHandler LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
            RegisterZoomTracker(TrackBarItem)
        End Sub

        Protected Overrides ReadOnly Property SupportAdvancedTitlePainting As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overrides ReadOnly Property DemoName As String
            Get
                Return DemoHelper.GetFormText("XtraScheduler Main Demo")
            End Get
        End Property

        <System.ComponentModel.DefaultValue(CType(Nothing, Object))>
        Public Property DateNavigator As DateNavigator
            Get
                Return _DateNavigator
            End Get

            Private Set(ByVal value As DateNavigator)
                _DateNavigator = value
            End Set
        End Property

        Protected Overrides Sub ShowAbout()
            Call SchedulerControl.About()
        End Sub

        Protected Overrides ReadOnly Property ProductName As String
            Get
                Return "XtraScheduler"
            End Get
        End Property

        Protected Overrides Sub SetFormParam()
            Icon = ResourceImageHelperCore.CreateIconFromResourcesEx("DevExpress.XtraScheduler.Demos.AppIcon.ico", GetType(frmMain).Assembly)
        End Sub

        Protected Overrides Sub ShowModuleCore(ByVal name As String, ByVal controlPlaceholder As GroupControl)
            DemosInfo.DoShowModule(name, controlPlaceholder, DateNavigator, RibbonMenuManager)
        End Sub

        Protected Overrides Sub ShowCalendars(ByVal calendarPlaceholder As GroupControl)
            DateNavigator = New DateNavigator()
            DateNavigator.BeginInit()
            DateNavigator.Dock = DockStyle.Fill
            DateNavigator.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder
            DateNavigator.ShowTodayButton = False
            DateNavigator.BackColor = ColorHelper.GetControlColor(LookAndFeel)
            SetUpCalendarAppearanceForeColor()
            DateNavigator.CalendarView = Repository.CalendarView.ClassicNew
            DateNavigator.NavigationMode = DateNavigationMode.ScrollCalendar
            AddHandler DateNavigator.LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
            DateNavigator.TabStop = False
            DateNavigator.EndInit()
            calendarPlaceholder.Controls.Add(DateNavigator)
            SidePanel.MinimumSize = New System.Drawing.Size(DateNavigator.CalcBestSize().Width + RightPadding, 0)
        End Sub

        Private Sub LookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            DateNavigator.BackColor = ColorHelper.GetControlColor(LookAndFeel)
            SetUpCalendarAppearanceForeColor()
            UpdateSidePanelWidth()
        End Sub

        Private Sub SetUpCalendarAppearanceForeColor()
            DateNavigator.CalendarAppearance.DayCell.ForeColor = DevExpress.LookAndFeel.LookAndFeelHelper.GetSystemColor(LookAndFeel, SystemColors.ControlText)
            DateNavigator.CalendarAppearance.DayCellSpecial.ForeColor = DevExpress.LookAndFeel.LookAndFeelHelper.GetSystemColor(LookAndFeel, SystemColors.ControlText)
            DateNavigator.CalendarAppearance.WeekNumber.ForeColor = DevExpress.LookAndFeel.LookAndFeelHelper.GetSystemColor(LookAndFeel, SystemColors.ControlText)
            DateNavigator.CalendarAppearance.WeekDay.ForeColor = DevExpress.LookAndFeel.LookAndFeelHelper.GetSystemColor(LookAndFeel, SystemColors.ControlText)
        End Sub

        Private Sub UpdateSidePanelWidth()
            Dim bestWidth As Integer = DateNavigator.GetPreferredSize(System.Drawing.Size.Empty).Width
            If DateNavigator.Parent.Width < bestWidth Then SidePanel.Width = bestWidth
        End Sub
    End Class

    Public Class CheckBarItemWithPrintColorSchema
        Inherits CheckBarItem

        Private _printColorSchema As PrintColorSchema

        Public Sub New(ByVal manager As BarManager, ByVal text As String, ByVal handler As ItemClickEventHandler, ByVal printColorSchema As PrintColorSchema)
            MyBase.New(manager, text, handler)
            _printColorSchema = printColorSchema
        End Sub

        Public ReadOnly Property PrintColorSchema As PrintColorSchema
            Get
                Return _printColorSchema
            End Get
        End Property
    End Class

    Public Interface IDemoSchedulerReport

        Sub UpdateActiveReport()

    End Interface

    Public Class SchedulerRibbonMenuManager
        Inherits RibbonMenuManager

#Region "Fields"
        Private fSchedulerControl As SchedulerControl

        Private fSchedulerReport As IDemoSchedulerReport

        Private bbiPageSetup As BarButtonItem

        Private bbiLoadPageSetup As BarButtonItem

        Private bbiSavePageSetup As BarButtonItem

        Private bsiReports As BarSubItem

        Private cbiPrintColorSchemaBW As BarItem

        Private cbiPrintColorSchemaGS As BarItem

        Private cbiPrintColorSchemaFC As BarItem

#End Region
        Public Sub New(ByVal form As RibbonMainForm)
            MyBase.New(form)
            CreatePageSetupMenu(form)
            CreateReportsMenu(form)
            EnableReportsMenu()
        End Sub

#Region "Properties"
        Public Property SchedulerControl As SchedulerControl
            Get
                Return fSchedulerControl
            End Get

            Set(ByVal value As SchedulerControl)
                fSchedulerControl = value
            End Set
        End Property

        Public Property SchedulerReport As IDemoSchedulerReport
            Get
                Return fSchedulerReport
            End Get

            Set(ByVal value As IDemoSchedulerReport)
                fSchedulerReport = value
                EnableReportsMenu()
            End Set
        End Property

#End Region
        Protected Friend Overridable Sub EnableReportsMenu()
            ShowReservGroup1(SchedulerReport IsNot Nothing)
        End Sub

        Protected Friend Overridable Sub CreatePageSetupMenu(ByVal form As RibbonMainForm)
            bbiPageSetup = CreateButtonItem("Page Setup", "PageSetup")
            AddHandler bbiPageSetup.ItemClick, AddressOf bbiPageSetup_Click
            Dim ribbon As RibbonControl = form.Ribbon
            Dim printExportGroup As RibbonPageGroup = form.PrintExportGroup
            AddBarItemInRibbon(ribbon, printExportGroup, bbiPageSetup, True)
            bbiLoadPageSetup = CreateButtonItem("Load Page Setup", "LoadPageSetup")
            AddHandler bbiLoadPageSetup.ItemClick, AddressOf bbiLoadPageSetup_Click
            AddBarItemInRibbon(ribbon, printExportGroup, bbiLoadPageSetup)
            bbiSavePageSetup = CreateButtonItem("Save Page Setup", "SavePageSetup")
            AddHandler bbiSavePageSetup.ItemClick, AddressOf bbiSavePageSetup_Click
            AddBarItemInRibbon(ribbon, printExportGroup, bbiSavePageSetup)
        End Sub

        Protected Friend Overridable Function CreateButtonItem(ByVal caption As String, ByVal imageName As String) As BarButtonItem
            Dim item As BarButtonItem = New BarButtonItem(Manager, caption)
            Call MainFormHelper.SetBarButtonImage(item, imageName)
            'bbiAlphaBlendingAdjustment.Glyph = DevExpress.Utils.ResourceImageHelper.CreateImageFromResources("DevExpress.XtraScheduler.Demos.Images.Blending.png", typeof(frmMain).Assembly);            
            Return item
        End Function

        Protected Friend Overridable Sub AddBarItemInRibbon(ByVal ribbon As RibbonControl, ByVal group As RibbonPageGroup, ByVal item As BarItem)
            AddBarItemInRibbon(ribbon, group, item, False)
        End Sub

        Private Sub AddBarItemInRibbon(ByVal ribbon As RibbonControl, ByVal group As RibbonPageGroup, ByVal item As BarItem, ByVal beginGroup As Boolean)
            ribbon.Items.Add(item)
            group.ItemLinks.Add(item, beginGroup)
        End Sub

        Private Sub bbiPageSetup_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Try
                SchedulerControl.ShowPrintOptionsForm()
            Catch ex As Exception
                XtraMessageBox.Show(ex.Message, Application.ProductName)
            End Try
        End Sub

        Private Sub bbiLoadPageSetup_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim dlg As OpenFileDialog = New OpenFileDialog()
            Try
                dlg.CheckPathExists = True
                dlg.Filter = "XML files (*.xml) | *.xml"
                Dim result As DialogResult = dlg.ShowDialog()
                If result <> DialogResult.OK Then Return
                SchedulerControl.PrintStyles.FromXml(dlg.FileName, Application.ProductName)
            Catch ex As Exception
                XtraMessageBox.Show(ex.Message, Application.ProductName)
            Finally
                dlg.Dispose()
            End Try
        End Sub

        Private Sub bbiSavePageSetup_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim dlg As SaveFileDialog = New SaveFileDialog()
            Try
                dlg.Filter = "XML files (*.xml) | *.xml"
                Dim result As DialogResult = dlg.ShowDialog()
                If result <> DialogResult.OK Then Return
                SchedulerControl.PrintStyles.ToXml(dlg.FileName, Application.ProductName)
            Catch ex As Exception
                XtraMessageBox.Show(ex.Message, Application.ProductName)
            Finally
                dlg.Dispose()
            End Try
        End Sub

        Protected Friend Overridable Sub CreateReportsMenu(ByVal form As RibbonMainForm)
            bsiReports = New BarSubItem(Manager, "Print Color Schemas")
            AddHandler bsiReports.Popup, AddressOf OnPopupReports
            Call MainFormHelper.SetBarButtonImage(bsiReports, "PrintColorSchemas")
            Dim ribbon As RibbonControl = form.Ribbon
            Dim reportsGroup As RibbonPageGroup = form.ReservGroup1
            reportsGroup.Text = "Reports"
            AddBarItemInRibbon(ribbon, reportsGroup, bsiReports)
            cbiPrintColorSchemaFC = New CheckBarItemWithPrintColorSchema(Manager, "Full Color", AddressOf cbiPrintColorSchema_Click, PrintColorSchema.FullColor)
            cbiPrintColorSchemaGS = New CheckBarItemWithPrintColorSchema(Manager, "Grayscale", AddressOf cbiPrintColorSchema_Click, PrintColorSchema.GrayScale)
            cbiPrintColorSchemaBW = New CheckBarItemWithPrintColorSchema(Manager, "Black And White", AddressOf cbiPrintColorSchema_Click, PrintColorSchema.BlackAndWhite)
            AddCheckBarItemInSubItem(ribbon, bsiReports, cbiPrintColorSchemaFC)
            AddCheckBarItemInSubItem(ribbon, bsiReports, cbiPrintColorSchemaGS)
            AddCheckBarItemInSubItem(ribbon, bsiReports, cbiPrintColorSchemaBW)
        End Sub

        Protected Friend Overridable Sub AddCheckBarItemInSubItem(ByVal ribbon As RibbonControl, ByVal subItem As BarSubItem, ByVal item As BarItem)
            ribbon.Items.Add(item)
            subItem.ItemLinks.Add(item)
        End Sub

        Private Sub OnPopupReports(ByVal sender As Object, ByVal e As EventArgs)
            Dim items As BarSubItem = TryCast(sender, BarSubItem)
            If items Is Nothing Then Return
            For Each item As BarItemLink In items.ItemLinks
                Dim aItem As CheckBarItemWithPrintColorSchema = TryCast(item.Item, CheckBarItemWithPrintColorSchema)
                If aItem IsNot Nothing Then aItem.Checked = aItem.PrintColorSchema.Equals(DemoUtils.ReportPrintColorSchema)
            Next
        End Sub

        Private Sub cbiPrintColorSchema_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim schemaItem As CheckBarItemWithPrintColorSchema = CType(e.Item, CheckBarItemWithPrintColorSchema)
            If SchedulerReport IsNot Nothing Then
                DemoUtils.ReportPrintColorSchema = schemaItem.PrintColorSchema
                SchedulerReport.UpdateActiveReport()
            End If
        End Sub
    End Class
End Namespace
