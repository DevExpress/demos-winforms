Namespace DevExpress.XtraTreeMap.Demos

    Partial Class Grouping

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
            Dim treeMapPaletteColorizer1 As DevExpress.XtraTreeMap.TreeMapPaletteColorizer = New DevExpress.XtraTreeMap.TreeMapPaletteColorizer()
            Dim treeMapFlatDataAdapter1 As DevExpress.XtraTreeMap.TreeMapFlatDataAdapter = New DevExpress.XtraTreeMap.TreeMapFlatDataAdapter()
            Dim title1 As DevExpress.XtraTreeMap.Title = New DevExpress.XtraTreeMap.Title()
            Me.treeMapControl1 = New DevExpress.XtraTreeMap.TreeMapControl()
            Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.groupByCBE = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.enableGroupingCE = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroupInteraction = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.groupByLCI = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemAllowAnchoring = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.treeMapControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.groupByCBE.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.enableGroupingCE.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupInteraction), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupByLCI), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemAllowAnchoring), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' sidePanelOptions
            ' 
            Me.sidePanelOptions.Location = New System.Drawing.Point(728, 10)
            Me.sidePanelOptions.Size = New System.Drawing.Size(323, 737)
            ' 
            ' tabPaneOptions
            ' 
            Me.tabPaneOptions.Margin = New System.Windows.Forms.Padding(2)
            Me.tabPaneOptions.RegularSize = New System.Drawing.Size(322, 737)
            Me.tabPaneOptions.Size = New System.Drawing.Size(322, 737)
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl)
            Me.tabNavigationPageOptions.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(322, 696)
            ' 
            ' treeMapControl1
            ' 
            Me.treeMapControl1.BorderOptions.Color = System.Drawing.Color.FromArgb((CInt(((CByte((157)))))), (CInt(((CByte((160)))))), (CInt(((CByte((170)))))))
            Me.treeMapControl1.BorderOptions.Thickness = 2
            Me.treeMapControl1.BorderOptions.Visible = False
            Me.treeMapControl1.Colorizer = treeMapPaletteColorizer1
            treeMapFlatDataAdapter1.DataMember = Nothing
            treeMapFlatDataAdapter1.LabelDataMember = "Name"
            treeMapFlatDataAdapter1.ValueDataMember = "NetWorth"
            Me.treeMapControl1.DataAdapter = treeMapFlatDataAdapter1
            Me.treeMapControl1.Location = New System.Drawing.Point(0, 0)
            Me.treeMapControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.treeMapControl1.Name = "treeMapControl1"
            Me.treeMapControl1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
            Me.treeMapControl1.Size = New System.Drawing.Size(728, 737)
            Me.treeMapControl1.TabIndex = 0
            title1.Indent = 0
            title1.Text = "Forbes World's Billionaires 2010"
            Me.treeMapControl1.Titles.Add(title1)
            Me.treeMapControl1.ToolTipController = Me.toolTipController1
            Me.treeMapControl1.ToolTipGroupPattern = "{L}: {V}B$"
            Me.treeMapControl1.ToolTipLeafPattern = "{L}: {V}B$"
            ' 
            ' toolTipController1
            ' 
            Me.toolTipController1.Appearance.Options.UseTextOptions = True
            Me.toolTipController1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None
            Me.toolTipController1.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip
            AddHandler Me.toolTipController1.BeforeShow, New DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(AddressOf Me.toolTipController1_BeforeShow)
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.groupByCBE)
            Me.layoutControl.Controls.Add(Me.enableGroupingCE)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.Root = Me.layoutControlGroupRoot
            Me.layoutControl.Size = New System.Drawing.Size(322, 696)
            Me.layoutControl.TabIndex = 1
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' groupByCBE
            ' 
            Me.groupByCBE.Location = New System.Drawing.Point(83, 46)
            Me.groupByCBE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.groupByCBE.Name = "groupByCBE"
            Me.groupByCBE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.groupByCBE.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.groupByCBE.Size = New System.Drawing.Size(223, 22)
            Me.groupByCBE.StyleController = Me.layoutControl
            Me.groupByCBE.TabIndex = 8
            AddHandler Me.groupByCBE.EditValueChanged, New System.EventHandler(AddressOf Me.groupByCBE_EditValueChanged)
            ' 
            ' enableGroupingCE
            ' 
            Me.enableGroupingCE.EditValue = True
            Me.enableGroupingCE.Location = New System.Drawing.Point(16, 16)
            Me.enableGroupingCE.Margin = New System.Windows.Forms.Padding(13, 13, 0, 0)
            Me.enableGroupingCE.Name = "enableGroupingCE"
            Me.enableGroupingCE.Properties.AutoWidth = True
            Me.enableGroupingCE.Properties.Caption = "Enable Grouping"
            Me.enableGroupingCE.Size = New System.Drawing.Size(121, 24)
            Me.enableGroupingCE.StyleController = Me.layoutControl
            Me.enableGroupingCE.TabIndex = 7
            AddHandler Me.enableGroupingCE.CheckedChanged, New System.EventHandler(AddressOf Me.enableGroupingCE_CheckedChanged)
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroupInteraction, Me.emptySpaceItem})
            Me.layoutControlGroupRoot.Name = "Root"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(322, 696)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' layoutControlGroupInteraction
            ' 
            Me.layoutControlGroupInteraction.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupInteraction.GroupBordersVisible = False
            Me.layoutControlGroupInteraction.GroupStyle = DevExpress.Utils.GroupStyle.Light
            Me.layoutControlGroupInteraction.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.groupByLCI, Me.layoutControlItemAllowAnchoring})
            Me.layoutControlGroupInteraction.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupInteraction.Name = "layoutControlGroupInteraction"
            Me.layoutControlGroupInteraction.Size = New System.Drawing.Size(322, 84)
            Me.layoutControlGroupInteraction.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupInteraction.Text = "Group settings"
            Me.layoutControlGroupInteraction.TextVisible = False
            ' 
            ' groupByLCI
            ' 
            Me.groupByLCI.Control = Me.groupByCBE
            Me.groupByLCI.Location = New System.Drawing.Point(0, 30)
            Me.groupByLCI.Name = "groupByLCI"
            Me.groupByLCI.Size = New System.Drawing.Size(296, 28)
            Me.groupByLCI.Text = "Group By"
            Me.groupByLCI.TextSize = New System.Drawing.Size(51, 16)
            ' 
            ' layoutControlItemAllowAnchoring
            ' 
            Me.layoutControlItemAllowAnchoring.Control = Me.enableGroupingCE
            Me.layoutControlItemAllowAnchoring.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemAllowAnchoring.Name = "layoutControlItemAllowAnchoring"
            Me.layoutControlItemAllowAnchoring.Size = New System.Drawing.Size(296, 30)
            Me.layoutControlItemAllowAnchoring.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemAllowAnchoring.TextVisible = False
            ' 
            ' emptySpaceItem
            ' 
            Me.emptySpaceItem.AllowHotTrack = False
            Me.emptySpaceItem.Location = New System.Drawing.Point(0, 84)
            Me.emptySpaceItem.Name = "emptySpaceItem"
            Me.emptySpaceItem.Size = New System.Drawing.Size(322, 612)
            Me.emptySpaceItem.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.treeMapControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 10)
            Me.layoutControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(593, 306, 650, 400)
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(728, 737)
            Me.layoutControl1.TabIndex = 1
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.GroupStyle = DevExpress.Utils.GroupStyle.Light
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.Root.Size = New System.Drawing.Size(728, 737)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.treeMapControl1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(728, 737)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' Grouping
            ' 
            Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 17F)
            Me.Controls.Add(Me.layoutControl1)
            Me.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
            Me.Name = "Grouping"
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.Controls.SetChildIndex(Me.layoutControl1, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((Me.treeMapControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.groupByCBE.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.enableGroupingCE.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupInteraction), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupByLCI), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemAllowAnchoring), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private treeMapControl1 As DevExpress.XtraTreeMap.TreeMapControl

        Private toolTipController1 As DevExpress.Utils.ToolTipController

        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private enableGroupingCE As DevExpress.XtraEditors.CheckEdit

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroupInteraction As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemAllowAnchoring As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem As DevExpress.XtraLayout.EmptySpaceItem

        Private groupByCBE As DevExpress.XtraEditors.ComboBoxEdit

        Private groupByLCI As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
