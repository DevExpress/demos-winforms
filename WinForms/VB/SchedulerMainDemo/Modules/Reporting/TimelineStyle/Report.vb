Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos.Reporting.TimelineStyle

    ''' <summary>
    ''' Summary description for Report.
    ''' </summary>
    Public Partial Class Report
        Inherits XtraSchedulerReport

        Private firstTimeScale As String = "Year"

        Private secondTimeScale As String = "Month"

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Property VisibleIntervalCount As Integer
            Get
                Return reportTimelineView1.VisibleIntervalCount
            End Get

            Set(ByVal value As Integer)
                reportTimelineView1.VisibleIntervalCount = value
            End Set
        End Property

        Public Property VisibleResourceCount As Integer
            Get
                Return reportTimelineView1.VisibleResourceCount
            End Get

            Set(ByVal value As Integer)
                reportTimelineView1.VisibleResourceCount = value
            End Set
        End Property

        Public ReadOnly Property Scales As TimeScaleCollection
            Get
                Return reportTimelineView1.Scales
            End Get
        End Property

        Public Property FirstLevelTimeScale As String
            Get
                Return firstTimeScale
            End Get

            Set(ByVal value As String)
                If Equals(firstTimeScale, value) Then Return
                firstTimeScale = value
                UpdateTimeScales()
            End Set
        End Property

        Public Property SecondLevelTimeScale As String
            Get
                Return secondTimeScale
            End Get

            Set(ByVal value As String)
                If Equals(secondTimeScale, value) Then Return
                secondTimeScale = value
                UpdateTimeScales()
            End Set
        End Property

        Private Sub UpdateTimeScales()
            Dim reportScales As TimeScaleCollection = reportTimelineView1.Scales
            reportScales.BeginUpdate()
            Try
                For Each item As TimeScale In reportScales
                    item.Enabled = Equals(item.DisplayName, firstTimeScale) OrElse Equals(item.DisplayName, secondTimeScale)
                Next
            Finally
                reportScales.EndUpdate()
            End Try
        End Sub
    End Class
End Namespace
