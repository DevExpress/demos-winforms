Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos.Reporting.AutoHeight

    ''' <summary>
    ''' Summary description for Report.
    ''' </summary>
    Public Partial Class MonthReport
        Inherits XtraSchedulerReport
        Implements IAutoHeightReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Property CompressWeekend As Boolean
            Get
                Return horizontalWeek.CompressWeekend
            End Get

            Set(ByVal value As Boolean)
                horizontalWeek.CompressWeekend = value
            End Set
        End Property

        Public Property CellsLayoutType As ControlContentLayoutType
            Get
                Return horizontalWeek.VerticalLayoutType
            End Get

            Set(ByVal value As ControlContentLayoutType)
                horizontalWeek.VerticalLayoutType = value
            End Set
        End Property

        Public Property CellsHeight As Single Implements IAutoHeightReport.CellsHeight
            Get
                Return horizontalWeek.HeightF
            End Get

            Set(ByVal value As Single)
                horizontalWeek.HeightF = value
            End Set
        End Property

        Public Property CellsCanShrink As Boolean Implements IAutoHeightReport.CellsCanShrink
            Get
                Return horizontalWeek.CanShrink
            End Get

            Set(ByVal value As Boolean)
                horizontalWeek.CanShrink = value
            End Set
        End Property

        Public Property CellsCanGrow As Boolean Implements IAutoHeightReport.CellsCanGrow
            Get
                Return horizontalWeek.CanGrow
            End Get

            Set(ByVal value As Boolean)
                horizontalWeek.CanGrow = value
            End Set
        End Property
    End Class
End Namespace
