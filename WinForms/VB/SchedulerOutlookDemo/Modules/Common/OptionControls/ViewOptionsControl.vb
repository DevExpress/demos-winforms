Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class ViewOptionsControl
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
            cbTimeMarkerVisibility.Properties.Items.Add(TimeMarkerVisibility.Always)
            cbTimeMarkerVisibility.Properties.Items.Add(TimeMarkerVisibility.Never)
            cbTimeMarkerVisibility.Properties.Items.Add(TimeMarkerVisibility.TodayView)
        End Sub

        Public Sub LoadOptions(ByVal options As CommonOptions)
            chkShowDayHeaders.Checked = options.ShowDayHeaders
            chkShowAllDayArea.Checked = options.ShowAllDayArea
            cbTimeMarkerVisibility.EditValue = options.TimeMarkerVisibility
            chkShowAllDayAppointmentStatusVertically.Checked = options.ShowAllDayAppointmentStatusVertically
            chkShowRightTimeRuler.Checked = options.ShowRightTimeRuler
            chkShowWeekend.Checked = options.ShowWeekEnd
            chkCompressWeekEnd.Checked = options.CompressWeekEnd
            chkShowAppointmentStatusVertically.Checked = options.ShowAppointmentStatusVertically
            chkEndTimeVisibility.Checked = options.ShowEndTime
            chkStartTimeVisibility.Checked = options.ShowStartTime
            chkShowTimeIndicatorOverAppointment.Checked = options.ShowTimeIndicatorOverAppointment
            chkShowTimeForDayViewAppointment.Checked = options.ShowTimeForDayView
        End Sub

        Public Sub SaveOptions(ByVal options As CommonOptions)
            options.ShowDayHeaders = chkShowDayHeaders.Checked
            options.ShowAllDayArea = chkShowAllDayArea.Checked
            options.TimeMarkerVisibility = CType(cbTimeMarkerVisibility.EditValue, TimeMarkerVisibility)
            options.ShowAllDayAppointmentStatusVertically = chkShowAllDayAppointmentStatusVertically.Checked
            options.ShowRightTimeRuler = chkShowRightTimeRuler.Checked
            options.ShowWeekEnd = chkShowWeekend.Checked
            options.CompressWeekEnd = chkCompressWeekEnd.Checked
            options.ShowAppointmentStatusVertically = chkShowAppointmentStatusVertically.Checked
            options.ShowEndTime = chkEndTimeVisibility.Checked
            options.ShowStartTime = chkStartTimeVisibility.Checked
            options.ShowTimeIndicatorOverAppointment = chkShowTimeIndicatorOverAppointment.Checked
            options.ShowTimeForDayView = chkShowTimeForDayViewAppointment.Checked
        End Sub
    End Class
End Namespace
