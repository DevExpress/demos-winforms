Namespace DevExpress.XtraCharts.Demos

    Partial Class DrillDownDemo

        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim toolTipRelativePosition1 As DevExpress.XtraCharts.ToolTipRelativePosition = New DevExpress.XtraCharts.ToolTipRelativePosition()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chart
            ' 
            Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.CrosshairOptions.HighlightPoints = False
            xyDiagram1.AxisX.GridLines.Visible = True
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.Label.TextPattern = "{V:0,.##}"
            xyDiagram1.AxisY.Title.Text = "Thousands of USD"
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[Default]
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.Rotated = True
            Me.chart.Diagram = xyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Name = "chart"
            Me.chart.SeriesDataMember = "Category"
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chart.SeriesTemplate.SeriesDataMember = "Category"
            Me.chart.Size = New System.Drawing.Size(784, 432)
            Me.chart.TabIndex = 0
            chartTitle1.Text = "DevAV Total Sales"
            chartTitle1.TitleID = 0
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            Me.chart.ToolTipController = Me.toolTipController1
            Me.chart.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.[True]
            toolTipRelativePosition1.OffsetY = -15
            Me.chart.ToolTipOptions.ToolTipPosition = toolTipRelativePosition1
            AddHandler Me.chart.DrillDownStateChanged, New DevExpress.XtraCharts.DrillDownStateChangedEventHandler(AddressOf Me.chart_DrillDownStateChanged)
            ' 
            ' toolTipController1
            ' 
            Me.toolTipController1.CloseOnClick = DevExpress.Utils.DefaultBoolean.[True]
            Me.toolTipController1.InitialDelay = 1
            Me.toolTipController1.Rounded = True
            Me.toolTipController1.ShowBeak = True
            Me.toolTipController1.ShowShadow = False
            Me.toolTipController1.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor
            Me.toolTipController1.ToolTipLocation = DevExpress.Utils.ToolTipLocation.LeftCenter
            ' 
            ' DrillDownDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.chart)
            Me.Name = "DrillDownDemo"
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private chart As DevExpress.XtraCharts.ChartControl

        Private toolTipController1 As DevExpress.Utils.ToolTipController
    End Class
End Namespace
