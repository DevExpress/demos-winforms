Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class CalendarOptionsControl
        Inherits UserControl

        Private chkEditList As CheckEdit()

        Public Sub New()
            InitializeComponent()
            FillTime(cbStartTime)
            FillTime(cbEndTime)
            chkEditList = New CheckEdit() {chkSun, chkMo, chkTu, chkWed, chkThu, chkFri, chkSat}
            FillDayOfWeek(cbFirstDayOfWeek)
        End Sub

        Public Sub LoadOptions(ByVal options As CommonOptions)
            cbStartTime.EditValue = options.WorkTime.Start
            cbEndTime.EditValue = options.WorkTime.End
            For i As Integer = 0 To chkEditList.Length - 1
                chkEditList(i).Checked =(1 << i And CInt(options.WorkDays)) <> 0
            Next

            cbFirstDayOfWeek.EditValue = options.FirstDayOfWeek
            chkEnableReminders.Checked = options.EnableReminders
            chkEnableNavigationButtons.Checked = options.EnableNavigationButtons
            chkAllowEditAppointment.Checked = options.AllowEditAppointment
            Me.chkAllowAsyncLayout.Checked = options.AllowAsyncLayout
        End Sub

        Public Sub SaveOptions(ByVal options As CommonOptions)
            Dim start As TimeSpan = CType(cbStartTime.EditValue, TimeSpan)
            Dim [end] As TimeSpan = CType(cbEndTime.EditValue, TimeSpan)
            If start > [end] Then [end] = start + TimeSpan.FromHours(1)
            options.WorkTime = New TimeOfDayInterval(start, [end])
            Dim workDays As Integer = 0
            For i As Integer = 0 To chkEditList.Length - 1
                If chkEditList(i).Checked Then workDays = workDays Or 1 << i
            Next

            options.WorkDays = CType(workDays, WeekDays)
            options.FirstDayOfWeek = CType(cbFirstDayOfWeek.EditValue, FirstDayOfWeek)
            options.EnableReminders = chkEnableReminders.Checked
            options.EnableNavigationButtons = chkEnableNavigationButtons.Checked
            options.AllowEditAppointment = chkAllowEditAppointment.Checked
            options.AllowAsyncLayout = Me.chkAllowAsyncLayout.Checked
        End Sub

        Private Sub FillTime(ByVal cbTime As ComboBoxEdit)
            cbTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            cbTime.Properties.DisplayFormat.FormatString = "hh\:mm"
            Dim span As TimeSpan = TimeSpan.Zero
            While span < TimeSpan.FromHours(23)
                cbTime.Properties.Items.Add(span)
                span += TimeSpan.FromMinutes(15)
            End While
        End Sub

        Private Sub FillDayOfWeek(ByVal cbDayOfWeek As ComboBoxEdit)
            cbDayOfWeek.Properties.Items.Add(FirstDayOfWeek.Sunday)
            cbDayOfWeek.Properties.Items.Add(FirstDayOfWeek.Monday)
            cbDayOfWeek.Properties.Items.Add(FirstDayOfWeek.Tuesday)
            cbDayOfWeek.Properties.Items.Add(FirstDayOfWeek.Wednesday)
            cbDayOfWeek.Properties.Items.Add(FirstDayOfWeek.Thursday)
            cbDayOfWeek.Properties.Items.Add(FirstDayOfWeek.Friday)
            cbDayOfWeek.Properties.Items.Add(FirstDayOfWeek.Saturday)
        End Sub
    End Class
End Namespace
