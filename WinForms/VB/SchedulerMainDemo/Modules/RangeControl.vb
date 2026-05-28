Imports System
Imports DevExpress.XtraEditors.Controls
Imports System.Drawing

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class RangeControlModule
        Inherits TutorialControl

        Const DailySchedulerType As Integer = 0

        Const MonthlySchedulerType As Integer = 1

        Const YearlySchedulerType As Integer = 2

        Private startDate As Date = GetStartDate()

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            UpdateSchedulerType(DailySchedulerType)
            InitPropertyEditors()
        ' TODO: Add any initialization after the InitializeComponent call
        End Sub

        Protected Overrides ReadOnly Property TakeScreenDelay As Integer
            Get
                Return 300
            End Get
        End Property

        Public Overrides ReadOnly Property PrintingSchedulerControl As SchedulerControl
            Get
                Return schedulerControl
            End Get
        End Property

        Public ReadOnly Property Options As SchedulerOptionsRangeControl
            Get
                Return schedulerControl.OptionsRangeControl
            End Get
        End Property

        Private Sub MonthViewModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            FillData(schedulerControl, schedulerStorage)
        End Sub

        Private Sub InitPropertyEditors()
            chkAutoFormatCaptions.Checked = Options.AutoFormatScaleCaptions
            chkAllowChangeActiveView.Checked = Options.AllowChangeActiveView
            Options.MaxSelectedIntervalCount = 7
            spinMaxIntervalCount.EditValue = Options.MaxSelectedIntervalCount
            spinThumbnailHeight.EditValue = Options.ThumbnailHeight
            cbThumbnailDisplay.EditValue = Options.DataDisplayType
        End Sub

        Private Sub rgrpSchedulerType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateSchedulerType(Convert.ToInt32(rgrpSchedulerType.EditValue))
        End Sub

        Private Sub chkAutoFormatCaptions_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Options.AutoFormatScaleCaptions = chkAutoFormatCaptions.Checked
        End Sub

        Private Sub chkAllowChangeActiveView_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Options.AllowChangeActiveView = chkAllowChangeActiveView.Checked
        End Sub

        Private Sub cbThumbnailDisplay_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim item As ImageComboBoxItem = CType(cbThumbnailDisplay.SelectedItem, ImageComboBoxItem)
            Options.DataDisplayType = CType(item.Value, RangeControlDataDisplayType)
        End Sub

        Private Sub spinMaxIntervalCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Options.MaxSelectedIntervalCount = Convert.ToInt32(spinMaxIntervalCount.EditValue)
        End Sub

        Private Sub spinThumbnailHeight_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Options.ThumbnailHeight = Convert.ToInt32(spinThumbnailHeight.EditValue)
        End Sub

        Private Sub UpdateSchedulerType(ByVal schedulerType As Integer)
            Dim baseDate As Date = startDate
            Dim scales As TimeScaleCollection = schedulerControl.OptionsRangeControl.Scales
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
                    schedulerControl.ActiveViewType = SchedulerViewType.Month
                    Exit Select
                Case YearlySchedulerType
                    scales.Add(New TimeScaleYear())
                    scales.Add(New TimeScaleQuarter())
                    scales.Add(New TimeScaleMonth())
                    rangeInterval = New TimeInterval(baseDate.AddYears(-1), baseDate.AddYears(1))
                    schedulerControl.ActiveViewType = SchedulerViewType.Timeline
                    Exit Select
            End Select

            scales.EndUpdate()
            SetRangeInterval(rangeInterval)
            chkAutoFormatCaptions.Enabled = schedulerType <> YearlySchedulerType
        End Sub

        Private Sub SetRangeInterval(ByVal interval As TimeInterval)
            Options.RangeMinimum = interval.Start
            Options.RangeMaximum = interval.End
            schedulerControl.LimitInterval = interval
        End Sub
    End Class
End Namespace
