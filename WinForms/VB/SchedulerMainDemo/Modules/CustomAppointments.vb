Imports System
Imports System.Drawing
Imports DevExpress.Utils
Imports DevExpress.XtraScheduler.Drawing

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class CustomAppointmentsModule
        Inherits TutorialControl

        Private fCustomImages As ImageCollection

        Const CustomImagesOccurenceIndex As Integer = 0

        Const CustomImagesExceptionIndex As Integer = 1

        Const CustomImagesBizTripIndex As Integer = 2

        Const CustomImagesHolidayIndex As Integer = 3

        Public Sub New()
            fCustomImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources(DemoUtils.FindResourceName("Images.appointment_icons.png"), Reflection.Assembly.GetExecutingAssembly(), New Size(15, 15))
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
        ' TODO: Add any initialization after the InitializeComponent call
        End Sub

        Public Overrides ReadOnly Property PrintingSchedulerControl As SchedulerControl
            Get
                Return schedulerControl
            End Get
        End Property

        Protected ReadOnly Property DisplayOptions As AppointmentDisplayOptions
            Get
                Return schedulerControl.ActiveView.AppointmentDisplayOptions
            End Get
        End Property

        Protected ReadOnly Property IsDefaultAppointmentImages As Boolean
            Get
                Return rgrpAptImages.SelectedIndex = 0
            End Get
        End Property

        Protected ReadOnly Property IsExternalAppointmentImages As Boolean
            Get
                Return rgrpAptImages.SelectedIndex = 1
            End Get
        End Property

        Protected ReadOnly Property IsCustomAppointmentImages As Boolean
            Get
                Return rgrpAptImages.SelectedIndex = 2
            End Get
        End Property

        Protected ReadOnly Property CustomImages As ImageCollection
            Get
                Return fCustomImages
            End Get
        End Property

        Private Sub CustomAppointmentsModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.DataStorage.EnableReminders = True
            FillData(schedulerControl, schedulerStorage)
            schedulerControl.DataStorage.EnableReminders = False
        End Sub

        Private Sub CustomAppointmentsModule_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Visible Then
                UpdateControls()
            End If
        End Sub

        Private Sub schedulerControl_ActiveViewChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateControls()
        End Sub

        Private Sub UpdateControls()
            Dim options As AppointmentDisplayOptions = DisplayOptions
            chkStartTimeVisibility.CheckState = DemoUtils.TimeVisibilityToCheckState(options.StartTimeVisibility)
            chkEndTimeVisibility.CheckState = DemoUtils.TimeVisibilityToCheckState(options.EndTimeVisibility)
            cbStatus.EditValue = options.StatusDisplayType
            chkShowRecurrence.Checked = options.ShowRecurrence
            chkShowReminder.Checked = options.ShowReminder
            cbTimeDisplayType.EditValue = options.TimeDisplayType
            rgrpAptImages.SelectedIndex = If(schedulerControl.AppointmentImages IsNot Nothing, 1, 0)
        End Sub

        Private Sub chkStartTimeVisibility_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs)
            DisplayOptions.StartTimeVisibility = DemoUtils.CheckStateToTimeVisibility(chkStartTimeVisibility.CheckState)
        End Sub

        Private Sub chkEndTimeVisibility_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs)
            DisplayOptions.EndTimeVisibility = DemoUtils.CheckStateToTimeVisibility(chkEndTimeVisibility.CheckState)
        End Sub

        Private Sub chkShowRecurrence_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            DisplayOptions.ShowRecurrence = chkShowRecurrence.Checked
        End Sub

        Private Sub chkShowReminder_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            DisplayOptions.ShowReminder = chkShowReminder.Checked
        End Sub

        Private Sub cbStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            DisplayOptions.StatusDisplayType = CType(cbStatus.EditValue, AppointmentStatusDisplayType)
        End Sub

        Private Sub cbTimeDisplayType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            DisplayOptions.TimeDisplayType = CType(cbTimeDisplayType.EditValue, AppointmentTimeDisplayType)
        End Sub

        Private Sub schedulerControl_InitAppointmentImages(ByVal sender As Object, ByVal e As AppointmentImagesEventArgs)
            If Not IsCustomAppointmentImages Then Return
            Dim apt As Appointment = e.Appointment
            Dim c As AppointmentImageInfoCollection = e.ImageInfoList
            c.Clear()
            c.Images = CustomImages
            If e.Appointment.IsRecurring Then
                SetRecurrentAppointmentImages(c, e.Appointment.IsException)
            Else
                SetNotRecurrentAppointmentImages(c, e.Appointment)
            End If

            If DisplayOptions.ShowReminder AndAlso apt.HasReminder Then c.AddStandard(AppointmentImageType.Reminder)
        End Sub

        Private Sub SetRecurrentAppointmentImages(ByVal c As AppointmentImageInfoCollection, ByVal isException As Boolean)
            If Not DisplayOptions.ShowRecurrence Then Return
            If isException Then
                AddImageByIndex(c, CustomImagesExceptionIndex)
                Dim info As AppointmentImageInfo = New AppointmentImageInfo()
                info.Image = SystemIcons.Warning.ToBitmap()
                c.Add(info)
            Else
                AddImageByIndex(c, CustomImagesOccurenceIndex)
            End If
        End Sub

        Private Sub SetNotRecurrentAppointmentImages(ByVal c As AppointmentImageInfoCollection, ByVal apt As Appointment)
            AddImageByIndex(c, CustomImagesBizTripIndex)
            AddImageByIndex(c, CustomImagesHolidayIndex)
        End Sub

        Private Sub AddImageByIndex(ByVal c As AppointmentImageInfoCollection, ByVal index As Integer)
            Dim info As AppointmentImageInfo = New AppointmentImageInfo()
            info.ImageIndex = index
            c.Add(info)
        End Sub

        Private Sub schedulerControl_InitAppointmentDisplayText(ByVal sender As Object, ByVal e As AppointmentDisplayTextEventArgs)
            If Not chkText.Checked Then Return
            Dim apt As Appointment = e.Appointment
            e.Text = GetCustomSubject(apt)
            e.Description = GetCustomDescription(apt)
        End Sub

        Private Function GetCustomSubject(ByVal apt As Appointment) As String
            Dim s As String = apt.Subject
            If apt.Location.Length > 0 Then
                s += String.Format(" - [{0}]", apt.Location)
            End If

            Return s
        End Function

        Private Function GetCustomDescription(ByVal apt As Appointment) As String
            Dim s As String = apt.Description
            If apt.IsRecurring Then
                Return String.Format("{0}" & Microsoft.VisualBasic.Constants.vbCrLf & "Occurs on {1}", s, RecurrenceInfo.GetDescription(apt, schedulerControl.FirstDayOfWeek))
            End If

            Return s
        End Function

        Private Sub chkCustomDisplayText_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.ActiveView.LayoutChanged()
        End Sub

        Private Sub chkCustomImages_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.AppointmentImages = If(IsExternalAppointmentImages, imcAppointmentIcons, Nothing)
        End Sub

        Private Sub chkToolTip_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.ToolTipController = If(chkToolTip.Checked, toolTipController1, Nothing)
        End Sub

        Private Sub toolTipController1_BeforeShow(ByVal sender As Object, ByVal e As ToolTipControllerShowEventArgs)
            Dim controller As ToolTipController = TryCast(sender, ToolTipController)
            Dim aptViewInfo As AppointmentViewInfo = TryCast(controller.ActiveObject, AppointmentViewInfo)
            If aptViewInfo Is Nothing Then Return
            Dim apt As Appointment = aptViewInfo.Appointment
            If apt Is Nothing Then Return
            e.IconType = ToolTipIconType.Information
            e.Title = e.ToolTip
            e.ToolTip = GetCustomDescription(apt)
        End Sub

        Private Sub rgrpAptImages_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.AppointmentImages = If(IsExternalAppointmentImages, imcAppointmentIcons, Nothing)
            schedulerControl.ActiveView.LayoutChanged()
        End Sub
    End Class
End Namespace
