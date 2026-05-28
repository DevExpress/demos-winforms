Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraScheduler.Demos.DemoData

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class RangeControlModule
        Inherits TutorialControl

        Const DailySchedulerType As Integer = 0

        Const MonthlySchedulerType As Integer = 1

        Const YearlySchedulerType As Integer = 2

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            Scheduler.LimitInterval = New TimeInterval(SchedulerDataHelper.Start.AddYears(-10), SchedulerDataHelper.Start.AddYears(10))
            Scheduler.Start = SchedulerDataHelper.Start
            UpdateSchedulerType(DailySchedulerType)
            ResetOptions()
        End Sub

        Public Overrides ReadOnly Property Scheduler As SchedulerControl
            Get
                Return schedulerControl
            End Get
        End Property

        Protected Overrides ReadOnly Property OptionsPane As Control
            Get
                Return spOptionPane
            End Get
        End Property

        Private Sub OnModuleLoad(ByVal sender As Object, ByVal e As EventArgs)
            SchedulerDataHelper.Attach(schedulerControl)
        End Sub

        Private Sub rgrpSchedulerType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateSchedulerType(Convert.ToInt32(rgrpSchedulerType.EditValue))
        End Sub

        Private Sub chkAutoFormatCaptions_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.OptionsRangeControl.AutoFormatScaleCaptions = chkAutoFormatCaptions.Checked
        End Sub

        Private Sub chkAllowChangeActiveView_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.OptionsRangeControl.AllowChangeActiveView = chkAllowChangeActiveView.Checked
        End Sub

        Private Sub cbThumbnailDisplay_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim item As ImageComboBoxItem = CType(cbThumbnailDisplay.SelectedItem, ImageComboBoxItem)
            Scheduler.OptionsRangeControl.DataDisplayType = CType(item.Value, RangeControlDataDisplayType)
        End Sub

        Private Sub spinMaxIntervalCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.OptionsRangeControl.MaxSelectedIntervalCount = Convert.ToInt32(spinMaxIntervalCount.EditValue)
        End Sub

        Private Sub spinThumbnailHeight_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.OptionsRangeControl.ThumbnailHeight = Convert.ToInt32(spinThumbnailHeight.EditValue)
        End Sub

        Private Sub UpdateSchedulerType(ByVal schedulerType As Integer)
            Dim baseDate As Date = Scheduler.Start
            Dim scales As TimeScaleCollection = Scheduler.OptionsRangeControl.Scales
            scales.BeginUpdate()
            scales.Clear()
            Dim rangeInterval As TimeInterval = TimeInterval.Empty
            Select Case schedulerType
                Case DailySchedulerType
                    scales.Add(New TimeScaleWeek())
                    scales.Add(New TimeScaleDay())
                    rangeInterval = New TimeInterval(baseDate.AddDays(-10), baseDate.AddDays(50))
                    Exit Select
                Case MonthlySchedulerType
                    Dim monthScale As TimeScaleMonth = New TimeScaleMonth()
                    monthScale.DisplayFormat = "yyyy MMMM"
                    scales.Add(monthScale)
                    Dim weekScale As TimeScaleWeek = New TimeScaleWeek()
                    weekScale.DisplayFormat = "MM/dd"
                    weekScale.Width = 80
                    scales.Add(weekScale)
                    rangeInterval = New TimeInterval(baseDate.AddMonths(-3), baseDate.AddMonths(3))
                    Scheduler.ActiveViewType = SchedulerViewType.Month
                    Exit Select
                Case YearlySchedulerType
                    scales.Add(New TimeScaleYear())
                    scales.Add(New TimeScaleQuarter())
                    scales.Add(New TimeScaleMonth())
                    rangeInterval = New TimeInterval(baseDate.AddYears(-1), baseDate.AddYears(1))
                    Scheduler.ActiveViewType = SchedulerViewType.Timeline
                    Exit Select
            End Select

            scales.EndUpdate()
            SetRangeInterval(rangeInterval)
            chkAutoFormatCaptions.Enabled = schedulerType <> YearlySchedulerType
        End Sub

        Private Sub SetRangeInterval(ByVal interval As TimeInterval)
            Scheduler.OptionsRangeControl.RangeMinimum = interval.Start
            Scheduler.OptionsRangeControl.RangeMaximum = interval.End
            Scheduler.LimitInterval = interval
        End Sub

        Public Overrides Sub ResetOptions()
            MyBase.ResetOptions()
            Scheduler.BeginUpdate()
            Try
                chkAutoFormatCaptions.Checked = True
                chkAllowChangeActiveView.Checked = True
                spinMaxIntervalCount.EditValue = 7
                spinThumbnailHeight.EditValue = 0
                cbThumbnailDisplay.EditValue = RangeControlDataDisplayType.Auto
                rgrpSchedulerType.EditValue = 0
            Finally
                Scheduler.EndUpdate()
            End Try
        End Sub
    End Class
End Namespace
