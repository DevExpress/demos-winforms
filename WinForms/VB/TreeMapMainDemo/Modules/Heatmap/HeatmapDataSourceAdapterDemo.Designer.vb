Namespace DevExpress.XtraTreeMap.Demos

    Partial Class HeatmapDataSourceAdapterDemo

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
            Dim heatmapRangeColorProvider1 As DevExpress.XtraCharts.Heatmap.HeatmapRangeColorProvider = New DevExpress.XtraCharts.Heatmap.HeatmapRangeColorProvider()
            Dim heatmapRangeStop1 As DevExpress.XtraCharts.Heatmap.HeatmapRangeStop = New DevExpress.XtraCharts.Heatmap.HeatmapRangeStop()
            Dim heatmapRangeStop2 As DevExpress.XtraCharts.Heatmap.HeatmapRangeStop = New DevExpress.XtraCharts.Heatmap.HeatmapRangeStop()
            Dim heatmapRangeStop3 As DevExpress.XtraCharts.Heatmap.HeatmapRangeStop = New DevExpress.XtraCharts.Heatmap.HeatmapRangeStop()
            Dim heatmapRangeStop4 As DevExpress.XtraCharts.Heatmap.HeatmapRangeStop = New DevExpress.XtraCharts.Heatmap.HeatmapRangeStop()
            Dim heatmapRangeStop5 As DevExpress.XtraCharts.Heatmap.HeatmapRangeStop = New DevExpress.XtraCharts.Heatmap.HeatmapRangeStop()
            Dim heatmapRangeStop6 As DevExpress.XtraCharts.Heatmap.HeatmapRangeStop = New DevExpress.XtraCharts.Heatmap.HeatmapRangeStop()
            Dim heatmapRangeStop7 As DevExpress.XtraCharts.Heatmap.HeatmapRangeStop = New DevExpress.XtraCharts.Heatmap.HeatmapRangeStop()
            Dim heatmapDataSourceAdapter1 As DevExpress.XtraCharts.Heatmap.HeatmapDataSourceAdapter = New DevExpress.XtraCharts.Heatmap.HeatmapDataSourceAdapter()
            Dim heatmapTitle1 As DevExpress.XtraCharts.Heatmap.HeatmapTitle = New DevExpress.XtraCharts.Heatmap.HeatmapTitle()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.heatmapControl1 = New DevExpress.XtraCharts.Heatmap.HeatmapControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.heatmapControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(547, 235, 650, 400)
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(500, 500)
            Me.layoutControl1.TabIndex = 1
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' heatmapControl1
            ' 
            heatmapRangeColorProvider1.ApproximateColors = True
            heatmapRangeColorProvider1.LegendItemPattern = "{V1} - {V2}"
            heatmapRangeColorProvider1.PaletteName = "Balance of Trade"
            heatmapRangeStop1.Type = DevExpress.XtraCharts.Heatmap.HeatmapRangeStopType.Percentage
            heatmapRangeStop1.Value = 0R
            heatmapRangeStop2.Value = -10R
            heatmapRangeStop3.Value = -2.5R
            heatmapRangeStop4.Value = 0R
            heatmapRangeStop5.Value = 2.5R
            heatmapRangeStop6.Value = 10R
            heatmapRangeStop7.Type = DevExpress.XtraCharts.Heatmap.HeatmapRangeStopType.Percentage
            heatmapRangeStop7.Value = 1R
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop1)
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop2)
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop3)
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop4)
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop5)
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop6)
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop7)
            Me.heatmapControl1.ColorProvider = heatmapRangeColorProvider1
            heatmapDataSourceAdapter1.ColorDataMember = "Value"
            heatmapDataSourceAdapter1.XArgumentDataMember = "Country"
            heatmapDataSourceAdapter1.YArgumentDataMember = "Product"
            Me.heatmapControl1.DataAdapter = heatmapDataSourceAdapter1
            Me.heatmapControl1.HighlightMode = DevExpress.XtraCharts.Heatmap.HeatmapHighlightMode.RowAndColumn
            Me.heatmapControl1.Label.Visible = True
            Me.heatmapControl1.Location = New System.Drawing.Point(0, 0)
            Me.heatmapControl1.Margin = New System.Windows.Forms.Padding(0)
            Me.heatmapControl1.Name = "heatmapControl1"
            Me.heatmapControl1.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.heatmapControl1.PaletteRepository.Add("Balance of Trade", New DevExpress.XtraCharts.Palette("Balance of Trade", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((218)))))), (CInt(((CByte((47)))))), (CInt(((CByte((66))))))), System.Drawing.Color.FromArgb((CInt(((CByte((218)))))), (CInt(((CByte((47)))))), (CInt(((CByte((66)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.White, System.Drawing.Color.White), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((50)))))), (CInt(((CByte((139)))))), (CInt(((CByte((125))))))), System.Drawing.Color.FromArgb((CInt(((CByte((50)))))), (CInt(((CByte((139)))))), (CInt(((CByte((125))))))))}))
            Me.heatmapControl1.Size = New System.Drawing.Size(500, 500)
            Me.heatmapControl1.TabIndex = 0
            Me.heatmapControl1.Text = "heatmapControl1"
            heatmapTitle1.Text = "Balance of Trade"
            Me.heatmapControl1.Titles.Add(heatmapTitle1)
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.GroupStyle = DevExpress.Utils.GroupStyle.Light
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2})
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.Root.Size = New System.Drawing.Size(500, 500)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.heatmapControl1
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem2.Size = New System.Drawing.Size(500, 500)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' HeatmapDataSourceAdapterDemo
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "HeatmapDataSourceAdapterDemo"
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private heatmapControl1 As DevExpress.XtraCharts.Heatmap.HeatmapControl

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
