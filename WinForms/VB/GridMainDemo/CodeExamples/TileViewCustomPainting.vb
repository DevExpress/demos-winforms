Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports System.Drawing
Imports DevExpress.XtraGrid.Views.Tile
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS
Imports System.Drawing.Drawing2D
Imports DevExpress.XtraEditors.TableLayout

Namespace DevExpress.XtraGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("TileView Custom painting", "TileViewCustomPainting.cs")>
    Public Module TileViewCustomPainting

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim gridControl As DevExpress.XtraGrid.GridControl = New DevExpress.XtraGrid.GridControl()
            Dim tileView = New DevExpress.XtraGrid.Views.Tile.TileView()
            tileView.OptionsTiles.ItemSize = New System.Drawing.Size(144, 144)
            tileView.OptionsTiles.RowCount = 2
            tileView.OptionsTiles.ItemPadding = New System.Windows.Forms.Padding(16)
            tileView.OptionsTiles.AllowItemHover = True
            gridControl.MainView = tileView
            gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            gridControl.Parent = sampleHost
            gridControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.GetData(6)
            tileView.TileRows.Add(New DevExpress.XtraEditors.TableLayout.TableRowDefinition())
            tileView.TileRows.Add(New DevExpress.XtraEditors.TableLayout.TableRowDefinition())
            tileView.TileRows(CInt((0))).AutoHeight = True
            tileView.TileRows(CInt((0))).PaddingBottom = 8
            Dim tileElementName = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileElementDesc = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            tileView.TileTemplate.Add(tileElementName)
            tileView.TileTemplate.Add(tileElementDesc)
            tileElementName.Column = tileView.Columns("Name")
            tileElementName.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileElementName.Appearance.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold
            tileElementDesc.Column = tileView.Columns("Notes")
            tileElementDesc.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
            tileElementDesc.RowIndex = 1
            Return New Object() {gridControl, tileView}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraGrid.GridControl).Dispose()
        End Sub

#Region "CustomPainting"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("CustomDrawTile"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomDrawTile")>
        Public Sub CustomDrawTile(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal tileView As DevExpress.XtraGrid.Views.Tile.TileView)
            Dim RoundedRect As System.Func(Of System.Drawing.Rectangle, Integer, System.Drawing.Drawing2D.GraphicsPath) = Function(bounds, radius)
                Dim diameter As Integer = radius * 2
                Dim size As System.Drawing.Size = New System.Drawing.Size(diameter, diameter)
                Dim arc As System.Drawing.Rectangle = New System.Drawing.Rectangle(bounds.Location, size)
                Dim path As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath()
                path.AddArc(arc, 180, 90)
                arc.X = bounds.Right - diameter
                path.AddArc(arc, 270, 90)
                arc.Y = bounds.Bottom - diameter
                path.AddArc(arc, 0, 90)
                arc.X = bounds.Left
                path.AddArc(arc, 90, 90)
                path.CloseFigure()
                Return path
            End Function
            ' Handle the CustomDrawTile event to paint tiles manually. The following code draws tiles with rounded corners:
            Const tileCornerRadius As Integer = 16
            Const selectionCornerRadius As Integer = 18
            AddHandler tileView.CustomDrawTile, Sub(s, e)
                If e.DrawingProcess = DevExpress.XtraGrid.Views.Tile.TileViewItemCustomDrawProcess.DrawTile Then
                    If e.ShouldDrawBackground Then
                        e.Cache.FillRectangle(e.TileViewEmptySpaceBackColor, e.Bounds)
                        Dim r = e.Bounds
                        r.Inflate(-2, -2)
                        e.Cache.FillPath(e.Appearance.GetBackBrush(e.Cache), RoundedRect(r, tileCornerRadius))
                    End If

                    If e.ShouldDrawContent Then
                        e.DrawContent()
                    End If

                    If e.ShouldDrawHoveredOverlay Then
                        e.DrawHoveredOverlay()
                    End If

                    If e.ShouldDrawDisabledOverlay Then
                        e.DrawDisabledOverlay()
                    End If

                    If e.ShouldDrawBorder Then
                        e.Cache.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
                        Dim r = New System.Drawing.Rectangle(e.Bounds.X + 2, e.Bounds.Y + 2, e.Bounds.Width - 3, e.Bounds.Height - 3)
                        e.Cache.DrawPath(e.Appearance.GetBorderPen(e.Cache), RoundedRect(r, tileCornerRadius))
                        e.Cache.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
                    End If

                    If e.ShouldDrawCheckMark Then
                        e.DrawCheckMark()
                    End If

                    e.Cache.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
                ElseIf e.DrawingProcess = DevExpress.XtraGrid.Views.Tile.TileViewItemCustomDrawProcess.DrawSelection Then
                    e.Cache.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
                    Dim r = e.DefaultSelectionBounds
                    r.Inflate(-1, -1)
                    e.Cache.DrawPath(New System.Drawing.Pen(e.DefaultSelectionColor, e.DefaultSelectionWidth), RoundedRect(r, selectionCornerRadius))
                    e.Cache.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
                Else
                    e.DefaultDraw()
                End If

                e.Handled = True
            End Sub
        End Sub
#End Region
    End Module
End Namespace
