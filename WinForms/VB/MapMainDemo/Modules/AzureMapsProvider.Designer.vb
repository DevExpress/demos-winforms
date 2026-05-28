Namespace DevExpress.XtraMap.Demos

    Partial Class AzureMapsProvider

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
            Me.mapControlField = New DevExpress.XtraMap.MapControl()
            Me.imageLayer1 = New DevExpress.XtraMap.ImageLayer()
            Me.sidePanelOptions = New DevExpress.XtraEditors.SidePanel()
            Me.tabPaneOptions = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPageOptions = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.chkShowTerrain = New DevExpress.XtraEditors.CheckEdit()
            Me.additionalLayersRadio = New DevExpress.XtraEditors.RadioGroup()
            Me.appearanceRadio = New DevExpress.XtraEditors.RadioGroup()
            Me.mapStyleRadio = New DevExpress.XtraEditors.RadioGroup()
            Me.weatherLayersRadio = New DevExpress.XtraEditors.RadioGroup()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.additionalLayersGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.additionalLayersItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.mapStyleGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.showTerrainItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.mapStyleItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.weatherLayersGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.weatherLayersItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.appearanceGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.appearanceItem = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mapControlField), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.chkShowTerrain.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.additionalLayersRadio.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.appearanceRadio.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mapStyleRadio.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.weatherLayersRadio.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.additionalLayersGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.additionalLayersItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mapStyleGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.showTerrainItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mapStyleItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.weatherLayersGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.weatherLayersItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.appearanceGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.appearanceItem), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.mapControlField)
            Me.panelControl1.Controls.Add(Me.sidePanelOptions)
            Me.panelControl1.Size = New System.Drawing.Size(686, 602)
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.MaxItemId = 10
            Me.ribbonControl1.Size = New System.Drawing.Size(686, 150)
            ' 
            ' mapControl
            ' 
            Me.mapControlField.CenterPoint = New DevExpress.XtraMap.GeoPoint(47.1R, 11.1R)
            Me.mapControlField.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControlField.Layers.Add(Me.imageLayer1)
            Me.mapControlField.Location = New System.Drawing.Point(0, 0)
            Me.mapControlField.Name = "mapControl"
            Me.mapControlField.Size = New System.Drawing.Size(488, 602)
            Me.mapControlField.TabIndex = 0
            Me.mapControlField.ZoomLevel = 5R
            ' 
            ' sidePanelOptions
            ' 
            Me.sidePanelOptions.AllowResize = False
            Me.sidePanelOptions.Controls.Add(Me.tabPaneOptions)
            Me.sidePanelOptions.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanelOptions.Location = New System.Drawing.Point(488, 0)
            Me.sidePanelOptions.Name = "sidePanelOptions"
            Me.sidePanelOptions.Size = New System.Drawing.Size(198, 602)
            Me.sidePanelOptions.TabIndex = 7
            ' 
            ' tabPaneOptions
            ' 
            Me.tabPaneOptions.Controls.Add(Me.tabNavigationPageOptions)
            Me.tabPaneOptions.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPaneOptions.Location = New System.Drawing.Point(1, 0)
            Me.tabPaneOptions.Name = "tabPaneOptions"
            Me.tabPaneOptions.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPageOptions})
            Me.tabPaneOptions.RegularSize = New System.Drawing.Size(197, 602)
            Me.tabPaneOptions.SelectedPage = Me.tabNavigationPageOptions
            Me.tabPaneOptions.Size = New System.Drawing.Size(197, 602)
            Me.tabPaneOptions.TabIndex = 8
            Me.tabPaneOptions.Text = "tabPane1"
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Caption = "Options"
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPageOptions.Name = "tabNavigationPageOptions"
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(197, 569)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AutoSize = True
            Me.layoutControl1.Controls.Add(Me.chkShowTerrain)
            Me.layoutControl1.Controls.Add(Me.additionalLayersRadio)
            Me.layoutControl1.Controls.Add(Me.appearanceRadio)
            Me.layoutControl1.Controls.Add(Me.mapStyleRadio)
            Me.layoutControl1.Controls.Add(Me.weatherLayersRadio)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(827, 319, 806, 536)
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(197, 392)
            Me.layoutControl1.TabIndex = 2
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' chkShowTerrain
            ' 
            Me.chkShowTerrain.Location = New System.Drawing.Point(11, 80)
            Me.chkShowTerrain.MenuManager = Me
            Me.chkShowTerrain.Name = "chkShowTerrain"
            Me.chkShowTerrain.Properties.Caption = "Show Terrain"
            Me.chkShowTerrain.Size = New System.Drawing.Size(175, 20)
            Me.chkShowTerrain.StyleController = Me.layoutControl1
            Me.chkShowTerrain.TabIndex = 4
            AddHandler Me.chkShowTerrain.CheckedChanged, New System.EventHandler(AddressOf Me.chkShowTerrain_CheckedChanged)
            ' 
            ' additionalLayersRadio
            ' 
            Me.additionalLayersRadio.EditValue = "Labels"
            Me.additionalLayersRadio.Location = New System.Drawing.Point(11, 212)
            Me.additionalLayersRadio.Margin = New System.Windows.Forms.Padding(0)
            Me.additionalLayersRadio.Name = "additionalLayersRadio"
            Me.additionalLayersRadio.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.additionalLayersRadio.Properties.Appearance.Options.UseBackColor = True
            Me.additionalLayersRadio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.additionalLayersRadio.Properties.Columns = 1
            Me.additionalLayersRadio.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("None", "None"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Hybrid Road", "Hybrid Road"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Labels", "Labels")})
            Me.additionalLayersRadio.Properties.Padding = New System.Windows.Forms.Padding(0)
            Me.additionalLayersRadio.Size = New System.Drawing.Size(175, 72)
            Me.additionalLayersRadio.StyleController = Me.layoutControl1
            Me.additionalLayersRadio.TabIndex = 5
            AddHandler Me.additionalLayersRadio.SelectedIndexChanged, New System.EventHandler(AddressOf Me.additionalLayersRadio_SelectedIndexChanged)
            ' 
            ' appearanceRadio
            ' 
            Me.appearanceRadio.EditValue = "Light"
            Me.appearanceRadio.Location = New System.Drawing.Point(11, 132)
            Me.appearanceRadio.Margin = New System.Windows.Forms.Padding(0)
            Me.appearanceRadio.Name = "appearanceRadio"
            Me.appearanceRadio.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.appearanceRadio.Properties.Appearance.Options.UseBackColor = True
            Me.appearanceRadio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.appearanceRadio.Properties.Columns = 1
            Me.appearanceRadio.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Light", "Light"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Dark", "Dark")})
            Me.appearanceRadio.Properties.Padding = New System.Windows.Forms.Padding(0)
            Me.appearanceRadio.Size = New System.Drawing.Size(175, 48)
            Me.appearanceRadio.StyleController = Me.layoutControl1
            Me.appearanceRadio.TabIndex = 7
            AddHandler Me.appearanceRadio.SelectedIndexChanged, New System.EventHandler(AddressOf Me.appearanceRadio_SelectedIndexChanged)
            ' 
            ' mapStyleRadio
            ' 
            Me.mapStyleRadio.EditValue = "Satellite"
            Me.mapStyleRadio.Location = New System.Drawing.Point(11, 28)
            Me.mapStyleRadio.Margin = New System.Windows.Forms.Padding(0)
            Me.mapStyleRadio.Name = "mapStyleRadio"
            Me.mapStyleRadio.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.mapStyleRadio.Properties.Appearance.Options.UseBackColor = True
            Me.mapStyleRadio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mapStyleRadio.Properties.Columns = 1
            Me.mapStyleRadio.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Satellite", "Satellite"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Road", "Road")})
            Me.mapStyleRadio.Properties.Padding = New System.Windows.Forms.Padding(0)
            Me.mapStyleRadio.Size = New System.Drawing.Size(175, 48)
            Me.mapStyleRadio.StyleController = Me.layoutControl1
            Me.mapStyleRadio.TabIndex = 7
            AddHandler Me.mapStyleRadio.SelectedIndexChanged, New System.EventHandler(AddressOf Me.mapStyleRadio_SelectedIndexChanged)
            ' 
            ' weatherLayersRadio
            ' 
            Me.weatherLayersRadio.EditValue = "None"
            Me.weatherLayersRadio.Location = New System.Drawing.Point(11, 316)
            Me.weatherLayersRadio.Margin = New System.Windows.Forms.Padding(0)
            Me.weatherLayersRadio.Name = "weatherLayersRadio"
            Me.weatherLayersRadio.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.weatherLayersRadio.Properties.Appearance.Options.UseBackColor = True
            Me.weatherLayersRadio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.weatherLayersRadio.Properties.Columns = 1
            Me.weatherLayersRadio.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("None", "None"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Radar", "Radar"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Infrared", "Infrared")})
            Me.weatherLayersRadio.Properties.Padding = New System.Windows.Forms.Padding(0)
            Me.weatherLayersRadio.Size = New System.Drawing.Size(175, 72)
            Me.weatherLayersRadio.StyleController = Me.layoutControl1
            Me.weatherLayersRadio.TabIndex = 7
            AddHandler Me.weatherLayersRadio.SelectedIndexChanged, New System.EventHandler(AddressOf Me.weatherLayersRadio_SelectedIndexChanged)
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.additionalLayersGroup, Me.mapStyleGroup, Me.weatherLayersGroup, Me.appearanceGroup})
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.Root.Size = New System.Drawing.Size(197, 392)
            Me.Root.TextVisible = False
            ' 
            ' additionalLayersGroup
            ' 
            Me.additionalLayersGroup.CustomizationFormText = "additionalLayersGroup"
            Me.additionalLayersGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.additionalLayersGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.additionalLayersItem})
            Me.additionalLayersGroup.Location = New System.Drawing.Point(0, 184)
            Me.additionalLayersGroup.Name = "additionalLayersGroup"
            Me.additionalLayersGroup.Padding = New DevExpress.XtraLayout.Utils.Padding(9, 9, 4, 2)
            Me.additionalLayersGroup.Size = New System.Drawing.Size(197, 104)
            Me.additionalLayersGroup.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.additionalLayersGroup.Text = "Additional Layers"
            ' 
            ' additionalLayersItem
            ' 
            Me.additionalLayersItem.Control = Me.additionalLayersRadio
            Me.additionalLayersItem.Location = New System.Drawing.Point(0, 0)
            Me.additionalLayersItem.Name = "additionalLayersItem"
            Me.additionalLayersItem.Size = New System.Drawing.Size(179, 76)
            Me.additionalLayersItem.TextSize = New System.Drawing.Size(0, 0)
            Me.additionalLayersItem.TextVisible = False
            ' 
            ' mapStyleGroup
            ' 
            Me.mapStyleGroup.CustomizationFormText = "mapStyleGroup"
            Me.mapStyleGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.mapStyleGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.showTerrainItem, Me.mapStyleItem})
            Me.mapStyleGroup.Location = New System.Drawing.Point(0, 0)
            Me.mapStyleGroup.Name = "mapStyleGroup"
            Me.mapStyleGroup.Padding = New DevExpress.XtraLayout.Utils.Padding(9, 9, 4, 2)
            Me.mapStyleGroup.Size = New System.Drawing.Size(197, 104)
            Me.mapStyleGroup.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.mapStyleGroup.Text = "Map Style"
            ' 
            ' showTerrainItem
            ' 
            Me.showTerrainItem.Control = Me.chkShowTerrain
            Me.showTerrainItem.Location = New System.Drawing.Point(0, 52)
            Me.showTerrainItem.Name = "showTerrainItem"
            Me.showTerrainItem.Size = New System.Drawing.Size(179, 24)
            Me.showTerrainItem.TextSize = New System.Drawing.Size(0, 0)
            Me.showTerrainItem.TextVisible = False
            ' 
            ' mapStyleItem
            ' 
            Me.mapStyleItem.Control = Me.mapStyleRadio
            Me.mapStyleItem.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.mapStyleItem.CustomizationFormText = "weatherLayersItem"
            Me.mapStyleItem.Location = New System.Drawing.Point(0, 0)
            Me.mapStyleItem.Name = "mapStyleItem"
            Me.mapStyleItem.Size = New System.Drawing.Size(179, 52)
            Me.mapStyleItem.Text = "weatherLayersItem"
            Me.mapStyleItem.TextVisible = False
            ' 
            ' weatherLayersGroup
            ' 
            Me.weatherLayersGroup.CustomizationFormText = "weatherLayersGroup"
            Me.weatherLayersGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.weatherLayersGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.weatherLayersItem})
            Me.weatherLayersGroup.Location = New System.Drawing.Point(0, 288)
            Me.weatherLayersGroup.Name = "weatherLayersGroup"
            Me.weatherLayersGroup.Padding = New DevExpress.XtraLayout.Utils.Padding(9, 9, 4, 2)
            Me.weatherLayersGroup.Size = New System.Drawing.Size(197, 104)
            Me.weatherLayersGroup.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.weatherLayersGroup.Text = "Weather"
            ' 
            ' weatherLayersItem
            ' 
            Me.weatherLayersItem.Control = Me.weatherLayersRadio
            Me.weatherLayersItem.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.weatherLayersItem.Location = New System.Drawing.Point(0, 0)
            Me.weatherLayersItem.Name = "weatherLayersItem"
            Me.weatherLayersItem.Size = New System.Drawing.Size(179, 76)
            Me.weatherLayersItem.TextVisible = False
            ' 
            ' appearanceGroup
            ' 
            Me.appearanceGroup.BestFitWeight = 0
            Me.appearanceGroup.CustomizationFormText = "appearanceGroup"
            Me.appearanceGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.appearanceGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.appearanceItem})
            Me.appearanceGroup.Location = New System.Drawing.Point(0, 104)
            Me.appearanceGroup.Name = "appearanceGroup"
            Me.appearanceGroup.Padding = New DevExpress.XtraLayout.Utils.Padding(9, 9, 4, 2)
            Me.appearanceGroup.Size = New System.Drawing.Size(197, 80)
            Me.appearanceGroup.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.appearanceGroup.Text = "Appearance"
            ' 
            ' appearanceItem
            ' 
            Me.appearanceItem.Control = Me.appearanceRadio
            Me.appearanceItem.Location = New System.Drawing.Point(0, 0)
            Me.appearanceItem.Name = "appearanceItem"
            Me.appearanceItem.Size = New System.Drawing.Size(179, 52)
            Me.appearanceItem.TextSize = New System.Drawing.Size(0, 0)
            Me.appearanceItem.TextVisible = False
            ' 
            ' AzureMapsProvider
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "AzureMapsProvider"
            Me.Size = New System.Drawing.Size(686, 770)
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mapControlField), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.PerformLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.chkShowTerrain.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.additionalLayersRadio.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.appearanceRadio.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mapStyleRadio.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.weatherLayersRadio.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.additionalLayersGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.additionalLayersItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mapStyleGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.showTerrainItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mapStyleItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.weatherLayersGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.weatherLayersItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.appearanceGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.appearanceItem), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private mapControlField As DevExpress.XtraMap.MapControl

        Private imageLayer1 As DevExpress.XtraMap.ImageLayer

        Protected sidePanelOptions As DevExpress.XtraEditors.SidePanel

        Protected tabPaneOptions As DevExpress.XtraBars.Navigation.TabPane

        Protected tabNavigationPageOptions As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private mapStyleGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private mapStyleItem As DevExpress.XtraLayout.LayoutControlItem

        Private mapStyleRadio As DevExpress.XtraEditors.RadioGroup

        Private showTerrainItem As DevExpress.XtraLayout.LayoutControlItem

        Private chkShowTerrain As DevExpress.XtraEditors.CheckEdit

        Private appearanceGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private appearanceItem As DevExpress.XtraLayout.LayoutControlItem

        Private appearanceRadio As DevExpress.XtraEditors.RadioGroup

        Private additionalLayersGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private additionalLayersItem As DevExpress.XtraLayout.LayoutControlItem

        Private additionalLayersRadio As DevExpress.XtraEditors.RadioGroup

        Private weatherLayersGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private weatherLayersItem As DevExpress.XtraLayout.LayoutControlItem

        Private weatherLayersRadio As DevExpress.XtraEditors.RadioGroup
    End Class
End Namespace
