Namespace DevExpress.XtraCharts.Demos

    Partial Class SeriesPointMovingDemo

        Private components As System.ComponentModel.IContainer = Nothing

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
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim xyDiagramPane1 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane()
            Dim secondaryAxisY1 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
            Dim secondaryAxisY2 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
            Dim legend1 As DevExpress.XtraCharts.Legend = New DevExpress.XtraCharts.Legend()
            Dim legend2 As DevExpress.XtraCharts.Legend = New DevExpress.XtraCharts.Legend()
            Dim customLegendItem1 As DevExpress.XtraCharts.CustomLegendItem = New DevExpress.XtraCharts.CustomLegendItem()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim dataSourceAdapter1 As DevExpress.XtraCharts.DataSourceAdapter = New DevExpress.XtraCharts.DataSourceAdapter()
            Dim dataMember1 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember2 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim splineAreaSeriesView1 As DevExpress.XtraCharts.SplineAreaSeriesView = New DevExpress.XtraCharts.SplineAreaSeriesView()
            Dim series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim dataSourceAdapter2 As DevExpress.XtraCharts.DataSourceAdapter = New DevExpress.XtraCharts.DataSourceAdapter()
            Dim dataMember3 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember4 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim pointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
            Dim lineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim dataSourceAdapter3 As DevExpress.XtraCharts.DataSourceAdapter = New DevExpress.XtraCharts.DataSourceAdapter()
            Dim dataMember5 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember6 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim sideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim sideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
            Dim series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim dataSourceAdapter4 As DevExpress.XtraCharts.DataSourceAdapter = New DevExpress.XtraCharts.DataSourceAdapter()
            Dim dataMember7 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember8 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim pointSeriesLabel2 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
            Dim lineSeriesView2 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim series5 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim dataSourceAdapter5 As DevExpress.XtraCharts.DataSourceAdapter = New DevExpress.XtraCharts.DataSourceAdapter()
            Dim dataMember9 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember10 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim pointSeriesLabel3 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
            Dim lineSeriesView3 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim lineSeriesView4 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.dockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.toolTipController = New DevExpress.Utils.ToolTipController(Me.components)
            Me.dockPanel6 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel6_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.documentManager = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            Me.noDocumentsView1 = New DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView(Me.components)
            Me.currentTabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.checkEditLabelVisible = New DevExpress.XtraEditors.CheckEdit()
            Me.spinEditLabelAngle = New DevExpress.XtraEditors.SpinEdit()
            Me.checkEditValueAsPercent = New DevExpress.XtraEditors.CheckEdit()
            Me.spinEditMarkerSize = New DevExpress.XtraEditors.SpinEdit()
            Me.checkEditMarkerVisible = New DevExpress.XtraEditors.CheckEdit()
            Me.spinEditLineTension = New DevExpress.XtraEditors.SpinEdit()
            Me.comboBoxEditFunction = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroupLabel = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemLabelVisible = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemAngle = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemValueAsPercent = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupMarker = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemMarkerSize = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemMarkerVisible = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupGeneral = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemLineTension = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemFunction = New DevExpress.XtraLayout.LayoutControlItem()
            Me.flyoutPanel1 = New DevExpress.Utils.FlyoutPanel()
            Me.button1 = New System.Windows.Forms.Button()
            Me.label1 = New System.Windows.Forms.Label()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            CType((Me.dockManager), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanel6.SuspendLayout()
            CType((Me.documentManager), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.noDocumentsView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.currentTabbedView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.checkEditLabelVisible.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditLabelAngle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditValueAsPercent.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditMarkerSize.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditMarkerVisible.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditLineTension.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditFunction.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemLabelVisible), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemAngle), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemValueAsPercent), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupMarker), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemMarkerSize), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemMarkerVisible), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupGeneral), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemLineTension), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemFunction), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.flyoutPanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.flyoutPanel1.SuspendLayout()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagramPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisY1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisY2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((splineAreaSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesLabel2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesLabel3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView4), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' dockManager
            ' 
            Me.dockManager.DockingOptions.FloatOnDblClick = False
            Me.dockManager.DockingOptions.ShowCloseButton = False
            Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
            ' 
            ' toolTipController
            ' 
            Me.toolTipController.InitialDelay = 10
            ' 
            ' dockPanel6
            ' 
            Me.dockPanel6.Controls.Add(Me.dockPanel6_Container)
            Me.dockPanel6.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanel6.DockedAsTabbedDocument = True
            Me.dockPanel6.ID = New System.Guid("2803d6da-c187-44bc-9ff9-42e5a317b047")
            Me.dockPanel6.Location = New System.Drawing.Point(-32768, -32768)
            Me.dockPanel6.Name = "dockPanel6"
            Me.dockPanel6.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanel6.SavedIndex = 5
            Me.dockPanel6.SavedMdiDocument = True
            Me.dockPanel6.Size = New System.Drawing.Size(786, 547)
            Me.dockPanel6.Text = "dockPanel6"
            Me.dockPanel6.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            ' 
            ' dockPanel6_Container
            ' 
            Me.dockPanel6_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel6_Container.Name = "dockPanel6_Container"
            Me.dockPanel6_Container.Size = New System.Drawing.Size(786, 547)
            Me.dockPanel6_Container.TabIndex = 0
            ' 
            ' documentManager
            ' 
            Me.documentManager.View = Me.noDocumentsView1
            Me.documentManager.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.noDocumentsView1, Me.currentTabbedView})
            ' 
            ' currentTabbedView
            ' 
            Me.currentTabbedView.DocumentGroupProperties.HeaderButtons = DevExpress.XtraTab.TabButtons.None
            Me.currentTabbedView.DocumentGroupProperties.ShowDocumentSelectorButton = False
            Me.currentTabbedView.DocumentProperties.AllowDock = False
            Me.currentTabbedView.DocumentProperties.AllowDockFill = False
            Me.currentTabbedView.DocumentProperties.AllowFloat = False
            Me.currentTabbedView.DocumentProperties.AllowFloatOnDoubleClick = False
            Me.currentTabbedView.DocumentProperties.AllowTabReordering = False
            Me.currentTabbedView.DocumentProperties.ShowInDocumentSelector = False
            Me.currentTabbedView.DocumentProperties.ShowPinButton = False
            Me.currentTabbedView.Style = DevExpress.XtraBars.Docking2010.Views.DockingViewStyle.Light
            Me.currentTabbedView.WindowsDialogProperties.NameColumnWidth = 5
            Me.currentTabbedView.WindowsDialogProperties.PathColumnWidth = 5
            Me.currentTabbedView.WindowsDialogProperties.Size = New System.Drawing.Size(400, 300)
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.checkEditLabelVisible)
            Me.layoutControl.Controls.Add(Me.spinEditLabelAngle)
            Me.layoutControl.Controls.Add(Me.checkEditValueAsPercent)
            Me.layoutControl.Controls.Add(Me.spinEditMarkerSize)
            Me.layoutControl.Controls.Add(Me.checkEditMarkerVisible)
            Me.layoutControl.Controls.Add(Me.spinEditLineTension)
            Me.layoutControl.Controls.Add(Me.comboBoxEditFunction)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(602, 135, 650, 400)
            Me.layoutControl.Root = Me.layoutControlGroupRoot
            Me.layoutControl.Size = New System.Drawing.Size(241, 542)
            Me.layoutControl.TabIndex = 0
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' checkEditLabelVisible
            ' 
            Me.checkEditLabelVisible.EditValue = True
            Me.checkEditLabelVisible.Location = New System.Drawing.Point(12, 124)
            Me.checkEditLabelVisible.Name = "checkEditLabelVisible"
            Me.checkEditLabelVisible.Properties.Caption = "Visible"
            Me.checkEditLabelVisible.Size = New System.Drawing.Size(217, 20)
            Me.checkEditLabelVisible.StyleController = Me.layoutControl
            Me.checkEditLabelVisible.TabIndex = 3
            ' 
            ' spinEditLabelAngle
            ' 
            Me.spinEditLabelAngle.EditValue = New Decimal(New Integer() {45, 0, 0, 0})
            Me.spinEditLabelAngle.Location = New System.Drawing.Point(87, 172)
            Me.spinEditLabelAngle.Name = "spinEditLabelAngle"
            Me.spinEditLabelAngle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditLabelAngle.Properties.DisplayFormat.FormatString = "0°"
            Me.spinEditLabelAngle.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEditLabelAngle.Properties.Increment = New Decimal(New Integer() {5, 0, 0, 0})
            Me.spinEditLabelAngle.Properties.IsFloatValue = False
            Me.spinEditLabelAngle.Properties.Mask.EditMask = "N00"
            Me.spinEditLabelAngle.Properties.MaxValue = New Decimal(New Integer() {360, 0, 0, 0})
            Me.spinEditLabelAngle.Size = New System.Drawing.Size(142, 20)
            Me.spinEditLabelAngle.StyleController = Me.layoutControl
            Me.spinEditLabelAngle.TabIndex = 5
            ' 
            ' checkEditValueAsPercent
            ' 
            Me.checkEditValueAsPercent.EditValue = True
            Me.checkEditValueAsPercent.Location = New System.Drawing.Point(12, 148)
            Me.checkEditValueAsPercent.Name = "checkEditValueAsPercent"
            Me.checkEditValueAsPercent.Properties.Caption = "Value As Percent"
            Me.checkEditValueAsPercent.Size = New System.Drawing.Size(217, 20)
            Me.checkEditValueAsPercent.StyleController = Me.layoutControl
            Me.checkEditValueAsPercent.TabIndex = 4
            Me.checkEditValueAsPercent.Visible = False
            ' 
            ' spinEditMarkerSize
            ' 
            Me.spinEditMarkerSize.EditValue = New Decimal(New Integer() {10, 0, 0, 0})
            Me.spinEditMarkerSize.Location = New System.Drawing.Point(87, 262)
            Me.spinEditMarkerSize.Name = "spinEditMarkerSize"
            Me.spinEditMarkerSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditMarkerSize.Properties.DisplayFormat.FormatString = "0 px"
            Me.spinEditMarkerSize.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEditMarkerSize.Properties.IsFloatValue = False
            Me.spinEditMarkerSize.Properties.Mask.EditMask = "N00"
            Me.spinEditMarkerSize.Properties.MaxValue = New Decimal(New Integer() {30, 0, 0, 0})
            Me.spinEditMarkerSize.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinEditMarkerSize.Size = New System.Drawing.Size(142, 20)
            Me.spinEditMarkerSize.StyleController = Me.layoutControl
            Me.spinEditMarkerSize.TabIndex = 7
            ' 
            ' checkEditMarkerVisible
            ' 
            Me.checkEditMarkerVisible.EditValue = True
            Me.checkEditMarkerVisible.Location = New System.Drawing.Point(12, 238)
            Me.checkEditMarkerVisible.Name = "checkEditMarkerVisible"
            Me.checkEditMarkerVisible.Properties.Caption = "Visible"
            Me.checkEditMarkerVisible.Size = New System.Drawing.Size(217, 20)
            Me.checkEditMarkerVisible.StyleController = Me.layoutControl
            Me.checkEditMarkerVisible.TabIndex = 6
            ' 
            ' spinEditLineTension
            ' 
            Me.spinEditLineTension.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinEditLineTension.Location = New System.Drawing.Point(87, 34)
            Me.spinEditLineTension.Name = "spinEditLineTension"
            Me.spinEditLineTension.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditLineTension.Properties.DisplayFormat.FormatString = "0\%"
            Me.spinEditLineTension.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEditLineTension.Properties.IsFloatValue = False
            Me.spinEditLineTension.Properties.Mask.EditMask = "N00"
            Me.spinEditLineTension.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.spinEditLineTension.Size = New System.Drawing.Size(142, 20)
            Me.spinEditLineTension.StyleController = Me.layoutControl
            Me.spinEditLineTension.TabIndex = 0
            ' 
            ' comboBoxEditFunction
            ' 
            Me.comboBoxEditFunction.EditValue = "Archimedean Spiral"
            Me.comboBoxEditFunction.Location = New System.Drawing.Point(87, 58)
            Me.comboBoxEditFunction.Name = "comboBoxEditFunction"
            Me.comboBoxEditFunction.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditFunction.Properties.Items.AddRange(New Object() {"Archimedean Spiral", "Cardioid", "Cartesian Folium"})
            Me.comboBoxEditFunction.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditFunction.Size = New System.Drawing.Size(142, 20)
            Me.comboBoxEditFunction.StyleController = Me.layoutControl
            Me.comboBoxEditFunction.TabIndex = 2
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroupLabel, Me.layoutControlGroupMarker, Me.layoutControlGroupGeneral})
            Me.layoutControlGroupRoot.Name = "Root"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(241, 542)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' layoutControlGroupLabel
            ' 
            Me.layoutControlGroupLabel.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupLabel.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupLabel.CustomizationFormText = "Label"
            Me.layoutControlGroupLabel.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupLabel.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemLabelVisible, Me.layoutControlItemAngle, Me.layoutControlItemValueAsPercent})
            Me.layoutControlGroupLabel.Location = New System.Drawing.Point(0, 90)
            Me.layoutControlGroupLabel.Name = "layoutControlGroupLabel"
            Me.layoutControlGroupLabel.Size = New System.Drawing.Size(241, 114)
            Me.layoutControlGroupLabel.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupLabel.Text = "Label"
            ' 
            ' layoutControlItemLabelVisible
            ' 
            Me.layoutControlItemLabelVisible.Control = Me.checkEditLabelVisible
            Me.layoutControlItemLabelVisible.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItemLabelVisible.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemLabelVisible.Name = "layoutControlItemLabelVisible"
            Me.layoutControlItemLabelVisible.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemLabelVisible.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemLabelVisible.TextVisible = False
            ' 
            ' layoutControlItemAngle
            ' 
            Me.layoutControlItemAngle.Control = Me.spinEditLabelAngle
            Me.layoutControlItemAngle.CustomizationFormText = "Angle:"
            Me.layoutControlItemAngle.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItemAngle.Name = "layoutControlItemAngle"
            Me.layoutControlItemAngle.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemAngle.Text = "Angle:"
            Me.layoutControlItemAngle.TextSize = New System.Drawing.Size(63, 13)
            Me.layoutControlItemAngle.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            ' 
            ' layoutControlItemValueAsPercent
            ' 
            Me.layoutControlItemValueAsPercent.Control = Me.checkEditValueAsPercent
            Me.layoutControlItemValueAsPercent.CustomizationFormText = "layoutControlItem8"
            Me.layoutControlItemValueAsPercent.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemValueAsPercent.Name = "layoutControlItemValueAsPercent"
            Me.layoutControlItemValueAsPercent.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemValueAsPercent.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItemValueAsPercent.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemValueAsPercent.TextVisible = False
            ' 
            ' layoutControlGroupMarker
            ' 
            Me.layoutControlGroupMarker.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupMarker.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupMarker.CustomizationFormText = "Marker"
            Me.layoutControlGroupMarker.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupMarker.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemMarkerSize, Me.layoutControlItemMarkerVisible})
            Me.layoutControlGroupMarker.Location = New System.Drawing.Point(0, 204)
            Me.layoutControlGroupMarker.Name = "layoutControlGroupMarker"
            Me.layoutControlGroupMarker.Size = New System.Drawing.Size(241, 338)
            Me.layoutControlGroupMarker.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupMarker.Text = "Marker"
            ' 
            ' layoutControlItemMarkerSize
            ' 
            Me.layoutControlItemMarkerSize.Control = Me.spinEditMarkerSize
            Me.layoutControlItemMarkerSize.CustomizationFormText = "Size:"
            Me.layoutControlItemMarkerSize.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemMarkerSize.Name = "layoutControlItemMarkerSize"
            Me.layoutControlItemMarkerSize.Size = New System.Drawing.Size(221, 272)
            Me.layoutControlItemMarkerSize.Text = "Size:"
            Me.layoutControlItemMarkerSize.TextSize = New System.Drawing.Size(63, 13)
            ' 
            ' layoutControlItemMarkerVisible
            ' 
            Me.layoutControlItemMarkerVisible.Control = Me.checkEditMarkerVisible
            Me.layoutControlItemMarkerVisible.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItemMarkerVisible.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemMarkerVisible.Name = "layoutControlItemMarkerVisible"
            Me.layoutControlItemMarkerVisible.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemMarkerVisible.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemMarkerVisible.TextVisible = False
            ' 
            ' layoutControlGroupGeneral
            ' 
            Me.layoutControlGroupGeneral.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupGeneral.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupGeneral.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupGeneral.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemLineTension, Me.layoutControlItemFunction})
            Me.layoutControlGroupGeneral.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupGeneral.Name = "layoutControlGroupGeneral"
            Me.layoutControlGroupGeneral.Size = New System.Drawing.Size(241, 90)
            Me.layoutControlGroupGeneral.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupGeneral.Text = "General"
            Me.layoutControlGroupGeneral.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            ' 
            ' layoutControlItemLineTension
            ' 
            Me.layoutControlItemLineTension.Control = Me.spinEditLineTension
            Me.layoutControlItemLineTension.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemLineTension.Name = "layoutControlItemLineTension"
            Me.layoutControlItemLineTension.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemLineTension.Text = "Line Tension:"
            Me.layoutControlItemLineTension.TextSize = New System.Drawing.Size(63, 13)
            ' 
            ' layoutControlItemFunction
            ' 
            Me.layoutControlItemFunction.Control = Me.comboBoxEditFunction
            Me.layoutControlItemFunction.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemFunction.Name = "layoutControlItemFunction"
            Me.layoutControlItemFunction.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemFunction.Text = "Function:"
            Me.layoutControlItemFunction.TextSize = New System.Drawing.Size(63, 13)
            ' 
            ' flyoutPanel1
            ' 
            Me.flyoutPanel1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((115)))))), (CInt(((CByte((198)))))))
            Me.flyoutPanel1.Appearance.Options.UseBackColor = True
            Me.flyoutPanel1.Controls.Add(Me.button1)
            Me.flyoutPanel1.Controls.Add(Me.label1)
            Me.flyoutPanel1.Location = New System.Drawing.Point(200, 150)
            Me.flyoutPanel1.Name = "flyoutPanel1"
            Me.flyoutPanel1.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Manual
            Me.flyoutPanel1.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade
            Me.flyoutPanel1.Options.Location = New System.Drawing.Point(200, 150)
            Me.flyoutPanel1.OptionsBeakPanel.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((115)))))), (CInt(((CByte((198)))))))
            Me.flyoutPanel1.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Bottom
            Me.flyoutPanel1.OwnerControl = Me.chart
            Me.flyoutPanel1.Size = New System.Drawing.Size(376, 80)
            Me.flyoutPanel1.TabIndex = 3
            ' 
            ' button1
            ' 
            Me.button1.FlatAppearance.BorderSize = 0
            Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button1.Font = New System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold)
            Me.button1.ForeColor = System.Drawing.Color.White
            Me.button1.Location = New System.Drawing.Point(298, 45)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(75, 31)
            Me.button1.TabIndex = 1
            Me.button1.Text = "Got It"
            Me.button1.UseVisualStyleBackColor = True
            AddHandler Me.button1.Click, New System.EventHandler(AddressOf Me.button1_Click)
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Tahoma", 12F)
            Me.label1.ForeColor = System.Drawing.Color.White
            Me.label1.Location = New System.Drawing.Point(12, 19)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(358, 19)
            Me.label1.TabIndex = 0
            Me.label1.Text = "Use the mouse or touch gestures to move points."
            ' 
            ' chart
            ' 
            Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.CrosshairOptions.HighlightPoints = False
            xyDiagram1.AxisX.Tickmarks.MinorVisible = False
            xyDiagram1.AxisX.VisibleInPanesSerializable = "0"
            xyDiagram1.AxisY.Title.Text = "Retail Price (USD)"
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
            xyDiagramPane1.Name = "Supply and Demand"
            xyDiagramPane1.PaneID = 0
            xyDiagram1.Panes.AddRange(New DevExpress.XtraCharts.XYDiagramPane() {xyDiagramPane1})
            secondaryAxisY1.AxisID = 0
            secondaryAxisY1.Label.TextPattern = "{V:0,}M"
            secondaryAxisY1.Name = "Income Axis"
            secondaryAxisY1.Title.Text = "Income (USD)"
            secondaryAxisY1.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            secondaryAxisY1.VisibleInPanesSerializable = "-1"
            secondaryAxisY2.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
            secondaryAxisY2.AxisID = 1
            secondaryAxisY2.GridLines.Visible = True
            secondaryAxisY2.Label.TextPattern = "{V:0,}K"
            secondaryAxisY2.Name = "Supply and Demand Axis"
            secondaryAxisY2.Title.Text = "Units"
            secondaryAxisY2.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            secondaryAxisY2.VisibleInPanesSerializable = "0"
            xyDiagram1.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() {secondaryAxisY1, secondaryAxisY2})
            Me.chart.Diagram = xyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.BackColor = System.Drawing.Color.Transparent
            Me.chart.Legend.DockTargetName = "Default Pane"
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            legend1.DockTargetName = "Supply and Demand"
            legend1.Name = "StockDemandProduction"
            legend2.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            legend2.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
            customLegendItem1.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
            customLegendItem1.MarkerVisible = True
            customLegendItem1.Name = "Total Income"
            customLegendItem1.TextVisible = True
            legend2.CustomItems.AddRange(New DevExpress.XtraCharts.CustomLegendItem() {customLegendItem1})
            legend2.DockTargetName = "Supply and Demand"
            legend2.MarkerMode = DevExpress.XtraCharts.LegendMarkerMode.None
            legend2.Name = "TotalIncome"
            Me.chart.Legends.AddRange(New DevExpress.XtraCharts.Legend() {legend1, legend2})
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Margin = New System.Windows.Forms.Padding(0)
            Me.chart.Name = "chart"
            Me.chart.RuntimeHitTesting = True
            dataMember1.ColumnName = "Month"
            dataMember2.ColumnName = "Income"
            dataMember2.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Value
            dataSourceAdapter1.DataMembers.AddRange(New DevExpress.XtraCharts.DataMember() {dataMember1, dataMember2})
            series1.DataAdapter = dataSourceAdapter1
            series1.Name = "Income"
            splineAreaSeriesView1.AxisYName = "Income Axis"
            series1.View = splineAreaSeriesView1
            dataMember3.ColumnName = "Month"
            dataMember4.ColumnName = "Cost"
            dataMember4.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Value
            dataSourceAdapter2.DataMembers.AddRange(New DevExpress.XtraCharts.DataMember() {dataMember3, dataMember4})
            series2.DataAdapter = dataSourceAdapter2
            pointSeriesLabel1.TextPattern = "${V:#.00}"
            series2.Label = pointSeriesLabel1
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
            series2.Name = "Retail Price"
            lineSeriesView1.LineMarkerOptions.Size = 12
            lineSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[True]
            series2.View = lineSeriesView1
            dataMember5.ColumnName = "Month"
            dataMember6.ColumnName = "Stock"
            dataMember6.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Value
            dataSourceAdapter3.DataMembers.AddRange(New DevExpress.XtraCharts.DataMember() {dataMember5, dataMember6})
            series3.DataAdapter = dataSourceAdapter3
            sideBySideBarSeriesLabel1.TextPattern = "{V:#.000}"
            series3.Label = sideBySideBarSeriesLabel1
            series3.LegendName = "StockDemandProduction"
            series3.Name = "Stock"
            sideBySideBarSeriesView1.AxisYName = "Supply and Demand Axis"
            sideBySideBarSeriesView1.PaneName = "Supply and Demand"
            sideBySideBarSeriesView1.Transparency =(CByte((135)))
            series3.View = sideBySideBarSeriesView1
            dataMember7.ColumnName = "Month"
            dataMember8.ColumnName = "Demand"
            dataMember8.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Value
            dataSourceAdapter4.DataMembers.AddRange(New DevExpress.XtraCharts.DataMember() {dataMember7, dataMember8})
            series4.DataAdapter = dataSourceAdapter4
            pointSeriesLabel2.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.[Default]
            pointSeriesLabel2.TextPattern = "{V:N0}"
            series4.Label = pointSeriesLabel2
            series4.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
            series4.LegendName = "StockDemandProduction"
            series4.Name = "Demand"
            lineSeriesView2.AxisYName = "Supply and Demand Axis"
            lineSeriesView2.LineMarkerOptions.Size = 12
            lineSeriesView2.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[True]
            lineSeriesView2.PaneName = "Supply and Demand"
            series4.View = lineSeriesView2
            dataMember9.ColumnName = "Month"
            dataMember10.ColumnName = "Production"
            dataMember10.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Value
            dataSourceAdapter5.DataMembers.AddRange(New DevExpress.XtraCharts.DataMember() {dataMember9, dataMember10})
            series5.DataAdapter = dataSourceAdapter5
            pointSeriesLabel3.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.[Default]
            pointSeriesLabel3.TextPattern = "{V:N0}"
            series5.Label = pointSeriesLabel3
            series5.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
            series5.LegendName = "StockDemandProduction"
            series5.Name = "Production"
            lineSeriesView3.AxisYName = "Supply and Demand Axis"
            lineSeriesView3.LineMarkerOptions.Size = 12
            lineSeriesView3.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[True]
            lineSeriesView3.PaneName = "Supply and Demand"
            series5.View = lineSeriesView3
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1, series2, series3, series4, series5}
            lineSeriesView4.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chart.SeriesTemplate.View = lineSeriesView4
            Me.chart.Size = New System.Drawing.Size(784, 432)
            Me.chart.TabIndex = 2
            Me.chart.TabStop = False
            chartTitle1.Text = "Income Forecast"
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            AddHandler Me.chart.CustomDrawSeriesPoint, New DevExpress.XtraCharts.CustomDrawSeriesPointEventHandler(AddressOf Me.Chart_CustomDrawSeriesPoint)
            AddHandler Me.chart.MouseDown, New System.Windows.Forms.MouseEventHandler(AddressOf Me.Chart_MouseDown)
            AddHandler Me.chart.MouseMove, New System.Windows.Forms.MouseEventHandler(AddressOf Me.Chart_MouseMove)
            AddHandler Me.chart.MouseUp, New System.Windows.Forms.MouseEventHandler(AddressOf Me.Chart_MouseUp)
            ' 
            ' SeriesPointMovingDemo
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.Controls.Add(Me.flyoutPanel1)
            Me.Controls.Add(Me.chart)
            Me.Name = "SeriesPointMovingDemo"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.SeriesPointMovingDemo_Load)
            CType((Me.dockManager), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanel6.ResumeLayout(False)
            CType((Me.documentManager), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.noDocumentsView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.currentTabbedView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.checkEditLabelVisible.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditLabelAngle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditValueAsPercent.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditMarkerSize.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditMarkerVisible.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditLineTension.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditFunction.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupLabel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemLabelVisible), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemAngle), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemValueAsPercent), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupMarker), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemMarkerSize), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemMarkerVisible), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupGeneral), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemLineTension), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemFunction), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.flyoutPanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.flyoutPanel1.ResumeLayout(False)
            Me.flyoutPanel1.PerformLayout()
            CType((xyDiagramPane1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((secondaryAxisY1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((secondaryAxisY2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((splineAreaSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesLabel2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesLabel3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private dockManager As DevExpress.XtraBars.Docking.DockManager

        Private documentManager As DevExpress.XtraBars.Docking2010.DocumentManager

        Private currentTabbedView As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView

        Private dockPanel6 As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanel6_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private checkEditLabelVisible As DevExpress.XtraEditors.CheckEdit

        Private spinEditLabelAngle As DevExpress.XtraEditors.SpinEdit

        Private checkEditValueAsPercent As DevExpress.XtraEditors.CheckEdit

        Private layoutControlGroupLabel As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemLabelVisible As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemAngle As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemValueAsPercent As DevExpress.XtraLayout.LayoutControlItem

        Private spinEditMarkerSize As DevExpress.XtraEditors.SpinEdit

        Private checkEditMarkerVisible As DevExpress.XtraEditors.CheckEdit

        Private layoutControlGroupMarker As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemMarkerSize As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemMarkerVisible As DevExpress.XtraLayout.LayoutControlItem

        Private spinEditLineTension As DevExpress.XtraEditors.SpinEdit

        Private layoutControlGroupGeneral As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemLineTension As DevExpress.XtraLayout.LayoutControlItem

        Private comboBoxEditFunction As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlItemFunction As DevExpress.XtraLayout.LayoutControlItem

        Private toolTipController As DevExpress.Utils.ToolTipController

        Private noDocumentsView1 As DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView

        Private flyoutPanel1 As DevExpress.Utils.FlyoutPanel

        Private label1 As System.Windows.Forms.Label

        Private chart As DevExpress.XtraCharts.ChartControl

        Private button1 As System.Windows.Forms.Button
    End Class
End Namespace
