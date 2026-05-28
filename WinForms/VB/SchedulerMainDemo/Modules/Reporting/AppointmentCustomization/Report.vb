Imports System
Imports DevExpress.XtraScheduler.Reporting
Imports System.Drawing
Imports DevExpress.XtraScheduler.Drawing
Imports DevExpress.Utils

Namespace DevExpress.XtraScheduler.Demos.Reporting.AppointmentCustomization

    ''' <summary>
    ''' Summary description for Report.
    ''' </summary>
    Public Partial Class Report
        Inherits XtraSchedulerReport

        Private _allowInitAppointmentText As Boolean

        Private _allowInitAppointmentImages As Boolean

        Private _showStartTime As Boolean

        Private _showEndTime As Boolean

        Private _statusDisplayType As AppointmentStatusDisplayType

        Private _timeDisplayType As AppointmentTimeDisplayType

        Private _showBell As Boolean

        Private _showRecurrence As Boolean

        Private fCustomImages As ImageCollection

        Const CustomImagesOccurenceIndex As Integer = 0

        Const CustomImagesExceptionIndex As Integer = 1

        Const CustomImagesBizTripIndex As Integer = 2

        Const CustomImagesHolidayIndex As Integer = 3

        Public Sub New()
            InitializeComponent()
            fCustomImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources(DemoUtils.FindResourceName("Images.appointment_icons.png"), Reflection.Assembly.GetExecutingAssembly(), New Size(15, 15))
        End Sub

        Public Property AllowInitAppointmentText As Boolean
            Get
                Return _allowInitAppointmentText
            End Get

            Set(ByVal value As Boolean)
                _allowInitAppointmentText = value
            End Set
        End Property

        Public Property AllowInitAppointmentImages As Boolean
            Get
                Return _allowInitAppointmentImages
            End Get

            Set(ByVal value As Boolean)
                _allowInitAppointmentImages = value
            End Set
        End Property

        Public Property ShowStartTime As Boolean
            Get
                Return _showStartTime
            End Get

            Set(ByVal value As Boolean)
                _showStartTime = value
            End Set
        End Property

        Public Property ShowEndTime As Boolean
            Get
                Return _showEndTime
            End Get

            Set(ByVal value As Boolean)
                _showEndTime = value
            End Set
        End Property

        Public Property StatusDisplayType As AppointmentStatusDisplayType
            Get
                Return _statusDisplayType
            End Get

            Set(ByVal value As AppointmentStatusDisplayType)
                _statusDisplayType = value
            End Set
        End Property

        Public Property TimeDisplayType As AppointmentTimeDisplayType
            Get
                Return _timeDisplayType
            End Get

            Set(ByVal value As AppointmentTimeDisplayType)
                _timeDisplayType = value
            End Set
        End Property

        Public Property ShowBell As Boolean
            Get
                Return _showBell
            End Get

            Set(ByVal value As Boolean)
                _showBell = value
            End Set
        End Property

        Public Property ShowRecurrence As Boolean
            Get
                Return _showRecurrence
            End Get

            Set(ByVal value As Boolean)
                _showRecurrence = value
            End Set
        End Property

        Private Sub dayViewTimeCells1_AppointmentViewInfoCustomizing(ByVal sender As Object, ByVal e As AppointmentViewInfoCustomizingEventArgs)
            Dim vi As AppointmentViewInfo = CType(e.ViewInfo, AppointmentViewInfo)
            vi.ShowStartTime = ShowStartTime
            vi.ShowEndTime = ShowEndTime
            vi.StatusDisplayType = StatusDisplayType
            vi.ShowTimeAsClock = TimeDisplayType.Equals(AppointmentTimeDisplayType.Clock)
            vi.ShowBell = ShowBell
            vi.ShowRecurrence = ShowRecurrence
        End Sub

        Private Sub dayViewTimeCells1_InitAppointmentImages(ByVal sender As Object, ByVal e As AppointmentImagesEventArgs)
            If Not AllowInitAppointmentImages Then Return
            Dim apt As Appointment = e.Appointment
            Dim c As AppointmentImageInfoCollection = e.ImageInfoList
            c.Clear()
            c.Images = fCustomImages
            If _showBell Then c.AddStandard(AppointmentImageType.Reminder)
            If e.Appointment.IsRecurring Then
                SetRecurrentAppointmentImages(c, e.Appointment.IsException)
            Else
                SetNotRecurrentAppointmentImages(c, e.Appointment)
            End If
        End Sub

        Private Sub SetRecurrentAppointmentImages(ByVal c As AppointmentImageInfoCollection, ByVal isException As Boolean)
            If Not _showRecurrence Then Return
            If isException Then
                AddImageByIndex(c, CustomImagesExceptionIndex)
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

        Private Sub dayViewTimeCells1_InitAppointmentDisplayText(ByVal sender As Object, ByVal e As AppointmentDisplayTextEventArgs)
            If Not AllowInitAppointmentText Then Return
            e.Text = String.Format("{0} [{1:F2} h]", e.Text, e.Appointment.Duration.TotalHours)
        End Sub
    End Class
End Namespace
