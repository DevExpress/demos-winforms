Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.ModulesStatistics
	Partial Public Class MediaPerformanceStatistics
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram
            Dim PointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel
            Dim LineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView
            Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle
            Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series
            Dim PieSeriesLabel1 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel
            Dim PieSeriesView1 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView
            Dim SeriesTitle1 As DevExpress.XtraCharts.SeriesTitle = New DevExpress.XtraCharts.SeriesTitle
            Dim PieSeriesLabel2 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel
            Dim PieSeriesView2 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView
            Dim ChartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl
            Me.cardView1 = New DevExpress.XtraGrid.Views.Card.CardView
            Me.colPhoto = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
            Me.colTitle = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
            Me.chartRevenues = New DevExpress.XtraCharts.ChartControl
            Me.chart = New DevExpress.XtraCharts.ChartControl
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.lciMediaChart = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciItemChart = New DevExpress.XtraLayout.LayoutControlItem
            Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem
            Me.lciMostRentedMovies = New DevExpress.XtraLayout.LayoutControlItem
            Me.splitterItem2 = New DevExpress.XtraLayout.SplitterItem
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cardView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chartRevenues, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(PieSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(PieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(PieSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(PieSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciMediaChart, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciItemChart, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciMostRentedMovies, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitterItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'layoutControl1
            '
            Me.layoutControl1.Controls.Add(Me.gridControl1)
            Me.layoutControl1.Controls.Add(Me.chartRevenues)
            Me.layoutControl1.Controls.Add(Me.chart)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(1016, 537)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            '
            'gridControl1
            '
            Me.gridControl1.Location = New System.Drawing.Point(372, 246)
            Me.gridControl1.MainView = Me.cardView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemPictureEdit1, Me.repositoryItemTextEdit1})
            Me.gridControl1.Size = New System.Drawing.Size(636, 283)
            Me.gridControl1.TabIndex = 6
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.cardView1})
            '
            'cardView1
            '
            Me.cardView1.Appearance.ViewCaption.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.cardView1.Appearance.ViewCaption.Options.UseFont = True
            Me.cardView1.CardCaptionFormat = "{2}"
            Me.cardView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPhoto, Me.colTitle})
            Me.cardView1.FocusedCardTopFieldIndex = 0
            Me.cardView1.GridControl = Me.gridControl1
            Me.cardView1.Name = "cardView1"
            Me.cardView1.OptionsBehavior.Editable = False
            Me.cardView1.OptionsView.ShowCardExpandButton = False
            Me.cardView1.OptionsView.ShowFieldCaptions = False
            Me.cardView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            Me.cardView1.OptionsView.ShowLines = False
            Me.cardView1.OptionsView.ShowQuickCustomizeButton = False
            Me.cardView1.OptionsView.ShowViewCaption = True
            '
            'colPhoto
            '
            Me.colPhoto.Caption = "Photo"
            Me.colPhoto.ColumnEdit = Me.repositoryItemPictureEdit1
            Me.colPhoto.CustomizationCaption = "Photo"
            Me.colPhoto.FieldName = "Movie.PhotoExist"
            Me.colPhoto.Name = "colPhoto"
            Me.colPhoto.Visible = True
            Me.colPhoto.VisibleIndex = 0
            '
            'repositoryItemPictureEdit1
            '
            Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
            Me.repositoryItemPictureEdit1.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
            Me.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            '
            'colTitle
            '
            Me.colTitle.Caption = "Title"
            Me.colTitle.ColumnEdit = Me.repositoryItemTextEdit1
            Me.colTitle.CustomizationCaption = "Title"
            Me.colTitle.FieldName = "Movie.Title"
            Me.colTitle.Name = "colTitle"
            '
            'repositoryItemTextEdit1
            '
            Me.repositoryItemTextEdit1.AutoHeight = False
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            '
            'chartRevenues
            '
            XyDiagram1.AxisX.Label.Angle = 30
            XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            XyDiagram1.AxisY.Label.TextPattern = "{V:C0}"
            XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            XyDiagram1.LabelsResolveOverlappingMinIndent = 6
            Me.chartRevenues.Diagram = XyDiagram1
            Me.chartRevenues.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            Me.chartRevenues.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
            Me.chartRevenues.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chartRevenues.Location = New System.Drawing.Point(372, 8)
            Me.chartRevenues.Name = "chartRevenues"
            Me.chartRevenues.SeriesDataMember = "Series"
            Me.chartRevenues.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chartRevenues.SeriesTemplate.ArgumentDataMember = "Arguments"
            PointSeriesLabel1.LineVisibility = Utils.DefaultBoolean.True
            PointSeriesLabel1.TextPattern = "{V:C2}"
            PointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.[Default]
            Me.chartRevenues.SeriesTemplate.Label = PointSeriesLabel1
            Me.chartRevenues.SeriesTemplate.LabelsVisibility = Utils.DefaultBoolean.True
            Me.chartRevenues.SeriesTemplate.ValueDataMembersSerializable = "Values"
            Me.chartRevenues.SeriesTemplate.View = LineSeriesView1
            Me.chartRevenues.Size = New System.Drawing.Size(636, 229)
            Me.chartRevenues.TabIndex = 5
            ChartTitle1.Text = "DVD Movie Revenues"
            Me.chartRevenues.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
            '
            'chart
            '
            Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            Me.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
            Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chart.Location = New System.Drawing.Point(8, 8)
            Me.chart.Name = "chart"
            Me.chart.PaletteName = "Concourse"
            Me.chart.SelectionMode = XtraCharts.ElementSelectionMode.Single
            Me.chart.SeriesSelectionMode = DevExpress.XtraCharts.SeriesSelectionMode.Point
            Series1.ArgumentDataMember = "Format"
            PieSeriesLabel1.LineVisibility = Utils.DefaultBoolean.True
            PieSeriesLabel1.TextPattern = "{A}"
            Series1.Label = PieSeriesLabel1
            Series1.LabelsVisibility = Utils.DefaultBoolean.True
            Series1.Name = "Movie Media"
            Series1.QualitativeSummaryOptions.SummaryFunction = "COUNT()"
            PieSeriesView1.RuntimeExploding = False
            SeriesTitle1.Text = "Press a pie section to view detailed information"
            SeriesTitle1.WordWrap = True
            PieSeriesView1.Titles.AddRange(New DevExpress.XtraCharts.SeriesTitle() {SeriesTitle1})
            Series1.View = PieSeriesView1
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
            PieSeriesLabel2.LineVisibility = Utils.DefaultBoolean.True
            PieSeriesLabel2.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.[Default]
            Me.chart.SeriesTemplate.Label = PieSeriesLabel2
            PieSeriesView2.RuntimeExploding = False
            Me.chart.SeriesTemplate.View = PieSeriesView2
            Me.chart.Size = New System.Drawing.Size(355, 521)
            Me.chart.TabIndex = 4
            ChartTitle2.Text = "Movie Media In Database"
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle2})
            '
            'layoutControlGroup1
            '
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciMediaChart, Me.lciItemChart, Me.splitterItem1, Me.lciMostRentedMovies, Me.splitterItem2})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(1016, 537)
            Me.layoutControlGroup1.Text = "Root"
            Me.layoutControlGroup1.TextVisible = False
            '
            'lciMediaChart
            '
            Me.lciMediaChart.Control = Me.chart
            Me.lciMediaChart.CustomizationFormText = "layoutControlItem1"
            Me.lciMediaChart.Location = New System.Drawing.Point(0, 0)
            Me.lciMediaChart.Name = "lciMediaChart"
            Me.lciMediaChart.Size = New System.Drawing.Size(359, 525)
            Me.lciMediaChart.Text = "lciMediaChart"
            Me.lciMediaChart.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciMediaChart.TextSize = New System.Drawing.Size(0, 0)
            Me.lciMediaChart.TextToControlDistance = 0
            Me.lciMediaChart.TextVisible = False
            '
            'lciItemChart
            '
            Me.lciItemChart.Control = Me.chartRevenues
            Me.lciItemChart.CustomizationFormText = "layoutControlItem2"
            Me.lciItemChart.Location = New System.Drawing.Point(364, 0)
            Me.lciItemChart.Name = "lciItemChart"
            Me.lciItemChart.Size = New System.Drawing.Size(640, 233)
            Me.lciItemChart.Text = "lciItemChart"
            Me.lciItemChart.TextSize = New System.Drawing.Size(0, 0)
            Me.lciItemChart.TextToControlDistance = 0
            Me.lciItemChart.TextVisible = False
            '
            'splitterItem1
            '
            Me.splitterItem1.AllowHotTrack = True
            Me.splitterItem1.CustomizationFormText = "splitterItem1"
            Me.splitterItem1.Location = New System.Drawing.Point(359, 0)
            Me.splitterItem1.Name = "splitterItem1"
            Me.splitterItem1.Size = New System.Drawing.Size(5, 525)
            '
            'lciMostRentedMovies
            '
            Me.lciMostRentedMovies.AllowHtmlStringInCaption = True
            Me.lciMostRentedMovies.Control = Me.gridControl1
            Me.lciMostRentedMovies.CustomizationFormText = "Most Rented Movies"
            Me.lciMostRentedMovies.Location = New System.Drawing.Point(364, 238)
            Me.lciMostRentedMovies.Name = "lciMostRentedMovies"
            Me.lciMostRentedMovies.Size = New System.Drawing.Size(640, 287)
            Me.lciMostRentedMovies.Text = "Most Rented Movies"
            Me.lciMostRentedMovies.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciMostRentedMovies.TextSize = New System.Drawing.Size(0, 0)
            Me.lciMostRentedMovies.TextToControlDistance = 0
            Me.lciMostRentedMovies.TextVisible = False
            '
            'splitterItem2
            '
            Me.splitterItem2.AllowHotTrack = True
            Me.splitterItem2.CustomizationFormText = "splitterItem2"
            Me.splitterItem2.Location = New System.Drawing.Point(364, 233)
            Me.splitterItem2.Name = "splitterItem2"
            Me.splitterItem2.Size = New System.Drawing.Size(640, 5)
            '
            'MediaPerformanceStatistics
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "MediaPerformanceStatistics"
            Me.Size = New System.Drawing.Size(1016, 537)
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cardView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartRevenues, System.ComponentModel.ISupportInitialize).EndInit()
            CType(PieSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(PieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(PieSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(PieSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciMediaChart, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciItemChart, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciMostRentedMovies, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitterItem2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private lciMediaChart As DevExpress.XtraLayout.LayoutControlItem
		Private lciItemChart As DevExpress.XtraLayout.LayoutControlItem
		Private splitterItem1 As DevExpress.XtraLayout.SplitterItem
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private lciMostRentedMovies As DevExpress.XtraLayout.LayoutControlItem
		Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
		Private splitterItem2 As DevExpress.XtraLayout.SplitterItem
		Private WithEvents cardView1 As DevExpress.XtraGrid.Views.Card.CardView
		Private colPhoto As DevExpress.XtraGrid.Columns.GridColumn
		Private colTitle As DevExpress.XtraGrid.Columns.GridColumn
        Private WithEvents chart As DevExpress.XtraCharts.ChartControl
        Private WithEvents chartRevenues As DevExpress.XtraCharts.ChartControl
	End Class
End Namespace
