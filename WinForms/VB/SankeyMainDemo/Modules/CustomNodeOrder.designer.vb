Namespace DevExpress.XtraSankey.Demos

    Partial Class CustomNodeOrder

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
            Dim sankeyTitle1 As DevExpress.XtraCharts.Sankey.SankeyTitle = New DevExpress.XtraCharts.Sankey.SankeyTitle()
            Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            Me.ordersTableAdapter1 = New DevExpress.XtraSankey.Demos.nwindDataSetTableAdapters.OrdersTableAdapter()
            Me.nwindDataSet = New DevExpress.XtraSankey.Demos.nwindDataSet()
            Me.customersTableAdapter1 = New DevExpress.XtraSankey.Demos.nwindDataSetTableAdapters.CustomersTableAdapter()
            Me.productsTableAdapter1 = New DevExpress.XtraSankey.Demos.nwindDataSetTableAdapters.ProductsTableAdapter()
            Me.nwindDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.order_DetailsTableAdapter1 = New DevExpress.XtraSankey.Demos.nwindDataSetTableAdapters.Order_DetailsTableAdapter()
            Me.suppliersTableAdapter1 = New DevExpress.XtraSankey.Demos.nwindDataSetTableAdapters.SuppliersTableAdapter()
            Me.categoriesTableAdapter1 = New DevExpress.XtraSankey.Demos.nwindDataSetTableAdapters.CategoriesTableAdapter()
            Me.shippersTableAdapter1 = New DevExpress.XtraSankey.Demos.nwindDataSetTableAdapters.ShippersTableAdapter()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroupTotalLabels = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.comparerRadioGroup = New DevExpress.XtraEditors.RadioGroup()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.orderRadioGroup = New DevExpress.XtraEditors.RadioGroup()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.sankeyDiagramControl1 = New DevExpress.XtraCharts.Sankey.SankeyDiagramControl()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.nwindDataSet), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.nwindDataSetBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupTotalLabels), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comparerRadioGroup.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.orderRadioGroup.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(209, 542)
            ' 
            ' toolTipController1
            ' 
            Me.toolTipController1.Appearance.Options.UseTextOptions = True
            Me.toolTipController1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None
            Me.toolTipController1.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip
            ' 
            ' ordersTableAdapter1
            ' 
            Me.ordersTableAdapter1.ClearBeforeFill = True
            ' 
            ' nwindDataSet
            ' 
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' customersTableAdapter1
            ' 
            Me.customersTableAdapter1.ClearBeforeFill = True
            ' 
            ' productsTableAdapter1
            ' 
            Me.productsTableAdapter1.ClearBeforeFill = True
            ' 
            ' nwindDataSetBindingSource
            ' 
            Me.nwindDataSetBindingSource.DataSource = Me.nwindDataSet
            Me.nwindDataSetBindingSource.Position = 0
            ' 
            ' order_DetailsTableAdapter1
            ' 
            Me.order_DetailsTableAdapter1.ClearBeforeFill = True
            ' 
            ' suppliersTableAdapter1
            ' 
            Me.suppliersTableAdapter1.ClearBeforeFill = True
            ' 
            ' categoriesTableAdapter1
            ' 
            Me.categoriesTableAdapter1.ClearBeforeFill = True
            ' 
            ' shippersTableAdapter1
            ' 
            Me.shippersTableAdapter1.ClearBeforeFill = True
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroupTotalLabels, Me.layoutControlGroup1})
            Me.layoutControlGroupRoot.Name = "Root"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(209, 542)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' layoutControlGroupTotalLabels
            ' 
            Me.layoutControlGroupTotalLabels.CustomizationFormText = "Sort by"
            Me.layoutControlGroupTotalLabels.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupTotalLabels.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroupTotalLabels.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupTotalLabels.Name = "layoutControlGroupTotalLabels"
            Me.layoutControlGroupTotalLabels.Size = New System.Drawing.Size(209, 59)
            Me.layoutControlGroupTotalLabels.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupTotalLabels.Text = "Sort by"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.comparerRadioGroup
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(189, 17)
            Me.layoutControlItem1.Text = "Sort by:"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' comparerRadioGroup
            ' 
            Me.comparerRadioGroup.Location = New System.Drawing.Point(12, 34)
            Me.comparerRadioGroup.MenuManager = Me
            Me.comparerRadioGroup.Name = "comparerRadioGroup"
            Me.comparerRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.comparerRadioGroup.Properties.Appearance.Options.UseBackColor = True
            Me.comparerRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.comparerRadioGroup.Size = New System.Drawing.Size(185, 13)
            Me.comparerRadioGroup.StyleController = Me.layoutControl
            Me.comparerRadioGroup.TabIndex = 4
            AddHandler Me.comparerRadioGroup.SelectedIndexChanged, New System.EventHandler(AddressOf Me.RadioGroup_SelectedIndexChanged)
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.comparerRadioGroup)
            Me.layoutControl.Controls.Add(Me.orderRadioGroup)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(835, 283, 650, 400)
            Me.layoutControl.Root = Me.layoutControlGroupRoot
            Me.layoutControl.Size = New System.Drawing.Size(209, 542)
            Me.layoutControl.TabIndex = 1
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' orderRadioGroup
            ' 
            Me.orderRadioGroup.Location = New System.Drawing.Point(12, 93)
            Me.orderRadioGroup.MenuManager = Me
            Me.orderRadioGroup.Name = "orderRadioGroup"
            Me.orderRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.orderRadioGroup.Properties.Appearance.Options.UseBackColor = True
            Me.orderRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.orderRadioGroup.Size = New System.Drawing.Size(185, 13)
            Me.orderRadioGroup.StyleController = Me.layoutControl
            Me.orderRadioGroup.TabIndex = 5
            AddHandler Me.orderRadioGroup.SelectedIndexChanged, New System.EventHandler(AddressOf Me.RadioGroup_SelectedIndexChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.emptySpaceItem1})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 59)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(209, 483)
            Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Text = "Order"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.orderRadioGroup
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(189, 17)
            Me.layoutControlItem2.Text = "Order:"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 17)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(189, 424)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' sankeyDiagramControl1
            ' 
            Me.sankeyDiagramControl1.BorderOptions.Thickness = 0
            Me.sankeyDiagramControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sankeyDiagramControl1.Location = New System.Drawing.Point(0, 0)
            Me.sankeyDiagramControl1.Name = "sankeyDiagramControl1"
            Me.sankeyDiagramControl1.Size = New System.Drawing.Size(578, 571)
            Me.sankeyDiagramControl1.TabIndex = 5
            Me.sankeyDiagramControl1.Text = "sankeyDiagramControl1"
            sankeyTitle1.Text = "Top 10 Companies by Revenue"
            Me.sankeyDiagramControl1.Titles.Add(sankeyTitle1)
            AddHandler Me.sankeyDiagramControl1.CustomizeNodeToolTip, New DevExpress.XtraCharts.Sankey.CustomizeSankeyNodeToolTipEventHandler(AddressOf Me.OnCustomizeNodeToolTip)
            AddHandler Me.sankeyDiagramControl1.CustomizeLinkToolTip, New DevExpress.XtraCharts.Sankey.CustomizeSankeyLinkToolTipEventHandler(AddressOf Me.OnCustomizeLinkToolTip)
            ' 
            ' CustomNodeOrder
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.Controls.Add(Me.sankeyDiagramControl1)
            Me.Name = "CustomNodeOrder"
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.Controls.SetChildIndex(Me.sankeyDiagramControl1, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((Me.nwindDataSet), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.nwindDataSetBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupTotalLabels), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comparerRadioGroup.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.orderRadioGroup.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private toolTipController1 As DevExpress.Utils.ToolTipController

        Private nwindDataSetBindingSource As System.Windows.Forms.BindingSource

        Private nwindDataSet As DevExpress.XtraSankey.Demos.nwindDataSet

        Private ordersTableAdapter1 As DevExpress.XtraSankey.Demos.nwindDataSetTableAdapters.OrdersTableAdapter

        Private order_DetailsTableAdapter1 As DevExpress.XtraSankey.Demos.nwindDataSetTableAdapters.Order_DetailsTableAdapter

        Private productsTableAdapter1 As DevExpress.XtraSankey.Demos.nwindDataSetTableAdapters.ProductsTableAdapter

        Private suppliersTableAdapter1 As DevExpress.XtraSankey.Demos.nwindDataSetTableAdapters.SuppliersTableAdapter

        Private categoriesTableAdapter1 As DevExpress.XtraSankey.Demos.nwindDataSetTableAdapters.CategoriesTableAdapter

        Private shippersTableAdapter1 As DevExpress.XtraSankey.Demos.nwindDataSetTableAdapters.ShippersTableAdapter

        Private customersTableAdapter1 As DevExpress.XtraSankey.Demos.nwindDataSetTableAdapters.CustomersTableAdapter

        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private sankeyDiagramControl1 As DevExpress.XtraCharts.Sankey.SankeyDiagramControl

        Private comparerRadioGroup As DevExpress.XtraEditors.RadioGroup

        Private orderRadioGroup As DevExpress.XtraEditors.RadioGroup

        Private layoutControlGroupTotalLabels As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
