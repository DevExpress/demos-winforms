Imports System

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class TimelineViewModule
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            PrepareViews()
        End Sub

        Public Overrides ReadOnly Property PrintingSchedulerControl As SchedulerControl
            Get
                Return schedulerControl
            End Get
        End Property

        Protected ReadOnly Property DisplayOptions As AppointmentDisplayOptions
            Get
                Return schedulerControl.TimelineView.AppointmentDisplayOptions
            End Get
        End Property

        Private ReadOnly Property TimeIndicatorDisplayOptions As TimeIndicatorDisplayOptions
            Get
                Return CType(schedulerControl.TimelineView.TimeIndicatorDisplayOptions, TimeIndicatorDisplayOptions)
            End Get
        End Property

        Private Sub PrepareViews()
            schedulerControl.DayView.Enabled = True
            schedulerControl.WeekView.Enabled = False
            schedulerControl.WorkWeekView.Enabled = False
            schedulerControl.MonthView.Enabled = False
            schedulerControl.AgendaView.Enabled = False
        End Sub

        Private Sub TimelineViewModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            FillData(schedulerControl, schedulerDataStorage)
            UpdateControls()
        End Sub

        Private Sub TimelineViewModule_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.ActiveViewType = SchedulerViewType.Timeline
        End Sub

        Private Sub UpdateControls()
            Dim options As AppointmentDisplayOptions = DisplayOptions
            chkAutoHeight.Checked = options.AppointmentAutoHeight
            spinHeight.Value = options.AppointmentHeight
            cbSnapToCellsMode.EditValue = options.SnapToCellsMode
            cbStatus.EditValue = options.StatusDisplayType
            chkSelectionBarVisible.Checked = schedulerControl.TimelineView.SelectionBar.Visible
            spinSelectionBarHeight.Value = schedulerControl.TimelineView.SelectionBar.Height
            UpdateTimeScaleWidthTrackBar()
            chkShowOverAppointment.Checked = TimeIndicatorDisplayOptions.ShowOverAppointment
            cbTimeIndicatorVisibility.EditValue = TimeIndicatorDisplayOptions.Visibility
        End Sub

        Private Sub UpdateTimeScaleWidthTrackBar()
            trckScaleWidth.Value = schedulerControl.TimelineView.GetBaseTimeScale().Width
            trckScaleWidth.Enabled = schedulerControl.TimelineView.Scales.Count > 0
        End Sub

        Private Sub chkSelectionBarVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.TimelineView.SelectionBar.Visible = chkSelectionBarVisible.Checked
        End Sub

        Private Sub spinSelectionBarHeight_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.TimelineView.SelectionBar.Height = Convert.ToInt32(spinSelectionBarHeight.Value)
        End Sub

        Private Sub btnEditScales_Click(ByVal sender As Object, ByVal e As EventArgs)
            EditTimeScales(schedulerControl.TimelineView.Scales)
            UpdateTimeScaleWidthTrackBar()
        End Sub

        Private Sub EditTimeScales(ByVal scales As TimeScaleCollection)
            Dim frm As TimeScalesEditForm = New TimeScalesEditForm(scales, FindForm())
            frm.ShowDialog()
        End Sub

        Private Sub chkAutoHeight_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            DisplayOptions.AppointmentAutoHeight = chkAutoHeight.Checked
        End Sub

        Private Sub spinHeight_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            DisplayOptions.AppointmentHeight = Convert.ToInt32(spinHeight.Value)
        End Sub

        Private Sub cbStatus_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not GetType(AppointmentStatusDisplayType).IsAssignableFrom(cbStatus.EditValue.GetType()) Then Return
            DisplayOptions.StatusDisplayType = CType(cbStatus.EditValue, AppointmentStatusDisplayType)
        End Sub

        Private Sub cbSnapToCellsMode_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            DisplayOptions.SnapToCellsMode = CType(cbSnapToCellsMode.EditValue, AppointmentSnapToCellsMode)
        End Sub

        Private Sub trckScaleWidth_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.TimelineView.GetBaseTimeScale().Width = trckScaleWidth.Value
        End Sub

        Private Sub chkShowOverAppointment_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            TimeIndicatorDisplayOptions.ShowOverAppointment = chkShowOverAppointment.Checked
        End Sub

        Private Sub cbTimeIndicatorVisibility_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            TimeIndicatorDisplayOptions.Visibility = CType(cbTimeIndicatorVisibility.EditValue, TimeIndicatorVisibility)
        End Sub

        Private Sub chkStatusOrientation_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim timelineViewOptions As TimelineViewAppointmentDisplayOptionsEx = TryCast(DisplayOptions, TimelineViewAppointmentDisplayOptionsEx)
            If timelineViewOptions IsNot Nothing Then timelineViewOptions.ShowAppointmentStatusVertically = chkStatusOrientation.Checked
        End Sub
    End Class
End Namespace
