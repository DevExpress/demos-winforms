Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Tutorials
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu
Imports DevExpress.Utils.Serializing.Helpers
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraScheduler.Commands
Imports DevExpress.XtraScheduler.Demos.DemoData
Imports DevExpress.XtraScheduler.Exchange
Imports DevExpress.XtraScheduler.iCalendar
Imports DevExpress.XtraScheduler.iCalendar.Components
Imports DevExpress.XtraScheduler.Native
Imports DevExpress.XtraScheduler.Outlook
Imports DevExpress.XtraScheduler.Services

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class CommonRibbon
        Inherits System.Windows.Forms.UserControl

        Public Const DefaultPageName As String = "Home"

        Private _tutorial As DevExpress.XtraScheduler.Demos.TutorialControl

        Private isLoaded As Boolean

        Public Sub New()
            Me.InitializeComponent()
            AddHandler Load, AddressOf Me.OnLoad
        End Sub

        <System.ComponentModel.DefaultValueAttribute(GetType(DevExpress.XtraScheduler.Demos.TutorialControl), Nothing)>
        Public Property Tutorial As TutorialControl
            Get
                Return Me._tutorial
            End Get

            Set(ByVal value As TutorialControl)
                If Me._tutorial Is value Then Return
                Me.UnsubscribeSchedulerEvents(Me._tutorial)
                Me._tutorial = value
                Dim scheduler As DevExpress.XtraScheduler.SchedulerControl = Me._tutorial.Scheduler
                If scheduler Is Nothing Then Return
                Me.schedulerBarController1.Control = scheduler
                Dim commandFactory As DevExpress.XtraScheduler.Demos.CustomSchedulerCommandFactoryService = New DevExpress.XtraScheduler.Demos.CustomSchedulerCommandFactoryService(scheduler, scheduler.GetService(Of DevExpress.XtraScheduler.Services.ISchedulerCommandFactoryService)())
                scheduler.RemoveService(GetType(DevExpress.XtraScheduler.Services.ISchedulerCommandFactoryService))
                scheduler.AddService(GetType(DevExpress.XtraScheduler.Services.ISchedulerCommandFactoryService), commandFactory)
                Me.SubscribeSchedulerEvents(Me._tutorial)
                Me.PrepareRibbon()
            End Set
        End Property

        Private ReadOnly Property ParentRibbon As RibbonControl
            Get
                If Me.Tutorial Is Nothing OrElse Me.Tutorial.RibbonOwnerForm Is Nothing Then Return Nothing
                Return Me.Tutorial.RibbonOwnerForm.Ribbon
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public Property GroupByRibbonPageGroupVisible As Boolean
            Get
                Return Not Me.groupByRibbonPageGroup1.Visible
            End Get

            Set(ByVal value As Boolean)
                Me.groupByRibbonPageGroup1.Visible = value
            End Set
        End Property

        <System.ComponentModel.DefaultValueAttribute(True)>
        Public Property SwitchViewPageGroupVisible As Boolean
            Get
                Return Me.arrangeRibbonPageGroup1.Visible AndAlso Me.activeViewRibbonPageGroup1.Visible
            End Get

            Set(ByVal value As Boolean)
                Me.arrangeRibbonPageGroup1.Visible = value
                Me.activeViewRibbonPageGroup1.Visible = value
            End Set
        End Property

        Public Sub UpdateRibbonItems()
            Me.bbiShowOptionsPane.Down = DevExpress.XtraScheduler.Demos.CommonOptions.Instance.ShowModuleOptionsPane
        End Sub

        Private Overloads Sub OnLoad(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.isLoaded = True
            Me.PrepareRibbon()
        End Sub

        Private Sub PrepareRibbon()
            If Not Me.isLoaded OrElse Me.Tutorial Is Nothing Then Return
            Me.Tutorial.SetModulesSubMenu(Me.bbiOpenCalendar)
        End Sub

        Private Sub SubscribeSchedulerEvents(ByVal tutorialControl As DevExpress.XtraScheduler.Demos.TutorialControl)
            If tutorialControl Is Nothing OrElse tutorialControl.Scheduler Is Nothing Then Return
            AddHandler tutorialControl.Scheduler.SelectionChanged, AddressOf Me.OnSchedulerSelectionChanged
            AddHandler tutorialControl.Scheduler.PopupMenuShowing, AddressOf Me.OnSchedulerPopupMenuShowing
        End Sub

        Private Sub UnsubscribeSchedulerEvents(ByVal tutorialControl As DevExpress.XtraScheduler.Demos.TutorialControl)
            If tutorialControl Is Nothing OrElse tutorialControl.Scheduler Is Nothing Then Return
            RemoveHandler tutorialControl.Scheduler.SelectionChanged, AddressOf Me.OnSchedulerSelectionChanged
            RemoveHandler tutorialControl.Scheduler.PopupMenuShowing, AddressOf Me.OnSchedulerPopupMenuShowing
        End Sub

        Private Sub OnSchedulerPopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.PopupMenuShowingEventArgs)
            Dim scheduler As DevExpress.XtraScheduler.SchedulerControl = CType(sender, DevExpress.XtraScheduler.SchedulerControl)
            If e.Menu.Id = DevExpress.XtraScheduler.SchedulerMenuItemId.AppointmentMenu Then
                Dim openAppointmentGroupIndex As Integer = Me.FindMenuAppointmentItemsGroupLastIndex(e.Menu)
                'Image sendMenuItemImage = DemoUtils.GetResourceImage("Images.Send_16x16.png");
                Dim sendMenuItem As DevExpress.Utils.Menu.DXMenuItem = New DevExpress.Utils.Menu.DXMenuItem("Send", Sub(s, ea) Call DevExpress.XtraScheduler.Demos.iCalendarMessageSender.ExportAppointments(Me.ParentForm, scheduler.DataStorage, scheduler.SelectedAppointments))
                sendMenuItem.BeginGroup = True
                sendMenuItem.SvgImage = DevExpress.XtraScheduler.Demos.DemoUtils.GetResourceSvgImage("Images.Forward.svg")
                sendMenuItem.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
                e.Menu.Items.Add(sendMenuItem)
                e.Menu.MoveMenuItem(sendMenuItem, System.Threading.Interlocked.Increment(openAppointmentGroupIndex))
                Dim selectedAppointments As DevExpress.XtraScheduler.AppointmentBaseCollection = scheduler.SelectedAppointments
                If selectedAppointments.Count = 1 Then
                    Dim selectedAppointment As DevExpress.XtraScheduler.Appointment = selectedAppointments(0)
                    Dim setAppointmentPrivateMenuItem As DevExpress.Utils.Menu.DXMenuItem = New DevExpress.Utils.Menu.DXMenuCheckItem("Private", selectedAppointment.GetIsPrivate())
                    AddHandler setAppointmentPrivateMenuItem.Click, Sub(s, ea) selectedAppointment.ToggleIsPrivate()
                    setAppointmentPrivateMenuItem.SvgImage = DevExpress.XtraScheduler.Demos.DemoUtils.GetResourceSvgImage("Images.Private.svg")
                    setAppointmentPrivateMenuItem.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
                    setAppointmentPrivateMenuItem.BeginGroup = True
                    e.Menu.Items.Add(setAppointmentPrivateMenuItem)
                    e.Menu.MoveMenuItem(setAppointmentPrivateMenuItem, System.Threading.Interlocked.Increment(openAppointmentGroupIndex))
                    e.Menu.Items(CInt((openAppointmentGroupIndex + 1))).BeginGroup = False
                End If

                Dim labelItem As DevExpress.Utils.Menu.DXMenuItem = Me.FindMenuItemById(e.Menu, DevExpress.XtraScheduler.SchedulerMenuItemId.LabelSubMenu)
                If labelItem IsNot Nothing Then
                    labelItem.Caption = "Categorize"
                    labelItem.SvgImage = DevExpress.XtraScheduler.Demos.DemoUtils.GetResourceSvgImage("Images.Categorize.svg")
                    labelItem.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
                End If
            End If
        End Sub

        Private Function FindMenuItemById(ByVal menu As DevExpress.XtraScheduler.SchedulerPopupMenu, ByVal id As DevExpress.XtraScheduler.SchedulerMenuItemId) As DXMenuItem
            For i As Integer = 0 To menu.Items.Count - 1
                Dim item As DevExpress.XtraScheduler.SchedulerMenuItem = TryCast(menu.Items(i), DevExpress.XtraScheduler.SchedulerMenuItem)
                If item IsNot Nothing AndAlso item.Id.Equals(id) Then Return item
                If item IsNot Nothing Then Continue For
                Dim subMenu As DevExpress.XtraScheduler.SchedulerPopupMenu = TryCast(menu.Items(i), DevExpress.XtraScheduler.SchedulerPopupMenu)
                If subMenu IsNot Nothing AndAlso subMenu.Id.Equals(id) Then Return subMenu
            Next

            Return Nothing
        End Function

        Private Function FindMenuAppointmentItemsGroupLastIndex(ByVal menu As DevExpress.XtraScheduler.SchedulerPopupMenu) As Integer
            Dim openAppointmentGroupIndex As Integer = -1
            For i As Integer = 0 To menu.Items.Count - 1
                Dim menuItem As DevExpress.XtraScheduler.SchedulerMenuItem = TryCast(menu.Items(i), DevExpress.XtraScheduler.SchedulerMenuItem)
                If menuItem Is Nothing Then Continue For
                If menuItem.Id = DevExpress.XtraScheduler.SchedulerMenuItemId.OpenAppointment OrElse menuItem.Id = DevExpress.XtraScheduler.SchedulerMenuItemId.EditSeries OrElse menuItem.Id = DevExpress.XtraScheduler.SchedulerMenuItemId.RestoreOccurrence Then openAppointmentGroupIndex = i
            Next

            Return openAppointmentGroupIndex
        End Function

        Private Sub OnSchedulerSelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            If Me.ParentRibbon Is Nothing Then Return
            Dim scheduler As DevExpress.XtraScheduler.SchedulerControl = CType(sender, DevExpress.XtraScheduler.SchedulerControl)
            If scheduler.SelectedAppointments.Count <> 1 Then Return
            Me.calendarToolsRibbonPageCategory1.Visible = True
            Me.ParentRibbon.SelectedPage = Me.appointmentRibbonPage1
            Me.btnIsPrivate.Down = scheduler.SelectedAppointments(CInt((0))).GetIsPrivate()
            Dim priority As DevExpress.XtraScheduler.Demos.DemoData.EventPriority = scheduler.SelectedAppointments(CInt((0))).GetPriority()
            Me.UpdateImportanceItems(priority)
        End Sub

        Private Sub UpdateImportanceItems(ByVal priority As DevExpress.XtraScheduler.Demos.DemoData.EventPriority)
            Me.bbiHighImportance.Down = priority = DevExpress.XtraScheduler.Demos.DemoData.EventPriority.Important
            Me.bbiLowImportance.Down = priority = DevExpress.XtraScheduler.Demos.DemoData.EventPriority.NotImportant
        End Sub

        Private Sub OnBbiNext7DaysItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            If Me.Tutorial Is Nothing OrElse Me.Tutorial.Scheduler Is Nothing Then Return
            Dim scheduler As DevExpress.XtraScheduler.SchedulerControl = Me.Tutorial.Scheduler
            scheduler.BeginUpdate()
            Try
                If scheduler.DayView.Enabled Then
                    scheduler.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Day
                    scheduler.DayView.DayCount = 7
                End If

                scheduler.Start = System.DateTime.Today
            Finally
                scheduler.EndUpdate()
            End Try
        End Sub

        Private currentOperationProgressIndex As Integer = 0

        Private Sub OnBbiOutlookImportItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            If Me.Tutorial Is Nothing OrElse Me.Tutorial.Scheduler Is Nothing Then Return
            Dim scheduler As DevExpress.XtraScheduler.SchedulerControl = Me.Tutorial.Scheduler
            scheduler.BeginUpdate()
            Try
                Dim chooseCalendarsForm As DevExpress.XtraScheduler.Demos.SelectOutlookCalendarsForm = New DevExpress.XtraScheduler.Demos.SelectOutlookCalendarsForm()
                chooseCalendarsForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
                If chooseCalendarsForm.ShowDialog(Me.Tutorial.ParentForm) <> System.Windows.Forms.DialogResult.OK Then Return
                Dim operationProgress As DevExpress.DXperience.Demos.IOperationProgress = TryCast(Me.Tutorial.ParentForm, DevExpress.DXperience.Demos.IOperationProgress)
                operationProgress.Start("Import from outlook", 0, 10000)
                Me.currentOperationProgressIndex = 0
                Dim importer As DevExpress.XtraScheduler.Exchange.AppointmentImporter = scheduler.DataStorage.CreateOutlookImporter()
                CType(importer, DevExpress.XtraScheduler.Outlook.ISupportCalendarFolders).CalendarFolderName = chooseCalendarsForm.CalendarName
                operationProgress.Start("Import from outlook", 0, importer.SourceObjectCount)
                AddHandler importer.AppointmentImporting, AddressOf Me.OnOutlookImportAppointmentImporting
                importer.Import(System.IO.Stream.Null)
                operationProgress.[End]()
            Finally
                scheduler.EndUpdate()
            End Try
        End Sub

        Private Sub OnOutlookImportAppointmentImporting(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.AppointmentImportingEventArgs)
            Me.currentOperationProgressIndex += 1
            Dim operationProgress As DevExpress.DXperience.Demos.IOperationProgress = TryCast(Me.Tutorial.ParentForm, DevExpress.DXperience.Demos.IOperationProgress)
            If operationProgress Is Nothing Then Return
            operationProgress.[Do](Me.currentOperationProgressIndex)
        End Sub

        Private Sub OnBbiResetViewSettingsItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            Call DevExpress.XtraScheduler.Demos.CommonOptions.ResetInstance()
            If Me.Tutorial Is Nothing OrElse Me.Tutorial.Scheduler Is Nothing Then Return
            Me.ApplySchedulerOptions()
            Me.Tutorial.ResetOptions()
        End Sub

        Private Sub OnBbiViewSettingsItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            Dim form As DevExpress.XtraScheduler.Demos.ChangeViewForm = New DevExpress.XtraScheduler.Demos.ChangeViewForm() With {.Icon = Me.Tutorial.ParentForm.Icon}
            form.LoadOptions(DevExpress.XtraScheduler.Demos.CommonOptions.Instance)
            If form.ShowDialog(Me.Tutorial.ParentForm) <> System.Windows.Forms.DialogResult.OK Then Return
            form.SaveOptions(DevExpress.XtraScheduler.Demos.CommonOptions.Instance)
            Me.ApplySchedulerOptions()
        End Sub

        Private Sub ApplySchedulerOptions()
            If Me.Tutorial Is Nothing Then Return
            Call DevExpress.XtraScheduler.Demos.CommonOptions.Instance.Apply(Me.Tutorial)
        End Sub

        Private Sub OnBbiShowOptionsPaneItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            DevExpress.XtraScheduler.Demos.CommonOptions.Instance.ShowModuleOptionsPane = Not DevExpress.XtraScheduler.Demos.CommonOptions.Instance.ShowModuleOptionsPane
            Me.Tutorial.UpdateOptionsPaneVisibility(DevExpress.XtraScheduler.Demos.CommonOptions.Instance.ShowModuleOptionsPane)
        End Sub

        Private Sub OnBtnIsPrivateItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            Dim scheduler As DevExpress.XtraScheduler.SchedulerControl = Me.Tutorial.Scheduler
            If scheduler.SelectedAppointments.Count <> 1 Then Return
            scheduler.SelectedAppointments(CInt((0))).SetIsPrivate(Me.btnIsPrivate.Down)
        End Sub

        Private Sub OnBbiHightImportanceItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            Dim scheduler As DevExpress.XtraScheduler.SchedulerControl = Me.Tutorial.Scheduler
            If scheduler.SelectedAppointments.Count <> 1 Then Return
            Dim priority As DevExpress.XtraScheduler.Demos.DemoData.EventPriority = DevExpress.XtraScheduler.Demos.DemoData.EventPriority.None
            If Me.bbiHighImportance.Down Then priority = DevExpress.XtraScheduler.Demos.DemoData.EventPriority.Important
            scheduler.SelectedAppointments(CInt((0))).SetPriority(priority)
            Me.UpdateImportanceItems(priority)
        End Sub

        Private Sub OnBbiLowImportanceItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            Dim scheduler As DevExpress.XtraScheduler.SchedulerControl = Me.Tutorial.Scheduler
            If scheduler.SelectedAppointments.Count <> 1 Then Return
            Dim priority As DevExpress.XtraScheduler.Demos.DemoData.EventPriority = DevExpress.XtraScheduler.Demos.DemoData.EventPriority.None
            If Me.bbiLowImportance.Down Then priority = DevExpress.XtraScheduler.Demos.DemoData.EventPriority.NotImportant
            scheduler.SelectedAppointments(CInt((0))).SetPriority(priority)
            Me.UpdateImportanceItems(priority)
        End Sub

        Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            Dim scheduler As DevExpress.XtraScheduler.SchedulerControl = Me.Tutorial.Scheduler
            Call DevExpress.XtraScheduler.Demos.iCalendarMessageSender.ExportAppointments(Me.ParentForm, scheduler.DataStorage, scheduler.SelectedAppointments)
        End Sub

        Private Sub OnBbiCopyDemoLinkItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            Me.CopyDemoLink()
        End Sub

        Private Sub OnBbiChCopyDemoLinkItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            Me.CopyDemoLink()
        End Sub

        Private Sub OnBbiChCopyHtmlDemoLinkItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            Dim htmlDemoLink As String = DevExpress.Tutorials.DemoLinkHelper.GetHtmlLink(Me.Tutorial)
            If System.[String].IsNullOrEmpty(htmlDemoLink) Then Return
            DevExpress.Data.Utils.SafeClipboardWin.Instance.SetText(htmlDemoLink)
        End Sub

        Private Sub CopyDemoLink()
            Dim link As String = DevExpress.Tutorials.DemoLinkHelper.GetLink(Me.Tutorial)
            If System.[String].IsNullOrEmpty(link) Then Return
            DevExpress.Data.Utils.SafeClipboardWin.Instance.SetText(link)
        End Sub
    End Class

    Public Class CustomSchedulerCommandFactoryService
        Implements DevExpress.XtraScheduler.Services.ISchedulerCommandFactoryService

        Private ReadOnly service As DevExpress.XtraScheduler.Services.ISchedulerCommandFactoryService

        Private ReadOnly control As DevExpress.XtraScheduler.SchedulerControl

        Public Sub New(ByVal control As DevExpress.XtraScheduler.SchedulerControl, ByVal service As DevExpress.XtraScheduler.Services.ISchedulerCommandFactoryService)
            Call DevExpress.Utils.Guard.ArgumentNotNull(control, "control")
            Call DevExpress.Utils.Guard.ArgumentNotNull(service, "service")
            Me.control = control
            Me.service = service
        End Sub

        Public Function CreateCommand(ByVal id As DevExpress.XtraScheduler.Commands.SchedulerCommandId) As SchedulerCommand Implements Global.DevExpress.XtraScheduler.Services.ISchedulerCommandFactoryService.CreateCommand
            If id = DevExpress.XtraScheduler.Commands.SchedulerCommandId.SaveSchedule Then Return New DevExpress.XtraScheduler.Demos.CustomSaveScheduleCommand(Me.control)
            Return Me.service.CreateCommand(id)
        End Function
    End Class

    Public Class CustomSaveScheduleCommand
        Inherits DevExpress.XtraScheduler.Commands.SaveScheduleCommand

        Private exporter As DevExpress.XtraScheduler.iCalendar.iCalendarExporter

        Public Sub New(ByVal target As DevExpress.XtraScheduler.Commands.ISchedulerCommandTarget)
            MyBase.New(target)
        End Sub

        Public Sub New(ByVal control As DevExpress.XtraScheduler.Native.InnerSchedulerControl)
            MyBase.New(control)
        End Sub

        Protected Overrides Function CreateExporter() As AppointmentExporter
            Me.exporter = New DevExpress.XtraScheduler.iCalendar.iCalendarExporter(Me.Control.Storage)
            AddHandler Me.exporter.AppointmentExporting, AddressOf Me.Exporter_AppointmentExporting
            Return Me.exporter
        End Function

        Public Overrides Sub Execute()
            MyBase.Execute()
            RemoveHandler Me.exporter.AppointmentExporting, AddressOf Me.Exporter_AppointmentExporting
        End Sub

        Private Sub Exporter_AppointmentExporting(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.AppointmentExportingEventArgs)
            Dim args As DevExpress.XtraScheduler.iCalendar.iCalendarAppointmentExportingEventArgs = TryCast(e, DevExpress.XtraScheduler.iCalendar.iCalendarAppointmentExportingEventArgs)
            Dim customProperty As DevExpress.XtraScheduler.iCalendar.Components.CustomProperty = TryCast(args.VEvent.CustomProperties("X-DEVEXPRESS-CUSTOMFIELD-PRIORITY"), DevExpress.XtraScheduler.iCalendar.Components.CustomProperty)
            customProperty.Value = DevExpress.Utils.Serializing.Helpers.ObjectConverter.ObjectToString(CInt(e.Appointment.CustomFields("Priority")))
        End Sub
    End Class
End Namespace
