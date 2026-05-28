Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.XtraMap.Demos

    Partial Class MapProjections

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
            Dim mapCustomElement1 As DevExpress.XtraMap.MapCustomElement = New DevExpress.XtraMap.MapCustomElement()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraMap.Demos.MapProjections))
            Dim mapPolygon1 As DevExpress.XtraMap.MapPolygon = New DevExpress.XtraMap.MapPolygon()
            Dim mapCustomElement2 As DevExpress.XtraMap.MapCustomElement = New DevExpress.XtraMap.MapCustomElement()
            Me.FileLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.ShapefileDataAdapter = New DevExpress.XtraMap.ShapefileDataAdapter()
            Me.ItemsLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.Data = New DevExpress.XtraMap.MapItemStorage()
            Me.btnCurrent = New DevExpress.XtraBars.BarButtonItem()
            Me.barEditCalendar = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.chkSteadily = New DevExpress.XtraBars.BarCheckItem()
            Me.btnMinus = New DevExpress.XtraBars.BarButtonItem()
            Me.btnPlus = New DevExpress.XtraBars.BarButtonItem()
            Me.barStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
            Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.repositoryItemTrackBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemTrackBar()
            Me.repositoryItemTimeEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
            Me.repositoryItemPopupContainerEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
            Me.repositoryItemRadioGroup1 = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
            Me.repositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.repositoryItemComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.chkPlay = New DevExpress.XtraBars.BarCheckItem()
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
            Me.sidePanel2 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPaneOptions = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPageOptions = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.projectionsList = New DevExpress.XtraTreeList.TreeList()
            Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanelMain = New DevExpress.XtraEditors.SidePanel()
            Me.sidePanel3 = New DevExpress.XtraEditors.SidePanel()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.GridLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.GridData = New DevExpress.XtraMap.MapItemStorage()
            Me.timer = New System.Windows.Forms.Timer(Me.components)
            Me.ribbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ShowGridBarCheckItem = New DevExpress.XtraBars.BarCheckItem()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemDateEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemDateEdit1.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTrackBar1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTimeEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemPopupContainerEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemRadioGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemComboBox2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemComboBox3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel2.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.projectionsList), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanelMain.SuspendLayout()
            Me.sidePanel3.SuspendLayout()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.chkSteadily, Me.btnMinus, Me.btnPlus, Me.barEditCalendar, Me.btnCurrent, Me.ShowGridBarCheckItem})
            Me.ribbonControl1.MaxItemId = 9
            ' 
            ' 
            ' 
            Me.ribbonControl1.SearchEditItem.AccessibleName = "Search Item"
            Me.ribbonControl1.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
            Me.ribbonControl1.SearchEditItem.EditWidth = 150
            Me.ribbonControl1.SearchEditItem.Id = -5000
            Me.ribbonControl1.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
            ' 
            ' rpOptions
            ' 
            Me.rpOptions.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup2, Me.ribbonPageGroup1, Me.ribbonPageGroup3})
            Me.FileLayer.Data = Me.ShapefileDataAdapter
            Me.FileLayer.EnableHighlighting = False
            Me.FileLayer.EnableSelection = False
            Me.FileLayer.ItemStyle.Fill = System.Drawing.Color.FromArgb((CInt(((CByte((125)))))), (CInt(((CByte((211)))))), (CInt(((CByte((236)))))))
            Me.FileLayer.ItemStyle.Stroke = System.Drawing.Color.Transparent
            Me.FileLayer.ItemStyle.StrokeWidth = 0
            Me.FileLayer.Name = "FileLayer"
            Me.FileLayer.ShapeTitlesPattern = ""
            AddHandler Me.FileLayer.DataLoaded, New DevExpress.XtraMap.DataLoadedEventHandler(AddressOf Me.DayAndNight_DataLoaded)
            Me.ItemsLayer.Data = Me.Data
            Me.ItemsLayer.EnableHighlighting = False
            Me.ItemsLayer.EnableSelection = False
            Me.ItemsLayer.Name = "ItemsLayer"
            mapCustomElement1.Image = CType((resources.GetObject("mapCustomElement1.Image")), System.Drawing.Image)
            mapCustomElement1.UseAnimation = False
            mapPolygon1.Fill = System.Drawing.Color.FromArgb((CInt(((CByte((64)))))), (CInt(((CByte((11)))))), (CInt(((CByte((0)))))), (CInt(((CByte((66)))))))
            mapPolygon1.Stroke = System.Drawing.Color.Transparent
            mapPolygon1.StrokeWidth = 0
            mapCustomElement2.Image = CType((resources.GetObject("mapCustomElement2.Image")), System.Drawing.Image)
            mapCustomElement2.UseAnimation = False
            Me.Data.Items.Add(mapCustomElement1)
            Me.Data.Items.Add(mapPolygon1)
            Me.Data.Items.Add(mapCustomElement2)
            ' 
            ' btnCurrent
            ' 
            Me.btnCurrent.Caption = "Current Time"
            Me.btnCurrent.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.btnCurrent.Id = 6
            Me.btnCurrent.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.CurrentTime
            Me.btnCurrent.Name = "btnCurrent"
            AddHandler Me.btnCurrent.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.btnCurrent_ItemClick)
            ' 
            ' barEditCalendar
            ' 
            Me.barEditCalendar.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.barEditCalendar.Edit = Me.repositoryItemDateEdit1
            Me.barEditCalendar.EditWidth = 150
            Me.barEditCalendar.Id = 24
            Me.barEditCalendar.Name = "barEditCalendar"
            AddHandler Me.barEditCalendar.EditValueChanged, New System.EventHandler(AddressOf Me.barEditItem2_EditValueChanged)
            ' 
            ' repositoryItemDateEdit1
            ' 
            Me.repositoryItemDateEdit1.AutoHeight = False
            Me.repositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemDateEdit1.Mask.EditMask = "G"
            Me.repositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat = True
            Me.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1"
            ' 
            ' chkSteadily
            ' 
            Me.chkSteadily.Caption = "Steadily"
            Me.chkSteadily.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.chkSteadily.Id = 30
            Me.chkSteadily.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.Time
            Me.chkSteadily.Name = "chkSteadily"
            AddHandler Me.chkSteadily.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.chkSteadily_CheckedChanged)
            ' 
            ' btnMinus
            ' 
            Me.btnMinus.Caption = "Backward"
            Me.btnMinus.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.btnMinus.Id = 31
            Me.btnMinus.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.Backward
            Me.btnMinus.Name = "btnMinus"
            AddHandler Me.btnMinus.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.btnMinus_ItemClick)
            ' 
            ' btnPlus
            ' 
            Me.btnPlus.Caption = "Forward"
            Me.btnPlus.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.btnPlus.Id = 32
            Me.btnPlus.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.Forward
            Me.btnPlus.Name = "btnPlus"
            AddHandler Me.btnPlus.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.btnPlus_ItemClick)
            ' 
            ' barStaticItem1
            ' 
            Me.barStaticItem1.Caption = "Custom Time"
            Me.barStaticItem1.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.barStaticItem1.Id = 46
            Me.barStaticItem1.Name = "barStaticItem1"
            ' 
            ' ribbonPageGroup2
            ' 
            Me.ribbonPageGroup2.ItemLinks.Add(Me.chkSteadily)
            Me.ribbonPageGroup2.ItemLinks.Add(Me.btnMinus)
            Me.ribbonPageGroup2.ItemLinks.Add(Me.btnPlus)
            Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
            Me.ribbonPageGroup2.Text = "Interactivity"
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barEditCalendar)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.btnCurrent)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "Set Date and Time"
            ' 
            ' repositoryItemTrackBar1
            ' 
            Me.repositoryItemTrackBar1.LabelAppearance.Options.UseTextOptions = True
            Me.repositoryItemTrackBar1.LargeChange = 24
            Me.repositoryItemTrackBar1.Maximum = 8760
            Me.repositoryItemTrackBar1.Name = "repositoryItemTrackBar1"
            ' 
            ' repositoryItemTimeEdit1
            ' 
            Me.repositoryItemTimeEdit1.AutoHeight = False
            Me.repositoryItemTimeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1"
            ' 
            ' repositoryItemPopupContainerEdit1
            ' 
            Me.repositoryItemPopupContainerEdit1.AutoHeight = False
            Me.repositoryItemPopupContainerEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemPopupContainerEdit1.Name = "repositoryItemPopupContainerEdit1"
            ' 
            ' repositoryItemRadioGroup1
            ' 
            Me.repositoryItemRadioGroup1.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "1"), New DevExpress.XtraEditors.Controls.RadioGroupItem(25, "25")})
            Me.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1"
            ' 
            ' repositoryItemComboBox2
            ' 
            Me.repositoryItemComboBox2.AutoHeight = False
            Me.repositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemComboBox2.Items.AddRange(New Object() {"1", "25"})
            Me.repositoryItemComboBox2.Name = "repositoryItemComboBox2"
            ' 
            ' repositoryItemComboBox3
            ' 
            Me.repositoryItemComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemComboBox3.Items.AddRange(New Object() {"1", "25"})
            Me.repositoryItemComboBox3.Name = "repositoryItemComboBox3"
            Me.repositoryItemComboBox3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            ' 
            ' chkPlay
            ' 
            Me.chkPlay.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.chkPlay.Id = 9
            Me.chkPlay.Name = "chkPlay"
            ' 
            ' barButtonItem1
            ' 
            Me.barButtonItem1.Caption = "-1"
            Me.barButtonItem1.Name = "barButtonItem1"
            ' 
            ' barButtonItem2
            ' 
            Me.barButtonItem2.Caption = "+1"
            Me.barButtonItem2.Name = "barButtonItem2"
            ' 
            ' sidePanel2
            ' 
            Me.sidePanel2.AllowResize = False
            Me.sidePanel2.AllowSnap = False
            Me.sidePanel2.Controls.Add(Me.tabPaneOptions)
            Me.sidePanel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel2.Location = New System.Drawing.Point(300, 0)
            Me.sidePanel2.Name = "sidePanel2"
            Me.sidePanel2.Size = New System.Drawing.Size(200, 350)
            Me.sidePanel2.TabIndex = 7
            Me.sidePanel2.Text = "sidePanel2"
            ' 
            ' tabPaneOptions
            ' 
            Me.tabPaneOptions.Controls.Add(Me.tabNavigationPageOptions)
            Me.tabPaneOptions.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPaneOptions.Location = New System.Drawing.Point(1, 0)
            Me.tabPaneOptions.Name = "tabPaneOptions"
            Me.tabPaneOptions.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPageOptions})
            Me.tabPaneOptions.RegularSize = New System.Drawing.Size(199, 350)
            Me.tabPaneOptions.SelectedPage = Me.tabNavigationPageOptions
            Me.tabPaneOptions.Size = New System.Drawing.Size(199, 350)
            Me.tabPaneOptions.TabIndex = 1
            Me.tabPaneOptions.Text = "tabPane1"
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Caption = "Options"
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPageOptions.Name = "tabNavigationPageOptions"
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(199, 317)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.projectionsList)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(408, 359, 650, 400)
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(199, 317)
            Me.layoutControl1.TabIndex = 1
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' projectionsList
            ' 
            Me.projectionsList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.projectionsList.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.treeListColumn1})
            Me.projectionsList.FixedLineWidth = 1
            Me.projectionsList.HorzScrollStep = 2
            Me.projectionsList.KeyFieldName = "Name"
            Me.projectionsList.Location = New System.Drawing.Point(0, 22)
            Me.projectionsList.MinWidth = 16
            Me.projectionsList.Name = "projectionsList"
            Me.projectionsList.OptionsBehavior.Editable = False
            Me.projectionsList.OptionsBehavior.[ReadOnly] = True
            Me.projectionsList.OptionsView.ShowIndentAsRowStyle = True
            Me.projectionsList.ParentFieldName = "ParentPrjName"
            Me.projectionsList.Size = New System.Drawing.Size(199, 295)
            Me.projectionsList.TabIndex = 0
            Me.projectionsList.TreeLevelWidth = 13
            Me.projectionsList.ViewStyle = DevExpress.XtraTreeList.TreeListViewStyle.TreeView
            AddHandler Me.projectionsList.FocusedNodeChanged, New DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(AddressOf Me.OnProjectionsListFocusedNodeChanged)
            ' 
            ' treeListColumn1
            ' 
            Me.treeListColumn1.Caption = "treeListColumn1"
            Me.treeListColumn1.FieldName = "Name"
            Me.treeListColumn1.MinWidth = 16
            Me.treeListColumn1.Name = "treeListColumn1"
            Me.treeListColumn1.Visible = True
            Me.treeListColumn1.VisibleIndex = 0
            Me.treeListColumn1.Width = 56
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.Root.Size = New System.Drawing.Size(199, 317)
            Me.Root.Text = "Projection"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.projectionsList
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(199, 295)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' sidePanelMain
            ' 
            Me.sidePanelMain.AllowResize = False
            Me.sidePanelMain.AllowSnap = False
            Me.sidePanelMain.Controls.Add(Me.sidePanel3)
            Me.sidePanelMain.Controls.Add(Me.sidePanel2)
            Me.sidePanelMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sidePanelMain.Location = New System.Drawing.Point(0, 150)
            Me.sidePanelMain.Name = "sidePanelMain"
            Me.sidePanelMain.Size = New System.Drawing.Size(500, 350)
            Me.sidePanelMain.TabIndex = 6
            Me.sidePanelMain.Text = "sidePanel1"
            ' 
            ' sidePanel3
            ' 
            Me.sidePanel3.Controls.Add(Me.mapControl1)
            Me.sidePanel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sidePanel3.Location = New System.Drawing.Point(0, 0)
            Me.sidePanel3.Name = "sidePanel3"
            Me.sidePanel3.Size = New System.Drawing.Size(300, 350)
            Me.sidePanel3.TabIndex = 0
            Me.sidePanel3.Text = "sidePanel3"
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((47)))))), (CInt(((CByte((173)))))), (CInt(((CByte((213)))))))
            Me.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl1.Layers.Add(Me.FileLayer)
            Me.mapControl1.Layers.Add(Me.ItemsLayer)
            Me.mapControl1.Layers.Add(Me.GridLayer)
            Me.mapControl1.Location = New System.Drawing.Point(0, 0)
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.NavigationPanelOptions.ShowZoomTrackbar = False
            Me.mapControl1.NavigationPanelOptions.Visible = False
            Me.mapControl1.Size = New System.Drawing.Size(300, 350)
            Me.mapControl1.TabIndex = 5
            Me.GridLayer.Data = Me.GridData
            Me.GridLayer.Name = "GridLayer"
            ' 
            ' timer
            ' 
            AddHandler Me.timer.Tick, New System.EventHandler(AddressOf Me.OnTimerTick)
            ' 
            ' ribbonPageGroup3
            ' 
            Me.ribbonPageGroup3.ItemLinks.Add(Me.ShowGridBarCheckItem)
            Me.ribbonPageGroup3.Name = "ribbonPageGroup3"
            ' 
            ' ShowGridBarCheckItem
            ' 
            Me.ShowGridBarCheckItem.BindableChecked = True
            Me.ShowGridBarCheckItem.Caption = "Show Grid"
            Me.ShowGridBarCheckItem.Checked = True
            Me.ShowGridBarCheckItem.Id = 8
            Me.ShowGridBarCheckItem.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.ShowGrid
            Me.ShowGridBarCheckItem.Name = "ShowGridBarCheckItem"
            AddHandler Me.ShowGridBarCheckItem.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnShowGridCheckedChanged)
            ' 
            ' MapProjections
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.sidePanelMain)
            Me.Name = "MapProjections"
            Me.Controls.SetChildIndex(Me.ribbonControl1, 0)
            Me.Controls.SetChildIndex(Me.sidePanelMain, 0)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemDateEdit1.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemDateEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTrackBar1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTimeEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemPopupContainerEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemRadioGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemComboBox2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemComboBox3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel2.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.projectionsList), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanelMain.ResumeLayout(False)
            Me.sidePanel3.ResumeLayout(False)
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private repositoryItemTrackBar1 As DevExpress.XtraEditors.Repository.RepositoryItemTrackBar

        Private btnCurrent As DevExpress.XtraBars.BarButtonItem

        Private chkPlay As DevExpress.XtraBars.BarCheckItem

        Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem

        Private barEditCalendar As DevExpress.XtraBars.BarEditItem

        Private repositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit

        Private repositoryItemTimeEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit

        Private chkSteadily As DevExpress.XtraBars.BarCheckItem

        Private btnMinus As DevExpress.XtraBars.BarButtonItem

        Private btnPlus As DevExpress.XtraBars.BarButtonItem

        Private repositoryItemPopupContainerEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit

        Private mapControl1 As DevExpress.XtraMap.MapControl

        Private projectionsList As DevExpress.XtraTreeList.TreeList

        Private barStaticItem1 As DevExpress.XtraBars.BarStaticItem

        Private repositoryItemRadioGroup1 As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup

        Private repositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox

        Private repositoryItemComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox

        Private tabPaneOptions As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPageOptions As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private timer As System.Windows.Forms.Timer

        Private FileLayer As DevExpress.XtraMap.VectorItemsLayer

        Private ShapefileDataAdapter As DevExpress.XtraMap.ShapefileDataAdapter

        Private ItemsLayer As DevExpress.XtraMap.VectorItemsLayer

        Private Data As DevExpress.XtraMap.MapItemStorage

        Private sidePanel2 As DevExpress.XtraEditors.SidePanel

        Private sidePanelMain As DevExpress.XtraEditors.SidePanel

        Private sidePanel3 As DevExpress.XtraEditors.SidePanel

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private ribbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private ribbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private GridLayer As DevExpress.XtraMap.VectorItemsLayer

        Private GridData As DevExpress.XtraMap.MapItemStorage

        Private ShowGridBarCheckItem As DevExpress.XtraBars.BarCheckItem
    End Class
End Namespace
