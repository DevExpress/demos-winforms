Imports DevExpress.XtraScheduler.UI

Namespace Modules

    Partial Class MedicalAppointmentForm

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modules.MedicalAppointmentForm))
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
            Me.rpAppointment = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.rpgActions = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.rpgOptions = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.riAppointmentResource = New DevExpress.XtraScheduler.UI.RepositoryItemAppointmentResource()
            Me.lblStartTime = New DevExpress.XtraEditors.LabelControl()
            Me.edtStartDate = New DevExpress.XtraEditors.DateEdit()
            Me.tbLocation = New DevExpress.XtraEditors.TextEdit()
            Me.edtStartTime = New DevExpress.XtraScheduler.UI.SchedulerTimeEdit()
            Me.lblEndTime = New DevExpress.XtraEditors.LabelControl()
            Me.edtEndDate = New DevExpress.XtraEditors.DateEdit()
            Me.edtEndTime = New DevExpress.XtraScheduler.UI.SchedulerTimeEdit()
            Me.lblLocation = New DevExpress.XtraEditors.LabelControl()
            Me.edtResource = New DevExpress.XtraScheduler.UI.AppointmentResourceEdit()
            Me.panelMain = New System.Windows.Forms.Panel()
            Me.tbDescription = New DevExpress.XtraEditors.MemoEdit()
            Me.panelDescription = New System.Windows.Forms.Panel()
            Me.panel2 = New System.Windows.Forms.Panel()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.lbMedic = New DevExpress.XtraEditors.LabelControl()
            Me.lbDepartment = New DevExpress.XtraEditors.LabelControl()
            Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.lbMedicName = New DevExpress.XtraEditors.LabelControl()
            Me.edtBirthday = New DevExpress.XtraEditors.DateEdit()
            Me.lbBirthday = New DevExpress.XtraEditors.LabelControl()
            Me.lbPhone = New DevExpress.XtraEditors.LabelControl()
            Me.tbPhone = New DevExpress.XtraEditors.TextEdit()
            Me.edtPhoneMedic = New DevExpress.XtraEditors.TextEdit()
            Me.cmbPatient = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.lbPhoneMedic = New DevExpress.XtraEditors.LabelControl()
            Me.panel3 = New System.Windows.Forms.Panel()
            Me.lbAdditionalInformation = New DevExpress.XtraEditors.LabelControl()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.backstageViewControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.backstageViewControl1.SuspendLayout()
            Me.bvPrint.SuspendLayout()
            CType((Me.riAppointmentLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.riAppointmentStatus), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.riDuration), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.riAppointmentResource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.edtStartDate.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.edtStartDate.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tbLocation.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.edtStartTime.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.edtEndDate.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.edtEndDate.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.edtEndTime.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.edtResource.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tbDescription.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel2.SuspendLayout()
            Me.panel1.SuspendLayout()
            CType((Me.pictureEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.edtBirthday.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.edtBirthday.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tbPhone.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.edtPhoneMedic.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cmbPatient.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel3.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ApplicationButtonDropDownControl = Me.backstageViewControl1
            Me.ribbonControl1.AutoSizeItems = True
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.btnSaveAndClose, Me.btnDelete, Me.barLabel, Me.barStatus, Me.barReminder, Me.btnRecurrence, Me.btnSave, Me.btnNext, Me.btnPrevious, Me.btnTimeZones})
            resources.ApplyResources(Me.ribbonControl1, "ribbonControl1")
            Me.ribbonControl1.MaxItemId = 2
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rpAppointment})
            Me.ribbonControl1.QuickToolbarItemLinks.Add(Me.btnSave)
            Me.ribbonControl1.QuickToolbarItemLinks.Add(Me.btnPrevious)
            Me.ribbonControl1.QuickToolbarItemLinks.Add(Me.btnNext)
            Me.ribbonControl1.QuickToolbarItemLinks.Add(Me.btnDelete)
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riAppointmentLabel, Me.riAppointmentResource, Me.riAppointmentStatus, Me.riDuration})
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
            Me.btnPrint.Name = "btnPrint"
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
            Me.riDuration.DisabledStateText = Nothing
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
            Me.btnRecurrence.Name = "btnRecurrence"
            AddHandler Me.btnRecurrence.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.barRecurrence_ItemClick)
            ' 
            ' btnSave
            ' 
            resources.ApplyResources(Me.btnSave, "btnSave")
            Me.btnSave.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.btnSave.Id = 1
            Me.btnSave.ImageOptions.Image = CType((resources.GetObject("btnSave.ImageOptions.Image")), System.Drawing.Image)
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
            Me.btnTimeZones.Name = "btnTimeZones"
            AddHandler Me.btnTimeZones.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.btnTimeZones_ItemClick)
            ' 
            ' rpAppointment
            ' 
            Me.rpAppointment.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgActions, Me.rpgOptions})
            Me.rpAppointment.Name = "rpAppointment"
            resources.ApplyResources(Me.rpAppointment, "rpAppointment")
            ' 
            ' rpgActions
            ' 
            Me.rpgActions.AllowTextClipping = False
            Me.rpgActions.ItemLinks.Add(Me.btnSaveAndClose)
            Me.rpgActions.ItemLinks.Add(Me.btnDelete)
            Me.rpgActions.Name = "rpgActions"
            Me.rpgActions.ShowCaptionButton = False
            ' 
            ' rpgOptions
            ' 
            Me.rpgOptions.AllowTextClipping = False
            Me.rpgOptions.ItemLinks.Add(Me.barLabel)
            Me.rpgOptions.ItemLinks.Add(Me.barStatus)
            Me.rpgOptions.ItemLinks.Add(Me.barReminder)
            Me.rpgOptions.ItemLinks.Add(Me.btnRecurrence, "C")
            Me.rpgOptions.Name = "rpgOptions"
            Me.rpgOptions.ShowCaptionButton = False
            ' 
            ' riAppointmentResource
            ' 
            resources.ApplyResources(Me.riAppointmentResource, "riAppointmentResource")
            Me.riAppointmentResource.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("riAppointmentResource.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.riAppointmentResource.Name = "riAppointmentResource"
            ' 
            ' lblStartTime
            ' 
            resources.ApplyResources(Me.lblStartTime, "lblStartTime")
            Me.lblStartTime.Name = "lblStartTime"
            ' 
            ' edtStartDate
            ' 
            resources.ApplyResources(Me.edtStartDate, "edtStartDate")
            Me.edtStartDate.Name = "edtStartDate"
            Me.edtStartDate.Properties.AccessibleName = resources.GetString("edtStartDate.Properties.AccessibleName")
            Me.edtStartDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("edtStartDate.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.edtStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.edtStartDate.Properties.MaxValue = New System.DateTime(4000, 1, 1, 0, 0, 0, 0)
            ' 
            ' tbLocation
            ' 
            resources.ApplyResources(Me.tbLocation, "tbLocation")
            Me.tbLocation.Name = "tbLocation"
            Me.tbLocation.Properties.AccessibleName = resources.GetString("tbLocation.Properties.AccessibleName")
            ' 
            ' edtStartTime
            ' 
            resources.ApplyResources(Me.edtStartTime, "edtStartTime")
            Me.edtStartTime.Name = "edtStartTime"
            Me.edtStartTime.Properties.AccessibleName = resources.GetString("edtStartTime.Properties.AccessibleName")
            Me.edtStartTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.edtStartTime.Properties.Mask.EditMask = resources.GetString("edtStartTime.Properties.Mask.EditMask")
            ' 
            ' lblEndTime
            ' 
            resources.ApplyResources(Me.lblEndTime, "lblEndTime")
            Me.lblEndTime.Name = "lblEndTime"
            ' 
            ' edtEndDate
            ' 
            resources.ApplyResources(Me.edtEndDate, "edtEndDate")
            Me.edtEndDate.Name = "edtEndDate"
            Me.edtEndDate.Properties.AccessibleName = resources.GetString("edtEndDate.Properties.AccessibleName")
            Me.edtEndDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("edtEndDate.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.edtEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.edtEndDate.Properties.MaxValue = New System.DateTime(4000, 1, 1, 0, 0, 0, 0)
            ' 
            ' edtEndTime
            ' 
            resources.ApplyResources(Me.edtEndTime, "edtEndTime")
            Me.edtEndTime.Name = "edtEndTime"
            Me.edtEndTime.Properties.AccessibleName = resources.GetString("edtEndTime.Properties.AccessibleName")
            Me.edtEndTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.edtEndTime.Properties.Mask.EditMask = resources.GetString("edtEndTime.Properties.Mask.EditMask")
            ' 
            ' lblLocation
            ' 
            resources.ApplyResources(Me.lblLocation, "lblLocation")
            Me.lblLocation.Name = "lblLocation"
            ' 
            ' edtResource
            ' 
            resources.ApplyResources(Me.edtResource, "edtResource")
            Me.edtResource.Name = "edtResource"
            Me.edtResource.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox
            Me.edtResource.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("edtResource.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.edtResource.Properties.ShowEmptyResource = False
            ' 
            ' panelMain
            ' 
            resources.ApplyResources(Me.panelMain, "panelMain")
            Me.panelMain.Name = "panelMain"
            ' 
            ' tbDescription
            ' 
            resources.ApplyResources(Me.tbDescription, "tbDescription")
            Me.tbDescription.Name = "tbDescription"
            Me.tbDescription.Properties.AccessibleName = resources.GetString("tbDescription.Properties.AccessibleName")
            Me.tbDescription.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Client
            ' 
            ' panelDescription
            ' 
            resources.ApplyResources(Me.panelDescription, "panelDescription")
            Me.panelDescription.Name = "panelDescription"
            ' 
            ' panel2
            ' 
            Me.panel2.Controls.Add(Me.panel1)
            Me.panel2.Controls.Add(Me.labelControl1)
            Me.panel2.Controls.Add(Me.lbMedicName)
            Me.panel2.Controls.Add(Me.edtBirthday)
            Me.panel2.Controls.Add(Me.lbBirthday)
            Me.panel2.Controls.Add(Me.lbPhone)
            Me.panel2.Controls.Add(Me.tbPhone)
            Me.panel2.Controls.Add(Me.edtPhoneMedic)
            Me.panel2.Controls.Add(Me.tbLocation)
            Me.panel2.Controls.Add(Me.backstageViewControl1)
            Me.panel2.Controls.Add(Me.cmbPatient)
            Me.panel2.Controls.Add(Me.lblLocation)
            Me.panel2.Controls.Add(Me.lbPhoneMedic)
            Me.panel2.Controls.Add(Me.edtResource)
            Me.panel2.Controls.Add(Me.edtEndTime)
            Me.panel2.Controls.Add(Me.edtEndDate)
            Me.panel2.Controls.Add(Me.lblEndTime)
            Me.panel2.Controls.Add(Me.lblStartTime)
            Me.panel2.Controls.Add(Me.edtStartTime)
            Me.panel2.Controls.Add(Me.edtStartDate)
            resources.ApplyResources(Me.panel2, "panel2")
            Me.panel2.Name = "panel2"
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.lbMedic)
            Me.panel1.Controls.Add(Me.lbDepartment)
            Me.panel1.Controls.Add(Me.pictureEdit1)
            resources.ApplyResources(Me.panel1, "panel1")
            Me.panel1.Name = "panel1"
            ' 
            ' lbMedic
            ' 
            Me.lbMedic.Appearance.Font = CType((resources.GetObject("lbMedic.Appearance.Font")), System.Drawing.Font)
            Me.lbMedic.Appearance.Options.UseFont = True
            Me.lbMedic.Appearance.Options.UseTextOptions = True
            Me.lbMedic.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            resources.ApplyResources(Me.lbMedic, "lbMedic")
            Me.lbMedic.Name = "lbMedic"
            ' 
            ' lbDepartment
            ' 
            Me.lbDepartment.Appearance.Font = CType((resources.GetObject("lbDepartment.Appearance.Font")), System.Drawing.Font)
            Me.lbDepartment.Appearance.ForeColor = CType((resources.GetObject("lbDepartment.Appearance.ForeColor")), System.Drawing.Color)
            Me.lbDepartment.Appearance.Options.UseFont = True
            Me.lbDepartment.Appearance.Options.UseForeColor = True
            Me.lbDepartment.Appearance.Options.UseTextOptions = True
            Me.lbDepartment.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            resources.ApplyResources(Me.lbDepartment, "lbDepartment")
            Me.lbDepartment.Name = "lbDepartment"
            ' 
            ' pictureEdit1
            ' 
            Me.pictureEdit1.Cursor = System.Windows.Forms.Cursors.[Default]
            resources.ApplyResources(Me.pictureEdit1, "pictureEdit1")
            Me.pictureEdit1.MenuManager = Me.ribbonControl1
            Me.pictureEdit1.Name = "pictureEdit1"
            Me.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto
            Me.pictureEdit1.Properties.ShowMenu = False
            ' 
            ' labelControl1
            ' 
            resources.ApplyResources(Me.labelControl1, "labelControl1")
            Me.labelControl1.Name = "labelControl1"
            ' 
            ' lbMedicName
            ' 
            resources.ApplyResources(Me.lbMedicName, "lbMedicName")
            Me.lbMedicName.Name = "lbMedicName"
            ' 
            ' edtBirthday
            ' 
            resources.ApplyResources(Me.edtBirthday, "edtBirthday")
            Me.edtBirthday.MenuManager = Me.ribbonControl1
            Me.edtBirthday.Name = "edtBirthday"
            Me.edtBirthday.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("edtBirthday.Properties.CalendarTimeProperties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.edtBirthday.Properties.[ReadOnly] = True
            ' 
            ' lbBirthday
            ' 
            resources.ApplyResources(Me.lbBirthday, "lbBirthday")
            Me.lbBirthday.Name = "lbBirthday"
            ' 
            ' lbPhone
            ' 
            resources.ApplyResources(Me.lbPhone, "lbPhone")
            Me.lbPhone.Name = "lbPhone"
            ' 
            ' tbPhone
            ' 
            resources.ApplyResources(Me.tbPhone, "tbPhone")
            Me.tbPhone.MenuManager = Me.ribbonControl1
            Me.tbPhone.Name = "tbPhone"
            Me.tbPhone.Properties.[ReadOnly] = True
            ' 
            ' edtPhoneMedic
            ' 
            resources.ApplyResources(Me.edtPhoneMedic, "edtPhoneMedic")
            Me.edtPhoneMedic.MenuManager = Me.ribbonControl1
            Me.edtPhoneMedic.Name = "edtPhoneMedic"
            Me.edtPhoneMedic.Properties.[ReadOnly] = True
            ' 
            ' cmbPatient
            ' 
            resources.ApplyResources(Me.cmbPatient, "cmbPatient")
            Me.cmbPatient.MenuManager = Me.ribbonControl1
            Me.cmbPatient.Name = "cmbPatient"
            Me.cmbPatient.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("cmbPatient.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.cmbPatient.Properties.Sorted = True
            ' 
            ' lbPhoneMedic
            ' 
            resources.ApplyResources(Me.lbPhoneMedic, "lbPhoneMedic")
            Me.lbPhoneMedic.Name = "lbPhoneMedic"
            ' 
            ' panel3
            ' 
            Me.panel3.Controls.Add(Me.lbAdditionalInformation)
            Me.panel3.Controls.Add(Me.tbDescription)
            resources.ApplyResources(Me.panel3, "panel3")
            Me.panel3.Name = "panel3"
            ' 
            ' lbAdditionalInformation
            ' 
            resources.ApplyResources(Me.lbAdditionalInformation, "lbAdditionalInformation")
            Me.lbAdditionalInformation.Name = "lbAdditionalInformation"
            ' 
            ' MedicalAppointmentForm
            ' 
            Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panel3)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "MedicalAppointmentForm"
            Me.Ribbon = Me.ribbonControl1
            Me.ShowInTaskbar = False
            AddHandler Me.Activated, New System.EventHandler(AddressOf Me.OnAppointmentFormActivated)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.OutlookAppointmentForm_Load)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.backstageViewControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.backstageViewControl1.ResumeLayout(False)
            Me.bvPrint.ResumeLayout(False)
            CType((Me.riAppointmentLabel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.riAppointmentStatus), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.riDuration), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.riAppointmentResource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.edtStartDate.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.edtStartDate.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tbLocation.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.edtStartTime.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.edtEndDate.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.edtEndDate.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.edtEndTime.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.edtResource.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tbDescription.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            Me.panel1.ResumeLayout(False)
            CType((Me.pictureEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.edtBirthday.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.edtBirthday.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tbPhone.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.edtPhoneMedic.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cmbPatient.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel3.ResumeLayout(False)
            Me.panel3.PerformLayout()
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

        Protected lblStartTime As DevExpress.XtraEditors.LabelControl

        Protected edtStartDate As DevExpress.XtraEditors.DateEdit

        Protected tbLocation As DevExpress.XtraEditors.TextEdit

        Protected edtStartTime As DevExpress.XtraScheduler.UI.SchedulerTimeEdit

        Protected lblEndTime As DevExpress.XtraEditors.LabelControl

        Protected edtEndDate As DevExpress.XtraEditors.DateEdit

        Protected edtEndTime As DevExpress.XtraScheduler.UI.SchedulerTimeEdit

        Protected lblLocation As DevExpress.XtraEditors.LabelControl

        Protected edtResource As DevExpress.XtraScheduler.UI.AppointmentResourceEdit

        Private panelMain As System.Windows.Forms.Panel

        Protected tbDescription As DevExpress.XtraEditors.MemoEdit

        Private panelDescription As System.Windows.Forms.Panel

        Private panel2 As System.Windows.Forms.Panel

        Private panel3 As System.Windows.Forms.Panel

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

        Private edtBirthday As DevExpress.XtraEditors.DateEdit

        Private tbPhone As DevExpress.XtraEditors.TextEdit

        Private cmbPatient As DevExpress.XtraEditors.ImageComboBoxEdit

        Private lbPhone As DevExpress.XtraEditors.LabelControl

        Private lbBirthday As DevExpress.XtraEditors.LabelControl

        Private pictureEdit1 As DevExpress.XtraEditors.PictureEdit

        Private edtPhoneMedic As DevExpress.XtraEditors.TextEdit

        Private lbPhoneMedic As DevExpress.XtraEditors.LabelControl

        Private lbMedicName As DevExpress.XtraEditors.LabelControl

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private lbAdditionalInformation As DevExpress.XtraEditors.LabelControl

        Private lbMedic As DevExpress.XtraEditors.LabelControl

        Private lbDepartment As DevExpress.XtraEditors.LabelControl

        Private panel1 As System.Windows.Forms.Panel
    End Class
End Namespace
