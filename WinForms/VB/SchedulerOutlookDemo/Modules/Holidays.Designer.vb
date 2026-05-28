Namespace DevExpress.XtraScheduler.Demos

    Partial Class HolidaysModule

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
            Dim timeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler3 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerDataStorage = New DevExpress.XtraScheduler.SchedulerDataStorage(Me.components)
            Me.clbLocations = New DevExpress.XtraEditors.CheckedListBoxControl()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.btnImportFromOutlook = New DevExpress.XtraEditors.SimpleButton()
            Me.btnImportFromXml = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.schedulerBarController1 = New DevExpress.XtraScheduler.UI.SchedulerBarController(Me.components)
            Me.commonRibbon1 = New DevExpress.XtraScheduler.Demos.CommonRibbon()
            Me.spOptionPane = New DevExpress.XtraEditors.SidePanel()
            Me.tpOptions = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            CType((Me.schedulerControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerDataStorage), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.clbLocations), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerBarController1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.spOptionPane.SuspendLayout()
            CType((Me.tpOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpOptions.SuspendLayout()
            Me.tabNavigationPage2.SuspendLayout()
            Me.sidePanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' schedulerControl
            ' 
            Me.schedulerControl.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month
            Me.schedulerControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.schedulerControl.DataStorage = Me.schedulerDataStorage
            Me.schedulerControl.DateNavigationBar.CalendarButton.Show = True
            Me.schedulerControl.DateNavigationBar.ShowViewSelectorButton = True
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.Location = New System.Drawing.Point(0, 0)
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.OptionsFlyout.SubjectAutoHeight = True
            Me.schedulerControl.Size = New System.Drawing.Size(418, 597)
            Me.schedulerControl.Start = New System.DateTime(2010, 6, 20, 0, 0, 0, 0)
            Me.schedulerControl.TabIndex = 1
            Me.schedulerControl.Text = "schedulerControl1"
            Me.schedulerControl.Views.AgendaView.DayCount = 10
            Me.schedulerControl.Views.DayView.DayCount = 5
            Me.schedulerControl.Views.DayView.ResourcesPerPage = 3
            Me.schedulerControl.Views.DayView.ShowWorkTimeOnly = True
            Me.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl.Views.FullWeekView.Enabled = True
            Me.schedulerControl.Views.FullWeekView.ResourcesPerPage = 3
            Me.schedulerControl.Views.FullWeekView.TimeRulers.Add(timeRuler2)
            Me.schedulerControl.Views.GanttView.Enabled = False
            Me.schedulerControl.Views.GanttView.ResourcesPerPage = 3
            Me.schedulerControl.Views.MonthView.ResourcesPerPage = 3
            Me.schedulerControl.Views.TimelineView.ResourcesPerPage = 3
            Me.schedulerControl.Views.WeekView.Enabled = False
            Me.schedulerControl.Views.WeekView.ResourcesPerPage = 3
            Me.schedulerControl.Views.WorkWeekView.Enabled = False
            Me.schedulerControl.Views.WorkWeekView.ResourcesPerPage = 3
            Me.schedulerControl.Views.WorkWeekView.ShowFullWeek = True
            Me.schedulerControl.Views.WorkWeekView.ShowWorkTimeOnly = True
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler3)
            Me.schedulerControl.Views.YearView.UseOptimizedScrolling = False
            AddHandler Me.schedulerControl.LayoutViewInfoCustomizing, New System.EventHandler(Of DevExpress.XtraScheduler.LayoutViewInfoCustomizingEventArgs)(AddressOf Me.schedulerControl_LayoutViewInfoCustomizing)
            ' 
            ' schedulerDataStorage
            ' 
            ' 
            ' 
            ' 
            Me.schedulerDataStorage.Appointments.Labels.CreateNewLabel(0, "None", "&None", System.Drawing.SystemColors.Window)
            Me.schedulerDataStorage.Appointments.Labels.CreateNewLabel(1, "Important", "&Important", System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((194)))))), (CInt(((CByte((190))))))))
            Me.schedulerDataStorage.Appointments.Labels.CreateNewLabel(2, "Business", "&Business", System.Drawing.Color.FromArgb((CInt(((CByte((168)))))), (CInt(((CByte((213)))))), (CInt(((CByte((255))))))))
            Me.schedulerDataStorage.Appointments.Labels.CreateNewLabel(3, "Personal", "&Personal", System.Drawing.Color.FromArgb((CInt(((CByte((193)))))), (CInt(((CByte((244)))))), (CInt(((CByte((156))))))))
            Me.schedulerDataStorage.Appointments.Labels.CreateNewLabel(4, "Vacation", "&Vacation", System.Drawing.Color.FromArgb((CInt(((CByte((243)))))), (CInt(((CByte((228)))))), (CInt(((CByte((199))))))))
            Me.schedulerDataStorage.Appointments.Labels.CreateNewLabel(5, "Must Attend", "Must &Attend", System.Drawing.Color.FromArgb((CInt(((CByte((244)))))), (CInt(((CByte((206)))))), (CInt(((CByte((147))))))))
            Me.schedulerDataStorage.Appointments.Labels.CreateNewLabel(6, "Travel Required", "&Travel Required", System.Drawing.Color.FromArgb((CInt(((CByte((199)))))), (CInt(((CByte((244)))))), (CInt(((CByte((255))))))))
            Me.schedulerDataStorage.Appointments.Labels.CreateNewLabel(7, "Needs Preparation", "&Needs Preparation", System.Drawing.Color.FromArgb((CInt(((CByte((207)))))), (CInt(((CByte((219)))))), (CInt(((CByte((152))))))))
            Me.schedulerDataStorage.Appointments.Labels.CreateNewLabel(8, "Birthday", "&Birthday", System.Drawing.Color.FromArgb((CInt(((CByte((224)))))), (CInt(((CByte((207)))))), (CInt(((CByte((233))))))))
            Me.schedulerDataStorage.Appointments.Labels.CreateNewLabel(9, "Anniversary", "&Anniversary", System.Drawing.Color.FromArgb((CInt(((CByte((141)))))), (CInt(((CByte((233)))))), (CInt(((CByte((223))))))))
            Me.schedulerDataStorage.Appointments.Labels.CreateNewLabel(10, "Phone Call", "Phone &Call", System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((247)))))), (CInt(((CByte((165))))))))
            ' 
            ' clbLocations
            ' 
            Me.clbLocations.CheckOnClick = True
            Me.clbLocations.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.clbLocations.Location = New System.Drawing.Point(2, 38)
            Me.clbLocations.Name = "clbLocations"
            Me.clbLocations.Size = New System.Drawing.Size(281, 524)
            Me.clbLocations.StyleController = Me.layoutControl1
            Me.clbLocations.TabIndex = 0
            AddHandler Me.clbLocations.ItemCheck, New DevExpress.XtraEditors.Controls.ItemCheckEventHandler(AddressOf Me.clbLocations_ItemCheck)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.clbLocations)
            Me.layoutControl1.Controls.Add(Me.btnImportFromOutlook)
            Me.layoutControl1.Controls.Add(Me.btnImportFromXml)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(911, 343, 650, 400)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(285, 564)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' btnImportFromOutlook
            ' 
            Me.btnImportFromOutlook.Location = New System.Drawing.Point(123, 2)
            Me.btnImportFromOutlook.Name = "btnImportFromOutlook"
            Me.btnImportFromOutlook.Size = New System.Drawing.Size(160, 22)
            Me.btnImportFromOutlook.StyleController = Me.layoutControl1
            Me.btnImportFromOutlook.TabIndex = 1
            Me.btnImportFromOutlook.Text = "Import Outlook Holidays..."
            AddHandler Me.btnImportFromOutlook.Click, New System.EventHandler(AddressOf Me.btnImportFromOutlook_Click)
            ' 
            ' btnImportFromXml
            ' 
            Me.btnImportFromXml.Location = New System.Drawing.Point(2, 2)
            Me.btnImportFromXml.Name = "btnImportFromXml"
            Me.btnImportFromXml.Size = New System.Drawing.Size(117, 22)
            Me.btnImportFromXml.StyleController = Me.layoutControl1
            Me.btnImportFromXml.TabIndex = 0
            Me.btnImportFromXml.Text = "Import From Xml..."
            AddHandler Me.btnImportFromXml.Click, New System.EventHandler(AddressOf Me.btnImportFromXml_Click)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.emptySpaceItem4, Me.emptySpaceItem5})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(285, 564)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.btnImportFromXml
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(121, 26)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.btnImportFromOutlook
            Me.layoutControlItem2.Location = New System.Drawing.Point(121, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(164, 26)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.clbLocations
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 36)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(285, 528)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' emptySpaceItem4
            ' 
            Me.emptySpaceItem4.Location = New System.Drawing.Point(121, 26)
            Me.emptySpaceItem4.MaxSize = New System.Drawing.Size(0, 10)
            Me.emptySpaceItem4.MinSize = New System.Drawing.Size(10, 10)
            Me.emptySpaceItem4.Name = "emptySpaceItem4"
            Me.emptySpaceItem4.Size = New System.Drawing.Size(164, 10)
            Me.emptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' emptySpaceItem5
            ' 
            Me.emptySpaceItem5.Location = New System.Drawing.Point(0, 26)
            Me.emptySpaceItem5.MaxSize = New System.Drawing.Size(0, 10)
            Me.emptySpaceItem5.MinSize = New System.Drawing.Size(10, 10)
            Me.emptySpaceItem5.Name = "emptySpaceItem5"
            Me.emptySpaceItem5.Size = New System.Drawing.Size(121, 10)
            Me.emptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' schedulerBarController1
            ' 
            Me.schedulerBarController1.Control = Me.schedulerControl
            ' 
            ' commonRibbon1
            ' 
            Me.commonRibbon1.Dock = System.Windows.Forms.DockStyle.Top
            Me.commonRibbon1.Location = New System.Drawing.Point(0, 0)
            Me.commonRibbon1.Name = "commonRibbon1"
            Me.commonRibbon1.Size = New System.Drawing.Size(418, 0)
            Me.commonRibbon1.TabIndex = 14
            Me.commonRibbon1.TabStop = False
            Me.commonRibbon1.Tutorial = Me
            ' 
            ' spOptionPane
            ' 
            Me.spOptionPane.Controls.Add(Me.tpOptions)
            Me.spOptionPane.Dock = System.Windows.Forms.DockStyle.Right
            Me.spOptionPane.Location = New System.Drawing.Point(418, 0)
            Me.spOptionPane.Name = "spOptionPane"
            Me.spOptionPane.Size = New System.Drawing.Size(286, 597)
            Me.spOptionPane.TabIndex = 15
            Me.spOptionPane.Text = "sidePanel1"
            ' 
            ' tpOptions
            ' 
            Me.tpOptions.Controls.Add(Me.tabNavigationPage2)
            Me.tpOptions.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tpOptions.Location = New System.Drawing.Point(1, 0)
            Me.tpOptions.Name = "tpOptions"
            Me.tpOptions.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage2})
            Me.tpOptions.RegularSize = New System.Drawing.Size(285, 597)
            Me.tpOptions.SelectedPage = Me.tabNavigationPage2
            Me.tpOptions.Size = New System.Drawing.Size(285, 597)
            Me.tpOptions.TabIndex = 1
            Me.tpOptions.Text = "tabPane1"
            ' 
            ' tabNavigationPage2
            ' 
            Me.tabNavigationPage2.Caption = "Options"
            Me.tabNavigationPage2.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPage2.Name = "tabNavigationPage2"
            Me.tabNavigationPage2.Size = New System.Drawing.Size(285, 564)
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.schedulerControl)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sidePanel1.Location = New System.Drawing.Point(0, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(418, 597)
            Me.sidePanel1.TabIndex = 16
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' HolidaysModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.sidePanel1)
            Me.Controls.Add(Me.commonRibbon1)
            Me.Controls.Add(Me.spOptionPane)
            Me.Name = "HolidaysModule"
            Me.Size = New System.Drawing.Size(704, 597)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.HolidaysModule_Load)
            CType((Me.schedulerControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerDataStorage), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.clbLocations), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerBarController1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.spOptionPane.ResumeLayout(False)
            CType((Me.tpOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpOptions.ResumeLayout(False)
            Me.tabNavigationPage2.ResumeLayout(False)
            Me.sidePanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private schedulerControl As DevExpress.XtraScheduler.SchedulerControl

        Private schedulerDataStorage As DevExpress.XtraScheduler.SchedulerDataStorage

        Private components As System.ComponentModel.IContainer = Nothing

        Private clbLocations As DevExpress.XtraEditors.CheckedListBoxControl

        Private btnImportFromOutlook As DevExpress.XtraEditors.SimpleButton

        Private btnImportFromXml As DevExpress.XtraEditors.SimpleButton

        Private schedulerBarController1 As DevExpress.XtraScheduler.UI.SchedulerBarController

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem

        Private commonRibbon1 As DevExpress.XtraScheduler.Demos.CommonRibbon

        Private spOptionPane As DevExpress.XtraEditors.SidePanel

        Private tpOptions As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel
    End Class
End Namespace
