Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.XtraTreeMap.Demos

    Public Partial Class Colorizer
        Inherits TreeMapDemoModuleWithOptions

        Const GroupMember As String = "FieldOfActivity"

        Private ReadOnly colorizers As List(Of ITreeMapColorizer) = New List(Of ITreeMapColorizer)()

        Private ReadOnly Property DataAdapter As TreeMapFlatDataAdapter
            Get
                Return CType(treeMapControl1.DataAdapter, TreeMapFlatDataAdapter)
            End Get
        End Property

        Public Overrides ReadOnly Property ActiveDemoModule As Control
            Get
                Return treeMapControl1
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            DataAdapter.DataSource = CreateDataSet("USLargestCompanies2011.xml")
            InitializeColorizers()
        End Sub

        Private Sub InitializeColorizers()
            colorizers.Add(New TreeMapPaletteColorizer() With {.Palette = Palette.GreenYellowPalette, .ColorizeGroups = True})
            Dim rangeColorizer As TreeMapRangeColorizer = New TreeMapRangeColorizer() With {.Palette = Palette.CreatePalette(Color.FromArgb(&HD8, &H61, &H0D), Color.FromArgb(&HEF, &H80, &H2B), Color.FromArgb(&HFF, &H9C, &H11), Color.FromArgb(&HFF, &HBB, &H32), Color.FromArgb(&HFF, &HCD, &H7C))}
            rangeColorizer.RangeStops.AddRange(New Double() {0, 59, 95, 300, 1300, 2500})
            colorizers.Add(rangeColorizer)
            colorizers.Add(New TreeMapGradientColorizer() With {.StartColor = Color.FromArgb(&H33, &H33, &H33), .EndColor = Color.FromArgb(&HEE, &HEE, &HEE)})
            colorizers.Add(New TreeMapGroupGradientColorizer() With {.Palette = Palette.InAFogPalette})
            treeMapControl1.Colorizer = colorizers(0)
            UpdateLegendParams()
        End Sub

        Private Sub colorizerCBE_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            treeMapControl1.Colorizer = colorizers(colorizerCBE.SelectedIndex)
            UpdateLegendParams()
        End Sub

        Private Sub UpdateLegendParams()
            Dim legend As LegendBase = treeMapControl1.Legend
            If TypeOf treeMapControl1.Colorizer Is TreeMapRangeColorizer Then
                legend.VerticalAlignment = LegendVerticalAlignment.Top
                legend.HorizontalAlignment = LegendHorizontalAlignment.RightOutside
                legend.Direction = LegendDirection.TopToBottom
                legend.Title.Text = "Assets, $B"
            ElseIf TypeOf treeMapControl1.Colorizer Is TreeMapPaletteColorizerBase Then
                legend.VerticalAlignment = LegendVerticalAlignment.BottomOutside
                legend.HorizontalAlignment = LegendHorizontalAlignment.Center
                legend.Direction = LegendDirection.LeftToRight
                legend.HorizontalIndent = 30
                legend.Title.Text = "Field Of Activity, $B"
                CType(treeMapControl1.Colorizer, TreeMapPaletteColorizerBase).LegendItemPattern = "{L}: {V:#.#}"
            End If
        End Sub

        Private Sub enableGroupingCE_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If enableGroupingCE.Checked Then
                DataAdapter.GroupDataMembers.Add(GroupMember)
            Else
                DataAdapter.GroupDataMembers.Clear()
            End If

            CType(colorizers(0), TreeMapPaletteColorizer).ColorizeGroups = enableGroupingCE.Checked
        End Sub
    End Class
End Namespace
