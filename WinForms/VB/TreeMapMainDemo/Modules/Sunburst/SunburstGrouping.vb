Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Globalization
Imports System.Windows.Forms
Imports DevExpress.TreeMap
Imports DevExpress.Utils

Namespace DevExpress.XtraTreeMap.Demos

    Public Partial Class SunburstGrouping
        Inherits TreeMapDemoModuleWithOptions

        Private ReadOnly Property DataAdapter As SunburstFlatDataAdapter
            Get
                Return CType(sunburstControl1.DataAdapter, SunburstFlatDataAdapter)
            End Get
        End Property

        Public Overrides ReadOnly Property ActiveDemoModule As Control
            Get
                Return sunburstControl1
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            DataAdapter.DataSource = CreateDataSet("ChemicalElements.xml")
            sunburstControl1.Colorizer = New ChemicalElementColorizer() With {.LegendItemPattern = "{L} : {V}"}
            displayModeCBE.Properties.Items.AddRange([Enum].GetValues(GetType(SunburstLabelDisplayMode)))
            displayModeCBE.SelectedIndex = 1
            InitializeControls(sunburstControl1)
        End Sub

        Private Sub toolTipController1_BeforeShow(ByVal sender As Object, ByVal e As ToolTipControllerShowEventArgs)
            Dim stp As SuperToolTip = New SuperToolTip()
            Dim item As SunburstItem = CType(e.SelectedObject, SunburstItem)
            If item.Children.Count = 0 Then
                Dim element As DataRowView = CType(item.Tag, DataRowView)
                stp.Items.Add(New ToolTipTitleItem() With {.Text = String.Format("{0}", element("Name"))})
                stp.Items.Add(New ToolTipSeparatorItem())
                stp.Items.Add(CreateToolTipItem(element, "AtomicNumber", "Atomic Number", ""))
                stp.Items.Add(CreateToolTipItem(element, "AtomicMass", "Atomic Mass", "u (±)"))
                stp.Items.Add(CreateToolTipItem(element, "Density", "Density", "g/cm³"))
                stp.Items.Add(CreateToolTipItem(element, "MeltingPoint", "Melting Point", "K"))
                stp.Items.Add(CreateToolTipItem(element, "BoilingPoint", "Boiling Point", "K"))
            Else
                stp.Items.Add(New ToolTipTitleItem() With {.Text = item.Label})
                stp.Items.Add(New ToolTipSeparatorItem())
                stp.Items.Add(New ToolTipTitleItem() With {.Text = String.Format(CultureInfo.InvariantCulture, "{0} elements", CType(item.Tag, IList).Count)})
            End If

            e.SuperTip = stp
        End Sub

        Private Function CreateToolTipItem(ByVal element As DataRowView, ByVal fieldName As String, ByVal caption As String, ByVal unit As String) As ToolTipTitleItem
            Dim fieldValue As String = element(fieldName).ToString()
            Dim itemText As String = If(Equals(fieldValue, "–"), String.Format(CultureInfo.InvariantCulture, "{0} = {1}", caption, fieldValue), String.Format(CultureInfo.InvariantCulture, "{0} = {1} {2}", caption, fieldValue, unit))
            Return New ToolTipTitleItem() With {.Text = itemText}
        End Function

        Private Sub displayModeCBE_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            sunburstControl1.Label.DisplayMode = CType(displayModeCBE.SelectedItem, SunburstLabelDisplayMode)
            autoLayoutCE.Enabled = sunburstControl1.Label.DisplayMode <> SunburstLabelDisplayMode.Radial
            sunburstControl1.Label.AutoLayout = autoLayoutCE.Checked
        End Sub

        Private Sub autoLayoutCE_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            sunburstControl1.Label.AutoLayout = autoLayoutCE.Checked
        End Sub
    End Class

    Public Class ChemicalElementColorizer
        Inherits SunburstPaletteColorizer

        Const FBlock As String = "F-block", BlockColumn As String = "Block", FamilyColumn As String = "Family"

        Private _colors As Dictionary(Of String, Color)

        Private ReadOnly Property Colors As Dictionary(Of String, Color)
            Get
                If _colors Is Nothing Then
                    _colors = New Dictionary(Of String, Color)()
                    _colors("S-block") = Color.FromArgb(216, 103, 159)
                    _colors("P-block") = Color.FromArgb(234, 202, 39)
                    _colors("D-block") = Color.FromArgb(102, 156, 220)
                    _colors("F-block") = Color.FromArgb(126, 171, 54)
                    _colors("Lanthanide") = Color.FromArgb(145, 183, 46)
                    _colors("Actinide") = Color.FromArgb(107, 160, 52)
                End If

                Return _colors
            End Get
        End Property

        Protected Overrides Function GetItemColor(ByVal item As ISunburstItem, ByVal group As SunburstItemGroupInfo) As Color
            Dim row As DataRowView = CType(GetItemObject(item), DataRowView)
            Dim block As String = row(BlockColumn).ToString()
            Dim colorKey As String = If(Equals(block, FBlock) AndAlso group.GroupLevel > 0, row(FamilyColumn).ToString(), block)
            Return Colors(colorKey)
        End Function

        Private Function GetItemObject(ByVal item As ISunburstItem) As Object
            Dim objects As IList = TryCast(item.Tag, IList)
            Return If(objects IsNot Nothing, objects(0), item.Tag)
        End Function
    End Class
End Namespace
