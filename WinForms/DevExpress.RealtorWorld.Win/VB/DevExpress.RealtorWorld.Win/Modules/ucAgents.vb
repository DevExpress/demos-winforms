Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors

Namespace DevExpress.RealtorWorld.Win

    Public Partial Class ucAgents
        Inherits BaseModule

        Private ReadOnly Property NorthEastSeries As Series
            Get
                Return ccAgent.Series(0)
            End Get
        End Property

        Private ReadOnly Property MidWestSeries As Series
            Get
                Return ccAgent.Series(1)
            End Get
        End Property

        Private ReadOnly Property SouthSeries As Series
            Get
                Return ccAgent.Series(2)
            End Get
        End Property

        Private ReadOnly Property WestSeries As Series
            Get
                Return ccAgent.Series(3)
            End Get
        End Property

        Private ReadOnly Property VisualRangeX As VisualRange
            Get
                Return CType(ccAgent.Diagram, XYDiagram).AxisX.VisualRange
            End Get
        End Property

        Private ReadOnly Property WholeRangeX As WholeRange
            Get
                Return CType(ccAgent.Diagram, XYDiagram).AxisX.WholeRange
            End Get
        End Property

        Private ReadOnly Property AxisX As AxisX
            Get
                Return CType(ccAgent.Diagram, XYDiagram).AxisX
            End Get
        End Property

        Public Overrides ReadOnly Property ModuleCaption As String
            Get
                Return "Agents"
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            pnlList.ItemSize = 137
            Dim width As Integer = pnlList.ItemSize * 2
            CType(pnlList, ITileControl).Properties.LargeItemWidth = width
            pnlList.Width = width + pnlList.Padding.Horizontal + SystemInformation.VerticalScrollBarWidth + 2
        End Sub

        Friend Overrides Sub HideModule()
            MyBase.HideModule()
            gridView1.HideCustomization()
        End Sub

        Private Sub pnlList_ItemClick(ByVal sender As Object, ByVal e As TileItemEventArgs)
            InitData(CType(e.Item.Tag, Agent))
        End Sub

        Private Sub gridControl1_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim currentHome As Home = TryCast(gridView1.GetFocusedRow(), Home)
            If currentHome IsNot Nothing AndAlso gridView1.CalcHitInfo(e.Location).InRow Then
                Dim main As IMainForm = TryCast(FindForm(), IMainForm)
                If main IsNot Nothing Then main.ShowHome(currentHome)
            End If
        End Sub

        Friend Overrides Sub InitModule(ByVal manager As IDXMenuManager, ByVal data As Object)
            MyBase.InitModule(manager, data)
            Dim group As TileGroup = New TileGroup()
            For Each agent As Agent In DataHelper.Agents
                Dim item As TileItem = New TileItem()
                item.ItemSize = TileItemSize.Wide
                item.Appearance.BackColor = Color.FromArgb(102, 102, 102)
                item.AppearanceSelected.BackColor = CommonSkins.GetSkin(LookAndFeel.ActiveLookAndFeel).Colors("Highlight")
                item.BackgroundImageScaleMode = TileItemImageScaleMode.NoScale
                item.BackgroundImageAlignment = TileItemContentAlignment.MiddleRight
                item.BackgroundImage = DataHelper.GetScaleImage(agent.Photo, 65)
                item.Text = String.Format("<size=+3>{0} {1}<size=-2><br>{2}", agent.FirstName, agent.LastName, agent.Phone)
                'item.Text3 = string.Format("{0}", agent.Email);
                item.Tag = agent
                group.Items.Add(item)
            Next

            pnlList.Groups.Add(group)
        End Sub

        Friend Overrides Sub ShowModule(ByVal item As Object)
            MyBase.ShowModule(item)
            InitData(CType(item, Agent))
            DataHelper.SetTileSelectedItem(item, pnlList)
        End Sub

        Private Sub InitData(ByVal agent As Agent)
            If agent Is Nothing Then Return
            gridControl1.DataSource = DataHelper.GetHomesByAgent(agent)
            gridControl1.Focus()
            Dim random = New Data.Utils.NonCryptographicRandom(agent.ID)
            Dim year As Integer = Date.Now.Year
            ccAgent.BeginInit()
            Try
                NorthEastSeries.Points.Clear()
                MidWestSeries.Points.Clear()
                SouthSeries.Points.Clear()
                WestSeries.Points.Clear()
                For i As Integer = 0 To 10 - 1
                    Dim [date] As Date = New DateTime(year - i, 1, 1)
                    NorthEastSeries.Points.Add(New SeriesPoint([date], random.Next(5)))
                    MidWestSeries.Points.Add(New SeriesPoint([date], random.Next(10)))
                    SouthSeries.Points.Add(New SeriesPoint([date], random.Next(20)))
                    WestSeries.Points.Add(New SeriesPoint([date], random.Next(15)))
                Next
            Finally
                ccAgent.EndInit()
            End Try

            CType(ccAgent.Annotations(0), ImageAnnotation).Image.Image = agent.Photo
            ccAgent.Titles(0).Text = String.Format("Houses Sold by {0} {1}", agent.FirstName, agent.LastName)
            Dim min As Object = AxisX.GetScaleValueFromInternal(WholeRangeX.MaxValueInternal - 3)
            VisualRangeX.SetMinMaxValues(min, WholeRangeX.MaxValue)
        End Sub
    End Class
End Namespace
