Namespace DevExpress.XtraSankey.Demos

    Partial Class Colorizer

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
        Private Overloads Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim sankeyLinearLayoutAlgorithm1 As DevExpress.XtraCharts.Sankey.SankeyLinearLayoutAlgorithm = New DevExpress.XtraCharts.Sankey.SankeyLinearLayoutAlgorithm()
            Dim sankeyTitle1 As DevExpress.XtraCharts.Sankey.SankeyTitle = New DevExpress.XtraCharts.Sankey.SankeyTitle()
            Dim sankeyTitle2 As DevExpress.XtraCharts.Sankey.SankeyTitle = New DevExpress.XtraCharts.Sankey.SankeyTitle()
            Dim sankeyTitle3 As DevExpress.XtraCharts.Sankey.SankeyTitle = New DevExpress.XtraCharts.Sankey.SankeyTitle()
            Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            Me.sankeyDiagramControl1 = New DevExpress.XtraCharts.Sankey.SankeyDiagramControl()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroupTotalLabels = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemTotalLabelVisible = New DevExpress.XtraLayout.LayoutControlItem()
            Me.AsiaChE = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.nodeAlignmentRadioGroup = New DevExpress.XtraEditors.RadioGroup()
            Me.resolveOverlappingChE = New DevExpress.XtraEditors.CheckEdit()
            Me.AustraliaChE = New DevExpress.XtraEditors.CheckEdit()
            Me.EuropeChE = New DevExpress.XtraEditors.CheckEdit()
            Me.NorthAmericaChE = New DevExpress.XtraEditors.CheckEdit()
            Me.SouthAmericaChE = New DevExpress.XtraEditors.CheckEdit()
            Me.colorizerRadioGroup = New DevExpress.XtraEditors.RadioGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupTotalLabels1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupTotalLabels2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItemBottom = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroupTotalLabels3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupTotalLabels), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemTotalLabelVisible), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.AsiaChE.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.nodeAlignmentRadioGroup.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.resolveOverlappingChE.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.AustraliaChE.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.EuropeChE.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.NorthAmericaChE.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.SouthAmericaChE.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.colorizerRadioGroup.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupTotalLabels1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupTotalLabels2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItemBottom), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupTotalLabels3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' sidePanelOptions
            ' 
            Me.sidePanelOptions.Location = New System.Drawing.Point(578, 0)
            Me.sidePanelOptions.Size = New System.Drawing.Size(210, 571)
            ' 
            ' tabPaneOptions
            ' 
            Me.tabPaneOptions.RegularSize = New System.Drawing.Size(209, 571)
            Me.tabPaneOptions.Size = New System.Drawing.Size(209, 571)
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(209, 538)
            ' 
            ' toolTipController1
            ' 
            Me.toolTipController1.Appearance.Options.UseTextOptions = True
            Me.toolTipController1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None
            Me.toolTipController1.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip
            ' 
            ' sankeyDiagramControl1
            ' 
            Me.sankeyDiagramControl1.BorderOptions.Thickness = 0
            Me.sankeyDiagramControl1.Dock = System.Windows.Forms.DockStyle.Fill
            sankeyLinearLayoutAlgorithm1.NodeAlignment = DevExpress.XtraCharts.Sankey.SankeyNodeAlignment.Far
            Me.sankeyDiagramControl1.LayoutAlgorithm = sankeyLinearLayoutAlgorithm1
            Me.sankeyDiagramControl1.Location = New System.Drawing.Point(0, 0)
            Me.sankeyDiagramControl1.Name = "sankeyDiagramControl1"
            Me.sankeyDiagramControl1.Size = New System.Drawing.Size(578, 571)
            Me.sankeyDiagramControl1.SourceDataMember = "Exporter"
            Me.sankeyDiagramControl1.TabIndex = 5
            Me.sankeyDiagramControl1.TargetDataMember = "Importer"
            Me.sankeyDiagramControl1.Text = "sankeyDiagramControl1"
            sankeyTitle1.Text = "Largest Export Partners"
            sankeyTitle2.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F)
            sankeyTitle2.Text = "Colored by Continent"
            sankeyTitle3.Dock = DevExpress.XtraCharts.Sankey.SankeyTitleDockStyle.Bottom
            sankeyTitle3.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            sankeyTitle3.Text = "From www.cia.gov"
            sankeyTitle3.TextAlignment = System.Drawing.StringAlignment.Far
            sankeyTitle3.TextColor = System.Drawing.Color.Gray
            Me.sankeyDiagramControl1.Titles.Add(sankeyTitle1)
            Me.sankeyDiagramControl1.Titles.Add(sankeyTitle2)
            Me.sankeyDiagramControl1.Titles.Add(sankeyTitle3)
            Me.sankeyDiagramControl1.WeightDataMember = "Sum"
            AddHandler Me.sankeyDiagramControl1.CustomizeNodeToolTip, New DevExpress.XtraCharts.Sankey.CustomizeSankeyNodeToolTipEventHandler(AddressOf Me.OnCustomizeNodeToolTip)
            AddHandler Me.sankeyDiagramControl1.CustomizeLinkToolTip, New DevExpress.XtraCharts.Sankey.CustomizeSankeyLinkToolTipEventHandler(AddressOf Me.OnCustomizeLinkToolTip)
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroupTotalLabels, Me.layoutControlGroupTotalLabels1, Me.layoutControlGroupTotalLabels2, Me.emptySpaceItemBottom, Me.layoutControlGroupTotalLabels3})
            Me.layoutControlGroupRoot.Name = "Root"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(209, 538)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' layoutControlGroupTotalLabels
            ' 
            Me.layoutControlGroupTotalLabels.CustomizationFormText = "Continent Visibility"
            Me.layoutControlGroupTotalLabels.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupTotalLabels.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemTotalLabelVisible, Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4})
            Me.layoutControlGroupTotalLabels.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupTotalLabels.Name = "layoutControlGroupTotalLabels"
            Me.layoutControlGroupTotalLabels.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 10, 10, 10)
            Me.layoutControlGroupTotalLabels.Size = New System.Drawing.Size(209, 162)
            Me.layoutControlGroupTotalLabels.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupTotalLabels.Text = "Continent Visibility"
            ' 
            ' layoutControlItemTotalLabelVisible
            ' 
            Me.layoutControlItemTotalLabelVisible.Control = Me.AsiaChE
            Me.layoutControlItemTotalLabelVisible.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.layoutControlItemTotalLabelVisible.CustomizationFormText = "layoutControlItemTotalLabelVisible"
            Me.layoutControlItemTotalLabelVisible.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemTotalLabelVisible.Name = "layoutControlItemTotalLabelVisible"
            Me.layoutControlItemTotalLabelVisible.Size = New System.Drawing.Size(183, 24)
            Me.layoutControlItemTotalLabelVisible.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemTotalLabelVisible.TextVisible = False
            ' 
            ' AsiaChE
            ' 
            Me.AsiaChE.EditValue = True
            Me.AsiaChE.Location = New System.Drawing.Point(18, 34)
            Me.AsiaChE.Name = "AsiaChE"
            Me.AsiaChE.Properties.Caption = "Asia"
            Me.AsiaChE.Size = New System.Drawing.Size(179, 20)
            Me.AsiaChE.StyleController = Me.layoutControl
            Me.AsiaChE.TabIndex = 15
            AddHandler Me.AsiaChE.CheckedChanged, New System.EventHandler(AddressOf Me.ChE_CheckedChanged)
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.nodeAlignmentRadioGroup)
            Me.layoutControl.Controls.Add(Me.resolveOverlappingChE)
            Me.layoutControl.Controls.Add(Me.AsiaChE)
            Me.layoutControl.Controls.Add(Me.AustraliaChE)
            Me.layoutControl.Controls.Add(Me.EuropeChE)
            Me.layoutControl.Controls.Add(Me.NorthAmericaChE)
            Me.layoutControl.Controls.Add(Me.SouthAmericaChE)
            Me.layoutControl.Controls.Add(Me.colorizerRadioGroup)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.Root = Me.layoutControlGroupRoot
            Me.layoutControl.Size = New System.Drawing.Size(209, 538)
            Me.layoutControl.TabIndex = 1
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' nodeAlignmentRadioGroup
            ' 
            Me.nodeAlignmentRadioGroup.Location = New System.Drawing.Point(12, 338)
            Me.nodeAlignmentRadioGroup.MenuManager = Me
            Me.nodeAlignmentRadioGroup.Name = "nodeAlignmentRadioGroup"
            Me.nodeAlignmentRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.nodeAlignmentRadioGroup.Properties.Appearance.Options.UseBackColor = True
            Me.nodeAlignmentRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.nodeAlignmentRadioGroup.Size = New System.Drawing.Size(185, 36)
            Me.nodeAlignmentRadioGroup.StyleController = Me.layoutControl
            Me.nodeAlignmentRadioGroup.TabIndex = 23
            AddHandler Me.nodeAlignmentRadioGroup.SelectedIndexChanged, New System.EventHandler(AddressOf Me.nodeAlignmentRadioGroup_SelectedIndexChanged)
            ' 
            ' resolveOverlappingChE
            ' 
            Me.resolveOverlappingChE.EditValue = True
            Me.resolveOverlappingChE.Location = New System.Drawing.Point(18, 272)
            Me.resolveOverlappingChE.MenuManager = Me
            Me.resolveOverlappingChE.Name = "resolveOverlappingChE"
            Me.resolveOverlappingChE.Properties.Caption = "Enabled"
            Me.resolveOverlappingChE.Size = New System.Drawing.Size(179, 20)
            Me.resolveOverlappingChE.StyleController = Me.layoutControl
            Me.resolveOverlappingChE.TabIndex = 21
            AddHandler Me.resolveOverlappingChE.CheckedChanged, New System.EventHandler(AddressOf Me.ResolveOverlappingChE_CheckedChanged)
            ' 
            ' AustraliaChE
            ' 
            Me.AustraliaChE.EditValue = True
            Me.AustraliaChE.Location = New System.Drawing.Point(18, 58)
            Me.AustraliaChE.MenuManager = Me
            Me.AustraliaChE.Name = "AustraliaChE"
            Me.AustraliaChE.Properties.Caption = "Australia"
            Me.AustraliaChE.Size = New System.Drawing.Size(179, 20)
            Me.AustraliaChE.StyleController = Me.layoutControl
            Me.AustraliaChE.TabIndex = 16
            AddHandler Me.AustraliaChE.CheckedChanged, New System.EventHandler(AddressOf Me.ChE_CheckedChanged)
            ' 
            ' EuropeChE
            ' 
            Me.EuropeChE.EditValue = True
            Me.EuropeChE.Location = New System.Drawing.Point(18, 82)
            Me.EuropeChE.MenuManager = Me
            Me.EuropeChE.Name = "EuropeChE"
            Me.EuropeChE.Properties.Caption = "Europe"
            Me.EuropeChE.Size = New System.Drawing.Size(179, 20)
            Me.EuropeChE.StyleController = Me.layoutControl
            Me.EuropeChE.TabIndex = 17
            AddHandler Me.EuropeChE.CheckedChanged, New System.EventHandler(AddressOf Me.ChE_CheckedChanged)
            ' 
            ' NorthAmericaChE
            ' 
            Me.NorthAmericaChE.EditValue = True
            Me.NorthAmericaChE.Location = New System.Drawing.Point(18, 106)
            Me.NorthAmericaChE.MenuManager = Me
            Me.NorthAmericaChE.Name = "NorthAmericaChE"
            Me.NorthAmericaChE.Properties.Caption = "North America"
            Me.NorthAmericaChE.Size = New System.Drawing.Size(179, 20)
            Me.NorthAmericaChE.StyleController = Me.layoutControl
            Me.NorthAmericaChE.TabIndex = 18
            AddHandler Me.NorthAmericaChE.CheckedChanged, New System.EventHandler(AddressOf Me.ChE_CheckedChanged)
            ' 
            ' SouthAmericaChE
            ' 
            Me.SouthAmericaChE.EditValue = True
            Me.SouthAmericaChE.Location = New System.Drawing.Point(18, 130)
            Me.SouthAmericaChE.MenuManager = Me
            Me.SouthAmericaChE.Name = "SouthAmericaChE"
            Me.SouthAmericaChE.Properties.Caption = "South America"
            Me.SouthAmericaChE.Size = New System.Drawing.Size(179, 20)
            Me.SouthAmericaChE.StyleController = Me.layoutControl
            Me.SouthAmericaChE.TabIndex = 19
            AddHandler Me.SouthAmericaChE.CheckedChanged, New System.EventHandler(AddressOf Me.ChE_CheckedChanged)
            ' 
            ' colorizerRadioGroup
            ' 
            Me.colorizerRadioGroup.Location = New System.Drawing.Point(12, 196)
            Me.colorizerRadioGroup.MenuManager = Me
            Me.colorizerRadioGroup.Name = "colorizerRadioGroup"
            Me.colorizerRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.colorizerRadioGroup.Properties.Appearance.Options.UseBackColor = True
            Me.colorizerRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.colorizerRadioGroup.Properties.Columns = 1
            Me.colorizerRadioGroup.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Column
            Me.colorizerRadioGroup.Size = New System.Drawing.Size(185, 30)
            Me.colorizerRadioGroup.StyleController = Me.layoutControl
            Me.colorizerRadioGroup.TabIndex = 20
            AddHandler Me.colorizerRadioGroup.SelectedIndexChanged, New System.EventHandler(AddressOf Me.colorizerRadioGroup_SelectedIndexChanged)
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.AustraliaChE
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(183, 24)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.EuropeChE
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(183, 24)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.NorthAmericaChE
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(183, 24)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.SouthAmericaChE
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 96)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(183, 24)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlGroupTotalLabels1
            ' 
            Me.layoutControlGroupTotalLabels1.CustomizationFormText = "Colorizer"
            Me.layoutControlGroupTotalLabels1.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupTotalLabels1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem5})
            Me.layoutControlGroupTotalLabels1.Location = New System.Drawing.Point(0, 162)
            Me.layoutControlGroupTotalLabels1.Name = "layoutControlGroupTotalLabels1"
            Me.layoutControlGroupTotalLabels1.Size = New System.Drawing.Size(209, 76)
            Me.layoutControlGroupTotalLabels1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupTotalLabels1.Text = "Colorizer"
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.colorizerRadioGroup
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(189, 34)
            Me.layoutControlItem5.Text = "Colorizer:"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlGroupTotalLabels2
            ' 
            Me.layoutControlGroupTotalLabels2.CustomizationFormText = "Resolve Overlapping"
            Me.layoutControlGroupTotalLabels2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupTotalLabels2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem6})
            Me.layoutControlGroupTotalLabels2.Location = New System.Drawing.Point(0, 238)
            Me.layoutControlGroupTotalLabels2.Name = "layoutControlGroupTotalLabels2"
            Me.layoutControlGroupTotalLabels2.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 10, 10, 10)
            Me.layoutControlGroupTotalLabels2.Size = New System.Drawing.Size(209, 66)
            Me.layoutControlGroupTotalLabels2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupTotalLabels2.Text = "Resolve Overlapping"
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.resolveOverlappingChE
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(183, 24)
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' emptySpaceItemBottom
            ' 
            Me.emptySpaceItemBottom.AllowHotTrack = False
            Me.emptySpaceItemBottom.Location = New System.Drawing.Point(0, 386)
            Me.emptySpaceItemBottom.Name = "emptySpaceItem1"
            Me.emptySpaceItemBottom.Size = New System.Drawing.Size(209, 152)
            Me.emptySpaceItemBottom.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlGroupTotalLabels3
            ' 
            Me.layoutControlGroupTotalLabels3.CustomizationFormText = "Node Alignment"
            Me.layoutControlGroupTotalLabels3.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupTotalLabels3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem7})
            Me.layoutControlGroupTotalLabels3.Location = New System.Drawing.Point(0, 304)
            Me.layoutControlGroupTotalLabels3.Name = "layoutControlGroupTotalLabels3"
            Me.layoutControlGroupTotalLabels3.OptionsItemText.TextToControlDistance = 3
            Me.layoutControlGroupTotalLabels3.Size = New System.Drawing.Size(209, 82)
            Me.layoutControlGroupTotalLabels3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupTotalLabels3.Text = "Node Alignment"
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.nodeAlignmentRadioGroup
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(189, 40)
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' Colorizer
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.Controls.Add(Me.sankeyDiagramControl1)
            Me.Name = "Colorizer"
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.Controls.SetChildIndex(Me.sankeyDiagramControl1, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupTotalLabels), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemTotalLabelVisible), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.AsiaChE.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.nodeAlignmentRadioGroup.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.resolveOverlappingChE.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.AustraliaChE.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.EuropeChE.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.NorthAmericaChE.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.SouthAmericaChE.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.colorizerRadioGroup.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupTotalLabels1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupTotalLabels2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItemBottom), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupTotalLabels3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private toolTipController1 As DevExpress.Utils.ToolTipController

        Private sankeyDiagramControl1 As DevExpress.XtraCharts.Sankey.SankeyDiagramControl

        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private AsiaChE As DevExpress.XtraEditors.CheckEdit

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroupTotalLabels As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemTotalLabelVisible As DevExpress.XtraLayout.LayoutControlItem

        Private AustraliaChE As DevExpress.XtraEditors.CheckEdit

        Private EuropeChE As DevExpress.XtraEditors.CheckEdit

        Private NorthAmericaChE As DevExpress.XtraEditors.CheckEdit

        Private SouthAmericaChE As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroupTotalLabels1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroupTotalLabels2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private colorizerRadioGroup As DevExpress.XtraEditors.RadioGroup

        Private emptySpaceItemBottom As DevExpress.XtraLayout.EmptySpaceItem

        Private resolveOverlappingChE As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroupTotalLabels3 As DevExpress.XtraLayout.LayoutControlGroup

        Private nodeAlignmentRadioGroup As DevExpress.XtraEditors.RadioGroup

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
