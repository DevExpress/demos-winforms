Imports DevExpress.XtraBars.Ribbon
Imports System.Drawing

Namespace DevExpress.XtraMap.Demos

    Partial Class BubbleCharts

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
            Me.OnDispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim keyColorColorizer1 As DevExpress.XtraMap.KeyColorColorizer = New DevExpress.XtraMap.KeyColorColorizer()
            Dim argumentItemKeyProvider1 As DevExpress.XtraMap.ArgumentItemKeyProvider = New DevExpress.XtraMap.ArgumentItemKeyProvider()
            Dim colorizerKeyItem1 As DevExpress.XtraMap.ColorizerKeyItem = New DevExpress.XtraMap.ColorizerKeyItem()
            Dim colorizerKeyItem2 As DevExpress.XtraMap.ColorizerKeyItem = New DevExpress.XtraMap.ColorizerKeyItem()
            Dim colorizerKeyItem3 As DevExpress.XtraMap.ColorizerKeyItem = New DevExpress.XtraMap.ColorizerKeyItem()
            Dim colorizerKeyItem4 As DevExpress.XtraMap.ColorizerKeyItem = New DevExpress.XtraMap.ColorizerKeyItem()
            Dim mapItemAttributeMapping1 As DevExpress.XtraMap.MapItemAttributeMapping = New DevExpress.XtraMap.MapItemAttributeMapping()
            Dim mapItemAttributeMapping2 As DevExpress.XtraMap.MapItemAttributeMapping = New DevExpress.XtraMap.MapItemAttributeMapping()
            Dim mapItemAttributeMapping3 As DevExpress.XtraMap.MapItemAttributeMapping = New DevExpress.XtraMap.MapItemAttributeMapping()
            Dim mapItemAttributeMapping4 As DevExpress.XtraMap.MapItemAttributeMapping = New DevExpress.XtraMap.MapItemAttributeMapping()
            Dim mapItemAttributeMapping5 As DevExpress.XtraMap.MapItemAttributeMapping = New DevExpress.XtraMap.MapItemAttributeMapping()
            Dim mapItemAttributeMapping6 As DevExpress.XtraMap.MapItemAttributeMapping = New DevExpress.XtraMap.MapItemAttributeMapping()
            Dim measureRules1 As DevExpress.XtraMap.MeasureRules = New DevExpress.XtraMap.MeasureRules()
            Dim linearRangeDistribution1 As DevExpress.XtraMap.LinearRangeDistribution = New DevExpress.XtraMap.LinearRangeDistribution()
            Dim mapItemAttributeValueProvider1 As DevExpress.XtraMap.MapItemAttributeValueProvider = New DevExpress.XtraMap.MapItemAttributeValueProvider()
            Dim sizeLegend1 As DevExpress.XtraMap.SizeLegend = New DevExpress.XtraMap.SizeLegend()
            Dim colorScaleLegend1 As DevExpress.XtraMap.ColorScaleLegend = New DevExpress.XtraMap.ColorScaleLegend()
            Dim trackBarLabel1 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel2 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel3 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Me.ItemsLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.BubbleChartDataAdapter = New DevExpress.XtraMap.BubbleChartDataAdapter()
            Me.TilesLayer = New DevExpress.XtraMap.ImageLayer()
            Me.AzureMapDataProvider = New DevExpress.XtraMap.AzureMapDataProvider()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            Me.rpgDecadeFilter = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.barCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem2 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem3 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem4 = New DevExpress.XtraBars.BarCheckItem()
            Me.rpgMagniduteFilter = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.barEditItem2 = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemRangeTrackBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemRangeTrackBar()
            Me.rpgMarkerKind = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.barEditItem1 = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemRangeTrackBar1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Size = New System.Drawing.Size(938, 139)
            ' 
            ' rpOptions
            ' 
            Me.rpOptions.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgDecadeFilter, Me.rpgMagniduteFilter, Me.rpgMarkerKind})
            keyColorColorizer1.Colors.Add(System.Drawing.Color.FromArgb((CInt(((CByte((128)))))), (CInt(((CByte((255)))))), (CInt(((CByte((93)))))), (CInt(((CByte((106))))))))
            keyColorColorizer1.Colors.Add(System.Drawing.Color.FromArgb((CInt(((CByte((128)))))), (CInt(((CByte((65)))))), (CInt(((CByte((124)))))), (CInt(((CByte((217))))))))
            keyColorColorizer1.Colors.Add(System.Drawing.Color.FromArgb((CInt(((CByte((128)))))), (CInt(((CByte((255)))))), (CInt(((CByte((221)))))), (CInt(((CByte((116))))))))
            keyColorColorizer1.Colors.Add(System.Drawing.Color.FromArgb((CInt(((CByte((128)))))), (CInt(((CByte((103)))))), (CInt(((CByte((191)))))), (CInt(((CByte((88))))))))
            keyColorColorizer1.ItemKeyProvider = argumentItemKeyProvider1
            colorizerKeyItem1.Key = "0"
            colorizerKeyItem1.Name = "1960-1969"
            colorizerKeyItem2.Key = "1"
            colorizerKeyItem2.Name = "1970-1979"
            colorizerKeyItem3.Key = "2"
            colorizerKeyItem3.Name = "1980-1989"
            colorizerKeyItem4.Key = "3"
            colorizerKeyItem4.Name = "1990-1999"
            keyColorColorizer1.Keys.Add(colorizerKeyItem1)
            keyColorColorizer1.Keys.Add(colorizerKeyItem2)
            keyColorColorizer1.Keys.Add(colorizerKeyItem3)
            keyColorColorizer1.Keys.Add(colorizerKeyItem4)
            Me.ItemsLayer.Colorizer = keyColorColorizer1
            Me.ItemsLayer.Data = Me.BubbleChartDataAdapter
            Me.ItemsLayer.Name = "ItemsLayer"
            Me.ItemsLayer.ToolTipPattern = "Date: {Date:d}" & Global.Microsoft.VisualBasic.Constants.vbLf & "Magnitude: {Magnitude}" & Global.Microsoft.VisualBasic.Constants.vbLf & "Depth: {Depth}km"
            mapItemAttributeMapping1.Member = "day"
            mapItemAttributeMapping1.Name = "Day"
            mapItemAttributeMapping2.Member = "mon"
            mapItemAttributeMapping2.Name = "Month"
            mapItemAttributeMapping3.Member = "yr"
            mapItemAttributeMapping3.Name = "Year"
            mapItemAttributeMapping4.Member = "mag"
            mapItemAttributeMapping4.Name = "Magnitude"
            mapItemAttributeMapping5.Member = "dep"
            mapItemAttributeMapping5.Name = "Depth"
            mapItemAttributeMapping6.Member = "Date"
            mapItemAttributeMapping6.Name = "Date"
            mapItemAttributeMapping6.ValueType = DevExpress.XtraMap.FieldValueType.DateTime
            Me.BubbleChartDataAdapter.AttributeMappings.Add(mapItemAttributeMapping1)
            Me.BubbleChartDataAdapter.AttributeMappings.Add(mapItemAttributeMapping2)
            Me.BubbleChartDataAdapter.AttributeMappings.Add(mapItemAttributeMapping3)
            Me.BubbleChartDataAdapter.AttributeMappings.Add(mapItemAttributeMapping4)
            Me.BubbleChartDataAdapter.AttributeMappings.Add(mapItemAttributeMapping5)
            Me.BubbleChartDataAdapter.AttributeMappings.Add(mapItemAttributeMapping6)
            Me.BubbleChartDataAdapter.ItemMaxSize = 60
            Me.BubbleChartDataAdapter.ItemMinSize = 10
            Me.BubbleChartDataAdapter.Mappings.BubbleGroup = "Type"
            Me.BubbleChartDataAdapter.Mappings.Latitude = "glat"
            Me.BubbleChartDataAdapter.Mappings.Longitude = "glon"
            Me.BubbleChartDataAdapter.Mappings.Value = "mag"
            measureRules1.ApproximateValues = True
            measureRules1.RangeDistribution = linearRangeDistribution1
            measureRules1.RangeStops.Add(6R)
            measureRules1.RangeStops.Add(7R)
            measureRules1.RangeStops.Add(8R)
            measureRules1.RangeStops.Add(9R)
            measureRules1.RangeStops.Add(10R)
            mapItemAttributeValueProvider1.AttributeName = "Magnitude"
            measureRules1.ValueProvider = mapItemAttributeValueProvider1
            Me.BubbleChartDataAdapter.MeasureRules = measureRules1
            Me.TilesLayer.DataProvider = Me.AzureMapDataProvider
            Me.TilesLayer.Name = "TilesLayer"
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl1.Layers.Add(Me.TilesLayer)
            Me.mapControl1.Layers.Add(Me.ItemsLayer)
            sizeLegend1.Header = "Magnitude"
            sizeLegend1.Layer = Me.ItemsLayer
            sizeLegend1.Visibility = DevExpress.XtraMap.VisibilityMode.Visible
            colorScaleLegend1.Header = "Years"
            colorScaleLegend1.Visibility = DevExpress.XtraMap.VisibilityMode.Visible
            Me.mapControl1.Legends.Add(sizeLegend1)
            Me.mapControl1.Legends.Add(colorScaleLegend1)
            Me.mapControl1.Location = New System.Drawing.Point(0, 139)
            Me.mapControl1.MaxZoomLevel = 10R
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.NavigationPanelOptions.Visible = False
            Me.mapControl1.Size = New System.Drawing.Size(938, 426)
            Me.mapControl1.TabIndex = 0
            Me.mapControl1.ToolTipController = Me.toolTipController1
            Me.mapControl1.ZoomLevel = 2R
            ' 
            ' toolTipController1
            ' 
            Me.toolTipController1.AllowHtmlText = True
            ' 
            ' rpgDecadeFilter
            ' 
            Me.rpgDecadeFilter.ItemLinks.Add(Me.barCheckItem1)
            Me.rpgDecadeFilter.ItemLinks.Add(Me.barCheckItem2)
            Me.rpgDecadeFilter.ItemLinks.Add(Me.barCheckItem3)
            Me.rpgDecadeFilter.ItemLinks.Add(Me.barCheckItem4)
            Me.rpgDecadeFilter.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.TwoRows
            Me.rpgDecadeFilter.Name = "rpgDecadeFilter"
            Me.rpgDecadeFilter.Text = "Filter by Decade"
            ' 
            ' barCheckItem1
            ' 
            Me.barCheckItem1.BindableChecked = True
            Me.barCheckItem1.Caption = "1960-1969"
            Me.barCheckItem1.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.barCheckItem1.Checked = True
            Me.barCheckItem1.Id = 19
            Me.barCheckItem1.ItemAppearance.Pressed.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((192)))))), (CInt(((CByte((192)))))))
            Me.barCheckItem1.ItemAppearance.Pressed.Options.UseBackColor = True
            Me.barCheckItem1.Name = "barCheckItem1"
            AddHandler Me.barCheckItem1.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.barCheckItem_CheckedChanged)
            ' 
            ' barCheckItem2
            ' 
            Me.barCheckItem2.BindableChecked = True
            Me.barCheckItem2.Caption = "1970-1979"
            Me.barCheckItem2.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.barCheckItem2.Checked = True
            Me.barCheckItem2.Id = 20
            Me.barCheckItem2.Name = "barCheckItem2"
            AddHandler Me.barCheckItem2.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.barCheckItem_CheckedChanged)
            ' 
            ' barCheckItem3
            ' 
            Me.barCheckItem3.BindableChecked = True
            Me.barCheckItem3.Caption = "1980-1989"
            Me.barCheckItem3.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.barCheckItem3.Checked = True
            Me.barCheckItem3.Id = 21
            Me.barCheckItem3.Name = "barCheckItem3"
            AddHandler Me.barCheckItem3.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.barCheckItem_CheckedChanged)
            ' 
            ' barCheckItem4
            ' 
            Me.barCheckItem4.BindableChecked = True
            Me.barCheckItem4.Caption = "1990-1999"
            Me.barCheckItem4.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.barCheckItem4.Checked = True
            Me.barCheckItem4.Id = 22
            Me.barCheckItem4.Name = "barCheckItem4"
            AddHandler Me.barCheckItem4.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.barCheckItem_CheckedChanged)
            ' 
            ' rpgMagniduteFilter
            ' 
            Me.rpgMagniduteFilter.ItemLinks.Add(Me.barEditItem2)
            Me.rpgMagniduteFilter.Name = "rpgMagniduteFilter"
            Me.rpgMagniduteFilter.Text = "Filter by Magnitude"
            ' 
            ' barEditItem2
            ' 
            Me.barEditItem2.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.barEditItem2.Edit = Me.repositoryItemRangeTrackBar1
            Me.barEditItem2.EditHeight = 60
            Me.barEditItem2.EditWidth = 120
            Me.barEditItem2.Id = 29
            Me.barEditItem2.Name = "barEditItem2"
            ' 
            ' repositoryItemRangeTrackBar1
            ' 
            Me.repositoryItemRangeTrackBar1.Appearance.BorderColor = System.Drawing.Color.Transparent
            Me.repositoryItemRangeTrackBar1.Appearance.Options.UseBorderColor = True
            Me.repositoryItemRangeTrackBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.repositoryItemRangeTrackBar1.LabelAppearance.Options.UseTextOptions = True
            Me.repositoryItemRangeTrackBar1.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            trackBarLabel1.Label = "7"
            trackBarLabel1.Value = 70
            trackBarLabel2.Label = "8"
            trackBarLabel2.Value = 80
            trackBarLabel3.Label = "9"
            trackBarLabel3.Value = 90
            Me.repositoryItemRangeTrackBar1.Labels.AddRange(New DevExpress.XtraEditors.Repository.TrackBarLabel() {trackBarLabel1, trackBarLabel2, trackBarLabel3})
            Me.repositoryItemRangeTrackBar1.Maximum = 96
            Me.repositoryItemRangeTrackBar1.Minimum = 65
            Me.repositoryItemRangeTrackBar1.Name = "repositoryItemRangeTrackBar1"
            Me.repositoryItemRangeTrackBar1.ShowLabels = True
            Me.repositoryItemRangeTrackBar1.TickFrequency = 5
            AddHandler Me.repositoryItemRangeTrackBar1.EditValueChanged, New System.EventHandler(AddressOf Me.repositoryItemRangeTrackBar1_EditValueChanged)
            ' 
            ' rpgMarkerKind
            ' 
            Me.rpgMarkerKind.ItemLinks.Add(Me.barEditItem1)
            Me.rpgMarkerKind.Name = "rpgMarkerKind"
            Me.rpgMarkerKind.Text = "Marker Type"
            ' 
            ' barEditItem1
            ' 
            Me.barEditItem1.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.barEditItem1.Edit = Me.repositoryItemComboBox1
            Me.barEditItem1.EditValue = "Circle"
            Me.barEditItem1.EditWidth = 125
            Me.barEditItem1.Id = 28
            Me.barEditItem1.Name = "barEditItem1"
            AddHandler Me.barEditItem1.EditValueChanged, New System.EventHandler(AddressOf Me.barEditItem1_EditValueChanged)
            ' 
            ' repositoryItemComboBox1
            ' 
            Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemComboBox1.DropDownRows = 12
            Me.repositoryItemComboBox1.Items.AddRange(New Object() {"Circle", "Square", "Diamond", "Triangle", "InvertedTriangle", "Plus", "Cross", "Star5", "Star6", "Star8", "Pentagon", "Hexagon"})
            Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
            Me.repositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            ' 
            ' BubbleCharts
            ' 
            Me.Appearance.Options.UseFont = True
            Me.panelControl1.Controls.Add(Me.mapControl1)
            Me.Name = "BubbleCharts"
            Me.Size = New System.Drawing.Size(938, 565)
            Me.Controls.SetChildIndex(Me.ribbonControl1, 0)
            Me.panelControl1.Controls.SetChildIndex(Me.mapControl1, 0)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemRangeTrackBar1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private mapControl1 As DevExpress.XtraMap.MapControl

        Private toolTipController1 As DevExpress.Utils.ToolTipController

        Private barCheckItem1 As DevExpress.XtraBars.BarCheckItem

        Private barCheckItem2 As DevExpress.XtraBars.BarCheckItem

        Private barCheckItem3 As DevExpress.XtraBars.BarCheckItem

        Private barCheckItem4 As DevExpress.XtraBars.BarCheckItem

        Private rpgDecadeFilter As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private rpgMarkerKind As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private barEditItem1 As DevExpress.XtraBars.BarEditItem

        Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox

        Private rpgMagniduteFilter As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private barEditItem2 As DevExpress.XtraBars.BarEditItem

        Private repositoryItemRangeTrackBar1 As DevExpress.XtraEditors.Repository.RepositoryItemRangeTrackBar

        Private TilesLayer As DevExpress.XtraMap.ImageLayer

        Private ItemsLayer As DevExpress.XtraMap.VectorItemsLayer

        Private BubbleChartDataAdapter As DevExpress.XtraMap.BubbleChartDataAdapter

        Private AzureMapDataProvider As DevExpress.XtraMap.AzureMapDataProvider
    End Class
End Namespace
