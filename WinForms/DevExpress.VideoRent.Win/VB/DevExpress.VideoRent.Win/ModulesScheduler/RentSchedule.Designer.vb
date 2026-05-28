Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler

Namespace DevExpress.VideoRent.Win.ModulesScheduler
    Partial Public Class RentalCalendar
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim TimeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim TimeScaleYear1 As DevExpress.XtraScheduler.TimeScaleYear = New DevExpress.XtraScheduler.TimeScaleYear()
            Dim TimeScaleQuarter1 As DevExpress.XtraScheduler.TimeScaleQuarter = New DevExpress.XtraScheduler.TimeScaleQuarter()
            Dim TimeScaleMonth1 As DevExpress.XtraScheduler.TimeScaleMonth = New DevExpress.XtraScheduler.TimeScaleMonth()
            Dim TimeScaleWeek1 As DevExpress.XtraScheduler.TimeScaleWeek = New DevExpress.XtraScheduler.TimeScaleWeek()
            Dim TimeScaleDay1 As DevExpress.XtraScheduler.TimeScaleDay = New DevExpress.XtraScheduler.TimeScaleDay()
            Dim TimeScaleHour1 As DevExpress.XtraScheduler.TimeScaleHour = New DevExpress.XtraScheduler.TimeScaleHour()
            Dim TimeScaleFixedInterval1 As DevExpress.XtraScheduler.TimeScaleFixedInterval = New DevExpress.XtraScheduler.TimeScaleFixedInterval()
            Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Me.lcMain = New DevExpress.XtraLayout.LayoutControl()
            Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.resourcesCheckedListBoxControl1 = New DevExpress.XtraScheduler.UI.ResourcesCheckedListBoxControl()
            Me.dateNavigator1 = New DevExpress.XtraScheduler.DateNavigator()
            Me.resourcesComboBoxControl1 = New DevExpress.XtraScheduler.UI.ResourcesComboBoxControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            Me.xpcRents = New DevExpress.Xpo.XPCollection(Me.components)
            Me.xpcCustomers = New DevExpress.Xpo.XPCollection(Me.components)
            CType(Me.lcMain, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.lcMain.SuspendLayout()
            CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.resourcesCheckedListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dateNavigator1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.resourcesComboBoxControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xpcRents, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xpcCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lcMain
            '
            Me.lcMain.Controls.Add(Me.schedulerControl1)
            Me.lcMain.Controls.Add(Me.resourcesCheckedListBoxControl1)
            Me.lcMain.Controls.Add(Me.dateNavigator1)
            Me.lcMain.Controls.Add(Me.resourcesComboBoxControl1)
            Me.lcMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lcMain.Location = New System.Drawing.Point(0, 0)
            Me.lcMain.Name = "lcMain"
            Me.lcMain.Root = Me.layoutControlGroup1
            Me.lcMain.Size = New System.Drawing.Size(1035, 622)
            Me.lcMain.TabIndex = 0
            Me.lcMain.Text = "layoutControl1"
            '
            'schedulerControl1
            '
            Me.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Timeline
            Me.schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
            Me.schedulerControl1.Location = New System.Drawing.Point(208, 8)
            Me.schedulerControl1.Name = "schedulerControl1"
            Me.schedulerControl1.OptionsCustomization.AllowAppointmentCopy = DevExpress.XtraScheduler.UsedAppointmentType.None
            Me.schedulerControl1.OptionsCustomization.AllowAppointmentCreate = DevExpress.XtraScheduler.UsedAppointmentType.None
            Me.schedulerControl1.OptionsCustomization.AllowAppointmentDelete = DevExpress.XtraScheduler.UsedAppointmentType.None
            Me.schedulerControl1.OptionsCustomization.AllowAppointmentDrag = DevExpress.XtraScheduler.UsedAppointmentType.None
            Me.schedulerControl1.OptionsCustomization.AllowAppointmentDragBetweenResources = DevExpress.XtraScheduler.UsedAppointmentType.None
            Me.schedulerControl1.OptionsCustomization.AllowAppointmentResize = DevExpress.XtraScheduler.UsedAppointmentType.None
            Me.schedulerControl1.OptionsCustomization.AllowInplaceEditor = DevExpress.XtraScheduler.UsedAppointmentType.None
            Me.schedulerControl1.OptionsView.ResourceHeaders.ImageAlign = DevExpress.XtraScheduler.HeaderImageAlign.Top
            Me.schedulerControl1.OptionsView.ResourceHeaders.ImageInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
            Me.schedulerControl1.OptionsView.ResourceHeaders.ImageSize = New System.Drawing.Size(50, 80)
            Me.schedulerControl1.OptionsView.ResourceHeaders.ImageSizeMode = DevExpress.XtraScheduler.HeaderImageSizeMode.ZoomImage
            Me.schedulerControl1.OptionsView.ShowOnlyResourceAppointments = True
            Me.schedulerControl1.Size = New System.Drawing.Size(819, 606)
            Me.schedulerControl1.Start = New Date(2010, 7, 19, 0, 0, 0, 0)
            Me.schedulerControl1.DataStorage = Me.schedulerStorage1
            Me.schedulerControl1.TabIndex = 5
            Me.schedulerControl1.Text = "schedulerControl1"
            Me.schedulerControl1.Views.DayView.ResourcesPerPage = 4
            Me.schedulerControl1.Views.DayView.ShowWorkTimeOnly = True
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(TimeRuler1)
            Me.schedulerControl1.Views.GanttView.Enabled = False
            Me.schedulerControl1.Views.MonthView.ResourcesPerPage = 3
            Me.schedulerControl1.Views.MonthView.WeekCount = 2
            Me.schedulerControl1.Views.TimelineView.ResourcesPerPage = 4
            TimeScaleYear1.Enabled = False
            TimeScaleQuarter1.Enabled = False
            TimeScaleMonth1.Enabled = False
            TimeScaleDay1.Width = 75
            TimeScaleHour1.Enabled = False
            TimeScaleFixedInterval1.Enabled = False
            Me.schedulerControl1.Views.TimelineView.Scales.Add(TimeScaleYear1)
            Me.schedulerControl1.Views.TimelineView.Scales.Add(TimeScaleQuarter1)
            Me.schedulerControl1.Views.TimelineView.Scales.Add(TimeScaleMonth1)
            Me.schedulerControl1.Views.TimelineView.Scales.Add(TimeScaleWeek1)
            Me.schedulerControl1.Views.TimelineView.Scales.Add(TimeScaleDay1)
            Me.schedulerControl1.Views.TimelineView.Scales.Add(TimeScaleHour1)
            Me.schedulerControl1.Views.TimelineView.Scales.Add(TimeScaleFixedInterval1)
            Me.schedulerControl1.Views.WeekView.ResourcesPerPage = 3
            Me.schedulerControl1.Views.WorkWeekView.ResourcesPerPage = 3
            Me.schedulerControl1.Views.WorkWeekView.ShowWorkTimeOnly = True
            Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
            '
            'schedulerStorage1
            '
            Me.schedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("ReceiptType", "ReceiptType", DevExpress.XtraScheduler.FieldValueType.[Integer]))
            Me.schedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("MovieGenre", "MovieGenre", DevExpress.XtraScheduler.FieldValueType.[Integer]))
            Me.schedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("MovieRating", "MovieRating", DevExpress.XtraScheduler.FieldValueType.[Integer]))
            Me.schedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("ItemFormat", "ItemFormat", DevExpress.XtraScheduler.FieldValueType.[Integer]))
            Me.schedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("MoviePhoto", "MoviePhoto"))
            Me.schedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("MovieLanguage", "MovieLanguage", DevExpress.XtraScheduler.FieldValueType.[String]))
            Me.schedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("Payment", "Payment", DevExpress.XtraScheduler.FieldValueType.[Decimal]))
            Me.schedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("OverduePayment", "OverduePayment", DevExpress.XtraScheduler.FieldValueType.[Decimal]))
            Me.schedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("ReceiptOverdue", "ReceiptOverdue!"))
            Me.schedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("ReturnedOn", "ReturnedOn", DevExpress.XtraScheduler.FieldValueType.DateTime))
            Me.schedulerStorage1.Appointments.Labels.Add(System.Drawing.SystemColors.Window, "G", "&G")
            Me.schedulerStorage1.Appointments.Labels.Add(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(190, Byte), Integer)), "PG", "&PG")
            Me.schedulerStorage1.Appointments.Labels.Add(System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(255, Byte), Integer)), "PG13", "&PG13")
            Me.schedulerStorage1.Appointments.Labels.Add(System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(156, Byte), Integer)), "R", "&R")
            Me.schedulerStorage1.Appointments.Labels.Add(System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(199, Byte), Integer)), "NC17", "&NC17")
            Me.schedulerStorage1.Appointments.Mappings.Description = "MoviePlot"
            Me.schedulerStorage1.Appointments.Mappings.End = "ExpectedOn"
            Me.schedulerStorage1.Appointments.Mappings.Label = "MovieRating"
            Me.schedulerStorage1.Appointments.Mappings.ResourceId = "Customer!Key"
            Me.schedulerStorage1.Appointments.Mappings.Start = "RentedOn"
            Me.schedulerStorage1.Appointments.Mappings.Status = "ActiveType"
            Me.schedulerStorage1.Appointments.Mappings.Subject = "MovieTitle"
            Me.schedulerStorage1.Appointments.Statuses.Add(DevExpress.XtraScheduler.AppointmentStatusType.Custom, "None", "&None", System.Drawing.SystemColors.Window)
            Me.schedulerStorage1.Appointments.Statuses.Add(DevExpress.XtraScheduler.AppointmentStatusType.Custom, "Overdue", "&Overdue", System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)))
            Me.schedulerStorage1.Appointments.Statuses.Add(DevExpress.XtraScheduler.AppointmentStatusType.Custom, "Today", "&Today", System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer)))
            Me.schedulerStorage1.Appointments.Statuses.Add(DevExpress.XtraScheduler.AppointmentStatusType.Custom, "Active", "&Active", System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer)))
            Me.schedulerStorage1.EnableReminders = False
            Me.schedulerStorage1.Resources.Mappings.Caption = "FullNameLastSorting"
            Me.schedulerStorage1.Resources.Mappings.Id = "Oid"
            Me.schedulerStorage1.Resources.Mappings.Image = "PhotoExist"
            '
            'resourcesCheckedListBoxControl1
            '
            Me.resourcesCheckedListBoxControl1.CheckOnClick = True
            Me.resourcesCheckedListBoxControl1.Location = New System.Drawing.Point(8, 32)
            Me.resourcesCheckedListBoxControl1.MaximumSize = New System.Drawing.Size(200, 0)
            Me.resourcesCheckedListBoxControl1.Name = "resourcesCheckedListBoxControl1"
            Me.resourcesCheckedListBoxControl1.SchedulerControl = Me.schedulerControl1
            Me.resourcesCheckedListBoxControl1.Size = New System.Drawing.Size(196, 396)
            Me.resourcesCheckedListBoxControl1.StyleController = Me.lcMain
            Me.resourcesCheckedListBoxControl1.TabIndex = 8
            '
            'dateNavigator1
            '
            Me.dateNavigator1.AllowAnimatedContentChange = True
            Me.dateNavigator1.CalendarHorizontalIndent = 0
            Me.dateNavigator1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dateNavigator1.CalendarVerticalIndent = 0
            Me.dateNavigator1.CellPadding = New System.Windows.Forms.Padding(0)
            Me.dateNavigator1.FirstDayOfWeek = System.DayOfWeek.Monday
            Me.dateNavigator1.Location = New System.Drawing.Point(8, 437)
            Me.dateNavigator1.MonthHeaderPadding = New System.Windows.Forms.Padding(0)
            Me.dateNavigator1.Name = "dateNavigator1"
            Me.dateNavigator1.SchedulerControl = Me.schedulerControl1
            Me.dateNavigator1.Size = New System.Drawing.Size(196, 177)
            Me.dateNavigator1.StyleController = Me.lcMain
            Me.dateNavigator1.TabIndex = 6
            '
            'resourcesComboBoxControl1
            '
            Me.resourcesComboBoxControl1.Location = New System.Drawing.Point(8, 8)
            Me.resourcesComboBoxControl1.Name = "resourcesComboBoxControl1"
            Me.resourcesComboBoxControl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.resourcesComboBoxControl1.Properties.DropDownRows = 25
            Me.resourcesComboBoxControl1.SchedulerControl = Me.schedulerControl1
            Me.resourcesComboBoxControl1.Size = New System.Drawing.Size(196, 20)
            Me.resourcesComboBoxControl1.StyleController = Me.lcMain
            Me.resourcesComboBoxControl1.TabIndex = 9
            '
            'layoutControlGroup1
            '
            Me.layoutControlGroup1.CustomizationFormText = "Root"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem1, Me.splitterItem1})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(1035, 622)
            Me.layoutControlGroup1.TextVisible = False
            '
            'layoutControlItem2
            '
            Me.layoutControlItem2.Control = Me.schedulerControl1
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(200, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(823, 610)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            '
            'layoutControlItem4
            '
            Me.layoutControlItem4.Control = Me.resourcesCheckedListBoxControl1
            Me.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.BottomCenter
            Me.layoutControlItem4.CustomizationFormText = "layoutControlItem4"
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(200, 400)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            '
            'layoutControlItem5
            '
            Me.layoutControlItem5.Control = Me.resourcesComboBoxControl1
            Me.layoutControlItem5.CustomizationFormText = "layoutControlItem5"
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(200, 24)
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            '
            'layoutControlItem1
            '
            Me.layoutControlItem1.Control = Me.dateNavigator1
            Me.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.BottomCenter
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 429)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(200, 180)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(200, 181)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            '
            'splitterItem1
            '
            Me.splitterItem1.AllowHotTrack = True
            Me.splitterItem1.CustomizationFormText = "splitterItem1"
            Me.splitterItem1.Location = New System.Drawing.Point(0, 424)
            Me.splitterItem1.Name = "splitterItem1"
            Me.splitterItem1.Size = New System.Drawing.Size(200, 5)
            '
            'xpcRents
            '
            Me.xpcRents.LoadingEnabled = False
            Me.xpcRents.ObjectType = GetType(DevExpress.VideoRent.Rent)
            '
            'xpcCustomers
            '
            Me.xpcCustomers.LoadingEnabled = False
            Me.xpcCustomers.ObjectType = GetType(DevExpress.VideoRent.Customer)
            Me.xpcCustomers.Sorting.AddRange(New DevExpress.Xpo.SortProperty() {New DevExpress.Xpo.SortProperty("[FullNameLastSorting]", DevExpress.Xpo.DB.SortingDirection.Ascending)})
            '
            'RentalCalendar
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.lcMain)
            Me.Name = "RentalCalendar"
            Me.Size = New System.Drawing.Size(1035, 622)
            CType(Me.lcMain, System.ComponentModel.ISupportInitialize).EndInit()
            Me.lcMain.ResumeLayout(False)
            CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.resourcesCheckedListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dateNavigator1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.resourcesComboBoxControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xpcRents, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xpcCustomers, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private lcMain As DevExpress.XtraLayout.LayoutControl
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private WithEvents schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
        Private WithEvents schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private dateNavigator1 As DevExpress.XtraScheduler.DateNavigator
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents resourcesCheckedListBoxControl1 As DevExpress.XtraScheduler.UI.ResourcesCheckedListBoxControl
        Private resourcesComboBoxControl1 As DevExpress.XtraScheduler.UI.ResourcesComboBoxControl
        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents xpcRents As DevExpress.Xpo.XPCollection
        Private WithEvents xpcCustomers As DevExpress.Xpo.XPCollection
        Private splitterItem1 As DevExpress.XtraLayout.SplitterItem
    End Class
End Namespace
