Namespace DevExpress.XtraTreeMap.Demos

    Partial Class HeatmapKeyColorProvider

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

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim heatmapKeyColorProvider1 As DevExpress.XtraCharts.Heatmap.HeatmapKeyColorProvider = New DevExpress.XtraCharts.Heatmap.HeatmapKeyColorProvider()
            Dim heatmapDataSourceAdapter1 As DevExpress.XtraCharts.Heatmap.HeatmapDataSourceAdapter = New DevExpress.XtraCharts.Heatmap.HeatmapDataSourceAdapter()
            Dim heatmapTitle1 As DevExpress.XtraCharts.Heatmap.HeatmapTitle = New DevExpress.XtraCharts.Heatmap.HeatmapTitle()
            Me.heatmapControl1 = New DevExpress.XtraCharts.Heatmap.HeatmapControl()
            Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            Me.SuspendLayout()
            ' 
            ' heatmapControl1
            ' 
            heatmapKeyColorProvider1.Keys.Add("Fast")
            heatmapKeyColorProvider1.Keys.Add("Average")
            heatmapKeyColorProvider1.Keys.Add("Slow")
            heatmapKeyColorProvider1.PaletteName = "Performance Monitoring"
            Me.heatmapControl1.ColorProvider = heatmapKeyColorProvider1
            heatmapDataSourceAdapter1.ColorDataMember = "Value"
            heatmapDataSourceAdapter1.XArgumentDataMember = "Date"
            heatmapDataSourceAdapter1.YArgumentDataMember = "Application"
            Me.heatmapControl1.DataAdapter = heatmapDataSourceAdapter1
            Me.heatmapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.heatmapControl1.HighlightMode = DevExpress.XtraCharts.Heatmap.HeatmapHighlightMode.RowAndColumn
            Me.heatmapControl1.Location = New System.Drawing.Point(0, 0)
            Me.heatmapControl1.Margin = New System.Windows.Forms.Padding(0)
            Me.heatmapControl1.Name = "heatmapControl1"
            Me.heatmapControl1.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
            Me.heatmapControl1.PaletteRepository.Add("Performance Monitoring", New DevExpress.XtraCharts.Palette("Performance Monitoring", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.LightGreen, System.Drawing.Color.LightGreen), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Yellow, System.Drawing.Color.Yellow), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.IndianRed, System.Drawing.Color.IndianRed)}))
            Me.heatmapControl1.Size = New System.Drawing.Size(750, 808)
            Me.heatmapControl1.TabIndex = 0
            Me.heatmapControl1.Text = "heatmapControl1"
            heatmapTitle1.Text = "Website Performance Monitor"
            Me.heatmapControl1.Titles.Add(heatmapTitle1)
            Me.heatmapControl1.ToolTipController = Me.toolTipController1
            Me.heatmapControl1.ToolTipEnabled = True
            ' 
            ' toolTipController1
            ' 
            AddHandler Me.toolTipController1.BeforeShow, New DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(AddressOf Me.toolTipController1_BeforeShow)
            ' 
            ' HeatmapKeyColorProvider
            ' 
            Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9F, 21F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.heatmapControl1)
            Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Name = "HeatmapKeyColorProvider"
            Me.Size = New System.Drawing.Size(750, 808)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private heatmapControl1 As DevExpress.XtraCharts.Heatmap.HeatmapControl

        Private toolTipController1 As DevExpress.Utils.ToolTipController
    End Class
End Namespace
