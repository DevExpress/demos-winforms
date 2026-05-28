Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports DevExpress.Utils
Imports DevExpress.XtraCharts.Sankey
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraSankey.Demos

    Public Partial Class Colorizer
        Inherits SankeyDemoModuleWithOptions

        Private continentCountriesPairs As Dictionary(Of String, List(Of String))

        Private ReadOnly gradientColorizer As GradientColorizer = New GradientColorizer()

        Public Overrides ReadOnly Property SankeyDiagramControl As SankeyDiagramControl
            Get
                Return sankeyDiagramControl1
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            InitContinentCountriesPairs_ColorizerDemo()
            InitColorizerItems()
            InitNodeAlignmentItems()
            AddData()
        End Sub

        Private Sub InitColorizerItems()
            colorizerRadioGroup.Properties.Items.Add(New RadioGroupItem(New ContinentColorizer(continentCountriesPairs), "Continent Colorizer (Custom)"))
            colorizerRadioGroup.Properties.Items.Add(New RadioGroupItem(gradientColorizer, "Gradient Colorizer (Custom)"))
            colorizerRadioGroup.Properties.Items.Add(New RadioGroupItem(New SankeyPaletteColorizer(), "Palette Colorizer"))
            colorizerRadioGroup.Properties.Items.Add(New RadioGroupItem(New SankeyPaletteColorizer() With {.LinkColor = Color.Gray}, "Monochrome Link Colorizer"))
            colorizerRadioGroup.SelectedIndex = 0
        End Sub

        Private Sub InitNodeAlignmentItems()
            nodeAlignmentRadioGroup.Properties.Items.Add(New RadioGroupItem(SankeyNodeAlignment.Far, "Far"))
            nodeAlignmentRadioGroup.Properties.Items.Add(New RadioGroupItem(SankeyNodeAlignment.Center, "Center"))
            nodeAlignmentRadioGroup.Properties.Items.Add(New RadioGroupItem(SankeyNodeAlignment.Near, "Near"))
            nodeAlignmentRadioGroup.SelectedIndex = 0
        End Sub

        Private Sub InitContinentCountriesPairs_ColorizerDemo()
            continentCountriesPairs = New Dictionary(Of String, List(Of String))()
            continentCountriesPairs.Add("North America", New List(Of String)() From {"United States", "Canada", "Mexico"})
            continentCountriesPairs.Add("Asia", New List(Of String)() From {"Japan", "South Korea"})
            continentCountriesPairs.Add("South America", New List(Of String)() From {"Brazil", "Argentina"})
            continentCountriesPairs.Add("Australia", New List(Of String)() From {"Australia"})
            continentCountriesPairs.Add("Europe", New List(Of String)() From {"Netherlands", "Germany", "United Kingdom", "Italy", "France", "Spain", "United Kingdom"})
        End Sub

        Private Sub AddData()
            Dim dataSource As List(Of Export) = LargestExportPartners.GetData()
            Dim removeFunction As Func(Of Export, String, Boolean) = Function(ByVal e, ByVal country) continentCountriesPairs(country).Contains(e.Importer) OrElse continentCountriesPairs(country).Contains(e.Exporter)
            If Not NorthAmericaChE.Checked Then dataSource.RemoveAll(Function(x) removeFunction(x, "North America"))
            If Not SouthAmericaChE.Checked Then dataSource.RemoveAll(Function(x) removeFunction(x, "South America"))
            If Not AsiaChE.Checked Then dataSource.RemoveAll(Function(x) removeFunction(x, "Asia"))
            If Not AustraliaChE.Checked Then dataSource.RemoveAll(Function(x) removeFunction(x, "Australia"))
            If Not EuropeChE.Checked Then dataSource.RemoveAll(Function(x) removeFunction(x, "Europe"))
            UpdateMinMaxRangeColorizerValue(dataSource)
            sankeyDiagramControl1.DataSource = dataSource
        End Sub

        Private Sub UpdateMinMaxRangeColorizerValue(ByVal dataSource As List(Of Export))
            If dataSource.Count <> 0 Then
                Dim exportCountryValues As Dictionary(Of String, Double) = New Dictionary(Of String, Double)()
                Dim importCountryValues As Dictionary(Of String, Double) = New Dictionary(Of String, Double)()
                For Each export In dataSource
                    Dim exportValue As Double
                    If exportCountryValues.TryGetValue(export.Exporter, exportValue) Then
                        exportCountryValues(export.Exporter) = exportValue + export.Sum
                    Else
                        exportCountryValues.Add(export.Exporter, export.Sum)
                    End If

                    Dim importValue As Double
                    If importCountryValues.TryGetValue(export.Importer, importValue) Then
                        importCountryValues(export.Importer) += importValue + export.Sum
                    Else
                        importCountryValues.Add(export.Importer, export.Sum)
                    End If
                Next

                Dim values = exportCountryValues.Values.ToList()
                values.AddRange(importCountryValues.Values.ToList())
                gradientColorizer.MinValue = values.Min()
                gradientColorizer.MaxValue = values.Max()
            End If
        End Sub

        Private Sub ChE_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            AddData()
        End Sub

        Private Sub OnCustomizeNodeToolTip(ByVal sender As Object, ByVal e As CustomizeSankeyNodeToolTipEventArgs)
            Dim text = New StringBuilder()
            If Math.Round(e.Node.SourceWeight, 3) <> 0 Then text.Append(String.Format("Total import: ${0} billion", Math.Round(e.Node.SourceWeight * 1000, 2)))
            If Math.Round(e.Node.TargetWeight, 3) <> 0 Then
                If text.Length <> 0 Then text.AppendLine()
                text.Append(String.Format("Total export: ${0} billion", Math.Round(e.Node.TargetWeight * 1000, 2)))
            End If

            e.Content = text.ToString()
        End Sub

        Private Sub OnCustomizeLinkToolTip(ByVal sender As Object, ByVal e As CustomizeSankeyLinkToolTipEventArgs)
            e.Content = String.Format("${0} billion", Math.Round(e.Link.TotalWeight * 1000, 2))
        End Sub

        Private Sub colorizerRadioGroup_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            sankeyDiagramControl1.Colorizer = CType(colorizerRadioGroup.Properties.Items(colorizerRadioGroup.SelectedIndex).Value, ISankeyColorizer)
        End Sub

        Private Sub ResolveOverlappingChE_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            CType(SankeyDiagramControl.LayoutAlgorithm, SankeyLinearLayoutAlgorithm).ResolveOverlapping = If(resolveOverlappingChE.Checked, DefaultBoolean.True, DefaultBoolean.False)
        End Sub

        Private Sub nodeAlignmentRadioGroup_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            CType(SankeyDiagramControl.LayoutAlgorithm, SankeyLinearLayoutAlgorithm).NodeAlignment = CType(nodeAlignmentRadioGroup.Properties.Items(nodeAlignmentRadioGroup.SelectedIndex).Value, SankeyNodeAlignment)
        End Sub
    End Class

    Friend Class ContinentColorizer
        Implements ISankeyColorizer

        Private continentColorPairs As Dictionary(Of String, Color) = New Dictionary(Of String, Color)()

        Private continentCountriesPairs As Dictionary(Of String, List(Of String)) = New Dictionary(Of String, List(Of String))()

        Public Sub New(ByVal continentCountriesPairs As Dictionary(Of String, List(Of String)))
            continentColorPairs.Add("Asia", Color.FromArgb(245, 86, 74))
            continentColorPairs.Add("North America", Color.FromArgb(29, 178, 245))
            continentColorPairs.Add("South America", Color.FromArgb(151, 201, 92))
            continentColorPairs.Add("Australia", Color.FromArgb(198, 144, 83))
            continentColorPairs.Add("Europe", Color.FromArgb(255, 199, 32))
            Me.continentCountriesPairs = continentCountriesPairs
        End Sub

        Public Sub New(ByVal continentColorPairs As Dictionary(Of String, Color), ByVal continentCountriesPairs As Dictionary(Of String, List(Of String)))
            Me.continentColorPairs = continentColorPairs
            Me.continentCountriesPairs = continentCountriesPairs
        End Sub

        Private Function GetContinentByCountry(ByVal country As String) As String
            If continentColorPairs.ContainsKey(country) Then Return country
            For Each continentCountryPairs In continentCountriesPairs
                If continentCountryPairs.Value.Contains(country) Then Return continentCountryPairs.Key
            Next

            Return String.Empty
        End Function

        Private Function GetLinkSourceColor(ByVal link As SankeyLink) As Color Implements ISankeyColorizer.GetLinkSourceColor
            Dim country As String = link.SourceNode.Tag.ToString()
            Return GetContinentColor(GetContinentByCountry(country))
        End Function

        Private Function GetLinkTargetColor(ByVal link As SankeyLink) As Color Implements ISankeyColorizer.GetLinkTargetColor
            Dim country As String = link.TargetNode.Tag.ToString()
            Return GetContinentColor(GetContinentByCountry(country))
        End Function

        Private Function GetNodeColor(ByVal info As SankeyNode) As Color Implements ISankeyColorizer.GetNodeColor
            Dim country As String = info.Tag.ToString()
            Return GetContinentColor(GetContinentByCountry(country))
        End Function

        Private Function GetContinentColor(ByVal continent As String) As Color
            Dim color As Color
            If Not String.IsNullOrEmpty(continent) AndAlso continentColorPairs.TryGetValue(continent, color) Then Return color
            Return Color.Empty
        End Function
    End Class

    Friend Class GradientColorizer
        Implements ISankeyColorizer

        Public Property MinValue As Double

        Public Property MaxValue As Double

        Private Function GetGradientColor(ByVal percent As Double) As Color
            Dim color1 As Color = Color.FromArgb(255, 96, 181, 204)
            Dim color2 As Color = Color.FromArgb(255, 230, 108, 125)
            percent = If(Double.IsNaN(percent), 1, percent)
            Dim resultRed As Double = color1.R * (1.0 - percent) + color2.R * percent
            Dim resultGreen As Double = color1.G * (1.0 - percent) + color2.G * percent
            Dim resultBlue As Double = color1.B * (1.0 - percent) + color2.B * percent
            Return Color.FromArgb(CByte(resultRed), CByte(resultGreen), CByte(resultBlue))
        End Function

        Private Function GetLinkSourceColor(ByVal link As SankeyLink) As Color Implements ISankeyColorizer.GetLinkSourceColor
            Return GetGradientColor((link.SourceNode.TotalWeight - MinValue) / (MaxValue - MinValue))
        End Function

        Private Function GetLinkTargetColor(ByVal link As SankeyLink) As Color Implements ISankeyColorizer.GetLinkTargetColor
            Return GetGradientColor((link.TargetNode.TotalWeight - MinValue) / (MaxValue - MinValue))
        End Function

        Private Function GetNodeColor(ByVal node As SankeyNode) As Color Implements ISankeyColorizer.GetNodeColor
            Return GetGradientColor((node.TotalWeight - MinValue) / (MaxValue - MinValue))
        End Function
    End Class
End Namespace
