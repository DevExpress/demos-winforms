Namespace DevExpress.XtraCharts.Demos

    Partial Class FinancialViewsDemo

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraCharts.Demos.FinancialViewsDemo))
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim stockSeriesLabel1 As DevExpress.XtraCharts.StockSeriesLabel = New DevExpress.XtraCharts.StockSeriesLabel()
            Dim candleStickSeriesView1 As DevExpress.XtraCharts.CandleStickSeriesView = New DevExpress.XtraCharts.CandleStickSeriesView()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim xyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim stockSeriesLabel2 As DevExpress.XtraCharts.StockSeriesLabel = New DevExpress.XtraCharts.StockSeriesLabel()
            Dim stockSeriesView1 As DevExpress.XtraCharts.StockSeriesView = New DevExpress.XtraCharts.StockSeriesView()
            Dim financialSlideAnimation1 As DevExpress.XtraCharts.FinancialSlideAnimation = New DevExpress.XtraCharts.FinancialSlideAnimation()
            Dim elasticEasingFunction1 As DevExpress.XtraCharts.ElasticEasingFunction = New DevExpress.XtraCharts.ElasticEasingFunction()
            Dim chartTitle3 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle4 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim dockingContainer1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer()
            Me.documentGroup = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
            Me.documentCandleStick = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentStock = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.comboBoxEditReductionLevel = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.comboBoxEditStockType = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.checkEditWorkDaysOnly = New DevExpress.XtraEditors.CheckEdit()
            Me.comboBoxEditReductionColorMode = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.colorPickEditReductionColor = New DevExpress.XtraEditors.ColorPickEdit()
            Me.colorPickEditBaseColor = New DevExpress.XtraEditors.ColorPickEdit()
            Me.comboBoxEditFillMode = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroupGeneral = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemStockType = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemWorkdaysOnly = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroupOptions = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemReductionColor = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemColorMode = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemFillMode = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemBaseColor = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemReductionLevel = New DevExpress.XtraLayout.LayoutControlItem()
            Me.dockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.dockPanelCandleStick = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelCandleStick_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartCandleStick = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelStock = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelStock_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartStock = New DevExpress.XtraCharts.ChartControl()
            Me.documentManager = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            Me.currentTabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.documentGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentCandleStick), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentStock), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.comboBoxEditReductionLevel.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditStockType.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditWorkDaysOnly.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditReductionColorMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.colorPickEditReductionColor.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.colorPickEditBaseColor.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditFillMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupGeneral), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemStockType), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemWorkdaysOnly), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemReductionColor), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemColorMode), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemFillMode), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemBaseColor), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemReductionLevel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dockManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelCandleStick.SuspendLayout()
            Me.dockPanelCandleStick_Container.SuspendLayout()
            CType((Me.chartCandleStick), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stockSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((candleStickSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelStock.SuspendLayout()
            Me.dockPanelStock_Container.SuspendLayout()
            CType((Me.chartStock), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stockSeriesLabel2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stockSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentManager), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.currentTabbedView), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' sidePanelOptions
            ' 
            Me.sidePanelOptions.Margin = New System.Windows.Forms.Padding(0)
            ' 
            ' tabPaneOptions
            ' 
            Me.tabPaneOptions.Margin = New System.Windows.Forms.Padding(0)
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(241, 538)
            ' 
            ' documentGroup
            ' 
            Me.documentGroup.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() {Me.documentCandleStick, Me.documentStock})
            ' 
            ' documentCandleStick
            ' 
            Me.documentCandleStick.Caption = "Candle Stick"
            Me.documentCandleStick.ControlName = "dockPanelCandleStick"
            Me.documentCandleStick.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentCandleStick.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentCandleStick.ImageOptions.SvgImage = CType((resources.GetObject("documentCandleStick.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentCandleStick.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentCandleStick.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentCandleStick.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentCandleStick.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' documentStock
            ' 
            Me.documentStock.Caption = "Stock"
            Me.documentStock.ControlName = "dockPanelStock"
            Me.documentStock.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentStock.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentStock.ImageOptions.SvgImage = CType((resources.GetObject("documentStock.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentStock.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentStock.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentStock.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentStock.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.comboBoxEditReductionLevel)
            Me.layoutControl.Controls.Add(Me.comboBoxEditStockType)
            Me.layoutControl.Controls.Add(Me.checkEditWorkDaysOnly)
            Me.layoutControl.Controls.Add(Me.comboBoxEditReductionColorMode)
            Me.layoutControl.Controls.Add(Me.colorPickEditReductionColor)
            Me.layoutControl.Controls.Add(Me.colorPickEditBaseColor)
            Me.layoutControl.Controls.Add(Me.comboBoxEditFillMode)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(941, 150, 650, 400)
            Me.layoutControl.Root = Me.layoutControlGroupRoot
            Me.layoutControl.Size = New System.Drawing.Size(241, 538)
            Me.layoutControl.TabIndex = 2
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' comboBoxEditReductionLevel
            ' 
            Me.comboBoxEditReductionLevel.EditValue = "Close"
            Me.comboBoxEditReductionLevel.Location = New System.Drawing.Point(104, 148)
            Me.comboBoxEditReductionLevel.Name = "comboBoxEditReductionLevel"
            Me.comboBoxEditReductionLevel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditReductionLevel.Properties.Items.AddRange(New Object() {"Low", "High", "Open", "Close"})
            Me.comboBoxEditReductionLevel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditReductionLevel.Size = New System.Drawing.Size(125, 20)
            Me.comboBoxEditReductionLevel.StyleController = Me.layoutControl
            Me.comboBoxEditReductionLevel.TabIndex = 0
            AddHandler Me.comboBoxEditReductionLevel.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditReductionLevel_SelectedIndexChanged)
            ' 
            ' comboBoxEditStockType
            ' 
            Me.comboBoxEditStockType.EditValue = "Both"
            Me.comboBoxEditStockType.Location = New System.Drawing.Point(104, 58)
            Me.comboBoxEditStockType.Name = "comboBoxEditStockType"
            Me.comboBoxEditStockType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditStockType.Properties.Items.AddRange(New Object() {"Both", "Close", "Open"})
            Me.comboBoxEditStockType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditStockType.Size = New System.Drawing.Size(125, 20)
            Me.comboBoxEditStockType.StyleController = Me.layoutControl
            Me.comboBoxEditStockType.TabIndex = 2
            AddHandler Me.comboBoxEditStockType.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditStockType_SelectedIndexChanged)
            ' 
            ' checkEditWorkDaysOnly
            ' 
            Me.checkEditWorkDaysOnly.EditValue = True
            Me.checkEditWorkDaysOnly.Location = New System.Drawing.Point(12, 34)
            Me.checkEditWorkDaysOnly.Name = "checkEditWorkDaysOnly"
            Me.checkEditWorkDaysOnly.Properties.Caption = "Workdays Only"
            Me.checkEditWorkDaysOnly.Size = New System.Drawing.Size(217, 20)
            Me.checkEditWorkDaysOnly.StyleController = Me.layoutControl
            Me.checkEditWorkDaysOnly.TabIndex = 3
            AddHandler Me.checkEditWorkDaysOnly.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditWorkdaysOnly_CheckedChanged)
            ' 
            ' comboBoxEditReductionColorMode
            ' 
            Me.comboBoxEditReductionColorMode.EditValue = "Previous to Current Point"
            Me.comboBoxEditReductionColorMode.Location = New System.Drawing.Point(104, 124)
            Me.comboBoxEditReductionColorMode.Name = "comboBoxEditReductionColorMode"
            Me.comboBoxEditReductionColorMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditReductionColorMode.Properties.Items.AddRange(New Object() {"Previous to Current Point", "Open to Close Value"})
            Me.comboBoxEditReductionColorMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditReductionColorMode.Size = New System.Drawing.Size(125, 20)
            Me.comboBoxEditReductionColorMode.StyleController = Me.layoutControl
            Me.comboBoxEditReductionColorMode.TabIndex = 6
            AddHandler Me.comboBoxEditReductionColorMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditReductionColorMode_SelectedIndexChanged)
            ' 
            ' colorPickEditReductionColor
            ' 
            Me.colorPickEditReductionColor.EditValue = System.Drawing.Color.Empty
            Me.colorPickEditReductionColor.Location = New System.Drawing.Point(104, 220)
            Me.colorPickEditReductionColor.Name = "colorPickEditReductionColor"
            Me.colorPickEditReductionColor.Properties.AutomaticColor = System.Drawing.Color.Black
            Me.colorPickEditReductionColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.colorPickEditReductionColor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
            Me.colorPickEditReductionColor.Size = New System.Drawing.Size(125, 20)
            Me.colorPickEditReductionColor.StyleController = Me.layoutControl
            Me.colorPickEditReductionColor.TabIndex = 7
            AddHandler Me.colorPickEditReductionColor.EditValueChanged, New System.EventHandler(AddressOf Me.colorPickEditReductionColor_EditValueChanged)
            ' 
            ' colorPickEditBaseColor
            ' 
            Me.colorPickEditBaseColor.EditValue = System.Drawing.Color.Empty
            Me.colorPickEditBaseColor.Location = New System.Drawing.Point(104, 196)
            Me.colorPickEditBaseColor.Name = "colorPickEditBaseColor"
            Me.colorPickEditBaseColor.Properties.AutomaticColor = System.Drawing.Color.Black
            Me.colorPickEditBaseColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.colorPickEditBaseColor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
            Me.colorPickEditBaseColor.Size = New System.Drawing.Size(125, 20)
            Me.colorPickEditBaseColor.StyleController = Me.layoutControl
            Me.colorPickEditBaseColor.TabIndex = 8
            AddHandler Me.colorPickEditBaseColor.EditValueChanged, New System.EventHandler(AddressOf Me.colorPickEditBaseColor_EditValueChanged)
            ' 
            ' comboBoxEditFillMode
            ' 
            Me.comboBoxEditFillMode.EditValue = "FilledOnReduction"
            Me.comboBoxEditFillMode.Location = New System.Drawing.Point(104, 172)
            Me.comboBoxEditFillMode.Name = "comboBoxEditFillMode"
            Me.comboBoxEditFillMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditFillMode.Properties.Items.AddRange(New Object() {"FilledOnReduction", "FilledOnIncrease", "AlwaysEmpty", "AlwaysFilled"})
            Me.comboBoxEditFillMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditFillMode.Size = New System.Drawing.Size(125, 20)
            Me.comboBoxEditFillMode.StyleController = Me.layoutControl
            Me.comboBoxEditFillMode.TabIndex = 9
            AddHandler Me.comboBoxEditFillMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditFillMode_SelectedIndexChanged)
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroupGeneral, Me.emptySpaceItem, Me.layoutControlGroupOptions})
            Me.layoutControlGroupRoot.Name = "layoutControlGroupRoot"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(241, 538)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' layoutControlGroupGeneral
            ' 
            Me.layoutControlGroupGeneral.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupGeneral.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupGeneral.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupGeneral.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemStockType, Me.layoutControlItemWorkdaysOnly})
            Me.layoutControlGroupGeneral.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupGeneral.Name = "layoutControlGroupGeneral"
            Me.layoutControlGroupGeneral.Size = New System.Drawing.Size(241, 90)
            Me.layoutControlGroupGeneral.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupGeneral.Text = "General"
            ' 
            ' layoutControlItemStockType
            ' 
            Me.layoutControlItemStockType.Control = Me.comboBoxEditStockType
            Me.layoutControlItemStockType.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemStockType.Name = "layoutControlItemStockType"
            Me.layoutControlItemStockType.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemStockType.Text = "Stock Type:"
            Me.layoutControlItemStockType.TextSize = New System.Drawing.Size(80, 13)
            Me.layoutControlItemStockType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            ' 
            ' layoutControlItemWorkdaysOnly
            ' 
            Me.layoutControlItemWorkdaysOnly.Control = Me.checkEditWorkDaysOnly
            Me.layoutControlItemWorkdaysOnly.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemWorkdaysOnly.Name = "layoutControlItemWorkdaysOnly"
            Me.layoutControlItemWorkdaysOnly.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemWorkdaysOnly.TextVisible = False
            ' 
            ' emptySpaceItem
            ' 
            Me.emptySpaceItem.Location = New System.Drawing.Point(0, 252)
            Me.emptySpaceItem.Name = "emptySpaceItem"
            Me.emptySpaceItem.Size = New System.Drawing.Size(241, 286)
            ' 
            ' layoutControlGroupOptions
            ' 
            Me.layoutControlGroupOptions.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupOptions.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupOptions.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupOptions.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemReductionColor, Me.layoutControlItemColorMode, Me.layoutControlItemFillMode, Me.layoutControlItemBaseColor, Me.layoutControlItemReductionLevel})
            Me.layoutControlGroupOptions.Location = New System.Drawing.Point(0, 90)
            Me.layoutControlGroupOptions.Name = "layoutControlGroupOptions"
            Me.layoutControlGroupOptions.Size = New System.Drawing.Size(241, 162)
            Me.layoutControlGroupOptions.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupOptions.Text = "Reduction Color"
            ' 
            ' layoutControlItemReductionColor
            ' 
            Me.layoutControlItemReductionColor.Control = Me.colorPickEditReductionColor
            Me.layoutControlItemReductionColor.Location = New System.Drawing.Point(0, 96)
            Me.layoutControlItemReductionColor.Name = "layoutControlItemReductionColor"
            Me.layoutControlItemReductionColor.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemReductionColor.Text = "Reduction Color:"
            Me.layoutControlItemReductionColor.TextSize = New System.Drawing.Size(80, 13)
            ' 
            ' layoutControlItemColorMode
            ' 
            Me.layoutControlItemColorMode.Control = Me.comboBoxEditReductionColorMode
            Me.layoutControlItemColorMode.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemColorMode.Name = "layoutControlItemColorMode"
            Me.layoutControlItemColorMode.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemColorMode.Text = "Mode"
            Me.layoutControlItemColorMode.TextSize = New System.Drawing.Size(80, 13)
            ' 
            ' layoutControlItemFillMode
            ' 
            Me.layoutControlItemFillMode.Control = Me.comboBoxEditFillMode
            Me.layoutControlItemFillMode.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItemFillMode.Name = "layoutControlItemFillMode"
            Me.layoutControlItemFillMode.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemFillMode.Text = "Fill Mode:"
            Me.layoutControlItemFillMode.TextSize = New System.Drawing.Size(80, 13)
            ' 
            ' layoutControlItemBaseColor
            ' 
            Me.layoutControlItemBaseColor.Control = Me.colorPickEditBaseColor
            Me.layoutControlItemBaseColor.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItemBaseColor.Name = "layoutControlItemBaseColor"
            Me.layoutControlItemBaseColor.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemBaseColor.Text = "Base Color:"
            Me.layoutControlItemBaseColor.TextSize = New System.Drawing.Size(80, 13)
            ' 
            ' layoutControlItemReductionLevel
            ' 
            Me.layoutControlItemReductionLevel.Control = Me.comboBoxEditReductionLevel
            Me.layoutControlItemReductionLevel.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemReductionLevel.Name = "layoutControlItemReductionLevel"
            Me.layoutControlItemReductionLevel.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemReductionLevel.Text = "Reduction Level:"
            Me.layoutControlItemReductionLevel.TextSize = New System.Drawing.Size(80, 13)
            ' 
            ' dockManager1
            ' 
            Me.dockManager1.DockingOptions.FloatOnDblClick = False
            Me.dockManager1.DockingOptions.ShowAutoHideButton = False
            Me.dockManager1.DockingOptions.ShowCloseButton = False
            Me.dockManager1.DockingOptions.ShowMaximizeButton = False
            Me.dockManager1.Form = Me
            Me.dockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanelCandleStick, Me.dockPanelStock})
            Me.dockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
            ' 
            ' dockPanelCandleStick
            ' 
            Me.dockPanelCandleStick.Controls.Add(Me.dockPanelCandleStick_Container)
            Me.dockPanelCandleStick.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelCandleStick.DockedAsTabbedDocument = True
            Me.dockPanelCandleStick.ID = New System.Guid("bde4f2e6-3190-4b46-a158-c84c72edf99f")
            Me.dockPanelCandleStick.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelCandleStick.Name = "dockPanelCandleStick"
            Me.dockPanelCandleStick.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelCandleStick.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelCandleStick.Text = "Candle Stick"
            ' 
            ' dockPanelCandleStick_Container
            ' 
            Me.dockPanelCandleStick_Container.Controls.Add(Me.chartCandleStick)
            Me.dockPanelCandleStick_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelCandleStick_Container.Name = "dockPanelCandleStick_Container"
            Me.dockPanelCandleStick_Container.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelCandleStick_Container.TabIndex = 0
            ' 
            ' chartCandleStick
            ' 
            Me.chartCandleStick.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chartCandleStick.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartCandleStick.CrosshairOptions.GroupHeaderPattern = "{A:d}"
            xyDiagram1.AxisX.DateTimeScaleOptions.WorkdaysOnly = True
            xyDiagram1.AxisX.GridLines.Visible = True
            xyDiagram1.AxisX.Interlaced = True
            xyDiagram1.AxisX.Title.Text = "Date"
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = False
            xyDiagram1.AxisX.WholeRange.EndSideMargin = 2R
            xyDiagram1.AxisX.WholeRange.StartSideMargin = 2R
            xyDiagram1.AxisY.GridLines.MinorVisible = True
            xyDiagram1.AxisY.Title.Text = "US Dollars"
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
            xyDiagram1.AxisY.WholeRange.AutoSideMargins = False
            xyDiagram1.AxisY.WholeRange.EndSideMargin = 0R
            xyDiagram1.AxisY.WholeRange.StartSideMargin = 0R
            xyDiagram1.DependentAxesYRange = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.EnableAxisXScrolling = True
            xyDiagram1.EnableAxisXZooming = True
            Me.chartCandleStick.Diagram = xyDiagram1
            Me.chartCandleStick.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartCandleStick.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
            Me.chartCandleStick.Legend.Name = "Default Legend"
            Me.chartCandleStick.Location = New System.Drawing.Point(0, 0)
            Me.chartCandleStick.Margin = New System.Windows.Forms.Padding(0)
            Me.chartCandleStick.Name = "chartCandleStick"
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series1.CrosshairLabelPattern = "Open:" & Global.Microsoft.VisualBasic.Constants.vbTab & "{OV:0.000}" & Global.Microsoft.VisualBasic.Constants.vbLf & "High:" & Global.Microsoft.VisualBasic.Constants.vbTab & "{HV:0.000}" & Global.Microsoft.VisualBasic.Constants.vbLf & "Low:" & Global.Microsoft.VisualBasic.Constants.vbTab & "{LV:0.000}" & Global.Microsoft.VisualBasic.Constants.vbLf & "Close:" & Global.Microsoft.VisualBasic.Constants.vbTab & "{CV:0.000}"
            stockSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped
            stockSeriesLabel1.TextPattern = "{CV:G4}"
            series1.Label = stockSeriesLabel1
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            series1.Name = "Google Inc."
            series1.SeriesID = 0
            candleStickSeriesView1.Color = System.Drawing.Color.Black
            candleStickSeriesView1.LineThickness = 1
            series1.View = candleStickSeriesView1
            Me.chartCandleStick.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1}
            Me.chartCandleStick.Size = New System.Drawing.Size(788, 548)
            Me.chartCandleStick.TabIndex = 1
            Me.chartCandleStick.TabStop = False
            chartTitle1.Text = "Stock Prices"
            chartTitle1.TitleID = 0
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            chartTitle2.DXAlignment = DevExpress.Drawing.DXStringAlignment.Far
            chartTitle2.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            chartTitle2.Text = "From www.quandl.com"
            chartTitle2.TextColor = System.Drawing.Color.Gray
            chartTitle2.TitleID = 1
            Me.chartCandleStick.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1, chartTitle2})
            ' 
            ' dockPanelStock
            ' 
            Me.dockPanelStock.Controls.Add(Me.dockPanelStock_Container)
            Me.dockPanelStock.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelStock.DockedAsTabbedDocument = True
            Me.dockPanelStock.ID = New System.Guid("431a805b-1fc4-444e-88ec-9167a87ec6e6")
            Me.dockPanelStock.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelStock.Name = "dockPanelStock"
            Me.dockPanelStock.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelStock.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelStock.Text = "Stock"
            ' 
            ' dockPanelStock_Container
            ' 
            Me.dockPanelStock_Container.Controls.Add(Me.chartStock)
            Me.dockPanelStock_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelStock_Container.Name = "dockPanelStock_Container"
            Me.dockPanelStock_Container.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelStock_Container.TabIndex = 0
            ' 
            ' chartStock
            ' 
            Me.chartStock.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chartStock.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartStock.CrosshairOptions.CrosshairLabelMode = DevExpress.XtraCharts.CrosshairLabelMode.ShowForNearestSeries
            Me.chartStock.CrosshairOptions.GroupHeaderPattern = "{A:d}"
            xyDiagram2.AxisX.DateTimeScaleOptions.WorkdaysOnly = True
            xyDiagram2.AxisX.GridLines.Visible = True
            xyDiagram2.AxisX.Interlaced = True
            xyDiagram2.AxisX.Title.Text = "Date"
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram2.AxisX.WholeRange.AutoSideMargins = False
            xyDiagram2.AxisX.WholeRange.EndSideMargin = 2R
            xyDiagram2.AxisX.WholeRange.StartSideMargin = 2R
            xyDiagram2.AxisY.GridLines.MinorVisible = True
            xyDiagram2.AxisY.Title.Text = "US Dollars"
            xyDiagram2.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram2.AxisY.WholeRange.AlwaysShowZeroLevel = False
            xyDiagram2.AxisY.WholeRange.AutoSideMargins = False
            xyDiagram2.AxisY.WholeRange.EndSideMargin = 0R
            xyDiagram2.AxisY.WholeRange.StartSideMargin = 0R
            xyDiagram2.DependentAxesYRange = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram2.EnableAxisXScrolling = True
            xyDiagram2.EnableAxisXZooming = True
            Me.chartStock.Diagram = xyDiagram2
            Me.chartStock.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartStock.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
            Me.chartStock.Legend.Name = "Default Legend"
            Me.chartStock.Location = New System.Drawing.Point(0, 0)
            Me.chartStock.Name = "chartStock"
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series2.CrosshairLabelPattern = "Open:" & Global.Microsoft.VisualBasic.Constants.vbTab & "{OV:0.000}" & Global.Microsoft.VisualBasic.Constants.vbLf & "High:" & Global.Microsoft.VisualBasic.Constants.vbTab & "{HV:0.000}" & Global.Microsoft.VisualBasic.Constants.vbLf & "Low:" & Global.Microsoft.VisualBasic.Constants.vbTab & "{LV:0.000}" & Global.Microsoft.VisualBasic.Constants.vbLf & "Close:" & Global.Microsoft.VisualBasic.Constants.vbTab & "{CV:0.000}"
            stockSeriesLabel2.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped
            stockSeriesLabel2.TextPattern = "{CV:G4}"
            series2.Label = stockSeriesLabel2
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            series2.Name = "Google Inc."
            series2.SeriesID = 0
            financialSlideAnimation1.Direction = DevExpress.XtraCharts.AnimationDirection.FromBottom
            elasticEasingFunction1.EasingMode = DevExpress.XtraCharts.EasingMode.Out
            financialSlideAnimation1.EasingFunction = elasticEasingFunction1
            stockSeriesView1.Animation = financialSlideAnimation1
            stockSeriesView1.Color = System.Drawing.Color.Black
            series2.View = stockSeriesView1
            Me.chartStock.SeriesSerializable = New DevExpress.XtraCharts.Series() {series2}
            Me.chartStock.Size = New System.Drawing.Size(788, 548)
            Me.chartStock.TabIndex = 1
            Me.chartStock.TabStop = False
            chartTitle3.Text = "Stock Prices"
            chartTitle3.TitleID = 0
            chartTitle4.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            chartTitle4.DXAlignment = DevExpress.Drawing.DXStringAlignment.Far
            chartTitle4.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            chartTitle4.Text = "From www.quandl.com"
            chartTitle4.TextColor = System.Drawing.Color.Gray
            chartTitle4.TitleID = 1
            Me.chartStock.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle3, chartTitle4})
            ' 
            ' documentManager
            ' 
            Me.documentManager.ContainerControl = Me
            Me.documentManager.View = Me.currentTabbedView
            Me.documentManager.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.currentTabbedView})
            ' 
            ' currentTabbedView
            ' 
            Me.currentTabbedView.DocumentGroupProperties.HeaderButtons = DevExpress.XtraTab.TabButtons.None
            Me.currentTabbedView.DocumentGroupProperties.ShowDocumentSelectorButton = False
            Me.currentTabbedView.DocumentGroups.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup() {Me.documentGroup})
            Me.currentTabbedView.DocumentProperties.AllowAnimation = False
            Me.currentTabbedView.DocumentProperties.AllowClose = False
            Me.currentTabbedView.DocumentProperties.AllowDock = False
            Me.currentTabbedView.DocumentProperties.AllowDockFill = False
            Me.currentTabbedView.DocumentProperties.AllowFloat = False
            Me.currentTabbedView.DocumentProperties.AllowFloatOnDoubleClick = False
            Me.currentTabbedView.DocumentProperties.AllowTabReordering = False
            Me.currentTabbedView.DocumentProperties.ShowInDocumentSelector = False
            Me.currentTabbedView.DocumentProperties.ShowPinButton = False
            Me.currentTabbedView.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.documentCandleStick, Me.documentStock})
            dockingContainer1.Element = Me.documentGroup
            Me.currentTabbedView.RootContainer.Nodes.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer() {dockingContainer1})
            Me.currentTabbedView.Style = DevExpress.XtraBars.Docking2010.Views.DockingViewStyle.Light
            AddHandler Me.currentTabbedView.DocumentActivated, New DevExpress.XtraBars.Docking2010.Views.DocumentEventHandler(AddressOf Me.tabbedView_DocumentActivated)
            ' 
            ' FinancialViewsDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "FinancialViewsDemo"
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((Me.documentGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentCandleStick), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentStock), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.comboBoxEditReductionLevel.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditStockType.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditWorkDaysOnly.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditReductionColorMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.colorPickEditReductionColor.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.colorPickEditBaseColor.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditFillMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupGeneral), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemStockType), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemWorkdaysOnly), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupOptions), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemReductionColor), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemColorMode), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemFillMode), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemBaseColor), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemReductionLevel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dockManager1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelCandleStick.ResumeLayout(False)
            Me.dockPanelCandleStick_Container.ResumeLayout(False)
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stockSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((candleStickSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartCandleStick), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelStock.ResumeLayout(False)
            Me.dockPanelStock_Container.ResumeLayout(False)
            CType((xyDiagram2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stockSeriesLabel2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stockSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartStock), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentManager), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.currentTabbedView), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroupGeneral As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroupOptions As DevExpress.XtraLayout.LayoutControlGroup

        Private comboBoxEditReductionLevel As DevExpress.XtraEditors.ComboBoxEdit

        Private comboBoxEditStockType As DevExpress.XtraEditors.ComboBoxEdit

        Private checkEditWorkDaysOnly As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItemReductionLevel As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemStockType As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemWorkdaysOnly As DevExpress.XtraLayout.LayoutControlItem

        Private dockManager1 As DevExpress.XtraBars.Docking.DockManager

        Private dockPanelCandleStick As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelCandleStick_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanelStock As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelStock_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private documentManager As DevExpress.XtraBars.Docking2010.DocumentManager

        Private currentTabbedView As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView

        Private documentGroup As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup

        Private documentCandleStick As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private documentStock As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private chartCandleStick As DevExpress.XtraCharts.ChartControl

        Private chartStock As DevExpress.XtraCharts.ChartControl

        Private comboBoxEditReductionColorMode As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlItemColorMode As DevExpress.XtraLayout.LayoutControlItem

        Private colorPickEditReductionColor As DevExpress.XtraEditors.ColorPickEdit

        Private layoutControlItemReductionColor As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemBaseColor As DevExpress.XtraLayout.LayoutControlItem

        Private colorPickEditBaseColor As DevExpress.XtraEditors.ColorPickEdit

        Private comboBoxEditFillMode As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlItemFillMode As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
