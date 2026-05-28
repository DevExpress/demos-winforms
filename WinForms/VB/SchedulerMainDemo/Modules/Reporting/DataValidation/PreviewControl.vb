Imports System
Imports System.Collections
Imports DevExpress.XtraScheduler.Reporting
Imports System.Collections.Generic

Namespace DevExpress.XtraScheduler.Demos.Reporting.DataValidation

    Public Class PreviewControl
        Inherits SingleReportPreviewControl

        Private components As System.ComponentModel.IContainer = Nothing

        Private cmbResources As XtraEditors.ComboBoxEdit

        Private cmbDays As XtraEditors.ImageComboBoxEdit

        Private layoutControlItem2 As XtraLayout.LayoutControlItem

        Private layoutControlItem3 As XtraLayout.LayoutControlItem

        Private layoutControlItem4 As XtraLayout.LayoutControlItem

        Private cmbAppointments As XtraEditors.ImageComboBoxEdit

        Private navigationPaneSettings As XtraBars.Navigation.NavigationPane

        Private navigationPageSettings As XtraBars.Navigation.NavigationPage

        Private layoutControlSettings As XtraLayout.LayoutControl

        Private layoutControlGroupSettings As XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As XtraLayout.EmptySpaceItem

        Private emptySpaceItem2 As XtraLayout.EmptySpaceItem

        Private btnEdit As XtraEditors.SimpleButton

        Public Overloads ReadOnly Property Report As Report
            Get
                Return CType(MyBase.Report, Report)
            End Get
        End Property

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            UpdateActiveReport()
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

        Protected Overrides Function CreateReportInstance() As XtraSchedulerReport
            Return New Report()
        End Function

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportPreviewControlBase))
            cmbResources = New XtraEditors.ComboBoxEdit()
            cmbAppointments = New XtraEditors.ImageComboBoxEdit()
            cmbDays = New XtraEditors.ImageComboBoxEdit()
            btnEdit = New XtraEditors.SimpleButton()
            layoutControlSettings = New DevExpress.XtraLayout.LayoutControl()
            layoutControlGroupSettings = New DevExpress.XtraLayout.LayoutControlGroup()
            layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            navigationPaneSettings = New XtraBars.Navigation.NavigationPane()
            navigationPageSettings = New XtraBars.Navigation.NavigationPage()
            layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            CType(fSchedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(navigationPaneSettings, System.ComponentModel.ISupportInitialize).BeginInit()
            navigationPaneSettings.SuspendLayout()
            navigationPageSettings.SuspendLayout()
            CType(layoutControlSettings, System.ComponentModel.ISupportInitialize).BeginInit()
            layoutControlSettings.SuspendLayout()
            CType(layoutControlGroupSettings, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(fStoragePrintAdapter, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(cmbResources.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(cmbAppointments.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(cmbDays.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' btnEdit
            ' 
            btnEdit.Anchor = CType(Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Right, Windows.Forms.AnchorStyles)
            btnEdit.Location = New System.Drawing.Point(7, 7)
            btnEdit.Name = "btnEdit"
            btnEdit.Size = New System.Drawing.Size(201, 22)
            btnEdit.StyleController = layoutControlSettings
            btnEdit.TabIndex = 2
            btnEdit.Text = "Edit"
            AddHandler btnEdit.Click, New EventHandler(AddressOf btnEdit_Click)
            ' 
            ' navigationPaneSettings
            ' 
            navigationPaneSettings.Controls.Add(navigationPageSettings)
            navigationPaneSettings.Dock = Windows.Forms.DockStyle.Right
            navigationPaneSettings.ItemOrientation = Windows.Forms.Orientation.Vertical
            navigationPaneSettings.Location = New System.Drawing.Point(455, 0)
            navigationPaneSettings.Name = "navigationPaneSettings"
            navigationPaneSettings.PageProperties.ShowExpandButton = False
            navigationPaneSettings.Pages.AddRange(New XtraBars.Navigation.NavigationPageBase() {navigationPageSettings})
            navigationPaneSettings.SelectedPage = navigationPageSettings
            navigationPaneSettings.TabIndex = 11
            navigationPaneSettings.Text = "navigationPane1"
            navigationPaneSettings.RegularSize = New System.Drawing.Size(245, 396)
            navigationPaneSettings.Size = New System.Drawing.Size(245, 396)
            ' 
            ' navigationPageSettings
            ' 
            navigationPageSettings.BackgroundPadding = New Windows.Forms.Padding(0)
            navigationPageSettings.Caption = "Options"
            navigationPageSettings.Controls.Add(layoutControlSettings)
            navigationPageSettings.Image = CType(resources.GetObject("navigationPageSettings.Image"), System.Drawing.Image)
            navigationPageSettings.Name = "navigationPageSettings"
            navigationPageSettings.Size = New System.Drawing.Size(215, 352)
            ' 
            ' layoutControlSettings
            ' 
            layoutControlSettings.Controls.Add(btnEdit)
            layoutControlSettings.Dock = Windows.Forms.DockStyle.Fill
            layoutControlSettings.Location = New System.Drawing.Point(0, 0)
            layoutControlSettings.Name = "layoutControlSettings"
            layoutControlSettings.Root = layoutControlGroupSettings
            layoutControlSettings.Size = New System.Drawing.Size(215, 352)
            layoutControlSettings.TabIndex = 0
            layoutControlSettings.Text = "layoutControl1"
            layoutControlSettings.Controls.Add(cmbDays)
            layoutControlSettings.Controls.Add(cmbAppointments)
            layoutControlSettings.Controls.Add(cmbResources)
            layoutControlSettings.Controls.SetChildIndex(cmbResources, 0)
            layoutControlSettings.Controls.SetChildIndex(btnEdit, 0)
            layoutControlSettings.Controls.SetChildIndex(cmbAppointments, 0)
            layoutControlSettings.Controls.SetChildIndex(cmbDays, 0)
            ' 
            ' layoutControlGroupSettings
            ' 
            layoutControlGroupSettings.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            layoutControlGroupSettings.GroupBordersVisible = False
            layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem1, emptySpaceItem1, emptySpaceItem2})
            layoutControlGroupSettings.Location = New System.Drawing.Point(0, 0)
            layoutControlGroupSettings.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            layoutControlGroupSettings.Size = New System.Drawing.Size(215, 352)
            layoutControlGroupSettings.TextVisible = False
            layoutControlGroupSettings.Name = "layoutControlGroup1"
            layoutControlGroupSettings.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {layoutControlItem2, layoutControlItem3, layoutControlItem4})
            ' 
            ' layoutControlItem1
            ' 
            layoutControlItem1.Control = btnEdit
            layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            layoutControlItem1.Name = "layoutControlItem1"
            layoutControlItem1.Size = New System.Drawing.Size(205, 26)
            layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            layoutControlItem1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            emptySpaceItem1.AllowHotTrack = False
            emptySpaceItem1.Location = New System.Drawing.Point(0, 26)
            emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 10)
            emptySpaceItem1.MinSize = New System.Drawing.Size(10, 10)
            emptySpaceItem1.Name = "emptySpaceItem1"
            emptySpaceItem1.Size = New System.Drawing.Size(205, 10)
            emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem2
            ' 
            emptySpaceItem2.AllowHotTrack = False
            emptySpaceItem2.Name = "emptySpaceItem2"
            emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            emptySpaceItem2.Location = New System.Drawing.Point(0, 108)
            emptySpaceItem2.Size = New System.Drawing.Size(205, 234)
            ' 
            ' fStoragePrintAdapter
            ' 
            AddHandler fStoragePrintAdapter.ValidateTimeIntervals, New TimeIntervalsValidationEventHandler(AddressOf storagePrintAdapter_ValidateTimeIntervals)
            AddHandler fStoragePrintAdapter.ValidateResources, New ResourcesValidationEventHandler(AddressOf storagePrintAdapter_ValidateResources)
            ' 
            ' cmbResources
            ' 
            cmbResources.EditValue = "All"
            cmbResources.Location = New System.Drawing.Point(81, 43)
            cmbResources.Name = "cmbResources"
            cmbResources.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo)})
            cmbResources.Properties.Items.AddRange(New Object() {"All", "Top 3 ", "A-Z order", "Z-A order", ""})
            cmbResources.Properties.TextEditStyle = XtraEditors.Controls.TextEditStyles.DisableTextEditor
            cmbResources.Size = New System.Drawing.Size(127, 20)
            cmbResources.StyleController = layoutControlSettings
            cmbResources.TabIndex = 13
            AddHandler cmbResources.SelectedIndexChanged, New EventHandler(AddressOf cmbResources_SelectedIndexChanged)
            ' 
            ' cmbAppointments
            ' 
            cmbAppointments.EditValue = UsedAppointmentType.All
            cmbAppointments.Location = New System.Drawing.Point(81, 67)
            cmbAppointments.Name = "cmbAppointments"
            cmbAppointments.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo)})
            cmbAppointments.Properties.Items.AddRange(New XtraEditors.Controls.ImageComboBoxItem() {New XtraEditors.Controls.ImageComboBoxItem("All", UsedAppointmentType.All, -1), New XtraEditors.Controls.ImageComboBoxItem("Recurring", UsedAppointmentType.Recurring, -1), New XtraEditors.Controls.ImageComboBoxItem("NonRecurring", UsedAppointmentType.NonRecurring, -1)})
            cmbAppointments.Size = New System.Drawing.Size(127, 20)
            cmbAppointments.StyleController = layoutControlSettings
            cmbAppointments.TabIndex = 38
            AddHandler cmbAppointments.SelectedIndexChanged, New EventHandler(AddressOf cmbAppointments_SelectedIndexChanged)
            ' 
            ' cmbDays
            ' 
            cmbDays.EditValue = CType(WeekDays.Sunday Or WeekDays.Monday Or WeekDays.Tuesday Or WeekDays.Wednesday Or WeekDays.Thursday Or WeekDays.Friday Or WeekDays.Saturday, WeekDays)
            cmbDays.Location = New System.Drawing.Point(81, 91)
            cmbDays.Name = "cmbDays"
            cmbDays.Properties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo)})
            cmbDays.Properties.Items.AddRange(New XtraEditors.Controls.ImageComboBoxItem() {New XtraEditors.Controls.ImageComboBoxItem("Every Day", CType(WeekDays.Sunday Or WeekDays.Monday Or WeekDays.Tuesday Or WeekDays.Wednesday Or WeekDays.Thursday Or WeekDays.Friday Or WeekDays.Saturday, WeekDays), -1), New XtraEditors.Controls.ImageComboBoxItem("Work Days", CType(WeekDays.Monday Or WeekDays.Tuesday Or WeekDays.Wednesday Or WeekDays.Thursday Or WeekDays.Friday, WeekDays), -1), New XtraEditors.Controls.ImageComboBoxItem("Weekend Days", CType(WeekDays.Sunday Or WeekDays.Saturday, WeekDays), -1)})
            cmbDays.Size = New System.Drawing.Size(127, 20)
            cmbDays.StyleController = layoutControlSettings
            cmbDays.TabIndex = 40
            AddHandler cmbDays.SelectedIndexChanged, New EventHandler(AddressOf cmbDays_SelectedIndexChanged)
            ' 
            ' layoutControlItem2
            ' 
            layoutControlItem2.Control = cmbResources
            layoutControlItem2.Location = New System.Drawing.Point(0, 36)
            layoutControlItem2.Name = "layoutControlItem2"
            layoutControlItem2.Size = New System.Drawing.Size(205, 24)
            layoutControlItem2.Text = "Resources:"
            layoutControlItem2.TextSize = New System.Drawing.Size(70, 13)
            ' 
            ' layoutControlItem3
            ' 
            layoutControlItem3.Control = cmbAppointments
            layoutControlItem3.Location = New System.Drawing.Point(0, 60)
            layoutControlItem3.Name = "layoutControlItem3"
            layoutControlItem3.Size = New System.Drawing.Size(205, 24)
            layoutControlItem3.Text = "Appointments:"
            layoutControlItem3.TextSize = New System.Drawing.Size(70, 13)
            ' 
            ' layoutControlItem4
            ' 
            layoutControlItem4.Control = cmbDays
            layoutControlItem4.Location = New System.Drawing.Point(0, 84)
            layoutControlItem4.Name = "layoutControlItem4"
            layoutControlItem4.Size = New System.Drawing.Size(205, 24)
            layoutControlItem4.Text = "Days:"
            layoutControlItem4.TextSize = New System.Drawing.Size(70, 13)
            ' 
            ' PreviewControl
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            Name = "PreviewControl"
            Me.Controls.Add(navigationPaneSettings)
            CType(fSchedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(navigationPaneSettings, System.ComponentModel.ISupportInitialize).EndInit()
            navigationPaneSettings.ResumeLayout(False)
            navigationPageSettings.ResumeLayout(False)
            CType(layoutControlSettings, System.ComponentModel.ISupportInitialize).EndInit()
            layoutControlSettings.ResumeLayout(False)
            CType(layoutControlGroupSettings, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(fStoragePrintAdapter, System.ComponentModel.ISupportInitialize).EndInit()
            CType(cmbResources.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(cmbAppointments.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(cmbDays.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim designForm As CustomDesignForm = New CustomDesignForm()
            Dim activeReport As XtraSchedulerReport = GetActiveReport()
            If activeReport Is Nothing Then Return
            designForm.OpenReport(activeReport)
            PreventUpdate = True
            Try
                ShowDesignerForm(designForm, FindForm())
            Finally
                PreventUpdate = False
            End Try

            designForm.Dispose()
            CreateReports()
            UpdateActiveReport()
        End Sub

        Protected Overrides Sub InitAdapterTimeInterval()
            StoragePrintAdapter.TimeInterval = New TimeInterval(BaseDate, TimeSpan.FromDays(10))
        End Sub

        Protected Overrides Sub DoValidateAppointments(ByVal e As AppointmentsValidationEventArgs)
            MyBase.DoValidateAppointments(e)
            Dim aptType As UsedAppointmentType = CType(cmbAppointments.EditValue, UsedAppointmentType)
            If aptType.Equals(UsedAppointmentType.All) Then Return
            If aptType.Equals(UsedAppointmentType.None) Then
                e.Appointments.Clear()
                Return
            End If

            Dim count As Integer = e.Appointments.Count
            Dim result As AppointmentBaseCollection = New AppointmentBaseCollection()
            For i As Integer = 0 To count - 1
                Dim apt As Appointment = e.Appointments(i)
                If aptType.Equals(UsedAppointmentType.Recurring) AndAlso apt.IsRecurring Then result.Add(apt)
                If aptType.Equals(UsedAppointmentType.NonRecurring) AndAlso Not apt.IsRecurring Then result.Add(apt)
            Next

            e.Appointments.Clear()
            e.Appointments.AddRange(result)
        End Sub

        Private Sub storagePrintAdapter_ValidateResources(ByVal sender As Object, ByVal e As ResourcesValidationEventArgs)
            Dim resourceMode As Integer = cmbResources.SelectedIndex
            If resourceMode = 1 Then
                Dim count As Integer = e.Resources.Count
                For i As Integer = count - 1 To 3 Step -1
                    e.Resources.RemoveAt(i)
                Next
            End If

            If resourceMode = 2 Then
                e.Resources.Sort(New ResourceCaptionComparer())
            End If

            If resourceMode = 3 Then
                e.Resources.Sort(New ResourceCaptionReverseComparer())
            End If
        End Sub

        Private Sub storagePrintAdapter_ValidateTimeIntervals(ByVal sender As Object, ByVal e As TimeIntervalsValidationEventArgs)
            Dim weekDays As WeekDays = CType(cmbDays.EditValue, WeekDays)
            If weekDays.Equals(WeekDays.EveryDay) Then Return
            Dim count As Integer = e.Intervals.Count
            Dim result As DayIntervalCollection = New DayIntervalCollection()
            For i As Integer = count - 1 To 0 Step -1
                Dim sourceDays As DayIntervalCollection = New DayIntervalCollection()
                sourceDays.Add(e.Intervals(i))
                FilterDays(sourceDays, weekDays)
                result.AddRange(sourceDays)
            Next

            e.Intervals.Clear()
            For i As Integer = 0 To result.Count - 1
                e.Intervals.Add(result(i))
            Next
        End Sub

        Private Sub FilterDays(ByVal dayIntervals As DayIntervalCollection, ByVal validDays As WeekDays)
            Dim count As Integer = dayIntervals.Count
            For i As Integer = count - 1 To 0 Step -1
                Dim day As DayOfWeek = dayIntervals(i).Start.DayOfWeek
                Dim weekDay As WeekDays = Native.DateTimeHelper.ToWeekDays(day)
                If Not(weekDay And validDays).Equals(weekDay) Then dayIntervals.RemoveAt(i)
            Next
        End Sub

        Private Sub cmbResources_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateActiveReport()
        End Sub

        Private Sub cmbAppointments_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateActiveReport()
        End Sub

        Private Sub cmbDays_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            CreateReports()
            UpdateActiveReport()
        End Sub
    End Class

    Public Class ResourceCaptionComparer
        Implements IComparer(Of Resource), IComparer

#Region "IComparer Members"
        Private Function IComparer_Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
            Return CompareCore(x, y)
        End Function

        Public Function Compare(ByVal x As Resource, ByVal y As Resource) As Integer Implements IComparer(Of Resource).Compare
            Return CompareCore(x, y)
        End Function

#End Region
        Protected Overridable Function CompareCore(ByVal x As Object, ByVal y As Object) As Integer
            Dim xRes As Resource = CType(x, Resource)
            Dim yRes As Resource = CType(y, Resource)
            If xRes Is Nothing OrElse yRes Is Nothing Then Return 0
            If EmptyResourceId.Id.Equals(xRes.Id) OrElse EmptyResourceId.Id.Equals(yRes.Id) Then Return 0
            Return CompareCaptions(xRes, yRes)
        End Function

        Protected Overridable Function CompareCaptions(ByVal xRes As Resource, ByVal yRes As Resource) As Integer
            Return String.Compare(xRes.Caption, yRes.Caption)
        End Function
    End Class

    Public Class ResourceCaptionReverseComparer
        Inherits ResourceCaptionComparer

        Protected Overrides Function CompareCaptions(ByVal xRes As Resource, ByVal yRes As Resource) As Integer
            Return String.Compare(yRes.Caption, xRes.Caption)
        End Function
    End Class
End Namespace
