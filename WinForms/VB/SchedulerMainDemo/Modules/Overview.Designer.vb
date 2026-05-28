Namespace DevExpress.XtraScheduler.Demos

    Partial Class OverviewModule

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

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim timeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler3 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim skinPaddingEdges1 As DevExpress.Skins.SkinPaddingEdges = New DevExpress.Skins.SkinPaddingEdges()
            Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerDataStorage1 = New DevExpress.XtraScheduler.SchedulerDataStorage(Me.components)
            Me.schedulerBarController1 = New DevExpress.XtraScheduler.UI.SchedulerBarController(Me.components)
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.accordionControl1 = New DevExpress.XtraBars.Navigation.AccordionControl()
            Me.accordionContentContainer1 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
            Me.dateNavigator1 = New DevExpress.XtraScheduler.DateNavigator()
            Me.accordionContentContainer3 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.Patient = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.Birthday = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.Phone = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.accordionContentContainer2 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
            Me.galleryControl1 = New DevExpress.XtraBars.Ribbon.GalleryControl()
            Me.galleryControlClient1 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
            Me.accordionControlElement1 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.accordionControlElement2 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.accordionControlElement3 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            CType((Me.schedulerControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerDataStorage1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerBarController1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.splitContainerControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            CType((Me.accordionControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.accordionControl1.SuspendLayout()
            Me.accordionContentContainer1.SuspendLayout()
            CType((Me.dateNavigator1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dateNavigator1.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.accordionContentContainer3.SuspendLayout()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.accordionContentContainer2.SuspendLayout()
            CType((Me.galleryControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.galleryControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' schedulerControl1
            ' 
            Me.schedulerControl1.Appearance.ResourceHeaderCaption.FontStyleDelta = System.Drawing.FontStyle.Bold
            Me.schedulerControl1.Appearance.ResourceHeaderCaption.Options.UseFont = True
            Me.schedulerControl1.DataStorage = Me.schedulerDataStorage1
            Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
            Me.schedulerControl1.Location = New System.Drawing.Point(0, 0)
            Me.schedulerControl1.MenuManager = Me
            Me.schedulerControl1.Name = "schedulerControl1"
            Me.schedulerControl1.OptionsCustomization.AllowAppointmentConflicts = DevExpress.XtraScheduler.AppointmentConflictsMode.Custom
            Me.schedulerControl1.OptionsView.NavigationButtons.Visibility = DevExpress.XtraScheduler.NavigationButtonVisibility.Never
            Me.schedulerControl1.OptionsView.ResourceHeaders.ImageAlign = DevExpress.XtraScheduler.HeaderImageAlign.Top
            Me.schedulerControl1.OptionsView.ResourceHeaders.ImageSize = New System.Drawing.Size(120, 120)
            Me.schedulerControl1.Size = New System.Drawing.Size(809, 707)
            Me.schedulerControl1.Start = New System.DateTime(2012, 12, 3, 0, 0, 0, 0)
            Me.schedulerControl1.TabIndex = 0
            Me.schedulerControl1.Text = "schedulerControl1"
            Me.schedulerControl1.Views.AgendaView.AppointmentDisplayOptions.ShowResource = True
            Me.schedulerControl1.Views.DayView.AppointmentDisplayOptions.EndTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Always
            Me.schedulerControl1.Views.DayView.AppointmentDisplayOptions.StartTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Always
            Me.schedulerControl1.Views.DayView.ShowWorkTimeOnly = True
            Me.schedulerControl1.Views.DayView.TimeMarkerVisibility = DevExpress.XtraScheduler.TimeMarkerVisibility.Always
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl1.Views.DayView.TimeScale = System.TimeSpan.Parse("00:10:00")
            Me.schedulerControl1.Views.FullWeekView.Enabled = True
            Me.schedulerControl1.Views.FullWeekView.ShowWorkTimeOnly = True
            Me.schedulerControl1.Views.FullWeekView.TimeMarkerVisibility = DevExpress.XtraScheduler.TimeMarkerVisibility.Always
            Me.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2)
            Me.schedulerControl1.Views.FullWeekView.TimeScale = System.TimeSpan.Parse("00:10:00")
            Me.schedulerControl1.Views.GanttView.Enabled = False
            Me.schedulerControl1.Views.MonthView.Enabled = False
            Me.schedulerControl1.Views.TimelineView.Enabled = False
            Me.schedulerControl1.Views.WeekView.Enabled = False
            Me.schedulerControl1.Views.WorkWeekView.ShowWorkTimeOnly = True
            Me.schedulerControl1.Views.WorkWeekView.TimeMarkerVisibility = DevExpress.XtraScheduler.TimeMarkerVisibility.Always
            Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3)
            Me.schedulerControl1.Views.WorkWeekView.TimeScale = System.TimeSpan.Parse("00:10:00")
            AddHandler Me.schedulerControl1.EditAppointmentFormShowing, New DevExpress.XtraScheduler.AppointmentFormEventHandler(AddressOf Me.schedulerControl1_EditAppointmentFormShowing)
            ' 
            ' schedulerBarController1
            ' 
            Me.schedulerBarController1.Control = Me.schedulerControl1
            ' 
            ' splitContainerControl1
            ' 
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.schedulerControl1)
            Me.splitContainerControl1.Panel1.Text = "Panel1"
            Me.splitContainerControl1.Panel2.Controls.Add(Me.accordionControl1)
            Me.splitContainerControl1.Panel2.Text = "Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(1076, 707)
            Me.splitContainerControl1.SplitterPosition = 809
            Me.splitContainerControl1.TabIndex = 4
            Me.splitContainerControl1.Text = "splitContainerControl1"
            ' 
            ' accordionControl1
            ' 
            Me.accordionControl1.Controls.Add(Me.accordionContentContainer1)
            Me.accordionControl1.Controls.Add(Me.accordionContentContainer3)
            Me.accordionControl1.Controls.Add(Me.accordionContentContainer2)
            Me.accordionControl1.DistanceBetweenRootGroups = 0
            Me.accordionControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.accordionControl1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.accordionControlElement1, Me.accordionControlElement2, Me.accordionControlElement3})
            Me.accordionControl1.ExpandElementMode = DevExpress.XtraBars.Navigation.ExpandElementMode.Multiple
            Me.accordionControl1.ExpandItemOnHeaderClick = False
            Me.accordionControl1.Location = New System.Drawing.Point(0, 0)
            Me.accordionControl1.Name = "accordionControl1"
            Me.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden
            Me.accordionControl1.ShowItemExpandButtons = False
            Me.accordionControl1.Size = New System.Drawing.Size(262, 707)
            Me.accordionControl1.TabIndex = 2
            Me.accordionControl1.Text = "accordionControl1"
            ' 
            ' accordionContentContainer1
            ' 
            Me.accordionContentContainer1.Appearance.BackColor = System.Drawing.SystemColors.Control
            Me.accordionContentContainer1.Appearance.Options.UseBackColor = True
            Me.accordionContentContainer1.Controls.Add(Me.dateNavigator1)
            Me.accordionContentContainer1.Name = "accordionContentContainer1"
            Me.accordionContentContainer1.Size = New System.Drawing.Size(262, 180)
            Me.accordionContentContainer1.TabIndex = 1
            ' 
            ' dateNavigator1
            ' 
            Me.dateNavigator1.AllowDrop = False
            Me.dateNavigator1.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold
            Me.dateNavigator1.CalendarAppearance.DayCellSpecial.Options.UseFont = True
            Me.dateNavigator1.CalendarHorizontalIndent = 0
            Me.dateNavigator1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dateNavigator1.CalendarVerticalIndent = 0
            Me.dateNavigator1.CellPadding = New System.Windows.Forms.Padding(5, 0, 5, 0)
            Me.dateNavigator1.ColumnCount = 1
            Me.dateNavigator1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dateNavigator1.FirstDayOfWeek = System.DayOfWeek.Monday
            Me.dateNavigator1.Location = New System.Drawing.Point(0, 0)
            Me.dateNavigator1.MonthHeaderPadding = New System.Windows.Forms.Padding(0)
            Me.dateNavigator1.Name = "dateNavigator1"
            Me.dateNavigator1.Padding = New System.Windows.Forms.Padding(10)
            Me.dateNavigator1.RowCount = 1
            Me.dateNavigator1.SchedulerControl = Me.schedulerControl1
            Me.dateNavigator1.Size = New System.Drawing.Size(262, 180)
            Me.dateNavigator1.TabIndex = 0
            ' 
            ' accordionContentContainer3
            ' 
            Me.accordionContentContainer3.Appearance.BackColor = System.Drawing.SystemColors.Control
            Me.accordionContentContainer3.Appearance.Options.UseBackColor = True
            Me.accordionContentContainer3.Controls.Add(Me.gridControl1)
            Me.accordionContentContainer3.Name = "accordionContentContainer3"
            Me.accordionContentContainer3.Size = New System.Drawing.Size(262, 76)
            Me.accordionContentContainer3.TabIndex = 3
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.MenuManager = Me
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(262, 76)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Patient, Me.Birthday, Me.Phone})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsView.ShowGroupPanel = False
            Me.gridView1.OptionsView.ShowIndicator = False
            AddHandler Me.gridView1.MouseDown, New System.Windows.Forms.MouseEventHandler(AddressOf Me.gridView1_MouseDown)
            AddHandler Me.gridView1.MouseMove, New System.Windows.Forms.MouseEventHandler(AddressOf Me.gridView1_MouseMove)
            ' 
            ' Patient
            ' 
            Me.Patient.Caption = "Patient"
            Me.Patient.FieldName = "Name"
            Me.Patient.Name = "Patient"
            Me.Patient.OptionsColumn.AllowEdit = False
            Me.Patient.Visible = True
            Me.Patient.VisibleIndex = 0
            Me.Patient.Width = 82
            ' 
            ' Birthday
            ' 
            Me.Birthday.Caption = "Birthday"
            Me.Birthday.FieldName = "Birthday"
            Me.Birthday.Name = "Birthday"
            Me.Birthday.OptionsColumn.AllowEdit = False
            Me.Birthday.Visible = True
            Me.Birthday.VisibleIndex = 1
            Me.Birthday.Width = 55
            ' 
            ' Phone
            ' 
            Me.Phone.Caption = "Phone"
            Me.Phone.FieldName = "Phone"
            Me.Phone.Name = "Phone"
            Me.Phone.OptionsColumn.AllowEdit = False
            Me.Phone.Visible = True
            Me.Phone.VisibleIndex = 2
            Me.Phone.Width = 63
            ' 
            ' accordionContentContainer2
            ' 
            Me.accordionContentContainer2.Appearance.BackColor = System.Drawing.SystemColors.Control
            Me.accordionContentContainer2.Appearance.Options.UseBackColor = True
            Me.accordionContentContainer2.Controls.Add(Me.galleryControl1)
            Me.accordionContentContainer2.Name = "accordionContentContainer2"
            Me.accordionContentContainer2.Size = New System.Drawing.Size(262, 219)
            Me.accordionContentContainer2.TabIndex = 4
            ' 
            ' galleryControl1
            ' 
            Me.galleryControl1.Controls.Add(Me.galleryControlClient1)
            Me.galleryControl1.DesignGalleryGroupIndex = 0
            Me.galleryControl1.DesignGalleryItemIndex = 0
            Me.galleryControl1.Dock = System.Windows.Forms.DockStyle.Fill
            ' 
            ' 
            ' 
            Me.galleryControl1.Gallery.AllowAllUp = False
            Me.galleryControl1.Gallery.AllowFilter = False
            Me.galleryControl1.Gallery.AllowMarqueeSelection = True
            Me.galleryControl1.Gallery.ColumnCount = 1
            Me.galleryControl1.Gallery.ImageSize = New System.Drawing.Size(40, 50)
            Me.galleryControl1.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.Multiple
            Me.galleryControl1.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside
            Me.galleryControl1.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            skinPaddingEdges1.Bottom = -10
            skinPaddingEdges1.Top = -10
            Me.galleryControl1.Gallery.ItemImagePadding = skinPaddingEdges1
            Me.galleryControl1.Gallery.ShowItemText = True
            Me.galleryControl1.Gallery.StretchItems = True
            Me.galleryControl1.Location = New System.Drawing.Point(0, 0)
            Me.galleryControl1.Name = "galleryControl1"
            Me.galleryControl1.Size = New System.Drawing.Size(262, 219)
            Me.galleryControl1.TabIndex = 0
            Me.galleryControl1.Text = "galleryControl1"
            ' 
            ' galleryControlClient1
            ' 
            Me.galleryControlClient1.GalleryControl = Me.galleryControl1
            Me.galleryControlClient1.Location = New System.Drawing.Point(2, 2)
            Me.galleryControlClient1.Size = New System.Drawing.Size(241, 215)
            ' 
            ' accordionControlElement1
            ' 
            Me.accordionControlElement1.ContentContainer = Me.accordionContentContainer1
            Me.accordionControlElement1.Expanded = True
            Me.accordionControlElement1.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)})
            Me.accordionControlElement1.Name = "accordionControlElement1"
            Me.accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.accordionControlElement1.Text = "Calendar"
            ' 
            ' accordionControlElement2
            ' 
            Me.accordionControlElement2.ContentContainer = Me.accordionContentContainer2
            Me.accordionControlElement2.Expanded = True
            Me.accordionControlElement2.Name = "accordionControlElement2"
            Me.accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.accordionControlElement2.Text = "Doctors"
            ' 
            ' accordionControlElement3
            ' 
            Me.accordionControlElement3.ContentContainer = Me.accordionContentContainer3
            Me.accordionControlElement3.Expanded = True
            Me.accordionControlElement3.Name = "accordionControlElement3"
            Me.accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.accordionControlElement3.Text = "Patients"
            ' 
            ' OverviewModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Name = "OverviewModule"
            Me.Size = New System.Drawing.Size(1076, 707)
            CType((Me.schedulerControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerDataStorage1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerBarController1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.splitContainerControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType((Me.accordionControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.accordionControl1.ResumeLayout(False)
            Me.accordionContentContainer1.ResumeLayout(False)
            CType((Me.dateNavigator1.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dateNavigator1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.accordionContentContainer3.ResumeLayout(False)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.accordionContentContainer2.ResumeLayout(False)
            CType((Me.galleryControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.galleryControl1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl

        Private schedulerDataStorage1 As DevExpress.XtraScheduler.SchedulerDataStorage

        Private schedulerBarController1 As DevExpress.XtraScheduler.UI.SchedulerBarController

        Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl

        Private dateNavigator1 As DevExpress.XtraScheduler.DateNavigator

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private Patient As DevExpress.XtraGrid.Columns.GridColumn

        Private Birthday As DevExpress.XtraGrid.Columns.GridColumn

        Private Phone As DevExpress.XtraGrid.Columns.GridColumn

        Private accordionControl1 As DevExpress.XtraBars.Navigation.AccordionControl

        Private accordionContentContainer1 As DevExpress.XtraBars.Navigation.AccordionContentContainer

        Private accordionContentContainer3 As DevExpress.XtraBars.Navigation.AccordionContentContainer

        Private accordionContentContainer2 As DevExpress.XtraBars.Navigation.AccordionContentContainer

        Private accordionControlElement1 As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private accordionControlElement3 As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private accordionControlElement2 As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private galleryControl1 As DevExpress.XtraBars.Ribbon.GalleryControl

        Private galleryControlClient1 As DevExpress.XtraBars.Ribbon.GalleryControlClient
    End Class
End Namespace
