Imports System
Imports System.Drawing
Imports DevExpress.Utils
Imports DevExpress.Utils.Controls
Imports DevExpress.XtraScheduler.Drawing

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class AppointmentFilteringModule
        Inherits TutorialControl

        Private sportsImages As ImageCollection

        Private channelsImages As ImageCollection

        Public Sub New()
            sportsImages = ImageHelper.CreateImageCollectionFromResources(DemoUtils.FindResourceName("Images.sports.png"), Reflection.Assembly.GetExecutingAssembly(), New Size(16, 16))
            channelsImages = ImageHelper.CreateImageCollectionFromResources(DemoUtils.FindResourceName("Images.channels.png"), Reflection.Assembly.GetExecutingAssembly(), New Size(60, 40))
            InitializeComponent()
        End Sub

        Public Overrides ReadOnly Property PrintingSchedulerControl As SchedulerControl
            Get
                Return schedulerControl
            End Get
        End Property

        Private Sub ResourceSharingModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.GroupType = SchedulerGroupType.Resource
            FillFilterComboBox()
            AddSportChanels()
            FillData()
        End Sub

        Private Sub AddAppointmentLabel(ByVal id As Object, ByVal displayName As String, ByVal menuCaption As String, ByVal color As Color)
            Dim label As IAppointmentLabel = schedulerStorage.Appointments.Labels.CreateNewLabel(id, displayName, menuCaption)
            label.SetColor(color)
            schedulerStorage.Appointments.Labels.Add(label)
        End Sub

        Private Sub FillData()
            schedulerStorage.EnableReminders = False
            schedulerStorage.Appointments.Mappings.End = "Finish"
            schedulerStorage.Appointments.Mappings.Label = "SportID"
            schedulerStorage.Appointments.Mappings.ResourceId = "ResourceID"
            schedulerStorage.Appointments.Mappings.Start = "Start"
            schedulerStorage.Appointments.Mappings.Subject = "Caption"
            schedulerStorage.Appointments.Mappings.AllDay = "AllDay"
            schedulerStorage.Appointments.DataSource = DemoUtils.GetSportEventsData()
            schedulerControl.Start = New DateTime(2016, 09, 15, 9, 0, 0)
        End Sub

        Private Sub AddSportChanels()
            schedulerStorage.BeginUpdate()
            AddResource(0, "SPORT TV 1")
            AddResource(1, "SPORT TV 2")
            AddResource(2, "SPORT TV 3")
            AddResource(3, "SPORT TV 4")
            AddResource(4, "TV 5")
            AddResource(5, "TV 6")
            AddResource(6, "TV 7")
            AddResource(7, "TV 8")
            schedulerStorage.EndUpdate()
        End Sub

        Private Sub AddResource(ByVal index As Integer, ByVal caption As String)
            Dim r As Resource = schedulerStorage.CreateResource(index.ToString())
            r.Caption = caption
            r.SetImage(channelsImages.Images(index))
            r.SetColor(schedulerControl.ResourceColorSchemas.GetSchema(index).CellLight)
            schedulerStorage.Resources.Add(r)
        End Sub

        Private Sub FillFilterComboBox()
            imcbSports.Properties.SmallImages = sportsImages
            imcbSports.Properties.LargeImages = sportsImages
            imcbSports.Properties.Items.Clear()
            imcbSports.Properties.Items.Add(New XtraEditors.Controls.ImageComboBoxItem("All sports", -1, -1))
            For i As Integer = 0 To schedulerStorage.Appointments.Labels.Count - 1
                Dim lab As IAppointmentLabel = schedulerStorage.Appointments.Labels.GetByIndex(i)
                imcbSports.Properties.Items.Add(New XtraEditors.Controls.ImageComboBoxItem(lab.DisplayName, i, i))
            Next

            imcbSports.SelectedIndex = 0
        End Sub

        Private Sub cbView_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.BeginUpdate()
            Try
                AdjustResourceHeaders()
            Finally
                schedulerControl.EndUpdate()
            End Try
        End Sub

        Private Sub schedulerControl_ActiveViewChanged(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub cbGrouping_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.BeginUpdate()
            Try
                AdjustResourceHeaders()
            Finally
                schedulerControl.EndUpdate()
            End Try
        End Sub

        Private Sub AdjustResourceHeaders()
            Dim headerHeight As Integer = 0
            Dim groupType As SchedulerGroupType = schedulerControl.GroupType
            If TypeOf schedulerControl.ActiveView Is WeekView AndAlso groupType.Equals(SchedulerGroupType.Date) OrElse TypeOf schedulerControl.ActiveView Is TimelineView AndAlso Not groupType.Equals(SchedulerGroupType.None) Then headerHeight = 90
            schedulerControl.OptionsView.ResourceHeaders.Height = headerHeight
        End Sub

        Private Sub schedulerStorage_FilterAppointment(ByVal sender As Object, ByVal e As PersistentObjectCancelEventArgs)
            Dim sportId As Integer = Convert.ToInt32(imcbSports.EditValue)
            If sportId < 0 Then Return
            Dim apt As Appointment = CType(e.Object, Appointment)
            e.Cancel = Convert.ToInt32(apt.LabelKey) <> sportId
        End Sub

        Private Sub imcbSports_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerStorage.RefreshData()
        End Sub

        Private Sub schedulerControl_InitAppointmentImages(ByVal sender As Object, ByVal e As AppointmentImagesEventArgs)
            Dim info As AppointmentImageInfo = New AppointmentImageInfo()
            info.Image = sportsImages.Images(Convert.ToInt32(e.Appointment.LabelKey))
            e.ImageInfoList.Add(info)
        End Sub
    End Class
End Namespace
