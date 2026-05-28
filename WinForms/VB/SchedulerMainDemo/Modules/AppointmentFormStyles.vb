Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraScheduler.UI

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class AppointmentFormStylesModule
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
        ' TODO: Add any initialization after the InitializeComponent call
        End Sub

        Public Overrides ReadOnly Property PrintingSchedulerControl As SchedulerControl
            Get
                Return schedulerControl
            End Get
        End Property

        Private Sub AppointmentFormStylesModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            FillData(schedulerControl, schedulerDataStorage)
        End Sub

        Private Sub schedulerControl_EditAppointmentFormShowing(ByVal sender As Object, ByVal e As AppointmentFormEventArgs)
            Dim form As XtraForm
            If rgrpAptFormStyle.SelectedIndex = 0 Then ' Outlook
                form = New AppointmentRibbonForm(schedulerControl, e.Appointment, e.OpenRecurrenceForm)
                CType(form, AppointmentRibbonForm).ReadOnly = e.ReadOnly ' Default
            Else
                form = New AppointmentForm(schedulerControl, e.Appointment, e.OpenRecurrenceForm)
                CType(form, AppointmentForm).ReadOnly = e.ReadOnly
            End If

            form.LookAndFeel.ParentLookAndFeel = schedulerControl.LookAndFeel
            e.DialogResult = form.ShowDialog(e.Parent)
            e.Handled = True
        End Sub
    End Class
End Namespace
