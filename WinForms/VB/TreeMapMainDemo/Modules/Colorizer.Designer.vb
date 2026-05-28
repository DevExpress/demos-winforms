Namespace DevExpress.XtraTreeMap.Demos

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
            Dim treeMapPaletteColorizer1 As DevExpress.XtraTreeMap.TreeMapPaletteColorizer = New DevExpress.XtraTreeMap.TreeMapPaletteColorizer()
            Dim treeMapFlatDataAdapter1 As DevExpress.XtraTreeMap.TreeMapFlatDataAdapter = New DevExpress.XtraTreeMap.TreeMapFlatDataAdapter()
            Dim colorListLegend1 As DevExpress.XtraTreeMap.ColorListLegend = New DevExpress.XtraTreeMap.ColorListLegend()
            Dim title1 As DevExpress.XtraTreeMap.Title = New DevExpress.XtraTreeMap.Title()
            Me.treeMapControl1 = New DevExpress.XtraTreeMap.TreeMapControl()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.colorizerCBE = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.enableGroupingCE = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroupInteraction = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.colorizerLCI = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemAllowAnchoring = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.treeMapControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.colorizerCBE.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.enableGroupingCE.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupInteraction), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.colorizerLCI), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemAllowAnchoring), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' tabPaneOptions
            ' 
            Me.tabPaneOptions.Margin = New System.Windows.Forms.Padding(2)
            Me.tabPaneOptions.RegularSize = New System.Drawing.Size(322, 747)
            Me.tabPaneOptions.Size = New System.Drawing.Size(322, 747)
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl)
            Me.tabNavigationPageOptions.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(322, 706)
            ' 
            ' treeMapControl1
            ' 
            Me.treeMapControl1.Appearance.GroupStyle.HeaderPadding = New DevExpress.XtraTreeMap.TreeMapPadding(4, 0, 4, 4)
            Me.treeMapControl1.Appearance.GroupStyle.SubGroupHeaderPadding = New DevExpress.XtraTreeMap.TreeMapPadding(4)
            Me.treeMapControl1.BorderOptions.Color = System.Drawing.Color.FromArgb((CInt(((CByte((157)))))), (CInt(((CByte((160)))))), (CInt(((CByte((170)))))))
            Me.treeMapControl1.BorderOptions.Thickness = 2
            Me.treeMapControl1.BorderOptions.Visible = False
            Me.treeMapControl1.Colorizer = treeMapPaletteColorizer1
            treeMapFlatDataAdapter1.DataMember = Nothing
            treeMapFlatDataAdapter1.GroupDataMembersSerializable = "FieldOfActivity"
            treeMapFlatDataAdapter1.LabelDataMember = "CompanyName"
            treeMapFlatDataAdapter1.ValueDataMember = "Assets"
            Me.treeMapControl1.DataAdapter = treeMapFlatDataAdapter1
            Me.treeMapControl1.Legend = colorListLegend1
            Me.treeMapControl1.Location = New System.Drawing.Point(0, 0)
            Me.treeMapControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.treeMapControl1.Name = "treeMapControl1"
            Me.treeMapControl1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
            Me.treeMapControl1.Size = New System.Drawing.Size(728, 747)
            Me.treeMapControl1.TabIndex = 0
            title1.Indent = 0
            title1.Text = "US Largest Companies 2011"
            Me.treeMapControl1.Titles.Add(title1)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.treeMapControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(728, 747)
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
            Me.Root.Size = New System.Drawing.Size(728, 747)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.treeMapControl1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(728, 747)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.colorizerCBE)
            Me.layoutControl.Controls.Add(Me.enableGroupingCE)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.Root = Me.layoutControlGroupRoot
            Me.layoutControl.Size = New System.Drawing.Size(322, 706)
            Me.layoutControl.TabIndex = 2
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' colorizerCBE
            ' 
            Me.colorizerCBE.EditValue = "Palette Colorizer"
            Me.colorizerCBE.Location = New System.Drawing.Point(83, 46)
            Me.colorizerCBE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.colorizerCBE.Name = "colorizerCBE"
            Me.colorizerCBE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.colorizerCBE.Properties.Items.AddRange(New Object() {"Palette Colorizer", "Range Colorizer", "Gradient Colorizer", "Group Gradient Colorizer"})
            Me.colorizerCBE.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.colorizerCBE.Size = New System.Drawing.Size(223, 22)
            Me.colorizerCBE.StyleController = Me.layoutControl
            Me.colorizerCBE.TabIndex = 8
            AddHandler Me.colorizerCBE.SelectedIndexChanged, New System.EventHandler(AddressOf Me.colorizerCBE_SelectedIndexChanged)
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
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(322, 706)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' layoutControlGroupInteraction
            ' 
            Me.layoutControlGroupInteraction.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupInteraction.GroupBordersVisible = False
            Me.layoutControlGroupInteraction.GroupStyle = DevExpress.Utils.GroupStyle.Light
            Me.layoutControlGroupInteraction.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.colorizerLCI, Me.layoutControlItemAllowAnchoring})
            Me.layoutControlGroupInteraction.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupInteraction.Name = "layoutControlGroupInteraction"
            Me.layoutControlGroupInteraction.Size = New System.Drawing.Size(322, 84)
            Me.layoutControlGroupInteraction.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupInteraction.Text = "Group settings"
            Me.layoutControlGroupInteraction.TextVisible = False
            ' 
            ' colorizerLCI
            ' 
            Me.colorizerLCI.Control = Me.colorizerCBE
            Me.colorizerLCI.Location = New System.Drawing.Point(0, 30)
            Me.colorizerLCI.Name = "colorizerLCI"
            Me.colorizerLCI.Size = New System.Drawing.Size(296, 28)
            Me.colorizerLCI.Text = "Colorizer"
            Me.colorizerLCI.TextSize = New System.Drawing.Size(51, 16)
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
            Me.emptySpaceItem.Size = New System.Drawing.Size(322, 622)
            Me.emptySpaceItem.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' Colorizer
            ' 
            Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 17F)
            Me.Controls.Add(Me.layoutControl1)
            Me.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
            Me.Name = "Colorizer"
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.Controls.SetChildIndex(Me.layoutControl1, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((Me.treeMapControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.colorizerCBE.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.enableGroupingCE.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupInteraction), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.colorizerLCI), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemAllowAnchoring), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private treeMapControl1 As DevExpress.XtraTreeMap.TreeMapControl

        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private colorizerCBE As DevExpress.XtraEditors.ComboBoxEdit

        Private enableGroupingCE As DevExpress.XtraEditors.CheckEdit

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroupInteraction As DevExpress.XtraLayout.LayoutControlGroup

        Private colorizerLCI As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemAllowAnchoring As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
