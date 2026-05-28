Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraCharts.Heatmap
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraTreeMap.Demos

    Public Partial Class HeatmapEmptyCells
        Inherits TreeMapDemoModuleWithOptions

        Public Overrides ReadOnly Property ActiveDemoModule As Control
            Get
                Return heatmapControl1
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            CType(heatmapControl1.DataAdapter, HeatmapDataSourceAdapter).DataSource = CreateDataSet("SalesPersons.xml")
            InitializeHighlightMode()
        End Sub

        Private Sub InitializeHighlightMode()
            highlightModeComboBoxEdit.Properties.Items.AddRange(New RadioGroupItem() {New RadioGroupItem(HeatmapHighlightMode.Row, "Row"), New RadioGroupItem(HeatmapHighlightMode.Column, "Column"), New RadioGroupItem(HeatmapHighlightMode.RowAndColumn, "RowAndColumn"), New RadioGroupItem(HeatmapHighlightMode.Cell, "Cell"), New RadioGroupItem(HeatmapHighlightMode.None, "None")})
            highlightModeComboBoxEdit.SelectedIndex = 2
        End Sub

        Private Sub HighlightModeChanged(ByVal sender As Object, ByVal e As EventArgs)
            heatmapControl1.HighlightMode = CType(highlightModeComboBoxEdit.EditValue, HeatmapHighlightMode)
        End Sub

        Private Sub DiagramColorChanged(ByVal sender As Object, ByVal e As EventArgs)
            heatmapControl1.Diagram.BackColor = CType(colorPickEdit1.EditValue, Color)
        End Sub
    End Class
End Namespace
