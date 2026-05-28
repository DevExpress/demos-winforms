Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos.Reporting.VisibleWeekDays

    ''' <summary>
    ''' Summary description for Report.
    ''' </summary>
    Public Partial Class DayReport
        Inherits XtraSchedulerReport
        Implements IVisibleWeekDaysReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Property VisibleWeekDays As WeekDays Implements IVisibleWeekDaysReport.VisibleWeekDays
            Get
                Return dayViewTimeCells1.VisibleWeekDays
            End Get

            Set(ByVal value As WeekDays)
                dayViewTimeCells1.VisibleWeekDays = value
            End Set
        End Property

        Public Property DayCount As Integer
            Get
                Return reportDayView1.VisibleDayCount
            End Get

            Set(ByVal value As Integer)
                reportDayView1.VisibleDayCount = value
            End Set
        End Property
    End Class
End Namespace
