Namespace DevExpress.XtraTreeMap.Demos

    Partial Class SunburstHierarchicalData

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

#Region "InitializeComponent"
        Private Overloads Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim sunburstHierarchicalDataAdapter1 As DevExpress.XtraTreeMap.SunburstHierarchicalDataAdapter = New DevExpress.XtraTreeMap.SunburstHierarchicalDataAdapter()
            Dim sunburstHierarchicalDataMapping1 As DevExpress.XtraTreeMap.SunburstHierarchicalDataMapping = New DevExpress.XtraTreeMap.SunburstHierarchicalDataMapping()
            Me.sunburstControl1 = New DevExpress.XtraTreeMap.SunburstControl()
            Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.colorizerCBE = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.varyColorInGroupCE = New DevExpress.XtraEditors.CheckEdit()
            Me.modeCBE = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroupInteraction1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.colorizerLCI1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.varyColorInGroupLCI = New DevExpress.XtraLayout.LayoutControlItem()
            Me.modeLCI = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.sunburstControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.colorizerCBE.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.varyColorInGroupCE.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.modeCBE.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupInteraction1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.colorizerLCI1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.varyColorInGroupLCI), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.modeLCI), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(241, 538)
            ' 
            ' sunburstControl1
            ' 
            Me.sunburstControl1.BorderOptions.Color = System.Drawing.Color.FromArgb((CInt(((CByte((157)))))), (CInt(((CByte((160)))))), (CInt(((CByte((170)))))))
            Me.sunburstControl1.CenterLabel.TextPattern = "Type Count in XtraBars : {TV}"
            sunburstHierarchicalDataMapping1.ChildrenDataMember = "NestedNamespaces"
            sunburstHierarchicalDataMapping1.LabelDataMember = "NamespaceString"
            sunburstHierarchicalDataMapping1.ValueDataMember = "TypesCount"
            sunburstHierarchicalDataAdapter1.Mappings.Add(sunburstHierarchicalDataMapping1)
            Me.sunburstControl1.DataAdapter = sunburstHierarchicalDataAdapter1
            Me.sunburstControl1.HoleRadiusPercent = 25
            Me.sunburstControl1.Location = New System.Drawing.Point(0, 0)
            Me.sunburstControl1.Name = "sunburstControl1"
            Me.sunburstControl1.Padding = New System.Windows.Forms.Padding(2)
            Me.sunburstControl1.Size = New System.Drawing.Size(546, 571)
            Me.sunburstControl1.TabIndex = 0
            Me.sunburstControl1.ToolTipController = Me.toolTipController1
            ' 
            ' toolTipController1
            ' 
            AddHandler Me.toolTipController1.BeforeShow, New DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(AddressOf Me.ToolTipController_BeforeShow)
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.colorizerCBE)
            Me.layoutControl.Controls.Add(Me.varyColorInGroupCE)
            Me.layoutControl.Controls.Add(Me.modeCBE)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.Root = Me.layoutControlGroupRoot
            Me.layoutControl.Size = New System.Drawing.Size(241, 538)
            Me.layoutControl.TabIndex = 4
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' colorizerCBE
            ' 
            Me.colorizerCBE.Location = New System.Drawing.Point(66, 12)
            Me.colorizerCBE.Name = "colorizerCBE"
            Me.colorizerCBE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.colorizerCBE.Properties.Items.AddRange(New Object() {"Palette Colorizer", "Gradient Colorizer"})
            Me.colorizerCBE.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.colorizerCBE.Size = New System.Drawing.Size(163, 20)
            Me.colorizerCBE.StyleController = Me.layoutControl
            Me.colorizerCBE.TabIndex = 8
            ' 
            ' varyColorInGroupCE
            ' 
            Me.varyColorInGroupCE.Location = New System.Drawing.Point(12, 36)
            Me.varyColorInGroupCE.Margin = New System.Windows.Forms.Padding(10, 10, 0, 0)
            Me.varyColorInGroupCE.Name = "varyColorInGroupCE"
            Me.varyColorInGroupCE.Properties.AutoWidth = True
            Me.varyColorInGroupCE.Properties.Caption = "Vary Color In Group"
            Me.varyColorInGroupCE.Size = New System.Drawing.Size(118, 20)
            Me.varyColorInGroupCE.StyleController = Me.layoutControl
            Me.varyColorInGroupCE.TabIndex = 7
            ' 
            ' modeCBE
            ' 
            Me.modeCBE.EditValue = "By Group Level"
            Me.modeCBE.Location = New System.Drawing.Point(66, 60)
            Me.modeCBE.Name = "modeCBE"
            Me.modeCBE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.modeCBE.Properties.Items.AddRange(New Object() {"By Group Level", "By Item Index"})
            Me.modeCBE.Size = New System.Drawing.Size(163, 20)
            Me.modeCBE.StyleController = Me.layoutControl
            Me.modeCBE.TabIndex = 9
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem, Me.layoutControlGroupInteraction1})
            Me.layoutControlGroupRoot.Name = "Root"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(241, 538)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' emptySpaceItem
            ' 
            Me.emptySpaceItem.AllowHotTrack = False
            Me.emptySpaceItem.Location = New System.Drawing.Point(0, 92)
            Me.emptySpaceItem.Name = "emptySpaceItem"
            Me.emptySpaceItem.Size = New System.Drawing.Size(241, 446)
            Me.emptySpaceItem.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlGroupInteraction1
            ' 
            Me.layoutControlGroupInteraction1.CustomizationFormText = "Group settings"
            Me.layoutControlGroupInteraction1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupInteraction1.GroupBordersVisible = False
            Me.layoutControlGroupInteraction1.GroupStyle = DevExpress.Utils.GroupStyle.Light
            Me.layoutControlGroupInteraction1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.colorizerLCI1, Me.varyColorInGroupLCI, Me.modeLCI})
            Me.layoutControlGroupInteraction1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupInteraction1.Name = "layoutControlGroupInteraction1"
            Me.layoutControlGroupInteraction1.Size = New System.Drawing.Size(241, 92)
            Me.layoutControlGroupInteraction1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupInteraction1.Text = "Group settings"
            Me.layoutControlGroupInteraction1.TextVisible = False
            ' 
            ' colorizerLCI1
            ' 
            Me.colorizerLCI1.Control = Me.colorizerCBE
            Me.colorizerLCI1.CustomizationFormText = "Colorizer"
            Me.colorizerLCI1.Location = New System.Drawing.Point(0, 0)
            Me.colorizerLCI1.Name = "colorizerLCI1"
            Me.colorizerLCI1.Size = New System.Drawing.Size(221, 24)
            Me.colorizerLCI1.Text = "Colorizer"
            Me.colorizerLCI1.TextSize = New System.Drawing.Size(42, 13)
            ' 
            ' varyColorInGroupLCI
            ' 
            Me.varyColorInGroupLCI.Control = Me.varyColorInGroupCE
            Me.varyColorInGroupLCI.CustomizationFormText = "varyColorInGroupLCI"
            Me.varyColorInGroupLCI.Location = New System.Drawing.Point(0, 24)
            Me.varyColorInGroupLCI.Name = "varyColorInGroupLCI"
            Me.varyColorInGroupLCI.Size = New System.Drawing.Size(221, 24)
            Me.varyColorInGroupLCI.TextSize = New System.Drawing.Size(0, 0)
            Me.varyColorInGroupLCI.TextVisible = False
            ' 
            ' modeLCI
            ' 
            Me.modeLCI.Control = Me.modeCBE
            Me.modeLCI.CustomizationFormText = "Mode"
            Me.modeLCI.Location = New System.Drawing.Point(0, 48)
            Me.modeLCI.Name = "modeLCI"
            Me.modeLCI.Size = New System.Drawing.Size(221, 24)
            Me.modeLCI.Text = "Mode"
            Me.modeLCI.TextSize = New System.Drawing.Size(42, 13)
            Me.modeLCI.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.sunburstControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(593, 306, 650, 400)
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(546, 571)
            Me.layoutControl1.TabIndex = 1
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.Root.Size = New System.Drawing.Size(546, 571)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.sunburstControl1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(546, 571)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' SunburstHierarchicalData
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "SunburstHierarchicalData"
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.Controls.SetChildIndex(Me.layoutControl1, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((Me.sunburstControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.colorizerCBE.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.varyColorInGroupCE.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.modeCBE.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupInteraction1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.colorizerLCI1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.varyColorInGroupLCI), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.modeLCI), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private sunburstControl1 As DevExpress.XtraTreeMap.SunburstControl

        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private toolTipController1 As DevExpress.Utils.ToolTipController

        Private colorizerCBE As DevExpress.XtraEditors.ComboBoxEdit

        Private varyColorInGroupCE As DevExpress.XtraEditors.CheckEdit

        Private modeCBE As DevExpress.XtraEditors.ComboBoxEdit

        Private emptySpaceItem As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroupInteraction1 As DevExpress.XtraLayout.LayoutControlGroup

        Private colorizerLCI1 As DevExpress.XtraLayout.LayoutControlItem

        Private varyColorInGroupLCI As DevExpress.XtraLayout.LayoutControlItem

        Private modeLCI As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
