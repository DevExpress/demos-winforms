Imports System

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class RestrictionsModule
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

        Private Sub RestrictionsModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            FillData(schedulerControl, schedulerStorage)
            UpdateControls()
        End Sub

        Private Sub UpdateControls()
            Dim opts As SchedulerOptionsCustomization = schedulerControl.OptionsCustomization
            chkAllowConflicts.Checked = opts.AllowAppointmentConflicts = AppointmentConflictsMode.Allowed
            chkAllowCopy.Checked = opts.AllowAppointmentCopy = UsedAppointmentType.All
            chkAllowCreate.Checked = opts.AllowAppointmentCreate = UsedAppointmentType.All
            chkAllowDelete.Checked = opts.AllowAppointmentDelete = UsedAppointmentType.All
            chkAllowDrag.Checked = opts.AllowAppointmentDrag = UsedAppointmentType.All
            chkAllowDragBetweenResources.Checked = opts.AllowAppointmentDragBetweenResources = UsedAppointmentType.All
            chkAllowEdit.Checked = opts.AllowAppointmentEdit = UsedAppointmentType.All
            chkAllowInplaceEditor.Checked = opts.AllowInplaceEditor = UsedAppointmentType.All
            chkAllowMultiSelect.Checked = opts.AllowAppointmentMultiSelect
            chkAllowResize.Checked = opts.AllowAppointmentResize = UsedAppointmentType.All
        End Sub

        Private Sub chkAllowCreate_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.OptionsCustomization.AllowAppointmentCreate = If(chkAllowCreate.Checked, UsedAppointmentType.All, UsedAppointmentType.None)
        End Sub

        Private Sub chkAllowEdit_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.OptionsCustomization.AllowAppointmentEdit = If(chkAllowEdit.Checked, UsedAppointmentType.All, UsedAppointmentType.None)
        End Sub

        Private Sub chkAllowResize_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.OptionsCustomization.AllowAppointmentResize = If(chkAllowResize.Checked, UsedAppointmentType.All, UsedAppointmentType.None)
        End Sub

        Private Sub chkAllowConflicts_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.OptionsCustomization.AllowAppointmentConflicts = If(chkAllowConflicts.Checked, AppointmentConflictsMode.Allowed, AppointmentConflictsMode.Forbidden)
        End Sub

        Private Sub chkAllowDragBetweenResources_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.OptionsCustomization.AllowAppointmentDragBetweenResources = If(chkAllowDragBetweenResources.Checked, UsedAppointmentType.All, UsedAppointmentType.None)
        End Sub

        Private Sub chkAllowDelete_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.OptionsCustomization.AllowAppointmentDelete = If(chkAllowDelete.Checked, UsedAppointmentType.All, UsedAppointmentType.None)
        End Sub

        Private Sub chkAllowCopy_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.OptionsCustomization.AllowAppointmentCopy = If(chkAllowCopy.Checked, UsedAppointmentType.All, UsedAppointmentType.None)
        End Sub

        Private Sub chkAllowDrag_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.OptionsCustomization.AllowAppointmentDrag = If(chkAllowDrag.Checked, UsedAppointmentType.All, UsedAppointmentType.None)
        End Sub

        Private Sub chkAllowMultiSelect_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.OptionsCustomization.AllowAppointmentMultiSelect = chkAllowMultiSelect.Checked
        End Sub

        Private Sub chkAllowInplaceEditor_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.OptionsCustomization.AllowInplaceEditor = If(chkAllowInplaceEditor.Checked, UsedAppointmentType.All, UsedAppointmentType.None)
        End Sub
    End Class
End Namespace
