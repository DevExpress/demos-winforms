Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Controls
	Partial Public Class ucMovieItemsInfo
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso ((Not Object.Equals(components, Nothing))) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim SimpleDiagram1 As DevExpress.XtraCharts.SimpleDiagram = New DevExpress.XtraCharts.SimpleDiagram
            Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series
            Dim DoughnutSeriesLabel1 As DevExpress.XtraCharts.DoughnutSeriesLabel = New DevExpress.XtraCharts.DoughnutSeriesLabel
            Dim DoughnutSeriesView1 As DevExpress.XtraCharts.DoughnutSeriesView = New DevExpress.XtraCharts.DoughnutSeriesView
            Dim SeriesTitle1 As DevExpress.XtraCharts.SeriesTitle = New DevExpress.XtraCharts.SeriesTitle
            Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series
            Dim DoughnutSeriesLabel2 As DevExpress.XtraCharts.DoughnutSeriesLabel = New DevExpress.XtraCharts.DoughnutSeriesLabel
            Dim DoughnutSeriesView2 As DevExpress.XtraCharts.DoughnutSeriesView = New DevExpress.XtraCharts.DoughnutSeriesView
            Dim SeriesTitle2 As DevExpress.XtraCharts.SeriesTitle = New DevExpress.XtraCharts.SeriesTitle
            Dim DoughnutSeriesLabel3 As DevExpress.XtraCharts.DoughnutSeriesLabel = New DevExpress.XtraCharts.DoughnutSeriesLabel
            Dim DoughnutSeriesView3 As DevExpress.XtraCharts.DoughnutSeriesView = New DevExpress.XtraCharts.DoughnutSeriesView
            Me.lcMain = New DevExpress.XtraLayout.LayoutControl
            Me.ccFormatsInfo = New DevExpress.XtraCharts.ChartControl
            Me.teLastRentedOn = New DevExpress.XtraEditors.TextEdit
            Me.tcFormats = New DevExpress.XtraTab.XtraTabControl
            Me.tpFormat = New DevExpress.XtraTab.XtraTabPage
            Me.lcFormat = New DevExpress.XtraLayout.LayoutControl
            Me.ucRentalSalesInfo = New DevExpress.VideoRent.Win.Controls.ucRentalSalesInfo
            Me.lcgInfo = New DevExpress.XtraLayout.LayoutControlGroup
            Me.lciInfo = New DevExpress.XtraLayout.LayoutControlItem
            Me.lcgMain = New DevExpress.XtraLayout.LayoutControlGroup
            Me.lciFormats = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciLastRentedOn = New DevExpress.XtraLayout.LayoutControlItem
            Me.lciChart = New DevExpress.XtraLayout.LayoutControlItem
            CType(Me.lcMain, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.lcMain.SuspendLayout()
            CType(Me.ccFormatsInfo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SimpleDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(DoughnutSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(DoughnutSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(DoughnutSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(DoughnutSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(DoughnutSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(DoughnutSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.teLastRentedOn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tcFormats, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tcFormats.SuspendLayout()
            Me.tpFormat.SuspendLayout()
            CType(Me.lcFormat, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.lcFormat.SuspendLayout()
            CType(Me.lcgInfo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciInfo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciFormats, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciLastRentedOn, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciChart, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lcMain
            '
            Me.lcMain.AllowCustomization = False
            Me.lcMain.Controls.Add(Me.ccFormatsInfo)
            Me.lcMain.Controls.Add(Me.teLastRentedOn)
            Me.lcMain.Controls.Add(Me.tcFormats)
            Me.lcMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lcMain.Location = New System.Drawing.Point(0, 0)
            Me.lcMain.Name = "lcMain"
            Me.lcMain.Padding = New System.Windows.Forms.Padding(3)
            Me.lcMain.Root = Me.lcgMain
            Me.lcMain.Size = New System.Drawing.Size(483, 400)
            Me.lcMain.TabIndex = 0
            Me.lcMain.Text = "layoutControl1"
            '
            'ccFormatsInfo
            '
            Me.ccFormatsInfo.BorderOptions.Visibility = Utils.DefaultBoolean.False
            Me.ccFormatsInfo.CrosshairOptions.ArgumentLineColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(205, Byte), Integer))
            Me.ccFormatsInfo.CrosshairOptions.ValueLineColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(205, Byte), Integer))
            SimpleDiagram1.CustomPanel = Nothing
            SimpleDiagram1.EqualPieSize = False
            Me.ccFormatsInfo.Diagram = SimpleDiagram1
            Me.ccFormatsInfo.Legend.Visibility = Utils.DefaultBoolean.False
            Me.ccFormatsInfo.Location = New System.Drawing.Point(5, 187)
            Me.ccFormatsInfo.Name = "ccFormatsInfo"
            DoughnutSeriesLabel1.LineVisibility = Utils.DefaultBoolean.True
            DoughnutSeriesLabel1.TextPattern = "{A:G2}: {V:P2}"
            Series1.Label = DoughnutSeriesLabel1
            Series1.Name = "Series 1"
            DoughnutSeriesView1.RuntimeExploding = True
            SeriesTitle1.Text = "Media Formats"
            DoughnutSeriesView1.Titles.AddRange(New DevExpress.XtraCharts.SeriesTitle() {SeriesTitle1})
            Series1.View = DoughnutSeriesView1
            DoughnutSeriesLabel2.LineVisibility = Utils.DefaultBoolean.True
            DoughnutSeriesLabel2.TextPattern = "{A:G2}: {V:P2}"
            Series2.Label = DoughnutSeriesLabel2
            Series2.Name = "Series 2"
            DoughnutSeriesView2.RuntimeExploding = False
            SeriesTitle2.Text = "Unit Allocation"
            DoughnutSeriesView2.Titles.AddRange(New DevExpress.XtraCharts.SeriesTitle() {SeriesTitle2})
            Series2.View = DoughnutSeriesView2
            Me.ccFormatsInfo.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2}
            DoughnutSeriesLabel3.LineVisibility = Utils.DefaultBoolean.True
            DoughnutSeriesLabel3.TextPattern = "{VP:G2}"
            Me.ccFormatsInfo.SeriesTemplate.Label = DoughnutSeriesLabel3
            DoughnutSeriesView3.RuntimeExploding = False
            Me.ccFormatsInfo.SeriesTemplate.View = DoughnutSeriesView3
            Me.ccFormatsInfo.Size = New System.Drawing.Size(469, 208)
            Me.ccFormatsInfo.TabIndex = 46
            '
            'teLastRentedOn
            '
            Me.teLastRentedOn.Location = New System.Drawing.Point(94, 5)
            Me.teLastRentedOn.Name = "teLastRentedOn"
            Me.teLastRentedOn.Properties.ReadOnly = True
            Me.teLastRentedOn.Size = New System.Drawing.Size(384, 20)
            Me.teLastRentedOn.StyleController = Me.lcMain
            Me.teLastRentedOn.TabIndex = 6
            '
            'tcFormats
            '
            Me.tcFormats.Location = New System.Drawing.Point(5, 29)
            Me.tcFormats.MinimumSize = New System.Drawing.Size(0, 140)
            Me.tcFormats.Name = "tcFormats"
            Me.tcFormats.SelectedTabPage = Me.tpFormat
            Me.tcFormats.Size = New System.Drawing.Size(473, 154)
            Me.tcFormats.TabIndex = 5
            Me.tcFormats.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tpFormat})
            '
            'tpFormat
            '
            Me.tpFormat.Controls.Add(Me.lcFormat)
            Me.tpFormat.Name = "tpFormat"
            Me.tpFormat.Size = New System.Drawing.Size(467, 126)
            Me.tpFormat.Text = "Format"
            '
            'lcFormat
            '
            Me.lcFormat.Controls.Add(Me.ucRentalSalesInfo)
            Me.lcFormat.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lcFormat.Location = New System.Drawing.Point(0, 0)
            Me.lcFormat.Name = "lcFormat"
            Me.lcFormat.Padding = New System.Windows.Forms.Padding(3)
            Me.lcFormat.Root = Me.lcgInfo
            Me.lcFormat.Size = New System.Drawing.Size(467, 126)
            Me.lcFormat.TabIndex = 0
            Me.lcFormat.Text = "lcFormats"
            '
            'ucRentalSalesInfo
            '
            Me.ucRentalSalesInfo.Location = New System.Drawing.Point(5, 5)
            Me.ucRentalSalesInfo.Name = "ucRentalSalesInfo"
            Me.ucRentalSalesInfo.Size = New System.Drawing.Size(457, 116)
            Me.ucRentalSalesInfo.TabIndex = 4
            '
            'lcgInfo
            '
            Me.lcgInfo.CustomizationFormText = "lcgInfo"
            Me.lcgInfo.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.lcgInfo.GroupBordersVisible = False
            Me.lcgInfo.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciInfo})
            Me.lcgInfo.Location = New System.Drawing.Point(0, 0)
            Me.lcgInfo.Name = "lcgInfo"
            Me.lcgInfo.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
            Me.lcgInfo.Size = New System.Drawing.Size(467, 126)
            Me.lcgInfo.Text = "lcgInfo"
            Me.lcgInfo.TextVisible = False
            '
            'lciInfo
            '
            Me.lciInfo.Control = Me.ucRentalSalesInfo
            Me.lciInfo.CustomizationFormText = "lciInfo"
            Me.lciInfo.Location = New System.Drawing.Point(0, 0)
            Me.lciInfo.Name = "lciInfo"
            Me.lciInfo.Size = New System.Drawing.Size(461, 120)
            Me.lciInfo.Text = "lciInfo"
            Me.lciInfo.TextSize = New System.Drawing.Size(0, 0)
            Me.lciInfo.TextToControlDistance = 0
            Me.lciInfo.TextVisible = False
            '
            'lcgMain
            '
            Me.lcgMain.CustomizationFormText = "lcgMain"
            Me.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.lcgMain.GroupBordersVisible = False
            Me.lcgMain.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciFormats, Me.lciLastRentedOn, Me.lciChart})
            Me.lcgMain.Location = New System.Drawing.Point(0, 0)
            Me.lcgMain.Name = "Root"
            Me.lcgMain.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
            Me.lcgMain.Size = New System.Drawing.Size(483, 400)
            Me.lcgMain.Text = "Root"
            Me.lcgMain.TextVisible = False
            '
            'lciFormats
            '
            Me.lciFormats.Control = Me.tcFormats
            Me.lciFormats.CustomizationFormText = "lciFormats"
            Me.lciFormats.Location = New System.Drawing.Point(0, 24)
            Me.lciFormats.MaxSize = New System.Drawing.Size(0, 158)
            Me.lciFormats.MinSize = New System.Drawing.Size(24, 158)
            Me.lciFormats.Name = "lciFormats"
            Me.lciFormats.Size = New System.Drawing.Size(477, 158)
            Me.lciFormats.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.lciFormats.Text = "lciFormats"
            Me.lciFormats.TextSize = New System.Drawing.Size(0, 0)
            Me.lciFormats.TextToControlDistance = 0
            Me.lciFormats.TextVisible = False
            '
            'lciLastRentedOn
            '
            Me.lciLastRentedOn.Control = Me.teLastRentedOn
            Me.lciLastRentedOn.CustomizationFormText = "Last Rented On:"
            Me.lciLastRentedOn.Location = New System.Drawing.Point(0, 0)
            Me.lciLastRentedOn.Name = "lciLastRentedOn"
            Me.lciLastRentedOn.Size = New System.Drawing.Size(477, 24)
            Me.lciLastRentedOn.Text = "Last Rented On:"
            Me.lciLastRentedOn.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
            Me.lciLastRentedOn.TextSize = New System.Drawing.Size(83, 13)
            Me.lciLastRentedOn.TextToControlDistance = 6
            '
            'lciChart
            '
            Me.lciChart.Control = Me.ccFormatsInfo
            Me.lciChart.CustomizationFormText = "layoutControlItemChart"
            Me.lciChart.Location = New System.Drawing.Point(0, 182)
            Me.lciChart.Name = "lciChart"
            Me.lciChart.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 6, 2, 2)
            Me.lciChart.Size = New System.Drawing.Size(477, 212)
            Me.lciChart.Text = "lciChart"
            Me.lciChart.TextSize = New System.Drawing.Size(0, 0)
            Me.lciChart.TextToControlDistance = 0
            Me.lciChart.TextVisible = False
            '
            'ucMovieItemsInfo
            '
            Me.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.Appearance.Options.UseBackColor = True
            Me.Controls.Add(Me.lcMain)
            Me.Name = "ucMovieItemsInfo"
            Me.Size = New System.Drawing.Size(483, 400)
            CType(Me.lcMain, System.ComponentModel.ISupportInitialize).EndInit()
            Me.lcMain.ResumeLayout(False)
            CType(SimpleDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(DoughnutSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(DoughnutSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(DoughnutSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(DoughnutSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(DoughnutSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(DoughnutSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ccFormatsInfo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.teLastRentedOn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tcFormats, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tcFormats.ResumeLayout(False)
            Me.tpFormat.ResumeLayout(False)
            CType(Me.lcFormat, System.ComponentModel.ISupportInitialize).EndInit()
            Me.lcFormat.ResumeLayout(False)
            CType(Me.lcgInfo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciInfo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciFormats, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciLastRentedOn, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciChart, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private lcMain As DevExpress.XtraLayout.LayoutControl
		Private lcgMain As DevExpress.XtraLayout.LayoutControlGroup
		Private WithEvents tcFormats As DevExpress.XtraTab.XtraTabControl
		Private tpFormat As DevExpress.XtraTab.XtraTabPage
		Private lcFormat As DevExpress.XtraLayout.LayoutControl
		Private ucRentalSalesInfo As ucRentalSalesInfo
		Private lcgInfo As DevExpress.XtraLayout.LayoutControlGroup
		Private lciInfo As DevExpress.XtraLayout.LayoutControlItem
		Private lciFormats As DevExpress.XtraLayout.LayoutControlItem
		Private teLastRentedOn As DevExpress.XtraEditors.TextEdit
		Private lciLastRentedOn As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents ccFormatsInfo As DevExpress.XtraCharts.ChartControl
		Private lciChart As DevExpress.XtraLayout.LayoutControlItem

	End Class
End Namespace
