Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraPivotGrid.Demos.Helpers

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Public Partial Class OLAPKPI
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            ddlStatusGraphics.Properties.Items.Clear()
            ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.None)
            ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.ServerDefined)
            ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.Cylinder)
            ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.Faces)
            ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.Gauge)
            ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.RoadSigns)
            ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.Shapes)
            ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.Thermometer)
            ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.TrafficLights)
            ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.VarianceArrow)
            ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.ReversedCylinder)
            ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.ReversedGauge)
            ddlStatusGraphics.Properties.Items.Add(PivotKPIGraphic.ReversedThermometer)
            ddlStatusGraphics.SelectedIndex = 1
            ddlTrendGraphics.Properties.Items.Clear()
            ddlTrendGraphics.Properties.Items.Add(PivotKPIGraphic.None)
            ddlTrendGraphics.Properties.Items.Add(PivotKPIGraphic.ServerDefined)
            ddlTrendGraphics.Properties.Items.Add(PivotKPIGraphic.StandardArrow)
            ddlTrendGraphics.Properties.Items.Add(PivotKPIGraphic.StatusArrow)
            ddlTrendGraphics.Properties.Items.Add(PivotKPIGraphic.ReversedStatusArrow)
            ddlTrendGraphics.Properties.Items.Add(PivotKPIGraphic.Faces)
            ddlTrendGraphics.SelectedIndex = 1
            panelError.Visible = False
            Dim success As Boolean = OLAPConfigurator.ConnectToAdventureWorks(pivotGridControl, False)
            panelError.Visible = Not success
            layoutControlGroup2.Enabled = success
            separator1.Visible = Not success
        End Sub

        Private Function GetAdventureWorksFileName() As String
            Return "Data\AdventureWorks.cub"
        End Function

        Public Overrides ReadOnly Property ViewOptionsControl As PivotGridControl
            Get
                Return pivotGridControl
            End Get
        End Property

        Public Overrides ReadOnly Property ExportControl As PivotGridControl
            Get
                Return pivotGridControl
            End Get
        End Property

        '<ddlStatusGraphics>
        Private Sub cbStatusGraphic_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If panelError.Visible Then Return
            pivotGridControl.Fields("[Measures].[Internet Revenue Status]").KPIGraphic = CType(ddlStatusGraphics.SelectedItem, PivotKPIGraphic)
        End Sub

        '</ddlStatusGraphics>
        '<ddlTrendGraphics>
        Private Sub cbTrendGraphic_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If panelError.Visible Then Return
            pivotGridControl.Fields("[Measures].[Internet Revenue Trend]").KPIGraphic = CType(ddlTrendGraphics.SelectedItem, PivotKPIGraphic)
        End Sub
    '</ddlTrendGraphics>
    End Class
End Namespace
