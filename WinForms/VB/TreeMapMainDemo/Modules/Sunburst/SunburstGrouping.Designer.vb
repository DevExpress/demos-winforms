Namespace DevExpress.XtraTreeMap.Demos

    Partial Class SunburstGrouping

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
            Dim sunburstFlatDataAdapter1 As DevExpress.XtraTreeMap.SunburstFlatDataAdapter = New DevExpress.XtraTreeMap.SunburstFlatDataAdapter()
            Dim colorListLegend1 As DevExpress.XtraTreeMap.ColorListLegend = New DevExpress.XtraTreeMap.ColorListLegend()
            Me.sunburstControl1 = New DevExpress.XtraTreeMap.SunburstControl()
            Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.displayModeCBE = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.autoLayoutCE = New DevExpress.XtraEditors.CheckEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroupInteraction1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.displayModeLCI1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.varyColorInGroupLCI = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.sunburstControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.displayModeCBE.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.autoLayoutCE.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupInteraction1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.displayModeLCI1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.varyColorInGroupLCI), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' tabPaneOptions
            ' 
            Me.tabPaneOptions.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPageOptions.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(241, 538)
            ' 
            ' sunburstControl1
            ' 
            Me.sunburstControl1.BorderOptions.Color = System.Drawing.Color.FromArgb((CInt(((CByte((157)))))), (CInt(((CByte((160)))))), (CInt(((CByte((170)))))))
            Me.sunburstControl1.BorderOptions.Thickness = 2
            Me.sunburstControl1.CenterLabel.TextPattern = "Periodic Table"
            sunburstFlatDataAdapter1.GroupDataMembersSerializable = "Block;Family;"
            sunburstFlatDataAdapter1.LabelDataMember = "Symbol"
            sunburstFlatDataAdapter1.ValueDataMember = "FakeValue"
            Me.sunburstControl1.DataAdapter = sunburstFlatDataAdapter1
            Me.sunburstControl1.Dock = System.Windows.Forms.DockStyle.Fill
            colorListLegend1.Title.Font = New System.Drawing.Font("Tahoma", 10F)
            colorListLegend1.Title.Text = "Chemical Element Block"
            Me.sunburstControl1.Legend = colorListLegend1
            Me.sunburstControl1.Location = New System.Drawing.Point(0, 0)
            Me.sunburstControl1.MaxVisibleLevel = 5
            Me.sunburstControl1.Name = "sunburstControl1"
            Me.sunburstControl1.Padding = New System.Windows.Forms.Padding(20, 20, 20, 20)
            Me.sunburstControl1.Size = New System.Drawing.Size(546, 571)
            Me.sunburstControl1.TabIndex = 1
            Me.sunburstControl1.ToolTipController = Me.toolTipController1
            Me.sunburstControl1.ToolTipTextPattern = "{L}: {V}MB"
            ' 
            ' toolTipController1
            ' 
            Me.toolTipController1.AutoPopDelay = 50000
            AddHandler Me.toolTipController1.BeforeShow, New DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(AddressOf Me.toolTipController1_BeforeShow)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.displayModeCBE)
            Me.layoutControl1.Controls.Add(Me.autoLayoutCE)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(241, 538)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' displayModeCBE
            ' 
            Me.displayModeCBE.Location = New System.Drawing.Point(105, 7)
            Me.displayModeCBE.Name = "displayModeCBE"
            Me.displayModeCBE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.displayModeCBE.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.displayModeCBE.Size = New System.Drawing.Size(129, 20)
            Me.displayModeCBE.StyleController = Me.layoutControl1
            Me.displayModeCBE.TabIndex = 8
            AddHandler Me.displayModeCBE.SelectedIndexChanged, New System.EventHandler(AddressOf Me.displayModeCBE_SelectedIndexChanged)
            ' 
            ' autoLayoutCE
            ' 
            Me.autoLayoutCE.EditValue = True
            Me.autoLayoutCE.Location = New System.Drawing.Point(7, 29)
            Me.autoLayoutCE.Margin = New System.Windows.Forms.Padding(10, 10, 0, 0)
            Me.autoLayoutCE.Name = "autoLayoutCE"
            Me.autoLayoutCE.Properties.AutoWidth = True
            Me.autoLayoutCE.Properties.Caption = "Auto Layout"
            Me.autoLayoutCE.Size = New System.Drawing.Size(82, 20)
            Me.autoLayoutCE.StyleController = Me.layoutControl1
            Me.autoLayoutCE.TabIndex = 7
            AddHandler Me.autoLayoutCE.CheckedChanged, New System.EventHandler(AddressOf Me.autoLayoutCE_CheckedChanged)
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem, Me.layoutControlGroupInteraction1})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(241, 538)
            Me.Root.TextVisible = False
            ' 
            ' emptySpaceItem
            ' 
            Me.emptySpaceItem.AllowHotTrack = False
            Me.emptySpaceItem.CustomizationFormText = "emptySpaceItem"
            Me.emptySpaceItem.Location = New System.Drawing.Point(0, 44)
            Me.emptySpaceItem.Name = "emptySpaceItem"
            Me.emptySpaceItem.Size = New System.Drawing.Size(229, 482)
            Me.emptySpaceItem.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlGroupInteraction1
            ' 
            Me.layoutControlGroupInteraction1.CustomizationFormText = "Group settings"
            Me.layoutControlGroupInteraction1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupInteraction1.GroupBordersVisible = False
            Me.layoutControlGroupInteraction1.GroupStyle = DevExpress.Utils.GroupStyle.Light
            Me.layoutControlGroupInteraction1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.displayModeLCI1, Me.varyColorInGroupLCI})
            Me.layoutControlGroupInteraction1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupInteraction1.Name = "layoutControlGroupInteraction1"
            Me.layoutControlGroupInteraction1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupInteraction1.Size = New System.Drawing.Size(229, 44)
            Me.layoutControlGroupInteraction1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupInteraction1.Text = "Group settings"
            Me.layoutControlGroupInteraction1.TextVisible = False
            ' 
            ' displayModeLCI1
            ' 
            Me.displayModeLCI1.Control = Me.displayModeCBE
            Me.displayModeLCI1.CustomizationFormText = "Colorizer"
            Me.displayModeLCI1.Location = New System.Drawing.Point(0, 0)
            Me.displayModeLCI1.Name = "displayModeLCI1"
            Me.displayModeLCI1.Size = New System.Drawing.Size(229, 22)
            Me.displayModeLCI1.Text = "Label Display Mode"
            Me.displayModeLCI1.TextSize = New System.Drawing.Size(91, 13)
            ' 
            ' varyColorInGroupLCI
            ' 
            Me.varyColorInGroupLCI.Control = Me.autoLayoutCE
            Me.varyColorInGroupLCI.CustomizationFormText = "varyColorInGroupLCI"
            Me.varyColorInGroupLCI.Location = New System.Drawing.Point(0, 22)
            Me.varyColorInGroupLCI.Name = "varyColorInGroupLCI"
            Me.varyColorInGroupLCI.Size = New System.Drawing.Size(229, 22)
            Me.varyColorInGroupLCI.TextSize = New System.Drawing.Size(0, 0)
            Me.varyColorInGroupLCI.TextVisible = False
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.sunburstControl1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sidePanel1.Location = New System.Drawing.Point(0, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(546, 571)
            Me.sidePanel1.TabIndex = 2
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' SunburstGrouping
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.sidePanel1)
            Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.Name = "SunburstGrouping"
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.Controls.SetChildIndex(Me.sidePanel1, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((Me.sunburstControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.displayModeCBE.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.autoLayoutCE.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupInteraction1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.displayModeLCI1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.varyColorInGroupLCI), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private sunburstControl1 As DevExpress.XtraTreeMap.SunburstControl

        Private toolTipController1 As DevExpress.Utils.ToolTipController

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private displayModeCBE As DevExpress.XtraEditors.ComboBoxEdit

        Private autoLayoutCE As DevExpress.XtraEditors.CheckEdit

        Private emptySpaceItem As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroupInteraction1 As DevExpress.XtraLayout.LayoutControlGroup

        Private displayModeLCI1 As DevExpress.XtraLayout.LayoutControlItem

        Private varyColorInGroupLCI As DevExpress.XtraLayout.LayoutControlItem

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel
    End Class
End Namespace
