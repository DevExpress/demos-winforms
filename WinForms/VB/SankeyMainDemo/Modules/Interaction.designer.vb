Namespace DevExpress.XtraSankey.Demos

    Partial Class Interaction

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
            Dim keyColorColorizer1 As DevExpress.XtraMap.KeyColorColorizer = New DevExpress.XtraMap.KeyColorColorizer()
            Dim attributeItemKeyProvider1 As DevExpress.XtraMap.AttributeItemKeyProvider = New DevExpress.XtraMap.AttributeItemKeyProvider()
            Dim sankeyLinearLayoutAlgorithm1 As DevExpress.XtraCharts.Sankey.SankeyLinearLayoutAlgorithm = New DevExpress.XtraCharts.Sankey.SankeyLinearLayoutAlgorithm()
            Dim sankeyTitle1 As DevExpress.XtraCharts.Sankey.SankeyTitle = New DevExpress.XtraCharts.Sankey.SankeyTitle()
            Dim sankeyTitle2 As DevExpress.XtraCharts.Sankey.SankeyTitle = New DevExpress.XtraCharts.Sankey.SankeyTitle()
            Dim sankeyTitle3 As DevExpress.XtraCharts.Sankey.SankeyTitle = New DevExpress.XtraCharts.Sankey.SankeyTitle()
            Me.sidePanelRightRoot = New DevExpress.XtraEditors.SidePanel()
            Me.sidePanelRight1 = New DevExpress.XtraEditors.SidePanel()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.sidePanelRight2 = New DevExpress.XtraEditors.SidePanel()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.backgroundLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.interactableItemsLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.shapefileDataAdapter1 = New DevExpress.XtraMap.ShapefileDataAdapter()
            Me.vectorItemsLayer2 = New DevExpress.XtraMap.VectorItemsLayer()
            Me.mapItemStorage1 = New DevExpress.XtraMap.MapItemStorage()
            Me.sankeyDiagramControl1 = New DevExpress.XtraCharts.Sankey.SankeyDiagramControl()
            Me.sidePanelLeftRoot = New DevExpress.XtraEditors.SidePanel()
            Me.sidePanelRightRoot.SuspendLayout()
            Me.sidePanelRight1.SuspendLayout()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanelRight2.SuspendLayout()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanelLeftRoot.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' sidePanelRightRoot
            ' 
            Me.sidePanelRightRoot.Controls.Add(Me.sidePanelRight1)
            Me.sidePanelRightRoot.Controls.Add(Me.sidePanelRight2)
            Me.sidePanelRightRoot.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanelRightRoot.Location = New System.Drawing.Point(620, 0)
            Me.sidePanelRightRoot.Name = "sidePanelRightRoot"
            Me.sidePanelRightRoot.Size = New System.Drawing.Size(400, 649)
            Me.sidePanelRightRoot.TabIndex = 1
            Me.sidePanelRightRoot.Text = "sidePanel1"
            ' 
            ' sidePanelRight1
            ' 
            Me.sidePanelRight1.Controls.Add(Me.gridControl1)
            Me.sidePanelRight1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sidePanelRight1.Location = New System.Drawing.Point(1, 300)
            Me.sidePanelRight1.Name = "sidePanelRight1"
            Me.sidePanelRight1.Size = New System.Drawing.Size(399, 349)
            Me.sidePanelRight1.TabIndex = 1
            Me.sidePanelRight1.Text = "sidePanel1"
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(399, 349)
            Me.gridControl1.TabIndex = 11
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView1.OptionsBehavior.AutoSelectAllInEditor = False
            Me.gridView1.OptionsBehavior.AutoUpdateTotalSummary = False
            Me.gridView1.OptionsBehavior.Editable = False
            Me.gridView1.OptionsBehavior.[ReadOnly] = True
            Me.gridView1.OptionsCustomization.AllowColumnMoving = False
            Me.gridView1.OptionsCustomization.AllowFilter = False
            Me.gridView1.OptionsCustomization.AllowGroup = False
            Me.gridView1.OptionsMenu.EnableColumnMenu = False
            Me.gridView1.OptionsMenu.EnableFooterMenu = False
            Me.gridView1.OptionsMenu.EnableGroupPanelMenu = False
            Me.gridView1.OptionsSelection.MultiSelect = True
            Me.gridView1.OptionsView.ShowGroupPanel = False
            AddHandler Me.gridView1.SelectionChanged, New DevExpress.Data.SelectionChangedEventHandler(AddressOf Me.OnGridSelectionChanged)
            ' 
            ' sidePanelRight2
            ' 
            Me.sidePanelRight2.Controls.Add(Me.mapControl1)
            Me.sidePanelRight2.Dock = System.Windows.Forms.DockStyle.Top
            Me.sidePanelRight2.Location = New System.Drawing.Point(1, 0)
            Me.sidePanelRight2.Name = "sidePanelRight2"
            Me.sidePanelRight2.Size = New System.Drawing.Size(399, 300)
            Me.sidePanelRight2.TabIndex = 0
            Me.sidePanelRight2.Text = "sidePanel1"
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mapControl1.CenterPoint = New DevExpress.XtraMap.GeoPoint(40R, 0R)
            Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl1.EnableAnimation = False
            Me.mapControl1.EnableRotation = False
            Me.mapControl1.Layers.Add(Me.backgroundLayer)
            Me.mapControl1.Layers.Add(Me.interactableItemsLayer)
            Me.mapControl1.Layers.Add(Me.vectorItemsLayer2)
            Me.mapControl1.Location = New System.Drawing.Point(0, 0)
            Me.mapControl1.MaxZoomLevel = 3R
            Me.mapControl1.MinZoomLevel = 0.5R
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.NavigationPanelOptions.Visible = False
            Me.mapControl1.RenderMode = DevExpress.XtraMap.RenderMode.GdiPlus
            Me.mapControl1.SelectionMode = DevExpress.XtraMap.ElementSelectionMode.Multiple
            Me.mapControl1.Size = New System.Drawing.Size(399, 299)
            Me.mapControl1.TabIndex = 5
            AddHandler Me.mapControl1.SelectionChanged, New DevExpress.XtraMap.MapSelectionChangedEventHandler(AddressOf Me.OnMapSelectionChanged)
            AddHandler Me.mapControl1.Resize, New System.EventHandler(AddressOf Me.mapControl1_Resize)
            Me.backgroundLayer.EnableHighlighting = False
            Me.backgroundLayer.EnableSelection = False
            Me.backgroundLayer.ShapeTitlesVisibility = DevExpress.XtraMap.VisibilityMode.Hidden
            attributeItemKeyProvider1.AttributeName = "CONTINENT"
            keyColorColorizer1.ItemKeyProvider = attributeItemKeyProvider1
            Me.interactableItemsLayer.Colorizer = keyColorColorizer1
            Me.interactableItemsLayer.Data = Me.shapefileDataAdapter1
            Me.interactableItemsLayer.EnableHighlighting = False
            AddHandler Me.shapefileDataAdapter1.ItemsLoaded, New DevExpress.XtraMap.ItemsLoadedEventHandler(AddressOf Me.Adapter_ItemsLoaded)
            Me.vectorItemsLayer2.Data = Me.mapItemStorage1
            Me.vectorItemsLayer2.EnableHighlighting = False
            Me.vectorItemsLayer2.EnableSelection = False
            ' 
            ' sankeyDiagramControl1
            ' 
            Me.sankeyDiagramControl1.BorderOptions.Thickness = 0
            Me.sankeyDiagramControl1.Dock = System.Windows.Forms.DockStyle.Fill
            sankeyLinearLayoutAlgorithm1.NodeAlignment = DevExpress.XtraCharts.Sankey.SankeyNodeAlignment.Near
            Me.sankeyDiagramControl1.LayoutAlgorithm = sankeyLinearLayoutAlgorithm1
            Me.sankeyDiagramControl1.Location = New System.Drawing.Point(0, 0)
            Me.sankeyDiagramControl1.Name = "sankeyDiagramControl1"
            Me.sankeyDiagramControl1.SelectionMode = DevExpress.XtraCharts.Sankey.SankeySelectionMode.Multiple
            Me.sankeyDiagramControl1.Size = New System.Drawing.Size(620, 649)
            Me.sankeyDiagramControl1.SourceDataMember = "Exporter"
            Me.sankeyDiagramControl1.TabIndex = 4
            Me.sankeyDiagramControl1.TargetDataMember = "Importer"
            Me.sankeyDiagramControl1.Text = "sankeyDiagramControl1"
            sankeyTitle1.Text = "Major oil trade movements"
            sankeyTitle2.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F)
            sankeyTitle2.Text = "Trade flows worldwide (million tonnes)"
            sankeyTitle3.Dock = DevExpress.XtraCharts.Sankey.SankeyTitleDockStyle.Bottom
            sankeyTitle3.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            sankeyTitle3.Text = "bp Statistical Review of World Energy 2020"
            sankeyTitle3.TextAlignment = System.Drawing.StringAlignment.Far
            sankeyTitle3.TextColor = System.Drawing.Color.Gray
            Me.sankeyDiagramControl1.Titles.Add(sankeyTitle1)
            Me.sankeyDiagramControl1.Titles.Add(sankeyTitle2)
            Me.sankeyDiagramControl1.Titles.Add(sankeyTitle3)
            Me.sankeyDiagramControl1.WeightDataMember = "Sum"
            AddHandler Me.sankeyDiagramControl1.CustomizeNodeToolTip, New DevExpress.XtraCharts.Sankey.CustomizeSankeyNodeToolTipEventHandler(AddressOf Me.OnCustomizeNodeToolTip)
            AddHandler Me.sankeyDiagramControl1.CustomizeLinkToolTip, New DevExpress.XtraCharts.Sankey.CustomizeSankeyLinkToolTipEventHandler(AddressOf Me.OnCustomizeLinkToolTip)
            AddHandler Me.sankeyDiagramControl1.HighlightedItemsChanged, New DevExpress.XtraCharts.Sankey.SankeyHighlightedItemsChangedEventHandler(AddressOf Me.OnSankeyHighlightedItemsChanged)
            AddHandler Me.sankeyDiagramControl1.SelectedItemsChanged, New DevExpress.XtraCharts.Sankey.SankeySelectedItemsChangedEventHandler(AddressOf Me.OnSankeySelectedItemsChanged)
            ' 
            ' sidePanelLeftRoot
            ' 
            Me.sidePanelLeftRoot.Controls.Add(Me.sankeyDiagramControl1)
            Me.sidePanelLeftRoot.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sidePanelLeftRoot.Location = New System.Drawing.Point(0, 0)
            Me.sidePanelLeftRoot.Name = "sidePanelLeftRoot"
            Me.sidePanelLeftRoot.Size = New System.Drawing.Size(620, 649)
            Me.sidePanelLeftRoot.TabIndex = 2
            Me.sidePanelLeftRoot.Text = "sidePanel1"
            ' 
            ' Interaction
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.sidePanelLeftRoot)
            Me.Controls.Add(Me.sidePanelRightRoot)
            Me.Name = "Interaction"
            Me.Size = New System.Drawing.Size(1020, 649)
            Me.sidePanelRightRoot.ResumeLayout(False)
            Me.sidePanelRight1.ResumeLayout(False)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanelRight2.ResumeLayout(False)
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanelLeftRoot.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private sidePanelRightRoot As DevExpress.XtraEditors.SidePanel

        Private sidePanelRight1 As DevExpress.XtraEditors.SidePanel

        Private sidePanelRight2 As DevExpress.XtraEditors.SidePanel

        Private sidePanelLeftRoot As DevExpress.XtraEditors.SidePanel

        Private sankeyDiagramControl1 As DevExpress.XtraCharts.Sankey.SankeyDiagramControl

        Private mapControl1 As DevExpress.XtraMap.MapControl

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private interactableItemsLayer As DevExpress.XtraMap.VectorItemsLayer

        Private vectorItemsLayer2 As DevExpress.XtraMap.VectorItemsLayer

        Private mapItemStorage1 As DevExpress.XtraMap.MapItemStorage

        Private backgroundLayer As DevExpress.XtraMap.VectorItemsLayer

        Private shapefileDataAdapter1 As DevExpress.XtraMap.ShapefileDataAdapter
    End Class
End Namespace
