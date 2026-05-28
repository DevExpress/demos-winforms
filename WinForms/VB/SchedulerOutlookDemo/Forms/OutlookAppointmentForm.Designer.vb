Imports DevExpress.XtraScheduler.UI

Namespace DevExpress.XtraScheduler.Demos

    Partial Class OutlookAppointmentForm

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraScheduler.Demos.OutlookAppointmentForm))
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.backstageViewControl1 = New DevExpress.XtraBars.Ribbon.BackstageViewControl()
            Me.bvPrint = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
            Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
            Me.dvInfo = New DevExpress.XtraPrinting.Preview.DocumentViewer()
            Me.bvtPrint = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
            Me.bvbSave = New DevExpress.XtraBars.Ribbon.BackstageViewButtonItem()
            Me.bvbSaveAs = New DevExpress.XtraBars.Ribbon.BackstageViewButtonItem()
            Me.bvbClose = New DevExpress.XtraBars.Ribbon.BackstageViewButtonItem()
            Me.btnSaveAndClose = New DevExpress.XtraBars.BarButtonItem()
            Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
            Me.barLabel = New DevExpress.XtraBars.BarEditItem()
            Me.riAppointmentLabel = New DevExpress.XtraScheduler.UI.RepositoryItemAppointmentLabel()
            Me.barStatus = New DevExpress.XtraBars.BarEditItem()
            Me.riAppointmentStatus = New DevExpress.XtraScheduler.UI.RepositoryItemAppointmentStatus()
            Me.barReminder = New DevExpress.XtraBars.BarEditItem()
            Me.riDuration = New DevExpress.XtraScheduler.UI.RepositoryItemDuration()
            Me.btnRecurrence = New DevExpress.XtraBars.BarButtonItem()
            Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
            Me.btnNext = New DevExpress.XtraBars.BarButtonItem()
            Me.btnPrevious = New DevExpress.XtraBars.BarButtonItem()
            Me.btnTimeZones = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiCategorize = New DevExpress.XtraBars.BarButtonItem()
            Me.pmCategorize = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.btnIsPrivate = New DevExpress.XtraBars.BarButtonItem()
            Me.btnHighImportance = New DevExpress.XtraBars.BarButtonItem()
            Me.btnLowImportance = New DevExpress.XtraBars.BarButtonItem()
            Me.rpAppointment = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.rpgActions = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.rpgOptions = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.rpgTags = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.riAppointmentResource = New DevExpress.XtraScheduler.UI.RepositoryItemAppointmentResource()
            Me.repositoryItemAppointmentLabel1 = New DevExpress.XtraScheduler.UI.RepositoryItemAppointmentLabel()
            Me.panelMain = New System.Windows.Forms.Panel()
            Me.panelDescription = New System.Windows.Forms.Panel()
            Me.changeAppointmentLabelItem2 = New DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem()
            Me.changeAppointmentLabelItem3 = New DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem()
            Me.tablePanel1 = New DevExpress.Utils.Layout.TablePanel()
            Me.tablePanel2 = New DevExpress.Utils.Layout.TablePanel()
            Me.tbProgress = New DevExpress.XtraEditors.TrackBarControl()
            Me.lblPercentCompleteValue = New DevExpress.XtraEditors.LabelControl()
            Me.tbDescription = New DevExpress.XtraEditors.MemoEdit()
            Me.panel1 = New DevExpress.XtraEditors.PanelControl()
            Me.edtResource = New DevExpress.XtraScheduler.UI.AppointmentResourceEdit()
            Me.edtResources = New DevExpress.XtraScheduler.UI.AppointmentResourcesEdit()
            Me.edtTimeZone = New DevExpress.XtraScheduler.UI.TimeZoneEdit()
            Me.lblPercentComplete = New DevExpress.XtraEditors.LabelControl()
            Me.lblSubject = New DevExpress.XtraEditors.LabelControl()
            Me.lblResource = New DevExpress.XtraEditors.LabelControl()
            Me.lblEndTime = New DevExpress.XtraEditors.LabelControl()
            Me.chkAllDay = New DevExpress.XtraEditors.CheckEdit()
            Me.edtEndDate = New DevExpress.XtraEditors.DateEdit()
            Me.lblStartTime = New DevExpress.XtraEditors.LabelControl()
            Me.edtEndTime = New DevExpress.XtraEditors.TimeEdit()
            Me.tbSubject = New DevExpress.XtraEditors.TextEdit()
            Me.lblLocation = New DevExpress.XtraEditors.LabelControl()
            Me.edtStartDate = New DevExpress.XtraEditors.DateEdit()
            Me.tbLocation = New DevExpress.XtraEditors.TextEdit()
            Me.edtStartTime = New DevExpress.XtraEditors.TimeEdit()
            Me.barEditItem1 = New DevExpress.XtraBars.BarEditItem()
            Me.barEditItem2 = New DevExpress.XtraBars.BarEditItem()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.backstageViewControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.backstageViewControl1.SuspendLayout()
            Me.bvPrint.SuspendLayout()
            CType((Me.riAppointmentLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.riAppointmentStatus), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.riDuration), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pmCategorize), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.riAppointmentResource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemAppointmentLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tablePanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tablePanel1.SuspendLayout()
            CType((Me.tablePanel2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tablePanel2.SuspendLayout()
            CType((Me.tbProgress), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tbProgress.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tbDescription.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType((Me.edtResource.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.edtResources.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.edtResources.ResourcesCheckedListBoxControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.edtTimeZone.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkAllDay.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.edtEndDate.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.edtEndDate.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.edtEndTime.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tbSubject.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.edtStartDate.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.edtStartDate.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tbLocation.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.edtStartTime.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ApplicationButtonDropDownControl = Me.backstageViewControl1
            Me.ribbonControl1.AutoSizeItems = True
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.btnSaveAndClose, Me.btnDelete, Me.barLabel, Me.barStatus, Me.barReminder, Me.btnRecurrence, Me.btnSave, Me.btnNext, Me.btnPrevious, Me.btnTimeZones, Me.bbiCategorize, Me.btnIsPrivate, Me.btnHighImportance, Me.btnLowImportance})
            resources.ApplyResources(Me.ribbonControl1, "ribbonControl1")
            Me.ribbonControl1.MaxItemId = 9
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rpAppointment})
            Me.ribbonControl1.QuickToolbarItemLinks.Add(Me.btnSave)
            Me.ribbonControl1.QuickToolbarItemLinks.Add(Me.btnPrevious)
            Me.ribbonControl1.QuickToolbarItemLinks.Add(Me.btnNext)
            Me.ribbonControl1.QuickToolbarItemLinks.Add(Me.btnDelete)
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riAppointmentLabel, Me.riAppointmentResource, Me.riAppointmentStatus, Me.riDuration, Me.repositoryItemAppointmentLabel1})
            Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
            AddHandler Me.ribbonControl1.ApplicationButtonClick, New System.EventHandler(AddressOf Me.ribbonControl1_ApplicationButtonClick)
            ' 
            ' backstageViewControl1
            ' 
            resources.ApplyResources(Me.backstageViewControl1, "backstageViewControl1")
            Me.backstageViewControl1.Controls.Add(Me.bvPrint)
            Me.backstageViewControl1.Items.Add(Me.bvtPrint)
            Me.backstageViewControl1.Items.Add(Me.bvbSave)
            Me.backstageViewControl1.Items.Add(Me.bvbSaveAs)
            Me.backstageViewControl1.Items.Add(Me.bvbClose)
            Me.backstageViewControl1.Name = "backstageViewControl1"
            Me.backstageViewControl1.OwnerControl = Me.ribbonControl1
            Me.backstageViewControl1.SelectedTab = Me.bvtPrint
            Me.backstageViewControl1.SelectedTabIndex = 0
            Me.backstageViewControl1.Style = DevExpress.XtraBars.Ribbon.BackstageViewStyle.Office2013
            ' 
            ' bvPrint
            ' 
            resources.ApplyResources(Me.bvPrint, "bvPrint")
            Me.bvPrint.Controls.Add(Me.btnPrint)
            Me.bvPrint.Controls.Add(Me.dvInfo)
            Me.bvPrint.Name = "bvPrint"
            ' 
            ' btnPrint
            ' 
            resources.ApplyResources(Me.btnPrint, "btnPrint")
            Me.btnPrint.ImageOptions.Image = CType((resources.GetObject("btnPrint.ImageOptions.Image")), System.Drawing.Image)
            Me.btnPrint.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
            Me.btnPrint.Name = "btnPrint"
            AddHandler Me.btnPrint.Click, New System.EventHandler(AddressOf Me.btnPrint_Click)
            ' 
            ' dvInfo
            ' 
            resources.ApplyResources(Me.dvInfo, "dvInfo")
            Me.dvInfo.AutoZoom = True
            Me.dvInfo.Name = "dvInfo"
            ' 
            ' bvtPrint
            ' 
            resources.ApplyResources(Me.bvtPrint, "bvtPrint")
            Me.bvtPrint.ContentControl = Me.bvPrint
            Me.bvtPrint.Name = "bvtPrint"
            Me.bvtPrint.Selected = True
            ' 
            ' bvbSave
            ' 
            resources.ApplyResources(Me.bvbSave, "bvbSave")
            Me.bvbSave.Name = "bvbSave"
            AddHandler Me.bvbSave.ItemClick, New DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(AddressOf Me.bvbSave_ItemClick)
            ' 
            ' bvbSaveAs
            ' 
            resources.ApplyResources(Me.bvbSaveAs, "bvbSaveAs")
            Me.bvbSaveAs.Name = "bvbSaveAs"
            AddHandler Me.bvbSaveAs.ItemClick, New DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(AddressOf Me.bvbSaveAs_ItemClick)
            ' 
            ' bvbClose
            ' 
            resources.ApplyResources(Me.bvbClose, "bvbClose")
            Me.bvbClose.Name = "bvbClose"
            AddHandler Me.bvbClose.ItemClick, New DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(AddressOf Me.bvbClose_ItemClick)
            ' 
            ' btnSaveAndClose
            ' 
            resources.ApplyResources(Me.btnSaveAndClose, "btnSaveAndClose")
            Me.btnSaveAndClose.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.btnSaveAndClose.Id = 3
            Me.btnSaveAndClose.ImageOptions.Image = CType((resources.GetObject("btnSaveAndClose.ImageOptions.Image")), System.Drawing.Image)
            Me.btnSaveAndClose.ImageOptions.LargeImage = CType((resources.GetObject("btnSaveAndClose.ImageOptions.LargeImage")), System.Drawing.Image)
            Me.btnSaveAndClose.ImageOptions.SvgImage = Global.DevExpress.XtraScheduler.Demos.Properties.Resources.SaveAndClose2
            Me.btnSaveAndClose.Name = "btnSaveAndClose"
            AddHandler Me.btnSaveAndClose.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.btnSaveAndClose_ItemClick)
            ' 
            ' btnDelete
            ' 
            resources.ApplyResources(Me.btnDelete, "btnDelete")
            Me.btnDelete.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.btnDelete.Id = 4
            Me.btnDelete.ImageOptions.Image = CType((resources.GetObject("btnDelete.ImageOptions.Image")), System.Drawing.Image)
            Me.btnDelete.ImageOptions.LargeImage = CType((resources.GetObject("btnDelete.ImageOptions.LargeImage")), System.Drawing.Image)
            Me.btnDelete.ImageOptions.SvgImage = Global.DevExpress.XtraScheduler.Demos.Properties.Resources.Delete
            Me.btnDelete.Name = "btnDelete"
            AddHandler Me.btnDelete.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.barButtonDelete_ItemClick)
            ' 
            ' barLabel
            ' 
            resources.ApplyResources(Me.barLabel, "barLabel")
            Me.barLabel.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.barLabel.Edit = Me.riAppointmentLabel
            Me.barLabel.Id = 8
            Me.barLabel.Name = "barLabel"
            Me.barLabel.RibbonStyle = CType((((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
            ' 
            ' riAppointmentLabel
            ' 
            resources.ApplyResources(Me.riAppointmentLabel, "riAppointmentLabel")
            Me.riAppointmentLabel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("riAppointmentLabel.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.riAppointmentLabel.Name = "riAppointmentLabel"
            ' 
            ' barStatus
            ' 
            resources.ApplyResources(Me.barStatus, "barStatus")
            Me.barStatus.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.barStatus.Edit = Me.riAppointmentStatus
            Me.barStatus.Id = 11
            Me.barStatus.Name = "barStatus"
            ' 
            ' riAppointmentStatus
            ' 
            resources.ApplyResources(Me.riAppointmentStatus, "riAppointmentStatus")
            Me.riAppointmentStatus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("riAppointmentStatus.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.riAppointmentStatus.Name = "riAppointmentStatus"
            ' 
            ' barReminder
            ' 
            resources.ApplyResources(Me.barReminder, "barReminder")
            Me.barReminder.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.barReminder.Edit = Me.riDuration
            Me.barReminder.Id = 12
            Me.barReminder.Name = "barReminder"
            ' 
            ' riDuration
            ' 
            resources.ApplyResources(Me.riDuration, "riDuration")
            Me.riDuration.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("riDuration.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.riDuration.Name = "riDuration"
            Me.riDuration.ShowEmptyItem = True
            ' 
            ' btnRecurrence
            ' 
            Me.btnRecurrence.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            resources.ApplyResources(Me.btnRecurrence, "btnRecurrence")
            Me.btnRecurrence.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.btnRecurrence.Id = 17
            Me.btnRecurrence.ImageOptions.Image = CType((resources.GetObject("btnRecurrence.ImageOptions.Image")), System.Drawing.Image)
            Me.btnRecurrence.ImageOptions.LargeImage = CType((resources.GetObject("btnRecurrence.ImageOptions.LargeImage")), System.Drawing.Image)
            Me.btnRecurrence.ImageOptions.SvgImage = Global.DevExpress.XtraScheduler.Demos.Properties.Resources.Recurrence
            Me.btnRecurrence.Name = "btnRecurrence"
            AddHandler Me.btnRecurrence.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.barRecurrence_ItemClick)
            ' 
            ' btnSave
            ' 
            resources.ApplyResources(Me.btnSave, "btnSave")
            Me.btnSave.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.btnSave.Id = 1
            Me.btnSave.ImageOptions.Image = CType((resources.GetObject("btnSave.ImageOptions.Image")), System.Drawing.Image)
            Me.btnSave.ImageOptions.SvgImage = Global.DevExpress.XtraScheduler.Demos.Properties.Resources.Save
            Me.btnSave.Name = "btnSave"
            AddHandler Me.btnSave.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.btnSave_ItemClick)
            ' 
            ' btnNext
            ' 
            resources.ApplyResources(Me.btnNext, "btnNext")
            Me.btnNext.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.btnNext.Id = 3
            Me.btnNext.ImageOptions.Image = CType((resources.GetObject("btnNext.ImageOptions.Image")), System.Drawing.Image)
            Me.btnNext.ImageOptions.LargeImage = CType((resources.GetObject("btnNext.ImageOptions.LargeImage")), System.Drawing.Image)
            Me.btnNext.ImageOptions.SvgImage = Global.DevExpress.XtraScheduler.Demos.Properties.Resources.Down
            Me.btnNext.Name = "btnNext"
            AddHandler Me.btnNext.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.btnNext_ItemClick)
            ' 
            ' btnPrevious
            ' 
            resources.ApplyResources(Me.btnPrevious, "btnPrevious")
            Me.btnPrevious.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.btnPrevious.Id = 4
            Me.btnPrevious.ImageOptions.Image = CType((resources.GetObject("btnPrevious.ImageOptions.Image")), System.Drawing.Image)
            Me.btnPrevious.ImageOptions.LargeImage = CType((resources.GetObject("btnPrevious.ImageOptions.LargeImage")), System.Drawing.Image)
            Me.btnPrevious.ImageOptions.SvgImage = Global.DevExpress.XtraScheduler.Demos.Properties.Resources.Up
            Me.btnPrevious.Name = "btnPrevious"
            AddHandler Me.btnPrevious.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.btnPrevious_ItemClick)
            ' 
            ' btnTimeZones
            ' 
            Me.btnTimeZones.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            resources.ApplyResources(Me.btnTimeZones, "btnTimeZones")
            Me.btnTimeZones.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.btnTimeZones.Id = 1
            Me.btnTimeZones.ImageOptions.Image = CType((resources.GetObject("btnTimeZones.ImageOptions.Image")), System.Drawing.Image)
            Me.btnTimeZones.ImageOptions.LargeImage = CType((resources.GetObject("btnTimeZones.ImageOptions.LargeImage")), System.Drawing.Image)
            Me.btnTimeZones.ImageOptions.SvgImage = Global.DevExpress.XtraScheduler.Demos.Properties.Resources.Scheduler_TimeZones
            Me.btnTimeZones.Name = "btnTimeZones"
            AddHandler Me.btnTimeZones.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.btnTimeZones_ItemClick)
            ' 
            ' bbiCategorize
            ' 
            Me.bbiCategorize.ActAsDropDown = True
            Me.bbiCategorize.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            resources.ApplyResources(Me.bbiCategorize, "bbiCategorize")
            Me.bbiCategorize.DropDownControl = Me.pmCategorize
            Me.bbiCategorize.Id = 5
            Me.bbiCategorize.ImageOptions.Image = CType((resources.GetObject("bbiCategorize.ImageOptions.Image")), System.Drawing.Image)
            Me.bbiCategorize.ImageOptions.LargeImage = CType((resources.GetObject("bbiCategorize.ImageOptions.LargeImage")), System.Drawing.Image)
            Me.bbiCategorize.ImageOptions.SvgImage = Global.DevExpress.XtraScheduler.Demos.Properties.Resources.Scheduler_Categorize
            Me.bbiCategorize.Name = "bbiCategorize"
            ' 
            ' pmCategorize
            ' 
            Me.pmCategorize.Name = "pmCategorize"
            Me.pmCategorize.Ribbon = Me.ribbonControl1
            ' 
            ' btnIsPrivate
            ' 
            Me.btnIsPrivate.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            resources.ApplyResources(Me.btnIsPrivate, "btnIsPrivate")
            Me.btnIsPrivate.Id = 6
            Me.btnIsPrivate.ImageOptions.SvgImage = Global.DevExpress.XtraScheduler.Demos.Properties.Resources.[Private]
            Me.btnIsPrivate.Name = "btnIsPrivate"
            Me.btnIsPrivate.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
            AddHandler Me.btnIsPrivate.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnBtnIsPrivateItemClick)
            ' 
            ' btnHighImportance
            ' 
            Me.btnHighImportance.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            resources.ApplyResources(Me.btnHighImportance, "btnHighImportance")
            Me.btnHighImportance.Id = 7
            Me.btnHighImportance.ImageOptions.SvgImage = Global.DevExpress.XtraScheduler.Demos.Properties.Resources.HighImportance
            Me.btnHighImportance.Name = "btnHighImportance"
            Me.btnHighImportance.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
            AddHandler Me.btnHighImportance.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnBtnHightImportanceItemClick)
            ' 
            ' btnLowImportance
            ' 
            Me.btnLowImportance.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            resources.ApplyResources(Me.btnLowImportance, "btnLowImportance")
            Me.btnLowImportance.Id = 8
            Me.btnLowImportance.ImageOptions.SvgImage = Global.DevExpress.XtraScheduler.Demos.Properties.Resources.LowImportance
            Me.btnLowImportance.Name = "btnLowImportance"
            Me.btnLowImportance.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
            AddHandler Me.btnLowImportance.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnBtnLowImportanceItemClick)
            ' 
            ' rpAppointment
            ' 
            Me.rpAppointment.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgActions, Me.rpgOptions, Me.rpgTags})
            Me.rpAppointment.Name = "rpAppointment"
            resources.ApplyResources(Me.rpAppointment, "rpAppointment")
            ' 
            ' rpgActions
            ' 
            Me.rpgActions.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.rpgActions.ItemLinks.Add(Me.btnSaveAndClose)
            Me.rpgActions.ItemLinks.Add(Me.btnDelete)
            Me.rpgActions.Name = "rpgActions"
            resources.ApplyResources(Me.rpgActions, "rpgActions")
            ' 
            ' rpgOptions
            ' 
            Me.rpgOptions.AllowTextClipping = False
            Me.rpgOptions.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.rpgOptions.ItemLinks.Add(Me.barStatus)
            Me.rpgOptions.ItemLinks.Add(Me.barReminder)
            Me.rpgOptions.ItemLinks.Add(Me.btnRecurrence, "C")
            Me.rpgOptions.ItemLinks.Add(Me.btnTimeZones)
            Me.rpgOptions.Name = "rpgOptions"
            resources.ApplyResources(Me.rpgOptions, "rpgOptions")
            ' 
            ' rpgTags
            ' 
            Me.rpgTags.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.rpgTags.ItemLinks.Add(Me.bbiCategorize)
            Me.rpgTags.ItemLinks.Add(Me.btnIsPrivate)
            Me.rpgTags.ItemLinks.Add(Me.btnHighImportance)
            Me.rpgTags.ItemLinks.Add(Me.btnLowImportance)
            Me.rpgTags.Name = "rpgTags"
            resources.ApplyResources(Me.rpgTags, "rpgTags")
            ' 
            ' riAppointmentResource
            ' 
            resources.ApplyResources(Me.riAppointmentResource, "riAppointmentResource")
            Me.riAppointmentResource.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("riAppointmentResource.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.riAppointmentResource.Name = "riAppointmentResource"
            ' 
            ' repositoryItemAppointmentLabel1
            ' 
            resources.ApplyResources(Me.repositoryItemAppointmentLabel1, "repositoryItemAppointmentLabel1")
            Me.repositoryItemAppointmentLabel1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemAppointmentLabel1.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemAppointmentLabel1.Name = "repositoryItemAppointmentLabel1"
            ' 
            ' panelMain
            ' 
            resources.ApplyResources(Me.panelMain, "panelMain")
            Me.panelMain.Name = "panelMain"
            ' 
            ' panelDescription
            ' 
            resources.ApplyResources(Me.panelDescription, "panelDescription")
            Me.panelDescription.Name = "panelDescription"
            ' 
            ' changeAppointmentLabelItem2
            ' 
            resources.ApplyResources(Me.changeAppointmentLabelItem2, "changeAppointmentLabelItem2")
            Me.changeAppointmentLabelItem2.ColorizeGlyph = False
            Me.changeAppointmentLabelItem2.Enabled = False
            Me.changeAppointmentLabelItem2.Id = 39
            Me.changeAppointmentLabelItem2.ImageOptions.Image = CType((resources.GetObject("changeAppointmentLabelItem2.ImageOptions.Image")), System.Drawing.Image)
            Me.changeAppointmentLabelItem2.ImageOptions.LargeImage = CType((resources.GetObject("changeAppointmentLabelItem2.ImageOptions.LargeImage")), System.Drawing.Image)
            Me.changeAppointmentLabelItem2.Name = "changeAppointmentLabelItem2"
            ' 
            ' changeAppointmentLabelItem3
            ' 
            resources.ApplyResources(Me.changeAppointmentLabelItem3, "changeAppointmentLabelItem3")
            Me.changeAppointmentLabelItem3.ColorizeGlyph = False
            Me.changeAppointmentLabelItem3.Enabled = False
            Me.changeAppointmentLabelItem3.Id = 39
            Me.changeAppointmentLabelItem3.ImageOptions.Image = CType((resources.GetObject("changeAppointmentLabelItem3.ImageOptions.Image")), System.Drawing.Image)
            Me.changeAppointmentLabelItem3.ImageOptions.LargeImage = CType((resources.GetObject("changeAppointmentLabelItem3.ImageOptions.LargeImage")), System.Drawing.Image)
            Me.changeAppointmentLabelItem3.Name = "changeAppointmentLabelItem3"
            ' 
            ' tablePanel1
            ' 
            Me.tablePanel1.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 20F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F)})
            Me.tablePanel1.Controls.Add(Me.tablePanel2)
            Me.tablePanel1.Controls.Add(Me.tbDescription)
            Me.tablePanel1.Controls.Add(Me.panel1)
            Me.tablePanel1.Controls.Add(Me.edtTimeZone)
            Me.tablePanel1.Controls.Add(Me.lblPercentComplete)
            Me.tablePanel1.Controls.Add(Me.lblSubject)
            Me.tablePanel1.Controls.Add(Me.lblResource)
            Me.tablePanel1.Controls.Add(Me.lblEndTime)
            Me.tablePanel1.Controls.Add(Me.chkAllDay)
            Me.tablePanel1.Controls.Add(Me.edtEndDate)
            Me.tablePanel1.Controls.Add(Me.lblStartTime)
            Me.tablePanel1.Controls.Add(Me.edtEndTime)
            Me.tablePanel1.Controls.Add(Me.tbSubject)
            Me.tablePanel1.Controls.Add(Me.lblLocation)
            Me.tablePanel1.Controls.Add(Me.edtStartDate)
            Me.tablePanel1.Controls.Add(Me.tbLocation)
            Me.tablePanel1.Controls.Add(Me.edtStartTime)
            resources.ApplyResources(Me.tablePanel1, "tablePanel1")
            Me.tablePanel1.Name = "tablePanel1"
            Me.tablePanel1.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 8F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 8F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 16F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)})
            ' 
            ' tablePanel2
            ' 
            resources.ApplyResources(Me.tablePanel2, "tablePanel2")
            Me.tablePanel1.SetColumn(Me.tablePanel2, 2)
            Me.tablePanel2.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 20F)})
            Me.tablePanel1.SetColumnSpan(Me.tablePanel2, 6)
            Me.tablePanel2.Controls.Add(Me.tbProgress)
            Me.tablePanel2.Controls.Add(Me.lblPercentCompleteValue)
            Me.tablePanel2.Name = "tablePanel2"
            Me.tablePanel1.SetRow(Me.tablePanel2, 6)
            Me.tablePanel2.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)})
            ' 
            ' tbProgress
            ' 
            Me.tablePanel2.SetColumn(Me.tbProgress, 0)
            resources.ApplyResources(Me.tbProgress, "tbProgress")
            Me.tbProgress.Name = "tbProgress"
            Me.tbProgress.Properties.AutoSize = False
            Me.tbProgress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.tbProgress.Properties.Maximum = 100
            Me.tbProgress.Properties.ShowValueToolTip = True
            Me.tbProgress.Properties.TickFrequency = 10
            Me.tablePanel2.SetRow(Me.tbProgress, 0)
            ' 
            ' lblPercentCompleteValue
            ' 
            resources.ApplyResources(Me.lblPercentCompleteValue, "lblPercentCompleteValue")
            Me.lblPercentCompleteValue.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.lblPercentCompleteValue.Appearance.Options.UseBackColor = True
            Me.tablePanel2.SetColumn(Me.lblPercentCompleteValue, 1)
            Me.lblPercentCompleteValue.Name = "lblPercentCompleteValue"
            Me.tablePanel2.SetRow(Me.lblPercentCompleteValue, 0)
            ' 
            ' tbDescription
            ' 
            Me.tablePanel1.SetColumn(Me.tbDescription, 0)
            Me.tablePanel1.SetColumnSpan(Me.tbDescription, 8)
            resources.ApplyResources(Me.tbDescription, "tbDescription")
            Me.tbDescription.Name = "tbDescription"
            Me.tbDescription.Properties.AccessibleName = resources.GetString("tbDescription.Properties.AccessibleName")
            Me.tbDescription.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Client
            Me.tablePanel1.SetRow(Me.tbDescription, 7)
            ' 
            ' panel1
            ' 
            Me.panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.tablePanel1.SetColumn(Me.panel1, 6)
            Me.panel1.Controls.Add(Me.edtResource)
            Me.panel1.Controls.Add(Me.edtResources)
            resources.ApplyResources(Me.panel1, "panel1")
            Me.panel1.Name = "panel1"
            Me.tablePanel1.SetRow(Me.panel1, 1)
            ' 
            ' edtResource
            ' 
            resources.ApplyResources(Me.edtResource, "edtResource")
            Me.edtResource.Name = "edtResource"
            Me.edtResource.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox
            Me.edtResource.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("edtResource.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            ' 
            ' edtResources
            ' 
            resources.ApplyResources(Me.edtResources, "edtResources")
            Me.edtResources.Name = "edtResources"
            Me.edtResources.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("edtResources.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            ' 
            ' 
            ' 
            Me.edtResources.ResourcesCheckedListBoxControl.Location = CType((resources.GetObject("edtResources.ResourcesCheckedListBoxControl.Location")), System.Drawing.Point)
            Me.edtResources.ResourcesCheckedListBoxControl.Name = ""
            Me.edtResources.ResourcesCheckedListBoxControl.TabIndex =(CInt((resources.GetObject("edtResources.ResourcesCheckedListBoxControl.TabIndex"))))
            ' 
            ' edtTimeZone
            ' 
            Me.tablePanel1.SetColumn(Me.edtTimeZone, 4)
            Me.tablePanel1.SetColumnSpan(Me.edtTimeZone, 3)
            resources.ApplyResources(Me.edtTimeZone, "edtTimeZone")
            Me.edtTimeZone.MenuManager = Me.ribbonControl1
            Me.edtTimeZone.Name = "edtTimeZone"
            Me.edtTimeZone.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("edtTimeZone.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.tablePanel1.SetRow(Me.edtTimeZone, 4)
            ' 
            ' lblPercentComplete
            ' 
            resources.ApplyResources(Me.lblPercentComplete, "lblPercentComplete")
            Me.lblPercentComplete.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.lblPercentComplete.Appearance.Options.UseBackColor = True
            Me.tablePanel1.SetColumn(Me.lblPercentComplete, 0)
            Me.lblPercentComplete.Name = "lblPercentComplete"
            Me.tablePanel1.SetRow(Me.lblPercentComplete, 6)
            ' 
            ' lblSubject
            ' 
            resources.ApplyResources(Me.lblSubject, "lblSubject")
            Me.tablePanel1.SetColumn(Me.lblSubject, 0)
            Me.lblSubject.Name = "lblSubject"
            Me.tablePanel1.SetRow(Me.lblSubject, 0)
            ' 
            ' lblResource
            ' 
            resources.ApplyResources(Me.lblResource, "lblResource")
            Me.tablePanel1.SetColumn(Me.lblResource, 4)
            Me.lblResource.Name = "lblResource"
            Me.tablePanel1.SetRow(Me.lblResource, 1)
            ' 
            ' lblEndTime
            ' 
            resources.ApplyResources(Me.lblEndTime, "lblEndTime")
            Me.tablePanel1.SetColumn(Me.lblEndTime, 0)
            Me.lblEndTime.Name = "lblEndTime"
            Me.tablePanel1.SetRow(Me.lblEndTime, 4)
            ' 
            ' chkAllDay
            ' 
            Me.tablePanel1.SetColumn(Me.chkAllDay, 4)
            Me.tablePanel1.SetColumnSpan(Me.chkAllDay, 3)
            resources.ApplyResources(Me.chkAllDay, "chkAllDay")
            Me.chkAllDay.Name = "chkAllDay"
            Me.chkAllDay.Properties.AccessibleName = resources.GetString("chkAllDay.Properties.AccessibleName")
            Me.chkAllDay.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton
            Me.chkAllDay.Properties.AutoWidth = True
            Me.chkAllDay.Properties.Caption = resources.GetString("chkAllDay.Properties.Caption")
            Me.tablePanel1.SetRow(Me.chkAllDay, 3)
            ' 
            ' edtEndDate
            ' 
            Me.tablePanel1.SetColumn(Me.edtEndDate, 2)
            resources.ApplyResources(Me.edtEndDate, "edtEndDate")
            Me.edtEndDate.Name = "edtEndDate"
            Me.edtEndDate.Properties.AccessibleName = resources.GetString("edtEndDate.Properties.AccessibleName")
            Me.edtEndDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("edtEndDate.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.edtEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.edtEndDate.Properties.MaxDate = New System.DateTime(4000, 1, 1, 0, 0, 0, 0)
            Me.tablePanel1.SetRow(Me.edtEndDate, 4)
            ' 
            ' lblStartTime
            ' 
            resources.ApplyResources(Me.lblStartTime, "lblStartTime")
            Me.tablePanel1.SetColumn(Me.lblStartTime, 0)
            Me.lblStartTime.Name = "lblStartTime"
            Me.tablePanel1.SetRow(Me.lblStartTime, 3)
            ' 
            ' edtEndTime
            ' 
            Me.tablePanel1.SetColumn(Me.edtEndTime, 3)
            resources.ApplyResources(Me.edtEndTime, "edtEndTime")
            Me.edtEndTime.Name = "edtEndTime"
            Me.edtEndTime.Properties.AccessibleName = resources.GetString("edtEndTime.Properties.AccessibleName")
            Me.edtEndTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.edtEndTime.Properties.MaskSettings.[Set]("mask", "t")
            Me.tablePanel1.SetRow(Me.edtEndTime, 4)
            ' 
            ' tbSubject
            ' 
            Me.tablePanel1.SetColumn(Me.tbSubject, 2)
            Me.tablePanel1.SetColumnSpan(Me.tbSubject, 6)
            resources.ApplyResources(Me.tbSubject, "tbSubject")
            Me.tbSubject.Name = "tbSubject"
            Me.tbSubject.Properties.AccessibleName = resources.GetString("tbSubject.Properties.AccessibleName")
            Me.tablePanel1.SetRow(Me.tbSubject, 0)
            ' 
            ' lblLocation
            ' 
            resources.ApplyResources(Me.lblLocation, "lblLocation")
            Me.tablePanel1.SetColumn(Me.lblLocation, 0)
            Me.lblLocation.Name = "lblLocation"
            Me.tablePanel1.SetRow(Me.lblLocation, 1)
            ' 
            ' edtStartDate
            ' 
            Me.tablePanel1.SetColumn(Me.edtStartDate, 2)
            resources.ApplyResources(Me.edtStartDate, "edtStartDate")
            Me.edtStartDate.Name = "edtStartDate"
            Me.edtStartDate.Properties.AccessibleName = resources.GetString("edtStartDate.Properties.AccessibleName")
            Me.edtStartDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("edtStartDate.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.edtStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.edtStartDate.Properties.MaxDate = New System.DateTime(4000, 1, 1, 0, 0, 0, 0)
            Me.tablePanel1.SetRow(Me.edtStartDate, 3)
            ' 
            ' tbLocation
            ' 
            Me.tablePanel1.SetColumn(Me.tbLocation, 2)
            Me.tablePanel1.SetColumnSpan(Me.tbLocation, 2)
            resources.ApplyResources(Me.tbLocation, "tbLocation")
            Me.tbLocation.Name = "tbLocation"
            Me.tbLocation.Properties.AccessibleName = resources.GetString("tbLocation.Properties.AccessibleName")
            Me.tablePanel1.SetRow(Me.tbLocation, 1)
            ' 
            ' edtStartTime
            ' 
            Me.tablePanel1.SetColumn(Me.edtStartTime, 3)
            resources.ApplyResources(Me.edtStartTime, "edtStartTime")
            Me.edtStartTime.Name = "edtStartTime"
            Me.edtStartTime.Properties.AccessibleName = resources.GetString("edtStartTime.Properties.AccessibleName")
            Me.edtStartTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.edtStartTime.Properties.MaskSettings.[Set]("mask", "t")
            Me.tablePanel1.SetRow(Me.edtStartTime, 3)
            ' 
            ' barEditItem1
            ' 
            resources.ApplyResources(Me.barEditItem1, "barEditItem1")
            Me.barEditItem1.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.barEditItem1.Edit = Me.riAppointmentLabel
            Me.barEditItem1.Id = 8
            Me.barEditItem1.Name = "barEditItem1"
            ' 
            ' barEditItem2
            ' 
            resources.ApplyResources(Me.barEditItem2, "barEditItem2")
            Me.barEditItem2.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.barEditItem2.Edit = Me.riAppointmentLabel
            Me.barEditItem2.Id = 8
            Me.barEditItem2.Name = "barEditItem2"
            ' 
            ' OutlookAppointmentForm
            ' 
            Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.tablePanel1)
            Me.Controls.Add(Me.backstageViewControl1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "OutlookAppointmentForm"
            Me.Ribbon = Me.ribbonControl1
            Me.ShowInTaskbar = False
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.backstageViewControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.backstageViewControl1.ResumeLayout(False)
            Me.bvPrint.ResumeLayout(False)
            CType((Me.riAppointmentLabel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.riAppointmentStatus), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.riDuration), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pmCategorize), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.riAppointmentResource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemAppointmentLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tablePanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tablePanel1.ResumeLayout(False)
            Me.tablePanel1.PerformLayout()
            CType((Me.tablePanel2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tablePanel2.ResumeLayout(False)
            Me.tablePanel2.PerformLayout()
            CType((Me.tbProgress.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tbProgress), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tbDescription.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            CType((Me.edtResource.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.edtResources.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.edtResources.ResourcesCheckedListBoxControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.edtTimeZone.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkAllDay.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.edtEndDate.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.edtEndDate.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.edtEndTime.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tbSubject.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.edtStartDate.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.edtStartDate.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tbLocation.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.edtStartTime.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer = Nothing

        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl

        Private rpAppointment As DevExpress.XtraBars.Ribbon.RibbonPage

        Private rpgActions As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private rpgOptions As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private btnSaveAndClose As DevExpress.XtraBars.BarButtonItem

        Private btnDelete As DevExpress.XtraBars.BarButtonItem

        Private barLabel As DevExpress.XtraBars.BarEditItem

        Private riAppointmentLabel As DevExpress.XtraScheduler.UI.RepositoryItemAppointmentLabel

        Private riAppointmentResource As DevExpress.XtraScheduler.UI.RepositoryItemAppointmentResource

        Private barStatus As DevExpress.XtraBars.BarEditItem

        Private riAppointmentStatus As DevExpress.XtraScheduler.UI.RepositoryItemAppointmentStatus

        Private barReminder As DevExpress.XtraBars.BarEditItem

        Private riDuration As DevExpress.XtraScheduler.UI.RepositoryItemDuration

        Private btnRecurrence As DevExpress.XtraBars.BarButtonItem

        Private panelMain As System.Windows.Forms.Panel

        Private panelDescription As System.Windows.Forms.Panel

        Private backstageViewControl1 As DevExpress.XtraBars.Ribbon.BackstageViewControl

        Private bvbSave As DevExpress.XtraBars.Ribbon.BackstageViewButtonItem

        Private bvbSaveAs As DevExpress.XtraBars.Ribbon.BackstageViewButtonItem

        Private bvbClose As DevExpress.XtraBars.Ribbon.BackstageViewButtonItem

        Private btnSave As DevExpress.XtraBars.BarButtonItem

        Private btnNext As DevExpress.XtraBars.BarButtonItem

        Private btnPrevious As DevExpress.XtraBars.BarButtonItem

        Private btnTimeZones As DevExpress.XtraBars.BarButtonItem

        Private bvPrint As DevExpress.XtraBars.Ribbon.BackstageViewClientControl

        Private bvtPrint As DevExpress.XtraBars.Ribbon.BackstageViewTabItem

        Private dvInfo As DevExpress.XtraPrinting.Preview.DocumentViewer

        Private btnPrint As DevExpress.XtraEditors.SimpleButton

        Private rpgTags As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private repositoryItemAppointmentLabel1 As DevExpress.XtraScheduler.UI.RepositoryItemAppointmentLabel

        Private changeAppointmentLabelItem2 As DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem

        Private changeAppointmentLabelItem3 As DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem

        Private bbiCategorize As DevExpress.XtraBars.BarButtonItem

        Private pmCategorize As DevExpress.XtraBars.PopupMenu

        Private btnIsPrivate As DevExpress.XtraBars.BarButtonItem

        Private btnHighImportance As DevExpress.XtraBars.BarButtonItem

        Private btnLowImportance As DevExpress.XtraBars.BarButtonItem

        Private tablePanel1 As DevExpress.Utils.Layout.TablePanel

        Private tablePanel2 As DevExpress.Utils.Layout.TablePanel

        Protected tbProgress As DevExpress.XtraEditors.TrackBarControl

        Protected lblPercentCompleteValue As DevExpress.XtraEditors.LabelControl

        Protected tbDescription As DevExpress.XtraEditors.MemoEdit

        Protected panel1 As DevExpress.XtraEditors.PanelControl

        Protected edtResource As DevExpress.XtraScheduler.UI.AppointmentResourceEdit

        Protected edtResources As DevExpress.XtraScheduler.UI.AppointmentResourcesEdit

        Private edtTimeZone As DevExpress.XtraScheduler.UI.TimeZoneEdit

        Protected lblPercentComplete As DevExpress.XtraEditors.LabelControl

        Protected lblSubject As DevExpress.XtraEditors.LabelControl

        Protected lblResource As DevExpress.XtraEditors.LabelControl

        Protected lblEndTime As DevExpress.XtraEditors.LabelControl

        Protected chkAllDay As DevExpress.XtraEditors.CheckEdit

        Protected edtEndDate As DevExpress.XtraEditors.DateEdit

        Protected lblStartTime As DevExpress.XtraEditors.LabelControl

        Protected edtEndTime As DevExpress.XtraEditors.TimeEdit

        Protected tbSubject As DevExpress.XtraEditors.TextEdit

        Protected lblLocation As DevExpress.XtraEditors.LabelControl

        Protected edtStartDate As DevExpress.XtraEditors.DateEdit

        Protected tbLocation As DevExpress.XtraEditors.TextEdit

        Protected edtStartTime As DevExpress.XtraEditors.TimeEdit

        Private barEditItem1 As DevExpress.XtraBars.BarEditItem

        Private barEditItem2 As DevExpress.XtraBars.BarEditItem
    End Class
End Namespace
