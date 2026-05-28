Namespace DevExpress.XtraTreeMap.Demos

    Partial Class SunburstInteraction

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        '#region Component Designer generated code
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim sunburstFlatDataAdapter1 As DevExpress.XtraTreeMap.SunburstFlatDataAdapter = New DevExpress.XtraTreeMap.SunburstFlatDataAdapter()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim seriesKeyColorColorizer1 As DevExpress.XtraCharts.SeriesKeyColorColorizer = New DevExpress.XtraCharts.SeriesKeyColorColorizer()
            Dim stackedBarSeriesView1 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
            Me.sunburstControl1 = New DevExpress.XtraTreeMap.SunburstControl()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            CType((Me.sunburstControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stackedBarSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' sunburstControl1
            ' 
            Me.sunburstControl1.BorderOptions.Color = System.Drawing.Color.FromArgb((CInt(((CByte((157)))))), (CInt(((CByte((160)))))), (CInt(((CByte((170)))))))
            Me.sunburstControl1.CenterLabel.TextPattern = "DevAV" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Branches" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Sales"
            sunburstFlatDataAdapter1.GroupDataMembersSerializable = "Company;Category"
            sunburstFlatDataAdapter1.LabelDataMember = "Product"
            sunburstFlatDataAdapter1.ValueDataMember = "Income"
            Me.sunburstControl1.DataAdapter = sunburstFlatDataAdapter1
            Me.sunburstControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sunburstControl1.Location = New System.Drawing.Point(0, 0)
            Me.sunburstControl1.Name = "sunburstControl1"
            Me.sunburstControl1.Padding = New System.Windows.Forms.Padding(20)
            Me.sunburstControl1.SelectionMode = DevExpress.XtraTreeMap.ElementSelectionMode.Multiple
            Me.sunburstControl1.Size = New System.Drawing.Size(83, 500)
            Me.sunburstControl1.StartAngle = 45R
            Me.sunburstControl1.TabIndex = 0
            Me.sunburstControl1.ToolTipTextPattern = "{L}: ${V}M"
            AddHandler Me.sunburstControl1.SelectionChanged, New DevExpress.XtraTreeMap.SelectionChangedEventHandler(AddressOf Me.SunburstControl1_SelectionChanged)
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.AutoLayout = False
            Me.chartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram1.AxisX.MinorCount = 1
            xyDiagram1.AxisX.Tickmarks.MinorLength = 5
            xyDiagram1.AxisX.Tickmarks.Visible = False
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.GridLines.Visible = False
            xyDiagram1.AxisY.MinorCount = 3
            xyDiagram1.AxisY.Tickmarks.MinorVisible = False
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.DefaultPane.BackColor = System.Drawing.Color.Transparent
            xyDiagram1.DefaultPane.BorderVisible = False
            xyDiagram1.Rotated = True
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Right
            Me.chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
            Me.chartControl1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chartControl1.Legend.Name = "Default Legend"
            Me.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartControl1.Location = New System.Drawing.Point(83, 0)
            Me.chartControl1.Margin = New System.Windows.Forms.Padding(5)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.Padding.Bottom = 20
            Me.chartControl1.Padding.Left = 20
            Me.chartControl1.Padding.Right = 20
            Me.chartControl1.Padding.Top = 20
            Me.chartControl1.SeriesDataMember = "Company"
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chartControl1.SeriesTemplate.ArgumentDataMember = "Product"
            Me.chartControl1.SeriesTemplate.SeriesColorizer = seriesKeyColorColorizer1
            Me.chartControl1.SeriesTemplate.SeriesDataMember = "Company"
            Me.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Income"
            Me.chartControl1.SeriesTemplate.View = stackedBarSeriesView1
            Me.chartControl1.Size = New System.Drawing.Size(417, 500)
            Me.chartControl1.TabIndex = 11
            ' 
            ' SunburstInteraction
            ' 
            Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.Appearance.Options.UseFont = True
            Me.Controls.Add(Me.sunburstControl1)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "SunburstInteraction"
            AddHandler Me.Resize, New System.EventHandler(AddressOf Me.SunburstInteraction_Resize)
            CType((Me.sunburstControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stackedBarSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private sunburstControl1 As DevExpress.XtraTreeMap.SunburstControl

        Private chartControl1 As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace
