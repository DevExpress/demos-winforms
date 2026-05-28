Namespace DevExpress.XtraMap.Demos

    Partial Class ShapeSimplifierDemo

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

            Me.isActive = False
            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim trackBarLabel3 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel4 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.vectorItemsLayer1 = New DevExpress.XtraMap.VectorItemsLayer()
            Me.shapefileDataAdapter1 = New DevExpress.XtraMap.ShapefileDataAdapter()
            Me.vectorItemsLayer2 = New DevExpress.XtraMap.VectorItemsLayer()
            Me.mapItemStorage1 = New DevExpress.XtraMap.MapItemStorage()
            Me.vectorItemsLayer3 = New DevExpress.XtraMap.VectorItemsLayer()
            Me.mapItemStorage2 = New DevExpress.XtraMap.MapItemStorage()
            Me.timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.sidePanelOptions = New DevExpress.XtraEditors.SidePanel()
            Me.tabPaneOptions = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPageOptions = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.mfTrackBarControl = New DevExpress.XtraEditors.TrackBarControl()
            Me.shapeTypeRadioGroup = New DevExpress.XtraEditors.RadioGroup()
            Me.ceAutoMode = New DevExpress.XtraEditors.CheckEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.mfTrackBarControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mfTrackBarControl.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.shapeTypeRadioGroup.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceAutoMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.MaxItemId = 8
            ' 
            ' 
            ' 
            Me.ribbonControl1.SearchEditItem.AccessibleName = "Search Item"
            Me.ribbonControl1.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
            Me.ribbonControl1.SearchEditItem.EditWidth = 150
            Me.ribbonControl1.SearchEditItem.Id = -5000
            Me.ribbonControl1.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
            Me.ribbonControl1.Size = New System.Drawing.Size(733, 150)
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl1.Layers.Add(Me.vectorItemsLayer1)
            Me.mapControl1.Layers.Add(Me.vectorItemsLayer2)
            Me.mapControl1.Layers.Add(Me.vectorItemsLayer3)
            Me.mapControl1.Location = New System.Drawing.Point(0, 150)
            Me.mapControl1.MapEditor.AllowSaveActions = False
            Me.mapControl1.Margin = New System.Windows.Forms.Padding(0)
            Me.mapControl1.MaxZoomLevel = 12R
            Me.mapControl1.MinZoomLevel = 5R
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.NavigationPanelOptions.Height = 60
            Me.mapControl1.NavigationPanelOptions.ShowCoordinates = False
            Me.mapControl1.NavigationPanelOptions.ShowKilometersScale = False
            Me.mapControl1.NavigationPanelOptions.ShowMilesScale = False
            Me.mapControl1.NavigationPanelOptions.ShowScrollButtons = False
            Me.mapControl1.SelectionMode = DevExpress.XtraMap.ElementSelectionMode.[Single]
            Me.mapControl1.Size = New System.Drawing.Size(523, 350)
            Me.mapControl1.TabIndex = 1
            Me.mapControl1.ZoomLevel = 5R
            Me.vectorItemsLayer1.Data = Me.shapefileDataAdapter1
            Me.vectorItemsLayer1.EnableHighlighting = False
            Me.vectorItemsLayer1.EnableSelection = False
            AddHandler Me.vectorItemsLayer1.DataLoaded, New DevExpress.XtraMap.DataLoadedEventHandler(AddressOf Me.OnDataLoaded)
            AddHandler Me.shapefileDataAdapter1.ItemsLoaded, New DevExpress.XtraMap.ItemsLoadedEventHandler(AddressOf Me.OnItemsLoaded)
            Me.vectorItemsLayer2.Data = Me.mapItemStorage1
            Me.vectorItemsLayer2.EnableHighlighting = False
            Me.vectorItemsLayer2.EnableSelection = False
            Me.vectorItemsLayer2.ItemStyle.StrokeWidth = 3
            Me.vectorItemsLayer2.Visible = False
            Me.vectorItemsLayer3.Data = Me.mapItemStorage2
            Me.vectorItemsLayer3.EnableHighlighting = False
            Me.vectorItemsLayer3.EnableSelection = False
            Me.vectorItemsLayer3.ItemStyle.Stroke = System.Drawing.Color.FromArgb((CInt(((CByte((150)))))), (CInt(((CByte((250)))))), (CInt(((CByte((125)))))), (CInt(((CByte((0)))))))
            ' 
            ' timer1
            ' 
            Me.timer1.Interval = 40
            AddHandler Me.timer1.Tick, New System.EventHandler(AddressOf Me.OnTimerTick)
            ' 
            ' sidePanelOptions
            ' 
            Me.sidePanelOptions.AllowResize = False
            Me.sidePanelOptions.Controls.Add(Me.tabPaneOptions)
            Me.sidePanelOptions.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanelOptions.Location = New System.Drawing.Point(523, 150)
            Me.sidePanelOptions.Name = "sidePanelOptions"
            Me.sidePanelOptions.Size = New System.Drawing.Size(210, 350)
            Me.sidePanelOptions.TabIndex = 6
            ' 
            ' tabPaneOptions
            ' 
            Me.tabPaneOptions.Controls.Add(Me.tabNavigationPageOptions)
            Me.tabPaneOptions.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPaneOptions.Location = New System.Drawing.Point(1, 0)
            Me.tabPaneOptions.Name = "tabPaneOptions"
            Me.tabPaneOptions.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPageOptions})
            Me.tabPaneOptions.RegularSize = New System.Drawing.Size(209, 350)
            Me.tabPaneOptions.SelectedPage = Me.tabNavigationPageOptions
            Me.tabPaneOptions.Size = New System.Drawing.Size(209, 350)
            Me.tabPaneOptions.TabIndex = 0
            Me.tabPaneOptions.Text = "tabPane1"
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.BackgroundPadding = New System.Windows.Forms.Padding(0)
            Me.tabNavigationPageOptions.Caption = "Options"
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPageOptions.Name = "tabNavigationPageOptions"
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(209, 317)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.mfTrackBarControl)
            Me.layoutControl1.Controls.Add(Me.shapeTypeRadioGroup)
            Me.layoutControl1.Controls.Add(Me.ceAutoMode)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Margin = New System.Windows.Forms.Padding(0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(393, 24, 865, 812)
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(209, 317)
            Me.layoutControl1.TabIndex = 5
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' mfTrackBarControl
            ' 
            Me.mfTrackBarControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.mfTrackBarControl.EditValue = Nothing
            Me.mfTrackBarControl.Location = New System.Drawing.Point(9, 32)
            Me.mfTrackBarControl.MenuManager = Me
            Me.mfTrackBarControl.Name = "mfTrackBarControl"
            Me.mfTrackBarControl.Properties.AutoSize = False
            Me.mfTrackBarControl.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.mfTrackBarControl.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            trackBarLabel3.Label = "0"
            trackBarLabel4.Label = "100"
            trackBarLabel4.Value = 280
            Me.mfTrackBarControl.Properties.Labels.AddRange(New DevExpress.XtraEditors.Repository.TrackBarLabel() {trackBarLabel3, trackBarLabel4})
            Me.mfTrackBarControl.Properties.Maximum = 280
            Me.mfTrackBarControl.Properties.ShowLabels = True
            Me.mfTrackBarControl.Properties.TickStyle = System.Windows.Forms.TickStyle.None
            Me.mfTrackBarControl.Size = New System.Drawing.Size(190, 44)
            Me.mfTrackBarControl.StyleController = Me.layoutControl1
            Me.mfTrackBarControl.TabIndex = 2
            AddHandler Me.mfTrackBarControl.ValueChanged, New System.EventHandler(AddressOf Me.OnTrackBarControlValueChanged)
            ' 
            ' shapeTypeRadioGroup
            ' 
            Me.shapeTypeRadioGroup.AutoSizeInLayoutControl = True
            Me.shapeTypeRadioGroup.Location = New System.Drawing.Point(8, 140)
            Me.shapeTypeRadioGroup.MenuManager = Me
            Me.shapeTypeRadioGroup.Name = "shapeTypeRadioGroup"
            Me.shapeTypeRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.shapeTypeRadioGroup.Properties.Appearance.Options.UseBackColor = True
            Me.shapeTypeRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.shapeTypeRadioGroup.Properties.Columns = 2
            Me.shapeTypeRadioGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Polygon"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Polyline")})
            Me.shapeTypeRadioGroup.Properties.Padding = New System.Windows.Forms.Padding(0)
            AddHandler Me.shapeTypeRadioGroup.Properties.SelectedIndexChanged, New System.EventHandler(AddressOf Me.ShapeTypeSelectedIndexChanged)
            Me.shapeTypeRadioGroup.Size = New System.Drawing.Size(193, 24)
            Me.shapeTypeRadioGroup.StyleController = Me.layoutControl1
            Me.shapeTypeRadioGroup.TabIndex = 4
            ' 
            ' ceAutoMode
            ' 
            Me.ceAutoMode.EditValue = True
            Me.ceAutoMode.Location = New System.Drawing.Point(9, 80)
            Me.ceAutoMode.MenuManager = Me
            Me.ceAutoMode.Name = "ceAutoMode"
            Me.ceAutoMode.Properties.Caption = "Auto"
            Me.ceAutoMode.Size = New System.Drawing.Size(191, 20)
            Me.ceAutoMode.StyleController = Me.layoutControl1
            Me.ceAutoMode.TabIndex = 6
            AddHandler Me.ceAutoMode.CheckedChanged, New System.EventHandler(AddressOf Me.OnCheckedChanged)
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlGroup1, Me.layoutControlGroup2})
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.Root.Size = New System.Drawing.Size(209, 317)
            Me.Root.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 172)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.emptySpaceItem1.Size = New System.Drawing.Size(209, 145)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem4})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 110)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(209, 62)
            Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Text = "Shape Type"
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.ContentVertAlignment = DevExpress.Utils.VertAlignment.Top
            Me.layoutControlItem4.Control = Me.shapeTypeRadioGroup
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem4.Size = New System.Drawing.Size(193, 24)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8)
            Me.layoutControlGroup2.Size = New System.Drawing.Size(209, 110)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "Tolerance"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.layoutControlItem2.Control = Me.mfTrackBarControl
            Me.layoutControlItem2.Enabled = False
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.MaxSize = New System.Drawing.Size(192, 48)
            Me.layoutControlItem2.MinSize = New System.Drawing.Size(192, 48)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(193, 48)
            Me.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.ceAutoMode
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(193, 24)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' ShapeSimplifierDemo
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.mapControl1)
            Me.Controls.Add(Me.sidePanelOptions)
            Me.Name = "ShapeSimplifierDemo"
            Me.Size = New System.Drawing.Size(733, 500)
            Me.Controls.SetChildIndex(Me.ribbonControl1, 0)
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.Controls.SetChildIndex(Me.mapControl1, 0)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.mfTrackBarControl.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mfTrackBarControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.shapeTypeRadioGroup.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceAutoMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private mapControl1 As DevExpress.XtraMap.MapControl

        Private vectorItemsLayer1 As DevExpress.XtraMap.VectorItemsLayer

        Private timer1 As System.Windows.Forms.Timer

        Private vectorItemsLayer2 As DevExpress.XtraMap.VectorItemsLayer

        Private mapItemStorage1 As DevExpress.XtraMap.MapItemStorage

        Protected sidePanelOptions As DevExpress.XtraEditors.SidePanel

        Protected tabPaneOptions As DevExpress.XtraBars.Navigation.TabPane

        Protected tabNavigationPageOptions As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private mfTrackBarControl As DevExpress.XtraEditors.TrackBarControl

        Private shapeTypeRadioGroup As DevExpress.XtraEditors.RadioGroup

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private ceAutoMode As DevExpress.XtraEditors.CheckEdit

        Private shapefileDataAdapter1 As DevExpress.XtraMap.ShapefileDataAdapter

        Private vectorItemsLayer3 As DevExpress.XtraMap.VectorItemsLayer

        Private mapItemStorage2 As DevExpress.XtraMap.MapItemStorage

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
