Imports DevExpress.XtraEditors
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Navigation

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class ChangeViewForm
        Inherits XtraForm

        Private viewOptionsControl As ViewOptionsControl

        Private calendarOptionsControl As CalendarOptionsControl

        Private appointmentOptionsControl As AppointmentOptionsControl

        Public Sub New()
            InitializeComponent()
            accordionControl1.SelectedElement = accordionControlElement2
            viewOptionsControl = New ViewOptionsControl()
            calendarOptionsControl = New CalendarOptionsControl()
            appointmentOptionsControl = New AppointmentOptionsControl()
            viewOptionsControl.Dock = DockStyle.Fill
            calendarOptionsControl.Dock = DockStyle.Fill
            appointmentOptionsControl.Dock = DockStyle.Fill
            panelControl1.Controls.Add(viewOptionsControl)
            panelControl1.Controls.Add(calendarOptionsControl)
            panelControl1.Controls.Add(appointmentOptionsControl)
            UpdateCurrentOptionsVisibility()
        End Sub

        Public Sub LoadOptions(ByVal options As CommonOptions)
            viewOptionsControl.LoadOptions(options)
            calendarOptionsControl.LoadOptions(options)
            appointmentOptionsControl.LoadOptions(options)
        End Sub

        Public Sub SaveOptions(ByVal options As CommonOptions)
            viewOptionsControl.SaveOptions(options)
            calendarOptionsControl.SaveOptions(options)
            appointmentOptionsControl.SaveOptions(options)
        End Sub

        Private Sub accordionControl1_SelectedElementChanged(ByVal sender As Object, ByVal e As SelectedElementChangedEventArgs)
            If e.Element.Tag Is Nothing Then Return
            UpdateCurrentOptionsVisibility()
        End Sub

        Private Sub UpdateCurrentOptionsVisibility()
            Dim optionsName As String = accordionControl1.SelectedElement.Tag.ToString()
            SetOptionsControlVisible(viewOptionsControl, Equals(optionsName, "Views"))
            SetOptionsControlVisible(calendarOptionsControl, Equals(optionsName, "Calendars"))
            SetOptionsControlVisible(appointmentOptionsControl, Equals(optionsName, "Appointments"))
        End Sub

        Private Sub SetOptionsControlVisible(ByVal control As Control, ByVal value As Boolean)
            If control Is Nothing Then Return
            control.Visible = value
        End Sub
    End Class
End Namespace
