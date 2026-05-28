Namespace DevExpress.XtraTreeMap.Demos

    Partial Class HeatmapHeightmap

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
            Dim heatmapTitle2 As DevExpress.XtraCharts.Heatmap.HeatmapTitle = New DevExpress.XtraCharts.Heatmap.HeatmapTitle()
            Me.heatmapControl1 = New DevExpress.XtraCharts.Heatmap.HeatmapControl()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControl2 = New DevExpress.XtraLayout.LayoutControl()
            Me.colorizerComboBox = New DevExpress.XtraEditors.RadioGroup()
            Me.navigationCheckEdit = New DevExpress.XtraEditors.CheckEdit()
            Me.Root2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl2.SuspendLayout()
            CType((Me.colorizerComboBox.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.navigationCheckEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl2)
            Me.tabNavigationPageOptions.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(322, 706)
            ' 
            ' heatmapControl1
            ' 
            Me.heatmapControl1.EnableAxisXScrolling = True
            Me.heatmapControl1.EnableAxisXZooming = True
            Me.heatmapControl1.EnableAxisYScrolling = True
            Me.heatmapControl1.EnableAxisYZooming = True
            Me.heatmapControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.heatmapControl1.Location = New System.Drawing.Point(0, 0)
            Me.heatmapControl1.Margin = New System.Windows.Forms.Padding(0)
            Me.heatmapControl1.Name = "heatmapControl1"
            Me.heatmapControl1.Padding = New System.Windows.Forms.Padding(7, 7, 7, 7)
            Me.heatmapControl1.Size = New System.Drawing.Size(728, 747)
            Me.heatmapControl1.TabIndex = 0
            Me.heatmapControl1.Text = "heatmapControl1"
            heatmapTitle2.Text = "Heightmap"
            Me.heatmapControl1.Titles.Add(heatmapTitle2)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.heatmapControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(593, 306, 650, 400)
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(728, 747)
            Me.layoutControl1.TabIndex = 1
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.GroupStyle = DevExpress.Utils.GroupStyle.Light
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem3})
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.Root.Size = New System.Drawing.Size(728, 747)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.heatmapControl1
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem3.Size = New System.Drawing.Size(728, 747)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControl2
            ' 
            Me.layoutControl2.Controls.Add(Me.colorizerComboBox)
            Me.layoutControl2.Controls.Add(Me.navigationCheckEdit)
            Me.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.layoutControl2.Name = "layoutControl2"
            Me.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(-4, 627, 650, 400)
            Me.layoutControl2.Root = Me.Root2
            Me.layoutControl2.Size = New System.Drawing.Size(322, 706)
            Me.layoutControl2.TabIndex = 0
            Me.layoutControl2.Text = "layoutControl2"
            ' 
            ' colorizerComboBox
            ' 
            Me.colorizerComboBox.Location = New System.Drawing.Point(16, 43)
            Me.colorizerComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.colorizerComboBox.MenuManager = Me
            Me.colorizerComboBox.Name = "colorizerComboBox"
            Me.colorizerComboBox.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.colorizerComboBox.Properties.Appearance.Options.UseBackColor = True
            Me.colorizerComboBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.colorizerComboBox.Properties.Columns = 1
            Me.colorizerComboBox.Size = New System.Drawing.Size(290, 20)
            Me.colorizerComboBox.StyleController = Me.layoutControl2
            Me.colorizerComboBox.TabIndex = 4
            AddHandler Me.colorizerComboBox.SelectedIndexChanged, New System.EventHandler(AddressOf Me.ColorizerComboBox_SelectedIndexChanged)
            ' 
            ' navigationCheckEdit
            ' 
            Me.navigationCheckEdit.EditValue = True
            Me.navigationCheckEdit.Location = New System.Drawing.Point(16, 122)
            Me.navigationCheckEdit.MenuManager = Me
            Me.navigationCheckEdit.Name = "navigationCheckEdit"
            Me.navigationCheckEdit.Properties.Caption = "Enabled"
            Me.navigationCheckEdit.Size = New System.Drawing.Size(290, 24)
            Me.navigationCheckEdit.StyleController = Me.layoutControl2
            Me.navigationCheckEdit.TabIndex = 5
            AddHandler Me.navigationCheckEdit.CheckedChanged, New System.EventHandler(AddressOf Me.navigationCheckEdit_CheckedChanged)
            ' 
            ' Root2
            ' 
            Me.Root2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root2.GroupBordersVisible = False
            Me.Root2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlGroup1, Me.layoutControlGroup2})
            Me.Root2.Name = "Root"
            Me.Root2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.Root2.Size = New System.Drawing.Size(322, 706)
            Me.Root2.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 162)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(322, 544)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(322, 79)
            Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Text = "Color Provider"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.colorizerComboBox
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(296, 26)
            Me.layoutControlItem2.Text = "Colorizer"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 79)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(322, 83)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "Navigation"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.navigationCheckEdit
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(296, 30)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' HeatmapHeightmap
            ' 
            Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 17F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
            Me.Name = "HeatmapHeightmap"
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.Controls.SetChildIndex(Me.layoutControl1, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl2.ResumeLayout(False)
            CType((Me.colorizerComboBox.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.navigationCheckEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private heatmapControl1 As DevExpress.XtraCharts.Heatmap.HeatmapControl

        Private layoutControl2 As DevExpress.XtraLayout.LayoutControl

        Private Root2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private colorizerComboBox As DevExpress.XtraEditors.RadioGroup

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private navigationCheckEdit As DevExpress.XtraEditors.CheckEdit

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
