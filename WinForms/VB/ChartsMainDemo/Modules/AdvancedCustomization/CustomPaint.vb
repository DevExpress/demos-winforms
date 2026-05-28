Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports DevExpress.Data.Utils
Imports DevExpress.Utils.Drawing

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class CustomPaintDemo
        Inherits ChartDemoModuleWithOptions

        Private ReadOnly clusters As List(Of Cluster) = New List(Of Cluster)()

        Private ReadOnly Property XYDiagram As XYDiagram
            Get
                Return TryCast(chart.Diagram, XYDiagram)
            End Get
        End Property

        Private ReadOnly Property AxisX As AxisX
            Get
                Return XYDiagram.AxisX
            End Get
        End Property

        Private ReadOnly Property AxisY As AxisY
            Get
                Return XYDiagram.AxisY
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartDesignerEnabled As Boolean
            Get
                Return False
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            ChartControl.BeginInit()
            InitSeries()
            ProcessAutoClusters()
            ChartControl.EndInit()
        End Sub

        Private Sub InitSeries()
            If chart.Series.Count > 0 Then
                Dim random As NonCryptographicRandom = NonCryptographicRandom.System
                chart.Series(0).Points.Clear()
                chart.Series(0).Points.AddRange(CalculatePoints(random, 50, 5, 9))
                chart.Series(0).Points.AddRange(CalculatePoints(random, 50, 13, 5))
                chart.Series(0).Points.AddRange(CalculatePoints(random, 50, 10, 18))
            End If
        End Sub

        Private Sub ProcessAutoClusters()
            Dim pointsLists As List(Of PointF)() = New List(Of PointF)(2) {New List(Of PointF)(), New List(Of PointF)(), New List(Of PointF)()}
            Call CalculateClusters(chart.Series(0).Points, pointsLists(0), pointsLists(1), pointsLists(2))
            For i As Integer = 0 To 3 - 1
                Dim cluster As Cluster = New Cluster()
                cluster.Calculate(pointsLists(i))
                clusters.Add(cluster)
                If i = 0 Then
                    cluster.IsSelected = True
                End If
            Next
        End Sub

        Private Function CalculateDiagramBounds() As Rectangle
            Dim p1 As Point = XYDiagram.DiagramToPoint(CDbl(AxisX.WholeRange.MinValue), CDbl(AxisY.WholeRange.MinValue)).Point
            Dim p2 As Point = XYDiagram.DiagramToPoint(CDbl(AxisX.WholeRange.MaxValue), CDbl(XYDiagram.AxisY.WholeRange.MaxValue)).Point
            Return CreateRectangle(p1, p2)
        End Function

        Private Function GetScreenPoints(ByVal contourPoints As List(Of PointF)) As Point()
            Dim screenPoints As Point() = New Point(contourPoints.Count - 1) {}
            For i As Integer = 0 To contourPoints.Count - 1
                screenPoints(i) = XYDiagram.DiagramToPoint(contourPoints(i).X, contourPoints(i).Y).Point
            Next

            Return screenPoints
        End Function

        Private Sub DrawCluster(ByVal cluster As Cluster, ByVal g As GraphicsCache, ByVal color As Color, ByVal borderColor As Color)
            Dim screenPoints As Point() = GetScreenPoints(cluster.ContourPoints)
            If screenPoints.Length > 0 Then
                Dim fillColor As Color = Color.FromArgb(50, color.R, color.G, color.B)
                If cluster.IsSelected Then
                    g.FillPolygon(screenPoints, fillColor)
                    g.DrawPolygon(screenPoints, borderColor, 4)
                Else
                    g.FillPolygon(screenPoints, fillColor)
                    g.DrawPolygon(screenPoints, borderColor, 1)
                End If
            End If
        End Sub

        Private Sub SelectOrUnselectCluster(ByVal cluster As Cluster, ByVal point As Point)
            If cluster.Points.Count < 2 Then Return
            Dim screenPoints As Point() = GetScreenPoints(cluster.ContourPoints)
            Dim path As GraphicsPath = New GraphicsPath()
            path.AddPolygon(screenPoints)
            cluster.IsSelected = path.IsVisible(point)
        End Sub

        Private Sub chart_CustomPaint(ByVal sender As Object, ByVal e As CustomPaintEventArgs)
            Dim args As DXCustomPaintEventArgs = TryCast(e, DXCustomPaintEventArgs)
            If args Is Nothing Then Return
            Dim g As GraphicsCache = args.Cache
            If clusters.Count = 0 Then
                If Not toggleSwitchClusteringMode.IsOn Then
                    Using font As Font = New Font("Tahoma", 18)
                        g.DrawString("Drag the mouse with the Ctrl key pressed to form a cluster.", font, Brushes.LightSlateGray, New PointF(40, 60))
                    End Using
                End If

                Return
            End If

            g.ClipInfo.SetClip(CalculateDiagramBounds())
            g.SmoothingMode = SmoothingMode.AntiAlias
            Dim paletteEntries As PaletteEntry() = ChartControl.GetPaletteEntries(clusters.Count)
            For i As Integer = 0 To clusters.Count - 1
                DrawCluster(clusters(i), g, paletteEntries(i).Color, paletteEntries(i).Color)
            Next
        End Sub

        Private Sub chart_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            For Each cluster As Cluster In clusters
                SelectOrUnselectCluster(cluster, e.Location)
            Next

            ChartControl.Invalidate()
        End Sub

        Private Sub chart_SelectedItemsChanging(ByVal sender As Object, ByVal e As SelectedItemsChangingEventArgs)
            If toggleSwitchClusteringMode.IsOn Then
                e.Cancel = True
                Return
            End If

            Dim newSelectedPoints As List(Of PointF) = New List(Of PointF)()
            For Each seriesPoint As SeriesPoint In e.NewItems
                Dim point As PointF = New PointF(CSng(seriesPoint.NumericalArgument), CSng(seriesPoint.Values(0)))
                newSelectedPoints.Add(point)
            Next

            Dim cluster As Cluster = New Cluster()
            cluster.Calculate(newSelectedPoints)
            clusters.Add(cluster)
            e.Cancel = True
            ChartControl.Invalidate()
        End Sub

        Private Sub chart_ObjectHotTracked(ByVal sender As Object, ByVal e As HotTrackEventArgs)
            e.Cancel = True
        End Sub

        Private Sub simpleButtonGeneratePoints_Click(ByVal sender As Object, ByVal e As EventArgs)
            InitSeries()
            clusters.Clear()
            If toggleSwitchClusteringMode.IsOn Then ProcessAutoClusters()
            chart.Animate()
            chart.Invalidate()
        End Sub

        Private Sub toggleSwitchClusteringMode_Toggled(ByVal sender As Object, ByVal e As EventArgs)
            clusters.Clear()
            If toggleSwitchClusteringMode.IsOn Then ProcessAutoClusters()
            chart.Invalidate()
        End Sub

        Private Sub simpleButtonClearClusters_Click(ByVal sender As Object, ByVal e As EventArgs)
            clusters.Clear()
            ChartControl.Invalidate()
        End Sub
    End Class

    Friend Class Cluster

        Private pointsField As List(Of PointF) = New List(Of PointF)()

        Private sortedPointsField As List(Of PointF) = New List(Of PointF)()

        Private contourPointsField As List(Of PointF) = New List(Of PointF)()

        Private isClusterSelected As Boolean = False

        Public ReadOnly Property Points As List(Of PointF)
            Get
                Return pointsField
            End Get
        End Property

        Public ReadOnly Property SortedPoints As List(Of PointF)
            Get
                Return sortedPointsField
            End Get
        End Property

        Public ReadOnly Property ContourPoints As List(Of PointF)
            Get
                Return contourPointsField
            End Get
        End Property

        Public Property IsSelected As Boolean
            Get
                Return isClusterSelected
            End Get

            Set(ByVal value As Boolean)
                isClusterSelected = value
            End Set
        End Property

        Public Sub Calculate(ByVal points As List(Of PointF))
            pointsField = points
            sortedPointsField = Sort(points)
            contourPointsField = CreateClosedCircuit(sortedPointsField)
            isClusterSelected = False
        End Sub

        Public Sub Clear()
            pointsField.Clear()
            sortedPointsField.Clear()
            contourPointsField.Clear()
            isClusterSelected = False
        End Sub
    End Class

    Friend Module DiagramToPointHelper

        Const Epsilon As Double = 0.001

        Private Function CalcRandomPoint(ByVal random As NonCryptographicRandom, ByVal xCenter As Integer, ByVal yCenter As Integer) As PointF
            Const dispersion As Integer = 2
            Const expectedSum As Integer = 6
            Dim point As PointF = New PointF()
            Dim sum As Double = 0
            For i As Integer = 0 To 12 - 1
                sum += random.NextDouble()
            Next

            Dim radius As Double =(sum - expectedSum) * dispersion
            Dim angle As Double = random.Next(360) * Math.PI / 180
            point.X = CSng(xCenter + radius * Math.Cos(angle))
            point.Y = CSng(yCenter + radius * Math.Sin(angle))
            Return point
        End Function

        Private Function AreEqual(ByVal point1 As PointF, ByVal point2 As PointF) As Boolean
            Return AreEqual(point1.X, point2.X) AndAlso AreEqual(point1.Y, point2.Y)
        End Function

        Private Function AreEqual(ByVal number1 As Double, ByVal number2 As Double) As Boolean
            Dim difference As Double = number1 - number2
            If Math.Abs(difference) <= Epsilon Then Return True
            Return False
        End Function

        Private Function GetClusterCenter(ByVal cluster As List(Of PointF)) As PointF
            If cluster.Count = 0 Then Return PointF.Empty
            Dim centerX As Single = 0
            Dim centerY As Single = 0
            For Each point As PointF In cluster
                centerX += point.X
                centerY += point.Y
            Next

            centerX /= cluster.Count
            centerY /= cluster.Count
            Return New PointF(centerX, centerY)
        End Function

        Private Sub CreateUpperArc(ByVal cluster As List(Of PointF), ByVal sortedCluster As List(Of PointF))
            For i As Integer = 1 To cluster.Count - 1
                If i + 1 = cluster.Count Then
                    sortedCluster.Add(cluster(i))
                    Exit For
                End If

                Dim shouldAddPoint As Boolean = False
                Dim x0 As Single = sortedCluster(sortedCluster.Count - 1).X
                Dim y0 As Single = sortedCluster(sortedCluster.Count - 1).Y
                Dim x1 As Single = cluster(i).X
                Dim y1 As Single = cluster(i).Y
                If x1 = x0 Then
                    If y0 < y1 Then shouldAddPoint = True
                Else
                    For j As Integer = i + 1 To cluster.Count - 1
                        If cluster(j).Y >= CDbl((cluster(j).X - x0)) * CDbl(y1 - y0) / CDbl(x1 - x0) + y0 Then
                            shouldAddPoint = False
                            Exit For
                        Else
                            shouldAddPoint = True
                        End If
                    Next
                End If

                If shouldAddPoint Then sortedCluster.Add(cluster(i))
            Next
        End Sub

        Private Sub CreateBottomArc(ByVal cluster As List(Of PointF), ByVal sortedCluster As List(Of PointF))
            For i As Integer = cluster.Count - 1 To 0 Step -1
                If i = 0 Then
                    sortedCluster.Add(cluster(i))
                    Exit For
                End If

                Dim shouldAddPoint As Boolean = False
                Dim x0 As Single = sortedCluster(sortedCluster.Count - 1).X
                Dim y0 As Single = sortedCluster(sortedCluster.Count - 1).Y
                Dim x1 As Single = cluster(i).X
                Dim y1 As Single = cluster(i).Y
                If x1 = x0 Then
                    If y0 > y1 Then shouldAddPoint = True
                Else
                    For j As Integer = i - 1 To 0 Step -1
                        If cluster(j).Y <= CDbl((cluster(j).X - x0)) * CDbl(y1 - y0) / CDbl(x1 - x0) + y0 Then
                            shouldAddPoint = False
                            Exit For
                        Else
                            shouldAddPoint = True
                        End If
                    Next
                End If

                If shouldAddPoint Then sortedCluster.Add(cluster(i))
            Next
        End Sub

        Public Function CreateRectangle(ByVal corner1 As Point, ByVal corner2 As Point) As Rectangle
            Dim x As Integer = If(corner1.X < corner2.X, corner1.X, corner2.X)
            Dim y As Integer = If(corner1.Y < corner2.Y, corner1.Y, corner2.Y)
            Dim width As Integer = Math.Abs(corner1.X - corner2.X)
            Dim height As Integer = Math.Abs(corner1.Y - corner2.Y)
            Return New Rectangle(x, y, width, height)
        End Function

        Public Function CreateRectangle(ByVal corner1 As PointF, ByVal corner2 As PointF) As RectangleF
            Dim x As Single = If(corner1.X < corner2.X, corner1.X, corner2.X)
            Dim y As Single = If(corner1.Y < corner2.Y, corner1.Y, corner2.Y)
            Dim width As Single = Math.Abs(corner1.X - corner2.X)
            Dim height As Single = Math.Abs(corner1.Y - corner2.Y)
            Return New RectangleF(x, y, width, height)
        End Function

        Public Function GetLastSelectionCornerPosition(ByVal p As Point, ByVal bounds As Rectangle) As Point
            If p.X < bounds.Left Then
                p.X = bounds.Left
            ElseIf p.X > bounds.Right Then
                p.X = bounds.Right - 1
            End If

            If p.Y < bounds.Top Then
                p.Y = bounds.Top
            ElseIf p.Y > bounds.Bottom Then
                p.Y = bounds.Bottom - 1
            End If

            Return p
        End Function

        Public Function CalculatePoints(ByVal random As NonCryptographicRandom, ByVal count As Integer, ByVal xCenter As Integer, ByVal yCenter As Integer) As SeriesPoint()
            Dim seriesPoints As SeriesPoint() = New SeriesPoint(count - 1) {}
            For i As Integer = 0 To count - 1
                Dim point As PointF = CalcRandomPoint(random, xCenter, yCenter)
                seriesPoints(i) = New SeriesPoint(point.X, New Double() {point.Y})
            Next

            Return seriesPoints
        End Function

        Public Sub CalculateClusters(ByVal seriesPoints As SeriesPointCollection, ByVal cluster1 As List(Of PointF), ByVal cluster2 As List(Of PointF), ByVal cluster3 As List(Of PointF))
            Dim points As List(Of PointF) = New List(Of PointF)()
            For Each point As SeriesPoint In seriesPoints
                points.Add(New PointF(CSng(point.NumericalArgument), CSng(point.Values(0))))
            Next

            If points.Count < 100 Then Return
            Dim nextCenter1 As PointF = points(0)
            Dim nextCenter2 As PointF = points(50)
            Dim nextCenter3 As PointF = points(100)
            Dim center1 As PointF
            Dim center2 As PointF
            Dim center3 As PointF
            Do
                center1 = nextCenter1
                center2 = nextCenter2
                center3 = nextCenter3
                cluster1.Clear()
                cluster2.Clear()
                cluster3.Clear()
                For Each point As PointF In points
                    Dim x As Single = point.X
                    Dim y As Single = point.Y
                    Dim distance1 As Double = Math.Sqrt((center1.X - x) * (center1.X - x) + (center1.Y - y) * (center1.Y - y))
                    Dim distance2 As Double = Math.Sqrt((center2.X - x) * (center2.X - x) + (center2.Y - y) * (center2.Y - y))
                    Dim distance3 As Double = Math.Sqrt((center3.X - x) * (center3.X - x) + (center3.Y - y) * (center3.Y - y))
                    If distance1 <= distance2 AndAlso distance1 <= distance3 Then
                        cluster1.Add(point)
                    ElseIf distance2 <= distance1 AndAlso distance2 <= distance3 Then
                        cluster2.Add(point)
                    Else
                        cluster3.Add(point)
                    End If
                Next

                nextCenter1 = GetClusterCenter(cluster1)
                nextCenter2 = GetClusterCenter(cluster2)
                nextCenter3 = GetClusterCenter(cluster3)
            Loop While Not AreEqual(center1, nextCenter1) OrElse Not AreEqual(center2, nextCenter2) OrElse Not AreEqual(center3, nextCenter3)
        End Sub

        Public Function Sort(ByVal cluster As List(Of PointF)) As List(Of PointF)
            Dim sortedCluster As List(Of PointF) = New List(Of PointF)()
            If cluster.Count = 0 Then Return sortedCluster
            sortedCluster.Add(cluster(0))
            For i As Integer = 1 To cluster.Count - 1
                If sortedCluster(0).X >= cluster(i).X Then
                    sortedCluster.Insert(0, cluster(i))
                ElseIf sortedCluster(sortedCluster.Count - 1).X <= cluster(i).X Then
                    sortedCluster.Insert(sortedCluster.Count, cluster(i))
                Else
                    For j As Integer = 0 To sortedCluster.Count - 1 - 1
                        If sortedCluster(j).X <= cluster(i).X AndAlso sortedCluster(j + 1).X >= cluster(i).X Then
                            sortedCluster.Insert(j + 1, cluster(i))
                            Exit For
                        End If
                    Next
                End If
            Next

            Return sortedCluster
        End Function

        Public Function CreateClosedCircuit(ByVal sortedCluster As List(Of PointF)) As List(Of PointF)
            Dim contourPoints As List(Of PointF) = New List(Of PointF)()
            If sortedCluster.Count = 0 Then Return contourPoints
            contourPoints.Add(sortedCluster(0))
            CreateUpperArc(sortedCluster, contourPoints)
            CreateBottomArc(sortedCluster, contourPoints)
            Return contourPoints
        End Function
    End Module
End Namespace
