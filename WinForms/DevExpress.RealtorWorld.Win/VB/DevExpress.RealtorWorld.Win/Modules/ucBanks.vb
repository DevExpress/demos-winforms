Imports System.Collections.Generic
Imports DevExpress.XtraCharts
Imports DevExpress.Utils.Menu

Namespace DevExpress.RealtorWorld.Win

    Public Partial Class ucBanks
        Inherits BaseModule

        Private ReadOnly Property FRM30 As Series
            Get
                Return ccBank.Series(0)
            End Get
        End Property

        Private ReadOnly Property FRM15 As Series
            Get
                Return ccBank.Series(1)
            End Get
        End Property

        Private ReadOnly Property ARM1 As Series
            Get
                Return ccBank.Series(2)
            End Get
        End Property

        Private ReadOnly Property VisualRangeX As VisualRange
            Get
                Return CType(ccBank.Diagram, XYDiagram).AxisX.VisualRange
            End Get
        End Property

        Private ReadOnly Property WholeRangeX As WholeRange
            Get
                Return CType(ccBank.Diagram, XYDiagram).AxisX.WholeRange
            End Get
        End Property

        Private ReadOnly Property AxisX As AxisX
            Get
                Return CType(ccBank.Diagram, XYDiagram).AxisX
            End Get
        End Property

        Public Overrides ReadOnly Property ModuleCaption As String
            Get
                Return "Mortgage rates"
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        Friend Overrides Sub InitModule(ByVal manager As IDXMenuManager, ByVal data As Object)
            MyBase.InitModule(manager, data)
            InitData(DataHelper.MortgageRates)
            gridControl1.DataSource = DataHelper.MortgageRates
        End Sub

        Friend Overrides Sub ShowModule(ByVal item As Object)
            MyBase.ShowModule(item)
            gridView1.ExpandAllGroups()
        End Sub

        Friend Overrides Sub HideModule()
            MyBase.HideModule()
            gridView1.HideCustomization()
        End Sub

        Private Sub InitData(ByVal mortgageRates As List(Of MortgageRate))
            ccBank.BeginInit()
            Try
                For Each mortgageRate As MortgageRate In mortgageRates
                    FRM30.Points.Add(New SeriesPoint(mortgageRate.Date, mortgageRate.FRM30))
                    FRM15.Points.Add(New SeriesPoint(mortgageRate.Date, mortgageRate.FRM15))
                    ARM1.Points.Add(New SeriesPoint(mortgageRate.Date, mortgageRate.ARM1))
                Next
            Finally
                ccBank.EndInit()
            End Try

            Dim min As Object = AxisX.GetScaleValueFromInternal(WholeRangeX.MaxValueInternal - 80)
            VisualRangeX.SetMinMaxValues(min, WholeRangeX.MaxValue)
        End Sub
    End Class
End Namespace
