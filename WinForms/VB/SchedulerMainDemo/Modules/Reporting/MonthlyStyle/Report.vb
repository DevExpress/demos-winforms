Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos.Reporting.MonthlyStyle

    ''' <summary>
    ''' Summary description for Report.
    ''' </summary>
    Public Partial Class Report
        Inherits XtraSchedulerReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Property PrintExactlyOneMonth As Boolean
            Get
                Return reportMonthView1.ExactlyOneMonth
            End Get

            Set(ByVal value As Boolean)
                reportMonthView1.ExactlyOneMonth = value
            End Set
        End Property

        Public Property VisibleResourceCount As Integer
            Get
                Return reportMonthView1.VisibleResourceCount
            End Get

            Set(ByVal value As Integer)
                reportMonthView1.VisibleResourceCount = value
            End Set
        End Property

        Public Property DontPrintWeekends As Boolean
            Get
                Return horizontalWeek1.VisibleWeekDays.Equals(WeekDays.WorkDays)
            End Get

            Set(ByVal value As Boolean)
                If value Then
                    horizontalWeek1.VisibleWeekDays = WeekDays.WorkDays
                Else
                    horizontalWeek1.VisibleWeekDays = WeekDays.EveryDay
                End If
            End Set
        End Property

        Public Property CompressWeekend As Boolean
            Get
                Return horizontalWeek1.CompressWeekend
            End Get

            Set(ByVal value As Boolean)
                horizontalWeek1.CompressWeekend = value
            End Set
        End Property

        Public Property ColumnCount As Integer
            Get
                Return reportMonthView1.VisibleWeekDayColumnCount
            End Get

            Set(ByVal value As Integer)
                If reportMonthView1.VisibleWeekDayColumnCount = value Then Return
                reportMonthView1.VisibleWeekDayColumnCount = value
                OnColumnCountChanged()
            End Set
        End Property

        Private Sub OnColumnCountChanged()
            If ColumnCount = 2 Then
                timeIntervalInfo1.PrintInColumn = PrintInColumnMode.Odd
                calendarControl1.PrintInColumn = PrintInColumnMode.Even
                timeIntervalInfo1.PrintContentMode = PrintContentMode.AllColumns
            Else
                timeIntervalInfo1.PrintInColumn = PrintInColumnMode.All
                calendarControl1.PrintInColumn = PrintInColumnMode.All
                timeIntervalInfo1.PrintContentMode = PrintContentMode.CurrentColumn
            End If
        End Sub
    End Class
End Namespace
