Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos.Reporting.AutoHeight

    ''' <summary>
    ''' Summary description for Report.
    ''' </summary>
    Public Partial Class TimelineReport
        Inherits XtraSchedulerReport
        Implements IAutoHeightReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Property VisibleResourceCount As Integer
            Get
                Return reportTimelineView1.VisibleResourceCount
            End Get

            Set(ByVal value As Integer)
                reportTimelineView1.VisibleResourceCount = value
            End Set
        End Property

        Public Property CellsLayoutType As ControlContentLayoutType
            Get
                Return timelineCells.VerticalLayoutType
            End Get

            Set(ByVal value As ControlContentLayoutType)
                timelineCells.VerticalLayoutType = value
            End Set
        End Property

        Public Property CellsHeight As Single Implements IAutoHeightReport.CellsHeight
            Get
                Return timelineCells.HeightF
            End Get

            Set(ByVal value As Single)
                timelineCells.HeightF = value
            End Set
        End Property

        Public Property CellsCanShrink As Boolean Implements IAutoHeightReport.CellsCanShrink
            Get
                Return timelineCells.CanShrink
            End Get

            Set(ByVal value As Boolean)
                timelineCells.CanShrink = value
            End Set
        End Property

        Public Property CellsCanGrow As Boolean Implements IAutoHeightReport.CellsCanGrow
            Get
                Return timelineCells.CanGrow
            End Get

            Set(ByVal value As Boolean)
                timelineCells.CanGrow = value
            End Set
        End Property

        Public Property CompressWeekend As Boolean
            Get
                Return False
            End Get

            Set(ByVal value As Boolean)
            End Set
        End Property
    End Class
End Namespace
