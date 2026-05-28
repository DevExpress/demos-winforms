Imports DevExpress.XtraEditors

Namespace DevExpress.XtraTreeMap.Demos

    Partial Class HeatmapEmptyCells

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
            Dim heatmapRangeColorProvider1 As DevExpress.XtraCharts.Heatmap.HeatmapRangeColorProvider = New DevExpress.XtraCharts.Heatmap.HeatmapRangeColorProvider()
            Dim heatmapRangeStop1 As DevExpress.XtraCharts.Heatmap.HeatmapRangeStop = New DevExpress.XtraCharts.Heatmap.HeatmapRangeStop()
            Dim heatmapRangeStop2 As DevExpress.XtraCharts.Heatmap.HeatmapRangeStop = New DevExpress.XtraCharts.Heatmap.HeatmapRangeStop()
            Dim heatmapRangeStop3 As DevExpress.XtraCharts.Heatmap.HeatmapRangeStop = New DevExpress.XtraCharts.Heatmap.HeatmapRangeStop()
            Dim heatmapRangeStop4 As DevExpress.XtraCharts.Heatmap.HeatmapRangeStop = New DevExpress.XtraCharts.Heatmap.HeatmapRangeStop()
            Dim heatmapRangeStop5 As DevExpress.XtraCharts.Heatmap.HeatmapRangeStop = New DevExpress.XtraCharts.Heatmap.HeatmapRangeStop()
            Dim heatmapRangeStop6 As DevExpress.XtraCharts.Heatmap.HeatmapRangeStop = New DevExpress.XtraCharts.Heatmap.HeatmapRangeStop()
            Dim heatmapDataSourceAdapter1 As DevExpress.XtraCharts.Heatmap.HeatmapDataSourceAdapter = New DevExpress.XtraCharts.Heatmap.HeatmapDataSourceAdapter()
            Dim heatmapTitle1 As DevExpress.XtraCharts.Heatmap.HeatmapTitle = New DevExpress.XtraCharts.Heatmap.HeatmapTitle()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.heatmapControl1 = New DevExpress.XtraCharts.Heatmap.HeatmapControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.colorPickEdit1 = New DevExpress.XtraEditors.ColorPickEdit()
            Me.highlightModeComboBoxEdit = New DevExpress.XtraEditors.RadioGroup()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroupInteraction = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroupInteraction1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.colorPickEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.highlightModeComboBoxEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupInteraction), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupInteraction1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.tabNavigationPageOptions.Margin = New System.Windows.Forms.Padding(7)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(322, 706)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.heatmapControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Margin = New System.Windows.Forms.Padding(4)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(593, 279, 650, 400)
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(728, 747)
            Me.layoutControl1.TabIndex = 1
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' heatmapControl1
            ' 
            Me.heatmapControl1.AxisX.Title.Text = ""
            Me.heatmapControl1.AxisY.Title.Text = ""
            Me.heatmapControl1.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            heatmapRangeColorProvider1.ApproximateColors = True
            heatmapRangeColorProvider1.LegendItemPattern = "${V1:N0} - ${V2:N0}"
            heatmapRangeColorProvider1.PaletteName = "Product Sales"
            heatmapRangeStop1.Value = 0R
            heatmapRangeStop2.Value = 250R
            heatmapRangeStop3.Value = 500R
            heatmapRangeStop4.Value = 1000R
            heatmapRangeStop5.Value = 5000R
            heatmapRangeStop6.Value = 15000R
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop1)
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop2)
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop3)
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop4)
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop5)
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop6)
            Me.heatmapControl1.ColorProvider = heatmapRangeColorProvider1
            heatmapDataSourceAdapter1.ColorDataMember = "SalesVolume"
            heatmapDataSourceAdapter1.XArgumentDataMember = "SalesPerson"
            heatmapDataSourceAdapter1.YArgumentDataMember = "ProductName"
            Me.heatmapControl1.DataAdapter = heatmapDataSourceAdapter1
            Me.heatmapControl1.Label.Pattern = "{V:N0}"
            Me.heatmapControl1.Label.Visible = True
            Me.heatmapControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            Me.heatmapControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
            Me.heatmapControl1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.heatmapControl1.Legend.HorizontalIndent = 20
            Me.heatmapControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.heatmapControl1.Location = New System.Drawing.Point(0, 0)
            Me.heatmapControl1.Margin = New System.Windows.Forms.Padding(4)
            Me.heatmapControl1.Name = "heatmapControl1"
            Me.heatmapControl1.PaletteRepository.Add("Product Sales", New DevExpress.XtraCharts.Palette("Product Sales", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((170)))))), (CInt(((CByte((230)))))), (CInt(((CByte((218))))))), System.Drawing.Color.FromArgb((CInt(((CByte((170)))))), (CInt(((CByte((230)))))), (CInt(((CByte((218)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((132)))))), (CInt(((CByte((209)))))), (CInt(((CByte((206))))))), System.Drawing.Color.FromArgb((CInt(((CByte((132)))))), (CInt(((CByte((209)))))), (CInt(((CByte((206)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((93)))))), (CInt(((CByte((185)))))), (CInt(((CByte((182))))))), System.Drawing.Color.FromArgb((CInt(((CByte((93)))))), (CInt(((CByte((185)))))), (CInt(((CByte((182)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((60)))))), (CInt(((CByte((163)))))), (CInt(((CByte((175))))))), System.Drawing.Color.FromArgb((CInt(((CByte((60)))))), (CInt(((CByte((163)))))), (CInt(((CByte((175)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((18)))))), (CInt(((CByte((131)))))), (CInt(((CByte((163))))))), System.Drawing.Color.FromArgb((CInt(((CByte((18)))))), (CInt(((CByte((131)))))), (CInt(((CByte((163))))))))}))
            Me.heatmapControl1.Size = New System.Drawing.Size(728, 747)
            Me.heatmapControl1.TabIndex = 4
            Me.heatmapControl1.Text = "heatmapControl1"
            heatmapTitle1.Text = "Product Sales"
            Me.heatmapControl1.Titles.Add(heatmapTitle1)
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
            Me.layoutControlItem1.Control = Me.heatmapControl1
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
            Me.layoutControl.Controls.Add(Me.colorPickEdit1)
            Me.layoutControl.Controls.Add(Me.highlightModeComboBoxEdit)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Margin = New System.Windows.Forms.Padding(4)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.Root = Me.layoutControlGroupRoot
            Me.layoutControl.Size = New System.Drawing.Size(322, 706)
            Me.layoutControl.TabIndex = 2
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' colorPickEdit1
            ' 
            Me.colorPickEdit1.EditValue = System.Drawing.Color.Empty
            Me.colorPickEdit1.Location = New System.Drawing.Point(12, 119)
            Me.colorPickEdit1.Margin = New System.Windows.Forms.Padding(4)
            Me.colorPickEdit1.MenuManager = Me
            Me.colorPickEdit1.Name = "colorPickEdit1"
            Me.colorPickEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.colorPickEdit1.Properties.Appearance.Options.UseBackColor = True
            Me.colorPickEdit1.Properties.AutomaticColor = System.Drawing.Color.Black
            Me.colorPickEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.colorPickEdit1.Size = New System.Drawing.Size(298, 22)
            Me.colorPickEdit1.StyleController = Me.layoutControl
            Me.colorPickEdit1.TabIndex = 5
            AddHandler Me.colorPickEdit1.ColorChanged, New System.EventHandler(AddressOf Me.DiagramColorChanged)
            ' 
            ' highlightModeComboBoxEdit
            ' 
            Me.highlightModeComboBoxEdit.Location = New System.Drawing.Point(12, 39)
            Me.highlightModeComboBoxEdit.Margin = New System.Windows.Forms.Padding(4)
            Me.highlightModeComboBoxEdit.MenuManager = Me
            Me.highlightModeComboBoxEdit.Name = "highlightModeComboBoxEdit"
            Me.highlightModeComboBoxEdit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.highlightModeComboBoxEdit.Properties.Appearance.Options.UseBackColor = True
            Me.highlightModeComboBoxEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.highlightModeComboBoxEdit.Size = New System.Drawing.Size(298, 29)
            Me.highlightModeComboBoxEdit.StyleController = Me.layoutControl
            Me.highlightModeComboBoxEdit.TabIndex = 4
            AddHandler Me.highlightModeComboBoxEdit.SelectedIndexChanged, New System.EventHandler(AddressOf Me.HighlightModeChanged)
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroupInteraction, Me.emptySpaceItem, Me.layoutControlGroupInteraction1})
            Me.layoutControlGroupRoot.Name = "Root"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(322, 706)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' layoutControlGroupInteraction
            ' 
            Me.layoutControlGroupInteraction.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupInteraction.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2})
            Me.layoutControlGroupInteraction.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupInteraction.Name = "layoutControlGroupInteraction"
            Me.layoutControlGroupInteraction.Size = New System.Drawing.Size(322, 80)
            Me.layoutControlGroupInteraction.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupInteraction.Text = "Highlight Mode"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.highlightModeComboBoxEdit
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(302, 33)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' emptySpaceItem
            ' 
            Me.emptySpaceItem.AllowHotTrack = False
            Me.emptySpaceItem.Location = New System.Drawing.Point(0, 153)
            Me.emptySpaceItem.Name = "emptySpaceItem"
            Me.emptySpaceItem.Size = New System.Drawing.Size(322, 553)
            Me.emptySpaceItem.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlGroupInteraction1
            ' 
            Me.layoutControlGroupInteraction1.CustomizationFormText = "Diagram Color"
            Me.layoutControlGroupInteraction1.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupInteraction1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem3})
            Me.layoutControlGroupInteraction1.Location = New System.Drawing.Point(0, 80)
            Me.layoutControlGroupInteraction1.Name = "layoutControlGroupInteraction1"
            Me.layoutControlGroupInteraction1.OptionsItemText.TextToControlDistance = 3
            Me.layoutControlGroupInteraction1.Size = New System.Drawing.Size(322, 73)
            Me.layoutControlGroupInteraction1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupInteraction1.Text = "Diagram Background"
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.colorPickEdit1
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(302, 26)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 0)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(0, 0)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' HeatmapEmptyCells
            ' 
            Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 17F)
            Me.Controls.Add(Me.layoutControl1)
            Me.Margin = New System.Windows.Forms.Padding(7)
            Me.Name = "HeatmapEmptyCells"
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.Controls.SetChildIndex(Me.layoutControl1, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.colorPickEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.highlightModeComboBoxEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupInteraction), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupInteraction1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroupInteraction As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private heatmapControl1 As DevExpress.XtraCharts.Heatmap.HeatmapControl

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroupInteraction1 As DevExpress.XtraLayout.LayoutControlGroup

        Private colorPickEdit1 As DevExpress.XtraEditors.ColorPickEdit

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private highlightModeComboBoxEdit As DevExpress.XtraEditors.RadioGroup
    End Class
End Namespace
