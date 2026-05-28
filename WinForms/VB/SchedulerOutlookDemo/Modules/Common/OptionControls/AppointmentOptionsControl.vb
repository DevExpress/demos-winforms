Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class AppointmentOptionsControl
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
            'this.cbAppointmentFontSize.
            For i As Single = 5 To 20 - 1
                cbAppointmentFontSize.Properties.Items.Add(i)
            Next
        End Sub

        Public Sub LoadOptions(ByVal options As CommonOptions)
            cbAppointmentFontSize.EditValue = options.FontSize
            cbAppointmentFontSize.Properties.OwnerEdit.Properties.Mask.MaskType = XtraEditors.Mask.MaskType.Numeric
            feAppointment.EditValue = options.FontFamilyName
            chkAppointmentShowReminder.Checked = options.ShowAppointmentReminder
            chkAppointmentShowRecurrence.Checked = options.ShowAppointmentRecurrence
        End Sub

        Public Sub SaveOptions(ByVal options As CommonOptions)
            options.FontSize = CSng(cbAppointmentFontSize.EditValue)
            options.FontFamilyName = CStr(feAppointment.EditValue)
            options.ShowAppointmentReminder = chkAppointmentShowReminder.Checked
            options.ShowAppointmentRecurrence = chkAppointmentShowRecurrence.Checked
        End Sub
    End Class
End Namespace
